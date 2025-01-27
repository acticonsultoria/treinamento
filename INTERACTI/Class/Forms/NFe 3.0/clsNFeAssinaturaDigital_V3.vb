Imports System
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Xml
Imports System.Xml.Schema
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml
Imports INTERACTI.NFe.CertificadoDigital

Namespace NFe

    Public NotInheritable Class AssinaturaDigital_V3

#Region "::: FUNCTION / SUB :::"

        Public Overloads Shared Function AssinarXML(ByVal sArquivoXML As String, _
                                                    ByVal sUri As String) As XmlDocument

            'Variaveis Locais
            Dim oXML As New XmlDocument
            Dim sXMLDocument As String
            Dim oCertificado As X509Certificate2
            Dim oStreamReader As StreamReader

            Try

                'Carrega Dados do Arquivo XML em Váriavel
                oStreamReader = File.OpenText(sArquivoXML)
                sXMLDocument = oStreamReader.ReadToEnd.Replace("xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""", "").Replace("xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "").Replace("xmlns:ds=""http://www.w3.org/2000/09/xmldsig#""", "").Replace("xsi:schemaLocation=""http://www.portalfiscal.inf.br/nfe enviNFe_v3.10.xsd""", "")
                oStreamReader.Close()

                'Abre Arquivo XML
                oXML.LoadXml(sXMLDocument)

                'Ignorando os espaços brancos
                oXML.PreserveWhitespace = True

                'Seleciona Certificado Digital
                oCertificado = GetCertificado(LoadCertificado)

                'Cria Objeto Assinado
                Dim oXmlSigned As New SignedXml(oXML)

                'Adiciona Chave do Certificado
                oXmlSigned.SigningKey = oCertificado.PrivateKey

                'Criando uma Referencia
                Dim oReference As New Reference

                'Verificando o URi a ser assinada, de acordo com o documento
                Dim oUri As XmlAttributeCollection = oXML.GetElementsByTagName(sUri).Item(0).Attributes

                'Cria Atributo XML
                Dim oXmlAttribute As XmlAttribute

                'Verificando todos atributos da URi
                For Each oXmlAttribute In oUri
                    If oXmlAttribute.Name = "Id" Then
                        oReference.Uri = "#" & oXmlAttribute.InnerText
                    End If
                Next

                'Adicionando uma transformação para a referencia
                Dim oXmlEnvelopedSignatureTransform As New XmlDsigEnvelopedSignatureTransform
                oReference.AddTransform(oXmlEnvelopedSignatureTransform)

                'Novamente outra transformação
                Dim oXmlEnvelopedC14Transform As New XmlDsigC14NTransform
                oReference.AddTransform(oXmlEnvelopedC14Transform)

                'Adicionando a referência para o objeto assinado
                oXmlSigned.AddReference(oReference)

                'Criando um Objeto de chave e adicionando na assinatura
                Dim oKeyInfo As New KeyInfo
                oKeyInfo.AddClause(New KeyInfoX509Data(oCertificado))
                oXmlSigned.KeyInfo = oKeyInfo

                'Selecionando o tipo de assinatura
                oXmlSigned.ComputeSignature()

                'Criando uma assinatura digital e adicionando em um elemento
                Dim oXmlElement As XmlElement = oXmlSigned.GetXml

                'Adicionando o elemento no XML
                oXML.DocumentElement.AppendChild(oXML.ImportNode(oXmlElement, True))

                'Retorna Arquivo XML
                Return oXML

            Catch ex As Exception
                Throw ex
            End Try

        End Function

#End Region

    End Class

End Namespace
