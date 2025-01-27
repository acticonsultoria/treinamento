Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports Janus.Windows.EditControls
Imports System.IO

Public Class clsUsrFatEmissaoNFe

#Region "::: VARIAVEIS :::"

#Region "::: VARIAVEIS - CAPA :::"

    'Variaveis da Classe - Capa
    Private lNotaFiscal As Long
    Private iCodigoModeloNotaFiscal As Integer
    Private iCodigoSequenciaNotaFiscal As Integer
    Private iSerie As Integer
    Private sDataEmissao As String
    Private sNaturezaOperacao As String
    Private sDataSaida As String
    Private iTipoItem As Integer
    Private iCodigoFormaEmissaoNFe As Integer
    Private iCodigoFinalidadeEmissaoNFe As Integer
    Private iCodigoFormaPagamento As Integer
    Private iCodigoTipoDocumentoFiscal As Integer
    Private iCodigoTipoOperacaoNFe As Integer
    Private iCodigoTipoConsumidor As Integer
    Private lCodigoEmissaoCapa As Long
    Private bPerforma As Boolean

#End Region

#Region "::: VARIAVEIS - DESTINATARIO :::"

    'Váriaveis da Classe - Destinatário
    Private lCodigoDestinatario As Long
    Private sRazaoSocialDestinatario As String
    Private sCnpjCpfDestinatario As String
    Private sLogradouroDestinatario As String
    Private sNumeroDestinatario As String
    Private sComplementoDestinatario As String
    Private sBairroDestinatario As String
    Private iCodigoMunicipioDestinatario As Integer
    Private sUFDestinatario As String
    Private sCepDestinatario As String
    Private iCodigoPaisDestinatario As Integer
    Private sTelefoneDestinatario As String
    Private sInscricaoEstadualDestinatario As String
    Private sInscricaoSuframaDestinatario As String
    Private sEmailDestinatario As String
    Private bOutroLugarRetirada As Boolean
    Private bOutroLugarEntrega As Boolean
    Private sIdentificacao As String

#End Region

#Region "::: VARIAVEIS - TRANSPORTE :::"

    'Váriaveis da Classe - Transporte
    Private iCodigoModalidadeFrete As Integer
    Private iCodigoTransportadora As Integer
    Private sRazaoSocialTransportadora As String
    Private sCnpjCpfTransportadora As String
    Private sInscricaoEstadualTransportadora As String
    Private sUFTransportadora As String
    Private sMunicipioTransportadora As String
    Private sEnderecoTransportadora As String
    Private dBaseCalculoTransporte As Double
    Private dAliquotaICMSTransporte As Double
    Private dValorServicoTransporte As Double
    Private dValorICMSRetidoTransporte As Double
    Private sUFICMSTransporte As String
    Private iCodigoMunicipioICMSTransporte As Integer
    Private iCodigoCFOPTransporte As Integer
    Private iTipoVeiculo As Integer
    Private sPlacaVeiculo As String
    Private sUFPlacaVeiculo As String
    Private sRNTCVeiculo As String
    Private sVagao As String
    Private sBalsa As String

#End Region

#Region "::: VARIAVEIS - TOTAL :::"

    'Váriaveis da Classe - Total
    Private dBaseCalculoICMS As Double
    Private dTotalICMS As Double
    Private dBaseCalculoICMSST As Double
    Private dTotalICMSST As Double
    Private dTotalProdutoServico As Double
    Private dTotalFrete As Double
    Private dTotalSeguro As Double
    Private dTotalDesconto As Double
    Private dTotalII As Double
    Private dTotalIPI As Double
    Private dPIS As Double
    Private dCOFINS As Double
    Private dOutrasDespesas As Double
    Private dTotalNotaFiscal As Double
    Private dValorRetidoPIS As Double
    Private dValorRetidoCOFINS As Double
    Private dValorRetidoCSLL As Double
    Private dBaseCalculoIRRF As Double
    Private dValorRetidoIRRF As Double
    Private dBaseCalculoRetencaoPrevidenciaSocial As Double
    Private dRetencaoPrevidenciaSocial As Double
    Private dBaseCalculoISS As Double
    Private dTotalISS As Double
    Private dPISSobreServico As Double
    Private dCOFINSSobreServico As Double
    Private dTotalServicoNaoTributadoICMS As Double

    'ICMS - Partilha
    Private dValorFCPICMSPartilha As Double
    Private dValorDestinoICMSPartilha As Double
    Private dValorRemetenteICMSPartilha As Double

#End Region

#Region "::: VARIAVEIS - INFORMAÇÕES ADICIONAIS :::"

    'Váriaveis da Classe - Informação Adicional
    Private sInformacaoAdicionalFisco As String
    Private sInformacaoAdicionalContribuinte As String

#End Region

#Region "::: VARIAVEIS - FATURA :::"

    'Váriaveis da Classe - Fatura
    Private sFatura As String
    Private dValorOriginal As Double
    Private dValorDesconto As Double
    Private dValorLiquido As Double
    Private iCodigoCondicaoPagamento As Integer
    Private iNumeroParcela As Integer
    Private iIntervaloParcela As Integer

#End Region

#Region "::: VARIAVEIS - EXPORTAÇÃO :::"

    'Váriaveis da Classe - EXPORTAÇÃO
    Private sUFEmbarque As String
    Private sLocalEmbarque As String

    Private sNumeroDrawbackExportacao As String
    Private sNumeroRE As String
    Private sChaveAcessoExportacao As String
    Private dQuantidadeExportacao As Double

#End Region

#Region "::: VARIAVEIS - COMPRAS :::"

    'Váriaveis da Classe - Fatura
    Private sNotaEmpenho As String
    Private sInformacaoPedido As String
    Private sInformacaoContrato As String

#End Region

#Region "::: VARIAVEIS - BOLETA :::"
    Private iCodigoBoleta As Integer
#End Region

#End Region

#Region "::: PROPERTIE :::"

