<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdOrdemProducaoProdutoFabricado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdOrdemProducaoProdutoFabricado))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroDesenhoRequisicaoOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDesenhoRequisicaoOrdemProducao = New System.Windows.Forms.Label()
        Me.txtCodigoProdutoClienteRequisicaoOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoClienteRequisicaoOrdemProducao = New System.Windows.Forms.Label()
        Me.lblDescricaoRequisicaoOrdemProducao = New System.Windows.Forms.Label()
        Me.txtDescricaoRequisicaoOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoRequisicaoOrdemProducao = New System.Windows.Forms.Label()
        Me.txtCodigoProdutoRequisicaoOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDetalheRequisicaoOrdemProducao = New System.Windows.Forms.Label()
        Me.lblQuantidadeRequisicaoOrdemProducao = New System.Windows.Forms.Label()
        Me.txtDetalheRequisicaoOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSubconjuntoRequisicaoOrdemProducao = New System.Windows.Forms.Label()
        Me.txtQuantidadeRequisicaoOrdemProducao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtSubconjuntoRequisicaoOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.btnProcurarProdutoRequisicao = New System.Windows.Forms.Button()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtQuantidadePlanejada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblQuantidadePlanejada = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvarRequisicao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(601, 373)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(599, 350)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Ordem de Produção"
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblObservacao)
        Me.grpDados.Controls.Add(Me.txtObservacao)
        Me.grpDados.Controls.Add(Me.txtNumeroDesenhoRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblNumeroDesenhoRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.txtCodigoProdutoClienteRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblCodigoProdutoClienteRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblDescricaoRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.txtDescricaoRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblCodigoProdutoRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.txtCodigoProdutoRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblDetalheRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblQuantidadeRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.txtDetalheRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblSubconjuntoRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.txtQuantidadeRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.txtSubconjuntoRequisicaoOrdemProducao)
        Me.grpDados.Controls.Add(Me.cboCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblCodigoProduto)
        Me.grpDados.Controls.Add(Me.btnProcurarProdutoRequisicao)
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.txtQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.lblQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(583, 279)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(7, 229)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 26
        Me.lblObservacao.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(10, 246)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(562, 20)
        Me.txtObservacao.TabIndex = 27
        Me.txtObservacao.TabStop = False
        '
        'txtNumeroDesenhoRequisicaoOrdemProducao
        '
        Me.txtNumeroDesenhoRequisicaoOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDesenhoRequisicaoOrdemProducao.Location = New System.Drawing.Point(103, 160)
        Me.txtNumeroDesenhoRequisicaoOrdemProducao.MaxLength = 60
        Me.txtNumeroDesenhoRequisicaoOrdemProducao.Name = "txtNumeroDesenhoRequisicaoOrdemProducao"
        Me.txtNumeroDesenhoRequisicaoOrdemProducao.Size = New System.Drawing.Size(199, 20)
        Me.txtNumeroDesenhoRequisicaoOrdemProducao.TabIndex = 19
        '
        'lblNumeroDesenhoRequisicaoOrdemProducao
        '
        Me.lblNumeroDesenhoRequisicaoOrdemProducao.AutoSize = True
        Me.lblNumeroDesenhoRequisicaoOrdemProducao.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroDesenhoRequisicaoOrdemProducao.Location = New System.Drawing.Point(100, 143)
        Me.lblNumeroDesenhoRequisicaoOrdemProducao.Name = "lblNumeroDesenhoRequisicaoOrdemProducao"
        Me.lblNumeroDesenhoRequisicaoOrdemProducao.Size = New System.Drawing.Size(68, 14)
        Me.lblNumeroDesenhoRequisicaoOrdemProducao.TabIndex = 18
        Me.lblNumeroDesenhoRequisicaoOrdemProducao.Text = "Nº Desenho:"
        '
        'txtCodigoProdutoClienteRequisicaoOrdemProducao
        '
        Me.txtCodigoProdutoClienteRequisicaoOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProdutoClienteRequisicaoOrdemProducao.Location = New System.Drawing.Point(308, 160)
        Me.txtCodigoProdutoClienteRequisicaoOrdemProducao.MaxLength = 60
        Me.txtCodigoProdutoClienteRequisicaoOrdemProducao.Name = "txtCodigoProdutoClienteRequisicaoOrdemProducao"
        Me.txtCodigoProdutoClienteRequisicaoOrdemProducao.Size = New System.Drawing.Size(264, 20)
        Me.txtCodigoProdutoClienteRequisicaoOrdemProducao.TabIndex = 21
        '
        'lblCodigoProdutoClienteRequisicaoOrdemProducao
        '
        Me.lblCodigoProdutoClienteRequisicaoOrdemProducao.AutoSize = True
        Me.lblCodigoProdutoClienteRequisicaoOrdemProducao.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoProdutoClienteRequisicaoOrdemProducao.Location = New System.Drawing.Point(305, 143)
        Me.lblCodigoProdutoClienteRequisicaoOrdemProducao.Name = "lblCodigoProdutoClienteRequisicaoOrdemProducao"
        Me.lblCodigoProdutoClienteRequisicaoOrdemProducao.Size = New System.Drawing.Size(107, 14)
        Me.lblCodigoProdutoClienteRequisicaoOrdemProducao.TabIndex = 20
        Me.lblCodigoProdutoClienteRequisicaoOrdemProducao.Text = "Cód. Produto Cliente:"
        '
        'lblDescricaoRequisicaoOrdemProducao
        '
        Me.lblDescricaoRequisicaoOrdemProducao.AutoSize = True
        Me.lblDescricaoRequisicaoOrdemProducao.Location = New System.Drawing.Point(169, 101)
        Me.lblDescricaoRequisicaoOrdemProducao.Name = "lblDescricaoRequisicaoOrdemProducao"
        Me.lblDescricaoRequisicaoOrdemProducao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoRequisicaoOrdemProducao.TabIndex = 14
        Me.lblDescricaoRequisicaoOrdemProducao.Text = "Descrição:"
        '
        'txtDescricaoRequisicaoOrdemProducao
        '
        Me.txtDescricaoRequisicaoOrdemProducao.Location = New System.Drawing.Point(172, 118)
        Me.txtDescricaoRequisicaoOrdemProducao.Name = "txtDescricaoRequisicaoOrdemProducao"
        Me.txtDescricaoRequisicaoOrdemProducao.Size = New System.Drawing.Size(400, 20)
        Me.txtDescricaoRequisicaoOrdemProducao.TabIndex = 15
        Me.txtDescricaoRequisicaoOrdemProducao.TabStop = False
        '
        'lblCodigoProdutoRequisicaoOrdemProducao
        '
        Me.lblCodigoProdutoRequisicaoOrdemProducao.AutoSize = True
        Me.lblCodigoProdutoRequisicaoOrdemProducao.Location = New System.Drawing.Point(6, 101)
        Me.lblCodigoProdutoRequisicaoOrdemProducao.Name = "lblCodigoProdutoRequisicaoOrdemProducao"
        Me.lblCodigoProdutoRequisicaoOrdemProducao.Size = New System.Drawing.Size(119, 14)
        Me.lblCodigoProdutoRequisicaoOrdemProducao.TabIndex = 12
        Me.lblCodigoProdutoRequisicaoOrdemProducao.Text = "Código Produto (Novo):"
        '
        'txtCodigoProdutoRequisicaoOrdemProducao
        '
        Me.txtCodigoProdutoRequisicaoOrdemProducao.Location = New System.Drawing.Point(9, 118)
        Me.txtCodigoProdutoRequisicaoOrdemProducao.Name = "txtCodigoProdutoRequisicaoOrdemProducao"
        Me.txtCodigoProdutoRequisicaoOrdemProducao.Size = New System.Drawing.Size(157, 20)
        Me.txtCodigoProdutoRequisicaoOrdemProducao.TabIndex = 13
        Me.txtCodigoProdutoRequisicaoOrdemProducao.TabStop = False
        '
        'lblDetalheRequisicaoOrdemProducao
        '
        Me.lblDetalheRequisicaoOrdemProducao.AutoSize = True
        Me.lblDetalheRequisicaoOrdemProducao.Location = New System.Drawing.Point(212, 186)
        Me.lblDetalheRequisicaoOrdemProducao.Name = "lblDetalheRequisicaoOrdemProducao"
        Me.lblDetalheRequisicaoOrdemProducao.Size = New System.Drawing.Size(76, 14)
        Me.lblDetalheRequisicaoOrdemProducao.TabIndex = 24
        Me.lblDetalheRequisicaoOrdemProducao.Text = "Detalhe (DET):"
        '
        'lblQuantidadeRequisicaoOrdemProducao
        '
        Me.lblQuantidadeRequisicaoOrdemProducao.AutoSize = True
        Me.lblQuantidadeRequisicaoOrdemProducao.Location = New System.Drawing.Point(7, 143)
        Me.lblQuantidadeRequisicaoOrdemProducao.Name = "lblQuantidadeRequisicaoOrdemProducao"
        Me.lblQuantidadeRequisicaoOrdemProducao.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeRequisicaoOrdemProducao.TabIndex = 16
        Me.lblQuantidadeRequisicaoOrdemProducao.Text = "Quantidade:"
        '
        'txtDetalheRequisicaoOrdemProducao
        '
        Me.txtDetalheRequisicaoOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalheRequisicaoOrdemProducao.Location = New System.Drawing.Point(214, 203)
        Me.txtDetalheRequisicaoOrdemProducao.MaxLength = 60
        Me.txtDetalheRequisicaoOrdemProducao.Name = "txtDetalheRequisicaoOrdemProducao"
        Me.txtDetalheRequisicaoOrdemProducao.Size = New System.Drawing.Size(196, 20)
        Me.txtDetalheRequisicaoOrdemProducao.TabIndex = 25
        '
        'lblSubconjuntoRequisicaoOrdemProducao
        '
        Me.lblSubconjuntoRequisicaoOrdemProducao.AutoSize = True
        Me.lblSubconjuntoRequisicaoOrdemProducao.Location = New System.Drawing.Point(7, 186)
        Me.lblSubconjuntoRequisicaoOrdemProducao.Name = "lblSubconjuntoRequisicaoOrdemProducao"
        Me.lblSubconjuntoRequisicaoOrdemProducao.Size = New System.Drawing.Size(95, 14)
        Me.lblSubconjuntoRequisicaoOrdemProducao.TabIndex = 22
        Me.lblSubconjuntoRequisicaoOrdemProducao.Text = "Subconjunto (SC):"
        '
        'txtQuantidadeRequisicaoOrdemProducao
        '
        Me.txtQuantidadeRequisicaoOrdemProducao.DecimalDigits = 2
        Me.txtQuantidadeRequisicaoOrdemProducao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtQuantidadeRequisicaoOrdemProducao.Location = New System.Drawing.Point(10, 160)
        Me.txtQuantidadeRequisicaoOrdemProducao.MaxLength = 0
        Me.txtQuantidadeRequisicaoOrdemProducao.Name = "txtQuantidadeRequisicaoOrdemProducao"
        Me.txtQuantidadeRequisicaoOrdemProducao.Size = New System.Drawing.Size(87, 20)
        Me.txtQuantidadeRequisicaoOrdemProducao.TabIndex = 17
        Me.txtQuantidadeRequisicaoOrdemProducao.Text = "0,00"
        Me.txtQuantidadeRequisicaoOrdemProducao.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtSubconjuntoRequisicaoOrdemProducao
        '
        Me.txtSubconjuntoRequisicaoOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubconjuntoRequisicaoOrdemProducao.Location = New System.Drawing.Point(9, 203)
        Me.txtSubconjuntoRequisicaoOrdemProducao.MaxLength = 60
        Me.txtSubconjuntoRequisicaoOrdemProducao.Name = "txtSubconjuntoRequisicaoOrdemProducao"
        Me.txtSubconjuntoRequisicaoOrdemProducao.Size = New System.Drawing.Size(199, 20)
        Me.txtSubconjuntoRequisicaoOrdemProducao.TabIndex = 23
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.AutoSize = False
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboCodigoProduto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCodigoProduto.Location = New System.Drawing.Point(9, 76)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProduto.Size = New System.Drawing.Size(563, 20)
        Me.cboCodigoProduto.TabIndex = 10
        Me.cboCodigoProduto.Tag = ""
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(6, 59)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(106, 14)
        Me.lblCodigoProduto.TabIndex = 9
        Me.lblCodigoProduto.Tag = ""
        Me.lblCodigoProduto.Text = "Produto Cadastrado:"
        '
        'btnProcurarProdutoRequisicao
        '
        Me.btnProcurarProdutoRequisicao.FlatAppearance.BorderSize = 0
        Me.btnProcurarProdutoRequisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProdutoRequisicao.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProdutoRequisicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProdutoRequisicao.Location = New System.Drawing.Point(555, 57)
        Me.btnProcurarProdutoRequisicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProdutoRequisicao.Name = "btnProcurarProdutoRequisicao"
        Me.btnProcurarProdutoRequisicao.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProdutoRequisicao.TabIndex = 11
        Me.btnProcurarProdutoRequisicao.TabStop = False
        Me.btnProcurarProdutoRequisicao.Tag = ""
        Me.btnProcurarProdutoRequisicao.UseVisualStyleBackColor = True
        '
        'txtProduto
        '
        Me.txtProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(145, 34)
        Me.txtProduto.MaxLength = 60
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(332, 20)
        Me.txtProduto.TabIndex = 3
        Me.txtProduto.TabStop = False
        '
        'txtQuantidadePlanejada
        '
        Me.txtQuantidadePlanejada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadePlanejada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadePlanejada.DecimalDigits = 4
        Me.txtQuantidadePlanejada.Location = New System.Drawing.Point(483, 34)
        Me.txtQuantidadePlanejada.Name = "txtQuantidadePlanejada"
        Me.txtQuantidadePlanejada.ReadOnly = True
        Me.txtQuantidadePlanejada.Size = New System.Drawing.Size(89, 20)
        Me.txtQuantidadePlanejada.TabIndex = 5
        Me.txtQuantidadePlanejada.TabStop = False
        Me.txtQuantidadePlanejada.Text = "0,0000"
        Me.txtQuantidadePlanejada.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(142, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(64, 14)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Produto Pai:"
        '
        'lblQuantidadePlanejada
        '
        Me.lblQuantidadePlanejada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadePlanejada.AutoSize = True
        Me.lblQuantidadePlanejada.Location = New System.Drawing.Point(480, 17)
        Me.lblQuantidadePlanejada.Name = "lblQuantidadePlanejada"
        Me.lblQuantidadePlanejada.Size = New System.Drawing.Size(53, 14)
        Me.lblQuantidadePlanejada.TabIndex = 4
        Me.lblQuantidadePlanejada.Text = "Qtde. Pai:"
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducao.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemProducao.MaxLength = 20
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.Size = New System.Drawing.Size(130, 20)
        Me.txtOrdemProducao.TabIndex = 1
        Me.txtOrdemProducao.TabStop = False
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(108, 14)
        Me.lblOrdemProducao.TabIndex = 0
        Me.lblOrdemProducao.Text = "Ordem Produção Pai:"
        '
        'grpControl2
        '
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvarRequisicao)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 288)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(583, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvarRequisicao
        '
        Me.btnSalvarRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarRequisicao.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarRequisicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarRequisicao.Location = New System.Drawing.Point(386, 17)
        Me.btnSalvarRequisicao.Name = "btnSalvarRequisicao"
        Me.btnSalvarRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarRequisicao.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvarRequisicao.TabIndex = 0
        Me.btnSalvarRequisicao.Text = "Salvar"
        Me.btnSalvarRequisicao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(483, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 1
        Me.jstTip.BodyWidth = 400
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 1
        Me.jstTip.ShowAlways = True
        '
        'frmPrdOrdemProducaoProdutoFabricado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 387)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrdOrdemProducaoProdutoFabricado"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ordem de Produção - Inserir Ordem de Produção"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
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
    Friend WithEvents txtQuantidadePlanejada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadePlanejada As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents btnProcurarProdutoRequisicao As System.Windows.Forms.Button
    Friend WithEvents btnSalvarRequisicao As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents txtNumeroDesenhoRequisicaoOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDesenhoRequisicaoOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProdutoClienteRequisicaoOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoClienteRequisicaoOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents lblDescricaoRequisicaoOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoRequisicaoOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoRequisicaoOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProdutoRequisicaoOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDetalheRequisicaoOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRequisicaoOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents txtDetalheRequisicaoOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSubconjuntoRequisicaoOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeRequisicaoOrdemProducao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtSubconjuntoRequisicaoOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
End Class
