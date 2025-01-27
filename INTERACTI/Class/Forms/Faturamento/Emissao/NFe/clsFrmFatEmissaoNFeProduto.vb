Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsFrmFatEmissaoNFeProduto

#Region "::: VARIAVEIS :::"

    'Dados Item
    Private lCodigoEmissaoCapa As Long
    Private iCodigoEmissaoItem As Integer
    Private iCodigoPedido As Integer
    Private iCodigoItem As Integer
    Private lCodigoItem As Long
    Private sCodigoProdutoServico As String
    Private sCodigoEAN As String
    Private sDescricao As String
    Private iCodigoCFOP As Integer
    Private sCFOP As String
    Private iCodigoNCM As Integer
    Private sNCM As String
    Private sLote As String
    Private dQuantidade As Double
    Private iCodigoUnidadeMedida As Integer
    Private sUnidadeMedida As String
    Private dValorUnitario As Double
    Private dValorFrete As Double
    Private dValorSeguro As Double
    Private dValorOutrasDespesas As Double
    Private dValorDesconto As Double
    Private dValorTotal As Double
    Private bIncideValorTotalNF As Boolean
    Private sPedidoCompra As String
    Private iNumeroItemPedidoCompra As Integer
    Private sInformacoesAdicionais As String
    Private iCodigoEmissaoDI As Integer
    Private sCodigoFabricante As String
    Private bCalculoAutomatico As Boolean
    Private sCEST As String
    Private sCodigoBeneficiamento As String

    'COFINS
    Private iCodigoSituacaoTributariaCOFINS As Integer
    Private sSituacaoTributariaCOFINS As String
    Private iTipoCalculoCOFINS As Integer
    Private dBaseCalculoCOFINS As Double
    Private dAliquotaPorcentagemCOFINS As Double
    Private dAliquotaValorCOFINS As Double
    Private dQuantidadeVendidaCOFINS As Double
    Private dValorCOFINS As Double
    Private iTipoCalculoCOFINSST As Integer
    Private dBaseCalculoCOFINSST As Double
    Private dAliquotaPorcentagemCOFINSST As Double
    Private dAliquotaValorCOFINSST As Double
    Private dQuantidadeVendidaCOFINSST As Double
    Private dValorCOFINSST As Double

    'ICMS
    Private iCodigoOrigemItem As Integer
    Private iCodigoSituacaoTributariaICMS As Integer
    Private sSituacaoTributariaICMS As String
    Private iModalidadeBaseCalculoICMS As Integer
    Private dPorcentagemReducaoBaseCalculoICMS As Double
    Private dBaseCalculoICMS As Double
    Private dAliquotaICMS As Double
    Private dValorICMS As Double
    Private iModalidadeBaseCalculoICMSST As Integer
    Private dIVA As Double
    Private dPorcentagemReducaoBaseCalculoICMSST As Double
    Private dBaseCalculoICMSST As Double
    Private dAliquotaICMSST As Double
    Private dValorICMSST As Double

    'ICMS - Simples
    Private iCodigoOrigemItemSimples As Integer
    Private iCodigoSituacaoTributariaICMSSimples As Integer
    Private sSituacaoTributariaICMSSimples As String
    Private iModalidadeBaseCalculoICMSSimples As Integer
    Private dPorcentagemReducaoBaseCalculoICMSSimples As Double
    Private dBaseCalculoICMSSimples As Double
    Private dAliquotaICMSSimples As Double
    Private dValorICMSSimples As Double
    Private iModalidadeBaseCalculoICMSSTSimples As Integer
    Private dIVASimples As Double
    Private dPorcentagemReducaoBaseCalculoICMSSTSimples As Double
    Private dBaseCalculoICMSSTSimples As Double
    Private dAliquotaICMSSTSimples As Double
    Private dValorICMSSTSimples As Double

    'ICMS - Partilha
    Private dBaseCalculoICMSPartilha As Double
    Private dPercentualFCPICMSPartilha As Double
    Private dPercentualDestinoICMSPartilha As Double
    Private dPercentualInterestadualICMSPartilha As Double
    Private dPercentualPartilhaICMSPartilha As Double
    Private dValorFCPICMSPartilha As Double
    Private dValorDestinoICMSPartilha As Double
    Private dValorRemetenteICMSPartilha As Double

    'II
    Private dBaseCalculoII As Double
    Private dDespesaAduaneira As Double
    Private dAliquotaIOF As Double
    Private dAliquotaII As Double

    'IPI
    Private sClasseEnquadramentoIPI As String
    Private sCNPJProdutorIPI As String
    Private sCodigoSeloControleIPI As String
    Private lQuantidadeSeloControleIPI As Long
    Private sCodigoEnquadramentoIPI As String
    Private sSituacaoTributariaIPI As String
    Private iTipoCalculoIPI As Integer
    Private dBaseCalculoIPI As Double
    Private dAliquotaIPI As Double
    Private dQuantidadeTotalUnidadePadraoIPI As Double
    Private dValorUnidadeIPI As Double
    Private dValorIPI As Double

    'PIS
    Private iCodigoSituacaoTributariaPIS As Integer
    Private sSituacaoTributariaPIS As String
    Private iTipoCalculoPIS As Integer
    Private dBaseCalculoPIS As Double
    Private dAliquotaPorcentagemPIS As Double
    Private dAliquotaValorPIS As Double
    Private dQuantidadeVendidaPIS As Double
    Private dValorPIS As Double
    Private iTipoCalculoPISST As Integer
    Private dBaseCalculoPISST As Double
    Private dAliquotaPorcentagemPISST As Double
    Private dAliquotaValorPISST As Double
    Private dQuantidadeVendidaPISST As Double
    Private dValorPISST As Double

#End Region

#Region "::: PROPERTIE :::"

