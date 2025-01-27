<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEntradaNFXML
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEntradaNFXML))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim cboCFOPFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdReboque_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdReboque_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdVolume_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdVolume_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdVolume_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdDuplicata_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdRecebimento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRecebimento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdRecebimento_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdXML_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaEmDigitacao = New System.Windows.Forms.Label()
        Me.picLegendaEnviadoCliente = New System.Windows.Forms.PictureBox()
        Me.picLegendaAutozidadaParaUso = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCancelada = New System.Windows.Forms.Label()
        Me.picLegendaCancelada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAutozidadaParaUso = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoOperacaoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoOperacaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataEntradaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEntradaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntradaFiltro = New System.Windows.Forms.Label()
        Me.txtLoteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLoteFiltro = New System.Windows.Forms.Label()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.cboCFOPFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.lblCFOPFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtEmitenteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.lblEmitenteFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnGerarXML = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosNF = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnInserirNFFatura = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosDACTE = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtChaveAcessoDACTE = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblChaveAcessoDACTE = New System.Windows.Forms.Label()
        Me.grpTipoNotaFiscal = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtEspecie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEspecie = New System.Windows.Forms.Label()
        Me.lblTipoNotaFiscal = New System.Windows.Forms.Label()
        Me.cboTipoNotaFiscal = New Janus.Windows.EditControls.UIComboBox()
        Me.grpDadosNFe = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEntradaNFe = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtStatusNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblStatusNFe = New System.Windows.Forms.Label()
        Me.txtNumeroProtocoloNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroProtocoloNFe = New System.Windows.Forms.Label()
        Me.txtChaveAcessoNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblChaveAcessoNFe = New System.Windows.Forms.Label()
        Me.lblDataEntradaNFe = New System.Windows.Forms.Label()
        Me.txtDataEmissaoNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEmissaoNFe = New System.Windows.Forms.Label()
        Me.txtSerieNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieNFe = New System.Windows.Forms.Label()
        Me.txtNumeroNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroNFe = New System.Windows.Forms.Label()
        Me.btnArquivoNFe = New Janus.Windows.EditControls.UIButton()
        Me.txtArquivoNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblArquivoNFe = New System.Windows.Forms.Label()
        Me.grpDadosNF = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEntradaNF = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoNF = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntradaNF = New System.Windows.Forms.Label()
        Me.lblDataEmissaoNF = New System.Windows.Forms.Label()
        Me.txtSerieNF = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieNF = New System.Windows.Forms.Label()
        Me.txtNumeroNF = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroNF = New System.Windows.Forms.Label()
        Me.pagEmitente = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLocalRetiradaEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnEnderecoLocalEntrega = New Janus.Windows.EditControls.UIButton()
        Me.btnEnderecoLocalRetirada = New Janus.Windows.EditControls.UIButton()
        Me.chkLocalEntrega = New Janus.Windows.EditControls.UICheckBox()
        Me.chkLocalRetirada = New Janus.Windows.EditControls.UICheckBox()
        Me.grpEmitente = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCNAEEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNAEEmitente = New System.Windows.Forms.Label()
        Me.txtInscricaoMunicipalEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoMunicipalEmitente = New System.Windows.Forms.Label()
        Me.lblRegimeTributarioEmitente = New System.Windows.Forms.Label()
        Me.cboRegimeTributarioEmitente = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCNPJEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadualSubstitutoTributarioEmitente = New System.Windows.Forms.Label()
        Me.txtInscricaoEstadualEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadualEmitente = New System.Windows.Forms.Label()
        Me.lblCNPJEmitente = New System.Windows.Forms.Label()
        Me.lblEmitente = New System.Windows.Forms.Label()
        Me.cboEmitente = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarEmitente = New System.Windows.Forms.Button()
        Me.btnCadastrarEmitente = New System.Windows.Forms.Button()
        Me.grpEnderecoDestinatario = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTelefoneEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefoneEmitente = New System.Windows.Forms.Label()
        Me.txtEmailEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmailEmitente = New System.Windows.Forms.Label()
        Me.cboMunicipioEmitente = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplementoEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairroEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPaisEmitente = New System.Windows.Forms.Label()
        Me.cboPaisEmitente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCEPEmitente = New System.Windows.Forms.Label()
        Me.txtCEPEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplementoEmitente = New System.Windows.Forms.Label()
        Me.lblUFEmitente = New System.Windows.Forms.Label()
        Me.cboUFEmitente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipioEmitente = New System.Windows.Forms.Label()
        Me.lblBairroEmitente = New System.Windows.Forms.Label()
        Me.lblNumeroEmitente = New System.Windows.Forms.Label()
        Me.lblLogradouroEmitente = New System.Windows.Forms.Label()
        Me.txtLogradouroEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnProcurarCEPEmitente = New System.Windows.Forms.Button()
        Me.btnCadastrarPaisEmitente = New System.Windows.Forms.Button()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnEditarGridProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.btnExcelGridProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.pagTransporte = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabTransporte = New Janus.Windows.UI.Tab.UITab()
        Me.pagTransportador = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpTransportador = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMunicipioTransportadora = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUFTransportadora = New System.Windows.Forms.Label()
        Me.cboUFTransportadora = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipioTransportadora = New System.Windows.Forms.Label()
        Me.lblEnderecoTransportadora = New System.Windows.Forms.Label()
        Me.txtEnderecoTransportadora = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblModalidadeFrete = New System.Windows.Forms.Label()
        Me.cboModalidadeFrete = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCNPJTransportadora = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtInscricaoEstadualTransportadora = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadualTransportadora = New System.Windows.Forms.Label()
        Me.lblCNPJTransportadora = New System.Windows.Forms.Label()
        Me.lblTransportadora = New System.Windows.Forms.Label()
        Me.cboTransportadora = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarTransportadora = New System.Windows.Forms.Button()
        Me.btnCadastrarTransportadora = New System.Windows.Forms.Button()
        Me.pagRetencaoICMS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpRetencaoICMSTransporte = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtICMSRetidoTransporte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCFOPICMSTransporte = New System.Windows.Forms.Label()
        Me.cboCFOPICMSTransporte = New Janus.Windows.EditControls.UIComboBox()
        Me.cboMunicipioICMSTransporte = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUFICMSTransporte = New System.Windows.Forms.Label()
        Me.cboUFICMSTransporte = New Janus.Windows.EditControls.UIComboBox()
        Me.cb = New System.Windows.Forms.Label()
        Me.txtValorServicoTransporte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorServicoTransporte = New System.Windows.Forms.Label()
        Me.txtAliquotaTransporte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaTransporte = New System.Windows.Forms.Label()
        Me.txtBaseCalculoTransporte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblICMSRetidoTransporte = New System.Windows.Forms.Label()
        Me.lblBaseCalculoTransporte = New System.Windows.Forms.Label()
        Me.pagVeiculo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpReboque = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirReboque = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirReboque = New Janus.Windows.EditControls.UIButton()
        Me.lblRNTCReboque = New System.Windows.Forms.Label()
        Me.txtRNTCReboque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboUFReboque = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUFReboque = New System.Windows.Forms.Label()
        Me.txtPlacaReboque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlacaReboque = New System.Windows.Forms.Label()
        Me.grpVeiculo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRNTCVeiculo = New System.Windows.Forms.Label()
        Me.txtRNTCVeiculo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboUFVeiculo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUFVeiculo = New System.Windows.Forms.Label()
        Me.txtPlacaVeiculo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlacaVeiculo = New System.Windows.Forms.Label()
        Me.grdReboque = New Janus.Windows.GridEX.GridEX()
        Me.grpBalsaoVagao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblVagao = New System.Windows.Forms.Label()
        Me.txtVagao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBalsa = New System.Windows.Forms.Label()
        Me.txtBalsa = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpTipoVeiculo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoVeiculo = New System.Windows.Forms.Label()
        Me.cboTipoVeiculo = New Janus.Windows.EditControls.UIComboBox()
        Me.pagVolume = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdVolume = New Janus.Windows.GridEX.GridEX()
        Me.grpVolume = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirVolume = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirVolume = New Janus.Windows.EditControls.UIButton()
        Me.txtPesoLiquidoTransportadora = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPesoBrutoTransportadora = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPesoLiquidoTransportadora = New System.Windows.Forms.Label()
        Me.lblPesoBrutoTransportadora = New System.Windows.Forms.Label()
        Me.txtNumeroTransportadora = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroTransportadora = New System.Windows.Forms.Label()
        Me.txtMarcaTransportadora = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarcaTransportadora = New System.Windows.Forms.Label()
        Me.txtEspecieTransportadora = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEspecieTransportadora = New System.Windows.Forms.Label()
        Me.txtQuantidadeEmbalagemTransportadora = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeEmbalagemTransportadora = New System.Windows.Forms.Label()
        Me.pagTotais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTotalICMSDestino = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalICMSDestino = New System.Windows.Forms.Label()
        Me.txtTotalICMSRemetente = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalICMSRemetente = New System.Windows.Forms.Label()
        Me.txtTotalFCP = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalFCP = New System.Windows.Forms.Label()
        Me.txtTotalNotaFiscal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalNotaFiscal = New System.Windows.Forms.Label()
        Me.txtOutrasDespesas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblOutrasDespesas = New System.Windows.Forms.Label()
        Me.txtTotalCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalCOFINS = New System.Windows.Forms.Label()
        Me.txtTotalPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalPIS = New System.Windows.Forms.Label()
        Me.txtTotalIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalIPI = New System.Windows.Forms.Label()
        Me.txtTotalII = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalII = New System.Windows.Forms.Label()
        Me.txtTotalDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalDesconto = New System.Windows.Forms.Label()
        Me.txtTotalSeguro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalSeguro = New System.Windows.Forms.Label()
        Me.txtTotalFrete = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalFrete = New System.Windows.Forms.Label()
        Me.txtTotalProdutoServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalProdutoServico = New System.Windows.Forms.Label()
        Me.txtTotalICMSST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalICMSST = New System.Windows.Forms.Label()
        Me.txtBaseCalculoICMSST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMSST = New System.Windows.Forms.Label()
        Me.txtTotalICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalICMS = New System.Windows.Forms.Label()
        Me.txtBaseCalculoICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMS = New System.Windows.Forms.Label()
        Me.pagCobranca = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpTituloPrevisto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTituloDescritivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTituloDescritivo = New System.Windows.Forms.Label()
        Me.btnProcurarCentroCusto = New System.Windows.Forms.Button()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.btnVincular = New Janus.Windows.EditControls.UIButton()
        Me.txtNumDocumentoPrevisto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTituloPrevisto = New System.Windows.Forms.Label()
        Me.txtValorPrevisto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboTituloPrevisto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTituloValor = New System.Windows.Forms.Label()
        Me.lblTituloNumeroDocumento = New System.Windows.Forms.Label()
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
        Me.txtValorPago = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorPago = New System.Windows.Forms.Label()
        Me.txtValorAcrescimo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorAcrescimo = New System.Windows.Forms.Label()
        Me.txtValorLiquido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorLiquido = New System.Windows.Forms.Label()
        Me.txtValorDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDesconto = New System.Windows.Forms.Label()
        Me.txtValorOriginal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOriginal = New System.Windows.Forms.Label()
        Me.txtFatura = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFatura = New System.Windows.Forms.Label()
        Me.pagInformacoesAdicionais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacaoAdicional = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDadosAdicionaisFISCO = New System.Windows.Forms.Label()
        Me.txtInformacaoAdicionalFisco = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDadosAdicionaisContribuinte = New System.Windows.Forms.Label()
        Me.txtInformacaoAdicionalContribuinte = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagExportacaoCompras = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCompra = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblInformacaoContrato = New System.Windows.Forms.Label()
        Me.txtInformacaoContrato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInformacaoPedido = New System.Windows.Forms.Label()
        Me.txtInformacaoPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaEmpenho = New System.Windows.Forms.Label()
        Me.txtNotaEmpenho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpExportacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLocalEmbarque = New System.Windows.Forms.Label()
        Me.txtLocalEmbarque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboUFEmbarque = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUFEmbarque = New System.Windows.Forms.Label()
        Me.pagArquivos = New Janus.Windows.UI.Tab.UITabPage()
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
        Me.pagProdutoXML = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFindCFOPDestinacao = New System.Windows.Forms.Button()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UiComboBox1 = New Janus.Windows.EditControls.UIComboBox()
        Me.btnAtualizarPedidoCompra = New System.Windows.Forms.Button()
        Me.lblQuantidadeDocumento = New System.Windows.Forms.Label()
        Me.txtQuantidadeDocumento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.txtQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDataFabricacao = New System.Windows.Forms.Label()
        Me.dtpDataFabricacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.lblDataValidade = New System.Windows.Forms.Label()
        Me.dtpDataValidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarCFOP = New System.Windows.Forms.Button()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFatorConversao = New System.Windows.Forms.Label()
        Me.txtFatorConversao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.btnExcluirXML = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarDeposito = New System.Windows.Forms.Button()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.cboNumeroDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTipoOperacao = New System.Windows.Forms.Label()
        Me.cboTipoOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.grdRecebimento = New Janus.Windows.GridEX.GridEX()
        Me.grpControleDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaICMSUltimaNF = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPISCOFINSPedido = New System.Windows.Forms.Label()
        Me.txtAliquotaPISCOFINSPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIPIPedido = New System.Windows.Forms.Label()
        Me.txtAliquotaIPIPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMSPedido = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitarioPedido = New System.Windows.Forms.Label()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.txtValorUnitarioPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.lblAliquotaICMSUltimaNF = New System.Windows.Forms.Label()
        Me.grdXML = New Janus.Windows.GridEX.GridEX()
        Me.txtTeste = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaEnviadoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDadosNF.SuspendLayout()
        CType(Me.grpDadosDACTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosDACTE.SuspendLayout()
        CType(Me.grpTipoNotaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipoNotaFiscal.SuspendLayout()
        CType(Me.grpDadosNFe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosNFe.SuspendLayout()
        CType(Me.grpDadosNF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosNF.SuspendLayout()
        Me.pagEmitente.SuspendLayout()
        CType(Me.grpLocalRetiradaEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLocalRetiradaEntrega.SuspendLayout()
        CType(Me.grpEmitente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmitente.SuspendLayout()
        CType(Me.grpEnderecoDestinatario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnderecoDestinatario.SuspendLayout()
        Me.pagProduto.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagTransporte.SuspendLayout()
        CType(Me.tabTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransporte.SuspendLayout()
        Me.pagTransportador.SuspendLayout()
        CType(Me.grpTransportador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTransportador.SuspendLayout()
        Me.pagRetencaoICMS.SuspendLayout()
        CType(Me.grpRetencaoICMSTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRetencaoICMSTransporte.SuspendLayout()
        Me.pagVeiculo.SuspendLayout()
        CType(Me.grpReboque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReboque.SuspendLayout()
        CType(Me.grpVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVeiculo.SuspendLayout()
        CType(Me.grdReboque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpBalsaoVagao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBalsaoVagao.SuspendLayout()
        CType(Me.grpTipoVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipoVeiculo.SuspendLayout()
        Me.pagVolume.SuspendLayout()
        CType(Me.grdVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVolume.SuspendLayout()
        Me.pagTotais.SuspendLayout()
        CType(Me.grpICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMS.SuspendLayout()
        Me.pagCobranca.SuspendLayout()
        CType(Me.grpTituloPrevisto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTituloPrevisto.SuspendLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDuplicata.SuspendLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFatura.SuspendLayout()
        Me.pagInformacoesAdicionais.SuspendLayout()
        CType(Me.grpInformacaoAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacaoAdicional.SuspendLayout()
        Me.pagExportacaoCompras.SuspendLayout()
        CType(Me.grpCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCompra.SuspendLayout()
        CType(Me.grpExportacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExportacao.SuspendLayout()
        Me.pagArquivos.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagProdutoXML.SuspendLayout()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
        CType(Me.grdRecebimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleDados.SuspendLayout()
        CType(Me.grdXML, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControle)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Entrada - Nota Fiscal"
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
        Me.grpLegenda.Controls.Add(Me.lblLegendaEmDigitacao)
        Me.grpLegenda.Controls.Add(Me.picLegendaEnviadoCliente)
        Me.grpLegenda.Controls.Add(Me.picLegendaAutozidadaParaUso)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCancelada)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAutozidadaParaUso)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(259, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaEmDigitacao
        '
        Me.lblLegendaEmDigitacao.AutoSize = True
        Me.lblLegendaEmDigitacao.Location = New System.Drawing.Point(28, 30)
        Me.lblLegendaEmDigitacao.Name = "lblLegendaEmDigitacao"
        Me.lblLegendaEmDigitacao.Size = New System.Drawing.Size(68, 14)
        Me.lblLegendaEmDigitacao.TabIndex = 19
        Me.lblLegendaEmDigitacao.Text = "Em Digitação"
        '
        'picLegendaEnviadoCliente
        '
        Me.picLegendaEnviadoCliente.BackColor = System.Drawing.Color.DarkMagenta
        Me.picLegendaEnviadoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEnviadoCliente.Location = New System.Drawing.Point(9, 30)
        Me.picLegendaEnviadoCliente.Name = "picLegendaEnviadoCliente"
        Me.picLegendaEnviadoCliente.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEnviadoCliente.TabIndex = 20
        Me.picLegendaEnviadoCliente.TabStop = False
        '
        'picLegendaAutozidadaParaUso
        '
        Me.picLegendaAutozidadaParaUso.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaAutozidadaParaUso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAutozidadaParaUso.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaAutozidadaParaUso.Name = "picLegendaAutozidadaParaUso"
        Me.picLegendaAutozidadaParaUso.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAutozidadaParaUso.TabIndex = 16
        Me.picLegendaAutozidadaParaUso.TabStop = False
        '
        'lblLegendaCancelada
        '
        Me.lblLegendaCancelada.AutoSize = True
        Me.lblLegendaCancelada.Location = New System.Drawing.Point(185, 13)
        Me.lblLegendaCancelada.Name = "lblLegendaCancelada"
        Me.lblLegendaCancelada.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelada.TabIndex = 1
        Me.lblLegendaCancelada.Text = "Cancelada"
        '
        'picLegendaCancelada
        '
        Me.picLegendaCancelada.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelada.Location = New System.Drawing.Point(166, 13)
        Me.picLegendaCancelada.Name = "picLegendaCancelada"
        Me.picLegendaCancelada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelada.TabIndex = 14
        Me.picLegendaCancelada.TabStop = False
        '
        'lblLegendaAutozidadaParaUso
        '
        Me.lblLegendaAutozidadaParaUso.AutoSize = True
        Me.lblLegendaAutozidadaParaUso.Location = New System.Drawing.Point(28, 13)
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
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
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
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 157)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 323)
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
        Me.grpFiltro.Controls.Add(Me.lblTipoOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEntradaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblTipoOperacaoFiltro
        '
        Me.lblTipoOperacaoFiltro.AutoSize = True
        Me.lblTipoOperacaoFiltro.Location = New System.Drawing.Point(116, 97)
        Me.lblTipoOperacaoFiltro.Name = "lblTipoOperacaoFiltro"
        Me.lblTipoOperacaoFiltro.Size = New System.Drawing.Size(96, 14)
        Me.lblTipoOperacaoFiltro.TabIndex = 18
        Me.lblTipoOperacaoFiltro.Text = "Tipo de Operação:"
        '
        'cboTipoOperacaoFiltro
        '
        Me.cboTipoOperacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoOperacaoFiltro.Location = New System.Drawing.Point(119, 114)
        Me.cboTipoOperacaoFiltro.Name = "cboTipoOperacaoFiltro"
        Me.cboTipoOperacaoFiltro.Size = New System.Drawing.Size(189, 20)
        Me.cboTipoOperacaoFiltro.TabIndex = 19
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
        Me.dtpDataEntradaInicioFiltro.TabIndex = 14
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
        Me.dtpDataEntradaTerminoFiltro.TabIndex = 15
        Me.dtpDataEntradaTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntradaFiltro
        '
        Me.lblDataEntradaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEntradaFiltro.AutoSize = True
        Me.lblDataEntradaFiltro.Location = New System.Drawing.Point(549, 57)
        Me.lblDataEntradaFiltro.Name = "lblDataEntradaFiltro"
        Me.lblDataEntradaFiltro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaFiltro.TabIndex = 13
        Me.lblDataEntradaFiltro.Text = "Data Entrada:"
        '
        'txtLoteFiltro
        '
        Me.txtLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteFiltro.Location = New System.Drawing.Point(428, 74)
        Me.txtLoteFiltro.MaxLength = 50
        Me.txtLoteFiltro.Name = "txtLoteFiltro"
        Me.txtLoteFiltro.Size = New System.Drawing.Size(118, 20)
        Me.txtLoteFiltro.TabIndex = 12
        '
        'lblLoteFiltro
        '
        Me.lblLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoteFiltro.AutoSize = True
        Me.lblLoteFiltro.Location = New System.Drawing.Point(425, 57)
        Me.lblLoteFiltro.Name = "lblLoteFiltro"
        Me.lblLoteFiltro.Size = New System.Drawing.Size(31, 14)
        Me.lblLoteFiltro.TabIndex = 11
        Me.lblLoteFiltro.Text = "Lote:"
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 9
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtProdutoFiltro.MaxLength = 120
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(413, 20)
        Me.txtProdutoFiltro.TabIndex = 10
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(314, 114)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroDocumentoFiltro.TabIndex = 21
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(311, 97)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoFiltro.TabIndex = 20
        Me.lblNumeroDocumentoFiltro.Text = "Nº Documento:"
        '
        'cboCFOPFiltro
        '
        Me.cboCFOPFiltro.AllowDrop = True
        Me.cboCFOPFiltro.ButtonCancelText = "Cancelar"
        Me.cboCFOPFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboCFOPFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboCFOPFiltro_DesignTimeLayout.LayoutString")
        Me.cboCFOPFiltro.DesignTimeLayout = cboCFOPFiltro_DesignTimeLayout
        Me.cboCFOPFiltro.Location = New System.Drawing.Point(9, 114)
        Me.cboCFOPFiltro.Name = "cboCFOPFiltro"
        Me.cboCFOPFiltro.SaveSettings = False
        Me.cboCFOPFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboCFOPFiltro.Size = New System.Drawing.Size(104, 20)
        Me.cboCFOPFiltro.TabIndex = 17
        Me.cboCFOPFiltro.ValuesDataMember = Nothing
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(428, 114)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(346, 20)
        Me.cboStatusFiltro.TabIndex = 23
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(425, 97)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 22
        Me.lblStatusFiltro.Text = "Status:"
        '
        'lblCFOPFiltro
        '
        Me.lblCFOPFiltro.AutoSize = True
        Me.lblCFOPFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblCFOPFiltro.Name = "lblCFOPFiltro"
        Me.lblCFOPFiltro.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOPFiltro.TabIndex = 16
        Me.lblCFOPFiltro.Text = "CFOP:"
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
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
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
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtEmitenteFiltro
        '
        Me.txtEmitenteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmitenteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitenteFiltro.Location = New System.Drawing.Point(185, 34)
        Me.txtEmitenteFiltro.MaxLength = 60
        Me.txtEmitenteFiltro.Name = "txtEmitenteFiltro"
        Me.txtEmitenteFiltro.Size = New System.Drawing.Size(361, 20)
        Me.txtEmitenteFiltro.TabIndex = 5
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
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 24
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
        Me.lblDataEmissaoFiltro.TabIndex = 6
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'lblEmitenteFiltro
        '
        Me.lblEmitenteFiltro.AutoSize = True
        Me.lblEmitenteFiltro.Location = New System.Drawing.Point(182, 17)
        Me.lblEmitenteFiltro.Name = "lblEmitenteFiltro"
        Me.lblEmitenteFiltro.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitenteFiltro.TabIndex = 4
        Me.lblEmitenteFiltro.Text = "Emitente:"
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
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnGerarXML)
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(273, 483)
        Me.grpControle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(632, 51)
        Me.grpControle.TabIndex = 6
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnGerarXML
        '
        Me.btnGerarXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarXML.Image = Global.INTERACTI.My.Resources.Resources.xml
        Me.btnGerarXML.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarXML.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnGerarXML.Location = New System.Drawing.Point(241, 17)
        Me.btnGerarXML.Name = "btnGerarXML"
        Me.btnGerarXML.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarXML.Size = New System.Drawing.Size(91, 23)
        Me.btnGerarXML.TabIndex = 3
        Me.btnGerarXML.Text = "Gerar XML"
        Me.btnGerarXML.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(338, 17)
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
        Me.btnExcluir.Location = New System.Drawing.Point(435, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(532, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Entrada - Nota Fiscal"
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
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosNF, Me.pagEmitente, Me.pagProduto, Me.pagTransporte, Me.pagTotais, Me.pagCobranca, Me.pagInformacoesAdicionais, Me.pagExportacaoCompras, Me.pagArquivos, Me.pagProdutoXML})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDadosNF
        '
        Me.pagDadosNF.Controls.Add(Me.btnInserirNFFatura)
        Me.pagDadosNF.Controls.Add(Me.grpDadosDACTE)
        Me.pagDadosNF.Controls.Add(Me.grpTipoNotaFiscal)
        Me.pagDadosNF.Controls.Add(Me.grpDadosNFe)
        Me.pagDadosNF.Controls.Add(Me.grpDadosNF)
        Me.pagDadosNF.Key = "pagDadosNFe"
        Me.pagDadosNF.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosNF.Name = "pagDadosNF"
        Me.pagDadosNF.Size = New System.Drawing.Size(895, 450)
        Me.pagDadosNF.TabStop = True
        Me.pagDadosNF.Text = "Dados da Nota Fiscal"
        '
        'btnInserirNFFatura
        '
        Me.btnInserirNFFatura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirNFFatura.Image = CType(resources.GetObject("btnInserirNFFatura.Image"), System.Drawing.Image)
        Me.btnInserirNFFatura.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirNFFatura.Location = New System.Drawing.Point(742, 414)
        Me.btnInserirNFFatura.Name = "btnInserirNFFatura"
        Me.btnInserirNFFatura.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirNFFatura.Size = New System.Drawing.Size(145, 23)
        Me.btnInserirNFFatura.TabIndex = 4
        Me.btnInserirNFFatura.Text = "Inserir NF Fatura"
        Me.btnInserirNFFatura.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDadosDACTE
        '
        Me.grpDadosDACTE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosDACTE.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosDACTE.Controls.Add(Me.txtChaveAcessoDACTE)
        Me.grpDadosDACTE.Controls.Add(Me.lblChaveAcessoDACTE)
        Me.grpDadosDACTE.Enabled = False
        Me.grpDadosDACTE.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosDACTE.Location = New System.Drawing.Point(8, 244)
        Me.grpDadosDACTE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosDACTE.Name = "grpDadosDACTE"
        Me.grpDadosDACTE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosDACTE.Size = New System.Drawing.Size(879, 64)
        Me.grpDadosDACTE.TabIndex = 3
        Me.grpDadosDACTE.Text = "Dados do Conhecimento Eletrônico"
        Me.grpDadosDACTE.VisualStyleManager = Me.vsmMain
        '
        'txtChaveAcessoDACTE
        '
        Me.txtChaveAcessoDACTE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChaveAcessoDACTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChaveAcessoDACTE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveAcessoDACTE.Location = New System.Drawing.Point(9, 34)
        Me.txtChaveAcessoDACTE.MaxLength = 50
        Me.txtChaveAcessoDACTE.Name = "txtChaveAcessoDACTE"
        Me.txtChaveAcessoDACTE.Size = New System.Drawing.Size(409, 20)
        Me.txtChaveAcessoDACTE.TabIndex = 1
        '
        'lblChaveAcessoDACTE
        '
        Me.lblChaveAcessoDACTE.AutoSize = True
        Me.lblChaveAcessoDACTE.Location = New System.Drawing.Point(6, 17)
        Me.lblChaveAcessoDACTE.Name = "lblChaveAcessoDACTE"
        Me.lblChaveAcessoDACTE.Size = New System.Drawing.Size(96, 14)
        Me.lblChaveAcessoDACTE.TabIndex = 0
        Me.lblChaveAcessoDACTE.Text = "Chave de Acesso:"
        '
        'grpTipoNotaFiscal
        '
        Me.grpTipoNotaFiscal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTipoNotaFiscal.BackColor = System.Drawing.Color.Transparent
        Me.grpTipoNotaFiscal.Controls.Add(Me.txtEspecie)
        Me.grpTipoNotaFiscal.Controls.Add(Me.lblEspecie)
        Me.grpTipoNotaFiscal.Controls.Add(Me.lblTipoNotaFiscal)
        Me.grpTipoNotaFiscal.Controls.Add(Me.cboTipoNotaFiscal)
        Me.grpTipoNotaFiscal.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpTipoNotaFiscal.Location = New System.Drawing.Point(8, 3)
        Me.grpTipoNotaFiscal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpTipoNotaFiscal.Name = "grpTipoNotaFiscal"
        Me.grpTipoNotaFiscal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTipoNotaFiscal.Size = New System.Drawing.Size(879, 64)
        Me.grpTipoNotaFiscal.TabIndex = 0
        Me.grpTipoNotaFiscal.Text = "Identificação"
        Me.grpTipoNotaFiscal.VisualStyleManager = Me.vsmMain
        '
        'txtEspecie
        '
        Me.txtEspecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspecie.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspecie.Location = New System.Drawing.Point(177, 34)
        Me.txtEspecie.MaxLength = 50
        Me.txtEspecie.Name = "txtEspecie"
        Me.txtEspecie.Size = New System.Drawing.Size(52, 20)
        Me.txtEspecie.TabIndex = 3
        Me.txtEspecie.TabStop = False
        Me.txtEspecie.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblEspecie
        '
        Me.lblEspecie.AutoSize = True
        Me.lblEspecie.Location = New System.Drawing.Point(174, 17)
        Me.lblEspecie.Name = "lblEspecie"
        Me.lblEspecie.Size = New System.Drawing.Size(48, 14)
        Me.lblEspecie.TabIndex = 2
        Me.lblEspecie.Text = "Espécie:"
        '
        'lblTipoNotaFiscal
        '
        Me.lblTipoNotaFiscal.AutoSize = True
        Me.lblTipoNotaFiscal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblTipoNotaFiscal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTipoNotaFiscal.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoNotaFiscal.Name = "lblTipoNotaFiscal"
        Me.lblTipoNotaFiscal.Size = New System.Drawing.Size(101, 14)
        Me.lblTipoNotaFiscal.TabIndex = 0
        Me.lblTipoNotaFiscal.Text = "Tipo de Nota Fiscal:"
        '
        'cboTipoNotaFiscal
        '
        Me.cboTipoNotaFiscal.AutoSize = False
        Me.cboTipoNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoNotaFiscal.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cboTipoNotaFiscal.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoNotaFiscal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoNotaFiscal.Name = "cboTipoNotaFiscal"
        Me.cboTipoNotaFiscal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoNotaFiscal.Size = New System.Drawing.Size(162, 20)
        Me.cboTipoNotaFiscal.TabIndex = 1
        '
        'grpDadosNFe
        '
        Me.grpDadosNFe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosNFe.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosNFe.Controls.Add(Me.dtpDataEntradaNFe)
        Me.grpDadosNFe.Controls.Add(Me.txtStatusNFe)
        Me.grpDadosNFe.Controls.Add(Me.lblStatusNFe)
        Me.grpDadosNFe.Controls.Add(Me.txtNumeroProtocoloNFe)
        Me.grpDadosNFe.Controls.Add(Me.lblNumeroProtocoloNFe)
        Me.grpDadosNFe.Controls.Add(Me.txtChaveAcessoNFe)
        Me.grpDadosNFe.Controls.Add(Me.lblChaveAcessoNFe)
        Me.grpDadosNFe.Controls.Add(Me.lblDataEntradaNFe)
        Me.grpDadosNFe.Controls.Add(Me.txtDataEmissaoNFe)
        Me.grpDadosNFe.Controls.Add(Me.lblDataEmissaoNFe)
        Me.grpDadosNFe.Controls.Add(Me.txtSerieNFe)
        Me.grpDadosNFe.Controls.Add(Me.lblSerieNFe)
        Me.grpDadosNFe.Controls.Add(Me.txtNumeroNFe)
        Me.grpDadosNFe.Controls.Add(Me.lblNumeroNFe)
        Me.grpDadosNFe.Controls.Add(Me.btnArquivoNFe)
        Me.grpDadosNFe.Controls.Add(Me.txtArquivoNFe)
        Me.grpDadosNFe.Controls.Add(Me.lblArquivoNFe)
        Me.grpDadosNFe.Enabled = False
        Me.grpDadosNFe.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosNFe.Location = New System.Drawing.Point(8, 137)
        Me.grpDadosNFe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosNFe.Name = "grpDadosNFe"
        Me.grpDadosNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosNFe.Size = New System.Drawing.Size(879, 104)
        Me.grpDadosNFe.TabIndex = 2
        Me.grpDadosNFe.Text = "Dados da Nota Fiscal Eletrônica"
        Me.grpDadosNFe.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEntradaNFe
        '
        Me.dtpDataEntradaNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDataEntradaNFe.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpDataEntradaNFe.DropDownCalendar.Name = ""
        Me.dtpDataEntradaNFe.Location = New System.Drawing.Point(720, 34)
        Me.dtpDataEntradaNFe.Name = "dtpDataEntradaNFe"
        Me.dtpDataEntradaNFe.Size = New System.Drawing.Size(150, 20)
        Me.dtpDataEntradaNFe.TabIndex = 10
        Me.dtpDataEntradaNFe.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtStatusNFe
        '
        Me.txtStatusNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatusNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStatusNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatusNFe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusNFe.Location = New System.Drawing.Point(617, 74)
        Me.txtStatusNFe.MaxLength = 50
        Me.txtStatusNFe.Name = "txtStatusNFe"
        Me.txtStatusNFe.ReadOnly = True
        Me.txtStatusNFe.Size = New System.Drawing.Size(253, 20)
        Me.txtStatusNFe.TabIndex = 16
        Me.txtStatusNFe.TabStop = False
        '
        'lblStatusNFe
        '
        Me.lblStatusNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusNFe.AutoSize = True
        Me.lblStatusNFe.Location = New System.Drawing.Point(614, 57)
        Me.lblStatusNFe.Name = "lblStatusNFe"
        Me.lblStatusNFe.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusNFe.TabIndex = 15
        Me.lblStatusNFe.Text = "Status:"
        '
        'txtNumeroProtocoloNFe
        '
        Me.txtNumeroProtocoloNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroProtocoloNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroProtocoloNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroProtocoloNFe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroProtocoloNFe.Location = New System.Drawing.Point(424, 74)
        Me.txtNumeroProtocoloNFe.MaxLength = 50
        Me.txtNumeroProtocoloNFe.Name = "txtNumeroProtocoloNFe"
        Me.txtNumeroProtocoloNFe.ReadOnly = True
        Me.txtNumeroProtocoloNFe.Size = New System.Drawing.Size(187, 20)
        Me.txtNumeroProtocoloNFe.TabIndex = 14
        Me.txtNumeroProtocoloNFe.TabStop = False
        '
        'lblNumeroProtocoloNFe
        '
        Me.lblNumeroProtocoloNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroProtocoloNFe.AutoSize = True
        Me.lblNumeroProtocoloNFe.Location = New System.Drawing.Point(421, 57)
        Me.lblNumeroProtocoloNFe.Name = "lblNumeroProtocoloNFe"
        Me.lblNumeroProtocoloNFe.Size = New System.Drawing.Size(69, 14)
        Me.lblNumeroProtocoloNFe.TabIndex = 13
        Me.lblNumeroProtocoloNFe.Text = "N° Protocolo:"
        '
        'txtChaveAcessoNFe
        '
        Me.txtChaveAcessoNFe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChaveAcessoNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtChaveAcessoNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChaveAcessoNFe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChaveAcessoNFe.Location = New System.Drawing.Point(9, 74)
        Me.txtChaveAcessoNFe.MaxLength = 50
        Me.txtChaveAcessoNFe.Name = "txtChaveAcessoNFe"
        Me.txtChaveAcessoNFe.ReadOnly = True
        Me.txtChaveAcessoNFe.Size = New System.Drawing.Size(409, 20)
        Me.txtChaveAcessoNFe.TabIndex = 12
        Me.txtChaveAcessoNFe.TabStop = False
        '
        'lblChaveAcessoNFe
        '
        Me.lblChaveAcessoNFe.AutoSize = True
        Me.lblChaveAcessoNFe.Location = New System.Drawing.Point(6, 57)
        Me.lblChaveAcessoNFe.Name = "lblChaveAcessoNFe"
        Me.lblChaveAcessoNFe.Size = New System.Drawing.Size(96, 14)
        Me.lblChaveAcessoNFe.TabIndex = 11
        Me.lblChaveAcessoNFe.Text = "Chave de Acesso:"
        '
        'lblDataEntradaNFe
        '
        Me.lblDataEntradaNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEntradaNFe.AutoSize = True
        Me.lblDataEntradaNFe.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDataEntradaNFe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDataEntradaNFe.Location = New System.Drawing.Point(717, 17)
        Me.lblDataEntradaNFe.Name = "lblDataEntradaNFe"
        Me.lblDataEntradaNFe.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaNFe.TabIndex = 9
        Me.lblDataEntradaNFe.Text = "Data Entrada:"
        '
        'txtDataEmissaoNFe
        '
        Me.txtDataEmissaoNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataEmissaoNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissaoNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissaoNFe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataEmissaoNFe.Location = New System.Drawing.Point(617, 34)
        Me.txtDataEmissaoNFe.MaxLength = 50
        Me.txtDataEmissaoNFe.Name = "txtDataEmissaoNFe"
        Me.txtDataEmissaoNFe.ReadOnly = True
        Me.txtDataEmissaoNFe.Size = New System.Drawing.Size(97, 20)
        Me.txtDataEmissaoNFe.TabIndex = 8
        Me.txtDataEmissaoNFe.TabStop = False
        Me.txtDataEmissaoNFe.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblDataEmissaoNFe
        '
        Me.lblDataEmissaoNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEmissaoNFe.AutoSize = True
        Me.lblDataEmissaoNFe.Location = New System.Drawing.Point(614, 17)
        Me.lblDataEmissaoNFe.Name = "lblDataEmissaoNFe"
        Me.lblDataEmissaoNFe.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoNFe.TabIndex = 7
        Me.lblDataEmissaoNFe.Text = "Data Emissão:"
        '
        'txtSerieNFe
        '
        Me.txtSerieNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSerieNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSerieNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieNFe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieNFe.Location = New System.Drawing.Point(559, 34)
        Me.txtSerieNFe.MaxLength = 50
        Me.txtSerieNFe.Name = "txtSerieNFe"
        Me.txtSerieNFe.ReadOnly = True
        Me.txtSerieNFe.Size = New System.Drawing.Size(52, 20)
        Me.txtSerieNFe.TabIndex = 6
        Me.txtSerieNFe.TabStop = False
        Me.txtSerieNFe.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblSerieNFe
        '
        Me.lblSerieNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSerieNFe.AutoSize = True
        Me.lblSerieNFe.Location = New System.Drawing.Point(556, 17)
        Me.lblSerieNFe.Name = "lblSerieNFe"
        Me.lblSerieNFe.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieNFe.TabIndex = 5
        Me.lblSerieNFe.Text = "Série:"
        '
        'txtNumeroNFe
        '
        Me.txtNumeroNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroNFe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroNFe.Location = New System.Drawing.Point(424, 34)
        Me.txtNumeroNFe.MaxLength = 50
        Me.txtNumeroNFe.Name = "txtNumeroNFe"
        Me.txtNumeroNFe.ReadOnly = True
        Me.txtNumeroNFe.Size = New System.Drawing.Size(129, 20)
        Me.txtNumeroNFe.TabIndex = 4
        Me.txtNumeroNFe.TabStop = False
        Me.txtNumeroNFe.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroNFe
        '
        Me.lblNumeroNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroNFe.AutoSize = True
        Me.lblNumeroNFe.Location = New System.Drawing.Point(421, 17)
        Me.lblNumeroNFe.Name = "lblNumeroNFe"
        Me.lblNumeroNFe.Size = New System.Drawing.Size(63, 14)
        Me.lblNumeroNFe.TabIndex = 3
        Me.lblNumeroNFe.Text = "Nota Fiscal:"
        '
        'btnArquivoNFe
        '
        Me.btnArquivoNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivoNFe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivoNFe.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnArquivoNFe.Location = New System.Drawing.Point(398, 34)
        Me.btnArquivoNFe.Name = "btnArquivoNFe"
        Me.btnArquivoNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivoNFe.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivoNFe.TabIndex = 2
        Me.btnArquivoNFe.Text = "..."
        Me.btnArquivoNFe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtArquivoNFe
        '
        Me.txtArquivoNFe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivoNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivoNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivoNFe.Location = New System.Drawing.Point(9, 34)
        Me.txtArquivoNFe.MaxLength = 60
        Me.txtArquivoNFe.Name = "txtArquivoNFe"
        Me.txtArquivoNFe.ReadOnly = True
        Me.txtArquivoNFe.Size = New System.Drawing.Size(390, 20)
        Me.txtArquivoNFe.TabIndex = 1
        Me.txtArquivoNFe.TabStop = False
        '
        'lblArquivoNFe
        '
        Me.lblArquivoNFe.AutoSize = True
        Me.lblArquivoNFe.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblArquivoNFe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblArquivoNFe.Location = New System.Drawing.Point(6, 17)
        Me.lblArquivoNFe.Name = "lblArquivoNFe"
        Me.lblArquivoNFe.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivoNFe.TabIndex = 0
        Me.lblArquivoNFe.Text = "Arquivo:"
        '
        'grpDadosNF
        '
        Me.grpDadosNF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosNF.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosNF.Controls.Add(Me.dtpDataEntradaNF)
        Me.grpDadosNF.Controls.Add(Me.dtpDataEmissaoNF)
        Me.grpDadosNF.Controls.Add(Me.lblDataEntradaNF)
        Me.grpDadosNF.Controls.Add(Me.lblDataEmissaoNF)
        Me.grpDadosNF.Controls.Add(Me.txtSerieNF)
        Me.grpDadosNF.Controls.Add(Me.lblSerieNF)
        Me.grpDadosNF.Controls.Add(Me.txtNumeroNF)
        Me.grpDadosNF.Controls.Add(Me.lblNumeroNF)
        Me.grpDadosNF.Enabled = False
        Me.grpDadosNF.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosNF.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosNF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosNF.Name = "grpDadosNF"
        Me.grpDadosNF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosNF.Size = New System.Drawing.Size(879, 64)
        Me.grpDadosNF.TabIndex = 1
        Me.grpDadosNF.Text = "Dados da Nota Fiscal"
        Me.grpDadosNF.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEntradaNF
        '
        Me.dtpDataEntradaNF.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpDataEntradaNF.DropDownCalendar.Name = ""
        Me.dtpDataEntradaNF.Location = New System.Drawing.Point(275, 34)
        Me.dtpDataEntradaNF.Name = "dtpDataEntradaNF"
        Me.dtpDataEntradaNF.Size = New System.Drawing.Size(143, 20)
        Me.dtpDataEntradaNF.TabIndex = 7
        Me.dtpDataEntradaNF.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoNF
        '
        '
        '
        '
        Me.dtpDataEmissaoNF.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoNF.Location = New System.Drawing.Point(177, 34)
        Me.dtpDataEmissaoNF.Name = "dtpDataEmissaoNF"
        Me.dtpDataEmissaoNF.Size = New System.Drawing.Size(92, 20)
        Me.dtpDataEmissaoNF.TabIndex = 5
        Me.dtpDataEmissaoNF.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntradaNF
        '
        Me.lblDataEntradaNF.AutoSize = True
        Me.lblDataEntradaNF.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDataEntradaNF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDataEntradaNF.Location = New System.Drawing.Point(272, 17)
        Me.lblDataEntradaNF.Name = "lblDataEntradaNF"
        Me.lblDataEntradaNF.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaNF.TabIndex = 6
        Me.lblDataEntradaNF.Text = "Data Entrada:"
        '
        'lblDataEmissaoNF
        '
        Me.lblDataEmissaoNF.AutoSize = True
        Me.lblDataEmissaoNF.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDataEmissaoNF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDataEmissaoNF.Location = New System.Drawing.Point(174, 17)
        Me.lblDataEmissaoNF.Name = "lblDataEmissaoNF"
        Me.lblDataEmissaoNF.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoNF.TabIndex = 4
        Me.lblDataEmissaoNF.Text = "Data Emissão:"
        '
        'txtSerieNF
        '
        Me.txtSerieNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieNF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieNF.Location = New System.Drawing.Point(119, 34)
        Me.txtSerieNF.MaxLength = 50
        Me.txtSerieNF.Name = "txtSerieNF"
        Me.txtSerieNF.Size = New System.Drawing.Size(52, 20)
        Me.txtSerieNF.TabIndex = 3
        Me.txtSerieNF.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblSerieNF
        '
        Me.lblSerieNF.AutoSize = True
        Me.lblSerieNF.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblSerieNF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSerieNF.Location = New System.Drawing.Point(116, 17)
        Me.lblSerieNF.Name = "lblSerieNF"
        Me.lblSerieNF.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieNF.TabIndex = 2
        Me.lblSerieNF.Text = "Série:"
        '
        'txtNumeroNF
        '
        Me.txtNumeroNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroNF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroNF.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroNF.MaxLength = 50
        Me.txtNumeroNF.Name = "txtNumeroNF"
        Me.txtNumeroNF.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroNF.TabIndex = 1
        Me.txtNumeroNF.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroNF
        '
        Me.lblNumeroNF.AutoSize = True
        Me.lblNumeroNF.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNumeroNF.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNumeroNF.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroNF.Name = "lblNumeroNF"
        Me.lblNumeroNF.Size = New System.Drawing.Size(63, 14)
        Me.lblNumeroNF.TabIndex = 0
        Me.lblNumeroNF.Text = "Nota Fiscal:"
        '
        'pagEmitente
        '
        Me.pagEmitente.Controls.Add(Me.grpLocalRetiradaEntrega)
        Me.pagEmitente.Controls.Add(Me.grpEmitente)
        Me.pagEmitente.Controls.Add(Me.grpEnderecoDestinatario)
        Me.pagEmitente.Key = "pagEmitente"
        Me.pagEmitente.Location = New System.Drawing.Point(1, 22)
        Me.pagEmitente.Name = "pagEmitente"
        Me.pagEmitente.Size = New System.Drawing.Size(895, 450)
        Me.pagEmitente.TabStop = True
        Me.pagEmitente.Text = "Emitente"
        '
        'grpLocalRetiradaEntrega
        '
        Me.grpLocalRetiradaEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLocalRetiradaEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpLocalRetiradaEntrega.Controls.Add(Me.btnEnderecoLocalEntrega)
        Me.grpLocalRetiradaEntrega.Controls.Add(Me.btnEnderecoLocalRetirada)
        Me.grpLocalRetiradaEntrega.Controls.Add(Me.chkLocalEntrega)
        Me.grpLocalRetiradaEntrega.Controls.Add(Me.chkLocalRetirada)
        Me.grpLocalRetiradaEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLocalRetiradaEntrega.Location = New System.Drawing.Point(8, 217)
        Me.grpLocalRetiradaEntrega.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpLocalRetiradaEntrega.Name = "grpLocalRetiradaEntrega"
        Me.grpLocalRetiradaEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLocalRetiradaEntrega.Size = New System.Drawing.Size(879, 89)
        Me.grpLocalRetiradaEntrega.TabIndex = 2
        Me.grpLocalRetiradaEntrega.Text = "Local de Retirada / Entrega"
        Me.grpLocalRetiradaEntrega.VisualStyleManager = Me.vsmMain
        '
        'btnEnderecoLocalEntrega
        '
        Me.btnEnderecoLocalEntrega.Image = Global.INTERACTI.My.Resources.Resources.truck
        Me.btnEnderecoLocalEntrega.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnderecoLocalEntrega.Location = New System.Drawing.Point(247, 55)
        Me.btnEnderecoLocalEntrega.Name = "btnEnderecoLocalEntrega"
        Me.btnEnderecoLocalEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEnderecoLocalEntrega.Size = New System.Drawing.Size(167, 23)
        Me.btnEnderecoLocalEntrega.TabIndex = 3
        Me.btnEnderecoLocalEntrega.Text = "Endereço Local Entrega"
        Me.btnEnderecoLocalEntrega.Visible = False
        Me.btnEnderecoLocalEntrega.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEnderecoLocalRetirada
        '
        Me.btnEnderecoLocalRetirada.Image = Global.INTERACTI.My.Resources.Resources.truck
        Me.btnEnderecoLocalRetirada.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnderecoLocalRetirada.Location = New System.Drawing.Point(247, 24)
        Me.btnEnderecoLocalRetirada.Name = "btnEnderecoLocalRetirada"
        Me.btnEnderecoLocalRetirada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEnderecoLocalRetirada.Size = New System.Drawing.Size(167, 23)
        Me.btnEnderecoLocalRetirada.TabIndex = 2
        Me.btnEnderecoLocalRetirada.Text = "Endereço Local Retirada"
        Me.btnEnderecoLocalRetirada.Visible = False
        Me.btnEnderecoLocalRetirada.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chkLocalEntrega
        '
        Me.chkLocalEntrega.Location = New System.Drawing.Point(9, 59)
        Me.chkLocalEntrega.Name = "chkLocalEntrega"
        Me.chkLocalEntrega.Size = New System.Drawing.Size(291, 15)
        Me.chkLocalEntrega.TabIndex = 1
        Me.chkLocalEntrega.Text = "Local de entrega diferente do Destinatário"
        '
        'chkLocalRetirada
        '
        Me.chkLocalRetirada.Location = New System.Drawing.Point(9, 28)
        Me.chkLocalRetirada.Name = "chkLocalRetirada"
        Me.chkLocalRetirada.Size = New System.Drawing.Size(291, 15)
        Me.chkLocalRetirada.TabIndex = 0
        Me.chkLocalRetirada.Text = "Local de retirada diferente do Emitente"
        '
        'grpEmitente
        '
        Me.grpEmitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEmitente.BackColor = System.Drawing.Color.Transparent
        Me.grpEmitente.Controls.Add(Me.txtCNAEEmitente)
        Me.grpEmitente.Controls.Add(Me.lblCNAEEmitente)
        Me.grpEmitente.Controls.Add(Me.txtInscricaoMunicipalEmitente)
        Me.grpEmitente.Controls.Add(Me.lblInscricaoMunicipalEmitente)
        Me.grpEmitente.Controls.Add(Me.lblRegimeTributarioEmitente)
        Me.grpEmitente.Controls.Add(Me.cboRegimeTributarioEmitente)
        Me.grpEmitente.Controls.Add(Me.txtCNPJEmitente)
        Me.grpEmitente.Controls.Add(Me.txtInscricaoEstadualSubstitutoTributarioEmitente)
        Me.grpEmitente.Controls.Add(Me.lblInscricaoEstadualSubstitutoTributarioEmitente)
        Me.grpEmitente.Controls.Add(Me.txtInscricaoEstadualEmitente)
        Me.grpEmitente.Controls.Add(Me.lblInscricaoEstadualEmitente)
        Me.grpEmitente.Controls.Add(Me.lblCNPJEmitente)
        Me.grpEmitente.Controls.Add(Me.lblEmitente)
        Me.grpEmitente.Controls.Add(Me.cboEmitente)
        Me.grpEmitente.Controls.Add(Me.btnProcurarEmitente)
        Me.grpEmitente.Controls.Add(Me.btnCadastrarEmitente)
        Me.grpEmitente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEmitente.Location = New System.Drawing.Point(8, 3)
        Me.grpEmitente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEmitente.Name = "grpEmitente"
        Me.grpEmitente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEmitente.Size = New System.Drawing.Size(879, 104)
        Me.grpEmitente.TabIndex = 0
        Me.grpEmitente.Text = "Dados do Emitente"
        Me.grpEmitente.VisualStyleManager = Me.vsmMain
        '
        'txtCNAEEmitente
        '
        Me.txtCNAEEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCNAEEmitente.BackColor = System.Drawing.Color.White
        Me.txtCNAEEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCNAEEmitente.Enabled = False
        Me.txtCNAEEmitente.Location = New System.Drawing.Point(604, 74)
        Me.txtCNAEEmitente.MaxLength = 7
        Me.txtCNAEEmitente.Name = "txtCNAEEmitente"
        Me.txtCNAEEmitente.Size = New System.Drawing.Size(130, 20)
        Me.txtCNAEEmitente.TabIndex = 15
        '
        'lblCNAEEmitente
        '
        Me.lblCNAEEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNAEEmitente.AutoSize = True
        Me.lblCNAEEmitente.Location = New System.Drawing.Point(601, 57)
        Me.lblCNAEEmitente.Name = "lblCNAEEmitente"
        Me.lblCNAEEmitente.Size = New System.Drawing.Size(38, 14)
        Me.lblCNAEEmitente.TabIndex = 14
        Me.lblCNAEEmitente.Text = "CNAE:"
        '
        'txtInscricaoMunicipalEmitente
        '
        Me.txtInscricaoMunicipalEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInscricaoMunicipalEmitente.BackColor = System.Drawing.Color.White
        Me.txtInscricaoMunicipalEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoMunicipalEmitente.Enabled = False
        Me.txtInscricaoMunicipalEmitente.Location = New System.Drawing.Point(469, 74)
        Me.txtInscricaoMunicipalEmitente.MaxLength = 15
        Me.txtInscricaoMunicipalEmitente.Name = "txtInscricaoMunicipalEmitente"
        Me.txtInscricaoMunicipalEmitente.Size = New System.Drawing.Size(130, 20)
        Me.txtInscricaoMunicipalEmitente.TabIndex = 13
        '
        'lblInscricaoMunicipalEmitente
        '
        Me.lblInscricaoMunicipalEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInscricaoMunicipalEmitente.AutoSize = True
        Me.lblInscricaoMunicipalEmitente.Location = New System.Drawing.Point(466, 57)
        Me.lblInscricaoMunicipalEmitente.Name = "lblInscricaoMunicipalEmitente"
        Me.lblInscricaoMunicipalEmitente.Size = New System.Drawing.Size(101, 14)
        Me.lblInscricaoMunicipalEmitente.TabIndex = 12
        Me.lblInscricaoMunicipalEmitente.Text = "Inscrição Municipal:"
        '
        'lblRegimeTributarioEmitente
        '
        Me.lblRegimeTributarioEmitente.AutoSize = True
        Me.lblRegimeTributarioEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRegimeTributarioEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblRegimeTributarioEmitente.Location = New System.Drawing.Point(6, 57)
        Me.lblRegimeTributarioEmitente.Name = "lblRegimeTributarioEmitente"
        Me.lblRegimeTributarioEmitente.Size = New System.Drawing.Size(93, 14)
        Me.lblRegimeTributarioEmitente.TabIndex = 10
        Me.lblRegimeTributarioEmitente.Text = "Regime Tributário:"
        '
        'cboRegimeTributarioEmitente
        '
        Me.cboRegimeTributarioEmitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboRegimeTributarioEmitente.AutoSize = False
        Me.cboRegimeTributarioEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRegimeTributarioEmitente.Enabled = False
        Me.cboRegimeTributarioEmitente.Location = New System.Drawing.Point(9, 74)
        Me.cboRegimeTributarioEmitente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboRegimeTributarioEmitente.Name = "cboRegimeTributarioEmitente"
        Me.cboRegimeTributarioEmitente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRegimeTributarioEmitente.Size = New System.Drawing.Size(454, 20)
        Me.cboRegimeTributarioEmitente.TabIndex = 11
        '
        'txtCNPJEmitente
        '
        Me.txtCNPJEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCNPJEmitente.BackColor = System.Drawing.Color.White
        Me.txtCNPJEmitente.Enabled = False
        Me.txtCNPJEmitente.Location = New System.Drawing.Point(469, 34)
        Me.txtCNPJEmitente.Mask = "00,000,000/0000-00"
        Me.txtCNPJEmitente.MaxLength = 25
        Me.txtCNPJEmitente.Name = "txtCNPJEmitente"
        Me.txtCNPJEmitente.Size = New System.Drawing.Size(129, 20)
        Me.txtCNPJEmitente.TabIndex = 5
        '
        'txtInscricaoEstadualSubstitutoTributarioEmitente
        '
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente.BackColor = System.Drawing.Color.White
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente.Enabled = False
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente.Location = New System.Drawing.Point(740, 34)
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente.MaxLength = 9
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente.Name = "txtInscricaoEstadualSubstitutoTributarioEmitente"
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente.Size = New System.Drawing.Size(130, 20)
        Me.txtInscricaoEstadualSubstitutoTributarioEmitente.TabIndex = 9
        '
        'lblInscricaoEstadualSubstitutoTributarioEmitente
        '
        Me.lblInscricaoEstadualSubstitutoTributarioEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInscricaoEstadualSubstitutoTributarioEmitente.AutoSize = True
        Me.lblInscricaoEstadualSubstitutoTributarioEmitente.Location = New System.Drawing.Point(737, 17)
        Me.lblInscricaoEstadualSubstitutoTributarioEmitente.Name = "lblInscricaoEstadualSubstitutoTributarioEmitente"
        Me.lblInscricaoEstadualSubstitutoTributarioEmitente.Size = New System.Drawing.Size(133, 14)
        Me.lblInscricaoEstadualSubstitutoTributarioEmitente.TabIndex = 8
        Me.lblInscricaoEstadualSubstitutoTributarioEmitente.Text = "Insc. Est. do Subs. Tribut.:"
        '
        'txtInscricaoEstadualEmitente
        '
        Me.txtInscricaoEstadualEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInscricaoEstadualEmitente.BackColor = System.Drawing.Color.White
        Me.txtInscricaoEstadualEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoEstadualEmitente.Enabled = False
        Me.txtInscricaoEstadualEmitente.Location = New System.Drawing.Point(604, 34)
        Me.txtInscricaoEstadualEmitente.MaxLength = 14
        Me.txtInscricaoEstadualEmitente.Name = "txtInscricaoEstadualEmitente"
        Me.txtInscricaoEstadualEmitente.Size = New System.Drawing.Size(130, 20)
        Me.txtInscricaoEstadualEmitente.TabIndex = 7
        '
        'lblInscricaoEstadualEmitente
        '
        Me.lblInscricaoEstadualEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInscricaoEstadualEmitente.AutoSize = True
        Me.lblInscricaoEstadualEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblInscricaoEstadualEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblInscricaoEstadualEmitente.Location = New System.Drawing.Point(601, 17)
        Me.lblInscricaoEstadualEmitente.Name = "lblInscricaoEstadualEmitente"
        Me.lblInscricaoEstadualEmitente.Size = New System.Drawing.Size(98, 14)
        Me.lblInscricaoEstadualEmitente.TabIndex = 6
        Me.lblInscricaoEstadualEmitente.Text = "Inscrição Estadual:"
        '
        'lblCNPJEmitente
        '
        Me.lblCNPJEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPJEmitente.AutoSize = True
        Me.lblCNPJEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblCNPJEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCNPJEmitente.Location = New System.Drawing.Point(466, 17)
        Me.lblCNPJEmitente.Name = "lblCNPJEmitente"
        Me.lblCNPJEmitente.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJEmitente.TabIndex = 4
        Me.lblCNPJEmitente.Text = "CNPJ:"
        '
        'lblEmitente
        '
        Me.lblEmitente.AutoSize = True
        Me.lblEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEmitente.Location = New System.Drawing.Point(25, 17)
        Me.lblEmitente.Name = "lblEmitente"
        Me.lblEmitente.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitente.TabIndex = 1
        Me.lblEmitente.Text = "Emitente:"
        '
        'cboEmitente
        '
        Me.cboEmitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEmitente.AutoSize = False
        Me.cboEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEmitente.Location = New System.Drawing.Point(9, 34)
        Me.cboEmitente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboEmitente.Name = "cboEmitente"
        Me.cboEmitente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEmitente.Size = New System.Drawing.Size(454, 20)
        Me.cboEmitente.TabIndex = 2
        '
        'btnProcurarEmitente
        '
        Me.btnProcurarEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarEmitente.FlatAppearance.BorderSize = 0
        Me.btnProcurarEmitente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarEmitente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarEmitente.Location = New System.Drawing.Point(446, 15)
        Me.btnProcurarEmitente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarEmitente.Name = "btnProcurarEmitente"
        Me.btnProcurarEmitente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarEmitente.TabIndex = 3
        Me.btnProcurarEmitente.TabStop = False
        Me.btnProcurarEmitente.UseVisualStyleBackColor = True
        '
        'btnCadastrarEmitente
        '
        Me.btnCadastrarEmitente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarEmitente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarEmitente.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarEmitente.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarEmitente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarEmitente.Name = "btnCadastrarEmitente"
        Me.btnCadastrarEmitente.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarEmitente.TabIndex = 0
        Me.btnCadastrarEmitente.TabStop = False
        Me.btnCadastrarEmitente.UseVisualStyleBackColor = True
        '
        'grpEnderecoDestinatario
        '
        Me.grpEnderecoDestinatario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEnderecoDestinatario.BackColor = System.Drawing.Color.Transparent
        Me.grpEnderecoDestinatario.Controls.Add(Me.txtTelefoneEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblTelefoneEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.txtEmailEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblEmailEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.cboMunicipioEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.txtNumeroEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.txtComplementoEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.txtBairroEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblPaisEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.cboPaisEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblCEPEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.txtCEPEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblComplementoEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblUFEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.cboUFEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblMunicipioEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblBairroEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblNumeroEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.lblLogradouroEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.txtLogradouroEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.btnProcurarCEPEmitente)
        Me.grpEnderecoDestinatario.Controls.Add(Me.btnCadastrarPaisEmitente)
        Me.grpEnderecoDestinatario.Location = New System.Drawing.Point(8, 110)
        Me.grpEnderecoDestinatario.Name = "grpEnderecoDestinatario"
        Me.grpEnderecoDestinatario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEnderecoDestinatario.Size = New System.Drawing.Size(879, 104)
        Me.grpEnderecoDestinatario.TabIndex = 1
        Me.grpEnderecoDestinatario.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEnderecoDestinatario.VisualStyleManager = Me.vsmMain
        '
        'txtTelefoneEmitente
        '
        Me.txtTelefoneEmitente.Enabled = False
        Me.txtTelefoneEmitente.Location = New System.Drawing.Point(534, 74)
        Me.txtTelefoneEmitente.Mask = "!(##) 0000-0000"
        Me.txtTelefoneEmitente.MaxLength = 10
        Me.txtTelefoneEmitente.Name = "txtTelefoneEmitente"
        Me.txtTelefoneEmitente.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefoneEmitente.TabIndex = 18
        '
        'lblTelefoneEmitente
        '
        Me.lblTelefoneEmitente.AutoSize = True
        Me.lblTelefoneEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefoneEmitente.Location = New System.Drawing.Point(531, 57)
        Me.lblTelefoneEmitente.Name = "lblTelefoneEmitente"
        Me.lblTelefoneEmitente.Size = New System.Drawing.Size(51, 14)
        Me.lblTelefoneEmitente.TabIndex = 17
        Me.lblTelefoneEmitente.Text = "Telefone:"
        '
        'txtEmailEmitente
        '
        Me.txtEmailEmitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmailEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailEmitente.Enabled = False
        Me.txtEmailEmitente.Location = New System.Drawing.Point(648, 74)
        Me.txtEmailEmitente.MaxLength = 60
        Me.txtEmailEmitente.Name = "txtEmailEmitente"
        Me.txtEmailEmitente.Size = New System.Drawing.Size(222, 20)
        Me.txtEmailEmitente.TabIndex = 20
        '
        'lblEmailEmitente
        '
        Me.lblEmailEmitente.AutoSize = True
        Me.lblEmailEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmailEmitente.Location = New System.Drawing.Point(645, 57)
        Me.lblEmailEmitente.Name = "lblEmailEmitente"
        Me.lblEmailEmitente.Size = New System.Drawing.Size(38, 14)
        Me.lblEmailEmitente.TabIndex = 19
        Me.lblEmailEmitente.Text = "E-mail:"
        '
        'cboMunicipioEmitente
        '
        Me.cboMunicipioEmitente.AutoSize = False
        Me.cboMunicipioEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipioEmitente.Enabled = False
        Me.cboMunicipioEmitente.Location = New System.Drawing.Point(311, 34)
        Me.cboMunicipioEmitente.Name = "cboMunicipioEmitente"
        Me.cboMunicipioEmitente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipioEmitente.Size = New System.Drawing.Size(217, 20)
        Me.cboMunicipioEmitente.TabIndex = 8
        '
        'txtNumeroEmitente
        '
        Me.txtNumeroEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroEmitente.Enabled = False
        Me.txtNumeroEmitente.Location = New System.Drawing.Point(806, 34)
        Me.txtNumeroEmitente.MaxLength = 60
        Me.txtNumeroEmitente.Name = "txtNumeroEmitente"
        Me.txtNumeroEmitente.Size = New System.Drawing.Size(64, 20)
        Me.txtNumeroEmitente.TabIndex = 12
        '
        'txtComplementoEmitente
        '
        Me.txtComplementoEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoEmitente.Enabled = False
        Me.txtComplementoEmitente.Location = New System.Drawing.Point(311, 74)
        Me.txtComplementoEmitente.MaxLength = 60
        Me.txtComplementoEmitente.Name = "txtComplementoEmitente"
        Me.txtComplementoEmitente.Size = New System.Drawing.Size(217, 20)
        Me.txtComplementoEmitente.TabIndex = 16
        '
        'txtBairroEmitente
        '
        Me.txtBairroEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairroEmitente.Enabled = False
        Me.txtBairroEmitente.Location = New System.Drawing.Point(9, 74)
        Me.txtBairroEmitente.MaxLength = 60
        Me.txtBairroEmitente.Name = "txtBairroEmitente"
        Me.txtBairroEmitente.Size = New System.Drawing.Size(296, 20)
        Me.txtBairroEmitente.TabIndex = 14
        '
        'lblPaisEmitente
        '
        Me.lblPaisEmitente.AutoSize = True
        Me.lblPaisEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblPaisEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPaisEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPaisEmitente.Location = New System.Drawing.Point(98, 17)
        Me.lblPaisEmitente.Name = "lblPaisEmitente"
        Me.lblPaisEmitente.Size = New System.Drawing.Size(30, 14)
        Me.lblPaisEmitente.TabIndex = 3
        Me.lblPaisEmitente.Text = "País:"
        '
        'cboPaisEmitente
        '
        Me.cboPaisEmitente.AutoSize = False
        Me.cboPaisEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPaisEmitente.Enabled = False
        Me.cboPaisEmitente.Location = New System.Drawing.Point(82, 34)
        Me.cboPaisEmitente.Name = "cboPaisEmitente"
        Me.cboPaisEmitente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPaisEmitente.Size = New System.Drawing.Size(159, 20)
        Me.cboPaisEmitente.TabIndex = 4
        '
        'lblCEPEmitente
        '
        Me.lblCEPEmitente.AutoSize = True
        Me.lblCEPEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblCEPEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCEPEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCEPEmitente.Location = New System.Drawing.Point(6, 17)
        Me.lblCEPEmitente.Name = "lblCEPEmitente"
        Me.lblCEPEmitente.Size = New System.Drawing.Size(29, 14)
        Me.lblCEPEmitente.TabIndex = 0
        Me.lblCEPEmitente.Text = "CEP:"
        '
        'txtCEPEmitente
        '
        Me.txtCEPEmitente.Enabled = False
        Me.txtCEPEmitente.Location = New System.Drawing.Point(9, 34)
        Me.txtCEPEmitente.Mask = "00000-000"
        Me.txtCEPEmitente.MaxLength = 10
        Me.txtCEPEmitente.Name = "txtCEPEmitente"
        Me.txtCEPEmitente.Size = New System.Drawing.Size(67, 20)
        Me.txtCEPEmitente.TabIndex = 2
        '
        'lblComplementoEmitente
        '
        Me.lblComplementoEmitente.AutoSize = True
        Me.lblComplementoEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblComplementoEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblComplementoEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComplementoEmitente.Location = New System.Drawing.Point(308, 57)
        Me.lblComplementoEmitente.Name = "lblComplementoEmitente"
        Me.lblComplementoEmitente.Size = New System.Drawing.Size(74, 14)
        Me.lblComplementoEmitente.TabIndex = 15
        Me.lblComplementoEmitente.Text = "Complemento:"
        '
        'lblUFEmitente
        '
        Me.lblUFEmitente.AutoSize = True
        Me.lblUFEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblUFEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUFEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFEmitente.Location = New System.Drawing.Point(244, 17)
        Me.lblUFEmitente.Name = "lblUFEmitente"
        Me.lblUFEmitente.Size = New System.Drawing.Size(23, 14)
        Me.lblUFEmitente.TabIndex = 5
        Me.lblUFEmitente.Text = "UF:"
        '
        'cboUFEmitente
        '
        Me.cboUFEmitente.AutoSize = False
        Me.cboUFEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFEmitente.Enabled = False
        Me.cboUFEmitente.Location = New System.Drawing.Point(247, 34)
        Me.cboUFEmitente.Name = "cboUFEmitente"
        Me.cboUFEmitente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFEmitente.Size = New System.Drawing.Size(58, 20)
        Me.cboUFEmitente.TabIndex = 6
        '
        'lblMunicipioEmitente
        '
        Me.lblMunicipioEmitente.AutoSize = True
        Me.lblMunicipioEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblMunicipioEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMunicipioEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipioEmitente.Location = New System.Drawing.Point(308, 17)
        Me.lblMunicipioEmitente.Name = "lblMunicipioEmitente"
        Me.lblMunicipioEmitente.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipioEmitente.TabIndex = 7
        Me.lblMunicipioEmitente.Text = "Município:"
        '
        'lblBairroEmitente
        '
        Me.lblBairroEmitente.AutoSize = True
        Me.lblBairroEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblBairroEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblBairroEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBairroEmitente.Location = New System.Drawing.Point(6, 57)
        Me.lblBairroEmitente.Name = "lblBairroEmitente"
        Me.lblBairroEmitente.Size = New System.Drawing.Size(39, 14)
        Me.lblBairroEmitente.TabIndex = 13
        Me.lblBairroEmitente.Text = "Bairro:"
        '
        'lblNumeroEmitente
        '
        Me.lblNumeroEmitente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroEmitente.AutoSize = True
        Me.lblNumeroEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNumeroEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblNumeroEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroEmitente.Location = New System.Drawing.Point(803, 17)
        Me.lblNumeroEmitente.Name = "lblNumeroEmitente"
        Me.lblNumeroEmitente.Size = New System.Drawing.Size(47, 14)
        Me.lblNumeroEmitente.TabIndex = 11
        Me.lblNumeroEmitente.Text = "Número:"
        '
        'lblLogradouroEmitente
        '
        Me.lblLogradouroEmitente.AutoSize = True
        Me.lblLogradouroEmitente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblLogradouroEmitente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLogradouroEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLogradouroEmitente.Location = New System.Drawing.Point(531, 17)
        Me.lblLogradouroEmitente.Name = "lblLogradouroEmitente"
        Me.lblLogradouroEmitente.Size = New System.Drawing.Size(66, 14)
        Me.lblLogradouroEmitente.TabIndex = 9
        Me.lblLogradouroEmitente.Text = "Logradouro:"
        '
        'txtLogradouroEmitente
        '
        Me.txtLogradouroEmitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogradouroEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouroEmitente.Enabled = False
        Me.txtLogradouroEmitente.Location = New System.Drawing.Point(534, 34)
        Me.txtLogradouroEmitente.MaxLength = 60
        Me.txtLogradouroEmitente.Name = "txtLogradouroEmitente"
        Me.txtLogradouroEmitente.Size = New System.Drawing.Size(266, 20)
        Me.txtLogradouroEmitente.TabIndex = 10
        '
        'btnProcurarCEPEmitente
        '
        Me.btnProcurarCEPEmitente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCEPEmitente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCEPEmitente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCEPEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCEPEmitente.Location = New System.Drawing.Point(59, 15)
        Me.btnProcurarCEPEmitente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCEPEmitente.Name = "btnProcurarCEPEmitente"
        Me.btnProcurarCEPEmitente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCEPEmitente.TabIndex = 1
        Me.btnProcurarCEPEmitente.TabStop = False
        Me.btnProcurarCEPEmitente.UseVisualStyleBackColor = True
        '
        'btnCadastrarPaisEmitente
        '
        Me.btnCadastrarPaisEmitente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPaisEmitente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPaisEmitente.Image = CType(resources.GetObject("btnCadastrarPaisEmitente.Image"), System.Drawing.Image)
        Me.btnCadastrarPaisEmitente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarPaisEmitente.Location = New System.Drawing.Point(82, 18)
        Me.btnCadastrarPaisEmitente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarPaisEmitente.Name = "btnCadastrarPaisEmitente"
        Me.btnCadastrarPaisEmitente.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarPaisEmitente.TabIndex = 3
        Me.btnCadastrarPaisEmitente.TabStop = False
        Me.btnCadastrarPaisEmitente.UseVisualStyleBackColor = True
        '
        'pagProduto
        '
        Me.pagProduto.Controls.Add(Me.btnEditarGridProduto)
        Me.pagProduto.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagProduto.Controls.Add(Me.btnExcelGridProduto)
        Me.pagProduto.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagProduto.Controls.Add(Me.grdProduto)
        Me.pagProduto.Key = "pagProduto"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Size = New System.Drawing.Size(895, 450)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Produtos"
        '
        'btnEditarGridProduto
        '
        Me.btnEditarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEditarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnEditarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.lapis
        Me.btnEditarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEditarGridProduto.Location = New System.Drawing.Point(81, 424)
        Me.btnEditarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEditarGridProduto.Name = "btnEditarGridProduto"
        Me.btnEditarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnEditarGridProduto.TabIndex = 22
        Me.btnEditarGridProduto.TabStop = False
        Me.btnEditarGridProduto.UseVisualStyleBackColor = False
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
        Me.btnAgruparGridProduto.TabIndex = 16
        Me.btnAgruparGridProduto.TabStop = False
        Me.btnAgruparGridProduto.UseVisualStyleBackColor = False
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
        Me.btnExcelGridProduto.TabIndex = 15
        Me.btnExcelGridProduto.TabStop = False
        Me.btnExcelGridProduto.UseVisualStyleBackColor = False
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
        Me.btnConfigurarGridProduto.TabIndex = 10
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'grdProduto
        '
        Me.grdProduto.AllowDrop = True
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdProduto_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProduto_DesignTimeLayout_Reference_0.Instance"), Object)
        grdProduto_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProduto_DesignTimeLayout_Reference_0})
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProduto.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.FrozenColumns = 2
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.Location = New System.Drawing.Point(8, 9)
        Me.grdProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(879, 432)
        Me.grdProduto.TabIndex = 5
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'pagTransporte
        '
        Me.pagTransporte.Controls.Add(Me.tabTransporte)
        Me.pagTransporte.Key = "pagTransporte"
        Me.pagTransporte.Location = New System.Drawing.Point(1, 22)
        Me.pagTransporte.Name = "pagTransporte"
        Me.pagTransporte.Size = New System.Drawing.Size(895, 450)
        Me.pagTransporte.TabStop = True
        Me.pagTransporte.Text = "Transporte"
        '
        'tabTransporte
        '
        Me.tabTransporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTransporte.BackColor = System.Drawing.Color.Transparent
        Me.tabTransporte.Location = New System.Drawing.Point(8, 6)
        Me.tabTransporte.Name = "tabTransporte"
        Me.tabTransporte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabTransporte.ShowFocusRectangle = False
        Me.tabTransporte.Size = New System.Drawing.Size(879, 435)
        Me.tabTransporte.TabIndex = 0
        Me.tabTransporte.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTransportador, Me.pagRetencaoICMS, Me.pagVeiculo, Me.pagVolume})
        Me.tabTransporte.TabStop = False
        Me.tabTransporte.VisualStyleManager = Me.vsmMain
        '
        'pagTransportador
        '
        Me.pagTransportador.Controls.Add(Me.grpTransportador)
        Me.pagTransportador.Key = "pagTransportador"
        Me.pagTransportador.Location = New System.Drawing.Point(1, 22)
        Me.pagTransportador.Name = "pagTransportador"
        Me.pagTransportador.Size = New System.Drawing.Size(877, 412)
        Me.pagTransportador.TabStop = True
        Me.pagTransportador.Text = "Transportador"
        '
        'grpTransportador
        '
        Me.grpTransportador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTransportador.BackColor = System.Drawing.Color.Transparent
        Me.grpTransportador.Controls.Add(Me.cboMunicipioTransportadora)
        Me.grpTransportador.Controls.Add(Me.lblUFTransportadora)
        Me.grpTransportador.Controls.Add(Me.cboUFTransportadora)
        Me.grpTransportador.Controls.Add(Me.lblMunicipioTransportadora)
        Me.grpTransportador.Controls.Add(Me.lblEnderecoTransportadora)
        Me.grpTransportador.Controls.Add(Me.txtEnderecoTransportadora)
        Me.grpTransportador.Controls.Add(Me.lblModalidadeFrete)
        Me.grpTransportador.Controls.Add(Me.cboModalidadeFrete)
        Me.grpTransportador.Controls.Add(Me.txtCNPJTransportadora)
        Me.grpTransportador.Controls.Add(Me.txtInscricaoEstadualTransportadora)
        Me.grpTransportador.Controls.Add(Me.lblInscricaoEstadualTransportadora)
        Me.grpTransportador.Controls.Add(Me.lblCNPJTransportadora)
        Me.grpTransportador.Controls.Add(Me.lblTransportadora)
        Me.grpTransportador.Controls.Add(Me.cboTransportadora)
        Me.grpTransportador.Controls.Add(Me.btnProcurarTransportadora)
        Me.grpTransportador.Controls.Add(Me.btnCadastrarTransportadora)
        Me.grpTransportador.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpTransportador.Location = New System.Drawing.Point(8, 3)
        Me.grpTransportador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpTransportador.Name = "grpTransportador"
        Me.grpTransportador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTransportador.Size = New System.Drawing.Size(861, 104)
        Me.grpTransportador.TabIndex = 0
        Me.grpTransportador.VisualStyleManager = Me.vsmMain
        '
        'cboMunicipioTransportadora
        '
        Me.cboMunicipioTransportadora.AutoSize = False
        Me.cboMunicipioTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipioTransportadora.Location = New System.Drawing.Point(73, 74)
        Me.cboMunicipioTransportadora.Name = "cboMunicipioTransportadora"
        Me.cboMunicipioTransportadora.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipioTransportadora.Size = New System.Drawing.Size(217, 20)
        Me.cboMunicipioTransportadora.TabIndex = 13
        '
        'lblUFTransportadora
        '
        Me.lblUFTransportadora.AutoSize = True
        Me.lblUFTransportadora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFTransportadora.Location = New System.Drawing.Point(6, 57)
        Me.lblUFTransportadora.Name = "lblUFTransportadora"
        Me.lblUFTransportadora.Size = New System.Drawing.Size(23, 14)
        Me.lblUFTransportadora.TabIndex = 10
        Me.lblUFTransportadora.Text = "UF:"
        '
        'cboUFTransportadora
        '
        Me.cboUFTransportadora.AutoSize = False
        Me.cboUFTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFTransportadora.Location = New System.Drawing.Point(9, 74)
        Me.cboUFTransportadora.Name = "cboUFTransportadora"
        Me.cboUFTransportadora.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFTransportadora.Size = New System.Drawing.Size(58, 20)
        Me.cboUFTransportadora.TabIndex = 11
        '
        'lblMunicipioTransportadora
        '
        Me.lblMunicipioTransportadora.AutoSize = True
        Me.lblMunicipioTransportadora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipioTransportadora.Location = New System.Drawing.Point(70, 57)
        Me.lblMunicipioTransportadora.Name = "lblMunicipioTransportadora"
        Me.lblMunicipioTransportadora.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipioTransportadora.TabIndex = 12
        Me.lblMunicipioTransportadora.Text = "Município:"
        '
        'lblEnderecoTransportadora
        '
        Me.lblEnderecoTransportadora.AutoSize = True
        Me.lblEnderecoTransportadora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEnderecoTransportadora.Location = New System.Drawing.Point(293, 57)
        Me.lblEnderecoTransportadora.Name = "lblEnderecoTransportadora"
        Me.lblEnderecoTransportadora.Size = New System.Drawing.Size(56, 14)
        Me.lblEnderecoTransportadora.TabIndex = 14
        Me.lblEnderecoTransportadora.Text = "Endereço:"
        '
        'txtEnderecoTransportadora
        '
        Me.txtEnderecoTransportadora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnderecoTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnderecoTransportadora.Location = New System.Drawing.Point(296, 74)
        Me.txtEnderecoTransportadora.MaxLength = 60
        Me.txtEnderecoTransportadora.Name = "txtEnderecoTransportadora"
        Me.txtEnderecoTransportadora.Size = New System.Drawing.Size(556, 20)
        Me.txtEnderecoTransportadora.TabIndex = 15
        '
        'lblModalidadeFrete
        '
        Me.lblModalidadeFrete.AutoSize = True
        Me.lblModalidadeFrete.BackColor = System.Drawing.Color.Transparent
        Me.lblModalidadeFrete.Location = New System.Drawing.Point(6, 17)
        Me.lblModalidadeFrete.Name = "lblModalidadeFrete"
        Me.lblModalidadeFrete.Size = New System.Drawing.Size(107, 14)
        Me.lblModalidadeFrete.TabIndex = 0
        Me.lblModalidadeFrete.Text = "Modalidade do Frete:"
        '
        'cboModalidadeFrete
        '
        Me.cboModalidadeFrete.AutoSize = False
        Me.cboModalidadeFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeFrete.Location = New System.Drawing.Point(9, 34)
        Me.cboModalidadeFrete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModalidadeFrete.Name = "cboModalidadeFrete"
        Me.cboModalidadeFrete.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeFrete.Size = New System.Drawing.Size(138, 20)
        Me.cboModalidadeFrete.TabIndex = 1
        '
        'txtCNPJTransportadora
        '
        Me.txtCNPJTransportadora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCNPJTransportadora.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCNPJTransportadora.Location = New System.Drawing.Point(597, 34)
        Me.txtCNPJTransportadora.Mask = "00,000,000/0000-00"
        Me.txtCNPJTransportadora.MaxLength = 25
        Me.txtCNPJTransportadora.Name = "txtCNPJTransportadora"
        Me.txtCNPJTransportadora.ReadOnly = True
        Me.txtCNPJTransportadora.Size = New System.Drawing.Size(129, 20)
        Me.txtCNPJTransportadora.TabIndex = 7
        Me.txtCNPJTransportadora.TabStop = False
        '
        'txtInscricaoEstadualTransportadora
        '
        Me.txtInscricaoEstadualTransportadora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInscricaoEstadualTransportadora.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtInscricaoEstadualTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoEstadualTransportadora.Location = New System.Drawing.Point(732, 34)
        Me.txtInscricaoEstadualTransportadora.MaxLength = 14
        Me.txtInscricaoEstadualTransportadora.Name = "txtInscricaoEstadualTransportadora"
        Me.txtInscricaoEstadualTransportadora.ReadOnly = True
        Me.txtInscricaoEstadualTransportadora.Size = New System.Drawing.Size(120, 20)
        Me.txtInscricaoEstadualTransportadora.TabIndex = 9
        Me.txtInscricaoEstadualTransportadora.TabStop = False
        '
        'lblInscricaoEstadualTransportadora
        '
        Me.lblInscricaoEstadualTransportadora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInscricaoEstadualTransportadora.AutoSize = True
        Me.lblInscricaoEstadualTransportadora.Location = New System.Drawing.Point(729, 17)
        Me.lblInscricaoEstadualTransportadora.Name = "lblInscricaoEstadualTransportadora"
        Me.lblInscricaoEstadualTransportadora.Size = New System.Drawing.Size(98, 14)
        Me.lblInscricaoEstadualTransportadora.TabIndex = 8
        Me.lblInscricaoEstadualTransportadora.Text = "Inscrição Estadual:"
        '
        'lblCNPJTransportadora
        '
        Me.lblCNPJTransportadora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPJTransportadora.AutoSize = True
        Me.lblCNPJTransportadora.Location = New System.Drawing.Point(594, 17)
        Me.lblCNPJTransportadora.Name = "lblCNPJTransportadora"
        Me.lblCNPJTransportadora.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJTransportadora.TabIndex = 6
        Me.lblCNPJTransportadora.Text = "CNPJ:"
        '
        'lblTransportadora
        '
        Me.lblTransportadora.AutoSize = True
        Me.lblTransportadora.Location = New System.Drawing.Point(169, 17)
        Me.lblTransportadora.Name = "lblTransportadora"
        Me.lblTransportadora.Size = New System.Drawing.Size(85, 14)
        Me.lblTransportadora.TabIndex = 3
        Me.lblTransportadora.Text = "Transportadora:"
        '
        'cboTransportadora
        '
        Me.cboTransportadora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTransportadora.AutoSize = False
        Me.cboTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTransportadora.Location = New System.Drawing.Point(153, 34)
        Me.cboTransportadora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTransportadora.Name = "cboTransportadora"
        Me.cboTransportadora.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTransportadora.Size = New System.Drawing.Size(438, 20)
        Me.cboTransportadora.TabIndex = 5
        '
        'btnProcurarTransportadora
        '
        Me.btnProcurarTransportadora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarTransportadora.FlatAppearance.BorderSize = 0
        Me.btnProcurarTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarTransportadora.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarTransportadora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarTransportadora.Location = New System.Drawing.Point(574, 15)
        Me.btnProcurarTransportadora.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarTransportadora.Name = "btnProcurarTransportadora"
        Me.btnProcurarTransportadora.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarTransportadora.TabIndex = 4
        Me.btnProcurarTransportadora.TabStop = False
        Me.btnProcurarTransportadora.UseVisualStyleBackColor = True
        '
        'btnCadastrarTransportadora
        '
        Me.btnCadastrarTransportadora.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTransportadora.Image = CType(resources.GetObject("btnCadastrarTransportadora.Image"), System.Drawing.Image)
        Me.btnCadastrarTransportadora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTransportadora.Location = New System.Drawing.Point(153, 17)
        Me.btnCadastrarTransportadora.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTransportadora.Name = "btnCadastrarTransportadora"
        Me.btnCadastrarTransportadora.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTransportadora.TabIndex = 2
        Me.btnCadastrarTransportadora.TabStop = False
        Me.btnCadastrarTransportadora.UseVisualStyleBackColor = True
        '
        'pagRetencaoICMS
        '
        Me.pagRetencaoICMS.Controls.Add(Me.grpRetencaoICMSTransporte)
        Me.pagRetencaoICMS.Key = "pagRetencaoICMS"
        Me.pagRetencaoICMS.Location = New System.Drawing.Point(1, 22)
        Me.pagRetencaoICMS.Name = "pagRetencaoICMS"
        Me.pagRetencaoICMS.Size = New System.Drawing.Size(877, 412)
        Me.pagRetencaoICMS.TabStop = True
        Me.pagRetencaoICMS.Text = "Retenção do ICMS"
        '
        'grpRetencaoICMSTransporte
        '
        Me.grpRetencaoICMSTransporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRetencaoICMSTransporte.BackColor = System.Drawing.Color.Transparent
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.txtICMSRetidoTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.lblCFOPICMSTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.cboCFOPICMSTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.cboMunicipioICMSTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.lblUFICMSTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.cboUFICMSTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.cb)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.txtValorServicoTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.lblValorServicoTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.txtAliquotaTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.lblAliquotaTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.txtBaseCalculoTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.lblICMSRetidoTransporte)
        Me.grpRetencaoICMSTransporte.Controls.Add(Me.lblBaseCalculoTransporte)
        Me.grpRetencaoICMSTransporte.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpRetencaoICMSTransporte.Location = New System.Drawing.Point(8, 3)
        Me.grpRetencaoICMSTransporte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpRetencaoICMSTransporte.Name = "grpRetencaoICMSTransporte"
        Me.grpRetencaoICMSTransporte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpRetencaoICMSTransporte.Size = New System.Drawing.Size(861, 104)
        Me.grpRetencaoICMSTransporte.TabIndex = 0
        Me.grpRetencaoICMSTransporte.VisualStyleManager = Me.vsmMain
        '
        'txtICMSRetidoTransporte
        '
        Me.txtICMSRetidoTransporte.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtICMSRetidoTransporte.DecimalDigits = 2
        Me.txtICMSRetidoTransporte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtICMSRetidoTransporte.Location = New System.Drawing.Point(9, 74)
        Me.txtICMSRetidoTransporte.Name = "txtICMSRetidoTransporte"
        Me.txtICMSRetidoTransporte.Size = New System.Drawing.Size(123, 20)
        Me.txtICMSRetidoTransporte.TabIndex = 13
        Me.txtICMSRetidoTransporte.TabStop = False
        Me.txtICMSRetidoTransporte.Text = "0,00"
        Me.txtICMSRetidoTransporte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCFOPICMSTransporte
        '
        Me.lblCFOPICMSTransporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCFOPICMSTransporte.AutoSize = True
        Me.lblCFOPICMSTransporte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCFOPICMSTransporte.Location = New System.Drawing.Point(770, 17)
        Me.lblCFOPICMSTransporte.Name = "lblCFOPICMSTransporte"
        Me.lblCFOPICMSTransporte.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOPICMSTransporte.TabIndex = 10
        Me.lblCFOPICMSTransporte.Text = "CFOP:"
        '
        'cboCFOPICMSTransporte
        '
        Me.cboCFOPICMSTransporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCFOPICMSTransporte.AutoSize = False
        Me.cboCFOPICMSTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCFOPICMSTransporte.Location = New System.Drawing.Point(773, 34)
        Me.cboCFOPICMSTransporte.Name = "cboCFOPICMSTransporte"
        Me.cboCFOPICMSTransporte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOPICMSTransporte.Size = New System.Drawing.Size(79, 20)
        Me.cboCFOPICMSTransporte.TabIndex = 11
        '
        'cboMunicipioICMSTransporte
        '
        Me.cboMunicipioICMSTransporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMunicipioICMSTransporte.AutoSize = False
        Me.cboMunicipioICMSTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipioICMSTransporte.Location = New System.Drawing.Point(460, 34)
        Me.cboMunicipioICMSTransporte.Name = "cboMunicipioICMSTransporte"
        Me.cboMunicipioICMSTransporte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipioICMSTransporte.Size = New System.Drawing.Size(307, 20)
        Me.cboMunicipioICMSTransporte.TabIndex = 9
        '
        'lblUFICMSTransporte
        '
        Me.lblUFICMSTransporte.AutoSize = True
        Me.lblUFICMSTransporte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFICMSTransporte.Location = New System.Drawing.Point(393, 17)
        Me.lblUFICMSTransporte.Name = "lblUFICMSTransporte"
        Me.lblUFICMSTransporte.Size = New System.Drawing.Size(23, 14)
        Me.lblUFICMSTransporte.TabIndex = 6
        Me.lblUFICMSTransporte.Text = "UF:"
        '
        'cboUFICMSTransporte
        '
        Me.cboUFICMSTransporte.AutoSize = False
        Me.cboUFICMSTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFICMSTransporte.Location = New System.Drawing.Point(396, 34)
        Me.cboUFICMSTransporte.Name = "cboUFICMSTransporte"
        Me.cboUFICMSTransporte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFICMSTransporte.Size = New System.Drawing.Size(58, 20)
        Me.cboUFICMSTransporte.TabIndex = 7
        '
        'cb
        '
        Me.cb.AutoSize = True
        Me.cb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cb.Location = New System.Drawing.Point(457, 17)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(54, 14)
        Me.cb.TabIndex = 8
        Me.cb.Text = "Município:"
        '
        'txtValorServicoTransporte
        '
        Me.txtValorServicoTransporte.DecimalDigits = 2
        Me.txtValorServicoTransporte.Location = New System.Drawing.Point(267, 34)
        Me.txtValorServicoTransporte.Name = "txtValorServicoTransporte"
        Me.txtValorServicoTransporte.Size = New System.Drawing.Size(123, 20)
        Me.txtValorServicoTransporte.TabIndex = 5
        Me.txtValorServicoTransporte.Text = "0,00"
        Me.txtValorServicoTransporte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorServicoTransporte
        '
        Me.lblValorServicoTransporte.AutoSize = True
        Me.lblValorServicoTransporte.Location = New System.Drawing.Point(264, 17)
        Me.lblValorServicoTransporte.Name = "lblValorServicoTransporte"
        Me.lblValorServicoTransporte.Size = New System.Drawing.Size(90, 14)
        Me.lblValorServicoTransporte.TabIndex = 4
        Me.lblValorServicoTransporte.Text = "Valor do Serviço:"
        '
        'txtAliquotaTransporte
        '
        Me.txtAliquotaTransporte.DecimalDigits = 2
        Me.txtAliquotaTransporte.Location = New System.Drawing.Point(138, 34)
        Me.txtAliquotaTransporte.Name = "txtAliquotaTransporte"
        Me.txtAliquotaTransporte.Size = New System.Drawing.Size(123, 20)
        Me.txtAliquotaTransporte.TabIndex = 3
        Me.txtAliquotaTransporte.Text = "0,00"
        Me.txtAliquotaTransporte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaTransporte
        '
        Me.lblAliquotaTransporte.AutoSize = True
        Me.lblAliquotaTransporte.Location = New System.Drawing.Point(135, 17)
        Me.lblAliquotaTransporte.Name = "lblAliquotaTransporte"
        Me.lblAliquotaTransporte.Size = New System.Drawing.Size(49, 14)
        Me.lblAliquotaTransporte.TabIndex = 2
        Me.lblAliquotaTransporte.Text = "Alíquota:"
        '
        'txtBaseCalculoTransporte
        '
        Me.txtBaseCalculoTransporte.DecimalDigits = 2
        Me.txtBaseCalculoTransporte.Location = New System.Drawing.Point(9, 34)
        Me.txtBaseCalculoTransporte.Name = "txtBaseCalculoTransporte"
        Me.txtBaseCalculoTransporte.Size = New System.Drawing.Size(123, 20)
        Me.txtBaseCalculoTransporte.TabIndex = 1
        Me.txtBaseCalculoTransporte.Text = "0,00"
        Me.txtBaseCalculoTransporte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblICMSRetidoTransporte
        '
        Me.lblICMSRetidoTransporte.AutoSize = True
        Me.lblICMSRetidoTransporte.Location = New System.Drawing.Point(6, 57)
        Me.lblICMSRetidoTransporte.Name = "lblICMSRetidoTransporte"
        Me.lblICMSRetidoTransporte.Size = New System.Drawing.Size(67, 14)
        Me.lblICMSRetidoTransporte.TabIndex = 12
        Me.lblICMSRetidoTransporte.Text = "ICMS Retido:"
        '
        'lblBaseCalculoTransporte
        '
        Me.lblBaseCalculoTransporte.AutoSize = True
        Me.lblBaseCalculoTransporte.Location = New System.Drawing.Point(6, 17)
        Me.lblBaseCalculoTransporte.Name = "lblBaseCalculoTransporte"
        Me.lblBaseCalculoTransporte.Size = New System.Drawing.Size(88, 14)
        Me.lblBaseCalculoTransporte.TabIndex = 0
        Me.lblBaseCalculoTransporte.Text = "Base de Cálculo:"
        '
        'pagVeiculo
        '
        Me.pagVeiculo.Controls.Add(Me.grpReboque)
        Me.pagVeiculo.Controls.Add(Me.grpVeiculo)
        Me.pagVeiculo.Controls.Add(Me.grdReboque)
        Me.pagVeiculo.Controls.Add(Me.grpBalsaoVagao)
        Me.pagVeiculo.Controls.Add(Me.grpTipoVeiculo)
        Me.pagVeiculo.Key = "pagVeiculo"
        Me.pagVeiculo.Location = New System.Drawing.Point(1, 22)
        Me.pagVeiculo.Name = "pagVeiculo"
        Me.pagVeiculo.Size = New System.Drawing.Size(877, 412)
        Me.pagVeiculo.TabStop = True
        Me.pagVeiculo.Text = "Veículo / Reboque / Balsa / Vagão"
        '
        'grpReboque
        '
        Me.grpReboque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpReboque.BackColor = System.Drawing.Color.Transparent
        Me.grpReboque.Controls.Add(Me.btnExcluirReboque)
        Me.grpReboque.Controls.Add(Me.btnInserirReboque)
        Me.grpReboque.Controls.Add(Me.lblRNTCReboque)
        Me.grpReboque.Controls.Add(Me.txtRNTCReboque)
        Me.grpReboque.Controls.Add(Me.cboUFReboque)
        Me.grpReboque.Controls.Add(Me.lblUFReboque)
        Me.grpReboque.Controls.Add(Me.txtPlacaReboque)
        Me.grpReboque.Controls.Add(Me.lblPlacaReboque)
        Me.grpReboque.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpReboque.Location = New System.Drawing.Point(320, 70)
        Me.grpReboque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpReboque.Name = "grpReboque"
        Me.grpReboque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpReboque.Size = New System.Drawing.Size(549, 64)
        Me.grpReboque.TabIndex = 2
        Me.grpReboque.Text = "Reboque"
        Me.grpReboque.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirReboque
        '
        Me.btnExcluirReboque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirReboque.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirReboque.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirReboque.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirReboque.Location = New System.Drawing.Point(449, 31)
        Me.btnExcluirReboque.Name = "btnExcluirReboque"
        Me.btnExcluirReboque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirReboque.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirReboque.TabIndex = 7
        Me.btnExcluirReboque.Text = "Excluir"
        Me.btnExcluirReboque.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirReboque
        '
        Me.btnInserirReboque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirReboque.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirReboque.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirReboque.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirReboque.Location = New System.Drawing.Point(352, 31)
        Me.btnInserirReboque.Name = "btnInserirReboque"
        Me.btnInserirReboque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirReboque.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirReboque.TabIndex = 6
        Me.btnInserirReboque.Text = "Inserir"
        Me.btnInserirReboque.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblRNTCReboque
        '
        Me.lblRNTCReboque.AutoSize = True
        Me.lblRNTCReboque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRNTCReboque.Location = New System.Drawing.Point(150, 17)
        Me.lblRNTCReboque.Name = "lblRNTCReboque"
        Me.lblRNTCReboque.Size = New System.Drawing.Size(37, 14)
        Me.lblRNTCReboque.TabIndex = 4
        Me.lblRNTCReboque.Text = "RNTC:"
        '
        'txtRNTCReboque
        '
        Me.txtRNTCReboque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRNTCReboque.Location = New System.Drawing.Point(153, 34)
        Me.txtRNTCReboque.MaxLength = 20
        Me.txtRNTCReboque.Name = "txtRNTCReboque"
        Me.txtRNTCReboque.Size = New System.Drawing.Size(141, 20)
        Me.txtRNTCReboque.TabIndex = 5
        '
        'cboUFReboque
        '
        Me.cboUFReboque.AutoSize = False
        Me.cboUFReboque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFReboque.Location = New System.Drawing.Point(95, 34)
        Me.cboUFReboque.Name = "cboUFReboque"
        Me.cboUFReboque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFReboque.Size = New System.Drawing.Size(52, 20)
        Me.cboUFReboque.TabIndex = 3
        '
        'lblUFReboque
        '
        Me.lblUFReboque.AutoSize = True
        Me.lblUFReboque.Location = New System.Drawing.Point(92, 17)
        Me.lblUFReboque.Name = "lblUFReboque"
        Me.lblUFReboque.Size = New System.Drawing.Size(23, 14)
        Me.lblUFReboque.TabIndex = 2
        Me.lblUFReboque.Text = "UF:"
        '
        'txtPlacaReboque
        '
        Me.txtPlacaReboque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaReboque.Location = New System.Drawing.Point(9, 34)
        Me.txtPlacaReboque.Mask = "LLL-0000"
        Me.txtPlacaReboque.MaxLength = 10
        Me.txtPlacaReboque.Name = "txtPlacaReboque"
        Me.txtPlacaReboque.Size = New System.Drawing.Size(80, 20)
        Me.txtPlacaReboque.TabIndex = 1
        '
        'lblPlacaReboque
        '
        Me.lblPlacaReboque.AutoSize = True
        Me.lblPlacaReboque.Location = New System.Drawing.Point(6, 17)
        Me.lblPlacaReboque.Name = "lblPlacaReboque"
        Me.lblPlacaReboque.Size = New System.Drawing.Size(36, 14)
        Me.lblPlacaReboque.TabIndex = 0
        Me.lblPlacaReboque.Text = "Placa:"
        '
        'grpVeiculo
        '
        Me.grpVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.grpVeiculo.Controls.Add(Me.lblRNTCVeiculo)
        Me.grpVeiculo.Controls.Add(Me.txtRNTCVeiculo)
        Me.grpVeiculo.Controls.Add(Me.cboUFVeiculo)
        Me.grpVeiculo.Controls.Add(Me.lblUFVeiculo)
        Me.grpVeiculo.Controls.Add(Me.txtPlacaVeiculo)
        Me.grpVeiculo.Controls.Add(Me.lblPlacaVeiculo)
        Me.grpVeiculo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpVeiculo.Location = New System.Drawing.Point(8, 70)
        Me.grpVeiculo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpVeiculo.Name = "grpVeiculo"
        Me.grpVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpVeiculo.Size = New System.Drawing.Size(303, 64)
        Me.grpVeiculo.TabIndex = 1
        Me.grpVeiculo.Text = "Veículo"
        Me.grpVeiculo.VisualStyleManager = Me.vsmMain
        '
        'lblRNTCVeiculo
        '
        Me.lblRNTCVeiculo.AutoSize = True
        Me.lblRNTCVeiculo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRNTCVeiculo.Location = New System.Drawing.Point(150, 17)
        Me.lblRNTCVeiculo.Name = "lblRNTCVeiculo"
        Me.lblRNTCVeiculo.Size = New System.Drawing.Size(37, 14)
        Me.lblRNTCVeiculo.TabIndex = 4
        Me.lblRNTCVeiculo.Text = "RNTC:"
        '
        'txtRNTCVeiculo
        '
        Me.txtRNTCVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRNTCVeiculo.Location = New System.Drawing.Point(153, 34)
        Me.txtRNTCVeiculo.MaxLength = 20
        Me.txtRNTCVeiculo.Name = "txtRNTCVeiculo"
        Me.txtRNTCVeiculo.Size = New System.Drawing.Size(141, 20)
        Me.txtRNTCVeiculo.TabIndex = 5
        '
        'cboUFVeiculo
        '
        Me.cboUFVeiculo.AutoSize = False
        Me.cboUFVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFVeiculo.Location = New System.Drawing.Point(95, 34)
        Me.cboUFVeiculo.Name = "cboUFVeiculo"
        Me.cboUFVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFVeiculo.Size = New System.Drawing.Size(52, 20)
        Me.cboUFVeiculo.TabIndex = 3
        '
        'lblUFVeiculo
        '
        Me.lblUFVeiculo.AutoSize = True
        Me.lblUFVeiculo.Location = New System.Drawing.Point(92, 17)
        Me.lblUFVeiculo.Name = "lblUFVeiculo"
        Me.lblUFVeiculo.Size = New System.Drawing.Size(23, 14)
        Me.lblUFVeiculo.TabIndex = 2
        Me.lblUFVeiculo.Text = "UF:"
        '
        'txtPlacaVeiculo
        '
        Me.txtPlacaVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaVeiculo.Location = New System.Drawing.Point(9, 34)
        Me.txtPlacaVeiculo.Mask = "LLL-0000"
        Me.txtPlacaVeiculo.MaxLength = 10
        Me.txtPlacaVeiculo.Name = "txtPlacaVeiculo"
        Me.txtPlacaVeiculo.Size = New System.Drawing.Size(80, 20)
        Me.txtPlacaVeiculo.TabIndex = 1
        '
        'lblPlacaVeiculo
        '
        Me.lblPlacaVeiculo.AutoSize = True
        Me.lblPlacaVeiculo.Location = New System.Drawing.Point(6, 17)
        Me.lblPlacaVeiculo.Name = "lblPlacaVeiculo"
        Me.lblPlacaVeiculo.Size = New System.Drawing.Size(36, 14)
        Me.lblPlacaVeiculo.TabIndex = 0
        Me.lblPlacaVeiculo.Text = "Placa:"
        '
        'grdReboque
        '
        Me.grdReboque.AllowDrop = True
        Me.grdReboque.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdReboque.AlternatingColors = True
        Me.grdReboque.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdReboque.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.grdReboque.ColumnAutoResize = True
        grdReboque_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdReboque_DesignTimeLayout_Reference_0.Instance"), Object)
        grdReboque_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdReboque_DesignTimeLayout_Reference_0})
        grdReboque_DesignTimeLayout.LayoutString = resources.GetString("grdReboque_DesignTimeLayout.LayoutString")
        Me.grdReboque.DesignTimeLayout = grdReboque_DesignTimeLayout
        Me.grdReboque.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdReboque.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdReboque.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdReboque.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdReboque.FrozenColumns = 3
        Me.grdReboque.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdReboque.GroupByBoxVisible = False
        Me.grdReboque.Location = New System.Drawing.Point(320, 143)
        Me.grdReboque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdReboque.Name = "grdReboque"
        Me.grdReboque.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdReboque.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdReboque.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdReboque.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdReboque.Size = New System.Drawing.Size(549, 260)
        Me.grdReboque.TabIndex = 3
        Me.grdReboque.TabStop = False
        Me.grdReboque.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdReboque.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdReboque.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdReboque.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdReboque.VisualStyleManager = Me.vsmMain
        '
        'grpBalsaoVagao
        '
        Me.grpBalsaoVagao.BackColor = System.Drawing.Color.Transparent
        Me.grpBalsaoVagao.Controls.Add(Me.lblVagao)
        Me.grpBalsaoVagao.Controls.Add(Me.txtVagao)
        Me.grpBalsaoVagao.Controls.Add(Me.lblBalsa)
        Me.grpBalsaoVagao.Controls.Add(Me.txtBalsa)
        Me.grpBalsaoVagao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpBalsaoVagao.Location = New System.Drawing.Point(8, 137)
        Me.grpBalsaoVagao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpBalsaoVagao.Name = "grpBalsaoVagao"
        Me.grpBalsaoVagao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBalsaoVagao.Size = New System.Drawing.Size(303, 104)
        Me.grpBalsaoVagao.TabIndex = 4
        Me.grpBalsaoVagao.Text = "Balsa / Vagão"
        Me.grpBalsaoVagao.VisualStyleManager = Me.vsmMain
        '
        'lblVagao
        '
        Me.lblVagao.AutoSize = True
        Me.lblVagao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVagao.Location = New System.Drawing.Point(6, 57)
        Me.lblVagao.Name = "lblVagao"
        Me.lblVagao.Size = New System.Drawing.Size(41, 14)
        Me.lblVagao.TabIndex = 2
        Me.lblVagao.Text = "Vagão:"
        '
        'txtVagao
        '
        Me.txtVagao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVagao.Location = New System.Drawing.Point(9, 74)
        Me.txtVagao.MaxLength = 20
        Me.txtVagao.Name = "txtVagao"
        Me.txtVagao.Size = New System.Drawing.Size(285, 20)
        Me.txtVagao.TabIndex = 3
        '
        'lblBalsa
        '
        Me.lblBalsa.AutoSize = True
        Me.lblBalsa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBalsa.Location = New System.Drawing.Point(6, 17)
        Me.lblBalsa.Name = "lblBalsa"
        Me.lblBalsa.Size = New System.Drawing.Size(37, 14)
        Me.lblBalsa.TabIndex = 0
        Me.lblBalsa.Text = "Balsa:"
        '
        'txtBalsa
        '
        Me.txtBalsa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBalsa.Location = New System.Drawing.Point(9, 34)
        Me.txtBalsa.MaxLength = 20
        Me.txtBalsa.Name = "txtBalsa"
        Me.txtBalsa.Size = New System.Drawing.Size(285, 20)
        Me.txtBalsa.TabIndex = 1
        '
        'grpTipoVeiculo
        '
        Me.grpTipoVeiculo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTipoVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.grpTipoVeiculo.Controls.Add(Me.lblTipoVeiculo)
        Me.grpTipoVeiculo.Controls.Add(Me.cboTipoVeiculo)
        Me.grpTipoVeiculo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpTipoVeiculo.Location = New System.Drawing.Point(8, 3)
        Me.grpTipoVeiculo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpTipoVeiculo.Name = "grpTipoVeiculo"
        Me.grpTipoVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTipoVeiculo.Size = New System.Drawing.Size(861, 64)
        Me.grpTipoVeiculo.TabIndex = 0
        Me.grpTipoVeiculo.VisualStyleManager = Me.vsmMain
        '
        'lblTipoVeiculo
        '
        Me.lblTipoVeiculo.AutoSize = True
        Me.lblTipoVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoVeiculo.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoVeiculo.Name = "lblTipoVeiculo"
        Me.lblTipoVeiculo.Size = New System.Drawing.Size(83, 14)
        Me.lblTipoVeiculo.TabIndex = 0
        Me.lblTipoVeiculo.Text = "Tipo de Veículo:"
        '
        'cboTipoVeiculo
        '
        Me.cboTipoVeiculo.AutoSize = False
        Me.cboTipoVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoVeiculo.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoVeiculo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoVeiculo.Name = "cboTipoVeiculo"
        Me.cboTipoVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoVeiculo.Size = New System.Drawing.Size(285, 20)
        Me.cboTipoVeiculo.TabIndex = 1
        '
        'pagVolume
        '
        Me.pagVolume.Controls.Add(Me.grdVolume)
        Me.pagVolume.Controls.Add(Me.grpVolume)
        Me.pagVolume.Key = "pagVolume"
        Me.pagVolume.Location = New System.Drawing.Point(1, 22)
        Me.pagVolume.Name = "pagVolume"
        Me.pagVolume.Size = New System.Drawing.Size(877, 412)
        Me.pagVolume.TabStop = True
        Me.pagVolume.Text = "Volume"
        '
        'grdVolume
        '
        Me.grdVolume.AllowDrop = True
        Me.grdVolume.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdVolume.AlternatingColors = True
        Me.grdVolume.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVolume.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.grdVolume.ColumnAutoResize = True
        grdVolume_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdVolume_DesignTimeLayout_Reference_0.Instance"), Object)
        grdVolume_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdVolume_DesignTimeLayout_Reference_1.Instance"), Object)
        grdVolume_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdVolume_DesignTimeLayout_Reference_0, grdVolume_DesignTimeLayout_Reference_1})
        grdVolume_DesignTimeLayout.LayoutString = resources.GetString("grdVolume_DesignTimeLayout.LayoutString")
        Me.grdVolume.DesignTimeLayout = grdVolume_DesignTimeLayout
        Me.grdVolume.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdVolume.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVolume.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVolume.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVolume.FrozenColumns = 3
        Me.grdVolume.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVolume.GroupByBoxVisible = False
        Me.grdVolume.Location = New System.Drawing.Point(8, 115)
        Me.grdVolume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdVolume.Name = "grdVolume"
        Me.grdVolume.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVolume.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVolume.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVolume.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVolume.Size = New System.Drawing.Size(861, 288)
        Me.grdVolume.TabIndex = 1
        Me.grdVolume.TabStop = False
        Me.grdVolume.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVolume.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdVolume.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdVolume.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdVolume.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVolume.VisualStyleManager = Me.vsmMain
        '
        'grpVolume
        '
        Me.grpVolume.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpVolume.BackColor = System.Drawing.Color.Transparent
        Me.grpVolume.Controls.Add(Me.btnExcluirVolume)
        Me.grpVolume.Controls.Add(Me.btnInserirVolume)
        Me.grpVolume.Controls.Add(Me.txtPesoLiquidoTransportadora)
        Me.grpVolume.Controls.Add(Me.txtPesoBrutoTransportadora)
        Me.grpVolume.Controls.Add(Me.lblPesoLiquidoTransportadora)
        Me.grpVolume.Controls.Add(Me.lblPesoBrutoTransportadora)
        Me.grpVolume.Controls.Add(Me.txtNumeroTransportadora)
        Me.grpVolume.Controls.Add(Me.lblNumeroTransportadora)
        Me.grpVolume.Controls.Add(Me.txtMarcaTransportadora)
        Me.grpVolume.Controls.Add(Me.lblMarcaTransportadora)
        Me.grpVolume.Controls.Add(Me.txtEspecieTransportadora)
        Me.grpVolume.Controls.Add(Me.lblEspecieTransportadora)
        Me.grpVolume.Controls.Add(Me.txtQuantidadeEmbalagemTransportadora)
        Me.grpVolume.Controls.Add(Me.lblQuantidadeEmbalagemTransportadora)
        Me.grpVolume.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpVolume.Location = New System.Drawing.Point(8, 3)
        Me.grpVolume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpVolume.Name = "grpVolume"
        Me.grpVolume.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpVolume.Size = New System.Drawing.Size(861, 104)
        Me.grpVolume.TabIndex = 0
        Me.grpVolume.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirVolume
        '
        Me.btnExcluirVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirVolume.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirVolume.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirVolume.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirVolume.Location = New System.Drawing.Point(761, 71)
        Me.btnExcluirVolume.Name = "btnExcluirVolume"
        Me.btnExcluirVolume.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirVolume.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirVolume.TabIndex = 13
        Me.btnExcluirVolume.Text = "Excluir"
        Me.btnExcluirVolume.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirVolume
        '
        Me.btnInserirVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirVolume.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirVolume.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirVolume.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirVolume.Location = New System.Drawing.Point(761, 42)
        Me.btnInserirVolume.Name = "btnInserirVolume"
        Me.btnInserirVolume.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirVolume.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirVolume.TabIndex = 12
        Me.btnInserirVolume.Text = "Inserir"
        Me.btnInserirVolume.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPesoLiquidoTransportadora
        '
        Me.txtPesoLiquidoTransportadora.DecimalDigits = 2
        Me.txtPesoLiquidoTransportadora.Location = New System.Drawing.Point(138, 74)
        Me.txtPesoLiquidoTransportadora.Name = "txtPesoLiquidoTransportadora"
        Me.txtPesoLiquidoTransportadora.Size = New System.Drawing.Size(123, 20)
        Me.txtPesoLiquidoTransportadora.TabIndex = 9
        Me.txtPesoLiquidoTransportadora.Text = "0,00"
        Me.txtPesoLiquidoTransportadora.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtPesoBrutoTransportadora
        '
        Me.txtPesoBrutoTransportadora.DecimalDigits = 2
        Me.txtPesoBrutoTransportadora.Location = New System.Drawing.Point(267, 74)
        Me.txtPesoBrutoTransportadora.Name = "txtPesoBrutoTransportadora"
        Me.txtPesoBrutoTransportadora.Size = New System.Drawing.Size(123, 20)
        Me.txtPesoBrutoTransportadora.TabIndex = 11
        Me.txtPesoBrutoTransportadora.Text = "0,00"
        Me.txtPesoBrutoTransportadora.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPesoLiquidoTransportadora
        '
        Me.lblPesoLiquidoTransportadora.AutoSize = True
        Me.lblPesoLiquidoTransportadora.Location = New System.Drawing.Point(134, 57)
        Me.lblPesoLiquidoTransportadora.Name = "lblPesoLiquidoTransportadora"
        Me.lblPesoLiquidoTransportadora.Size = New System.Drawing.Size(71, 14)
        Me.lblPesoLiquidoTransportadora.TabIndex = 8
        Me.lblPesoLiquidoTransportadora.Text = "Peso Líquido:"
        '
        'lblPesoBrutoTransportadora
        '
        Me.lblPesoBrutoTransportadora.AutoSize = True
        Me.lblPesoBrutoTransportadora.Location = New System.Drawing.Point(264, 57)
        Me.lblPesoBrutoTransportadora.Name = "lblPesoBrutoTransportadora"
        Me.lblPesoBrutoTransportadora.Size = New System.Drawing.Size(63, 14)
        Me.lblPesoBrutoTransportadora.TabIndex = 10
        Me.lblPesoBrutoTransportadora.Text = "Peso Bruto:"
        '
        'txtNumeroTransportadora
        '
        Me.txtNumeroTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroTransportadora.Location = New System.Drawing.Point(9, 74)
        Me.txtNumeroTransportadora.MaxLength = 60
        Me.txtNumeroTransportadora.Name = "txtNumeroTransportadora"
        Me.txtNumeroTransportadora.Size = New System.Drawing.Size(123, 20)
        Me.txtNumeroTransportadora.TabIndex = 7
        '
        'lblNumeroTransportadora
        '
        Me.lblNumeroTransportadora.AutoSize = True
        Me.lblNumeroTransportadora.Location = New System.Drawing.Point(6, 57)
        Me.lblNumeroTransportadora.Name = "lblNumeroTransportadora"
        Me.lblNumeroTransportadora.Size = New System.Drawing.Size(47, 14)
        Me.lblNumeroTransportadora.TabIndex = 6
        Me.lblNumeroTransportadora.Text = "Número:"
        '
        'txtMarcaTransportadora
        '
        Me.txtMarcaTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaTransportadora.Location = New System.Drawing.Point(396, 34)
        Me.txtMarcaTransportadora.MaxLength = 60
        Me.txtMarcaTransportadora.Name = "txtMarcaTransportadora"
        Me.txtMarcaTransportadora.Size = New System.Drawing.Size(252, 20)
        Me.txtMarcaTransportadora.TabIndex = 5
        '
        'lblMarcaTransportadora
        '
        Me.lblMarcaTransportadora.AutoSize = True
        Me.lblMarcaTransportadora.Location = New System.Drawing.Point(393, 17)
        Me.lblMarcaTransportadora.Name = "lblMarcaTransportadora"
        Me.lblMarcaTransportadora.Size = New System.Drawing.Size(40, 14)
        Me.lblMarcaTransportadora.TabIndex = 4
        Me.lblMarcaTransportadora.Text = "Marca:"
        '
        'txtEspecieTransportadora
        '
        Me.txtEspecieTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspecieTransportadora.Location = New System.Drawing.Point(138, 34)
        Me.txtEspecieTransportadora.MaxLength = 60
        Me.txtEspecieTransportadora.Name = "txtEspecieTransportadora"
        Me.txtEspecieTransportadora.Size = New System.Drawing.Size(252, 20)
        Me.txtEspecieTransportadora.TabIndex = 3
        '
        'lblEspecieTransportadora
        '
        Me.lblEspecieTransportadora.AutoSize = True
        Me.lblEspecieTransportadora.Location = New System.Drawing.Point(135, 17)
        Me.lblEspecieTransportadora.Name = "lblEspecieTransportadora"
        Me.lblEspecieTransportadora.Size = New System.Drawing.Size(48, 14)
        Me.lblEspecieTransportadora.TabIndex = 2
        Me.lblEspecieTransportadora.Text = "Espécie:"
        '
        'txtQuantidadeEmbalagemTransportadora
        '
        Me.txtQuantidadeEmbalagemTransportadora.DecimalDigits = 0
        Me.txtQuantidadeEmbalagemTransportadora.Location = New System.Drawing.Point(9, 34)
        Me.txtQuantidadeEmbalagemTransportadora.Name = "txtQuantidadeEmbalagemTransportadora"
        Me.txtQuantidadeEmbalagemTransportadora.Size = New System.Drawing.Size(123, 20)
        Me.txtQuantidadeEmbalagemTransportadora.TabIndex = 1
        Me.txtQuantidadeEmbalagemTransportadora.Text = "0"
        Me.txtQuantidadeEmbalagemTransportadora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblQuantidadeEmbalagemTransportadora
        '
        Me.lblQuantidadeEmbalagemTransportadora.AutoSize = True
        Me.lblQuantidadeEmbalagemTransportadora.Location = New System.Drawing.Point(6, 17)
        Me.lblQuantidadeEmbalagemTransportadora.Name = "lblQuantidadeEmbalagemTransportadora"
        Me.lblQuantidadeEmbalagemTransportadora.Size = New System.Drawing.Size(93, 14)
        Me.lblQuantidadeEmbalagemTransportadora.TabIndex = 0
        Me.lblQuantidadeEmbalagemTransportadora.Text = "Qtde. Embalagem:"
        '
        'pagTotais
        '
        Me.pagTotais.Controls.Add(Me.grpICMS)
        Me.pagTotais.Key = "pagTotais"
        Me.pagTotais.Location = New System.Drawing.Point(1, 22)
        Me.pagTotais.Name = "pagTotais"
        Me.pagTotais.Size = New System.Drawing.Size(895, 450)
        Me.pagTotais.TabStop = True
        Me.pagTotais.Text = "Totais"
        '
        'grpICMS
        '
        Me.grpICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMS.BackColor = System.Drawing.Color.Transparent
        Me.grpICMS.Controls.Add(Me.txtTotalICMSDestino)
        Me.grpICMS.Controls.Add(Me.lblTotalICMSDestino)
        Me.grpICMS.Controls.Add(Me.txtTotalICMSRemetente)
        Me.grpICMS.Controls.Add(Me.lblTotalICMSRemetente)
        Me.grpICMS.Controls.Add(Me.txtTotalFCP)
        Me.grpICMS.Controls.Add(Me.lblTotalFCP)
        Me.grpICMS.Controls.Add(Me.txtTotalNotaFiscal)
        Me.grpICMS.Controls.Add(Me.lblTotalNotaFiscal)
        Me.grpICMS.Controls.Add(Me.txtOutrasDespesas)
        Me.grpICMS.Controls.Add(Me.lblOutrasDespesas)
        Me.grpICMS.Controls.Add(Me.txtTotalCOFINS)
        Me.grpICMS.Controls.Add(Me.lblTotalCOFINS)
        Me.grpICMS.Controls.Add(Me.txtTotalPIS)
        Me.grpICMS.Controls.Add(Me.lblTotalPIS)
        Me.grpICMS.Controls.Add(Me.txtTotalIPI)
        Me.grpICMS.Controls.Add(Me.lblTotalIPI)
        Me.grpICMS.Controls.Add(Me.txtTotalII)
        Me.grpICMS.Controls.Add(Me.lblTotalII)
        Me.grpICMS.Controls.Add(Me.txtTotalDesconto)
        Me.grpICMS.Controls.Add(Me.lblTotalDesconto)
        Me.grpICMS.Controls.Add(Me.txtTotalSeguro)
        Me.grpICMS.Controls.Add(Me.lblTotalSeguro)
        Me.grpICMS.Controls.Add(Me.txtTotalFrete)
        Me.grpICMS.Controls.Add(Me.lblTotalFrete)
        Me.grpICMS.Controls.Add(Me.txtTotalProdutoServico)
        Me.grpICMS.Controls.Add(Me.lblTotalProdutoServico)
        Me.grpICMS.Controls.Add(Me.txtTotalICMSST)
        Me.grpICMS.Controls.Add(Me.lblTotalICMSST)
        Me.grpICMS.Controls.Add(Me.txtBaseCalculoICMSST)
        Me.grpICMS.Controls.Add(Me.lblBaseCalculoICMSST)
        Me.grpICMS.Controls.Add(Me.txtTotalICMS)
        Me.grpICMS.Controls.Add(Me.lblTotalICMS)
        Me.grpICMS.Controls.Add(Me.txtBaseCalculoICMS)
        Me.grpICMS.Controls.Add(Me.lblBaseCalculoICMS)
        Me.grpICMS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMS.Location = New System.Drawing.Point(8, 3)
        Me.grpICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMS.Name = "grpICMS"
        Me.grpICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMS.Size = New System.Drawing.Size(879, 144)
        Me.grpICMS.TabIndex = 1
        Me.grpICMS.Text = "ICMS"
        Me.grpICMS.VisualStyleManager = Me.vsmMain
        '
        'txtTotalICMSDestino
        '
        Me.txtTotalICMSDestino.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalICMSDestino.Enabled = False
        Me.txtTotalICMSDestino.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalICMSDestino.Location = New System.Drawing.Point(576, 114)
        Me.txtTotalICMSDestino.Name = "txtTotalICMSDestino"
        Me.txtTotalICMSDestino.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalICMSDestino.TabIndex = 39
        Me.txtTotalICMSDestino.Text = "0,00"
        Me.txtTotalICMSDestino.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalICMSDestino
        '
        Me.lblTotalICMSDestino.AutoSize = True
        Me.lblTotalICMSDestino.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalICMSDestino.Location = New System.Drawing.Point(573, 97)
        Me.lblTotalICMSDestino.Name = "lblTotalICMSDestino"
        Me.lblTotalICMSDestino.Size = New System.Drawing.Size(98, 14)
        Me.lblTotalICMSDestino.TabIndex = 38
        Me.lblTotalICMSDestino.Text = "Total ICMS Destino:"
        '
        'txtTotalICMSRemetente
        '
        Me.txtTotalICMSRemetente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalICMSRemetente.Enabled = False
        Me.txtTotalICMSRemetente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalICMSRemetente.Location = New System.Drawing.Point(576, 74)
        Me.txtTotalICMSRemetente.Name = "txtTotalICMSRemetente"
        Me.txtTotalICMSRemetente.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalICMSRemetente.TabIndex = 37
        Me.txtTotalICMSRemetente.Text = "0,00"
        Me.txtTotalICMSRemetente.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalICMSRemetente
        '
        Me.lblTotalICMSRemetente.AutoSize = True
        Me.lblTotalICMSRemetente.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalICMSRemetente.Location = New System.Drawing.Point(573, 57)
        Me.lblTotalICMSRemetente.Name = "lblTotalICMSRemetente"
        Me.lblTotalICMSRemetente.Size = New System.Drawing.Size(113, 14)
        Me.lblTotalICMSRemetente.TabIndex = 36
        Me.lblTotalICMSRemetente.Text = "Total ICMS Remetente:"
        '
        'txtTotalFCP
        '
        Me.txtTotalFCP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalFCP.Enabled = False
        Me.txtTotalFCP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFCP.Location = New System.Drawing.Point(576, 34)
        Me.txtTotalFCP.Name = "txtTotalFCP"
        Me.txtTotalFCP.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalFCP.TabIndex = 35
        Me.txtTotalFCP.Text = "0,00"
        Me.txtTotalFCP.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalFCP
        '
        Me.lblTotalFCP.AutoSize = True
        Me.lblTotalFCP.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalFCP.Location = New System.Drawing.Point(573, 17)
        Me.lblTotalFCP.Name = "lblTotalFCP"
        Me.lblTotalFCP.Size = New System.Drawing.Size(54, 14)
        Me.lblTotalFCP.TabIndex = 34
        Me.lblTotalFCP.Text = "Total FCP:"
        '
        'txtTotalNotaFiscal
        '
        Me.txtTotalNotaFiscal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalNotaFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalNotaFiscal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalNotaFiscal.Location = New System.Drawing.Point(737, 114)
        Me.txtTotalNotaFiscal.Name = "txtTotalNotaFiscal"
        Me.txtTotalNotaFiscal.ReadOnly = True
        Me.txtTotalNotaFiscal.Size = New System.Drawing.Size(133, 20)
        Me.txtTotalNotaFiscal.TabIndex = 27
        Me.txtTotalNotaFiscal.TabStop = False
        Me.txtTotalNotaFiscal.Text = "0,00"
        Me.txtTotalNotaFiscal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalNotaFiscal
        '
        Me.lblTotalNotaFiscal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalNotaFiscal.AutoSize = True
        Me.lblTotalNotaFiscal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalNotaFiscal.Location = New System.Drawing.Point(734, 97)
        Me.lblTotalNotaFiscal.Name = "lblTotalNotaFiscal"
        Me.lblTotalNotaFiscal.Size = New System.Drawing.Size(103, 14)
        Me.lblTotalNotaFiscal.TabIndex = 26
        Me.lblTotalNotaFiscal.Text = "Total da Nota Fiscal:"
        '
        'txtOutrasDespesas
        '
        Me.txtOutrasDespesas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOutrasDespesas.Location = New System.Drawing.Point(435, 74)
        Me.txtOutrasDespesas.Name = "txtOutrasDespesas"
        Me.txtOutrasDespesas.ReadOnly = True
        Me.txtOutrasDespesas.Size = New System.Drawing.Size(136, 20)
        Me.txtOutrasDespesas.TabIndex = 15
        Me.txtOutrasDespesas.TabStop = False
        Me.txtOutrasDespesas.Text = "0,00"
        Me.txtOutrasDespesas.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblOutrasDespesas
        '
        Me.lblOutrasDespesas.AutoSize = True
        Me.lblOutrasDespesas.BackColor = System.Drawing.Color.Transparent
        Me.lblOutrasDespesas.Location = New System.Drawing.Point(432, 57)
        Me.lblOutrasDespesas.Name = "lblOutrasDespesas"
        Me.lblOutrasDespesas.Size = New System.Drawing.Size(95, 14)
        Me.lblOutrasDespesas.TabIndex = 14
        Me.lblOutrasDespesas.Text = "Outras Despesas:"
        '
        'txtTotalCOFINS
        '
        Me.txtTotalCOFINS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalCOFINS.Location = New System.Drawing.Point(435, 114)
        Me.txtTotalCOFINS.Name = "txtTotalCOFINS"
        Me.txtTotalCOFINS.ReadOnly = True
        Me.txtTotalCOFINS.Size = New System.Drawing.Size(135, 20)
        Me.txtTotalCOFINS.TabIndex = 23
        Me.txtTotalCOFINS.TabStop = False
        Me.txtTotalCOFINS.Text = "0,00"
        Me.txtTotalCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalCOFINS
        '
        Me.lblTotalCOFINS.AutoSize = True
        Me.lblTotalCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCOFINS.Location = New System.Drawing.Point(432, 97)
        Me.lblTotalCOFINS.Name = "lblTotalCOFINS"
        Me.lblTotalCOFINS.Size = New System.Drawing.Size(47, 14)
        Me.lblTotalCOFINS.TabIndex = 22
        Me.lblTotalCOFINS.Text = "COFINS:"
        '
        'txtTotalPIS
        '
        Me.txtTotalPIS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalPIS.Location = New System.Drawing.Point(293, 114)
        Me.txtTotalPIS.Name = "txtTotalPIS"
        Me.txtTotalPIS.ReadOnly = True
        Me.txtTotalPIS.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalPIS.TabIndex = 21
        Me.txtTotalPIS.TabStop = False
        Me.txtTotalPIS.Text = "0,00"
        Me.txtTotalPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalPIS
        '
        Me.lblTotalPIS.AutoSize = True
        Me.lblTotalPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPIS.Location = New System.Drawing.Point(290, 97)
        Me.lblTotalPIS.Name = "lblTotalPIS"
        Me.lblTotalPIS.Size = New System.Drawing.Size(25, 14)
        Me.lblTotalPIS.TabIndex = 20
        Me.lblTotalPIS.Text = "PIS:"
        '
        'txtTotalIPI
        '
        Me.txtTotalIPI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalIPI.Location = New System.Drawing.Point(151, 114)
        Me.txtTotalIPI.Name = "txtTotalIPI"
        Me.txtTotalIPI.ReadOnly = True
        Me.txtTotalIPI.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalIPI.TabIndex = 19
        Me.txtTotalIPI.TabStop = False
        Me.txtTotalIPI.Text = "0,00"
        Me.txtTotalIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalIPI
        '
        Me.lblTotalIPI.AutoSize = True
        Me.lblTotalIPI.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalIPI.Location = New System.Drawing.Point(148, 97)
        Me.lblTotalIPI.Name = "lblTotalIPI"
        Me.lblTotalIPI.Size = New System.Drawing.Size(60, 14)
        Me.lblTotalIPI.TabIndex = 18
        Me.lblTotalIPI.Text = "Total do IPI:"
        '
        'txtTotalII
        '
        Me.txtTotalII.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalII.Location = New System.Drawing.Point(9, 114)
        Me.txtTotalII.Name = "txtTotalII"
        Me.txtTotalII.ReadOnly = True
        Me.txtTotalII.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalII.TabIndex = 17
        Me.txtTotalII.TabStop = False
        Me.txtTotalII.Text = "0,00"
        Me.txtTotalII.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalII
        '
        Me.lblTotalII.AutoSize = True
        Me.lblTotalII.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalII.Location = New System.Drawing.Point(6, 97)
        Me.lblTotalII.Name = "lblTotalII"
        Me.lblTotalII.Size = New System.Drawing.Size(54, 14)
        Me.lblTotalII.TabIndex = 16
        Me.lblTotalII.Text = "Total do II:"
        '
        'txtTotalDesconto
        '
        Me.txtTotalDesconto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalDesconto.Location = New System.Drawing.Point(293, 74)
        Me.txtTotalDesconto.Name = "txtTotalDesconto"
        Me.txtTotalDesconto.ReadOnly = True
        Me.txtTotalDesconto.Size = New System.Drawing.Size(135, 20)
        Me.txtTotalDesconto.TabIndex = 13
        Me.txtTotalDesconto.TabStop = False
        Me.txtTotalDesconto.Text = "0,00"
        Me.txtTotalDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalDesconto
        '
        Me.lblTotalDesconto.AutoSize = True
        Me.lblTotalDesconto.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalDesconto.Location = New System.Drawing.Point(290, 57)
        Me.lblTotalDesconto.Name = "lblTotalDesconto"
        Me.lblTotalDesconto.Size = New System.Drawing.Size(96, 14)
        Me.lblTotalDesconto.TabIndex = 12
        Me.lblTotalDesconto.Text = "Total do Desconto:"
        '
        'txtTotalSeguro
        '
        Me.txtTotalSeguro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalSeguro.Location = New System.Drawing.Point(151, 74)
        Me.txtTotalSeguro.Name = "txtTotalSeguro"
        Me.txtTotalSeguro.ReadOnly = True
        Me.txtTotalSeguro.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalSeguro.TabIndex = 11
        Me.txtTotalSeguro.TabStop = False
        Me.txtTotalSeguro.Text = "0,00"
        Me.txtTotalSeguro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalSeguro
        '
        Me.lblTotalSeguro.AutoSize = True
        Me.lblTotalSeguro.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSeguro.Location = New System.Drawing.Point(148, 57)
        Me.lblTotalSeguro.Name = "lblTotalSeguro"
        Me.lblTotalSeguro.Size = New System.Drawing.Size(85, 14)
        Me.lblTotalSeguro.TabIndex = 10
        Me.lblTotalSeguro.Text = "Total do Seguro:"
        '
        'txtTotalFrete
        '
        Me.txtTotalFrete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalFrete.Location = New System.Drawing.Point(9, 74)
        Me.txtTotalFrete.Name = "txtTotalFrete"
        Me.txtTotalFrete.ReadOnly = True
        Me.txtTotalFrete.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalFrete.TabIndex = 9
        Me.txtTotalFrete.TabStop = False
        Me.txtTotalFrete.Text = "0,00"
        Me.txtTotalFrete.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalFrete
        '
        Me.lblTotalFrete.AutoSize = True
        Me.lblTotalFrete.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalFrete.Location = New System.Drawing.Point(6, 57)
        Me.lblTotalFrete.Name = "lblTotalFrete"
        Me.lblTotalFrete.Size = New System.Drawing.Size(75, 14)
        Me.lblTotalFrete.TabIndex = 8
        Me.lblTotalFrete.Text = "Total do Frete:"
        '
        'txtTotalProdutoServico
        '
        Me.txtTotalProdutoServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalProdutoServico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalProdutoServico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalProdutoServico.Location = New System.Drawing.Point(737, 74)
        Me.txtTotalProdutoServico.Name = "txtTotalProdutoServico"
        Me.txtTotalProdutoServico.ReadOnly = True
        Me.txtTotalProdutoServico.Size = New System.Drawing.Size(133, 20)
        Me.txtTotalProdutoServico.TabIndex = 25
        Me.txtTotalProdutoServico.TabStop = False
        Me.txtTotalProdutoServico.Text = "0,00"
        Me.txtTotalProdutoServico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalProdutoServico
        '
        Me.lblTotalProdutoServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalProdutoServico.AutoSize = True
        Me.lblTotalProdutoServico.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalProdutoServico.Location = New System.Drawing.Point(734, 57)
        Me.lblTotalProdutoServico.Name = "lblTotalProdutoServico"
        Me.lblTotalProdutoServico.Size = New System.Drawing.Size(93, 14)
        Me.lblTotalProdutoServico.TabIndex = 24
        Me.lblTotalProdutoServico.Text = "Total de Produtos:"
        '
        'txtTotalICMSST
        '
        Me.txtTotalICMSST.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalICMSST.Location = New System.Drawing.Point(435, 34)
        Me.txtTotalICMSST.Name = "txtTotalICMSST"
        Me.txtTotalICMSST.ReadOnly = True
        Me.txtTotalICMSST.Size = New System.Drawing.Size(135, 20)
        Me.txtTotalICMSST.TabIndex = 7
        Me.txtTotalICMSST.TabStop = False
        Me.txtTotalICMSST.Text = "0,00"
        Me.txtTotalICMSST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalICMSST
        '
        Me.lblTotalICMSST.AutoSize = True
        Me.lblTotalICMSST.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalICMSST.Location = New System.Drawing.Point(432, 17)
        Me.lblTotalICMSST.Name = "lblTotalICMSST"
        Me.lblTotalICMSST.Size = New System.Drawing.Size(74, 14)
        Me.lblTotalICMSST.TabIndex = 6
        Me.lblTotalICMSST.Text = "Total ICMS ST:"
        '
        'txtBaseCalculoICMSST
        '
        Me.txtBaseCalculoICMSST.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBaseCalculoICMSST.Location = New System.Drawing.Point(293, 34)
        Me.txtBaseCalculoICMSST.Name = "txtBaseCalculoICMSST"
        Me.txtBaseCalculoICMSST.ReadOnly = True
        Me.txtBaseCalculoICMSST.Size = New System.Drawing.Size(136, 20)
        Me.txtBaseCalculoICMSST.TabIndex = 5
        Me.txtBaseCalculoICMSST.TabStop = False
        Me.txtBaseCalculoICMSST.Text = "0,00"
        Me.txtBaseCalculoICMSST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoICMSST
        '
        Me.lblBaseCalculoICMSST.AutoSize = True
        Me.lblBaseCalculoICMSST.BackColor = System.Drawing.Color.Transparent
        Me.lblBaseCalculoICMSST.Location = New System.Drawing.Point(290, 17)
        Me.lblBaseCalculoICMSST.Name = "lblBaseCalculoICMSST"
        Me.lblBaseCalculoICMSST.Size = New System.Drawing.Size(130, 14)
        Me.lblBaseCalculoICMSST.TabIndex = 4
        Me.lblBaseCalculoICMSST.Text = "Base de Cálculo ICMS ST:"
        '
        'txtTotalICMS
        '
        Me.txtTotalICMS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalICMS.Location = New System.Drawing.Point(151, 34)
        Me.txtTotalICMS.Name = "txtTotalICMS"
        Me.txtTotalICMS.ReadOnly = True
        Me.txtTotalICMS.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalICMS.TabIndex = 3
        Me.txtTotalICMS.TabStop = False
        Me.txtTotalICMS.Text = "0,00"
        Me.txtTotalICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalICMS
        '
        Me.lblTotalICMS.AutoSize = True
        Me.lblTotalICMS.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalICMS.Location = New System.Drawing.Point(148, 17)
        Me.lblTotalICMS.Name = "lblTotalICMS"
        Me.lblTotalICMS.Size = New System.Drawing.Size(74, 14)
        Me.lblTotalICMS.TabIndex = 2
        Me.lblTotalICMS.Text = "Total do ICMS:"
        '
        'txtBaseCalculoICMS
        '
        Me.txtBaseCalculoICMS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBaseCalculoICMS.Location = New System.Drawing.Point(9, 34)
        Me.txtBaseCalculoICMS.Name = "txtBaseCalculoICMS"
        Me.txtBaseCalculoICMS.ReadOnly = True
        Me.txtBaseCalculoICMS.Size = New System.Drawing.Size(136, 20)
        Me.txtBaseCalculoICMS.TabIndex = 1
        Me.txtBaseCalculoICMS.TabStop = False
        Me.txtBaseCalculoICMS.Text = "0,00"
        Me.txtBaseCalculoICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoICMS
        '
        Me.lblBaseCalculoICMS.AutoSize = True
        Me.lblBaseCalculoICMS.BackColor = System.Drawing.Color.Transparent
        Me.lblBaseCalculoICMS.Location = New System.Drawing.Point(6, 17)
        Me.lblBaseCalculoICMS.Name = "lblBaseCalculoICMS"
        Me.lblBaseCalculoICMS.Size = New System.Drawing.Size(88, 14)
        Me.lblBaseCalculoICMS.TabIndex = 0
        Me.lblBaseCalculoICMS.Text = "Base de Cálculo:"
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
        Me.grpTituloPrevisto.Controls.Add(Me.txtTituloDescritivo)
        Me.grpTituloPrevisto.Controls.Add(Me.lblTituloDescritivo)
        Me.grpTituloPrevisto.Controls.Add(Me.btnProcurarCentroCusto)
        Me.grpTituloPrevisto.Controls.Add(Me.lblCentroGasto)
        Me.grpTituloPrevisto.Controls.Add(Me.cboCentroGasto)
        Me.grpTituloPrevisto.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpTituloPrevisto.Controls.Add(Me.btnVincular)
        Me.grpTituloPrevisto.Controls.Add(Me.txtNumDocumentoPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.lblTituloPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.txtValorPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.cboTituloPrevisto)
        Me.grpTituloPrevisto.Controls.Add(Me.lblTituloValor)
        Me.grpTituloPrevisto.Controls.Add(Me.lblTituloNumeroDocumento)
        Me.grpTituloPrevisto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpTituloPrevisto.Location = New System.Drawing.Point(8, 74)
        Me.grpTituloPrevisto.Name = "grpTituloPrevisto"
        Me.grpTituloPrevisto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTituloPrevisto.Size = New System.Drawing.Size(641, 150)
        Me.grpTituloPrevisto.TabIndex = 1
        Me.grpTituloPrevisto.Text = "Dados do Título Previsto"
        Me.grpTituloPrevisto.VisualStyleManager = Me.vsmMain
        '
        'txtTituloDescritivo
        '
        Me.txtTituloDescritivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTituloDescritivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTituloDescritivo.Location = New System.Drawing.Point(14, 115)
        Me.txtTituloDescritivo.MaxLength = 60
        Me.txtTituloDescritivo.Name = "txtTituloDescritivo"
        Me.txtTituloDescritivo.Size = New System.Drawing.Size(515, 20)
        Me.txtTituloDescritivo.TabIndex = 13
        '
        'lblTituloDescritivo
        '
        Me.lblTituloDescritivo.AutoSize = True
        Me.lblTituloDescritivo.Location = New System.Drawing.Point(11, 98)
        Me.lblTituloDescritivo.Name = "lblTituloDescritivo"
        Me.lblTituloDescritivo.Size = New System.Drawing.Size(58, 14)
        Me.lblTituloDescritivo.TabIndex = 12
        Me.lblTituloDescritivo.Text = "Descritivo:"
        '
        'btnProcurarCentroCusto
        '
        Me.btnProcurarCentroCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCentroCusto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroCusto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroCusto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroCusto.Location = New System.Drawing.Point(512, 56)
        Me.btnProcurarCentroCusto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroCusto.Name = "btnProcurarCentroCusto"
        Me.btnProcurarCentroCusto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroCusto.TabIndex = 17
        Me.btnProcurarCentroCusto.TabStop = False
        Me.btnProcurarCentroCusto.UseVisualStyleBackColor = True
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(263, 58)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 15
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(247, 75)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(282, 20)
        Me.cboCentroGasto.TabIndex = 16
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(247, 58)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 14
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnVincular
        '
        Me.btnVincular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVincular.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnVincular.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVincular.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnVincular.Location = New System.Drawing.Point(535, 112)
        Me.btnVincular.Name = "btnVincular"
        Me.btnVincular.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVincular.Size = New System.Drawing.Size(98, 23)
        Me.btnVincular.TabIndex = 10
        Me.btnVincular.Text = "Vincular Título"
        Me.btnVincular.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtNumDocumentoPrevisto
        '
        Me.txtNumDocumentoPrevisto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumDocumentoPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumDocumentoPrevisto.Location = New System.Drawing.Point(14, 75)
        Me.txtNumDocumentoPrevisto.MaxLength = 60
        Me.txtNumDocumentoPrevisto.Name = "txtNumDocumentoPrevisto"
        Me.txtNumDocumentoPrevisto.ReadOnly = True
        Me.txtNumDocumentoPrevisto.Size = New System.Drawing.Size(90, 20)
        Me.txtNumDocumentoPrevisto.TabIndex = 3
        Me.txtNumDocumentoPrevisto.TabStop = False
        '
        'lblTituloPrevisto
        '
        Me.lblTituloPrevisto.AutoSize = True
        Me.lblTituloPrevisto.Location = New System.Drawing.Point(9, 17)
        Me.lblTituloPrevisto.Name = "lblTituloPrevisto"
        Me.lblTituloPrevisto.Size = New System.Drawing.Size(77, 14)
        Me.lblTituloPrevisto.TabIndex = 0
        Me.lblTituloPrevisto.Text = "Título Previsto:"
        '
        'txtValorPrevisto
        '
        Me.txtValorPrevisto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPrevisto.DecimalDigits = 2
        Me.txtValorPrevisto.Location = New System.Drawing.Point(110, 75)
        Me.txtValorPrevisto.MaxLength = 0
        Me.txtValorPrevisto.Name = "txtValorPrevisto"
        Me.txtValorPrevisto.ReadOnly = True
        Me.txtValorPrevisto.Size = New System.Drawing.Size(131, 20)
        Me.txtValorPrevisto.TabIndex = 7
        Me.txtValorPrevisto.Text = "0,00"
        Me.txtValorPrevisto.Value = 0.0R
        Me.txtValorPrevisto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'cboTituloPrevisto
        '
        Me.cboTituloPrevisto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTituloPrevisto.AutoSize = False
        Me.cboTituloPrevisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTituloPrevisto.Location = New System.Drawing.Point(12, 34)
        Me.cboTituloPrevisto.Name = "cboTituloPrevisto"
        Me.cboTituloPrevisto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTituloPrevisto.Size = New System.Drawing.Size(517, 20)
        Me.cboTituloPrevisto.TabIndex = 1
        '
        'lblTituloValor
        '
        Me.lblTituloValor.AutoSize = True
        Me.lblTituloValor.Location = New System.Drawing.Point(107, 58)
        Me.lblTituloValor.Name = "lblTituloValor"
        Me.lblTituloValor.Size = New System.Drawing.Size(35, 14)
        Me.lblTituloValor.TabIndex = 6
        Me.lblTituloValor.Text = "Valor:"
        '
        'lblTituloNumeroDocumento
        '
        Me.lblTituloNumeroDocumento.AutoSize = True
        Me.lblTituloNumeroDocumento.Location = New System.Drawing.Point(11, 58)
        Me.lblTituloNumeroDocumento.Name = "lblTituloNumeroDocumento"
        Me.lblTituloNumeroDocumento.Size = New System.Drawing.Size(78, 14)
        Me.lblTituloNumeroDocumento.TabIndex = 2
        Me.lblTituloNumeroDocumento.Text = "N° Documento:"
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
        Me.grpDuplicata.Size = New System.Drawing.Size(229, 334)
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
        Me.btnCalcularDuplicata.TabIndex = 7
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
        Me.grdDuplicata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDuplicata.CellToolTipText = "Duplo Clique para editar o Registro"
        Me.grdDuplicata.ColumnAutoResize = True
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
        Me.grdDuplicata.Size = New System.Drawing.Size(211, 179)
        Me.grdDuplicata.TabIndex = 6
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
        Me.grpFatura.Controls.Add(Me.txtValorPago)
        Me.grpFatura.Controls.Add(Me.lblValorPago)
        Me.grpFatura.Controls.Add(Me.txtValorAcrescimo)
        Me.grpFatura.Controls.Add(Me.lblValorAcrescimo)
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
        Me.grpFatura.Size = New System.Drawing.Size(641, 64)
        Me.grpFatura.TabIndex = 0
        Me.grpFatura.Text = "Fatura"
        Me.grpFatura.VisualStyleManager = Me.vsmMain
        '
        'txtValorPago
        '
        Me.txtValorPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorPago.Location = New System.Drawing.Point(443, 34)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(92, 20)
        Me.txtValorPago.TabIndex = 9
        Me.txtValorPago.Text = "0,00"
        Me.txtValorPago.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorPago
        '
        Me.lblValorPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorPago.AutoSize = True
        Me.lblValorPago.Location = New System.Drawing.Point(440, 17)
        Me.lblValorPago.Name = "lblValorPago"
        Me.lblValorPago.Size = New System.Drawing.Size(62, 14)
        Me.lblValorPago.TabIndex = 8
        Me.lblValorPago.Text = "Valor Pago:"
        '
        'txtValorAcrescimo
        '
        Me.txtValorAcrescimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorAcrescimo.Location = New System.Drawing.Point(247, 34)
        Me.txtValorAcrescimo.Name = "txtValorAcrescimo"
        Me.txtValorAcrescimo.Size = New System.Drawing.Size(92, 20)
        Me.txtValorAcrescimo.TabIndex = 5
        Me.txtValorAcrescimo.Text = "0,00"
        Me.txtValorAcrescimo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorAcrescimo
        '
        Me.lblValorAcrescimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorAcrescimo.AutoSize = True
        Me.lblValorAcrescimo.Location = New System.Drawing.Point(244, 17)
        Me.lblValorAcrescimo.Name = "lblValorAcrescimo"
        Me.lblValorAcrescimo.Size = New System.Drawing.Size(89, 14)
        Me.lblValorAcrescimo.TabIndex = 4
        Me.lblValorAcrescimo.Text = "Valor Acréscimo:"
        '
        'txtValorLiquido
        '
        Me.txtValorLiquido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorLiquido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorLiquido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorLiquido.Location = New System.Drawing.Point(541, 34)
        Me.txtValorLiquido.Name = "txtValorLiquido"
        Me.txtValorLiquido.ReadOnly = True
        Me.txtValorLiquido.Size = New System.Drawing.Size(92, 20)
        Me.txtValorLiquido.TabIndex = 11
        Me.txtValorLiquido.TabStop = False
        Me.txtValorLiquido.Text = "0,00"
        Me.txtValorLiquido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorLiquido
        '
        Me.lblValorLiquido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorLiquido.AutoSize = True
        Me.lblValorLiquido.Location = New System.Drawing.Point(538, 17)
        Me.lblValorLiquido.Name = "lblValorLiquido"
        Me.lblValorLiquido.Size = New System.Drawing.Size(72, 14)
        Me.lblValorLiquido.TabIndex = 10
        Me.lblValorLiquido.Text = "Valor Líquido:"
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorDesconto.Location = New System.Drawing.Point(345, 34)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.Size = New System.Drawing.Size(92, 20)
        Me.txtValorDesconto.TabIndex = 7
        Me.txtValorDesconto.Text = "0,00"
        Me.txtValorDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDesconto
        '
        Me.lblValorDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorDesconto.AutoSize = True
        Me.lblValorDesconto.Location = New System.Drawing.Point(342, 17)
        Me.lblValorDesconto.Name = "lblValorDesconto"
        Me.lblValorDesconto.Size = New System.Drawing.Size(84, 14)
        Me.lblValorDesconto.TabIndex = 6
        Me.lblValorDesconto.Text = "Valor Desconto:"
        '
        'txtValorOriginal
        '
        Me.txtValorOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorOriginal.Location = New System.Drawing.Point(149, 34)
        Me.txtValorOriginal.Name = "txtValorOriginal"
        Me.txtValorOriginal.Size = New System.Drawing.Size(92, 20)
        Me.txtValorOriginal.TabIndex = 3
        Me.txtValorOriginal.Text = "0,00"
        Me.txtValorOriginal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorOriginal
        '
        Me.lblValorOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorOriginal.AutoSize = True
        Me.lblValorOriginal.Location = New System.Drawing.Point(146, 17)
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
        Me.txtFatura.MaxLength = 60
        Me.txtFatura.Name = "txtFatura"
        Me.txtFatura.Size = New System.Drawing.Size(134, 20)
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
        'pagInformacoesAdicionais
        '
        Me.pagInformacoesAdicionais.Controls.Add(Me.grpInformacaoAdicional)
        Me.pagInformacoesAdicionais.Key = "pagInformacoesAdicionais"
        Me.pagInformacoesAdicionais.Location = New System.Drawing.Point(1, 22)
        Me.pagInformacoesAdicionais.Name = "pagInformacoesAdicionais"
        Me.pagInformacoesAdicionais.Size = New System.Drawing.Size(895, 450)
        Me.pagInformacoesAdicionais.TabStop = True
        Me.pagInformacoesAdicionais.Text = "Informações Adicionais"
        '
        'grpInformacaoAdicional
        '
        Me.grpInformacaoAdicional.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacaoAdicional.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacaoAdicional.Controls.Add(Me.lblDadosAdicionaisFISCO)
        Me.grpInformacaoAdicional.Controls.Add(Me.txtInformacaoAdicionalFisco)
        Me.grpInformacaoAdicional.Controls.Add(Me.lblDadosAdicionaisContribuinte)
        Me.grpInformacaoAdicional.Controls.Add(Me.txtInformacaoAdicionalContribuinte)
        Me.grpInformacaoAdicional.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpInformacaoAdicional.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacaoAdicional.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInformacaoAdicional.Name = "grpInformacaoAdicional"
        Me.grpInformacaoAdicional.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacaoAdicional.Size = New System.Drawing.Size(879, 437)
        Me.grpInformacaoAdicional.TabIndex = 0
        Me.grpInformacaoAdicional.Text = "Informações Adicionais"
        Me.grpInformacaoAdicional.VisualStyleManager = Me.vsmMain
        '
        'lblDadosAdicionaisFISCO
        '
        Me.lblDadosAdicionaisFISCO.AutoSize = True
        Me.lblDadosAdicionaisFISCO.Location = New System.Drawing.Point(6, 265)
        Me.lblDadosAdicionaisFISCO.Name = "lblDadosAdicionaisFISCO"
        Me.lblDadosAdicionaisFISCO.Size = New System.Drawing.Size(197, 14)
        Me.lblDadosAdicionaisFISCO.TabIndex = 14
        Me.lblDadosAdicionaisFISCO.Text = "Dados Adicionais (Interesse do FISCO):"
        '
        'txtInformacaoAdicionalFisco
        '
        Me.txtInformacaoAdicionalFisco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInformacaoAdicionalFisco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInformacaoAdicionalFisco.Location = New System.Drawing.Point(9, 282)
        Me.txtInformacaoAdicionalFisco.MaxLength = 2000
        Me.txtInformacaoAdicionalFisco.Multiline = True
        Me.txtInformacaoAdicionalFisco.Name = "txtInformacaoAdicionalFisco"
        Me.txtInformacaoAdicionalFisco.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInformacaoAdicionalFisco.Size = New System.Drawing.Size(861, 146)
        Me.txtInformacaoAdicionalFisco.TabIndex = 15
        '
        'lblDadosAdicionaisContribuinte
        '
        Me.lblDadosAdicionaisContribuinte.AutoSize = True
        Me.lblDadosAdicionaisContribuinte.Location = New System.Drawing.Point(6, 17)
        Me.lblDadosAdicionaisContribuinte.Name = "lblDadosAdicionaisContribuinte"
        Me.lblDadosAdicionaisContribuinte.Size = New System.Drawing.Size(224, 14)
        Me.lblDadosAdicionaisContribuinte.TabIndex = 12
        Me.lblDadosAdicionaisContribuinte.Text = "Dados Adicionais (Interesse do Contribuinte):"
        '
        'txtInformacaoAdicionalContribuinte
        '
        Me.txtInformacaoAdicionalContribuinte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInformacaoAdicionalContribuinte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInformacaoAdicionalContribuinte.Location = New System.Drawing.Point(9, 34)
        Me.txtInformacaoAdicionalContribuinte.MaxLength = 5000
        Me.txtInformacaoAdicionalContribuinte.Multiline = True
        Me.txtInformacaoAdicionalContribuinte.Name = "txtInformacaoAdicionalContribuinte"
        Me.txtInformacaoAdicionalContribuinte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInformacaoAdicionalContribuinte.Size = New System.Drawing.Size(861, 228)
        Me.txtInformacaoAdicionalContribuinte.TabIndex = 13
        '
        'pagExportacaoCompras
        '
        Me.pagExportacaoCompras.Controls.Add(Me.grpCompra)
        Me.pagExportacaoCompras.Controls.Add(Me.grpExportacao)
        Me.pagExportacaoCompras.Key = "pagExportacaoCompras"
        Me.pagExportacaoCompras.Location = New System.Drawing.Point(1, 22)
        Me.pagExportacaoCompras.Name = "pagExportacaoCompras"
        Me.pagExportacaoCompras.Size = New System.Drawing.Size(895, 450)
        Me.pagExportacaoCompras.TabStop = True
        Me.pagExportacaoCompras.Text = "Exportação e Compras"
        '
        'grpCompra
        '
        Me.grpCompra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCompra.BackColor = System.Drawing.Color.Transparent
        Me.grpCompra.Controls.Add(Me.lblInformacaoContrato)
        Me.grpCompra.Controls.Add(Me.txtInformacaoContrato)
        Me.grpCompra.Controls.Add(Me.lblInformacaoPedido)
        Me.grpCompra.Controls.Add(Me.txtInformacaoPedido)
        Me.grpCompra.Controls.Add(Me.lblNotaEmpenho)
        Me.grpCompra.Controls.Add(Me.txtNotaEmpenho)
        Me.grpCompra.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCompra.Location = New System.Drawing.Point(8, 70)
        Me.grpCompra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCompra.Name = "grpCompra"
        Me.grpCompra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCompra.Size = New System.Drawing.Size(879, 67)
        Me.grpCompra.TabIndex = 1
        Me.grpCompra.Text = "Compra"
        Me.grpCompra.VisualStyleManager = Me.vsmMain
        '
        'lblInformacaoContrato
        '
        Me.lblInformacaoContrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInformacaoContrato.AutoSize = True
        Me.lblInformacaoContrato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInformacaoContrato.Location = New System.Drawing.Point(503, 20)
        Me.lblInformacaoContrato.Name = "lblInformacaoContrato"
        Me.lblInformacaoContrato.Size = New System.Drawing.Size(129, 14)
        Me.lblInformacaoContrato.TabIndex = 4
        Me.lblInformacaoContrato.Text = "Informações do Contrato:"
        '
        'txtInformacaoContrato
        '
        Me.txtInformacaoContrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInformacaoContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInformacaoContrato.Location = New System.Drawing.Point(506, 37)
        Me.txtInformacaoContrato.MaxLength = 60
        Me.txtInformacaoContrato.Name = "txtInformacaoContrato"
        Me.txtInformacaoContrato.Size = New System.Drawing.Size(364, 20)
        Me.txtInformacaoContrato.TabIndex = 5
        '
        'lblInformacaoPedido
        '
        Me.lblInformacaoPedido.AutoSize = True
        Me.lblInformacaoPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInformacaoPedido.Location = New System.Drawing.Point(132, 20)
        Me.lblInformacaoPedido.Name = "lblInformacaoPedido"
        Me.lblInformacaoPedido.Size = New System.Drawing.Size(120, 14)
        Me.lblInformacaoPedido.TabIndex = 2
        Me.lblInformacaoPedido.Text = "Informações do Pedido:"
        '
        'txtInformacaoPedido
        '
        Me.txtInformacaoPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInformacaoPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInformacaoPedido.Location = New System.Drawing.Point(135, 37)
        Me.txtInformacaoPedido.MaxLength = 60
        Me.txtInformacaoPedido.Name = "txtInformacaoPedido"
        Me.txtInformacaoPedido.Size = New System.Drawing.Size(365, 20)
        Me.txtInformacaoPedido.TabIndex = 3
        '
        'lblNotaEmpenho
        '
        Me.lblNotaEmpenho.AutoSize = True
        Me.lblNotaEmpenho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotaEmpenho.Location = New System.Drawing.Point(6, 20)
        Me.lblNotaEmpenho.Name = "lblNotaEmpenho"
        Me.lblNotaEmpenho.Size = New System.Drawing.Size(94, 14)
        Me.lblNotaEmpenho.TabIndex = 0
        Me.lblNotaEmpenho.Text = "Nota de Empenho:"
        '
        'txtNotaEmpenho
        '
        Me.txtNotaEmpenho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaEmpenho.Location = New System.Drawing.Point(9, 37)
        Me.txtNotaEmpenho.MaxLength = 17
        Me.txtNotaEmpenho.Name = "txtNotaEmpenho"
        Me.txtNotaEmpenho.Size = New System.Drawing.Size(120, 20)
        Me.txtNotaEmpenho.TabIndex = 1
        '
        'grpExportacao
        '
        Me.grpExportacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpExportacao.BackColor = System.Drawing.Color.Transparent
        Me.grpExportacao.Controls.Add(Me.lblLocalEmbarque)
        Me.grpExportacao.Controls.Add(Me.txtLocalEmbarque)
        Me.grpExportacao.Controls.Add(Me.cboUFEmbarque)
        Me.grpExportacao.Controls.Add(Me.lblUFEmbarque)
        Me.grpExportacao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpExportacao.Location = New System.Drawing.Point(8, 3)
        Me.grpExportacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpExportacao.Name = "grpExportacao"
        Me.grpExportacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpExportacao.Size = New System.Drawing.Size(879, 64)
        Me.grpExportacao.TabIndex = 0
        Me.grpExportacao.Text = "Exportação:"
        Me.grpExportacao.VisualStyleManager = Me.vsmMain
        '
        'lblLocalEmbarque
        '
        Me.lblLocalEmbarque.AutoSize = True
        Me.lblLocalEmbarque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLocalEmbarque.Location = New System.Drawing.Point(132, 17)
        Me.lblLocalEmbarque.Name = "lblLocalEmbarque"
        Me.lblLocalEmbarque.Size = New System.Drawing.Size(102, 14)
        Me.lblLocalEmbarque.TabIndex = 2
        Me.lblLocalEmbarque.Text = "Local de Embarque:"
        '
        'txtLocalEmbarque
        '
        Me.txtLocalEmbarque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocalEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalEmbarque.Location = New System.Drawing.Point(135, 34)
        Me.txtLocalEmbarque.MaxLength = 60
        Me.txtLocalEmbarque.Name = "txtLocalEmbarque"
        Me.txtLocalEmbarque.Size = New System.Drawing.Size(365, 20)
        Me.txtLocalEmbarque.TabIndex = 3
        '
        'cboUFEmbarque
        '
        Me.cboUFEmbarque.AutoSize = False
        Me.cboUFEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFEmbarque.Location = New System.Drawing.Point(9, 34)
        Me.cboUFEmbarque.Name = "cboUFEmbarque"
        Me.cboUFEmbarque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFEmbarque.Size = New System.Drawing.Size(120, 20)
        Me.cboUFEmbarque.TabIndex = 1
        '
        'lblUFEmbarque
        '
        Me.lblUFEmbarque.AutoSize = True
        Me.lblUFEmbarque.Location = New System.Drawing.Point(6, 17)
        Me.lblUFEmbarque.Name = "lblUFEmbarque"
        Me.lblUFEmbarque.Size = New System.Drawing.Size(74, 14)
        Me.lblUFEmbarque.TabIndex = 0
        Me.lblUFEmbarque.Text = "UF Embarque:"
        '
        'pagArquivos
        '
        Me.pagArquivos.Controls.Add(Me.btnExcelGridArquivo)
        Me.pagArquivos.Controls.Add(Me.btnAgruparGridArquivo)
        Me.pagArquivos.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagArquivos.Controls.Add(Me.grpArquivo)
        Me.pagArquivos.Controls.Add(Me.grdArquivo)
        Me.pagArquivos.Key = "pagArquivos"
        Me.pagArquivos.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivos.Name = "pagArquivos"
        Me.pagArquivos.Size = New System.Drawing.Size(895, 450)
        Me.pagArquivos.TabStop = True
        Me.pagArquivos.Text = "Arquivos"
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 424)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 100
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
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 424)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 99
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
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 424)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 98
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
        Me.grpArquivo.TabIndex = 96
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
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 325)
        Me.grdArquivo.TabIndex = 97
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'pagProdutoXML
        '
        Me.pagProdutoXML.Controls.Add(Me.grpEntrega)
        Me.pagProdutoXML.Controls.Add(Me.grdRecebimento)
        Me.pagProdutoXML.Controls.Add(Me.grpControleDados)
        Me.pagProdutoXML.Controls.Add(Me.grdXML)
        Me.pagProdutoXML.Controls.Add(Me.txtTeste)
        Me.pagProdutoXML.Location = New System.Drawing.Point(1, 22)
        Me.pagProdutoXML.Name = "pagProdutoXML"
        Me.pagProdutoXML.Size = New System.Drawing.Size(895, 450)
        Me.pagProdutoXML.TabStop = True
        Me.pagProdutoXML.Text = "Produto - XML"
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.btnFindCFOPDestinacao)
        Me.grpEntrega.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpEntrega.Controls.Add(Me.lblContaContabil)
        Me.grpEntrega.Controls.Add(Me.cboContaContabil)
        Me.grpEntrega.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpEntrega.Controls.Add(Me.Button1)
        Me.grpEntrega.Controls.Add(Me.Label1)
        Me.grpEntrega.Controls.Add(Me.UiComboBox1)
        Me.grpEntrega.Controls.Add(Me.btnAtualizarPedidoCompra)
        Me.grpEntrega.Controls.Add(Me.lblQuantidadeDocumento)
        Me.grpEntrega.Controls.Add(Me.txtQuantidadeDocumento)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpEntrega.Controls.Add(Me.lblUnidadeMedida)
        Me.grpEntrega.Controls.Add(Me.cboUnidadeMedida)
        Me.grpEntrega.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpEntrega.Controls.Add(Me.txtQuantidadeEstoque)
        Me.grpEntrega.Controls.Add(Me.lblDataFabricacao)
        Me.grpEntrega.Controls.Add(Me.dtpDataFabricacao)
        Me.grpEntrega.Controls.Add(Me.btnProcurarProduto)
        Me.grpEntrega.Controls.Add(Me.lblDataValidade)
        Me.grpEntrega.Controls.Add(Me.dtpDataValidade)
        Me.grpEntrega.Controls.Add(Me.lblLote)
        Me.grpEntrega.Controls.Add(Me.txtLote)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarProduto)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarCFOP)
        Me.grpEntrega.Controls.Add(Me.lblCFOP)
        Me.grpEntrega.Controls.Add(Me.cboCFOP)
        Me.grpEntrega.Controls.Add(Me.lblFatorConversao)
        Me.grpEntrega.Controls.Add(Me.txtFatorConversao)
        Me.grpEntrega.Controls.Add(Me.lblProduto)
        Me.grpEntrega.Controls.Add(Me.btnExcluirXML)
        Me.grpEntrega.Controls.Add(Me.btnInserir)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarDeposito)
        Me.grpEntrega.Controls.Add(Me.lblNumeroDocumento)
        Me.grpEntrega.Controls.Add(Me.cboNumeroDocumento)
        Me.grpEntrega.Controls.Add(Me.lblDeposito)
        Me.grpEntrega.Controls.Add(Me.cboDeposito)
        Me.grpEntrega.Controls.Add(Me.lblQuantidade)
        Me.grpEntrega.Controls.Add(Me.txtQuantidade)
        Me.grpEntrega.Controls.Add(Me.lblTipoOperacao)
        Me.grpEntrega.Controls.Add(Me.cboTipoOperacao)
        Me.grpEntrega.Controls.Add(Me.cboProduto)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(8, 140)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(879, 138)
        Me.grpEntrega.TabIndex = 11
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'btnFindCFOPDestinacao
        '
        Me.btnFindCFOPDestinacao.FlatAppearance.BorderSize = 0
        Me.btnFindCFOPDestinacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindCFOPDestinacao.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnFindCFOPDestinacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFindCFOPDestinacao.Location = New System.Drawing.Point(97, 11)
        Me.btnFindCFOPDestinacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFindCFOPDestinacao.Name = "btnFindCFOPDestinacao"
        Me.btnFindCFOPDestinacao.Size = New System.Drawing.Size(17, 16)
        Me.btnFindCFOPDestinacao.TabIndex = 46
        Me.btnFindCFOPDestinacao.TabStop = False
        Me.btnFindCFOPDestinacao.UseVisualStyleBackColor = True
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(839, 92)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 42
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(602, 94)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 40
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.Text = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaContabil.Location = New System.Drawing.Point(618, 93)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 41
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(602, 110)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(254, 20)
        Me.cboContaContabil.TabIndex = 43
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(575, 92)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 38
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(231, 94)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(13, 13)
        Me.Button1.TabIndex = 36
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(247, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 14)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Centro de Gasto:"
        '
        'UiComboBox1
        '
        Me.UiComboBox1.AutoSize = False
        Me.UiComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UiComboBox1.Location = New System.Drawing.Point(231, 110)
        Me.UiComboBox1.Name = "UiComboBox1"
        Me.UiComboBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiComboBox1.Size = New System.Drawing.Size(365, 20)
        Me.UiComboBox1.TabIndex = 39
        '
        'btnAtualizarPedidoCompra
        '
        Me.btnAtualizarPedidoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizarPedidoCompra.FlatAppearance.BorderSize = 0
        Me.btnAtualizarPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizarPedidoCompra.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAtualizarPedidoCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAtualizarPedidoCompra.Location = New System.Drawing.Point(737, 14)
        Me.btnAtualizarPedidoCompra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtualizarPedidoCompra.Name = "btnAtualizarPedidoCompra"
        Me.btnAtualizarPedidoCompra.Size = New System.Drawing.Size(15, 13)
        Me.btnAtualizarPedidoCompra.TabIndex = 13
        Me.btnAtualizarPedidoCompra.TabStop = False
        Me.btnAtualizarPedidoCompra.UseVisualStyleBackColor = True
        '
        'lblQuantidadeDocumento
        '
        Me.lblQuantidadeDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeDocumento.AutoSize = True
        Me.lblQuantidadeDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeDocumento.Location = New System.Drawing.Point(644, 13)
        Me.lblQuantidadeDocumento.Name = "lblQuantidadeDocumento"
        Me.lblQuantidadeDocumento.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeDocumento.TabIndex = 11
        Me.lblQuantidadeDocumento.Text = "Quantidade:"
        '
        'txtQuantidadeDocumento
        '
        Me.txtQuantidadeDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeDocumento.DecimalDigits = 4
        Me.txtQuantidadeDocumento.Location = New System.Drawing.Point(647, 30)
        Me.txtQuantidadeDocumento.Name = "txtQuantidadeDocumento"
        Me.txtQuantidadeDocumento.ReadOnly = True
        Me.txtQuantidadeDocumento.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidadeDocumento.TabIndex = 12
        Me.txtQuantidadeDocumento.TabStop = False
        Me.txtQuantidadeDocumento.Text = "0,0000"
        Me.txtQuantidadeDocumento.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(120, 54)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 18
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(136, 53)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(69, 14)
        Me.lblUnidadeMedida.TabIndex = 19
        Me.lblUnidadeMedida.Text = "Und. Medida:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(120, 70)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(105, 20)
        Me.cboUnidadeMedida.TabIndex = 20
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(339, 53)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeEstoque.TabIndex = 23
        Me.lblQuantidadeEstoque.Text = "Qtde. Estoque:"
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.DecimalDigits = 4
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(342, 70)
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidadeEstoque.TabIndex = 24
        Me.txtQuantidadeEstoque.Text = "0,0000"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDataFabricacao
        '
        Me.lblDataFabricacao.AutoSize = True
        Me.lblDataFabricacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFabricacao.Location = New System.Drawing.Point(6, 93)
        Me.lblDataFabricacao.Name = "lblDataFabricacao"
        Me.lblDataFabricacao.Size = New System.Drawing.Size(89, 14)
        Me.lblDataFabricacao.TabIndex = 30
        Me.lblDataFabricacao.Text = "Data Fabricação:"
        '
        'dtpDataFabricacao
        '
        '
        '
        '
        Me.dtpDataFabricacao.DropDownCalendar.Name = ""
        Me.dtpDataFabricacao.Location = New System.Drawing.Point(9, 110)
        Me.dtpDataFabricacao.Name = "dtpDataFabricacao"
        Me.dtpDataFabricacao.Size = New System.Drawing.Size(105, 20)
        Me.dtpDataFabricacao.TabIndex = 31
        Me.dtpDataFabricacao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(624, 16)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 9
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'lblDataValidade
        '
        Me.lblDataValidade.AutoSize = True
        Me.lblDataValidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataValidade.Location = New System.Drawing.Point(117, 93)
        Me.lblDataValidade.Name = "lblDataValidade"
        Me.lblDataValidade.Size = New System.Drawing.Size(76, 14)
        Me.lblDataValidade.TabIndex = 34
        Me.lblDataValidade.Text = "Data Validade:"
        '
        'dtpDataValidade
        '
        '
        '
        '
        Me.dtpDataValidade.DropDownCalendar.Name = ""
        Me.dtpDataValidade.Location = New System.Drawing.Point(120, 110)
        Me.dtpDataValidade.Name = "dtpDataValidade"
        Me.dtpDataValidade.Size = New System.Drawing.Size(105, 20)
        Me.dtpDataValidade.TabIndex = 35
        Me.dtpDataValidade.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblLote
        '
        Me.lblLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(644, 53)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(85, 14)
        Me.lblLote.TabIndex = 28
        Me.lblLote.Text = "Lote Fabricante:"
        '
        'txtLote
        '
        Me.txtLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(647, 70)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(105, 20)
        Me.txtLote.TabIndex = 29
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(453, 14)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 7
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarCFOP
        '
        Me.btnCadastrarCFOP.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCFOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCFOP.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCFOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCFOP.Location = New System.Drawing.Point(9, 14)
        Me.btnCadastrarCFOP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCFOP.Name = "btnCadastrarCFOP"
        Me.btnCadastrarCFOP.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCFOP.TabIndex = 0
        Me.btnCadastrarCFOP.TabStop = False
        Me.btnCadastrarCFOP.UseVisualStyleBackColor = True
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCFOP.Location = New System.Drawing.Point(25, 13)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 1
        Me.lblCFOP.Text = "CFOP:"
        '
        'cboCFOP
        '
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCFOP.Location = New System.Drawing.Point(9, 30)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(105, 20)
        Me.cboCFOP.TabIndex = 2
        '
        'lblFatorConversao
        '
        Me.lblFatorConversao.AutoSize = True
        Me.lblFatorConversao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFatorConversao.Location = New System.Drawing.Point(228, 53)
        Me.lblFatorConversao.Name = "lblFatorConversao"
        Me.lblFatorConversao.Size = New System.Drawing.Size(91, 14)
        Me.lblFatorConversao.TabIndex = 21
        Me.lblFatorConversao.Text = "Fator Conversão:"
        '
        'txtFatorConversao
        '
        Me.txtFatorConversao.DecimalDigits = 4
        Me.txtFatorConversao.Location = New System.Drawing.Point(231, 70)
        Me.txtFatorConversao.Name = "txtFatorConversao"
        Me.txtFatorConversao.Size = New System.Drawing.Size(105, 20)
        Me.txtFatorConversao.TabIndex = 22
        Me.txtFatorConversao.Text = "0,0000"
        Me.txtFatorConversao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProduto.Location = New System.Drawing.Point(469, 13)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 8
        Me.lblProduto.Text = "Produto:"
        '
        'btnExcluirXML
        '
        Me.btnExcluirXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirXML.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirXML.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirXML.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirXML.Location = New System.Drawing.Point(773, 55)
        Me.btnExcluirXML.Name = "btnExcluirXML"
        Me.btnExcluirXML.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirXML.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirXML.TabIndex = 45
        Me.btnExcluirXML.Text = "Excluir"
        Me.btnExcluirXML.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = CType(resources.GetObject("btnInserir.Image"), System.Drawing.Image)
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(773, 26)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 44
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarDeposito
        '
        Me.btnCadastrarDeposito.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDeposito.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDeposito.Location = New System.Drawing.Point(453, 54)
        Me.btnCadastrarDeposito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDeposito.Name = "btnCadastrarDeposito"
        Me.btnCadastrarDeposito.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDeposito.TabIndex = 25
        Me.btnCadastrarDeposito.TabStop = False
        Me.btnCadastrarDeposito.UseVisualStyleBackColor = True
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(339, 14)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 5
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'cboNumeroDocumento
        '
        Me.cboNumeroDocumento.AutoSize = False
        Me.cboNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroDocumento.Location = New System.Drawing.Point(342, 30)
        Me.cboNumeroDocumento.Name = "cboNumeroDocumento"
        Me.cboNumeroDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroDocumento.Size = New System.Drawing.Size(105, 20)
        Me.cboNumeroDocumento.TabIndex = 6
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(469, 53)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 26
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(453, 70)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(188, 20)
        Me.cboDeposito.TabIndex = 27
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 53)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 16
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 70)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidade.TabIndex = 17
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblTipoOperacao
        '
        Me.lblTipoOperacao.AutoSize = True
        Me.lblTipoOperacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoOperacao.Location = New System.Drawing.Point(117, 13)
        Me.lblTipoOperacao.Name = "lblTipoOperacao"
        Me.lblTipoOperacao.Size = New System.Drawing.Size(96, 14)
        Me.lblTipoOperacao.TabIndex = 3
        Me.lblTipoOperacao.Text = "Tipo de Operação:"
        '
        'cboTipoOperacao
        '
        Me.cboTipoOperacao.AutoSize = False
        Me.cboTipoOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoOperacao.Location = New System.Drawing.Point(120, 30)
        Me.cboTipoOperacao.Name = "cboTipoOperacao"
        Me.cboTipoOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoOperacao.Size = New System.Drawing.Size(216, 20)
        Me.cboTipoOperacao.TabIndex = 4
        '
        'cboProduto
        '
        Me.cboProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProduto.Location = New System.Drawing.Point(453, 30)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(188, 20)
        Me.cboProduto.TabIndex = 10
        '
        'grdRecebimento
        '
        Me.grdRecebimento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdRecebimento.AlternatingColors = True
        Me.grdRecebimento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRecebimento.AutoEdit = True
        grdRecebimento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRecebimento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRecebimento_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdRecebimento_DesignTimeLayout_Reference_1.Instance"), Object)
        grdRecebimento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRecebimento_DesignTimeLayout_Reference_0, grdRecebimento_DesignTimeLayout_Reference_1})
        grdRecebimento_DesignTimeLayout.LayoutString = resources.GetString("grdRecebimento_DesignTimeLayout.LayoutString")
        Me.grdRecebimento.DesignTimeLayout = grdRecebimento_DesignTimeLayout
        Me.grdRecebimento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdRecebimento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdRecebimento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRecebimento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRecebimento.FrozenColumns = 2
        Me.grdRecebimento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRecebimento.GroupByBoxVisible = False
        Me.grdRecebimento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRecebimento.Location = New System.Drawing.Point(8, 284)
        Me.grdRecebimento.Name = "grdRecebimento"
        Me.grdRecebimento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRecebimento.RecordNavigator = True
        Me.grdRecebimento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdRecebimento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRecebimento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRecebimento.Size = New System.Drawing.Size(879, 111)
        Me.grdRecebimento.TabIndex = 12
        Me.grdRecebimento.TabStop = False
        Me.grdRecebimento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRecebimento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdRecebimento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdRecebimento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdRecebimento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRecebimento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRecebimento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdRecebimento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRecebimento.VisualStyleManager = Me.vsmMain
        '
        'grpControleDados
        '
        Me.grpControleDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleDados.BackColor = System.Drawing.Color.Transparent
        Me.grpControleDados.Controls.Add(Me.txtAliquotaICMSUltimaNF)
        Me.grpControleDados.Controls.Add(Me.lblAliquotaPISCOFINSPedido)
        Me.grpControleDados.Controls.Add(Me.txtAliquotaPISCOFINSPedido)
        Me.grpControleDados.Controls.Add(Me.lblAliquotaIPIPedido)
        Me.grpControleDados.Controls.Add(Me.txtAliquotaIPIPedido)
        Me.grpControleDados.Controls.Add(Me.lblAliquotaICMSPedido)
        Me.grpControleDados.Controls.Add(Me.txtAliquotaICMSPedido)
        Me.grpControleDados.Controls.Add(Me.lblValorUnitarioPedido)
        Me.grpControleDados.Controls.Add(Me.btnConfirmar)
        Me.grpControleDados.Controls.Add(Me.txtValorUnitarioPedido)
        Me.grpControleDados.Controls.Add(Me.btnCancelar)
        Me.grpControleDados.Controls.Add(Me.lblAliquotaICMSUltimaNF)
        Me.grpControleDados.Location = New System.Drawing.Point(8, 395)
        Me.grpControleDados.Name = "grpControleDados"
        Me.grpControleDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleDados.Size = New System.Drawing.Size(879, 50)
        Me.grpControleDados.TabIndex = 13
        Me.grpControleDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControleDados.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaICMSUltimaNF
        '
        Me.txtAliquotaICMSUltimaNF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaICMSUltimaNF.DecimalDigits = 2
        Me.txtAliquotaICMSUltimaNF.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaICMSUltimaNF.Location = New System.Drawing.Point(630, 17)
        Me.txtAliquotaICMSUltimaNF.Name = "txtAliquotaICMSUltimaNF"
        Me.txtAliquotaICMSUltimaNF.ReadOnly = True
        Me.txtAliquotaICMSUltimaNF.Size = New System.Drawing.Size(51, 20)
        Me.txtAliquotaICMSUltimaNF.TabIndex = 9
        Me.txtAliquotaICMSUltimaNF.TabStop = False
        Me.txtAliquotaICMSUltimaNF.Text = "0,00%"
        Me.txtAliquotaICMSUltimaNF.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPISCOFINSPedido
        '
        Me.lblAliquotaPISCOFINSPedido.AutoSize = True
        Me.lblAliquotaPISCOFINSPedido.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAliquotaPISCOFINSPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaPISCOFINSPedido.Location = New System.Drawing.Point(377, 20)
        Me.lblAliquotaPISCOFINSPedido.Name = "lblAliquotaPISCOFINSPedido"
        Me.lblAliquotaPISCOFINSPedido.Size = New System.Drawing.Size(85, 13)
        Me.lblAliquotaPISCOFINSPedido.TabIndex = 6
        Me.lblAliquotaPISCOFINSPedido.Text = "% PIS/COFINS:"
        '
        'txtAliquotaPISCOFINSPedido
        '
        Me.txtAliquotaPISCOFINSPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaPISCOFINSPedido.DecimalDigits = 2
        Me.txtAliquotaPISCOFINSPedido.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaPISCOFINSPedido.Location = New System.Drawing.Point(465, 17)
        Me.txtAliquotaPISCOFINSPedido.Name = "txtAliquotaPISCOFINSPedido"
        Me.txtAliquotaPISCOFINSPedido.ReadOnly = True
        Me.txtAliquotaPISCOFINSPedido.Size = New System.Drawing.Size(51, 20)
        Me.txtAliquotaPISCOFINSPedido.TabIndex = 7
        Me.txtAliquotaPISCOFINSPedido.TabStop = False
        Me.txtAliquotaPISCOFINSPedido.Text = "0,00%"
        Me.txtAliquotaPISCOFINSPedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIPIPedido
        '
        Me.lblAliquotaIPIPedido.AutoSize = True
        Me.lblAliquotaIPIPedido.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAliquotaIPIPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaIPIPedido.Location = New System.Drawing.Point(286, 20)
        Me.lblAliquotaIPIPedido.Name = "lblAliquotaIPIPedido"
        Me.lblAliquotaIPIPedido.Size = New System.Drawing.Size(36, 13)
        Me.lblAliquotaIPIPedido.TabIndex = 4
        Me.lblAliquotaIPIPedido.Text = "% IPI:"
        '
        'txtAliquotaIPIPedido
        '
        Me.txtAliquotaIPIPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaIPIPedido.DecimalDigits = 2
        Me.txtAliquotaIPIPedido.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaIPIPedido.Location = New System.Drawing.Point(324, 17)
        Me.txtAliquotaIPIPedido.Name = "txtAliquotaIPIPedido"
        Me.txtAliquotaIPIPedido.ReadOnly = True
        Me.txtAliquotaIPIPedido.Size = New System.Drawing.Size(51, 20)
        Me.txtAliquotaIPIPedido.TabIndex = 5
        Me.txtAliquotaIPIPedido.TabStop = False
        Me.txtAliquotaIPIPedido.Text = "0,00%"
        Me.txtAliquotaIPIPedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSPedido
        '
        Me.lblAliquotaICMSPedido.AutoSize = True
        Me.lblAliquotaICMSPedido.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAliquotaICMSPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaICMSPedido.Location = New System.Drawing.Point(180, 20)
        Me.lblAliquotaICMSPedido.Name = "lblAliquotaICMSPedido"
        Me.lblAliquotaICMSPedido.Size = New System.Drawing.Size(51, 13)
        Me.lblAliquotaICMSPedido.TabIndex = 2
        Me.lblAliquotaICMSPedido.Text = "% ICMS:"
        '
        'txtAliquotaICMSPedido
        '
        Me.txtAliquotaICMSPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaICMSPedido.DecimalDigits = 2
        Me.txtAliquotaICMSPedido.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaICMSPedido.Location = New System.Drawing.Point(233, 17)
        Me.txtAliquotaICMSPedido.Name = "txtAliquotaICMSPedido"
        Me.txtAliquotaICMSPedido.ReadOnly = True
        Me.txtAliquotaICMSPedido.Size = New System.Drawing.Size(51, 20)
        Me.txtAliquotaICMSPedido.TabIndex = 3
        Me.txtAliquotaICMSPedido.TabStop = False
        Me.txtAliquotaICMSPedido.Text = "0,00%"
        Me.txtAliquotaICMSPedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorUnitarioPedido
        '
        Me.lblValorUnitarioPedido.AutoSize = True
        Me.lblValorUnitarioPedido.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblValorUnitarioPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorUnitarioPedido.Location = New System.Drawing.Point(-1, 21)
        Me.lblValorUnitarioPedido.Name = "lblValorUnitarioPedido"
        Me.lblValorUnitarioPedido.Size = New System.Drawing.Size(90, 13)
        Me.lblValorUnitarioPedido.TabIndex = 0
        Me.lblValorUnitarioPedido.Text = "Valor Unitário:"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnConfirmar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmar.Location = New System.Drawing.Point(685, 17)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfirmar.Size = New System.Drawing.Size(91, 23)
        Me.btnConfirmar.TabIndex = 10
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtValorUnitarioPedido
        '
        Me.txtValorUnitarioPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorUnitarioPedido.DecimalDigits = 4
        Me.txtValorUnitarioPedido.Location = New System.Drawing.Point(91, 18)
        Me.txtValorUnitarioPedido.Name = "txtValorUnitarioPedido"
        Me.txtValorUnitarioPedido.ReadOnly = True
        Me.txtValorUnitarioPedido.Size = New System.Drawing.Size(87, 20)
        Me.txtValorUnitarioPedido.TabIndex = 1
        Me.txtValorUnitarioPedido.TabStop = False
        Me.txtValorUnitarioPedido.Text = "0,0000"
        Me.txtValorUnitarioPedido.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(782, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblAliquotaICMSUltimaNF
        '
        Me.lblAliquotaICMSUltimaNF.AutoSize = True
        Me.lblAliquotaICMSUltimaNF.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAliquotaICMSUltimaNF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaICMSUltimaNF.Location = New System.Drawing.Point(518, 20)
        Me.lblAliquotaICMSUltimaNF.Name = "lblAliquotaICMSUltimaNF"
        Me.lblAliquotaICMSUltimaNF.Size = New System.Drawing.Size(109, 13)
        Me.lblAliquotaICMSUltimaNF.TabIndex = 8
        Me.lblAliquotaICMSUltimaNF.Text = "% ICMS Última NF:"
        '
        'grdXML
        '
        Me.grdXML.AllowDrop = True
        Me.grdXML.AlternatingColors = True
        Me.grdXML.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdXML.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdXML_DesignTimeLayout.LayoutString = resources.GetString("grdXML_DesignTimeLayout.LayoutString")
        Me.grdXML.DesignTimeLayout = grdXML_DesignTimeLayout
        Me.grdXML.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdXML.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdXML.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdXML.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdXML.FrozenColumns = 1
        Me.grdXML.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdXML.GroupByBoxVisible = False
        Me.grdXML.Location = New System.Drawing.Point(8, 9)
        Me.grdXML.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdXML.Name = "grdXML"
        Me.grdXML.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdXML.RecordNavigator = True
        Me.grdXML.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.grdXML.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdXML.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdXML.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdXML.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdXML.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdXML.Size = New System.Drawing.Size(879, 131)
        Me.grdXML.TabIndex = 10
        Me.grdXML.TabStop = False
        Me.grdXML.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdXML.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdXML.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdXML.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdXML.VisualStyleManager = Me.vsmMain
        '
        'txtTeste
        '
        Me.txtTeste.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTeste.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTeste.Location = New System.Drawing.Point(710, 70)
        Me.txtTeste.MaxLength = 50
        Me.txtTeste.Name = "txtTeste"
        Me.txtTeste.Size = New System.Drawing.Size(105, 20)
        Me.txtTeste.TabIndex = 47
        Me.txtTeste.Visible = False
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnInserirProduto)
        Me.grpControl.Controls.Add(Me.btnExcluirProduto)
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnVoltar)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(8, 482)
        Me.grpControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 1
        Me.grpControl.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirProduto.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirProduto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirProduto.Location = New System.Drawing.Point(409, 17)
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirProduto.TabIndex = 0
        Me.btnInserirProduto.Text = "Inserir"
        Me.btnInserirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirProduto.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirProduto.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirProduto.Location = New System.Drawing.Point(506, 17)
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirProduto.TabIndex = 1
        Me.btnExcluirProduto.Text = "Excluir"
        Me.btnExcluirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 2
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 4
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFatEntradaNFXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrFatEntradaNFXML"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaEnviadoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDadosNF.ResumeLayout(False)
        CType(Me.grpDadosDACTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosDACTE.ResumeLayout(False)
        Me.grpDadosDACTE.PerformLayout()
        CType(Me.grpTipoNotaFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipoNotaFiscal.ResumeLayout(False)
        Me.grpTipoNotaFiscal.PerformLayout()
        CType(Me.grpDadosNFe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosNFe.ResumeLayout(False)
        Me.grpDadosNFe.PerformLayout()
        CType(Me.grpDadosNF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosNF.ResumeLayout(False)
        Me.grpDadosNF.PerformLayout()
        Me.pagEmitente.ResumeLayout(False)
        CType(Me.grpLocalRetiradaEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLocalRetiradaEntrega.ResumeLayout(False)
        CType(Me.grpEmitente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmitente.ResumeLayout(False)
        Me.grpEmitente.PerformLayout()
        CType(Me.grpEnderecoDestinatario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEnderecoDestinatario.ResumeLayout(False)
        Me.grpEnderecoDestinatario.PerformLayout()
        Me.pagProduto.ResumeLayout(False)
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagTransporte.ResumeLayout(False)
        CType(Me.tabTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransporte.ResumeLayout(False)
        Me.pagTransportador.ResumeLayout(False)
        CType(Me.grpTransportador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTransportador.ResumeLayout(False)
        Me.grpTransportador.PerformLayout()
        Me.pagRetencaoICMS.ResumeLayout(False)
        CType(Me.grpRetencaoICMSTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRetencaoICMSTransporte.ResumeLayout(False)
        Me.grpRetencaoICMSTransporte.PerformLayout()
        Me.pagVeiculo.ResumeLayout(False)
        CType(Me.grpReboque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReboque.ResumeLayout(False)
        Me.grpReboque.PerformLayout()
        CType(Me.grpVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVeiculo.ResumeLayout(False)
        Me.grpVeiculo.PerformLayout()
        CType(Me.grdReboque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpBalsaoVagao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBalsaoVagao.ResumeLayout(False)
        Me.grpBalsaoVagao.PerformLayout()
        CType(Me.grpTipoVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipoVeiculo.ResumeLayout(False)
        Me.grpTipoVeiculo.PerformLayout()
        Me.pagVolume.ResumeLayout(False)
        CType(Me.grdVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVolume.ResumeLayout(False)
        Me.grpVolume.PerformLayout()
        Me.pagTotais.ResumeLayout(False)
        CType(Me.grpICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMS.ResumeLayout(False)
        Me.grpICMS.PerformLayout()
        Me.pagCobranca.ResumeLayout(False)
        CType(Me.grpTituloPrevisto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTituloPrevisto.ResumeLayout(False)
        Me.grpTituloPrevisto.PerformLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDuplicata.ResumeLayout(False)
        Me.grpDuplicata.PerformLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFatura.ResumeLayout(False)
        Me.grpFatura.PerformLayout()
        Me.pagInformacoesAdicionais.ResumeLayout(False)
        CType(Me.grpInformacaoAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacaoAdicional.ResumeLayout(False)
        Me.grpInformacaoAdicional.PerformLayout()
        Me.pagExportacaoCompras.ResumeLayout(False)
        CType(Me.grpCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCompra.ResumeLayout(False)
        Me.grpCompra.PerformLayout()
        CType(Me.grpExportacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExportacao.ResumeLayout(False)
        Me.grpExportacao.PerformLayout()
        Me.pagArquivos.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagProdutoXML.ResumeLayout(False)
        Me.pagProdutoXML.PerformLayout()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntrega.ResumeLayout(False)
        Me.grpEntrega.PerformLayout()
        CType(Me.grdRecebimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleDados.ResumeLayout(False)
        Me.grpControleDados.PerformLayout()
        CType(Me.grdXML, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDadosNF As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagTransporte As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagTotais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagCobranca As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagInformacoesAdicionais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDuplicata As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtIntervaloEntreParcelas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloEntreParcelas As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroParcela As System.Windows.Forms.Label
    Friend WithEvents grdDuplicata As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFatura As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorLiquido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorLiquido As System.Windows.Forms.Label
    Friend WithEvents txtValorDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDesconto As System.Windows.Forms.Label
    Friend WithEvents txtValorOriginal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOriginal As System.Windows.Forms.Label
    Friend WithEvents txtFatura As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFatura As System.Windows.Forms.Label
    Friend WithEvents grpInformacaoAdicional As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDadosNFe As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtEmitenteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblEmitenteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents btnArquivoNFe As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtArquivoNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblArquivoNFe As System.Windows.Forms.Label
    Friend WithEvents txtNumeroNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroNFe As System.Windows.Forms.Label
    Friend WithEvents txtSerieNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieNFe As System.Windows.Forms.Label
    Friend WithEvents txtDataEmissaoNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissaoNFe As System.Windows.Forms.Label
    Friend WithEvents grpDadosNF As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroNF As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroNF As System.Windows.Forms.Label
    Friend WithEvents lblDataEntradaNFe As System.Windows.Forms.Label
    Friend WithEvents lblDataEntradaNF As System.Windows.Forms.Label
    Friend WithEvents lblDataEmissaoNF As System.Windows.Forms.Label
    Friend WithEvents txtSerieNF As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieNF As System.Windows.Forms.Label
    Friend WithEvents txtStatusNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblStatusNFe As System.Windows.Forms.Label
    Friend WithEvents txtNumeroProtocoloNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroProtocoloNFe As System.Windows.Forms.Label
    Friend WithEvents txtChaveAcessoNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblChaveAcessoNFe As System.Windows.Forms.Label
    Friend WithEvents grpTipoNotaFiscal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents cboTipoNotaFiscal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCalcularDuplicata As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtEspecie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEspecie As System.Windows.Forms.Label
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblDadosAdicionaisFISCO As System.Windows.Forms.Label
    Friend WithEvents txtInformacaoAdicionalFisco As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDadosAdicionaisContribuinte As System.Windows.Forms.Label
    Friend WithEvents txtInformacaoAdicionalContribuinte As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents pagEmitente As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpEmitente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblEmitente As System.Windows.Forms.Label
    Friend WithEvents cboEmitente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarEmitente As System.Windows.Forms.Button
    Friend WithEvents grpEnderecoDestinatario As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtEmailEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEmailEmitente As System.Windows.Forms.Label
    Friend WithEvents cboMunicipioEmitente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairroEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPaisEmitente As System.Windows.Forms.Label
    Friend WithEvents cboPaisEmitente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCEPEmitente As System.Windows.Forms.Label
    Friend WithEvents txtCEPEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplementoEmitente As System.Windows.Forms.Label
    Friend WithEvents lblUFEmitente As System.Windows.Forms.Label
    Friend WithEvents cboUFEmitente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipioEmitente As System.Windows.Forms.Label
    Friend WithEvents lblBairroEmitente As System.Windows.Forms.Label
    Friend WithEvents lblNumeroEmitente As System.Windows.Forms.Label
    Friend WithEvents lblLogradouroEmitente As System.Windows.Forms.Label
    Friend WithEvents txtLogradouroEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarCEPEmitente As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarPaisEmitente As System.Windows.Forms.Button
    Friend WithEvents grpLocalRetiradaEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnEnderecoLocalEntrega As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnderecoLocalRetirada As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkLocalEntrega As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkLocalRetirada As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtCNPJEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtInscricaoEstadualSubstitutoTributarioEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadualSubstitutoTributarioEmitente As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoEstadualEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadualEmitente As System.Windows.Forms.Label
    Friend WithEvents lblCNPJEmitente As System.Windows.Forms.Label
    Friend WithEvents btnProcurarEmitente As System.Windows.Forms.Button
    Friend WithEvents tabTransporte As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTransportador As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagRetencaoICMS As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagVolume As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpTransportador As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboMunicipioTransportadora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUFTransportadora As System.Windows.Forms.Label
    Friend WithEvents cboUFTransportadora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipioTransportadora As System.Windows.Forms.Label
    Friend WithEvents lblEnderecoTransportadora As System.Windows.Forms.Label
    Friend WithEvents txtEnderecoTransportadora As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarTransportadora As System.Windows.Forms.Button
    Friend WithEvents lblModalidadeFrete As System.Windows.Forms.Label
    Friend WithEvents cboModalidadeFrete As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCNPJTransportadora As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtInscricaoEstadualTransportadora As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadualTransportadora As System.Windows.Forms.Label
    Friend WithEvents lblCNPJTransportadora As System.Windows.Forms.Label
    Friend WithEvents lblTransportadora As System.Windows.Forms.Label
    Friend WithEvents cboTransportadora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarTransportadora As System.Windows.Forms.Button
    Friend WithEvents grpVolume As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtPesoLiquidoTransportadora As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtPesoBrutoTransportadora As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPesoLiquidoTransportadora As System.Windows.Forms.Label
    Friend WithEvents lblPesoBrutoTransportadora As System.Windows.Forms.Label
    Friend WithEvents txtNumeroTransportadora As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroTransportadora As System.Windows.Forms.Label
    Friend WithEvents txtMarcaTransportadora As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarcaTransportadora As System.Windows.Forms.Label
    Friend WithEvents txtEspecieTransportadora As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEspecieTransportadora As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEmbalagemTransportadora As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeEmbalagemTransportadora As System.Windows.Forms.Label
    Friend WithEvents grdVolume As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcluirVolume As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirVolume As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagVeiculo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpTipoVeiculo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoVeiculo As System.Windows.Forms.Label
    Friend WithEvents cboTipoVeiculo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdReboque As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpBalsaoVagao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblVagao As System.Windows.Forms.Label
    Friend WithEvents txtVagao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBalsa As System.Windows.Forms.Label
    Friend WithEvents txtBalsa As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpVeiculo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRNTCVeiculo As System.Windows.Forms.Label
    Friend WithEvents txtRNTCVeiculo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboUFVeiculo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUFVeiculo As System.Windows.Forms.Label
    Friend WithEvents txtPlacaVeiculo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlacaVeiculo As System.Windows.Forms.Label
    Friend WithEvents grpReboque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirReboque As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirReboque As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblRNTCReboque As System.Windows.Forms.Label
    Friend WithEvents txtRNTCReboque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboUFReboque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUFReboque As System.Windows.Forms.Label
    Friend WithEvents txtPlacaReboque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlacaReboque As System.Windows.Forms.Label
    Friend WithEvents grpRetencaoICMSTransporte As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtICMSRetidoTransporte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCFOPICMSTransporte As System.Windows.Forms.Label
    Friend WithEvents cboCFOPICMSTransporte As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboMunicipioICMSTransporte As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUFICMSTransporte As System.Windows.Forms.Label
    Friend WithEvents cboUFICMSTransporte As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cb As System.Windows.Forms.Label
    Friend WithEvents txtValorServicoTransporte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorServicoTransporte As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaTransporte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaTransporte As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoTransporte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblICMSRetidoTransporte As System.Windows.Forms.Label
    Friend WithEvents lblBaseCalculoTransporte As System.Windows.Forms.Label
    Friend WithEvents lblRegimeTributarioEmitente As System.Windows.Forms.Label
    Friend WithEvents cboRegimeTributarioEmitente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtTelefoneEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefoneEmitente As System.Windows.Forms.Label
    Friend WithEvents pagExportacaoCompras As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpCompra As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNotaEmpenho As System.Windows.Forms.Label
    Friend WithEvents txtNotaEmpenho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpExportacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLocalEmbarque As System.Windows.Forms.Label
    Friend WithEvents txtLocalEmbarque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboUFEmbarque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUFEmbarque As System.Windows.Forms.Label
    Friend WithEvents lblInformacaoContrato As System.Windows.Forms.Label
    Friend WithEvents txtInformacaoContrato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInformacaoPedido As System.Windows.Forms.Label
    Friend WithEvents txtInformacaoPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCNAEEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNAEEmitente As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoMunicipalEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoMunicipalEmitente As System.Windows.Forms.Label
    Friend WithEvents grpICMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtTotalNotaFiscal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtOutrasDespesas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblOutrasDespesas As System.Windows.Forms.Label
    Friend WithEvents txtTotalCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtTotalPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalPIS As System.Windows.Forms.Label
    Friend WithEvents txtTotalIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalIPI As System.Windows.Forms.Label
    Friend WithEvents txtTotalII As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalII As System.Windows.Forms.Label
    Friend WithEvents txtTotalDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalDesconto As System.Windows.Forms.Label
    Friend WithEvents txtTotalSeguro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalSeguro As System.Windows.Forms.Label
    Friend WithEvents txtTotalFrete As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalFrete As System.Windows.Forms.Label
    Friend WithEvents txtTotalProdutoServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalProdutoServico As System.Windows.Forms.Label
    Friend WithEvents txtTotalICMSST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalICMSST As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoICMSST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMSST As System.Windows.Forms.Label
    Friend WithEvents txtTotalICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalICMS As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMS As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCFOPFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCFOPFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoNF As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntradaNF As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntradaNFe As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaAutozidadaParaUso As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelada As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAutozidadaParaUso As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents grpDadosDACTE As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtChaveAcessoDACTE As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblChaveAcessoDACTE As System.Windows.Forms.Label
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataEntradaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntradaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntradaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtLoteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLoteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblTipoOperacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorAcrescimo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorAcrescimo As System.Windows.Forms.Label
    Friend WithEvents txtValorPago As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorPago As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnEditarGridProduto As System.Windows.Forms.Button
    Friend WithEvents pagArquivos As Janus.Windows.UI.Tab.UITabPage
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
    Friend WithEvents btnInserirNFFatura As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnGerarXML As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpTituloPrevisto As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnVincular As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumDocumentoPrevisto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTituloPrevisto As System.Windows.Forms.Label
    Friend WithEvents txtValorPrevisto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboTituloPrevisto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTituloValor As System.Windows.Forms.Label
    Friend WithEvents lblTituloNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCentroCusto As System.Windows.Forms.Button
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents txtTituloDescritivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTituloDescritivo As System.Windows.Forms.Label
    Friend WithEvents txtTotalICMSDestino As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalICMSDestino As System.Windows.Forms.Label
    Friend WithEvents txtTotalICMSRemetente As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalICMSRemetente As System.Windows.Forms.Label
    Friend WithEvents txtTotalFCP As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalFCP As System.Windows.Forms.Label
    Friend WithEvents pagProdutoXML As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFindCFOPDestinacao As System.Windows.Forms.Button
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UiComboBox1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAtualizarPedidoCompra As System.Windows.Forms.Button
    Friend WithEvents lblQuantidadeDocumento As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeDocumento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDataFabricacao As System.Windows.Forms.Label
    Friend WithEvents dtpDataFabricacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents lblDataValidade As System.Windows.Forms.Label
    Friend WithEvents dtpDataValidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCFOP As System.Windows.Forms.Button
    Friend WithEvents lblCFOP As System.Windows.Forms.Label
    Friend WithEvents cboCFOP As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFatorConversao As System.Windows.Forms.Label
    Friend WithEvents txtFatorConversao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents btnExcluirXML As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarDeposito As System.Windows.Forms.Button
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cboNumeroDocumento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTipoOperacao As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdRecebimento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControleDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAliquotaICMSUltimaNF As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPISCOFINSPedido As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPISCOFINSPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIPIPedido As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIPIPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMSPedido As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMSPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitarioPedido As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValorUnitarioPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAliquotaICMSUltimaNF As System.Windows.Forms.Label
    Friend WithEvents grdXML As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblLegendaEmDigitacao As System.Windows.Forms.Label
    Friend WithEvents picLegendaEnviadoCliente As System.Windows.Forms.PictureBox
    Friend WithEvents txtTeste As Janus.Windows.GridEX.EditControls.MaskedEditBox

End Class
