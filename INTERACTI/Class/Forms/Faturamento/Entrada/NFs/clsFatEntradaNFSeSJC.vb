Imports System.Data
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFatEntradaNFSeSJC

#Region "::: VARIÁVEIS :::"

    Private sCEPTomador As String
    Private sNotaFiscal As String
    Private sData As String
    Private sCompetencia As String
    Private sNumeroRPS As String
    Private sNFSeSubstituida As String
    Private sCNPJPrestador As String
    Private sInscricaoMunicipalPrestador As String
    Private sMunicipioPrestador As String
    Private sEnderecoPrestador As String
    Private sComplementoPrestador As String
    Private sTelefonePrestador As String
    Private sEmailPrestador As String
    Private sRazaoSocialTomador As String
    Private sNomeFantasiaTomador As String
    Private sMunicipioTomador As String
    Private sTelefoneTomador As String
    Private sEmailTomador As String
    Private sInscricaoMunicipal As String
    Private sServico As String
    Private sDiscriminacao As String
    Private sCodigoObra As String
    Private sCodigoArt As String
    Private dValorPIS As Double
    Private dValorCOFINS As Double
    Private dValorIR As Double
    Private dValorINSS As Double
    Private dValorCSLL As Double
    Private dValorServico As Double
    Private dValorDescontoIncondicionado As Double
    Private dValorDescontoCondicionado As Double
    Private dOutrasRetencoes As Double
    Private dValorRetensoesFederais As Double
    Private dValorLiquido As Double
    Private sRegimeEspecialTributacao As String
    Private sSimplesNacional As String
    Private sIncentivadorCultural As String
    Private sRazaoSocialPrestador As String
    Private dISSRetido As Double
    Private sTributacao As String
    Private sCNPJTomador As String
    Private sEnderecoTomador As String
    Private sComplementoTomador As String
    Private sMunicipioServico As String
    Private dDeducoesEmLei As Double
    Private dValorISS As Double
    Private bReterISS As Boolean
    Private dAliquotaISS As Double
    Private dValorBaseCalculo As Double
    Private sUFPrestador As String
    Private sCEPPrestador As String
    Private iCodigoSimplesNacional As String
    Private sUFTomador As String
    Private sCodigoServico As String
    Private sCodigoTributacaoServico As String
    Private sCodigoRegimeEspecial As String
    Private sCodigoIncentivadorCultural As String
    Private sUFServico As String
    Private sCodigoTipoTributacao As String

#End Region

