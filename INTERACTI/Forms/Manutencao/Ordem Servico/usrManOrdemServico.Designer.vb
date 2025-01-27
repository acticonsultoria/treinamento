<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrManOrdemServico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrManOrdemServico))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdApontamento_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaConcluido = New System.Windows.Forms.Label()
        Me.picLegendaConcluido = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCancelado = New System.Windows.Forms.Label()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEmAndamento = New System.Windows.Forms.Label()
        Me.picLegendaEmAndamento = New System.Windows.Forms.PictureBox()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboManutencaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataConclusaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataConclusaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataConclusaoFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblManutencaoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboTipoManutencaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoManutencaoFiltro = New System.Windows.Forms.Label()
        Me.lblNumeroRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.dtpDataOrdemServicoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataOrdemServicoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroOrdemServicoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrdemServicoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataOrdemServicoFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFinalizar = New Janus.Windows.EditControls.UIButton()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoManutencao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoManutencao = New System.Windows.Forms.Label()
        Me.cboNumeroRequisicao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.dtpDataOrdemServico = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboManutencao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblManutencao = New System.Windows.Forms.Label()
        Me.lblDataOrdemServico = New System.Windows.Forms.Label()
        Me.txtNumeroOrdemServico = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrdemServico = New System.Windows.Forms.Label()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnInserirApontamento = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirApontamento = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.pagApontamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridApontamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridApontamento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridApontamento = New System.Windows.Forms.Button()
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaEmAndamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagProduto.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagApontamento.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpDadosVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosVenda.SuspendLayout()
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
        Me.tabMain.FocusOnClick = False
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
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Ordem de Serviço"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaConcluido)
        Me.grpLegenda.Controls.Add(Me.picLegendaConcluido)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEmAndamento)
        Me.grpLegenda.Controls.Add(Me.picLegendaEmAndamento)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(271, 51)
        Me.grpLegenda.TabIndex = 8
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaConcluido
        '
        Me.lblLegendaConcluido.AutoSize = True
        Me.lblLegendaConcluido.Location = New System.Drawing.Point(131, 21)
        Me.lblLegendaConcluido.Name = "lblLegendaConcluido"
        Me.lblLegendaConcluido.Size = New System.Drawing.Size(54, 14)
        Me.lblLegendaConcluido.TabIndex = 17
        Me.lblLegendaConcluido.Text = "Concluído"
        '
        'picLegendaConcluido
        '
        Me.picLegendaConcluido.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaConcluido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaConcluido.Location = New System.Drawing.Point(112, 21)
        Me.picLegendaConcluido.Name = "picLegendaConcluido"
        Me.picLegendaConcluido.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaConcluido.TabIndex = 18
        Me.picLegendaConcluido.TabStop = False
        '
        'lblLegendaCancelado
        '
        Me.lblLegendaCancelado.AutoSize = True
        Me.lblLegendaCancelado.Location = New System.Drawing.Point(210, 21)
        Me.lblLegendaCancelado.Name = "lblLegendaCancelado"
        Me.lblLegendaCancelado.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelado.TabIndex = 1
        Me.lblLegendaCancelado.Text = "Cancelado"
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(191, 21)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelado.TabIndex = 16
        Me.picLegendaCancelado.TabStop = False
        '
        'lblLegendaEmAndamento
        '
        Me.lblLegendaEmAndamento.AutoSize = True
        Me.lblLegendaEmAndamento.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaEmAndamento.Name = "lblLegendaEmAndamento"
        Me.lblLegendaEmAndamento.Size = New System.Drawing.Size(78, 14)
        Me.lblLegendaEmAndamento.TabIndex = 0
        Me.lblLegendaEmAndamento.Text = "Em Andamento"
        '
        'picLegendaEmAndamento
        '
        Me.picLegendaEmAndamento.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaEmAndamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEmAndamento.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaEmAndamento.Name = "picLegendaEmAndamento"
        Me.picLegendaEmAndamento.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEmAndamento.TabIndex = 4
        Me.picLegendaEmAndamento.TabStop = False
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
        Me.btnExcelGrid.TabIndex = 4
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
        Me.btnAgruparGrid.TabIndex = 3
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
        Me.btnConfigurarGrid.TabIndex = 2
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
        Me.grdListagem.ColumnAutoResize = True
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
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboManutencaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataConclusaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataConclusaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataConclusaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblManutencaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoManutencaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoManutencaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataOrdemServicoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataOrdemServicoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroOrdemServicoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroOrdemServicoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataOrdemServicoFiltro)
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
        Me.cboManutencaoFiltro.Size = New System.Drawing.Size(555, 20)
        Me.cboManutencaoFiltro.TabIndex = 13
        '
        'dtpDataConclusaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataConclusaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataConclusaoInicioFiltro.Location = New System.Drawing.Point(570, 34)
        Me.dtpDataConclusaoInicioFiltro.Name = "dtpDataConclusaoInicioFiltro"
        Me.dtpDataConclusaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataConclusaoInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataConclusaoInicioFiltro.TabIndex = 10
        Me.dtpDataConclusaoInicioFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'dtpDataConclusaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataConclusaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataConclusaoTerminoFiltro.Location = New System.Drawing.Point(676, 34)
        Me.dtpDataConclusaoTerminoFiltro.Name = "dtpDataConclusaoTerminoFiltro"
        Me.dtpDataConclusaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataConclusaoTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataConclusaoTerminoFiltro.TabIndex = 11
        Me.dtpDataConclusaoTerminoFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataConclusaoFiltro
        '
        Me.lblDataConclusaoFiltro.AutoSize = True
        Me.lblDataConclusaoFiltro.Location = New System.Drawing.Point(567, 17)
        Me.lblDataConclusaoFiltro.Name = "lblDataConclusaoFiltro"
        Me.lblDataConclusaoFiltro.Size = New System.Drawing.Size(86, 14)
        Me.lblDataConclusaoFiltro.TabIndex = 9
        Me.lblDataConclusaoFiltro.Text = "Data Conclusão:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AutoSize = False
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusFiltro.Location = New System.Drawing.Point(570, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusFiltro.Size = New System.Drawing.Size(206, 20)
        Me.cboStatusFiltro.TabIndex = 15
        '
        'lblManutencaoFiltro
        '
        Me.lblManutencaoFiltro.AutoSize = True
        Me.lblManutencaoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblManutencaoFiltro.Name = "lblManutencaoFiltro"
        Me.lblManutencaoFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblManutencaoFiltro.TabIndex = 12
        Me.lblManutencaoFiltro.Text = "Manutenção:"
        '
        'txtNumeroRequisicaoFiltro
        '
        Me.txtNumeroRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicaoFiltro.Location = New System.Drawing.Point(464, 34)
        Me.txtNumeroRequisicaoFiltro.MaxLength = 20
        Me.txtNumeroRequisicaoFiltro.Name = "txtNumeroRequisicaoFiltro"
        Me.txtNumeroRequisicaoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroRequisicaoFiltro.TabIndex = 8
        '
        'cboTipoManutencaoFiltro
        '
        Me.cboTipoManutencaoFiltro.AutoSize = False
        Me.cboTipoManutencaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoManutencaoFiltro.Location = New System.Drawing.Point(327, 34)
        Me.cboTipoManutencaoFiltro.Name = "cboTipoManutencaoFiltro"
        Me.cboTipoManutencaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoManutencaoFiltro.Size = New System.Drawing.Size(131, 20)
        Me.cboTipoManutencaoFiltro.TabIndex = 6
        '
        'lblTipoManutencaoFiltro
        '
        Me.lblTipoManutencaoFiltro.AutoSize = True
        Me.lblTipoManutencaoFiltro.Location = New System.Drawing.Point(324, 17)
        Me.lblTipoManutencaoFiltro.Name = "lblTipoManutencaoFiltro"
        Me.lblTipoManutencaoFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblTipoManutencaoFiltro.TabIndex = 5
        Me.lblTipoManutencaoFiltro.Text = "Tipo de Manutenção:"
        '
        'lblNumeroRequisicaoFiltro
        '
        Me.lblNumeroRequisicaoFiltro.AutoSize = True
        Me.lblNumeroRequisicaoFiltro.Location = New System.Drawing.Point(461, 17)
        Me.lblNumeroRequisicaoFiltro.Name = "lblNumeroRequisicaoFiltro"
        Me.lblNumeroRequisicaoFiltro.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicaoFiltro.TabIndex = 7
        Me.lblNumeroRequisicaoFiltro.Text = "Nº Requisição:"
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(567, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 14
        Me.lblStatusFiltro.Text = "Status:"
        '
        'dtpDataOrdemServicoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataOrdemServicoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOrdemServicoInicioFiltro.Location = New System.Drawing.Point(115, 34)
        Me.dtpDataOrdemServicoInicioFiltro.Name = "dtpDataOrdemServicoInicioFiltro"
        Me.dtpDataOrdemServicoInicioFiltro.ShowCheckBox = True
        Me.dtpDataOrdemServicoInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataOrdemServicoInicioFiltro.TabIndex = 3
        Me.dtpDataOrdemServicoInicioFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'dtpDataOrdemServicoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataOrdemServicoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOrdemServicoTerminoFiltro.Location = New System.Drawing.Point(221, 34)
        Me.dtpDataOrdemServicoTerminoFiltro.Name = "dtpDataOrdemServicoTerminoFiltro"
        Me.dtpDataOrdemServicoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataOrdemServicoTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataOrdemServicoTerminoFiltro.TabIndex = 4
        Me.dtpDataOrdemServicoTerminoFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'txtNumeroOrdemServicoFiltro
        '
        Me.txtNumeroOrdemServicoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrdemServicoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrdemServicoFiltro.MaxLength = 20
        Me.txtNumeroOrdemServicoFiltro.Name = "txtNumeroOrdemServicoFiltro"
        Me.txtNumeroOrdemServicoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroOrdemServicoFiltro.TabIndex = 1
        '
        'lblNumeroOrdemServicoFiltro
        '
        Me.lblNumeroOrdemServicoFiltro.AutoSize = True
        Me.lblNumeroOrdemServicoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrdemServicoFiltro.Name = "lblNumeroOrdemServicoFiltro"
        Me.lblNumeroOrdemServicoFiltro.Size = New System.Drawing.Size(97, 14)
        Me.lblNumeroOrdemServicoFiltro.TabIndex = 0
        Me.lblNumeroOrdemServicoFiltro.Text = "Nº Ordem Serviço:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 16
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataOrdemServicoFiltro
        '
        Me.lblDataOrdemServicoFiltro.AutoSize = True
        Me.lblDataOrdemServicoFiltro.Location = New System.Drawing.Point(112, 17)
        Me.lblDataOrdemServicoFiltro.Name = "lblDataOrdemServicoFiltro"
        Me.lblDataOrdemServicoFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblDataOrdemServicoFiltro.TabIndex = 2
        Me.lblDataOrdemServicoFiltro.Text = "Data Abertura:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnFinalizar)
        Me.grpControle.Controls.Add(Me.btnCancelar)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Controls.Add(Me.btnNovo)
        Me.grpControle.Location = New System.Drawing.Point(288, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(702, 51)
        Me.grpControle.TabIndex = 6
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizar.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnFinalizar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFinalizar.Location = New System.Drawing.Point(408, 17)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFinalizar.Size = New System.Drawing.Size(91, 23)
        Me.btnFinalizar.TabIndex = 2
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(311, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(505, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(602, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(214, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpInformacoes)
        Me.pagDados.Controls.Add(Me.grdControlesEdicao)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Ordem de Serviço"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.cboTipoManutencao)
        Me.grpInformacoes.Controls.Add(Me.lblTipoManutencao)
        Me.grpInformacoes.Controls.Add(Me.cboNumeroRequisicao)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpInformacoes.Controls.Add(Me.dtpDataOrdemServico)
        Me.grpInformacoes.Controls.Add(Me.cboManutencao)
        Me.grpInformacoes.Controls.Add(Me.lblManutencao)
        Me.grpInformacoes.Controls.Add(Me.lblDataOrdemServico)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroOrdemServico)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroOrdemServico)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(982, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'cboTipoManutencao
        '
        Me.cboTipoManutencao.AutoSize = False
        Me.cboTipoManutencao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoManutencao.Location = New System.Drawing.Point(211, 34)
        Me.cboTipoManutencao.Name = "cboTipoManutencao"
        Me.cboTipoManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoManutencao.Size = New System.Drawing.Size(131, 20)
        Me.cboTipoManutencao.TabIndex = 5
        '
        'lblTipoManutencao
        '
        Me.lblTipoManutencao.AutoSize = True
        Me.lblTipoManutencao.Location = New System.Drawing.Point(208, 17)
        Me.lblTipoManutencao.Name = "lblTipoManutencao"
        Me.lblTipoManutencao.Size = New System.Drawing.Size(107, 14)
        Me.lblTipoManutencao.TabIndex = 4
        Me.lblTipoManutencao.Text = "Tipo de Manutenção:"
        '
        'cboNumeroRequisicao
        '
        Me.cboNumeroRequisicao.AutoSize = False
        Me.cboNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroRequisicao.Location = New System.Drawing.Point(348, 34)
        Me.cboNumeroRequisicao.Name = "cboNumeroRequisicao"
        Me.cboNumeroRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroRequisicao.Size = New System.Drawing.Size(99, 20)
        Me.cboNumeroRequisicao.TabIndex = 7
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(345, 17)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicao.TabIndex = 6
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'dtpDataOrdemServico
        '
        '
        '
        '
        Me.dtpDataOrdemServico.DropDownCalendar.Name = ""
        Me.dtpDataOrdemServico.Location = New System.Drawing.Point(114, 34)
        Me.dtpDataOrdemServico.Name = "dtpDataOrdemServico"
        Me.dtpDataOrdemServico.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataOrdemServico.TabIndex = 3
        Me.dtpDataOrdemServico.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'cboManutencao
        '
        Me.cboManutencao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboManutencao.AutoSize = False
        Me.cboManutencao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboManutencao.Location = New System.Drawing.Point(453, 34)
        Me.cboManutencao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboManutencao.Name = "cboManutencao"
        Me.cboManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboManutencao.Size = New System.Drawing.Size(520, 20)
        Me.cboManutencao.TabIndex = 9
        '
        'lblManutencao
        '
        Me.lblManutencao.AutoSize = True
        Me.lblManutencao.Location = New System.Drawing.Point(450, 17)
        Me.lblManutencao.Name = "lblManutencao"
        Me.lblManutencao.Size = New System.Drawing.Size(69, 14)
        Me.lblManutencao.TabIndex = 8
        Me.lblManutencao.Text = "Manutenção:"
        '
        'lblDataOrdemServico
        '
        Me.lblDataOrdemServico.AutoSize = True
        Me.lblDataOrdemServico.Location = New System.Drawing.Point(111, 17)
        Me.lblDataOrdemServico.Name = "lblDataOrdemServico"
        Me.lblDataOrdemServico.Size = New System.Drawing.Size(29, 14)
        Me.lblDataOrdemServico.TabIndex = 2
        Me.lblDataOrdemServico.Text = "Data"
        '
        'txtNumeroOrdemServico
        '
        Me.txtNumeroOrdemServico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroOrdemServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrdemServico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroOrdemServico.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrdemServico.MaxLength = 20
        Me.txtNumeroOrdemServico.Name = "txtNumeroOrdemServico"
        Me.txtNumeroOrdemServico.ReadOnly = True
        Me.txtNumeroOrdemServico.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroOrdemServico.TabIndex = 1
        Me.txtNumeroOrdemServico.TabStop = False
        Me.txtNumeroOrdemServico.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroOrdemServico
        '
        Me.lblNumeroOrdemServico.AutoSize = True
        Me.lblNumeroOrdemServico.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrdemServico.Name = "lblNumeroOrdemServico"
        Me.lblNumeroOrdemServico.Size = New System.Drawing.Size(97, 14)
        Me.lblNumeroOrdemServico.TabIndex = 0
        Me.lblNumeroOrdemServico.Text = "Nº Ordem Serviço:"
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnInserirApontamento)
        Me.grdControlesEdicao.Controls.Add(Me.btnExcluirApontamento)
        Me.grdControlesEdicao.Controls.Add(Me.btnImprimir)
        Me.grdControlesEdicao.Controls.Add(Me.btnNovo1)
        Me.grdControlesEdicao.Controls.Add(Me.btnVoltar)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(8, 483)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(982, 51)
        Me.grdControlesEdicao.TabIndex = 2
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnInserirApontamento
        '
        Me.btnInserirApontamento.Image = Global.INTERACTI.My.Resources.novo
        Me.btnInserirApontamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirApontamento.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnInserirApontamento.Location = New System.Drawing.Point(9, 17)
        Me.btnInserirApontamento.Name = "btnInserirApontamento"
        Me.btnInserirApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirApontamento.Size = New System.Drawing.Size(150, 23)
        Me.btnInserirApontamento.TabIndex = 0
        Me.btnInserirApontamento.Text = "Novo Apontamento"
        Me.btnInserirApontamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirApontamento
        '
        Me.btnExcluirApontamento.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirApontamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirApontamento.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirApontamento.Location = New System.Drawing.Point(165, 17)
        Me.btnExcluirApontamento.Name = "btnExcluirApontamento"
        Me.btnExcluirApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirApontamento.Size = New System.Drawing.Size(150, 23)
        Me.btnExcluirApontamento.TabIndex = 1
        Me.btnExcluirApontamento.Text = "Excluir Apontamento"
        Me.btnExcluirApontamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(785, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(591, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 2
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(882, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 5
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(688, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(8, 73)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(982, 407)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagProduto, Me.pagApontamento, Me.pagDadosGerais})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagProduto
        '
        Me.pagProduto.Controls.Add(Me.btnExcelGridProduto)
        Me.pagProduto.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagProduto.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagProduto.Controls.Add(Me.grdProduto)
        Me.pagProduto.Key = "pagProduto"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Size = New System.Drawing.Size(980, 384)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Produtos"
        '
        'btnExcelGridProduto
        '
        Me.btnExcelGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridProduto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridProduto.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridProduto.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridProduto.Name = "btnExcelGridProduto"
        Me.btnExcelGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridProduto.TabIndex = 3
        Me.btnExcelGridProduto.TabStop = False
        Me.btnExcelGridProduto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridProduto
        '
        Me.btnAgruparGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridProduto.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridProduto.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProduto.Name = "btnAgruparGridProduto"
        Me.btnAgruparGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridProduto.TabIndex = 2
        Me.btnAgruparGridProduto.TabStop = False
        Me.btnAgruparGridProduto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 1
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'grdProduto
        '
        Me.grdProduto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.AutoEdit = True
        Me.grdProduto.ColumnAutoResize = True
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.FrozenColumns = 2
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.Location = New System.Drawing.Point(8, 9)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(964, 366)
        Me.grdProduto.TabIndex = 0
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdProduto.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdProduto.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'pagApontamento
        '
        Me.pagApontamento.Controls.Add(Me.btnExcelGridApontamento)
        Me.pagApontamento.Controls.Add(Me.btnAgruparGridApontamento)
        Me.pagApontamento.Controls.Add(Me.btnConfigurarGridApontamento)
        Me.pagApontamento.Controls.Add(Me.grdApontamento)
        Me.pagApontamento.Key = "pagApontamento"
        Me.pagApontamento.Location = New System.Drawing.Point(1, 22)
        Me.pagApontamento.Name = "pagApontamento"
        Me.pagApontamento.Size = New System.Drawing.Size(980, 384)
        Me.pagApontamento.TabStop = True
        Me.pagApontamento.Text = "Apontamentos"
        '
        'btnExcelGridApontamento
        '
        Me.btnExcelGridApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridApontamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridApontamento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridApontamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridApontamento.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridApontamento.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridApontamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridApontamento.Name = "btnExcelGridApontamento"
        Me.btnExcelGridApontamento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridApontamento.TabIndex = 3
        Me.btnExcelGridApontamento.TabStop = False
        Me.btnExcelGridApontamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridApontamento
        '
        Me.btnAgruparGridApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridApontamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridApontamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridApontamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridApontamento.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridApontamento.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridApontamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridApontamento.Name = "btnAgruparGridApontamento"
        Me.btnAgruparGridApontamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridApontamento.TabIndex = 2
        Me.btnAgruparGridApontamento.TabStop = False
        Me.btnAgruparGridApontamento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridApontamento
        '
        Me.btnConfigurarGridApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridApontamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridApontamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridApontamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridApontamento.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridApontamento.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridApontamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridApontamento.Name = "btnConfigurarGridApontamento"
        Me.btnConfigurarGridApontamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridApontamento.TabIndex = 1
        Me.btnConfigurarGridApontamento.TabStop = False
        Me.btnConfigurarGridApontamento.UseVisualStyleBackColor = False
        '
        'grdApontamento
        '
        Me.grdApontamento.AllowChildTableGroups = True
        Me.grdApontamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdApontamento.AutoEdit = True
        Me.grdApontamento.ColumnAutoResize = True
        grdApontamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdApontamento_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_1.Instance"), Object)
        grdApontamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdApontamento_DesignTimeLayout_Reference_0, grdApontamento_DesignTimeLayout_Reference_1})
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdApontamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdApontamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdApontamento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.FrozenColumns = 3
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdApontamento.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.Hierarchical = True
        Me.grdApontamento.Location = New System.Drawing.Point(8, 9)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.RecordNavigator = True
        Me.grdApontamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(964, 366)
        Me.grdApontamento.TabIndex = 0
        Me.grdApontamento.TabStop = False
        Me.grdApontamento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdApontamento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdApontamento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
        '
        'pagDadosGerais
        '
        Me.pagDadosGerais.Controls.Add(Me.grpDadosVenda)
        Me.pagDadosGerais.Key = "pagDadosGerais"
        Me.pagDadosGerais.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.Size = New System.Drawing.Size(980, 384)
        Me.pagDadosGerais.TabStop = True
        Me.pagDadosGerais.Text = "Dados Gerais"
        '
        'grpDadosVenda
        '
        Me.grpDadosVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosVenda.Controls.Add(Me.txtObservacao)
        Me.grpDadosVenda.Controls.Add(Me.lblObservacao)
        Me.grpDadosVenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosVenda.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosVenda.Name = "grpDadosVenda"
        Me.grpDadosVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosVenda.Size = New System.Drawing.Size(964, 372)
        Me.grpDadosVenda.TabIndex = 0
        Me.grpDadosVenda.Text = "Dados da Ordem de Serviço"
        Me.grpDadosVenda.VisualStyleManager = Me.vsmMain
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(9, 37)
        Me.txtObservacao.MaxLength = 5000
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(946, 325)
        Me.txtObservacao.TabIndex = 1
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 20)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 0
        Me.lblObservacao.Text = "Observação:"
        '
        'usrManOrdemServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrManOrdemServico"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaEmAndamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagProduto.ResumeLayout(False)
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagApontamento.ResumeLayout(False)
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDadosGerais.ResumeLayout(False)
        CType(Me.grpDadosVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosVenda.ResumeLayout(False)
        Me.grpDadosVenda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Private WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataOrdemServicoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataOrdemServico As System.Windows.Forms.Label
    Friend WithEvents txtNumeroOrdemServico As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrdemServico As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Private WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroOrdemServicoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrdemServicoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagApontamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents cboManutencao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblManutencao As System.Windows.Forms.Label
    Friend WithEvents dtpDataOrdemServicoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataOrdemServicoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataOrdemServico As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridApontamento As System.Windows.Forms.Button
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgruparGridApontamento As System.Windows.Forms.Button
    Friend WithEvents cboNumeroRequisicao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents cboTipoManutencao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoManutencao As System.Windows.Forms.Label
    Friend WithEvents txtNumeroRequisicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboTipoManutencaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoManutencaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblManutencaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Private WithEvents btnInserirApontamento As Janus.Windows.EditControls.UIButton
    Private WithEvents btnExcluirApontamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataConclusaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataConclusaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataConclusaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboManutencaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridApontamento As System.Windows.Forms.Button
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosVenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaConcluido As System.Windows.Forms.Label
    Friend WithEvents picLegendaConcluido As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelado As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEmAndamento As System.Windows.Forms.Label
    Friend WithEvents picLegendaEmAndamento As System.Windows.Forms.PictureBox
    Friend WithEvents btnFinalizar As Janus.Windows.EditControls.UIButton

End Class
