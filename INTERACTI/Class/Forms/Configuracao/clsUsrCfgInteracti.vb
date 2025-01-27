Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgInteracti

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe 
    Private bValidaGrupoItemPedido As Boolean
    Private bValidaGrupoItemOrcamento As Boolean
    Private bOrcamentoPedidoMatricial As Boolean
    Private bPDVHablitaDadosPagamentoOrcamento As Boolean
    Private bCodigoDepositoPadraoVenda As Boolean
    Private bDuplicidadeItemVenda As Boolean
    Private bValidaVendaPrecoVenda As Boolean
    Private bValidaVendaPrecoMinimo As Boolean
    Private bMultiploVenda As Boolean
    Private sFormularioFindProdutoOrcamento As String
    Private sFormularioFindProdutoVenda As String
    Private bReservarEstoquePedidoVenda As Boolean
    Private bDataPedidoVendaMaiorAtual As Boolean
    Private bDataOrcamentoMaiorAtual As Boolean
    Private bUsarVendedorExternoVenda As Boolean

    Private bAtualizaPedidoCompraNF As Boolean
    Private bAtualizaPedidoCompraRecebimento As Boolean
    Private fDeltaCustoMedioPrecoCompraTeorico As Double
    Private bReaprovarPedidoCompra As Boolean
    Private bPedidoCompraCheckbox As Boolean
    Private sFormularioFindProdutoCompra As String
    Private bAtualizaPrecoCompraRecebimento As Boolean

    Private bControlaEstoque As Boolean
    Private bDadosProdutoEstoque As Boolean

    Private bExibeDescontoFaturamento As Boolean
    Private sEmailBackupNFe As String
    Private bMoverArquivoNFePastaEntrada As Boolean
    Private bGerarNumeracaoNFe As Boolean
    Private bInformacaoAdicionalProdutoPolygon As Boolean
    Private iTipoCodigoProdutoEmissaoNotaFiscal As Integer
    Private bVisualizarPreNota As Boolean
    Private bValidaRegraFaturamento As Boolean
    Private bAtualizaCadastroXML As Boolean

    Private bBoletoBancarioDLL As Boolean
    Private bValidaCentroCusto As Boolean
    Private bValidaContaContabil As Boolean
    Private bValidaVendaTituloAtraso As Boolean

    Private bComboProdutoDescricao As Boolean
    Private bTeclaAtalho As Boolean
    Private sPastaArquivo As String
    Private sPastaArquivoFisico As String
    Private sDescricaoComboParceiroNegocio As String
    Private sStringConexaoSelma As String
    Private bValidaEmbalagem As Boolean
    Private bLoteTextoEmissao As Boolean

    Private bAtualizaRegraImposto As Boolean
    Private bImpostoRegraPorCliente As Boolean
    Private bTotalImpostoNFAliquota As Boolean
    Private bImpostoRegraPorProduto As Boolean

    Private iTipoApontamentoConcorrente As Integer
    Private iFormatoOrdemProducao As Integer


#End Region

#Region "::: PROPERTIE :::"

#Region "::: COMERCIAL :::"

    Public Property ValidaGrupoItemPedido() As Boolean
        Get
            Return bValidaGrupoItemPedido
        End Get
        Set(ByVal value As Boolean)
            bValidaGrupoItemPedido = value
        End Set
    End Property

    Public Property ValidaGrupoItemOrcamento() As Boolean
        Get
            Return bValidaGrupoItemOrcamento
        End Get
        Set(ByVal value As Boolean)
            bValidaGrupoItemOrcamento = value
        End Set
    End Property

    Public Property OrcamentoPedidoMatricial() As Boolean
        Get
            Return bOrcamentoPedidoMatricial
        End Get
        Set(ByVal value As Boolean)
            bOrcamentoPedidoMatricial = value
        End Set
    End Property

    Public Property PDVHablitaDadosPagamentoOrcamento() As Boolean
        Get
            Return bPDVHablitaDadosPagamentoOrcamento
        End Get
        Set(ByVal value As Boolean)
            bPDVHablitaDadosPagamentoOrcamento = value
        End Set
    End Property

    Public Property CodigoDepositoPadraoVenda() As Boolean
        Get
            Return bCodigoDepositoPadraoVenda
        End Get
        Set(ByVal value As Boolean)
            bCodigoDepositoPadraoVenda = value
        End Set

    End Property

    Public Property DataPedidoVendaMaiorAtual() As Boolean
        Get
            Return bDataPedidoVendaMaiorAtual
        End Get
        Set(ByVal value As Boolean)
            bDataPedidoVendaMaiorAtual = value
        End Set

    End Property

    Public Property ReservarEstoquePedidoVenda() As Boolean
        Get
            Return bReservarEstoquePedidoVenda
        End Get
        Set(ByVal value As Boolean)
            bReservarEstoquePedidoVenda = value
        End Set

    End Property

    Public Property FormularioFindProdutoVenda() As String
        Get
            Return sFormularioFindProdutoVenda
        End Get
        Set(ByVal value As String)
            sFormularioFindProdutoVenda = value
        End Set

    End Property

    Public Property FormularioFindProdutoOrcamento() As String
        Get
            Return sFormularioFindProdutoOrcamento
        End Get
        Set(ByVal value As String)
            sFormularioFindProdutoOrcamento = value
        End Set

    End Property

    Public Property MultiploVenda() As Boolean
        Get
            Return bMultiploVenda
        End Get
        Set(ByVal value As Boolean)
            bMultiploVenda = value
        End Set

    End Property

    Public Property ValidaVendaPrecoMinimo() As Boolean
        Get
            Return bValidaVendaPrecoMinimo
        End Get
        Set(ByVal value As Boolean)
            bValidaVendaPrecoMinimo = value
        End Set

    End Property

    Public Property ValidaVendaPrecoVenda() As Boolean
        Get
            Return bValidaVendaPrecoVenda
        End Get
        Set(ByVal value As Boolean)
            bValidaVendaPrecoVenda = value
        End Set

    End Property

    Public Property DuplicidadeItemVenda() As Boolean
        Get
            Return bDuplicidadeItemVenda
        End Get
        Set(ByVal value As Boolean)
            bDuplicidadeItemVenda = value
        End Set

    End Property

    Public Property UsarVendedorExternoVenda() As Boolean
        Get
            Return bUsarVendedorExternoVenda
        End Get
        Set(ByVal value As Boolean)
            bUsarVendedorExternoVenda = value
        End Set

    End Property

    Public Property DataOrcamentoMaiorAtual() As Boolean
        Get
            Return bDataOrcamentoMaiorAtual
        End Get
        Set(ByVal value As Boolean)
            bDataOrcamentoMaiorAtual = value
        End Set

    End Property
