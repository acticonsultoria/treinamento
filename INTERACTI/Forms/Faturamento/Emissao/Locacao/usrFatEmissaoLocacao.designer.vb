<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEmissaoLocacao
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEmissaoLocacao))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim grdListagem_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.Image")
        Dim grdListagem_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.Image")
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdDuplicata_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaAutozidadaParaUso = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCancelada = New System.Windows.Forms.Label()
        Me.picLegendaCancelada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaElaboracao = New System.Windows.Forms.Label()
        Me.picLegendaElaboracao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAutozidadaParaUso = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.txtClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosNotaFiscal = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpEnderecoCliente = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTelefoneCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefoneCliente = New System.Windows.Forms.Label()
        Me.txtEmailCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmailCliente = New System.Windows.Forms.Label()
        Me.cboMunicipioCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplementoCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairroCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPaisCliente = New System.Windows.Forms.Label()
        Me.cboPaisCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCEPCliente = New System.Windows.Forms.Label()
        Me.txtCEPCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplementoCliente = New System.Windows.Forms.Label()
        Me.lblUFCliente = New System.Windows.Forms.Label()
        Me.cboUFCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipioCliente = New System.Windows.Forms.Label()
        Me.lblBairroCliente = New System.Windows.Forms.Label()
        Me.lblNumeroCliente = New System.Windows.Forms.Label()
        Me.lblLogradouroCliente = New System.Windows.Forms.Label()
        Me.txtLogradouroCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnProcurarCEPCliente = New System.Windows.Forms.Button()
        Me.btnCadastrarPaisCliente = New System.Windows.Forms.Button()
        Me.grpIdentificacaoCliente = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.txtCNPJCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtInscricaoMunicipalCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoMunicipalCliente = New System.Windows.Forms.Label()
        Me.txtInscricaoEstadualCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadualCliente = New System.Windows.Forms.Label()
        Me.lblCNPJCliente = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarCliente = New System.Windows.Forms.Button()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboSerie = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.cboModelo = New Janus.Windows.EditControls.UIComboBox()
        Me.grpEnderecoEmitente = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblValorUFEmitente = New System.Windows.Forms.Label()
        Me.lblValorPaisEmitente = New System.Windows.Forms.Label()
        Me.lblValorCEPEmiente = New System.Windows.Forms.Label()
        Me.lblValorMunicipioEmitente = New System.Windows.Forms.Label()
        Me.lblValorBairroEmitente = New System.Windows.Forms.Label()
        Me.lblValorComplementoEmitente = New System.Windows.Forms.Label()
        Me.lblValorNumeroEmitente = New System.Windows.Forms.Label()
        Me.lblValorLogradouroEmitente = New System.Windows.Forms.Label()
        Me.lblPaisEmitente = New System.Windows.Forms.Label()
        Me.lblCEPEmiente = New System.Windows.Forms.Label()
        Me.lblUFEmitente = New System.Windows.Forms.Label()
        Me.lblMunicipioEmitente = New System.Windows.Forms.Label()
        Me.lblBairroEmitente = New System.Windows.Forms.Label()
        Me.lblComplementoEmitente = New System.Windows.Forms.Label()
        Me.lblNumeroEmitente = New System.Windows.Forms.Label()
        Me.lblLogradouroEmitente = New System.Windows.Forms.Label()
        Me.grpDadosEmitente = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblValorRegimeTributarioEmitente = New System.Windows.Forms.Label()
        Me.lblValorInscricaoEstadualEmitente = New System.Windows.Forms.Label()
        Me.lblValorInscricaoMunicipalEmitente = New System.Windows.Forms.Label()
        Me.lblValorNomeFantasiaEmitente = New System.Windows.Forms.Label()
        Me.lblRegimeTributarioEmitente = New System.Windows.Forms.Label()
        Me.lblInscricaoMunicipalEmitente = New System.Windows.Forms.Label()
        Me.lblInscricaoEstadualEmitente = New System.Windows.Forms.Label()
        Me.lblNomeFantasiaEmitente = New System.Windows.Forms.Label()
        Me.lblValorRazaoSocialEmitente = New System.Windows.Forms.Label()
        Me.lblRazaoSocialEmitente = New System.Windows.Forms.Label()
        Me.lblValorCNPJEmitente = New System.Windows.Forms.Label()
        Me.lblCNPJEmitente = New System.Windows.Forms.Label()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.grpItens = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPedidoVenda = New System.Windows.Forms.Label()
        Me.cboPedidoVenda = New Janus.Windows.EditControls.UIComboBox()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.btnExcluirProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.pagCobranca = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpImposto = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkLei10833 = New Janus.Windows.EditControls.UICheckBox()
        Me.chkINSS = New Janus.Windows.EditControls.UICheckBox()
        Me.chkISS = New Janus.Windows.EditControls.UICheckBox()
        Me.chkIR = New Janus.Windows.EditControls.UICheckBox()
        Me.txtIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtISS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtINSS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtLei10833 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpDadosAdicionais = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboDadosAdicionaisPreCadastrado = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDadosAdicionaisPreCadastrado = New System.Windows.Forms.Label()
        Me.lblDadosAdicionais = New System.Windows.Forms.Label()
        Me.txtDadosAdicionais = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.btnCadastrarDadosAdicionais = New System.Windows.Forms.Button()
        Me.grpDuplicata = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCalcularDuplicata = New Janus.Windows.EditControls.UIButton()
        Me.txtIntervaloEntreParcelas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIntervaloEntreParcelas = New System.Windows.Forms.Label()
        Me.txtNumeroParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroParcela = New System.Windows.Forms.Label()
        Me.lblCodigoCondicaoPagamento = New System.Windows.Forms.Label()
        Me.cboCondicaoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.grdDuplicata = New Janus.Windows.GridEX.GridEX()
        Me.grpFatura = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorRetido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorRetido = New System.Windows.Forms.Label()
        Me.txtValorLiquido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorLiquido = New System.Windows.Forms.Label()
        Me.lblValorDesconto = New System.Windows.Forms.Label()
        Me.txtValorOriginal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOriginal = New System.Windows.Forms.Label()
        Me.txtFatura = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFatura = New System.Windows.Forms.Label()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRevisaoArquivo = New System.Windows.Forms.Label()
        Me.txtRevisaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoArquivo = New System.Windows.Forms.Label()
        Me.cboTipoArquivo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.btnCadastrarTipoArquivo = New System.Windows.Forms.Button()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaElaboracao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDadosNotaFiscal.SuspendLayout()
        CType(Me.grpEnderecoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnderecoCliente.SuspendLayout()
        CType(Me.grpIdentificacaoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIdentificacaoCliente.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpEnderecoEmitente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnderecoEmitente.SuspendLayout()
        CType(Me.grpDadosEmitente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosEmitente.SuspendLayout()
        Me.pagProduto.SuspendLayout()
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItens.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCobranca.SuspendLayout()
        CType(Me.grpImposto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImposto.SuspendLayout()
        CType(Me.grpDadosAdicionais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosAdicionais.SuspendLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDuplicata.SuspendLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFatura.SuspendLayout()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.grpControle)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Nota Fiscal - Locação"
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
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
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
        Me.grpLegenda.Controls.Add(Me.picLegendaAutozidadaParaUso)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCancelada)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaElaboracao)
        Me.grpLegenda.Controls.Add(Me.picLegendaElaboracao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAutozidadaParaUso)
        Me.grpLegenda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(253, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaAutozidadaParaUso
        '
        Me.picLegendaAutozidadaParaUso.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaAutozidadaParaUso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAutozidadaParaUso.Location = New System.Drawing.Point(95, 21)
        Me.picLegendaAutozidadaParaUso.Name = "picLegendaAutozidadaParaUso"
        Me.picLegendaAutozidadaParaUso.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAutozidadaParaUso.TabIndex = 16
        Me.picLegendaAutozidadaParaUso.TabStop = False
        '
        'lblLegendaCancelada
        '
        Me.lblLegendaCancelada.AutoSize = True
        Me.lblLegendaCancelada.Location = New System.Drawing.Point(190, 21)
        Me.lblLegendaCancelada.Name = "lblLegendaCancelada"
        Me.lblLegendaCancelada.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelada.TabIndex = 2
        Me.lblLegendaCancelada.Text = "Cancelada"
        '
        'picLegendaCancelada
        '
        Me.picLegendaCancelada.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelada.Location = New System.Drawing.Point(171, 21)
        Me.picLegendaCancelada.Name = "picLegendaCancelada"
        Me.picLegendaCancelada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelada.TabIndex = 14
        Me.picLegendaCancelada.TabStop = False
        '
        'lblLegendaElaboracao
        '
        Me.lblLegendaElaboracao.AutoSize = True
        Me.lblLegendaElaboracao.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaElaboracao.Name = "lblLegendaElaboracao"
        Me.lblLegendaElaboracao.Size = New System.Drawing.Size(61, 14)
        Me.lblLegendaElaboracao.TabIndex = 0
        Me.lblLegendaElaboracao.Text = "Elaboração"
        '
        'picLegendaElaboracao
        '
        Me.picLegendaElaboracao.BackColor = System.Drawing.Color.DimGray
        Me.picLegendaElaboracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaElaboracao.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaElaboracao.Name = "picLegendaElaboracao"
        Me.picLegendaElaboracao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaElaboracao.TabIndex = 4
        Me.picLegendaElaboracao.TabStop = False
        '
        'lblLegendaAutozidadaParaUso
        '
        Me.lblLegendaAutozidadaParaUso.AutoSize = True
        Me.lblLegendaAutozidadaParaUso.Location = New System.Drawing.Point(114, 21)
        Me.lblLegendaAutozidadaParaUso.Name = "lblLegendaAutozidadaParaUso"
        Me.lblLegendaAutozidadaParaUso.Size = New System.Drawing.Size(51, 14)
        Me.lblLegendaAutozidadaParaUso.TabIndex = 1
        Me.lblLegendaAutozidadaParaUso.Text = "Impresso"
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
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(270, 483)
        Me.grpControle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(635, 51)
        Me.grpControle.TabIndex = 5
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(341, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 0
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(438, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(535, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_4.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_5.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3, grdListagem_DesignTimeLayout_Reference_4, grdListagem_DesignTimeLayout_Reference_5})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(284, 20)
        Me.cboStatusFiltro.TabIndex = 10
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteFiltro.Location = New System.Drawing.Point(413, 34)
        Me.txtClienteFiltro.MaxLength = 60
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.Size = New System.Drawing.Size(361, 20)
        Me.txtClienteFiltro.TabIndex = 8
        '
        'txtSerieFiltro
        '
        Me.txtSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieFiltro.Location = New System.Drawing.Point(119, 34)
        Me.txtSerieFiltro.MaxLength = 3
        Me.txtSerieFiltro.Name = "txtSerieFiltro"
        Me.txtSerieFiltro.Size = New System.Drawing.Size(60, 20)
        Me.txtSerieFiltro.TabIndex = 3
        '
        'lblSerieFiltro
        '
        Me.lblSerieFiltro.AutoSize = True
        Me.lblSerieFiltro.Location = New System.Drawing.Point(116, 17)
        Me.lblSerieFiltro.Name = "lblSerieFiltro"
        Me.lblSerieFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieFiltro.TabIndex = 2
        Me.lblSerieFiltro.Text = "Série:"
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.IncludeLiterals = False
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscalFiltro.MaxLength = 9
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(104, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 1
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 9
        Me.lblStatusFiltro.Text = "Status:"
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(410, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 7
        Me.lblClienteFiltro.Text = "Cliente:"
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
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(299, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 6
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(185, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 5
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(182, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 4
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Nota Fiscal - Locação"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(8, 7)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 473)
        Me.tabDados.TabIndex = 0
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosNotaFiscal, Me.pagProduto, Me.pagCobranca, Me.pagArquivo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDadosNotaFiscal
        '
        Me.pagDadosNotaFiscal.Controls.Add(Me.grpEnderecoCliente)
        Me.pagDadosNotaFiscal.Controls.Add(Me.grpIdentificacaoCliente)
        Me.pagDadosNotaFiscal.Controls.Add(Me.grpDados)
        Me.pagDadosNotaFiscal.Controls.Add(Me.grpEnderecoEmitente)
        Me.pagDadosNotaFiscal.Controls.Add(Me.grpDadosEmitente)
        Me.pagDadosNotaFiscal.Key = "pagDadosNotaFiscal"
        Me.pagDadosNotaFiscal.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosNotaFiscal.Name = "pagDadosNotaFiscal"
        Me.pagDadosNotaFiscal.Size = New System.Drawing.Size(895, 450)
        Me.pagDadosNotaFiscal.TabStop = True
        Me.pagDadosNotaFiscal.Text = "Dados da Nota Fiscal"
        '
        'grpEnderecoCliente
        '
        Me.grpEnderecoCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEnderecoCliente.BackColor = System.Drawing.Color.Transparent
        Me.grpEnderecoCliente.Controls.Add(Me.txtTelefoneCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblTelefoneCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.txtEmailCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblEmailCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.cboMunicipioCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.txtNumeroCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.txtComplementoCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.txtBairroCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblPaisCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.cboPaisCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblCEPCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.txtCEPCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblComplementoCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblUFCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.cboUFCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblMunicipioCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblBairroCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblNumeroCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.lblLogradouroCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.txtLogradouroCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.btnProcurarCEPCliente)
        Me.grpEnderecoCliente.Controls.Add(Me.btnCadastrarPaisCliente)
        Me.grpEnderecoCliente.Location = New System.Drawing.Point(8, 337)
        Me.grpEnderecoCliente.Name = "grpEnderecoCliente"
        Me.grpEnderecoCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEnderecoCliente.Size = New System.Drawing.Size(879, 104)
        Me.grpEnderecoCliente.TabIndex = 5
        Me.grpEnderecoCliente.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEnderecoCliente.VisualStyleManager = Me.vsmMain
        '
        'txtTelefoneCliente
        '
        Me.txtTelefoneCliente.Enabled = False
        Me.txtTelefoneCliente.Location = New System.Drawing.Point(420, 74)
        Me.txtTelefoneCliente.Mask = "!(##) 0000-0000"
        Me.txtTelefoneCliente.MaxLength = 10
        Me.txtTelefoneCliente.Name = "txtTelefoneCliente"
        Me.txtTelefoneCliente.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefoneCliente.TabIndex = 18
        '
        'lblTelefoneCliente
        '
        Me.lblTelefoneCliente.AutoSize = True
        Me.lblTelefoneCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefoneCliente.Location = New System.Drawing.Point(417, 57)
        Me.lblTelefoneCliente.Name = "lblTelefoneCliente"
        Me.lblTelefoneCliente.Size = New System.Drawing.Size(51, 14)
        Me.lblTelefoneCliente.TabIndex = 17
        Me.lblTelefoneCliente.Text = "Telefone:"
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmailCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailCliente.Enabled = False
        Me.txtEmailCliente.Location = New System.Drawing.Point(534, 74)
        Me.txtEmailCliente.MaxLength = 60
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(336, 20)
        Me.txtEmailCliente.TabIndex = 20
        '
        'lblEmailCliente
        '
        Me.lblEmailCliente.AutoSize = True
        Me.lblEmailCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmailCliente.Location = New System.Drawing.Point(531, 57)
        Me.lblEmailCliente.Name = "lblEmailCliente"
        Me.lblEmailCliente.Size = New System.Drawing.Size(38, 14)
        Me.lblEmailCliente.TabIndex = 19
        Me.lblEmailCliente.Text = "E-mail:"
        '
        'cboMunicipioCliente
        '
        Me.cboMunicipioCliente.AutoSize = False
        Me.cboMunicipioCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipioCliente.Enabled = False
        Me.cboMunicipioCliente.Location = New System.Drawing.Point(311, 34)
        Me.cboMunicipioCliente.Name = "cboMunicipioCliente"
        Me.cboMunicipioCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipioCliente.Size = New System.Drawing.Size(217, 20)
        Me.cboMunicipioCliente.TabIndex = 8
        '
        'txtNumeroCliente
        '
        Me.txtNumeroCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCliente.Enabled = False
        Me.txtNumeroCliente.Location = New System.Drawing.Point(806, 34)
        Me.txtNumeroCliente.MaxLength = 60
        Me.txtNumeroCliente.Name = "txtNumeroCliente"
        Me.txtNumeroCliente.Size = New System.Drawing.Size(64, 20)
        Me.txtNumeroCliente.TabIndex = 12
        '
        'txtComplementoCliente
        '
        Me.txtComplementoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoCliente.Enabled = False
        Me.txtComplementoCliente.Location = New System.Drawing.Point(247, 74)
        Me.txtComplementoCliente.MaxLength = 60
        Me.txtComplementoCliente.Name = "txtComplementoCliente"
        Me.txtComplementoCliente.Size = New System.Drawing.Size(167, 20)
        Me.txtComplementoCliente.TabIndex = 16
        '
        'txtBairroCliente
        '
        Me.txtBairroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairroCliente.Enabled = False
        Me.txtBairroCliente.Location = New System.Drawing.Point(9, 74)
        Me.txtBairroCliente.MaxLength = 60
        Me.txtBairroCliente.Name = "txtBairroCliente"
        Me.txtBairroCliente.Size = New System.Drawing.Size(232, 20)
        Me.txtBairroCliente.TabIndex = 14
        '
        'lblPaisCliente
        '
        Me.lblPaisCliente.AutoSize = True
        Me.lblPaisCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPaisCliente.Location = New System.Drawing.Point(98, 17)
        Me.lblPaisCliente.Name = "lblPaisCliente"
        Me.lblPaisCliente.Size = New System.Drawing.Size(30, 14)
        Me.lblPaisCliente.TabIndex = 3
        Me.lblPaisCliente.Text = "País:"
        '
        'cboPaisCliente
        '
        Me.cboPaisCliente.AutoSize = False
        Me.cboPaisCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPaisCliente.Enabled = False
        Me.cboPaisCliente.Location = New System.Drawing.Point(82, 34)
        Me.cboPaisCliente.Name = "cboPaisCliente"
        Me.cboPaisCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPaisCliente.Size = New System.Drawing.Size(159, 20)
        Me.cboPaisCliente.TabIndex = 4
        '
        'lblCEPCliente
        '
        Me.lblCEPCliente.AutoSize = True
        Me.lblCEPCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCEPCliente.Location = New System.Drawing.Point(6, 17)
        Me.lblCEPCliente.Name = "lblCEPCliente"
        Me.lblCEPCliente.Size = New System.Drawing.Size(29, 14)
        Me.lblCEPCliente.TabIndex = 0
        Me.lblCEPCliente.Text = "CEP:"
        '
        'txtCEPCliente
        '
        Me.txtCEPCliente.Enabled = False
        Me.txtCEPCliente.Location = New System.Drawing.Point(9, 34)
        Me.txtCEPCliente.Mask = "00000-000"
        Me.txtCEPCliente.MaxLength = 10
        Me.txtCEPCliente.Name = "txtCEPCliente"
        Me.txtCEPCliente.Size = New System.Drawing.Size(67, 20)
        Me.txtCEPCliente.TabIndex = 1
        '
        'lblComplementoCliente
        '
        Me.lblComplementoCliente.AutoSize = True
        Me.lblComplementoCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComplementoCliente.Location = New System.Drawing.Point(244, 57)
        Me.lblComplementoCliente.Name = "lblComplementoCliente"
        Me.lblComplementoCliente.Size = New System.Drawing.Size(74, 14)
        Me.lblComplementoCliente.TabIndex = 15
        Me.lblComplementoCliente.Text = "Complemento:"
        '
        'lblUFCliente
        '
        Me.lblUFCliente.AutoSize = True
        Me.lblUFCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFCliente.Location = New System.Drawing.Point(244, 17)
        Me.lblUFCliente.Name = "lblUFCliente"
        Me.lblUFCliente.Size = New System.Drawing.Size(23, 14)
        Me.lblUFCliente.TabIndex = 5
        Me.lblUFCliente.Text = "UF:"
        '
        'cboUFCliente
        '
        Me.cboUFCliente.AutoSize = False
        Me.cboUFCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFCliente.Enabled = False
        Me.cboUFCliente.Location = New System.Drawing.Point(247, 34)
        Me.cboUFCliente.Name = "cboUFCliente"
        Me.cboUFCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFCliente.Size = New System.Drawing.Size(58, 20)
        Me.cboUFCliente.TabIndex = 7
        '
        'lblMunicipioCliente
        '
        Me.lblMunicipioCliente.AutoSize = True
        Me.lblMunicipioCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipioCliente.Location = New System.Drawing.Point(308, 17)
        Me.lblMunicipioCliente.Name = "lblMunicipioCliente"
        Me.lblMunicipioCliente.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipioCliente.TabIndex = 6
        Me.lblMunicipioCliente.Text = "Município:"
        '
        'lblBairroCliente
        '
        Me.lblBairroCliente.AutoSize = True
        Me.lblBairroCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBairroCliente.Location = New System.Drawing.Point(6, 57)
        Me.lblBairroCliente.Name = "lblBairroCliente"
        Me.lblBairroCliente.Size = New System.Drawing.Size(39, 14)
        Me.lblBairroCliente.TabIndex = 13
        Me.lblBairroCliente.Text = "Bairro:"
        '
        'lblNumeroCliente
        '
        Me.lblNumeroCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroCliente.AutoSize = True
        Me.lblNumeroCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroCliente.Location = New System.Drawing.Point(803, 17)
        Me.lblNumeroCliente.Name = "lblNumeroCliente"
        Me.lblNumeroCliente.Size = New System.Drawing.Size(47, 14)
        Me.lblNumeroCliente.TabIndex = 11
        Me.lblNumeroCliente.Text = "Número:"
        '
        'lblLogradouroCliente
        '
        Me.lblLogradouroCliente.AutoSize = True
        Me.lblLogradouroCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLogradouroCliente.Location = New System.Drawing.Point(531, 17)
        Me.lblLogradouroCliente.Name = "lblLogradouroCliente"
        Me.lblLogradouroCliente.Size = New System.Drawing.Size(66, 14)
        Me.lblLogradouroCliente.TabIndex = 9
        Me.lblLogradouroCliente.Text = "Logradouro:"
        '
        'txtLogradouroCliente
        '
        Me.txtLogradouroCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogradouroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouroCliente.Enabled = False
        Me.txtLogradouroCliente.Location = New System.Drawing.Point(534, 34)
        Me.txtLogradouroCliente.MaxLength = 60
        Me.txtLogradouroCliente.Name = "txtLogradouroCliente"
        Me.txtLogradouroCliente.Size = New System.Drawing.Size(266, 20)
        Me.txtLogradouroCliente.TabIndex = 10
        '
        'btnProcurarCEPCliente
        '
        Me.btnProcurarCEPCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCEPCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCEPCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCEPCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCEPCliente.Location = New System.Drawing.Point(59, 15)
        Me.btnProcurarCEPCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCEPCliente.Name = "btnProcurarCEPCliente"
        Me.btnProcurarCEPCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCEPCliente.TabIndex = 2
        Me.btnProcurarCEPCliente.TabStop = False
        Me.btnProcurarCEPCliente.UseVisualStyleBackColor = True
        '
        'btnCadastrarPaisCliente
        '
        Me.btnCadastrarPaisCliente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPaisCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPaisCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarPaisCliente.Location = New System.Drawing.Point(82, 18)
        Me.btnCadastrarPaisCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarPaisCliente.Name = "btnCadastrarPaisCliente"
        Me.btnCadastrarPaisCliente.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarPaisCliente.TabIndex = 3
        Me.btnCadastrarPaisCliente.TabStop = False
        Me.btnCadastrarPaisCliente.UseVisualStyleBackColor = True
        '
        'grpIdentificacaoCliente
        '
        Me.grpIdentificacaoCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpIdentificacaoCliente.BackColor = System.Drawing.Color.Transparent
        Me.grpIdentificacaoCliente.Controls.Add(Me.btnProcurarCliente)
        Me.grpIdentificacaoCliente.Controls.Add(Me.txtCNPJCliente)
        Me.grpIdentificacaoCliente.Controls.Add(Me.txtInscricaoMunicipalCliente)
        Me.grpIdentificacaoCliente.Controls.Add(Me.lblInscricaoMunicipalCliente)
        Me.grpIdentificacaoCliente.Controls.Add(Me.txtInscricaoEstadualCliente)
        Me.grpIdentificacaoCliente.Controls.Add(Me.lblInscricaoEstadualCliente)
        Me.grpIdentificacaoCliente.Controls.Add(Me.lblCNPJCliente)
        Me.grpIdentificacaoCliente.Controls.Add(Me.lblCliente)
        Me.grpIdentificacaoCliente.Controls.Add(Me.cboCliente)
        Me.grpIdentificacaoCliente.Controls.Add(Me.btnCadastrarCliente)
        Me.grpIdentificacaoCliente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpIdentificacaoCliente.Location = New System.Drawing.Point(8, 267)
        Me.grpIdentificacaoCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpIdentificacaoCliente.Name = "grpIdentificacaoCliente"
        Me.grpIdentificacaoCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpIdentificacaoCliente.Size = New System.Drawing.Size(879, 67)
        Me.grpIdentificacaoCliente.TabIndex = 4
        Me.grpIdentificacaoCliente.Text = "Identificação"
        Me.grpIdentificacaoCliente.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(376, 18)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 2
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'txtCNPJCliente
        '
        Me.txtCNPJCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCNPJCliente.BackColor = System.Drawing.Color.White
        Me.txtCNPJCliente.Enabled = False
        Me.txtCNPJCliente.Location = New System.Drawing.Point(399, 37)
        Me.txtCNPJCliente.Mask = "00,000,000/0000-00"
        Me.txtCNPJCliente.MaxLength = 25
        Me.txtCNPJCliente.Name = "txtCNPJCliente"
        Me.txtCNPJCliente.Size = New System.Drawing.Size(129, 20)
        Me.txtCNPJCliente.TabIndex = 5
        '
        'txtInscricaoMunicipalCliente
        '
        Me.txtInscricaoMunicipalCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInscricaoMunicipalCliente.BackColor = System.Drawing.Color.White
        Me.txtInscricaoMunicipalCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoMunicipalCliente.Enabled = False
        Me.txtInscricaoMunicipalCliente.Location = New System.Drawing.Point(670, 37)
        Me.txtInscricaoMunicipalCliente.MaxLength = 9
        Me.txtInscricaoMunicipalCliente.Name = "txtInscricaoMunicipalCliente"
        Me.txtInscricaoMunicipalCliente.Size = New System.Drawing.Size(130, 20)
        Me.txtInscricaoMunicipalCliente.TabIndex = 9
        '
        'lblInscricaoMunicipalCliente
        '
        Me.lblInscricaoMunicipalCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInscricaoMunicipalCliente.AutoSize = True
        Me.lblInscricaoMunicipalCliente.Location = New System.Drawing.Point(667, 20)
        Me.lblInscricaoMunicipalCliente.Name = "lblInscricaoMunicipalCliente"
        Me.lblInscricaoMunicipalCliente.Size = New System.Drawing.Size(101, 14)
        Me.lblInscricaoMunicipalCliente.TabIndex = 8
        Me.lblInscricaoMunicipalCliente.Text = "Inscrição Municipal:"
        '
        'txtInscricaoEstadualCliente
        '
        Me.txtInscricaoEstadualCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInscricaoEstadualCliente.BackColor = System.Drawing.Color.White
        Me.txtInscricaoEstadualCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoEstadualCliente.Enabled = False
        Me.txtInscricaoEstadualCliente.Location = New System.Drawing.Point(534, 37)
        Me.txtInscricaoEstadualCliente.MaxLength = 14
        Me.txtInscricaoEstadualCliente.Name = "txtInscricaoEstadualCliente"
        Me.txtInscricaoEstadualCliente.Size = New System.Drawing.Size(130, 20)
        Me.txtInscricaoEstadualCliente.TabIndex = 7
        '
        'lblInscricaoEstadualCliente
        '
        Me.lblInscricaoEstadualCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInscricaoEstadualCliente.AutoSize = True
        Me.lblInscricaoEstadualCliente.Location = New System.Drawing.Point(531, 20)
        Me.lblInscricaoEstadualCliente.Name = "lblInscricaoEstadualCliente"
        Me.lblInscricaoEstadualCliente.Size = New System.Drawing.Size(98, 14)
        Me.lblInscricaoEstadualCliente.TabIndex = 6
        Me.lblInscricaoEstadualCliente.Text = "Inscrição Estadual:"
        '
        'lblCNPJCliente
        '
        Me.lblCNPJCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPJCliente.AutoSize = True
        Me.lblCNPJCliente.Location = New System.Drawing.Point(396, 20)
        Me.lblCNPJCliente.Name = "lblCNPJCliente"
        Me.lblCNPJCliente.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJCliente.TabIndex = 4
        Me.lblCNPJCliente.Text = "CNPJ:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(25, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 14)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente"
        '
        'cboCliente
        '
        Me.cboCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(9, 37)
        Me.cboCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(384, 20)
        Me.cboCliente.TabIndex = 3
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCliente.Image = CType(resources.GetObject("btnCadastrarCliente.Image"), System.Drawing.Image)
        Me.btnCadastrarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCliente.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCliente.TabIndex = 0
        Me.btnCadastrarCliente.TabStop = False
        Me.btnCadastrarCliente.UseVisualStyleBackColor = True
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtDataEmissao)
        Me.grpDados.Controls.Add(Me.cboSerie)
        Me.grpDados.Controls.Add(Me.lblDataEmissao)
        Me.grpDados.Controls.Add(Me.lblSerie)
        Me.grpDados.Controls.Add(Me.txtNotaFiscal)
        Me.grpDados.Controls.Add(Me.lblNotaFiscal)
        Me.grpDados.Controls.Add(Me.lblModelo)
        Me.grpDados.Controls.Add(Me.cboModelo)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(879, 67)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados da NFS-e"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataEmissao.Location = New System.Drawing.Point(284, 37)
        Me.txtDataEmissao.MaxLength = 50
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.ReadOnly = True
        Me.txtDataEmissao.Size = New System.Drawing.Size(135, 20)
        Me.txtDataEmissao.TabIndex = 22
        Me.txtDataEmissao.TabStop = False
        Me.txtDataEmissao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'cboSerie
        '
        Me.cboSerie.AutoSize = False
        Me.cboSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSerie.Location = New System.Drawing.Point(123, 37)
        Me.cboSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSerie.Name = "cboSerie"
        Me.cboSerie.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSerie.Size = New System.Drawing.Size(53, 20)
        Me.cboSerie.TabIndex = 3
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(281, 20)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 6
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(120, 20)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Série:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaFiscal.Location = New System.Drawing.Point(182, 37)
        Me.txtNotaFiscal.MaxLength = 50
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.ReadOnly = True
        Me.txtNotaFiscal.Size = New System.Drawing.Size(96, 20)
        Me.txtNotaFiscal.TabIndex = 5
        Me.txtNotaFiscal.TabStop = False
        Me.txtNotaFiscal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(179, 20)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(47, 14)
        Me.lblNotaFiscal.TabIndex = 4
        Me.lblNotaFiscal.Text = "Número:"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BackColor = System.Drawing.Color.Transparent
        Me.lblModelo.Location = New System.Drawing.Point(6, 20)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(44, 14)
        Me.lblModelo.TabIndex = 0
        Me.lblModelo.Text = "Modelo:"
        '
        'cboModelo
        '
        Me.cboModelo.AutoSize = False
        Me.cboModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModelo.Location = New System.Drawing.Point(9, 37)
        Me.cboModelo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModelo.Name = "cboModelo"
        Me.cboModelo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModelo.Size = New System.Drawing.Size(108, 20)
        Me.cboModelo.TabIndex = 1
        '
        'grpEnderecoEmitente
        '
        Me.grpEnderecoEmitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEnderecoEmitente.BackColor = System.Drawing.Color.Transparent
        Me.grpEnderecoEmitente.Controls.Add(Me.lblValorUFEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblValorPaisEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblValorCEPEmiente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblValorMunicipioEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblValorBairroEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblValorComplementoEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblValorNumeroEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblValorLogradouroEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblPaisEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblCEPEmiente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblUFEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblMunicipioEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblBairroEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblComplementoEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblNumeroEmitente)
        Me.grpEnderecoEmitente.Controls.Add(Me.lblLogradouroEmitente)
        Me.grpEnderecoEmitente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEnderecoEmitente.Location = New System.Drawing.Point(8, 170)
        Me.grpEnderecoEmitente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEnderecoEmitente.Name = "grpEnderecoEmitente"
        Me.grpEnderecoEmitente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEnderecoEmitente.Size = New System.Drawing.Size(879, 94)
        Me.grpEnderecoEmitente.TabIndex = 3
        Me.grpEnderecoEmitente.Text = "Endereço do Emitente"
        Me.grpEnderecoEmitente.VisualStyleManager = Me.vsmMain
        '
        'lblValorUFEmitente
        '
        Me.lblValorUFEmitente.AutoSize = True
        Me.lblValorUFEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorUFEmitente.Location = New System.Drawing.Point(575, 54)
        Me.lblValorUFEmitente.Name = "lblValorUFEmitente"
        Me.lblValorUFEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorUFEmitente.TabIndex = 11
        Me.lblValorUFEmitente.Text = "-"
        '
        'lblValorPaisEmitente
        '
        Me.lblValorPaisEmitente.AutoSize = True
        Me.lblValorPaisEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorPaisEmitente.Location = New System.Drawing.Point(136, 71)
        Me.lblValorPaisEmitente.Name = "lblValorPaisEmitente"
        Me.lblValorPaisEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorPaisEmitente.TabIndex = 15
        Me.lblValorPaisEmitente.Text = "-"
        '
        'lblValorCEPEmiente
        '
        Me.lblValorCEPEmiente.AutoSize = True
        Me.lblValorCEPEmiente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorCEPEmiente.Location = New System.Drawing.Point(740, 54)
        Me.lblValorCEPEmiente.Name = "lblValorCEPEmiente"
        Me.lblValorCEPEmiente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorCEPEmiente.TabIndex = 13
        Me.lblValorCEPEmiente.Text = "-"
        '
        'lblValorMunicipioEmitente
        '
        Me.lblValorMunicipioEmitente.AutoSize = True
        Me.lblValorMunicipioEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorMunicipioEmitente.Location = New System.Drawing.Point(136, 54)
        Me.lblValorMunicipioEmitente.Name = "lblValorMunicipioEmitente"
        Me.lblValorMunicipioEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorMunicipioEmitente.TabIndex = 9
        Me.lblValorMunicipioEmitente.Text = "-"
        '
        'lblValorBairroEmitente
        '
        Me.lblValorBairroEmitente.AutoSize = True
        Me.lblValorBairroEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorBairroEmitente.Location = New System.Drawing.Point(575, 37)
        Me.lblValorBairroEmitente.Name = "lblValorBairroEmitente"
        Me.lblValorBairroEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorBairroEmitente.TabIndex = 7
        Me.lblValorBairroEmitente.Text = "-"
        '
        'lblValorComplementoEmitente
        '
        Me.lblValorComplementoEmitente.AutoSize = True
        Me.lblValorComplementoEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorComplementoEmitente.Location = New System.Drawing.Point(136, 37)
        Me.lblValorComplementoEmitente.Name = "lblValorComplementoEmitente"
        Me.lblValorComplementoEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorComplementoEmitente.TabIndex = 5
        Me.lblValorComplementoEmitente.Text = "-"
        '
        'lblValorNumeroEmitente
        '
        Me.lblValorNumeroEmitente.AutoSize = True
        Me.lblValorNumeroEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorNumeroEmitente.Location = New System.Drawing.Point(575, 20)
        Me.lblValorNumeroEmitente.Name = "lblValorNumeroEmitente"
        Me.lblValorNumeroEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorNumeroEmitente.TabIndex = 3
        Me.lblValorNumeroEmitente.Text = "-"
        '
        'lblValorLogradouroEmitente
        '
        Me.lblValorLogradouroEmitente.AutoSize = True
        Me.lblValorLogradouroEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorLogradouroEmitente.Location = New System.Drawing.Point(136, 20)
        Me.lblValorLogradouroEmitente.Name = "lblValorLogradouroEmitente"
        Me.lblValorLogradouroEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorLogradouroEmitente.TabIndex = 1
        Me.lblValorLogradouroEmitente.Text = "-"
        '
        'lblPaisEmitente
        '
        Me.lblPaisEmitente.AutoSize = True
        Me.lblPaisEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblPaisEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPaisEmitente.Location = New System.Drawing.Point(6, 71)
        Me.lblPaisEmitente.Name = "lblPaisEmitente"
        Me.lblPaisEmitente.Size = New System.Drawing.Size(33, 14)
        Me.lblPaisEmitente.TabIndex = 14
        Me.lblPaisEmitente.Text = "País:"
        '
        'lblCEPEmiente
        '
        Me.lblCEPEmiente.AutoSize = True
        Me.lblCEPEmiente.BackColor = System.Drawing.Color.Transparent
        Me.lblCEPEmiente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCEPEmiente.Location = New System.Drawing.Point(703, 54)
        Me.lblCEPEmiente.Name = "lblCEPEmiente"
        Me.lblCEPEmiente.Size = New System.Drawing.Size(31, 14)
        Me.lblCEPEmiente.TabIndex = 12
        Me.lblCEPEmiente.Text = "CEP:"
        '
        'lblUFEmitente
        '
        Me.lblUFEmitente.AutoSize = True
        Me.lblUFEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblUFEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUFEmitente.Location = New System.Drawing.Point(515, 54)
        Me.lblUFEmitente.Name = "lblUFEmitente"
        Me.lblUFEmitente.Size = New System.Drawing.Size(23, 14)
        Me.lblUFEmitente.TabIndex = 10
        Me.lblUFEmitente.Text = "UF:"
        '
        'lblMunicipioEmitente
        '
        Me.lblMunicipioEmitente.AutoSize = True
        Me.lblMunicipioEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblMunicipioEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMunicipioEmitente.Location = New System.Drawing.Point(6, 54)
        Me.lblMunicipioEmitente.Name = "lblMunicipioEmitente"
        Me.lblMunicipioEmitente.Size = New System.Drawing.Size(63, 14)
        Me.lblMunicipioEmitente.TabIndex = 8
        Me.lblMunicipioEmitente.Text = "Município:"
        '
        'lblBairroEmitente
        '
        Me.lblBairroEmitente.AutoSize = True
        Me.lblBairroEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblBairroEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblBairroEmitente.Location = New System.Drawing.Point(515, 37)
        Me.lblBairroEmitente.Name = "lblBairroEmitente"
        Me.lblBairroEmitente.Size = New System.Drawing.Size(43, 14)
        Me.lblBairroEmitente.TabIndex = 6
        Me.lblBairroEmitente.Text = "Bairro:"
        '
        'lblComplementoEmitente
        '
        Me.lblComplementoEmitente.AutoSize = True
        Me.lblComplementoEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblComplementoEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblComplementoEmitente.Location = New System.Drawing.Point(6, 37)
        Me.lblComplementoEmitente.Name = "lblComplementoEmitente"
        Me.lblComplementoEmitente.Size = New System.Drawing.Size(89, 14)
        Me.lblComplementoEmitente.TabIndex = 4
        Me.lblComplementoEmitente.Text = "Complemento:"
        '
        'lblNumeroEmitente
        '
        Me.lblNumeroEmitente.AutoSize = True
        Me.lblNumeroEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNumeroEmitente.Location = New System.Drawing.Point(515, 20)
        Me.lblNumeroEmitente.Name = "lblNumeroEmitente"
        Me.lblNumeroEmitente.Size = New System.Drawing.Size(54, 14)
        Me.lblNumeroEmitente.TabIndex = 2
        Me.lblNumeroEmitente.Text = "Número:"
        '
        'lblLogradouroEmitente
        '
        Me.lblLogradouroEmitente.AutoSize = True
        Me.lblLogradouroEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblLogradouroEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLogradouroEmitente.Location = New System.Drawing.Point(6, 20)
        Me.lblLogradouroEmitente.Name = "lblLogradouroEmitente"
        Me.lblLogradouroEmitente.Size = New System.Drawing.Size(75, 14)
        Me.lblLogradouroEmitente.TabIndex = 0
        Me.lblLogradouroEmitente.Text = "Logradouro:"
        '
        'grpDadosEmitente
        '
        Me.grpDadosEmitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosEmitente.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosEmitente.Controls.Add(Me.lblValorRegimeTributarioEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblValorInscricaoEstadualEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblValorInscricaoMunicipalEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblValorNomeFantasiaEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblRegimeTributarioEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblInscricaoMunicipalEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblInscricaoEstadualEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblNomeFantasiaEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblValorRazaoSocialEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblRazaoSocialEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblValorCNPJEmitente)
        Me.grpDadosEmitente.Controls.Add(Me.lblCNPJEmitente)
        Me.grpDadosEmitente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosEmitente.Location = New System.Drawing.Point(8, 73)
        Me.grpDadosEmitente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosEmitente.Name = "grpDadosEmitente"
        Me.grpDadosEmitente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosEmitente.Size = New System.Drawing.Size(879, 94)
        Me.grpDadosEmitente.TabIndex = 2
        Me.grpDadosEmitente.Text = "Dados do Emitente"
        Me.grpDadosEmitente.VisualStyleManager = Me.vsmMain
        '
        'lblValorRegimeTributarioEmitente
        '
        Me.lblValorRegimeTributarioEmitente.AutoSize = True
        Me.lblValorRegimeTributarioEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorRegimeTributarioEmitente.Location = New System.Drawing.Point(510, 37)
        Me.lblValorRegimeTributarioEmitente.Name = "lblValorRegimeTributarioEmitente"
        Me.lblValorRegimeTributarioEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorRegimeTributarioEmitente.TabIndex = 7
        Me.lblValorRegimeTributarioEmitente.Text = "-"
        '
        'lblValorInscricaoEstadualEmitente
        '
        Me.lblValorInscricaoEstadualEmitente.AutoSize = True
        Me.lblValorInscricaoEstadualEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorInscricaoEstadualEmitente.Location = New System.Drawing.Point(510, 20)
        Me.lblValorInscricaoEstadualEmitente.Name = "lblValorInscricaoEstadualEmitente"
        Me.lblValorInscricaoEstadualEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorInscricaoEstadualEmitente.TabIndex = 3
        Me.lblValorInscricaoEstadualEmitente.Text = "-"
        '
        'lblValorInscricaoMunicipalEmitente
        '
        Me.lblValorInscricaoMunicipalEmitente.AutoSize = True
        Me.lblValorInscricaoMunicipalEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorInscricaoMunicipalEmitente.Location = New System.Drawing.Point(136, 37)
        Me.lblValorInscricaoMunicipalEmitente.Name = "lblValorInscricaoMunicipalEmitente"
        Me.lblValorInscricaoMunicipalEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorInscricaoMunicipalEmitente.TabIndex = 5
        Me.lblValorInscricaoMunicipalEmitente.Text = "-"
        '
        'lblValorNomeFantasiaEmitente
        '
        Me.lblValorNomeFantasiaEmitente.AutoSize = True
        Me.lblValorNomeFantasiaEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorNomeFantasiaEmitente.Location = New System.Drawing.Point(136, 71)
        Me.lblValorNomeFantasiaEmitente.Name = "lblValorNomeFantasiaEmitente"
        Me.lblValorNomeFantasiaEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorNomeFantasiaEmitente.TabIndex = 11
        Me.lblValorNomeFantasiaEmitente.Text = "-"
        '
        'lblRegimeTributarioEmitente
        '
        Me.lblRegimeTributarioEmitente.AutoSize = True
        Me.lblRegimeTributarioEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblRegimeTributarioEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRegimeTributarioEmitente.Location = New System.Drawing.Point(396, 37)
        Me.lblRegimeTributarioEmitente.Name = "lblRegimeTributarioEmitente"
        Me.lblRegimeTributarioEmitente.Size = New System.Drawing.Size(108, 14)
        Me.lblRegimeTributarioEmitente.TabIndex = 6
        Me.lblRegimeTributarioEmitente.Text = "Regime Tributário:"
        '
        'lblInscricaoMunicipalEmitente
        '
        Me.lblInscricaoMunicipalEmitente.AutoSize = True
        Me.lblInscricaoMunicipalEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblInscricaoMunicipalEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInscricaoMunicipalEmitente.Location = New System.Drawing.Point(6, 37)
        Me.lblInscricaoMunicipalEmitente.Name = "lblInscricaoMunicipalEmitente"
        Me.lblInscricaoMunicipalEmitente.Size = New System.Drawing.Size(113, 14)
        Me.lblInscricaoMunicipalEmitente.TabIndex = 4
        Me.lblInscricaoMunicipalEmitente.Text = "Instrição Municipal:"
        '
        'lblInscricaoEstadualEmitente
        '
        Me.lblInscricaoEstadualEmitente.AutoSize = True
        Me.lblInscricaoEstadualEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblInscricaoEstadualEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInscricaoEstadualEmitente.Location = New System.Drawing.Point(396, 20)
        Me.lblInscricaoEstadualEmitente.Name = "lblInscricaoEstadualEmitente"
        Me.lblInscricaoEstadualEmitente.Size = New System.Drawing.Size(109, 14)
        Me.lblInscricaoEstadualEmitente.TabIndex = 2
        Me.lblInscricaoEstadualEmitente.Text = "Inscrição Estadual:"
        '
        'lblNomeFantasiaEmitente
        '
        Me.lblNomeFantasiaEmitente.AutoSize = True
        Me.lblNomeFantasiaEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeFantasiaEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNomeFantasiaEmitente.Location = New System.Drawing.Point(6, 71)
        Me.lblNomeFantasiaEmitente.Name = "lblNomeFantasiaEmitente"
        Me.lblNomeFantasiaEmitente.Size = New System.Drawing.Size(90, 14)
        Me.lblNomeFantasiaEmitente.TabIndex = 10
        Me.lblNomeFantasiaEmitente.Text = "Nome Fantasia:"
        '
        'lblValorRazaoSocialEmitente
        '
        Me.lblValorRazaoSocialEmitente.AutoSize = True
        Me.lblValorRazaoSocialEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorRazaoSocialEmitente.Location = New System.Drawing.Point(136, 54)
        Me.lblValorRazaoSocialEmitente.Name = "lblValorRazaoSocialEmitente"
        Me.lblValorRazaoSocialEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorRazaoSocialEmitente.TabIndex = 9
        Me.lblValorRazaoSocialEmitente.Text = "-"
        '
        'lblRazaoSocialEmitente
        '
        Me.lblRazaoSocialEmitente.AutoSize = True
        Me.lblRazaoSocialEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblRazaoSocialEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRazaoSocialEmitente.Location = New System.Drawing.Point(6, 54)
        Me.lblRazaoSocialEmitente.Name = "lblRazaoSocialEmitente"
        Me.lblRazaoSocialEmitente.Size = New System.Drawing.Size(77, 14)
        Me.lblRazaoSocialEmitente.TabIndex = 8
        Me.lblRazaoSocialEmitente.Text = "Razão Social:"
        '
        'lblValorCNPJEmitente
        '
        Me.lblValorCNPJEmitente.AutoSize = True
        Me.lblValorCNPJEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorCNPJEmitente.Location = New System.Drawing.Point(136, 20)
        Me.lblValorCNPJEmitente.Name = "lblValorCNPJEmitente"
        Me.lblValorCNPJEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorCNPJEmitente.TabIndex = 1
        Me.lblValorCNPJEmitente.Text = "-"
        '
        'lblCNPJEmitente
        '
        Me.lblCNPJEmitente.AutoSize = True
        Me.lblCNPJEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblCNPJEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCNPJEmitente.Location = New System.Drawing.Point(6, 20)
        Me.lblCNPJEmitente.Name = "lblCNPJEmitente"
        Me.lblCNPJEmitente.Size = New System.Drawing.Size(38, 14)
        Me.lblCNPJEmitente.TabIndex = 0
        Me.lblCNPJEmitente.Text = "CNPJ:"
        '
        'pagProduto
        '
        Me.pagProduto.Controls.Add(Me.btnExcelGridProduto)
        Me.pagProduto.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagProduto.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagProduto.Controls.Add(Me.grpItens)
        Me.pagProduto.Controls.Add(Me.grdProduto)
        Me.pagProduto.Key = "pagProduto"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Size = New System.Drawing.Size(895, 450)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Lista de Produtos"
        '
        'btnExcelGridProduto
        '
        Me.btnExcelGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridProduto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridProduto.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridProduto.Location = New System.Drawing.Point(57, 424)
        Me.btnExcelGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridProduto.Name = "btnExcelGridProduto"
        Me.btnExcelGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridProduto.TabIndex = 94
        Me.btnExcelGridProduto.TabStop = False
        Me.btnExcelGridProduto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridProduto
        '
        Me.btnAgruparGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridProduto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridProduto.Location = New System.Drawing.Point(33, 424)
        Me.btnAgruparGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProduto.Name = "btnAgruparGridProduto"
        Me.btnAgruparGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridProduto.TabIndex = 93
        Me.btnAgruparGridProduto.TabStop = False
        Me.btnAgruparGridProduto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(9, 424)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 9
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'grpItens
        '
        Me.grpItens.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItens.BackColor = System.Drawing.Color.Transparent
        Me.grpItens.Controls.Add(Me.lblPedidoVenda)
        Me.grpItens.Controls.Add(Me.cboPedidoVenda)
        Me.grpItens.Controls.Add(Me.txtValorTotal)
        Me.grpItens.Controls.Add(Me.lblValorTotal)
        Me.grpItens.Controls.Add(Me.lblContaContabil)
        Me.grpItens.Controls.Add(Me.cboContaContabil)
        Me.grpItens.Controls.Add(Me.lblCentroGasto)
        Me.grpItens.Controls.Add(Me.cboCentroGasto)
        Me.grpItens.Controls.Add(Me.lblCodigoProduto)
        Me.grpItens.Controls.Add(Me.cboCodigoProduto)
        Me.grpItens.Controls.Add(Me.lblDescricao)
        Me.grpItens.Controls.Add(Me.txtDescricao)
        Me.grpItens.Controls.Add(Me.txtValorUnitario)
        Me.grpItens.Controls.Add(Me.lblValorUnitario)
        Me.grpItens.Controls.Add(Me.txtQuantidade)
        Me.grpItens.Controls.Add(Me.lblQuantidade)
        Me.grpItens.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpItens.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpItens.Controls.Add(Me.btnProcurarProduto)
        Me.grpItens.Controls.Add(Me.btnCadastrarProduto)
        Me.grpItens.Controls.Add(Me.btnExcluirProduto)
        Me.grpItens.Controls.Add(Me.btnInserirProduto)
        Me.grpItens.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpItens.Location = New System.Drawing.Point(8, 3)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpItens.Size = New System.Drawing.Size(879, 184)
        Me.grpItens.TabIndex = 0
        Me.grpItens.Text = "Dados do Item"
        Me.grpItens.VisualStyleManager = Me.vsmMain
        '
        'lblPedidoVenda
        '
        Me.lblPedidoVenda.AutoSize = True
        Me.lblPedidoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPedidoVenda.Location = New System.Drawing.Point(6, 17)
        Me.lblPedidoVenda.Name = "lblPedidoVenda"
        Me.lblPedidoVenda.Size = New System.Drawing.Size(91, 14)
        Me.lblPedidoVenda.TabIndex = 0
        Me.lblPedidoVenda.Text = "Nº Pedido Venda:"
        '
        'cboPedidoVenda
        '
        Me.cboPedidoVenda.AutoSize = False
        Me.cboPedidoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPedidoVenda.Location = New System.Drawing.Point(9, 34)
        Me.cboPedidoVenda.Name = "cboPedidoVenda"
        Me.cboPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPedidoVenda.Size = New System.Drawing.Size(100, 20)
        Me.cboPedidoVenda.TabIndex = 1
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.DecimalDigits = 2
        Me.txtValorTotal.Location = New System.Drawing.Point(221, 74)
        Me.txtValorTotal.MaxLength = 0
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotal.TabIndex = 13
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = 0.0R
        Me.txtValorTotal.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(218, 57)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 12
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(25, 137)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 18
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(9, 154)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(312, 20)
        Me.cboContaContabil.TabIndex = 19
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(25, 97)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 15
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(9, 114)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(312, 20)
        Me.cboCentroGasto.TabIndex = 16
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProduto.Location = New System.Drawing.Point(131, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProduto.TabIndex = 3
        Me.lblCodigoProduto.Text = "Código Produto:"
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.AutoSize = False
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoProduto.Location = New System.Drawing.Point(115, 34)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProduto.Size = New System.Drawing.Size(206, 20)
        Me.cboCodigoProduto.TabIndex = 5
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(324, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 6
        Me.lblDescricao.Text = "Descricao:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(327, 34)
        Me.txtDescricao.MaxLength = 1000
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescricao.Size = New System.Drawing.Size(431, 140)
        Me.txtDescricao.TabIndex = 7
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.DecimalDigits = 2
        Me.txtValorUnitario.Location = New System.Drawing.Point(115, 74)
        Me.txtValorUnitario.MaxLength = 0
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtValorUnitario.TabIndex = 11
        Me.txtValorUnitario.Text = "0,00"
        Me.txtValorUnitario.Value = 0.0R
        Me.txtValorUnitario.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.Location = New System.Drawing.Point(112, 57)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitario.TabIndex = 10
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 2
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 74)
        Me.txtQuantidade.MaxLength = 0
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 9
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 57)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 8
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(9, 138)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 17
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(9, 98)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 14
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(304, 16)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 4
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = CType(resources.GetObject("btnCadastrarProduto.Image"), System.Drawing.Image)
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(115, 18)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 2
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirProduto.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirProduto.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirProduto.Location = New System.Drawing.Point(779, 151)
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirProduto.TabIndex = 21
        Me.btnExcluirProduto.Text = "Excluir"
        Me.btnExcluirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirProduto.Image = CType(resources.GetObject("btnInserirProduto.Image"), System.Drawing.Image)
        Me.btnInserirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirProduto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirProduto.Location = New System.Drawing.Point(779, 122)
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirProduto.TabIndex = 20
        Me.btnInserirProduto.Text = "Inserir"
        Me.btnInserirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.grdProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProduto.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.FrozenColumns = 2
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.Location = New System.Drawing.Point(8, 196)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(879, 245)
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
        'pagCobranca
        '
        Me.pagCobranca.Controls.Add(Me.grpImposto)
        Me.pagCobranca.Controls.Add(Me.grpDadosAdicionais)
        Me.pagCobranca.Controls.Add(Me.grpDuplicata)
        Me.pagCobranca.Controls.Add(Me.grpFatura)
        Me.pagCobranca.Key = "pagCobranca"
        Me.pagCobranca.Location = New System.Drawing.Point(1, 22)
        Me.pagCobranca.Name = "pagCobranca"
        Me.pagCobranca.Size = New System.Drawing.Size(895, 450)
        Me.pagCobranca.TabStop = True
        Me.pagCobranca.Text = "Imposto / Cobrança /  Informações Adicionais"
        '
        'grpImposto
        '
        Me.grpImposto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpImposto.BackColor = System.Drawing.Color.Transparent
        Me.grpImposto.Controls.Add(Me.chkLei10833)
        Me.grpImposto.Controls.Add(Me.chkINSS)
        Me.grpImposto.Controls.Add(Me.chkISS)
        Me.grpImposto.Controls.Add(Me.chkIR)
        Me.grpImposto.Controls.Add(Me.txtIR)
        Me.grpImposto.Controls.Add(Me.txtISS)
        Me.grpImposto.Controls.Add(Me.txtINSS)
        Me.grpImposto.Controls.Add(Me.txtLei10833)
        Me.grpImposto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpImposto.Location = New System.Drawing.Point(8, 3)
        Me.grpImposto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpImposto.Name = "grpImposto"
        Me.grpImposto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpImposto.Size = New System.Drawing.Size(879, 64)
        Me.grpImposto.TabIndex = 0
        Me.grpImposto.Text = "Imposto"
        Me.grpImposto.VisualStyleManager = Me.vsmMain
        '
        'chkLei10833
        '
        Me.chkLei10833.Location = New System.Drawing.Point(9, 17)
        Me.chkLei10833.Name = "chkLei10833"
        Me.chkLei10833.Size = New System.Drawing.Size(75, 14)
        Me.chkLei10833.TabIndex = 0
        Me.chkLei10833.Text = "Lei 10833:"
        '
        'chkINSS
        '
        Me.chkINSS.Location = New System.Drawing.Point(105, 17)
        Me.chkINSS.Name = "chkINSS"
        Me.chkINSS.Size = New System.Drawing.Size(42, 14)
        Me.chkINSS.TabIndex = 2
        Me.chkINSS.Text = "INSS:"
        '
        'chkISS
        '
        Me.chkISS.Location = New System.Drawing.Point(201, 17)
        Me.chkISS.Name = "chkISS"
        Me.chkISS.Size = New System.Drawing.Size(42, 14)
        Me.chkISS.TabIndex = 4
        Me.chkISS.Text = "ISS:"
        '
        'chkIR
        '
        Me.chkIR.Location = New System.Drawing.Point(297, 17)
        Me.chkIR.Name = "chkIR"
        Me.chkIR.Size = New System.Drawing.Size(42, 14)
        Me.chkIR.TabIndex = 6
        Me.chkIR.Text = "IR:"
        '
        'txtIR
        '
        Me.txtIR.DecimalDigits = 2
        Me.txtIR.Location = New System.Drawing.Point(297, 34)
        Me.txtIR.Name = "txtIR"
        Me.txtIR.Size = New System.Drawing.Size(90, 20)
        Me.txtIR.TabIndex = 7
        Me.txtIR.Text = "0,00"
        Me.txtIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtISS
        '
        Me.txtISS.DecimalDigits = 2
        Me.txtISS.Location = New System.Drawing.Point(201, 34)
        Me.txtISS.Name = "txtISS"
        Me.txtISS.Size = New System.Drawing.Size(90, 20)
        Me.txtISS.TabIndex = 5
        Me.txtISS.Text = "0,00"
        Me.txtISS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtINSS
        '
        Me.txtINSS.DecimalDigits = 2
        Me.txtINSS.Location = New System.Drawing.Point(105, 34)
        Me.txtINSS.Name = "txtINSS"
        Me.txtINSS.Size = New System.Drawing.Size(90, 20)
        Me.txtINSS.TabIndex = 3
        Me.txtINSS.Text = "0,00"
        Me.txtINSS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtLei10833
        '
        Me.txtLei10833.DecimalDigits = 2
        Me.txtLei10833.Location = New System.Drawing.Point(9, 34)
        Me.txtLei10833.Name = "txtLei10833"
        Me.txtLei10833.Size = New System.Drawing.Size(90, 20)
        Me.txtLei10833.TabIndex = 1
        Me.txtLei10833.Text = "0,00"
        Me.txtLei10833.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'grpDadosAdicionais
        '
        Me.grpDadosAdicionais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosAdicionais.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosAdicionais.Controls.Add(Me.cboDadosAdicionaisPreCadastrado)
        Me.grpDadosAdicionais.Controls.Add(Me.lblDadosAdicionaisPreCadastrado)
        Me.grpDadosAdicionais.Controls.Add(Me.lblDadosAdicionais)
        Me.grpDadosAdicionais.Controls.Add(Me.txtDadosAdicionais)
        Me.grpDadosAdicionais.Controls.Add(Me.btnCadastrarDadosAdicionais)
        Me.grpDadosAdicionais.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosAdicionais.Location = New System.Drawing.Point(8, 137)
        Me.grpDadosAdicionais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosAdicionais.Name = "grpDadosAdicionais"
        Me.grpDadosAdicionais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosAdicionais.Size = New System.Drawing.Size(640, 214)
        Me.grpDadosAdicionais.TabIndex = 3
        Me.grpDadosAdicionais.Text = "Informações Adicionais"
        Me.grpDadosAdicionais.VisualStyleManager = Me.vsmMain
        '
        'cboDadosAdicionaisPreCadastrado
        '
        Me.cboDadosAdicionaisPreCadastrado.AutoSize = False
        Me.cboDadosAdicionaisPreCadastrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDadosAdicionaisPreCadastrado.Location = New System.Drawing.Point(9, 34)
        Me.cboDadosAdicionaisPreCadastrado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDadosAdicionaisPreCadastrado.Name = "cboDadosAdicionaisPreCadastrado"
        Me.cboDadosAdicionaisPreCadastrado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDadosAdicionaisPreCadastrado.Size = New System.Drawing.Size(359, 20)
        Me.cboDadosAdicionaisPreCadastrado.TabIndex = 2
        '
        'lblDadosAdicionaisPreCadastrado
        '
        Me.lblDadosAdicionaisPreCadastrado.AutoSize = True
        Me.lblDadosAdicionaisPreCadastrado.Location = New System.Drawing.Point(25, 17)
        Me.lblDadosAdicionaisPreCadastrado.Name = "lblDadosAdicionaisPreCadastrado"
        Me.lblDadosAdicionaisPreCadastrado.Size = New System.Drawing.Size(171, 14)
        Me.lblDadosAdicionaisPreCadastrado.TabIndex = 1
        Me.lblDadosAdicionaisPreCadastrado.Text = "Dados Adicionais pré-cadastrado:"
        '
        'lblDadosAdicionais
        '
        Me.lblDadosAdicionais.AutoSize = True
        Me.lblDadosAdicionais.Location = New System.Drawing.Point(6, 57)
        Me.lblDadosAdicionais.Name = "lblDadosAdicionais"
        Me.lblDadosAdicionais.Size = New System.Drawing.Size(93, 14)
        Me.lblDadosAdicionais.TabIndex = 3
        Me.lblDadosAdicionais.Text = "Dados Adicionais:"
        '
        'txtDadosAdicionais
        '
        Me.txtDadosAdicionais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDadosAdicionais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDadosAdicionais.Location = New System.Drawing.Point(9, 74)
        Me.txtDadosAdicionais.MaxLength = 5000
        Me.txtDadosAdicionais.Multiline = True
        Me.txtDadosAdicionais.Name = "txtDadosAdicionais"
        Me.txtDadosAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDadosAdicionais.Size = New System.Drawing.Size(622, 131)
        Me.txtDadosAdicionais.TabIndex = 4
        '
        'btnCadastrarDadosAdicionais
        '
        Me.btnCadastrarDadosAdicionais.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDadosAdicionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDadosAdicionais.Image = CType(resources.GetObject("btnCadastrarDadosAdicionais.Image"), System.Drawing.Image)
        Me.btnCadastrarDadosAdicionais.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDadosAdicionais.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarDadosAdicionais.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDadosAdicionais.Name = "btnCadastrarDadosAdicionais"
        Me.btnCadastrarDadosAdicionais.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDadosAdicionais.TabIndex = 0
        Me.btnCadastrarDadosAdicionais.TabStop = False
        Me.btnCadastrarDadosAdicionais.UseVisualStyleBackColor = True
        '
        'grpDuplicata
        '
        Me.grpDuplicata.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDuplicata.BackColor = System.Drawing.Color.Transparent
        Me.grpDuplicata.Controls.Add(Me.btnCalcularDuplicata)
        Me.grpDuplicata.Controls.Add(Me.txtIntervaloEntreParcelas)
        Me.grpDuplicata.Controls.Add(Me.lblIntervaloEntreParcelas)
        Me.grpDuplicata.Controls.Add(Me.txtNumeroParcela)
        Me.grpDuplicata.Controls.Add(Me.lblNumeroParcela)
        Me.grpDuplicata.Controls.Add(Me.lblCodigoCondicaoPagamento)
        Me.grpDuplicata.Controls.Add(Me.cboCondicaoPagamento)
        Me.grpDuplicata.Controls.Add(Me.grdDuplicata)
        Me.grpDuplicata.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDuplicata.Location = New System.Drawing.Point(657, 73)
        Me.grpDuplicata.Name = "grpDuplicata"
        Me.grpDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDuplicata.Size = New System.Drawing.Size(230, 278)
        Me.grpDuplicata.TabIndex = 2
        Me.grpDuplicata.Text = "Duplicata"
        Me.grpDuplicata.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDuplicata.VisualStyleManager = Me.vsmMain
        '
        'btnCalcularDuplicata
        '
        Me.btnCalcularDuplicata.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcularDuplicata.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularDuplicata.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCalcularDuplicata.Location = New System.Drawing.Point(130, 111)
        Me.btnCalcularDuplicata.Name = "btnCalcularDuplicata"
        Me.btnCalcularDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCalcularDuplicata.Size = New System.Drawing.Size(91, 23)
        Me.btnCalcularDuplicata.TabIndex = 6
        Me.btnCalcularDuplicata.Text = "Calcular"
        Me.btnCalcularDuplicata.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtIntervaloEntreParcelas
        '
        Me.txtIntervaloEntreParcelas.DecimalDigits = 0
        Me.txtIntervaloEntreParcelas.Location = New System.Drawing.Point(9, 114)
        Me.txtIntervaloEntreParcelas.Name = "txtIntervaloEntreParcelas"
        Me.txtIntervaloEntreParcelas.Size = New System.Drawing.Size(108, 20)
        Me.txtIntervaloEntreParcelas.TabIndex = 5
        Me.txtIntervaloEntreParcelas.Text = "0"
        Me.txtIntervaloEntreParcelas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblIntervaloEntreParcelas
        '
        Me.lblIntervaloEntreParcelas.AutoSize = True
        Me.lblIntervaloEntreParcelas.Location = New System.Drawing.Point(6, 97)
        Me.lblIntervaloEntreParcelas.Name = "lblIntervaloEntreParcelas"
        Me.lblIntervaloEntreParcelas.Size = New System.Drawing.Size(97, 14)
        Me.lblIntervaloEntreParcelas.TabIndex = 4
        Me.lblIntervaloEntreParcelas.Text = "Int. entre Parcelas:"
        '
        'txtNumeroParcela
        '
        Me.txtNumeroParcela.DecimalDigits = 0
        Me.txtNumeroParcela.Location = New System.Drawing.Point(9, 74)
        Me.txtNumeroParcela.Name = "txtNumeroParcela"
        Me.txtNumeroParcela.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroParcela.TabIndex = 2
        Me.txtNumeroParcela.Text = "0"
        Me.txtNumeroParcela.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroParcela
        '
        Me.lblNumeroParcela.AutoSize = True
        Me.lblNumeroParcela.Location = New System.Drawing.Point(6, 57)
        Me.lblNumeroParcela.Name = "lblNumeroParcela"
        Me.lblNumeroParcela.Size = New System.Drawing.Size(67, 14)
        Me.lblNumeroParcela.TabIndex = 3
        Me.lblNumeroParcela.Text = "Nº Parcelas:"
        '
        'lblCodigoCondicaoPagamento
        '
        Me.lblCodigoCondicaoPagamento.AutoSize = True
        Me.lblCodigoCondicaoPagamento.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoCondicaoPagamento.Name = "lblCodigoCondicaoPagamento"
        Me.lblCodigoCondicaoPagamento.Size = New System.Drawing.Size(126, 14)
        Me.lblCodigoCondicaoPagamento.TabIndex = 0
        Me.lblCodigoCondicaoPagamento.Text = "Condição de Pagamento:"
        '
        'cboCondicaoPagamento
        '
        Me.cboCondicaoPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCondicaoPagamento.AutoSize = False
        Me.cboCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCondicaoPagamento.Location = New System.Drawing.Point(9, 34)
        Me.cboCondicaoPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCondicaoPagamento.Name = "cboCondicaoPagamento"
        Me.cboCondicaoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCondicaoPagamento.Size = New System.Drawing.Size(212, 20)
        Me.cboCondicaoPagamento.TabIndex = 1
        '
        'grdDuplicata
        '
        Me.grdDuplicata.AlternatingColors = True
        Me.grdDuplicata.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDuplicata.CellToolTipText = "Duplo Clique para editar o Registro"
        Me.grdDuplicata.ColumnAutoResize = True
        grdDuplicata_DesignTimeLayout.LayoutString = resources.GetString("grdDuplicata_DesignTimeLayout.LayoutString")
        Me.grdDuplicata.DesignTimeLayout = grdDuplicata_DesignTimeLayout
        Me.grdDuplicata.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDuplicata.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDuplicata.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDuplicata.GroupByBoxVisible = False
        Me.grdDuplicata.Location = New System.Drawing.Point(9, 142)
        Me.grdDuplicata.Name = "grdDuplicata"
        Me.grdDuplicata.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDuplicata.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDuplicata.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDuplicata.Size = New System.Drawing.Size(212, 127)
        Me.grdDuplicata.TabIndex = 7
        Me.grdDuplicata.TabStop = False
        Me.grdDuplicata.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDuplicata.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdDuplicata.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDuplicata.VisualStyleManager = Me.vsmMain
        '
        'grpFatura
        '
        Me.grpFatura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFatura.BackColor = System.Drawing.Color.Transparent
        Me.grpFatura.Controls.Add(Me.txtValorDesconto)
        Me.grpFatura.Controls.Add(Me.txtValorRetido)
        Me.grpFatura.Controls.Add(Me.lblValorRetido)
        Me.grpFatura.Controls.Add(Me.txtValorLiquido)
        Me.grpFatura.Controls.Add(Me.lblValorLiquido)
        Me.grpFatura.Controls.Add(Me.lblValorDesconto)
        Me.grpFatura.Controls.Add(Me.txtValorOriginal)
        Me.grpFatura.Controls.Add(Me.lblValorOriginal)
        Me.grpFatura.Controls.Add(Me.txtFatura)
        Me.grpFatura.Controls.Add(Me.lblFatura)
        Me.grpFatura.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFatura.Location = New System.Drawing.Point(8, 70)
        Me.grpFatura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFatura.Name = "grpFatura"
        Me.grpFatura.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFatura.Size = New System.Drawing.Size(640, 64)
        Me.grpFatura.TabIndex = 1
        Me.grpFatura.Text = "Fatura"
        Me.grpFatura.VisualStyleManager = Me.vsmMain
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDesconto.DecimalDigits = 2
        Me.txtValorDesconto.Location = New System.Drawing.Point(297, 34)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.Size = New System.Drawing.Size(90, 20)
        Me.txtValorDesconto.TabIndex = 5
        Me.txtValorDesconto.Text = "0,00"
        Me.txtValorDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorRetido
        '
        Me.txtValorRetido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorRetido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorRetido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorRetido.Location = New System.Drawing.Point(393, 34)
        Me.txtValorRetido.Name = "txtValorRetido"
        Me.txtValorRetido.ReadOnly = True
        Me.txtValorRetido.Size = New System.Drawing.Size(90, 20)
        Me.txtValorRetido.TabIndex = 7
        Me.txtValorRetido.TabStop = False
        Me.txtValorRetido.Text = "0,00"
        Me.txtValorRetido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorRetido
        '
        Me.lblValorRetido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorRetido.AutoSize = True
        Me.lblValorRetido.Location = New System.Drawing.Point(390, 17)
        Me.lblValorRetido.Name = "lblValorRetido"
        Me.lblValorRetido.Size = New System.Drawing.Size(68, 14)
        Me.lblValorRetido.TabIndex = 6
        Me.lblValorRetido.Text = "Valor Retido:"
        '
        'txtValorLiquido
        '
        Me.txtValorLiquido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorLiquido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorLiquido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorLiquido.Location = New System.Drawing.Point(489, 34)
        Me.txtValorLiquido.Name = "txtValorLiquido"
        Me.txtValorLiquido.ReadOnly = True
        Me.txtValorLiquido.Size = New System.Drawing.Size(90, 20)
        Me.txtValorLiquido.TabIndex = 9
        Me.txtValorLiquido.TabStop = False
        Me.txtValorLiquido.Text = "0,00"
        Me.txtValorLiquido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorLiquido
        '
        Me.lblValorLiquido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorLiquido.AutoSize = True
        Me.lblValorLiquido.Location = New System.Drawing.Point(486, 17)
        Me.lblValorLiquido.Name = "lblValorLiquido"
        Me.lblValorLiquido.Size = New System.Drawing.Size(72, 14)
        Me.lblValorLiquido.TabIndex = 8
        Me.lblValorLiquido.Text = "Valor Líquido:"
        '
        'lblValorDesconto
        '
        Me.lblValorDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorDesconto.AutoSize = True
        Me.lblValorDesconto.Location = New System.Drawing.Point(294, 17)
        Me.lblValorDesconto.Name = "lblValorDesconto"
        Me.lblValorDesconto.Size = New System.Drawing.Size(84, 14)
        Me.lblValorDesconto.TabIndex = 4
        Me.lblValorDesconto.Text = "Valor Desconto:"
        '
        'txtValorOriginal
        '
        Me.txtValorOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorOriginal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorOriginal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorOriginal.Location = New System.Drawing.Point(201, 34)
        Me.txtValorOriginal.Name = "txtValorOriginal"
        Me.txtValorOriginal.ReadOnly = True
        Me.txtValorOriginal.Size = New System.Drawing.Size(90, 20)
        Me.txtValorOriginal.TabIndex = 3
        Me.txtValorOriginal.TabStop = False
        Me.txtValorOriginal.Text = "0,00"
        Me.txtValorOriginal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorOriginal
        '
        Me.lblValorOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorOriginal.AutoSize = True
        Me.lblValorOriginal.Location = New System.Drawing.Point(198, 17)
        Me.lblValorOriginal.Name = "lblValorOriginal"
        Me.lblValorOriginal.Size = New System.Drawing.Size(74, 14)
        Me.lblValorOriginal.TabIndex = 2
        Me.lblValorOriginal.Text = "Valor Original:"
        '
        'txtFatura
        '
        Me.txtFatura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFatura.Location = New System.Drawing.Point(9, 34)
        Me.txtFatura.MaxLength = 150
        Me.txtFatura.Name = "txtFatura"
        Me.txtFatura.Size = New System.Drawing.Size(186, 20)
        Me.txtFatura.TabIndex = 1
        '
        'lblFatura
        '
        Me.lblFatura.AutoSize = True
        Me.lblFatura.Location = New System.Drawing.Point(6, 17)
        Me.lblFatura.Name = "lblFatura"
        Me.lblFatura.Size = New System.Drawing.Size(41, 14)
        Me.lblFatura.TabIndex = 0
        Me.lblFatura.Text = "Fatura:"
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
        Me.pagArquivo.Size = New System.Drawing.Size(895, 450)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Text = "Arquivos"
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnImprimir)
        Me.grpControle2.Controls.Add(Me.btnNovo)
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Controls.Add(Me.btnSalvar)
        Me.grpControle2.Location = New System.Drawing.Point(8, 483)
        Me.grpControle2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(897, 51)
        Me.grpControle2.TabIndex = 1
        Me.grpControle2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControle2.VisualStyleManager = Me.vsmMain
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(9, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 3
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 0
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 0
        Me.ToolTip.ReshowDelay = 0
        Me.ToolTip.ShowAlways = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 425)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 101
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
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 425)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 100
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
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 425)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 99
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
        Me.grpArquivo.Controls.Add(Me.lblTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.cboTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.txtDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnCadastrarTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(879, 104)
        Me.grpArquivo.TabIndex = 97
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'lblRevisaoArquivo
        '
        Me.lblRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevisaoArquivo.AutoSize = True
        Me.lblRevisaoArquivo.Location = New System.Drawing.Point(575, 17)
        Me.lblRevisaoArquivo.Name = "lblRevisaoArquivo"
        Me.lblRevisaoArquivo.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoArquivo.TabIndex = 2
        Me.lblRevisaoArquivo.Text = "Revisão:"
        '
        'txtRevisaoArquivo
        '
        Me.txtRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRevisaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisaoArquivo.Location = New System.Drawing.Point(578, 34)
        Me.txtRevisaoArquivo.MaxLength = 5
        Me.txtRevisaoArquivo.Name = "txtRevisaoArquivo"
        Me.txtRevisaoArquivo.Size = New System.Drawing.Size(89, 20)
        Me.txtRevisaoArquivo.TabIndex = 3
        '
        'lblTipoArquivo
        '
        Me.lblTipoArquivo.AutoSize = True
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
        Me.btnArquivo.Location = New System.Drawing.Point(647, 74)
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
        Me.txtArquivo.Size = New System.Drawing.Size(393, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
        '
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(563, 20)
        Me.txtDescricaoArquivo.TabIndex = 1
        '
        'lblDescricaoArquivo
        '
        Me.lblDescricaoArquivo.AutoSize = True
        Me.lblDescricaoArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoArquivo.Name = "lblDescricaoArquivo"
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoArquivo.TabIndex = 0
        Me.lblDescricaoArquivo.Text = "Descrição:"
        '
        'btnCadastrarTipoArquivo
        '
        Me.btnCadastrarTipoArquivo.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoArquivo.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarTipoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoArquivo.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarTipoArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoArquivo.Name = "btnCadastrarTipoArquivo"
        Me.btnCadastrarTipoArquivo.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoArquivo.TabIndex = 4
        Me.btnCadastrarTipoArquivo.TabStop = False
        Me.btnCadastrarTipoArquivo.UseVisualStyleBackColor = True
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(779, 71)
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
        Me.btnInserirArquivo.Location = New System.Drawing.Point(779, 42)
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
        Me.grdArquivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 326)
        Me.grdArquivo.TabIndex = 98
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'usrFatEmissaoLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrFatEmissaoLocacao"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaElaboracao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDadosNotaFiscal.ResumeLayout(False)
        CType(Me.grpEnderecoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEnderecoCliente.ResumeLayout(False)
        Me.grpEnderecoCliente.PerformLayout()
        CType(Me.grpIdentificacaoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIdentificacaoCliente.ResumeLayout(False)
        Me.grpIdentificacaoCliente.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpEnderecoEmitente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEnderecoEmitente.ResumeLayout(False)
        Me.grpEnderecoEmitente.PerformLayout()
        CType(Me.grpDadosEmitente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosEmitente.ResumeLayout(False)
        Me.grpDadosEmitente.PerformLayout()
        Me.pagProduto.ResumeLayout(False)
        CType(Me.grpItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItens.ResumeLayout(False)
        Me.grpItens.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCobranca.ResumeLayout(False)
        CType(Me.grpImposto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImposto.ResumeLayout(False)
        Me.grpImposto.PerformLayout()
        CType(Me.grpDadosAdicionais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosAdicionais.ResumeLayout(False)
        Me.grpDadosAdicionais.PerformLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDuplicata.ResumeLayout(False)
        Me.grpDuplicata.PerformLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFatura.ResumeLayout(False)
        Me.grpFatura.PerformLayout()
        Me.pagArquivo.ResumeLayout(False)
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDadosNotaFiscal As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagCobranca As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFatura As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorLiquido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorLiquido As System.Windows.Forms.Label
    Friend WithEvents lblValorDesconto As System.Windows.Forms.Label
    Friend WithEvents txtValorOriginal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOriginal As System.Windows.Forms.Label
    Friend WithEvents txtFatura As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFatura As System.Windows.Forms.Label
    Friend WithEvents txtClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpDuplicata As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCalcularDuplicata As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtIntervaloEntreParcelas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloEntreParcelas As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroParcela As System.Windows.Forms.Label
    Friend WithEvents lblCodigoCondicaoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboCondicaoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdDuplicata As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpEnderecoEmitente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorUFEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorPaisEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorCEPEmiente As System.Windows.Forms.Label
    Friend WithEvents lblValorMunicipioEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorBairroEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorComplementoEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorNumeroEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorLogradouroEmitente As System.Windows.Forms.Label
    Friend WithEvents lblPaisEmitente As System.Windows.Forms.Label
    Friend WithEvents lblCEPEmiente As System.Windows.Forms.Label
    Friend WithEvents lblUFEmitente As System.Windows.Forms.Label
    Friend WithEvents lblMunicipioEmitente As System.Windows.Forms.Label
    Friend WithEvents lblBairroEmitente As System.Windows.Forms.Label
    Friend WithEvents lblComplementoEmitente As System.Windows.Forms.Label
    Friend WithEvents lblNumeroEmitente As System.Windows.Forms.Label
    Friend WithEvents lblLogradouroEmitente As System.Windows.Forms.Label
    Friend WithEvents grpDadosEmitente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorRegimeTributarioEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorInscricaoEstadualEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorInscricaoMunicipalEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorNomeFantasiaEmitente As System.Windows.Forms.Label
    Friend WithEvents lblRegimeTributarioEmitente As System.Windows.Forms.Label
    Friend WithEvents lblInscricaoMunicipalEmitente As System.Windows.Forms.Label
    Friend WithEvents lblInscricaoEstadualEmitente As System.Windows.Forms.Label
    Friend WithEvents lblNomeFantasiaEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorRazaoSocialEmitente As System.Windows.Forms.Label
    Friend WithEvents lblRazaoSocialEmitente As System.Windows.Forms.Label
    Friend WithEvents lblValorCNPJEmitente As System.Windows.Forms.Label
    Friend WithEvents lblCNPJEmitente As System.Windows.Forms.Label
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSerie As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents cboModelo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaAutozidadaParaUso As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelada As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaElaboracao As System.Windows.Forms.Label
    Friend WithEvents picLegendaElaboracao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAutozidadaParaUso As System.Windows.Forms.Label
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents grpEnderecoCliente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtTelefoneCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefoneCliente As System.Windows.Forms.Label
    Friend WithEvents txtEmailCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEmailCliente As System.Windows.Forms.Label
    Friend WithEvents cboMunicipioCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairroCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPaisCliente As System.Windows.Forms.Label
    Friend WithEvents cboPaisCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCEPCliente As System.Windows.Forms.Label
    Friend WithEvents txtCEPCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplementoCliente As System.Windows.Forms.Label
    Friend WithEvents lblUFCliente As System.Windows.Forms.Label
    Friend WithEvents cboUFCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipioCliente As System.Windows.Forms.Label
    Friend WithEvents lblBairroCliente As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCliente As System.Windows.Forms.Label
    Friend WithEvents lblLogradouroCliente As System.Windows.Forms.Label
    Friend WithEvents txtLogradouroCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarCEPCliente As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarPaisCliente As System.Windows.Forms.Button
    Friend WithEvents grpIdentificacaoCliente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents txtCNPJCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtInscricaoMunicipalCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoMunicipalCliente As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoEstadualCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadualCliente As System.Windows.Forms.Label
    Friend WithEvents lblCNPJCliente As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarCliente As System.Windows.Forms.Button
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents grpItens As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents cboPedidoVenda As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcluirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosAdicionais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboDadosAdicionaisPreCadastrado As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDadosAdicionaisPreCadastrado As System.Windows.Forms.Label
    Friend WithEvents lblDadosAdicionais As System.Windows.Forms.Label
    Friend WithEvents txtDadosAdicionais As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents btnCadastrarDadosAdicionais As System.Windows.Forms.Button
    Friend WithEvents grpImposto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtIR As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtISS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtINSS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtLei10833 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorRetido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorRetido As System.Windows.Forms.Label
    Friend WithEvents chkLei10833 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkINSS As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkISS As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkIR As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtValorDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRevisaoArquivo As System.Windows.Forms.Label
    Friend WithEvents txtRevisaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoArquivo As System.Windows.Forms.Label
    Friend WithEvents cboTipoArquivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarTipoArquivo As System.Windows.Forms.Button
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX

End Class