#Region "::: PRODUTO :::"

    Public Property CEST As String
        Get
            Return scest
        End Get
        Set(value As String)
            scest = value
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

    Public Property CodigoEmissaoItem() As Integer
        Get
            Return iCodigoEmissaoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoEmissaoItem = value
        End Set
    End Property

    Public Property CodigoItem() As Long
        Get
            Return lCodigoItem
        End Get
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

    Public Property CodigoProdutoServico() As String
        Get
            Return sCodigoProdutoServico
        End Get
        Set(ByVal value As String)
            sCodigoProdutoServico = value
        End Set
    End Property

    Public Property CodigoEAN() As String
        Get
            Return sCodigoEAN
        End Get
        Set(ByVal value As String)
            sCodigoEAN = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property CodigoCFOP() As Integer
        Get
            Return iCodigoCFOP
        End Get
        Set(ByVal value As Integer)
            iCodigoCFOP = value
        End Set
    End Property

    Public Property CFOP() As String
        Get
            Return sCFOP
        End Get
        Set(ByVal value As String)
            sCFOP = value
        End Set
    End Property

    Public Property CodigoNCM() As Integer
        Get
            Return iCodigoNCM
        End Get
        Set(ByVal value As Integer)
            iCodigoNCM = value
        End Set
    End Property

    Public Property NCM() As String
        Get
            Return sNCM
        End Get
        Set(ByVal value As String)
            sNCM = value
        End Set
    End Property

    Public Property Lote() As String
        Get
            Return sLote
        End Get
        Set(ByVal value As String)
            sLote = value
        End Set
    End Property

    Public Property CodigoPedidoItem() As Integer
        Get
            Return iCodigoItem
        End Get
        Set(ByVal value As Integer)
            dQuantidade = value
        End Set
    End Property

    Public Property CodigoPedido() As Integer
        Get
            Return iCodigoPedido
        End Get
        Set(ByVal value As Integer)
            iCodigoPedido = value
        End Set
    End Property

    Public Property Quantidade() As Double
        Get
            Return dQuantidade
        End Get
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public Property CodigoUnidadeMedida() As Integer
        Get
            Return iCodigoUnidadeMedida
        End Get
        Set(ByVal value As Integer)
            iCodigoUnidadeMedida = value
        End Set
    End Property

    Public Property UnidadeMedida() As String
        Get
            Return sUnidadeMedida
        End Get
        Set(ByVal value As String)
            sUnidadeMedida = value
        End Set
    End Property

    Public Property ValorUnitario() As Double
        Get
            Return dValorUnitario
        End Get
        Set(ByVal value As Double)
            dValorUnitario = value
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

    Public Property ValorFrete() As Double
        Get
            Return dValorFrete
        End Get
        Set(ByVal value As Double)
            dValorFrete = value
        End Set
    End Property

    Public Property ValorSeguro() As Double
        Get
            Return dValorSeguro
        End Get
        Set(ByVal value As Double)
            dValorSeguro = value
        End Set
    End Property

    Public Property ValorOutrasDespesas() As Double
        Get
            Return dValorOutrasDespesas
        End Get
        Set(ByVal value As Double)
            dValorOutrasDespesas = value
        End Set
    End Property

    Public Property ValorTotal() As Double
        Get
            Return dValorTotal
        End Get
        Set(ByVal value As Double)
            dValorTotal = value
        End Set
    End Property

    Public Property IncideValorTotalNF() As Boolean
        Get
            Return bIncideValorTotalNF
        End Get
        Set(ByVal value As Boolean)
            bIncideValorTotalNF = value
        End Set
    End Property

    Public Property PedidoCompra() As String
        Get
            Return sPedidoCompra
        End Get
        Set(ByVal value As String)
            sPedidoCompra = value
        End Set
    End Property

    Public Property NumeroItemPedidoCompra() As Integer
        Get
            Return iNumeroItemPedidoCompra
        End Get
        Set(ByVal value As Integer)
            iNumeroItemPedidoCompra = value
        End Set
    End Property

    Public Property InformacoesAdicionais() As String
        Get
            Return sInformacoesAdicionais
        End Get
        Set(ByVal value As String)
            sInformacoesAdicionais = value
        End Set
    End Property

    Public Property CodigoEmissaoDI() As Integer
        Get
            Return iCodigoEmissaoDI
        End Get
        Set(ByVal value As Integer)
            iCodigoEmissaoDI = value
        End Set
    End Property

    Public Property CodigoFabricante() As String
        Get
            Return sCodigoFabricante
        End Get
        Set(ByVal value As String)
            sCodigoFabricante = value
        End Set
    End Property

    Public Property CalculoAutomatico() As Boolean
        Get
            Return bCalculoAutomatico
        End Get
        Set(ByVal value As Boolean)
            bCalculoAutomatico = value
        End Set
    End Property

    Public Property CodigoBeneficiamento() As String
        Get
            Return sCodigoBeneficiamento
        End Get
        Set(ByVal value As String)
            sCodigoBeneficiamento = value
        End Set
    End Property

#End Region

#Region "::: IMPOSTO - COFINS :::"

    Public Property CodigoSituacaoTributariaCOFINS() As Integer
        Get
            Return iCodigoSituacaoTributariaCOFINS
        End Get
        Set(ByVal value As Integer)
            iCodigoSituacaoTributariaCOFINS = value
        End Set
    End Property

    Public Property SituacaoTributariaCOFINS() As String
        Get
            Return sSituacaoTributariaCOFINS
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaCOFINS = value
        End Set
    End Property

    Public Property TipoCalculoCOFINS() As Integer
        Get
            Return iTipoCalculoCOFINS
        End Get
        Set(ByVal value As Integer)
            iTipoCalculoCOFINS = value
        End Set
    End Property

    Public Property BaseCalculoCOFINS() As Double
        Get
            Return dBaseCalculoCOFINS
        End Get
        Set(ByVal value As Double)
            dBaseCalculoCOFINS = value
        End Set
    End Property

    Public Property AliquotaPorcentagemCOFINS() As Double
        Get
            Return dAliquotaPorcentagemCOFINS
        End Get
        Set(ByVal value As Double)
            dAliquotaPorcentagemCOFINS = value
        End Set
    End Property

    Public Property QuantidadeVendidaCOFINS() As Double
        Get
            Return dQuantidadeVendidaCOFINS
        End Get
        Set(ByVal value As Double)
            dQuantidadeVendidaCOFINS = value
        End Set
    End Property

    Public Property AliquotaValorCOFINS() As Double
        Get
            Return dAliquotaValorCOFINS
        End Get
        Set(ByVal value As Double)
            dAliquotaValorCOFINS = value
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

    Public Property TipoCalculoCOFINSST() As Integer
        Get
            Return iTipoCalculoCOFINSST
        End Get
        Set(ByVal value As Integer)
            iTipoCalculoCOFINSST = value
        End Set
    End Property

    Public Property BaseCalculoCOFINSST() As Double
        Get
            Return dBaseCalculoCOFINSST
        End Get
        Set(ByVal value As Double)
            dBaseCalculoCOFINSST = value
        End Set
    End Property

    Public Property AliquotaPorcentagemCOFINSST() As Double
        Get
            Return dAliquotaPorcentagemCOFINSST
        End Get
        Set(ByVal value As Double)
            dAliquotaPorcentagemCOFINSST = value
        End Set
    End Property

    Public Property AliquotaValorCOFINSST() As Double
        Get
            Return dAliquotaValorCOFINSST
        End Get
        Set(ByVal value As Double)
            dAliquotaValorCOFINSST = value
        End Set
    End Property

    Public Property QuantidadeVendidaCOFINSST() As Double
        Get
            Return dQuantidadeVendidaCOFINSST
        End Get
        Set(ByVal value As Double)
            dQuantidadeVendidaCOFINSST = value
        End Set
    End Property

    Public Property ValorCOFINSST() As Double
        Get
            Return dValorCOFINSST
        End Get
        Set(ByVal value As Double)
            dValorCOFINSST = value
        End Set
    End Property

#End Region

#Region "::: IMPOSTO - ICMS :::"

    Public Property CodigoOrigemItem() As Integer
        Get
            Return iCodigoOrigemItem
        End Get
        Set(ByVal value As Integer)
            iCodigoOrigemItem = value
        End Set
    End Property

    Public Property CodigoSituacaoTributariaICMS() As Integer
        Get
            Return iCodigoSituacaoTributariaICMS
        End Get
        Set(ByVal value As Integer)
            iCodigoSituacaoTributariaICMS = value
        End Set
    End Property

    Public Property SituacaoTributariaICMS() As String
        Get
            Return sSituacaoTributariaICMS
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaICMS = value
        End Set
    End Property

    Public Property ModalidadeBaseCalculoICMS() As Integer
        Get
            Return iModalidadeBaseCalculoICMS
        End Get
        Set(ByVal value As Integer)
            iModalidadeBaseCalculoICMS = value
        End Set
    End Property

    Public Property ReducaoBaseCalculoICMS() As Double
        Get
            Return dPorcentagemReducaoBaseCalculoICMS
        End Get
        Set(ByVal value As Double)
            dPorcentagemReducaoBaseCalculoICMS = value
        End Set
    End Property

    Public Property BaseCalculoICMS() As Double
        Get
            Return dBaseCalculoICMS
        End Get
        Set(ByVal value As Double)
            dBaseCalculoICMS = value
        End Set
    End Property

    Public Property AliquotaICMS() As Double
        Get
            Return dAliquotaICMS
        End Get
        Set(ByVal value As Double)
            dAliquotaICMS = value
        End Set
    End Property

    Public Property ValorICMS() As Double
        Get
            Return dValorICMS
        End Get
        Set(ByVal value As Double)
            dValorICMS = value
        End Set
    End Property

    Public Property ModalidadeBaseCalculoICMSST() As Integer
        Get
            Return iModalidadeBaseCalculoICMSST
        End Get
        Set(ByVal value As Integer)
            iModalidadeBaseCalculoICMSST = value
        End Set
    End Property

    Public Property IVA() As Double
        Get
            Return dIVA
        End Get
        Set(ByVal value As Double)
            dIVA = value
        End Set
    End Property

    Public Property ReducaoBaseCalculoICMSST() As Double
        Get
            Return dPorcentagemReducaoBaseCalculoICMSST
        End Get
        Set(ByVal value As Double)
            dPorcentagemReducaoBaseCalculoICMSST = value
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

    Public Property AliquotaICMSST() As Double
        Get
            Return dAliquotaICMSST
        End Get
        Set(ByVal value As Double)
            dAliquotaICMSST = value
        End Set
    End Property

    Public Property ValorICMSST() As Double
        Get
            Return dValorICMSST
        End Get
        Set(ByVal value As Double)
            dValorICMSST = value
        End Set
    End Property

