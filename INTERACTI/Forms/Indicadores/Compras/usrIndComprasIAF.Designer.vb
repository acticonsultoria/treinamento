<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIndComprasIAF
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim grdListagemMensal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIndComprasIAF))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridMensal = New System.Windows.Forms.Button()
        Me.btnAgruparGridMensal = New System.Windows.Forms.Button()
        Me.btnConfigurarGridMensal = New System.Windows.Forms.Button()
        Me.grdListagemMensal = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCategoriaIAF = New System.Windows.Forms.Label()
        Me.cboCategoriaIAF = New Janus.Windows.EditControls.UIComboBox()
        Me.cboMesFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboAnoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
        Me.cboFornecedorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnVisualizarGrafico = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagPlacar = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControlPlacar = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSairPlacar = New Janus.Windows.EditControls.UIButton()
        Me.chrIAFPlacar = New Dundas.Charting.WinControl.Chart()
        Me.grpPlacarFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusPlacarFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblStatusPlacarFiltro = New System.Windows.Forms.Label()
        Me.cboCategoriaPlacarFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCategoriaFiltro = New System.Windows.Forms.Label()
        Me.cboMesPlacarFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboAnoPlacarFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMesPlacarFiltro = New System.Windows.Forms.Label()
        Me.lblAnoPlacarFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrarPlacar = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox6 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.chrIAF = New Dundas.Charting.WinControl.Chart()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagemMensal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagPlacar.SuspendLayout()
        CType(Me.grpControlPlacar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlPlacar.SuspendLayout()
        CType(Me.chrIAFPlacar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPlacarFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlacarFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox6.SuspendLayout()
        CType(Me.chrIAF, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagPlacar, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGridMensal)
        Me.pagListagem.Controls.Add(Me.btnAgruparGridMensal)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGridMensal)
        Me.pagListagem.Controls.Add(Me.grdListagemMensal)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "IAF"
        '
        'btnExcelGridMensal
        '
        Me.btnExcelGridMensal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridMensal.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridMensal.FlatAppearance.BorderSize = 0
        Me.btnExcelGridMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridMensal.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridMensal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridMensal.Location = New System.Drawing.Point(57, 460)
        Me.btnExcelGridMensal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridMensal.Name = "btnExcelGridMensal"
        Me.btnExcelGridMensal.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridMensal.TabIndex = 33
        Me.btnExcelGridMensal.TabStop = False
        Me.btnExcelGridMensal.UseVisualStyleBackColor = False
        '
        'btnAgruparGridMensal
        '
        Me.btnAgruparGridMensal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridMensal.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridMensal.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridMensal.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridMensal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridMensal.Location = New System.Drawing.Point(34, 460)
        Me.btnAgruparGridMensal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridMensal.Name = "btnAgruparGridMensal"
        Me.btnAgruparGridMensal.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridMensal.TabIndex = 32
        Me.btnAgruparGridMensal.TabStop = False
        Me.btnAgruparGridMensal.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridMensal
        '
        Me.btnConfigurarGridMensal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridMensal.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridMensal.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridMensal.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridMensal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridMensal.Location = New System.Drawing.Point(9, 460)
        Me.btnConfigurarGridMensal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridMensal.Name = "btnConfigurarGridMensal"
        Me.btnConfigurarGridMensal.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridMensal.TabIndex = 31
        Me.btnConfigurarGridMensal.TabStop = False
        Me.btnConfigurarGridMensal.UseVisualStyleBackColor = False
        '
        'grdListagemMensal
        '
        Me.grdListagemMensal.AlternatingColors = True
        Me.grdListagemMensal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagemMensal.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagemMensal_DesignTimeLayout.LayoutString = resources.GetString("grdListagemMensal_DesignTimeLayout.LayoutString")
        Me.grdListagemMensal.DesignTimeLayout = grdListagemMensal_DesignTimeLayout
        Me.grdListagemMensal.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemMensal.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagemMensal.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemMensal.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemMensal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemMensal.FrozenColumns = 7
        Me.grdListagemMensal.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemMensal.GroupByBoxVisible = False
        Me.grdListagemMensal.Hierarchical = True
        Me.grdListagemMensal.Location = New System.Drawing.Point(8, 334)
        Me.grdListagemMensal.Name = "grdListagemMensal"
        Me.grdListagemMensal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemMensal.RecordNavigator = True
        Me.grdListagemMensal.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemMensal.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemMensal.Size = New System.Drawing.Size(982, 143)
        Me.grdListagemMensal.TabIndex = 30
        Me.grdListagemMensal.TabStop = False
        Me.grdListagemMensal.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagemMensal.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemMensal.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemMensal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemMensal.VisualStyleManager = Me.vsmMain
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(58, 311)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 29
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(35, 311)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 28
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(10, 311)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 27
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 74)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 254)
        Me.grdListagem.TabIndex = 5
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
        Me.grpFiltro.Controls.Add(Me.lblCategoriaIAF)
        Me.grpFiltro.Controls.Add(Me.cboCategoriaIAF)
        Me.grpFiltro.Controls.Add(Me.cboMesFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAnoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMes)
        Me.grpFiltro.Controls.Add(Me.lblAno)
        Me.grpFiltro.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpFiltro.Controls.Add(Me.cboFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedor)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 67)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblCategoriaIAF
        '
        Me.lblCategoriaIAF.AutoSize = True
        Me.lblCategoriaIAF.Location = New System.Drawing.Point(180, 19)
        Me.lblCategoriaIAF.Name = "lblCategoriaIAF"
        Me.lblCategoriaIAF.Size = New System.Drawing.Size(56, 14)
        Me.lblCategoriaIAF.TabIndex = 35
        Me.lblCategoriaIAF.Text = "Categoria:"
        '
        'cboCategoriaIAF
        '
        Me.cboCategoriaIAF.AutoSize = False
        Me.cboCategoriaIAF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboCategoriaIAF.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCategoriaIAF.Location = New System.Drawing.Point(183, 37)
        Me.cboCategoriaIAF.Name = "cboCategoriaIAF"
        Me.cboCategoriaIAF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCategoriaIAF.Size = New System.Drawing.Size(204, 20)
        Me.cboCategoriaIAF.TabIndex = 2
        '
        'cboMesFiltro
        '
        Me.cboMesFiltro.AutoSize = False
        Me.cboMesFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMesFiltro.Location = New System.Drawing.Point(85, 37)
        Me.cboMesFiltro.Name = "cboMesFiltro"
        Me.cboMesFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMesFiltro.Size = New System.Drawing.Size(92, 20)
        Me.cboMesFiltro.TabIndex = 1
        '
        'cboAnoFiltro
        '
        Me.cboAnoFiltro.AutoSize = False
        Me.cboAnoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAnoFiltro.Location = New System.Drawing.Point(6, 37)
        Me.cboAnoFiltro.Name = "cboAnoFiltro"
        Me.cboAnoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAnoFiltro.Size = New System.Drawing.Size(73, 20)
        Me.cboAnoFiltro.TabIndex = 0
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(82, 20)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(30, 14)
        Me.lblMes.TabIndex = 33
        Me.lblMes.Text = "Mês:"
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(3, 20)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(30, 14)
        Me.lblAno.TabIndex = 31
        Me.lblAno.Text = "Ano:"
        '
        'btnProcurarFornecedor
        '
        Me.btnProcurarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(705, 19)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedor.TabIndex = 30
        Me.btnProcurarFornecedor.TabStop = False
        Me.btnProcurarFornecedor.UseVisualStyleBackColor = True
        '
        'cboFornecedorFiltro
        '
        Me.cboFornecedorFiltro.AutoSize = False
        Me.cboFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboFornecedorFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboFornecedorFiltro.Location = New System.Drawing.Point(393, 37)
        Me.cboFornecedorFiltro.Name = "cboFornecedorFiltro"
        Me.cboFornecedorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedorFiltro.Size = New System.Drawing.Size(331, 20)
        Me.cboFornecedorFiltro.TabIndex = 3
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.lblFornecedor.Location = New System.Drawing.Point(390, 20)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 28
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnImprimir)
        Me.grpControl.Controls.Add(Me.btnVisualizarGrafico)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(685, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVisualizarGrafico
        '
        Me.btnVisualizarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarGrafico.Image = Global.INTERACTI.My.Resources.Resources.grafico
        Me.btnVisualizarGrafico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarGrafico.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnVisualizarGrafico.Location = New System.Drawing.Point(783, 17)
        Me.btnVisualizarGrafico.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnVisualizarGrafico.Name = "btnVisualizarGrafico"
        Me.btnVisualizarGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarGrafico.Size = New System.Drawing.Size(91, 23)
        Me.btnVisualizarGrafico.TabIndex = 1
        Me.btnVisualizarGrafico.Text = "Gráfico"
        Me.btnVisualizarGrafico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagPlacar
        '
        Me.pagPlacar.Controls.Add(Me.grpControlPlacar)
        Me.pagPlacar.Controls.Add(Me.chrIAFPlacar)
        Me.pagPlacar.Controls.Add(Me.grpPlacarFiltro)
        Me.pagPlacar.Key = "pagPlacar"
        Me.pagPlacar.Location = New System.Drawing.Point(1, 22)
        Me.pagPlacar.Name = "pagPlacar"
        Me.pagPlacar.Size = New System.Drawing.Size(998, 543)
        Me.pagPlacar.TabStop = True
        Me.pagPlacar.Text = "Placar"
        '
        'grpControlPlacar
        '
        Me.grpControlPlacar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControlPlacar.BackColor = System.Drawing.Color.Transparent
        Me.grpControlPlacar.Controls.Add(Me.btnSairPlacar)
        Me.grpControlPlacar.Location = New System.Drawing.Point(8, 483)
        Me.grpControlPlacar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpControlPlacar.Name = "grpControlPlacar"
        Me.grpControlPlacar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlPlacar.Size = New System.Drawing.Size(982, 51)
        Me.grpControlPlacar.TabIndex = 8
        Me.grpControlPlacar.VisualStyleManager = Me.vsmMain
        '
        'btnSairPlacar
        '
        Me.btnSairPlacar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSairPlacar.Image = CType(resources.GetObject("btnSairPlacar.Image"), System.Drawing.Image)
        Me.btnSairPlacar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSairPlacar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSairPlacar.Location = New System.Drawing.Point(882, 17)
        Me.btnSairPlacar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSairPlacar.Name = "btnSairPlacar"
        Me.btnSairPlacar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSairPlacar.Size = New System.Drawing.Size(91, 23)
        Me.btnSairPlacar.TabIndex = 0
        Me.btnSairPlacar.Text = "Sair"
        Me.btnSairPlacar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chrIAFPlacar
        '
        Me.chrIAFPlacar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrIAFPlacar.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrIAFPlacar.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrIAFPlacar.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea1.AxisX.Title = "Período (dias)"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Quantidade"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrIAFPlacar.ChartAreas.Add(ChartArea1)
        Legend1.AutoFitText = False
        Legend1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.Name = "Default"
        Me.chrIAFPlacar.Legends.Add(Legend1)
        Me.chrIAFPlacar.Location = New System.Drawing.Point(8, 76)
        Me.chrIAFPlacar.Name = "chrIAFPlacar"
        Me.chrIAFPlacar.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrIAFPlacar.Size = New System.Drawing.Size(982, 401)
        Me.chrIAFPlacar.TabIndex = 7
        Me.chrIAFPlacar.UI.Toolbar.Enabled = True
        '
        'grpPlacarFiltro
        '
        Me.grpPlacarFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPlacarFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpPlacarFiltro.Controls.Add(Me.cboStatusPlacarFiltro)
        Me.grpPlacarFiltro.Controls.Add(Me.lblStatusPlacarFiltro)
        Me.grpPlacarFiltro.Controls.Add(Me.cboCategoriaPlacarFiltro)
        Me.grpPlacarFiltro.Controls.Add(Me.lblCategoriaFiltro)
        Me.grpPlacarFiltro.Controls.Add(Me.cboMesPlacarFiltro)
        Me.grpPlacarFiltro.Controls.Add(Me.cboAnoPlacarFiltro)
        Me.grpPlacarFiltro.Controls.Add(Me.lblMesPlacarFiltro)
        Me.grpPlacarFiltro.Controls.Add(Me.lblAnoPlacarFiltro)
        Me.grpPlacarFiltro.Controls.Add(Me.btnFiltrarPlacar)
        Me.grpPlacarFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPlacarFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpPlacarFiltro.Name = "grpPlacarFiltro"
        Me.grpPlacarFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPlacarFiltro.Size = New System.Drawing.Size(982, 67)
        Me.grpPlacarFiltro.TabIndex = 1
        Me.grpPlacarFiltro.Text = "Filtro"
        Me.grpPlacarFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpPlacarFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusPlacarFiltro
        '
        Me.cboStatusPlacarFiltro.AutoSize = False
        Me.cboStatusPlacarFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusPlacarFiltro.Location = New System.Drawing.Point(383, 37)
        Me.cboStatusPlacarFiltro.Name = "cboStatusPlacarFiltro"
        Me.cboStatusPlacarFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusPlacarFiltro.Size = New System.Drawing.Size(194, 20)
        Me.cboStatusPlacarFiltro.TabIndex = 3
        '
        'lblStatusPlacarFiltro
        '
        Me.lblStatusPlacarFiltro.AutoSize = True
        Me.lblStatusPlacarFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusPlacarFiltro.Location = New System.Drawing.Point(380, 20)
        Me.lblStatusPlacarFiltro.Name = "lblStatusPlacarFiltro"
        Me.lblStatusPlacarFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusPlacarFiltro.TabIndex = 39
        Me.lblStatusPlacarFiltro.Text = "Status:"
        '
        'cboCategoriaPlacarFiltro
        '
        Me.cboCategoriaPlacarFiltro.AutoSize = False
        Me.cboCategoriaPlacarFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCategoriaPlacarFiltro.Location = New System.Drawing.Point(183, 37)
        Me.cboCategoriaPlacarFiltro.Name = "cboCategoriaPlacarFiltro"
        Me.cboCategoriaPlacarFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCategoriaPlacarFiltro.Size = New System.Drawing.Size(194, 20)
        Me.cboCategoriaPlacarFiltro.TabIndex = 2
        '
        'lblCategoriaFiltro
        '
        Me.lblCategoriaFiltro.AutoSize = True
        Me.lblCategoriaFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblCategoriaFiltro.Location = New System.Drawing.Point(180, 20)
        Me.lblCategoriaFiltro.Name = "lblCategoriaFiltro"
        Me.lblCategoriaFiltro.Size = New System.Drawing.Size(56, 14)
        Me.lblCategoriaFiltro.TabIndex = 37
        Me.lblCategoriaFiltro.Text = "Categoria:"
        '
        'cboMesPlacarFiltro
        '
        Me.cboMesPlacarFiltro.AutoSize = False
        Me.cboMesPlacarFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMesPlacarFiltro.Location = New System.Drawing.Point(85, 37)
        Me.cboMesPlacarFiltro.Name = "cboMesPlacarFiltro"
        Me.cboMesPlacarFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMesPlacarFiltro.Size = New System.Drawing.Size(92, 20)
        Me.cboMesPlacarFiltro.TabIndex = 1
        '
        'cboAnoPlacarFiltro
        '
        Me.cboAnoPlacarFiltro.AutoSize = False
        Me.cboAnoPlacarFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAnoPlacarFiltro.Location = New System.Drawing.Point(6, 37)
        Me.cboAnoPlacarFiltro.Name = "cboAnoPlacarFiltro"
        Me.cboAnoPlacarFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAnoPlacarFiltro.Size = New System.Drawing.Size(73, 20)
        Me.cboAnoPlacarFiltro.TabIndex = 0
        '
        'lblMesPlacarFiltro
        '
        Me.lblMesPlacarFiltro.AutoSize = True
        Me.lblMesPlacarFiltro.Location = New System.Drawing.Point(82, 20)
        Me.lblMesPlacarFiltro.Name = "lblMesPlacarFiltro"
        Me.lblMesPlacarFiltro.Size = New System.Drawing.Size(30, 14)
        Me.lblMesPlacarFiltro.TabIndex = 33
        Me.lblMesPlacarFiltro.Text = "Mês:"
        '
        'lblAnoPlacarFiltro
        '
        Me.lblAnoPlacarFiltro.AutoSize = True
        Me.lblAnoPlacarFiltro.Location = New System.Drawing.Point(3, 20)
        Me.lblAnoPlacarFiltro.Name = "lblAnoPlacarFiltro"
        Me.lblAnoPlacarFiltro.Size = New System.Drawing.Size(30, 14)
        Me.lblAnoPlacarFiltro.TabIndex = 31
        Me.lblAnoPlacarFiltro.Text = "Ano:"
        '
        'btnFiltrarPlacar
        '
        Me.btnFiltrarPlacar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarPlacar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarPlacar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarPlacar.Location = New System.Drawing.Point(882, 34)
        Me.btnFiltrarPlacar.Name = "btnFiltrarPlacar"
        Me.btnFiltrarPlacar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarPlacar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarPlacar.TabIndex = 4
        Me.btnFiltrarPlacar.Text = "Filtrar"
        Me.btnFiltrarPlacar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.UiGroupBox6)
        Me.pagDados.Controls.Add(Me.chrIAF)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "IAF"
        '
        'UiGroupBox6
        '
        Me.UiGroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox6.Controls.Add(Me.btnVoltar)
        Me.UiGroupBox6.Location = New System.Drawing.Point(8, 483)
        Me.UiGroupBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UiGroupBox6.Name = "UiGroupBox6"
        Me.UiGroupBox6.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox6.Size = New System.Drawing.Size(982, 51)
        Me.UiGroupBox6.TabIndex = 5
        Me.UiGroupBox6.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(882, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 3
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chrIAF
        '
        Me.chrIAF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrIAF.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrIAF.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrIAF.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea2.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea2.AxisX.Title = "Período (dias)"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea2.AxisY.Title = "Quantidade"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea2.BorderColor = System.Drawing.Color.Empty
        ChartArea2.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea2.Name = "Default"
        Me.chrIAF.ChartAreas.Add(ChartArea2)
        Legend2.AutoFitText = False
        Legend2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.Name = "Default"
        Me.chrIAF.Legends.Add(Legend2)
        Me.chrIAF.Location = New System.Drawing.Point(8, 17)
        Me.chrIAF.Name = "chrIAF"
        Me.chrIAF.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrIAF.Size = New System.Drawing.Size(982, 460)
        Me.chrIAF.TabIndex = 6
        Me.chrIAF.UI.Toolbar.Enabled = True
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Key = "pagDadosCliente"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 22)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(980, 378)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Visible = False
        '
        'usrIndComprasIAF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "usrIndComprasIAF"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagemMensal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagPlacar.ResumeLayout(False)
        CType(Me.grpControlPlacar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlPlacar.ResumeLayout(False)
        CType(Me.chrIAFPlacar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPlacarFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlacarFiltro.ResumeLayout(False)
        Me.grpPlacarFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox6.ResumeLayout(False)
        CType(Me.chrIAF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox6 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnVisualizarGrafico As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridMensal As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridMensal As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridMensal As System.Windows.Forms.Button
    Friend WithEvents grdListagemMensal As Janus.Windows.GridEX.GridEX
    Friend WithEvents chrIAF As Dundas.Charting.WinControl.Chart
    Friend WithEvents cboFornecedorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button
    Friend WithEvents cboMesFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboAnoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Private WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagPlacar As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpPlacarFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboMesPlacarFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboAnoPlacarFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMesPlacarFiltro As System.Windows.Forms.Label
    Friend WithEvents lblAnoPlacarFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarPlacar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCategoriaFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControlPlacar As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents chrIAFPlacar As Dundas.Charting.WinControl.Chart
    Friend WithEvents btnSairPlacar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboCategoria As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cbocategoriaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboCategoriaPlacarFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCategoriaIAF As System.Windows.Forms.Label
    Friend WithEvents cboCategoriaIAF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboStatusPlacarFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblStatusPlacarFiltro As System.Windows.Forms.Label

End Class
