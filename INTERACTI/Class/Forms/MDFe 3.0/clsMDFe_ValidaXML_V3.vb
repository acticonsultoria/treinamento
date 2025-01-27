Imports System
Imports System.IO
Imports System.Xml
Imports System.Xml.Schema

Namespace MDFe

    Public NotInheritable Class ValidaXML

#Region "::: VÁRIAVEIS :::"

        Private Shared sResult As String = ""

#End Region

#Region "::: FUNCTION / SUB :::"
        

        Public Overloads Shared Function ValidaArquivoXML(ByVal sArquivoXML As String, _
                                                          ByVal sArquivoXSD As String, _
                                                          ByVal sNomeXSD As String) As String


            sResult = ""
            ValidaArquivoXML = ""

            'Verifica se o Arquivo Existe
            If File.Exists(sArquivoXML) = False Then
                'Retorna que não encontrou Arquivo XML
                Return "ERRO: Arquivo XML com dados da NFe não foi encontrado."
            ElseIf File.Exists(sArquivoXSD) = False Then
                'Retorna que não encontrou Arquivo XSD
                Return "ERRO: Arquivo XSD Utilizado na validação não foi encontrado."
            Else

                'Declara XML Reader
                Dim oXmlReaderSettings As New XmlReaderSettings()

                'Adiciona Validação
                AddHandler oXmlReaderSettings.ValidationEventHandler, AddressOf ValidationEventHandler


                Try
                    oXmlReaderSettings.ValidationType = ValidationType.Schema
                    oXmlReaderSettings.Schemas.Add("http://www.portalfiscal.inf.br/mdfe", XmlReader.Create(sArquivoXSD))
                    'oXmlReaderSettings.Schemas.Add("http://www.portalfiscal.inf.br/mdfe", XmlReader.Create(goConfiguracaoMDFe.sPastaXSD & "mdfe_v1.00.xsd"))


                    Using XmlValidatingReader As XmlReader = XmlReader.Create(sArquivoXML, oXmlReaderSettings)
                        While XmlValidatingReader.Read()
                        End While
                    End Using

                    'Retorno da Função
                    Return sResult

                Catch ex As Exception
                    sResult = sResult & IIf(sResult = "", "ERRO: ", vbCrLf & "ERRO: ") & ex.Message
                    Return sResult
                End Try


            End If

        End Function

        Public Overloads Shared Sub ValidationEventHandler(ByVal sender As Object, _
                                                           ByVal args As ValidationEventArgs)

            If args.Severity = XmlSeverityType.Warning Then
                sResult = sResult & IIf(sResult = "", "ALERTA: ", vbCrLf & "ALERTA: ") & "Nenhum Arquivo de Schema foi encontrado para efetuar a Validação."
            End If

            If Not (args.Exception Is Nothing) Then
                sResult = sResult & IIf(sResult = "", "ERRO: ", vbCrLf & "ERRO: ") & args.Message
            End If

        End Sub

#End Region

    End Class

End Namespace