#End Region

#Region "::: IMPOSTO - ICMS SIMPLES :::"

    Public Property CodigoOrigemItemSimples() As Integer
        Get
            Return iCodigoOrigemItemSimples
        End Get
        Set(ByVal value As Integer)
            iCodigoOrigemItemSimples = value
        End Set
    End Property

    Public Property CodigoSituacaoTributariaICMSSimples() As Integer
        Get
            Return iCodigoSituacaoTributariaICMSSimples
        End Get
        Set(ByVal value As Integer)
            iCodigoSituacaoTributariaICMSSimples = value
        End Set
    End Property

    Public Property SituacaoTributariaICMSSimples() As String
        Get
            Return sSituacaoTributariaICMSSimples
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaICMSSimples = value
        End Set
    End Property

    Public Property ModalidadeBaseCalculoICMSSimples() As Integer
        Get
            Return iModalidadeBaseCalculoICMSSimples
        End Get
        Set(ByVal value As Integer)
            iModalidadeBaseCalculoICMSSimples = value
        End Set
    End Property

    Public Property ReducaoBaseCalculoICMSSimples() As Double
        Get
            Return dPorcentagemReducaoBaseCalculoICMSSimples
        End Get
        Set(ByVal value As Double)
            dPorcentagemReducaoBaseCalculoICMSSimples = value
        End Set
    End Property

    Public Property BaseCalculoICMSSimples() As Double
        Get
            Return dBaseCalculoICMSSimples
        End Get
        Set(ByVal value As Double)
            dBaseCalculoICMSSimples = value
        End Set
    End Property

    Public Property AliquotaICMSSimples() As Double
        Get
            Return dAliquotaICMSSimples
        End Get
        Set(ByVal value As Double)
            dAliquotaICMSSimples = value
        End Set
    End Property

    Public Property ValorICMSSimples() As Double
        Get
            Return dValorICMSSimples
        End Get
        Set(ByVal value As Double)
            dValorICMSSimples = value
        End Set
    End Property

    Public Property ModalidadeBaseCalculoICMSSTSimples() As Integer
        Get
            Return iModalidadeBaseCalculoICMSSTSimples
        End Get
        Set(ByVal value As Integer)
            iModalidadeBaseCalculoICMSSTSimples = value
        End Set
    End Property

    Public Property IVASimples() As Double
        Get
            Return dIVASimples
        End Get
        Set(ByVal value As Double)
            dIVASimples = value
        End Set
    End Property

    Public Property ReducaoBaseCalculoICMSSTSimples() As Double
        Get
            Return dPorcentagemReducaoBaseCalculoICMSSTSimples
        End Get
        Set(ByVal value As Double)
            dPorcentagemReducaoBaseCalculoICMSSTSimples = value
        End Set
    End Property

    Public Property BaseCalculoICMSSTSimples() As Double
        Get
            Return dBaseCalculoICMSSTSimples
        End Get
        Set(ByVal value As Double)
            dBaseCalculoICMSSTSimples = value
        End Set
    End Property

    Public Property AliquotaICMSSTSimples() As Double
        Get
            Return dAliquotaICMSSTSimples
        End Get
        Set(ByVal value As Double)
            dAliquotaICMSSTSimples = value
        End Set
    End Property

    Public Property ValorICMSSTSimples() As Double
        Get
            Return dValorICMSSTSimples
        End Get
        Set(ByVal value As Double)
            dValorICMSSTSimples = value
        End Set
    End Property

#End Region

#Region "::: IMPOSTO - ICMS PARTILHA :::"

    Public Property BaseCalculoICMSPartilha() As Double
        Get
            Return dBaseCalculoICMSPartilha
        End Get
        Set(ByVal value As Double)
            dBaseCalculoICMSPartilha = value
        End Set
    End Property

    Public Property PercentualFCPICMSPartilha() As Double
        Get
            Return dPercentualFCPICMSPartilha
        End Get
        Set(ByVal value As Double)
            dPercentualFCPICMSPartilha = value
        End Set
    End Property

    Public Property PercentualDestinoICMSPartilha() As Double
        Get
            Return dPercentualDestinoICMSPartilha
        End Get
        Set(ByVal value As Double)
            dPercentualDestinoICMSPartilha = value
        End Set
    End Property

    Public Property PercentualInterestadualICMSPartilha() As Double
        Get
            Return dPercentualInterestadualICMSPartilha
        End Get
        Set(ByVal value As Double)
            dPercentualInterestadualICMSPartilha = value
        End Set
    End Property

    Public Property PercentualPartilhaICMSPartilha() As Integer
        Get
            Return dPercentualPartilhaICMSPartilha
        End Get
        Set(ByVal value As Integer)
            dPercentualPartilhaICMSPartilha = value
        End Set
    End Property

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

#Region "::: IMPOSTO - II :::"

    Public Property BaseCalculoII() As Double
        Get
            Return dBaseCalculoII
        End Get
        Set(ByVal value As Double)
            dBaseCalculoII = value
        End Set
    End Property

    Public Property DespesaAduaneira() As Double
        Get
            Return dDespesaAduaneira
        End Get
        Set(ByVal value As Double)
            dDespesaAduaneira = value
        End Set
    End Property

    Public Property AliquotaIOF() As Double
        Get
            Return dAliquotaIOF
        End Get
        Set(ByVal value As Double)
            dAliquotaIOF = value
        End Set
    End Property

    Public Property AliquotaII() As Double
        Get
            Return dAliquotaII
        End Get
        Set(ByVal value As Double)
            dAliquotaII = value
        End Set
    End Property

#End Region

