<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEntradaRelatorioCFOP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEntradaRelatorioCFOP))
        Dim grdListagemAnalitico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagemSintetico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.tabAnalitico = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGridAnalitico = New System.Windows.Forms.Button()
        Me.btnConfigurarGridAnalitico = New System.Windows.Forms.Button()
        Me.grdListagemAnalitico = New Janus.Windows.GridEX.GridEX()
        Me.tabSintetico = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGridSintetico = New System.Windows.Forms.Button()
        Me.btnConfigurarGridSintetico = New System.Windows.Forms.Button()
        Me.grdListagemSintetico = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.tabAnalitico.SuspendLayout()
        CType(Me.grdListagemAnalitico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSintetico.SuspendLayout()
        CType(Me.grdListagemSintetico, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(847, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.tabDados)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(845, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório CFOP"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblTipoDocumento)
        Me.grpFiltro.Controls.Add(Me.cboTipoDocumento)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(829, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(234, 17)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(102, 14)
        Me.lblTipoDocumento.TabIndex = 12
        Me.lblTipoDocumento.Text = "Tipo do Documento:"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoSize = False
        Me.cboTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumento.Location = New System.Drawing.Point(237, 34)
        Me.cboTipoDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumento.Size = New System.Drawing.Size(202, 20)
        Me.cboTipoDocumento.TabIndex = 13
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 5
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
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 4
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 3
        Me.lblDataFiltro.Text = "Data:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(729, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnImprimir)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 394)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(829, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(535, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 5
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(632, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Visible = False
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(729, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 69)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(829, 322)
        Me.tabDados.TabIndex = 7
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabAnalitico, Me.tabSintetico})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'tabAnalitico
        '
        Me.tabAnalitico.Controls.Add(Me.btnAgruparGridAnalitico)
        Me.tabAnalitico.Controls.Add(Me.btnConfigurarGridAnalitico)
        Me.tabAnalitico.Controls.Add(Me.grdListagemAnalitico)
        Me.tabAnalitico.Location = New System.Drawing.Point(1, 22)
        Me.tabAnalitico.Name = "tabAnalitico"
        Me.tabAnalitico.Size = New System.Drawing.Size(827, 299)
        Me.tabAnalitico.TabStop = True
        Me.tabAnalitico.Text = "Analítico"
        '
        'btnAgruparGridAnalitico
        '
        Me.btnAgruparGridAnalitico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridAnalitico.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridAnalitico.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridAnalitico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridAnalitico.Image = CType(resources.GetObject("btnAgruparGridAnalitico.Image"), System.Drawing.Image)
        Me.btnAgruparGridAnalitico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridAnalitico.Location = New System.Drawing.Point(37, 273)
        Me.btnAgruparGridAnalitico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridAnalitico.Name = "btnAgruparGridAnalitico"
        Me.btnAgruparGridAnalitico.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridAnalitico.TabIndex = 5
        Me.btnAgruparGridAnalitico.TabStop = False
        Me.btnAgruparGridAnalitico.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridAnalitico
        '
        Me.btnConfigurarGridAnalitico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridAnalitico.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridAnalitico.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridAnalitico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridAnalitico.Image = CType(resources.GetObject("btnConfigurarGridAnalitico.Image"), System.Drawing.Image)
        Me.btnConfigurarGridAnalitico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridAnalitico.Location = New System.Drawing.Point(13, 275)
        Me.btnConfigurarGridAnalitico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridAnalitico.Name = "btnConfigurarGridAnalitico"
        Me.btnConfigurarGridAnalitico.Size = New System.Drawing.Size(24, 13)
        Me.btnConfigurarGridAnalitico.TabIndex = 4
        Me.btnConfigurarGridAnalitico.TabStop = False
        Me.btnConfigurarGridAnalitico.UseVisualStyleBackColor = False
        '
        'grdListagemAnalitico
        '
        Me.grdListagemAnalitico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagemAnalitico.AlternatingColors = True
        Me.grdListagemAnalitico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagemAnalitico_DesignTimeLayout.LayoutString = resources.GetString("grdListagemAnalitico_DesignTimeLayout.LayoutString")
        Me.grdListagemAnalitico.DesignTimeLayout = grdListagemAnalitico_DesignTimeLayout
        Me.grdListagemAnalitico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemAnalitico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagemAnalitico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemAnalitico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemAnalitico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemAnalitico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemAnalitico.GroupByBoxVisible = false
        Me.grdListagemAnalitico.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagemAnalitico.Hierarchical = true
        Me.grdListagemAnalitico.Location = New System.Drawing.Point(8, 8)
        Me.grdListagemAnalitico.Name = "grdListagemAnalitico"
        Me.grdListagemAnalitico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemAnalitico.RecordNavigator = true
        Me.grdListagemAnalitico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemAnalitico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemAnalitico.Size = New System.Drawing.Size(811, 282)
        Me.grdListagemAnalitico.TabIndex = 6
        Me.grdListagemAnalitico.TabStop = false
        Me.grdListagemAnalitico.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagemAnalitico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemAnalitico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemAnalitico.VisualStyleManager = Me.vsmMain
        '
        'tabSintetico
        '
        Me.tabSintetico.Controls.Add(Me.btnAgruparGridSintetico)
        Me.tabSintetico.Controls.Add(Me.btnConfigurarGridSintetico)
        Me.tabSintetico.Controls.Add(Me.grdListagemSintetico)
        Me.tabSintetico.Location = New System.Drawing.Point(1, 22)
        Me.tabSintetico.Name = "tabSintetico"
        Me.tabSintetico.Size = New System.Drawing.Size(827, 299)
        Me.tabSintetico.TabStop = true
        Me.tabSintetico.Text = "Sintético"
        '
        'btnAgruparGridSintetico
        '
        Me.btnAgruparGridSintetico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridSintetico.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridSintetico.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridSintetico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridSintetico.Image = CType(resources.GetObject("btnAgruparGridSintetico.Image"),System.Drawing.Image)
        Me.btnAgruparGridSintetico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridSintetico.Location = New System.Drawing.Point(37, 273)
        Me.btnAgruparGridSintetico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridSintetico.Name = "btnAgruparGridSintetico"
        Me.btnAgruparGridSintetico.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridSintetico.TabIndex = 7
        Me.btnAgruparGridSintetico.TabStop = false
        Me.btnAgruparGridSintetico.UseVisualStyleBackColor = false
        '
        'btnConfigurarGridSintetico
        '
        Me.btnConfigurarGridSintetico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridSintetico.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridSintetico.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridSintetico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridSintetico.Image = CType(resources.GetObject("btnConfigurarGridSintetico.Image"),System.Drawing.Image)
        Me.btnConfigurarGridSintetico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridSintetico.Location = New System.Drawing.Point(13, 275)
        Me.btnConfigurarGridSintetico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridSintetico.Name = "btnConfigurarGridSintetico"
        Me.btnConfigurarGridSintetico.Size = New System.Drawing.Size(24, 13)
        Me.btnConfigurarGridSintetico.TabIndex = 6
        Me.btnConfigurarGridSintetico.TabStop = false
        Me.btnConfigurarGridSintetico.UseVisualStyleBackColor = false
        '
        'grdListagemSintetico
        '
        Me.grdListagemSintetico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagemSintetico.AlternatingColors = true
        Me.grdListagemSintetico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        grdListagemSintetico_DesignTimeLayout.LayoutString = resources.GetString("grdListagemSintetico_DesignTimeLayout.LayoutString")
        Me.grdListagemSintetico.DesignTimeLayout = grdListagemSintetico_DesignTimeLayout
        Me.grdListagemSintetico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemSintetico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagemSintetico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemSintetico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemSintetico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemSintetico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemSintetico.GroupByBoxVisible = false
        Me.grdListagemSintetico.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagemSintetico.Hierarchical = true
        Me.grdListagemSintetico.Location = New System.Drawing.Point(8, 8)
        Me.grdListagemSintetico.Name = "grdListagemSintetico"
        Me.grdListagemSintetico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemSintetico.RecordNavigator = true
        Me.grdListagemSintetico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemSintetico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemSintetico.Size = New System.Drawing.Size(811, 282)
        Me.grdListagemSintetico.TabIndex = 3
        Me.grdListagemSintetico.TabStop = false
        Me.grdListagemSintetico.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagemSintetico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemSintetico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemSintetico.VisualStyleManager = Me.vsmMain
        '
        'usrFatEntradaRelatorioCFOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatEntradaRelatorioCFOP"
        Me.Size = New System.Drawing.Size(847, 476)
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagLista.ResumeLayout(false)
        CType(Me.grpFiltro,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFiltro.ResumeLayout(false)
        Me.grpFiltro.PerformLayout
        CType(Me.grpControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControl.ResumeLayout(false)
        CType(Me.tabDados,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabDados.ResumeLayout(false)
        Me.tabAnalitico.ResumeLayout(false)
        CType(Me.grdListagemAnalitico,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabSintetico.ResumeLayout(false)
        CType(Me.grdListagemSintetico,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents tabAnalitico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabSintetico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagemSintetico As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgruparGridAnalitico As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridAnalitico As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridSintetico As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridSintetico As System.Windows.Forms.Button
    Friend WithEvents grdListagemAnalitico As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As Janus.Windows.EditControls.UIComboBox

End Class
