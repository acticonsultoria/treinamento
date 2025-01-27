Imports System.IO
Imports System.Xml
Imports INTERACTI.MDFe.Dados
Imports INTERACTI.MDFe.RecepcaoLote
Imports INTERACTI.MDFe.RetRecepcaoLote
Imports INTERACTI.mdfe.ValidaXML
Imports INTERACTI.mdfe.WebService

Public Class clsMDFe_EnvioLote

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe    
    Private lLote As Long

    'Variaveis da Classe - ReadOnly
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String
    Private sProtocolo As String
    Private dDataRecebimento As Date

#End Region

#Region "::: PROPERTIE :::"

    Public Property Lote() As Long
        Get
            Return lLote
        End Get
        Set(ByVal value As Long)
            lLote = value
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

    Public ReadOnly Property Protocolo() As String
        Get
            Return sProtocolo
        End Get
    End Property

    Public ReadOnly Property DataRecebimento() As Date
        Get
            Return dDataRecebimento
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        Try

            'Váriaveis Locais
            Dim sRetornoWS As String

            ''Gera Arquivo NFe
            'If ArquivoMDFE(lLote, sArquivoEnvio, sMensagemErro) = False Then
            '    'Seta Retorno da Função
            '    Return False
            'End If

            Try
            
                sRetornoWS = WSRecepcao(sArquivoEnvio)

            Catch ex As Exception
                'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                File.Delete(sArquivoEnvio)
                File.Delete(goConfiguracaoMDFe.sPastaEnvio & "cabecRecepcaoLote.xml")
                'Seta Informação
                sMensagemErro = ex.Message
                'Retorno da Função
                Return False
            End Try

            'Seta Arquivo de Retorno
            sArquivoRetorno = goConfiguracaoMDFe.sPastaRecibo & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & Format(lLote, "000000") & "-rec.xml"

            'Recebe Arquivo de Retorno do WebService
            Dim oStreamWriter As StreamWriter = File.CreateText(sArquivoRetorno)
            oStreamWriter.Write(sRetornoWS)
            oStreamWriter.Close()

            'Exclui Cabeçalho
            File.Delete(goConfiguracaoMDFe.sPastaEnvio & "cabecRecepcaoLote.xml")

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            'Seta Mensagem de Erro
            sMensagemErro = ex.Message
            'Seta Retorno da Função
            Return False
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sArquivo As String)

        Try

            'Váriaveis Locais
            Dim oTRetEnvioMDFe 'As New EnviarLoteRpsResposta

            'Carrega arquivo de Retorno
            ' oTRetEnvioMDFe = EnviarLoteRpsResposta.Load(sArquivo)

            Dim oXMLDocument As New Xml.XmlDocument
            oXMLDocument.Load(sArquivo)

            If oXMLDocument.InnerXml.Contains("ListaMensagemRetorno") Then
                sMensagemErro = oXMLDocument.ChildNodes(1).ChildNodes(0).ChildNodes(0).ChildNodes(1).InnerText
                sProtocolo = ""
            Else
                sProtocolo = oTRetEnvioMDFe.Protocolo
                dDataRecebimento = oTRetEnvioMDFe.DataRecebimento
                lLote = oTRetEnvioMDFe.NumeroLote
            End If

            'Limpa Váriaveis
            oXMLDocument = Nothing
            oTRetEnvioMDFe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
