Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.DownloadNFe
Imports INTERACTI.NFe.RetDownloadNFe
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V2

Public Class clsNFeDownloadNFe

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sChaveAcesso As String
    Private sPathArquivoEnvio As String
    Private sPathArquivoRetorno As String
    Private sArquivoXML As String
    'Variaveis da Classe - ReadOnly
    Private sMensagemErro As String
    Private sVersao As String
    Private sVersaoAplicativo As String
    Private iStatus As Integer
    Private sMotivo As String
    Private sProtocolo As String
    Private sDataRecibo As String
    Private sUF As String
    Private sAmbiente As String

#End Region

#Region "::: PROPERTIE :::"

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

    Public Property ChaveAcesso() As String
        Get
            Return sChaveAcesso
        End Get
        Set(ByVal value As String)
            sChaveAcesso = value
        End Set
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

    Public ReadOnly Property Protocolo() As String
        Get
            Return sProtocolo
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

    Public Function Send(ByVal sChaveAcesso As String) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTDownloadNFe As New TDownloadNFe

        Try
            Call LoadDadosEmitente()

            Dim oChNFe(0) As String
            oChNFe(0) = sChaveAcesso

            oTDownloadNFe.chNFe = oChNFe
            oTDownloadNFe.CNPJ = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")
            oTDownloadNFe.tpAmb = DownloadNFe.TAmb.Item1
            oTDownloadNFe.versao = DownloadNFe.TVerDownloadNFe.Item100
            oTDownloadNFe.xServ = TDownloadNFeXServ.DOWNLOADNFE

            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-download-nfe.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTDownloadNFe.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "downloadNFe_v1.00.xsd")

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

                    'Executa Serviço (SÍNCRONO)
                    sRetornoWS = WSDownloadNFe(sPathArquivoEnvio)

                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(sPathArquivoEnvio)
                    File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & sChaveAcesso & "-ret-situacao-nf.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
                oStreamWriter.Write(sRetornoWS)
                oStreamWriter.Close()

                'Exclui Cabeçalho
                File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sCaminho As String)

        'Váriaveis Locais
        Dim oTRetDownloadNFe As New TRetDownloadNFe

        Try

            'Carrega arquivo de Retorno
            oTRetDownloadNFe = TRetDownloadNFe.Load(sPathArquivoRetorno)

            If oTRetDownloadNFe.cStat = "139" Then

                If oTRetDownloadNFe.retNFe(0).cStat = "140" Then

                    'Salvando o arquivo
                    oTRetDownloadNFe.retNFe(0).procNFe.Save(sCaminho)

                    'Lendo o arquivo
                    Dim oStreamReader As New System.IO.StreamReader(sCaminho)
                    Dim sNFeDados As String = oStreamReader.ReadToEnd
                    oStreamReader.Close()

                    'Quebrando até o processo
                    Dim sCabecalho As String = "<?xml version=""1.0"" encoding=""utf-8""?>"
                    sNFeDados = Mid(sNFeDados, InStr(sNFeDados, "<nfe"))
                    sNFeDados = Replace(sNFeDados, "</TRetDownloadNFeRetNFeProcNFe>", "").Trim

                    'Abrindo como XML
                    Dim oXmlDocument As New XmlDocument
                    oXmlDocument.LoadXml(sCabecalho + sNFeDados)
                    oXmlDocument.Save(sCaminho)
                    sMensagemErro = ""

                Else
                    sMensagemErro = oTRetDownloadNFe.retNFe(0).xMotivo
                End If

            Else
                sMensagemErro = oTRetDownloadNFe.xMotivo
            End If

            'Limpa Váriaveis
            oTRetDownloadNFe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
