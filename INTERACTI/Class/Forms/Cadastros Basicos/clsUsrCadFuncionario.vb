Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports INTERACTI.SQLHelper
Imports System.IO
Imports System.Drawing.Imaging

Public Class clsUsrCadFuncionario

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigoFuncionario As Integer
    Private sProntuario As String
    Private sNome As String
    Private iCodigoMaquina As Integer
    Private sCTPS As String
    Private sSerieCTPS As String
    Private sUFCTPS As String
    Private sDataEmissaoCTPS As String
    Private sCPF As String
    Private sRG As String
    Private sDataExpedicaoRG As String
    Private sOrgaoEmissor As String
    Private sTituloEleitor As String
    Private sZonaEleitoral As String
    Private sSecaoEleitoral As String
    Private sCNH As String
    Private sCategoriaCNH As String
    Private sCertificadoMilitar As String
    Private sPISPASEP As String
    Private sDataExpedicaoPISPASEP As String
    Private iCodigoTurnoRelatorio As Integer
    Private bAtivo As Boolean
    Private iNivelPermissaoAPP As Integer
    Private iEscolhasApontamento As Integer
    'Dados Gerais
    Private sCep As String
    Private iCodigoPais As Integer
    Private sUF As String
    Private iCodigoMunicipio As Integer
    Private sLogradouro As String
    Private sNumero As String
    Private sBairro As String
    Private sComplemento As String
    Private sDataNascimento As String
    Private sEmail As String
    Private sTelefone1 As String
    Private sTelefone2 As String
    Private sNextel As String
    Private sTelefoneRecado As String
    Private sDataAdmissao As String
    Private sDataDemissao As String
    Private sCargo As String
    Private iCodigoOcupacao As Integer
    Private sObservacao As String
    Private picFoto As PictureBox
    'Dados Pessoais
    Private iCodigoSexo As Integer
    Private iCodigoEstadoCivil As Integer
    Private sNomeConjuge As String
    Private iCodigoFormacao As Integer
    Private sNomePai As String
    Private sNomeMae As String
    'Jornada de Trabalho / Pagamento
    Private iCodigoTipoValor As Integer
    Private dValorBase As Double
    Private dValorHora As Double
    Private dPercentualAdicionalNoturno As Double
    Private sBancoHoras As String
    Private iCodigoCentroGasto As Integer
    Private iCodigoTipoContrato As Integer
    Private sObservacaoTipoContrato As String
    Private iCodigoTurno As Integer
    Private dHoraEntradaSegunda As Double
    Private dHoraEntradaTerca As Double
    Private dHoraEntradaQuarta As Double
    Private dHoraEntradaQuinta As Double
    Private dHoraEntradaSexta As Double
    Private dHoraEntradaSabado As Double
    Private dHoraEntradaDomingo As Double
    Private dHoraSaidaSegunda As Double
    Private dHoraSaidaTerca As Double
    Private dHoraSaidaQuarta As Double
    Private dHoraSaidaQuinta As Double
    Private dHoraSaidaSexta As Double
    Private dHoraSaidaSabado As Double
    Private dHoraSaidaDomingo As Double
    Private dHoraAlmocoSegunda As Double
    Private dHoraAlmocoTerca As Double
    Private dHoraAlmocoQuarta As Double
    Private dHoraAlmocoQuinta As Double
    Private dHoraAlmocoSexta As Double
    Private dHoraAlmocoSabado As Double
    Private dHoraAlmocoDomingo As Double
    Private dHoraAdicionalInicio As Double
    Private dHoraAdicionalTermino As Double
    Private iCodigoHoraExtraSegunda As Integer
    Private iHoraExtraAposSegunda As Integer
    Private iCodigoHoraExtraAposSegunda As Integer
    Private iCodigoHoraExtraTerca As Integer
    Private iHoraExtraAposTerca As Integer
    Private iCodigoHoraExtraAposTerca As Integer
    Private iCodigoHoraExtraQuarta As Integer
    Private iHoraExtraAposQuarta As Integer
    Private iCodigoHoraExtraAposQuarta As Integer
    Private iCodigoHoraExtraQuinta As Integer
    Private iHoraExtraAposQuinta As Integer
    Private iCodigoHoraExtraAposQuinta As Integer
    Private iCodigoHoraExtraSexta As Integer
    Private iHoraExtraAposSexta As Integer
    Private iCodigoHoraExtraAposSexta As Integer
    Private iCodigoHoraExtraSabado As Integer
    Private iHoraExtraAposSabado As Integer
    Private iCodigoHoraExtraAposSabado As Integer
    Private iCodigoHoraExtraDomingo As Integer
    Private iHoraExtraAposDomingo As Integer
    Private iCodigoHoraExtraAposDomingo As Integer
    Private iCodigoInsertDocumento As Integer
    Private dHoraAlmocoSegundaTermino As Double
    Private dHoraAlmocoTercaTermino As Double
    Private dHoraAlmocoQuartaTermino As Double
    Private dHoraAlmocoQuintaTermino As Double
    Private dHoraAlmocoSextaTermino As Double
    Private dHoraAlmocoSabadoTermino As Double
    Private dHoraAlmocoDomingoTermino As Double
    Private dHoraIntervaloSegundaInicio As Double
    Private dHoraIntervaloTercaInicio As Double
    Private dHoraIntervaloQuartaInicio As Double
    Private dHoraIntervaloQuintaInicio As Double
    Private dHoraIntervaloSextaInicio As Double
    Private dHoraIntervaloSabadoInicio As Double
    Private dHoraIntervaloDomingoInicio As Double
    Private dHoraIntervaloSegundaTermino As Double
    Private dHoraIntervaloTercaTermino As Double
    Private dHoraIntervaloQuartaTermino As Double
    Private dHoraIntervaloQuintaTermino As Double
    Private dHoraIntervaloSextaTermino As Double
    Private dHoraIntervaloSabadoTermino As Double
    Private dHoraIntervaloDomingoTermino As Double

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoFuncionario() As Integer
        Get
            Return iCodigoFuncionario
        End Get
        Set(ByVal value As Integer)
            iCodigoFuncionario = value
        End Set
    End Property

    Public Property CodigoTurnoRelatorio() As Integer
        Get
            Return iCodigoTurnoRelatorio
        End Get
        Set(ByVal value As Integer)
            iCodigoTurnoRelatorio = value
        End Set
    End Property

    Public Property CodigoInsertDocumento() As Integer
        Get
            Return iCodigoInsertDocumento
        End Get
        Set(ByVal value As Integer)
            iCodigoInsertDocumento = value
        End Set
    End Property

    Public Property Prontuario() As String
        Get
            Return sProntuario
        End Get
        Set(ByVal value As String)
            sProntuario = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return sNome
        End Get
        Set(ByVal value As String)
            sNome = value
        End Set
    End Property

    Public Property CodigoMaquina() As Integer
        Get
            Return iCodigoMaquina
        End Get
        Set(ByVal value As Integer)
            iCodigoMaquina = value
        End Set
    End Property


    Public Property CTPS() As String
        Get
            Return sCTPS
        End Get
        Set(ByVal value As String)
            sCTPS = value
        End Set
    End Property

    Public Property SerieCTPS() As String
        Get
            Return sSerieCTPS
        End Get
        Set(ByVal value As String)
            sSerieCTPS = value
        End Set
    End Property

    Public Property UFCTPS() As String
        Get
            Return sUFCTPS
        End Get
        Set(ByVal value As String)
            sUFCTPS = value
        End Set
    End Property

    Public Property DataEmissaoCTPS() As String
        Get
            Return sDataEmissaoCTPS
        End Get
        Set(ByVal value As String)
            sDataEmissaoCTPS = value
        End Set
    End Property

    Public Property CPF() As String
        Get
            Return sCPF
        End Get
        Set(ByVal value As String)
            sCPF = value
        End Set
    End Property

    Public Property RG() As String
        Get
            Return sRG
        End Get
        Set(ByVal value As String)
            sRG = value
        End Set
    End Property

    Public Property DataExpedicaoRG() As String
        Get
            Return sDataExpedicaoRG
        End Get
        Set(ByVal value As String)
            sDataExpedicaoRG = value
        End Set
    End Property

    Public Property OrgaoEmissor() As String
        Get
            Return sOrgaoEmissor
        End Get
        Set(ByVal value As String)
            sOrgaoEmissor = value
        End Set
    End Property

    Public Property TituloEleitor() As String
        Get
            Return sTituloEleitor
        End Get
        Set(ByVal value As String)
            sTituloEleitor = value
        End Set
    End Property

    Public Property ZonaEleitoral() As String
        Get
            Return sZonaEleitoral
        End Get
        Set(ByVal value As String)
            sZonaEleitoral = value
        End Set
    End Property

    Public Property SecaoEleitoral() As String
        Get
            Return sSecaoEleitoral
        End Get
        Set(ByVal value As String)
            sSecaoEleitoral = value
        End Set
    End Property

    Public Property CNH() As String
        Get
            Return sCNH
        End Get
        Set(ByVal value As String)
            sCNH = value
        End Set
    End Property

    Public Property CategoriaCNH() As String
        Get
            Return sCategoriaCNH
        End Get
        Set(ByVal value As String)
            sCategoriaCNH = value
        End Set
    End Property

    Public Property CertificadoMilitar() As String
        Get
            Return sCertificadoMilitar
        End Get
        Set(ByVal value As String)
            sCertificadoMilitar = value
        End Set
    End Property

    Public Property PISPASEP() As String
        Get
            Return sPISPASEP
        End Get
        Set(ByVal value As String)
            sPISPASEP = value
        End Set
    End Property

    Public Property DataExpedicaoPISPASEP() As String
        Get
            Return sDataExpedicaoPISPASEP
        End Get
        Set(ByVal value As String)
            sDataExpedicaoPISPASEP = value
        End Set
    End Property


    Public Property Cep() As String
        Get
            Return sCep
        End Get
        Set(ByVal value As String)
            sCep = value
        End Set
    End Property

    Public Property Pais() As Integer
        Get
            Return iCodigoPais
        End Get
        Set(ByVal value As Integer)
            iCodigoPais = value
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

    Public Property Municipio() As Integer
        Get
            Return iCodigoMunicipio
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipio = value
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

    Public Property Complemento() As String
        Get
            Return sComplemento
        End Get
        Set(ByVal value As String)
            sComplemento = value
        End Set
    End Property

    Public Property DataNascimento() As String
        Get
            Return sDataNascimento
        End Get
        Set(ByVal value As String)
            sDataNascimento = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return sEmail
        End Get
        Set(ByVal value As String)
            sEmail = value
        End Set
    End Property

    Public Property Telefone1() As String
        Get
            Return sTelefone1
        End Get
        Set(ByVal value As String)
            sTelefone1 = value
        End Set
    End Property

    Public Property Telefone2() As String
        Get
            Return sTelefone2
        End Get
        Set(ByVal value As String)
            sTelefone2 = value
        End Set
    End Property

    Public Property Nextel() As String
        Get
            Return sNextel
        End Get
        Set(ByVal value As String)
            sNextel = value
        End Set
    End Property

    Public Property TelefoneRecado() As String
        Get
            Return sTelefoneRecado
        End Get
        Set(ByVal value As String)
            sTelefoneRecado = value
        End Set
    End Property

    Public Property DataAdmissao() As String
        Get
            Return sDataAdmissao
        End Get
        Set(ByVal value As String)
            sDataAdmissao = value
        End Set
    End Property

    Public Property DataDemissao() As String
        Get
            Return sDataDemissao
        End Get
        Set(ByVal value As String)
            sDataDemissao = value
        End Set
    End Property

    Public Property Cargo() As String
        Get
            Return sCargo
        End Get
        Set(ByVal value As String)
            sCargo = value
        End Set
    End Property

    Public Property CodigoOcupacao() As Integer
        Get
            Return iCodigoOcupacao
        End Get
        Set(ByVal value As Integer)
            iCodigoOcupacao = value
        End Set
    End Property

    Public Property Observacao() As String
        Get
            Return sObservacao
        End Get
        Set(ByVal value As String)
            sObservacao = value
        End Set
    End Property

    Public Property Foto() As PictureBox
        Get
            Return picFoto
        End Get
        Set(ByVal value As PictureBox)
            picFoto = value
        End Set
    End Property


    Public Property CodigoSexo() As Integer
        Get
            Return iCodigoSexo
        End Get
        Set(ByVal value As Integer)
            iCodigoSexo = value
        End Set
    End Property

    Public Property CodigoEstadoCivil() As Integer
        Get
            Return iCodigoEstadoCivil
        End Get
        Set(ByVal value As Integer)
            iCodigoEstadoCivil = value
        End Set
    End Property

    Public Property NomeConjuge() As String
        Get
            Return sNomeConjuge
        End Get
        Set(ByVal value As String)
            sNomeConjuge = value
        End Set
    End Property

    Public Property CodigoFormacao() As Integer
        Get
            Return iCodigoFormacao
        End Get
        Set(ByVal value As Integer)
            iCodigoFormacao = value
        End Set
    End Property

    Public Property NomePai() As String
        Get
            Return sNomePai
        End Get
        Set(ByVal value As String)
            sNomePai = value
        End Set
    End Property

    Public Property NomeMae() As String
        Get
            Return sNomeMae
        End Get
        Set(ByVal value As String)
            sNomeMae = value
        End Set
    End Property


    Public Property CodigoTipoValor() As Integer
        Get
            Return iCodigoTipoValor
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoValor = value
        End Set
    End Property

    Public Property ValorBase() As Double
        Get
            Return dValorBase
        End Get
        Set(ByVal value As Double)
            dValorBase = value
        End Set
    End Property

    Public Property ValorHora() As Double
        Get
            Return dValorHora
        End Get
        Set(ByVal value As Double)
            dValorHora = value
        End Set
    End Property

    Public Property PercentualAdicionalNoturno() As Double
        Get
            Return dPercentualAdicionalNoturno
        End Get
        Set(ByVal value As Double)
            dPercentualAdicionalNoturno = value
        End Set
    End Property

    Public Property BancoHoras() As String
        Get
            Return sBancoHoras
        End Get
        Set(ByVal value As String)
            sBancoHoras = value
        End Set
    End Property

    Public Property CodigoCentroGasto() As Integer
        Get
            Return iCodigoCentroGasto
        End Get
        Set(ByVal value As Integer)
            iCodigoCentroGasto = value
        End Set
    End Property

    Public Property CodigoTipoContrato() As Integer
        Get
            Return iCodigoTipoContrato
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoContrato = value
        End Set
    End Property

    Public Property CodigoTurno() As Integer
        Get
            Return iCodigoTurno
        End Get
        Set(ByVal value As Integer)
            iCodigoTurno = value
        End Set
    End Property

    Public Property ObservacaoTipoContrato() As String
        Get
            Return sObservacaoTipoContrato
        End Get
        Set(ByVal value As String)
            sObservacaoTipoContrato = value
        End Set
    End Property


    Public Property HoraEntradaSegunda() As Double
        Get
            Return dHoraEntradaSegunda
        End Get
        Set(ByVal value As Double)
            dHoraEntradaSegunda = value
        End Set
    End Property

    Public Property HoraEntradaTerca() As Double
        Get
            Return dHoraEntradaTerca
        End Get
        Set(ByVal value As Double)
            dHoraEntradaTerca = value
        End Set
    End Property

    Public Property HoraEntradaQuarta() As Double
        Get
            Return dHoraEntradaQuarta
        End Get
        Set(ByVal value As Double)
            dHoraEntradaQuarta = value
        End Set
    End Property

    Public Property HoraEntradaQuinta() As Double
        Get
            Return dHoraEntradaQuinta
        End Get
        Set(ByVal value As Double)
            dHoraEntradaQuinta = value
        End Set
    End Property

    Public Property HoraEntradaSexta() As Double
        Get
            Return dHoraEntradaSexta
        End Get
        Set(ByVal value As Double)
            dHoraEntradaSexta = value
        End Set
    End Property

    Public Property HoraEntradaSabado() As Double
        Get
            Return dHoraEntradaSabado
        End Get
        Set(ByVal value As Double)
            dHoraEntradaSabado = value
        End Set
    End Property

    Public Property HoraEntradaDomingo() As Double
        Get
            Return dHoraEntradaDomingo
        End Get
        Set(ByVal value As Double)
            dHoraEntradaDomingo = value
        End Set
    End Property


    Public Property HoraSaidaSegunda() As Double
        Get
            Return dHoraSaidaSegunda
        End Get
        Set(ByVal value As Double)
            dHoraSaidaSegunda = value
        End Set
    End Property

    Public Property HoraSaidaTerca() As Double
        Get
            Return dHoraSaidaTerca
        End Get
        Set(ByVal value As Double)
            dHoraSaidaTerca = value
        End Set
    End Property

    Public Property HoraSaidaQuarta() As Double
        Get
            Return dHoraSaidaQuarta
        End Get
        Set(ByVal value As Double)
            dHoraSaidaQuarta = value
        End Set
    End Property

    Public Property HoraSaidaQuinta() As Double
        Get
            Return dHoraSaidaQuinta
        End Get
        Set(ByVal value As Double)
            dHoraSaidaQuinta = value
        End Set
    End Property

    Public Property HoraSaidaSexta() As Double
        Get
            Return dHoraSaidaSexta
        End Get
        Set(ByVal value As Double)
            dHoraSaidaSexta = value
        End Set
    End Property

    Public Property HoraSaidaSabado() As Double
        Get
            Return dHoraSaidaSabado
        End Get
        Set(ByVal value As Double)
            dHoraSaidaSabado = value
        End Set
    End Property

    Public Property HoraSaidaDomingo() As Double
        Get
            Return dHoraSaidaDomingo
        End Get
        Set(ByVal value As Double)
            dHoraSaidaDomingo = value
        End Set
    End Property


    Public Property HoraAlmocoSegundaInicio() As Double
        Get
            Return dHoraAlmocoSegunda
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSegunda = value
        End Set
    End Property

    Public Property HoraAlmocoTercaInicio() As Double
        Get
            Return dHoraAlmocoTerca
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoTerca = value
        End Set
    End Property

    Public Property HoraAlmocoQuartaInicio() As Double
        Get
            Return dHoraAlmocoQuarta
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuarta = value
        End Set
    End Property

    Public Property HoraAlmocoQuintaInicio() As Double
        Get
            Return dHoraAlmocoQuinta
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuinta = value
        End Set
    End Property

    Public Property HoraAlmocoSextaInicio() As Double
        Get
            Return dHoraAlmocoSexta
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSexta = value
        End Set
    End Property

    Public Property HoraAlmocoSabadoInicio() As Double
        Get
            Return dHoraAlmocoSabado
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSabado = value
        End Set
    End Property

    Public Property HoraAlmocoDomingoInicio() As Double
        Get
            Return dHoraAlmocoDomingo
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoDomingo = value
        End Set
    End Property

    Public Property HoraAlmocoSegundaTermino() As Double
        Get
            Return dHoraAlmocoSegundaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSegundaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoTercaTermino() As Double
        Get
            Return dHoraAlmocoTercaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoTercaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoQuartaTermino() As Double
        Get
            Return dHoraAlmocoQuartaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuartaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoQuintaTermino() As Double
        Get
            Return dHoraAlmocoQuintaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuintaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoSextaTermino() As Double
        Get
            Return dHoraAlmocoSextaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSextaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoSabadoTermino() As Double
        Get
            Return dHoraAlmocoSabadoTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSabadoTermino = value
        End Set
    End Property

    Public Property HoraAlmocoDomingoTermino() As Double
        Get
            Return dHoraAlmocoDomingoTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoDomingoTermino = value
        End Set
    End Property

    Public Property HoraIntervaloSegundaInicio() As Double
        Get
            Return dHoraIntervaloSegundaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSegundaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloTercaInicio() As Double
        Get
            Return dHoraIntervaloTercaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloTercaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloQuartaInicio() As Double
        Get
            Return dHoraIntervaloQuartaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloQuartaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloQuintaInicio() As Double
        Get
            Return dHoraIntervaloQuintaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloQuintaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloSextaInicio() As Double
        Get
            Return dHoraIntervaloSextaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSextaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloSabadoInicio() As Double
        Get
            Return dHoraIntervaloSabadoInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSabadoInicio = value
        End Set
    End Property

    Public Property HoraIntervaloDomingoInicio() As Double
        Get
            Return dHoraIntervaloDomingoInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloDomingoInicio = value
        End Set
    End Property

    Public Property HoraIntervaloSegundaTermino() As Double
        Get
            Return dHoraIntervaloSegundaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSegundaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloTercaTermino() As Double
        Get
            Return dHoraIntervaloTercaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloTercaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloQuartaTermino() As Double
        Get
            Return dHoraIntervaloQuartaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloQuartaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloQuintaTermino() As Double
        Get
            Return dHoraIntervaloQuintaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloQuintaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloSextaTermino() As Double
        Get
            Return dHoraIntervaloSextaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSextaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloSabadoTermino() As Double
        Get
            Return dHoraIntervaloSabadoTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSabadoTermino = value
        End Set
    End Property

    Public Property HoraIntervaloDomingoTermino() As Double
        Get
            Return dHoraIntervaloDomingoTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloDomingoTermino = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoInicio() As Double
        Get
            Return dHoraAdicionalInicio
        End Get
        Set(ByVal value As Double)
            dHoraAdicionalInicio = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoTermino() As Double
        Get
            Return dHoraAdicionalTermino
        End Get
        Set(ByVal value As Double)
            dHoraAdicionalTermino = value
        End Set
    End Property

    Public Property CodigoHoraExtraSegunda() As Integer
        Get
            Return iCodigoHoraExtraSegunda
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraSegunda = value
        End Set
    End Property

    Public Property HoraExtraAposSegunda() As Integer
        Get
            Return iHoraExtraAposSegunda
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposSegunda = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposSegunda() As Integer
        Get
            Return iCodigoHoraExtraAposSegunda
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposSegunda = value
        End Set
    End Property

    Public Property CodigoHoraExtraTerca() As Integer
        Get
            Return iCodigoHoraExtraTerca
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraTerca = value
        End Set
    End Property

    Public Property HoraExtraAposTerca() As Integer
        Get
            Return iHoraExtraAposTerca
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposTerca = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposTerca() As Integer
        Get
            Return iCodigoHoraExtraAposTerca
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposTerca = value
        End Set
    End Property

    Public Property CodigoHoraExtraQuarta() As Integer
        Get
            Return iCodigoHoraExtraQuarta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraQuarta = value
        End Set
    End Property

    Public Property HoraExtraAposQuarta() As Integer
        Get
            Return iHoraExtraAposQuarta
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposQuarta = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposQuarta() As Integer
        Get
            Return iCodigoHoraExtraAposQuarta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposQuarta = value
        End Set
    End Property

    Public Property CodigoHoraExtraQuinta() As Integer
        Get
            Return iCodigoHoraExtraQuinta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraQuinta = value
        End Set
    End Property

    Public Property HoraExtraAposQuinta() As Integer
        Get
            Return iHoraExtraAposQuinta
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposQuinta = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposQuinta() As Integer
        Get
            Return iCodigoHoraExtraAposQuinta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposQuinta = value
        End Set
    End Property

    Public Property CodigoHoraExtraSexta() As Integer
        Get
            Return iCodigoHoraExtraSexta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraSexta = value
        End Set
    End Property

    Public Property HoraExtraAposSexta() As Integer
        Get
            Return iHoraExtraAposSexta
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposSexta = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposSexta() As Integer
        Get
            Return iCodigoHoraExtraAposSexta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposSexta = value
        End Set
    End Property

    Public Property CodigoHoraExtraSabado() As Integer
        Get
            Return iCodigoHoraExtraSabado
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraSabado = value
        End Set
    End Property

    Public Property HoraExtraAposSabado() As Integer
        Get
            Return iHoraExtraAposSabado
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposSabado = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposSabado() As Integer
        Get
            Return iCodigoHoraExtraAposSabado
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposSabado = value
        End Set
    End Property

    Public Property CodigoHoraExtraDomingo() As Integer
        Get
            Return iCodigoHoraExtraDomingo
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraDomingo = value
        End Set
    End Property

    Public Property HoraExtraAposDomingo() As Integer
        Get
            Return iHoraExtraAposDomingo
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposDomingo = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposDomingo() As Integer
        Get
            Return iCodigoHoraExtraAposDomingo
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposDomingo = value
        End Set
    End Property

    Public Property NivelPermissaoAPP() As Integer
        Get
            Return iNivelPermissaoAPP
        End Get
        Set(ByVal value As Integer)
            iNivelPermissaoAPP = value
        End Set
    End Property

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
        End Set
    End Property

    Public Property EscolhasApontamento() As Integer
        Get
            Return iEscolhasApontamento
        End Get
        Set(ByVal value As Integer)
            iEscolhasApontamento = value
        End Set
    End Property


