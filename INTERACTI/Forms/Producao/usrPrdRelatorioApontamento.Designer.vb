<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdRelatorioApontamento
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
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdRelatorioApontamento))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagMain = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.dtpDataTerminoApontamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioApontamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblPeriodoApontamento = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.btnExcelGridServico = New System.Windows.Forms.Button()
        Me.btnAgruparGridServico = New System.Windows.Forms.Button()
        Me.btnConfigurarGridServico = New System.Windows.Forms.Button()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagMain.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(946, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagMain})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagMain
        '
        Me.pagMain.Controls.Add(Me.grdApontamento)
        Me.pagMain.Controls.Add(Me.grpEntrega)
        Me.pagMain.Controls.Add(Me.grpFiltro)
        Me.pagMain.Location = New System.Drawing.Point(1, 22)
        Me.pagMain.Name = "pagMain"
        Me.pagMain.Size = New System.Drawing.Size(944, 543)
        Me.pagMain.TabStop = True
        Me.pagMain.Text = "Análise"
        '
        'grdApontamento
        '
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdApontamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdApontamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdApontamento.Location = New System.Drawing.Point(7, 75)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.RecordNavigator = True
        Me.grdApontamento.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(925, 402)
        Me.grdApontamento.TabIndex = 7
        Me.grdApontamento.TabStop = False
        Me.grdApontamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.btnExcel)
        Me.grpEntrega.Controls.Add(Me.btnSair)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(7, 483)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(925, 52)
        Me.grpEntrega.TabIndex = 2
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(728, 19)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(825, 19)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboMaquina)
        Me.grpFiltro.Controls.Add(Me.lblMaquina)
        Me.grpFiltro.Controls.Add(Me.cboFuncionario)
        Me.grpFiltro.Controls.Add(Me.lblFuncionario)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoApontamento)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioApontamento)
        Me.grpFiltro.Controls.Add(Me.lblPeriodoApontamento)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(7, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(925, 66)
        Me.grpFiltro.TabIndex = 1
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoSize = False
        Me.cboMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboMaquina.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboMaquina.Location = New System.Drawing.Point(298, 32)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaquina.Size = New System.Drawing.Size(225, 20)
        Me.cboMaquina.TabIndex = 28
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaquina.Location = New System.Drawing.Point(295, 16)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(50, 14)
        Me.lblMaquina.TabIndex = 27
        Me.lblMaquina.Text = "Máquina:"
        '
        'cboFuncionario
        '
        Me.cboFuncionario.AutoSize = False
        Me.cboFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboFuncionario.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboFuncionario.Location = New System.Drawing.Point(12, 32)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFuncionario.Size = New System.Drawing.Size(280, 20)
        Me.cboFuncionario.TabIndex = 26
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(9, 16)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionario.TabIndex = 25
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'dtpDataTerminoApontamento
        '
        '
        '
        '
        Me.dtpDataTerminoApontamento.DropDownCalendar.Name = ""
        Me.dtpDataTerminoApontamento.Location = New System.Drawing.Point(655, 32)
        Me.dtpDataTerminoApontamento.Name = "dtpDataTerminoApontamento"
        Me.dtpDataTerminoApontamento.ShowCheckBox = True
        Me.dtpDataTerminoApontamento.Size = New System.Drawing.Size(120, 20)
        Me.dtpDataTerminoApontamento.TabIndex = 24
        '
        'dtpDataInicioApontamento
        '
        '
        '
        '
        Me.dtpDataInicioApontamento.DropDownCalendar.Name = ""
        Me.dtpDataInicioApontamento.Location = New System.Drawing.Point(529, 32)
        Me.dtpDataInicioApontamento.Name = "dtpDataInicioApontamento"
        Me.dtpDataInicioApontamento.ShowCheckBox = True
        Me.dtpDataInicioApontamento.Size = New System.Drawing.Size(120, 20)
        Me.dtpDataInicioApontamento.TabIndex = 23
        '
        'lblPeriodoApontamento
        '
        Me.lblPeriodoApontamento.AutoSize = True
        Me.lblPeriodoApontamento.Location = New System.Drawing.Point(526, 15)
        Me.lblPeriodoApontamento.Name = "lblPeriodoApontamento"
        Me.lblPeriodoApontamento.Size = New System.Drawing.Size(124, 14)
        Me.lblPeriodoApontamento.TabIndex = 22
        Me.lblPeriodoApontamento.Text = "Data início apontamento:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(811, 29)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 60000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.ShowAlways = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(50, 368)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 15)
        Me.Button1.TabIndex = 94
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(26, 368)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 15)
        Me.Button2.TabIndex = 93
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(2, 368)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 2
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'btnExcelGridServico
        '
        Me.btnExcelGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridServico.FlatAppearance.BorderSize = 0
        Me.btnExcelGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridServico.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridServico.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridServico.Name = "btnExcelGridServico"
        Me.btnExcelGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridServico.TabIndex = 96
        Me.btnExcelGridServico.TabStop = False
        Me.btnExcelGridServico.UseVisualStyleBackColor = False
        '
        'btnAgruparGridServico
        '
        Me.btnAgruparGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridServico.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridServico.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridServico.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridServico.Name = "btnAgruparGridServico"
        Me.btnAgruparGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridServico.TabIndex = 95
        Me.btnAgruparGridServico.TabStop = False
        Me.btnAgruparGridServico.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridServico
        '
        Me.btnConfigurarGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridServico.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridServico.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridServico.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridServico.Name = "btnConfigurarGridServico"
        Me.btnConfigurarGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridServico.TabIndex = 2
        Me.btnConfigurarGridServico.TabStop = False
        Me.btnConfigurarGridServico.UseVisualStyleBackColor = False
        '
        'grdProduto
        '
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.AutoEdit = True
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.DynamicFiltering = True
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProduto.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.Hierarchical = True
        Me.grdProduto.Location = New System.Drawing.Point(0, 0)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(936, 385)
        Me.grdProduto.TabIndex = 95
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdProduto.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdProduto.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.AutoEdit = True
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.DynamicFiltering = True
        Me.GridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridEX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX1.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.GridEX1.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.GridEX1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridEX1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.GridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridEX1.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.GridEX1.Size = New System.Drawing.Size(936, 384)
        Me.GridEX1.TabIndex = 97
        Me.GridEX1.TabStop = False
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.GridEX1.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridEX1.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.GridEX1.VisualStyleManager = Me.vsmMain
        '
        'usrPrdRelatorioApontamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdRelatorioApontamento"
        Me.Size = New System.Drawing.Size(946, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagMain.ResumeLayout(False)
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntrega.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents pagMain As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridServico As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridServico As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridServico As System.Windows.Forms.Button
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaquina As System.Windows.Forms.Label
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoApontamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioApontamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblPeriodoApontamento As System.Windows.Forms.Label

End Class
