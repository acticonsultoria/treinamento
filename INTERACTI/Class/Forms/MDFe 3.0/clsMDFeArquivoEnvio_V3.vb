Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.MDFe.AssinaturaDigital
'Imports INTERACTI.MDFe.ProcMDFe_V3
Imports INTERACTI.MDFe
Imports INTERACTI.MDFe.ValidaXML
Imports INTERACTI.SQLHelper
Imports System.Xml.Serialization
Imports System.IO.File

Public Class clsMDFeArquivoEnvio_V3

#Region "::: FUNCTION / SUB :::"

    Public Function ArquivoMDFe(ByVal sArquivoXML As String, _
                               ByVal sArquivoProtocolo As String, _
                               ByVal sArquivoXMLCancelamento As String, _
                               ByVal sArquivoProtocoloCancelamento As String, _
                               ByVal sChave As String, _
                               ByRef sArquivoEnvio As String, _
                               ByRef sMensagemErro As String) As Boolean

        Try

            'Váriaveis Locais
            Dim oXmlDocumentMDFe As New XmlDocument
            Dim oXmlDocumentProtocolo As New XmlDocument
            Dim oXmlDocumentEnvio As New XmlDocument
            Dim oXmlDocumentCancelamentoMDFe As New XmlDocument
            Dim oXmlDocumentProtocoloCancelamento As New XmlDocument
            Dim oNodeMDFe As XmlNodeList
            Dim oNodeProtocolo As XmlNodeList
            Dim oNodeProtocoloCancelamento As XmlNodeList
            Dim oNodeEnvio As XmlNodeList
            Dim oNodeEnvioCancelamento As XmlNodeList
            Dim oStreamWriter As StreamWriter

            'Cria Cabeçalho
            Dim sCabecalho As String
            sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?><mdfeProc xmlns=""http://www.portalfiscal.inf.br/mdfe"" versao=""1.00""></mdfeProc>"

            'Carrega Arquivo de Cabeçalho
            oXmlDocumentEnvio.LoadXml(sCabecalho)

            'Carrega Arquivo de Nota Fiscal
            oXmlDocumentMDFe.LoadXml(sArquivoXML)
            'Carrega Arquivo do Protocolo
            oXmlDocumentProtocolo.LoadXml(sArquivoProtocolo)
            'Carrega Arquivo de Cancelamento
            If sArquivoXMLCancelamento <> "" Then
                oXmlDocumentCancelamentoMDFe.LoadXml(sArquivoXMLCancelamento)
            End If
            'Carrega Arquivo do Protocolo de Cancelamento
            If sArquivoProtocoloCancelamento <> "" Then
                oXmlDocumentProtocoloCancelamento.LoadXml(sArquivoProtocoloCancelamento)
            End If

            'Ignora Espaços em Branco
            oXmlDocumentEnvio.PreserveWhitespace = False
            oXmlDocumentMDFe.PreserveWhitespace = False
            oXmlDocumentProtocolo.PreserveWhitespace = False
            oXmlDocumentCancelamentoMDFe.PreserveWhitespace = False
            oXmlDocumentProtocoloCancelamento.PreserveWhitespace = False

            'Obtem Elemento nfeProc
            oNodeEnvio = oXmlDocumentEnvio.GetElementsByTagName("mdfeProc", "http://www.portalfiscal.inf.br/mdfe")
            'Obtem Elemento NFe
            oNodeMDFe = oXmlDocumentMDFe.GetElementsByTagName("MDFe")
            oNodeProtocolo = oXmlDocumentProtocolo.GetElementsByTagName("protMDFe")
            oNodeEnvio.Item(0).AppendChild(oXmlDocumentEnvio.ImportNode(oNodeMDFe.Item(0), True))
            oNodeEnvio.Item(0).AppendChild(oXmlDocumentEnvio.ImportNode(oNodeProtocolo.Item(0), True))
            'Obtem Elemento Cancelamento
            If sArquivoXMLCancelamento <> "" Then
                oNodeEnvioCancelamento = oXmlDocumentCancelamentoMDFe.GetElementsByTagName("enviMDFe")
                oNodeProtocoloCancelamento = oXmlDocumentProtocoloCancelamento.GetElementsByTagName("retEnvEvento")
                oNodeEnvio.Item(0).AppendChild(oXmlDocumentEnvio.ImportNode(oNodeEnvioCancelamento.Item(0), True))
                oNodeEnvio.Item(0).AppendChild(oXmlDocumentEnvio.ImportNode(oNodeProtocoloCancelamento.Item(0), True))
            End If


            'Seta Arquivo de Envio
            If sArquivoEnvio = "" Then
                sArquivoEnvio = goConfiguracaoMDFe.sPastaEnvio & sChave & "-mdfe.xml"
            End If

            If File.Exists(sArquivoEnvio) = True Then
                File.Delete(sArquivoEnvio)
            End If

            'Salva o Arquivo
            oStreamWriter = File.CreateText(sArquivoEnvio)
            oStreamWriter.Write(oXmlDocumentEnvio.OuterXml)
            oStreamWriter.Close()

            'Retorna Status
            Return True

        Catch ex As Exception
            sMensagemErro = "ERRO: " & ex.Message
            Return False
        End Try

    End Function

    Public Function XMLCartaCorrecao(ByVal lCodigoEmissaoCapa As Long, _
                                     ByVal iSequencia As Integer, _
                                     ByVal sChaveAcesso As String, _
                                     ByRef sArquivoXML As String, _
                                     ByRef sMensagemErro As String) As Boolean

        Try

            'Váriaveis Locais
            Dim oXmlDocumentCC As New XmlDocument
            Dim oXmlDocumentEnvio As New XmlDocument
            Dim oXmlDocumentRetorno As New XmlDocument
            Dim oNodeCC As XmlNodeList
            Dim oNodeEnvio As XmlNodeList
            Dim oNodeRetorno As XmlNodeList
            Dim oStreamWriter As StreamWriter

            'Cria Cabeçalho
            Dim sCabecalho As String
            sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?>" & _
                         "<procEventoNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""1.00"">" & _
                         "</procEventoNFe>"

            'Carrega Arquivo de Cabeçalho
            oXmlDocumentCC.LoadXml(sCabecalho)

            'Carrega Arquivo de Nota Fiscal
            oXmlDocumentEnvio.LoadXml(LoadDescricao("sp_select_faturamento_emissao_carta_correcao_xml_envio " & lCodigoEmissaoCapa & ", " & goUsuario.iEmpresa & ", " & iSequencia))
            'Carrega Arquivo do Protocolo
            oXmlDocumentRetorno.LoadXml(LoadDescricao("sp_select_faturamento_emissao_carta_correcao_xml_retorno " & lCodigoEmissaoCapa & ", " & goUsuario.iEmpresa & ", " & iSequencia))

            'Ignora Espaços em Branco
            oXmlDocumentCC.PreserveWhitespace = False
            oXmlDocumentEnvio.PreserveWhitespace = False
            oXmlDocumentRetorno.PreserveWhitespace = False

            'Obtem Elemento procEventoNFe
            oNodeCC = oXmlDocumentCC.GetElementsByTagName("procEventoNFe", "http://www.portalfiscal.inf.br/nfe")
            'Obtem Elemento NFe
            oNodeEnvio = oXmlDocumentEnvio.GetElementsByTagName("evento", "http://www.portalfiscal.inf.br/nfe")
            oNodeRetorno = oXmlDocumentRetorno.GetElementsByTagName("retEvento", "http://www.portalfiscal.inf.br/nfe")
            oNodeCC.Item(0).AppendChild(oXmlDocumentCC.ImportNode(oNodeEnvio.Item(0), True))
            oNodeCC.Item(0).AppendChild(oXmlDocumentCC.ImportNode(oNodeRetorno.Item(0), True))

            'Seta Arquivo de Envio
            If sArquivoXML = "" Then
                sArquivoXML = goConfiguracaoNFe.sPastaEnvio & "CartaCorrecao" & sChaveAcesso & ".xml"
            End If

            If File.Exists(sArquivoXML) = True Then
                File.Delete(sArquivoXML)
            End If

            'Salva o Arquivo
            oStreamWriter = File.CreateText(sArquivoXML)
            oStreamWriter.Write(oXmlDocumentCC.OuterXml)
            oStreamWriter.Close()

            'Retorna Status
            Return True

        Catch ex As Exception
            sMensagemErro = "ERRO: " & ex.Message
            Return False
        End Try

    End Function

#End Region

End Class
