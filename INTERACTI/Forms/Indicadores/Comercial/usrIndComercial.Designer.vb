<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIndComercial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIndComercial))
        Dim grdSintetico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdSintetico_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdSintetico_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
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
        Me.txtMeta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMeta = New System.Windows.Forms.Label()
        Me.cboTipoValor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoValor = New System.Windows.Forms.Label()
        Me.txtFiltro = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.btnAlterarCorSerie5 = New Janus.Windows.EditControls.UIButton()
        Me.chkSerie5 = New Janus.Windows.EditControls.UICheckBox()
        Me.chkSerie4 = New Janus.Windows.EditControls.UICheckBox()
        Me.txtSerie5 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnAlterarCorSerie4 = New Janus.Windows.EditControls.UIButton()
        Me.txtSerie4 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnAlterarCorSerie3 = New Janus.Windows.EditControls.UIButton()
        Me.chkSerie3 = New Janus.Windows.EditControls.UICheckBox()
        Me.chkSerie2 = New Janus.Windows.EditControls.UICheckBox()
        Me.chkSerie1 = New Janus.Windows.EditControls.UICheckBox()
        Me.lblDataTermino = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtSerie3 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnAlterarCorSerie2 = New Janus.Windows.EditControls.UIButton()
        Me.txtSerie2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnAlterarCorSerie1 = New Janus.Windows.EditControls.UIButton()
        Me.txtSerie1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInicioFiltro = New System.Windows.Forms.Label()
        Me.cboTipoFiltroIndicador = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoFiltroIndicador = New System.Windows.Forms.Label()
        Me.lblTipoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.chrMain = New Dundas.Charting.WinControl.Chart()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnOcultarFiltro = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnOcultar = New Janus.Windows.EditControls.UIButton()
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
        Me.tabMain.Size = New System.Drawing.Size(1247, 566)
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
        Me.pagListagem.Size = New System.Drawing.Size(1245, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Indicador - Comercial"
        '
        'btnExcelAnalitico
        '
        Me.btnExcelAnalitico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelAnalitico.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelAnalitico.FlatAppearance.BorderSize = 0
        Me.btnExcelAnalitico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelAnalitico.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelAnalitico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelAnalitico.Location = New System.Drawing.Point(703, 463)
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
        Me.grdAnalitico.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdAnalitico_DesignTimeLayout.LayoutString = resources.GetString("grdAnalitico_DesignTimeLayout.LayoutString")
        Me.grdAnalitico.DesignTimeLayout = grdAnalitico_DesignTimeLayout
        Me.grdAnalitico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdAnalitico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdAnalitico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdAnalitico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdAnalitico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdAnalitico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdAnalitico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdAnalitico.GroupByBoxVisible = False
        Me.grdAnalitico.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdAnalitico.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdAnalitico.Hierarchical = True
        Me.grdAnalitico.Location = New System.Drawing.Point(702, 326)
        Me.grdAnalitico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdAnalitico.Name = "grdAnalitico"
        Me.grdAnalitico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdAnalitico.RecordNavigator = True
        Me.grdAnalitico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdAnalitico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdAnalitico.Size = New System.Drawing.Size(535, 154)
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
        Me.btnExcelGrid.Location = New System.Drawing.Point(703, 301)
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
        grdSintetico_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdSintetico_DesignTimeLayout_Reference_0.Instance"), Object)
        grdSintetico_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdSintetico_DesignTimeLayout_Reference_1.Instance"), Object)
        grdSintetico_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdSintetico_DesignTimeLayout_Reference_0, grdSintetico_DesignTimeLayout_Reference_1})
        grdSintetico_DesignTimeLayout.LayoutString = resources.GetString("grdSintetico_DesignTimeLayout.LayoutString")
        Me.grdSintetico.DesignTimeLayout = grdSintetico_DesignTimeLayout
        Me.grdSintetico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdSintetico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdSintetico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdSintetico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdSintetico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdSintetico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdSintetico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdSintetico.GroupByBoxVisible = False
        Me.grdSintetico.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdSintetico.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdSintetico.Hierarchical = True
        Me.grdSintetico.Location = New System.Drawing.Point(701, 162)
        Me.grdSintetico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdSintetico.Name = "grdSintetico"
        Me.grdSintetico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdSintetico.RecordNavigator = True
        Me.grdSintetico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdSintetico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdSintetico.Size = New System.Drawing.Size(536, 156)
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
        Me.grpFiltro.Controls.Add(Me.txtMeta)
        Me.grpFiltro.Controls.Add(Me.lblMeta)
        Me.grpFiltro.Controls.Add(Me.cboTipoValor)
        Me.grpFiltro.Controls.Add(Me.lblTipoValor)
        Me.grpFiltro.Controls.Add(Me.txtFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFiltro)
        Me.grpFiltro.Controls.Add(Me.btnAlterarCorSerie5)
        Me.grpFiltro.Controls.Add(Me.chkSerie5)
        Me.grpFiltro.Controls.Add(Me.chkSerie4)
        Me.grpFiltro.Controls.Add(Me.txtSerie5)
        Me.grpFiltro.Controls.Add(Me.btnAlterarCorSerie4)
        Me.grpFiltro.Controls.Add(Me.txtSerie4)
        Me.grpFiltro.Controls.Add(Me.btnAlterarCorSerie3)
        Me.grpFiltro.Controls.Add(Me.chkSerie3)
        Me.grpFiltro.Controls.Add(Me.chkSerie2)
        Me.grpFiltro.Controls.Add(Me.chkSerie1)
        Me.grpFiltro.Controls.Add(Me.lblDataTermino)
        Me.grpFiltro.Controls.Add(Me.txtDescricao)
        Me.grpFiltro.Controls.Add(Me.lblDescricao)
        Me.grpFiltro.Controls.Add(Me.txtSerie3)
        Me.grpFiltro.Controls.Add(Me.btnAlterarCorSerie2)
        Me.grpFiltro.Controls.Add(Me.txtSerie2)
        Me.grpFiltro.Controls.Add(Me.btnAlterarCorSerie1)
        Me.grpFiltro.Controls.Add(Me.txtSerie1)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoFiltroIndicador)
        Me.grpFiltro.Controls.Add(Me.lblTipoFiltroIndicador)
        Me.grpFiltro.Controls.Add(Me.lblTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1229, 152)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtMeta
        '
        Me.txtMeta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMeta.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtMeta.Location = New System.Drawing.Point(606, 74)
        Me.txtMeta.Name = "txtMeta"
        Me.txtMeta.Size = New System.Drawing.Size(136, 20)
        Me.txtMeta.TabIndex = 17
        Me.txtMeta.Text = "0,00"
        Me.txtMeta.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMeta
        '
        Me.lblMeta.AutoSize = True
        Me.lblMeta.BackColor = System.Drawing.Color.Transparent
        Me.lblMeta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeta.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblMeta.Location = New System.Drawing.Point(603, 57)
        Me.lblMeta.Name = "lblMeta"
        Me.lblMeta.Size = New System.Drawing.Size(43, 16)
        Me.lblMeta.TabIndex = 16
        Me.lblMeta.Text = "Meta:"
        '
        'cboTipoValor
        '
        Me.cboTipoValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoValor.AutoSize = False
        Me.cboTipoValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboTipoValor.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboTipoValor.Location = New System.Drawing.Point(955, 34)
        Me.cboTipoValor.Name = "cboTipoValor"
        Me.cboTipoValor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoValor.Size = New System.Drawing.Size(167, 20)
        Me.cboTipoValor.TabIndex = 76
        '
        'lblTipoValor
        '
        Me.lblTipoValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoValor.AutoSize = True
        Me.lblTipoValor.Location = New System.Drawing.Point(952, 17)
        Me.lblTipoValor.Name = "lblTipoValor"
        Me.lblTipoValor.Size = New System.Drawing.Size(73, 14)
        Me.lblTipoValor.TabIndex = 75
        Me.lblTipoValor.Text = "Tipo de Valor:"
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(371, 74)
        Me.txtFiltro.MaxLength = 0
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFiltro.Size = New System.Drawing.Size(229, 20)
        Me.txtFiltro.TabIndex = 15
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(368, 57)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(33, 14)
        Me.lblFiltro.TabIndex = 14
        Me.lblFiltro.Text = "Filtro:"
        '
        'btnAlterarCorSerie5
        '
        Me.btnAlterarCorSerie5.FlatBorderColor = System.Drawing.Color.Maroon
        Me.btnAlterarCorSerie5.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAlterarCorSerie5.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarCorSerie5.Location = New System.Drawing.Point(587, 119)
        Me.btnAlterarCorSerie5.Name = "btnAlterarCorSerie5"
        Me.btnAlterarCorSerie5.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarCorSerie5.Size = New System.Drawing.Size(20, 20)
        Me.btnAlterarCorSerie5.TabIndex = 0
        Me.btnAlterarCorSerie5.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chkSerie5
        '
        Me.chkSerie5.Location = New System.Drawing.Point(492, 102)
        Me.chkSerie5.Name = "chkSerie5"
        Me.chkSerie5.Size = New System.Drawing.Size(54, 17)
        Me.chkSerie5.TabIndex = 30
        Me.chkSerie5.Tag = "4"
        Me.chkSerie5.Text = "Série 5:"
        '
        'chkSerie4
        '
        Me.chkSerie4.Location = New System.Drawing.Point(371, 102)
        Me.chkSerie4.Name = "chkSerie4"
        Me.chkSerie4.Size = New System.Drawing.Size(54, 17)
        Me.chkSerie4.TabIndex = 27
        Me.chkSerie4.Tag = "3"
        Me.chkSerie4.Text = "Série 4:"
        '
        'txtSerie5
        '
        Me.txtSerie5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie5.Location = New System.Drawing.Point(492, 119)
        Me.txtSerie5.MaxLength = 3
        Me.txtSerie5.Name = "txtSerie5"
        Me.txtSerie5.Size = New System.Drawing.Size(95, 20)
        Me.txtSerie5.TabIndex = 31
        '
        'btnAlterarCorSerie4
        '
        Me.btnAlterarCorSerie4.FlatBorderColor = System.Drawing.Color.Maroon
        Me.btnAlterarCorSerie4.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAlterarCorSerie4.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarCorSerie4.Location = New System.Drawing.Point(466, 119)
        Me.btnAlterarCorSerie4.Name = "btnAlterarCorSerie4"
        Me.btnAlterarCorSerie4.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarCorSerie4.Size = New System.Drawing.Size(20, 20)
        Me.btnAlterarCorSerie4.TabIndex = 29
        Me.btnAlterarCorSerie4.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtSerie4
        '
        Me.txtSerie4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie4.Location = New System.Drawing.Point(371, 119)
        Me.txtSerie4.MaxLength = 3
        Me.txtSerie4.Name = "txtSerie4"
        Me.txtSerie4.Size = New System.Drawing.Size(95, 20)
        Me.txtSerie4.TabIndex = 28
        '
        'btnAlterarCorSerie3
        '
        Me.btnAlterarCorSerie3.FlatBorderColor = System.Drawing.Color.Maroon
        Me.btnAlterarCorSerie3.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAlterarCorSerie3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarCorSerie3.Location = New System.Drawing.Point(345, 119)
        Me.btnAlterarCorSerie3.Name = "btnAlterarCorSerie3"
        Me.btnAlterarCorSerie3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarCorSerie3.Size = New System.Drawing.Size(20, 20)
        Me.btnAlterarCorSerie3.TabIndex = 26
        Me.btnAlterarCorSerie3.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chkSerie3
        '
        Me.chkSerie3.Location = New System.Drawing.Point(250, 102)
        Me.chkSerie3.Name = "chkSerie3"
        Me.chkSerie3.Size = New System.Drawing.Size(54, 17)
        Me.chkSerie3.TabIndex = 24
        Me.chkSerie3.Tag = "2"
        Me.chkSerie3.Text = "Série 3:"
        '
        'chkSerie2
        '
        Me.chkSerie2.Location = New System.Drawing.Point(129, 102)
        Me.chkSerie2.Name = "chkSerie2"
        Me.chkSerie2.Size = New System.Drawing.Size(54, 17)
        Me.chkSerie2.TabIndex = 21
        Me.chkSerie2.Tag = "1"
        Me.chkSerie2.Text = "Série 2:"
        '
        'chkSerie1
        '
        Me.chkSerie1.Location = New System.Drawing.Point(10, 102)
        Me.chkSerie1.Name = "chkSerie1"
        Me.chkSerie1.Size = New System.Drawing.Size(54, 17)
        Me.chkSerie1.TabIndex = 18
        Me.chkSerie1.Tag = "0"
        Me.chkSerie1.Text = "Série 1:"
        '
        'lblDataTermino
        '
        Me.lblDataTermino.AutoSize = True
        Me.lblDataTermino.Location = New System.Drawing.Point(110, 57)
        Me.lblDataTermino.Name = "lblDataTermino"
        Me.lblDataTermino.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTermino.TabIndex = 10
        Me.lblDataTermino.Text = "Data Término:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(336, 34)
        Me.txtDescricao.MaxLength = 0
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescricao.Size = New System.Drawing.Size(613, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(333, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(113, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição do Gráfico:"
        '
        'txtSerie3
        '
        Me.txtSerie3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie3.Location = New System.Drawing.Point(250, 119)
        Me.txtSerie3.MaxLength = 3
        Me.txtSerie3.Name = "txtSerie3"
        Me.txtSerie3.Size = New System.Drawing.Size(95, 20)
        Me.txtSerie3.TabIndex = 25
        '
        'btnAlterarCorSerie2
        '
        Me.btnAlterarCorSerie2.FlatBorderColor = System.Drawing.Color.Maroon
        Me.btnAlterarCorSerie2.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAlterarCorSerie2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarCorSerie2.Location = New System.Drawing.Point(224, 119)
        Me.btnAlterarCorSerie2.Name = "btnAlterarCorSerie2"
        Me.btnAlterarCorSerie2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarCorSerie2.Size = New System.Drawing.Size(20, 20)
        Me.btnAlterarCorSerie2.TabIndex = 23
        Me.btnAlterarCorSerie2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtSerie2
        '
        Me.txtSerie2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie2.Location = New System.Drawing.Point(129, 119)
        Me.txtSerie2.MaxLength = 3
        Me.txtSerie2.Name = "txtSerie2"
        Me.txtSerie2.Size = New System.Drawing.Size(95, 20)
        Me.txtSerie2.TabIndex = 22
        '
        'btnAlterarCorSerie1
        '
        Me.btnAlterarCorSerie1.FlatBorderColor = System.Drawing.Color.Maroon
        Me.btnAlterarCorSerie1.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAlterarCorSerie1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarCorSerie1.Location = New System.Drawing.Point(103, 119)
        Me.btnAlterarCorSerie1.Name = "btnAlterarCorSerie1"
        Me.btnAlterarCorSerie1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarCorSerie1.Size = New System.Drawing.Size(20, 20)
        Me.btnAlterarCorSerie1.TabIndex = 20
        Me.btnAlterarCorSerie1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtSerie1
        '
        Me.txtSerie1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie1.Location = New System.Drawing.Point(10, 119)
        Me.txtSerie1.MaxLength = 3
        Me.txtSerie1.Name = "txtSerie1"
        Me.txtSerie1.Size = New System.Drawing.Size(95, 20)
        Me.txtSerie1.TabIndex = 19
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(98, 20)
        Me.dtpDataInicioFiltro.TabIndex = 9
        Me.dtpDataInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(113, 74)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 11
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataInicioFiltro
        '
        Me.lblDataInicioFiltro.AutoSize = True
        Me.lblDataInicioFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataInicioFiltro.Name = "lblDataInicioFiltro"
        Me.lblDataInicioFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicioFiltro.TabIndex = 8
        Me.lblDataInicioFiltro.Text = "Data Início:"
        '
        'cboTipoFiltroIndicador
        '
        Me.cboTipoFiltroIndicador.AutoSize = False
        Me.cboTipoFiltroIndicador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboTipoFiltroIndicador.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboTipoFiltroIndicador.Location = New System.Drawing.Point(218, 74)
        Me.cboTipoFiltroIndicador.Name = "cboTipoFiltroIndicador"
        Me.cboTipoFiltroIndicador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoFiltroIndicador.Size = New System.Drawing.Size(147, 20)
        Me.cboTipoFiltroIndicador.TabIndex = 13
        '
        'lblTipoFiltroIndicador
        '
        Me.lblTipoFiltroIndicador.AutoSize = True
        Me.lblTipoFiltroIndicador.Location = New System.Drawing.Point(215, 58)
        Me.lblTipoFiltroIndicador.Name = "lblTipoFiltroIndicador"
        Me.lblTipoFiltroIndicador.Size = New System.Drawing.Size(71, 14)
        Me.lblTipoFiltroIndicador.TabIndex = 12
        Me.lblTipoFiltroIndicador.Text = "Tipo de Filtro:"
        '
        'lblTipoFiltro
        '
        Me.lblTipoFiltro.AutoSize = True
        Me.lblTipoFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoFiltro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTipoFiltro.ForeColor = System.Drawing.Color.Firebrick
        Me.lblTipoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoFiltro.Name = "lblTipoFiltro"
        Me.lblTipoFiltro.Size = New System.Drawing.Size(100, 14)
        Me.lblTipoFiltro.TabIndex = 0
        Me.lblTipoFiltro.Text = "* Tipo de Gráfico:"
        '
        'cboTipoFiltro
        '
        Me.cboTipoFiltro.AutoSize = False
        Me.cboTipoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboTipoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboTipoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoFiltro.Name = "cboTipoFiltro"
        Me.cboTipoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoFiltro.Size = New System.Drawing.Size(321, 20)
        Me.cboTipoFiltro.TabIndex = 1
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(1129, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(84, 23)
        Me.btnFiltrar.TabIndex = 25
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
        Me.chrMain.Location = New System.Drawing.Point(9, 161)
        Me.chrMain.Name = "chrMain"
        Me.chrMain.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Me.chrMain.Size = New System.Drawing.Size(686, 319)
        Me.chrMain.TabIndex = 1
        Me.chrMain.UI.Toolbar.Enabled = True
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnOcultarFiltro)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnOcultar)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(1229, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnOcultarFiltro
        '
        Me.btnOcultarFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOcultarFiltro.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnOcultarFiltro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOcultarFiltro.Location = New System.Drawing.Point(1016, 17)
        Me.btnOcultarFiltro.Name = "btnOcultarFiltro"
        Me.btnOcultarFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOcultarFiltro.Size = New System.Drawing.Size(106, 23)
        Me.btnOcultarFiltro.TabIndex = 27
        Me.btnOcultarFiltro.Text = "Ocultar Filtro"
        Me.btnOcultarFiltro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(1129, 17)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnOcultar
        '
        Me.btnOcultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOcultar.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnOcultar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOcultar.Location = New System.Drawing.Point(904, 17)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOcultar.Size = New System.Drawing.Size(106, 23)
        Me.btnOcultar.TabIndex = 26
        Me.btnOcultar.Text = "Ocultar Tabela"
        Me.btnOcultar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrIndComercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "usrIndComercial"
        Me.Size = New System.Drawing.Size(1247, 566)
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
    Friend WithEvents lblTipoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelAnalitico As System.Windows.Forms.Button
    Friend WithEvents grdAnalitico As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnOcultar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboTipoFiltroIndicador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoFiltroIndicador As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataInicioFiltro As System.Windows.Forms.Label
    Friend WithEvents txtSerie3 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnAlterarCorSerie2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSerie2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnAlterarCorSerie1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSerie1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblDataTermino As System.Windows.Forms.Label
    Friend WithEvents btnOcultarFiltro As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkSerie3 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSerie2 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSerie1 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnAlterarCorSerie3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAlterarCorSerie5 As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkSerie5 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSerie4 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtSerie5 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnAlterarCorSerie4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSerie4 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtFiltro As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoValor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoValor As System.Windows.Forms.Label
    Friend WithEvents txtMeta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMeta As System.Windows.Forms.Label

End Class
