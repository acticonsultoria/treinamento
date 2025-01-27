Imports System.Xml
Imports System.Web
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml.Schema
Imports System.Security.Cryptography.Xml
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Net
Imports INTERACTI.NFe.CertificadoDigital


Namespace NFe

    Public NotInheritable Class WebService_V4
        Public Overloads Shared Function WSConsultaDFe_CTE(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd
            oStreamReader.Close()


            Try

                'Váriaveis Locais
                Dim oNfeConsultaNFeDestinada As New br.gov.fazenda.cte.DFeCTe.CTeDistribuicaoDFe


                'Adiciona Certificado
                oNfeConsultaNFeDestinada.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeConsultaNFeDestinada.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeConsultaNFeDestinada.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeConsultaNFeDestinada.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                'Carregando os dados 
                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)

                'Enviando
                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                sRetorno = oNfeConsultaNFeDestinada.cteDistDFeInteresse(oXmlDocument).OuterXml

                'Finalizando
                oNfeConsultaNFeDestinada.Dispose()


                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function
        Public Overloads Shared Function WSConsultaDFe(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd
            oStreamReader.Close()


            Try

                'Váriaveis Locais
                Dim oNfeConsultaNFeDestinada As New br.gov.fazenda.nfe.ConsultaDFe.NFeDistribuicaoDFe


                'Adiciona Certificado
                oNfeConsultaNFeDestinada.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeConsultaNFeDestinada.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeConsultaNFeDestinada.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeConsultaNFeDestinada.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                'Carregando os dados 
                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)

                'Enviando
                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                sRetorno = oNfeConsultaNFeDestinada.nfeDistDFeInteresse(oXmlDocument).OuterXml

                'Finalizando
                oNfeConsultaNFeDestinada.Dispose()


                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSStatusServico_V4(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd.Replace("xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""", "").Replace("xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "")
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                Dim oNfeStatusServico As New br.gov.sp.fazenda.nfe.V4_StatusServico.NFeStatusServico4


                'Seta URL
                oNfeStatusServico.Url = LoadURLNFe(WebServiceNFe.NfeStatusServico, goEmitente.sUF)


                'Adiciona Certificado
                oNfeStatusServico.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeStatusServico.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeStatusServico.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeStatusServico.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)

                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                'Enviando
                sRetorno = oNfeStatusServico.nfeStatusServicoNF(oXmlDocument).OuterXml
                oNfeStatusServico.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSRecepcaoLote_V4(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                Dim oNfeRecepcaoLote As New br.gov.sp.fazenda.nfe.v4_AutorizacaoLote.NFeAutorizacao4


                'Seta URL
                oNfeRecepcaoLote.Url = LoadURLNFe(WebServiceNFe.NfeRecepcao, goEmitente.sUF)

                'Adiciona Certificado
                oNfeRecepcaoLote.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeRecepcaoLote.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeRecepcaoLote.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeRecepcaoLote.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                'Seta Timeout
                oNfeRecepcaoLote.Timeout = goConfiguracaoNFe.iTimeOut
                oNfeRecepcaoLote.InitializeLifetimeService()

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)

         

                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                sRetorno = oNfeRecepcaoLote.nfeAutorizacaoLote(oXmlDocument).OuterXml
                oNfeRecepcaoLote.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSRetRecepcaoLote_V4(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd.Replace("xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""", "").Replace("xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "")
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                Dim oNfeRetRecepcaoLote As New br.gov.sp.fazenda.nfe.v4_RetAutorizacaoLote.NFeRetAutorizacao4

                'Seta URL
                oNfeRetRecepcaoLote.Url = LoadURLNFe(WebServiceNFe.NfeRetRecepcao, goEmitente.sUF)

                'Adiciona Certificado
                oNfeRetRecepcaoLote.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeRetRecepcaoLote.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeRetRecepcaoLote.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeRetRecepcaoLote.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                'Seta Timeout
                oNfeRetRecepcaoLote.Timeout = goConfiguracaoNFe.iTimeOut
                oNfeRetRecepcaoLote.InitializeLifetimeService()

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)


                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                sRetorno = oNfeRetRecepcaoLote.nfeRetAutorizacaoLote(oXmlDocument).OuterXml
                oNfeRetRecepcaoLote.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSEventoCancelamento(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd
            oStreamReader.Close()

            Try

                ''Váriaveis Locais
                'Dim oNfeEventoCancelamento As New br.gov.sp.fazenda.nfe.v4_RecepcaoEvento.NFeRecepcaoEvento4
                Dim oRecepcaoEvento As New br.gov.sp.fazenda.nfe.v4_RecepcaoEvento.NFeRecepcaoEvento4
                'Dim oRecepcaoEvento As New br.gov.fazenda.nfe.V2_RecepcaoEvento.RecepcaoEvento
                Dim oMsgCabecalho As New br.gov.fazenda.nfe.V2_RecepcaoEvento.nfeCabecMsg



                'Seta URL
                oRecepcaoEvento.Url = LoadURLNFe(WebServiceNFe.NFeRecepcaoEvento, goEmitente.sUF)


                'Adiciona Certificado
                oRecepcaoEvento.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oRecepcaoEvento.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oRecepcaoEvento.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oRecepcaoEvento.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)

                oMsgCabecalho.cUF = goEmitente.iUF
                oMsgCabecalho.versaoDados = "1.00"

                'oRecepcaoEvento.nfeCabecMsgValue = oMsgCabecalho


                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                sRetorno = oRecepcaoEvento.nfeRecepcaoEvento(oXmlDocument).OuterXml

                oRecepcaoEvento.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSConsultaSituacaoNF_V4(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd.Replace("xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" ", "").Replace("xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" ", "")
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                Dim oNfeConsulta As New br.gov.sp.fazenda.nfe.v4_ConsultaNF.NFeConsultaProtocolo4

                'Seta URL
                oNfeConsulta.Url = LoadURLNFe(WebServiceNFe.NfeConsultaNF, goEmitente.sUF)

                'Adiciona Certificado
                oNfeConsulta.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeConsulta.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeConsulta.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeConsulta.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                'Seta Timeout
                oNfeConsulta.Timeout = goConfiguracaoNFe.iTimeOut
                oNfeConsulta.InitializeLifetimeService()

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)

                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                sRetorno = oNfeConsulta.nfeConsultaNF(oXmlDocument).OuterXml

                oNfeConsulta.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSConsultaCadastro_V2(ByVal sMensagem As String, _
                                                               ByVal sUF As String, _
                                                               ByVal iCodigoIBGEUF As Integer) As String

            'Váriaveis Locais            
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd.Replace("xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""", "").Replace("xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "")
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                Dim oNfeConsulta As New br.gov.fazenda.nfe.V2_ConsultaCadastro.CadConsultaCadastro2
                Dim oMsgCabecalho As New br.gov.fazenda.nfe.V2_ConsultaCadastro.nfeCabecMsg

                'Seta URL
                oNfeConsulta.Url = LoadURLNFe(WebServiceNFe.ConsultaCadastro, sUF)

                'Adiciona Certificado
                oNfeConsulta.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeConsulta.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeConsulta.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeConsulta.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                'Seta Timeout
                oNfeConsulta.Timeout = goConfiguracaoNFe.iTimeOut
                oNfeConsulta.InitializeLifetimeService()

                oMsgCabecalho.versaoDados = "2.00"
                oMsgCabecalho.cUF = iCodigoIBGEUF
                oNfeConsulta.nfeCabecMsgValue = oMsgCabecalho

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)

                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                sRetorno = oNfeConsulta.consultaCadastro2(oXmlDocument).OuterXml
                oNfeConsulta.Dispose()

                Return sRetorno

            Catch ex As Exception

                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSRecepcaoEvento_V4(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sCCeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sCCeDados = oStreamReader.ReadToEnd.Replace("xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""", "").Replace("xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "")
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                'Dim oRecepcaoEvento As New br.gov.fazenda.nfe.V2_RecepcaoEvento.RecepcaoEvento
                Dim oRecepcaoEvento As New br.gov.sp.fazenda.nfe.v4_RecepcaoEvento.NFeRecepcaoEvento4
                'Dim oMsgCabecalho As New br.gov.fazenda.nfe.V2_RecepcaoEvento.nfeCabecMsg

                'Seta URL
                oRecepcaoEvento.Url = LoadURLNFe(WebServiceNFe.NFeRecepcaoEvento, goEmitente.sUF)

                'Adiciona Certificado
                oRecepcaoEvento.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oRecepcaoEvento.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oRecepcaoEvento.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oRecepcaoEvento.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                'Seta Timeout
                oRecepcaoEvento.Timeout = goConfiguracaoNFe.iTimeOut
                oRecepcaoEvento.InitializeLifetimeService()

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sCCeDados)

                'oMsgCabecalho.cUF = goEmitente.iUF
                'oMsgCabecalho.versaoDados = "1.00"

                'oRecepcaoEvento.nfeCabecMsgValue = oMsgCabecalho

                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                sRetorno = oRecepcaoEvento.nfeRecepcaoEvento(oXmlDocument).OuterXml

                oRecepcaoEvento.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSInutilizacaoNumeracaoNFe_V4(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                Dim oNfeInutilizacao As New br.gov.sp.fazenda.nfe.v4_Inutilizacao.NFeInutilizacao4

                'Seta URL
                oNfeInutilizacao.Url = LoadURLNFe(WebServiceNFe.NfeiNutilizacao, goEmitente.sUF)

                'Adiciona Certificado
                oNfeInutilizacao.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeInutilizacao.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeInutilizacao.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeInutilizacao.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                'Seta Timeout
                'oNfeCancelamento.Timeout = goConfiguracaoNFe.iTimeOut
                'oNfeCancelamento.InitializeLifetimeService()

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)


                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                sRetorno = oNfeInutilizacao.nfeInutilizacaoNF(oXmlDocument).OuterXml
                oNfeInutilizacao.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSDownloadNFe(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                Dim oNfeDownloadNFe As New br.gov.fazenda.nfe.DownloadNFe.NfeDownloadNF
                Dim oNFeCabecalho As New br.gov.fazenda.nfe.DownloadNFe.nfeCabecMsg

                'Seta URL
                'oNfeDownloadNFe.Url = LoadURLNFe(WebServiceNFe.NfeStatusServico)

                'Setando o cabeçalho
                oNFeCabecalho.cUF = goConfiguracaoNFe.sCodigoEstado
                oNFeCabecalho.versaoDados = "1.00"

                oNfeDownloadNFe.nfeCabecMsgValue = oNFeCabecalho

                'Adiciona Certificado
                oNfeDownloadNFe.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeDownloadNFe.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeDownloadNFe.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeDownloadNFe.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                sNFeDados = Replace(sNFeDados, "xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "")
                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)

                'oNfeDownloadNFe.SoapVersion = Services.Protocols.SoapProtocolVersion.Soap12

                System.Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12

                'Enviando
                sRetorno = oNfeDownloadNFe.nfeDownloadNF(oXmlDocument).OuterXml
                oNfeDownloadNFe.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSManifestacaoDestinatario(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sNFeDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sNFeDados = oStreamReader.ReadToEnd
            oStreamReader.Close()

            Try

                ''Váriaveis Locais
                'Dim oNfeManifestacaoDestinatario As New br.gov.fazenda.nfe.ManifestacaoDestinatario.RecepcaoEvento
                'Dim oNFeCabecalho As New br.gov.fazenda.nfe.ManifestacaoDestinatario.nfeCabecMsg

                Dim oNfeManifestacaoDestinatario As New br.gov.fazenda.nfe.evento.NFeRecepcaoEvento4


                'Seta URL
                oNfeManifestacaoDestinatario.Url = "https://www.nfe.fazenda.gov.br/NFeRecepcaoEvento4/NFeRecepcaoEvento4.asmx" 'LoadURLNFe(WebServiceNFe.NfeStatusServico)


                'Adiciona Certificado
                oNfeManifestacaoDestinatario.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                    oNfeManifestacaoDestinatario.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFe.sDominio.Trim = "" Then
                        oNfeManifestacaoDestinatario.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                    Else
                        oNfeManifestacaoDestinatario.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                    End If
                End If

                'Carregando os dados 
                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sNFeDados)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                'Enviando
                sRetorno = oNfeManifestacaoDestinatario.nfeRecepcaoEventoNF(oXmlDocument).OuterXml

                'Finalizando
                oNfeManifestacaoDestinatario.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        'Public Overloads Shared Function WSConsultaNFDestinada(ByVal sMensagem As String) As String

        '    'Váriaveis Locais
        '    Dim sNFeDados As String
        '    Dim sRetorno As String = ""
        '    Dim oStreamReader As StreamReader

        '    'Busca o Certificado no Repositorio do Vindows
        '    Dim oCertificado As New X509Certificate2

        '    'Obtem Certificado
        '    oCertificado = GetCertificado(LoadCertificado)

        '    oStreamReader = File.OpenText(sMensagem)
        '    sNFeDados = oStreamReader.ReadToEnd
        '    oStreamReader.Close()

        '    Try

        '        'Váriaveis Locais
        '        Dim oNfeConsultaNFeDestinada As New br.gov.fazenda.nfe.V2_ConsultaNFDestinada.NFeConsultaDest
        '        Dim oNFeCabecalho As New br.gov.fazenda.nfe.V2_ConsultaNFDestinada.nfeCabecMsg

        '        'Seta URL
        '        'oNfeConsultaNFeDestinada.Url = LoadURLNFe(WebServiceNFe.NFeRecepcaoEvento, goConfiguracaoNFe.sUF)

        '        'Setando o cabeçalho
        '        oNFeCabecalho.cUF = goConfiguracaoNFe.sCodigoEstado
        '        oNFeCabecalho.versaoDados = "1.01"

        '        oNfeConsultaNFeDestinada.nfeCabecMsgValue = oNFeCabecalho

        '        'Adiciona Certificado
        '        oNfeConsultaNFeDestinada.ClientCertificates.Add(oCertificado)

        '        ''Caso tenha Proxy
        '        'If goConfiguracaoNFe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
        '        '    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
        '        '    oNfeConsultaNFeDestinada.Proxy = New WebProxy(sEndereco, True)
        '        '    If goConfiguracaoNFe.sDominio.Trim = "" Then
        '        '        oNfeConsultaNFeDestinada.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
        '        '    Else
        '        '        oNfeConsultaNFeDestinada.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
        '        '    End If
        '        'End If

        '        'Carregando os dados 
        '        Dim oXmlDocument As New XmlDocument
        '        oXmlDocument.LoadXml(sNFeDados)

        '        'Enviando
        '        sRetorno = oNfeConsultaNFeDestinada.nfeConsultaNFDest(oXmlDocument).OuterXml

        '        'Finalizando
        '        oNfeConsultaNFeDestinada.Dispose()

        '        Return sRetorno

        '    Catch ex As Exception
        '        Throw ex
        '    End Try

        'End Function

    End Class

End Namespace