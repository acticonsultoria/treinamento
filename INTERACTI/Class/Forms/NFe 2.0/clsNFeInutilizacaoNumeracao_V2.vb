Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.InutilizacaoNFe_V2
Imports INTERACTI.NFe.RetInutilizacaoNFe_V2
Imports INTERACTI.NFe.AssinaturaDigital
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V2

Public Class clsNFeInutilizacaoNumeracao_V2

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iAno As Integer
    Private iModelo As Integer
    Private iSerie As Integer
    Private lNFeInicial As Long
    Private lNFeFinal As Long
    Private sJustificativa As String
    Private sMensagemErro As String
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sArquivoEnvioXML As String
    Private sArquivoRetornoXML As String

    'Variaveis da Classe - ReadOnly
    Private sVersao As String
    Private sID As String
    Private iCodigoTipoAmbiente As Integer
    Private sVersaoAplicativo As String
    Private iStatus As Integer
    Private sMotivo As String
    Private sUF As String
    Private sDataProcessamento As String
    Private sNumeroProtocolo As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Ano() As Integer
        Get
            Return iAno
        End Get
        Set(ByVal value As Integer)
            iAno = value
        End Set
    End Property

    Public Property Modelo() As Integer
        Get
            Return iModelo
        End Get
        Set(ByVal value As Integer)
            iModelo = value
        End Set
    End Property

    Public Property Serie() As Integer
        Get
            Return iSerie
        End Get
        Set(ByVal value As Integer)
            iSerie = value
        End Set
    End Property

    Public Property NFeInicial() As Long
        Get
            Return lNFeInicial
        End Get
        Set(ByVal value As Long)
            lNFeInicial = value
        End Set
    End Property

    Public Property NFeFinal() As Long
        Get
            Return lNFeFinal
        End Get
        Set(ByVal value As Long)
            lNFeFinal = value
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

    Public ReadOnly Property ArquivoEnvioXML() As String
        Get
            Return sArquivoEnvioXML
        End Get
    End Property

    Public ReadOnly Property ArquivoRetornoXML() As String
        Get
            Return sArquivoRetornoXML
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
        Dim sRetornoWS As String
        Dim oTInutNFe As New TInutNFe
        Dim oTInutNFeInfInut As New TInutNFeInfInut
        Dim oXMLDocument As XmlDocument
        Dim sID As String

        Try

            'Carrega Dados do Emitente
            Call LoadDadosEmitente()

            'ID Utilizado nas Informações de Inutilização da NFe
            sID = "ID" & _
                  goEmitente.iUF & _
                  Mid(iAno, 3, 2) & _
                  goEmitente.sCNPJ.Replace(".", "").Replace("/", "").Replace("-", "") & _
                  iModelo & _
                  iSerie.ToString.PadLeft(3, "0") & _
                  lNFeInicial.ToString.PadLeft(9, "0") & _
                  lNFeFinal.ToString.PadLeft(9, "0")

            'Informação da Inutilização da NFe
            oTInutNFeInfInut.Id = sID
            oTInutNFeInfInut.tpAmb = IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, InutilizacaoNFe_V2.TAmb.Item2, InutilizacaoNFe_V2.TAmb.Item1)
            oTInutNFeInfInut.xServ = TInutNFeInfInutXServ.INUTILIZAR
            oTInutNFeInfInut.cUF = DefineEnum(goEmitente.iUF, GetType(InutilizacaoNFe_V2.TCodUfIBGE))
            oTInutNFeInfInut.ano = Mid(iAno, 3, 2)
            oTInutNFeInfInut.CNPJ = goEmitente.sCNPJ.Replace(".", "").Replace("/", "").Replace("-", "")
            oTInutNFeInfInut.mod = DefineEnum(iModelo, GetType(InutilizacaoNFe_V2.TMod))
            oTInutNFeInfInut.serie = iSerie
            oTInutNFeInfInut.nNFIni = lNFeInicial
            oTInutNFeInfInut.nNFFin = lNFeFinal
            oTInutNFeInfInut.xJust = RetirarAcento(sJustificativa)

            'Informação da versão da Mensagem (Inutilização da NFe)
            oTInutNFe.versao = "2.00"
            oTInutNFe.infInut = oTInutNFeInfInut

            'Salva Pedido de Inutilização Temporariamente
            oTInutNFe.Save(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao.xml")

            Try

                'Assina Arquivo
                oXMLDocument = AssinarXML(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao.xml", "infInut")

            Catch ex As Exception
                'Exclui Arquivo XML (Pedido de Inutilização)
                File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao.xml")
                'Seta Informação
                sMensagemErro = "Ocorreu um erro ao tentar assinar o Arquivo XML." & vbCrLf & ex.Message
                'Retorno da Função
                Return False
            End Try

            'Exclui Arquivo XML (Pedido de Inutilização)
            File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao.xml")

            'Salva Arquivo XML Assinado
            oXMLDocument.Save(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao-ass.xml")

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao-ass.xml", _
                                                 goConfiguracaoNFe.sPastaXSD & "inutNFe_v2.00.xsd")

            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Pedido de Inutilização)
                File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao-ass.xml")

                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                'Obtem Tamanho do Arquivo XML
                Dim oFileInfo As New FileInfo(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao-ass.xml")

                'Verifica se o Tamanho do Arquivo XML é maior que o Tamanho Máximo
                If (oFileInfo.Length / 1000) > goConfiguracaoNFe.iTamanhoMaximo Then
                    'Exclui Arquivo XML (Pedido de Inutilização)
                    File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao-ass.xml")
                    'Seta Informação
                    sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                    'Retorno da Função
                    Return False
                End If

                'Seta Váriavel
                sArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao-ass.xml"

                'Cria Cabecalho da mensagem
                Dim oCabecalho As New Cabecalho.cabecMsg

                'Seta Dados do Cabeçalho
                oCabecalho.versao = "1.02"
                oCabecalho.versaoDados = "2.00"

                'Salva Cabecalho Temporariamente
                oCabecalho.Save(goConfiguracaoNFe.sPastaEnvio & "cabecInutilizacaoNumeracaoNFe.xml")

                Try

                    'Executa Serviço (SÍNCRONO)
                    sRetornoWS = WSInutilizacaoNumeracaoNFe(sArquivoEnvio)

                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Inutilização e Cabeçalho)
                    File.Delete(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-inutilizacao-ass.xml")
                    File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecInutilizacaoNumeracaoNFe.xml")
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & sID & "-ret-ped-inutilizacao.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sArquivoRetorno)
                oStreamWriter.Write(sRetornoWS)
                oStreamWriter.Close()

                'Exclui Cabeçalho
                File.Delete(goConfiguracaoNFe.sPastaEnvio & "cabecInutilizacaoNumeracaoNFe.xml")

                'Carrega Arquivo XML
                Dim oStreamReader As StreamReader
                oStreamReader = File.OpenText(sArquivoEnvio)
                sArquivoEnvioXML = oStreamReader.ReadToEnd
                oStreamReader.Close()
                oStreamReader = File.OpenText(sArquivoRetorno)
                sArquivoRetornoXML = oStreamReader.ReadToEnd
                oStreamReader.Close()

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sArquivo As String)

        'Váriaveis Locais
        Dim oTRetInutNFe As New TRetInutNFe
        Dim oTRetInutNFeInfInut As New TRetInutNFeInfInut

        Try

            'Carrega arquivo de Retorno
            oTRetInutNFe = TRetInutNFe.Load(sArquivo)
            oTRetInutNFeInfInut = oTRetInutNFe.infInut

            'Seta Váriaveis
            sVersao = oTRetInutNFe.versao
            sID = oTRetInutNFeInfInut.Id
            iCodigoTipoAmbiente = IIf(oTRetInutNFeInfInut.tpAmb = RetInutilizacaoNFe_V2.TAmb.Item1, TipoAmbienteNFe.producao, TipoAmbienteNFe.homologacao)
            sVersaoAplicativo = oTRetInutNFeInfInut.verAplic
            iStatus = oTRetInutNFeInfInut.cStat
            sMotivo = oTRetInutNFeInfInut.xMotivo
            sUF = oTRetInutNFeInfInut.cUF
            sDataProcessamento = oTRetInutNFeInfInut.dhRecbto
            sNumeroProtocolo = oTRetInutNFeInfInut.nProt

            'Limpa Váriaveis
            oTRetInutNFe = Nothing
            oTRetInutNFeInfInut = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
