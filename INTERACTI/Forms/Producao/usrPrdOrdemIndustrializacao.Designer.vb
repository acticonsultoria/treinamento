<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdOrdemIndustrializacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdOrdemIndustrializacao))
        Dim grdItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdItem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdItem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPedidoCompra = New System.Windows.Forms.Label()
        Me.picLegendaTipoOrcamento = New System.Windows.Forms.PictureBox()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataOrcamentoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoFiltro = New System.Windows.Forms.Label()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grdItem = New Janus.Windows.GridEX.GridEX()
        Me.btnInserirItem = New Janus.Windows.EditControls.UIButton()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirItem = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMateriaPrima = New Janus.Windows.EditControls.UIComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboOrdemProducao = New Janus.Windows.EditControls.UIComboBox()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosCompra = New Janus.Windows.EditControls.UIGroupBox()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorDesonto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCondicaoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarCondicaoPagamento = New System.Windows.Forms.Button()
        Me.txtValorFinalPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCondicaoPagamento = New System.Windows.Forms.Label()
        Me.lblValorFinalPedido = New System.Windows.Forms.Label()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.cboFormaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboCentroTrabalho = New Janus.Windows.EditControls.UIComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboModalidadeFrete = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeFrete = New System.Windows.Forms.Label()
        Me.cboModalidadeTransporte = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarModalidadeTransporte = New System.Windows.Forms.Button()
        Me.lblModalidadeTransporte = New System.Windows.Forms.Label()
        Me.txtValorFretePedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboTransportadora = New Janus.Windows.EditControls.UIComboBox()
        Me.lblValorFretePedido = New System.Windows.Forms.Label()
        Me.btnCadastrarTransportadora = New System.Windows.Forms.Button()
        Me.lblTransportadora = New System.Windows.Forms.Label()
        Me.txtLocalEntrega = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLocalEntrega = New System.Windows.Forms.Label()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnGerarPedidoCompra = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEntrega = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataOrcamento = New System.Windows.Forms.Label()
        Me.txtNumeroOrdem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.btnAgruparGridServico = New System.Windows.Forms.Button()
        Me.btnConfigurarGridServico = New System.Windows.Forms.Button()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagProduto.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpDadosCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosCompra.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1110, 551)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(1108, 528)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Ordem de Industrialização"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.Label9)
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoCompra)
        Me.grpLegenda.Controls.Add(Me.picLegendaTipoOrcamento)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 468)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(302, 51)
        Me.grpLegenda.TabIndex = 87
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Ordem de Industrialização"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(13, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblLegendaPedidoCompra
        '
        Me.lblLegendaPedidoCompra.AutoSize = True
        Me.lblLegendaPedidoCompra.Location = New System.Drawing.Point(194, 21)
        Me.lblLegendaPedidoCompra.Name = "lblLegendaPedidoCompra"
        Me.lblLegendaPedidoCompra.Size = New System.Drawing.Size(79, 14)
        Me.lblLegendaPedidoCompra.TabIndex = 0
        Me.lblLegendaPedidoCompra.Text = "Pedido Compra"
        '
        'picLegendaTipoOrcamento
        '
        Me.picLegendaTipoOrcamento.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaTipoOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaTipoOrcamento.Location = New System.Drawing.Point(175, 21)
        Me.picLegendaTipoOrcamento.Name = "picLegendaTipoOrcamento"
        Me.picLegendaTipoOrcamento.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaTipoOrcamento.TabIndex = 4
        Me.picLegendaTipoOrcamento.TabStop = False
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(33, 448)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 86
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 448)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
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
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1092, 389)
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
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataOrcamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1092, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(135, 33)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 6
        Me.dtpDataInicioFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(249, 33)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 7
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataOrcamentoFiltro
        '
        Me.lblDataOrcamentoFiltro.AutoSize = True
        Me.lblDataOrcamentoFiltro.Location = New System.Drawing.Point(132, 16)
        Me.lblDataOrcamentoFiltro.Name = "lblDataOrcamentoFiltro"
        Me.lblDataOrcamentoFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataOrcamentoFiltro.TabIndex = 5
        Me.lblDataOrcamentoFiltro.Text = "Data:"
        '
        'txtNumeroFiltro
        '
        Me.txtNumeroFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroFiltro.MaxLength = 20
        Me.txtNumeroFiltro.Name = "txtNumeroFiltro"
        Me.txtNumeroFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroFiltro.TabIndex = 1
        '
        'lblCodigoFiltro
        '
        Me.lblCodigoFiltro.AutoSize = True
        Me.lblCodigoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoFiltro.Name = "lblCodigoFiltro"
        Me.lblCodigoFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblCodigoFiltro.TabIndex = 0
        Me.lblCodigoFiltro.Text = "Nº Ordem Ind.:"
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(363, 34)
        Me.txtFornecedorFiltro.MaxLength = 100
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(603, 20)
        Me.txtFornecedorFiltro.TabIndex = 3
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(360, 16)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblDescricaoFiltro.TabIndex = 2
        Me.lblDescricaoFiltro.Text = "Fornecedor:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(992, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 4
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
        Me.grpControl.Location = New System.Drawing.Point(316, 468)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(784, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(490, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(684, 17)
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
        Me.btnExcluir.Location = New System.Drawing.Point(587, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(1108, 528)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados da Ordem"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(8, 84)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(1092, 376)
        Me.tabDados.TabIndex = 38
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagProduto, Me.pagDadosGerais})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagProduto
        '
        Me.pagProduto.Controls.Add(Me.UiGroupBox1)
        Me.pagProduto.Key = "pagItem"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Size = New System.Drawing.Size(1090, 353)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Produto"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtValorTotal)
        Me.UiGroupBox1.Controls.Add(Me.Label6)
        Me.UiGroupBox1.Controls.Add(Me.txtValorUnitario)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.txtQuantidade)
        Me.UiGroupBox1.Controls.Add(Me.grdItem)
        Me.UiGroupBox1.Controls.Add(Me.btnInserirItem)
        Me.UiGroupBox1.Controls.Add(Me.btnArquivo)
        Me.UiGroupBox1.Controls.Add(Me.btnExcluirItem)
        Me.UiGroupBox1.Controls.Add(Me.lblArquivo)
        Me.UiGroupBox1.Controls.Add(Me.txtArquivo)
        Me.UiGroupBox1.Controls.Add(Me.txtLote)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.cboMateriaPrima)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.cboOrdemProducao)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(1074, 338)
        Me.UiGroupBox1.TabIndex = 37
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtValorTotal.DecimalDigits = 6
        Me.txtValorTotal.Location = New System.Drawing.Point(723, 32)
        Me.txtValorTotal.MaxLength = 0
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(111, 20)
        Me.txtValorTotal.TabIndex = 37
        Me.txtValorTotal.Text = "0,000000"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(720, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 14)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Valor Total:"
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.BackColor = System.Drawing.SystemColors.Info
        Me.txtValorUnitario.DecimalDigits = 6
        Me.txtValorUnitario.Location = New System.Drawing.Point(603, 32)
        Me.txtValorUnitario.MaxLength = 0
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(114, 20)
        Me.txtValorUnitario.TabIndex = 35
        Me.txtValorUnitario.Text = "0,000000"
        Me.txtValorUnitario.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(600, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 14)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Valor Unitário:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 6
        Me.txtQuantidade.Location = New System.Drawing.Point(337, 31)
        Me.txtQuantidade.MaxLength = 0
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(99, 20)
        Me.txtQuantidade.TabIndex = 33
        Me.txtQuantidade.Text = "0,000000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'grdItem
        '
        Me.grdItem.AlternatingColors = True
        Me.grdItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItem.ColumnAutoResize = True
        grdItem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdItem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdItem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdItem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdItem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdItem_DesignTimeLayout_Reference_0, grdItem_DesignTimeLayout_Reference_1})
        grdItem_DesignTimeLayout.LayoutString = resources.GetString("grdItem_DesignTimeLayout.LayoutString")
        Me.grdItem.DesignTimeLayout = grdItem_DesignTimeLayout
        Me.grdItem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdItem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdItem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdItem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdItem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdItem.GroupByBoxVisible = False
        Me.grdItem.Location = New System.Drawing.Point(9, 105)
        Me.grdItem.Name = "grdItem"
        Me.grdItem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdItem.RecordNavigator = True
        Me.grdItem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdItem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdItem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdItem.Size = New System.Drawing.Size(1051, 218)
        Me.grdItem.TabIndex = 13
        Me.grdItem.TabStop = False
        Me.grdItem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdItem.VisualStyleManager = Me.vsmMain
        '
        'btnInserirItem
        '
        Me.btnInserirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirItem.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirItem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirItem.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirItem.Location = New System.Drawing.Point(964, 32)
        Me.btnInserirItem.Name = "btnInserirItem"
        Me.btnInserirItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirItem.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirItem.TabIndex = 3
        Me.btnInserirItem.Text = "Inserir"
        Me.btnInserirItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(833, 72)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 12
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirItem
        '
        Me.btnExcluirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirItem.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirItem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirItem.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExcluirItem.Location = New System.Drawing.Point(964, 69)
        Me.btnExcluirItem.Name = "btnExcluirItem"
        Me.btnExcluirItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirItem.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirItem.TabIndex = 4
        Me.btnExcluirItem.Text = "Excluir"
        Me.btnExcluirItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(6, 55)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 10
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(9, 72)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(844, 20)
        Me.txtArquivo.TabIndex = 11
        Me.txtArquivo.TabStop = False
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(442, 31)
        Me.txtLote.MaxLength = 20
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(155, 20)
        Me.txtLote.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(439, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Lote:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Produto:"
        '
        'cboMateriaPrima
        '
        Me.cboMateriaPrima.AutoSize = False
        Me.cboMateriaPrima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboMateriaPrima.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboMateriaPrima.Location = New System.Drawing.Point(170, 32)
        Me.cboMateriaPrima.Name = "cboMateriaPrima"
        Me.cboMateriaPrima.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMateriaPrima.Size = New System.Drawing.Size(161, 20)
        Me.cboMateriaPrima.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Quantidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ordem de Produção:"
        '
        'cboOrdemProducao
        '
        Me.cboOrdemProducao.AutoSize = False
        Me.cboOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboOrdemProducao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboOrdemProducao.Location = New System.Drawing.Point(9, 32)
        Me.cboOrdemProducao.Name = "cboOrdemProducao"
        Me.cboOrdemProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrdemProducao.Size = New System.Drawing.Size(155, 20)
        Me.cboOrdemProducao.TabIndex = 5
        '
        'pagDadosGerais
        '
        Me.pagDadosGerais.Controls.Add(Me.grpDadosCompra)
        Me.pagDadosGerais.Key = "pagDadosGerais"
        Me.pagDadosGerais.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.Size = New System.Drawing.Size(1090, 353)
        Me.pagDadosGerais.TabStop = True
        Me.pagDadosGerais.Text = "Dados da Industrialização"
        '
        'grpDadosCompra
        '
        Me.grpDadosCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosCompra.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosCompra.Controls.Add(Me.UiGroupBox3)
        Me.grpDadosCompra.Controls.Add(Me.UiGroupBox2)
        Me.grpDadosCompra.Controls.Add(Me.txtObservacao)
        Me.grpDadosCompra.Controls.Add(Me.lblObservacao)
        Me.grpDadosCompra.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosCompra.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosCompra.Name = "grpDadosCompra"
        Me.grpDadosCompra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosCompra.Size = New System.Drawing.Size(1067, 347)
        Me.grpDadosCompra.TabIndex = 0
        Me.grpDadosCompra.Text = "Dados de Compra"
        Me.grpDadosCompra.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.txtValorDesonto)
        Me.UiGroupBox3.Controls.Add(Me.Label7)
        Me.UiGroupBox3.Controls.Add(Me.cboCondicaoPagamento)
        Me.UiGroupBox3.Controls.Add(Me.btnCadastrarCondicaoPagamento)
        Me.UiGroupBox3.Controls.Add(Me.txtValorFinalPedido)
        Me.UiGroupBox3.Controls.Add(Me.lblCondicaoPagamento)
        Me.UiGroupBox3.Controls.Add(Me.lblValorFinalPedido)
        Me.UiGroupBox3.Controls.Add(Me.lblFormaPagamento)
        Me.UiGroupBox3.Controls.Add(Me.cboFormaPagamento)
        Me.UiGroupBox3.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox3.Location = New System.Drawing.Point(6, 257)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(1051, 72)
        Me.UiGroupBox3.TabIndex = 37
        Me.UiGroupBox3.Text = "Totais"
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'txtValorDesonto
        '
        Me.txtValorDesonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDesonto.DecimalDigits = 2
        Me.txtValorDesonto.Location = New System.Drawing.Point(542, 40)
        Me.txtValorDesonto.Name = "txtValorDesonto"
        Me.txtValorDesonto.Size = New System.Drawing.Size(140, 20)
        Me.txtValorDesonto.TabIndex = 19
        Me.txtValorDesonto.Text = "0,00"
        Me.txtValorDesonto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(539, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Valor Desconto:"
        '
        'cboCondicaoPagamento
        '
        Me.cboCondicaoPagamento.AutoSize = False
        Me.cboCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCondicaoPagamento.Location = New System.Drawing.Point(6, 40)
        Me.cboCondicaoPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCondicaoPagamento.Name = "cboCondicaoPagamento"
        Me.cboCondicaoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCondicaoPagamento.Size = New System.Drawing.Size(262, 20)
        Me.cboCondicaoPagamento.TabIndex = 2
        '
        'btnCadastrarCondicaoPagamento
        '
        Me.btnCadastrarCondicaoPagamento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCondicaoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCondicaoPagamento.Image = CType(resources.GetObject("btnCadastrarCondicaoPagamento.Image"), System.Drawing.Image)
        Me.btnCadastrarCondicaoPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCondicaoPagamento.Location = New System.Drawing.Point(6, 23)
        Me.btnCadastrarCondicaoPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCondicaoPagamento.Name = "btnCadastrarCondicaoPagamento"
        Me.btnCadastrarCondicaoPagamento.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCondicaoPagamento.TabIndex = 0
        Me.btnCadastrarCondicaoPagamento.TabStop = False
        Me.btnCadastrarCondicaoPagamento.UseVisualStyleBackColor = True
        '
        'txtValorFinalPedido
        '
        Me.txtValorFinalPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorFinalPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorFinalPedido.DecimalDigits = 2
        Me.txtValorFinalPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorFinalPedido.Location = New System.Drawing.Point(688, 40)
        Me.txtValorFinalPedido.Name = "txtValorFinalPedido"
        Me.txtValorFinalPedido.Size = New System.Drawing.Size(140, 20)
        Me.txtValorFinalPedido.TabIndex = 27
        Me.txtValorFinalPedido.TabStop = False
        Me.txtValorFinalPedido.Text = "0,00"
        Me.txtValorFinalPedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCondicaoPagamento
        '
        Me.lblCondicaoPagamento.AutoSize = True
        Me.lblCondicaoPagamento.ForeColor = System.Drawing.Color.Black
        Me.lblCondicaoPagamento.Location = New System.Drawing.Point(22, 23)
        Me.lblCondicaoPagamento.Name = "lblCondicaoPagamento"
        Me.lblCondicaoPagamento.Size = New System.Drawing.Size(126, 14)
        Me.lblCondicaoPagamento.TabIndex = 1
        Me.lblCondicaoPagamento.Text = "Condição de Pagamento:"
        '
        'lblValorFinalPedido
        '
        Me.lblValorFinalPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorFinalPedido.AutoSize = True
        Me.lblValorFinalPedido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValorFinalPedido.Location = New System.Drawing.Point(685, 22)
        Me.lblValorFinalPedido.Name = "lblValorFinalPedido"
        Me.lblValorFinalPedido.Size = New System.Drawing.Size(66, 14)
        Me.lblValorFinalPedido.TabIndex = 26
        Me.lblValorFinalPedido.Text = "Valor Final:"
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(271, 23)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblFormaPagamento.TabIndex = 3
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.AutoSize = False
        Me.cboFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaPagamento.Location = New System.Drawing.Point(274, 40)
        Me.cboFormaPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaPagamento.Size = New System.Drawing.Size(262, 20)
        Me.cboFormaPagamento.TabIndex = 4
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.cboCentroTrabalho)
        Me.UiGroupBox2.Controls.Add(Me.Label10)
        Me.UiGroupBox2.Controls.Add(Me.cboModalidadeFrete)
        Me.UiGroupBox2.Controls.Add(Me.lblModalidadeFrete)
        Me.UiGroupBox2.Controls.Add(Me.cboModalidadeTransporte)
        Me.UiGroupBox2.Controls.Add(Me.btnCadastrarModalidadeTransporte)
        Me.UiGroupBox2.Controls.Add(Me.lblModalidadeTransporte)
        Me.UiGroupBox2.Controls.Add(Me.txtValorFretePedido)
        Me.UiGroupBox2.Controls.Add(Me.cboTransportadora)
        Me.UiGroupBox2.Controls.Add(Me.lblValorFretePedido)
        Me.UiGroupBox2.Controls.Add(Me.btnCadastrarTransportadora)
        Me.UiGroupBox2.Controls.Add(Me.lblTransportadora)
        Me.UiGroupBox2.Controls.Add(Me.txtLocalEntrega)
        Me.UiGroupBox2.Controls.Add(Me.lblLocalEntrega)
        Me.UiGroupBox2.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox2.Location = New System.Drawing.Point(7, 138)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(1051, 113)
        Me.UiGroupBox2.TabIndex = 8
        Me.UiGroupBox2.Text = "Transporte"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'cboCentroTrabalho
        '
        Me.cboCentroTrabalho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroTrabalho.AutoSize = False
        Me.cboCentroTrabalho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroTrabalho.Location = New System.Drawing.Point(507, 36)
        Me.cboCentroTrabalho.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCentroTrabalho.Name = "cboCentroTrabalho"
        Me.cboCentroTrabalho.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroTrabalho.Size = New System.Drawing.Size(245, 20)
        Me.cboCentroTrabalho.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(505, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 14)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Centro de Trabalho:"
        '
        'cboModalidadeFrete
        '
        Me.cboModalidadeFrete.AutoSize = False
        Me.cboModalidadeFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeFrete.Location = New System.Drawing.Point(9, 36)
        Me.cboModalidadeFrete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModalidadeFrete.Name = "cboModalidadeFrete"
        Me.cboModalidadeFrete.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeFrete.Size = New System.Drawing.Size(241, 20)
        Me.cboModalidadeFrete.TabIndex = 1
        '
        'lblModalidadeFrete
        '
        Me.lblModalidadeFrete.AutoSize = True
        Me.lblModalidadeFrete.ForeColor = System.Drawing.Color.Black
        Me.lblModalidadeFrete.Location = New System.Drawing.Point(6, 19)
        Me.lblModalidadeFrete.Name = "lblModalidadeFrete"
        Me.lblModalidadeFrete.Size = New System.Drawing.Size(107, 14)
        Me.lblModalidadeFrete.TabIndex = 0
        Me.lblModalidadeFrete.Text = "Modalidade de Frete:"
        '
        'cboModalidadeTransporte
        '
        Me.cboModalidadeTransporte.AutoSize = False
        Me.cboModalidadeTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeTransporte.Location = New System.Drawing.Point(9, 82)
        Me.cboModalidadeTransporte.Name = "cboModalidadeTransporte"
        Me.cboModalidadeTransporte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeTransporte.Size = New System.Drawing.Size(241, 20)
        Me.cboModalidadeTransporte.TabIndex = 14
        '
        'btnCadastrarModalidadeTransporte
        '
        Me.btnCadastrarModalidadeTransporte.FlatAppearance.BorderSize = 0
        Me.btnCadastrarModalidadeTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarModalidadeTransporte.Image = CType(resources.GetObject("btnCadastrarModalidadeTransporte.Image"), System.Drawing.Image)
        Me.btnCadastrarModalidadeTransporte.Location = New System.Drawing.Point(9, 66)
        Me.btnCadastrarModalidadeTransporte.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarModalidadeTransporte.Name = "btnCadastrarModalidadeTransporte"
        Me.btnCadastrarModalidadeTransporte.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarModalidadeTransporte.TabIndex = 12
        Me.btnCadastrarModalidadeTransporte.TabStop = False
        Me.btnCadastrarModalidadeTransporte.UseVisualStyleBackColor = True
        '
        'lblModalidadeTransporte
        '
        Me.lblModalidadeTransporte.AutoSize = True
        Me.lblModalidadeTransporte.Location = New System.Drawing.Point(25, 65)
        Me.lblModalidadeTransporte.Name = "lblModalidadeTransporte"
        Me.lblModalidadeTransporte.Size = New System.Drawing.Size(135, 14)
        Me.lblModalidadeTransporte.TabIndex = 13
        Me.lblModalidadeTransporte.Text = "Modalidade de Transporte:"
        '
        'txtValorFretePedido
        '
        Me.txtValorFretePedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorFretePedido.DecimalDigits = 2
        Me.txtValorFretePedido.Location = New System.Drawing.Point(507, 82)
        Me.txtValorFretePedido.Name = "txtValorFretePedido"
        Me.txtValorFretePedido.Size = New System.Drawing.Size(140, 20)
        Me.txtValorFretePedido.TabIndex = 17
        Me.txtValorFretePedido.Text = "0,00"
        Me.txtValorFretePedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboTransportadora
        '
        Me.cboTransportadora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTransportadora.AutoSize = False
        Me.cboTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTransportadora.Location = New System.Drawing.Point(256, 36)
        Me.cboTransportadora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTransportadora.Name = "cboTransportadora"
        Me.cboTransportadora.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTransportadora.Size = New System.Drawing.Size(245, 20)
        Me.cboTransportadora.TabIndex = 4
        '
        'lblValorFretePedido
        '
        Me.lblValorFretePedido.AutoSize = True
        Me.lblValorFretePedido.Location = New System.Drawing.Point(504, 66)
        Me.lblValorFretePedido.Name = "lblValorFretePedido"
        Me.lblValorFretePedido.Size = New System.Drawing.Size(63, 14)
        Me.lblValorFretePedido.TabIndex = 16
        Me.lblValorFretePedido.Text = "Valor Frete:"
        '
        'btnCadastrarTransportadora
        '
        Me.btnCadastrarTransportadora.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTransportadora.Image = CType(resources.GetObject("btnCadastrarTransportadora.Image"), System.Drawing.Image)
        Me.btnCadastrarTransportadora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTransportadora.Location = New System.Drawing.Point(257, 20)
        Me.btnCadastrarTransportadora.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTransportadora.Name = "btnCadastrarTransportadora"
        Me.btnCadastrarTransportadora.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTransportadora.TabIndex = 2
        Me.btnCadastrarTransportadora.TabStop = False
        Me.btnCadastrarTransportadora.UseVisualStyleBackColor = True
        '
        'lblTransportadora
        '
        Me.lblTransportadora.AutoSize = True
        Me.lblTransportadora.Location = New System.Drawing.Point(273, 19)
        Me.lblTransportadora.Name = "lblTransportadora"
        Me.lblTransportadora.Size = New System.Drawing.Size(85, 14)
        Me.lblTransportadora.TabIndex = 3
        Me.lblTransportadora.Text = "Transportadora:"
        '
        'txtLocalEntrega
        '
        Me.txtLocalEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocalEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalEntrega.Location = New System.Drawing.Point(256, 82)
        Me.txtLocalEntrega.MaxLength = 500
        Me.txtLocalEntrega.Name = "txtLocalEntrega"
        Me.txtLocalEntrega.Size = New System.Drawing.Size(245, 20)
        Me.txtLocalEntrega.TabIndex = 6
        '
        'lblLocalEntrega
        '
        Me.lblLocalEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLocalEntrega.AutoSize = True
        Me.lblLocalEntrega.Location = New System.Drawing.Point(253, 66)
        Me.lblLocalEntrega.Name = "lblLocalEntrega"
        Me.lblLocalEntrega.Size = New System.Drawing.Size(76, 14)
        Me.lblLocalEntrega.TabIndex = 5
        Me.lblLocalEntrega.Text = "Local Entrega:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(6, 41)
        Me.txtObservacao.MaxLength = 5000
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(1051, 91)
        Me.txtObservacao.TabIndex = 36
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 21)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 35
        Me.lblObservacao.Text = "Observação:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnGerarPedidoCompra)
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 466)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(1091, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnGerarPedidoCompra
        '
        Me.btnGerarPedidoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarPedidoCompra.Image = Global.INTERACTI.My.Resources.Resources.upload
        Me.btnGerarPedidoCompra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarPedidoCompra.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnGerarPedidoCompra.Location = New System.Drawing.Point(14, 17)
        Me.btnGerarPedidoCompra.Name = "btnGerarPedidoCompra"
        Me.btnGerarPedidoCompra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarPedidoCompra.Size = New System.Drawing.Size(150, 23)
        Me.btnGerarPedidoCompra.TabIndex = 3
        Me.btnGerarPedidoCompra.Text = "Gerar Pedido de Compra"
        Me.btnGerarPedidoCompra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(797, 17)
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
        Me.btnVoltar.Location = New System.Drawing.Point(991, 17)
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
        Me.btnSalvar.Location = New System.Drawing.Point(894, 17)
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
        Me.grpDados.Controls.Add(Me.dtpDataEntrega)
        Me.grpDados.Controls.Add(Me.Label8)
        Me.grpDados.Controls.Add(Me.dtpData)
        Me.grpDados.Controls.Add(Me.lblDataOrcamento)
        Me.grpDados.Controls.Add(Me.txtNumeroOrdem)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.lblFornecedor)
        Me.grpDados.Controls.Add(Me.cboFornecedor)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(1092, 75)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEntrega
        '
        '
        '
        '
        Me.dtpDataEntrega.DropDownCalendar.Name = ""
        Me.dtpDataEntrega.Location = New System.Drawing.Point(700, 33)
        Me.dtpDataEntrega.Name = "dtpDataEntrega"
        Me.dtpDataEntrega.Size = New System.Drawing.Size(92, 20)
        Me.dtpDataEntrega.TabIndex = 9
        Me.dtpDataEntrega.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(697, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Data Entrega:"
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(135, 33)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(92, 20)
        Me.dtpData.TabIndex = 7
        Me.dtpData.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataOrcamento
        '
        Me.lblDataOrcamento.AutoSize = True
        Me.lblDataOrcamento.Location = New System.Drawing.Point(132, 16)
        Me.lblDataOrcamento.Name = "lblDataOrcamento"
        Me.lblDataOrcamento.Size = New System.Drawing.Size(32, 14)
        Me.lblDataOrcamento.TabIndex = 6
        Me.lblDataOrcamento.Text = "Data:"
        '
        'txtNumeroOrdem
        '
        Me.txtNumeroOrdem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrdem.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrdem.MaxLength = 20
        Me.txtNumeroOrdem.Name = "txtNumeroOrdem"
        Me.txtNumeroOrdem.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroOrdem.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(77, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Nº Ordem Ind.:"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(230, 16)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 4
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.AutoSize = False
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboFornecedor.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboFornecedor.Location = New System.Drawing.Point(233, 33)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedor.Size = New System.Drawing.Size(461, 20)
        Me.cboFornecedor.TabIndex = 5
        '
        'btnAgruparGridServico
        '
        Me.btnAgruparGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridServico.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridServico.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridServico.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridServico.Name = "btnAgruparGridServico"
        Me.btnAgruparGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridServico.TabIndex = 95
        Me.btnAgruparGridServico.TabStop = False
        Me.btnAgruparGridServico.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridServico
        '
        Me.btnConfigurarGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridServico.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridServico.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridServico.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridServico.Name = "btnConfigurarGridServico"
        Me.btnConfigurarGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridServico.TabIndex = 2
        Me.btnConfigurarGridServico.TabStop = False
        Me.btnConfigurarGridServico.UseVisualStyleBackColor = False
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 96
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
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 3
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
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 2
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'usrPrdOrdemIndustrializacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdOrdemIndustrializacao"
        Me.Size = New System.Drawing.Size(1110, 551)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagProduto.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDadosGerais.ResumeLayout(False)
        CType(Me.grpDadosCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosCompra.ResumeLayout(False)
        Me.grpDadosCompra.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
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
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtNumeroFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroOrdem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataOrcamento As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMateriaPrima As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboOrdemProducao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents grdItem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnInserirItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataOrcamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosCompra As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboCondicaoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarCondicaoPagamento As System.Windows.Forms.Button
    Friend WithEvents txtValorFinalPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCondicaoPagamento As System.Windows.Forms.Label
    Friend WithEvents lblValorFinalPedido As System.Windows.Forms.Label
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboModalidadeFrete As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModalidadeFrete As System.Windows.Forms.Label
    Friend WithEvents cboModalidadeTransporte As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarModalidadeTransporte As System.Windows.Forms.Button
    Friend WithEvents lblModalidadeTransporte As System.Windows.Forms.Label
    Friend WithEvents txtValorFretePedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboTransportadora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblValorFretePedido As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarTransportadora As System.Windows.Forms.Button
    Friend WithEvents lblTransportadora As System.Windows.Forms.Label
    Friend WithEvents txtLocalEntrega As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLocalEntrega As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGridServico As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridServico As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents txtValorDesonto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDataEntrega As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnGerarPedidoCompra As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPedidoCompra As System.Windows.Forms.Label
    Friend WithEvents picLegendaTipoOrcamento As System.Windows.Forms.PictureBox
    Friend WithEvents cboCentroTrabalho As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
