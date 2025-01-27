<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmpRequisicaoAprovar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpRequisicaoAprovar))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim cboRequisitanteFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
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
        Me.lblLegendaAprovada = New System.Windows.Forms.Label()
        Me.picAprovado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAguardandoAprovacao = New System.Windows.Forms.Label()
        Me.picAguardandoAprovacao = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboRequisitanteFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataRequisicaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataRequisicaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblRequisitante = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
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
        Me.grpItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.btnQuantidadeAberto = New System.Windows.Forms.Button()
        Me.txtQuantidadeAberto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeAberto = New System.Windows.Forms.Label()
        Me.cboTipoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoItem = New System.Windows.Forms.Label()
        Me.txtMultiploCompra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMultiploCompra = New System.Windows.Forms.Label()
        Me.txtQuantidadeMinima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeMinima = New System.Windows.Forms.Label()
        Me.dtpDataNecessidadeItem = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboCodigoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoItem = New System.Windows.Forms.Label()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.btnCadastrarItem = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGastoItem = New System.Windows.Forms.Button()
        Me.lblJustificativaItem = New System.Windows.Forms.Label()
        Me.btnCadastrarContaContabilItem = New System.Windows.Forms.Button()
        Me.cboContaContabilItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaContabilItem = New System.Windows.Forms.Label()
        Me.lblCentroGastoItem = New System.Windows.Forms.Label()
        Me.cboCentroGastoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblComplementoItem = New System.Windows.Forms.Label()
        Me.txtComplementoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataNecessidadeItem = New System.Windows.Forms.Label()
        Me.lblUnidadeMedidaItem = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaItem = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidadeItem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeItem = New System.Windows.Forms.Label()
        Me.btnCadastrarUnidadeMedidaItem = New System.Windows.Forms.Button()
        Me.txtMarcaItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarcaItem = New System.Windows.Forms.Label()
        Me.txtDescricaoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoItem = New System.Windows.Forms.Label()
        Me.txtJustificativaItem = New Janus.Windows.GridEX.EditControls.EditBox()
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
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItem.SuspendLayout()
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
        Me.pagListagem.Text = "Aprovar / Reprovar - Requisição de Compra"
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
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
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
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
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
        Me.grdListagem.FrozenColumns = 4
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
        Me.grpLegenda.Controls.Add(Me.lblLegendaAprovada)
        Me.grpLegenda.Controls.Add(Me.picAprovado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoAprovacao)
        Me.grpLegenda.Controls.Add(Me.picAguardandoAprovacao)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(324, 51)
        Me.grpLegenda.TabIndex = 2
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaReprovado
        '
        Me.lblLegendaReprovado.AutoSize = True
        Me.lblLegendaReprovado.Location = New System.Drawing.Point(259, 21)
        Me.lblLegendaReprovado.Name = "lblLegendaReprovado"
        Me.lblLegendaReprovado.Size = New System.Drawing.Size(60, 14)
        Me.lblLegendaReprovado.TabIndex = 5
        Me.lblLegendaReprovado.Text = "Reprovado"
        '
        'picReprovado
        '
        Me.picReprovado.BackColor = System.Drawing.Color.Firebrick
        Me.picReprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picReprovado.Location = New System.Drawing.Point(240, 21)
        Me.picReprovado.Name = "picReprovado"
        Me.picReprovado.Size = New System.Drawing.Size(13, 14)
        Me.picReprovado.TabIndex = 18
        Me.picReprovado.TabStop = False
        '
        'lblLegendaAprovada
        '
        Me.lblLegendaAprovada.AutoSize = True
        Me.lblLegendaAprovada.Location = New System.Drawing.Point(176, 21)
        Me.lblLegendaAprovada.Name = "lblLegendaAprovada"
        Me.lblLegendaAprovada.Size = New System.Drawing.Size(55, 14)
        Me.lblLegendaAprovada.TabIndex = 2
        Me.lblLegendaAprovada.Text = "Aprovada"
        '
        'picAprovado
        '
        Me.picAprovado.BackColor = System.Drawing.Color.ForestGreen
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
        Me.grpFiltro.Controls.Add(Me.cboRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRequisitante)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtItemFiltro)
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
        'lblItemFiltro
        '
        Me.lblItemFiltro.AutoSize = True
        Me.lblItemFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblItemFiltro.Name = "lblItemFiltro"
        Me.lblItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblItemFiltro.TabIndex = 7
        Me.lblItemFiltro.Text = "Item:"
        '
        'txtItemFiltro
        '
        Me.txtItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtItemFiltro.MaxLength = 100
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.Size = New System.Drawing.Size(515, 20)
        Me.txtItemFiltro.TabIndex = 8
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
        Me.grpControle.Location = New System.Drawing.Point(341, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(649, 51)
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
        Me.btnAprovar.Location = New System.Drawing.Point(355, 17)
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
        Me.btnReprovar.Location = New System.Drawing.Point(452, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(549, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpItem)
        Me.pagDados.Controls.Add(Me.UiGroupBox2)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagLista"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Requisição de Compra"
        '
        'grpItem
        '
        Me.grpItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItem.BackColor = System.Drawing.Color.Transparent
        Me.grpItem.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpItem.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpItem.Controls.Add(Me.btnQuantidadeAberto)
        Me.grpItem.Controls.Add(Me.txtQuantidadeAberto)
        Me.grpItem.Controls.Add(Me.lblQuantidadeAberto)
        Me.grpItem.Controls.Add(Me.cboTipoItem)
        Me.grpItem.Controls.Add(Me.lblTipoItem)
        Me.grpItem.Controls.Add(Me.txtMultiploCompra)
        Me.grpItem.Controls.Add(Me.lblMultiploCompra)
        Me.grpItem.Controls.Add(Me.txtQuantidadeMinima)
        Me.grpItem.Controls.Add(Me.lblQuantidadeMinima)
        Me.grpItem.Controls.Add(Me.dtpDataNecessidadeItem)
        Me.grpItem.Controls.Add(Me.cboCodigoItem)
        Me.grpItem.Controls.Add(Me.lblCodigoItem)
        Me.grpItem.Controls.Add(Me.btnProcurarItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarCentroGastoItem)
        Me.grpItem.Controls.Add(Me.lblJustificativaItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarContaContabilItem)
        Me.grpItem.Controls.Add(Me.cboContaContabilItem)
        Me.grpItem.Controls.Add(Me.lblContaContabilItem)
        Me.grpItem.Controls.Add(Me.lblCentroGastoItem)
        Me.grpItem.Controls.Add(Me.cboCentroGastoItem)
        Me.grpItem.Controls.Add(Me.lblComplementoItem)
        Me.grpItem.Controls.Add(Me.txtComplementoItem)
        Me.grpItem.Controls.Add(Me.lblDataNecessidadeItem)
        Me.grpItem.Controls.Add(Me.lblUnidadeMedidaItem)
        Me.grpItem.Controls.Add(Me.cboUnidadeMedidaItem)
        Me.grpItem.Controls.Add(Me.txtQuantidadeItem)
        Me.grpItem.Controls.Add(Me.lblQuantidadeItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarUnidadeMedidaItem)
        Me.grpItem.Controls.Add(Me.txtMarcaItem)
        Me.grpItem.Controls.Add(Me.lblMarcaItem)
        Me.grpItem.Controls.Add(Me.txtDescricaoItem)
        Me.grpItem.Controls.Add(Me.lblDescricaoItem)
        Me.grpItem.Controls.Add(Me.txtJustificativaItem)
        Me.grpItem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpItem.Location = New System.Drawing.Point(8, 69)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpItem.Size = New System.Drawing.Size(982, 187)
        Me.grpItem.TabIndex = 1
        Me.grpItem.Text = "Lista de Item"
        Me.grpItem.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(317, 139)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 31
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(317, 99)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 27
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnQuantidadeAberto
        '
        Me.btnQuantidadeAberto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuantidadeAberto.FlatAppearance.BorderSize = 0
        Me.btnQuantidadeAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuantidadeAberto.Image = Global.INTERACTI.My.Resources.Resources.grid
        Me.btnQuantidadeAberto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnQuantidadeAberto.Location = New System.Drawing.Point(660, 59)
        Me.btnQuantidadeAberto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnQuantidadeAberto.Name = "btnQuantidadeAberto"
        Me.btnQuantidadeAberto.Size = New System.Drawing.Size(17, 16)
        SuperTipSettings1.HeaderText = "Quantidade em Aberto"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Σ Quantidade de Pedido de Compra em Trânsito."
        Me.jstTip.SetSuperTip(Me.btnQuantidadeAberto, SuperTipSettings1)
        Me.btnQuantidadeAberto.TabIndex = 18
        Me.btnQuantidadeAberto.TabStop = False
        Me.btnQuantidadeAberto.UseVisualStyleBackColor = True
        '
        'txtQuantidadeAberto
        '
        Me.txtQuantidadeAberto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeAberto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeAberto.DecimalDigits = 4
        Me.txtQuantidadeAberto.Location = New System.Drawing.Point(661, 77)
        Me.txtQuantidadeAberto.MaxLength = 0
        Me.txtQuantidadeAberto.Name = "txtQuantidadeAberto"
        Me.txtQuantidadeAberto.ReadOnly = True
        Me.txtQuantidadeAberto.Size = New System.Drawing.Size(100, 20)
        SuperTipSettings2.HeaderText = "Quantidade em Aberto"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Σ Quantidade de Pedido de Compra em Trânsito."
        Me.jstTip.SetSuperTip(Me.txtQuantidadeAberto, SuperTipSettings2)
        Me.txtQuantidadeAberto.TabIndex = 20
        Me.txtQuantidadeAberto.TabStop = False
        Me.txtQuantidadeAberto.Text = "0,0000"
        Me.txtQuantidadeAberto.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeAberto
        '
        Me.lblQuantidadeAberto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeAberto.AutoSize = True
        Me.lblQuantidadeAberto.Location = New System.Drawing.Point(680, 60)
        Me.lblQuantidadeAberto.Name = "lblQuantidadeAberto"
        Me.lblQuantidadeAberto.Size = New System.Drawing.Size(71, 14)
        SuperTipSettings3.HeaderText = "Quantidade em Aberto"
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Σ Quantidade de Pedido de Compra em Trânsito."
        Me.jstTip.SetSuperTip(Me.lblQuantidadeAberto, SuperTipSettings3)
        Me.lblQuantidadeAberto.TabIndex = 19
        Me.lblQuantidadeAberto.Text = "Qtde. Aberto:"
        '
        'cboTipoItem
        '
        Me.cboTipoItem.AutoSize = False
        Me.cboTipoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboTipoItem.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboTipoItem.Location = New System.Drawing.Point(9, 37)
        Me.cboTipoItem.Name = "cboTipoItem"
        Me.cboTipoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoItem.Size = New System.Drawing.Size(132, 20)
        Me.cboTipoItem.TabIndex = 1
        '
        'lblTipoItem
        '
        Me.lblTipoItem.AutoSize = True
        Me.lblTipoItem.Location = New System.Drawing.Point(6, 20)
        Me.lblTipoItem.Name = "lblTipoItem"
        Me.lblTipoItem.Size = New System.Drawing.Size(67, 14)
        Me.lblTipoItem.TabIndex = 0
        Me.lblTipoItem.Text = "Tipo de Item:"
        '
        'txtMultiploCompra
        '
        Me.txtMultiploCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMultiploCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMultiploCompra.DecimalDigits = 4
        Me.txtMultiploCompra.Location = New System.Drawing.Point(873, 37)
        Me.txtMultiploCompra.MaxLength = 0
        Me.txtMultiploCompra.Name = "txtMultiploCompra"
        Me.txtMultiploCompra.ReadOnly = True
        Me.txtMultiploCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtMultiploCompra.TabIndex = 11
        Me.txtMultiploCompra.TabStop = False
        Me.txtMultiploCompra.Text = "0,0000"
        Me.txtMultiploCompra.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblMultiploCompra
        '
        Me.lblMultiploCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMultiploCompra.AutoSize = True
        Me.lblMultiploCompra.Location = New System.Drawing.Point(870, 20)
        Me.lblMultiploCompra.Name = "lblMultiploCompra"
        Me.lblMultiploCompra.Size = New System.Drawing.Size(91, 14)
        Me.lblMultiploCompra.TabIndex = 10
        Me.lblMultiploCompra.Text = "Múltiplo Compras:"
        '
        'txtQuantidadeMinima
        '
        Me.txtQuantidadeMinima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeMinima.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeMinima.DecimalDigits = 4
        Me.txtQuantidadeMinima.Location = New System.Drawing.Point(767, 37)
        Me.txtQuantidadeMinima.MaxLength = 0
        Me.txtQuantidadeMinima.Name = "txtQuantidadeMinima"
        Me.txtQuantidadeMinima.ReadOnly = True
        Me.txtQuantidadeMinima.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeMinima.TabIndex = 9
        Me.txtQuantidadeMinima.TabStop = False
        Me.txtQuantidadeMinima.Text = "0,0000"
        Me.txtQuantidadeMinima.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeMinima
        '
        Me.lblQuantidadeMinima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeMinima.AutoSize = True
        Me.lblQuantidadeMinima.Location = New System.Drawing.Point(764, 20)
        Me.lblQuantidadeMinima.Name = "lblQuantidadeMinima"
        Me.lblQuantidadeMinima.Size = New System.Drawing.Size(71, 14)
        Me.lblQuantidadeMinima.TabIndex = 8
        Me.lblQuantidadeMinima.Text = "Qtde. Mínima:"
        '
        'dtpDataNecessidadeItem
        '
        Me.dtpDataNecessidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataNecessidadeItem.DropDownCalendar.Name = ""
        Me.dtpDataNecessidadeItem.Location = New System.Drawing.Point(873, 77)
        Me.dtpDataNecessidadeItem.Name = "dtpDataNecessidadeItem"
        Me.dtpDataNecessidadeItem.ShowCheckBox = True
        Me.dtpDataNecessidadeItem.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataNecessidadeItem.TabIndex = 24
        '
        'cboCodigoItem
        '
        Me.cboCodigoItem.AutoSize = False
        Me.cboCodigoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoItem.Location = New System.Drawing.Point(147, 37)
        Me.cboCodigoItem.Name = "cboCodigoItem"
        Me.cboCodigoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoItem.Size = New System.Drawing.Size(187, 20)
        Me.cboCodigoItem.TabIndex = 5
        '
        'lblCodigoItem
        '
        Me.lblCodigoItem.AutoSize = True
        Me.lblCodigoItem.Location = New System.Drawing.Point(163, 20)
        Me.lblCodigoItem.Name = "lblCodigoItem"
        Me.lblCodigoItem.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoItem.TabIndex = 3
        Me.lblCodigoItem.Text = "Código:"
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(317, 18)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 4
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarItem
        '
        Me.btnCadastrarItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarItem.Location = New System.Drawing.Point(147, 21)
        Me.btnCadastrarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarItem.Name = "btnCadastrarItem"
        Me.btnCadastrarItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarItem.TabIndex = 2
        Me.btnCadastrarItem.TabStop = False
        Me.btnCadastrarItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGastoItem
        '
        Me.btnCadastrarCentroGastoItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGastoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGastoItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGastoItem.Location = New System.Drawing.Point(9, 101)
        Me.btnCadastrarCentroGastoItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGastoItem.Name = "btnCadastrarCentroGastoItem"
        Me.btnCadastrarCentroGastoItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGastoItem.TabIndex = 25
        Me.btnCadastrarCentroGastoItem.TabStop = False
        Me.btnCadastrarCentroGastoItem.UseVisualStyleBackColor = True
        '
        'lblJustificativaItem
        '
        Me.lblJustificativaItem.AutoSize = True
        Me.lblJustificativaItem.Location = New System.Drawing.Point(337, 100)
        Me.lblJustificativaItem.Name = "lblJustificativaItem"
        Me.lblJustificativaItem.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativaItem.TabIndex = 33
        Me.lblJustificativaItem.Text = "Justificativa:"
        '
        'btnCadastrarContaContabilItem
        '
        Me.btnCadastrarContaContabilItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabilItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabilItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabilItem.Location = New System.Drawing.Point(9, 141)
        Me.btnCadastrarContaContabilItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabilItem.Name = "btnCadastrarContaContabilItem"
        Me.btnCadastrarContaContabilItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabilItem.TabIndex = 29
        Me.btnCadastrarContaContabilItem.TabStop = False
        Me.btnCadastrarContaContabilItem.UseVisualStyleBackColor = True
        '
        'cboContaContabilItem
        '
        Me.cboContaContabilItem.AutoSize = False
        Me.cboContaContabilItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabilItem.Location = New System.Drawing.Point(9, 157)
        Me.cboContaContabilItem.Name = "cboContaContabilItem"
        Me.cboContaContabilItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabilItem.Size = New System.Drawing.Size(325, 20)
        Me.cboContaContabilItem.TabIndex = 32
        '
        'lblContaContabilItem
        '
        Me.lblContaContabilItem.AutoSize = True
        Me.lblContaContabilItem.Location = New System.Drawing.Point(25, 140)
        Me.lblContaContabilItem.Name = "lblContaContabilItem"
        Me.lblContaContabilItem.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabilItem.TabIndex = 30
        Me.lblContaContabilItem.Text = "Conta Contábil:"
        '
        'lblCentroGastoItem
        '
        Me.lblCentroGastoItem.AutoSize = True
        Me.lblCentroGastoItem.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroGastoItem.Location = New System.Drawing.Point(25, 100)
        Me.lblCentroGastoItem.Name = "lblCentroGastoItem"
        Me.lblCentroGastoItem.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGastoItem.TabIndex = 26
        Me.lblCentroGastoItem.Text = "Centro de Gasto:"
        '
        'cboCentroGastoItem
        '
        Me.cboCentroGastoItem.AutoSize = False
        Me.cboCentroGastoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboCentroGastoItem.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboCentroGastoItem.Location = New System.Drawing.Point(9, 117)
        Me.cboCentroGastoItem.Name = "cboCentroGastoItem"
        Me.cboCentroGastoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGastoItem.Size = New System.Drawing.Size(325, 20)
        Me.cboCentroGastoItem.TabIndex = 28
        '
        'lblComplementoItem
        '
        Me.lblComplementoItem.AutoSize = True
        Me.lblComplementoItem.Location = New System.Drawing.Point(6, 60)
        Me.lblComplementoItem.Name = "lblComplementoItem"
        Me.lblComplementoItem.Size = New System.Drawing.Size(74, 14)
        Me.lblComplementoItem.TabIndex = 12
        Me.lblComplementoItem.Text = "Complemento:"
        '
        'txtComplementoItem
        '
        Me.txtComplementoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoItem.Location = New System.Drawing.Point(9, 77)
        Me.txtComplementoItem.MaxLength = 100
        Me.txtComplementoItem.Name = "txtComplementoItem"
        Me.txtComplementoItem.Size = New System.Drawing.Size(325, 20)
        Me.txtComplementoItem.TabIndex = 13
        '
        'lblDataNecessidadeItem
        '
        Me.lblDataNecessidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataNecessidadeItem.AutoSize = True
        Me.lblDataNecessidadeItem.Location = New System.Drawing.Point(870, 60)
        Me.lblDataNecessidadeItem.Name = "lblDataNecessidadeItem"
        Me.lblDataNecessidadeItem.Size = New System.Drawing.Size(98, 14)
        Me.lblDataNecessidadeItem.TabIndex = 23
        Me.lblDataNecessidadeItem.Text = "Data Necessidade:"
        '
        'lblUnidadeMedidaItem
        '
        Me.lblUnidadeMedidaItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnidadeMedidaItem.AutoSize = True
        Me.lblUnidadeMedidaItem.Location = New System.Drawing.Point(783, 60)
        Me.lblUnidadeMedidaItem.Name = "lblUnidadeMedidaItem"
        Me.lblUnidadeMedidaItem.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedidaItem.TabIndex = 21
        Me.lblUnidadeMedidaItem.Text = "Und. Med.:"
        '
        'cboUnidadeMedidaItem
        '
        Me.cboUnidadeMedidaItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUnidadeMedidaItem.AutoSize = False
        Me.cboUnidadeMedidaItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaItem.Location = New System.Drawing.Point(767, 77)
        Me.cboUnidadeMedidaItem.Name = "cboUnidadeMedidaItem"
        Me.cboUnidadeMedidaItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaItem.Size = New System.Drawing.Size(100, 20)
        Me.cboUnidadeMedidaItem.TabIndex = 22
        '
        'txtQuantidadeItem
        '
        Me.txtQuantidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeItem.DecimalDigits = 4
        Me.txtQuantidadeItem.Location = New System.Drawing.Point(555, 77)
        Me.txtQuantidadeItem.MaxLength = 0
        Me.txtQuantidadeItem.Name = "txtQuantidadeItem"
        Me.txtQuantidadeItem.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeItem.TabIndex = 17
        Me.txtQuantidadeItem.Text = "0,0000"
        Me.txtQuantidadeItem.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeItem
        '
        Me.lblQuantidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeItem.AutoSize = True
        Me.lblQuantidadeItem.Location = New System.Drawing.Point(552, 60)
        Me.lblQuantidadeItem.Name = "lblQuantidadeItem"
        Me.lblQuantidadeItem.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeItem.TabIndex = 16
        Me.lblQuantidadeItem.Text = "Quantidade:"
        '
        'btnCadastrarUnidadeMedidaItem
        '
        Me.btnCadastrarUnidadeMedidaItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarUnidadeMedidaItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedidaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedidaItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedidaItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedidaItem.Location = New System.Drawing.Point(767, 61)
        Me.btnCadastrarUnidadeMedidaItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedidaItem.Name = "btnCadastrarUnidadeMedidaItem"
        Me.btnCadastrarUnidadeMedidaItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedidaItem.TabIndex = 21
        Me.btnCadastrarUnidadeMedidaItem.TabStop = False
        Me.btnCadastrarUnidadeMedidaItem.UseVisualStyleBackColor = True
        '
        'txtMarcaItem
        '
        Me.txtMarcaItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarcaItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaItem.Location = New System.Drawing.Point(340, 77)
        Me.txtMarcaItem.MaxLength = 100
        Me.txtMarcaItem.Name = "txtMarcaItem"
        Me.txtMarcaItem.Size = New System.Drawing.Size(209, 20)
        Me.txtMarcaItem.TabIndex = 15
        '
        'lblMarcaItem
        '
        Me.lblMarcaItem.AutoSize = True
        Me.lblMarcaItem.Location = New System.Drawing.Point(337, 60)
        Me.lblMarcaItem.Name = "lblMarcaItem"
        Me.lblMarcaItem.Size = New System.Drawing.Size(40, 14)
        Me.lblMarcaItem.TabIndex = 14
        Me.lblMarcaItem.Text = "Marca:"
        '
        'txtDescricaoItem
        '
        Me.txtDescricaoItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoItem.Location = New System.Drawing.Point(340, 37)
        Me.txtDescricaoItem.MaxLength = 120
        Me.txtDescricaoItem.Name = "txtDescricaoItem"
        Me.txtDescricaoItem.ReadOnly = True
        Me.txtDescricaoItem.Size = New System.Drawing.Size(421, 20)
        Me.txtDescricaoItem.TabIndex = 7
        Me.txtDescricaoItem.TabStop = False
        '
        'lblDescricaoItem
        '
        Me.lblDescricaoItem.AutoSize = True
        Me.lblDescricaoItem.Location = New System.Drawing.Point(337, 20)
        Me.lblDescricaoItem.Name = "lblDescricaoItem"
        Me.lblDescricaoItem.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoItem.TabIndex = 6
        Me.lblDescricaoItem.Text = "Descrição:"
        '
        'txtJustificativaItem
        '
        Me.txtJustificativaItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativaItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativaItem.Location = New System.Drawing.Point(340, 117)
        Me.txtJustificativaItem.MaxLength = 500
        Me.txtJustificativaItem.Multiline = True
        Me.txtJustificativaItem.Name = "txtJustificativaItem"
        Me.txtJustificativaItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativaItem.Size = New System.Drawing.Size(633, 60)
        Me.txtJustificativaItem.TabIndex = 34
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
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
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
        'usrCmpRequisicaoAprovar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpRequisicaoAprovar"
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
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
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
    Friend WithEvents lblItemFiltro As System.Windows.Forms.Label
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroRequisicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaAprovada As System.Windows.Forms.Label
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
    Friend WithEvents grpItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboTipoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoItem As System.Windows.Forms.Label
    Friend WithEvents txtMultiploCompra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMultiploCompra As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeMinima As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeMinima As System.Windows.Forms.Label
    Friend WithEvents dtpDataNecessidadeItem As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboCodigoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoItem As System.Windows.Forms.Label
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarItem As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGastoItem As System.Windows.Forms.Button
    Friend WithEvents lblJustificativaItem As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarContaContabilItem As System.Windows.Forms.Button
    Friend WithEvents cboContaContabilItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaContabilItem As System.Windows.Forms.Label
    Friend WithEvents lblCentroGastoItem As System.Windows.Forms.Label
    Friend WithEvents cboCentroGastoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblComplementoItem As System.Windows.Forms.Label
    Friend WithEvents txtComplementoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataNecessidadeItem As System.Windows.Forms.Label
    Friend WithEvents lblUnidadeMedidaItem As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedidaItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtQuantidadeItem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeItem As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarUnidadeMedidaItem As System.Windows.Forms.Button
    Friend WithEvents txtMarcaItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarcaItem As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoItem As System.Windows.Forms.Label
    Friend WithEvents txtJustificativaItem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents btnQuantidadeAberto As System.Windows.Forms.Button
    Friend WithEvents txtQuantidadeAberto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblQuantidadeAberto As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button

End Class
