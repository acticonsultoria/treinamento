Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.NFe.AssinaturaDigital_V4
Imports INTERACTI.NFe.ProcNFe_V4
Imports INTERACTI.NFe
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.SQLHelper
Imports System.Xml.Serialization
Imports System.IO.File

Public Class clsNFeArquivoEnvio_V4

#Region "::: FUNCTION / SUB :::"

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

    Public Function ArquivoNFe(ByVal sArquivoXML As String, _
                               ByVal sArquivoProtocolo As String, _
                               ByVal sChave As String, _
                               ByRef sArquivoEnvio As String, _
                               ByRef sMensagemErro As String) As Boolean

        Try

            'Váriaveis Locais
            Dim oXmlDocumentNFe As New XmlDocument
            Dim oXmlDocumentProtocolo As New XmlDocument
            Dim oXmlDocumentEnvio As New XmlDocument
            Dim oNodeNFe As XmlNodeList
            Dim oNodeProtocolo As XmlNodeList
            Dim oNodeEnvio As XmlNodeList
            Dim oStreamWriter As StreamWriter

         
            'Carrega Arquivo de Nota Fiscal
            oXmlDocumentNFe.LoadXml(sArquivoXML)


            'Cria Cabeçalho
            Dim sCabecalho As String

            If sArquivoXML.ToUpper.Contains("VERSAO=""3.10""") Then
                sCabecalho = "<nfeProc versao=""3.10"" xmlns=""http://www.portalfiscal.inf.br/nfe""></nfeProc>"
            Else
                sCabecalho = "<nfeProc versao=""4.00"" xmlns=""http://www.portalfiscal.inf.br/nfe""></nfeProc>"
            End If


            'If sArquivoXML.ToUpper.Contains("VERSAO=""3.10""") Then
            '    sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?>" & _
            '            "<nfeProc xmlns=""http://www.portalfiscal.inf.br/nfe"" xmlns:ds=""http://www.w3.org/2000/09/xmldsig#"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://www.portalfiscal.inf.br/nfe procNFe_v3.10.xsd"" versao=""3.10"">" & _
            '            "</nfeProc>"
            'Else
            '    sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?>" & _
            '                "<nfeProc xmlns=""http://www.portalfiscal.inf.br/nfe"" xmlns:ds=""http://www.w3.org/2000/09/xmldsig#"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://www.portalfiscal.inf.br/nfe procNFe_v4.00.xsd"" versao=""4.00"">" & _
            '                "</nfeProc>"
            'End If

            'Carrega Arquivo de Cabeçalho
            oXmlDocumentEnvio.LoadXml(sCabecalho)




            'Carrega Arquivo do Protocolo
            oXmlDocumentProtocolo.LoadXml(sArquivoProtocolo)

            'Ignora Espaços em Branco
            oXmlDocumentEnvio.PreserveWhitespace = False
            oXmlDocumentNFe.PreserveWhitespace = False
            oXmlDocumentProtocolo.PreserveWhitespace = False

            'Obtem Elemento nfeProc
            oNodeEnvio = oXmlDocumentEnvio.GetElementsByTagName("nfeProc", "http://www.portalfiscal.inf.br/nfe")
            'Obtem Elemento NFe
            oNodeNFe = oXmlDocumentNFe.GetElementsByTagName("NFe", "http://www.portalfiscal.inf.br/nfe")
            'Obtem Elemento protNFe
            oNodeProtocolo = oXmlDocumentProtocolo.GetElementsByTagName("protNFe", "http://www.portalfiscal.inf.br/nfe")

            oNodeEnvio.Item(0).AppendChild(oXmlDocumentEnvio.ImportNode(oNodeNFe.Item(0), True))
            oNodeEnvio.Item(0).AppendChild(oXmlDocumentEnvio.ImportNode(oNodeProtocolo.Item(0), True))

            'Seta Arquivo de Envio
            If sArquivoEnvio = "" Then
                sArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & sChave & "-nfe.xml"
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

#End Region

End Class