#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: FUNCINÁRIO :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Prontuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prontuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sProntuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Turno Relatorio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_turno_relatorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTurnoRelatorio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNome : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Máquina
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMaquina = -1, DBNull.Value, iCodigoMaquina) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CTPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ctps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCTPS = "", DBNull.Value, sCTPS) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CTPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie_ctps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sSerieCTPS = "", DBNull.Value, sSerieCTPS) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - UF CTPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_ctps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUFCTPS = "", DBNull.Value, sUFCTPS) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Emissão CTPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_ctps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoCTPS), sDataEmissaoCTPS, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCPF : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - RG
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRG : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Expedicao RG
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_expedicao_rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataExpedicaoRG), sDataExpedicaoRG, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Órgão Emissor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "orgao_emissor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sOrgaoEmissor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Título de Eleitor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "titulo_eleitor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTituloEleitor = "", DBNull.Value, sTituloEleitor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Zona Eleitoral
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "zona_eleitoral"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sZonaEleitoral = "", DBNull.Value, sZonaEleitoral) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Seção Eleitoral
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "secao_eleitoral"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sSecaoEleitoral = "", DBNull.Value, sSecaoEleitoral) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CNH
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnh"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCNH = "", DBNull.Value, sCNH) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Categoria CNH
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "categoria_cnh"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCategoriaCNH = "", DBNull.Value, sCategoriaCNH) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Certificado Militar
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "certificado_militar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCertificadoMilitar = "", DBNull.Value, sCertificadoMilitar) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - PIS / PASEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_pasep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sPISPASEP = "", DBNull.Value, sPISPASEP) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Expedição PIS / PASEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_expedicao_pis_pasep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataExpedicaoPISPASEP), sDataExpedicaoPISPASEP, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCep : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoPais = -1, DBNull.Value, iCodigoPais) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUF = "", DBNull.Value, sUF) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Municipio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMunicipio = -1, DBNull.Value, iCodigoMunicipio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumero : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Nascimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataNascimento) = False, DBNull.Value, sDataNascimento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sEmail = "", DBNull.Value, sEmail) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTelefone1 = "", DBNull.Value, sTelefone1) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTelefone2 = "", DBNull.Value, sTelefone2) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nextel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nextel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sNextel = "", DBNull.Value, sNextel) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone de Recado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone_recado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTelefoneRecado = "", DBNull.Value, sTelefoneRecado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Admissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_admissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataAdmissao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Demissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_demissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataDemissao = "", DBNull.Value, sDataDemissao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cargo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cargo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sCargo = "", DBNull.Value, sCargo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código da Ocupação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ocupacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoOcupacao = -1, DBNull.Value, iCodigoOcupacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Verifica se existe Foto
            If Not picFoto.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picFoto.Image.Save(oMemoryStream, ImageFormat.Jpeg)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData : i += 1 : ReDim Preserve oSqlParameter(i)

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            End If

            If Not picFoto.Image Is Nothing Then

                Dim base64String As String = ImageToBase64(picFoto.Image)

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto_app"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = base64String : i += 1 : ReDim Preserve oSqlParameter(i)

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto_app"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            End If

            'Seta Parametros - Código Sexo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_sexo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoSexo = -1, DBNull.Value, iCodigoSexo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Estado Civil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_estado_civil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoEstadoCivil = -1, DBNull.Value, iCodigoEstadoCivil) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Conjuge
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_conjuge"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNomeConjuge = "", DBNull.Value, sNomeConjuge) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Formação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormacao = -1, DBNull.Value, iCodigoFormacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNomePai = "", DBNull.Value, sNomePai) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Mãe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_mae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNomeMae = "", DBNull.Value, sNomeMae) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo de Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoValor = -1, DBNull.Value, iCodigoTipoValor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Base
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_base"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorBase : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Hora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_hora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorHora : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Percentual Adicional Noturno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_adicional_noturno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualAdicionalNoturno : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Banco de Horas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "banco_horas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(sBancoHoras = "", DBNull.Value, sBancoHoras) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo de Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoContrato = -1, DBNull.Value, iCodigoTipoContrato) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação Tipo de Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao_tipo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sObservacaoTipoContrato = "", DBNull.Value, sObservacaoTipoContrato) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Turno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_turno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTurno = -1, DBNull.Value, iCodigoTurno) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Segunda Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegundaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Terça Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTercaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quarta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuartaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quinta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuintaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sexta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSextaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sabado Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabadoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Domingo Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Segunda Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_segunda_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSegundaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Terça Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_terca_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloTercaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quarta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quarta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuartaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quinta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quinta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuintaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sexta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sexta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSextaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sabado Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sabado_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSabadoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Domingo Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_domingo_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloDomingoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Segunda Termino 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_segunda_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSegundaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Terça Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_terca_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloTercaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quarta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quarta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuartaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quinta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quinta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuintaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sexta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sexta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSextaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sabado Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sabado_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSabadoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Domingo Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_domingo_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloDomingoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Adicional Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adicional_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAdicionalInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Adicional Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adicional_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAdicionalTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSegunda = -1, DBNull.Value, iCodigoHoraExtraSegunda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSegunda = -1, DBNull.Value, iCodigoHoraExtraAposSegunda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraTerca = -1, DBNull.Value, iCodigoHoraExtraTerca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposTerca = -1, DBNull.Value, iCodigoHoraExtraAposTerca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraQuarta = -1, DBNull.Value, iCodigoHoraExtraQuarta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposQuarta = -1, DBNull.Value, iCodigoHoraExtraAposQuarta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraQuinta = -1, DBNull.Value, iCodigoHoraExtraQuinta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposQuinta = -1, DBNull.Value, iCodigoHoraExtraAposQuinta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSexta = -1, DBNull.Value, iCodigoHoraExtraSexta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSexta = -1, DBNull.Value, iCodigoHoraExtraAposSexta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSabado = -1, DBNull.Value, iCodigoHoraExtraSabado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSabado = -1, DBNull.Value, iCodigoHoraExtraAposSabado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraDomingo = -1, DBNull.Value, iCodigoHoraExtraDomingo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposDomingo = -1, DBNull.Value, iCodigoHoraExtraAposDomingo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nivel Permissao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nivel_permissao_app"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iNivelPermissaoAPP = -1, DBNull.Value, iNivelPermissaoAPP) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Escolhas Apontamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "escolhas_apontamento_app"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iEscolhasApontamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario", oSqlParameter)

            'Seta Parâmetro
            iCodigoFuncionario = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Prontuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prontuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sProntuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Turno Relatorio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_turno_relatorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTurnoRelatorio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNome : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Máquina
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMaquina = -1, DBNull.Value, iCodigoMaquina) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CTPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ctps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCTPS = "", DBNull.Value, sCTPS) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CTPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie_ctps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sSerieCTPS = "", DBNull.Value, sSerieCTPS) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - UF CTPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_ctps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUFCTPS = "", DBNull.Value, sUFCTPS) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Emissão CTPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_ctps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoCTPS), sDataEmissaoCTPS, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCPF : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - RG
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRG : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Expedicao RG
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_expedicao_rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataExpedicaoRG), sDataExpedicaoRG, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Órgão Emissor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "orgao_emissor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sOrgaoEmissor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Título de Eleitor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "titulo_eleitor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTituloEleitor = "", DBNull.Value, sTituloEleitor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Zona Eleitoral
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "zona_eleitoral"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sZonaEleitoral = "", DBNull.Value, sZonaEleitoral) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Seção Eleitoral
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "secao_eleitoral"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sSecaoEleitoral = "", DBNull.Value, sSecaoEleitoral) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CNH
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnh"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCNH = "", DBNull.Value, sCNH) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Categoria CNH
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "categoria_cnh"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCategoriaCNH = "", DBNull.Value, sCategoriaCNH) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Certificado Militar
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "certificado_militar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCertificadoMilitar = "", DBNull.Value, sCertificadoMilitar) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - PIS / PASEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_pasep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sPISPASEP = "", DBNull.Value, sPISPASEP) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Expedição PIS / PASEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_expedicao_pis_pasep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataExpedicaoPISPASEP), sDataExpedicaoPISPASEP, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCep : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoPais = -1, DBNull.Value, iCodigoPais) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUF = "", DBNull.Value, sUF) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Municipio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMunicipio = -1, DBNull.Value, iCodigoMunicipio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumero : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Nascimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataNascimento) = False, DBNull.Value, sDataNascimento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sEmail = "", DBNull.Value, sEmail) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTelefone1 = "", DBNull.Value, sTelefone1) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTelefone2 = "", DBNull.Value, sTelefone2) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nextel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nextel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sNextel = "", DBNull.Value, sNextel) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone de Recado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone_recado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sTelefoneRecado = "", DBNull.Value, sTelefoneRecado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Admissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_admissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataAdmissao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Demissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_demissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataDemissao = "", DBNull.Value, sDataDemissao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cargo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cargo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sCargo = "", DBNull.Value, sCargo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código da Ocupação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ocupacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoOcupacao = -1, DBNull.Value, iCodigoOcupacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Verifica se existe Foto
            If Not picFoto.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picFoto.Image.Save(oMemoryStream, ImageFormat.Jpeg)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData : i += 1 : ReDim Preserve oSqlParameter(i)

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            End If

            If Not picFoto.Image Is Nothing Then

                Dim base64String As String = ImageToBase64(picFoto.Image)

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto_app"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = base64String : i += 1 : ReDim Preserve oSqlParameter(i)

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto_app"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = DBNull.Value : i += 1 : i += 1 : ReDim Preserve oSqlParameter(i)
            End If

            'Seta Parametros - Código Sexo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_sexo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoSexo = -1, DBNull.Value, iCodigoSexo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Estado Civil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_estado_civil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoEstadoCivil = -1, DBNull.Value, iCodigoEstadoCivil) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Conjuge
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_conjuge"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNomeConjuge = "", DBNull.Value, sNomeConjuge) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Formação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormacao = -1, DBNull.Value, iCodigoFormacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNomePai = "", DBNull.Value, sNomePai) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Mãe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_mae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNomeMae = "", DBNull.Value, sNomeMae) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo de Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoValor = -1, DBNull.Value, iCodigoTipoValor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Base
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_base"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorBase : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Hora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_hora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorHora : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Percentual Adicional Noturno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_adicional_noturno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualAdicionalNoturno : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Banco de Horas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "banco_horas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(sBancoHoras = "", DBNull.Value, sBancoHoras) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo de Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoContrato = -1, DBNull.Value, iCodigoTipoContrato) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação Tipo de Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao_tipo_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sObservacaoTipoContrato = "", DBNull.Value, sObservacaoTipoContrato) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Turno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_turno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTurno = -1, DBNull.Value, iCodigoTurno) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Segunda Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegundaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Terça Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTercaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quarta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuartaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quinta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuintaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sexta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSextaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sabado Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabadoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Domingo Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Segunda Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_segunda_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSegundaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Terça Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_terca_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloTercaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quarta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quarta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuartaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quinta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quinta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuintaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sexta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sexta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSextaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sabado Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sabado_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSabadoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Domingo Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_domingo_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloDomingoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Segunda Termino 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_segunda_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSegundaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Terça Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_terca_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloTercaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quarta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quarta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuartaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quinta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quinta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuintaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sexta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sexta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSextaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sabado Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sabado_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSabadoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Domingo Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_domingo_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloDomingoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Adicional Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adicional_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAdicionalInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Adicional Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adicional_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAdicionalTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSegunda = -1, DBNull.Value, iCodigoHoraExtraSegunda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSegunda = -1, DBNull.Value, iCodigoHoraExtraAposSegunda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraTerca = -1, DBNull.Value, iCodigoHoraExtraTerca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposTerca = -1, DBNull.Value, iCodigoHoraExtraAposTerca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraQuarta = -1, DBNull.Value, iCodigoHoraExtraQuarta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposQuarta = -1, DBNull.Value, iCodigoHoraExtraAposQuarta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraQuinta = -1, DBNull.Value, iCodigoHoraExtraQuinta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposQuinta = -1, DBNull.Value, iCodigoHoraExtraAposQuinta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSexta = -1, DBNull.Value, iCodigoHoraExtraSexta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSexta = -1, DBNull.Value, iCodigoHoraExtraAposSexta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSabado = -1, DBNull.Value, iCodigoHoraExtraSabado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSabado = -1, DBNull.Value, iCodigoHoraExtraAposSabado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraDomingo = -1, DBNull.Value, iCodigoHoraExtraDomingo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposDomingo = -1, DBNull.Value, iCodigoHoraExtraAposDomingo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - iNivelPermissaoAPP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nivel_permissao_app"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iNivelPermissaoAPP = -1, DBNull.Value, iNivelPermissaoAPP) : i += 1 : ReDim Preserve oSqlParameter(i) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Escolhas Apontamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "escolhas_apontamento_app"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iEscolhasApontamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal iCodigo As Integer,
                         ByVal txtProntuario As MaskedEditBox,
                         ByVal txtNome As MaskedEditBox,
                         ByVal cboMaquinaEquipamento As UIComboBox,
                         ByVal txtCTPS As MaskedEditBox,
                         ByVal txtSerieCTPS As MaskedEditBox,
                         ByVal cboUFCTPS As UIComboBox,
                         ByVal dtpDataEmissaoCTPS As CalendarCombo,
                         ByVal txtCPF As MaskedEditBox,
                         ByVal txtRG As MaskedEditBox,
                         ByVal dtpDataExpedicao As CalendarCombo,
                         ByVal txtOrgaoEmissor As MaskedEditBox,
                         ByVal txtTituloEleitor As MaskedEditBox,
                         ByVal txtZona As MaskedEditBox,
                         ByVal txtSecao As MaskedEditBox,
                         ByVal txtCNH As MaskedEditBox,
                         ByVal txtCategoria As MaskedEditBox,
                         ByVal txtCertificadoMilitar As MaskedEditBox,
                         ByVal txtPISPASEP As MaskedEditBox,
                         ByVal dtpDataExpedicaoPISPASEP As CalendarCombo,
                         ByVal txtCep As MaskedEditBox,
                         ByVal cboPais As UIComboBox,
                         ByVal cboUF As UIComboBox,
                         ByVal cboMunicipio As UIComboBox,
                         ByVal txtLogradouro As MaskedEditBox,
                         ByVal txtNumero As MaskedEditBox,
                         ByVal txtBairro As MaskedEditBox,
                         ByVal txtComplemento As MaskedEditBox,
                         ByVal dtpDataNascimento As CalendarCombo,
                         ByVal txtEmail As MaskedEditBox,
                         ByVal txtTelefone1 As MaskedEditBox,
                         ByVal txtTelefone2 As MaskedEditBox,
                         ByVal txtNextel As MaskedEditBox,
                         ByVal txtTelefoneRecado As MaskedEditBox,
                         ByVal dtpDataAdmissao As CalendarCombo,
                         ByVal dtpDataDemissao As CalendarCombo,
                         ByVal txtCargo As MaskedEditBox,
                         ByVal cboOcupacao As UIComboBox,
                         ByVal txtObservacao As EditBox,
                         ByVal picFoto As PictureBox,
                         ByVal cboSexo As UIComboBox,
                         ByVal cboEstadoCivil As UIComboBox,
                         ByVal txtNomeConjuge As MaskedEditBox,
                         ByVal cboFormacao As UIComboBox,
                         ByVal txtNomePai As MaskedEditBox,
                         ByVal txtNomeMae As MaskedEditBox,
                         ByVal cboTipoValor As UIComboBox,
                         ByVal txtValorBase As NumericEditBox,
                         ByVal txtValorHora As NumericEditBox,
                         ByVal txtPercentualAdicionalNoturno As NumericEditBox,
                         ByVal cboBancoHoras As UIComboBox,
                         ByVal cboCentroGasto As UIComboBox,
                         ByVal cboTipoContrato As UIComboBox,
                         ByVal txtObservacaoTipoContrato As MaskedEditBox,
                         ByVal cboTurno As UIComboBox,
                         ByVal txtHoraEntradaSegunda As MaskedEditBox,
                         ByVal txtHoraEntradaTerca As MaskedEditBox,
                         ByVal txtHoraEntradaQuarta As MaskedEditBox,
                         ByVal txtHoraEntradaQuinta As MaskedEditBox,
                         ByVal txtHoraEntradaSexta As MaskedEditBox,
                         ByVal txtHoraEntradaSabado As MaskedEditBox,
                         ByVal txtHoraEntradaDomingo As MaskedEditBox,
                         ByVal txtHoraSaidaSegunda As MaskedEditBox,
                         ByVal txtHoraSaidaTerca As MaskedEditBox,
                         ByVal txtHoraSaidaQuarta As MaskedEditBox,
                         ByVal txtHoraSaidaQuinta As MaskedEditBox,
                         ByVal txtHoraSaidaSexta As MaskedEditBox,
                         ByVal txtHoraSaidaSabado As MaskedEditBox,
                         ByVal txtHoraSaidaDomingo As MaskedEditBox,
                         ByVal txtHoraAlmocoSegundaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoTercaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoQuartaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoQuintaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoSextaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoSabadoInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoDomingoInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoSegundaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoTercaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoQuartaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoQuintaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoSextaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoSabadoTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoDomingoTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloSegundaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloTercaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloQuartaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloQuintaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloSextaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloSabadoInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloDomingoInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloSegundaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloTercaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloQuartaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloQuintaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloSextaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloSabadoTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloDomingoTermino As MaskedEditBox,
                         ByVal txtHoraAdicionalNoturnoInicio As MaskedEditBox,
                         ByVal txtHoraAdicionalNoturnoTermino As MaskedEditBox,
                         ByVal cboHoraExtraSegunda As UIComboBox,
                         ByVal txtHoraExtraAposSegunda As NumericEditBox,
                         ByVal cboHoraExtraAposSegunda As UIComboBox,
                         ByVal cboHoraExtraTerca As UIComboBox,
                         ByVal txtHoraExtraAposTerca As NumericEditBox,
                         ByVal cboHoraExtraAposTerca As UIComboBox,
                         ByVal cboHoraExtraQuarta As UIComboBox,
                         ByVal txtHoraExtraAposQuarta As NumericEditBox,
                         ByVal cboHoraExtraAposQuarta As UIComboBox,
                         ByVal cboHoraExtraQuinta As UIComboBox,
                         ByVal txtHoraExtraAposQuinta As NumericEditBox,
                         ByVal cboHoraExtraAposQuinta As UIComboBox,
                         ByVal cboHoraExtraSexta As UIComboBox,
                         ByVal txtHoraExtraAposSexta As NumericEditBox,
                         ByVal cboHoraExtraAposSexta As UIComboBox,
                         ByVal cboHoraExtraSabado As UIComboBox,
                         ByVal txtHoraExtraAposSabado As NumericEditBox,
                         ByVal cboHoraExtraAposSabado As UIComboBox,
                         ByVal cboHoraExtraDomingo As UIComboBox,
                         ByVal txtHoraExtraAposDomingo As NumericEditBox,
                         ByVal cboHoraExtraAposDomingo As UIComboBox,
                         ByVal cboTurnoRelatorio As UIComboBox,
                         ByVal cboAtivo As UIComboBox,
                         ByVal cboNivelPermissaoAPP As UIComboBox,
                         ByVal txtEscolhasApontamento As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_dados", oSqlParameter)

            While oSqlDataReader.Read

                If IsDBNull(oSqlDataReader.Item("codigo_turno_relatorio")) Then
                    cboTurnoRelatorio.SelectedIndex = -1
                Else
                    cboTurnoRelatorio.SelectedValue = oSqlDataReader.Item("codigo_turno_relatorio")
                End If

                'Preenche Controles
                txtProntuario.Text = oSqlDataReader.Item("prontuario")
                txtNome.Text = oSqlDataReader.Item("nome")
                cboMaquinaEquipamento.SelectedValue = oSqlDataReader.Item("codigo_maquina")
                txtCTPS.Text = oSqlDataReader.Item("ctps")
                txtSerieCTPS.Text = oSqlDataReader.Item("serie_ctps")
                cboUFCTPS.SelectedValue = oSqlDataReader.Item("uf_ctps")
                If IsDBNull(oSqlDataReader.Item("data_emissao_ctps")) Then
                    dtpDataEmissaoCTPS.Checked = False
                Else
                    dtpDataEmissaoCTPS.Value = oSqlDataReader.Item("data_emissao_ctps") : dtpDataEmissaoCTPS.Checked = True
                End If
                txtCPF.Text = oSqlDataReader.Item("cpf")
                txtRG.Text = oSqlDataReader.Item("rg")
                If IsDBNull(oSqlDataReader.Item("data_expedicao_rg")) Then
                    dtpDataExpedicao.Checked = False
                Else
                    dtpDataExpedicao.Value = oSqlDataReader.Item("data_expedicao_rg") : dtpDataExpedicao.Checked = True
                End If
                txtOrgaoEmissor.Text = oSqlDataReader.Item("orgao_emissor")
                txtTituloEleitor.Text = oSqlDataReader.Item("titulo_eleitor")
                txtZona.Text = oSqlDataReader.Item("zona_eleitoral")
                txtSecao.Text = oSqlDataReader.Item("secao_eleitoral")
                txtCNH.Text = oSqlDataReader.Item("cnh")
                txtCategoria.Text = oSqlDataReader.Item("categoria_cnh")
                txtCertificadoMilitar.Text = oSqlDataReader.Item("certificado_militar")
                txtPISPASEP.Text = oSqlDataReader.Item("pis_pasep")
                If IsDBNull(oSqlDataReader.Item("data_expedicao_pis_pasep")) Then
                    dtpDataExpedicaoPISPASEP.Checked = False
                Else
                    dtpDataExpedicaoPISPASEP.Value = oSqlDataReader.Item("data_expedicao_pis_pasep") : dtpDataExpedicaoPISPASEP.Checked = True
                End If
                txtCep.Text = oSqlDataReader.Item("cep")
                cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                cboUF.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                txtNumero.Text = oSqlDataReader.Item("numero")
                txtBairro.Text = oSqlDataReader.Item("bairro")
                txtComplemento.Text = oSqlDataReader.Item("complemento")
                dtpDataNascimento.Value = oSqlDataReader.Item("data_nascimento")
                txtEmail.Text = oSqlDataReader.Item("email")
                txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                txtNextel.Text = oSqlDataReader.Item("nextel")
                txtTelefoneRecado.Text = oSqlDataReader.Item("telefone_recado")
                dtpDataAdmissao.Value = oSqlDataReader.Item("data_admissao")
                If IsDBNull(oSqlDataReader.Item("data_demissao")) Then
                    dtpDataDemissao.Checked = False
                Else
                    dtpDataDemissao.Value = oSqlDataReader.Item("data_demissao") : dtpDataDemissao.Checked = True
                End If
                txtCargo.Text = oSqlDataReader.Item("cargo")
                cboOcupacao.SelectedValue = oSqlDataReader.Item("codigo_ocupacao")
                txtObservacao.Text = oSqlDataReader.Item("observacao")
                cboSexo.SelectedValue = oSqlDataReader.Item("codigo_sexo")
                cboEstadoCivil.SelectedValue = oSqlDataReader.Item("codigo_estado_civil")
                txtNomeConjuge.Text = oSqlDataReader.Item("nome_conjuge")
                cboFormacao.SelectedValue = oSqlDataReader.Item("codigo_formacao")
                txtNomePai.Text = oSqlDataReader.Item("nome_pai")
                txtNomeMae.Text = oSqlDataReader.Item("nome_mae")
                cboTipoValor.SelectedValue = oSqlDataReader.Item("codigo_tipo_valor")
                txtValorBase.Value = oSqlDataReader.Item("valor_base")
                txtValorHora.Value = oSqlDataReader.Item("valor_hora")
                txtPercentualAdicionalNoturno.Value = oSqlDataReader.Item("percentual_adicional_noturno")
                cboBancoHoras.SelectedValue = oSqlDataReader.Item("banco_horas")
                cboCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_centro_custo")
                cboTipoContrato.SelectedValue = oSqlDataReader.Item("codigo_tipo_contrato")
                txtObservacaoTipoContrato.Text = oSqlDataReader.Item("observacao_tipo_contrato")
                cboTurno.SelectedValue = oSqlDataReader.Item("codigo_turno")
                txtHoraEntradaSegunda.Text = oSqlDataReader.Item("entrada_segunda")
                txtHoraEntradaTerca.Text = oSqlDataReader.Item("entrada_terca")
                txtHoraEntradaQuarta.Text = oSqlDataReader.Item("entrada_quarta")
                txtHoraEntradaQuinta.Text = oSqlDataReader.Item("entrada_quinta")
                txtHoraEntradaSexta.Text = oSqlDataReader.Item("entrada_sexta")
                txtHoraEntradaSabado.Text = oSqlDataReader.Item("entrada_sabado")
                txtHoraEntradaDomingo.Text = oSqlDataReader.Item("entrada_domingo")
                txtHoraSaidaSegunda.Text = oSqlDataReader.Item("saida_segunda")
                txtHoraSaidaTerca.Text = oSqlDataReader.Item("saida_terca")
                txtHoraSaidaQuarta.Text = oSqlDataReader.Item("saida_quarta")
                txtHoraSaidaQuinta.Text = oSqlDataReader.Item("saida_quinta")
                txtHoraSaidaSexta.Text = oSqlDataReader.Item("saida_sexta")
                txtHoraSaidaSabado.Text = oSqlDataReader.Item("saida_sabado")
                txtHoraSaidaDomingo.Text = oSqlDataReader.Item("saida_domingo")
                txtHoraAlmocoSegundaInicio.Text = oSqlDataReader.Item("hora_almoco_segunda")
                txtHoraAlmocoSegundaTermino.Text = oSqlDataReader.Item("hora_almoco_segunda_termino")
                txtHoraAlmocoTercaInicio.Text = oSqlDataReader.Item("hora_almoco_terca")
                txtHoraAlmocoTercaTermino.Text = oSqlDataReader.Item("hora_almoco_terca_termino")
                txtHoraAlmocoQuartaInicio.Text = oSqlDataReader.Item("hora_almoco_quarta")
                txtHoraAlmocoQuartaTermino.Text = oSqlDataReader.Item("hora_almoco_quarta_termino")
                txtHoraAlmocoQuintaInicio.Text = oSqlDataReader.Item("hora_almoco_quinta")
                txtHoraAlmocoQuintaTermino.Text = oSqlDataReader.Item("hora_almoco_quinta_termino")
                txtHoraAlmocoSextaInicio.Text = oSqlDataReader.Item("hora_almoco_sexta")
                txtHoraAlmocoSextaTermino.Text = oSqlDataReader.Item("hora_almoco_sexta_termino")
                txtHoraAlmocoSabadoInicio.Text = oSqlDataReader.Item("hora_almoco_sabado")
                txtHoraAlmocoSabadoTermino.Text = oSqlDataReader.Item("hora_almoco_sabado_termino")
                txtHoraAlmocoDomingoInicio.Text = oSqlDataReader.Item("hora_almoco_domingo")
                txtHoraAlmocoDomingoTermino.Text = oSqlDataReader.Item("hora_almoco_domingo_termino")
                txtHoraIntervaloSegundaInicio.Text = oSqlDataReader.Item("hora_intervalo_segunda_inicio")
                txtHoraIntervaloTercaInicio.Text = oSqlDataReader.Item("hora_intervalo_terca_inicio")
                txtHoraIntervaloQuartaInicio.Text = oSqlDataReader.Item("hora_intervalo_quarta_inicio")
                txtHoraIntervaloQuintaInicio.Text = oSqlDataReader.Item("hora_intervalo_quinta_inicio")
                txtHoraIntervaloSextaInicio.Text = oSqlDataReader.Item("hora_intervalo_sexta_inicio")
                txtHoraIntervaloSabadoInicio.Text = oSqlDataReader.Item("hora_intervalo_sabado_inicio")
                txtHoraIntervaloDomingoInicio.Text = oSqlDataReader.Item("hora_intervalo_domingo_inicio")
                txtHoraIntervaloSegundaTermino.Text = oSqlDataReader.Item("hora_intervalo_segunda_termino")
                txtHoraIntervaloTercaTermino.Text = oSqlDataReader.Item("hora_intervalo_terca_termino")
                txtHoraIntervaloQuartaTermino.Text = oSqlDataReader.Item("hora_intervalo_quarta_termino")
                txtHoraIntervaloQuintaTermino.Text = oSqlDataReader.Item("hora_intervalo_quinta_termino")
                txtHoraIntervaloSextaTermino.Text = oSqlDataReader.Item("hora_intervalo_sexta_termino")
                txtHoraIntervaloSabadoTermino.Text = oSqlDataReader.Item("hora_intervalo_sabado_termino")
                txtHoraIntervaloDomingoTermino.Text = oSqlDataReader.Item("hora_intervalo_domingo_termino")
                txtHoraAdicionalNoturnoInicio.Text = oSqlDataReader.Item("adicional_inicio")
                txtHoraAdicionalNoturnoTermino.Text = oSqlDataReader.Item("adicional_termino")
                cboHoraExtraSegunda.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_segunda")
                txtHoraExtraAposSegunda.Value = oSqlDataReader.Item("hora_extra_apos_segunda")
                cboHoraExtraAposSegunda.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_segunda")
                cboHoraExtraTerca.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_terca")
                txtHoraExtraAposTerca.Value = oSqlDataReader.Item("hora_extra_apos_terca")
                cboHoraExtraAposTerca.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_terca")
                cboHoraExtraQuarta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_quarta")
                txtHoraExtraAposQuarta.Value = oSqlDataReader.Item("hora_extra_apos_quarta")
                cboHoraExtraAposQuarta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_quarta")
                cboHoraExtraQuinta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_quinta")
                txtHoraExtraAposQuinta.Value = oSqlDataReader.Item("hora_extra_apos_quinta")
                cboHoraExtraAposQuinta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_quinta")
                cboHoraExtraSexta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_sexta")
                txtHoraExtraAposSexta.Value = oSqlDataReader.Item("hora_extra_apos_sexta")
                cboHoraExtraAposSexta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_sexta")
                cboHoraExtraSabado.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_sabado")
                txtHoraExtraAposSabado.Value = oSqlDataReader.Item("hora_extra_apos_sabado")
                cboHoraExtraAposSabado.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_sabado")
                cboHoraExtraDomingo.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_domingo")
                txtHoraExtraAposDomingo.Value = oSqlDataReader.Item("hora_extra_apos_domingo")
                cboHoraExtraAposDomingo.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_domingo")

                'Carrega Foto
                If IsDBNull(oSqlDataReader.Item("foto")) = False Then
                    Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                    oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
                    picFoto.Image = Image.FromStream(stmBLOBData)
                End If

                If IsDBNull(oSqlDataReader.Item("foto_app")) = False Then
                    picFoto.Image = LoadImageFromBase64(oSqlDataReader.Item("foto_app"))
                End If

                If IsDBNull(oSqlDataReader.Item("ativo")) Then
                    cboAtivo.SelectedIndex = -1
                Else
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                End If

                If IsDBNull(oSqlDataReader.Item("codigo_nivel_permissao_app")) Then
                    cboNivelPermissaoAPP.SelectedIndex = -1
                Else
                    cboNivelPermissaoAPP.SelectedValue = oSqlDataReader.Item("codigo_nivel_permissao_app")
                End If

                txtEscolhasApontamento.Value = oSqlDataReader.Item("escolhas_apontamento_app")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosTurno(ByVal iCodigo As Integer,
                              ByVal txtHoraEntradaSegunda As MaskedEditBox,
                              ByVal txtHoraEntradaTerca As MaskedEditBox,
                              ByVal txtHoraEntradaQuarta As MaskedEditBox,
                              ByVal txtHoraEntradaQuinta As MaskedEditBox,
                              ByVal txtHoraEntradaSexta As MaskedEditBox,
                              ByVal txtHoraEntradaSabado As MaskedEditBox,
                              ByVal txtHoraEntradaDomingo As MaskedEditBox,
                              ByVal txtHoraSaidaSegunda As MaskedEditBox,
                              ByVal txtHoraSaidaTerca As MaskedEditBox,
                              ByVal txtHoraSaidaQuarta As MaskedEditBox,
                              ByVal txtHoraSaidaQuinta As MaskedEditBox,
                              ByVal txtHoraSaidaSexta As MaskedEditBox,
                              ByVal txtHoraSaidaSabado As MaskedEditBox,
                              ByVal txtHoraSaidaDomingo As MaskedEditBox,
                              ByVal txtHoraAlmocoSegundaInicio As MaskedEditBox,
                              ByVal txtHoraAlmocoTercaInicio As MaskedEditBox,
                              ByVal txtHoraAlmocoQuartaInicio As MaskedEditBox,
                              ByVal txtHoraAlmocoQuintaInicio As MaskedEditBox,
                              ByVal txtHoraAlmocoSextaInicio As MaskedEditBox,
                              ByVal txtHoraAlmocoSabadoInicio As MaskedEditBox,
                              ByVal txtHoraAlmocoDomingoInicio As MaskedEditBox,
                              ByVal txtHoraAlmocoSegundaTermino As MaskedEditBox,
                              ByVal txtHoraAlmocoTercaTermino As MaskedEditBox,
                              ByVal txtHoraAlmocoQuartaTermino As MaskedEditBox,
                              ByVal txtHoraAlmocoQuintaTermino As MaskedEditBox,
                              ByVal txtHoraAlmocoSextaTermino As MaskedEditBox,
                              ByVal txtHoraAlmocoSabadoTermino As MaskedEditBox,
                              ByVal txtHoraAlmocoDomingoTermino As MaskedEditBox,
                              ByVal txtHoraIntervaloSegundaInicio As MaskedEditBox,
                              ByVal txtHoraIntervaloTercaInicio As MaskedEditBox,
                              ByVal txtHoraIntervaloQuartaInicio As MaskedEditBox,
                              ByVal txtHoraIntervaloQuintaInicio As MaskedEditBox,
                              ByVal txtHoraIntervaloSextaInicio As MaskedEditBox,
                              ByVal txtHoraIntervaloSabadoInicio As MaskedEditBox,
                              ByVal txtHoraIntervaloDomingoInicio As MaskedEditBox,
                              ByVal txtHoraIntervaloSegundaTermino As MaskedEditBox,
                              ByVal txtHoraIntervaloTercaTermino As MaskedEditBox,
                              ByVal txtHoraIntervaloQuartaTermino As MaskedEditBox,
                              ByVal txtHoraIntervaloQuintaTermino As MaskedEditBox,
                              ByVal txtHoraIntervaloSextaTermino As MaskedEditBox,
                              ByVal txtHoraIntervaloSabadoTermino As MaskedEditBox,
                              ByVal txtHoraIntervaloDomingoTermino As MaskedEditBox,
                              ByVal txtHoraAdicionalNoturnoInicio As MaskedEditBox,
                              ByVal txtHoraAdicionalNoturnoTermino As MaskedEditBox,
                              ByVal cboHoraExtraSegunda As UIComboBox,
                              ByVal txtHoraExtraAposSegunda As NumericEditBox,
                              ByVal cboHoraExtraAposSegunda As UIComboBox,
                              ByVal cboHoraExtraTerca As UIComboBox,
                              ByVal txtHoraExtraAposTerca As NumericEditBox,
                              ByVal cboHoraExtraAposTerca As UIComboBox,
                              ByVal cboHoraExtraQuarta As UIComboBox,
                              ByVal txtHoraExtraAposQuarta As NumericEditBox,
                              ByVal cboHoraExtraAposQuarta As UIComboBox,
                              ByVal cboHoraExtraQuinta As UIComboBox,
                              ByVal txtHoraExtraAposQuinta As NumericEditBox,
                              ByVal cboHoraExtraAposQuinta As UIComboBox,
                              ByVal cboHoraExtraSexta As UIComboBox,
                              ByVal txtHoraExtraAposSexta As NumericEditBox,
                              ByVal cboHoraExtraAposSexta As UIComboBox,
                              ByVal cboHoraExtraSabado As UIComboBox,
                              ByVal txtHoraExtraAposSabado As NumericEditBox,
                              ByVal cboHoraExtraAposSabado As UIComboBox,
                              ByVal cboHoraExtraDomingo As UIComboBox,
                              ByVal txtHoraExtraAposDomingo As NumericEditBox,
                              ByVal cboHoraExtraAposDomingo As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_turno", oSqlParameter)

            While oSqlDataReader.Read

                'Preenche Controles
                txtHoraEntradaSegunda.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_segunda")) = True, "", oSqlDataReader.Item("entrada_segunda"))
                txtHoraEntradaTerca.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_terca")) = True, "", oSqlDataReader.Item("entrada_terca"))
                txtHoraEntradaQuarta.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_quarta")) = True, "", oSqlDataReader.Item("entrada_quarta"))
                txtHoraEntradaQuinta.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_quinta")) = True, "", oSqlDataReader.Item("entrada_quinta"))
                txtHoraEntradaSexta.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_sexta")) = True, "", oSqlDataReader.Item("entrada_sexta"))
                txtHoraEntradaSabado.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_sabado")) = True, "", oSqlDataReader.Item("entrada_sabado"))
                txtHoraEntradaDomingo.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_domingo")) = True, "", oSqlDataReader.Item("entrada_domingo"))
                txtHoraSaidaSegunda.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_segunda")) = True, "", oSqlDataReader.Item("saida_segunda"))
                txtHoraSaidaTerca.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_terca")) = True, "", oSqlDataReader.Item("saida_terca"))
                txtHoraSaidaQuarta.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_quarta")) = True, "", oSqlDataReader.Item("saida_quarta"))
                txtHoraSaidaQuinta.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_quinta")) = True, "", oSqlDataReader.Item("saida_quinta"))
                txtHoraSaidaSexta.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_sexta")) = True, "", oSqlDataReader.Item("saida_sexta"))
                txtHoraSaidaSabado.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_sabado")) = True, "", oSqlDataReader.Item("saida_sabado"))
                txtHoraSaidaDomingo.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_domingo")) = True, "", oSqlDataReader.Item("saida_domingo"))
                txtHoraAlmocoSegundaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_segunda_inicio")) = True, "", oSqlDataReader.Item("hora_almoco_segunda_inicio"))
                txtHoraAlmocoTercaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_terca_inicio")) = True, "", oSqlDataReader.Item("hora_almoco_terca_inicio"))
                txtHoraAlmocoQuartaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_quarta_inicio")) = True, "", oSqlDataReader.Item("hora_almoco_quarta_inicio"))
                txtHoraAlmocoQuintaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_quinta_inicio")) = True, "", oSqlDataReader.Item("hora_almoco_quinta_inicio"))
                txtHoraAlmocoSextaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_sexta_inicio")) = True, "", oSqlDataReader.Item("hora_almoco_sexta_inicio"))
                txtHoraAlmocoSabadoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_sabado_inicio")) = True, "", oSqlDataReader.Item("hora_almoco_sabado_inicio"))
                txtHoraAlmocoDomingoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_domingo_inicio")) = True, "", oSqlDataReader.Item("hora_almoco_domingo_inicio"))
                txtHoraAlmocoSegundaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_segunda_termino")) = True, "", oSqlDataReader.Item("hora_almoco_segunda_termino"))
                txtHoraAlmocoTercaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_terca_termino")) = True, "", oSqlDataReader.Item("hora_almoco_terca_termino"))
                txtHoraAlmocoQuartaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_quarta_termino")) = True, "", oSqlDataReader.Item("hora_almoco_quarta_termino"))
                txtHoraAlmocoQuintaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_quinta_termino")) = True, "", oSqlDataReader.Item("hora_almoco_quinta_termino"))
                txtHoraAlmocoSextaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_sexta_termino")) = True, "", oSqlDataReader.Item("hora_almoco_sexta_termino"))
                txtHoraAlmocoSabadoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_sabado_termino")) = True, "", oSqlDataReader.Item("hora_almoco_sabado_termino"))
                txtHoraAlmocoDomingoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_domingo_termino")) = True, "", oSqlDataReader.Item("hora_almoco_domingo_termino"))
                txtHoraIntervaloSegundaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_segunda_inicio")) = True, "", oSqlDataReader.Item("hora_intervalo_segunda_inicio"))
                txtHoraIntervaloTercaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_terca_inicio")) = True, "", oSqlDataReader.Item("hora_intervalo_terca_inicio"))
                txtHoraIntervaloQuartaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_quarta_inicio")) = True, "", oSqlDataReader.Item("hora_intervalo_quarta_inicio"))
                txtHoraIntervaloQuintaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_quinta_inicio")) = True, "", oSqlDataReader.Item("hora_intervalo_quinta_inicio"))
                txtHoraIntervaloSextaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_sexta_inicio")) = True, "", oSqlDataReader.Item("hora_intervalo_sexta_inicio"))
                txtHoraIntervaloSabadoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_sabado_inicio")) = True, "", oSqlDataReader.Item("hora_intervalo_sabado_inicio"))
                txtHoraIntervaloDomingoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_domingo_inicio")) = True, "", oSqlDataReader.Item("hora_intervalo_domingo_inicio"))
                txtHoraIntervaloSegundaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_segunda_termino")) = True, "", oSqlDataReader.Item("hora_intervalo_segunda_termino"))
                txtHoraIntervaloTercaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_terca_termino")) = True, "", oSqlDataReader.Item("hora_intervalo_terca_termino"))
                txtHoraIntervaloQuartaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_quarta_termino")) = True, "", oSqlDataReader.Item("hora_intervalo_quarta_termino"))
                txtHoraIntervaloQuintaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_quinta_termino")) = True, "", oSqlDataReader.Item("hora_intervalo_quinta_termino"))
                txtHoraIntervaloSextaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_sexta_termino")) = True, "", oSqlDataReader.Item("hora_intervalo_sexta_termino"))
                txtHoraIntervaloSabadoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_sabado_termino")) = True, "", oSqlDataReader.Item("hora_intervalo_sabado_termino"))
                txtHoraIntervaloDomingoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_domingo_termino")) = True, "", oSqlDataReader.Item("hora_intervalo_domingo_termino"))
                txtHoraAdicionalNoturnoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("adicional_inicio")) = True, "", oSqlDataReader.Item("adicional_inicio"))
                txtHoraAdicionalNoturnoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("adicional_termino")) = True, "", oSqlDataReader.Item("adicional_termino"))
                cboHoraExtraSegunda.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_segunda")
                txtHoraExtraAposSegunda.Value = oSqlDataReader.Item("hora_extra_apos_segunda")
                cboHoraExtraAposSegunda.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_segunda")
                cboHoraExtraTerca.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_terca")
                txtHoraExtraAposTerca.Value = oSqlDataReader.Item("hora_extra_apos_terca")
                cboHoraExtraAposTerca.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_terca")
                cboHoraExtraQuarta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_quarta")
                txtHoraExtraAposQuarta.Value = oSqlDataReader.Item("hora_extra_apos_quarta")
                cboHoraExtraAposQuarta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_quarta")
                cboHoraExtraQuinta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_quinta")
                txtHoraExtraAposQuinta.Value = oSqlDataReader.Item("hora_extra_apos_quinta")
                cboHoraExtraAposQuinta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_quinta")
                cboHoraExtraSexta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_sexta")
                txtHoraExtraAposSexta.Value = oSqlDataReader.Item("hora_extra_apos_sexta")
                cboHoraExtraAposSexta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_sexta")
                cboHoraExtraSabado.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_sabado")
                txtHoraExtraAposSabado.Value = oSqlDataReader.Item("hora_extra_apos_sabado")
                cboHoraExtraAposSabado.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_sabado")
                cboHoraExtraDomingo.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_domingo")
                txtHoraExtraAposDomingo.Value = oSqlDataReader.Item("hora_extra_apos_domingo")
                cboHoraExtraAposDomingo.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_domingo")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaProntuario(ByVal iCodigo As Integer,
                                     ByVal sProntuario As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaProntuario = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Prontuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prontuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sProntuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_funcionario", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaProntuario = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX,
                        ByVal sProntuario As String,
                        ByVal sNome As String,
                        ByVal sCPF As String,
                        ByVal sRG As String,
                        ByVal sOrgaoEmissor As String,
                        ByVal bAtivo As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Prontuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prontuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sProntuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNome : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCPF : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - RG
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRG : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Órgão Emissor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "orgao_emissor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sOrgaoEmissor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_funcionario"))

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCpf(ByVal lCodigo As Long,
                               ByVal sCPF As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaCpf = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Cnpj / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCPF : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_cpf_funcionario", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCpf = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function
#End Region

#Region "::: CENTRO DE TRABALHO \ OPERAÇÃO :::"

    Public Sub LoadGridOperacao(ByVal oGrid As GridEX,
                                ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_operacao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertOperacao(ByVal iCodigoCentroTrabalho As Integer,
                              ByVal iCodigoOperacao As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Centro Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - Código Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOperacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario_operacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateOperacao(ByVal iCodigoCentroTrabalho As Integer,
                              ByVal iCodigoOperacao As Integer,
                              ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Centro de Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - Código Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOperacao : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario_operacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteOperacao(ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Funcinário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoFuncionario : i += 1

                'Seta Parametros - Código Centro Trabalho
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_centro_trabalho").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario_operacao", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CONTA BANCÁRIA :::"

    Public Sub LoadGridContaBancaria(ByVal oGrid As GridEX,
                                     ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_banco_conta", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertContaBancaria(ByVal iCodigoBanco As Integer,
                                   ByVal iCodigoTipoContaBancaria As Integer,
                                   ByVal sAgencia As String,
                                   ByVal sConta As String,
                                   ByVal sDigitoControle As String,
                                   ByVal bContaPagamento As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBanco : i += 1

            'Seta Parametros - Código Tipo Conta Bancária
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_conta_bancaria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContaBancaria : i += 1

            'Seta Parametros - Agência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sAgencia : i += 1

            'Seta Parametros - Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sConta : i += 1

            'Seta Parametros - Dígito Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sDigitoControle : i += 1

            'Seta Parametros - Conta Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bContaPagamento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario_banco_conta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateContaBancaria(ByVal iCodigoBanco As Integer,
                                   ByVal iCodigoTipoContaBancaria As Integer,
                                   ByVal sAgencia As String,
                                   ByVal sConta As String,
                                   ByVal sDigitoControle As String,
                                   ByVal bContaPagamento As Boolean,
                                   ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBanco : i += 1

            'Seta Parametros - Código Tipo Conta Bancária
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_conta_bancaria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContaBancaria : i += 1

            'Seta Parametros - Agência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sAgencia : i += 1

            'Seta Parametros - Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sConta : i += 1

            'Seta Parametros - Dígito Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sDigitoControle : i += 1

            'Seta Parametros - Conta Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bContaPagamento : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario_banco_conta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteContaBancaria(ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Funcinário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoFuncionario : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario_banco_conta", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ATIVIDADE :::"

    Public Sub LoadGridAtividade(ByVal oGrid As GridEX,
                                  ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_atividade", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertAtividade(ByVal iCodigoAtividade As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Ajuda de Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_atividade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAtividade : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario_atividade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateAtividade(ByVal iCodigoAtividade As Integer,
                                ByVal iCodigoAtividadeAntigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Ajuda de Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_atividade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAtividade : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Ajuda de Custo Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_atividade_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAtividadeAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario_atividade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteAtividade(ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Funcinário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoFuncionario : i += 1

                'Seta Parametros - Código Ajuda de Custo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_atividade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario_atividade", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region


#Region "::: SALARIO :::"
    Public Sub LoadGridSalario(ByVal oGrid As GridEX,
                               ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_salario", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertSalario(ByVal sData As String,
                             ByVal dValor As Double,
                             ByVal bAtivo As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sData : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario_salario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateSalario(ByVal sData As String,
                             ByVal dValor As Double,
                             ByVal bAtivo As Boolean,
                             ByVal iCodigoSalario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Salario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoSalario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sData : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario_salario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteSalario(ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Funcinário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoFuncionario : i += 1 : ReDim Preserve oSqlParameter(i)

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario_salario", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: DEPENDENTE :::"

    Public Sub LoadGridDependente(ByVal oGrid As GridEX, _
                                  ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_dependente", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDependente(ByVal sNome As String, _
                                ByVal sParentesco As String, _
                                ByVal sDataNascimento As String, _
                                ByVal bIR As Boolean, _
                                ByVal bSalarioFamilia As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNome : i += 1

            'Seta Parametros - Parentesco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parentesco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sParentesco : i += 1

            'Seta Parametros - Data de Nascimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataNascimento), sDataNascimento, DBNull.Value) : i += 1

            'Seta Parametros - IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIR : i += 1

            'Seta Parametros - Salário Familia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "salario_familia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSalarioFamilia : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario_dependente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDependente(ByVal sNome As String, _
                                ByVal sParentesco As String, _
                                ByVal sDataNascimento As String, _
                                ByVal bIR As Boolean, _
                                ByVal bSalarioFamilia As Boolean, _
                                ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNome : i += 1

            'Seta Parametros - Parentesco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parentesco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sParentesco : i += 1

            'Seta Parametros - Data de Nascimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataNascimento), sDataNascimento, DBNull.Value) : i += 1

            'Seta Parametros - IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIR : i += 1

            'Seta Parametros - Salário Familia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "salario_familia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSalarioFamilia : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario_dependente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteDependente()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Funcinário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoFuncionario : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario_dependente", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DOCUMENTOS :::"

    Public Sub LoadGridDocumento(ByVal oGrid As GridEX, _
                                 ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_documento", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDocumento(ByVal iCodigoDocumento As Integer, _
                               ByVal sDocumento As String, _
                               ByVal sDescricao As String, _
                               ByVal sDataEmissao As String, _
                               ByVal sDataValidade As String, _
                               ByVal iAlertaAntecedencia As Integer, _
                               ByVal iCodigoTipoArquivo As Integer, _
                               ByVal sArquivoInteracti As String, _
                               ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoArquivo : i += 1

            'Seta Parametros - Código do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDocumento : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Data de Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissao), sDataEmissao, DBNull.Value) : i += 1

            'Seta Parametros - Data de Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade), sDataValidade, DBNull.Value) : i += 1

            'Seta Parametros - Alerta Antecedêncua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "alerta_antecedencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAlertaAntecedencia : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario_documento", oSqlParameter)

            iCodigoInsertDocumento = oSqlParameter(i).Value
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDocumento(ByVal iCodigoDocumento As Integer, _
                               ByVal sDocumento As String, _
                               ByVal sDescricao As String, _
                               ByVal sDataEmissao As String, _
                               ByVal sDataValidade As String, _
                               ByVal iAlertaAntecedencia As Integer, _
                               ByVal iCodigoTipoArquivo As Integer, _
                               ByVal sArquivoInteracti As String, _
                               ByVal sArquivo As String, _
                               ByVal sArquivoAntigo As String, _
                               ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoArquivo : i += 1

            'Seta Parametros - Código do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDocumento : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Data de Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissao), sDataEmissao, DBNull.Value) : i += 1

            'Seta Parametros - Data de Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade), sDataValidade, DBNull.Value) : i += 1

            'Seta Parametros - Alerta Antecedêncua
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "alerta_antecedencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAlertaAntecedencia : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Destino                
            If sArquivoInteracti <> "" Then
                sArquivoInteracti &= "FUN_" & Format(iCodigoFuncionario, "000000000") & "_" & sDocumento & "_" & sDescricao & sArquivo.Substring(sArquivo.LastIndexOf("."))
            End If

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_interacti"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoInteracti : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario_documento", oSqlParameter)

            'Copia Arquivo para a Pasta Desejada                
            If sArquivoInteracti <> "" And sArquivoInteracti.ToUpper <> sArquivo.ToUpper Then
                If System.IO.File.Exists(sArquivoInteracti) = True And sArquivoInteracti <> sArquivoAntigo Then
                    System.IO.File.Delete(sArquivoInteracti)
                End If
                System.IO.File.Copy(sArquivo, sArquivoInteracti)
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteDocumento(ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Funcinário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoFuncionario : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario_documento", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: AJUDA DE CUSTO :::"

    Public Sub LoadGridAjudaCusto(ByVal oGrid As GridEX, _
                                  ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_ajuda_custo", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertAjudaCusto(ByVal iCodigoAjudaCusto As Integer, _
                                ByVal dValor As Double, _
                                ByVal dDesconto As Double)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Ajuda de Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ajuda_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAjudaCusto : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDesconto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario_ajuda_custo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateAjudaCusto(ByVal iCodigoAjudaCusto As Integer, _
                                ByVal dValor As Double, _
                                ByVal dDesconto As Double, _
                                ByVal iCodigoAjudaCustoAntigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Ajuda de Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ajuda_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAjudaCusto : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDesconto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Ajuda de Custo Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ajuda_custo_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAjudaCustoAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario_ajuda_custo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteAjudaCusto(ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Funcinário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoFuncionario : i += 1

                'Seta Parametros - Código Ajuda de Custo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ajuda_custo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario_ajuda_custo", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: RATEIO :::"

    Public Sub LoadGridRateio(ByVal oGrid As GridEX, _
                              ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_rateio", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRateio(ByVal iCodigoCentroTrabalho As Integer, _
                            ByVal dPercentualRateio As Double)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Centro Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - % Rateio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_rateio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualRateio : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario_rateio", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRateio(ByVal iCodigoCentroTrabalho As Integer, _
                            ByVal dPercentualRateio As Double, _
                            ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Centro de Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - % Rateio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_rateio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentualRateio : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario_rateio", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteRateio(ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Funcinário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoFuncionario : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario_rateio", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FALTA :::"

    Public Sub LoadGridFalta(ByVal oGrid As GridEX, _
                             ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_falta", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega DataGrid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFalta(ByVal iCodigoTipoFalta As Integer, _
                           ByVal sDescricao As String, _
                           ByVal sData As String, _
                           ByVal dHoraInicio As Double, _
                           ByVal dHoraTermino As Double, _
                           ByVal iCodigoTipoArquivo As Integer, _
                           ByVal sArquivoInteracti As String, _
                           ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Tipo de Falta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_falta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoFalta : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Data 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Hora Início 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraInicio : i += 1

            'Seta Parametros - Hora Término 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraTermino : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoArquivo : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Arquivo Interacti
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_interacti"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivoInteracti : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_funcionario_falta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateFalta(ByVal iCodigoTipoFalta As Integer, _
                           ByVal sDescricao As String, _
                           ByVal sData As String, _
                           ByVal dHoraInicio As Double, _
                           ByVal dHoraTermino As Double, _
                           ByVal iCodigoTipoArquivo As Integer, _
                           ByVal sArquivoInteracti As String, _
                           ByVal sArquivo As String, _
                           ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFuncionario : i += 1

            'Seta Parametros - Código Tipo de Falta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_falta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoFalta : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Data 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData : i += 1
            
            'Seta Parametros - Hora Início 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraInicio : i += 1

            'Seta Parametros - Hora Término 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraTermino : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoArquivo : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Arquivo Interacti
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_interacti"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivoInteracti : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_funcionario_falta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteFalta(ByVal iCodigoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Funcinário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_funcionario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoFuncionario : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_funcionario_falta", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
