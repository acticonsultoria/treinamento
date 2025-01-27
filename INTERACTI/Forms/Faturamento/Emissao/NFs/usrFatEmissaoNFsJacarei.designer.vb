<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEmissaoNFsJacarei
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEmissaoNFsJacarei))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim grdListagem_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.Image")
        Dim cboNaturezaOperacaoServicoFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboTipoRPSFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdDuplicata_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaAutozidadaParaUso = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCancelada = New System.Windows.Forms.Label()
        Me.picLegendaCancelada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaRejeitada = New System.Windows.Forms.Label()
        Me.picLegendaRejeitada = New System.Windows.Forms.PictureBox()
        Me.lblAguardandoRetorno = New System.Windows.Forms.Label()
        Me.pigAguardandoRetorno = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAguardandoTransmissao = New System.Windows.Forms.Label()
        Me.picLegendaAguardandoTransmissao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAutozidadaParaUso = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboNaturezaOperacaoServicoFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblNaturezaOperacaoServicoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoRPSFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblTipoRPSFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtTomadorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.lblTomadorFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosNFs = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMunicipioTributacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipioTributacao = New System.Windows.Forms.Label()
        Me.cboUFTributacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUFTributacao = New System.Windows.Forms.Label()
        Me.cboNaturezaOperacaoServico = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNaturezaOperacaoServico = New System.Windows.Forms.Label()
        Me.grpEnderecoTomador = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTelefoneTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefoneTomador = New System.Windows.Forms.Label()
        Me.txtEmailTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmailTomador = New System.Windows.Forms.Label()
        Me.cboMunicipioTomador = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplementoTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairroTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPaisTomador = New System.Windows.Forms.Label()
        Me.cboPaisTomador = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCEPTomador = New System.Windows.Forms.Label()
        Me.txtCEPTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplementoTomador = New System.Windows.Forms.Label()
        Me.lblUFTomador = New System.Windows.Forms.Label()
        Me.cboUFTomador = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipioTomador = New System.Windows.Forms.Label()
        Me.lblBairroTomador = New System.Windows.Forms.Label()
        Me.lblNumeroTomador = New System.Windows.Forms.Label()
        Me.lblLogradouroTomador = New System.Windows.Forms.Label()
        Me.txtLogradouroTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnProcurarCEPTomador = New System.Windows.Forms.Button()
        Me.btnCadastrarPaisTomador = New System.Windows.Forms.Button()
        Me.grpIdentificacaoTomador = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarTomador = New System.Windows.Forms.Button()
        Me.txtCNPJTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtInscricaoMunicipalTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoMunicipalTomador = New System.Windows.Forms.Label()
        Me.txtInscricaoEstadualTomador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadualTomador = New System.Windows.Forms.Label()
        Me.lblCNPJTomador = New System.Windows.Forms.Label()
        Me.lblTomador = New System.Windows.Forms.Label()
        Me.cboTomador = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarTomador = New System.Windows.Forms.Button()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboTipoRPS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoRPS = New System.Windows.Forms.Label()
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
        Me.pagServico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpClassificacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.grpValores = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCalcularCSLL = New System.Windows.Forms.Button()
        Me.btnCalcularINSS = New System.Windows.Forms.Button()
        Me.btnCalcularCOFINS = New System.Windows.Forms.Button()
        Me.btnCalcularPIS = New System.Windows.Forms.Button()
        Me.txtAliquotaIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIR = New System.Windows.Forms.Label()
        Me.txtAliquotaCSLL = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCSLL = New System.Windows.Forms.Label()
        Me.txtAliquotaINSS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaINSS = New System.Windows.Forms.Label()
        Me.txtAliquotaCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCOFINS = New System.Windows.Forms.Label()
        Me.txtAliquotaPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPIS = New System.Windows.Forms.Label()
        Me.cboISSRetido = New Janus.Windows.EditControls.UIComboBox()
        Me.lblISSRetido = New System.Windows.Forms.Label()
        Me.txtValorISS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorISS = New System.Windows.Forms.Label()
        Me.txtValorISSRetido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorISSRetido = New System.Windows.Forms.Label()
        Me.txtAliquotaISS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaISS = New System.Windows.Forms.Label()
        Me.txtBaseCalculo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculo = New System.Windows.Forms.Label()
        Me.txtOutrasRetencoes = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblOutrasRetencoes = New System.Windows.Forms.Label()
        Me.txtValorCSLL = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCSLL = New System.Windows.Forms.Label()
        Me.txtValorIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorIR = New System.Windows.Forms.Label()
        Me.txtValorINSS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorINSS = New System.Windows.Forms.Label()
        Me.txtValorCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCOFINS = New System.Windows.Forms.Label()
        Me.txtValorPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorPIS = New System.Windows.Forms.Label()
        Me.txtValorDeducoes = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDeducoes = New System.Windows.Forms.Label()
        Me.grpServico = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarServico = New System.Windows.Forms.Button()
        Me.txtValorLiquidoNFSE = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorLiquidoNFSE = New System.Windows.Forms.Label()
        Me.txtValorDescontoIncondicionado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDescontoIncondicionado = New System.Windows.Forms.Label()
        Me.txtValorDescontoCondicionado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDescontoCondicionado = New System.Windows.Forms.Label()
        Me.txtValorServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorServico = New System.Windows.Forms.Label()
        Me.btnProcurarServico = New System.Windows.Forms.Button()
        Me.cboServico = New Janus.Windows.EditControls.UIComboBox()
        Me.lblServico = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.pagCobranca = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDuplicata = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCalcularDuplicata = New Janus.Windows.EditControls.UIButton()
        Me.txtIntervaloEntreParcelas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIntervaloEntreParcelas = New System.Windows.Forms.Label()
        Me.txtNumeroParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroParcela = New System.Windows.Forms.Label()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.cboFormaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.grdDuplicata = New Janus.Windows.GridEX.GridEX()
        Me.grpFatura = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorLiquido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorLiquido = New System.Windows.Forms.Label()
        Me.txtValorDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDesconto = New System.Windows.Forms.Label()
        Me.txtValorOriginal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOriginal = New System.Windows.Forms.Label()
        Me.txtFatura = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFatura = New System.Windows.Forms.Label()
        Me.pagNFSe = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpNFSe = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimirNFSe = New Janus.Windows.EditControls.UIButton()
        Me.txtNumeroRPS = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRPS = New System.Windows.Forms.Label()
        Me.txtCodigoVerificacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoVerificacao = New System.Windows.Forms.Label()
        Me.lblAmbiente = New System.Windows.Forms.Label()
        Me.txtProtocolo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProtocolo = New System.Windows.Forms.Label()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtMensagemNFSe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMensagemNFSe = New System.Windows.Forms.Label()
        Me.txtStatusNFSe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblStatusNFSe = New System.Windows.Forms.Label()
        Me.btnReenviarEmail = New Janus.Windows.EditControls.UIButton()
        Me.btnRetornarNFSE = New Janus.Windows.EditControls.UIButton()
        Me.btnTransmitirNFSE = New Janus.Windows.EditControls.UIButton()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnImportarPedido = New Janus.Windows.EditControls.UIButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnTransmissaoLote = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaRejeitada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pigAguardandoRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAguardandoTransmissao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDadosNFs.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grpEnderecoTomador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnderecoTomador.SuspendLayout()
        CType(Me.grpIdentificacaoTomador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIdentificacaoTomador.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpEnderecoEmitente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnderecoEmitente.SuspendLayout()
        CType(Me.grpDadosEmitente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosEmitente.SuspendLayout()
        Me.pagServico.SuspendLayout()
        CType(Me.grpClassificacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClassificacao.SuspendLayout()
        CType(Me.grpValores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValores.SuspendLayout()
        CType(Me.grpServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServico.SuspendLayout()
        Me.pagCobranca.SuspendLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDuplicata.SuspendLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFatura.SuspendLayout()
        Me.pagNFSe.SuspendLayout()
        CType(Me.grpNFSe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNFSe.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
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
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
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
        Me.pagLista.Text = "Lista de Nota Fiscal"
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
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(49, 15)
        Me.btnConfigurarGrid.TabIndex = 9
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
        Me.grpLegenda.Controls.Add(Me.lblLegendaRejeitada)
        Me.grpLegenda.Controls.Add(Me.picLegendaRejeitada)
        Me.grpLegenda.Controls.Add(Me.lblAguardandoRetorno)
        Me.grpLegenda.Controls.Add(Me.pigAguardandoRetorno)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoTransmissao)
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoTransmissao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAutozidadaParaUso)
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(392, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaAutozidadaParaUso
        '
        Me.picLegendaAutozidadaParaUso.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaAutozidadaParaUso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAutozidadaParaUso.Location = New System.Drawing.Point(166, 13)
        Me.picLegendaAutozidadaParaUso.Name = "picLegendaAutozidadaParaUso"
        Me.picLegendaAutozidadaParaUso.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAutozidadaParaUso.TabIndex = 16
        Me.picLegendaAutozidadaParaUso.TabStop = False
        '
        'lblLegendaCancelada
        '
        Me.lblLegendaCancelada.AutoSize = True
        Me.lblLegendaCancelada.Location = New System.Drawing.Point(329, 13)
        Me.lblLegendaCancelada.Name = "lblLegendaCancelada"
        Me.lblLegendaCancelada.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelada.TabIndex = 3
        Me.lblLegendaCancelada.Text = "Cancelada"
        '
        'picLegendaCancelada
        '
        Me.picLegendaCancelada.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelada.Location = New System.Drawing.Point(310, 13)
        Me.picLegendaCancelada.Name = "picLegendaCancelada"
        Me.picLegendaCancelada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelada.TabIndex = 14
        Me.picLegendaCancelada.TabStop = False
        '
        'lblLegendaRejeitada
        '
        Me.lblLegendaRejeitada.AutoSize = True
        Me.lblLegendaRejeitada.Location = New System.Drawing.Point(185, 30)
        Me.lblLegendaRejeitada.Name = "lblLegendaRejeitada"
        Me.lblLegendaRejeitada.Size = New System.Drawing.Size(51, 14)
        Me.lblLegendaRejeitada.TabIndex = 2
        Me.lblLegendaRejeitada.Text = "Rejeitada"
        '
        'picLegendaRejeitada
        '
        Me.picLegendaRejeitada.BackColor = System.Drawing.Color.Peru
        Me.picLegendaRejeitada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaRejeitada.Location = New System.Drawing.Point(166, 30)
        Me.picLegendaRejeitada.Name = "picLegendaRejeitada"
        Me.picLegendaRejeitada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaRejeitada.TabIndex = 12
        Me.picLegendaRejeitada.TabStop = False
        '
        'lblAguardandoRetorno
        '
        Me.lblAguardandoRetorno.AutoSize = True
        Me.lblAguardandoRetorno.Location = New System.Drawing.Point(28, 30)
        Me.lblAguardandoRetorno.Name = "lblAguardandoRetorno"
        Me.lblAguardandoRetorno.Size = New System.Drawing.Size(108, 14)
        Me.lblAguardandoRetorno.TabIndex = 1
        Me.lblAguardandoRetorno.Text = "Aguardando Retorno"
        '
        'pigAguardandoRetorno
        '
        Me.pigAguardandoRetorno.BackColor = System.Drawing.Color.SteelBlue
        Me.pigAguardandoRetorno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pigAguardandoRetorno.Location = New System.Drawing.Point(9, 30)
        Me.pigAguardandoRetorno.Name = "pigAguardandoRetorno"
        Me.pigAguardandoRetorno.Size = New System.Drawing.Size(13, 14)
        Me.pigAguardandoRetorno.TabIndex = 10
        Me.pigAguardandoRetorno.TabStop = False
        '
        'lblLegendaAguardandoTransmissao
        '
        Me.lblLegendaAguardandoTransmissao.AutoSize = True
        Me.lblLegendaAguardandoTransmissao.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaAguardandoTransmissao.Name = "lblLegendaAguardandoTransmissao"
        Me.lblLegendaAguardandoTransmissao.Size = New System.Drawing.Size(132, 14)
        Me.lblLegendaAguardandoTransmissao.TabIndex = 0
        Me.lblLegendaAguardandoTransmissao.Text = "Aguardando Transmissão"
        '
        'picLegendaAguardandoTransmissao
        '
        Me.picLegendaAguardandoTransmissao.BackColor = System.Drawing.Color.DimGray
        Me.picLegendaAguardandoTransmissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoTransmissao.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaAguardandoTransmissao.Name = "picLegendaAguardandoTransmissao"
        Me.picLegendaAguardandoTransmissao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAguardandoTransmissao.TabIndex = 4
        Me.picLegendaAguardandoTransmissao.TabStop = False
        '
        'lblLegendaAutozidadaParaUso
        '
        Me.lblLegendaAutozidadaParaUso.AutoSize = True
        Me.lblLegendaAutozidadaParaUso.Location = New System.Drawing.Point(185, 13)
        Me.lblLegendaAutozidadaParaUso.Name = "lblLegendaAutozidadaParaUso"
        Me.lblLegendaAutozidadaParaUso.Size = New System.Drawing.Size(119, 14)
        Me.lblLegendaAutozidadaParaUso.TabIndex = 15
        Me.lblLegendaAutozidadaParaUso.Text = "Autorizadada para Uso"
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
        Me.grpControle.Controls.Add(Me.btnTransmissaoLote)
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(409, 483)
        Me.grpControle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(496, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(105, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(202, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 1
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(299, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(396, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
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
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_4.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3, grdListagem_DesignTimeLayout_Reference_4})
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
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
        Me.grpFiltro.Controls.Add(Me.cboNaturezaOperacaoServicoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNaturezaOperacaoServicoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoRPSFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoRPSFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtTomadorFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTomadorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboNaturezaOperacaoServicoFiltro
        '
        Me.cboNaturezaOperacaoServicoFiltro.AllowDrop = True
        Me.cboNaturezaOperacaoServicoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNaturezaOperacaoServicoFiltro.ButtonCancelText = "Cancelar"
        Me.cboNaturezaOperacaoServicoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboNaturezaOperacaoServicoFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboNaturezaOperacaoServicoFiltro_DesignTimeLayout.LayoutString")
        Me.cboNaturezaOperacaoServicoFiltro.DesignTimeLayout = cboNaturezaOperacaoServicoFiltro_DesignTimeLayout
        Me.cboNaturezaOperacaoServicoFiltro.Location = New System.Drawing.Point(457, 74)
        Me.cboNaturezaOperacaoServicoFiltro.Name = "cboNaturezaOperacaoServicoFiltro"
        Me.cboNaturezaOperacaoServicoFiltro.SaveSettings = False
        Me.cboNaturezaOperacaoServicoFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboNaturezaOperacaoServicoFiltro.Size = New System.Drawing.Size(317, 20)
        Me.cboNaturezaOperacaoServicoFiltro.TabIndex = 14
        Me.cboNaturezaOperacaoServicoFiltro.ValuesDataMember = Nothing
        '
        'lblNaturezaOperacaoServicoFiltro
        '
        Me.lblNaturezaOperacaoServicoFiltro.AutoSize = True
        Me.lblNaturezaOperacaoServicoFiltro.Location = New System.Drawing.Point(454, 57)
        Me.lblNaturezaOperacaoServicoFiltro.Name = "lblNaturezaOperacaoServicoFiltro"
        Me.lblNaturezaOperacaoServicoFiltro.Size = New System.Drawing.Size(160, 14)
        Me.lblNaturezaOperacaoServicoFiltro.TabIndex = 13
        Me.lblNaturezaOperacaoServicoFiltro.Text = "Natureza Operação do Serviço:"
        '
        'cboTipoRPSFiltro
        '
        Me.cboTipoRPSFiltro.AllowDrop = True
        Me.cboTipoRPSFiltro.ButtonCancelText = "Cancelar"
        Me.cboTipoRPSFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboTipoRPSFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboTipoRPSFiltro_DesignTimeLayout.LayoutString")
        Me.cboTipoRPSFiltro.DesignTimeLayout = cboTipoRPSFiltro_DesignTimeLayout
        Me.cboTipoRPSFiltro.Location = New System.Drawing.Point(258, 74)
        Me.cboTipoRPSFiltro.Name = "cboTipoRPSFiltro"
        Me.cboTipoRPSFiltro.SaveSettings = False
        Me.cboTipoRPSFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboTipoRPSFiltro.Size = New System.Drawing.Size(193, 20)
        Me.cboTipoRPSFiltro.TabIndex = 12
        Me.cboTipoRPSFiltro.ValuesDataMember = Nothing
        '
        'lblTipoRPSFiltro
        '
        Me.lblTipoRPSFiltro.AutoSize = True
        Me.lblTipoRPSFiltro.Location = New System.Drawing.Point(255, 57)
        Me.lblTipoRPSFiltro.Name = "lblTipoRPSFiltro"
        Me.lblTipoRPSFiltro.Size = New System.Drawing.Size(68, 14)
        Me.lblTipoRPSFiltro.TabIndex = 11
        Me.lblTipoRPSFiltro.Text = "Tipo de RPS:"
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
        Me.cboStatusFiltro.Size = New System.Drawing.Size(243, 20)
        Me.cboStatusFiltro.TabIndex = 10
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'dtpDataEmissaoTerminoFiltro
        '
        Me.dtpDataEmissaoTerminoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(666, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 8
        '
        'dtpDataEmissaoInicioFiltro
        '
        Me.dtpDataEmissaoInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(552, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 7
        '
        'txtTomadorFiltro
        '
        Me.txtTomadorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTomadorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTomadorFiltro.Location = New System.Drawing.Point(185, 34)
        Me.txtTomadorFiltro.MaxLength = 60
        Me.txtTomadorFiltro.Name = "txtTomadorFiltro"
        Me.txtTomadorFiltro.Size = New System.Drawing.Size(361, 20)
        Me.txtTomadorFiltro.TabIndex = 5
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
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 15
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
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(549, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 6
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'lblTomadorFiltro
        '
        Me.lblTomadorFiltro.AutoSize = True
        Me.lblTomadorFiltro.Location = New System.Drawing.Point(182, 17)
        Me.lblTomadorFiltro.Name = "lblTomadorFiltro"
        Me.lblTomadorFiltro.Size = New System.Drawing.Size(51, 14)
        Me.lblTomadorFiltro.TabIndex = 4
        Me.lblTomadorFiltro.Text = "Tomador:"
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
        Me.pagDados.Text = "Dados da Nota Fiscal"
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
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosNFs, Me.pagServico, Me.pagCobranca, Me.pagNFSe})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDadosNFs
        '
        Me.pagDadosNFs.Controls.Add(Me.UiGroupBox1)
        Me.pagDadosNFs.Controls.Add(Me.grpEnderecoTomador)
        Me.pagDadosNFs.Controls.Add(Me.grpIdentificacaoTomador)
        Me.pagDadosNFs.Controls.Add(Me.grpDados)
        Me.pagDadosNFs.Controls.Add(Me.grpEnderecoEmitente)
        Me.pagDadosNFs.Controls.Add(Me.grpDadosEmitente)
        Me.pagDadosNFs.Key = "pagDadosNFe"
        Me.pagDadosNFs.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosNFs.Name = "pagDadosNFs"
        Me.pagDadosNFs.Size = New System.Drawing.Size(895, 450)
        Me.pagDadosNFs.TabStop = True
        Me.pagDadosNFs.Text = "Dados da NFs"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.cboMunicipioTributacao)
        Me.UiGroupBox1.Controls.Add(Me.lblMunicipioTributacao)
        Me.UiGroupBox1.Controls.Add(Me.cboUFTributacao)
        Me.UiGroupBox1.Controls.Add(Me.lblUFTributacao)
        Me.UiGroupBox1.Controls.Add(Me.cboNaturezaOperacaoServico)
        Me.UiGroupBox1.Controls.Add(Me.lblNaturezaOperacaoServico)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(557, 3)
        Me.UiGroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(330, 164)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.Text = "Dados do Emitente"
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'cboMunicipioTributacao
        '
        Me.cboMunicipioTributacao.AutoSize = False
        Me.cboMunicipioTributacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipioTributacao.Location = New System.Drawing.Point(12, 134)
        Me.cboMunicipioTributacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboMunicipioTributacao.Name = "cboMunicipioTributacao"
        Me.cboMunicipioTributacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipioTributacao.Size = New System.Drawing.Size(312, 20)
        Me.cboMunicipioTributacao.TabIndex = 5
        '
        'lblMunicipioTributacao
        '
        Me.lblMunicipioTributacao.AutoSize = True
        Me.lblMunicipioTributacao.Location = New System.Drawing.Point(9, 117)
        Me.lblMunicipioTributacao.Name = "lblMunicipioTributacao"
        Me.lblMunicipioTributacao.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipioTributacao.TabIndex = 4
        Me.lblMunicipioTributacao.Text = "Município:"
        '
        'cboUFTributacao
        '
        Me.cboUFTributacao.AutoSize = False
        Me.cboUFTributacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFTributacao.Location = New System.Drawing.Point(10, 94)
        Me.cboUFTributacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUFTributacao.Name = "cboUFTributacao"
        Me.cboUFTributacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFTributacao.Size = New System.Drawing.Size(105, 20)
        Me.cboUFTributacao.TabIndex = 3
        '
        'lblUFTributacao
        '
        Me.lblUFTributacao.AutoSize = True
        Me.lblUFTributacao.Location = New System.Drawing.Point(7, 77)
        Me.lblUFTributacao.Name = "lblUFTributacao"
        Me.lblUFTributacao.Size = New System.Drawing.Size(23, 14)
        Me.lblUFTributacao.TabIndex = 2
        Me.lblUFTributacao.Text = "UF:"
        '
        'cboNaturezaOperacaoServico
        '
        Me.cboNaturezaOperacaoServico.AutoSize = False
        Me.cboNaturezaOperacaoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNaturezaOperacaoServico.Location = New System.Drawing.Point(9, 37)
        Me.cboNaturezaOperacaoServico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNaturezaOperacaoServico.Name = "cboNaturezaOperacaoServico"
        Me.cboNaturezaOperacaoServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNaturezaOperacaoServico.Size = New System.Drawing.Size(312, 20)
        Me.cboNaturezaOperacaoServico.TabIndex = 1
        '
        'lblNaturezaOperacaoServico
        '
        Me.lblNaturezaOperacaoServico.AutoSize = True
        Me.lblNaturezaOperacaoServico.Location = New System.Drawing.Point(6, 20)
        Me.lblNaturezaOperacaoServico.Name = "lblNaturezaOperacaoServico"
        Me.lblNaturezaOperacaoServico.Size = New System.Drawing.Size(160, 14)
        Me.lblNaturezaOperacaoServico.TabIndex = 0
        Me.lblNaturezaOperacaoServico.Text = "Natureza Operação do Serviço:"
        '
        'grpEnderecoTomador
        '
        Me.grpEnderecoTomador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEnderecoTomador.BackColor = System.Drawing.Color.Transparent
        Me.grpEnderecoTomador.Controls.Add(Me.txtTelefoneTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblTelefoneTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.txtEmailTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblEmailTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.cboMunicipioTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.txtNumeroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.txtComplementoTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.txtBairroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblPaisTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.cboPaisTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblCEPTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.txtCEPTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblComplementoTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblUFTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.cboUFTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblMunicipioTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblBairroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblNumeroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblLogradouroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.txtLogradouroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.btnProcurarCEPTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.btnCadastrarPaisTomador)
        Me.grpEnderecoTomador.Location = New System.Drawing.Point(8, 337)
        Me.grpEnderecoTomador.Name = "grpEnderecoTomador"
        Me.grpEnderecoTomador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEnderecoTomador.Size = New System.Drawing.Size(879, 104)
        Me.grpEnderecoTomador.TabIndex = 5
        Me.grpEnderecoTomador.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEnderecoTomador.VisualStyleManager = Me.vsmMain
        '
        'txtTelefoneTomador
        '
        Me.txtTelefoneTomador.Enabled = False
        Me.txtTelefoneTomador.Location = New System.Drawing.Point(420, 74)
        Me.txtTelefoneTomador.Mask = "!(##) 0000-0000"
        Me.txtTelefoneTomador.MaxLength = 10
        Me.txtTelefoneTomador.Name = "txtTelefoneTomador"
        Me.txtTelefoneTomador.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefoneTomador.TabIndex = 18
        '
        'lblTelefoneTomador
        '
        Me.lblTelefoneTomador.AutoSize = True
        Me.lblTelefoneTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefoneTomador.Location = New System.Drawing.Point(417, 57)
        Me.lblTelefoneTomador.Name = "lblTelefoneTomador"
        Me.lblTelefoneTomador.Size = New System.Drawing.Size(51, 14)
        Me.lblTelefoneTomador.TabIndex = 17
        Me.lblTelefoneTomador.Text = "Telefone:"
        '
        'txtEmailTomador
        '
        Me.txtEmailTomador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmailTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailTomador.Enabled = False
        Me.txtEmailTomador.Location = New System.Drawing.Point(534, 74)
        Me.txtEmailTomador.MaxLength = 60
        Me.txtEmailTomador.Name = "txtEmailTomador"
        Me.txtEmailTomador.Size = New System.Drawing.Size(336, 20)
        Me.txtEmailTomador.TabIndex = 20
        '
        'lblEmailTomador
        '
        Me.lblEmailTomador.AutoSize = True
        Me.lblEmailTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmailTomador.Location = New System.Drawing.Point(531, 57)
        Me.lblEmailTomador.Name = "lblEmailTomador"
        Me.lblEmailTomador.Size = New System.Drawing.Size(38, 14)
        Me.lblEmailTomador.TabIndex = 19
        Me.lblEmailTomador.Text = "E-mail:"
        '
        'cboMunicipioTomador
        '
        Me.cboMunicipioTomador.AutoSize = False
        Me.cboMunicipioTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipioTomador.Enabled = False
        Me.cboMunicipioTomador.Location = New System.Drawing.Point(311, 34)
        Me.cboMunicipioTomador.Name = "cboMunicipioTomador"
        Me.cboMunicipioTomador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipioTomador.Size = New System.Drawing.Size(217, 20)
        Me.cboMunicipioTomador.TabIndex = 8
        '
        'txtNumeroTomador
        '
        Me.txtNumeroTomador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroTomador.Enabled = False
        Me.txtNumeroTomador.Location = New System.Drawing.Point(806, 34)
        Me.txtNumeroTomador.MaxLength = 60
        Me.txtNumeroTomador.Name = "txtNumeroTomador"
        Me.txtNumeroTomador.Size = New System.Drawing.Size(64, 20)
        Me.txtNumeroTomador.TabIndex = 12
        '
        'txtComplementoTomador
        '
        Me.txtComplementoTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoTomador.Enabled = False
        Me.txtComplementoTomador.Location = New System.Drawing.Point(247, 74)
        Me.txtComplementoTomador.MaxLength = 60
        Me.txtComplementoTomador.Name = "txtComplementoTomador"
        Me.txtComplementoTomador.Size = New System.Drawing.Size(167, 20)
        Me.txtComplementoTomador.TabIndex = 16
        '
        'txtBairroTomador
        '
        Me.txtBairroTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairroTomador.Enabled = False
        Me.txtBairroTomador.Location = New System.Drawing.Point(9, 74)
        Me.txtBairroTomador.MaxLength = 60
        Me.txtBairroTomador.Name = "txtBairroTomador"
        Me.txtBairroTomador.Size = New System.Drawing.Size(232, 20)
        Me.txtBairroTomador.TabIndex = 14
        '
        'lblPaisTomador
        '
        Me.lblPaisTomador.AutoSize = True
        Me.lblPaisTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPaisTomador.Location = New System.Drawing.Point(98, 17)
        Me.lblPaisTomador.Name = "lblPaisTomador"
        Me.lblPaisTomador.Size = New System.Drawing.Size(30, 14)
        Me.lblPaisTomador.TabIndex = 3
        Me.lblPaisTomador.Text = "País:"
        '
        'cboPaisTomador
        '
        Me.cboPaisTomador.AutoSize = False
        Me.cboPaisTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPaisTomador.Enabled = False
        Me.cboPaisTomador.Location = New System.Drawing.Point(82, 34)
        Me.cboPaisTomador.Name = "cboPaisTomador"
        Me.cboPaisTomador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPaisTomador.Size = New System.Drawing.Size(159, 20)
        Me.cboPaisTomador.TabIndex = 4
        '
        'lblCEPTomador
        '
        Me.lblCEPTomador.AutoSize = True
        Me.lblCEPTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCEPTomador.Location = New System.Drawing.Point(6, 17)
        Me.lblCEPTomador.Name = "lblCEPTomador"
        Me.lblCEPTomador.Size = New System.Drawing.Size(29, 14)
        Me.lblCEPTomador.TabIndex = 0
        Me.lblCEPTomador.Text = "CEP:"
        '
        'txtCEPTomador
        '
        Me.txtCEPTomador.Enabled = False
        Me.txtCEPTomador.Location = New System.Drawing.Point(9, 34)
        Me.txtCEPTomador.Mask = "00000-000"
        Me.txtCEPTomador.MaxLength = 10
        Me.txtCEPTomador.Name = "txtCEPTomador"
        Me.txtCEPTomador.Size = New System.Drawing.Size(67, 20)
        Me.txtCEPTomador.TabIndex = 1
        '
        'lblComplementoTomador
        '
        Me.lblComplementoTomador.AutoSize = True
        Me.lblComplementoTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComplementoTomador.Location = New System.Drawing.Point(244, 57)
        Me.lblComplementoTomador.Name = "lblComplementoTomador"
        Me.lblComplementoTomador.Size = New System.Drawing.Size(74, 14)
        Me.lblComplementoTomador.TabIndex = 15
        Me.lblComplementoTomador.Text = "Complemento:"
        '
        'lblUFTomador
        '
        Me.lblUFTomador.AutoSize = True
        Me.lblUFTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFTomador.Location = New System.Drawing.Point(244, 17)
        Me.lblUFTomador.Name = "lblUFTomador"
        Me.lblUFTomador.Size = New System.Drawing.Size(23, 14)
        Me.lblUFTomador.TabIndex = 5
        Me.lblUFTomador.Text = "UF:"
        '
        'cboUFTomador
        '
        Me.cboUFTomador.AutoSize = False
        Me.cboUFTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFTomador.Enabled = False
        Me.cboUFTomador.Location = New System.Drawing.Point(247, 34)
        Me.cboUFTomador.Name = "cboUFTomador"
        Me.cboUFTomador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFTomador.Size = New System.Drawing.Size(58, 20)
        Me.cboUFTomador.TabIndex = 7
        '
        'lblMunicipioTomador
        '
        Me.lblMunicipioTomador.AutoSize = True
        Me.lblMunicipioTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipioTomador.Location = New System.Drawing.Point(308, 17)
        Me.lblMunicipioTomador.Name = "lblMunicipioTomador"
        Me.lblMunicipioTomador.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipioTomador.TabIndex = 6
        Me.lblMunicipioTomador.Text = "Município:"
        '
        'lblBairroTomador
        '
        Me.lblBairroTomador.AutoSize = True
        Me.lblBairroTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBairroTomador.Location = New System.Drawing.Point(6, 57)
        Me.lblBairroTomador.Name = "lblBairroTomador"
        Me.lblBairroTomador.Size = New System.Drawing.Size(39, 14)
        Me.lblBairroTomador.TabIndex = 13
        Me.lblBairroTomador.Text = "Bairro:"
        '
        'lblNumeroTomador
        '
        Me.lblNumeroTomador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroTomador.AutoSize = True
        Me.lblNumeroTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroTomador.Location = New System.Drawing.Point(803, 17)
        Me.lblNumeroTomador.Name = "lblNumeroTomador"
        Me.lblNumeroTomador.Size = New System.Drawing.Size(47, 14)
        Me.lblNumeroTomador.TabIndex = 11
        Me.lblNumeroTomador.Text = "Número:"
        '
        'lblLogradouroTomador
        '
        Me.lblLogradouroTomador.AutoSize = True
        Me.lblLogradouroTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLogradouroTomador.Location = New System.Drawing.Point(531, 17)
        Me.lblLogradouroTomador.Name = "lblLogradouroTomador"
        Me.lblLogradouroTomador.Size = New System.Drawing.Size(66, 14)
        Me.lblLogradouroTomador.TabIndex = 9
        Me.lblLogradouroTomador.Text = "Logradouro:"
        '
        'txtLogradouroTomador
        '
        Me.txtLogradouroTomador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogradouroTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouroTomador.Enabled = False
        Me.txtLogradouroTomador.Location = New System.Drawing.Point(534, 34)
        Me.txtLogradouroTomador.MaxLength = 60
        Me.txtLogradouroTomador.Name = "txtLogradouroTomador"
        Me.txtLogradouroTomador.Size = New System.Drawing.Size(266, 20)
        Me.txtLogradouroTomador.TabIndex = 10
        '
        'btnProcurarCEPTomador
        '
        Me.btnProcurarCEPTomador.FlatAppearance.BorderSize = 0
        Me.btnProcurarCEPTomador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCEPTomador.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCEPTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCEPTomador.Location = New System.Drawing.Point(59, 15)
        Me.btnProcurarCEPTomador.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCEPTomador.Name = "btnProcurarCEPTomador"
        Me.btnProcurarCEPTomador.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCEPTomador.TabIndex = 2
        Me.btnProcurarCEPTomador.TabStop = False
        Me.btnProcurarCEPTomador.UseVisualStyleBackColor = True
        '
        'btnCadastrarPaisTomador
        '
        Me.btnCadastrarPaisTomador.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPaisTomador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPaisTomador.Image = CType(resources.GetObject("btnCadastrarPaisTomador.Image"), System.Drawing.Image)
        Me.btnCadastrarPaisTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarPaisTomador.Location = New System.Drawing.Point(82, 18)
        Me.btnCadastrarPaisTomador.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarPaisTomador.Name = "btnCadastrarPaisTomador"
        Me.btnCadastrarPaisTomador.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarPaisTomador.TabIndex = 3
        Me.btnCadastrarPaisTomador.TabStop = False
        Me.btnCadastrarPaisTomador.UseVisualStyleBackColor = True
        '
        'grpIdentificacaoTomador
        '
        Me.grpIdentificacaoTomador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpIdentificacaoTomador.BackColor = System.Drawing.Color.Transparent
        Me.grpIdentificacaoTomador.Controls.Add(Me.btnProcurarTomador)
        Me.grpIdentificacaoTomador.Controls.Add(Me.txtCNPJTomador)
        Me.grpIdentificacaoTomador.Controls.Add(Me.txtInscricaoMunicipalTomador)
        Me.grpIdentificacaoTomador.Controls.Add(Me.lblInscricaoMunicipalTomador)
        Me.grpIdentificacaoTomador.Controls.Add(Me.txtInscricaoEstadualTomador)
        Me.grpIdentificacaoTomador.Controls.Add(Me.lblInscricaoEstadualTomador)
        Me.grpIdentificacaoTomador.Controls.Add(Me.lblCNPJTomador)
        Me.grpIdentificacaoTomador.Controls.Add(Me.lblTomador)
        Me.grpIdentificacaoTomador.Controls.Add(Me.cboTomador)
        Me.grpIdentificacaoTomador.Controls.Add(Me.btnCadastrarTomador)
        Me.grpIdentificacaoTomador.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpIdentificacaoTomador.Location = New System.Drawing.Point(8, 267)
        Me.grpIdentificacaoTomador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpIdentificacaoTomador.Name = "grpIdentificacaoTomador"
        Me.grpIdentificacaoTomador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpIdentificacaoTomador.Size = New System.Drawing.Size(879, 67)
        Me.grpIdentificacaoTomador.TabIndex = 4
        Me.grpIdentificacaoTomador.Text = "Identificação"
        Me.grpIdentificacaoTomador.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarTomador
        '
        Me.btnProcurarTomador.FlatAppearance.BorderSize = 0
        Me.btnProcurarTomador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarTomador.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarTomador.Location = New System.Drawing.Point(376, 18)
        Me.btnProcurarTomador.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarTomador.Name = "btnProcurarTomador"
        Me.btnProcurarTomador.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarTomador.TabIndex = 2
        Me.btnProcurarTomador.TabStop = False
        Me.btnProcurarTomador.UseVisualStyleBackColor = True
        '
        'txtCNPJTomador
        '
        Me.txtCNPJTomador.BackColor = System.Drawing.Color.White
        Me.txtCNPJTomador.Enabled = False
        Me.txtCNPJTomador.Location = New System.Drawing.Point(399, 37)
        Me.txtCNPJTomador.Mask = "00,000,000/0000-00"
        Me.txtCNPJTomador.MaxLength = 25
        Me.txtCNPJTomador.Name = "txtCNPJTomador"
        Me.txtCNPJTomador.Size = New System.Drawing.Size(129, 20)
        Me.txtCNPJTomador.TabIndex = 5
        '
        'txtInscricaoMunicipalTomador
        '
        Me.txtInscricaoMunicipalTomador.BackColor = System.Drawing.Color.White
        Me.txtInscricaoMunicipalTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoMunicipalTomador.Enabled = False
        Me.txtInscricaoMunicipalTomador.Location = New System.Drawing.Point(670, 37)
        Me.txtInscricaoMunicipalTomador.MaxLength = 9
        Me.txtInscricaoMunicipalTomador.Name = "txtInscricaoMunicipalTomador"
        Me.txtInscricaoMunicipalTomador.Size = New System.Drawing.Size(130, 20)
        Me.txtInscricaoMunicipalTomador.TabIndex = 9
        '
        'lblInscricaoMunicipalTomador
        '
        Me.lblInscricaoMunicipalTomador.AutoSize = True
        Me.lblInscricaoMunicipalTomador.Location = New System.Drawing.Point(667, 20)
        Me.lblInscricaoMunicipalTomador.Name = "lblInscricaoMunicipalTomador"
        Me.lblInscricaoMunicipalTomador.Size = New System.Drawing.Size(101, 14)
        Me.lblInscricaoMunicipalTomador.TabIndex = 8
        Me.lblInscricaoMunicipalTomador.Text = "Inscrição Municipal:"
        '
        'txtInscricaoEstadualTomador
        '
        Me.txtInscricaoEstadualTomador.BackColor = System.Drawing.Color.White
        Me.txtInscricaoEstadualTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoEstadualTomador.Enabled = False
        Me.txtInscricaoEstadualTomador.Location = New System.Drawing.Point(534, 37)
        Me.txtInscricaoEstadualTomador.MaxLength = 14
        Me.txtInscricaoEstadualTomador.Name = "txtInscricaoEstadualTomador"
        Me.txtInscricaoEstadualTomador.Size = New System.Drawing.Size(130, 20)
        Me.txtInscricaoEstadualTomador.TabIndex = 7
        '
        'lblInscricaoEstadualTomador
        '
        Me.lblInscricaoEstadualTomador.AutoSize = True
        Me.lblInscricaoEstadualTomador.Location = New System.Drawing.Point(531, 20)
        Me.lblInscricaoEstadualTomador.Name = "lblInscricaoEstadualTomador"
        Me.lblInscricaoEstadualTomador.Size = New System.Drawing.Size(98, 14)
        Me.lblInscricaoEstadualTomador.TabIndex = 6
        Me.lblInscricaoEstadualTomador.Text = "Inscrição Estadual:"
        '
        'lblCNPJTomador
        '
        Me.lblCNPJTomador.AutoSize = True
        Me.lblCNPJTomador.Location = New System.Drawing.Point(396, 20)
        Me.lblCNPJTomador.Name = "lblCNPJTomador"
        Me.lblCNPJTomador.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJTomador.TabIndex = 4
        Me.lblCNPJTomador.Text = "CNPJ:"
        '
        'lblTomador
        '
        Me.lblTomador.AutoSize = True
        Me.lblTomador.Location = New System.Drawing.Point(25, 20)
        Me.lblTomador.Name = "lblTomador"
        Me.lblTomador.Size = New System.Drawing.Size(51, 14)
        Me.lblTomador.TabIndex = 1
        Me.lblTomador.Text = "Tomador:"
        '
        'cboTomador
        '
        Me.cboTomador.AutoSize = False
        Me.cboTomador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTomador.Location = New System.Drawing.Point(9, 37)
        Me.cboTomador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTomador.Name = "cboTomador"
        Me.cboTomador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTomador.Size = New System.Drawing.Size(384, 20)
        Me.cboTomador.TabIndex = 3
        '
        'btnCadastrarTomador
        '
        Me.btnCadastrarTomador.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTomador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTomador.Image = CType(resources.GetObject("btnCadastrarTomador.Image"), System.Drawing.Image)
        Me.btnCadastrarTomador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTomador.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarTomador.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTomador.Name = "btnCadastrarTomador"
        Me.btnCadastrarTomador.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTomador.TabIndex = 0
        Me.btnCadastrarTomador.TabStop = False
        Me.btnCadastrarTomador.UseVisualStyleBackColor = True
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtDataEmissao)
        Me.grpDados.Controls.Add(Me.cboTipoRPS)
        Me.grpDados.Controls.Add(Me.lblTipoRPS)
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
        Me.grpDados.Size = New System.Drawing.Size(540, 67)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados da NFS-e"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataEmissao.Location = New System.Drawing.Point(283, 37)
        Me.txtDataEmissao.MaxLength = 50
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.ReadOnly = True
        Me.txtDataEmissao.Size = New System.Drawing.Size(135, 20)
        Me.txtDataEmissao.TabIndex = 22
        Me.txtDataEmissao.TabStop = False
        Me.txtDataEmissao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'cboTipoRPS
        '
        Me.cboTipoRPS.AutoSize = False
        Me.cboTipoRPS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoRPS.Location = New System.Drawing.Point(424, 37)
        Me.cboTipoRPS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoRPS.Name = "cboTipoRPS"
        Me.cboTipoRPS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoRPS.Size = New System.Drawing.Size(107, 20)
        Me.cboTipoRPS.TabIndex = 9
        '
        'lblTipoRPS
        '
        Me.lblTipoRPS.AutoSize = True
        Me.lblTipoRPS.Location = New System.Drawing.Point(421, 20)
        Me.lblTipoRPS.Name = "lblTipoRPS"
        Me.lblTipoRPS.Size = New System.Drawing.Size(68, 14)
        Me.lblTipoRPS.TabIndex = 8
        Me.lblTipoRPS.Text = "Tipo de RPS:"
        '
        'cboSerie
        '
        Me.cboSerie.AutoSize = False
        Me.cboSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSerie.Location = New System.Drawing.Point(122, 37)
        Me.cboSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSerie.Name = "cboSerie"
        Me.cboSerie.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSerie.Size = New System.Drawing.Size(53, 20)
        Me.cboSerie.TabIndex = 3
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(280, 20)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 6
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(119, 20)
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
        Me.txtNotaFiscal.Location = New System.Drawing.Point(181, 37)
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
        Me.lblNotaFiscal.Location = New System.Drawing.Point(178, 20)
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
        Me.cboModelo.Size = New System.Drawing.Size(107, 20)
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
        Me.grpDadosEmitente.Size = New System.Drawing.Size(540, 94)
        Me.grpDadosEmitente.TabIndex = 2
        Me.grpDadosEmitente.Text = "Dados do Emitente"
        Me.grpDadosEmitente.VisualStyleManager = Me.vsmMain
        '
        'lblValorRegimeTributarioEmitente
        '
        Me.lblValorRegimeTributarioEmitente.AutoSize = True
        Me.lblValorRegimeTributarioEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorRegimeTributarioEmitente.Location = New System.Drawing.Point(391, 37)
        Me.lblValorRegimeTributarioEmitente.Name = "lblValorRegimeTributarioEmitente"
        Me.lblValorRegimeTributarioEmitente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorRegimeTributarioEmitente.TabIndex = 7
        Me.lblValorRegimeTributarioEmitente.Text = "-"
        '
        'lblValorInscricaoEstadualEmitente
        '
        Me.lblValorInscricaoEstadualEmitente.AutoSize = True
        Me.lblValorInscricaoEstadualEmitente.BackColor = System.Drawing.Color.Transparent
        Me.lblValorInscricaoEstadualEmitente.Location = New System.Drawing.Point(391, 20)
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
        Me.lblRegimeTributarioEmitente.Location = New System.Drawing.Point(277, 37)
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
        Me.lblInscricaoEstadualEmitente.Location = New System.Drawing.Point(277, 20)
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
        'pagServico
        '
        Me.pagServico.Controls.Add(Me.grpClassificacao)
        Me.pagServico.Controls.Add(Me.grpValores)
        Me.pagServico.Controls.Add(Me.grpServico)
        Me.pagServico.Key = "pagServico"
        Me.pagServico.Location = New System.Drawing.Point(1, 22)
        Me.pagServico.Name = "pagServico"
        Me.pagServico.Size = New System.Drawing.Size(895, 450)
        Me.pagServico.TabStop = True
        Me.pagServico.Text = "Serviços"
        '
        'grpClassificacao
        '
        Me.grpClassificacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpClassificacao.BackColor = System.Drawing.Color.Transparent
        Me.grpClassificacao.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpClassificacao.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpClassificacao.Controls.Add(Me.cboContaContabil)
        Me.grpClassificacao.Controls.Add(Me.lblContaContabil)
        Me.grpClassificacao.Controls.Add(Me.cboCentroGasto)
        Me.grpClassificacao.Controls.Add(Me.lblCentroGasto)
        Me.grpClassificacao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpClassificacao.Location = New System.Drawing.Point(8, 193)
        Me.grpClassificacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpClassificacao.Name = "grpClassificacao"
        Me.grpClassificacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpClassificacao.Size = New System.Drawing.Size(879, 67)
        Me.grpClassificacao.TabIndex = 1
        Me.grpClassificacao.Text = "Classificação"
        Me.grpClassificacao.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = CType(resources.GetObject("btnCadastrarContaContabil.Image"), System.Drawing.Image)
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(458, 21)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 5
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = CType(resources.GetObject("btnCadastrarCentroGasto.Image"), System.Drawing.Image)
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 4
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(458, 37)
        Me.cboContaContabil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(412, 20)
        Me.cboContaContabil.TabIndex = 3
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(474, 20)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 2
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(9, 37)
        Me.cboCentroGasto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(443, 20)
        Me.cboCentroGasto.TabIndex = 1
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(25, 20)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 0
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'grpValores
        '
        Me.grpValores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpValores.BackColor = System.Drawing.Color.Transparent
        Me.grpValores.Controls.Add(Me.btnCalcularCSLL)
        Me.grpValores.Controls.Add(Me.btnCalcularINSS)
        Me.grpValores.Controls.Add(Me.btnCalcularCOFINS)
        Me.grpValores.Controls.Add(Me.btnCalcularPIS)
        Me.grpValores.Controls.Add(Me.txtAliquotaIR)
        Me.grpValores.Controls.Add(Me.lblAliquotaIR)
        Me.grpValores.Controls.Add(Me.txtAliquotaCSLL)
        Me.grpValores.Controls.Add(Me.lblAliquotaCSLL)
        Me.grpValores.Controls.Add(Me.txtAliquotaINSS)
        Me.grpValores.Controls.Add(Me.lblAliquotaINSS)
        Me.grpValores.Controls.Add(Me.txtAliquotaCOFINS)
        Me.grpValores.Controls.Add(Me.lblAliquotaCOFINS)
        Me.grpValores.Controls.Add(Me.txtAliquotaPIS)
        Me.grpValores.Controls.Add(Me.lblAliquotaPIS)
        Me.grpValores.Controls.Add(Me.cboISSRetido)
        Me.grpValores.Controls.Add(Me.lblISSRetido)
        Me.grpValores.Controls.Add(Me.txtValorISS)
        Me.grpValores.Controls.Add(Me.lblValorISS)
        Me.grpValores.Controls.Add(Me.txtValorISSRetido)
        Me.grpValores.Controls.Add(Me.lblValorISSRetido)
        Me.grpValores.Controls.Add(Me.txtAliquotaISS)
        Me.grpValores.Controls.Add(Me.lblAliquotaISS)
        Me.grpValores.Controls.Add(Me.txtBaseCalculo)
        Me.grpValores.Controls.Add(Me.lblBaseCalculo)
        Me.grpValores.Controls.Add(Me.txtOutrasRetencoes)
        Me.grpValores.Controls.Add(Me.lblOutrasRetencoes)
        Me.grpValores.Controls.Add(Me.txtValorCSLL)
        Me.grpValores.Controls.Add(Me.lblValorCSLL)
        Me.grpValores.Controls.Add(Me.txtValorIR)
        Me.grpValores.Controls.Add(Me.lblValorIR)
        Me.grpValores.Controls.Add(Me.txtValorINSS)
        Me.grpValores.Controls.Add(Me.lblValorINSS)
        Me.grpValores.Controls.Add(Me.txtValorCOFINS)
        Me.grpValores.Controls.Add(Me.lblValorCOFINS)
        Me.grpValores.Controls.Add(Me.txtValorPIS)
        Me.grpValores.Controls.Add(Me.lblValorPIS)
        Me.grpValores.Controls.Add(Me.txtValorDeducoes)
        Me.grpValores.Controls.Add(Me.lblValorDeducoes)
        Me.grpValores.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpValores.Location = New System.Drawing.Point(8, 263)
        Me.grpValores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpValores.Name = "grpValores"
        Me.grpValores.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpValores.Size = New System.Drawing.Size(879, 147)
        Me.grpValores.TabIndex = 2
        Me.grpValores.Text = "Retenções / Deduções / Impostos"
        Me.grpValores.VisualStyleManager = Me.vsmMain
        '
        'btnCalcularCSLL
        '
        Me.btnCalcularCSLL.FlatAppearance.BorderSize = 0
        Me.btnCalcularCSLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularCSLL.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularCSLL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcularCSLL.Location = New System.Drawing.Point(628, 59)
        Me.btnCalcularCSLL.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalcularCSLL.Name = "btnCalcularCSLL"
        Me.btnCalcularCSLL.Size = New System.Drawing.Size(13, 16)
        Me.btnCalcularCSLL.TabIndex = 37
        Me.btnCalcularCSLL.TabStop = False
        Me.btnCalcularCSLL.UseVisualStyleBackColor = True
        '
        'btnCalcularINSS
        '
        Me.btnCalcularINSS.FlatAppearance.BorderSize = 0
        Me.btnCalcularINSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularINSS.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularINSS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcularINSS.Location = New System.Drawing.Point(504, 59)
        Me.btnCalcularINSS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalcularINSS.Name = "btnCalcularINSS"
        Me.btnCalcularINSS.Size = New System.Drawing.Size(13, 16)
        Me.btnCalcularINSS.TabIndex = 36
        Me.btnCalcularINSS.TabStop = False
        Me.btnCalcularINSS.UseVisualStyleBackColor = True
        '
        'btnCalcularCOFINS
        '
        Me.btnCalcularCOFINS.FlatAppearance.BorderSize = 0
        Me.btnCalcularCOFINS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularCOFINS.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularCOFINS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcularCOFINS.Location = New System.Drawing.Point(380, 59)
        Me.btnCalcularCOFINS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalcularCOFINS.Name = "btnCalcularCOFINS"
        Me.btnCalcularCOFINS.Size = New System.Drawing.Size(13, 16)
        Me.btnCalcularCOFINS.TabIndex = 35
        Me.btnCalcularCOFINS.TabStop = False
        Me.btnCalcularCOFINS.UseVisualStyleBackColor = True
        '
        'btnCalcularPIS
        '
        Me.btnCalcularPIS.FlatAppearance.BorderSize = 0
        Me.btnCalcularPIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularPIS.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularPIS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcularPIS.Location = New System.Drawing.Point(256, 59)
        Me.btnCalcularPIS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalcularPIS.Name = "btnCalcularPIS"
        Me.btnCalcularPIS.Size = New System.Drawing.Size(13, 16)
        Me.btnCalcularPIS.TabIndex = 34
        Me.btnCalcularPIS.TabStop = False
        Me.btnCalcularPIS.UseVisualStyleBackColor = True
        '
        'txtAliquotaIR
        '
        Me.txtAliquotaIR.DecimalDigits = 2
        Me.txtAliquotaIR.Location = New System.Drawing.Point(752, 77)
        Me.txtAliquotaIR.Name = "txtAliquotaIR"
        Me.txtAliquotaIR.Size = New System.Drawing.Size(118, 20)
        Me.txtAliquotaIR.TabIndex = 18
        Me.txtAliquotaIR.Text = "0,00"
        Me.txtAliquotaIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIR
        '
        Me.lblAliquotaIR.AutoSize = True
        Me.lblAliquotaIR.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaIR.Location = New System.Drawing.Point(749, 60)
        Me.lblAliquotaIR.Name = "lblAliquotaIR"
        Me.lblAliquotaIR.Size = New System.Drawing.Size(82, 14)
        Me.lblAliquotaIR.TabIndex = 19
        Me.lblAliquotaIR.Text = "Alíquota IR (%):"
        '
        'txtAliquotaCSLL
        '
        Me.txtAliquotaCSLL.DecimalDigits = 2
        Me.txtAliquotaCSLL.Location = New System.Drawing.Point(628, 77)
        Me.txtAliquotaCSLL.Name = "txtAliquotaCSLL"
        Me.txtAliquotaCSLL.Size = New System.Drawing.Size(118, 20)
        Me.txtAliquotaCSLL.TabIndex = 17
        Me.txtAliquotaCSLL.Text = "0,00"
        Me.txtAliquotaCSLL.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCSLL
        '
        Me.lblAliquotaCSLL.AutoSize = True
        Me.lblAliquotaCSLL.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaCSLL.Location = New System.Drawing.Point(644, 60)
        Me.lblAliquotaCSLL.Name = "lblAliquotaCSLL"
        Me.lblAliquotaCSLL.Size = New System.Drawing.Size(57, 14)
        Me.lblAliquotaCSLL.TabIndex = 16
        Me.lblAliquotaCSLL.Text = "CSLL (%):"
        '
        'txtAliquotaINSS
        '
        Me.txtAliquotaINSS.DecimalDigits = 2
        Me.txtAliquotaINSS.Location = New System.Drawing.Point(504, 77)
        Me.txtAliquotaINSS.Name = "txtAliquotaINSS"
        Me.txtAliquotaINSS.Size = New System.Drawing.Size(118, 20)
        Me.txtAliquotaINSS.TabIndex = 15
        Me.txtAliquotaINSS.Text = "0,00"
        Me.txtAliquotaINSS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaINSS
        '
        Me.lblAliquotaINSS.AutoSize = True
        Me.lblAliquotaINSS.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaINSS.Location = New System.Drawing.Point(520, 60)
        Me.lblAliquotaINSS.Name = "lblAliquotaINSS"
        Me.lblAliquotaINSS.Size = New System.Drawing.Size(54, 14)
        Me.lblAliquotaINSS.TabIndex = 14
        Me.lblAliquotaINSS.Text = "INSS (%):"
        '
        'txtAliquotaCOFINS
        '
        Me.txtAliquotaCOFINS.DecimalDigits = 2
        Me.txtAliquotaCOFINS.Location = New System.Drawing.Point(380, 77)
        Me.txtAliquotaCOFINS.Name = "txtAliquotaCOFINS"
        Me.txtAliquotaCOFINS.Size = New System.Drawing.Size(118, 20)
        Me.txtAliquotaCOFINS.TabIndex = 13
        Me.txtAliquotaCOFINS.Text = "0,00"
        Me.txtAliquotaCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCOFINS
        '
        Me.lblAliquotaCOFINS.AutoSize = True
        Me.lblAliquotaCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaCOFINS.Location = New System.Drawing.Point(396, 60)
        Me.lblAliquotaCOFINS.Name = "lblAliquotaCOFINS"
        Me.lblAliquotaCOFINS.Size = New System.Drawing.Size(68, 14)
        Me.lblAliquotaCOFINS.TabIndex = 12
        Me.lblAliquotaCOFINS.Text = "COFINS (%):"
        '
        'txtAliquotaPIS
        '
        Me.txtAliquotaPIS.DecimalDigits = 2
        Me.txtAliquotaPIS.Location = New System.Drawing.Point(256, 77)
        Me.txtAliquotaPIS.Name = "txtAliquotaPIS"
        Me.txtAliquotaPIS.Size = New System.Drawing.Size(118, 20)
        Me.txtAliquotaPIS.TabIndex = 11
        Me.txtAliquotaPIS.Text = "0,00"
        Me.txtAliquotaPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPIS
        '
        Me.lblAliquotaPIS.AutoSize = True
        Me.lblAliquotaPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaPIS.Location = New System.Drawing.Point(272, 60)
        Me.lblAliquotaPIS.Name = "lblAliquotaPIS"
        Me.lblAliquotaPIS.Size = New System.Drawing.Size(46, 14)
        Me.lblAliquotaPIS.TabIndex = 10
        Me.lblAliquotaPIS.Text = "PIS (%):"
        '
        'cboISSRetido
        '
        Me.cboISSRetido.AutoSize = False
        Me.cboISSRetido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboISSRetido.Location = New System.Drawing.Point(132, 77)
        Me.cboISSRetido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboISSRetido.Name = "cboISSRetido"
        Me.cboISSRetido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboISSRetido.Size = New System.Drawing.Size(118, 20)
        Me.cboISSRetido.TabIndex = 9
        '
        'lblISSRetido
        '
        Me.lblISSRetido.AutoSize = True
        Me.lblISSRetido.BackColor = System.Drawing.Color.Transparent
        Me.lblISSRetido.Location = New System.Drawing.Point(129, 60)
        Me.lblISSRetido.Name = "lblISSRetido"
        Me.lblISSRetido.Size = New System.Drawing.Size(59, 14)
        Me.lblISSRetido.TabIndex = 8
        Me.lblISSRetido.Text = "ISS Retido:"
        '
        'txtValorISS
        '
        Me.txtValorISS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorISS.DecimalDigits = 2
        Me.txtValorISS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorISS.Location = New System.Drawing.Point(9, 117)
        Me.txtValorISS.Name = "txtValorISS"
        Me.txtValorISS.Size = New System.Drawing.Size(117, 20)
        Me.txtValorISS.TabIndex = 21
        Me.txtValorISS.TabStop = False
        Me.txtValorISS.Text = "0,00"
        Me.txtValorISS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorISS
        '
        Me.lblValorISS.AutoSize = True
        Me.lblValorISS.BackColor = System.Drawing.Color.Transparent
        Me.lblValorISS.Location = New System.Drawing.Point(6, 100)
        Me.lblValorISS.Name = "lblValorISS"
        Me.lblValorISS.Size = New System.Drawing.Size(54, 14)
        Me.lblValorISS.TabIndex = 20
        Me.lblValorISS.Text = "Valor ISS:"
        '
        'txtValorISSRetido
        '
        Me.txtValorISSRetido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorISSRetido.DecimalDigits = 2
        Me.txtValorISSRetido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorISSRetido.Location = New System.Drawing.Point(132, 117)
        Me.txtValorISSRetido.Name = "txtValorISSRetido"
        Me.txtValorISSRetido.Size = New System.Drawing.Size(118, 20)
        Me.txtValorISSRetido.TabIndex = 23
        Me.txtValorISSRetido.TabStop = False
        Me.txtValorISSRetido.Text = "0,00"
        Me.txtValorISSRetido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorISSRetido
        '
        Me.lblValorISSRetido.AutoSize = True
        Me.lblValorISSRetido.BackColor = System.Drawing.Color.Transparent
        Me.lblValorISSRetido.Location = New System.Drawing.Point(129, 100)
        Me.lblValorISSRetido.Name = "lblValorISSRetido"
        Me.lblValorISSRetido.Size = New System.Drawing.Size(87, 14)
        Me.lblValorISSRetido.TabIndex = 22
        Me.lblValorISSRetido.Text = "Valor ISS Retido:"
        '
        'txtAliquotaISS
        '
        Me.txtAliquotaISS.DecimalDigits = 2
        Me.txtAliquotaISS.Location = New System.Drawing.Point(9, 77)
        Me.txtAliquotaISS.Name = "txtAliquotaISS"
        Me.txtAliquotaISS.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaISS.TabIndex = 7
        Me.txtAliquotaISS.Text = "0,00"
        Me.txtAliquotaISS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaISS
        '
        Me.lblAliquotaISS.AutoSize = True
        Me.lblAliquotaISS.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaISS.Location = New System.Drawing.Point(6, 60)
        Me.lblAliquotaISS.Name = "lblAliquotaISS"
        Me.lblAliquotaISS.Size = New System.Drawing.Size(89, 14)
        Me.lblAliquotaISS.TabIndex = 6
        Me.lblAliquotaISS.Text = "Alíquota ISS (%):"
        '
        'txtBaseCalculo
        '
        Me.txtBaseCalculo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBaseCalculo.Location = New System.Drawing.Point(256, 37)
        Me.txtBaseCalculo.Name = "txtBaseCalculo"
        Me.txtBaseCalculo.ReadOnly = True
        Me.txtBaseCalculo.Size = New System.Drawing.Size(118, 20)
        Me.txtBaseCalculo.TabIndex = 5
        Me.txtBaseCalculo.TabStop = False
        Me.txtBaseCalculo.Text = "0,00"
        Me.txtBaseCalculo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculo
        '
        Me.lblBaseCalculo.AutoSize = True
        Me.lblBaseCalculo.BackColor = System.Drawing.Color.Transparent
        Me.lblBaseCalculo.Location = New System.Drawing.Point(253, 20)
        Me.lblBaseCalculo.Name = "lblBaseCalculo"
        Me.lblBaseCalculo.Size = New System.Drawing.Size(73, 14)
        Me.lblBaseCalculo.TabIndex = 4
        Me.lblBaseCalculo.Text = "Base Cálculo:"
        '
        'txtOutrasRetencoes
        '
        Me.txtOutrasRetencoes.Location = New System.Drawing.Point(9, 37)
        Me.txtOutrasRetencoes.Name = "txtOutrasRetencoes"
        Me.txtOutrasRetencoes.Size = New System.Drawing.Size(117, 20)
        Me.txtOutrasRetencoes.TabIndex = 1
        Me.txtOutrasRetencoes.Text = "0,00"
        Me.txtOutrasRetencoes.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblOutrasRetencoes
        '
        Me.lblOutrasRetencoes.AutoSize = True
        Me.lblOutrasRetencoes.BackColor = System.Drawing.Color.Transparent
        Me.lblOutrasRetencoes.Location = New System.Drawing.Point(6, 20)
        Me.lblOutrasRetencoes.Name = "lblOutrasRetencoes"
        Me.lblOutrasRetencoes.Size = New System.Drawing.Size(98, 14)
        Me.lblOutrasRetencoes.TabIndex = 0
        Me.lblOutrasRetencoes.Text = "Outras Retenções:"
        '
        'txtValorCSLL
        '
        Me.txtValorCSLL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorCSLL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorCSLL.Location = New System.Drawing.Point(628, 117)
        Me.txtValorCSLL.Name = "txtValorCSLL"
        Me.txtValorCSLL.Size = New System.Drawing.Size(118, 20)
        Me.txtValorCSLL.TabIndex = 31
        Me.txtValorCSLL.TabStop = False
        Me.txtValorCSLL.Text = "0,00"
        Me.txtValorCSLL.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCSLL
        '
        Me.lblValorCSLL.AutoSize = True
        Me.lblValorCSLL.BackColor = System.Drawing.Color.Transparent
        Me.lblValorCSLL.Location = New System.Drawing.Point(625, 100)
        Me.lblValorCSLL.Name = "lblValorCSLL"
        Me.lblValorCSLL.Size = New System.Drawing.Size(64, 14)
        Me.lblValorCSLL.TabIndex = 30
        Me.lblValorCSLL.Text = "Valor CSLL:"
        '
        'txtValorIR
        '
        Me.txtValorIR.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorIR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorIR.Location = New System.Drawing.Point(752, 117)
        Me.txtValorIR.Name = "txtValorIR"
        Me.txtValorIR.Size = New System.Drawing.Size(118, 20)
        Me.txtValorIR.TabIndex = 33
        Me.txtValorIR.TabStop = False
        Me.txtValorIR.Text = "0,00"
        Me.txtValorIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorIR
        '
        Me.lblValorIR.AutoSize = True
        Me.lblValorIR.BackColor = System.Drawing.Color.Transparent
        Me.lblValorIR.Location = New System.Drawing.Point(749, 100)
        Me.lblValorIR.Name = "lblValorIR"
        Me.lblValorIR.Size = New System.Drawing.Size(47, 14)
        Me.lblValorIR.TabIndex = 32
        Me.lblValorIR.Text = "Valor IR:"
        '
        'txtValorINSS
        '
        Me.txtValorINSS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorINSS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorINSS.Location = New System.Drawing.Point(504, 117)
        Me.txtValorINSS.Name = "txtValorINSS"
        Me.txtValorINSS.Size = New System.Drawing.Size(118, 20)
        Me.txtValorINSS.TabIndex = 29
        Me.txtValorINSS.TabStop = False
        Me.txtValorINSS.Text = "0,00"
        Me.txtValorINSS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorINSS
        '
        Me.lblValorINSS.AutoSize = True
        Me.lblValorINSS.BackColor = System.Drawing.Color.Transparent
        Me.lblValorINSS.Location = New System.Drawing.Point(501, 100)
        Me.lblValorINSS.Name = "lblValorINSS"
        Me.lblValorINSS.Size = New System.Drawing.Size(61, 14)
        Me.lblValorINSS.TabIndex = 28
        Me.lblValorINSS.Text = "Valor INSS:"
        '
        'txtValorCOFINS
        '
        Me.txtValorCOFINS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorCOFINS.Location = New System.Drawing.Point(380, 117)
        Me.txtValorCOFINS.Name = "txtValorCOFINS"
        Me.txtValorCOFINS.Size = New System.Drawing.Size(118, 20)
        Me.txtValorCOFINS.TabIndex = 27
        Me.txtValorCOFINS.TabStop = False
        Me.txtValorCOFINS.Text = "0,00"
        Me.txtValorCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCOFINS
        '
        Me.lblValorCOFINS.AutoSize = True
        Me.lblValorCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.lblValorCOFINS.Location = New System.Drawing.Point(377, 100)
        Me.lblValorCOFINS.Name = "lblValorCOFINS"
        Me.lblValorCOFINS.Size = New System.Drawing.Size(75, 14)
        Me.lblValorCOFINS.TabIndex = 26
        Me.lblValorCOFINS.Text = "Valor COFINS:"
        '
        'txtValorPIS
        '
        Me.txtValorPIS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorPIS.Location = New System.Drawing.Point(256, 117)
        Me.txtValorPIS.Name = "txtValorPIS"
        Me.txtValorPIS.Size = New System.Drawing.Size(118, 20)
        Me.txtValorPIS.TabIndex = 25
        Me.txtValorPIS.TabStop = False
        Me.txtValorPIS.Text = "0,00"
        Me.txtValorPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorPIS
        '
        Me.lblValorPIS.AutoSize = True
        Me.lblValorPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblValorPIS.Location = New System.Drawing.Point(253, 100)
        Me.lblValorPIS.Name = "lblValorPIS"
        Me.lblValorPIS.Size = New System.Drawing.Size(53, 14)
        Me.lblValorPIS.TabIndex = 24
        Me.lblValorPIS.Text = "Valor PIS:"
        '
        'txtValorDeducoes
        '
        Me.txtValorDeducoes.Location = New System.Drawing.Point(132, 37)
        Me.txtValorDeducoes.Name = "txtValorDeducoes"
        Me.txtValorDeducoes.Size = New System.Drawing.Size(118, 20)
        Me.txtValorDeducoes.TabIndex = 3
        Me.txtValorDeducoes.Text = "0,00"
        Me.txtValorDeducoes.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDeducoes
        '
        Me.lblValorDeducoes.AutoSize = True
        Me.lblValorDeducoes.BackColor = System.Drawing.Color.Transparent
        Me.lblValorDeducoes.Location = New System.Drawing.Point(129, 20)
        Me.lblValorDeducoes.Name = "lblValorDeducoes"
        Me.lblValorDeducoes.Size = New System.Drawing.Size(108, 14)
        Me.lblValorDeducoes.TabIndex = 2
        Me.lblValorDeducoes.Text = "Valor das Deduções:"
        '
        'grpServico
        '
        Me.grpServico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpServico.BackColor = System.Drawing.Color.Transparent
        Me.grpServico.Controls.Add(Me.btnCadastrarServico)
        Me.grpServico.Controls.Add(Me.txtValorLiquidoNFSE)
        Me.grpServico.Controls.Add(Me.lblValorLiquidoNFSE)
        Me.grpServico.Controls.Add(Me.txtValorDescontoIncondicionado)
        Me.grpServico.Controls.Add(Me.lblValorDescontoIncondicionado)
        Me.grpServico.Controls.Add(Me.txtValorDescontoCondicionado)
        Me.grpServico.Controls.Add(Me.lblValorDescontoCondicionado)
        Me.grpServico.Controls.Add(Me.txtValorServico)
        Me.grpServico.Controls.Add(Me.lblValorServico)
        Me.grpServico.Controls.Add(Me.btnProcurarServico)
        Me.grpServico.Controls.Add(Me.cboServico)
        Me.grpServico.Controls.Add(Me.lblServico)
        Me.grpServico.Controls.Add(Me.txtDescricao)
        Me.grpServico.Controls.Add(Me.lblDescricao)
        Me.grpServico.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpServico.Location = New System.Drawing.Point(8, 3)
        Me.grpServico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpServico.Name = "grpServico"
        Me.grpServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpServico.Size = New System.Drawing.Size(879, 187)
        Me.grpServico.TabIndex = 0
        Me.grpServico.Text = "Dados do Serviço"
        Me.grpServico.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarServico
        '
        Me.btnCadastrarServico.FlatAppearance.BorderSize = 0
        Me.btnCadastrarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarServico.Image = CType(resources.GetObject("btnCadastrarServico.Image"), System.Drawing.Image)
        Me.btnCadastrarServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarServico.Location = New System.Drawing.Point(9, 20)
        Me.btnCadastrarServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarServico.Name = "btnCadastrarServico"
        Me.btnCadastrarServico.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarServico.TabIndex = 2
        Me.btnCadastrarServico.TabStop = False
        Me.btnCadastrarServico.UseVisualStyleBackColor = True
        '
        'txtValorLiquidoNFSE
        '
        Me.txtValorLiquidoNFSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorLiquidoNFSE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorLiquidoNFSE.DecimalDigits = 2
        Me.txtValorLiquidoNFSE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorLiquidoNFSE.Location = New System.Drawing.Point(752, 157)
        Me.txtValorLiquidoNFSE.Name = "txtValorLiquidoNFSE"
        Me.txtValorLiquidoNFSE.ReadOnly = True
        Me.txtValorLiquidoNFSE.Size = New System.Drawing.Size(118, 20)
        Me.txtValorLiquidoNFSE.TabIndex = 15
        Me.txtValorLiquidoNFSE.TabStop = False
        Me.txtValorLiquidoNFSE.Text = "0,00"
        Me.txtValorLiquidoNFSE.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorLiquidoNFSE
        '
        Me.lblValorLiquidoNFSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorLiquidoNFSE.AutoSize = True
        Me.lblValorLiquidoNFSE.BackColor = System.Drawing.Color.Transparent
        Me.lblValorLiquidoNFSE.Location = New System.Drawing.Point(749, 140)
        Me.lblValorLiquidoNFSE.Name = "lblValorLiquidoNFSE"
        Me.lblValorLiquidoNFSE.Size = New System.Drawing.Size(72, 14)
        Me.lblValorLiquidoNFSE.TabIndex = 14
        Me.lblValorLiquidoNFSE.Text = "Valor Líquido:"
        '
        'txtValorDescontoIncondicionado
        '
        Me.txtValorDescontoIncondicionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDescontoIncondicionado.DecimalDigits = 2
        Me.txtValorDescontoIncondicionado.Location = New System.Drawing.Point(752, 117)
        Me.txtValorDescontoIncondicionado.Name = "txtValorDescontoIncondicionado"
        Me.txtValorDescontoIncondicionado.Size = New System.Drawing.Size(118, 20)
        Me.txtValorDescontoIncondicionado.TabIndex = 13
        Me.txtValorDescontoIncondicionado.Text = "0,00"
        Me.txtValorDescontoIncondicionado.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDescontoIncondicionado
        '
        Me.lblValorDescontoIncondicionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorDescontoIncondicionado.AutoSize = True
        Me.lblValorDescontoIncondicionado.BackColor = System.Drawing.Color.Transparent
        Me.lblValorDescontoIncondicionado.Location = New System.Drawing.Point(749, 100)
        Me.lblValorDescontoIncondicionado.Name = "lblValorDescontoIncondicionado"
        Me.lblValorDescontoIncondicionado.Size = New System.Drawing.Size(103, 14)
        Me.lblValorDescontoIncondicionado.TabIndex = 12
        Me.lblValorDescontoIncondicionado.Text = "Desc. Incondicional:"
        '
        'txtValorDescontoCondicionado
        '
        Me.txtValorDescontoCondicionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDescontoCondicionado.DecimalDigits = 2
        Me.txtValorDescontoCondicionado.Location = New System.Drawing.Point(752, 77)
        Me.txtValorDescontoCondicionado.Name = "txtValorDescontoCondicionado"
        Me.txtValorDescontoCondicionado.Size = New System.Drawing.Size(118, 20)
        Me.txtValorDescontoCondicionado.TabIndex = 11
        Me.txtValorDescontoCondicionado.Text = "0,00"
        Me.txtValorDescontoCondicionado.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDescontoCondicionado
        '
        Me.lblValorDescontoCondicionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorDescontoCondicionado.AutoSize = True
        Me.lblValorDescontoCondicionado.BackColor = System.Drawing.Color.Transparent
        Me.lblValorDescontoCondicionado.Location = New System.Drawing.Point(749, 60)
        Me.lblValorDescontoCondicionado.Name = "lblValorDescontoCondicionado"
        Me.lblValorDescontoCondicionado.Size = New System.Drawing.Size(96, 14)
        Me.lblValorDescontoCondicionado.TabIndex = 10
        Me.lblValorDescontoCondicionado.Text = "Desc. Condicional:"
        '
        'txtValorServico
        '
        Me.txtValorServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorServico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorServico.Location = New System.Drawing.Point(752, 37)
        Me.txtValorServico.Name = "txtValorServico"
        Me.txtValorServico.Size = New System.Drawing.Size(118, 20)
        Me.txtValorServico.TabIndex = 9
        Me.txtValorServico.Text = "0,00"
        Me.txtValorServico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorServico
        '
        Me.lblValorServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorServico.AutoSize = True
        Me.lblValorServico.BackColor = System.Drawing.Color.Transparent
        Me.lblValorServico.Location = New System.Drawing.Point(749, 20)
        Me.lblValorServico.Name = "lblValorServico"
        Me.lblValorServico.Size = New System.Drawing.Size(90, 14)
        Me.lblValorServico.TabIndex = 8
        Me.lblValorServico.Text = "Valor do Serviço:"
        '
        'btnProcurarServico
        '
        Me.btnProcurarServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarServico.FlatAppearance.BorderSize = 0
        Me.btnProcurarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarServico.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarServico.Location = New System.Drawing.Point(729, 19)
        Me.btnProcurarServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarServico.Name = "btnProcurarServico"
        Me.btnProcurarServico.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarServico.TabIndex = 4
        Me.btnProcurarServico.TabStop = False
        Me.btnProcurarServico.UseVisualStyleBackColor = True
        '
        'cboServico
        '
        Me.cboServico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboServico.AutoSize = False
        Me.cboServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboServico.Location = New System.Drawing.Point(9, 37)
        Me.cboServico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboServico.Name = "cboServico"
        Me.cboServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboServico.Size = New System.Drawing.Size(737, 20)
        Me.cboServico.TabIndex = 5
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.Location = New System.Drawing.Point(25, 20)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(47, 14)
        Me.lblServico.TabIndex = 3
        Me.lblServico.Text = "Serviço:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(9, 77)
        Me.txtDescricao.MaxLength = 2000
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescricao.Size = New System.Drawing.Size(737, 100)
        Me.txtDescricao.TabIndex = 7
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 60)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 6
        Me.lblDescricao.Text = "Descrição:"
        '
        'pagCobranca
        '
        Me.pagCobranca.Controls.Add(Me.grpDuplicata)
        Me.pagCobranca.Controls.Add(Me.grpFatura)
        Me.pagCobranca.Key = "pagCobranca"
        Me.pagCobranca.Location = New System.Drawing.Point(1, 22)
        Me.pagCobranca.Name = "pagCobranca"
        Me.pagCobranca.Size = New System.Drawing.Size(895, 450)
        Me.pagCobranca.TabStop = True
        Me.pagCobranca.Text = "Cobrança"
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
        Me.grpDuplicata.Controls.Add(Me.lblFormaPagamento)
        Me.grpDuplicata.Controls.Add(Me.cboFormaPagamento)
        Me.grpDuplicata.Controls.Add(Me.grdDuplicata)
        Me.grpDuplicata.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDuplicata.Location = New System.Drawing.Point(658, 3)
        Me.grpDuplicata.Name = "grpDuplicata"
        Me.grpDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDuplicata.Size = New System.Drawing.Size(229, 284)
        Me.grpDuplicata.TabIndex = 1
        Me.grpDuplicata.Text = "Duplicata"
        Me.grpDuplicata.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDuplicata.VisualStyleManager = Me.vsmMain
        '
        'btnCalcularDuplicata
        '
        Me.btnCalcularDuplicata.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularDuplicata.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCalcularDuplicata.Location = New System.Drawing.Point(129, 114)
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
        Me.txtIntervaloEntreParcelas.Location = New System.Drawing.Point(9, 117)
        Me.txtIntervaloEntreParcelas.Name = "txtIntervaloEntreParcelas"
        Me.txtIntervaloEntreParcelas.Size = New System.Drawing.Size(108, 20)
        Me.txtIntervaloEntreParcelas.TabIndex = 5
        Me.txtIntervaloEntreParcelas.Text = "0"
        Me.txtIntervaloEntreParcelas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblIntervaloEntreParcelas
        '
        Me.lblIntervaloEntreParcelas.AutoSize = True
        Me.lblIntervaloEntreParcelas.Location = New System.Drawing.Point(6, 100)
        Me.lblIntervaloEntreParcelas.Name = "lblIntervaloEntreParcelas"
        Me.lblIntervaloEntreParcelas.Size = New System.Drawing.Size(97, 14)
        Me.lblIntervaloEntreParcelas.TabIndex = 4
        Me.lblIntervaloEntreParcelas.Text = "Int. entre Parcelas:"
        '
        'txtNumeroParcela
        '
        Me.txtNumeroParcela.DecimalDigits = 0
        Me.txtNumeroParcela.Location = New System.Drawing.Point(9, 77)
        Me.txtNumeroParcela.Name = "txtNumeroParcela"
        Me.txtNumeroParcela.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroParcela.TabIndex = 3
        Me.txtNumeroParcela.Text = "0"
        Me.txtNumeroParcela.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroParcela
        '
        Me.lblNumeroParcela.AutoSize = True
        Me.lblNumeroParcela.Location = New System.Drawing.Point(6, 60)
        Me.lblNumeroParcela.Name = "lblNumeroParcela"
        Me.lblNumeroParcela.Size = New System.Drawing.Size(66, 14)
        Me.lblNumeroParcela.TabIndex = 2
        Me.lblNumeroParcela.Text = "N° Parcelas:"
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(6, 20)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblFormaPagamento.TabIndex = 0
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.AutoSize = False
        Me.cboFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaPagamento.Location = New System.Drawing.Point(9, 37)
        Me.cboFormaPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaPagamento.Size = New System.Drawing.Size(211, 20)
        Me.cboFormaPagamento.TabIndex = 1
        '
        'grdDuplicata
        '
        Me.grdDuplicata.AlternatingColors = True
        Me.grdDuplicata.CellToolTipText = "Duplo Clique para editar o Registro"
        grdDuplicata_DesignTimeLayout.LayoutString = resources.GetString("grdDuplicata_DesignTimeLayout.LayoutString")
        Me.grdDuplicata.DesignTimeLayout = grdDuplicata_DesignTimeLayout
        Me.grdDuplicata.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDuplicata.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDuplicata.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDuplicata.GroupByBoxVisible = False
        Me.grdDuplicata.Location = New System.Drawing.Point(9, 146)
        Me.grdDuplicata.Name = "grdDuplicata"
        Me.grdDuplicata.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDuplicata.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDuplicata.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDuplicata.Size = New System.Drawing.Size(211, 129)
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
        Me.grpFatura.Controls.Add(Me.txtValorLiquido)
        Me.grpFatura.Controls.Add(Me.lblValorLiquido)
        Me.grpFatura.Controls.Add(Me.txtValorDesconto)
        Me.grpFatura.Controls.Add(Me.lblValorDesconto)
        Me.grpFatura.Controls.Add(Me.txtValorOriginal)
        Me.grpFatura.Controls.Add(Me.lblValorOriginal)
        Me.grpFatura.Controls.Add(Me.txtFatura)
        Me.grpFatura.Controls.Add(Me.lblFatura)
        Me.grpFatura.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFatura.Location = New System.Drawing.Point(8, 3)
        Me.grpFatura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFatura.Name = "grpFatura"
        Me.grpFatura.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFatura.Size = New System.Drawing.Size(641, 67)
        Me.grpFatura.TabIndex = 0
        Me.grpFatura.Text = "Fatura"
        Me.grpFatura.VisualStyleManager = Me.vsmMain
        '
        'txtValorLiquido
        '
        Me.txtValorLiquido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorLiquido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorLiquido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorLiquido.Location = New System.Drawing.Point(541, 37)
        Me.txtValorLiquido.Name = "txtValorLiquido"
        Me.txtValorLiquido.ReadOnly = True
        Me.txtValorLiquido.Size = New System.Drawing.Size(92, 20)
        Me.txtValorLiquido.TabIndex = 7
        Me.txtValorLiquido.TabStop = False
        Me.txtValorLiquido.Text = "0,00"
        Me.txtValorLiquido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorLiquido
        '
        Me.lblValorLiquido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorLiquido.AutoSize = True
        Me.lblValorLiquido.Location = New System.Drawing.Point(538, 20)
        Me.lblValorLiquido.Name = "lblValorLiquido"
        Me.lblValorLiquido.Size = New System.Drawing.Size(72, 14)
        Me.lblValorLiquido.TabIndex = 6
        Me.lblValorLiquido.Text = "Valor Líquido:"
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDesconto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorDesconto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorDesconto.Location = New System.Drawing.Point(443, 37)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.ReadOnly = True
        Me.txtValorDesconto.Size = New System.Drawing.Size(92, 20)
        Me.txtValorDesconto.TabIndex = 5
        Me.txtValorDesconto.TabStop = False
        Me.txtValorDesconto.Text = "0,00"
        Me.txtValorDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDesconto
        '
        Me.lblValorDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorDesconto.AutoSize = True
        Me.lblValorDesconto.Location = New System.Drawing.Point(440, 20)
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
        Me.txtValorOriginal.Location = New System.Drawing.Point(345, 37)
        Me.txtValorOriginal.Name = "txtValorOriginal"
        Me.txtValorOriginal.ReadOnly = True
        Me.txtValorOriginal.Size = New System.Drawing.Size(92, 20)
        Me.txtValorOriginal.TabIndex = 3
        Me.txtValorOriginal.TabStop = False
        Me.txtValorOriginal.Text = "0,00"
        Me.txtValorOriginal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorOriginal
        '
        Me.lblValorOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorOriginal.AutoSize = True
        Me.lblValorOriginal.Location = New System.Drawing.Point(342, 20)
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
        Me.txtFatura.Location = New System.Drawing.Point(9, 37)
        Me.txtFatura.MaxLength = 60
        Me.txtFatura.Name = "txtFatura"
        Me.txtFatura.Size = New System.Drawing.Size(330, 20)
        Me.txtFatura.TabIndex = 1
        '
        'lblFatura
        '
        Me.lblFatura.AutoSize = True
        Me.lblFatura.Location = New System.Drawing.Point(6, 20)
        Me.lblFatura.Name = "lblFatura"
        Me.lblFatura.Size = New System.Drawing.Size(41, 14)
        Me.lblFatura.TabIndex = 0
        Me.lblFatura.Text = "Fatura:"
        '
        'pagNFSe
        '
        Me.pagNFSe.Controls.Add(Me.grpNFSe)
        Me.pagNFSe.Key = "pagNFSe"
        Me.pagNFSe.Location = New System.Drawing.Point(1, 22)
        Me.pagNFSe.Name = "pagNFSe"
        Me.pagNFSe.Size = New System.Drawing.Size(895, 450)
        Me.pagNFSe.TabStop = True
        Me.pagNFSe.Text = "Transmissão do Arquivo XML"
        '
        'grpNFSe
        '
        Me.grpNFSe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpNFSe.BackColor = System.Drawing.Color.Transparent
        Me.grpNFSe.Controls.Add(Me.btnImprimirNFSe)
        Me.grpNFSe.Controls.Add(Me.txtNumeroRPS)
        Me.grpNFSe.Controls.Add(Me.lblNumeroRPS)
        Me.grpNFSe.Controls.Add(Me.txtCodigoVerificacao)
        Me.grpNFSe.Controls.Add(Me.lblCodigoVerificacao)
        Me.grpNFSe.Controls.Add(Me.lblAmbiente)
        Me.grpNFSe.Controls.Add(Me.txtProtocolo)
        Me.grpNFSe.Controls.Add(Me.lblProtocolo)
        Me.grpNFSe.Controls.Add(Me.txtLote)
        Me.grpNFSe.Controls.Add(Me.lblLote)
        Me.grpNFSe.Controls.Add(Me.txtMensagemNFSe)
        Me.grpNFSe.Controls.Add(Me.lblMensagemNFSe)
        Me.grpNFSe.Controls.Add(Me.txtStatusNFSe)
        Me.grpNFSe.Controls.Add(Me.lblStatusNFSe)
        Me.grpNFSe.Controls.Add(Me.btnReenviarEmail)
        Me.grpNFSe.Controls.Add(Me.btnRetornarNFSE)
        Me.grpNFSe.Controls.Add(Me.btnTransmitirNFSE)
        Me.grpNFSe.Location = New System.Drawing.Point(8, 3)
        Me.grpNFSe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpNFSe.Name = "grpNFSe"
        Me.grpNFSe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpNFSe.Size = New System.Drawing.Size(879, 233)
        Me.grpNFSe.TabIndex = 0
        Me.grpNFSe.VisualStyleManager = Me.vsmMain
        '
        'btnImprimirNFSe
        '
        Me.btnImprimirNFSe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirNFSe.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimirNFSe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimirNFSe.Location = New System.Drawing.Point(720, 171)
        Me.btnImprimirNFSe.Name = "btnImprimirNFSe"
        Me.btnImprimirNFSe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimirNFSe.Size = New System.Drawing.Size(150, 23)
        Me.btnImprimirNFSe.TabIndex = 14
        Me.btnImprimirNFSe.Text = "Imprimir NFS-e"
        Me.btnImprimirNFSe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtNumeroRPS
        '
        Me.txtNumeroRPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroRPS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRPS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRPS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroRPS.Location = New System.Drawing.Point(110, 72)
        Me.txtNumeroRPS.MaxLength = 50
        Me.txtNumeroRPS.Name = "txtNumeroRPS"
        Me.txtNumeroRPS.ReadOnly = True
        Me.txtNumeroRPS.Size = New System.Drawing.Size(96, 20)
        Me.txtNumeroRPS.TabIndex = 21
        Me.txtNumeroRPS.TabStop = False
        Me.txtNumeroRPS.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroRPS
        '
        Me.lblNumeroRPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroRPS.AutoSize = True
        Me.lblNumeroRPS.Location = New System.Drawing.Point(6, 75)
        Me.lblNumeroRPS.Name = "lblNumeroRPS"
        Me.lblNumeroRPS.Size = New System.Drawing.Size(70, 14)
        Me.lblNumeroRPS.TabIndex = 20
        Me.lblNumeroRPS.Text = "Número RPS:"
        '
        'txtCodigoVerificacao
        '
        Me.txtCodigoVerificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoVerificacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoVerificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoVerificacao.Location = New System.Drawing.Point(110, 203)
        Me.txtCodigoVerificacao.MaxLength = 250
        Me.txtCodigoVerificacao.Name = "txtCodigoVerificacao"
        Me.txtCodigoVerificacao.ReadOnly = True
        Me.txtCodigoVerificacao.Size = New System.Drawing.Size(472, 20)
        Me.txtCodigoVerificacao.TabIndex = 19
        Me.txtCodigoVerificacao.TabStop = False
        '
        'lblCodigoVerificacao
        '
        Me.lblCodigoVerificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoVerificacao.AutoSize = True
        Me.lblCodigoVerificacao.Location = New System.Drawing.Point(6, 206)
        Me.lblCodigoVerificacao.Name = "lblCodigoVerificacao"
        Me.lblCodigoVerificacao.Size = New System.Drawing.Size(101, 14)
        Me.lblCodigoVerificacao.TabIndex = 18
        Me.lblCodigoVerificacao.Text = "Código Verificação:"
        '
        'lblAmbiente
        '
        Me.lblAmbiente.AutoSize = True
        Me.lblAmbiente.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAmbiente.ForeColor = System.Drawing.Color.Blue
        Me.lblAmbiente.Location = New System.Drawing.Point(6, 20)
        Me.lblAmbiente.Name = "lblAmbiente"
        Me.lblAmbiente.Size = New System.Drawing.Size(298, 23)
        Me.lblAmbiente.TabIndex = 3
        Me.lblAmbiente.Text = "AMBIENTE NÃO IDENTIFICADO"
        '
        'txtProtocolo
        '
        Me.txtProtocolo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtProtocolo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProtocolo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProtocolo.Location = New System.Drawing.Point(110, 177)
        Me.txtProtocolo.MaxLength = 250
        Me.txtProtocolo.Name = "txtProtocolo"
        Me.txtProtocolo.ReadOnly = True
        Me.txtProtocolo.Size = New System.Drawing.Size(472, 20)
        Me.txtProtocolo.TabIndex = 16
        Me.txtProtocolo.TabStop = False
        '
        'lblProtocolo
        '
        Me.lblProtocolo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProtocolo.AutoSize = True
        Me.lblProtocolo.Location = New System.Drawing.Point(6, 180)
        Me.lblProtocolo.Name = "lblProtocolo"
        Me.lblProtocolo.Size = New System.Drawing.Size(55, 14)
        Me.lblProtocolo.TabIndex = 15
        Me.lblProtocolo.Text = "Protocolo:"
        '
        'txtLote
        '
        Me.txtLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLote.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(110, 151)
        Me.txtLote.MaxLength = 250
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(472, 20)
        Me.txtLote.TabIndex = 10
        Me.txtLote.TabStop = False
        '
        'lblLote
        '
        Me.lblLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(6, 154)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 9
        Me.lblLote.Text = "Lote:"
        '
        'txtMensagemNFSe
        '
        Me.txtMensagemNFSe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMensagemNFSe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMensagemNFSe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensagemNFSe.Location = New System.Drawing.Point(110, 124)
        Me.txtMensagemNFSe.MaxLength = 250
        Me.txtMensagemNFSe.Name = "txtMensagemNFSe"
        Me.txtMensagemNFSe.ReadOnly = True
        Me.txtMensagemNFSe.Size = New System.Drawing.Size(472, 20)
        Me.txtMensagemNFSe.TabIndex = 4
        Me.txtMensagemNFSe.TabStop = False
        '
        'lblMensagemNFSe
        '
        Me.lblMensagemNFSe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMensagemNFSe.AutoSize = True
        Me.lblMensagemNFSe.Location = New System.Drawing.Point(6, 127)
        Me.lblMensagemNFSe.Name = "lblMensagemNFSe"
        Me.lblMensagemNFSe.Size = New System.Drawing.Size(95, 14)
        Me.lblMensagemNFSe.TabIndex = 3
        Me.lblMensagemNFSe.Text = "Mensagem NFS-e:"
        '
        'txtStatusNFSe
        '
        Me.txtStatusNFSe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtStatusNFSe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStatusNFSe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatusNFSe.Location = New System.Drawing.Point(110, 98)
        Me.txtStatusNFSe.MaxLength = 250
        Me.txtStatusNFSe.Name = "txtStatusNFSe"
        Me.txtStatusNFSe.ReadOnly = True
        Me.txtStatusNFSe.Size = New System.Drawing.Size(472, 20)
        Me.txtStatusNFSe.TabIndex = 1
        Me.txtStatusNFSe.TabStop = False
        '
        'lblStatusNFSe
        '
        Me.lblStatusNFSe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatusNFSe.AutoSize = True
        Me.lblStatusNFSe.Location = New System.Drawing.Point(6, 101)
        Me.lblStatusNFSe.Name = "lblStatusNFSe"
        Me.lblStatusNFSe.Size = New System.Drawing.Size(89, 14)
        Me.lblStatusNFSe.TabIndex = 0
        Me.lblStatusNFSe.Text = "Status da NFS-e:"
        '
        'btnReenviarEmail
        '
        Me.btnReenviarEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReenviarEmail.Image = CType(resources.GetObject("btnReenviarEmail.Image"), System.Drawing.Image)
        Me.btnReenviarEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnReenviarEmail.Location = New System.Drawing.Point(720, 200)
        Me.btnReenviarEmail.Name = "btnReenviarEmail"
        Me.btnReenviarEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnReenviarEmail.Size = New System.Drawing.Size(150, 23)
        Me.btnReenviarEmail.TabIndex = 15
        Me.btnReenviarEmail.Text = "Reenviar NFS-e"
        Me.btnReenviarEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnRetornarNFSE
        '
        Me.btnRetornarNFSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRetornarNFSE.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnRetornarNFSE.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRetornarNFSE.Location = New System.Drawing.Point(720, 142)
        Me.btnRetornarNFSE.Name = "btnRetornarNFSE"
        Me.btnRetornarNFSE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRetornarNFSE.Size = New System.Drawing.Size(150, 23)
        Me.btnRetornarNFSE.TabIndex = 12
        Me.btnRetornarNFSE.Text = "Retornar NFS-e"
        Me.btnRetornarNFSE.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnTransmitirNFSE
        '
        Me.btnTransmitirNFSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransmitirNFSE.Image = Global.INTERACTI.My.Resources.Resources.upload
        Me.btnTransmitirNFSE.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnTransmitirNFSE.Location = New System.Drawing.Point(720, 113)
        Me.btnTransmitirNFSE.Name = "btnTransmitirNFSE"
        Me.btnTransmitirNFSE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnTransmitirNFSE.Size = New System.Drawing.Size(150, 23)
        Me.btnTransmitirNFSE.TabIndex = 11
        Me.btnTransmitirNFSE.Text = "Transmitir NFS-e"
        Me.btnTransmitirNFSE.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnNovo)
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Controls.Add(Me.btnSalvar)
        Me.grpControle2.Controls.Add(Me.btnImportarPedido)
        Me.grpControle2.Location = New System.Drawing.Point(8, 483)
        Me.grpControle2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(897, 51)
        Me.grpControle2.TabIndex = 1
        Me.grpControle2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControle2.VisualStyleManager = Me.vsmMain
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
        Me.btnNovo.TabIndex = 0
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
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImportarPedido
        '
        Me.btnImportarPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarPedido.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportarPedido.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarPedido.Location = New System.Drawing.Point(397, 17)
        Me.btnImportarPedido.Name = "btnImportarPedido"
        Me.btnImportarPedido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarPedido.Size = New System.Drawing.Size(200, 23)
        Me.btnImportarPedido.TabIndex = 3
        Me.btnImportarPedido.Text = "Importar Pedido de Venda"
        Me.btnImportarPedido.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'btnTransmissaoLote
        '
        Me.btnTransmissaoLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTransmissaoLote.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnTransmissaoLote.Location = New System.Drawing.Point(6, 17)
        Me.btnTransmissaoLote.Name = "btnTransmissaoLote"
        Me.btnTransmissaoLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnTransmissaoLote.Size = New System.Drawing.Size(93, 23)
        Me.btnTransmissaoLote.TabIndex = 15
        Me.btnTransmissaoLote.Text = "Transmitir Lote"
        Me.btnTransmissaoLote.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFatEmissaoNFs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrFatEmissaoNFs"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaRejeitada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pigAguardandoRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAguardandoTransmissao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDadosNFs.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grpEnderecoTomador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEnderecoTomador.ResumeLayout(False)
        Me.grpEnderecoTomador.PerformLayout()
        CType(Me.grpIdentificacaoTomador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIdentificacaoTomador.ResumeLayout(False)
        Me.grpIdentificacaoTomador.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpEnderecoEmitente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEnderecoEmitente.ResumeLayout(False)
        Me.grpEnderecoEmitente.PerformLayout()
        CType(Me.grpDadosEmitente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosEmitente.ResumeLayout(False)
        Me.grpDadosEmitente.PerformLayout()
        Me.pagServico.ResumeLayout(False)
        CType(Me.grpClassificacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClassificacao.ResumeLayout(False)
        Me.grpClassificacao.PerformLayout()
        CType(Me.grpValores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValores.ResumeLayout(False)
        Me.grpValores.PerformLayout()
        CType(Me.grpServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServico.ResumeLayout(False)
        Me.grpServico.PerformLayout()
        Me.pagCobranca.ResumeLayout(False)
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDuplicata.ResumeLayout(False)
        Me.grpDuplicata.PerformLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFatura.ResumeLayout(False)
        Me.grpFatura.PerformLayout()
        Me.pagNFSe.ResumeLayout(False)
        CType(Me.grpNFSe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNFSe.ResumeLayout(False)
        Me.grpNFSe.PerformLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDadosNFs As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTomadorFiltro As System.Windows.Forms.Label
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
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents pagServico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagCobranca As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFatura As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorLiquido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorLiquido As System.Windows.Forms.Label
    Friend WithEvents txtValorDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDesconto As System.Windows.Forms.Label
    Friend WithEvents txtValorOriginal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOriginal As System.Windows.Forms.Label
    Friend WithEvents txtFatura As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFatura As System.Windows.Forms.Label
    Friend WithEvents txtTomadorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpDuplicata As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCalcularDuplicata As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtIntervaloEntreParcelas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloEntreParcelas As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroParcela As System.Windows.Forms.Label
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdDuplicata As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnImportarPedido As Janus.Windows.EditControls.UIButton
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
    Friend WithEvents cboTipoRPS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoRPS As System.Windows.Forms.Label
    Friend WithEvents cboSerie As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents grpValores As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorISS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorISS As System.Windows.Forms.Label
    Friend WithEvents txtValorISSRetido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorISSRetido As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculo As System.Windows.Forms.Label
    Friend WithEvents txtOutrasRetencoes As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblOutrasRetencoes As System.Windows.Forms.Label
    Friend WithEvents txtValorCSLL As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCSLL As System.Windows.Forms.Label
    Friend WithEvents txtValorIR As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorIR As System.Windows.Forms.Label
    Friend WithEvents txtValorINSS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorINSS As System.Windows.Forms.Label
    Friend WithEvents txtValorCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtValorPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorPIS As System.Windows.Forms.Label
    Friend WithEvents txtValorDeducoes As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDeducoes As System.Windows.Forms.Label
    Friend WithEvents grpServico As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarServico As System.Windows.Forms.Button
    Friend WithEvents cboServico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblServico As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents cboISSRetido As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblISSRetido As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaISS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaISS As System.Windows.Forms.Label
    Friend WithEvents txtValorDescontoIncondicionado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDescontoIncondicionado As System.Windows.Forms.Label
    Friend WithEvents txtValorDescontoCondicionado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDescontoCondicionado As System.Windows.Forms.Label
    Friend WithEvents txtValorServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorServico As System.Windows.Forms.Label
    Friend WithEvents txtValorLiquidoNFSE As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorLiquidoNFSE As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaINSS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaINSS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPIS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIR As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIR As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCSLL As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCSLL As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents cboModelo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagNFSe As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpNFSe As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCodigoVerificacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoVerificacao As System.Windows.Forms.Label
    Friend WithEvents lblAmbiente As System.Windows.Forms.Label
    Friend WithEvents txtProtocolo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProtocolo As System.Windows.Forms.Label
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents txtMensagemNFSe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMensagemNFSe As System.Windows.Forms.Label
    Friend WithEvents txtStatusNFSe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblStatusNFSe As System.Windows.Forms.Label
    Friend WithEvents btnReenviarEmail As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnRetornarNFSE As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnTransmitirNFSE As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroRPS As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRPS As System.Windows.Forms.Label
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnCadastrarServico As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaAutozidadaParaUso As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelada As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaRejeitada As System.Windows.Forms.Label
    Friend WithEvents picLegendaRejeitada As System.Windows.Forms.PictureBox
    Friend WithEvents lblAguardandoRetorno As System.Windows.Forms.Label
    Friend WithEvents pigAguardandoRetorno As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAguardandoTransmissao As System.Windows.Forms.Label
    Friend WithEvents picLegendaAguardandoTransmissao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAutozidadaParaUso As System.Windows.Forms.Label
    Friend WithEvents btnImprimirNFSe As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents grpEnderecoTomador As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtTelefoneTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefoneTomador As System.Windows.Forms.Label
    Friend WithEvents txtEmailTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEmailTomador As System.Windows.Forms.Label
    Friend WithEvents cboMunicipioTomador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairroTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPaisTomador As System.Windows.Forms.Label
    Friend WithEvents cboPaisTomador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCEPTomador As System.Windows.Forms.Label
    Friend WithEvents txtCEPTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplementoTomador As System.Windows.Forms.Label
    Friend WithEvents lblUFTomador As System.Windows.Forms.Label
    Friend WithEvents cboUFTomador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipioTomador As System.Windows.Forms.Label
    Friend WithEvents lblBairroTomador As System.Windows.Forms.Label
    Friend WithEvents lblNumeroTomador As System.Windows.Forms.Label
    Friend WithEvents lblLogradouroTomador As System.Windows.Forms.Label
    Friend WithEvents txtLogradouroTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarCEPTomador As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarPaisTomador As System.Windows.Forms.Button
    Friend WithEvents grpIdentificacaoTomador As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarTomador As System.Windows.Forms.Button
    Friend WithEvents txtCNPJTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtInscricaoMunicipalTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoMunicipalTomador As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoEstadualTomador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadualTomador As System.Windows.Forms.Label
    Friend WithEvents lblCNPJTomador As System.Windows.Forms.Label
    Friend WithEvents lblTomador As System.Windows.Forms.Label
    Friend WithEvents cboTomador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarTomador As System.Windows.Forms.Button
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboNaturezaOperacaoServicoFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblNaturezaOperacaoServicoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoRPSFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblTipoRPSFiltro As System.Windows.Forms.Label
    Friend WithEvents grpClassificacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboMunicipioTributacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipioTributacao As System.Windows.Forms.Label
    Friend WithEvents cboUFTributacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUFTributacao As System.Windows.Forms.Label
    Friend WithEvents cboNaturezaOperacaoServico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNaturezaOperacaoServico As System.Windows.Forms.Label
    Friend WithEvents btnCalcularINSS As System.Windows.Forms.Button
    Friend WithEvents btnCalcularCOFINS As System.Windows.Forms.Button
    Friend WithEvents btnCalcularPIS As System.Windows.Forms.Button
    Friend WithEvents btnCalcularCSLL As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnTransmissaoLote As Janus.Windows.EditControls.UIButton

End Class
