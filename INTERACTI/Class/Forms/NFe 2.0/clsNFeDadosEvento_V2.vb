Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.NFe.AssinaturaDigital
Imports INTERACTI.NFe.RecepcaoEvento
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.SQLHelper


Namespace NFe

    Public NotInheritable Class DadosCCe

#Region "::: FUNCTION / SUB :::"

        Public Overloads Shared Function ArquivoCCe(ByRef sArquivo As String, _
                                                    ByRef sMensagemErro As String, _
                                                    ByVal sChaveAcesso As String, _
                                                    ByVal sCondicaoUso As String, _
                                                    ByVal sDataEvento As String, _
                                                    ByVal iSequencia As Integer) As Boolean

            'Variaveis Locais
            Dim oTEvento As New TEvento
            Dim oXMLDocument As XmlDocument

            Try

                'Setando a versão
                oTEvento.versao = "1.00"

                'Instanciando
                Dim oTInfEvento As New TEventoInfEvento

                'Seta Parâmetros
                oTInfEvento.chNFe = sChaveAcesso
                oTInfEvento.cOrgao = DefineEnum(goEmitente.iUF, GetType(TCOrgaoIBGE))
                oTInfEvento.dhEvento = Format(CDate(sDataEvento), "yyyy-MM-ddTHH:mm:ss") + "-03:00"
                oTInfEvento.ItemElementName = ItemChoiceType.CNPJ
                oTInfEvento.Item = Replace(Replace(Replace(goEmitente.sCNPJ, "-", ""), ".", ""), "/", "")
                oTInfEvento.nSeqEvento = iSequencia
                oTInfEvento.tpAmb = IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.producao, TAmb.Item1, TAmb.Item2)
                oTInfEvento.tpEvento = TEventoInfEventoTpEvento.Item110110
                oTInfEvento.verEvento = TEventoInfEventoVerEvento.Item100
                oTInfEvento.Id = "ID" + "110110" + sChaveAcesso + Format(iSequencia, "00")


                Dim oTEventoInfEventoDetEvento As New TEventoInfEventoDetEvento

                'Tipo de descrição
                oTEventoInfEventoDetEvento.descEvento = TEventoInfEventoDetEventoDescEvento.CartadeCorreção
                oTEventoInfEventoDetEvento.versao = TEventoInfEventoDetEventoVersao.Item100
                oTEventoInfEventoDetEvento.xCondUso = TEventoInfEventoDetEventoXCondUso.ACartadeCorreçãoédisciplinadapelo1ºAdoart7ºdoConvênioSNde15dedezembrode1970epodeserutilizadapararegularizaçãodeerroocorridonaemissãodedocumentofiscaldesdequeoerronãoestejarelacionadocomIasvariáveisquedeterminamovalordoimpostotaiscomobasedecálculoalíquotadiferençadepreçoquantidadevalordaoperaçãooudaprestaçãoIIacorreçãodedadoscadastraisqueimpliquemudançadoremetenteoudodestinatárioIIIadatadeemissãooudesaída
                oTEventoInfEventoDetEvento.xCorrecao = RetirarAcento2(sCondicaoUso)
                oTInfEvento.detEvento = oTEventoInfEventoDetEvento
                oTEvento.infEvento = oTInfEvento

                'Seta Arquivo
                sArquivo = goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & "cce_" & sChaveAcesso & ".xml"

                'Salva Arquivo XML
                oTEvento.Save(sArquivo)

                Try

                    'Assina Arquivo
                    oXMLDocument = AssinarXML(sArquivo, "infEvento")

                Catch ex As Exception
                    oTEvento = Nothing
                    'Exclui Arquivo XML (CCe)
                    File.Delete(sArquivo)
                    'Seta Informação
                    sMensagemErro = "Ocorreu um erro ao tentar assinar o Arquivo XML." & vbCrLf & ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Exclui Arquivo XML (CCe)
                File.Delete(sArquivo)

                'Seta Arquivo 
                sArquivo = goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & "cce_" & sChaveAcesso & "-ass.xml"

                'Salva Arquivo XML Assinado
                oXMLDocument.Save(sArquivo)

                'Valida Arquivo XML Assinado
                Dim sRetornoValidacao As String = ""

                'Verifica se Encontrou algum Erro no Arquivo XML
                sRetornoValidacao = ValidaArquivoXML(sArquivo, _
                                                     goConfiguracaoNFe.sPastaXSD & "CCe_v1.00.xsd")

                'Verifica se ocorreu algum erro na Validação
                If sRetornoValidacao <> "" Then

                    'Limpa Váriavel
                    oTEvento = Nothing
                    'Exclui Arquivo XML (Status)
                    File.Delete(sArquivo)
                    'Seta Informação
                    sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                    'Informa o Erro Ocorrigo
                    MsgBox(sMensagemErro, MsgBoxStyle.Exclamation, "Erro")

                    'Retorno da Função
                    Return False

                Else

                    'Obtem Tamanho do Arquivo XML
                    Dim oFileInfo As New FileInfo(sArquivo)

                    'Verifica se o Tamanho do Arquivo XML é maior que o Tamanho Máximo
                    If (oFileInfo.Length / 1000) > goConfiguracaoNFe.iTamanhoMaximo Then
                        'Limpa Váriavel
                        oTEvento = Nothing
                        'Exclui Arquivo XML (Status)
                        File.Delete(sArquivo)
                        'Seta Informação
                        sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                        'Retorno da Função
                        Return False
                    End If

                    'Inclui Lote no Arquivo XML
                    Dim sArquivoLote = IncluiLoteCCe(sArquivo, _
                                                     "", _
                                                     Format(iSequencia, "000000"))

                    'Exclui Arquivo XML
                    File.Delete(sArquivo)

                    If sArquivoLote <> "ERROR" Then
                        'Seta Arquivo
                        sArquivo = sArquivoLote
                        'Seta Retorno da Função
                        Return True
                    Else
                        'Seta Retorno da Função
                        Return False
                    End If

                End If

            Catch ex As Exception
                oTEvento = Nothing
                sMensagemErro = ex.Message
                Return False
            End Try

        End Function

        Public Overloads Shared Function IncluiLoteCCe(ByVal sArquivoXML As String, _
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

                        sCabecalho = "<envEvento xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""1.00"">" & _
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
                    oStreamWriter = File.CreateText(goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sLote & "-env-cce.xml")
                    oStreamWriter.Write(oXmlDocumentLote.OuterXml)
                    oStreamWriter.Close()

                    'Retorna Status
                    Return goConfiguracaoNFe.sPastaEnvio & IIf(goConfiguracaoNFe.iCodigoTipoAmbienteNFe = TipoAmbienteNFe.homologacao, "H", "P") & sLote & "-env-cce.xml"

                Else
                    'Retorna se nota nao encontrada
                    Return "ERROR"
                End If

            Catch ex As Exception
                Throw ex
            End Try

        End Function

#End Region

    End Class

End Namespace