#End Region

#Region "::: COMPRAS :::"

    Public Property AtualizaPrecoCompraRecebimento() As Boolean
        Get
            Return bAtualizaPrecoCompraRecebimento
        End Get
        Set(ByVal value As Boolean)
            bAtualizaPrecoCompraRecebimento = value
        End Set

    End Property

    Public Property FormularioFindProdutoCompra() As String
        Get
            Return sFormularioFindProdutoCompra
        End Get
        Set(ByVal value As String)
            sFormularioFindProdutoCompra = value
        End Set

    End Property

    Public Property PedidoCompraCheckbox() As Boolean
        Get
            Return bPedidoCompraCheckbox
        End Get
        Set(ByVal value As Boolean)
            bPedidoCompraCheckbox = value
        End Set

    End Property

    Public Property ReaprovarPedidoCompra() As Boolean
        Get
            Return bReaprovarPedidoCompra
        End Get
        Set(ByVal value As Boolean)
            bReaprovarPedidoCompra = value
        End Set

    End Property

    Public Property DeltaCustoMedioPrecoCompraTeorico() As Double
        Get
            Return fDeltaCustoMedioPrecoCompraTeorico
        End Get
        Set(ByVal value As Double)
            fDeltaCustoMedioPrecoCompraTeorico = value
        End Set

    End Property

    Public Property AtualizaPedidoCompraRecebimento() As Boolean
        Get
            Return bAtualizaPedidoCompraRecebimento
        End Get
        Set(ByVal value As Boolean)
            bAtualizaPedidoCompraRecebimento = value
        End Set

    End Property

    Public Property AtualizaPedidoCompraNF() As Boolean
        Get
            Return bAtualizaPedidoCompraNF
        End Get
        Set(ByVal value As Boolean)
            bAtualizaPedidoCompraNF = value
        End Set

    End Property

#End Region

#Region "::: ESTOQUE :::"

    Public Property ControlaEstoque() As Boolean
        Get
            Return bControlaEstoque
        End Get
        Set(ByVal value As Boolean)
            bControlaEstoque = value
        End Set

    End Property

    Public Property DadosProdutoEstoque() As Boolean
        Get
            Return bDadosProdutoEstoque
        End Get
        Set(ByVal value As Boolean)
            bDadosProdutoEstoque = value
        End Set

    End Property

#End Region

#Region "::: FATURAMENTO :::"

    Public Property ExibeDescontoFaturamento() As Boolean
        Get
            Return bExibeDescontoFaturamento
        End Get
        Set(ByVal value As Boolean)
            bExibeDescontoFaturamento = value
        End Set
    End Property

    Public Property EmailBackupNFe() As String
        Get
            Return sEmailBackupNFe
        End Get
        Set(ByVal value As String)
            sEmailBackupNFe = value
        End Set
    End Property

    Public Property MoverArquivoNFePastaEntrada() As Boolean
        Get
            Return bMoverArquivoNFePastaEntrada
        End Get
        Set(ByVal value As Boolean)
            bMoverArquivoNFePastaEntrada = value
        End Set
    End Property

    Public Property GerarNumeracaoNFe() As Boolean
        Get
            Return bGerarNumeracaoNFe
        End Get
        Set(ByVal value As Boolean)
            bGerarNumeracaoNFe = value
        End Set
    End Property

    Public Property InformacaoAdicionalProdutoPolygon() As Boolean
        Get
            Return bInformacaoAdicionalProdutoPolygon
        End Get
        Set(ByVal value As Boolean)
            bInformacaoAdicionalProdutoPolygon = value
        End Set

    End Property

    Public Property TipoCodigoProdutoEmissaoNotaFiscal() As Integer
        Get
            Return iTipoCodigoProdutoEmissaoNotaFiscal
        End Get
        Set(ByVal value As Integer)
            iTipoCodigoProdutoEmissaoNotaFiscal = value
        End Set

    End Property

    Public Property VisualizarPreNota() As Boolean
        Get
            Return bVisualizarPreNota
        End Get
        Set(ByVal value As Boolean)
            bVisualizarPreNota = value
        End Set

    End Property

    Public Property ValidaRegraFaturamento() As Boolean
        Get
            Return bValidaRegraFaturamento
        End Get
        Set(ByVal value As Boolean)
            bValidaRegraFaturamento = value
        End Set

    End Property

    Public Property AtualizaCadastroXML() As Boolean
        Get
            Return bAtualizaCadastroXML
        End Get
        Set(ByVal value As Boolean)
            bAtualizaCadastroXML = value
        End Set

    End Property

