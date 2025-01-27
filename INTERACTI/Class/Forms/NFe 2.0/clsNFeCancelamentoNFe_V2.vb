Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.CancelamentoNFe_V2
Imports INTERACTI.NFe.RetCancelamentoNFe_V2
Imports INTERACTI.NFe.AssinaturaDigital
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V2

Public Class clsNFeCancelamentoNFe_V2

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sChave As String
    Private sNumeroProtocoloAutorizacao As String
    Private sJustificativa As String

    'Variaveis da Classe - ReadOnly
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String
    Private sVersao As String
    Private sID As String
    Private iCodigoTipoAmbiente As Integer
    Private sVersaoAplicativo As String
    Private iStatus As Integer
    Private sMotivo As String
    Private sUF As String
    Private sDataProcessamento As String
    Private sNumeroProtocolo As String
    Private sPathArquivoEnvio As String
    Private sPathArquivoRetorno As String
    Private sXMLCancelamentoEnvio As String
    Private sXMLCancelamentoRecepcao As String
#End Region

#Region "::: PROPERTIE :::"
    Public ReadOnly Property XMLCancelamentoEnvio() As String
        Get
            Return sXMLCancelamentoEnvio
        End Get
    End Property

    Public ReadOnly Property XMLCancelamentoRecepcao() As String
        Get
            Return sXMLCancelamentoRecepcao
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
    Public Property Chave() As String
        Get
            Return sChave
        End Get
        Set(ByVal value As String)
            sChave = value
        End Set
    End Property

    Public Property NumeroProtocoloAutorizacao() As String
        Get
            Return sNumeroProtocoloAutorizacao
        End Get
        Set(ByVal value As String)
            sNumeroProtocoloAutorizacao = value
        End Set
    End Property

    Public Property Justificativa() As String
        Get
            Return sJustificativa
        End Get
        Set(ByVal value As String)
            sJustificativa = value
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

    Public ReadOnly Property Versao() As String
        Get
            Return sVersao
        End Get
    End Property

    Public ReadOnly Property ID() As String
        Get
            Return sID
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

    Public ReadOnly Property NumeroProtocolo() As String
        Get
            Return sNumeroProtocolo
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        'Váriaveis Locais
        Dim oTCancNFe As New TCancNFe
        Dim oTCancNFeInfCanc As New TCancNFeInfCanc
        Dim oXMLDocument As XmlDocument
        Dim sID As String

        Try

            'ID Utilizado nas Informações de Inutilização da NFe
            sID = "ID" & _
                  sChave

            'Informação da Inutilização da NFe
            oTCancNFeInfCanc.Id = sID
            oTCancNFeInfCanc.tpAmb = IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, CancelamentoNFe_V2.TAmb.Item2, CancelamentoNFe_V2.TAmb.Item1)
            oTCancNFeInfCanc.chNFe = sChave
            oTCancNFeInfCanc.nProt = sNumeroProtocoloAutorizacao
            oTCancNFeInfCanc.xJust = RetirarAcento(sJustificativa)

            'Informação da versão da Mensagem (Cancelamento NFe)
            oTCancNFe.versao = "2.00"
            oTCancNFe.infCanc = oTCancNFeInfCanc

            'Salva Pedido de Inutilização Temporariamente
            oTCancNFe.Save(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento.xml")

            Try

                'Assina Arquivo
                oXMLDocument = AssinarXML(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento.xml", "infCanc")

            Catch ex As Exception
                'Exclui Arquivo XML (Pedido de Cancelamento)
                File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento.xml")
                'Seta Informação
                sMensagemErro = "Ocorreu um erro ao tentar assinar o Arquivo XML." & vbCrLf & ex.Message
                'Retorno da Função
                Return False
            End Try

            'Exclui Arquivo XML (Pedido de Cancelamento)
            File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento.xml")

            'Salva Arquivo XML Assinado
            oXMLDocument.Save(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml", _
                                                 goConfiguracaoNFe.sPastaXSD & "cancNFe_v2.00.xsd")

            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Pedido de Cancelamento)
                File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")

                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                'Obtem Tamanho do Arquivo XML
                Dim oFileInfo As New FileInfo(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")

                'Verifica se o Tamanho do Arquivo XML é maior que o Tamanho Máximo
                If (oFileInfo.Length / 1000) > goConfiguracaoNFe.iTamanhoMaximo Then
                    'Exclui Arquivo XML (Pedido de Cancelamento)
                    File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")
                    'Seta Informação
                    sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                    'Retorno da Função
                    Return False
                End If

                'Seta Váriavel
                sArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml"
                sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml"

                Try

                    'Executa Serviço (SÍNCRONO)
                    sArquivoRetorno = WSCancelarNotaFiscal_V2(sArquivoEnvio)

                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")
                    File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecCancelamentoNFe.xml")
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoNFe.sPastaEnvio & sID & "-ret-ped-cancelamento.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
                oStreamWriter.Write(sArquivoRetorno)
                oStreamWriter.Close()

                'Exclui Cabeçalho
                File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecCancelamentoNFe.xml")

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sArquivo As String)

        'Váriaveis Locais
        Dim oTRetCancNFe As New TRetCancNFe
        Dim oTRetCancNFeInfCanc As New TRetCancNFeInfCanc

        Try

            'Carrega arquivo de Retorno
            oTRetCancNFe = TRetCancNFe.Load(sArquivo)
            oTRetCancNFeInfCanc = oTRetCancNFe.infCanc

            'Seta Váriaveis
            sVersao = oTRetCancNFe.versao
            sID = oTRetCancNFeInfCanc.Id
            iCodigoTipoAmbiente = IIf(oTRetCancNFeInfCanc.tpAmb = CancelamentoNFe_V2.TAmb.Item1, TipoAmbienteNFe.producao, TipoAmbienteNFe.homologacao)
            sVersaoAplicativo = oTRetCancNFeInfCanc.verAplic
            iStatus = oTRetCancNFeInfCanc.cStat
            sMotivo = oTRetCancNFeInfCanc.xMotivo
            sDataProcessamento = oTRetCancNFeInfCanc.dhRecbto
            sNumeroProtocolo = IIf(iStatus = 420, sMotivo.Substring(sMotivo.IndexOf("[nProt:") + 7, sMotivo.IndexOf("]") - (sMotivo.IndexOf("[") + 7)), oTRetCancNFeInfCanc.nProt)
            iStatus = IIf(iStatus = 420, 101, iStatus)
            sMotivo = IIf(iStatus = 420, "NOTA FISCAL CANCELADA COM SUCESSO", sMotivo)

            'Limpa Váriaveis
            oTRetCancNFe = Nothing
            oTRetCancNFeInfCanc = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
