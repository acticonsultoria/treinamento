<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmpPedidoAprovar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpPedidoAprovar))
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim grdCotacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdCotacao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdCotacao_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdCotacao_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column1.Image")
        Dim grdCotacao_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column2.Image")
        Dim grdCotacao_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table1.Columns.Column0.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagGerarPedido = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaNaoFoiSelecionadoMenorPreco = New System.Windows.Forms.PictureBox()
        Me.lblLegendaNaoFoiSelecionadoMenorPreco = New System.Windows.Forms.Label()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGridCotacao = New System.Windows.Forms.Button()
        Me.grpControleFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnReprovarCompra = New Janus.Windows.EditControls.UIButton()
        Me.btnReprovarOrcamento = New Janus.Windows.EditControls.UIButton()
        Me.btnAprovarPedidoCompraUnitario = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdCotacao = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboFornecedorCotacaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataCotacaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataCotacaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroCotacaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroCotacaoFiltro = New System.Windows.Forms.Label()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataCotacaoFiltro = New System.Windows.Forms.Label()
        Me.lblFornecedorCotacaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagGerarPedido.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaNaoFoiSelecionadoMenorPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControleFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleFiltro.SuspendLayout()
        CType(Me.grdCotacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagGerarPedido})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagGerarPedido
        '
        Me.pagGerarPedido.Controls.Add(Me.btnExcelGrid)
        Me.pagGerarPedido.Controls.Add(Me.grpLegenda)
        Me.pagGerarPedido.Controls.Add(Me.btnAgruparGrid)
        Me.pagGerarPedido.Controls.Add(Me.btnConfigurarGridCotacao)
        Me.pagGerarPedido.Controls.Add(Me.grpControleFiltro)
        Me.pagGerarPedido.Controls.Add(Me.grdCotacao)
        Me.pagGerarPedido.Controls.Add(Me.grpFiltro)
        Me.pagGerarPedido.Key = "pagGerarPedido"
        Me.pagGerarPedido.Location = New System.Drawing.Point(1, 22)
        Me.pagGerarPedido.Name = "pagGerarPedido"
        Me.pagGerarPedido.Size = New System.Drawing.Size(913, 543)
        Me.pagGerarPedido.TabStop = True
        Me.pagGerarPedido.Text = "Aprovar Pedido de Compra"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = CType(resources.GetObject("btnExcelGrid.Image"), System.Drawing.Image)
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 25
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaNaoFoiSelecionadoMenorPreco)
        Me.grpLegenda.Controls.Add(Me.lblLegendaNaoFoiSelecionadoMenorPreco)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(220, 51)
        Me.grpLegenda.TabIndex = 14
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaNaoFoiSelecionadoMenorPreco
        '
        Me.picLegendaNaoFoiSelecionadoMenorPreco.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaNaoFoiSelecionadoMenorPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaNaoFoiSelecionadoMenorPreco.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaNaoFoiSelecionadoMenorPreco.Name = "picLegendaNaoFoiSelecionadoMenorPreco"
        Me.picLegendaNaoFoiSelecionadoMenorPreco.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaNaoFoiSelecionadoMenorPreco.TabIndex = 11
        Me.picLegendaNaoFoiSelecionadoMenorPreco.TabStop = False
        '
        'lblLegendaNaoFoiSelecionadoMenorPreco
        '
        Me.lblLegendaNaoFoiSelecionadoMenorPreco.AutoSize = True
        Me.lblLegendaNaoFoiSelecionadoMenorPreco.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaNaoFoiSelecionadoMenorPreco.Name = "lblLegendaNaoFoiSelecionadoMenorPreco"
        Me.lblLegendaNaoFoiSelecionadoMenorPreco.Size = New System.Drawing.Size(187, 14)
        Me.lblLegendaNaoFoiSelecionadoMenorPreco.TabIndex = 3
        Me.lblLegendaNaoFoiSelecionadoMenorPreco.Text = "Não é o Orçamento com menor Preço"
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
        Me.btnAgruparGrid.TabIndex = 13
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridCotacao
        '
        Me.btnConfigurarGridCotacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridCotacao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridCotacao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridCotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridCotacao.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridCotacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridCotacao.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridCotacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridCotacao.Name = "btnConfigurarGridCotacao"
        Me.btnConfigurarGridCotacao.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridCotacao.TabIndex = 10
        Me.btnConfigurarGridCotacao.TabStop = False
        Me.btnConfigurarGridCotacao.UseVisualStyleBackColor = False
        '
        'grpControleFiltro
        '
        Me.grpControleFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpControleFiltro.Controls.Add(Me.btnReprovarCompra)
        Me.grpControleFiltro.Controls.Add(Me.btnReprovarOrcamento)
        Me.grpControleFiltro.Controls.Add(Me.btnAprovarPedidoCompraUnitario)
        Me.grpControleFiltro.Controls.Add(Me.btnSair)
        Me.grpControleFiltro.Location = New System.Drawing.Point(237, 483)
        Me.grpControleFiltro.Name = "grpControleFiltro"
        Me.grpControleFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleFiltro.Size = New System.Drawing.Size(668, 51)
        Me.grpControleFiltro.TabIndex = 5
        Me.grpControleFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnReprovarCompra
        '
        Me.btnReprovarCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReprovarCompra.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnReprovarCompra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnReprovarCompra.Location = New System.Drawing.Point(297, 17)
        Me.btnReprovarCompra.Name = "btnReprovarCompra"
        Me.btnReprovarCompra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnReprovarCompra.Size = New System.Drawing.Size(130, 23)
        SuperTipSettings1.HeaderText = "Reprovar Compra"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Clique em Reprovar Compra quando não tem intensão de comprar este Item."
        Me.jstTip.SetSuperTip(Me.btnReprovarCompra, SuperTipSettings1)
        Me.btnReprovarCompra.TabIndex = 2
        Me.btnReprovarCompra.Text = "Reprovar Compra"
        Me.btnReprovarCompra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnReprovarOrcamento
        '
        Me.btnReprovarOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReprovarOrcamento.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnReprovarOrcamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnReprovarOrcamento.Location = New System.Drawing.Point(161, 17)
        Me.btnReprovarOrcamento.Name = "btnReprovarOrcamento"
        Me.btnReprovarOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnReprovarOrcamento.Size = New System.Drawing.Size(130, 23)
        SuperTipSettings2.HeaderText = "Reprovar Orçamento"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Clique em Reprovar Orçamento quando deseja que o Item volte para Compras cotar no" & _
    "vamente."
        Me.jstTip.SetSuperTip(Me.btnReprovarOrcamento, SuperTipSettings2)
        Me.btnReprovarOrcamento.TabIndex = 1
        Me.btnReprovarOrcamento.Text = "Reprovar Orçamento"
        Me.btnReprovarOrcamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAprovarPedidoCompraUnitario
        '
        Me.btnAprovarPedidoCompraUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAprovarPedidoCompraUnitario.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnAprovarPedidoCompraUnitario.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAprovarPedidoCompraUnitario.Location = New System.Drawing.Point(433, 17)
        Me.btnAprovarPedidoCompraUnitario.Name = "btnAprovarPedidoCompraUnitario"
        Me.btnAprovarPedidoCompraUnitario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAprovarPedidoCompraUnitario.Size = New System.Drawing.Size(130, 23)
        Me.btnAprovarPedidoCompraUnitario.TabIndex = 4
        Me.btnAprovarPedidoCompraUnitario.Text = "Aprovar Compra"
        Me.btnAprovarPedidoCompraUnitario.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(569, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(90, 23)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdCotacao
        '
        Me.grdCotacao.AlternatingColors = True
        Me.grdCotacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCotacao.AutoEdit = True
        grdCotacao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdCotacao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdCotacao_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdCotacao_DesignTimeLayout_Reference_1.Instance"), Object)
        grdCotacao_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdCotacao_DesignTimeLayout_Reference_2.Instance"), Object)
        grdCotacao_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdCotacao_DesignTimeLayout_Reference_3.Instance"), Object)
        grdCotacao_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("grdCotacao_DesignTimeLayout_Reference_4.Instance"), Object)
        grdCotacao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdCotacao_DesignTimeLayout_Reference_0, grdCotacao_DesignTimeLayout_Reference_1, grdCotacao_DesignTimeLayout_Reference_2, grdCotacao_DesignTimeLayout_Reference_3, grdCotacao_DesignTimeLayout_Reference_4})
        grdCotacao_DesignTimeLayout.LayoutString = resources.GetString("grdCotacao_DesignTimeLayout.LayoutString")
        Me.grdCotacao.DesignTimeLayout = grdCotacao_DesignTimeLayout
        Me.grdCotacao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCotacao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCotacao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdCotacao.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdCotacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCotacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCotacao.FrozenColumns = 7
        Me.grdCotacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCotacao.GroupByBoxVisible = False
        Me.grdCotacao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdCotacao.Hierarchical = True
        Me.grdCotacao.Location = New System.Drawing.Point(8, 116)
        Me.grdCotacao.Name = "grdCotacao"
        Me.grdCotacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCotacao.RecordNavigator = True
        Me.grdCotacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCotacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCotacao.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.grdCotacao.Size = New System.Drawing.Size(897, 364)
        Me.grdCotacao.TabIndex = 4
        Me.grdCotacao.TabStop = False
        Me.grdCotacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCotacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCotacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCotacao.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboFornecedorCotacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataCotacaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataCotacaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroCotacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroCotacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataCotacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorCotacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 3
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboFornecedorCotacaoFiltro
        '
        Me.cboFornecedorCotacaoFiltro.Location = New System.Drawing.Point(358, 34)
        Me.cboFornecedorCotacaoFiltro.Name = "cboFornecedorCotacaoFiltro"
        Me.cboFornecedorCotacaoFiltro.Size = New System.Drawing.Size(402, 20)
        Me.cboFornecedorCotacaoFiltro.TabIndex = 6
        '
        'dtpDataCotacaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataCotacaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataCotacaoTerminoFiltro.Location = New System.Drawing.Point(244, 34)
        Me.dtpDataCotacaoTerminoFiltro.Name = "dtpDataCotacaoTerminoFiltro"
        Me.dtpDataCotacaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataCotacaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataCotacaoTerminoFiltro.TabIndex = 4
        '
        'dtpDataCotacaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataCotacaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataCotacaoInicioFiltro.Location = New System.Drawing.Point(130, 34)
        Me.dtpDataCotacaoInicioFiltro.Name = "dtpDataCotacaoInicioFiltro"
        Me.dtpDataCotacaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataCotacaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataCotacaoInicioFiltro.TabIndex = 3
        '
        'txtNumeroCotacaoFiltro
        '
        Me.txtNumeroCotacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCotacaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroCotacaoFiltro.MaxLength = 20
        Me.txtNumeroCotacaoFiltro.Name = "txtNumeroCotacaoFiltro"
        Me.txtNumeroCotacaoFiltro.Size = New System.Drawing.Size(115, 20)
        Me.txtNumeroCotacaoFiltro.TabIndex = 1
        '
        'lblNumeroCotacaoFiltro
        '
        Me.lblNumeroCotacaoFiltro.AutoSize = True
        Me.lblNumeroCotacaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroCotacaoFiltro.Name = "lblNumeroCotacaoFiltro"
        Me.lblNumeroCotacaoFiltro.Size = New System.Drawing.Size(65, 14)
        Me.lblNumeroCotacaoFiltro.TabIndex = 0
        Me.lblNumeroCotacaoFiltro.Text = "Nº Cotação:"
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
        Me.txtItemFiltro.MaxLength = 120
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.Size = New System.Drawing.Size(751, 20)
        Me.txtItemFiltro.TabIndex = 8
        '
        'lblDataCotacaoFiltro
        '
        Me.lblDataCotacaoFiltro.AutoSize = True
        Me.lblDataCotacaoFiltro.Location = New System.Drawing.Point(127, 17)
        Me.lblDataCotacaoFiltro.Name = "lblDataCotacaoFiltro"
        Me.lblDataCotacaoFiltro.Size = New System.Drawing.Size(90, 14)
        Me.lblDataCotacaoFiltro.TabIndex = 2
        Me.lblDataCotacaoFiltro.Text = "Data da Cotação:"
        '
        'lblFornecedorCotacaoFiltro
        '
        Me.lblFornecedorCotacaoFiltro.AutoSize = True
        Me.lblFornecedorCotacaoFiltro.Location = New System.Drawing.Point(355, 17)
        Me.lblFornecedorCotacaoFiltro.Name = "lblFornecedorCotacaoFiltro"
        Me.lblFornecedorCotacaoFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorCotacaoFiltro.TabIndex = 5
        Me.lblFornecedorCotacaoFiltro.Text = "Fornecedor:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(798, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(90, 23)
        Me.btnFiltrar.TabIndex = 9
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCmpPedidoAprovar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpPedidoAprovar"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagGerarPedido.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaNaoFoiSelecionadoMenorPreco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControleFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleFiltro.ResumeLayout(False)
        CType(Me.grdCotacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagGerarPedido As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdCotacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboFornecedorCotacaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataCotacaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataCotacaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumeroCotacaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroCotacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblItemFiltro As System.Windows.Forms.Label
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataCotacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblFornecedorCotacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGridCotacao As System.Windows.Forms.Button
    Private WithEvents btnAprovarPedidoCompraUnitario As Janus.Windows.EditControls.UIButton
    Private WithEvents btnReprovarCompra As Janus.Windows.EditControls.UIButton
    Private WithEvents btnReprovarOrcamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaNaoFoiSelecionadoMenorPreco As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaNaoFoiSelecionadoMenorPreco As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button

End Class
