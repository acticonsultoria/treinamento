<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEst000000006
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEst000000006))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPedidoB = New System.Windows.Forms.Label()
        Me.picLegendaB = New System.Windows.Forms.PictureBox()
        Me.txtBFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLegendaC = New System.Windows.Forms.Label()
        Me.txtAFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.picLegendaC = New System.Windows.Forms.PictureBox()
        Me.lblLegendaA = New System.Windows.Forms.Label()
        Me.picLegendaA = New System.Windows.Forms.PictureBox()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPeriodoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblMarcaFiltro = New System.Windows.Forms.Label()
        Me.cboMarcaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.chrDados = New Dundas.Charting.WinControl.Chart()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrDados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "EST000000006 - Estudo de Política - Estoque Mínimo"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 11
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.txtCFiltro)
        Me.grpLegenda.Controls.Add(Me.lblPedidoB)
        Me.grpLegenda.Controls.Add(Me.picLegendaB)
        Me.grpLegenda.Controls.Add(Me.txtBFiltro)
        Me.grpLegenda.Controls.Add(Me.lblLegendaC)
        Me.grpLegenda.Controls.Add(Me.txtAFiltro)
        Me.grpLegenda.Controls.Add(Me.picLegendaC)
        Me.grpLegenda.Controls.Add(Me.lblLegendaA)
        Me.grpLegenda.Controls.Add(Me.picLegendaA)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(276, 51)
        Me.grpLegenda.TabIndex = 10
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'txtCFiltro
        '
        Me.txtCFiltro.Location = New System.Drawing.Point(220, 18)
        Me.txtCFiltro.Name = "txtCFiltro"
        Me.txtCFiltro.Size = New System.Drawing.Size(47, 20)
        Me.txtCFiltro.TabIndex = 10
        Me.txtCFiltro.Text = "0,00"
        Me.txtCFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPedidoB
        '
        Me.lblPedidoB.AutoSize = True
        Me.lblPedidoB.Location = New System.Drawing.Point(114, 21)
        Me.lblPedidoB.Name = "lblPedidoB"
        Me.lblPedidoB.Size = New System.Drawing.Size(14, 14)
        Me.lblPedidoB.TabIndex = 1
        Me.lblPedidoB.Text = "B"
        '
        'picLegendaB
        '
        Me.picLegendaB.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaB.Location = New System.Drawing.Point(95, 21)
        Me.picLegendaB.Name = "picLegendaB"
        Me.picLegendaB.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaB.TabIndex = 18
        Me.picLegendaB.TabStop = False
        '
        'txtBFiltro
        '
        Me.txtBFiltro.Location = New System.Drawing.Point(131, 18)
        Me.txtBFiltro.Name = "txtBFiltro"
        Me.txtBFiltro.Size = New System.Drawing.Size(47, 20)
        Me.txtBFiltro.TabIndex = 8
        Me.txtBFiltro.Text = "0,00"
        Me.txtBFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblLegendaC
        '
        Me.lblLegendaC.AutoSize = True
        Me.lblLegendaC.Location = New System.Drawing.Point(203, 21)
        Me.lblLegendaC.Name = "lblLegendaC"
        Me.lblLegendaC.Size = New System.Drawing.Size(14, 14)
        Me.lblLegendaC.TabIndex = 2
        Me.lblLegendaC.Text = "C"
        '
        'txtAFiltro
        '
        Me.txtAFiltro.Location = New System.Drawing.Point(42, 18)
        Me.txtAFiltro.Name = "txtAFiltro"
        Me.txtAFiltro.Size = New System.Drawing.Size(47, 20)
        Me.txtAFiltro.TabIndex = 6
        Me.txtAFiltro.Text = "0,00"
        Me.txtAFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'picLegendaC
        '
        Me.picLegendaC.BackColor = System.Drawing.Color.Peru
        Me.picLegendaC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaC.Location = New System.Drawing.Point(184, 21)
        Me.picLegendaC.Name = "picLegendaC"
        Me.picLegendaC.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaC.TabIndex = 16
        Me.picLegendaC.TabStop = False
        '
        'lblLegendaA
        '
        Me.lblLegendaA.AutoSize = True
        Me.lblLegendaA.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaA.Name = "lblLegendaA"
        Me.lblLegendaA.Size = New System.Drawing.Size(15, 14)
        Me.lblLegendaA.TabIndex = 0
        Me.lblLegendaA.Text = "A"
        '
        'picLegendaA
        '
        Me.picLegendaA.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaA.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaA.Name = "picLegendaA"
        Me.picLegendaA.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaA.TabIndex = 4
        Me.picLegendaA.TabStop = False
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
        Me.btnConfigurarGrid.TabIndex = 9
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblPeriodoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboMarcaFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblPeriodoFiltro
        '
        Me.lblPeriodoFiltro.AutoSize = True
        Me.lblPeriodoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPeriodoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblPeriodoFiltro.Name = "lblPeriodoFiltro"
        Me.lblPeriodoFiltro.Size = New System.Drawing.Size(46, 14)
        Me.lblPeriodoFiltro.TabIndex = 0
        Me.lblPeriodoFiltro.Text = "Período:"
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(117, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 2
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataInicioFiltro.TabIndex = 1
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(222, 17)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblGrupoItemFiltro.TabIndex = 3
        Me.lblGrupoItemFiltro.Text = "Grupo - Item:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.AutoSize = False
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(225, 34)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(272, 20)
        Me.cboGrupoItemFiltro.TabIndex = 4
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblMarcaFiltro
        '
        Me.lblMarcaFiltro.AutoSize = True
        Me.lblMarcaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcaFiltro.Location = New System.Drawing.Point(500, 17)
        Me.lblMarcaFiltro.Name = "lblMarcaFiltro"
        Me.lblMarcaFiltro.Size = New System.Drawing.Size(40, 14)
        Me.lblMarcaFiltro.TabIndex = 12
        Me.lblMarcaFiltro.Text = "Marca:"
        '
        'cboMarcaFiltro
        '
        Me.cboMarcaFiltro.AutoSize = False
        Me.cboMarcaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMarcaFiltro.Location = New System.Drawing.Point(503, 34)
        Me.cboMarcaFiltro.Name = "cboMarcaFiltro"
        Me.cboMarcaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMarcaFiltro.Size = New System.Drawing.Size(272, 20)
        Me.cboMarcaFiltro.TabIndex = 13
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(293, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(612, 51)
        Me.grpControle.TabIndex = 2
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(512, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.grdListagem.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 404)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'chrDados
        '
        Me.chrDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chrDados.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrDados.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrDados.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.Title = "Data"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Fator Cambial"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrDados.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Default"
        Me.chrDados.Legends.Add(Legend1)
        Me.chrDados.Location = New System.Drawing.Point(9, 178)
        Me.chrDados.Name = "chrDados"
        Me.chrDados.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series1.ChartType = "Line"
        Series1.CustomAttributes = "LabelStyle=Bottom"
        Series1.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Series1.Name = "Default"
        Series1.ShowLabelAsValue = True
        Series1.SmartLabels.Enabled = True
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrDados.Series.Add(Series1)
        Me.chrDados.Size = New System.Drawing.Size(897, 324)
        Me.chrDados.TabIndex = 4
        Title1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Variação Cambial"
        Title1.Text = "Variação Cambial"
        Me.chrDados.Titles.Add(Title1)
        Me.chrDados.UI.Toolbar.Enabled = True
        '
        'usrEst000000006
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.chrDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEst000000006"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents chrDados As Dundas.Charting.WinControl.Chart
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtCFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtBFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtAFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPeriodoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPedidoB As System.Windows.Forms.Label
    Friend WithEvents picLegendaB As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaC As System.Windows.Forms.Label
    Friend WithEvents picLegendaC As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaA As System.Windows.Forms.Label
    Friend WithEvents picLegendaA As System.Windows.Forms.PictureBox
    Friend WithEvents lblMarcaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboMarcaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button

End Class
