Imports System.IO
Imports System.Xml
Imports INTERACTI.MDFe
Imports INTERACTI.MDFe.EventoCancelamento_V3
Imports INTERACTI.MDFe.RetEvento_V3
Imports INTERACTI.MDFe.AssinaturaDigital
Imports INTERACTI.MDFe.ValidaXML
Imports INTERACTI.MDFe.WebService

Public Class clsMDFeEventoCancelamento_V3

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private dDataEmissao As Date
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
    Public WriteOnly Property DataEmissao As Date
        Set(ByVal value As Date)
            dDataEmissao = value
        End Set
    End Property

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
        Dim oTEvento As New TEvento
        Dim oTEventoInfEvento As New TEventoInfEvento
        Dim oTEventoInfEventoDetEvento As New TEventoInfEventoDetEvento
        Dim oXMLDocument As XmlDocument
        Dim sID As String

        Try

            'Versão
            oTEvento.versao = "3.00"

            'Setando a ID
            sID = "ID" + "110111" + sChave + sSequencia

            'Setando os parâmetros da informação do evento
            oTEventoInfEvento.Id = sID

            oTEventoInfEvento.cOrgao = DefineEnum(goEmitente.iUF, GetType(INTERACTI.NFe.EventoCancelamento.TCOrgaoIBGE))
            oTEventoInfEvento.tpAmb = IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteNFe.producao, MDFe.EventoCancelamento_V3.TAmb.Item1, MDFe.EventoCancelamento_V3.TAmb.Item2)
            oTEventoInfEvento.tpEvento = "110111"
            oTEventoInfEvento.CNPJ = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")
            oTEventoInfEvento.chMDFe = sChave
            oTEventoInfEvento.dhEvento = Format(dDataEmissao, "yyyy-MM-ddTHH:mm:ss") + LoadFusoHorario()
            oTEventoInfEvento.nSeqEvento = CInt(sSequencia)
            oTEventoInfEventoDetEvento.versaoEvento = "3.00"

            Dim oEvCancMDFe As New evCancMDFe
            oEvCancMDFe.descEvento = evCancMDFeDescEvento.Cancelamento
            oEvCancMDFe.nProt = sNumeroProtocoloAutorizacao
            oEvCancMDFe.xJust = sJustificativa

            'É necessário dar um "load" do xml, instanciar e entao pegar o child node
            Dim sArquivo As String = goConfiguracaoMDFe.sPastaEnvio & "\cancelamento.xml"
            oEvCancMDFe.Save(sArquivo)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sArquivo, _
                                                 goConfiguracaoMDFe.sPastaXSD & "evCancMDFe_v3.00.xsd",
                                                 "evCancMDFe_v3.00.xsd")



            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                MsgBox("O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao)

                'Retorno da Função
                Exit Function

            End If

            'Instancia o tipo xml
            Dim oXML As New XmlDocument

            'Carrega o arquivo salvo
            oXML.Load(sArquivo)

            'Seta no Any 
            oTEventoInfEventoDetEvento.Any = oXML.GetElementsByTagName("evCancMDFe")(0)

            'tenta excluir o arquivo
            Try
                System.IO.File.Delete(sArquivo)
            Catch ex As Exception : End Try


            'Setando os elementos
            oTEventoInfEvento.detEvento = oTEventoInfEventoDetEvento
            oTEvento.infEvento = oTEventoInfEvento

            'Salva Pedido de Inutilização Temporariamente
            oTEvento.Save(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento.xml")

            sArquivo = goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento.xml"

            'Desoneração do ICMS
            Dim oTempReader As New StreamReader(sArquivo)
            Dim sDados As String = oTempReader.ReadToEnd
            oTempReader.Close()

            sDados = Replace(sDados, " xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "")


            Dim oTempWriter As New StreamWriter(sArquivo)
            oTempWriter.WriteLine(sDados)
            oTempWriter.Close()

            Try

                'Assina Arquivo
                oXMLDocument = AssinarXML(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento.xml", "infEvento")

            Catch ex As Exception
                'Exclui Arquivo XML (Pedido de Cancelamento)
                File.Delete(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento.xml")
                'Seta Informação
                sMensagemErro = "Ocorreu um erro ao tentar assinar o Arquivo XML." & vbCrLf & ex.Message
                'Retorno da Função
                Return False
            End Try

            'Exclui Arquivo XML (Pedido de Cancelamento)
            File.Delete(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento.xml")

            'Salva Arquivo XML Assinado
            oXMLDocument.Save(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")

            'Valida Arquivo XML Assinado
            sRetornoValidacao = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml", _
                                                 goConfiguracaoMDFe.sPastaXSD & "eventoMDFe_v3.00.xsd", _
                                                 "eventoMDFe_v3.00.xsd")

            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Pedido de Cancelamento)
                File.Delete(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")

                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                'Obtem Tamanho do Arquivo XML
                Dim oFileInfo As New FileInfo(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")

                'Verifica se o Tamanho do Arquivo XML é maior que o Tamanho Máximo
                If (oFileInfo.Length / 1000) > goConfiguracaoMDFe.iTamanhoMaximo Then
                    'Exclui Arquivo XML (Pedido de Cancelamento)
                    File.Delete(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")
                    'Seta Informação
                    sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                    'Retorno da Função
                    Return False
                End If

                ''Inclui Lote no Arquivo XML
                'Dim sArquivoLote = IncluiLoteMDFe(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml", _
                '                                 "", _
                '                                 Format(1, "000000"))

                'Seta Váriavel
                sArquivoEnvio = goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml"
                sPathArquivoEnvio = goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml"

                Try

                    'Executa Serviço (SÍNCRONO)
                    sArquivoRetorno = WSEvento(sArquivoEnvio)

                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(goConfiguracaoMDFe.sPastaEnvio & sID & "-ped-cancelamento-ass.xml")
                    File.Delete(goConfiguracaoMDFe.sPastaEnvio & "cabecCancelamentoNFe.xml")
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoMDFe.sPastaEnvio & sID & "-ret-ped-cancelamento.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
                oStreamWriter.Write(sArquivoRetorno)
                oStreamWriter.Close()

                'Exclui Cabeçalho
                File.Delete(goConfiguracaoMDFe.sPastaEnvio & "cabecCancelamentomdfe.xml")

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Overloads Shared Function IncluiLoteMDFe(ByVal sArquivoXML As String, _
                                                       ByVal sArquivoLote As String, _
                                                       ByVal sLote As String) As String

        Try

            'Váriaveis Locais
            Dim oXmlDocumentMDFe As New XmlDocument
            Dim oXmlDocumentLote As New XmlDocument
            Dim oNodeEnviMDFe As XmlNodeList
            Dim oNodeMDFe As XmlNodeList
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
                                 "<envEvento xmlns=""http://www.portalfiscal.inf.br/mdfe"" versao=""1.00"">" & _
                                 "<idLote>" & sLote & "</idLote></envEvento>"
                    'Carrega Arquivo de Cabeçalho
                    oXmlDocumentLote.LoadXml(sCabecalho)
                End If

                'Carrega Arquivo de Nota Fiscal
                oXmlDocumentMDFe.Load(sArquivoXML)
                'Ignora Espaços em Branco
                oXmlDocumentMDFe.PreserveWhitespace = False
                oXmlDocumentLote.PreserveWhitespace = False

                'Obtem Elemento enviMDFe
                oNodeEnviMDFe = oXmlDocumentLote.GetElementsByTagName("envEvento")

                'Adiciona o Node MDFe no EnvMDFe
                oNodeMDFe = oXmlDocumentMDFe.GetElementsByTagName("eventoMDFe")
                oNodeEnviMDFe.Item(0).AppendChild(oXmlDocumentLote.ImportNode(oNodeMDFe.Item(0), True))

                'Salva o Arquivo
                oStreamWriter = File.CreateText(goConfiguracaoMDFe.sPastaEnvio & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & sLote & "-env-lot.xml")
                oStreamWriter.Write(oXmlDocumentLote.OuterXml)
                oStreamWriter.Close()

                'Retorna Status
                Return goConfiguracaoMDFe.sPastaEnvio & IIf(goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe = TipoAmbienteMDFe.homologacao, "H", "P") & sLote & "-env-lot.xml"

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


        Dim oTRetEvento As New TRetEvento
        Dim oTRetEventoInfEvento As New TRetEventoInfEvento


        Try

            'Carrega arquivo de Retorno
            oTRetEvento = TRetEvento.Load(sArquivo)
            oTRetEventoInfEvento = oTRetEvento.infEvento

            'Seta Váriaveis
            sVersao = oTRetEvento.versao
            sID = oTRetEventoInfEvento.Id
            iCodigoTipoAmbiente = TipoAmbienteMDFe.producao
            sVersaoAplicativo = oTRetEvento.infEvento.verAplic
            iStatus = oTRetEventoInfEvento.cStat
            sMotivo = oTRetEventoInfEvento.xMotivo
            sDataProcessamento = oTRetEventoInfEvento.dhRegEvento
            sNumeroProtocolo = oTRetEventoInfEvento.nProt


            oTRetEvento = Nothing
            oTRetEventoInfEvento = Nothing
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
