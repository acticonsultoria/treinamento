<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinReceitaAdiantamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinReceitaAdiantamento))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column12.Image")
        Dim grdListagem_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column0.Image")
        Dim grdListagem_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column3.Image")
        Dim grdClassificacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdClassificacao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtivar = New Janus.Windows.EditControls.UIButton()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picAntecipado = New System.Windows.Forms.PictureBox()
        Me.lblAntecipado = New System.Windows.Forms.Label()
        Me.lblTituloAberto = New System.Windows.Forms.Label()
        Me.picTituloAberto = New System.Windows.Forms.PictureBox()
        Me.picTituloQuitado = New System.Windows.Forms.PictureBox()
        Me.lblTituloCancelado = New System.Windows.Forms.Label()
        Me.picTituloCancelado = New System.Windows.Forms.PictureBox()
        Me.lblTituloQuitado = New System.Windows.Forms.Label()
        Me.picTituloParcialmenteQuitado = New System.Windows.Forms.PictureBox()
        Me.lblTituloParcialmenteQuitado = New System.Windows.Forms.Label()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescritivoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescritivoFiltro = New System.Windows.Forms.Label()
        Me.lblContaBancariaFiltro = New System.Windows.Forms.Label()
        Me.cboContaBancariaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtValorFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarClienteFiltro = New System.Windows.Forms.Button()
        Me.dtpDataPagamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPagamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPagamentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataVencimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataVencimentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoTituloFinanceiroFiltro = New System.Windows.Forms.Label()
        Me.cboTipoTituloFinanceiroFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.pagReceita = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpPagamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarContaBancaria = New System.Windows.Forms.Button()
        Me.lblTipoDocumentoPagamento = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.grpChequeTerceiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoChequeTerceiro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorChequeTerceiro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtPreDatadoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPreDatadoChequeTerceiro = New System.Windows.Forms.Label()
        Me.cboNumeroDocumentoChequeTerceiro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroDocumentoChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtDataRecebimentoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataRecebimentoChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtContaChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblContaChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtAgenciaChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAgenciaChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtBancoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBancoChequeTerceiro = New System.Windows.Forms.Label()
        Me.lblDataPagamentoChequeTerceiro = New System.Windows.Forms.Label()
        Me.grpOutros = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoOutros = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorOutros = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOutros = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoOutros = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoOutros = New System.Windows.Forms.Label()
        Me.lblDataPagamentoOutros = New System.Windows.Forms.Label()
        Me.grpOutrosSimples = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoOutrosSimples = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorOutrosSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOutrosSimples = New System.Windows.Forms.Label()
        Me.lblDataPagamentoOutrosSimples = New System.Windows.Forms.Label()
        Me.grpDescontoDuplicata = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtJurosDescontoDuplicata = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblJurosDescontoDuplicata = New System.Windows.Forms.Label()
        Me.dtpDataPagamentoDescontoDuplicata = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorDescontoDuplicata = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDescontoDuplicata = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoDescontoDuplicata = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoDescontoDuplicata = New System.Windows.Forms.Label()
        Me.lblDataPagamentoDescontoDuplicata = New System.Windows.Forms.Label()
        Me.grpBoleto = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoBoleto = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorBoleto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBancoBoleto = New System.Windows.Forms.Label()
        Me.txtBancoBoleto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataPagamentoBoleto = New System.Windows.Forms.Label()
        Me.txtNumeroBoleto8 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto7 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto6 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto5 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto4 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto3 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoleto2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValorBoleto = New System.Windows.Forms.Label()
        Me.txtNumeroBoleto1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpCartaoCredito = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarMaquinaCartao = New System.Windows.Forms.Button()
        Me.cboMaquinaCartao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaquinaCartao = New System.Windows.Forms.Label()
        Me.btnCadastrarBandeiraCartaoCredito = New System.Windows.Forms.Button()
        Me.txtValorCartaoCredito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCartaoCredito = New System.Windows.Forms.Label()
        Me.lblNumeroParcelaCartaoCredito = New System.Windows.Forms.Label()
        Me.cboBandeiraCartaoCredito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblBandeiraCartaoCredito = New System.Windows.Forms.Label()
        Me.lblDataPagamentoCartaoCredito = New System.Windows.Forms.Label()
        Me.txtNumeroParcelaCartaoCredito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.dtpDataPagamentoCartaoCredito = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.grpSaldoCliente = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoSaldoCliente = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorSaldoCliente = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorSaldoCliente = New System.Windows.Forms.Label()
        Me.lblDataPagamentoSaldoCliente = New System.Windows.Forms.Label()
        Me.grpCheque = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataCompensacaoCheque = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPagamentoCheque = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCompensacaoCheque = New System.Windows.Forms.Label()
        Me.txtValorCheque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCheque = New System.Windows.Forms.Label()
        Me.lblDataPagamentoCheque = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoCheque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoCheque = New System.Windows.Forms.Label()
        Me.lblPreDatadoCheque = New System.Windows.Forms.Label()
        Me.cboPreDatadoCheque = New Janus.Windows.EditControls.UIComboBox()
        Me.txtFavorecidoCheque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFavorecidoCheque = New System.Windows.Forms.Label()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescritivo = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescritivo = New System.Windows.Forms.Label()
        Me.pagClassificacao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpClassificao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorClassificacao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorClassificacao = New System.Windows.Forms.Label()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcluirClassificacao = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirClassificao = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.grdClassificacao = New Janus.Windows.GridEX.GridEX()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.dtpDataVencimento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataVencimento = New System.Windows.Forms.Label()
        Me.dtpDataEmissao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.btnCadastrarCliente = New System.Windows.Forms.Button()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.lblPedidoVenda = New System.Windows.Forms.Label()
        Me.cboPedidoVenda = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picAntecipado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloAberto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloParcialmenteQuitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagReceita.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPagamento.SuspendLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChequeTerceiro.SuspendLayout()
        CType(Me.grpOutros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutros.SuspendLayout()
        CType(Me.grpOutrosSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutrosSimples.SuspendLayout()
        CType(Me.grpDescontoDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDescontoDuplicata.SuspendLayout()
        CType(Me.grpBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoleto.SuspendLayout()
        CType(Me.grpCartaoCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCartaoCredito.SuspendLayout()
        CType(Me.grpSaldoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSaldoCliente.SuspendLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCheque.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        Me.pagClassificacao.SuspendLayout()
        CType(Me.grpClassificao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClassificao.SuspendLayout()
        CType(Me.grdClassificacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagReceita})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Lista de Receita"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 462)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 26
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
        Me.btnAgruparGrid.TabIndex = 12
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
        Me.btnConfigurarGrid.TabIndex = 9
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
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_4.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_5.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_6.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_7.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3, grdListagem_DesignTimeLayout_Reference_4, grdListagem_DesignTimeLayout_Reference_5, grdListagem_DesignTimeLayout_Reference_6, grdListagem_DesignTimeLayout_Reference_7})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 5
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 155)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 324)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
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
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnAtivar)
        Me.grpControle.Controls.Add(Me.btnCancelar)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Controls.Add(Me.btnNovo)
        Me.grpControle.Location = New System.Drawing.Point(299, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(606, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnAtivar
        '
        Me.btnAtivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtivar.Image = Global.INTERACTI.My.Resources.Resources.undo
        Me.btnAtivar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtivar.Location = New System.Drawing.Point(215, 17)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtivar.Size = New System.Drawing.Size(91, 23)
        Me.btnAtivar.TabIndex = 2
        Me.btnAtivar.Text = "Ativar"
        Me.btnAtivar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(118, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(409, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 4
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(506, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(312, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 3
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picAntecipado)
        Me.grpLegenda.Controls.Add(Me.lblAntecipado)
        Me.grpLegenda.Controls.Add(Me.lblTituloAberto)
        Me.grpLegenda.Controls.Add(Me.picTituloAberto)
        Me.grpLegenda.Controls.Add(Me.picTituloQuitado)
        Me.grpLegenda.Controls.Add(Me.lblTituloCancelado)
        Me.grpLegenda.Controls.Add(Me.picTituloCancelado)
        Me.grpLegenda.Controls.Add(Me.lblTituloQuitado)
        Me.grpLegenda.Controls.Add(Me.picTituloParcialmenteQuitado)
        Me.grpLegenda.Controls.Add(Me.lblTituloParcialmenteQuitado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(282, 51)
        Me.grpLegenda.TabIndex = 2
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picAntecipado
        '
        Me.picAntecipado.BackColor = System.Drawing.Color.Peru
        Me.picAntecipado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAntecipado.Location = New System.Drawing.Point(189, 13)
        Me.picAntecipado.Name = "picAntecipado"
        Me.picAntecipado.Size = New System.Drawing.Size(13, 14)
        Me.picAntecipado.TabIndex = 18
        Me.picAntecipado.TabStop = False
        '
        'lblAntecipado
        '
        Me.lblAntecipado.AutoSize = True
        Me.lblAntecipado.Location = New System.Drawing.Point(208, 13)
        Me.lblAntecipado.Name = "lblAntecipado"
        Me.lblAntecipado.Size = New System.Drawing.Size(70, 14)
        Me.lblAntecipado.TabIndex = 17
        Me.lblAntecipado.Text = "Duplic. Desc."
        '
        'lblTituloAberto
        '
        Me.lblTituloAberto.AutoSize = True
        Me.lblTituloAberto.Location = New System.Drawing.Point(28, 13)
        Me.lblTituloAberto.Name = "lblTituloAberto"
        Me.lblTituloAberto.Size = New System.Drawing.Size(40, 14)
        Me.lblTituloAberto.TabIndex = 0
        Me.lblTituloAberto.Text = "Aberto"
        '
        'picTituloAberto
        '
        Me.picTituloAberto.BackColor = System.Drawing.Color.DimGray
        Me.picTituloAberto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloAberto.Location = New System.Drawing.Point(9, 13)
        Me.picTituloAberto.Name = "picTituloAberto"
        Me.picTituloAberto.Size = New System.Drawing.Size(13, 14)
        Me.picTituloAberto.TabIndex = 14
        Me.picTituloAberto.TabStop = False
        '
        'picTituloQuitado
        '
        Me.picTituloQuitado.BackColor = System.Drawing.Color.ForestGreen
        Me.picTituloQuitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloQuitado.Location = New System.Drawing.Point(106, 13)
        Me.picTituloQuitado.Name = "picTituloQuitado"
        Me.picTituloQuitado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloQuitado.TabIndex = 12
        Me.picTituloQuitado.TabStop = False
        '
        'lblTituloCancelado
        '
        Me.lblTituloCancelado.AutoSize = True
        Me.lblTituloCancelado.Location = New System.Drawing.Point(125, 31)
        Me.lblTituloCancelado.Name = "lblTituloCancelado"
        Me.lblTituloCancelado.Size = New System.Drawing.Size(58, 14)
        Me.lblTituloCancelado.TabIndex = 3
        Me.lblTituloCancelado.Text = "Cancelado"
        '
        'picTituloCancelado
        '
        Me.picTituloCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picTituloCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloCancelado.Location = New System.Drawing.Point(106, 31)
        Me.picTituloCancelado.Name = "picTituloCancelado"
        Me.picTituloCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloCancelado.TabIndex = 8
        Me.picTituloCancelado.TabStop = False
        '
        'lblTituloQuitado
        '
        Me.lblTituloQuitado.AutoSize = True
        Me.lblTituloQuitado.Location = New System.Drawing.Point(125, 13)
        Me.lblTituloQuitado.Name = "lblTituloQuitado"
        Me.lblTituloQuitado.Size = New System.Drawing.Size(44, 14)
        Me.lblTituloQuitado.TabIndex = 2
        Me.lblTituloQuitado.Text = "Quitado"
        '
        'picTituloParcialmenteQuitado
        '
        Me.picTituloParcialmenteQuitado.BackColor = System.Drawing.Color.SteelBlue
        Me.picTituloParcialmenteQuitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloParcialmenteQuitado.Location = New System.Drawing.Point(9, 31)
        Me.picTituloParcialmenteQuitado.Name = "picTituloParcialmenteQuitado"
        Me.picTituloParcialmenteQuitado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloParcialmenteQuitado.TabIndex = 16
        Me.picTituloParcialmenteQuitado.TabStop = False
        '
        'lblTituloParcialmenteQuitado
        '
        Me.lblTituloParcialmenteQuitado.AutoSize = True
        Me.lblTituloParcialmenteQuitado.Location = New System.Drawing.Point(28, 31)
        Me.lblTituloParcialmenteQuitado.Name = "lblTituloParcialmenteQuitado"
        Me.lblTituloParcialmenteQuitado.Size = New System.Drawing.Size(72, 14)
        Me.lblTituloParcialmenteQuitado.TabIndex = 1
        Me.lblTituloParcialmenteQuitado.Text = "Parc. Quitado"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtDescritivoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescritivoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblContaBancariaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboContaBancariaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblValorFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPagamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoTituloFinanceiroFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoTituloFinanceiroFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtDescritivoFiltro
        '
        Me.txtDescritivoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivoFiltro.Location = New System.Drawing.Point(370, 114)
        Me.txtDescritivoFiltro.MaxLength = 60
        Me.txtDescritivoFiltro.Name = "txtDescritivoFiltro"
        Me.txtDescritivoFiltro.Size = New System.Drawing.Size(414, 20)
        Me.txtDescritivoFiltro.TabIndex = 27
        '
        'lblDescritivoFiltro
        '
        Me.lblDescritivoFiltro.AutoSize = True
        Me.lblDescritivoFiltro.Location = New System.Drawing.Point(367, 97)
        Me.lblDescritivoFiltro.Name = "lblDescritivoFiltro"
        Me.lblDescritivoFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivoFiltro.TabIndex = 26
        Me.lblDescritivoFiltro.Text = "Descritivo:"
        '
        'lblContaBancariaFiltro
        '
        Me.lblContaBancariaFiltro.AutoSize = True
        Me.lblContaBancariaFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblContaBancariaFiltro.Name = "lblContaBancariaFiltro"
        Me.lblContaBancariaFiltro.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancariaFiltro.TabIndex = 24
        Me.lblContaBancariaFiltro.Text = "Conta Bancária:"
        '
        'cboContaBancariaFiltro
        '
        Me.cboContaBancariaFiltro.AutoSize = False
        Me.cboContaBancariaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancariaFiltro.Location = New System.Drawing.Point(9, 114)
        Me.cboContaBancariaFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboContaBancariaFiltro.Name = "cboContaBancariaFiltro"
        Me.cboContaBancariaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancariaFiltro.Size = New System.Drawing.Size(355, 20)
        Me.cboContaBancariaFiltro.TabIndex = 25
        '
        'txtValorFiltro
        '
        Me.txtValorFiltro.DecimalDigits = 2
        Me.txtValorFiltro.Location = New System.Drawing.Point(685, 34)
        Me.txtValorFiltro.MaxLength = 0
        Me.txtValorFiltro.Name = "txtValorFiltro"
        Me.txtValorFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtValorFiltro.TabIndex = 9
        Me.txtValorFiltro.Text = "0,00"
        Me.txtValorFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFiltro
        '
        Me.lblValorFiltro.AutoSize = True
        Me.lblValorFiltro.Location = New System.Drawing.Point(682, 17)
        Me.lblValorFiltro.Name = "lblValorFiltro"
        Me.lblValorFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblValorFiltro.TabIndex = 8
        Me.lblValorFiltro.Text = "Valor:"
        '
        'btnProcurarClienteFiltro
        '
        Me.btnProcurarClienteFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarClienteFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarClienteFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarClienteFiltro.Location = New System.Drawing.Point(557, 16)
        Me.btnProcurarClienteFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarClienteFiltro.Name = "btnProcurarClienteFiltro"
        Me.btnProcurarClienteFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarClienteFiltro.TabIndex = 21
        Me.btnProcurarClienteFiltro.TabStop = False
        Me.btnProcurarClienteFiltro.UseVisualStyleBackColor = True
        '
        'dtpDataPagamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoTerminoFiltro.Location = New System.Drawing.Point(685, 74)
        Me.dtpDataPagamentoTerminoFiltro.Name = "dtpDataPagamentoTerminoFiltro"
        Me.dtpDataPagamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataPagamentoTerminoFiltro.TabIndex = 20
        Me.dtpDataPagamentoTerminoFiltro.Value = New Date(2017, 8, 10, 0, 0, 0, 0)
        '
        'dtpDataPagamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoInicioFiltro.Location = New System.Drawing.Point(580, 74)
        Me.dtpDataPagamentoInicioFiltro.Name = "dtpDataPagamentoInicioFiltro"
        Me.dtpDataPagamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataPagamentoInicioFiltro.TabIndex = 19
        Me.dtpDataPagamentoInicioFiltro.Value = New Date(2017, 8, 10, 0, 0, 0, 0)
        '
        'lblDataPagamentoFiltro
        '
        Me.lblDataPagamentoFiltro.AutoSize = True
        Me.lblDataPagamentoFiltro.Location = New System.Drawing.Point(577, 57)
        Me.lblDataPagamentoFiltro.Name = "lblDataPagamentoFiltro"
        Me.lblDataPagamentoFiltro.Size = New System.Drawing.Size(88, 14)
        Me.lblDataPagamentoFiltro.TabIndex = 18
        Me.lblDataPagamentoFiltro.Text = "Data Pagamento:"
        '
        'dtpDataVencimentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoFiltro.Location = New System.Drawing.Point(475, 74)
        Me.dtpDataVencimentoTerminoFiltro.Name = "dtpDataVencimentoTerminoFiltro"
        Me.dtpDataVencimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoTerminoFiltro.TabIndex = 17
        Me.dtpDataVencimentoTerminoFiltro.Value = New Date(2017, 8, 10, 0, 0, 0, 0)
        '
        'dtpDataVencimentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioFiltro.Location = New System.Drawing.Point(370, 74)
        Me.dtpDataVencimentoInicioFiltro.Name = "dtpDataVencimentoInicioFiltro"
        Me.dtpDataVencimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoInicioFiltro.TabIndex = 16
        Me.dtpDataVencimentoInicioFiltro.Value = New Date(2017, 8, 10, 0, 0, 0, 0)
        '
        'lblDataVencimentoFiltro
        '
        Me.lblDataVencimentoFiltro.AutoSize = True
        Me.lblDataVencimentoFiltro.Location = New System.Drawing.Point(367, 57)
        Me.lblDataVencimentoFiltro.Name = "lblDataVencimentoFiltro"
        Me.lblDataVencimentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltro.TabIndex = 15
        Me.lblDataVencimentoFiltro.Text = "Data Vencimento:"
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(265, 74)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 14
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2017, 8, 10, 0, 0, 0, 0)
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(160, 74)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 13
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2017, 8, 10, 0, 0, 0, 0)
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteFiltro.Location = New System.Drawing.Point(160, 34)
        Me.txtClienteFiltro.MaxLength = 60
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.Size = New System.Drawing.Size(414, 20)
        Me.txtClienteFiltro.TabIndex = 5
        '
        'lblTipoTituloFinanceiroFiltro
        '
        Me.lblTipoTituloFinanceiroFiltro.AutoSize = True
        Me.lblTipoTituloFinanceiroFiltro.Location = New System.Drawing.Point(577, 17)
        Me.lblTipoTituloFinanceiroFiltro.Name = "lblTipoTituloFinanceiroFiltro"
        Me.lblTipoTituloFinanceiroFiltro.Size = New System.Drawing.Size(73, 14)
        Me.lblTipoTituloFinanceiroFiltro.TabIndex = 6
        Me.lblTipoTituloFinanceiroFiltro.Text = "Tipo do Título:"
        '
        'cboTipoTituloFinanceiroFiltro
        '
        Me.cboTipoTituloFinanceiroFiltro.AutoSize = False
        Me.cboTipoTituloFinanceiroFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoTituloFinanceiroFiltro.Location = New System.Drawing.Point(580, 34)
        Me.cboTipoTituloFinanceiroFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoTituloFinanceiroFiltro.Name = "cboTipoTituloFinanceiroFiltro"
        Me.cboTipoTituloFinanceiroFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoTituloFinanceiroFiltro.Size = New System.Drawing.Size(99, 20)
        Me.cboTipoTituloFinanceiroFiltro.TabIndex = 7
        '
        'txtSerieFiltro
        '
        Me.txtSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieFiltro.Location = New System.Drawing.Point(114, 34)
        Me.txtSerieFiltro.MaxLength = 3
        Me.txtSerieFiltro.Name = "txtSerieFiltro"
        Me.txtSerieFiltro.Size = New System.Drawing.Size(40, 20)
        Me.txtSerieFiltro.TabIndex = 3
        '
        'lblSerieFiltro
        '
        Me.lblSerieFiltro.AutoSize = True
        Me.lblSerieFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblSerieFiltro.Name = "lblSerieFiltro"
        Me.lblSerieFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieFiltro.TabIndex = 2
        Me.lblSerieFiltro.Text = "Série:"
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(95, 14)
        Me.lblStatusFiltro.TabIndex = 10
        Me.lblStatusFiltro.Text = "Status da Receita:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AutoSize = False
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboStatusFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusFiltro.Size = New System.Drawing.Size(145, 20)
        Me.cboStatusFiltro.TabIndex = 11
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroDocumentoFiltro.TabIndex = 1
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoFiltro.TabIndex = 0
        Me.lblNumeroDocumentoFiltro.Text = "Nº Documento:"
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(157, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 4
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 28
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(157, 57)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 12
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'pagReceita
        '
        Me.pagReceita.Controls.Add(Me.grdControlesEdicao)
        Me.pagReceita.Controls.Add(Me.tabDados)
        Me.pagReceita.Controls.Add(Me.grpInformacoes)
        Me.pagReceita.Key = "pagReceita"
        Me.pagReceita.Location = New System.Drawing.Point(1, 22)
        Me.pagReceita.Name = "pagReceita"
        Me.pagReceita.Size = New System.Drawing.Size(913, 543)
        Me.pagReceita.TabStop = True
        Me.pagReceita.Text = "Dados da Receita"
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnNovo1)
        Me.grdControlesEdicao.Controls.Add(Me.btnVoltar)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(8, 483)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(897, 51)
        Me.grdControlesEdicao.TabIndex = 2
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 0
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
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
        Me.tabDados.Size = New System.Drawing.Size(897, 407)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados, Me.pagClassificacao})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpPagamento)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(895, 384)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados Gerais"
        '
        'grpPagamento
        '
        Me.grpPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPagamento.BackColor = System.Drawing.Color.Transparent
        Me.grpPagamento.Controls.Add(Me.btnCadastrarContaBancaria)
        Me.grpPagamento.Controls.Add(Me.lblTipoDocumentoPagamento)
        Me.grpPagamento.Controls.Add(Me.cboTipoDocumentoPagamento)
        Me.grpPagamento.Controls.Add(Me.lblContaBancaria)
        Me.grpPagamento.Controls.Add(Me.cboContaBancaria)
        Me.grpPagamento.Controls.Add(Me.grpChequeTerceiro)
        Me.grpPagamento.Controls.Add(Me.grpOutros)
        Me.grpPagamento.Controls.Add(Me.grpOutrosSimples)
        Me.grpPagamento.Controls.Add(Me.grpDescontoDuplicata)
        Me.grpPagamento.Controls.Add(Me.grpBoleto)
        Me.grpPagamento.Controls.Add(Me.grpCartaoCredito)
        Me.grpPagamento.Controls.Add(Me.grpSaldoCliente)
        Me.grpPagamento.Controls.Add(Me.grpCheque)
        Me.grpPagamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPagamento.Location = New System.Drawing.Point(8, 270)
        Me.grpPagamento.Name = "grpPagamento"
        Me.grpPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPagamento.Size = New System.Drawing.Size(879, 104)
        Me.grpPagamento.TabIndex = 1
        Me.grpPagamento.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarContaBancaria
        '
        Me.btnCadastrarContaBancaria.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaBancaria.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaBancaria.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarContaBancaria.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaBancaria.Name = "btnCadastrarContaBancaria"
        Me.btnCadastrarContaBancaria.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaBancaria.TabIndex = 0
        Me.btnCadastrarContaBancaria.TabStop = False
        Me.btnCadastrarContaBancaria.UseVisualStyleBackColor = True
        '
        'lblTipoDocumentoPagamento
        '
        Me.lblTipoDocumentoPagamento.AutoSize = True
        Me.lblTipoDocumentoPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoDocumentoPagamento.Location = New System.Drawing.Point(6, 57)
        Me.lblTipoDocumentoPagamento.Name = "lblTipoDocumentoPagamento"
        Me.lblTipoDocumentoPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblTipoDocumentoPagamento.TabIndex = 3
        Me.lblTipoDocumentoPagamento.Text = "Forma de Pagamento:"
        '
        'cboTipoDocumentoPagamento
        '
        Me.cboTipoDocumentoPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoDocumentoPagamento.AutoSize = False
        Me.cboTipoDocumentoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumentoPagamento.Location = New System.Drawing.Point(9, 74)
        Me.cboTipoDocumentoPagamento.Name = "cboTipoDocumentoPagamento"
        Me.cboTipoDocumentoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumentoPagamento.Size = New System.Drawing.Size(166, 20)
        Me.cboTipoDocumentoPagamento.TabIndex = 1
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaBancaria.Location = New System.Drawing.Point(25, 17)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 1
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContaBancaria.AutoSize = False
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancaria.Location = New System.Drawing.Point(9, 34)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancaria.Size = New System.Drawing.Size(166, 20)
        Me.cboContaBancaria.TabIndex = 0
        '
        'grpChequeTerceiro
        '
        Me.grpChequeTerceiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpChequeTerceiro.BackColor = System.Drawing.Color.Transparent
        Me.grpChequeTerceiro.BorderColor = System.Drawing.Color.Transparent
        Me.grpChequeTerceiro.Controls.Add(Me.dtpDataPagamentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtValorChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblValorChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtPreDatadoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblPreDatadoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.cboNumeroDocumentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblNumeroDocumentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtDataRecebimentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblDataRecebimentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtContaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblContaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtAgenciaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblAgenciaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtBancoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblBancoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblDataPagamentoChequeTerceiro)
        Me.grpChequeTerceiro.Location = New System.Drawing.Point(181, 0)
        Me.grpChequeTerceiro.Name = "grpChequeTerceiro"
        Me.grpChequeTerceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpChequeTerceiro.Size = New System.Drawing.Size(505, 104)
        Me.grpChequeTerceiro.TabIndex = 1
        Me.grpChequeTerceiro.Visible = False
        Me.grpChequeTerceiro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoChequeTerceiro
        '
        '
        '
        '
        Me.dtpDataPagamentoChequeTerceiro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoChequeTerceiro.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoChequeTerceiro.Name = "dtpDataPagamentoChequeTerceiro"
        Me.dtpDataPagamentoChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoChequeTerceiro.TabIndex = 2
        Me.dtpDataPagamentoChequeTerceiro.Value = New Date(2016, 7, 26, 0, 0, 0, 0)
        '
        'txtValorChequeTerceiro
        '
        Me.txtValorChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorChequeTerceiro.Location = New System.Drawing.Point(310, 74)
        Me.txtValorChequeTerceiro.Name = "txtValorChequeTerceiro"
        Me.txtValorChequeTerceiro.ReadOnly = True
        Me.txtValorChequeTerceiro.Size = New System.Drawing.Size(98, 20)
        Me.txtValorChequeTerceiro.TabIndex = 9
        Me.txtValorChequeTerceiro.TabStop = False
        Me.txtValorChequeTerceiro.Text = "0,00"
        Me.txtValorChequeTerceiro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorChequeTerceiro
        '
        Me.lblValorChequeTerceiro.AutoSize = True
        Me.lblValorChequeTerceiro.Location = New System.Drawing.Point(307, 57)
        Me.lblValorChequeTerceiro.Name = "lblValorChequeTerceiro"
        Me.lblValorChequeTerceiro.Size = New System.Drawing.Size(75, 14)
        Me.lblValorChequeTerceiro.TabIndex = 12
        Me.lblValorChequeTerceiro.Text = "Valor Cheque:"
        '
        'txtPreDatadoChequeTerceiro
        '
        Me.txtPreDatadoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPreDatadoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreDatadoChequeTerceiro.Location = New System.Drawing.Point(216, 74)
        Me.txtPreDatadoChequeTerceiro.MaxLength = 20
        Me.txtPreDatadoChequeTerceiro.Name = "txtPreDatadoChequeTerceiro"
        Me.txtPreDatadoChequeTerceiro.ReadOnly = True
        Me.txtPreDatadoChequeTerceiro.Size = New System.Drawing.Size(88, 20)
        Me.txtPreDatadoChequeTerceiro.TabIndex = 8
        Me.txtPreDatadoChequeTerceiro.TabStop = False
        '
        'lblPreDatadoChequeTerceiro
        '
        Me.lblPreDatadoChequeTerceiro.AutoSize = True
        Me.lblPreDatadoChequeTerceiro.Location = New System.Drawing.Point(213, 57)
        Me.lblPreDatadoChequeTerceiro.Name = "lblPreDatadoChequeTerceiro"
        Me.lblPreDatadoChequeTerceiro.Size = New System.Drawing.Size(88, 14)
        Me.lblPreDatadoChequeTerceiro.TabIndex = 10
        Me.lblPreDatadoChequeTerceiro.Text = "Pré-datado para:"
        '
        'cboNumeroDocumentoChequeTerceiro
        '
        Me.cboNumeroDocumentoChequeTerceiro.AutoSize = False
        Me.cboNumeroDocumentoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroDocumentoChequeTerceiro.Location = New System.Drawing.Point(9, 34)
        Me.cboNumeroDocumentoChequeTerceiro.Name = "cboNumeroDocumentoChequeTerceiro"
        Me.cboNumeroDocumentoChequeTerceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroDocumentoChequeTerceiro.Size = New System.Drawing.Size(104, 20)
        Me.cboNumeroDocumentoChequeTerceiro.TabIndex = 1
        '
        'lblNumeroDocumentoChequeTerceiro
        '
        Me.lblNumeroDocumentoChequeTerceiro.AutoSize = True
        Me.lblNumeroDocumentoChequeTerceiro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoChequeTerceiro.Name = "lblNumeroDocumentoChequeTerceiro"
        Me.lblNumeroDocumentoChequeTerceiro.Size = New System.Drawing.Size(62, 14)
        Me.lblNumeroDocumentoChequeTerceiro.TabIndex = 0
        Me.lblNumeroDocumentoChequeTerceiro.Text = "Nº Cheque:"
        '
        'txtDataRecebimentoChequeTerceiro
        '
        Me.txtDataRecebimentoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataRecebimentoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataRecebimentoChequeTerceiro.Location = New System.Drawing.Point(119, 74)
        Me.txtDataRecebimentoChequeTerceiro.MaxLength = 20
        Me.txtDataRecebimentoChequeTerceiro.Name = "txtDataRecebimentoChequeTerceiro"
        Me.txtDataRecebimentoChequeTerceiro.ReadOnly = True
        Me.txtDataRecebimentoChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.txtDataRecebimentoChequeTerceiro.TabIndex = 7
        Me.txtDataRecebimentoChequeTerceiro.TabStop = False
        '
        'lblDataRecebimentoChequeTerceiro
        '
        Me.lblDataRecebimentoChequeTerceiro.AutoSize = True
        Me.lblDataRecebimentoChequeTerceiro.Location = New System.Drawing.Point(116, 57)
        Me.lblDataRecebimentoChequeTerceiro.Name = "lblDataRecebimentoChequeTerceiro"
        Me.lblDataRecebimentoChequeTerceiro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataRecebimentoChequeTerceiro.TabIndex = 8
        Me.lblDataRecebimentoChequeTerceiro.Text = "Recebido em:"
        '
        'txtContaChequeTerceiro
        '
        Me.txtContaChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContaChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContaChequeTerceiro.Location = New System.Drawing.Point(9, 74)
        Me.txtContaChequeTerceiro.MaxLength = 20
        Me.txtContaChequeTerceiro.Name = "txtContaChequeTerceiro"
        Me.txtContaChequeTerceiro.ReadOnly = True
        Me.txtContaChequeTerceiro.Size = New System.Drawing.Size(104, 20)
        Me.txtContaChequeTerceiro.TabIndex = 4
        Me.txtContaChequeTerceiro.TabStop = False
        '
        'lblContaChequeTerceiro
        '
        Me.lblContaChequeTerceiro.AutoSize = True
        Me.lblContaChequeTerceiro.Location = New System.Drawing.Point(6, 57)
        Me.lblContaChequeTerceiro.Name = "lblContaChequeTerceiro"
        Me.lblContaChequeTerceiro.Size = New System.Drawing.Size(38, 14)
        Me.lblContaChequeTerceiro.TabIndex = 6
        Me.lblContaChequeTerceiro.Text = "Conta:"
        '
        'txtAgenciaChequeTerceiro
        '
        Me.txtAgenciaChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAgenciaChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAgenciaChequeTerceiro.Location = New System.Drawing.Point(414, 34)
        Me.txtAgenciaChequeTerceiro.MaxLength = 20
        Me.txtAgenciaChequeTerceiro.Name = "txtAgenciaChequeTerceiro"
        Me.txtAgenciaChequeTerceiro.ReadOnly = True
        Me.txtAgenciaChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.txtAgenciaChequeTerceiro.TabIndex = 6
        Me.txtAgenciaChequeTerceiro.TabStop = False
        '
        'lblAgenciaChequeTerceiro
        '
        Me.lblAgenciaChequeTerceiro.AutoSize = True
        Me.lblAgenciaChequeTerceiro.Location = New System.Drawing.Point(411, 17)
        Me.lblAgenciaChequeTerceiro.Name = "lblAgenciaChequeTerceiro"
        Me.lblAgenciaChequeTerceiro.Size = New System.Drawing.Size(50, 14)
        Me.lblAgenciaChequeTerceiro.TabIndex = 4
        Me.lblAgenciaChequeTerceiro.Text = "Agência:"
        '
        'txtBancoChequeTerceiro
        '
        Me.txtBancoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBancoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoChequeTerceiro.Location = New System.Drawing.Point(216, 34)
        Me.txtBancoChequeTerceiro.MaxLength = 20
        Me.txtBancoChequeTerceiro.Name = "txtBancoChequeTerceiro"
        Me.txtBancoChequeTerceiro.ReadOnly = True
        Me.txtBancoChequeTerceiro.Size = New System.Drawing.Size(192, 20)
        Me.txtBancoChequeTerceiro.TabIndex = 4
        Me.txtBancoChequeTerceiro.TabStop = False
        '
        'lblBancoChequeTerceiro
        '
        Me.lblBancoChequeTerceiro.AutoSize = True
        Me.lblBancoChequeTerceiro.Location = New System.Drawing.Point(213, 17)
        Me.lblBancoChequeTerceiro.Name = "lblBancoChequeTerceiro"
        Me.lblBancoChequeTerceiro.Size = New System.Drawing.Size(41, 14)
        Me.lblBancoChequeTerceiro.TabIndex = 2
        Me.lblBancoChequeTerceiro.Text = "Banco:"
        '
        'lblDataPagamentoChequeTerceiro
        '
        Me.lblDataPagamentoChequeTerceiro.AutoSize = True
        Me.lblDataPagamentoChequeTerceiro.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoChequeTerceiro.Name = "lblDataPagamentoChequeTerceiro"
        Me.lblDataPagamentoChequeTerceiro.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoChequeTerceiro.TabIndex = 14
        Me.lblDataPagamentoChequeTerceiro.Text = "Data Pgto.:"
        '
        'grpOutros
        '
        Me.grpOutros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOutros.BackColor = System.Drawing.Color.Transparent
        Me.grpOutros.BorderColor = System.Drawing.Color.Transparent
        Me.grpOutros.Controls.Add(Me.dtpDataPagamentoOutros)
        Me.grpOutros.Controls.Add(Me.txtValorOutros)
        Me.grpOutros.Controls.Add(Me.lblValorOutros)
        Me.grpOutros.Controls.Add(Me.txtNumeroDocumentoOutros)
        Me.grpOutros.Controls.Add(Me.lblNumeroDocumentoOutros)
        Me.grpOutros.Controls.Add(Me.lblDataPagamentoOutros)
        Me.grpOutros.Location = New System.Drawing.Point(181, 0)
        Me.grpOutros.Name = "grpOutros"
        Me.grpOutros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOutros.Size = New System.Drawing.Size(505, 64)
        Me.grpOutros.TabIndex = 4
        Me.grpOutros.Visible = False
        Me.grpOutros.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoOutros
        '
        '
        '
        '
        Me.dtpDataPagamentoOutros.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoOutros.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoOutros.Name = "dtpDataPagamentoOutros"
        Me.dtpDataPagamentoOutros.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoOutros.TabIndex = 3
        Me.dtpDataPagamentoOutros.Value = New Date(2016, 7, 26, 0, 0, 0, 0)
        '
        'txtValorOutros
        '
        Me.txtValorOutros.Location = New System.Drawing.Point(216, 34)
        Me.txtValorOutros.Name = "txtValorOutros"
        Me.txtValorOutros.Size = New System.Drawing.Size(98, 20)
        Me.txtValorOutros.TabIndex = 7
        Me.txtValorOutros.Text = "0,00"
        Me.txtValorOutros.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorOutros
        '
        Me.lblValorOutros.AutoSize = True
        Me.lblValorOutros.Location = New System.Drawing.Point(213, 17)
        Me.lblValorOutros.Name = "lblValorOutros"
        Me.lblValorOutros.Size = New System.Drawing.Size(35, 14)
        Me.lblValorOutros.TabIndex = 6
        Me.lblValorOutros.Text = "Valor:"
        '
        'txtNumeroDocumentoOutros
        '
        Me.txtNumeroDocumentoOutros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoOutros.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoOutros.MaxLength = 20
        Me.txtNumeroDocumentoOutros.Name = "txtNumeroDocumentoOutros"
        Me.txtNumeroDocumentoOutros.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroDocumentoOutros.TabIndex = 1
        '
        'lblNumeroDocumentoOutros
        '
        Me.lblNumeroDocumentoOutros.AutoSize = True
        Me.lblNumeroDocumentoOutros.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoOutros.Name = "lblNumeroDocumentoOutros"
        Me.lblNumeroDocumentoOutros.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoOutros.TabIndex = 0
        Me.lblNumeroDocumentoOutros.Text = "Nº Documento:"
        '
        'lblDataPagamentoOutros
        '
        Me.lblDataPagamentoOutros.AutoSize = True
        Me.lblDataPagamentoOutros.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoOutros.Name = "lblDataPagamentoOutros"
        Me.lblDataPagamentoOutros.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoOutros.TabIndex = 2
        Me.lblDataPagamentoOutros.Text = "Data Pgto.:"
        '
        'grpOutrosSimples
        '
        Me.grpOutrosSimples.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOutrosSimples.BackColor = System.Drawing.Color.Transparent
        Me.grpOutrosSimples.BorderColor = System.Drawing.Color.Transparent
        Me.grpOutrosSimples.Controls.Add(Me.dtpDataPagamentoOutrosSimples)
        Me.grpOutrosSimples.Controls.Add(Me.txtValorOutrosSimples)
        Me.grpOutrosSimples.Controls.Add(Me.lblValorOutrosSimples)
        Me.grpOutrosSimples.Controls.Add(Me.lblDataPagamentoOutrosSimples)
        Me.grpOutrosSimples.Location = New System.Drawing.Point(181, 0)
        Me.grpOutrosSimples.Name = "grpOutrosSimples"
        Me.grpOutrosSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOutrosSimples.Size = New System.Drawing.Size(505, 64)
        Me.grpOutrosSimples.TabIndex = 1
        Me.grpOutrosSimples.Visible = False
        Me.grpOutrosSimples.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoOutrosSimples
        '
        '
        '
        '
        Me.dtpDataPagamentoOutrosSimples.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoOutrosSimples.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataPagamentoOutrosSimples.Name = "dtpDataPagamentoOutrosSimples"
        Me.dtpDataPagamentoOutrosSimples.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoOutrosSimples.TabIndex = 1
        Me.dtpDataPagamentoOutrosSimples.Value = New Date(2016, 7, 26, 0, 0, 0, 0)
        '
        'txtValorOutrosSimples
        '
        Me.txtValorOutrosSimples.Location = New System.Drawing.Point(106, 34)
        Me.txtValorOutrosSimples.Name = "txtValorOutrosSimples"
        Me.txtValorOutrosSimples.Size = New System.Drawing.Size(98, 20)
        Me.txtValorOutrosSimples.TabIndex = 3
        Me.txtValorOutrosSimples.Text = "0,00"
        Me.txtValorOutrosSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorOutrosSimples
        '
        Me.lblValorOutrosSimples.AutoSize = True
        Me.lblValorOutrosSimples.Location = New System.Drawing.Point(103, 17)
        Me.lblValorOutrosSimples.Name = "lblValorOutrosSimples"
        Me.lblValorOutrosSimples.Size = New System.Drawing.Size(35, 14)
        Me.lblValorOutrosSimples.TabIndex = 4
        Me.lblValorOutrosSimples.Text = "Valor:"
        '
        'lblDataPagamentoOutrosSimples
        '
        Me.lblDataPagamentoOutrosSimples.AutoSize = True
        Me.lblDataPagamentoOutrosSimples.Location = New System.Drawing.Point(6, 17)
        Me.lblDataPagamentoOutrosSimples.Name = "lblDataPagamentoOutrosSimples"
        Me.lblDataPagamentoOutrosSimples.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoOutrosSimples.TabIndex = 0
        Me.lblDataPagamentoOutrosSimples.Text = "Data Pgto.:"
        '
        'grpDescontoDuplicata
        '
        Me.grpDescontoDuplicata.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDescontoDuplicata.BackColor = System.Drawing.Color.Transparent
        Me.grpDescontoDuplicata.BorderColor = System.Drawing.Color.Transparent
        Me.grpDescontoDuplicata.Controls.Add(Me.txtJurosDescontoDuplicata)
        Me.grpDescontoDuplicata.Controls.Add(Me.lblJurosDescontoDuplicata)
        Me.grpDescontoDuplicata.Controls.Add(Me.dtpDataPagamentoDescontoDuplicata)
        Me.grpDescontoDuplicata.Controls.Add(Me.txtValorDescontoDuplicata)
        Me.grpDescontoDuplicata.Controls.Add(Me.lblValorDescontoDuplicata)
        Me.grpDescontoDuplicata.Controls.Add(Me.txtNumeroDocumentoDescontoDuplicata)
        Me.grpDescontoDuplicata.Controls.Add(Me.lblNumeroDocumentoDescontoDuplicata)
        Me.grpDescontoDuplicata.Controls.Add(Me.lblDataPagamentoDescontoDuplicata)
        Me.grpDescontoDuplicata.Location = New System.Drawing.Point(181, 0)
        Me.grpDescontoDuplicata.Name = "grpDescontoDuplicata"
        Me.grpDescontoDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDescontoDuplicata.Size = New System.Drawing.Size(505, 64)
        Me.grpDescontoDuplicata.TabIndex = 10
        Me.grpDescontoDuplicata.Visible = False
        Me.grpDescontoDuplicata.VisualStyleManager = Me.vsmMain
        '
        'txtJurosDescontoDuplicata
        '
        Me.txtJurosDescontoDuplicata.Location = New System.Drawing.Point(310, 34)
        Me.txtJurosDescontoDuplicata.Name = "txtJurosDescontoDuplicata"
        Me.txtJurosDescontoDuplicata.Size = New System.Drawing.Size(98, 20)
        Me.txtJurosDescontoDuplicata.TabIndex = 7
        Me.txtJurosDescontoDuplicata.Text = "0,00"
        Me.txtJurosDescontoDuplicata.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblJurosDescontoDuplicata
        '
        Me.lblJurosDescontoDuplicata.AutoSize = True
        Me.lblJurosDescontoDuplicata.Location = New System.Drawing.Point(307, 17)
        Me.lblJurosDescontoDuplicata.Name = "lblJurosDescontoDuplicata"
        Me.lblJurosDescontoDuplicata.Size = New System.Drawing.Size(75, 14)
        Me.lblJurosDescontoDuplicata.TabIndex = 6
        Me.lblJurosDescontoDuplicata.Text = "Juros (% dia):"
        '
        'dtpDataPagamentoDescontoDuplicata
        '
        '
        '
        '
        Me.dtpDataPagamentoDescontoDuplicata.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoDescontoDuplicata.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoDescontoDuplicata.Name = "dtpDataPagamentoDescontoDuplicata"
        Me.dtpDataPagamentoDescontoDuplicata.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoDescontoDuplicata.TabIndex = 3
        Me.dtpDataPagamentoDescontoDuplicata.Value = New Date(2016, 7, 26, 0, 0, 0, 0)
        '
        'txtValorDescontoDuplicata
        '
        Me.txtValorDescontoDuplicata.Location = New System.Drawing.Point(216, 34)
        Me.txtValorDescontoDuplicata.Name = "txtValorDescontoDuplicata"
        Me.txtValorDescontoDuplicata.Size = New System.Drawing.Size(88, 20)
        Me.txtValorDescontoDuplicata.TabIndex = 5
        Me.txtValorDescontoDuplicata.Text = "0,00"
        Me.txtValorDescontoDuplicata.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDescontoDuplicata
        '
        Me.lblValorDescontoDuplicata.AutoSize = True
        Me.lblValorDescontoDuplicata.Location = New System.Drawing.Point(213, 17)
        Me.lblValorDescontoDuplicata.Name = "lblValorDescontoDuplicata"
        Me.lblValorDescontoDuplicata.Size = New System.Drawing.Size(35, 14)
        Me.lblValorDescontoDuplicata.TabIndex = 4
        Me.lblValorDescontoDuplicata.Text = "Valor:"
        '
        'txtNumeroDocumentoDescontoDuplicata
        '
        Me.txtNumeroDocumentoDescontoDuplicata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoDescontoDuplicata.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoDescontoDuplicata.MaxLength = 20
        Me.txtNumeroDocumentoDescontoDuplicata.Name = "txtNumeroDocumentoDescontoDuplicata"
        Me.txtNumeroDocumentoDescontoDuplicata.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroDocumentoDescontoDuplicata.TabIndex = 1
        '
        'lblNumeroDocumentoDescontoDuplicata
        '
        Me.lblNumeroDocumentoDescontoDuplicata.AutoSize = True
        Me.lblNumeroDocumentoDescontoDuplicata.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoDescontoDuplicata.Name = "lblNumeroDocumentoDescontoDuplicata"
        Me.lblNumeroDocumentoDescontoDuplicata.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoDescontoDuplicata.TabIndex = 0
        Me.lblNumeroDocumentoDescontoDuplicata.Text = "Nº Documento:"
        '
        'lblDataPagamentoDescontoDuplicata
        '
        Me.lblDataPagamentoDescontoDuplicata.AutoSize = True
        Me.lblDataPagamentoDescontoDuplicata.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoDescontoDuplicata.Name = "lblDataPagamentoDescontoDuplicata"
        Me.lblDataPagamentoDescontoDuplicata.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoDescontoDuplicata.TabIndex = 2
        Me.lblDataPagamentoDescontoDuplicata.Text = "Data Pgto.:"
        '
        'grpBoleto
        '
        Me.grpBoleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBoleto.BackColor = System.Drawing.Color.Transparent
        Me.grpBoleto.BorderColor = System.Drawing.Color.Transparent
        Me.grpBoleto.Controls.Add(Me.dtpDataPagamentoBoleto)
        Me.grpBoleto.Controls.Add(Me.txtValorBoleto)
        Me.grpBoleto.Controls.Add(Me.lblBancoBoleto)
        Me.grpBoleto.Controls.Add(Me.txtBancoBoleto)
        Me.grpBoleto.Controls.Add(Me.lblDataPagamentoBoleto)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto8)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto7)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto6)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto5)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto4)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto3)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto2)
        Me.grpBoleto.Controls.Add(Me.lblValorBoleto)
        Me.grpBoleto.Controls.Add(Me.txtNumeroBoleto1)
        Me.grpBoleto.Controls.Add(Me.Label4)
        Me.grpBoleto.Location = New System.Drawing.Point(181, 0)
        Me.grpBoleto.Name = "grpBoleto"
        Me.grpBoleto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBoleto.Size = New System.Drawing.Size(505, 104)
        Me.grpBoleto.TabIndex = 1
        Me.grpBoleto.Visible = False
        Me.grpBoleto.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoBoleto
        '
        '
        '
        '
        Me.dtpDataPagamentoBoleto.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoBoleto.Location = New System.Drawing.Point(320, 74)
        Me.dtpDataPagamentoBoleto.Name = "dtpDataPagamentoBoleto"
        Me.dtpDataPagamentoBoleto.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoBoleto.TabIndex = 14
        Me.dtpDataPagamentoBoleto.Value = New Date(2016, 7, 26, 0, 0, 0, 0)
        '
        'txtValorBoleto
        '
        Me.txtValorBoleto.Location = New System.Drawing.Point(416, 74)
        Me.txtValorBoleto.Name = "txtValorBoleto"
        Me.txtValorBoleto.Size = New System.Drawing.Size(89, 20)
        Me.txtValorBoleto.TabIndex = 10
        Me.txtValorBoleto.Text = "0,00"
        Me.txtValorBoleto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBancoBoleto
        '
        Me.lblBancoBoleto.AutoSize = True
        Me.lblBancoBoleto.Location = New System.Drawing.Point(6, 57)
        Me.lblBancoBoleto.Name = "lblBancoBoleto"
        Me.lblBancoBoleto.Size = New System.Drawing.Size(41, 14)
        Me.lblBancoBoleto.TabIndex = 9
        Me.lblBancoBoleto.Text = "Banco:"
        '
        'txtBancoBoleto
        '
        Me.txtBancoBoleto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBancoBoleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoBoleto.Location = New System.Drawing.Point(9, 74)
        Me.txtBancoBoleto.MaxLength = 5
        Me.txtBancoBoleto.Name = "txtBancoBoleto"
        Me.txtBancoBoleto.ReadOnly = True
        Me.txtBancoBoleto.Size = New System.Drawing.Size(304, 20)
        Me.txtBancoBoleto.TabIndex = 10
        Me.txtBancoBoleto.TabStop = False
        '
        'lblDataPagamentoBoleto
        '
        Me.lblDataPagamentoBoleto.AutoSize = True
        Me.lblDataPagamentoBoleto.Location = New System.Drawing.Point(316, 57)
        Me.lblDataPagamentoBoleto.Name = "lblDataPagamentoBoleto"
        Me.lblDataPagamentoBoleto.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoBoleto.TabIndex = 11
        Me.lblDataPagamentoBoleto.Text = "Data Pgto.:"
        '
        'txtNumeroBoleto8
        '
        Me.txtNumeroBoleto8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto8.Location = New System.Drawing.Point(416, 34)
        Me.txtNumeroBoleto8.MaxLength = 14
        Me.txtNumeroBoleto8.Name = "txtNumeroBoleto8"
        Me.txtNumeroBoleto8.Size = New System.Drawing.Size(89, 20)
        Me.txtNumeroBoleto8.TabIndex = 8
        '
        'txtNumeroBoleto7
        '
        Me.txtNumeroBoleto7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto7.Location = New System.Drawing.Point(389, 34)
        Me.txtNumeroBoleto7.MaxLength = 1
        Me.txtNumeroBoleto7.Name = "txtNumeroBoleto7"
        Me.txtNumeroBoleto7.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoleto7.TabIndex = 7
        '
        'txtNumeroBoleto6
        '
        Me.txtNumeroBoleto6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto6.Location = New System.Drawing.Point(319, 34)
        Me.txtNumeroBoleto6.MaxLength = 6
        Me.txtNumeroBoleto6.Name = "txtNumeroBoleto6"
        Me.txtNumeroBoleto6.Size = New System.Drawing.Size(64, 20)
        Me.txtNumeroBoleto6.TabIndex = 6
        '
        'txtNumeroBoleto5
        '
        Me.txtNumeroBoleto5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto5.Location = New System.Drawing.Point(259, 34)
        Me.txtNumeroBoleto5.MaxLength = 5
        Me.txtNumeroBoleto5.Name = "txtNumeroBoleto5"
        Me.txtNumeroBoleto5.Size = New System.Drawing.Size(54, 20)
        Me.txtNumeroBoleto5.TabIndex = 5
        '
        'txtNumeroBoleto4
        '
        Me.txtNumeroBoleto4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto4.Location = New System.Drawing.Point(189, 34)
        Me.txtNumeroBoleto4.MaxLength = 6
        Me.txtNumeroBoleto4.Name = "txtNumeroBoleto4"
        Me.txtNumeroBoleto4.Size = New System.Drawing.Size(64, 20)
        Me.txtNumeroBoleto4.TabIndex = 4
        '
        'txtNumeroBoleto3
        '
        Me.txtNumeroBoleto3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto3.Location = New System.Drawing.Point(129, 34)
        Me.txtNumeroBoleto3.MaxLength = 5
        Me.txtNumeroBoleto3.Name = "txtNumeroBoleto3"
        Me.txtNumeroBoleto3.Size = New System.Drawing.Size(54, 20)
        Me.txtNumeroBoleto3.TabIndex = 3
        '
        'txtNumeroBoleto2
        '
        Me.txtNumeroBoleto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto2.Location = New System.Drawing.Point(69, 34)
        Me.txtNumeroBoleto2.MaxLength = 5
        Me.txtNumeroBoleto2.Name = "txtNumeroBoleto2"
        Me.txtNumeroBoleto2.Size = New System.Drawing.Size(54, 20)
        Me.txtNumeroBoleto2.TabIndex = 2
        '
        'lblValorBoleto
        '
        Me.lblValorBoleto.AutoSize = True
        Me.lblValorBoleto.Location = New System.Drawing.Point(413, 57)
        Me.lblValorBoleto.Name = "lblValorBoleto"
        Me.lblValorBoleto.Size = New System.Drawing.Size(68, 14)
        Me.lblValorBoleto.TabIndex = 13
        Me.lblValorBoleto.Text = "Valor Boleto:"
        '
        'txtNumeroBoleto1
        '
        Me.txtNumeroBoleto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoleto1.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroBoleto1.MaxLength = 5
        Me.txtNumeroBoleto1.Name = "txtNumeroBoleto1"
        Me.txtNumeroBoleto1.Size = New System.Drawing.Size(54, 20)
        Me.txtNumeroBoleto1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nº Boleto:"
        '
        'grpCartaoCredito
        '
        Me.grpCartaoCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCartaoCredito.BackColor = System.Drawing.Color.Transparent
        Me.grpCartaoCredito.BorderColor = System.Drawing.Color.Transparent
        Me.grpCartaoCredito.Controls.Add(Me.btnCadastrarMaquinaCartao)
        Me.grpCartaoCredito.Controls.Add(Me.cboMaquinaCartao)
        Me.grpCartaoCredito.Controls.Add(Me.lblMaquinaCartao)
        Me.grpCartaoCredito.Controls.Add(Me.btnCadastrarBandeiraCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.txtValorCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblValorCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblNumeroParcelaCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.cboBandeiraCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblBandeiraCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblDataPagamentoCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.txtNumeroParcelaCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.dtpDataPagamentoCartaoCredito)
        Me.grpCartaoCredito.Location = New System.Drawing.Point(180, 0)
        Me.grpCartaoCredito.Name = "grpCartaoCredito"
        Me.grpCartaoCredito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCartaoCredito.Size = New System.Drawing.Size(505, 104)
        Me.grpCartaoCredito.TabIndex = 10
        Me.grpCartaoCredito.Visible = False
        Me.grpCartaoCredito.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarMaquinaCartao
        '
        Me.btnCadastrarMaquinaCartao.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMaquinaCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMaquinaCartao.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarMaquinaCartao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMaquinaCartao.Location = New System.Drawing.Point(10, 17)
        Me.btnCadastrarMaquinaCartao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMaquinaCartao.Name = "btnCadastrarMaquinaCartao"
        Me.btnCadastrarMaquinaCartao.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMaquinaCartao.TabIndex = 9
        Me.btnCadastrarMaquinaCartao.TabStop = False
        Me.btnCadastrarMaquinaCartao.UseVisualStyleBackColor = True
        '
        'cboMaquinaCartao
        '
        Me.cboMaquinaCartao.AutoSize = False
        Me.cboMaquinaCartao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMaquinaCartao.Location = New System.Drawing.Point(10, 34)
        Me.cboMaquinaCartao.Name = "cboMaquinaCartao"
        Me.cboMaquinaCartao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaquinaCartao.Size = New System.Drawing.Size(299, 20)
        Me.cboMaquinaCartao.TabIndex = 11
        '
        'lblMaquinaCartao
        '
        Me.lblMaquinaCartao.AutoSize = True
        Me.lblMaquinaCartao.Location = New System.Drawing.Point(26, 17)
        Me.lblMaquinaCartao.Name = "lblMaquinaCartao"
        Me.lblMaquinaCartao.Size = New System.Drawing.Size(50, 14)
        Me.lblMaquinaCartao.TabIndex = 10
        Me.lblMaquinaCartao.Text = "Máquina:"
        '
        'btnCadastrarBandeiraCartaoCredito
        '
        Me.btnCadastrarBandeiraCartaoCredito.FlatAppearance.BorderSize = 0
        Me.btnCadastrarBandeiraCartaoCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarBandeiraCartaoCredito.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarBandeiraCartaoCredito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarBandeiraCartaoCredito.Location = New System.Drawing.Point(9, 57)
        Me.btnCadastrarBandeiraCartaoCredito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarBandeiraCartaoCredito.Name = "btnCadastrarBandeiraCartaoCredito"
        Me.btnCadastrarBandeiraCartaoCredito.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarBandeiraCartaoCredito.TabIndex = 0
        Me.btnCadastrarBandeiraCartaoCredito.TabStop = False
        Me.btnCadastrarBandeiraCartaoCredito.UseVisualStyleBackColor = True
        '
        'txtValorCartaoCredito
        '
        Me.txtValorCartaoCredito.Location = New System.Drawing.Point(314, 74)
        Me.txtValorCartaoCredito.Name = "txtValorCartaoCredito"
        Me.txtValorCartaoCredito.Size = New System.Drawing.Size(98, 20)
        Me.txtValorCartaoCredito.TabIndex = 6
        Me.txtValorCartaoCredito.Text = "0,00"
        Me.txtValorCartaoCredito.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCartaoCredito
        '
        Me.lblValorCartaoCredito.AutoSize = True
        Me.lblValorCartaoCredito.Location = New System.Drawing.Point(311, 57)
        Me.lblValorCartaoCredito.Name = "lblValorCartaoCredito"
        Me.lblValorCartaoCredito.Size = New System.Drawing.Size(35, 14)
        Me.lblValorCartaoCredito.TabIndex = 5
        Me.lblValorCartaoCredito.Text = "Valor:"
        '
        'lblNumeroParcelaCartaoCredito
        '
        Me.lblNumeroParcelaCartaoCredito.AutoSize = True
        Me.lblNumeroParcelaCartaoCredito.Location = New System.Drawing.Point(415, 57)
        Me.lblNumeroParcelaCartaoCredito.Name = "lblNumeroParcelaCartaoCredito"
        Me.lblNumeroParcelaCartaoCredito.Size = New System.Drawing.Size(67, 14)
        Me.lblNumeroParcelaCartaoCredito.TabIndex = 7
        Me.lblNumeroParcelaCartaoCredito.Text = "Nº Parcelas:"
        '
        'cboBandeiraCartaoCredito
        '
        Me.cboBandeiraCartaoCredito.AutoSize = False
        Me.cboBandeiraCartaoCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboBandeiraCartaoCredito.Location = New System.Drawing.Point(9, 74)
        Me.cboBandeiraCartaoCredito.Name = "cboBandeiraCartaoCredito"
        Me.cboBandeiraCartaoCredito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBandeiraCartaoCredito.Size = New System.Drawing.Size(202, 20)
        Me.cboBandeiraCartaoCredito.TabIndex = 2
        '
        'lblBandeiraCartaoCredito
        '
        Me.lblBandeiraCartaoCredito.AutoSize = True
        Me.lblBandeiraCartaoCredito.Location = New System.Drawing.Point(25, 57)
        Me.lblBandeiraCartaoCredito.Name = "lblBandeiraCartaoCredito"
        Me.lblBandeiraCartaoCredito.Size = New System.Drawing.Size(53, 14)
        Me.lblBandeiraCartaoCredito.TabIndex = 1
        Me.lblBandeiraCartaoCredito.Text = "Bandeira:"
        '
        'lblDataPagamentoCartaoCredito
        '
        Me.lblDataPagamentoCartaoCredito.AutoSize = True
        Me.lblDataPagamentoCartaoCredito.Location = New System.Drawing.Point(214, 57)
        Me.lblDataPagamentoCartaoCredito.Name = "lblDataPagamentoCartaoCredito"
        Me.lblDataPagamentoCartaoCredito.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoCartaoCredito.TabIndex = 3
        Me.lblDataPagamentoCartaoCredito.Text = "Data Pgto.:"
        '
        'txtNumeroParcelaCartaoCredito
        '
        Me.txtNumeroParcelaCartaoCredito.DecimalDigits = 0
        Me.txtNumeroParcelaCartaoCredito.Location = New System.Drawing.Point(418, 74)
        Me.txtNumeroParcelaCartaoCredito.Name = "txtNumeroParcelaCartaoCredito"
        Me.txtNumeroParcelaCartaoCredito.Size = New System.Drawing.Size(87, 20)
        Me.txtNumeroParcelaCartaoCredito.TabIndex = 8
        Me.txtNumeroParcelaCartaoCredito.Text = "0"
        Me.txtNumeroParcelaCartaoCredito.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dtpDataPagamentoCartaoCredito
        '
        '
        '
        '
        Me.dtpDataPagamentoCartaoCredito.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoCartaoCredito.Location = New System.Drawing.Point(217, 74)
        Me.dtpDataPagamentoCartaoCredito.Name = "dtpDataPagamentoCartaoCredito"
        Me.dtpDataPagamentoCartaoCredito.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoCartaoCredito.TabIndex = 4
        Me.dtpDataPagamentoCartaoCredito.Value = New Date(2016, 7, 26, 0, 0, 0, 0)
        '
        'grpSaldoCliente
        '
        Me.grpSaldoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSaldoCliente.BackColor = System.Drawing.Color.Transparent
        Me.grpSaldoCliente.BorderColor = System.Drawing.Color.Transparent
        Me.grpSaldoCliente.Controls.Add(Me.dtpDataPagamentoSaldoCliente)
        Me.grpSaldoCliente.Controls.Add(Me.txtValorSaldoCliente)
        Me.grpSaldoCliente.Controls.Add(Me.lblValorSaldoCliente)
        Me.grpSaldoCliente.Controls.Add(Me.lblDataPagamentoSaldoCliente)
        Me.grpSaldoCliente.Location = New System.Drawing.Point(181, 0)
        Me.grpSaldoCliente.Name = "grpSaldoCliente"
        Me.grpSaldoCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSaldoCliente.Size = New System.Drawing.Size(505, 104)
        Me.grpSaldoCliente.TabIndex = 11
        Me.grpSaldoCliente.Visible = False
        Me.grpSaldoCliente.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoSaldoCliente
        '
        '
        '
        '
        Me.dtpDataPagamentoSaldoCliente.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoSaldoCliente.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataPagamentoSaldoCliente.Name = "dtpDataPagamentoSaldoCliente"
        Me.dtpDataPagamentoSaldoCliente.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoSaldoCliente.TabIndex = 7
        Me.dtpDataPagamentoSaldoCliente.Value = New Date(2017, 10, 27, 0, 0, 0, 0)
        '
        'txtValorSaldoCliente
        '
        Me.txtValorSaldoCliente.Location = New System.Drawing.Point(106, 34)
        Me.txtValorSaldoCliente.Name = "txtValorSaldoCliente"
        Me.txtValorSaldoCliente.Size = New System.Drawing.Size(98, 20)
        Me.txtValorSaldoCliente.TabIndex = 9
        Me.txtValorSaldoCliente.Text = "0,00"
        Me.txtValorSaldoCliente.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorSaldoCliente
        '
        Me.lblValorSaldoCliente.AutoSize = True
        Me.lblValorSaldoCliente.Location = New System.Drawing.Point(103, 17)
        Me.lblValorSaldoCliente.Name = "lblValorSaldoCliente"
        Me.lblValorSaldoCliente.Size = New System.Drawing.Size(35, 14)
        Me.lblValorSaldoCliente.TabIndex = 8
        Me.lblValorSaldoCliente.Text = "Valor:"
        '
        'lblDataPagamentoSaldoCliente
        '
        Me.lblDataPagamentoSaldoCliente.AutoSize = True
        Me.lblDataPagamentoSaldoCliente.Location = New System.Drawing.Point(6, 17)
        Me.lblDataPagamentoSaldoCliente.Name = "lblDataPagamentoSaldoCliente"
        Me.lblDataPagamentoSaldoCliente.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoSaldoCliente.TabIndex = 6
        Me.lblDataPagamentoSaldoCliente.Text = "Data Pgto.:"
        '
        'grpCheque
        '
        Me.grpCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCheque.BackColor = System.Drawing.Color.Transparent
        Me.grpCheque.BorderColor = System.Drawing.Color.Transparent
        Me.grpCheque.Controls.Add(Me.dtpDataCompensacaoCheque)
        Me.grpCheque.Controls.Add(Me.dtpDataPagamentoCheque)
        Me.grpCheque.Controls.Add(Me.lblDataCompensacaoCheque)
        Me.grpCheque.Controls.Add(Me.txtValorCheque)
        Me.grpCheque.Controls.Add(Me.lblValorCheque)
        Me.grpCheque.Controls.Add(Me.lblDataPagamentoCheque)
        Me.grpCheque.Controls.Add(Me.txtNumeroDocumentoCheque)
        Me.grpCheque.Controls.Add(Me.lblNumeroDocumentoCheque)
        Me.grpCheque.Controls.Add(Me.lblPreDatadoCheque)
        Me.grpCheque.Controls.Add(Me.cboPreDatadoCheque)
        Me.grpCheque.Controls.Add(Me.txtFavorecidoCheque)
        Me.grpCheque.Controls.Add(Me.lblFavorecidoCheque)
        Me.grpCheque.Location = New System.Drawing.Point(181, 0)
        Me.grpCheque.Name = "grpCheque"
        Me.grpCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCheque.Size = New System.Drawing.Size(481, 104)
        Me.grpCheque.TabIndex = 1
        Me.grpCheque.Visible = False
        Me.grpCheque.VisualStyleManager = Me.vsmMain
        '
        'dtpDataCompensacaoCheque
        '
        '
        '
        '
        Me.dtpDataCompensacaoCheque.DropDownCalendar.Name = ""
        Me.dtpDataCompensacaoCheque.Location = New System.Drawing.Point(216, 74)
        Me.dtpDataCompensacaoCheque.Name = "dtpDataCompensacaoCheque"
        Me.dtpDataCompensacaoCheque.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataCompensacaoCheque.TabIndex = 11
        Me.dtpDataCompensacaoCheque.Value = New Date(2016, 7, 26, 0, 0, 0, 0)
        '
        'dtpDataPagamentoCheque
        '
        '
        '
        '
        Me.dtpDataPagamentoCheque.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoCheque.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoCheque.Name = "dtpDataPagamentoCheque"
        Me.dtpDataPagamentoCheque.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoCheque.TabIndex = 3
        Me.dtpDataPagamentoCheque.Value = New Date(2016, 7, 26, 0, 0, 0, 0)
        '
        'lblDataCompensacaoCheque
        '
        Me.lblDataCompensacaoCheque.AutoSize = True
        Me.lblDataCompensacaoCheque.Location = New System.Drawing.Point(213, 57)
        Me.lblDataCompensacaoCheque.Name = "lblDataCompensacaoCheque"
        Me.lblDataCompensacaoCheque.Size = New System.Drawing.Size(88, 14)
        Me.lblDataCompensacaoCheque.TabIndex = 10
        Me.lblDataCompensacaoCheque.Text = "Pré-datado para:"
        '
        'txtValorCheque
        '
        Me.txtValorCheque.Location = New System.Drawing.Point(9, 74)
        Me.txtValorCheque.Name = "txtValorCheque"
        Me.txtValorCheque.Size = New System.Drawing.Size(104, 20)
        Me.txtValorCheque.TabIndex = 7
        Me.txtValorCheque.Text = "0,00"
        Me.txtValorCheque.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCheque
        '
        Me.lblValorCheque.AutoSize = True
        Me.lblValorCheque.Location = New System.Drawing.Point(6, 57)
        Me.lblValorCheque.Name = "lblValorCheque"
        Me.lblValorCheque.Size = New System.Drawing.Size(75, 14)
        Me.lblValorCheque.TabIndex = 6
        Me.lblValorCheque.Text = "Valor Cheque:"
        '
        'lblDataPagamentoCheque
        '
        Me.lblDataPagamentoCheque.AutoSize = True
        Me.lblDataPagamentoCheque.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoCheque.Name = "lblDataPagamentoCheque"
        Me.lblDataPagamentoCheque.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoCheque.TabIndex = 2
        Me.lblDataPagamentoCheque.Text = "Data Pgto.:"
        '
        'txtNumeroDocumentoCheque
        '
        Me.txtNumeroDocumentoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoCheque.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoCheque.MaxLength = 20
        Me.txtNumeroDocumentoCheque.Name = "txtNumeroDocumentoCheque"
        Me.txtNumeroDocumentoCheque.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroDocumentoCheque.TabIndex = 1
        '
        'lblNumeroDocumentoCheque
        '
        Me.lblNumeroDocumentoCheque.AutoSize = True
        Me.lblNumeroDocumentoCheque.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoCheque.Name = "lblNumeroDocumentoCheque"
        Me.lblNumeroDocumentoCheque.Size = New System.Drawing.Size(62, 14)
        Me.lblNumeroDocumentoCheque.TabIndex = 0
        Me.lblNumeroDocumentoCheque.Text = "Nº Cheque:"
        '
        'lblPreDatadoCheque
        '
        Me.lblPreDatadoCheque.AutoSize = True
        Me.lblPreDatadoCheque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPreDatadoCheque.Location = New System.Drawing.Point(116, 57)
        Me.lblPreDatadoCheque.Name = "lblPreDatadoCheque"
        Me.lblPreDatadoCheque.Size = New System.Drawing.Size(63, 14)
        Me.lblPreDatadoCheque.TabIndex = 8
        Me.lblPreDatadoCheque.Text = "Pré-datado:"
        '
        'cboPreDatadoCheque
        '
        Me.cboPreDatadoCheque.AutoSize = False
        Me.cboPreDatadoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPreDatadoCheque.Location = New System.Drawing.Point(119, 74)
        Me.cboPreDatadoCheque.Name = "cboPreDatadoCheque"
        Me.cboPreDatadoCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPreDatadoCheque.Size = New System.Drawing.Size(91, 20)
        Me.cboPreDatadoCheque.TabIndex = 9
        '
        'txtFavorecidoCheque
        '
        Me.txtFavorecidoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFavorecidoCheque.Location = New System.Drawing.Point(216, 34)
        Me.txtFavorecidoCheque.MaxLength = 100
        Me.txtFavorecidoCheque.Name = "txtFavorecidoCheque"
        Me.txtFavorecidoCheque.Size = New System.Drawing.Size(259, 20)
        Me.txtFavorecidoCheque.TabIndex = 5
        '
        'lblFavorecidoCheque
        '
        Me.lblFavorecidoCheque.AutoSize = True
        Me.lblFavorecidoCheque.Location = New System.Drawing.Point(213, 17)
        Me.lblFavorecidoCheque.Name = "lblFavorecidoCheque"
        Me.lblFavorecidoCheque.Size = New System.Drawing.Size(64, 14)
        Me.lblFavorecidoCheque.TabIndex = 4
        Me.lblFavorecidoCheque.Text = "Favorecido:"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtDescritivo)
        Me.grpDados.Controls.Add(Me.lblDescritivo)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(879, 262)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados da Receita"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtDescritivo
        '
        Me.txtDescritivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescritivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivo.Location = New System.Drawing.Point(9, 37)
        Me.txtDescritivo.MaxLength = 500
        Me.txtDescritivo.Multiline = True
        Me.txtDescritivo.Name = "txtDescritivo"
        Me.txtDescritivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescritivo.Size = New System.Drawing.Size(861, 215)
        Me.txtDescritivo.TabIndex = 1
        '
        'lblDescritivo
        '
        Me.lblDescritivo.AutoSize = True
        Me.lblDescritivo.Location = New System.Drawing.Point(6, 20)
        Me.lblDescritivo.Name = "lblDescritivo"
        Me.lblDescritivo.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivo.TabIndex = 0
        Me.lblDescritivo.Text = "Descritivo:"
        '
        'pagClassificacao
        '
        Me.pagClassificacao.Controls.Add(Me.grpClassificao)
        Me.pagClassificacao.Controls.Add(Me.grdClassificacao)
        Me.pagClassificacao.Key = "pagClassificacao"
        Me.pagClassificacao.Location = New System.Drawing.Point(1, 22)
        Me.pagClassificacao.Name = "pagClassificacao"
        Me.pagClassificacao.Size = New System.Drawing.Size(895, 384)
        Me.pagClassificacao.TabStop = True
        Me.pagClassificacao.Text = "Classificação"
        '
        'grpClassificao
        '
        Me.grpClassificao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpClassificao.BackColor = System.Drawing.Color.Transparent
        Me.grpClassificao.Controls.Add(Me.txtValorClassificacao)
        Me.grpClassificao.Controls.Add(Me.lblValorClassificacao)
        Me.grpClassificao.Controls.Add(Me.lblContaContabil)
        Me.grpClassificao.Controls.Add(Me.cboContaContabil)
        Me.grpClassificao.Controls.Add(Me.lblCentroGasto)
        Me.grpClassificao.Controls.Add(Me.cboCentroGasto)
        Me.grpClassificao.Controls.Add(Me.btnExcluirClassificacao)
        Me.grpClassificao.Controls.Add(Me.btnInserirClassificao)
        Me.grpClassificao.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpClassificao.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpClassificao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpClassificao.Location = New System.Drawing.Point(8, 3)
        Me.grpClassificao.Name = "grpClassificao"
        Me.grpClassificao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpClassificao.Size = New System.Drawing.Size(879, 67)
        Me.grpClassificao.TabIndex = 0
        Me.grpClassificao.Text = "Dados da Classificação"
        Me.grpClassificao.VisualStyleManager = Me.vsmMain
        '
        'txtValorClassificacao
        '
        Me.txtValorClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorClassificacao.DecimalDigits = 2
        Me.txtValorClassificacao.Location = New System.Drawing.Point(568, 37)
        Me.txtValorClassificacao.MaxLength = 0
        Me.txtValorClassificacao.Name = "txtValorClassificacao"
        Me.txtValorClassificacao.Size = New System.Drawing.Size(99, 20)
        Me.txtValorClassificacao.TabIndex = 7
        Me.txtValorClassificacao.Text = "0,00"
        Me.txtValorClassificacao.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorClassificacao
        '
        Me.lblValorClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorClassificacao.AutoSize = True
        Me.lblValorClassificacao.Location = New System.Drawing.Point(565, 20)
        Me.lblValorClassificacao.Name = "lblValorClassificacao"
        Me.lblValorClassificacao.Size = New System.Drawing.Size(35, 14)
        Me.lblValorClassificacao.TabIndex = 6
        Me.lblValorClassificacao.Text = "Valor:"
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(410, 20)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 4
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(394, 37)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(168, 20)
        Me.cboContaContabil.TabIndex = 5
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(25, 20)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 1
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(9, 37)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(379, 20)
        Me.cboCentroGasto.TabIndex = 2
        '
        'btnExcluirClassificacao
        '
        Me.btnExcluirClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirClassificacao.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirClassificacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirClassificacao.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirClassificacao.Location = New System.Drawing.Point(779, 34)
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
        Me.btnInserirClassificao.Location = New System.Drawing.Point(682, 34)
        Me.btnInserirClassificao.Name = "btnInserirClassificao"
        Me.btnInserirClassificao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirClassificao.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirClassificao.TabIndex = 8
        Me.btnInserirClassificao.Text = "Inserir"
        Me.btnInserirClassificao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(394, 21)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 3
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 0
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'grdClassificacao
        '
        Me.grdClassificacao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdClassificacao.AlternatingColors = True
        Me.grdClassificacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdClassificacao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdClassificacao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdClassificacao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdClassificacao_DesignTimeLayout_Reference_0})
        grdClassificacao_DesignTimeLayout.LayoutString = resources.GetString("grdClassificacao_DesignTimeLayout.LayoutString")
        Me.grdClassificacao.DesignTimeLayout = grdClassificacao_DesignTimeLayout
        Me.grdClassificacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdClassificacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdClassificacao.GroupByBoxVisible = False
        Me.grdClassificacao.Location = New System.Drawing.Point(8, 79)
        Me.grdClassificacao.Name = "grdClassificacao"
        Me.grdClassificacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdClassificacao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdClassificacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdClassificacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdClassificacao.Size = New System.Drawing.Size(879, 295)
        Me.grdClassificacao.TabIndex = 1
        Me.grdClassificacao.TabStop = False
        Me.grdClassificacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdClassificacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdClassificacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdClassificacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdClassificacao.VisualStyleManager = Me.vsmMain
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.lblPedidoVenda)
        Me.grpInformacoes.Controls.Add(Me.cboPedidoVenda)
        Me.grpInformacoes.Controls.Add(Me.txtValor)
        Me.grpInformacoes.Controls.Add(Me.lblValor)
        Me.grpInformacoes.Controls.Add(Me.dtpDataVencimento)
        Me.grpInformacoes.Controls.Add(Me.lblDataVencimento)
        Me.grpInformacoes.Controls.Add(Me.dtpDataEmissao)
        Me.grpInformacoes.Controls.Add(Me.lblDataEmissao)
        Me.grpInformacoes.Controls.Add(Me.txtSerie)
        Me.grpInformacoes.Controls.Add(Me.lblSerie)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.cboCliente)
        Me.grpInformacoes.Controls.Add(Me.lblCliente)
        Me.grpInformacoes.Controls.Add(Me.btnProcurarCliente)
        Me.grpInformacoes.Controls.Add(Me.btnCadastrarCliente)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(897, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtValor
        '
        Me.txtValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(678, 34)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(96, 20)
        Me.txtValor.TabIndex = 13
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(675, 17)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 12
        Me.lblValor.Text = "Valor:"
        '
        'dtpDataVencimento
        '
        Me.dtpDataVencimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataVencimento.DropDownCalendar.Name = ""
        Me.dtpDataVencimento.Location = New System.Drawing.Point(582, 34)
        Me.dtpDataVencimento.Name = "dtpDataVencimento"
        Me.dtpDataVencimento.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataVencimento.TabIndex = 11
        Me.dtpDataVencimento.Value = New Date(2017, 8, 10, 0, 0, 0, 0)
        '
        'lblDataVencimento
        '
        Me.lblDataVencimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataVencimento.AutoSize = True
        Me.lblDataVencimento.Location = New System.Drawing.Point(579, 17)
        Me.lblDataVencimento.Name = "lblDataVencimento"
        Me.lblDataVencimento.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimento.TabIndex = 10
        Me.lblDataVencimento.Text = "Data Vencimento:"
        '
        'dtpDataEmissao
        '
        '
        '
        '
        Me.dtpDataEmissao.DropDownCalendar.Name = ""
        Me.dtpDataEmissao.Location = New System.Drawing.Point(160, 34)
        Me.dtpDataEmissao.Name = "dtpDataEmissao"
        Me.dtpDataEmissao.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataEmissao.TabIndex = 5
        Me.dtpDataEmissao.Value = New Date(2017, 8, 10, 0, 0, 0, 0)
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(157, 17)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 4
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(114, 34)
        Me.txtSerie.MaxLength = 3
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(40, 20)
        Me.txtSerie.TabIndex = 3
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(111, 17)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Série:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'cboCliente
        '
        Me.cboCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(256, 34)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(320, 20)
        Me.cboCliente.TabIndex = 8
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(272, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Cliente:"
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(559, 15)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 9
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCliente.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCliente.Location = New System.Drawing.Point(256, 17)
        Me.btnCadastrarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCliente.TabIndex = 6
        Me.btnCadastrarCliente.TabStop = False
        Me.btnCadastrarCliente.UseVisualStyleBackColor = True
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 2000
        Me.jstTip.ImageList = Nothing
        '
        'lblPedidoVenda
        '
        Me.lblPedidoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPedidoVenda.AutoSize = True
        Me.lblPedidoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPedidoVenda.Location = New System.Drawing.Point(777, 17)
        Me.lblPedidoVenda.Name = "lblPedidoVenda"
        Me.lblPedidoVenda.Size = New System.Drawing.Size(76, 14)
        Me.lblPedidoVenda.TabIndex = 16
        Me.lblPedidoVenda.Text = "Pedido Venda:"
        '
        'cboPedidoVenda
        '
        Me.cboPedidoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPedidoVenda.AutoSize = False
        Me.cboPedidoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPedidoVenda.Location = New System.Drawing.Point(780, 34)
        Me.cboPedidoVenda.Name = "cboPedidoVenda"
        Me.cboPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPedidoVenda.Size = New System.Drawing.Size(108, 20)
        Me.cboPedidoVenda.TabIndex = 17
        '
        'usrFinReceitaAdiantamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinReceitaAdiantamento"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picAntecipado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloAberto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloParcialmenteQuitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagReceita.ResumeLayout(False)
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPagamento.ResumeLayout(False)
        Me.grpPagamento.PerformLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChequeTerceiro.ResumeLayout(False)
        Me.grpChequeTerceiro.PerformLayout()
        CType(Me.grpOutros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutros.ResumeLayout(False)
        Me.grpOutros.PerformLayout()
        CType(Me.grpOutrosSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutrosSimples.ResumeLayout(False)
        Me.grpOutrosSimples.PerformLayout()
        CType(Me.grpDescontoDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDescontoDuplicata.ResumeLayout(False)
        Me.grpDescontoDuplicata.PerformLayout()
        CType(Me.grpBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoleto.ResumeLayout(False)
        Me.grpBoleto.PerformLayout()
        CType(Me.grpCartaoCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCartaoCredito.ResumeLayout(False)
        Me.grpCartaoCredito.PerformLayout()
        CType(Me.grpSaldoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSaldoCliente.ResumeLayout(False)
        Me.grpSaldoCliente.PerformLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCheque.ResumeLayout(False)
        Me.grpCheque.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.pagClassificacao.ResumeLayout(False)
        CType(Me.grpClassificao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClassificao.ResumeLayout(False)
        Me.grpClassificao.PerformLayout()
        CType(Me.grdClassificacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagReceita As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoTituloFinanceiroFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoTituloFinanceiroFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picTituloParcialmenteQuitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloParcialmenteQuitado As System.Windows.Forms.Label
    Friend WithEvents lblTituloAberto As System.Windows.Forms.Label
    Friend WithEvents picTituloAberto As System.Windows.Forms.PictureBox
    Friend WithEvents picTituloQuitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloCancelado As System.Windows.Forms.Label
    Friend WithEvents picTituloCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloQuitado As System.Windows.Forms.Label
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Private WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarCliente As System.Windows.Forms.Button
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtDescritivo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescritivo As System.Windows.Forms.Label
    Friend WithEvents txtClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAtivar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagClassificacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpClassificao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdClassificacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtValorClassificacao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorClassificacao As System.Windows.Forms.Label
    Friend WithEvents btnExcluirClassificacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirClassificao As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents picAntecipado As System.Windows.Forms.PictureBox
    Friend WithEvents lblAntecipado As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents dtpDataPagamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPagamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnProcurarClienteFiltro As System.Windows.Forms.Button
    Friend WithEvents txtValorFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFiltro As System.Windows.Forms.Label
    Friend WithEvents lblContaBancariaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboContaBancariaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents txtDescritivoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescritivoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataVencimento As System.Windows.Forms.Label
    Friend WithEvents grpPagamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarContaBancaria As System.Windows.Forms.Button
    Friend WithEvents lblTipoDocumentoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpSaldoCliente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoSaldoCliente As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorSaldoCliente As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorSaldoCliente As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoSaldoCliente As System.Windows.Forms.Label
    Friend WithEvents grpCheque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataCompensacaoCheque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoCheque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCompensacaoCheque As System.Windows.Forms.Label
    Friend WithEvents txtValorCheque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCheque As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoCheque As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoCheque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoCheque As System.Windows.Forms.Label
    Friend WithEvents lblPreDatadoCheque As System.Windows.Forms.Label
    Friend WithEvents cboPreDatadoCheque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtFavorecidoCheque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFavorecidoCheque As System.Windows.Forms.Label
    Friend WithEvents grpChequeTerceiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoChequeTerceiro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorChequeTerceiro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtPreDatadoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPreDatadoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents cboNumeroDocumentoChequeTerceiro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroDocumentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtDataRecebimentoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataRecebimentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtContaChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblContaChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtAgenciaChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAgenciaChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtBancoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBancoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents grpOutros As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoOutros As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorOutros As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOutros As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoOutros As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoOutros As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoOutros As System.Windows.Forms.Label
    Friend WithEvents grpOutrosSimples As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoOutrosSimples As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorOutrosSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOutrosSimples As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoOutrosSimples As System.Windows.Forms.Label
    Friend WithEvents grpDescontoDuplicata As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtJurosDescontoDuplicata As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblJurosDescontoDuplicata As System.Windows.Forms.Label
    Friend WithEvents dtpDataPagamentoDescontoDuplicata As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorDescontoDuplicata As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDescontoDuplicata As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoDescontoDuplicata As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoDescontoDuplicata As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoDescontoDuplicata As System.Windows.Forms.Label
    Friend WithEvents grpBoleto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoBoleto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorBoleto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBancoBoleto As System.Windows.Forms.Label
    Friend WithEvents txtBancoBoleto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataPagamentoBoleto As System.Windows.Forms.Label
    Friend WithEvents txtNumeroBoleto8 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto7 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto6 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto5 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto4 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto3 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoleto2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblValorBoleto As System.Windows.Forms.Label
    Friend WithEvents txtNumeroBoleto1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpCartaoCredito As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarMaquinaCartao As System.Windows.Forms.Button
    Friend WithEvents cboMaquinaCartao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaquinaCartao As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarBandeiraCartaoCredito As System.Windows.Forms.Button
    Friend WithEvents txtValorCartaoCredito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents lblNumeroParcelaCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents cboBandeiraCartaoCredito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblBandeiraCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcelaCartaoCredito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpDataPagamentoCartaoCredito As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblPedidoVenda As Label
    Friend WithEvents cboPedidoVenda As Janus.Windows.EditControls.UIComboBox
End Class
