Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.ConsultaSituacaoNF_V3
Imports INTERACTI.NFe.RetConsultaSituacaoNFe_V3
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V3

Public Class clsNFeConsultaSituacao_V3

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sChaveAcesso As String
    Private sPathArquivoEnvio As String
    Private sPathArquivoRetorno As String
    Private sXMLEnvio As String
    Private sXMLRetorno As String
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

    Public ReadOnly Property XMLEnvio() As String
        Get
            Return sXMLEnvio
        End Get
    End Property

    Public ReadOnly Property XMLRetorno() As String
        Get
            Return sXMLRetorno
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

    Public Function Send() As Boolean

        'Váriaveis Locais
        Dim oTConsSitNFe As New TConsSitNFe

        Try

            'Informação do Status do Serviço
            oTConsSitNFe.versao = ConsultaSituacaoNF_V3.TVerConsSitNFe.Item310
            oTConsSitNFe.tpAmb = IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, ConsultaStatusServico_V3.TAmb.Item2, ConsultaStatusServico_V3.TAmb.Item1)
            oTConsSitNFe.chNFe = sChaveAcesso

            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & sChaveAcesso & "-ped-situacao-nf.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsSitNFe.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "consSitNFe_v3.10.xsd")

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
                    Dim cUF As String = Mid(sChaveAcesso, 1, 2)
                    Select Case cUF
                        Case "29"
                            sXMLRetorno = WSConsultaSituacaoNF_V3_BA(sPathArquivoEnvio, cUF)
                        Case "41"
                            sXMLRetorno = WSConsultaSituacaoNF_V3_PR(sPathArquivoEnvio, cUF)
                        Case Else
                            sXMLRetorno = WSConsultaSituacaoNF_V3(sPathArquivoEnvio, cUF)

                    End Select

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
                oStreamWriter.Write(sXMLRetorno)
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

    Public Sub LoadArquivo(ByVal sArquivo As String)

        'Váriaveis Locais
        Dim oTRetConsSitNFe As New TRetConsSitNFe

        Try

            'Carrega arquivo de Retorno
            oTRetConsSitNFe = TRetConsSitNFe.Load(sArquivo)

            'Seta Váriaveis
            sVersao = oTRetConsSitNFe.versao

            sVersaoAplicativo = oTRetConsSitNFe.verAplic
            iStatus = oTRetConsSitNFe.cStat
            sMotivo = oTRetConsSitNFe.xMotivo
            If oTRetConsSitNFe.protNFe Is Nothing Then
                sProtocolo = ""
                sDataRecibo = ""
                sUF = ""
                sAmbiente = ""
            Else
                sProtocolo = oTRetConsSitNFe.protNFe.infProt.nProt
                sDataRecibo = oTRetConsSitNFe.protNFe.infProt.dhRecbto
                sUF = LoadUFIBGE(oTRetConsSitNFe.cUF)
                sUF = LoadUFIBGE(LoadValueEnum(oTRetConsSitNFe.cUF.GetType, oTRetConsSitNFe.cUF.ToString))
                sAmbiente = IIf(oTRetConsSitNFe.protNFe.infProt.tpAmb = RetConsultaSituacaoNFe_V3.TAmb.Item1, "PRODUÇÃO", "HOMOLOGAÇÃO")
            End If

            'Limpa Váriaveis
            oTRetConsSitNFe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ConsultaSituacao(ByVal sChaveAcessoConsulta As String, _
                                     ByRef sMensagemErroConsulta As String) As Integer
        Try

            sChaveAcesso = sChaveAcessoConsulta
            sMensagemErroConsulta = ""

            If Send() = False Then

                'Se deu erro
                ConsultaSituacao = -1
                sMensagemErroConsulta = sMensagemErro

            Else
                Try
                    LoadArquivo(sPathArquivoRetorno)

                    ConsultaSituacao = iStatus

                Catch ex As Exception
                    'Se deu erro
                    ConsultaSituacao = -1
                    sMensagemErroConsulta = ex.Message

                End Try

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
