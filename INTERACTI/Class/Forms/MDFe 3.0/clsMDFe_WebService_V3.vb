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
Imports INTERACTI.MDFe.CertificadoDigital

Namespace MDFe

    Public NotInheritable Class WebService



        Public Overloads Shared Function WSStatusServico(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sDados = oStreamReader.ReadToEnd
            oStreamReader.Close()

            'Try

            '    'Váriaveis Locais
            '    Dim oWebservice As New br.gov.fazenda.MDFeStatusServico.MDFeStatusServicoSoap12Client
            '    Dim oCabecalho As New br.gov.fazenda.MDFeStatusServico.mdfeCabecMsg


            '    'Setando o cabeçalho
            '    oCabecalho.cUF = goConfiguracaoNFe.sCodigoEstado
            '    oCabecalho.versaoDados = "1.00"


            '    'Adiciona Certificado
            '    oWebservice.ClientCredentials.ClientCertificate.Certificate = oCertificado


            '    Dim oXmlDocument As New XmlDocument
            '    oXmlDocument.LoadXml(sDados)

            '    sRetorno = oWebservice.mdfeStatusServicoMDF(oCabecalho, oXmlDocument).OuterXml

            '    Return sRetorno

            'Catch ex As Exception
            '    Throw ex
            'End Try

        End Function

        Public Overloads Shared Function WSRecepcao(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sDados = oStreamReader.ReadToEnd
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                Dim oWebservice As New br.gov.rs.svrs.mdfe.Recepcao.MDFeRecepcao
                Dim oCabecalho As New br.gov.rs.svrs.mdfe.Recepcao.mdfeCabecMsg

                
                'Setando o cabeçalho
                oCabecalho.cUF = goConfiguracaoMDFe.sCodigoEstado
                oCabecalho.versaoDados = "3.00"
                oWebservice.mdfeCabecMsgValue = oCabecalho

                'Seta a url
                oWebservice.Url = LoadURLMDFe(WebServiceMDFe.Recepcao)
                

                'Adiciona Certificado
                oWebservice.ClientCertificates.Add(oCertificado)

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sDados)

                sRetorno = oWebservice.mdfeRecepcaoLote(oXmlDocument).OuterXml

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSRetRecepcaoLote(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sDados = oStreamReader.ReadToEnd
            oStreamReader.Close()


            sDados = Replace(sDados, " xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", "")

            Try

                'Váriaveis Locais
                Dim oWebservice As New br.gov.rs.svrs.mdfe.RetRecepcao.MDFeRetRecepcao
                Dim oCabecalho As New br.gov.rs.svrs.mdfe.RetRecepcao.mdfeCabecMsg


                'Setando o cabeçalho
                oCabecalho.cUF = goConfiguracaoMDFe.sCodigoEstado
                oCabecalho.versaoDados = "3.00"
                oWebservice.mdfeCabecMsgValue = oCabecalho

                'Seta a url
                oWebservice.Url = LoadURLMDFe(WebServiceMDFe.RetRecepcao)


                'Adiciona Certificado
                oWebservice.ClientCertificates.Add(oCertificado)

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sDados)

                sRetorno = oWebservice.mdfeRetRecepcao(oXmlDocument).OuterXml

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSEvento(ByVal sMensagem As String) As String

            
            'Váriaveis Locais
            Dim sDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sDados = oStreamReader.ReadToEnd
            oStreamReader.Close()

            Try

                'Váriaveis Locais
                Dim oWebservice As New br.gov.rs.svrs.mdfe.Evento.MDFeRecepcaoEvento
                Dim oCabecalho As New br.gov.rs.svrs.mdfe.Evento.mdfeCabecMsg


                'Setando o cabeçalho
                oCabecalho.cUF = goConfiguracaoMDFe.sCodigoEstado
                oCabecalho.versaoDados = "3.00"
                oWebservice.mdfeCabecMsgValue = oCabecalho

                'Seta a url
                oWebservice.Url = LoadURLMDFe(WebServiceMDFe.Evento)


                'Adiciona Certificado
                oWebservice.ClientCertificates.Add(oCertificado)

                Dim oXmlDocument As New XmlDocument
                oXmlDocument.LoadXml(sDados)

                sRetorno = oWebservice.mdfeRecepcaoEvento(oXmlDocument).OuterXml

                Return sRetorno

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Public Overloads Shared Function WSConsulta(ByVal sMensagem As String) As String

            'Váriaveis Locais
            Dim sDados As String
            Dim sRetorno As String = ""
            Dim oStreamReader As StreamReader

            'Busca o Certificado no Repositorio do Vindows
            Dim oCertificado As New X509Certificate2

            'Obtem Certificado
            oCertificado = GetCertificado(LoadCertificado)

            oStreamReader = File.OpenText(sMensagem)
            sDados = oStreamReader.ReadToEnd
            oStreamReader.Close()

            'Try

            '    'Váriaveis Locais
            '    Dim oWebservice As New br.gov.fazenda.MDFeConsulta.MDFeConsultaSoap12Client
            '    Dim oCabecalho As New br.gov.fazenda.MDFeConsulta.mdfeCabecMsg


            '    'Setando o cabeçalho
            '    oCabecalho.cUF = goConfiguracaoNFe.sCodigoEstado
            '    oCabecalho.versaoDados = "1.00"


            '    'Adiciona Certificado
            '    oWebservice.ClientCredentials.ClientCertificate.Certificate = oCertificado


            '    Dim oXmlDocument As New XmlDocument
            '    oXmlDocument.LoadXml(sDados)

            '    sRetorno = oWebservice.mdfeConsultaMDF(oCabecalho, oXmlDocument).OuterXml

            '    Return sRetorno

            'Catch ex As Exception
            '    Throw ex
            'End Try

        End Function

      


    End Class

End Namespace