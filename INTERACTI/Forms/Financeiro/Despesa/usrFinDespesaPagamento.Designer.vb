<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinDespesaPagamento
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPagamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPagamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinDespesaPagamento))
        Dim grdParcela_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblParcelaVencimentoFuturo = New System.Windows.Forms.Label()
        Me.picParcelaVencimentoFuturo = New System.Windows.Forms.PictureBox()
        Me.lblParcelaVencimentoAtrasado = New System.Windows.Forms.Label()
        Me.picParcelaVencimentoAtrasado = New System.Windows.Forms.PictureBox()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpValorSelecionado = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblValorTitulo = New System.Windows.Forms.Label()
        Me.lblLabelValorTitulo = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnPagar1 = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAdiantamentoFiltro = New System.Windows.Forms.Label()
        Me.cboAdiantamentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataVencimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFiltro = New System.Windows.Forms.Label()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataVencimentoFiltro = New System.Windows.Forms.Label()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridPagamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridPagamento = New System.Windows.Forms.Button()
        Me.btnExcelGridParcela = New System.Windows.Forms.Button()
        Me.btnAgruparGridParcela = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPagamento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridParcela = New System.Windows.Forms.Button()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnPagar = New Janus.Windows.EditControls.UIButton()
        Me.grdPagamento = New Janus.Windows.GridEX.GridEX()
        Me.grdParcela = New Janus.Windows.GridEX.GridEX()
        Me.grpPagamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.grpSaldoFornecedor = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoSaldoFornecedor = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorSaldoFornecedor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorSaldoFornecedor = New System.Windows.Forms.Label()
        Me.lblDataPagamentoSaldoFornecedor = New System.Windows.Forms.Label()
        Me.grpChequePerforma = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizarCheque = New System.Windows.Forms.Button()
        Me.btnAtualizar = New Janus.Windows.EditControls.UIButton()
        Me.lblNumeroCheque = New System.Windows.Forms.Label()
        Me.dtpDataCompensacaoChequePerforma = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboCheque = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataPagamentoChequePerforma = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCompensacaoChequePerforma = New System.Windows.Forms.Label()
        Me.txtValorChequePerforma = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorChequePerforma = New System.Windows.Forms.Label()
        Me.lblDataPagamentoChequePerforma = New System.Windows.Forms.Label()
        Me.lblPreDatadoChequePerforma = New System.Windows.Forms.Label()
        Me.cboPreDatadoChequePerforma = New Janus.Windows.EditControls.UIComboBox()
        Me.txtFavorecidoChequePerforma = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFavorecidoChequePerforma = New System.Windows.Forms.Label()
        Me.grpOutros = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoOutros = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorOutros = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOutros = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoOutros = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoOutros = New System.Windows.Forms.Label()
        Me.lblDataPagamentoOutros = New System.Windows.Forms.Label()
        Me.btnExcluirPagamento = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirPagamento = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarContaBancaria = New System.Windows.Forms.Button()
        Me.lblTipoDocumentoPagamento = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.grpOutrosSimples = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoOutrosSimples = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorOutrosSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOutrosSimples = New System.Windows.Forms.Label()
        Me.lblDataPagamentoOutrosSimples = New System.Windows.Forms.Label()
        Me.grpCartaoCredito = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarCartaoCredito = New System.Windows.Forms.Button()
        Me.txtValorCartaoCredito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCartaoCredito = New System.Windows.Forms.Label()
        Me.lblNumeroParcelaCartaoCredito = New System.Windows.Forms.Label()
        Me.cboCartaoCredito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCartaoCredito = New System.Windows.Forms.Label()
        Me.lblDataPagamentoCartaoCredito = New System.Windows.Forms.Label()
        Me.txtNumeroParcelaCartaoCredito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.dtpDataPagamentoCartaoCredito = New Janus.Windows.CalendarCombo.CalendarCombo()
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
        Me.grpBoletoGuia = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroBoletoGuia8 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia7 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia6 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia5 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia4 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia3 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataPagamentoBoletoGuia = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorBoletoGuia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumeroBoletoGuia2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroBoletoGuia1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBancoBoletoGuia = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picParcelaVencimentoFuturo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picParcelaVencimentoAtrasado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpValorSelecionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValorSelecionado.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
        CType(Me.grdPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPagamento.SuspendLayout()
        CType(Me.grpSaldoFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSaldoFornecedor.SuspendLayout()
        CType(Me.grpChequePerforma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChequePerforma.SuspendLayout()
        CType(Me.grpOutros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutros.SuspendLayout()
        CType(Me.grpOutrosSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutrosSimples.SuspendLayout()
        CType(Me.grpCartaoCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCartaoCredito.SuspendLayout()
        CType(Me.grpBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoleto.SuspendLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCheque.SuspendLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChequeTerceiro.SuspendLayout()
        CType(Me.grpBoletoGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoletoGuia.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.pagListagem.Controls.Add(Me.grpValorSelecionado)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Baixar Duplicatas"
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
        Me.btnExcelGrid.TabIndex = 24
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
        Me.btnAgruparGrid.TabIndex = 14
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
        Me.btnConfigurarGrid.TabIndex = 11
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblParcelaVencimentoFuturo)
        Me.grpLegenda.Controls.Add(Me.picParcelaVencimentoFuturo)
        Me.grpLegenda.Controls.Add(Me.lblParcelaVencimentoAtrasado)
        Me.grpLegenda.Controls.Add(Me.picParcelaVencimentoAtrasado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(183, 51)
        Me.grpLegenda.TabIndex = 6
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblParcelaVencimentoFuturo
        '
        Me.lblParcelaVencimentoFuturo.AutoSize = True
        Me.lblParcelaVencimentoFuturo.Location = New System.Drawing.Point(28, 13)
        Me.lblParcelaVencimentoFuturo.Name = "lblParcelaVencimentoFuturo"
        Me.lblParcelaVencimentoFuturo.Size = New System.Drawing.Size(151, 14)
        Me.lblParcelaVencimentoFuturo.TabIndex = 0
        Me.lblParcelaVencimentoFuturo.Text = "Duplicata - Vencimento Futuro"
        '
        'picParcelaVencimentoFuturo
        '
        Me.picParcelaVencimentoFuturo.BackColor = System.Drawing.Color.DarkGray
        Me.picParcelaVencimentoFuturo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParcelaVencimentoFuturo.Location = New System.Drawing.Point(9, 13)
        Me.picParcelaVencimentoFuturo.Name = "picParcelaVencimentoFuturo"
        Me.picParcelaVencimentoFuturo.Size = New System.Drawing.Size(13, 14)
        Me.picParcelaVencimentoFuturo.TabIndex = 14
        Me.picParcelaVencimentoFuturo.TabStop = False
        '
        'lblParcelaVencimentoAtrasado
        '
        Me.lblParcelaVencimentoAtrasado.AutoSize = True
        Me.lblParcelaVencimentoAtrasado.Location = New System.Drawing.Point(28, 30)
        Me.lblParcelaVencimentoAtrasado.Name = "lblParcelaVencimentoAtrasado"
        Me.lblParcelaVencimentoAtrasado.Size = New System.Drawing.Size(105, 14)
        Me.lblParcelaVencimentoAtrasado.TabIndex = 1
        Me.lblParcelaVencimentoAtrasado.Text = "Duplicata - Atrasada"
        '
        'picParcelaVencimentoAtrasado
        '
        Me.picParcelaVencimentoAtrasado.BackColor = System.Drawing.Color.Firebrick
        Me.picParcelaVencimentoAtrasado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParcelaVencimentoAtrasado.Location = New System.Drawing.Point(9, 30)
        Me.picParcelaVencimentoAtrasado.Name = "picParcelaVencimentoAtrasado"
        Me.picParcelaVencimentoAtrasado.Size = New System.Drawing.Size(13, 14)
        Me.picParcelaVencimentoAtrasado.TabIndex = 8
        Me.picParcelaVencimentoAtrasado.TabStop = False
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpValorSelecionado
        '
        Me.grpValorSelecionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpValorSelecionado.BackColor = System.Drawing.Color.Transparent
        Me.grpValorSelecionado.Controls.Add(Me.lblValorTitulo)
        Me.grpValorSelecionado.Controls.Add(Me.lblLabelValorTitulo)
        Me.grpValorSelecionado.Location = New System.Drawing.Point(200, 483)
        Me.grpValorSelecionado.Name = "grpValorSelecionado"
        Me.grpValorSelecionado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpValorSelecionado.Size = New System.Drawing.Size(207, 51)
        Me.grpValorSelecionado.TabIndex = 3
        Me.grpValorSelecionado.VisualStyleManager = Me.vsmMain
        '
        'lblValorTitulo
        '
        Me.lblValorTitulo.AutoSize = True
        Me.lblValorTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValorTitulo.Location = New System.Drawing.Point(120, 22)
        Me.lblValorTitulo.Name = "lblValorTitulo"
        Me.lblValorTitulo.Size = New System.Drawing.Size(44, 14)
        Me.lblValorTitulo.TabIndex = 1
        Me.lblValorTitulo.Text = "R$ 0,00"
        '
        'lblLabelValorTitulo
        '
        Me.lblLabelValorTitulo.AutoSize = True
        Me.lblLabelValorTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLabelValorTitulo.Location = New System.Drawing.Point(6, 22)
        Me.lblLabelValorTitulo.Name = "lblLabelValorTitulo"
        Me.lblLabelValorTitulo.Size = New System.Drawing.Size(108, 14)
        Me.lblLabelValorTitulo.TabIndex = 0
        Me.lblLabelValorTitulo.Text = "Valor Selecionado:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Controls.Add(Me.btnPagar1)
        Me.grpControle.Location = New System.Drawing.Point(416, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(574, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 11
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 12
        Me.cboCongelarColuna.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(474, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPagar1
        '
        Me.btnPagar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar1.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnPagar1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar1.Location = New System.Drawing.Point(318, 17)
        Me.btnPagar1.Name = "btnPagar1"
        Me.btnPagar1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar1.Size = New System.Drawing.Size(150, 23)
        Me.btnPagar1.TabIndex = 0
        Me.btnPagar1.Text = "Baixar Duplicatas"
        Me.btnPagar1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblAdiantamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAdiantamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblAdiantamentoFiltro
        '
        Me.lblAdiantamentoFiltro.AutoSize = True
        Me.lblAdiantamentoFiltro.Location = New System.Drawing.Point(321, 57)
        Me.lblAdiantamentoFiltro.Name = "lblAdiantamentoFiltro"
        Me.lblAdiantamentoFiltro.Size = New System.Drawing.Size(76, 14)
        Me.lblAdiantamentoFiltro.TabIndex = 12
        Me.lblAdiantamentoFiltro.Text = "Adiantamento:"
        '
        'cboAdiantamentoFiltro
        '
        Me.cboAdiantamentoFiltro.AutoSize = False
        Me.cboAdiantamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAdiantamentoFiltro.Location = New System.Drawing.Point(324, 74)
        Me.cboAdiantamentoFiltro.Name = "cboAdiantamentoFiltro"
        Me.cboAdiantamentoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAdiantamentoFiltro.Size = New System.Drawing.Size(128, 20)
        Me.cboAdiantamentoFiltro.TabIndex = 13
        '
        'dtpDataVencimentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoFiltro.Location = New System.Drawing.Point(114, 74)
        Me.dtpDataVencimentoTerminoFiltro.Name = "dtpDataVencimentoTerminoFiltro"
        Me.dtpDataVencimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoTerminoFiltro.TabIndex = 9
        '
        'dtpDataVencimentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataVencimentoInicioFiltro.Name = "dtpDataVencimentoInicioFiltro"
        Me.dtpDataVencimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoInicioFiltro.TabIndex = 8
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(219, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 4
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(114, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 3
        '
        'txtValorFiltro
        '
        Me.txtValorFiltro.Location = New System.Drawing.Point(219, 74)
        Me.txtValorFiltro.Name = "txtValorFiltro"
        Me.txtValorFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtValorFiltro.TabIndex = 11
        Me.txtValorFiltro.Text = "0,00"
        Me.txtValorFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFiltro
        '
        Me.lblValorFiltro.AutoSize = True
        Me.lblValorFiltro.Location = New System.Drawing.Point(216, 57)
        Me.lblValorFiltro.Name = "lblValorFiltro"
        Me.lblValorFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblValorFiltro.TabIndex = 10
        Me.lblValorFiltro.Text = "Valor:"
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 2
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
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
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(321, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 5
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 14
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataVencimentoFiltro
        '
        Me.lblDataVencimentoFiltro.AutoSize = True
        Me.lblDataVencimentoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataVencimentoFiltro.Name = "lblDataVencimentoFiltro"
        Me.lblDataVencimentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltro.TabIndex = 7
        Me.lblDataVencimentoFiltro.Text = "Data Vencimento:"
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(324, 34)
        Me.txtFornecedorFiltro.MaxLength = 20
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(385, 20)
        Me.txtFornecedorFiltro.TabIndex = 6
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridPagamento)
        Me.pagDados.Controls.Add(Me.btnAgruparGridPagamento)
        Me.pagDados.Controls.Add(Me.btnExcelGridParcela)
        Me.pagDados.Controls.Add(Me.btnAgruparGridParcela)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridPagamento)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridParcela)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Controls.Add(Me.grdPagamento)
        Me.pagDados.Controls.Add(Me.grdParcela)
        Me.pagDados.Controls.Add(Me.grpPagamento)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Baixar Duplicatas"
        '
        'btnExcelGridPagamento
        '
        Me.btnExcelGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPagamento.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPagamento.Name = "btnExcelGridPagamento"
        Me.btnExcelGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPagamento.TabIndex = 28
        Me.btnExcelGridPagamento.TabStop = False
        Me.btnExcelGridPagamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPagamento
        '
        Me.btnAgruparGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPagamento.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPagamento.Name = "btnAgruparGridPagamento"
        Me.btnAgruparGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPagamento.TabIndex = 27
        Me.btnAgruparGridPagamento.TabStop = False
        Me.btnAgruparGridPagamento.UseVisualStyleBackColor = False
        '
        'btnExcelGridParcela
        '
        Me.btnExcelGridParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridParcela.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridParcela.FlatAppearance.BorderSize = 0
        Me.btnExcelGridParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridParcela.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridParcela.Location = New System.Drawing.Point(57, 185)
        Me.btnExcelGridParcela.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridParcela.Name = "btnExcelGridParcela"
        Me.btnExcelGridParcela.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridParcela.TabIndex = 26
        Me.btnExcelGridParcela.TabStop = False
        Me.btnExcelGridParcela.UseVisualStyleBackColor = False
        '
        'btnAgruparGridParcela
        '
        Me.btnAgruparGridParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridParcela.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridParcela.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridParcela.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridParcela.Location = New System.Drawing.Point(33, 185)
        Me.btnAgruparGridParcela.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridParcela.Name = "btnAgruparGridParcela"
        Me.btnAgruparGridParcela.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridParcela.TabIndex = 25
        Me.btnAgruparGridParcela.TabStop = False
        Me.btnAgruparGridParcela.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPagamento
        '
        Me.btnConfigurarGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPagamento.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPagamento.Name = "btnConfigurarGridPagamento"
        Me.btnConfigurarGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPagamento.TabIndex = 4
        Me.btnConfigurarGridPagamento.TabStop = False
        Me.btnConfigurarGridPagamento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridParcela
        '
        Me.btnConfigurarGridParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridParcela.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridParcela.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridParcela.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridParcela.Location = New System.Drawing.Point(9, 185)
        Me.btnConfigurarGridParcela.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridParcela.Name = "btnConfigurarGridParcela"
        Me.btnConfigurarGridParcela.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridParcela.TabIndex = 1
        Me.btnConfigurarGridParcela.TabStop = False
        Me.btnConfigurarGridParcela.UseVisualStyleBackColor = False
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Controls.Add(Me.btnPagar)
        Me.grpControle2.Location = New System.Drawing.Point(8, 483)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(982, 51)
        Me.grpControle2.TabIndex = 5
        Me.grpControle2.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(882, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPagar
        '
        Me.btnPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnPagar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar.Location = New System.Drawing.Point(726, 17)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar.Size = New System.Drawing.Size(150, 23)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Baixar Duplicatas"
        Me.btnPagar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdPagamento
        '
        Me.grdPagamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPagamento.AlternatingColors = True
        Me.grdPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPagamento.AutoEdit = True
        grdPagamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdPagamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdPagamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdPagamento_DesignTimeLayout_Reference_0})
        grdPagamento_DesignTimeLayout.LayoutString = resources.GetString("grdPagamento_DesignTimeLayout.LayoutString")
        Me.grdPagamento.DesignTimeLayout = grdPagamento_DesignTimeLayout
        Me.grdPagamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPagamento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdPagamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPagamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPagamento.FrozenColumns = 2
        Me.grdPagamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPagamento.GroupByBoxVisible = False
        Me.grdPagamento.Location = New System.Drawing.Point(8, 318)
        Me.grdPagamento.Name = "grdPagamento"
        Me.grdPagamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPagamento.RecordNavigator = True
        Me.grdPagamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdPagamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPagamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPagamento.Size = New System.Drawing.Size(982, 162)
        Me.grdPagamento.TabIndex = 3
        Me.grdPagamento.TabStop = False
        Me.grdPagamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPagamento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdPagamento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdPagamento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPagamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPagamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPagamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPagamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPagamento.VisualStyleManager = Me.vsmMain
        '
        'grdParcela
        '
        Me.grdParcela.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdParcela_DesignTimeLayout.LayoutString = resources.GetString("grdParcela_DesignTimeLayout.LayoutString")
        Me.grdParcela.DesignTimeLayout = grdParcela_DesignTimeLayout
        Me.grdParcela.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdParcela.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdParcela.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdParcela.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdParcela.FrozenColumns = 1
        Me.grdParcela.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdParcela.GroupByBoxVisible = False
        Me.grdParcela.Location = New System.Drawing.Point(8, 9)
        Me.grdParcela.Name = "grdParcela"
        Me.grdParcela.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdParcela.RecordNavigator = True
        Me.grdParcela.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdParcela.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdParcela.Size = New System.Drawing.Size(982, 193)
        Me.grdParcela.TabIndex = 0
        Me.grdParcela.TabStop = False
        Me.grdParcela.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdParcela.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdParcela.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdParcela.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdParcela.VisualStyleManager = Me.vsmMain
        '
        'grpPagamento
        '
        Me.grpPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPagamento.BackColor = System.Drawing.Color.Transparent
        Me.grpPagamento.Controls.Add(Me.grpSaldoFornecedor)
        Me.grpPagamento.Controls.Add(Me.grpChequePerforma)
        Me.grpPagamento.Controls.Add(Me.grpOutros)
        Me.grpPagamento.Controls.Add(Me.btnExcluirPagamento)
        Me.grpPagamento.Controls.Add(Me.btnInserirPagamento)
        Me.grpPagamento.Controls.Add(Me.btnCadastrarContaBancaria)
        Me.grpPagamento.Controls.Add(Me.lblTipoDocumentoPagamento)
        Me.grpPagamento.Controls.Add(Me.cboTipoDocumentoPagamento)
        Me.grpPagamento.Controls.Add(Me.lblContaBancaria)
        Me.grpPagamento.Controls.Add(Me.cboContaBancaria)
        Me.grpPagamento.Controls.Add(Me.grpOutrosSimples)
        Me.grpPagamento.Controls.Add(Me.grpCartaoCredito)
        Me.grpPagamento.Controls.Add(Me.grpBoleto)
        Me.grpPagamento.Controls.Add(Me.grpCheque)
        Me.grpPagamento.Controls.Add(Me.grpChequeTerceiro)
        Me.grpPagamento.Controls.Add(Me.grpBoletoGuia)
        Me.grpPagamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPagamento.Location = New System.Drawing.Point(8, 205)
        Me.grpPagamento.Name = "grpPagamento"
        Me.grpPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPagamento.Size = New System.Drawing.Size(982, 104)
        Me.grpPagamento.TabIndex = 2
        Me.grpPagamento.VisualStyleManager = Me.vsmMain
        '
        'grpSaldoFornecedor
        '
        Me.grpSaldoFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSaldoFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.grpSaldoFornecedor.BorderColor = System.Drawing.Color.Transparent
        Me.grpSaldoFornecedor.Controls.Add(Me.dtpDataPagamentoSaldoFornecedor)
        Me.grpSaldoFornecedor.Controls.Add(Me.txtValorSaldoFornecedor)
        Me.grpSaldoFornecedor.Controls.Add(Me.lblValorSaldoFornecedor)
        Me.grpSaldoFornecedor.Controls.Add(Me.lblDataPagamentoSaldoFornecedor)
        Me.grpSaldoFornecedor.Location = New System.Drawing.Point(283, 1)
        Me.grpSaldoFornecedor.Name = "grpSaldoFornecedor"
        Me.grpSaldoFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSaldoFornecedor.Size = New System.Drawing.Size(593, 104)
        Me.grpSaldoFornecedor.TabIndex = 31
        Me.grpSaldoFornecedor.Visible = False
        Me.grpSaldoFornecedor.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoSaldoFornecedor
        '
        '
        '
        '
        Me.dtpDataPagamentoSaldoFornecedor.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoSaldoFornecedor.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataPagamentoSaldoFornecedor.Name = "dtpDataPagamentoSaldoFornecedor"
        Me.dtpDataPagamentoSaldoFornecedor.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoSaldoFornecedor.TabIndex = 1
        Me.dtpDataPagamentoSaldoFornecedor.Value = New Date(2017, 11, 17, 0, 0, 0, 0)
        '
        'txtValorSaldoFornecedor
        '
        Me.txtValorSaldoFornecedor.Location = New System.Drawing.Point(106, 34)
        Me.txtValorSaldoFornecedor.Name = "txtValorSaldoFornecedor"
        Me.txtValorSaldoFornecedor.Size = New System.Drawing.Size(98, 20)
        Me.txtValorSaldoFornecedor.TabIndex = 3
        Me.txtValorSaldoFornecedor.Text = "0,00"
        Me.txtValorSaldoFornecedor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorSaldoFornecedor
        '
        Me.lblValorSaldoFornecedor.AutoSize = True
        Me.lblValorSaldoFornecedor.Location = New System.Drawing.Point(103, 17)
        Me.lblValorSaldoFornecedor.Name = "lblValorSaldoFornecedor"
        Me.lblValorSaldoFornecedor.Size = New System.Drawing.Size(35, 14)
        Me.lblValorSaldoFornecedor.TabIndex = 2
        Me.lblValorSaldoFornecedor.Text = "Valor:"
        '
        'lblDataPagamentoSaldoFornecedor
        '
        Me.lblDataPagamentoSaldoFornecedor.AutoSize = True
        Me.lblDataPagamentoSaldoFornecedor.Location = New System.Drawing.Point(6, 17)
        Me.lblDataPagamentoSaldoFornecedor.Name = "lblDataPagamentoSaldoFornecedor"
        Me.lblDataPagamentoSaldoFornecedor.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoSaldoFornecedor.TabIndex = 0
        Me.lblDataPagamentoSaldoFornecedor.Text = "Data Pgto.:"
        '
        'grpChequePerforma
        '
        Me.grpChequePerforma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpChequePerforma.BackColor = System.Drawing.Color.Transparent
        Me.grpChequePerforma.BorderColor = System.Drawing.Color.Transparent
        Me.grpChequePerforma.Controls.Add(Me.btnAtualizarCheque)
        Me.grpChequePerforma.Controls.Add(Me.btnAtualizar)
        Me.grpChequePerforma.Controls.Add(Me.lblNumeroCheque)
        Me.grpChequePerforma.Controls.Add(Me.dtpDataCompensacaoChequePerforma)
        Me.grpChequePerforma.Controls.Add(Me.cboCheque)
        Me.grpChequePerforma.Controls.Add(Me.dtpDataPagamentoChequePerforma)
        Me.grpChequePerforma.Controls.Add(Me.lblDataCompensacaoChequePerforma)
        Me.grpChequePerforma.Controls.Add(Me.txtValorChequePerforma)
        Me.grpChequePerforma.Controls.Add(Me.lblValorChequePerforma)
        Me.grpChequePerforma.Controls.Add(Me.lblDataPagamentoChequePerforma)
        Me.grpChequePerforma.Controls.Add(Me.lblPreDatadoChequePerforma)
        Me.grpChequePerforma.Controls.Add(Me.cboPreDatadoChequePerforma)
        Me.grpChequePerforma.Controls.Add(Me.txtFavorecidoChequePerforma)
        Me.grpChequePerforma.Controls.Add(Me.lblFavorecidoChequePerforma)
        Me.grpChequePerforma.Location = New System.Drawing.Point(283, 1)
        Me.grpChequePerforma.Name = "grpChequePerforma"
        Me.grpChequePerforma.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpChequePerforma.Size = New System.Drawing.Size(593, 104)
        Me.grpChequePerforma.TabIndex = 9
        Me.grpChequePerforma.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizarCheque
        '
        Me.btnAtualizarCheque.FlatAppearance.BorderSize = 0
        Me.btnAtualizarCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizarCheque.Image = CType(resources.GetObject("btnAtualizarCheque.Image"), System.Drawing.Image)
        Me.btnAtualizarCheque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAtualizarCheque.Location = New System.Drawing.Point(93, 13)
        Me.btnAtualizarCheque.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtualizarCheque.Name = "btnAtualizarCheque"
        Me.btnAtualizarCheque.Size = New System.Drawing.Size(18, 20)
        Me.btnAtualizarCheque.TabIndex = 27
        Me.btnAtualizarCheque.TabStop = False
        Me.btnAtualizarCheque.UseVisualStyleBackColor = True
        Me.btnAtualizarCheque.Visible = False
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnAtualizar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnAtualizar.Location = New System.Drawing.Point(313, 70)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizar.Size = New System.Drawing.Size(103, 23)
        Me.btnAtualizar.TabIndex = 3
        Me.btnAtualizar.Text = "Atualizar Valor"
        Me.btnAtualizar.Visible = False
        Me.btnAtualizar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblNumeroCheque
        '
        Me.lblNumeroCheque.AutoSize = True
        Me.lblNumeroCheque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroCheque.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroCheque.Name = "lblNumeroCheque"
        Me.lblNumeroCheque.Size = New System.Drawing.Size(62, 14)
        Me.lblNumeroCheque.TabIndex = 13
        Me.lblNumeroCheque.Text = "Nº Cheque:"
        '
        'dtpDataCompensacaoChequePerforma
        '
        '
        '
        '
        Me.dtpDataCompensacaoChequePerforma.DropDownCalendar.Name = ""
        Me.dtpDataCompensacaoChequePerforma.Location = New System.Drawing.Point(216, 74)
        Me.dtpDataCompensacaoChequePerforma.Name = "dtpDataCompensacaoChequePerforma"
        Me.dtpDataCompensacaoChequePerforma.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataCompensacaoChequePerforma.TabIndex = 9
        '
        'cboCheque
        '
        Me.cboCheque.AutoSize = False
        Me.cboCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCheque.Location = New System.Drawing.Point(9, 34)
        Me.cboCheque.Name = "cboCheque"
        Me.cboCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCheque.Size = New System.Drawing.Size(104, 20)
        Me.cboCheque.TabIndex = 14
        '
        'dtpDataPagamentoChequePerforma
        '
        '
        '
        '
        Me.dtpDataPagamentoChequePerforma.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoChequePerforma.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoChequePerforma.Name = "dtpDataPagamentoChequePerforma"
        Me.dtpDataPagamentoChequePerforma.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoChequePerforma.TabIndex = 1
        '
        'lblDataCompensacaoChequePerforma
        '
        Me.lblDataCompensacaoChequePerforma.AutoSize = True
        Me.lblDataCompensacaoChequePerforma.Location = New System.Drawing.Point(213, 57)
        Me.lblDataCompensacaoChequePerforma.Name = "lblDataCompensacaoChequePerforma"
        Me.lblDataCompensacaoChequePerforma.Size = New System.Drawing.Size(88, 14)
        Me.lblDataCompensacaoChequePerforma.TabIndex = 8
        Me.lblDataCompensacaoChequePerforma.Text = "Pré-datado para:"
        '
        'txtValorChequePerforma
        '
        Me.txtValorChequePerforma.Location = New System.Drawing.Point(9, 74)
        Me.txtValorChequePerforma.Name = "txtValorChequePerforma"
        Me.txtValorChequePerforma.Size = New System.Drawing.Size(104, 20)
        Me.txtValorChequePerforma.TabIndex = 3
        Me.txtValorChequePerforma.Text = "0,00"
        Me.txtValorChequePerforma.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorChequePerforma
        '
        Me.lblValorChequePerforma.AutoSize = True
        Me.lblValorChequePerforma.Location = New System.Drawing.Point(6, 57)
        Me.lblValorChequePerforma.Name = "lblValorChequePerforma"
        Me.lblValorChequePerforma.Size = New System.Drawing.Size(75, 14)
        Me.lblValorChequePerforma.TabIndex = 10
        Me.lblValorChequePerforma.Text = "Valor Cheque:"
        '
        'lblDataPagamentoChequePerforma
        '
        Me.lblDataPagamentoChequePerforma.AutoSize = True
        Me.lblDataPagamentoChequePerforma.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoChequePerforma.Name = "lblDataPagamentoChequePerforma"
        Me.lblDataPagamentoChequePerforma.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoChequePerforma.TabIndex = 2
        Me.lblDataPagamentoChequePerforma.Text = "Data Pgto.:"
        '
        'lblPreDatadoChequePerforma
        '
        Me.lblPreDatadoChequePerforma.AutoSize = True
        Me.lblPreDatadoChequePerforma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPreDatadoChequePerforma.Location = New System.Drawing.Point(116, 57)
        Me.lblPreDatadoChequePerforma.Name = "lblPreDatadoChequePerforma"
        Me.lblPreDatadoChequePerforma.Size = New System.Drawing.Size(63, 14)
        Me.lblPreDatadoChequePerforma.TabIndex = 6
        Me.lblPreDatadoChequePerforma.Text = "Pré-datado:"
        '
        'cboPreDatadoChequePerforma
        '
        Me.cboPreDatadoChequePerforma.AutoSize = False
        Me.cboPreDatadoChequePerforma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPreDatadoChequePerforma.Location = New System.Drawing.Point(119, 74)
        Me.cboPreDatadoChequePerforma.Name = "cboPreDatadoChequePerforma"
        Me.cboPreDatadoChequePerforma.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPreDatadoChequePerforma.Size = New System.Drawing.Size(91, 20)
        Me.cboPreDatadoChequePerforma.TabIndex = 4
        '
        'txtFavorecidoChequePerforma
        '
        Me.txtFavorecidoChequePerforma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFavorecidoChequePerforma.Location = New System.Drawing.Point(216, 34)
        Me.txtFavorecidoChequePerforma.MaxLength = 100
        Me.txtFavorecidoChequePerforma.Name = "txtFavorecidoChequePerforma"
        Me.txtFavorecidoChequePerforma.Size = New System.Drawing.Size(289, 20)
        Me.txtFavorecidoChequePerforma.TabIndex = 2
        '
        'lblFavorecidoChequePerforma
        '
        Me.lblFavorecidoChequePerforma.AutoSize = True
        Me.lblFavorecidoChequePerforma.Location = New System.Drawing.Point(213, 17)
        Me.lblFavorecidoChequePerforma.Name = "lblFavorecidoChequePerforma"
        Me.lblFavorecidoChequePerforma.Size = New System.Drawing.Size(64, 14)
        Me.lblFavorecidoChequePerforma.TabIndex = 4
        Me.lblFavorecidoChequePerforma.Text = "Favorecido:"
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
        Me.grpOutros.Location = New System.Drawing.Point(283, 1)
        Me.grpOutros.Name = "grpOutros"
        Me.grpOutros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOutros.Size = New System.Drawing.Size(505, 104)
        Me.grpOutros.TabIndex = 1
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
        Me.dtpDataPagamentoOutros.TabIndex = 2
        '
        'txtValorOutros
        '
        Me.txtValorOutros.Location = New System.Drawing.Point(216, 34)
        Me.txtValorOutros.Name = "txtValorOutros"
        Me.txtValorOutros.Size = New System.Drawing.Size(98, 20)
        Me.txtValorOutros.TabIndex = 3
        Me.txtValorOutros.Text = "0,00"
        Me.txtValorOutros.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorOutros
        '
        Me.lblValorOutros.AutoSize = True
        Me.lblValorOutros.Location = New System.Drawing.Point(213, 17)
        Me.lblValorOutros.Name = "lblValorOutros"
        Me.lblValorOutros.Size = New System.Drawing.Size(35, 14)
        Me.lblValorOutros.TabIndex = 4
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
        'btnExcluirPagamento
        '
        Me.btnExcluirPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirPagamento.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirPagamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirPagamento.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirPagamento.Location = New System.Drawing.Point(882, 71)
        Me.btnExcluirPagamento.Name = "btnExcluirPagamento"
        Me.btnExcluirPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirPagamento.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirPagamento.TabIndex = 12
        Me.btnExcluirPagamento.Text = "Excluir"
        Me.btnExcluirPagamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirPagamento
        '
        Me.btnInserirPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirPagamento.Image = CType(resources.GetObject("btnInserirPagamento.Image"), System.Drawing.Image)
        Me.btnInserirPagamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirPagamento.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirPagamento.Location = New System.Drawing.Point(882, 42)
        Me.btnInserirPagamento.Name = "btnInserirPagamento"
        Me.btnInserirPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirPagamento.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirPagamento.TabIndex = 11
        Me.btnInserirPagamento.Text = "Inserir"
        Me.btnInserirPagamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.cboTipoDocumentoPagamento.Size = New System.Drawing.Size(273, 20)
        Me.cboTipoDocumentoPagamento.TabIndex = 4
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
        Me.cboContaBancaria.Size = New System.Drawing.Size(273, 20)
        Me.cboContaBancaria.TabIndex = 2
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
        Me.grpOutrosSimples.Location = New System.Drawing.Point(283, 1)
        Me.grpOutrosSimples.Name = "grpOutrosSimples"
        Me.grpOutrosSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOutrosSimples.Size = New System.Drawing.Size(505, 104)
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
        Me.lblDataPagamentoOutrosSimples.TabIndex = 2
        Me.lblDataPagamentoOutrosSimples.Text = "Data Pgto.:"
        '
        'grpCartaoCredito
        '
        Me.grpCartaoCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCartaoCredito.BackColor = System.Drawing.Color.Transparent
        Me.grpCartaoCredito.BorderColor = System.Drawing.Color.Transparent
        Me.grpCartaoCredito.Controls.Add(Me.btnCadastrarCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.txtValorCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblValorCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblNumeroParcelaCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.cboCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.lblDataPagamentoCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.txtNumeroParcelaCartaoCredito)
        Me.grpCartaoCredito.Controls.Add(Me.dtpDataPagamentoCartaoCredito)
        Me.grpCartaoCredito.Location = New System.Drawing.Point(283, 1)
        Me.grpCartaoCredito.Name = "grpCartaoCredito"
        Me.grpCartaoCredito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCartaoCredito.Size = New System.Drawing.Size(505, 104)
        Me.grpCartaoCredito.TabIndex = 5
        Me.grpCartaoCredito.Visible = False
        Me.grpCartaoCredito.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarCartaoCredito
        '
        Me.btnCadastrarCartaoCredito.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCartaoCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCartaoCredito.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCartaoCredito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCartaoCredito.Location = New System.Drawing.Point(9, 17)
        Me.btnCadastrarCartaoCredito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCartaoCredito.Name = "btnCadastrarCartaoCredito"
        Me.btnCadastrarCartaoCredito.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCartaoCredito.TabIndex = 0
        Me.btnCadastrarCartaoCredito.TabStop = False
        Me.btnCadastrarCartaoCredito.UseVisualStyleBackColor = True
        '
        'txtValorCartaoCredito
        '
        Me.txtValorCartaoCredito.Location = New System.Drawing.Point(314, 34)
        Me.txtValorCartaoCredito.Name = "txtValorCartaoCredito"
        Me.txtValorCartaoCredito.Size = New System.Drawing.Size(98, 20)
        Me.txtValorCartaoCredito.TabIndex = 6
        Me.txtValorCartaoCredito.Text = "0,00"
        Me.txtValorCartaoCredito.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCartaoCredito
        '
        Me.lblValorCartaoCredito.AutoSize = True
        Me.lblValorCartaoCredito.Location = New System.Drawing.Point(311, 17)
        Me.lblValorCartaoCredito.Name = "lblValorCartaoCredito"
        Me.lblValorCartaoCredito.Size = New System.Drawing.Size(35, 14)
        Me.lblValorCartaoCredito.TabIndex = 5
        Me.lblValorCartaoCredito.Text = "Valor:"
        '
        'lblNumeroParcelaCartaoCredito
        '
        Me.lblNumeroParcelaCartaoCredito.AutoSize = True
        Me.lblNumeroParcelaCartaoCredito.Location = New System.Drawing.Point(415, 17)
        Me.lblNumeroParcelaCartaoCredito.Name = "lblNumeroParcelaCartaoCredito"
        Me.lblNumeroParcelaCartaoCredito.Size = New System.Drawing.Size(67, 14)
        Me.lblNumeroParcelaCartaoCredito.TabIndex = 7
        Me.lblNumeroParcelaCartaoCredito.Text = "Nº Parcelas:"
        '
        'cboCartaoCredito
        '
        Me.cboCartaoCredito.AutoSize = False
        Me.cboCartaoCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCartaoCredito.Location = New System.Drawing.Point(9, 34)
        Me.cboCartaoCredito.Name = "cboCartaoCredito"
        Me.cboCartaoCredito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCartaoCredito.Size = New System.Drawing.Size(202, 20)
        Me.cboCartaoCredito.TabIndex = 2
        '
        'lblCartaoCredito
        '
        Me.lblCartaoCredito.AutoSize = True
        Me.lblCartaoCredito.Location = New System.Drawing.Point(25, 17)
        Me.lblCartaoCredito.Name = "lblCartaoCredito"
        Me.lblCartaoCredito.Size = New System.Drawing.Size(91, 14)
        Me.lblCartaoCredito.TabIndex = 1
        Me.lblCartaoCredito.Text = "Cartão de Crédito"
        '
        'lblDataPagamentoCartaoCredito
        '
        Me.lblDataPagamentoCartaoCredito.AutoSize = True
        Me.lblDataPagamentoCartaoCredito.Location = New System.Drawing.Point(214, 17)
        Me.lblDataPagamentoCartaoCredito.Name = "lblDataPagamentoCartaoCredito"
        Me.lblDataPagamentoCartaoCredito.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoCartaoCredito.TabIndex = 3
        Me.lblDataPagamentoCartaoCredito.Text = "Data Pgto.:"
        '
        'txtNumeroParcelaCartaoCredito
        '
        Me.txtNumeroParcelaCartaoCredito.DecimalDigits = 0
        Me.txtNumeroParcelaCartaoCredito.Location = New System.Drawing.Point(418, 34)
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
        Me.dtpDataPagamentoCartaoCredito.Location = New System.Drawing.Point(217, 34)
        Me.dtpDataPagamentoCartaoCredito.Name = "dtpDataPagamentoCartaoCredito"
        Me.dtpDataPagamentoCartaoCredito.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoCartaoCredito.TabIndex = 4
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
        Me.grpBoleto.Location = New System.Drawing.Point(283, 1)
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
        Me.dtpDataPagamentoBoleto.TabIndex = 9
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
        Me.grpCheque.Location = New System.Drawing.Point(283, 1)
        Me.grpCheque.Name = "grpCheque"
        Me.grpCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCheque.Size = New System.Drawing.Size(505, 104)
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
        Me.dtpDataCompensacaoCheque.TabIndex = 9
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
        Me.dtpDataPagamentoCheque.TabIndex = 1
        '
        'lblDataCompensacaoCheque
        '
        Me.lblDataCompensacaoCheque.AutoSize = True
        Me.lblDataCompensacaoCheque.Location = New System.Drawing.Point(213, 57)
        Me.lblDataCompensacaoCheque.Name = "lblDataCompensacaoCheque"
        Me.lblDataCompensacaoCheque.Size = New System.Drawing.Size(88, 14)
        Me.lblDataCompensacaoCheque.TabIndex = 8
        Me.lblDataCompensacaoCheque.Text = "Pré-datado para:"
        '
        'txtValorCheque
        '
        Me.txtValorCheque.Location = New System.Drawing.Point(9, 74)
        Me.txtValorCheque.Name = "txtValorCheque"
        Me.txtValorCheque.Size = New System.Drawing.Size(104, 20)
        Me.txtValorCheque.TabIndex = 3
        Me.txtValorCheque.Text = "0,00"
        Me.txtValorCheque.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCheque
        '
        Me.lblValorCheque.AutoSize = True
        Me.lblValorCheque.Location = New System.Drawing.Point(6, 57)
        Me.lblValorCheque.Name = "lblValorCheque"
        Me.lblValorCheque.Size = New System.Drawing.Size(75, 14)
        Me.lblValorCheque.TabIndex = 10
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
        Me.txtNumeroDocumentoCheque.TabIndex = 0
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
        Me.lblPreDatadoCheque.TabIndex = 6
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
        Me.cboPreDatadoCheque.TabIndex = 4
        '
        'txtFavorecidoCheque
        '
        Me.txtFavorecidoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFavorecidoCheque.Location = New System.Drawing.Point(216, 34)
        Me.txtFavorecidoCheque.MaxLength = 100
        Me.txtFavorecidoCheque.Name = "txtFavorecidoCheque"
        Me.txtFavorecidoCheque.Size = New System.Drawing.Size(289, 20)
        Me.txtFavorecidoCheque.TabIndex = 2
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
        Me.grpChequeTerceiro.Location = New System.Drawing.Point(283, 1)
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
        'grpBoletoGuia
        '
        Me.grpBoletoGuia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBoletoGuia.BackColor = System.Drawing.Color.Transparent
        Me.grpBoletoGuia.BorderColor = System.Drawing.Color.Transparent
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia8)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia7)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia6)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia5)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia4)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia3)
        Me.grpBoletoGuia.Controls.Add(Me.dtpDataPagamentoBoletoGuia)
        Me.grpBoletoGuia.Controls.Add(Me.txtValorBoletoGuia)
        Me.grpBoletoGuia.Controls.Add(Me.Label6)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia2)
        Me.grpBoletoGuia.Controls.Add(Me.txtNumeroBoletoGuia1)
        Me.grpBoletoGuia.Controls.Add(Me.Label7)
        Me.grpBoletoGuia.Controls.Add(Me.lblBancoBoletoGuia)
        Me.grpBoletoGuia.Location = New System.Drawing.Point(283, 1)
        Me.grpBoletoGuia.Name = "grpBoletoGuia"
        Me.grpBoletoGuia.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBoletoGuia.Size = New System.Drawing.Size(505, 104)
        Me.grpBoletoGuia.TabIndex = 3
        Me.grpBoletoGuia.Visible = False
        Me.grpBoletoGuia.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroBoletoGuia8
        '
        Me.txtNumeroBoletoGuia8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia8.Location = New System.Drawing.Point(434, 21)
        Me.txtNumeroBoletoGuia8.MaxLength = 1
        Me.txtNumeroBoletoGuia8.Name = "txtNumeroBoletoGuia8"
        Me.txtNumeroBoletoGuia8.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoletoGuia8.TabIndex = 8
        '
        'txtNumeroBoletoGuia7
        '
        Me.txtNumeroBoletoGuia7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia7.Location = New System.Drawing.Point(351, 21)
        Me.txtNumeroBoletoGuia7.MaxLength = 11
        Me.txtNumeroBoletoGuia7.Name = "txtNumeroBoletoGuia7"
        Me.txtNumeroBoletoGuia7.Size = New System.Drawing.Size(77, 20)
        Me.txtNumeroBoletoGuia7.TabIndex = 7
        '
        'txtNumeroBoletoGuia6
        '
        Me.txtNumeroBoletoGuia6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia6.Location = New System.Drawing.Point(324, 21)
        Me.txtNumeroBoletoGuia6.MaxLength = 1
        Me.txtNumeroBoletoGuia6.Name = "txtNumeroBoletoGuia6"
        Me.txtNumeroBoletoGuia6.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoletoGuia6.TabIndex = 6
        '
        'txtNumeroBoletoGuia5
        '
        Me.txtNumeroBoletoGuia5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia5.Location = New System.Drawing.Point(241, 21)
        Me.txtNumeroBoletoGuia5.MaxLength = 11
        Me.txtNumeroBoletoGuia5.Name = "txtNumeroBoletoGuia5"
        Me.txtNumeroBoletoGuia5.Size = New System.Drawing.Size(77, 20)
        Me.txtNumeroBoletoGuia5.TabIndex = 5
        '
        'txtNumeroBoletoGuia4
        '
        Me.txtNumeroBoletoGuia4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia4.Location = New System.Drawing.Point(214, 21)
        Me.txtNumeroBoletoGuia4.MaxLength = 1
        Me.txtNumeroBoletoGuia4.Name = "txtNumeroBoletoGuia4"
        Me.txtNumeroBoletoGuia4.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoletoGuia4.TabIndex = 4
        '
        'txtNumeroBoletoGuia3
        '
        Me.txtNumeroBoletoGuia3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia3.Location = New System.Drawing.Point(131, 21)
        Me.txtNumeroBoletoGuia3.MaxLength = 11
        Me.txtNumeroBoletoGuia3.Name = "txtNumeroBoletoGuia3"
        Me.txtNumeroBoletoGuia3.Size = New System.Drawing.Size(77, 20)
        Me.txtNumeroBoletoGuia3.TabIndex = 3
        '
        'dtpDataPagamentoBoletoGuia
        '
        '
        '
        '
        Me.dtpDataPagamentoBoletoGuia.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoBoletoGuia.Location = New System.Drawing.Point(21, 61)
        Me.dtpDataPagamentoBoletoGuia.Name = "dtpDataPagamentoBoletoGuia"
        Me.dtpDataPagamentoBoletoGuia.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoBoletoGuia.TabIndex = 10
        '
        'txtValorBoletoGuia
        '
        Me.txtValorBoletoGuia.Location = New System.Drawing.Point(118, 61)
        Me.txtValorBoletoGuia.Name = "txtValorBoletoGuia"
        Me.txtValorBoletoGuia.Size = New System.Drawing.Size(89, 20)
        Me.txtValorBoletoGuia.TabIndex = 12
        Me.txtValorBoletoGuia.Text = "0,00"
        Me.txtValorBoletoGuia.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Data Pgto.:"
        '
        'txtNumeroBoletoGuia2
        '
        Me.txtNumeroBoletoGuia2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia2.Location = New System.Drawing.Point(104, 21)
        Me.txtNumeroBoletoGuia2.MaxLength = 1
        Me.txtNumeroBoletoGuia2.Name = "txtNumeroBoletoGuia2"
        Me.txtNumeroBoletoGuia2.Size = New System.Drawing.Size(21, 20)
        Me.txtNumeroBoletoGuia2.TabIndex = 2
        '
        'txtNumeroBoletoGuia1
        '
        Me.txtNumeroBoletoGuia1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroBoletoGuia1.Location = New System.Drawing.Point(21, 21)
        Me.txtNumeroBoletoGuia1.MaxLength = 11
        Me.txtNumeroBoletoGuia1.Name = "txtNumeroBoletoGuia1"
        Me.txtNumeroBoletoGuia1.Size = New System.Drawing.Size(77, 20)
        Me.txtNumeroBoletoGuia1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(114, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Valor Boleto:"
        '
        'lblBancoBoletoGuia
        '
        Me.lblBancoBoletoGuia.AutoSize = True
        Me.lblBancoBoletoGuia.Location = New System.Drawing.Point(17, 4)
        Me.lblBancoBoletoGuia.Name = "lblBancoBoletoGuia"
        Me.lblBancoBoletoGuia.Size = New System.Drawing.Size(80, 14)
        Me.lblBancoBoletoGuia.TabIndex = 0
        Me.lblBancoBoletoGuia.Text = "Nº Boleto Guia:"
        '
        'usrFinDespesaPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinDespesaPagamento"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picParcelaVencimentoFuturo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picParcelaVencimentoAtrasado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpValorSelecionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValorSelecionado.ResumeLayout(False)
        Me.grpValorSelecionado.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        CType(Me.grdPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPagamento.ResumeLayout(False)
        Me.grpPagamento.PerformLayout()
        CType(Me.grpSaldoFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSaldoFornecedor.ResumeLayout(False)
        Me.grpSaldoFornecedor.PerformLayout()
        CType(Me.grpChequePerforma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChequePerforma.ResumeLayout(False)
        Me.grpChequePerforma.PerformLayout()
        CType(Me.grpOutros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutros.ResumeLayout(False)
        Me.grpOutros.PerformLayout()
        CType(Me.grpOutrosSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutrosSimples.ResumeLayout(False)
        Me.grpOutrosSimples.PerformLayout()
        CType(Me.grpCartaoCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCartaoCredito.ResumeLayout(False)
        Me.grpCartaoCredito.PerformLayout()
        CType(Me.grpBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoleto.ResumeLayout(False)
        Me.grpBoleto.PerformLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCheque.ResumeLayout(False)
        Me.grpCheque.PerformLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChequeTerceiro.ResumeLayout(False)
        Me.grpChequeTerceiro.PerformLayout()
        CType(Me.grpBoletoGuia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoletoGuia.ResumeLayout(False)
        Me.grpBoletoGuia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnPagar1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpValorSelecionado As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorTitulo As System.Windows.Forms.Label
    Friend WithEvents lblLabelValorTitulo As System.Windows.Forms.Label
    Friend WithEvents txtValorFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFiltro As System.Windows.Forms.Label
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grdParcela As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControle2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnPagar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdPagamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpPagamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirPagamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirPagamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarContaBancaria As System.Windows.Forms.Button
    Friend WithEvents lblTipoDocumentoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
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
    Friend WithEvents dtpDataVencimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblParcelaVencimentoFuturo As System.Windows.Forms.Label
    Friend WithEvents picParcelaVencimentoFuturo As System.Windows.Forms.PictureBox
    Friend WithEvents lblParcelaVencimentoAtrasado As System.Windows.Forms.Label
    Friend WithEvents picParcelaVencimentoAtrasado As System.Windows.Forms.PictureBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpCartaoCredito As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroParcelaCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents cboCartaoCredito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcelaCartaoCredito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpDataPagamentoCartaoCredito As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorCartaoCredito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarCartaoCredito As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridParcela As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblAdiantamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAdiantamentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridParcela As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridParcela As System.Windows.Forms.Button
    Friend WithEvents grpBoletoGuia As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroBoletoGuia7 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia6 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia5 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia4 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia3 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataPagamentoBoletoGuia As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorBoletoGuia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroBoletoGuia2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroBoletoGuia1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblBancoBoletoGuia As System.Windows.Forms.Label
    Friend WithEvents txtNumeroBoletoGuia8 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpChequePerforma As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroCheque As System.Windows.Forms.Label
    Friend WithEvents dtpDataCompensacaoChequePerforma As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboCheque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataPagamentoChequePerforma As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCompensacaoChequePerforma As System.Windows.Forms.Label
    Friend WithEvents txtValorChequePerforma As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorChequePerforma As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoChequePerforma As System.Windows.Forms.Label
    Friend WithEvents lblPreDatadoChequePerforma As System.Windows.Forms.Label
    Friend WithEvents cboPreDatadoChequePerforma As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtFavorecidoChequePerforma As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFavorecidoChequePerforma As System.Windows.Forms.Label
    Friend WithEvents btnAtualizar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAtualizarCheque As System.Windows.Forms.Button
    Friend WithEvents grpSaldoFornecedor As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoSaldoFornecedor As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorSaldoFornecedor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorSaldoFornecedor As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoSaldoFornecedor As System.Windows.Forms.Label

End Class
