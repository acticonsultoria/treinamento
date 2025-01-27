Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports Janus.Windows.EditControls
Imports System.IO

Public Class clsUsrFatEmissaoRelatorio

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
     
    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNotaFiscal As Long, _
                        ByVal iCodigoDestinatario As Integer, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sCodigoProduto As String, _
                        ByVal iCodigoTipoDocumentoFiscal As Integer, _
                        ByVal sCFOP As String, _
                        ByVal sStatus As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Destinatário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "destinatario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDestinatario : i += 1

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

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_fatutamento_emissao_relatorio", oSqlParameter)

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

End Class
