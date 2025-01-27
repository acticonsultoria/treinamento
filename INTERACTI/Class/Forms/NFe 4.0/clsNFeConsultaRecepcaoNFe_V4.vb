Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.ConsultaRecepcaoNFe_V4
Imports INTERACTI.NFe.RetConsultaRecepcaoNFe_V4
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V4

Public Class clsNFeConsultaRecepcaoNFe_V4

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

    Private oProtocoloNFe() As InformacaoProtocoloNFe

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

    Public ReadOnly Property ProtocoloNFe() As Object
        Get
            Return oProtocoloNFe
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        'Váriaveis Locais
        Dim oTConsReciNFe As New TConsReciNFe

        Try

            'Informação do Status do Serviço
            oTConsReciNFe.versao = "4.00"
            oTConsReciNFe.tpAmb = IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, ConsultaStatusServico_V4.TAmb.Item2, ConsultaStatusServico_V4.TAmb.Item1)
            oTConsReciNFe.nRec = sRecibo

            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sRecibo & "-ped-rec.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsReciNFe.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "consReciNFe_v4.00.xsd")

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
                If (oFileInfo.Length / 1000) > goConfiguracaoNFe.iTamanhoMaximo Then
                    'Exclui Arquivo XML (Status)
                    File.Delete(sPathArquivoEnvio)
                    'Seta Informação
                    sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                    'Retorno da Função
                    Return False
                End If


                Try

                    'Executa Serviço (SÍNCRONO)
                    sArquivoRetornoXML = WSRetRecepcaoLote_V4(sPathArquivoEnvio)

                Catch ex As Exception
                    'Exclui Arquivo XML 
                    File.Delete(sPathArquivoEnvio)
                    File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecRetRecepcaoNFe.xml")
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sRecibo & "-pro-rec.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
                oStreamWriter.Write(sArquivoRetornoXML)
                oStreamWriter.Close()

                'Exclui Cabeçalho
                File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecRetRecepcaoNFe.xml")

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sArquivo As String)

        'Váriaveis Locais
        Dim oTRetConsReciNFe As New TRetConsReciNFe
        Dim oTProtNFe() As TProtNFe

        Try

            'Carrega arquivo de Retorno
            oTRetConsReciNFe = TRetConsReciNFe.Load(sArquivo)

            'Seta Váriaveis
            sVersao = oTRetConsReciNFe.versao
            sVersaoAplicativo = oTRetConsReciNFe.verAplic
            iStatus = oTRetConsReciNFe.cStat
            sMotivo = oTRetConsReciNFe.xMotivo

            oTProtNFe = oTRetConsReciNFe.protNFe

            If Not oTProtNFe Is Nothing Then

                'Redimensiona Vetor
                ReDim oProtocoloNFe(UBound(oTProtNFe))

                For i = 0 To UBound(oTProtNFe)

                    oProtocoloNFe(i).sChaveAcesso = oTProtNFe(i).infProt.chNFe
                    oProtocoloNFe(i).iStatus = oTProtNFe(i).infProt.cStat
                    oProtocoloNFe(i).sDataProcessamento = oTProtNFe(i).infProt.dhRecbto
                    oProtocoloNFe(i).sNumeroProtocolo = oTProtNFe(i).infProt.nProt
                    oProtocoloNFe(i).sMotivo = oTProtNFe(i).infProt.xMotivo

                Next

            Else

                'Redimensiona Vetor
                ReDim oProtocoloNFe(0)

            End If

            'Limpa Váriaveis
            oTRetConsReciNFe = Nothing
            oTProtNFe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
