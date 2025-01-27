Imports System.IO
Imports System.Xml
Imports INTERACTI.MDFe
Imports INTERACTI.MDFe.ConsultaRecibo_V3
Imports INTERACTI.MDFe.RetConsultaRecibo_V3
Imports INTERACTI.MDFe.RetRecepcaoLote_V3
Imports INTERACTI.MDFe.ValidaXML
Imports INTERACTI.MDFe.WebService


Public Class clsMDFe_ConsultaRecepcaoLote_V3

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sRecibo As String
    Private sLote As String
    Private sArquivoRetornoXML As String
    Private sPathArquivoEnvio As String
    Private sPathArquivoRetorno As String
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

    Private oProtocoloMDFe() As InformacaoProtocoloMDFe

#End Region

#Region "::: PROPERTIE :::"
    Public ReadOnly Property ArquivoRetornoXML() As String
        Get
            Return sArquivoRetornoXML
        End Get
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
    Public Property Recibo() As String
        Get
            Return sRecibo
        End Get
        Set(ByVal value As String)
            sRecibo = value
        End Set
    End Property

    Public Property Lote() As String
        Get
            Return sLote
        End Get
        Set(ByVal value As String)
            sLote = value
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

    Public ReadOnly Property ProtocoloMDFe() As Object
        Get
            Return oProtocoloMDFe
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        'Váriaveis Locais
        Dim oTConsReciMDFe As New TConsReciMDFe

        Try

            'Informação do Status do Serviço
            oTConsReciMDFe.versao = "3.00"
            oTConsReciMDFe.tpAmb = IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, MDFe.ConsultaRecibo_V3.TAmb.Item2, MDFe.ConsultaRecibo_V3.TAmb.Item1)
            oTConsReciMDFe.nRec = sRecibo


            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoMDFe.sPastaEnvio & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & sRecibo & "-ped-rec.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsReciMDFe.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
                                                     goConfiguracaoMDFe.sPastaXSD & "consReciMdfe_v3.00.xsd",
                                                     "consReciMdfe_v3.00.xsd")

            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Status)
                File.Delete(sPathArquivoEnvio)

                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                'Obtem Tamanho do Arquivo XML
                Dim oFileInfo As New FileInfo(sPathArquivoEnvio)

                'Verifica se o Tamanho do Arquivo XML é maior que o Tamanho Máximo
                If (oFileInfo.Length / 1000) > goConfiguracaoMDFe.iTamanhoMaximo Then
                    'Exclui Arquivo XML (Status)
                    File.Delete(sPathArquivoEnvio)
                    'Seta Informação
                    sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                    'Retorno da Função
                    Return False
                End If


                Try

                    'Executa Serviço (SÍNCRONO)
                    sArquivoRetornoXML = WSRetRecepcaoLote(sPathArquivoEnvio)

                Catch ex As Exception
                    'Exclui Arquivo XML 
                    File.Delete(sPathArquivoEnvio)
                    File.Delete(goConfiguracaoMDFe.sPastaEnvio & "cabecRetRecepcaoMDFe.xml")
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoMDFe.sPastaRecibo & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & sRecibo & "-pro-rec.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
                oStreamWriter.Write(sArquivoRetornoXML)
                oStreamWriter.Close()

                'Exclui Cabeçalho
                File.Delete(goConfiguracaoMDFe.sPastaEnvio & "cabecRetRecepcaoMDFe.xml")

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sArquivo As String)

        'Váriaveis Locais
        Dim oTRetConsReciMDFe As New TRetConsReciMDFe
        Dim oTProtMDFe As TProtMDFe

        Try

            'Carrega arquivo de Retorno
            oTRetConsReciMDFe = TRetConsReciMDFe.Load(sArquivo)

            'Seta Váriaveis
            sVersao = oTRetConsReciMDFe.versao
            sVersaoAplicativo = oTRetConsReciMDFe.verAplic
            iStatus = oTRetConsReciMDFe.cStat
            sMotivo = oTRetConsReciMDFe.xMotivo

            oTProtMDFe = oTRetConsReciMDFe.protMDFe

            If Not oTProtMDFe Is Nothing Then
                'Redimensiona Vetor
                ReDim oProtocoloMDFe(0)

                oProtocoloMDFe(0).sChaveAcesso = oTProtMDFe.infProt.chMDFe
                oProtocoloMDFe(0).iStatus = oTProtMDFe.infProt.cStat
                oProtocoloMDFe(0).sDataProcessamento = oTProtMDFe.infProt.dhRecbto
                oProtocoloMDFe(0).sNumeroProtocolo = oTProtMDFe.infProt.nProt
                oProtocoloMDFe(0).sMotivo = oTProtMDFe.infProt.xMotivo


            End If

            'Limpa Váriaveis
            oTRetConsReciMDFe = Nothing
            oTProtMDFe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

End Class