#Region "::: IMPOSTO - IPI :::"

    Public Property ClasseEnquadramentoIPI() As String
        Get
            Return sClasseEnquadramentoIPI
        End Get
        Set(ByVal value As String)
            sClasseEnquadramentoIPI = value
        End Set
    End Property

    Public Property CNPJProdutorIPI() As String
        Get
            Return sCNPJProdutorIPI
        End Get
        Set(ByVal value As String)
            sCNPJProdutorIPI = value
        End Set
    End Property

    Public Property CodigoSeloControleIPI() As String
        Get
            Return sCodigoSeloControleIPI
        End Get
        Set(ByVal value As String)
            sCodigoSeloControleIPI = value
        End Set
    End Property

    Public Property QuantidadeSeloControleIPI() As Long
        Get
            Return lQuantidadeSeloControleIPI
        End Get
        Set(ByVal value As Long)
            lQuantidadeSeloControleIPI = value
        End Set
    End Property

    Public Property CodigoEnquadramentoIPI() As String
        Get
            Return sCodigoEnquadramentoIPI
        End Get
        Set(ByVal value As String)
            sCodigoEnquadramentoIPI = value
        End Set
    End Property

    Public Property SituacaoTributariaIPI() As String
        Get
            Return sSituacaoTributariaIPI
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaIPI = value
        End Set
    End Property

    Public Property TipoCalculoIPI() As Integer
        Get
            Return iTipoCalculoIPI
        End Get
        Set(ByVal value As Integer)
            iTipoCalculoIPI = value
        End Set
    End Property

    Public Property BaseCalculoIPI() As Double
        Get
            Return dBaseCalculoIPI
        End Get
        Set(ByVal value As Double)
            dBaseCalculoIPI = value
        End Set
    End Property

    Public Property AliquotaIPI() As Double
        Get
            Return dAliquotaIPI
        End Get
        Set(ByVal value As Double)
            dAliquotaIPI = value
        End Set
    End Property

    Public Property QuantidadeTotalUnidadePadraoIPI() As Double
        Get
            Return dQuantidadeTotalUnidadePadraoIPI
        End Get
        Set(ByVal value As Double)
            dQuantidadeTotalUnidadePadraoIPI = value
        End Set
    End Property

    Public Property ValorUnidadeIPI() As Double
        Get
            Return dValorUnidadeIPI
        End Get
        Set(ByVal value As Double)
            dValorUnidadeIPI = value
        End Set
    End Property

    Public Property ValorIPI() As Double
        Get
            Return dValorIPI
        End Get
        Set(ByVal value As Double)
            dValorIPI = value
        End Set
    End Property

#End Region

