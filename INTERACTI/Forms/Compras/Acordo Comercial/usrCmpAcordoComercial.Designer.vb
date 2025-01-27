<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmpAcordoComercial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpAcordoComercial))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtRevisaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRevisaoFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarFornecedorFiltro = New System.Windows.Forms.Button()
        Me.txtDescritivoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescritivoFiltro = New System.Windows.Forms.Label()
        Me.lblMoedaFiltro = New System.Windows.Forms.Label()
        Me.cboMoedaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataValidadeInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataValidadeFiltro = New System.Windows.Forms.Label()
        Me.dtpDataValidadeTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroAcordoComercialFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroAcordoComercialFiltro = New System.Windows.Forms.Label()
        Me.lblDataInicioFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInicioTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.cboFornecedorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpAcordoComercial = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtRevisao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRevisao = New System.Windows.Forms.Label()
        Me.txtDescritivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescritivo = New System.Windows.Forms.Label()
        Me.txtFatorCambial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
        Me.btnCadastrarMoeda = New System.Windows.Forms.Button()
        Me.btnCadastrarFornecedor = New System.Windows.Forms.Button()
        Me.lblMoeda = New System.Windows.Forms.Label()
        Me.cboMoeda = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroAcordoComercial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroAcordoComercial = New System.Windows.Forms.Label()
        Me.lblDataValidade = New System.Windows.Forms.Label()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.dtpDataValidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkPISCOFINSEmbutido = New Janus.Windows.EditControls.UICheckBox()
        Me.txtAliquotaPISCOFINSProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtAliquotaICMSProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.chkIPIEmbutido = New Janus.Windows.EditControls.UICheckBox()
        Me.chkICMSEmbutido = New Janus.Windows.EditControls.UICheckBox()
        Me.txtAliquotaIPIProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtLeadTime = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLeadTime = New System.Windows.Forms.Label()
        Me.txtPrecoCompra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoCompra = New System.Windows.Forms.Label()
        Me.btnExcluirProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.lblDescricaoProduto = New System.Windows.Forms.Label()
        Me.txtDescricaoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.cboUnidadeMedidaProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaProduto = New System.Windows.Forms.Label()
        Me.txtQuantidadeMinimaProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeMinimaProduto = New System.Windows.Forms.Label()
        Me.btnCadastrarUnidadeMedidaProduto = New System.Windows.Forms.Button()
        Me.txtDescontoValorProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoValorProduto = New System.Windows.Forms.Label()
        Me.txtDescontoPercentualProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoPercentualProduto = New System.Windows.Forms.Label()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosGerais = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtObservacaoOrcamento = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblInstrucaoEmbarque = New System.Windows.Forms.Label()
        Me.cboInstrucaoEmbarque = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarInstrucaoEmbarque = New System.Windows.Forms.Button()
        Me.lblAgenteLogistico = New System.Windows.Forms.Label()
        Me.cboAgenteLogistico = New Janus.Windows.EditControls.UIComboBox()
        Me.lblIncoterms = New System.Windows.Forms.Label()
        Me.cboIncoterms = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeTransporte = New System.Windows.Forms.Label()
        Me.cboModalidadeTransporte = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTransportadora = New System.Windows.Forms.Label()
        Me.cboTransportadora = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarModalidadeTransporte = New System.Windows.Forms.Button()
        Me.btnCadastrarIncoterms = New System.Windows.Forms.Button()
        Me.btnCadastrarAgenteLogistico = New System.Windows.Forms.Button()
        Me.btnCadastrarTransportadora = New System.Windows.Forms.Button()
        Me.lblAdministradorAcordoComercialFornecedor = New System.Windows.Forms.Label()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.txtAdministradorAcordoComercialFornecedor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboFormaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarCondicaoPagamento = New System.Windows.Forms.Button()
        Me.lblModalidadeFrete = New System.Windows.Forms.Label()
        Me.cboCondicaoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboModalidadeFrete = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCondicaoPagamento = New System.Windows.Forms.Label()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRevisaoArquivo = New System.Windows.Forms.Label()
        Me.txtRevisaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCadastrarTipoArquivo = New System.Windows.Forms.Button()
        Me.lblTipoArquivo = New System.Windows.Forms.Label()
        Me.cboTipoArquivo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grpAcordoComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAcordoComercial.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagProduto.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosGerais.SuspendLayout()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
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
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Acordo Comercial"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtRevisaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRevisaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescritivoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescritivoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMoedaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboMoedaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.dtpDataValidadeInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataValidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataValidadeTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroAcordoComercialFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroAcordoComercialFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboFornecedorFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtRevisaoFiltro
        '
        Me.txtRevisaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisaoFiltro.Location = New System.Drawing.Point(119, 34)
        Me.txtRevisaoFiltro.MaxLength = 3
        Me.txtRevisaoFiltro.Name = "txtRevisaoFiltro"
        Me.txtRevisaoFiltro.Size = New System.Drawing.Size(104, 20)
        Me.txtRevisaoFiltro.TabIndex = 3
        '
        'lblRevisaoFiltro
        '
        Me.lblRevisaoFiltro.AutoSize = True
        Me.lblRevisaoFiltro.Location = New System.Drawing.Point(116, 17)
        Me.lblRevisaoFiltro.Name = "lblRevisaoFiltro"
        Me.lblRevisaoFiltro.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoFiltro.TabIndex = 2
        Me.lblRevisaoFiltro.Text = "Revisão:"
        '
        'btnProcurarFornecedorFiltro
        '
        Me.btnProcurarFornecedorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarFornecedorFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedorFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedorFiltro.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarFornecedorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedorFiltro.Location = New System.Drawing.Point(621, 16)
        Me.btnProcurarFornecedorFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedorFiltro.Name = "btnProcurarFornecedorFiltro"
        Me.btnProcurarFornecedorFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedorFiltro.TabIndex = 6
        Me.btnProcurarFornecedorFiltro.TabStop = False
        Me.btnProcurarFornecedorFiltro.UseVisualStyleBackColor = True
        '
        'txtDescritivoFiltro
        '
        Me.txtDescritivoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescritivoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivoFiltro.Location = New System.Drawing.Point(449, 74)
        Me.txtDescritivoFiltro.MaxLength = 500
        Me.txtDescritivoFiltro.Name = "txtDescritivoFiltro"
        Me.txtDescritivoFiltro.Size = New System.Drawing.Size(299, 20)
        Me.txtDescritivoFiltro.TabIndex = 16
        '
        'lblDescritivoFiltro
        '
        Me.lblDescritivoFiltro.AutoSize = True
        Me.lblDescritivoFiltro.Location = New System.Drawing.Point(446, 57)
        Me.lblDescritivoFiltro.Name = "lblDescritivoFiltro"
        Me.lblDescritivoFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivoFiltro.TabIndex = 15
        Me.lblDescritivoFiltro.Text = "Descritivo:"
        '
        'lblMoedaFiltro
        '
        Me.lblMoedaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoedaFiltro.AutoSize = True
        Me.lblMoedaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMoedaFiltro.Location = New System.Drawing.Point(641, 17)
        Me.lblMoedaFiltro.Name = "lblMoedaFiltro"
        Me.lblMoedaFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblMoedaFiltro.TabIndex = 7
        Me.lblMoedaFiltro.Text = "Moeda:"
        '
        'cboMoedaFiltro
        '
        Me.cboMoedaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMoedaFiltro.AutoSize = False
        Me.cboMoedaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMoedaFiltro.Location = New System.Drawing.Point(644, 34)
        Me.cboMoedaFiltro.Name = "cboMoedaFiltro"
        Me.cboMoedaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMoedaFiltro.Size = New System.Drawing.Size(104, 20)
        Me.cboMoedaFiltro.TabIndex = 8
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 17
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataValidadeInicioFiltro
        '
        '
        '
        '
        Me.dtpDataValidadeInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataValidadeInicioFiltro.Location = New System.Drawing.Point(229, 74)
        Me.dtpDataValidadeInicioFiltro.Name = "dtpDataValidadeInicioFiltro"
        Me.dtpDataValidadeInicioFiltro.ShowCheckBox = True
        Me.dtpDataValidadeInicioFiltro.Size = New System.Drawing.Size(104, 20)
        Me.dtpDataValidadeInicioFiltro.TabIndex = 13
        '
        'lblDataValidadeFiltro
        '
        Me.lblDataValidadeFiltro.AutoSize = True
        Me.lblDataValidadeFiltro.Location = New System.Drawing.Point(226, 57)
        Me.lblDataValidadeFiltro.Name = "lblDataValidadeFiltro"
        Me.lblDataValidadeFiltro.Size = New System.Drawing.Size(76, 14)
        Me.lblDataValidadeFiltro.TabIndex = 12
        Me.lblDataValidadeFiltro.Text = "Data Validade:"
        '
        'dtpDataValidadeTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataValidadeTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataValidadeTerminoFiltro.Location = New System.Drawing.Point(339, 74)
        Me.dtpDataValidadeTerminoFiltro.Name = "dtpDataValidadeTerminoFiltro"
        Me.dtpDataValidadeTerminoFiltro.ShowCheckBox = True
        Me.dtpDataValidadeTerminoFiltro.Size = New System.Drawing.Size(104, 20)
        Me.dtpDataValidadeTerminoFiltro.TabIndex = 14
        '
        'dtpDataInicioInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataInicioInicioFiltro.Name = "dtpDataInicioInicioFiltro"
        Me.dtpDataInicioInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioInicioFiltro.Size = New System.Drawing.Size(104, 20)
        Me.dtpDataInicioInicioFiltro.TabIndex = 10
        '
        'txtNumeroAcordoComercialFiltro
        '
        Me.txtNumeroAcordoComercialFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroAcordoComercialFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroAcordoComercialFiltro.MaxLength = 100
        Me.txtNumeroAcordoComercialFiltro.Name = "txtNumeroAcordoComercialFiltro"
        Me.txtNumeroAcordoComercialFiltro.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroAcordoComercialFiltro.TabIndex = 1
        '
        'lblNumeroAcordoComercialFiltro
        '
        Me.lblNumeroAcordoComercialFiltro.AutoSize = True
        Me.lblNumeroAcordoComercialFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroAcordoComercialFiltro.Name = "lblNumeroAcordoComercialFiltro"
        Me.lblNumeroAcordoComercialFiltro.Size = New System.Drawing.Size(60, 14)
        Me.lblNumeroAcordoComercialFiltro.TabIndex = 0
        Me.lblNumeroAcordoComercialFiltro.Text = "Nº Acordo:"
        '
        'lblDataInicioFiltro
        '
        Me.lblDataInicioFiltro.AutoSize = True
        Me.lblDataInicioFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataInicioFiltro.Name = "lblDataInicioFiltro"
        Me.lblDataInicioFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicioFiltro.TabIndex = 9
        Me.lblDataInicioFiltro.Text = "Data Início:"
        '
        'dtpDataInicioTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataInicioTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioTerminoFiltro.Location = New System.Drawing.Point(119, 74)
        Me.dtpDataInicioTerminoFiltro.Name = "dtpDataInicioTerminoFiltro"
        Me.dtpDataInicioTerminoFiltro.ShowCheckBox = True
        Me.dtpDataInicioTerminoFiltro.Size = New System.Drawing.Size(104, 20)
        Me.dtpDataInicioTerminoFiltro.TabIndex = 11
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(226, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 4
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'cboFornecedorFiltro
        '
        Me.cboFornecedorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedorFiltro.AutoSize = False
        Me.cboFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedorFiltro.Location = New System.Drawing.Point(229, 34)
        Me.cboFornecedorFiltro.Name = "cboFornecedorFiltro"
        Me.cboFornecedorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedorFiltro.Size = New System.Drawing.Size(409, 20)
        Me.cboFornecedorFiltro.TabIndex = 5
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
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(982, 51)
        Me.grpControle.TabIndex = 5
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(785, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(688, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 0
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpAcordoComercial)
        Me.pagDados.Controls.Add(Me.UiGroupBox1)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Acordo Comercial"
        '
        'grpAcordoComercial
        '
        Me.grpAcordoComercial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAcordoComercial.BackColor = System.Drawing.Color.Transparent
        Me.grpAcordoComercial.Controls.Add(Me.txtRevisao)
        Me.grpAcordoComercial.Controls.Add(Me.lblRevisao)
        Me.grpAcordoComercial.Controls.Add(Me.txtDescritivo)
        Me.grpAcordoComercial.Controls.Add(Me.lblDescritivo)
        Me.grpAcordoComercial.Controls.Add(Me.txtFatorCambial)
        Me.grpAcordoComercial.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpAcordoComercial.Controls.Add(Me.btnCadastrarMoeda)
        Me.grpAcordoComercial.Controls.Add(Me.btnCadastrarFornecedor)
        Me.grpAcordoComercial.Controls.Add(Me.lblMoeda)
        Me.grpAcordoComercial.Controls.Add(Me.cboMoeda)
        Me.grpAcordoComercial.Controls.Add(Me.txtNumeroAcordoComercial)
        Me.grpAcordoComercial.Controls.Add(Me.lblNumeroAcordoComercial)
        Me.grpAcordoComercial.Controls.Add(Me.lblDataValidade)
        Me.grpAcordoComercial.Controls.Add(Me.lblDataInicio)
        Me.grpAcordoComercial.Controls.Add(Me.dtpDataValidade)
        Me.grpAcordoComercial.Controls.Add(Me.dtpDataInicio)
        Me.grpAcordoComercial.Controls.Add(Me.lblFornecedor)
        Me.grpAcordoComercial.Controls.Add(Me.cboFornecedor)
        Me.grpAcordoComercial.Location = New System.Drawing.Point(8, 3)
        Me.grpAcordoComercial.Name = "grpAcordoComercial"
        Me.grpAcordoComercial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAcordoComercial.Size = New System.Drawing.Size(982, 104)
        Me.grpAcordoComercial.TabIndex = 0
        Me.grpAcordoComercial.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpAcordoComercial.VisualStyleManager = Me.vsmMain
        '
        'txtRevisao
        '
        Me.txtRevisao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRevisao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisao.Location = New System.Drawing.Point(119, 34)
        Me.txtRevisao.MaxLength = 3
        Me.txtRevisao.Name = "txtRevisao"
        Me.txtRevisao.ReadOnly = True
        Me.txtRevisao.Size = New System.Drawing.Size(104, 20)
        Me.txtRevisao.TabIndex = 3
        Me.txtRevisao.TabStop = False
        Me.txtRevisao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblRevisao
        '
        Me.lblRevisao.AutoSize = True
        Me.lblRevisao.Location = New System.Drawing.Point(116, 17)
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisao.TabIndex = 2
        Me.lblRevisao.Text = "Revisão:"
        '
        'txtDescritivo
        '
        Me.txtDescritivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescritivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivo.Location = New System.Drawing.Point(9, 74)
        Me.txtDescritivo.MaxLength = 500
        Me.txtDescritivo.Name = "txtDescritivo"
        Me.txtDescritivo.Size = New System.Drawing.Size(964, 20)
        Me.txtDescritivo.TabIndex = 17
        '
        'lblDescritivo
        '
        Me.lblDescritivo.AutoSize = True
        Me.lblDescritivo.Location = New System.Drawing.Point(6, 57)
        Me.lblDescritivo.Name = "lblDescritivo"
        Me.lblDescritivo.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivo.TabIndex = 16
        Me.lblDescritivo.Text = "Descritivo:"
        '
        'txtFatorCambial
        '
        Me.txtFatorCambial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFatorCambial.DecimalDigits = 4
        Me.txtFatorCambial.Location = New System.Drawing.Point(702, 34)
        Me.txtFatorCambial.Name = "txtFatorCambial"
        Me.txtFatorCambial.Size = New System.Drawing.Size(59, 20)
        Me.txtFatorCambial.TabIndex = 11
        Me.txtFatorCambial.Text = "0,0000"
        Me.txtFatorCambial.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnProcurarFornecedor
        '
        Me.btnProcurarFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedor.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(610, 16)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedor.TabIndex = 6
        Me.btnProcurarFornecedor.TabStop = False
        Me.btnProcurarFornecedor.UseVisualStyleBackColor = True
        '
        'btnCadastrarMoeda
        '
        Me.btnCadastrarMoeda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarMoeda.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMoeda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMoeda.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarMoeda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMoeda.Location = New System.Drawing.Point(633, 18)
        Me.btnCadastrarMoeda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMoeda.Name = "btnCadastrarMoeda"
        Me.btnCadastrarMoeda.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMoeda.TabIndex = 8
        Me.btnCadastrarMoeda.TabStop = False
        Me.btnCadastrarMoeda.UseVisualStyleBackColor = True
        '
        'btnCadastrarFornecedor
        '
        Me.btnCadastrarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarFornecedor.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarFornecedor.Location = New System.Drawing.Point(229, 18)
        Me.btnCadastrarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor"
        Me.btnCadastrarFornecedor.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarFornecedor.TabIndex = 4
        Me.btnCadastrarFornecedor.TabStop = False
        Me.btnCadastrarFornecedor.UseVisualStyleBackColor = True
        '
        'lblMoeda
        '
        Me.lblMoeda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoeda.AutoSize = True
        Me.lblMoeda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMoeda.Location = New System.Drawing.Point(649, 17)
        Me.lblMoeda.Name = "lblMoeda"
        Me.lblMoeda.Size = New System.Drawing.Size(42, 14)
        Me.lblMoeda.TabIndex = 9
        Me.lblMoeda.Text = "Moeda:"
        '
        'cboMoeda
        '
        Me.cboMoeda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMoeda.AutoSize = False
        Me.cboMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMoeda.Location = New System.Drawing.Point(633, 34)
        Me.cboMoeda.Name = "cboMoeda"
        Me.cboMoeda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMoeda.Size = New System.Drawing.Size(63, 20)
        Me.cboMoeda.TabIndex = 10
        '
        'txtNumeroAcordoComercial
        '
        Me.txtNumeroAcordoComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroAcordoComercial.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroAcordoComercial.MaxLength = 20
        Me.txtNumeroAcordoComercial.Name = "txtNumeroAcordoComercial"
        Me.txtNumeroAcordoComercial.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroAcordoComercial.TabIndex = 1
        '
        'lblNumeroAcordoComercial
        '
        Me.lblNumeroAcordoComercial.AutoSize = True
        Me.lblNumeroAcordoComercial.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroAcordoComercial.Name = "lblNumeroAcordoComercial"
        Me.lblNumeroAcordoComercial.Size = New System.Drawing.Size(60, 14)
        Me.lblNumeroAcordoComercial.TabIndex = 0
        Me.lblNumeroAcordoComercial.Text = "Nº Acordo:"
        '
        'lblDataValidade
        '
        Me.lblDataValidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataValidade.AutoSize = True
        Me.lblDataValidade.Location = New System.Drawing.Point(870, 17)
        Me.lblDataValidade.Name = "lblDataValidade"
        Me.lblDataValidade.Size = New System.Drawing.Size(76, 14)
        Me.lblDataValidade.TabIndex = 14
        Me.lblDataValidade.Text = "Data Validade:"
        '
        'lblDataInicio
        '
        Me.lblDataInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(764, 17)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicio.TabIndex = 12
        Me.lblDataInicio.Text = "Data Início:"
        '
        'dtpDataValidade
        '
        Me.dtpDataValidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataValidade.DropDownCalendar.Name = ""
        Me.dtpDataValidade.Location = New System.Drawing.Point(873, 34)
        Me.dtpDataValidade.Name = "dtpDataValidade"
        Me.dtpDataValidade.ShowCheckBox = True
        Me.dtpDataValidade.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataValidade.TabIndex = 15
        Me.dtpDataValidade.Value = New Date(2013, 6, 30, 0, 0, 0, 0)
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(767, 34)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataInicio.TabIndex = 13
        Me.dtpDataInicio.Value = New Date(2013, 6, 30, 0, 0, 0, 0)
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFornecedor.Location = New System.Drawing.Point(245, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 5
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedor.AutoSize = False
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedor.Location = New System.Drawing.Point(229, 34)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedor.Size = New System.Drawing.Size(398, 20)
        Me.cboFornecedor.TabIndex = 7
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnNovo)
        Me.UiGroupBox1.Controls.Add(Me.btnSalvar)
        Me.UiGroupBox1.Controls.Add(Me.btnVoltar)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 483)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(982, 51)
        Me.UiGroupBox1.TabIndex = 2
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(688, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(785, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(882, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 113)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(982, 367)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagProduto, Me.pagDadosGerais, Me.pagArquivo})
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagProduto
        '
        Me.pagProduto.Controls.Add(Me.btnExcelGridProduto)
        Me.pagProduto.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagProduto.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagProduto.Controls.Add(Me.grpProduto)
        Me.pagProduto.Controls.Add(Me.grdProduto)
        Me.pagProduto.Key = "pagProduto"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Size = New System.Drawing.Size(980, 344)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Produto"
        '
        'btnExcelGridProduto
        '
        Me.btnExcelGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridProduto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridProduto.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridProduto.Location = New System.Drawing.Point(57, 318)
        Me.btnExcelGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridProduto.Name = "btnExcelGridProduto"
        Me.btnExcelGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridProduto.TabIndex = 4
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
        Me.btnAgruparGridProduto.Location = New System.Drawing.Point(33, 318)
        Me.btnAgruparGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProduto.Name = "btnAgruparGridProduto"
        Me.btnAgruparGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridProduto.TabIndex = 3
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
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(9, 318)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 2
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'grpProduto
        '
        Me.grpProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.chkPISCOFINSEmbutido)
        Me.grpProduto.Controls.Add(Me.txtAliquotaPISCOFINSProduto)
        Me.grpProduto.Controls.Add(Me.txtAliquotaICMSProduto)
        Me.grpProduto.Controls.Add(Me.chkIPIEmbutido)
        Me.grpProduto.Controls.Add(Me.chkICMSEmbutido)
        Me.grpProduto.Controls.Add(Me.txtAliquotaIPIProduto)
        Me.grpProduto.Controls.Add(Me.txtLeadTime)
        Me.grpProduto.Controls.Add(Me.lblLeadTime)
        Me.grpProduto.Controls.Add(Me.txtPrecoCompra)
        Me.grpProduto.Controls.Add(Me.lblPrecoCompra)
        Me.grpProduto.Controls.Add(Me.btnExcluirProduto)
        Me.grpProduto.Controls.Add(Me.btnInserirProduto)
        Me.grpProduto.Controls.Add(Me.txtValorUnitario)
        Me.grpProduto.Controls.Add(Me.lblValorUnitario)
        Me.grpProduto.Controls.Add(Me.lblDescricaoProduto)
        Me.grpProduto.Controls.Add(Me.txtDescricaoProduto)
        Me.grpProduto.Controls.Add(Me.cboProduto)
        Me.grpProduto.Controls.Add(Me.lblProduto)
        Me.grpProduto.Controls.Add(Me.btnProcurarProduto)
        Me.grpProduto.Controls.Add(Me.btnCadastrarProduto)
        Me.grpProduto.Controls.Add(Me.cboUnidadeMedidaProduto)
        Me.grpProduto.Controls.Add(Me.lblUnidadeMedidaProduto)
        Me.grpProduto.Controls.Add(Me.txtQuantidadeMinimaProduto)
        Me.grpProduto.Controls.Add(Me.lblQuantidadeMinimaProduto)
        Me.grpProduto.Controls.Add(Me.btnCadastrarUnidadeMedidaProduto)
        Me.grpProduto.Controls.Add(Me.txtDescontoValorProduto)
        Me.grpProduto.Controls.Add(Me.lblDescontoValorProduto)
        Me.grpProduto.Controls.Add(Me.txtDescontoPercentualProduto)
        Me.grpProduto.Controls.Add(Me.lblDescontoPercentualProduto)
        Me.grpProduto.Location = New System.Drawing.Point(8, 3)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(964, 104)
        Me.grpProduto.TabIndex = 0
        Me.grpProduto.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'chkPISCOFINSEmbutido
        '
        Me.chkPISCOFINSEmbutido.Location = New System.Drawing.Point(671, 57)
        Me.chkPISCOFINSEmbutido.Name = "chkPISCOFINSEmbutido"
        Me.chkPISCOFINSEmbutido.Size = New System.Drawing.Size(82, 14)
        Me.chkPISCOFINSEmbutido.TabIndex = 23
        Me.chkPISCOFINSEmbutido.Text = "PIS / COFINS:"
        '
        'txtAliquotaPISCOFINSProduto
        '
        Me.txtAliquotaPISCOFINSProduto.DecimalDigits = 2
        Me.txtAliquotaPISCOFINSProduto.Location = New System.Drawing.Point(671, 74)
        Me.txtAliquotaPISCOFINSProduto.MaxLength = 0
        Me.txtAliquotaPISCOFINSProduto.Name = "txtAliquotaPISCOFINSProduto"
        Me.txtAliquotaPISCOFINSProduto.Size = New System.Drawing.Size(90, 20)
        Me.txtAliquotaPISCOFINSProduto.TabIndex = 24
        Me.txtAliquotaPISCOFINSProduto.Text = "0,00"
        Me.txtAliquotaPISCOFINSProduto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtAliquotaICMSProduto
        '
        Me.txtAliquotaICMSProduto.DecimalDigits = 2
        Me.txtAliquotaICMSProduto.Location = New System.Drawing.Point(479, 74)
        Me.txtAliquotaICMSProduto.MaxLength = 0
        Me.txtAliquotaICMSProduto.Name = "txtAliquotaICMSProduto"
        Me.txtAliquotaICMSProduto.Size = New System.Drawing.Size(90, 20)
        Me.txtAliquotaICMSProduto.TabIndex = 20
        Me.txtAliquotaICMSProduto.Text = "0,00"
        Me.txtAliquotaICMSProduto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'chkIPIEmbutido
        '
        Me.chkIPIEmbutido.Location = New System.Drawing.Point(575, 57)
        Me.chkIPIEmbutido.Name = "chkIPIEmbutido"
        Me.chkIPIEmbutido.Size = New System.Drawing.Size(68, 14)
        Me.chkIPIEmbutido.TabIndex = 21
        Me.chkIPIEmbutido.Text = "IPI (%)"
        '
        'chkICMSEmbutido
        '
        Me.chkICMSEmbutido.Location = New System.Drawing.Point(479, 57)
        Me.chkICMSEmbutido.Name = "chkICMSEmbutido"
        Me.chkICMSEmbutido.Size = New System.Drawing.Size(68, 14)
        Me.chkICMSEmbutido.TabIndex = 19
        Me.chkICMSEmbutido.Text = "ICMS (%)"
        '
        'txtAliquotaIPIProduto
        '
        Me.txtAliquotaIPIProduto.DecimalDigits = 2
        Me.txtAliquotaIPIProduto.Location = New System.Drawing.Point(575, 74)
        Me.txtAliquotaIPIProduto.MaxLength = 0
        Me.txtAliquotaIPIProduto.Name = "txtAliquotaIPIProduto"
        Me.txtAliquotaIPIProduto.Size = New System.Drawing.Size(90, 20)
        Me.txtAliquotaIPIProduto.TabIndex = 22
        Me.txtAliquotaIPIProduto.Text = "0,00"
        Me.txtAliquotaIPIProduto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtLeadTime
        '
        Me.txtLeadTime.DecimalDigits = 0
        Me.txtLeadTime.Location = New System.Drawing.Point(767, 34)
        Me.txtLeadTime.MaxLength = 0
        Me.txtLeadTime.Name = "txtLeadTime"
        Me.txtLeadTime.Size = New System.Drawing.Size(90, 20)
        Me.txtLeadTime.TabIndex = 7
        Me.txtLeadTime.Text = "0"
        Me.txtLeadTime.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLeadTime
        '
        Me.lblLeadTime.AutoSize = True
        Me.lblLeadTime.Location = New System.Drawing.Point(764, 17)
        Me.lblLeadTime.Name = "lblLeadTime"
        Me.lblLeadTime.Size = New System.Drawing.Size(59, 14)
        Me.lblLeadTime.TabIndex = 6
        Me.lblLeadTime.Text = "Lead Time:"
        '
        'txtPrecoCompra
        '
        Me.txtPrecoCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrecoCompra.DecimalDigits = 2
        Me.txtPrecoCompra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoCompra.Location = New System.Drawing.Point(767, 74)
        Me.txtPrecoCompra.MaxLength = 0
        Me.txtPrecoCompra.Name = "txtPrecoCompra"
        Me.txtPrecoCompra.ReadOnly = True
        Me.txtPrecoCompra.Size = New System.Drawing.Size(90, 20)
        Me.txtPrecoCompra.TabIndex = 26
        Me.txtPrecoCompra.TabStop = False
        Me.txtPrecoCompra.Text = "0,00"
        Me.txtPrecoCompra.Value = 0.0R
        Me.txtPrecoCompra.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblPrecoCompra
        '
        Me.lblPrecoCompra.AutoSize = True
        Me.lblPrecoCompra.Location = New System.Drawing.Point(764, 57)
        Me.lblPrecoCompra.Name = "lblPrecoCompra"
        Me.lblPrecoCompra.Size = New System.Drawing.Size(78, 14)
        Me.lblPrecoCompra.TabIndex = 25
        Me.lblPrecoCompra.Text = "Preço Compra:"
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirProduto.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirProduto.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirProduto.Location = New System.Drawing.Point(864, 71)
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirProduto.TabIndex = 28
        Me.btnExcluirProduto.Text = "Excluir"
        Me.btnExcluirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirProduto.Image = CType(resources.GetObject("btnInserirProduto.Image"), System.Drawing.Image)
        Me.btnInserirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirProduto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirProduto.Location = New System.Drawing.Point(864, 42)
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirProduto.TabIndex = 27
        Me.btnInserirProduto.Text = "Inserir"
        Me.btnInserirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.DecimalDigits = 4
        Me.txtValorUnitario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnitario.Location = New System.Drawing.Point(191, 74)
        Me.txtValorUnitario.MaxLength = 0
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(90, 20)
        Me.txtValorUnitario.TabIndex = 14
        Me.txtValorUnitario.Text = "0,0000"
        Me.txtValorUnitario.Value = 0.0R
        Me.txtValorUnitario.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.Location = New System.Drawing.Point(188, 57)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitario.TabIndex = 13
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'lblDescricaoProduto
        '
        Me.lblDescricaoProduto.AutoSize = True
        Me.lblDescricaoProduto.Location = New System.Drawing.Point(188, 17)
        Me.lblDescricaoProduto.Name = "lblDescricaoProduto"
        Me.lblDescricaoProduto.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoProduto.TabIndex = 4
        Me.lblDescricaoProduto.Text = "Descrição:"
        '
        'txtDescricaoProduto
        '
        Me.txtDescricaoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoProduto.Location = New System.Drawing.Point(191, 34)
        Me.txtDescricaoProduto.MaxLength = 60
        Me.txtDescricaoProduto.Name = "txtDescricaoProduto"
        Me.txtDescricaoProduto.ReadOnly = True
        Me.txtDescricaoProduto.Size = New System.Drawing.Size(570, 20)
        Me.txtDescricaoProduto.TabIndex = 5
        Me.txtDescricaoProduto.TabStop = False
        '
        'cboProduto
        '
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboProduto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboProduto.Location = New System.Drawing.Point(9, 34)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(176, 20)
        Me.cboProduto.TabIndex = 3
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(25, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 1
        Me.lblProduto.Text = "Produto:"
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(168, 15)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 2
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 0
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'cboUnidadeMedidaProduto
        '
        Me.cboUnidadeMedidaProduto.AutoSize = False
        Me.cboUnidadeMedidaProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboUnidadeMedidaProduto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboUnidadeMedidaProduto.Location = New System.Drawing.Point(100, 74)
        Me.cboUnidadeMedidaProduto.Name = "cboUnidadeMedidaProduto"
        Me.cboUnidadeMedidaProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaProduto.Size = New System.Drawing.Size(85, 20)
        Me.cboUnidadeMedidaProduto.TabIndex = 12
        '
        'lblUnidadeMedidaProduto
        '
        Me.lblUnidadeMedidaProduto.AutoSize = True
        Me.lblUnidadeMedidaProduto.Location = New System.Drawing.Point(116, 57)
        Me.lblUnidadeMedidaProduto.Name = "lblUnidadeMedidaProduto"
        Me.lblUnidadeMedidaProduto.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedidaProduto.TabIndex = 11
        Me.lblUnidadeMedidaProduto.Text = "Und. Med.:"
        '
        'txtQuantidadeMinimaProduto
        '
        Me.txtQuantidadeMinimaProduto.DecimalDigits = 4
        Me.txtQuantidadeMinimaProduto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeMinimaProduto.Location = New System.Drawing.Point(9, 74)
        Me.txtQuantidadeMinimaProduto.MaxLength = 0
        Me.txtQuantidadeMinimaProduto.Name = "txtQuantidadeMinimaProduto"
        Me.txtQuantidadeMinimaProduto.Size = New System.Drawing.Size(85, 20)
        Me.txtQuantidadeMinimaProduto.TabIndex = 9
        Me.txtQuantidadeMinimaProduto.Text = "0,0000"
        Me.txtQuantidadeMinimaProduto.Value = 0.0R
        Me.txtQuantidadeMinimaProduto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblQuantidadeMinimaProduto
        '
        Me.lblQuantidadeMinimaProduto.AutoSize = True
        Me.lblQuantidadeMinimaProduto.Location = New System.Drawing.Point(6, 57)
        Me.lblQuantidadeMinimaProduto.Name = "lblQuantidadeMinimaProduto"
        Me.lblQuantidadeMinimaProduto.Size = New System.Drawing.Size(71, 14)
        Me.lblQuantidadeMinimaProduto.TabIndex = 8
        Me.lblQuantidadeMinimaProduto.Text = "Qtde. Mínima:"
        '
        'btnCadastrarUnidadeMedidaProduto
        '
        Me.btnCadastrarUnidadeMedidaProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedidaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedidaProduto.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarUnidadeMedidaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedidaProduto.Location = New System.Drawing.Point(100, 58)
        Me.btnCadastrarUnidadeMedidaProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedidaProduto.Name = "btnCadastrarUnidadeMedidaProduto"
        Me.btnCadastrarUnidadeMedidaProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedidaProduto.TabIndex = 10
        Me.btnCadastrarUnidadeMedidaProduto.TabStop = False
        Me.btnCadastrarUnidadeMedidaProduto.UseVisualStyleBackColor = True
        '
        'txtDescontoValorProduto
        '
        Me.txtDescontoValorProduto.DecimalDigits = 4
        Me.txtDescontoValorProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDescontoValorProduto.Location = New System.Drawing.Point(383, 74)
        Me.txtDescontoValorProduto.MaxLength = 0
        Me.txtDescontoValorProduto.Name = "txtDescontoValorProduto"
        Me.txtDescontoValorProduto.Size = New System.Drawing.Size(90, 20)
        Me.txtDescontoValorProduto.TabIndex = 18
        Me.txtDescontoValorProduto.Text = "0,0000"
        Me.txtDescontoValorProduto.Value = 0.0R
        Me.txtDescontoValorProduto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoValorProduto
        '
        Me.lblDescontoValorProduto.AutoSize = True
        Me.lblDescontoValorProduto.Location = New System.Drawing.Point(380, 57)
        Me.lblDescontoValorProduto.Name = "lblDescontoValorProduto"
        Me.lblDescontoValorProduto.Size = New System.Drawing.Size(92, 14)
        Me.lblDescontoValorProduto.TabIndex = 17
        Me.lblDescontoValorProduto.Text = "Desconto (Valor):"
        '
        'txtDescontoPercentualProduto
        '
        Me.txtDescontoPercentualProduto.DecimalDigits = 5
        Me.txtDescontoPercentualProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDescontoPercentualProduto.Location = New System.Drawing.Point(287, 74)
        Me.txtDescontoPercentualProduto.MaxLength = 0
        Me.txtDescontoPercentualProduto.Name = "txtDescontoPercentualProduto"
        Me.txtDescontoPercentualProduto.Size = New System.Drawing.Size(90, 20)
        Me.txtDescontoPercentualProduto.TabIndex = 16
        Me.txtDescontoPercentualProduto.Text = "0,00000"
        Me.txtDescontoPercentualProduto.Value = 0.0R
        Me.txtDescontoPercentualProduto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoPercentualProduto
        '
        Me.lblDescontoPercentualProduto.AutoSize = True
        Me.lblDescontoPercentualProduto.Location = New System.Drawing.Point(284, 57)
        Me.lblDescontoPercentualProduto.Name = "lblDescontoPercentualProduto"
        Me.lblDescontoPercentualProduto.Size = New System.Drawing.Size(77, 14)
        Me.lblDescontoPercentualProduto.TabIndex = 15
        Me.lblDescontoPercentualProduto.Text = "Desconto (%):"
        '
        'grdProduto
        '
        Me.grdProduto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.AutoEdit = True
        grdProduto_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProduto_DesignTimeLayout_Reference_0.Instance"), Object)
        grdProduto_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProduto_DesignTimeLayout_Reference_0})
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.FrozenColumns = 2
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.Location = New System.Drawing.Point(8, 116)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(964, 219)
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
        'pagDadosGerais
        '
        Me.pagDadosGerais.Controls.Add(Me.grpDadosGerais)
        Me.pagDadosGerais.Key = "pagDadosGerais"
        Me.pagDadosGerais.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.Size = New System.Drawing.Size(980, 344)
        Me.pagDadosGerais.TabStop = True
        Me.pagDadosGerais.Text = "Dados Gerais"
        '
        'grpDadosGerais
        '
        Me.grpDadosGerais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosGerais.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosGerais.Controls.Add(Me.lblObservacao)
        Me.grpDadosGerais.Controls.Add(Me.txtObservacaoOrcamento)
        Me.grpDadosGerais.Controls.Add(Me.lblInstrucaoEmbarque)
        Me.grpDadosGerais.Controls.Add(Me.cboInstrucaoEmbarque)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarInstrucaoEmbarque)
        Me.grpDadosGerais.Controls.Add(Me.lblAgenteLogistico)
        Me.grpDadosGerais.Controls.Add(Me.cboAgenteLogistico)
        Me.grpDadosGerais.Controls.Add(Me.lblIncoterms)
        Me.grpDadosGerais.Controls.Add(Me.cboIncoterms)
        Me.grpDadosGerais.Controls.Add(Me.lblModalidadeTransporte)
        Me.grpDadosGerais.Controls.Add(Me.cboModalidadeTransporte)
        Me.grpDadosGerais.Controls.Add(Me.lblTransportadora)
        Me.grpDadosGerais.Controls.Add(Me.cboTransportadora)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarModalidadeTransporte)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarIncoterms)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarAgenteLogistico)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarTransportadora)
        Me.grpDadosGerais.Controls.Add(Me.lblAdministradorAcordoComercialFornecedor)
        Me.grpDadosGerais.Controls.Add(Me.lblFormaPagamento)
        Me.grpDadosGerais.Controls.Add(Me.txtAdministradorAcordoComercialFornecedor)
        Me.grpDadosGerais.Controls.Add(Me.cboFormaPagamento)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarCondicaoPagamento)
        Me.grpDadosGerais.Controls.Add(Me.lblModalidadeFrete)
        Me.grpDadosGerais.Controls.Add(Me.cboCondicaoPagamento)
        Me.grpDadosGerais.Controls.Add(Me.cboModalidadeFrete)
        Me.grpDadosGerais.Controls.Add(Me.lblCondicaoPagamento)
        Me.grpDadosGerais.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosGerais.Name = "grpDadosGerais"
        Me.grpDadosGerais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosGerais.Size = New System.Drawing.Size(964, 332)
        Me.grpDadosGerais.TabIndex = 0
        Me.grpDadosGerais.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosGerais.VisualStyleManager = Me.vsmMain
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 137)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 24
        Me.lblObservacao.Text = "Observação:"
        '
        'txtObservacaoOrcamento
        '
        Me.txtObservacaoOrcamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoOrcamento.Location = New System.Drawing.Point(9, 154)
        Me.txtObservacaoOrcamento.MaxLength = 5000
        Me.txtObservacaoOrcamento.Multiline = True
        Me.txtObservacaoOrcamento.Name = "txtObservacaoOrcamento"
        Me.txtObservacaoOrcamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacaoOrcamento.Size = New System.Drawing.Size(946, 168)
        Me.txtObservacaoOrcamento.TabIndex = 25
        '
        'lblInstrucaoEmbarque
        '
        Me.lblInstrucaoEmbarque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstrucaoEmbarque.AutoSize = True
        Me.lblInstrucaoEmbarque.Location = New System.Drawing.Point(420, 97)
        Me.lblInstrucaoEmbarque.Name = "lblInstrucaoEmbarque"
        Me.lblInstrucaoEmbarque.Size = New System.Drawing.Size(121, 14)
        Me.lblInstrucaoEmbarque.TabIndex = 22
        Me.lblInstrucaoEmbarque.Text = "Instrução de Embarque:"
        '
        'cboInstrucaoEmbarque
        '
        Me.cboInstrucaoEmbarque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboInstrucaoEmbarque.AutoSize = False
        Me.cboInstrucaoEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboInstrucaoEmbarque.Location = New System.Drawing.Point(404, 114)
        Me.cboInstrucaoEmbarque.Name = "cboInstrucaoEmbarque"
        Me.cboInstrucaoEmbarque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboInstrucaoEmbarque.Size = New System.Drawing.Size(551, 20)
        Me.cboInstrucaoEmbarque.TabIndex = 23
        '
        'btnCadastrarInstrucaoEmbarque
        '
        Me.btnCadastrarInstrucaoEmbarque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarInstrucaoEmbarque.FlatAppearance.BorderSize = 0
        Me.btnCadastrarInstrucaoEmbarque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarInstrucaoEmbarque.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarInstrucaoEmbarque.Location = New System.Drawing.Point(404, 98)
        Me.btnCadastrarInstrucaoEmbarque.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarInstrucaoEmbarque.Name = "btnCadastrarInstrucaoEmbarque"
        Me.btnCadastrarInstrucaoEmbarque.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarInstrucaoEmbarque.TabIndex = 21
        Me.btnCadastrarInstrucaoEmbarque.TabStop = False
        Me.btnCadastrarInstrucaoEmbarque.UseVisualStyleBackColor = True
        '
        'lblAgenteLogistico
        '
        Me.lblAgenteLogistico.AutoSize = True
        Me.lblAgenteLogistico.Location = New System.Drawing.Point(25, 97)
        Me.lblAgenteLogistico.Name = "lblAgenteLogistico"
        Me.lblAgenteLogistico.Size = New System.Drawing.Size(91, 14)
        Me.lblAgenteLogistico.TabIndex = 19
        Me.lblAgenteLogistico.Text = "Agente Logístico:"
        '
        'cboAgenteLogistico
        '
        Me.cboAgenteLogistico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAgenteLogistico.AutoSize = False
        Me.cboAgenteLogistico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAgenteLogistico.Location = New System.Drawing.Point(9, 114)
        Me.cboAgenteLogistico.Name = "cboAgenteLogistico"
        Me.cboAgenteLogistico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAgenteLogistico.Size = New System.Drawing.Size(389, 20)
        Me.cboAgenteLogistico.TabIndex = 20
        '
        'lblIncoterms
        '
        Me.lblIncoterms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIncoterms.AutoSize = True
        Me.lblIncoterms.Location = New System.Drawing.Point(841, 57)
        Me.lblIncoterms.Name = "lblIncoterms"
        Me.lblIncoterms.Size = New System.Drawing.Size(57, 14)
        Me.lblIncoterms.TabIndex = 16
        Me.lblIncoterms.Text = "Incoterms:"
        '
        'cboIncoterms
        '
        Me.cboIncoterms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIncoterms.AutoSize = False
        Me.cboIncoterms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboIncoterms.Location = New System.Drawing.Point(825, 74)
        Me.cboIncoterms.Name = "cboIncoterms"
        Me.cboIncoterms.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboIncoterms.Size = New System.Drawing.Size(130, 20)
        Me.cboIncoterms.TabIndex = 17
        '
        'lblModalidadeTransporte
        '
        Me.lblModalidadeTransporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblModalidadeTransporte.AutoSize = True
        Me.lblModalidadeTransporte.Location = New System.Drawing.Point(420, 57)
        Me.lblModalidadeTransporte.Name = "lblModalidadeTransporte"
        Me.lblModalidadeTransporte.Size = New System.Drawing.Size(135, 14)
        Me.lblModalidadeTransporte.TabIndex = 13
        Me.lblModalidadeTransporte.Text = "Modalidade de Transporte:"
        '
        'cboModalidadeTransporte
        '
        Me.cboModalidadeTransporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboModalidadeTransporte.AutoSize = False
        Me.cboModalidadeTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeTransporte.Location = New System.Drawing.Point(404, 74)
        Me.cboModalidadeTransporte.Name = "cboModalidadeTransporte"
        Me.cboModalidadeTransporte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeTransporte.Size = New System.Drawing.Size(415, 20)
        Me.cboModalidadeTransporte.TabIndex = 14
        '
        'lblTransportadora
        '
        Me.lblTransportadora.AutoSize = True
        Me.lblTransportadora.Location = New System.Drawing.Point(25, 57)
        Me.lblTransportadora.Name = "lblTransportadora"
        Me.lblTransportadora.Size = New System.Drawing.Size(85, 14)
        Me.lblTransportadora.TabIndex = 10
        Me.lblTransportadora.Text = "Transportadora:"
        '
        'cboTransportadora
        '
        Me.cboTransportadora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTransportadora.AutoSize = False
        Me.cboTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTransportadora.Location = New System.Drawing.Point(9, 74)
        Me.cboTransportadora.Name = "cboTransportadora"
        Me.cboTransportadora.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTransportadora.Size = New System.Drawing.Size(389, 20)
        Me.cboTransportadora.TabIndex = 11
        '
        'btnCadastrarModalidadeTransporte
        '
        Me.btnCadastrarModalidadeTransporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarModalidadeTransporte.FlatAppearance.BorderSize = 0
        Me.btnCadastrarModalidadeTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarModalidadeTransporte.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarModalidadeTransporte.Location = New System.Drawing.Point(404, 58)
        Me.btnCadastrarModalidadeTransporte.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarModalidadeTransporte.Name = "btnCadastrarModalidadeTransporte"
        Me.btnCadastrarModalidadeTransporte.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarModalidadeTransporte.TabIndex = 12
        Me.btnCadastrarModalidadeTransporte.TabStop = False
        Me.btnCadastrarModalidadeTransporte.UseVisualStyleBackColor = True
        '
        'btnCadastrarIncoterms
        '
        Me.btnCadastrarIncoterms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarIncoterms.FlatAppearance.BorderSize = 0
        Me.btnCadastrarIncoterms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarIncoterms.Image = CType(resources.GetObject("btnCadastrarIncoterms.Image"), System.Drawing.Image)
        Me.btnCadastrarIncoterms.Location = New System.Drawing.Point(825, 58)
        Me.btnCadastrarIncoterms.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarIncoterms.Name = "btnCadastrarIncoterms"
        Me.btnCadastrarIncoterms.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarIncoterms.TabIndex = 15
        Me.btnCadastrarIncoterms.TabStop = False
        Me.btnCadastrarIncoterms.UseVisualStyleBackColor = True
        '
        'btnCadastrarAgenteLogistico
        '
        Me.btnCadastrarAgenteLogistico.FlatAppearance.BorderSize = 0
        Me.btnCadastrarAgenteLogistico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarAgenteLogistico.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarAgenteLogistico.Location = New System.Drawing.Point(9, 98)
        Me.btnCadastrarAgenteLogistico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarAgenteLogistico.Name = "btnCadastrarAgenteLogistico"
        Me.btnCadastrarAgenteLogistico.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarAgenteLogistico.TabIndex = 18
        Me.btnCadastrarAgenteLogistico.TabStop = False
        Me.btnCadastrarAgenteLogistico.UseVisualStyleBackColor = True
        '
        'btnCadastrarTransportadora
        '
        Me.btnCadastrarTransportadora.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTransportadora.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarTransportadora.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarTransportadora.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTransportadora.Name = "btnCadastrarTransportadora"
        Me.btnCadastrarTransportadora.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTransportadora.TabIndex = 9
        Me.btnCadastrarTransportadora.TabStop = False
        Me.btnCadastrarTransportadora.UseVisualStyleBackColor = True
        '
        'lblAdministradorAcordoComercialFornecedor
        '
        Me.lblAdministradorAcordoComercialFornecedor.AutoSize = True
        Me.lblAdministradorAcordoComercialFornecedor.Location = New System.Drawing.Point(6, 17)
        Me.lblAdministradorAcordoComercialFornecedor.Name = "lblAdministradorAcordoComercialFornecedor"
        Me.lblAdministradorAcordoComercialFornecedor.Size = New System.Drawing.Size(246, 14)
        Me.lblAdministradorAcordoComercialFornecedor.TabIndex = 0
        Me.lblAdministradorAcordoComercialFornecedor.Text = "Administrador do Acordo Comercial - Fornecedor:"
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(612, 17)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblFormaPagamento.TabIndex = 5
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'txtAdministradorAcordoComercialFornecedor
        '
        Me.txtAdministradorAcordoComercialFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdministradorAcordoComercialFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdministradorAcordoComercialFornecedor.Location = New System.Drawing.Point(9, 34)
        Me.txtAdministradorAcordoComercialFornecedor.MaxLength = 100
        Me.txtAdministradorAcordoComercialFornecedor.Name = "txtAdministradorAcordoComercialFornecedor"
        Me.txtAdministradorAcordoComercialFornecedor.Size = New System.Drawing.Size(389, 20)
        Me.txtAdministradorAcordoComercialFornecedor.TabIndex = 1
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFormaPagamento.AutoSize = False
        Me.cboFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaPagamento.Location = New System.Drawing.Point(615, 34)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaPagamento.Size = New System.Drawing.Size(204, 20)
        Me.cboFormaPagamento.TabIndex = 6
        '
        'btnCadastrarCondicaoPagamento
        '
        Me.btnCadastrarCondicaoPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarCondicaoPagamento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCondicaoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCondicaoPagamento.Image = CType(resources.GetObject("btnCadastrarCondicaoPagamento.Image"), System.Drawing.Image)
        Me.btnCadastrarCondicaoPagamento.Location = New System.Drawing.Point(404, 18)
        Me.btnCadastrarCondicaoPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCondicaoPagamento.Name = "btnCadastrarCondicaoPagamento"
        Me.btnCadastrarCondicaoPagamento.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCondicaoPagamento.TabIndex = 2
        Me.btnCadastrarCondicaoPagamento.TabStop = False
        Me.btnCadastrarCondicaoPagamento.UseVisualStyleBackColor = True
        '
        'lblModalidadeFrete
        '
        Me.lblModalidadeFrete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblModalidadeFrete.AutoSize = True
        Me.lblModalidadeFrete.Location = New System.Drawing.Point(822, 17)
        Me.lblModalidadeFrete.Name = "lblModalidadeFrete"
        Me.lblModalidadeFrete.Size = New System.Drawing.Size(92, 14)
        Me.lblModalidadeFrete.TabIndex = 7
        Me.lblModalidadeFrete.Text = "Modalidade Frete:"
        '
        'cboCondicaoPagamento
        '
        Me.cboCondicaoPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCondicaoPagamento.AutoSize = False
        Me.cboCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCondicaoPagamento.Location = New System.Drawing.Point(404, 34)
        Me.cboCondicaoPagamento.Name = "cboCondicaoPagamento"
        Me.cboCondicaoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCondicaoPagamento.Size = New System.Drawing.Size(205, 20)
        Me.cboCondicaoPagamento.TabIndex = 4
        '
        'cboModalidadeFrete
        '
        Me.cboModalidadeFrete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboModalidadeFrete.AutoSize = False
        Me.cboModalidadeFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeFrete.Location = New System.Drawing.Point(825, 34)
        Me.cboModalidadeFrete.Name = "cboModalidadeFrete"
        Me.cboModalidadeFrete.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeFrete.Size = New System.Drawing.Size(130, 20)
        Me.cboModalidadeFrete.TabIndex = 8
        '
        'lblCondicaoPagamento
        '
        Me.lblCondicaoPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCondicaoPagamento.AutoSize = True
        Me.lblCondicaoPagamento.Location = New System.Drawing.Point(420, 17)
        Me.lblCondicaoPagamento.Name = "lblCondicaoPagamento"
        Me.lblCondicaoPagamento.Size = New System.Drawing.Size(126, 14)
        Me.lblCondicaoPagamento.TabIndex = 3
        Me.lblCondicaoPagamento.Text = "Condição de Pagamento:"
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
        Me.pagArquivo.Size = New System.Drawing.Size(980, 344)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Text = "Arquivos"
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 318)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 4
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 318)
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
        Me.btnConfigurarGridArquivo.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 318)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 2
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.lblRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.txtRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnCadastrarTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.cboTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Controls.Add(Me.txtDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblDescricaoArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(964, 104)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'lblRevisaoArquivo
        '
        Me.lblRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevisaoArquivo.AutoSize = True
        Me.lblRevisaoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRevisaoArquivo.Location = New System.Drawing.Point(660, 17)
        Me.lblRevisaoArquivo.Name = "lblRevisaoArquivo"
        Me.lblRevisaoArquivo.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoArquivo.TabIndex = 2
        Me.lblRevisaoArquivo.Text = "Revisão:"
        '
        'txtRevisaoArquivo
        '
        Me.txtRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRevisaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisaoArquivo.Location = New System.Drawing.Point(663, 34)
        Me.txtRevisaoArquivo.MaxLength = 5
        Me.txtRevisaoArquivo.Name = "txtRevisaoArquivo"
        Me.txtRevisaoArquivo.Size = New System.Drawing.Size(89, 20)
        Me.txtRevisaoArquivo.TabIndex = 3
        '
        'btnCadastrarTipoArquivo
        '
        Me.btnCadastrarTipoArquivo.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoArquivo.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarTipoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoArquivo.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarTipoArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoArquivo.Name = "btnCadastrarTipoArquivo"
        Me.btnCadastrarTipoArquivo.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoArquivo.TabIndex = 4
        Me.btnCadastrarTipoArquivo.TabStop = False
        Me.btnCadastrarTipoArquivo.UseVisualStyleBackColor = True
        '
        'lblTipoArquivo
        '
        Me.lblTipoArquivo.AutoSize = True
        Me.lblTipoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoArquivo.Location = New System.Drawing.Point(25, 57)
        Me.lblTipoArquivo.Name = "lblTipoArquivo"
        Me.lblTipoArquivo.Size = New System.Drawing.Size(85, 14)
        Me.lblTipoArquivo.TabIndex = 5
        Me.lblTipoArquivo.Text = "Tipo do Arquivo:"
        '
        'cboTipoArquivo
        '
        Me.cboTipoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoArquivo.Location = New System.Drawing.Point(9, 74)
        Me.cboTipoArquivo.Name = "cboTipoArquivo"
        Me.cboTipoArquivo.Size = New System.Drawing.Size(240, 20)
        Me.cboTipoArquivo.TabIndex = 6
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(732, 74)
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
        Me.lblArquivo.Location = New System.Drawing.Point(252, 57)
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
        Me.txtArquivo.Location = New System.Drawing.Point(255, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(478, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.excluir
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
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.salvar
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
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(648, 20)
        Me.txtDescricaoArquivo.TabIndex = 1
        '
        'lblDescricaoArquivo
        '
        Me.lblDescricaoArquivo.AutoSize = True
        Me.lblDescricaoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoArquivo.Name = "lblDescricaoArquivo"
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoArquivo.TabIndex = 0
        Me.lblDescricaoArquivo.Text = "Descrição:"
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
        grdArquivo_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_1.Instance"), Object)
        grdArquivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivo_DesignTimeLayout_Reference_0, grdArquivo_DesignTimeLayout_Reference_1})
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
        Me.grdArquivo.Size = New System.Drawing.Size(964, 219)
        Me.grdArquivo.TabIndex = 1
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'usrCmpAcordoComercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpAcordoComercial"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpAcordoComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAcordoComercial.ResumeLayout(False)
        Me.grpAcordoComercial.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagProduto.ResumeLayout(False)
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDadosGerais.ResumeLayout(False)
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosGerais.ResumeLayout(False)
        Me.grpDadosGerais.PerformLayout()
        Me.pagArquivo.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents dtpDataValidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents grpAcordoComercial As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroAcordoComercial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroAcordoComercial As System.Windows.Forms.Label
    Friend WithEvents lblDataValidade As System.Windows.Forms.Label
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblMoeda As System.Windows.Forms.Label
    Friend WithEvents cboMoeda As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarMoeda As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAdministradorAcordoComercialFornecedor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAdministradorAcordoComercialFornecedor As System.Windows.Forms.Label
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModalidadeFrete As System.Windows.Forms.Label
    Friend WithEvents cboModalidadeFrete As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCondicaoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboCondicaoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarCondicaoPagamento As System.Windows.Forms.Button
    Friend WithEvents txtFatorCambial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtLeadTime As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLeadTime As System.Windows.Forms.Label
    Friend WithEvents txtPrecoCompra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoCompra As System.Windows.Forms.Label
    Friend WithEvents btnExcluirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents lblDescricaoProduto As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents cboUnidadeMedidaProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaProduto As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeMinimaProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeMinimaProduto As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarUnidadeMedidaProduto As System.Windows.Forms.Button
    Friend WithEvents txtDescontoValorProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoValorProduto As System.Windows.Forms.Label
    Friend WithEvents txtDescontoPercentualProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoPercentualProduto As System.Windows.Forms.Label
    Friend WithEvents chkPISCOFINSEmbutido As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtAliquotaPISCOFINSProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtAliquotaICMSProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents chkIPIEmbutido As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkICMSEmbutido As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtAliquotaIPIProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosGerais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAgenteLogistico As System.Windows.Forms.Label
    Friend WithEvents cboAgenteLogistico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblIncoterms As System.Windows.Forms.Label
    Friend WithEvents cboIncoterms As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModalidadeTransporte As System.Windows.Forms.Label
    Friend WithEvents cboModalidadeTransporte As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTransportadora As System.Windows.Forms.Label
    Friend WithEvents cboTransportadora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarModalidadeTransporte As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarIncoterms As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarAgenteLogistico As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarTransportadora As System.Windows.Forms.Button
    Friend WithEvents lblInstrucaoEmbarque As System.Windows.Forms.Label
    Friend WithEvents cboInstrucaoEmbarque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarInstrucaoEmbarque As System.Windows.Forms.Button
    Friend WithEvents txtDescritivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescritivo As System.Windows.Forms.Label
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtObservacaoOrcamento As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarFornecedorFiltro As System.Windows.Forms.Button
    Friend WithEvents txtDescritivoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescritivoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblMoedaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboMoedaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataValidadeInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataValidadeFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataValidadeTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumeroAcordoComercialFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroAcordoComercialFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataInicioFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicioTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboFornecedorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtRevisaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRevisaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtRevisao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRevisao As System.Windows.Forms.Label
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRevisaoArquivo As System.Windows.Forms.Label
    Friend WithEvents txtRevisaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnCadastrarTipoArquivo As System.Windows.Forms.Button
    Friend WithEvents lblTipoArquivo As System.Windows.Forms.Label
    Friend WithEvents cboTipoArquivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As System.Windows.Forms.Label
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX

End Class
