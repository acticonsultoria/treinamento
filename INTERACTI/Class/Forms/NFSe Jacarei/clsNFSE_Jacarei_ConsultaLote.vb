Imports System.IO
Imports System.Xml
Imports INTERACTI.NFSE_Jacarei
Imports INTERACTI.NFSE_Jacarei.ConsultarLoteEnvio
Imports INTERACTI.NFSE_Jacarei.ConsultarLoteRetorno
Imports INTERACTI.NFSE_Jacarei.ValidaXML
Imports INTERACTI.NFSE_Jacarei.WebService

Public Class clsNFSE_Jacarei_ConsultaLote

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sProtocolo As String
    Private sInscricaoMunicipal As String

    'Variaveis da Classe - ReadOnly
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String
    Private sCodigoVerificacao As String
    Private dDataEmissao As Date
    Private lNotaFical As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property Protocolo() As String
        Get
            Return sProtocolo
        End Get
        Set(ByVal value As String)
            sProtocolo = value
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

    Public ReadOnly Property CodigoVerificacao() As String
        Get
            Return sCodigoVerificacao
        End Get
    End Property

    Public ReadOnly Property DataEmissao() As Date
        Get
            Return dDataEmissao
        End Get
    End Property

    Public ReadOnly Property NotaFiscal() As Long
        Get
            Return lNotaFical
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsLoteNFSe As New ConsultarLoteRpsEnvio

        Try

            Dim oPrestador As New ConsultarLoteEnvio.tcIdentificacaoPrestador
            Dim otcCpfCnpj As New ConsultarLoteEnvio.tcCpfCnpj
            otcCpfCnpj.ItemElementName = ConsultarLoteEnvio.ItemChoiceType.Cnpj
            otcCpfCnpj.Item = Replace(Replace(Replace(goEmitente.sCNPJ, "-", ""), ".", ""), "/", "")
            oPrestador.CpfCnpj = otcCpfCnpj
            oPrestador.InscricaoMunicipal = Replace(goEmitente.sInscricaoMunicipal, ".", "")

            oTConsLoteNFSe.Prestador = oPrestador
            oTConsLoteNFSe.Protocolo = sProtocolo

            'Seta Arquivo
            sArquivoEnvio = goConfiguracaoNFSe.sPastaEnvio & sProtocolo & "-ped-situacao-nfse.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsLoteNFSe.Save(sArquivoEnvio)


            Dim oXmlDocument As New Xml.XmlDocument
            oXmlDocument = NFSE_Jacarei.AssinaturaDigital.AssinarXML(sArquivoEnvio, "")
            oXmlDocument.Save(sArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
                                                 goConfiguracaoNFSe.sPastaXSD & "servico_enviar_lote_rps_envio.xsd", _
                                                 "servico_enviar_lote_rps_envio.xsd")

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
                        sRetornoWS = WS_ConsultaLoteNFSeHomologacao(sArquivoEnvio)
                    ElseIf goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.producao Then
                        sRetornoWS = WS_ConsultaLoteNFSeProducao(sArquivoEnvio)
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
        Dim oTRetConsultaLote As New ConsultarLoteRpsResposta

        Try

            'Carrega arquivo de Retorno
            oTRetConsultaLote = ConsultarLoteRpsResposta.Load(sArquivo)

            'Carregando o XML para análise
            Dim oXMLDocument As New Xml.XmlDocument
            oXMLDocument.Load(sArquivo)

            'Retornando a mensagem de erro
            sMensagemErro = oXMLDocument.ChildNodes(1).ChildNodes(0).ChildNodes(0).ChildNodes(1).InnerText

            'Limpa Váriaveis
            oTRetConsultaLote = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoVerificacao(ByVal sArquivo As String)

        Try

            'Carregando o XML para análise
            Dim oXMLDocument As New Xml.XmlDocument
            oXMLDocument.Load(sArquivo)

            'Retornando a mensagem de erro
            With oXMLDocument.ChildNodes(1).ChildNodes(0).ChildNodes(0).ChildNodes(0).ChildNodes(0)
                lNotaFical = .ChildNodes(0).InnerText
                sCodigoVerificacao = .ChildNodes(1).InnerText
                dDataEmissao = .ChildNodes(2).InnerText
            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
