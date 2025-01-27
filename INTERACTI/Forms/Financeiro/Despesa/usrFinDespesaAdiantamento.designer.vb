<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinDespesaAdiantamento
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinDespesaAdiantamento))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim grdListagem_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.Image")
        Dim grdListagem_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.Image")
        Dim grdListagem_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column0.Image")
        Dim grdListagem_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_8 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_9 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column3.Image")
        Dim grdClassificacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdClassificacao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtivar = New Janus.Windows.EditControls.UIButton()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTituloAberto = New System.Windows.Forms.Label()
        Me.picTituloAberto = New System.Windows.Forms.PictureBox()
        Me.picTituloQuitado = New System.Windows.Forms.PictureBox()
        Me.lblTituloCancelado = New System.Windows.Forms.Label()
        Me.picTituloCancelado = New System.Windows.Forms.PictureBox()
        Me.lblTituloQuitado = New System.Windows.Forms.Label()
        Me.picTituloParcialmenteQuitado = New System.Windows.Forms.PictureBox()
        Me.lblTituloParcialmenteQuitado = New System.Windows.Forms.Label()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescritivoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescritivoFiltro = New System.Windows.Forms.Label()
        Me.lblContaBancariaFiltro = New System.Windows.Forms.Label()
        Me.cboContaBancariaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarFornecedorFiltro = New System.Windows.Forms.Button()
        Me.txtValorFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFiltro = New System.Windows.Forms.Label()
        Me.dtpDataPagamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPagamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPagamentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataVencimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataVencimentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoTituloFinanceiroFiltro = New System.Windows.Forms.Label()
        Me.cboTipoTituloFinanceiroFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.pagDespesa = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPedidoCompra = New System.Windows.Forms.Label()
        Me.cboPedidoCompra = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataVencimento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataVencimento = New System.Windows.Forms.Label()
        Me.dtpDataEmissao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
        Me.btnCadastrarFornecedor = New System.Windows.Forms.Button()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescritivo = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescritivo = New System.Windows.Forms.Label()
        Me.grpPagamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoDocumentoPagamento = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.grpBoleto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroBoleto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataPagamentoBoleto = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorBoleto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBancoBoleto = New System.Windows.Forms.Label()
        Me.txtBancoBoleto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataPagamentoBoleto = New System.Windows.Forms.Label()
        Me.txtNumeroBoleto8 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto7 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto6 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto5 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto4 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto3 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValorBoleto = New System.Windows.Forms.Label()
        Me.txtNumeroBoleto1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpCartaoCredito = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarCartaoCredito = New System.Windows.Forms.Button()
        Me.txtValorCartaoCredito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCartaoCredito = New System.Windows.Forms.Label()
        Me.lblNumeroParcelaCartaoCredito = New System.Windows.Forms.Label()
        Me.cboCartaoCredito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCartaoCredito = New System.Windows.Forms.Label()
        Me.lblDataPagamentoCartaoCredito = New System.Windows.Forms.Label()
        Me.txtNumeroParcelaCartaoCredito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.dtpDataPagamentoCartaoCredito = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.grpChequeTerceiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoChequeTerceiro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorChequeTerceiro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtPreDatadoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPreDatadoChequeTerceiro = New System.Windows.Forms.Label()
        Me.cboNumeroDocumentoChequeTerceiro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroDocumentoChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtDataRecebimentoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataRecebimentoChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtContaChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblContaChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtAgenciaChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAgenciaChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtBancoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBancoChequeTerceiro = New System.Windows.Forms.Label()
        Me.lblDataPagamentoChequeTerceiro = New System.Windows.Forms.Label()
        Me.grpOutros = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoOutros = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorOutros = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOutros = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoOutros = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoOutros = New System.Windows.Forms.Label()
        Me.lblDataPagamentoOutros = New System.Windows.Forms.Label()
        Me.grpOutrosSimples = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoOutrosSimples = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorOutrosSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOutrosSimples = New System.Windows.Forms.Label()
        Me.lblDataPagamentoOutrosSimples = New System.Windows.Forms.Label()
        Me.grpCheque = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataCompensacaoCheque = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPagamentoCheque = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCompensacaoCheque = New System.Windows.Forms.Label()
        Me.txtValorCheque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCheque = New System.Windows.Forms.Label()
        Me.lblDataPagamentoCheque = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoCheque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoCheque = New System.Windows.Forms.Label()
        Me.lblPreDatadoCheque = New System.Windows.Forms.Label()
        Me.cboPreDatadoCheque = New Janus.Windows.EditControls.UIComboBox()
        Me.txtFavorecidoCheque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFavorecidoCheque = New System.Windows.Forms.Label()
        Me.grpSaldoFornecedor = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoSaldoFornecedor = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorSaldoFornecedor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorSaldoFornecedor = New System.Windows.Forms.Label()
        Me.lblDataPagamentoSaldoFornecedor = New System.Windows.Forms.Label()
        Me.grpBoletoGuia = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroBoletoGuia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia8 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia7 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia6 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia5 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia4 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia3 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataPagamentoBoletoGuia = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorBoletoGuia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumeroBoletoGuia2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValorBoletoGuia = New System.Windows.Forms.Label()
        Me.lblBancoBoletoGuia = New System.Windows.Forms.Label()
        Me.btnCadastrarContaBancaria = New System.Windows.Forms.Button()
        Me.pagClassificacao = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridClassificacao = New System.Windows.Forms.Button()
        Me.btnAgruparGridClassificacao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridClassificacao = New System.Windows.Forms.Button()
        Me.grpClassificao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCentroCusto = New System.Windows.Forms.Button()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.txtValorClassificacao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorClassificacao = New System.Windows.Forms.Label()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcluirClassificacao = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirClassificao = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.grdClassificacao = New Janus.Windows.GridEX.GridEX()
        Me.pagArquivos = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRevisaoArquivo = New System.Windows.Forms.Label()
        Me.txtRevisaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoArquivo = New System.Windows.Forms.Label()
        Me.cboTipoArquivo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.btnCadastrarTipoArquivo = New System.Windows.Forms.Button()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.txtDescritivo1 = New Janus.Windows.GridEX.EditControls.EditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picTituloAberto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloParcialmenteQuitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDespesa.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPagamento.SuspendLayout()
        CType(Me.grpBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoleto.SuspendLayout()
        CType(Me.grpCartaoCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCartaoCredito.SuspendLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChequeTerceiro.SuspendLayout()
        CType(Me.grpOutros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutros.SuspendLayout()
        CType(Me.grpOutrosSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutrosSimples.SuspendLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCheque.SuspendLayout()
        CType(Me.grpSaldoFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSaldoFornecedor.SuspendLayout()
        CType(Me.grpBoletoGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoletoGuia.SuspendLayout()
        Me.pagClassificacao.SuspendLayout()
        CType(Me.grpClassificao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClassificao.SuspendLayout()
        CType(Me.grdClassificacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagArquivos.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme1)
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDespesa})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Despesa"
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_4.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_5.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_6.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_7.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_8.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_8.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_9.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_9.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3, grdListagem_DesignTimeLayout_Reference_4, grdListagem_DesignTimeLayout_Reference_5, grdListagem_DesignTimeLayout_Reference_6, grdListagem_DesignTimeLayout_Reference_7, grdListagem_DesignTimeLayout_Reference_8, grdListagem_DesignTimeLayout_Reference_9})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 5
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 156)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 324)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnAtivar)
        Me.grpControle.Controls.Add(Me.btnCancelar)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Controls.Add(Me.btnNovo)
        Me.grpControle.Location = New System.Drawing.Point(242, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(663, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnAtivar
        '
        Me.btnAtivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtivar.Image = Global.INTERACTI.My.Resources.Resources.undo
        Me.btnAtivar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtivar.Location = New System.Drawing.Point(272, 17)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtivar.Size = New System.Drawing.Size(91, 23)
        Me.btnAtivar.TabIndex = 2
        Me.btnAtivar.Text = "Ativar"
        Me.btnAtivar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(175, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(466, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 4
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(563, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(369, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 3
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblTituloAberto)
        Me.grpLegenda.Controls.Add(Me.picTituloAberto)
        Me.grpLegenda.Controls.Add(Me.picTituloQuitado)
        Me.grpLegenda.Controls.Add(Me.lblTituloCancelado)
        Me.grpLegenda.Controls.Add(Me.picTituloCancelado)
        Me.grpLegenda.Controls.Add(Me.lblTituloQuitado)
        Me.grpLegenda.Controls.Add(Me.picTituloParcialmenteQuitado)
        Me.grpLegenda.Controls.Add(Me.lblTituloParcialmenteQuitado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(225, 51)
        Me.grpLegenda.TabIndex = 2
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblTituloAberto
        '
        Me.lblTituloAberto.AutoSize = True
        Me.lblTituloAberto.Location = New System.Drawing.Point(28, 13)
        Me.lblTituloAberto.Name = "lblTituloAberto"
        Me.lblTituloAberto.Size = New System.Drawing.Size(40, 14)
        Me.lblTituloAberto.TabIndex = 0
        Me.lblTituloAberto.Text = "Aberto"
        '
        'picTituloAberto
        '
        Me.picTituloAberto.BackColor = System.Drawing.Color.DimGray
        Me.picTituloAberto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloAberto.Location = New System.Drawing.Point(9, 13)
        Me.picTituloAberto.Name = "picTituloAberto"
        Me.picTituloAberto.Size = New System.Drawing.Size(13, 14)
        Me.picTituloAberto.TabIndex = 14
        Me.picTituloAberto.TabStop = False
        '
        'picTituloQuitado
        '
        Me.picTituloQuitado.BackColor = System.Drawing.Color.ForestGreen
        Me.picTituloQuitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloQuitado.Location = New System.Drawing.Point(142, 13)
        Me.picTituloQuitado.Name = "picTituloQuitado"
        Me.picTituloQuitado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloQuitado.TabIndex = 12
        Me.picTituloQuitado.TabStop = False
        '
        'lblTituloCancelado
        '
        Me.lblTituloCancelado.AutoSize = True
        Me.lblTituloCancelado.Location = New System.Drawing.Point(161, 31)
        Me.lblTituloCancelado.Name = "lblTituloCancelado"
        Me.lblTituloCancelado.Size = New System.Drawing.Size(58, 14)
        Me.lblTituloCancelado.TabIndex = 3
        Me.lblTituloCancelado.Text = "Cancelado"
        '
        'picTituloCancelado
        '
        Me.picTituloCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picTituloCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloCancelado.Location = New System.Drawing.Point(142, 31)
        Me.picTituloCancelado.Name = "picTituloCancelado"
        Me.picTituloCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloCancelado.TabIndex = 8
        Me.picTituloCancelado.TabStop = False
        '
        'lblTituloQuitado
        '
        Me.lblTituloQuitado.AutoSize = True
        Me.lblTituloQuitado.Location = New System.Drawing.Point(161, 13)
        Me.lblTituloQuitado.Name = "lblTituloQuitado"
        Me.lblTituloQuitado.Size = New System.Drawing.Size(44, 14)
        Me.lblTituloQuitado.TabIndex = 2
        Me.lblTituloQuitado.Text = "Quitado"
        '
        'picTituloParcialmenteQuitado
        '
        Me.picTituloParcialmenteQuitado.BackColor = System.Drawing.Color.SteelBlue
        Me.picTituloParcialmenteQuitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloParcialmenteQuitado.Location = New System.Drawing.Point(9, 31)
        Me.picTituloParcialmenteQuitado.Name = "picTituloParcialmenteQuitado"
        Me.picTituloParcialmenteQuitado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloParcialmenteQuitado.TabIndex = 16
        Me.picTituloParcialmenteQuitado.TabStop = False
        '
        'lblTituloParcialmenteQuitado
        '
        Me.lblTituloParcialmenteQuitado.AutoSize = True
        Me.lblTituloParcialmenteQuitado.Location = New System.Drawing.Point(28, 31)
        Me.lblTituloParcialmenteQuitado.Name = "lblTituloParcialmenteQuitado"
        Me.lblTituloParcialmenteQuitado.Size = New System.Drawing.Size(108, 14)
        Me.lblTituloParcialmenteQuitado.TabIndex = 1
        Me.lblTituloParcialmenteQuitado.Text = "Parcialmente Quitado"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtDescritivoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescritivoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblContaBancariaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboContaBancariaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.txtValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblValorFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPagamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoTituloFinanceiroFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoTituloFinanceiroFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtDescritivoFiltro
        '
        Me.txtDescritivoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivoFiltro.Location = New System.Drawing.Point(370, 114)
        Me.txtDescritivoFiltro.MaxLength = 60
        Me.txtDescritivoFiltro.Name = "txtDescritivoFiltro"
        Me.txtDescritivoFiltro.Size = New System.Drawing.Size(414, 20)
        Me.txtDescritivoFiltro.TabIndex = 24
        '
        'lblDescritivoFiltro
        '
        Me.lblDescritivoFiltro.AutoSize = True
        Me.lblDescritivoFiltro.Location = New System.Drawing.Point(367, 97)
        Me.lblDescritivoFiltro.Name = "lblDescritivoFiltro"
        Me.lblDescritivoFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivoFiltro.TabIndex = 23
        Me.lblDescritivoFiltro.Text = "Descritivo:"
        '
        'lblContaBancariaFiltro
        '
        Me.lblContaBancariaFiltro.AutoSize = True
        Me.lblContaBancariaFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblContaBancariaFiltro.Name = "lblContaBancariaFiltro"
        Me.lblContaBancariaFiltro.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancariaFiltro.TabIndex = 21
        Me.lblContaBancariaFiltro.Text = "Conta Bancária:"
        '
        'cboContaBancariaFiltro
        '
        Me.cboContaBancariaFiltro.AutoSize = False
        Me.cboContaBancariaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancariaFiltro.Location = New System.Drawing.Point(9, 114)
        Me.cboContaBancariaFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboContaBancariaFiltro.Name = "cboContaBancariaFiltro"
        Me.cboContaBancariaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancariaFiltro.Size = New System.Drawing.Size(355, 20)
        Me.cboContaBancariaFiltro.TabIndex = 22
        '
        'btnProcurarFornecedorFiltro
        '
        Me.btnProcurarFornecedorFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedorFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedorFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFornecedorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedorFiltro.Location = New System.Drawing.Point(557, 16)
        Me.btnProcurarFornecedorFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedorFiltro.Name = "btnProcurarFornecedorFiltro"
        Me.btnProcurarFornecedorFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedorFiltro.TabIndex = 22
        Me.btnProcurarFornecedorFiltro.TabStop = False
        Me.btnProcurarFornecedorFiltro.UseVisualStyleBackColor = True
        '
        'txtValorFiltro
        '
        Me.txtValorFiltro.DecimalDigits = 2
        Me.txtValorFiltro.Location = New System.Drawing.Point(685, 34)
        Me.txtValorFiltro.MaxLength = 0
        Me.txtValorFiltro.Name = "txtValorFiltro"
        Me.txtValorFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtValorFiltro.TabIndex = 9
        Me.txtValorFiltro.Text = "0,00"
        Me.txtValorFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFiltro
        '
        Me.lblValorFiltro.AutoSize = True
        Me.lblValorFiltro.Location = New System.Drawing.Point(682, 17)
        Me.lblValorFiltro.Name = "lblValorFiltro"
        Me.lblValorFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblValorFiltro.TabIndex = 8
        Me.lblValorFiltro.Text = "Valor:"
        '
        'dtpDataPagamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoTerminoFiltro.Location = New System.Drawing.Point(685, 74)
        Me.dtpDataPagamentoTerminoFiltro.Name = "dtpDataPagamentoTerminoFiltro"
        Me.dtpDataPagamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataPagamentoTerminoFiltro.TabIndex = 20
        Me.dtpDataPagamentoTerminoFiltro.Value = New Date(2017, 2, 3, 0, 0, 0, 0)
        '
        'dtpDataPagamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoInicioFiltro.Location = New System.Drawing.Point(580, 74)
        Me.dtpDataPagamentoInicioFiltro.Name = "dtpDataPagamentoInicioFiltro"
        Me.dtpDataPagamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataPagamentoInicioFiltro.TabIndex = 19
        Me.dtpDataPagamentoInicioFiltro.Value = New Date(2017, 2, 3, 0, 0, 0, 0)
        '
        'lblDataPagamentoFiltro
        '
        Me.lblDataPagamentoFiltro.AutoSize = True
        Me.lblDataPagamentoFiltro.Location = New System.Drawing.Point(577, 57)
        Me.lblDataPagamentoFiltro.Name = "lblDataPagamentoFiltro"
        Me.lblDataPagamentoFiltro.Size = New System.Drawing.Size(88, 14)
        Me.lblDataPagamentoFiltro.TabIndex = 18
        Me.lblDataPagamentoFiltro.Text = "Data Pagamento:"
        '
        'dtpDataVencimentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoFiltro.Location = New System.Drawing.Point(475, 74)
        Me.dtpDataVencimentoTerminoFiltro.Name = "dtpDataVencimentoTerminoFiltro"
        Me.dtpDataVencimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoTerminoFiltro.TabIndex = 17
        Me.dtpDataVencimentoTerminoFiltro.Value = New Date(2017, 2, 3, 0, 0, 0, 0)
        '
        'dtpDataVencimentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioFiltro.Location = New System.Drawing.Point(370, 74)
        Me.dtpDataVencimentoInicioFiltro.Name = "dtpDataVencimentoInicioFiltro"
        Me.dtpDataVencimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoInicioFiltro.TabIndex = 16
        Me.dtpDataVencimentoInicioFiltro.Value = New Date(2017, 2, 3, 0, 0, 0, 0)
        '
        'lblDataVencimentoFiltro
        '
        Me.lblDataVencimentoFiltro.AutoSize = True
        Me.lblDataVencimentoFiltro.Location = New System.Drawing.Point(367, 57)
        Me.lblDataVencimentoFiltro.Name = "lblDataVencimentoFiltro"
        Me.lblDataVencimentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltro.TabIndex = 15
        Me.lblDataVencimentoFiltro.Text = "Data Vencimento:"
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(265, 74)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 14
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2017, 2, 3, 0, 0, 0, 0)
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(160, 74)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 13
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2017, 2, 3, 0, 0, 0, 0)
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(160, 34)
        Me.txtFornecedorFiltro.MaxLength = 60
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(414, 20)
        Me.txtFornecedorFiltro.TabIndex = 5
        '
        'lblTipoTituloFinanceiroFiltro
        '
        Me.lblTipoTituloFinanceiroFiltro.AutoSize = True
        Me.lblTipoTituloFinanceiroFiltro.Location = New System.Drawing.Point(577, 17)
        Me.lblTipoTituloFinanceiroFiltro.Name = "lblTipoTituloFinanceiroFiltro"
        Me.lblTipoTituloFinanceiroFiltro.Size = New System.Drawing.Size(73, 14)
        Me.lblTipoTituloFinanceiroFiltro.TabIndex = 6
        Me.lblTipoTituloFinanceiroFiltro.Text = "Tipo do Título:"
        '
        'cboTipoTituloFinanceiroFiltro
        '
        Me.cboTipoTituloFinanceiroFiltro.AutoSize = False
        Me.cboTipoTituloFinanceiroFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoTituloFinanceiroFiltro.Location = New System.Drawing.Point(580, 34)
        Me.cboTipoTituloFinanceiroFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoTituloFinanceiroFiltro.Name = "cboTipoTituloFinanceiroFiltro"
        Me.cboTipoTituloFinanceiroFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoTituloFinanceiroFiltro.Size = New System.Drawing.Size(99, 20)
        Me.cboTipoTituloFinanceiroFiltro.TabIndex = 7
        '
        'txtSerieFiltro
        '
        Me.txtSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieFiltro.Location = New System.Drawing.Point(114, 34)
        Me.txtSerieFiltro.MaxLength = 3
        Me.txtSerieFiltro.Name = "txtSerieFiltro"
        Me.txtSerieFiltro.Size = New System.Drawing.Size(40, 20)
        Me.txtSerieFiltro.TabIndex = 3
        '
        'lblSerieFiltro
        '
        Me.lblSerieFiltro.AutoSize = True
        Me.lblSerieFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblSerieFiltro.Name = "lblSerieFiltro"
        Me.lblSerieFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieFiltro.TabIndex = 2
        Me.lblSerieFiltro.Text = "Série:"
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(102, 14)
        Me.lblStatusFiltro.TabIndex = 10
        Me.lblStatusFiltro.Text = "Status da Despesa:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AutoSize = False
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboStatusFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusFiltro.Size = New System.Drawing.Size(145, 20)
        Me.cboStatusFiltro.TabIndex = 11
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroDocumentoFiltro.TabIndex = 1
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoFiltro.TabIndex = 0
        Me.lblNumeroDocumentoFiltro.Text = "Nº Documento:"
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(157, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 4
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 25
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(157, 57)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 12
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'pagDespesa
        '
        Me.pagDespesa.Controls.Add(Me.grpInformacoes)
        Me.pagDespesa.Controls.Add(Me.grdControlesEdicao)
        Me.pagDespesa.Controls.Add(Me.tabDados)
        Me.pagDespesa.Key = "pagDespesa"
        Me.pagDespesa.Location = New System.Drawing.Point(1, 22)
        Me.pagDespesa.Name = "pagDespesa"
        Me.pagDespesa.Size = New System.Drawing.Size(913, 543)
        Me.pagDespesa.TabStop = True
        Me.pagDespesa.Text = "Despesa"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.lblPedidoCompra)
        Me.grpInformacoes.Controls.Add(Me.cboPedidoCompra)
        Me.grpInformacoes.Controls.Add(Me.dtpDataVencimento)
        Me.grpInformacoes.Controls.Add(Me.lblDataVencimento)
        Me.grpInformacoes.Controls.Add(Me.dtpDataEmissao)
        Me.grpInformacoes.Controls.Add(Me.lblDataEmissao)
        Me.grpInformacoes.Controls.Add(Me.txtSerie)
        Me.grpInformacoes.Controls.Add(Me.lblSerie)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.txtValor)
        Me.grpInformacoes.Controls.Add(Me.lblValor)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.cboFornecedor)
        Me.grpInformacoes.Controls.Add(Me.lblFornecedor)
        Me.grpInformacoes.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpInformacoes.Controls.Add(Me.btnCadastrarFornecedor)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(897, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'lblPedidoCompra
        '
        Me.lblPedidoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPedidoCompra.AutoSize = True
        Me.lblPedidoCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPedidoCompra.Location = New System.Drawing.Point(768, 17)
        Me.lblPedidoCompra.Name = "lblPedidoCompra"
        Me.lblPedidoCompra.Size = New System.Drawing.Size(82, 14)
        Me.lblPedidoCompra.TabIndex = 14
        Me.lblPedidoCompra.Text = "Pedido Compra:"
        '
        'cboPedidoCompra
        '
        Me.cboPedidoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPedidoCompra.AutoSize = False
        Me.cboPedidoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPedidoCompra.Location = New System.Drawing.Point(771, 34)
        Me.cboPedidoCompra.Name = "cboPedidoCompra"
        Me.cboPedidoCompra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPedidoCompra.Size = New System.Drawing.Size(108, 20)
        Me.cboPedidoCompra.TabIndex = 15
        '
        'dtpDataVencimento
        '
        Me.dtpDataVencimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataVencimento.DropDownCalendar.Name = ""
        Me.dtpDataVencimento.Location = New System.Drawing.Point(579, 34)
        Me.dtpDataVencimento.Name = "dtpDataVencimento"
        Me.dtpDataVencimento.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataVencimento.TabIndex = 11
        Me.dtpDataVencimento.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'lblDataVencimento
        '
        Me.lblDataVencimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataVencimento.AutoSize = True
        Me.lblDataVencimento.Location = New System.Drawing.Point(576, 17)
        Me.lblDataVencimento.Name = "lblDataVencimento"
        Me.lblDataVencimento.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimento.TabIndex = 10
        Me.lblDataVencimento.Text = "Data Vencimento:"
        '
        'dtpDataEmissao
        '
        '
        '
        '
        Me.dtpDataEmissao.DropDownCalendar.Name = ""
        Me.dtpDataEmissao.Location = New System.Drawing.Point(160, 34)
        Me.dtpDataEmissao.Name = "dtpDataEmissao"
        Me.dtpDataEmissao.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataEmissao.TabIndex = 5
        Me.dtpDataEmissao.Value = New Date(2017, 2, 3, 0, 0, 0, 0)
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(157, 17)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 4
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(114, 34)
        Me.txtSerie.MaxLength = 3
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(40, 20)
        Me.txtSerie.TabIndex = 3
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(111, 17)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Série:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        '
        'txtValor
        '
        Me.txtValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(676, 34)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(90, 20)
        Me.txtValor.TabIndex = 13
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(673, 17)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 12
        Me.lblValor.Text = "Valor:"
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedor.AutoSize = False
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedor.Location = New System.Drawing.Point(256, 34)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedor.Size = New System.Drawing.Size(317, 20)
        Me.cboFornecedor.TabIndex = 8
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(271, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 7
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'btnProcurarFornecedor
        '
        Me.btnProcurarFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(556, 17)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedor.TabIndex = 9
        Me.btnProcurarFornecedor.TabStop = False
        Me.btnProcurarFornecedor.UseVisualStyleBackColor = True
        '
        'btnCadastrarFornecedor
        '
        Me.btnCadastrarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarFornecedor.Location = New System.Drawing.Point(255, 17)
        Me.btnCadastrarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor"
        Me.btnCadastrarFornecedor.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarFornecedor.TabIndex = 6
        Me.btnCadastrarFornecedor.TabStop = False
        Me.btnCadastrarFornecedor.UseVisualStyleBackColor = True
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnNovo1)
        Me.grdControlesEdicao.Controls.Add(Me.btnVoltar)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(8, 483)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(897, 51)
        Me.grdControlesEdicao.TabIndex = 2
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 0
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(8, 73)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 407)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados, Me.pagClassificacao, Me.pagArquivos})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpPagamento)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(895, 384)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados Gerais"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtDescritivo)
        Me.grpDados.Controls.Add(Me.lblDescritivo)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 12)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(879, 253)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados da Despesa"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtDescritivo
        '
        Me.txtDescritivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescritivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivo.Location = New System.Drawing.Point(9, 34)
        Me.txtDescritivo.MaxLength = 500
        Me.txtDescritivo.Multiline = True
        Me.txtDescritivo.Name = "txtDescritivo"
        Me.txtDescritivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescritivo.Size = New System.Drawing.Size(861, 210)
        Me.txtDescritivo.TabIndex = 1
        '
        'lblDescritivo
        '
        Me.lblDescritivo.AutoSize = True
        Me.lblDescritivo.Location = New System.Drawing.Point(6, 17)
        Me.lblDescritivo.Name = "lblDescritivo"
        Me.lblDescritivo.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivo.TabIndex = 0
        Me.lblDescritivo.Text = "Descritivo:"
        '
        'grpPagamento
        '
        Me.grpPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPagamento.BackColor = System.Drawing.Color.Transparent
        Me.grpPagamento.Controls.Add(Me.lblTipoDocumentoPagamento)
        Me.grpPagamento.Controls.Add(Me.cboTipoDocumentoPagamento)
        Me.grpPagamento.Controls.Add(Me.lblContaBancaria)
        Me.grpPagamento.Controls.Add(Me.cboContaBancaria)
        Me.grpPagamento.Controls.Add(Me.grpBoleto)
        Me.grpPagamento.Controls.Add(Me.grpCartaoCredito)
        Me.grpPagamento.Controls.Add(Me.grpChequeTerceiro)
        Me.grpPagamento.Controls.Add(Me.grpOutros)
        Me.grpPagamento.Controls.Add(Me.grpOutrosSimples)
        Me.grpPagamento.Controls.Add(Me.grpCheque)
        Me.grpPagamento.Controls.Add(Me.grpSaldoFornecedor)
        Me.grpPagamento.Controls.Add(Me.grpBoletoGuia)
        Me.grpPagamento.Controls.Add(Me.btnCadastrarContaBancaria)
        Me.grpPagamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPagamento.Location = New System.Drawing.Point(8, 271)
        Me.grpPagamento.Name = "grpPagamento"
        Me.grpPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPagamento.Size = New System.Drawing.Size(879, 104)
        Me.grpPagamento.TabIndex = 1
        Me.grpPagamento.VisualStyleManager = Me.vsmMain
        '
        'lblTipoDocumentoPagamento
        '
        Me.lblTipoDocumentoPagamento.AutoSize = True
        Me.lblTipoDocumentoPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoDocumentoPagamento.Location = New System.Drawing.Point(6, 57)
        Me.lblTipoDocumentoPagamento.Name = "lblTipoDocumentoPagamento"
        Me.lblTipoDocumentoPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblTipoDocumentoPagamento.TabIndex = 3
        Me.lblTipoDocumentoPagamento.Text = "Forma de Pagamento:"
        '
        'cboTipoDocumentoPagamento
        '
        Me.cboTipoDocumentoPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoDocumentoPagamento.AutoSize = False
        Me.cboTipoDocumentoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumentoPagamento.Location = New System.Drawing.Point(9, 74)
        Me.cboTipoDocumentoPagamento.Name = "cboTipoDocumentoPagamento"
        Me.cboTipoDocumentoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumentoPagamento.Size = New System.Drawing.Size(170, 20)
        Me.cboTipoDocumentoPagamento.TabIndex = 4
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaBancaria.Location = New System.Drawing.Point(25, 17)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 1
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContaBancaria.AutoSize = False
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancaria.Location = New System.Drawing.Point(9, 34)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancaria.Size = New System.Drawing.Size(170, 20)
        Me.cboContaBancaria.TabIndex = 2
        '
        'grpBoleto
        '
        Me.grpBoleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBoleto.BackColor = System.Drawing.Color.Transparent
        Me.grpBoleto.BorderColor = System.Drawing.Color.Transparent
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto)
        Me.grpBoleto.Controls.Add(Me.dtpDataPagamentoBoleto)
        Me.grpBoleto.Controls.Add(Me.txtValorBoleto)
        Me.grpBoleto.Controls.Add(Me.lblBancoBoleto)
        Me.grpBoleto.Controls.Add(Me.txtBancoBoleto)
        Me.grpBoleto.Controls.Add(Me.lblDataPagamentoBoleto)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto8)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto7)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto6)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto5)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto4)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto3)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto2)
        Me.grpBoleto.Controls.Add(Me.lblValorBoleto)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto1)
        Me.grpBoleto.Controls.Add(Me.Label4)
        Me.grpBoleto.Location = New System.Drawing.Point(181, 0)
        Me.grpBoleto.Name = "grpBoleto"
        Me.grpBoleto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBoleto.Size = New System.Drawing.Size(505, 104)
        Me.grpBoleto.TabIndex = 29
        Me.grpBoleto.Visible = False
        Me.grpBoleto.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroBoleto
        '
        Me.txtNumeroBoleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroBoleto.MaxLength = 47
        Me.txtNumeroBoleto.Name = "txtNumeroBoleto"
        Me.txtNumeroBoleto.Size = New System.Drawing.Size(304, 20)
        Me.txtNumeroBoleto.TabIndex = 14
        '
        'dtpDataPagamentoBoleto
        '
        '
        '
        '
        Me.dtpDataPagamentoBoleto.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoBoleto.Location = New System.Drawing.Point(320, 74)
        Me.dtpDataPagamentoBoleto.Name = "dtpDataPagamentoBoleto"
        Me.dtpDataPagamentoBoleto.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoBoleto.TabIndex = 9
        Me.dtpDataPagamentoBoleto.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'txtValorBoleto
        '
        Me.txtValorBoleto.Location = New System.Drawing.Point(416, 74)
        Me.txtValorBoleto.Name = "txtValorBoleto"
        Me.txtValorBoleto.Size = New System.Drawing.Size(89, 20)
        Me.txtValorBoleto.TabIndex = 10
        Me.txtValorBoleto.Text = "0,00"
        Me.txtValorBoleto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBancoBoleto
        '
        Me.lblBancoBoleto.AutoSize = True
        Me.lblBancoBoleto.Location = New System.Drawing.Point(6, 57)
        Me.lblBancoBoleto.Name = "lblBancoBoleto"
        Me.lblBancoBoleto.Size = New System.Drawing.Size(41, 14)
        Me.lblBancoBoleto.TabIndex = 9
        Me.lblBancoBoleto.Text = "Banco:"
        '
        'txtBancoBoleto
        '
        Me.txtBancoBoleto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBancoBoleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoBoleto.Location = New System.Drawing.Point(9, 74)
        Me.txtBancoBoleto.MaxLength = 5
        Me.txtBancoBoleto.Name = "txtBancoBoleto"
        Me.txtBancoBoleto.ReadOnly = True
        Me.txtBancoBoleto.Size = New System.Drawing.Size(304, 20)
        Me.txtBancoBoleto.TabIndex = 10
        Me.txtBancoBoleto.TabStop = False
        '
        'lblDataPagamentoBoleto
        '
        Me.lblDataPagamentoBoleto.AutoSize = True
        Me.lblDataPagamentoBoleto.Location = New System.Drawing.Point(316, 57)
        Me.lblDataPagamentoBoleto.Name = "lblDataPagamentoBoleto"
        Me.lblDataPagamentoBoleto.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoBoleto.TabIndex = 11
        Me.lblDataPagamentoBoleto.Text = "Data Pgto.:"
        '
        'txtNumeroBoleto8
        '
        Me.txtNumeroBoleto8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto8.Location = New System.Drawing.Point(416, 34)
        Me.txtNumeroBoleto8.MaxLength = 14
        Me.txtNumeroBoleto8.Name = "txtNumeroBoleto8"
        Me.txtNumeroBoleto8.Size = New System.Drawing.Size(89, 20)
        Me.txtNumeroBoleto8.TabIndex = 8
        Me.txtNumeroBoleto8.Visible = False
        '
        'txtNumeroBoleto7
        '
        Me.txtNumeroBoleto7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto7.Location = New System.Drawing.Point(389, 34)
        Me.txtNumeroBoleto7.MaxLength = 1
        Me.txtNumeroBoleto7.Name = "txtNumeroBoleto7"
        Me.txtNumeroBoleto7.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoleto7.TabIndex = 7
        Me.txtNumeroBoleto7.Visible = False
        '
        'txtNumeroBoleto6
        '
        Me.txtNumeroBoleto6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto6.Location = New System.Drawing.Point(319, 34)
        Me.txtNumeroBoleto6.MaxLength = 6
        Me.txtNumeroBoleto6.Name = "txtNumeroBoleto6"
        Me.txtNumeroBoleto6.Size = New System.Drawing.Size(64, 20)
        Me.txtNumeroBoleto6.TabIndex = 6
        Me.txtNumeroBoleto6.Visible = False
        '
        'txtNumeroBoleto5
        '
        Me.txtNumeroBoleto5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto5.Location = New System.Drawing.Point(259, 34)
        Me.txtNumeroBoleto5.MaxLength = 5
        Me.txtNumeroBoleto5.Name = "txtNumeroBoleto5"
        Me.txtNumeroBoleto5.Size = New System.Drawing.Size(54, 20)
        Me.txtNumeroBoleto5.TabIndex = 5
        Me.txtNumeroBoleto5.Visible = False
        '
        'txtNumeroBoleto4
        '
        Me.txtNumeroBoleto4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto4.Location = New System.Drawing.Point(189, 34)
        Me.txtNumeroBoleto4.MaxLength = 6
        Me.txtNumeroBoleto4.Name = "txtNumeroBoleto4"
        Me.txtNumeroBoleto4.Size = New System.Drawing.Size(64, 20)
        Me.txtNumeroBoleto4.TabIndex = 4
        Me.txtNumeroBoleto4.Visible = False
        '
        'txtNumeroBoleto3
        '
        Me.txtNumeroBoleto3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto3.Location = New System.Drawing.Point(129, 34)
        Me.txtNumeroBoleto3.MaxLength = 5
        Me.txtNumeroBoleto3.Name = "txtNumeroBoleto3"
        Me.txtNumeroBoleto3.Size = New System.Drawing.Size(54, 20)
        Me.txtNumeroBoleto3.TabIndex = 3
        Me.txtNumeroBoleto3.Visible = False
        '
        'txtNumeroBoleto2
        '
        Me.txtNumeroBoleto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto2.Location = New System.Drawing.Point(69, 34)
        Me.txtNumeroBoleto2.MaxLength = 5
        Me.txtNumeroBoleto2.Name = "txtNumeroBoleto2"
        Me.txtNumeroBoleto2.Size = New System.Drawing.Size(54, 20)
        Me.txtNumeroBoleto2.TabIndex = 2
        Me.txtNumeroBoleto2.Visible = False
        '
        'lblValorBoleto
        '
        Me.lblValorBoleto.AutoSize = True
        Me.lblValorBoleto.Location = New System.Drawing.Point(413, 57)
        Me.lblValorBoleto.Name = "lblValorBoleto"
        Me.lblValorBoleto.Size = New System.Drawing.Size(68, 14)
        Me.lblValorBoleto.TabIndex = 13
        Me.lblValorBoleto.Text = "Valor Boleto:"
        '
        'txtNumeroBoleto1
        '
        Me.txtNumeroBoleto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto1.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroBoleto1.MaxLength = 5
        Me.txtNumeroBoleto1.Name = "txtNumeroBoleto1"
        Me.txtNumeroBoleto1.Size = New System.Drawing.Size(54, 20)
        Me.txtNumeroBoleto1.TabIndex = 1
        Me.txtNumeroBoleto1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nº Boleto:"
        '
        'grpCartaoCredito
        '
        Me.grpCartaoCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCartaoCredito.BackColor = System.Drawing.Color.Transparent
        Me.grpCartaoCredito.BorderColor = System.Drawing.Color.Transparent
        Me.grpCartaoCredito.Controls.Add(Me.btnCadastrarCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.txtValorCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblValorCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblNumeroParcelaCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.cboCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblDataPagamentoCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.txtNumeroParcelaCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.dtpDataPagamentoCartaoCredito)
        Me.grpCartaoCredito.Location = New System.Drawing.Point(181, 0)
        Me.grpCartaoCredito.Name = "grpCartaoCredito"
        Me.grpCartaoCredito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCartaoCredito.Size = New System.Drawing.Size(505, 104)
        Me.grpCartaoCredito.TabIndex = 5
        Me.grpCartaoCredito.Visible = False
        Me.grpCartaoCredito.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarCartaoCredito
        '
        Me.btnCadastrarCartaoCredito.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCartaoCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCartaoCredito.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCartaoCredito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCartaoCredito.Location = New System.Drawing.Point(9, 17)
        Me.btnCadastrarCartaoCredito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCartaoCredito.Name = "btnCadastrarCartaoCredito"
        Me.btnCadastrarCartaoCredito.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCartaoCredito.TabIndex = 0
        Me.btnCadastrarCartaoCredito.TabStop = False
        Me.btnCadastrarCartaoCredito.UseVisualStyleBackColor = True
        '
        'txtValorCartaoCredito
        '
        Me.txtValorCartaoCredito.Location = New System.Drawing.Point(314, 34)
        Me.txtValorCartaoCredito.Name = "txtValorCartaoCredito"
        Me.txtValorCartaoCredito.Size = New System.Drawing.Size(98, 20)
        Me.txtValorCartaoCredito.TabIndex = 6
        Me.txtValorCartaoCredito.Text = "0,00"
        Me.txtValorCartaoCredito.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCartaoCredito
        '
        Me.lblValorCartaoCredito.AutoSize = True
        Me.lblValorCartaoCredito.Location = New System.Drawing.Point(311, 17)
        Me.lblValorCartaoCredito.Name = "lblValorCartaoCredito"
        Me.lblValorCartaoCredito.Size = New System.Drawing.Size(35, 14)
        Me.lblValorCartaoCredito.TabIndex = 5
        Me.lblValorCartaoCredito.Text = "Valor:"
        '
        'lblNumeroParcelaCartaoCredito
        '
        Me.lblNumeroParcelaCartaoCredito.AutoSize = True
        Me.lblNumeroParcelaCartaoCredito.Location = New System.Drawing.Point(415, 17)
        Me.lblNumeroParcelaCartaoCredito.Name = "lblNumeroParcelaCartaoCredito"
        Me.lblNumeroParcelaCartaoCredito.Size = New System.Drawing.Size(67, 14)
        Me.lblNumeroParcelaCartaoCredito.TabIndex = 7
        Me.lblNumeroParcelaCartaoCredito.Text = "Nº Parcelas:"
        '
        'cboCartaoCredito
        '
        Me.cboCartaoCredito.AutoSize = False
        Me.cboCartaoCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCartaoCredito.Location = New System.Drawing.Point(9, 34)
        Me.cboCartaoCredito.Name = "cboCartaoCredito"
        Me.cboCartaoCredito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCartaoCredito.Size = New System.Drawing.Size(202, 20)
        Me.cboCartaoCredito.TabIndex = 2
        '
        'lblCartaoCredito
        '
        Me.lblCartaoCredito.AutoSize = True
        Me.lblCartaoCredito.Location = New System.Drawing.Point(25, 17)
        Me.lblCartaoCredito.Name = "lblCartaoCredito"
        Me.lblCartaoCredito.Size = New System.Drawing.Size(91, 14)
        Me.lblCartaoCredito.TabIndex = 1
        Me.lblCartaoCredito.Text = "Cartão de Crédito"
        '
        'lblDataPagamentoCartaoCredito
        '
        Me.lblDataPagamentoCartaoCredito.AutoSize = True
        Me.lblDataPagamentoCartaoCredito.Location = New System.Drawing.Point(214, 17)
        Me.lblDataPagamentoCartaoCredito.Name = "lblDataPagamentoCartaoCredito"
        Me.lblDataPagamentoCartaoCredito.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoCartaoCredito.TabIndex = 3
        Me.lblDataPagamentoCartaoCredito.Text = "Data Pgto.:"
        '
        'txtNumeroParcelaCartaoCredito
        '
        Me.txtNumeroParcelaCartaoCredito.DecimalDigits = 0
        Me.txtNumeroParcelaCartaoCredito.Location = New System.Drawing.Point(418, 34)
        Me.txtNumeroParcelaCartaoCredito.Name = "txtNumeroParcelaCartaoCredito"
        Me.txtNumeroParcelaCartaoCredito.Size = New System.Drawing.Size(87, 20)
        Me.txtNumeroParcelaCartaoCredito.TabIndex = 8
        Me.txtNumeroParcelaCartaoCredito.Text = "0"
        Me.txtNumeroParcelaCartaoCredito.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dtpDataPagamentoCartaoCredito
        '
        '
        '
        '
        Me.dtpDataPagamentoCartaoCredito.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoCartaoCredito.Location = New System.Drawing.Point(217, 34)
        Me.dtpDataPagamentoCartaoCredito.Name = "dtpDataPagamentoCartaoCredito"
        Me.dtpDataPagamentoCartaoCredito.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoCartaoCredito.TabIndex = 4
        Me.dtpDataPagamentoCartaoCredito.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'grpChequeTerceiro
        '
        Me.grpChequeTerceiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpChequeTerceiro.BackColor = System.Drawing.Color.Transparent
        Me.grpChequeTerceiro.BorderColor = System.Drawing.Color.Transparent
        Me.grpChequeTerceiro.Controls.Add(Me.dtpDataPagamentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtValorChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblValorChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtPreDatadoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblPreDatadoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.cboNumeroDocumentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblNumeroDocumentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtDataRecebimentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblDataRecebimentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtContaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblContaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtAgenciaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblAgenciaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtBancoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblBancoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblDataPagamentoChequeTerceiro)
        Me.grpChequeTerceiro.Location = New System.Drawing.Point(181, 0)
        Me.grpChequeTerceiro.Name = "grpChequeTerceiro"
        Me.grpChequeTerceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpChequeTerceiro.Size = New System.Drawing.Size(505, 104)
        Me.grpChequeTerceiro.TabIndex = 1
        Me.grpChequeTerceiro.Visible = False
        Me.grpChequeTerceiro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoChequeTerceiro
        '
        '
        '
        '
        Me.dtpDataPagamentoChequeTerceiro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoChequeTerceiro.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoChequeTerceiro.Name = "dtpDataPagamentoChequeTerceiro"
        Me.dtpDataPagamentoChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoChequeTerceiro.TabIndex = 2
        Me.dtpDataPagamentoChequeTerceiro.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'txtValorChequeTerceiro
        '
        Me.txtValorChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorChequeTerceiro.Location = New System.Drawing.Point(310, 74)
        Me.txtValorChequeTerceiro.Name = "txtValorChequeTerceiro"
        Me.txtValorChequeTerceiro.ReadOnly = True
        Me.txtValorChequeTerceiro.Size = New System.Drawing.Size(98, 20)
        Me.txtValorChequeTerceiro.TabIndex = 9
        Me.txtValorChequeTerceiro.TabStop = False
        Me.txtValorChequeTerceiro.Text = "0,00"
        Me.txtValorChequeTerceiro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorChequeTerceiro
        '
        Me.lblValorChequeTerceiro.AutoSize = True
        Me.lblValorChequeTerceiro.Location = New System.Drawing.Point(307, 57)
        Me.lblValorChequeTerceiro.Name = "lblValorChequeTerceiro"
        Me.lblValorChequeTerceiro.Size = New System.Drawing.Size(75, 14)
        Me.lblValorChequeTerceiro.TabIndex = 12
        Me.lblValorChequeTerceiro.Text = "Valor Cheque:"
        '
        'txtPreDatadoChequeTerceiro
        '
        Me.txtPreDatadoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPreDatadoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreDatadoChequeTerceiro.Location = New System.Drawing.Point(216, 74)
        Me.txtPreDatadoChequeTerceiro.MaxLength = 20
        Me.txtPreDatadoChequeTerceiro.Name = "txtPreDatadoChequeTerceiro"
        Me.txtPreDatadoChequeTerceiro.ReadOnly = True
        Me.txtPreDatadoChequeTerceiro.Size = New System.Drawing.Size(88, 20)
        Me.txtPreDatadoChequeTerceiro.TabIndex = 8
        Me.txtPreDatadoChequeTerceiro.TabStop = False
        '
        'lblPreDatadoChequeTerceiro
        '
        Me.lblPreDatadoChequeTerceiro.AutoSize = True
        Me.lblPreDatadoChequeTerceiro.Location = New System.Drawing.Point(213, 57)
        Me.lblPreDatadoChequeTerceiro.Name = "lblPreDatadoChequeTerceiro"
        Me.lblPreDatadoChequeTerceiro.Size = New System.Drawing.Size(88, 14)
        Me.lblPreDatadoChequeTerceiro.TabIndex = 10
        Me.lblPreDatadoChequeTerceiro.Text = "Pré-datado para:"
        '
        'cboNumeroDocumentoChequeTerceiro
        '
        Me.cboNumeroDocumentoChequeTerceiro.AutoSize = False
        Me.cboNumeroDocumentoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroDocumentoChequeTerceiro.Location = New System.Drawing.Point(9, 34)
        Me.cboNumeroDocumentoChequeTerceiro.Name = "cboNumeroDocumentoChequeTerceiro"
        Me.cboNumeroDocumentoChequeTerceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroDocumentoChequeTerceiro.Size = New System.Drawing.Size(104, 20)
        Me.cboNumeroDocumentoChequeTerceiro.TabIndex = 1
        '
        'lblNumeroDocumentoChequeTerceiro
        '
        Me.lblNumeroDocumentoChequeTerceiro.AutoSize = True
        Me.lblNumeroDocumentoChequeTerceiro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoChequeTerceiro.Name = "lblNumeroDocumentoChequeTerceiro"
        Me.lblNumeroDocumentoChequeTerceiro.Size = New System.Drawing.Size(62, 14)
        Me.lblNumeroDocumentoChequeTerceiro.TabIndex = 0
        Me.lblNumeroDocumentoChequeTerceiro.Text = "Nº Cheque:"
        '
        'txtDataRecebimentoChequeTerceiro
        '
        Me.txtDataRecebimentoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataRecebimentoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataRecebimentoChequeTerceiro.Location = New System.Drawing.Point(119, 74)
        Me.txtDataRecebimentoChequeTerceiro.MaxLength = 20
        Me.txtDataRecebimentoChequeTerceiro.Name = "txtDataRecebimentoChequeTerceiro"
        Me.txtDataRecebimentoChequeTerceiro.ReadOnly = True
        Me.txtDataRecebimentoChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.txtDataRecebimentoChequeTerceiro.TabIndex = 7
        Me.txtDataRecebimentoChequeTerceiro.TabStop = False
        '
        'lblDataRecebimentoChequeTerceiro
        '
        Me.lblDataRecebimentoChequeTerceiro.AutoSize = True
        Me.lblDataRecebimentoChequeTerceiro.Location = New System.Drawing.Point(116, 57)
        Me.lblDataRecebimentoChequeTerceiro.Name = "lblDataRecebimentoChequeTerceiro"
        Me.lblDataRecebimentoChequeTerceiro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataRecebimentoChequeTerceiro.TabIndex = 8
        Me.lblDataRecebimentoChequeTerceiro.Text = "Recebido em:"
        '
        'txtContaChequeTerceiro
        '
        Me.txtContaChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContaChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContaChequeTerceiro.Location = New System.Drawing.Point(9, 74)
        Me.txtContaChequeTerceiro.MaxLength = 20
        Me.txtContaChequeTerceiro.Name = "txtContaChequeTerceiro"
        Me.txtContaChequeTerceiro.ReadOnly = True
        Me.txtContaChequeTerceiro.Size = New System.Drawing.Size(104, 20)
        Me.txtContaChequeTerceiro.TabIndex = 4
        Me.txtContaChequeTerceiro.TabStop = False
        '
        'lblContaChequeTerceiro
        '
        Me.lblContaChequeTerceiro.AutoSize = True
        Me.lblContaChequeTerceiro.Location = New System.Drawing.Point(6, 57)
        Me.lblContaChequeTerceiro.Name = "lblContaChequeTerceiro"
        Me.lblContaChequeTerceiro.Size = New System.Drawing.Size(38, 14)
        Me.lblContaChequeTerceiro.TabIndex = 6
        Me.lblContaChequeTerceiro.Text = "Conta:"
        '
        'txtAgenciaChequeTerceiro
        '
        Me.txtAgenciaChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAgenciaChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAgenciaChequeTerceiro.Location = New System.Drawing.Point(414, 34)
        Me.txtAgenciaChequeTerceiro.MaxLength = 20
        Me.txtAgenciaChequeTerceiro.Name = "txtAgenciaChequeTerceiro"
        Me.txtAgenciaChequeTerceiro.ReadOnly = True
        Me.txtAgenciaChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.txtAgenciaChequeTerceiro.TabIndex = 6
        Me.txtAgenciaChequeTerceiro.TabStop = False
        '
        'lblAgenciaChequeTerceiro
        '
        Me.lblAgenciaChequeTerceiro.AutoSize = True
        Me.lblAgenciaChequeTerceiro.Location = New System.Drawing.Point(411, 17)
        Me.lblAgenciaChequeTerceiro.Name = "lblAgenciaChequeTerceiro"
        Me.lblAgenciaChequeTerceiro.Size = New System.Drawing.Size(50, 14)
        Me.lblAgenciaChequeTerceiro.TabIndex = 4
        Me.lblAgenciaChequeTerceiro.Text = "Agência:"
        '
        'txtBancoChequeTerceiro
        '
        Me.txtBancoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBancoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoChequeTerceiro.Location = New System.Drawing.Point(216, 34)
        Me.txtBancoChequeTerceiro.MaxLength = 20
        Me.txtBancoChequeTerceiro.Name = "txtBancoChequeTerceiro"
        Me.txtBancoChequeTerceiro.ReadOnly = True
        Me.txtBancoChequeTerceiro.Size = New System.Drawing.Size(192, 20)
        Me.txtBancoChequeTerceiro.TabIndex = 4
        Me.txtBancoChequeTerceiro.TabStop = False
        '
        'lblBancoChequeTerceiro
        '
        Me.lblBancoChequeTerceiro.AutoSize = True
        Me.lblBancoChequeTerceiro.Location = New System.Drawing.Point(213, 17)
        Me.lblBancoChequeTerceiro.Name = "lblBancoChequeTerceiro"
        Me.lblBancoChequeTerceiro.Size = New System.Drawing.Size(41, 14)
        Me.lblBancoChequeTerceiro.TabIndex = 2
        Me.lblBancoChequeTerceiro.Text = "Banco:"
        '
        'lblDataPagamentoChequeTerceiro
        '
        Me.lblDataPagamentoChequeTerceiro.AutoSize = True
        Me.lblDataPagamentoChequeTerceiro.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoChequeTerceiro.Name = "lblDataPagamentoChequeTerceiro"
        Me.lblDataPagamentoChequeTerceiro.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoChequeTerceiro.TabIndex = 14
        Me.lblDataPagamentoChequeTerceiro.Text = "Data Pgto.:"
        '
        'grpOutros
        '
        Me.grpOutros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOutros.BackColor = System.Drawing.Color.Transparent
        Me.grpOutros.BorderColor = System.Drawing.Color.Transparent
        Me.grpOutros.Controls.Add(Me.dtpDataPagamentoOutros)
        Me.grpOutros.Controls.Add(Me.txtValorOutros)
        Me.grpOutros.Controls.Add(Me.lblValorOutros)
        Me.grpOutros.Controls.Add(Me.txtNumeroDocumentoOutros)
        Me.grpOutros.Controls.Add(Me.lblNumeroDocumentoOutros)
        Me.grpOutros.Controls.Add(Me.lblDataPagamentoOutros)
        Me.grpOutros.Location = New System.Drawing.Point(181, 0)
        Me.grpOutros.Name = "grpOutros"
        Me.grpOutros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOutros.Size = New System.Drawing.Size(505, 64)
        Me.grpOutros.TabIndex = 1
        Me.grpOutros.Visible = False
        Me.grpOutros.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoOutros
        '
        '
        '
        '
        Me.dtpDataPagamentoOutros.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoOutros.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoOutros.Name = "dtpDataPagamentoOutros"
        Me.dtpDataPagamentoOutros.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoOutros.TabIndex = 2
        Me.dtpDataPagamentoOutros.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'txtValorOutros
        '
        Me.txtValorOutros.Location = New System.Drawing.Point(216, 34)
        Me.txtValorOutros.Name = "txtValorOutros"
        Me.txtValorOutros.Size = New System.Drawing.Size(98, 20)
        Me.txtValorOutros.TabIndex = 3
        Me.txtValorOutros.Text = "0,00"
        Me.txtValorOutros.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorOutros
        '
        Me.lblValorOutros.AutoSize = True
        Me.lblValorOutros.Location = New System.Drawing.Point(213, 17)
        Me.lblValorOutros.Name = "lblValorOutros"
        Me.lblValorOutros.Size = New System.Drawing.Size(35, 14)
        Me.lblValorOutros.TabIndex = 4
        Me.lblValorOutros.Text = "Valor:"
        '
        'txtNumeroDocumentoOutros
        '
        Me.txtNumeroDocumentoOutros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoOutros.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoOutros.MaxLength = 20
        Me.txtNumeroDocumentoOutros.Name = "txtNumeroDocumentoOutros"
        Me.txtNumeroDocumentoOutros.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroDocumentoOutros.TabIndex = 1
        '
        'lblNumeroDocumentoOutros
        '
        Me.lblNumeroDocumentoOutros.AutoSize = True
        Me.lblNumeroDocumentoOutros.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoOutros.Name = "lblNumeroDocumentoOutros"
        Me.lblNumeroDocumentoOutros.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoOutros.TabIndex = 0
        Me.lblNumeroDocumentoOutros.Text = "Nº Documento:"
        '
        'lblDataPagamentoOutros
        '
        Me.lblDataPagamentoOutros.AutoSize = True
        Me.lblDataPagamentoOutros.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoOutros.Name = "lblDataPagamentoOutros"
        Me.lblDataPagamentoOutros.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoOutros.TabIndex = 2
        Me.lblDataPagamentoOutros.Text = "Data Pgto.:"
        '
        'grpOutrosSimples
        '
        Me.grpOutrosSimples.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOutrosSimples.BackColor = System.Drawing.Color.Transparent
        Me.grpOutrosSimples.BorderColor = System.Drawing.Color.Transparent
        Me.grpOutrosSimples.Controls.Add(Me.dtpDataPagamentoOutrosSimples)
        Me.grpOutrosSimples.Controls.Add(Me.txtValorOutrosSimples)
        Me.grpOutrosSimples.Controls.Add(Me.lblValorOutrosSimples)
        Me.grpOutrosSimples.Controls.Add(Me.lblDataPagamentoOutrosSimples)
        Me.grpOutrosSimples.Location = New System.Drawing.Point(181, 0)
        Me.grpOutrosSimples.Name = "grpOutrosSimples"
        Me.grpOutrosSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOutrosSimples.Size = New System.Drawing.Size(505, 64)
        Me.grpOutrosSimples.TabIndex = 1
        Me.grpOutrosSimples.Visible = False
        Me.grpOutrosSimples.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoOutrosSimples
        '
        '
        '
        '
        Me.dtpDataPagamentoOutrosSimples.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoOutrosSimples.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataPagamentoOutrosSimples.Name = "dtpDataPagamentoOutrosSimples"
        Me.dtpDataPagamentoOutrosSimples.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoOutrosSimples.TabIndex = 1
        Me.dtpDataPagamentoOutrosSimples.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'txtValorOutrosSimples
        '
        Me.txtValorOutrosSimples.Location = New System.Drawing.Point(106, 34)
        Me.txtValorOutrosSimples.Name = "txtValorOutrosSimples"
        Me.txtValorOutrosSimples.Size = New System.Drawing.Size(98, 20)
        Me.txtValorOutrosSimples.TabIndex = 3
        Me.txtValorOutrosSimples.Text = "0,00"
        Me.txtValorOutrosSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorOutrosSimples
        '
        Me.lblValorOutrosSimples.AutoSize = True
        Me.lblValorOutrosSimples.Location = New System.Drawing.Point(103, 17)
        Me.lblValorOutrosSimples.Name = "lblValorOutrosSimples"
        Me.lblValorOutrosSimples.Size = New System.Drawing.Size(35, 14)
        Me.lblValorOutrosSimples.TabIndex = 4
        Me.lblValorOutrosSimples.Text = "Valor:"
        '
        'lblDataPagamentoOutrosSimples
        '
        Me.lblDataPagamentoOutrosSimples.AutoSize = True
        Me.lblDataPagamentoOutrosSimples.Location = New System.Drawing.Point(6, 17)
        Me.lblDataPagamentoOutrosSimples.Name = "lblDataPagamentoOutrosSimples"
        Me.lblDataPagamentoOutrosSimples.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoOutrosSimples.TabIndex = 2
        Me.lblDataPagamentoOutrosSimples.Text = "Data Pgto.:"
        '
        'grpCheque
        '
        Me.grpCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCheque.BackColor = System.Drawing.Color.Transparent
        Me.grpCheque.BorderColor = System.Drawing.Color.Transparent
        Me.grpCheque.Controls.Add(Me.dtpDataCompensacaoCheque)
        Me.grpCheque.Controls.Add(Me.dtpDataPagamentoCheque)
        Me.grpCheque.Controls.Add(Me.lblDataCompensacaoCheque)
        Me.grpCheque.Controls.Add(Me.txtValorCheque)
        Me.grpCheque.Controls.Add(Me.lblValorCheque)
        Me.grpCheque.Controls.Add(Me.lblDataPagamentoCheque)
        Me.grpCheque.Controls.Add(Me.txtNumeroDocumentoCheque)
        Me.grpCheque.Controls.Add(Me.lblNumeroDocumentoCheque)
        Me.grpCheque.Controls.Add(Me.lblPreDatadoCheque)
        Me.grpCheque.Controls.Add(Me.cboPreDatadoCheque)
        Me.grpCheque.Controls.Add(Me.txtFavorecidoCheque)
        Me.grpCheque.Controls.Add(Me.lblFavorecidoCheque)
        Me.grpCheque.Location = New System.Drawing.Point(181, 0)
        Me.grpCheque.Name = "grpCheque"
        Me.grpCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCheque.Size = New System.Drawing.Size(505, 104)
        Me.grpCheque.TabIndex = 1
        Me.grpCheque.Visible = False
        Me.grpCheque.VisualStyleManager = Me.vsmMain
        '
        'dtpDataCompensacaoCheque
        '
        '
        '
        '
        Me.dtpDataCompensacaoCheque.DropDownCalendar.Name = ""
        Me.dtpDataCompensacaoCheque.Location = New System.Drawing.Point(216, 74)
        Me.dtpDataCompensacaoCheque.Name = "dtpDataCompensacaoCheque"
        Me.dtpDataCompensacaoCheque.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataCompensacaoCheque.TabIndex = 9
        Me.dtpDataCompensacaoCheque.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'dtpDataPagamentoCheque
        '
        '
        '
        '
        Me.dtpDataPagamentoCheque.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoCheque.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoCheque.Name = "dtpDataPagamentoCheque"
        Me.dtpDataPagamentoCheque.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoCheque.TabIndex = 1
        Me.dtpDataPagamentoCheque.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'lblDataCompensacaoCheque
        '
        Me.lblDataCompensacaoCheque.AutoSize = True
        Me.lblDataCompensacaoCheque.Location = New System.Drawing.Point(213, 57)
        Me.lblDataCompensacaoCheque.Name = "lblDataCompensacaoCheque"
        Me.lblDataCompensacaoCheque.Size = New System.Drawing.Size(88, 14)
        Me.lblDataCompensacaoCheque.TabIndex = 8
        Me.lblDataCompensacaoCheque.Text = "Pré-datado para:"
        '
        'txtValorCheque
        '
        Me.txtValorCheque.Location = New System.Drawing.Point(9, 74)
        Me.txtValorCheque.Name = "txtValorCheque"
        Me.txtValorCheque.Size = New System.Drawing.Size(104, 20)
        Me.txtValorCheque.TabIndex = 3
        Me.txtValorCheque.Text = "0,00"
        Me.txtValorCheque.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCheque
        '
        Me.lblValorCheque.AutoSize = True
        Me.lblValorCheque.Location = New System.Drawing.Point(6, 57)
        Me.lblValorCheque.Name = "lblValorCheque"
        Me.lblValorCheque.Size = New System.Drawing.Size(75, 14)
        Me.lblValorCheque.TabIndex = 10
        Me.lblValorCheque.Text = "Valor Cheque:"
        '
        'lblDataPagamentoCheque
        '
        Me.lblDataPagamentoCheque.AutoSize = True
        Me.lblDataPagamentoCheque.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoCheque.Name = "lblDataPagamentoCheque"
        Me.lblDataPagamentoCheque.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoCheque.TabIndex = 2
        Me.lblDataPagamentoCheque.Text = "Data Pgto.:"
        '
        'txtNumeroDocumentoCheque
        '
        Me.txtNumeroDocumentoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoCheque.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoCheque.MaxLength = 20
        Me.txtNumeroDocumentoCheque.Name = "txtNumeroDocumentoCheque"
        Me.txtNumeroDocumentoCheque.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroDocumentoCheque.TabIndex = 0
        '
        'lblNumeroDocumentoCheque
        '
        Me.lblNumeroDocumentoCheque.AutoSize = True
        Me.lblNumeroDocumentoCheque.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoCheque.Name = "lblNumeroDocumentoCheque"
        Me.lblNumeroDocumentoCheque.Size = New System.Drawing.Size(62, 14)
        Me.lblNumeroDocumentoCheque.TabIndex = 0
        Me.lblNumeroDocumentoCheque.Text = "Nº Cheque:"
        '
        'lblPreDatadoCheque
        '
        Me.lblPreDatadoCheque.AutoSize = True
        Me.lblPreDatadoCheque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPreDatadoCheque.Location = New System.Drawing.Point(116, 57)
        Me.lblPreDatadoCheque.Name = "lblPreDatadoCheque"
        Me.lblPreDatadoCheque.Size = New System.Drawing.Size(63, 14)
        Me.lblPreDatadoCheque.TabIndex = 6
        Me.lblPreDatadoCheque.Text = "Pré-datado:"
        '
        'cboPreDatadoCheque
        '
        Me.cboPreDatadoCheque.AutoSize = False
        Me.cboPreDatadoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPreDatadoCheque.Location = New System.Drawing.Point(119, 74)
        Me.cboPreDatadoCheque.Name = "cboPreDatadoCheque"
        Me.cboPreDatadoCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPreDatadoCheque.Size = New System.Drawing.Size(91, 20)
        Me.cboPreDatadoCheque.TabIndex = 4
        '
        'txtFavorecidoCheque
        '
        Me.txtFavorecidoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFavorecidoCheque.Location = New System.Drawing.Point(216, 34)
        Me.txtFavorecidoCheque.MaxLength = 100
        Me.txtFavorecidoCheque.Name = "txtFavorecidoCheque"
        Me.txtFavorecidoCheque.Size = New System.Drawing.Size(289, 20)
        Me.txtFavorecidoCheque.TabIndex = 2
        '
        'lblFavorecidoCheque
        '
        Me.lblFavorecidoCheque.AutoSize = True
        Me.lblFavorecidoCheque.Location = New System.Drawing.Point(213, 17)
        Me.lblFavorecidoCheque.Name = "lblFavorecidoCheque"
        Me.lblFavorecidoCheque.Size = New System.Drawing.Size(64, 14)
        Me.lblFavorecidoCheque.TabIndex = 4
        Me.lblFavorecidoCheque.Text = "Favorecido:"
        '
        'grpSaldoFornecedor
        '
        Me.grpSaldoFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSaldoFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.grpSaldoFornecedor.BorderColor = System.Drawing.Color.Transparent
        Me.grpSaldoFornecedor.Controls.Add(Me.dtpDataPagamentoSaldoFornecedor)
        Me.grpSaldoFornecedor.Controls.Add(Me.txtValorSaldoFornecedor)
        Me.grpSaldoFornecedor.Controls.Add(Me.lblValorSaldoFornecedor)
        Me.grpSaldoFornecedor.Controls.Add(Me.lblDataPagamentoSaldoFornecedor)
        Me.grpSaldoFornecedor.Location = New System.Drawing.Point(181, 0)
        Me.grpSaldoFornecedor.Name = "grpSaldoFornecedor"
        Me.grpSaldoFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSaldoFornecedor.Size = New System.Drawing.Size(505, 64)
        Me.grpSaldoFornecedor.TabIndex = 30
        Me.grpSaldoFornecedor.Visible = False
        Me.grpSaldoFornecedor.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoSaldoFornecedor
        '
        '
        '
        '
        Me.dtpDataPagamentoSaldoFornecedor.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoSaldoFornecedor.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataPagamentoSaldoFornecedor.Name = "dtpDataPagamentoSaldoFornecedor"
        Me.dtpDataPagamentoSaldoFornecedor.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoSaldoFornecedor.TabIndex = 1
        Me.dtpDataPagamentoSaldoFornecedor.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'txtValorSaldoFornecedor
        '
        Me.txtValorSaldoFornecedor.Location = New System.Drawing.Point(106, 34)
        Me.txtValorSaldoFornecedor.Name = "txtValorSaldoFornecedor"
        Me.txtValorSaldoFornecedor.Size = New System.Drawing.Size(98, 20)
        Me.txtValorSaldoFornecedor.TabIndex = 3
        Me.txtValorSaldoFornecedor.Text = "0,00"
        Me.txtValorSaldoFornecedor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorSaldoFornecedor
        '
        Me.lblValorSaldoFornecedor.AutoSize = True
        Me.lblValorSaldoFornecedor.Location = New System.Drawing.Point(103, 17)
        Me.lblValorSaldoFornecedor.Name = "lblValorSaldoFornecedor"
        Me.lblValorSaldoFornecedor.Size = New System.Drawing.Size(35, 14)
        Me.lblValorSaldoFornecedor.TabIndex = 2
        Me.lblValorSaldoFornecedor.Text = "Valor:"
        '
        'lblDataPagamentoSaldoFornecedor
        '
        Me.lblDataPagamentoSaldoFornecedor.AutoSize = True
        Me.lblDataPagamentoSaldoFornecedor.Location = New System.Drawing.Point(6, 17)
        Me.lblDataPagamentoSaldoFornecedor.Name = "lblDataPagamentoSaldoFornecedor"
        Me.lblDataPagamentoSaldoFornecedor.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoSaldoFornecedor.TabIndex = 0
        Me.lblDataPagamentoSaldoFornecedor.Text = "Data Pgto.:"
        '
        'grpBoletoGuia
        '
        Me.grpBoletoGuia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBoletoGuia.BackColor = System.Drawing.Color.Transparent
        Me.grpBoletoGuia.BorderColor = System.Drawing.Color.Transparent
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia8)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia7)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia6)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia5)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia4)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia3)
        Me.grpBoletoGuia.Controls.Add(Me.dtpDataPagamentoBoletoGuia)
        Me.grpBoletoGuia.Controls.Add(Me.txtValorBoletoGuia)
        Me.grpBoletoGuia.Controls.Add(Me.Label6)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia2)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia1)
        Me.grpBoletoGuia.Controls.Add(Me.lblValorBoletoGuia)
        Me.grpBoletoGuia.Controls.Add(Me.lblBancoBoletoGuia)
        Me.grpBoletoGuia.Location = New System.Drawing.Point(181, 12)
        Me.grpBoletoGuia.Name = "grpBoletoGuia"
        Me.grpBoletoGuia.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBoletoGuia.Size = New System.Drawing.Size(519, 86)
        Me.grpBoletoGuia.TabIndex = 9
        Me.grpBoletoGuia.Visible = False
        Me.grpBoletoGuia.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroBoletoGuia
        '
        Me.txtNumeroBoletoGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia.Location = New System.Drawing.Point(9, 22)
        Me.txtNumeroBoletoGuia.MaxLength = 48
        Me.txtNumeroBoletoGuia.Name = "txtNumeroBoletoGuia"
        Me.txtNumeroBoletoGuia.Size = New System.Drawing.Size(299, 20)
        Me.txtNumeroBoletoGuia.TabIndex = 13
        '
        'txtNumeroBoletoGuia8
        '
        Me.txtNumeroBoletoGuia8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia8.Location = New System.Drawing.Point(422, 22)
        Me.txtNumeroBoletoGuia8.MaxLength = 1
        Me.txtNumeroBoletoGuia8.Name = "txtNumeroBoletoGuia8"
        Me.txtNumeroBoletoGuia8.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoletoGuia8.TabIndex = 8
        Me.txtNumeroBoletoGuia8.Visible = False
        '
        'txtNumeroBoletoGuia7
        '
        Me.txtNumeroBoletoGuia7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia7.Location = New System.Drawing.Point(339, 22)
        Me.txtNumeroBoletoGuia7.MaxLength = 11
        Me.txtNumeroBoletoGuia7.Name = "txtNumeroBoletoGuia7"
        Me.txtNumeroBoletoGuia7.Size = New System.Drawing.Size(77, 20)
        Me.txtNumeroBoletoGuia7.TabIndex = 7
        Me.txtNumeroBoletoGuia7.Visible = False
        '
        'txtNumeroBoletoGuia6
        '
        Me.txtNumeroBoletoGuia6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia6.Location = New System.Drawing.Point(312, 22)
        Me.txtNumeroBoletoGuia6.MaxLength = 1
        Me.txtNumeroBoletoGuia6.Name = "txtNumeroBoletoGuia6"
        Me.txtNumeroBoletoGuia6.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoletoGuia6.TabIndex = 6
        Me.txtNumeroBoletoGuia6.Visible = False
        '
        'txtNumeroBoletoGuia5
        '
        Me.txtNumeroBoletoGuia5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia5.Location = New System.Drawing.Point(229, 22)
        Me.txtNumeroBoletoGuia5.MaxLength = 11
        Me.txtNumeroBoletoGuia5.Name = "txtNumeroBoletoGuia5"
        Me.txtNumeroBoletoGuia5.Size = New System.Drawing.Size(77, 20)
        Me.txtNumeroBoletoGuia5.TabIndex = 5
        Me.txtNumeroBoletoGuia5.Visible = False
        '
        'txtNumeroBoletoGuia4
        '
        Me.txtNumeroBoletoGuia4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia4.Location = New System.Drawing.Point(202, 22)
        Me.txtNumeroBoletoGuia4.MaxLength = 1
        Me.txtNumeroBoletoGuia4.Name = "txtNumeroBoletoGuia4"
        Me.txtNumeroBoletoGuia4.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoletoGuia4.TabIndex = 4
        Me.txtNumeroBoletoGuia4.Visible = False
        '
        'txtNumeroBoletoGuia3
        '
        Me.txtNumeroBoletoGuia3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia3.Location = New System.Drawing.Point(119, 22)
        Me.txtNumeroBoletoGuia3.MaxLength = 11
        Me.txtNumeroBoletoGuia3.Name = "txtNumeroBoletoGuia3"
        Me.txtNumeroBoletoGuia3.Size = New System.Drawing.Size(77, 20)
        Me.txtNumeroBoletoGuia3.TabIndex = 3
        Me.txtNumeroBoletoGuia3.Visible = False
        '
        'dtpDataPagamentoBoletoGuia
        '
        '
        '
        '
        Me.dtpDataPagamentoBoletoGuia.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoBoletoGuia.Location = New System.Drawing.Point(9, 62)
        Me.dtpDataPagamentoBoletoGuia.Name = "dtpDataPagamentoBoletoGuia"
        Me.dtpDataPagamentoBoletoGuia.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoBoletoGuia.TabIndex = 10
        Me.dtpDataPagamentoBoletoGuia.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'txtValorBoletoGuia
        '
        Me.txtValorBoletoGuia.Location = New System.Drawing.Point(106, 62)
        Me.txtValorBoletoGuia.Name = "txtValorBoletoGuia"
        Me.txtValorBoletoGuia.Size = New System.Drawing.Size(89, 20)
        Me.txtValorBoletoGuia.TabIndex = 12
        Me.txtValorBoletoGuia.Text = "0,00"
        Me.txtValorBoletoGuia.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Data Pgto.:"
        '
        'txtNumeroBoletoGuia2
        '
        Me.txtNumeroBoletoGuia2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia2.Location = New System.Drawing.Point(92, 22)
        Me.txtNumeroBoletoGuia2.MaxLength = 1
        Me.txtNumeroBoletoGuia2.Name = "txtNumeroBoletoGuia2"
        Me.txtNumeroBoletoGuia2.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoletoGuia2.TabIndex = 2
        Me.txtNumeroBoletoGuia2.Visible = False
        '
        'txtNumeroBoletoGuia1
        '
        Me.txtNumeroBoletoGuia1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia1.Location = New System.Drawing.Point(9, 22)
        Me.txtNumeroBoletoGuia1.MaxLength = 11
        Me.txtNumeroBoletoGuia1.Name = "txtNumeroBoletoGuia1"
        Me.txtNumeroBoletoGuia1.Size = New System.Drawing.Size(77, 20)
        Me.txtNumeroBoletoGuia1.TabIndex = 1
        Me.txtNumeroBoletoGuia1.Visible = False
        '
        'lblValorBoletoGuia
        '
        Me.lblValorBoletoGuia.AutoSize = True
        Me.lblValorBoletoGuia.Location = New System.Drawing.Point(102, 45)
        Me.lblValorBoletoGuia.Name = "lblValorBoletoGuia"
        Me.lblValorBoletoGuia.Size = New System.Drawing.Size(68, 14)
        Me.lblValorBoletoGuia.TabIndex = 11
        Me.lblValorBoletoGuia.Text = "Valor Boleto:"
        '
        'lblBancoBoletoGuia
        '
        Me.lblBancoBoletoGuia.AutoSize = True
        Me.lblBancoBoletoGuia.Location = New System.Drawing.Point(5, 5)
        Me.lblBancoBoletoGuia.Name = "lblBancoBoletoGuia"
        Me.lblBancoBoletoGuia.Size = New System.Drawing.Size(80, 14)
        Me.lblBancoBoletoGuia.TabIndex = 0
        Me.lblBancoBoletoGuia.Text = "Nº Boleto Guia:"
        '
        'btnCadastrarContaBancaria
        '
        Me.btnCadastrarContaBancaria.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaBancaria.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaBancaria.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarContaBancaria.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaBancaria.Name = "btnCadastrarContaBancaria"
        Me.btnCadastrarContaBancaria.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaBancaria.TabIndex = 0
        Me.btnCadastrarContaBancaria.TabStop = False
        Me.btnCadastrarContaBancaria.UseVisualStyleBackColor = True
        '
        'pagClassificacao
        '
        Me.pagClassificacao.Controls.Add(Me.btnExcelGridClassificacao)
        Me.pagClassificacao.Controls.Add(Me.btnAgruparGridClassificacao)
        Me.pagClassificacao.Controls.Add(Me.btnConfigurarGridClassificacao)
        Me.pagClassificacao.Controls.Add(Me.grpClassificao)
        Me.pagClassificacao.Controls.Add(Me.grdClassificacao)
        Me.pagClassificacao.Key = "pagClassificacao"
        Me.pagClassificacao.Location = New System.Drawing.Point(1, 22)
        Me.pagClassificacao.Name = "pagClassificacao"
        Me.pagClassificacao.Size = New System.Drawing.Size(895, 384)
        Me.pagClassificacao.TabStop = True
        Me.pagClassificacao.Text = "Classificação"
        '
        'btnExcelGridClassificacao
        '
        Me.btnExcelGridClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridClassificacao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridClassificacao.FlatAppearance.BorderSize = 0
        Me.btnExcelGridClassificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridClassificacao.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridClassificacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridClassificacao.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridClassificacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridClassificacao.Name = "btnExcelGridClassificacao"
        Me.btnExcelGridClassificacao.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridClassificacao.TabIndex = 25
        Me.btnExcelGridClassificacao.TabStop = False
        Me.btnExcelGridClassificacao.UseVisualStyleBackColor = False
        '
        'btnAgruparGridClassificacao
        '
        Me.btnAgruparGridClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridClassificacao.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridClassificacao.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridClassificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridClassificacao.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridClassificacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridClassificacao.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridClassificacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridClassificacao.Name = "btnAgruparGridClassificacao"
        Me.btnAgruparGridClassificacao.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridClassificacao.TabIndex = 24
        Me.btnAgruparGridClassificacao.TabStop = False
        Me.btnAgruparGridClassificacao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridClassificacao
        '
        Me.btnConfigurarGridClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridClassificacao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridClassificacao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridClassificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridClassificacao.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridClassificacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridClassificacao.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridClassificacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridClassificacao.Name = "btnConfigurarGridClassificacao"
        Me.btnConfigurarGridClassificacao.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridClassificacao.TabIndex = 3
        Me.btnConfigurarGridClassificacao.TabStop = False
        Me.btnConfigurarGridClassificacao.UseVisualStyleBackColor = False
        '
        'grpClassificao
        '
        Me.grpClassificao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpClassificao.BackColor = System.Drawing.Color.Transparent
        Me.grpClassificao.Controls.Add(Me.btnProcurarCentroCusto)
        Me.grpClassificao.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpClassificao.Controls.Add(Me.txtValorClassificacao)
        Me.grpClassificao.Controls.Add(Me.lblValorClassificacao)
        Me.grpClassificao.Controls.Add(Me.lblContaContabil)
        Me.grpClassificao.Controls.Add(Me.cboContaContabil)
        Me.grpClassificao.Controls.Add(Me.lblCentroGasto)
        Me.grpClassificao.Controls.Add(Me.cboCentroGasto)
        Me.grpClassificao.Controls.Add(Me.btnExcluirClassificacao)
        Me.grpClassificao.Controls.Add(Me.btnInserirClassificao)
        Me.grpClassificao.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpClassificao.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpClassificao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpClassificao.Location = New System.Drawing.Point(8, 3)
        Me.grpClassificao.Name = "grpClassificao"
        Me.grpClassificao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpClassificao.Size = New System.Drawing.Size(879, 67)
        Me.grpClassificao.TabIndex = 0
        Me.grpClassificao.Text = "Dados da Classificação"
        Me.grpClassificao.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCentroCusto
        '
        Me.btnProcurarCentroCusto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroCusto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroCusto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroCusto.Location = New System.Drawing.Point(272, 19)
        Me.btnProcurarCentroCusto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroCusto.Name = "btnProcurarCentroCusto"
        Me.btnProcurarCentroCusto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroCusto.TabIndex = 13
        Me.btnProcurarCentroCusto.TabStop = False
        Me.btnProcurarCentroCusto.UseVisualStyleBackColor = True
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(555, 19)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 12
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'txtValorClassificacao
        '
        Me.txtValorClassificacao.DecimalDigits = 2
        Me.txtValorClassificacao.Location = New System.Drawing.Point(578, 37)
        Me.txtValorClassificacao.MaxLength = 0
        Me.txtValorClassificacao.Name = "txtValorClassificacao"
        Me.txtValorClassificacao.Size = New System.Drawing.Size(90, 20)
        Me.txtValorClassificacao.TabIndex = 7
        Me.txtValorClassificacao.Text = "0,00"
        Me.txtValorClassificacao.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorClassificacao
        '
        Me.lblValorClassificacao.AutoSize = True
        Me.lblValorClassificacao.Location = New System.Drawing.Point(575, 20)
        Me.lblValorClassificacao.Name = "lblValorClassificacao"
        Me.lblValorClassificacao.Size = New System.Drawing.Size(35, 14)
        Me.lblValorClassificacao.TabIndex = 6
        Me.lblValorClassificacao.Text = "Valor:"
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(311, 20)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 4
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(295, 37)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(277, 20)
        Me.cboContaContabil.TabIndex = 5
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(25, 20)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 1
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(9, 37)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(280, 20)
        Me.cboCentroGasto.TabIndex = 2
        '
        'btnExcluirClassificacao
        '
        Me.btnExcluirClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirClassificacao.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirClassificacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirClassificacao.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirClassificacao.Location = New System.Drawing.Point(779, 34)
        Me.btnExcluirClassificacao.Name = "btnExcluirClassificacao"
        Me.btnExcluirClassificacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirClassificacao.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirClassificacao.TabIndex = 9
        Me.btnExcluirClassificacao.Text = "Excluir"
        Me.btnExcluirClassificacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirClassificao
        '
        Me.btnInserirClassificao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirClassificao.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirClassificao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirClassificao.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirClassificao.Location = New System.Drawing.Point(682, 34)
        Me.btnInserirClassificao.Name = "btnInserirClassificao"
        Me.btnInserirClassificao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirClassificao.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirClassificao.TabIndex = 8
        Me.btnInserirClassificao.Text = "Inserir"
        Me.btnInserirClassificao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(295, 21)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 3
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 0
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'grdClassificacao
        '
        Me.grdClassificacao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdClassificacao.AlternatingColors = True
        Me.grdClassificacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClassificacao.ColumnAutoResize = True
        grdClassificacao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdClassificacao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdClassificacao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdClassificacao_DesignTimeLayout_Reference_0})
        grdClassificacao_DesignTimeLayout.LayoutString = resources.GetString("grdClassificacao_DesignTimeLayout.LayoutString")
        Me.grdClassificacao.DesignTimeLayout = grdClassificacao_DesignTimeLayout
        Me.grdClassificacao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdClassificacao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdClassificacao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdClassificacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdClassificacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdClassificacao.GroupByBoxVisible = False
        Me.grdClassificacao.Location = New System.Drawing.Point(8, 79)
        Me.grdClassificacao.Name = "grdClassificacao"
        Me.grdClassificacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdClassificacao.RecordNavigator = True
        Me.grdClassificacao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdClassificacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdClassificacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdClassificacao.Size = New System.Drawing.Size(879, 296)
        Me.grdClassificacao.TabIndex = 1
        Me.grdClassificacao.TabStop = False
        Me.grdClassificacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdClassificacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdClassificacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdClassificacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdClassificacao.VisualStyleManager = Me.vsmMain
        '
        'pagArquivos
        '
        Me.pagArquivos.Controls.Add(Me.btnExcelGridArquivo)
        Me.pagArquivos.Controls.Add(Me.btnAgruparGridArquivo)
        Me.pagArquivos.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagArquivos.Controls.Add(Me.grpArquivo)
        Me.pagArquivos.Controls.Add(Me.grdArquivo)
        Me.pagArquivos.Key = "pagArquivos"
        Me.pagArquivos.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivos.Name = "pagArquivos"
        Me.pagArquivos.Size = New System.Drawing.Size(895, 384)
        Me.pagArquivos.TabStop = True
        Me.pagArquivos.Text = "Arquivos"
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = CType(resources.GetObject("btnExcelGridArquivo.Image"), System.Drawing.Image)
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 35
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 34
        Me.btnAgruparGridArquivo.TabStop = False
        Me.btnAgruparGridArquivo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridArquivo
        '
        Me.btnConfigurarGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridArquivo.Image = CType(resources.GetObject("btnConfigurarGridArquivo.Image"), System.Drawing.Image)
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 33
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.lblRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.txtRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.cboTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.txtDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnCadastrarTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(879, 104)
        Me.grpArquivo.TabIndex = 31
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'lblRevisaoArquivo
        '
        Me.lblRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevisaoArquivo.AutoSize = True
        Me.lblRevisaoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRevisaoArquivo.Location = New System.Drawing.Point(575, 17)
        Me.lblRevisaoArquivo.Name = "lblRevisaoArquivo"
        Me.lblRevisaoArquivo.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoArquivo.TabIndex = 2
        Me.lblRevisaoArquivo.Text = "Revisão:"
        '
        'txtRevisaoArquivo
        '
        Me.txtRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRevisaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisaoArquivo.Location = New System.Drawing.Point(578, 34)
        Me.txtRevisaoArquivo.MaxLength = 5
        Me.txtRevisaoArquivo.Name = "txtRevisaoArquivo"
        Me.txtRevisaoArquivo.Size = New System.Drawing.Size(89, 20)
        Me.txtRevisaoArquivo.TabIndex = 3
        '
        'lblTipoArquivo
        '
        Me.lblTipoArquivo.AutoSize = True
        Me.lblTipoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoArquivo.Location = New System.Drawing.Point(25, 57)
        Me.lblTipoArquivo.Name = "lblTipoArquivo"
        Me.lblTipoArquivo.Size = New System.Drawing.Size(85, 14)
        Me.lblTipoArquivo.TabIndex = 5
        Me.lblTipoArquivo.Text = "Tipo do Arquivo:"
        '
        'cboTipoArquivo
        '
        Me.cboTipoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoArquivo.Location = New System.Drawing.Point(9, 74)
        Me.cboTipoArquivo.Name = "cboTipoArquivo"
        Me.cboTipoArquivo.Size = New System.Drawing.Size(240, 20)
        Me.cboTipoArquivo.TabIndex = 6
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(647, 74)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 9
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArquivo.Location = New System.Drawing.Point(252, 57)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 7
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(255, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(393, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
        '
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(563, 20)
        Me.txtDescricaoArquivo.TabIndex = 1
        '
        'lblDescricaoArquivo
        '
        Me.lblDescricaoArquivo.AutoSize = True
        Me.lblDescricaoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoArquivo.Name = "lblDescricaoArquivo"
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoArquivo.TabIndex = 0
        Me.lblDescricaoArquivo.Text = "Descrição:"
        '
        'btnCadastrarTipoArquivo
        '
        Me.btnCadastrarTipoArquivo.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoArquivo.Image = CType(resources.GetObject("btnCadastrarTipoArquivo.Image"), System.Drawing.Image)
        Me.btnCadastrarTipoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoArquivo.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarTipoArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoArquivo.Name = "btnCadastrarTipoArquivo"
        Me.btnCadastrarTipoArquivo.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoArquivo.TabIndex = 4
        Me.btnCadastrarTipoArquivo.TabStop = False
        Me.btnCadastrarTipoArquivo.UseVisualStyleBackColor = True
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirArquivo.Name = "btnExcluirArquivo"
        Me.btnExcluirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivo.TabIndex = 11
        Me.btnExcluirArquivo.Text = "Excluir"
        Me.btnExcluirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirArquivo
        '
        Me.btnInserirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirArquivo.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirArquivo.Name = "btnInserirArquivo"
        Me.btnInserirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirArquivo.TabIndex = 10
        Me.btnInserirArquivo.Text = "Inserir"
        Me.btnInserirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdArquivo
        '
        Me.grdArquivo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdArquivo.AlternatingColors = True
        Me.grdArquivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArquivo.ColumnAutoResize = True
        grdArquivo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdArquivo_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_1.Instance"), Object)
        grdArquivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivo_DesignTimeLayout_Reference_0, grdArquivo_DesignTimeLayout_Reference_1})
        grdArquivo_DesignTimeLayout.LayoutString = resources.GetString("grdArquivo_DesignTimeLayout.LayoutString")
        Me.grdArquivo.DesignTimeLayout = grdArquivo_DesignTimeLayout
        Me.grdArquivo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdArquivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivo.FrozenColumns = 3
        Me.grdArquivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivo.GroupByBoxVisible = False
        Me.grdArquivo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdArquivo.Location = New System.Drawing.Point(8, 116)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 259)
        Me.grdArquivo.TabIndex = 32
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 2000
        Me.jstTip.ImageList = Nothing
        '
        'txtDescritivo1
        '
        Me.txtDescritivo1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescritivo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivo1.Location = New System.Drawing.Point(9, 37)
        Me.txtDescritivo1.MaxLength = 500
        Me.txtDescritivo1.Multiline = True
        Me.txtDescritivo1.Name = "txtDescritivo1"
        Me.txtDescritivo1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescritivo1.Size = New System.Drawing.Size(601, 214)
        Me.txtDescritivo1.TabIndex = 1
        '
        'usrFinDespesaAdiantamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinDespesaAdiantamento"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picTituloAberto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloParcialmenteQuitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDespesa.ResumeLayout(False)
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPagamento.ResumeLayout(False)
        Me.grpPagamento.PerformLayout()
        CType(Me.grpBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoleto.ResumeLayout(False)
        Me.grpBoleto.PerformLayout()
        CType(Me.grpCartaoCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCartaoCredito.ResumeLayout(False)
        Me.grpCartaoCredito.PerformLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChequeTerceiro.ResumeLayout(False)
        Me.grpChequeTerceiro.PerformLayout()
        CType(Me.grpOutros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutros.ResumeLayout(False)
        Me.grpOutros.PerformLayout()
        CType(Me.grpOutrosSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutrosSimples.ResumeLayout(False)
        Me.grpOutrosSimples.PerformLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCheque.ResumeLayout(False)
        Me.grpCheque.PerformLayout()
        CType(Me.grpSaldoFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSaldoFornecedor.ResumeLayout(False)
        Me.grpSaldoFornecedor.PerformLayout()
        CType(Me.grpBoletoGuia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoletoGuia.ResumeLayout(False)
        Me.grpBoletoGuia.PerformLayout()
        Me.pagClassificacao.ResumeLayout(False)
        CType(Me.grpClassificao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClassificao.ResumeLayout(False)
        Me.grpClassificao.PerformLayout()
        CType(Me.grdClassificacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagArquivos.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDespesa As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoTituloFinanceiroFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoTituloFinanceiroFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picTituloParcialmenteQuitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloParcialmenteQuitado As System.Windows.Forms.Label
    Friend WithEvents lblTituloAberto As System.Windows.Forms.Label
    Friend WithEvents picTituloAberto As System.Windows.Forms.PictureBox
    Friend WithEvents picTituloQuitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloCancelado As System.Windows.Forms.Label
    Friend WithEvents picTituloCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloQuitado As System.Windows.Forms.Label
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Private WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarFornecedor As System.Windows.Forms.Button
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAtivar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagClassificacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpClassificao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdClassificacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtValorClassificacao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorClassificacao As System.Windows.Forms.Label
    Friend WithEvents btnExcluirClassificacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirClassificao As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnConfigurarGridClassificacao As System.Windows.Forms.Button
    Friend WithEvents dtpDataPagamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPagamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtValorFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFiltro As System.Windows.Forms.Label
    Friend WithEvents btnProcurarFornecedorFiltro As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridClassificacao As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridClassificacao As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCentroCusto As System.Windows.Forms.Button
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents lblContaBancariaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboContaBancariaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescritivoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescritivoFiltro As System.Windows.Forms.Label
    Friend WithEvents pagArquivos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelGridArquivo As Button
    Friend WithEvents btnAgruparGridArquivo As Button
    Friend WithEvents btnConfigurarGridArquivo As Button
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRevisaoArquivo As Label
    Friend WithEvents txtRevisaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoArquivo As Label
    Friend WithEvents cboTipoArquivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As Label
    Friend WithEvents btnCadastrarTipoArquivo As Button
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpPagamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpSaldoFornecedor As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoSaldoFornecedor As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorSaldoFornecedor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorSaldoFornecedor As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoSaldoFornecedor As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarContaBancaria As System.Windows.Forms.Button
    Friend WithEvents lblTipoDocumentoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents grpBoletoGuia As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroBoletoGuia8 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia7 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia6 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia5 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia4 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia3 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataPagamentoBoletoGuia As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorBoletoGuia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroBoletoGuia2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblValorBoletoGuia As System.Windows.Forms.Label
    Friend WithEvents lblBancoBoletoGuia As System.Windows.Forms.Label
    Friend WithEvents grpBoleto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoBoleto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorBoleto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBancoBoleto As System.Windows.Forms.Label
    Friend WithEvents txtBancoBoleto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataPagamentoBoleto As System.Windows.Forms.Label
    Friend WithEvents txtNumeroBoleto8 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto7 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto6 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto5 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto4 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto3 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblValorBoleto As System.Windows.Forms.Label
    Friend WithEvents txtNumeroBoleto1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpCartaoCredito As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarCartaoCredito As System.Windows.Forms.Button
    Friend WithEvents txtValorCartaoCredito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents lblNumeroParcelaCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents cboCartaoCredito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcelaCartaoCredito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpDataPagamentoCartaoCredito As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grpChequeTerceiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoChequeTerceiro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorChequeTerceiro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtPreDatadoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPreDatadoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents cboNumeroDocumentoChequeTerceiro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroDocumentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtDataRecebimentoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataRecebimentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtContaChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblContaChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtAgenciaChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAgenciaChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtBancoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBancoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents grpOutros As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoOutros As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorOutros As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOutros As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoOutros As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoOutros As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoOutros As System.Windows.Forms.Label
    Friend WithEvents grpOutrosSimples As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoOutrosSimples As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorOutrosSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOutrosSimples As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoOutrosSimples As System.Windows.Forms.Label
    Friend WithEvents grpCheque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataCompensacaoCheque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoCheque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCompensacaoCheque As System.Windows.Forms.Label
    Friend WithEvents txtValorCheque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCheque As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoCheque As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoCheque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoCheque As System.Windows.Forms.Label
    Friend WithEvents lblPreDatadoCheque As System.Windows.Forms.Label
    Friend WithEvents cboPreDatadoCheque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtFavorecidoCheque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFavorecidoCheque As System.Windows.Forms.Label
    Friend WithEvents txtDescritivo1 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescritivo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescritivo As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataVencimento As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroBoletoGuia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPedidoCompra As Label
    Friend WithEvents cboPedidoCompra As Janus.Windows.EditControls.UIComboBox
End Class
