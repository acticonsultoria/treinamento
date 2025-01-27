<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmpRecebimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpRecebimento))
        Dim cboNumeroPedido_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboProdutoKit_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEstoque_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEstoque_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdDuplicata_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoItemFiltro = New System.Windows.Forms.Label()
        Me.cboTipoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataRecebimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataRecebimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroPedidoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoFiltro = New System.Windows.Forms.Label()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataRecebimentoFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpRecebimento = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataRecebimento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataRecebimento = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.grpFiltro2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboNumeroPedido = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.btnFiltrarPedido = New Janus.Windows.EditControls.UIButton()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmarRecebimento = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagItem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpEstoque = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboProdutoKit = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblProdutoKit = New System.Windows.Forms.Label()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnExcluirEstoque = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirEstoque = New Janus.Windows.EditControls.UIButton()
        Me.btnAgruparGridItem = New System.Windows.Forms.Button()
        Me.btnConfigurarGridItem = New System.Windows.Forms.Button()
        Me.grdItem = New Janus.Windows.GridEX.GridEX()
        Me.grdEstoque = New Janus.Windows.GridEX.GridEX()
        Me.pagFatura = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDuplicata = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCalcularDuplicata = New Janus.Windows.EditControls.UIButton()
        Me.txtIntervaloEntreParcelas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIntervaloEntreParcelas = New System.Windows.Forms.Label()
        Me.txtNumeroParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroParcela = New System.Windows.Forms.Label()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.cboFormaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.grdDuplicata = New Janus.Windows.GridEX.GridEX()
        Me.grpFatura = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorLiquido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorLiquido = New System.Windows.Forms.Label()
        Me.lblValorDesconto = New System.Windows.Forms.Label()
        Me.txtValorOriginal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOriginal = New System.Windows.Forms.Label()
        Me.txtFatura = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFatura = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpRecebimento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRecebimento.SuspendLayout()
        CType(Me.grpFiltro2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro2.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagItem.SuspendLayout()
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEstoque.SuspendLayout()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagFatura.SuspendLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDuplicata.SuspendLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFatura.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Compras - Recebimento"
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 4
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 3
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
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 117)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 363)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblTipoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRecebimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRecebimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataRecebimentoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblTipoItemFiltro
        '
        Me.lblTipoItemFiltro.AutoSize = True
        Me.lblTipoItemFiltro.Location = New System.Drawing.Point(129, 57)
        Me.lblTipoItemFiltro.Name = "lblTipoItemFiltro"
        Me.lblTipoItemFiltro.Size = New System.Drawing.Size(67, 14)
        Me.lblTipoItemFiltro.TabIndex = 9
        Me.lblTipoItemFiltro.Text = "Tipo de Item:"
        '
        'cboTipoItemFiltro
        '
        Me.cboTipoItemFiltro.Location = New System.Drawing.Point(132, 74)
        Me.cboTipoItemFiltro.Name = "cboTipoItemFiltro"
        Me.cboTipoItemFiltro.Size = New System.Drawing.Size(222, 20)
        Me.cboTipoItemFiltro.TabIndex = 10
        '
        'txtItemFiltro
        '
        Me.txtItemFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemFiltro.Location = New System.Drawing.Point(360, 74)
        Me.txtItemFiltro.MaxLength = 120
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.Size = New System.Drawing.Size(399, 20)
        Me.txtItemFiltro.TabIndex = 12
        '
        'lblItemFiltro
        '
        Me.lblItemFiltro.AutoSize = True
        Me.lblItemFiltro.Location = New System.Drawing.Point(357, 57)
        Me.lblItemFiltro.Name = "lblItemFiltro"
        Me.lblItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblItemFiltro.TabIndex = 11
        Me.lblItemFiltro.Text = "Item:"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(117, 20)
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
        'dtpDataRecebimentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataRecebimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRecebimentoInicioFiltro.Location = New System.Drawing.Point(132, 34)
        Me.dtpDataRecebimentoInicioFiltro.Name = "dtpDataRecebimentoInicioFiltro"
        Me.dtpDataRecebimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataRecebimentoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRecebimentoInicioFiltro.TabIndex = 3
        '
        'dtpDataRecebimentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataRecebimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRecebimentoTerminoFiltro.Location = New System.Drawing.Point(246, 34)
        Me.dtpDataRecebimentoTerminoFiltro.Name = "dtpDataRecebimentoTerminoFiltro"
        Me.dtpDataRecebimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataRecebimentoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRecebimentoTerminoFiltro.TabIndex = 4
        '
        'txtNumeroPedidoFiltro
        '
        Me.txtNumeroPedidoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtNumeroPedidoFiltro.MaxLength = 20
        Me.txtNumeroPedidoFiltro.Name = "txtNumeroPedidoFiltro"
        Me.txtNumeroPedidoFiltro.Size = New System.Drawing.Size(117, 20)
        Me.txtNumeroPedidoFiltro.TabIndex = 8
        '
        'lblNumeroPedidoFiltro
        '
        Me.lblNumeroPedidoFiltro.AutoSize = True
        Me.lblNumeroPedidoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblNumeroPedidoFiltro.Name = "lblNumeroPedidoFiltro"
        Me.lblNumeroPedidoFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedidoFiltro.TabIndex = 7
        Me.lblNumeroPedidoFiltro.Text = "Nº Pedido:"
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(360, 34)
        Me.txtFornecedorFiltro.MaxLength = 60
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(399, 20)
        Me.txtFornecedorFiltro.TabIndex = 6
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(357, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 5
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 13
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataRecebimentoFiltro
        '
        Me.lblDataRecebimentoFiltro.AutoSize = True
        Me.lblDataRecebimentoFiltro.Location = New System.Drawing.Point(129, 17)
        Me.lblDataRecebimentoFiltro.Name = "lblDataRecebimentoFiltro"
        Me.lblDataRecebimentoFiltro.Size = New System.Drawing.Size(97, 14)
        Me.lblDataRecebimentoFiltro.TabIndex = 2
        Me.lblDataRecebimentoFiltro.Text = "Data Recebimento:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Controls.Add(Me.btnNovo)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 2
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(506, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(700, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpRecebimento)
        Me.pagDados.Controls.Add(Me.grpFiltro2)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Compras - Recebimento"
        '
        'grpRecebimento
        '
        Me.grpRecebimento.BackColor = System.Drawing.Color.Transparent
        Me.grpRecebimento.Controls.Add(Me.dtpDataRecebimento)
        Me.grpRecebimento.Controls.Add(Me.lblDataRecebimento)
        Me.grpRecebimento.Controls.Add(Me.txtNumeroDocumento)
        Me.grpRecebimento.Controls.Add(Me.lblNumeroDocumento)
        Me.grpRecebimento.Location = New System.Drawing.Point(8, 3)
        Me.grpRecebimento.Name = "grpRecebimento"
        Me.grpRecebimento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpRecebimento.Size = New System.Drawing.Size(251, 64)
        Me.grpRecebimento.TabIndex = 0
        Me.grpRecebimento.VisualStyleManager = Me.vsmMain
        '
        'dtpDataRecebimento
        '
        '
        '
        '
        Me.dtpDataRecebimento.DropDownCalendar.Name = ""
        Me.dtpDataRecebimento.Location = New System.Drawing.Point(132, 34)
        Me.dtpDataRecebimento.Name = "dtpDataRecebimento"
        Me.dtpDataRecebimento.Size = New System.Drawing.Size(110, 20)
        Me.dtpDataRecebimento.TabIndex = 3
        '
        'lblDataRecebimento
        '
        Me.lblDataRecebimento.AutoSize = True
        Me.lblDataRecebimento.Location = New System.Drawing.Point(129, 17)
        Me.lblDataRecebimento.Name = "lblDataRecebimento"
        Me.lblDataRecebimento.Size = New System.Drawing.Size(112, 14)
        Me.lblDataRecebimento.TabIndex = 2
        Me.lblDataRecebimento.Text = "Data do Recebimento:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(117, 20)
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
        'grpFiltro2
        '
        Me.grpFiltro2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro2.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro2.Controls.Add(Me.cboNumeroPedido)
        Me.grpFiltro2.Controls.Add(Me.lblNumeroPedido)
        Me.grpFiltro2.Controls.Add(Me.cboFornecedor)
        Me.grpFiltro2.Controls.Add(Me.lblFornecedor)
        Me.grpFiltro2.Controls.Add(Me.btnFiltrarPedido)
        Me.grpFiltro2.Location = New System.Drawing.Point(268, 3)
        Me.grpFiltro2.Name = "grpFiltro2"
        Me.grpFiltro2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro2.Size = New System.Drawing.Size(637, 64)
        Me.grpFiltro2.TabIndex = 1
        Me.grpFiltro2.VisualStyleManager = Me.vsmMain
        '
        'cboNumeroPedido
        '
        Me.cboNumeroPedido.AllowDrop = True
        Me.cboNumeroPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNumeroPedido.ButtonCancelText = "Cancelar"
        Me.cboNumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboNumeroPedido_DesignTimeLayout.LayoutString = resources.GetString("cboNumeroPedido_DesignTimeLayout.LayoutString")
        Me.cboNumeroPedido.DesignTimeLayout = cboNumeroPedido_DesignTimeLayout
        Me.cboNumeroPedido.Location = New System.Drawing.Point(389, 34)
        Me.cboNumeroPedido.Name = "cboNumeroPedido"
        Me.cboNumeroPedido.SaveSettings = False
        Me.cboNumeroPedido.SettingsKey = "cboDestinacaoFiltro"
        Me.cboNumeroPedido.Size = New System.Drawing.Size(128, 20)
        Me.cboNumeroPedido.TabIndex = 3
        Me.cboNumeroPedido.ValuesDataMember = Nothing
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Location = New System.Drawing.Point(386, 17)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(97, 14)
        Me.lblNumeroPedido.TabIndex = 2
        Me.lblNumeroPedido.Text = "Nº Pedido Compra:"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedor.Location = New System.Drawing.Point(9, 34)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Size = New System.Drawing.Size(374, 20)
        Me.cboFornecedor.TabIndex = 1
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(6, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 0
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'btnFiltrarPedido
        '
        Me.btnFiltrarPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarPedido.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarPedido.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarPedido.Location = New System.Drawing.Point(537, 31)
        Me.btnFiltrarPedido.Name = "btnFiltrarPedido"
        Me.btnFiltrarPedido.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarPedido.TabIndex = 4
        Me.btnFiltrarPedido.Tag = ""
        Me.btnFiltrarPedido.Text = "Filtrar"
        Me.btnFiltrarPedido.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnConfirmarRecebimento)
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Location = New System.Drawing.Point(8, 483)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(897, 51)
        Me.grpControle2.TabIndex = 3
        Me.grpControle2.VisualStyleManager = Me.vsmMain
        '
        'btnConfirmarRecebimento
        '
        Me.btnConfirmarRecebimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmarRecebimento.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnConfirmarRecebimento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmarRecebimento.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnConfirmarRecebimento.Location = New System.Drawing.Point(591, 17)
        Me.btnConfirmarRecebimento.Name = "btnConfirmarRecebimento"
        Me.btnConfirmarRecebimento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfirmarRecebimento.Size = New System.Drawing.Size(200, 23)
        Me.btnConfirmarRecebimento.TabIndex = 0
        Me.btnConfirmarRecebimento.Text = "Confirmar Recebimento"
        Me.btnConfirmarRecebimento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 73)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 407)
        Me.tabDados.TabIndex = 2
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagItem, Me.pagFatura})
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagItem
        '
        Me.pagItem.Controls.Add(Me.grpEstoque)
        Me.pagItem.Controls.Add(Me.btnAgruparGridItem)
        Me.pagItem.Controls.Add(Me.btnConfigurarGridItem)
        Me.pagItem.Controls.Add(Me.grdItem)
        Me.pagItem.Controls.Add(Me.grdEstoque)
        Me.pagItem.Key = "pagItem"
        Me.pagItem.Location = New System.Drawing.Point(1, 22)
        Me.pagItem.Name = "pagItem"
        Me.pagItem.Size = New System.Drawing.Size(895, 384)
        Me.pagItem.TabStop = True
        Me.pagItem.Text = "Lista de Itens"
        '
        'grpEstoque
        '
        Me.grpEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEstoque.BackColor = System.Drawing.Color.Transparent
        Me.grpEstoque.Controls.Add(Me.cboProdutoKit)
        Me.grpEstoque.Controls.Add(Me.lblProdutoKit)
        Me.grpEstoque.Controls.Add(Me.txtLote)
        Me.grpEstoque.Controls.Add(Me.lblLote)
        Me.grpEstoque.Controls.Add(Me.lblDeposito)
        Me.grpEstoque.Controls.Add(Me.cboDeposito)
        Me.grpEstoque.Controls.Add(Me.lblQuantidade)
        Me.grpEstoque.Controls.Add(Me.txtQuantidade)
        Me.grpEstoque.Controls.Add(Me.btnExcluirEstoque)
        Me.grpEstoque.Controls.Add(Me.btnInserirEstoque)
        Me.grpEstoque.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEstoque.Location = New System.Drawing.Point(8, 198)
        Me.grpEstoque.Name = "grpEstoque"
        Me.grpEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEstoque.Size = New System.Drawing.Size(879, 64)
        Me.grpEstoque.TabIndex = 6
        Me.grpEstoque.VisualStyleManager = Me.vsmMain
        '
        'cboProdutoKit
        '
        Me.cboProdutoKit.AllowDrop = True
        Me.cboProdutoKit.ButtonCancelText = "Cancelar"
        Me.cboProdutoKit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboProdutoKit_DesignTimeLayout.LayoutString = resources.GetString("cboProdutoKit_DesignTimeLayout.LayoutString")
        Me.cboProdutoKit.DesignTimeLayout = cboProdutoKit_DesignTimeLayout
        Me.cboProdutoKit.Location = New System.Drawing.Point(550, 35)
        Me.cboProdutoKit.Name = "cboProdutoKit"
        Me.cboProdutoKit.SaveSettings = False
        Me.cboProdutoKit.SettingsKey = "cboDestinacaoFiltro"
        Me.cboProdutoKit.Size = New System.Drawing.Size(112, 20)
        Me.cboProdutoKit.TabIndex = 7
        Me.cboProdutoKit.ValuesDataMember = Nothing
        Me.cboProdutoKit.Visible = False
        '
        'lblProdutoKit
        '
        Me.lblProdutoKit.AutoSize = True
        Me.lblProdutoKit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProdutoKit.Location = New System.Drawing.Point(547, 18)
        Me.lblProdutoKit.Name = "lblProdutoKit"
        Me.lblProdutoKit.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoKit.TabIndex = 6
        Me.lblProdutoKit.Text = "Produto:"
        Me.lblProdutoKit.Visible = False
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(273, 35)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(165, 20)
        Me.txtLote.TabIndex = 3
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(270, 18)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 2
        Me.lblLote.Text = "Lote:"
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(6, 18)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 0
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(9, 35)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(258, 20)
        Me.cboDeposito.TabIndex = 1
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(441, 18)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(101, 14)
        Me.lblQuantidade.TabIndex = 4
        Me.lblQuantidade.Text = "Qtde. Recebimento:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(444, 35)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 5
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnExcluirEstoque
        '
        Me.btnExcluirEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirEstoque.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirEstoque.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirEstoque.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirEstoque.Location = New System.Drawing.Point(779, 32)
        Me.btnExcluirEstoque.Name = "btnExcluirEstoque"
        Me.btnExcluirEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirEstoque.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirEstoque.TabIndex = 9
        Me.btnExcluirEstoque.Text = "Excluir"
        Me.btnExcluirEstoque.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirEstoque
        '
        Me.btnInserirEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirEstoque.Image = CType(resources.GetObject("btnInserirEstoque.Image"), System.Drawing.Image)
        Me.btnInserirEstoque.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirEstoque.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirEstoque.Location = New System.Drawing.Point(682, 32)
        Me.btnInserirEstoque.Name = "btnInserirEstoque"
        Me.btnInserirEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirEstoque.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirEstoque.TabIndex = 8
        Me.btnInserirEstoque.Text = "Inserir"
        Me.btnInserirEstoque.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAgruparGridItem
        '
        Me.btnAgruparGridItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridItem.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridItem.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridItem.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridItem.Location = New System.Drawing.Point(33, 178)
        Me.btnAgruparGridItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridItem.Name = "btnAgruparGridItem"
        Me.btnAgruparGridItem.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridItem.TabIndex = 2
        Me.btnAgruparGridItem.TabStop = False
        Me.btnAgruparGridItem.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridItem
        '
        Me.btnConfigurarGridItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridItem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridItem.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridItem.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridItem.Location = New System.Drawing.Point(9, 178)
        Me.btnConfigurarGridItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridItem.Name = "btnConfigurarGridItem"
        Me.btnConfigurarGridItem.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridItem.TabIndex = 1
        Me.btnConfigurarGridItem.TabStop = False
        Me.btnConfigurarGridItem.UseVisualStyleBackColor = False
        '
        'grdItem
        '
        Me.grdItem.AllowChildTableGroups = True
        Me.grdItem.AlternatingColors = True
        Me.grdItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItem.AutoEdit = True
        grdItem_DesignTimeLayout.LayoutString = resources.GetString("grdItem_DesignTimeLayout.LayoutString")
        Me.grdItem.DesignTimeLayout = grdItem_DesignTimeLayout
        Me.grdItem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdItem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdItem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdItem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdItem.FrozenColumns = 2
        Me.grdItem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdItem.GroupByBoxVisible = False
        Me.grdItem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdItem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItem.Hierarchical = True
        Me.grdItem.Location = New System.Drawing.Point(8, 9)
        Me.grdItem.Name = "grdItem"
        Me.grdItem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdItem.RecordNavigator = True
        Me.grdItem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdItem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdItem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdItem.Size = New System.Drawing.Size(879, 186)
        Me.grdItem.TabIndex = 0
        Me.grdItem.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdItem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdItem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdItem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdItem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdItem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdItem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdItem.VisualStyleManager = Me.vsmMain
        '
        'grdEstoque
        '
        Me.grdEstoque.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEstoque.AlternatingColors = True
        Me.grdEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEstoque.AutoEdit = True
        grdEstoque_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdEstoque_DesignTimeLayout_Reference_0.Instance"), Object)
        grdEstoque_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdEstoque_DesignTimeLayout_Reference_0})
        grdEstoque_DesignTimeLayout.LayoutString = resources.GetString("grdEstoque_DesignTimeLayout.LayoutString")
        Me.grdEstoque.DesignTimeLayout = grdEstoque_DesignTimeLayout
        Me.grdEstoque.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdEstoque.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdEstoque.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEstoque.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEstoque.FrozenColumns = 2
        Me.grdEstoque.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEstoque.GroupByBoxVisible = False
        Me.grdEstoque.Location = New System.Drawing.Point(8, 271)
        Me.grdEstoque.Name = "grdEstoque"
        Me.grdEstoque.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEstoque.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdEstoque.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdEstoque.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEstoque.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEstoque.Size = New System.Drawing.Size(879, 104)
        Me.grdEstoque.TabIndex = 7
        Me.grdEstoque.TabStop = False
        Me.grdEstoque.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdEstoque.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdEstoque.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdEstoque.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdEstoque.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdEstoque.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdEstoque.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdEstoque.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEstoque.VisualStyleManager = Me.vsmMain
        '
        'pagFatura
        '
        Me.pagFatura.Controls.Add(Me.grpDuplicata)
        Me.pagFatura.Controls.Add(Me.grpFatura)
        Me.pagFatura.Key = "pagFatura"
        Me.pagFatura.Location = New System.Drawing.Point(1, 22)
        Me.pagFatura.Name = "pagFatura"
        Me.pagFatura.Size = New System.Drawing.Size(895, 384)
        Me.pagFatura.TabStop = True
        Me.pagFatura.Text = "Fatura"
        '
        'grpDuplicata
        '
        Me.grpDuplicata.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDuplicata.BackColor = System.Drawing.Color.Transparent
        Me.grpDuplicata.Controls.Add(Me.btnCalcularDuplicata)
        Me.grpDuplicata.Controls.Add(Me.txtIntervaloEntreParcelas)
        Me.grpDuplicata.Controls.Add(Me.lblIntervaloEntreParcelas)
        Me.grpDuplicata.Controls.Add(Me.txtNumeroParcela)
        Me.grpDuplicata.Controls.Add(Me.lblNumeroParcela)
        Me.grpDuplicata.Controls.Add(Me.lblFormaPagamento)
        Me.grpDuplicata.Controls.Add(Me.cboFormaPagamento)
        Me.grpDuplicata.Controls.Add(Me.grdDuplicata)
        Me.grpDuplicata.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDuplicata.Location = New System.Drawing.Point(619, 3)
        Me.grpDuplicata.Name = "grpDuplicata"
        Me.grpDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDuplicata.Size = New System.Drawing.Size(268, 284)
        Me.grpDuplicata.TabIndex = 1
        Me.grpDuplicata.Text = "Duplicata"
        Me.grpDuplicata.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDuplicata.VisualStyleManager = Me.vsmMain
        '
        'btnCalcularDuplicata
        '
        Me.btnCalcularDuplicata.Image = CType(resources.GetObject("btnCalcularDuplicata.Image"), System.Drawing.Image)
        Me.btnCalcularDuplicata.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCalcularDuplicata.Location = New System.Drawing.Point(168, 114)
        Me.btnCalcularDuplicata.Name = "btnCalcularDuplicata"
        Me.btnCalcularDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCalcularDuplicata.Size = New System.Drawing.Size(91, 23)
        Me.btnCalcularDuplicata.TabIndex = 6
        Me.btnCalcularDuplicata.Text = "Calcular"
        Me.btnCalcularDuplicata.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtIntervaloEntreParcelas
        '
        Me.txtIntervaloEntreParcelas.DecimalDigits = 0
        Me.txtIntervaloEntreParcelas.Location = New System.Drawing.Point(9, 117)
        Me.txtIntervaloEntreParcelas.Name = "txtIntervaloEntreParcelas"
        Me.txtIntervaloEntreParcelas.Size = New System.Drawing.Size(108, 20)
        Me.txtIntervaloEntreParcelas.TabIndex = 5
        Me.txtIntervaloEntreParcelas.Text = "0"
        Me.txtIntervaloEntreParcelas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblIntervaloEntreParcelas
        '
        Me.lblIntervaloEntreParcelas.AutoSize = True
        Me.lblIntervaloEntreParcelas.Location = New System.Drawing.Point(6, 100)
        Me.lblIntervaloEntreParcelas.Name = "lblIntervaloEntreParcelas"
        Me.lblIntervaloEntreParcelas.Size = New System.Drawing.Size(97, 14)
        Me.lblIntervaloEntreParcelas.TabIndex = 4
        Me.lblIntervaloEntreParcelas.Text = "Int. entre Parcelas:"
        '
        'txtNumeroParcela
        '
        Me.txtNumeroParcela.DecimalDigits = 0
        Me.txtNumeroParcela.Location = New System.Drawing.Point(9, 77)
        Me.txtNumeroParcela.Name = "txtNumeroParcela"
        Me.txtNumeroParcela.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroParcela.TabIndex = 3
        Me.txtNumeroParcela.Text = "0"
        Me.txtNumeroParcela.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroParcela
        '
        Me.lblNumeroParcela.AutoSize = True
        Me.lblNumeroParcela.Location = New System.Drawing.Point(6, 60)
        Me.lblNumeroParcela.Name = "lblNumeroParcela"
        Me.lblNumeroParcela.Size = New System.Drawing.Size(67, 14)
        Me.lblNumeroParcela.TabIndex = 2
        Me.lblNumeroParcela.Text = "Nº Parcelas:"
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(6, 20)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblFormaPagamento.TabIndex = 0
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.AutoSize = False
        Me.cboFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaPagamento.Location = New System.Drawing.Point(9, 37)
        Me.cboFormaPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaPagamento.Size = New System.Drawing.Size(250, 20)
        Me.cboFormaPagamento.TabIndex = 1
        '
        'grdDuplicata
        '
        Me.grdDuplicata.AlternatingColors = True
        Me.grdDuplicata.CellToolTipText = "Duplo Clique para editar o Registro"
        grdDuplicata_DesignTimeLayout.LayoutString = resources.GetString("grdDuplicata_DesignTimeLayout.LayoutString")
        Me.grdDuplicata.DesignTimeLayout = grdDuplicata_DesignTimeLayout
        Me.grdDuplicata.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDuplicata.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDuplicata.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDuplicata.GroupByBoxVisible = False
        Me.grdDuplicata.Location = New System.Drawing.Point(9, 146)
        Me.grdDuplicata.Name = "grdDuplicata"
        Me.grdDuplicata.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDuplicata.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDuplicata.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDuplicata.Size = New System.Drawing.Size(250, 129)
        Me.grdDuplicata.TabIndex = 7
        Me.grdDuplicata.TabStop = False
        Me.grdDuplicata.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDuplicata.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdDuplicata.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDuplicata.VisualStyleManager = Me.vsmMain
        '
        'grpFatura
        '
        Me.grpFatura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFatura.BackColor = System.Drawing.Color.Transparent
        Me.grpFatura.Controls.Add(Me.txtValorDesconto)
        Me.grpFatura.Controls.Add(Me.txtValorLiquido)
        Me.grpFatura.Controls.Add(Me.lblValorLiquido)
        Me.grpFatura.Controls.Add(Me.lblValorDesconto)
        Me.grpFatura.Controls.Add(Me.txtValorOriginal)
        Me.grpFatura.Controls.Add(Me.lblValorOriginal)
        Me.grpFatura.Controls.Add(Me.txtFatura)
        Me.grpFatura.Controls.Add(Me.lblFatura)
        Me.grpFatura.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFatura.Location = New System.Drawing.Point(8, 3)
        Me.grpFatura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFatura.Name = "grpFatura"
        Me.grpFatura.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFatura.Size = New System.Drawing.Size(602, 67)
        Me.grpFatura.TabIndex = 0
        Me.grpFatura.Text = "Fatura"
        Me.grpFatura.VisualStyleManager = Me.vsmMain
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDesconto.Location = New System.Drawing.Point(403, 37)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.Size = New System.Drawing.Size(92, 20)
        Me.txtValorDesconto.TabIndex = 5
        Me.txtValorDesconto.Text = "0,00"
        Me.txtValorDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorLiquido
        '
        Me.txtValorLiquido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorLiquido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorLiquido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorLiquido.Location = New System.Drawing.Point(501, 37)
        Me.txtValorLiquido.Name = "txtValorLiquido"
        Me.txtValorLiquido.ReadOnly = True
        Me.txtValorLiquido.Size = New System.Drawing.Size(92, 20)
        Me.txtValorLiquido.TabIndex = 7
        Me.txtValorLiquido.TabStop = False
        Me.txtValorLiquido.Text = "0,00"
        Me.txtValorLiquido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorLiquido
        '
        Me.lblValorLiquido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorLiquido.AutoSize = True
        Me.lblValorLiquido.Location = New System.Drawing.Point(498, 20)
        Me.lblValorLiquido.Name = "lblValorLiquido"
        Me.lblValorLiquido.Size = New System.Drawing.Size(72, 14)
        Me.lblValorLiquido.TabIndex = 6
        Me.lblValorLiquido.Text = "Valor Líquido:"
        '
        'lblValorDesconto
        '
        Me.lblValorDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorDesconto.AutoSize = True
        Me.lblValorDesconto.Location = New System.Drawing.Point(400, 20)
        Me.lblValorDesconto.Name = "lblValorDesconto"
        Me.lblValorDesconto.Size = New System.Drawing.Size(84, 14)
        Me.lblValorDesconto.TabIndex = 4
        Me.lblValorDesconto.Text = "Valor Desconto:"
        '
        'txtValorOriginal
        '
        Me.txtValorOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorOriginal.Location = New System.Drawing.Point(305, 37)
        Me.txtValorOriginal.Name = "txtValorOriginal"
        Me.txtValorOriginal.Size = New System.Drawing.Size(92, 20)
        Me.txtValorOriginal.TabIndex = 3
        Me.txtValorOriginal.Text = "0,00"
        Me.txtValorOriginal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorOriginal
        '
        Me.lblValorOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorOriginal.AutoSize = True
        Me.lblValorOriginal.Location = New System.Drawing.Point(302, 20)
        Me.lblValorOriginal.Name = "lblValorOriginal"
        Me.lblValorOriginal.Size = New System.Drawing.Size(74, 14)
        Me.lblValorOriginal.TabIndex = 2
        Me.lblValorOriginal.Text = "Valor Original:"
        '
        'txtFatura
        '
        Me.txtFatura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFatura.Location = New System.Drawing.Point(9, 37)
        Me.txtFatura.MaxLength = 60
        Me.txtFatura.Name = "txtFatura"
        Me.txtFatura.Size = New System.Drawing.Size(290, 20)
        Me.txtFatura.TabIndex = 1
        '
        'lblFatura
        '
        Me.lblFatura.AutoSize = True
        Me.lblFatura.Location = New System.Drawing.Point(6, 20)
        Me.lblFatura.Name = "lblFatura"
        Me.lblFatura.Size = New System.Drawing.Size(41, 14)
        Me.lblFatura.TabIndex = 0
        Me.lblFatura.Text = "Fatura:"
        '
        'usrCmpRecebimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpRecebimento"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpRecebimento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRecebimento.ResumeLayout(False)
        Me.grpRecebimento.PerformLayout()
        CType(Me.grpFiltro2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro2.ResumeLayout(False)
        Me.grpFiltro2.PerformLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagItem.ResumeLayout(False)
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEstoque.ResumeLayout(False)
        Me.grpEstoque.PerformLayout()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagFatura.ResumeLayout(False)
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDuplicata.ResumeLayout(False)
        Me.grpDuplicata.PerformLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFatura.ResumeLayout(False)
        Me.grpFatura.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarPedido As Janus.Windows.EditControls.UIButton
    Private WithEvents btnConfirmarRecebimento As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboNumeroPedido As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents grpRecebimento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataRecebimento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataRecebimento As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagItem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdItem As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagFatura As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDuplicata As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCalcularDuplicata As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtIntervaloEntreParcelas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloEntreParcelas As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroParcela As System.Windows.Forms.Label
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdDuplicata As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFatura As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorLiquido As System.Windows.Forms.Label
    Friend WithEvents lblValorDesconto As System.Windows.Forms.Label
    Friend WithEvents txtValorOriginal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOriginal As System.Windows.Forms.Label
    Friend WithEvents txtFatura As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFatura As System.Windows.Forms.Label
    Friend WithEvents txtValorDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorLiquido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItemFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataRecebimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataRecebimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumeroPedidoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataRecebimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblTipoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgruparGridItem As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridItem As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpEstoque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnExcluirEstoque As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirEstoque As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdEstoque As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboProdutoKit As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblProdutoKit As System.Windows.Forms.Label

End Class
