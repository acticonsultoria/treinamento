Imports System.IO
Imports System.Xml
Imports INTERACTI.NFSE
'Imports INTERACTI.NFSE.CancelarNFSe
'Imports INTERACTI.NFSE.RetCancelarNFSe
Imports INTERACTI.NFSE.GERAL
Imports INTERACTI.NFSE.ValidaXML
Imports INTERACTI.NFSE.WebService

Public Class clsNFSE_CancelarNFSe

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe - ReadOnly
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String
    Private iStatus As Integer
    Private sMotivo As String
    Private sCodigoVerificacao As String
    Private iNumero As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public ReadOnly Property ArquivoEnvio() As String
        Get
            Return sArquivoEnvio
        End Get
    End Property

    Public ReadOnly Property ArquivoRetorno() As String
        Get
            Return sArquivoRetorno
        End Get
    End Property

    Public ReadOnly Property MensagemErro() As String
        Get
            Return sMensagemErro
        End Get
    End Property

    Public ReadOnly Property Status() As Integer
        Get
            Return iStatus
        End Get
    End Property

    Public ReadOnly Property Motivo() As String
        Get
            Return sMotivo
        End Get
    End Property

    Public Property CodigoVerificacao() As String
        Get
            Return sCodigoVerificacao
        End Get
        Set(ByVal value As String)
            sCodigoVerificacao = value
        End Set
    End Property

    Public Property Numero() As Integer
        Get
            Return iNumero
        End Get
        Set(ByVal value As Integer)
            iNumero = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    'Public Function Send() As Boolean

    '    'Váriaveis Locais
    '    Dim sRetornoWS As String
    '    Dim oTCancelarNFSe As New CancelarNfseEnvio

    '    Try

    '        Dim oInfRPS As New NFSE.CancelarNFSe.tcIdentificacaoNfse

    '        oInfRPS.Cnpj = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")
    '        oInfRPS.CodigoMunicipio = goEmitente.iMunicipio
    '        oInfRPS.InscricaoMunicipal = goEmitente.sInscricaoMunicipal
    '        oInfRPS.Numero = iNumero

    '        Dim oPedido As New NFSE.CancelarNFSe.tcPedidoCancelamento
    '        Dim oPedidoCancelamento As New NFSE.CancelarNFSe.tcInfPedidoCancelamento

    '        oPedido.InfPedidoCancelamento = oPedidoCancelamento

    '        oPedido.InfPedidoCancelamento.IdentificacaoNfse = oInfRPS
    '        oTCancelarNFSe.Pedido = oPedido

    '        'Seta Arquivo
    '        sArquivoEnvio = goConfiguracaoNFSe.sPastaEnvio & sCodigoVerificacao & "-ped-situacao-nfse.xml"

    '        'Salva Pedido de Status do Serviço Temporariamente
    '        oTCancelarNFSe.Save(sArquivoEnvio)


    '        Dim oXmlDocument As New Xml.XmlDocument
    '        oXmlDocument = NFSE.AssinaturaDigital.AssinarXML(sArquivoEnvio, "")
    '        oXmlDocument.Save(sArquivoEnvio)

    '        'Valida Arquivo XML Assinado
    '        Dim sRetornoValidacao As String = ""

    '        'Verifica se Encontrou algum Erro no Arquivo XML
    '        sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
    '                                             goConfiguracaoNFSe.sPastaXSD & "servico_cancelar_nfse_envio_v03.xsd", _
    '                                             "servico_cancelar_nfse_envio_v03.xsd")

    '        'Verifica se ocorreu algum erro na Validação
    '        If sRetornoValidacao <> "" Then

    '            'Exclui Arquivo XML (Status)
    '            File.Delete(sArquivoEnvio)
    '            'Seta Informação
    '            sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
    '            'Retorno da Função
    '            Return False

    '        Else

    '            Try
    '                'Executa Serviço (SÍNCRONO)
    '                If goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.homologacao Then
    '                    sRetornoWS = WS_CancelarNFSe_V2Homologacao(sArquivoEnvio)
    '                ElseIf goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.producao Then
    '                    sRetornoWS = WS_CancelarNFSe_V2Producao(sArquivoEnvio)
    '                End If
    '            Catch ex As Exception
    '                'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
    '                File.Delete(sArquivoEnvio)
    '                File.Delete(goConfiguracaoNFSe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")
    '                'Seta Informação
    '                sMensagemErro = ex.Message
    '                'Retorno da Função
    '                Return False
    '            End Try

    '            'Seta Arquivo de Retorno
    '            sArquivoRetorno = goConfiguracaoNFSe.sPastaEnvio & sCodigoVerificacao & "-ret-situacao-nf.xml"

    '            'Recebe Arquivo de Retorno do WebService
    '            Dim oStreamWriter As StreamWriter = File.CreateText(sArquivoRetorno)
    '            oStreamWriter.Write(sRetornoWS)
    '            oStreamWriter.Close()

    '            'Exclui Cabeçalho
    '            File.Delete(goConfiguracaoNFSe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")

    '        End If

    '        'Seta Retorno da Função
    '        Return True

    '    Catch ex As Exception
    '        Return False
    '    End Try

    'End Function

    'Public Function Send_V2() As Boolean

    '    'Váriaveis Locais
    '    Dim sRetornoWS As String
    '    Dim oTCancelarNFSe As New NFSE.CancelarNFSe_V2.CancelarNfseEnvio

    '    Try

    '        Dim oInfPrestador As New NFSE.CancelarNFSe_V2.tcIdentificacaoPrestador
    '        oInfPrestador.Cnpj = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")
    '        oInfPrestador.InscricaoMunicipal = goEmitente.sInscricaoMunicipal
    '        oTCancelarNFSe.Prestador = oInfPrestador
    '        oTCancelarNFSe.NumeroNfse = iNumero

    '        'Seta Arquivo
    '        sArquivoEnvio = goConfiguracaoNFSe.sPastaEnvio & sCodigoVerificacao & "-ped-situacao-nfse.xml"

    '        'Salva Pedido de Status do Serviço Temporariamente
    '        oTCancelarNFSe.Save(sArquivoEnvio)

    '        Dim oXmlDocument As New Xml.XmlDocument
    '        oXmlDocument = NFSE.AssinaturaDigital.AssinarXML(sArquivoEnvio, "")
    '        oXmlDocument.Save(sArquivoEnvio)

    '        'Valida Arquivo XML Assinado
    '        Dim sRetornoValidacao As String = ""

    '        'Verifica se Encontrou algum Erro no Arquivo XML
    '        sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
    '                                             goConfiguracaoNFSe.sPastaXSD & "servico_cancelar_nfse_envio_v03.xsd", _
    '                                             "servico_cancelar_nfse_envio_v03.xsd")

    '        'Verifica se ocorreu algum erro na Validação
    '        If sRetornoValidacao <> "" Then

    '            'Exclui Arquivo XML (Status)
    '            File.Delete(sArquivoEnvio)
    '            'Seta Informação
    '            sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
    '            'Retorno da Função
    '            Return False

    '        Else

    '            Try
    '                'Executa Serviço (SÍNCRONO)
    '                If goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.homologacao Then
    '                    sRetornoWS = WS_CancelarNFSe_V2Homologacao(sArquivoEnvio)
    '                ElseIf goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.producao Then
    '                    sRetornoWS = WS_CancelarNFSe_V2Producao(sArquivoEnvio)
    '                End If
    '            Catch ex As Exception
    '                'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
    '                File.Delete(sArquivoEnvio)
    '                File.Delete(goConfiguracaoNFSe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")
    '                'Seta Informação
    '                sMensagemErro = ex.Message
    '                'Retorno da Função
    '                Return False
    '            End Try

    '            'Seta Arquivo de Retorno
    '            sArquivoRetorno = goConfiguracaoNFSe.sPastaEnvio & sCodigoVerificacao & "-ret-situacao-nf.xml"

    '            'Recebe Arquivo de Retorno do WebService
    '            Dim oStreamWriter As StreamWriter = File.CreateText(sArquivoRetorno)
    '            oStreamWriter.Write(sRetornoWS)
    '            oStreamWriter.Close()

    '            'Exclui Cabeçalho
    '            File.Delete(goConfiguracaoNFSe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")

    '        End If

    '        'Seta Retorno da Função
    '        Return True

    '    Catch ex As Exception
    '        Return False
    '    End Try

    'End Function

    Public Function Send_ABRASF() As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTCancelarNFSe As New NFSE.GERAL.CancelarNfseEnvio

        Try

            oTCancelarNFSe.Pedido = New tcPedidoCancelamento
            oTCancelarNFSe.Pedido.InfPedidoCancelamento = New tcInfPedidoCancelamento
            oTCancelarNFSe.Pedido.InfPedidoCancelamento.IdentificacaoNfse = New tcIdentificacaoNfse


            oTCancelarNFSe.Pedido.InfPedidoCancelamento.IdentificacaoNfse.Cnpj = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")
            oTCancelarNFSe.Pedido.InfPedidoCancelamento.IdentificacaoNfse.InscricaoMunicipal = goEmitente.sInscricaoMunicipal
            oTCancelarNFSe.Pedido.InfPedidoCancelamento.IdentificacaoNfse.Numero = iNumero



            'Seta Arquivo
            sArquivoEnvio = goConfiguracaoNFSe.sPastaEnvio & sCodigoVerificacao & "-ped-situacao-nfse.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTCancelarNFSe.Save(sArquivoEnvio)

            Dim oXmlDocument As New Xml.XmlDocument
            oXmlDocument = NFSE.AssinaturaDigital.AssinarXML(sArquivoEnvio, "")
            oXmlDocument.Save(sArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""


            ''Verifica se Encontrou algum Erro no Arquivo XML
            'sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
            '                                     goConfiguracaoNFSe.sPastaXSD & "nfse.xsd", _
            '                                         "nfse.xsd")


            'Verifica se Encontrou algum Erro no Arquivo XML
            'sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
            '                                     goConfiguracaoNFSe.sPastaXSD & "servico_consultar_nfse_rps_envio_v03.xsd", _
            '                                     "servico_consultar_nfse_rps_envio_v03.xsd")


            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Status)
                File.Delete(sArquivoEnvio)
                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                Try
                    'Executa Serviço (SÍNCRONO)
                    If goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.homologacao Then
                        sRetornoWS = WS_CancelarNFSe_V2Homologacao(sArquivoEnvio)
                    ElseIf goConfiguracaoNFSe.iCodigoTipoAmbienteNFSe = TipoAmbienteNFe.producao Then
                        sRetornoWS = WS_CancelarNFSe_V2Producao(sArquivoEnvio)
                    End If
                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(sArquivoEnvio)
                    File.Delete(goConfiguracaoNFSe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sArquivoRetorno = goConfiguracaoNFSe.sPastaEnvio & sCodigoVerificacao & "-ret-situacao-nf.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sArquivoRetorno)
                oStreamWriter.Write(sRetornoWS)
                oStreamWriter.Close()

                'Exclui Cabeçalho
                File.Delete(goConfiguracaoNFSe.sPastaEnvio & "cabecConsultaSituacaoNF.xml")

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub LoadArquivo(ByVal sArquivo As String)

        Try

            'Váriaveis Locais
            Dim oTRetCancelarNFSe As New CancelarNfseResposta

            'Carrega arquivo de Retorno
            oTRetCancelarNFSe = oTRetCancelarNFSe.Load(sArquivo)

            'Limpa Váriaveis
            oTRetCancelarNFSe = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