#Region "::: PROPERTIES :::"

    Public ReadOnly Property CEPTomador()
        Get
            Return sCEPTomador
        End Get
    End Property

    Public ReadOnly Property NotaFiscal() As String
        Get
            Return sNotaFiscal
        End Get
    End Property

    Public ReadOnly Property Data() As String
        Get
            Return sData
        End Get
    End Property

    Public ReadOnly Property Competencia() As String
        Get
            Return sCompetencia
        End Get
    End Property

    Public ReadOnly Property NumeroRPS() As String
        Get
            Return sNumeroRPS
        End Get
    End Property

    Public ReadOnly Property NFSeSubstituida() As String
        Get
            Return sNFSeSubstituida
        End Get
    End Property

    Public ReadOnly Property CNPJPrestador() As String
        Get
            Return sCNPJPrestador
        End Get
    End Property

    Public ReadOnly Property InscricaoMunicipalPrestador() As String
        Get
            Return sInscricaoMunicipalPrestador
        End Get
    End Property

    Public ReadOnly Property MunicipioPrestador() As String
        Get
            Return sMunicipioPrestador
        End Get
    End Property

    Public ReadOnly Property EnderecoPrestador() As String
        Get
            Return sEnderecoPrestador
        End Get
    End Property

    Public ReadOnly Property ComplementoPrestador() As String
        Get
            Return sComplementoPrestador
        End Get
    End Property

    Public ReadOnly Property TelefonePrestador() As String
        Get
            Return sTelefonePrestador
        End Get
    End Property

    Public ReadOnly Property EmailPrestador() As String
        Get
            Return sEmailPrestador
        End Get
    End Property

    Public ReadOnly Property RazaoSocialTomador() As String
        Get
            Return sRazaoSocialTomador
        End Get
    End Property

    Public ReadOnly Property NomeFantasiaTomador() As String
        Get
            Return sNomeFantasiaTomador
        End Get
    End Property

    Public ReadOnly Property MunicipioTomador() As String
        Get
            Return sMunicipioTomador
        End Get
    End Property

    Public ReadOnly Property TelefoneTomador() As String
        Get
            Return sTelefoneTomador
        End Get
    End Property

    Public ReadOnly Property EmailTomador() As String
        Get
            Return sEmailTomador
        End Get
    End Property

    Public ReadOnly Property InscricaoMunicipal() As String
        Get
            Return sInscricaoMunicipal
        End Get
    End Property

    Public ReadOnly Property Servico() As String
        Get
            Return sServico
        End Get
    End Property

    Public ReadOnly Property Discriminacao() As String
        Get
            Return sDiscriminacao
        End Get
    End Property

    Public ReadOnly Property CodigoObra() As String
        Get
            Return sCodigoObra
        End Get
    End Property

    Public ReadOnly Property CodigoArt() As String
        Get
            Return sCodigoArt
        End Get
    End Property

    Public ReadOnly Property ValorPIS() As Double
        Get
            Return dValorPIS
        End Get
    End Property

    Public ReadOnly Property ValorCOFINS() As Double
        Get
            Return dValorCOFINS
        End Get
    End Property

    Public ReadOnly Property ValorIR() As Double
        Get
            Return dValorIR
        End Get
    End Property

    Public ReadOnly Property ValorINSS() As Double
        Get
            Return dValorINSS
        End Get
    End Property

    Public ReadOnly Property ValorCSLL() As Double
        Get
            Return dValorCSLL
        End Get
    End Property

    Public ReadOnly Property ValorServico() As Double
        Get
            Return dValorServico
        End Get
    End Property

    Public ReadOnly Property ValorDescontoIncondicionado() As Double
        Get
            Return dValorDescontoIncondicionado
        End Get
    End Property

    Public ReadOnly Property ValorDescontoCondicionado() As Double
        Get
            Return dValorDescontoCondicionado
        End Get
    End Property

    Public ReadOnly Property OutrasRetencoes() As Double
        Get
            Return dOutrasRetencoes
        End Get
    End Property

    Public ReadOnly Property ValorRetensoesFederais() As Double
        Get
            Return dValorRetensoesFederais
        End Get
    End Property

    Public ReadOnly Property ValorLiquido() As Double
        Get
            Return dValorLiquido
        End Get
    End Property

    Public ReadOnly Property RegimeEspecialTributacao() As String
        Get
            Return sRegimeEspecialTributacao
        End Get
    End Property

    Public ReadOnly Property SimplesNacional() As String
        Get
            Return sSimplesNacional
        End Get
    End Property

    Public ReadOnly Property IncentivadorCultural() As String
        Get
            Return sIncentivadorCultural
        End Get
    End Property

    Public ReadOnly Property RazaoSocialPrestador() As String
        Get
            Return sRazaoSocialPrestador
        End Get
    End Property

    Public ReadOnly Property ValorISSRetido() As Double
        Get
            Return dISSRetido
        End Get
    End Property

    Public ReadOnly Property Tributacao() As String
        Get
            Return sTributacao
        End Get
    End Property

    Public ReadOnly Property CNPJTomador() As String
        Get
            Return sCNPJTomador
        End Get
    End Property

    Public ReadOnly Property EnderecoTomador() As String
        Get
            Return sEnderecoTomador
        End Get
    End Property

    Public ReadOnly Property ComplementoTomador() As String
        Get
            Return sComplementoTomador
        End Get
    End Property

    Public ReadOnly Property MunicipioServico() As String
        Get
            Return sMunicipioServico
        End Get
    End Property

    Public ReadOnly Property DeducoesEmLei() As Double
        Get
            Return dDeducoesEmLei
        End Get
    End Property

    Public ReadOnly Property ValorISS() As Double
        Get
            Return dValorISS
        End Get
    End Property

    Public ReadOnly Property ReterISS() As Boolean
        Get
            Return bReterISS
        End Get
    End Property

    Public ReadOnly Property AliquotaISS() As Double
        Get
            Return dAliquotaISS
        End Get
    End Property

    Public ReadOnly Property ValorBaseCalculo() As Double
        Get
            Return dValorBaseCalculo
        End Get
    End Property

    Public ReadOnly Property UFPrestador() As String
        Get
            Return sUFPrestador
        End Get
    End Property
    Public ReadOnly Property CEPPrestador() As String
        Get
            Return sCEPPrestador
        End Get
    End Property

    Public ReadOnly Property CodigoSimplesNacional() As String
        Get
            Return iCodigoSimplesNacional
        End Get
    End Property
    Public ReadOnly Property UFTomador() As String
        Get
            Return sUFTomador
        End Get
    End Property
    Public ReadOnly Property CodigoServico() As String
        Get
            Return sCodigoServico
        End Get
    End Property
    Public ReadOnly Property CodigoTributacaoServico() As String
        Get
            Return sCodigoTributacaoServico
        End Get
    End Property
    Public ReadOnly Property CodigoRegimeEspecial() As String
        Get
            Return sCodigoRegimeEspecial
        End Get
    End Property
    Public ReadOnly Property CodigoIncentivadorCultural() As String
        Get
            Return sCodigoIncentivadorCultural
        End Get
    End Property
    Public ReadOnly Property UFServico() As String
        Get
            Return sUFServico
        End Get
    End Property
    Public ReadOnly Property CodigoTipoTributacao() As String
        Get
            Return sCodigoTipoTributacao
        End Get
    End Property
