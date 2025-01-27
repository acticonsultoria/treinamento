Imports System.IO
Imports System.Xml
Imports INTERACTI.NFSE.DadosServico.clsNFSE_DadosServico
'Imports INTERACTI.NFSE.EnvioLoteRPS
'Imports INTERACTI.NFSE.RetEnvioLoteRPS
Imports INTERACTI.NFSE.GERAL
Imports INTERACTI.NFSE.ValidaXML
Imports INTERACTI.NFSE.WebService




Public Class clsNFSE_EnvioLote

    Private Enum EnviarLoteRespostaArray

        DataRecebimento = 0
        ListaMensagemRetorno = 1
        NumeroLote = 2
        Protocolo = 3


    End Enum


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

            'Gera Arquivo NFe
            If ArquivoNFSE(lLote, sArquivoEnvio, sMensagemErro) = False Then
                'Seta Retorno da Função
                Return False
            End If

            Try
                'Executa Serviço (SÍNCRONO)
                If goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.homologacao Then
                    sRetornoWS = WS_EnvioLoteNFSeHomologacao(sArquivoEnvio)
                ElseIf goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.producao Then
                    sRetornoWS = WS_EnvioLoteNFSeProducao(sArquivoEnvio)
                End If
            Catch ex As Exception
                'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                File.Delete(sArquivoEnvio)
                File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecRecepcaoLote.xml")
                'Seta Informação
                sMensagemErro = ex.Message
                'Retorno da Função
                Return False
            End Try

            'Seta Arquivo de Retorno
            sArquivoRetorno = goConfiguracaoNFSe.sPastaRecibo & IIf(goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.homologacao, "H", "P") & Format(lLote, "000000") & "-rec.xml"

            'Recebe Arquivo de Retorno do WebService
            Dim oStreamWriter As StreamWriter = File.CreateText(sArquivoRetorno)
            oStreamWriter.Write(sRetornoWS)
            oStreamWriter.Close()

            'Exclui Cabeçalho
            File.Delete(goConfiguracaoNFSe.sPastaEnvio & "cabecRecepcaoLote.xml")

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
            Dim oTRetEnvioNFSe As New EnviarLoteRpsResposta

            'Carrega arquivo de Retorno
            oTRetEnvioNFSe = EnviarLoteRpsResposta.Load(sArquivo)

            Dim oXMLDocument As New Xml.XmlDocument
            oXMLDocument.Load(sArquivo)

            Dim otcListagemMensagemRetorno As New ListaMensagemRetorno
            otcListagemMensagemRetorno = oTRetEnvioNFSe.Items(3)

            If Not otcListagemMensagemRetorno.MensagemRetorno Is Nothing Then

                'If oXMLDocument.InnerXml.ToUpper.Contains("

                sMensagemErro = oXMLDocument.ChildNodes(1).ChildNodes(0).ChildNodes(0).ChildNodes(1).InnerText
                sProtocolo = ""
            Else
                sProtocolo = oTRetEnvioNFSe.Items(2)
                dDataRecebimento = oTRetEnvioNFSe.Items(1)
                lLote = oTRetEnvioNFSe.Items(0)
            End If

            'Limpa Váriaveis
            oXMLDocument = Nothing
            oTRetEnvioNFSe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    'Public Sub LoadArquivo(ByVal sArquivo As String)

    '    Try

    '        'Váriaveis Locais
    '        Dim oTRetEnvioNFSe As New EnviarLoteRpsResposta

    '        'Carrega arquivo de Retorno
    '        oTRetEnvioNFSe = EnviarLoteRpsResposta.Load(sArquivo)

    '        Dim oXMLDocument As New Xml.XmlDocument
    '        oXMLDocument.Load(sArquivo)

    '        If Not oTRetEnvioNFSe.ListaMensagemRetorno.MensagemRetorno Is Nothing Then

    '            'If oXMLDocument.InnerXml.ToUpper.Contains("

    '            sMensagemErro = oXMLDocument.ChildNodes(1).ChildNodes(0).ChildNodes(0).ChildNodes(1).InnerText
    '            sProtocolo = ""
    '        Else
    '            sProtocolo = oTRetEnvioNFSe.Items(EnviarLoteRespostaArray.Protocolo)
    '            dDataRecebimento = oTRetEnvioNFSe.DataRecebimento
    '            lLote = oTRetEnvioNFSe.NumeroLote
    '        End If

    '        'Limpa Váriaveis
    '        oXMLDocument = Nothing
    '        oTRetEnvioNFSe = Nothing

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub
#End Region

End Class
