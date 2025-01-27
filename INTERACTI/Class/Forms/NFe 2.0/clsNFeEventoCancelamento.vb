Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.EventoCancelamento
Imports INTERACTI.NFe.RetEventoCancelamento
Imports INTERACTI.NFe.AssinaturaDigital
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V2

Public Class clsNFeEventoCancelamento

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sChave As String
    Private sNumeroProtocoloAutorizacao As String
    Private sJustificativa As String
    Private sSequencia As String

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
    Public Property Sequencia() As String
        Get
            Return sSequencia
        End Get
        Set(ByVal value As String)
            sSequencia = value
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
        Dim oTEnvEvento As New INTERACTI.NFe.EventoCancelamento.TEnvEvento
        Dim oTEvento As New INTERACTI.NFe.EventoCancelamento.TEvento
        Dim oTEventoInfEvento As New INTERACTI.NFe.EventoCancelamento.TEventoInfEvento
        Dim oTEventoInfEventoDetEvento As New INTERACTI.NFe.EventoCancelamento.TEventoInfEventoDetEvento
        Dim oXMLDocument As XmlDocument
        Dim sID As String

        Try

            'Versão
            oTEvento.versao = "1.00"

            'Setando a ID
            sID = "ID" + "110111" + sChave + sSequencia

            'Setando os parâmetros da informação do evento
            oTEventoInfEvento.Id = sID

            oTEventoInfEvento.cOrgao = EventoCancelamento.TCOrgaoIBGE.Item35 'Temp
            oTEventoInfEvento.tpAmb = IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.producao, EventoCancelamento.TAmb.Item1, EventoCancelamento.TAmb.Item2)
            oTEventoInfEvento.ItemElementName = EventoCancelamento.ItemChoiceType.CNPJ
            oTEventoInfEvento.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")
            oTEventoInfEvento.chNFe = sChave
            oTEventoInfEvento.dhEvento = Format(Now, "yyyy-MM-ddTHH:mm:ss") + If(goConfiguracaoNFe.bHorarioVerao = True, "-02:00", "-03:00")
            oTEventoInfEvento.tpEvento = EventoCancelamento.TEventoInfEventoTpEvento.Item110111
            oTEventoInfEvento.verEvento = EventoCancelamento.TEventoInfEventoVerEvento.Item100
            oTEventoInfEvento.nSeqEvento = CInt(sSequencia)

            'Dados do cancelamento
            oTEventoInfEventoDetEvento.versao = EventoCancelamento.TEventoInfEventoDetEventoVersao.Item100
            oTEventoInfEventoDetEvento.descEvento = EventoCancelamento.TEventoInfEventoDetEventoDescEvento.Cancelamento
            oTEventoInfEventoDetEvento.nProt = sNumeroProtocoloAutorizacao
            oTEventoInfEventoDetEvento.xJust = sJustificativa

            'Setando os elementos
            oTEventoInfEvento.detEvento = oTEventoInfEventoDetEvento
            oTEvento.infEvento = oTEventoInfEvento

            'Salva Pedido de Inutilização Temporariamente
            oTEvento.Save(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento.xml")

            Try

                'Assina Arquivo
                oXMLDocument = AssinarXML(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento.xml", "infEvento")

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
                                                 goConfiguracaoNFe.sPastaXSD & "eventoCancNFe_v1.00.xsd")

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

                'Inclui Lote no Arquivo XML
                Dim sArquivoLote = IncluiLoteNFe(goConfiguracaoNFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml", _
                                                 "", _
                                                 Format(1, "000000"))

                'Seta Váriavel
                sArquivoEnvio = sArquivoLote
                sPathArquivoEnvio = sArquivoLote

                Try

                    'Executa Serviço (SÍNCRONO)
                    sArquivoRetorno = WSEventoCancelamento(sArquivoEnvio)

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
    Public Overloads Shared Function IncluiLoteNFe(ByVal sArquivoXML As String, _
                                                       ByVal sArquivoLote As String, _
                                                       ByVal sLote As String) As String

        Try

            'Váriaveis Locais
            Dim oXmlDocumentNFe As New XmlDocument
            Dim oXmlDocumentLote As New XmlDocument
            Dim oNodeEnviNFe As XmlNodeList
            Dim oNodeNFe As XmlNodeList
            Dim oStreamWriter As StreamWriter

            'Verifica se Arquivo de Nota Fiscal Existe
            If (File.Exists(sArquivoXML)) Then

                'Carrega Arquivo de Lote caso ele exista
                If (File.Exists(sArquivoLote)) Then
                    'Carrega Arquivo
                    oXmlDocumentLote.Load(sArquivoLote)
                Else
                    'Cria Cabeçalho
                    Dim sCabecalho As String
                    sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?>" & _
                                 "<envEvento xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""1.00"">" & _
                                 "<idLote>" & sLote & "</idLote></envEvento>"
                    'Carrega Arquivo de Cabeçalho
                    oXmlDocumentLote.LoadXml(sCabecalho)
                End If

                'Carrega Arquivo de Nota Fiscal
                oXmlDocumentNFe.Load(sArquivoXML)
                'Ignora Espaços em Branco
                oXmlDocumentNFe.PreserveWhitespace = False
                oXmlDocumentLote.PreserveWhitespace = False

                'Obtem Elemento enviNFe
                oNodeEnviNFe = oXmlDocumentLote.GetElementsByTagName("envEvento")

                'Adiciona o Node NFe no EnvNFe
                oNodeNFe = oXmlDocumentNFe.GetElementsByTagName("evento", "http://www.portalfiscal.inf.br/nfe")
                oNodeEnviNFe.Item(0).AppendChild(oXmlDocumentLote.ImportNode(oNodeNFe.Item(0), True))

                'Salva o Arquivo
                oStreamWriter = File.CreateText(goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sLote & "-env-lot.xml")
                oStreamWriter.Write(oXmlDocumentLote.OuterXml)
                oStreamWriter.Close()

                'Retorna Status
                Return goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sLote & "-env-lot.xml"

            Else
                'Retorna se nota nao encontrada
                Return "ERROR"
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sArquivo As String)

        'Váriaveis Locais

        Dim oTRetEnvEvento As New INTERACTI.NFe.RetEventoCancelamento.TRetEnvEvento
        Dim oTRetEvento As New INTERACTI.NFe.RetEventoCancelamento.TRetEvento
        Dim oTRetEventoInfEvento As New INTERACTI.NFe.RetEventoCancelamento.TRetEventoInfEvento


        Try

            'Carrega arquivo de Retorno
            oTRetEnvEvento = TRetEnvEvento.Load(sArquivo)
            oTRetEvento = oTRetEnvEvento.retEvento(0)
            oTRetEventoInfEvento = oTRetEvento.infEvento

            'Seta Váriaveis
            sVersao = oTRetEnvEvento.versao
            sID = oTRetEventoInfEvento.Id
            iCodigoTipoAmbiente = IIf(oTRetEnvEvento.tpAmb = RetEventoCancelamento.TAmb.Item1, TipoAmbienteNFe.producao, TipoAmbienteNFe.homologacao)
            sVersaoAplicativo = oTRetEnvEvento.verAplic
            iStatus = oTRetEventoInfEvento.cStat
            sMotivo = oTRetEventoInfEvento.xMotivo
            sDataProcessamento = oTRetEventoInfEvento.dhRegEvento
            sNumeroProtocolo = oTRetEventoInfEvento.nProt

            'Limpa Váriaveis
            oTRetEnvEvento = Nothing
            oTRetEvento = Nothing
            oTRetEventoInfEvento = Nothing
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
