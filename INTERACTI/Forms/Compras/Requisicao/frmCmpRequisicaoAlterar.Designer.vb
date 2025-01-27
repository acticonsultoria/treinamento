<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpRequisicaoAlterar
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
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpRequisicaoAlterar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtUnidadeMedidaDimensao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDimensao = New System.Windows.Forms.Label()
        Me.txtDimensao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkDimensao = New Janus.Windows.EditControls.UICheckBox()
        Me.chkUnidadeMedida = New Janus.Windows.EditControls.UICheckBox()
        Me.chkAltura = New Janus.Windows.EditControls.UICheckBox()
        Me.chkLargura = New Janus.Windows.EditControls.UICheckBox()
        Me.chkComprimento = New Janus.Windows.EditControls.UICheckBox()
        Me.txtNewDimensao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboNewUnidadeMedidaDimensao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNewAltura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtNewComprimento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtNewLargura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblUnidadeMedidaDimensao = New System.Windows.Forms.Label()
        Me.txtAltura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtComprimento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.lblComprimento = New System.Windows.Forms.Label()
        Me.txtLargura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLargura = New System.Windows.Forms.Label()
        Me.txtQuantidadeAntiga = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblQuantidadeAntiga = New System.Windows.Forms.Label()
        Me.txtNumeroCotacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroCotacao = New System.Windows.Forms.Label()
        Me.txtNumeroPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.chkQuantidade = New Janus.Windows.EditControls.UICheckBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.chkCodigoProduto = New Janus.Windows.EditControls.UICheckBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtRequisitante = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRequisitante = New System.Windows.Forms.Label()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblSelecione = New System.Windows.Forms.Label()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMotivo.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(836, 277)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(834, 254)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Histórico"
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtUnidadeMedidaDimensao)
        Me.grpMotivo.Controls.Add(Me.lblDimensao)
        Me.grpMotivo.Controls.Add(Me.txtDimensao)
        Me.grpMotivo.Controls.Add(Me.chkDimensao)
        Me.grpMotivo.Controls.Add(Me.chkUnidadeMedida)
        Me.grpMotivo.Controls.Add(Me.chkAltura)
        Me.grpMotivo.Controls.Add(Me.chkLargura)
        Me.grpMotivo.Controls.Add(Me.chkComprimento)
        Me.grpMotivo.Controls.Add(Me.txtNewDimensao)
        Me.grpMotivo.Controls.Add(Me.cboNewUnidadeMedidaDimensao)
        Me.grpMotivo.Controls.Add(Me.txtNewAltura)
        Me.grpMotivo.Controls.Add(Me.txtNewComprimento)
        Me.grpMotivo.Controls.Add(Me.txtNewLargura)
        Me.grpMotivo.Controls.Add(Me.lblUnidadeMedidaDimensao)
        Me.grpMotivo.Controls.Add(Me.txtAltura)
        Me.grpMotivo.Controls.Add(Me.txtComprimento)
        Me.grpMotivo.Controls.Add(Me.lblAltura)
        Me.grpMotivo.Controls.Add(Me.lblComprimento)
        Me.grpMotivo.Controls.Add(Me.txtLargura)
        Me.grpMotivo.Controls.Add(Me.lblLargura)
        Me.grpMotivo.Controls.Add(Me.txtQuantidadeAntiga)
        Me.grpMotivo.Controls.Add(Me.lblQuantidadeAntiga)
        Me.grpMotivo.Controls.Add(Me.txtNumeroCotacao)
        Me.grpMotivo.Controls.Add(Me.lblNumeroCotacao)
        Me.grpMotivo.Controls.Add(Me.txtNumeroPedido)
        Me.grpMotivo.Controls.Add(Me.lblNumeroPedido)
        Me.grpMotivo.Controls.Add(Me.chkQuantidade)
        Me.grpMotivo.Controls.Add(Me.txtQuantidade)
        Me.grpMotivo.Controls.Add(Me.cboCodigoProduto)
        Me.grpMotivo.Controls.Add(Me.chkCodigoProduto)
        Me.grpMotivo.Controls.Add(Me.txtCodigo)
        Me.grpMotivo.Controls.Add(Me.lblCodigo)
        Me.grpMotivo.Controls.Add(Me.txtRequisitante)
        Me.grpMotivo.Controls.Add(Me.lblRequisitante)
        Me.grpMotivo.Controls.Add(Me.txtNumeroRequisicao)
        Me.grpMotivo.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpMotivo.Controls.Add(Me.txtDescricao)
        Me.grpMotivo.Controls.Add(Me.lblDescricao)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(818, 196)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados da Requisição de Compras"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtUnidadeMedidaDimensao
        '
        Me.txtUnidadeMedidaDimensao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUnidadeMedidaDimensao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadeMedidaDimensao.Location = New System.Drawing.Point(501, 77)
        Me.txtUnidadeMedidaDimensao.MaxLength = 20
        Me.txtUnidadeMedidaDimensao.Name = "txtUnidadeMedidaDimensao"
        Me.txtUnidadeMedidaDimensao.Size = New System.Drawing.Size(55, 20)
        Me.txtUnidadeMedidaDimensao.TabIndex = 38
        Me.txtUnidadeMedidaDimensao.TabStop = False
        Me.txtUnidadeMedidaDimensao.Visible = False
        '
        'lblDimensao
        '
        Me.lblDimensao.AutoSize = True
        Me.lblDimensao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDimensao.Location = New System.Drawing.Point(562, 60)
        Me.lblDimensao.Name = "lblDimensao"
        Me.lblDimensao.Size = New System.Drawing.Size(99, 14)
        Me.lblDimensao.TabIndex = 37
        Me.lblDimensao.Text = "Dimensão (Antiga):"
        Me.lblDimensao.Visible = False
        '
        'txtDimensao
        '
        Me.txtDimensao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDimensao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDimensao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDimensao.Location = New System.Drawing.Point(562, 77)
        Me.txtDimensao.MaxLength = 120
        Me.txtDimensao.Name = "txtDimensao"
        Me.txtDimensao.ReadOnly = True
        Me.txtDimensao.Size = New System.Drawing.Size(180, 20)
        Me.txtDimensao.TabIndex = 36
        Me.txtDimensao.TabStop = False
        Me.txtDimensao.Visible = False
        '
        'chkDimensao
        '
        Me.chkDimensao.Location = New System.Drawing.Point(691, 143)
        Me.chkDimensao.Name = "chkDimensao"
        Me.chkDimensao.Size = New System.Drawing.Size(70, 17)
        Me.chkDimensao.TabIndex = 35
        Me.chkDimensao.Text = "Dimensão"
        Me.chkDimensao.Visible = False
        '
        'chkUnidadeMedida
        '
        Me.chkUnidadeMedida.Location = New System.Drawing.Point(615, 143)
        Me.chkUnidadeMedida.Name = "chkUnidadeMedida"
        Me.chkUnidadeMedida.Size = New System.Drawing.Size(70, 17)
        Me.chkUnidadeMedida.TabIndex = 33
        Me.chkUnidadeMedida.Text = "Und. Med:"
        Me.chkUnidadeMedida.Visible = False
        '
        'chkAltura
        '
        Me.chkAltura.Location = New System.Drawing.Point(550, 143)
        Me.chkAltura.Name = "chkAltura"
        Me.chkAltura.Size = New System.Drawing.Size(61, 17)
        Me.chkAltura.TabIndex = 31
        Me.chkAltura.Text = "Altura:"
        Me.chkAltura.Visible = False
        '
        'chkLargura
        '
        Me.chkLargura.Location = New System.Drawing.Point(483, 143)
        Me.chkLargura.Name = "chkLargura"
        Me.chkLargura.Size = New System.Drawing.Size(61, 17)
        Me.chkLargura.TabIndex = 29
        Me.chkLargura.Text = "Largura:"
        Me.chkLargura.Visible = False
        '
        'chkComprimento
        '
        Me.chkComprimento.Location = New System.Drawing.Point(388, 143)
        Me.chkComprimento.Name = "chkComprimento"
        Me.chkComprimento.Size = New System.Drawing.Size(89, 17)
        Me.chkComprimento.TabIndex = 27
        Me.chkComprimento.Text = "Comprimento:"
        Me.chkComprimento.Visible = False
        '
        'txtNewDimensao
        '
        Me.txtNewDimensao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNewDimensao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNewDimensao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewDimensao.Location = New System.Drawing.Point(692, 163)
        Me.txtNewDimensao.MaxLength = 20
        Me.txtNewDimensao.Name = "txtNewDimensao"
        Me.txtNewDimensao.Size = New System.Drawing.Size(120, 20)
        Me.txtNewDimensao.TabIndex = 0
        Me.txtNewDimensao.TabStop = False
        Me.txtNewDimensao.Visible = False
        '
        'cboNewUnidadeMedidaDimensao
        '
        Me.cboNewUnidadeMedidaDimensao.AutoSize = False
        Me.cboNewUnidadeMedidaDimensao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboNewUnidadeMedidaDimensao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = ""
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = ""
        Me.cboNewUnidadeMedidaDimensao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboNewUnidadeMedidaDimensao.Location = New System.Drawing.Point(616, 163)
        Me.cboNewUnidadeMedidaDimensao.Name = "cboNewUnidadeMedidaDimensao"
        Me.cboNewUnidadeMedidaDimensao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNewUnidadeMedidaDimensao.Size = New System.Drawing.Size(70, 20)
        Me.cboNewUnidadeMedidaDimensao.TabIndex = 34
        Me.cboNewUnidadeMedidaDimensao.Visible = False
        '
        'txtNewAltura
        '
        Me.txtNewAltura.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNewAltura.DecimalDigits = 0
        Me.txtNewAltura.Location = New System.Drawing.Point(550, 163)
        Me.txtNewAltura.MaxLength = 100
        Me.txtNewAltura.Name = "txtNewAltura"
        Me.txtNewAltura.ReadOnly = True
        Me.txtNewAltura.Size = New System.Drawing.Size(60, 20)
        Me.txtNewAltura.TabIndex = 32
        Me.txtNewAltura.Text = "0"
        Me.txtNewAltura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNewAltura.Visible = False
        '
        'txtNewComprimento
        '
        Me.txtNewComprimento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNewComprimento.DecimalDigits = 0
        Me.txtNewComprimento.Location = New System.Drawing.Point(388, 163)
        Me.txtNewComprimento.MaxLength = 100
        Me.txtNewComprimento.Name = "txtNewComprimento"
        Me.txtNewComprimento.ReadOnly = True
        Me.txtNewComprimento.Size = New System.Drawing.Size(89, 20)
        Me.txtNewComprimento.TabIndex = 28
        Me.txtNewComprimento.Text = "0"
        Me.txtNewComprimento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNewComprimento.Visible = False
        '
        'txtNewLargura
        '
        Me.txtNewLargura.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNewLargura.DecimalDigits = 0
        Me.txtNewLargura.Location = New System.Drawing.Point(483, 163)
        Me.txtNewLargura.MaxLength = 100
        Me.txtNewLargura.Name = "txtNewLargura"
        Me.txtNewLargura.ReadOnly = True
        Me.txtNewLargura.Size = New System.Drawing.Size(61, 20)
        Me.txtNewLargura.TabIndex = 30
        Me.txtNewLargura.Text = "0"
        Me.txtNewLargura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNewLargura.Visible = False
        '
        'lblUnidadeMedidaDimensao
        '
        Me.lblUnidadeMedidaDimensao.AutoSize = True
        Me.lblUnidadeMedidaDimensao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedidaDimensao.Location = New System.Drawing.Point(498, 60)
        Me.lblUnidadeMedidaDimensao.Name = "lblUnidadeMedidaDimensao"
        Me.lblUnidadeMedidaDimensao.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedidaDimensao.TabIndex = 15
        Me.lblUnidadeMedidaDimensao.Text = "Und. Med.:"
        Me.lblUnidadeMedidaDimensao.Visible = False
        '
        'txtAltura
        '
        Me.txtAltura.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAltura.DecimalDigits = 0
        Me.txtAltura.Location = New System.Drawing.Point(705, 117)
        Me.txtAltura.MaxLength = 100
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.ReadOnly = True
        Me.txtAltura.Size = New System.Drawing.Size(70, 20)
        Me.txtAltura.TabIndex = 14
        Me.txtAltura.Text = "0"
        Me.txtAltura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAltura.Visible = False
        '
        'txtComprimento
        '
        Me.txtComprimento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtComprimento.DecimalDigits = 0
        Me.txtComprimento.Location = New System.Drawing.Point(550, 117)
        Me.txtComprimento.MaxLength = 100
        Me.txtComprimento.Name = "txtComprimento"
        Me.txtComprimento.ReadOnly = True
        Me.txtComprimento.Size = New System.Drawing.Size(70, 20)
        Me.txtComprimento.TabIndex = 10
        Me.txtComprimento.Text = "0"
        Me.txtComprimento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtComprimento.Visible = False
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAltura.Location = New System.Drawing.Point(702, 100)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(39, 14)
        Me.lblAltura.TabIndex = 13
        Me.lblAltura.Text = "Altura:"
        Me.lblAltura.Visible = False
        '
        'lblComprimento
        '
        Me.lblComprimento.AutoSize = True
        Me.lblComprimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComprimento.Location = New System.Drawing.Point(547, 100)
        Me.lblComprimento.Name = "lblComprimento"
        Me.lblComprimento.Size = New System.Drawing.Size(72, 14)
        Me.lblComprimento.TabIndex = 9
        Me.lblComprimento.Text = "Comprimento:"
        Me.lblComprimento.Visible = False
        '
        'txtLargura
        '
        Me.txtLargura.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLargura.DecimalDigits = 0
        Me.txtLargura.Location = New System.Drawing.Point(626, 117)
        Me.txtLargura.MaxLength = 100
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.ReadOnly = True
        Me.txtLargura.Size = New System.Drawing.Size(70, 20)
        Me.txtLargura.TabIndex = 12
        Me.txtLargura.Text = "0"
        Me.txtLargura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLargura.Visible = False
        '
        'lblLargura
        '
        Me.lblLargura.AutoSize = True
        Me.lblLargura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLargura.Location = New System.Drawing.Point(623, 100)
        Me.lblLargura.Name = "lblLargura"
        Me.lblLargura.Size = New System.Drawing.Size(48, 14)
        Me.lblLargura.TabIndex = 11
        Me.lblLargura.Text = "Largura:"
        Me.lblLargura.Visible = False
        '
        'txtQuantidadeAntiga
        '
        Me.txtQuantidadeAntiga.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeAntiga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantidadeAntiga.Location = New System.Drawing.Point(397, 117)
        Me.txtQuantidadeAntiga.MaxLength = 250
        Me.txtQuantidadeAntiga.Name = "txtQuantidadeAntiga"
        Me.txtQuantidadeAntiga.Size = New System.Drawing.Size(127, 20)
        Me.txtQuantidadeAntiga.TabIndex = 22
        Me.txtQuantidadeAntiga.TabStop = False
        '
        'lblQuantidadeAntiga
        '
        Me.lblQuantidadeAntiga.AutoSize = True
        Me.lblQuantidadeAntiga.Location = New System.Drawing.Point(394, 100)
        Me.lblQuantidadeAntiga.Name = "lblQuantidadeAntiga"
        Me.lblQuantidadeAntiga.Size = New System.Drawing.Size(107, 14)
        Me.lblQuantidadeAntiga.TabIndex = 21
        Me.lblQuantidadeAntiga.Text = "Quantidade (Antiga):"
        '
        'txtNumeroCotacao
        '
        Me.txtNumeroCotacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroCotacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCotacao.Location = New System.Drawing.Point(9, 117)
        Me.txtNumeroCotacao.MaxLength = 20
        Me.txtNumeroCotacao.Name = "txtNumeroCotacao"
        Me.txtNumeroCotacao.Size = New System.Drawing.Size(187, 20)
        Me.txtNumeroCotacao.TabIndex = 18
        Me.txtNumeroCotacao.TabStop = False
        '
        'lblNumeroCotacao
        '
        Me.lblNumeroCotacao.AutoSize = True
        Me.lblNumeroCotacao.Location = New System.Drawing.Point(6, 100)
        Me.lblNumeroCotacao.Name = "lblNumeroCotacao"
        Me.lblNumeroCotacao.Size = New System.Drawing.Size(65, 14)
        Me.lblNumeroCotacao.TabIndex = 17
        Me.lblNumeroCotacao.Text = "Nº Cotação:"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedido.Location = New System.Drawing.Point(204, 117)
        Me.txtNumeroPedido.MaxLength = 250
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Size = New System.Drawing.Size(187, 20)
        Me.txtNumeroPedido.TabIndex = 20
        Me.txtNumeroPedido.TabStop = False
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Location = New System.Drawing.Point(201, 100)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedido.TabIndex = 19
        Me.lblNumeroPedido.Text = "Nº Pedido:"
        '
        'chkQuantidade
        '
        Me.chkQuantidade.Location = New System.Drawing.Point(298, 143)
        Me.chkQuantidade.Name = "chkQuantidade"
        Me.chkQuantidade.Size = New System.Drawing.Size(84, 17)
        Me.chkQuantidade.TabIndex = 25
        Me.chkQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(299, 163)
        Me.txtQuantidade.MaxLength = 0
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(83, 20)
        Me.txtQuantidade.TabIndex = 26
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.AutoSize = False
        Me.cboCodigoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoProduto.Location = New System.Drawing.Point(9, 163)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProduto.ReadOnly = True
        Me.cboCodigoProduto.Size = New System.Drawing.Size(284, 20)
        Me.cboCodigoProduto.TabIndex = 24
        '
        'chkCodigoProduto
        '
        Me.chkCodigoProduto.Location = New System.Drawing.Point(9, 143)
        Me.chkCodigoProduto.Name = "chkCodigoProduto"
        Me.chkCodigoProduto.Size = New System.Drawing.Size(93, 17)
        Me.chkCodigoProduto.TabIndex = 23
        Me.chkCodigoProduto.Text = "Código Produto:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(645, 37)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(164, 20)
        Me.txtCodigo.TabIndex = 6
        Me.txtCodigo.TabStop = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(642, 20)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 5
        Me.lblCodigo.Text = "Código:"
        '
        'txtRequisitante
        '
        Me.txtRequisitante.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRequisitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRequisitante.Location = New System.Drawing.Point(204, 37)
        Me.txtRequisitante.MaxLength = 250
        Me.txtRequisitante.Name = "txtRequisitante"
        Me.txtRequisitante.Size = New System.Drawing.Size(435, 20)
        Me.txtRequisitante.TabIndex = 4
        Me.txtRequisitante.TabStop = False
        '
        'lblRequisitante
        '
        Me.lblRequisitante.AutoSize = True
        Me.lblRequisitante.Location = New System.Drawing.Point(201, 20)
        Me.lblRequisitante.Name = "lblRequisitante"
        Me.lblRequisitante.Size = New System.Drawing.Size(69, 14)
        Me.lblRequisitante.TabIndex = 3
        Me.lblRequisitante.Text = "Requisitante:"
        '
        'txtNumeroRequisicao
        '
        Me.txtNumeroRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicao.Location = New System.Drawing.Point(9, 37)
        Me.txtNumeroRequisicao.MaxLength = 20
        Me.txtNumeroRequisicao.Name = "txtNumeroRequisicao"
        Me.txtNumeroRequisicao.Size = New System.Drawing.Size(187, 20)
        Me.txtNumeroRequisicao.TabIndex = 2
        Me.txtNumeroRequisicao.TabStop = False
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(6, 20)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicao.TabIndex = 1
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 77)
        Me.txtDescricao.MaxLength = 250
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(486, 20)
        Me.txtDescricao.TabIndex = 8
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 60)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 7
        Me.lblDescricao.Text = "Descrição:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.lblSelecione)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 198)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(818, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'lblSelecione
        '
        Me.lblSelecione.AutoSize = True
        Me.lblSelecione.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblSelecione.ForeColor = System.Drawing.Color.Firebrick
        Me.lblSelecione.Location = New System.Drawing.Point(6, 17)
        Me.lblSelecione.Name = "lblSelecione"
        Me.lblSelecione.Size = New System.Drawing.Size(476, 14)
        Me.lblSelecione.TabIndex = 0
        Me.lblSelecione.Text = "Selecione a opção para fazer a alteração em cascata (Requisição a Pedido de Compr" & _
    "a)"
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSalvar.Location = New System.Drawing.Point(621, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(718, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmCmpRequisicaoAlterar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 292)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCmpRequisicaoAlterar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Compras - Alterar Requisição"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMotivo.ResumeLayout(False)
        Me.grpMotivo.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.grpControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtRequisitante As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRequisitante As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents chkCodigoProduto As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents chkQuantidade As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNumeroCotacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroCotacao As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents lblSelecione As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtQuantidadeAntiga As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblQuantidadeAntiga As System.Windows.Forms.Label
    Friend WithEvents chkLargura As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkComprimento As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtUnidadeMedidaDimensao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboNewUnidadeMedidaDimensao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNewAltura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNewComprimento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNewLargura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblUnidadeMedidaDimensao As System.Windows.Forms.Label
    Friend WithEvents txtAltura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtComprimento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAltura As System.Windows.Forms.Label
    Friend WithEvents lblComprimento As System.Windows.Forms.Label
    Friend WithEvents txtLargura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLargura As System.Windows.Forms.Label
    Friend WithEvents chkDimensao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkUnidadeMedida As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkAltura As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents lblDimensao As System.Windows.Forms.Label
    Friend WithEvents txtDimensao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNewDimensao As Janus.Windows.GridEX.EditControls.MaskedEditBox
End Class
