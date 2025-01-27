Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.NFe.AssinaturaDigital_V3
Imports INTERACTI.NFe.ProcNFe_V3
Imports INTERACTI.NFe
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.SQLHelper
Imports System.Xml.Serialization
Imports System.IO.File

Public Class clsNFeArquivoEnvio_V3

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
                               ByVal sArquivoXMLCancelamento As String, _
                               ByVal sArquivoProtocoloCancelamento As String, _
                               ByVal sChave As String, _
                               ByRef sArquivoEnvio As String, _
                               ByRef sMensagemErro As String) As Boolean

        Try

            'Váriaveis Locais
            Dim oXmlDocumentNFe As New XmlDocument
            Dim oXmlDocumentProtocolo As New XmlDocument
            Dim oXmlDocumentEnvio As New XmlDocument
            Dim oXmlDocumentCancelamentoNFe As New XmlDocument
            Dim oXmlDocumentProtocoloCancelamento As New XmlDocument
            Dim oXmlDocumentEnvioCancelamento As New XmlDocument
            Dim oNodeNFe As XmlNodeList
            Dim oNodeProtocolo As XmlNodeList
            Dim oNodeProtocoloCancelamento As XmlNodeList
            Dim oNodeEnvio As XmlNodeList
            Dim oNodeEnvioCancelamento As XmlNodeList
            Dim oStreamWriter As StreamWriter

            'Cria Cabeçalho
            Dim sCabecalho As String

            'sCabecalho = "<?xml version=""1.0"" encoding=""UTF-8""?>" & _
            '             "<nfeProc xmlns=""http://www.portalfiscal.inf.br/nfe"" xmlns:ds=""http://www.w3.org/2000/09/xmldsig#"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://www.portalfiscal.inf.br/nfe procNFe_v3.10.xsd"" versao=""3.10"">" & _
            '             "</nfeProc>"
            sCabecalho = "<nfeProc versao=""3.10"" xmlns=""http://www.portalfiscal.inf.br/nfe""></nfeProc>"


            'Carrega Arquivo de Cabeçalho
            oXmlDocumentEnvio.LoadXml(sCabecalho)

            'Carrega Arquivo de Nota Fiscal
            oXmlDocumentNFe.LoadXml(sArquivoXML)
            'Carrega Arquivo do Protocolo
            oXmlDocumentProtocolo.LoadXml(sArquivoProtocolo)
            'Carrega Arquivo de Cancelamento
            If sArquivoXMLCancelamento <> "" Then
                oXmlDocumentCancelamentoNFe.LoadXml(sArquivoXMLCancelamento)
            End If
            'Carrega Arquivo do Protocolo de Cancelamento
            If sArquivoProtocoloCancelamento <> "" Then
                oXmlDocumentProtocoloCancelamento.LoadXml(sArquivoProtocoloCancelamento)
            End If

            'Ignora Espaços em Branco
            oXmlDocumentEnvio.PreserveWhitespace = False
            oXmlDocumentNFe.PreserveWhitespace = False
            oXmlDocumentProtocolo.PreserveWhitespace = False
            oXmlDocumentCancelamentoNFe.PreserveWhitespace = False
            oXmlDocumentProtocoloCancelamento.PreserveWhitespace = False

            'Obtem Elemento nfeProc
            oNodeEnvio = oXmlDocumentEnvio.GetElementsByTagName("nfeProc", "http://www.portalfiscal.inf.br/nfe")
            'Obtem Elemento NFe
            oNodeNFe = oXmlDocumentNFe.GetElementsByTagName("NFe")
            oNodeProtocolo = oXmlDocumentProtocolo.GetElementsByTagName("protNFe")
            oNodeEnvio.Item(0).AppendChild(oXmlDocumentEnvio.ImportNode(oNodeNFe.Item(0), True))
            oNodeEnvio.Item(0).AppendChild(oXmlDocumentEnvio.ImportNode(oNodeProtocolo.Item(0), True))
            'Obtem Elemento Cancelamento
            If sArquivoXMLCancelamento <> "" Then
                Dim sCabecalhoCancelamento As String = "<procEventoNFe xmlns=""http://www.portalfiscal.inf.br/nfe"" versao=""1.00""></procEventoNFe>"
                Dim oNodeEnvioCanc As XmlNodeList
                'Carrega Arquivo de Cabeçalho
                oXmlDocumentEnvioCancelamento.LoadXml(sCabecalhoCancelamento)

                oNodeEnvioCanc = oXmlDocumentEnvioCancelamento.GetElementsByTagName("procEventoNFe", "http://www.portalfiscal.inf.br/nfe")

                oNodeEnvioCancelamento = oXmlDocumentCancelamentoNFe.GetElementsByTagName("evento")
                oNodeProtocoloCancelamento = oXmlDocumentProtocoloCancelamento.GetElementsByTagName("retEvento")

                oNodeEnvioCanc.Item(0).AppendChild(oXmlDocumentEnvioCancelamento.ImportNode(oNodeEnvioCancelamento.Item(0), True))
                oNodeEnvioCanc.Item(0).AppendChild(oXmlDocumentEnvioCancelamento.ImportNode(oNodeProtocoloCancelamento.Item(0), True))

                For i As Integer = 0 To oXmlDocumentEnvioCancelamento.GetElementsByTagName("retEvento").Item(0).Attributes.Count - 1
                    If oXmlDocumentEnvioCancelamento.GetElementsByTagName("retEvento").Item(0).Attributes(i).Name = "xmlns" Then
                        oXmlDocumentEnvioCancelamento.GetElementsByTagName("retEvento").Item(0).Attributes(i).Value = "http://www.portalfiscal.inf.br/nfe"

                        Exit For
                    End If

                Next
            End If


            'Seta Arquivo de Envio
            If sArquivoEnvio = "" Then
                sArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & sChave & "-nfe.xml"
            End If

            If File.Exists(sArquivoEnvio) = True Then
                File.Delete(sArquivoEnvio)
            End If



            Try
                'Escreve na base de dados
                ExecuteNonQuery(goDatabase.sConnection, CommandType.Text, "sp_update_faturamento_emissao_capa_xml '" & sChave & "', " & CStr(goUsuario.iEmpresa) & ",'" & oXmlDocumentEnvio.OuterXml & "'")

            Catch ex As Exception

            End Try
            

            'Salva o Arquivo
            oStreamWriter = File.CreateText(sArquivoEnvio)
            oStreamWriter.Write(oXmlDocumentEnvio.OuterXml)
            oStreamWriter.Close()

            If sArquivoProtocoloCancelamento <> "" Then
                If File.Exists(sArquivoEnvio.Replace(".xml", "-canc.xml")) = True Then
                    File.Delete(sArquivoEnvio.Replace(".xml", "-canc.xml"))
                End If
                Dim sDados As String = oXmlDocumentEnvioCancelamento.OuterXml
                If sDados.Contains("xmlns=""""") Then
                    sDados = sDados.Replace(" xmlns=""""", "")
                End If

                'Salva o Arquivo
                oStreamWriter = File.CreateText(sArquivoEnvio.Replace(".xml", "-canc.xml"))
                oStreamWriter.Write(sDados)
                oStreamWriter.Close()
            End If

            'Retorna Status
            Return True

        Catch ex As Exception
            sMensagemErro = "ERRO: " & ex.Message
            Return False
        End Try

    End Function

#End Region

End Class
