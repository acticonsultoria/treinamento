<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatAlteracaoEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatAlteracaoEntrada))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaOrdemProducao = New System.Windows.Forms.Label()
        Me.picLegendaOrdemProducao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaDevolucao = New System.Windows.Forms.Label()
        Me.picLegendaDevolucao = New System.Windows.Forms.PictureBox()
        Me.picLegendaAutozidadaParaUso = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPedidoCompra = New System.Windows.Forms.Label()
        Me.picLegendaCancelada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEntradaNotaFiscal = New System.Windows.Forms.Label()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.grpControleListagem = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControleEditar = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.grpAlterar = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarLote = New System.Windows.Forms.Button()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboNumeroDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProdutoAlterar = New System.Windows.Forms.Label()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtQuantidadeNF = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeNF = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.txtFornecedor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblData = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaOrdemProducao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaDevolucao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControleListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grpControleEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleEditar.SuspendLayout()
        CType(Me.grpAlterar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAlterar.SuspendLayout()
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
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(946, 566)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControleListagem)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Key = "pagTabela"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(944, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Entrada"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaOrdemProducao)
        Me.grpLegenda.Controls.Add(Me.picLegendaOrdemProducao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaDevolucao)
        Me.grpLegenda.Controls.Add(Me.picLegendaDevolucao)
        Me.grpLegenda.Controls.Add(Me.picLegendaAutozidadaParaUso)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoCompra)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEntradaNotaFiscal)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(297, 51)
        Me.grpLegenda.TabIndex = 92
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaOrdemProducao
        '
        Me.lblLegendaOrdemProducao.AutoSize = True
        Me.lblLegendaOrdemProducao.Location = New System.Drawing.Point(169, 32)
        Me.lblLegendaOrdemProducao.Name = "lblLegendaOrdemProducao"
        Me.lblLegendaOrdemProducao.Size = New System.Drawing.Size(103, 14)
        Me.lblLegendaOrdemProducao.TabIndex = 19
        Me.lblLegendaOrdemProducao.Text = "Ordem de Produção"
        '
        'picLegendaOrdemProducao
        '
        Me.picLegendaOrdemProducao.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaOrdemProducao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaOrdemProducao.Location = New System.Drawing.Point(150, 32)
        Me.picLegendaOrdemProducao.Name = "picLegendaOrdemProducao"
        Me.picLegendaOrdemProducao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaOrdemProducao.TabIndex = 20
        Me.picLegendaOrdemProducao.TabStop = False
        '
        'lblLegendaDevolucao
        '
        Me.lblLegendaDevolucao.AutoSize = True
        Me.lblLegendaDevolucao.Location = New System.Drawing.Point(169, 15)
        Me.lblLegendaDevolucao.Name = "lblLegendaDevolucao"
        Me.lblLegendaDevolucao.Size = New System.Drawing.Size(99, 14)
        Me.lblLegendaDevolucao.TabIndex = 17
        Me.lblLegendaDevolucao.Text = "Devolução de NF-e"
        '
        'picLegendaDevolucao
        '
        Me.picLegendaDevolucao.BackColor = System.Drawing.Color.Purple
        Me.picLegendaDevolucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaDevolucao.Location = New System.Drawing.Point(150, 15)
        Me.picLegendaDevolucao.Name = "picLegendaDevolucao"
        Me.picLegendaDevolucao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaDevolucao.TabIndex = 18
        Me.picLegendaDevolucao.TabStop = False
        '
        'picLegendaAutozidadaParaUso
        '
        Me.picLegendaAutozidadaParaUso.BackColor = System.Drawing.Color.Black
        Me.picLegendaAutozidadaParaUso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAutozidadaParaUso.Location = New System.Drawing.Point(9, 15)
        Me.picLegendaAutozidadaParaUso.Name = "picLegendaAutozidadaParaUso"
        Me.picLegendaAutozidadaParaUso.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAutozidadaParaUso.TabIndex = 16
        Me.picLegendaAutozidadaParaUso.TabStop = False
        '
        'lblLegendaPedidoCompra
        '
        Me.lblLegendaPedidoCompra.AutoSize = True
        Me.lblLegendaPedidoCompra.Location = New System.Drawing.Point(28, 32)
        Me.lblLegendaPedidoCompra.Name = "lblLegendaPedidoCompra"
        Me.lblLegendaPedidoCompra.Size = New System.Drawing.Size(94, 14)
        Me.lblLegendaPedidoCompra.TabIndex = 1
        Me.lblLegendaPedidoCompra.Text = "Pedido de Compra"
        '
        'picLegendaCancelada
        '
        Me.picLegendaCancelada.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaCancelada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelada.Location = New System.Drawing.Point(9, 32)
        Me.picLegendaCancelada.Name = "picLegendaCancelada"
        Me.picLegendaCancelada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelada.TabIndex = 14
        Me.picLegendaCancelada.TabStop = False
        '
        'lblLegendaEntradaNotaFiscal
        '
        Me.lblLegendaEntradaNotaFiscal.AutoSize = True
        Me.lblLegendaEntradaNotaFiscal.Location = New System.Drawing.Point(28, 15)
        Me.lblLegendaEntradaNotaFiscal.Name = "lblLegendaEntradaNotaFiscal"
        Me.lblLegendaEntradaNotaFiscal.Size = New System.Drawing.Size(115, 14)
        Me.lblLegendaEntradaNotaFiscal.TabIndex = 0
        Me.lblLegendaEntradaNotaFiscal.Text = "Entrada de Nota Fiscal"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 460)
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 460)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 89
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 460)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 88
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(928, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(561, 34)
        Me.txtProdutoFiltro.MaxLength = 20
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(230, 20)
        Me.txtProdutoFiltro.TabIndex = 35
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(558, 17)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 34
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(341, 34)
        Me.txtFornecedorFiltro.MaxLength = 20
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(214, 20)
        Me.txtFornecedorFiltro.TabIndex = 33
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(338, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 32
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(101, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataInicioFiltro.TabIndex = 28
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(216, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(119, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 29
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(98, 17)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 27
        Me.lblDataFiltro.Text = "Data:"
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscalFiltro.MaxLength = 20
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(86, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 26
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(828, 29)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 23
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblNotaFiscalFiltro
        '
        Me.lblNotaFiscalFiltro.AutoSize = True
        Me.lblNotaFiscalFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNotaFiscalFiltro.Name = "lblNotaFiscalFiltro"
        Me.lblNotaFiscalFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalFiltro.TabIndex = 0
        Me.lblNotaFiscalFiltro.Text = "Nota Fiscal:"
        '
        'grpControleListagem
        '
        Me.grpControleListagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleListagem.BackColor = System.Drawing.Color.Transparent
        Me.grpControleListagem.Controls.Add(Me.btnSair)
        Me.grpControleListagem.Location = New System.Drawing.Point(311, 483)
        Me.grpControleListagem.Name = "grpControleListagem"
        Me.grpControleListagem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleListagem.Size = New System.Drawing.Size(625, 51)
        Me.grpControleListagem.TabIndex = 5
        Me.grpControleListagem.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControleListagem.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(525, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 74)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(928, 403)
        Me.grdListagem.TabIndex = 91
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
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpControleEditar)
        Me.pagDados.Controls.Add(Me.grpAlterar)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(944, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados Entrada"
        '
        'grpControleEditar
        '
        Me.grpControleEditar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleEditar.BackColor = System.Drawing.Color.Transparent
        Me.grpControleEditar.Controls.Add(Me.btnSalvar)
        Me.grpControleEditar.Controls.Add(Me.btnVoltar)
        Me.grpControleEditar.Location = New System.Drawing.Point(8, 483)
        Me.grpControleEditar.Name = "grpControleEditar"
        Me.grpControleEditar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleEditar.Size = New System.Drawing.Size(928, 51)
        Me.grpControleEditar.TabIndex = 43
        Me.grpControleEditar.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControleEditar.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSalvar.Location = New System.Drawing.Point(731, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnVoltar.Location = New System.Drawing.Point(828, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpAlterar
        '
        Me.grpAlterar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAlterar.BackColor = System.Drawing.Color.Transparent
        Me.grpAlterar.Controls.Add(Me.btnProcurarLote)
        Me.grpAlterar.Controls.Add(Me.txtLote)
        Me.grpAlterar.Controls.Add(Me.lblLote)
        Me.grpAlterar.Controls.Add(Me.cboDeposito)
        Me.grpAlterar.Controls.Add(Me.lblDeposito)
        Me.grpAlterar.Controls.Add(Me.cboNumeroDocumento)
        Me.grpAlterar.Controls.Add(Me.txtQuantidade)
        Me.grpAlterar.Controls.Add(Me.lblQuantidade)
        Me.grpAlterar.Controls.Add(Me.cboProduto)
        Me.grpAlterar.Controls.Add(Me.lblProdutoAlterar)
        Me.grpAlterar.Controls.Add(Me.cboOperacao)
        Me.grpAlterar.Controls.Add(Me.lblNumeroDocumento)
        Me.grpAlterar.Controls.Add(Me.lblOperacao)
        Me.grpAlterar.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpAlterar.Location = New System.Drawing.Point(8, 116)
        Me.grpAlterar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAlterar.Name = "grpAlterar"
        Me.grpAlterar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAlterar.Size = New System.Drawing.Size(928, 111)
        Me.grpAlterar.TabIndex = 0
        Me.grpAlterar.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarLote
        '
        Me.btnProcurarLote.FlatAppearance.BorderSize = 0
        Me.btnProcurarLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarLote.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarLote.Location = New System.Drawing.Point(418, 59)
        Me.btnProcurarLote.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarLote.Name = "btnProcurarLote"
        Me.btnProcurarLote.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarLote.TabIndex = 44
        Me.btnProcurarLote.TabStop = False
        Me.btnProcurarLote.UseVisualStyleBackColor = True
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(221, 78)
        Me.txtLote.MaxLength = 20
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(214, 20)
        Me.txtLote.TabIndex = 35
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(218, 61)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 34
        Me.lblLote.Text = "Lote:"
        '
        'cboDeposito
        '
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cboDeposito.Location = New System.Drawing.Point(9, 78)
        Me.cboDeposito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(206, 20)
        Me.cboDeposito.TabIndex = 11
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.Location = New System.Drawing.Point(6, 61)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 10
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboNumeroDocumento
        '
        Me.cboNumeroDocumento.AutoSize = False
        Me.cboNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroDocumento.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cboNumeroDocumento.Location = New System.Drawing.Point(221, 34)
        Me.cboNumeroDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNumeroDocumento.Name = "cboNumeroDocumento"
        Me.cboNumeroDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroDocumento.Size = New System.Drawing.Size(131, 20)
        Me.cboNumeroDocumento.TabIndex = 5
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.White
        Me.txtQuantidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(826, 34)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(93, 20)
        Me.txtQuantidade.TabIndex = 9
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(823, 17)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 8
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'cboProduto
        '
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProduto.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cboProduto.Location = New System.Drawing.Point(358, 34)
        Me.cboProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(462, 20)
        Me.cboProduto.TabIndex = 7
        '
        'lblProdutoAlterar
        '
        Me.lblProdutoAlterar.AutoSize = True
        Me.lblProdutoAlterar.Location = New System.Drawing.Point(355, 17)
        Me.lblProdutoAlterar.Name = "lblProdutoAlterar"
        Me.lblProdutoAlterar.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoAlterar.TabIndex = 6
        Me.lblProdutoAlterar.Text = "Produto:"
        '
        'cboOperacao
        '
        Me.cboOperacao.AutoSize = False
        Me.cboOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOperacao.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cboOperacao.Location = New System.Drawing.Point(9, 34)
        Me.cboOperacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOperacao.Size = New System.Drawing.Size(206, 20)
        Me.cboOperacao.TabIndex = 3
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(218, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroDocumento.TabIndex = 4
        Me.lblNumeroDocumento.Text = "N° Documento:"
        '
        'lblOperacao
        '
        Me.lblOperacao.AutoSize = True
        Me.lblOperacao.Location = New System.Drawing.Point(6, 17)
        Me.lblOperacao.Name = "lblOperacao"
        Me.lblOperacao.Size = New System.Drawing.Size(81, 14)
        Me.lblOperacao.TabIndex = 2
        Me.lblOperacao.Text = "Tipo Operação:"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtValorTotal)
        Me.grpDados.Controls.Add(Me.lblValorTotal)
        Me.grpDados.Controls.Add(Me.txtQuantidadeNF)
        Me.grpDados.Controls.Add(Me.lblQuantidadeNF)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.cboCFOP)
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.lblCFOP)
        Me.grpDados.Controls.Add(Me.txtFornecedor)
        Me.grpDados.Controls.Add(Me.lblFornecedor)
        Me.grpDados.Controls.Add(Me.dtpData)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.txtNotaFiscal)
        Me.grpDados.Controls.Add(Me.lblNotaFiscal)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(928, 105)
        Me.grpDados.TabIndex = 1
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(516, 74)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(132, 20)
        Me.txtValorTotal.TabIndex = 13
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(513, 57)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(84, 14)
        Me.lblValorTotal.TabIndex = 12
        Me.lblValorTotal.Text = "Valor Total (R$):"
        '
        'txtQuantidadeNF
        '
        Me.txtQuantidadeNF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeNF.Enabled = False
        Me.txtQuantidadeNF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeNF.Location = New System.Drawing.Point(417, 74)
        Me.txtQuantidadeNF.Name = "txtQuantidadeNF"
        Me.txtQuantidadeNF.ReadOnly = True
        Me.txtQuantidadeNF.Size = New System.Drawing.Size(93, 20)
        Me.txtQuantidadeNF.TabIndex = 11
        Me.txtQuantidadeNF.Text = "0,00"
        Me.txtQuantidadeNF.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidadeNF
        '
        Me.lblQuantidadeNF.AutoSize = True
        Me.lblQuantidadeNF.Location = New System.Drawing.Point(414, 57)
        Me.lblQuantidadeNF.Name = "lblQuantidadeNF"
        Me.lblQuantidadeNF.Size = New System.Drawing.Size(81, 14)
        Me.lblQuantidadeNF.TabIndex = 10
        Me.lblQuantidadeNF.Text = "Quantidade NF:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 74)
        Me.txtDescricao.MaxLength = 20
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(402, 20)
        Me.txtDescricao.TabIndex = 9
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 57)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 8
        Me.lblDescricao.Text = "Descrição:"
        '
        'cboCFOP
        '
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCFOP.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cboCFOP.Location = New System.Drawing.Point(654, 74)
        Me.cboCFOP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(77, 20)
        Me.cboCFOP.TabIndex = 1
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(718, 33)
        Me.txtProduto.MaxLength = 20
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(204, 20)
        Me.txtProduto.TabIndex = 7
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(715, 16)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 6
        Me.lblProduto.Text = "Produto:"
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.Location = New System.Drawing.Point(651, 57)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 0
        Me.lblCFOP.Text = "CFOP:"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedor.Location = New System.Drawing.Point(252, 33)
        Me.txtFornecedor.MaxLength = 20
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.ReadOnly = True
        Me.txtFornecedor.Size = New System.Drawing.Size(460, 20)
        Me.txtFornecedor.TabIndex = 5
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(249, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 4
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'dtpData
        '
        Me.dtpData.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(146, 33)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.ReadOnly = True
        Me.dtpData.Size = New System.Drawing.Size(100, 20)
        Me.dtpData.TabIndex = 3
        Me.dtpData.Value = New Date(2016, 8, 12, 14, 46, 51, 0)
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(143, 16)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = "Data:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscal.MaxLength = 20
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.ReadOnly = True
        Me.txtNotaFiscal.Size = New System.Drawing.Size(131, 20)
        Me.txtNotaFiscal.TabIndex = 1
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(6, 17)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscal.TabIndex = 0
        Me.lblNotaFiscal.Text = "Nota Fiscal:"
        '
        'usrFatAlteracaoEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatAlteracaoEntrada"
        Me.Size = New System.Drawing.Size(946, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaOrdemProducao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaDevolucao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControleListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControleEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleEditar.ResumeLayout(False)
        CType(Me.grpAlterar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAlterar.ResumeLayout(False)
        Me.grpAlterar.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControleListagem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents txtFornecedor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeNF As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeNF As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents grpAlterar As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents lblCFOP As System.Windows.Forms.Label
    Friend WithEvents cboCFOP As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblProdutoAlterar As System.Windows.Forms.Label
    Friend WithEvents grpControleEditar As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents cboNumeroDocumento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents btnProcurarLote As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaAutozidadaParaUso As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPedidoCompra As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEntradaNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents lblLegendaOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents picLegendaOrdemProducao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaDevolucao As System.Windows.Forms.Label
    Friend WithEvents picLegendaDevolucao As System.Windows.Forms.PictureBox

End Class
