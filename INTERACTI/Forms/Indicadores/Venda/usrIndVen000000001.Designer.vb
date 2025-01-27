<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIndVen000000001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIndVen000000001))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrMain = New Dundas.Charting.WinControl.Chart()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboComparativoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblComparativoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoComparativoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoComparativoFiltro = New System.Windows.Forms.Label()
        Me.cboVendedorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblVendedorFiltro = New System.Windows.Forms.Label()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.cboVisualizarPorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblVisualizarPorFiltro = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.chrMain, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagListagem.Controls.Add(Me.chrMain)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
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
        Me.pagListagem.Text = "Indicador - Vendedor"
        '
        'chrMain
        '
        Me.chrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrMain.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrMain.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrMain.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.LabelsAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.FontAngle = 90
        ChartArea1.AxisX.LineWidth = 2
        ChartArea1.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea1.AxisX.Title = "Período"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelsAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelStyle.Format = "#,#0.00"
        ChartArea1.AxisY.Title = "Receita (R$)"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrMain.ChartAreas.Add(ChartArea1)
        Legend1.AutoFitText = False
        Legend1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.Name = "Default"
        Me.chrMain.Legends.Add(Legend1)
        Me.chrMain.Location = New System.Drawing.Point(8, 79)
        Me.chrMain.Name = "chrMain"
        Me.chrMain.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrMain.Size = New System.Drawing.Size(654, 401)
        Me.chrMain.TabIndex = 1
        Me.chrMain.UI.Toolbar.Enabled = True
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(672, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 3
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnAutoResize = True
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(671, 79)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(319, 401)
        Me.grdListagem.TabIndex = 2
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
        Me.grpFiltro.Controls.Add(Me.cboVisualizarPorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblVisualizarPorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboComparativoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblComparativoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoComparativoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoComparativoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboVendedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblVendedorFiltro)
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
        'cboComparativoFiltro
        '
        Me.cboComparativoFiltro.Location = New System.Drawing.Point(661, 37)
        Me.cboComparativoFiltro.Name = "cboComparativoFiltro"
        Me.cboComparativoFiltro.Size = New System.Drawing.Size(192, 20)
        Me.cboComparativoFiltro.TabIndex = 9
        '
        'lblComparativoFiltro
        '
        Me.lblComparativoFiltro.AutoSize = True
        Me.lblComparativoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComparativoFiltro.Location = New System.Drawing.Point(658, 20)
        Me.lblComparativoFiltro.Name = "lblComparativoFiltro"
        Me.lblComparativoFiltro.Size = New System.Drawing.Size(70, 14)
        Me.lblComparativoFiltro.TabIndex = 8
        Me.lblComparativoFiltro.Text = "Comparativo:"
        '
        'cboTipoComparativoFiltro
        '
        Me.cboTipoComparativoFiltro.Location = New System.Drawing.Point(504, 37)
        Me.cboTipoComparativoFiltro.Name = "cboTipoComparativoFiltro"
        Me.cboTipoComparativoFiltro.Size = New System.Drawing.Size(151, 20)
        Me.cboTipoComparativoFiltro.TabIndex = 7
        '
        'lblTipoComparativoFiltro
        '
        Me.lblTipoComparativoFiltro.AutoSize = True
        Me.lblTipoComparativoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoComparativoFiltro.Location = New System.Drawing.Point(501, 20)
        Me.lblTipoComparativoFiltro.Name = "lblTipoComparativoFiltro"
        Me.lblTipoComparativoFiltro.Size = New System.Drawing.Size(93, 14)
        Me.lblTipoComparativoFiltro.TabIndex = 6
        Me.lblTipoComparativoFiltro.Text = "Tipo Comparativo:"
        '
        'cboVendedorFiltro
        '
        Me.cboVendedorFiltro.Location = New System.Drawing.Point(311, 37)
        Me.cboVendedorFiltro.Name = "cboVendedorFiltro"
        Me.cboVendedorFiltro.Size = New System.Drawing.Size(187, 20)
        Me.cboVendedorFiltro.TabIndex = 5
        '
        'lblVendedorFiltro
        '
        Me.lblVendedorFiltro.AutoSize = True
        Me.lblVendedorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVendedorFiltro.Location = New System.Drawing.Point(308, 20)
        Me.lblVendedorFiltro.Name = "lblVendedorFiltro"
        Me.lblVendedorFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblVendedorFiltro.TabIndex = 4
        Me.lblVendedorFiltro.Text = "Vendedor:"
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
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(6, 20)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 1
        Me.lblDataFiltro.Text = "Data:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 10
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
        'cboVisualizarPorFiltro
        '
        Me.cboVisualizarPorFiltro.Location = New System.Drawing.Point(201, 37)
        Me.cboVisualizarPorFiltro.Name = "cboVisualizarPorFiltro"
        Me.cboVisualizarPorFiltro.Size = New System.Drawing.Size(104, 20)
        Me.cboVisualizarPorFiltro.TabIndex = 3
        '
        'lblVisualizarPorFiltro
        '
        Me.lblVisualizarPorFiltro.AutoSize = True
        Me.lblVisualizarPorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVisualizarPorFiltro.Location = New System.Drawing.Point(198, 20)
        Me.lblVisualizarPorFiltro.Name = "lblVisualizarPorFiltro"
        Me.lblVisualizarPorFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblVisualizarPorFiltro.TabIndex = 2
        Me.lblVisualizarPorFiltro.Text = "Visualizar por:"
        '
        'usrIndVen000000001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "usrIndVen000000001"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.chrMain, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoComparativoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoComparativoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboVendedorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblVendedorFiltro As System.Windows.Forms.Label
    Friend WithEvents chrMain As Dundas.Charting.WinControl.Chart
    Friend WithEvents cboComparativoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblComparativoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboVisualizarPorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblVisualizarPorFiltro As System.Windows.Forms.Label

End Class
