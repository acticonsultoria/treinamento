Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Security
Imports System.Xml
Imports System.Xml.Schema
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms
Imports Janus.Windows.EditControls

Namespace NFe

    Public NotInheritable Class CertificadoDigital

        Public Overloads Shared Function LoadCertificado() As String

            Try

                'Variaveis Locais
                Dim oX509Store As New X509Store("MY", StoreLocation.CurrentUser)
                oX509Store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)

                Dim oCollection As X509Certificate2Collection = oX509Store.Certificates
                Dim oCollection1 As X509Certificate2Collection = oCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, True)
                Dim oCollection2 As X509Certificate2Collection = oCollection1.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, True)

                Dim sReturn As String = ""

                If oCollection2.Count > 0 Then
                    For Each oObject In oCollection2


                        If oObject.Subject.ToString = goConfiguracaoNFe.sCertificado Then
                            sReturn = oObject.Subject.ToString
                            Exit For

                        End If

                      

                    Next
                Else
                    sReturn = ""
                End If

                Return sReturn

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function BuscaCertificadoNome(ByVal sCertificado As String) As X509Certificate2

            Try

                'Váriaveis Locais
                Dim oX509Cert As New X509Certificate2
                Dim oX509Store As New X509Store("MY", StoreLocation.CurrentUser)

                oX509Store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)

                Dim oCollection As X509Certificate2Collection = oX509Store.Certificates
                Dim oCollection1 As X509Certificate2Collection = oCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, False)
                Dim oCollection2 As X509Certificate2Collection = oCollection.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, False)

                'Caso não tenha certificado cadastrado
                If sCertificado = "" Then

                    'Abre Lista de Certificado
                    Dim sCollection As X509Certificate2Collection = X509Certificate2UI.SelectFromCollection(oCollection2, _
                                                                                                            "Certificado(s) Digital(is) disponível(is)", _
                                                                                                            "Selecione o Certificado Digital para uso no aplicativo", _
                                                                                                            X509SelectionFlag.SingleSelection)

                    'Verifica se foi selecionado algum certificado
                    If (sCollection.Count = 0) Then
                        'Reseta Certificado
                        oX509Cert.Reset()
                        'Informa o Usuário que não encontrou nenhum certificado
                        frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Certificado Digital")
                    Else
                        'Seta Certificado
                        oX509Cert = sCollection(0)
                    End If

                Else

                    'Procura Certificado pelo Nome
                    Dim sCollection As X509Certificate2Collection = oCollection2.Find(X509FindType.FindBySubjectDistinguishedName, _
                                                                                      sCertificado, _
                                                                                      False)

                    'Verifica se encontrou o Certificado pelo Nome
                    If (sCollection.Count = 0) Then
                        'Imforma o Usuário que não foi encontrado o certificado
                        frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Certificado Digital: " & sCertificado)
                        'Reseta Certificado
                        oX509Cert.Reset()
                    Else
                        'Seta Certificado
                        oX509Cert = sCollection(0)
                    End If

                End If

                'Fecha oX509Store
                oX509Store.Close()

                'Retorna Certificado
                Return oX509Cert

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Sub LoadComboCertificado(ByVal oComboBox As UIComboBox)

            Try

                'Variaveis Locais
                Dim i As Integer

                'Carrega Grid
                With oComboBox

                    'Limpa Combo
                    .Items.Clear()

                    Dim oX509Store As New X509Store("MY", StoreLocation.CurrentUser)
                    oX509Store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)

                    Dim oCollection As X509Certificate2Collection = oX509Store.Certificates
                    Dim oCollection1 As X509Certificate2Collection = oCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, True)
                    Dim oCollection2 As X509Certificate2Collection = oCollection1.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, True)

                    For i = 0 To oCollection2.Count - 1
                        .Items.Add(oCollection2(i).Subject.ToString())
                    Next

                End With

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        'Public Overloads Shared Function LoadCertificado() As String

        '    Try

        '        'Variaveis Locais
        '        Dim oX509Store As New X509Store("MY", StoreLocation.CurrentUser)
        '        oX509Store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)

        '        Dim oCollection As X509Certificate2Collection = oX509Store.Certificates
        '        Dim oCollection1 As X509Certificate2Collection = oCollection.Find(X509FindType.FindByTimeValid, DateTime.Now, True)
        '        Dim oCollection2 As X509Certificate2Collection = oCollection1.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, True)

        '        If oCollection2.Count > 0 Then
        '            Return oCollection2(0).Subject.ToString()
        '        End If


        '    Catch ex As Exception
        '        Throw ex
        '    End Try

        'End Function

    End Class

End Namespace
