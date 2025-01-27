<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIndProjeto
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIndProjeto))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagGrafico1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrGraficoEtapa = New Dundas.Charting.WinControl.Chart()
        Me.pagAmostra = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.btnConfigurarGridAmostra = New System.Windows.Forms.Button()
        Me.btnExcelGridAmostra = New System.Windows.Forms.Button()
        Me.btnAgruparGridAmostra = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnInserirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboEtapaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtMetaFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMetaFiltro = New System.Windows.Forms.Label()
        Me.lblEtapaFiltro = New System.Windows.Forms.Label()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPeríodo = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagGrafico1.SuspendLayout()
        CType(Me.chrGraficoEtapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagAmostra.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
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
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Indicador - Projeto"
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
        Me.tabDados.Size = New System.Drawing.Size(982, 401)
        Me.tabDados.TabIndex = 5
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagGrafico1, Me.pagAmostra})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagGrafico1
        '
        Me.pagGrafico1.Controls.Add(Me.chrGraficoEtapa)
        Me.pagGrafico1.Key = "pagDadosGerais"
        Me.pagGrafico1.Location = New System.Drawing.Point(1, 22)
        Me.pagGrafico1.Name = "pagGrafico1"
        Me.pagGrafico1.Size = New System.Drawing.Size(980, 378)
        Me.pagGrafico1.TabStop = True
        Me.pagGrafico1.Text = "Gráfico"
        '
        'chrGraficoEtapa
        '
        Me.chrGraficoEtapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrGraficoEtapa.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrGraficoEtapa.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrGraficoEtapa.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea1.AxisX.Title = "Período (dias)"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Quantidade"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrGraficoEtapa.ChartAreas.Add(ChartArea1)
        Legend1.AutoFitText = False
        Legend1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.Name = "Default"
        Me.chrGraficoEtapa.Legends.Add(Legend1)
        Me.chrGraficoEtapa.Location = New System.Drawing.Point(3, 3)
        Me.chrGraficoEtapa.Name = "chrGraficoEtapa"
        Me.chrGraficoEtapa.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Me.chrGraficoEtapa.Size = New System.Drawing.Size(974, 372)
        Me.chrGraficoEtapa.TabIndex = 2
        Me.chrGraficoEtapa.UI.Toolbar.Enabled = True
        '
        'pagAmostra
        '
        Me.pagAmostra.Controls.Add(Me.grdListagem)
        Me.pagAmostra.Controls.Add(Me.btnConfigurarGridAmostra)
        Me.pagAmostra.Controls.Add(Me.btnExcelGridAmostra)
        Me.pagAmostra.Controls.Add(Me.btnAgruparGridAmostra)
        Me.pagAmostra.Controls.Add(Me.Button3)
        Me.pagAmostra.Controls.Add(Me.btnInserirAmostra)
        Me.pagAmostra.Controls.Add(Me.btnExcluirAmostra)
        Me.pagAmostra.Location = New System.Drawing.Point(1, 22)
        Me.pagAmostra.Name = "pagAmostra"
        Me.pagAmostra.Size = New System.Drawing.Size(980, 378)
        Me.pagAmostra.TabStop = True
        Me.pagAmostra.Text = "Dados"
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 3)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(964, 372)
        Me.grdListagem.TabIndex = 26
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'btnConfigurarGridAmostra
        '
        Me.btnConfigurarGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridAmostra.Location = New System.Drawing.Point(11, 1378)
        Me.btnConfigurarGridAmostra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridAmostra.Name = "btnConfigurarGridAmostra"
        Me.btnConfigurarGridAmostra.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridAmostra.TabIndex = 25
        Me.btnConfigurarGridAmostra.TabStop = False
        Me.btnConfigurarGridAmostra.UseVisualStyleBackColor = False
        '
        'btnExcelGridAmostra
        '
        Me.btnExcelGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnExcelGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridAmostra.Location = New System.Drawing.Point(57, 1378)
        Me.btnExcelGridAmostra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridAmostra.Name = "btnExcelGridAmostra"
        Me.btnExcelGridAmostra.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridAmostra.TabIndex = 24
        Me.btnExcelGridAmostra.TabStop = False
        Me.btnExcelGridAmostra.UseVisualStyleBackColor = False
        '
        'btnAgruparGridAmostra
        '
        Me.btnAgruparGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridAmostra.Location = New System.Drawing.Point(33, 1378)
        Me.btnAgruparGridAmostra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridAmostra.Name = "btnAgruparGridAmostra"
        Me.btnAgruparGridAmostra.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridAmostra.TabIndex = 23
        Me.btnAgruparGridAmostra.TabStop = False
        Me.btnAgruparGridAmostra.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(11, 1380)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 15)
        Me.Button3.TabIndex = 22
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnInserirAmostra
        '
        Me.btnInserirAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirAmostra.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirAmostra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirAmostra.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirAmostra.Location = New System.Drawing.Point(3821, 7)
        Me.btnInserirAmostra.Name = "btnInserirAmostra"
        Me.btnInserirAmostra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirAmostra.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirAmostra.TabIndex = 14
        Me.btnInserirAmostra.Text = "Inserir"
        Me.btnInserirAmostra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirAmostra
        '
        Me.btnExcluirAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirAmostra.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirAmostra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirAmostra.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirAmostra.Location = New System.Drawing.Point(3821, 36)
        Me.btnExcluirAmostra.Name = "btnExcluirAmostra"
        Me.btnExcluirAmostra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirAmostra.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirAmostra.TabIndex = 15
        Me.btnExcluirAmostra.Text = "Excluir"
        Me.btnExcluirAmostra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboEtapaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtMetaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMetaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblEtapaFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPeríodo)
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
        'cboEtapaFiltro
        '
        Me.cboEtapaFiltro.AutoSize = False
        Me.cboEtapaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEtapaFiltro.Location = New System.Drawing.Point(201, 37)
        Me.cboEtapaFiltro.Name = "cboEtapaFiltro"
        Me.cboEtapaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEtapaFiltro.Size = New System.Drawing.Size(175, 20)
        Me.cboEtapaFiltro.TabIndex = 2
        '
        'txtMetaFiltro
        '
        Me.txtMetaFiltro.FormatString = "0"
        Me.txtMetaFiltro.Location = New System.Drawing.Point(382, 37)
        Me.txtMetaFiltro.Name = "txtMetaFiltro"
        Me.txtMetaFiltro.Size = New System.Drawing.Size(58, 20)
        Me.txtMetaFiltro.TabIndex = 3
        Me.txtMetaFiltro.Text = "0"
        Me.txtMetaFiltro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMetaFiltro
        '
        Me.lblMetaFiltro.AutoSize = True
        Me.lblMetaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMetaFiltro.Location = New System.Drawing.Point(379, 20)
        Me.lblMetaFiltro.Name = "lblMetaFiltro"
        Me.lblMetaFiltro.Size = New System.Drawing.Size(33, 14)
        Me.lblMetaFiltro.TabIndex = 32
        Me.lblMetaFiltro.Text = "Meta:"
        '
        'lblEtapaFiltro
        '
        Me.lblEtapaFiltro.AutoSize = True
        Me.lblEtapaFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblEtapaFiltro.Location = New System.Drawing.Point(198, 20)
        Me.lblEtapaFiltro.Name = "lblEtapaFiltro"
        Me.lblEtapaFiltro.Size = New System.Drawing.Size(37, 14)
        Me.lblEtapaFiltro.TabIndex = 30
        Me.lblEtapaFiltro.Text = "Etapa:"
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
        Me.dtpDataTerminoFiltro.TabIndex = 1
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
        Me.dtpDataInicioFiltro.TabIndex = 0
        Me.dtpDataInicioFiltro.Value = New Date(2014, 9, 23, 0, 0, 0, 0)
        '
        'lblDataPeríodo
        '
        Me.lblDataPeríodo.AutoSize = True
        Me.lblDataPeríodo.Location = New System.Drawing.Point(6, 20)
        Me.lblDataPeríodo.Name = "lblDataPeríodo"
        Me.lblDataPeríodo.Size = New System.Drawing.Size(43, 14)
        Me.lblDataPeríodo.TabIndex = 0
        Me.lblDataPeríodo.Text = "Período"
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
        'UiTabPage1
        '
        Me.UiTabPage1.Key = "pagDadosCliente"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 22)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(980, 378)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Visible = False
        '
        'usrIndProjeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "usrIndProjeto"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagGrafico1.ResumeLayout(False)
        CType(Me.chrGraficoEtapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagAmostra.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPeríodo As System.Windows.Forms.Label
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblEtapaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtMetaFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMetaFiltro As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagAmostra As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridAmostra As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnInserirAmostra As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirAmostra As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagGrafico1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents chrGraficoEtapa As Dundas.Charting.WinControl.Chart
    Friend WithEvents cboEtapaFiltro As Janus.Windows.EditControls.UIComboBox

End Class