#Region "::: PROPERTIE - CAPA :::"

    Public Property Performa() As Boolean
        Get
            Return bPerforma
        End Get
        Set(ByVal value As Boolean)
            bPerforma = value
        End Set
    End Property

    Public Property NotaFiscal() As Long
        Get
            Return lNotaFiscal
        End Get
        Set(ByVal value As Long)
            lNotaFiscal = value
        End Set
    End Property

    Public Property ModeloNotaFiscal() As Integer
        Get
            Return iCodigoModeloNotaFiscal
        End Get
        Set(ByVal value As Integer)
            iCodigoModeloNotaFiscal = value
        End Set
    End Property

    Public Property SequenciaNotaFiscal() As Integer
        Get
            Return iCodigoSequenciaNotaFiscal
        End Get
        Set(ByVal value As Integer)
            iCodigoSequenciaNotaFiscal = value
        End Set
    End Property

    Public Property Serie() As Integer
        Get
            Return iSerie
        End Get
        Set(ByVal value As Integer)
            iSerie = value
        End Set
    End Property

    Public Property DataEmissao() As String
        Get
            Return sDataEmissao
        End Get
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public Property NaturezaOperacao() As String
        Get
            Return sNaturezaOperacao
        End Get
        Set(ByVal value As String)
            sNaturezaOperacao = value
        End Set
    End Property

    Public Property DataSaida() As String
        Get
            Return sDataSaida
        End Get
        Set(ByVal value As String)
            sDataSaida = value
        End Set
    End Property

    Public Property FormaPagamento() As Integer
        Get
            Return iCodigoFormaPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamento = value
        End Set
    End Property

    Public Property TipoItem() As Integer
        Get
            Return iTipoItem
        End Get
        Set(ByVal value As Integer)
            iTipoItem = value
        End Set
    End Property

    Public Property CodigoFormaEmissaoNFe() As Integer
        Get
            Return iCodigoFormaEmissaoNFe
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaEmissaoNFe = value
        End Set
    End Property

    Public Property CodigoFinalidadeEmissaoNFe() As Integer
        Get
            Return iCodigoFinalidadeEmissaoNFe
        End Get
        Set(ByVal value As Integer)
            iCodigoFinalidadeEmissaoNFe = value
        End Set
    End Property

    Public Property CodigoFormaPagamento() As Integer
        Get
            Return iCodigoFormaPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamento = value
        End Set
    End Property

    Public Property CodigoTipoDocumentoFiscal() As Integer
        Get
            Return iCodigoTipoDocumentoFiscal
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoDocumentoFiscal = value
        End Set
    End Property
    Public Property CodigoTipoOperacaoNFe As Integer
        Get
            Return iCodigoTipoOperacaoNFe
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoOperacaoNFe = value
        End Set
    End Property
    Public Property CodigoTipoConsumidor As Integer
        Get
            Return iCodigoTipoConsumidor
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoConsumidor = value
        End Set
    End Property
    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - DESTINATÁRIO :::"

    Public Property CodigoDestinatario() As Long
        Get
            Return lCodigoDestinatario
        End Get
        Set(ByVal value As Long)
            lCodigoDestinatario = value
        End Set
    End Property

    Public Property RazaoSocialDestinatario() As String
        Get
            Return sRazaoSocialDestinatario
        End Get
        Set(ByVal value As String)
            sRazaoSocialDestinatario = value
        End Set
    End Property

    Public Property CnpjCpfDestinatario() As String
        Get
            Return sCnpjCpfDestinatario
        End Get
        Set(ByVal value As String)
            sCnpjCpfDestinatario = value
        End Set
    End Property

    Public Property LogradouroDestinatario() As String
        Get
            Return sLogradouroDestinatario
        End Get
        Set(ByVal value As String)
            sLogradouroDestinatario = value
        End Set
    End Property

    Public Property NumeroDestinatario() As String
        Get
            Return sNumeroDestinatario
        End Get
        Set(ByVal value As String)
            sNumeroDestinatario = value
        End Set
    End Property

    Public Property ComplementoDestinatario() As String
        Get
            Return sComplementoDestinatario
        End Get
        Set(ByVal value As String)
            sComplementoDestinatario = value
        End Set
    End Property

    Public Property BairroDestinatario() As String
        Get
            Return sBairroDestinatario
        End Get
        Set(ByVal value As String)
            sBairroDestinatario = value
        End Set
    End Property

    Public Property CodigoMunicipioDestinatario() As Integer
        Get
            Return iCodigoMunicipioDestinatario
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipioDestinatario = value
        End Set
    End Property

    Public Property UFDestinatario() As String
        Get
            Return sUFDestinatario
        End Get
        Set(ByVal value As String)
            sUFDestinatario = value
        End Set
    End Property

    Public Property CepDestinatario() As String
        Get
            Return sCepDestinatario
        End Get
        Set(ByVal value As String)
            sCepDestinatario = value
        End Set
    End Property

    Public Property CodigoPaisDestinatario() As Integer
        Get
            Return iCodigoPaisDestinatario
        End Get
        Set(ByVal value As Integer)
            iCodigoPaisDestinatario = value
        End Set
    End Property

    Public Property TelefoneDestinatario() As String
        Get
            Return sTelefoneDestinatario
        End Get
        Set(ByVal value As String)
            sTelefoneDestinatario = value
        End Set
    End Property

    Public Property InscricaoEstadualDestinatario() As String
        Get
            Return sInscricaoEstadualDestinatario
        End Get
        Set(ByVal value As String)
            sInscricaoEstadualDestinatario = value
        End Set
    End Property

    Public Property InscricaoSuframaDestinatario() As String
        Get
            Return sInscricaoSuframaDestinatario
        End Get
        Set(ByVal value As String)
            sInscricaoSuframaDestinatario = value
        End Set
    End Property

    Public Property EmailDestinatario() As String
        Get
            Return sEmailDestinatario
        End Get
        Set(ByVal value As String)
            sEmailDestinatario = value
        End Set
    End Property

    Public Property OutroLugarRetirada() As Boolean
        Get
            Return bOutroLugarRetirada
        End Get
        Set(ByVal value As Boolean)
            bOutroLugarRetirada = value
        End Set
    End Property

    Public Property OutroLugarEntrega() As Boolean
        Get
            Return bOutroLugarEntrega
        End Get
        Set(ByVal value As Boolean)
            bOutroLugarEntrega = value
        End Set
    End Property

    Public Property Identificacao() As String
        Get
            Return sIdentificacao
        End Get
        Set(ByVal value As String)
            sIdentificacao = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - TRANSPORTE :::"

    Public Property CodigoModalidadeFrete() As Integer
        Get
            Return iCodigoModalidadeFrete
        End Get
        Set(ByVal value As Integer)
            iCodigoModalidadeFrete = value
        End Set
    End Property

    Public Property CodigoTransportadora() As Integer
        Get
            Return iCodigoTransportadora
        End Get
        Set(ByVal value As Integer)
            iCodigoTransportadora = value
        End Set
    End Property

    Public Property RazaoSocialTransportadora() As String
        Get
            Return sRazaoSocialTransportadora
        End Get
        Set(ByVal value As String)
            sRazaoSocialTransportadora = value
        End Set
    End Property

    Public Property CnpjCpfTransportadora() As String
        Get
            Return sCnpjCpfTransportadora
        End Get
        Set(ByVal value As String)
            sCnpjCpfTransportadora = value
        End Set
    End Property

    Public Property InscricaoEstadualTransportadora() As String
        Get
            Return sInscricaoEstadualTransportadora
        End Get
        Set(ByVal value As String)
            sInscricaoEstadualTransportadora = value
        End Set
    End Property

    Public Property UFTransportadora() As String
        Get
            Return sUFTransportadora
        End Get
        Set(ByVal value As String)
            sUFTransportadora = value
        End Set
    End Property

    Public Property MunicipioTransportadora() As String
        Get
            Return sMunicipioTransportadora
        End Get
        Set(ByVal value As String)
            sMunicipioTransportadora = value
        End Set
    End Property

    Public Property EnderecoTransportadora() As String
        Get
            Return sEnderecoTransportadora
        End Get
        Set(ByVal value As String)
            sEnderecoTransportadora = value
        End Set
    End Property

    Public Property BaseCalculoTransporte() As Double
        Get
            Return dBaseCalculoTransporte
        End Get
        Set(ByVal value As Double)
            dBaseCalculoTransporte = value
        End Set
    End Property

    Public Property AliquotaICMSTransporte() As Double
        Get
            Return dAliquotaICMSTransporte
        End Get
        Set(ByVal value As Double)
            dAliquotaICMSTransporte = value
        End Set
    End Property

    Public Property ValorServicoTransporte() As Double
        Get
            Return dValorServicoTransporte
        End Get
        Set(ByVal value As Double)
            dValorServicoTransporte = value
        End Set
    End Property

    Public Property ValorICMSRetidoTransporte() As Double
        Get
            Return dValorICMSRetidoTransporte
        End Get
        Set(ByVal value As Double)
            dValorICMSRetidoTransporte = value
        End Set
    End Property

    Public Property UFICMSTransporte() As String
        Get
            Return sUFICMSTransporte
        End Get
        Set(ByVal value As String)
            sUFICMSTransporte = value
        End Set
    End Property

    Public Property CodigoMunicipioICMSTransporte() As Integer
        Get
            Return iCodigoMunicipioICMSTransporte
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipioICMSTransporte = value
        End Set
    End Property

    Public Property CodigoCFOPTransporte() As Integer
        Get
            Return iCodigoCFOPTransporte
        End Get
        Set(ByVal value As Integer)
            iCodigoCFOPTransporte = value
        End Set
    End Property

    Public Property TipoVeiculo() As Integer
        Get
            Return iTipoVeiculo
        End Get
        Set(ByVal value As Integer)
            iTipoVeiculo = value
        End Set
    End Property

    Public Property PlacaVeiculo() As String
        Get
            Return sPlacaVeiculo
        End Get
        Set(ByVal value As String)
            sPlacaVeiculo = value
        End Set
    End Property

    Public Property UFPlacaVeiculo() As String
        Get
            Return sUFPlacaVeiculo
        End Get
        Set(ByVal value As String)
            sUFPlacaVeiculo = value
        End Set
    End Property

    Public Property RNTCVeiculo() As String
        Get
            Return sRNTCVeiculo
        End Get
        Set(ByVal value As String)
            sRNTCVeiculo = value
        End Set
    End Property

    Public Property Vagao() As String
        Get
            Return sVagao
        End Get
        Set(ByVal value As String)
            sVagao = value
        End Set
    End Property

    Public Property Balsa() As String
        Get
            Return sBalsa
        End Get
        Set(ByVal value As String)
            sBalsa = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - TOTAL :::"

    Public Property BaseCalculoICMS() As Double
        Get
            Return dBaseCalculoICMS
        End Get
        Set(ByVal value As Double)
            dBaseCalculoICMS = value
        End Set
    End Property

    Public Property TotalICMS() As Double
        Get
            Return dTotalICMS
        End Get
        Set(ByVal value As Double)
            dTotalICMS = value
        End Set
    End Property

    Public Property BaseCalculoICMSST() As Double
        Get
            Return dBaseCalculoICMSST
        End Get
        Set(ByVal value As Double)
            dBaseCalculoICMSST = value
        End Set
    End Property

    Public Property TotalICMSST() As Double
        Get
            Return dTotalICMSST
        End Get
        Set(ByVal value As Double)
            dTotalICMSST = value
        End Set
    End Property

    Public Property TotalProdutoServico() As Double
        Get
            Return dTotalProdutoServico
        End Get
        Set(ByVal value As Double)
            dTotalProdutoServico = value
        End Set
    End Property

    Public Property TotalFrete() As Double
        Get
            Return dTotalFrete
        End Get
        Set(ByVal value As Double)
            dTotalFrete = value
        End Set
    End Property

    Public Property TotalSeguro() As Double
        Get
            Return dTotalSeguro
        End Get
        Set(ByVal value As Double)
            dTotalSeguro = value
        End Set
    End Property

    Public Property TotalDesconto() As Double
        Get
            Return dTotalDesconto
        End Get
        Set(ByVal value As Double)
            dTotalDesconto = value
        End Set
    End Property

    Public Property TotalII() As Double
        Get
            Return dTotalII
        End Get
        Set(ByVal value As Double)
            dTotalII = value
        End Set
    End Property

    Public Property TotalIPI() As Double
        Get
            Return dTotalIPI
        End Get
        Set(ByVal value As Double)
            dTotalIPI = value
        End Set
    End Property

    Public Property PIS() As Double
        Get
            Return dPIS
        End Get
        Set(ByVal value As Double)
            dPIS = value
        End Set
    End Property

    Public Property COFINS() As Double
        Get
            Return dCOFINS
        End Get
        Set(ByVal value As Double)
            dCOFINS = value
        End Set
    End Property

    Public Property OutrasDespesas() As Double
        Get
            Return dOutrasDespesas
        End Get
        Set(ByVal value As Double)
            dOutrasDespesas = value
        End Set
    End Property


    Public Property TotalNotaFiscal() As Double
        Get
            Return dTotalNotaFiscal
        End Get
        Set(ByVal value As Double)
            dTotalNotaFiscal = value
        End Set
    End Property

    Public Property ValorRetidoPIS() As Double
        Get
            Return dValorRetidoPIS
        End Get
        Set(ByVal value As Double)
            dValorRetidoPIS = value
        End Set
    End Property

    Public Property ValorRetidoCOFINS() As Double
        Get
            Return dValorRetidoCOFINS
        End Get
        Set(ByVal value As Double)
            dValorRetidoCOFINS = value
        End Set
    End Property

    Public Property ValorRetidoCSLL() As Double
        Get
            Return dValorRetidoCSLL
        End Get
        Set(ByVal value As Double)
            dValorRetidoCSLL = value
        End Set
    End Property

    Public Property BaseCalculoIRRF() As Double
        Get
            Return dBaseCalculoIRRF
        End Get
        Set(ByVal value As Double)
            dBaseCalculoIRRF = value
        End Set
    End Property

    Public Property ValorRetidoIRRF() As Double
        Get
            Return dValorRetidoIRRF
        End Get
        Set(ByVal value As Double)
            dValorRetidoIRRF = value
        End Set
    End Property

    Public Property BaseCalculoRetencaoPrevidenciaSocial() As Double
        Get
            Return dBaseCalculoRetencaoPrevidenciaSocial
        End Get
        Set(ByVal value As Double)
            dBaseCalculoRetencaoPrevidenciaSocial = value
        End Set
    End Property

    Public Property RetencaoPrevidenciaSocial() As Double
        Get
            Return dRetencaoPrevidenciaSocial
        End Get
        Set(ByVal value As Double)
            dRetencaoPrevidenciaSocial = value
        End Set
    End Property

    Public Property BaseCalculoISS() As Double
        Get
            Return dBaseCalculoISS
        End Get
        Set(ByVal value As Double)
            dBaseCalculoISS = value
        End Set
    End Property

    Public Property TotalISS() As Double
        Get
            Return dTotalISS
        End Get
        Set(ByVal value As Double)
            dTotalISS = value
        End Set
    End Property

    Public Property PISSobreServico() As Double
        Get
            Return dPISSobreServico
        End Get
        Set(ByVal value As Double)
            dPISSobreServico = value
        End Set
    End Property

    Public Property COFINSSobreServico() As Double
        Get
            Return dCOFINSSobreServico
        End Get
        Set(ByVal value As Double)
            dCOFINSSobreServico = value
        End Set
    End Property

    Public Property TotalServicoNaoTributadoICMS() As Double
        Get
            Return dTotalServicoNaoTributadoICMS
        End Get
        Set(ByVal value As Double)
            dTotalServicoNaoTributadoICMS = value
        End Set
    End Property

#Region "::: TOTAL - ICMS PARTILHA :::"

    Public Property ValorFCPICMSPartilha() As Double
        Get
            Return dValorFCPICMSPartilha
        End Get
        Set(ByVal value As Double)
            dValorFCPICMSPartilha = value
        End Set
    End Property

    Public Property ValorDestinoICMSPartilha() As Double
        Get
            Return dValorDestinoICMSPartilha
        End Get
        Set(ByVal value As Double)
            dValorDestinoICMSPartilha = value
        End Set
    End Property

    Public Property ValorRemetenteICMSPartilha() As Double
        Get
            Return dValorRemetenteICMSPartilha
        End Get
        Set(ByVal value As Double)
            dValorRemetenteICMSPartilha = value
        End Set
    End Property

#End Region

#End Region

#Region "::: PROPERTIE - INFORMAÇÃO ADICIONAL :::"

    Public Property InformacaoAdicionalFisco() As String
        Get
            Return sInformacaoAdicionalFisco
        End Get
        Set(ByVal value As String)
            sInformacaoAdicionalFisco = value
        End Set
    End Property

    Public Property InformacaoAdicionalContribuinte() As String
        Get
            Return sInformacaoAdicionalContribuinte
        End Get
        Set(ByVal value As String)
            sInformacaoAdicionalContribuinte = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - FATURA :::"

    Public Property Fatura() As String
        Get
            Return sFatura
        End Get
        Set(ByVal value As String)
            sFatura = value
        End Set
    End Property

    Public Property ValorOriginal() As Double
        Get
            Return dValorOriginal
        End Get
        Set(ByVal value As Double)
            dValorOriginal = value
        End Set
    End Property

    Public Property ValorDesconto() As Double
        Get
            Return dValorDesconto
        End Get
        Set(ByVal value As Double)
            dValorDesconto = value
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

    Public Property NumeroParcela() As Integer
        Get
            Return iNumeroParcela
        End Get
        Set(ByVal value As Integer)
            iNumeroParcela = value
        End Set
    End Property

    Public Property CodigoCondicaoPagamento() As Integer
        Get
            Return iCodigoCondicaoPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoCondicaoPagamento = value
        End Set
    End Property

    Public Property IntervaloParcela() As Integer
        Get
            Return iIntervaloParcela
        End Get
        Set(ByVal value As Integer)
            iIntervaloParcela = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - EXPORTAÇÃO :::"

    Public Property UFEmbarque() As String
        Get
            Return sUFEmbarque
        End Get
        Set(ByVal value As String)
            sUFEmbarque = value
        End Set
    End Property

    Public Property LocalEmbarque() As String
        Get
            Return sLocalEmbarque
        End Get
        Set(ByVal value As String)
            sLocalEmbarque = value
        End Set
    End Property

    Public Property NumeroDrawbackExportacao As String
        Get
            Return sNumeroDrawbackExportacao
        End Get
        Set(ByVal value As String)
            sNumeroDrawbackExportacao = value
        End Set
    End Property
    Public Property NumeroRE As String
        Get
            Return sNumeroRE
        End Get
        Set(ByVal value As String)
            sNumeroRE = value
        End Set
    End Property
    Public Property ChaveAcessoExportacao As String
        Get
            Return sChaveAcessoExportacao
        End Get
        Set(ByVal value As String)
            sChaveAcessoExportacao = value
        End Set
    End Property
    Public Property QuantidadeExportacao As Double
        Get
            Return dQuantidadeExportacao
        End Get
        Set(ByVal value As Double)
            dQuantidadeExportacao = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - COMPRAS :::"

    Public Property NotaEmpenho() As String
        Get
            Return sNotaEmpenho
        End Get
        Set(ByVal value As String)
            sNotaEmpenho = value
        End Set
    End Property

    Public Property InformacaoPedido() As String
        Get
            Return sInformacaoPedido
        End Get
        Set(ByVal value As String)
            sInformacaoPedido = value
        End Set
    End Property

    Public Property InformacaoContrato() As String
        Get
            Return sInformacaoContrato
        End Get
        Set(ByVal value As String)
            sInformacaoContrato = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - BOLETA :::"
    Public Property CodigoBoleta() As Integer
        Get
            Return iCodigoBoleta
        End Get
        Set(ByVal value As Integer)
            iCodigoBoleta = value
        End Set
    End Property
