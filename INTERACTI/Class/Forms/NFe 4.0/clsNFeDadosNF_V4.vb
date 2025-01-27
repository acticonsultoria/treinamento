Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.NFe.AssinaturaDigital_V4
Imports INTERACTI.NFe.RecepcaoLote_V4
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.SQLHelper


Enum Imposto

    ICMS = 0
    IPI = 1
    II = 2
    ISSQN = 3



End Enum

Namespace NFe

    Public NotInheritable Class DadosNF

#Region "::: FUNCTION / SUB :::"

        Public Overloads Shared Function ArquivoNFe(ByVal lLote As Long, _
                                                    ByRef sArquivo As String, _
                                                    ByRef sMensagemErro As String, _
                                                    ByRef sChaveAcesso As String) As Boolean

            'Variaveis LocaisDefineEnum(goEmitente.iUF, TCOrgaoIBGE)
            Dim oTNFe As New TNFe
            Dim oXMLDocument As XmlDocument

            Try

                'Dados da Nota Fiscal Eletronica
                Call NFe_A_Dados(oTNFe)                 'Dados
                Call NFe_B_Identificacao(oTNFe, lLote)  'Identificação            

                'Pré Chave de Acesso
                sChaveAcesso = goConfiguracaoNFe.sCodigoEstado & _
                               Format(CDate(oTNFe.infNFe.ide.dhEmi), "yyMM") & _
                               Format(oTNFe.infNFe.emit.Item) & _
                               "55" & _
                               oTNFe.infNFe.ide.serie.ToString().PadLeft(3, "0") & _
                               oTNFe.infNFe.ide.nNF.ToString().PadLeft(9, "0") & _
                               CInt(goConfiguracaoNFe.iModoOperacaoNFe) & _
                               oTNFe.infNFe.ide.cNF.ToString().PadLeft(8, "0")

                'Digito Verificador
                oTNFe.infNFe.ide.cDV = DvBase11(sChaveAcesso)
                'Chave de Acesso
                sChaveAcesso = oTNFe.infNFe.Id & sChaveAcesso & oTNFe.infNFe.ide.cDV
                oTNFe.infNFe.Id = "NFe" & sChaveAcesso

                'Seta Arquivo
                sArquivo = goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sChaveAcesso & ".xml"

                'Salva Arquivo XML
                'oTNFe.Save(sArquivo)vBCFCPUFDest

                Try
                    'Salva Arquivo XML
                    oTNFe.Save(sArquivo)

                Catch ex As Exception

                    Try
                        MsgBox(ex.InnerException.Message)
                        sMensagemErro = ex.InnerException.Message
                        Return False
                    Catch ex2 As Exception

                        MsgBox(ex2.Message)
                        sMensagemErro = ex2.Message
                        Return False
                    End Try

                End Try

                Dim oTempReader As New StreamReader(sArquivo)
                Dim sDados As String = oTempReader.ReadToEnd
                oTempReader.Close()

                sDados = Replace(sDados, "<motDesICMS>3</motDesICMS>", "")
                sDados = Replace(sDados, "<vICMSDeson>1.00</vICMSDeson>", "")

                Dim oTempWriter As New StreamWriter(sArquivo)
                oTempWriter.WriteLine(sDados)
                oTempWriter.Close()

                Try

                    'Assina Arquivo
                    oXMLDocument = AssinarXML(sArquivo, "infNFe")


                Catch ex As Exception
                    oTNFe = Nothing
                    'Exclui Arquivo XML (NFe)
                    File.Delete(sArquivo)
                    'Seta Informação
                    sMensagemErro = "Ocorreu um erro ao tentar assinar o Arquivo XML." & vbCrLf & ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Exclui Arquivo XML (NFe)
                File.Delete(sArquivo)

                'Seta Arquivo 
                sArquivo = goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sChaveAcesso & "-ass.xml"
                'Salva Arquivo XML Assinado
                oXMLDocument.Save(sArquivo)

                'Valida Arquivo XML Assinado
                Dim sRetornoValidacao As String = ""

                'Verifica se Encontrou algum Erro no Arquivo XML
                sRetornoValidacao = ValidaArquivoXML(sArquivo, _
                                                     goConfiguracaoNFe.sPastaXSD & "nfe_v4.00.xsd")

                'Verifica se ocorreu algum erro na Validação
                If sRetornoValidacao <> "" Then

                    'Limpa Váriavel
                    oTNFe = Nothing
                    'Seta Informação
                    sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                    'Informa o Erro Ocorrigo
                    MsgBox(sMensagemErro, MsgBoxStyle.Exclamation, "Erro")
                    'Retorno da Função
                    Return False

                Else

                    'Obtem Tamanho do Arquivo XML
                    Dim oFileInfo As New FileInfo(sArquivo)

                    'Verifica se o Tamanho do Arquivo XML é maior que o Tamanho Máximo
                    If (oFileInfo.Length / 1000) > goConfiguracaoNFe.iTamanhoMaximo Then
                        'Limpa Váriavel
                        oTNFe = Nothing
                        'Seta Informação
                        sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                        'Retorno da Função
                        Return False
                    End If

                    'Inclui Lote no Arquivo XML
                    Dim sArquivoLote = IncluiLoteNFe(sArquivo, _
                                                     "", _
                                                     Format(lLote, "000000"))

                    'Exclui Arquivo XML
                    File.Delete(sArquivo)

                    If sArquivoLote <> "ERROR" Then
                        'Seta Arquivo
                        sArquivo = sArquivoLote
                        'Seta Retorno da Função
                        Return True
                    Else
                        'Seta Retorno da Função
                        Return False
                    End If

                End If

            Catch ex As Exception
                oTNFe = Nothing
                sMensagemErro = ex.Message
                Return False
            End Try

        End Function

        Private Overloads Shared Sub NFe_A_Dados(ByRef oTNFe As TNFe)

            Try

                'Váriaveis Locais
                oTNFe.infNFe = New TNFeInfNFe

                'Dados da Nota Fislca
                oTNFe.infNFe.versao = "4.00"
                oTNFe.infNFe.Id = ""

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_B_Identificacao(ByRef oTNFe As TNFe, _
                                                         ByVal lLote As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim oRandom As New Random
                Dim iRandom As Integer = oRandom.Next(99999999)
                Dim i As Integer

                'Seta Parametros - Lote
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "lote"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = lLote : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_identificacao_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Váriaveis Locais
                    oTNFe.infNFe.ide = New TNFeInfNFeIde

                    While oSqlDataReader.Read

                        oTNFe.infNFe.ide.idDest = DefineEnum(oSqlDataReader.Item("idDest"), GetType(TNFeInfNFeIdeIdDest))
                        oTNFe.infNFe.ide.indPres = DefineEnum(oSqlDataReader.Item("indPres"), GetType(TNFeInfNFeIdeIndPres))
                        oTNFe.infNFe.ide.indFinal = DefineEnum(oSqlDataReader.Item("indFinal"), GetType(TNFeInfNFeIdeIndFinal))

                        oTNFe.infNFe.ide.cUF = DefineEnum(oSqlDataReader.Item("cUF"), GetType(TCodUfIBGE))
                        oTNFe.infNFe.ide.cNF = Format(iRandom, "00000000")
                        oTNFe.infNFe.ide.natOp = RetirarAcento(oSqlDataReader.Item("natOP"))
                        'oTNFe.infNFe.ide.indpag = DefineEnum(oSqlDataReader.Item("indPag"), GetType(TNFeInfNFeIdeIndPag))
                        oTNFe.infNFe.ide.mod = DefineEnum(oSqlDataReader.Item("mod"), GetType(TMod))
                        oTNFe.infNFe.ide.serie = oSqlDataReader.Item("serie")
                        oTNFe.infNFe.ide.nNF = oSqlDataReader.Item("nNF")
                        oTNFe.infNFe.ide.dhEmi = Format(CDate(oSqlDataReader.Item("dEmi")), "yyyy-MM-ddThh:mm:ss" + "-03:00")
                        oTNFe.infNFe.ide.dhSaiEnt = Format(CDate(oSqlDataReader.Item("dSaiEnt")), "yyyy-MM-ddThh:mm:ss" + "-03:00")
                        oTNFe.infNFe.ide.tpNF = DefineEnum(oSqlDataReader.Item("tpNF"), GetType(TNFeInfNFeIdeTpNF))
                        oTNFe.infNFe.ide.cMunFG = oSqlDataReader.Item("cMunFG")
                        oTNFe.infNFe.ide.tpImp = DefineEnum(oSqlDataReader.Item("tpImp"), GetType(TNFeInfNFeIdeTpImp))
                        oTNFe.infNFe.ide.tpEmis = DefineEnum(oSqlDataReader.Item("tpEmis"), GetType(TNFeInfNFeIdeTpEmis))
                        oTNFe.infNFe.ide.tpAmb = DefineEnum(goConfiguracaoNFe.iCodigoTipoAmbienteNFe, GetType(TAmb))
                        oTNFe.infNFe.ide.finNFe = DefineEnum(oSqlDataReader.Item("finNFe"), GetType(TFinNFe))
                        oTNFe.infNFe.ide.procEmi = DefineEnum(oSqlDataReader.Item("procEmi"), GetType(TProcEmi))
                        oTNFe.infNFe.ide.verProc = gcVersaoNFe & "3.0"

                        Call NFe_B_Referencia_NFe(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                'Referência
                        Call NFe_C_Emitente(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                      'Emitente
                        Call NFe_E_Destinatario(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                  'Destinatário
                        Call NFe_F_LocalRetirada(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                 'Local Retirada
                        Call NFe_G_LocalEntrega(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                  'Local Entrega
                        Call NFe_GA_AutorizacaoXML(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                  'Local Entrega
                        Call NFe_H_DetalhamentoProduto(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))           'Detalhamento Produto
                        Call NFe_W_Total(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                         'Total
                        Call NFe_X_Transporte(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                    'Transporte
                        Call NFe_Y_Cobranca(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                      'Cobrança
                        Call NFe_YA_Pagamento(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))                      'Pagamento
                        Call NFe_Z_InformacoesAdicionais(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))         'Informações Adicionais
                        Call NFe_ZA_InformacoesComercioExterior(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))  'Informações de Comércio Exterior
                        Call NFe_ZB_InformacoesCompras(oTNFe, oSqlDataReader.Item("codigo_emissao_capa"))           'Informações de Compras

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_B_Referencia_NFe(ByRef oTNFe As TNFe, _
                                                          ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim i As Integer = 0
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_identificacao_referencia", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        Select Case oSqlDataReader.Item("codigo_tipo_nota_fiscal")

                            Case CInt(TipoNotaFiscal.NotaFiscalEletronica)
                                'Redimensiona o Vetor de NF Referencia
                                ReDim Preserve oTNFe.infNFe.ide.NFref(i)
                                oTNFe.infNFe.ide.NFref(i) = New TNFeInfNFeIdeNFref
                                'Seta Parâmetros
                                oTNFe.infNFe.ide.NFref(i).ItemElementName = ItemChoiceType1.refNFe
                                oTNFe.infNFe.ide.NFref(i).Item = oSqlDataReader.Item("refNFe")

                            Case CInt(TipoNotaFiscal.NotaFiscal)
                                'Redimensiona o Vetor de NF Referencia
                                ReDim Preserve oTNFe.infNFe.ide.NFref(i)
                                'Seta Parâmetros
                                oTNFe.infNFe.ide.NFref(i).ItemElementName = ItemChoiceType1.refNF
                                'Váriavel de Referência - NF
                                Dim oTNFeInfNFeIdeNFrefRefNF As New TNFeInfNFeIdeNFrefRefNF
                                'Seta Parâmetros
                                oTNFeInfNFeIdeNFrefRefNF.AAMM = oSqlDataReader.Item("AAMM")
                                oTNFeInfNFeIdeNFrefRefNF.CNPJ = oSqlDataReader.Item("CNPJ")
                                oTNFeInfNFeIdeNFrefRefNF.cUF = oSqlDataReader.Item("cUF")
                                oTNFeInfNFeIdeNFrefRefNF.mod = oSqlDataReader.Item("mod")
                                oTNFeInfNFeIdeNFrefRefNF.nNF = oSqlDataReader.Item("nNF")
                                oTNFeInfNFeIdeNFrefRefNF.serie = oSqlDataReader.Item("serie")
                                oTNFe.infNFe.ide.NFref(i).Item = oTNFeInfNFeIdeNFrefRefNF

                        End Select

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_C_Emitente(ByRef oTNFe As TNFe, _
                                                    ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_emitente_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Váriaveis Locais
                    oTNFe.infNFe.emit = New TNFeInfNFeEmit

                    While oSqlDataReader.Read

                        'Dados do Emitente
                        oTNFe.infNFe.emit.ItemElementName = ItemChoiceType.CNPJ
                        oTNFe.infNFe.emit.Item = oSqlDataReader.Item("cnpj")
                        oTNFe.infNFe.emit.xNome = RetirarAcento(oSqlDataReader.Item("xNome"))
                        If oSqlDataReader.Item("xFant") <> "" Then oTNFe.infNFe.emit.xFant = RetirarAcento(oSqlDataReader.Item("xFant"))
                        oTNFe.infNFe.emit.IE = oSqlDataReader.Item("IE")
                        If oSqlDataReader.Item("IEST") <> "" Then oTNFe.infNFe.emit.IEST = oSqlDataReader.Item("IEST")
                        If oSqlDataReader.Item("IM") <> "" Then oTNFe.infNFe.emit.IM = oSqlDataReader.Item("IM")
                        If oSqlDataReader.Item("CNAE") <> "" Then oTNFe.infNFe.emit.CNAE = oSqlDataReader.Item("CNAE")
                        oTNFe.infNFe.emit.CRT = DefineEnum(oSqlDataReader.Item("CRT"), GetType(TNFeInfNFeEmitCRT))
                        'Endereço do Emitente
                        oTNFe.infNFe.emit.enderEmit = New TEnderEmi
                        oTNFe.infNFe.emit.enderEmit.xLgr = RetirarAcento(oSqlDataReader.Item("xLgr"))
                        oTNFe.infNFe.emit.enderEmit.nro = RetirarAcento(oSqlDataReader.Item("nro"))
                        If oSqlDataReader.Item("xCpl") <> "" Then oTNFe.infNFe.emit.enderEmit.xCpl = RetirarAcento(oSqlDataReader.Item("xCpl"))
                        oTNFe.infNFe.emit.enderEmit.xBairro = RetirarAcento(oSqlDataReader.Item("xBairro"))
                        oTNFe.infNFe.emit.enderEmit.cMun = oSqlDataReader.Item("cMun")
                        If oSqlDataReader.Item("xMun") <> "" Then oTNFe.infNFe.emit.enderEmit.xMun = RetirarAcento(oSqlDataReader.Item("xMun"))
                        oTNFe.infNFe.emit.enderEmit.UF = DefineUF(oSqlDataReader.Item("UF"))
                        If oSqlDataReader.Item("CEP") <> "" Then oTNFe.infNFe.emit.enderEmit.CEP = oSqlDataReader.Item("CEP")
                        If oSqlDataReader.Item("cPais") <> "" Then oTNFe.infNFe.emit.enderEmit.cPais = TEnderEmiCPais.Item1058 : oTNFe.infNFe.emit.enderEmit.cPaisSpecified = True
                        If oSqlDataReader.Item("xPais") <> "" Then oTNFe.infNFe.emit.enderEmit.xPais = TEnderEmiXPais.Brasil : oTNFe.infNFe.emit.enderEmit.xPaisSpecified = True
                        If oSqlDataReader.Item("fone") <> "" Then oTNFe.infNFe.emit.enderEmit.fone = RetirarAcento(oSqlDataReader.Item("fone"))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_E_Destinatario(ByRef oTNFe As TNFe, _
                                                        ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_destinatario_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Instancia Destinatário
                    oTNFe.infNFe.dest = New TNFeInfNFeDest

                    While oSqlDataReader.Read

                        'Dados do Destinatário
                        If oSqlDataReader.Item("uf") <> "EX" Then
                            oTNFe.infNFe.dest.ItemElementName = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.fisica, ItemChoiceType.CPF, ItemChoiceType.CNPJ)
                            oTNFe.infNFe.dest.Item = oSqlDataReader.Item("cnpj_cpf")
                        Else
                            oTNFe.infNFe.dest.ItemElementName = ItemChoiceType3.idEstrangeiro
                            oTNFe.infNFe.dest.Item = oSqlDataReader.Item("idEstrangeiro")

                        End If
                        If Not IsDBNull(oSqlDataReader.Item("IE")) Then
                            If oSqlDataReader.Item("IE") <> "ISENTO" And oSqlDataReader.Item("IE") <> "" Then
                                oTNFe.infNFe.dest.IE = oSqlDataReader.Item("IE")
                                oTNFe.infNFe.dest.indIEDest = DefineEnum(oSqlDataReader.Item("indIEDest"), GetType(TNFeInfNFeDestIndIEDest))
                            Else
                                oTNFe.infNFe.dest.indIEDest = TNFeInfNFeDestIndIEDest.Item9
                            End If
                        Else
                            oTNFe.infNFe.dest.indIEDest = TNFeInfNFeDestIndIEDest.Item9
                        End If

                        oTNFe.infNFe.dest.xNome = RetirarAcento(oSqlDataReader.Item("xNome"))

                        If oSqlDataReader.Item("ISUF") <> "" Then oTNFe.infNFe.dest.ISUF = oSqlDataReader.Item("ISUF")

                        'Endereço do Destinatário
                        oTNFe.infNFe.dest.enderDest = New TEndereco()
                        oTNFe.infNFe.dest.enderDest.xLgr = RetirarAcento(oSqlDataReader.Item("xLgr"))
                        oTNFe.infNFe.dest.enderDest.nro = RetirarAcento(oSqlDataReader.Item("nro"))
                        If oSqlDataReader.Item("xCpl") <> "" Then oTNFe.infNFe.dest.enderDest.xCpl = RetirarAcento(oSqlDataReader.Item("xCpl"))
                        oTNFe.infNFe.dest.enderDest.xBairro = RetirarAcento(oSqlDataReader.Item("xBairro"))
                        oTNFe.infNFe.dest.enderDest.cMun = oSqlDataReader.Item("cMun")
                        If oSqlDataReader.Item("xMun") <> "" Then oTNFe.infNFe.dest.enderDest.xMun = RetirarAcento(oSqlDataReader.Item("xMun"))
                        oTNFe.infNFe.dest.enderDest.UF = DefineUF(oSqlDataReader.Item("UF"))
                        If oSqlDataReader.Item("CEP") <> "" Then oTNFe.infNFe.dest.enderDest.CEP = RetirarAcento(oSqlDataReader.Item("CEP"))
                        If oSqlDataReader.Item("cPais") <> "" Then oTNFe.infNFe.dest.enderDest.cPais = oSqlDataReader.Item("cPais") ': oTNFe.infNFe.dest.enderDest.cPaisSpecified = True
                        If oSqlDataReader.Item("xPais") <> "" Then oTNFe.infNFe.dest.enderDest.xPais = RetirarAcento(oSqlDataReader.Item("xPais"))
                        If oSqlDataReader.Item("fone") <> "" Then oTNFe.infNFe.dest.enderDest.fone = RetirarAcento(oSqlDataReader.Item("fone"))
                        If oSqlDataReader.Item("email") <> "" Then oTNFe.infNFe.dest.email = RetirarAcento(oSqlDataReader.Item("email"))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_F_LocalRetirada(ByRef oTNFe As TNFe, _
                                                         ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_local_retirada", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Váriaveis Locais
                    oTNFe.infNFe.retirada = New TLocal

                    While oSqlDataReader.Read

                        'Dados do Local de Retirada
                        oTNFe.infNFe.retirada.ItemElementName = ItemChoiceType4.CNPJ
                        oTNFe.infNFe.retirada.Item = oSqlDataReader.Item("CNPJ")
                        oTNFe.infNFe.retirada.xLgr = RetirarAcento(oSqlDataReader.Item("xLgr"))
                        oTNFe.infNFe.retirada.nro = RetirarAcento(oSqlDataReader.Item("nro"))
                        If Not IsDBNull(oSqlDataReader.Item("xCpl")) Then oTNFe.infNFe.retirada.xCpl = RetirarAcento(oSqlDataReader.Item("xCpl"))
                        oTNFe.infNFe.retirada.xBairro = RetirarAcento(oSqlDataReader.Item("xBairro"))
                        oTNFe.infNFe.retirada.cMun = oSqlDataReader.Item("cMun")
                        oTNFe.infNFe.retirada.xMun = RetirarAcento(oSqlDataReader.Item("xMun"))
                        oTNFe.infNFe.retirada.UF = DefineUF(oSqlDataReader.Item("UF"))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_G_LocalEntrega(ByRef oTNFe As TNFe, _
                                                        ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_local_entrega", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Váriaveis Locais
                    oTNFe.infNFe.entrega = New TLocal

                    While oSqlDataReader.Read

                        'Dados do Local de Entrega
                        oTNFe.infNFe.entrega.ItemElementName = ItemChoiceType4.CNPJ
                        oTNFe.infNFe.entrega.Item = oSqlDataReader.Item("CNPJ")
                        oTNFe.infNFe.entrega.xLgr = RetirarAcento(oSqlDataReader.Item("xLgr"))
                        oTNFe.infNFe.entrega.nro = RetirarAcento(oSqlDataReader.Item("nro"))
                        If Not IsDBNull(oSqlDataReader.Item("xCpl")) Then oTNFe.infNFe.entrega.xCpl = RetirarAcento(oSqlDataReader.Item("xCpl"))
                        oTNFe.infNFe.entrega.xBairro = RetirarAcento(oSqlDataReader.Item("xBairro"))
                        oTNFe.infNFe.entrega.cMun = oSqlDataReader.Item("cMun")
                        oTNFe.infNFe.entrega.xMun = RetirarAcento(oSqlDataReader.Item("xMun"))
                        oTNFe.infNFe.entrega.UF = DefineUF(oSqlDataReader.Item("UF"))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_GA_AutorizacaoXML(ByRef oTNFe As TNFe, _
                                                        ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_autorizacao", oSqlParameter)

                Dim iNumeroAutorizacao As Integer = 0

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                   
                    While oSqlDataReader.Read

                        'Váriaveis Locais
                        ReDim Preserve oTNFe.infNFe.autXML(iNumeroAutorizacao)
                        oTNFe.infNFe.autXML(iNumeroAutorizacao) = New TNFeInfNFeAutXML

                        oTNFe.infNFe.autXML(iNumeroAutorizacao).ItemElementName = IIf(oSqlDataReader.Item("codigo_personalidade") = Personalidade.Fisica, ItemChoiceType5.CPF, ItemChoiceType5.CNPJ)
                        oTNFe.infNFe.autXML(iNumeroAutorizacao).Item = oSqlDataReader.Item("cnpj_cpf")

                        'Incrementa
                        iNumeroAutorizacao += 1
                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_H_DetalhamentoProduto(ByRef oTNFe As TNFe, _
                                                               ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim iNumeroItem As Integer = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_detalhamento_item_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Redimensiona Vetor
                        ReDim Preserve oTNFe.infNFe.det(iNumeroItem)

                        oTNFe.infNFe.det(iNumeroItem) = New TNFeInfNFeDet
                        oTNFe.infNFe.det(iNumeroItem).nItem = iNumeroItem + 1
                        If Not IsDBNull(oSqlDataReader.Item("infAdProd")) Then oTNFe.infNFe.det(iNumeroItem).infAdProd = RetirarAcento(oSqlDataReader("infAdProd"))

                        'Carrega dados do produto, serviço
                        Call NFe_I_ProdutoServico(oTNFe.infNFe.det(iNumeroItem), _
                                                  lCodigoEmissaoCapa, _
                                                  oSqlDataReader.Item("codigo"))
                        'Impostos
                        Call NFe_M_Impostos(oTNFe.infNFe.det(iNumeroItem), _
                                            lCodigoEmissaoCapa, _
                                            oSqlDataReader.Item("codigo"))

                        iNumeroItem += 1

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_I_ProdutoServico(ByRef oTNFeItem As TNFeInfNFeDet, _
                                                          ByVal lCodigoEmissaoCapa As Long, _
                                                          ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = lCodigoEmissaoItem : i += 1

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        oTNFeItem.prod = New TNFeInfNFeDetProd

                        oTNFeItem.prod.cProd = RetirarAcento(oSqlDataReader.Item("cProd"))
                        'oTNFeItem.prod.cEAN = oSqlDataReader.Item("cEAN")
                        If Not IsDBNull(oSqlDataReader.Item("cEAN")) Then oTNFeItem.prod.cEAN = oSqlDataReader.Item("cEAN")
                        oTNFeItem.prod.xProd = RetirarAcento(oSqlDataReader.Item("xProd"))
                        oTNFeItem.prod.NCM = oSqlDataReader.Item("NCM")
                        If oSqlDataReader.Item("EX_TIPI") <> "" Then oTNFeItem.prod.EXTIPI = oSqlDataReader.Item("EX_TIPI")
                        oTNFeItem.prod.CFOP = oSqlDataReader.Item("CFOP")
                        oTNFeItem.prod.uCom = oSqlDataReader.Item("uCom")
                        oTNFeItem.prod.qCom = oSqlDataReader.Item("qCom")
                        oTNFeItem.prod.vUnCom = oSqlDataReader.Item("vUnCom")
                        oTNFeItem.prod.vProd = oSqlDataReader.Item("vProd")
                        'oTNFeItem.prod.cEANTrib = oSqlDataReader.Item("cEANTrib")
                        If Not IsDBNull(oSqlDataReader.Item("cEANTrib")) Then oTNFeItem.prod.cEANTrib = oSqlDataReader.Item("cEANTrib")
                        oTNFeItem.prod.uTrib = oSqlDataReader.Item("uTrib")
                        oTNFeItem.prod.qTrib = oSqlDataReader.Item("qTrib")
                        oTNFeItem.prod.vUnTrib = oSqlDataReader.Item("vUnTrib")
                        If Not IsDBNull(oSqlDataReader.Item("vFrete")) Then oTNFeItem.prod.vFrete = oSqlDataReader.Item("vFrete")
                        If Not IsDBNull(oSqlDataReader.Item("vSeg")) Then oTNFeItem.prod.vSeg = oSqlDataReader.Item("vSeg")
                        If Not IsDBNull(oSqlDataReader.Item("vDesc")) Then oTNFeItem.prod.vDesc = oSqlDataReader.Item("vDesc")
                        If Not IsDBNull(oSqlDataReader.Item("vOutro")) Then oTNFeItem.prod.vOutro = oSqlDataReader.Item("vOutro")
                        oTNFeItem.prod.indTot = IIf(oSqlDataReader("indTot") = True, TNFeInfNFeDetProdIndTot.Item1, TNFeInfNFeDetProdIndTot.Item0)
                        If Not IsDBNull(oSqlDataReader.Item("xPed")) Then oTNFeItem.prod.xPed = RetirarAcento(oSqlDataReader("xPed"))
                        If Not IsDBNull(oSqlDataReader.Item("nItemPed")) Then oTNFeItem.prod.nItemPed = RetirarAcento(oSqlDataReader("nItemPed"))
                        If Not IsDBNull(oSqlDataReader.Item("nFCI")) Then oTNFeItem.prod.nFCI = oSqlDataReader.Item("nFCI")

                        'DI
                        Call NFe_I_ProdutoServicoDI(oTNFeItem, _
                                                    lCodigoEmissaoCapa, _
                                                    lCodigoEmissaoItem)

                        'Exporta
                        Call NFe_I03_ProdutoServicoExporta(oTNFeItem, _
                                                    lCodigoEmissaoCapa, _
                                                    lCodigoEmissaoItem)

                   

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_I_ProdutoServicoDI(ByRef oTNFeItem As TNFeInfNFeDet, _
                                                            ByVal lCodigoEmissaoCapa As Long, _
                                                            ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim iDI As Integer = 0

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_di", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Redimensiona Vetor de DI
                        ReDim Preserve oTNFeItem.prod.DI(iDI)
                        oTNFeItem.prod.DI(iDI) = New TNFeInfNFeDetProdDI

                        'Seta Valores
                        oTNFeItem.prod.DI(iDI).nDI = oSqlDataReader.Item("nDI")
                        oTNFeItem.prod.DI(iDI).tpIntermedio = DefineEnum(oSqlDataReader.Item("tpIntermedio"), GetType(TNFeInfNFeDetProdDITpIntermedio))
                        oTNFeItem.prod.DI(iDI).tpViaTransp = DefineEnum(oSqlDataReader.Item("tpViaTransp"), GetType(TNFeInfNFeDetProdDITpViaTransp))
                        'Caso marítimo
                        If Not IsDBNull(oSqlDataReader.Item("vAFRMM")) Then oTNFeItem.prod.DI(iDI).vAFRMM = oSqlDataReader.Item("vAFRMM")

                        If Not IsDBNull(oSqlDataReader.Item("CNPJ")) Then
                            oTNFeItem.prod.DI(iDI).Item = oSqlDataReader.Item("CNPJ")
                            oTNFeItem.prod.DI(iDI).ItemElementName = ItemChoiceType6.CNPJ
                        End If

                        If Not IsDBNull(oSqlDataReader.Item("UFTerceiro")) Then
                            oTNFeItem.prod.DI(iDI).UFTerceiro = DefineUF(oSqlDataReader.Item("UFTerceiro"))
                            oTNFeItem.prod.DI(iDI).UFTerceiroSpecified = True
                        Else
                            oTNFeItem.prod.DI(iDI).UFTerceiroSpecified = False
                        End If

                        oTNFeItem.prod.DI(iDI).dDI = Format(CDate(oSqlDataReader.Item("dDI")), "yyyy-MM-dd")
                        oTNFeItem.prod.DI(iDI).xLocDesemb = oSqlDataReader.Item("xLocDesemb")
                        oTNFeItem.prod.DI(iDI).UFDesemb = DefineUF(oSqlDataReader.Item("UFDesemb"))
                        oTNFeItem.prod.DI(iDI).dDesemb = Format(CDate(oSqlDataReader.Item("dDesemb")), "yyyy-MM-dd")
                        oTNFeItem.prod.DI(iDI).cExportador = oSqlDataReader.Item("cExportador")

                        'Carrega Dados Adição
                        Call NFe_I_ProdutoServicoDIAdicao(oTNFeItem.prod.DI(iDI), _
                                                          lCodigoEmissaoCapa, _
                                                          lCodigoEmissaoItem)

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_I_ProdutoServicoDIAdicao(ByRef oTNFeItemDI As TNFeInfNFeDetProdDI, _
                                                                  ByVal lCodigoEmissaoCapa As Long, _
                                                                  ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim iAdicao As Integer = 0

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_di_adicao", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Redimensiona Vetor de Adição
                        ReDim Preserve oTNFeItemDI.adi(iAdicao)
                        oTNFeItemDI.adi(iAdicao) = New TNFeInfNFeDetProdDIAdi

                        'Seta Valores
                        If IsDBNull(oSqlDataReader.Item("nDraw")) = False Then
                            oTNFeItemDI.adi(iAdicao).nDraw = oSqlDataReader.Item("nDraw")
                        End If

                        oTNFeItemDI.adi(iAdicao).nAdicao = oSqlDataReader.Item("nAdicao")
                        oTNFeItemDI.adi(iAdicao).nSeqAdic = iAdicao + 1
                        oTNFeItemDI.adi(iAdicao).cFabricante = oSqlDataReader.Item("cFabricante")
                        If oSqlDataReader.Item("vDescDI") <> 0 Then oTNFeItemDI.adi(iAdicao).vDescDI = oSqlDataReader.Item("vDescDI")

                        iAdicao = iAdicao + 1

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_I03_ProdutoServicoExporta(ByRef oTNFeItem As TNFeInfNFeDet, _
                                                            ByVal lCodigoEmissaoCapa As Long, _
                                                            ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim iExporta As Integer = 0

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_exporta", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Redimensiona Vetor de Exportação do item
                        ReDim Preserve oTNFeItem.prod.detExport(iExporta)
                        oTNFeItem.prod.detExport(iExporta) = New TNFeInfNFeDetProdDetExport

                        'Seta Valores
                        If Not IsDBNull(oSqlDataReader.Item("dDraw")) Then oTNFeItem.prod.detExport(iExporta).nDraw = oSqlDataReader.Item("dDraw")
                        If Not IsDBNull(oSqlDataReader.Item("nRE")) Then oTNFeItem.prod.detExport(iExporta).exportInd.nRE = oSqlDataReader.Item("nRE")
                        If Not IsDBNull(oSqlDataReader.Item("qExport")) Then oTNFeItem.prod.detExport(iExporta).exportInd.qExport = oSqlDataReader.Item("qExport")
                        If Not IsDBNull(oSqlDataReader.Item("chNFe")) Then oTNFeItem.prod.detExport(iExporta).exportInd.chNFe = oSqlDataReader.Item("chNFe")

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_M_Impostos(ByRef oTNFeItem As TNFeInfNFeDet, _
                                                    ByVal lCodigoEmissaoCapa As Long, _
                                                    ByVal lCodigoEmissaoItem As Long)

            Try

                'Carrega Total de Imposto
                Dim sTotalImposto As String = CType(LoadDescricao("sp_select_faturamento_emissao_xml_item_imposto " & lCodigoEmissaoCapa & ", " & lCodigoEmissaoItem & ", " & goUsuario.iEmpresa), String)

                'Adiciona tag Imposto
                oTNFeItem.imposto = New TNFeInfNFeDetImposto
                If CDbl(sTotalImposto) > 0 Then oTNFeItem.imposto.vTotTrib = sTotalImposto

                If goEmitente.iRegimeTributario <> CInt(RegimeTributario.SimplesNacional) Then
                    Call NFe_N_ImpostosICMS(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)          'ICMS
                Else
                    Call NFe_N_ImpostosICMSSimples(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)   'ICMS SIMPLES
                End If
                If goDatabase.sInitialCatalog <> "INTERACTI_MODULINE_SJC_PRD" Then
                    Call NFe_N10_ImpostosICMS_DIFAL(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)      'ICMS PART
                End If
                Call NFe_O_ImpostosIPI(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)               'IPI
                Call NFe_P_ImpostosII(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)                'II
                Call NFe_Q_ImpostosPIS(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)               'PIS
                Call NFe_R_ImpostosPISST(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)             'PIS ST
                Call NFe_S_ImpostosCOFINS(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)            'COFINS
                Call NFe_T_ImpostosCOFINSSST(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)         'COFINS ST
                Call NFe_U_ImpostosISSQN(oTNFeItem.imposto, lCodigoEmissaoCapa, lCodigoEmissaoItem)             'ISSQN

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_N_ImpostosICMS(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                        ByVal lCodigoEmissaoCapa As Long, _
                                                        ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_icms", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Instancia Objeto
                    'oTNFeImposto.Icms = New TNFeInfNFeDetImpostoICMS()

                    'oTNFeImposto.Items(DefineEnum("ICMS", GetType(TNFeInfNFeDetImpostoICMS)) = New TNFeInfNFeDetImpostoICMS

                    ReDim Preserve oTNFeImposto.Items(Imposto.ICMS)


                    oTNFeImposto.Items(Imposto.ICMS) = New TNFeInfNFeDetImpostoICMS

                    While oSqlDataReader.Read

                        Select Case oSqlDataReader.Item("CST")

                            Case "00"
                                Dim ICMS00 As New TNFeInfNFeDetImpostoICMSICMS00
                                ICMS00.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS00.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoICMSICMS00CST))
                                ICMS00.modBC = DefineEnum(oSqlDataReader.Item("modBC"), GetType(TNFeInfNFeDetImpostoICMSICMS00ModBC))
                                ICMS00.vBC = oSqlDataReader.Item("vBC")
                                ICMS00.pICMS = oSqlDataReader.Item("pICMS")
                                ICMS00.vICMS = oSqlDataReader.Item("vICMS")


                                If Not IsDBNull(oSqlDataReader.Item("pFCP")) Then ICMS00.pFCP = oSqlDataReader.Item("pFCP")
                                If Not IsDBNull(oSqlDataReader.Item("vFCP")) Then ICMS00.vFCP = oSqlDataReader.Item("vFCP")


                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS00

                                'oTNFeImposto.ICMS.Item = ICMS00

                            Case "10"
                                Dim ICMS10 As New TNFeInfNFeDetImpostoICMSICMS10
                                ICMS10.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS10.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoICMSICMS10CST))
                                ICMS10.modBC = DefineEnum(oSqlDataReader.Item("modBC"), GetType(TNFeInfNFeDetImpostoICMSICMS10ModBC))
                                ICMS10.vBC = oSqlDataReader.Item("vBC")
                                ICMS10.pICMS = oSqlDataReader.Item("pICMS")
                                ICMS10.vICMS = oSqlDataReader.Item("vICMS")
                                ICMS10.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMS10ModBCST))
                                If Not IsDBNull(oSqlDataReader.Item("pMVAST")) Then ICMS10.pMVAST = oSqlDataReader.Item("pMVAST")
                                If Not IsDBNull(oSqlDataReader.Item("pRedBCST")) Then ICMS10.pRedBCST = oSqlDataReader.Item("pRedBCST")
                                ICMS10.vBCST = oSqlDataReader.Item("vBCST")
                                ICMS10.pICMSST = oSqlDataReader.Item("pICMSST")
                                ICMS10.vICMSST = oSqlDataReader.Item("vICMSST")

                                If Not IsDBNull(oSqlDataReader.Item("vBCFCP")) Then ICMS10.vBCFCP = oSqlDataReader.Item("vBCFCP")
                                If Not IsDBNull(oSqlDataReader.Item("pFCP")) Then ICMS10.pFCP = oSqlDataReader.Item("pFCP")
                                If Not IsDBNull(oSqlDataReader.Item("vFCP")) Then ICMS10.vFCP = oSqlDataReader.Item("vFCP")

                                If Not IsDBNull(oSqlDataReader.Item("vBCFCPST")) Then ICMS10.vBCFCPST = oSqlDataReader.Item("vBCFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("pFCPST")) Then ICMS10.pFCPST = oSqlDataReader.Item("pFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("vFCPST")) Then ICMS10.vFCPST = oSqlDataReader.Item("vFCPST")


                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS10

                            Case "20"
                                Dim ICMS20 As New TNFeInfNFeDetImpostoICMSICMS20
                                ICMS20.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS20.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoICMSICMS20CST))
                                ICMS20.modBC = DefineEnum(oSqlDataReader.Item("modBC"), GetType(TNFeInfNFeDetImpostoICMSICMS20ModBC))
                                ICMS20.pRedBC = oSqlDataReader.Item("pRedBC")
                                ICMS20.vBC = oSqlDataReader.Item("vBC")
                                ICMS20.pICMS = oSqlDataReader.Item("pICMS")
                                ICMS20.vICMS = oSqlDataReader.Item("vICMS")
                                If Not IsDBNull(oSqlDataReader.Item("vICMSDeson")) Then ICMS20.vICMSDeson = oSqlDataReader.Item("vICMSDeson")
                                If Not IsDBNull(oSqlDataReader.Item("motDesICMS")) Then ICMS20.motDesICMS = DefineEnum(oSqlDataReader.Item("motDesICMS"), GetType(TNFeInfNFeDetImpostoICMSICMS20MotDesICMS))

                                If Not IsDBNull(oSqlDataReader.Item("pFCP")) Then ICMS20.pFCP = oSqlDataReader.Item("pFCP")
                                If Not IsDBNull(oSqlDataReader.Item("vFCP")) Then ICMS20.vFCP = oSqlDataReader.Item("vFCP")
                                If Not IsDBNull(oSqlDataReader.Item("vBCFCP")) Then ICMS20.vBCFCP = oSqlDataReader.Item("vBCFCP")

                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS20

                            Case "30"
                                Dim ICMS30 = New TNFeInfNFeDetImpostoICMSICMS30
                                ICMS30.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS30.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoICMSICMS30CST))
                                ICMS30.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMS30ModBCST))
                                If Not IsDBNull(oSqlDataReader.Item("pMVAST")) Then ICMS30.pMVAST = oSqlDataReader.Item("pMVAST")
                                If Not IsDBNull(oSqlDataReader.Item("pRedBCST")) Then ICMS30.pRedBCST = oSqlDataReader.Item("pRedBCST")
                                If Not IsDBNull(oSqlDataReader.Item("vBCST")) Then ICMS30.vBCST = oSqlDataReader.Item("vBCST")
                                ICMS30.pICMSST = oSqlDataReader.Item("pICMSST")
                                ICMS30.vICMSST = oSqlDataReader.Item("vICMSST")
                                If Not IsDBNull(oSqlDataReader.Item("vICMSDeson")) Then ICMS30.vICMSDeson = oSqlDataReader.Item("vICMSDeson")
                                If Not IsDBNull(oSqlDataReader.Item("motDesICMS")) Then ICMS30.motDesICMS = DefineEnum(oSqlDataReader.Item("motDesICMS"), GetType(TNFeInfNFeDetImpostoICMSICMS30MotDesICMS))


                                If Not IsDBNull(oSqlDataReader.Item("vBCFCPST")) Then ICMS30.vBCFCPST = oSqlDataReader.Item("vBCFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("pFCPST")) Then ICMS30.pFCPST = oSqlDataReader.Item("pFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("vFCPST")) Then ICMS30.vFCPST = oSqlDataReader.Item("vFCPST")

                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS30

                            Case "40", "41", "50"
                                Dim ICMS40 As New TNFeInfNFeDetImpostoICMSICMS40
                                ICMS40.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS40.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoICMSICMS40CST))
                                If Not IsDBNull(oSqlDataReader.Item("motDesICMS")) Then ICMS40.motDesICMS = DefineEnum(oSqlDataReader.Item("motDesICMS"), GetType(TNFeInfNFeDetImpostoICMSICMS40MotDesICMS))
                                If Not IsDBNull(oSqlDataReader.Item("vICMSDeson")) Then ICMS40.vICMSDeson = oSqlDataReader.Item("vICMSDeson")

                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS40

                            Case "51"
                                Dim ICMS51 As New TNFeInfNFeDetImpostoICMSICMS51
                                ICMS51.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS51.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoICMSICMS51CST))
                                If Not IsDBNull(oSqlDataReader.Item("modBC")) Then ICMS51.modBC = DefineEnum(oSqlDataReader.Item("modBC"), GetType(TNFeInfNFeDetImpostoICMSICMS51ModBC))
                                If Not IsDBNull(oSqlDataReader.Item("pRedBC")) Then ICMS51.pRedBC = oSqlDataReader.Item("pRedBC")
                                If Not IsDBNull(oSqlDataReader.Item("vBC")) Then ICMS51.vBC = oSqlDataReader.Item("vBC")
                                If Not IsDBNull(oSqlDataReader.Item("pICMS")) Then ICMS51.pICMS = oSqlDataReader.Item("pICMS")
                                If Not IsDBNull(oSqlDataReader.Item("vICMS")) Then ICMS51.vICMS = oSqlDataReader.Item("vICMS")
                                If Not IsDBNull(oSqlDataReader.Item("vICMSDif")) Then ICMS51.vICMSDif = oSqlDataReader.Item("vICMSDif")
                                If Not IsDBNull(oSqlDataReader.Item("vICMSOp")) Then ICMS51.vICMSOp = oSqlDataReader.Item("vICMSOp")
                                If Not IsDBNull(oSqlDataReader.Item("pDif")) Then ICMS51.pDif = oSqlDataReader.Item("pDif")

                                If Not IsDBNull(oSqlDataReader.Item("vBCFCP")) Then ICMS51.vBCFCP = oSqlDataReader.Item("vBCFCP")
                                If Not IsDBNull(oSqlDataReader.Item("pFCP")) Then ICMS51.pFCP = oSqlDataReader.Item("pFCP")
                                If Not IsDBNull(oSqlDataReader.Item("vFCP")) Then ICMS51.vFCP = oSqlDataReader.Item("vFCP")

                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS51

                            Case "60"
                                Dim ICMS60 As New TNFeInfNFeDetImpostoICMSICMS60
                                ICMS60.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS60.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoICMSICMS60CST))
                                ICMS60.vBCSTRet = oSqlDataReader.Item("vBCSTRet")
                                ICMS60.vICMSSTRet = oSqlDataReader.Item("vICMSSTRet")

                                If Not IsDBNull(oSqlDataReader.Item("vBCFCPSTRet")) Then ICMS60.vBCFCPSTRet = oSqlDataReader.Item("vBCFCPSTRet")
                                If Not IsDBNull(oSqlDataReader.Item("pFCPSTRet")) Then ICMS60.pFCPSTRet = oSqlDataReader.Item("pFCPSTRet")
                                If Not IsDBNull(oSqlDataReader.Item("vFCPSTRet")) Then ICMS60.vFCPSTRet = oSqlDataReader.Item("vFCPSTRet")
                                If Not IsDBNull(oSqlDataReader.Item("pST")) Then ICMS60.pST = oSqlDataReader.Item("pST")
                                If Not IsDBNull(oSqlDataReader.Item("vICMSSubstituto")) Then ICMS60.vICMSSubstituto = oSqlDataReader.Item("vICMSSubstituto")

                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS60

                            Case "70"

                                Dim ICMS70 As New TNFeInfNFeDetImpostoICMSICMS70
                                ICMS70.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS70.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoICMSICMS70CST))
                                ICMS70.modBC = DefineEnum(oSqlDataReader.Item("modBC"), GetType(TNFeInfNFeDetImpostoICMSICMS70ModBC))
                                ICMS70.pRedBC = oSqlDataReader.Item("pRedBC")
                                ICMS70.vBC = oSqlDataReader.Item("vBC")
                                ICMS70.pICMS = oSqlDataReader.Item("pICMS")
                                ICMS70.vICMS = oSqlDataReader.Item("vICMS")
                                ICMS70.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMS70ModBCST))
                                If Not IsDBNull(oSqlDataReader.Item("pMVAST")) Then ICMS70.pMVAST = oSqlDataReader.Item("pMVAST")
                                If Not IsDBNull(oSqlDataReader.Item("pRedBCST")) Then ICMS70.pRedBCST = oSqlDataReader.Item("pRedBCST")
                                ICMS70.vBCST = oSqlDataReader.Item("vBCST")
                                ICMS70.pICMSST = oSqlDataReader.Item("pICMSST")
                                ICMS70.vICMSST = oSqlDataReader.Item("vICMSST")
                                If Not IsDBNull(oSqlDataReader.Item("vICMSDeson")) Then ICMS70.vICMSDeson = oSqlDataReader.Item("vICMSDeson")
                                If Not IsDBNull(oSqlDataReader.Item("motDesICMS")) Then ICMS70.motDesICMS = DefineEnum(oSqlDataReader.Item("motDesICMS"), GetType(TNFeInfNFeDetImpostoICMSICMS70MotDesICMS))


                                If Not IsDBNull(oSqlDataReader.Item("vBCFCP")) Then ICMS70.vBCFCP = oSqlDataReader.Item("vBCFCP")
                                If Not IsDBNull(oSqlDataReader.Item("pFCP")) Then ICMS70.pFCP = oSqlDataReader.Item("pFCP")
                                If Not IsDBNull(oSqlDataReader.Item("vFCP")) Then ICMS70.vFCP = oSqlDataReader.Item("vFCP")

                                If Not IsDBNull(oSqlDataReader.Item("vBCFCPST")) Then ICMS70.vBCFCPST = oSqlDataReader.Item("vBCFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("pFCPST")) Then ICMS70.pFCPST = oSqlDataReader.Item("pFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("vFCPST")) Then ICMS70.vFCPST = oSqlDataReader.Item("vFCPST")


                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS70

                            Case "90"
                                Dim ICMS90 As New TNFeInfNFeDetImpostoICMSICMS90()
                                ICMS90.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS90.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoICMSICMS90CST))
                                ICMS90.modBC = DefineEnum(oSqlDataReader.Item("modBC"), GetType(TNFeInfNFeDetImpostoICMSICMS90ModBC))
                                If Not IsDBNull(oSqlDataReader.Item("pRedBC")) Then ICMS90.pRedBC = oSqlDataReader.Item("pRedBC")
                                ICMS90.vBC = oSqlDataReader.Item("vBC")
                                ICMS90.pICMS = oSqlDataReader.Item("pICMS")
                                ICMS90.vICMS = oSqlDataReader.Item("vICMS")
                                ICMS90.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMS90ModBCST))
                                If Not IsDBNull(oSqlDataReader.Item("pMVAST")) Then ICMS90.pMVAST = oSqlDataReader.Item("pMVAST")
                                If Not IsDBNull(oSqlDataReader.Item("pRedBCST")) Then ICMS90.pRedBCST = oSqlDataReader.Item("pRedBCST")
                                ICMS90.vBCST = oSqlDataReader.Item("vBCST")
                                ICMS90.pICMSST = oSqlDataReader.Item("pICMSST")
                                ICMS90.vICMSST = oSqlDataReader.Item("vICMSST")
                                If Not IsDBNull(oSqlDataReader.Item("vICMSDeson")) Then ICMS90.vICMSDeson = oSqlDataReader.Item("vICMSDeson")
                                If Not IsDBNull(oSqlDataReader.Item("motDesICMS")) Then ICMS90.motDesICMS = DefineEnum(oSqlDataReader.Item("motDesICMS"), GetType(TNFeInfNFeDetImpostoICMSICMS90MotDesICMS))

                                If Not IsDBNull(oSqlDataReader.Item("vBCFCP")) Then ICMS90.vBCFCP = oSqlDataReader.Item("vBCFCP")
                                If Not IsDBNull(oSqlDataReader.Item("pFCP")) Then ICMS90.pFCP = oSqlDataReader.Item("pFCP")
                                If Not IsDBNull(oSqlDataReader.Item("vFCP")) Then ICMS90.vFCP = oSqlDataReader.Item("vFCP")

                                If Not IsDBNull(oSqlDataReader.Item("vBCFCPST")) Then ICMS90.vBCFCPST = oSqlDataReader.Item("vBCFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("pFCPST")) Then ICMS90.pFCPST = oSqlDataReader.Item("pFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("vFCPST")) Then ICMS90.vFCPST = oSqlDataReader.Item("vFCPST")



                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS90

                        End Select

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_N_ImpostosICMSSimples(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                               ByVal lCodigoEmissaoCapa As Long, _
                                                               ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_icms_simples", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Instancia Objeto
                    ReDim Preserve oTNFeImposto.Items(Imposto.ICMS)
                    oTNFeImposto.Items(Imposto.ICMS) = New TNFeInfNFeDetImpostoICMS()

                    While oSqlDataReader.Read

                        Select Case oSqlDataReader.Item("CSOSN")

                            Case "101"
                                Dim ICMS101 As New TNFeInfNFeDetImpostoICMSICMSSN101
                                ICMS101.CSOSN = TNFeInfNFeDetImpostoICMSICMSSN101CSOSN.Item101
                                ICMS101.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS101.pCredSN = oSqlDataReader.Item("pCredSN")
                                ICMS101.vCredICMSSN = oSqlDataReader.Item("vCredICMSSN")

                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS101

                            Case "102", "103", "300", "400"
                                Dim ICMS102 As New TNFeInfNFeDetImpostoICMSICMSSN102
                                ICMS102.CSOSN = DefineEnum(oSqlDataReader.Item("CSOSN"), GetType(TNFeInfNFeDetImpostoICMSICMSSN102))
                                ICMS102.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))

                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS102

                            Case "201"
                                Dim ICMS201 As New TNFeInfNFeDetImpostoICMSICMSSN201
                                ICMS201.CSOSN = TNFeInfNFeDetImpostoICMSICMSSN201CSOSN.Item201
                                ICMS201.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS201.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMSSN201ModBCST))
                                ICMS201.pCredSN = oSqlDataReader.Item("pCredSN")
                                ICMS201.vCredICMSSN = oSqlDataReader.Item("vCredICMSSN")
                                ICMS201.pMVAST = oSqlDataReader.Item("pMVAST")
                                If Not IsDBNull(oSqlDataReader.Item("pRedBCST")) Then ICMS201.pRedBCST = oSqlDataReader.Item("pRedBCST")
                                ICMS201.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMS90ModBCST))
                                ICMS201.vBCST = oSqlDataReader.Item("vBCST")
                                ICMS201.pICMSST = oSqlDataReader.Item("pICMSST")
                                ICMS201.vICMSST = oSqlDataReader.Item("vICMSST")

                                If Not IsDBNull(oSqlDataReader.Item("vBCFCPST")) Then ICMS201.vBCFCPST = oSqlDataReader.Item("vBCFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("pFCPST")) Then ICMS201.pFCPST = oSqlDataReader.Item("pFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("vFCPST")) Then ICMS201.vFCPST = oSqlDataReader.Item("vFCPST")


                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS201


                            Case "202", "203"
                                Dim ICMS202 As New TNFeInfNFeDetImpostoICMSICMSSN202
                                ICMS202.CSOSN = TNFeInfNFeDetImpostoICMSICMSSN202CSOSN.Item202
                                ICMS202.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS202.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMSSN202ModBCST))
                                ICMS202.pMVAST = oSqlDataReader.Item("pMVAST")
                                If Not IsDBNull(oSqlDataReader.Item("pRedBCST")) Then ICMS202.pRedBCST = oSqlDataReader.Item("pRedBCST")
                                ICMS202.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMS90ModBCST))
                                ICMS202.vBCST = oSqlDataReader.Item("vBCST")
                                ICMS202.pICMSST = oSqlDataReader.Item("pICMSST")
                                ICMS202.vICMSST = oSqlDataReader.Item("vICMSST")


                                If Not IsDBNull(oSqlDataReader.Item("vBCFCPST")) Then ICMS202.vBCFCPST = oSqlDataReader.Item("vBCFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("pFCPST")) Then ICMS202.pFCPST = oSqlDataReader.Item("pFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("vFCPST")) Then ICMS202.vFCPST = oSqlDataReader.Item("vFCPST")


                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS202

                            Case "500"
                                Dim ICMS500 As New TNFeInfNFeDetImpostoICMSICMSSN500
                                ICMS500.CSOSN = TNFeInfNFeDetImpostoICMSICMSSN500CSOSN.Item500
                                ICMS500.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                ICMS500.vBCSTRet = oSqlDataReader.Item("vBCSTRet")
                                ICMS500.vICMSSTRet = oSqlDataReader.Item("vICMSSTRet")


                                If Not IsDBNull(oSqlDataReader.Item("vBCFCPSTRet")) Then ICMS500.vBCFCPSTRet = oSqlDataReader.Item("vBCFCPSTRet")
                                If Not IsDBNull(oSqlDataReader.Item("pFCPSTRet")) Then ICMS500.pFCPSTRet = oSqlDataReader.Item("pFCPSTRet")
                                If Not IsDBNull(oSqlDataReader.Item("vFCPSTRet")) Then ICMS500.vFCPSTRet = oSqlDataReader.Item("vFCPSTRet")
                                If Not IsDBNull(oSqlDataReader.Item("pST")) Then ICMS500.pST = oSqlDataReader.Item("pST")



                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS500

                            Case "900"

                                Dim ICMS900 As New TNFeInfNFeDetImpostoICMSICMSSN900
                                ICMS900.CSOSN = TNFeInfNFeDetImpostoICMSICMSSN900CSOSN.Item900
                                ICMS900.orig = DefineEnum(oSqlDataReader.Item("orig"), GetType(Torig))
                                If Not IsDBNull(oSqlDataReader.Item("modBC")) Then ICMS900.modBC = DefineEnum(oSqlDataReader.Item("modBC"), GetType(TNFeInfNFeDetImpostoICMSICMS90ModBC))
                                If Not IsDBNull(oSqlDataReader.Item("vBC")) Then ICMS900.vBC = oSqlDataReader.Item("vBC")
                                If Not IsDBNull(oSqlDataReader.Item("pICMS")) Then ICMS900.pICMS = oSqlDataReader.Item("pICMS")
                                If Not IsDBNull(oSqlDataReader.Item("vICMS")) Then ICMS900.vICMS = oSqlDataReader.Item("vICMS")
                                If Not IsDBNull(oSqlDataReader.Item("modBCST")) Then ICMS900.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMSSN900ModBCST))
                                ICMS900.pCredSN = oSqlDataReader.Item("pCredSN")
                                ICMS900.vCredICMSSN = oSqlDataReader.Item("vCredICMSSN")
                                ICMS900.pMVAST = oSqlDataReader.Item("pMVAST")
                                If Not IsDBNull(oSqlDataReader.Item("pRedBC")) Then ICMS900.pRedBC = oSqlDataReader.Item("pRedBC")
                                If Not IsDBNull(oSqlDataReader.Item("pRedBCST")) Then ICMS900.pRedBCST = oSqlDataReader.Item("pRedBCST")
                                ICMS900.modBCST = DefineEnum(oSqlDataReader.Item("modBCST"), GetType(TNFeInfNFeDetImpostoICMSICMS90ModBCST))
                                If Not IsDBNull(oSqlDataReader.Item("vBCST")) Then ICMS900.vBCST = oSqlDataReader.Item("vBCST")
                                If Not IsDBNull(oSqlDataReader.Item("pICMSST")) Then ICMS900.pICMSST = oSqlDataReader.Item("pICMSST")
                                If Not IsDBNull(oSqlDataReader.Item("vICMSST")) Then ICMS900.vICMSST = oSqlDataReader.Item("vICMSST")

                                If Not IsDBNull(oSqlDataReader.Item("vBCFCPST")) Then ICMS900.vBCFCPST = oSqlDataReader.Item("vBCFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("pFCPST")) Then ICMS900.pFCPST = oSqlDataReader.Item("pFCPST")
                                If Not IsDBNull(oSqlDataReader.Item("vFCPST")) Then ICMS900.vFCPST = oSqlDataReader.Item("vFCPST")



                                oTNFeImposto.Items(Imposto.ICMS).ITEM = ICMS900

                        End Select

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
        Private Overloads Shared Sub NFe_N10_ImpostosICMS_DIFAL(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                        ByVal lCodigoEmissaoCapa As Long, _
                                                        ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_icms_difal", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Instancia Objeto
                    oTNFeImposto.ICMSUFDest = New TNFeInfNFeDetImpostoICMSUFDest()

                    While oSqlDataReader.Read


                        If Not IsDBNull(oSqlDataReader.Item("pFCPUFDest")) Then oTNFeImposto.ICMSUFDest.pFCPUFDest = oSqlDataReader.Item("pFCPUFDest")

                        If Not IsDBNull(oSqlDataReader.Item("pFCPUFDest")) Then
                            Select Case oSqlDataReader.Item("pICMSInter")
                                Case 4
                                    oTNFeImposto.ICMSUFDest.pICMSInter = TNFeInfNFeDetImpostoICMSUFDestPICMSInter.Item400
                                Case 7
                                    oTNFeImposto.ICMSUFDest.pICMSInter = TNFeInfNFeDetImpostoICMSUFDestPICMSInter.Item700
                                Case 12
                                    oTNFeImposto.ICMSUFDest.pICMSInter = TNFeInfNFeDetImpostoICMSUFDestPICMSInter.Item1200
                            End Select
                        End If

                        If Not IsDBNull(oSqlDataReader.Item("pICMSInterPart")) Then oTNFeImposto.ICMSUFDest.pICMSInterPart = oSqlDataReader.Item("pICMSInterPart")
                        If Not IsDBNull(oSqlDataReader.Item("pICMSUFDest")) Then oTNFeImposto.ICMSUFDest.pICMSUFDest = oSqlDataReader.Item("pICMSUFDest")
                        If Not IsDBNull(oSqlDataReader.Item("vBCFCPUFDest")) Then oTNFeImposto.ICMSUFDest.vBCFCPUFDest = oSqlDataReader.Item("vBCFCPUFDest")
                        If Not IsDBNull(oSqlDataReader.Item("vBCUFDest")) Then oTNFeImposto.ICMSUFDest.vBCUFDest = oSqlDataReader.Item("vBCUFDest")
                        If Not IsDBNull(oSqlDataReader.Item("vFCPUFDest")) Then oTNFeImposto.ICMSUFDest.vFCPUFDest = oSqlDataReader.Item("vFCPUFDest")
                        If Not IsDBNull(oSqlDataReader.Item("vICMSUFDest")) Then oTNFeImposto.ICMSUFDest.vICMSUFDest = oSqlDataReader.Item("vICMSUFDest")
                        If Not IsDBNull(oSqlDataReader.Item("vICMSUFRemet")) Then oTNFeImposto.ICMSUFDest.vICMSUFRemet = oSqlDataReader.Item("vICMSUFRemet")



                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
        Private Overloads Shared Sub NFe_O_ImpostosIPI(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                       ByVal lCodigoEmissaoCapa As Long, _
                                                       ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_ipi", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Instancia Objeto
                        ReDim Preserve oTNFeImposto.Items(Imposto.IPI)
                        oTNFeImposto.Items(Imposto.IPI) = New TIpi

                        'Informa Dados
                        If oSqlDataReader.Item("clEnq") <> "" Then oTNFeImposto.Items(Imposto.IPI).clEnq = RetirarAcento(oSqlDataReader.Item("clEnq"))
                        If oSqlDataReader.Item("CNPJProd") <> "" Then oTNFeImposto.Items(Imposto.IPI).CNPJProd = RetirarAcento(oSqlDataReader.Item("CNPJProd"))
                        If oSqlDataReader.Item("cSelo") <> "" Then oTNFeImposto.Items(Imposto.IPI).cSelo = RetirarAcento(oSqlDataReader.Item("cSelo"))
                        If Not IsDBNull(oSqlDataReader.Item("qSelo")) Then oTNFeImposto.Items(Imposto.IPI).qSelo = oSqlDataReader.Item("qSelo")
                        oTNFeImposto.Items(Imposto.IPI).cEnq = IIf(oSqlDataReader.Item("cEnq") = "", "999", oSqlDataReader.Item("cEnq"))

                        Select Case oSqlDataReader.Item("CST")

                            Case "00", "49", "50", "99"
                                'IPI Tributado
                                Dim IPITrib As New TIpiIPITrib
                                'Informa Dados do IPI
                                IPITrib.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TIpiIPITribCST))
                                IPITrib.vIPI = oSqlDataReader.Item("vIPI")
                                ReDim IPITrib.ItemsElementName(1)
                                ReDim IPITrib.Items(1)

                                Select Case oSqlDataReader.Item("codigo_tipo_calculo_imposto")

                                    Case TipoCalculoImposto.Percentual
                                        IPITrib.ItemsElementName(0) = ItemsChoiceType.vBC
                                        IPITrib.ItemsElementName(1) = ItemsChoiceType.pIPI
                                        IPITrib.Items(0) = oSqlDataReader.Item("vBC")
                                        IPITrib.Items(1) = oSqlDataReader.Item("pIPI")

                                    Case TipoCalculoImposto.Valor
                                        IPITrib.ItemsElementName(0) = ItemsChoiceType.qUnid
                                        IPITrib.ItemsElementName(1) = ItemsChoiceType.vUnid
                                        IPITrib.Items(0) = oSqlDataReader.Item("qUnid")
                                        IPITrib.Items(1) = oSqlDataReader.Item("vUnid")

                                End Select
                                'Seta IPI
                                oTNFeImposto.Items(Imposto.IPI).ITEM = IPITrib

                            Case Else
                                'IPI Não Tributado
                                Dim IPIINT As New TIpiIPINT
                                'Informa Dados do IPI Não Tributado
                                IPIINT.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TIpiIPINTCST))
                                'Seta IPI
                                oTNFeImposto.Items(Imposto.IPI).ITEM = IPIINT

                        End Select

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_P_ImpostosII(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                       ByVal lCodigoEmissaoCapa As Long, _
                                                       ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_ii", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Instancia Objeto
                        ReDim Preserve oTNFeImposto.Items(Imposto.II)
                        oTNFeImposto.Items(Imposto.II) = New TNFeInfNFeDetImpostoII
                        'Informa Dados 
                        oTNFeImposto.Items(Imposto.II).vBC = oSqlDataReader.Item("vBC")
                        oTNFeImposto.Items(Imposto.II).vDespAdu = oSqlDataReader.Item("vDespAdu")
                        oTNFeImposto.Items(Imposto.II).vII = oSqlDataReader.Item("vII")
                        oTNFeImposto.Items(Imposto.II).vIOF = oSqlDataReader.Item("vIOF")

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_Q_ImpostosPIS(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                       ByVal lCodigoEmissaoCapa As Long, _
                                                       ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_pis", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Instancia Objeto
                        oTNFeImposto.PIS = New TNFeInfNFeDetImpostoPIS

                        'Verifica Situação Tributária
                        Select Case oSqlDataReader.Item("CST")


                            Case "01", "02"
                                'PIS - Alíquota
                                Dim PISAliq = New TNFeInfNFeDetImpostoPISPISAliq
                                PISAliq.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoPISPISAliqCST))
                                PISAliq.vBC = oSqlDataReader.Item("vBC")
                                PISAliq.pPIS = oSqlDataReader.Item("pPIS")
                                PISAliq.vPIS = oSqlDataReader.Item("vPIS")
                                'Seta PIS
                                oTNFeImposto.PIS.Item = PISAliq

                            Case "03"
                                'PIS - Quantidade
                                Dim PISQtde = New TNFeInfNFeDetImpostoPISPISQtde
                                PISQtde.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoPISPISQtdeCST))
                                PISQtde.qBCProd = oSqlDataReader.Item("qBCProd")
                                PISQtde.vAliqProd = oSqlDataReader.Item("vAliqProd")
                                PISQtde.vPIS = oSqlDataReader.Item("vPIS")
                                'Seta PIS
                                oTNFeImposto.PIS.Item = PISQtde

                            Case "04", "05", "06", "07", "08", "09"
                                'PIS - Não Tributado
                                Dim PISNT = New TNFeInfNFeDetImpostoPISPISNT
                                PISNT.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoPISPISNTCST))
                                'Seta PIS
                                oTNFeImposto.PIS.Item = PISNT

                            Case "49", "50", "51", "52", "53", "54", "55", "56", "60", "61", "62", "63", "64", "65", "66", "67", "70", "71", "72", "73", "74", "75", "98", "99"
                                'PIS - Outros
                                Dim PISOutr = New TNFeInfNFeDetImpostoPISPISOutr
                                PISOutr.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoPISPISOutrCST))
                                PISOutr.vPIS = oSqlDataReader.Item("vPIS")
                                ReDim PISOutr.ItemsElementName(1)
                                ReDim PISOutr.Items(1)

                                Select Case oSqlDataReader.Item("codigo_tipo_calculo_pis")

                                    Case TipoCalculoImposto.Percentual
                                        PISOutr.ItemsElementName(0) = ItemsChoiceType1.vBC
                                        PISOutr.ItemsElementName(1) = ItemsChoiceType1.pPIS
                                        PISOutr.Items(0) = oSqlDataReader.Item("vBC")
                                        PISOutr.Items(1) = oSqlDataReader.Item("pPIS")

                                    Case TipoCalculoImposto.Valor
                                        PISOutr.ItemsElementName(0) = ItemsChoiceType1.qBCProd
                                        PISOutr.ItemsElementName(1) = ItemsChoiceType1.vAliqProd
                                        PISOutr.Items(0) = oSqlDataReader.Item("qBCProd")
                                        PISOutr.Items(1) = oSqlDataReader.Item("vAliqProd")

                                End Select
                                'Seta PIS
                                oTNFeImposto.PIS.Item = PISOutr

                        End Select

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_R_ImpostosPISST(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                         ByVal lCodigoEmissaoCapa As Long, _
                                                         ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_pis_st", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Verifica se foi seleciona o Tipo de Calculo Imposto
                        If IsDBNull(oSqlDataReader.Item("codigo_tipo_calculo_imposto")) = False Then

                            'Instancia Objeto
                            oTNFeImposto.PISST = New TNFeInfNFeDetImpostoPISST

                            oTNFeImposto.PISST.vPIS = oSqlDataReader.Item("vPIS")
                            ReDim oTNFeImposto.PISST.ItemsElementName(1)
                            ReDim oTNFeImposto.PISST.Items(1)

                            Select Case oSqlDataReader.Item("codigo_tipo_calculo_imposto")

                                Case TipoCalculoImposto.Percentual
                                    oTNFeImposto.PISST.ItemsElementName(0) = ItemsChoiceType2.vBC
                                    oTNFeImposto.PISST.ItemsElementName(1) = ItemsChoiceType2.pPIS
                                    oTNFeImposto.PISST.Items(0) = oSqlDataReader.Item("vBC")
                                    oTNFeImposto.PISST.Items(1) = oSqlDataReader.Item("pPIS")

                                Case TipoCalculoImposto.Valor
                                    oTNFeImposto.PISST.ItemsElementName(0) = ItemsChoiceType2.qBCProd
                                    oTNFeImposto.PISST.ItemsElementName(1) = ItemsChoiceType2.vAliqProd
                                    oTNFeImposto.PISST.Items(0) = oSqlDataReader.Item("qBCProd")
                                    oTNFeImposto.PISST.Items(1) = oSqlDataReader.Item("vAliqProd")

                            End Select

                        End If

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_S_ImpostosCOFINS(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                          ByVal lCodigoEmissaoCapa As Long, _
                                                          ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_cofins", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Instancia Objeto
                        oTNFeImposto.COFINS = New TNFeInfNFeDetImpostoCOFINS

                        'Verifica Situação Tributária
                        Select Case oSqlDataReader.Item("CST")

                            Case "01", "02"
                                'COFINS - Alíquota
                                Dim COFINSAliq As New TNFeInfNFeDetImpostoCOFINSCOFINSAliq
                                COFINSAliq.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST))
                                COFINSAliq.vBC = oSqlDataReader.Item("vBC")
                                COFINSAliq.pCOFINS = oSqlDataReader.Item("pCOFINS")
                                COFINSAliq.vCOFINS = oSqlDataReader.Item("vCOFINS")
                                'Seta COFINS
                                oTNFeImposto.COFINS.Item = COFINSAliq

                            Case "03"
                                'COFINS - Quantidade
                                Dim COFINSQtde As New TNFeInfNFeDetImpostoCOFINSCOFINSQtde
                                COFINSQtde.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST))
                                COFINSQtde.qBCProd = oSqlDataReader.Item("qBCProd")
                                COFINSQtde.vAliqProd = oSqlDataReader.Item("vAliqProd")
                                COFINSQtde.vCOFINS = oSqlDataReader.Item("vCOFINS")
                                'Seta COFINS
                                oTNFeImposto.COFINS.Item = COFINSQtde

                            Case "04", "05", "06", "07", "08", "09"
                                'COFINS - Não Tributado
                                Dim COFINSNT As New TNFeInfNFeDetImpostoCOFINSCOFINSNT
                                COFINSNT.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoCOFINSCOFINSNTCST))
                                'Seta COFINS
                                oTNFeImposto.COFINS.Item = COFINSNT

                            Case "49", "50", "51", "52", "53", "54", "55", "56", "60", "61", "62", "63", "64", "65", "66", "67", "70", "71", "72", "73", "74", "75", "98", "99"
                                'COFINS - Outros
                                Dim COFINSOutr As New TNFeInfNFeDetImpostoCOFINSCOFINSOutr
                                COFINSOutr.CST = DefineEnum(oSqlDataReader.Item("CST"), GetType(TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST))
                                COFINSOutr.vCOFINS = oSqlDataReader.Item("vCOFINS")
                                ReDim COFINSOutr.ItemsElementName(1)
                                ReDim COFINSOutr.Items(1)

                                Select Case oSqlDataReader.Item("codigo_tipo_calculo_cofins")

                                    Case TipoCalculoImposto.Percentual
                                        COFINSOutr.ItemsElementName(0) = ItemsChoiceType3.vBC
                                        COFINSOutr.ItemsElementName(1) = ItemsChoiceType3.pCOFINS
                                        COFINSOutr.Items(0) = oSqlDataReader.Item("vBC")
                                        COFINSOutr.Items(1) = oSqlDataReader.Item("pCOFINS")

                                    Case TipoCalculoImposto.Valor
                                        COFINSOutr.ItemsElementName(0) = ItemsChoiceType3.qBCProd
                                        COFINSOutr.ItemsElementName(1) = ItemsChoiceType3.vAliqProd
                                        COFINSOutr.Items(0) = oSqlDataReader.Item("qBCProd")
                                        COFINSOutr.Items(1) = oSqlDataReader.Item("vAliqProd")

                                End Select
                                'Seta COFINS
                                oTNFeImposto.COFINS.Item = COFINSOutr

                        End Select

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_T_ImpostosCOFINSSST(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                             ByVal lCodigoEmissaoCapa As Long, _
                                                             ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_cofins_st", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Verifica se foi seleciona o Tipo de Calculo Imposto
                        If IsDBNull(oSqlDataReader.Item("codigo_tipo_calculo_imposto")) = False Then

                            'Instancia Objeto
                            oTNFeImposto.COFINSST = New TNFeInfNFeDetImpostoCOFINSST

                            oTNFeImposto.COFINSST.vCOFINS = oSqlDataReader.Item("vCOFINS")
                            ReDim oTNFeImposto.COFINSST.ItemsElementName(1)
                            ReDim oTNFeImposto.COFINSST.Items(1)

                            Select Case oSqlDataReader.Item("codigo_tipo_calculo_imposto")

                                Case TipoCalculoImposto.Percentual
                                    oTNFeImposto.COFINSST.ItemsElementName(0) = ItemsChoiceType4.vBC
                                    oTNFeImposto.COFINSST.ItemsElementName(1) = ItemsChoiceType4.pCOFINS
                                    oTNFeImposto.COFINSST.Items(0) = oSqlDataReader.Item("vBC")
                                    oTNFeImposto.COFINSST.Items(1) = oSqlDataReader.Item("pCOFINS")

                                Case TipoCalculoImposto.Valor
                                    oTNFeImposto.COFINSST.ItemsElementName(0) = ItemsChoiceType4.qBCProd
                                    oTNFeImposto.COFINSST.ItemsElementName(1) = ItemsChoiceType4.vAliqProd
                                    oTNFeImposto.COFINSST.Items(0) = oSqlDataReader.Item("qBCProd")
                                    oTNFeImposto.COFINSST.Items(1) = oSqlDataReader.Item("vAliqProd")

                            End Select

                        End If

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_U_ImpostosISSQN(ByRef oTNFeImposto As TNFeInfNFeDetImposto, _
                                                         ByVal lCodigoEmissaoCapa As Long, _
                                                         ByVal lCodigoEmissaoItem As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoItem

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_emissao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_item_issqn", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        oTNFeImposto.Items("ISSQN") = New TNFeInfNFeDetImpostoISSQN

                        oTNFeImposto.Items("ISSQN").vBC = oSqlDataReader.Item("vBC")
                        oTNFeImposto.Items("ISSQN").vAliq = oSqlDataReader.Item("vAliq")
                        oTNFeImposto.Items("ISSQN").vISSQN = oSqlDataReader.Item("vISSQN")
                        oTNFeImposto.Items("ISSQN").cMunFG = oSqlDataReader.Item("cMunFG")
                        'oTNFeImposto.Items("ISSQN").cListServ = TCListServ.Item1001 ' DefineEnum(oSqlDataReader.Item("cListServ"), GetType(TCListServ))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_W_Total(ByRef oTNFe As TNFe, _
                                                 ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_totais", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        oTNFe.infNFe.total = New TNFeInfNFeTotal

                        'Total ICMS
                        oTNFe.infNFe.total.ICMSTot = New TNFeInfNFeTotalICMSTot

                        oTNFe.infNFe.total.ICMSTot.vICMSDeson = oSqlDataReader.Item("vICMSDeson")
                        oTNFe.infNFe.total.ICMSTot.vBC = oSqlDataReader.Item("vBC")
                        oTNFe.infNFe.total.ICMSTot.vBC = oSqlDataReader.Item("vBC")
                        oTNFe.infNFe.total.ICMSTot.vICMS = oSqlDataReader.Item("vICMS")

                        '4.00
                        oTNFe.infNFe.total.ICMSTot.vFCP = oSqlDataReader.Item("vFCP")
                        oTNFe.infNFe.total.ICMSTot.vFCPST = oSqlDataReader.Item("vFCPST")
                        oTNFe.infNFe.total.ICMSTot.vFCPSTRet = oSqlDataReader.Item("vFCPSTRet")
                        oTNFe.infNFe.total.ICMSTot.vIPIDevol = oSqlDataReader.Item("vIPIDevol")

                        oTNFe.infNFe.total.ICMSTot.vBCST = oSqlDataReader.Item("vBCST")
                        oTNFe.infNFe.total.ICMSTot.vST = oSqlDataReader.Item("vST")
                        oTNFe.infNFe.total.ICMSTot.vProd = oSqlDataReader.Item("vProd")
                        oTNFe.infNFe.total.ICMSTot.vFrete = oSqlDataReader.Item("vFrete")
                        oTNFe.infNFe.total.ICMSTot.vSeg = oSqlDataReader.Item("vSeg")
                        oTNFe.infNFe.total.ICMSTot.vDesc = oSqlDataReader.Item("vDesc")
                        oTNFe.infNFe.total.ICMSTot.vII = oSqlDataReader.Item("vII")
                        oTNFe.infNFe.total.ICMSTot.vIPI = oSqlDataReader.Item("vIPI")
                        oTNFe.infNFe.total.ICMSTot.vPIS = oSqlDataReader.Item("vPIS")
                        oTNFe.infNFe.total.ICMSTot.vCOFINS = oSqlDataReader.Item("vCOFINS")
                        oTNFe.infNFe.total.ICMSTot.vOutro = oSqlDataReader.Item("vOutro")
                        oTNFe.infNFe.total.ICMSTot.vNF = oSqlDataReader.Item("vNF")
                        If oSqlDataReader.Item("vTotTrib") > 0 Then oTNFe.infNFe.total.ICMSTot.vTotTrib = oSqlDataReader.Item("vTotTrib")

                        If goDatabase.sInitialCatalog <> "INTERACTI_MODULINE_SJC_PRD" Then
                            'ICMS Partilha
                            If Not IsDBNull(oSqlDataReader.Item("vFCPUFDest")) Then oTNFe.infNFe.total.ICMSTot.vFCPUFDest = oSqlDataReader.Item("vFCPUFDest")
                            If Not IsDBNull(oSqlDataReader.Item("vICMSUFDest")) Then oTNFe.infNFe.total.ICMSTot.vICMSUFDest = oSqlDataReader.Item("vICMSUFDest")
                            If Not IsDBNull(oSqlDataReader.Item("vICMSUFRemet")) Then oTNFe.infNFe.total.ICMSTot.vICMSUFRemet = oSqlDataReader.Item("vICMSUFRemet")
                        End If

                        'Total ISSQN
                        'oTNFe.infNFe.total.ISSQNtot = New TNFeInfNFeTotalISSQNtot
                        'If Not IsDBNull(oSqlDataReader.Item("vServ")) Then oTNFe.infNFe.total.ISSQNtot.vServ = oSqlDataReader.Item("vServ")
                        'If Not IsDBNull(oSqlDataReader.Item("vBC")) Then oTNFe.infNFe.total.ISSQNtot.vBC = oSqlDataReader.Item("vBC")
                        'If Not IsDBNull(oSqlDataReader.Item("vISS")) Then oTNFe.infNFe.total.ISSQNtot.vISS = oSqlDataReader.Item("vISS")
                        'If Not IsDBNull(oSqlDataReader.Item("vPIS")) Then oTNFe.infNFe.total.ISSQNtot.vPIS = oSqlDataReader.Item("vPIS")
                        'If Not IsDBNull(oSqlDataReader.Item("vCOFINS")) Then oTNFe.infNFe.total.ISSQNtot.vCOFINS = oSqlDataReader.Item("vCOFINS")

                        'Retenção
                        'oTNFe.infNFe.total.retTrib = New TNFeInfNFeTotalRetTrib
                        'If Not IsDBNull(oSqlDataReader.Item("vRetPIS")) Then oTNFe.infNFe.total.retTrib.vRetPIS = oSqlDataReader.Item("vRetPIS")
                        'If Not IsDBNull(oSqlDataReader.Item("vRetCOFINS")) Then oTNFe.infNFe.total.retTrib.vRetCOFINS = oSqlDataReader.Item("vRetCOFINS")
                        'If Not IsDBNull(oSqlDataReader.Item("vRetCSLL")) Then oTNFe.infNFe.total.retTrib.vRetCSLL = oSqlDataReader.Item("vRetCSLL")
                        'If Not IsDBNull(oSqlDataReader.Item("vBCIRRF")) Then oTNFe.infNFe.total.retTrib.vBCIRRF = oSqlDataReader.Item("vBCIRRF")
                        'If Not IsDBNull(oSqlDataReader.Item("vIRRF")) Then oTNFe.infNFe.total.retTrib.vIRRF = oSqlDataReader.Item("vIRRF")
                        'If Not IsDBNull(oSqlDataReader.Item("vBCRetPrev")) Then oTNFe.infNFe.total.retTrib.vBCRetPrev = oSqlDataReader.Item("vBCRetPrev")
                        'If Not IsDBNull(oSqlDataReader.Item("vRetPrev")) Then oTNFe.infNFe.total.retTrib.vRetPrev = oSqlDataReader.Item("vRetPrev")

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_X_Transporte(ByRef oTNFe As TNFe, _
                                                      ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_transportadora_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        oTNFe.infNFe.transp = New TNFeInfNFeTransp
                        oTNFe.infNFe.transp.modFrete = DefineEnum(oSqlDataReader.Item("modFrete"), GetType(TNFeInfNFeTranspModFrete))

                        'Dados Transportadora
                        If Not IsDBNull(oSqlDataReader("codigo_personalidade")) Then
                            oTNFe.infNFe.transp.transporta = New TNFeInfNFeTranspTransporta
                            If oSqlDataReader.Item("cnpj_cpf") <> "" Then oTNFe.infNFe.transp.transporta.ItemElementName = IIf(oSqlDataReader("codigo_personalidade") = Personalidade.fisica, ItemChoiceType2.CPF, ItemChoiceType2.CNPJ)
                            If oSqlDataReader.Item("cnpj_cpf") <> "" Then oTNFe.infNFe.transp.transporta.Item = oSqlDataReader.Item("cnpj_cpf")
                            If oSqlDataReader.Item("xNome") <> "" Then oTNFe.infNFe.transp.transporta.xNome = RetirarAcento(oSqlDataReader.Item("xNome"))
                            If oSqlDataReader.Item("IE") <> "" Then oTNFe.infNFe.transp.transporta.IE = oSqlDataReader.Item("IE")
                            If oSqlDataReader.Item("xEnder") <> "" Then oTNFe.infNFe.transp.transporta.xEnder = RetirarAcento(oSqlDataReader.Item("xEnder"))
                            If oSqlDataReader.Item("xMun") <> "" Then oTNFe.infNFe.transp.transporta.xMun = RetirarAcento(oSqlDataReader.Item("xMun"))
                            If oSqlDataReader.Item("UF") <> "" Then oTNFe.infNFe.transp.transporta.UF = DefineUF(oSqlDataReader.Item("UF")) : oTNFe.infNFe.transp.transporta.UFSpecified = True
                          
                        End If


                        If IsDBNull(oSqlDataReader.Item("codigo_tipo_veiculo")) = False Then
                            ReDim oTNFe.infNFe.transp.ItemsElementName(0)
                            Select Case oSqlDataReader.Item("codigo_tipo_veiculo")
                                Case 0 : oTNFe.infNFe.transp.ItemsElementName(0) = ItemsChoiceType5.balsa
                                Case 1 : oTNFe.infNFe.transp.ItemsElementName(0) = ItemsChoiceType5.reboque
                                Case 2 : oTNFe.infNFe.transp.ItemsElementName(0) = ItemsChoiceType5.vagao
                                Case 3 : oTNFe.infNFe.transp.ItemsElementName(0) = ItemsChoiceType5.veicTransp
                            End Select

                        End If


                        'Retenção de ICMS
                        If Not IsDBNull(oSqlDataReader("vServ")) Then
                            oTNFe.infNFe.transp.retTransp = New TNFeInfNFeTranspRetTransp
                            oTNFe.infNFe.transp.retTransp.vServ = oSqlDataReader("vServ")
                            oTNFe.infNFe.transp.retTransp.vBCRet = oSqlDataReader("vBCRet")
                            oTNFe.infNFe.transp.retTransp.pICMSRet = oSqlDataReader("pICMSRet")
                            oTNFe.infNFe.transp.retTransp.vICMSRet = oSqlDataReader("vICMSRet")
                            oTNFe.infNFe.transp.retTransp.CFOP = oSqlDataReader("CFOP")
                            oTNFe.infNFe.transp.retTransp.cMunFG = oSqlDataReader("cMunFG")
                        End If


                        'Veículo 
                        If IsDBNull(oSqlDataReader.Item("placa")) = False Then
                            If oSqlDataReader.Item("placa") <> "" Then

                                ReDim Preserve oTNFe.infNFe.transp.Items(0)
                                oTNFe.infNFe.transp.Items(0) = New TVeiculo

                                oTNFe.infNFe.transp.Items(0).placa = oSqlDataReader("placa")
                                oTNFe.infNFe.transp.Items(0).UF = DefineUF(oSqlDataReader("UFPlaca"))
                                If Not IsDBNull(oSqlDataReader("RNTC")) Then oTNFe.infNFe.transp.Items(0).RNTC = oSqlDataReader("RNTC")
                            End If
                        End If

                        'Volume
                        Call NFe_X_TransporteVolume(oTNFe.infNFe.transp, _
                                                    lCodigoEmissaoCapa)

                        'Vagão
                        'If Not IsDBNull(oSqlDataReader("vagao")) Then oTNFe.infNFe.transp.veicTransp = oSqlDataReader("vagao")

                        'Balsa
                        'If Not IsDBNull(oSqlDataReader("balsa")) Then oTNFe.infNFe.transp.veicTransp.UF = oSqlDataReader("balsa")

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_X_TransporteReboque(ByRef oTNFeInfNFeTransp As TNFeInfNFeTransp, _
                                                             ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim iReboque As Integer = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_transporte_reboque", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Redimensiona Vetor de DI
                        'ReDim Preserve oTNFeInfNFeTransp.vol.DI(iReboque)
                        'oTNFeItem.prod.DI(iDI) = New TNFeInfNFeDetProdDI

                        ''Seta Valores
                        'oTNFeItem.prod.DI(iDI).nDI = oSqlDataReader.Item("nDI")
                        'oTNFeItem.prod.DI(iDI).dDI = Format(CDate(oSqlDataReader.Item("dDI")), "yyyy-MM-dd")
                        'oTNFeItem.prod.DI(iDI).xLocDesemb = oSqlDataReader.Item("xLocDesemb")
                        'oTNFeItem.prod.DI(iDI).UFDesemb = DefineEnum(oSqlDataReader.Item("UFDesemb"), GetType(TUfEmi))
                        'oTNFeItem.prod.DI(iDI).dDesemb = Format(CDate(oSqlDataReader.Item("dDesemb")), "yyyy-MM-dd")
                        'oTNFeItem.prod.DI(iDI).cExportador = oSqlDataReader.Item("cExportador")

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_X_TransporteVolume(ByRef oTNFeInfNFeTransp As TNFeInfNFeTransp, _
                                                            ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim iVolume As Integer = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_transportadora_volume_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Redimensiona Vetor de Volume
                        ReDim Preserve oTNFeInfNFeTransp.vol(iVolume)
                        oTNFeInfNFeTransp.vol(iVolume) = New TNFeInfNFeTranspVol

                        ''Seta Valores
                        If Not IsDBNull(oSqlDataReader.Item("qVol")) Then oTNFeInfNFeTransp.vol(iVolume).qVol = oSqlDataReader.Item("qVol")
                        If Not IsDBNull(oSqlDataReader.Item("esp")) Then oTNFeInfNFeTransp.vol(iVolume).esp = oSqlDataReader.Item("esp")
                        If Not IsDBNull(oSqlDataReader.Item("marca")) Then oTNFeInfNFeTransp.vol(iVolume).marca = oSqlDataReader.Item("marca")
                        If Not IsDBNull(oSqlDataReader.Item("nVol")) Then oTNFeInfNFeTransp.vol(iVolume).nVol = oSqlDataReader.Item("nVol")
                        If Not IsDBNull(oSqlDataReader.Item("pesoL")) Then oTNFeInfNFeTransp.vol(iVolume).pesoL = oSqlDataReader.Item("pesoL")
                        If Not IsDBNull(oSqlDataReader.Item("pesoB")) Then oTNFeInfNFeTransp.vol(iVolume).pesoB = oSqlDataReader.Item("pesoB")

                        'Carrega XML - Lacre
                        Call NFe_X_TransporteVolumeLacre(oTNFeInfNFeTransp.vol(iVolume), _
                                                         lCodigoEmissaoCapa, _
                                                         oSqlDataReader.Item("codigo"))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_X_TransporteVolumeLacre(ByRef oTNFeInfNFeTranspVol As TNFeInfNFeTranspVol, _
                                                                 ByVal lCodigoEmissaoCapa As Long, _
                                                                 ByVal iCodigoEmissaoTransporteVolume As Integer)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim iLacre As Integer = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Seta Parametros - Código Emissão Transporte Volume
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_emissao_transporte_volume"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = iCodigoEmissaoTransporteVolume

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_transportadora_volume_lacre_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Redimensiona Vetor de Volume
                        ReDim Preserve oTNFeInfNFeTranspVol.lacres(iLacre)
                        oTNFeInfNFeTranspVol.lacres(iLacre) = New TNFeInfNFeTranspVolLacres

                        'Seta Valores
                        oTNFeInfNFeTranspVol.lacres(iLacre).nLacre = RetirarAcento(oSqlDataReader.Item("nLacre"))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_Y_Cobranca(ByRef oTNFe As TNFe, _
                                                    ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_cobranca_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Instancia Objeto
                    oTNFe.infNFe.cobr = New TNFeInfNFeCobr
                    oTNFe.infNFe.cobr.fat = New TNFeInfNFeCobrFat

                    While oSqlDataReader.Read

                        'Dados - Fatura                    
                        If Not IsDBNull(oSqlDataReader.Item("nFat")) Then oTNFe.infNFe.cobr.fat.nFat = RetirarAcento(oSqlDataReader.Item("nFat"))
                        If Not IsDBNull(oSqlDataReader.Item("vOrig")) Then oTNFe.infNFe.cobr.fat.vOrig = oSqlDataReader.Item("vOrig")
                        If Not IsDBNull(oSqlDataReader.Item("vDesc")) Then oTNFe.infNFe.cobr.fat.vDesc = oSqlDataReader.Item("vDesc")
                        If Not IsDBNull(oSqlDataReader.Item("vLiq")) Then oTNFe.infNFe.cobr.fat.vLiq = oSqlDataReader.Item("vLiq")

                        'Duplicata
                        Call NFe_Y_CobrancaDuplicata(oTNFe, lCodigoEmissaoCapa)

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_YA_Pagamento(ByRef oTNFe As TNFe, _
                                                    ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim iNumero = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_cobranca_pagamento_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    'Instancia Objeto
                    oTNFe.infNFe.pag = New TNFeInfNFePag

                    'ReDim oTNFe.infNFe.pag.detPag(0)
                    'oTNFe.infNFe.pag.detPag(0) = New TNFeInfNFePagDetPag


                    While oSqlDataReader.Read

                        ReDim Preserve oTNFe.infNFe.pag.detPag(iNumero)
                        oTNFe.infNFe.pag.detPag(iNumero) = New TNFeInfNFePagDetPag
                        'oTNFe.infNFe.pag.detPag(iNumero).tPag = DefineEnum(oSqlDataReader.Item("tPag"), GetType(TNFeInfNFePagDetPagTPag))
                        oTNFe.infNFe.pag.detPag(iNumero).tPag = oSqlDataReader.Item("tPag")
                        oTNFe.infNFe.pag.detPag(iNumero).vPag = oSqlDataReader.Item("vPag")
                        oTNFe.infNFe.pag.detPag(iNumero).indPag = TNFeInfNFePagDetPagIndPag.Item1
                        'oTNFe.infNFe.pag.detPag(iNumero).UFPag
                        oTNFe.infNFe.pag.detPag(iNumero).indPagSpecified = False
                        'oTNFe.infNFe.pag.detPag(iNumero).dPag

                        iNumero += 1
                        'oTNFe.infNFe.pag.detPag(0).tPag = DefineEnum(oSqlDataReader.Item("tPag"), GetType(TNFeInfNFePagDetPagTPag))
                        'oTNFe.infNFe.pag.detPag(0).vPag = oSqlDataReader.Item("vPag")

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_Y_CobrancaDuplicata(ByRef oTNFe As TNFe, _
                                                             ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim iNumeroDuplicata = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_cobranca_duplicata_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Instancia Objeto
                        ReDim Preserve oTNFe.infNFe.cobr.dup(iNumeroDuplicata)
                        oTNFe.infNFe.cobr.dup(iNumeroDuplicata) = New TNFeInfNFeCobrDup
                        If Not IsDBNull(oSqlDataReader.Item("nDup")) Then oTNFe.infNFe.cobr.dup(iNumeroDuplicata).nDup = oSqlDataReader.Item("nDup")
                        If Not IsDBNull(oSqlDataReader.Item("dVenc")) Then oTNFe.infNFe.cobr.dup(iNumeroDuplicata).dVenc = Format(CDate(oSqlDataReader.Item("dVenc")), "yyyy-MM-dd")
                        If Not IsDBNull(oSqlDataReader.Item("vDup")) Then oTNFe.infNFe.cobr.dup(iNumeroDuplicata).vDup = oSqlDataReader.Item("vDup")

                        iNumeroDuplicata += 1

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_Z_InformacoesAdicionais(ByRef oTNFe As TNFe, _
                                                                 ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_informacoes_adicionais_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Instancia Objeto
                        oTNFe.infNFe.infAdic = New TNFeInfNFeInfAdic
                        If Not IsDBNull(oSqlDataReader.Item("infAdFisco")) Then oTNFe.infNFe.infAdic.infAdFisco = RetirarAcento(oSqlDataReader.Item("infAdFisco"))
                        If Not IsDBNull(oSqlDataReader.Item("infCpl")) Then oTNFe.infNFe.infAdic.infCpl = RetirarAcento(oSqlDataReader.Item("infCpl"))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_ZA_InformacoesComercioExterior(ByRef oTNFe As TNFe, _
                                                                        ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_comercio_exterior_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Instancia Objeto
                        oTNFe.infNFe.exporta = New TNFeInfNFeExporta
                        'oTNFe.infNFe.exporta.UFSaidaPais = DefineUF(oSqlDataReader.Item("UFEmbarq"))
                        oTNFe.infNFe.exporta.UFSaidaPais = DefineEnum(oSqlDataReader.Item("UFEmbarq"), GetType(TUfEmi))
                        oTNFe.infNFe.exporta.xLocExporta = RetirarAcento(oSqlDataReader.Item("xLocEmbarq"))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFe_ZB_InformacoesCompras(ByRef oTNFe As TNFe, _
                                                               ByVal lCodigoEmissaoCapa As Long)

            Try

                'Váriaveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_compras_nfe", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.HasRows = True Then

                    While oSqlDataReader.Read

                        'Instancia Objeto
                        oTNFe.infNFe.compra = New TNFeInfNFeCompra
                        If Not IsDBNull(oSqlDataReader.Item("xNEmp")) Then oTNFe.infNFe.compra.xNEmp = RetirarAcento(oSqlDataReader.Item("xNEmp"))
                        If Not IsDBNull(oSqlDataReader.Item("xPed")) Then oTNFe.infNFe.compra.xPed = RetirarAcento(oSqlDataReader.Item("xPed"))
                        If Not IsDBNull(oSqlDataReader.Item("xCont")) Then oTNFe.infNFe.compra.xCont = RetirarAcento(oSqlDataReader.Item("xCont"))

                    End While

                End If

                'Fecha o oSqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Function DvBase11(ByVal sNumero As String) As String

            Try

                'Váriaveis Locais
                Dim iDv As Integer
                Dim iMultiplicador As Integer
                Dim i As Integer = sNumero.Length - 1

                iMultiplicador = 1
                iDv = 0

                While i >= 0

                    iMultiplicador += 1

                    If (iMultiplicador > 9) Then iMultiplicador = 2

                    iDv += (Int32.Parse(sNumero(i).ToString()) * iMultiplicador)

                    i = i - 1

                End While

                iDv = iDv Mod 11
                If (iDv > 1) Then
                    Return (11 - iDv).ToString()
                Else
                    Return "0"
                End If

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function IncluiLoteNFe(ByVal sArquivoXML As String, _
                                                       ByVal sArquivoLote As String, _
                                                       ByVal sLote As String) As String

            Try

                'Váriaveis Locais
                Dim oXmlDocumentNFe As New XmlDocument
                Dim oXmlDocumentLote As New XmlDocument
                Dim oNodeEnviNFe As XmlNodeList
                Dim oNodeNFe As XmlNodeList
                Dim oStreamWriter As StreamWriter

                'Verifica se Arquivo de Nota Fiscal Existe
                If (File.Exists(sArquivoXML)) Then

                    'Carrega Arquivo de Lote caso ele exista
                    If (File.Exists(sArquivoLote)) Then
                        'Carrega Arquivo
                        oXmlDocumentLote.Load(sArquivoLote)
                    Else
                        'Cria Cabeçalho
                        Dim sCabecalho As String
                        sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?>" & _
                                      "<enviNFe versao=""4.00"" xmlns=""http://www.portalfiscal.inf.br/nfe"">" & _
                                      "<idLote>" & sLote & "</idLote><indSinc>0</indSinc></enviNFe>"
                        'Carrega Arquivo de Cabeçalho
                        oXmlDocumentLote.LoadXml(sCabecalho)
                    End If

                    'Carrega Arquivo de Nota Fiscal
                    oXmlDocumentNFe.Load(sArquivoXML)
                    'Ignora Espaços em Branco
                    oXmlDocumentNFe.PreserveWhitespace = False
                    oXmlDocumentLote.PreserveWhitespace = False

                    'Obtem Elemento enviNFe
                    oNodeEnviNFe = oXmlDocumentLote.GetElementsByTagName("enviNFe")

                    'Adiciona o Node NFe no EnvNFe
                    oNodeNFe = oXmlDocumentNFe.GetElementsByTagName("NFe", "http://www.portalfiscal.inf.br/nfe")
                    oNodeEnviNFe.Item(0).AppendChild(oXmlDocumentLote.ImportNode(oNodeNFe.Item(0), True))

                    'Salva o Arquivo
                    oStreamWriter = File.CreateText(goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sLote & "-env-lot.xml")
                    oStreamWriter.Write(oXmlDocumentLote.OuterXml)
                    oStreamWriter.Close()

                    'Retorna Status
                    Return goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sLote & "-env-lot.xml"

                Else
                    'Retorna se nota nao encontrada
                    Return "ERROR"
                End If

            Catch ex As Exception
                Throw ex
            End Try

        End Function

#End Region

    End Class

End Namespace