#End Region

#Region "::: FINANCEIRO :::"
    
    Public Property BoletoBancarioDLL() As Boolean
        Get
            Return bBoletoBancarioDLL
        End Get
        Set(ByVal value As Boolean)
            bBoletoBancarioDLL = value
        End Set
    End Property

    Public Property ValidaCentroCusto() As Boolean
        Get
            Return bValidaCentroCusto
        End Get
        Set(ByVal value As Boolean)
            bValidaCentroCusto = value
        End Set
    End Property

    Public Property ValidaContaContabil() As Boolean
        Get
            Return bValidaContaContabil
        End Get
        Set(ByVal value As Boolean)
            bValidaContaContabil = value
        End Set
    End Property

    Public Property ValidaVendaTituloAtraso() As Boolean
        Get
            Return bValidaVendaTituloAtraso
        End Get
        Set(ByVal value As Boolean)
            bValidaVendaTituloAtraso = value
        End Set
    End Property

#End Region

#Region "::: GERAL :::"
     
    Public Property ComboProdutoDescricao() As Boolean
        Get
            Return bComboProdutoDescricao
        End Get
        Set(ByVal value As Boolean)
            bComboProdutoDescricao = value
        End Set
    End Property

    Public Property TeclaAtalho() As Boolean
        Get
            Return bValidaCentroCusto
        End Get
        Set(ByVal value As Boolean)
            bTeclaAtalho = value
        End Set
    End Property

    Public Property PastaArquivo() As String
        Get
            Return sPastaArquivo
        End Get
        Set(ByVal value As String)
            sPastaArquivo = value
        End Set
    End Property

    Public Property PastaArquivoFisico() As String
        Get
            Return sPastaArquivoFisico
        End Get
        Set(ByVal value As String)
            sPastaArquivoFisico = value
        End Set
    End Property

    Public Property DescricaoComboParceiroNegocio() As String
        Get
            Return sDescricaoComboParceiroNegocio
        End Get
        Set(ByVal value As String)
            sDescricaoComboParceiroNegocio = value
        End Set
    End Property

    Public Property StringConexaoSelma() As String
        Get
            Return sStringConexaoSelma
        End Get
        Set(ByVal value As String)
            sStringConexaoSelma = value
        End Set
    End Property

    Public Property ValidaEmbalagem() As Boolean
        Get
            Return bValidaEmbalagem
        End Get
        Set(ByVal value As Boolean)
            bValidaEmbalagem = value
        End Set
    End Property

    Public Property LoteTextoEmissao() As Boolean
        Get
            Return bLoteTextoEmissao
        End Get
        Set(ByVal value As Boolean)
            bLoteTextoEmissao = value
        End Set
    End Property

#End Region

#Region "::: IMPOSTO :::"

    Public Property AtualizaRegraImposto() As Boolean
        Get
            Return bAtualizaRegraImposto
        End Get
        Set(ByVal value As Boolean)
            bAtualizaRegraImposto = value
        End Set

    End Property

    Public Property ImpostoRegraPorCliente() As Boolean
        Get
            Return bImpostoRegraPorCliente
        End Get
        Set(ByVal value As Boolean)
            bImpostoRegraPorCliente = value
        End Set

    End Property

    Public Property TotalImpostoNFAliquota() As Boolean
        Get
            Return bTotalImpostoNFAliquota
        End Get
        Set(ByVal value As Boolean)
            bTotalImpostoNFAliquota = value
        End Set

    End Property

    Public Property ImpostoRegraPorProduto() As Boolean
        Get
            Return bImpostoRegraPorProduto
        End Get
        Set(ByVal value As Boolean)
            bImpostoRegraPorProduto = value
        End Set

    End Property

#End Region

