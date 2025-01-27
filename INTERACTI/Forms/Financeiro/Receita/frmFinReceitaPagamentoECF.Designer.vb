<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinReceitaPagamentoECF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinReceitaPagamentoECF))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarContaBancaria = New System.Windows.Forms.Button()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnPagar = New Janus.Windows.EditControls.UIButton()
        Me.grpPagamento = New Janus.Windows.EditControls.UIGroupBox()
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
        Me.txtBancoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBancoChequeTerceiro = New System.Windows.Forms.Label()
        Me.lblDataPagamentoChequeTerceiro = New System.Windows.Forms.Label()
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
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPagamento.SuspendLayout()
        CType(Me.grpOutros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutros.SuspendLayout()
        CType(Me.grpOutrosSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutrosSimples.SuspendLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChequeTerceiro.SuspendLayout()
        CType(Me.grpBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoleto.SuspendLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCheque.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(533, 266)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.UiGroupBox1)
        Me.pagTabela.Controls.Add(Me.UiGroupBox2)
        Me.pagTabela.Controls.Add(Me.grpPagamento)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(531, 243)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados do Pagamento"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnCadastrarContaBancaria)
        Me.UiGroupBox1.Controls.Add(Me.lblContaBancaria)
        Me.UiGroupBox1.Controls.Add(Me.cboContaBancaria)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(514, 67)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Dados Bancários"
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarContaBancaria
        '
        Me.btnCadastrarContaBancaria.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaBancaria.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaBancaria.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarContaBancaria.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaBancaria.Name = "btnCadastrarContaBancaria"
        Me.btnCadastrarContaBancaria.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaBancaria.TabIndex = 0
        Me.btnCadastrarContaBancaria.TabStop = False
        Me.btnCadastrarContaBancaria.UseVisualStyleBackColor = True
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaBancaria.Location = New System.Drawing.Point(25, 20)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 1
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.AutoSize = False
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancaria.Location = New System.Drawing.Point(9, 37)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancaria.Size = New System.Drawing.Size(496, 20)
        Me.cboContaBancaria.TabIndex = 2
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnSair)
        Me.UiGroupBox2.Controls.Add(Me.btnPagar)
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 183)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(514, 51)
        Me.UiGroupBox2.TabIndex = 2
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(414, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPagar
        '
        Me.btnPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar.Image = Global.INTERACTI.My.Resources.dinheiro2
        Me.btnPagar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar.Location = New System.Drawing.Point(317, 17)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar.Size = New System.Drawing.Size(91, 23)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpPagamento
        '
        Me.grpPagamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPagamento.BackColor = System.Drawing.Color.Transparent
        Me.grpPagamento.Controls.Add(Me.grpOutros)
        Me.grpPagamento.Controls.Add(Me.grpOutrosSimples)
        Me.grpPagamento.Controls.Add(Me.grpChequeTerceiro)
        Me.grpPagamento.Controls.Add(Me.grpBoleto)
        Me.grpPagamento.Controls.Add(Me.grpCheque)
        Me.grpPagamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPagamento.Location = New System.Drawing.Point(8, 73)
        Me.grpPagamento.Name = "grpPagamento"
        Me.grpPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPagamento.Size = New System.Drawing.Size(514, 107)
        Me.grpPagamento.TabIndex = 1
        Me.grpPagamento.VisualStyleManager = Me.vsmMain
        '
        'grpOutros
        '
        Me.grpOutros.BackColor = System.Drawing.Color.Transparent
        Me.grpOutros.BorderColor = System.Drawing.Color.Transparent
        Me.grpOutros.Controls.Add(Me.dtpDataPagamentoOutros)
        Me.grpOutros.Controls.Add(Me.txtValorOutros)
        Me.grpOutros.Controls.Add(Me.lblValorOutros)
        Me.grpOutros.Controls.Add(Me.txtNumeroDocumentoOutros)
        Me.grpOutros.Controls.Add(Me.lblNumeroDocumentoOutros)
        Me.grpOutros.Controls.Add(Me.lblDataPagamentoOutros)
        Me.grpOutros.Location = New System.Drawing.Point(0, 0)
        Me.grpOutros.Name = "grpOutros"
        Me.grpOutros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOutros.Size = New System.Drawing.Size(505, 64)
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
        'grpOutrosSimples
        '
        Me.grpOutrosSimples.BackColor = System.Drawing.Color.Transparent
        Me.grpOutrosSimples.BorderColor = System.Drawing.Color.Transparent
        Me.grpOutrosSimples.Controls.Add(Me.dtpDataPagamentoOutrosSimples)
        Me.grpOutrosSimples.Controls.Add(Me.txtValorOutrosSimples)
        Me.grpOutrosSimples.Controls.Add(Me.lblValorOutrosSimples)
        Me.grpOutrosSimples.Controls.Add(Me.lblDataPagamentoOutrosSimples)
        Me.grpOutrosSimples.Location = New System.Drawing.Point(0, 0)
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
        Me.dtpDataPagamentoOutrosSimples.TabIndex = 2
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
        'grpChequeTerceiro
        '
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
        Me.grpChequeTerceiro.Controls.Add(Me.txtBancoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblBancoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblDataPagamentoChequeTerceiro)
        Me.grpChequeTerceiro.Location = New System.Drawing.Point(0, 0)
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
        Me.txtValorChequeTerceiro.Location = New System.Drawing.Point(216, 74)
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
        Me.lblValorChequeTerceiro.Location = New System.Drawing.Point(213, 57)
        Me.lblValorChequeTerceiro.Name = "lblValorChequeTerceiro"
        Me.lblValorChequeTerceiro.Size = New System.Drawing.Size(75, 14)
        Me.lblValorChequeTerceiro.TabIndex = 12
        Me.lblValorChequeTerceiro.Text = "Valor Cheque:"
        '
        'txtPreDatadoChequeTerceiro
        '
        Me.txtPreDatadoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPreDatadoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreDatadoChequeTerceiro.Location = New System.Drawing.Point(119, 74)
        Me.txtPreDatadoChequeTerceiro.MaxLength = 20
        Me.txtPreDatadoChequeTerceiro.Name = "txtPreDatadoChequeTerceiro"
        Me.txtPreDatadoChequeTerceiro.ReadOnly = True
        Me.txtPreDatadoChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.txtPreDatadoChequeTerceiro.TabIndex = 8
        Me.txtPreDatadoChequeTerceiro.TabStop = False
        '
        'lblPreDatadoChequeTerceiro
        '
        Me.lblPreDatadoChequeTerceiro.AutoSize = True
        Me.lblPreDatadoChequeTerceiro.Location = New System.Drawing.Point(116, 57)
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
        Me.txtDataRecebimentoChequeTerceiro.Location = New System.Drawing.Point(9, 74)
        Me.txtDataRecebimentoChequeTerceiro.MaxLength = 20
        Me.txtDataRecebimentoChequeTerceiro.Name = "txtDataRecebimentoChequeTerceiro"
        Me.txtDataRecebimentoChequeTerceiro.ReadOnly = True
        Me.txtDataRecebimentoChequeTerceiro.Size = New System.Drawing.Size(104, 20)
        Me.txtDataRecebimentoChequeTerceiro.TabIndex = 7
        Me.txtDataRecebimentoChequeTerceiro.TabStop = False
        '
        'lblDataRecebimentoChequeTerceiro
        '
        Me.lblDataRecebimentoChequeTerceiro.AutoSize = True
        Me.lblDataRecebimentoChequeTerceiro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataRecebimentoChequeTerceiro.Name = "lblDataRecebimentoChequeTerceiro"
        Me.lblDataRecebimentoChequeTerceiro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataRecebimentoChequeTerceiro.TabIndex = 8
        Me.lblDataRecebimentoChequeTerceiro.Text = "Recebido em:"
        '
        'txtBancoChequeTerceiro
        '
        Me.txtBancoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBancoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoChequeTerceiro.Location = New System.Drawing.Point(216, 34)
        Me.txtBancoChequeTerceiro.MaxLength = 20
        Me.txtBancoChequeTerceiro.Name = "txtBancoChequeTerceiro"
        Me.txtBancoChequeTerceiro.ReadOnly = True
        Me.txtBancoChequeTerceiro.Size = New System.Drawing.Size(289, 20)
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
        'grpBoleto
        '
        Me.grpBoleto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.grpBoleto.Location = New System.Drawing.Point(0, 0)
        Me.grpBoleto.Name = "grpBoleto"
        Me.grpBoleto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBoleto.Size = New System.Drawing.Size(505, 107)
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
        Me.dtpDataPagamentoBoleto.Location = New System.Drawing.Point(319, 74)
        Me.dtpDataPagamentoBoleto.Name = "dtpDataPagamentoBoleto"
        Me.dtpDataPagamentoBoleto.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoBoleto.TabIndex = 14
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
        Me.lblDataPagamentoBoleto.TabIndex = 9
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
        Me.grpCheque.Location = New System.Drawing.Point(0, 0)
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
        Me.dtpDataCompensacaoCheque.TabIndex = 5
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
        'frmFinReceitaPagamentoECF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(547, 281)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinReceitaPagamentoECF"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receita - Pagamento"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPagamento.ResumeLayout(False)
        CType(Me.grpOutros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutros.ResumeLayout(False)
        Me.grpOutros.PerformLayout()
        CType(Me.grpOutrosSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutrosSimples.ResumeLayout(False)
        Me.grpOutrosSimples.PerformLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChequeTerceiro.ResumeLayout(False)
        Me.grpChequeTerceiro.PerformLayout()
        CType(Me.grpBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoleto.ResumeLayout(False)
        Me.grpBoleto.PerformLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCheque.ResumeLayout(False)
        Me.grpCheque.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpPagamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpOutros As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorOutros As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOutros As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoOutros As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoOutros As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoOutros As System.Windows.Forms.Label
    Friend WithEvents grpBoleto As Janus.Windows.EditControls.UIGroupBox
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
    Friend WithEvents grpOutrosSimples As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorOutrosSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOutrosSimples As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoOutrosSimples As System.Windows.Forms.Label
    Friend WithEvents grpCheque As Janus.Windows.EditControls.UIGroupBox
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
    Friend WithEvents txtValorChequeTerceiro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtPreDatadoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPreDatadoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents cboNumeroDocumentoChequeTerceiro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroDocumentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtDataRecebimentoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataRecebimentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtBancoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBancoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnPagar As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataPagamentoChequeTerceiro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoBoleto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoOutros As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoOutrosSimples As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataCompensacaoCheque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoCheque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarContaBancaria As System.Windows.Forms.Button
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
End Class
