<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVenPedidoLegado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVenPedidoLegado))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim grdListagem_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.Image")
        Dim grdListagem_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.Image")
        Dim grdListagem_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column10.Image")
        Dim grdListagem_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column11.Image")
        Dim grdListagem_DesignTimeLayout_Reference_8 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.ChildTables.Table0.Columns.Column0." &
        "Image")
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings4 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings5 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings6 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings7 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdProduto_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdProduto_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdVendedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProducao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProducao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblParcialmenteEntregue = New System.Windows.Forms.Label()
        Me.picParcialmenteEntregue = New System.Windows.Forms.PictureBox()
        Me.lblEntregue = New System.Windows.Forms.Label()
        Me.picEntregue = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCancelado = New System.Windows.Forms.Label()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPedidoVenda = New System.Windows.Forms.Label()
        Me.picLegendaTipoOrcamento = New System.Windows.Forms.PictureBox()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarClienteFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarItemFiltro = New System.Windows.Forms.Button()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.lblTipoItemFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataPedidoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPedidoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroPedidoClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoClienteFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroPedidoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoFiltro = New System.Windows.Forms.Label()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataPedidoFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpGerarOP = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblItemPai = New System.Windows.Forms.Label()
        Me.cboItemPai = New Janus.Windows.EditControls.UIComboBox()
        Me.chkAgrupar = New Janus.Windows.EditControls.UICheckBox()
        Me.btnGerarOrdemProducao = New Janus.Windows.EditControls.UIButton()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroOrcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrcamento = New System.Windows.Forms.Label()
        Me.txtComprador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataPedido = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblRequerente = New System.Windows.Forms.Label()
        Me.lblDataPedido = New System.Windows.Forms.Label()
        Me.txtNumeroPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.btnCadastrarCliente = New System.Windows.Forms.Button()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCriarItemFantasma = New Janus.Windows.EditControls.UIButton()
        Me.btnGerarForeCast = New Janus.Windows.EditControls.UIButton()
        Me.btnRegistroAnterior = New Janus.Windows.EditControls.UIButton()
        Me.btnProximoRegistro = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTituloArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTituloArquivo = New System.Windows.Forms.Label()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarObservacaoVenda = New System.Windows.Forms.Button()
        Me.btnProcurarObservacaoVenda = New System.Windows.Forms.Button()
        Me.grdVendedor = New Janus.Windows.GridEX.GridEX()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.cboTransportadora = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTransportadora = New System.Windows.Forms.Label()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.btnCadastrarTransportadora = New System.Windows.Forms.Button()
        Me.btnProcurarTransportadora = New System.Windows.Forms.Button()
        Me.grpTotal = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorIPI = New System.Windows.Forms.Label()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.cboFormaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtValorFinalPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFinalPedido = New System.Windows.Forms.Label()
        Me.txtValorTotalPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotalOrcamento = New System.Windows.Forms.Label()
        Me.lblModalidadeFrete = New System.Windows.Forms.Label()
        Me.lblCondicaoPagamento = New System.Windows.Forms.Label()
        Me.cboModalidadeFrete = New Janus.Windows.EditControls.UIComboBox()
        Me.cboCondicaoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarCondicaoPagamento = New System.Windows.Forms.Button()
        Me.pagProducao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdProducao = New Janus.Windows.GridEX.GridEX()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picParcialmenteEntregue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEntregue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpGerarOP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGerarOP.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagProduto.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpDadosVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosVenda.SuspendLayout()
        CType(Me.grdVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTotal.SuspendLayout()
        Me.pagProducao.SuspendLayout()
        CType(Me.grdProducao, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Pedido de Venda"
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
        Me.btnExcelGrid.TabIndex = 90
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
        Me.btnAgruparGrid.TabIndex = 24
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
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblParcialmenteEntregue)
        Me.grpLegenda.Controls.Add(Me.picParcialmenteEntregue)
        Me.grpLegenda.Controls.Add(Me.lblEntregue)
        Me.grpLegenda.Controls.Add(Me.picEntregue)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoVenda)
        Me.grpLegenda.Controls.Add(Me.picLegendaTipoOrcamento)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(258, 51)
        Me.grpLegenda.TabIndex = 3
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblParcialmenteEntregue
        '
        Me.lblParcialmenteEntregue.AutoSize = True
        Me.lblParcialmenteEntregue.Location = New System.Drawing.Point(141, 13)
        Me.lblParcialmenteEntregue.Name = "lblParcialmenteEntregue"
        Me.lblParcialmenteEntregue.Size = New System.Drawing.Size(114, 14)
        Me.lblParcialmenteEntregue.TabIndex = 1
        Me.lblParcialmenteEntregue.Text = "Parcialmente Faturado"
        '
        'picParcialmenteEntregue
        '
        Me.picParcialmenteEntregue.BackColor = System.Drawing.Color.Peru
        Me.picParcialmenteEntregue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParcialmenteEntregue.Location = New System.Drawing.Point(122, 13)
        Me.picParcialmenteEntregue.Name = "picParcialmenteEntregue"
        Me.picParcialmenteEntregue.Size = New System.Drawing.Size(13, 14)
        Me.picParcialmenteEntregue.TabIndex = 20
        Me.picParcialmenteEntregue.TabStop = False
        '
        'lblEntregue
        '
        Me.lblEntregue.AutoSize = True
        Me.lblEntregue.Location = New System.Drawing.Point(28, 30)
        Me.lblEntregue.Name = "lblEntregue"
        Me.lblEntregue.Size = New System.Drawing.Size(50, 14)
        Me.lblEntregue.TabIndex = 2
        Me.lblEntregue.Text = "Faturado"
        '
        'picEntregue
        '
        Me.picEntregue.BackColor = System.Drawing.Color.ForestGreen
        Me.picEntregue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEntregue.Location = New System.Drawing.Point(9, 30)
        Me.picEntregue.Name = "picEntregue"
        Me.picEntregue.Size = New System.Drawing.Size(13, 14)
        Me.picEntregue.TabIndex = 18
        Me.picEntregue.TabStop = False
        '
        'lblLegendaCancelado
        '
        Me.lblLegendaCancelado.AutoSize = True
        Me.lblLegendaCancelado.Location = New System.Drawing.Point(141, 30)
        Me.lblLegendaCancelado.Name = "lblLegendaCancelado"
        Me.lblLegendaCancelado.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelado.TabIndex = 3
        Me.lblLegendaCancelado.Text = "Cancelado"
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(122, 30)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelado.TabIndex = 16
        Me.picLegendaCancelado.TabStop = False
        '
        'lblLegendaPedidoVenda
        '
        Me.lblLegendaPedidoVenda.AutoSize = True
        Me.lblLegendaPedidoVenda.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaPedidoVenda.Name = "lblLegendaPedidoVenda"
        Me.lblLegendaPedidoVenda.Size = New System.Drawing.Size(88, 14)
        Me.lblLegendaPedidoVenda.TabIndex = 0
        Me.lblLegendaPedidoVenda.Text = "Pedido de Venda"
        '
        'picLegendaTipoOrcamento
        '
        Me.picLegendaTipoOrcamento.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaTipoOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaTipoOrcamento.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaTipoOrcamento.Name = "picLegendaTipoOrcamento"
        Me.picLegendaTipoOrcamento.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaTipoOrcamento.TabIndex = 4
        Me.picLegendaTipoOrcamento.TabStop = False
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
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_4.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_5.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_6.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_7.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_8.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_8.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3, grdListagem_DesignTimeLayout_Reference_4, grdListagem_DesignTimeLayout_Reference_5, grdListagem_DesignTimeLayout_Reference_6, grdListagem_DesignTimeLayout_Reference_7, grdListagem_DesignTimeLayout_Reference_8})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 8
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 157)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 323)
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
        Me.grpFiltro.Controls.Add(Me.cboTipoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataPedidoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 148)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboTipoItemFiltro
        '
        Me.cboTipoItemFiltro.AutoSize = False
        Me.cboTipoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoItemFiltro.Location = New System.Drawing.Point(9, 116)
        Me.cboTipoItemFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoItemFiltro.Name = "cboTipoItemFiltro"
        Me.cboTipoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoItemFiltro.Size = New System.Drawing.Size(143, 20)
        Me.cboTipoItemFiltro.TabIndex = 27
        '
        'cboItemFiltro
        '
        Me.cboItemFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboItemFiltro.AutoSize = False
        Me.cboItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboItemFiltro.Location = New System.Drawing.Point(158, 116)
        Me.cboItemFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboItemFiltro.Name = "cboItemFiltro"
        Me.cboItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboItemFiltro.Size = New System.Drawing.Size(668, 20)
        Me.cboItemFiltro.TabIndex = 29
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClienteFiltro.AutoSize = False
        Me.cboClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFiltro.Location = New System.Drawing.Point(342, 34)
        Me.cboClienteFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(484, 20)
        Me.cboClienteFiltro.TabIndex = 8
        '
        'btnProcurarClienteFiltro
        '
        Me.btnProcurarClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarClienteFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarClienteFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarClienteFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarClienteFiltro.Location = New System.Drawing.Point(809, 16)
        Me.btnProcurarClienteFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarClienteFiltro.Name = "btnProcurarClienteFiltro"
        Me.btnProcurarClienteFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarClienteFiltro.TabIndex = 9
        Me.btnProcurarClienteFiltro.TabStop = False
        Me.btnProcurarClienteFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarItemFiltro
        '
        Me.btnProcurarItemFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarItemFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarItemFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItemFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItemFiltro.Location = New System.Drawing.Point(808, 98)
        Me.btnProcurarItemFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItemFiltro.Name = "btnProcurarItemFiltro"
        Me.btnProcurarItemFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItemFiltro.TabIndex = 30
        Me.btnProcurarItemFiltro.TabStop = False
        Me.btnProcurarItemFiltro.UseVisualStyleBackColor = True
        '
        'lblItemFiltro
        '
        Me.lblItemFiltro.AutoSize = True
        Me.lblItemFiltro.Location = New System.Drawing.Point(155, 99)
        Me.lblItemFiltro.Name = "lblItemFiltro"
        Me.lblItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblItemFiltro.TabIndex = 28
        Me.lblItemFiltro.Text = "Item:"
        '
        'lblTipoItemFiltro
        '
        Me.lblTipoItemFiltro.AutoSize = True
        Me.lblTipoItemFiltro.Location = New System.Drawing.Point(6, 99)
        Me.lblTipoItemFiltro.Name = "lblTipoItemFiltro"
        Me.lblTipoItemFiltro.Size = New System.Drawing.Size(67, 14)
        Me.lblTipoItemFiltro.TabIndex = 26
        Me.lblTipoItemFiltro.Text = "Tipo de Item:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(115, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(710, 20)
        Me.cboStatusFiltro.TabIndex = 13
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'dtpDataPedidoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPedidoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPedidoInicioFiltro.Location = New System.Drawing.Point(115, 34)
        Me.dtpDataPedidoInicioFiltro.Name = "dtpDataPedidoInicioFiltro"
        Me.dtpDataPedidoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPedidoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPedidoInicioFiltro.TabIndex = 3
        Me.dtpDataPedidoInicioFiltro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'dtpDataPedidoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPedidoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPedidoTerminoFiltro.Location = New System.Drawing.Point(228, 34)
        Me.dtpDataPedidoTerminoFiltro.Name = "dtpDataPedidoTerminoFiltro"
        Me.dtpDataPedidoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPedidoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPedidoTerminoFiltro.TabIndex = 4
        Me.dtpDataPedidoTerminoFiltro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'txtNumeroPedidoClienteFiltro
        '
        Me.txtNumeroPedidoClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoClienteFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtNumeroPedidoClienteFiltro.MaxLength = 20
        Me.txtNumeroPedidoClienteFiltro.Name = "txtNumeroPedidoClienteFiltro"
        Me.txtNumeroPedidoClienteFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPedidoClienteFiltro.TabIndex = 11
        '
        'lblNumeroPedidoClienteFiltro
        '
        Me.lblNumeroPedidoClienteFiltro.AutoSize = True
        Me.lblNumeroPedidoClienteFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblNumeroPedidoClienteFiltro.Name = "lblNumeroPedidoClienteFiltro"
        Me.lblNumeroPedidoClienteFiltro.Size = New System.Drawing.Size(92, 14)
        Me.lblNumeroPedidoClienteFiltro.TabIndex = 10
        Me.lblNumeroPedidoClienteFiltro.Text = "Nº Pedido Cliente:"
        '
        'txtNumeroPedidoFiltro
        '
        Me.txtNumeroPedidoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroPedidoFiltro.MaxLength = 20
        Me.txtNumeroPedidoFiltro.Name = "txtNumeroPedidoFiltro"
        Me.txtNumeroPedidoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPedidoFiltro.TabIndex = 1
        '
        'lblNumeroPedidoFiltro
        '
        Me.lblNumeroPedidoFiltro.AutoSize = True
        Me.lblNumeroPedidoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroPedidoFiltro.Name = "lblNumeroPedidoFiltro"
        Me.lblNumeroPedidoFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedidoFiltro.TabIndex = 0
        Me.lblNumeroPedidoFiltro.Text = "Nº Pedido:"
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(112, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 12
        Me.lblStatusFiltro.Text = "Status:"
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(339, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 7
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 77)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 33
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataPedidoFiltro
        '
        Me.lblDataPedidoFiltro.AutoSize = True
        Me.lblDataPedidoFiltro.Location = New System.Drawing.Point(112, 17)
        Me.lblDataPedidoFiltro.Name = "lblDataPedidoFiltro"
        Me.lblDataPedidoFiltro.Size = New System.Drawing.Size(67, 14)
        Me.lblDataPedidoFiltro.TabIndex = 2
        Me.lblDataPedidoFiltro.Text = "Data Pedido:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnCancelar)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(275, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(715, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(421, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(518, 17)
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
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(615, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpGerarOP)
        Me.pagDados.Controls.Add(Me.grpInformacoes)
        Me.pagDados.Controls.Add(Me.grdControlesEdicao)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Pedido de Venda"
        '
        'grpGerarOP
        '
        Me.grpGerarOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpGerarOP.BackColor = System.Drawing.Color.Transparent
        Me.grpGerarOP.Controls.Add(Me.lblItemPai)
        Me.grpGerarOP.Controls.Add(Me.cboItemPai)
        Me.grpGerarOP.Controls.Add(Me.chkAgrupar)
        Me.grpGerarOP.Controls.Add(Me.btnGerarOrdemProducao)
        Me.grpGerarOP.Location = New System.Drawing.Point(8, 440)
        Me.grpGerarOP.Name = "grpGerarOP"
        Me.grpGerarOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpGerarOP.Size = New System.Drawing.Size(454, 94)
        Me.grpGerarOP.TabIndex = 2
        Me.grpGerarOP.VisualStyleManager = Me.vsmMain
        '
        'lblItemPai
        '
        Me.lblItemPai.AutoSize = True
        Me.lblItemPai.Location = New System.Drawing.Point(10, 48)
        Me.lblItemPai.Name = "lblItemPai"
        Me.lblItemPai.Size = New System.Drawing.Size(191, 14)
        Me.lblItemPai.TabIndex = 22
        Me.lblItemPai.Text = "Gerar Ordens de Produção abaixo de:"
        '
        'cboItemPai
        '
        Me.cboItemPai.AutoSize = False
        Me.cboItemPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboItemPai.Location = New System.Drawing.Point(13, 65)
        Me.cboItemPai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboItemPai.Name = "cboItemPai"
        Me.cboItemPai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboItemPai.Size = New System.Drawing.Size(231, 20)
        Me.cboItemPai.TabIndex = 23
        '
        'chkAgrupar
        '
        Me.chkAgrupar.Location = New System.Drawing.Point(13, 22)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Size = New System.Drawing.Size(225, 17)
        SuperTipSettings1.HeaderText = "Agrupar apontamentos no Produto Vendido"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Essa opção fará com que toda a estrutura seja consolidada no Produto Topo, e desc" &
    "onsiderando os demais níveis de filhos e netos"
        Me.jstTip.SetSuperTip(Me.chkAgrupar, SuperTipSettings1)
        Me.chkAgrupar.TabIndex = 21
        Me.chkAgrupar.TabStop = False
        Me.chkAgrupar.Text = "Agrupar apontamentos no Produto Vendido"
        '
        'btnGerarOrdemProducao
        '
        Me.btnGerarOrdemProducao.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnGerarOrdemProducao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarOrdemProducao.Location = New System.Drawing.Point(250, 17)
        Me.btnGerarOrdemProducao.Name = "btnGerarOrdemProducao"
        Me.btnGerarOrdemProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarOrdemProducao.Size = New System.Drawing.Size(187, 23)
        SuperTipSettings2.HeaderText = "Gerar Ordem de Produção"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Gerar Ordem de Produção Espelho do Pedido de Venda "
        Me.jstTip.SetSuperTip(Me.btnGerarOrdemProducao, SuperTipSettings2)
        Me.btnGerarOrdemProducao.TabIndex = 20
        Me.btnGerarOrdemProducao.Text = "Gerar Ordem de Produção"
        Me.btnGerarOrdemProducao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtNumeroOrcamento)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroOrcamento)
        Me.grpInformacoes.Controls.Add(Me.txtComprador)
        Me.grpInformacoes.Controls.Add(Me.dtpDataPedido)
        Me.grpInformacoes.Controls.Add(Me.lblRequerente)
        Me.grpInformacoes.Controls.Add(Me.lblDataPedido)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroPedido)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroPedido)
        Me.grpInformacoes.Controls.Add(Me.cboCliente)
        Me.grpInformacoes.Controls.Add(Me.lblCliente)
        Me.grpInformacoes.Controls.Add(Me.btnProcurarCliente)
        Me.grpInformacoes.Controls.Add(Me.btnCadastrarCliente)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(982, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroOrcamento
        '
        Me.txtNumeroOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroOrcamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrcamento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroOrcamento.Location = New System.Drawing.Point(873, 34)
        Me.txtNumeroOrcamento.MaxLength = 20
        Me.txtNumeroOrcamento.Name = "txtNumeroOrcamento"
        Me.txtNumeroOrcamento.ReadOnly = True
        Me.txtNumeroOrcamento.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroOrcamento.TabIndex = 17
        Me.txtNumeroOrcamento.TabStop = False
        Me.txtNumeroOrcamento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroOrcamento
        '
        Me.lblNumeroOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroOrcamento.AutoSize = True
        Me.lblNumeroOrcamento.Location = New System.Drawing.Point(870, 17)
        Me.lblNumeroOrcamento.Name = "lblNumeroOrcamento"
        Me.lblNumeroOrcamento.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroOrcamento.TabIndex = 16
        Me.lblNumeroOrcamento.Text = "Nº Orçamento:"
        '
        'txtComprador
        '
        Me.txtComprador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComprador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComprador.Location = New System.Drawing.Point(661, 34)
        Me.txtComprador.MaxLength = 20
        Me.txtComprador.Name = "txtComprador"
        Me.txtComprador.Size = New System.Drawing.Size(206, 20)
        Me.txtComprador.TabIndex = 2
        '
        'dtpDataPedido
        '
        '
        '
        '
        Me.dtpDataPedido.DropDownCalendar.Name = ""
        Me.dtpDataPedido.Location = New System.Drawing.Point(115, 34)
        Me.dtpDataPedido.Name = "dtpDataPedido"
        Me.dtpDataPedido.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPedido.TabIndex = 0
        Me.dtpDataPedido.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblRequerente
        '
        Me.lblRequerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRequerente.AutoSize = True
        Me.lblRequerente.Location = New System.Drawing.Point(658, 17)
        Me.lblRequerente.Name = "lblRequerente"
        Me.lblRequerente.Size = New System.Drawing.Size(63, 14)
        Me.lblRequerente.TabIndex = 15
        Me.lblRequerente.Text = "Comprador:"
        '
        'lblDataPedido
        '
        Me.lblDataPedido.AutoSize = True
        Me.lblDataPedido.Location = New System.Drawing.Point(112, 17)
        Me.lblDataPedido.Name = "lblDataPedido"
        Me.lblDataPedido.Size = New System.Drawing.Size(67, 14)
        Me.lblDataPedido.TabIndex = 3
        Me.lblDataPedido.Text = "Data Pedido:"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroPedido.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroPedido.MaxLength = 20
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.ReadOnly = True
        Me.txtNumeroPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPedido.TabIndex = 2
        Me.txtNumeroPedido.TabStop = False
        Me.txtNumeroPedido.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(91, 14)
        Me.lblNumeroPedido.TabIndex = 1
        Me.lblNumeroPedido.Text = "Nº Pedido Venda:"
        '
        'cboCliente
        '
        Me.cboCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(212, 34)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(443, 20)
        Me.cboCliente.TabIndex = 1
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(228, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente:"
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(637, 15)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 14
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCliente.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCliente.Location = New System.Drawing.Point(212, 18)
        Me.btnCadastrarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCliente.TabIndex = 11
        Me.btnCadastrarCliente.TabStop = False
        Me.btnCadastrarCliente.UseVisualStyleBackColor = True
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnCriarItemFantasma)
        Me.grdControlesEdicao.Controls.Add(Me.btnGerarForeCast)
        Me.grdControlesEdicao.Controls.Add(Me.btnRegistroAnterior)
        Me.grdControlesEdicao.Controls.Add(Me.btnProximoRegistro)
        Me.grdControlesEdicao.Controls.Add(Me.btnImprimir)
        Me.grdControlesEdicao.Controls.Add(Me.btnVoltar)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(471, 440)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(519, 94)
        Me.grdControlesEdicao.TabIndex = 0
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnCriarItemFantasma
        '
        Me.btnCriarItemFantasma.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnCriarItemFantasma.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCriarItemFantasma.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnCriarItemFantasma.Location = New System.Drawing.Point(9, 48)
        Me.btnCriarItemFantasma.Name = "btnCriarItemFantasma"
        Me.btnCriarItemFantasma.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCriarItemFantasma.Size = New System.Drawing.Size(210, 23)
        SuperTipSettings3.HeaderText = "Criar Item Fantasma"
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Essa função irá adicionar uma linha de pedido e uma ordem de produção, para que a" &
    " mesma seja a OP Topo e agrupe as demais ordens de produção"
        Me.jstTip.SetSuperTip(Me.btnCriarItemFantasma, SuperTipSettings3)
        Me.btnCriarItemFantasma.TabIndex = 20
        Me.btnCriarItemFantasma.Text = "Criar Item / OP Fantasma"
        Me.btnCriarItemFantasma.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnGerarForeCast
        '
        Me.btnGerarForeCast.Image = Global.INTERACTI.My.Resources.Resources.relogio
        Me.btnGerarForeCast.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarForeCast.Location = New System.Drawing.Point(63, 17)
        Me.btnGerarForeCast.Name = "btnGerarForeCast"
        Me.btnGerarForeCast.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarForeCast.Size = New System.Drawing.Size(156, 23)
        SuperTipSettings4.HeaderText = "Gerar Forecast"
        SuperTipSettings4.ImageListProvider = Nothing
        SuperTipSettings4.Text = "Ao clicar no botão será exibido a tela de planejamento para abrir Ordens de Produ" &
    "ção"
        Me.jstTip.SetSuperTip(Me.btnGerarForeCast, SuperTipSettings4)
        Me.btnGerarForeCast.TabIndex = 19
        Me.btnGerarForeCast.Text = "Gerar Forecast"
        Me.btnGerarForeCast.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnRegistroAnterior
        '
        Me.btnRegistroAnterior.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnRegistroAnterior.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRegistroAnterior.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnRegistroAnterior.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.btnRegistroAnterior.Location = New System.Drawing.Point(9, 17)
        Me.btnRegistroAnterior.Name = "btnRegistroAnterior"
        Me.btnRegistroAnterior.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRegistroAnterior.Size = New System.Drawing.Size(21, 23)
        SuperTipSettings5.HeaderText = "Registro anterior"
        SuperTipSettings5.ImageListProvider = Nothing
        SuperTipSettings5.Text = "Navegar pelo Pedido de Venda Anterior"
        Me.jstTip.SetSuperTip(Me.btnRegistroAnterior, SuperTipSettings5)
        Me.btnRegistroAnterior.TabIndex = 17
        Me.btnRegistroAnterior.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProximoRegistro
        '
        Me.btnProximoRegistro.Image = Global.INTERACTI.My.Resources.Resources.seta_direita
        Me.btnProximoRegistro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProximoRegistro.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnProximoRegistro.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.btnProximoRegistro.Location = New System.Drawing.Point(36, 17)
        Me.btnProximoRegistro.Name = "btnProximoRegistro"
        Me.btnProximoRegistro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProximoRegistro.Size = New System.Drawing.Size(21, 23)
        SuperTipSettings6.HeaderText = "Registro posterior"
        SuperTipSettings6.ImageListProvider = Nothing
        SuperTipSettings6.Text = "Navegador pelo Pedido de Venda Posterior"
        Me.jstTip.SetSuperTip(Me.btnProximoRegistro, SuperTipSettings6)
        Me.btnProximoRegistro.TabIndex = 18
        Me.btnProximoRegistro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(225, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        SuperTipSettings7.HeaderText = "Imprimir OP"
        SuperTipSettings7.ImageListProvider = Nothing
        SuperTipSettings7.Text = "Imprimir as Ordens de Produção"
        Me.jstTip.SetSuperTip(Me.btnImprimir, SuperTipSettings7)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(419, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 0
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(322, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
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
        Me.tabDados.Size = New System.Drawing.Size(982, 361)
        Me.tabDados.TabDisplay = Janus.Windows.UI.Tab.TabDisplay.Text
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagProduto, Me.pagArquivo, Me.pagDadosGerais, Me.pagProducao})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagProduto
        '
        Me.pagProduto.Controls.Add(Me.grdProduto)
        Me.pagProduto.Key = "pagItem"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Size = New System.Drawing.Size(980, 338)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Produtos / Serviços"
        '
        'grdProduto
        '
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.AutoEdit = True
        grdProduto_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProduto_DesignTimeLayout_Reference_0.Instance"), Object)
        grdProduto_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdProduto_DesignTimeLayout_Reference_1.Instance"), Object)
        grdProduto_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdProduto_DesignTimeLayout_Reference_2.Instance"), Object)
        grdProduto_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProduto_DesignTimeLayout_Reference_0, grdProduto_DesignTimeLayout_Reference_1, grdProduto_DesignTimeLayout_Reference_2})
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.DynamicFiltering = True
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProduto.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
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
        Me.grdProduto.Size = New System.Drawing.Size(964, 318)
        Me.grdProduto.TabIndex = 1
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
        'pagArquivo
        '
        Me.pagArquivo.Controls.Add(Me.btnExcelGridArquivo)
        Me.pagArquivo.Controls.Add(Me.btnAgruparGridArquivo)
        Me.pagArquivo.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagArquivo.Controls.Add(Me.grpArquivo)
        Me.pagArquivo.Controls.Add(Me.grdArquivo)
        Me.pagArquivo.Key = "pagArquivo"
        Me.pagArquivo.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivo.Name = "pagArquivo"
        Me.pagArquivo.Size = New System.Drawing.Size(980, 338)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Text = "Arquivos"
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 312)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 95
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 312)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 11
        Me.btnAgruparGridArquivo.TabStop = False
        Me.btnAgruparGridArquivo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridArquivo
        '
        Me.btnConfigurarGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 312)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 10
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.txtTituloArquivo)
        Me.grpArquivo.Controls.Add(Me.lblTituloArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(964, 104)
        Me.grpArquivo.TabIndex = 8
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(811, 74)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 9
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArquivo.Location = New System.Drawing.Point(6, 57)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 7
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(9, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(808, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
        '
        'txtTituloArquivo
        '
        Me.txtTituloArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTituloArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTituloArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtTituloArquivo.MaxLength = 100
        Me.txtTituloArquivo.Name = "txtTituloArquivo"
        Me.txtTituloArquivo.Size = New System.Drawing.Size(822, 20)
        Me.txtTituloArquivo.TabIndex = 1
        '
        'lblTituloArquivo
        '
        Me.lblTituloArquivo.AutoSize = True
        Me.lblTituloArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTituloArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblTituloArquivo.Name = "lblTituloArquivo"
        Me.lblTituloArquivo.Size = New System.Drawing.Size(35, 14)
        Me.lblTituloArquivo.TabIndex = 0
        Me.lblTituloArquivo.Text = "Título:"
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(864, 71)
        Me.btnExcluirArquivo.Name = "btnExcluirArquivo"
        Me.btnExcluirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivo.TabIndex = 11
        Me.btnExcluirArquivo.Text = "Excluir"
        Me.btnExcluirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirArquivo
        '
        Me.btnInserirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirArquivo.Location = New System.Drawing.Point(864, 42)
        Me.btnInserirArquivo.Name = "btnInserirArquivo"
        Me.btnInserirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirArquivo.TabIndex = 10
        Me.btnInserirArquivo.Text = "Inserir"
        Me.btnInserirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdArquivo
        '
        Me.grdArquivo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdArquivo.AlternatingColors = True
        Me.grdArquivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArquivo.ColumnAutoResize = True
        grdArquivo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdArquivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivo_DesignTimeLayout_Reference_0})
        grdArquivo_DesignTimeLayout.LayoutString = resources.GetString("grdArquivo_DesignTimeLayout.LayoutString")
        Me.grdArquivo.DesignTimeLayout = grdArquivo_DesignTimeLayout
        Me.grdArquivo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdArquivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivo.FrozenColumns = 3
        Me.grdArquivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivo.GroupByBoxVisible = False
        Me.grdArquivo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdArquivo.Location = New System.Drawing.Point(8, 116)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(964, 213)
        Me.grdArquivo.TabIndex = 9
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'pagDadosGerais
        '
        Me.pagDadosGerais.Controls.Add(Me.grpDadosVenda)
        Me.pagDadosGerais.Controls.Add(Me.grpTotal)
        Me.pagDadosGerais.Key = "pagDadosGerais"
        Me.pagDadosGerais.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.Size = New System.Drawing.Size(980, 338)
        Me.pagDadosGerais.TabStop = True
        Me.pagDadosGerais.Text = "Dados Gerais"
        '
        'grpDadosVenda
        '
        Me.grpDadosVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosVenda.Controls.Add(Me.btnCadastrarObservacaoVenda)
        Me.grpDadosVenda.Controls.Add(Me.btnProcurarObservacaoVenda)
        Me.grpDadosVenda.Controls.Add(Me.grdVendedor)
        Me.grpDadosVenda.Controls.Add(Me.txtReferencia)
        Me.grpDadosVenda.Controls.Add(Me.lblReferencia)
        Me.grpDadosVenda.Controls.Add(Me.cboTransportadora)
        Me.grpDadosVenda.Controls.Add(Me.lblTransportadora)
        Me.grpDadosVenda.Controls.Add(Me.txtObservacao)
        Me.grpDadosVenda.Controls.Add(Me.lblObservacao)
        Me.grpDadosVenda.Controls.Add(Me.btnCadastrarTransportadora)
        Me.grpDadosVenda.Controls.Add(Me.btnProcurarTransportadora)
        Me.grpDadosVenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosVenda.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosVenda.Name = "grpDadosVenda"
        Me.grpDadosVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosVenda.Size = New System.Drawing.Size(675, 326)
        Me.grpDadosVenda.TabIndex = 0
        Me.grpDadosVenda.Text = "Dados de Venda"
        Me.grpDadosVenda.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarObservacaoVenda
        '
        Me.btnCadastrarObservacaoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarObservacaoVenda.FlatAppearance.BorderSize = 0
        Me.btnCadastrarObservacaoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarObservacaoVenda.Image = CType(resources.GetObject("btnCadastrarObservacaoVenda.Image"), System.Drawing.Image)
        Me.btnCadastrarObservacaoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarObservacaoVenda.Location = New System.Drawing.Point(9, 123)
        Me.btnCadastrarObservacaoVenda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarObservacaoVenda.Name = "btnCadastrarObservacaoVenda"
        Me.btnCadastrarObservacaoVenda.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarObservacaoVenda.TabIndex = 5
        Me.btnCadastrarObservacaoVenda.TabStop = False
        Me.btnCadastrarObservacaoVenda.UseVisualStyleBackColor = True
        '
        'btnProcurarObservacaoVenda
        '
        Me.btnProcurarObservacaoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarObservacaoVenda.FlatAppearance.BorderSize = 0
        Me.btnProcurarObservacaoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarObservacaoVenda.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarObservacaoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarObservacaoVenda.Location = New System.Drawing.Point(257, 121)
        Me.btnProcurarObservacaoVenda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarObservacaoVenda.Name = "btnProcurarObservacaoVenda"
        Me.btnProcurarObservacaoVenda.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarObservacaoVenda.TabIndex = 26
        Me.btnProcurarObservacaoVenda.TabStop = False
        Me.btnProcurarObservacaoVenda.UseVisualStyleBackColor = True
        '
        'grdVendedor
        '
        Me.grdVendedor.AlternatingColors = True
        Me.grdVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVendedor.AutoEdit = True
        Me.grdVendedor.ColumnAutoResize = True
        grdVendedor_DesignTimeLayout.LayoutString = resources.GetString("grdVendedor_DesignTimeLayout.LayoutString")
        Me.grdVendedor.DesignTimeLayout = grdVendedor_DesignTimeLayout
        Me.grdVendedor.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdVendedor.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdVendedor.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVendedor.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVendedor.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVendedor.GroupByBoxVisible = False
        Me.grdVendedor.Location = New System.Drawing.Point(280, 140)
        Me.grdVendedor.Name = "grdVendedor"
        Me.grdVendedor.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVendedor.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVendedor.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVendedor.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVendedor.Size = New System.Drawing.Size(385, 176)
        Me.grdVendedor.TabIndex = 30
        Me.grdVendedor.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdVendedor.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVendedor.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdVendedor.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdVendedor.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdVendedor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVendedor.VisualStyleManager = Me.vsmMain
        '
        'txtReferencia
        '
        Me.txtReferencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(9, 79)
        Me.txtReferencia.MaxLength = 500
        Me.txtReferencia.Multiline = True
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReferencia.Size = New System.Drawing.Size(656, 29)
        Me.txtReferencia.TabIndex = 4
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(6, 62)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(63, 14)
        Me.lblReferencia.TabIndex = 3
        Me.lblReferencia.Text = "Referência:"
        '
        'cboTransportadora
        '
        Me.cboTransportadora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTransportadora.AutoSize = False
        Me.cboTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTransportadora.Location = New System.Drawing.Point(9, 37)
        Me.cboTransportadora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTransportadora.Name = "cboTransportadora"
        Me.cboTransportadora.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTransportadora.Size = New System.Drawing.Size(656, 20)
        Me.cboTransportadora.TabIndex = 2
        '
        'lblTransportadora
        '
        Me.lblTransportadora.AutoSize = True
        Me.lblTransportadora.Location = New System.Drawing.Point(25, 20)
        Me.lblTransportadora.Name = "lblTransportadora"
        Me.lblTransportadora.Size = New System.Drawing.Size(85, 14)
        Me.lblTransportadora.TabIndex = 1
        Me.lblTransportadora.Text = "Transportadora:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(9, 140)
        Me.txtObservacao.MaxLength = 5000
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(265, 176)
        Me.txtObservacao.TabIndex = 7
        '
        'lblObservacao
        '
        Me.lblObservacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(25, 122)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 6
        Me.lblObservacao.Text = "Observação:"
        '
        'btnCadastrarTransportadora
        '
        Me.btnCadastrarTransportadora.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTransportadora.Image = CType(resources.GetObject("btnCadastrarTransportadora.Image"), System.Drawing.Image)
        Me.btnCadastrarTransportadora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTransportadora.Location = New System.Drawing.Point(9, 20)
        Me.btnCadastrarTransportadora.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTransportadora.Name = "btnCadastrarTransportadora"
        Me.btnCadastrarTransportadora.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTransportadora.TabIndex = 0
        Me.btnCadastrarTransportadora.TabStop = False
        Me.btnCadastrarTransportadora.UseVisualStyleBackColor = True
        '
        'btnProcurarTransportadora
        '
        Me.btnProcurarTransportadora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarTransportadora.FlatAppearance.BorderSize = 0
        Me.btnProcurarTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarTransportadora.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarTransportadora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarTransportadora.Location = New System.Drawing.Point(648, 19)
        Me.btnProcurarTransportadora.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarTransportadora.Name = "btnProcurarTransportadora"
        Me.btnProcurarTransportadora.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarTransportadora.TabIndex = 8
        Me.btnProcurarTransportadora.TabStop = False
        Me.btnProcurarTransportadora.UseVisualStyleBackColor = True
        '
        'grpTotal
        '
        Me.grpTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTotal.BackColor = System.Drawing.Color.Transparent
        Me.grpTotal.Controls.Add(Me.txtValorIPI)
        Me.grpTotal.Controls.Add(Me.lblValorIPI)
        Me.grpTotal.Controls.Add(Me.lblFormaPagamento)
        Me.grpTotal.Controls.Add(Me.cboFormaPagamento)
        Me.grpTotal.Controls.Add(Me.txtValorFinalPedido)
        Me.grpTotal.Controls.Add(Me.lblValorFinalPedido)
        Me.grpTotal.Controls.Add(Me.txtValorTotalPedido)
        Me.grpTotal.Controls.Add(Me.lblValorTotalOrcamento)
        Me.grpTotal.Controls.Add(Me.lblModalidadeFrete)
        Me.grpTotal.Controls.Add(Me.lblCondicaoPagamento)
        Me.grpTotal.Controls.Add(Me.cboModalidadeFrete)
        Me.grpTotal.Controls.Add(Me.cboCondicaoPagamento)
        Me.grpTotal.Controls.Add(Me.btnCadastrarCondicaoPagamento)
        Me.grpTotal.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpTotal.Location = New System.Drawing.Point(692, 3)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTotal.Size = New System.Drawing.Size(280, 326)
        Me.grpTotal.TabIndex = 1
        Me.grpTotal.Text = "Totais"
        Me.grpTotal.VisualStyleManager = Me.vsmMain
        '
        'txtValorIPI
        '
        Me.txtValorIPI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtValorIPI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorIPI.DecimalDigits = 2
        Me.txtValorIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorIPI.Location = New System.Drawing.Point(131, 199)
        Me.txtValorIPI.Name = "txtValorIPI"
        Me.txtValorIPI.Size = New System.Drawing.Size(141, 20)
        Me.txtValorIPI.TabIndex = 10
        Me.txtValorIPI.TabStop = False
        Me.txtValorIPI.Text = "0,00"
        Me.txtValorIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorIPI
        '
        Me.lblValorIPI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblValorIPI.AutoSize = True
        Me.lblValorIPI.Location = New System.Drawing.Point(6, 202)
        Me.lblValorIPI.Name = "lblValorIPI"
        Me.lblValorIPI.Size = New System.Drawing.Size(48, 14)
        Me.lblValorIPI.TabIndex = 9
        Me.lblValorIPI.Text = "Valor IPI:"
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = true
        Me.lblFormaPagamento.Location = New System.Drawing.Point(6, 99)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblFormaPagamento.TabIndex = 5
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cboFormaPagamento.AutoSize = false
        Me.cboFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaPagamento.Location = New System.Drawing.Point(9, 116)
        Me.cboFormaPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaPagamento.Size = New System.Drawing.Size(263, 20)
        Me.cboFormaPagamento.TabIndex = 6
        '
        'txtValorFinalPedido
        '
        Me.txtValorFinalPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.txtValorFinalPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorFinalPedido.DecimalDigits = 2
        Me.txtValorFinalPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorFinalPedido.Location = New System.Drawing.Point(131, 170)
        Me.txtValorFinalPedido.Name = "txtValorFinalPedido"
        Me.txtValorFinalPedido.Size = New System.Drawing.Size(141, 20)
        Me.txtValorFinalPedido.TabIndex = 14
        Me.txtValorFinalPedido.TabStop = false
        Me.txtValorFinalPedido.Text = "0,00"
        Me.txtValorFinalPedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFinalPedido
        '
        Me.lblValorFinalPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblValorFinalPedido.AutoSize = true
        Me.lblValorFinalPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValorFinalPedido.Location = New System.Drawing.Point(6, 173)
        Me.lblValorFinalPedido.Name = "lblValorFinalPedido"
        Me.lblValorFinalPedido.Size = New System.Drawing.Size(66, 14)
        Me.lblValorFinalPedido.TabIndex = 13
        Me.lblValorFinalPedido.Text = "Valor Final:"
        '
        'txtValorTotalPedido
        '
        Me.txtValorTotalPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtValorTotalPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotalPedido.DecimalDigits = 2
        Me.txtValorTotalPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorTotalPedido.Location = New System.Drawing.Point(131, 144)
        Me.txtValorTotalPedido.Name = "txtValorTotalPedido"
        Me.txtValorTotalPedido.Size = New System.Drawing.Size(141, 20)
        Me.txtValorTotalPedido.TabIndex = 8
        Me.txtValorTotalPedido.TabStop = false
        Me.txtValorTotalPedido.Text = "0,00"
        Me.txtValorTotalPedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTotalOrcamento
        '
        Me.lblValorTotalOrcamento.AutoSize = true
        Me.lblValorTotalOrcamento.Location = New System.Drawing.Point(6, 147)
        Me.lblValorTotalOrcamento.Name = "lblValorTotalOrcamento"
        Me.lblValorTotalOrcamento.Size = New System.Drawing.Size(49, 14)
        Me.lblValorTotalOrcamento.TabIndex = 7
        Me.lblValorTotalOrcamento.Text = "Subtotal:"
        '
        'lblModalidadeFrete
        '
        Me.lblModalidadeFrete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblModalidadeFrete.AutoSize = true
        Me.lblModalidadeFrete.Location = New System.Drawing.Point(6, 17)
        Me.lblModalidadeFrete.Name = "lblModalidadeFrete"
        Me.lblModalidadeFrete.Size = New System.Drawing.Size(107, 14)
        Me.lblModalidadeFrete.TabIndex = 0
        Me.lblModalidadeFrete.Text = "Modalidade de Frete:"
        '
        'lblCondicaoPagamento
        '
        Me.lblCondicaoPagamento.AutoSize = true
        Me.lblCondicaoPagamento.Location = New System.Drawing.Point(25, 59)
        Me.lblCondicaoPagamento.Name = "lblCondicaoPagamento"
        Me.lblCondicaoPagamento.Size = New System.Drawing.Size(126, 14)
        Me.lblCondicaoPagamento.TabIndex = 3
        Me.lblCondicaoPagamento.Text = "Condição de Pagamento:"
        '
        'cboModalidadeFrete
        '
        Me.cboModalidadeFrete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cboModalidadeFrete.AutoSize = false
        Me.cboModalidadeFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeFrete.Location = New System.Drawing.Point(9, 34)
        Me.cboModalidadeFrete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModalidadeFrete.Name = "cboModalidadeFrete"
        Me.cboModalidadeFrete.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeFrete.Size = New System.Drawing.Size(263, 20)
        Me.cboModalidadeFrete.TabIndex = 1
        '
        'cboCondicaoPagamento
        '
        Me.cboCondicaoPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cboCondicaoPagamento.AutoSize = false
        Me.cboCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCondicaoPagamento.Location = New System.Drawing.Point(9, 76)
        Me.cboCondicaoPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCondicaoPagamento.Name = "cboCondicaoPagamento"
        Me.cboCondicaoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCondicaoPagamento.Size = New System.Drawing.Size(263, 20)
        Me.cboCondicaoPagamento.TabIndex = 4
        '
        'btnCadastrarCondicaoPagamento
        '
        Me.btnCadastrarCondicaoPagamento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCondicaoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCondicaoPagamento.Image = CType(resources.GetObject("btnCadastrarCondicaoPagamento.Image"),System.Drawing.Image)
        Me.btnCadastrarCondicaoPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCondicaoPagamento.Location = New System.Drawing.Point(9, 60)
        Me.btnCadastrarCondicaoPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCondicaoPagamento.Name = "btnCadastrarCondicaoPagamento"
        Me.btnCadastrarCondicaoPagamento.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCondicaoPagamento.TabIndex = 2
        Me.btnCadastrarCondicaoPagamento.TabStop = false
        Me.btnCadastrarCondicaoPagamento.UseVisualStyleBackColor = true
        '
        'pagProducao
        '
        Me.pagProducao.Controls.Add(Me.grdProducao)
        Me.pagProducao.Location = New System.Drawing.Point(1, 22)
        Me.pagProducao.Name = "pagProducao"
        Me.pagProducao.Size = New System.Drawing.Size(980, 338)
        Me.pagProducao.TabStop = true
        Me.pagProducao.Text = "Produção"
        '
        'grdProducao
        '
        Me.grdProducao.AllowChildTableGroups = true
        Me.grdProducao.AlternatingColors = true
        Me.grdProducao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grdProducao.AutoEdit = true
        grdProducao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProducao_DesignTimeLayout_Reference_0.Instance"),Object)
        grdProducao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProducao_DesignTimeLayout_Reference_0})
        grdProducao_DesignTimeLayout.LayoutString = resources.GetString("grdProducao_DesignTimeLayout.LayoutString")
        Me.grdProducao.DesignTimeLayout = grdProducao_DesignTimeLayout
        Me.grdProducao.DynamicFiltering = true
        Me.grdProducao.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProducao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProducao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProducao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProducao.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProducao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProducao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProducao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProducao.GroupByBoxVisible = false
        Me.grdProducao.Hierarchical = true
        Me.grdProducao.Location = New System.Drawing.Point(8, 10)
        Me.grdProducao.Name = "grdProducao"
        Me.grdProducao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProducao.RecordNavigator = true
        Me.grdProducao.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdProducao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProducao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProducao.Size = New System.Drawing.Size(964, 321)
        Me.grdProducao.TabIndex = 4
        Me.grdProducao.TabStop = false
        Me.grdProducao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProducao.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdProducao.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdProducao.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdProducao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProducao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProducao.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdProducao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProducao.VisualStyleManager = Me.vsmMain
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 1
        Me.jstTip.BodyWidth = 400
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 1
        Me.jstTip.ShowAlways = true
        '
        'usrVenPedidoLegado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrVenPedidoLegado"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagListagem.ResumeLayout(false)
        CType(Me.grpLegenda,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpLegenda.ResumeLayout(false)
        Me.grpLegenda.PerformLayout
        CType(Me.picParcialmenteEntregue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picEntregue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picLegendaCancelado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picLegendaTipoOrcamento,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpFiltro,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFiltro.ResumeLayout(false)
        Me.grpFiltro.PerformLayout
        CType(Me.grpControle,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControle.ResumeLayout(false)
        Me.pagDados.ResumeLayout(false)
        CType(Me.grpGerarOP,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpGerarOP.ResumeLayout(false)
        Me.grpGerarOP.PerformLayout
        CType(Me.grpInformacoes,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpInformacoes.ResumeLayout(false)
        Me.grpInformacoes.PerformLayout
        CType(Me.grdControlesEdicao,System.ComponentModel.ISupportInitialize).EndInit
        Me.grdControlesEdicao.ResumeLayout(false)
        CType(Me.tabDados,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabDados.ResumeLayout(false)
        Me.pagProduto.ResumeLayout(false)
        CType(Me.grdProduto,System.ComponentModel.ISupportInitialize).EndInit
        Me.pagArquivo.ResumeLayout(false)
        CType(Me.grpArquivo,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpArquivo.ResumeLayout(false)
        Me.grpArquivo.PerformLayout
        CType(Me.grdArquivo,System.ComponentModel.ISupportInitialize).EndInit
        Me.pagDadosGerais.ResumeLayout(false)
        CType(Me.grpDadosVenda,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDadosVenda.ResumeLayout(false)
        Me.grpDadosVenda.PerformLayout
        CType(Me.grdVendedor,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpTotal,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpTotal.ResumeLayout(false)
        Me.grpTotal.PerformLayout
        Me.pagProducao.ResumeLayout(false)
        CType(Me.grdProducao,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

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
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarCliente As System.Windows.Forms.Button
    Friend WithEvents lblDataPedido As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Private WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedidoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedidoClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblRequerente As System.Windows.Forms.Label
    Friend WithEvents grpTotal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorFinalPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFinalPedido As System.Windows.Forms.Label
    Friend WithEvents txtValorTotalPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotalOrcamento As System.Windows.Forms.Label
    Friend WithEvents lblCondicaoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboCondicaoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarCondicaoPagamento As System.Windows.Forms.Button
    Friend WithEvents grpDadosVenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdVendedor As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents cboTransportadora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTransportadora As System.Windows.Forms.Label
    Friend WithEvents lblModalidadeFrete As System.Windows.Forms.Label
    Friend WithEvents cboModalidadeFrete As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarTransportadora As System.Windows.Forms.Button
    Friend WithEvents btnProcurarObservacaoVenda As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblParcialmenteEntregue As System.Windows.Forms.Label
    Friend WithEvents picParcialmenteEntregue As System.Windows.Forms.PictureBox
    Friend WithEvents lblEntregue As System.Windows.Forms.Label
    Friend WithEvents picEntregue As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelado As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents picLegendaTipoOrcamento As System.Windows.Forms.PictureBox
    Friend WithEvents dtpDataPedidoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPedidoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPedido As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnCadastrarObservacaoVenda As System.Windows.Forms.Button
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblTipoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents btnProcurarTransportadora As System.Windows.Forms.Button
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblItemFiltro As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItemFiltro As System.Windows.Forms.Button
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarClienteFiltro As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtTituloArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTituloArquivo As System.Windows.Forms.Label
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents cboItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboTipoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtComprador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtValorIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorIPI As System.Windows.Forms.Label
    Friend WithEvents pagProducao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdProducao As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnRegistroAnterior As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProximoRegistro As Janus.Windows.EditControls.UIButton
    Private WithEvents btnGerarForeCast As Janus.Windows.EditControls.UIButton
    Private WithEvents btnGerarOrdemProducao As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkAgrupar As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grpGerarOP As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblItemPai As System.Windows.Forms.Label
    Friend WithEvents cboItemPai As Janus.Windows.EditControls.UIComboBox
    Private WithEvents btnCriarItemFantasma As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroOrcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrcamento As System.Windows.Forms.Label

End Class
