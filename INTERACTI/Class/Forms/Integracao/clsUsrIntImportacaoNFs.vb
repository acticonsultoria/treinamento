Imports System.IO
Imports System.IO.File
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrIntImportacaoNFs

#Region "::: VARIAVEIS :::"

    Private sUFTomador As String
    Private sUFServico As String
    Private sUFPrestador As String
    Private sTributacao As String
    Private sTelefoneTomador As String
    Private sTelefonePrestador As String
    Private sSimplesNacional As String
    Private sServico As String
    Private sRegimeEspecialTributacao As String
    Private sRazaoSocialTomador As String
    Private sRazaoSocialPrestador As String
    Private sNumeroRPS As String
    Private sNotaFiscal As String
    Private sNomeFantasiaTomador As String
    Private sNFSeSubstituida As String
    Private sMunicipioTomador As String
    Private sMunicipioServico As String
    Private sMunicipioPrestador As String
    Private sInscricaoMunicipalPrestador As String
    Private sInscricaoMunicipal As String
    Private sIncentivadorCultural As String
    Private sEnderecoTomador As String
    Private sEnderecoPrestador As String
    Private sEmailTomador As String
    Private sEmailPrestador As String
    Private sDiscriminacao As String
    Private sData As String
    Private sComplementoTomador As String
    Private sComplementoPrestador As String
    Private sCompetencia As String
    Private sCodigoTributacaoServico As String
    Private sCodigoTipoTributacao As String
    Private sCodigoServico As String
    Private sCodigoAtividade As String
    Private sCodigoRegimeEspecial As String
    Private sCodigoObra As String
    Private sCodigoIncentivadorCultural As String
    Private sCodigoArt As String
    Private sCNPJTomador As String
    Private sCNPJPrestador As String
    Private sCEPTomador As String
    Private sCEPPrestador As String
    Private dValorServico As Double
    Private iCodigoSimplesNacional As Integer
    Private dValorRetensoesFederais As Double
    Private dValorPIS As Double
    Private dValorLiquido As Double
    Private dValorISS As Double
    Private dValorIR As Double
    Private dValorINSS As Double
    Private dValorDescontoIncondicionado As Double
    Private dValorDescontoCondicionado As Double
    Private dValorCSLL As Double
    Private dValorCOFINS As Double
    Private dValorBaseCalculo As Double
    Private dOutrasRetencoes As Double
    Private dISSRetido As Double
    Private dDeducoesEmLei As Double
    Private dAliquotaISS As Double
    Private bReterISS As Boolean

#End Region

