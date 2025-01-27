<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenOrcamentoComposicaoImportarEstrutura
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenOrcamentoComposicaoImportarEstrutura))
        Dim grdGrupo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdMascara_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMascaraGrupo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagOrcamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.SpltContainerOrcamento = New System.Windows.Forms.SplitContainer()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grdGrupo = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroOrcamentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrcamentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataOrcamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataOrcamento = New System.Windows.Forms.Label()
        Me.dtpDataOrcamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblCodigoProdutoFiltro = New System.Windows.Forms.Label()
        Me.cboCodigoProdutoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.pagMascaraOrcamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.SpltContainerMascara = New System.Windows.Forms.SplitContainer()
        Me.grdMascara = New Janus.Windows.GridEX.GridEX()
        Me.grdMascaraGrupo = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltroMascara = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.btnFiltrarMascara = New Janus.Windows.EditControls.UIButton()
        Me.grpSair = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnImportar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagOrcamento.SuspendLayout()
        CType(Me.SpltContainerOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpltContainerOrcamento.Panel1.SuspendLayout()
        Me.SpltContainerOrcamento.Panel2.SuspendLayout()
        Me.SpltContainerOrcamento.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagMascaraOrcamento.SuspendLayout()
        CType(Me.SpltContainerMascara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpltContainerMascara.Panel1.SuspendLayout()
        Me.SpltContainerMascara.Panel2.SuspendLayout()
        Me.SpltContainerMascara.SuspendLayout()
        CType(Me.grdMascara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMascaraGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltroMascara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltroMascara.SuspendLayout()
        CType(Me.grpSair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSair.SuspendLayout()
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
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(945, 489)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagOrcamento, Me.pagMascaraOrcamento})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagOrcamento
        '
        Me.pagOrcamento.Controls.Add(Me.SpltContainerOrcamento)
        Me.pagOrcamento.Controls.Add(Me.grpFiltro)
        Me.pagOrcamento.Key = "pagOrcamento"
        Me.pagOrcamento.Location = New System.Drawing.Point(1, 22)
        Me.pagOrcamento.Name = "pagOrcamento"
        Me.pagOrcamento.Size = New System.Drawing.Size(943, 466)
        Me.pagOrcamento.TabStop = True
        Me.pagOrcamento.Text = "Importar Orçamento"
        '
        'SpltContainerOrcamento
        '
        Me.SpltContainerOrcamento.AllowDrop = True
        Me.SpltContainerOrcamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpltContainerOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpltContainerOrcamento.Location = New System.Drawing.Point(8, 73)
        Me.SpltContainerOrcamento.Name = "SpltContainerOrcamento"
        Me.SpltContainerOrcamento.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SpltContainerOrcamento.Panel1
        '
        Me.SpltContainerOrcamento.Panel1.Controls.Add(Me.grdListagem)
        '
        'SpltContainerOrcamento.Panel2
        '
        Me.SpltContainerOrcamento.Panel2.Controls.Add(Me.grdGrupo)
        Me.SpltContainerOrcamento.Size = New System.Drawing.Size(927, 390)
        Me.SpltContainerOrcamento.SplitterDistance = 236
        Me.SpltContainerOrcamento.TabIndex = 6
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(0, 0)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(925, 234)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grdGrupo
        '
        Me.grdGrupo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdGrupo.AlternatingColors = True
        grdGrupo_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><CellToolTip>TruncatedText</CellToolTip><GroupCondit" & _
    "ion /></RootTable></GridEXLayoutData>"
        Me.grdGrupo.DesignTimeLayout = grdGrupo_DesignTimeLayout
        Me.grdGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdGrupo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdGrupo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdGrupo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdGrupo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdGrupo.FrozenColumns = 2
        Me.grdGrupo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdGrupo.GroupByBoxVisible = False
        Me.grdGrupo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdGrupo.Hierarchical = True
        Me.grdGrupo.Location = New System.Drawing.Point(0, 0)
        Me.grdGrupo.Name = "grdGrupo"
        Me.grdGrupo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdGrupo.RecordNavigator = True
        Me.grdGrupo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdGrupo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdGrupo.Size = New System.Drawing.Size(925, 148)
        Me.grdGrupo.TabIndex = 4
        Me.grdGrupo.TabStop = False
        Me.grdGrupo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdGrupo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdGrupo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdGrupo.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtNumeroOrcamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroOrcamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataOrcamentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataOrcamento)
        Me.grpFiltro.Controls.Add(Me.dtpDataOrcamentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarProduto)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(927, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroOrcamentoFiltro
        '
        Me.txtNumeroOrcamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrcamentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrcamentoFiltro.MaxLength = 20
        Me.txtNumeroOrcamentoFiltro.Name = "txtNumeroOrcamentoFiltro"
        Me.txtNumeroOrcamentoFiltro.Size = New System.Drawing.Size(85, 20)
        Me.txtNumeroOrcamentoFiltro.TabIndex = 0
        '
        'lblNumeroOrcamentoFiltro
        '
        Me.lblNumeroOrcamentoFiltro.AutoSize = True
        Me.lblNumeroOrcamentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrcamentoFiltro.Name = "lblNumeroOrcamentoFiltro"
        Me.lblNumeroOrcamentoFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblNumeroOrcamentoFiltro.TabIndex = 37
        Me.lblNumeroOrcamentoFiltro.Text = "N° Orçamento:"
        '
        'dtpDataOrcamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataOrcamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOrcamentoTerminoFiltro.Location = New System.Drawing.Point(550, 34)
        Me.dtpDataOrcamentoTerminoFiltro.Name = "dtpDataOrcamentoTerminoFiltro"
        Me.dtpDataOrcamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataOrcamentoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataOrcamentoTerminoFiltro.TabIndex = 3
        Me.dtpDataOrcamentoTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataOrcamento
        '
        Me.lblDataOrcamento.AutoSize = True
        Me.lblDataOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.lblDataOrcamento.Location = New System.Drawing.Point(442, 17)
        Me.lblDataOrcamento.Name = "lblDataOrcamento"
        Me.lblDataOrcamento.Size = New System.Drawing.Size(88, 14)
        Me.lblDataOrcamento.TabIndex = 36
        Me.lblDataOrcamento.Text = "Data Orçamento:"
        '
        'dtpDataOrcamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataOrcamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOrcamentoInicioFiltro.Location = New System.Drawing.Point(445, 34)
        Me.dtpDataOrcamentoInicioFiltro.Name = "dtpDataOrcamentoInicioFiltro"
        Me.dtpDataOrcamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataOrcamentoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataOrcamentoInicioFiltro.TabIndex = 2
        Me.dtpDataOrcamentoInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblCodigoProdutoFiltro
        '
        Me.lblCodigoProdutoFiltro.AutoSize = True
        Me.lblCodigoProdutoFiltro.Location = New System.Drawing.Point(97, 17)
        Me.lblCodigoProdutoFiltro.Name = "lblCodigoProdutoFiltro"
        Me.lblCodigoProdutoFiltro.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProdutoFiltro.TabIndex = 32
        Me.lblCodigoProdutoFiltro.Text = "Código Produto:"
        '
        'cboCodigoProdutoFiltro
        '
        Me.cboCodigoProdutoFiltro.AutoSize = False
        Me.cboCodigoProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboCodigoProdutoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCodigoProdutoFiltro.Location = New System.Drawing.Point(100, 34)
        Me.cboCodigoProdutoFiltro.Name = "cboCodigoProdutoFiltro"
        Me.cboCodigoProdutoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProdutoFiltro.Size = New System.Drawing.Size(339, 20)
        Me.cboCodigoProdutoFiltro.TabIndex = 1
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(421, 15)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 33
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(830, 29)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagMascaraOrcamento
        '
        Me.pagMascaraOrcamento.Controls.Add(Me.SpltContainerMascara)
        Me.pagMascaraOrcamento.Controls.Add(Me.grpFiltroMascara)
        Me.pagMascaraOrcamento.Key = "pagMascaraOrcamento"
        Me.pagMascaraOrcamento.Location = New System.Drawing.Point(1, 22)
        Me.pagMascaraOrcamento.Name = "pagMascaraOrcamento"
        Me.pagMascaraOrcamento.Size = New System.Drawing.Size(943, 466)
        Me.pagMascaraOrcamento.TabStop = True
        Me.pagMascaraOrcamento.Text = "Máscara de Orçamento"
        '
        'SpltContainerMascara
        '
        Me.SpltContainerMascara.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpltContainerMascara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpltContainerMascara.Location = New System.Drawing.Point(8, 73)
        Me.SpltContainerMascara.Name = "SpltContainerMascara"
        Me.SpltContainerMascara.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SpltContainerMascara.Panel1
        '
        Me.SpltContainerMascara.Panel1.Controls.Add(Me.grdMascara)
        '
        'SpltContainerMascara.Panel2
        '
        Me.SpltContainerMascara.Panel2.Controls.Add(Me.grdMascaraGrupo)
        Me.SpltContainerMascara.Size = New System.Drawing.Size(927, 390)
        Me.SpltContainerMascara.SplitterDistance = 195
        Me.SpltContainerMascara.TabIndex = 7
        '
        'grdMascara
        '
        Me.grdMascara.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMascara.AlternatingColors = True
        grdMascara_DesignTimeLayout.LayoutString = resources.GetString("grdMascara_DesignTimeLayout.LayoutString")
        Me.grdMascara.DesignTimeLayout = grdMascara_DesignTimeLayout
        Me.grdMascara.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMascara.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMascara.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMascara.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMascara.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMascara.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMascara.GroupByBoxVisible = False
        Me.grdMascara.Hierarchical = True
        Me.grdMascara.Location = New System.Drawing.Point(0, 0)
        Me.grdMascara.Name = "grdMascara"
        Me.grdMascara.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMascara.RecordNavigator = True
        Me.grdMascara.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMascara.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMascara.Size = New System.Drawing.Size(925, 193)
        Me.grdMascara.TabIndex = 5
        Me.grdMascara.TabStop = False
        Me.grdMascara.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMascara.VisualStyleManager = Me.vsmMain
        '
        'grdMascaraGrupo
        '
        Me.grdMascaraGrupo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMascaraGrupo.AlternatingColors = True
        grdMascaraGrupo_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><CellToolTip>TruncatedText</CellToolTip><GroupCondit" & _
    "ion /></RootTable></GridEXLayoutData>"
        Me.grdMascaraGrupo.DesignTimeLayout = grdMascaraGrupo_DesignTimeLayout
        Me.grdMascaraGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMascaraGrupo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMascaraGrupo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMascaraGrupo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMascaraGrupo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdMascaraGrupo.FrozenColumns = 2
        Me.grdMascaraGrupo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMascaraGrupo.GroupByBoxVisible = False
        Me.grdMascaraGrupo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdMascaraGrupo.Hierarchical = True
        Me.grdMascaraGrupo.Location = New System.Drawing.Point(0, 0)
        Me.grdMascaraGrupo.Name = "grdMascaraGrupo"
        Me.grdMascaraGrupo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMascaraGrupo.RecordNavigator = True
        Me.grdMascaraGrupo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMascaraGrupo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMascaraGrupo.Size = New System.Drawing.Size(925, 189)
        Me.grdMascaraGrupo.TabIndex = 6
        Me.grdMascaraGrupo.TabStop = False
        Me.grdMascaraGrupo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMascaraGrupo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMascaraGrupo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMascaraGrupo.VisualStyleManager = Me.vsmMain
        '
        'grpFiltroMascara
        '
        Me.grpFiltroMascara.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltroMascara.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltroMascara.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltroMascara.Controls.Add(Me.lblDescricao)
        Me.grpFiltroMascara.Controls.Add(Me.btnFiltrarMascara)
        Me.grpFiltroMascara.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltroMascara.Name = "grpFiltroMascara"
        Me.grpFiltroMascara.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltroMascara.Size = New System.Drawing.Size(927, 64)
        Me.grpFiltroMascara.TabIndex = 0
        Me.grpFiltroMascara.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltroMascara.VisualStyleManager = Me.vsmMain
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoFiltro.MaxLength = 20
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(319, 20)
        Me.txtDescricaoFiltro.TabIndex = 0
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 37
        Me.lblDescricao.Text = "Descrição:"
        '
        'btnFiltrarMascara
        '
        Me.btnFiltrarMascara.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarMascara.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarMascara.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarMascara.Location = New System.Drawing.Point(830, 29)
        Me.btnFiltrarMascara.Name = "btnFiltrarMascara"
        Me.btnFiltrarMascara.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarMascara.TabIndex = 1
        Me.btnFiltrarMascara.Tag = ""
        Me.btnFiltrarMascara.Text = "Filtrar"
        Me.btnFiltrarMascara.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpSair
        '
        Me.grpSair.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSair.BackColor = System.Drawing.Color.Transparent
        Me.grpSair.Controls.Add(Me.btnNovo)
        Me.grpSair.Controls.Add(Me.btnImportar)
        Me.grpSair.Controls.Add(Me.btnSair)
        Me.grpSair.Location = New System.Drawing.Point(7, 502)
        Me.grpSair.Name = "grpSair"
        Me.grpSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSair.Size = New System.Drawing.Size(945, 51)
        Me.grpSair.TabIndex = 1
        Me.grpSair.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpSair.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.Location = New System.Drawing.Point(651, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar.Location = New System.Drawing.Point(748, 17)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar.Size = New System.Drawing.Size(91, 23)
        Me.btnImportar.TabIndex = 1
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(845, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmVenOrcamentoComposicaoImportarEstrutura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 565)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.grpSair)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmVenOrcamentoComposicaoImportarEstrutura"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importar Orçamento"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagOrcamento.ResumeLayout(False)
        Me.SpltContainerOrcamento.Panel1.ResumeLayout(False)
        Me.SpltContainerOrcamento.Panel2.ResumeLayout(False)
        CType(Me.SpltContainerOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpltContainerOrcamento.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagMascaraOrcamento.ResumeLayout(False)
        Me.SpltContainerMascara.Panel1.ResumeLayout(False)
        Me.SpltContainerMascara.Panel2.ResumeLayout(False)
        CType(Me.SpltContainerMascara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpltContainerMascara.ResumeLayout(False)
        CType(Me.grdMascara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMascaraGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltroMascara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltroMascara.ResumeLayout(False)
        Me.grpFiltroMascara.PerformLayout()
        CType(Me.grpSair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSair.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagOrcamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpSair As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCodigoProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProdutoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents dtpDataOrcamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataOrcamento As System.Windows.Forms.Label
    Friend WithEvents dtpDataOrcamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumeroOrcamentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrcamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdGrupo As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagMascaraOrcamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltroMascara As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarMascara As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdMascaraGrupo As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdMascara As Janus.Windows.GridEX.GridEX
    Private WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents SpltContainerOrcamento As System.Windows.Forms.SplitContainer
    Friend WithEvents SpltContainerMascara As System.Windows.Forms.SplitContainer
End Class
