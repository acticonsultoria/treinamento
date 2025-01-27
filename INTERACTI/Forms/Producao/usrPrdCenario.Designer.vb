<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdCenario
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdPool_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdCarga_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim grdManutencao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdManutencao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdOrcamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdOrcamentoOperacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPlanejamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdCenario))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataCenarioFiltroTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCenarioFiltro = New System.Windows.Forms.Label()
        Me.dtpDataCenarioFiltroInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblCenarioFiltro = New System.Windows.Forms.Label()
        Me.txtCenarioFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picPedidoCompra = New System.Windows.Forms.PictureBox()
        Me.picAguardandoCotacao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPedidoCompra = New System.Windows.Forms.Label()
        Me.lblLegendaAguardandoCotacao = New System.Windows.Forms.Label()
        Me.grpFiltroPool = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfigurarPeriodo = New Janus.Windows.EditControls.UIButton()
        Me.cboMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.lblDiasUteisFiltro = New System.Windows.Forms.Label()
        Me.txtDiasUteisFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataTerminoFiltro = New System.Windows.Forms.Label()
        Me.btnGerarCenario = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagPool = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdPool = New Janus.Windows.GridEX.GridEX()
        Me.pagCarga = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdCarga = New Janus.Windows.GridEX.GridEX()
        Me.pagManutencao = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnCadastrarCentroTrabalho = New System.Windows.Forms.Button()
        Me.grdManutencao = New Janus.Windows.GridEX.GridEX()
        Me.pagConfiguracaoCarga = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdOrcamento = New Janus.Windows.GridEX.GridEX()
        Me.grpOrcamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEntregaOrcamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntregaOrcamento = New System.Windows.Forms.Label()
        Me.btnInserirOrcamento = New Janus.Windows.EditControls.UIButton()
        Me.cboOrcamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrcamento = New System.Windows.Forms.Label()
        Me.grdOrcamentoOperacao = New Janus.Windows.GridEX.GridEX()
        Me.pagPlanejamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdPlanejamento = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarGrafico = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDataCenario = New System.Windows.Forms.Label()
        Me.dtpDataCenario = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblCenario = New System.Windows.Forms.Label()
        Me.txtCenario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.SchedulePrintDocument1 = New Janus.Windows.Schedule.SchedulePrintDocument()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picPedidoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAguardandoCotacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltroPool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltroPool.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagPool.SuspendLayout()
        CType(Me.grdPool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCarga.SuspendLayout()
        CType(Me.grdCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagManutencao.SuspendLayout()
        CType(Me.grdManutencao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagConfiguracaoCarga.SuspendLayout()
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrcamento.SuspendLayout()
        CType(Me.grdOrcamentoOperacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagPlanejamento.SuspendLayout()
        CType(Me.grdPlanejamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
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
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Cenário"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
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
        Me.grpFiltro.Controls.Add(Me.dtpDataCenarioFiltroTermino)
        Me.grpFiltro.Controls.Add(Me.lblDataCenarioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataCenarioFiltroInicio)
        Me.grpFiltro.Controls.Add(Me.lblCenarioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCenarioFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataCenarioFiltroTermino
        '
        '
        '
        '
        Me.dtpDataCenarioFiltroTermino.DropDownCalendar.Name = ""
        Me.dtpDataCenarioFiltroTermino.Location = New System.Drawing.Point(291, 34)
        Me.dtpDataCenarioFiltroTermino.Name = "dtpDataCenarioFiltroTermino"
        Me.dtpDataCenarioFiltroTermino.ShowCheckBox = True
        Me.dtpDataCenarioFiltroTermino.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataCenarioFiltroTermino.TabIndex = 2
        Me.dtpDataCenarioFiltroTermino.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataCenarioFiltro
        '
        Me.lblDataCenarioFiltro.AutoSize = True
        Me.lblDataCenarioFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblDataCenarioFiltro.Location = New System.Drawing.Point(182, 17)
        Me.lblDataCenarioFiltro.Name = "lblDataCenarioFiltro"
        Me.lblDataCenarioFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataCenarioFiltro.TabIndex = 30
        Me.lblDataCenarioFiltro.Text = "Data:"
        '
        'dtpDataCenarioFiltroInicio
        '
        '
        '
        '
        Me.dtpDataCenarioFiltroInicio.DropDownCalendar.Name = ""
        Me.dtpDataCenarioFiltroInicio.Location = New System.Drawing.Point(185, 34)
        Me.dtpDataCenarioFiltroInicio.Name = "dtpDataCenarioFiltroInicio"
        Me.dtpDataCenarioFiltroInicio.ShowCheckBox = True
        Me.dtpDataCenarioFiltroInicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataCenarioFiltroInicio.TabIndex = 1
        Me.dtpDataCenarioFiltroInicio.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblCenarioFiltro
        '
        Me.lblCenarioFiltro.AutoSize = True
        Me.lblCenarioFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCenarioFiltro.Name = "lblCenarioFiltro"
        Me.lblCenarioFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblCenarioFiltro.TabIndex = 0
        Me.lblCenarioFiltro.Text = "Cenário:"
        '
        'txtCenarioFiltro
        '
        Me.txtCenarioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCenarioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCenarioFiltro.MaxLength = 100
        Me.txtCenarioFiltro.Name = "txtCenarioFiltro"
        Me.txtCenarioFiltro.Size = New System.Drawing.Size(170, 20)
        Me.txtCenarioFiltro.TabIndex = 0
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 3
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
        Me.grpControl.TabIndex = 1
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
        Me.btnNovo1.TabIndex = 0
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
        Me.btnSair.TabIndex = 2
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
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpLegenda)
        Me.pagDados.Controls.Add(Me.grpFiltroPool)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Cenário"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picPedidoCompra)
        Me.grpLegenda.Controls.Add(Me.picAguardandoCotacao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoCompra)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoCotacao)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(9, 393)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(219, 51)
        Me.grpLegenda.TabIndex = 4
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picPedidoCompra
        '
        Me.picPedidoCompra.BackColor = System.Drawing.Color.Firebrick
        Me.picPedidoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPedidoCompra.Location = New System.Drawing.Point(9, 31)
        Me.picPedidoCompra.Name = "picPedidoCompra"
        Me.picPedidoCompra.Size = New System.Drawing.Size(13, 14)
        Me.picPedidoCompra.TabIndex = 14
        Me.picPedidoCompra.TabStop = False
        '
        'picAguardandoCotacao
        '
        Me.picAguardandoCotacao.BackColor = System.Drawing.Color.Purple
        Me.picAguardandoCotacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAguardandoCotacao.Location = New System.Drawing.Point(9, 13)
        Me.picAguardandoCotacao.Name = "picAguardandoCotacao"
        Me.picAguardandoCotacao.Size = New System.Drawing.Size(13, 14)
        Me.picAguardandoCotacao.TabIndex = 12
        Me.picAguardandoCotacao.TabStop = False
        '
        'lblLegendaPedidoCompra
        '
        Me.lblLegendaPedidoCompra.AutoSize = True
        Me.lblLegendaPedidoCompra.Location = New System.Drawing.Point(27, 31)
        Me.lblLegendaPedidoCompra.Name = "lblLegendaPedidoCompra"
        Me.lblLegendaPedidoCompra.Size = New System.Drawing.Size(190, 14)
        Me.lblLegendaPedidoCompra.TabIndex = 2
        Me.lblLegendaPedidoCompra.Text = "Não Planejado (excedente do término)"
        '
        'lblLegendaAguardandoCotacao
        '
        Me.lblLegendaAguardandoCotacao.AutoSize = True
        Me.lblLegendaAguardandoCotacao.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaAguardandoCotacao.Name = "lblLegendaAguardandoCotacao"
        Me.lblLegendaAguardandoCotacao.Size = New System.Drawing.Size(44, 14)
        Me.lblLegendaAguardandoCotacao.TabIndex = 0
        Me.lblLegendaAguardandoCotacao.Text = "Externo"
        '
        'grpFiltroPool
        '
        Me.grpFiltroPool.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltroPool.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltroPool.Controls.Add(Me.btnConfigurarPeriodo)
        Me.grpFiltroPool.Controls.Add(Me.cboMaquina)
        Me.grpFiltroPool.Controls.Add(Me.lblMaquina)
        Me.grpFiltroPool.Controls.Add(Me.lblDiasUteisFiltro)
        Me.grpFiltroPool.Controls.Add(Me.txtDiasUteisFiltro)
        Me.grpFiltroPool.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltroPool.Controls.Add(Me.lblDataTerminoFiltro)
        Me.grpFiltroPool.Controls.Add(Me.btnGerarCenario)
        Me.grpFiltroPool.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltroPool.Location = New System.Drawing.Point(393, 3)
        Me.grpFiltroPool.Name = "grpFiltroPool"
        Me.grpFiltroPool.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltroPool.Size = New System.Drawing.Size(512, 71)
        Me.grpFiltroPool.TabIndex = 1
        Me.grpFiltroPool.Text = "Filtros de Planejamento"
        Me.grpFiltroPool.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltroPool.VisualStyleManager = Me.vsmMain
        '
        'btnConfigurarPeriodo
        '
        Me.btnConfigurarPeriodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarPeriodo.Image = Global.INTERACTI.My.Resources.Resources.configuracao
        Me.btnConfigurarPeriodo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfigurarPeriodo.Location = New System.Drawing.Point(371, 41)
        Me.btnConfigurarPeriodo.Name = "btnConfigurarPeriodo"
        Me.btnConfigurarPeriodo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfigurarPeriodo.Size = New System.Drawing.Size(132, 23)
        Me.btnConfigurarPeriodo.TabIndex = 19
        Me.btnConfigurarPeriodo.Text = "Configurar Período"
        Me.btnConfigurarPeriodo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoSize = False
        Me.cboMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboMaquina.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboMaquina.Location = New System.Drawing.Point(164, 34)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaquina.Size = New System.Drawing.Size(192, 20)
        Me.cboMaquina.TabIndex = 18
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.Location = New System.Drawing.Point(161, 17)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(50, 14)
        Me.lblMaquina.TabIndex = 7
        Me.lblMaquina.Text = "Máquina:"
        '
        'lblDiasUteisFiltro
        '
        Me.lblDiasUteisFiltro.AutoSize = True
        Me.lblDiasUteisFiltro.Location = New System.Drawing.Point(100, 17)
        Me.lblDiasUteisFiltro.Name = "lblDiasUteisFiltro"
        Me.lblDiasUteisFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblDiasUteisFiltro.TabIndex = 8
        Me.lblDiasUteisFiltro.Text = "Dias Úteis:"
        '
        'txtDiasUteisFiltro
        '
        Me.txtDiasUteisFiltro.DecimalDigits = 0
        Me.txtDiasUteisFiltro.Location = New System.Drawing.Point(103, 34)
        Me.txtDiasUteisFiltro.Name = "txtDiasUteisFiltro"
        Me.txtDiasUteisFiltro.Size = New System.Drawing.Size(55, 20)
        Me.txtDiasUteisFiltro.TabIndex = 1
        Me.txtDiasUteisFiltro.Text = "0"
        Me.txtDiasUteisFiltro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(88, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 0
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataTerminoFiltro
        '
        Me.lblDataTerminoFiltro.AutoSize = True
        Me.lblDataTerminoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDataTerminoFiltro.Name = "lblDataTerminoFiltro"
        Me.lblDataTerminoFiltro.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTerminoFiltro.TabIndex = 2
        Me.lblDataTerminoFiltro.Text = "Data Término:"
        '
        'btnGerarCenario
        '
        Me.btnGerarCenario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarCenario.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnGerarCenario.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarCenario.Location = New System.Drawing.Point(371, 12)
        Me.btnGerarCenario.Name = "btnGerarCenario"
        Me.btnGerarCenario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarCenario.Size = New System.Drawing.Size(132, 23)
        Me.btnGerarCenario.TabIndex = 2
        Me.btnGerarCenario.Text = "Gerar Cenário"
        Me.btnGerarCenario.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 80)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 307)
        Me.tabDados.TabIndex = 2
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagPool, Me.pagCarga, Me.pagManutencao, Me.pagConfiguracaoCarga, Me.pagPlanejamento})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagPool
        '
        Me.pagPool.Controls.Add(Me.grdPool)
        Me.pagPool.Key = "pagPool"
        Me.pagPool.Location = New System.Drawing.Point(1, 22)
        Me.pagPool.Name = "pagPool"
        Me.pagPool.Size = New System.Drawing.Size(895, 284)
        Me.pagPool.TabStop = True
        Me.pagPool.Text = "Pool"
        '
        'grdPool
        '
        Me.grdPool.AlternatingColors = True
        Me.grdPool.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdPool_DesignTimeLayout.LayoutString = resources.GetString("grdPool_DesignTimeLayout.LayoutString")
        Me.grdPool.DesignTimeLayout = grdPool_DesignTimeLayout
        Me.grdPool.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPool.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPool.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPool.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPool.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPool.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPool.GroupByBoxVisible = False
        Me.grdPool.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPool.Location = New System.Drawing.Point(8, 3)
        Me.grdPool.Name = "grdPool"
        Me.grdPool.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPool.RecordNavigator = True
        Me.grdPool.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPool.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPool.Size = New System.Drawing.Size(879, 278)
        Me.grdPool.TabIndex = 2
        Me.grdPool.TabStop = False
        Me.grdPool.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPool.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPool.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPool.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPool.VisualStyleManager = Me.vsmMain
        '
        'pagCarga
        '
        Me.pagCarga.Controls.Add(Me.grdCarga)
        Me.pagCarga.Key = "pagCarga"
        Me.pagCarga.Location = New System.Drawing.Point(1, 22)
        Me.pagCarga.Name = "pagCarga"
        Me.pagCarga.Size = New System.Drawing.Size(895, 284)
        Me.pagCarga.TabStop = True
        Me.pagCarga.Text = "Carga"
        '
        'grdCarga
        '
        Me.grdCarga.AlternatingColors = True
        Me.grdCarga.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdCarga_DesignTimeLayout.LayoutString = resources.GetString("grdCarga_DesignTimeLayout.LayoutString")
        Me.grdCarga.DesignTimeLayout = grdCarga_DesignTimeLayout
        Me.grdCarga.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCarga.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCarga.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdCarga.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCarga.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCarga.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCarga.GroupByBoxVisible = False
        Me.grdCarga.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdCarga.Location = New System.Drawing.Point(8, 3)
        Me.grdCarga.Name = "grdCarga"
        Me.grdCarga.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCarga.RecordNavigator = True
        Me.grdCarga.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCarga.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCarga.Size = New System.Drawing.Size(879, 278)
        Me.grdCarga.TabIndex = 3
        Me.grdCarga.TabStop = False
        Me.grdCarga.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCarga.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCarga.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCarga.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCarga.VisualStyleManager = Me.vsmMain
        '
        'pagManutencao
        '
        Me.pagManutencao.Controls.Add(Me.btnCadastrarCentroTrabalho)
        Me.pagManutencao.Controls.Add(Me.grdManutencao)
        Me.pagManutencao.Key = "pagManutencao"
        Me.pagManutencao.Location = New System.Drawing.Point(1, 22)
        Me.pagManutencao.Name = "pagManutencao"
        Me.pagManutencao.Size = New System.Drawing.Size(895, 284)
        Me.pagManutencao.TabStop = True
        Me.pagManutencao.Text = "Manutenção"
        '
        'btnCadastrarCentroTrabalho
        '
        Me.btnCadastrarCentroTrabalho.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarCentroTrabalho.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroTrabalho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroTrabalho.Image = CType(resources.GetObject("btnCadastrarCentroTrabalho.Image"), System.Drawing.Image)
        Me.btnCadastrarCentroTrabalho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroTrabalho.Location = New System.Drawing.Point(11, 266)
        Me.btnCadastrarCentroTrabalho.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroTrabalho.Name = "btnCadastrarCentroTrabalho"
        Me.btnCadastrarCentroTrabalho.Size = New System.Drawing.Size(13, 13)
        SuperTipSettings2.HeaderText = "Inserir Manutenção"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Clique aqui para inserir uma manutenção neste cenário."
        Me.jstTip.SetSuperTip(Me.btnCadastrarCentroTrabalho, SuperTipSettings2)
        Me.btnCadastrarCentroTrabalho.TabIndex = 6
        Me.btnCadastrarCentroTrabalho.TabStop = False
        Me.btnCadastrarCentroTrabalho.UseVisualStyleBackColor = True
        '
        'grdManutencao
        '
        Me.grdManutencao.AlternatingColors = True
        Me.grdManutencao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdManutencao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdManutencao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdManutencao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdManutencao_DesignTimeLayout_Reference_0})
        grdManutencao_DesignTimeLayout.LayoutString = resources.GetString("grdManutencao_DesignTimeLayout.LayoutString")
        Me.grdManutencao.DesignTimeLayout = grdManutencao_DesignTimeLayout
        Me.grdManutencao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdManutencao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdManutencao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdManutencao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdManutencao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdManutencao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdManutencao.GroupByBoxVisible = False
        Me.grdManutencao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdManutencao.Location = New System.Drawing.Point(8, 3)
        Me.grdManutencao.Name = "grdManutencao"
        Me.grdManutencao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdManutencao.RecordNavigator = True
        Me.grdManutencao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdManutencao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdManutencao.Size = New System.Drawing.Size(879, 278)
        Me.grdManutencao.TabIndex = 5
        Me.grdManutencao.TabStop = False
        Me.grdManutencao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdManutencao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdManutencao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdManutencao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdManutencao.VisualStyleManager = Me.vsmMain
        '
        'pagConfiguracaoCarga
        '
        Me.pagConfiguracaoCarga.Controls.Add(Me.grdOrcamento)
        Me.pagConfiguracaoCarga.Controls.Add(Me.grpOrcamento)
        Me.pagConfiguracaoCarga.Controls.Add(Me.grdOrcamentoOperacao)
        Me.pagConfiguracaoCarga.Location = New System.Drawing.Point(1, 22)
        Me.pagConfiguracaoCarga.Name = "pagConfiguracaoCarga"
        Me.pagConfiguracaoCarga.Size = New System.Drawing.Size(895, 284)
        Me.pagConfiguracaoCarga.TabStop = True
        Me.pagConfiguracaoCarga.Text = "Configuração de carga adicional"
        '
        'grdOrcamento
        '
        Me.grdOrcamento.AlternatingColors = True
        Me.grdOrcamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdOrcamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdOrcamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdOrcamento_DesignTimeLayout_Reference_0})
        grdOrcamento_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamento_DesignTimeLayout.LayoutString")
        Me.grdOrcamento.DesignTimeLayout = grdOrcamento_DesignTimeLayout
        Me.grdOrcamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdOrcamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamento.GroupByBoxVisible = False
        Me.grdOrcamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamento.Location = New System.Drawing.Point(8, 83)
        Me.grdOrcamento.Name = "grdOrcamento"
        Me.grdOrcamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamento.RecordNavigator = True
        Me.grdOrcamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamento.Size = New System.Drawing.Size(568, 192)
        Me.grdOrcamento.TabIndex = 9
        Me.grdOrcamento.TabStop = False
        Me.grdOrcamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamento.VisualStyleManager = Me.vsmMain
        '
        'grpOrcamento
        '
        Me.grpOrcamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.grpOrcamento.Controls.Add(Me.dtpDataEntregaOrcamento)
        Me.grpOrcamento.Controls.Add(Me.lblDataEntregaOrcamento)
        Me.grpOrcamento.Controls.Add(Me.btnInserirOrcamento)
        Me.grpOrcamento.Controls.Add(Me.cboOrcamento)
        Me.grpOrcamento.Controls.Add(Me.lblOrcamento)
        Me.grpOrcamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpOrcamento.Location = New System.Drawing.Point(9, 6)
        Me.grpOrcamento.Name = "grpOrcamento"
        Me.grpOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOrcamento.Size = New System.Drawing.Size(567, 71)
        Me.grpOrcamento.TabIndex = 8
        Me.grpOrcamento.Text = "Inserir Orçamento"
        Me.grpOrcamento.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpOrcamento.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEntregaOrcamento
        '
        Me.dtpDataEntregaOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEntregaOrcamento.DropDownCalendar.Name = ""
        Me.dtpDataEntregaOrcamento.Location = New System.Drawing.Point(346, 34)
        Me.dtpDataEntregaOrcamento.Name = "dtpDataEntregaOrcamento"
        Me.dtpDataEntregaOrcamento.Size = New System.Drawing.Size(88, 20)
        Me.dtpDataEntregaOrcamento.TabIndex = 31
        Me.dtpDataEntregaOrcamento.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntregaOrcamento
        '
        Me.lblDataEntregaOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEntregaOrcamento.AutoSize = True
        Me.lblDataEntregaOrcamento.Location = New System.Drawing.Point(343, 17)
        Me.lblDataEntregaOrcamento.Name = "lblDataEntregaOrcamento"
        Me.lblDataEntregaOrcamento.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntregaOrcamento.TabIndex = 32
        Me.lblDataEntregaOrcamento.Text = "Data Entrega:"
        '
        'btnInserirOrcamento
        '
        Me.btnInserirOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirOrcamento.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnInserirOrcamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirOrcamento.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnInserirOrcamento.Location = New System.Drawing.Point(440, 31)
        Me.btnInserirOrcamento.Name = "btnInserirOrcamento"
        Me.btnInserirOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirOrcamento.Size = New System.Drawing.Size(121, 23)
        Me.btnInserirOrcamento.TabIndex = 30
        Me.btnInserirOrcamento.Text = "Inserir"
        Me.btnInserirOrcamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboOrcamento
        '
        Me.cboOrcamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOrcamento.AutoSize = False
        Me.cboOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = "SIM"
        UiComboBoxItem7.Value = True
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = "NÃO"
        UiComboBoxItem8.Value = False
        Me.cboOrcamento.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboOrcamento.Location = New System.Drawing.Point(9, 34)
        Me.cboOrcamento.Name = "cboOrcamento"
        Me.cboOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrcamento.Size = New System.Drawing.Size(331, 20)
        Me.cboOrcamento.TabIndex = 29
        '
        'lblOrcamento
        '
        Me.lblOrcamento.AutoSize = True
        Me.lblOrcamento.Location = New System.Drawing.Point(6, 17)
        Me.lblOrcamento.Name = "lblOrcamento"
        Me.lblOrcamento.Size = New System.Drawing.Size(78, 14)
        Me.lblOrcamento.TabIndex = 2
        Me.lblOrcamento.Text = "Nº Orçamento:"
        '
        'grdOrcamentoOperacao
        '
        Me.grdOrcamentoOperacao.AlternatingColors = True
        Me.grdOrcamentoOperacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoOperacao_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoOperacao_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoOperacao.DesignTimeLayout = grdOrcamentoOperacao_DesignTimeLayout
        Me.grdOrcamentoOperacao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamentoOperacao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoOperacao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdOrcamentoOperacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoOperacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoOperacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoOperacao.GroupByBoxVisible = False
        Me.grdOrcamentoOperacao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamentoOperacao.Location = New System.Drawing.Point(582, 6)
        Me.grdOrcamentoOperacao.Name = "grdOrcamentoOperacao"
        Me.grdOrcamentoOperacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoOperacao.RecordNavigator = True
        Me.grdOrcamentoOperacao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoOperacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoOperacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoOperacao.Size = New System.Drawing.Size(305, 269)
        Me.grdOrcamentoOperacao.TabIndex = 7
        Me.grdOrcamentoOperacao.TabStop = False
        Me.grdOrcamentoOperacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoOperacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoOperacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoOperacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoOperacao.VisualStyleManager = Me.vsmMain
        '
        'pagPlanejamento
        '
        Me.pagPlanejamento.Controls.Add(Me.grdPlanejamento)
        Me.pagPlanejamento.Key = "pagPlanejamento"
        Me.pagPlanejamento.Location = New System.Drawing.Point(1, 22)
        Me.pagPlanejamento.Name = "pagPlanejamento"
        Me.pagPlanejamento.Size = New System.Drawing.Size(895, 284)
        Me.pagPlanejamento.TabStop = True
        Me.pagPlanejamento.Text = "Planejamento"
        '
        'grdPlanejamento
        '
        Me.grdPlanejamento.AlternatingColors = True
        Me.grdPlanejamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdPlanejamento_DesignTimeLayout.LayoutString = resources.GetString("grdPlanejamento_DesignTimeLayout.LayoutString")
        Me.grdPlanejamento.DesignTimeLayout = grdPlanejamento_DesignTimeLayout
        Me.grdPlanejamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPlanejamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPlanejamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPlanejamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPlanejamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPlanejamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPlanejamento.GroupByBoxVisible = False
        Me.grdPlanejamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPlanejamento.Location = New System.Drawing.Point(8, 7)
        Me.grdPlanejamento.Name = "grdPlanejamento"
        Me.grdPlanejamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPlanejamento.RecordNavigator = True
        Me.grdPlanejamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPlanejamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPlanejamento.Size = New System.Drawing.Size(879, 272)
        Me.grdPlanejamento.TabIndex = 5
        Me.grdPlanejamento.TabStop = False
        Me.grdPlanejamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPlanejamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPlanejamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPlanejamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPlanejamento.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnVisualizarGrafico)
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(234, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(671, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarGrafico
        '
        Me.btnVisualizarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarGrafico.Image = CType(resources.GetObject("btnVisualizarGrafico.Image"), System.Drawing.Image)
        Me.btnVisualizarGrafico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarGrafico.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnVisualizarGrafico.Location = New System.Drawing.Point(251, 17)
        Me.btnVisualizarGrafico.Name = "btnVisualizarGrafico"
        Me.btnVisualizarGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarGrafico.Size = New System.Drawing.Size(121, 23)
        Me.btnVisualizarGrafico.TabIndex = 3
        Me.btnVisualizarGrafico.Text = "Visualizar Gráfico"
        Me.btnVisualizarGrafico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(377, 17)
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
        Me.btnVoltar.Location = New System.Drawing.Point(571, 17)
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
        Me.btnSalvar.Location = New System.Drawing.Point(474, 17)
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
        Me.grpDados.Controls.Add(Me.cboStatusFiltro)
        Me.grpDados.Controls.Add(Me.lblStatusFiltro)
        Me.grpDados.Controls.Add(Me.lblDataCenario)
        Me.grpDados.Controls.Add(Me.dtpDataCenario)
        Me.grpDados.Controls.Add(Me.lblCenario)
        Me.grpDados.Controls.Add(Me.txtCenario)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(379, 71)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados do Cenário"
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblDataCenario
        '
        Me.lblDataCenario.AutoSize = True
        Me.lblDataCenario.BackColor = System.Drawing.Color.Transparent
        Me.lblDataCenario.Location = New System.Drawing.Point(146, 17)
        Me.lblDataCenario.Name = "lblDataCenario"
        Me.lblDataCenario.Size = New System.Drawing.Size(32, 14)
        Me.lblDataCenario.TabIndex = 28
        Me.lblDataCenario.Text = "Data:"
        '
        'dtpDataCenario
        '
        '
        '
        '
        Me.dtpDataCenario.DropDownCalendar.Name = ""
        Me.dtpDataCenario.Location = New System.Drawing.Point(149, 34)
        Me.dtpDataCenario.Name = "dtpDataCenario"
        Me.dtpDataCenario.Size = New System.Drawing.Size(88, 20)
        Me.dtpDataCenario.TabIndex = 1
        Me.dtpDataCenario.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblCenario
        '
        Me.lblCenario.AutoSize = True
        Me.lblCenario.Location = New System.Drawing.Point(6, 17)
        Me.lblCenario.Name = "lblCenario"
        Me.lblCenario.Size = New System.Drawing.Size(47, 14)
        Me.lblCenario.TabIndex = 2
        Me.lblCenario.Text = "Cenário:"
        '
        'txtCenario
        '
        Me.txtCenario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCenario.Location = New System.Drawing.Point(9, 34)
        Me.txtCenario.MaxLength = 100
        Me.txtCenario.Name = "txtCenario"
        Me.txtCenario.Size = New System.Drawing.Size(134, 20)
        Me.txtCenario.TabIndex = 0
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 1
        Me.jstTip.BodyWidth = 200
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 1
        Me.jstTip.ShowAlways = True
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(243, 35)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(130, 20)
        Me.cboStatusFiltro.TabIndex = 46
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(240, 18)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 45
        Me.lblStatusFiltro.Text = "Status:"
        '
        'usrPrdCenario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdCenario"
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
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picPedidoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAguardandoCotacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltroPool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltroPool.ResumeLayout(False)
        Me.grpFiltroPool.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagPool.ResumeLayout(False)
        CType(Me.grdPool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCarga.ResumeLayout(False)
        CType(Me.grdCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagManutencao.ResumeLayout(False)
        CType(Me.grdManutencao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagConfiguracaoCarga.ResumeLayout(False)
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrcamento.ResumeLayout(False)
        Me.grpOrcamento.PerformLayout()
        CType(Me.grdOrcamentoOperacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagPlanejamento.ResumeLayout(False)
        CType(Me.grdPlanejamento, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblCenarioFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCenarioFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnGerarCenario As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCenario As System.Windows.Forms.Label
    Friend WithEvents txtCenario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataCenarioFiltroTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCenarioFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataCenarioFiltroInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCenario As System.Windows.Forms.Label
    Friend WithEvents dtpDataCenario As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagPool As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdPool As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagCarga As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdCarga As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagManutencao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdManutencao As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagPlanejamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdPlanejamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltroPool As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataTerminoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDiasUteisFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDiasUteisFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarCentroTrabalho As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnConfigurarPeriodo As Janus.Windows.EditControls.UIButton
    Friend WithEvents SchedulePrintDocument1 As Janus.Windows.Schedule.SchedulePrintDocument
    Friend WithEvents btnVisualizarGrafico As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaquina As Label
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picPedidoCompra As System.Windows.Forms.PictureBox
    Friend WithEvents picAguardandoCotacao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPedidoCompra As System.Windows.Forms.Label
    Friend WithEvents lblLegendaAguardandoCotacao As System.Windows.Forms.Label
    Friend WithEvents pagConfiguracaoCarga As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpOrcamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboOrcamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrcamento As System.Windows.Forms.Label
    Friend WithEvents grdOrcamentoOperacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdOrcamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnInserirOrcamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataEntregaOrcamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntregaOrcamento As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
End Class
