Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrFatEntradaNFXML

#Region "::: VARIAVEIS :::"

#Region "::: VARIAVEIS - CAPA :::"

    'Variaveis da Classe - Capa
    Private iTipoNotaFiscal As Integer
    Private sSerie As String
    Private sEspecie As String
    Private lNotaFiscal As Long
    Private sDataEmissao As String
    Private sDataEntrada As String
    Private iCodigoFormaPagamento As Integer
    Private sChaveAcesso As String
    Private sChaveAcessoDACTE As String
    Private sNumeroProtocolo As String
    Private sArquivoNFe As String
    Private sStatusNFe As String
    Private bInspecao As Boolean
    Private lCodigoEntradaCapa As Long
    Private iConfirmar As Integer

#End Region

#Region "::: VARIAVEIS - EMITENTE :::"

    'Váriaveis da Classe - Emitente
    Private lCodigoEmitente As Long
    Private sRazaoSocialEmitente As String
    Private sCnpjCpfEmitente As String
    Private sInscricaoEstadualEmitente As String
    Private sInscricaoEstadualSubstitutoTributarioEmitente As String
    Private iCodigoRegimeTributario As Integer
    Private sInscricaoMunicipalEmitente As String
    Private sCNAEEmitente As String
    Private sCepEmitente As String
    Private iCodigoPaisEmitente As Integer
    Private sUFEmitente As String
    Private iCodigoMunicipioEmitente As Integer
    Private sLogradouroEmitente As String
    Private sNumeroEmitente As String
    Private sComplementoEmitente As String
    Private sBairroEmitente As String
    Private sTelefoneEmitente As String
    Private sEmailEmitente As String
    Private bOutroLugarRetiradaEmitente As Boolean
    Private bOutroLugarEntregaEmitente As Boolean

#End Region

#Region "::: VARIAVEIS - TRANSPORTE :::"

    'Váriaveis da Classe - Transporte
    Private iCodigoModalidadeFrete As Integer
    Private iCodigoTransportadora As Integer
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

#Region "::: VARIAVEIS - EXPORTAÇÃO :::"

    'Váriaveis da Classe - Exportação
    Private sUFEmbarque As String
    Private sLocalEmbarque As String

#End Region

#Region "::: VARIAVEIS - COMPRAS :::"

    'Váriaveis da Classe - Compras
    Private sNotaEmpenho As String
    Private sInformacaoPedido As String
    Private sInformacaoContrato As String

#End Region

#Region "::: VARIAVEIS - FATURA :::"

    'Váriaveis da Classe - Fatura
    Private sFatura As String
    Private dValorOriginal As Double
    Private dValorDesconto As Double
    Private dValorAcrescimo As Double
    Private dValorLiquido As Double
    Private iNumeroParcela As Integer
    Private iIntervaloParcela As Integer

#End Region

#End Region

#Region "::: PROPERTIE :::"

#Region "::: PROPERTIE - CAPA :::"

    Public Property Confirmar() As Integer
        Get
            Return iConfirmar
        End Get
        Set(ByVal value As Integer)
            iConfirmar = value
        End Set
    End Property

    Public Property TipoNotaFiscal() As Integer
        Get
            Return iTipoNotaFiscal
        End Get
        Set(ByVal value As Integer)
            iTipoNotaFiscal = value
        End Set
    End Property

    Public Property Serie() As String
        Get
            Return sSerie
        End Get
        Set(ByVal value As String)
            sSerie = value
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

    Public Property Especie() As String
        Get
            Return sEspecie
        End Get
        Set(ByVal value As String)
            sEspecie = value
        End Set
    End Property

    Public Property ChaveAcesso() As String
        Get
            Return sChaveAcesso
        End Get
        Set(ByVal value As String)
            sChaveAcesso = value
        End Set
    End Property

    Public Property ChaveAcessoDACTE() As String
        Get
            Return sChaveAcessoDACTE
        End Get
        Set(ByVal value As String)
            sChaveAcessoDACTE = value
        End Set
    End Property

    Public Property NumeroProtocolo() As String
        Get
            Return sNumeroProtocolo
        End Get
        Set(ByVal value As String)
            sNumeroProtocolo = value
        End Set
    End Property

    Public Property ArquivoNFe() As String
        Get
            Return sArquivoNFe
        End Get
        Set(ByVal value As String)
            sArquivoNFe = value
        End Set
    End Property

    Public Property StatusNFe() As String
        Get
            Return sStatusNFe
        End Get
        Set(ByVal value As String)
            sStatusNFe = value
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

    Public Property DataEntrada() As String
        Get
            Return sDataEntrada
        End Get
        Set(ByVal value As String)
            sDataEntrada = value
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

    Public Property CodigoFormaPagamento() As Integer
        Get
            Return iCodigoFormaPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamento = value
        End Set
    End Property

    Public Property Inspecao() As Boolean
        Get
            Return bInspecao
        End Get
        Set(ByVal value As Boolean)
            bInspecao = value
        End Set
    End Property

    Public Property CodigoEntradaCapa() As Long
        Get
            Return lCodigoEntradaCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - EMITENTE :::"

    Public Property CodigoEmitente() As Long
        Get
            Return lCodigoEmitente
        End Get
        Set(ByVal value As Long)
            lCodigoEmitente = value
        End Set
    End Property

    Public Property RazaoSocialEmitente() As String
        Get
            Return sRazaoSocialEmitente
        End Get
        Set(ByVal value As String)
            sRazaoSocialEmitente = value
        End Set
    End Property

    Public Property CnpjCpfEmitente() As String
        Get
            Return sCnpjCpfEmitente
        End Get
        Set(ByVal value As String)
            sCnpjCpfEmitente = value
        End Set
    End Property

    Public Property InscricaoEstadualEmitente() As String
        Get
            Return sInscricaoEstadualEmitente
        End Get
        Set(ByVal value As String)
            sInscricaoEstadualEmitente = value
        End Set
    End Property

    Public Property InscricaoEstadualSubstitutoTributarioEmitente() As String
        Get
            Return sInscricaoEstadualSubstitutoTributarioEmitente
        End Get
        Set(ByVal value As String)
            sInscricaoEstadualSubstitutoTributarioEmitente = value
        End Set
    End Property

    Public Property CodigoRegimeTributario() As Integer
        Get
            Return iCodigoRegimeTributario
        End Get
        Set(ByVal value As Integer)
            iCodigoRegimeTributario = value
        End Set
    End Property

    Public Property InscricaoMunicipalEmitente() As String
        Get
            Return sInscricaoMunicipalEmitente
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipalEmitente = value
        End Set
    End Property

    Public Property CNAEEmitente() As String
        Get
            Return sCNAEEmitente
        End Get
        Set(ByVal value As String)
            sCNAEEmitente = value
        End Set
    End Property

    Public Property CepEmitente() As String
        Get
            Return sCepEmitente
        End Get
        Set(ByVal value As String)
            sCepEmitente = value
        End Set
    End Property

    Public Property CodigoPaisEmitente() As Integer
        Get
            Return iCodigoPaisEmitente
        End Get
        Set(ByVal value As Integer)
            iCodigoPaisEmitente = value
        End Set
    End Property

    Public Property UFEmitente() As String
        Get
            Return sUFEmitente
        End Get
        Set(ByVal value As String)
            sUFEmitente = value
        End Set
    End Property

    Public Property CodigoMunicipioEmitente() As Integer
        Get
            Return iCodigoMunicipioEmitente
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipioEmitente = value
        End Set
    End Property

    Public Property LogradouroEmitente() As String
        Get
            Return sLogradouroEmitente
        End Get
        Set(ByVal value As String)
            sLogradouroEmitente = value
        End Set
    End Property

    Public Property NumeroEmitente() As String
        Get
            Return sNumeroEmitente
        End Get
        Set(ByVal value As String)
            sNumeroEmitente = value
        End Set
    End Property

    Public Property ComplementoEmitente() As String
        Get
            Return sComplementoEmitente
        End Get
        Set(ByVal value As String)
            sComplementoEmitente = value
        End Set
    End Property

    Public Property BairroEmitente() As String
        Get
            Return sBairroEmitente
        End Get
        Set(ByVal value As String)
            sBairroEmitente = value
        End Set
    End Property

    Public Property TelefoneEmitente() As String
        Get
            Return sTelefoneEmitente
        End Get
        Set(ByVal value As String)
            sTelefoneEmitente = value
        End Set
    End Property

    Public Property EmailEmitente() As String
        Get
            Return sEmailEmitente
        End Get
        Set(ByVal value As String)
            sEmailEmitente = value
        End Set
    End Property

    Public Property OutroLugarEntregaEmitente() As Boolean
        Get
            Return bOutroLugarEntregaEmitente
        End Get
        Set(ByVal value As Boolean)
            bOutroLugarEntregaEmitente = value
        End Set
    End Property

    Public Property OutroLugarRetiradaEmitente() As Boolean
        Get
            Return bOutroLugarRetiradaEmitente
        End Get
        Set(ByVal value As Boolean)
            bOutroLugarRetiradaEmitente = value
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

    Public Property ValorAcrescimo() As Double
        Get
            Return dValorAcrescimo
        End Get
        Set(ByVal value As Double)
            dValorAcrescimo = value
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

    Public Property IntervaloParcela() As Integer
        Get
            Return iIntervaloParcela
        End Get
        Set(ByVal value As Integer)
            iIntervaloParcela = value
        End Set
    End Property

