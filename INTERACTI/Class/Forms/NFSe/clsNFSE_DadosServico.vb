Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.NFSE.AssinaturaDigital
'Imports INTERACTI.NFSE.EnvioLoteRPS
Imports INTERACTI.NFSE.ValidaXML
Imports INTERACTI.NFSE.GERAL
Imports INTERACTI.SQLHelper

Namespace NFSE.DadosServico

    Public NotInheritable Class clsNFSE_DadosServico

#Region "::: ENUM :::"

        Private Enum TipoFormatacao
            oDecimal_2_Casas = 1
            oDecimal_4_Casas = 2
        End Enum

#End Region

#Region "::: FUNCTION / SUB :::"

        Private Shared lCodigoNFSECapa As Long

        Public Overloads Shared Function ArquivoNFSE(ByVal lLote As Long, _
                                                    ByRef sArquivo As String, _
                                                    ByRef sMensagemErro As String) As Boolean

            Dim oTNFSE As New EnviarLoteRpsEnvio
            Dim oXMLDocument As XmlDocument

            Try

                'Zerando a mensagem de err
                sMensagemErro = ""

                'Zerando o valor da variavel, pois irá puxar de acordo com o lote
                lCodigoNFSECapa = 0

                'Configurando o cabecalho
                Call NFSE_A_Cabecalho(oTNFSE, lLote)

                'Configurando o lote
                Call NFSE_B_DadosLote(oTNFSE)

                'Seta Arquivo
                sArquivo = goConfiguracaoNFSe.sPastaEnvio & IIf(goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.homologacao, "H", "P") & Format(lLote, "000000000") & ".xml"

                'Salva Arquivo XML
                oTNFSE.Save(sArquivo)

                Try

                    'Assina Arquivo - Lote
                    oXMLDocument = AssinarXML(sArquivo, "")
                    oXMLDocument.Save(sArquivo)

                Catch ex As Exception
                    oTNFSE = Nothing
                    'Exclui Arquivo XML (NFe)
                    File.Delete(sArquivo)
                    'Seta Informação
                    sMensagemErro = "Ocorreu um erro ao tentar assinar o Arquivo XML." & vbCrLf & ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Valida Arquivo XML Assinado
                Dim sRetornoValidacao As String = ""

                ''Verifica se Encontrou algum Erro no Arquivo XML
                'sRetornoValidacao = ValidaArquivoXML(sArquivo, _
                '                                     goConfiguracaoNFSe.sPastaXSD & "servico_enviar_lote_rps_envio_v03.xsd", _
                '                                     "servico_enviar_lote_rps_envio_v03.xsd")



                'Verifica se Encontrou algum Erro no Arquivo XML
                sRetornoValidacao = ValidaArquivoXML(sArquivo, _
                                                     goConfiguracaoNFSe.sPastaXSD & "nfse.xsd", _
                                                     "nfse.xsd")

                'Verifica se ocorreu algum erro na Validação
                If sRetornoValidacao <> "" Then

                    'Limpa Váriavel
                    oTNFSE = Nothing
                    'File.Delete(sArquivo)
                    MsgBox(sRetornoValidacao)
                    'Seta Informação
                    sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                    'Retorno da Função
                    Return False

                Else

                    'Obtem Tamanho do Arquivo XML
                    Dim oFileInfo As New FileInfo(sArquivo)

                    'Verifica se o Tamanho do Arquivo XML é maior que o Tamanho Máximo
                    If (oFileInfo.Length / 1000) > goConfiguracaoNFSe.iTamanhoMaximo Then
                        'Limpa Váriavel
                        oTNFSE = Nothing
                        'Exclui Arquivo XML (Status)
                        File.Delete(sArquivo)
                        'Seta Informação
                        sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                        'Retorno da Função
                        Return False
                    End If


                    'Alteração necessária para nova nota joseense - 29/08/2019
                    '******************************************
                    Dim oXML As New XmlDocument
                    oXML.Load(sArquivo)

                    Dim sDados As String = oXML.InnerXml

                    'sDados = Replace(sDados, " xmlns=""http://www.ginfes.com.br/tipos_v03.xsd""", "")
                    'sDados = Replace(sDados, "LoteRps Id=""", "LoteRps xmlns=""http:/www.abrasf.org.br/nfse.xsd"" Id=""")

                    Dim oStreamWriter As New StreamWriter(sArquivo)
                    oStreamWriter.WriteLine(sDados)
                    oStreamWriter.Close()
                    'Alteração necessária para nova nota joseense - 29/08/2019
                    '******************************************




                    Return True

                End If

            Catch ex As Exception
                oTNFSE = Nothing
                sMensagemErro = ex.Message
                Return False
            End Try

        End Function

        Private Overloads Shared Sub NFSE_A_Cabecalho(ByRef oTNFSE As EnviarLoteRpsEnvio, _
                                                      ByVal sLote As String)

            Try

                'Váriaveis Locais
                oTNFSE.LoteRps = New tcLoteRps

                'Váriaveis Locais
                Dim oSqlDataReader As SqlDataReader
                Dim oSqlParameter(1) As SqlParameter
                Dim i As Integer = 0

                'Seta Parametros - Lote
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "lote"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = sLote : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_emitente", oSqlParameter)

                'Verificando se foi encontrado algum Registro
                If oSqlDataReader.Read Then

                    oTNFSE.LoteRps.Cnpj = oSqlDataReader.Item("cnpj")
                    oTNFSE.LoteRps.Id = ""
                    oTNFSE.LoteRps.InscricaoMunicipal = oSqlDataReader.Item("inscricao_municipal")
                    oTNFSE.LoteRps.QuantidadeRps = 1
                    oTNFSE.LoteRps.NumeroLote = sLote
                    oTNFSE.LoteRps.versao = "1.00"

                    lCodigoNFSECapa = oSqlDataReader.Item("codigo_nfse_capa")

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_B_DadosLote(ByRef oTNFSE As EnviarLoteRpsEnvio)

            Try

                'Váriaveis Locais
                Dim oSqlDataReader As SqlDataReader
                Dim oSqlParameter(1) As SqlParameter
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_identificacao", oSqlParameter)

                If oSqlDataReader.Read Then

                    'Iniciando um novo lote
                    ReDim oTNFSE.LoteRps.ListaRps(0)
                    oTNFSE.LoteRps.ListaRps(0) = New tcRps

                    Dim oInfRps As New tcInfRps

                    With oInfRps

                        'Parâmetros
                        .DataEmissao = oSqlDataReader.Item("data_emissao_rps")
                        .Id = ""
                        .IncentivadorCultural = IIf(oSqlDataReader.Item("incentivador_cultural") = True, 1, 2)
                        .NaturezaOperacao = oSqlDataReader.Item("codigo_natureza_operacao_servico")
                        .OptanteSimplesNacional = IIf(oSqlDataReader.Item("codigo_regime_tributario") = CInt(RegimeTributario.SimplesNacional), 1, 2)
                        If IsDBNull(oSqlDataReader.Item("codigo_regime_especial_tributacao_nfse")) = False Then
                            .RegimeEspecialTributacao = oSqlDataReader.Item("codigo_regime_especial_tributacao_nfse")
                            .RegimeEspecialTributacaoSpecified = True
                        End If
                        .Status = oSqlDataReader.Item("status")

                        'Setando Valor
                        oTNFSE.LoteRps.ListaRps(0).InfRps = oInfRps

                    End With

                    'Outras TAG´s
                    Call NFSE_C_Identificacao(oTNFSE)
                    Call NFSE_D_IntermediarioServico(oTNFSE)
                    Call NFSE_E_ConstrucaoCivil(oTNFSE)
                    Call NFSE_F_Prestador(oTNFSE)
                    'Call NFSE_G_RPSSubstituido(oTNFSE)
                    Call NFSE_H_Servico(oTNFSE)
                    Call NFSE_I_Tomador(oTNFSE)

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_C_Identificacao(ByRef oTNFSE As EnviarLoteRpsEnvio)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_identificacao", oSqlParameter)


                If oSqlDataReader.Read Then

                    Dim oIdentificacaoRps As New tcIdentificacaoRps

                    With oIdentificacaoRps

                        'Setando os parâmetros
                        .Numero = oSqlDataReader.Item("numero_rps")
                        .Serie = oSqlDataReader.Item("serie")
                        .Tipo = oSqlDataReader.Item("codigo_tipo_rps")

                    End With

                    'Setando
                    oTNFSE.LoteRps.ListaRps(0).InfRps.IdentificacaoRps = oIdentificacaoRps

                End If

                'Fechando
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_D_IntermediarioServico(ByRef oTNFSE As EnviarLoteRpsEnvio)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_intermediario", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oIdentificacaoIntermediarioServico As New tcIdentificacaoIntermediarioServico

                    'Setando os parâmetros
                    oIdentificacaoIntermediarioServico.RazaoSocial = oSqlDataReader.Item("razao_social")
                    oIdentificacaoIntermediarioServico.CpfCnpj = RetirarAcento2(oSqlDataReader.Item("cnpj_cpf"))
                    If IsDBNull(oSqlDataReader.Item("inscricao_municipal")) = False Then oIdentificacaoIntermediarioServico.InscricaoMunicipal = oSqlDataReader.Item("inscricao_municipal")

                    'Setando
                    oTNFSE.LoteRps.ListaRps(0).InfRps.IntermediarioServico = oIdentificacaoIntermediarioServico

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_E_ConstrucaoCivil(ByRef oTNFSE As EnviarLoteRpsEnvio)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_construcao_civil", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oDadosConstrucaoCivil As New tcDadosConstrucaoCivil

                    oDadosConstrucaoCivil.CodigoObra = oSqlDataReader.Item("codigo_obra")
                    oDadosConstrucaoCivil.Art = oSqlDataReader.Item("codigo_art")

                    'Setando
                    'oTNFSE.LoteRps.ListaRps(0).InfRps.ConstrucaoCivil = oDadosConstrucaoCivil

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_F_Prestador(ByRef oTNFSE As EnviarLoteRpsEnvio)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_prestador", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oIdentificacaoPrestador As New tcIdentificacaoPrestador

                    oIdentificacaoPrestador.Cnpj = RetirarAcento2(oSqlDataReader.Item("cnpj"))
                    oIdentificacaoPrestador.InscricaoMunicipal = oSqlDataReader.Item("inscricao_municipal")

                    oTNFSE.LoteRps.ListaRps(0).InfRps.Prestador = oIdentificacaoPrestador

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_G_RPSSubstituido(ByRef oTNFSE As EnviarLoteRpsEnvio)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_rps_substituido", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oIdentificacaoRpsSubstituido As New tcIdentificacaoRps

                    With oIdentificacaoRpsSubstituido
                        .Numero = oSqlDataReader.Item("Numero")
                        .Serie = oSqlDataReader.Item("Serie")
                        .Tipo = oSqlDataReader.Item("Tipo")
                    End With

                    oTNFSE.LoteRps.ListaRps(0).InfRps.RpsSubstituido = oIdentificacaoRpsSubstituido

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_H_Servico(ByRef oTNFSE As EnviarLoteRpsEnvio)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_servico", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oDadosServico As New tcDadosServico

                    If IsDBNull(oSqlDataReader.Item("codigo_cnae")) = False Then
                        oDadosServico.CodigoCnae = oSqlDataReader.Item("codigo_cnae")
                        oDadosServico.CodigoCnaeSpecified = True
                    End If
                    oDadosServico.CodigoMunicipio = oSqlDataReader.Item("codigo_ibge_municipio")
                    If IsDBNull(oSqlDataReader.Item("codigo_tributacao_municipio")) = False Then
                        oDadosServico.CodigoTributacaoMunicipio = oSqlDataReader.Item("codigo_tributacao_municipio")
                    End If
                    oDadosServico.Discriminacao = oSqlDataReader.Item("descricao")
                    oDadosServico.ItemListaServico = oSqlDataReader.Item("codigo_servico")

                    'oDadosServico.CodigoTributacaoMunicipio = ""
                    'oDadosServico.ItemListaServico = ""

                 
                    'Preenchendo os valores
                    Call NFSE_H1_Servico_Valores(oDadosServico)

                    oTNFSE.LoteRps.ListaRps(0).InfRps.Servico = oDadosServico

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_H1_Servico_Valores(ByRef oDadosServico As tcDadosServico)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_servico_valores", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oValores As New tcValores

                    oValores.AliquotaSpecified = True
                    oValores.IssRetido = IIf(oSqlDataReader.Item("iss_retido") = True, 1, 2)

                    oValores.ValorLiquidoNfse = FormatarNumero(oSqlDataReader.Item("valor_liquido"), TipoFormatacao.oDecimal_2_Casas)
                    oValores.ValorLiquidoNfseSpecified = True
                    If Not IsDBNull(oSqlDataReader.Item("valor_servico")) Then oValores.ValorServicos = FormatarNumero(oSqlDataReader.Item("valor_servico"), TipoFormatacao.oDecimal_2_Casas)
                    If Not IsDBNull(oSqlDataReader.Item("aliquota_iss")) Then
                        oValores.Aliquota = FormatarNumero(oSqlDataReader.Item("aliquota_iss"), TipoFormatacao.oDecimal_4_Casas)
                        oValores.Aliquota = oSqlDataReader.Item("aliquota_iss")
                        oValores.AliquotaSpecified = True
                    Else

                        oValores.AliquotaSpecified = False
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("base_calculo")) Then
                        oValores.BaseCalculo = FormatarNumero(oSqlDataReader.Item("base_calculo"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.BaseCalculoSpecified = True

                    End If
                    If Not IsDBNull(oSqlDataReader.Item("desconto_condicional")) Then
                        oValores.DescontoCondicionado = FormatarNumero(oSqlDataReader.Item("desconto_condicional"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.DescontoCondicionadoSpecified = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("desconto_incondicional")) Then
                        oValores.DescontoIncondicionado = FormatarNumero(oSqlDataReader.Item("desconto_incondicional"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.DescontoIncondicionadoSpecified = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("outras_retencoes")) Then
                        oValores.OutrasRetencoes = FormatarNumero(oSqlDataReader.Item("outras_retencoes"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.OutrasRetencoesSpecified = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("valor_cofins")) Then
                        oValores.ValorCofins = FormatarNumero(oSqlDataReader.Item("valor_cofins"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.ValorCofinsSpecified = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("valor_csll")) Then
                        oValores.ValorCsll = FormatarNumero(oSqlDataReader.Item("valor_csll"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.ValorCsllSpecified = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("valor_deducoes")) Then
                        oValores.ValorDeducoes = FormatarNumero(oSqlDataReader.Item("valor_deducoes"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.ValorDeducoesSpecified = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("valor_inss")) Then
                        oValores.ValorInss = FormatarNumero(oSqlDataReader.Item("valor_inss"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.ValorInssSpecified = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("valor_ir")) Then
                        oValores.ValorIr = FormatarNumero(oSqlDataReader.Item("valor_ir"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.ValorIrSpecified = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("valor_iss")) Then
                        oValores.ValorIss = FormatarNumero(oSqlDataReader.Item("valor_iss"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.ValorIssSpecified = True
                    Else
                        oValores.ValorIssSpecified = False
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("valor_iss_retido")) Then
                        oValores.ValorIssRetido = FormatarNumero(oSqlDataReader.Item("valor_iss_retido"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.ValorIssRetidoSpecified = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("valor_pis")) Then
                        oValores.ValorPis = FormatarNumero(oSqlDataReader.Item("valor_pis"), TipoFormatacao.oDecimal_2_Casas)
                        oValores.ValorPisSpecified = True
                    End If


            


                    oValores.ValorDeducoes = FormatarNumero(0, TipoFormatacao.oDecimal_2_Casas)
                    oValores.OutrasRetencoes = FormatarNumero(0, TipoFormatacao.oDecimal_2_Casas)
                    oValores.OutrasRetencoesSpecified = True
                    oValores.ValorDeducoesSpecified = True


                    'oValores.ValorIssRetidoSpecified = False
                    'oValores.ValorPisSpecified = False
                    'oValores.ValorCofinsSpecified = False
                    'oValores.ValorIrSpecified = False
                    'oValores.ValorCsllSpecified = False
                    'oValores.DescontoCondicionadoSpecified = False
                    'oValores.DescontoIncondicionadoSpecified = False
                    'oValores.OutrasRetencoesSpecified = False
                    'oValores.ValorInssSpecified = False
                    'oValores.ValorLiquidoNfseSpecified = False
                    'oValores.ValorDeducoesSpecified = False







                    oDadosServico.Valores = oValores

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_I_Tomador(ByRef oTNFSE As EnviarLoteRpsEnvio)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_tomador", oSqlParameter)


                If oSqlDataReader.Read Then

                    Dim oDadosTomador As New tcDadosTomador

                    oDadosTomador.RazaoSocial = oSqlDataReader.Item("razao_social")

                    'Preenchendo outras informações
                    Call NFSE_I1_Tomador_Identificacao(oDadosTomador)
                    Call NFSE_I2_Tomador_Endereco(oDadosTomador)
                    Call NFSE_I3_Tomador_Contato(oDadosTomador)

                    oTNFSE.LoteRps.ListaRps(0).InfRps.Tomador = oDadosTomador

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_I1_Tomador_Identificacao(ByRef oDadosTomador As tcDadosTomador)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_tomador", oSqlParameter)

                If oSqlDataReader.Read Then

                    If oSqlDataReader.Item("cnpj_cpf") <> "" Then

                        Dim oIdentificacaoTomador As New tcIdentificacaoTomador
                        Dim oTcCPFCNPJ As New tcCpfCnpj

                        If oSqlDataReader.Item("codigo_personalidade") = CInt(Personalidade.juridica) Then
                            oTcCPFCNPJ.ItemElementName = ItemChoiceType.Cnpj
                            oTcCPFCNPJ.Item = oSqlDataReader.Item("cnpj_cpf")
                        ElseIf oSqlDataReader.Item("codigo_personalidade") = CInt(Personalidade.fisica) Then
                            oTcCPFCNPJ.ItemElementName = ItemChoiceType.Cpf
                            oTcCPFCNPJ.Item = oSqlDataReader.Item("cnpj_cpf")
                        End If
                        oIdentificacaoTomador.CpfCnpj = oTcCPFCNPJ

                        If oSqlDataReader.Item("inscricao_municipal") <> "" Then
                            oIdentificacaoTomador.InscricaoMunicipal = oSqlDataReader.Item("inscricao_municipal")
                        End If

                        oDadosTomador.IdentificacaoTomador = oIdentificacaoTomador

                    End If

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_I2_Tomador_Endereco(ByRef oDadosTomador As tcDadosTomador)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_tomador_endereco", oSqlParameter)


                If oSqlDataReader.Read Then

                    Dim oEndereco As New tcEndereco

                    With oEndereco
                        If IsDBNull(oSqlDataReader.Item("bairro")) = False Then
                            .Bairro = oSqlDataReader.Item("bairro")
                        End If
                        If IsDBNull(oSqlDataReader.Item("cep")) = False Then
                            .Cep = CLng(Replace(oSqlDataReader.Item("cep"), "-", ""))
                            .CepSpecified = True
                        End If
                        If IsDBNull(oSqlDataReader.Item("codigo_ibge")) = False Then
                            .CodigoMunicipio = oSqlDataReader.Item("codigo_ibge")
                            .CodigoMunicipioSpecified = True
                        End If
                        If IsDBNull(oSqlDataReader.Item("complemento")) = False Then
                            .Complemento = oSqlDataReader.Item("complemento")
                        End If
                        If IsDBNull(oSqlDataReader.Item("logradouro")) = False Then
                            .Endereco = oSqlDataReader.Item("logradouro")
                        End If
                        If IsDBNull(oSqlDataReader.Item("numero")) = False Then
                            .Numero = oSqlDataReader.Item("numero")
                        End If
                        If IsDBNull(oSqlDataReader.Item("uf")) = False Then
                            .Uf = oSqlDataReader.Item("uf")
                        End If
                    End With

                    oDadosTomador.Endereco = oEndereco

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Overloads Shared Sub NFSE_I3_Tomador_Contato(ByRef oDadosTomador As tcDadosTomador)

            Try

                'Váriaiveis Locais
                Dim oSqlParameter(1) As SqlParameter
                Dim oSqlDataReader As SqlDataReader
                Dim i As Integer = 0

                'Seta Parametros - Código Emissão NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFSECapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_xml_tomador_contato", oSqlParameter)

                If oSqlDataReader.Read Then

                    Dim oContato As New tcContato

                    With oContato
                        If IsDBNull(oSqlDataReader.Item("email")) = False Then
                            .Email = oSqlDataReader.Item("email")
                        End If
                        If IsDBNull(oSqlDataReader.Item("telefone")) = False Then
                            .Telefone = oSqlDataReader.Item("telefone")
                        End If
                    End With

                    oDadosTomador.Contato = oContato

                End If

                'Fechando o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Private Shared Function FormatarNumero(ByVal dValor As Double, ByVal oTipo As TipoFormatacao) As String

            Try
                Dim sValor As String = ""

                If oTipo = TipoFormatacao.oDecimal_2_Casas Then
                    sValor = Format(dValor, "0.00")
                ElseIf oTipo = TipoFormatacao.oDecimal_4_Casas Then
                    sValor = Format(dValor, "0.0000")
                End If

                FormatarNumero = sValor
            Catch ex As Exception
                Throw ex
            End Try

        End Function

#End Region

    End Class

End Namespace