<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIndCompras
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
        Dim grdAnalitico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIndCompras))
        Dim grdSintetico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboGrupoTecnologia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboFornecedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelAnalitico = New System.Windows.Forms.Button()
        Me.grdAnalitico = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.grdSintetico = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboGrupoTecnologia = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.txtMeta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMeta = New System.Windows.Forms.Label()
        Me.btnHelp = New Janus.Windows.EditControls.UIButton()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.btnOcultar = New Janus.Windows.EditControls.UIButton()
        Me.lblTipoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.chrMain = New Dundas.Charting.WinControl.Chart()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdAnalitico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSintetico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.chrMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelAnalitico)
        Me.pagListagem.Controls.Add(Me.grdAnalitico)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.grdSintetico)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.chrMain)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Indicador - Compras"
        '
        'btnExcelAnalitico
        '
        Me.btnExcelAnalitico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelAnalitico.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelAnalitico.FlatAppearance.BorderSize = 0
        Me.btnExcelAnalitico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelAnalitico.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelAnalitico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelAnalitico.Location = New System.Drawing.Point(456, 463)
        Me.btnExcelAnalitico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelAnalitico.Name = "btnExcelAnalitico"
        Me.btnExcelAnalitico.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelAnalitico.TabIndex = 6
        Me.btnExcelAnalitico.TabStop = False
        Me.btnExcelAnalitico.UseVisualStyleBackColor = False
        '
        'grdAnalitico
        '
        Me.grdAnalitico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdAnalitico.AlternatingColors = True
        Me.grdAnalitico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAnalitico.ColumnAutoResize = True
        Me.grdAnalitico.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdAnalitico_DesignTimeLayout.LayoutString = resources.GetString("grdAnalitico_DesignTimeLayout.LayoutString")
        Me.grdAnalitico.DesignTimeLayout = grdAnalitico_DesignTimeLayout
        Me.grdAnalitico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdAnalitico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdAnalitico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdAnalitico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdAnalitico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdAnalitico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdAnalitico.GroupByBoxVisible = False
        Me.grdAnalitico.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdAnalitico.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdAnalitico.Hierarchical = True
        Me.grdAnalitico.Location = New System.Drawing.Point(455, 255)
        Me.grdAnalitico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdAnalitico.Name = "grdAnalitico"
        Me.grdAnalitico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdAnalitico.RecordNavigator = True
        Me.grdAnalitico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdAnalitico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdAnalitico.Size = New System.Drawing.Size(535, 225)
        Me.grdAnalitico.TabIndex = 5
        Me.grdAnalitico.TabStop = False
        Me.grdAnalitico.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdAnalitico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdAnalitico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdAnalitico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdAnalitico.VisualStyleManager = Me.vsmMain
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(455, 230)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 3
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'grdSintetico
        '
        Me.grdSintetico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdSintetico.AlternatingColors = True
        Me.grdSintetico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSintetico.ColumnAutoResize = True
        Me.grdSintetico.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdSintetico_DesignTimeLayout.LayoutString = resources.GetString("grdSintetico_DesignTimeLayout.LayoutString")
        Me.grdSintetico.DesignTimeLayout = grdSintetico_DesignTimeLayout
        Me.grdSintetico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdSintetico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdSintetico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdSintetico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdSintetico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdSintetico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdSintetico.GroupByBoxVisible = False
        Me.grdSintetico.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdSintetico.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdSintetico.Hierarchical = True
        Me.grdSintetico.Location = New System.Drawing.Point(454, 79)
        Me.grdSintetico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdSintetico.Name = "grdSintetico"
        Me.grdSintetico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdSintetico.RecordNavigator = True
        Me.grdSintetico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdSintetico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdSintetico.Size = New System.Drawing.Size(536, 168)
        Me.grdSintetico.TabIndex = 2
        Me.grdSintetico.TabStop = False
        Me.grdSintetico.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdSintetico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdSintetico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdSintetico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdSintetico.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboGrupoTecnologia)
        Me.grpFiltro.Controls.Add(Me.Label1)
        Me.grpFiltro.Controls.Add(Me.cboFornecedor)
        Me.grpFiltro.Controls.Add(Me.txtMeta)
        Me.grpFiltro.Controls.Add(Me.lblMeta)
        Me.grpFiltro.Controls.Add(Me.btnHelp)
        Me.grpFiltro.Controls.Add(Me.lblFornecedor)
        Me.grpFiltro.Controls.Add(Me.btnOcultar)
        Me.grpFiltro.Controls.Add(Me.lblTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
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
        'cboGrupoTecnologia
        '
        Me.cboGrupoTecnologia.AllowDrop = True
        Me.cboGrupoTecnologia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoTecnologia.ButtonCancelText = "Cancelar"
        Me.cboGrupoTecnologia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboGrupoTecnologia_DesignTimeLayout.LayoutString = resources.GetString("cboGrupoTecnologia_DesignTimeLayout.LayoutString")
        Me.cboGrupoTecnologia.DesignTimeLayout = cboGrupoTecnologia_DesignTimeLayout
        Me.cboGrupoTecnologia.Location = New System.Drawing.Point(574, 37)
        Me.cboGrupoTecnologia.Name = "cboGrupoTecnologia"
        Me.cboGrupoTecnologia.SaveSettings = False
        Me.cboGrupoTecnologia.SettingsKey = "cboDestinacaoFiltro"
        Me.cboGrupoTecnologia.Size = New System.Drawing.Size(126, 20)
        Me.cboGrupoTecnologia.TabIndex = 26
        Me.cboGrupoTecnologia.ValuesDataMember = Nothing
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(571, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 14)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Grupo Tecnologia:"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.AllowDrop = True
        Me.cboFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedor.ButtonCancelText = "Cancelar"
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboFornecedor_DesignTimeLayout.LayoutString = resources.GetString("cboFornecedor_DesignTimeLayout.LayoutString")
        Me.cboFornecedor.DesignTimeLayout = cboFornecedor_DesignTimeLayout
        Me.cboFornecedor.Location = New System.Drawing.Point(430, 37)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.SaveSettings = False
        Me.cboFornecedor.SettingsKey = "cboDestinacaoFiltro"
        Me.cboFornecedor.Size = New System.Drawing.Size(138, 20)
        Me.cboFornecedor.TabIndex = 24
        Me.cboFornecedor.ValuesDataMember = Nothing
        '
        'txtMeta
        '
        Me.txtMeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMeta.FormatString = "0"
        Me.txtMeta.Location = New System.Drawing.Point(706, 37)
        Me.txtMeta.Name = "txtMeta"
        Me.txtMeta.Size = New System.Drawing.Size(58, 20)
        Me.txtMeta.TabIndex = 8
        Me.txtMeta.Text = "0"
        Me.txtMeta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMeta
        '
        Me.lblMeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMeta.AutoSize = True
        Me.lblMeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMeta.Location = New System.Drawing.Point(703, 20)
        Me.lblMeta.Name = "lblMeta"
        Me.lblMeta.Size = New System.Drawing.Size(33, 14)
        Me.lblMeta.TabIndex = 7
        Me.lblMeta.Text = "Meta:"
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Image = Global.INTERACTI.My.Resources.Resources.comentario
        Me.btnHelp.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnHelp.Location = New System.Drawing.Point(867, 11)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnHelp.Size = New System.Drawing.Size(106, 23)
        Me.btnHelp.TabIndex = 12
        Me.btnHelp.Text = "Help"
        Me.btnHelp.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.lblFornecedor.Location = New System.Drawing.Point(427, 20)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 5
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'btnOcultar
        '
        Me.btnOcultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOcultar.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnOcultar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOcultar.Location = New System.Drawing.Point(867, 38)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOcultar.Size = New System.Drawing.Size(106, 23)
        Me.btnOcultar.TabIndex = 9
        Me.btnOcultar.Text = "Ocultar Tabela"
        Me.btnOcultar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblTipoFiltro
        '
        Me.lblTipoFiltro.AutoSize = True
        Me.lblTipoFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoFiltro.Location = New System.Drawing.Point(198, 20)
        Me.lblTipoFiltro.Name = "lblTipoFiltro"
        Me.lblTipoFiltro.Size = New System.Drawing.Size(30, 14)
        Me.lblTipoFiltro.TabIndex = 3
        Me.lblTipoFiltro.Text = "Tipo:"
        '
        'cboTipoFiltro
        '
        Me.cboTipoFiltro.AutoSize = False
        Me.cboTipoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboTipoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboTipoFiltro.Location = New System.Drawing.Point(201, 37)
        Me.cboTipoFiltro.Name = "cboTipoFiltro"
        Me.cboTipoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoFiltro.Size = New System.Drawing.Size(223, 20)
        Me.cboTipoFiltro.TabIndex = 4
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(105, 37)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 2
        Me.dtpDataTerminoFiltro.Value = New Date(2014, 9, 23, 0, 0, 0, 0)
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 37)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataInicioFiltro.TabIndex = 1
        Me.dtpDataInicioFiltro.Value = New Date(2014, 9, 23, 0, 0, 0, 0)
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(6, 20)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 0
        Me.lblDataFiltro.Text = "Data:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(770, 38)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 3
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chrMain
        '
        Me.chrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrMain.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrMain.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrMain.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea1.AxisX.Title = "Período (dias)"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Quantidade"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrMain.ChartAreas.Add(ChartArea1)
        Legend1.AutoFitText = False
        Legend1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.Name = "Default"
        Me.chrMain.Legends.Add(Legend1)
        Me.chrMain.Location = New System.Drawing.Point(9, 79)
        Me.chrMain.Name = "chrMain"
        Me.chrMain.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrMain.Size = New System.Drawing.Size(439, 401)
        Me.chrMain.TabIndex = 1
        Me.chrMain.UI.Toolbar.Enabled = True
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
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
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrIndCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "usrIndCompras"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdAnalitico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSintetico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.chrMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents chrMain As Dundas.Charting.WinControl.Chart
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents grdSintetico As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelAnalitico As System.Windows.Forms.Button
    Friend WithEvents grdAnalitico As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnHelp As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents btnOcultar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtMeta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMeta As System.Windows.Forms.Label
    Friend WithEvents cboFornecedor As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboGrupoTecnologia As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
