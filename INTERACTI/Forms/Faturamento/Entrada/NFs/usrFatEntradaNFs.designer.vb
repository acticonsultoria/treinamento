<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEntradaNFs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEntradaNFs))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboTipoNotaFiscalFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdServico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdServico_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdDuplicata_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdClassificacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdClassificacao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
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
        Me.lblLegendaAutozidadaParaUso = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPedidoCompraFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPedidoCompraFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEntradaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEntradaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntradaFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtPrestadorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.lblPrestadorFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.cboTipoNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblTipoNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosNFs = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosNFse = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConsultarNFSe = New Janus.Windows.EditControls.UIButton()
        Me.txtCodigoVerificacaoNFSe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoVerificacaoNFSe = New System.Windows.Forms.Label()
        Me.grpDadosNF = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataEntrada = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntrada = New System.Windows.Forms.Label()
        Me.dtpDataEmissao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.grpEnderecoPrestador = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTelefonePrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtEmailPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmailPrestador = New System.Windows.Forms.Label()
        Me.cboMunicipioPrestador = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplementoPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairroPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPaisPrestador = New System.Windows.Forms.Label()
        Me.cboPaisPrestador = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCEPPrestador = New System.Windows.Forms.Label()
        Me.txtCEPPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplementoPrestador = New System.Windows.Forms.Label()
        Me.lblUFPrestador = New System.Windows.Forms.Label()
        Me.cboUFPrestador = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipioPrestador = New System.Windows.Forms.Label()
        Me.lblBairroPrestador = New System.Windows.Forms.Label()
        Me.lblNumeroPrestador = New System.Windows.Forms.Label()
        Me.lblLogradouroPrestador = New System.Windows.Forms.Label()
        Me.txtLogradouroPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnProcurarCEPPrestador = New System.Windows.Forms.Button()
        Me.btnCadastrarPaisPrestador = New System.Windows.Forms.Button()
        Me.lblTelefonePrestador = New System.Windows.Forms.Label()
        Me.grpIdentificacaoPrestador = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarPrestador = New System.Windows.Forms.Button()
        Me.txtCNPJPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtInscricaoMunicipalPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoMunicipalPrestador = New System.Windows.Forms.Label()
        Me.txtInscricaoEstadualPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadualPrestador = New System.Windows.Forms.Label()
        Me.lblCNPJPrestador = New System.Windows.Forms.Label()
        Me.lblPrestador = New System.Windows.Forms.Label()
        Me.cboPrestador = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarPrestador = New System.Windows.Forms.Button()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoNotaFiscal = New System.Windows.Forms.Label()
        Me.cboTipoNotaFiscal = New Janus.Windows.EditControls.UIComboBox()
        Me.grpEnderecoTomador = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblValorUFTomador = New System.Windows.Forms.Label()
        Me.lblValorPaisTomador = New System.Windows.Forms.Label()
        Me.lblValorCEPEmiente = New System.Windows.Forms.Label()
        Me.lblValorMunicipioTomador = New System.Windows.Forms.Label()
        Me.lblValorBairroTomador = New System.Windows.Forms.Label()
        Me.lblValorComplementoTomador = New System.Windows.Forms.Label()
        Me.lblValorNumeroTomador = New System.Windows.Forms.Label()
        Me.lblValorLogradouroTomador = New System.Windows.Forms.Label()
        Me.lblPaisTomador = New System.Windows.Forms.Label()
        Me.lblCEPEmiente = New System.Windows.Forms.Label()
        Me.lblUFTomador = New System.Windows.Forms.Label()
        Me.lblMunicipioTomador = New System.Windows.Forms.Label()
        Me.lblBairroTomador = New System.Windows.Forms.Label()
        Me.lblComplementoTomador = New System.Windows.Forms.Label()
        Me.lblNumeroTomador = New System.Windows.Forms.Label()
        Me.lblLogradouroTomador = New System.Windows.Forms.Label()
        Me.grpDadosTomador = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblValorRegimeTributarioTomador = New System.Windows.Forms.Label()
        Me.lblValorInscricaoEstadualTomador = New System.Windows.Forms.Label()
        Me.lblValorInscricaoMunicipalTomador = New System.Windows.Forms.Label()
        Me.lblValorNomeFantasiaTomador = New System.Windows.Forms.Label()
        Me.lblRegimeTributarioTomador = New System.Windows.Forms.Label()
        Me.lblInscricaoMunicipalTomador = New System.Windows.Forms.Label()
        Me.lblInscricaoEstadualTomador = New System.Windows.Forms.Label()
        Me.lblNomeFantasiaTomador = New System.Windows.Forms.Label()
        Me.lblValorRazaoSocialTomador = New System.Windows.Forms.Label()
        Me.lblRazaoSocialTomador = New System.Windows.Forms.Label()
        Me.lblValorCNPJTomador = New System.Windows.Forms.Label()
        Me.lblCNPJTomador = New System.Windows.Forms.Label()
        Me.pagServico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdServico = New Janus.Windows.GridEX.GridEX()
        Me.grpServico = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirServico = New Janus.Windows.EditControls.UIButton()
        Me.txtValorISS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnInserirServico = New Janus.Windows.EditControls.UIButton()
        Me.btnCalcularCSLL = New System.Windows.Forms.Button()
        Me.lblValorISS = New System.Windows.Forms.Label()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.txtValorISSRetido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorISSRetido = New System.Windows.Forms.Label()
        Me.btnCalcularINSS = New System.Windows.Forms.Button()
        Me.txtValorCSLL = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorServicoUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCSLL = New System.Windows.Forms.Label()
        Me.btnCalcularCOFINS = New System.Windows.Forms.Button()
        Me.txtValorIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.lblValorIR = New System.Windows.Forms.Label()
        Me.btnCalcularPIS = New System.Windows.Forms.Button()
        Me.txtValorINSS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorServicoUnitario = New System.Windows.Forms.Label()
        Me.lblValorINSS = New System.Windows.Forms.Label()
        Me.txtAliquotaIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCOFINS = New System.Windows.Forms.Label()
        Me.lblAliquotaIR = New System.Windows.Forms.Label()
        Me.txtValorPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.lblValorPIS = New System.Windows.Forms.Label()
        Me.txtAliquotaCSLL = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCSLL = New System.Windows.Forms.Label()
        Me.txtAliquotaINSS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.lblAliquotaINSS = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtAliquotaCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAliquotaCOFINS = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.txtAliquotaPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblAliquotaPIS = New System.Windows.Forms.Label()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboISSRetido = New Janus.Windows.EditControls.UIComboBox()
        Me.lblISSRetido = New System.Windows.Forms.Label()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.btnCadastrarServico = New System.Windows.Forms.Button()
        Me.txtValorLiquidoNFSE = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorLiquidoNFSE = New System.Windows.Forms.Label()
        Me.txtValorDescontoIncondicionado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtAliquotaISS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDescontoIncondicionado = New System.Windows.Forms.Label()
        Me.lblAliquotaISS = New System.Windows.Forms.Label()
        Me.txtValorDescontoCondicionado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtBaseCalculo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDescontoCondicionado = New System.Windows.Forms.Label()
        Me.lblBaseCalculo = New System.Windows.Forms.Label()
        Me.txtValorServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtOutrasRetencoes = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblOutrasRetencoes = New System.Windows.Forms.Label()
        Me.lblValorServico = New System.Windows.Forms.Label()
        Me.btnProcurarServico = New System.Windows.Forms.Button()
        Me.cboServico = New Janus.Windows.EditControls.UIComboBox()
        Me.lblServico = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblValorDeducoes = New System.Windows.Forms.Label()
        Me.txtValorDeducoes = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.pagCobranca = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpTituloPrevisto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroParcelaTituloPrevisto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroParcelaTituloPrevisto = New System.Windows.Forms.Label()
        Me.btnVincular = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataVencimentoPrevisto = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumDocumentoPrevisto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTituloPrevisto = New System.Windows.Forms.Label()
        Me.txtValorPrevisto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboTituloPrevisto = New Janus.Windows.EditControls.UIComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.pagDadosDespesa = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosDespesa = New Janus.Windows.EditControls.UIGroupBox()
        Me.grpClassificao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCentroGastoDespesa = New System.Windows.Forms.Button()
        Me.btnProcurarContaContabilDespesa = New System.Windows.Forms.Button()
        Me.txtValorClassificacao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorClassificacao = New System.Windows.Forms.Label()
        Me.lblContaContabilDespesa = New System.Windows.Forms.Label()
        Me.cboContaContabilDespesa = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGastoDespesa = New System.Windows.Forms.Label()
        Me.cboCentroGastoDespesa = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcluirClassificacao = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirClassificao = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarContaContabilDespesa = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGastoDespesa = New System.Windows.Forms.Button()
        Me.txtDescritivoDespesa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.grdClassificacao = New Janus.Windows.GridEX.GridEX()
        Me.lblDescritivoDespesa = New System.Windows.Forms.Label()
        Me.lblTipoDocumentoPagamento = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
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
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkCalculoImpostoManual = New Janus.Windows.EditControls.UICheckBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDadosNFs.SuspendLayout()
        CType(Me.grpDadosNFse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosNFse.SuspendLayout()
        CType(Me.grpDadosNF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosNF.SuspendLayout()
        CType(Me.grpEnderecoPrestador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnderecoPrestador.SuspendLayout()
        CType(Me.grpIdentificacaoPrestador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIdentificacaoPrestador.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpEnderecoTomador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnderecoTomador.SuspendLayout()
        CType(Me.grpDadosTomador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosTomador.SuspendLayout()
        Me.pagServico.SuspendLayout()
        CType(Me.grdServico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServico.SuspendLayout()
        Me.pagCobranca.SuspendLayout()
        CType(Me.grpTituloPrevisto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTituloPrevisto.SuspendLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDuplicata.SuspendLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFatura.SuspendLayout()
        Me.pagDadosDespesa.SuspendLayout()
        CType(Me.grpDadosDespesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosDespesa.SuspendLayout()
        CType(Me.grpClassificao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClassificao.SuspendLayout()
        CType(Me.grdClassificacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagLista.Text = "Lista de Nota Fiscal"
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
        Me.btnExcelGrid.TabIndex = 7
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
        Me.btnAgruparGrid.TabIndex = 6
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
        Me.btnConfigurarGrid.TabIndex = 5
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
        Me.grpLegenda.Controls.Add(Me.lblLegendaAutozidadaParaUso)
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(234, 51)
        Me.grpLegenda.TabIndex = 3
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaAutozidadaParaUso
        '
        Me.picLegendaAutozidadaParaUso.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaAutozidadaParaUso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAutozidadaParaUso.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaAutozidadaParaUso.Name = "picLegendaAutozidadaParaUso"
        Me.picLegendaAutozidadaParaUso.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAutozidadaParaUso.TabIndex = 16
        Me.picLegendaAutozidadaParaUso.TabStop = False
        '
        'lblLegendaCancelada
        '
        Me.lblLegendaCancelada.AutoSize = True
        Me.lblLegendaCancelada.Location = New System.Drawing.Point(172, 21)
        Me.lblLegendaCancelada.Name = "lblLegendaCancelada"
        Me.lblLegendaCancelada.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelada.TabIndex = 1
        Me.lblLegendaCancelada.Text = "Cancelada"
        '
        'picLegendaCancelada
        '
        Me.picLegendaCancelada.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelada.Location = New System.Drawing.Point(153, 21)
        Me.picLegendaCancelada.Name = "picLegendaCancelada"
        Me.picLegendaCancelada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelada.TabIndex = 14
        Me.picLegendaCancelada.TabStop = False
        '
        'lblLegendaAutozidadaParaUso
        '
        Me.lblLegendaAutozidadaParaUso.AutoSize = True
        Me.lblLegendaAutozidadaParaUso.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaAutozidadaParaUso.Name = "lblLegendaAutozidadaParaUso"
        Me.lblLegendaAutozidadaParaUso.Size = New System.Drawing.Size(119, 14)
        Me.lblLegendaAutozidadaParaUso.TabIndex = 0
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
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(251, 483)
        Me.grpControle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(654, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(360, 17)
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
        Me.btnExcluir.Location = New System.Drawing.Point(457, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(554, 17)
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
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.[Default]
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
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
        Me.grpFiltro.Controls.Add(Me.txtPedidoCompraFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPedidoCompraFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEntradaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtPrestadorFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPrestadorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoNotaFiscalFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtPedidoCompraFiltro
        '
        Me.txtPedidoCompraFiltro.IncludeLiterals = False
        Me.txtPedidoCompraFiltro.Location = New System.Drawing.Point(185, 34)
        Me.txtPedidoCompraFiltro.MaxLength = 9
        Me.txtPedidoCompraFiltro.Name = "txtPedidoCompraFiltro"
        Me.txtPedidoCompraFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPedidoCompraFiltro.Size = New System.Drawing.Size(104, 20)
        Me.txtPedidoCompraFiltro.TabIndex = 5
        '
        'lblPedidoCompraFiltro
        '
        Me.lblPedidoCompraFiltro.AutoSize = True
        Me.lblPedidoCompraFiltro.Location = New System.Drawing.Point(182, 17)
        Me.lblPedidoCompraFiltro.Name = "lblPedidoCompraFiltro"
        Me.lblPedidoCompraFiltro.Size = New System.Drawing.Size(82, 14)
        Me.lblPedidoCompraFiltro.TabIndex = 4
        Me.lblPedidoCompraFiltro.Text = "Pedido Compra:"
        '
        'dtpDataEntradaInicioFiltro
        '
        Me.dtpDataEntradaInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEntradaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntradaInicioFiltro.Location = New System.Drawing.Point(552, 74)
        Me.dtpDataEntradaInicioFiltro.Name = "dtpDataEntradaInicioFiltro"
        Me.dtpDataEntradaInicioFiltro.ShowCheckBox = True
        Me.dtpDataEntradaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntradaInicioFiltro.TabIndex = 16
        Me.dtpDataEntradaInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEntradaTerminoFiltro
        '
        Me.dtpDataEntradaTerminoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEntradaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntradaTerminoFiltro.Location = New System.Drawing.Point(666, 74)
        Me.dtpDataEntradaTerminoFiltro.Name = "dtpDataEntradaTerminoFiltro"
        Me.dtpDataEntradaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEntradaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntradaTerminoFiltro.TabIndex = 17
        Me.dtpDataEntradaTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntradaFiltro
        '
        Me.lblDataEntradaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEntradaFiltro.AutoSize = True
        Me.lblDataEntradaFiltro.Location = New System.Drawing.Point(549, 57)
        Me.lblDataEntradaFiltro.Name = "lblDataEntradaFiltro"
        Me.lblDataEntradaFiltro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaFiltro.TabIndex = 15
        Me.lblDataEntradaFiltro.Text = "Data Entrada:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(185, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(361, 20)
        Me.cboStatusFiltro.TabIndex = 14
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(182, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 13
        Me.lblStatusFiltro.Text = "Status:"
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
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 10
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
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 9
        '
        'txtPrestadorFiltro
        '
        Me.txtPrestadorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrestadorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrestadorFiltro.Location = New System.Drawing.Point(295, 34)
        Me.txtPrestadorFiltro.MaxLength = 60
        Me.txtPrestadorFiltro.Name = "txtPrestadorFiltro"
        Me.txtPrestadorFiltro.Size = New System.Drawing.Size(251, 20)
        Me.txtPrestadorFiltro.TabIndex = 7
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
        Me.btnFiltrar.TabIndex = 18
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(549, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 8
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'lblPrestadorFiltro
        '
        Me.lblPrestadorFiltro.AutoSize = True
        Me.lblPrestadorFiltro.Location = New System.Drawing.Point(292, 17)
        Me.lblPrestadorFiltro.Name = "lblPrestadorFiltro"
        Me.lblPrestadorFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblPrestadorFiltro.TabIndex = 6
        Me.lblPrestadorFiltro.Text = "Prestador:"
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
        'cboTipoNotaFiscalFiltro
        '
        Me.cboTipoNotaFiscalFiltro.AllowDrop = True
        Me.cboTipoNotaFiscalFiltro.ButtonCancelText = "Cancelar"
        Me.cboTipoNotaFiscalFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboTipoNotaFiscalFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboTipoNotaFiscalFiltro_DesignTimeLayout.LayoutString")
        Me.cboTipoNotaFiscalFiltro.DesignTimeLayout = cboTipoNotaFiscalFiltro_DesignTimeLayout
        Me.cboTipoNotaFiscalFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboTipoNotaFiscalFiltro.Name = "cboTipoNotaFiscalFiltro"
        Me.cboTipoNotaFiscalFiltro.SaveSettings = False
        Me.cboTipoNotaFiscalFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboTipoNotaFiscalFiltro.Size = New System.Drawing.Size(170, 20)
        Me.cboTipoNotaFiscalFiltro.TabIndex = 12
        Me.cboTipoNotaFiscalFiltro.ValuesDataMember = Nothing
        '
        'lblTipoNotaFiscalFiltro
        '
        Me.lblTipoNotaFiscalFiltro.AutoSize = True
        Me.lblTipoNotaFiscalFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblTipoNotaFiscalFiltro.Name = "lblTipoNotaFiscalFiltro"
        Me.lblTipoNotaFiscalFiltro.Size = New System.Drawing.Size(101, 14)
        Me.lblTipoNotaFiscalFiltro.TabIndex = 11
        Me.lblTipoNotaFiscalFiltro.Text = "Tipo de Nota Fiscal:"
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
        Me.tabDados.Size = New System.Drawing.Size(897, 473)
        Me.tabDados.TabIndex = 0
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosNFs, Me.pagServico, Me.pagCobranca, Me.pagDadosDespesa, Me.pagArquivo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDadosNFs
        '
        Me.pagDadosNFs.Controls.Add(Me.grpDadosNFse)
        Me.pagDadosNFs.Controls.Add(Me.grpDadosNF)
        Me.pagDadosNFs.Controls.Add(Me.grpEnderecoPrestador)
        Me.pagDadosNFs.Controls.Add(Me.grpIdentificacaoPrestador)
        Me.pagDadosNFs.Controls.Add(Me.grpDados)
        Me.pagDadosNFs.Controls.Add(Me.grpEnderecoTomador)
        Me.pagDadosNFs.Controls.Add(Me.grpDadosTomador)
        Me.pagDadosNFs.Key = "pagDadosNFe"
        Me.pagDadosNFs.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosNFs.Name = "pagDadosNFs"
        Me.pagDadosNFs.Size = New System.Drawing.Size(895, 450)
        Me.pagDadosNFs.TabStop = True
        Me.pagDadosNFs.Text = "Dados da Nota Fiscal"
        '
        'grpDadosNFse
        '
        Me.grpDadosNFse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosNFse.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosNFse.Controls.Add(Me.btnConsultarNFSe)
        Me.grpDadosNFse.Controls.Add(Me.txtCodigoVerificacaoNFSe)
        Me.grpDadosNFse.Controls.Add(Me.lblCodigoVerificacaoNFSe)
        Me.grpDadosNFse.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosNFse.Location = New System.Drawing.Point(669, 4)
        Me.grpDadosNFse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosNFse.Name = "grpDadosNFse"
        Me.grpDadosNFse.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosNFse.Size = New System.Drawing.Size(218, 67)
        Me.grpDadosNFse.TabIndex = 2
        Me.grpDadosNFse.Text = "Dados da Nota Fiscal Eletrônica"
        Me.grpDadosNFse.VisualStyleManager = Me.vsmMain
        '
        'btnConsultarNFSe
        '
        Me.btnConsultarNFSe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConsultarNFSe.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnConsultarNFSe.Location = New System.Drawing.Point(189, 36)
        Me.btnConsultarNFSe.Name = "btnConsultarNFSe"
        Me.btnConsultarNFSe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConsultarNFSe.Size = New System.Drawing.Size(20, 20)
        Me.btnConsultarNFSe.TabIndex = 3
        Me.btnConsultarNFSe.Text = "..."
        Me.btnConsultarNFSe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtCodigoVerificacaoNFSe
        '
        Me.txtCodigoVerificacaoNFSe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoVerificacaoNFSe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoVerificacaoNFSe.Location = New System.Drawing.Point(9, 36)
        Me.txtCodigoVerificacaoNFSe.MaxLength = 9
        Me.txtCodigoVerificacaoNFSe.Name = "txtCodigoVerificacaoNFSe"
        Me.txtCodigoVerificacaoNFSe.Size = New System.Drawing.Size(181, 20)
        Me.txtCodigoVerificacaoNFSe.TabIndex = 1
        Me.txtCodigoVerificacaoNFSe.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblCodigoVerificacaoNFSe
        '
        Me.lblCodigoVerificacaoNFSe.AutoSize = True
        Me.lblCodigoVerificacaoNFSe.Location = New System.Drawing.Point(6, 19)
        Me.lblCodigoVerificacaoNFSe.Name = "lblCodigoVerificacaoNFSe"
        Me.lblCodigoVerificacaoNFSe.Size = New System.Drawing.Size(101, 14)
        Me.lblCodigoVerificacaoNFSe.TabIndex = 0
        Me.lblCodigoVerificacaoNFSe.Text = "Código Verificação:"
        '
        'grpDadosNF
        '
        Me.grpDadosNF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosNF.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosNF.Controls.Add(Me.txtSerie)
        Me.grpDadosNF.Controls.Add(Me.dtpDataEntrada)
        Me.grpDadosNF.Controls.Add(Me.lblDataEntrada)
        Me.grpDadosNF.Controls.Add(Me.dtpDataEmissao)
        Me.grpDadosNF.Controls.Add(Me.lblDataEmissao)
        Me.grpDadosNF.Controls.Add(Me.lblSerie)
        Me.grpDadosNF.Controls.Add(Me.txtNotaFiscal)
        Me.grpDadosNF.Controls.Add(Me.lblNotaFiscal)
        Me.grpDadosNF.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosNF.Location = New System.Drawing.Point(237, 4)
        Me.grpDadosNF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosNF.Name = "grpDadosNF"
        Me.grpDadosNF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosNF.Size = New System.Drawing.Size(423, 67)
        Me.grpDadosNF.TabIndex = 1
        Me.grpDadosNF.Text = "Dados da Nota Fiscal"
        Me.grpDadosNF.VisualStyleManager = Me.vsmMain
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(119, 36)
        Me.txtSerie.MaxLength = 5
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(60, 20)
        Me.txtSerie.TabIndex = 3
        Me.txtSerie.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'dtpDataEntrada
        '
        '
        '
        '
        Me.dtpDataEntrada.DropDownCalendar.Name = ""
        Me.dtpDataEntrada.Location = New System.Drawing.Point(295, 36)
        Me.dtpDataEntrada.Name = "dtpDataEntrada"
        Me.dtpDataEntrada.Size = New System.Drawing.Size(119, 20)
        Me.dtpDataEntrada.TabIndex = 7
        '
        'lblDataEntrada
        '
        Me.lblDataEntrada.AutoSize = True
        Me.lblDataEntrada.Location = New System.Drawing.Point(292, 19)
        Me.lblDataEntrada.Name = "lblDataEntrada"
        Me.lblDataEntrada.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntrada.TabIndex = 6
        Me.lblDataEntrada.Text = "Data Entrada:"
        '
        'dtpDataEmissao
        '
        '
        '
        '
        Me.dtpDataEmissao.DropDownCalendar.Name = ""
        Me.dtpDataEmissao.Location = New System.Drawing.Point(185, 36)
        Me.dtpDataEmissao.Name = "dtpDataEmissao"
        Me.dtpDataEmissao.Size = New System.Drawing.Size(104, 20)
        Me.dtpDataEmissao.TabIndex = 5
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(182, 19)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 4
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(116, 19)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Série:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaFiscal.Location = New System.Drawing.Point(9, 36)
        Me.txtNotaFiscal.MaxLength = 20
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(104, 20)
        Me.txtNotaFiscal.TabIndex = 0
        Me.txtNotaFiscal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(6, 19)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(47, 14)
        Me.lblNotaFiscal.TabIndex = 1
        Me.lblNotaFiscal.Text = "Número:"
        '
        'grpEnderecoPrestador
        '
        Me.grpEnderecoPrestador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEnderecoPrestador.BackColor = System.Drawing.Color.Transparent
        Me.grpEnderecoPrestador.Controls.Add(Me.txtTelefonePrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.txtEmailPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblEmailPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.cboMunicipioPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.txtNumeroPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.txtComplementoPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.txtBairroPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblPaisPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.cboPaisPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblCEPPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.txtCEPPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblComplementoPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblUFPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.cboUFPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblMunicipioPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblBairroPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblNumeroPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblLogradouroPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.txtLogradouroPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.btnProcurarCEPPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.btnCadastrarPaisPrestador)
        Me.grpEnderecoPrestador.Controls.Add(Me.lblTelefonePrestador)
        Me.grpEnderecoPrestador.Location = New System.Drawing.Point(8, 337)
        Me.grpEnderecoPrestador.Name = "grpEnderecoPrestador"
        Me.grpEnderecoPrestador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEnderecoPrestador.Size = New System.Drawing.Size(879, 104)
        Me.grpEnderecoPrestador.TabIndex = 6
        Me.grpEnderecoPrestador.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEnderecoPrestador.VisualStyleManager = Me.vsmMain
        '
        'txtTelefonePrestador
        '
        Me.txtTelefonePrestador.Location = New System.Drawing.Point(534, 74)
        Me.txtTelefonePrestador.Mask = "!(##) 0000-0000"
        Me.txtTelefonePrestador.MaxLength = 10
        Me.txtTelefonePrestador.Name = "txtTelefonePrestador"
        Me.txtTelefonePrestador.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefonePrestador.TabIndex = 19
        '
        'txtEmailPrestador
        '
        Me.txtEmailPrestador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmailPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailPrestador.Enabled = False
        Me.txtEmailPrestador.Location = New System.Drawing.Point(648, 74)
        Me.txtEmailPrestador.MaxLength = 60
        Me.txtEmailPrestador.Name = "txtEmailPrestador"
        Me.txtEmailPrestador.Size = New System.Drawing.Size(222, 20)
        Me.txtEmailPrestador.TabIndex = 21
        '
        'lblEmailPrestador
        '
        Me.lblEmailPrestador.AutoSize = True
        Me.lblEmailPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmailPrestador.Location = New System.Drawing.Point(645, 57)
        Me.lblEmailPrestador.Name = "lblEmailPrestador"
        Me.lblEmailPrestador.Size = New System.Drawing.Size(38, 14)
        Me.lblEmailPrestador.TabIndex = 20
        Me.lblEmailPrestador.Text = "E-mail:"
        '
        'cboMunicipioPrestador
        '
        Me.cboMunicipioPrestador.AutoSize = False
        Me.cboMunicipioPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipioPrestador.Enabled = False
        Me.cboMunicipioPrestador.Location = New System.Drawing.Point(311, 34)
        Me.cboMunicipioPrestador.Name = "cboMunicipioPrestador"
        Me.cboMunicipioPrestador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipioPrestador.Size = New System.Drawing.Size(217, 20)
        Me.cboMunicipioPrestador.TabIndex = 9
        '
        'txtNumeroPrestador
        '
        Me.txtNumeroPrestador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPrestador.Enabled = False
        Me.txtNumeroPrestador.Location = New System.Drawing.Point(806, 34)
        Me.txtNumeroPrestador.MaxLength = 60
        Me.txtNumeroPrestador.Name = "txtNumeroPrestador"
        Me.txtNumeroPrestador.Size = New System.Drawing.Size(64, 20)
        Me.txtNumeroPrestador.TabIndex = 13
        '
        'txtComplementoPrestador
        '
        Me.txtComplementoPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoPrestador.Enabled = False
        Me.txtComplementoPrestador.Location = New System.Drawing.Point(311, 74)
        Me.txtComplementoPrestador.MaxLength = 60
        Me.txtComplementoPrestador.Name = "txtComplementoPrestador"
        Me.txtComplementoPrestador.Size = New System.Drawing.Size(217, 20)
        Me.txtComplementoPrestador.TabIndex = 17
        '
        'txtBairroPrestador
        '
        Me.txtBairroPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairroPrestador.Enabled = False
        Me.txtBairroPrestador.Location = New System.Drawing.Point(9, 74)
        Me.txtBairroPrestador.MaxLength = 60
        Me.txtBairroPrestador.Name = "txtBairroPrestador"
        Me.txtBairroPrestador.Size = New System.Drawing.Size(296, 20)
        Me.txtBairroPrestador.TabIndex = 15
        '
        'lblPaisPrestador
        '
        Me.lblPaisPrestador.AutoSize = True
        Me.lblPaisPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPaisPrestador.Location = New System.Drawing.Point(98, 17)
        Me.lblPaisPrestador.Name = "lblPaisPrestador"
        Me.lblPaisPrestador.Size = New System.Drawing.Size(30, 14)
        Me.lblPaisPrestador.TabIndex = 3
        Me.lblPaisPrestador.Text = "País:"
        '
        'cboPaisPrestador
        '
        Me.cboPaisPrestador.AutoSize = False
        Me.cboPaisPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPaisPrestador.Enabled = False
        Me.cboPaisPrestador.Location = New System.Drawing.Point(82, 34)
        Me.cboPaisPrestador.Name = "cboPaisPrestador"
        Me.cboPaisPrestador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPaisPrestador.Size = New System.Drawing.Size(159, 20)
        Me.cboPaisPrestador.TabIndex = 5
        '
        'lblCEPPrestador
        '
        Me.lblCEPPrestador.AutoSize = True
        Me.lblCEPPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCEPPrestador.Location = New System.Drawing.Point(6, 17)
        Me.lblCEPPrestador.Name = "lblCEPPrestador"
        Me.lblCEPPrestador.Size = New System.Drawing.Size(29, 14)
        Me.lblCEPPrestador.TabIndex = 0
        Me.lblCEPPrestador.Text = "CEP:"
        '
        'txtCEPPrestador
        '
        Me.txtCEPPrestador.Enabled = False
        Me.txtCEPPrestador.Location = New System.Drawing.Point(9, 34)
        Me.txtCEPPrestador.Mask = "00000-000"
        Me.txtCEPPrestador.MaxLength = 10
        Me.txtCEPPrestador.Name = "txtCEPPrestador"
        Me.txtCEPPrestador.Size = New System.Drawing.Size(67, 20)
        Me.txtCEPPrestador.TabIndex = 2
        '
        'lblComplementoPrestador
        '
        Me.lblComplementoPrestador.AutoSize = True
        Me.lblComplementoPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComplementoPrestador.Location = New System.Drawing.Point(308, 57)
        Me.lblComplementoPrestador.Name = "lblComplementoPrestador"
        Me.lblComplementoPrestador.Size = New System.Drawing.Size(74, 14)
        Me.lblComplementoPrestador.TabIndex = 16
        Me.lblComplementoPrestador.Text = "Complemento:"
        '
        'lblUFPrestador
        '
        Me.lblUFPrestador.AutoSize = True
        Me.lblUFPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFPrestador.Location = New System.Drawing.Point(244, 17)
        Me.lblUFPrestador.Name = "lblUFPrestador"
        Me.lblUFPrestador.Size = New System.Drawing.Size(23, 14)
        Me.lblUFPrestador.TabIndex = 6
        Me.lblUFPrestador.Text = "UF:"
        '
        'cboUFPrestador
        '
        Me.cboUFPrestador.AutoSize = False
        Me.cboUFPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFPrestador.Enabled = False
        Me.cboUFPrestador.Location = New System.Drawing.Point(247, 34)
        Me.cboUFPrestador.Name = "cboUFPrestador"
        Me.cboUFPrestador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFPrestador.Size = New System.Drawing.Size(58, 20)
        Me.cboUFPrestador.TabIndex = 7
        '
        'lblMunicipioPrestador
        '
        Me.lblMunicipioPrestador.AutoSize = True
        Me.lblMunicipioPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipioPrestador.Location = New System.Drawing.Point(308, 17)
        Me.lblMunicipioPrestador.Name = "lblMunicipioPrestador"
        Me.lblMunicipioPrestador.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipioPrestador.TabIndex = 8
        Me.lblMunicipioPrestador.Text = "Município:"
        '
        'lblBairroPrestador
        '
        Me.lblBairroPrestador.AutoSize = True
        Me.lblBairroPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBairroPrestador.Location = New System.Drawing.Point(6, 57)
        Me.lblBairroPrestador.Name = "lblBairroPrestador"
        Me.lblBairroPrestador.Size = New System.Drawing.Size(39, 14)
        Me.lblBairroPrestador.TabIndex = 14
        Me.lblBairroPrestador.Text = "Bairro:"
        '
        'lblNumeroPrestador
        '
        Me.lblNumeroPrestador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroPrestador.AutoSize = True
        Me.lblNumeroPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroPrestador.Location = New System.Drawing.Point(803, 17)
        Me.lblNumeroPrestador.Name = "lblNumeroPrestador"
        Me.lblNumeroPrestador.Size = New System.Drawing.Size(47, 14)
        Me.lblNumeroPrestador.TabIndex = 12
        Me.lblNumeroPrestador.Text = "Número:"
        '
        'lblLogradouroPrestador
        '
        Me.lblLogradouroPrestador.AutoSize = True
        Me.lblLogradouroPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLogradouroPrestador.Location = New System.Drawing.Point(531, 17)
        Me.lblLogradouroPrestador.Name = "lblLogradouroPrestador"
        Me.lblLogradouroPrestador.Size = New System.Drawing.Size(66, 14)
        Me.lblLogradouroPrestador.TabIndex = 10
        Me.lblLogradouroPrestador.Text = "Logradouro:"
        '
        'txtLogradouroPrestador
        '
        Me.txtLogradouroPrestador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogradouroPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouroPrestador.Enabled = False
        Me.txtLogradouroPrestador.Location = New System.Drawing.Point(534, 34)
        Me.txtLogradouroPrestador.MaxLength = 60
        Me.txtLogradouroPrestador.Name = "txtLogradouroPrestador"
        Me.txtLogradouroPrestador.Size = New System.Drawing.Size(266, 20)
        Me.txtLogradouroPrestador.TabIndex = 11
        '
        'btnProcurarCEPPrestador
        '
        Me.btnProcurarCEPPrestador.FlatAppearance.BorderSize = 0
        Me.btnProcurarCEPPrestador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCEPPrestador.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCEPPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCEPPrestador.Location = New System.Drawing.Point(59, 15)
        Me.btnProcurarCEPPrestador.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCEPPrestador.Name = "btnProcurarCEPPrestador"
        Me.btnProcurarCEPPrestador.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCEPPrestador.TabIndex = 1
        Me.btnProcurarCEPPrestador.TabStop = False
        Me.btnProcurarCEPPrestador.UseVisualStyleBackColor = True
        '
        'btnCadastrarPaisPrestador
        '
        Me.btnCadastrarPaisPrestador.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPaisPrestador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPaisPrestador.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarPaisPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarPaisPrestador.Location = New System.Drawing.Point(82, 18)
        Me.btnCadastrarPaisPrestador.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarPaisPrestador.Name = "btnCadastrarPaisPrestador"
        Me.btnCadastrarPaisPrestador.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarPaisPrestador.TabIndex = 4
        Me.btnCadastrarPaisPrestador.TabStop = False
        Me.btnCadastrarPaisPrestador.UseVisualStyleBackColor = True
        '
        'lblTelefonePrestador
        '
        Me.lblTelefonePrestador.AutoSize = True
        Me.lblTelefonePrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefonePrestador.Location = New System.Drawing.Point(531, 57)
        Me.lblTelefonePrestador.Name = "lblTelefonePrestador"
        Me.lblTelefonePrestador.Size = New System.Drawing.Size(51, 14)
        Me.lblTelefonePrestador.TabIndex = 18
        Me.lblTelefonePrestador.Text = "Telefone:"
        '
        'grpIdentificacaoPrestador
        '
        Me.grpIdentificacaoPrestador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpIdentificacaoPrestador.BackColor = System.Drawing.Color.Transparent
        Me.grpIdentificacaoPrestador.Controls.Add(Me.btnProcurarPrestador)
        Me.grpIdentificacaoPrestador.Controls.Add(Me.txtCNPJPrestador)
        Me.grpIdentificacaoPrestador.Controls.Add(Me.txtInscricaoMunicipalPrestador)
        Me.grpIdentificacaoPrestador.Controls.Add(Me.lblInscricaoMunicipalPrestador)
        Me.grpIdentificacaoPrestador.Controls.Add(Me.txtInscricaoEstadualPrestador)
        Me.grpIdentificacaoPrestador.Controls.Add(Me.lblInscricaoEstadualPrestador)
        Me.grpIdentificacaoPrestador.Controls.Add(Me.lblCNPJPrestador)
        Me.grpIdentificacaoPrestador.Controls.Add(Me.lblPrestador)
        Me.grpIdentificacaoPrestador.Controls.Add(Me.cboPrestador)
        Me.grpIdentificacaoPrestador.Controls.Add(Me.btnCadastrarPrestador)
        Me.grpIdentificacaoPrestador.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpIdentificacaoPrestador.Location = New System.Drawing.Point(8, 267)
        Me.grpIdentificacaoPrestador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpIdentificacaoPrestador.Name = "grpIdentificacaoPrestador"
        Me.grpIdentificacaoPrestador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpIdentificacaoPrestador.Size = New System.Drawing.Size(879, 67)
        Me.grpIdentificacaoPrestador.TabIndex = 5
        Me.grpIdentificacaoPrestador.Text = "Identificação Prestador"
        Me.grpIdentificacaoPrestador.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarPrestador
        '
        Me.btnProcurarPrestador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarPrestador.FlatAppearance.BorderSize = 0
        Me.btnProcurarPrestador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarPrestador.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarPrestador.Location = New System.Drawing.Point(446, 18)
        Me.btnProcurarPrestador.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarPrestador.Name = "btnProcurarPrestador"
        Me.btnProcurarPrestador.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarPrestador.TabIndex = 2
        Me.btnProcurarPrestador.TabStop = False
        Me.btnProcurarPrestador.UseVisualStyleBackColor = True
        '
        'txtCNPJPrestador
        '
        Me.txtCNPJPrestador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCNPJPrestador.BackColor = System.Drawing.Color.White
        Me.txtCNPJPrestador.Enabled = False
        Me.txtCNPJPrestador.Location = New System.Drawing.Point(469, 37)
        Me.txtCNPJPrestador.Mask = "00,000,000/0000-00"
        Me.txtCNPJPrestador.MaxLength = 25
        Me.txtCNPJPrestador.Name = "txtCNPJPrestador"
        Me.txtCNPJPrestador.Size = New System.Drawing.Size(129, 20)
        Me.txtCNPJPrestador.TabIndex = 5
        '
        'txtInscricaoMunicipalPrestador
        '
        Me.txtInscricaoMunicipalPrestador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInscricaoMunicipalPrestador.BackColor = System.Drawing.Color.White
        Me.txtInscricaoMunicipalPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoMunicipalPrestador.Enabled = False
        Me.txtInscricaoMunicipalPrestador.Location = New System.Drawing.Point(740, 37)
        Me.txtInscricaoMunicipalPrestador.MaxLength = 9
        Me.txtInscricaoMunicipalPrestador.Name = "txtInscricaoMunicipalPrestador"
        Me.txtInscricaoMunicipalPrestador.Size = New System.Drawing.Size(130, 20)
        Me.txtInscricaoMunicipalPrestador.TabIndex = 9
        '
        'lblInscricaoMunicipalPrestador
        '
        Me.lblInscricaoMunicipalPrestador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInscricaoMunicipalPrestador.AutoSize = True
        Me.lblInscricaoMunicipalPrestador.Location = New System.Drawing.Point(737, 20)
        Me.lblInscricaoMunicipalPrestador.Name = "lblInscricaoMunicipalPrestador"
        Me.lblInscricaoMunicipalPrestador.Size = New System.Drawing.Size(101, 14)
        Me.lblInscricaoMunicipalPrestador.TabIndex = 8
        Me.lblInscricaoMunicipalPrestador.Text = "Inscrição Municipal:"
        '
        'txtInscricaoEstadualPrestador
        '
        Me.txtInscricaoEstadualPrestador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInscricaoEstadualPrestador.BackColor = System.Drawing.Color.White
        Me.txtInscricaoEstadualPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoEstadualPrestador.Enabled = False
        Me.txtInscricaoEstadualPrestador.Location = New System.Drawing.Point(604, 37)
        Me.txtInscricaoEstadualPrestador.MaxLength = 14
        Me.txtInscricaoEstadualPrestador.Name = "txtInscricaoEstadualPrestador"
        Me.txtInscricaoEstadualPrestador.Size = New System.Drawing.Size(130, 20)
        Me.txtInscricaoEstadualPrestador.TabIndex = 7
        '
        'lblInscricaoEstadualPrestador
        '
        Me.lblInscricaoEstadualPrestador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInscricaoEstadualPrestador.AutoSize = True
        Me.lblInscricaoEstadualPrestador.Location = New System.Drawing.Point(601, 20)
        Me.lblInscricaoEstadualPrestador.Name = "lblInscricaoEstadualPrestador"
        Me.lblInscricaoEstadualPrestador.Size = New System.Drawing.Size(98, 14)
        Me.lblInscricaoEstadualPrestador.TabIndex = 6
        Me.lblInscricaoEstadualPrestador.Text = "Inscrição Estadual:"
        '
        'lblCNPJPrestador
        '
        Me.lblCNPJPrestador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPJPrestador.AutoSize = True
        Me.lblCNPJPrestador.Location = New System.Drawing.Point(466, 20)
        Me.lblCNPJPrestador.Name = "lblCNPJPrestador"
        Me.lblCNPJPrestador.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJPrestador.TabIndex = 4
        Me.lblCNPJPrestador.Text = "CNPJ:"
        '
        'lblPrestador
        '
        Me.lblPrestador.AutoSize = True
        Me.lblPrestador.Location = New System.Drawing.Point(25, 20)
        Me.lblPrestador.Name = "lblPrestador"
        Me.lblPrestador.Size = New System.Drawing.Size(57, 14)
        Me.lblPrestador.TabIndex = 0
        Me.lblPrestador.Text = "Prestador:"
        '
        'cboPrestador
        '
        Me.cboPrestador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPrestador.AutoSize = False
        Me.cboPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPrestador.Location = New System.Drawing.Point(9, 37)
        Me.cboPrestador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPrestador.Name = "cboPrestador"
        Me.cboPrestador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPrestador.Size = New System.Drawing.Size(454, 20)
        Me.cboPrestador.TabIndex = 3
        '
        'btnCadastrarPrestador
        '
        Me.btnCadastrarPrestador.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPrestador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPrestador.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarPrestador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarPrestador.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarPrestador.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarPrestador.Name = "btnCadastrarPrestador"
        Me.btnCadastrarPrestador.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarPrestador.TabIndex = 1
        Me.btnCadastrarPrestador.TabStop = False
        Me.btnCadastrarPrestador.UseVisualStyleBackColor = True
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblTipoNotaFiscal)
        Me.grpDados.Controls.Add(Me.cboTipoNotaFiscal)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(220, 67)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados da Nota Fiscal"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblTipoNotaFiscal
        '
        Me.lblTipoNotaFiscal.AutoSize = True
        Me.lblTipoNotaFiscal.Location = New System.Drawing.Point(9, 20)
        Me.lblTipoNotaFiscal.Name = "lblTipoNotaFiscal"
        Me.lblTipoNotaFiscal.Size = New System.Drawing.Size(101, 14)
        Me.lblTipoNotaFiscal.TabIndex = 0
        Me.lblTipoNotaFiscal.Text = "Tipo de Nota Fiscal:"
        '
        'cboTipoNotaFiscal
        '
        Me.cboTipoNotaFiscal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoNotaFiscal.AutoSize = False
        Me.cboTipoNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoNotaFiscal.Location = New System.Drawing.Point(9, 37)
        Me.cboTipoNotaFiscal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoNotaFiscal.Name = "cboTipoNotaFiscal"
        Me.cboTipoNotaFiscal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoNotaFiscal.Size = New System.Drawing.Size(202, 20)
        Me.cboTipoNotaFiscal.TabIndex = 1
        '
        'grpEnderecoTomador
        '
        Me.grpEnderecoTomador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEnderecoTomador.BackColor = System.Drawing.Color.Transparent
        Me.grpEnderecoTomador.Controls.Add(Me.lblValorUFTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblValorPaisTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblValorCEPEmiente)
        Me.grpEnderecoTomador.Controls.Add(Me.lblValorMunicipioTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblValorBairroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblValorComplementoTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblValorNumeroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblValorLogradouroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblPaisTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblCEPEmiente)
        Me.grpEnderecoTomador.Controls.Add(Me.lblUFTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblMunicipioTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblBairroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblComplementoTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblNumeroTomador)
        Me.grpEnderecoTomador.Controls.Add(Me.lblLogradouroTomador)
        Me.grpEnderecoTomador.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEnderecoTomador.Location = New System.Drawing.Point(8, 170)
        Me.grpEnderecoTomador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEnderecoTomador.Name = "grpEnderecoTomador"
        Me.grpEnderecoTomador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEnderecoTomador.Size = New System.Drawing.Size(879, 94)
        Me.grpEnderecoTomador.TabIndex = 4
        Me.grpEnderecoTomador.Text = "Endereço do Tomador"
        Me.grpEnderecoTomador.VisualStyleManager = Me.vsmMain
        '
        'lblValorUFTomador
        '
        Me.lblValorUFTomador.AutoSize = True
        Me.lblValorUFTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorUFTomador.Location = New System.Drawing.Point(575, 54)
        Me.lblValorUFTomador.Name = "lblValorUFTomador"
        Me.lblValorUFTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorUFTomador.TabIndex = 11
        Me.lblValorUFTomador.Text = "-"
        '
        'lblValorPaisTomador
        '
        Me.lblValorPaisTomador.AutoSize = True
        Me.lblValorPaisTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorPaisTomador.Location = New System.Drawing.Point(136, 71)
        Me.lblValorPaisTomador.Name = "lblValorPaisTomador"
        Me.lblValorPaisTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorPaisTomador.TabIndex = 15
        Me.lblValorPaisTomador.Text = "-"
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
        'lblValorMunicipioTomador
        '
        Me.lblValorMunicipioTomador.AutoSize = True
        Me.lblValorMunicipioTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorMunicipioTomador.Location = New System.Drawing.Point(136, 54)
        Me.lblValorMunicipioTomador.Name = "lblValorMunicipioTomador"
        Me.lblValorMunicipioTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorMunicipioTomador.TabIndex = 9
        Me.lblValorMunicipioTomador.Text = "-"
        '
        'lblValorBairroTomador
        '
        Me.lblValorBairroTomador.AutoSize = True
        Me.lblValorBairroTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorBairroTomador.Location = New System.Drawing.Point(575, 37)
        Me.lblValorBairroTomador.Name = "lblValorBairroTomador"
        Me.lblValorBairroTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorBairroTomador.TabIndex = 7
        Me.lblValorBairroTomador.Text = "-"
        '
        'lblValorComplementoTomador
        '
        Me.lblValorComplementoTomador.AutoSize = True
        Me.lblValorComplementoTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorComplementoTomador.Location = New System.Drawing.Point(136, 37)
        Me.lblValorComplementoTomador.Name = "lblValorComplementoTomador"
        Me.lblValorComplementoTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorComplementoTomador.TabIndex = 5
        Me.lblValorComplementoTomador.Text = "-"
        '
        'lblValorNumeroTomador
        '
        Me.lblValorNumeroTomador.AutoSize = True
        Me.lblValorNumeroTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorNumeroTomador.Location = New System.Drawing.Point(575, 20)
        Me.lblValorNumeroTomador.Name = "lblValorNumeroTomador"
        Me.lblValorNumeroTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorNumeroTomador.TabIndex = 3
        Me.lblValorNumeroTomador.Text = "-"
        '
        'lblValorLogradouroTomador
        '
        Me.lblValorLogradouroTomador.AutoSize = True
        Me.lblValorLogradouroTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorLogradouroTomador.Location = New System.Drawing.Point(136, 20)
        Me.lblValorLogradouroTomador.Name = "lblValorLogradouroTomador"
        Me.lblValorLogradouroTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorLogradouroTomador.TabIndex = 1
        Me.lblValorLogradouroTomador.Text = "-"
        '
        'lblPaisTomador
        '
        Me.lblPaisTomador.AutoSize = True
        Me.lblPaisTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblPaisTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPaisTomador.Location = New System.Drawing.Point(6, 71)
        Me.lblPaisTomador.Name = "lblPaisTomador"
        Me.lblPaisTomador.Size = New System.Drawing.Size(33, 14)
        Me.lblPaisTomador.TabIndex = 14
        Me.lblPaisTomador.Text = "País:"
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
        'lblUFTomador
        '
        Me.lblUFTomador.AutoSize = True
        Me.lblUFTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblUFTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUFTomador.Location = New System.Drawing.Point(515, 54)
        Me.lblUFTomador.Name = "lblUFTomador"
        Me.lblUFTomador.Size = New System.Drawing.Size(23, 14)
        Me.lblUFTomador.TabIndex = 10
        Me.lblUFTomador.Text = "UF:"
        '
        'lblMunicipioTomador
        '
        Me.lblMunicipioTomador.AutoSize = True
        Me.lblMunicipioTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblMunicipioTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMunicipioTomador.Location = New System.Drawing.Point(6, 54)
        Me.lblMunicipioTomador.Name = "lblMunicipioTomador"
        Me.lblMunicipioTomador.Size = New System.Drawing.Size(63, 14)
        Me.lblMunicipioTomador.TabIndex = 8
        Me.lblMunicipioTomador.Text = "Município:"
        '
        'lblBairroTomador
        '
        Me.lblBairroTomador.AutoSize = True
        Me.lblBairroTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblBairroTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblBairroTomador.Location = New System.Drawing.Point(515, 37)
        Me.lblBairroTomador.Name = "lblBairroTomador"
        Me.lblBairroTomador.Size = New System.Drawing.Size(43, 14)
        Me.lblBairroTomador.TabIndex = 6
        Me.lblBairroTomador.Text = "Bairro:"
        '
        'lblComplementoTomador
        '
        Me.lblComplementoTomador.AutoSize = True
        Me.lblComplementoTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblComplementoTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblComplementoTomador.Location = New System.Drawing.Point(6, 37)
        Me.lblComplementoTomador.Name = "lblComplementoTomador"
        Me.lblComplementoTomador.Size = New System.Drawing.Size(89, 14)
        Me.lblComplementoTomador.TabIndex = 4
        Me.lblComplementoTomador.Text = "Complemento:"
        '
        'lblNumeroTomador
        '
        Me.lblNumeroTomador.AutoSize = True
        Me.lblNumeroTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNumeroTomador.Location = New System.Drawing.Point(515, 20)
        Me.lblNumeroTomador.Name = "lblNumeroTomador"
        Me.lblNumeroTomador.Size = New System.Drawing.Size(54, 14)
        Me.lblNumeroTomador.TabIndex = 2
        Me.lblNumeroTomador.Text = "Número:"
        '
        'lblLogradouroTomador
        '
        Me.lblLogradouroTomador.AutoSize = True
        Me.lblLogradouroTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblLogradouroTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLogradouroTomador.Location = New System.Drawing.Point(6, 20)
        Me.lblLogradouroTomador.Name = "lblLogradouroTomador"
        Me.lblLogradouroTomador.Size = New System.Drawing.Size(75, 14)
        Me.lblLogradouroTomador.TabIndex = 0
        Me.lblLogradouroTomador.Text = "Logradouro:"
        '
        'grpDadosTomador
        '
        Me.grpDadosTomador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosTomador.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosTomador.Controls.Add(Me.lblValorRegimeTributarioTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblValorInscricaoEstadualTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblValorInscricaoMunicipalTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblValorNomeFantasiaTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblRegimeTributarioTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblInscricaoMunicipalTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblInscricaoEstadualTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblNomeFantasiaTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblValorRazaoSocialTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblRazaoSocialTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblValorCNPJTomador)
        Me.grpDadosTomador.Controls.Add(Me.lblCNPJTomador)
        Me.grpDadosTomador.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosTomador.Location = New System.Drawing.Point(8, 73)
        Me.grpDadosTomador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosTomador.Name = "grpDadosTomador"
        Me.grpDadosTomador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosTomador.Size = New System.Drawing.Size(879, 94)
        Me.grpDadosTomador.TabIndex = 3
        Me.grpDadosTomador.Text = "Dados do Tomador"
        Me.grpDadosTomador.VisualStyleManager = Me.vsmMain
        '
        'lblValorRegimeTributarioTomador
        '
        Me.lblValorRegimeTributarioTomador.AutoSize = True
        Me.lblValorRegimeTributarioTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorRegimeTributarioTomador.Location = New System.Drawing.Point(391, 37)
        Me.lblValorRegimeTributarioTomador.Name = "lblValorRegimeTributarioTomador"
        Me.lblValorRegimeTributarioTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorRegimeTributarioTomador.TabIndex = 7
        Me.lblValorRegimeTributarioTomador.Text = "-"
        '
        'lblValorInscricaoEstadualTomador
        '
        Me.lblValorInscricaoEstadualTomador.AutoSize = True
        Me.lblValorInscricaoEstadualTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorInscricaoEstadualTomador.Location = New System.Drawing.Point(391, 20)
        Me.lblValorInscricaoEstadualTomador.Name = "lblValorInscricaoEstadualTomador"
        Me.lblValorInscricaoEstadualTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorInscricaoEstadualTomador.TabIndex = 3
        Me.lblValorInscricaoEstadualTomador.Text = "-"
        '
        'lblValorInscricaoMunicipalTomador
        '
        Me.lblValorInscricaoMunicipalTomador.AutoSize = True
        Me.lblValorInscricaoMunicipalTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorInscricaoMunicipalTomador.Location = New System.Drawing.Point(136, 37)
        Me.lblValorInscricaoMunicipalTomador.Name = "lblValorInscricaoMunicipalTomador"
        Me.lblValorInscricaoMunicipalTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorInscricaoMunicipalTomador.TabIndex = 5
        Me.lblValorInscricaoMunicipalTomador.Text = "-"
        '
        'lblValorNomeFantasiaTomador
        '
        Me.lblValorNomeFantasiaTomador.AutoSize = True
        Me.lblValorNomeFantasiaTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorNomeFantasiaTomador.Location = New System.Drawing.Point(136, 71)
        Me.lblValorNomeFantasiaTomador.Name = "lblValorNomeFantasiaTomador"
        Me.lblValorNomeFantasiaTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorNomeFantasiaTomador.TabIndex = 11
        Me.lblValorNomeFantasiaTomador.Text = "-"
        '
        'lblRegimeTributarioTomador
        '
        Me.lblRegimeTributarioTomador.AutoSize = True
        Me.lblRegimeTributarioTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblRegimeTributarioTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRegimeTributarioTomador.Location = New System.Drawing.Point(277, 37)
        Me.lblRegimeTributarioTomador.Name = "lblRegimeTributarioTomador"
        Me.lblRegimeTributarioTomador.Size = New System.Drawing.Size(108, 14)
        Me.lblRegimeTributarioTomador.TabIndex = 6
        Me.lblRegimeTributarioTomador.Text = "Regime Tributário:"
        '
        'lblInscricaoMunicipalTomador
        '
        Me.lblInscricaoMunicipalTomador.AutoSize = True
        Me.lblInscricaoMunicipalTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblInscricaoMunicipalTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInscricaoMunicipalTomador.Location = New System.Drawing.Point(6, 37)
        Me.lblInscricaoMunicipalTomador.Name = "lblInscricaoMunicipalTomador"
        Me.lblInscricaoMunicipalTomador.Size = New System.Drawing.Size(113, 14)
        Me.lblInscricaoMunicipalTomador.TabIndex = 4
        Me.lblInscricaoMunicipalTomador.Text = "Instrição Municipal:"
        '
        'lblInscricaoEstadualTomador
        '
        Me.lblInscricaoEstadualTomador.AutoSize = True
        Me.lblInscricaoEstadualTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblInscricaoEstadualTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInscricaoEstadualTomador.Location = New System.Drawing.Point(277, 20)
        Me.lblInscricaoEstadualTomador.Name = "lblInscricaoEstadualTomador"
        Me.lblInscricaoEstadualTomador.Size = New System.Drawing.Size(109, 14)
        Me.lblInscricaoEstadualTomador.TabIndex = 2
        Me.lblInscricaoEstadualTomador.Text = "Inscrição Estadual:"
        '
        'lblNomeFantasiaTomador
        '
        Me.lblNomeFantasiaTomador.AutoSize = True
        Me.lblNomeFantasiaTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeFantasiaTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNomeFantasiaTomador.Location = New System.Drawing.Point(6, 71)
        Me.lblNomeFantasiaTomador.Name = "lblNomeFantasiaTomador"
        Me.lblNomeFantasiaTomador.Size = New System.Drawing.Size(90, 14)
        Me.lblNomeFantasiaTomador.TabIndex = 10
        Me.lblNomeFantasiaTomador.Text = "Nome Fantasia:"
        '
        'lblValorRazaoSocialTomador
        '
        Me.lblValorRazaoSocialTomador.AutoSize = True
        Me.lblValorRazaoSocialTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorRazaoSocialTomador.Location = New System.Drawing.Point(136, 54)
        Me.lblValorRazaoSocialTomador.Name = "lblValorRazaoSocialTomador"
        Me.lblValorRazaoSocialTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorRazaoSocialTomador.TabIndex = 9
        Me.lblValorRazaoSocialTomador.Text = "-"
        '
        'lblRazaoSocialTomador
        '
        Me.lblRazaoSocialTomador.AutoSize = True
        Me.lblRazaoSocialTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblRazaoSocialTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRazaoSocialTomador.Location = New System.Drawing.Point(6, 54)
        Me.lblRazaoSocialTomador.Name = "lblRazaoSocialTomador"
        Me.lblRazaoSocialTomador.Size = New System.Drawing.Size(77, 14)
        Me.lblRazaoSocialTomador.TabIndex = 8
        Me.lblRazaoSocialTomador.Text = "Razão Social:"
        '
        'lblValorCNPJTomador
        '
        Me.lblValorCNPJTomador.AutoSize = True
        Me.lblValorCNPJTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblValorCNPJTomador.Location = New System.Drawing.Point(136, 20)
        Me.lblValorCNPJTomador.Name = "lblValorCNPJTomador"
        Me.lblValorCNPJTomador.Size = New System.Drawing.Size(11, 14)
        Me.lblValorCNPJTomador.TabIndex = 1
        Me.lblValorCNPJTomador.Text = "-"
        '
        'lblCNPJTomador
        '
        Me.lblCNPJTomador.AutoSize = True
        Me.lblCNPJTomador.BackColor = System.Drawing.Color.Transparent
        Me.lblCNPJTomador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCNPJTomador.Location = New System.Drawing.Point(6, 20)
        Me.lblCNPJTomador.Name = "lblCNPJTomador"
        Me.lblCNPJTomador.Size = New System.Drawing.Size(38, 14)
        Me.lblCNPJTomador.TabIndex = 0
        Me.lblCNPJTomador.Text = "CNPJ:"
        '
        'pagServico
        '
        Me.pagServico.Controls.Add(Me.grdServico)
        Me.pagServico.Controls.Add(Me.grpServico)
        Me.pagServico.Key = "pagServico"
        Me.pagServico.Location = New System.Drawing.Point(1, 22)
        Me.pagServico.Name = "pagServico"
        Me.pagServico.Size = New System.Drawing.Size(895, 450)
        Me.pagServico.TabStop = True
        Me.pagServico.Text = "Serviços"
        '
        'grdServico
        '
        Me.grdServico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdServico.AlternatingColors = True
        Me.grdServico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdServico_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdServico_DesignTimeLayout_Reference_0.Instance"), Object)
        grdServico_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdServico_DesignTimeLayout_Reference_0})
        grdServico_DesignTimeLayout.LayoutString = resources.GetString("grdServico_DesignTimeLayout.LayoutString")
        Me.grdServico.DesignTimeLayout = grdServico_DesignTimeLayout
        Me.grdServico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdServico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdServico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdServico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdServico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdServico.GroupByBoxVisible = False
        Me.grdServico.Location = New System.Drawing.Point(8, 328)
        Me.grdServico.Name = "grdServico"
        Me.grdServico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdServico.RecordNavigator = True
        Me.grdServico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdServico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdServico.Size = New System.Drawing.Size(879, 119)
        Me.grdServico.TabIndex = 1
        Me.grdServico.TabStop = False
        Me.grdServico.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdServico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdServico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdServico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdServico.VisualStyleManager = Me.vsmMain
        '
        'grpServico
        '
        Me.grpServico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpServico.BackColor = System.Drawing.Color.Transparent
        Me.grpServico.Controls.Add(Me.btnExcluirServico)
        Me.grpServico.Controls.Add(Me.txtValorISS)
        Me.grpServico.Controls.Add(Me.btnInserirServico)
        Me.grpServico.Controls.Add(Me.btnCalcularCSLL)
        Me.grpServico.Controls.Add(Me.lblValorISS)
        Me.grpServico.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpServico.Controls.Add(Me.txtValorISSRetido)
        Me.grpServico.Controls.Add(Me.lblValorISSRetido)
        Me.grpServico.Controls.Add(Me.btnCalcularINSS)
        Me.grpServico.Controls.Add(Me.txtValorCSLL)
        Me.grpServico.Controls.Add(Me.txtValorServicoUnitario)
        Me.grpServico.Controls.Add(Me.lblValorCSLL)
        Me.grpServico.Controls.Add(Me.btnCalcularCOFINS)
        Me.grpServico.Controls.Add(Me.txtValorIR)
        Me.grpServico.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpServico.Controls.Add(Me.lblValorIR)
        Me.grpServico.Controls.Add(Me.btnCalcularPIS)
        Me.grpServico.Controls.Add(Me.txtValorINSS)
        Me.grpServico.Controls.Add(Me.lblValorServicoUnitario)
        Me.grpServico.Controls.Add(Me.lblValorINSS)
        Me.grpServico.Controls.Add(Me.txtAliquotaIR)
        Me.grpServico.Controls.Add(Me.txtValorCOFINS)
        Me.grpServico.Controls.Add(Me.lblValorCOFINS)
        Me.grpServico.Controls.Add(Me.lblAliquotaIR)
        Me.grpServico.Controls.Add(Me.txtValorPIS)
        Me.grpServico.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpServico.Controls.Add(Me.lblValorPIS)
        Me.grpServico.Controls.Add(Me.txtAliquotaCSLL)
        Me.grpServico.Controls.Add(Me.lblAliquotaCSLL)
        Me.grpServico.Controls.Add(Me.txtAliquotaINSS)
        Me.grpServico.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpServico.Controls.Add(Me.lblAliquotaINSS)
        Me.grpServico.Controls.Add(Me.txtQuantidade)
        Me.grpServico.Controls.Add(Me.txtAliquotaCOFINS)
        Me.grpServico.Controls.Add(Me.cboCentroGasto)
        Me.grpServico.Controls.Add(Me.lblAliquotaCOFINS)
        Me.grpServico.Controls.Add(Me.cboContaContabil)
        Me.grpServico.Controls.Add(Me.txtAliquotaPIS)
        Me.grpServico.Controls.Add(Me.lblQuantidade)
        Me.grpServico.Controls.Add(Me.lblAliquotaPIS)
        Me.grpServico.Controls.Add(Me.lblCentroGasto)
        Me.grpServico.Controls.Add(Me.cboISSRetido)
        Me.grpServico.Controls.Add(Me.lblISSRetido)
        Me.grpServico.Controls.Add(Me.lblContaContabil)
        Me.grpServico.Controls.Add(Me.btnCadastrarServico)
        Me.grpServico.Controls.Add(Me.txtValorLiquidoNFSE)
        Me.grpServico.Controls.Add(Me.lblValorLiquidoNFSE)
        Me.grpServico.Controls.Add(Me.txtValorDescontoIncondicionado)
        Me.grpServico.Controls.Add(Me.txtAliquotaISS)
        Me.grpServico.Controls.Add(Me.lblValorDescontoIncondicionado)
        Me.grpServico.Controls.Add(Me.lblAliquotaISS)
        Me.grpServico.Controls.Add(Me.txtValorDescontoCondicionado)
        Me.grpServico.Controls.Add(Me.txtBaseCalculo)
        Me.grpServico.Controls.Add(Me.lblValorDescontoCondicionado)
        Me.grpServico.Controls.Add(Me.lblBaseCalculo)
        Me.grpServico.Controls.Add(Me.txtValorServico)
        Me.grpServico.Controls.Add(Me.txtOutrasRetencoes)
        Me.grpServico.Controls.Add(Me.lblOutrasRetencoes)
        Me.grpServico.Controls.Add(Me.lblValorServico)
        Me.grpServico.Controls.Add(Me.btnProcurarServico)
        Me.grpServico.Controls.Add(Me.cboServico)
        Me.grpServico.Controls.Add(Me.lblServico)
        Me.grpServico.Controls.Add(Me.txtDescricao)
        Me.grpServico.Controls.Add(Me.lblDescricao)
        Me.grpServico.Controls.Add(Me.lblValorDeducoes)
        Me.grpServico.Controls.Add(Me.txtValorDeducoes)
        Me.grpServico.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpServico.Location = New System.Drawing.Point(8, 3)
        Me.grpServico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpServico.Name = "grpServico"
        Me.grpServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpServico.Size = New System.Drawing.Size(879, 318)
        Me.grpServico.TabIndex = 0
        Me.grpServico.Text = "Dados do Serviço"
        Me.grpServico.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirServico
        '
        Me.btnExcluirServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirServico.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirServico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirServico.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirServico.Location = New System.Drawing.Point(786, 280)
        Me.btnExcluirServico.Name = "btnExcluirServico"
        Me.btnExcluirServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirServico.Size = New System.Drawing.Size(84, 23)
        Me.btnExcluirServico.TabIndex = 30
        Me.btnExcluirServico.Text = "Excluir"
        Me.btnExcluirServico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtValorISS
        '
        Me.txtValorISS.DecimalDigits = 2
        Me.txtValorISS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorISS.Location = New System.Drawing.Point(9, 283)
        Me.txtValorISS.Name = "txtValorISS"
        Me.txtValorISS.ReadOnly = True
        Me.txtValorISS.Size = New System.Drawing.Size(105, 20)
        Me.txtValorISS.TabIndex = 22
        Me.txtValorISS.TabStop = False
        Me.txtValorISS.Text = "0,00"
        Me.txtValorISS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnInserirServico
        '
        Me.btnInserirServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirServico.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirServico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirServico.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirServico.Location = New System.Drawing.Point(786, 251)
        Me.btnInserirServico.Name = "btnInserirServico"
        Me.btnInserirServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirServico.Size = New System.Drawing.Size(84, 23)
        Me.btnInserirServico.TabIndex = 29
        Me.btnInserirServico.Text = "Inserir"
        Me.btnInserirServico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCalcularCSLL
        '
        Me.btnCalcularCSLL.FlatAppearance.BorderSize = 0
        Me.btnCalcularCSLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularCSLL.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularCSLL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcularCSLL.Location = New System.Drawing.Point(564, 223)
        Me.btnCalcularCSLL.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalcularCSLL.Name = "btnCalcularCSLL"
        Me.btnCalcularCSLL.Size = New System.Drawing.Size(13, 16)
        Me.btnCalcularCSLL.TabIndex = 53
        Me.btnCalcularCSLL.TabStop = False
        Me.btnCalcularCSLL.UseVisualStyleBackColor = True
        '
        'lblValorISS
        '
        Me.lblValorISS.AutoSize = True
        Me.lblValorISS.BackColor = System.Drawing.Color.Transparent
        Me.lblValorISS.Location = New System.Drawing.Point(6, 266)
        Me.lblValorISS.Name = "lblValorISS"
        Me.lblValorISS.Size = New System.Drawing.Size(54, 14)
        Me.lblValorISS.TabIndex = 58
        Me.lblValorISS.Text = "Valor ISS:"
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(853, 143)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 30
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'txtValorISSRetido
        '
        Me.txtValorISSRetido.DecimalDigits = 2
        Me.txtValorISSRetido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorISSRetido.Location = New System.Drawing.Point(120, 283)
        Me.txtValorISSRetido.Name = "txtValorISSRetido"
        Me.txtValorISSRetido.ReadOnly = True
        Me.txtValorISSRetido.Size = New System.Drawing.Size(105, 20)
        Me.txtValorISSRetido.TabIndex = 23
        Me.txtValorISSRetido.TabStop = False
        Me.txtValorISSRetido.Text = "0,00"
        Me.txtValorISSRetido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorISSRetido
        '
        Me.lblValorISSRetido.AutoSize = True
        Me.lblValorISSRetido.BackColor = System.Drawing.Color.Transparent
        Me.lblValorISSRetido.Location = New System.Drawing.Point(117, 266)
        Me.lblValorISSRetido.Name = "lblValorISSRetido"
        Me.lblValorISSRetido.Size = New System.Drawing.Size(87, 14)
        Me.lblValorISSRetido.TabIndex = 60
        Me.lblValorISSRetido.Text = "Valor ISS Retido:"
        '
        'btnCalcularINSS
        '
        Me.btnCalcularINSS.FlatAppearance.BorderSize = 0
        Me.btnCalcularINSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularINSS.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularINSS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcularINSS.Location = New System.Drawing.Point(453, 224)
        Me.btnCalcularINSS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalcularINSS.Name = "btnCalcularINSS"
        Me.btnCalcularINSS.Size = New System.Drawing.Size(13, 16)
        Me.btnCalcularINSS.TabIndex = 49
        Me.btnCalcularINSS.TabStop = False
        Me.btnCalcularINSS.UseVisualStyleBackColor = True
        '
        'txtValorCSLL
        '
        Me.txtValorCSLL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorCSLL.Location = New System.Drawing.Point(564, 283)
        Me.txtValorCSLL.Name = "txtValorCSLL"
        Me.txtValorCSLL.ReadOnly = True
        Me.txtValorCSLL.Size = New System.Drawing.Size(105, 20)
        Me.txtValorCSLL.TabIndex = 27
        Me.txtValorCSLL.TabStop = False
        Me.txtValorCSLL.Text = "0,00"
        Me.txtValorCSLL.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorServicoUnitario
        '
        Me.txtValorServicoUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorServicoUnitario.DecimalDigits = 3
        Me.txtValorServicoUnitario.Location = New System.Drawing.Point(563, 37)
        Me.txtValorServicoUnitario.Name = "txtValorServicoUnitario"
        Me.txtValorServicoUnitario.Size = New System.Drawing.Size(97, 20)
        Me.txtValorServicoUnitario.TabIndex = 4
        Me.txtValorServicoUnitario.Text = "0,000"
        Me.txtValorServicoUnitario.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        '
        'lblValorCSLL
        '
        Me.lblValorCSLL.AutoSize = True
        Me.lblValorCSLL.BackColor = System.Drawing.Color.Transparent
        Me.lblValorCSLL.Location = New System.Drawing.Point(561, 266)
        Me.lblValorCSLL.Name = "lblValorCSLL"
        Me.lblValorCSLL.Size = New System.Drawing.Size(64, 14)
        Me.lblValorCSLL.TabIndex = 69
        Me.lblValorCSLL.Text = "Valor CSLL:"
        '
        'btnCalcularCOFINS
        '
        Me.btnCalcularCOFINS.FlatAppearance.BorderSize = 0
        Me.btnCalcularCOFINS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularCOFINS.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularCOFINS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcularCOFINS.Location = New System.Drawing.Point(342, 223)
        Me.btnCalcularCOFINS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalcularCOFINS.Name = "btnCalcularCOFINS"
        Me.btnCalcularCOFINS.Size = New System.Drawing.Size(13, 16)
        Me.btnCalcularCOFINS.TabIndex = 46
        Me.btnCalcularCOFINS.TabStop = False
        Me.btnCalcularCOFINS.UseVisualStyleBackColor = True
        '
        'txtValorIR
        '
        Me.txtValorIR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorIR.Location = New System.Drawing.Point(675, 283)
        Me.txtValorIR.Name = "txtValorIR"
        Me.txtValorIR.ReadOnly = True
        Me.txtValorIR.Size = New System.Drawing.Size(105, 20)
        Me.txtValorIR.TabIndex = 28
        Me.txtValorIR.TabStop = False
        Me.txtValorIR.Text = "0,00"
        Me.txtValorIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(481, 143)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 26
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'lblValorIR
        '
        Me.lblValorIR.AutoSize = True
        Me.lblValorIR.BackColor = System.Drawing.Color.Transparent
        Me.lblValorIR.Location = New System.Drawing.Point(672, 266)
        Me.lblValorIR.Name = "lblValorIR"
        Me.lblValorIR.Size = New System.Drawing.Size(47, 14)
        Me.lblValorIR.TabIndex = 1
        Me.lblValorIR.Text = "Valor IR:"
        '
        'btnCalcularPIS
        '
        Me.btnCalcularPIS.FlatAppearance.BorderSize = 0
        Me.btnCalcularPIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularPIS.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularPIS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcularPIS.Location = New System.Drawing.Point(231, 224)
        Me.btnCalcularPIS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalcularPIS.Name = "btnCalcularPIS"
        Me.btnCalcularPIS.Size = New System.Drawing.Size(13, 16)
        Me.btnCalcularPIS.TabIndex = 42
        Me.btnCalcularPIS.TabStop = False
        Me.btnCalcularPIS.UseVisualStyleBackColor = True
        '
        'txtValorINSS
        '
        Me.txtValorINSS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorINSS.Location = New System.Drawing.Point(453, 283)
        Me.txtValorINSS.Name = "txtValorINSS"
        Me.txtValorINSS.ReadOnly = True
        Me.txtValorINSS.Size = New System.Drawing.Size(105, 20)
        Me.txtValorINSS.TabIndex = 26
        Me.txtValorINSS.TabStop = False
        Me.txtValorINSS.Text = "0,00"
        Me.txtValorINSS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorServicoUnitario
        '
        Me.lblValorServicoUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorServicoUnitario.AutoSize = True
        Me.lblValorServicoUnitario.BackColor = System.Drawing.Color.Transparent
        Me.lblValorServicoUnitario.Location = New System.Drawing.Point(560, 20)
        Me.lblValorServicoUnitario.Name = "lblValorServicoUnitario"
        Me.lblValorServicoUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorServicoUnitario.TabIndex = 10
        Me.lblValorServicoUnitario.Text = "Valor Unitário:"
        '
        'lblValorINSS
        '
        Me.lblValorINSS.AutoSize = True
        Me.lblValorINSS.BackColor = System.Drawing.Color.Transparent
        Me.lblValorINSS.Location = New System.Drawing.Point(450, 266)
        Me.lblValorINSS.Name = "lblValorINSS"
        Me.lblValorINSS.Size = New System.Drawing.Size(61, 14)
        Me.lblValorINSS.TabIndex = 67
        Me.lblValorINSS.Text = "Valor INSS:"
        '
        'txtAliquotaIR
        '
        Me.txtAliquotaIR.DecimalDigits = 2
        Me.txtAliquotaIR.Location = New System.Drawing.Point(675, 241)
        Me.txtAliquotaIR.Name = "txtAliquotaIR"
        Me.txtAliquotaIR.Size = New System.Drawing.Size(105, 20)
        Me.txtAliquotaIR.TabIndex = 21
        Me.txtAliquotaIR.Text = "0,00"
        Me.txtAliquotaIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorCOFINS
        '
        Me.txtValorCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorCOFINS.Location = New System.Drawing.Point(342, 283)
        Me.txtValorCOFINS.Name = "txtValorCOFINS"
        Me.txtValorCOFINS.ReadOnly = True
        Me.txtValorCOFINS.Size = New System.Drawing.Size(105, 20)
        Me.txtValorCOFINS.TabIndex = 25
        Me.txtValorCOFINS.TabStop = False
        Me.txtValorCOFINS.Text = "0,00"
        Me.txtValorCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCOFINS
        '
        Me.lblValorCOFINS.AutoSize = True
        Me.lblValorCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.lblValorCOFINS.Location = New System.Drawing.Point(339, 266)
        Me.lblValorCOFINS.Name = "lblValorCOFINS"
        Me.lblValorCOFINS.Size = New System.Drawing.Size(75, 14)
        Me.lblValorCOFINS.TabIndex = 65
        Me.lblValorCOFINS.Text = "Valor COFINS:"
        '
        'lblAliquotaIR
        '
        Me.lblAliquotaIR.AutoSize = True
        Me.lblAliquotaIR.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaIR.Location = New System.Drawing.Point(672, 226)
        Me.lblAliquotaIR.Name = "lblAliquotaIR"
        Me.lblAliquotaIR.Size = New System.Drawing.Size(82, 14)
        Me.lblAliquotaIR.TabIndex = 56
        Me.lblAliquotaIR.Text = "Alíquota IR (%):"
        '
        'txtValorPIS
        '
        Me.txtValorPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorPIS.Location = New System.Drawing.Point(231, 283)
        Me.txtValorPIS.Name = "txtValorPIS"
        Me.txtValorPIS.ReadOnly = True
        Me.txtValorPIS.Size = New System.Drawing.Size(105, 20)
        Me.txtValorPIS.TabIndex = 24
        Me.txtValorPIS.TabStop = False
        Me.txtValorPIS.Text = "0,00"
        Me.txtValorPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = CType(resources.GetObject("btnCadastrarContaContabil.Image"), System.Drawing.Image)
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(504, 145)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 28
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'lblValorPIS
        '
        Me.lblValorPIS.AutoSize = True
        Me.lblValorPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblValorPIS.Location = New System.Drawing.Point(228, 267)
        Me.lblValorPIS.Name = "lblValorPIS"
        Me.lblValorPIS.Size = New System.Drawing.Size(53, 14)
        Me.lblValorPIS.TabIndex = 63
        Me.lblValorPIS.Text = "Valor PIS:"
        '
        'txtAliquotaCSLL
        '
        Me.txtAliquotaCSLL.DecimalDigits = 2
        Me.txtAliquotaCSLL.Location = New System.Drawing.Point(564, 241)
        Me.txtAliquotaCSLL.Name = "txtAliquotaCSLL"
        Me.txtAliquotaCSLL.Size = New System.Drawing.Size(105, 20)
        Me.txtAliquotaCSLL.TabIndex = 20
        Me.txtAliquotaCSLL.Text = "0,00"
        Me.txtAliquotaCSLL.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCSLL
        '
        Me.lblAliquotaCSLL.AutoSize = True
        Me.lblAliquotaCSLL.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaCSLL.Location = New System.Drawing.Point(580, 224)
        Me.lblAliquotaCSLL.Name = "lblAliquotaCSLL"
        Me.lblAliquotaCSLL.Size = New System.Drawing.Size(57, 14)
        Me.lblAliquotaCSLL.TabIndex = 54
        Me.lblAliquotaCSLL.Text = "CSLL (%):"
        '
        'txtAliquotaINSS
        '
        Me.txtAliquotaINSS.DecimalDigits = 2
        Me.txtAliquotaINSS.Location = New System.Drawing.Point(453, 241)
        Me.txtAliquotaINSS.Name = "txtAliquotaINSS"
        Me.txtAliquotaINSS.Size = New System.Drawing.Size(105, 20)
        Me.txtAliquotaINSS.TabIndex = 19
        Me.txtAliquotaINSS.Text = "0,00"
        Me.txtAliquotaINSS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = CType(resources.GetObject("btnCadastrarCentroGasto.Image"), System.Drawing.Image)
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(9, 145)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 23
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'lblAliquotaINSS
        '
        Me.lblAliquotaINSS.AutoSize = True
        Me.lblAliquotaINSS.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaINSS.Location = New System.Drawing.Point(469, 225)
        Me.lblAliquotaINSS.Name = "lblAliquotaINSS"
        Me.lblAliquotaINSS.Size = New System.Drawing.Size(54, 14)
        Me.lblAliquotaINSS.TabIndex = 51
        Me.lblAliquotaINSS.Text = "INSS (%):"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidade.DecimalDigits = 2
        Me.txtQuantidade.Location = New System.Drawing.Point(460, 37)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(97, 20)
        Me.txtQuantidade.TabIndex = 3
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtAliquotaCOFINS
        '
        Me.txtAliquotaCOFINS.DecimalDigits = 2
        Me.txtAliquotaCOFINS.Location = New System.Drawing.Point(342, 241)
        Me.txtAliquotaCOFINS.Name = "txtAliquotaCOFINS"
        Me.txtAliquotaCOFINS.Size = New System.Drawing.Size(105, 20)
        Me.txtAliquotaCOFINS.TabIndex = 18
        Me.txtAliquotaCOFINS.Text = "0,00"
        Me.txtAliquotaCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(9, 161)
        Me.cboCentroGasto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(489, 20)
        Me.cboCentroGasto.TabIndex = 10
        '
        'lblAliquotaCOFINS
        '
        Me.lblAliquotaCOFINS.AutoSize = True
        Me.lblAliquotaCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaCOFINS.Location = New System.Drawing.Point(358, 224)
        Me.lblAliquotaCOFINS.Name = "lblAliquotaCOFINS"
        Me.lblAliquotaCOFINS.Size = New System.Drawing.Size(68, 14)
        Me.lblAliquotaCOFINS.TabIndex = 47
        Me.lblAliquotaCOFINS.Text = "COFINS (%):"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(504, 161)
        Me.cboContaContabil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(366, 20)
        Me.cboContaContabil.TabIndex = 11
        '
        'txtAliquotaPIS
        '
        Me.txtAliquotaPIS.DecimalDigits = 2
        Me.txtAliquotaPIS.Location = New System.Drawing.Point(231, 241)
        Me.txtAliquotaPIS.Name = "txtAliquotaPIS"
        Me.txtAliquotaPIS.Size = New System.Drawing.Size(105, 20)
        Me.txtAliquotaPIS.TabIndex = 17
        Me.txtAliquotaPIS.Text = "0,00"
        Me.txtAliquotaPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantidade.Location = New System.Drawing.Point(457, 20)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 8
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'lblAliquotaPIS
        '
        Me.lblAliquotaPIS.AutoSize = True
        Me.lblAliquotaPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaPIS.Location = New System.Drawing.Point(247, 225)
        Me.lblAliquotaPIS.Name = "lblAliquotaPIS"
        Me.lblAliquotaPIS.Size = New System.Drawing.Size(46, 14)
        Me.lblAliquotaPIS.TabIndex = 43
        Me.lblAliquotaPIS.Text = "PIS (%):"
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(25, 144)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 24
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboISSRetido
        '
        Me.cboISSRetido.AutoSize = False
        Me.cboISSRetido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboISSRetido.Location = New System.Drawing.Point(120, 241)
        Me.cboISSRetido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboISSRetido.Name = "cboISSRetido"
        Me.cboISSRetido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboISSRetido.Size = New System.Drawing.Size(105, 20)
        Me.cboISSRetido.TabIndex = 16
        '
        'lblISSRetido
        '
        Me.lblISSRetido.AutoSize = True
        Me.lblISSRetido.BackColor = System.Drawing.Color.Transparent
        Me.lblISSRetido.Location = New System.Drawing.Point(117, 225)
        Me.lblISSRetido.Name = "lblISSRetido"
        Me.lblISSRetido.Size = New System.Drawing.Size(59, 14)
        Me.lblISSRetido.TabIndex = 40
        Me.lblISSRetido.Text = "ISS Retido:"
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(520, 144)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 29
        Me.lblContaContabil.Text = "Conta Contábil:"
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
        Me.txtValorLiquidoNFSE.DecimalDigits = 3
        Me.txtValorLiquidoNFSE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorLiquidoNFSE.Location = New System.Drawing.Point(769, 117)
        Me.txtValorLiquidoNFSE.Name = "txtValorLiquidoNFSE"
        Me.txtValorLiquidoNFSE.ReadOnly = True
        Me.txtValorLiquidoNFSE.Size = New System.Drawing.Size(100, 20)
        Me.txtValorLiquidoNFSE.TabIndex = 8
        Me.txtValorLiquidoNFSE.TabStop = False
        Me.txtValorLiquidoNFSE.Text = "0,000"
        Me.txtValorLiquidoNFSE.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        '
        'lblValorLiquidoNFSE
        '
        Me.lblValorLiquidoNFSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorLiquidoNFSE.AutoSize = True
        Me.lblValorLiquidoNFSE.BackColor = System.Drawing.Color.Transparent
        Me.lblValorLiquidoNFSE.Location = New System.Drawing.Point(766, 100)
        Me.lblValorLiquidoNFSE.Name = "lblValorLiquidoNFSE"
        Me.lblValorLiquidoNFSE.Size = New System.Drawing.Size(72, 14)
        Me.lblValorLiquidoNFSE.TabIndex = 19
        Me.lblValorLiquidoNFSE.Text = "Valor Líquido:"
        '
        'txtValorDescontoIncondicionado
        '
        Me.txtValorDescontoIncondicionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDescontoIncondicionado.DecimalDigits = 3
        Me.txtValorDescontoIncondicionado.Location = New System.Drawing.Point(769, 77)
        Me.txtValorDescontoIncondicionado.Name = "txtValorDescontoIncondicionado"
        Me.txtValorDescontoIncondicionado.Size = New System.Drawing.Size(100, 20)
        Me.txtValorDescontoIncondicionado.TabIndex = 7
        Me.txtValorDescontoIncondicionado.Text = "0,000"
        Me.txtValorDescontoIncondicionado.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        '
        'txtAliquotaISS
        '
        Me.txtAliquotaISS.DecimalDigits = 2
        Me.txtAliquotaISS.Location = New System.Drawing.Point(9, 241)
        Me.txtAliquotaISS.Name = "txtAliquotaISS"
        Me.txtAliquotaISS.Size = New System.Drawing.Size(105, 20)
        Me.txtAliquotaISS.TabIndex = 15
        Me.txtAliquotaISS.Text = "0,00"
        Me.txtAliquotaISS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDescontoIncondicionado
        '
        Me.lblValorDescontoIncondicionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorDescontoIncondicionado.AutoSize = True
        Me.lblValorDescontoIncondicionado.BackColor = System.Drawing.Color.Transparent
        Me.lblValorDescontoIncondicionado.Location = New System.Drawing.Point(766, 60)
        Me.lblValorDescontoIncondicionado.Name = "lblValorDescontoIncondicionado"
        Me.lblValorDescontoIncondicionado.Size = New System.Drawing.Size(103, 14)
        Me.lblValorDescontoIncondicionado.TabIndex = 17
        Me.lblValorDescontoIncondicionado.Text = "Desc. Incondicional:"
        '
        'lblAliquotaISS
        '
        Me.lblAliquotaISS.AutoSize = True
        Me.lblAliquotaISS.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaISS.Location = New System.Drawing.Point(6, 224)
        Me.lblAliquotaISS.Name = "lblAliquotaISS"
        Me.lblAliquotaISS.Size = New System.Drawing.Size(89, 14)
        Me.lblAliquotaISS.TabIndex = 38
        Me.lblAliquotaISS.Text = "Alíquota ISS (%):"
        '
        'txtValorDescontoCondicionado
        '
        Me.txtValorDescontoCondicionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDescontoCondicionado.DecimalDigits = 3
        Me.txtValorDescontoCondicionado.Location = New System.Drawing.Point(769, 37)
        Me.txtValorDescontoCondicionado.Name = "txtValorDescontoCondicionado"
        Me.txtValorDescontoCondicionado.Size = New System.Drawing.Size(97, 20)
        Me.txtValorDescontoCondicionado.TabIndex = 6
        Me.txtValorDescontoCondicionado.Text = "0,000"
        Me.txtValorDescontoCondicionado.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        '
        'txtBaseCalculo
        '
        Me.txtBaseCalculo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBaseCalculo.Location = New System.Drawing.Point(231, 201)
        Me.txtBaseCalculo.Name = "txtBaseCalculo"
        Me.txtBaseCalculo.ReadOnly = True
        Me.txtBaseCalculo.Size = New System.Drawing.Size(105, 20)
        Me.txtBaseCalculo.TabIndex = 14
        Me.txtBaseCalculo.TabStop = False
        Me.txtBaseCalculo.Text = "0,00"
        Me.txtBaseCalculo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDescontoCondicionado
        '
        Me.lblValorDescontoCondicionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorDescontoCondicionado.AutoSize = True
        Me.lblValorDescontoCondicionado.BackColor = System.Drawing.Color.Transparent
        Me.lblValorDescontoCondicionado.Location = New System.Drawing.Point(766, 20)
        Me.lblValorDescontoCondicionado.Name = "lblValorDescontoCondicionado"
        Me.lblValorDescontoCondicionado.Size = New System.Drawing.Size(96, 14)
        Me.lblValorDescontoCondicionado.TabIndex = 15
        Me.lblValorDescontoCondicionado.Text = "Desc. Condicional:"
        '
        'lblBaseCalculo
        '
        Me.lblBaseCalculo.AutoSize = True
        Me.lblBaseCalculo.BackColor = System.Drawing.Color.Transparent
        Me.lblBaseCalculo.Location = New System.Drawing.Point(228, 184)
        Me.lblBaseCalculo.Name = "lblBaseCalculo"
        Me.lblBaseCalculo.Size = New System.Drawing.Size(73, 14)
        Me.lblBaseCalculo.TabIndex = 36
        Me.lblBaseCalculo.Text = "Base Cálculo:"
        '
        'txtValorServico
        '
        Me.txtValorServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorServico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorServico.DecimalDigits = 3
        Me.txtValorServico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorServico.Location = New System.Drawing.Point(666, 37)
        Me.txtValorServico.Name = "txtValorServico"
        Me.txtValorServico.ReadOnly = True
        Me.txtValorServico.Size = New System.Drawing.Size(97, 20)
        Me.txtValorServico.TabIndex = 5
        Me.txtValorServico.TabStop = False
        Me.txtValorServico.Text = "0,000"
        Me.txtValorServico.Value = New Decimal(New Integer() {0, 0, 0, 196608})
        '
        'txtOutrasRetencoes
        '
        Me.txtOutrasRetencoes.Location = New System.Drawing.Point(9, 201)
        Me.txtOutrasRetencoes.Name = "txtOutrasRetencoes"
        Me.txtOutrasRetencoes.Size = New System.Drawing.Size(105, 20)
        Me.txtOutrasRetencoes.TabIndex = 12
        Me.txtOutrasRetencoes.Text = "0,00"
        Me.txtOutrasRetencoes.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblOutrasRetencoes
        '
        Me.lblOutrasRetencoes.AutoSize = True
        Me.lblOutrasRetencoes.BackColor = System.Drawing.Color.Transparent
        Me.lblOutrasRetencoes.Location = New System.Drawing.Point(6, 184)
        Me.lblOutrasRetencoes.Name = "lblOutrasRetencoes"
        Me.lblOutrasRetencoes.Size = New System.Drawing.Size(98, 14)
        Me.lblOutrasRetencoes.TabIndex = 32
        Me.lblOutrasRetencoes.Text = "Outras Retenções:"
        '
        'lblValorServico
        '
        Me.lblValorServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorServico.AutoSize = True
        Me.lblValorServico.BackColor = System.Drawing.Color.Transparent
        Me.lblValorServico.Location = New System.Drawing.Point(663, 20)
        Me.lblValorServico.Name = "lblValorServico"
        Me.lblValorServico.Size = New System.Drawing.Size(90, 14)
        Me.lblValorServico.TabIndex = 13
        Me.lblValorServico.Text = "Valor do Serviço:"
        '
        'btnProcurarServico
        '
        Me.btnProcurarServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarServico.FlatAppearance.BorderSize = 0
        Me.btnProcurarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarServico.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarServico.Location = New System.Drawing.Point(436, 18)
        Me.btnProcurarServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarServico.Name = "btnProcurarServico"
        Me.btnProcurarServico.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarServico.TabIndex = 5
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
        Me.cboServico.Size = New System.Drawing.Size(445, 20)
        Me.cboServico.TabIndex = 1
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
        Me.txtDescricao.Size = New System.Drawing.Size(754, 60)
        Me.txtDescricao.TabIndex = 9
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 60)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 21
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblValorDeducoes
        '
        Me.lblValorDeducoes.AutoSize = True
        Me.lblValorDeducoes.BackColor = System.Drawing.Color.Transparent
        Me.lblValorDeducoes.Location = New System.Drawing.Point(117, 184)
        Me.lblValorDeducoes.Name = "lblValorDeducoes"
        Me.lblValorDeducoes.Size = New System.Drawing.Size(108, 14)
        Me.lblValorDeducoes.TabIndex = 34
        Me.lblValorDeducoes.Text = "Valor das Deduções:"
        '
        'txtValorDeducoes
        '
        Me.txtValorDeducoes.Location = New System.Drawing.Point(120, 201)
        Me.txtValorDeducoes.Name = "txtValorDeducoes"
        Me.txtValorDeducoes.Size = New System.Drawing.Size(105, 20)
        Me.txtValorDeducoes.TabIndex = 13
        Me.txtValorDeducoes.Text = "0,00"
        Me.txtValorDeducoes.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'pagCobranca
        '
        Me.pagCobranca.Controls.Add(Me.grpTituloPrevisto)
        Me.pagCobranca.Controls.Add(Me.grpDuplicata)
        Me.pagCobranca.Controls.Add(Me.grpFatura)
        Me.pagCobranca.Key = "pagCobranca"
        Me.pagCobranca.Location = New System.Drawing.Point(1, 22)
        Me.pagCobranca.Name = "pagCobranca"
        Me.pagCobranca.Size = New System.Drawing.Size(895, 450)
        Me.pagCobranca.TabStop = True
        Me.pagCobranca.Text = "Cobrança"
        '
        'grpTituloPrevisto
        '
        Me.grpTituloPrevisto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTituloPrevisto.BackColor = System.Drawing.Color.Transparent
        Me.grpTituloPrevisto.Controls.Add(Me.txtNumeroParcelaTituloPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.lblNumeroParcelaTituloPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.btnVincular)
        Me.grpTituloPrevisto.Controls.Add(Me.dtpDataVencimentoPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.txtNumDocumentoPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.lblTituloPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.txtValorPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.cboTituloPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.Label1)
        Me.grpTituloPrevisto.Controls.Add(Me.Label3)
        Me.grpTituloPrevisto.Controls.Add(Me.Label4)
        Me.grpTituloPrevisto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpTituloPrevisto.Location = New System.Drawing.Point(8, 80)
        Me.grpTituloPrevisto.Name = "grpTituloPrevisto"
        Me.grpTituloPrevisto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTituloPrevisto.Size = New System.Drawing.Size(641, 105)
        Me.grpTituloPrevisto.TabIndex = 0
        Me.grpTituloPrevisto.Text = "Dados do Título Previsto"
        Me.grpTituloPrevisto.Visible = False
        Me.grpTituloPrevisto.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroParcelaTituloPrevisto
        '
        Me.txtNumeroParcelaTituloPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroParcelaTituloPrevisto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroParcelaTituloPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroParcelaTituloPrevisto.Location = New System.Drawing.Point(135, 71)
        Me.txtNumeroParcelaTituloPrevisto.MaxLength = 60
        Me.txtNumeroParcelaTituloPrevisto.Name = "txtNumeroParcelaTituloPrevisto"
        Me.txtNumeroParcelaTituloPrevisto.ReadOnly = True
        Me.txtNumeroParcelaTituloPrevisto.Size = New System.Drawing.Size(90, 20)
        Me.txtNumeroParcelaTituloPrevisto.TabIndex = 5
        Me.txtNumeroParcelaTituloPrevisto.TabStop = False
        '
        'lblNumeroParcelaTituloPrevisto
        '
        Me.lblNumeroParcelaTituloPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroParcelaTituloPrevisto.AutoSize = True
        Me.lblNumeroParcelaTituloPrevisto.Location = New System.Drawing.Point(134, 54)
        Me.lblNumeroParcelaTituloPrevisto.Name = "lblNumeroParcelaTituloPrevisto"
        Me.lblNumeroParcelaTituloPrevisto.Size = New System.Drawing.Size(60, 14)
        Me.lblNumeroParcelaTituloPrevisto.TabIndex = 4
        Me.lblNumeroParcelaTituloPrevisto.Text = "N° Parcela:"
        '
        'btnVincular
        '
        Me.btnVincular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVincular.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnVincular.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVincular.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnVincular.Location = New System.Drawing.Point(485, 71)
        Me.btnVincular.Name = "btnVincular"
        Me.btnVincular.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVincular.Size = New System.Drawing.Size(148, 23)
        Me.btnVincular.TabIndex = 10
        Me.btnVincular.Text = "Vincular Título - Previsão"
        Me.btnVincular.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataVencimentoPrevisto
        '
        Me.dtpDataVencimentoPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDataVencimentoPrevisto.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.dtpDataVencimentoPrevisto.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoPrevisto.Location = New System.Drawing.Point(340, 71)
        Me.dtpDataVencimentoPrevisto.Name = "dtpDataVencimentoPrevisto"
        Me.dtpDataVencimentoPrevisto.ReadOnly = True
        Me.dtpDataVencimentoPrevisto.Size = New System.Drawing.Size(118, 20)
        Me.dtpDataVencimentoPrevisto.TabIndex = 9
        '
        'txtNumDocumentoPrevisto
        '
        Me.txtNumDocumentoPrevisto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumDocumentoPrevisto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumDocumentoPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumDocumentoPrevisto.Location = New System.Drawing.Point(12, 71)
        Me.txtNumDocumentoPrevisto.MaxLength = 60
        Me.txtNumDocumentoPrevisto.Name = "txtNumDocumentoPrevisto"
        Me.txtNumDocumentoPrevisto.ReadOnly = True
        Me.txtNumDocumentoPrevisto.Size = New System.Drawing.Size(117, 20)
        Me.txtNumDocumentoPrevisto.TabIndex = 3
        Me.txtNumDocumentoPrevisto.TabStop = False
        '
        'lblTituloPrevisto
        '
        Me.lblTituloPrevisto.AutoSize = True
        Me.lblTituloPrevisto.Location = New System.Drawing.Point(9, 13)
        Me.lblTituloPrevisto.Name = "lblTituloPrevisto"
        Me.lblTituloPrevisto.Size = New System.Drawing.Size(77, 14)
        Me.lblTituloPrevisto.TabIndex = 0
        Me.lblTituloPrevisto.Text = "Título Previsto:"
        '
        'txtValorPrevisto
        '
        Me.txtValorPrevisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorPrevisto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPrevisto.DecimalDigits = 2
        Me.txtValorPrevisto.Location = New System.Drawing.Point(229, 71)
        Me.txtValorPrevisto.MaxLength = 0
        Me.txtValorPrevisto.Name = "txtValorPrevisto"
        Me.txtValorPrevisto.ReadOnly = True
        Me.txtValorPrevisto.Size = New System.Drawing.Size(105, 20)
        Me.txtValorPrevisto.TabIndex = 7
        Me.txtValorPrevisto.Text = "0,00"
        Me.txtValorPrevisto.Value = 0.0R
        Me.txtValorPrevisto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'cboTituloPrevisto
        '
        Me.cboTituloPrevisto.AutoSize = False
        Me.cboTituloPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTituloPrevisto.Location = New System.Drawing.Point(12, 30)
        Me.cboTituloPrevisto.Name = "cboTituloPrevisto"
        Me.cboTituloPrevisto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTituloPrevisto.Size = New System.Drawing.Size(446, 20)
        Me.cboTituloPrevisto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Valor:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Data Vencimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "N° Documento:"
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
        Me.btnCalcularDuplicata.Location = New System.Drawing.Point(129, 117)
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
        'pagDadosDespesa
        '
        Me.pagDadosDespesa.Controls.Add(Me.grpDadosDespesa)
        Me.pagDadosDespesa.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosDespesa.Name = "pagDadosDespesa"
        Me.pagDadosDespesa.Size = New System.Drawing.Size(895, 450)
        Me.pagDadosDespesa.TabStop = True
        Me.pagDadosDespesa.Text = "Dados da Despesa"
        '
        'grpDadosDespesa
        '
        Me.grpDadosDespesa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosDespesa.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosDespesa.Controls.Add(Me.grpClassificao)
        Me.grpDadosDespesa.Controls.Add(Me.txtDescritivoDespesa)
        Me.grpDadosDespesa.Controls.Add(Me.grdClassificacao)
        Me.grpDadosDespesa.Controls.Add(Me.lblDescritivoDespesa)
        Me.grpDadosDespesa.Controls.Add(Me.lblTipoDocumentoPagamento)
        Me.grpDadosDespesa.Controls.Add(Me.cboTipoDocumentoPagamento)
        Me.grpDadosDespesa.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosDespesa.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosDespesa.Name = "grpDadosDespesa"
        Me.grpDadosDespesa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosDespesa.Size = New System.Drawing.Size(879, 330)
        Me.grpDadosDespesa.TabIndex = 4
        Me.grpDadosDespesa.Text = "Dados da Despesa"
        Me.grpDadosDespesa.VisualStyleManager = Me.vsmMain
        '
        'grpClassificao
        '
        Me.grpClassificao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpClassificao.BackColor = System.Drawing.Color.Transparent
        Me.grpClassificao.Controls.Add(Me.btnProcurarCentroGastoDespesa)
        Me.grpClassificao.Controls.Add(Me.btnProcurarContaContabilDespesa)
        Me.grpClassificao.Controls.Add(Me.txtValorClassificacao)
        Me.grpClassificao.Controls.Add(Me.lblValorClassificacao)
        Me.grpClassificao.Controls.Add(Me.lblContaContabilDespesa)
        Me.grpClassificao.Controls.Add(Me.cboContaContabilDespesa)
        Me.grpClassificao.Controls.Add(Me.lblCentroGastoDespesa)
        Me.grpClassificao.Controls.Add(Me.cboCentroGastoDespesa)
        Me.grpClassificao.Controls.Add(Me.btnExcluirClassificacao)
        Me.grpClassificao.Controls.Add(Me.btnInserirClassificao)
        Me.grpClassificao.Controls.Add(Me.btnCadastrarContaContabilDespesa)
        Me.grpClassificao.Controls.Add(Me.btnCadastrarCentroGastoDespesa)
        Me.grpClassificao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpClassificao.Location = New System.Drawing.Point(12, 109)
        Me.grpClassificao.Name = "grpClassificao"
        Me.grpClassificao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpClassificao.Size = New System.Drawing.Size(859, 67)
        Me.grpClassificao.TabIndex = 14
        Me.grpClassificao.Text = "Dados da Classificação"
        Me.grpClassificao.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCentroGastoDespesa
        '
        Me.btnProcurarCentroGastoDespesa.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGastoDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGastoDespesa.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGastoDespesa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGastoDespesa.Location = New System.Drawing.Point(272, 19)
        Me.btnProcurarCentroGastoDespesa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGastoDespesa.Name = "btnProcurarCentroGastoDespesa"
        Me.btnProcurarCentroGastoDespesa.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGastoDespesa.TabIndex = 13
        Me.btnProcurarCentroGastoDespesa.TabStop = False
        Me.btnProcurarCentroGastoDespesa.UseVisualStyleBackColor = True
        '
        'btnProcurarContaContabilDespesa
        '
        Me.btnProcurarContaContabilDespesa.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabilDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabilDespesa.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabilDespesa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabilDespesa.Location = New System.Drawing.Point(528, 19)
        Me.btnProcurarContaContabilDespesa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabilDespesa.Name = "btnProcurarContaContabilDespesa"
        Me.btnProcurarContaContabilDespesa.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabilDespesa.TabIndex = 12
        Me.btnProcurarContaContabilDespesa.TabStop = False
        Me.btnProcurarContaContabilDespesa.UseVisualStyleBackColor = True
        '
        'txtValorClassificacao
        '
        Me.txtValorClassificacao.DecimalDigits = 2
        Me.txtValorClassificacao.Location = New System.Drawing.Point(551, 37)
        Me.txtValorClassificacao.MaxLength = 0
        Me.txtValorClassificacao.Name = "txtValorClassificacao"
        Me.txtValorClassificacao.Size = New System.Drawing.Size(90, 20)
        Me.txtValorClassificacao.TabIndex = 7
        Me.txtValorClassificacao.Text = "0,00"
        Me.txtValorClassificacao.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorClassificacao
        '
        Me.lblValorClassificacao.AutoSize = True
        Me.lblValorClassificacao.Location = New System.Drawing.Point(548, 20)
        Me.lblValorClassificacao.Name = "lblValorClassificacao"
        Me.lblValorClassificacao.Size = New System.Drawing.Size(35, 14)
        Me.lblValorClassificacao.TabIndex = 6
        Me.lblValorClassificacao.Text = "Valor:"
        '
        'lblContaContabilDespesa
        '
        Me.lblContaContabilDespesa.AutoSize = True
        Me.lblContaContabilDespesa.Location = New System.Drawing.Point(311, 20)
        Me.lblContaContabilDespesa.Name = "lblContaContabilDespesa"
        Me.lblContaContabilDespesa.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabilDespesa.TabIndex = 4
        Me.lblContaContabilDespesa.Text = "Conta Contábil:"
        '
        'cboContaContabilDespesa
        '
        Me.cboContaContabilDespesa.AutoSize = False
        Me.cboContaContabilDespesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabilDespesa.Location = New System.Drawing.Point(295, 37)
        Me.cboContaContabilDespesa.Name = "cboContaContabilDespesa"
        Me.cboContaContabilDespesa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabilDespesa.Size = New System.Drawing.Size(250, 20)
        Me.cboContaContabilDespesa.TabIndex = 5
        '
        'lblCentroGastoDespesa
        '
        Me.lblCentroGastoDespesa.AutoSize = True
        Me.lblCentroGastoDespesa.Location = New System.Drawing.Point(25, 20)
        Me.lblCentroGastoDespesa.Name = "lblCentroGastoDespesa"
        Me.lblCentroGastoDespesa.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGastoDespesa.TabIndex = 1
        Me.lblCentroGastoDespesa.Text = "Centro de Gasto:"
        '
        'cboCentroGastoDespesa
        '
        Me.cboCentroGastoDespesa.AutoSize = False
        Me.cboCentroGastoDespesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGastoDespesa.Location = New System.Drawing.Point(9, 37)
        Me.cboCentroGastoDespesa.Name = "cboCentroGastoDespesa"
        Me.cboCentroGastoDespesa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGastoDespesa.Size = New System.Drawing.Size(280, 20)
        Me.cboCentroGastoDespesa.TabIndex = 2
        '
        'btnExcluirClassificacao
        '
        Me.btnExcluirClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirClassificacao.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirClassificacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirClassificacao.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirClassificacao.Location = New System.Drawing.Point(757, 34)
        Me.btnExcluirClassificacao.Name = "btnExcluirClassificacao"
        Me.btnExcluirClassificacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirClassificacao.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirClassificacao.TabIndex = 9
        Me.btnExcluirClassificacao.Text = "Excluir"
        Me.btnExcluirClassificacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirClassificao
        '
        Me.btnInserirClassificao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirClassificao.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirClassificao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirClassificao.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirClassificao.Location = New System.Drawing.Point(660, 34)
        Me.btnInserirClassificao.Name = "btnInserirClassificao"
        Me.btnInserirClassificao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirClassificao.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirClassificao.TabIndex = 8
        Me.btnInserirClassificao.Text = "Inserir"
        Me.btnInserirClassificao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarContaContabilDespesa
        '
        Me.btnCadastrarContaContabilDespesa.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabilDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabilDespesa.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabilDespesa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabilDespesa.Location = New System.Drawing.Point(295, 21)
        Me.btnCadastrarContaContabilDespesa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabilDespesa.Name = "btnCadastrarContaContabilDespesa"
        Me.btnCadastrarContaContabilDespesa.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabilDespesa.TabIndex = 3
        Me.btnCadastrarContaContabilDespesa.TabStop = False
        Me.btnCadastrarContaContabilDespesa.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGastoDespesa
        '
        Me.btnCadastrarCentroGastoDespesa.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGastoDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGastoDespesa.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGastoDespesa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGastoDespesa.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarCentroGastoDespesa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGastoDespesa.Name = "btnCadastrarCentroGastoDespesa"
        Me.btnCadastrarCentroGastoDespesa.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGastoDespesa.TabIndex = 0
        Me.btnCadastrarCentroGastoDespesa.TabStop = False
        Me.btnCadastrarCentroGastoDespesa.UseVisualStyleBackColor = True
        '
        'txtDescritivoDespesa
        '
        Me.txtDescritivoDespesa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescritivoDespesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivoDespesa.Location = New System.Drawing.Point(168, 34)
        Me.txtDescritivoDespesa.MaxLength = 500
        Me.txtDescritivoDespesa.Multiline = True
        Me.txtDescritivoDespesa.Name = "txtDescritivoDespesa"
        Me.txtDescritivoDespesa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescritivoDespesa.Size = New System.Drawing.Size(703, 69)
        Me.txtDescritivoDespesa.TabIndex = 13
        '
        'grdClassificacao
        '
        Me.grdClassificacao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdClassificacao.AlternatingColors = True
        Me.grdClassificacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClassificacao.ColumnAutoResize = True
        grdClassificacao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdClassificacao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdClassificacao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdClassificacao_DesignTimeLayout_Reference_0})
        grdClassificacao_DesignTimeLayout.LayoutString = resources.GetString("grdClassificacao_DesignTimeLayout.LayoutString")
        Me.grdClassificacao.DesignTimeLayout = grdClassificacao_DesignTimeLayout
        Me.grdClassificacao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdClassificacao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdClassificacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdClassificacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdClassificacao.GroupByBoxVisible = False
        Me.grdClassificacao.Location = New System.Drawing.Point(12, 182)
        Me.grdClassificacao.Name = "grdClassificacao"
        Me.grdClassificacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdClassificacao.RecordNavigator = True
        Me.grdClassificacao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdClassificacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdClassificacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdClassificacao.Size = New System.Drawing.Size(856, 138)
        Me.grdClassificacao.TabIndex = 15
        Me.grdClassificacao.TabStop = False
        Me.grdClassificacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdClassificacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdClassificacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdClassificacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdClassificacao.VisualStyleManager = Me.vsmMain
        '
        'lblDescritivoDespesa
        '
        Me.lblDescritivoDespesa.AutoSize = True
        Me.lblDescritivoDespesa.Location = New System.Drawing.Point(165, 17)
        Me.lblDescritivoDespesa.Name = "lblDescritivoDespesa"
        Me.lblDescritivoDespesa.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivoDespesa.TabIndex = 12
        Me.lblDescritivoDespesa.Text = "Descritivo:"
        '
        'lblTipoDocumentoPagamento
        '
        Me.lblTipoDocumentoPagamento.AutoSize = True
        Me.lblTipoDocumentoPagamento.Location = New System.Drawing.Point(9, 17)
        Me.lblTipoDocumentoPagamento.Name = "lblTipoDocumentoPagamento"
        Me.lblTipoDocumentoPagamento.Size = New System.Drawing.Size(143, 14)
        Me.lblTipoDocumentoPagamento.TabIndex = 0
        Me.lblTipoDocumentoPagamento.Text = "Tipo Documento Pagamento:"
        '
        'cboTipoDocumentoPagamento
        '
        Me.cboTipoDocumentoPagamento.AutoSize = False
        Me.cboTipoDocumentoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumentoPagamento.Location = New System.Drawing.Point(12, 34)
        Me.cboTipoDocumentoPagamento.Name = "cboTipoDocumentoPagamento"
        Me.cboTipoDocumentoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumentoPagamento.Size = New System.Drawing.Size(150, 20)
        Me.cboTipoDocumentoPagamento.TabIndex = 1
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
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = CType(resources.GetObject("btnExcelGridArquivo.Image"), System.Drawing.Image)
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(58, 424)
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
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(34, 424)
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
        Me.btnConfigurarGridArquivo.Image = CType(resources.GetObject("btnConfigurarGridArquivo.Image"), System.Drawing.Image)
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(10, 424)
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
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'lblRevisaoArquivo
        '
        Me.lblRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevisaoArquivo.AutoSize = True
        Me.lblRevisaoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        Me.lblDescricaoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        Me.btnCadastrarTipoArquivo.Image = CType(resources.GetObject("btnCadastrarTipoArquivo.Image"), System.Drawing.Image)
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
        Me.grdArquivo.Location = New System.Drawing.Point(9, 116)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(878, 325)
        Me.grdArquivo.TabIndex = 1
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.chkCalculoImpostoManual)
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
        'chkCalculoImpostoManual
        '
        Me.chkCalculoImpostoManual.Location = New System.Drawing.Point(6, 22)
        Me.chkCalculoImpostoManual.Name = "chkCalculoImpostoManual"
        Me.chkCalculoImpostoManual.Size = New System.Drawing.Size(136, 18)
        Me.chkCalculoImpostoManual.TabIndex = 0
        Me.chkCalculoImpostoManual.TabStop = False
        Me.chkCalculoImpostoManual.Text = "Cálculo Imposto Manual"
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
        'usrFatEntradaNFs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrFatEntradaNFs"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagLista.ResumeLayout(false)
        CType(Me.grpLegenda,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpLegenda.ResumeLayout(false)
        Me.grpLegenda.PerformLayout
        CType(Me.picLegendaAutozidadaParaUso,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picLegendaCancelada,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpControle,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControle.ResumeLayout(false)
        CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpFiltro,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFiltro.ResumeLayout(false)
        Me.grpFiltro.PerformLayout
        Me.pagDados.ResumeLayout(false)
        CType(Me.tabDados,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabDados.ResumeLayout(false)
        Me.pagDadosNFs.ResumeLayout(false)
        CType(Me.grpDadosNFse,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDadosNFse.ResumeLayout(false)
        Me.grpDadosNFse.PerformLayout
        CType(Me.grpDadosNF,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDadosNF.ResumeLayout(false)
        Me.grpDadosNF.PerformLayout
        CType(Me.grpEnderecoPrestador,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpEnderecoPrestador.ResumeLayout(false)
        Me.grpEnderecoPrestador.PerformLayout
        CType(Me.grpIdentificacaoPrestador,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpIdentificacaoPrestador.ResumeLayout(false)
        Me.grpIdentificacaoPrestador.PerformLayout
        CType(Me.grpDados,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDados.ResumeLayout(false)
        Me.grpDados.PerformLayout
        CType(Me.grpEnderecoTomador,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpEnderecoTomador.ResumeLayout(false)
        Me.grpEnderecoTomador.PerformLayout
        CType(Me.grpDadosTomador,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDadosTomador.ResumeLayout(false)
        Me.grpDadosTomador.PerformLayout
        Me.pagServico.ResumeLayout(false)
        CType(Me.grdServico,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpServico,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpServico.ResumeLayout(false)
        Me.grpServico.PerformLayout
        Me.pagCobranca.ResumeLayout(false)
        CType(Me.grpTituloPrevisto,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpTituloPrevisto.ResumeLayout(false)
        Me.grpTituloPrevisto.PerformLayout
        CType(Me.grpDuplicata,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDuplicata.ResumeLayout(false)
        Me.grpDuplicata.PerformLayout
        CType(Me.grdDuplicata,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpFatura,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFatura.ResumeLayout(false)
        Me.grpFatura.PerformLayout
        Me.pagDadosDespesa.ResumeLayout(false)
        CType(Me.grpDadosDespesa,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDadosDespesa.ResumeLayout(false)
        Me.grpDadosDespesa.PerformLayout
        CType(Me.grpClassificao,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpClassificao.ResumeLayout(false)
        Me.grpClassificao.PerformLayout
        CType(Me.grdClassificacao,System.ComponentModel.ISupportInitialize).EndInit
        Me.pagArquivo.ResumeLayout(false)
        CType(Me.grpArquivo,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpArquivo.ResumeLayout(false)
        Me.grpArquivo.PerformLayout
        CType(Me.grdArquivo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpControle2,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControle2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDadosNFs As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPrestadorFiltro As System.Windows.Forms.Label
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
    Friend WithEvents txtPrestadorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpDuplicata As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCalcularDuplicata As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtIntervaloEntreParcelas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloEntreParcelas As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroParcela As System.Windows.Forms.Label
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdDuplicata As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpEnderecoTomador As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorUFTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorPaisTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorCEPEmiente As System.Windows.Forms.Label
    Friend WithEvents lblValorMunicipioTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorBairroTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorComplementoTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorNumeroTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorLogradouroTomador As System.Windows.Forms.Label
    Friend WithEvents lblPaisTomador As System.Windows.Forms.Label
    Friend WithEvents lblCEPEmiente As System.Windows.Forms.Label
    Friend WithEvents lblUFTomador As System.Windows.Forms.Label
    Friend WithEvents lblMunicipioTomador As System.Windows.Forms.Label
    Friend WithEvents lblBairroTomador As System.Windows.Forms.Label
    Friend WithEvents lblComplementoTomador As System.Windows.Forms.Label
    Friend WithEvents lblNumeroTomador As System.Windows.Forms.Label
    Friend WithEvents lblLogradouroTomador As System.Windows.Forms.Label
    Friend WithEvents grpDadosTomador As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorRegimeTributarioTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorInscricaoEstadualTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorInscricaoMunicipalTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorNomeFantasiaTomador As System.Windows.Forms.Label
    Friend WithEvents lblRegimeTributarioTomador As System.Windows.Forms.Label
    Friend WithEvents lblInscricaoMunicipalTomador As System.Windows.Forms.Label
    Friend WithEvents lblInscricaoEstadualTomador As System.Windows.Forms.Label
    Friend WithEvents lblNomeFantasiaTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorRazaoSocialTomador As System.Windows.Forms.Label
    Friend WithEvents lblRazaoSocialTomador As System.Windows.Forms.Label
    Friend WithEvents lblValorCNPJTomador As System.Windows.Forms.Label
    Friend WithEvents lblCNPJTomador As System.Windows.Forms.Label
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaAutozidadaParaUso As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelada As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAutozidadaParaUso As System.Windows.Forms.Label
    Friend WithEvents grpEnderecoPrestador As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtTelefonePrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefonePrestador As System.Windows.Forms.Label
    Friend WithEvents txtEmailPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEmailPrestador As System.Windows.Forms.Label
    Friend WithEvents cboMunicipioPrestador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairroPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPaisPrestador As System.Windows.Forms.Label
    Friend WithEvents cboPaisPrestador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCEPPrestador As System.Windows.Forms.Label
    Friend WithEvents txtCEPPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplementoPrestador As System.Windows.Forms.Label
    Friend WithEvents lblUFPrestador As System.Windows.Forms.Label
    Friend WithEvents cboUFPrestador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipioPrestador As System.Windows.Forms.Label
    Friend WithEvents lblBairroPrestador As System.Windows.Forms.Label
    Friend WithEvents lblNumeroPrestador As System.Windows.Forms.Label
    Friend WithEvents lblLogradouroPrestador As System.Windows.Forms.Label
    Friend WithEvents txtLogradouroPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarCEPPrestador As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarPaisPrestador As System.Windows.Forms.Button
    Friend WithEvents grpIdentificacaoPrestador As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarPrestador As System.Windows.Forms.Button
    Friend WithEvents txtCNPJPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtInscricaoMunicipalPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoMunicipalPrestador As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoEstadualPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadualPrestador As System.Windows.Forms.Label
    Friend WithEvents lblCNPJPrestador As System.Windows.Forms.Label
    Friend WithEvents lblPrestador As System.Windows.Forms.Label
    Friend WithEvents cboPrestador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarPrestador As System.Windows.Forms.Button
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents grpDadosNF As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataEntrada As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntrada As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents lblTipoNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents cboTipoNotaFiscal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpDadosNFse As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCodigoVerificacaoNFSe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoVerificacaoNFSe As System.Windows.Forms.Label
    Friend WithEvents cboTipoNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblTipoNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents btnConsultarNFSe As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataEntradaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntradaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntradaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents btnCalcularCSLL As System.Windows.Forms.Button
    Friend WithEvents btnCalcularINSS As System.Windows.Forms.Button
    Friend WithEvents btnCalcularCOFINS As System.Windows.Forms.Button
    Friend WithEvents btnCalcularPIS As System.Windows.Forms.Button
    Friend WithEvents txtAliquotaIR As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIR As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCSLL As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCSLL As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaINSS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaINSS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPIS As System.Windows.Forms.Label
    Friend WithEvents cboISSRetido As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblISSRetido As System.Windows.Forms.Label
    Friend WithEvents txtValorISS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorISS As System.Windows.Forms.Label
    Friend WithEvents txtValorISSRetido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorISSRetido As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaISS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaISS As System.Windows.Forms.Label
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
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarServico As System.Windows.Forms.Button
    Friend WithEvents txtValorLiquidoNFSE As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorLiquidoNFSE As System.Windows.Forms.Label
    Friend WithEvents txtValorDescontoIncondicionado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDescontoIncondicionado As System.Windows.Forms.Label
    Friend WithEvents txtValorDescontoCondicionado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDescontoCondicionado As System.Windows.Forms.Label
    Friend WithEvents txtValorServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorServico As System.Windows.Forms.Label
    Friend WithEvents btnProcurarServico As System.Windows.Forms.Button
    Friend WithEvents cboServico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblServico As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents txtValorServicoUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorServicoUnitario As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents txtPedidoCompraFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPedidoCompraFiltro As System.Windows.Forms.Label
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
    Friend WithEvents grpTituloPrevisto As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnVincular As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataVencimentoPrevisto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumDocumentoPrevisto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTituloPrevisto As System.Windows.Forms.Label
    Friend WithEvents txtValorPrevisto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboTituloPrevisto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcelaTituloPrevisto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroParcelaTituloPrevisto As System.Windows.Forms.Label
    Friend WithEvents chkCalculoImpostoManual As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents pagDadosDespesa As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosDespesa As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpClassificao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarCentroGastoDespesa As System.Windows.Forms.Button
    Friend WithEvents btnProcurarContaContabilDespesa As System.Windows.Forms.Button
    Friend WithEvents txtValorClassificacao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorClassificacao As System.Windows.Forms.Label
    Friend WithEvents lblContaContabilDespesa As System.Windows.Forms.Label
    Friend WithEvents cboContaContabilDespesa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGastoDespesa As System.Windows.Forms.Label
    Friend WithEvents cboCentroGastoDespesa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluirClassificacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirClassificao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarContaContabilDespesa As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGastoDespesa As System.Windows.Forms.Button
    Friend WithEvents txtDescritivoDespesa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grdClassificacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblDescritivoDespesa As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocumentoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluirServico As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirServico As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdServico As Janus.Windows.GridEX.GridEX

End Class