#Region "::: PROPERTIE :::"

    Public Property UFTomador() As String
        Get
            Return sUFTomador
        End Get
        Set(ByVal value As String)
            sUFTomador = value
        End Set
    End Property

    Public Property UFServico() As String
        Get
            Return sUFServico
        End Get
        Set(ByVal value As String)
            sUFServico = value
        End Set
    End Property

    Public Property UFPrestador() As String
        Get
            Return sUFPrestador
        End Get
        Set(ByVal value As String)
            sUFPrestador = value
        End Set
    End Property

    Public Property Tributacao() As String
        Get
            Return sTributacao
        End Get
        Set(ByVal value As String)
            sTributacao = value
        End Set
    End Property

    Public Property TelefoneTomador() As String
        Get
            Return sTelefoneTomador
        End Get
        Set(ByVal value As String)
            sTelefoneTomador = value
        End Set
    End Property

    Public Property TelefonePrestador() As String
        Get
            Return sTelefonePrestador
        End Get
        Set(ByVal value As String)
            sTelefonePrestador = value
        End Set
    End Property

    Public Property SimplesNacional() As String
        Get
            Return sSimplesNacional
        End Get
        Set(ByVal value As String)
            sSimplesNacional = value
        End Set
    End Property

    Public Property Servico() As String
        Get
            Return sServico
        End Get
        Set(ByVal value As String)
            sServico = value
        End Set
    End Property

    Public Property RegimeEspecialTributacao() As String
        Get
            Return sRegimeEspecialTributacao
        End Get
        Set(ByVal value As String)
            sRegimeEspecialTributacao = value
        End Set
    End Property

    Public Property RazaoSocialTomador() As String
        Get
            Return sRazaoSocialTomador
        End Get
        Set(ByVal value As String)
            sRazaoSocialTomador = value
        End Set
    End Property

    Public Property NumeroRPS() As String
        Get
            Return sNumeroRPS
        End Get
        Set(ByVal value As String)
            sNumeroRPS = value
        End Set
    End Property

    Public Property NotaFiscal() As String
        Get
            Return sNotaFiscal
        End Get
        Set(ByVal value As String)
            sNotaFiscal = value
        End Set
    End Property

    Public Property NomeFantasiaTomador() As String
        Get
            Return sNomeFantasiaTomador
        End Get
        Set(ByVal value As String)
            sNomeFantasiaTomador = value
        End Set
    End Property

    Public Property NFSeSubstituida() As String
        Get
            Return sNFSeSubstituida
        End Get
        Set(ByVal value As String)
            sNFSeSubstituida = value
        End Set
    End Property

    Public Property MunicipioTomador() As String
        Get
            Return sMunicipioTomador
        End Get
        Set(ByVal value As String)
            sMunicipioTomador = value
        End Set
    End Property

    Public Property MunicipioServico() As String
        Get
            Return sMunicipioServico
        End Get
        Set(ByVal value As String)
            sMunicipioServico = value
        End Set
    End Property

    Public Property MunicipioPrestador() As String
        Get
            Return sMunicipioPrestador
        End Get
        Set(ByVal value As String)
            sMunicipioPrestador = value
        End Set
    End Property

    Public Property InscricaoMunicipalPrestador() As String
        Get
            Return sInscricaoMunicipalPrestador
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipalPrestador = value
        End Set
    End Property

    Public Property InscricaoMunicipal() As String
        Get
            Return sInscricaoMunicipal
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipal = value
        End Set
    End Property

    Public Property IncentivadorCultural() As String
        Get
            Return sIncentivadorCultural
        End Get
        Set(ByVal value As String)
            sIncentivadorCultural = value
        End Set
    End Property

    Public Property EnderecoTomador() As String
        Get
            Return sEnderecoTomador
        End Get
        Set(ByVal value As String)
            sEnderecoTomador = value
        End Set
    End Property

    Public Property EnderecoPrestador() As String
        Get
            Return sEnderecoPrestador
        End Get
        Set(ByVal value As String)
            sEnderecoPrestador = value
        End Set
    End Property

    Public Property EmailTomador() As String
        Get
            Return sEmailTomador
        End Get
        Set(ByVal value As String)
            sEmailTomador = value
        End Set
    End Property

    Public Property EmailPrestador() As String
        Get
            Return sEmailPrestador
        End Get
        Set(ByVal value As String)
            sEmailPrestador = value
        End Set
    End Property

    Public Property Discriminacao() As String
        Get
            Return sDiscriminacao
        End Get
        Set(ByVal value As String)
            sDiscriminacao = value
        End Set
    End Property

    Public Property Data() As String
        Get
            Return sData
        End Get
        Set(ByVal value As String)
            sData = value
        End Set
    End Property

    Public Property ComplementoTomador() As String
        Get
            Return sComplementoTomador
        End Get
        Set(ByVal value As String)
            sComplementoTomador = value
        End Set
    End Property

    Public Property ComplementoPrestador() As String
        Get
            Return sComplementoPrestador
        End Get
        Set(ByVal value As String)
            sComplementoPrestador = value
        End Set
    End Property

    Public Property Competencia() As String
        Get
            Return sCompetencia
        End Get
        Set(ByVal value As String)
            sCompetencia = value
        End Set
    End Property

    Public Property CodigoTributacaoServico() As String
        Get
            Return sCodigoTributacaoServico
        End Get
        Set(ByVal value As String)
            sCodigoTributacaoServico = value
        End Set
    End Property

    Public Property CodigoTipoTributacao() As String
        Get
            Return sCodigoTipoTributacao
        End Get
        Set(ByVal value As String)
            sCodigoTipoTributacao = value
        End Set
    End Property

    Public Property CodigoServico() As String
        Get
            Return sCodigoServico
        End Get
        Set(ByVal value As String)
            sCodigoServico = value
        End Set
    End Property

    Public Property CodigoAtividade() As String
        Get
            Return sCodigoAtividade
        End Get
        Set(ByVal value As String)
            sCodigoAtividade = value
        End Set
    End Property

    Public Property CodigoRegimeEspecial() As String
        Get
            Return sCodigoRegimeEspecial
        End Get
        Set(ByVal value As String)
            sCodigoRegimeEspecial = value
        End Set
    End Property

    Public Property CodigoObra() As String
        Get
            Return sCodigoObra
        End Get
        Set(ByVal value As String)
            sCodigoObra = value
        End Set
    End Property

    Public Property CodigoIncentivadorCultural() As String
        Get
            Return sCodigoIncentivadorCultural
        End Get
        Set(ByVal value As String)
            sCodigoIncentivadorCultural = value
        End Set
    End Property

    Public Property CodigoArt() As String
        Get
            Return sCodigoArt
        End Get
        Set(ByVal value As String)
            sCodigoArt = value
        End Set
    End Property

    Public Property CNPJTomador() As String
        Get
            Return sCNPJTomador
        End Get
        Set(ByVal value As String)
            sCNPJTomador = value
        End Set
    End Property

    Public Property CNPJPrestador() As String
        Get
            Return sCNPJPrestador
        End Get
        Set(ByVal value As String)
            sCNPJPrestador = value
        End Set
    End Property

    Public Property CEPTomador() As String
        Get
            Return sCEPTomador
        End Get
        Set(ByVal value As String)
            sCEPTomador = value
        End Set
    End Property

    Public Property CEPPrestador() As String
        Get
            Return sCEPPrestador
        End Get
        Set(ByVal value As String)
            sCEPPrestador = value
        End Set
    End Property

    Public Property ValorServico() As Double
        Get
            Return dValorServico
        End Get
        Set(ByVal value As Double)
            dValorServico = value
        End Set
    End Property

    Public Property CodigoSimplesNacional() As Integer
        Get
            Return iCodigoSimplesNacional
        End Get
        Set(ByVal value As Integer)
            iCodigoSimplesNacional = value
        End Set
    End Property

    Public Property ValorRetensoesFederais() As Double
        Get
            Return dValorRetensoesFederais
        End Get
        Set(ByVal value As Double)
            dValorRetensoesFederais = value
        End Set
    End Property

    Public Property ValorPIS() As Double
        Get
            Return dValorPIS
        End Get
        Set(ByVal value As Double)
            dValorPIS = value
        End Set
    End Property

    Public Property ValorLiquido() As Double
        Get
            Return dValorLiquido
        End Get
        Set(ByVal value As Double)
            dValorLiquido = value
        End Set
    End Property

    Public Property ValorISS() As Double
        Get
            Return dValorISS
        End Get
        Set(ByVal value As Double)
            dValorISS = value
        End Set
    End Property

    Public Property ValorIR() As Double
        Get
            Return dValorIR
        End Get
        Set(ByVal value As Double)
            dValorIR = value
        End Set
    End Property

    Public Property ValorINSS() As Double
        Get
            Return dValorINSS
        End Get
        Set(ByVal value As Double)
            dValorINSS = value
        End Set
    End Property

    Public Property ValorDescontoIncondicionado() As Double
        Get
            Return dValorDescontoIncondicionado
        End Get
        Set(ByVal value As Double)
            dValorDescontoIncondicionado = value
        End Set
    End Property

    Public Property ValorDescontoCondicionado() As Double
        Get
            Return dValorDescontoCondicionado
        End Get
        Set(ByVal value As Double)
            dValorDescontoCondicionado = value
        End Set
    End Property

    Public Property ValorCSLL() As Double
        Get
            Return dValorCSLL
        End Get
        Set(ByVal value As Double)
            dValorCSLL = value
        End Set
    End Property

    Public Property ValorCOFINS() As Double
        Get
            Return dValorCOFINS
        End Get
        Set(ByVal value As Double)
            dValorCOFINS = value
        End Set
    End Property

    Public Property ValorBaseCalculo() As Double
        Get
            Return dValorBaseCalculo
        End Get
        Set(ByVal value As Double)
            dValorBaseCalculo = value
        End Set
    End Property

    Public Property OutrasRetencoes() As Double
        Get
            Return dOutrasRetencoes
        End Get
        Set(ByVal value As Double)
            dOutrasRetencoes = value
        End Set
    End Property

    Public Property ISSRetido() As Double
        Get
            Return dISSRetido
        End Get
        Set(ByVal value As Double)
            dISSRetido = value
        End Set
    End Property

    Public Property DeducoesEmLei() As Double
        Get
            Return dDeducoesEmLei
        End Get
        Set(ByVal value As Double)
            dDeducoesEmLei = value
        End Set
    End Property

    Public Property AliquotaISS() As Double
        Get
            Return dAliquotaISS
        End Get
        Set(ByVal value As Double)
            dAliquotaISS = value
        End Set
    End Property

    Public Property ReterISS() As Boolean
        Get
            Return bReterISS
        End Get
        Set(ByVal value As Boolean)
            bReterISS = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: NOTA FISCAL :::"

    Public Sub ReceberDadosNFSe(ByVal sCodigoVerificacao As String)

        Dim oStreamReader As StreamReader

        Try

            'Váriaveis Locais
            Dim sUrl As String = "http://visualizar.ginfes.com.br/report/consultarNota?__report=nfs_ver4&cdVerificacao=" & sCodigoVerificacao
            Dim sValorAuxiliar As String
            Dim sAux() As String

            'Criando um web request 
            Dim oWebRequest As System.Net.HttpWebRequest = System.Net.WebRequest.Create(sUrl)

            'Caso tenha Proxy
            If goConfiguracaoNFe.bHabilitarProxy = True Then
                Dim sEndereco As String = goConfiguracaoNFe.sEndereco & ":" & goConfiguracaoNFe.iPorta
                oWebRequest.Proxy = New System.Net.WebProxy(sEndereco, True)
                If goConfiguracaoNFe.sDominio.Trim = "" Then
                    oWebRequest.Proxy.Credentials = New System.Net.NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha))
                Else
                    oWebRequest.Proxy.Credentials = New System.Net.NetworkCredential(goConfiguracaoNFe.sUsuario, Cripitografar(goConfiguracaoNFe.sSenha), goConfiguracaoNFe.sDominio)
                End If
            End If

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
            sHTML = sHTML.Replace("<br/>", vbNewLine)
            sHTML = sHTML.Replace("&nbsp;", " ")

            'Tirando os últimos SPAN´s
            sHTML = sHTML.Replace("</span>", "")

            'Tirando esses caracteres que podem confundir
            sHTML = sHTML.Replace("><", "")

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
            sCodigoAtividade = sAux(1).Trim.Substring(0, 8)
            sCodigoTributacaoServico = Mid(sAux(1), 2, 8)

            'Discriminacao
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sDiscriminacao = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

            'Código da Obra ( Se Houver)
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sCodigoObra = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))

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

            'CSLL
            sHTML = Mid(sHTML, InStr(sHTML, """>") + 2)
            sValorAuxiliar = (RTrim(Mid(sHTML, 1, InStr(sHTML, "<") - 1)))
            If IsNumeric(sValorAuxiliar) Then
                dValorCSLL = sValorAuxiliar
            Else
                dValorCSLL = 0
            End If

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

#Region "::: SERVIÇO :::"

    Private Sub LoadDadosServicos(ByVal txtValorServico As NumericEditBox, _
                                  ByVal lCodigoPedidoVenda As Double, _
                                  ByVal iCodigoPedidoVendaItem As Integer, _
                                  ByVal iCodigoPedidoVendaItemEntrega As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedidoVenda : i += 1

            'Seta Parametros - Código Pedido Venda Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_venda_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoVendaItem : i += 1

            'Seta Parametros - Código Pedido Venda Item E
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_venda_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoVendaItemEntrega : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_nfs_venda_pedido_servico_dados", oSqlParameter)

            While oSqlDataReader.Read

                txtValorServico.Value = oSqlDataReader.Item("valor_servico")
                txtValorServico.Tag = oSqlDataReader.Item("codigo_servico")

            End While

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Public Sub GerarDuplicata(ByVal oGrid As GridEX, _
                              ByVal dValor As Double, _
                              ByVal iNumeroParcela As Integer, _
                              ByVal iIntervaloParcela As Integer)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Caso Valor Liquido maior que 0
            If dValor > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")

                'Seta DataType
                oDCVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCVencimento)
                oDataTable.Columns.Add(oDCValor)

                'Adiciona Linhas ao DataTable
                For i = 1 To iNumeroParcela
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("data_vencimento") = CDate(DateAdd(DateInterval.Day, i * iIntervaloParcela, Now.Date))
                    oDataRow("valor") = dValor / iNumeroParcela
                    oDataTable.Rows.Add(oDataRow)
                Next
                
                'Configura DataMember
                Call ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class


