<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVen000000003
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVen000000003))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.lblDataOrcamentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataOrcamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataOrcamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblAgrupadoPorFiltro = New System.Windows.Forms.Label()
        Me.cboAgrupadoPorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProbabilidadeVendaFiltro = New System.Windows.Forms.Label()
        Me.lblDataPrevisaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.cboProbabilidadeVendaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboSegmentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSegmentoFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.dtpDataPrevisaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPrevisaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboVendedorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblVendedorFiltro = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório de Vendas - VEN000000003"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 92
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 91
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataOrcamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataOrcamentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataOrcamentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAgrupadoPorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAgrupadoPorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProbabilidadeVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPrevisaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.cboProbabilidadeVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboSegmentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSegmentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboVendedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblVendedorFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 147)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.AutoSize = False
        Me.cboClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFiltro.Location = New System.Drawing.Point(237, 36)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(387, 20)
        Me.cboClienteFiltro.TabIndex = 4
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblClienteFiltro.Location = New System.Drawing.Point(234, 19)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 3
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'lblDataOrcamentoFiltro
        '
        Me.lblDataOrcamentoFiltro.AutoSize = True
        Me.lblDataOrcamentoFiltro.Location = New System.Drawing.Point(6, 19)
        Me.lblDataOrcamentoFiltro.Name = "lblDataOrcamentoFiltro"
        Me.lblDataOrcamentoFiltro.Size = New System.Drawing.Size(88, 14)
        Me.lblDataOrcamentoFiltro.TabIndex = 0
        Me.lblDataOrcamentoFiltro.Text = "Data Orçamento:"
        '
        'dtpDataOrcamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataOrcamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOrcamentoTerminoFiltro.Location = New System.Drawing.Point(123, 36)
        Me.dtpDataOrcamentoTerminoFiltro.Name = "dtpDataOrcamentoTerminoFiltro"
        Me.dtpDataOrcamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataOrcamentoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataOrcamentoTerminoFiltro.TabIndex = 2
        '
        'dtpDataOrcamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataOrcamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOrcamentoInicioFiltro.Location = New System.Drawing.Point(9, 36)
        Me.dtpDataOrcamentoInicioFiltro.Name = "dtpDataOrcamentoInicioFiltro"
        Me.dtpDataOrcamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataOrcamentoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataOrcamentoInicioFiltro.TabIndex = 1
        '
        'lblAgrupadoPorFiltro
        '
        Me.lblAgrupadoPorFiltro.AutoSize = True
        Me.lblAgrupadoPorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAgrupadoPorFiltro.Location = New System.Drawing.Point(234, 99)
        Me.lblAgrupadoPorFiltro.Name = "lblAgrupadoPorFiltro"
        Me.lblAgrupadoPorFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblAgrupadoPorFiltro.TabIndex = 16
        Me.lblAgrupadoPorFiltro.Text = "Agrupado por:"
        '
        'cboAgrupadoPorFiltro
        '
        Me.cboAgrupadoPorFiltro.Location = New System.Drawing.Point(237, 116)
        Me.cboAgrupadoPorFiltro.Name = "cboAgrupadoPorFiltro"
        Me.cboAgrupadoPorFiltro.Size = New System.Drawing.Size(236, 20)
        Me.cboAgrupadoPorFiltro.TabIndex = 17
        '
        'lblProbabilidadeVendaFiltro
        '
        Me.lblProbabilidadeVendaFiltro.AutoSize = True
        Me.lblProbabilidadeVendaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProbabilidadeVendaFiltro.Location = New System.Drawing.Point(627, 59)
        Me.lblProbabilidadeVendaFiltro.Name = "lblProbabilidadeVendaFiltro"
        Me.lblProbabilidadeVendaFiltro.Size = New System.Drawing.Size(123, 14)
        Me.lblProbabilidadeVendaFiltro.TabIndex = 12
        Me.lblProbabilidadeVendaFiltro.Text = "Probabilidade de Venda:"
        '
        'lblDataPrevisaoFiltro
        '
        Me.lblDataPrevisaoFiltro.AutoSize = True
        Me.lblDataPrevisaoFiltro.Location = New System.Drawing.Point(6, 59)
        Me.lblDataPrevisaoFiltro.Name = "lblDataPrevisaoFiltro"
        Me.lblDataPrevisaoFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblDataPrevisaoFiltro.TabIndex = 7
        Me.lblDataPrevisaoFiltro.Text = "Data Previsão:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(883, 113)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 18
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboProbabilidadeVendaFiltro
        '
        Me.cboProbabilidadeVendaFiltro.AutoSize = False
        Me.cboProbabilidadeVendaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProbabilidadeVendaFiltro.Location = New System.Drawing.Point(630, 76)
        Me.cboProbabilidadeVendaFiltro.Name = "cboProbabilidadeVendaFiltro"
        Me.cboProbabilidadeVendaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProbabilidadeVendaFiltro.Size = New System.Drawing.Size(236, 20)
        Me.cboProbabilidadeVendaFiltro.TabIndex = 13
        '
        'cboSegmentoFiltro
        '
        Me.cboSegmentoFiltro.AutoSize = False
        Me.cboSegmentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSegmentoFiltro.Location = New System.Drawing.Point(630, 36)
        Me.cboSegmentoFiltro.Name = "cboSegmentoFiltro"
        Me.cboSegmentoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSegmentoFiltro.Size = New System.Drawing.Size(236, 20)
        Me.cboSegmentoFiltro.TabIndex = 6
        '
        'lblSegmentoFiltro
        '
        Me.lblSegmentoFiltro.AutoSize = True
        Me.lblSegmentoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSegmentoFiltro.Location = New System.Drawing.Point(627, 19)
        Me.lblSegmentoFiltro.Name = "lblSegmentoFiltro"
        Me.lblSegmentoFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblSegmentoFiltro.TabIndex = 5
        Me.lblSegmentoFiltro.Text = "Segmento:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.AutoSize = False
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(237, 76)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(387, 20)
        Me.cboGrupoItemFiltro.TabIndex = 11
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(234, 59)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblGrupoItemFiltro.TabIndex = 10
        Me.lblGrupoItemFiltro.Text = "Grupo de Item:"
        '
        'dtpDataPrevisaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoTerminoFiltro.Location = New System.Drawing.Point(123, 76)
        Me.dtpDataPrevisaoTerminoFiltro.Name = "dtpDataPrevisaoTerminoFiltro"
        Me.dtpDataPrevisaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoTerminoFiltro.TabIndex = 9
        '
        'dtpDataPrevisaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoInicioFiltro.Location = New System.Drawing.Point(9, 76)
        Me.dtpDataPrevisaoInicioFiltro.Name = "dtpDataPrevisaoInicioFiltro"
        Me.dtpDataPrevisaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoInicioFiltro.TabIndex = 8
        '
        'cboVendedorFiltro
        '
        Me.cboVendedorFiltro.AutoSize = False
        Me.cboVendedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboVendedorFiltro.Location = New System.Drawing.Point(9, 116)
        Me.cboVendedorFiltro.Name = "cboVendedorFiltro"
        Me.cboVendedorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboVendedorFiltro.Size = New System.Drawing.Size(222, 20)
        Me.cboVendedorFiltro.TabIndex = 15
        '
        'lblVendedorFiltro
        '
        Me.lblVendedorFiltro.AutoSize = True
        Me.lblVendedorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVendedorFiltro.Location = New System.Drawing.Point(6, 99)
        Me.lblVendedorFiltro.Name = "lblVendedorFiltro"
        Me.lblVendedorFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblVendedorFiltro.TabIndex = 14
        Me.lblVendedorFiltro.Text = "Vendedor:"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 160)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 320)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(7, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 3
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(102, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 4
        Me.cboCongelarColuna.TabStop = False
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(676, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(200, 23)
        Me.btnVisualizarImpressao.TabIndex = 1
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrVen000000003
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrVen000000003"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAgrupadoPorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAgrupadoPorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblProbabilidadeVendaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataPrevisaoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboProbabilidadeVendaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboSegmentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSegmentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataPrevisaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPrevisaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboVendedorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblVendedorFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataOrcamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataOrcamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataOrcamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button

End Class
