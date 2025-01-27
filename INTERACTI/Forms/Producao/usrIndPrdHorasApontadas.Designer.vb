<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIndPrdHorasApontadas
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIndPrdHorasApontadas))
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim grdMensal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMensal_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagGrafico1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelListagem = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.chrHorasApontadas = New Dundas.Charting.WinControl.Chart()
        Me.pagMensal = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnGridMensal = New System.Windows.Forms.Button()
        Me.chrMensal = New Dundas.Charting.WinControl.Chart()
        Me.grdMensal = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPeríodo = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnOcultar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagGrafico1.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrHorasApontadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagMensal.SuspendLayout()
        CType(Me.chrMensal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMensal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(939, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.tabDados)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(937, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Indicador - Horas Apontadas"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 76)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(921, 398)
        Me.tabDados.TabIndex = 5
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagGrafico1, Me.pagMensal})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagGrafico1
        '
        Me.pagGrafico1.Controls.Add(Me.btnExcelListagem)
        Me.pagGrafico1.Controls.Add(Me.grdListagem)
        Me.pagGrafico1.Controls.Add(Me.chrHorasApontadas)
        Me.pagGrafico1.Key = "pagDadosGerais"
        Me.pagGrafico1.Location = New System.Drawing.Point(1, 22)
        Me.pagGrafico1.Name = "pagGrafico1"
        Me.pagGrafico1.Size = New System.Drawing.Size(919, 375)
        Me.pagGrafico1.TabStop = True
        Me.pagGrafico1.Text = "Geral"
        '
        'btnExcelListagem
        '
        Me.btnExcelListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelListagem.FlatAppearance.BorderSize = 0
        Me.btnExcelListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelListagem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelListagem.Location = New System.Drawing.Point(377, 354)
        Me.btnExcelListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelListagem.Name = "btnExcelListagem"
        Me.btnExcelListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelListagem.TabIndex = 114
        Me.btnExcelListagem.TabStop = False
        Me.btnExcelListagem.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(376, 2)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(540, 369)
        Me.grdListagem.TabIndex = 113
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'chrHorasApontadas
        '
        Me.chrHorasApontadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrHorasApontadas.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrHorasApontadas.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrHorasApontadas.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea1.AxisX.Title = "Período (dias)"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Quantidade"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrHorasApontadas.ChartAreas.Add(ChartArea1)
        Legend1.AutoFitText = False
        Legend1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.Name = "Default"
        Me.chrHorasApontadas.Legends.Add(Legend1)
        Me.chrHorasApontadas.Location = New System.Drawing.Point(5, 2)
        Me.chrHorasApontadas.Name = "chrHorasApontadas"
        Me.chrHorasApontadas.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Me.chrHorasApontadas.Size = New System.Drawing.Size(365, 369)
        Me.chrHorasApontadas.TabIndex = 8
        Me.chrHorasApontadas.UI.Toolbar.Enabled = True
        '
        'pagMensal
        '
        Me.pagMensal.Controls.Add(Me.btnGridMensal)
        Me.pagMensal.Controls.Add(Me.chrMensal)
        Me.pagMensal.Controls.Add(Me.grdMensal)
        Me.pagMensal.Key = "pagMensal"
        Me.pagMensal.Location = New System.Drawing.Point(1, 22)
        Me.pagMensal.Name = "pagMensal"
        Me.pagMensal.Size = New System.Drawing.Size(919, 375)
        Me.pagMensal.TabStop = True
        Me.pagMensal.Tag = "pagMensal"
        Me.pagMensal.Text = "Mensal Em Porcentagem"
        '
        'btnGridMensal
        '
        Me.btnGridMensal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGridMensal.BackColor = System.Drawing.Color.Transparent
        Me.btnGridMensal.FlatAppearance.BorderSize = 0
        Me.btnGridMensal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGridMensal.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnGridMensal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGridMensal.Location = New System.Drawing.Point(430, 354)
        Me.btnGridMensal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGridMensal.Name = "btnGridMensal"
        Me.btnGridMensal.Size = New System.Drawing.Size(24, 15)
        Me.btnGridMensal.TabIndex = 119
        Me.btnGridMensal.TabStop = False
        Me.btnGridMensal.UseVisualStyleBackColor = False
        '
        'chrMensal
        '
        Me.chrMensal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrMensal.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrMensal.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrMensal.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea2.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea2.AxisX.Title = "Período (dias)"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea2.AxisY.Title = "Quantidade"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea2.BorderColor = System.Drawing.Color.Empty
        ChartArea2.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea2.Name = "Default"
        Me.chrMensal.ChartAreas.Add(ChartArea2)
        Legend2.AutoFitText = False
        Legend2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.Name = "Default"
        Me.chrMensal.Legends.Add(Legend2)
        Me.chrMensal.Location = New System.Drawing.Point(5, 2)
        Me.chrMensal.Name = "chrMensal"
        Me.chrMensal.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Me.chrMensal.Size = New System.Drawing.Size(418, 369)
        Me.chrMensal.TabIndex = 118
        Me.chrMensal.UI.Toolbar.Enabled = True
        '
        'grdMensal
        '
        Me.grdMensal.AlternatingColors = True
        Me.grdMensal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMensal.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdMensal_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdMensal_DesignTimeLayout_Reference_0.Instance"), Object)
        grdMensal_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdMensal_DesignTimeLayout_Reference_0})
        grdMensal_DesignTimeLayout.LayoutString = resources.GetString("grdMensal_DesignTimeLayout.LayoutString")
        Me.grdMensal.DesignTimeLayout = grdMensal_DesignTimeLayout
        Me.grdMensal.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdMensal.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMensal.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMensal.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMensal.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMensal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdMensal.FrozenColumns = 1
        Me.grdMensal.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMensal.GroupByBoxVisible = False
        Me.grdMensal.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdMensal.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdMensal.Hierarchical = True
        Me.grdMensal.Location = New System.Drawing.Point(429, 2)
        Me.grdMensal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdMensal.Name = "grdMensal"
        Me.grdMensal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMensal.RecordNavigator = True
        Me.grdMensal.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMensal.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMensal.Size = New System.Drawing.Size(487, 369)
        Me.grdMensal.TabIndex = 117
        Me.grdMensal.TabStop = False
        Me.grdMensal.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMensal.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMensal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMensal.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPeríodo)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(921, 67)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(102, 34)
        Me.dtpDataTerminoFiltro.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 19
        Me.dtpDataTerminoFiltro.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(6, 34)
        Me.dtpDataInicioFiltro.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataInicioFiltro.TabIndex = 17
        Me.dtpDataInicioFiltro.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'lblDataPeríodo
        '
        Me.lblDataPeríodo.AutoSize = True
        Me.lblDataPeríodo.Location = New System.Drawing.Point(3, 17)
        Me.lblDataPeríodo.Name = "lblDataPeríodo"
        Me.lblDataPeríodo.Size = New System.Drawing.Size(46, 14)
        Me.lblDataPeríodo.TabIndex = 18
        Me.lblDataPeríodo.Text = "Período:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(821, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 1
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
        Me.grpControl.Size = New System.Drawing.Size(921, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnOcultar
        '
        Me.btnOcultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOcultar.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnOcultar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOcultar.Location = New System.Drawing.Point(708, 17)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOcultar.Size = New System.Drawing.Size(106, 23)
        Me.btnOcultar.TabIndex = 27
        Me.btnOcultar.Text = "Ocultar Tabela"
        Me.btnOcultar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(821, 17)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'usrIndPrdHorasApontadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "usrIndPrdHorasApontadas"
        Me.Size = New System.Drawing.Size(939, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagGrafico1.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrHorasApontadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagMensal.ResumeLayout(False)
        CType(Me.chrMensal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMensal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagGrafico1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents chrHorasApontadas As Dundas.Charting.WinControl.Chart
    Friend WithEvents btnExcelListagem As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPeríodo As System.Windows.Forms.Label
    Friend WithEvents btnOcultar As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagMensal As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents chrMensal As Dundas.Charting.WinControl.Chart
    Friend WithEvents grdMensal As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnGridMensal As System.Windows.Forms.Button

End Class
