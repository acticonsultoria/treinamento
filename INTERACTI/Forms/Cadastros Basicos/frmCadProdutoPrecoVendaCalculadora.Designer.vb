<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutoPrecoVendaCalculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutoPrecoVendaCalculadora))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnRev = New System.Windows.Forms.Button()
        Me.txtSugestao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.grpPrecoVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFatorConversao = New System.Windows.Forms.Label()
        Me.txtFatorConversao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.btnPedidoCompraTransito = New Janus.Windows.EditControls.UIButton()
        Me.lblPedidoCompraTransito = New System.Windows.Forms.Label()
        Me.txtPedidoCompraTransito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnEstoqueReservado = New Janus.Windows.EditControls.UIButton()
        Me.lblQuantidadeEstoqueReservado = New System.Windows.Forms.Label()
        Me.txtEstoqueReservado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeUnidade = New System.Windows.Forms.Label()
        Me.txtQuantidadeUnidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.dtpPrevisaoEntregaProduto = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblPrevisaoEntregaProduto = New System.Windows.Forms.Label()
        Me.lblLine2 = New System.Windows.Forms.Label()
        Me.btnDesmembrarPrevisaoEntrega = New System.Windows.Forms.Button()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.cboDestinacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDestinacao = New System.Windows.Forms.Label()
        Me.btnAdicionarMedio = New Janus.Windows.EditControls.UIButton()
        Me.btnAdicionarTeorico = New Janus.Windows.EditControls.UIButton()
        Me.lblMarkupMedio = New System.Windows.Forms.Label()
        Me.txtMarkupMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMarkupTeorico = New System.Windows.Forms.Label()
        Me.txtMarkupTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIgualMedio = New System.Windows.Forms.Label()
        Me.lblIgualTeorico = New System.Windows.Forms.Label()
        Me.lblMaisMedio = New System.Windows.Forms.Label()
        Me.lblMaisTeorico = New System.Windows.Forms.Label()
        Me.lblPrecoVendaUnidadeMedio = New System.Windows.Forms.Label()
        Me.txtPrecoVendaUnidadeMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVendaUnidadeTeorico = New System.Windows.Forms.Label()
        Me.txtPrecoVendaUnidadeTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblGPMedio = New System.Windows.Forms.Label()
        Me.txtGPMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMargemMedio = New System.Windows.Forms.Label()
        Me.txtMargemMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCustoTeorico = New System.Windows.Forms.Label()
        Me.txtCustoTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCustoMedio = New System.Windows.Forms.Label()
        Me.lblPrecoVendaMedio = New System.Windows.Forms.Label()
        Me.txtPrecoVendaMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVendaTeorico = New System.Windows.Forms.Label()
        Me.txtPrecoVendaTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblGPTeorico = New System.Windows.Forms.Label()
        Me.txtGPTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMargemTeorico = New System.Windows.Forms.Label()
        Me.txtMargemTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtCustoMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMunicipioUF = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMunicipioUF = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtMarca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblEstoque = New System.Windows.Forms.Label()
        Me.txtQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpPrecoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPrecoVenda.SuspendLayout()
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
        Me.tabMain.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.ForeColor = System.Drawing.Color.Red
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.ShowTabs = False
        Me.tabMain.Size = New System.Drawing.Size(851, 359)
        Me.tabMain.TabDisplay = Janus.Windows.UI.Tab.TabDisplay.Text
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnRev)
        Me.pagDados.Controls.Add(Me.txtSugestao)
        Me.pagDados.Controls.Add(Me.grpPrecoVenda)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 1)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(849, 357)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "New Tab"
        '
        'btnRev
        '
        Me.btnRev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRev.BackColor = System.Drawing.Color.Red
        Me.btnRev.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.btnRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRev.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnRev.ForeColor = System.Drawing.Color.White
        Me.btnRev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRev.Location = New System.Drawing.Point(8, 280)
        Me.btnRev.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRev.Name = "btnRev"
        Me.btnRev.Size = New System.Drawing.Size(62, 68)
        Me.btnRev.TabIndex = 5
        Me.btnRev.Text = "REV"
        Me.btnRev.UseVisualStyleBackColor = False
        '
        'txtSugestao
        '
        Me.txtSugestao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSugestao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSugestao.Font = New System.Drawing.Font("Arial", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txtSugestao.ForeColor = System.Drawing.Color.Black
        Me.txtSugestao.Location = New System.Drawing.Point(69, 280)
        Me.txtSugestao.MaxLength = 700
        Me.txtSugestao.Multiline = True
        Me.txtSugestao.Name = "txtSugestao"
        Me.txtSugestao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSugestao.Size = New System.Drawing.Size(772, 68)
        Me.txtSugestao.TabIndex = 6
        '
        'grpPrecoVenda
        '
        Me.grpPrecoVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpPrecoVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpPrecoVenda.Controls.Add(Me.lblFatorConversao)
        Me.grpPrecoVenda.Controls.Add(Me.txtFatorConversao)
        Me.grpPrecoVenda.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpPrecoVenda.Controls.Add(Me.btnPedidoCompraTransito)
        Me.grpPrecoVenda.Controls.Add(Me.lblPedidoCompraTransito)
        Me.grpPrecoVenda.Controls.Add(Me.txtPedidoCompraTransito)
        Me.grpPrecoVenda.Controls.Add(Me.btnEstoqueReservado)
        Me.grpPrecoVenda.Controls.Add(Me.lblQuantidadeEstoqueReservado)
        Me.grpPrecoVenda.Controls.Add(Me.txtEstoqueReservado)
        Me.grpPrecoVenda.Controls.Add(Me.lblQuantidadeUnidade)
        Me.grpPrecoVenda.Controls.Add(Me.txtQuantidadeUnidade)
        Me.grpPrecoVenda.Controls.Add(Me.dtpPrevisaoEntregaProduto)
        Me.grpPrecoVenda.Controls.Add(Me.lblPrevisaoEntregaProduto)
        Me.grpPrecoVenda.Controls.Add(Me.lblLine2)
        Me.grpPrecoVenda.Controls.Add(Me.btnDesmembrarPrevisaoEntrega)
        Me.grpPrecoVenda.Controls.Add(Me.lblLine1)
        Me.grpPrecoVenda.Controls.Add(Me.cboDestinacao)
        Me.grpPrecoVenda.Controls.Add(Me.lblDestinacao)
        Me.grpPrecoVenda.Controls.Add(Me.btnAdicionarMedio)
        Me.grpPrecoVenda.Controls.Add(Me.btnAdicionarTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.lblMarkupMedio)
        Me.grpPrecoVenda.Controls.Add(Me.txtMarkupMedio)
        Me.grpPrecoVenda.Controls.Add(Me.lblMarkupTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.txtMarkupTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.lblIgualMedio)
        Me.grpPrecoVenda.Controls.Add(Me.lblIgualTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.lblMaisMedio)
        Me.grpPrecoVenda.Controls.Add(Me.lblMaisTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.lblPrecoVendaUnidadeMedio)
        Me.grpPrecoVenda.Controls.Add(Me.txtPrecoVendaUnidadeMedio)
        Me.grpPrecoVenda.Controls.Add(Me.lblPrecoVendaUnidadeTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.txtPrecoVendaUnidadeTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.lblGPMedio)
        Me.grpPrecoVenda.Controls.Add(Me.txtGPMedio)
        Me.grpPrecoVenda.Controls.Add(Me.lblMargemMedio)
        Me.grpPrecoVenda.Controls.Add(Me.txtMargemMedio)
        Me.grpPrecoVenda.Controls.Add(Me.lblCustoTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.txtCustoTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.lblCustoMedio)
        Me.grpPrecoVenda.Controls.Add(Me.lblPrecoVendaMedio)
        Me.grpPrecoVenda.Controls.Add(Me.txtPrecoVendaMedio)
        Me.grpPrecoVenda.Controls.Add(Me.lblPrecoVendaTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.txtPrecoVendaTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.lblGPTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.txtGPTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.lblMargemTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.txtMargemTeorico)
        Me.grpPrecoVenda.Controls.Add(Me.txtCustoMedio)
        Me.grpPrecoVenda.Controls.Add(Me.lblQuantidade)
        Me.grpPrecoVenda.Controls.Add(Me.txtQuantidade)
        Me.grpPrecoVenda.Controls.Add(Me.txtMunicipioUF)
        Me.grpPrecoVenda.Controls.Add(Me.lblMunicipioUF)
        Me.grpPrecoVenda.Controls.Add(Me.cboCliente)
        Me.grpPrecoVenda.Controls.Add(Me.lblCliente)
        Me.grpPrecoVenda.Controls.Add(Me.lblCodigo)
        Me.grpPrecoVenda.Controls.Add(Me.txtMarca)
        Me.grpPrecoVenda.Controls.Add(Me.lblMarca)
        Me.grpPrecoVenda.Controls.Add(Me.lblEstoque)
        Me.grpPrecoVenda.Controls.Add(Me.txtQuantidadeEstoque)
        Me.grpPrecoVenda.Controls.Add(Me.lblDescricao)
        Me.grpPrecoVenda.Controls.Add(Me.txtDescricao)
        Me.grpPrecoVenda.Controls.Add(Me.cboCodigoProduto)
        Me.grpPrecoVenda.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrecoVenda.FormatStyle.FontBold = Janus.Windows.UI.TriState.[True]
        Me.grpPrecoVenda.FormatStyle.ForeColor = System.Drawing.Color.Black
        Me.grpPrecoVenda.Location = New System.Drawing.Point(8, 4)
        Me.grpPrecoVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPrecoVenda.Name = "grpPrecoVenda"
        Me.grpPrecoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPrecoVenda.Size = New System.Drawing.Size(833, 267)
        Me.grpPrecoVenda.TabIndex = 0
        Me.grpPrecoVenda.VisualStyleManager = Me.vsmMain
        '
        'lblFatorConversao
        '
        Me.lblFatorConversao.AutoSize = True
        Me.lblFatorConversao.BackColor = System.Drawing.Color.Transparent
        Me.lblFatorConversao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFatorConversao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFatorConversao.Location = New System.Drawing.Point(570, 79)
        Me.lblFatorConversao.Name = "lblFatorConversao"
        Me.lblFatorConversao.Size = New System.Drawing.Size(91, 14)
        Me.lblFatorConversao.TabIndex = 70
        Me.lblFatorConversao.Text = "Fator Conversão:"
        '
        'txtFatorConversao
        '
        Me.txtFatorConversao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFatorConversao.DecimalDigits = 4
        Me.txtFatorConversao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatorConversao.Location = New System.Drawing.Point(573, 97)
        Me.txtFatorConversao.Name = "txtFatorConversao"
        Me.txtFatorConversao.ReadOnly = True
        Me.txtFatorConversao.Size = New System.Drawing.Size(99, 20)
        Me.txtFatorConversao.TabIndex = 69
        Me.txtFatorConversao.TabStop = False
        Me.txtFatorConversao.Text = "0,0000"
        Me.txtFatorConversao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantidadeEstoque.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidadeEstoque.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(6, 121)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeEstoque.TabIndex = 68
        Me.lblQuantidadeEstoque.Text = "Qtde. Estoque:"
        '
        'btnPedidoCompraTransito
        '
        Me.btnPedidoCompraTransito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedidoCompraTransito.Image = Global.INTERACTI.My.Resources.Resources.text_align_right
        Me.btnPedidoCompraTransito.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnPedidoCompraTransito.Location = New System.Drawing.Point(213, 139)
        Me.btnPedidoCompraTransito.Name = "btnPedidoCompraTransito"
        Me.btnPedidoCompraTransito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPedidoCompraTransito.Size = New System.Drawing.Size(20, 20)
        Me.btnPedidoCompraTransito.TabIndex = 20
        Me.btnPedidoCompraTransito.TabStop = False
        Me.btnPedidoCompraTransito.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblPedidoCompraTransito
        '
        Me.lblPedidoCompraTransito.AutoSize = True
        Me.lblPedidoCompraTransito.BackColor = System.Drawing.Color.Transparent
        Me.lblPedidoCompraTransito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedidoCompraTransito.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPedidoCompraTransito.Location = New System.Drawing.Point(112, 121)
        Me.lblPedidoCompraTransito.Name = "lblPedidoCompraTransito"
        Me.lblPedidoCompraTransito.Size = New System.Drawing.Size(82, 14)
        Me.lblPedidoCompraTransito.TabIndex = 18
        Me.lblPedidoCompraTransito.Text = "Pedido Compra:"
        '
        'txtPedidoCompraTransito
        '
        Me.txtPedidoCompraTransito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPedidoCompraTransito.DecimalDigits = 2
        Me.txtPedidoCompraTransito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoCompraTransito.Location = New System.Drawing.Point(114, 139)
        Me.txtPedidoCompraTransito.Name = "txtPedidoCompraTransito"
        Me.txtPedidoCompraTransito.ReadOnly = True
        Me.txtPedidoCompraTransito.Size = New System.Drawing.Size(100, 20)
        Me.txtPedidoCompraTransito.TabIndex = 19
        Me.txtPedidoCompraTransito.TabStop = False
        Me.txtPedidoCompraTransito.Text = "0,00"
        Me.txtPedidoCompraTransito.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnEstoqueReservado
        '
        Me.btnEstoqueReservado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstoqueReservado.Image = Global.INTERACTI.My.Resources.Resources.text_align_right
        Me.btnEstoqueReservado.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnEstoqueReservado.Location = New System.Drawing.Point(337, 139)
        Me.btnEstoqueReservado.Name = "btnEstoqueReservado"
        Me.btnEstoqueReservado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEstoqueReservado.Size = New System.Drawing.Size(20, 20)
        Me.btnEstoqueReservado.TabIndex = 23
        Me.btnEstoqueReservado.TabStop = False
        Me.btnEstoqueReservado.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblQuantidadeEstoqueReservado
        '
        Me.lblQuantidadeEstoqueReservado.AutoSize = True
        Me.lblQuantidadeEstoqueReservado.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantidadeEstoqueReservado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidadeEstoqueReservado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQuantidadeEstoqueReservado.Location = New System.Drawing.Point(236, 121)
        Me.lblQuantidadeEstoqueReservado.Name = "lblQuantidadeEstoqueReservado"
        Me.lblQuantidadeEstoqueReservado.Size = New System.Drawing.Size(105, 14)
        Me.lblQuantidadeEstoqueReservado.TabIndex = 21
        Me.lblQuantidadeEstoqueReservado.Text = "Estoque Reservado:"
        '
        'txtEstoqueReservado
        '
        Me.txtEstoqueReservado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEstoqueReservado.DecimalDigits = 2
        Me.txtEstoqueReservado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstoqueReservado.Location = New System.Drawing.Point(239, 139)
        Me.txtEstoqueReservado.Name = "txtEstoqueReservado"
        Me.txtEstoqueReservado.ReadOnly = True
        Me.txtEstoqueReservado.Size = New System.Drawing.Size(99, 20)
        Me.txtEstoqueReservado.TabIndex = 22
        Me.txtEstoqueReservado.TabStop = False
        Me.txtEstoqueReservado.Text = "0,00"
        Me.txtEstoqueReservado.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidadeUnidade
        '
        Me.lblQuantidadeUnidade.AutoSize = True
        Me.lblQuantidadeUnidade.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantidadeUnidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidadeUnidade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQuantidadeUnidade.Location = New System.Drawing.Point(464, 121)
        Me.lblQuantidadeUnidade.Name = "lblQuantidadeUnidade"
        Me.lblQuantidadeUnidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeUnidade.TabIndex = 26
        Me.lblQuantidadeUnidade.Text = "Quantidade:"
        '
        'txtQuantidadeUnidade
        '
        Me.txtQuantidadeUnidade.DecimalDigits = 2
        Me.txtQuantidadeUnidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeUnidade.Location = New System.Drawing.Point(468, 139)
        Me.txtQuantidadeUnidade.Name = "txtQuantidadeUnidade"
        Me.txtQuantidadeUnidade.Size = New System.Drawing.Size(99, 20)
        Me.txtQuantidadeUnidade.TabIndex = 27
        Me.txtQuantidadeUnidade.Text = "0,00"
        Me.txtQuantidadeUnidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'dtpPrevisaoEntregaProduto
        '
        '
        '
        '
        Me.dtpPrevisaoEntregaProduto.DropDownCalendar.Name = ""
        Me.dtpPrevisaoEntregaProduto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPrevisaoEntregaProduto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtpPrevisaoEntregaProduto.Location = New System.Drawing.Point(573, 139)
        Me.dtpPrevisaoEntregaProduto.Name = "dtpPrevisaoEntregaProduto"
        Me.dtpPrevisaoEntregaProduto.Size = New System.Drawing.Size(99, 20)
        Me.dtpPrevisaoEntregaProduto.TabIndex = 32
        Me.dtpPrevisaoEntregaProduto.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblPrevisaoEntregaProduto
        '
        Me.lblPrevisaoEntregaProduto.AutoSize = True
        Me.lblPrevisaoEntregaProduto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevisaoEntregaProduto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrevisaoEntregaProduto.Location = New System.Drawing.Point(590, 121)
        Me.lblPrevisaoEntregaProduto.Name = "lblPrevisaoEntregaProduto"
        Me.lblPrevisaoEntregaProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblPrevisaoEntregaProduto.TabIndex = 31
        Me.lblPrevisaoEntregaProduto.Text = "Entrega:"
        '
        'lblLine2
        '
        Me.lblLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLine2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLine2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLine2.Location = New System.Drawing.Point(8, 169)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.Size = New System.Drawing.Size(816, 1)
        Me.lblLine2.TabIndex = 35
        '
        'btnDesmembrarPrevisaoEntrega
        '
        Me.btnDesmembrarPrevisaoEntrega.FlatAppearance.BorderSize = 0
        Me.btnDesmembrarPrevisaoEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesmembrarPrevisaoEntrega.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesmembrarPrevisaoEntrega.Image = Global.INTERACTI.My.Resources.Resources.calendario
        Me.btnDesmembrarPrevisaoEntrega.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDesmembrarPrevisaoEntrega.Location = New System.Drawing.Point(570, 120)
        Me.btnDesmembrarPrevisaoEntrega.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDesmembrarPrevisaoEntrega.Name = "btnDesmembrarPrevisaoEntrega"
        Me.btnDesmembrarPrevisaoEntrega.Size = New System.Drawing.Size(17, 17)
        Me.btnDesmembrarPrevisaoEntrega.TabIndex = 30
        Me.btnDesmembrarPrevisaoEntrega.TabStop = False
        Me.btnDesmembrarPrevisaoEntrega.UseVisualStyleBackColor = True
        '
        'lblLine1
        '
        Me.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLine1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLine1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLine1.Location = New System.Drawing.Point(9, 70)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(815, 1)
        Me.lblLine1.TabIndex = 4
        '
        'cboDestinacao
        '
        Me.cboDestinacao.AutoSize = False
        Me.cboDestinacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDestinacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestinacao.Location = New System.Drawing.Point(678, 138)
        Me.cboDestinacao.Name = "cboDestinacao"
        Me.cboDestinacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDestinacao.Size = New System.Drawing.Size(146, 21)
        Me.cboDestinacao.TabIndex = 29
        '
        'lblDestinacao
        '
        Me.lblDestinacao.AutoSize = True
        Me.lblDestinacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestinacao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDestinacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDestinacao.Location = New System.Drawing.Point(675, 120)
        Me.lblDestinacao.Name = "lblDestinacao"
        Me.lblDestinacao.Size = New System.Drawing.Size(64, 14)
        Me.lblDestinacao.TabIndex = 28
        Me.lblDestinacao.Text = "Destinação:"
        '
        'btnAdicionarMedio
        '
        Me.btnAdicionarMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarMedio.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnAdicionarMedio.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAdicionarMedio.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAdicionarMedio.Location = New System.Drawing.Point(733, 238)
        Me.btnAdicionarMedio.Name = "btnAdicionarMedio"
        Me.btnAdicionarMedio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAdicionarMedio.Size = New System.Drawing.Size(91, 20)
        Me.btnAdicionarMedio.TabIndex = 65
        Me.btnAdicionarMedio.Text = "Adicionar"
        Me.btnAdicionarMedio.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAdicionarTeorico
        '
        Me.btnAdicionarTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarTeorico.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnAdicionarTeorico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAdicionarTeorico.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAdicionarTeorico.Location = New System.Drawing.Point(733, 196)
        Me.btnAdicionarTeorico.Name = "btnAdicionarTeorico"
        Me.btnAdicionarTeorico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAdicionarTeorico.Size = New System.Drawing.Size(91, 20)
        Me.btnAdicionarTeorico.TabIndex = 50
        Me.btnAdicionarTeorico.Text = "Adicionar"
        Me.btnAdicionarTeorico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblMarkupMedio
        '
        Me.lblMarkupMedio.AutoSize = True
        Me.lblMarkupMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblMarkupMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarkupMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMarkupMedio.Location = New System.Drawing.Point(341, 220)
        Me.lblMarkupMedio.Name = "lblMarkupMedio"
        Me.lblMarkupMedio.Size = New System.Drawing.Size(45, 14)
        Me.lblMarkupMedio.TabIndex = 58
        Me.lblMarkupMedio.Text = "Markup:"
        '
        'txtMarkupMedio
        '
        Me.txtMarkupMedio.DecimalDigits = 2
        Me.txtMarkupMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarkupMedio.Location = New System.Drawing.Point(344, 238)
        Me.txtMarkupMedio.Name = "txtMarkupMedio"
        Me.txtMarkupMedio.Size = New System.Drawing.Size(99, 20)
        Me.txtMarkupMedio.TabIndex = 59
        Me.txtMarkupMedio.Text = "0,00"
        Me.txtMarkupMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMarkupTeorico
        '
        Me.lblMarkupTeorico.AutoSize = True
        Me.lblMarkupTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblMarkupTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarkupTeorico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMarkupTeorico.Location = New System.Drawing.Point(341, 178)
        Me.lblMarkupTeorico.Name = "lblMarkupTeorico"
        Me.lblMarkupTeorico.Size = New System.Drawing.Size(45, 14)
        Me.lblMarkupTeorico.TabIndex = 43
        Me.lblMarkupTeorico.Text = "Markup:"
        '
        'txtMarkupTeorico
        '
        Me.txtMarkupTeorico.DecimalDigits = 2
        Me.txtMarkupTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarkupTeorico.Location = New System.Drawing.Point(344, 196)
        Me.txtMarkupTeorico.Name = "txtMarkupTeorico"
        Me.txtMarkupTeorico.Size = New System.Drawing.Size(99, 20)
        Me.txtMarkupTeorico.TabIndex = 44
        Me.txtMarkupTeorico.Text = "0,00"
        Me.txtMarkupTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblIgualMedio
        '
        Me.lblIgualMedio.AutoSize = True
        Me.lblIgualMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblIgualMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgualMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIgualMedio.Location = New System.Drawing.Point(449, 240)
        Me.lblIgualMedio.Name = "lblIgualMedio"
        Me.lblIgualMedio.Size = New System.Drawing.Size(13, 14)
        Me.lblIgualMedio.TabIndex = 60
        Me.lblIgualMedio.Text = "="
        '
        'lblIgualTeorico
        '
        Me.lblIgualTeorico.AutoSize = True
        Me.lblIgualTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblIgualTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIgualTeorico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIgualTeorico.Location = New System.Drawing.Point(449, 198)
        Me.lblIgualTeorico.Name = "lblIgualTeorico"
        Me.lblIgualTeorico.Size = New System.Drawing.Size(13, 14)
        Me.lblIgualTeorico.TabIndex = 45
        Me.lblIgualTeorico.Text = "="
        '
        'lblMaisMedio
        '
        Me.lblMaisMedio.AutoSize = True
        Me.lblMaisMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblMaisMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaisMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaisMedio.Location = New System.Drawing.Point(114, 239)
        Me.lblMaisMedio.Name = "lblMaisMedio"
        Me.lblMaisMedio.Size = New System.Drawing.Size(13, 14)
        Me.lblMaisMedio.TabIndex = 53
        Me.lblMaisMedio.Text = "+"
        '
        'lblMaisTeorico
        '
        Me.lblMaisTeorico.AutoSize = True
        Me.lblMaisTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblMaisTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaisTeorico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaisTeorico.Location = New System.Drawing.Point(114, 196)
        Me.lblMaisTeorico.Name = "lblMaisTeorico"
        Me.lblMaisTeorico.Size = New System.Drawing.Size(13, 14)
        Me.lblMaisTeorico.TabIndex = 38
        Me.lblMaisTeorico.Text = "+"
        '
        'lblPrecoVendaUnidadeMedio
        '
        Me.lblPrecoVendaUnidadeMedio.AutoSize = True
        Me.lblPrecoVendaUnidadeMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVendaUnidadeMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoVendaUnidadeMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrecoVendaUnidadeMedio.Location = New System.Drawing.Point(570, 220)
        Me.lblPrecoVendaUnidadeMedio.Name = "lblPrecoVendaUnidadeMedio"
        Me.lblPrecoVendaUnidadeMedio.Size = New System.Drawing.Size(72, 14)
        Me.lblPrecoVendaUnidadeMedio.TabIndex = 63
        Me.lblPrecoVendaUnidadeMedio.Text = "Preço Venda:"
        '
        'txtPrecoVendaUnidadeMedio
        '
        Me.txtPrecoVendaUnidadeMedio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecoVendaUnidadeMedio.DecimalDigits = 4
        Me.txtPrecoVendaUnidadeMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoVendaUnidadeMedio.Location = New System.Drawing.Point(573, 238)
        Me.txtPrecoVendaUnidadeMedio.Name = "txtPrecoVendaUnidadeMedio"
        Me.txtPrecoVendaUnidadeMedio.Size = New System.Drawing.Size(99, 20)
        Me.txtPrecoVendaUnidadeMedio.TabIndex = 64
        Me.txtPrecoVendaUnidadeMedio.Tag = "COLOR"
        Me.txtPrecoVendaUnidadeMedio.Text = "0,0000"
        Me.txtPrecoVendaUnidadeMedio.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblPrecoVendaUnidadeTeorico
        '
        Me.lblPrecoVendaUnidadeTeorico.AutoSize = True
        Me.lblPrecoVendaUnidadeTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVendaUnidadeTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoVendaUnidadeTeorico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrecoVendaUnidadeTeorico.Location = New System.Drawing.Point(570, 178)
        Me.lblPrecoVendaUnidadeTeorico.Name = "lblPrecoVendaUnidadeTeorico"
        Me.lblPrecoVendaUnidadeTeorico.Size = New System.Drawing.Size(72, 14)
        Me.lblPrecoVendaUnidadeTeorico.TabIndex = 48
        Me.lblPrecoVendaUnidadeTeorico.Text = "Preço Venda:"
        '
        'txtPrecoVendaUnidadeTeorico
        '
        Me.txtPrecoVendaUnidadeTeorico.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecoVendaUnidadeTeorico.DecimalDigits = 4
        Me.txtPrecoVendaUnidadeTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoVendaUnidadeTeorico.Location = New System.Drawing.Point(573, 196)
        Me.txtPrecoVendaUnidadeTeorico.Name = "txtPrecoVendaUnidadeTeorico"
        Me.txtPrecoVendaUnidadeTeorico.Size = New System.Drawing.Size(99, 20)
        Me.txtPrecoVendaUnidadeTeorico.TabIndex = 49
        Me.txtPrecoVendaUnidadeTeorico.Tag = "COLOR"
        Me.txtPrecoVendaUnidadeTeorico.Text = "0,0000"
        Me.txtPrecoVendaUnidadeTeorico.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblGPMedio
        '
        Me.lblGPMedio.AutoSize = True
        Me.lblGPMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblGPMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGPMedio.Location = New System.Drawing.Point(236, 220)
        Me.lblGPMedio.Name = "lblGPMedio"
        Me.lblGPMedio.Size = New System.Drawing.Size(24, 14)
        Me.lblGPMedio.TabIndex = 56
        Me.lblGPMedio.Text = "GP:"
        '
        'txtGPMedio
        '
        Me.txtGPMedio.DecimalDigits = 2
        Me.txtGPMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGPMedio.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtGPMedio.Location = New System.Drawing.Point(239, 238)
        Me.txtGPMedio.Name = "txtGPMedio"
        Me.txtGPMedio.Size = New System.Drawing.Size(99, 20)
        Me.txtGPMedio.TabIndex = 57
        Me.txtGPMedio.Text = "0,00%"
        Me.txtGPMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMargemMedio
        '
        Me.lblMargemMedio.AutoSize = True
        Me.lblMargemMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblMargemMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMargemMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMargemMedio.Location = New System.Drawing.Point(130, 220)
        Me.lblMargemMedio.Name = "lblMargemMedio"
        Me.lblMargemMedio.Size = New System.Drawing.Size(48, 14)
        Me.lblMargemMedio.TabIndex = 54
        Me.lblMargemMedio.Text = "Margem:"
        '
        'txtMargemMedio
        '
        Me.txtMargemMedio.DecimalDigits = 2
        Me.txtMargemMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMargemMedio.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtMargemMedio.Location = New System.Drawing.Point(133, 238)
        Me.txtMargemMedio.Name = "txtMargemMedio"
        Me.txtMargemMedio.Size = New System.Drawing.Size(99, 20)
        Me.txtMargemMedio.TabIndex = 55
        Me.txtMargemMedio.Text = "0,00%"
        Me.txtMargemMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCustoTeorico
        '
        Me.lblCustoTeorico.AutoSize = True
        Me.lblCustoTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblCustoTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustoTeorico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustoTeorico.Location = New System.Drawing.Point(6, 178)
        Me.lblCustoTeorico.Name = "lblCustoTeorico"
        Me.lblCustoTeorico.Size = New System.Drawing.Size(76, 14)
        Me.lblCustoTeorico.TabIndex = 36
        Me.lblCustoTeorico.Text = "Custo Teórico:"
        '
        'txtCustoTeorico
        '
        Me.txtCustoTeorico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoTeorico.DecimalDigits = 4
        Me.txtCustoTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustoTeorico.Location = New System.Drawing.Point(9, 196)
        Me.txtCustoTeorico.Name = "txtCustoTeorico"
        Me.txtCustoTeorico.Size = New System.Drawing.Size(99, 20)
        Me.txtCustoTeorico.TabIndex = 37
        Me.txtCustoTeorico.TabStop = False
        Me.txtCustoTeorico.Text = "0,0000"
        Me.txtCustoTeorico.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblCustoMedio
        '
        Me.lblCustoMedio.AutoSize = True
        Me.lblCustoMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblCustoMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustoMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustoMedio.Location = New System.Drawing.Point(6, 220)
        Me.lblCustoMedio.Name = "lblCustoMedio"
        Me.lblCustoMedio.Size = New System.Drawing.Size(105, 14)
        Me.lblCustoMedio.TabIndex = 51
        Me.lblCustoMedio.Text = "C.M. Base p/ Venda:"
        '
        'lblPrecoVendaMedio
        '
        Me.lblPrecoVendaMedio.AutoSize = True
        Me.lblPrecoVendaMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVendaMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoVendaMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrecoVendaMedio.Location = New System.Drawing.Point(465, 220)
        Me.lblPrecoVendaMedio.Name = "lblPrecoVendaMedio"
        Me.lblPrecoVendaMedio.Size = New System.Drawing.Size(72, 14)
        Me.lblPrecoVendaMedio.TabIndex = 61
        Me.lblPrecoVendaMedio.Text = "Preço Venda:"
        '
        'txtPrecoVendaMedio
        '
        Me.txtPrecoVendaMedio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecoVendaMedio.DecimalDigits = 4
        Me.txtPrecoVendaMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoVendaMedio.Location = New System.Drawing.Point(468, 238)
        Me.txtPrecoVendaMedio.Name = "txtPrecoVendaMedio"
        Me.txtPrecoVendaMedio.Size = New System.Drawing.Size(99, 20)
        Me.txtPrecoVendaMedio.TabIndex = 62
        Me.txtPrecoVendaMedio.Tag = "COLOR"
        Me.txtPrecoVendaMedio.Text = "0,0000"
        Me.txtPrecoVendaMedio.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblPrecoVendaTeorico
        '
        Me.lblPrecoVendaTeorico.AutoSize = True
        Me.lblPrecoVendaTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVendaTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoVendaTeorico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrecoVendaTeorico.Location = New System.Drawing.Point(465, 178)
        Me.lblPrecoVendaTeorico.Name = "lblPrecoVendaTeorico"
        Me.lblPrecoVendaTeorico.Size = New System.Drawing.Size(72, 14)
        Me.lblPrecoVendaTeorico.TabIndex = 46
        Me.lblPrecoVendaTeorico.Text = "Preço Venda:"
        '
        'txtPrecoVendaTeorico
        '
        Me.txtPrecoVendaTeorico.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecoVendaTeorico.DecimalDigits = 4
        Me.txtPrecoVendaTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoVendaTeorico.Location = New System.Drawing.Point(468, 196)
        Me.txtPrecoVendaTeorico.Name = "txtPrecoVendaTeorico"
        Me.txtPrecoVendaTeorico.Size = New System.Drawing.Size(99, 20)
        Me.txtPrecoVendaTeorico.TabIndex = 47
        Me.txtPrecoVendaTeorico.Tag = "COLOR"
        Me.txtPrecoVendaTeorico.Text = "0,0000"
        Me.txtPrecoVendaTeorico.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblGPTeorico
        '
        Me.lblGPTeorico.AutoSize = True
        Me.lblGPTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblGPTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPTeorico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGPTeorico.Location = New System.Drawing.Point(236, 178)
        Me.lblGPTeorico.Name = "lblGPTeorico"
        Me.lblGPTeorico.Size = New System.Drawing.Size(24, 14)
        Me.lblGPTeorico.TabIndex = 41
        Me.lblGPTeorico.Text = "GP:"
        '
        'txtGPTeorico
        '
        Me.txtGPTeorico.DecimalDigits = 2
        Me.txtGPTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGPTeorico.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtGPTeorico.Location = New System.Drawing.Point(239, 196)
        Me.txtGPTeorico.Name = "txtGPTeorico"
        Me.txtGPTeorico.Size = New System.Drawing.Size(99, 20)
        Me.txtGPTeorico.TabIndex = 42
        Me.txtGPTeorico.Text = "0,00%"
        Me.txtGPTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMargemTeorico
        '
        Me.lblMargemTeorico.AutoSize = True
        Me.lblMargemTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblMargemTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMargemTeorico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMargemTeorico.Location = New System.Drawing.Point(130, 178)
        Me.lblMargemTeorico.Name = "lblMargemTeorico"
        Me.lblMargemTeorico.Size = New System.Drawing.Size(48, 14)
        Me.lblMargemTeorico.TabIndex = 39
        Me.lblMargemTeorico.Text = "Margem:"
        '
        'txtMargemTeorico
        '
        Me.txtMargemTeorico.DecimalDigits = 2
        Me.txtMargemTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMargemTeorico.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtMargemTeorico.Location = New System.Drawing.Point(133, 196)
        Me.txtMargemTeorico.Name = "txtMargemTeorico"
        Me.txtMargemTeorico.Size = New System.Drawing.Size(99, 20)
        Me.txtMargemTeorico.TabIndex = 40
        Me.txtMargemTeorico.Text = "0,00%"
        Me.txtMargemTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtCustoMedio
        '
        Me.txtCustoMedio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoMedio.DecimalDigits = 4
        Me.txtCustoMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustoMedio.Location = New System.Drawing.Point(9, 238)
        Me.txtCustoMedio.Name = "txtCustoMedio"
        Me.txtCustoMedio.Size = New System.Drawing.Size(99, 20)
        Me.txtCustoMedio.TabIndex = 52
        Me.txtCustoMedio.TabStop = False
        Me.txtCustoMedio.Text = "0,0000"
        Me.txtCustoMedio.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQuantidade.Location = New System.Drawing.Point(360, 121)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 24
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 2
        Me.txtQuantidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(363, 139)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(99, 20)
        Me.txtQuantidade.TabIndex = 25
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtMunicipioUF
        '
        Me.txtMunicipioUF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMunicipioUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMunicipioUF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipioUF.Location = New System.Drawing.Point(573, 38)
        Me.txtMunicipioUF.MaxLength = 100
        Me.txtMunicipioUF.Name = "txtMunicipioUF"
        Me.txtMunicipioUF.ReadOnly = True
        Me.txtMunicipioUF.Size = New System.Drawing.Size(251, 20)
        Me.txtMunicipioUF.TabIndex = 3
        Me.txtMunicipioUF.TabStop = False
        '
        'lblMunicipioUF
        '
        Me.lblMunicipioUF.AutoSize = True
        Me.lblMunicipioUF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunicipioUF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMunicipioUF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipioUF.Location = New System.Drawing.Point(570, 20)
        Me.lblMunicipioUF.Name = "lblMunicipioUF"
        Me.lblMunicipioUF.Size = New System.Drawing.Size(77, 14)
        Me.lblMunicipioUF.TabIndex = 2
        Me.lblMunicipioUF.Text = "Município - UF:"
        '
        'cboCliente
        '
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.Location = New System.Drawing.Point(9, 38)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(558, 21)
        Me.cboCliente.TabIndex = 1
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCliente.Location = New System.Drawing.Point(6, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigo.Location = New System.Drawing.Point(6, 79)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 6
        Me.lblCodigo.Text = "Código:"
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(678, 97)
        Me.txtMarca.MaxLength = 100
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(146, 20)
        Me.txtMarca.TabIndex = 15
        Me.txtMarca.TabStop = False
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarca.Location = New System.Drawing.Point(675, 79)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 14)
        Me.lblMarca.TabIndex = 14
        Me.lblMarca.Text = "Marca:"
        '
        'lblEstoque
        '
        Me.lblEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstoque.AutoSize = True
        Me.lblEstoque.BackColor = System.Drawing.Color.Transparent
        Me.lblEstoque.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstoque.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEstoque.Location = New System.Drawing.Point(-151, 121)
        Me.lblEstoque.Name = "lblEstoque"
        Me.lblEstoque.Size = New System.Drawing.Size(49, 14)
        Me.lblEstoque.TabIndex = 16
        Me.lblEstoque.Text = "Estoque:"
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeEstoque.DecimalDigits = 2
        Me.txtQuantidadeEstoque.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(9, 139)
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.ReadOnly = True
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(99, 20)
        Me.txtQuantidadeEstoque.TabIndex = 17
        Me.txtQuantidadeEstoque.TabStop = False
        Me.txtQuantidadeEstoque.Text = "0,00"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(130, 79)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 8
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(133, 97)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(434, 20)
        Me.txtDescricao.TabIndex = 9
        Me.txtDescricao.TabStop = False
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.AutoSize = False
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoProduto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodigoProduto.Location = New System.Drawing.Point(9, 97)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProduto.Size = New System.Drawing.Size(118, 20)
        Me.cboCodigoProduto.TabIndex = 67
        '
        'frmCadProdutoPrecoVendaCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 374)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadProdutoPrecoVendaCalculadora"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produto - Calculadora"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        Me.pagDados.PerformLayout()
        CType(Me.grpPrecoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPrecoVenda.ResumeLayout(False)
        Me.grpPrecoVenda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtMarca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpPrecoVenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblEstoque As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMunicipioUF As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMunicipioUF As System.Windows.Forms.Label
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnAdicionarMedio As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAdicionarTeorico As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblMarkupMedio As System.Windows.Forms.Label
    Friend WithEvents txtMarkupMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMarkupTeorico As System.Windows.Forms.Label
    Friend WithEvents txtMarkupTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIgualMedio As System.Windows.Forms.Label
    Friend WithEvents lblIgualTeorico As System.Windows.Forms.Label
    Friend WithEvents lblMaisMedio As System.Windows.Forms.Label
    Friend WithEvents lblMaisTeorico As System.Windows.Forms.Label
    Friend WithEvents lblPrecoVendaUnidadeMedio As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaUnidadeMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVendaUnidadeTeorico As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaUnidadeTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblGPMedio As System.Windows.Forms.Label
    Friend WithEvents txtGPMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMargemMedio As System.Windows.Forms.Label
    Friend WithEvents txtMargemMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCustoTeorico As System.Windows.Forms.Label
    Friend WithEvents txtCustoTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCustoMedio As System.Windows.Forms.Label
    Friend WithEvents lblPrecoVendaMedio As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVendaTeorico As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblGPTeorico As System.Windows.Forms.Label
    Friend WithEvents txtGPTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMargemTeorico As System.Windows.Forms.Label
    Friend WithEvents txtMargemTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtCustoMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboDestinacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDestinacao As System.Windows.Forms.Label
    Friend WithEvents lblLine2 As System.Windows.Forms.Label
    Friend WithEvents lblLine1 As System.Windows.Forms.Label
    Friend WithEvents dtpPrevisaoEntregaProduto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblPrevisaoEntregaProduto As System.Windows.Forms.Label
    Friend WithEvents btnDesmembrarPrevisaoEntrega As System.Windows.Forms.Button
    Friend WithEvents lblQuantidadeUnidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeUnidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnEstoqueReservado As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblQuantidadeEstoqueReservado As System.Windows.Forms.Label
    Friend WithEvents txtEstoqueReservado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnPedidoCompraTransito As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPedidoCompraTransito As System.Windows.Forms.Label
    Friend WithEvents txtPedidoCompraTransito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnRev As System.Windows.Forms.Button
    Friend WithEvents txtSugestao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblFatorConversao As System.Windows.Forms.Label
    Friend WithEvents txtFatorConversao As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
