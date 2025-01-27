<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstMovimentacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstMovimentacao))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim cboGrupoItemFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboTipoMovimentacaoFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboCFOPFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboTipoDocumentoFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdMovimentacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMarcaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMarcaFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarParceiroNegocioFiltro = New System.Windows.Forms.Button()
        Me.dtpDataMovimentacaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataMovimentacaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataMovimentacaoFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblTipoDocumentoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoMovimentacaoFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.cboCFOPFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblTipoMovimentacaoFiltro = New System.Windows.Forms.Label()
        Me.lblCFOPFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.cboParceiroNegocioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblParceiroNegocioFiltro = New System.Windows.Forms.Label()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.txtLoteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLoteFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.cboDepositoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepositoFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnAtualizarDeposito = New Janus.Windows.EditControls.UIButton()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.grpEndereco = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboLote = New Janus.Windows.EditControls.UIComboBox()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarDeposito = New System.Windows.Forms.Button()
        Me.btnExcluirProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarParceiroNegocio = New System.Windows.Forms.Button()
        Me.btnCadastrarParceiroNegocio = New System.Windows.Forms.Button()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.cboParceiroNegocio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoMovimentacao = New System.Windows.Forms.Label()
        Me.cboTipoMovimentacao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblDataMovimentacao = New System.Windows.Forms.Label()
        Me.dtpDataMovimentacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.pagMovimentacao = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGridMovimentacao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridMovimentacao = New System.Windows.Forms.Button()
        Me.btnExcelMovimentacao = New System.Windows.Forms.Button()
        Me.UiGroupBox5 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvarMovimentacao = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarMovimentacao = New Janus.Windows.EditControls.UIButton()
        Me.grdMovimentacao = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnInserirProdutoMovimentacao = New System.Windows.Forms.Button()
        Me.txtLoteInserirMovimentacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoInserirMovimentacao = New System.Windows.Forms.Label()
        Me.txtDescricaoInserirMovimentacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblQuantidadeInserirMovimentacao = New System.Windows.Forms.Label()
        Me.txtQuantidadeInserirMovimentacao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDepositoInserirMovimentacao = New System.Windows.Forms.Label()
        Me.cboDepositoMovimentacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblLoteInserirMovimentacao = New System.Windows.Forms.Label()
        Me.lblCodigoProdutoInserir = New System.Windows.Forms.Label()
        Me.cboCodigoProdutoMovimentacao = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarProdutoMovimentacao = New System.Windows.Forms.Button()
        Me.btnInserirDepositoMovimentacao = New System.Windows.Forms.Button()
        Me.btnExcluirMovimentacao = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirMovimentacao = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoMovimentacao = New System.Windows.Forms.Label()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.txtQuantidadeMovimentacao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeMovimentacao = New System.Windows.Forms.Label()
        Me.lblLoteMovimentacao = New System.Windows.Forms.Label()
        Me.txtLoteMovimentacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDeposito = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoMovimentacao = New System.Windows.Forms.Label()
        Me.txtDescricaoMovimentacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoMovimentacao = New System.Windows.Forms.Label()
        Me.txtParceiroNegocio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDepositoMovimentacao = New System.Windows.Forms.Label()
        Me.txtTipoMovimentacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblParceiroNegocioMovimentacao = New System.Windows.Forms.Label()
        Me.lblTipoMovimentacaoEditar = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoMovimentacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoMovimentacao = New System.Windows.Forms.Label()
        Me.lblDataEditarMovimentacao = New System.Windows.Forms.Label()
        Me.dtpDataEditarMovimentacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEndereco.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.pagMovimentacao.SuspendLayout()
        CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox5.SuspendLayout()
        CType(Me.grdMovimentacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox4.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados, Me.pagMovimentacao})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 24)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 541)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Estoque - Movimentação"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(55, 461)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 13
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 461)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 11
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 461)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 10
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Location = New System.Drawing.Point(8, 156)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 322)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataMovimentacaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataMovimentacaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataMovimentacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoMovimentacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoMovimentacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.cboDepositoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDepositoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoDocumentoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboMarcaFiltro
        '
        Me.cboMarcaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMarcaFiltro.AutoSize = False
        Me.cboMarcaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMarcaFiltro.Location = New System.Drawing.Point(498, 74)
        Me.cboMarcaFiltro.Name = "cboMarcaFiltro"
        Me.cboMarcaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMarcaFiltro.Size = New System.Drawing.Size(126, 20)
        Me.cboMarcaFiltro.TabIndex = 14
        '
        'lblMarcaFiltro
        '
        Me.lblMarcaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarcaFiltro.AutoSize = True
        Me.lblMarcaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcaFiltro.Location = New System.Drawing.Point(495, 57)
        Me.lblMarcaFiltro.Name = "lblMarcaFiltro"
        Me.lblMarcaFiltro.Size = New System.Drawing.Size(51, 16)
        Me.lblMarcaFiltro.TabIndex = 13
        Me.lblMarcaFiltro.Text = "Marca:"
        '
        'btnProcurarParceiroNegocioFiltro
        '
        Me.btnProcurarParceiroNegocioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarParceiroNegocioFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarParceiroNegocioFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarParceiroNegocioFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarParceiroNegocioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarParceiroNegocioFiltro.Location = New System.Drawing.Point(475, 56)
        Me.btnProcurarParceiroNegocioFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarParceiroNegocioFiltro.Name = "btnProcurarParceiroNegocioFiltro"
        Me.btnProcurarParceiroNegocioFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarParceiroNegocioFiltro.TabIndex = 12
        Me.btnProcurarParceiroNegocioFiltro.TabStop = False
        Me.btnProcurarParceiroNegocioFiltro.UseVisualStyleBackColor = True
        '
        'dtpDataMovimentacaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataMovimentacaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataMovimentacaoInicioFiltro.Location = New System.Drawing.Point(9, 114)
        Me.dtpDataMovimentacaoInicioFiltro.Name = "dtpDataMovimentacaoInicioFiltro"
        Me.dtpDataMovimentacaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataMovimentacaoInicioFiltro.Size = New System.Drawing.Size(118, 23)
        Me.dtpDataMovimentacaoInicioFiltro.TabIndex = 18
        Me.dtpDataMovimentacaoInicioFiltro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'dtpDataMovimentacaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataMovimentacaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataMovimentacaoTerminoFiltro.Location = New System.Drawing.Point(133, 114)
        Me.dtpDataMovimentacaoTerminoFiltro.Name = "dtpDataMovimentacaoTerminoFiltro"
        Me.dtpDataMovimentacaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataMovimentacaoTerminoFiltro.Size = New System.Drawing.Size(115, 23)
        Me.dtpDataMovimentacaoTerminoFiltro.TabIndex = 19
        Me.dtpDataMovimentacaoTerminoFiltro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataMovimentacaoFiltro
        '
        Me.lblDataMovimentacaoFiltro.AutoSize = True
        Me.lblDataMovimentacaoFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblDataMovimentacaoFiltro.Name = "lblDataMovimentacaoFiltro"
        Me.lblDataMovimentacaoFiltro.Size = New System.Drawing.Size(137, 16)
        Me.lblDataMovimentacaoFiltro.TabIndex = 17
        Me.lblDataMovimentacaoFiltro.Text = "Data Movimentação:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.AllowDrop = True
        Me.cboGrupoItemFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoItemFiltro.ButtonCancelText = "Cancelar"
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboGrupoItemFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboGrupoItemFiltro_DesignTimeLayout.LayoutString")
        Me.cboGrupoItemFiltro.DesignTimeLayout = cboGrupoItemFiltro_DesignTimeLayout
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(254, 34)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.SaveSettings = False
        Me.cboGrupoItemFiltro.SettingsKey = "cboCFOPFiltro"
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(238, 23)
        Me.cboGrupoItemFiltro.TabIndex = 3
        Me.cboGrupoItemFiltro.ValuesDataMember = Nothing
        '
        'lblTipoDocumentoFiltro
        '
        Me.lblTipoDocumentoFiltro.AutoSize = True
        Me.lblTipoDocumentoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoDocumentoFiltro.Location = New System.Drawing.Point(251, 97)
        Me.lblTipoDocumentoFiltro.Name = "lblTipoDocumentoFiltro"
        Me.lblTipoDocumentoFiltro.Size = New System.Drawing.Size(135, 16)
        Me.lblTipoDocumentoFiltro.TabIndex = 20
        Me.lblTipoDocumentoFiltro.Text = "Tipo de Documento:"
        '
        'cboTipoMovimentacaoFiltro
        '
        Me.cboTipoMovimentacaoFiltro.AllowDrop = True
        Me.cboTipoMovimentacaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoMovimentacaoFiltro.ButtonCancelText = "Cancelar"
        Me.cboTipoMovimentacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboTipoMovimentacaoFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboTipoMovimentacaoFiltro_DesignTimeLayout.LayoutString")
        Me.cboTipoMovimentacaoFiltro.DesignTimeLayout = cboTipoMovimentacaoFiltro_DesignTimeLayout
        Me.cboTipoMovimentacaoFiltro.Location = New System.Drawing.Point(630, 114)
        Me.cboTipoMovimentacaoFiltro.Name = "cboTipoMovimentacaoFiltro"
        Me.cboTipoMovimentacaoFiltro.SaveSettings = False
        Me.cboTipoMovimentacaoFiltro.SettingsKey = "cboCFOPFiltro"
        Me.cboTipoMovimentacaoFiltro.Size = New System.Drawing.Size(128, 23)
        Me.cboTipoMovimentacaoFiltro.TabIndex = 24
        Me.cboTipoMovimentacaoFiltro.ValuesDataMember = Nothing
        '
        'cboCFOPFiltro
        '
        Me.cboCFOPFiltro.AllowDrop = True
        Me.cboCFOPFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCFOPFiltro.ButtonCancelText = "Cancelar"
        Me.cboCFOPFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboCFOPFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboCFOPFiltro_DesignTimeLayout.LayoutString")
        Me.cboCFOPFiltro.DesignTimeLayout = cboCFOPFiltro_DesignTimeLayout
        Me.cboCFOPFiltro.Location = New System.Drawing.Point(498, 114)
        Me.cboCFOPFiltro.Name = "cboCFOPFiltro"
        Me.cboCFOPFiltro.SaveSettings = False
        Me.cboCFOPFiltro.SettingsKey = "cboCFOPFiltro"
        Me.cboCFOPFiltro.Size = New System.Drawing.Size(126, 23)
        Me.cboCFOPFiltro.TabIndex = 23
        Me.cboCFOPFiltro.ValuesDataMember = Nothing
        '
        'lblTipoMovimentacaoFiltro
        '
        Me.lblTipoMovimentacaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoMovimentacaoFiltro.AutoSize = True
        Me.lblTipoMovimentacaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoMovimentacaoFiltro.Location = New System.Drawing.Point(627, 97)
        Me.lblTipoMovimentacaoFiltro.Name = "lblTipoMovimentacaoFiltro"
        Me.lblTipoMovimentacaoFiltro.Size = New System.Drawing.Size(154, 16)
        Me.lblTipoMovimentacaoFiltro.TabIndex = 25
        Me.lblTipoMovimentacaoFiltro.Text = "Tipo de Movimentação:"
        '
        'lblCFOPFiltro
        '
        Me.lblCFOPFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCFOPFiltro.AutoSize = True
        Me.lblCFOPFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCFOPFiltro.Location = New System.Drawing.Point(495, 97)
        Me.lblCFOPFiltro.Name = "lblCFOPFiltro"
        Me.lblCFOPFiltro.Size = New System.Drawing.Size(51, 16)
        Me.lblCFOPFiltro.TabIndex = 22
        Me.lblCFOPFiltro.Text = "CFOP:"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(630, 74)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(128, 23)
        Me.txtNumeroDocumentoFiltro.TabIndex = 16
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(627, 57)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(102, 16)
        Me.lblNumeroDocumentoFiltro.TabIndex = 15
        Me.lblNumeroDocumentoFiltro.Text = "Nº Documento:"
        '
        'cboParceiroNegocioFiltro
        '
        Me.cboParceiroNegocioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboParceiroNegocioFiltro.AutoSize = False
        Me.cboParceiroNegocioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboParceiroNegocioFiltro.Location = New System.Drawing.Point(254, 74)
        Me.cboParceiroNegocioFiltro.Name = "cboParceiroNegocioFiltro"
        Me.cboParceiroNegocioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboParceiroNegocioFiltro.Size = New System.Drawing.Size(238, 20)
        Me.cboParceiroNegocioFiltro.TabIndex = 11
        '
        'lblParceiroNegocioFiltro
        '
        Me.lblParceiroNegocioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblParceiroNegocioFiltro.AutoSize = True
        Me.lblParceiroNegocioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocioFiltro.Location = New System.Drawing.Point(251, 57)
        Me.lblParceiroNegocioFiltro.Name = "lblParceiroNegocioFiltro"
        Me.lblParceiroNegocioFiltro.Size = New System.Drawing.Size(140, 16)
        Me.lblParceiroNegocioFiltro.TabIndex = 10
        Me.lblParceiroNegocioFiltro.Text = "Parceiro de Negócio:"
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(251, 17)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(91, 16)
        Me.lblGrupoItemFiltro.TabIndex = 2
        Me.lblGrupoItemFiltro.Text = "Grupo - Item:"
        '
        'txtLoteFiltro
        '
        Me.txtLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteFiltro.Location = New System.Drawing.Point(630, 34)
        Me.txtLoteFiltro.MaxLength = 50
        Me.txtLoteFiltro.Name = "txtLoteFiltro"
        Me.txtLoteFiltro.Size = New System.Drawing.Size(128, 23)
        Me.txtLoteFiltro.TabIndex = 7
        '
        'lblLoteFiltro
        '
        Me.lblLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoteFiltro.AutoSize = True
        Me.lblLoteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLoteFiltro.Location = New System.Drawing.Point(627, 17)
        Me.lblLoteFiltro.Name = "lblLoteFiltro"
        Me.lblLoteFiltro.Size = New System.Drawing.Size(40, 16)
        Me.lblLoteFiltro.TabIndex = 6
        Me.lblLoteFiltro.Text = "Lote:"
        '
        'txtCodigoProdutoFiltro
        '
        Me.txtCodigoProdutoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProdutoFiltro.Location = New System.Drawing.Point(498, 34)
        Me.txtCodigoProdutoFiltro.MaxLength = 60
        Me.txtCodigoProdutoFiltro.Name = "txtCodigoProdutoFiltro"
        Me.txtCodigoProdutoFiltro.Size = New System.Drawing.Size(126, 23)
        Me.txtCodigoProdutoFiltro.TabIndex = 5
        '
        'lblCodigoProdutoFiltro
        '
        Me.lblCodigoProdutoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoProdutoFiltro.AutoSize = True
        Me.lblCodigoProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoFiltro.Location = New System.Drawing.Point(495, 17)
        Me.lblCodigoProdutoFiltro.Name = "lblCodigoProdutoFiltro"
        Me.lblCodigoProdutoFiltro.Size = New System.Drawing.Size(111, 16)
        Me.lblCodigoProdutoFiltro.TabIndex = 4
        Me.lblCodigoProdutoFiltro.Text = "Código Produto:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 26
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboDepositoFiltro
        '
        Me.cboDepositoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDepositoFiltro.AutoSize = False
        Me.cboDepositoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboDepositoFiltro.Name = "cboDepositoFiltro"
        Me.cboDepositoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepositoFiltro.Size = New System.Drawing.Size(239, 20)
        Me.cboDepositoFiltro.TabIndex = 1
        '
        'lblDepositoFiltro
        '
        Me.lblDepositoFiltro.AutoSize = True
        Me.lblDepositoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDepositoFiltro.Name = "lblDepositoFiltro"
        Me.lblDepositoFiltro.Size = New System.Drawing.Size(68, 16)
        Me.lblDepositoFiltro.TabIndex = 0
        Me.lblDepositoFiltro.Text = "Depósito:"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtDescricaoFiltro.MaxLength = 120
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(239, 23)
        Me.txtDescricaoFiltro.TabIndex = 9
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(75, 16)
        Me.lblDescricaoFiltro.TabIndex = 8
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'cboTipoDocumentoFiltro
        '
        Me.cboTipoDocumentoFiltro.AllowDrop = True
        Me.cboTipoDocumentoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoDocumentoFiltro.ButtonCancelText = "Cancelar"
        Me.cboTipoDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboTipoDocumentoFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboTipoDocumentoFiltro_DesignTimeLayout.LayoutString")
        Me.cboTipoDocumentoFiltro.DesignTimeLayout = cboTipoDocumentoFiltro_DesignTimeLayout
        Me.cboTipoDocumentoFiltro.Location = New System.Drawing.Point(254, 114)
        Me.cboTipoDocumentoFiltro.Name = "cboTipoDocumentoFiltro"
        Me.cboTipoDocumentoFiltro.SaveSettings = False
        Me.cboTipoDocumentoFiltro.SettingsKey = "cboCFOPFiltro"
        Me.cboTipoDocumentoFiltro.Size = New System.Drawing.Size(238, 23)
        Me.cboTipoDocumentoFiltro.TabIndex = 21
        Me.cboTipoDocumentoFiltro.ValuesDataMember = Nothing
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Controls.Add(Me.btnAtualizarDeposito)
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 481)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExcluir.Location = New System.Drawing.Point(545, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(106, 24)
        Me.btnExcluir.TabIndex = 14
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAtualizarDeposito
        '
        Me.btnAtualizarDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizarDeposito.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAtualizarDeposito.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizarDeposito.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnAtualizarDeposito.Location = New System.Drawing.Point(657, 17)
        Me.btnAtualizarDeposito.Name = "btnAtualizarDeposito"
        Me.btnAtualizarDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizarDeposito.Size = New System.Drawing.Size(134, 23)
        Me.btnAtualizarDeposito.TabIndex = 5
        Me.btnAtualizarDeposito.Text = "Atualizar Depósito"
        Me.btnAtualizarDeposito.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(119, 16)
        Me.lblCongelarColuna.TabIndex = 3
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(78, 20)
        Me.cboCongelarColuna.TabIndex = 4
        Me.cboCongelarColuna.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridProduto)
        Me.pagDados.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagDados.Controls.Add(Me.grpEndereco)
        Me.pagDados.Controls.Add(Me.grdProduto)
        Me.pagDados.Controls.Add(Me.UiGroupBox1)
        Me.pagDados.Controls.Add(Me.UiGroupBox2)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 24)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 541)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Estoque - Movimentação"
        '
        'btnExcelGridProduto
        '
        Me.btnExcelGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridProduto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridProduto.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridProduto.Location = New System.Drawing.Point(55, 461)
        Me.btnExcelGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridProduto.Name = "btnExcelGridProduto"
        Me.btnExcelGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridProduto.TabIndex = 5
        Me.btnExcelGridProduto.TabStop = False
        Me.btnExcelGridProduto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridProduto
        '
        Me.btnAgruparGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridProduto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridProduto.Location = New System.Drawing.Point(33, 461)
        Me.btnAgruparGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProduto.Name = "btnAgruparGridProduto"
        Me.btnAgruparGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridProduto.TabIndex = 4
        Me.btnAgruparGridProduto.TabStop = False
        Me.btnAgruparGridProduto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(9, 461)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 3
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'grpEndereco
        '
        Me.grpEndereco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEndereco.BackColor = System.Drawing.Color.Transparent
        Me.grpEndereco.Controls.Add(Me.cboLote)
        Me.grpEndereco.Controls.Add(Me.txtLote)
        Me.grpEndereco.Controls.Add(Me.lblDescricao)
        Me.grpEndereco.Controls.Add(Me.txtDescricao)
        Me.grpEndereco.Controls.Add(Me.lblQuantidade)
        Me.grpEndereco.Controls.Add(Me.txtQuantidade)
        Me.grpEndereco.Controls.Add(Me.lblDeposito)
        Me.grpEndereco.Controls.Add(Me.cboDeposito)
        Me.grpEndereco.Controls.Add(Me.lblLote)
        Me.grpEndereco.Controls.Add(Me.lblCodigoProduto)
        Me.grpEndereco.Controls.Add(Me.cboProduto)
        Me.grpEndereco.Controls.Add(Me.btnCadastrarProduto)
        Me.grpEndereco.Controls.Add(Me.btnProcurarProduto)
        Me.grpEndereco.Controls.Add(Me.btnCadastrarDeposito)
        Me.grpEndereco.Controls.Add(Me.btnExcluirProduto)
        Me.grpEndereco.Controls.Add(Me.btnInserirProduto)
        Me.grpEndereco.Location = New System.Drawing.Point(8, 70)
        Me.grpEndereco.Name = "grpEndereco"
        Me.grpEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEndereco.Size = New System.Drawing.Size(897, 104)
        Me.grpEndereco.TabIndex = 1
        Me.grpEndereco.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEndereco.VisualStyleManager = Me.vsmMain
        '
        'cboLote
        '
        Me.cboLote.AutoSize = False
        Me.cboLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLote.Location = New System.Drawing.Point(9, 74)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLote.Size = New System.Drawing.Size(120, 20)
        Me.cboLote.TabIndex = 8
        '
        'txtLote
        '
        Me.txtLote.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(9, 74)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(120, 23)
        Me.txtLote.TabIndex = 7
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(132, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(75, 16)
        Me.lblDescricao.TabIndex = 4
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(517, 23)
        Me.txtDescricao.TabIndex = 5
        Me.txtDescricao.TabStop = False
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(549, 57)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(86, 16)
        Me.lblQuantidade.TabIndex = 12
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(552, 74)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 23)
        Me.txtQuantidade.TabIndex = 13
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(151, 57)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(68, 16)
        Me.lblDeposito.TabIndex = 10
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(135, 74)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(411, 20)
        Me.cboDeposito.TabIndex = 11
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(6, 57)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(40, 16)
        Me.lblLote.TabIndex = 6
        Me.lblLote.Text = "Lote:"
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProduto.Location = New System.Drawing.Point(25, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(57, 16)
        Me.lblCodigoProduto.TabIndex = 1
        Me.lblCodigoProduto.Text = "Código:"
        '
        'cboProduto
        '
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProduto.Location = New System.Drawing.Point(9, 34)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(120, 20)
        Me.cboProduto.TabIndex = 3
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 0
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(112, 15)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 2
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarDeposito
        '
        Me.btnCadastrarDeposito.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDeposito.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDeposito.Location = New System.Drawing.Point(135, 58)
        Me.btnCadastrarDeposito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDeposito.Name = "btnCadastrarDeposito"
        Me.btnCadastrarDeposito.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDeposito.TabIndex = 9
        Me.btnCadastrarDeposito.TabStop = False
        Me.btnCadastrarDeposito.UseVisualStyleBackColor = True
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirProduto.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirProduto.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirProduto.Location = New System.Drawing.Point(797, 71)
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirProduto.TabIndex = 15
        Me.btnExcluirProduto.Text = "Excluir"
        Me.btnExcluirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirProduto.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirProduto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirProduto.Location = New System.Drawing.Point(700, 71)
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirProduto.TabIndex = 14
        Me.btnInserirProduto.Text = "Inserir"
        Me.btnInserirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdProduto
        '
        Me.grdProduto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.CellToolTipText = "Duplo clique para editar o registro"
        Me.grdProduto.ColumnAutoResize = True
        grdProduto_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProduto_DesignTimeLayout_Reference_0.Instance"), Object)
        grdProduto_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProduto_DesignTimeLayout_Reference_0})
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.Location = New System.Drawing.Point(8, 183)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(897, 295)
        Me.grdProduto.TabIndex = 2
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnNovo)
        Me.UiGroupBox1.Controls.Add(Me.btnSalvar)
        Me.UiGroupBox1.Controls.Add(Me.btnVoltar)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 481)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(897, 51)
        Me.UiGroupBox1.TabIndex = 6
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnProcurarParceiroNegocio)
        Me.UiGroupBox2.Controls.Add(Me.btnCadastrarParceiroNegocio)
        Me.UiGroupBox2.Controls.Add(Me.lblParceiroNegocio)
        Me.UiGroupBox2.Controls.Add(Me.cboParceiroNegocio)
        Me.UiGroupBox2.Controls.Add(Me.lblTipoMovimentacao)
        Me.UiGroupBox2.Controls.Add(Me.cboTipoMovimentacao)
        Me.UiGroupBox2.Controls.Add(Me.txtNumeroDocumento)
        Me.UiGroupBox2.Controls.Add(Me.lblNumeroDocumento)
        Me.UiGroupBox2.Controls.Add(Me.lblDataMovimentacao)
        Me.UiGroupBox2.Controls.Add(Me.dtpDataMovimentacao)
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(897, 64)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarParceiroNegocio
        '
        Me.btnProcurarParceiroNegocio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarParceiroNegocio.FlatAppearance.BorderSize = 0
        Me.btnProcurarParceiroNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarParceiroNegocio.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarParceiroNegocio.Location = New System.Drawing.Point(871, 15)
        Me.btnProcurarParceiroNegocio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarParceiroNegocio.Name = "btnProcurarParceiroNegocio"
        Me.btnProcurarParceiroNegocio.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarParceiroNegocio.TabIndex = 9
        Me.btnProcurarParceiroNegocio.TabStop = False
        Me.btnProcurarParceiroNegocio.UseVisualStyleBackColor = True
        '
        'btnCadastrarParceiroNegocio
        '
        Me.btnCadastrarParceiroNegocio.FlatAppearance.BorderSize = 0
        Me.btnCadastrarParceiroNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarParceiroNegocio.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarParceiroNegocio.Location = New System.Drawing.Point(397, 18)
        Me.btnCadastrarParceiroNegocio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarParceiroNegocio.Name = "btnCadastrarParceiroNegocio"
        Me.btnCadastrarParceiroNegocio.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarParceiroNegocio.TabIndex = 6
        Me.btnCadastrarParceiroNegocio.TabStop = False
        Me.btnCadastrarParceiroNegocio.UseVisualStyleBackColor = True
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(413, 17)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(140, 16)
        Me.lblParceiroNegocio.TabIndex = 7
        Me.lblParceiroNegocio.Text = "Parceiro de Negócio:"
        '
        'cboParceiroNegocio
        '
        Me.cboParceiroNegocio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboParceiroNegocio.AutoSize = False
        Me.cboParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboParceiroNegocio.Location = New System.Drawing.Point(397, 34)
        Me.cboParceiroNegocio.Name = "cboParceiroNegocio"
        Me.cboParceiroNegocio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboParceiroNegocio.Size = New System.Drawing.Size(491, 20)
        Me.cboParceiroNegocio.TabIndex = 8
        '
        'lblTipoMovimentacao
        '
        Me.lblTipoMovimentacao.AutoSize = True
        Me.lblTipoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoMovimentacao.Location = New System.Drawing.Point(238, 17)
        Me.lblTipoMovimentacao.Name = "lblTipoMovimentacao"
        Me.lblTipoMovimentacao.Size = New System.Drawing.Size(154, 16)
        Me.lblTipoMovimentacao.TabIndex = 4
        Me.lblTipoMovimentacao.Text = "Tipo de Movimentação:"
        '
        'cboTipoMovimentacao
        '
        Me.cboTipoMovimentacao.AutoSize = False
        Me.cboTipoMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoMovimentacao.Location = New System.Drawing.Point(241, 34)
        Me.cboTipoMovimentacao.Name = "cboTipoMovimentacao"
        Me.cboTipoMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoMovimentacao.Size = New System.Drawing.Size(150, 20)
        Me.cboTipoMovimentacao.TabIndex = 5
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(120, 23)
        Me.txtNumeroDocumento.TabIndex = 1
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(102, 16)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'lblDataMovimentacao
        '
        Me.lblDataMovimentacao.AutoSize = True
        Me.lblDataMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataMovimentacao.Location = New System.Drawing.Point(132, 17)
        Me.lblDataMovimentacao.Name = "lblDataMovimentacao"
        Me.lblDataMovimentacao.Size = New System.Drawing.Size(42, 16)
        Me.lblDataMovimentacao.TabIndex = 2
        Me.lblDataMovimentacao.Text = "Data:"
        '
        'dtpDataMovimentacao
        '
        '
        '
        '
        Me.dtpDataMovimentacao.DropDownCalendar.Name = ""
        Me.dtpDataMovimentacao.Location = New System.Drawing.Point(135, 34)
        Me.dtpDataMovimentacao.Name = "dtpDataMovimentacao"
        Me.dtpDataMovimentacao.Size = New System.Drawing.Size(100, 23)
        Me.dtpDataMovimentacao.TabIndex = 3
        '
        'pagMovimentacao
        '
        Me.pagMovimentacao.Controls.Add(Me.btnAgruparGridMovimentacao)
        Me.pagMovimentacao.Controls.Add(Me.btnConfigurarGridMovimentacao)
        Me.pagMovimentacao.Controls.Add(Me.btnExcelMovimentacao)
        Me.pagMovimentacao.Controls.Add(Me.UiGroupBox5)
        Me.pagMovimentacao.Controls.Add(Me.grdMovimentacao)
        Me.pagMovimentacao.Controls.Add(Me.UiGroupBox4)
        Me.pagMovimentacao.Controls.Add(Me.UiGroupBox3)
        Me.pagMovimentacao.Location = New System.Drawing.Point(1, 24)
        Me.pagMovimentacao.Name = "pagMovimentacao"
        Me.pagMovimentacao.Size = New System.Drawing.Size(913, 541)
        Me.pagMovimentacao.TabStop = True
        Me.pagMovimentacao.Text = "Estoque - Movimentação"
        '
        'btnAgruparGridMovimentacao
        '
        Me.btnAgruparGridMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridMovimentacao.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridMovimentacao.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridMovimentacao.Location = New System.Drawing.Point(30, 461)
        Me.btnAgruparGridMovimentacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridMovimentacao.Name = "btnAgruparGridMovimentacao"
        Me.btnAgruparGridMovimentacao.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridMovimentacao.TabIndex = 17
        Me.btnAgruparGridMovimentacao.TabStop = False
        Me.btnAgruparGridMovimentacao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridMovimentacao
        '
        Me.btnConfigurarGridMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridMovimentacao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridMovimentacao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridMovimentacao.Location = New System.Drawing.Point(9, 461)
        Me.btnConfigurarGridMovimentacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridMovimentacao.Name = "btnConfigurarGridMovimentacao"
        Me.btnConfigurarGridMovimentacao.Size = New System.Drawing.Size(21, 15)
        Me.btnConfigurarGridMovimentacao.TabIndex = 16
        Me.btnConfigurarGridMovimentacao.TabStop = False
        Me.btnConfigurarGridMovimentacao.UseVisualStyleBackColor = False
        '
        'btnExcelMovimentacao
        '
        Me.btnExcelMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelMovimentacao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelMovimentacao.FlatAppearance.BorderSize = 0
        Me.btnExcelMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelMovimentacao.Location = New System.Drawing.Point(55, 461)
        Me.btnExcelMovimentacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelMovimentacao.Name = "btnExcelMovimentacao"
        Me.btnExcelMovimentacao.Size = New System.Drawing.Size(22, 15)
        Me.btnExcelMovimentacao.TabIndex = 3
        Me.btnExcelMovimentacao.TabStop = False
        Me.btnExcelMovimentacao.UseVisualStyleBackColor = False
        '
        'UiGroupBox5
        '
        Me.UiGroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox5.Controls.Add(Me.btnSalvarMovimentacao)
        Me.UiGroupBox5.Controls.Add(Me.btnVoltarMovimentacao)
        Me.UiGroupBox5.Location = New System.Drawing.Point(8, 481)
        Me.UiGroupBox5.Name = "UiGroupBox5"
        Me.UiGroupBox5.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox5.Size = New System.Drawing.Size(897, 51)
        Me.UiGroupBox5.TabIndex = 4
        Me.UiGroupBox5.VisualStyleManager = Me.vsmMain
        '
        'btnSalvarMovimentacao
        '
        Me.btnSalvarMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarMovimentacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarMovimentacao.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarMovimentacao.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvarMovimentacao.Name = "btnSalvarMovimentacao"
        Me.btnSalvarMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarMovimentacao.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvarMovimentacao.TabIndex = 0
        Me.btnSalvarMovimentacao.Text = "Salvar"
        Me.btnSalvarMovimentacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarMovimentacao
        '
        Me.btnVoltarMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltarMovimentacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarMovimentacao.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltarMovimentacao.Name = "btnVoltarMovimentacao"
        Me.btnVoltarMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarMovimentacao.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltarMovimentacao.TabIndex = 1
        Me.btnVoltarMovimentacao.Text = "Voltar"
        Me.btnVoltarMovimentacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdMovimentacao
        '
        Me.grdMovimentacao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMovimentacao.AlternatingColors = True
        Me.grdMovimentacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMovimentacao.CellToolTipText = "Duplo clique para editar o registro"
        Me.grdMovimentacao.ColumnAutoResize = True
        grdMovimentacao_DesignTimeLayout.LayoutString = resources.GetString("grdMovimentacao_DesignTimeLayout.LayoutString")
        Me.grdMovimentacao.DesignTimeLayout = grdMovimentacao_DesignTimeLayout
        Me.grdMovimentacao.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdMovimentacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMovimentacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdMovimentacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMovimentacao.GroupByBoxVisible = False
        Me.grdMovimentacao.Location = New System.Drawing.Point(8, 229)
        Me.grdMovimentacao.Name = "grdMovimentacao"
        Me.grdMovimentacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMovimentacao.RecordNavigator = True
        Me.grdMovimentacao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdMovimentacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMovimentacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMovimentacao.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMovimentacao.Size = New System.Drawing.Size(897, 249)
        Me.grdMovimentacao.TabIndex = 2
        Me.grdMovimentacao.TabStop = False
        Me.grdMovimentacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMovimentacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMovimentacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMovimentacao.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdMovimentacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMovimentacao.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox4
        '
        Me.UiGroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox4.Controls.Add(Me.btnInserirProdutoMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.txtLoteInserirMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.lblDescricaoInserirMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.txtDescricaoInserirMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.lblQuantidadeInserirMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.txtQuantidadeInserirMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.lblDepositoInserirMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.cboDepositoMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.lblLoteInserirMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.lblCodigoProdutoInserir)
        Me.UiGroupBox4.Controls.Add(Me.cboCodigoProdutoMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.btnProcurarProdutoMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.btnInserirDepositoMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.btnExcluirMovimentacao)
        Me.UiGroupBox4.Controls.Add(Me.btnInserirMovimentacao)
        Me.UiGroupBox4.Location = New System.Drawing.Point(8, 115)
        Me.UiGroupBox4.Name = "UiGroupBox4"
        Me.UiGroupBox4.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox4.Size = New System.Drawing.Size(897, 104)
        Me.UiGroupBox4.TabIndex = 1
        Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox4.VisualStyleManager = Me.vsmMain
        '
        'btnInserirProdutoMovimentacao
        '
        Me.btnInserirProdutoMovimentacao.FlatAppearance.BorderSize = 0
        Me.btnInserirProdutoMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserirProdutoMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnInserirProdutoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnInserirProdutoMovimentacao.Location = New System.Drawing.Point(9, 18)
        Me.btnInserirProdutoMovimentacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInserirProdutoMovimentacao.Name = "btnInserirProdutoMovimentacao"
        Me.btnInserirProdutoMovimentacao.Size = New System.Drawing.Size(13, 13)
        Me.btnInserirProdutoMovimentacao.TabIndex = 0
        Me.btnInserirProdutoMovimentacao.TabStop = False
        Me.btnInserirProdutoMovimentacao.UseVisualStyleBackColor = True
        '
        'txtLoteInserirMovimentacao
        '
        Me.txtLoteInserirMovimentacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoteInserirMovimentacao.Location = New System.Drawing.Point(9, 74)
        Me.txtLoteInserirMovimentacao.MaxLength = 50
        Me.txtLoteInserirMovimentacao.Name = "txtLoteInserirMovimentacao"
        Me.txtLoteInserirMovimentacao.Size = New System.Drawing.Size(120, 23)
        Me.txtLoteInserirMovimentacao.TabIndex = 7
        '
        'lblDescricaoInserirMovimentacao
        '
        Me.lblDescricaoInserirMovimentacao.AutoSize = True
        Me.lblDescricaoInserirMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoInserirMovimentacao.Location = New System.Drawing.Point(132, 17)
        Me.lblDescricaoInserirMovimentacao.Name = "lblDescricaoInserirMovimentacao"
        Me.lblDescricaoInserirMovimentacao.Size = New System.Drawing.Size(75, 16)
        Me.lblDescricaoInserirMovimentacao.TabIndex = 4
        Me.lblDescricaoInserirMovimentacao.Text = "Descrição:"
        '
        'txtDescricaoInserirMovimentacao
        '
        Me.txtDescricaoInserirMovimentacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoInserirMovimentacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoInserirMovimentacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoInserirMovimentacao.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricaoInserirMovimentacao.MaxLength = 120
        Me.txtDescricaoInserirMovimentacao.Name = "txtDescricaoInserirMovimentacao"
        Me.txtDescricaoInserirMovimentacao.ReadOnly = True
        Me.txtDescricaoInserirMovimentacao.Size = New System.Drawing.Size(517, 23)
        Me.txtDescricaoInserirMovimentacao.TabIndex = 5
        Me.txtDescricaoInserirMovimentacao.TabStop = False
        '
        'lblQuantidadeInserirMovimentacao
        '
        Me.lblQuantidadeInserirMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeInserirMovimentacao.AutoSize = True
        Me.lblQuantidadeInserirMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeInserirMovimentacao.Location = New System.Drawing.Point(549, 57)
        Me.lblQuantidadeInserirMovimentacao.Name = "lblQuantidadeInserirMovimentacao"
        Me.lblQuantidadeInserirMovimentacao.Size = New System.Drawing.Size(86, 16)
        Me.lblQuantidadeInserirMovimentacao.TabIndex = 11
        Me.lblQuantidadeInserirMovimentacao.Text = "Quantidade:"
        '
        'txtQuantidadeInserirMovimentacao
        '
        Me.txtQuantidadeInserirMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeInserirMovimentacao.DecimalDigits = 4
        Me.txtQuantidadeInserirMovimentacao.Location = New System.Drawing.Point(552, 74)
        Me.txtQuantidadeInserirMovimentacao.Name = "txtQuantidadeInserirMovimentacao"
        Me.txtQuantidadeInserirMovimentacao.Size = New System.Drawing.Size(100, 23)
        Me.txtQuantidadeInserirMovimentacao.TabIndex = 12
        Me.txtQuantidadeInserirMovimentacao.Text = "0,0000"
        Me.txtQuantidadeInserirMovimentacao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDepositoInserirMovimentacao
        '
        Me.lblDepositoInserirMovimentacao.AutoSize = True
        Me.lblDepositoInserirMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoInserirMovimentacao.Location = New System.Drawing.Point(151, 57)
        Me.lblDepositoInserirMovimentacao.Name = "lblDepositoInserirMovimentacao"
        Me.lblDepositoInserirMovimentacao.Size = New System.Drawing.Size(68, 16)
        Me.lblDepositoInserirMovimentacao.TabIndex = 9
        Me.lblDepositoInserirMovimentacao.Text = "Depósito:"
        '
        'cboDepositoMovimentacao
        '
        Me.cboDepositoMovimentacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDepositoMovimentacao.AutoSize = False
        Me.cboDepositoMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoMovimentacao.Location = New System.Drawing.Point(135, 74)
        Me.cboDepositoMovimentacao.Name = "cboDepositoMovimentacao"
        Me.cboDepositoMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepositoMovimentacao.Size = New System.Drawing.Size(411, 20)
        Me.cboDepositoMovimentacao.TabIndex = 10
        '
        'lblLoteInserirMovimentacao
        '
        Me.lblLoteInserirMovimentacao.AutoSize = True
        Me.lblLoteInserirMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLoteInserirMovimentacao.Location = New System.Drawing.Point(6, 57)
        Me.lblLoteInserirMovimentacao.Name = "lblLoteInserirMovimentacao"
        Me.lblLoteInserirMovimentacao.Size = New System.Drawing.Size(40, 16)
        Me.lblLoteInserirMovimentacao.TabIndex = 6
        Me.lblLoteInserirMovimentacao.Text = "Lote:"
        '
        'lblCodigoProdutoInserir
        '
        Me.lblCodigoProdutoInserir.AutoSize = True
        Me.lblCodigoProdutoInserir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoInserir.Location = New System.Drawing.Point(25, 17)
        Me.lblCodigoProdutoInserir.Name = "lblCodigoProdutoInserir"
        Me.lblCodigoProdutoInserir.Size = New System.Drawing.Size(57, 16)
        Me.lblCodigoProdutoInserir.TabIndex = 1
        Me.lblCodigoProdutoInserir.Text = "Código:"
        '
        'cboCodigoProdutoMovimentacao
        '
        Me.cboCodigoProdutoMovimentacao.AutoSize = False
        Me.cboCodigoProdutoMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoProdutoMovimentacao.Location = New System.Drawing.Point(9, 34)
        Me.cboCodigoProdutoMovimentacao.Name = "cboCodigoProdutoMovimentacao"
        Me.cboCodigoProdutoMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProdutoMovimentacao.Size = New System.Drawing.Size(120, 20)
        Me.cboCodigoProdutoMovimentacao.TabIndex = 2
        '
        'btnProcurarProdutoMovimentacao
        '
        Me.btnProcurarProdutoMovimentacao.FlatAppearance.BorderSize = 0
        Me.btnProcurarProdutoMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProdutoMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProdutoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProdutoMovimentacao.Location = New System.Drawing.Point(112, 15)
        Me.btnProcurarProdutoMovimentacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProdutoMovimentacao.Name = "btnProcurarProdutoMovimentacao"
        Me.btnProcurarProdutoMovimentacao.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProdutoMovimentacao.TabIndex = 3
        Me.btnProcurarProdutoMovimentacao.TabStop = False
        Me.btnProcurarProdutoMovimentacao.UseVisualStyleBackColor = True
        '
        'btnInserirDepositoMovimentacao
        '
        Me.btnInserirDepositoMovimentacao.FlatAppearance.BorderSize = 0
        Me.btnInserirDepositoMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserirDepositoMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnInserirDepositoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnInserirDepositoMovimentacao.Location = New System.Drawing.Point(135, 58)
        Me.btnInserirDepositoMovimentacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInserirDepositoMovimentacao.Name = "btnInserirDepositoMovimentacao"
        Me.btnInserirDepositoMovimentacao.Size = New System.Drawing.Size(13, 13)
        Me.btnInserirDepositoMovimentacao.TabIndex = 8
        Me.btnInserirDepositoMovimentacao.TabStop = False
        Me.btnInserirDepositoMovimentacao.UseVisualStyleBackColor = True
        '
        'btnExcluirMovimentacao
        '
        Me.btnExcluirMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirMovimentacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirMovimentacao.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirMovimentacao.Location = New System.Drawing.Point(797, 71)
        Me.btnExcluirMovimentacao.Name = "btnExcluirMovimentacao"
        Me.btnExcluirMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirMovimentacao.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirMovimentacao.TabIndex = 14
        Me.btnExcluirMovimentacao.Text = "Excluir"
        Me.btnExcluirMovimentacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirMovimentacao
        '
        Me.btnInserirMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirMovimentacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirMovimentacao.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirMovimentacao.Location = New System.Drawing.Point(700, 71)
        Me.btnInserirMovimentacao.Name = "btnInserirMovimentacao"
        Me.btnInserirMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirMovimentacao.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirMovimentacao.TabIndex = 13
        Me.btnInserirMovimentacao.Text = "Inserir"
        Me.btnInserirMovimentacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.txtCodigo)
        Me.UiGroupBox3.Controls.Add(Me.lblCodigoMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.txtValorUnitario)
        Me.UiGroupBox3.Controls.Add(Me.lblValorUnitario)
        Me.UiGroupBox3.Controls.Add(Me.txtQuantidadeMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.lblQuantidadeMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.lblLoteMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.txtLoteMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.txtDeposito)
        Me.UiGroupBox3.Controls.Add(Me.txtCodigoProduto)
        Me.UiGroupBox3.Controls.Add(Me.lblDescricaoMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.txtDescricaoMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.lblCodigoProdutoMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.txtParceiroNegocio)
        Me.UiGroupBox3.Controls.Add(Me.lblDepositoMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.txtTipoMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.lblParceiroNegocioMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.lblTipoMovimentacaoEditar)
        Me.UiGroupBox3.Controls.Add(Me.txtNumeroDocumentoMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.lblNumeroDocumentoMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.lblDataEditarMovimentacao)
        Me.UiGroupBox3.Controls.Add(Me.dtpDataEditarMovimentacao)
        Me.UiGroupBox3.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(897, 108)
        Me.UiGroupBox3.TabIndex = 0
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(784, 74)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(103, 23)
        Me.txtCodigo.TabIndex = 21
        '
        'lblCodigoMovimentacao
        '
        Me.lblCodigoMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoMovimentacao.AutoSize = True
        Me.lblCodigoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoMovimentacao.Location = New System.Drawing.Point(781, 57)
        Me.lblCodigoMovimentacao.Name = "lblCodigoMovimentacao"
        Me.lblCodigoMovimentacao.Size = New System.Drawing.Size(61, 16)
        Me.lblCodigoMovimentacao.TabIndex = 20
        Me.lblCodigoMovimentacao.Text = " Código:"
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorUnitario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorUnitario.DecimalDigits = 2
        Me.txtValorUnitario.Enabled = False
        Me.txtValorUnitario.Location = New System.Drawing.Point(446, 74)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(100, 23)
        Me.txtValorUnitario.TabIndex = 15
        Me.txtValorUnitario.Text = "0,00"
        Me.txtValorUnitario.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtValorUnitario.Visible = False
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorUnitario.Location = New System.Drawing.Point(443, 57)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(96, 16)
        Me.lblValorUnitario.TabIndex = 14
        Me.lblValorUnitario.Tag = ""
        Me.lblValorUnitario.Text = "Valor Unitário:"
        Me.lblValorUnitario.Visible = False
        '
        'txtQuantidadeMovimentacao
        '
        Me.txtQuantidadeMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeMovimentacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeMovimentacao.DecimalDigits = 4
        Me.txtQuantidadeMovimentacao.Enabled = False
        Me.txtQuantidadeMovimentacao.Location = New System.Drawing.Point(552, 74)
        Me.txtQuantidadeMovimentacao.Name = "txtQuantidadeMovimentacao"
        Me.txtQuantidadeMovimentacao.Size = New System.Drawing.Size(100, 23)
        Me.txtQuantidadeMovimentacao.TabIndex = 17
        Me.txtQuantidadeMovimentacao.Text = "0,0000"
        Me.txtQuantidadeMovimentacao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeMovimentacao
        '
        Me.lblQuantidadeMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeMovimentacao.AutoSize = True
        Me.lblQuantidadeMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeMovimentacao.Location = New System.Drawing.Point(549, 57)
        Me.lblQuantidadeMovimentacao.Name = "lblQuantidadeMovimentacao"
        Me.lblQuantidadeMovimentacao.Size = New System.Drawing.Size(86, 16)
        Me.lblQuantidadeMovimentacao.TabIndex = 16
        Me.lblQuantidadeMovimentacao.Text = "Quantidade:"
        '
        'lblLoteMovimentacao
        '
        Me.lblLoteMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoteMovimentacao.AutoSize = True
        Me.lblLoteMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLoteMovimentacao.Location = New System.Drawing.Point(655, 57)
        Me.lblLoteMovimentacao.Name = "lblLoteMovimentacao"
        Me.lblLoteMovimentacao.Size = New System.Drawing.Size(40, 16)
        Me.lblLoteMovimentacao.TabIndex = 18
        Me.lblLoteMovimentacao.Text = "Lote:"
        '
        'txtLoteMovimentacao
        '
        Me.txtLoteMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoteMovimentacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLoteMovimentacao.Enabled = False
        Me.txtLoteMovimentacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoteMovimentacao.Location = New System.Drawing.Point(658, 74)
        Me.txtLoteMovimentacao.MaxLength = 20
        Me.txtLoteMovimentacao.Name = "txtLoteMovimentacao"
        Me.txtLoteMovimentacao.Size = New System.Drawing.Size(120, 23)
        Me.txtLoteMovimentacao.TabIndex = 19
        '
        'txtDeposito
        '
        Me.txtDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDeposito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDeposito.Enabled = False
        Me.txtDeposito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeposito.Location = New System.Drawing.Point(658, 34)
        Me.txtDeposito.MaxLength = 20
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.Size = New System.Drawing.Size(229, 23)
        Me.txtDeposito.TabIndex = 9
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoProduto.Enabled = False
        Me.txtCodigoProduto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProduto.Location = New System.Drawing.Point(9, 74)
        Me.txtCodigoProduto.MaxLength = 20
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.Size = New System.Drawing.Size(120, 23)
        Me.txtCodigoProduto.TabIndex = 11
        '
        'lblDescricaoMovimentacao
        '
        Me.lblDescricaoMovimentacao.AutoSize = True
        Me.lblDescricaoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoMovimentacao.Location = New System.Drawing.Point(132, 57)
        Me.lblDescricaoMovimentacao.Name = "lblDescricaoMovimentacao"
        Me.lblDescricaoMovimentacao.Size = New System.Drawing.Size(75, 16)
        Me.lblDescricaoMovimentacao.TabIndex = 12
        Me.lblDescricaoMovimentacao.Text = "Descrição:"
        '
        'txtDescricaoMovimentacao
        '
        Me.txtDescricaoMovimentacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoMovimentacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoMovimentacao.Enabled = False
        Me.txtDescricaoMovimentacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoMovimentacao.Location = New System.Drawing.Point(135, 74)
        Me.txtDescricaoMovimentacao.MaxLength = 120
        Me.txtDescricaoMovimentacao.Name = "txtDescricaoMovimentacao"
        Me.txtDescricaoMovimentacao.ReadOnly = True
        Me.txtDescricaoMovimentacao.Size = New System.Drawing.Size(305, 23)
        Me.txtDescricaoMovimentacao.TabIndex = 13
        Me.txtDescricaoMovimentacao.TabStop = False
        '
        'lblCodigoProdutoMovimentacao
        '
        Me.lblCodigoProdutoMovimentacao.AutoSize = True
        Me.lblCodigoProdutoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoMovimentacao.Location = New System.Drawing.Point(6, 57)
        Me.lblCodigoProdutoMovimentacao.Name = "lblCodigoProdutoMovimentacao"
        Me.lblCodigoProdutoMovimentacao.Size = New System.Drawing.Size(115, 16)
        Me.lblCodigoProdutoMovimentacao.TabIndex = 10
        Me.lblCodigoProdutoMovimentacao.Text = " Código Produto:"
        '
        'txtParceiroNegocio
        '
        Me.txtParceiroNegocio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParceiroNegocio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtParceiroNegocio.Enabled = False
        Me.txtParceiroNegocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParceiroNegocio.Location = New System.Drawing.Point(397, 34)
        Me.txtParceiroNegocio.MaxLength = 20
        Me.txtParceiroNegocio.Name = "txtParceiroNegocio"
        Me.txtParceiroNegocio.Size = New System.Drawing.Size(255, 23)
        Me.txtParceiroNegocio.TabIndex = 7
        '
        'lblDepositoMovimentacao
        '
        Me.lblDepositoMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDepositoMovimentacao.AutoSize = True
        Me.lblDepositoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoMovimentacao.Location = New System.Drawing.Point(655, 17)
        Me.lblDepositoMovimentacao.Name = "lblDepositoMovimentacao"
        Me.lblDepositoMovimentacao.Size = New System.Drawing.Size(68, 16)
        Me.lblDepositoMovimentacao.TabIndex = 8
        Me.lblDepositoMovimentacao.Text = "Depósito:"
        '
        'txtTipoMovimentacao
        '
        Me.txtTipoMovimentacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipoMovimentacao.Enabled = False
        Me.txtTipoMovimentacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoMovimentacao.Location = New System.Drawing.Point(241, 34)
        Me.txtTipoMovimentacao.MaxLength = 20
        Me.txtTipoMovimentacao.Name = "txtTipoMovimentacao"
        Me.txtTipoMovimentacao.Size = New System.Drawing.Size(150, 23)
        Me.txtTipoMovimentacao.TabIndex = 5
        '
        'lblParceiroNegocioMovimentacao
        '
        Me.lblParceiroNegocioMovimentacao.AutoSize = True
        Me.lblParceiroNegocioMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocioMovimentacao.Location = New System.Drawing.Point(394, 17)
        Me.lblParceiroNegocioMovimentacao.Name = "lblParceiroNegocioMovimentacao"
        Me.lblParceiroNegocioMovimentacao.Size = New System.Drawing.Size(140, 16)
        Me.lblParceiroNegocioMovimentacao.TabIndex = 6
        Me.lblParceiroNegocioMovimentacao.Text = "Parceiro de Negócio:"
        '
        'lblTipoMovimentacaoEditar
        '
        Me.lblTipoMovimentacaoEditar.AutoSize = True
        Me.lblTipoMovimentacaoEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoMovimentacaoEditar.Location = New System.Drawing.Point(238, 17)
        Me.lblTipoMovimentacaoEditar.Name = "lblTipoMovimentacaoEditar"
        Me.lblTipoMovimentacaoEditar.Size = New System.Drawing.Size(154, 16)
        Me.lblTipoMovimentacaoEditar.TabIndex = 4
        Me.lblTipoMovimentacaoEditar.Text = "Tipo de Movimentação:"
        '
        'txtNumeroDocumentoMovimentacao
        '
        Me.txtNumeroDocumentoMovimentacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumentoMovimentacao.Enabled = False
        Me.txtNumeroDocumentoMovimentacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDocumentoMovimentacao.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoMovimentacao.MaxLength = 20
        Me.txtNumeroDocumentoMovimentacao.Name = "txtNumeroDocumentoMovimentacao"
        Me.txtNumeroDocumentoMovimentacao.Size = New System.Drawing.Size(120, 23)
        Me.txtNumeroDocumentoMovimentacao.TabIndex = 1
        '
        'lblNumeroDocumentoMovimentacao
        '
        Me.lblNumeroDocumentoMovimentacao.AutoSize = True
        Me.lblNumeroDocumentoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDocumentoMovimentacao.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoMovimentacao.Name = "lblNumeroDocumentoMovimentacao"
        Me.lblNumeroDocumentoMovimentacao.Size = New System.Drawing.Size(102, 16)
        Me.lblNumeroDocumentoMovimentacao.TabIndex = 0
        Me.lblNumeroDocumentoMovimentacao.Text = "Nº Documento:"
        '
        'lblDataEditarMovimentacao
        '
        Me.lblDataEditarMovimentacao.AutoSize = True
        Me.lblDataEditarMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataEditarMovimentacao.Location = New System.Drawing.Point(132, 17)
        Me.lblDataEditarMovimentacao.Name = "lblDataEditarMovimentacao"
        Me.lblDataEditarMovimentacao.Size = New System.Drawing.Size(42, 16)
        Me.lblDataEditarMovimentacao.TabIndex = 2
        Me.lblDataEditarMovimentacao.Text = "Data:"
        '
        'dtpDataEditarMovimentacao
        '
        Me.dtpDataEditarMovimentacao.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.dtpDataEditarMovimentacao.DropDownCalendar.Name = ""
        Me.dtpDataEditarMovimentacao.Enabled = False
        Me.dtpDataEditarMovimentacao.Location = New System.Drawing.Point(135, 34)
        Me.dtpDataEditarMovimentacao.Name = "dtpDataEditarMovimentacao"
        Me.dtpDataEditarMovimentacao.Size = New System.Drawing.Size(100, 23)
        Me.dtpDataEditarMovimentacao.TabIndex = 3
        '
        'usrEstMovimentacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstMovimentacao"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEndereco.ResumeLayout(False)
        Me.grpEndereco.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.pagMovimentacao.ResumeLayout(False)
        CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox5.ResumeLayout(False)
        CType(Me.grdMovimentacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox4.ResumeLayout(False)
        Me.UiGroupBox4.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoMovimentacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCFOPFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboParceiroNegocioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblParceiroNegocioFiltro As System.Windows.Forms.Label
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents txtLoteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLoteFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboDepositoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepositoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboTipoDocumentoFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblTipoDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoMovimentacaoFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboCFOPFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents dtpDataMovimentacaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataMovimentacaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataMovimentacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents grpEndereco As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarDeposito As System.Windows.Forms.Button
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents btnExcluirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents cboParceiroNegocio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoMovimentacao As System.Windows.Forms.Label
    Friend WithEvents cboTipoMovimentacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblDataMovimentacao As System.Windows.Forms.Label
    Friend WithEvents dtpDataMovimentacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarParceiroNegocio As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents cboLote As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarParceiroNegocio As System.Windows.Forms.Button
    Friend WithEvents btnProcurarParceiroNegocioFiltro As System.Windows.Forms.Button
    Friend WithEvents cboMarcaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMarcaFiltro As System.Windows.Forms.Label
    Friend WithEvents pagMovimentacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtParceiroNegocio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTipoMovimentacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblParceiroNegocioMovimentacao As System.Windows.Forms.Label
    Friend WithEvents lblTipoMovimentacaoEditar As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoMovimentacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoMovimentacao As System.Windows.Forms.Label
    Friend WithEvents lblDataEditarMovimentacao As System.Windows.Forms.Label
    Friend WithEvents dtpDataEditarMovimentacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtCodigoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoMovimentacao As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoMovimentacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoMovimentacao As System.Windows.Forms.Label
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeMovimentacao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeMovimentacao As System.Windows.Forms.Label
    Friend WithEvents lblLoteMovimentacao As System.Windows.Forms.Label
    Friend WithEvents txtLoteMovimentacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDeposito As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDepositoMovimentacao As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnInserirProdutoMovimentacao As System.Windows.Forms.Button
    Friend WithEvents txtLoteInserirMovimentacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoInserirMovimentacao As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoInserirMovimentacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarProdutoMovimentacao As System.Windows.Forms.Button
    Friend WithEvents btnInserirDepositoMovimentacao As System.Windows.Forms.Button
    Friend WithEvents lblQuantidadeInserirMovimentacao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeInserirMovimentacao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDepositoInserirMovimentacao As System.Windows.Forms.Label
    Friend WithEvents cboDepositoMovimentacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLoteInserirMovimentacao As System.Windows.Forms.Label
    Friend WithEvents btnExcluirMovimentacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirMovimentacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCodigoProdutoInserir As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProdutoMovimentacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelMovimentacao As System.Windows.Forms.Button
    Friend WithEvents UiGroupBox5 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSalvarMovimentacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltarMovimentacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdMovimentacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgruparGridMovimentacao As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridMovimentacao As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoMovimentacao As System.Windows.Forms.Label
    Friend WithEvents btnAtualizarDeposito As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton

End Class