#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: NOTA FISCAL :::"

    Public Function ValidaNumeracaoNFe(ByVal sNotaFiscal As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim iRetorno As Integer = 0
        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = snotafiscal

            'Executa Query
            iRetorno = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_emissao_numeracao_nota_fiscal", oSqlParameter)

            'Retorno da Função
            Return IIf(iRetorno = 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub ExcluirNumeracaoNFe(ByVal sNotaFiscal As String)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = sNotaFiscal

            'Executa Query
            executenonquery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_numeracao_nota_fiscal", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNotaFiscal As Long, _
                        ByVal sSerie As String, _
                        ByVal sDestinatario As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sCodigoProduto As String, _
                        ByVal sLote As String, _
                        ByVal iCodigoTipoDocumentoFiscal As Integer, _
                        ByVal sCFOP As String, _
                        ByVal sStatus As String, _
                        ByVal sTipoDocumentoFaturado As String, _
                        ByVal sNaturezaOperacao As String, _
                        ByVal sNumeroPedido As String, _
                        ByVal lNotaFiscalReferenciada As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Destinatário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "destinatario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sDestinatario : i += 1

            'Seta Parametros - Data de Emissão - Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissaoInicio = "", DBNull.Value, sDataEmissaoInicio) : i += 1

            'Seta Parametros - Data de Emissão - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissaoTermino = "", DBNull.Value, sDataEmissaoTermino) : i += 1

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sCodigoProduto : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sLote : i += 1

            'Seta Parametros - Código Tipo Documento Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoDocumentoFiscal : i += 1

            'Seta Parametros - CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCFOP : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Tipo Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento_faturado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sTipoDocumentoFaturado : i += 1

            'Seta Parametros - Natureza da Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "natureza_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNaturezaOperacao : i += 1

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroPedido : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - NF Referenciada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nf_referenciada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscalReferenciada : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_emissao_capa"))

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertNotaFiscal()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNotaFiscalEletronica.AguardandoTransmissao : i += 1

            'Seta Parametros - Código Tipo Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = TipoNotaFiscal.NotaFiscalEletronica : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_capa", oSqlParameter)

            'Seta Váriavel 
            lCodigoEmissaoCapa = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateNotaFiscal()

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Modelo Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloNotaFiscal : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Código Sequência Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_numeracao_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoSequenciaNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSerie : i += 1

            'Seta Parametros - Data de Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissao : i += 1

            'Seta Parametros - Natureza da Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "natureza_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNaturezaOperacao : i += 1

            'Seta Parametros - Data de Saída
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_saida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataSaida = "", DBNull.Value, sDataSaida) : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoItem : i += 1

            'Seta Parametros - Código Forma Emissão NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_emissao_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaEmissaoNFe : i += 1

            'Seta Parametros - Código Finalidade Emissão NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_finalidade_emissao_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFinalidadeEmissaoNFe : i += 1

            'Seta Parametros - Código Forma Pagamento NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaPagamento : i += 1

            'Seta Parametros - Código Tipo Documento Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoDocumentoFiscal : i += 1

            'Seta Parametros - Forma de Impressão do DANFE NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_impressao_danfe_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goConfiguracaoNFe.iFormatoImpressaoDANFE : i += 1

            'Seta Parametros - Código Tipo Operacao NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoOperacaoNFe : i += 1

            'Seta Parametros - Código Tipo Consumidor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_consumidor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoConsumidor : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteNotaFiscal()

        Try

            'Variaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim i As Integer

            'Exclui Registro
            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_capa", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNF(ByVal cboModelo As UIComboBox, _
                           ByVal cboSerie As UIComboBox, _
                           ByVal txtNotaFiscal As MaskedEditBox, _
                           ByVal dtpDataEmissao As CalendarCombo, _
                           ByVal cboNaturezaOperacao As UIComboBox, _
                           ByVal cboTipoDocumento As UIComboBox, _
                           ByVal dtpDataSaida As CalendarCombo, _
                           ByVal cboFormaEmissao As UIComboBox, _
                           ByVal cboFinalidadeEmissao As UIComboBox, _
                           ByVal cboTipoOperacaoNFe As UIComboBox, _
                           ByVal cboTipoConsumidor As UIComboBox, _
                           ByVal cboDestinatario As UIComboBox, _
                           ByVal chkLocalRetirada As UICheckBox, _
                           ByVal chkLocalEntrega As UICheckBox, _
                           ByVal cboModalidadeFrete As UIComboBox, _
                           ByVal cboTransportadora As UIComboBox, _
                           ByVal txtBaseCalculoTransporte As NumericEditBox, _
                           ByVal txtAliquotaTransporte As NumericEditBox, _
                           ByVal txtValorServicoTransporte As NumericEditBox, _
                           ByVal cboUFICMSTransporte As UIComboBox, _
                           ByVal cboMunicipioICMSTransporte As UIComboBox, _
                           ByVal cboCFOPICMSTransporte As UIComboBox, _
                           ByVal txtICMSRetidoTransporte As NumericEditBox, _
                           ByVal cboTipoVeiculo As UIComboBox, _
                           ByVal txtPlacaVeiculo As MaskedEditBox, _
                           ByVal cboUFVeiculo As UIComboBox, _
                           ByVal txtRNTCVeiculo As MaskedEditBox, _
                           ByVal txtBalsa As MaskedEditBox, _
                           ByVal txtVagao As MaskedEditBox, _
                           ByVal txtBaseCalculoICMS As NumericEditBox, _
                           ByVal txtTotalICMS As NumericEditBox, _
                           ByVal txtBaseCalculoICMSST As NumericEditBox, _
                           ByVal txtTotalICMSST As NumericEditBox, _
                           ByVal txtTotalProdutoServico As NumericEditBox, _
                           ByVal txtTotalFrete As NumericEditBox, _
                           ByVal txtTotalSeguro As NumericEditBox, _
                           ByVal txtTotalDesconto As NumericEditBox, _
                           ByVal txtTotalII As NumericEditBox, _
                           ByVal txtTotalIPI As NumericEditBox, _
                           ByVal txtTotalPIS As NumericEditBox, _
                           ByVal txtTotalCOFINS As NumericEditBox, _
                           ByVal txtOutrasDespesas As NumericEditBox, _
                           ByVal txtTotalNotaFiscal As NumericEditBox, _
                           ByVal txtFatura As MaskedEditBox, _
                           ByVal txtValorOriginal As NumericEditBox, _
                           ByVal txtValorDesconto As NumericEditBox, _
                           ByVal txtValorLiquido As NumericEditBox, _
                           ByVal cboCondicaoPagamento As UIComboBox, _
                           ByVal cboFormaPagamento As UIComboBox, _
                           ByVal txtNumeroParcela As NumericEditBox, _
                           ByVal txtIntervaloEntreParcelas As NumericEditBox, _
                           ByVal cboUFEmbarque As UIComboBox, _
                           ByVal txtLocalEmbarque As MaskedEditBox, _
                           ByVal txtNumeroDrawbackExportacao As MaskedEditBox, _
                           ByVal txtNumeroRE As MaskedEditBox, _
                           ByVal txtChaveAcessoExportacao As MaskedEditBox, _
                           ByVal txtQuantidadeExportacao As NumericEditBox, _
                           ByVal txtInformacaoAdicionalContribuinte As EditBox, _
                           ByVal txtInformacaoAdicionalFisco As EditBox, _
                           ByVal txtStatusNFe As MaskedEditBox, _
                           ByVal txtMensagemSefaz As MaskedEditBox, _
                           ByVal txtChaveAcesso As MaskedEditBox, _
                           ByVal txtRecibo As MaskedEditBox, _
                           ByVal txtLote As MaskedEditBox, _
                           ByVal txtProtocolo As MaskedEditBox, _
                           ByVal txtIdentificacao As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_dados", oSqlParameter)

            While oSqlDataReader.Read

                lCodigoEmissaoCapa = lCodigoEmissaoCapa
                cboModelo.SelectedValue = oSqlDataReader("codigo_modelo_nota_fiscal")
                cboSerie.SelectedValue = oSqlDataReader("codigo_numeracao_nota_fiscal")
                cboSerie.Tag = lCodigoEmissaoCapa
                txtNotaFiscal.Text = oSqlDataReader("nota_fiscal")
                If IsDBNull(oSqlDataReader("data_emissao")) = False Then dtpDataEmissao.Value = oSqlDataReader("data_emissao")
                If IsDBNull(oSqlDataReader("natureza_operacao")) = False Then cboNaturezaOperacao.Text = oSqlDataReader("natureza_operacao")
                cboTipoDocumento.SelectedValue = oSqlDataReader("codigo_tipo_documento_fiscal")
                If IsDBNull(oSqlDataReader("data_saida")) Then
                    dtpDataSaida.Value = Now.Date : dtpDataSaida.Checked = False
                Else
                    dtpDataSaida.Value = oSqlDataReader("data_saida") : dtpDataSaida.Checked = True
                End If
                cboFormaEmissao.SelectedValue = oSqlDataReader("codigo_forma_emissao_nfe")
                cboFinalidadeEmissao.SelectedValue = oSqlDataReader("codigo_finalidade_emissao_nfe")
                cboTipoOperacaoNFe.SelectedValue = oSqlDataReader("codigo_tipo_operacao_nfe")
                cboTipoConsumidor.SelectedValue = oSqlDataReader("codigo_tipo_consumidor")
                cboDestinatario.SelectedValue = oSqlDataReader("codigo_destinatario")
                chkLocalRetirada.Checked = oSqlDataReader("outro_lugar_retirada")
                chkLocalEntrega.Checked = oSqlDataReader("outro_lugar_entrega")
                cboModalidadeFrete.SelectedValue = oSqlDataReader("codigo_modalidade_frete")
                cboTransportadora.SelectedValue = oSqlDataReader("codigo_transportadora")
                txtBaseCalculoTransporte.Value = oSqlDataReader("base_calculo_transporte")
                txtAliquotaTransporte.Value = oSqlDataReader("aliquota_transporte")
                txtValorServicoTransporte.Value = oSqlDataReader("valor_servico_transporte")
                cboUFICMSTransporte.SelectedValue = oSqlDataReader("uf_fator_gerador")
                cboMunicipioICMSTransporte.SelectedValue = oSqlDataReader("codigo_municipio_fator_gerador")
                cboCFOPICMSTransporte.SelectedValue = oSqlDataReader("cfop")
                txtICMSRetidoTransporte.Value = oSqlDataReader("valor_icms_retido")
                cboTipoVeiculo.SelectedValue = oSqlDataReader("codigo_tipo_veiculo")
                txtPlacaVeiculo.Text = oSqlDataReader("placa")
                cboUFVeiculo.SelectedValue = oSqlDataReader("uf_placa")
                txtRNTCVeiculo.Text = oSqlDataReader("rntc")
                txtBalsa.Text = oSqlDataReader("balsa")
                txtVagao.Text = oSqlDataReader("vagao")
                txtBaseCalculoICMS.Value = oSqlDataReader("base_calculo_icms")
                txtTotalICMS.Value = oSqlDataReader("total_icms")
                txtBaseCalculoICMSST.Value = oSqlDataReader("base_calculo_icms_st")
                txtTotalICMSST.Value = oSqlDataReader("total_icms_st")
                txtTotalProdutoServico.Value = oSqlDataReader("total_produto_servico")
                txtTotalFrete.Value = oSqlDataReader("total_frete")
                txtTotalSeguro.Value = oSqlDataReader("total_seguro")
                txtTotalDesconto.Value = oSqlDataReader("total_desconto")
                txtTotalII.Value = oSqlDataReader("total_ii")
                txtTotalIPI.Value = oSqlDataReader("total_ipi")
                txtTotalPIS.Value = oSqlDataReader("pis")
                txtTotalCOFINS.Value = oSqlDataReader("cofins")
                txtOutrasDespesas.Value = oSqlDataReader("outras_despesas")

                txtTotalNotaFiscal.Value = oSqlDataReader("total_nota_fiscal")
                txtFatura.Text = oSqlDataReader("fatura")
                txtValorOriginal.Value = oSqlDataReader("valor_original")
                txtValorDesconto.Value = oSqlDataReader("valor_desconto")
                txtValorLiquido.Value = oSqlDataReader("valor_liquido")
                cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                cboFormaPagamento.SelectedValue = oSqlDataReader("codigo_forma_pagamento_nfe")
                txtNumeroParcela.Value = oSqlDataReader("numero_parcela")
                txtIntervaloEntreParcelas.Value = oSqlDataReader("intervalo_parcela")

                'Exportação
                If IsDBNull(oSqlDataReader.Item("uf_embarque")) = False Then
                    cboUFEmbarque.SelectedValue = oSqlDataReader("uf_embarque")
                    txtLocalEmbarque.Text = oSqlDataReader("local_embarque")
                    txtNumeroDrawbackExportacao.Text = oSqlDataReader.Item("numero_drawback_exportacao")
                    txtNumeroRE.Text = oSqlDataReader.Item("numero_re")
                    txtChaveAcessoExportacao.Text = oSqlDataReader("chave_acesso_exportacao")
                    txtQuantidadeExportacao.Value = oSqlDataReader("quantidade_exportacao")
                End If

                If IsDBNull(oSqlDataReader("informacao_adicional_contribuinte")) = False Then txtInformacaoAdicionalContribuinte.Text = oSqlDataReader("informacao_adicional_contribuinte")
                If IsDBNull(oSqlDataReader("informacao_adicional_fisco")) = False Then txtInformacaoAdicionalFisco.Text = oSqlDataReader("informacao_adicional_fisco")
                txtStatusNFe.Tag = oSqlDataReader("status")
                txtMensagemSefaz.Text = IIf(IsDBNull(oSqlDataReader("mensagem_sefaz")), "", oSqlDataReader("mensagem_sefaz"))
                txtChaveAcesso.Text = IIf(IsDBNull(oSqlDataReader("chave_acesso")), "", oSqlDataReader("chave_acesso"))
                txtRecibo.Text = IIf(IsDBNull(oSqlDataReader("recibo_nfe")), "", oSqlDataReader("recibo_nfe"))
                txtLote.Text = IIf(IsDBNull(oSqlDataReader("lote_nfe")), "", oSqlDataReader("lote_nfe"))
                txtProtocolo.Text = IIf(IsDBNull(oSqlDataReader("protocolo_nfe")), "", oSqlDataReader("protocolo_nfe"))
                txtIdentificacao.Text = oSqlDataReader("identificacao")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNFe(ByVal lCodigo As Long, _
                            ByRef sArquivoNFe As String, _
                            ByRef sArquivoProtocoloNFe As String, _
                            ByRef sArquivoCancelamentoNFe As String, _
                            ByRef sArquivoProtocoloCancelamentoNFe As String, _
                            ByRef sChaveAcess As String, _
                            ByRef sNotaFiscal As String, _
                            ByRef lCodigoParceiroNegocio As Long, _
                            ByRef lCodigoTituloCala As Long, _
                            Optional ByRef sTexto As String = "")

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_dados_nfe", oSqlParameter)

            While oSqlDataReader.Read

                sArquivoNFe = oSqlDataReader.Item("xml_transmissao")
                sArquivoProtocoloNFe = oSqlDataReader.Item("xml_protocolo")
                sArquivoCancelamentoNFe = oSqlDataReader.Item("xml_transmissao_cancelamento")
                sArquivoProtocoloCancelamentoNFe = oSqlDataReader.Item("xml_protocolo_cancelamento")
                sChaveAcess = oSqlDataReader.Item("chave_acesso")
                sNotaFiscal = "NF" & Format(oSqlDataReader.Item("nota_fiscal"), "000000000")
                lCodigoParceiroNegocio = oSqlDataReader.Item("codigo_destinatario")
                lCodigoTituloCala = oSqlDataReader.Item("codigo_titulo_capa")
                sTexto = oSqlDataReader.Item("texto")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNFePedidoVenda(ByVal cboDestinatario As UIComboBox, _
                                       ByVal txtFatura As MaskedEditBox, _
                                       ByVal txtValorOriginal As NumericEditBox, _
                                       ByVal txtValorDesconto As NumericEditBox, _
                                       ByVal txtValorLiquido As NumericEditBox, _
                                       ByVal cboFormaPagamento As UIComboBox, _
                                       ByVal txtNumeroParcela As NumericEditBox, _
                                       ByVal txtIntervaloParcela As NumericEditBox, _
                                       ByVal cboModalidadeFrete As UIComboBox, _
                                       ByVal txtValorFrete As NumericEditBox, _
                                       ByVal cboTransportadora As UIComboBox, _
                                       ByVal chkOutroLugarRetirada As UICheckBox, _
                                       ByVal chkOutroLugarEntrega As UICheckBox, _
                                       ByVal txtDadosAdicionais As EditBox, _
                                       ByVal cboNaturezaOperacao As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_dados_pedido_venda", oSqlParameter)

            While oSqlDataReader.Read

                cboDestinatario.SelectedValue = oSqlDataReader.Item("codigo_destinatario")
                txtFatura.Text = oSqlDataReader.Item("fatura")
                txtValorOriginal.Value = oSqlDataReader.Item("valor_original")
                txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto")
                txtValorLiquido.Value = oSqlDataReader.Item("valor_liquido")
                cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_nfe")
                txtNumeroParcela.Value = oSqlDataReader.Item("numero_parcela")
                txtIntervaloParcela.Value = oSqlDataReader.Item("intervalo_parcela")
                cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                txtValorFrete.Value = oSqlDataReader.Item("valor_frete")
                cboTransportadora.SelectedValue = oSqlDataReader.Item("codigo_transportadora")
                chkOutroLugarRetirada.Checked = oSqlDataReader.Item("outro_lugar_retirada")
                chkOutroLugarEntrega.Checked = oSqlDataReader.Item("outro_lugar_entrega")
                cboNaturezaOperacao.SelectedValue = oSqlDataReader.Item("natureza_operacao")
                Try
                    txtDadosAdicionais.Text = oSqlDataReader.Item("informacao_adicional_contribuinte")
                Catch ex As Exception

                End Try

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function GeraNumeroNotaFiscal() As String

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Tipo Ambiente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goConfiguracaoNFe.iCodigoTipoAmbienteNFe : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nota_fiscal", oSqlParameter)

            Return Format(oSqlParameter(i).Value, "000000000")

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub UpdateDataEmissao(ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nota_fiscal_data_emissao", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function GeraNumeroLote() As String

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Tipo Ambiente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goConfiguracaoNFe.iCodigoTipoAmbienteNFe : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_lote", oSqlParameter)

            Return Format(oSqlParameter(i).Value, "000000000")

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function DuplicarNotaFiscal(ByVal lCodigoEmissaoCapa As Long) As Long

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0
        Dim lReturn As Long

        Try

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

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNotaFiscalEletronica.AguardandoTransmissao : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Emissão Capa Novo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa_novo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_duplicar", oSqlParameter)

            'Seta Váriavel 
            lReturn = oSqlParameter(i).Value

            'Retorno da Função
            Return lReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub UpdateStatusNotaFiscal(ByVal lCodigoEmissaoCapa As Long, _
                                      ByVal iStatus As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_status_nota_fiscal", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaProduto(ByVal lCodigoEmissaoCapa As Long, _
                                  ByRef sMensagem As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa

            'Executa Query
            sMensagem = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_emissao_produto", oSqlParameter)

            'Retorno da Função
            Return IIf(sMensagem = "", True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function CodigoTituloFinanceiro() As Long

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim lCodigoFinanceiro As Long

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa

            'Executa Query
            lCodigoFinanceiro = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_financeiro", oSqlParameter)

            'Retorno da Função
            Return lCodigoFinanceiro

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#Region "::: NF REFERÊNCIA :::"

    Public Sub DeleteNFReferenciada()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("item").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_nf_referenciada", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertNFReferenciada(ByVal iCodigoTipoNotaFiscal As Integer, _
                                    ByVal sUF As String, _
                                    ByVal sDataEmissao As String, _
                                    ByVal sCnpj As String, _
                                    ByVal iSerie As Integer, _
                                    ByVal lNotaFiscal As Long, _
                                    ByVal sChaveAcesso As String)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Tipo de Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNotaFiscal : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, sUF) : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, sDataEmissao) : i += 1

            'Seta Parametros - CNPJ
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, sCnpj) : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, iSerie) : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, lNotaFiscal) : i += 1

            'Seta Parametros - Chave Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscal, DBNull.Value, sChaveAcesso)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nf_referenciada", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateNFReferenciada(ByVal iCodigoTipoNotaFiscal As Integer, _
                                    ByVal sUF As String, _
                                    ByVal sDataEmissao As String, _
                                    ByVal sCnpj As String, _
                                    ByVal iSerie As Integer, _
                                    ByVal lNotaFiscal As Long, _
                                    ByVal sChaveAcesso As String, _
                                    ByVal iItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Tipo de Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNotaFiscal : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, sUF) : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, sDataEmissao) : i += 1

            'Seta Parametros - CNPJ
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, sCnpj) : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, iSerie) : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscalEletronica, DBNull.Value, lNotaFiscal) : i += 1

            'Seta Parametros - Chave Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = IIf(iCodigoTipoNotaFiscal = TipoNotaFiscal.NotaFiscal, DBNull.Value, sChaveAcesso) : i += 1

            'Seta Parametros - Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nf_referenciada", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridNFReferenciada(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As New DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nota_fiscal_referenciada", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: HISTÓRICO :::"

    Public Sub LoadGridHistorico(ByVal oGrid As GridEX, _
                                 ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_historico", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DESTINATÁRIO :::"

    Public Sub InsertDestinatario(Optional ByVal bImportacaoTXT As Boolean = False)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

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

            'Seta Parametros - Código Destinatário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinatario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoDestinatario : i += 1

            'Seta Parametros - CNPJ / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCnpjCpfDestinatario : i += 1

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sRazaoSocialDestinatario : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouroDestinatario : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroDestinatario : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplementoDestinatario = "", DBNull.Value, sComplementoDestinatario) : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairroDestinatario : i += 1

            'Seta Parametros - Código Municipio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipioDestinatario : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFDestinatario : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCepDestinatario : i += 1

            'Seta Parametros - Código Pais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPaisDestinatario : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sTelefoneDestinatario = "", DBNull.Value, sTelefoneDestinatario) : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadualDestinatario : i += 1

            'Seta Parametros - Inscrição Suframa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_suframa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = sInscricaoSuframaDestinatario : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sEmailDestinatario = "", DBNull.Value, sEmailDestinatario) : i += 1

            'Seta Parametros - Outro Lugar Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outro_lugar_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bOutroLugarEntrega : i += 1

            'Seta Parametros - Outro Lugar Retirada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outro_lugar_retirada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bOutroLugarRetirada : i += 1

            'Seta Parametros - Identificacao 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "identificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sIdentificacao : i += 1

            If bImportacaoTXT = True Then
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_destinatario2", oSqlParameter)
            Else
                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_destinatario", oSqlParameter)
            End If
           

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteDestinatario()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_destinatario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: EMITENTE :::"

    Public Sub InsertEmitente()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_emitente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEmitente()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_emitente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TOTAL :::"

    Public Sub InsertTotal()

        'Variaveis Locais
        Dim oSqlParameter(31) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Base de Calculo de ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBaseCalculoICMS : i += 1

            'Seta Parametros - Total ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalICMS : i += 1

            'Seta Parametros - Base de Calculo de ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBaseCalculoICMSST : i += 1

            'Seta Parametros - Total ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalICMSST : i += 1

            'Seta Parametros - Total Produto Serviço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_produto_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalProdutoServico : i += 1

            'Seta Parametros - Total Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalFrete : i += 1

            'Seta Parametros - Total Seguro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_seguro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalSeguro : i += 1

            'Seta Parametros - Total Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalDesconto : i += 1

            'Seta Parametros - Total II
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_ii"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalII : i += 1

            'Seta Parametros - Total IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalIPI : i += 1

            'Seta Parametros - PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPIS : i += 1

            'Seta Parametros - COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCOFINS : i += 1

            'Seta Parametros - Outras Despesas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_despesas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dOutrasDespesas : i += 1


            'Seta Parametros - Total Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalNotaFiscal : i += 1

            'Seta Parametros - Valor Retido PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_retido_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorRetidoPIS : i += 1

            'Seta Parametros - Valor Retido COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_retido_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorRetidoCOFINS : i += 1

            'Seta Parametros - Valor Retido CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_retido_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorRetidoCSLL : i += 1

            'Seta Parametros - Base de Cálculo IRRF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_irrf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBaseCalculoIRRF : i += 1

            'Seta Parametros - Valor Retido IRRF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_retido_irrf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorRetidoIRRF : i += 1

            'Seta Parametros - Base de Cálculo Retencao Previdencia Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_retencao_previdencia_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBaseCalculoRetencaoPrevidenciaSocial : i += 1

            'Seta Parametros - Retencao Previdencia Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "retencao_previdencia_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRetencaoPrevidenciaSocial : i += 1

            'Seta Parametros - Base de Cálculo ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBaseCalculoISS : i += 1

            'Seta Parametros - Total ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalISS : i += 1

            'Seta Parametros - PIS Sobre Serviço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_sobre_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPISSobreServico : i += 1

            'Seta Parametros - COFINS Sobre Serviço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cofins_sobre_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCOFINSSobreServico : i += 1

            'Seta Parametros - Total Serviço Não Tributado ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_servico_nao_tributado_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalServicoNaoTributadoICMS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_icms_fcp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFCPICMSPartilha : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_icms_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDestinoICMSPartilha : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_icms_remetente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorRemetenteICMSPartilha

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_total", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteTotal()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_total", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosTotal(ByVal txtBaseCalculoICMS As NumericEditBox, _
                              ByVal txtTotalICMS As NumericEditBox, _
                              ByVal txtBaseCalculoICMSST As NumericEditBox, _
                              ByVal txtTotalICMSST As NumericEditBox, _
                              ByVal txtTotalProdutoServico As NumericEditBox, _
                              ByVal txtTotalII As NumericEditBox, _
                              ByVal txtTotalIPI As NumericEditBox, _
                              ByVal txtTotalPIS As NumericEditBox, _
                              ByVal txtTotalCOFINS As NumericEditBox, _
                              ByVal txtTotalDesconto As NumericEditBox, _
                              ByVal txtTotalSeguro As NumericEditBox, _
                              ByVal txtTotalFrete As NumericEditBox, _
                              ByVal txtTotalOutrasDespesas As NumericEditBox, _
                              ByVal dValorFrete As Double, _
                              ByVal dValorSeguro As Double, _
                              ByVal dOutrasDespesas As Double, _
                              ByVal txtTotalFCP As NumericEditBox, _
                              ByVal txtTotalICMSRemetente As NumericEditBox, _
                              ByVal txtTotalICMSDestino As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Total Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Total Seguro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_seguro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorSeguro : i += 1

            'Seta Parametros - Outras Despesas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_despesas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dOutrasDespesas

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_totais", oSqlParameter)

            While oSqlDataReader.Read

                txtBaseCalculoICMS.Value = oSqlDataReader("base_calculo_icms")
                txtTotalICMS.Value = oSqlDataReader("total_icms")
                txtBaseCalculoICMSST.Value = oSqlDataReader("base_calculo_icms_st")
                txtTotalICMSST.Value = oSqlDataReader("total_icms_st")
                txtTotalII.Value = oSqlDataReader("total_ii")
                txtTotalIPI.Value = oSqlDataReader("total_ipi")
                txtTotalPIS.Value = oSqlDataReader("total_pis")
                txtTotalCOFINS.Value = oSqlDataReader("total_cofins")
                txtTotalProdutoServico.Value = oSqlDataReader("total_produto_servico")
                txtTotalDesconto.Value = oSqlDataReader.Item("valor_desconto")
                txtTotalSeguro.Value = oSqlDataReader.Item("total_seguro")
                txtTotalFrete.Value = oSqlDataReader.Item("total_frete")
                txtTotalOutrasDespesas.Value = oSqlDataReader.Item("total_outras_despesas")
                txtTotalICMSDestino.Value = oSqlDataReader.Item("total_icms_destino")
                txtTotalICMSRemetente.Value = oSqlDataReader.Item("total_icms_remetente")
                txtTotalFCP.Value = oSqlDataReader.Item("total_icms_fcp")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: INFORMAÇÕES ADICIONAIS :::"

    Public Sub InsertInformacaoAdicional()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Informação Adicional FISCO
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "informacao_adicional_fisco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2000
            oSqlParameter(i).Value = IIf(sInformacaoAdicionalFisco = "", DBNull.Value, Replace(sInformacaoAdicionalFisco, vbCr & vbLf, "||")) : i += 1

            'Seta Parametros - Informação Adicional Contribuinte
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "informacao_adicional_contribuinte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sInformacaoAdicionalContribuinte = "", DBNull.Value, Replace(sInformacaoAdicionalContribuinte, vbCr & vbLf, "||"))

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_informacoes_adicionais", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteInformacaoAdicional()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_informacoes_adicionais", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Public Sub InsertFatura()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Condição de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamento = -1, DBNull.Value, iCodigoCondicaoPagamento) : i += 1

            'Seta Parametros - Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sFatura = "", DBNull.Value, sFatura) : i += 1

            'Seta Parametros - Valor Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorOriginal = 0, DBNull.Value, dValorOriginal) : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorDesconto = 0, DBNull.Value, dValorDesconto) : i += 1

            'Seta Parametros - Valor Liquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorLiquido = 0, DBNull.Value, dValorLiquido) : i += 1

            'Seta Parametros - Número de Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Intervalo de Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "intervalo_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iIntervaloParcela

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFaturaDuplicata(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim oSqlParameter(4) As SqlParameter
            Dim i As Integer

            For Each oRow As GridEXRow In oGrid.GetDataRows

                i = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - N° Duplicata
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_duplicata"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.RowIndex + 1 : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_fatura_duplicata", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFaturaDuplicata(ByVal sNumeroDuplicata As String, _
                                     ByVal sDataVencimento As String, _
                                     ByVal dValor As Double)

        Try

            'Variaveis Locais
            Dim oSqlParameter(4) As SqlParameter
            Dim i As Integer = 0

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - N° Duplicata
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_duplicata"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroDuplicata + 1 : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataVencimento : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_fatura_duplicata", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteFatura()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosFatura(ByVal txtValorOriginal As NumericEditBox, _
                               ByVal txtValorDesconto As NumericEditBox, _
                               ByVal txtValorPago As NumericEditBox, _
                               ByVal cboCondicaoPagamento As UIComboBox, _
                               ByVal dValorFrete As Double, _
                               ByVal dValorSeguro As Double, _
                               ByVal dOutrasDespesas As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Total Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Total Seguro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_seguro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorSeguro : i += 1


            'Seta Parametros - Outras Despesas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_despesas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dOutrasDespesas

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_totais", oSqlParameter)

            While oSqlDataReader.Read

                cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                txtValorOriginal.Value = oSqlDataReader.Item("valor_fatura")
                txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto_financeiro")
                txtValorPago.Value = oSqlDataReader.Item("valor_pago")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFatura(ByVal oGrid As GridEX, _
                              ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_fatura_duplicata", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarDuplicata2(ByVal oGrid As GridEX, _
                               ByVal dValor As Double, _
                               ByVal iNumeroParcela As Integer, _
                               ByVal iIntervaloParcela As Integer, _
                               ByVal dValorICMSST As Double)

        Try

            'Váriaveis Locais
            Dim oRow As GridEXRow
            Dim dValorTotal As Double = 0
            Dim dValorResidual As Double = 0
            Dim iParcela As Integer = 0

            If bSistemaPerforma = True Then
                bPerforma = 1
                dValor = dValor - dValorICMSST
            End If

            'Preenche Total
            For Each oRow In oGrid.GetDataRows
                If oRow.Cells("valor_pago").Value > 0 Then
                    iParcela += 1
                    dValorTotal += oRow.Cells("valor").Value
                End If
            Next

            'Caso Valor Liquido maior que 0
            If dValor - dValorTotal > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCPago As New DataColumn("pago")
                Dim oDCVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")
                Dim oDCValorPago As New DataColumn("valor_pago")

                'Seta DataType
                oDCPago.DataType = False.GetType
                oDCVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType
                oDCValorPago.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCPago)
                oDataTable.Columns.Add(oDCVencimento)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCValorPago)

                'Adiciona Linhas ao DataTable - Pago
                For Each oRow In oGrid.GetDataRows
                    If oRow.Cells("valor_pago").Value > 0 Then
                        Dim oDataRow As DataRow = oDataTable.NewRow
                        oDataRow("pago") = oRow.Cells("pago").Value
                        oDataRow("data_vencimento") = oRow.Cells("data_vencimento").Value
                        oDataRow("valor") = oRow.Cells("valor").Value
                        oDataRow("valor_pago") = oRow.Cells("valor_pago").Value
                        oDataTable.Rows.Add(oDataRow)
                    End If
                Next

                dValorResidual = (dValor - dValorTotal)

                'Adiciona Linhas ao DataTable
                For i = 1 + iParcela To iNumeroParcela
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("pago") = False
                    oDataRow("data_vencimento") = CDate(DateAdd(DateInterval.Day, i * iIntervaloParcela, Now.Date))
                    oDataRow("valor") = IIf(iNumeroParcela = i, dValorResidual, System.Math.Round(((dValor - dValorTotal) / (iNumeroParcela - iParcela)), 2)) + IIf(i = 1, dValorICMSST, 0)
                    dValorResidual -= System.Math.Round(((dValor - dValorTotal) / (iNumeroParcela - iParcela)), 2)
                    oDataRow("valor_pago") = 0
                    oDataTable.Rows.Add(oDataRow)
                Next

                'Limpa Grid
                oGrid.DataSource = Nothing

                'Configura DataMember
                Call ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            Else

                'Limpa Grid
                oGrid.DataSource = Nothing

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarDuplicata(ByVal oGrid As GridEX, _
                              ByVal iCodigoCondicaoPagamento As Integer, _
                              ByVal dValor As Double, _
                              ByVal sDataEmissao As String, _
                              ByVal dValorICMSST As Double)

        Try

            'Váriaveis Locais
            Dim oRow As GridEXRow
            Dim dValorTotal As Double = 0
            Dim dValorResidual As Double = 0
            Dim iParcela As Integer = 0

            If bSistemaPerforma = True Then
                bPerforma = 1
            End If

            'Preenche Total
            For Each oRow In oGrid.GetDataRows
                If oRow.Cells("valor_pago").Value > 0 Then
                    iParcela += 1
                    dValorTotal += oRow.Cells("valor").Value
                End If
            Next

            'Caso Valor Liquido maior que 0
            If dValor - dValorTotal > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCPago As New DataColumn("pago")
                Dim oDCVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")
                Dim oDCValorPago As New DataColumn("valor_pago")
                Dim oSqlDataReader As SqlDataReader
                Dim oSqlParameter(5) As SqlParameter
                Dim oDataRow As DataRow
                Dim i As Integer = 0

                'Seta DataType
                oDCPago.DataType = False.GetType
                oDCVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType
                oDCValorPago.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCPago)
                oDataTable.Columns.Add(oDCVencimento)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCValorPago)

                'Adiciona Linhas ao DataTable - Pago
                For Each oRow In oGrid.GetDataRows
                    If oRow.Cells("valor_pago").Value > 0 Then
                        oDataRow = oDataTable.NewRow
                        oDataRow("pago") = oRow.Cells("pago").Value
                        oDataRow("data_vencimento") = oRow.Cells("data_vencimento").Value
                        oDataRow("valor") = oRow.Cells("valor").Value
                        oDataRow("valor_pago") = oRow.Cells("valor_pago").Value
                        oDataTable.Rows.Add(oDataRow)
                    End If
                Next

                dValorResidual = (dValor - dValorTotal)

                'Verifica se possui Valor Residual
                If dValorResidual > 0 Then

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1
                     
                    'Seta Parametros - Código Condição de Pagamento
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = iCodigoCondicaoPagamento : i += 1

                    'Seta Parametros - Valor
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = dValorResidual : i += 1

                    'If bPerforma = 1 Then

                    'Seta Parametros - Valor ICMS ST
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor_icms_st"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = dValorICMSST : i += 1

                    'End If

                    'Seta Parametros - Parcela
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "parcela"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = iParcela : i += 1

                    'Seta Parametros - Data Emissão
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "data_emissao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                    oSqlParameter(i).Value = sDataEmissao

                    'Carrega Query
                    oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_condicao_pagamento_parcela_valor", oSqlParameter)

                    While oSqlDataReader.Read
                        oDataRow = oDataTable.NewRow
                        oDataRow("pago") = False
                        oDataRow("data_vencimento") = oSqlDataReader.Item("data_vencimento")
                        oDataRow("valor") = oSqlDataReader.Item("valor")
                        oDataRow("valor_pago") = 0
                        oDataTable.Rows.Add(oDataRow)
                    End While

                    'Fecah o SqlDataReader
                    If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

                End If

                'Limpa Grid
                oGrid.DataSource = Nothing

                'Configura DataMember
                Call ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            Else

                'Limpa Grid
                oGrid.DataSource = Nothing

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FINANCEIRO MANUAL ::: "

    Public Sub InsertFinanceiroGrid(ByVal oGrid As GridEX, _
                                ByVal dDataVencimento As Date, _
                                ByVal iNumeroParcela As Integer, _
                                ByVal iIntervaloParcela As Integer, _
                                ByVal dPorcentagemParcela As Double, _
                                ByVal dValorParcela As Double, _
                                ByVal iCodigo As Integer, _
                                ByVal sTipoOperacao As String)


        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCDataVencimento As New DataColumn("data_vencimento")
            Dim oDCNumeroParcela As New DataColumn("numero_parcela")
            Dim oDCIntervaloParcela As New DataColumn("intervalo_parcela")
            Dim oDCPorcentagemParcela As New DataColumn("percentual_parcela")
            Dim oDCValorParcela As New DataColumn("valor_parcela")
            Dim oDCCodigo As New DataColumn("codigo")



            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCDataVencimento)
                oDataTable.Columns.Add(oDCNumeroParcela)
                oDataTable.Columns.Add(oDCIntervaloParcela)
                oDataTable.Columns.Add(oDCPorcentagemParcela)
                oDataTable.Columns.Add(oDCValorParcela)
                oDataTable.Columns.Add(oDCCodigo)
                'Seta Tipo
                oDCPorcentagemParcela.DataType = 0.0.GetType
                oDCValorParcela.DataType = 0.0.GetType

            End If

            'Verifica o Tipo de Operação
            If sTipoOperacao = "I" Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("data_vencimento") = dDataVencimento
                oDataRow("numero_parcela") = iNumeroParcela
                oDataRow("intervalo_parcela") = iIntervaloParcela
                oDataRow("percentual_parcela") = dPorcentagemParcela
                oDataRow("valor_parcela") = dValorParcela
                oDataRow("codigo") = iCodigo
                oDataTable.Rows.Add(oDataRow)
            Else
                'oDataRow = oDataTable.Select("(codigo_item = " & lCodigoItemAntigo & ")")(0)
                oDataRow = oDataTable.Select("(codigo = " & iCodigo & ")")(0)

                oDataRow("data_vencimento") = dDataVencimento
                oDataRow("numero_parcela") = iNumeroParcela
                oDataRow("intervalo_parcela") = iIntervaloParcela
                oDataRow("percentual_parcela") = dPorcentagemParcela
                oDataRow("valor_parcela") = dValorParcela

            End If

            With oGrid

                'Preenche Dados
                .RootTable.Columns.Item("data_vencimento").DataMember = "data_vencimento"
                .RootTable.Columns.Item("numero_parcela").DataMember = "numero_parcela"
                .RootTable.Columns.Item("intervalo_parcela").DataMember = "intervalo_parcela"
                .RootTable.Columns.Item("percentual_parcela").DataMember = "percentual_parcela"
                .RootTable.Columns.Item("valor_parcela").DataMember = "valor_parcela"

                .RootTable.Columns.Item("codigo").DataMember = "codigo"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

                'DEIXA NA ULTIMA LINHA DA GRID.
                .MoveLast()


            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteFinanceiro()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissao Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_fatura_financeiro", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFinanceiro(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim i As Integer
            Dim oSqlParameter(7) As SqlParameter

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

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
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - N° Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("numero_parcela").Value : i += 1

                'Seta Parametros - Intervalo Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "intervalo_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("intervalo_parcela").Value : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Percentual Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "percentual_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("percentual_parcela").Value : i += 1

                'Seta Parametros - Valor Parcela 
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_parcela").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_fatura_financeiro", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFinanceiro(ByVal lCodigoEmisaoCapa As Long, _
                                  ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emisão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_fatura_financeiro", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: EXPORTAÇÃO :::"

    Public Sub InsertExportacao()

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - UF Embarque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_embarque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFEmbarque : i += 1

            'Seta Parametros - Local Embarque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "local_embarque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLocalEmbarque : i += 1

            'Seta Parametros - Numero Drawback
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_drawback_exportacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroDrawbackExportacao = "", DBNull.Value, sNumeroDrawbackExportacao) : i += 1

            'Seta Parametros - Numero RE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_re"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroRE = "", DBNull.Value, sNumeroRE) : i += 1

            'Seta Parametros - Chave Acesso Exportacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso_exportacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sChaveAcessoExportacao = "", DBNull.Value, sChaveAcessoExportacao) : i += 1

            'Seta Parametros - Quantidade Exportacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_exportacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadeExportacao = 0, DBNull.Value, dQuantidadeExportacao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_exportacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteExportacao()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0


        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_exportacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: COMPRAS :::"

    Public Sub LoadControles(ByVal lCodigoPedido As Long, _
                             ByVal iCodigo As Integer, _
                             ByVal txtQuantidade As NumericEditBox, _
                             ByVal txtReferencia As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_load_compras_emissao_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtQuantidade.Text = oSqlDataReader.Item("quantidade")
                    txtReferencia.Text = oSqlDataReader.Item("referencia")

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCompras()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nota de Empenho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_empenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sNotaEmpenho = "", DBNull.Value, sNotaEmpenho) : i += 1

            'Seta Parametros - Informação do Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "informacao_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sInformacaoPedido = "", DBNull.Value, sInformacaoPedido) : i += 1

            'Seta Parametros - Informação do Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "informacao_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sInformacaoContrato = "", DBNull.Value, sInformacaoContrato)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_compras", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCompras()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_compras", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertComprasRetornoConserto(ByVal lCodigoEmissaoCapa As Long, _
                                            ByVal iCodigoEmissaoItem As Integer, _
                                            ByVal lCodigoPedido As Long, _
                                            ByVal iCodigoPedidoItem As Integer, _
                                            ByVal sPedidoCompra As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pedido_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPedidoCompra : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_lote_retorno_conserto_compras", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DI / ADIÇÃO :::"

