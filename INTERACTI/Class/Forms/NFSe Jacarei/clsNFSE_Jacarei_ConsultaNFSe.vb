Imports System.IO
Imports System.Xml
Imports INTERACTI.NFSE_Jacarei
Imports INTERACTI.NFSE_Jacarei.ConsultarNFSeRPSEnvio
Imports INTERACTI.NFSE_Jacarei.ConsultarNFSeRPSRetorno
Imports INTERACTI.NFSE_Jacarei.ValidaXML
Imports INTERACTI.NFSE_Jacarei.WebService
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml

Public Class clsNFSE_Jacarei_ConsultaNFSe

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sProtocolo As String

    'Variaveis da Classe - ReadOnly
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String
    Private sVersao As String
    Private sVersaoAplicativo As String
    Private iStatus As Integer
    Private sMotivo As String
    Private sDataRecibo As String
    Private sUF As String
    Private sAmbiente As String

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

    Public ReadOnly Property Versao() As String
        Get
            Return sVersao
        End Get
    End Property

    Public ReadOnly Property VersaoAplicativo() As String
        Get
            Return sVersaoAplicativo
        End Get
    End Property

    Public ReadOnly Property Status() As Integer
        Get
            Return iStatus
        End Get
    End Property

    Public ReadOnly Property Motivo() As String
        Get
            Return sMotivo
        End Get
    End Property

    Public ReadOnly Property DataRecibo() As String
        Get
            Return sDataRecibo
        End Get
    End Property

    Public ReadOnly Property UF() As String
        Get
            Return sUF
        End Get
    End Property

    Public ReadOnly Property Ambiente() As String
        Get
            Return sAmbiente
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsSitNFSe As New ConsultarNfseRpsEnvio

        Try

            oTConsSitNFSe.Prestador = New NFSE_Jacarei.ConsultarNFSeRPSEnvio.tcIdentificacaoPrestador
            'Informação do prestador
            Dim otcCpfCnpj As New NFSE_Jacarei.ConsultarNFSeRPSEnvio.tcCpfCnpj
            otcCpfCnpj.ItemElementName = ConsultarLoteEnvio.ItemChoiceType.Cnpj
            otcCpfCnpj.Item = Replace(Replace(Replace(goEmitente.sCNPJ, "-", ""), ".", ""), "/", "")
            oTConsSitNFSe.Prestador.CpfCnpj = otcCpfCnpj
            oTConsSitNFSe.Prestador.InscricaoMunicipal = goEmitente.sInscricaoMunicipal

            'Seta Arquivo
            sArquivoEnvio = goConfiguracaoNFSe.sPastaEnvio & sProtocolo & "-ped-situacao-nfse.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsSitNFSe.Save(sArquivoEnvio)

            Dim oXmlDocument As New XmlDocument
            oXmlDocument = NFSE_Jacarei.AssinaturaDigital.AssinarXML(sArquivoEnvio, "")
            oXmlDocument.Save(sArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
                                                 goConfiguracaoNFSe.sPastaXSD & "servico_consultar_nfse_rps_envio.xsd", _
                                                 "servico_consultar_nfse_rps_envio.xsd")

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
                        sRetornoWS = WS_ConsultaNFSeHomologacao(sArquivoEnvio)
                    ElseIf goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.producao Then
                        sRetornoWS = WS_ConsultaNFSeProducao(sArquivoEnvio)
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

#End Region

End Class
