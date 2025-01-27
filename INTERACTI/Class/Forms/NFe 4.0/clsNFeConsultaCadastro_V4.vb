Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.ConsultaCadastro_V2
Imports INTERACTI.NFe.RetConsultaCadastro_V2
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V4


Public Class clsNFeConsultaCadastro_V4

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe - ReadOnly
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sMensagemErro As String
    Private sCNPJConsulta As String
    Private sUFConsulta As String
    Private iCodigoIBGEUFConsulta As Integer
    Private iTipoConsulta As Integer

    Private sNomeFantasia As String
    Private sUF As String
    Private sIE As String
    Private sSituacao As String
    Private sSituacaoNFe As String
    Private sRazaoSocial As String
    Private sCNAE As String
    Private sLogradouro As String
    Private sNumero As String
    Private sBairro As String
    Private sMunicipio As String
    Private sCEP As String
    Private sComplemento As String
    Private sDataInicioAtividade As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CNPJConsulta() As String
        Get
            Return sCNPJConsulta
        End Get
        Set(ByVal value As String)
            sCNPJConsulta = value
        End Set
    End Property

    Public Property UFConsulta() As String
        Get
            Return sUFConsulta
        End Get
        Set(ByVal value As String)
            sUFConsulta = value
        End Set
    End Property

    Public Property CodigoIBGEUFConsulta() As Integer
        Get
            Return iCodigoIBGEUFConsulta
        End Get
        Set(ByVal value As Integer)
            iCodigoIBGEUFConsulta = value
        End Set
    End Property

    Public Property NomeFantasia() As String
        Get
            Return sNomeFantasia
        End Get
        Set(ByVal value As String)
            sNomeFantasia = value
        End Set
    End Property

    Public Property Complemento() As String
        Get
            Return sComplemento
        End Get
        Set(ByVal value As String)
            sComplemento = value
        End Set
    End Property

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

    Public Property TipoConsulta() As Integer
        Get
            Return iTipoConsulta
        End Get
        Set(ByVal value As Integer)
            iTipoConsulta = value
        End Set
    End Property

    Public Property UF() As String
        Get
            Return sUF
        End Get
        Set(ByVal value As String)
            sUF = value
        End Set
    End Property

    Public Property IE() As String
        Get
            Return sIE
        End Get
        Set(ByVal value As String)
            sIE = value
        End Set
    End Property

    Public Property Situacao() As String
        Get
            Return sSituacao
        End Get
        Set(ByVal value As String)
            sSituacao = value
        End Set
    End Property

    Public Property SituacaoNFe() As String
        Get
            Return sSituacaoNFe
        End Get
        Set(ByVal value As String)
            sSituacaoNFe = value
        End Set
    End Property

    Public Property RazaoSocial() As String
        Get
            Return sRazaoSocial
        End Get
        Set(ByVal value As String)
            sRazaoSocial = value
        End Set
    End Property

    Public Property CNAE() As String
        Get
            Return sCNAE
        End Get
        Set(ByVal value As String)
            sCNAE = value
        End Set
    End Property

    Public Property Logradouro() As String
        Get
            Return sLogradouro
        End Get
        Set(ByVal value As String)
            sLogradouro = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return sNumero
        End Get
        Set(ByVal value As String)
            sNumero = value
        End Set
    End Property

    Public Property Bairro() As String
        Get
            Return sBairro
        End Get
        Set(ByVal value As String)
            sBairro = value
        End Set
    End Property

    Public Property Municipio() As String
        Get
            Return sMunicipio
        End Get
        Set(ByVal value As String)
            sMunicipio = value
        End Set
    End Property

    Public Property CEP() As String
        Get
            Return sCEP
        End Get
        Set(ByVal value As String)
            sCEP = value
        End Set
    End Property

    Public Property DataInicioAtividade() As String
        Get
            Return sDataInicioAtividade
        End Get
        Set(ByVal value As String)
            sDataInicioAtividade = value
        End Set
    End Property
