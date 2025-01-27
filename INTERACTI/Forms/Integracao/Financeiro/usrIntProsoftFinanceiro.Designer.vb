<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIntProsoftFinanceiro
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
        Dim grdNotaFiscal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIntProsoftFinanceiro))
        Dim grdModelo1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabNFe = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosCapa = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grdNotaFiscal = New Janus.Windows.GridEX.GridEX()
        Me.pagNFReferenciada = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridModelo = New System.Windows.Forms.Button()
        Me.btnAgruparGridModelo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridModelo = New System.Windows.Forms.Button()
        Me.grdModelo1 = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblTipoOperacao = New System.Windows.Forms.Label()
        Me.cboTipoOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnEnviarEmail = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnGerarArquivo = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.tabNFe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNFe.SuspendLayout()
        Me.pagDadosCapa.SuspendLayout()
        CType(Me.grdNotaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagNFReferenciada.SuspendLayout()
        CType(Me.grdModelo1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.tabNFe)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Integração - Prosoft"
        '
        'tabNFe
        '
        Me.tabNFe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabNFe.BackColor = System.Drawing.Color.Transparent
        Me.tabNFe.FocusOnClick = False
        Me.tabNFe.Location = New System.Drawing.Point(8, 75)
        Me.tabNFe.Name = "tabNFe"
        Me.tabNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabNFe.ShowFocusRectangle = False
        Me.tabNFe.Size = New System.Drawing.Size(897, 402)
        Me.tabNFe.TabIndex = 41
        Me.tabNFe.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosCapa, Me.pagNFReferenciada})
        Me.tabNFe.TabStop = False
        Me.tabNFe.VisualStyleManager = Me.vsmMain
        '
        'pagDadosCapa
        '
        Me.pagDadosCapa.Controls.Add(Me.btnExcelGrid)
        Me.pagDadosCapa.Controls.Add(Me.btnConfigurarGrid)
        Me.pagDadosCapa.Controls.Add(Me.btnAgruparGrid)
        Me.pagDadosCapa.Controls.Add(Me.grdNotaFiscal)
        Me.pagDadosCapa.Key = "pagDadosCapa"
        Me.pagDadosCapa.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosCapa.Name = "pagDadosCapa"
        Me.pagDadosCapa.Size = New System.Drawing.Size(895, 379)
        Me.pagDadosCapa.TabStop = True
        Me.pagDadosCapa.Text = "Prosoft"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(56, 358)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 93
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(25, 16)
        Me.btnConfigurarGrid.TabIndex = 40
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(30, 358)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 92
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grdNotaFiscal
        '
        Me.grdNotaFiscal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdNotaFiscal.AlternatingColors = True
        Me.grdNotaFiscal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdNotaFiscal_DesignTimeLayout.LayoutString = resources.GetString("grdNotaFiscal_DesignTimeLayout.LayoutString")
        Me.grdNotaFiscal.DesignTimeLayout = grdNotaFiscal_DesignTimeLayout
        Me.grdNotaFiscal.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdNotaFiscal.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdNotaFiscal.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdNotaFiscal.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNotaFiscal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNotaFiscal.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNotaFiscal.GroupByBoxVisible = False
        Me.grdNotaFiscal.Location = New System.Drawing.Point(8, 7)
        Me.grdNotaFiscal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdNotaFiscal.Name = "grdNotaFiscal"
        Me.grdNotaFiscal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNotaFiscal.RecordNavigator = True
        Me.grdNotaFiscal.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdNotaFiscal.Size = New System.Drawing.Size(879, 368)
        Me.grdNotaFiscal.TabIndex = 39
        Me.grdNotaFiscal.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscal.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdNotaFiscal.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNotaFiscal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNotaFiscal.VisualStyleManager = Me.vsmMain
        '
        'pagNFReferenciada
        '
        Me.pagNFReferenciada.Controls.Add(Me.btnExcelGridModelo)
        Me.pagNFReferenciada.Controls.Add(Me.btnAgruparGridModelo)
        Me.pagNFReferenciada.Controls.Add(Me.btnConfigurarGridModelo)
        Me.pagNFReferenciada.Controls.Add(Me.grdModelo1)
        Me.pagNFReferenciada.Key = "pagNFReferenciada"
        Me.pagNFReferenciada.Location = New System.Drawing.Point(1, 22)
        Me.pagNFReferenciada.Name = "pagNFReferenciada"
        Me.pagNFReferenciada.Size = New System.Drawing.Size(895, 379)
        Me.pagNFReferenciada.TabStop = True
        Me.pagNFReferenciada.Text = "Modelo 1"
        '
        'btnExcelGridModelo
        '
        Me.btnExcelGridModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridModelo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridModelo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridModelo.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridModelo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridModelo.Location = New System.Drawing.Point(64, 355)
        Me.btnExcelGridModelo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridModelo.Name = "btnExcelGridModelo"
        Me.btnExcelGridModelo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridModelo.TabIndex = 91
        Me.btnExcelGridModelo.TabStop = False
        Me.btnExcelGridModelo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridModelo
        '
        Me.btnAgruparGridModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridModelo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridModelo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridModelo.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridModelo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridModelo.Location = New System.Drawing.Point(37, 355)
        Me.btnAgruparGridModelo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridModelo.Name = "btnAgruparGridModelo"
        Me.btnAgruparGridModelo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridModelo.TabIndex = 90
        Me.btnAgruparGridModelo.TabStop = False
        Me.btnAgruparGridModelo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridModelo
        '
        Me.btnConfigurarGridModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridModelo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridModelo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridModelo.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridModelo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridModelo.Location = New System.Drawing.Point(13, 355)
        Me.btnConfigurarGridModelo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridModelo.Name = "btnConfigurarGridModelo"
        Me.btnConfigurarGridModelo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridModelo.TabIndex = 3
        Me.btnConfigurarGridModelo.TabStop = False
        Me.btnConfigurarGridModelo.UseVisualStyleBackColor = False
        '
        'grdModelo1
        '
        Me.grdModelo1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdModelo1.AlternatingColors = True
        Me.grdModelo1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdModelo1_DesignTimeLayout.LayoutString = resources.GetString("grdModelo1_DesignTimeLayout.LayoutString")
        Me.grdModelo1.DesignTimeLayout = grdModelo1_DesignTimeLayout
        Me.grdModelo1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdModelo1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdModelo1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdModelo1.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdModelo1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdModelo1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdModelo1.GroupByBoxVisible = False
        Me.grdModelo1.Location = New System.Drawing.Point(9, 4)
        Me.grdModelo1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdModelo1.Name = "grdModelo1"
        Me.grdModelo1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdModelo1.RecordNavigator = True
        Me.grdModelo1.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdModelo1.Size = New System.Drawing.Size(879, 368)
        Me.grdModelo1.TabIndex = 42
        Me.grdModelo1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdModelo1.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdModelo1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdModelo1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdModelo1.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoOperacao)
        Me.grpFiltro.Controls.Add(Me.cboTipoOperacao)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 32
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 40
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 38
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 39
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblTipoOperacao
        '
        Me.lblTipoOperacao.AutoSize = True
        Me.lblTipoOperacao.Location = New System.Drawing.Point(234, 17)
        Me.lblTipoOperacao.Name = "lblTipoOperacao"
        Me.lblTipoOperacao.Size = New System.Drawing.Size(96, 14)
        Me.lblTipoOperacao.TabIndex = 36
        Me.lblTipoOperacao.Text = "Tipo de Operação:"
        '
        'cboTipoOperacao
        '
        Me.cboTipoOperacao.AutoSize = False
        Me.cboTipoOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoOperacao.Location = New System.Drawing.Point(237, 34)
        Me.cboTipoOperacao.Name = "cboTipoOperacao"
        Me.cboTipoOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoOperacao.Size = New System.Drawing.Size(222, 20)
        Me.cboTipoOperacao.TabIndex = 37
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(90, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 33
        Me.lblDataEmissaoFiltro.Text = "Data de Emissão:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnEnviarEmail)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnGerarArquivo)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 30
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarEmail.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEnviarEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarEmail.Location = New System.Drawing.Point(536, 17)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(124, 23)
        Me.btnEnviarEmail.TabIndex = 27
        Me.btnEnviarEmail.Text = "Enviar por E-mail"
        Me.btnEnviarEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(796, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(92, 23)
        Me.btnSair.TabIndex = 26
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnGerarArquivo
        '
        Me.btnGerarArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarArquivo.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnGerarArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarArquivo.Location = New System.Drawing.Point(666, 17)
        Me.btnGerarArquivo.Name = "btnGerarArquivo"
        Me.btnGerarArquivo.Size = New System.Drawing.Size(124, 23)
        Me.btnGerarArquivo.TabIndex = 25
        Me.btnGerarArquivo.Text = "Gerar Arquivos"
        Me.btnGerarArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrIntProsoftFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrIntProsoftFinanceiro"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.tabNFe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNFe.ResumeLayout(False)
        Me.pagDadosCapa.ResumeLayout(False)
        CType(Me.grdNotaFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagNFReferenciada.ResumeLayout(False)
        CType(Me.grdModelo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnGerarArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoOperacao As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarEmail As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdNotaFiscal As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents tabNFe As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDadosCapa As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagNFReferenciada As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelGridModelo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridModelo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridModelo As System.Windows.Forms.Button
    Friend WithEvents grdModelo1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button

End Class