#Region "::: PRODUÇÃO :::"

    Public Property TipoApontamentoConcorrente() As Integer
        Get
            Return iTipoApontamentoConcorrente
        End Get
        Set(ByVal value As Integer)
            iTipoApontamentoConcorrente = value
        End Set

    End Property

    Public Property FormatoOrdemProducao() As Integer
        Get
            Return iFormatoOrdemProducao
        End Get
        Set(ByVal value As Integer)
            iFormatoOrdemProducao = value
        End Set
    End Property

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Salvar()

        'Variaveis Locais
        Dim oSqlParameter(52) As SqlParameter

        Try
            'Seta Parametros - Valida Grupo Item Pedido
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "valida_grupo_item_pedido"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Bit
            oSqlParameter(0).Value = bValidaGrupoItemPedido

            'Seta Parametros - Valida Grupo Item Orcamento
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "valida_grupo_item_orcamento"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Bit
            oSqlParameter(1).Value = bValidaGrupoItemOrcamento

            'Seta Parametros - Orcamento Pedido Matricial
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "orcamento_pedido_matricial"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Bit
            oSqlParameter(2).Value = bOrcamentoPedidoMatricial

            'Seta Parametros - PDV Hablita Dados Pagamento Orcamento
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "pdv_hablita_dados_pagamento_orcamento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Bit
            oSqlParameter(3).Value = bPDVHablitaDadosPagamentoOrcamento

            'Seta Parametros - Codigo Deposito Padrao Venda
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_deposito_padrao_venda"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Bit
            oSqlParameter(4).Value = bCodigoDepositoPadraoVenda

            'Seta Parametros - Duplicidade Item Venda
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "duplicidade_item_venda"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Bit
            oSqlParameter(5).Value = bDuplicidadeItemVenda

            'Seta Parametros - Valida Venda PrecoVenda
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "valida_venda_preco_venda"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Bit
            oSqlParameter(6).Value = bValidaVendaPrecoVenda

            'Seta Parametros - Valida Venda Preco Minimo
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "valida_venda_preco_minimo"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Bit
            oSqlParameter(7).Value = bValidaVendaPrecoMinimo

            'Seta Parametros - Multiplo Venda
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "multiplo_venda"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Bit
            oSqlParameter(8).Value = bMultiploVenda

            'Seta Parametros - Formulario Find Produto Orcamento
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "formulario_find_produto_orcamento"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.VarChar
            oSqlParameter(9).Value = sFormularioFindProdutoOrcamento

            'Seta Parametros - Formulario Find Produto Venda
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "formulario_find_produto_venda"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.VarChar
            oSqlParameter(10).Value = sFormularioFindProdutoVenda

            'Seta Parametros - Reservar Estoque Pedido Venda
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "reservar_estoque_pedido_venda"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Bit
            oSqlParameter(11).Value = bReservarEstoquePedidoVenda

            'Seta Parametros - Data Pedido Venda Maior Atual
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "data_pedido_venda_maior_atual"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Bit
            oSqlParameter(12).Value = bDataPedidoVendaMaiorAtual

            'Seta Parametros - Data Orcamento Maior Atual
            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "data_orcamento_maior_atual"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Bit
            oSqlParameter(13).Value = bDataOrcamentoMaiorAtual

            'Seta Parametros - Usar Vendedor Externo Venda
            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "usar_vendedor_externo_venda"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.Bit
            oSqlParameter(14).Value = bUsarVendedorExternoVenda

            'Seta Parametros - Atualiza Pedido Compra nf
            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "atualiza_pedido_compra_nf"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.Bit
            oSqlParameter(15).Value = bAtualizaPedidoCompraNF

            'Seta Parametros - Atualiza Pedido Compra Recebimento
            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "atualiza_pedido_compra_recebimento"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.Bit
            oSqlParameter(16).Value = bAtualizaPedidoCompraRecebimento

            'Seta Parametros - Delta Custo Medio Preco Compra Teorico
            oSqlParameter(17) = New SqlParameter
            oSqlParameter(17).ParameterName = "delta_custo_medio_preco_compra_teorico"
            oSqlParameter(17).Direction = ParameterDirection.Input
            oSqlParameter(17).SqlDbType = SqlDbType.Float
            oSqlParameter(17).Value = fDeltaCustoMedioPrecoCompraTeorico

            'Seta Parametros - Reaprovar Pedido Compra
            oSqlParameter(18) = New SqlParameter
            oSqlParameter(18).ParameterName = "reaprovar_pedido_compra"
            oSqlParameter(18).Direction = ParameterDirection.Input
            oSqlParameter(18).SqlDbType = SqlDbType.Bit
            oSqlParameter(18).Value = bReaprovarPedidoCompra

            'Seta Parametros - Pedido Compra Checkbox
            oSqlParameter(19) = New SqlParameter
            oSqlParameter(19).ParameterName = "pedido_compra_checkbox"
            oSqlParameter(19).Direction = ParameterDirection.Input
            oSqlParameter(19).SqlDbType = SqlDbType.Bit
            oSqlParameter(19).Value = bPedidoCompraCheckbox

            'Seta Parametros - Formulario Find Produto Compra
            oSqlParameter(20) = New SqlParameter
            oSqlParameter(20).ParameterName = "formulario_find_produto_compra"
            oSqlParameter(20).Direction = ParameterDirection.Input
            oSqlParameter(20).SqlDbType = SqlDbType.VarChar
            oSqlParameter(20).Value = sFormularioFindProdutoCompra

            'Seta Parametros - Atualiza Preco Compra Recebimento
            oSqlParameter(21) = New SqlParameter
            oSqlParameter(21).ParameterName = "atualiza_preco_compra_recebimento"
            oSqlParameter(21).Direction = ParameterDirection.Input
            oSqlParameter(21).SqlDbType = SqlDbType.Bit
            oSqlParameter(21).Value = bAtualizaPrecoCompraRecebimento

            'Seta Parametros - Controla Estoque
            oSqlParameter(22) = New SqlParameter
            oSqlParameter(22).ParameterName = "controla_estoque"
            oSqlParameter(22).Direction = ParameterDirection.Input
            oSqlParameter(22).SqlDbType = SqlDbType.Bit
            oSqlParameter(22).Value = bControlaEstoque

            'Seta Parametros - Dados Produto Estoque
            oSqlParameter(23) = New SqlParameter
            oSqlParameter(23).ParameterName = "dados_produto_estoque"
            oSqlParameter(23).Direction = ParameterDirection.Input
            oSqlParameter(23).SqlDbType = SqlDbType.Bit
            oSqlParameter(23).Value = bDadosProdutoEstoque

            'Seta Parametros - Exibe Desconto Faturamento
            oSqlParameter(24) = New SqlParameter
            oSqlParameter(24).ParameterName = "exibe_desconto_faturamento"
            oSqlParameter(24).Direction = ParameterDirection.Input
            oSqlParameter(24).SqlDbType = SqlDbType.Bit
            oSqlParameter(24).Value = bExibeDescontoFaturamento

            'Seta Parametros - Email Backup NFe
            oSqlParameter(25) = New SqlParameter
            oSqlParameter(25).ParameterName = "email_backup_nfe"
            oSqlParameter(25).Direction = ParameterDirection.Input
            oSqlParameter(25).SqlDbType = SqlDbType.VarChar
            oSqlParameter(25).Value = sEmailBackupNFe

            'Seta Parametros - Mover Arquivo NFe Pasta Entrada
            oSqlParameter(26) = New SqlParameter
            oSqlParameter(26).ParameterName = "mover_arquivo_nfe_pasta_entrada"
            oSqlParameter(26).Direction = ParameterDirection.Input
            oSqlParameter(26).SqlDbType = SqlDbType.Bit
            oSqlParameter(26).Value = bMoverArquivoNFePastaEntrada

            'Seta Parametros - Gerar Numeracao NFe
            oSqlParameter(27) = New SqlParameter
            oSqlParameter(27).ParameterName = "gerar_numeracao_nfe"
            oSqlParameter(27).Direction = ParameterDirection.Input
            oSqlParameter(27).SqlDbType = SqlDbType.Bit
            oSqlParameter(27).Value = bGerarNumeracaoNFe

            'Seta Parametros - Informacao Adicional Produto Polygon
            oSqlParameter(28) = New SqlParameter
            oSqlParameter(28).ParameterName = "informacao_adicional_produto_polygon"
            oSqlParameter(28).Direction = ParameterDirection.Input
            oSqlParameter(28).SqlDbType = SqlDbType.Bit
            oSqlParameter(28).Value = bInformacaoAdicionalProdutoPolygon

            'Seta Parametros - Tipo Codigo Produto Emissao Nota Fiscal
            oSqlParameter(29) = New SqlParameter
            oSqlParameter(29).ParameterName = "tipo_codigo_produto_emissao_nota_fiscal"
            oSqlParameter(29).Direction = ParameterDirection.Input
            oSqlParameter(29).SqlDbType = SqlDbType.Int
            oSqlParameter(29).Value = iTipoCodigoProdutoEmissaoNotaFiscal

            'Seta Parametros - Visualizar Pre Nota
            oSqlParameter(30) = New SqlParameter
            oSqlParameter(30).ParameterName = "visualizar_pre_nota"
            oSqlParameter(30).Direction = ParameterDirection.Input
            oSqlParameter(30).SqlDbType = SqlDbType.Bit
            oSqlParameter(30).Value = bVisualizarPreNota

            'Seta Parametros - Valida Regra Faturamento
            oSqlParameter(31) = New SqlParameter
            oSqlParameter(31).ParameterName = "valida_regra_faturamento"
            oSqlParameter(31).Direction = ParameterDirection.Input
            oSqlParameter(31).SqlDbType = SqlDbType.Bit
            oSqlParameter(31).Value = bValidaRegraFaturamento

            'Seta Parametros - Atualiza Cadastro XML
            oSqlParameter(32) = New SqlParameter
            oSqlParameter(32).ParameterName = "atualiza_cadastro_xml"
            oSqlParameter(32).Direction = ParameterDirection.Input
            oSqlParameter(32).SqlDbType = SqlDbType.Bit
            oSqlParameter(32).Value = bAtualizaCadastroXML

            'Seta Parametros - Boleto Bancario DLL
            oSqlParameter(33) = New SqlParameter
            oSqlParameter(33).ParameterName = "boleto_bancario_dll"
            oSqlParameter(33).Direction = ParameterDirection.Input
            oSqlParameter(33).SqlDbType = SqlDbType.Bit
            oSqlParameter(33).Value = bBoletoBancarioDLL

            'Seta Parametros - Valida Centro Custo
            oSqlParameter(34) = New SqlParameter
            oSqlParameter(34).ParameterName = "valida_centro_custo"
            oSqlParameter(34).Direction = ParameterDirection.Input
            oSqlParameter(34).SqlDbType = SqlDbType.Bit
            oSqlParameter(34).Value = bValidaCentroCusto

            'Seta Parametros - Valida Conta Contabil
            oSqlParameter(35) = New SqlParameter
            oSqlParameter(35).ParameterName = "valida_conta_contabil"
            oSqlParameter(35).Direction = ParameterDirection.Input
            oSqlParameter(35).SqlDbType = SqlDbType.Bit
            oSqlParameter(35).Value = bValidaContaContabil

            'Seta Parametros - Valida Venda Titulo Atraso
            oSqlParameter(36) = New SqlParameter
            oSqlParameter(36).ParameterName = "valida_venda_titulo_atraso"
            oSqlParameter(36).Direction = ParameterDirection.Input
            oSqlParameter(36).SqlDbType = SqlDbType.Bit
            oSqlParameter(36).Value = bValidaVendaTituloAtraso

            'Seta Parametros - Combo Produto Descricao
            oSqlParameter(37) = New SqlParameter
            oSqlParameter(37).ParameterName = "combo_produto_descricao"
            oSqlParameter(37).Direction = ParameterDirection.Input
            oSqlParameter(37).SqlDbType = SqlDbType.Bit
            oSqlParameter(37).Value = bComboProdutoDescricao

            'Seta Parametros - Tecla Atalho
            oSqlParameter(38) = New SqlParameter
            oSqlParameter(38).ParameterName = "tecla_atalho"
            oSqlParameter(38).Direction = ParameterDirection.Input
            oSqlParameter(38).SqlDbType = SqlDbType.Bit
            oSqlParameter(38).Value = bTeclaAtalho

            'Seta Parametros - Pasta Arquivo
            oSqlParameter(39) = New SqlParameter
            oSqlParameter(39).ParameterName = "pasta_arquivo"
            oSqlParameter(39).Direction = ParameterDirection.Input
            oSqlParameter(39).SqlDbType = SqlDbType.VarChar
            oSqlParameter(39).Value = sPastaArquivo

            'Seta Parametros - Pasta Arquivo Fisico
            oSqlParameter(40) = New SqlParameter
            oSqlParameter(40).ParameterName = "pasta_arquivo_fisico"
            oSqlParameter(40).Direction = ParameterDirection.Input
            oSqlParameter(40).SqlDbType = SqlDbType.VarChar
            oSqlParameter(40).Value = sPastaArquivoFisico

            'Seta Parametros - Descricao Combo Parceiro Negocio
            oSqlParameter(41) = New SqlParameter
            oSqlParameter(41).ParameterName = "descricao_combo_parceiro_negocio"
            oSqlParameter(41).Direction = ParameterDirection.Input
            oSqlParameter(41).SqlDbType = SqlDbType.VarChar
            oSqlParameter(41).Value = sDescricaoComboParceiroNegocio

            'Seta Parametros - String Conexao Selma
            oSqlParameter(42) = New SqlParameter
            oSqlParameter(42).ParameterName = "string_conexao_selma"
            oSqlParameter(42).Direction = ParameterDirection.Input
            oSqlParameter(42).SqlDbType = SqlDbType.VarChar
            oSqlParameter(42).Value = sStringConexaoSelma

            'Seta Parametros - Valida Embalagem
            oSqlParameter(43) = New SqlParameter
            oSqlParameter(43).ParameterName = "valida_embalagem"
            oSqlParameter(43).Direction = ParameterDirection.Input
            oSqlParameter(43).SqlDbType = SqlDbType.Bit
            oSqlParameter(43).Value = bValidaEmbalagem

            'Seta Parametros - Lote Texto Emissao
            oSqlParameter(44) = New SqlParameter
            oSqlParameter(44).ParameterName = "lote_texto_emissao"
            oSqlParameter(44).Direction = ParameterDirection.Input
            oSqlParameter(44).SqlDbType = SqlDbType.Bit
            oSqlParameter(44).Value = bLoteTextoEmissao

            'Seta Parametros - bAtualizaRegraImposto
            oSqlParameter(45) = New SqlParameter
            oSqlParameter(45).ParameterName = "atualiza_regra_imposto"
            oSqlParameter(45).Direction = ParameterDirection.Input
            oSqlParameter(45).SqlDbType = SqlDbType.Bit
            oSqlParameter(45).Value = bAtualizaRegraImposto

            'Seta Parametros - bImpostoRegraPorCliente
            oSqlParameter(46) = New SqlParameter
            oSqlParameter(46).ParameterName = "imposto_regra_por_cliente"
            oSqlParameter(46).Direction = ParameterDirection.Input
            oSqlParameter(46).SqlDbType = SqlDbType.Bit
            oSqlParameter(46).Value = bImpostoRegraPorCliente

            'Seta Parametros - bTotalImpostoNFAliquota
            oSqlParameter(47) = New SqlParameter
            oSqlParameter(47).ParameterName = "total_imposto_nf_aliquota"
            oSqlParameter(47).Direction = ParameterDirection.Input
            oSqlParameter(47).SqlDbType = SqlDbType.Bit
            oSqlParameter(47).Value = bTotalImpostoNFAliquota

            'Seta Parametros - bImpostoRegraPorProduto
            oSqlParameter(48) = New SqlParameter
            oSqlParameter(48).ParameterName = "imposto_regra_por_produto"
            oSqlParameter(48).Direction = ParameterDirection.Input
            oSqlParameter(48).SqlDbType = SqlDbType.Int
            oSqlParameter(48).Value = bImpostoRegraPorProduto

            'Seta Parametros - iTipoApontamentoConcorrente
            oSqlParameter(49) = New SqlParameter
            oSqlParameter(49).ParameterName = "tipo_apontamento_concorrente"
            oSqlParameter(49).Direction = ParameterDirection.Input
            oSqlParameter(49).SqlDbType = SqlDbType.Bit
            oSqlParameter(49).Value = iTipoApontamentoConcorrente

            'Seta Parametros - iFormatoOrdemProducao
            oSqlParameter(50) = New SqlParameter
            oSqlParameter(50).ParameterName = "formato_ordem_producao"
            oSqlParameter(50).Direction = ParameterDirection.Input
            oSqlParameter(50).SqlDbType = SqlDbType.Int
            oSqlParameter(50).Value = bTotalImpostoNFAliquota

            'Seta Parametros - Codigo Empresa
            oSqlParameter(51) = New SqlParameter
            oSqlParameter(51).ParameterName = "codigo_empresa"
            oSqlParameter(51).Direction = ParameterDirection.Input
            oSqlParameter(51).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(51).Value = goUsuario.iEmpresa

            'Seta Parametros - Arquivo Padrão Módulo
            oSqlParameter(52) = New SqlParameter
            oSqlParameter(52).ParameterName = "arquivo_padrao_modulo"
            oSqlParameter(52).Direction = ParameterDirection.Input
            oSqlParameter(52).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(52).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_interacti", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal cboAtualizaCadastroXML As UIComboBox, _
                         ByVal cboAtualizaPedidoCompraNF As UIComboBox, _
                         ByVal cboAtualizaPedidoCompraRecebimento As UIComboBox, _
                         ByVal cboAtualizaPrecoCompraRecebimento As UIComboBox, _
                         ByVal cboAtualizaRegraImposto As UIComboBox, _
                         ByVal cboBoletoBancarioDll As UIComboBox, _
                         ByVal cboComboProdutoDescricao As UIComboBox, _
                         ByVal cboControlaEstoque As UIComboBox, _
                         ByVal cboDadosProdutoEstoque As UIComboBox, _
                         ByVal cboDataOrcamentoMaiorAtual As UIComboBox, _
                         ByVal cboDataPedidoVendaMaiorAtual As UIComboBox, _
                         ByVal cboDuplicidadeItemVenda As UIComboBox, _
                         ByVal cboExibeDescontoFaturamento As UIComboBox, _
                         ByVal cboGerarNumeracaoNFE As UIComboBox, _
                         ByVal cboImpostoRegraPorCliente As UIComboBox, _
                         ByVal cboImpostoRegraPorProduto As UIComboBox, _
                         ByVal cboInformacaoAdicionalProdutoPolygon As UIComboBox, _
                         ByVal cboLoteTextoEmissao As UIComboBox, _
                         ByVal cboMoverArquivoNFEPastaEntrada As UIComboBox, _
                         ByVal cboMultiploVenda As UIComboBox, _
                         ByVal cboOrcamentoPedidoMatricial As UIComboBox, _
                         ByVal cboPdvHablitaDadosPagamentoOrcamento As UIComboBox, _
                         ByVal cboPedidoCompraCheckbox As UIComboBox, _
                         ByVal cboReaprovarPedidoCompra As UIComboBox, _
                         ByVal cboReservarEstoquePedidoVenda As UIComboBox, _
                         ByVal cboTeclaAtalho As UIComboBox, _
                         ByVal cboTotalImpostoNFAliquota As UIComboBox, _
                         ByVal cboUsarVendedorExternoVenda As UIComboBox, _
                         ByVal cboValidaCentroCusto As UIComboBox, _
                         ByVal cboValidaContaContabil As UIComboBox, _
                         ByVal cboValidaEmbalagem As UIComboBox, _
                         ByVal cboValidaGrupoItemOrcamento As UIComboBox, _
                         ByVal cboValidaGrupoItemPedido As UIComboBox, _
                         ByVal cboValidaRegraFaturamento As UIComboBox, _
                         ByVal cboValidaVendaPrecoMinimo As UIComboBox, _
                         ByVal cboValidaVendaPrecoVenda As UIComboBox, _
                         ByVal cboValidaVendaTituloAtraso As UIComboBox, _
                         ByVal cboVisualizarPreNota As UIComboBox, _
                         ByVal cboArquivoPadraoModulo As UIComboBox, _
                         ByVal txtCodigoDepositoPadraoVenda As NumericEditBox, _
                         ByVal txtDeltaCustoMedioPrecoCompraTeorico As NumericEditBox, _
                         ByVal txtDescricaoComboParceiroNegocio As MaskedEditBox, _
                         ByVal txtEmailBackupNFE As MaskedEditBox, _
                         ByVal txtFormatoOrdemProducao As NumericEditBox, _
                         ByVal txtFormularioFindProdutoCompra As MaskedEditBox, _
                         ByVal txtFormularioFindProdutoOrcamento As MaskedEditBox, _
                         ByVal txtFormularioFindProdutoVenda As MaskedEditBox, _
                         ByVal txtPastaArquivo As MaskedEditBox, _
                         ByVal txtPastaArquivoFisico As MaskedEditBox, _
                         ByVal txtStringConexaoSelma As MaskedEditBox, _
                         ByVal txtTipoApontamentoConcorrente As NumericEditBox, _
                         ByVal txtTipoCodigoProdutoEmissaoNotaFiscal As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_interacti_editar", oSqlParameter)

            While oSqlDataReader.Read

                cboAtualizaCadastroXML.SelectedValue = oSqlDataReader.Item("atualiza_cadastro_xml")
                cboAtualizaPedidoCompraNF.SelectedValue = oSqlDataReader.Item("atualiza_pedido_compra_nf")
                cboAtualizaPedidoCompraRecebimento.SelectedValue = oSqlDataReader.Item("atualiza_pedido_compra_recebimento")
                cboAtualizaPrecoCompraRecebimento.SelectedValue = oSqlDataReader.Item("atualiza_preco_compra_recebimento")
                cboAtualizaRegraImposto.SelectedValue = oSqlDataReader.Item("atualiza_regra_imposto")
                cboBoletoBancarioDll.SelectedValue = oSqlDataReader.Item("boleto_bancario_dll")
                cboComboProdutoDescricao.SelectedValue = oSqlDataReader.Item("combo_produto_descricao")
                cboControlaEstoque.SelectedValue = oSqlDataReader.Item("controla_estoque")
                cboDadosProdutoEstoque.SelectedValue = oSqlDataReader.Item("dados_produto_estoque")
                cboDataOrcamentoMaiorAtual.SelectedValue = oSqlDataReader.Item("data_orcamento_maior_atual")
                cboDataPedidoVendaMaiorAtual.SelectedValue = oSqlDataReader.Item("data_pedido_venda_maior_atual")
                cboDuplicidadeItemVenda.SelectedValue = oSqlDataReader.Item("duplicidade_item_venda")
                cboExibeDescontoFaturamento.SelectedValue = oSqlDataReader.Item("exibe_desconto_faturamento")
                cboGerarNumeracaoNFE.SelectedValue = oSqlDataReader.Item("gerar_numeracao_nfe")
                cboImpostoRegraPorCliente.SelectedValue = oSqlDataReader.Item("imposto_regra_por_cliente")
                cboImpostoRegraPorProduto.SelectedValue = oSqlDataReader.Item("imposto_regra_por_produto")
                cboInformacaoAdicionalProdutoPolygon.SelectedValue = oSqlDataReader.Item("informacao_adicional_produto_polygon")
                cboLoteTextoEmissao.SelectedValue = oSqlDataReader.Item("lote_texto_emissao")
                cboMoverArquivoNFEPastaEntrada.SelectedValue = oSqlDataReader.Item("mover_arquivo_nfe_pasta_entrada")
                cboMultiploVenda.SelectedValue = oSqlDataReader.Item("multiplo_venda")
                cboOrcamentoPedidoMatricial.SelectedValue = oSqlDataReader.Item("orcamento_pedido_matricial")
                cboPdvHablitaDadosPagamentoOrcamento.SelectedValue = oSqlDataReader.Item("pdv_habilita_dados_pagamento_orcamento")
                cboPedidoCompraCheckbox.SelectedValue = oSqlDataReader.Item("pedido_compra_checkbox")
                cboReaprovarPedidoCompra.SelectedValue = oSqlDataReader.Item("reaprovar_pedido_compra")
                cboReservarEstoquePedidoVenda.SelectedValue = oSqlDataReader.Item("reservar_estoque_pedido_venda")
                cboTeclaAtalho.SelectedValue = oSqlDataReader.Item("tecla_atalho")
                cboTotalImpostoNFAliquota.SelectedValue = oSqlDataReader.Item("total_imposto_nf_aliquota")
                cboUsarVendedorExternoVenda.SelectedValue = oSqlDataReader.Item("usar_vendedor_externo_venda")
                cboValidaCentroCusto.SelectedValue = oSqlDataReader.Item("valida_centro_custo")
                cboValidaContaContabil.SelectedValue = oSqlDataReader.Item("valida_conta_contabil")
                cboValidaEmbalagem.SelectedValue = oSqlDataReader.Item("valida_embalagem")
                cboValidaGrupoItemOrcamento.SelectedValue = oSqlDataReader.Item("valida_grupo_item_orcamento")
                cboValidaGrupoItemPedido.SelectedValue = oSqlDataReader.Item("valida_grupo_item_pedido")
                cboValidaRegraFaturamento.SelectedValue = oSqlDataReader.Item("valida_regra_faturamento")
                cboValidaVendaPrecoMinimo.SelectedValue = oSqlDataReader.Item("valida_venda_preco_minimo")
                cboValidaVendaPrecoVenda.SelectedValue = oSqlDataReader.Item("valida_venda_preco_venda")
                cboValidaVendaTituloAtraso.SelectedValue = oSqlDataReader.Item("valida_titulo_atraso")
                cboVisualizarPreNota.SelectedValue = oSqlDataReader.Item("visualizar_pre_nota")
                cboArquivoPadraoModulo.SelectedValue = oSqlDataReader.Item("arquivo_padrao_modulo")
                txtCodigoDepositoPadraoVenda.Value = oSqlDataReader.Item("codigo_deposito_padrao_venda")
                txtDeltaCustoMedioPrecoCompraTeorico.Value = oSqlDataReader.Item("delta_custo_medio_preco_compra")
                txtDescricaoComboParceiroNegocio.Text = oSqlDataReader.Item("descricao_combo_parceiro_negocio")
                txtEmailBackupNFE.Text = oSqlDataReader.Item("email_backup_nfe")
                txtFormatoOrdemProducao.Text = oSqlDataReader.Item("formato_ordem_producao")
                txtFormularioFindProdutoCompra.Text = oSqlDataReader.Item("formulario_find_produto_compra")
                txtFormularioFindProdutoOrcamento.Text = oSqlDataReader.Item("formulario_find_produto_orcamento")
                txtFormularioFindProdutoVenda.Text = oSqlDataReader.Item("formulario_find_produto_venda")
                txtPastaArquivo.Text = oSqlDataReader.Item("pasta_arquivo")
                txtPastaArquivoFisico.Text = oSqlDataReader.Item("pasta_arquivo_fisico")
                txtStringConexaoSelma.Text = oSqlDataReader.Item("string_conexao_selma")
                txtTipoApontamentoConcorrente.Value = oSqlDataReader.Item("tipo_apontamento_concorrente")
                txtTipoCodigoProdutoEmissaoNotaFiscal.Value = oSqlDataReader.Item("tipo_codigo_produto_emissao_nota_fiscal")
            End While

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