#End Region

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

#Region "::: FUNCTION / SUB :::"

#Region " ::: CAPA "


    Public Sub LoadGridNotaFiscal(ByVal oGrid As GridEX, _
                                  ByVal lNotaFiscal As Long, _
                                  ByVal sSerie As String, _
                                  ByVal sEmitente As String, _
                                  ByVal sDataEmissaoInicio As String, _
                                  ByVal sDataEmissaoTermino As String, _
                                  ByVal sProduto As String, _
                                  ByVal sLote As String, _
                                  ByVal sDataEntradaInicio As String, _
                                  ByVal sDataEntradaTermino As String, _
                                  ByVal sCFOP As String, _
                                  ByVal iCodigoTipoOperacao As Integer, _
                                  ByVal sNumeroDocumento As String, _
                                  ByVal sStatus As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(13) As SqlParameter
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
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sEmitente : i += 1

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

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sLote : i += 1

            'Seta Parametros - Data de Entrada - Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEntradaInicio = "", DBNull.Value, sDataEntradaInicio) : i += 1

            'Seta Parametros - Data de Entrada - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEntradaTermino = "", DBNull.Value, sDataEntradaTermino) : i += 1

            'Seta Parametros - CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCFOP : i += 1

            'Seta Parametros - Código Tipo de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoOperacao : i += 1

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_entrada_capa"))

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

            'Move para o Primeiro Registro
            oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridHistorico(ByVal oGrid As GridEX, _
                                 ByVal lCodigoEntradaCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_historico", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            'Move para o Primeiro Registro
            oGrid.MoveFirst()

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
            oSqlParameter(i).Value = StatusNotaFiscalEntrada.EntradaEfetuadaSucesso : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_capa", oSqlParameter)

            'Seta Váriavel 
            lCodigoEntradaCapa = oSqlParameter(4).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateNotaFiscal()

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo de Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoNotaFiscal : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Espécie
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "especie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sEspecie : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissao : i += 1

            'Seta Parametros - Data de Entrada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntrada : i += 1

            'Seta Parametros - Código Forma Pagamento NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaPagamento : i += 1

            'Seta Parametros - Chave de Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = IIf(sChaveAcesso = "", DBNull.Value, sChaveAcesso) : i += 1

            'Seta Parametros - Chave de Acesso DACTE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso_dacte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = IIf(sChaveAcessoDACTE = "", DBNull.Value, sChaveAcessoDACTE) : i += 1

            'Seta Parametros - Número do Protocolo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sNumeroProtocolo = "", DBNull.Value, sNumeroProtocolo) : i += 1

            'Seta Parametros - Arquivo NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = IIf(sArquivoNFe = "", DBNull.Value, sArquivoNFe) : i += 1

            'Seta Parametros - Status NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sStatusNFe = "", DBNull.Value, sStatusNFe) : i += 1

            'Seta Parametros - Inspeção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inspecao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bInspecao : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteNotaFiscal()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_capa", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteNotaFiscal(ByVal lCodigoEntradaCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteXML()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_xml", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNotaFiscal(ByVal lCodigoEntradaCapa As Long, _
                                   ByVal cboTipoNotaFiscal As UIComboBox, _
                                   ByVal txtNotaFiscal As MaskedEditBox, _
                                   ByVal txtEspecie As MaskedEditBox, _
                                   ByVal txtSerie As MaskedEditBox, _
                                   ByVal dtpDataEmissao As CalendarCombo, _
                                   ByVal dtpDataEntrada As CalendarCombo, _
                                   ByVal txtArquivo As MaskedEditBox, _
                                   ByVal txtNotaFiscalNFe As MaskedEditBox, _
                                   ByVal txtSerieNFe As MaskedEditBox, _
                                   ByVal txtDataEmissaoNFe As MaskedEditBox, _
                                   ByVal dtpDataEntradaNFe As CalendarCombo, _
                                   ByVal txtChaveAcessoNFe As MaskedEditBox, _
                                   ByVal txtChaveAcessoDACTE As MaskedEditBox, _
                                   ByVal txtNumeroProtocolo As MaskedEditBox, _
                                   ByVal txtStatusNFe As MaskedEditBox, _
                                   ByVal cboEmitente As UIComboBox, _
                                   ByVal chkLocalRetirada As UICheckBox, _
                                   ByVal chkLocalEntrega As UICheckBox, _
                                   ByVal cboModalidadeFrete As UIComboBox, _
                                   ByVal cboTransportadora As UIComboBox, _
                                   ByVal txtBaseCalculoTransporte As NumericEditBox, _
                                   ByVal txtAliquotaTransporte As NumericEditBox, _
                                   ByVal txtValorServicoTransporte As NumericEditBox, _
                                   ByVal cboUFICMSTransporte As UIComboBox, _
                                   ByVal cboMunicipioICMSTransporte As UIComboBox, _
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
                                   ByVal cboFormaPagamento As UIComboBox, _
                                   ByVal txtNumeroParcela As NumericEditBox, _
                                   ByVal txtIntervaloEntreParcelas As NumericEditBox, _
                                   ByVal txtInformacaoAdicionalContribuinte As EditBox, _
                                   ByVal txtInformacaoAdicionalFisco As EditBox, _
                                   ByVal cboUFEmbarque As UIComboBox, _
                                   ByVal txtLocalEmbarque As MaskedEditBox, _
                                   ByVal txtNotaEmpenho As MaskedEditBox, _
                                   ByVal txtInformacoesPedido As MaskedEditBox, _
                                   ByVal txtInformacoesContrato As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i = +1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_dados", oSqlParameter)

            If oSqlDataReader.HasRows = False Then

                'Limpa Controles
                cboTipoNotaFiscal.SelectedIndex = -1
                txtNotaFiscal.Text = ""
                dtpDataEmissao.Value = Now.Date
                dtpDataEntrada.Value = Now.Date
                txtArquivo.Text = ""
                txtNotaFiscalNFe.Text = ""
                txtSerieNFe.Text = ""
                txtDataEmissaoNFe.Text = ""
                dtpDataEntradaNFe.Value = Now.Date
                txtChaveAcessoNFe.Text = ""
                txtChaveAcessoDACTE.Text = ""
                txtNumeroProtocolo.Text = ""
                txtStatusNFe.Text = ""
                cboEmitente.SelectedIndex = -1
                chkLocalRetirada.Checked = False
                chkLocalEntrega.Checked = False
                cboModalidadeFrete.SelectedIndex = -1
                cboTransportadora.SelectedIndex = -1
                txtBaseCalculoTransporte.Value = 0
                txtAliquotaTransporte.Value = 0
                txtValorServicoTransporte.Value = 0
                cboUFICMSTransporte.SelectedIndex = -1
                cboMunicipioICMSTransporte.SelectedIndex = -1
                txtICMSRetidoTransporte.Value = 0
                cboTipoVeiculo.SelectedIndex = -1
                txtPlacaVeiculo.Text = ""
                cboUFVeiculo.SelectedIndex = -1
                txtRNTCVeiculo.Text = ""
                txtBalsa.Text = ""
                txtVagao.Text = ""
                txtBaseCalculoICMS.Value = 0
                txtTotalICMS.Value = 0
                txtBaseCalculoICMSST.Value = 0
                txtTotalICMSST.Value = 0
                txtTotalProdutoServico.Value = 0
                txtTotalFrete.Value = 0
                txtTotalSeguro.Value = 0
                txtTotalDesconto.Value = 0
                txtTotalII.Value = 0
                txtTotalIPI.Value = 0
                txtTotalPIS.Value = 0
                txtTotalCOFINS.Value = 0
                txtOutrasDespesas.Value = 0
                txtTotalNotaFiscal.Value = 0
                txtFatura.Text = ""
                txtValorOriginal.Value = 0
                txtValorDesconto.Value = 0
                txtValorLiquido.Value = 0
                cboFormaPagamento.SelectedIndex = -1
                txtNumeroParcela.Value = 0
                txtIntervaloEntreParcelas.Value = 0
                txtInformacaoAdicionalContribuinte.Text = ""
                txtInformacaoAdicionalFisco.Text = ""
                cboUFEmbarque.SelectedIndex = -1
                txtLocalEmbarque.Text = ""
                txtNotaEmpenho.Text = ""
                txtInformacoesPedido.Text = ""
                txtInformacoesContrato.Text = ""

            Else

                While oSqlDataReader.Read

                    cboTipoNotaFiscal.SelectedValue = oSqlDataReader.Item("codigo_tipo_nota_fiscal")
                    If oSqlDataReader.Item("codigo_tipo_nota_fiscal") = CInt(modDeclaration.TipoNotaFiscal.NotaFiscal) Or _
                       oSqlDataReader.Item("codigo_tipo_nota_fiscal") = CInt(modDeclaration.TipoNotaFiscal.CTRC) Or _
                       oSqlDataReader.Item("codigo_tipo_nota_fiscal") = CInt(modDeclaration.TipoNotaFiscal.DACTE) Or _
                       oSqlDataReader.Item("codigo_tipo_nota_fiscal") = CInt(modDeclaration.TipoNotaFiscal.NFST) Or _
                       oSqlDataReader.Item("codigo_tipo_nota_fiscal") = CInt(modDeclaration.TipoNotaFiscal.NFE) Then
                        txtNotaFiscal.Text = oSqlDataReader.Item("nota_fiscal")
                        txtSerie.Text = oSqlDataReader.Item("serie")
                        dtpDataEmissao.Value = oSqlDataReader.Item("data_emissao")
                        dtpDataEntrada.Value = oSqlDataReader.Item("data_entrada")
                    Else
                        txtArquivo.Text = oSqlDataReader.Item("arquivo_nfe")
                        txtNotaFiscalNFe.Text = oSqlDataReader.Item("nota_fiscal")
                        txtSerieNFe.Text = oSqlDataReader.Item("serie")
                        txtDataEmissaoNFe.Text = oSqlDataReader.Item("data_emissao")
                        dtpDataEntradaNFe.Value = oSqlDataReader.Item("data_entrada")
                        txtChaveAcessoNFe.Text = oSqlDataReader.Item("chave_acesso")
                        txtNumeroProtocolo.Text = oSqlDataReader.Item("numero_protocolo")
                        txtStatusNFe.Text = oSqlDataReader.Item("status_nfe")
                    End If
                    txtEspecie.Text = oSqlDataReader.Item("especie")
                    txtChaveAcessoDACTE.Text = oSqlDataReader.Item("chave_acesso_dacte")
                    cboEmitente.SelectedValue = oSqlDataReader.Item("codigo_emitente")
                    chkLocalRetirada.Checked = oSqlDataReader.Item("outro_lugar_retirada")
                    chkLocalEntrega.Checked = oSqlDataReader.Item("outro_lugar_entrega")
                    cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    cboTransportadora.SelectedValue = oSqlDataReader.Item("codigo_transportadora")
                    txtBaseCalculoTransporte.Value = oSqlDataReader.Item("base_calculo_retencao_icms")
                    txtAliquotaTransporte.Value = oSqlDataReader.Item("aliquota_retencao_icms")
                    txtValorServicoTransporte.Value = oSqlDataReader.Item("valor_servico")
                    cboUFICMSTransporte.SelectedValue = oSqlDataReader.Item("uf_fator_gerador")
                    cboMunicipioICMSTransporte.SelectedValue = oSqlDataReader.Item("codigo_municipio_fator_gerador")
                    txtICMSRetidoTransporte.Value = oSqlDataReader.Item("valor_icms_retido")
                    cboTipoVeiculo.SelectedValue = oSqlDataReader.Item("codigo_tipo_veiculo")
                    txtPlacaVeiculo.Text = oSqlDataReader.Item("placa")
                    cboUFVeiculo.SelectedValue = oSqlDataReader.Item("uf_placa")
                    txtRNTCVeiculo.Text = oSqlDataReader.Item("rntc")
                    txtBalsa.Text = oSqlDataReader.Item("balsa")
                    txtVagao.Text = oSqlDataReader.Item("vagao")
                    txtBaseCalculoICMS.Value = oSqlDataReader.Item("base_calculo_icms")
                    txtTotalICMS.Value = oSqlDataReader.Item("total_icms")
                    txtBaseCalculoICMSST.Value = oSqlDataReader.Item("base_calculo_icms_st")
                    txtTotalICMSST.Value = oSqlDataReader.Item("total_icms_st")
                    txtTotalProdutoServico.Value = oSqlDataReader.Item("total_produto_servico")
                    txtTotalFrete.Value = oSqlDataReader.Item("total_frete")
                    txtTotalSeguro.Value = oSqlDataReader.Item("total_seguro")
                    txtTotalDesconto.Value = oSqlDataReader.Item("total_desconto")
                    txtTotalII.Value = oSqlDataReader.Item("total_ii")
                    txtTotalIPI.Value = oSqlDataReader.Item("total_ipi")
                    txtTotalPIS.Value = oSqlDataReader.Item("pis")
                    txtTotalCOFINS.Value = oSqlDataReader.Item("cofins")
                    txtOutrasDespesas.Value = oSqlDataReader.Item("outras_despesas")
                    txtTotalNotaFiscal.Value = oSqlDataReader.Item("total_nota_fiscal")
                    txtFatura.Text = oSqlDataReader.Item("fatura")
                    txtValorOriginal.Value = oSqlDataReader.Item("valor_original")
                    txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto")
                    txtValorLiquido.Value = oSqlDataReader.Item("valor_liquido")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_nfe")
                    txtNumeroParcela.Value = oSqlDataReader.Item("numero_parcela")
                    txtIntervaloEntreParcelas.Value = oSqlDataReader.Item("intervalo_parcela")
                    txtInformacaoAdicionalContribuinte.Text = oSqlDataReader.Item("informacao_adicional_contribuinte")
                    txtInformacaoAdicionalFisco.Text = oSqlDataReader.Item("informacao_adicional_fisco")
                    cboUFEmbarque.SelectedValue = oSqlDataReader.Item("uf_embarque")
                    txtLocalEmbarque.Text = oSqlDataReader.Item("local_embarque")
                    txtNotaEmpenho.Text = oSqlDataReader.Item("nota_empenho")
                    txtInformacoesPedido.Text = oSqlDataReader.Item("informacao_pedido")
                    txtInformacoesContrato.Text = oSqlDataReader.Item("informacao_contrato")

                End While

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaDocumento(ByVal lCodigoEntradaCapa As Long, _
                                    ByVal iTipoNotaFiscal As Integer, _
                                    ByVal lNumeroDocumento As Long, _
                                    ByVal sSerie As String, _
                                    ByVal lCodigoFornecedor As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaDocumento = False

            'Seta Parametros - Codigo Tipo Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoNotaFiscal : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroDocumento : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Código Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoFornecedor : i += 1

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_entrada_capa", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaDocumento = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ImportarXML(ByVal sArquivoXML As String, _
                                ByVal sCaminhoArquivo As String) As String

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim sReturn As String
        Dim i As Integer = 0

        Try

            sArquivoXML = sArquivoXML.Replace("xmlns=""http://www.portalfiscal.inf.br/nfe""", "")
            sArquivoXML = RetirarAcento2(sArquivoXML)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_txt"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sArquivoXML : i += 1

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Caminho Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "caminho_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sCaminhoArquivo : i += 1

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

            'Seta Parametros - UF Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_emitente"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2

            'Executa Query
            sReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_importar_xml", oSqlParameter), String)

            If sReturn = "" Then
                'Seta Váriavel
                sUFEmitente = oSqlParameter(i).Value
            End If

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Cancelar(ByVal lCodigoEntradaCapa As Long, _
                        ByVal sJustificativa As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sJustificativa : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_capa_cancelar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateNFFatura(ByVal lCodigoEntradaCapa As Long, _
                              ByVal dDataEmissao As Date, _
                              ByVal sSerie As String, _
                              ByVal sNotaFiscal As String, _
                              ByVal sItem As String)

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataEmissao : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNotaFiscal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_nf_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



#End Region

#Region " ::: PRODUTO ::: "

    Public Sub DeleteProduto()

        Try

            'Váriaveis Locais
            Dim i As Integer
            Dim oSqlParameter(2) As SqlParameter

            'Exclui Registro
            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_entrada_item").Value : i += 1

                'Seta Parametros - Código Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_produto", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProduto(ByVal lCodigoEntradaCapa As Long, _
                               ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_produto", oSqlParameter)

            'Configura DataMember da Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid    
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertProdutoFatura(ByVal lCodigoEntradaCapa As Long, _
                             ByVal dValorTotal As Double, _
                             ByVal sItem As String)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Produto Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItem : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_nf_fatura", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: DESTINATÁRIO ::: "

    Public Sub InsertDestinatario()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_destinatario", oSqlParameter)

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_destinatario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDestinatarioFatura(ByVal lCodigoEntradaCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_destinatario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: EMITENTE ::: "

    Public Sub InsertEmitente()

        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmitente : i += 1

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sRazaoSocialEmitente : i += 1

            'Seta Parametros - CNPJ / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCnpjCpfEmitente : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadualEmitente : i += 1

            'Seta Parametros - Inscrição Estadual Substituto Tributário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual_substituto_tributario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadualSubstitutoTributarioEmitente : i += 1

            'Seta Parametros - Código Regime Tributário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_regime_tributario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoRegimeTributario = -1, DBNull.Value, iCodigoRegimeTributario) : i += 1

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sInscricaoMunicipalEmitente : i += 1

            'Seta Parametros - CNAE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 7
            oSqlParameter(i).Value = sCNAEEmitente : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCepEmitente : i += 1

            'Seta Parametros - Código Pais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPaisEmitente : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFEmitente : i += 1

            'Seta Parametros - Código Municipio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipioEmitente : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouroEmitente : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroEmitente : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplementoEmitente = "", DBNull.Value, sComplementoEmitente) : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairroEmitente : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sTelefoneEmitente = "", DBNull.Value, sTelefoneEmitente) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sEmailEmitente = "", DBNull.Value, sEmailEmitente) : i += 1

            'Seta Parametros - Outro Lugar - Retirada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outro_lugar_retirada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bOutroLugarRetiradaEmitente : i += 1

            'Seta Parametros - Outro Lugar - Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outro_lugar_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bOutroLugarRetiradaEmitente

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_emitente", oSqlParameter)

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_emitente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertEmitenteFatura(ByVal lCodigoEntradaCapa As Long, _
                                    ByVal iCodigoEmitente As Integer)

        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmitente : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_emitente_nf_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: TRANSPORTE ::: "

    Public Sub InsertTransporte()

        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            oSqlParameter(i).Value = IIf(iTipoVeiculo = -1, DBNull.Value, iTipoVeiculo) : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = IIf(iTipoVeiculo = CInt(modDeclaration.TipoVeiculo.VeiculoReboque), sPlacaVeiculo, DBNull.Value) : i += 1

            'Seta Parametros - UF Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_placa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(iTipoVeiculo = CInt(modDeclaration.TipoVeiculo.VeiculoReboque), sUFPlacaVeiculo, DBNull.Value) : i += 1

            'Seta Parametros - RNTC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rntc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(iTipoVeiculo = CInt(modDeclaration.TipoVeiculo.VeiculoReboque), sRNTCVeiculo, DBNull.Value) : i += 1

            'Seta Parametros - Vagão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "vagao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(iTipoVeiculo = CInt(modDeclaration.TipoVeiculo.Vagao), sVagao, DBNull.Value) : i += 1

            'Seta Parametros - Balsa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "balsa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(iTipoVeiculo = CInt(modDeclaration.TipoVeiculo.Balsa), sBalsa, DBNull.Value)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_transporte", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertTransporteFatura(ByVal lCodigoEntradaCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_transporte_nf_fatura", oSqlParameter)

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
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_transporte", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: TRANSPORTE - REBOQUE ::: "

    Public Sub DeleteReboque()

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(2) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_transporte_reboque", oSqlParameter)

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_transporte_reboque", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridReboque(ByVal lCodigoEntradaCapa As Long, _
                               ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_transporte_reboque", oSqlParameter)

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_transporte_reboque", oSqlParameter)

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
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaReboque = False

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_entrada_transporte_reboque", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaReboque = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region " ::: TRANSPORTE - VOLUME ::: "

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
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
                oSqlParameter(i).Value = gSelecaoRow(i).Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_transporte_volume", oSqlParameter)

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
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_transporte_volume", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridVolume(ByVal lCodigoEntradaCapa As Long, _
                              ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_transporte_volume", oSqlParameter)

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
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_transporte_volume", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: TOTAL ::: "

    Public Sub LoadDadosTotal(ByVal txtBaseCalculoICMS As NumericEditBox, _
                              ByVal txtTotalICMS As NumericEditBox, _
                              ByVal txtBaseCalculoICMSST As NumericEditBox, _
                              ByVal txtTotalICMSST As NumericEditBox, _
                              ByVal txtTotalProdutoServico As NumericEditBox, _
                              ByVal txtTotalIPI As NumericEditBox, _
                              ByVal txtTotalII As NumericEditBox, _
                              ByVal txtTotalPIS As NumericEditBox, _
                              ByVal txtTotalCOFINS As NumericEditBox, _
                              ByVal txtTotalFrete As NumericEditBox, _
                              ByVal txtTotalSeguro As NumericEditBox, _
                              ByVal txtTotalDesconto As NumericEditBox, _
                              ByVal txtTotalOutrasDespesas As NumericEditBox, _
                              ByVal txtTotalFCP As NumericEditBox, _
                              ByVal txtTotalICMSRemetente As NumericEditBox, _
                              ByVal txtTotalICMSDestino As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_totais", oSqlParameter)

            While oSqlDataReader.Read

                txtBaseCalculoICMS.Value = oSqlDataReader("base_calculo_icms")
                txtTotalICMS.Value = oSqlDataReader("total_icms")
                txtBaseCalculoICMSST.Value = oSqlDataReader("base_calculo_icms_st")
                txtTotalICMSST.Value = oSqlDataReader("total_icms_st")
                txtTotalFrete.Value = oSqlDataReader("total_frete")
                txtTotalSeguro.Value = oSqlDataReader("total_seguro")
                txtTotalDesconto.Value = oSqlDataReader("total_desconto")
                txtTotalOutrasDespesas.Value = oSqlDataReader("total_outras_despesas")
                txtTotalII.Value = oSqlDataReader("total_ii")
                txtTotalIPI.Value = oSqlDataReader("total_ipi")
                txtTotalPIS.Value = oSqlDataReader("total_pis")
                txtTotalCOFINS.Value = oSqlDataReader("total_cofins")
                txtTotalProdutoServico.Value = oSqlDataReader("total_produto_servico")
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

    Public Sub InsertTotal()

        'Variaveis Locais
        Dim oSqlParameter(30) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            oSqlParameter(i).Value = dValorRemetenteICMSPartilha : i += 1

            'Seta Parametros - Total Serviço Não Tributado ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_servico_nao_tributado_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTotalServicoNaoTributadoICMS

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_total", oSqlParameter)

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_total", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: INFORMAÇÕES ADICIONAIS ::: "

    Public Sub InsertInformacaoAdicional()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_informacoes_adicionais", oSqlParameter)

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_informacoes_adicionais", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: EXPORTAÇÃO ::: "

    Public Sub InsertExportacao()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            oSqlParameter(i).Value = IIf(sUFEmbarque = "", DBNull.Value, sUFEmbarque) : i += 1

            'Seta Parametros - Local de Embarque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "local_embarque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sLocalEmbarque = "", DBNull.Value, sLocalEmbarque)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_exportacao", oSqlParameter)

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_exportacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: COMPRAS ::: "

    Public Sub InsertCompras()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_compras", oSqlParameter)

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_compras", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region " ::: FATURA ::: "

    Public Sub InsertFatura()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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

            'Seta Parametros - Valor Acréscimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_acrescimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorAcrescimo = 0, DBNull.Value, dValorAcrescimo) : i += 1

            'Seta Parametros - Valor Liquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorLiquido = 0, DBNull.Value, dValorLiquido) : i += 1

            'Seta Parametros - Número Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Intervalo Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "intervalo_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iIntervaloParcela

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_fatura", oSqlParameter)

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosFatura(ByVal txtValorOriginal As NumericEditBox, _
                               ByVal txtValorDesconto As NumericEditBox, _
                               ByVal txtValorAcrescimo As NumericEditBox, _
                               ByVal iModalidadeFrete As Integer)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_totais_fatura", oSqlParameter)

            While oSqlDataReader.Read

                txtValorOriginal.Value = oSqlDataReader.Item("valor_original")
                txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto")
                txtValorAcrescimo.Value = oSqlDataReader.Item("valor_acrescimo")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNFFatura(ByVal txtValorOriginal As NumericEditBox, _
                               ByVal txtValorDesconto As NumericEditBox, _
                               ByVal txtValorAcrescimo As NumericEditBox, _
                               ByVal iModalidadeFrete As Integer)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_totais_nf_fatura", oSqlParameter)

            While oSqlDataReader.Read

                txtValorOriginal.Value = oSqlDataReader.Item("valor_original")
                txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto")
                txtValorAcrescimo.Value = oSqlDataReader.Item("valor_acrescimo")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub LoadControlesTituloPrevisao(ByVal lCodigo As Long, _
                                           ByVal txtNumeroDocumentoPrevisto As MaskedEditBox,
                                           ByVal txtValorPrevisto As NumericEditBox, _
                                           ByVal cboCentroGasto As UIComboBox, _
                                           ByVal txtTituloDescritivo As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_titulo_previsto_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtNumeroDocumentoPrevisto.Text = oSqlDataReader.Item("numero_documento")
                    txtValorPrevisto.Value = oSqlDataReader.Item("valor")
                    txtTituloDescritivo.Text = oSqlDataReader.Item("descritivo")
                    cboCentroGasto.SelectedValue = IIf(IsDBNull(oSqlDataReader.Item("codigo_centro_custo")), -1, oSqlDataReader.Item("codigo_centro_custo"))


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

    Public Sub UpdateVinculoTituloPrevisao(ByVal lCodigoTituloPrevisto As Long, _
                                           ByVal lCodigoTituloCapa As Long, _
                                           ByVal lCodigoCentroCusto As Long, _
                                           ByVal sDescritivo As String, _
                                           ByVal sNumeroDocumentoPrevisto As String, _
                                           ByVal dValorPrevisto As Double)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCentroCusto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sDescritivo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sNumeroDocumentoPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Decimal
            oSqlParameter(i).Value = dValorPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_titulo_vinculo_previsao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteVinculoTituloPrevisao(ByVal lCodigoTituloPrevisto As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_titulo_previsto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosVinculoTituloPrevisto(ByVal lCodigoTituloCapa As Long, _
                                               ByVal cboTituloPrevisto As UIComboBox, _
                                               ByVal txtNumDocumentoPrevisto As MaskedEditBox, _
                                               ByVal txtValorPrevisto As NumericEditBox, _
                                               ByVal txtTituloDescritivo As MaskedEditBox, _
                                               ByVal cboCentroGasto As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_titulo_previsao_dados", oSqlParameter)

            While oSqlDataReader.Read



                txtValorPrevisto.Value = oSqlDataReader.Item("valor_previsto")
                txtNumDocumentoPrevisto.Text = oSqlDataReader.Item("numero_documento_previsto")
                txtTituloDescritivo.Text = oSqlDataReader.Item("descritivo")


                If IIf(IsDBNull(oSqlDataReader.Item("codigo_centro_custo")), -1, oSqlDataReader.Item("codigo_centro_custo")) = -1 Then
                    cboCentroGasto.SelectedIndex = -1
                Else
                    cboCentroGasto.SelectedValue = IIf(IsDBNull(oSqlDataReader.Item("codigo_centro_custo")), -1, oSqlDataReader.Item("codigo_centro_custo"))
                End If


                If oSqlDataReader.Item("numero_documento_previsto") <> "" Then
                    cboTituloPrevisto.Enabled = False
                    txtNumDocumentoPrevisto.Enabled = False
                    txtValorPrevisto.Enabled = False
                    cboCentroGasto.Enabled = False
                    txtTituloDescritivo.Enabled = False
                Else
                    cboTituloPrevisto.Enabled = True
                    txtNumDocumentoPrevisto.Enabled = True : txtNumDocumentoPrevisto.Text = ""
                    txtValorPrevisto.Enabled = True : txtValorPrevisto.Value = 0
                    cboCentroGasto.Enabled = True
                    txtTituloDescritivo.Enabled = True : txtTituloDescritivo.Text = ""
                End If


            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

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

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa

            'Executa Query
            lCodigoFinanceiro = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_financeiro", oSqlParameter)

            'Retorno da Função
            Return lCodigoFinanceiro

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region " ::: FATURA - DUPLICATA ::: "

    Public Sub InsertFaturaDuplicata(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim i As Integer
            Dim oSqlParameter(5) As SqlParameter

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

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
                oSqlParameter(i).Value = oRow.Cells("valor").Value : i += 1

                'Seta Parametros - Valor Pago
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_pago"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = IIf(oRow.Cells("pago").Value = True, oRow.Cells("valor").Value, DBNull.Value)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_fatura_duplicata", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDuplicata(ByVal lCodigoEntradaCapa As Long, _
                                 ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_fatura_duplicata", oSqlParameter)

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
                Dim dValorResidual As Double = dValor

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
                    oDataRow("valor") = IIf(iNumeroParcela = i, dValorResidual, FormatNumber(dValor / iNumeroParcela, 2))
                    dValorResidual -= FormatNumber(dValor / iNumeroParcela, 2)
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

    Public Function ValidaFaturaDuplicataPagamento(ByVal lCodigoEntradaCapa As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaFaturaDuplicataPagamento = False

            'Seta Parametros - Codigo Tipo Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_entrada_fatura_duplicata_pagamento", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaFaturaDuplicataPagamento = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: LACRE :::"

    Public Sub DeleteLacre(ByVal lCodigoEntradaCapa As Long, _
                           ByVal iCodigoEntradaTransporteVolume As Integer)

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(3) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Codigo Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

                'Seta Parametros - Codigo Entrada Transporte Volume
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_transporte_volume"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iCodigoEntradaTransporteVolume : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Número do Lacre
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_lacre"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("lacre").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_transporte_volume_lacre", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLacre(ByVal lCodigoEntradaCapa As Long, _
                           ByVal iCodigoEntradaTransporteVolume As Integer, _
                           ByVal sNumeroLacre As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Codigo Entrada Transporte Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_transporte_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaTransporteVolume : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número do Lacre
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_lacre"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroLacre

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_transporte_volume_lacre", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridLacre(ByVal oGrid As GridEX, _
                             ByVal lCodigoEntradaCapa As Long, _
                             ByVal iCodigoEntradaTransporteVolume As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Codigo Entrada Transporte Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_transporte_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaTransporteVolume : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_transporte_volume_lacre", oSqlParameter)

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

    Public Sub UpdateLacre(ByVal lCodigoEntradaCapa As Long, _
                           ByVal iCodigoEntradaTransporteVolume As Integer, _
                           ByVal sNumeroLacre As String, _
                           ByVal sNumeroLacreAntigo As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Codigo Entrada Transporte Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_transporte_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaTransporteVolume : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número do Lacre
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_lacre"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroLacre : i += 1

            'Seta Parametros - Número do Lacre Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_lacre_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroLacreAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_transporte_volume_lacre", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: KIT - COMPOSIÇÃO :::"

    Public Sub LoadGridKITTmp(ByVal oGrid As GridEX, _
                              ByVal lCodigoEntradaCapa As Long, _
                              ByVal iCodigoEntradaItem As Integer, _
                              ByVal iCodigoEntradaItemLote As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Codigo Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Codigo Entrada Item Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItemLote : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_item_lote_kit_tmp", oSqlParameter)

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

    Public Sub DeleteKITTmp(ByVal lCodigoEntradaCapa As Long, _
                            ByVal iCodigoEntradaItem As Integer, _
                            ByVal iCodigoEntradaItemLote As Integer)

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(4) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Codigo Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

                'Seta Parametros - Codigo Entrada Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

                'Seta Parametros - Codigo Entrada Item Lote
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_item_lote"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iCodigoEntradaItemLote : i += 1

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
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_item_lote_kit_tmp", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertKITTmp(ByVal lCodigoEntradaCapa As Long, _
                            ByVal iCodigoEntradaItem As Integer, _
                            ByVal iCodigoEntradaItemLote As Integer, _
                            ByVal lCodigoItemOriginal As Long, _
                            ByVal lCodigoItemOpcional As Long, _
                            ByVal dQuantidade As Double, _
                            ByVal sLote As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Codigo Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Codigo Entrada Item Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItemLote : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemOriginal : i += 1

            'Seta Parametros - Código Item Opcional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_opcional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemOpcional = -1, DBNull.Value, lCodigoItemOpcional) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_lote_kit_tmp", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidateKITTmp(ByVal lCodigoEntradaCapa As Long, _
                                   ByVal iCodigoEntradaItem As Integer, _
                                   ByVal iCodigoEntradaItemLote As Integer, _
                                   ByVal lCodigoItemOriginal As Long, _
                                   ByVal dQuantidade As Double, _
                                   ByVal iCodigo As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Codigo Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Codigo Entrada Item Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItemLote : i += 1

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
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Item Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemOriginal : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_kit"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_entrada_item_lote_kit_tmp", oSqlParameter)

            'Seta Retorno da Função
            Return IIf(iReturn = 1, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub UpdateKITTmp(ByVal lCodigoEntradaCapa As Long, _
                            ByVal iCodigoEntradaItem As Integer, _
                            ByVal iCodigoEntradaItemLote As Integer, _
                            ByVal lCodigoItemOriginal As Long, _
                            ByVal lCodigoItemOpcional As Long, _
                            ByVal dQuantidade As Double, _
                            ByVal sLote As String, _
                            ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Codigo Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Codigo Entrada Item Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItemLote : i += 1

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
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Item Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemOriginal : i += 1

            'Seta Parametros - Código Item Opcional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_opcional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemOpcional = -1, DBNull.Value, lCodigoItemOpcional) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_item_lote_kit_tmp", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: IMPOSTOS :::"

    Public Sub InsertImpostoICMSFatura(ByVal lCodigoEntradaCapa As Long, _
                                       ByVal sItem As String)

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItem : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_icms_nf_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoIPIFatura(ByVal lCodigoEntradaCapa As Long, _
                                     ByVal sItem As String)

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItem : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_ipi_nf_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoPISFatura(ByVal lCodigoEntradaCapa As Long, _
                                ByVal sItem As String)

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItem : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_pis_nf_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoCOFINSFatura(ByVal lCodigoEntradaCapa As Long, _
                                   ByVal sItem As String)

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItem : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_cofins_nf_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: XML :::"

    Public Function ValidaFornecedorHomologado(ByVal lCodigoItem As Long, _
                                               ByVal lCodigoEntradaCapa As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim bRetorno As Boolean
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            bRetorno = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_entrada_item_fornecedor", oSqlParameter), Boolean)

            Return bRetorno

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosConfirmar(ByVal lCodigoEntradaCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim iCodigoEntradaItem As Integer
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Confirmar
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "confirmar"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_confirmar_xml", oSqlParameter)

            Confirmar = oSqlParameter(i).Value
             
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Public Sub LoadDadosConfirmar(ByVal oGrid As GridEX, _
    '                              ByVal lCodigoEntradaCapa As Long)

    '    'Variaveis Locais
    '    Dim oDataSet As DataSet
    '    Dim oSqlParameter(2) As SqlParameter
    '    Dim iCodigoEntradaItem As Integer
    '    Dim i As Integer = 0

    '    Try

    '        'Seta Parametros - Código Entrada Capa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_entrada_capa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

    '        'Seta Parametros - Código Empresa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_empresa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

    '        'Seta Parametros - Confirmar
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "confirmar"
    '        oSqlParameter(i).Direction = ParameterDirection.Output
    '        oSqlParameter(i).SqlDbType = SqlDbType.Int 

    '        'Executa Query
    '        oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_confirmar_xml", oSqlParameter)

    '        Confirmar = oSqlParameter(i).Value

    '        ''Configura DataMember Grid
    '        'Call ConfigurarDataMemberGrid(oGrid)

    '        ''Carrega(Grid)
    '        'oGrid.DataSource = oDataSet.DefaultViewManager
    '        'oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Public Sub LoadDadosProduto(ByVal iCodigoTipoOperacao As Integer, _
                                ByVal iCodigoOrdemProducao As Integer, _
                                ByVal lCodigoItem As Long, _
                                ByVal lCodigoEntradaCapa As Long, _
                                ByVal iCodigoEntradaItem As Integer, _
                                ByVal iCodigoEntradaItemLote As Integer, _
                                ByVal sOperacao As String, _
                                ByVal lCodigoPedido As Long, _
                                ByVal iCodigoPedidoItem As Integer, _
                                ByVal iCodigoPedidoItemEntrega As Integer, _
                                ByVal lCodigoEmissaoCapa As Long, _
                                ByVal iCodigoEmissaoItem As Integer, _
                                ByRef iCodigoUnidadeMedida As Integer, _
                                ByRef bItemEstoque As Boolean, _
                                ByRef bQualidade As Boolean, _
                                ByRef bLote As Boolean, _
                                ByRef bDataFabricacao As Boolean, _
                                ByRef bDataValidade As Boolean, _
                                ByRef dQuantidadePedido As Double, _
                                ByRef dQuantidadePendente As Double, _
                                ByRef dValorUnitario As Double, _
                                ByRef dFatorConversao As Double, _
                                ByRef sUnidadeMedida As String, _
                                ByRef dToleranciaQuantidade As Double, _
                                ByRef dToleranciaValor As Double, _
                                ByRef iCodigoCentroGasto As Integer, _
                                ByRef sContaContabil As String, _
                                Optional ByRef dAliquotaICMS As Double = 0, _
                                Optional ByRef dAliquotaIPI As Double = 0, _
                                Optional ByRef dAliquotaPISCOFINS As Double = 0, _
                                Optional ByRef dAliquotaICMSUltimaNF As Double = 0)

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoOperacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOrdemProducao : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Código Entrada Item Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItemLote : i += 1

            'Seta Parametros - Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sOperacao : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Pedido Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItemEntrega : i += 1

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
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_dados_produto", oSqlParameter)

            While oSqlDataReader.Read

                'Seta Váriaveis
                iCodigoUnidadeMedida = oSqlDataReader.Item("codigo_unidade_medida")
                bQualidade = oSqlDataReader.Item("controla_qualidade")
                lCodigoItem = oSqlDataReader.Item("codigo_item")
                bItemEstoque = oSqlDataReader.Item("item_estoque")
                bLote = oSqlDataReader.Item("controla_lote")
                bDataFabricacao = oSqlDataReader.Item("controla_data_fabricacao")
                bDataValidade = oSqlDataReader.Item("controla_validade")
                dQuantidadePedido = oSqlDataReader.Item("quantidade_pedido")
                dQuantidadePendente = oSqlDataReader.Item("quantidade_pendente")
                dValorUnitario = oSqlDataReader.Item("valor_unitario")
                dFatorConversao = oSqlDataReader.Item("fator_conversao")
                sUnidadeMedida = oSqlDataReader.Item("unidade_medida")
                dToleranciaQuantidade = oSqlDataReader.Item("tolerancia_quantidade")
                dToleranciaValor = oSqlDataReader.Item("tolerancia_valor")
                iCodigoCentroGasto = oSqlDataReader.Item("codigo_centro_gasto")
                sContaContabil = oSqlDataReader.Item("conta_contabil")
                dAliquotaICMS = oSqlDataReader.Item("aliquota_icms")
                dAliquotaIPI = oSqlDataReader.Item("aliquota_ipi")
                dAliquotaPISCOFINS = oSqlDataReader.Item("aliquota_pis_cofins")
                dAliquotaICMSUltimaNF = oSqlDataReader.Item("aliquota_icms_ultima_nf")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridItemXML(ByVal oGrid As GridEX, _
                           ByVal lCodigoEntradaCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim iCodigoEntradaItem As Integer
        Dim i As Integer = 0

        Try
             
            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_item_tmp", oSqlParameter)

            'Configura DataMember Grid
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

    Public Sub LoadGridXML(ByVal oGrid As GridEX, _
                           ByVal lCodigoEntradaCapa As Long, _
                           ByRef oCurrentRow As GridEXRow)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim iCodigoEntradaItem As Integer
        Dim i As Integer = 0

        Try

            'Carrega Váriavel
            If IsNothing(oCurrentRow) = False Then iCodigoEntradaItem = oCurrentRow.Cells("codigo_entrada_item").Value

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_item_tmp", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            'Seleciona Registro            
            For Each oRow As GridEXRow In oGrid.GetDataRows
                If oRow.Cells("codigo_entrada_item").Value = iCodigoEntradaItem Then
                    oCurrentRow = oRow
                End If
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridRecebimento(ByVal oGrid As GridEX, _
                                   ByVal lCodigoEntradaCapa As Long, _
                                   ByVal iCodigoEntradaItem As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_item_pedido_tmp", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SalvarXML(ByVal lCodigoEntradaCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_item_tmp", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteRecebimento()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_entrada_capa").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Entrada Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_entrada_item").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_item_pedido_tmp", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Cancelar(ByVal lCodigoEntradaCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_item_pedido_tmp_cancelar", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRecebimento(ByVal lCodigoEntradaCapa As Long, _
                                 ByVal iCodigoEntradaItem As Integer, _
                                 ByVal iCodigoCFOP As Integer, _
                                 ByVal iCodigoTipoOperacao As Integer, _
                                 ByVal sNumeroDocumento As String, _
                                 ByVal lCodigoItem As Long, _
                                 ByVal bControlaQualidade As Boolean, _
                                 ByVal dQuantidade As Double, _
                                 ByVal iCodigoUnidadeMedida As Integer, _
                                 ByVal dQuantidadeEstoque As Double, _
                                 ByVal iCodigoDeposito As Integer, _
                                 ByVal sLote As String, _
                                 ByVal sDataValidade As String, _
                                 ByVal sDataFabricacao As String, _
                                 ByVal iNumeroMesesValidade As Integer, _
                                 ByVal iCodigoCentroGasto As Integer, _
                                 ByVal sContaContabil As String, _
                                 ByVal lCodigoPedido As Long, _
                                 ByVal iCodigoPedidoItem As Integer, _
                                 ByVal iCodigoPedidoItemEntrega As Integer, _
                                 ByVal lCodigoEmissaoCapa As Long, _
                                 ByVal iCodigoEmissaoItem As Integer, _
                                 ByVal lCodigoOrdemProducao As Long, _
                                 ByVal sKIT As String)

        'Variaveis Locais
        Dim oSqlParameter(24) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Código CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCFOP : i += 1

            'Seta Parametros - Código Tipo de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoOperacao : i += 1

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Controla Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bControlaQualidade : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, iCodigoUnidadeMedida) : i += 1

            'Seta Parametros - Fator de Conversão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidade = 0, 0, dQuantidadeEstoque / dQuantidade) : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoDeposito = -1, DBNull.Value, iCodigoDeposito) : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            'Seta Parametros - Data de Fabricação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fabricacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataFabricacao) = False, DBNull.Value, sDataFabricacao) : i += 1

            'Seta Parametros - Data de Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade) = False, DBNull.Value, sDataValidade) : i += 1

            'Seta Parametros - Nº Meses Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_meses_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroMesesValidade : i += 1

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_gasto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sContaContabil = "", DBNull.Value, sContaContabil) : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPedido = -1, DBNull.Value, lCodigoPedido) : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItem = -1, DBNull.Value, iCodigoPedidoItem) : i += 1

            'Seta Parametros - Código Pedido Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItemEntrega = -1, DBNull.Value, iCodigoPedidoItemEntrega) : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEmissaoCapa = -1, DBNull.Value, lCodigoEmissaoCapa) : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEmissaoItem = -1, DBNull.Value, iCodigoEmissaoItem) : i += 1

            'Seta Parametros - Código Ordem de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoOrdemProducao = -1, DBNull.Value, lCodigoOrdemProducao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_item_pedido_tmp", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRecebimento(ByVal lCodigoEntradaCapa As Long, _
                                 ByVal iCodigoEntradaItem As Integer, _
                                 ByVal iCodigo As Integer, _
                                 ByVal iCodigoCFOP As Integer, _
                                 ByVal iCodigoTipoOperacao As Integer, _
                                 ByVal sNumeroDocumento As String, _
                                 ByVal lCodigoItem As Long, _
                                 ByVal bControlaQualidade As Boolean, _
                                 ByVal dQuantidade As Double, _
                                 ByVal iCodigoUnidadeMedida As Integer, _
                                 ByVal dQuantidadeEstoque As Double, _
                                 ByVal iCodigoDeposito As Integer, _
                                 ByVal sLote As String, _
                                 ByVal sDataValidade As String, _
                                 ByVal sDataFabricacao As String, _
                                 ByVal iNumeroMesesValidade As Integer, _
                                 ByVal iCodigoCentroGasto As Integer, _
                                 ByVal sContaContabil As String, _
                                 ByVal lCodigoPedido As Long, _
                                 ByVal iCodigoPedidoItem As Integer, _
                                 ByVal iCodigoPedidoItemEntrega As Integer, _
                                 ByVal lCodigoEmissaoCapa As Long, _
                                 ByVal iCodigoEmissaoItem As Integer, _
                                 ByVal lCodigoOrdemProducao As Long, _
                                 ByVal sKIT As String)

        'Variaveis Locais
        Dim oSqlParameter(25) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Entrada Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCFOP : i += 1

            'Seta Parametros - Código Tipo de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoOperacao : i += 1

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Controla Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bControlaQualidade : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, iCodigoUnidadeMedida) : i += 1

            'Seta Parametros - Fator de Conversão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidade = 0, 0, dQuantidadeEstoque / dQuantidade) : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoDeposito = -1, DBNull.Value, iCodigoDeposito) : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            'Seta Parametros - Data de Fabricação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fabricacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataFabricacao) = False, DBNull.Value, sDataFabricacao) : i += 1

            'Seta Parametros - Data de Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade) = False, DBNull.Value, sDataValidade) : i += 1

            'Seta Parametros - Nº Meses Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_meses_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroMesesValidade : i += 1

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_gasto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sContaContabil = "", DBNull.Value, sContaContabil) : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPedido = -1, DBNull.Value, lCodigoPedido) : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItem = -1, DBNull.Value, iCodigoPedidoItem) : i += 1

            'Seta Parametros - Código Pedido Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItemEntrega = -1, DBNull.Value, iCodigoPedidoItemEntrega) : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoEmissaoCapa = -1, DBNull.Value, lCodigoEmissaoCapa) : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEmissaoItem = -1, DBNull.Value, iCodigoEmissaoItem) : i += 1

            'Seta Parametros - Código Ordem de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoOrdemProducao = -1, DBNull.Value, lCodigoOrdemProducao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_item_pedido_tmp", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateStatus(ByVal lCodigoEntradaCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_status_confirmar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