#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub New(ByVal sCodigoVerificacao As String)

        Try

            'Carrega Dados
            ReceberDadosNFSe(sCodigoVerificacao)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ReceberDadosNFSe(ByVal sCodigoVerificacao As String)

        Dim oStreamReader As System.IO.StreamReader

        Try

            'Váriaveis Locais
            Dim sUrl As String = "http://visualizar.ginfes.com.br/report/consultarNota?__report=nfs_ver4&cdVerificacao=" & sCodigoVerificacao
            Dim sValorAuxiliar As String
            Dim sAux() As String

            'Criando um web request 
            Dim oWebRequest As System.Net.HttpWebRequest = System.Net.WebRequest.Create(sUrl)

            ''Caso tenha Proxy
            'If goConfiguracaoNFe.bHabilitarProxy = True Then
            '    Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
            '    oWebRequest.Proxy = New System.Net.WebProxy(sEndereco, True)
            '    If goConfiguracaoNFe.sDominio.Trim = "" Then
            '        oWebRequest.Proxy.Credentials = New System.Net.NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
            '    Else
            '        oWebRequest.Proxy.Credentials = New System.Net.NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
            '    End If
            'End If

            'Verificando a resposta
            Dim oWebResponse As System.Net.HttpWebResponse = oWebRequest.GetResponse

            'Criando o encode para o stream reader
            Dim oEncode As System.Text.Encoding = System.Text.Encoding.GetEncoding(1252)

            'Criando um StreamReader para ler a resposta
            oStreamReader = New System.IO.StreamReader(oWebResponse.GetResponseStream, oEncode)

            'String para receber o conteudo do reader
            Dim sHTML As String = oStreamReader.ReadToEnd

            'Quebrando a string até achar o valor
            sHTML = Mid(sHTML, InStr(sHTML, "<a name=""JR_PAGE_ANCHOR_0_1""></a>"))
            sHTML = Mid(sHTML, InStr(sHTML, "SECRETARIA DA FAZENDA"))
            sHTML = Replace(sHTML, "<br/>", vbNewLine)
            sHTML = Replace(sHTML, "&nbsp;", " ")

            'Tirando os últimos SPAN´s
            sHTML = Replace(sHTML, "</span>", "")

            'Tirando esses caracteres que podem confundir
            sHTML = Replace(sHTML, "><", "")

            'Agora, buscar sempre pelo caracter ">"

            'Número da Nota fiscal
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sNotaFiscal = RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1))

            'Data
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sData = RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1))

            'Competência
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sCompetencia = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Código Verificação (Não precisa buscar)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)

            'Número RPS (Se houver)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sNumeroRPS = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'NFS-e Substituída (Se houver)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sNFSeSubstituida = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'CNPJ Prestador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sCNPJPrestador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'IM Prestador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sInscricaoMunicipalPrestador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Município e UF da Prestação do Prestador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sAux = Split((RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1))), "-")
            sMunicipioPrestador = sAux(0)
            sUFPrestador = sAux(1)

            'Endereço Completo
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sAux = Split(RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)), "CEP:")
            sEnderecoPrestador = sAux(0)
            sCEPPrestador = sAux(1)

            'Complemento (Se houver)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sComplementoPrestador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Telefone (Se houver)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sTelefonePrestador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'E-mail (Se houver)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sEmailPrestador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Razão Social Tomador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sRazaoSocialTomador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Nome Fantasia (Se houver) do Tomador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sNomeFantasiaTomador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Município e UF do Tomador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sAux = Split((RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1))), "-")
            sMunicipioTomador = sAux(0)
            sUFTomador = sAux(1)

            'Telefone Tomador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sTelefoneTomador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Email Tomador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sEmailTomador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Inscrição Municipal Tomador (VERIFICAR)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sInscricaoMunicipal = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Chegando na DIV de baixo
            sHTML = Mid(sHTML, InStr(sHTML, "</div>") + 6)
            'Chegando na próxima DIV 
            sHTML = Mid(sHTML, InStr(sHTML, "</div>") + 7)

            'Serviço
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sServico = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            sAux = Split(sServico, "/")
            sCodigoServico = sAux(0)
            sCodigoTributacaoServico = Mid(sAux(1), 2, 8)

            'Discriminacao
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sDiscriminacao = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Retirado e inserido para pegar a CSLL - cleyton 04/11/2015
            ''Código da Obra ( Se Houver)
            'sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            'sCodigoObra = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'CSLL
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorCSLL = sValorAuxiliar
            Else
                dValorCSLL = 0
            End If

            'Código Art ( Se Houver)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sCodigoArt = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'PIS
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorPIS = sValorAuxiliar
            Else
                dValorPIS = 0
            End If

            'COFINS
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorCOFINS = sValorAuxiliar
            Else
                dValorCOFINS = 0
            End If

            'IR
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorIR = sValorAuxiliar
            Else
                dValorIR = 0
            End If

            'INSS
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorINSS = sValorAuxiliar
            Else
                dValorINSS = 0
            End If

            'Este imposto está sendo setado acima.
            'CSLL
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            'If IsNumeric(sValorAuxiliar) Then
            '    dValorCSLL = sValorAuxiliar
            'Else
            '    dValorCSLL = 0
            'End If

            'Valor Serviço
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            dValorServico = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Desconto Incondicionado
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorDescontoIncondicionado = sValorAuxiliar
            Else
                dValorDescontoIncondicionado = 0
            End If

            'Desconto Condicionado
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorDescontoCondicionado = sValorAuxiliar
            Else
                dValorDescontoCondicionado = 0
            End If

            'IR 
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorRetensoesFederais = sValorAuxiliar
            Else
                dValorRetensoesFederais = 0
            End If

            'Outras Retenções
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dOutrasRetencoes = sValorAuxiliar
            Else
                dOutrasRetencoes = 0
            End If

            'Valor Líquido
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorLiquido = sValorAuxiliar
            Else
                dValorLiquido = 0
            End If

            'Regime Especial Tributação
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sAux = Split(RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)), "-")
            sCodigoRegimeEspecial = sAux(0)
            sRegimeEspecialTributacao = sAux(1)

            'Simples Nacional
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sAux = Split(RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)), "-")
            iCodigoSimplesNacional = sAux(0)
            sSimplesNacional = sAux(1)

            'Incentivador Cultural
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sAux = Split(RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)), "-")
            sCodigoIncentivadorCultural = sAux(0)
            sIncentivadorCultural = sAux(1)

            'Razão Social Prestador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sRazaoSocialPrestador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'ISS RETIDO (VERIFICAR)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dISSRetido = sValorAuxiliar
            Else
                dISSRetido = 0
            End If

            'Natureza de operação (Não interessa)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)

            'Tributação
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sAux = Split(RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)), "-")
            sTributacao = sAux(1)
            sCodigoTipoTributacao = sAux(0)

            'CNPJ tomador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sCNPJTomador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Endereço Tomador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sAux = Split((RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1))), "CEP:")
            sEnderecoTomador = sAux(0)
            sCEPTomador = sAux(1)

            'Complemento Tomador
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sComplementoTomador = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Local Prestação (LABEL)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)

            'Local Prestação Servico
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sAux = Split(RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)), "-")
            sMunicipioServico = sAux(0)
            sUFServico = sAux(1)

            'Baixando mais uma DIV
            sHTML = Mid(sHTML, InStr(sHTML, "</div>") + 7)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)

            'Deduções em Lei
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dDeducoesEmLei = sValorAuxiliar
            Else
                dDeducoesEmLei = 0
            End If

            'Valor iSS
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorISS = sValorAuxiliar
            Else
                dValorISS = 0
            End If

            'Reter ISS
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            If InStr(sValorAuxiliar, "X") = 10 Then
                bReterISS = False
            Else
                bReterISS = True
            End If

            'Desconto Incondicionado2 (É o mesmo do anterior)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)

            'Aliquota ISS
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dAliquotaISS = sValorAuxiliar
            Else
                dAliquotaISS = 0
            End If

            'Valor dos Serviços 2 (É o mesmo do anterior
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)

            'Valor Base Calculo
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorBaseCalculo = sValorAuxiliar
            Else
                dValorBaseCalculo = 0
            End If

            'Fechando o stream reader
            oStreamReader.Close()

        Catch ex As Exception
            'Fechando o stream reader
            oStreamReader.Close()
            Throw ex
        End Try

    End Sub

#End Region

End Class
