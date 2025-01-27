<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutoPrecoVendaObservacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutoPrecoVendaObservacao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpPrecoVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPrecoVenda = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMarkup = New System.Windows.Forms.Label()
        Me.txtMarkup = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblGP = New System.Windows.Forms.Label()
        Me.txtGP = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMargem = New System.Windows.Forms.Label()
        Me.txtMargem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtCusto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboCusto = New Janus.Windows.EditControls.UIComboBox()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataValidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDataValidade = New System.Windows.Forms.Label()
        Me.txtMarca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblQuantidadeRev = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtQuantidadeRev = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.txtQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.cboSugestaoVenda = New Janus.Windows.EditControls.UIComboBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.btnCadastrarSugestaoVenda = New System.Windows.Forms.Button()
        Me.lblSugestaoVenda = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpPrecoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPrecoVenda.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(886, 535)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpPrecoVenda)
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Controls.Add(Me.txtObservacao)
        Me.pagTabela.Controls.Add(Me.cboSugestaoVenda)
        Me.pagTabela.Controls.Add(Me.lblObservacao)
        Me.pagTabela.Controls.Add(Me.btnCadastrarSugestaoVenda)
        Me.pagTabela.Controls.Add(Me.lblSugestaoVenda)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(884, 512)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Revisão do Preço de Venda"
        '
        'grpPrecoVenda
        '
        Me.grpPrecoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPrecoVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpPrecoVenda.Controls.Add(Me.lblPrecoVenda)
        Me.grpPrecoVenda.Controls.Add(Me.txtPrecoVenda)
        Me.grpPrecoVenda.Controls.Add(Me.lblMarkup)
        Me.grpPrecoVenda.Controls.Add(Me.txtMarkup)
        Me.grpPrecoVenda.Controls.Add(Me.lblGP)
        Me.grpPrecoVenda.Controls.Add(Me.txtGP)
        Me.grpPrecoVenda.Controls.Add(Me.lblMargem)
        Me.grpPrecoVenda.Controls.Add(Me.txtMargem)
        Me.grpPrecoVenda.Controls.Add(Me.txtCusto)
        Me.grpPrecoVenda.Controls.Add(Me.cboCusto)
        Me.grpPrecoVenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPrecoVenda.Location = New System.Drawing.Point(512, 3)
        Me.grpPrecoVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPrecoVenda.Name = "grpPrecoVenda"
        Me.grpPrecoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPrecoVenda.Size = New System.Drawing.Size(364, 144)
        Me.grpPrecoVenda.TabIndex = 0
        Me.grpPrecoVenda.Text = "Preço de Venda"
        Me.grpPrecoVenda.VisualStyleManager = Me.vsmMain
        '
        'lblPrecoVenda
        '
        Me.lblPrecoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecoVenda.AutoSize = True
        Me.lblPrecoVenda.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVenda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecoVenda.Location = New System.Drawing.Point(252, 57)
        Me.lblPrecoVenda.Name = "lblPrecoVenda"
        Me.lblPrecoVenda.Size = New System.Drawing.Size(96, 14)
        Me.lblPrecoVenda.TabIndex = 8
        Me.lblPrecoVenda.Text = "Preço de Venda:"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecoVenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecoVenda.DecimalDigits = 2
        Me.txtPrecoVenda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrecoVenda.Location = New System.Drawing.Point(255, 74)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoVenda.TabIndex = 9
        Me.txtPrecoVenda.Text = "0,00"
        Me.txtPrecoVenda.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMarkup
        '
        Me.lblMarkup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarkup.AutoSize = True
        Me.lblMarkup.BackColor = System.Drawing.Color.Transparent
        Me.lblMarkup.Location = New System.Drawing.Point(146, 97)
        Me.lblMarkup.Name = "lblMarkup"
        Me.lblMarkup.Size = New System.Drawing.Size(45, 14)
        Me.lblMarkup.TabIndex = 6
        Me.lblMarkup.Text = "Markup:"
        '
        'txtMarkup
        '
        Me.txtMarkup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarkup.DecimalDigits = 2
        Me.txtMarkup.Location = New System.Drawing.Point(149, 114)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkup.TabIndex = 7
        Me.txtMarkup.Text = "0,00"
        Me.txtMarkup.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblGP
        '
        Me.lblGP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGP.AutoSize = True
        Me.lblGP.BackColor = System.Drawing.Color.Transparent
        Me.lblGP.Location = New System.Drawing.Point(146, 57)
        Me.lblGP.Name = "lblGP"
        Me.lblGP.Size = New System.Drawing.Size(24, 14)
        Me.lblGP.TabIndex = 4
        Me.lblGP.Text = "GP:"
        '
        'txtGP
        '
        Me.txtGP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGP.DecimalDigits = 2
        Me.txtGP.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtGP.Location = New System.Drawing.Point(149, 74)
        Me.txtGP.Name = "txtGP"
        Me.txtGP.Size = New System.Drawing.Size(100, 20)
        Me.txtGP.TabIndex = 5
        Me.txtGP.Text = "0,00%"
        Me.txtGP.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMargem
        '
        Me.lblMargem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMargem.AutoSize = True
        Me.lblMargem.BackColor = System.Drawing.Color.Transparent
        Me.lblMargem.Location = New System.Drawing.Point(146, 17)
        Me.lblMargem.Name = "lblMargem"
        Me.lblMargem.Size = New System.Drawing.Size(48, 14)
        Me.lblMargem.TabIndex = 2
        Me.lblMargem.Text = "Margem:"
        '
        'txtMargem
        '
        Me.txtMargem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMargem.DecimalDigits = 2
        Me.txtMargem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtMargem.Location = New System.Drawing.Point(149, 34)
        Me.txtMargem.Name = "txtMargem"
        Me.txtMargem.Size = New System.Drawing.Size(100, 20)
        Me.txtMargem.TabIndex = 3
        Me.txtMargem.Text = "0,00%"
        Me.txtMargem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtCusto
        '
        Me.txtCusto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCusto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCusto.DecimalDigits = 2
        Me.txtCusto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCusto.Location = New System.Drawing.Point(9, 74)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(134, 20)
        Me.txtCusto.TabIndex = 1
        Me.txtCusto.Text = "0,00"
        Me.txtCusto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboCusto
        '
        Me.cboCusto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCusto.AutoSize = False
        Me.cboCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCusto.Location = New System.Drawing.Point(9, 54)
        Me.cboCusto.Name = "cboCusto"
        Me.cboCusto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCusto.Size = New System.Drawing.Size(134, 20)
        Me.cboCusto.TabIndex = 0
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.dtpDataValidade)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.lblDataValidade)
        Me.grpDados.Controls.Add(Me.txtMarca)
        Me.grpDados.Controls.Add(Me.lblQuantidadeRev)
        Me.grpDados.Controls.Add(Me.lblMarca)
        Me.grpDados.Controls.Add(Me.txtQuantidadeRev)
        Me.grpDados.Controls.Add(Me.txtReferencia)
        Me.grpDados.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpDados.Controls.Add(Me.txtQuantidadeEstoque)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.lblReferencia)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(495, 144)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados do Produto"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'dtpDataValidade
        '
        '
        '
        '
        Me.dtpDataValidade.DropDownCalendar.Name = ""
        Me.dtpDataValidade.Location = New System.Drawing.Point(267, 114)
        Me.dtpDataValidade.Name = "dtpDataValidade"
        Me.dtpDataValidade.ShowCheckBox = True
        Me.dtpDataValidade.Size = New System.Drawing.Size(123, 20)
        Me.dtpDataValidade.TabIndex = 13
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'lblDataValidade
        '
        Me.lblDataValidade.AutoSize = True
        Me.lblDataValidade.BackColor = System.Drawing.Color.Transparent
        Me.lblDataValidade.Location = New System.Drawing.Point(264, 97)
        Me.lblDataValidade.Name = "lblDataValidade"
        Me.lblDataValidade.Size = New System.Drawing.Size(76, 14)
        Me.lblDataValidade.TabIndex = 12
        Me.lblDataValidade.Text = "Data Validade:"
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMarca.Location = New System.Drawing.Point(138, 74)
        Me.txtMarca.MaxLength = 100
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(348, 20)
        Me.txtMarca.TabIndex = 7
        Me.txtMarca.TabStop = False
        '
        'lblQuantidadeRev
        '
        Me.lblQuantidadeRev.AutoSize = True
        Me.lblQuantidadeRev.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantidadeRev.Location = New System.Drawing.Point(135, 97)
        Me.lblQuantidadeRev.Name = "lblQuantidadeRev"
        Me.lblQuantidadeRev.Size = New System.Drawing.Size(111, 14)
        Me.lblQuantidadeRev.TabIndex = 10
        Me.lblQuantidadeRev.Text = "Quantidade para Rev."
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarca.Location = New System.Drawing.Point(135, 57)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 14)
        Me.lblMarca.TabIndex = 6
        Me.lblMarca.Text = "Marca:"
        '
        'txtQuantidadeRev
        '
        Me.txtQuantidadeRev.DecimalDigits = 4
        Me.txtQuantidadeRev.Location = New System.Drawing.Point(138, 114)
        Me.txtQuantidadeRev.Name = "txtQuantidadeRev"
        Me.txtQuantidadeRev.Size = New System.Drawing.Size(123, 20)
        Me.txtQuantidadeRev.TabIndex = 11
        Me.txtQuantidadeRev.Text = "0,0000"
        Me.txtQuantidadeRev.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtReferencia
        '
        Me.txtReferencia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtReferencia.Location = New System.Drawing.Point(9, 74)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.ReadOnly = True
        Me.txtReferencia.Size = New System.Drawing.Size(123, 20)
        Me.txtReferencia.TabIndex = 5
        Me.txtReferencia.TabStop = False
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(6, 97)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(107, 14)
        Me.lblQuantidadeEstoque.TabIndex = 8
        Me.lblQuantidadeEstoque.Text = "Quantidade Estoque:"
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeEstoque.DecimalDigits = 4
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(9, 114)
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.ReadOnly = True
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(123, 20)
        Me.txtQuantidadeEstoque.TabIndex = 9
        Me.txtQuantidadeEstoque.TabStop = False
        Me.txtQuantidadeEstoque.Text = "0,0000"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(135, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReferencia.Location = New System.Drawing.Point(6, 57)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(63, 14)
        Me.lblReferencia.TabIndex = 4
        Me.lblReferencia.Text = "Referência:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricao.Location = New System.Drawing.Point(138, 34)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(348, 20)
        Me.txtDescricao.TabIndex = 3
        Me.txtDescricao.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigo.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TabStop = False
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 452)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(868, 51)
        Me.grpControl2.TabIndex = 6
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(671, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(768, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(8, 207)
        Me.txtObservacao.MaxLength = 0
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(868, 242)
        Me.txtObservacao.TabIndex = 5
        '
        'cboSugestaoVenda
        '
        Me.cboSugestaoVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSugestaoVenda.AutoSize = False
        Me.cboSugestaoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSugestaoVenda.Location = New System.Drawing.Point(8, 167)
        Me.cboSugestaoVenda.Name = "cboSugestaoVenda"
        Me.cboSugestaoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSugestaoVenda.Size = New System.Drawing.Size(868, 20)
        Me.cboSugestaoVenda.TabIndex = 3
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.BackColor = System.Drawing.Color.Transparent
        Me.lblObservacao.Location = New System.Drawing.Point(5, 190)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(56, 14)
        Me.lblObservacao.TabIndex = 4
        Me.lblObservacao.Text = "Sugestão:"
        '
        'btnCadastrarSugestaoVenda
        '
        Me.btnCadastrarSugestaoVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastrarSugestaoVenda.FlatAppearance.BorderSize = 0
        Me.btnCadastrarSugestaoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarSugestaoVenda.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarSugestaoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarSugestaoVenda.Location = New System.Drawing.Point(8, 151)
        Me.btnCadastrarSugestaoVenda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarSugestaoVenda.Name = "btnCadastrarSugestaoVenda"
        Me.btnCadastrarSugestaoVenda.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarSugestaoVenda.TabIndex = 1
        Me.btnCadastrarSugestaoVenda.TabStop = False
        Me.btnCadastrarSugestaoVenda.UseVisualStyleBackColor = False
        '
        'lblSugestaoVenda
        '
        Me.lblSugestaoVenda.AutoSize = True
        Me.lblSugestaoVenda.BackColor = System.Drawing.Color.Transparent
        Me.lblSugestaoVenda.Location = New System.Drawing.Point(24, 150)
        Me.lblSugestaoVenda.Name = "lblSugestaoVenda"
        Me.lblSugestaoVenda.Size = New System.Drawing.Size(105, 14)
        Me.lblSugestaoVenda.TabIndex = 2
        Me.lblSugestaoVenda.Text = "Sugestão de Venda:"
        '
        'frmCadProdutoPrecoVendaObservacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 550)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadProdutoPrecoVendaObservacao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Revisão do Preço de Venda"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        Me.pagTabela.PerformLayout()
        CType(Me.grpPrecoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPrecoVenda.ResumeLayout(False)
        Me.grpPrecoVenda.PerformLayout()
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
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtMarca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboSugestaoVenda As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarSugestaoVenda As System.Windows.Forms.Button
    Friend WithEvents lblSugestaoVenda As System.Windows.Forms.Label
    Friend WithEvents grpPrecoVenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPrecoVenda As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVenda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMarkup As System.Windows.Forms.Label
    Friend WithEvents txtMarkup As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblGP As System.Windows.Forms.Label
    Friend WithEvents txtGP As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMargem As System.Windows.Forms.Label
    Friend WithEvents txtMargem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtCusto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpDataValidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataValidade As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRev As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeRev As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboCusto As Janus.Windows.EditControls.UIComboBox
End Class
