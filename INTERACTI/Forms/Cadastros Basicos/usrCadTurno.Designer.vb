<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadTurno
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
        Dim JanusColorScheme5 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadTurno))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCalendario = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtHoraIntervaloDomingoTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloSabadoTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloSextaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloQuintaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloQuartaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloTercaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloSegundaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblHoraIntervaloTermino = New System.Windows.Forms.Label()
        Me.txtHoraAlmocoDomingoTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoSabadoTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoSextaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoQuintaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoQuartaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoTercaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoSegundaTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblHoraAlmocoTermino = New System.Windows.Forms.Label()
        Me.txtHoraIntervaloDomingoInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloSabadoInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloSextaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloQuintaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloQuartaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloTercaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraIntervaloSegundaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblHoraIntervaloInicio = New System.Windows.Forms.Label()
        Me.txtHoraAdicionaNoturnoTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAdicionaNoturnoInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraSaidaDomingo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraSaidaSabado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraSaidaSexta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraSaidaQuinta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraSaidaQuarta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraSaidaTerca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraSaidaSegunda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraEntradaDomingo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraEntradaSabado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraEntradaSexta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraEntradaQuinta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraEntradaQuarta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraEntradaTerca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraEntradaSegunda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoDomingoInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoSabadoInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoSextaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoQuintaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoQuartaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoTercaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoSegundaInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblHoraAdicionalNoturnoTermino = New System.Windows.Forms.Label()
        Me.lblHoraAdicionalNoturnoInicio = New System.Windows.Forms.Label()
        Me.lblHoraAlmocoInicio = New System.Windows.Forms.Label()
        Me.lblHoraSaida = New System.Windows.Forms.Label()
        Me.lblHoraEntrada = New System.Windows.Forms.Label()
        Me.chkDomingo = New Janus.Windows.EditControls.UICheckBox()
        Me.chkSabado = New Janus.Windows.EditControls.UICheckBox()
        Me.chkSexta = New Janus.Windows.EditControls.UICheckBox()
        Me.chkQuinta = New Janus.Windows.EditControls.UICheckBox()
        Me.chkQuarta = New Janus.Windows.EditControls.UICheckBox()
        Me.chkTerca = New Janus.Windows.EditControls.UICheckBox()
        Me.chkSegunda = New Janus.Windows.EditControls.UICheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblHoraExtraAposPagamento = New System.Windows.Forms.Label()
        Me.lblHoraExtraPagamento = New System.Windows.Forms.Label()
        Me.txtHoraExtraAposDomingoPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboHoraExtraAposDomingoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtHoraExtraAposSabadoPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboHoraExtraAposSabadoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtHoraExtraAposSextaPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboHoraExtraAposSextaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtHoraExtraAposQuintaPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboHoraExtraAposQuintaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtHoraExtraAposQuartaPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboHoraExtraAposQuartaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtHoraExtraAposTercaPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboHoraExtraAposTercaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtHoraExtraAposSegundaPagamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboHoraExtraAposSegundaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboHoraExtraDomingoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboHoraExtraSabadoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboHoraExtraSextaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboHoraExtraQuintaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboHoraExtraQuartaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboHoraExtraTercaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarTipoHoraExtra = New System.Windows.Forms.Button()
        Me.cboHoraExtraSegundaPagamento = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCalendario.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme5.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme5.Name = "Scheme"
        JanusColorScheme5.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme5.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme5.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme5)
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
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Turno"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(33, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 23
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 6
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
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 314)
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
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(666, 20)
        Me.txtDescricaoFiltro.TabIndex = 1
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 0
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
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
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 2
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
        Me.pagDados.Controls.Add(Me.grpCalendario)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Turno"
        '
        'grpCalendario
        '
        Me.grpCalendario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCalendario.BackColor = System.Drawing.Color.Transparent
        Me.grpCalendario.Controls.Add(Me.btnCadastrarTipoHoraExtra)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraSegundaPagamento)
        Me.grpCalendario.Controls.Add(Me.lblHoraExtraAposPagamento)
        Me.grpCalendario.Controls.Add(Me.lblHoraExtraPagamento)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraAposDomingoPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraAposDomingoPagamento)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraAposSabadoPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraAposSabadoPagamento)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraAposSextaPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraAposSextaPagamento)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraAposQuintaPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraAposQuintaPagamento)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraAposQuartaPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraAposQuartaPagamento)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraAposTercaPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraAposTercaPagamento)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraAposSegundaPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraAposSegundaPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraDomingoPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraSabadoPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraSextaPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraQuintaPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraQuartaPagamento)
        Me.grpCalendario.Controls.Add(Me.cboHoraExtraTercaPagamento)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloDomingoTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloSabadoTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloSextaTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloQuintaTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloQuartaTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloTercaTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloSegundaTermino)
        Me.grpCalendario.Controls.Add(Me.lblHoraIntervaloTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoDomingoTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoSabadoTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoSextaTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoQuintaTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoQuartaTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoTercaTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoSegundaTermino)
        Me.grpCalendario.Controls.Add(Me.lblHoraAlmocoTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloDomingoInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloSabadoInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloSextaInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloQuintaInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloQuartaInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloTercaInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraIntervaloSegundaInicio)
        Me.grpCalendario.Controls.Add(Me.lblHoraIntervaloInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionaNoturnoTermino)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionaNoturnoInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaDomingo)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaSabado)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaSexta)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaQuinta)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaQuarta)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaSegunda)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaDomingo)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaSabado)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaSexta)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaQuinta)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaQuarta)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaSegunda)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoDomingoInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoSabadoInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoSextaInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoQuintaInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoQuartaInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoTercaInicio)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoSegundaInicio)
        Me.grpCalendario.Controls.Add(Me.lblHoraAdicionalNoturnoTermino)
        Me.grpCalendario.Controls.Add(Me.lblHoraAdicionalNoturnoInicio)
        Me.grpCalendario.Controls.Add(Me.lblHoraAlmocoInicio)
        Me.grpCalendario.Controls.Add(Me.lblHoraSaida)
        Me.grpCalendario.Controls.Add(Me.lblHoraEntrada)
        Me.grpCalendario.Controls.Add(Me.chkDomingo)
        Me.grpCalendario.Controls.Add(Me.chkSabado)
        Me.grpCalendario.Controls.Add(Me.chkSexta)
        Me.grpCalendario.Controls.Add(Me.chkQuinta)
        Me.grpCalendario.Controls.Add(Me.chkQuarta)
        Me.grpCalendario.Controls.Add(Me.chkTerca)
        Me.grpCalendario.Controls.Add(Me.chkSegunda)
        Me.grpCalendario.Controls.Add(Me.Label2)
        Me.grpCalendario.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCalendario.Location = New System.Drawing.Point(8, 70)
        Me.grpCalendario.Name = "grpCalendario"
        Me.grpCalendario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCalendario.Size = New System.Drawing.Size(897, 317)
        Me.grpCalendario.TabIndex = 1
        Me.grpCalendario.Text = "Dias de Trabalho"
        Me.grpCalendario.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpCalendario.VisualStyleManager = Me.vsmMain
        '
        'txtHoraIntervaloDomingoTermino
        '
        Me.txtHoraIntervaloDomingoTermino.Location = New System.Drawing.Point(825, 171)
        Me.txtHoraIntervaloDomingoTermino.Mask = "00:00:00"
        Me.txtHoraIntervaloDomingoTermino.Name = "txtHoraIntervaloDomingoTermino"
        Me.txtHoraIntervaloDomingoTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloDomingoTermino.TabIndex = 59
        Me.txtHoraIntervaloDomingoTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloSabadoTermino
        '
        Me.txtHoraIntervaloSabadoTermino.Location = New System.Drawing.Point(754, 171)
        Me.txtHoraIntervaloSabadoTermino.Mask = "00:00:00"
        Me.txtHoraIntervaloSabadoTermino.Name = "txtHoraIntervaloSabadoTermino"
        Me.txtHoraIntervaloSabadoTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloSabadoTermino.TabIndex = 58
        Me.txtHoraIntervaloSabadoTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloSextaTermino
        '
        Me.txtHoraIntervaloSextaTermino.Location = New System.Drawing.Point(683, 171)
        Me.txtHoraIntervaloSextaTermino.Mask = "00:00:00"
        Me.txtHoraIntervaloSextaTermino.Name = "txtHoraIntervaloSextaTermino"
        Me.txtHoraIntervaloSextaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloSextaTermino.TabIndex = 57
        Me.txtHoraIntervaloSextaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloQuintaTermino
        '
        Me.txtHoraIntervaloQuintaTermino.Location = New System.Drawing.Point(612, 171)
        Me.txtHoraIntervaloQuintaTermino.Mask = "00:00:00"
        Me.txtHoraIntervaloQuintaTermino.Name = "txtHoraIntervaloQuintaTermino"
        Me.txtHoraIntervaloQuintaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloQuintaTermino.TabIndex = 56
        Me.txtHoraIntervaloQuintaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloQuartaTermino
        '
        Me.txtHoraIntervaloQuartaTermino.Location = New System.Drawing.Point(541, 171)
        Me.txtHoraIntervaloQuartaTermino.Mask = "00:00:00"
        Me.txtHoraIntervaloQuartaTermino.Name = "txtHoraIntervaloQuartaTermino"
        Me.txtHoraIntervaloQuartaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloQuartaTermino.TabIndex = 55
        Me.txtHoraIntervaloQuartaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloTercaTermino
        '
        Me.txtHoraIntervaloTercaTermino.Location = New System.Drawing.Point(470, 171)
        Me.txtHoraIntervaloTercaTermino.Mask = "00:00:00"
        Me.txtHoraIntervaloTercaTermino.Name = "txtHoraIntervaloTercaTermino"
        Me.txtHoraIntervaloTercaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloTercaTermino.TabIndex = 54
        Me.txtHoraIntervaloTercaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloSegundaTermino
        '
        Me.txtHoraIntervaloSegundaTermino.Location = New System.Drawing.Point(398, 171)
        Me.txtHoraIntervaloSegundaTermino.Mask = "00:00:00"
        Me.txtHoraIntervaloSegundaTermino.Name = "txtHoraIntervaloSegundaTermino"
        Me.txtHoraIntervaloSegundaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloSegundaTermino.TabIndex = 53
        Me.txtHoraIntervaloSegundaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblHoraIntervaloTermino
        '
        Me.lblHoraIntervaloTermino.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraIntervaloTermino.Location = New System.Drawing.Point(7, 175)
        Me.lblHoraIntervaloTermino.Name = "lblHoraIntervaloTermino"
        Me.lblHoraIntervaloTermino.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraIntervaloTermino.TabIndex = 52
        Me.lblHoraIntervaloTermino.Text = "Hora Intervalo (Término):"
        '
        'txtHoraAlmocoDomingoTermino
        '
        Me.txtHoraAlmocoDomingoTermino.Location = New System.Drawing.Point(825, 119)
        Me.txtHoraAlmocoDomingoTermino.Mask = "00:00:00"
        Me.txtHoraAlmocoDomingoTermino.Name = "txtHoraAlmocoDomingoTermino"
        Me.txtHoraAlmocoDomingoTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoDomingoTermino.TabIndex = 51
        Me.txtHoraAlmocoDomingoTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoSabadoTermino
        '
        Me.txtHoraAlmocoSabadoTermino.Location = New System.Drawing.Point(754, 119)
        Me.txtHoraAlmocoSabadoTermino.Mask = "00:00:00"
        Me.txtHoraAlmocoSabadoTermino.Name = "txtHoraAlmocoSabadoTermino"
        Me.txtHoraAlmocoSabadoTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoSabadoTermino.TabIndex = 50
        Me.txtHoraAlmocoSabadoTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoSextaTermino
        '
        Me.txtHoraAlmocoSextaTermino.Location = New System.Drawing.Point(683, 119)
        Me.txtHoraAlmocoSextaTermino.Mask = "00:00:00"
        Me.txtHoraAlmocoSextaTermino.Name = "txtHoraAlmocoSextaTermino"
        Me.txtHoraAlmocoSextaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoSextaTermino.TabIndex = 49
        Me.txtHoraAlmocoSextaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoQuintaTermino
        '
        Me.txtHoraAlmocoQuintaTermino.Location = New System.Drawing.Point(612, 119)
        Me.txtHoraAlmocoQuintaTermino.Mask = "00:00:00"
        Me.txtHoraAlmocoQuintaTermino.Name = "txtHoraAlmocoQuintaTermino"
        Me.txtHoraAlmocoQuintaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoQuintaTermino.TabIndex = 48
        Me.txtHoraAlmocoQuintaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoQuartaTermino
        '
        Me.txtHoraAlmocoQuartaTermino.Location = New System.Drawing.Point(541, 119)
        Me.txtHoraAlmocoQuartaTermino.Mask = "00:00:00"
        Me.txtHoraAlmocoQuartaTermino.Name = "txtHoraAlmocoQuartaTermino"
        Me.txtHoraAlmocoQuartaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoQuartaTermino.TabIndex = 47
        Me.txtHoraAlmocoQuartaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoTercaTermino
        '
        Me.txtHoraAlmocoTercaTermino.Location = New System.Drawing.Point(470, 119)
        Me.txtHoraAlmocoTercaTermino.Mask = "00:00:00"
        Me.txtHoraAlmocoTercaTermino.Name = "txtHoraAlmocoTercaTermino"
        Me.txtHoraAlmocoTercaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoTercaTermino.TabIndex = 46
        Me.txtHoraAlmocoTercaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoSegundaTermino
        '
        Me.txtHoraAlmocoSegundaTermino.Location = New System.Drawing.Point(398, 119)
        Me.txtHoraAlmocoSegundaTermino.Mask = "00:00:00"
        Me.txtHoraAlmocoSegundaTermino.Name = "txtHoraAlmocoSegundaTermino"
        Me.txtHoraAlmocoSegundaTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoSegundaTermino.TabIndex = 45
        Me.txtHoraAlmocoSegundaTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblHoraAlmocoTermino
        '
        Me.lblHoraAlmocoTermino.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraAlmocoTermino.Location = New System.Drawing.Point(7, 123)
        Me.lblHoraAlmocoTermino.Name = "lblHoraAlmocoTermino"
        Me.lblHoraAlmocoTermino.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraAlmocoTermino.TabIndex = 44
        Me.lblHoraAlmocoTermino.Text = "Hora Refeição (Término):"
        '
        'txtHoraIntervaloDomingoInicio
        '
        Me.txtHoraIntervaloDomingoInicio.Location = New System.Drawing.Point(825, 145)
        Me.txtHoraIntervaloDomingoInicio.Mask = "00:00:00"
        Me.txtHoraIntervaloDomingoInicio.Name = "txtHoraIntervaloDomingoInicio"
        Me.txtHoraIntervaloDomingoInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloDomingoInicio.TabIndex = 43
        Me.txtHoraIntervaloDomingoInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloSabadoInicio
        '
        Me.txtHoraIntervaloSabadoInicio.Location = New System.Drawing.Point(754, 145)
        Me.txtHoraIntervaloSabadoInicio.Mask = "00:00:00"
        Me.txtHoraIntervaloSabadoInicio.Name = "txtHoraIntervaloSabadoInicio"
        Me.txtHoraIntervaloSabadoInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloSabadoInicio.TabIndex = 42
        Me.txtHoraIntervaloSabadoInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloSextaInicio
        '
        Me.txtHoraIntervaloSextaInicio.Location = New System.Drawing.Point(683, 145)
        Me.txtHoraIntervaloSextaInicio.Mask = "00:00:00"
        Me.txtHoraIntervaloSextaInicio.Name = "txtHoraIntervaloSextaInicio"
        Me.txtHoraIntervaloSextaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloSextaInicio.TabIndex = 41
        Me.txtHoraIntervaloSextaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloQuintaInicio
        '
        Me.txtHoraIntervaloQuintaInicio.Location = New System.Drawing.Point(612, 145)
        Me.txtHoraIntervaloQuintaInicio.Mask = "00:00:00"
        Me.txtHoraIntervaloQuintaInicio.Name = "txtHoraIntervaloQuintaInicio"
        Me.txtHoraIntervaloQuintaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloQuintaInicio.TabIndex = 40
        Me.txtHoraIntervaloQuintaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloQuartaInicio
        '
        Me.txtHoraIntervaloQuartaInicio.Location = New System.Drawing.Point(541, 145)
        Me.txtHoraIntervaloQuartaInicio.Mask = "00:00:00"
        Me.txtHoraIntervaloQuartaInicio.Name = "txtHoraIntervaloQuartaInicio"
        Me.txtHoraIntervaloQuartaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloQuartaInicio.TabIndex = 39
        Me.txtHoraIntervaloQuartaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloTercaInicio
        '
        Me.txtHoraIntervaloTercaInicio.Location = New System.Drawing.Point(470, 145)
        Me.txtHoraIntervaloTercaInicio.Mask = "00:00:00"
        Me.txtHoraIntervaloTercaInicio.Name = "txtHoraIntervaloTercaInicio"
        Me.txtHoraIntervaloTercaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloTercaInicio.TabIndex = 38
        Me.txtHoraIntervaloTercaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraIntervaloSegundaInicio
        '
        Me.txtHoraIntervaloSegundaInicio.Location = New System.Drawing.Point(398, 145)
        Me.txtHoraIntervaloSegundaInicio.Mask = "00:00:00"
        Me.txtHoraIntervaloSegundaInicio.Name = "txtHoraIntervaloSegundaInicio"
        Me.txtHoraIntervaloSegundaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraIntervaloSegundaInicio.TabIndex = 37
        Me.txtHoraIntervaloSegundaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblHoraIntervaloInicio
        '
        Me.lblHoraIntervaloInicio.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraIntervaloInicio.Location = New System.Drawing.Point(6, 149)
        Me.lblHoraIntervaloInicio.Name = "lblHoraIntervaloInicio"
        Me.lblHoraIntervaloInicio.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraIntervaloInicio.TabIndex = 36
        Me.lblHoraIntervaloInicio.Text = "Hora Intervalo (Início):"
        '
        'txtHoraAdicionaNoturnoTermino
        '
        Me.txtHoraAdicionaNoturnoTermino.Location = New System.Drawing.Point(398, 276)
        Me.txtHoraAdicionaNoturnoTermino.Mask = "00:00:00"
        Me.txtHoraAdicionaNoturnoTermino.Name = "txtHoraAdicionaNoturnoTermino"
        Me.txtHoraAdicionaNoturnoTermino.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAdicionaNoturnoTermino.TabIndex = 35
        Me.txtHoraAdicionaNoturnoTermino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAdicionaNoturnoInicio
        '
        Me.txtHoraAdicionaNoturnoInicio.Location = New System.Drawing.Point(398, 250)
        Me.txtHoraAdicionaNoturnoInicio.Mask = "00:00:00"
        Me.txtHoraAdicionaNoturnoInicio.Name = "txtHoraAdicionaNoturnoInicio"
        Me.txtHoraAdicionaNoturnoInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAdicionaNoturnoInicio.TabIndex = 33
        Me.txtHoraAdicionaNoturnoInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraSaidaDomingo
        '
        Me.txtHoraSaidaDomingo.Location = New System.Drawing.Point(825, 67)
        Me.txtHoraSaidaDomingo.Mask = "00:00:00"
        Me.txtHoraSaidaDomingo.Name = "txtHoraSaidaDomingo"
        Me.txtHoraSaidaDomingo.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraSaidaDomingo.TabIndex = 23
        Me.txtHoraSaidaDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraSaidaSabado
        '
        Me.txtHoraSaidaSabado.Location = New System.Drawing.Point(754, 67)
        Me.txtHoraSaidaSabado.Mask = "00:00:00"
        Me.txtHoraSaidaSabado.Name = "txtHoraSaidaSabado"
        Me.txtHoraSaidaSabado.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraSaidaSabado.TabIndex = 22
        Me.txtHoraSaidaSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraSaidaSexta
        '
        Me.txtHoraSaidaSexta.Location = New System.Drawing.Point(683, 67)
        Me.txtHoraSaidaSexta.Mask = "00:00:00"
        Me.txtHoraSaidaSexta.Name = "txtHoraSaidaSexta"
        Me.txtHoraSaidaSexta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraSaidaSexta.TabIndex = 21
        Me.txtHoraSaidaSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraSaidaQuinta
        '
        Me.txtHoraSaidaQuinta.Location = New System.Drawing.Point(612, 67)
        Me.txtHoraSaidaQuinta.Mask = "00:00:00"
        Me.txtHoraSaidaQuinta.Name = "txtHoraSaidaQuinta"
        Me.txtHoraSaidaQuinta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraSaidaQuinta.TabIndex = 20
        Me.txtHoraSaidaQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraSaidaQuarta
        '
        Me.txtHoraSaidaQuarta.Location = New System.Drawing.Point(541, 67)
        Me.txtHoraSaidaQuarta.Mask = "00:00:00"
        Me.txtHoraSaidaQuarta.Name = "txtHoraSaidaQuarta"
        Me.txtHoraSaidaQuarta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraSaidaQuarta.TabIndex = 19
        Me.txtHoraSaidaQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraSaidaTerca
        '
        Me.txtHoraSaidaTerca.Location = New System.Drawing.Point(470, 67)
        Me.txtHoraSaidaTerca.Mask = "00:00:00"
        Me.txtHoraSaidaTerca.Name = "txtHoraSaidaTerca"
        Me.txtHoraSaidaTerca.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraSaidaTerca.TabIndex = 18
        Me.txtHoraSaidaTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraSaidaSegunda
        '
        Me.txtHoraSaidaSegunda.Location = New System.Drawing.Point(398, 67)
        Me.txtHoraSaidaSegunda.Mask = "00:00:00"
        Me.txtHoraSaidaSegunda.Name = "txtHoraSaidaSegunda"
        Me.txtHoraSaidaSegunda.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraSaidaSegunda.TabIndex = 17
        Me.txtHoraSaidaSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraEntradaDomingo
        '
        Me.txtHoraEntradaDomingo.Location = New System.Drawing.Point(825, 41)
        Me.txtHoraEntradaDomingo.Mask = "00:00:00"
        Me.txtHoraEntradaDomingo.Name = "txtHoraEntradaDomingo"
        Me.txtHoraEntradaDomingo.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraEntradaDomingo.TabIndex = 15
        Me.txtHoraEntradaDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraEntradaSabado
        '
        Me.txtHoraEntradaSabado.Location = New System.Drawing.Point(754, 41)
        Me.txtHoraEntradaSabado.Mask = "00:00:00"
        Me.txtHoraEntradaSabado.Name = "txtHoraEntradaSabado"
        Me.txtHoraEntradaSabado.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraEntradaSabado.TabIndex = 14
        Me.txtHoraEntradaSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraEntradaSexta
        '
        Me.txtHoraEntradaSexta.Location = New System.Drawing.Point(683, 41)
        Me.txtHoraEntradaSexta.Mask = "00:00:00"
        Me.txtHoraEntradaSexta.Name = "txtHoraEntradaSexta"
        Me.txtHoraEntradaSexta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraEntradaSexta.TabIndex = 13
        Me.txtHoraEntradaSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraEntradaQuinta
        '
        Me.txtHoraEntradaQuinta.Location = New System.Drawing.Point(612, 41)
        Me.txtHoraEntradaQuinta.Mask = "00:00:00"
        Me.txtHoraEntradaQuinta.Name = "txtHoraEntradaQuinta"
        Me.txtHoraEntradaQuinta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraEntradaQuinta.TabIndex = 12
        Me.txtHoraEntradaQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraEntradaQuarta
        '
        Me.txtHoraEntradaQuarta.Location = New System.Drawing.Point(541, 41)
        Me.txtHoraEntradaQuarta.Mask = "00:00:00"
        Me.txtHoraEntradaQuarta.Name = "txtHoraEntradaQuarta"
        Me.txtHoraEntradaQuarta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraEntradaQuarta.TabIndex = 11
        Me.txtHoraEntradaQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraEntradaTerca
        '
        Me.txtHoraEntradaTerca.Location = New System.Drawing.Point(470, 41)
        Me.txtHoraEntradaTerca.Mask = "00:00:00"
        Me.txtHoraEntradaTerca.Name = "txtHoraEntradaTerca"
        Me.txtHoraEntradaTerca.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraEntradaTerca.TabIndex = 10
        Me.txtHoraEntradaTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraEntradaSegunda
        '
        Me.txtHoraEntradaSegunda.Location = New System.Drawing.Point(398, 41)
        Me.txtHoraEntradaSegunda.Mask = "00:00:00"
        Me.txtHoraEntradaSegunda.Name = "txtHoraEntradaSegunda"
        Me.txtHoraEntradaSegunda.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraEntradaSegunda.TabIndex = 9
        Me.txtHoraEntradaSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoDomingoInicio
        '
        Me.txtHoraAlmocoDomingoInicio.Location = New System.Drawing.Point(825, 93)
        Me.txtHoraAlmocoDomingoInicio.Mask = "00:00:00"
        Me.txtHoraAlmocoDomingoInicio.Name = "txtHoraAlmocoDomingoInicio"
        Me.txtHoraAlmocoDomingoInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoDomingoInicio.TabIndex = 31
        Me.txtHoraAlmocoDomingoInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoSabadoInicio
        '
        Me.txtHoraAlmocoSabadoInicio.Location = New System.Drawing.Point(754, 93)
        Me.txtHoraAlmocoSabadoInicio.Mask = "00:00:00"
        Me.txtHoraAlmocoSabadoInicio.Name = "txtHoraAlmocoSabadoInicio"
        Me.txtHoraAlmocoSabadoInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoSabadoInicio.TabIndex = 30
        Me.txtHoraAlmocoSabadoInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoSextaInicio
        '
        Me.txtHoraAlmocoSextaInicio.Location = New System.Drawing.Point(683, 93)
        Me.txtHoraAlmocoSextaInicio.Mask = "00:00:00"
        Me.txtHoraAlmocoSextaInicio.Name = "txtHoraAlmocoSextaInicio"
        Me.txtHoraAlmocoSextaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoSextaInicio.TabIndex = 29
        Me.txtHoraAlmocoSextaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoQuintaInicio
        '
        Me.txtHoraAlmocoQuintaInicio.Location = New System.Drawing.Point(612, 93)
        Me.txtHoraAlmocoQuintaInicio.Mask = "00:00:00"
        Me.txtHoraAlmocoQuintaInicio.Name = "txtHoraAlmocoQuintaInicio"
        Me.txtHoraAlmocoQuintaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoQuintaInicio.TabIndex = 28
        Me.txtHoraAlmocoQuintaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoQuartaInicio
        '
        Me.txtHoraAlmocoQuartaInicio.Location = New System.Drawing.Point(541, 93)
        Me.txtHoraAlmocoQuartaInicio.Mask = "00:00:00"
        Me.txtHoraAlmocoQuartaInicio.Name = "txtHoraAlmocoQuartaInicio"
        Me.txtHoraAlmocoQuartaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoQuartaInicio.TabIndex = 27
        Me.txtHoraAlmocoQuartaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoTercaInicio
        '
        Me.txtHoraAlmocoTercaInicio.Location = New System.Drawing.Point(470, 93)
        Me.txtHoraAlmocoTercaInicio.Mask = "00:00:00"
        Me.txtHoraAlmocoTercaInicio.Name = "txtHoraAlmocoTercaInicio"
        Me.txtHoraAlmocoTercaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoTercaInicio.TabIndex = 26
        Me.txtHoraAlmocoTercaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoSegundaInicio
        '
        Me.txtHoraAlmocoSegundaInicio.Location = New System.Drawing.Point(398, 93)
        Me.txtHoraAlmocoSegundaInicio.Mask = "00:00:00"
        Me.txtHoraAlmocoSegundaInicio.Name = "txtHoraAlmocoSegundaInicio"
        Me.txtHoraAlmocoSegundaInicio.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoSegundaInicio.TabIndex = 25
        Me.txtHoraAlmocoSegundaInicio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblHoraAdicionalNoturnoTermino
        '
        Me.lblHoraAdicionalNoturnoTermino.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraAdicionalNoturnoTermino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHoraAdicionalNoturnoTermino.Location = New System.Drawing.Point(7, 280)
        Me.lblHoraAdicionalNoturnoTermino.Name = "lblHoraAdicionalNoturnoTermino"
        Me.lblHoraAdicionalNoturnoTermino.Size = New System.Drawing.Size(366, 16)
        Me.lblHoraAdicionalNoturnoTermino.TabIndex = 34
        Me.lblHoraAdicionalNoturnoTermino.Text = "Adicional Noturno (Término):"
        '
        'lblHoraAdicionalNoturnoInicio
        '
        Me.lblHoraAdicionalNoturnoInicio.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraAdicionalNoturnoInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHoraAdicionalNoturnoInicio.Location = New System.Drawing.Point(6, 254)
        Me.lblHoraAdicionalNoturnoInicio.Name = "lblHoraAdicionalNoturnoInicio"
        Me.lblHoraAdicionalNoturnoInicio.Size = New System.Drawing.Size(366, 16)
        Me.lblHoraAdicionalNoturnoInicio.TabIndex = 32
        Me.lblHoraAdicionalNoturnoInicio.Text = "Adicional Noturno (Início):"
        '
        'lblHoraAlmocoInicio
        '
        Me.lblHoraAlmocoInicio.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraAlmocoInicio.Location = New System.Drawing.Point(6, 97)
        Me.lblHoraAlmocoInicio.Name = "lblHoraAlmocoInicio"
        Me.lblHoraAlmocoInicio.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraAlmocoInicio.TabIndex = 24
        Me.lblHoraAlmocoInicio.Text = "Hora Refeição (Início):"
        '
        'lblHoraSaida
        '
        Me.lblHoraSaida.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraSaida.Location = New System.Drawing.Point(6, 71)
        Me.lblHoraSaida.Name = "lblHoraSaida"
        Me.lblHoraSaida.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraSaida.TabIndex = 16
        Me.lblHoraSaida.Text = "Hora Saída:"
        '
        'lblHoraEntrada
        '
        Me.lblHoraEntrada.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraEntrada.Location = New System.Drawing.Point(6, 45)
        Me.lblHoraEntrada.Name = "lblHoraEntrada"
        Me.lblHoraEntrada.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraEntrada.TabIndex = 8
        Me.lblHoraEntrada.Text = "Hora Entrada:"
        '
        'chkDomingo
        '
        Me.chkDomingo.Location = New System.Drawing.Point(825, 20)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(63, 15)
        Me.chkDomingo.TabIndex = 7
        Me.chkDomingo.Text = "Domingo"
        '
        'chkSabado
        '
        Me.chkSabado.Location = New System.Drawing.Point(754, 20)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(63, 15)
        Me.chkSabado.TabIndex = 6
        Me.chkSabado.Text = "Sabado"
        '
        'chkSexta
        '
        Me.chkSexta.Location = New System.Drawing.Point(683, 20)
        Me.chkSexta.Name = "chkSexta"
        Me.chkSexta.Size = New System.Drawing.Size(63, 15)
        Me.chkSexta.TabIndex = 5
        Me.chkSexta.Text = "Sexta"
        '
        'chkQuinta
        '
        Me.chkQuinta.Location = New System.Drawing.Point(612, 20)
        Me.chkQuinta.Name = "chkQuinta"
        Me.chkQuinta.Size = New System.Drawing.Size(63, 15)
        Me.chkQuinta.TabIndex = 4
        Me.chkQuinta.Text = "Quinta"
        '
        'chkQuarta
        '
        Me.chkQuarta.Location = New System.Drawing.Point(541, 20)
        Me.chkQuarta.Name = "chkQuarta"
        Me.chkQuarta.Size = New System.Drawing.Size(63, 15)
        Me.chkQuarta.TabIndex = 3
        Me.chkQuarta.Text = "Quarta"
        '
        'chkTerca
        '
        Me.chkTerca.Location = New System.Drawing.Point(470, 20)
        Me.chkTerca.Name = "chkTerca"
        Me.chkTerca.Size = New System.Drawing.Size(63, 15)
        Me.chkTerca.TabIndex = 2
        Me.chkTerca.Text = "Terça"
        '
        'chkSegunda
        '
        Me.chkSegunda.Location = New System.Drawing.Point(398, 20)
        Me.chkSegunda.Name = "chkSegunda"
        Me.chkSegunda.Size = New System.Drawing.Size(63, 15)
        Me.chkSegunda.TabIndex = 1
        Me.chkSegunda.Text = "Segunda"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Moccasin
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dias:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 2
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
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(666, 20)
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
        'lblHoraExtraAposPagamento
        '
        Me.lblHoraExtraAposPagamento.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraExtraAposPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHoraExtraAposPagamento.Location = New System.Drawing.Point(7, 225)
        Me.lblHoraExtraAposPagamento.Name = "lblHoraExtraAposPagamento"
        Me.lblHoraExtraAposPagamento.Size = New System.Drawing.Size(366, 16)
        Me.lblHoraExtraAposPagamento.TabIndex = 61
        Me.lblHoraExtraAposPagamento.Text = "Hora Extra - Após:"
        '
        'lblHoraExtraPagamento
        '
        Me.lblHoraExtraPagamento.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraExtraPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHoraExtraPagamento.Location = New System.Drawing.Point(7, 199)
        Me.lblHoraExtraPagamento.Name = "lblHoraExtraPagamento"
        Me.lblHoraExtraPagamento.Size = New System.Drawing.Size(366, 16)
        Me.lblHoraExtraPagamento.TabIndex = 60
        Me.lblHoraExtraPagamento.Text = "Hora Extra:"
        '
        'txtHoraExtraAposDomingoPagamento
        '
        Me.txtHoraExtraAposDomingoPagamento.DecimalDigits = 0
        Me.txtHoraExtraAposDomingoPagamento.Location = New System.Drawing.Point(825, 222)
        Me.txtHoraExtraAposDomingoPagamento.Name = "txtHoraExtraAposDomingoPagamento"
        Me.txtHoraExtraAposDomingoPagamento.Size = New System.Drawing.Size(23, 20)
        Me.txtHoraExtraAposDomingoPagamento.TabIndex = 80
        Me.txtHoraExtraAposDomingoPagamento.Text = "0"
        Me.txtHoraExtraAposDomingoPagamento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraExtraAposDomingoPagamento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboHoraExtraAposDomingoPagamento
        '
        Me.cboHoraExtraAposDomingoPagamento.AutoSize = False
        Me.cboHoraExtraAposDomingoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraAposDomingoPagamento.Location = New System.Drawing.Point(845, 222)
        Me.cboHoraExtraAposDomingoPagamento.Name = "cboHoraExtraAposDomingoPagamento"
        Me.cboHoraExtraAposDomingoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraAposDomingoPagamento.Size = New System.Drawing.Size(43, 20)
        Me.cboHoraExtraAposDomingoPagamento.TabIndex = 81
        '
        'txtHoraExtraAposSabadoPagamento
        '
        Me.txtHoraExtraAposSabadoPagamento.DecimalDigits = 0
        Me.txtHoraExtraAposSabadoPagamento.Location = New System.Drawing.Point(754, 221)
        Me.txtHoraExtraAposSabadoPagamento.Name = "txtHoraExtraAposSabadoPagamento"
        Me.txtHoraExtraAposSabadoPagamento.Size = New System.Drawing.Size(23, 20)
        Me.txtHoraExtraAposSabadoPagamento.TabIndex = 78
        Me.txtHoraExtraAposSabadoPagamento.Text = "0"
        Me.txtHoraExtraAposSabadoPagamento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraExtraAposSabadoPagamento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboHoraExtraAposSabadoPagamento
        '
        Me.cboHoraExtraAposSabadoPagamento.AutoSize = False
        Me.cboHoraExtraAposSabadoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraAposSabadoPagamento.Location = New System.Drawing.Point(774, 221)
        Me.cboHoraExtraAposSabadoPagamento.Name = "cboHoraExtraAposSabadoPagamento"
        Me.cboHoraExtraAposSabadoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraAposSabadoPagamento.Size = New System.Drawing.Size(43, 20)
        Me.cboHoraExtraAposSabadoPagamento.TabIndex = 79
        '
        'txtHoraExtraAposSextaPagamento
        '
        Me.txtHoraExtraAposSextaPagamento.DecimalDigits = 0
        Me.txtHoraExtraAposSextaPagamento.Location = New System.Drawing.Point(683, 222)
        Me.txtHoraExtraAposSextaPagamento.Name = "txtHoraExtraAposSextaPagamento"
        Me.txtHoraExtraAposSextaPagamento.Size = New System.Drawing.Size(23, 20)
        Me.txtHoraExtraAposSextaPagamento.TabIndex = 76
        Me.txtHoraExtraAposSextaPagamento.Text = "0"
        Me.txtHoraExtraAposSextaPagamento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraExtraAposSextaPagamento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboHoraExtraAposSextaPagamento
        '
        Me.cboHoraExtraAposSextaPagamento.AutoSize = False
        Me.cboHoraExtraAposSextaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraAposSextaPagamento.Location = New System.Drawing.Point(703, 222)
        Me.cboHoraExtraAposSextaPagamento.Name = "cboHoraExtraAposSextaPagamento"
        Me.cboHoraExtraAposSextaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraAposSextaPagamento.Size = New System.Drawing.Size(43, 20)
        Me.cboHoraExtraAposSextaPagamento.TabIndex = 77
        '
        'txtHoraExtraAposQuintaPagamento
        '
        Me.txtHoraExtraAposQuintaPagamento.DecimalDigits = 0
        Me.txtHoraExtraAposQuintaPagamento.Location = New System.Drawing.Point(612, 223)
        Me.txtHoraExtraAposQuintaPagamento.Name = "txtHoraExtraAposQuintaPagamento"
        Me.txtHoraExtraAposQuintaPagamento.Size = New System.Drawing.Size(23, 20)
        Me.txtHoraExtraAposQuintaPagamento.TabIndex = 74
        Me.txtHoraExtraAposQuintaPagamento.Text = "0"
        Me.txtHoraExtraAposQuintaPagamento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraExtraAposQuintaPagamento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboHoraExtraAposQuintaPagamento
        '
        Me.cboHoraExtraAposQuintaPagamento.AutoSize = False
        Me.cboHoraExtraAposQuintaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraAposQuintaPagamento.Location = New System.Drawing.Point(632, 223)
        Me.cboHoraExtraAposQuintaPagamento.Name = "cboHoraExtraAposQuintaPagamento"
        Me.cboHoraExtraAposQuintaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraAposQuintaPagamento.Size = New System.Drawing.Size(43, 20)
        Me.cboHoraExtraAposQuintaPagamento.TabIndex = 75
        '
        'txtHoraExtraAposQuartaPagamento
        '
        Me.txtHoraExtraAposQuartaPagamento.DecimalDigits = 0
        Me.txtHoraExtraAposQuartaPagamento.Location = New System.Drawing.Point(541, 223)
        Me.txtHoraExtraAposQuartaPagamento.Name = "txtHoraExtraAposQuartaPagamento"
        Me.txtHoraExtraAposQuartaPagamento.Size = New System.Drawing.Size(23, 20)
        Me.txtHoraExtraAposQuartaPagamento.TabIndex = 72
        Me.txtHoraExtraAposQuartaPagamento.Text = "0"
        Me.txtHoraExtraAposQuartaPagamento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraExtraAposQuartaPagamento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboHoraExtraAposQuartaPagamento
        '
        Me.cboHoraExtraAposQuartaPagamento.AutoSize = False
        Me.cboHoraExtraAposQuartaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraAposQuartaPagamento.Location = New System.Drawing.Point(561, 223)
        Me.cboHoraExtraAposQuartaPagamento.Name = "cboHoraExtraAposQuartaPagamento"
        Me.cboHoraExtraAposQuartaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraAposQuartaPagamento.Size = New System.Drawing.Size(43, 20)
        Me.cboHoraExtraAposQuartaPagamento.TabIndex = 73
        '
        'txtHoraExtraAposTercaPagamento
        '
        Me.txtHoraExtraAposTercaPagamento.DecimalDigits = 0
        Me.txtHoraExtraAposTercaPagamento.Location = New System.Drawing.Point(470, 224)
        Me.txtHoraExtraAposTercaPagamento.Name = "txtHoraExtraAposTercaPagamento"
        Me.txtHoraExtraAposTercaPagamento.Size = New System.Drawing.Size(23, 20)
        Me.txtHoraExtraAposTercaPagamento.TabIndex = 70
        Me.txtHoraExtraAposTercaPagamento.Text = "0"
        Me.txtHoraExtraAposTercaPagamento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraExtraAposTercaPagamento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboHoraExtraAposTercaPagamento
        '
        Me.cboHoraExtraAposTercaPagamento.AutoSize = False
        Me.cboHoraExtraAposTercaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraAposTercaPagamento.Location = New System.Drawing.Point(490, 224)
        Me.cboHoraExtraAposTercaPagamento.Name = "cboHoraExtraAposTercaPagamento"
        Me.cboHoraExtraAposTercaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraAposTercaPagamento.Size = New System.Drawing.Size(43, 20)
        Me.cboHoraExtraAposTercaPagamento.TabIndex = 71
        '
        'txtHoraExtraAposSegundaPagamento
        '
        Me.txtHoraExtraAposSegundaPagamento.DecimalDigits = 0
        Me.txtHoraExtraAposSegundaPagamento.Location = New System.Drawing.Point(398, 224)
        Me.txtHoraExtraAposSegundaPagamento.Name = "txtHoraExtraAposSegundaPagamento"
        Me.txtHoraExtraAposSegundaPagamento.Size = New System.Drawing.Size(23, 20)
        Me.txtHoraExtraAposSegundaPagamento.TabIndex = 68
        Me.txtHoraExtraAposSegundaPagamento.Text = "0"
        Me.txtHoraExtraAposSegundaPagamento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraExtraAposSegundaPagamento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboHoraExtraAposSegundaPagamento
        '
        Me.cboHoraExtraAposSegundaPagamento.AutoSize = False
        Me.cboHoraExtraAposSegundaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraAposSegundaPagamento.Location = New System.Drawing.Point(418, 224)
        Me.cboHoraExtraAposSegundaPagamento.Name = "cboHoraExtraAposSegundaPagamento"
        Me.cboHoraExtraAposSegundaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraAposSegundaPagamento.Size = New System.Drawing.Size(43, 20)
        Me.cboHoraExtraAposSegundaPagamento.TabIndex = 69
        '
        'cboHoraExtraDomingoPagamento
        '
        Me.cboHoraExtraDomingoPagamento.AutoSize = False
        Me.cboHoraExtraDomingoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraDomingoPagamento.Location = New System.Drawing.Point(825, 197)
        Me.cboHoraExtraDomingoPagamento.Name = "cboHoraExtraDomingoPagamento"
        Me.cboHoraExtraDomingoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraDomingoPagamento.Size = New System.Drawing.Size(63, 20)
        Me.cboHoraExtraDomingoPagamento.TabIndex = 67
        '
        'cboHoraExtraSabadoPagamento
        '
        Me.cboHoraExtraSabadoPagamento.AutoSize = False
        Me.cboHoraExtraSabadoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraSabadoPagamento.Location = New System.Drawing.Point(754, 197)
        Me.cboHoraExtraSabadoPagamento.Name = "cboHoraExtraSabadoPagamento"
        Me.cboHoraExtraSabadoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraSabadoPagamento.Size = New System.Drawing.Size(63, 20)
        Me.cboHoraExtraSabadoPagamento.TabIndex = 66
        '
        'cboHoraExtraSextaPagamento
        '
        Me.cboHoraExtraSextaPagamento.AutoSize = False
        Me.cboHoraExtraSextaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraSextaPagamento.Location = New System.Drawing.Point(683, 197)
        Me.cboHoraExtraSextaPagamento.Name = "cboHoraExtraSextaPagamento"
        Me.cboHoraExtraSextaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraSextaPagamento.Size = New System.Drawing.Size(63, 20)
        Me.cboHoraExtraSextaPagamento.TabIndex = 65
        '
        'cboHoraExtraQuintaPagamento
        '
        Me.cboHoraExtraQuintaPagamento.AutoSize = False
        Me.cboHoraExtraQuintaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraQuintaPagamento.Location = New System.Drawing.Point(612, 197)
        Me.cboHoraExtraQuintaPagamento.Name = "cboHoraExtraQuintaPagamento"
        Me.cboHoraExtraQuintaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraQuintaPagamento.Size = New System.Drawing.Size(63, 20)
        Me.cboHoraExtraQuintaPagamento.TabIndex = 64
        '
        'cboHoraExtraQuartaPagamento
        '
        Me.cboHoraExtraQuartaPagamento.AutoSize = False
        Me.cboHoraExtraQuartaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraQuartaPagamento.Location = New System.Drawing.Point(541, 197)
        Me.cboHoraExtraQuartaPagamento.Name = "cboHoraExtraQuartaPagamento"
        Me.cboHoraExtraQuartaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraQuartaPagamento.Size = New System.Drawing.Size(63, 20)
        Me.cboHoraExtraQuartaPagamento.TabIndex = 63
        '
        'cboHoraExtraTercaPagamento
        '
        Me.cboHoraExtraTercaPagamento.AutoSize = False
        Me.cboHoraExtraTercaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraTercaPagamento.Location = New System.Drawing.Point(470, 197)
        Me.cboHoraExtraTercaPagamento.Name = "cboHoraExtraTercaPagamento"
        Me.cboHoraExtraTercaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraTercaPagamento.Size = New System.Drawing.Size(63, 20)
        Me.cboHoraExtraTercaPagamento.TabIndex = 62
        '
        'btnCadastrarTipoHoraExtra
        '
        Me.btnCadastrarTipoHoraExtra.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoHoraExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoHoraExtra.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarTipoHoraExtra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoHoraExtra.Location = New System.Drawing.Point(382, 200)
        Me.btnCadastrarTipoHoraExtra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoHoraExtra.Name = "btnCadastrarTipoHoraExtra"
        Me.btnCadastrarTipoHoraExtra.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoHoraExtra.TabIndex = 82
        Me.btnCadastrarTipoHoraExtra.TabStop = False
        Me.btnCadastrarTipoHoraExtra.UseVisualStyleBackColor = True
        '
        'cboHoraExtraSegundaPagamento
        '
        Me.cboHoraExtraSegundaPagamento.AutoSize = False
        Me.cboHoraExtraSegundaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboHoraExtraSegundaPagamento.Location = New System.Drawing.Point(398, 197)
        Me.cboHoraExtraSegundaPagamento.Name = "cboHoraExtraSegundaPagamento"
        Me.cboHoraExtraSegundaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboHoraExtraSegundaPagamento.Size = New System.Drawing.Size(63, 20)
        Me.cboHoraExtraSegundaPagamento.TabIndex = 83
        '
        'usrCadTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadTurno"
        Me.Size = New System.Drawing.Size(915, 476)
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
        CType(Me.grpCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCalendario.ResumeLayout(False)
        Me.grpCalendario.PerformLayout()
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
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpCalendario As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblHoraAdicionalNoturnoTermino As System.Windows.Forms.Label
    Friend WithEvents lblHoraAdicionalNoturnoInicio As System.Windows.Forms.Label
    Friend WithEvents lblHoraAlmocoInicio As System.Windows.Forms.Label
    Friend WithEvents lblHoraSaida As System.Windows.Forms.Label
    Friend WithEvents lblHoraEntrada As System.Windows.Forms.Label
    Friend WithEvents chkDomingo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSabado As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSexta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkQuinta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkQuarta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkTerca As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSegunda As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents txtHoraAlmocoDomingoInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoSabadoInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoSextaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoQuintaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoQuartaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoTercaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoSegundaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAdicionaNoturnoTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAdicionaNoturnoInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSaidaDomingo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSaidaSabado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSaidaSexta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSaidaQuinta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSaidaQuarta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSaidaTerca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraSaidaSegunda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraEntradaDomingo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraEntradaSabado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraEntradaSexta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraEntradaQuinta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraEntradaQuarta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraEntradaTerca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraEntradaSegunda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloDomingoInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloSabadoInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloSextaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloQuintaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloQuartaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloTercaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloSegundaInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblHoraIntervaloInicio As Label
    Friend WithEvents txtHoraAlmocoDomingoTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoSabadoTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoSextaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoQuintaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoQuartaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoTercaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoSegundaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblHoraAlmocoTermino As Label
    Friend WithEvents txtHoraIntervaloDomingoTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloSabadoTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloSextaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloQuintaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloQuartaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloTercaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraIntervaloSegundaTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblHoraIntervaloTermino As Label
    Friend WithEvents lblHoraExtraAposPagamento As Label
    Friend WithEvents lblHoraExtraPagamento As Label
    Friend WithEvents txtHoraExtraAposDomingoPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboHoraExtraAposDomingoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtHoraExtraAposSabadoPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboHoraExtraAposSabadoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtHoraExtraAposSextaPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboHoraExtraAposSextaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtHoraExtraAposQuintaPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboHoraExtraAposQuintaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtHoraExtraAposQuartaPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboHoraExtraAposQuartaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtHoraExtraAposTercaPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboHoraExtraAposTercaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtHoraExtraAposSegundaPagamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboHoraExtraAposSegundaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboHoraExtraDomingoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboHoraExtraSabadoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboHoraExtraSextaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboHoraExtraQuintaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboHoraExtraQuartaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboHoraExtraTercaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarTipoHoraExtra As Button
    Friend WithEvents cboHoraExtraSegundaPagamento As Janus.Windows.EditControls.UIComboBox
End Class
