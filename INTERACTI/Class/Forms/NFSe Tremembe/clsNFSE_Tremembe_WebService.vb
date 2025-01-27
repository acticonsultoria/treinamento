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
Imports INTERACTI.NFSE_Tremembe.CertificadoDigital

Namespace NFSE_Tremembe

    Public NotInheritable Class WebService

#Region "::: ENUM ::: "

        Public Enum NFSE_TipoServicoWS
            EnvioLote = 1
            RetornoLote = 2
            ConsultaNFSe = 3
            CancelarNFSe = 4
        End Enum

#End Region

#Region "::: FUNCION HOMOLOGAÇÃO :::"

        Public Overloads Shared Function WS_EnvioLoteNFSeHomologacao(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sRetorno As String = ""
            Dim sDadosNFSe As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            Try

                'Váriaveis Locais
                Dim oServiceGinfesImplService As New br.com.ginfes.homologacao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()

                Dim oCabecalho As New NFSE.ConsultaNFSe.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")

                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.RecepcionarLoteRpsV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_ConsultaLoteNFSeHomologacao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.homologacao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()

                Dim oCabecalho As New NFSE.ConsultaSituacao_LoteRPS.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)


                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.ConsultarLoteRpsV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_ConsultaSituacaoLoteRPSHomologacao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.homologacao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()

                Dim oCabecalho As New NFSE.ConsultaSituacao_LoteRPS.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.ConsultarSituacaoLoteRpsV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_CancelarNFSeHomologacao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.homologacao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()

                Dim oCabecalho As New NFSE.ConsultaNFSe.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.CancelarNfseV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                MsgBox(sRetorno)

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_CancelarNFSe_V2Homologacao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.homologacao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()


                Dim oCabecalho As New NFSE.ConsultaNFSe.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Seta URL
                'oServiceGinfesImplService.Url = LoadURLNFSE(WebServiceNFSE.ConsultaNFSe)

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)


                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.CancelarNfse(sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_ConsultaNFSeHomologacao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.homologacao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()


                Dim oCabecalho As New NFSE.ConsultaNFSe.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")

                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.ConsultarNfseV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                MsgBox(sRetorno)

            Catch ex As Exception
                Throw ex
            End Try

        End Function

#End Region

#Region "::: FUNCION PRODUÇÃO :::"

        Public Overloads Shared Function WS_EnvioLoteNFSeProducao(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sRetorno As String = ""
            Dim sDadosNFSe As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            Try

                'Váriaveis Locais
                Dim oServiceGinfesImplService As New br.com.ginfes.producao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()

                Dim oCabecalho As New NFSE.ConsultaNFSe.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")

                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.RecepcionarLoteRpsV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_ConsultaLoteNFSeProducao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.producao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()

                Dim oCabecalho As New NFSE.ConsultaSituacao_LoteRPS.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)


                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.ConsultarLoteRpsV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_ConsultaSituacaoLoteRPSProducao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.producao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()

                Dim oCabecalho As New NFSE.ConsultaSituacao_LoteRPS.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.ConsultarSituacaoLoteRpsV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_CancelarNFSeProducao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.producao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()

                Dim oCabecalho As New NFSE.ConsultaNFSe.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.CancelarNfseV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                MsgBox(sRetorno)

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_CancelarNFSe_V2Producao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.producao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()


                Dim oCabecalho As New NFSE.ConsultaNFSe.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Seta URL
                'oServiceGinfesImplService.Url = LoadURLNFSE(WebServiceNFSE.ConsultaNFSe)

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)


                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.CancelarNfse(sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WS_ConsultaNFSeProducao(ByVal sMensagem As String) As String

            Try

                'Váriaveis Locais
                Dim sRetorno As String = ""
                Dim sDadosNFSe As String = ""
                Dim oStreamReader As StreamReader

                'Busca o Certificado no Repositorio do Vindows
                Dim oCertificado As New X509Certificate2

                'Obtem Certificado
                oCertificado = GetCertificado(LoadCertificado)

                'Váriaveis do WebService
                Dim oServiceGinfesImplService As New br.com.ginfes.producao.ServiceGinfesImplService
                Dim sCabecalho As String = ""

                'Seta URL
                oServiceGinfesImplService.Url = LoadURLNFSe()

                oStreamReader = File.OpenText(sMensagem)
                sDadosNFSe = oStreamReader.ReadToEnd
                oStreamReader.Close()


                Dim oCabecalho As New NFSE.ConsultaNFSe.cabecalho
                oCabecalho.versao = "3"
                oCabecalho.versaoDados = "3"
                oCabecalho.Save(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")

                oStreamReader = File.OpenText(goConfiguracaoNFSe.sPastaEnvio & "cabecalho.xml")
                sCabecalho = oStreamReader.ReadToEnd
                oStreamReader.Close()

                'Adiciona Certificado
                oServiceGinfesImplService.ClientCertificates.Add(oCertificado)

                'Caso tenha Proxy
                If goConfiguracaoNFSe.bHabilitarProxy = True And System.Net.Dns.GetHostName <> "Note-Tharcius" Then
                    Dim sEndereco As String = goConfiguracaoNFSe.sEndereco & ":" & goConfiguracaoNFSe.iPorta
                    oServiceGinfesImplService.Proxy = New WebProxy(sEndereco, True)
                    If goConfiguracaoNFSe.sDominio.Trim = "" Then
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha))
                    Else
                        oServiceGinfesImplService.Proxy.Credentials = New NetworkCredential(goConfiguracaoNFSe.sUsuario, Cripitografar(goConfiguracaoNFSe.sSenha), goConfiguracaoNFSe.sDominio)
                    End If
                End If

                'Consumindo o WebService
                sRetorno = oServiceGinfesImplService.ConsultarNfseV3(sCabecalho, sDadosNFSe)

                'Finalizando 
                oServiceGinfesImplService.Dispose()

                MsgBox(sRetorno)

            Catch ex As Exception
                Throw ex
            End Try

        End Function

#End Region

    End Class

End Namespace