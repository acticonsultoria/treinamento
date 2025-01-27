Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe.Cabecalho
Imports INTERACTI.NFe.DadosCCe
Imports INTERACTI.NFe.RecepcaoEvento
Imports INTERACTI.NFe.RetRecepcaoEvento
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V4

Public Class clsNFeRecepcaoEvento_V4

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sPathArquivoEnvio As String
    Private sPathArquivoRetorno As String
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String
    Private sChaveAcesso As String
    Private sCondicaoUso As String
    Private sDataEvento As String
    Private iSequencia As Integer
    Private iStatus As Integer
    Private sMotivo As String
    Private iStatusCCe As Integer
    Private sMotivoCCe As String
    Private sNumeroProtocolo As String
    Private sDataRegistroEvento As String

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

    Public ReadOnly Property StatusCCe() As Integer
        Get
            Return iStatusCCe
        End Get
    End Property

    Public ReadOnly Property MotivoCCe() As String
        Get
            Return sMotivoCCe
        End Get
    End Property

    Public WriteOnly Property ChaveAcesso() As String
        Set(ByVal value As String)
            sChaveAcesso = value
        End Set
    End Property

    Public WriteOnly Property CondicaoUso() As String
        Set(ByVal value As String)
            sCondicaoUso = value
        End Set
    End Property

    Public WriteOnly Property DataEvento() As String
        Set(ByVal value As String)
            sDataEvento = value
        End Set
    End Property

    Public WriteOnly Property Sequencia() As Integer
        Set(ByVal value As Integer)
            iSequencia = value
        End Set
    End Property

    Public ReadOnly Property NumeroProtocolo() As String
        Get
            Return sNumeroProtocolo
        End Get
    End Property

    Public ReadOnly Property DataRegistroEvento() As String
        Get
            Return sDataRegistroEvento
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        Try

            'Gera Arquivo CCe
            If ArquivoCCe(sArquivoEnvio, sMensagemErro, sChaveAcesso, sCondicaoUso, sDataEvento, iSequencia) = False Then
                'Seta Retorno da Função
                Return False
            End If

            'Seta Caminho do Arquivo
            sPathArquivoEnvio = sArquivoEnvio

            Try

                'Executa Serviço (SÍNCRONO)
                sArquivoRetorno = WSRecepcaoEvento_V4(sArquivoEnvio)

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
            sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & Format(iSequencia, "000000") & "-rec-cce.xml"

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
            File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecRecepcaoEvento.xml")

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
        Dim oTRetEnviNFe As New TRetEnvEvento

        Try

            'Carrega arquivo de Retorno
            oTRetEnviNFe = TRetEnvEvento.Load(sArquivo)


            'Seta Váriaveis
            iStatus = oTRetEnviNFe.cStat
            sMotivo = oTRetEnviNFe.xMotivo
            iStatusCCe = oTRetEnviNFe.retEvento(0).infEvento.cStat
            sMotivoCCe = oTRetEnviNFe.retEvento(0).infEvento.xMotivo
            sNumeroProtocolo = oTRetEnviNFe.retEvento(0).infEvento.nProt
            sDataRegistroEvento = oTRetEnviNFe.retEvento(0).infEvento.dhRegEvento

            'Limpa Váriaveis
            oTRetEnviNFe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class