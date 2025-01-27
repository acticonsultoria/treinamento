Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe.DadosNF
Imports INTERACTI.NFe.RecepcaoLote_V4
Imports INTERACTI.NFe.RetRecepcaoLote_V4
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V4

Public Class clsNFeRecepcaoLote_V4

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe    
    Private lLote As Long

    'Variaveis da Classe - ReadOnly
    Private sChaveAcesso As String
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String
    Private sVersao As String
    Private sVersaoAplicativo As String
    Private iStatus As Integer
    Private sMotivo As String
    Private sDataRecibo As String
    Private sRecibo As String
    Private iTempoMedio As Integer
    Private sPathArquivoEnvio As String
    Private sPathArquivoRetorno As String

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

    Public Property Lote() As Long
        Get
            Return lLote
        End Get
        Set(ByVal value As Long)
            lLote = value
        End Set
    End Property

    Public ReadOnly Property ChaveAcesso() As String
        Get
            Return sChaveAcesso
        End Get
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

    Public ReadOnly Property Recibo() As String
        Get
            Return sRecibo
        End Get
    End Property

    Public ReadOnly Property TempoMedio() As Integer
        Get
            Return iTempoMedio
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        Try

            'Gera Arquivo NFe
            If ArquivoNFe(lLote, sArquivoEnvio, sMensagemErro, sChaveAcesso) = False Then
                'Seta Retorno da Função
                Return False
            End If

            'Seta Caminho do Arquivo
            sPathArquivoEnvio = sArquivoEnvio

            Try

                'Executa Serviço (SÍNCRONO)
                sArquivoRetorno = WSRecepcaoLote_V4(sArquivoEnvio)

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
            sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & Format(lLote, "000000") & "-rec.xml"

            'Váriaveis Locais
            Dim oStreamReader As StreamReader

            'Recebe Arquivo de Retorno do WebService
            Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
            oStreamWriter.Write(sArquivoRetorno)
            oStreamWriter.Close()

            'Carrega Arquivo XML
            oStreamReader = File.OpenText(sPathArquivoEnvio)
            sArquivoEnvio = oStreamReader.ReadToEnd
            oStreamReader.Close()

            'Exclui Cabeçalho
            File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecRecepcaoLote.xml")

            'Seta Arquivo de Retorno
            sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & Format(lLote, "000000") & "-rec.xml"

            'Recebe Arquivo de Retorno do WebService
            oStreamWriter = File.CreateText(sPathArquivoRetorno)
            oStreamWriter.Write(sArquivoRetorno)
            oStreamWriter.Close()

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

        'Váriaveis Locais
        Dim oTRetEnviNFe As New TRetEnviNFe

        Try

            'Carrega arquivo de Retorno
            oTRetEnviNFe = TRetEnviNFe.Load(sArquivo)

            'Seta Váriaveis
            sVersao = oTRetEnviNFe.versao
            sVersaoAplicativo = oTRetEnviNFe.verAplic
            iStatus = oTRetEnviNFe.cStat
            sMotivo = oTRetEnviNFe.xMotivo
            sDataRecibo = Now

            sRecibo = oTRetEnviNFe.Item.nRec
            iTempoMedio = oTRetEnviNFe.Item.tMed



            'Limpa Váriaveis
            oTRetEnviNFe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
