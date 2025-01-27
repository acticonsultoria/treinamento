<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinDespesaLancamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinDespesaLancamento))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column0.Image")
        Dim grdListagem_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column3.Image")
        Dim grdDuplicata_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim grdClassificacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdClassificacao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdNotaFiscalEntrada_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdNotaFiscalEntrada_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
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
        Me.dtpDataInputTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInputInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInputFiltro = New System.Windows.Forms.Label()
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
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDespesa = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEmissao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblTipoTituloFinanceiro = New System.Windows.Forms.Label()
        Me.cboTipoTituloFinanceiro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
        Me.btnCadastrarFornecedor = New System.Windows.Forms.Button()
        Me.btnCadastrarTipoDocumento = New System.Windows.Forms.Button()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportarContaRateavel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpTituloPrevisto = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVincular = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataVencimentoPrevisto = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumDocumentoPrevisto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTituloPrevisto = New System.Windows.Forms.Label()
        Me.txtValorPrevisto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboTituloPrevisto = New Janus.Windows.EditControls.UIComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpDuplicata = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarCondicaoPagamento = New System.Windows.Forms.Button()
        Me.lblCondicaoPagamento = New System.Windows.Forms.Label()
        Me.cboCondicaoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCalcularDuplicata = New Janus.Windows.EditControls.UIButton()
        Me.txtIntervaloParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIntervaloParcela = New System.Windows.Forms.Label()
        Me.txtNumeroParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroParcela = New System.Windows.Forms.Label()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.cboFormaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.grdDuplicata = New Janus.Windows.GridEX.GridEX()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizarDescritivo = New System.Windows.Forms.Button()
        Me.txtDescontoValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoValor = New System.Windows.Forms.Label()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtDescontoPercentual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoPercentual = New System.Windows.Forms.Label()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtDescritivo = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescritivo = New System.Windows.Forms.Label()
        Me.grpCobranca = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFatorCambial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFatorCambial = New System.Windows.Forms.Label()
        Me.lblDescontoPagamento = New System.Windows.Forms.Label()
        Me.lblJurosPagamento = New System.Windows.Forms.Label()
        Me.txtDescontoPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtJurosPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMultaPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMultaPagamento = New System.Windows.Forms.Label()
        Me.lblMoeda = New System.Windows.Forms.Label()
        Me.cboMoeda = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarMoeda = New System.Windows.Forms.Button()
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
        Me.pagNotaFiscalEntrada = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridNotaFiscalEntrada = New System.Windows.Forms.Button()
        Me.btnAgruparGridNotaFiscalEntrada = New System.Windows.Forms.Button()
        Me.btnConfigurarGridNotaFiscalEntrada = New System.Windows.Forms.Button()
        Me.grpNotaFiscalEntrada = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDataEmissaoNotaFiscalEntrada = New System.Windows.Forms.Label()
        Me.txtDataEmissaoNotaFiscalEntrada = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedorNotaFiscalEntrada = New System.Windows.Forms.Label()
        Me.txtFornecedorNotaFiscalEntrada = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieNotaFiscalEntrada = New System.Windows.Forms.Label()
        Me.txtSerieNotaFiscalEntrada = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtValorNotaFiscalEntrada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorNotaFiscalEntrada = New System.Windows.Forms.Label()
        Me.lblNotaFiscalEntrada = New System.Windows.Forms.Label()
        Me.cboNotaFiscalEntrada = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcluirNotaFiscalEntrada = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirNotaFiscalEntrada = New Janus.Windows.EditControls.UIButton()
        Me.grdNotaFiscalEntrada = New Janus.Windows.GridEX.GridEX()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
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
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDespesa.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpTituloPrevisto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTituloPrevisto.SuspendLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDuplicata.SuspendLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpCobranca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCobranca.SuspendLayout()
        Me.pagClassificacao.SuspendLayout()
        CType(Me.grpClassificao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClassificao.SuspendLayout()
        CType(Me.grdClassificacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagNotaFiscalEntrada.SuspendLayout()
        CType(Me.grpNotaFiscalEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNotaFiscalEntrada.SuspendLayout()
        CType(Me.grdNotaFiscalEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Despesa"
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
        Me.picTituloAberto.BackColor = System.Drawing.Color.DarkGray
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
        Me.grpFiltro.Controls.Add(Me.dtpDataInputTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInputInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataInputFiltro)
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
        'dtpDataInputTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataInputTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInputTerminoFiltro.Location = New System.Drawing.Point(685, 114)
        Me.dtpDataInputTerminoFiltro.Name = "dtpDataInputTerminoFiltro"
        Me.dtpDataInputTerminoFiltro.ShowCheckBox = True
        Me.dtpDataInputTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataInputTerminoFiltro.TabIndex = 27
        '
        'dtpDataInputInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInputInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInputInicioFiltro.Location = New System.Drawing.Point(580, 114)
        Me.dtpDataInputInicioFiltro.Name = "dtpDataInputInicioFiltro"
        Me.dtpDataInputInicioFiltro.ShowCheckBox = True
        Me.dtpDataInputInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataInputInicioFiltro.TabIndex = 26
        '
        'lblDataInputFiltro
        '
        Me.lblDataInputFiltro.AutoSize = True
        Me.lblDataInputFiltro.Location = New System.Drawing.Point(577, 97)
        Me.lblDataInputFiltro.Name = "lblDataInputFiltro"
        Me.lblDataInputFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblDataInputFiltro.TabIndex = 25
        Me.lblDataInputFiltro.Text = "Data Input:"
        '
        'txtDescritivoFiltro
        '
        Me.txtDescritivoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivoFiltro.Location = New System.Drawing.Point(265, 114)
        Me.txtDescritivoFiltro.MaxLength = 60
        Me.txtDescritivoFiltro.Name = "txtDescritivoFiltro"
        Me.txtDescritivoFiltro.Size = New System.Drawing.Size(309, 20)
        Me.txtDescritivoFiltro.TabIndex = 24
        '
        'lblDescritivoFiltro
        '
        Me.lblDescritivoFiltro.AutoSize = True
        Me.lblDescritivoFiltro.Location = New System.Drawing.Point(262, 97)
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
        Me.cboContaBancariaFiltro.Size = New System.Drawing.Size(250, 20)
        Me.cboContaBancariaFiltro.TabIndex = 22
        '
        'btnProcurarFornecedorFiltro
        '
        Me.btnProcurarFornecedorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txtValorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.lblValorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(160, 34)
        Me.txtFornecedorFiltro.MaxLength = 60
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(414, 20)
        Me.txtFornecedorFiltro.TabIndex = 5
        '
        'lblTipoTituloFinanceiroFiltro
        '
        Me.lblTipoTituloFinanceiroFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoTituloFinanceiroFiltro.AutoSize = True
        Me.lblTipoTituloFinanceiroFiltro.Location = New System.Drawing.Point(577, 17)
        Me.lblTipoTituloFinanceiroFiltro.Name = "lblTipoTituloFinanceiroFiltro"
        Me.lblTipoTituloFinanceiroFiltro.Size = New System.Drawing.Size(73, 14)
        Me.lblTipoTituloFinanceiroFiltro.TabIndex = 6
        Me.lblTipoTituloFinanceiroFiltro.Text = "Tipo do Título:"
        '
        'cboTipoTituloFinanceiroFiltro
        '
        Me.cboTipoTituloFinanceiroFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnFiltrar.TabIndex = 28
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
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3, grdListagem_DesignTimeLayout_Reference_4, grdListagem_DesignTimeLayout_Reference_5, grdListagem_DesignTimeLayout_Reference_6})
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
        Me.grpInformacoes.Controls.Add(Me.dtpDataEmissao)
        Me.grpInformacoes.Controls.Add(Me.lblTipoTituloFinanceiro)
        Me.grpInformacoes.Controls.Add(Me.cboTipoTituloFinanceiro)
        Me.grpInformacoes.Controls.Add(Me.lblDataEmissao)
        Me.grpInformacoes.Controls.Add(Me.lblTipoDocumento)
        Me.grpInformacoes.Controls.Add(Me.txtSerie)
        Me.grpInformacoes.Controls.Add(Me.lblSerie)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.cboTipoDocumento)
        Me.grpInformacoes.Controls.Add(Me.cboFornecedor)
        Me.grpInformacoes.Controls.Add(Me.lblFornecedor)
        Me.grpInformacoes.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpInformacoes.Controls.Add(Me.btnCadastrarFornecedor)
        Me.grpInformacoes.Controls.Add(Me.btnCadastrarTipoDocumento)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(897, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
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
        '
        'lblTipoTituloFinanceiro
        '
        Me.lblTipoTituloFinanceiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoTituloFinanceiro.AutoSize = True
        Me.lblTipoTituloFinanceiro.Location = New System.Drawing.Point(795, 17)
        Me.lblTipoTituloFinanceiro.Name = "lblTipoTituloFinanceiro"
        Me.lblTipoTituloFinanceiro.Size = New System.Drawing.Size(73, 14)
        Me.lblTipoTituloFinanceiro.TabIndex = 13
        Me.lblTipoTituloFinanceiro.Text = "Tipo do Título:"
        '
        'cboTipoTituloFinanceiro
        '
        Me.cboTipoTituloFinanceiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoTituloFinanceiro.AutoSize = False
        Me.cboTipoTituloFinanceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoTituloFinanceiro.Location = New System.Drawing.Point(798, 34)
        Me.cboTipoTituloFinanceiro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoTituloFinanceiro.Name = "cboTipoTituloFinanceiro"
        Me.cboTipoTituloFinanceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoTituloFinanceiro.Size = New System.Drawing.Size(90, 20)
        Me.cboTipoTituloFinanceiro.TabIndex = 14
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
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(272, 17)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(102, 14)
        Me.lblTipoDocumento.TabIndex = 7
        Me.lblTipoDocumento.Text = "Tipo de Documento:"
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
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoSize = False
        Me.cboTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumento.Location = New System.Drawing.Point(256, 34)
        Me.cboTipoDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumento.Size = New System.Drawing.Size(149, 20)
        Me.cboTipoDocumento.TabIndex = 8
        '
        'cboFornecedor
        '
        Me.cboFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedor.AutoSize = False
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedor.Location = New System.Drawing.Point(411, 34)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedor.Size = New System.Drawing.Size(381, 20)
        Me.cboFornecedor.TabIndex = 12
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(427, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 10
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'btnProcurarFornecedor
        '
        Me.btnProcurarFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(775, 16)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedor.TabIndex = 11
        Me.btnProcurarFornecedor.TabStop = False
        Me.btnProcurarFornecedor.UseVisualStyleBackColor = True
        '
        'btnCadastrarFornecedor
        '
        Me.btnCadastrarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarFornecedor.Location = New System.Drawing.Point(411, 18)
        Me.btnCadastrarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor"
        Me.btnCadastrarFornecedor.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarFornecedor.TabIndex = 9
        Me.btnCadastrarFornecedor.TabStop = False
        Me.btnCadastrarFornecedor.UseVisualStyleBackColor = True
        '
        'btnCadastrarTipoDocumento
        '
        Me.btnCadastrarTipoDocumento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoDocumento.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarTipoDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoDocumento.Location = New System.Drawing.Point(256, 18)
        Me.btnCadastrarTipoDocumento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoDocumento.Name = "btnCadastrarTipoDocumento"
        Me.btnCadastrarTipoDocumento.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoDocumento.TabIndex = 6
        Me.btnCadastrarTipoDocumento.TabStop = False
        Me.btnCadastrarTipoDocumento.UseVisualStyleBackColor = True
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnImportarContaRateavel)
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
        'btnImportarContaRateavel
        '
        Me.btnImportarContaRateavel.Image = Global.INTERACTI.My.Resources.Resources.upload
        Me.btnImportarContaRateavel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarContaRateavel.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnImportarContaRateavel.Location = New System.Drawing.Point(6, 17)
        Me.btnImportarContaRateavel.Name = "btnImportarContaRateavel"
        Me.btnImportarContaRateavel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarContaRateavel.Size = New System.Drawing.Size(164, 23)
        Me.btnImportarContaRateavel.TabIndex = 9
        Me.btnImportarContaRateavel.Text = "Importar Conta Rateável"
        Me.btnImportarContaRateavel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados, Me.pagClassificacao, Me.pagNotaFiscalEntrada})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpTituloPrevisto)
        Me.pagDados.Controls.Add(Me.grpDuplicata)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpCobranca)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(895, 384)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados Gerais"
        '
        'grpTituloPrevisto
        '
        Me.grpTituloPrevisto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTituloPrevisto.BackColor = System.Drawing.Color.Transparent
        Me.grpTituloPrevisto.Controls.Add(Me.btnVincular)
        Me.grpTituloPrevisto.Controls.Add(Me.dtpDataVencimentoPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.txtNumDocumentoPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.lblTituloPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.txtValorPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.cboTituloPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.Label1)
        Me.grpTituloPrevisto.Controls.Add(Me.Label3)
        Me.grpTituloPrevisto.Controls.Add(Me.Label4)
        Me.grpTituloPrevisto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpTituloPrevisto.Location = New System.Drawing.Point(8, 272)
        Me.grpTituloPrevisto.Name = "grpTituloPrevisto"
        Me.grpTituloPrevisto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTituloPrevisto.Size = New System.Drawing.Size(619, 103)
        Me.grpTituloPrevisto.TabIndex = 10
        Me.grpTituloPrevisto.Text = "Dados do Título Previsto"
        Me.grpTituloPrevisto.VisualStyleManager = Me.vsmMain
        '
        'btnVincular
        '
        Me.btnVincular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVincular.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnVincular.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVincular.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnVincular.Location = New System.Drawing.Point(465, 48)
        Me.btnVincular.Name = "btnVincular"
        Me.btnVincular.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVincular.Size = New System.Drawing.Size(148, 23)
        Me.btnVincular.TabIndex = 3
        Me.btnVincular.Text = "Vincular Título - Previsão"
        Me.btnVincular.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataVencimentoPrevisto
        '
        Me.dtpDataVencimentoPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpDataVencimentoPrevisto.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.dtpDataVencimentoPrevisto.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoPrevisto.Location = New System.Drawing.Point(246, 74)
        Me.dtpDataVencimentoPrevisto.Name = "dtpDataVencimentoPrevisto"
        Me.dtpDataVencimentoPrevisto.ReadOnly = True
        Me.dtpDataVencimentoPrevisto.Size = New System.Drawing.Size(118, 20)
        Me.dtpDataVencimentoPrevisto.TabIndex = 14
        '
        'txtNumDocumentoPrevisto
        '
        Me.txtNumDocumentoPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumDocumentoPrevisto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumDocumentoPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumDocumentoPrevisto.Location = New System.Drawing.Point(12, 74)
        Me.txtNumDocumentoPrevisto.MaxLength = 60
        Me.txtNumDocumentoPrevisto.Name = "txtNumDocumentoPrevisto"
        Me.txtNumDocumentoPrevisto.ReadOnly = True
        Me.txtNumDocumentoPrevisto.Size = New System.Drawing.Size(117, 20)
        Me.txtNumDocumentoPrevisto.TabIndex = 13
        Me.txtNumDocumentoPrevisto.TabStop = False
        '
        'lblTituloPrevisto
        '
        Me.lblTituloPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTituloPrevisto.AutoSize = True
        Me.lblTituloPrevisto.Location = New System.Drawing.Point(9, 16)
        Me.lblTituloPrevisto.Name = "lblTituloPrevisto"
        Me.lblTituloPrevisto.Size = New System.Drawing.Size(77, 14)
        Me.lblTituloPrevisto.TabIndex = 11
        Me.lblTituloPrevisto.Text = "Título Previsto:"
        '
        'txtValorPrevisto
        '
        Me.txtValorPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtValorPrevisto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPrevisto.DecimalDigits = 2
        Me.txtValorPrevisto.Location = New System.Drawing.Point(135, 74)
        Me.txtValorPrevisto.MaxLength = 0
        Me.txtValorPrevisto.Name = "txtValorPrevisto"
        Me.txtValorPrevisto.ReadOnly = True
        Me.txtValorPrevisto.Size = New System.Drawing.Size(105, 20)
        Me.txtValorPrevisto.TabIndex = 5
        Me.txtValorPrevisto.Text = "0,00"
        Me.txtValorPrevisto.Value = 0.0R
        Me.txtValorPrevisto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'cboTituloPrevisto
        '
        Me.cboTituloPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboTituloPrevisto.AutoSize = False
        Me.cboTituloPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTituloPrevisto.Location = New System.Drawing.Point(12, 33)
        Me.cboTituloPrevisto.Name = "cboTituloPrevisto"
        Me.cboTituloPrevisto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTituloPrevisto.Size = New System.Drawing.Size(352, 20)
        Me.cboTituloPrevisto.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Valor:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Data Vencimento:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Num. Documento:"
        '
        'grpDuplicata
        '
        Me.grpDuplicata.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDuplicata.BackColor = System.Drawing.Color.Transparent
        Me.grpDuplicata.Controls.Add(Me.btnCadastrarCondicaoPagamento)
        Me.grpDuplicata.Controls.Add(Me.lblCondicaoPagamento)
        Me.grpDuplicata.Controls.Add(Me.cboCondicaoPagamento)
        Me.grpDuplicata.Controls.Add(Me.btnCalcularDuplicata)
        Me.grpDuplicata.Controls.Add(Me.txtIntervaloParcela)
        Me.grpDuplicata.Controls.Add(Me.lblIntervaloParcela)
        Me.grpDuplicata.Controls.Add(Me.txtNumeroParcela)
        Me.grpDuplicata.Controls.Add(Me.lblNumeroParcela)
        Me.grpDuplicata.Controls.Add(Me.lblFormaPagamento)
        Me.grpDuplicata.Controls.Add(Me.cboFormaPagamento)
        Me.grpDuplicata.Controls.Add(Me.grdDuplicata)
        Me.grpDuplicata.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDuplicata.Location = New System.Drawing.Point(636, 3)
        Me.grpDuplicata.Name = "grpDuplicata"
        Me.grpDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDuplicata.Size = New System.Drawing.Size(251, 372)
        Me.grpDuplicata.TabIndex = 2
        Me.grpDuplicata.Text = "Duplicata"
        Me.grpDuplicata.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDuplicata.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarCondicaoPagamento
        '
        Me.btnCadastrarCondicaoPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarCondicaoPagamento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCondicaoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCondicaoPagamento.Image = CType(resources.GetObject("btnCadastrarCondicaoPagamento.Image"), System.Drawing.Image)
        Me.btnCadastrarCondicaoPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCondicaoPagamento.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarCondicaoPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCondicaoPagamento.Name = "btnCadastrarCondicaoPagamento"
        Me.btnCadastrarCondicaoPagamento.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCondicaoPagamento.TabIndex = 24
        Me.btnCadastrarCondicaoPagamento.TabStop = False
        Me.btnCadastrarCondicaoPagamento.UseVisualStyleBackColor = True
        '
        'lblCondicaoPagamento
        '
        Me.lblCondicaoPagamento.AutoSize = True
        Me.lblCondicaoPagamento.Location = New System.Drawing.Point(29, 57)
        Me.lblCondicaoPagamento.Name = "lblCondicaoPagamento"
        Me.lblCondicaoPagamento.Size = New System.Drawing.Size(126, 14)
        Me.lblCondicaoPagamento.TabIndex = 8
        Me.lblCondicaoPagamento.Text = "Condição de Pagamento:"
        '
        'cboCondicaoPagamento
        '
        Me.cboCondicaoPagamento.AutoSize = False
        Me.cboCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCondicaoPagamento.Location = New System.Drawing.Point(9, 74)
        Me.cboCondicaoPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCondicaoPagamento.Name = "cboCondicaoPagamento"
        Me.cboCondicaoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCondicaoPagamento.Size = New System.Drawing.Size(233, 20)
        Me.cboCondicaoPagamento.TabIndex = 1
        '
        'btnCalcularDuplicata
        '
        Me.btnCalcularDuplicata.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularDuplicata.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCalcularDuplicata.Location = New System.Drawing.Point(151, 151)
        Me.btnCalcularDuplicata.Name = "btnCalcularDuplicata"
        Me.btnCalcularDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCalcularDuplicata.Size = New System.Drawing.Size(91, 23)
        Me.btnCalcularDuplicata.TabIndex = 4
        Me.btnCalcularDuplicata.Text = "Calcular"
        Me.btnCalcularDuplicata.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtIntervaloParcela
        '
        Me.txtIntervaloParcela.DecimalDigits = 0
        Me.txtIntervaloParcela.Location = New System.Drawing.Point(9, 154)
        Me.txtIntervaloParcela.Name = "txtIntervaloParcela"
        Me.txtIntervaloParcela.Size = New System.Drawing.Size(108, 20)
        Me.txtIntervaloParcela.TabIndex = 3
        Me.txtIntervaloParcela.Text = "0"
        Me.txtIntervaloParcela.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblIntervaloParcela
        '
        Me.lblIntervaloParcela.AutoSize = True
        Me.lblIntervaloParcela.Location = New System.Drawing.Point(6, 137)
        Me.lblIntervaloParcela.Name = "lblIntervaloParcela"
        Me.lblIntervaloParcela.Size = New System.Drawing.Size(97, 14)
        Me.lblIntervaloParcela.TabIndex = 4
        Me.lblIntervaloParcela.Text = "Int. entre Parcelas:"
        '
        'txtNumeroParcela
        '
        Me.txtNumeroParcela.DecimalDigits = 0
        Me.txtNumeroParcela.Location = New System.Drawing.Point(9, 114)
        Me.txtNumeroParcela.Name = "txtNumeroParcela"
        Me.txtNumeroParcela.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroParcela.TabIndex = 2
        Me.txtNumeroParcela.Text = "0"
        Me.txtNumeroParcela.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroParcela
        '
        Me.lblNumeroParcela.AutoSize = True
        Me.lblNumeroParcela.Location = New System.Drawing.Point(6, 97)
        Me.lblNumeroParcela.Name = "lblNumeroParcela"
        Me.lblNumeroParcela.Size = New System.Drawing.Size(67, 14)
        Me.lblNumeroParcela.TabIndex = 2
        Me.lblNumeroParcela.Text = "Nº Parcelas:"
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(6, 17)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblFormaPagamento.TabIndex = 0
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.AutoSize = False
        Me.cboFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaPagamento.Location = New System.Drawing.Point(9, 34)
        Me.cboFormaPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaPagamento.Size = New System.Drawing.Size(233, 20)
        Me.cboFormaPagamento.TabIndex = 0
        '
        'grdDuplicata
        '
        Me.grdDuplicata.AlternatingColors = True
        Me.grdDuplicata.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdDuplicata.CellToolTipText = "Duplo Clique para editar o Registro"
        grdDuplicata_DesignTimeLayout.LayoutString = resources.GetString("grdDuplicata_DesignTimeLayout.LayoutString")
        Me.grdDuplicata.DesignTimeLayout = grdDuplicata_DesignTimeLayout
        Me.grdDuplicata.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDuplicata.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDuplicata.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDuplicata.GroupByBoxVisible = False
        Me.grdDuplicata.Location = New System.Drawing.Point(9, 180)
        Me.grdDuplicata.Name = "grdDuplicata"
        Me.grdDuplicata.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDuplicata.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDuplicata.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDuplicata.Size = New System.Drawing.Size(233, 182)
        Me.grdDuplicata.TabIndex = 7
        Me.grdDuplicata.TabStop = False
        Me.grdDuplicata.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDuplicata.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdDuplicata.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDuplicata.VisualStyleManager = Me.vsmMain
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnAtualizarDescritivo)
        Me.grpDados.Controls.Add(Me.txtDescontoValor)
        Me.grpDados.Controls.Add(Me.lblDescontoValor)
        Me.grpDados.Controls.Add(Me.txtValorTotal)
        Me.grpDados.Controls.Add(Me.lblValorTotal)
        Me.grpDados.Controls.Add(Me.txtDescontoPercentual)
        Me.grpDados.Controls.Add(Me.lblDescontoPercentual)
        Me.grpDados.Controls.Add(Me.txtValor)
        Me.grpDados.Controls.Add(Me.lblValor)
        Me.grpDados.Controls.Add(Me.txtDescritivo)
        Me.grpDados.Controls.Add(Me.lblDescritivo)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 73)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(619, 183)
        Me.grpDados.TabIndex = 1
        Me.grpDados.Text = "Dados da Despesa"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizarDescritivo
        '
        Me.btnAtualizarDescritivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizarDescritivo.FlatAppearance.BorderSize = 0
        Me.btnAtualizarDescritivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizarDescritivo.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnAtualizarDescritivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAtualizarDescritivo.Location = New System.Drawing.Point(594, 18)
        Me.btnAtualizarDescritivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtualizarDescritivo.Name = "btnAtualizarDescritivo"
        Me.btnAtualizarDescritivo.Size = New System.Drawing.Size(16, 16)
        Me.btnAtualizarDescritivo.TabIndex = 10
        Me.btnAtualizarDescritivo.TabStop = False
        Me.btnAtualizarDescritivo.UseVisualStyleBackColor = True
        '
        'txtDescontoValor
        '
        Me.txtDescontoValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDescontoValor.DecimalDigits = 2
        Me.txtDescontoValor.Location = New System.Drawing.Point(130, 152)
        Me.txtDescontoValor.MaxLength = 0
        Me.txtDescontoValor.Name = "txtDescontoValor"
        Me.txtDescontoValor.Size = New System.Drawing.Size(111, 20)
        Me.txtDescontoValor.TabIndex = 5
        Me.txtDescontoValor.Text = "0,00"
        Me.txtDescontoValor.Value = 0.0R
        Me.txtDescontoValor.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoValor
        '
        Me.lblDescontoValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescontoValor.AutoSize = True
        Me.lblDescontoValor.Location = New System.Drawing.Point(127, 135)
        Me.lblDescontoValor.Name = "lblDescontoValor"
        Me.lblDescontoValor.Size = New System.Drawing.Size(92, 14)
        Me.lblDescontoValor.TabIndex = 4
        Me.lblDescontoValor.Text = "Desconto (Valor):"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.DecimalDigits = 2
        Me.txtValorTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(364, 152)
        Me.txtValorTotal.MaxLength = 0
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(111, 20)
        Me.txtValorTotal.TabIndex = 8
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = 0.0R
        Me.txtValorTotal.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorTotal
        '
        Me.lblValorTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(361, 135)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 9
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'txtDescontoPercentual
        '
        Me.txtDescontoPercentual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDescontoPercentual.DecimalDigits = 2
        Me.txtDescontoPercentual.Location = New System.Drawing.Point(247, 152)
        Me.txtDescontoPercentual.MaxLength = 0
        Me.txtDescontoPercentual.Name = "txtDescontoPercentual"
        Me.txtDescontoPercentual.Size = New System.Drawing.Size(111, 20)
        Me.txtDescontoPercentual.TabIndex = 7
        Me.txtDescontoPercentual.Text = "0,00"
        Me.txtDescontoPercentual.Value = 0.0R
        Me.txtDescontoPercentual.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoPercentual
        '
        Me.lblDescontoPercentual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescontoPercentual.AutoSize = True
        Me.lblDescontoPercentual.Location = New System.Drawing.Point(244, 135)
        Me.lblDescontoPercentual.Name = "lblDescontoPercentual"
        Me.lblDescontoPercentual.Size = New System.Drawing.Size(77, 14)
        Me.lblDescontoPercentual.TabIndex = 6
        Me.lblDescontoPercentual.Text = "Desconto (%):"
        '
        'txtValor
        '
        Me.txtValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(9, 152)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(115, 20)
        Me.txtValor.TabIndex = 3
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(6, 135)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 2
        Me.lblValor.Text = "Valor:"
        '
        'txtDescritivo
        '
        Me.txtDescritivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescritivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivo.Location = New System.Drawing.Point(9, 37)
        Me.txtDescritivo.MaxLength = 1000
        Me.txtDescritivo.Multiline = True
        Me.txtDescritivo.Name = "txtDescritivo"
        Me.txtDescritivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescritivo.Size = New System.Drawing.Size(601, 95)
        Me.txtDescritivo.TabIndex = 1
        '
        'lblDescritivo
        '
        Me.lblDescritivo.AutoSize = True
        Me.lblDescritivo.Location = New System.Drawing.Point(6, 20)
        Me.lblDescritivo.Name = "lblDescritivo"
        Me.lblDescritivo.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivo.TabIndex = 0
        Me.lblDescritivo.Text = "Descritivo:"
        '
        'grpCobranca
        '
        Me.grpCobranca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCobranca.BackColor = System.Drawing.Color.Transparent
        Me.grpCobranca.Controls.Add(Me.txtFatorCambial)
        Me.grpCobranca.Controls.Add(Me.lblFatorCambial)
        Me.grpCobranca.Controls.Add(Me.lblDescontoPagamento)
        Me.grpCobranca.Controls.Add(Me.lblJurosPagamento)
        Me.grpCobranca.Controls.Add(Me.txtDescontoPagamento)
        Me.grpCobranca.Controls.Add(Me.txtJurosPagamento)
        Me.grpCobranca.Controls.Add(Me.txtMultaPagamento)
        Me.grpCobranca.Controls.Add(Me.lblMultaPagamento)
        Me.grpCobranca.Controls.Add(Me.lblMoeda)
        Me.grpCobranca.Controls.Add(Me.cboMoeda)
        Me.grpCobranca.Controls.Add(Me.btnCadastrarMoeda)
        Me.grpCobranca.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCobranca.Location = New System.Drawing.Point(8, 3)
        Me.grpCobranca.Name = "grpCobranca"
        Me.grpCobranca.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCobranca.Size = New System.Drawing.Size(619, 67)
        Me.grpCobranca.TabIndex = 0
        Me.grpCobranca.Text = "Dados de Cobrança"
        Me.grpCobranca.VisualStyleManager = Me.vsmMain
        '
        'txtFatorCambial
        '
        Me.txtFatorCambial.DecimalDigits = 4
        Me.txtFatorCambial.Enabled = False
        Me.txtFatorCambial.Location = New System.Drawing.Point(130, 37)
        Me.txtFatorCambial.MaxLength = 0
        Me.txtFatorCambial.Name = "txtFatorCambial"
        Me.txtFatorCambial.Size = New System.Drawing.Size(111, 20)
        Me.txtFatorCambial.TabIndex = 4
        Me.txtFatorCambial.Text = "0,0000"
        Me.txtFatorCambial.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblFatorCambial
        '
        Me.lblFatorCambial.AutoSize = True
        Me.lblFatorCambial.Location = New System.Drawing.Point(127, 20)
        Me.lblFatorCambial.Name = "lblFatorCambial"
        Me.lblFatorCambial.Size = New System.Drawing.Size(75, 14)
        Me.lblFatorCambial.TabIndex = 3
        Me.lblFatorCambial.Text = "Fator Cambial:"
        '
        'lblDescontoPagamento
        '
        Me.lblDescontoPagamento.AutoSize = True
        Me.lblDescontoPagamento.Location = New System.Drawing.Point(478, 20)
        Me.lblDescontoPagamento.Name = "lblDescontoPagamento"
        Me.lblDescontoPagamento.Size = New System.Drawing.Size(108, 14)
        Me.lblDescontoPagamento.TabIndex = 9
        Me.lblDescontoPagamento.Text = "Desconto Cond. (%):"
        '
        'lblJurosPagamento
        '
        Me.lblJurosPagamento.AutoSize = True
        Me.lblJurosPagamento.Location = New System.Drawing.Point(361, 20)
        Me.lblJurosPagamento.Name = "lblJurosPagamento"
        Me.lblJurosPagamento.Size = New System.Drawing.Size(81, 14)
        Me.lblJurosPagamento.TabIndex = 7
        Me.lblJurosPagamento.Text = "Juros Mês (%):"
        '
        'txtDescontoPagamento
        '
        Me.txtDescontoPagamento.DecimalDigits = 2
        Me.txtDescontoPagamento.Location = New System.Drawing.Point(481, 37)
        Me.txtDescontoPagamento.MaxLength = 0
        Me.txtDescontoPagamento.Name = "txtDescontoPagamento"
        Me.txtDescontoPagamento.Size = New System.Drawing.Size(111, 20)
        SuperTipSettings1.HeaderText = "Desconto Cond. (Valor)"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Desconto concedido somente se for efetuado o pagamento antes do Vencimento."
        Me.jstTip.SetSuperTip(Me.txtDescontoPagamento, SuperTipSettings1)
        Me.txtDescontoPagamento.TabIndex = 10
        Me.txtDescontoPagamento.Text = "0,00"
        Me.txtDescontoPagamento.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtJurosPagamento
        '
        Me.txtJurosPagamento.DecimalDigits = 2
        Me.txtJurosPagamento.Location = New System.Drawing.Point(364, 37)
        Me.txtJurosPagamento.MaxLength = 0
        Me.txtJurosPagamento.Name = "txtJurosPagamento"
        Me.txtJurosPagamento.Size = New System.Drawing.Size(111, 20)
        Me.txtJurosPagamento.TabIndex = 8
        Me.txtJurosPagamento.Text = "0,00"
        Me.txtJurosPagamento.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtMultaPagamento
        '
        Me.txtMultaPagamento.DecimalDigits = 2
        Me.txtMultaPagamento.Location = New System.Drawing.Point(247, 37)
        Me.txtMultaPagamento.MaxLength = 0
        Me.txtMultaPagamento.Name = "txtMultaPagamento"
        Me.txtMultaPagamento.Size = New System.Drawing.Size(111, 20)
        Me.txtMultaPagamento.TabIndex = 6
        Me.txtMultaPagamento.Text = "0,00"
        Me.txtMultaPagamento.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMultaPagamento
        '
        Me.lblMultaPagamento.AutoSize = True
        Me.lblMultaPagamento.Location = New System.Drawing.Point(244, 20)
        Me.lblMultaPagamento.Name = "lblMultaPagamento"
        Me.lblMultaPagamento.Size = New System.Drawing.Size(56, 14)
        Me.lblMultaPagamento.TabIndex = 5
        Me.lblMultaPagamento.Text = "Multa (%):"
        '
        'lblMoeda
        '
        Me.lblMoeda.AutoSize = True
        Me.lblMoeda.Location = New System.Drawing.Point(25, 20)
        Me.lblMoeda.Name = "lblMoeda"
        Me.lblMoeda.Size = New System.Drawing.Size(42, 14)
        Me.lblMoeda.TabIndex = 1
        Me.lblMoeda.Text = "Moeda:"
        '
        'cboMoeda
        '
        Me.cboMoeda.AutoSize = False
        Me.cboMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMoeda.Location = New System.Drawing.Point(9, 37)
        Me.cboMoeda.Name = "cboMoeda"
        Me.cboMoeda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMoeda.Size = New System.Drawing.Size(115, 20)
        Me.cboMoeda.TabIndex = 2
        '
        'btnCadastrarMoeda
        '
        Me.btnCadastrarMoeda.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMoeda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMoeda.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarMoeda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMoeda.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarMoeda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMoeda.Name = "btnCadastrarMoeda"
        Me.btnCadastrarMoeda.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMoeda.TabIndex = 0
        Me.btnCadastrarMoeda.TabStop = False
        Me.btnCadastrarMoeda.UseVisualStyleBackColor = True
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
        'pagNotaFiscalEntrada
        '
        Me.pagNotaFiscalEntrada.Controls.Add(Me.btnExcelGridNotaFiscalEntrada)
        Me.pagNotaFiscalEntrada.Controls.Add(Me.btnAgruparGridNotaFiscalEntrada)
        Me.pagNotaFiscalEntrada.Controls.Add(Me.btnConfigurarGridNotaFiscalEntrada)
        Me.pagNotaFiscalEntrada.Controls.Add(Me.grpNotaFiscalEntrada)
        Me.pagNotaFiscalEntrada.Controls.Add(Me.grdNotaFiscalEntrada)
        Me.pagNotaFiscalEntrada.Key = "pagNotaFiscalEntrada"
        Me.pagNotaFiscalEntrada.Location = New System.Drawing.Point(1, 22)
        Me.pagNotaFiscalEntrada.Name = "pagNotaFiscalEntrada"
        Me.pagNotaFiscalEntrada.Size = New System.Drawing.Size(895, 384)
        Me.pagNotaFiscalEntrada.TabStop = True
        Me.pagNotaFiscalEntrada.Text = "Nota Fiscal de Entrada Correlacionada"
        '
        'btnExcelGridNotaFiscalEntrada
        '
        Me.btnExcelGridNotaFiscalEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridNotaFiscalEntrada.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridNotaFiscalEntrada.FlatAppearance.BorderSize = 0
        Me.btnExcelGridNotaFiscalEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridNotaFiscalEntrada.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridNotaFiscalEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridNotaFiscalEntrada.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridNotaFiscalEntrada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridNotaFiscalEntrada.Name = "btnExcelGridNotaFiscalEntrada"
        Me.btnExcelGridNotaFiscalEntrada.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridNotaFiscalEntrada.TabIndex = 27
        Me.btnExcelGridNotaFiscalEntrada.TabStop = False
        Me.btnExcelGridNotaFiscalEntrada.UseVisualStyleBackColor = False
        '
        'btnAgruparGridNotaFiscalEntrada
        '
        Me.btnAgruparGridNotaFiscalEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridNotaFiscalEntrada.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridNotaFiscalEntrada.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridNotaFiscalEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridNotaFiscalEntrada.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridNotaFiscalEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridNotaFiscalEntrada.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridNotaFiscalEntrada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridNotaFiscalEntrada.Name = "btnAgruparGridNotaFiscalEntrada"
        Me.btnAgruparGridNotaFiscalEntrada.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridNotaFiscalEntrada.TabIndex = 26
        Me.btnAgruparGridNotaFiscalEntrada.TabStop = False
        Me.btnAgruparGridNotaFiscalEntrada.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridNotaFiscalEntrada
        '
        Me.btnConfigurarGridNotaFiscalEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridNotaFiscalEntrada.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridNotaFiscalEntrada.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridNotaFiscalEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridNotaFiscalEntrada.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridNotaFiscalEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridNotaFiscalEntrada.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridNotaFiscalEntrada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridNotaFiscalEntrada.Name = "btnConfigurarGridNotaFiscalEntrada"
        Me.btnConfigurarGridNotaFiscalEntrada.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridNotaFiscalEntrada.TabIndex = 2
        Me.btnConfigurarGridNotaFiscalEntrada.TabStop = False
        Me.btnConfigurarGridNotaFiscalEntrada.UseVisualStyleBackColor = False
        '
        'grpNotaFiscalEntrada
        '
        Me.grpNotaFiscalEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpNotaFiscalEntrada.BackColor = System.Drawing.Color.Transparent
        Me.grpNotaFiscalEntrada.Controls.Add(Me.lblDataEmissaoNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.txtDataEmissaoNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.lblFornecedorNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.txtFornecedorNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.lblSerieNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.txtSerieNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.txtValorNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.lblValorNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.lblNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.cboNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.btnExcluirNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.Controls.Add(Me.btnInserirNotaFiscalEntrada)
        Me.grpNotaFiscalEntrada.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpNotaFiscalEntrada.Location = New System.Drawing.Point(8, 3)
        Me.grpNotaFiscalEntrada.Name = "grpNotaFiscalEntrada"
        Me.grpNotaFiscalEntrada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpNotaFiscalEntrada.Size = New System.Drawing.Size(879, 67)
        Me.grpNotaFiscalEntrada.TabIndex = 0
        Me.grpNotaFiscalEntrada.Text = "Dados da Nota Fiscal de Entrada"
        Me.grpNotaFiscalEntrada.VisualStyleManager = Me.vsmMain
        '
        'lblDataEmissaoNotaFiscalEntrada
        '
        Me.lblDataEmissaoNotaFiscalEntrada.AutoSize = True
        Me.lblDataEmissaoNotaFiscalEntrada.Location = New System.Drawing.Point(173, 20)
        Me.lblDataEmissaoNotaFiscalEntrada.Name = "lblDataEmissaoNotaFiscalEntrada"
        Me.lblDataEmissaoNotaFiscalEntrada.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoNotaFiscalEntrada.TabIndex = 4
        Me.lblDataEmissaoNotaFiscalEntrada.Text = "Data Emissão:"
        '
        'txtDataEmissaoNotaFiscalEntrada
        '
        Me.txtDataEmissaoNotaFiscalEntrada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissaoNotaFiscalEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissaoNotaFiscalEntrada.Location = New System.Drawing.Point(176, 37)
        Me.txtDataEmissaoNotaFiscalEntrada.MaxLength = 3
        Me.txtDataEmissaoNotaFiscalEntrada.Name = "txtDataEmissaoNotaFiscalEntrada"
        Me.txtDataEmissaoNotaFiscalEntrada.ReadOnly = True
        Me.txtDataEmissaoNotaFiscalEntrada.Size = New System.Drawing.Size(80, 20)
        Me.txtDataEmissaoNotaFiscalEntrada.TabIndex = 5
        Me.txtDataEmissaoNotaFiscalEntrada.TabStop = False
        '
        'lblFornecedorNotaFiscalEntrada
        '
        Me.lblFornecedorNotaFiscalEntrada.AutoSize = True
        Me.lblFornecedorNotaFiscalEntrada.Location = New System.Drawing.Point(259, 20)
        Me.lblFornecedorNotaFiscalEntrada.Name = "lblFornecedorNotaFiscalEntrada"
        Me.lblFornecedorNotaFiscalEntrada.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorNotaFiscalEntrada.TabIndex = 6
        Me.lblFornecedorNotaFiscalEntrada.Text = "Fornecedor:"
        '
        'txtFornecedorNotaFiscalEntrada
        '
        Me.txtFornecedorNotaFiscalEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFornecedorNotaFiscalEntrada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFornecedorNotaFiscalEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorNotaFiscalEntrada.Location = New System.Drawing.Point(262, 37)
        Me.txtFornecedorNotaFiscalEntrada.MaxLength = 60
        Me.txtFornecedorNotaFiscalEntrada.Name = "txtFornecedorNotaFiscalEntrada"
        Me.txtFornecedorNotaFiscalEntrada.ReadOnly = True
        Me.txtFornecedorNotaFiscalEntrada.Size = New System.Drawing.Size(310, 20)
        Me.txtFornecedorNotaFiscalEntrada.TabIndex = 7
        Me.txtFornecedorNotaFiscalEntrada.TabStop = False
        '
        'lblSerieNotaFiscalEntrada
        '
        Me.lblSerieNotaFiscalEntrada.AutoSize = True
        Me.lblSerieNotaFiscalEntrada.Location = New System.Drawing.Point(127, 20)
        Me.lblSerieNotaFiscalEntrada.Name = "lblSerieNotaFiscalEntrada"
        Me.lblSerieNotaFiscalEntrada.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieNotaFiscalEntrada.TabIndex = 2
        Me.lblSerieNotaFiscalEntrada.Text = "Série:"
        '
        'txtSerieNotaFiscalEntrada
        '
        Me.txtSerieNotaFiscalEntrada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSerieNotaFiscalEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieNotaFiscalEntrada.Location = New System.Drawing.Point(130, 37)
        Me.txtSerieNotaFiscalEntrada.MaxLength = 3
        Me.txtSerieNotaFiscalEntrada.Name = "txtSerieNotaFiscalEntrada"
        Me.txtSerieNotaFiscalEntrada.ReadOnly = True
        Me.txtSerieNotaFiscalEntrada.Size = New System.Drawing.Size(40, 20)
        Me.txtSerieNotaFiscalEntrada.TabIndex = 3
        Me.txtSerieNotaFiscalEntrada.TabStop = False
        '
        'txtValorNotaFiscalEntrada
        '
        Me.txtValorNotaFiscalEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorNotaFiscalEntrada.DecimalDigits = 2
        Me.txtValorNotaFiscalEntrada.Location = New System.Drawing.Point(578, 37)
        Me.txtValorNotaFiscalEntrada.MaxLength = 15
        Me.txtValorNotaFiscalEntrada.Name = "txtValorNotaFiscalEntrada"
        Me.txtValorNotaFiscalEntrada.Size = New System.Drawing.Size(90, 20)
        Me.txtValorNotaFiscalEntrada.TabIndex = 9
        Me.txtValorNotaFiscalEntrada.Text = "0,00"
        Me.txtValorNotaFiscalEntrada.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorNotaFiscalEntrada
        '
        Me.lblValorNotaFiscalEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorNotaFiscalEntrada.AutoSize = True
        Me.lblValorNotaFiscalEntrada.Location = New System.Drawing.Point(575, 20)
        Me.lblValorNotaFiscalEntrada.Name = "lblValorNotaFiscalEntrada"
        Me.lblValorNotaFiscalEntrada.Size = New System.Drawing.Size(35, 14)
        Me.lblValorNotaFiscalEntrada.TabIndex = 8
        Me.lblValorNotaFiscalEntrada.Text = "Valor:"
        '
        'lblNotaFiscalEntrada
        '
        Me.lblNotaFiscalEntrada.AutoSize = True
        Me.lblNotaFiscalEntrada.Location = New System.Drawing.Point(6, 20)
        Me.lblNotaFiscalEntrada.Name = "lblNotaFiscalEntrada"
        Me.lblNotaFiscalEntrada.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalEntrada.TabIndex = 0
        Me.lblNotaFiscalEntrada.Text = "Nota Fiscal:"
        '
        'cboNotaFiscalEntrada
        '
        Me.cboNotaFiscalEntrada.AutoSize = False
        Me.cboNotaFiscalEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNotaFiscalEntrada.Location = New System.Drawing.Point(9, 37)
        Me.cboNotaFiscalEntrada.Name = "cboNotaFiscalEntrada"
        Me.cboNotaFiscalEntrada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNotaFiscalEntrada.Size = New System.Drawing.Size(115, 20)
        Me.cboNotaFiscalEntrada.TabIndex = 1
        '
        'btnExcluirNotaFiscalEntrada
        '
        Me.btnExcluirNotaFiscalEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirNotaFiscalEntrada.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirNotaFiscalEntrada.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirNotaFiscalEntrada.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirNotaFiscalEntrada.Location = New System.Drawing.Point(779, 34)
        Me.btnExcluirNotaFiscalEntrada.Name = "btnExcluirNotaFiscalEntrada"
        Me.btnExcluirNotaFiscalEntrada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirNotaFiscalEntrada.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirNotaFiscalEntrada.TabIndex = 11
        Me.btnExcluirNotaFiscalEntrada.Text = "Excluir"
        Me.btnExcluirNotaFiscalEntrada.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirNotaFiscalEntrada
        '
        Me.btnInserirNotaFiscalEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirNotaFiscalEntrada.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirNotaFiscalEntrada.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirNotaFiscalEntrada.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirNotaFiscalEntrada.Location = New System.Drawing.Point(682, 34)
        Me.btnInserirNotaFiscalEntrada.Name = "btnInserirNotaFiscalEntrada"
        Me.btnInserirNotaFiscalEntrada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirNotaFiscalEntrada.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirNotaFiscalEntrada.TabIndex = 10
        Me.btnInserirNotaFiscalEntrada.Text = "Inserir"
        Me.btnInserirNotaFiscalEntrada.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdNotaFiscalEntrada
        '
        Me.grdNotaFiscalEntrada.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdNotaFiscalEntrada.AlternatingColors = True
        Me.grdNotaFiscalEntrada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdNotaFiscalEntrada.ColumnAutoResize = True
        grdNotaFiscalEntrada_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdNotaFiscalEntrada_DesignTimeLayout_Reference_0.Instance"), Object)
        grdNotaFiscalEntrada_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdNotaFiscalEntrada_DesignTimeLayout_Reference_0})
        grdNotaFiscalEntrada_DesignTimeLayout.LayoutString = resources.GetString("grdNotaFiscalEntrada_DesignTimeLayout.LayoutString")
        Me.grdNotaFiscalEntrada.DesignTimeLayout = grdNotaFiscalEntrada_DesignTimeLayout
        Me.grdNotaFiscalEntrada.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdNotaFiscalEntrada.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdNotaFiscalEntrada.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdNotaFiscalEntrada.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNotaFiscalEntrada.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNotaFiscalEntrada.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNotaFiscalEntrada.GroupByBoxVisible = False
        Me.grdNotaFiscalEntrada.Location = New System.Drawing.Point(8, 79)
        Me.grdNotaFiscalEntrada.Name = "grdNotaFiscalEntrada"
        Me.grdNotaFiscalEntrada.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNotaFiscalEntrada.RecordNavigator = True
        Me.grdNotaFiscalEntrada.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdNotaFiscalEntrada.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdNotaFiscalEntrada.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdNotaFiscalEntrada.Size = New System.Drawing.Size(879, 296)
        Me.grdNotaFiscalEntrada.TabIndex = 1
        Me.grdNotaFiscalEntrada.TabStop = False
        Me.grdNotaFiscalEntrada.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscalEntrada.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdNotaFiscalEntrada.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNotaFiscalEntrada.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNotaFiscalEntrada.VisualStyleManager = Me.vsmMain
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 2000
        Me.jstTip.ImageList = Nothing
        '
        'usrFinDespesaLancamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinDespesaLancamento"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
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
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDespesa.ResumeLayout(False)
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpTituloPrevisto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTituloPrevisto.ResumeLayout(False)
        Me.grpTituloPrevisto.PerformLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDuplicata.ResumeLayout(False)
        Me.grpDuplicata.PerformLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpCobranca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCobranca.ResumeLayout(False)
        Me.grpCobranca.PerformLayout()
        Me.pagClassificacao.ResumeLayout(False)
        CType(Me.grpClassificao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClassificao.ResumeLayout(False)
        Me.grpClassificao.PerformLayout()
        CType(Me.grdClassificacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagNotaFiscalEntrada.ResumeLayout(False)
        CType(Me.grpNotaFiscalEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNotaFiscalEntrada.ResumeLayout(False)
        Me.grpNotaFiscalEntrada.PerformLayout()
        CType(Me.grdNotaFiscalEntrada, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblTipoTituloFinanceiro As System.Windows.Forms.Label
    Friend WithEvents cboTipoTituloFinanceiro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents grpCobranca As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblMoeda As System.Windows.Forms.Label
    Friend WithEvents cboMoeda As Janus.Windows.EditControls.UIComboBox
    Private WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtMultaPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMultaPagamento As System.Windows.Forms.Label
    Friend WithEvents txtDescontoPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtJurosPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoPagamento As System.Windows.Forms.Label
    Friend WithEvents lblJurosPagamento As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarTipoDocumento As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarMoeda As System.Windows.Forms.Button
    Friend WithEvents txtFatorCambial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFatorCambial As System.Windows.Forms.Label
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtDescontoPercentual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoPercentual As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtDescritivo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescritivo As System.Windows.Forms.Label
    Friend WithEvents grpDuplicata As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCalcularDuplicata As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtIntervaloParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloParcela As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroParcela As System.Windows.Forms.Label
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdDuplicata As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAtivar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDescontoValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoValor As System.Windows.Forms.Label
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
    Friend WithEvents pagNotaFiscalEntrada As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridNotaFiscalEntrada As System.Windows.Forms.Button
    Friend WithEvents grpNotaFiscalEntrada As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataEmissaoNotaFiscalEntrada As System.Windows.Forms.Label
    Friend WithEvents txtDataEmissaoNotaFiscalEntrada As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedorNotaFiscalEntrada As System.Windows.Forms.Label
    Friend WithEvents txtFornecedorNotaFiscalEntrada As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieNotaFiscalEntrada As System.Windows.Forms.Label
    Friend WithEvents txtSerieNotaFiscalEntrada As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtValorNotaFiscalEntrada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorNotaFiscalEntrada As System.Windows.Forms.Label
    Friend WithEvents btnExcluirNotaFiscalEntrada As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirNotaFiscalEntrada As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNotaFiscalEntrada As System.Windows.Forms.Label
    Friend WithEvents cboNotaFiscalEntrada As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdNotaFiscalEntrada As Janus.Windows.GridEX.GridEX
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
    Friend WithEvents btnExcelGridNotaFiscalEntrada As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridNotaFiscalEntrada As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCentroCusto As System.Windows.Forms.Button
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents lblContaBancariaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboContaBancariaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescritivoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescritivoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpTituloPrevisto As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnVincular As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataVencimentoPrevisto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumDocumentoPrevisto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTituloPrevisto As System.Windows.Forms.Label
    Friend WithEvents txtValorPrevisto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboTituloPrevisto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDataInputTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInputInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataInputFiltro As System.Windows.Forms.Label
    Friend WithEvents btnAtualizarDescritivo As System.Windows.Forms.Button
    Friend WithEvents lblCondicaoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboCondicaoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarCondicaoPagamento As System.Windows.Forms.Button
    Friend WithEvents btnImportarContaRateavel As Janus.Windows.EditControls.UIButton

End Class