#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send() As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsStatServ As New TConsCad

        Try

            'Informação do Status do Serviço
            oTConsStatServ.versao = "2.00"

            Dim oTConsCadInfCons As New TConsCadInfCons
            oTConsCadInfCons.Item = Replace(Replace(Replace(sCNPJConsulta, ".", ""), "/", ""), "-", "")
            oTConsCadInfCons.UF = DefineUF(sUFConsulta)
            oTConsCadInfCons.ItemElementName = ConsultaCadastro_V2.ItemChoiceType.CNPJ
            oTConsCadInfCons.xServ = TConsCadInfConsXServ.CONSCAD

            'Passando o parâmetro
            oTConsStatServ.infCons = oTConsCadInfCons

            'Seta Arquivo
            sArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & "ConsultaCad-" & Format(Now, "yyyyMMdd-HHmmss") & "-ped-cadastro.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsStatServ.Save(sArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "consCad_v2.00.xsd")

            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Status)
                File.Delete(sArquivoEnvio)

                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                'Obtem Tamanho do Arquivo XML
                Dim oFileInfo As New FileInfo(sArquivoEnvio)

                'Verifica se o Tamanho do Arquivo XML é maior que o Tamanho Máximo
                If (oFileInfo.Length / 1000) > goConfiguracaoNFe.iTamanhoMaximo Then
                    'Exclui Arquivo XML (Status)
                    File.Delete(sArquivoEnvio)
                    'Seta Informação
                    sMensagemErro = "O Tamanho do Arquivo (" & oFileInfo.Length & "KB) é maior que o tamanho configurado."
                    'Retorno da Função
                    Return False
                End If


                Try

                    'Executa Serviço (SÍNCRONO)
                    sRetornoWS = WSConsultaCadastro_V2(sArquivoEnvio, _
                                                       sUFConsulta, _
                                                       iCodigoIBGEUFConsulta)

                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(sArquivoEnvio)
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & "ConsultaCad-" & Format(Now, "yyyyMMdd-HHmmss") & "-ret-cadastro.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sArquivoRetorno)
                oStreamWriter.Write(sRetornoWS)
                oStreamWriter.Close()

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function LoadArquivo(ByVal sArquivo As String) As Boolean

        'Váriaveis Locais
        Dim oTRetConsCad As New TRetConsCad

        Try

            'Carrega arquivo de Retorno
            oTRetConsCad = TRetConsCad.Load(sArquivo)

            If oTRetConsCad.infCons.cStat = "111" Then

                'Seta Váriaveis
                sIE = oTRetConsCad.infCons.infCad(0).IE
                Select Case oTRetConsCad.infCons.infCad(0).cSit
                    Case TRetConsCadInfConsInfCadCSit.Item0 : sSituacao = "Não Habilitado"
                    Case TRetConsCadInfConsInfCadCSit.Item1 : sSituacao = "Habilitado"
                End Select

                Select Case oTRetConsCad.infCons.infCad(0).indCredNFe
                    Case TRetConsCadInfConsInfCadIndCredNFe.Item0 : sSituacaoNFe = "Não credenciado para emissão da NF-e"
                    Case TRetConsCadInfConsInfCadIndCredNFe.Item1 : sSituacaoNFe = "Credenciado"
                    Case TRetConsCadInfConsInfCadIndCredNFe.Item2 : sSituacaoNFe = "Credenciado com obrigatoriedade para todas operações"
                    Case TRetConsCadInfConsInfCadIndCredNFe.Item3 : sSituacaoNFe = "Credenciado com obrigatoriedade parcial"
                    Case TRetConsCadInfConsInfCadIndCredNFe.Item4 : sSituacaoNFe = "A SEFAZ não fornece a informação"
                End Select
                sRazaoSocial = oTRetConsCad.infCons.infCad(0).xNome
                sNomeFantasia = oTRetConsCad.infCons.infCad(0).xFant
                sCNAE = oTRetConsCad.infCons.infCad(0).CNAE
                sLogradouro = oTRetConsCad.infCons.infCad(0).ender.xLgr
                sNumero = oTRetConsCad.infCons.infCad(0).ender.nro
                sBairro = oTRetConsCad.infCons.infCad(0).ender.xBairro
                sMunicipio = oTRetConsCad.infCons.infCad(0).ender.xMun
                sCEP = oTRetConsCad.infCons.infCad(0).ender.CEP
                sDataInicioAtividade = oTRetConsCad.infCons.infCad(0).dIniAtiv
                sComplemento = oTRetConsCad.infCons.infCad(0).ender.xCpl

                'Limpa Váriaveis
                oTRetConsCad = Nothing
                'Seta Retorno da Função
                Return True

            Else

                'Seta Mensagem de Erro
                sMensagemErro = HTMLtoText(oTRetConsCad.infCons.xMotivo)
                'Limpa Váriaveis
                oTRetConsCad = Nothing
                'Seta Retorno da Função
                Return False

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
