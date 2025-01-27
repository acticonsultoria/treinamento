<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrManRequisicaoAprovar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrManRequisicaoAprovar))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim cboRequisitanteFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaReprovado = New System.Windows.Forms.Label()
        Me.picReprovado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAprovado = New System.Windows.Forms.Label()
        Me.picAprovado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAguardandoAprovacao = New System.Windows.Forms.Label()
        Me.picAguardandoAprovacao = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboManutencaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboRequisitanteFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataRequisicaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataRequisicaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblRequisitante = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblManutencaoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblDataRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblStatusRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnAprovar = New Janus.Windows.EditControls.UIButton()
        Me.btnReprovar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpManutencao = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboArea = New Janus.Windows.EditControls.UIComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.dtpDataNecessidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboManutencao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblManutencao = New System.Windows.Forms.Label()
        Me.lblJustificativa = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtComplemento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataNecessidade = New System.Windows.Forms.Label()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.btnCadastrarArea = New System.Windows.Forms.Button()
        Me.btnCadastrarManutencao = New System.Windows.Forms.Button()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAprovador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.lblAprovador = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picReprovado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAprovado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAguardandoAprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpManutencao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpManutencao.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Aprovar / Reprovar - Requisição de Manutenção"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 55
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 10
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
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
        Me.btnConfigurarGrid.TabIndex = 9
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 3
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaReprovado)
        Me.grpLegenda.Controls.Add(Me.picReprovado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAprovado)
        Me.grpLegenda.Controls.Add(Me.picAprovado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoAprovacao)
        Me.grpLegenda.Controls.Add(Me.picAguardandoAprovacao)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(422, 51)
        Me.grpLegenda.TabIndex = 2
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaReprovado
        '
        Me.lblLegendaReprovado.AutoSize = True
        Me.lblLegendaReprovado.Location = New System.Drawing.Point(358, 21)
        Me.lblLegendaReprovado.Name = "lblLegendaReprovado"
        Me.lblLegendaReprovado.Size = New System.Drawing.Size(60, 14)
        Me.lblLegendaReprovado.TabIndex = 5
        Me.lblLegendaReprovado.Text = "Reprovada"
        '
        'picReprovado
        '
        Me.picReprovado.BackColor = System.Drawing.Color.Firebrick
        Me.picReprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picReprovado.Location = New System.Drawing.Point(339, 21)
        Me.picReprovado.Name = "picReprovado"
        Me.picReprovado.Size = New System.Drawing.Size(13, 14)
        Me.picReprovado.TabIndex = 18
        Me.picReprovado.TabStop = False
        '
        'lblLegendaAprovado
        '
        Me.lblLegendaAprovado.AutoSize = True
        Me.lblLegendaAprovado.Location = New System.Drawing.Point(176, 21)
        Me.lblLegendaAprovado.Name = "lblLegendaAprovado"
        Me.lblLegendaAprovado.Size = New System.Drawing.Size(157, 14)
        Me.lblLegendaAprovado.TabIndex = 2
        Me.lblLegendaAprovado.Text = "Aguardando Ordem de Serviço"
        '
        'picAprovado
        '
        Me.picAprovado.BackColor = System.Drawing.Color.Peru
        Me.picAprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAprovado.Location = New System.Drawing.Point(157, 21)
        Me.picAprovado.Name = "picAprovado"
        Me.picAprovado.Size = New System.Drawing.Size(13, 14)
        Me.picAprovado.TabIndex = 6
        Me.picAprovado.TabStop = False
        '
        'lblLegendaAguardandoAprovacao
        '
        Me.lblLegendaAguardandoAprovacao.AutoSize = True
        Me.lblLegendaAguardandoAprovacao.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaAguardandoAprovacao.Name = "lblLegendaAguardandoAprovacao"
        Me.lblLegendaAguardandoAprovacao.Size = New System.Drawing.Size(123, 14)
        Me.lblLegendaAguardandoAprovacao.TabIndex = 0
        Me.lblLegendaAguardandoAprovacao.Text = "Aguardando Aprovação"
        '
        'picAguardandoAprovacao
        '
        Me.picAguardandoAprovacao.BackColor = System.Drawing.Color.SteelBlue
        Me.picAguardandoAprovacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAguardandoAprovacao.Location = New System.Drawing.Point(9, 21)
        Me.picAguardandoAprovacao.Name = "picAguardandoAprovacao"
        Me.picAguardandoAprovacao.Size = New System.Drawing.Size(13, 14)
        Me.picAguardandoAprovacao.TabIndex = 4
        Me.picAguardandoAprovacao.TabStop = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboManutencaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRequisitante)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblManutencaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusRequisicaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboManutencaoFiltro
        '
        Me.cboManutencaoFiltro.AutoSize = False
        Me.cboManutencaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboManutencaoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboManutencaoFiltro.Name = "cboManutencaoFiltro"
        Me.cboManutencaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboManutencaoFiltro.Size = New System.Drawing.Size(515, 20)
        Me.cboManutencaoFiltro.TabIndex = 8
        '
        'cboRequisitanteFiltro
        '
        Me.cboRequisitanteFiltro.AllowDrop = True
        Me.cboRequisitanteFiltro.ButtonCancelText = "Cancelar"
        Me.cboRequisitanteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboRequisitanteFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboRequisitanteFiltro_DesignTimeLayout.LayoutString")
        Me.cboRequisitanteFiltro.DesignTimeLayout = cboRequisitanteFiltro_DesignTimeLayout
        Me.cboRequisitanteFiltro.Location = New System.Drawing.Point(130, 34)
        Me.cboRequisitanteFiltro.Name = "cboRequisitanteFiltro"
        Me.cboRequisitanteFiltro.SaveSettings = False
        Me.cboRequisitanteFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboRequisitanteFiltro.Size = New System.Drawing.Size(394, 20)
        Me.cboRequisitanteFiltro.TabIndex = 3
        Me.cboRequisitanteFiltro.ValuesDataMember = Nothing
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(530, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(222, 20)
        Me.cboStatusFiltro.TabIndex = 10
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'dtpDataRequisicaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoTerminoFiltro.Location = New System.Drawing.Point(644, 34)
        Me.dtpDataRequisicaoTerminoFiltro.Name = "dtpDataRequisicaoTerminoFiltro"
        Me.dtpDataRequisicaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRequisicaoTerminoFiltro.TabIndex = 6
        '
        'dtpDataRequisicaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoInicioFiltro.Location = New System.Drawing.Point(530, 34)
        Me.dtpDataRequisicaoInicioFiltro.Name = "dtpDataRequisicaoInicioFiltro"
        Me.dtpDataRequisicaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRequisicaoInicioFiltro.TabIndex = 5
        '
        'lblRequisitante
        '
        Me.lblRequisitante.AutoSize = True
        Me.lblRequisitante.Location = New System.Drawing.Point(127, 17)
        Me.lblRequisitante.Name = "lblRequisitante"
        Me.lblRequisitante.Size = New System.Drawing.Size(69, 14)
        Me.lblRequisitante.TabIndex = 2
        Me.lblRequisitante.Text = "Requisitante:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblManutencaoFiltro
        '
        Me.lblManutencaoFiltro.AutoSize = True
        Me.lblManutencaoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblManutencaoFiltro.Name = "lblManutencaoFiltro"
        Me.lblManutencaoFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblManutencaoFiltro.TabIndex = 7
        Me.lblManutencaoFiltro.Text = "Manutenção:"
        '
        'txtNumeroRequisicaoFiltro
        '
        Me.txtNumeroRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicaoFiltro.MaxLength = 8
        Me.txtNumeroRequisicaoFiltro.Name = "txtNumeroRequisicaoFiltro"
        Me.txtNumeroRequisicaoFiltro.Size = New System.Drawing.Size(115, 20)
        Me.txtNumeroRequisicaoFiltro.TabIndex = 1
        '
        'lblNumeroRequisicaoFiltro
        '
        Me.lblNumeroRequisicaoFiltro.AutoSize = True
        Me.lblNumeroRequisicaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicaoFiltro.Name = "lblNumeroRequisicaoFiltro"
        Me.lblNumeroRequisicaoFiltro.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicaoFiltro.TabIndex = 0
        Me.lblNumeroRequisicaoFiltro.Text = "Nº Requisição:"
        '
        'lblDataRequisicaoFiltro
        '
        Me.lblDataRequisicaoFiltro.AutoSize = True
        Me.lblDataRequisicaoFiltro.Location = New System.Drawing.Point(527, 17)
        Me.lblDataRequisicaoFiltro.Name = "lblDataRequisicaoFiltro"
        Me.lblDataRequisicaoFiltro.Size = New System.Drawing.Size(103, 14)
        Me.lblDataRequisicaoFiltro.TabIndex = 4
        Me.lblDataRequisicaoFiltro.Text = "Data da Requisição:"
        '
        'lblStatusRequisicaoFiltro
        '
        Me.lblStatusRequisicaoFiltro.AutoSize = True
        Me.lblStatusRequisicaoFiltro.Location = New System.Drawing.Point(527, 57)
        Me.lblStatusRequisicaoFiltro.Name = "lblStatusRequisicaoFiltro"
        Me.lblStatusRequisicaoFiltro.Size = New System.Drawing.Size(97, 14)
        Me.lblStatusRequisicaoFiltro.TabIndex = 9
        Me.lblStatusRequisicaoFiltro.Text = "Status Requisição:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnAprovar)
        Me.grpControle.Controls.Add(Me.btnReprovar)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(439, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(551, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 9
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 10
        Me.cboCongelarColuna.TabStop = False
        '
        'btnAprovar
        '
        Me.btnAprovar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAprovar.Image = CType(resources.GetObject("btnAprovar.Image"), System.Drawing.Image)
        Me.btnAprovar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAprovar.Location = New System.Drawing.Point(257, 17)
        Me.btnAprovar.Name = "btnAprovar"
        Me.btnAprovar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAprovar.Size = New System.Drawing.Size(91, 23)
        Me.btnAprovar.TabIndex = 1
        Me.btnAprovar.Text = "Aprovar"
        Me.btnAprovar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnReprovar
        '
        Me.btnReprovar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReprovar.Image = CType(resources.GetObject("btnReprovar.Image"), System.Drawing.Image)
        Me.btnReprovar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnReprovar.Location = New System.Drawing.Point(354, 17)
        Me.btnReprovar.Name = "btnReprovar"
        Me.btnReprovar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnReprovar.Size = New System.Drawing.Size(91, 23)
        Me.btnReprovar.TabIndex = 2
        Me.btnReprovar.Text = "Reprovar"
        Me.btnReprovar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(451, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpManutencao)
        Me.pagDados.Controls.Add(Me.UiGroupBox2)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagLista"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Requisição de Manutenção"
        '
        'grpManutencao
        '
        Me.grpManutencao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpManutencao.BackColor = System.Drawing.Color.Transparent
        Me.grpManutencao.Controls.Add(Me.cboArea)
        Me.grpManutencao.Controls.Add(Me.lblArea)
        Me.grpManutencao.Controls.Add(Me.dtpDataNecessidade)
        Me.grpManutencao.Controls.Add(Me.cboManutencao)
        Me.grpManutencao.Controls.Add(Me.lblManutencao)
        Me.grpManutencao.Controls.Add(Me.lblJustificativa)
        Me.grpManutencao.Controls.Add(Me.lblComplemento)
        Me.grpManutencao.Controls.Add(Me.txtComplemento)
        Me.grpManutencao.Controls.Add(Me.lblDataNecessidade)
        Me.grpManutencao.Controls.Add(Me.txtJustificativa)
        Me.grpManutencao.Controls.Add(Me.btnCadastrarArea)
        Me.grpManutencao.Controls.Add(Me.btnCadastrarManutencao)
        Me.grpManutencao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpManutencao.Location = New System.Drawing.Point(8, 69)
        Me.grpManutencao.Name = "grpManutencao"
        Me.grpManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpManutencao.Size = New System.Drawing.Size(982, 144)
        Me.grpManutencao.TabIndex = 0
        Me.grpManutencao.VisualStyleManager = Me.vsmMain
        '
        'cboArea
        '
        Me.cboArea.AutoSize = False
        Me.cboArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboArea.Location = New System.Drawing.Point(9, 74)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboArea.Size = New System.Drawing.Size(388, 20)
        Me.cboArea.TabIndex = 9
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(25, 57)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(34, 14)
        Me.lblArea.TabIndex = 8
        Me.lblArea.Text = "Área:"
        '
        'dtpDataNecessidade
        '
        Me.dtpDataNecessidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataNecessidade.DropDownCalendar.Name = ""
        Me.dtpDataNecessidade.Location = New System.Drawing.Point(873, 34)
        Me.dtpDataNecessidade.Name = "dtpDataNecessidade"
        Me.dtpDataNecessidade.ShowCheckBox = True
        Me.dtpDataNecessidade.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataNecessidade.TabIndex = 6
        '
        'cboManutencao
        '
        Me.cboManutencao.AutoSize = False
        Me.cboManutencao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboManutencao.Location = New System.Drawing.Point(9, 34)
        Me.cboManutencao.Name = "cboManutencao"
        Me.cboManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboManutencao.Size = New System.Drawing.Size(388, 20)
        Me.cboManutencao.TabIndex = 2
        '
        'lblManutencao
        '
        Me.lblManutencao.AutoSize = True
        Me.lblManutencao.Location = New System.Drawing.Point(25, 17)
        Me.lblManutencao.Name = "lblManutencao"
        Me.lblManutencao.Size = New System.Drawing.Size(69, 14)
        Me.lblManutencao.TabIndex = 1
        Me.lblManutencao.Text = "Manutenção:"
        '
        'lblJustificativa
        '
        Me.lblJustificativa.AutoSize = True
        Me.lblJustificativa.Location = New System.Drawing.Point(400, 57)
        Me.lblJustificativa.Name = "lblJustificativa"
        Me.lblJustificativa.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativa.TabIndex = 10
        Me.lblJustificativa.Text = "Justificativa:"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(400, 17)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(74, 14)
        Me.lblComplemento.TabIndex = 3
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(403, 34)
        Me.txtComplemento.MaxLength = 100
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(464, 20)
        Me.txtComplemento.TabIndex = 4
        '
        'lblDataNecessidade
        '
        Me.lblDataNecessidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataNecessidade.AutoSize = True
        Me.lblDataNecessidade.Location = New System.Drawing.Point(870, 17)
        Me.lblDataNecessidade.Name = "lblDataNecessidade"
        Me.lblDataNecessidade.Size = New System.Drawing.Size(98, 14)
        Me.lblDataNecessidade.TabIndex = 5
        Me.lblDataNecessidade.Text = "Data Necessidade:"
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(403, 74)
        Me.txtJustificativa.MaxLength = 500
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(570, 60)
        Me.txtJustificativa.TabIndex = 11
        '
        'btnCadastrarArea
        '
        Me.btnCadastrarArea.FlatAppearance.BorderSize = 0
        Me.btnCadastrarArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarArea.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarArea.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarArea.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarArea.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarArea.Name = "btnCadastrarArea"
        Me.btnCadastrarArea.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarArea.TabIndex = 7
        Me.btnCadastrarArea.TabStop = False
        Me.btnCadastrarArea.UseVisualStyleBackColor = True
        '
        'btnCadastrarManutencao
        '
        Me.btnCadastrarManutencao.FlatAppearance.BorderSize = 0
        Me.btnCadastrarManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarManutencao.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarManutencao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarManutencao.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarManutencao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarManutencao.Name = "btnCadastrarManutencao"
        Me.btnCadastrarManutencao.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarManutencao.TabIndex = 0
        Me.btnCadastrarManutencao.TabStop = False
        Me.btnCadastrarManutencao.UseVisualStyleBackColor = True
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.txtAprovador)
        Me.UiGroupBox2.Controls.Add(Me.txtNumeroRequisicao)
        Me.UiGroupBox2.Controls.Add(Me.lblNumeroRequisicao)
        Me.UiGroupBox2.Controls.Add(Me.lblAprovador)
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(982, 63)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'txtAprovador
        '
        Me.txtAprovador.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAprovador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAprovador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtAprovador.Location = New System.Drawing.Point(130, 34)
        Me.txtAprovador.MaxLength = 0
        Me.txtAprovador.Name = "txtAprovador"
        Me.txtAprovador.ReadOnly = True
        Me.txtAprovador.Size = New System.Drawing.Size(631, 20)
        Me.txtAprovador.TabIndex = 3
        Me.txtAprovador.TabStop = False
        '
        'txtNumeroRequisicao
        '
        Me.txtNumeroRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroRequisicao.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicao.MaxLength = 20
        Me.txtNumeroRequisicao.Name = "txtNumeroRequisicao"
        Me.txtNumeroRequisicao.ReadOnly = True
        Me.txtNumeroRequisicao.Size = New System.Drawing.Size(115, 20)
        Me.txtNumeroRequisicao.TabIndex = 1
        Me.txtNumeroRequisicao.TabStop = False
        Me.txtNumeroRequisicao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicao.TabIndex = 0
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'lblAprovador
        '
        Me.lblAprovador.AutoSize = True
        Me.lblAprovador.Location = New System.Drawing.Point(127, 17)
        Me.lblAprovador.Name = "lblAprovador"
        Me.lblAprovador.Size = New System.Drawing.Size(62, 14)
        Me.lblAprovador.TabIndex = 2
        Me.lblAprovador.Text = "Aprovador:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVoltar)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(882, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(785, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrManRequisicaoAprovar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrManRequisicaoAprovar"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picReprovado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAprovado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAguardandoAprovacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpManutencao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpManutencao.ResumeLayout(False)
        Me.grpManutencao.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAprovador As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblManutencaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroRequisicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaAprovado As System.Windows.Forms.Label
    Friend WithEvents picAprovado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAguardandoAprovacao As System.Windows.Forms.Label
    Friend WithEvents picAguardandoAprovacao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaReprovado As System.Windows.Forms.Label
    Friend WithEvents picReprovado As System.Windows.Forms.PictureBox
    Private WithEvents btnReprovar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblRequisitante As System.Windows.Forms.Label
    Private WithEvents btnAprovar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAprovador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataRequisicaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataRequisicaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboRequisitanteFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents cboManutencaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpManutencao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboArea As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarArea As System.Windows.Forms.Button
    Friend WithEvents dtpDataNecessidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboManutencao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblManutencao As System.Windows.Forms.Label
    Friend WithEvents lblJustificativa As System.Windows.Forms.Label
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents txtComplemento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataNecessidade As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarManutencao As System.Windows.Forms.Button
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox

End Class
