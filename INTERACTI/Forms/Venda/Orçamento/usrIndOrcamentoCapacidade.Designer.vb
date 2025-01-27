<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIndOrcamentoCapacidade
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
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIndOrcamentoCapacidade))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim grdListagemMensal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagemDiaria = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelDiario = New System.Windows.Forms.Button()
        Me.chrCapacidadeDiaria = New Dundas.Charting.WinControl.Chart()
        Me.grpFiltroDiario = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataFiltroDiario = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltroDiario = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnOcultar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagListagemMensal = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelMensal = New System.Windows.Forms.Button()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair2 = New Janus.Windows.EditControls.UIButton()
        Me.chrCapacidadeMensal = New Dundas.Charting.WinControl.Chart()
        Me.grdListagemMensal = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltroMensal = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataFiltroMensal = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltroMensal = New System.Windows.Forms.Label()
        Me.btnFiltrarMensal = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagemDiaria.SuspendLayout()
        CType(Me.chrCapacidadeDiaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltroDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltroDiario.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagListagemMensal.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.chrCapacidadeMensal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagemMensal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltroMensal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltroMensal.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1048, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagemDiaria, Me.pagListagemMensal})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagemDiaria
        '
        Me.pagListagemDiaria.Controls.Add(Me.btnExcelDiario)
        Me.pagListagemDiaria.Controls.Add(Me.chrCapacidadeDiaria)
        Me.pagListagemDiaria.Controls.Add(Me.grpFiltroDiario)
        Me.pagListagemDiaria.Controls.Add(Me.grpControl)
        Me.pagListagemDiaria.Controls.Add(Me.grdListagem)
        Me.pagListagemDiaria.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagemDiaria.Key = "pagListagem"
        Me.pagListagemDiaria.Location = New System.Drawing.Point(1, 22)
        Me.pagListagemDiaria.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pagListagemDiaria.Name = "pagListagemDiaria"
        Me.pagListagemDiaria.Size = New System.Drawing.Size(1046, 543)
        Me.pagListagemDiaria.TabStop = True
        Me.pagListagemDiaria.Text = "Demanda x Capacidade - Diária"
        '
        'btnExcelDiario
        '
        Me.btnExcelDiario.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelDiario.FlatAppearance.BorderSize = 0
        Me.btnExcelDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelDiario.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelDiario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelDiario.Location = New System.Drawing.Point(9, 196)
        Me.btnExcelDiario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelDiario.Name = "btnExcelDiario"
        Me.btnExcelDiario.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelDiario.TabIndex = 114
        Me.btnExcelDiario.TabStop = False
        Me.btnExcelDiario.UseVisualStyleBackColor = False
        '
        'chrCapacidadeDiaria
        '
        Me.chrCapacidadeDiaria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrCapacidadeDiaria.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrCapacidadeDiaria.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrCapacidadeDiaria.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea1.AxisX.Title = "Período (dias)"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Quantidade"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrCapacidadeDiaria.ChartAreas.Add(ChartArea1)
        Legend1.AutoFitText = False
        Legend1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.Name = "Default"
        Me.chrCapacidadeDiaria.Legends.Add(Legend1)
        Me.chrCapacidadeDiaria.Location = New System.Drawing.Point(8, 219)
        Me.chrCapacidadeDiaria.Name = "chrCapacidadeDiaria"
        Me.chrCapacidadeDiaria.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Me.chrCapacidadeDiaria.Size = New System.Drawing.Size(1030, 258)
        Me.chrCapacidadeDiaria.TabIndex = 112
        Me.chrCapacidadeDiaria.UI.Toolbar.Enabled = True
        '
        'grpFiltroDiario
        '
        Me.grpFiltroDiario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltroDiario.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltroDiario.Controls.Add(Me.dtpDataFiltroDiario)
        Me.grpFiltroDiario.Controls.Add(Me.lblDataFiltroDiario)
        Me.grpFiltroDiario.Controls.Add(Me.btnFiltrar)
        Me.grpFiltroDiario.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltroDiario.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltroDiario.Name = "grpFiltroDiario"
        Me.grpFiltroDiario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltroDiario.Size = New System.Drawing.Size(1030, 67)
        Me.grpFiltroDiario.TabIndex = 0
        Me.grpFiltroDiario.Text = "Filtro"
        Me.grpFiltroDiario.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltroDiario.VisualStyleManager = Me.vsmMain
        '
        'dtpDataFiltroDiario
        '
        Me.dtpDataFiltroDiario.CustomFormat = "MM/yyyy"
        Me.dtpDataFiltroDiario.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataFiltroDiario.DropDownCalendar.Name = ""
        Me.dtpDataFiltroDiario.Location = New System.Drawing.Point(6, 34)
        Me.dtpDataFiltroDiario.Name = "dtpDataFiltroDiario"
        Me.dtpDataFiltroDiario.Size = New System.Drawing.Size(73, 20)
        Me.dtpDataFiltroDiario.TabIndex = 19
        Me.dtpDataFiltroDiario.Value = New Date(2016, 3, 9, 8, 48, 2, 0)
        '
        'lblDataFiltroDiario
        '
        Me.lblDataFiltroDiario.AutoSize = True
        Me.lblDataFiltroDiario.Location = New System.Drawing.Point(3, 17)
        Me.lblDataFiltroDiario.Name = "lblDataFiltroDiario"
        Me.lblDataFiltroDiario.Size = New System.Drawing.Size(30, 14)
        Me.lblDataFiltroDiario.TabIndex = 18
        Me.lblDataFiltroDiario.Text = "Mês:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(930, 34)
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
        Me.grpControl.Controls.Add(Me.btnOcultar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(1030, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnOcultar
        '
        Me.btnOcultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOcultar.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnOcultar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOcultar.Location = New System.Drawing.Point(817, 17)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOcultar.Size = New System.Drawing.Size(106, 23)
        Me.btnOcultar.TabIndex = 28
        Me.btnOcultar.Text = "Ocultar Tabela"
        Me.btnOcultar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(930, 17)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1030, 137)
        Me.grdListagem.TabIndex = 5
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagListagemMensal
        '
        Me.pagListagemMensal.Controls.Add(Me.btnExcelMensal)
        Me.pagListagemMensal.Controls.Add(Me.grpControl2)
        Me.pagListagemMensal.Controls.Add(Me.chrCapacidadeMensal)
        Me.pagListagemMensal.Controls.Add(Me.grdListagemMensal)
        Me.pagListagemMensal.Controls.Add(Me.grpFiltroMensal)
        Me.pagListagemMensal.Location = New System.Drawing.Point(1, 22)
        Me.pagListagemMensal.Name = "pagListagemMensal"
        Me.pagListagemMensal.Size = New System.Drawing.Size(1046, 543)
        Me.pagListagemMensal.TabStop = True
        Me.pagListagemMensal.Text = "Demanda x Capacidade - Mensal"
        '
        'btnExcelMensal
        '
        Me.btnExcelMensal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelMensal.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelMensal.FlatAppearance.BorderSize = 0
        Me.btnExcelMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelMensal.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelMensal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelMensal.Location = New System.Drawing.Point(57, 174)
        Me.btnExcelMensal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelMensal.Name = "btnExcelMensal"
        Me.btnExcelMensal.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelMensal.TabIndex = 114
        Me.btnExcelMensal.TabStop = False
        Me.btnExcelMensal.UseVisualStyleBackColor = False
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair2)
        Me.grpControl2.Location = New System.Drawing.Point(8, 483)
        Me.grpControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(1030, 51)
        Me.grpControl2.TabIndex = 114
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair2
        '
        Me.btnSair2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair2.Image = CType(resources.GetObject("btnSair2.Image"), System.Drawing.Image)
        Me.btnSair2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair2.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair2.Location = New System.Drawing.Point(930, 17)
        Me.btnSair2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair2.Name = "btnSair2"
        Me.btnSair2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair2.Size = New System.Drawing.Size(91, 23)
        Me.btnSair2.TabIndex = 0
        Me.btnSair2.Text = "Sair"
        Me.btnSair2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chrCapacidadeMensal
        '
        Me.chrCapacidadeMensal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrCapacidadeMensal.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrCapacidadeMensal.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrCapacidadeMensal.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea2.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea2.AxisX.Title = "Período (dias)"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea2.AxisY.Title = "Quantidade"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea2.BorderColor = System.Drawing.Color.Empty
        ChartArea2.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea2.Name = "Default"
        Me.chrCapacidadeMensal.ChartAreas.Add(ChartArea2)
        Legend2.AutoFitText = False
        Legend2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.Name = "Default"
        Me.chrCapacidadeMensal.Legends.Add(Legend2)
        Me.chrCapacidadeMensal.Location = New System.Drawing.Point(8, 197)
        Me.chrCapacidadeMensal.Name = "chrCapacidadeMensal"
        Me.chrCapacidadeMensal.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Me.chrCapacidadeMensal.Size = New System.Drawing.Size(1030, 280)
        Me.chrCapacidadeMensal.TabIndex = 113
        Me.chrCapacidadeMensal.UI.Toolbar.Enabled = True
        '
        'grdListagemMensal
        '
        Me.grdListagemMensal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagemMensal.AlternatingColors = True
        Me.grdListagemMensal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagemMensal.AutoEdit = True
        grdListagemMensal_DesignTimeLayout.LayoutString = resources.GetString("grdListagemMensal_DesignTimeLayout.LayoutString")
        Me.grdListagemMensal.DesignTimeLayout = grdListagemMensal_DesignTimeLayout
        Me.grdListagemMensal.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagemMensal.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagemMensal.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemMensal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemMensal.FrozenColumns = 1
        Me.grdListagemMensal.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemMensal.GroupByBoxVisible = False
        Me.grdListagemMensal.Location = New System.Drawing.Point(8, 76)
        Me.grdListagemMensal.Name = "grdListagemMensal"
        Me.grdListagemMensal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemMensal.RecordNavigator = True
        Me.grdListagemMensal.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagemMensal.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagemMensal.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemMensal.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemMensal.Size = New System.Drawing.Size(1030, 115)
        Me.grdListagemMensal.TabIndex = 7
        Me.grdListagemMensal.TabStop = False
        Me.grdListagemMensal.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagemMensal.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagemMensal.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagemMensal.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemMensal.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemMensal.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagemMensal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemMensal.VisualStyleManager = Me.vsmMain
        '
        'grpFiltroMensal
        '
        Me.grpFiltroMensal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltroMensal.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltroMensal.Controls.Add(Me.dtpDataFiltroMensal)
        Me.grpFiltroMensal.Controls.Add(Me.lblDataFiltroMensal)
        Me.grpFiltroMensal.Controls.Add(Me.btnFiltrarMensal)
        Me.grpFiltroMensal.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltroMensal.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltroMensal.Name = "grpFiltroMensal"
        Me.grpFiltroMensal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltroMensal.Size = New System.Drawing.Size(1030, 67)
        Me.grpFiltroMensal.TabIndex = 6
        Me.grpFiltroMensal.Text = "Filtro"
        Me.grpFiltroMensal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltroMensal.VisualStyleManager = Me.vsmMain
        '
        'dtpDataFiltroMensal
        '
        Me.dtpDataFiltroMensal.CustomFormat = "MM/yyyy"
        Me.dtpDataFiltroMensal.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataFiltroMensal.DropDownCalendar.Name = ""
        Me.dtpDataFiltroMensal.Location = New System.Drawing.Point(6, 34)
        Me.dtpDataFiltroMensal.Name = "dtpDataFiltroMensal"
        Me.dtpDataFiltroMensal.Size = New System.Drawing.Size(73, 20)
        Me.dtpDataFiltroMensal.TabIndex = 17
        Me.dtpDataFiltroMensal.Value = New Date(2016, 3, 9, 8, 48, 2, 0)
        '
        'lblDataFiltroMensal
        '
        Me.lblDataFiltroMensal.AutoSize = True
        Me.lblDataFiltroMensal.Location = New System.Drawing.Point(3, 17)
        Me.lblDataFiltroMensal.Name = "lblDataFiltroMensal"
        Me.lblDataFiltroMensal.Size = New System.Drawing.Size(30, 14)
        Me.lblDataFiltroMensal.TabIndex = 16
        Me.lblDataFiltroMensal.Text = "Mês:"
        '
        'btnFiltrarMensal
        '
        Me.btnFiltrarMensal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarMensal.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarMensal.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarMensal.Location = New System.Drawing.Point(930, 34)
        Me.btnFiltrarMensal.Name = "btnFiltrarMensal"
        Me.btnFiltrarMensal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarMensal.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarMensal.TabIndex = 4
        Me.btnFiltrarMensal.Text = "Filtrar"
        Me.btnFiltrarMensal.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'usrIndOrcamentoCapacidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "usrIndOrcamentoCapacidade"
        Me.Size = New System.Drawing.Size(1048, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagemDiaria.ResumeLayout(False)
        CType(Me.chrCapacidadeDiaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltroDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltroDiario.ResumeLayout(False)
        Me.grpFiltroDiario.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagListagemMensal.ResumeLayout(False)
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.chrCapacidadeMensal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagemMensal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltroMensal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltroMensal.ResumeLayout(False)
        Me.grpFiltroMensal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagemDiaria As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpFiltroDiario As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagListagemMensal As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagemMensal As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltroMensal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrarMensal As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataFiltroDiario As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltroDiario As System.Windows.Forms.Label
    Friend WithEvents dtpDataFiltroMensal As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltroMensal As System.Windows.Forms.Label
    Friend WithEvents chrCapacidadeDiaria As Dundas.Charting.WinControl.Chart
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents chrCapacidadeMensal As Dundas.Charting.WinControl.Chart
    Friend WithEvents btnExcelDiario As System.Windows.Forms.Button
    Friend WithEvents btnExcelMensal As System.Windows.Forms.Button
    Friend WithEvents btnOcultar As Janus.Windows.EditControls.UIButton

End Class