#Region "::: DI :::"

    Public Sub DeleteDI()

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(2) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Codigo Emissão Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código DI
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_di").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_di", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDI(ByVal sNumeroDI As String, _
                        ByVal sDataRegistro As String, _
                        ByVal sCodigoExportador As String, _
                        ByVal sUFLocalDesembaraco As String, _
                        ByVal sLocalDesembaraco As String, _
                        ByVal sDataDesembaraco As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número da DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sNumeroDI : i += 1

            'Seta Parametros - Data Registro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataRegistro : i += 1

            'Seta Parametros - Código Exportador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_exportador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoExportador : i += 1

            'Seta Parametros - UF do Local do Desembaraco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_local_desembaraco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFLocalDesembaraco : i += 1

            'Seta Parametros - Local do Desembaraco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "local_desembaraco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLocalDesembaraco : i += 1

            'Seta Parametros - Data do Desembaraco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_desembaraco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataDesembaraco

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_di", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDI(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Codigo Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_di", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDI(ByVal sNumeroDI As String, _
                        ByVal sDataRegistro As String, _
                        ByVal sCodigoExportador As String, _
                        ByVal sUFLocalDesembaraco As String, _
                        ByVal sLocalDesembaraco As String, _
                        ByVal sDataDesembaraco As String, _
                        ByVal iCodigoDI As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número da DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sNumeroDI : i += 1

            'Seta Parametros - Data Registro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataRegistro : i += 1

            'Seta Parametros - Código Exportador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_exportador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoExportador : i += 1

            'Seta Parametros - UF do Local do Desembaraco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_local_desembaraco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFLocalDesembaraco : i += 1

            'Seta Parametros - Local do Desembaraco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "local_desembaraco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLocalDesembaraco : i += 1

            'Seta Parametros - Data do Desembaraco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_desembaraco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataDesembaraco : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDI

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_di", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaDI(ByVal sNumeroDI As String, _
                             ByVal iCodigoDI As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sNumeroDI : i += 1

            'Seta Parametros - Código DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDI

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_emissao_di", oSqlParameter), Integer)

            'Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ADIÇÃO :::"

    Public Sub DeleteDIAdicao()

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(3) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Codigo Emissão Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Emissão DI
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_di"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_emissao_di").Value : i += 1

                'Seta Parametros - Sequência
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "sequencia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("sequencia").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_di_adicao", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDIAdicao(ByVal iCodigoDI As Integer, _
                              ByVal iNumeroAdicao As Integer, _
                              ByVal iCodigoNCM As Integer, _
                              ByVal dValorFrete As Double, _
                              ByVal dValorSeguro As Double, _
                              ByVal dValorDesconto As Double, _
                              ByVal dValorOutrasDespesas As Double, _
                              ByVal sNumeroDrawbackAdicao As String)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDI : i += 1

            'Seta Parametros - Número Adição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_adicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroAdicao : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNCM : i += 1

            'Seta Parametros - Valor Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Valor Seguro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_seguro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorSeguro : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Outras Despesas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_outras_despesas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorOutrasDespesas : i += 1

            'Seta Parametros - Numero Drawback Adição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_drawback_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroDrawbackAdicao = "", DBNull.Value, sNumeroDrawbackAdicao) : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_di_adicao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDIAdicao(ByVal oGrid As GridEX, _
                                ByVal iCodigoEmissaoDI As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Codigo Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Emissão DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoDI

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_di_adicao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDIAdicao(ByVal iCodigoDI As Integer, _
                              ByVal iNumeroAdicao As Integer, _
                              ByVal iCodigoNCM As Integer, _
                              ByVal dValorFrete As Double, _
                              ByVal dValorSeguro As Double, _
                              ByVal dValorDesconto As Double, _
                              ByVal dValorOutrasDespesas As Double, _
                              ByVal sNumeroDrawbackAdicao As String, _
                              ByVal iSequencia As Integer)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDI : i += 1

            'Seta Parametros - Número Adição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_adicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroAdicao : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNCM : i += 1

            'Seta Parametros - Valor Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Valor Seguro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_seguro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorSeguro : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Outras Despesas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_outras_despesas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorOutrasDespesas : i += 1

            'Seta Parametros - Sequencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Numero Drawback Adição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_drawback_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroDrawbackAdicao = "", DBNull.Value, sNumeroDrawbackAdicao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_di_adicao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaDIAdicao(ByVal iCodigoEmissaoDI As Integer, _
                                   ByVal iNumeroAdicao As Integer, _
                                   ByVal iSequencia As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoDI : i += 1

            'Seta Parametros - Número Adição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_adicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroAdicao : i += 1

            'Seta Parametros - Sequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_emissao_di_adicao", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

#Region "::: PRODUTO :::"

    Public Sub DeleteProduto()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Exclui Registro
            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Emissao Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_emissao_item").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_item", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProduto(ByVal lCodigoEmissaoCapa As Long, _
                               ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_item_produto", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtualizaDadosProduto(ByVal dValorFrete As Double, _
                                    ByVal dValorSeguro As Double, _
                                    ByVal dOutrasDespesas As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Total Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Total Seguro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_seguro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorSeguro : i += 1

            'Seta Parametros - Outras Despesas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_despesas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dOutrasDespesas

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_item_imposto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridExportar(ByVal oGrdListagem As GridEX, _
                                ByVal oGrdExportar As GridEX)
        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim sCodigo As String = ""

        Try

            For Each oRow In oGrdListagem.GetCheckedRows
                sCodigo += IIf(sCodigo = "", "", ",") + CStr(oRow.Cells.Item("codigo").Value)
            Next

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_exportar_contabilidade", oSqlParameter)

            oGrdExportar.RootTable.Columns.Clear()

            For Each oDataColumn As DataColumn In oDataSet.Tables(0).Columns
                Dim sKey As String = Mid(oDataColumn.ColumnName, InStr(oDataColumn.ColumnName, "_") + 1)
                Dim sColors As String = oDataColumn.ColumnName.Replace("_" + sKey, "")
                Dim oGrdExFormatStyle As New GridEXFormatStyle
                Dim oGrdExColumn As New GridEXColumn(sKey)
                Select Case sColors.ToLower
                    Case "r"
                        oGrdExFormatStyle.ForeColor = Color.Firebrick

                    Case "o"
                        oGrdExFormatStyle.ForeColor = Color.Orange

                    Case "y"
                        oGrdExFormatStyle.ForeColor = Color.YellowGreen

                    Case "g"
                        oGrdExFormatStyle.ForeColor = Color.Green

                    Case "b"
                        oGrdExFormatStyle.ForeColor = Color.Blue

                    Case "bl"
                        oGrdExFormatStyle.ForeColor = Color.Black

                    Case "pi"
                        oGrdExFormatStyle.ForeColor = Color.Peru

                    Case "p"
                        oGrdExFormatStyle.ForeColor = Color.Purple

                End Select
                oGrdExColumn.CellStyle = oGrdExFormatStyle
                oGrdExColumn.Caption = sKey
                oGrdExColumn.DataMember = oDataColumn.ColumnName
                oGrdExportar.RootTable.Columns.Add(oGrdExColumn)

            Next


            'Carrega a Grid    
            oGrdExportar.DataSource = oDataSet.DefaultViewManager
            oGrdExportar.DataMember = oDataSet.Tables(0).TableName : oGrdExportar.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FCI :::"

    Public Sub LoadGridProdutoFCI(ByVal lCodigoEmissaoCapa As Long, _
                               ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_item_produto_fci", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarFCI(ByVal lCodigoEmissaoCapa As Long, _
                        ByVal sCodigoEmissaoItem As String, _
                        ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        'Instanciando um streamwriter para escrever as linhas
        Dim oStreamWriter As New StreamWriter(sArquivo, False, System.Text.Encoding.UTF8)

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Quety
            oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_item_fci_gerar", oSqlParameter)

            While oSqlDataReader.Read

                'Escrevendo as linhas
                oStreamWriter.WriteLine(oSqlDataReader(0))

            End While

            'Fechando o data set
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        Finally
            oStreamWriter.Close()
        End Try

    End Sub

    Public Sub LoadDadosFCI(ByRef oDataSetMain As DataSet, _
                            ByVal sArquivo As String)

        'Instanciando o stream reader
        Dim oStreamReader As New StreamReader(sArquivo, System.Text.Encoding.UTF8)

        Try

            'Variáveis auxiliares
            Dim sLinha As String
            Dim oVetor() As String
            Dim sProtocolo As String
            Dim dDataFCI As Date

            'Instanciando um novo dataset
            Dim oDataSet As New DataSet

            'Instanciando uma variavel para adicionar as linhas
            Dim oRow As DataRow

            'Adicionando a tabela
            oDataSet.Tables.Add("main")

            'Adicionando as colunas
            oDataSet.Tables(0).Columns.Add("codigo_item")
            oDataSet.Tables(0).Columns.Add("data_fci").DataType = Now.GetType
            oDataSet.Tables(0).Columns.Add("protocolo")
            oDataSet.Tables(0).Columns.Add("valor_parcela_importada")
            oDataSet.Tables(0).Columns.Add("preco_venda")
            oDataSet.Tables(0).Columns.Add("conteudo_importacao")
            oDataSet.Tables(0).Columns.Add("fci")
            oDataSet.Tables(0).Columns.Add("descricao")

            'Agora percorre o arquivo para setar as linhas
            While oStreamReader.EndOfStream = False

                'Lendo a linha
                sLinha = oStreamReader.ReadLine

                'Separando os dados no vetor
                oVetor = sLinha.Split("|")

                'Se for o arquivo do cabeçalho, pegar os dados do recibo
                If oVetor(0) = "0000" Then

                    'Recebendo os dados
                    dDataFCI = oVetor(5)
                    sProtocolo = oVetor(6)

                ElseIf oVetor(0) = "5020" Then 'Somente interessa esses dois registros

                    'setando os campos
                    If oVetor(10) = "100" Then

                        'Adicionando um novo registro
                        oRow = oDataSet.Tables(0).Rows.Add

                        oRow("descricao") = oVetor(1)
                        oRow("codigo_item") = oVetor(3)
                        oRow("preco_venda") = oVetor(6)
                        oRow("valor_parcela_importada") = oVetor(7)
                        oRow("conteudo_importacao") = oVetor(8)
                        oRow("fci") = oVetor(9)

                        'Dados do protocolo
                        oRow("protocolo") = sProtocolo
                        oRow("data_fci") = dDataFCI

                    End If

                End If

            End While

            'Copia o dataset gerado
            oDataSetMain = oDataSet.Copy

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        Finally
            oStreamReader.Close()
        End Try

    End Sub

    Public Sub InsertFCI(ByVal lCodigoEmissaoCapa As Long, _
                         ByVal oDataSet As DataSet)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Percorrendo os dados
            For Each oDataRow In oDataSet.Tables(0).Rows

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Emissão Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oDataRow("codigo_emissao_item") : i += 1

                'Seta Parametros - Descrição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oDataRow("descricao") : i += 1

                'Seta Parametros - Valor Parcela Importada
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_parcela_importada"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oDataRow("valor_parcela_importada") : i += 1

                'Seta Parametros - Preço de Venda
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "preco_venda"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oDataRow("preco_venda") : i += 1

                'Seta Parametros - Data FCI
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_fci"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Date
                oSqlParameter(i).Value = oDataRow("data_fci") : i += 1

                'Seta Parametros - Protocolo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "protocolo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oDataRow("protocolo") : i += 1

                'Seta Parametros - FCI
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "fci"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oDataRow("fci") : i += 1

                'Seta Parametros - Conteudo Importação
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "conteudo_importacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oDataRow("conteudo_importacao")

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_fci_importar_arquivo", oSqlParameter)

            Next

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TRANSPORTE :::"

#Region "::: TRANSPORTADORA :::"

    Public Sub InsertTransporte()

        'Variaveis Locais
        Dim oSqlParameter(22) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Modalidade de Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModalidadeFrete : i += 1

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, iCodigoTransportadora) : i += 1

            'Seta Parametros - CNPJ / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, sCnpjCpfTransportadora) : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, sInscricaoEstadualTransportadora) : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, sUFTransportadora) : i += 1

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, sMunicipioTransportadora) : i += 1

            'Seta Parametros - Endereço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "endereco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, sEnderecoTransportadora) : i += 1

            'Seta Parametros - Valor do Serviço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorServicoTransporte = 0, DBNull.Value, dValorServicoTransporte) : i += 1

            'Seta Parametros - Base de Calculo Retenção de ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_retencao_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoTransporte = 0, DBNull.Value, dBaseCalculoTransporte) : i += 1

            'Seta Parametros - Alíquota Retenção ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_retencao_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSTransporte = 0, DBNull.Value, dAliquotaICMSTransporte) : i += 1

            'Seta Parametros - Valor ICMS Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMSRetidoTransporte = 0, DBNull.Value, dValorICMSRetidoTransporte) : i += 1

            'Seta Parametros - CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCFOPTransporte = -1, DBNull.Value, iCodigoCFOPTransporte) : i += 1

            'Seta Parametros - UF Fator Gerador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_fator_gerador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUFICMSTransporte = "", DBNull.Value, sUFICMSTransporte) : i += 1

            'Seta Parametros - Código do Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio_fator_gerador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMunicipioICMSTransporte = -1, DBNull.Value, iCodigoMunicipioICMSTransporte) : i += 1

            'Seta Parametros - Código Tipo Veículo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_veiculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iTipoVeiculo = -1 Or iTipoVeiculo = 0, DBNull.Value, iTipoVeiculo) : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = IIf(sPlacaVeiculo <> "", sPlacaVeiculo, DBNull.Value) : i += 1

            'Seta Parametros - UF Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sUFPlacaVeiculo <> "", sUFPlacaVeiculo, DBNull.Value) : i += 1

            'Seta Parametros - RNTC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rntc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sRNTCVeiculo <> "", sRNTCVeiculo, DBNull.Value) : i += 1

            'Seta Parametros - Vagão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "vagao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sVagao <> "", sVagao, DBNull.Value) : i += 1

            'Seta Parametros - Balsa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "balsa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sBalsa <> "", sBalsa, DBNull.Value) : i += 1

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, sRazaoSocialTransportadora)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_transporte", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteTransporte()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_transporte", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: REBOQUE :::"

    Public Sub DeleteReboque()

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(2) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Codigo Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Placa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "placa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 8
                oSqlParameter(i).Value = oRow.Cells("placa").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_transporte_reboque", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertReboque(ByVal sPlaca As String, _
                             ByVal sUF As String, _
                             ByVal sRNTC As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = sPlaca : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - RNTC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rntc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sRNTC = "", DBNull.Value, sRNTC)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_transporte_reboque", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridReboque(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_transporte_reboque", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReboque(ByVal sPlaca As String, _
                             ByVal sUF As String, _
                             ByVal sRNTC As String, _
                             ByVal sPlacaAtual As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = sPlaca : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - RNTC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rntc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sRNTC = "", DBNull.Value, sRNTC) : i += 1

            'Seta Parametros - Placa Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = sPlacaAtual

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_transporte_reboque", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaReboque(ByVal sPlaca As String, _
                                  ByVal sPlacaAtual As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = sPlacaAtual : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = sPlaca

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_emissao_transporte_reboque", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: VOLUME :::"

    Public Sub LoadDadosPeso(ByVal txtPesoLiquido As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            txtPesoLiquido.Value = 0

            'Seta Parametros - Codigo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            txtPesoLiquido.Value = txtPesoLiquido.Value + ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_transporte_peso", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteVolume()

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(2) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Codigo Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

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
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_transporte_volume", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertVolume(ByVal lQuantidade As Long, _
                            ByVal sEspecie As String, _
                            ByVal sMarca As String, _
                            ByVal sNumeracaoVolumes As String, _
                            ByVal dPesoLiquido As Double, _
                            ByVal dPesoBruto As Double)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lQuantidade = 0, DBNull.Value, lQuantidade) : i += 1

            'Seta Parametros - Espécie
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "especie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sEspecie = "", DBNull.Value, sEspecie) : i += 1

            'Seta Parametros - Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sMarca = "", DBNull.Value, sMarca) : i += 1

            'Seta Parametros - Numeração de Volumes
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numeracao_volumes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sNumeracaoVolumes = "", DBNull.Value, sNumeracaoVolumes) : i += 1

            'Seta Parametros - Peso Líquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "peso_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPesoLiquido = 0, DBNull.Value, dPesoLiquido) : i += 1

            'Seta Parametros - Peso Bruto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "peso_bruto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPesoBruto = 0, DBNull.Value, dPesoBruto)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_transporte_volume", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridVolume(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_transporte_volume", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateVolume(ByVal lQuantidade As Long, _
                            ByVal sEspecie As String, _
                            ByVal sMarca As String, _
                            ByVal sNumeracaoVolumes As String, _
                            ByVal dPesoLiquido As Double, _
                            ByVal dPesoBruto As Double, _
                            ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lQuantidade = 0, DBNull.Value, lQuantidade) : i += 1

            'Seta Parametros - Espécie
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "especie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sEspecie = "", DBNull.Value, sEspecie) : i += 1

            'Seta Parametros - Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sMarca = "", DBNull.Value, sMarca) : i += 1

            'Seta Parametros - Numeração de Volumes
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numeracao_volumes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sNumeracaoVolumes = "", DBNull.Value, sNumeracaoVolumes) : i += 1

            'Seta Parametros - Peso Líquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "peso_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPesoLiquido = 0, DBNull.Value, dPesoLiquido) : i += 1

            'Seta Parametros - Peso Bruto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "peso_bruto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPesoBruto = 0, DBNull.Value, dPesoBruto) : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_transporte_volume", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: NOTA FISCAL ELETRÔNICA :::"

    Public Sub UpdateNFeEnvio(ByVal sMensagemSefaz As String, _
                              ByVal sChaveAcesso As String, _
                              ByVal sNumeroRecibo As String, _
                              ByVal sXMLEnvio As String, _
                              ByVal sXMLRetorno As String, _
                              ByVal lLote As Long, _
                              ByVal iCodigoTipoAmbienteNFe As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Mensagem Sefaz
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_sefaz"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sMensagemSefaz : i += 1

            'Seta Parametros - Chave de Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            'Seta Parametros - Número do Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNumeroRecibo : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(StatusNotaFiscalEletronica.AguardandoRetorno) : i += 1

            'Seta Parametros - XML Envio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_envio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLEnvio : i += 1

            'Seta Parametros - XML Retorno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_retorno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLRetorno : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lLote : i += 1

            'Seta Parametros - Código Tipo de Ambiente NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoAmbienteNFe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_nfe_envio", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateNFeEnvioDuplicidade(ByVal sChaveAcesso As String, _
                                         ByVal sChaveAcessoCorreta As String, _
                                         ByVal sNumeroRecibo As String, _
                                         ByVal iCodigoTipoAmbienteNFe As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Chave de Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            'Seta Parametros - Número do Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNumeroRecibo : i += 1

            'Seta Parametros - Código Tipo de Ambiente NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoAmbienteNFe : i += 1

            'Seta Parametros - Chave de Acesso Correta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso_correta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = sChaveAcessoCorreta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_nfe_envio_duplicidade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateNFeRetorno(ByVal sMensagemSefaz As String, _
                                ByVal sChaveAcesso As String, _
                                ByVal sNumeroProtocolo As String, _
                                ByVal iStatus As Integer, _
                                ByVal sXMLProtocolo As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Mensagem Sefaz
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_sefaz"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sMensagemSefaz : i += 1

            'Seta Parametros - Chave de Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            'Seta Parametros - Número do Protocolo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNumeroProtocolo : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - XML Protocolo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLProtocolo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_nfe_retorno", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub RetornoNFe(ByVal sProtocolo As String, _
                          ByVal sMensagem As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Protocolo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sProtocolo : i += 1

            'Seta Parametros - Mensagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_sefaz"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sMensagem : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNotaFiscalEletronica.AutorizadaUso

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfe_protocolo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateNFeSimulacao(ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_nfe_simulacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO TXT :::"

    Public Sub InsertLinha1(ByVal iNotaFiscal As Integer, _
                            ByVal sSerie As String, _
                            ByVal dDataEmissao As Date, _
                            ByVal dDataSaida As Date, _
                            ByVal sNaturezaOpercao As String, _
                            ByVal sInformacoesAdicionais As String, _
                            ByVal sCampo07 As String, _
                            ByVal sTipoDocumento As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iNotaFiscal : i += 1

            'Seta Parametros - Serie
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataEmissao : i += 1

            'Seta Parametros - Data Saída
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_saida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataSaida : i += 1

            'Seta Parametros - Natureza Operação 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "natureza_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNaturezaOpercao : i += 1

            'Seta Parametros - Informações Adicionais 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "informacoes_adicionais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sInformacoesAdicionais : i += 1

            'Seta Parametros - Campo 07
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_07"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo07 : i += 1

            'Seta Parametros - Tipo Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoDocumento

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_integracao_linha1", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLinha2(ByVal sCampo01 As String, _
                            ByVal sCampo02 As String, _
                            ByVal sCampo03 As String, _
                            ByVal sCampo04 As String, _
                            ByVal sCampo05 As String, _
                            ByVal sCampo06 As String, _
                            ByVal sCampo07 As String, _
                            ByVal sCampo08 As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Campo 01
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_01"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo01 : i += 1

            'Seta Parametros - Campo 02
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_02"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo02 : i += 1

            'Seta Parametros - Campos 03
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_03"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo03 : i += 1

            'Seta Parametros - Campo 04
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_04"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo04 : i += 1

            'Seta Parametros - Campo 05 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_05"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo05 : i += 1

            'Seta Parametros - Campo 06
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_06"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo06 : i += 1

            'Seta Parametros - Campo 07
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_07"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo07 : i += 1

            'Seta Parametros - Campo 08
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_08"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo08

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_integracao_linha2", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLinha3(ByVal sCNPJDestinatario As String, _
                            ByVal sNomeFantasia As String, _
                            ByVal sRazaoSocial As String, _
                            ByVal sLogradouro As String, _
                            ByVal sNumero As String, _
                            ByVal sComplemento As String, _
                            ByVal sBairro As String, _
                            ByVal iIBGEMunicipio As Integer, _
                            ByVal sUF As String, _
                            ByVal iCEP As Integer, _
                            ByVal iIBGEPais As Integer, _
                            ByVal sIE As String, _
                            ByVal sCampo13 As String, _
                            ByVal sEmail As String, _
                            ByVal sCampo15 As String)

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - CNPJ Destinatario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_destinatario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCNPJDestinatario : i += 1

            'Seta Parametros - Nome Fantasia 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_fantasia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeFantasia : i += 1

            'Seta Parametros - Razao Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sLogradouro : i += 1

            'Seta Parametros - Número 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumero : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sComplemento : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sBairro : i += 1

            'Seta Parametros - IBGE Municipio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ibge_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iIBGEMunicipio : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCEP : i += 1

            'Seta Parametros - IBGE Pais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ibge_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iIBGEPais : i += 1

            'Seta Parametros - IE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sIE : i += 1

            'Seta Parametros - Campo 13
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_13"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo13 : i += 1

            'Seta Parametros - EMAIL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmail : i += 1

            'Seta Parametros - Campo 15
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo_15"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo15

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_integracao_linha3", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLinha4()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_integracao_linha4", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLinha5(ByVal sFatura As String, _
                            ByVal fValorBruto As Double, _
                            ByVal fDesconto As Double, _
                            ByVal fValorLiquido As Double, _
                            ByVal iQuantidadeParcelas As Integer)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFatura : i += 1

            'Seta Parametros - Valor Bruto 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_bruto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = fValorBruto : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = fDesconto : i += 1

            'Seta Parametros - Valor Liquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = fValorLiquido : i += 1

            'Seta Parametros - Qtd Parcela 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iQuantidadeParcelas : i += 1

            'Seta Parametros - intervalor parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "intervalo_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iIntervaloParcela : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_integracao_linha5", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLinha5_Duplicata(ByVal sNumeroDuplicata As String, _
                                      ByVal dDataVencimento As Date, _
                                      ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Numero Duplicata
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_duplicata"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDuplicata : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataVencimento : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_integracao_linha5_duplicata", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLinha6(ByVal sCodigoProduto As String, _
                            ByVal sDescricao As String, _
                            ByVal sCFOP As String, _
                            ByVal sNCM As String, _
                            ByVal dQuantidade As Double, _
                            ByVal sUnidadeMedida As String, _
                            ByVal dValorUnitario As Double, _
                            ByVal dValorTotal As Double, _
                            ByVal dValorDesconto As Double, _
                            ByVal dValorFrete As Double, _
                            ByVal dValorSeguro As Double, _
                            ByVal dValorDespesa As Double, _
                            ByVal iOrigem As Integer, _
                            ByVal sTributacaoICMS As String)

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoProduto : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCFOP : i += 1

            'Seta Parametros - NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNCM : i += 1

            'Seta Parametros - Quantidade 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUnidadeMedida : i += 1

            'Seta Parametros - Valor Unitario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Valor total
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Valor Seguro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_seguro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorSeguro : i += 1

            'Seta Parametros -  Valor Deespesa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_despesa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDespesa : i += 1

            'Seta Parametros - Origem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iOrigem : i += 1

            'Seta Parametros - Tributacao ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tributacao_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTributacaoICMS : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_integracao_linha6", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLinha7()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_integracao_linha7", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLinha8(ByVal iModalidadeFrete As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Modalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iModalidadeFrete : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_integracao_linha8", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO XML :::"

    Public Sub ImportarXMLEmissao(ByVal sArquivoXML As String, _
                                     ByVal sArquivo As String, _
                                     ByRef sMensagem As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            sArquivoXML = sArquivoXML.Replace("<?xml version = '1.0' encoding = 'UTF-8'?>", "")
            sArquivoXML = sArquivoXML.Replace("xmlns=""http://www.portalfiscal.inf.br/nfe""", "")
            sArquivoXML = RetirarAcento2(sArquivoXML)

            'Seta Parametros - Arquivo XML
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_txt"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sArquivoXML : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Código do Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Hostname
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            sMensagem = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_importar_xml", oSqlParameter), String)

            If sMensagem = "" Then
                lCodigoEmissaoCapa = oSqlParameter(5).Value
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: BOLETA :::"

    Public Sub InsertBoleta(ByVal sCliente As String, _
                            ByVal sNumeroTicket As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_ticket"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroTicket : i += 1

            'Seta Parametros - Serie
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_boleta_capa", oSqlParameter)

            iCodigoBoleta = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertBoletaItem(ByVal iCodigoBoleta As String, _
                                 ByVal sProduto As String, _
                                 ByVal sQuantidade As String, _
                                 ByVal sUnidadeMedida As String, _
                                 ByVal sValorUnitario As String, _
                                 ByVal sValorTotal As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_boleta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.bigint
            oSqlParameter(i).Value = iCodigoBoleta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProduto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sQuantidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUnidadeMedida : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sValorUnitario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sValorTotal : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_boleta_linha", oSqlParameter)

          
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "::: IMPORTAÇAO EXCEL REMESSA :::"

    Public Sub InsertImpostoICMS(ByVal lCodigoEmissaoCapa As Long, _
                                 ByVal iCSTICMS As Integer, _
                                 ByVal sCSTICMS As String, _
                                 ByVal iModalidadeBCICMS As Integer, _
                                 ByVal dReducaoBCICMS As Double, _
                                 ByVal dBCICMS As Double, _
                                 ByVal dAliquotaICMS As Double, _
                                 ByVal dValorICMS As Double, _
                                 ByVal iModalidadeBCICMSST As Integer, _
                                 ByVal dIVA As Double, _
                                 ByVal dReducaoBCICMSST As Double, _
                                 ByVal dBCICMSST As Double, _
                                 ByVal dAliquotaICMSST As Double, _
                                 ByVal dValorICMSST As Double)

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sCSTICMS : i += 1

            'Seta Parametros - Código Modadelida Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBCICMS = -1, DBNull.Value, iModalidadeBCICMS) : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReducaoBCICMS : i += 1

            'Seta Parametros - Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBCICMS : i += 1

            'Seta Parametros - Aliquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - Código Modalidade Base Cálculo ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBCICMSST = -1, DBNull.Value, iModalidadeBCICMSST) : i += 1

            'Seta Parametros - IVA
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dIVA : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReducaoBCICMSST : i += 1

            'Seta Parametros - Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBCICMSST : i += 1

            'Seta Parametros - Alíquota ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMSST : i += 1

            'Seta Parametros - Valor ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMSST : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_icms_importacao_excel", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoIPI(ByVal lCodigoEmissaoCapa As Long, _
                                ByVal sCSTIPI As String, _
                                ByVal sClasseEnquadramento As String, _
                                ByVal sCodigoEnquadramento As String, _
                                ByVal iTipoCalculoIPI As Integer, _
                                ByVal dBCIPI As Double, _
                                ByVal dAliquotaIPI As Double, _
                                ByVal dValorUnidadeIPI As Double, _
                                ByVal dValorIPI As Double)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Situação Tributária IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sCSTIPI : i += 1

            'Seta Parametros - Classe Enquadramento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "classe_enquadramento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = IIf(sClasseEnquadramento = "", DBNull.Value, sClasseEnquadramento) : i += 1

            'Seta Parametros - Código Enquadramento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_enquadramento_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = IIf(sCodigoEnquadramento = "", DBNull.Value, sCodigoEnquadramento) : i += 1

            'Seta Parametros - Tipo Cálculo IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_calculo_imposto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iTipoCalculoIPI = -1, DBNull.Value, iTipoCalculoIPI) : i += 1

            'Seta Parametros - Base Cálculo IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBCIPI : i += 1

            'Seta Parametros - Aliquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIPI : i += 1

            'Seta Parametros - Valor Unidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnidadeIPI : i += 1

            'Seta Parametros - Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIPI : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_ipi_importacao_excel", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoPIS(ByVal lCodigoEmissaoCapa As Long, _
                                ByVal sCSTPIS As String, _
                                ByVal dBCPIS As Double, _
                                ByVal dAliquotaValorPis As Double, _
                                ByVal dValorPIS As Double)


        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Situação Tributária PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sCSTPIS : i += 1

            'Seta Parametros - Base Cálculo PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBCPIS : i += 1

            'Seta Parametros - Valor PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPIS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaValorPis : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_pis_importacao_excel", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoCOFINS(ByVal lCodigoEmissaoCapa As Long, _
                                   ByVal sCSTCOFINS As String, _
                                   ByVal iTipoCalculoCOFINS As Integer, _
                                   ByVal dBCCOFINS As Double, _
                                   ByVal dAliquotaCOFINS As Double, _
                                   ByVal dValorCofins As Double)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Situação Tributária COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sCSTCOFINS : i += 1

            'Seta Parametros - Tipo Cálculo COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_calculo_imposto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iTipoCalculoCOFINS = -1, DBNull.Value, iTipoCalculoCOFINS) : i += 1

            'Seta Parametros - Base Cálculo COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBCCOFINS : i += 1

            'Seta Parametros - Aliquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCofins : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_cofins_importacao_excel", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertItemExcelTemp(ByVal sProduto As String, _
                                   ByVal sDescricao As String, _
                                    ByVal dQuantidade As Double, _
                                    ByVal dValorUnitario As Double, _
                                    ByVal dValorTotal As Double)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProduto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_importacao_excel", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProdutoExcel(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_importacao_excel", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteProdutoExcel()

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_importacao_excel", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function InsertProdutoExcelNFe(ByVal iCodigoCfop As Integer, _
                                          ByVal sCodigoCfop As String) As Long

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCfop : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCfop : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_remessa_industrializacao_temp", oSqlParameter)

            Return oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function



#End Region

#End Region

#Region "::: DISPARO DE EMAIL :::"

    Public Sub EnviarEmailEmissaoNF(ByVal sChaveAcesso As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Chave de acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sChaveAcesso : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_email_faturamento_produto_emissao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub EnviarEmailEmissaoNFLogistica(ByVal sChaveAcesso As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Chave de acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sChaveAcesso : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_email_faturamento_op_faturada", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ORDEM DE PRODUÇÃO :::"

    Public Sub AtualizarStatusOp(ByVal sChaveAcesso As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Chave de acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sChaveAcesso : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_status_ordem_producao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