#Region "::: IMPOSTO - PIS :::"

    Public Property CodigoSituacaoTributariaPIS() As Integer
        Get
            Return iCodigoSituacaoTributariaPIS
        End Get
        Set(ByVal value As Integer)
            iCodigoSituacaoTributariaPIS = value
        End Set
    End Property

    Public Property SituacaoTributariaPIS() As String
        Get
            Return sSituacaoTributariaPIS
        End Get
        Set(ByVal value As String)
            sSituacaoTributariaPIS = value
        End Set
    End Property

    Public Property TipoCalculoPIS() As Integer
        Get
            Return iTipoCalculoPIS
        End Get
        Set(ByVal value As Integer)
            iTipoCalculoPIS = value
        End Set
    End Property

    Public Property BaseCalculoPIS() As Double
        Get
            Return dBaseCalculoPIS
        End Get
        Set(ByVal value As Double)
            dBaseCalculoPIS = value
        End Set
    End Property

    Public Property AliquotaPorcentagemPIS() As Double
        Get
            Return dAliquotaPorcentagemPIS
        End Get
        Set(ByVal value As Double)
            dAliquotaPorcentagemPIS = value
        End Set
    End Property

    Public Property QuantidadeVendidaPIS() As Double
        Get
            Return dQuantidadeVendidaPIS
        End Get
        Set(ByVal value As Double)
            dQuantidadeVendidaPIS = value
        End Set
    End Property

    Public Property AliquotaValorPIS() As Double
        Get
            Return dAliquotaValorPIS
        End Get
        Set(ByVal value As Double)
            dAliquotaValorPIS = value
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

    Public Property TipoCalculoPISST() As Integer
        Get
            Return iTipoCalculoPISST
        End Get
        Set(ByVal value As Integer)
            iTipoCalculoPISST = value
        End Set
    End Property

    Public Property BaseCalculoPISST() As Double
        Get
            Return dBaseCalculoPISST
        End Get
        Set(ByVal value As Double)
            dBaseCalculoPISST = value
        End Set
    End Property

    Public Property AliquotaPorcentagemPISST() As Double
        Get
            Return dAliquotaPorcentagemPISST
        End Get
        Set(ByVal value As Double)
            dAliquotaPorcentagemPISST = value
        End Set
    End Property

    Public Property AliquotaValorPISST() As Double
        Get
            Return dAliquotaValorPISST
        End Get
        Set(ByVal value As Double)
            dAliquotaValorPISST = value
        End Set
    End Property

    Public Property QuantidadeVendidaPISST() As Double
        Get
            Return dQuantidadeVendidaPISST
        End Get
        Set(ByVal value As Double)
            dQuantidadeVendidaPISST = value
        End Set
    End Property

    Public Property ValorPISST() As Double
        Get
            Return dValorPISST
        End Get
        Set(ByVal value As Double)
            dValorPISST = value
        End Set
    End Property

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub InsertProduto()

        'Variaveis Locais
        Dim oSqlParameter(31) As SqlParameter
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
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Produto / Serviço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProdutoServico : i += 1

            'Seta Parametros - Código EAN
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ean"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sCodigoEAN = "", DBNull.Value, sCodigoEAN) : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCFOP = -1, DBNull.Value, iCodigoCFOP) : i += 1

            'Seta Parametros - CFOP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4
            oSqlParameter(i).Value = IIf(sCFOP = -1, DBNull.Value, sCFOP) : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, iCodigoNCM) : i += 1

            'Seta Parametros - NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, sNCM) : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote <> "", sLote, DBNull.Value) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, iCodigoUnidadeMedida) : i += 1

            'Seta Parametros - Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedida = -1, DBNull.Value, sUnidadeMedida) : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

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

            'Seta Parametros - Valor Outras Despesas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_outras_despesas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorOutrasDespesas : i += 1

            'Seta Parametros - Valor Total
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Seta Parametros - Incide no Valor Total da Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incide_valor_total_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIncideValorTotalNF : i += 1

            'Seta Parametros - Informações Adicionais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "informacoes_adicionais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sInformacoesAdicionais = "", DBNull.Value, sInformacoesAdicionais) : i += 1

            'Seta Parametros - Número do Item no Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_pedido_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iNumeroItemPedidoCompra = 0, DBNull.Value, iNumeroItemPedidoCompra) : i += 1

            'Seta Parametros - Número do Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sPedidoCompra = "", DBNull.Value, sPedidoCompra) : i += 1

            'Seta Parametros - Código Emissão DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoEmissaoDI = -1, DBNull.Value, iCodigoEmissaoDI) : i += 1

            'Seta Parametros - Código Fabricante
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fabricante"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sCodigoFabricante = "", DBNull.Value, sCodigoFabricante) : i += 1

            'Seta Parametros - CEST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cest"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sCEST = "", DBNull.Value, sCEST) : i += 1

            'Seta Parametros - Calculo Automático
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "calculo_automatico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCalculoAutomatico : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_produto", oSqlParameter)

            'Seta Código
            iCodigoEmissaoItem = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadProduto(ByVal lCodigo As Long, _
                           ByVal lCodigoEmissaoCapa As Long, _
                           ByVal cboCodigo As UIComboBox, _
                           ByVal txtDescricao As EditBox, _
                           ByVal txtCodigoEAN As MaskedEditBox, _
                           ByVal cboCFOP As UIComboBox, _
                           ByVal cboIncideValorTotalNF As UIComboBox, _
                           ByVal cboNCM As UIComboBox, _
                           ByVal txtQuantidade As NumericEditBox, _
                           ByVal cboUnidadeMedida As UIComboBox, _
                           ByVal txtValorUnitario As NumericEditBox, _
                           ByVal txtValorFrete As NumericEditBox, _
                           ByVal txtValorSeguro As NumericEditBox, _
                           ByVal txtValorOutrasDespesas As NumericEditBox, _
                           ByVal txtValorDesconto As NumericEditBox, _
                           ByVal txtValorTotal As NumericEditBox, _
                           ByVal txtInformacoesAdicionais As EditBox, _
                           ByVal txtPedidoCompra As MaskedEditBox, _
                           ByVal txtItemPedidoCompra As NumericEditBox, _
                           ByVal cboNumeroDI As UIComboBox, _
                           ByVal txtCodigoFabricante As MaskedEditBox, _
                           ByVal chkCalculoAutomatico As UICheckBox, _
                           ByVal cboOrigemItem As UIComboBox, _
                           ByVal cboSituacaoTributariaICMS As UIComboBox, _
                           ByVal cboModalidadeBCICMS As UIComboBox, _
                           ByVal txtPorcentagemReducaoBCICMS As NumericEditBox, _
                           ByVal txtBaseCalculoICMS As NumericEditBox, _
                           ByVal txtAliquotaICMS As NumericEditBox, _
                           ByVal cboModalidadeBCICMSST As UIComboBox, _
                           ByVal txtIVA As NumericEditBox, _
                           ByVal txtPorcentagemReducaoBCICMSST As NumericEditBox, _
                           ByVal txtBaseCalculoICMSST As NumericEditBox, _
                           ByVal txtAliquotaICMSST As NumericEditBox, _
                           ByVal txtValorICMS As NumericEditBox, _
                           ByVal cboOrigemItemSimples As UIComboBox, _
                           ByVal cboSituacaoTributariaICMSSimples As UIComboBox, _
                           ByVal cboModalidadeBCICMSSimples As UIComboBox, _
                           ByVal txtPorcentagemReducaoBCICMSSimples As NumericEditBox, _
                           ByVal txtAliquotaICMSSimples As NumericEditBox, _
                           ByVal cboModalidadeBCICMSSTSimples As UIComboBox, _
                           ByVal txtIVASimples As NumericEditBox, _
                           ByVal txtPorcentagemReducaoBCICMSSTSimples As NumericEditBox, _
                           ByVal txtBaseCalculoICMSSTSimples As NumericEditBox, _
                           ByVal txtAliquotaICMSSTSimples As NumericEditBox, _
                           ByVal cboSituacaoTributariaIPI As UIComboBox, _
                           ByVal cboTipoCalculoIPI As UIComboBox, _
                           ByVal txtBaseCalculoIPI As NumericEditBox, _
                           ByVal txtAliquotaIPI As NumericEditBox, _
                           ByVal txtQuantidadeIPI As NumericEditBox, _
                           ByVal txtValorUnidadeIPI As NumericEditBox, _
                           ByVal txtValorIPI As NumericEditBox, _
                           ByVal cboSituacaoTributariaPIS As UIComboBox, _
                           ByVal cboTipoCalculoPIS As UIComboBox, _
                           ByVal txtBaseCalculoPIS As NumericEditBox, _
                           ByVal txtAliquotaPercentualPIS As NumericEditBox, _
                           ByVal txtAliquotaValorPIS As NumericEditBox, _
                           ByVal txtQuantidadeVendidaPIS As NumericEditBox, _
                           ByVal txtValorPIS As NumericEditBox, _
                           ByVal cboSituacaoTributariaCOFINS As UIComboBox, _
                           ByVal cboTipoCalculoCOFINS As UIComboBox, _
                           ByVal txtBaseCalculoCOFINS As NumericEditBox, _
                           ByVal txtAliquotaPercentualCOFINS As NumericEditBox, _
                           ByVal txtAliquotaValorCOFINS As NumericEditBox, _
                           ByVal txtQuantidadeVendidaCOFINS As NumericEditBox, _
                           ByVal txtValorCOFINS As NumericEditBox, _
                           ByVal txtBaseCalculoII As NumericEditBox, _
                           ByVal txtDespesaAduaneiraII As NumericEditBox, _
                           ByVal txtAliquotaIOF As NumericEditBox, _
                           ByVal txtAliquotaII As NumericEditBox, _
                           ByVal cboCodigoEnquadramentoIPI As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_dados_item_produto", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                cboCodigo.SelectedValue = oSqlDataReader.Item("codigo_item")
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                cboCFOP.SelectedValue = oSqlDataReader.Item("codigo_cfop")
                txtCodigoEAN.Text = oSqlDataReader.Item("codigo_ean")
                cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
                cboIncideValorTotalNF.SelectedValue = oSqlDataReader.Item("incide_valor_total_nota_fiscal")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                cboUnidadeMedida.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida")
                txtValorUnitario.Value = oSqlDataReader.Item("valor_unitario")
                txtValorFrete.Value = oSqlDataReader.Item("valor_frete")
                txtValorSeguro.Value = oSqlDataReader.Item("valor_seguro")
                txtValorOutrasDespesas.Value = oSqlDataReader.Item("valor_outras_despesas")
                txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto")
                txtValorTotal.Value = oSqlDataReader.Item("valor_total")
                txtInformacoesAdicionais.Text = oSqlDataReader.Item("informacoes_adicionais")
                txtPedidoCompra.Text = oSqlDataReader.Item("numero_pedido")
                txtItemPedidoCompra.Text = oSqlDataReader.Item("item_pedido_compra")
                cboNumeroDI.SelectedValue = oSqlDataReader.Item("codigo_emissao_di")
                txtCodigoFabricante.Text = oSqlDataReader.Item("codigo_fabricante")
                chkCalculoAutomatico.Checked = oSqlDataReader.Item("calculo_automatico")
                'ICMS
                cboOrigemItem.SelectedValue = oSqlDataReader.Item("codigo_origem_item")
                cboSituacaoTributariaICMS.SelectedValue = oSqlDataReader.Item("situacao_tributaria_icms")
                cboModalidadeBCICMS.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms")
                txtPorcentagemReducaoBCICMS.Value = oSqlDataReader.Item("porcentagem_reducao_base_calculo_icms")
                txtBaseCalculoICMS.Value = oSqlDataReader.Item("base_calculo_icms")
                txtAliquotaICMS.Value = oSqlDataReader.Item("aliquota_icms")
                cboModalidadeBCICMSST.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms_st")
                txtIVA.Value = oSqlDataReader.Item("iva")
                txtPorcentagemReducaoBCICMSST.Value = oSqlDataReader.Item("porcentagem_reducao_base_calculo_icms_st")
                txtBaseCalculoICMSST.Value = oSqlDataReader.Item("base_calculo_icms_st")
                txtAliquotaICMSST.Value = oSqlDataReader.Item("aliquota_icms_st")
                txtvaloricms.value = oSqlDataReader.Item("valor_icms")
                'ICMS - SIMPLES
                cboOrigemItemSimples.SelectedValue = oSqlDataReader.Item("codigo_origem_item_simples")
                cboSituacaoTributariaICMSSimples.SelectedValue = oSqlDataReader.Item("situacao_tributaria_icms_simples")
                cboModalidadeBCICMSSimples.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms_simples")
                txtPorcentagemReducaoBCICMSSTSimples.Value = oSqlDataReader.Item("porcentagem_reducao_base_calculo_icms_simples")
                txtAliquotaICMSSimples.Value = oSqlDataReader.Item("aliquota_icms_simples")
                cboModalidadeBCICMSSTSimples.SelectedValue = oSqlDataReader.Item("codigo_modalidade_base_calculo_icms_st_simples")
                txtIVASimples.Value = oSqlDataReader.Item("iva_simples")
                txtPorcentagemReducaoBCICMSSTSimples.Value = oSqlDataReader.Item("porcentagem_reducao_base_calculo_icms_st_simples")
                txtBaseCalculoICMSSTSimples.Value = oSqlDataReader.Item("base_calculo_icms_st_simples")
                txtAliquotaICMSSTSimples.Value = oSqlDataReader.Item("aliquota_icms_st_simples")
                'IPI
                cboSituacaoTributariaIPI.SelectedValue = oSqlDataReader.Item("situacao_tributaria_ipi")
                cboTipoCalculoIPI.SelectedValue = oSqlDataReader.Item("codigo_tipo_calculo_ipi")
                txtBaseCalculoIPI.Value = oSqlDataReader.Item("base_calculo_ipi")
                txtAliquotaIPI.Value = oSqlDataReader.Item("aliquota_ipi")
                txtQuantidadeIPI.Value = oSqlDataReader.Item("quantidade_total_unidade_padrao_ipi")
                txtValorUnidadeIPI.Value = oSqlDataReader.Item("valor_unidade_ipi")
                txtValorIPI.Value = oSqlDataReader.Item("valor_ipi")
                cboCodigoEnquadramentoIPI.SelectedValue = oSqlDataReader.Item("codigo_enquadramento")
                'PIS
                cboSituacaoTributariaPIS.SelectedValue = oSqlDataReader.Item("situacao_tributaria_pis")
                cboTipoCalculoPIS.SelectedValue = oSqlDataReader.Item("codigo_tipo_calculo_pis")
                txtBaseCalculoPIS.Value = oSqlDataReader.Item("base_calculo_pis")
                txtAliquotaPercentualPIS.Value = oSqlDataReader.Item("aliquota_percentual_pis")
                txtAliquotaValorPIS.Value = oSqlDataReader.Item("aliquota_valor_pis")
                txtQuantidadeVendidaPIS.Value = oSqlDataReader.Item("quantidade_vendida_pis")
                txtValorPIS.Value = oSqlDataReader.Item("valor_pis")
                'PIS ST
                'cboTipoCalculoPISST.SelectedValue = oSqlDataReader.Item("codigo_tipo_calculo_pis_st")
                'txtBaseCalculoPISST.Value = oSqlDataReader.Item("base_calculo_pis_st")
                'txtAliquotaPercentualPISST.Value = oSqlDataReader.Item("aliquota_percentual_pis_st")
                'txtAliquotaValorPISST.Value = oSqlDataReader.Item("aliquota_valor_pis_st")
                'txtQuantidadeVendidaPISST.Value = oSqlDataReader.Item("quantidade_vendida_pis_st")
                'txtValorPISST.Value = oSqlDataReader.Item("valor_pis_st")
                'COFINS
                cboSituacaoTributariaCOFINS.SelectedValue = oSqlDataReader.Item("situacao_tributaria_cofins")
                cboTipoCalculoCOFINS.SelectedValue = oSqlDataReader.Item("codigo_tipo_calculo_cofins")
                txtBaseCalculoCOFINS.Value = oSqlDataReader.Item("base_calculo_cofins")
                txtAliquotaPercentualCOFINS.Value = oSqlDataReader.Item("aliquota_percentual_cofins")
                txtAliquotaValorCOFINS.Value = oSqlDataReader.Item("aliquota_valor_cofins")
                txtQuantidadeVendidaCOFINS.Value = oSqlDataReader.Item("quantidade_vendida_cofins")
                txtValorCOFINS.Value = oSqlDataReader.Item("valor_cofins")
                'COFINS ST
                'cboTipoCalculoCOFINSST.SelectedValue = oSqlDataReader.Item("codigo_tipo_calculo_cofins_st")
                'txtBaseCalculoCOFINSST.Value = oSqlDataReader.Item("base_calculo_cofins_st")
                'txtAliquotaPercentualCOFINSST.Value = oSqlDataReader.Item("aliquota_percentual_cofins_st")
                'txtAliquotaValorCOFINSST.Value = oSqlDataReader.Item("aliquota_valor_cofins_st")
                'txtQuantidadeVendidaCOFINSST.Value = oSqlDataReader.Item("quantidade_vendida_cofins_st")
                'txtValorCOFINSST.Value = oSqlDataReader.Item("valor_cofins_st")
                'II
                txtBaseCalculoII.Value = oSqlDataReader.Item("base_calculo_ii")
                txtDespesaAduaneiraII.Value = oSqlDataReader.Item("despesa_aduaneira")
                txtAliquotaIOF.Value = oSqlDataReader.Item("aliquota_iof")
                txtAliquotaII.Value = oSqlDataReader.Item("aliquota_ii")
            End While

            'Fecha o oSqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoCOFINS()

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Item
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_emissao_item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoEmissaoItem

            'Seta Parametros - Situação Tributária COFINS
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "situacao_tributaria_cofins"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 2
            oSqlParameter(3).Value = sSituacaoTributariaCOFINS

            'Seta Parametros - Código Tipo Cálculo Imposto COFINS
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_tipo_calculo_imposto"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = IIf(iTipoCalculoCOFINS = -1, DBNull.Value, iTipoCalculoCOFINS)

            'Seta Parametros - Base Cálculo COFINS
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "base_calculo_cofins"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = IIf(iTipoCalculoCOFINS = TipoCalculoImposto.Percentual, dBaseCalculoCOFINS, DBNull.Value)

            'Seta Parametros - Aliquota (%)
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "aliquota_percentual_cofins"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = IIf(iTipoCalculoCOFINS = TipoCalculoImposto.Percentual, dAliquotaPorcentagemCOFINS, DBNull.Value)

            'Seta Parametros - Quantidade Vendida COFINS
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "quantidade_vendida_cofins"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Float
            oSqlParameter(7).Value = IIf(iTipoCalculoCOFINS = TipoCalculoImposto.Valor, dQuantidadeVendidaCOFINS, DBNull.Value)

            'Seta Parametros - Aliquota (Valor)
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "aliquota_valor_cofins"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Float
            oSqlParameter(8).Value = IIf(iTipoCalculoCOFINS = TipoCalculoImposto.Valor, dAliquotaValorCOFINS, DBNull.Value)

            'Seta Parametros - Valor COFINS
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "valor_cofins"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Float
            oSqlParameter(9).Value = dValorCOFINS

            'Seta Parametros - Código Tipo Cálculo Imposto COFINS - ST
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "codigo_tipo_calculo_imposto_st"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(10).Value = IIf(iTipoCalculoCOFINSST = -1, DBNull.Value, iTipoCalculoCOFINSST)

            'Seta Parametros - Base Cálculo COFINS - ST
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "base_calculo_cofins_st"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Float
            oSqlParameter(11).Value = IIf(iTipoCalculoCOFINSST = TipoCalculoImposto.Percentual, dBaseCalculoCOFINSST, DBNull.Value)

            'Seta Parametros - Aliquota (%) - ST
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "aliquota_percentual_cofins_st"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Float
            oSqlParameter(12).Value = IIf(iTipoCalculoCOFINSST = TipoCalculoImposto.Percentual, dAliquotaPorcentagemCOFINSST, DBNull.Value)

            'Seta Parametros - Quantidade Vendida COFINS - ST
            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "quantidade_vendida_cofins_st"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Float
            oSqlParameter(13).Value = IIf(iTipoCalculoCOFINSST = TipoCalculoImposto.Valor, dQuantidadeVendidaCOFINSST, DBNull.Value)

            'Seta Parametros - Aliquota (Valor) - ST
            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "aliquota_valor_cofins_st"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.Float
            oSqlParameter(14).Value = IIf(iTipoCalculoCOFINSST = TipoCalculoImposto.Valor, dAliquotaValorCOFINSST, DBNull.Value)

            'Seta Parametros - Valor COFINS - ST
            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "valor_cofins_st"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.Float
            oSqlParameter(15).Value = dValorCOFINSST

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_cofins", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoICMS()

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
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

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOrigemItem : i += 1

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSituacaoTributariaICMS : i += 1

            'Seta Parametros - Código Modadelida Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMS = -1, DBNull.Value, iModalidadeBaseCalculoICMS) : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPorcentagemReducaoBaseCalculoICMS = -1, DBNull.Value, dPorcentagemReducaoBaseCalculoICMS) : i += 1

            'Seta Parametros - Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoICMS = -1, DBNull.Value, dBaseCalculoICMS) : i += 1

            'Seta Parametros - Aliquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMS = -1, DBNull.Value, dAliquotaICMS) : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMS = -1, DBNull.Value, dValorICMS) : i += 1

            'Seta Parametros - Código Modalidade Base Cálculo ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMSST = -1, DBNull.Value, iModalidadeBaseCalculoICMSST) : i += 1

            'Seta Parametros - IVA
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dIVA = -1, DBNull.Value, dIVA) : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPorcentagemReducaoBaseCalculoICMSST = -1, DBNull.Value, dPorcentagemReducaoBaseCalculoICMSST) : i += 1

            'Seta Parametros - Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoICMSST = -1, DBNull.Value, dBaseCalculoICMSST) : i += 1

            'Seta Parametros - Alíquota ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSST = -1, DBNull.Value, dAliquotaICMSST) : i += 1

            'Seta Parametros - Valor ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMSST = -1, DBNull.Value, dValorICMSST) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_icms", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoICMSSimples()

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
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

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoOrigemItemSimples : i += 1

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSituacaoTributariaICMSSimples : i += 1

            'Seta Parametros - Código Modadelida Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMSSimples = -1, DBNull.Value, iModalidadeBaseCalculoICMSSimples) : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPorcentagemReducaoBaseCalculoICMSSimples > 0, dPorcentagemReducaoBaseCalculoICMSSimples, DBNull.Value) : i += 1

            'Seta Parametros - Base Cálculo ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoICMSSimples > 0, dBaseCalculoICMSSimples, DBNull.Value) : i += 1

            'Seta Parametros - Aliquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSSimples > 0, dAliquotaICMSSimples, DBNull.Value) : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMSSimples > 0, dValorICMSSimples, DBNull.Value) : i += 1

            'Seta Parametros - Código Modalidade Base Cálculo ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iModalidadeBaseCalculoICMSSTSimples = -1, DBNull.Value, iModalidadeBaseCalculoICMSSTSimples) : i += 1

            'Seta Parametros - IVA
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dIVASimples > 0, dIVASimples, DBNull.Value) : i += 1

            'Seta Parametros - Porcentagem Redução Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dPorcentagemReducaoBaseCalculoICMSSTSimples > 0, dPorcentagemReducaoBaseCalculoICMSSTSimples, DBNull.Value) : i += 1

            'Seta Parametros - Base Cálculo ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBaseCalculoICMSSTSimples > 0, dBaseCalculoICMSSTSimples, DBNull.Value) : i += 1

            'Seta Parametros - Alíquota ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dAliquotaICMSSTSimples > 0, dAliquotaICMSSTSimples, DBNull.Value) : i += 1

            'Seta Parametros - Valor ICMS ST
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms_st"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorICMSSTSimples > 0, dValorICMSSTSimples, DBNull.Value) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_icms_simples", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoICMSPartilha()

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Item
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_emissao_item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoEmissaoItem

            'Seta Parametros - Base Calculo ICMS Partilha
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "base_calculo_icms"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Float
            oSqlParameter(3).Value = dBaseCalculoICMSPartilha

            'Seta Parametros - Percentual FCP ICMS Partilha
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "percentual_fcp_icms"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Float
            oSqlParameter(4).Value = dPercentualFCPICMSPartilha

            'Seta Parametros - Percentual Destino ICMS Partilha
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "percentual_destino_icms"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = dPercentualDestinoICMSPartilha

            'Seta Parametros - Percentual Interestadual ICMS Partilha
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "percentual_interestadual_icms"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = dPercentualInterestadualICMSPartilha

            'Seta Parametros - Percentual Partilha ICMS Partilha
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "percentual_partilha_icms"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Float
            oSqlParameter(7).Value = dPercentualPartilhaICMSPartilha

            'Seta Parametros - Valor FCP ICMS Partilha
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "valor_fcp_icms"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Float
            oSqlParameter(8).Value = dValorFCPICMSPartilha

            'Seta Parametros - Valor Destino ICMS Partilha
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "valor_destino_icms"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Float
            oSqlParameter(9).Value = dValorDestinoICMSPartilha

            'Seta Parametros - Valor Remetente ICMS Partilha
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "valor_remetente_icms"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Float
            oSqlParameter(10).Value = dValorRemetenteICMSPartilha

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_icms_partilha", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoII()

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Item
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_emissao_item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoEmissaoItem

            'Seta Parametros - Base Cálculo II
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "base_calculo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Float
            oSqlParameter(3).Value = dBaseCalculoII

            'Seta Parametros - Despesas Aduaneiras
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "despesa_aduaneira"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Float
            oSqlParameter(4).Value = dDespesaAduaneira

            'Seta Parametros - Alíquota IOF
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "aliquota_iof"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = dAliquotaIOF

            'Seta Parametros - Alíquota II
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "aliquota_ii"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = dAliquotaII

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_ii", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoIPI()

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Item
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_emissao_item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoEmissaoItem

            'Seta Parametros - Classe Enquadramento
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "classe_enquadramento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 5
            oSqlParameter(3).Value = IIf(sClasseEnquadramentoIPI = "", DBNull.Value, sClasseEnquadramentoIPI)

            'Seta Parametros - CNPJ Produtor
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "cnpj_produtor"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 20
            oSqlParameter(4).Value = IIf(sCNPJProdutorIPI = "", DBNull.Value, sCNPJProdutorIPI)

            'Seta Parametros - Código Selo Controle
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_selo_controle"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Size = 60
            oSqlParameter(5).Value = IIf(sCodigoSeloControleIPI = "", DBNull.Value, sCodigoSeloControleIPI)

            'Seta Parametros - Quantidade Selo Controle
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "quantidade_selo_controle"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.BigInt
            oSqlParameter(6).Value = IIf(lQuantidadeSeloControleIPI = 0, DBNull.Value, lQuantidadeSeloControleIPI)

            'Seta Parametros - Código Enquadramento IPI
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_enquadramento_ipi"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Size = 3
            oSqlParameter(7).Value = IIf(sCodigoEnquadramentoIPI = "", DBNull.Value, sCodigoEnquadramentoIPI)

            'Seta Parametros - Situação Tributária IPI
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "situacao_tributaria_ipi"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.VarChar
            oSqlParameter(8).Size = 2
            oSqlParameter(8).Value = sSituacaoTributariaIPI

            'Seta Parametros - Código Tipo Cálculo de Imposto
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo_tipo_calculo_imposto"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(9).Value = IIf(iTipoCalculoIPI = -1, DBNull.Value, iTipoCalculoIPI)

            'Seta Parametros - Base Cálculo IPI
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "base_calculo_ipi"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Float
            oSqlParameter(10).Value = IIf(iTipoCalculoIPI = TipoCalculoImposto.Valor, DBNull.Value, dBaseCalculoIPI)

            'Seta Parametros - Aliquota IPI
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "aliquota_ipi"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Float
            oSqlParameter(11).Value = IIf(iTipoCalculoIPI = TipoCalculoImposto.Valor, DBNull.Value, dAliquotaIPI)

            'Seta Parametros - Quantidade Total Unidade Padrão
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "quantidade_total_unidade_padrao"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Float
            oSqlParameter(12).Value = IIf(iTipoCalculoIPI = TipoCalculoImposto.Percentual, DBNull.Value, dQuantidadeTotalUnidadePadraoIPI)

            'Seta Parametros - Valor Unidade
            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "valor_unidade"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Float
            oSqlParameter(13).Value = IIf(iTipoCalculoIPI = TipoCalculoImposto.Percentual, DBNull.Value, dValorUnidadeIPI)

            'Seta Parametros - Valor IPI
            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "valor_ipi"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.Float
            oSqlParameter(14).Value = dValorIPI

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_ipi", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertImpostoPIS()

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Item
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_emissao_item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoEmissaoItem

            'Seta Parametros - Situação Tributária PIS
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "situacao_tributaria_pis"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 2
            oSqlParameter(3).Value = sSituacaoTributariaPIS

            'Seta Parametros - Código Tipo Cálculo Imposto PIS
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_tipo_calculo_imposto"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = IIf(iTipoCalculoPIS = -1, DBNull.Value, iTipoCalculoPIS)

            'Seta Parametros - Base Cálculo PIS
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "base_calculo_pis"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = IIf(iTipoCalculoPIS = TipoCalculoImposto.Percentual, dBaseCalculoPIS, DBNull.Value)

            'Seta Parametros - Aliquota (%)
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "aliquota_percentual_pis"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = IIf(iTipoCalculoPIS = TipoCalculoImposto.Percentual, dAliquotaPorcentagemPIS, DBNull.Value)

            'Seta Parametros - Quantidade Vendida PIS
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "quantidade_vendida_pis"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Float
            oSqlParameter(7).Value = IIf(iTipoCalculoPIS = TipoCalculoImposto.Valor, dQuantidadeVendidaPIS, DBNull.Value)

            'Seta Parametros - Aliquota (Valor)
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "aliquota_valor_pis"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Float
            oSqlParameter(8).Value = IIf(iTipoCalculoPIS = TipoCalculoImposto.Valor, dAliquotaValorPIS, DBNull.Value)

            'Seta Parametros - Valor PIS
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "valor_pis"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Float
            oSqlParameter(9).Value = dValorPIS

            'Seta Parametros - Código Tipo Cálculo Imposto PIS - ST
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "codigo_tipo_calculo_imposto_st"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(10).Value = IIf(iTipoCalculoPISST = -1, DBNull.Value, iTipoCalculoPISST)

            'Seta Parametros - Base Cálculo PIS - ST
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "base_calculo_pis_st"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Float
            oSqlParameter(11).Value = IIf(iTipoCalculoPISST = TipoCalculoImposto.Percentual, dBaseCalculoPISST, DBNull.Value)

            'Seta Parametros - Aliquota (%) - ST
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "aliquota_percentual_pis_st"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Float
            oSqlParameter(12).Value = IIf(iTipoCalculoPISST = TipoCalculoImposto.Percentual, dAliquotaPorcentagemPISST, DBNull.Value)

            'Seta Parametros - Quantidade Vendida PIS - ST
            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "quantidade_vendida_pis_st"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Float
            oSqlParameter(13).Value = IIf(iTipoCalculoPISST = TipoCalculoImposto.Valor, dQuantidadeVendidaPISST, DBNull.Value)

            'Seta Parametros - Aliquota (Valor) - ST
            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "aliquota_valor_pis_st"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.Float
            oSqlParameter(14).Value = IIf(iTipoCalculoPISST = TipoCalculoImposto.Valor, dAliquotaValorPISST, DBNull.Value)

            'Seta Parametros - Valor PIS - ST
            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "valor_pis_st"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.Float
            oSqlParameter(15).Value = dValorPISST

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_pis", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosItem(ByVal lCodigo As Long, _
                             ByVal txtDescricao As EditBox, _
                             ByVal cboNCM As UIComboBox, _
                             ByVal cboUnidadeMedida As UIComboBox, _
                             ByVal txtAliquotaIPI As NumericEditBox, _
                             ByVal txtValorUnitario As NumericEditBox, _
                             ByRef bItemEstoque As Boolean, _
                             ByRef bItemProducao As Boolean)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_faturamento_emissao_dados_item_produto", oSqlParameter)

            While oSqlDataReader.Read

                txtDescricao.Text = oSqlDataReader.Item("descricao")
                cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
                cboUnidadeMedida.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida")
                txtAliquotaIPI.Tag = oSqlDataReader.Item("aliquota_ipi")
                txtValorUnitario.Value = oSqlDataReader.Item("preco_venda")
                bItemEstoque = oSqlDataReader.Item("item_estoque")
                bItemProducao = oSqlDataReader.Item("item_producao")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaItem(ByVal sSituacaoTributariaICMS As String, _
                               ByVal iCodigoCFOP As Integer) As String

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim sReturn As String = ""

        Try

            'Seta Parametros - Situação Tributária ICMS
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "situacao_tributaria_icms"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 3
            oSqlParameter(0).Value = sSituacaoTributariaICMS

            'Seta Parametros - Código CFOP
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_cfop"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigoCFOP

            'Seta Parametros - Código Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_emissao_item", oSqlParameter).ToString

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaNCM(ByVal lCodigoEmissaoCapa As Long, _
                              ByVal iCodigoNCM As Integer, _
                              ByVal iCodigoEmissaoDI As Integer) As Boolean

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

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNCM : i += 1

            'Seta Parametros - Código Emissão DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoDI : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_emissao_ncm_di", oSqlParameter).ToString

            Return IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosICMSPartilha(ByVal txtBaseCalculoICMSPartilha As NumericEditBox, _
                                     ByVal txtPercentualFCPICMSPartilha As NumericEditBox, _
                                     ByVal txtPercentualICMSDestino As NumericEditBox, _
                                     ByVal txtPercentualICMSInterestadual As NumericEditBox, _
                                     ByVal txtPercentualICMSPartilha As NumericEditBox, _
                                     ByVal txtValorFCP As NumericEditBox, _
                                     ByVal txtValorICMSDestino As NumericEditBox, _
                                     ByVal txtValorICMSRemetente As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Item
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_emissao_item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoEmissaoItem

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_dados_item_icms_partilha", oSqlParameter)

            While oSqlDataReader.Read

                txtBaseCalculoICMSPartilha.Value = oSqlDataReader.Item("base_calculo_icms")
                txtPercentualFCPICMSPartilha.Value = oSqlDataReader.Item("percentual_fcp_icms")
                txtPercentualICMSDestino.Value = oSqlDataReader.Item("percentual_icms_destino")
                txtPercentualICMSInterestadual.Value = oSqlDataReader.Item("percentual_icms_interestadual")
                txtPercentualICMSPartilha.Value = oSqlDataReader.Item("percentual_icms_partilha")
                txtValorFCP.Value = oSqlDataReader.Item("valor_fcp")
                txtValorICMSDestino.Value = oSqlDataReader.Item("valor_destino_icms")
                txtValorICMSRemetente.Value = oSqlDataReader.Item("valor_remetente_icms")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CalcularICMSPartilha(ByRef txtBaseCalculoICMSPartilha As NumericEditBox, _
                                     ByRef txtPercentualICMSPartilha As NumericEditBox, _
                                     ByRef txtPercentualFCPICMSPartilha As NumericEditBox, _
                                     ByRef txtPercentualICMSDestino As NumericEditBox, _
                                     ByRef txtPercentualICMSInterestadual As NumericEditBox, _
                                     ByRef txtValorFCP As NumericEditBox, _
                                     ByRef txtValorICMSDestino As NumericEditBox, _
                                     ByRef txtValorICMSRemetente As NumericEditBox, _
                                     ByRef txtAliquotaICMS As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(4) As SqlParameter

        Try
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "base_calculo_icms_partilha"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Float
            oSqlParameter(0).Value = txtBaseCalculoICMSPartilha.Value

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "percentual_icms_partilha"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Float
            oSqlParameter(1).Value = txtPercentualICMSPartilha.Value

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "percentual_fcp_icms_partilha"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = txtPercentualFCPICMSPartilha.Value

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "percentual_icms_destino"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Float
            oSqlParameter(3).Value = txtPercentualICMSDestino.Value

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "percentual_icms_interestadual"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Float
            oSqlParameter(4).Value = txtPercentualICMSInterestadual.Value


            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_item_totais", oSqlParameter)

            While oSqlDataReader.Read

                txtValorFCP.Value = oSqlDataReader.Item("valor_icms_fcp")
                txtValorICMSDestino.Value = oSqlDataReader.Item("valor_icms_destino")
                txtValorICMSRemetente.Value = oSqlDataReader.Item("valor_icms_remetente")

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

End Class