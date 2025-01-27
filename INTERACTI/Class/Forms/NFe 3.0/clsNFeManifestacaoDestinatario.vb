Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.ManifestacaoDestinatario
Imports INTERACTI.NFe.RetManifestacaoDestinatario
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V3
Imports INTERACTI.NFe.AssinaturaDigital_V3
Imports System.Data
Imports System.Data.SqlClient
Public Class clsNFeManifestacaoDestinatario

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sPathArquivoEnvio As String
    Private sPathArquivoRetorno As String
    Private sArquivoXML As String
    'Variaveis da Classe - ReadOnly
    Private sMensagemErro As String
    Private sJustificativa As String

#End Region

#Region "::: PROPERTIE :::"
    Public WriteOnly Property Justificativa() As String
        Set(ByVal value As String)
            sJustificativa = value
        End Set
    End Property


    Public ReadOnly Property PathArquivoEnvio() As String
        Get
            Return sPathArquivoEnvio
        End Get
    End Property

    Public ReadOnly Property PathArquivoRetorno() As String
        Get
            Return sPathArquivoRetorno
        End Get
    End Property

    Public ReadOnly Property ArquivoXML() As String
        Get
            Return sArquivoXML
        End Get
    End Property

    Public ReadOnly Property MensagemErro() As String
        Get
            Return sMensagemErro
        End Get
    End Property


