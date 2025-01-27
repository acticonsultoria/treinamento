<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinImportacaoExtratoCadastrarDocumento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinImportacaoExtratoCadastrarDocumento))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosDocumento = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.btnProcurarCentroCusto = New System.Windows.Forms.Button()
        Me.cboCentroCusto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroCusto = New System.Windows.Forms.Label()
        Me.txtDescritivo = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescritivo = New System.Windows.Forms.Label()
        Me.cboBancoContaTransferencia = New Janus.Windows.EditControls.UIComboBox()
        Me.lblBancoContaTransferencia = New System.Windows.Forms.Label()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarTipoDocumento = New System.Windows.Forms.Button()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarFornecedor = New System.Windows.Forms.Button()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtTipo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpDadosDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosDocumento.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(986, 343)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpDadosDocumento)
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(984, 320)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Documento"
        '
        'grpDadosDocumento
        '
        Me.grpDadosDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosDocumento.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosDocumento.Controls.Add(Me.cboContaContabil)
        Me.grpDadosDocumento.Controls.Add(Me.lblContaContabil)
        Me.grpDadosDocumento.Controls.Add(Me.btnProcurarCentroCusto)
        Me.grpDadosDocumento.Controls.Add(Me.cboCentroCusto)
        Me.grpDadosDocumento.Controls.Add(Me.lblCentroCusto)
        Me.grpDadosDocumento.Controls.Add(Me.txtDescritivo)
        Me.grpDadosDocumento.Controls.Add(Me.lblDescritivo)
        Me.grpDadosDocumento.Controls.Add(Me.cboBancoContaTransferencia)
        Me.grpDadosDocumento.Controls.Add(Me.lblBancoContaTransferencia)
        Me.grpDadosDocumento.Controls.Add(Me.lblTipoDocumento)
        Me.grpDadosDocumento.Controls.Add(Me.cboTipoDocumento)
        Me.grpDadosDocumento.Controls.Add(Me.btnCadastrarTipoDocumento)
        Me.grpDadosDocumento.Controls.Add(Me.cboFornecedor)
        Me.grpDadosDocumento.Controls.Add(Me.btnCadastrarFornecedor)
        Me.grpDadosDocumento.Controls.Add(Me.lblFornecedor)
        Me.grpDadosDocumento.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpDadosDocumento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosDocumento.Location = New System.Drawing.Point(8, 75)
        Me.grpDadosDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosDocumento.Name = "grpDadosDocumento"
        Me.grpDadosDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosDocumento.Size = New System.Drawing.Size(968, 178)
        Me.grpDadosDocumento.TabIndex = 1
        Me.grpDadosDocumento.Text = "Dados do Documento"
        Me.grpDadosDocumento.VisualStyleManager = Me.vsmMain
        '
        'cboContaContabil
        '
        Me.cboContaContabil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(808, 37)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(145, 20)
        Me.cboContaContabil.TabIndex = 15
        '
        'lblContaContabil
        '
        Me.lblContaContabil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(805, 20)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 14
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'btnProcurarCentroCusto
        '
        Me.btnProcurarCentroCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCentroCusto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroCusto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroCusto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroCusto.Location = New System.Drawing.Point(785, 19)
        Me.btnProcurarCentroCusto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroCusto.Name = "btnProcurarCentroCusto"
        Me.btnProcurarCentroCusto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroCusto.TabIndex = 11
        Me.btnProcurarCentroCusto.TabStop = False
        Me.btnProcurarCentroCusto.UseVisualStyleBackColor = True
        '
        'cboCentroCusto
        '
        Me.cboCentroCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroCusto.AutoSize = False
        Me.cboCentroCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroCusto.Location = New System.Drawing.Point(600, 37)
        Me.cboCentroCusto.Name = "cboCentroCusto"
        Me.cboCentroCusto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroCusto.Size = New System.Drawing.Size(202, 20)
        Me.cboCentroCusto.TabIndex = 10
        '
        'lblCentroCusto
        '
        Me.lblCentroCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCentroCusto.AutoSize = True
        Me.lblCentroCusto.Location = New System.Drawing.Point(597, 20)
        Me.lblCentroCusto.Name = "lblCentroCusto"
        Me.lblCentroCusto.Size = New System.Drawing.Size(88, 14)
        Me.lblCentroCusto.TabIndex = 9
        Me.lblCentroCusto.Text = "Centro de Custo:"
        '
        'txtDescritivo
        '
        Me.txtDescritivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescritivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivo.Location = New System.Drawing.Point(6, 80)
        Me.txtDescritivo.MaxLength = 500
        Me.txtDescritivo.Multiline = True
        Me.txtDescritivo.Name = "txtDescritivo"
        Me.txtDescritivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescritivo.Size = New System.Drawing.Size(947, 87)
        Me.txtDescritivo.TabIndex = 13
        '
        'lblDescritivo
        '
        Me.lblDescritivo.AutoSize = True
        Me.lblDescritivo.Location = New System.Drawing.Point(6, 63)
        Me.lblDescritivo.Name = "lblDescritivo"
        Me.lblDescritivo.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivo.TabIndex = 12
        Me.lblDescritivo.Text = "Descritivo:"
        '
        'cboBancoContaTransferencia
        '
        Me.cboBancoContaTransferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBancoContaTransferencia.AutoSize = False
        Me.cboBancoContaTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboBancoContaTransferencia.Location = New System.Drawing.Point(377, 37)
        Me.cboBancoContaTransferencia.Name = "cboBancoContaTransferencia"
        Me.cboBancoContaTransferencia.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBancoContaTransferencia.Size = New System.Drawing.Size(217, 20)
        Me.cboBancoContaTransferencia.TabIndex = 8
        '
        'lblBancoContaTransferencia
        '
        Me.lblBancoContaTransferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBancoContaTransferencia.AutoSize = True
        Me.lblBancoContaTransferencia.Location = New System.Drawing.Point(374, 20)
        Me.lblBancoContaTransferencia.Name = "lblBancoContaTransferencia"
        Me.lblBancoContaTransferencia.Size = New System.Drawing.Size(170, 14)
        Me.lblBancoContaTransferencia.TabIndex = 7
        Me.lblBancoContaTransferencia.Text = "Conta Bancária de Transferência:"
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(22, 20)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(102, 14)
        Me.lblTipoDocumento.TabIndex = 1
        Me.lblTipoDocumento.Text = "Tipo de Documento:"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoSize = False
        Me.cboTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumento.Location = New System.Drawing.Point(6, 37)
        Me.cboTipoDocumento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumento.Size = New System.Drawing.Size(133, 20)
        Me.cboTipoDocumento.TabIndex = 2
        '
        'btnCadastrarTipoDocumento
        '
        Me.btnCadastrarTipoDocumento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoDocumento.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarTipoDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoDocumento.Location = New System.Drawing.Point(6, 21)
        Me.btnCadastrarTipoDocumento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoDocumento.Name = "btnCadastrarTipoDocumento"
        Me.btnCadastrarTipoDocumento.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoDocumento.TabIndex = 0
        Me.btnCadastrarTipoDocumento.TabStop = False
        Me.btnCadastrarTipoDocumento.UseVisualStyleBackColor = True
        '
        'cboFornecedor
        '
        Me.cboFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedor.AutoSize = False
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedor.Location = New System.Drawing.Point(145, 37)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedor.Size = New System.Drawing.Size(226, 20)
        Me.cboFornecedor.TabIndex = 5
        '
        'btnCadastrarFornecedor
        '
        Me.btnCadastrarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarFornecedor.Location = New System.Drawing.Point(145, 21)
        Me.btnCadastrarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor"
        Me.btnCadastrarFornecedor.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarFornecedor.TabIndex = 3
        Me.btnCadastrarFornecedor.TabStop = False
        Me.btnCadastrarFornecedor.UseVisualStyleBackColor = True
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(161, 20)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(107, 14)
        Me.lblFornecedor.TabIndex = 4
        Me.lblFornecedor.Text = "Cliente / Fornecedor:"
        '
        'btnProcurarFornecedor
        '
        Me.btnProcurarFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(354, 19)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedor.TabIndex = 6
        Me.btnProcurarFornecedor.TabStop = False
        Me.btnProcurarFornecedor.UseVisualStyleBackColor = True
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblTipo)
        Me.grpDados.Controls.Add(Me.txtTipo)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.lblValor)
        Me.grpDados.Controls.Add(Me.txtDataEmissao)
        Me.grpDados.Controls.Add(Me.txtValor)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblNumeroDocumento)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.txtNumeroDocumento)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(968, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados do Arquivo"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(772, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 6
        Me.lblTipo.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(775, 34)
        Me.txtTipo.MaxLength = 250
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(89, 20)
        Me.txtTipo.TabIndex = 7
        Me.txtTipo.TabStop = False
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(690, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "Data:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(867, 17)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 8
        Me.lblValor.Text = "Valor:"
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Location = New System.Drawing.Point(693, 34)
        Me.txtDataEmissao.MaxLength = 250
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.ReadOnly = True
        Me.txtDataEmissao.Size = New System.Drawing.Size(76, 20)
        Me.txtDataEmissao.TabIndex = 5
        Me.txtDataEmissao.TabStop = False
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Location = New System.Drawing.Point(870, 34)
        Me.txtValor.MaxLength = 250
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(83, 20)
        Me.txtValor.TabIndex = 9
        Me.txtValor.TabStop = False
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(113, 34)
        Me.txtDescricao.MaxLength = 250
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(574, 20)
        Me.txtDescricao.TabIndex = 3
        Me.txtDescricao.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(3, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(113, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(6, 34)
        Me.txtNumeroDocumento.MaxLength = 250
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(101, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 260)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(968, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(771, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Cadastrar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(868, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFinImportacaoExtratoCadastrarDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 358)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinImportacaoExtratoCadastrarDocumento"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importação Extrato - Documento Pagamento"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpDadosDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosDocumento.ResumeLayout(False)
        Me.grpDadosDocumento.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTipo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents grpDadosDocumento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarTipoDocumento As System.Windows.Forms.Button
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarFornecedor As System.Windows.Forms.Button
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboBancoContaTransferencia As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblBancoContaTransferencia As System.Windows.Forms.Label
    Friend WithEvents txtDescritivo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescritivo As System.Windows.Forms.Label
    Friend WithEvents cboCentroCusto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroCusto As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCentroCusto As System.Windows.Forms.Button
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
End Class
