<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpPedidoCompra
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpPedidoCompra))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarMoeda = New System.Windows.Forms.Button()
        Me.lblFatorCambial = New System.Windows.Forms.Label()
        Me.txtFatorCambial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboMoeda = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMoeda = New System.Windows.Forms.Label()
        Me.btnCadastrarTransportadora = New System.Windows.Forms.Button()
        Me.cboTransportadora = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTransportadora = New System.Windows.Forms.Label()
        Me.btnCadastrarCondicaoPagamento = New System.Windows.Forms.Button()
        Me.lblValorFinal = New System.Windows.Forms.Label()
        Me.txtValorFinal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorICMS = New System.Windows.Forms.Label()
        Me.txtValorICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorIPI = New System.Windows.Forms.Label()
        Me.txtValorIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDesconto = New System.Windows.Forms.Label()
        Me.txtValorDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboFormaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.cboCondicaoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCondicaoPagamento = New System.Windows.Forms.Label()
        Me.lblValorFrete = New System.Windows.Forms.Label()
        Me.txtValorFrete = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboModalidadeFrete = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeFrete = New System.Windows.Forms.Label()
        Me.grpDadosItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFornecedor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        CType(Me.grpDadosItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosItem.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(7, 9)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(531, 382)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpProduto)
        Me.pagTabela.Controls.Add(Me.grpDadosItem)
        Me.pagTabela.Controls.Add(Me.grpControle)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(529, 359)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados das Cotações"
        '
        'grpProduto
        '
        Me.grpProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.btnCadastrarMoeda)
        Me.grpProduto.Controls.Add(Me.lblFatorCambial)
        Me.grpProduto.Controls.Add(Me.txtFatorCambial)
        Me.grpProduto.Controls.Add(Me.cboMoeda)
        Me.grpProduto.Controls.Add(Me.lblMoeda)
        Me.grpProduto.Controls.Add(Me.btnCadastrarTransportadora)
        Me.grpProduto.Controls.Add(Me.cboTransportadora)
        Me.grpProduto.Controls.Add(Me.lblTransportadora)
        Me.grpProduto.Controls.Add(Me.btnCadastrarCondicaoPagamento)
        Me.grpProduto.Controls.Add(Me.lblValorFinal)
        Me.grpProduto.Controls.Add(Me.txtValorFinal)
        Me.grpProduto.Controls.Add(Me.lblValorICMS)
        Me.grpProduto.Controls.Add(Me.txtValorICMS)
        Me.grpProduto.Controls.Add(Me.lblValorIPI)
        Me.grpProduto.Controls.Add(Me.txtValorIPI)
        Me.grpProduto.Controls.Add(Me.lblValorDesconto)
        Me.grpProduto.Controls.Add(Me.txtValorDesconto)
        Me.grpProduto.Controls.Add(Me.lblValorTotal)
        Me.grpProduto.Controls.Add(Me.txtValorTotal)
        Me.grpProduto.Controls.Add(Me.cboFormaPagamento)
        Me.grpProduto.Controls.Add(Me.lblFormaPagamento)
        Me.grpProduto.Controls.Add(Me.cboCondicaoPagamento)
        Me.grpProduto.Controls.Add(Me.lblCondicaoPagamento)
        Me.grpProduto.Controls.Add(Me.lblValorFrete)
        Me.grpProduto.Controls.Add(Me.txtValorFrete)
        Me.grpProduto.Controls.Add(Me.cboModalidadeFrete)
        Me.grpProduto.Controls.Add(Me.lblModalidadeFrete)
        Me.grpProduto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProduto.Location = New System.Drawing.Point(8, 70)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(513, 227)
        Me.grpProduto.TabIndex = 1
        Me.grpProduto.Text = "Dados do Pedido"
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarMoeda
        '
        Me.btnCadastrarMoeda.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMoeda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMoeda.Image = CType(resources.GetObject("btnCadastrarMoeda.Image"), System.Drawing.Image)
        Me.btnCadastrarMoeda.Location = New System.Drawing.Point(306, 21)
        Me.btnCadastrarMoeda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMoeda.Name = "btnCadastrarMoeda"
        Me.btnCadastrarMoeda.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMoeda.TabIndex = 26
        Me.btnCadastrarMoeda.TabStop = False
        Me.btnCadastrarMoeda.UseVisualStyleBackColor = True
        '
        'lblFatorCambial
        '
        Me.lblFatorCambial.AutoSize = True
        Me.lblFatorCambial.Location = New System.Drawing.Point(402, 20)
        Me.lblFatorCambial.Name = "lblFatorCambial"
        Me.lblFatorCambial.Size = New System.Drawing.Size(75, 14)
        Me.lblFatorCambial.TabIndex = 6
        Me.lblFatorCambial.Text = "Fator Cambial:"
        '
        'txtFatorCambial
        '
        Me.txtFatorCambial.DecimalDigits = 4
        Me.txtFatorCambial.Location = New System.Drawing.Point(405, 37)
        Me.txtFatorCambial.Name = "txtFatorCambial"
        Me.txtFatorCambial.Size = New System.Drawing.Size(99, 20)
        Me.txtFatorCambial.TabIndex = 7
        Me.txtFatorCambial.Text = "0,0000"
        Me.txtFatorCambial.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'cboMoeda
        '
        Me.cboMoeda.AutoSize = False
        Me.cboMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMoeda.Location = New System.Drawing.Point(306, 37)
        Me.cboMoeda.Name = "cboMoeda"
        Me.cboMoeda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMoeda.Size = New System.Drawing.Size(93, 20)
        Me.cboMoeda.TabIndex = 5
        '
        'lblMoeda
        '
        Me.lblMoeda.AutoSize = True
        Me.lblMoeda.Location = New System.Drawing.Point(322, 20)
        Me.lblMoeda.Name = "lblMoeda"
        Me.lblMoeda.Size = New System.Drawing.Size(42, 14)
        Me.lblMoeda.TabIndex = 4
        Me.lblMoeda.Text = "Moeda:"
        '
        'btnCadastrarTransportadora
        '
        Me.btnCadastrarTransportadora.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTransportadora.Image = CType(resources.GetObject("btnCadastrarTransportadora.Image"), System.Drawing.Image)
        Me.btnCadastrarTransportadora.Location = New System.Drawing.Point(9, 61)
        Me.btnCadastrarTransportadora.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTransportadora.Name = "btnCadastrarTransportadora"
        Me.btnCadastrarTransportadora.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTransportadora.TabIndex = 8
        Me.btnCadastrarTransportadora.TabStop = False
        Me.btnCadastrarTransportadora.UseVisualStyleBackColor = True
        '
        'cboTransportadora
        '
        Me.cboTransportadora.AutoSize = False
        Me.cboTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTransportadora.Location = New System.Drawing.Point(9, 77)
        Me.cboTransportadora.Name = "cboTransportadora"
        Me.cboTransportadora.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTransportadora.Size = New System.Drawing.Size(495, 20)
        Me.cboTransportadora.TabIndex = 10
        '
        'lblTransportadora
        '
        Me.lblTransportadora.AutoSize = True
        Me.lblTransportadora.Location = New System.Drawing.Point(25, 60)
        Me.lblTransportadora.Name = "lblTransportadora"
        Me.lblTransportadora.Size = New System.Drawing.Size(85, 14)
        Me.lblTransportadora.TabIndex = 9
        Me.lblTransportadora.Text = "Transportadora:"
        '
        'btnCadastrarCondicaoPagamento
        '
        Me.btnCadastrarCondicaoPagamento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCondicaoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCondicaoPagamento.Image = CType(resources.GetObject("btnCadastrarCondicaoPagamento.Image"), System.Drawing.Image)
        Me.btnCadastrarCondicaoPagamento.Location = New System.Drawing.Point(9, 101)
        Me.btnCadastrarCondicaoPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCondicaoPagamento.Name = "btnCadastrarCondicaoPagamento"
        Me.btnCadastrarCondicaoPagamento.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCondicaoPagamento.TabIndex = 11
        Me.btnCadastrarCondicaoPagamento.TabStop = False
        Me.btnCadastrarCondicaoPagamento.UseVisualStyleBackColor = True
        '
        'lblValorFinal
        '
        Me.lblValorFinal.AutoSize = True
        Me.lblValorFinal.Location = New System.Drawing.Point(402, 180)
        Me.lblValorFinal.Name = "lblValorFinal"
        Me.lblValorFinal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorFinal.TabIndex = 24
        Me.lblValorFinal.Text = "Valor Final:"
        '
        'txtValorFinal
        '
        Me.txtValorFinal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorFinal.Location = New System.Drawing.Point(405, 197)
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.ReadOnly = True
        Me.txtValorFinal.Size = New System.Drawing.Size(99, 20)
        Me.txtValorFinal.TabIndex = 25
        Me.txtValorFinal.TabStop = False
        Me.txtValorFinal.Text = "0,00"
        Me.txtValorFinal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorICMS
        '
        Me.lblValorICMS.AutoSize = True
        Me.lblValorICMS.Location = New System.Drawing.Point(303, 180)
        Me.lblValorICMS.Name = "lblValorICMS"
        Me.lblValorICMS.Size = New System.Drawing.Size(62, 14)
        Me.lblValorICMS.TabIndex = 22
        Me.lblValorICMS.Text = "Valor ICMS:"
        '
        'txtValorICMS
        '
        Me.txtValorICMS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorICMS.Location = New System.Drawing.Point(306, 197)
        Me.txtValorICMS.Name = "txtValorICMS"
        Me.txtValorICMS.ReadOnly = True
        Me.txtValorICMS.Size = New System.Drawing.Size(93, 20)
        Me.txtValorICMS.TabIndex = 23
        Me.txtValorICMS.TabStop = False
        Me.txtValorICMS.Text = "0,00"
        Me.txtValorICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorIPI
        '
        Me.lblValorIPI.AutoSize = True
        Me.lblValorIPI.Location = New System.Drawing.Point(204, 180)
        Me.lblValorIPI.Name = "lblValorIPI"
        Me.lblValorIPI.Size = New System.Drawing.Size(48, 14)
        Me.lblValorIPI.TabIndex = 20
        Me.lblValorIPI.Text = "Valor IPI:"
        '
        'txtValorIPI
        '
        Me.txtValorIPI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorIPI.Location = New System.Drawing.Point(207, 197)
        Me.txtValorIPI.Name = "txtValorIPI"
        Me.txtValorIPI.ReadOnly = True
        Me.txtValorIPI.Size = New System.Drawing.Size(93, 20)
        Me.txtValorIPI.TabIndex = 21
        Me.txtValorIPI.TabStop = False
        Me.txtValorIPI.Text = "0,00"
        Me.txtValorIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDesconto
        '
        Me.lblValorDesconto.AutoSize = True
        Me.lblValorDesconto.Location = New System.Drawing.Point(105, 180)
        Me.lblValorDesconto.Name = "lblValorDesconto"
        Me.lblValorDesconto.Size = New System.Drawing.Size(84, 14)
        Me.lblValorDesconto.TabIndex = 18
        Me.lblValorDesconto.Text = "Valor Desconto:"
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorDesconto.Location = New System.Drawing.Point(108, 197)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.ReadOnly = True
        Me.txtValorDesconto.Size = New System.Drawing.Size(93, 20)
        Me.txtValorDesconto.TabIndex = 19
        Me.txtValorDesconto.TabStop = False
        Me.txtValorDesconto.Text = "0,00"
        Me.txtValorDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(6, 180)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 16
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.Location = New System.Drawing.Point(9, 197)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(93, 20)
        Me.txtValorTotal.TabIndex = 17
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.AutoSize = False
        Me.cboFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaPagamento.Location = New System.Drawing.Point(9, 157)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaPagamento.Size = New System.Drawing.Size(495, 20)
        Me.cboFormaPagamento.TabIndex = 15
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(6, 140)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblFormaPagamento.TabIndex = 14
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'cboCondicaoPagamento
        '
        Me.cboCondicaoPagamento.AutoSize = False
        Me.cboCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCondicaoPagamento.Location = New System.Drawing.Point(9, 117)
        Me.cboCondicaoPagamento.Name = "cboCondicaoPagamento"
        Me.cboCondicaoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCondicaoPagamento.Size = New System.Drawing.Size(495, 20)
        Me.cboCondicaoPagamento.TabIndex = 13
        '
        'lblCondicaoPagamento
        '
        Me.lblCondicaoPagamento.AutoSize = True
        Me.lblCondicaoPagamento.Location = New System.Drawing.Point(25, 100)
        Me.lblCondicaoPagamento.Name = "lblCondicaoPagamento"
        Me.lblCondicaoPagamento.Size = New System.Drawing.Size(126, 14)
        Me.lblCondicaoPagamento.TabIndex = 12
        Me.lblCondicaoPagamento.Text = "Condição de Pagamento:"
        '
        'lblValorFrete
        '
        Me.lblValorFrete.AutoSize = True
        Me.lblValorFrete.Location = New System.Drawing.Point(204, 20)
        Me.lblValorFrete.Name = "lblValorFrete"
        Me.lblValorFrete.Size = New System.Drawing.Size(63, 14)
        Me.lblValorFrete.TabIndex = 2
        Me.lblValorFrete.Text = "Valor Frete:"
        '
        'txtValorFrete
        '
        Me.txtValorFrete.Location = New System.Drawing.Point(207, 37)
        Me.txtValorFrete.Name = "txtValorFrete"
        Me.txtValorFrete.Size = New System.Drawing.Size(93, 20)
        Me.txtValorFrete.TabIndex = 3
        Me.txtValorFrete.Text = "0,00"
        Me.txtValorFrete.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboModalidadeFrete
        '
        Me.cboModalidadeFrete.AutoSize = False
        Me.cboModalidadeFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeFrete.Location = New System.Drawing.Point(9, 37)
        Me.cboModalidadeFrete.Name = "cboModalidadeFrete"
        Me.cboModalidadeFrete.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeFrete.Size = New System.Drawing.Size(192, 20)
        Me.cboModalidadeFrete.TabIndex = 1
        '
        'lblModalidadeFrete
        '
        Me.lblModalidadeFrete.AutoSize = True
        Me.lblModalidadeFrete.Location = New System.Drawing.Point(6, 20)
        Me.lblModalidadeFrete.Name = "lblModalidadeFrete"
        Me.lblModalidadeFrete.Size = New System.Drawing.Size(107, 14)
        Me.lblModalidadeFrete.TabIndex = 0
        Me.lblModalidadeFrete.Text = "Modalidade de Frete:"
        '
        'grpDadosItem
        '
        Me.grpDadosItem.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosItem.Controls.Add(Me.txtFornecedor)
        Me.grpDadosItem.Controls.Add(Me.lblFornecedor)
        Me.grpDadosItem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosItem.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosItem.Name = "grpDadosItem"
        Me.grpDadosItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosItem.Size = New System.Drawing.Size(513, 64)
        Me.grpDadosItem.TabIndex = 0
        Me.grpDadosItem.VisualStyleManager = Me.vsmMain
        '
        'txtFornecedor
        '
        Me.txtFornecedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedor.Location = New System.Drawing.Point(9, 34)
        Me.txtFornecedor.MaxLength = 50
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.ReadOnly = True
        Me.txtFornecedor.Size = New System.Drawing.Size(495, 20)
        Me.txtFornecedor.TabIndex = 1
        Me.txtFornecedor.TabStop = False
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(6, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 0
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSalvar)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 300)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(513, 51)
        Me.grpControle.TabIndex = 2
        Me.grpControle.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(318, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(90, 23)
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
        Me.btnSair.Location = New System.Drawing.Point(414, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(90, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmCmpPedidoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 398)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCmpPedidoCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cotação - Orçamento"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        CType(Me.grpDadosItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosItem.ResumeLayout(False)
        Me.grpDadosItem.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtFornecedor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblModalidadeFrete As System.Windows.Forms.Label
    Friend WithEvents cboModalidadeFrete As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblValorFinal As System.Windows.Forms.Label
    Friend WithEvents txtValorFinal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorICMS As System.Windows.Forms.Label
    Friend WithEvents txtValorICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorIPI As System.Windows.Forms.Label
    Friend WithEvents txtValorIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDesconto As System.Windows.Forms.Label
    Friend WithEvents txtValorDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents cboCondicaoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCondicaoPagamento As System.Windows.Forms.Label
    Friend WithEvents lblValorFrete As System.Windows.Forms.Label
    Friend WithEvents txtValorFrete As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarTransportadora As System.Windows.Forms.Button
    Friend WithEvents cboTransportadora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTransportadora As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarCondicaoPagamento As System.Windows.Forms.Button
    Friend WithEvents lblFatorCambial As System.Windows.Forms.Label
    Friend WithEvents txtFatorCambial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboMoeda As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMoeda As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarMoeda As System.Windows.Forms.Button
End Class
