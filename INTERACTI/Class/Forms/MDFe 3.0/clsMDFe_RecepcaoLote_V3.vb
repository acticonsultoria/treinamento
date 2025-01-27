Imports System.IO
Imports System.Xml
Imports INTERACTI.MDFe.Dados
Imports INTERACTI.MDFe.RecepcaoLote_v3
Imports INTERACTI.MDFe.RetRecepcaoLote_V3
Imports INTERACTI.mdfe.ValidaXML
Imports INTERACTI.MDFe.WebService
Imports INTERACTI.MDFe.Dados.clsMDFe_Dados

Public Class clsMDFe_RecepcaoLote_V3

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
    Private lCodigoEmissaoCapa As Long



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

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
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

            'Gera Arquivo mdfe
            If ArquivoMDFE(lLote, sArquivoEnvio, sMensagemErro, sChaveAcesso) = False Then
                'Seta Retorno da Função
                Return False
            End If

            'Seta Caminho do Arquivo
            sPathArquivoEnvio = sArquivoEnvio

            Try

                'Executa Serviço (SÍNCRONO)
                sArquivoRetorno = WSRecepcao(sArquivoEnvio)

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
            sPathArquivoRetorno = goConfiguracaoMDFe.sPastaRecibo & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & Format(lLote, "000000") & "-rec.xml"

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
            File.Delete(goConfiguracaoMDFe.sPastaEnvio & "cabecRecepcaoLote.xml")

            'Seta Arquivo de Retorno
            sPathArquivoRetorno = goConfiguracaoMDFe.sPastaRecibo & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & Format(lLote, "000000") & "-rec.xml"

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
        Dim oTRetEnviMDFe As New TRetEnviMDFe

        Try

            'Carrega arquivo de Retorno
            oTRetEnviMDFe = TRetEnviMDFe.Load(sArquivo)

            'Seta Váriaveis
            sVersao = oTRetEnviMDFe.versao
            sVersaoAplicativo = oTRetEnviMDFe.verAplic
            iStatus = oTRetEnviMDFe.cStat
            sMotivo = oTRetEnviMDFe.xMotivo
            sDataRecibo = Now
            sRecibo = oTRetEnviMDFe.infRec.nRec
            iTempoMedio = oTRetEnviMDFe.infRec.tMed

            'Limpa Váriaveis
            oTRetEnviMDFe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
