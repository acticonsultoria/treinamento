<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrCadCentroTrabalho
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadCentroTrabalho))
        Dim grdMaquina_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMaquina_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAtivoFiltro = New System.Windows.Forms.Label()
        Me.cboAtivoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGastoFiltro = New System.Windows.Forms.Label()
        Me.cboCentroGastoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCalendarioFiltro = New System.Windows.Forms.Label()
        Me.cboCalendarioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOperacionalFiltro = New System.Windows.Forms.Label()
        Me.cboOperacionalFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.txtCentroTrabalhoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCentroTrabalhoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagMaquina = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridMaquina = New System.Windows.Forms.Button()
        Me.btnAgruparGridMaquina = New System.Windows.Forms.Button()
        Me.grpMaquina = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricaoMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoMaquina = New System.Windows.Forms.Label()
        Me.cboCodigoMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoMaquina = New System.Windows.Forms.Label()
        Me.btnExcluirMaquina = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirMaquina = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarMaquina = New System.Windows.Forms.Button()
        Me.btnConfigurarGridMaquina = New System.Windows.Forms.Button()
        Me.grdMaquina = New Janus.Windows.GridEX.GridEX()
        Me.tabCalendario = New Janus.Windows.UI.Tab.UITabPage()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtHoraDomingo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoraSabado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkSegunda = New Janus.Windows.EditControls.UICheckBox()
        Me.txtHoraSexta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkTerca = New Janus.Windows.EditControls.UICheckBox()
        Me.txtHoraQuinta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkQuarta = New Janus.Windows.EditControls.UICheckBox()
        Me.txtHoraQuarta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkQuinta = New Janus.Windows.EditControls.UICheckBox()
        Me.txtHoraTerca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkSexta = New Janus.Windows.EditControls.UICheckBox()
        Me.txtHoraSegunda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkSabado = New Janus.Windows.EditControls.UICheckBox()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.chkDomingo = New Janus.Windows.EditControls.UICheckBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblMultiploApontamento = New System.Windows.Forms.Label()
        Me.cboMultiploApontamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroTrabalhoAlternativo = New System.Windows.Forms.Label()
        Me.cboCentroTrabalhoAlternativo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOperacional = New System.Windows.Forms.Label()
        Me.lblCalendario = New System.Windows.Forms.Label()
        Me.cboOperacional = New Janus.Windows.EditControls.UIComboBox()
        Me.cboCalendario = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.btnCadastrarCalendario = New System.Windows.Forms.Button()
        Me.lblMultiplaOPApontamento = New System.Windows.Forms.Label()
        Me.cboMultiplaOPApontamento = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagMaquina.SuspendLayout()
        CType(Me.grpMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaquina.SuspendLayout()
        CType(Me.grdMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCalendario.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Centro de Trabalho"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 70
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 69
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
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
        Me.btnConfigurarGrid.TabIndex = 68
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblAtivoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAtivoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCentroGastoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCentroGastoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCalendarioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCalendarioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblOperacionalFiltro)
        Me.grpFiltro.Controls.Add(Me.cboOperacionalFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCentroTrabalhoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCentroTrabalhoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblAtivoFiltro
        '
        Me.lblAtivoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivoFiltro.AutoSize = True
        Me.lblAtivoFiltro.Location = New System.Drawing.Point(600, 57)
        Me.lblAtivoFiltro.Name = "lblAtivoFiltro"
        Me.lblAtivoFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivoFiltro.TabIndex = 18
        Me.lblAtivoFiltro.Text = "Ativo:"
        '
        'cboAtivoFiltro
        '
        Me.cboAtivoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAtivoFiltro.Location = New System.Drawing.Point(603, 74)
        Me.cboAtivoFiltro.Name = "cboAtivoFiltro"
        Me.cboAtivoFiltro.Size = New System.Drawing.Size(156, 20)
        Me.cboAtivoFiltro.TabIndex = 19
        '
        'lblCentroGastoFiltro
        '
        Me.lblCentroGastoFiltro.AutoSize = True
        Me.lblCentroGastoFiltro.Location = New System.Drawing.Point(262, 57)
        Me.lblCentroGastoFiltro.Name = "lblCentroGastoFiltro"
        Me.lblCentroGastoFiltro.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGastoFiltro.TabIndex = 8
        Me.lblCentroGastoFiltro.Text = "Centro de Gasto:"
        '
        'cboCentroGastoFiltro
        '
        Me.cboCentroGastoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroGastoFiltro.Location = New System.Drawing.Point(265, 74)
        Me.cboCentroGastoFiltro.Name = "cboCentroGastoFiltro"
        Me.cboCentroGastoFiltro.Size = New System.Drawing.Size(332, 20)
        Me.cboCentroGastoFiltro.TabIndex = 9
        '
        'lblCalendarioFiltro
        '
        Me.lblCalendarioFiltro.AutoSize = True
        Me.lblCalendarioFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblCalendarioFiltro.Name = "lblCalendarioFiltro"
        Me.lblCalendarioFiltro.Size = New System.Drawing.Size(61, 14)
        Me.lblCalendarioFiltro.TabIndex = 6
        Me.lblCalendarioFiltro.Text = "Calendário:"
        '
        'cboCalendarioFiltro
        '
        Me.cboCalendarioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboCalendarioFiltro.Name = "cboCalendarioFiltro"
        Me.cboCalendarioFiltro.Size = New System.Drawing.Size(250, 20)
        Me.cboCalendarioFiltro.TabIndex = 7
        '
        'lblOperacionalFiltro
        '
        Me.lblOperacionalFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOperacionalFiltro.AutoSize = True
        Me.lblOperacionalFiltro.Location = New System.Drawing.Point(600, 17)
        Me.lblOperacionalFiltro.Name = "lblOperacionalFiltro"
        Me.lblOperacionalFiltro.Size = New System.Drawing.Size(68, 14)
        Me.lblOperacionalFiltro.TabIndex = 4
        Me.lblOperacionalFiltro.Text = "Operacional:"
        '
        'cboOperacionalFiltro
        '
        Me.cboOperacionalFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOperacionalFiltro.Location = New System.Drawing.Point(603, 34)
        Me.cboOperacionalFiltro.Name = "cboOperacionalFiltro"
        Me.cboOperacionalFiltro.Size = New System.Drawing.Size(156, 20)
        Me.cboOperacionalFiltro.TabIndex = 5
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(145, 34)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(452, 20)
        Me.txtDescricaoFiltro.TabIndex = 3
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(142, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 2
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'txtCentroTrabalhoFiltro
        '
        Me.txtCentroTrabalhoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentroTrabalhoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCentroTrabalhoFiltro.MaxLength = 20
        Me.txtCentroTrabalhoFiltro.Name = "txtCentroTrabalhoFiltro"
        Me.txtCentroTrabalhoFiltro.Size = New System.Drawing.Size(130, 20)
        Me.txtCentroTrabalhoFiltro.TabIndex = 1
        '
        'lblCentroTrabalhoFiltro
        '
        Me.lblCentroTrabalhoFiltro.AutoSize = True
        Me.lblCentroTrabalhoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCentroTrabalhoFiltro.Name = "lblCentroTrabalhoFiltro"
        Me.lblCentroTrabalhoFiltro.Size = New System.Drawing.Size(43, 14)
        Me.lblCentroTrabalhoFiltro.TabIndex = 0
        Me.lblCentroTrabalhoFiltro.Text = "Código:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
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
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 1
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(700, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Centro de Trabalho"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 212)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 268)
        Me.tabDados.TabIndex = 2
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagMaquina, Me.tabCalendario})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagMaquina
        '
        Me.pagMaquina.Controls.Add(Me.btnExcelGridMaquina)
        Me.pagMaquina.Controls.Add(Me.btnAgruparGridMaquina)
        Me.pagMaquina.Controls.Add(Me.grpMaquina)
        Me.pagMaquina.Controls.Add(Me.btnConfigurarGridMaquina)
        Me.pagMaquina.Controls.Add(Me.grdMaquina)
        Me.pagMaquina.Key = "pagMaquina"
        Me.pagMaquina.Location = New System.Drawing.Point(1, 22)
        Me.pagMaquina.Name = "pagMaquina"
        Me.pagMaquina.Size = New System.Drawing.Size(895, 245)
        Me.pagMaquina.TabStop = True
        Me.pagMaquina.Text = "Máquina e Equipamento"
        '
        'btnExcelGridMaquina
        '
        Me.btnExcelGridMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridMaquina.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridMaquina.FlatAppearance.BorderSize = 0
        Me.btnExcelGridMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridMaquina.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridMaquina.Location = New System.Drawing.Point(57, 219)
        Me.btnExcelGridMaquina.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridMaquina.Name = "btnExcelGridMaquina"
        Me.btnExcelGridMaquina.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridMaquina.TabIndex = 4
        Me.btnExcelGridMaquina.TabStop = False
        Me.btnExcelGridMaquina.UseVisualStyleBackColor = False
        '
        'btnAgruparGridMaquina
        '
        Me.btnAgruparGridMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridMaquina.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridMaquina.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridMaquina.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridMaquina.Location = New System.Drawing.Point(33, 219)
        Me.btnAgruparGridMaquina.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridMaquina.Name = "btnAgruparGridMaquina"
        Me.btnAgruparGridMaquina.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridMaquina.TabIndex = 3
        Me.btnAgruparGridMaquina.TabStop = False
        Me.btnAgruparGridMaquina.UseVisualStyleBackColor = False
        '
        'grpMaquina
        '
        Me.grpMaquina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMaquina.BackColor = System.Drawing.Color.Transparent
        Me.grpMaquina.Controls.Add(Me.txtDescricaoMaquina)
        Me.grpMaquina.Controls.Add(Me.lblDescricaoMaquina)
        Me.grpMaquina.Controls.Add(Me.cboCodigoMaquina)
        Me.grpMaquina.Controls.Add(Me.lblCodigoMaquina)
        Me.grpMaquina.Controls.Add(Me.btnExcluirMaquina)
        Me.grpMaquina.Controls.Add(Me.btnInserirMaquina)
        Me.grpMaquina.Controls.Add(Me.btnCadastrarMaquina)
        Me.grpMaquina.Location = New System.Drawing.Point(8, 3)
        Me.grpMaquina.Name = "grpMaquina"
        Me.grpMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMaquina.Size = New System.Drawing.Size(879, 64)
        Me.grpMaquina.TabIndex = 0
        Me.grpMaquina.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpMaquina.VisualStyleManager = Me.vsmMain
        '
        'txtDescricaoMaquina
        '
        Me.txtDescricaoMaquina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoMaquina.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoMaquina.Location = New System.Drawing.Point(145, 34)
        Me.txtDescricaoMaquina.MaxLength = 100
        Me.txtDescricaoMaquina.Name = "txtDescricaoMaquina"
        Me.txtDescricaoMaquina.ReadOnly = True
        Me.txtDescricaoMaquina.Size = New System.Drawing.Size(480, 20)
        Me.txtDescricaoMaquina.TabIndex = 4
        Me.txtDescricaoMaquina.TabStop = False
        '
        'lblDescricaoMaquina
        '
        Me.lblDescricaoMaquina.AutoSize = True
        Me.lblDescricaoMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoMaquina.Location = New System.Drawing.Point(142, 17)
        Me.lblDescricaoMaquina.Name = "lblDescricaoMaquina"
        Me.lblDescricaoMaquina.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoMaquina.TabIndex = 3
        Me.lblDescricaoMaquina.Text = "Descrição:"
        '
        'cboCodigoMaquina
        '
        Me.cboCodigoMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoMaquina.Location = New System.Drawing.Point(9, 34)
        Me.cboCodigoMaquina.Name = "cboCodigoMaquina"
        Me.cboCodigoMaquina.Size = New System.Drawing.Size(130, 20)
        Me.cboCodigoMaquina.TabIndex = 2
        '
        'lblCodigoMaquina
        '
        Me.lblCodigoMaquina.AutoSize = True
        Me.lblCodigoMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoMaquina.Location = New System.Drawing.Point(25, 17)
        Me.lblCodigoMaquina.Name = "lblCodigoMaquina"
        Me.lblCodigoMaquina.Size = New System.Drawing.Size(86, 14)
        Me.lblCodigoMaquina.TabIndex = 1
        Me.lblCodigoMaquina.Text = "Código Máquina:"
        '
        'btnExcluirMaquina
        '
        Me.btnExcluirMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirMaquina.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirMaquina.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirMaquina.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirMaquina.Location = New System.Drawing.Point(779, 31)
        Me.btnExcluirMaquina.Name = "btnExcluirMaquina"
        Me.btnExcluirMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirMaquina.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirMaquina.TabIndex = 6
        Me.btnExcluirMaquina.Text = "Excluir"
        Me.btnExcluirMaquina.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirMaquina
        '
        Me.btnInserirMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirMaquina.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirMaquina.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirMaquina.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirMaquina.Location = New System.Drawing.Point(682, 31)
        Me.btnInserirMaquina.Name = "btnInserirMaquina"
        Me.btnInserirMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirMaquina.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirMaquina.TabIndex = 5
        Me.btnInserirMaquina.Text = "Inserir"
        Me.btnInserirMaquina.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarMaquina
        '
        Me.btnCadastrarMaquina.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMaquina.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMaquina.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarMaquina.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMaquina.Name = "btnCadastrarMaquina"
        Me.btnCadastrarMaquina.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMaquina.TabIndex = 0
        Me.btnCadastrarMaquina.TabStop = False
        Me.btnCadastrarMaquina.UseVisualStyleBackColor = True
        '
        'btnConfigurarGridMaquina
        '
        Me.btnConfigurarGridMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridMaquina.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridMaquina.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridMaquina.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridMaquina.Location = New System.Drawing.Point(9, 219)
        Me.btnConfigurarGridMaquina.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridMaquina.Name = "btnConfigurarGridMaquina"
        Me.btnConfigurarGridMaquina.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridMaquina.TabIndex = 2
        Me.btnConfigurarGridMaquina.TabStop = False
        Me.btnConfigurarGridMaquina.UseVisualStyleBackColor = False
        '
        'grdMaquina
        '
        Me.grdMaquina.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMaquina.AlternatingColors = True
        Me.grdMaquina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMaquina.ColumnAutoResize = True
        grdMaquina_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdMaquina_DesignTimeLayout_Reference_0.Instance"), Object)
        grdMaquina_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdMaquina_DesignTimeLayout_Reference_0})
        grdMaquina_DesignTimeLayout.LayoutString = resources.GetString("grdMaquina_DesignTimeLayout.LayoutString")
        Me.grdMaquina.DesignTimeLayout = grdMaquina_DesignTimeLayout
        Me.grdMaquina.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMaquina.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMaquina.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMaquina.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMaquina.FrozenColumns = 3
        Me.grdMaquina.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMaquina.GroupByBoxVisible = False
        Me.grdMaquina.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdMaquina.Location = New System.Drawing.Point(8, 76)
        Me.grdMaquina.Name = "grdMaquina"
        Me.grdMaquina.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMaquina.RecordNavigator = True
        Me.grdMaquina.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMaquina.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMaquina.Size = New System.Drawing.Size(879, 160)
        Me.grdMaquina.TabIndex = 1
        Me.grdMaquina.TabStop = False
        Me.grdMaquina.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMaquina.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMaquina.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMaquina.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMaquina.VisualStyleManager = Me.vsmMain
        '
        'tabCalendario
        '
        Me.tabCalendario.Controls.Add(Me.lblObservacao)
        Me.tabCalendario.Controls.Add(Me.txtHoraDomingo)
        Me.tabCalendario.Controls.Add(Me.Label2)
        Me.tabCalendario.Controls.Add(Me.txtHoraSabado)
        Me.tabCalendario.Controls.Add(Me.chkSegunda)
        Me.tabCalendario.Controls.Add(Me.txtHoraSexta)
        Me.tabCalendario.Controls.Add(Me.chkTerca)
        Me.tabCalendario.Controls.Add(Me.txtHoraQuinta)
        Me.tabCalendario.Controls.Add(Me.chkQuarta)
        Me.tabCalendario.Controls.Add(Me.txtHoraQuarta)
        Me.tabCalendario.Controls.Add(Me.chkQuinta)
        Me.tabCalendario.Controls.Add(Me.txtHoraTerca)
        Me.tabCalendario.Controls.Add(Me.chkSexta)
        Me.tabCalendario.Controls.Add(Me.txtHoraSegunda)
        Me.tabCalendario.Controls.Add(Me.chkSabado)
        Me.tabCalendario.Controls.Add(Me.lblHoras)
        Me.tabCalendario.Controls.Add(Me.chkDomingo)
        Me.tabCalendario.Location = New System.Drawing.Point(1, 24)
        Me.tabCalendario.Name = "tabCalendario"
        Me.tabCalendario.Size = New System.Drawing.Size(895, 241)
        Me.tabCalendario.TabStop = True
        Me.tabCalendario.Text = "Dias de Trabalho"
        '
        'lblObservacao
        '
        Me.lblObservacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblObservacao.ForeColor = System.Drawing.Color.Firebrick
        Me.lblObservacao.Location = New System.Drawing.Point(3, 225)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(842, 14)
        Me.lblObservacao.TabIndex = 12
        Me.lblObservacao.Text = "Obs.: Quando associado alguma Máquina / Equipamento ao Centro de Trabalho, a quan" & _
    "tidade de Horas fica a cargo dos Turnos associados as Máquinas / Equipamentos"
        '
        'txtHoraDomingo
        '
        Me.txtHoraDomingo.Location = New System.Drawing.Point(789, 40)
        Me.txtHoraDomingo.Mask = "00:00:00"
        Me.txtHoraDomingo.Name = "txtHoraDomingo"
        Me.txtHoraDomingo.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraDomingo.TabIndex = 15
        Me.txtHoraDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Moccasin
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dias:"
        '
        'txtHoraSabado
        '
        Me.txtHoraSabado.Location = New System.Drawing.Point(682, 40)
        Me.txtHoraSabado.Mask = "00:00:00"
        Me.txtHoraSabado.Name = "txtHoraSabado"
        Me.txtHoraSabado.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraSabado.TabIndex = 13
        Me.txtHoraSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'chkSegunda
        '
        Me.chkSegunda.Location = New System.Drawing.Point(147, 19)
        Me.chkSegunda.Name = "chkSegunda"
        Me.chkSegunda.Size = New System.Drawing.Size(63, 15)
        Me.chkSegunda.TabIndex = 2
        Me.chkSegunda.Text = "Segunda"
        '
        'txtHoraSexta
        '
        Me.txtHoraSexta.Location = New System.Drawing.Point(575, 40)
        Me.txtHoraSexta.Mask = "00:00:00"
        Me.txtHoraSexta.Name = "txtHoraSexta"
        Me.txtHoraSexta.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraSexta.TabIndex = 11
        Me.txtHoraSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'chkTerca
        '
        Me.chkTerca.Location = New System.Drawing.Point(254, 19)
        Me.chkTerca.Name = "chkTerca"
        Me.chkTerca.Size = New System.Drawing.Size(63, 15)
        Me.chkTerca.TabIndex = 4
        Me.chkTerca.Text = "Terça"
        '
        'txtHoraQuinta
        '
        Me.txtHoraQuinta.Location = New System.Drawing.Point(468, 40)
        Me.txtHoraQuinta.Mask = "00:00:00"
        Me.txtHoraQuinta.Name = "txtHoraQuinta"
        Me.txtHoraQuinta.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraQuinta.TabIndex = 9
        Me.txtHoraQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'chkQuarta
        '
        Me.chkQuarta.Location = New System.Drawing.Point(361, 19)
        Me.chkQuarta.Name = "chkQuarta"
        Me.chkQuarta.Size = New System.Drawing.Size(63, 15)
        Me.chkQuarta.TabIndex = 6
        Me.chkQuarta.Text = "Quarta"
        '
        'txtHoraQuarta
        '
        Me.txtHoraQuarta.Location = New System.Drawing.Point(361, 40)
        Me.txtHoraQuarta.Mask = "00:00:00"
        Me.txtHoraQuarta.Name = "txtHoraQuarta"
        Me.txtHoraQuarta.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraQuarta.TabIndex = 7
        Me.txtHoraQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'chkQuinta
        '
        Me.chkQuinta.Location = New System.Drawing.Point(468, 19)
        Me.chkQuinta.Name = "chkQuinta"
        Me.chkQuinta.Size = New System.Drawing.Size(63, 15)
        Me.chkQuinta.TabIndex = 8
        Me.chkQuinta.Text = "Quinta"
        '
        'txtHoraTerca
        '
        Me.txtHoraTerca.Location = New System.Drawing.Point(254, 40)
        Me.txtHoraTerca.Mask = "00:00:00"
        Me.txtHoraTerca.Name = "txtHoraTerca"
        Me.txtHoraTerca.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraTerca.TabIndex = 5
        Me.txtHoraTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'chkSexta
        '
        Me.chkSexta.Location = New System.Drawing.Point(575, 19)
        Me.chkSexta.Name = "chkSexta"
        Me.chkSexta.Size = New System.Drawing.Size(63, 15)
        Me.chkSexta.TabIndex = 10
        Me.chkSexta.Text = "Sexta"
        '
        'txtHoraSegunda
        '
        Me.txtHoraSegunda.Location = New System.Drawing.Point(147, 40)
        Me.txtHoraSegunda.Mask = "00:00:00"
        Me.txtHoraSegunda.Name = "txtHoraSegunda"
        Me.txtHoraSegunda.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraSegunda.TabIndex = 3
        Me.txtHoraSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'chkSabado
        '
        Me.chkSabado.Location = New System.Drawing.Point(682, 19)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(63, 15)
        Me.chkSabado.TabIndex = 12
        Me.chkSabado.Text = "Sabado"
        '
        'lblHoras
        '
        Me.lblHoras.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoras.Location = New System.Drawing.Point(7, 44)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(105, 14)
        Me.lblHoras.TabIndex = 1
        Me.lblHoras.Text = "Horas:"
        '
        'chkDomingo
        '
        Me.chkDomingo.Location = New System.Drawing.Point(789, 19)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(63, 15)
        Me.chkDomingo.TabIndex = 14
        Me.chkDomingo.Text = "Domingo"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 483)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblMultiplaOPApontamento)
        Me.grpDados.Controls.Add(Me.cboMultiplaOPApontamento)
        Me.grpDados.Controls.Add(Me.lblMultiploApontamento)
        Me.grpDados.Controls.Add(Me.cboMultiploApontamento)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblCentroTrabalhoAlternativo)
        Me.grpDados.Controls.Add(Me.cboCentroTrabalhoAlternativo)
        Me.grpDados.Controls.Add(Me.lblCentroGasto)
        Me.grpDados.Controls.Add(Me.cboCentroGasto)
        Me.grpDados.Controls.Add(Me.lblOperacional)
        Me.grpDados.Controls.Add(Me.lblCalendario)
        Me.grpDados.Controls.Add(Me.cboOperacional)
        Me.grpDados.Controls.Add(Me.cboCalendario)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpDados.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpDados.Controls.Add(Me.btnCadastrarCalendario)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 203)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblMultiploApontamento
        '
        Me.lblMultiploApontamento.AutoSize = True
        Me.lblMultiploApontamento.Location = New System.Drawing.Point(292, 59)
        Me.lblMultiploApontamento.Name = "lblMultiploApontamento"
        Me.lblMultiploApontamento.Size = New System.Drawing.Size(180, 14)
        Me.lblMultiploApontamento.TabIndex = 7
        Me.lblMultiploApontamento.Text = "Multiplo Apontamento na mesma OP:"
        '
        'cboMultiploApontamento
        '
        Me.cboMultiploApontamento.Location = New System.Drawing.Point(295, 76)
        Me.cboMultiploApontamento.Name = "cboMultiploApontamento"
        Me.cboMultiploApontamento.Size = New System.Drawing.Size(200, 20)
        Me.cboMultiploApontamento.TabIndex = 8
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(717, 59)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 11
        Me.lblAtivo.Text = "Ativo:"
        '
        'cboAtivo
        '
        Me.cboAtivo.Location = New System.Drawing.Point(720, 76)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Size = New System.Drawing.Size(168, 20)
        Me.cboAtivo.TabIndex = 12
        '
        'lblCentroTrabalhoAlternativo
        '
        Me.lblCentroTrabalhoAlternativo.AutoSize = True
        Me.lblCentroTrabalhoAlternativo.Location = New System.Drawing.Point(6, 154)
        Me.lblCentroTrabalhoAlternativo.Name = "lblCentroTrabalhoAlternativo"
        Me.lblCentroTrabalhoAlternativo.Size = New System.Drawing.Size(156, 14)
        Me.lblCentroTrabalhoAlternativo.TabIndex = 16
        Me.lblCentroTrabalhoAlternativo.Text = "Centro de Trabalho Alternativo:"
        '
        'cboCentroTrabalhoAlternativo
        '
        Me.cboCentroTrabalhoAlternativo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroTrabalhoAlternativo.Location = New System.Drawing.Point(9, 173)
        Me.cboCentroTrabalhoAlternativo.Name = "cboCentroTrabalhoAlternativo"
        Me.cboCentroTrabalhoAlternativo.Size = New System.Drawing.Size(879, 20)
        Me.cboCentroTrabalhoAlternativo.TabIndex = 17
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(27, 111)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 14
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroGasto.Location = New System.Drawing.Point(11, 128)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Size = New System.Drawing.Size(877, 20)
        Me.cboCentroGasto.TabIndex = 15
        '
        'lblOperacional
        '
        Me.lblOperacional.AutoSize = True
        Me.lblOperacional.Location = New System.Drawing.Point(6, 59)
        Me.lblOperacional.Name = "lblOperacional"
        Me.lblOperacional.Size = New System.Drawing.Size(68, 14)
        Me.lblOperacional.TabIndex = 2
        Me.lblOperacional.Text = "Operacional:"
        '
        'lblCalendario
        '
        Me.lblCalendario.AutoSize = True
        Me.lblCalendario.Location = New System.Drawing.Point(118, 58)
        Me.lblCalendario.Name = "lblCalendario"
        Me.lblCalendario.Size = New System.Drawing.Size(61, 14)
        Me.lblCalendario.TabIndex = 5
        Me.lblCalendario.Text = "Calendário:"
        '
        'cboOperacional
        '
        Me.cboOperacional.Location = New System.Drawing.Point(9, 76)
        Me.cboOperacional.Name = "cboOperacional"
        Me.cboOperacional.Size = New System.Drawing.Size(87, 20)
        Me.cboOperacional.TabIndex = 3
        '
        'cboCalendario
        '
        Me.cboCalendario.Location = New System.Drawing.Point(102, 76)
        Me.cboCalendario.Name = "cboCalendario"
        Me.cboCalendario.Size = New System.Drawing.Size(187, 20)
        Me.cboCalendario.TabIndex = 6
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(879, 20)
        Me.txtDescricao.TabIndex = 1
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 0
        Me.lblDescricao.Text = "Descrição:"
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(871, 108)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 15
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(11, 112)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 13
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnCadastrarCalendario
        '
        Me.btnCadastrarCalendario.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCalendario.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCalendario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCalendario.Location = New System.Drawing.Point(102, 59)
        Me.btnCadastrarCalendario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCalendario.Name = "btnCadastrarCalendario"
        Me.btnCadastrarCalendario.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCalendario.TabIndex = 4
        Me.btnCadastrarCalendario.TabStop = False
        Me.btnCadastrarCalendario.UseVisualStyleBackColor = True
        '
        'lblMultiplaOPApontamento
        '
        Me.lblMultiplaOPApontamento.AutoSize = True
        Me.lblMultiplaOPApontamento.Location = New System.Drawing.Point(498, 59)
        Me.lblMultiplaOPApontamento.Name = "lblMultiplaOPApontamento"
        Me.lblMultiplaOPApontamento.Size = New System.Drawing.Size(190, 14)
        Me.lblMultiplaOPApontamento.TabIndex = 9
        Me.lblMultiplaOPApontamento.Text = "Múltiplas OP's no mesmo apontamento"
        '
        'cboMultiplaOPApontamento
        '
        Me.cboMultiplaOPApontamento.Location = New System.Drawing.Point(501, 76)
        Me.cboMultiplaOPApontamento.Name = "cboMultiplaOPApontamento"
        Me.cboMultiplaOPApontamento.Size = New System.Drawing.Size(213, 20)
        Me.cboMultiplaOPApontamento.TabIndex = 10
        '
        'usrCadCentroTrabalho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadCentroTrabalho"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagMaquina.ResumeLayout(False)
        CType(Me.grpMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaquina.ResumeLayout(False)
        Me.grpMaquina.PerformLayout()
        CType(Me.grdMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCalendario.ResumeLayout(False)
        Me.tabCalendario.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCentroTrabalhoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCentroTrabalhoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCentroGastoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCentroGastoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCalendarioFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCalendarioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOperacionalFiltro As System.Windows.Forms.Label
    Friend WithEvents cboOperacionalFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblHoras As System.Windows.Forms.Label
    Friend WithEvents chkDomingo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSabado As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSexta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkQuinta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkQuarta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkTerca As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSegunda As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCalendario As System.Windows.Forms.Button
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOperacional As System.Windows.Forms.Label
    Friend WithEvents lblCalendario As System.Windows.Forms.Label
    Friend WithEvents cboOperacional As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboCalendario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagMaquina As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelGridMaquina As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridMaquina As System.Windows.Forms.Button
    Friend WithEvents grpMaquina As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricaoMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirMaquina As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDescricaoMaquina As System.Windows.Forms.Label
    Friend WithEvents btnInserirMaquina As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarMaquina As System.Windows.Forms.Button
    Friend WithEvents cboCodigoMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoMaquina As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGridMaquina As System.Windows.Forms.Button
    Friend WithEvents grdMaquina As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtHoraDomingo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSabado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSexta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraQuinta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraQuarta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraTerca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSegunda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents tabCalendario As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblCentroTrabalhoAlternativo As Label
    Friend WithEvents cboCentroTrabalhoAlternativo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAtivo As Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAtivoFiltro As Label
    Friend WithEvents cboAtivoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMultiploApontamento As Label
    Friend WithEvents cboMultiploApontamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMultiplaOPApontamento As System.Windows.Forms.Label
    Friend WithEvents cboMultiplaOPApontamento As Janus.Windows.EditControls.UIComboBox
End Class
