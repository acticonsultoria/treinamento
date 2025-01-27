Imports System.IO
Imports System.Xml
Imports INTERACTI.NFSE
Imports INTERACTI.NFSE.GERAL
Imports INTERACTI.NFSE.ValidaXML
Imports INTERACTI.NFSE.WebService

Public Class clsNFSE_ConsultaSituacaoLoteRPS

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iSituacao As Integer
    Private sProtocolo As String
    Private sInscricaoMunicipal As String

    'Variaveis da Classe - ReadOnly
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String    

#End Region

#Region "::: PROPERTIE :::"

    Public Property Situacao() As Integer
        Get
            Return iSituacao
        End Get
        Set(ByVal value As Integer)
            iSituacao = value
        End Set
    End Property

    Public Property InscricaoMunicipal() As String
        Get
            Return sInscricaoMunicipal
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipal = value
        End Set
    End Property

    Public Property Protocolo() As String
        Get
            Return sProtocolo
        End Get
        Set(ByVal value As String)
            sProtocolo = value
        End Set
    End Property

    Public ReadOnly Property ArquivoEnvio() As String
        Get
            Return sArquivoEnvio
        End Get
    End Property

    Public ReadOnly Property ArquivoRetorno() As String
        Get
            Return sArquivoRetorno
        End Get
    End Property

    Public ReadOnly Property MensagemErro() As String
        Get
            Return sMensagemErro
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsLoteNFSe As New ConsultarSituacaoLoteRpsEnvio

        Try

            Dim oPrestador As New tcIdentificacaoPrestador
            oPrestador.Cnpj = Replace(Replace(Replace(goEmitente.sCNPJ, "-", ""), ".", ""), "/", "")
            oPrestador.InscricaoMunicipal = Replace(goEmitente.sInscricaoMunicipal, ".", "")

            oTConsLoteNFSe.Prestador = oPrestador
            oTConsLoteNFSe.Protocolo = sProtocolo

            'Seta Arquivo
            sArquivoEnvio = goConfiguracaoNFSe.sPastaEnvio & sProtocolo & "-ped-situacao-nfse.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsLoteNFSe.Save(sArquivoEnvio)

            'Dim oXmlDocument As New Xml.XmlDocument
            'oXmlDocument = NFSE.AssinaturaDigital.AssinarXML(sArquivoEnvio, "")
            'oXmlDocument.Save(sArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            ''Verifica se Encontrou algum Erro no Arquivo XML
            'sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
            '                                     goConfiguracaoNFSe.sPastaXSD & "servico_consultar_lote_rps_envio_v03.xsd", _
            '                                     "servico_consultar_lote_rps_envio_v03.xsd")


            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
                                                 goConfiguracaoNFSe.sPastaXSD & "nfse.xsd", _
                                                     "nfse.xsd")


            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Status)
                File.Delete(sArquivoEnvio)
                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                Try
                    'Executa Serviço (SÍNCRONO)
                    If goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.homologacao Then
                        sRetornoWS = WS_ConsultaSituacaoLoteRPSHomologacao(sArquivoEnvio)
                    ElseIf goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.producao Then
                        sRetornoWS = WS_ConsultaSituacaoLoteRPSProducao(sArquivoEnvio)
                    End If
                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(sArquivoEnvio)
                    File.Delete(goConfiguracaoNFSe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sArquivoRetorno = goConfiguracaoNFSe.sPastaEnvio & sProtocolo & "-ret-situacao-nf.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sArquivoRetorno)
                oStreamWriter.Write(sRetornoWS)
                oStreamWriter.Close()

                'Exclui Cabeçalho
                File.Delete(goConfiguracaoNFSe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sArquivo As String)

        'Váriaveis Locais
        Dim oTRetConsSituacaoLote As New ConsultarSituacaoLoteRpsResposta

        Try

            'Carrega arquivo de Retorno
            oTRetConsSituacaoLote = ConsultarSituacaoLoteRpsResposta.Load(sArquivo)

            'Carregando o xml para análise
            Dim oXmlDocument As New Xml.XmlDocument
            oXmlDocument.Load(sArquivo)

            'Recebendo a situação do lote
            iSituacao = oXmlDocument.ChildNodes(1).ChildNodes(1).InnerText

            If iSituacao = 3 Then 'Rejeitada

                Try
                    sMensagemErro = oXmlDocument.ChildNodes(1).ChildNodes(2).ChildNodes(0).ChildNodes(0).InnerText + " - " + _
                                    oXmlDocument.ChildNodes(1).ChildNodes(2).ChildNodes(0).ChildNodes(1).InnerText + " ( " + _
                                    oXmlDocument.ChildNodes(1).ChildNodes(2).ChildNodes(0).ChildNodes(2).InnerText + " )"
                Catch ex As Exception
                    sMensagemErro = "ERRO"
                End Try


            End If


            'Limpando as variáveis
            oXmlDocument = Nothing
            oTRetConsSituacaoLote = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
