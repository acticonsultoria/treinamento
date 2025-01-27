<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVenInvoice
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVenInvoice))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdPedido_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPedido_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgrupaGrid = New System.Windows.Forms.Button()
        Me.btnConfiguraGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarClienteFiltro = New System.Windows.Forms.Button()
        Me.dtpDataInvoiceInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInvoiceTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroInvoiceFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataInvoiceFiltro = New System.Windows.Forms.Label()
        Me.txtPedidoVendaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPedidoVendaFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagPedido = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridPedido = New System.Windows.Forms.Button()
        Me.btnAgruparGridPedido = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPedido = New System.Windows.Forms.Button()
        Me.grdPedido = New Janus.Windows.GridEX.GridEX()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpPayment = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtBanco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigoIBAN = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.lblCodigoIBAN = New System.Windows.Forms.Label()
        Me.lblSwiftCodeBanco = New System.Windows.Forms.Label()
        Me.txtBranchNumber = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSwiftCodeBanco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBranchNumber = New System.Windows.Forms.Label()
        Me.lblNumeroConta = New System.Windows.Forms.Label()
        Me.txtSwiftCode = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroConta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSwiftCode = New System.Windows.Forms.Label()
        Me.txtFavorecido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFavorecido = New System.Windows.Forms.Label()
        Me.grpDadosInvoice = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtImportadora = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtMeioTransporte = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReceptorMercadoria = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtCondicaoPagamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtPagadora = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPaisOrigem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtEmbarque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMoeda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDesembarque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIncoterm = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpTotais = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtVolume = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPesoGrosso = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPesoLiquido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtValorFinal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtValorSeguro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtValorFrete = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblData = New System.Windows.Forms.Label()
        Me.txtNumeroInvoice = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportarPedido = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagPedido.SuspendLayout()
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayment.SuspendLayout()
        CType(Me.grpDadosInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosInvoice.SuspendLayout()
        CType(Me.grpTotais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTotais.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1057, 655)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgrupaGrid)
        Me.pagListagem.Controls.Add(Me.btnConfiguraGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(1055, 632)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Invoice"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(60, 548)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 96
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgrupaGrid
        '
        Me.btnAgrupaGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgrupaGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgrupaGrid.FlatAppearance.BorderSize = 0
        Me.btnAgrupaGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgrupaGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgrupaGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgrupaGrid.Location = New System.Drawing.Point(36, 548)
        Me.btnAgrupaGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgrupaGrid.Name = "btnAgrupaGrid"
        Me.btnAgrupaGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgrupaGrid.TabIndex = 95
        Me.btnAgrupaGrid.TabStop = False
        Me.btnAgrupaGrid.UseVisualStyleBackColor = False
        '
        'btnConfiguraGrid
        '
        Me.btnConfiguraGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGrid.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfiguraGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGrid.Location = New System.Drawing.Point(12, 548)
        Me.btnConfiguraGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGrid.Name = "btnConfiguraGrid"
        Me.btnConfiguraGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGrid.TabIndex = 94
        Me.btnConfiguraGrid.TabStop = False
        Me.btnConfiguraGrid.UseVisualStyleBackColor = False
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
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 77)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1038, 488)
        Me.grdListagem.TabIndex = 93
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
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInvoiceInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInvoiceTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroInvoiceFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataInvoiceFiltro)
        Me.grpFiltro.Controls.Add(Me.txtPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPedidoVendaFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1039, 69)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClienteFiltro.AutoSize = False
        Me.cboClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFiltro.Location = New System.Drawing.Point(447, 34)
        Me.cboClienteFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(436, 20)
        Me.cboClienteFiltro.TabIndex = 4
        '
        'btnProcurarClienteFiltro
        '
        Me.btnProcurarClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarClienteFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarClienteFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarClienteFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarClienteFiltro.Location = New System.Drawing.Point(866, 16)
        Me.btnProcurarClienteFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarClienteFiltro.Name = "btnProcurarClienteFiltro"
        Me.btnProcurarClienteFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarClienteFiltro.TabIndex = 9
        Me.btnProcurarClienteFiltro.TabStop = False
        Me.btnProcurarClienteFiltro.UseVisualStyleBackColor = True
        '
        'dtpDataInvoiceInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInvoiceInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInvoiceInicioFiltro.Location = New System.Drawing.Point(115, 34)
        Me.dtpDataInvoiceInicioFiltro.Name = "dtpDataInvoiceInicioFiltro"
        Me.dtpDataInvoiceInicioFiltro.ShowCheckBox = True
        Me.dtpDataInvoiceInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInvoiceInicioFiltro.TabIndex = 1
        '
        'dtpDataInvoiceTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataInvoiceTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInvoiceTerminoFiltro.Location = New System.Drawing.Point(228, 34)
        Me.dtpDataInvoiceTerminoFiltro.Name = "dtpDataInvoiceTerminoFiltro"
        Me.dtpDataInvoiceTerminoFiltro.ShowCheckBox = True
        Me.dtpDataInvoiceTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInvoiceTerminoFiltro.TabIndex = 2
        '
        'txtNumeroInvoiceFiltro
        '
        Me.txtNumeroInvoiceFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroInvoiceFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroInvoiceFiltro.MaxLength = 20
        Me.txtNumeroInvoiceFiltro.Name = "txtNumeroInvoiceFiltro"
        Me.txtNumeroInvoiceFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroInvoiceFiltro.TabIndex = 0
        '
        'lblNumeroPedidoFiltro
        '
        Me.lblNumeroPedidoFiltro.AutoSize = True
        Me.lblNumeroPedidoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroPedidoFiltro.Name = "lblNumeroPedidoFiltro"
        Me.lblNumeroPedidoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblNumeroPedidoFiltro.TabIndex = 0
        Me.lblNumeroPedidoFiltro.Text = "Nº Invoice:"
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(444, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 7
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(939, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 5
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataInvoiceFiltro
        '
        Me.lblDataInvoiceFiltro.AutoSize = True
        Me.lblDataInvoiceFiltro.Location = New System.Drawing.Point(112, 17)
        Me.lblDataInvoiceFiltro.Name = "lblDataInvoiceFiltro"
        Me.lblDataInvoiceFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataInvoiceFiltro.TabIndex = 2
        Me.lblDataInvoiceFiltro.Text = "Data:"
        '
        'txtPedidoVendaFiltro
        '
        Me.txtPedidoVendaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPedidoVendaFiltro.Location = New System.Drawing.Point(342, 34)
        Me.txtPedidoVendaFiltro.MaxLength = 3
        Me.txtPedidoVendaFiltro.Name = "txtPedidoVendaFiltro"
        Me.txtPedidoVendaFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtPedidoVendaFiltro.TabIndex = 3
        '
        'lblPedidoVendaFiltro
        '
        Me.lblPedidoVendaFiltro.AutoSize = True
        Me.lblPedidoVendaFiltro.Location = New System.Drawing.Point(339, 17)
        Me.lblPedidoVendaFiltro.Name = "lblPedidoVendaFiltro"
        Me.lblPedidoVendaFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblPedidoVendaFiltro.TabIndex = 5
        Me.lblPedidoVendaFiltro.Text = "Pedido de Venda:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Controls.Add(Me.btnNovo)
        Me.grpControle.Location = New System.Drawing.Point(8, 572)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(1039, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(939, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(842, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpInformacoes)
        Me.pagDados.Controls.Add(Me.grdControlesEdicao)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(1055, 632)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Invoice"
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
        Me.tabDados.Size = New System.Drawing.Size(1039, 493)
        Me.tabDados.TabIndex = 0
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagPedido, Me.pagDadosGerais})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagPedido
        '
        Me.pagPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagPedido.Controls.Add(Me.btnExcelGridPedido)
        Me.pagPedido.Controls.Add(Me.btnAgruparGridPedido)
        Me.pagPedido.Controls.Add(Me.btnConfigurarGridPedido)
        Me.pagPedido.Controls.Add(Me.grdPedido)
        Me.pagPedido.Key = "pagPedido"
        Me.pagPedido.Location = New System.Drawing.Point(1, 22)
        Me.pagPedido.Name = "pagPedido"
        Me.pagPedido.Size = New System.Drawing.Size(1037, 470)
        Me.pagPedido.TabStop = True
        Me.pagPedido.Text = "Pedido"
        '
        'btnExcelGridPedido
        '
        Me.btnExcelGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPedido.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPedido.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPedido.Location = New System.Drawing.Point(53, 448)
        Me.btnExcelGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPedido.Name = "btnExcelGridPedido"
        Me.btnExcelGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPedido.TabIndex = 3
        Me.btnExcelGridPedido.TabStop = False
        Me.btnExcelGridPedido.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPedido
        '
        Me.btnAgruparGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPedido.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPedido.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPedido.Location = New System.Drawing.Point(33, 448)
        Me.btnAgruparGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPedido.Name = "btnAgruparGridPedido"
        Me.btnAgruparGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPedido.TabIndex = 2
        Me.btnAgruparGridPedido.TabStop = False
        Me.btnAgruparGridPedido.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPedido
        '
        Me.btnConfigurarGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPedido.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPedido.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPedido.Location = New System.Drawing.Point(11, 448)
        Me.btnConfigurarGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPedido.Name = "btnConfigurarGridPedido"
        Me.btnConfigurarGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPedido.TabIndex = 1
        Me.btnConfigurarGridPedido.TabStop = False
        Me.btnConfigurarGridPedido.UseVisualStyleBackColor = False
        '
        'grdPedido
        '
        Me.grdPedido.AllowChildTableGroups = True
        Me.grdPedido.AlternatingColors = True
        Me.grdPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPedido.AutoEdit = True
        grdPedido_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdPedido_DesignTimeLayout_Reference_0.Instance"), Object)
        grdPedido_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdPedido_DesignTimeLayout_Reference_0})
        grdPedido_DesignTimeLayout.LayoutString = resources.GetString("grdPedido_DesignTimeLayout.LayoutString")
        Me.grdPedido.DesignTimeLayout = grdPedido_DesignTimeLayout
        Me.grdPedido.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPedido.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedido.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedido.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedido.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdPedido.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedido.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPedido.FrozenColumns = 2
        Me.grdPedido.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedido.GroupByBoxVisible = False
        Me.grdPedido.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPedido.Hierarchical = True
        Me.grdPedido.Location = New System.Drawing.Point(8, 3)
        Me.grdPedido.Name = "grdPedido"
        Me.grdPedido.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedido.RecordNavigator = True
        Me.grdPedido.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdPedido.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPedido.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPedido.Size = New System.Drawing.Size(1021, 462)
        Me.grdPedido.TabIndex = 8
        Me.grdPedido.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedido.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdPedido.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdPedido.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPedido.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPedido.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedido.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPedido.UpdateOnLeave = False
        Me.grdPedido.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedido.VisualStyleManager = Me.vsmMain
        '
        'pagDadosGerais
        '
        Me.pagDadosGerais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagDadosGerais.Controls.Add(Me.grpPayment)
        Me.pagDadosGerais.Controls.Add(Me.grpDadosInvoice)
        Me.pagDadosGerais.Controls.Add(Me.grpTotais)
        Me.pagDadosGerais.Key = "pagItem"
        Me.pagDadosGerais.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.Size = New System.Drawing.Size(1037, 470)
        Me.pagDadosGerais.TabStop = True
        Me.pagDadosGerais.Text = "Invoice"
        '
        'grpPayment
        '
        Me.grpPayment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPayment.BackColor = System.Drawing.Color.Transparent
        Me.grpPayment.Controls.Add(Me.txtBanco)
        Me.grpPayment.Controls.Add(Me.txtCodigoIBAN)
        Me.grpPayment.Controls.Add(Me.lblBanco)
        Me.grpPayment.Controls.Add(Me.lblCodigoIBAN)
        Me.grpPayment.Controls.Add(Me.lblSwiftCodeBanco)
        Me.grpPayment.Controls.Add(Me.txtBranchNumber)
        Me.grpPayment.Controls.Add(Me.txtSwiftCodeBanco)
        Me.grpPayment.Controls.Add(Me.lblBranchNumber)
        Me.grpPayment.Controls.Add(Me.lblNumeroConta)
        Me.grpPayment.Controls.Add(Me.txtSwiftCode)
        Me.grpPayment.Controls.Add(Me.txtNumeroConta)
        Me.grpPayment.Controls.Add(Me.lblSwiftCode)
        Me.grpPayment.Controls.Add(Me.txtFavorecido)
        Me.grpPayment.Controls.Add(Me.lblFavorecido)
        Me.grpPayment.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPayment.Location = New System.Drawing.Point(5, 217)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPayment.Size = New System.Drawing.Size(1024, 101)
        Me.grpPayment.TabIndex = 14
        Me.grpPayment.Text = "Payment"
        Me.grpPayment.VisualStyleManager = Me.vsmMain
        '
        'txtBanco
        '
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Location = New System.Drawing.Point(9, 33)
        Me.txtBanco.MaxLength = 0
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(246, 20)
        Me.txtBanco.TabIndex = 0
        '
        'txtCodigoIBAN
        '
        Me.txtCodigoIBAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoIBAN.Location = New System.Drawing.Point(512, 74)
        Me.txtCodigoIBAN.MaxLength = 0
        Me.txtCodigoIBAN.Name = "txtCodigoIBAN"
        Me.txtCodigoIBAN.Size = New System.Drawing.Size(250, 20)
        Me.txtCodigoIBAN.TabIndex = 6
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(6, 16)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(41, 14)
        Me.lblBanco.TabIndex = 39
        Me.lblBanco.Text = "Banco:"
        '
        'lblCodigoIBAN
        '
        Me.lblCodigoIBAN.AutoSize = True
        Me.lblCodigoIBAN.Location = New System.Drawing.Point(509, 57)
        Me.lblCodigoIBAN.Name = "lblCodigoIBAN"
        Me.lblCodigoIBAN.Size = New System.Drawing.Size(62, 14)
        Me.lblCodigoIBAN.TabIndex = 51
        Me.lblCodigoIBAN.Text = "IBAN Code:"
        '
        'lblSwiftCodeBanco
        '
        Me.lblSwiftCodeBanco.AutoSize = True
        Me.lblSwiftCodeBanco.Location = New System.Drawing.Point(258, 16)
        Me.lblSwiftCodeBanco.Name = "lblSwiftCodeBanco"
        Me.lblSwiftCodeBanco.Size = New System.Drawing.Size(64, 14)
        Me.lblSwiftCodeBanco.TabIndex = 41
        Me.lblSwiftCodeBanco.Text = "Swift Code:"
        '
        'txtBranchNumber
        '
        Me.txtBranchNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBranchNumber.Location = New System.Drawing.Point(261, 74)
        Me.txtBranchNumber.MaxLength = 0
        Me.txtBranchNumber.Name = "txtBranchNumber"
        Me.txtBranchNumber.Size = New System.Drawing.Size(245, 20)
        Me.txtBranchNumber.TabIndex = 5
        '
        'txtSwiftCodeBanco
        '
        Me.txtSwiftCodeBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSwiftCodeBanco.Location = New System.Drawing.Point(261, 33)
        Me.txtSwiftCodeBanco.MaxLength = 0
        Me.txtSwiftCodeBanco.Name = "txtSwiftCodeBanco"
        Me.txtSwiftCodeBanco.Size = New System.Drawing.Size(245, 20)
        Me.txtSwiftCodeBanco.TabIndex = 1
        '
        'lblBranchNumber
        '
        Me.lblBranchNumber.AutoSize = True
        Me.lblBranchNumber.Location = New System.Drawing.Point(258, 57)
        Me.lblBranchNumber.Name = "lblBranchNumber"
        Me.lblBranchNumber.Size = New System.Drawing.Size(84, 14)
        Me.lblBranchNumber.TabIndex = 49
        Me.lblBranchNumber.Text = "Branch number:"
        '
        'lblNumeroConta
        '
        Me.lblNumeroConta.AutoSize = True
        Me.lblNumeroConta.Location = New System.Drawing.Point(509, 16)
        Me.lblNumeroConta.Name = "lblNumeroConta"
        Me.lblNumeroConta.Size = New System.Drawing.Size(67, 14)
        Me.lblNumeroConta.TabIndex = 43
        Me.lblNumeroConta.Text = "Account nr: "
        '
        'txtSwiftCode
        '
        Me.txtSwiftCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSwiftCode.Location = New System.Drawing.Point(9, 74)
        Me.txtSwiftCode.MaxLength = 0
        Me.txtSwiftCode.Name = "txtSwiftCode"
        Me.txtSwiftCode.Size = New System.Drawing.Size(246, 20)
        Me.txtSwiftCode.TabIndex = 4
        '
        'txtNumeroConta
        '
        Me.txtNumeroConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroConta.Location = New System.Drawing.Point(512, 33)
        Me.txtNumeroConta.MaxLength = 0
        Me.txtNumeroConta.Name = "txtNumeroConta"
        Me.txtNumeroConta.Size = New System.Drawing.Size(250, 20)
        Me.txtNumeroConta.TabIndex = 2
        '
        'lblSwiftCode
        '
        Me.lblSwiftCode.AutoSize = True
        Me.lblSwiftCode.Location = New System.Drawing.Point(6, 57)
        Me.lblSwiftCode.Name = "lblSwiftCode"
        Me.lblSwiftCode.Size = New System.Drawing.Size(63, 14)
        Me.lblSwiftCode.TabIndex = 47
        Me.lblSwiftCode.Text = "Swift code:"
        '
        'txtFavorecido
        '
        Me.txtFavorecido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFavorecido.Location = New System.Drawing.Point(768, 33)
        Me.txtFavorecido.MaxLength = 0
        Me.txtFavorecido.Name = "txtFavorecido"
        Me.txtFavorecido.Size = New System.Drawing.Size(238, 20)
        Me.txtFavorecido.TabIndex = 3
        '
        'lblFavorecido
        '
        Me.lblFavorecido.AutoSize = True
        Me.lblFavorecido.Location = New System.Drawing.Point(765, 16)
        Me.lblFavorecido.Name = "lblFavorecido"
        Me.lblFavorecido.Size = New System.Drawing.Size(60, 14)
        Me.lblFavorecido.TabIndex = 45
        Me.lblFavorecido.Text = "In favor of:"
        '
        'grpDadosInvoice
        '
        Me.grpDadosInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosInvoice.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosInvoice.Controls.Add(Me.txtImportadora)
        Me.grpDadosInvoice.Controls.Add(Me.Label4)
        Me.grpDadosInvoice.Controls.Add(Me.txtObservacao)
        Me.grpDadosInvoice.Controls.Add(Me.txtMeioTransporte)
        Me.grpDadosInvoice.Controls.Add(Me.Label11)
        Me.grpDadosInvoice.Controls.Add(Me.Label8)
        Me.grpDadosInvoice.Controls.Add(Me.txtReceptorMercadoria)
        Me.grpDadosInvoice.Controls.Add(Me.txtCondicaoPagamento)
        Me.grpDadosInvoice.Controls.Add(Me.Label3)
        Me.grpDadosInvoice.Controls.Add(Me.lblObservacao)
        Me.grpDadosInvoice.Controls.Add(Me.txtPagadora)
        Me.grpDadosInvoice.Controls.Add(Me.Label1)
        Me.grpDadosInvoice.Controls.Add(Me.Label5)
        Me.grpDadosInvoice.Controls.Add(Me.txtPaisOrigem)
        Me.grpDadosInvoice.Controls.Add(Me.txtEmbarque)
        Me.grpDadosInvoice.Controls.Add(Me.Label10)
        Me.grpDadosInvoice.Controls.Add(Me.Label6)
        Me.grpDadosInvoice.Controls.Add(Me.txtMoeda)
        Me.grpDadosInvoice.Controls.Add(Me.txtDesembarque)
        Me.grpDadosInvoice.Controls.Add(Me.Label9)
        Me.grpDadosInvoice.Controls.Add(Me.Label7)
        Me.grpDadosInvoice.Controls.Add(Me.txtIncoterm)
        Me.grpDadosInvoice.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosInvoice.Location = New System.Drawing.Point(5, 3)
        Me.grpDadosInvoice.Name = "grpDadosInvoice"
        Me.grpDadosInvoice.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosInvoice.Size = New System.Drawing.Size(1024, 208)
        Me.grpDadosInvoice.TabIndex = 0
        Me.grpDadosInvoice.Text = "Dados"
        Me.grpDadosInvoice.VisualStyleManager = Me.vsmMain
        '
        'txtImportadora
        '
        Me.txtImportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImportadora.Location = New System.Drawing.Point(9, 33)
        Me.txtImportadora.MaxLength = 0
        Me.txtImportadora.Multiline = True
        Me.txtImportadora.Name = "txtImportadora"
        Me.txtImportadora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImportadora.Size = New System.Drawing.Size(246, 81)
        Me.txtImportadora.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Means of Transportation:"
        '
        'txtObservacao
        '
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(768, 33)
        Me.txtObservacao.MaxLength = 0
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(238, 81)
        Me.txtObservacao.TabIndex = 4
        '
        'txtMeioTransporte
        '
        Me.txtMeioTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMeioTransporte.Location = New System.Drawing.Point(9, 135)
        Me.txtMeioTransporte.MaxLength = 0
        Me.txtMeioTransporte.Name = "txtMeioTransporte"
        Me.txtMeioTransporte.Size = New System.Drawing.Size(246, 20)
        Me.txtMeioTransporte.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(765, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 14)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Observation Invoice:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 14)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Payment Condition:"
        '
        'txtReceptorMercadoria
        '
        Me.txtReceptorMercadoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceptorMercadoria.Location = New System.Drawing.Point(512, 33)
        Me.txtReceptorMercadoria.MaxLength = 0
        Me.txtReceptorMercadoria.Multiline = True
        Me.txtReceptorMercadoria.Name = "txtReceptorMercadoria"
        Me.txtReceptorMercadoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReceptorMercadoria.Size = New System.Drawing.Size(250, 81)
        Me.txtReceptorMercadoria.TabIndex = 3
        '
        'txtCondicaoPagamento
        '
        Me.txtCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCondicaoPagamento.Location = New System.Drawing.Point(9, 176)
        Me.txtCondicaoPagamento.MaxLength = 0
        Me.txtCondicaoPagamento.Name = "txtCondicaoPagamento"
        Me.txtCondicaoPagamento.Size = New System.Drawing.Size(246, 20)
        Me.txtCondicaoPagamento.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(509, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Receiver's Merchandise:"
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 16)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(49, 14)
        Me.lblObservacao.TabIndex = 0
        Me.lblObservacao.Text = "Importer:"
        '
        'txtPagadora
        '
        Me.txtPagadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPagadora.Location = New System.Drawing.Point(261, 33)
        Me.txtPagadora.MaxLength = 0
        Me.txtPagadora.Multiline = True
        Me.txtPagadora.Name = "txtPagadora"
        Me.txtPagadora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPagadora.Size = New System.Drawing.Size(245, 81)
        Me.txtPagadora.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Payer:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(258, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Port of Loading:"
        '
        'txtPaisOrigem
        '
        Me.txtPaisOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaisOrigem.Location = New System.Drawing.Point(512, 176)
        Me.txtPaisOrigem.MaxLength = 0
        Me.txtPaisOrigem.Name = "txtPaisOrigem"
        Me.txtPaisOrigem.Size = New System.Drawing.Size(250, 20)
        Me.txtPaisOrigem.TabIndex = 11
        '
        'txtEmbarque
        '
        Me.txtEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmbarque.Location = New System.Drawing.Point(261, 135)
        Me.txtEmbarque.MaxLength = 0
        Me.txtEmbarque.Name = "txtEmbarque"
        Me.txtEmbarque.Size = New System.Drawing.Size(245, 20)
        Me.txtEmbarque.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(509, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 14)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Country of Origin:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(509, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 14)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Destination Port:"
        '
        'txtMoeda
        '
        Me.txtMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMoeda.Location = New System.Drawing.Point(261, 176)
        Me.txtMoeda.MaxLength = 0
        Me.txtMoeda.Name = "txtMoeda"
        Me.txtMoeda.Size = New System.Drawing.Size(245, 20)
        Me.txtMoeda.TabIndex = 10
        '
        'txtDesembarque
        '
        Me.txtDesembarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesembarque.Location = New System.Drawing.Point(512, 135)
        Me.txtDesembarque.MaxLength = 0
        Me.txtDesembarque.Name = "txtDesembarque"
        Me.txtDesembarque.Size = New System.Drawing.Size(250, 20)
        Me.txtDesembarque.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(258, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 14)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Currency:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(765, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Incoterm:"
        '
        'txtIncoterm
        '
        Me.txtIncoterm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIncoterm.Location = New System.Drawing.Point(768, 135)
        Me.txtIncoterm.MaxLength = 0
        Me.txtIncoterm.Name = "txtIncoterm"
        Me.txtIncoterm.Size = New System.Drawing.Size(238, 20)
        Me.txtIncoterm.TabIndex = 8
        '
        'grpTotais
        '
        Me.grpTotais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTotais.BackColor = System.Drawing.Color.Transparent
        Me.grpTotais.Controls.Add(Me.txtValorTotal)
        Me.grpTotais.Controls.Add(Me.Label25)
        Me.grpTotais.Controls.Add(Me.txtVolume)
        Me.grpTotais.Controls.Add(Me.Label21)
        Me.grpTotais.Controls.Add(Me.txtPesoGrosso)
        Me.grpTotais.Controls.Add(Me.Label22)
        Me.grpTotais.Controls.Add(Me.txtPesoLiquido)
        Me.grpTotais.Controls.Add(Me.Label23)
        Me.grpTotais.Controls.Add(Me.txtValorFinal)
        Me.grpTotais.Controls.Add(Me.Label20)
        Me.grpTotais.Controls.Add(Me.txtValorSeguro)
        Me.grpTotais.Controls.Add(Me.Label19)
        Me.grpTotais.Controls.Add(Me.txtValorFrete)
        Me.grpTotais.Controls.Add(Me.Label24)
        Me.grpTotais.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpTotais.Location = New System.Drawing.Point(5, 324)
        Me.grpTotais.Name = "grpTotais"
        Me.grpTotais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTotais.Size = New System.Drawing.Size(1024, 69)
        Me.grpTotais.TabIndex = 1
        Me.grpTotais.Text = "Totais"
        Me.grpTotais.VisualStyleManager = Me.vsmMain
        '
        'txtValorTotal
        '
        Me.txtValorTotal.DecimalDigits = 2
        Me.txtValorTotal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtValorTotal.Location = New System.Drawing.Point(371, 39)
        Me.txtValorTotal.MaxLength = 0
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(116, 20)
        Me.txtValorTotal.TabIndex = 3
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = 0.0R
        Me.txtValorTotal.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(370, 22)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 14)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "Total:"
        '
        'txtVolume
        '
        Me.txtVolume.DecimalDigits = 2
        Me.txtVolume.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtVolume.Location = New System.Drawing.Point(251, 39)
        Me.txtVolume.MaxLength = 0
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(116, 20)
        Me.txtVolume.TabIndex = 2
        Me.txtVolume.Text = "0,00"
        Me.txtVolume.Value = 0.0R
        Me.txtVolume.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(250, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 14)
        Me.Label21.TabIndex = 66
        Me.Label21.Text = "Total Volume (m³):"
        '
        'txtPesoGrosso
        '
        Me.txtPesoGrosso.DecimalDigits = 2
        Me.txtPesoGrosso.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPesoGrosso.Location = New System.Drawing.Point(129, 39)
        Me.txtPesoGrosso.MaxLength = 0
        Me.txtPesoGrosso.Name = "txtPesoGrosso"
        Me.txtPesoGrosso.Size = New System.Drawing.Size(116, 20)
        Me.txtPesoGrosso.TabIndex = 1
        Me.txtPesoGrosso.Text = "0,00"
        Me.txtPesoGrosso.Value = 0.0R
        Me.txtPesoGrosso.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(128, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(101, 14)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Total Gross Weight:"
        '
        'txtPesoLiquido
        '
        Me.txtPesoLiquido.DecimalDigits = 2
        Me.txtPesoLiquido.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPesoLiquido.Location = New System.Drawing.Point(8, 39)
        Me.txtPesoLiquido.MaxLength = 0
        Me.txtPesoLiquido.Name = "txtPesoLiquido"
        Me.txtPesoLiquido.Size = New System.Drawing.Size(116, 20)
        Me.txtPesoLiquido.TabIndex = 0
        Me.txtPesoLiquido.Text = "0,00"
        Me.txtPesoLiquido.Value = 0.0R
        Me.txtPesoLiquido.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 14)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Total Net Weight:"
        '
        'txtValorFinal
        '
        Me.txtValorFinal.DecimalDigits = 2
        Me.txtValorFinal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorFinal.Location = New System.Drawing.Point(736, 39)
        Me.txtValorFinal.MaxLength = 0
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.Size = New System.Drawing.Size(116, 20)
        Me.txtValorFinal.TabIndex = 6
        Me.txtValorFinal.Text = "0,00"
        Me.txtValorFinal.Value = 0.0R
        Me.txtValorFinal.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(735, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 14)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "Total Value:"
        '
        'txtValorSeguro
        '
        Me.txtValorSeguro.DecimalDigits = 2
        Me.txtValorSeguro.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtValorSeguro.Location = New System.Drawing.Point(614, 39)
        Me.txtValorSeguro.MaxLength = 0
        Me.txtValorSeguro.Name = "txtValorSeguro"
        Me.txtValorSeguro.Size = New System.Drawing.Size(116, 20)
        Me.txtValorSeguro.TabIndex = 5
        Me.txtValorSeguro.Text = "0,00"
        Me.txtValorSeguro.Value = 0.0R
        Me.txtValorSeguro.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(613, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 14)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "International Insurance:"
        '
        'txtValorFrete
        '
        Me.txtValorFrete.DecimalDigits = 2
        Me.txtValorFrete.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtValorFrete.Location = New System.Drawing.Point(493, 39)
        Me.txtValorFrete.MaxLength = 0
        Me.txtValorFrete.Name = "txtValorFrete"
        Me.txtValorFrete.Size = New System.Drawing.Size(115, 20)
        Me.txtValorFrete.TabIndex = 4
        Me.txtValorFrete.Text = "0,00"
        Me.txtValorFrete.Value = 0.0R
        Me.txtValorFrete.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(492, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 14)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "International Freight:"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.btnProcurarCliente)
        Me.grpInformacoes.Controls.Add(Me.lblCliente)
        Me.grpInformacoes.Controls.Add(Me.cboCliente)
        Me.grpInformacoes.Controls.Add(Me.dtpData)
        Me.grpInformacoes.Controls.Add(Me.lblData)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroInvoice)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroPedido)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(1039, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(356, 16)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 12
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(112, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 11
        Me.lblCliente.Text = "Cliente:"
        '
        'cboCliente
        '
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboCliente.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCliente.Location = New System.Drawing.Point(115, 34)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(258, 20)
        Me.cboCliente.TabIndex = 1
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(379, 34)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(93, 20)
        Me.dtpData.TabIndex = 2
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(376, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(69, 14)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data Invoice:"
        '
        'txtNumeroInvoice
        '
        Me.txtNumeroInvoice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroInvoice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroInvoice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroInvoice.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroInvoice.MaxLength = 20
        Me.txtNumeroInvoice.Name = "txtNumeroInvoice"
        Me.txtNumeroInvoice.ReadOnly = True
        Me.txtNumeroInvoice.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroInvoice.TabIndex = 0
        Me.txtNumeroInvoice.TabStop = False
        Me.txtNumeroInvoice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(59, 14)
        Me.lblNumeroPedido.TabIndex = 1
        Me.lblNumeroPedido.Text = "Nº Invoice:"
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnImportarPedido)
        Me.grdControlesEdicao.Controls.Add(Me.btnImprimir)
        Me.grdControlesEdicao.Controls.Add(Me.btnNovo1)
        Me.grdControlesEdicao.Controls.Add(Me.btnVoltar)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(8, 572)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(1039, 51)
        Me.grdControlesEdicao.TabIndex = 0
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnImportarPedido
        '
        Me.btnImportarPedido.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportarPedido.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarPedido.Location = New System.Drawing.Point(6, 17)
        Me.btnImportarPedido.Name = "btnImportarPedido"
        Me.btnImportarPedido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarPedido.Size = New System.Drawing.Size(124, 23)
        Me.btnImportarPedido.TabIndex = 0
        Me.btnImportarPedido.Text = "Importar Pedido"
        Me.btnImportarPedido.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(842, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(648, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 1
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(939, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 4
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(745, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 1
        Me.jstTip.BodyWidth = 400
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 1
        Me.jstTip.ShowAlways = True
        '
        'usrVenInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrVenInvoice"
        Me.Size = New System.Drawing.Size(1057, 655)
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
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagPedido.ResumeLayout(False)
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDadosGerais.ResumeLayout(False)
        CType(Me.grpPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        CType(Me.grpDadosInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosInvoice.ResumeLayout(False)
        Me.grpDadosInvoice.PerformLayout()
        CType(Me.grpTotais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTotais.ResumeLayout(False)
        Me.grpTotais.PerformLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Private WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataInvoiceFiltro As System.Windows.Forms.Label
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtNumeroInvoice As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Private WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroInvoiceFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataInvoiceInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInvoiceTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnProcurarClienteFiltro As System.Windows.Forms.Button
    Friend WithEvents txtPedidoVendaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPedidoVendaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgrupaGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Private WithEvents btnImportarPedido As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridPedido As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPedido As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPedido As System.Windows.Forms.Button
    Friend WithEvents pagPedido As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosInvoice As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtImportadora As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtMeioTransporte As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtReceptorMercadoria As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtCondicaoPagamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtPagadora As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPaisOrigem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtEmbarque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMoeda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDesembarque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIncoterm As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpTotais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtVolume As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPesoGrosso As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPesoLiquido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtValorFinal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtValorSeguro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtValorFrete As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents grpPayment As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtBanco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigoIBAN As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents lblCodigoIBAN As System.Windows.Forms.Label
    Friend WithEvents lblSwiftCodeBanco As System.Windows.Forms.Label
    Friend WithEvents txtBranchNumber As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSwiftCodeBanco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBranchNumber As System.Windows.Forms.Label
    Friend WithEvents lblNumeroConta As System.Windows.Forms.Label
    Friend WithEvents txtSwiftCode As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroConta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSwiftCode As System.Windows.Forms.Label
    Friend WithEvents txtFavorecido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFavorecido As System.Windows.Forms.Label
    Friend WithEvents grdPedido As Janus.Windows.GridEX.GridEX

End Class