#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send(ByVal sChaveAcesso As String, ByVal sSequencia As String, ByVal lLote As Long) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTEvento As New ManifestacaoDestinatario.TEvento
        Try
            'Carregando os dados do emitente
            Call LoadDadosEmitente()


            'Setando os parâmetros

            Dim oTInfEvento As New ManifestacaoDestinatario.TEventoInfEvento
            oTEvento.versao = "1.00"
            oTInfEvento.Id = "ID" + "210200" + sChaveAcesso + "0" + sSequencia '210200 - Confirmação
            oTInfEvento.cOrgao = ManifestacaoDestinatario.TCOrgaoIBGE.Item91 'SVAN
            oTInfEvento.tpAmb = ManifestacaoDestinatario.TAmb.Item1 'Produção
            oTInfEvento.ItemElementName = ManifestacaoDestinatario.ItemChoiceType.CNPJ
            oTInfEvento.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")
            oTInfEvento.chNFe = sChaveAcesso
            oTInfEvento.tpEvento = ManifestacaoDestinatario.TEventoInfEventoTpEvento.Item210200

            Dim dDataEvento As Date = Now
            Dim bHorarioVerao As Boolean = False
            Try
                bHorarioVerao = LoadConfiguracao("tb_cfg_interacti", "horario_verao")
            Catch ex As Exception

            End Try
            If bHorarioVerao = True Then
                dDataEvento = DateAdd(DateInterval.Hour, -1, dDataEvento)
            Else
                dDataEvento = DateAdd(DateInterval.Minute, -15, dDataEvento)
            End If

            oTInfEvento.dhEvento = Format(dDataEvento, "yyyy-MM-dd") + "T" + Format(dDataEvento, "HH:mm:ss") + "-03:00"

            oTInfEvento.nSeqEvento = sSequencia
            oTInfEvento.verEvento = "1.00"


            Dim oTInfEventoDetEvento As New INTERACTI.NFe.ManifestacaoDestinatario.TEventoInfEventoDetEvento
            oTInfEventoDetEvento.descEvento = ManifestacaoDestinatario.TEventoInfEventoDetEventoDescEvento.ConfirmacaodaOperacao  'TEMP
            oTInfEventoDetEvento.versao = ManifestacaoDestinatario.TEventoInfEventoDetEventoVersao.Item100

            oTInfEvento.detEvento = oTInfEventoDetEvento
            oTEvento.infEvento = oTInfEvento


            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-envio-manifestacao-destinatario.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTEvento.Save(sPathArquivoEnvio)

            Dim oXMLDocument As New XmlDocument
            Try

                Dim sNFeDados As String
                Dim oStreamReader As StreamReader
                oStreamReader = File.OpenText(sPathArquivoEnvio)
                sNFeDados = oStreamReader.ReadToEnd
                oStreamReader.Close()

                sNFeDados = Replace(sNFeDados, "xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns=""http://www.portalfiscal.inf.br/nfe"" ", "")
                sNFeDados = Replace(sNFeDados, "xmlns:ds=""http://www.w3.org/2000/09/xmldsig#""", "")
                sNFeDados = Replace(sNFeDados, "xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" ", "")
                sNFeDados = Replace(sNFeDados, "xmlns:xsd=""http://www.w3.org/2001/XMLSchema-instance"" ", "")
                sNFeDados = Replace(sNFeDados, "xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" ", "")

                Dim oXML As New Xml.XmlDocument
                oXML.LoadXml(sNFeDados)
                oXML.Save(sPathArquivoEnvio)

                'Assina Arquivo
                oXMLDocument = AssinarXML(sPathArquivoEnvio, "infEvento")

            Catch ex As Exception
                oTEvento = Nothing
                'Exclui Arquivo XML (NFe)
                File.Delete(sPathArquivoEnvio)
                'Seta Informação
                sMensagemErro = "Ocorreu um erro ao tentar assinar o Arquivo XML." & vbCrLf & ex.Message
                'Retorno da Função
                Return False
            End Try

            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-envio-manifestacao-destinatario-ass.xml"
            oXMLDocument.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "confRecebto_v1.00.xsd")

            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Status)
                File.Delete(sPathArquivoEnvio)

                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                Try

                    'Inclui Lote no Arquivo XML
                    Dim sArquivoLote = IncluiLoteEvento(sPathArquivoEnvio, _
                                                     "", _
                                                     Format(lLote, "000000"))

                    If sArquivoLote = "ERROR" Then
                        sMensagemErro = "Erro ao incluir o lote!"
                        Exit Function
                    End If
                    sPathArquivoEnvio = sArquivoLote

                    'Verifica se Encontrou algum Erro no Arquivo XML
                    sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
                                                         goConfiguracaoNFe.sPastaXSD & "envConfRecebto_v1.00.xsd")


                    If sRetornoValidacao <> "" Then
                        sMensagemErro = sRetornoValidacao
                        Exit Function
                    End If

                    'Executa Serviço (SÍNCRONO)
                    sRetornoWS = WSManifestacaoDestinatario(sPathArquivoEnvio)

                    'Setando o retorno da função
                    sArquivoXML = sRetornoWS
                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(sPathArquivoEnvio)
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & "-ret-ped-envio-manifestacao-destinatario.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
                oStreamWriter.Write(sRetornoWS)
                oStreamWriter.Close()

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function LoadArquivo() As Boolean

        'Váriaveis Locais
        Dim oTRetEnvEvento As New TRetEnvEvento

        Try

            'Carrega arquivo de Retorno
            oTRetEnvEvento = TRetEnvEvento.Load(sPathArquivoRetorno)

            'Se for recebido
            If oTRetEnvEvento.cStat = "128" Then

                If oTRetEnvEvento.retEvento(0).infEvento.cStat = "135" Or oTRetEnvEvento.retEvento(0).infEvento.cStat = "136" Then

                    With oTRetEnvEvento.retEvento(0).infEvento

                        'Inserindo os dados 
                        InsertManifestacao(.chNFe, _
                                           .dhRegEvento, _
                                           .tpEvento, _
                                           .xEvento, _
                                           .nProt, _
                                           "")

                        Return True
                    End With

                Else
                    sMensagemErro = oTRetEnvEvento.retEvento(0).infEvento.xMotivo
                End If

            Else
                sMensagemErro = oTRetEnvEvento.xMotivo
            End If

            'Limpa Váriaveis
            oTRetEnvEvento = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub InsertManifestacao(ByVal sChaveAcesso As String, _
                                  ByVal sDataRegistroEvento As String, _
                                  ByVal sTipoEvento As String, _
                                  ByVal sDescricaoEvento As String, _
                                  ByVal sProtocolo As String, _
                                  ByVal sJustificativa As String)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0
        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDataRegistroEvento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_evento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoEvento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_evento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricaoEvento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProtocolo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sJustificativa : i += 1

            'Executa Quety
            SQLHelper.ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_manifestacao", oSqlParameter)


        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Overloads Shared Function IncluiLoteEvento(ByVal sArquivoXML As String, _
                                                       ByVal sArquivoLote As String, _
                                                       ByVal sLote As String) As String

        Try

            'Váriaveis Locais
            Dim oXmlDocumentEvento As New XmlDocument
            Dim oXmlDocumentLote As New XmlDocument
            Dim oNodeEnviEvento As XmlNodeList
            Dim oNodeEvento As XmlNodeList
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

                    'sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?>" & _
                    '             "<envEvento xmlns=""http://www.portalfiscal.inf.br/nfe"" xmlns:ds=""http://www.w3.org/2000/09/xmldsig#"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://www.portalfiscal.inf.br/envConfRecebto_v1.00.xsd"" versao=""1.00"">" & _
                    '             "<idLote>" & sLote & "</idLote></envEvento>"
                    sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?>" & _
                               "<envEvento xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""1.00"">" & _
                               "<idLote>" & sLote & "</idLote></envEvento>"
                    'Carrega Arquivo de Cabeçalho
                    oXmlDocumentLote.LoadXml(sCabecalho)
                End If

            'Carrega Arquivo de Nota Fiscal
            oXmlDocumentEvento.Load(sArquivoXML)
            'Ignora Espaços em Branco
            oXmlDocumentEvento.PreserveWhitespace = False
            oXmlDocumentLote.PreserveWhitespace = False

            'Obtem Elemento enviNFe
                oNodeEnviEvento = oXmlDocumentLote.GetElementsByTagName("envEvento")

            'Adiciona o Node NFe no EnvNFe
                oNodeEvento = oXmlDocumentEvento.GetElementsByTagName("Evento", "http://www.portalfiscal.inf.br/nfe")
            oNodeEnviEvento.Item(0).AppendChild(oXmlDocumentLote.ImportNode(oNodeEvento.Item(0), True))

            'Salva o Arquivo
                oStreamWriter = File.CreateText(goConfiguracaoNFe.sPastaSaida & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sLote & "-env-lot-evento.xml")
                oStreamWriter.Write(Replace(Replace(oXmlDocumentLote.OuterXml, "<Evento", "<evento"),"</Evento", "</evento"))
            oStreamWriter.Close()

            'Retorna Status
                Return goConfiguracaoNFe.sPastaSaida & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sLote & "-env-lot-evento.xml"

            Else
            'Retorna se nota nao encontrada
            Return "ERROR"
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function SendInformacaoEvento(ByVal sChaveAcesso As String, _
                               ByVal sSequencia As String, _
                               ByVal lLote As Long, _
                               ByVal sJustificativa As String, _
                               ByVal sTipoEvento As String) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTEvento As New ManifestacaoDestinatario.TEvento

        Try

            'Carregando os Dados do Emitente
            Call LoadDadosEmitente()

            'Setando os parâmetros
            Dim oTInfEvento As New ManifestacaoDestinatario.TEventoInfEvento
            oTEvento.versao = "1.00"
            oTInfEvento.Id = "ID" + sTipoEvento + sChaveAcesso + "0" + sSequencia '210240 - Operação Não realizada / 210220 - Desconhecimento da Operação
            oTInfEvento.cOrgao = ManifestacaoDestinatario.TCOrgaoIBGE.Item91 'SVAN
            oTInfEvento.tpAmb = ManifestacaoDestinatario.TAmb.Item1 'Produção
            oTInfEvento.ItemElementName = ManifestacaoDestinatario.ItemChoiceType.CNPJ
            oTInfEvento.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")
            oTInfEvento.chNFe = sChaveAcesso
            If sTipoEvento = "210240" Then
                oTInfEvento.tpEvento = ManifestacaoDestinatario.TEventoInfEventoTpEvento.Item210240
            Else
                oTInfEvento.tpEvento = ManifestacaoDestinatario.TEventoInfEventoTpEvento.Item210220
            End If


            Dim dDataEvento As Date = Now
            dDataEvento = DateAdd(DateInterval.Hour, -1, dDataEvento)
            oTInfEvento.dhEvento = Format(dDataEvento, "yyyy-MM-dd") + "T" + Format(dDataEvento, "HH:mm:ss") + "-03:00"
            oTInfEvento.nSeqEvento = sSequencia
            oTInfEvento.verEvento = "1.00"

            Dim oTInfEventoDetEvento As New INTERACTI.NFe.ManifestacaoDestinatario.TEventoInfEventoDetEvento
            If sTipoEvento = "210240" Then
                oTInfEventoDetEvento.descEvento = ManifestacaoDestinatario.TEventoInfEventoDetEventoDescEvento.OperacaonaoRealizada
            Else
                oTInfEventoDetEvento.descEvento = ManifestacaoDestinatario.TEventoInfEventoDetEventoDescEvento.DesconhecimentodaOperacao
            End If
            oTInfEventoDetEvento.versao = ManifestacaoDestinatario.TEventoInfEventoDetEventoVersao.Item100
            oTInfEventoDetEvento.xJust = sJustificativa

            oTInfEvento.detEvento = oTInfEventoDetEvento
            oTEvento.infEvento = oTInfEvento

            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-envio-manifestacao-destinatario.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTEvento.Save(sPathArquivoEnvio)

            Dim oXMLDocument As New XmlDocument

            Try

                'Assina Arquivo
                oXMLDocument = AssinarXML(sPathArquivoEnvio, "infEvento")

            Catch ex As Exception
                oTEvento = Nothing
                'Exclui Arquivo XML (NFe)
                File.Delete(sPathArquivoEnvio)
                'Seta Informação
                sMensagemErro = "Ocorreu um erro ao tentar assinar o Arquivo XML." & vbCrLf & ex.Message
                'Retorno da Função
                Return False
            End Try

            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-envio-manifestacao-destinatario-ass.xml"
            oXMLDocument.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, goConfiguracaoNFe.sPastaXSD & "confRecebto_v1.00.xsd")

            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Status)
                File.Delete(sPathArquivoEnvio)

                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                Try

                    'Inclui Lote no Arquivo XML
                    Dim sArquivoLote = IncluiLoteEvento(sPathArquivoEnvio, "", Format(lLote, "000000"))

                    If sArquivoLote = "ERROR" Then
                        sMensagemErro = "Erro ao incluir o lote!"
                        Exit Function
                    End If

                    sPathArquivoEnvio = sArquivoLote

                    'Verifica se Encontrou algum Erro no Arquivo XML
                    sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, goConfiguracaoNFe.sPastaXSD & "envConfRecebto_v1.00.xsd")

                    If sRetornoValidacao <> "" Then
                        sMensagemErro = sRetornoValidacao
                        Exit Function
                    End If

                    'Executa Serviço (SÍNCRONO)
                    sRetornoWS = WSManifestacaoDestinatario(sPathArquivoEnvio)

                    'Setando o retorno da função
                    sArquivoXML = sRetornoWS

                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(sPathArquivoEnvio)
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & "-ret-ped-envio-manifestacao-destinatario.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
                oStreamWriter.Write(sRetornoWS)
                oStreamWriter.Close()

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function LoadArquivoRecusa(ByVal sJustificativa As String) As Boolean

        'Váriaveis Locais
        Dim oTRetEnvEvento As New TRetEnvEvento

        Try

            'Carrega arquivo de Retorno
            oTRetEnvEvento = TRetEnvEvento.Load(sPathArquivoRetorno)

            'Se for recebido
            If oTRetEnvEvento.cStat = "128" Then

                If oTRetEnvEvento.retEvento(0).infEvento.cStat = "135" Or oTRetEnvEvento.retEvento(0).infEvento.cStat = "136" Then

                    With oTRetEnvEvento.retEvento(0).infEvento

                        'Inserindo os dados 
                        Call InsertManifestacao(.chNFe, _
                                                .dhRegEvento, _
                                                .tpEvento, _
                                                .xEvento, _
                                                .nProt, _
                                                sJustificativa)

                        Return True

                    End With

                Else
                    sMensagemErro = oTRetEnvEvento.retEvento(0).infEvento.xMotivo
                End If

            Else
                sMensagemErro = oTRetEnvEvento.xMotivo
            End If

            'Limpa Váriaveis
            oTRetEnvEvento = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
