Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.ConsultaStatusServico_V3
Imports INTERACTI.NFe.RetConsultaStatusServico_V3
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V3


Public Class clsNFeStatusServico_V3

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe - ReadOnly
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String
    Private sVersao As String
    Private iCodigoTipoAmbiente As Integer
    Private sVersaoAplicativo As String
    Private iStatus As Integer
    Private sMotivo As String
    Private sUF As String
    Private sDataProcessamento As String
    Private iTempoMedioResposta As Integer
    Private sDataPrevistaRetorno As String
    Private sObservacao As String

#End Region

#Region "::: PROPERTIE :::"

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

    Public ReadOnly Property CodigoTipoAmbiente() As Integer
        Get
            Return iCodigoTipoAmbiente
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

    Public ReadOnly Property UF() As String
        Get
            Return sUF
        End Get
    End Property

    Public ReadOnly Property DataProcessamento() As String
        Get
            Return sDataProcessamento
        End Get
    End Property

    Public ReadOnly Property TempoMedioResposta() As Integer
        Get
            Return iTempoMedioResposta
        End Get
    End Property

    Public ReadOnly Property DataPrevistaRetorno() As String
        Get
            Return sDataPrevistaRetorno
        End Get
    End Property

    Public ReadOnly Property Observacao() As String
        Get
            Return sObservacao
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsStatServ As New TConsStatServ

        Try

            'Informação do Status do Serviço
            oTConsStatServ.versao = "3.10"
            oTConsStatServ.tpAmb = IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, ConsultaStatusServico_V3.TAmb.Item2, ConsultaStatusServico_V3.TAmb.Item1)
            oTConsStatServ.cUF = DefineEnum(goConfiguracaoNFe.sCodigoEstado, GetType(ConsultaStatusServico_V3.TCodUfIBGE))

            'Seta Arquivo
            sArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & "ConsultaStatus-" & Format(Now, "yyyyMMdd-HHmmss") & "-ped-status.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsStatServ.Save(sArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "consStatServ_v3.10.xsd")

            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Status)
                File.Delete(sArquivoEnvio)

                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                'Obtem Tamanho do Arquivo XML
                Dim oFileInfo As New FileInfo(sArquivoEnvio)

                'Verifica se o Tamanho do Arquivo XML é maior que o Tamanho Máximo
                If (oFileInfo.Length / 1000) > goConfiguracaoNFe.iTamanhoMaximo Then
                    'Exclui Arquivo XML (Status)
                    File.Delete(sArquivoEnvio)
                    'Seta Informação
                    sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                    'Retorno da Função
                    Return False
                End If


                Try

                    'Executa Serviço (SÍNCRONO)
                    sRetornoWS = WSStatusServico_V3(sArquivoEnvio)

                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(sArquivoEnvio)
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & "ConsultaStatus-" & Format(Now, "yyyyMMdd-HHmmss") & "-ret-status.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sArquivoRetorno)
                oStreamWriter.Write(sRetornoWS)
                oStreamWriter.Close()

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            sMensagemErro = ex.Message
            Return False
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sArquivo As String)

        'Váriaveis Locais
        Dim oTRetConsStatServ As New TRetConsStatServ

        Try

            'Carrega arquivo de Retorno
            oTRetConsStatServ = TRetConsStatServ.Load(sArquivo)

            'Seta Váriaveis
            sVersao = oTRetConsStatServ.versao
            iCodigoTipoAmbiente = IIf(oTRetConsStatServ.tpAmb = ConsultaStatusServico_V3.TAmb.Item1, TipoAmbienteNFe.producao, TipoAmbienteNFe.homologacao)
            sVersaoAplicativo = oTRetConsStatServ.verAplic
            iStatus = oTRetConsStatServ.cStat
            sMotivo = oTRetConsStatServ.xMotivo
            sDataProcessamento = oTRetConsStatServ.dhRecbto
            iTempoMedioResposta = oTRetConsStatServ.tMed
            sDataPrevistaRetorno = oTRetConsStatServ.dhRetorno
            sObservacao = oTRetConsStatServ.xObs

            'Limpa Váriaveis
            oTRetConsStatServ = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
