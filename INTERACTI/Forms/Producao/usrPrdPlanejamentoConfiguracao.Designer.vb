<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrPrdPlanejamentoConfiguracao
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
        Dim grdConfiguracaoOP_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdPlanejamentoConfiguracao))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings4 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings5 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings6 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings7 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings8 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim grdManutencao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdCentroTrabalho_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.pagConfiguracaoOP = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdConfiguracaoOP = New Janus.Windows.GridEX.GridEX()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnRecalcularFila = New Janus.Windows.EditControls.UIButton()
        Me.btnAtualizar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagConfiguracaoGeral = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.grpDataProducao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDataProducaoNetos = New System.Windows.Forms.Label()
        Me.txtDataProducaoNetos = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDataProducaoFilhos = New System.Windows.Forms.Label()
        Me.txtDataProducaoFilhos = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTempoOperacaoUltrapassado = New System.Windows.Forms.Label()
        Me.txtTempoOperacaoUltrapassado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTempoMotivoParadaGrande = New System.Windows.Forms.Label()
        Me.txtTempoMotivoParadaGrande = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTempoSetupUltrapassado = New System.Windows.Forms.Label()
        Me.txtTempoSetupUltrapassado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLeadTimeMetrologia = New System.Windows.Forms.Label()
        Me.txtLeadTimeMetrologia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLeadTimeEstoque = New System.Windows.Forms.Label()
        Me.txtLeadTimeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLeadTimeProducao = New System.Windows.Forms.Label()
        Me.txtLeadTimeProducao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboPriorizacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPriorizacao = New System.Windows.Forms.Label()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizar1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair1 = New Janus.Windows.EditControls.UIButton()
        Me.pagManutencao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdManutencao = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizar2 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair2 = New Janus.Windows.EditControls.UIButton()
        Me.pagCentroTrabalho = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizar3 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair3 = New Janus.Windows.EditControls.UIButton()
        Me.grdCentroTrabalho = New Janus.Windows.GridEX.GridEX()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.pagSintetico = New Janus.Windows.UI.Tab.UITabPage()
        Me.pagConfiguracaoOP.SuspendLayout()
        CType(Me.grdConfiguracaoOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagConfiguracaoGeral.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpDataProducao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDataProducao.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.pagManutencao.SuspendLayout()
        CType(Me.grdManutencao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.pagCentroTrabalho.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.grdCentroTrabalho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pagConfiguracaoOP
        '
        Me.pagConfiguracaoOP.Controls.Add(Me.grdConfiguracaoOP)
        Me.pagConfiguracaoOP.Controls.Add(Me.grpControl2)
        Me.pagConfiguracaoOP.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagConfiguracaoOP.Key = "pagConfiguracaoOP"
        Me.pagConfiguracaoOP.Location = New System.Drawing.Point(1, 22)
        Me.pagConfiguracaoOP.Name = "pagConfiguracaoOP"
        Me.pagConfiguracaoOP.Size = New System.Drawing.Size(964, 436)
        Me.pagConfiguracaoOP.TabStop = True
        Me.pagConfiguracaoOP.Text = "Config. OP"
        '
        'grdConfiguracaoOP
        '
        Me.grdConfiguracaoOP.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdConfiguracaoOP.AlternatingColors = True
        Me.grdConfiguracaoOP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdConfiguracaoOP_DesignTimeLayout.LayoutString = resources.GetString("grdConfiguracaoOP_DesignTimeLayout.LayoutString")
        Me.grdConfiguracaoOP.DesignTimeLayout = grdConfiguracaoOP_DesignTimeLayout
        Me.grdConfiguracaoOP.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdConfiguracaoOP.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdConfiguracaoOP.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdConfiguracaoOP.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdConfiguracaoOP.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdConfiguracaoOP.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdConfiguracaoOP.GroupByBoxVisible = False
        Me.grdConfiguracaoOP.Location = New System.Drawing.Point(9, 9)
        Me.grdConfiguracaoOP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdConfiguracaoOP.Name = "grdConfiguracaoOP"
        Me.grdConfiguracaoOP.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdConfiguracaoOP.RecordNavigator = True
        Me.grdConfiguracaoOP.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdConfiguracaoOP.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdConfiguracaoOP.Size = New System.Drawing.Size(948, 363)
        Me.grdConfiguracaoOP.TabIndex = 12
        Me.grdConfiguracaoOP.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdConfiguracaoOP.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdConfiguracaoOP.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdConfiguracaoOP.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdConfiguracaoOP.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdConfiguracaoOP.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdConfiguracaoOP.VisualStyleManager = Me.vsmMain
        '
        'vsmMain
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme1)
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnRecalcularFila)
        Me.grpControl2.Controls.Add(Me.btnAtualizar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(9, 378)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(948, 51)
        Me.grpControl2.TabIndex = 11
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnRecalcularFila
        '
        Me.btnRecalcularFila.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecalcularFila.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnRecalcularFila.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRecalcularFila.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnRecalcularFila.Location = New System.Drawing.Point(609, 18)
        Me.btnRecalcularFila.Name = "btnRecalcularFila"
        Me.btnRecalcularFila.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRecalcularFila.Size = New System.Drawing.Size(137, 23)
        Me.btnRecalcularFila.TabIndex = 13
        Me.btnRecalcularFila.Text = "Recalcular Fila"
        Me.btnRecalcularFila.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar.Image = CType(resources.GetObject("btnAtualizar.Image"), System.Drawing.Image)
        Me.btnAtualizar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAtualizar.Location = New System.Drawing.Point(752, 18)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizar.Size = New System.Drawing.Size(91, 23)
        Me.btnAtualizar.TabIndex = 12
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(849, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 11
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.tabMain.Size = New System.Drawing.Size(966, 459)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagConfiguracaoOP, Me.pagConfiguracaoGeral, Me.pagManutencao, Me.pagCentroTrabalho})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagConfiguracaoGeral
        '
        Me.pagConfiguracaoGeral.Controls.Add(Me.grpDados)
        Me.pagConfiguracaoGeral.Controls.Add(Me.UiGroupBox1)
        Me.pagConfiguracaoGeral.Key = "pagConfiguracaoGeral"
        Me.pagConfiguracaoGeral.Location = New System.Drawing.Point(1, 22)
        Me.pagConfiguracaoGeral.Name = "pagConfiguracaoGeral"
        Me.pagConfiguracaoGeral.Size = New System.Drawing.Size(964, 436)
        Me.pagConfiguracaoGeral.TabStop = True
        Me.pagConfiguracaoGeral.Text = "Config. Geral"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.grpDataProducao)
        Me.grpDados.Controls.Add(Me.lblTempoOperacaoUltrapassado)
        Me.grpDados.Controls.Add(Me.txtTempoOperacaoUltrapassado)
        Me.grpDados.Controls.Add(Me.lblTempoMotivoParadaGrande)
        Me.grpDados.Controls.Add(Me.txtTempoMotivoParadaGrande)
        Me.grpDados.Controls.Add(Me.lblTempoSetupUltrapassado)
        Me.grpDados.Controls.Add(Me.txtTempoSetupUltrapassado)
        Me.grpDados.Controls.Add(Me.lblLeadTimeMetrologia)
        Me.grpDados.Controls.Add(Me.txtLeadTimeMetrologia)
        Me.grpDados.Controls.Add(Me.lblLeadTimeEstoque)
        Me.grpDados.Controls.Add(Me.txtLeadTimeEstoque)
        Me.grpDados.Controls.Add(Me.lblLeadTimeProducao)
        Me.grpDados.Controls.Add(Me.txtLeadTimeProducao)
        Me.grpDados.Controls.Add(Me.cboPriorizacao)
        Me.grpDados.Controls.Add(Me.lblPriorizacao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(948, 369)
        Me.grpDados.TabIndex = 13
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'grpDataProducao
        '
        Me.grpDataProducao.BackColor = System.Drawing.Color.Transparent
        Me.grpDataProducao.Controls.Add(Me.lblDataProducaoNetos)
        Me.grpDataProducao.Controls.Add(Me.txtDataProducaoNetos)
        Me.grpDataProducao.Controls.Add(Me.lblDataProducaoFilhos)
        Me.grpDataProducao.Controls.Add(Me.txtDataProducaoFilhos)
        Me.grpDataProducao.Location = New System.Drawing.Point(9, 181)
        Me.grpDataProducao.Name = "grpDataProducao"
        Me.grpDataProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDataProducao.Size = New System.Drawing.Size(288, 109)
        Me.grpDataProducao.TabIndex = 28
        Me.grpDataProducao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDataProducao.VisualStyleManager = Me.vsmMain
        '
        'lblDataProducaoNetos
        '
        Me.lblDataProducaoNetos.AutoSize = True
        Me.lblDataProducaoNetos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataProducaoNetos.Location = New System.Drawing.Point(6, 57)
        Me.lblDataProducaoNetos.Name = "lblDataProducaoNetos"
        Me.lblDataProducaoNetos.Size = New System.Drawing.Size(164, 14)
        SuperTipSettings1.HeaderText = "Lead Time para Produção"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Lead time para calcular necessidade em dias úteis do material estar pronto antes " &
    "da Data Produção (cliente)"
        Me.jstMain.SetSuperTip(Me.lblDataProducaoNetos, SuperTipSettings1)
        Me.lblDataProducaoNetos.TabIndex = 30
        Me.lblDataProducaoNetos.Text = "Data Produção OPs Netas (Dias)"
        '
        'txtDataProducaoNetos
        '
        Me.txtDataProducaoNetos.DecimalDigits = 0
        Me.txtDataProducaoNetos.Location = New System.Drawing.Point(9, 74)
        Me.txtDataProducaoNetos.Name = "txtDataProducaoNetos"
        Me.txtDataProducaoNetos.Size = New System.Drawing.Size(273, 20)
        Me.txtDataProducaoNetos.TabIndex = 31
        Me.txtDataProducaoNetos.Text = "0"
        Me.txtDataProducaoNetos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDataProducaoFilhos
        '
        Me.lblDataProducaoFilhos.AutoSize = True
        Me.lblDataProducaoFilhos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataProducaoFilhos.Location = New System.Drawing.Point(6, 17)
        Me.lblDataProducaoFilhos.Name = "lblDataProducaoFilhos"
        Me.lblDataProducaoFilhos.Size = New System.Drawing.Size(164, 14)
        SuperTipSettings2.HeaderText = "Lead Time para Produção"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Lead time para calcular necessidade em dias úteis do material estar pronto antes " &
    "da Data Produção (cliente)"
        Me.jstMain.SetSuperTip(Me.lblDataProducaoFilhos, SuperTipSettings2)
        Me.lblDataProducaoFilhos.TabIndex = 28
        Me.lblDataProducaoFilhos.Text = "Data Produção OPs Filhas (Dias)"
        '
        'txtDataProducaoFilhos
        '
        Me.txtDataProducaoFilhos.DecimalDigits = 0
        Me.txtDataProducaoFilhos.Location = New System.Drawing.Point(9, 34)
        Me.txtDataProducaoFilhos.Name = "txtDataProducaoFilhos"
        Me.txtDataProducaoFilhos.Size = New System.Drawing.Size(273, 20)
        Me.txtDataProducaoFilhos.TabIndex = 29
        Me.txtDataProducaoFilhos.Text = "0"
        Me.txtDataProducaoFilhos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTempoOperacaoUltrapassado
        '
        Me.lblTempoOperacaoUltrapassado.AutoSize = True
        Me.lblTempoOperacaoUltrapassado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTempoOperacaoUltrapassado.Location = New System.Drawing.Point(6, 138)
        Me.lblTempoOperacaoUltrapassado.Name = "lblTempoOperacaoUltrapassado"
        Me.lblTempoOperacaoUltrapassado.Size = New System.Drawing.Size(222, 14)
        SuperTipSettings3.HeaderText = "Lead Time para Estoque"
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Lead time para calcular necessidade em dias úteis do material estar pronto antes " &
    "de entrar no estoque"
        Me.jstMain.SetSuperTip(Me.lblTempoOperacaoUltrapassado, SuperTipSettings3)
        Me.lblTempoOperacaoUltrapassado.TabIndex = 22
        Me.lblTempoOperacaoUltrapassado.Text = "Tempo de Operação Ultrapassado (Minutos):"
        '
        'txtTempoOperacaoUltrapassado
        '
        Me.txtTempoOperacaoUltrapassado.DecimalDigits = 0
        Me.txtTempoOperacaoUltrapassado.Location = New System.Drawing.Point(9, 155)
        Me.txtTempoOperacaoUltrapassado.Name = "txtTempoOperacaoUltrapassado"
        Me.txtTempoOperacaoUltrapassado.Size = New System.Drawing.Size(288, 20)
        Me.txtTempoOperacaoUltrapassado.TabIndex = 23
        Me.txtTempoOperacaoUltrapassado.Text = "0"
        Me.txtTempoOperacaoUltrapassado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTempoMotivoParadaGrande
        '
        Me.lblTempoMotivoParadaGrande.AutoSize = True
        Me.lblTempoMotivoParadaGrande.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTempoMotivoParadaGrande.Location = New System.Drawing.Point(6, 98)
        Me.lblTempoMotivoParadaGrande.Name = "lblTempoMotivoParadaGrande"
        Me.lblTempoMotivoParadaGrande.Size = New System.Drawing.Size(257, 14)
        SuperTipSettings4.HeaderText = "Lead Time para Estoque"
        SuperTipSettings4.ImageListProvider = Nothing
        SuperTipSettings4.Text = "Lead time para calcular necessidade em dias úteis do material estar pronto antes " &
    "de entrar no estoque"
        Me.jstMain.SetSuperTip(Me.lblTempoMotivoParadaGrande, SuperTipSettings4)
        Me.lblTempoMotivoParadaGrande.TabIndex = 20
        Me.lblTempoMotivoParadaGrande.Text = "Tempo de Motivo de Parada Muito Grande (Minutos):"
        '
        'txtTempoMotivoParadaGrande
        '
        Me.txtTempoMotivoParadaGrande.DecimalDigits = 0
        Me.txtTempoMotivoParadaGrande.Location = New System.Drawing.Point(9, 115)
        Me.txtTempoMotivoParadaGrande.Name = "txtTempoMotivoParadaGrande"
        Me.txtTempoMotivoParadaGrande.Size = New System.Drawing.Size(288, 20)
        Me.txtTempoMotivoParadaGrande.TabIndex = 21
        Me.txtTempoMotivoParadaGrande.Text = "0"
        Me.txtTempoMotivoParadaGrande.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTempoSetupUltrapassado
        '
        Me.lblTempoSetupUltrapassado.AutoSize = True
        Me.lblTempoSetupUltrapassado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTempoSetupUltrapassado.Location = New System.Drawing.Point(6, 58)
        Me.lblTempoSetupUltrapassado.Name = "lblTempoSetupUltrapassado"
        Me.lblTempoSetupUltrapassado.Size = New System.Drawing.Size(202, 14)
        SuperTipSettings5.HeaderText = "Lead Time para Produção"
        SuperTipSettings5.ImageListProvider = Nothing
        SuperTipSettings5.Text = "Lead time para calcular necessidade em dias úteis do material estar pronto antes " &
    "da Data Produção (cliente)"
        Me.jstMain.SetSuperTip(Me.lblTempoSetupUltrapassado, SuperTipSettings5)
        Me.lblTempoSetupUltrapassado.TabIndex = 18
        Me.lblTempoSetupUltrapassado.Text = "Tempo de Setup Ultrapassado (Minutos):"
        '
        'txtTempoSetupUltrapassado
        '
        Me.txtTempoSetupUltrapassado.DecimalDigits = 0
        Me.txtTempoSetupUltrapassado.Location = New System.Drawing.Point(9, 75)
        Me.txtTempoSetupUltrapassado.Name = "txtTempoSetupUltrapassado"
        Me.txtTempoSetupUltrapassado.Size = New System.Drawing.Size(288, 20)
        Me.txtTempoSetupUltrapassado.TabIndex = 19
        Me.txtTempoSetupUltrapassado.Text = "0"
        Me.txtTempoSetupUltrapassado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLeadTimeMetrologia
        '
        Me.lblLeadTimeMetrologia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLeadTimeMetrologia.AutoSize = True
        Me.lblLeadTimeMetrologia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLeadTimeMetrologia.Location = New System.Drawing.Point(656, 17)
        Me.lblLeadTimeMetrologia.Name = "lblLeadTimeMetrologia"
        Me.lblLeadTimeMetrologia.Size = New System.Drawing.Size(153, 14)
        SuperTipSettings6.HeaderText = "Lead Time para Estoque"
        SuperTipSettings6.ImageListProvider = Nothing
        SuperTipSettings6.Text = "Lead time para calcular necessidade em dias úteis do material estar pronto antes " &
    "de entrar no estoque"
        Me.jstMain.SetSuperTip(Me.lblLeadTimeMetrologia, SuperTipSettings6)
        Me.lblLeadTimeMetrologia.TabIndex = 16
        Me.lblLeadTimeMetrologia.Text = "Lead Time para Metrologia (d):"
        '
        'txtLeadTimeMetrologia
        '
        Me.txtLeadTimeMetrologia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLeadTimeMetrologia.DecimalDigits = 0
        Me.txtLeadTimeMetrologia.Location = New System.Drawing.Point(659, 34)
        Me.txtLeadTimeMetrologia.Name = "txtLeadTimeMetrologia"
        Me.txtLeadTimeMetrologia.Size = New System.Drawing.Size(172, 20)
        Me.txtLeadTimeMetrologia.TabIndex = 17
        Me.txtLeadTimeMetrologia.Text = "0"
        Me.txtLeadTimeMetrologia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLeadTimeEstoque
        '
        Me.lblLeadTimeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLeadTimeEstoque.AutoSize = True
        Me.lblLeadTimeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLeadTimeEstoque.Location = New System.Drawing.Point(478, 17)
        Me.lblLeadTimeEstoque.Name = "lblLeadTimeEstoque"
        Me.lblLeadTimeEstoque.Size = New System.Drawing.Size(143, 14)
        SuperTipSettings7.HeaderText = "Lead Time para Estoque"
        SuperTipSettings7.ImageListProvider = Nothing
        SuperTipSettings7.Text = "Lead time para calcular necessidade em dias úteis do material estar pronto antes " &
    "de entrar no estoque"
        Me.jstMain.SetSuperTip(Me.lblLeadTimeEstoque, SuperTipSettings7)
        Me.lblLeadTimeEstoque.TabIndex = 14
        Me.lblLeadTimeEstoque.Text = "Lead Time para Estoque (d):"
        '
        'txtLeadTimeEstoque
        '
        Me.txtLeadTimeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLeadTimeEstoque.DecimalDigits = 0
        Me.txtLeadTimeEstoque.Location = New System.Drawing.Point(481, 34)
        Me.txtLeadTimeEstoque.Name = "txtLeadTimeEstoque"
        Me.txtLeadTimeEstoque.Size = New System.Drawing.Size(172, 20)
        Me.txtLeadTimeEstoque.TabIndex = 15
        Me.txtLeadTimeEstoque.Text = "0"
        Me.txtLeadTimeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLeadTimeProducao
        '
        Me.lblLeadTimeProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLeadTimeProducao.AutoSize = True
        Me.lblLeadTimeProducao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLeadTimeProducao.Location = New System.Drawing.Point(300, 17)
        Me.lblLeadTimeProducao.Name = "lblLeadTimeProducao"
        Me.lblLeadTimeProducao.Size = New System.Drawing.Size(175, 14)
        SuperTipSettings8.HeaderText = "Lead Time para Produção"
        SuperTipSettings8.ImageListProvider = Nothing
        SuperTipSettings8.Text = "Lead time para calcular necessidade em dias úteis do material estar pronto antes " &
    "da Data Produção (cliente)"
        Me.jstMain.SetSuperTip(Me.lblLeadTimeProducao, SuperTipSettings8)
        Me.lblLeadTimeProducao.TabIndex = 12
        Me.lblLeadTimeProducao.Text = "Lead Time para Data Produção (d):"
        '
        'txtLeadTimeProducao
        '
        Me.txtLeadTimeProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLeadTimeProducao.DecimalDigits = 0
        Me.txtLeadTimeProducao.Location = New System.Drawing.Point(303, 34)
        Me.txtLeadTimeProducao.Name = "txtLeadTimeProducao"
        Me.txtLeadTimeProducao.Size = New System.Drawing.Size(172, 20)
        Me.txtLeadTimeProducao.TabIndex = 13
        Me.txtLeadTimeProducao.Text = "0"
        Me.txtLeadTimeProducao.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboPriorizacao
        '
        Me.cboPriorizacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPriorizacao.AutoSize = False
        Me.cboPriorizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPriorizacao.Location = New System.Drawing.Point(9, 34)
        Me.cboPriorizacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPriorizacao.Name = "cboPriorizacao"
        Me.cboPriorizacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPriorizacao.Size = New System.Drawing.Size(288, 20)
        Me.cboPriorizacao.TabIndex = 3
        '
        'lblPriorizacao
        '
        Me.lblPriorizacao.AutoSize = True
        Me.lblPriorizacao.Location = New System.Drawing.Point(6, 17)
        Me.lblPriorizacao.Name = "lblPriorizacao"
        Me.lblPriorizacao.Size = New System.Drawing.Size(64, 14)
        Me.lblPriorizacao.TabIndex = 0
        Me.lblPriorizacao.Text = "Priorização:"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnAtualizar1)
        Me.UiGroupBox1.Controls.Add(Me.btnSair1)
        Me.UiGroupBox1.Location = New System.Drawing.Point(9, 378)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(948, 51)
        Me.UiGroupBox1.TabIndex = 12
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizar1
        '
        Me.btnAtualizar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar1.Image = CType(resources.GetObject("btnAtualizar1.Image"), System.Drawing.Image)
        Me.btnAtualizar1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizar1.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAtualizar1.Location = New System.Drawing.Point(752, 18)
        Me.btnAtualizar1.Name = "btnAtualizar1"
        Me.btnAtualizar1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizar1.Size = New System.Drawing.Size(91, 23)
        Me.btnAtualizar1.TabIndex = 12
        Me.btnAtualizar1.Text = "Atualizar"
        Me.btnAtualizar1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair1
        '
        Me.btnSair1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair1.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair1.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair1.Location = New System.Drawing.Point(849, 18)
        Me.btnSair1.Name = "btnSair1"
        Me.btnSair1.Size = New System.Drawing.Size(91, 23)
        Me.btnSair1.TabIndex = 11
        Me.btnSair1.Text = "Sair"
        Me.btnSair1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagManutencao
        '
        Me.pagManutencao.Controls.Add(Me.grdManutencao)
        Me.pagManutencao.Controls.Add(Me.UiGroupBox2)
        Me.pagManutencao.Key = "pagManutencao"
        Me.pagManutencao.Location = New System.Drawing.Point(1, 22)
        Me.pagManutencao.Name = "pagManutencao"
        Me.pagManutencao.Size = New System.Drawing.Size(964, 436)
        Me.pagManutencao.TabStop = True
        Me.pagManutencao.Text = "Manutenção"
        '
        'grdManutencao
        '
        Me.grdManutencao.AlternatingColors = True
        Me.grdManutencao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.grdManutencao.Location = New System.Drawing.Point(9, 9)
        Me.grdManutencao.Name = "grdManutencao"
        Me.grdManutencao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdManutencao.RecordNavigator = True
        Me.grdManutencao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdManutencao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdManutencao.Size = New System.Drawing.Size(948, 363)
        Me.grdManutencao.TabIndex = 14
        Me.grdManutencao.TabStop = False
        Me.grdManutencao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdManutencao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdManutencao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdManutencao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdManutencao.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnAtualizar2)
        Me.UiGroupBox2.Controls.Add(Me.btnSair2)
        Me.UiGroupBox2.Location = New System.Drawing.Point(9, 378)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(948, 51)
        Me.UiGroupBox2.TabIndex = 13
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizar2
        '
        Me.btnAtualizar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar2.Image = CType(resources.GetObject("btnAtualizar2.Image"), System.Drawing.Image)
        Me.btnAtualizar2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizar2.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAtualizar2.Location = New System.Drawing.Point(752, 18)
        Me.btnAtualizar2.Name = "btnAtualizar2"
        Me.btnAtualizar2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizar2.Size = New System.Drawing.Size(91, 23)
        Me.btnAtualizar2.TabIndex = 12
        Me.btnAtualizar2.Text = "Atualizar"
        Me.btnAtualizar2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair2
        '
        Me.btnSair2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair2.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair2.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair2.Location = New System.Drawing.Point(849, 18)
        Me.btnSair2.Name = "btnSair2"
        Me.btnSair2.Size = New System.Drawing.Size(91, 23)
        Me.btnSair2.TabIndex = 11
        Me.btnSair2.Text = "Sair"
        Me.btnSair2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagCentroTrabalho
        '
        Me.pagCentroTrabalho.Controls.Add(Me.UiGroupBox3)
        Me.pagCentroTrabalho.Controls.Add(Me.grdCentroTrabalho)
        Me.pagCentroTrabalho.Key = "pagCentroTrabalho"
        Me.pagCentroTrabalho.Location = New System.Drawing.Point(1, 22)
        Me.pagCentroTrabalho.Name = "pagCentroTrabalho"
        Me.pagCentroTrabalho.Size = New System.Drawing.Size(964, 436)
        Me.pagCentroTrabalho.TabStop = True
        Me.pagCentroTrabalho.Tag = ""
        Me.pagCentroTrabalho.Text = "Centro de Trabalho"
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.btnAtualizar3)
        Me.UiGroupBox3.Controls.Add(Me.btnSair3)
        Me.UiGroupBox3.Location = New System.Drawing.Point(9, 378)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(948, 51)
        Me.UiGroupBox3.TabIndex = 14
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizar3
        '
        Me.btnAtualizar3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar3.Image = CType(resources.GetObject("btnAtualizar3.Image"), System.Drawing.Image)
        Me.btnAtualizar3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizar3.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAtualizar3.Location = New System.Drawing.Point(752, 18)
        Me.btnAtualizar3.Name = "btnAtualizar3"
        Me.btnAtualizar3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizar3.Size = New System.Drawing.Size(91, 23)
        Me.btnAtualizar3.TabIndex = 12
        Me.btnAtualizar3.Text = "Atualizar"
        Me.btnAtualizar3.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair3
        '
        Me.btnSair3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair3.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair3.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair3.Location = New System.Drawing.Point(849, 18)
        Me.btnSair3.Name = "btnSair3"
        Me.btnSair3.Size = New System.Drawing.Size(91, 23)
        Me.btnSair3.TabIndex = 11
        Me.btnSair3.Text = "Sair"
        Me.btnSair3.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdCentroTrabalho
        '
        Me.grdCentroTrabalho.AlternatingColors = True
        Me.grdCentroTrabalho.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdCentroTrabalho_DesignTimeLayout.LayoutString = resources.GetString("grdCentroTrabalho_DesignTimeLayout.LayoutString")
        Me.grdCentroTrabalho.DesignTimeLayout = grdCentroTrabalho_DesignTimeLayout
        Me.grdCentroTrabalho.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCentroTrabalho.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCentroTrabalho.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdCentroTrabalho.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCentroTrabalho.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCentroTrabalho.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCentroTrabalho.GroupByBoxVisible = False
        Me.grdCentroTrabalho.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdCentroTrabalho.Location = New System.Drawing.Point(9, 9)
        Me.grdCentroTrabalho.Name = "grdCentroTrabalho"
        Me.grdCentroTrabalho.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCentroTrabalho.RecordNavigator = True
        Me.grdCentroTrabalho.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdCentroTrabalho.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCentroTrabalho.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCentroTrabalho.Size = New System.Drawing.Size(948, 363)
        Me.grdCentroTrabalho.TabIndex = 8
        Me.grdCentroTrabalho.TabStop = False
        Me.grdCentroTrabalho.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCentroTrabalho.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCentroTrabalho.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCentroTrabalho.VisualStyleManager = Me.vsmMain
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 60000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.ShowAlways = True
        '
        'pagSintetico
        '
        Me.pagSintetico.Location = New System.Drawing.Point(1, 22)
        Me.pagSintetico.Name = "pagSintetico"
        Me.pagSintetico.Size = New System.Drawing.Size(946, 291)
        Me.pagSintetico.TabStop = True
        Me.pagSintetico.Text = "Sintético"
        '
        'usrPrdPlanejamentoConfiguracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdPlanejamentoConfiguracao"
        Me.Size = New System.Drawing.Size(966, 459)
        Me.pagConfiguracaoOP.ResumeLayout(False)
        CType(Me.grdConfiguracaoOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagConfiguracaoGeral.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpDataProducao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDataProducao.ResumeLayout(False)
        Me.grpDataProducao.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.pagManutencao.ResumeLayout(False)
        CType(Me.grdManutencao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.pagCentroTrabalho.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.grdCentroTrabalho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents pagSintetico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAtualizar As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagConfiguracaoGeral As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAtualizar1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboPriorizacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPriorizacao As Label
    Friend WithEvents pagManutencao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAtualizar2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagCentroTrabalho As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAtualizar3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdCentroTrabalho As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdConfiguracaoOP As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagConfiguracaoOP As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdManutencao As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnRecalcularFila As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblLeadTimeEstoque As System.Windows.Forms.Label
    Friend WithEvents txtLeadTimeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLeadTimeProducao As System.Windows.Forms.Label
    Friend WithEvents txtLeadTimeProducao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLeadTimeMetrologia As System.Windows.Forms.Label
    Friend WithEvents txtLeadTimeMetrologia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTempoOperacaoUltrapassado As Label
    Friend WithEvents txtTempoOperacaoUltrapassado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTempoMotivoParadaGrande As Label
    Friend WithEvents txtTempoMotivoParadaGrande As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTempoSetupUltrapassado As Label
    Friend WithEvents txtTempoSetupUltrapassado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpDataProducao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataProducaoNetos As Label
    Friend WithEvents txtDataProducaoNetos As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDataProducaoFilhos As Label
    Friend WithEvents txtDataProducaoFilhos As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
