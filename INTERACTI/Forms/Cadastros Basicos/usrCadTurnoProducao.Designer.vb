<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadTurnoProducao
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadTurnoProducao))
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
        Me.lblHoraAdicionalNoturnoTermino = New System.Windows.Forms.Label()
        Me.lblHoraAdicionalNoturnoInicio = New System.Windows.Forms.Label()
        Me.txtMinutoAdicionalNoturnoTerminoDomingo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoTerminoDomingo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoTerminoSabado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoTerminoSabado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoTerminoSexta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoTerminoSexta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoTerminoQuinta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoTerminoQuinta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoTerminoQuarta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoTerminoQuarta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoTerminoTerca = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoTerminoTerca = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoTerminoSegunda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoTerminoSegunda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoInicioDomingo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoInicioDomingo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoInicioSabado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoInicioSabado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoInicioSexta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoInicioSexta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoInicioQuinta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoInicioQuinta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoInicioQuarta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoInicioQuarta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoInicioTerca = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoInicioTerca = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoAdicionalNoturnoInicioSegunda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraAdicionalNoturnoInicioSegunda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoSaidaDomingo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraSaidaDomingo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoSaidaSabado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraSaidaSabado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoSaidaSexta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraSaidaSexta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoSaidaQuinta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraSaidaQuinta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoSaidaQuarta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraSaidaQuarta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoSaidaTerca = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraSaidaTerca = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoSaidaSegunda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraSaidaSegunda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoEntradaDomingo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraEntradaDomingo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoEntradaSabado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraEntradaSabado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoEntradaSexta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraEntradaSexta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoEntradaQuinta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraEntradaQuinta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoEntradaQuarta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraEntradaQuarta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoEntradaTerca = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtHoraEntradaTerca = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMinutoEntradaSegunda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblHoraAlmoco = New System.Windows.Forms.Label()
        Me.lblHoraSaida = New System.Windows.Forms.Label()
        Me.lblHoraEntrada = New System.Windows.Forms.Label()
        Me.chkDomingo = New Janus.Windows.EditControls.UICheckBox()
        Me.chkSabado = New Janus.Windows.EditControls.UICheckBox()
        Me.chkSexta = New Janus.Windows.EditControls.UICheckBox()
        Me.chkQuinta = New Janus.Windows.EditControls.UICheckBox()
        Me.chkQuarta = New Janus.Windows.EditControls.UICheckBox()
        Me.chkTerca = New Janus.Windows.EditControls.UICheckBox()
        Me.txtHoraEntradaSegunda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.chkSegunda = New Janus.Windows.EditControls.UICheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblHoraExtraPreTurno = New System.Windows.Forms.Label()
        Me.lblHoraExtraPosTurno = New System.Windows.Forms.Label()
        Me.txtHoraAlmocoSegunda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoTerca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoQuarta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoQuinta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoSexta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoSabado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraAlmocoDomingo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPreTurnoDomingo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPreTurnoSabado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPreTurnoSexta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPreTurnoQuinta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPreTurnoQuarta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPreTurnoTerca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPreTurnoSegunda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPosTurnoDomingo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPosTurnoSabado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPosTurnoSexta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPosTurnoQuinta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPosTurnoQuarta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPosTurnoTerca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraExtraPosTurnoSegunda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
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
        Me.pagLista.Text = "Turno de Produção"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
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
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
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
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(685, 20)
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
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
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
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
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
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
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
        Me.pagDados.Text = "Turno de Produção"
        '
        'grpCalendario
        '
        Me.grpCalendario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCalendario.BackColor = System.Drawing.Color.Transparent
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPosTurnoDomingo)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPosTurnoSabado)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPosTurnoSexta)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPosTurnoQuinta)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPosTurnoQuarta)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPosTurnoTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPosTurnoSegunda)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPreTurnoDomingo)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPreTurnoSabado)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPreTurnoSexta)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPreTurnoQuinta)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPreTurnoQuarta)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPreTurnoTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraExtraPreTurnoSegunda)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoDomingo)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoSabado)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoSexta)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoQuinta)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoQuarta)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraAlmocoSegunda)
        Me.grpCalendario.Controls.Add(Me.lblHoraExtraPosTurno)
        Me.grpCalendario.Controls.Add(Me.lblHoraExtraPreTurno)
        Me.grpCalendario.Controls.Add(Me.lblHoraAdicionalNoturnoTermino)
        Me.grpCalendario.Controls.Add(Me.lblHoraAdicionalNoturnoInicio)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoTerminoDomingo)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoTerminoDomingo)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoTerminoSabado)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoTerminoSabado)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoTerminoSexta)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoTerminoSexta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoTerminoQuinta)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoTerminoQuinta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoTerminoQuarta)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoTerminoQuarta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoTerminoTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoTerminoTerca)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoTerminoSegunda)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoTerminoSegunda)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoInicioDomingo)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoInicioDomingo)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoInicioSabado)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoInicioSabado)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoInicioSexta)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoInicioSexta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoInicioQuinta)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoInicioQuinta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoInicioQuarta)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoInicioQuarta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoInicioTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoInicioTerca)
        Me.grpCalendario.Controls.Add(Me.txtMinutoAdicionalNoturnoInicioSegunda)
        Me.grpCalendario.Controls.Add(Me.txtHoraAdicionalNoturnoInicioSegunda)
        Me.grpCalendario.Controls.Add(Me.txtMinutoSaidaDomingo)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaDomingo)
        Me.grpCalendario.Controls.Add(Me.txtMinutoSaidaSabado)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaSabado)
        Me.grpCalendario.Controls.Add(Me.txtMinutoSaidaSexta)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaSexta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoSaidaQuinta)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaQuinta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoSaidaQuarta)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaQuarta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoSaidaTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaTerca)
        Me.grpCalendario.Controls.Add(Me.txtMinutoSaidaSegunda)
        Me.grpCalendario.Controls.Add(Me.txtHoraSaidaSegunda)
        Me.grpCalendario.Controls.Add(Me.txtMinutoEntradaDomingo)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaDomingo)
        Me.grpCalendario.Controls.Add(Me.txtMinutoEntradaSabado)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaSabado)
        Me.grpCalendario.Controls.Add(Me.txtMinutoEntradaSexta)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaSexta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoEntradaQuinta)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaQuinta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoEntradaQuarta)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaQuarta)
        Me.grpCalendario.Controls.Add(Me.txtMinutoEntradaTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaTerca)
        Me.grpCalendario.Controls.Add(Me.txtMinutoEntradaSegunda)
        Me.grpCalendario.Controls.Add(Me.lblHoraAlmoco)
        Me.grpCalendario.Controls.Add(Me.lblHoraSaida)
        Me.grpCalendario.Controls.Add(Me.lblHoraEntrada)
        Me.grpCalendario.Controls.Add(Me.chkDomingo)
        Me.grpCalendario.Controls.Add(Me.chkSabado)
        Me.grpCalendario.Controls.Add(Me.chkSexta)
        Me.grpCalendario.Controls.Add(Me.chkQuinta)
        Me.grpCalendario.Controls.Add(Me.chkQuarta)
        Me.grpCalendario.Controls.Add(Me.chkTerca)
        Me.grpCalendario.Controls.Add(Me.txtHoraEntradaSegunda)
        Me.grpCalendario.Controls.Add(Me.chkSegunda)
        Me.grpCalendario.Controls.Add(Me.Label2)
        Me.grpCalendario.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCalendario.Location = New System.Drawing.Point(8, 70)
        Me.grpCalendario.Name = "grpCalendario"
        Me.grpCalendario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCalendario.Size = New System.Drawing.Size(897, 227)
        Me.grpCalendario.TabIndex = 1
        Me.grpCalendario.Text = "Dias de Trabalho"
        Me.grpCalendario.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpCalendario.VisualStyleManager = Me.vsmMain
        '
        'lblHoraAdicionalNoturnoTermino
        '
        Me.lblHoraAdicionalNoturnoTermino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraAdicionalNoturnoTermino.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraAdicionalNoturnoTermino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHoraAdicionalNoturnoTermino.Location = New System.Drawing.Point(6, 147)
        Me.lblHoraAdicionalNoturnoTermino.Name = "lblHoraAdicionalNoturnoTermino"
        Me.lblHoraAdicionalNoturnoTermino.Size = New System.Drawing.Size(366, 16)
        Me.lblHoraAdicionalNoturnoTermino.TabIndex = 61
        Me.lblHoraAdicionalNoturnoTermino.Text = "Ad. Not. (Término):"
        '
        'lblHoraAdicionalNoturnoInicio
        '
        Me.lblHoraAdicionalNoturnoInicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraAdicionalNoturnoInicio.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraAdicionalNoturnoInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHoraAdicionalNoturnoInicio.Location = New System.Drawing.Point(6, 121)
        Me.lblHoraAdicionalNoturnoInicio.Name = "lblHoraAdicionalNoturnoInicio"
        Me.lblHoraAdicionalNoturnoInicio.Size = New System.Drawing.Size(366, 16)
        Me.lblHoraAdicionalNoturnoInicio.TabIndex = 46
        Me.lblHoraAdicionalNoturnoInicio.Text = "Ad. Not. (Início):"
        '
        'txtMinutoAdicionalNoturnoTerminoDomingo
        '
        Me.txtMinutoAdicionalNoturnoTerminoDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoTerminoDomingo.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoTerminoDomingo.Location = New System.Drawing.Point(858, 145)
        Me.txtMinutoAdicionalNoturnoTerminoDomingo.Name = "txtMinutoAdicionalNoturnoTerminoDomingo"
        Me.txtMinutoAdicionalNoturnoTerminoDomingo.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoTerminoDomingo.TabIndex = 75
        Me.txtMinutoAdicionalNoturnoTerminoDomingo.Text = "0"
        Me.txtMinutoAdicionalNoturnoTerminoDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoTerminoDomingo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoTerminoDomingo
        '
        Me.txtHoraAdicionalNoturnoTerminoDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoTerminoDomingo.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoTerminoDomingo.Location = New System.Drawing.Point(825, 145)
        Me.txtHoraAdicionalNoturnoTerminoDomingo.Name = "txtHoraAdicionalNoturnoTerminoDomingo"
        Me.txtHoraAdicionalNoturnoTerminoDomingo.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoTerminoDomingo.TabIndex = 74
        Me.txtHoraAdicionalNoturnoTerminoDomingo.Text = "0"
        Me.txtHoraAdicionalNoturnoTerminoDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoTerminoDomingo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoTerminoSabado
        '
        Me.txtMinutoAdicionalNoturnoTerminoSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoTerminoSabado.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoTerminoSabado.Location = New System.Drawing.Point(787, 145)
        Me.txtMinutoAdicionalNoturnoTerminoSabado.Name = "txtMinutoAdicionalNoturnoTerminoSabado"
        Me.txtMinutoAdicionalNoturnoTerminoSabado.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoTerminoSabado.TabIndex = 73
        Me.txtMinutoAdicionalNoturnoTerminoSabado.Text = "0"
        Me.txtMinutoAdicionalNoturnoTerminoSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoTerminoSabado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoTerminoSabado
        '
        Me.txtHoraAdicionalNoturnoTerminoSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoTerminoSabado.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoTerminoSabado.Location = New System.Drawing.Point(754, 145)
        Me.txtHoraAdicionalNoturnoTerminoSabado.Name = "txtHoraAdicionalNoturnoTerminoSabado"
        Me.txtHoraAdicionalNoturnoTerminoSabado.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoTerminoSabado.TabIndex = 72
        Me.txtHoraAdicionalNoturnoTerminoSabado.Text = "0"
        Me.txtHoraAdicionalNoturnoTerminoSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoTerminoSabado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoTerminoSexta
        '
        Me.txtMinutoAdicionalNoturnoTerminoSexta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoTerminoSexta.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoTerminoSexta.Location = New System.Drawing.Point(716, 145)
        Me.txtMinutoAdicionalNoturnoTerminoSexta.Name = "txtMinutoAdicionalNoturnoTerminoSexta"
        Me.txtMinutoAdicionalNoturnoTerminoSexta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoTerminoSexta.TabIndex = 71
        Me.txtMinutoAdicionalNoturnoTerminoSexta.Text = "0"
        Me.txtMinutoAdicionalNoturnoTerminoSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoTerminoSexta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoTerminoSexta
        '
        Me.txtHoraAdicionalNoturnoTerminoSexta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoTerminoSexta.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoTerminoSexta.Location = New System.Drawing.Point(683, 145)
        Me.txtHoraAdicionalNoturnoTerminoSexta.Name = "txtHoraAdicionalNoturnoTerminoSexta"
        Me.txtHoraAdicionalNoturnoTerminoSexta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoTerminoSexta.TabIndex = 70
        Me.txtHoraAdicionalNoturnoTerminoSexta.Text = "0"
        Me.txtHoraAdicionalNoturnoTerminoSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoTerminoSexta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoTerminoQuinta
        '
        Me.txtMinutoAdicionalNoturnoTerminoQuinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoTerminoQuinta.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoTerminoQuinta.Location = New System.Drawing.Point(645, 145)
        Me.txtMinutoAdicionalNoturnoTerminoQuinta.Name = "txtMinutoAdicionalNoturnoTerminoQuinta"
        Me.txtMinutoAdicionalNoturnoTerminoQuinta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoTerminoQuinta.TabIndex = 69
        Me.txtMinutoAdicionalNoturnoTerminoQuinta.Text = "0"
        Me.txtMinutoAdicionalNoturnoTerminoQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoTerminoQuinta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoTerminoQuinta
        '
        Me.txtHoraAdicionalNoturnoTerminoQuinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoTerminoQuinta.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoTerminoQuinta.Location = New System.Drawing.Point(612, 145)
        Me.txtHoraAdicionalNoturnoTerminoQuinta.Name = "txtHoraAdicionalNoturnoTerminoQuinta"
        Me.txtHoraAdicionalNoturnoTerminoQuinta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoTerminoQuinta.TabIndex = 68
        Me.txtHoraAdicionalNoturnoTerminoQuinta.Text = "0"
        Me.txtHoraAdicionalNoturnoTerminoQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoTerminoQuinta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoTerminoQuarta
        '
        Me.txtMinutoAdicionalNoturnoTerminoQuarta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoTerminoQuarta.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoTerminoQuarta.Location = New System.Drawing.Point(574, 145)
        Me.txtMinutoAdicionalNoturnoTerminoQuarta.Name = "txtMinutoAdicionalNoturnoTerminoQuarta"
        Me.txtMinutoAdicionalNoturnoTerminoQuarta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoTerminoQuarta.TabIndex = 67
        Me.txtMinutoAdicionalNoturnoTerminoQuarta.Text = "0"
        Me.txtMinutoAdicionalNoturnoTerminoQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoTerminoQuarta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoTerminoQuarta
        '
        Me.txtHoraAdicionalNoturnoTerminoQuarta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoTerminoQuarta.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoTerminoQuarta.Location = New System.Drawing.Point(541, 145)
        Me.txtHoraAdicionalNoturnoTerminoQuarta.Name = "txtHoraAdicionalNoturnoTerminoQuarta"
        Me.txtHoraAdicionalNoturnoTerminoQuarta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoTerminoQuarta.TabIndex = 66
        Me.txtHoraAdicionalNoturnoTerminoQuarta.Text = "0"
        Me.txtHoraAdicionalNoturnoTerminoQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoTerminoQuarta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoTerminoTerca
        '
        Me.txtMinutoAdicionalNoturnoTerminoTerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoTerminoTerca.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoTerminoTerca.Location = New System.Drawing.Point(503, 145)
        Me.txtMinutoAdicionalNoturnoTerminoTerca.Name = "txtMinutoAdicionalNoturnoTerminoTerca"
        Me.txtMinutoAdicionalNoturnoTerminoTerca.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoTerminoTerca.TabIndex = 65
        Me.txtMinutoAdicionalNoturnoTerminoTerca.Text = "0"
        Me.txtMinutoAdicionalNoturnoTerminoTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoTerminoTerca.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoTerminoTerca
        '
        Me.txtHoraAdicionalNoturnoTerminoTerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoTerminoTerca.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoTerminoTerca.Location = New System.Drawing.Point(470, 145)
        Me.txtHoraAdicionalNoturnoTerminoTerca.Name = "txtHoraAdicionalNoturnoTerminoTerca"
        Me.txtHoraAdicionalNoturnoTerminoTerca.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoTerminoTerca.TabIndex = 64
        Me.txtHoraAdicionalNoturnoTerminoTerca.Text = "0"
        Me.txtHoraAdicionalNoturnoTerminoTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoTerminoTerca.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoTerminoSegunda
        '
        Me.txtMinutoAdicionalNoturnoTerminoSegunda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoTerminoSegunda.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoTerminoSegunda.Location = New System.Drawing.Point(431, 145)
        Me.txtMinutoAdicionalNoturnoTerminoSegunda.Name = "txtMinutoAdicionalNoturnoTerminoSegunda"
        Me.txtMinutoAdicionalNoturnoTerminoSegunda.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoTerminoSegunda.TabIndex = 63
        Me.txtMinutoAdicionalNoturnoTerminoSegunda.Text = "0"
        Me.txtMinutoAdicionalNoturnoTerminoSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoTerminoSegunda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoTerminoSegunda
        '
        Me.txtHoraAdicionalNoturnoTerminoSegunda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoTerminoSegunda.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoTerminoSegunda.Location = New System.Drawing.Point(398, 145)
        Me.txtHoraAdicionalNoturnoTerminoSegunda.Name = "txtHoraAdicionalNoturnoTerminoSegunda"
        Me.txtHoraAdicionalNoturnoTerminoSegunda.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoTerminoSegunda.TabIndex = 62
        Me.txtHoraAdicionalNoturnoTerminoSegunda.Text = "0"
        Me.txtHoraAdicionalNoturnoTerminoSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoTerminoSegunda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoInicioDomingo
        '
        Me.txtMinutoAdicionalNoturnoInicioDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoInicioDomingo.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoInicioDomingo.Location = New System.Drawing.Point(858, 119)
        Me.txtMinutoAdicionalNoturnoInicioDomingo.Name = "txtMinutoAdicionalNoturnoInicioDomingo"
        Me.txtMinutoAdicionalNoturnoInicioDomingo.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoInicioDomingo.TabIndex = 60
        Me.txtMinutoAdicionalNoturnoInicioDomingo.Text = "0"
        Me.txtMinutoAdicionalNoturnoInicioDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoInicioDomingo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoInicioDomingo
        '
        Me.txtHoraAdicionalNoturnoInicioDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoInicioDomingo.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoInicioDomingo.Location = New System.Drawing.Point(825, 119)
        Me.txtHoraAdicionalNoturnoInicioDomingo.Name = "txtHoraAdicionalNoturnoInicioDomingo"
        Me.txtHoraAdicionalNoturnoInicioDomingo.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoInicioDomingo.TabIndex = 59
        Me.txtHoraAdicionalNoturnoInicioDomingo.Text = "0"
        Me.txtHoraAdicionalNoturnoInicioDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoInicioDomingo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoInicioSabado
        '
        Me.txtMinutoAdicionalNoturnoInicioSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoInicioSabado.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoInicioSabado.Location = New System.Drawing.Point(787, 119)
        Me.txtMinutoAdicionalNoturnoInicioSabado.Name = "txtMinutoAdicionalNoturnoInicioSabado"
        Me.txtMinutoAdicionalNoturnoInicioSabado.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoInicioSabado.TabIndex = 58
        Me.txtMinutoAdicionalNoturnoInicioSabado.Text = "0"
        Me.txtMinutoAdicionalNoturnoInicioSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoInicioSabado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoInicioSabado
        '
        Me.txtHoraAdicionalNoturnoInicioSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoInicioSabado.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoInicioSabado.Location = New System.Drawing.Point(754, 119)
        Me.txtHoraAdicionalNoturnoInicioSabado.Name = "txtHoraAdicionalNoturnoInicioSabado"
        Me.txtHoraAdicionalNoturnoInicioSabado.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoInicioSabado.TabIndex = 57
        Me.txtHoraAdicionalNoturnoInicioSabado.Text = "0"
        Me.txtHoraAdicionalNoturnoInicioSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoInicioSabado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoInicioSexta
        '
        Me.txtMinutoAdicionalNoturnoInicioSexta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoInicioSexta.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoInicioSexta.Location = New System.Drawing.Point(716, 119)
        Me.txtMinutoAdicionalNoturnoInicioSexta.Name = "txtMinutoAdicionalNoturnoInicioSexta"
        Me.txtMinutoAdicionalNoturnoInicioSexta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoInicioSexta.TabIndex = 56
        Me.txtMinutoAdicionalNoturnoInicioSexta.Text = "0"
        Me.txtMinutoAdicionalNoturnoInicioSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoInicioSexta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoInicioSexta
        '
        Me.txtHoraAdicionalNoturnoInicioSexta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoInicioSexta.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoInicioSexta.Location = New System.Drawing.Point(683, 119)
        Me.txtHoraAdicionalNoturnoInicioSexta.Name = "txtHoraAdicionalNoturnoInicioSexta"
        Me.txtHoraAdicionalNoturnoInicioSexta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoInicioSexta.TabIndex = 55
        Me.txtHoraAdicionalNoturnoInicioSexta.Text = "0"
        Me.txtHoraAdicionalNoturnoInicioSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoInicioSexta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoInicioQuinta
        '
        Me.txtMinutoAdicionalNoturnoInicioQuinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoInicioQuinta.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoInicioQuinta.Location = New System.Drawing.Point(645, 119)
        Me.txtMinutoAdicionalNoturnoInicioQuinta.Name = "txtMinutoAdicionalNoturnoInicioQuinta"
        Me.txtMinutoAdicionalNoturnoInicioQuinta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoInicioQuinta.TabIndex = 54
        Me.txtMinutoAdicionalNoturnoInicioQuinta.Text = "0"
        Me.txtMinutoAdicionalNoturnoInicioQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoInicioQuinta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoInicioQuinta
        '
        Me.txtHoraAdicionalNoturnoInicioQuinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoInicioQuinta.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoInicioQuinta.Location = New System.Drawing.Point(612, 119)
        Me.txtHoraAdicionalNoturnoInicioQuinta.Name = "txtHoraAdicionalNoturnoInicioQuinta"
        Me.txtHoraAdicionalNoturnoInicioQuinta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoInicioQuinta.TabIndex = 53
        Me.txtHoraAdicionalNoturnoInicioQuinta.Text = "0"
        Me.txtHoraAdicionalNoturnoInicioQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoInicioQuinta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoInicioQuarta
        '
        Me.txtMinutoAdicionalNoturnoInicioQuarta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoInicioQuarta.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoInicioQuarta.Location = New System.Drawing.Point(574, 119)
        Me.txtMinutoAdicionalNoturnoInicioQuarta.Name = "txtMinutoAdicionalNoturnoInicioQuarta"
        Me.txtMinutoAdicionalNoturnoInicioQuarta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoInicioQuarta.TabIndex = 52
        Me.txtMinutoAdicionalNoturnoInicioQuarta.Text = "0"
        Me.txtMinutoAdicionalNoturnoInicioQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoInicioQuarta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoInicioQuarta
        '
        Me.txtHoraAdicionalNoturnoInicioQuarta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoInicioQuarta.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoInicioQuarta.Location = New System.Drawing.Point(541, 119)
        Me.txtHoraAdicionalNoturnoInicioQuarta.Name = "txtHoraAdicionalNoturnoInicioQuarta"
        Me.txtHoraAdicionalNoturnoInicioQuarta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoInicioQuarta.TabIndex = 51
        Me.txtHoraAdicionalNoturnoInicioQuarta.Text = "0"
        Me.txtHoraAdicionalNoturnoInicioQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoInicioQuarta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoInicioTerca
        '
        Me.txtMinutoAdicionalNoturnoInicioTerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoInicioTerca.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoInicioTerca.Location = New System.Drawing.Point(503, 119)
        Me.txtMinutoAdicionalNoturnoInicioTerca.Name = "txtMinutoAdicionalNoturnoInicioTerca"
        Me.txtMinutoAdicionalNoturnoInicioTerca.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoInicioTerca.TabIndex = 50
        Me.txtMinutoAdicionalNoturnoInicioTerca.Text = "0"
        Me.txtMinutoAdicionalNoturnoInicioTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoInicioTerca.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoInicioTerca
        '
        Me.txtHoraAdicionalNoturnoInicioTerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoInicioTerca.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoInicioTerca.Location = New System.Drawing.Point(470, 119)
        Me.txtHoraAdicionalNoturnoInicioTerca.Name = "txtHoraAdicionalNoturnoInicioTerca"
        Me.txtHoraAdicionalNoturnoInicioTerca.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoInicioTerca.TabIndex = 49
        Me.txtHoraAdicionalNoturnoInicioTerca.Text = "0"
        Me.txtHoraAdicionalNoturnoInicioTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoInicioTerca.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoAdicionalNoturnoInicioSegunda
        '
        Me.txtMinutoAdicionalNoturnoInicioSegunda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoAdicionalNoturnoInicioSegunda.DecimalDigits = 0
        Me.txtMinutoAdicionalNoturnoInicioSegunda.Location = New System.Drawing.Point(431, 119)
        Me.txtMinutoAdicionalNoturnoInicioSegunda.Name = "txtMinutoAdicionalNoturnoInicioSegunda"
        Me.txtMinutoAdicionalNoturnoInicioSegunda.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoAdicionalNoturnoInicioSegunda.TabIndex = 48
        Me.txtMinutoAdicionalNoturnoInicioSegunda.Text = "0"
        Me.txtMinutoAdicionalNoturnoInicioSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoAdicionalNoturnoInicioSegunda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraAdicionalNoturnoInicioSegunda
        '
        Me.txtHoraAdicionalNoturnoInicioSegunda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraAdicionalNoturnoInicioSegunda.DecimalDigits = 0
        Me.txtHoraAdicionalNoturnoInicioSegunda.Location = New System.Drawing.Point(398, 119)
        Me.txtHoraAdicionalNoturnoInicioSegunda.Name = "txtHoraAdicionalNoturnoInicioSegunda"
        Me.txtHoraAdicionalNoturnoInicioSegunda.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraAdicionalNoturnoInicioSegunda.TabIndex = 47
        Me.txtHoraAdicionalNoturnoInicioSegunda.Text = "0"
        Me.txtHoraAdicionalNoturnoInicioSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraAdicionalNoturnoInicioSegunda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoSaidaDomingo
        '
        Me.txtMinutoSaidaDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoSaidaDomingo.DecimalDigits = 0
        Me.txtMinutoSaidaDomingo.Location = New System.Drawing.Point(858, 67)
        Me.txtMinutoSaidaDomingo.Name = "txtMinutoSaidaDomingo"
        Me.txtMinutoSaidaDomingo.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoSaidaDomingo.TabIndex = 37
        Me.txtMinutoSaidaDomingo.Text = "0"
        Me.txtMinutoSaidaDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoSaidaDomingo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraSaidaDomingo
        '
        Me.txtHoraSaidaDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraSaidaDomingo.DecimalDigits = 0
        Me.txtHoraSaidaDomingo.Location = New System.Drawing.Point(825, 67)
        Me.txtHoraSaidaDomingo.Name = "txtHoraSaidaDomingo"
        Me.txtHoraSaidaDomingo.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraSaidaDomingo.TabIndex = 36
        Me.txtHoraSaidaDomingo.Text = "0"
        Me.txtHoraSaidaDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraSaidaDomingo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoSaidaSabado
        '
        Me.txtMinutoSaidaSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoSaidaSabado.DecimalDigits = 0
        Me.txtMinutoSaidaSabado.Location = New System.Drawing.Point(787, 67)
        Me.txtMinutoSaidaSabado.Name = "txtMinutoSaidaSabado"
        Me.txtMinutoSaidaSabado.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoSaidaSabado.TabIndex = 35
        Me.txtMinutoSaidaSabado.Text = "0"
        Me.txtMinutoSaidaSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoSaidaSabado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraSaidaSabado
        '
        Me.txtHoraSaidaSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraSaidaSabado.DecimalDigits = 0
        Me.txtHoraSaidaSabado.Location = New System.Drawing.Point(754, 67)
        Me.txtHoraSaidaSabado.Name = "txtHoraSaidaSabado"
        Me.txtHoraSaidaSabado.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraSaidaSabado.TabIndex = 34
        Me.txtHoraSaidaSabado.Text = "0"
        Me.txtHoraSaidaSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraSaidaSabado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoSaidaSexta
        '
        Me.txtMinutoSaidaSexta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoSaidaSexta.DecimalDigits = 0
        Me.txtMinutoSaidaSexta.Location = New System.Drawing.Point(716, 67)
        Me.txtMinutoSaidaSexta.Name = "txtMinutoSaidaSexta"
        Me.txtMinutoSaidaSexta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoSaidaSexta.TabIndex = 33
        Me.txtMinutoSaidaSexta.Text = "0"
        Me.txtMinutoSaidaSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoSaidaSexta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraSaidaSexta
        '
        Me.txtHoraSaidaSexta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraSaidaSexta.DecimalDigits = 0
        Me.txtHoraSaidaSexta.Location = New System.Drawing.Point(683, 67)
        Me.txtHoraSaidaSexta.Name = "txtHoraSaidaSexta"
        Me.txtHoraSaidaSexta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraSaidaSexta.TabIndex = 32
        Me.txtHoraSaidaSexta.Text = "0"
        Me.txtHoraSaidaSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraSaidaSexta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoSaidaQuinta
        '
        Me.txtMinutoSaidaQuinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoSaidaQuinta.DecimalDigits = 0
        Me.txtMinutoSaidaQuinta.Location = New System.Drawing.Point(645, 67)
        Me.txtMinutoSaidaQuinta.Name = "txtMinutoSaidaQuinta"
        Me.txtMinutoSaidaQuinta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoSaidaQuinta.TabIndex = 31
        Me.txtMinutoSaidaQuinta.Text = "0"
        Me.txtMinutoSaidaQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoSaidaQuinta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraSaidaQuinta
        '
        Me.txtHoraSaidaQuinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraSaidaQuinta.DecimalDigits = 0
        Me.txtHoraSaidaQuinta.Location = New System.Drawing.Point(612, 67)
        Me.txtHoraSaidaQuinta.Name = "txtHoraSaidaQuinta"
        Me.txtHoraSaidaQuinta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraSaidaQuinta.TabIndex = 30
        Me.txtHoraSaidaQuinta.Text = "0"
        Me.txtHoraSaidaQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraSaidaQuinta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoSaidaQuarta
        '
        Me.txtMinutoSaidaQuarta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoSaidaQuarta.DecimalDigits = 0
        Me.txtMinutoSaidaQuarta.Location = New System.Drawing.Point(574, 67)
        Me.txtMinutoSaidaQuarta.Name = "txtMinutoSaidaQuarta"
        Me.txtMinutoSaidaQuarta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoSaidaQuarta.TabIndex = 29
        Me.txtMinutoSaidaQuarta.Text = "0"
        Me.txtMinutoSaidaQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoSaidaQuarta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraSaidaQuarta
        '
        Me.txtHoraSaidaQuarta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraSaidaQuarta.DecimalDigits = 0
        Me.txtHoraSaidaQuarta.Location = New System.Drawing.Point(541, 67)
        Me.txtHoraSaidaQuarta.Name = "txtHoraSaidaQuarta"
        Me.txtHoraSaidaQuarta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraSaidaQuarta.TabIndex = 28
        Me.txtHoraSaidaQuarta.Text = "0"
        Me.txtHoraSaidaQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraSaidaQuarta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoSaidaTerca
        '
        Me.txtMinutoSaidaTerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoSaidaTerca.DecimalDigits = 0
        Me.txtMinutoSaidaTerca.Location = New System.Drawing.Point(503, 67)
        Me.txtMinutoSaidaTerca.Name = "txtMinutoSaidaTerca"
        Me.txtMinutoSaidaTerca.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoSaidaTerca.TabIndex = 27
        Me.txtMinutoSaidaTerca.Text = "0"
        Me.txtMinutoSaidaTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoSaidaTerca.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraSaidaTerca
        '
        Me.txtHoraSaidaTerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraSaidaTerca.DecimalDigits = 0
        Me.txtHoraSaidaTerca.Location = New System.Drawing.Point(470, 67)
        Me.txtHoraSaidaTerca.Name = "txtHoraSaidaTerca"
        Me.txtHoraSaidaTerca.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraSaidaTerca.TabIndex = 26
        Me.txtHoraSaidaTerca.Text = "0"
        Me.txtHoraSaidaTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraSaidaTerca.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoSaidaSegunda
        '
        Me.txtMinutoSaidaSegunda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoSaidaSegunda.DecimalDigits = 0
        Me.txtMinutoSaidaSegunda.Location = New System.Drawing.Point(431, 67)
        Me.txtMinutoSaidaSegunda.Name = "txtMinutoSaidaSegunda"
        Me.txtMinutoSaidaSegunda.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoSaidaSegunda.TabIndex = 25
        Me.txtMinutoSaidaSegunda.Text = "0"
        Me.txtMinutoSaidaSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoSaidaSegunda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraSaidaSegunda
        '
        Me.txtHoraSaidaSegunda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraSaidaSegunda.DecimalDigits = 0
        Me.txtHoraSaidaSegunda.Location = New System.Drawing.Point(398, 67)
        Me.txtHoraSaidaSegunda.Name = "txtHoraSaidaSegunda"
        Me.txtHoraSaidaSegunda.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraSaidaSegunda.TabIndex = 24
        Me.txtHoraSaidaSegunda.Text = "0"
        Me.txtHoraSaidaSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraSaidaSegunda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoEntradaDomingo
        '
        Me.txtMinutoEntradaDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoEntradaDomingo.DecimalDigits = 0
        Me.txtMinutoEntradaDomingo.Location = New System.Drawing.Point(858, 41)
        Me.txtMinutoEntradaDomingo.Name = "txtMinutoEntradaDomingo"
        Me.txtMinutoEntradaDomingo.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoEntradaDomingo.TabIndex = 22
        Me.txtMinutoEntradaDomingo.Text = "0"
        Me.txtMinutoEntradaDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoEntradaDomingo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraEntradaDomingo
        '
        Me.txtHoraEntradaDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraEntradaDomingo.DecimalDigits = 0
        Me.txtHoraEntradaDomingo.Location = New System.Drawing.Point(825, 41)
        Me.txtHoraEntradaDomingo.Name = "txtHoraEntradaDomingo"
        Me.txtHoraEntradaDomingo.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraEntradaDomingo.TabIndex = 21
        Me.txtHoraEntradaDomingo.Text = "0"
        Me.txtHoraEntradaDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraEntradaDomingo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoEntradaSabado
        '
        Me.txtMinutoEntradaSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoEntradaSabado.DecimalDigits = 0
        Me.txtMinutoEntradaSabado.Location = New System.Drawing.Point(787, 41)
        Me.txtMinutoEntradaSabado.Name = "txtMinutoEntradaSabado"
        Me.txtMinutoEntradaSabado.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoEntradaSabado.TabIndex = 20
        Me.txtMinutoEntradaSabado.Text = "0"
        Me.txtMinutoEntradaSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoEntradaSabado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraEntradaSabado
        '
        Me.txtHoraEntradaSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraEntradaSabado.DecimalDigits = 0
        Me.txtHoraEntradaSabado.Location = New System.Drawing.Point(754, 41)
        Me.txtHoraEntradaSabado.Name = "txtHoraEntradaSabado"
        Me.txtHoraEntradaSabado.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraEntradaSabado.TabIndex = 19
        Me.txtHoraEntradaSabado.Text = "0"
        Me.txtHoraEntradaSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraEntradaSabado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoEntradaSexta
        '
        Me.txtMinutoEntradaSexta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoEntradaSexta.DecimalDigits = 0
        Me.txtMinutoEntradaSexta.Location = New System.Drawing.Point(716, 41)
        Me.txtMinutoEntradaSexta.Name = "txtMinutoEntradaSexta"
        Me.txtMinutoEntradaSexta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoEntradaSexta.TabIndex = 18
        Me.txtMinutoEntradaSexta.Text = "0"
        Me.txtMinutoEntradaSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoEntradaSexta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraEntradaSexta
        '
        Me.txtHoraEntradaSexta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraEntradaSexta.DecimalDigits = 0
        Me.txtHoraEntradaSexta.Location = New System.Drawing.Point(683, 41)
        Me.txtHoraEntradaSexta.Name = "txtHoraEntradaSexta"
        Me.txtHoraEntradaSexta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraEntradaSexta.TabIndex = 17
        Me.txtHoraEntradaSexta.Text = "0"
        Me.txtHoraEntradaSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraEntradaSexta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoEntradaQuinta
        '
        Me.txtMinutoEntradaQuinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoEntradaQuinta.DecimalDigits = 0
        Me.txtMinutoEntradaQuinta.Location = New System.Drawing.Point(645, 41)
        Me.txtMinutoEntradaQuinta.Name = "txtMinutoEntradaQuinta"
        Me.txtMinutoEntradaQuinta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoEntradaQuinta.TabIndex = 16
        Me.txtMinutoEntradaQuinta.Text = "0"
        Me.txtMinutoEntradaQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoEntradaQuinta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraEntradaQuinta
        '
        Me.txtHoraEntradaQuinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraEntradaQuinta.DecimalDigits = 0
        Me.txtHoraEntradaQuinta.Location = New System.Drawing.Point(612, 41)
        Me.txtHoraEntradaQuinta.Name = "txtHoraEntradaQuinta"
        Me.txtHoraEntradaQuinta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraEntradaQuinta.TabIndex = 15
        Me.txtHoraEntradaQuinta.Text = "0"
        Me.txtHoraEntradaQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraEntradaQuinta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoEntradaQuarta
        '
        Me.txtMinutoEntradaQuarta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoEntradaQuarta.DecimalDigits = 0
        Me.txtMinutoEntradaQuarta.Location = New System.Drawing.Point(574, 41)
        Me.txtMinutoEntradaQuarta.Name = "txtMinutoEntradaQuarta"
        Me.txtMinutoEntradaQuarta.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoEntradaQuarta.TabIndex = 14
        Me.txtMinutoEntradaQuarta.Text = "0"
        Me.txtMinutoEntradaQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoEntradaQuarta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraEntradaQuarta
        '
        Me.txtHoraEntradaQuarta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraEntradaQuarta.DecimalDigits = 0
        Me.txtHoraEntradaQuarta.Location = New System.Drawing.Point(541, 41)
        Me.txtHoraEntradaQuarta.Name = "txtHoraEntradaQuarta"
        Me.txtHoraEntradaQuarta.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraEntradaQuarta.TabIndex = 13
        Me.txtHoraEntradaQuarta.Text = "0"
        Me.txtHoraEntradaQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraEntradaQuarta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoEntradaTerca
        '
        Me.txtMinutoEntradaTerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoEntradaTerca.DecimalDigits = 0
        Me.txtMinutoEntradaTerca.Location = New System.Drawing.Point(503, 41)
        Me.txtMinutoEntradaTerca.Name = "txtMinutoEntradaTerca"
        Me.txtMinutoEntradaTerca.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoEntradaTerca.TabIndex = 12
        Me.txtMinutoEntradaTerca.Text = "0"
        Me.txtMinutoEntradaTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoEntradaTerca.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHoraEntradaTerca
        '
        Me.txtHoraEntradaTerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraEntradaTerca.DecimalDigits = 0
        Me.txtHoraEntradaTerca.Location = New System.Drawing.Point(470, 41)
        Me.txtHoraEntradaTerca.Name = "txtHoraEntradaTerca"
        Me.txtHoraEntradaTerca.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraEntradaTerca.TabIndex = 11
        Me.txtHoraEntradaTerca.Text = "0"
        Me.txtHoraEntradaTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraEntradaTerca.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMinutoEntradaSegunda
        '
        Me.txtMinutoEntradaSegunda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMinutoEntradaSegunda.DecimalDigits = 0
        Me.txtMinutoEntradaSegunda.Location = New System.Drawing.Point(431, 41)
        Me.txtMinutoEntradaSegunda.Name = "txtMinutoEntradaSegunda"
        Me.txtMinutoEntradaSegunda.Size = New System.Drawing.Size(30, 20)
        Me.txtMinutoEntradaSegunda.TabIndex = 10
        Me.txtMinutoEntradaSegunda.Text = "0"
        Me.txtMinutoEntradaSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtMinutoEntradaSegunda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblHoraAlmoco
        '
        Me.lblHoraAlmoco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraAlmoco.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraAlmoco.Location = New System.Drawing.Point(6, 97)
        Me.lblHoraAlmoco.Name = "lblHoraAlmoco"
        Me.lblHoraAlmoco.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraAlmoco.TabIndex = 38
        Me.lblHoraAlmoco.Text = "Hora Almoço:"
        '
        'lblHoraSaida
        '
        Me.lblHoraSaida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraSaida.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraSaida.Location = New System.Drawing.Point(6, 71)
        Me.lblHoraSaida.Name = "lblHoraSaida"
        Me.lblHoraSaida.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraSaida.TabIndex = 23
        Me.lblHoraSaida.Text = "Hora Saída:"
        '
        'lblHoraEntrada
        '
        Me.lblHoraEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraEntrada.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraEntrada.Location = New System.Drawing.Point(6, 45)
        Me.lblHoraEntrada.Name = "lblHoraEntrada"
        Me.lblHoraEntrada.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraEntrada.TabIndex = 8
        Me.lblHoraEntrada.Text = "Hora Entrada:"
        '
        'chkDomingo
        '
        Me.chkDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDomingo.Location = New System.Drawing.Point(825, 20)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(63, 15)
        Me.chkDomingo.TabIndex = 7
        Me.chkDomingo.Text = "Domingo"
        '
        'chkSabado
        '
        Me.chkSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSabado.Location = New System.Drawing.Point(754, 20)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(63, 15)
        Me.chkSabado.TabIndex = 6
        Me.chkSabado.Text = "Sabádo"
        '
        'chkSexta
        '
        Me.chkSexta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSexta.Location = New System.Drawing.Point(683, 20)
        Me.chkSexta.Name = "chkSexta"
        Me.chkSexta.Size = New System.Drawing.Size(63, 15)
        Me.chkSexta.TabIndex = 5
        Me.chkSexta.Text = "Sexta"
        '
        'chkQuinta
        '
        Me.chkQuinta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkQuinta.Location = New System.Drawing.Point(612, 20)
        Me.chkQuinta.Name = "chkQuinta"
        Me.chkQuinta.Size = New System.Drawing.Size(63, 15)
        Me.chkQuinta.TabIndex = 4
        Me.chkQuinta.Text = "Quinta"
        '
        'chkQuarta
        '
        Me.chkQuarta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkQuarta.Location = New System.Drawing.Point(541, 20)
        Me.chkQuarta.Name = "chkQuarta"
        Me.chkQuarta.Size = New System.Drawing.Size(63, 15)
        Me.chkQuarta.TabIndex = 3
        Me.chkQuarta.Text = "Quarta"
        '
        'chkTerca
        '
        Me.chkTerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTerca.Location = New System.Drawing.Point(470, 20)
        Me.chkTerca.Name = "chkTerca"
        Me.chkTerca.Size = New System.Drawing.Size(63, 15)
        Me.chkTerca.TabIndex = 2
        Me.chkTerca.Text = "Terça"
        '
        'txtHoraEntradaSegunda
        '
        Me.txtHoraEntradaSegunda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraEntradaSegunda.DecimalDigits = 0
        Me.txtHoraEntradaSegunda.Location = New System.Drawing.Point(398, 41)
        Me.txtHoraEntradaSegunda.Name = "txtHoraEntradaSegunda"
        Me.txtHoraEntradaSegunda.Size = New System.Drawing.Size(30, 20)
        Me.txtHoraEntradaSegunda.TabIndex = 9
        Me.txtHoraEntradaSegunda.Text = "0"
        Me.txtHoraEntradaSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtHoraEntradaSegunda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'chkSegunda
        '
        Me.chkSegunda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSegunda.Location = New System.Drawing.Point(398, 20)
        Me.chkSegunda.Name = "chkSegunda"
        Me.chkSegunda.Size = New System.Drawing.Size(63, 15)
        Me.chkSegunda.TabIndex = 1
        Me.chkSegunda.Text = "Segunda"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
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
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
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
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
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
        Me.txtDescricao.Size = New System.Drawing.Size(685, 20)
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
        'lblHoraExtraPreTurno
        '
        Me.lblHoraExtraPreTurno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraExtraPreTurno.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraExtraPreTurno.Location = New System.Drawing.Point(6, 175)
        Me.lblHoraExtraPreTurno.Name = "lblHoraExtraPreTurno"
        Me.lblHoraExtraPreTurno.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraExtraPreTurno.TabIndex = 76
        Me.lblHoraExtraPreTurno.Text = "Horas Extras Pré-turno:"
        '
        'lblHoraExtraPosTurno
        '
        Me.lblHoraExtraPosTurno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraExtraPosTurno.BackColor = System.Drawing.Color.Moccasin
        Me.lblHoraExtraPosTurno.Location = New System.Drawing.Point(6, 201)
        Me.lblHoraExtraPosTurno.Name = "lblHoraExtraPosTurno"
        Me.lblHoraExtraPosTurno.Size = New System.Drawing.Size(366, 14)
        Me.lblHoraExtraPosTurno.TabIndex = 84
        Me.lblHoraExtraPosTurno.Text = "Horas Extras Pró-turno:"
        '
        'txtHoraAlmocoSegunda
        '
        Me.txtHoraAlmocoSegunda.Location = New System.Drawing.Point(398, 93)
        Me.txtHoraAlmocoSegunda.Mask = "00:00:00"
        Me.txtHoraAlmocoSegunda.Name = "txtHoraAlmocoSegunda"
        Me.txtHoraAlmocoSegunda.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoSegunda.TabIndex = 39
        Me.txtHoraAlmocoSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoTerca
        '
        Me.txtHoraAlmocoTerca.Location = New System.Drawing.Point(470, 93)
        Me.txtHoraAlmocoTerca.Mask = "00:00:00"
        Me.txtHoraAlmocoTerca.Name = "txtHoraAlmocoTerca"
        Me.txtHoraAlmocoTerca.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoTerca.TabIndex = 40
        Me.txtHoraAlmocoTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoQuarta
        '
        Me.txtHoraAlmocoQuarta.Location = New System.Drawing.Point(541, 93)
        Me.txtHoraAlmocoQuarta.Mask = "00:00:00"
        Me.txtHoraAlmocoQuarta.Name = "txtHoraAlmocoQuarta"
        Me.txtHoraAlmocoQuarta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoQuarta.TabIndex = 41
        Me.txtHoraAlmocoQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoQuinta
        '
        Me.txtHoraAlmocoQuinta.Location = New System.Drawing.Point(612, 93)
        Me.txtHoraAlmocoQuinta.Mask = "00:00:00"
        Me.txtHoraAlmocoQuinta.Name = "txtHoraAlmocoQuinta"
        Me.txtHoraAlmocoQuinta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoQuinta.TabIndex = 42
        Me.txtHoraAlmocoQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoSexta
        '
        Me.txtHoraAlmocoSexta.Location = New System.Drawing.Point(683, 93)
        Me.txtHoraAlmocoSexta.Mask = "00:00:00"
        Me.txtHoraAlmocoSexta.Name = "txtHoraAlmocoSexta"
        Me.txtHoraAlmocoSexta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoSexta.TabIndex = 43
        Me.txtHoraAlmocoSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoSabado
        '
        Me.txtHoraAlmocoSabado.Location = New System.Drawing.Point(754, 93)
        Me.txtHoraAlmocoSabado.Mask = "00:00:00"
        Me.txtHoraAlmocoSabado.Name = "txtHoraAlmocoSabado"
        Me.txtHoraAlmocoSabado.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoSabado.TabIndex = 44
        Me.txtHoraAlmocoSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraAlmocoDomingo
        '
        Me.txtHoraAlmocoDomingo.Location = New System.Drawing.Point(825, 93)
        Me.txtHoraAlmocoDomingo.Mask = "00:00:00"
        Me.txtHoraAlmocoDomingo.Name = "txtHoraAlmocoDomingo"
        Me.txtHoraAlmocoDomingo.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraAlmocoDomingo.TabIndex = 45
        Me.txtHoraAlmocoDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPreTurnoDomingo
        '
        Me.txtHoraExtraPreTurnoDomingo.Location = New System.Drawing.Point(825, 171)
        Me.txtHoraExtraPreTurnoDomingo.Mask = "00:00:00"
        Me.txtHoraExtraPreTurnoDomingo.Name = "txtHoraExtraPreTurnoDomingo"
        Me.txtHoraExtraPreTurnoDomingo.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPreTurnoDomingo.TabIndex = 83
        Me.txtHoraExtraPreTurnoDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPreTurnoSabado
        '
        Me.txtHoraExtraPreTurnoSabado.Location = New System.Drawing.Point(754, 171)
        Me.txtHoraExtraPreTurnoSabado.Mask = "00:00:00"
        Me.txtHoraExtraPreTurnoSabado.Name = "txtHoraExtraPreTurnoSabado"
        Me.txtHoraExtraPreTurnoSabado.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPreTurnoSabado.TabIndex = 82
        Me.txtHoraExtraPreTurnoSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPreTurnoSexta
        '
        Me.txtHoraExtraPreTurnoSexta.Location = New System.Drawing.Point(683, 171)
        Me.txtHoraExtraPreTurnoSexta.Mask = "00:00:00"
        Me.txtHoraExtraPreTurnoSexta.Name = "txtHoraExtraPreTurnoSexta"
        Me.txtHoraExtraPreTurnoSexta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPreTurnoSexta.TabIndex = 81
        Me.txtHoraExtraPreTurnoSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPreTurnoQuinta
        '
        Me.txtHoraExtraPreTurnoQuinta.Location = New System.Drawing.Point(612, 171)
        Me.txtHoraExtraPreTurnoQuinta.Mask = "00:00:00"
        Me.txtHoraExtraPreTurnoQuinta.Name = "txtHoraExtraPreTurnoQuinta"
        Me.txtHoraExtraPreTurnoQuinta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPreTurnoQuinta.TabIndex = 80
        Me.txtHoraExtraPreTurnoQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPreTurnoQuarta
        '
        Me.txtHoraExtraPreTurnoQuarta.Location = New System.Drawing.Point(541, 171)
        Me.txtHoraExtraPreTurnoQuarta.Mask = "00:00:00"
        Me.txtHoraExtraPreTurnoQuarta.Name = "txtHoraExtraPreTurnoQuarta"
        Me.txtHoraExtraPreTurnoQuarta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPreTurnoQuarta.TabIndex = 79
        Me.txtHoraExtraPreTurnoQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPreTurnoTerca
        '
        Me.txtHoraExtraPreTurnoTerca.Location = New System.Drawing.Point(470, 171)
        Me.txtHoraExtraPreTurnoTerca.Mask = "00:00:00"
        Me.txtHoraExtraPreTurnoTerca.Name = "txtHoraExtraPreTurnoTerca"
        Me.txtHoraExtraPreTurnoTerca.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPreTurnoTerca.TabIndex = 78
        Me.txtHoraExtraPreTurnoTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPreTurnoSegunda
        '
        Me.txtHoraExtraPreTurnoSegunda.Location = New System.Drawing.Point(398, 171)
        Me.txtHoraExtraPreTurnoSegunda.Mask = "00:00:00"
        Me.txtHoraExtraPreTurnoSegunda.Name = "txtHoraExtraPreTurnoSegunda"
        Me.txtHoraExtraPreTurnoSegunda.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPreTurnoSegunda.TabIndex = 77
        Me.txtHoraExtraPreTurnoSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPosTurnoDomingo
        '
        Me.txtHoraExtraPosTurnoDomingo.Location = New System.Drawing.Point(825, 197)
        Me.txtHoraExtraPosTurnoDomingo.Mask = "00:00:00"
        Me.txtHoraExtraPosTurnoDomingo.Name = "txtHoraExtraPosTurnoDomingo"
        Me.txtHoraExtraPosTurnoDomingo.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPosTurnoDomingo.TabIndex = 91
        Me.txtHoraExtraPosTurnoDomingo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPosTurnoSabado
        '
        Me.txtHoraExtraPosTurnoSabado.Location = New System.Drawing.Point(754, 197)
        Me.txtHoraExtraPosTurnoSabado.Mask = "00:00:00"
        Me.txtHoraExtraPosTurnoSabado.Name = "txtHoraExtraPosTurnoSabado"
        Me.txtHoraExtraPosTurnoSabado.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPosTurnoSabado.TabIndex = 90
        Me.txtHoraExtraPosTurnoSabado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPosTurnoSexta
        '
        Me.txtHoraExtraPosTurnoSexta.Location = New System.Drawing.Point(683, 197)
        Me.txtHoraExtraPosTurnoSexta.Mask = "00:00:00"
        Me.txtHoraExtraPosTurnoSexta.Name = "txtHoraExtraPosTurnoSexta"
        Me.txtHoraExtraPosTurnoSexta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPosTurnoSexta.TabIndex = 89
        Me.txtHoraExtraPosTurnoSexta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPosTurnoQuinta
        '
        Me.txtHoraExtraPosTurnoQuinta.Location = New System.Drawing.Point(612, 197)
        Me.txtHoraExtraPosTurnoQuinta.Mask = "00:00:00"
        Me.txtHoraExtraPosTurnoQuinta.Name = "txtHoraExtraPosTurnoQuinta"
        Me.txtHoraExtraPosTurnoQuinta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPosTurnoQuinta.TabIndex = 88
        Me.txtHoraExtraPosTurnoQuinta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPosTurnoQuarta
        '
        Me.txtHoraExtraPosTurnoQuarta.Location = New System.Drawing.Point(541, 197)
        Me.txtHoraExtraPosTurnoQuarta.Mask = "00:00:00"
        Me.txtHoraExtraPosTurnoQuarta.Name = "txtHoraExtraPosTurnoQuarta"
        Me.txtHoraExtraPosTurnoQuarta.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPosTurnoQuarta.TabIndex = 87
        Me.txtHoraExtraPosTurnoQuarta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPosTurnoTerca
        '
        Me.txtHoraExtraPosTurnoTerca.Location = New System.Drawing.Point(470, 197)
        Me.txtHoraExtraPosTurnoTerca.Mask = "00:00:00"
        Me.txtHoraExtraPosTurnoTerca.Name = "txtHoraExtraPosTurnoTerca"
        Me.txtHoraExtraPosTurnoTerca.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPosTurnoTerca.TabIndex = 86
        Me.txtHoraExtraPosTurnoTerca.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtHoraExtraPosTurnoSegunda
        '
        Me.txtHoraExtraPosTurnoSegunda.Location = New System.Drawing.Point(398, 197)
        Me.txtHoraExtraPosTurnoSegunda.Mask = "00:00:00"
        Me.txtHoraExtraPosTurnoSegunda.Name = "txtHoraExtraPosTurnoSegunda"
        Me.txtHoraExtraPosTurnoSegunda.Size = New System.Drawing.Size(63, 20)
        Me.txtHoraExtraPosTurnoSegunda.TabIndex = 85
        Me.txtHoraExtraPosTurnoSegunda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'usrCadTurnoProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadTurnoProducao"
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
    Friend WithEvents txtMinutoAdicionalNoturnoTerminoDomingo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoTerminoDomingo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoTerminoSabado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoTerminoSabado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoTerminoSexta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoTerminoSexta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoTerminoQuinta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoTerminoQuinta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoTerminoQuarta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoTerminoQuarta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoTerminoTerca As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoTerminoTerca As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoTerminoSegunda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoTerminoSegunda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoInicioDomingo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoInicioDomingo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoInicioSabado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoInicioSabado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoInicioSexta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoInicioSexta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoInicioQuinta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoInicioQuinta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoInicioQuarta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoInicioQuarta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoInicioTerca As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoInicioTerca As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoAdicionalNoturnoInicioSegunda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraAdicionalNoturnoInicioSegunda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoSaidaDomingo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraSaidaDomingo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoSaidaSabado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraSaidaSabado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoSaidaSexta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraSaidaSexta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoSaidaQuinta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraSaidaQuinta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoSaidaQuarta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraSaidaQuarta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoSaidaTerca As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraSaidaTerca As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoSaidaSegunda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraSaidaSegunda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoEntradaDomingo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraEntradaDomingo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoEntradaSabado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraEntradaSabado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoEntradaSexta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraEntradaSexta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoEntradaQuinta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraEntradaQuinta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoEntradaQuarta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraEntradaQuarta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoEntradaTerca As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtHoraEntradaTerca As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMinutoEntradaSegunda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblHoraAlmoco As System.Windows.Forms.Label
    Friend WithEvents lblHoraSaida As System.Windows.Forms.Label
    Friend WithEvents lblHoraEntrada As System.Windows.Forms.Label
    Friend WithEvents chkDomingo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSabado As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSexta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkQuinta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkQuarta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkTerca As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtHoraEntradaSegunda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents chkSegunda As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents lblHoraExtraPosTurno As System.Windows.Forms.Label
    Friend WithEvents lblHoraExtraPreTurno As System.Windows.Forms.Label
    Friend WithEvents txtHoraExtraPosTurnoDomingo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPosTurnoSabado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPosTurnoSexta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPosTurnoQuinta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPosTurnoQuarta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPosTurnoTerca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPosTurnoSegunda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPreTurnoDomingo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPreTurnoSabado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPreTurnoSexta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPreTurnoQuinta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPreTurnoQuarta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPreTurnoTerca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraExtraPreTurnoSegunda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoDomingo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoSabado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoSexta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoQuinta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoQuarta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoTerca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtHoraAlmocoSegunda As Janus.Windows.GridEX.EditControls.MaskedEditBox

End Class
