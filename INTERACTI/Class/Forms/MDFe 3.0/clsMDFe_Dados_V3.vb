Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.MDFe.AssinaturaDigital
Imports INTERACTI.MDFe.RecepcaoLote_V3
Imports INTERACTI.MDFe.ValidaXML
Imports INTERACTI.SQLHelper

Namespace MDFe.Dados

    Public NotInheritable Class clsMDFe_Dados


#Region "::: FUNCTION / SUB :::"

        Private Shared lCodigoMDFECapa As Long

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

        Public Overloads Shared Function IncluiLoteMDFe(ByVal sArquivoXML As String, _
                                                       ByVal sArquivoLote As String, _
                                                       ByVal sLote As String) As String

            Try

                'Váriaveis Locais
                Dim oXmlDocumentMDFe As New XmlDocument
                Dim oXmlDocumentLote As New XmlDocument
                Dim oNodeEnviMDFe As XmlNodeList
                Dim oNodeMDFe As XmlNodeList
                Dim oStreamWriter As StreamWriter

                If (File.Exists(sArquivoXML)) Then

                    If (File.Exists(sArquivoLote)) Then
                        oXmlDocumentLote.Load(sArquivoLote)
                    Else
                        Dim sCabecalho As String
                        sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?>" & _
                                      "<enviMDFe versao=""3.00"" xmlns=""http://www.portalfiscal.inf.br/mdfe"">" & _
                                      "<idLote>" & sLote & "</idLote></enviMDFe>"
                       oXmlDocumentLote.LoadXml(sCabecalho)
                    End If

                    oXmlDocumentMDFe.Load(sArquivoXML)
                    oXmlDocumentMDFe.PreserveWhitespace = False
                    oXmlDocumentLote.PreserveWhitespace = False

                    oNodeEnviMDFe = oXmlDocumentLote.GetElementsByTagName("enviMDFe")

                    oNodeMDFe = oXmlDocumentMDFe.GetElementsByTagName("MDFe", "http://www.portalfiscal.inf.br/mdfe")
                    oNodeEnviMDFe.Item(0).AppendChild(oXmlDocumentLote.ImportNode(oNodeMDFe.Item(0), True))

                    'Salva o Arquivo
                    oStreamWriter = File.CreateText(goConfiguracaoMDFe.sPastaEnvio & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & sLote & "-env-lot.xml")
                    oStreamWriter.Write(oXmlDocumentLote.OuterXml)
                    oStreamWriter.Close()

                    'Retorna Status
                    Return goConfiguracaoMDFe.sPastaEnvio & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & sLote & "-env-lot.xml"

                Else
                    'Retorna se nota nao encontrada
                    Return "ERROR"
                End If

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function ArquivoMDFE(ByVal lLote As Long, _
                                                    ByRef sArquivo As String, _
                                                    ByRef sMensagemErro As String, _
                                                    ByRef sChaveAcesso As String) As Boolean


            Dim oMDFe As New TMDFe
            Dim oXMLDocument As XmlDocument

            Try
                oMDFe.infMDFe = New TMDFeInfMDFe
                oMDFe.infMDFe.ide = New TMDFeInfMDFeIde

                'Dados da Nota Fiscal Eletronica
                Call MDFE_A_Cabecalho(oMDFe)                 'Dados
                Call MDFE_B_Identificacao(oMDFe, lLote)  'Identificação            

                'Pré Chave de Acesso
                sChaveAcesso = goConfiguracaoMDFe.sCodigoEstado & _
                               Format(CDate(oMDFe.infMDFe.ide.dhEmi), "yyMM") & _
                               Format(oMDFe.infMDFe.emit.CNPJ) & _
                               "58" & _
                               oMDFe.infMDFe.ide.serie.ToString().PadLeft(3, "0") & _
                               oMDFe.infMDFe.ide.nMDF.ToString().PadLeft(9, "0") & _
                               CInt(goConfiguracaoMDFe.iModoOperacaoMDFe) & _
                               oMDFe.infMDFe.ide.cMDF.ToString().PadLeft(8, "0")

                'Digito Verificador
                oMDFe.infMDFe.ide.cDV = DvBase11(sChaveAcesso)

                'Chave de Acesso
                sChaveAcesso = oMDFe.infMDFe.Id & sChaveAcesso & oMDFe.infMDFe.ide.cDV
                oMDFe.infMDFe.Id = "MDFe" & sChaveAcesso

                'Seta Arquivo
                sArquivo = goConfiguracaoMDFe.sPastaEnvio & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & sChaveAcesso & ".xml"

                'Salva Arquivo XML
                oMDFe.Save(sArquivo)

                'Desoneração do ICMS
                Dim oTempReader As New StreamReader(sArquivo)
                Dim sDados As String = oTempReader.ReadToEnd
                oTempReader.Close()

               sDados = Replace(sDados, " xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "")

                Dim oTempWriter As New StreamWriter(sArquivo)
                oTempWriter.WriteLine(sDados)
                oTempWriter.Close()


                Try

                    'Assina Arquivo
                    oXMLDocument = AssinarXML(sArquivo, "infMDFe")

                Catch ex As Exception
                    oMDFe = Nothing
                    'Exclui Arquivo XML (MDFe)
                    File.Delete(sArquivo)
                    'Seta Informação
                    sMensagemErro = "Ocorreu um erro ao tentar assinar o Arquivo XML." & vbCrLf & ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Exclui Arquivo XML (MDFe)
                File.Delete(sArquivo)

                'Seta Arquivo 
                sArquivo = goConfiguracaoMDFe.sPastaEnvio & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & sChaveAcesso & "-ass.xml"
                'Salva Arquivo XML Assinado
                oXMLDocument.Save(sArquivo)



                'Valida Arquivo XML Assinado
                Dim sRetornoValidacao As String = ""
                'Dim s As String = "C:\Users\tharcius.pivetta\Desktop\50151055163745000244580010000000031000285406-procMDFe.xml"
                'Verifica se Encontrou algum Erro no Arquivo XML
                sRetornoValidacao = ValidaArquivoXML(sArquivo, _
                                                     goConfiguracaoMDFe.sPastaXSD & "mdfe_v3.00.xsd",
                                                     "mdfe_v3.00.xsd")



                'Verifica se ocorreu algum erro na Validação
                If sRetornoValidacao <> "" Then

                    'Limpa Váriavel
                    oMDFe = Nothing
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
                    If (oFileInfo.Length / 1000) > goConfiguracaoMDFe.iTamanhoMaximo Then
                        'Limpa Váriavel
                        oMDFe = Nothing
                        'Seta Informação
                        sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                        'Retorno da Função
                        Return False
                    End If

                    'Inclui Lote no Arquivo XML
                    Dim sArquivoLote = IncluiLoteMDFe(sArquivo, _
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
                oMDFe = Nothing
                sMensagemErro = ex.Message
                Return False
            End Try

        End Function

        Private Overloads Shared Sub MDFE_A_Cabecalho(ByRef oTMDFe As TMDFe)

            Try

                
                'Dados da Nota Fislca
                oTMDFe.infMDFe.versao = "3.00"
                oTMDFe.infMDFe.Id = ""

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_B_Identificacao(ByRef oTMDFE As TMDFe, _
                                                          ByVal lLote As Long)

            Try

                'Váriaveis(Locais)
                Dim oSqlDataReader As SqlDataReader
                Dim oSqlParameter(1) As SqlParameter
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão MDFe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "lote"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lLote : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_identificacao", oSqlParameter)

                If oSqlDataReader.Read Then

                    oTMDFE.infMDFe.ide.cUF = DefineEnum(oSqlDataReader.Item("cUF"), GetType(TCodUfIBGE))
                    oTMDFE.infMDFe.ide.tpAmb = IIf(oSqlDataReader.Item("tpAmb") = 1, TAmb.Item1, TAmb.Item2)
                    oTMDFE.infMDFe.ide.tpEmit = TEmit.Item2
                    oTMDFE.infMDFe.ide.mod = DefineEnum(oSqlDataReader.Item("mod"), GetType(TModMD))
                    oTMDFE.infMDFe.ide.serie = oSqlDataReader.Item("serie")
                    oTMDFE.infMDFe.ide.nMDF = oSqlDataReader.Item("nMDF")

                    Dim oRandom As New Random
                    Dim iRandom As Integer = oRandom.Next(99999999)
                    oTMDFE.infMDFe.ide.cMDF = Format(iRandom, "00000000")


                    oTMDFE.infMDFe.ide.modal = DefineEnum(oSqlDataReader.Item("modal"), GetType(TModalMD))
                    oTMDFE.infMDFe.ide.mod = DefineEnum(oSqlDataReader.Item("mod"), GetType(TModMD))

                    oTMDFE.infMDFe.ide.dhEmi = Format(CDate(oSqlDataReader.Item("dhEmi")), "yyyy-MM-ddThh:mm:ss") + LoadFusoHorario()
                    oTMDFE.infMDFe.ide.tpEmis = DefineEnum(oSqlDataReader.Item("tpEmis"), GetType(TMDFeInfMDFeIdeTpEmis))

                    oTMDFE.infMDFe.ide.verProc = oSqlDataReader.Item("verProc")

                    oTMDFE.infMDFe.ide.UFIni = DefineUF(oSqlDataReader.Item("UFIni"))
                    oTMDFE.infMDFe.ide.UFFim = DefineUF(oSqlDataReader.Item("UFFim"))

                    oTMDFE.infMDFe.ide.dhIniViagem = Format(CDate(oSqlDataReader.Item("dhIniViagem")), "yyyy-MM-ddThh:mm:ss") + LoadFusoHorario()

                    lCodigoMDFECapa = oSqlDataReader.Item("codigo_emissao_capa")

                    'Demais operações
                    Call MDFE_C_Municipio_Carregamento(oTMDFE)
                    Call MDFE_D_Percurso(oTMDFE)
                    Call MDFE_E_Emitente(oTMDFE)
                    Call MDFE_F_Endereco_Emitente(oTMDFE)
                    Call MDFE_G_InformacaoDocumentos(oTMDFE)
                    Call MDFE_H_Totalizadores(oTMDFE)
                    Call MDFE_I_Lacres(oTMDFE)
                    Call MDFE_J_AutorizadoXML(oTMDFE)
                    Call MDFE_K_Informacoes_Adicionais(oTMDFE)

                    'Agora faz o layout específico de cada um dos modais
                    Select Case oSqlDataReader("modal")

                        Case 1 'Rodoviário
                            Call MDFE_L01_Rodoviario(oTMDFE)

                        Case 3 'Aquaviário
                            Call MDFE_M01_Aquaviario(oTMDFE)

                    End Select

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_C_Municipio_Carregamento(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_municipio_carregamento", oSqlParameter)


                While oSqlDataReader.Read

                    'Instancia 
                    Dim oTMDFeInfMDFeIdeInfMunCarrega As New TMDFeInfMDFeIdeInfMunCarrega


                    'Setando os parâmetros
                    oTMDFeInfMDFeIdeInfMunCarrega.xMunCarrega = oSqlDataReader.Item("xMunCarrega")
                    oTMDFeInfMDFeIdeInfMunCarrega.cMunCarrega = oSqlDataReader.Item("cMunCarrega")



                    'Redimensiona o vetor
                    If oTMDFE.infMDFe.ide.infMunCarrega Is Nothing Then
                        ReDim oTMDFE.infMDFe.ide.infMunCarrega(0)
                    Else
                        ReDim Preserve oTMDFE.infMDFe.ide.infMunCarrega(oTMDFE.infMDFe.ide.infMunCarrega.Count)
                    End If

                    'Seta agora 
                    oTMDFE.infMDFe.ide.infMunCarrega(oTMDFE.infMDFe.ide.infMunCarrega.Count - 1) = oTMDFeInfMDFeIdeInfMunCarrega


                End While

                ' Fechando()
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_D_Percurso(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_percurso", oSqlParameter)

                While oSqlDataReader.Read

                    Dim oTMDFeInfMDFeIdeInfPercurso As New TMDFeInfMDFeIdeInfPercurso

                    'Setando os parâmetros
                    oTMDFeInfMDFeIdeInfPercurso.UFPer = DefineUF(oSqlDataReader.Item("UFPer"))

                    'Redimensiona o vetor
                    If oTMDFE.infMDFe.ide.infPercurso Is Nothing Then
                        ReDim oTMDFE.infMDFe.ide.infPercurso(0)
                    Else
                        ReDim Preserve oTMDFE.infMDFe.ide.infPercurso(oTMDFE.infMDFe.ide.infPercurso.Count)
                    End If

                    'Seta agora 
                    oTMDFE.infMDFe.ide.infPercurso(oTMDFE.infMDFe.ide.infPercurso.Count - 1) = oTMDFeInfMDFeIdeInfPercurso


                End While

                ' Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_E_Emitente(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_identificacao_emitente", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oTMDFeInfMDFeEmit As New TMDFeInfMDFeEmit

                    oTMDFeInfMDFeEmit.CNPJ = oSqlDataReader.Item("CNPJ")

                    If Not IsDBNull(oSqlDataReader.Item("IE")) Then
                        If oSqlDataReader.Item("IE") <> "ISENTO" And oSqlDataReader.Item("IE") <> "" Then
                            oTMDFeInfMDFeEmit.IE = oSqlDataReader.Item("IE")
                        End If
                    End If

                    oTMDFeInfMDFeEmit.xNome = oSqlDataReader.Item("xNome")
                    oTMDFeInfMDFeEmit.xFant = oSqlDataReader.Item("xFant")

                    'Setando()
                    oTMDFE.infMDFe.emit = oTMDFeInfMDFeEmit

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_F_Endereco_Emitente(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                ' Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_endereco_emitente", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oTEndeEmi As New TEndeEmi

                    oTEndeEmi.xLgr = oSqlDataReader.Item("xLgr")
                    oTEndeEmi.nro = oSqlDataReader.Item("nro")
                    oTEndeEmi.xBairro = oSqlDataReader.Item("xBairro")

                    If Not IsDBNull(oSqlDataReader.Item("xCpl")) Then
                        oTEndeEmi.xCpl = oSqlDataReader.Item("xCpl")
                    End If

                    oTEndeEmi.cMun = oSqlDataReader.Item("cMun")
                    oTEndeEmi.xMun = oSqlDataReader.Item("xMun")
                    oTEndeEmi.CEP = oSqlDataReader.Item("CEP")
                    oTEndeEmi.UF = DefineUF(oSqlDataReader.Item("UF"))
                    oTEndeEmi.fone = oSqlDataReader.Item("fone")

                    'Seta o objeto
                    oTMDFE.infMDFe.emit.enderEmit = oTEndeEmi


                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_G_InformacaoDocumentos(ByRef oTMDFE As TMDFe)

            Try

                ' Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_municipios_descarregamento", oSqlParameter)

                While oSqlDataReader.Read

                    'Instancia 
                    Dim oTMDFeInfMDFeInfMunDescarga As New TMDFeInfMDFeInfMunDescarga

                    'Seta valores
                    oTMDFeInfMDFeInfMunDescarga.cMunDescarga = oSqlDataReader.Item("cMunDescarga")
                    oTMDFeInfMDFeInfMunDescarga.xMunDescarga = oSqlDataReader.Item("xMunDescarga")

                   
                    'Redimensiona o vetor
                    ReDim oTMDFE.infMDFe.infDoc(0)
                    oTMDFE.infMDFe.infDoc(0) = New TMDFeInfMDFeInfMunDescarga

                    'Seta o objeto
                    oTMDFE.infMDFe.infDoc(0) = oTMDFeInfMDFeInfMunDescarga

                    'Preenche as NF-e
                    Call MDFE_G1_InformacaoDocumento_NFe(oTMDFeInfMDFeInfMunDescarga)


                End While

                

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_G1_InformacaoDocumento_NFe(ByRef oTMDFeInfMDFeInfMunDescarga As TMDFeInfMDFeInfMunDescarga)

            Try

                ' Váriaiveis(Locais)
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1


                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_informacao_documento_nfe", oSqlParameter)

                While oSqlDataReader.Read

                    'Instancia 
                    Dim oTMDFeInfMDFeInfMunDescargaInfNFe As New TMDFeInfMDFeInfMunDescargaInfNFe

                    'Seta os valores
                    oTMDFeInfMDFeInfMunDescargaInfNFe.chNFe = oSqlDataReader.Item("chNFe")

                    'Segundo código de barra
                    If Not IsDBNull(oSqlDataReader.Item("SegCodBarra")) Then
                        oTMDFeInfMDFeInfMunDescargaInfNFe.SegCodBarra = oSqlDataReader.Item("SegCodBarra")
                    End If

                    'Seta as unidades de transporte
                    Call MDFE_G2_InformacaoDocumento_NFe_UnidadeTransporte(oTMDFeInfMDFeInfMunDescargaInfNFe, oSqlDataReader.Item("chNFe"))


                    'Redimensiona o vetor
                    If oTMDFeInfMDFeInfMunDescarga.infNFe Is Nothing Then
                        ReDim oTMDFeInfMDFeInfMunDescarga.infNFe(0)
                    Else
                        ReDim Preserve oTMDFeInfMDFeInfMunDescarga.infNFe(oTMDFeInfMDFeInfMunDescarga.infNFe.Count)
                    End If

                    'Seta agora 
                    oTMDFeInfMDFeInfMunDescarga.infNFe(oTMDFeInfMDFeInfMunDescarga.infNFe.Count - 1) = oTMDFeInfMDFeInfMunDescargaInfNFe



                End While



                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_G2_InformacaoDocumento_NFe_UnidadeTransporte(ByRef oTMDFeInfMDFeInfMunDescargaInfNFe As TMDFeInfMDFeInfMunDescargaInfNFe, _
                                                                                       ByVal sChaveAcesso As String)

            Try

                ' Váriaiveis(Locais)
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                'Seta Parametros - Chave acesso
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "chave_acesso"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = sChaveAcesso : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_informacao_documento_nfe_unidade", oSqlParameter)

                While oSqlDataReader.Read

                    'Instancia 
                    Dim oTUnidadeTransp As New TUnidadeTransp



                    'Seta os valores
                    oTUnidadeTransp.idUnidTransp = oSqlDataReader.Item("idUnidTransp")
                    oTUnidadeTransp.tpUnidTransp = DefineEnum(oSqlDataReader.Item("tpUnidTransp"), GetType(TtipoUnidTransp))


                    'Quantidade rateada
                    If Not IsDBNull(oSqlDataReader.Item("qtdRat")) Then
                        oTUnidadeTransp.qtdRat = oSqlDataReader.Item("qtdRat")
                    End If


                    'Redimensiona o vetor
                    If oTMDFeInfMDFeInfMunDescargaInfNFe.infUnidTransp Is Nothing Then
                        ReDim oTMDFeInfMDFeInfMunDescargaInfNFe.infUnidTransp(0)
                    Else
                        ReDim Preserve oTMDFeInfMDFeInfMunDescargaInfNFe.infUnidTransp(oTMDFeInfMDFeInfMunDescargaInfNFe.infUnidTransp.Count)
                    End If

                    'Insere os lacres
                    Call MDFE_G3_InformacaoDocumento_NFe_UnidadeTransporte_Lacre(oTUnidadeTransp, sChaveAcesso)
                    Call MDFE_G4_InformacaoDocumento_NFe_UnidadeTransporte_Carga(oTUnidadeTransp, sChaveAcesso)

                    'Seta agora 
                    oTMDFeInfMDFeInfMunDescargaInfNFe.infUnidTransp(oTMDFeInfMDFeInfMunDescargaInfNFe.infUnidTransp.Count - 1) = oTUnidadeTransp




                End While



                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_G3_InformacaoDocumento_NFe_UnidadeTransporte_Lacre(ByRef oTUnidadeTransp As TUnidadeTransp, _
                                                                                             ByVal sChaveAcesso As String)

            Try

                ' Váriaiveis(Locais)
                Dim oSqlParameter(3) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1


                'Seta Parametros - Chave acesso
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "chave_acesso"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = sChaveAcesso : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_informacao_documento_nfe_unidade_lacre", oSqlParameter)

                While oSqlDataReader.Read

                    'Instancia 
                    Dim oTUnidadeTranspLacUnidTransp As New TUnidadeTranspLacUnidTransp

                    'Seta valor
                    oTUnidadeTranspLacUnidTransp.nLacre = oSqlDataReader.Item("nLacre")


                    'Redimensiona o vetor
                    If oTUnidadeTransp.lacUnidTransp Is Nothing Then
                        ReDim oTUnidadeTransp.lacUnidTransp(0)
                    Else
                        ReDim Preserve oTUnidadeTransp.lacUnidTransp(oTUnidadeTransp.lacUnidTransp.Count)
                    End If

                    'Seta agora 
                    oTUnidadeTransp.lacUnidTransp(oTUnidadeTransp.lacUnidTransp.Count - 1) = oTUnidadeTranspLacUnidTransp



                End While



                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_G4_InformacaoDocumento_NFe_UnidadeTransporte_Carga(ByRef oTUnidadeTransp As TUnidadeTransp, _
                                                                                             ByVal sChaveAcesso As String)

            Try

                ' Váriaiveis(Locais)
                Dim oSqlParameter(2) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                'Seta Parametros - Chave acesso
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "chave_acesso"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = sChaveAcesso : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_informacao_documento_nfe_unidade_carga", oSqlParameter)

                While oSqlDataReader.Read

                    'Instancia
                    Dim oTUnidCarga As New TUnidCarga
                    oTUnidCarga.idUnidCarga = oSqlDataReader.Item("idUnidCarga")

                    If Not IsDBNull(oSqlDataReader.Item("qtdRat")) Then
                        oTUnidCarga.qtdRat = oSqlDataReader.Item("qtdRat")
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("nLacre")) Then
                        ReDim oTUnidCarga.lacUnidCarga(0)
                        oTUnidCarga.lacUnidCarga(0) = New TUnidCargaLacUnidCarga
                        oTUnidCarga.lacUnidCarga(0).nLacre = oSqlDataReader.Item("nLacre")

                    End If

                    'Seta valor
                    oTUnidCarga.tpUnidCarga = DefineEnum(oSqlDataReader.Item("tpUnidCarga"), GetType(TtipoUnidCarga))


                    'Redimensiona o vetor
                    If oTUnidadeTransp.infUnidCarga Is Nothing Then
                        ReDim oTUnidadeTransp.infUnidCarga(0)
                    Else
                        ReDim Preserve oTUnidadeTransp.infUnidCarga(oTUnidadeTransp.infUnidCarga.Count)
                    End If

                    'Seta agora 
                    oTUnidadeTransp.infUnidCarga(oTUnidadeTransp.infUnidCarga.Count - 1) = oTUnidCarga



                End While



                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_H_Totalizadores(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_totalizadores", oSqlParameter)


                If oSqlDataReader.Read Then

                    Dim oTMDFeInfMDFeTot As New TMDFeInfMDFeTot

                    If oSqlDataReader.Item("qCTe") > 0 Then
                        oTMDFeInfMDFeTot.qCTe = oSqlDataReader.Item("qCTe")
                    End If
                    If oSqlDataReader.Item("qNFe") > 0 Then
                        oTMDFeInfMDFeTot.qNFe = oSqlDataReader.Item("qNFe")
                    End If
                    If oSqlDataReader.Item("qMDFe") > 0 Then
                        oTMDFeInfMDFeTot.qMDFe = oSqlDataReader.Item("qMDFe")
                    End If

                    oTMDFeInfMDFeTot.vCarga = oSqlDataReader.Item("vCarga")
                    oTMDFeInfMDFeTot.cUnid = DefineEnum(oSqlDataReader.Item("cUnid"), GetType(usrCadUnidadeMedida))
                    oTMDFeInfMDFeTot.qCarga = oSqlDataReader.Item("qCarga")

                    'Seta o objeto
                    oTMDFE.infMDFe.tot = oTMDFeInfMDFeTot

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_I_Lacres(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_lacres", oSqlParameter)

                While oSqlDataReader.Read

                    'Instancia 
                    Dim oTMDFeInfMDFeLacres As New TMDFeInfMDFeLacres

                    'Seta valor
                    oTMDFeInfMDFeLacres.nLacre = oSqlDataReader.Item("nLacre")


                    'Redimensiona o vetor
                    If oTMDFE.infMDFe.lacres Is Nothing Then
                        ReDim oTMDFE.infMDFe.lacres(0)
                    Else
                        ReDim Preserve oTMDFE.infMDFe.lacres(oTMDFE.infMDFe.lacres.Count)
                    End If

                    'Seta agora 
                    oTMDFE.infMDFe.lacres(oTMDFE.infMDFe.lacres.Count - 1) = oTMDFeInfMDFeLacres



                End While


                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_J_AutorizadoXML(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_autorizados", oSqlParameter)

                If oSqlDataReader.Read Then

                 
                   
                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_K_Informacoes_Adicionais(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_informacoes_adicionais", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oTMDFeInfMDFeInfAdic As New TMDFeInfMDFeInfAdic

                    If Not IsDBNull(oSqlDataReader.Item("infCpl")) Then
                        oTMDFeInfMDFeInfAdic.infCpl = oSqlDataReader.Item("infCpl")
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("infAdFisco")) Then
                        oTMDFeInfMDFeInfAdic.infAdFisco = oSqlDataReader.Item("infAdFisco")
                    End If


                    'Seta o objeto
                    oTMDFE.infMDFe.infAdic = oTMDFeInfMDFeInfAdic

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_L01_Rodoviario(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_informacoes_rodoviario", oSqlParameter)

                While oSqlDataReader.Read

                    'Instancia 
                    Dim oRodo As New rodo

                    oRodo.infANTT = New rodoInfANTT

                    'Seta valores
                    If Not IsDBNull(oSqlDataReader.Item("CIOT")) Then
                        ReDim oRodo.infANTT.infCIOT(0)
                        oRodo.infANTT.infCIOT(0).CIOT = oSqlDataReader.Item("CIOT")
                        'oRodo.infANTT.infCIOT(0).ItemElementName = 
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("codAgPorto")) Then
                        oRodo.codAgPorto = oSqlDataReader.Item("codAgPorto")
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("RNTRC")) Then
                        oRodo.infANTT.RNTRC = oSqlDataReader.Item("RNTRC")
                    End If

                    'Redimensiona o vetor
                    'ReDim oRodo.infANTT.valePed(0)
                    'oRodo.infANTT.valePed(0) = New rodoInfANTTDisp
                    Call MDFE_L02_Rodoviario_Vale_Pedagio(oRodo)

                    'If oRodo.infANTT.valePed(0).CNPJForn Is Nothing Then
                    '    oRodo.infANTT.valePed(0) = Nothing
                    'End If

                    'Redimensiona o vetor
                    ReDim oRodo.veicReboque(0)
                    oRodo.veicReboque(0) = New rodoVeicReboque
                    Call MDFE_L03_Rodoviario_Veiculo_Reboque(oRodo)

                    If oRodo.veicReboque(0).placa Is Nothing Then
                        oRodo.veicReboque(0) = Nothing
                    End If


                    Call MDFE_L05_Rodoviario_Veiculo_Tracao(oRodo)

                  
                    oTMDFE.infMDFe.infModal = New TMDFeInfMDFeInfModal
                    oTMDFE.infMDFe.infModal.versaoModal = "3.00"


                    'É necessário dar um "load" do xml, instanciar e entao pegar o child node
                    Dim sArquivo As String = goConfiguracaoMDFe.sPastaEnvio & "\rodo.xml"
                    oRodo.Save(sArquivo)

                    'Valida Arquivo XML Assinado
                    Dim sRetornoValidacao As String = ""
                    'Dim s As String = "C:\Users\tharcius.pivetta\Desktop\50151055163745000244580010000000031000285406-procMDFe.xml"
                    'Verifica se Encontrou algum Erro no Arquivo XML
                    sRetornoValidacao = ValidaArquivoXML(sArquivo, _
                                                         goConfiguracaoMDFe.sPastaXSD & "mdfeModalRodoviario_v3.00.xsd",
                                                         "mdfe_v3.00.xsd")



                    'Verifica se ocorreu algum erro na Validação
                    If sRetornoValidacao <> "" Then

                        MsgBox("O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao)

                        'Retorno da Função
                        Exit Sub

                    End If

                    'Instancia o tipo xml
                    Dim oXML As New XmlDocument

                    'Carrega o arquivo salvo
                    oXML.Load(sArquivo)

                    'Seta no Any 
                    oTMDFE.infMDFe.infModal.Any = oXML.GetElementsByTagName("rodo")(0)

                    'tenta excluir o arquivo
                    Try
                        System.IO.File.Delete(sArquivo)
                    Catch ex As Exception : End Try


                End While

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_L02_Rodoviario_Vale_Pedagio(ByRef oRodo As rodo)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_vale_pedagio", oSqlParameter)

                While oSqlDataReader.Read

                    Dim oRodoDisp As New rodoInfANTTDisp
                    ReDim oRodo.infANTT.valePed(0)
                    oRodo.infANTT.valePed(0) = New rodoInfANTTDisp

                    oRodoDisp.CNPJForn = oSqlDataReader.Item("CNPJForn")

                    If Not IsDBNull(oSqlDataReader.Item("CNPJPg")) Then
                        oRodoDisp.Item = oSqlDataReader.Item("CNPJPg")
                        oRodoDisp.ItemElementName = ItemChoiceType3.CNPJPg
                    End If

                    oRodoDisp.nCompra = oSqlDataReader.Item("nCompra")

                    oRodo.infANTT.valePed(0) = oRodoDisp

                End While

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_L03_Rodoviario_Veiculo_Reboque(ByRef oRodo As rodo)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_reboque", oSqlParameter)

                While oSqlDataReader.Read

                    Dim orodoVeicReboque As New rodoVeicReboque

                    orodoVeicReboque.capKG = oSqlDataReader.Item("capKG")

                    If Not IsDBNull(oSqlDataReader.Item("capM3")) Then
                        orodoVeicReboque.capM3 = oSqlDataReader.Item("capM3")
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("cInt")) Then
                        orodoVeicReboque.cInt = oSqlDataReader.Item("cInt")
                    End If

                    orodoVeicReboque.placa = oSqlDataReader.Item("placa")

                    If Not IsDBNull(oSqlDataReader.Item("RENAVAM")) Then
                        orodoVeicReboque.RENAVAM = oSqlDataReader.Item("RENAVAM")
                    End If

                    orodoVeicReboque.tara = oSqlDataReader.Item("tara")

                    orodoVeicReboque.UF = DefineUF(oSqlDataReader.Item("UF"))
                    orodoVeicReboque.tpCar = DefineEnum(oSqlDataReader.Item("tpCar"), GetType(rodoVeicReboqueTpCar))

                   
                    'Preenche as NF-e
                    Call MDFE_L04_Rodoviario_Proprietario_Veiculo_Reboque(orodoVeicReboque)

                    ReDim oRodo.veicReboque(0)
                    oRodo.veicReboque(0) = orodoVeicReboque

                End While

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_L04_Rodoviario_Proprietario_Veiculo_Reboque(ByRef oReboque As rodoVeicReboque)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_proprietario_reboque", oSqlParameter)

                While oSqlDataReader.Read

                    Dim oRodoVeicReboqueProp As New rodoVeicReboqueProp

                    If oSqlDataReader.Item("uf") <> "EX" Then
                        oRodoVeicReboqueProp.ItemElementName = IIf(Len(oSqlDataReader.Item("cnpj_cpf")) = 14, ItemChoiceType.CNPJ, ItemChoiceType.CPF)
                        oRodoVeicReboqueProp.Item = oSqlDataReader.Item("cnpj_cpf")
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("IE")) Then
                        If oSqlDataReader.Item("IE") <> "ISENTO" And oSqlDataReader.Item("IE") <> "" Then
                            oRodoVeicReboqueProp.IE = oSqlDataReader.Item("IE")
                        End If
                    End If

                    oRodoVeicReboqueProp.RNTRC = oSqlDataReader.Item("RNTRC")
                    oRodoVeicReboqueProp.tpProp = DefineEnum(oSqlDataReader.Item("tpProp"), GetType(rodoVeicReboquePropTpProp))
                    oRodoVeicReboqueProp.UF = DefineUF(oSqlDataReader.Item("UF"))
                    oRodoVeicReboqueProp.xNome = oSqlDataReader.Item("Nome")

                    'Seta o retorno
                    oReboque.prop = oRodoVeicReboqueProp
                End While

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_L05_Rodoviario_Veiculo_Tracao(ByRef oRodo As rodo)

           Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_veiculo_tracao", oSqlParameter)

                While oSqlDataReader.Read

                    Dim oRodoVeicTracao As New rodoVeicTracao

                    If Not IsDBNull(oSqlDataReader.Item("capKG")) Then
                        oRodoVeicTracao.capKG = oSqlDataReader.Item("capKG")
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("capM3")) Then
                        oRodoVeicTracao.capM3 = oSqlDataReader.Item("capM3")
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("cInt")) Then
                        oRodoVeicTracao.cInt = oSqlDataReader.Item("cInt")
                    End If

                    oRodoVeicTracao.placa = oSqlDataReader.Item("placa")

                    If Not IsDBNull(oSqlDataReader.Item("RENAVAM")) Then
                        oRodoVeicTracao.RENAVAM = oSqlDataReader.Item("RENAVAM")
                    End If

                    oRodoVeicTracao.tara = oSqlDataReader.Item("tara")

                    oRodoVeicTracao.tpCar = DefineEnum(oSqlDataReader.Item("tpCar"), GetType(rodoVeicTracaoTpCar))
                    oRodoVeicTracao.tpRod = DefineEnum(oSqlDataReader.Item("tpRod"), GetType(rodoVeicTracaoTpRod))
                    oRodoVeicTracao.UF = DefineUF(oSqlDataReader.Item("UF"))

                    'Seta o retorno
                    oRodo.veicTracao = oRodoVeicTracao


                    Call MDFE_L06_Rodoviario_Proprietario_Veiculo_Tracao(oRodoVeicTracao)


                    'Redimensiona o vetor
                    ReDim oRodoVeicTracao.condutor(0)
                    oRodoVeicTracao.condutor(0) = New rodoVeicTracaoCondutor
                    Call MDFE_L07_Rodoviario_Condutor_Veiculo_Tracao(oRodoVeicTracao)


                End While

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_L06_Rodoviario_Proprietario_Veiculo_Tracao(ByRef oRodoVeicTracao As rodoVeicTracao)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_proprietario_veiculo", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oRodoVeicTracaoProp As New rodoVeicTracaoProp

                    If oSqlDataReader.Item("uf") <> "EX" Then
                        oRodoVeicTracaoProp.ItemElementName = IIf(Len(oSqlDataReader.Item("cnpj_cpf")) = 14, ItemChoiceType.CNPJ, ItemChoiceType.CPF)
                        oRodoVeicTracaoProp.Item = oSqlDataReader.Item("cnpj_cpf")
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("IE")) Then
                        If oSqlDataReader.Item("IE") <> "ISENTO" And oSqlDataReader.Item("IE") <> "" Then
                            oRodoVeicTracaoProp.IE = oSqlDataReader.Item("IE")
                        End If
                    End If

                    oRodoVeicTracaoProp.RNTRC = oSqlDataReader.Item("RNTRC")
                    oRodoVeicTracaoProp.tpProp = DefineEnum(oSqlDataReader.Item("tpProp"), GetType(rodoVeicTracaoPropTpProp))
                    oRodoVeicTracaoProp.UF = DefineUF(oSqlDataReader.Item("UF"))
                    oRodoVeicTracaoProp.xNome = oSqlDataReader.Item("Nome")

                    'Seta o retorno
                    oRodoVeicTracao.prop = oRodoVeicTracaoProp
                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_L07_Rodoviario_Condutor_Veiculo_Tracao(ByRef oRodoVeicTracao As rodoVeicTracao)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_condutor_veiculo", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oRodoVeicTracaoCondutor As New rodoVeicTracaoCondutor

                    oRodoVeicTracaoCondutor.CPF = oSqlDataReader.Item("cpf")
                    oRodoVeicTracaoCondutor.xNome = oSqlDataReader.Item("nome")

                    oRodoVeicTracao.condutor(0) = oRodoVeicTracaoCondutor
                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_M01_Aquaviario(ByRef oTMDFE As TMDFe)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_informacoes_aquaviario", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oAquav As New aquav

                    oAquav.cEmbar = oSqlDataReader.Item("cEmbar")
                    'oAquav.CNPJAgeNav = oSqlDataReader.Item("CNPJAgeNav")
                    oAquav.cPrtDest = oSqlDataReader.Item("cPrtDest")
                    oAquav.cPrtEmb = oSqlDataReader.Item("cPrtEmb")
                    oAquav.nViag = oSqlDataReader.Item("nViag")
                    oAquav.tpEmb = oSqlDataReader.Item("tpEmb")
                    oAquav.xEmbar = oSqlDataReader.Item("xEmbar")

                    'Redimensiona o vetor
                    ReDim oAquav.infEmbComb(0)
                    oAquav.infEmbComb(0) = New aquavInfEmbComb
                    Call MDFE_M02_Aquaviario_Embarcacao_Comboio(oAquav)

                    'Redimensiona o vetor
                    ReDim oAquav.infTermCarreg(0)
                    oAquav.infTermCarreg(0) = New aquavInfTermCarreg
                    Call MDFE_M03_Aquaviario_Terminal_Carregamento(oAquav)

                    'Redimensiona o vetor
                    ReDim oAquav.infTermDescarreg(0)
                    oAquav.infTermDescarreg(0) = New aquavInfTermDescarreg
                    Call MDFE_M04_Aquaviario_Terminal_Descarregamento(oAquav)

                    'Redimensiona o vetor
                    ReDim oAquav.infUnidCargaVazia(0)
                    oAquav.infUnidCargaVazia(0) = New aquavInfUnidCargaVazia
                    Call MDFE_M05_Aquaviario_Unidade_Carga_Vazia(oAquav)


                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_M02_Aquaviario_Embarcacao_Comboio(ByRef oAquav As aquav)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_embarcacao_comboio", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oAquavInfEmbComb As New aquavInfEmbComb

                    oAquavInfEmbComb.cEmbComb = oSqlDataReader.Item("cEmbComb")

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_M03_Aquaviario_Terminal_Carregamento(ByRef oAquav As aquav)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_terminal_carregamento", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oAquavInfTermCarreg As New aquavInfTermCarreg

                    oAquavInfTermCarreg.cTermCarreg = oSqlDataReader.Item("cTermCarreg")
                    oAquavInfTermCarreg.xTermCarreg = oSqlDataReader.Item("xTermCarreg")

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_M04_Aquaviario_Terminal_Descarregamento(ByRef oAquav As aquav)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_terminal_descarregamento", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oAquavInfTermDescarreg As New aquavInfTermDescarreg

                    oAquavInfTermDescarreg.cTermDescarreg = oSqlDataReader.Item("cTermDescarreg")
                    oAquavInfTermDescarreg.xTermDescarreg = oSqlDataReader.Item("xTermDescarreg")

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub MDFE_M05_Aquaviario_Unidade_Carga_Vazia(ByRef oAquav As aquav)

            Try

                'Váriaiveis(Locais)
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código MDFE Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoMDFECapa : i += 1

                ' Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa(Query)
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_xml_mdfe_unidade_carga_aquaviario", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oaquavInfUnidCargaVazia As New aquavInfUnidCargaVazia

                    oaquavInfUnidCargaVazia.idUnidCargaVazia = oSqlDataReader.Item("idUnidCargaVazia")
                    oaquavInfUnidCargaVazia.tpUnidCargaVazia = DefineEnum(oSqlDataReader.Item("tpUnidCargaVazia"), GetType(aquavInfUnidCargaVaziaTpUnidCargaVazia))

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub


#End Region

    End Class

End Namespace