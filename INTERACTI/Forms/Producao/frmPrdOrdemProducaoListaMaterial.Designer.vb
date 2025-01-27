<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdOrdemProducaoListaMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdOrdemProducaoListaMaterial))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroDesenho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDesenho = New System.Windows.Forms.Label()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.grpCorteMaterial = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblQuantidadeCorte = New System.Windows.Forms.Label()
        Me.txtQuantidadeCorte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCodigoProdutoNovoCorte = New System.Windows.Forms.Label()
        Me.txtProdutoNovoCorte = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoCorte = New System.Windows.Forms.Label()
        Me.txtDescricaoCorte = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPesoEspecificoCorte = New System.Windows.Forms.Label()
        Me.txtPesoEspecificoCorte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPesoCorte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPesoCorte = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaCorte = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaCorte = New System.Windows.Forms.Label()
        Me.txtMedida1Corte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida3Corte = New System.Windows.Forms.Label()
        Me.txtMedida2Corte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMedida3Corte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida2Corte = New System.Windows.Forms.Label()
        Me.lblMedida4Corte = New System.Windows.Forms.Label()
        Me.txtMedida4Corte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida1Corte = New System.Windows.Forms.Label()
        Me.cboTipoRequisicao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoRequisicao = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaEstoque = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaEstoque = New System.Windows.Forms.Label()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.txtQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblObservacaoInterna = New System.Windows.Forms.Label()
        Me.txtObservacaoInterna = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataNecessidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataNecessidade = New System.Windows.Forms.Label()
        Me.txtMedida1 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeRequisicaoListaMaterial = New System.Windows.Forms.Label()
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial = New System.Windows.Forms.Label()
        Me.txtQuantidadeRequisicaoListaMaterial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtCodigoProdutoNovoRequisicaoListaMaterial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMedida3 = New System.Windows.Forms.Label()
        Me.lblDescricaoRequisicaoListaMaterial = New System.Windows.Forms.Label()
        Me.txtDescricaoRequisicaoListaMaterial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtMedida2 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.cboGrupoItemRequisicaoListaMaterial = New Janus.Windows.EditControls.UIComboBox()
        Me.cboCodigoProdutoRequisicaoListaMaterial = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProdutoRequisicaoListaMaterial = New System.Windows.Forms.Label()
        Me.lblGrupoItemRequisicaoListaMaterial = New System.Windows.Forms.Label()
        Me.txtMedida3 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida2 = New System.Windows.Forms.Label()
        Me.lblMedida4 = New System.Windows.Forms.Label()
        Me.txtMedida4 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida1 = New System.Windows.Forms.Label()
        Me.lblPesoEspecifico = New System.Windows.Forms.Label()
        Me.txtPesoEspecifico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPeso = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnFindGrupoItem = New System.Windows.Forms.Button()
        Me.lblPeso = New System.Windows.Forms.Label()
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
        CType(Me.grpCorteMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCorteMaterial.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(635, 584)
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
        Me.pagTabela.Size = New System.Drawing.Size(633, 561)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Lista de Material"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtNumeroDesenho)
        Me.grpDados.Controls.Add(Me.lblNumeroDesenho)
        Me.grpDados.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDados.Controls.Add(Me.grpCorteMaterial)
        Me.grpDados.Controls.Add(Me.cboTipoRequisicao)
        Me.grpDados.Controls.Add(Me.lblTipoRequisicao)
        Me.grpDados.Controls.Add(Me.cboUnidadeMedidaEstoque)
        Me.grpDados.Controls.Add(Me.lblUnidadeMedidaEstoque)
        Me.grpDados.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpDados.Controls.Add(Me.txtQuantidadeEstoque)
        Me.grpDados.Controls.Add(Me.lblObservacaoInterna)
        Me.grpDados.Controls.Add(Me.txtObservacaoInterna)
        Me.grpDados.Controls.Add(Me.lblObservacao)
        Me.grpDados.Controls.Add(Me.txtObservacao)
        Me.grpDados.Controls.Add(Me.dtpDataNecessidade)
        Me.grpDados.Controls.Add(Me.lblDataNecessidade)
        Me.grpDados.Controls.Add(Me.txtMedida1)
        Me.grpDados.Controls.Add(Me.lblQuantidadeRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.lblCodigoProdutoNovoRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.txtQuantidadeRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.txtCodigoProdutoNovoRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.lblMedida3)
        Me.grpDados.Controls.Add(Me.lblDescricaoRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.txtDescricaoRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.txtMedida2)
        Me.grpDados.Controls.Add(Me.cboUnidadeMedida)
        Me.grpDados.Controls.Add(Me.cboGrupoItemRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.cboCodigoProdutoRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.lblCodigoProdutoRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.lblGrupoItemRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.txtMedida3)
        Me.grpDados.Controls.Add(Me.lblMedida2)
        Me.grpDados.Controls.Add(Me.lblMedida4)
        Me.grpDados.Controls.Add(Me.txtMedida4)
        Me.grpDados.Controls.Add(Me.lblMedida1)
        Me.grpDados.Controls.Add(Me.lblPesoEspecifico)
        Me.grpDados.Controls.Add(Me.txtPesoEspecifico)
        Me.grpDados.Controls.Add(Me.txtPeso)
        Me.grpDados.Controls.Add(Me.btnFindGrupoItem)
        Me.grpDados.Controls.Add(Me.lblPeso)
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.txtQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.lblQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(621, 496)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroDesenho
        '
        Me.txtNumeroDesenho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroDesenho.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDesenho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDesenho.Location = New System.Drawing.Point(343, 34)
        Me.txtNumeroDesenho.MaxLength = 60
        Me.txtNumeroDesenho.Name = "txtNumeroDesenho"
        Me.txtNumeroDesenho.ReadOnly = True
        Me.txtNumeroDesenho.Size = New System.Drawing.Size(158, 20)
        Me.txtNumeroDesenho.TabIndex = 48
        Me.txtNumeroDesenho.TabStop = False
        '
        'lblNumeroDesenho
        '
        Me.lblNumeroDesenho.AutoSize = True
        Me.lblNumeroDesenho.Location = New System.Drawing.Point(340, 17)
        Me.lblNumeroDesenho.Name = "lblNumeroDesenho"
        Me.lblNumeroDesenho.Size = New System.Drawing.Size(68, 14)
        Me.lblNumeroDesenho.TabIndex = 47
        Me.lblNumeroDesenho.Text = "Nº Desenho:"
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.ForeColor = System.Drawing.Color.Firebrick
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(449, 178)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(71, 14)
        Me.lblUnidadeMedida.TabIndex = 46
        Me.lblUnidadeMedida.Tag = ""
        Me.lblUnidadeMedida.Text = "Unid. Medida:"
        '
        'grpCorteMaterial
        '
        Me.grpCorteMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCorteMaterial.BackColor = System.Drawing.Color.Transparent
        Me.grpCorteMaterial.Controls.Add(Me.lblQuantidadeCorte)
        Me.grpCorteMaterial.Controls.Add(Me.txtQuantidadeCorte)
        Me.grpCorteMaterial.Controls.Add(Me.lblCodigoProdutoNovoCorte)
        Me.grpCorteMaterial.Controls.Add(Me.txtProdutoNovoCorte)
        Me.grpCorteMaterial.Controls.Add(Me.lblDescricaoCorte)
        Me.grpCorteMaterial.Controls.Add(Me.txtDescricaoCorte)
        Me.grpCorteMaterial.Controls.Add(Me.lblPesoEspecificoCorte)
        Me.grpCorteMaterial.Controls.Add(Me.txtPesoEspecificoCorte)
        Me.grpCorteMaterial.Controls.Add(Me.txtPesoCorte)
        Me.grpCorteMaterial.Controls.Add(Me.lblPesoCorte)
        Me.grpCorteMaterial.Controls.Add(Me.cboUnidadeMedidaCorte)
        Me.grpCorteMaterial.Controls.Add(Me.lblUnidadeMedidaCorte)
        Me.grpCorteMaterial.Controls.Add(Me.txtMedida1Corte)
        Me.grpCorteMaterial.Controls.Add(Me.lblMedida3Corte)
        Me.grpCorteMaterial.Controls.Add(Me.txtMedida2Corte)
        Me.grpCorteMaterial.Controls.Add(Me.txtMedida3Corte)
        Me.grpCorteMaterial.Controls.Add(Me.lblMedida2Corte)
        Me.grpCorteMaterial.Controls.Add(Me.lblMedida4Corte)
        Me.grpCorteMaterial.Controls.Add(Me.txtMedida4Corte)
        Me.grpCorteMaterial.Controls.Add(Me.lblMedida1Corte)
        Me.grpCorteMaterial.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCorteMaterial.Location = New System.Drawing.Point(9, 261)
        Me.grpCorteMaterial.Name = "grpCorteMaterial"
        Me.grpCorteMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCorteMaterial.Size = New System.Drawing.Size(601, 144)
        Me.grpCorteMaterial.TabIndex = 45
        Me.grpCorteMaterial.Text = "Corte"
        Me.grpCorteMaterial.VisualStyleManager = Me.vsmMain
        '
        'lblQuantidadeCorte
        '
        Me.lblQuantidadeCorte.AutoSize = True
        Me.lblQuantidadeCorte.ForeColor = System.Drawing.Color.Firebrick
        Me.lblQuantidadeCorte.Location = New System.Drawing.Point(449, 16)
        Me.lblQuantidadeCorte.Name = "lblQuantidadeCorte"
        Me.lblQuantidadeCorte.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeCorte.TabIndex = 45
        Me.lblQuantidadeCorte.Text = "Quantidade:"
        '
        'txtQuantidadeCorte
        '
        Me.txtQuantidadeCorte.DecimalDigits = 2
        Me.txtQuantidadeCorte.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtQuantidadeCorte.Location = New System.Drawing.Point(452, 33)
        Me.txtQuantidadeCorte.MaxLength = 0
        Me.txtQuantidadeCorte.Name = "txtQuantidadeCorte"
        Me.txtQuantidadeCorte.Size = New System.Drawing.Size(143, 20)
        Me.txtQuantidadeCorte.TabIndex = 0
        Me.txtQuantidadeCorte.Text = "0,00"
        Me.txtQuantidadeCorte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCodigoProdutoNovoCorte
        '
        Me.lblCodigoProdutoNovoCorte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoProdutoNovoCorte.AutoSize = True
        Me.lblCodigoProdutoNovoCorte.Location = New System.Drawing.Point(6, 16)
        Me.lblCodigoProdutoNovoCorte.Name = "lblCodigoProdutoNovoCorte"
        Me.lblCodigoProdutoNovoCorte.Size = New System.Drawing.Size(119, 14)
        Me.lblCodigoProdutoNovoCorte.TabIndex = 43
        Me.lblCodigoProdutoNovoCorte.Text = "Código Produto (Novo):"
        '
        'txtProdutoNovoCorte
        '
        Me.txtProdutoNovoCorte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdutoNovoCorte.Location = New System.Drawing.Point(9, 33)
        Me.txtProdutoNovoCorte.Name = "txtProdutoNovoCorte"
        Me.txtProdutoNovoCorte.Size = New System.Drawing.Size(437, 20)
        Me.txtProdutoNovoCorte.TabIndex = 44
        Me.txtProdutoNovoCorte.TabStop = False
        '
        'lblDescricaoCorte
        '
        Me.lblDescricaoCorte.AutoSize = True
        Me.lblDescricaoCorte.Location = New System.Drawing.Point(231, 96)
        Me.lblDescricaoCorte.Name = "lblDescricaoCorte"
        Me.lblDescricaoCorte.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoCorte.TabIndex = 41
        Me.lblDescricaoCorte.Text = "Descrição:"
        '
        'txtDescricaoCorte
        '
        Me.txtDescricaoCorte.Location = New System.Drawing.Point(234, 113)
        Me.txtDescricaoCorte.Name = "txtDescricaoCorte"
        Me.txtDescricaoCorte.Size = New System.Drawing.Size(361, 20)
        Me.txtDescricaoCorte.TabIndex = 9
        '
        'lblPesoEspecificoCorte
        '
        Me.lblPesoEspecificoCorte.AutoSize = True
        Me.lblPesoEspecificoCorte.Location = New System.Drawing.Point(6, 96)
        Me.lblPesoEspecificoCorte.Name = "lblPesoEspecificoCorte"
        Me.lblPesoEspecificoCorte.Size = New System.Drawing.Size(87, 14)
        Me.lblPesoEspecificoCorte.TabIndex = 37
        Me.lblPesoEspecificoCorte.Tag = ""
        Me.lblPesoEspecificoCorte.Text = "Peso Específico:"
        '
        'txtPesoEspecificoCorte
        '
        Me.txtPesoEspecificoCorte.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPesoEspecificoCorte.DecimalDigits = 2
        Me.txtPesoEspecificoCorte.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPesoEspecificoCorte.Location = New System.Drawing.Point(9, 113)
        Me.txtPesoEspecificoCorte.MaxLength = 0
        Me.txtPesoEspecificoCorte.Name = "txtPesoEspecificoCorte"
        Me.txtPesoEspecificoCorte.Size = New System.Drawing.Size(103, 20)
        Me.txtPesoEspecificoCorte.TabIndex = 7
        Me.txtPesoEspecificoCorte.TabStop = False
        Me.txtPesoEspecificoCorte.Tag = ""
        Me.txtPesoEspecificoCorte.Text = "0,00"
        Me.txtPesoEspecificoCorte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtPesoCorte
        '
        Me.txtPesoCorte.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPesoCorte.DecimalDigits = 4
        Me.txtPesoCorte.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPesoCorte.Location = New System.Drawing.Point(118, 113)
        Me.txtPesoCorte.MaxLength = 0
        Me.txtPesoCorte.Name = "txtPesoCorte"
        Me.txtPesoCorte.ReadOnly = True
        Me.txtPesoCorte.Size = New System.Drawing.Size(110, 20)
        Me.txtPesoCorte.TabIndex = 8
        Me.txtPesoCorte.Tag = ""
        Me.txtPesoCorte.Text = "0,0000"
        Me.txtPesoCorte.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblPesoCorte
        '
        Me.lblPesoCorte.AutoSize = True
        Me.lblPesoCorte.Location = New System.Drawing.Point(117, 96)
        Me.lblPesoCorte.Name = "lblPesoCorte"
        Me.lblPesoCorte.Size = New System.Drawing.Size(34, 14)
        Me.lblPesoCorte.TabIndex = 39
        Me.lblPesoCorte.Tag = ""
        Me.lblPesoCorte.Text = "Peso:"
        '
        'cboUnidadeMedidaCorte
        '
        Me.cboUnidadeMedidaCorte.AutoSize = False
        Me.cboUnidadeMedidaCorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaCorte.Location = New System.Drawing.Point(452, 73)
        Me.cboUnidadeMedidaCorte.Name = "cboUnidadeMedidaCorte"
        Me.cboUnidadeMedidaCorte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaCorte.Size = New System.Drawing.Size(143, 20)
        Me.cboUnidadeMedidaCorte.TabIndex = 5
        Me.cboUnidadeMedidaCorte.Tag = ""
        '
        'lblUnidadeMedidaCorte
        '
        Me.lblUnidadeMedidaCorte.AutoSize = True
        Me.lblUnidadeMedidaCorte.ForeColor = System.Drawing.Color.Firebrick
        Me.lblUnidadeMedidaCorte.Location = New System.Drawing.Point(449, 56)
        Me.lblUnidadeMedidaCorte.Name = "lblUnidadeMedidaCorte"
        Me.lblUnidadeMedidaCorte.Size = New System.Drawing.Size(71, 14)
        Me.lblUnidadeMedidaCorte.TabIndex = 35
        Me.lblUnidadeMedidaCorte.Tag = ""
        Me.lblUnidadeMedidaCorte.Text = "Unid. Medida:"
        '
        'txtMedida1Corte
        '
        Me.txtMedida1Corte.DecimalDigits = 2
        Me.txtMedida1Corte.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida1Corte.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida1Corte.FormatString = "0.00"
        Me.txtMedida1Corte.Location = New System.Drawing.Point(9, 73)
        Me.txtMedida1Corte.MaxLength = 0
        Me.txtMedida1Corte.Name = "txtMedida1Corte"
        Me.txtMedida1Corte.Size = New System.Drawing.Size(103, 20)
        Me.txtMedida1Corte.TabIndex = 1
        Me.txtMedida1Corte.Tag = ""
        Me.txtMedida1Corte.Text = "0,00"
        Me.txtMedida1Corte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida3Corte
        '
        Me.lblMedida3Corte.AutoSize = True
        Me.lblMedida3Corte.Location = New System.Drawing.Point(231, 56)
        Me.lblMedida3Corte.Name = "lblMedida3Corte"
        Me.lblMedida3Corte.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida3Corte.TabIndex = 31
        Me.lblMedida3Corte.Tag = ""
        Me.lblMedida3Corte.Text = "Medida 3:"
        '
        'txtMedida2Corte
        '
        Me.txtMedida2Corte.DecimalDigits = 2
        Me.txtMedida2Corte.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida2Corte.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida2Corte.FormatString = "0.00"
        Me.txtMedida2Corte.Location = New System.Drawing.Point(118, 73)
        Me.txtMedida2Corte.MaxLength = 0
        Me.txtMedida2Corte.Name = "txtMedida2Corte"
        Me.txtMedida2Corte.Size = New System.Drawing.Size(110, 20)
        Me.txtMedida2Corte.TabIndex = 2
        Me.txtMedida2Corte.Tag = ""
        Me.txtMedida2Corte.Text = "0,00"
        Me.txtMedida2Corte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtMedida3Corte
        '
        Me.txtMedida3Corte.DecimalDigits = 2
        Me.txtMedida3Corte.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida3Corte.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida3Corte.FormatString = "0.00"
        Me.txtMedida3Corte.Location = New System.Drawing.Point(234, 73)
        Me.txtMedida3Corte.MaxLength = 0
        Me.txtMedida3Corte.Name = "txtMedida3Corte"
        Me.txtMedida3Corte.Size = New System.Drawing.Size(103, 20)
        Me.txtMedida3Corte.TabIndex = 3
        Me.txtMedida3Corte.Tag = ""
        Me.txtMedida3Corte.Text = "0,00"
        Me.txtMedida3Corte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida2Corte
        '
        Me.lblMedida2Corte.AutoSize = True
        Me.lblMedida2Corte.Location = New System.Drawing.Point(115, 56)
        Me.lblMedida2Corte.Name = "lblMedida2Corte"
        Me.lblMedida2Corte.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida2Corte.TabIndex = 29
        Me.lblMedida2Corte.Tag = ""
        Me.lblMedida2Corte.Text = "Medida 2:"
        '
        'lblMedida4Corte
        '
        Me.lblMedida4Corte.AutoSize = True
        Me.lblMedida4Corte.Location = New System.Drawing.Point(342, 56)
        Me.lblMedida4Corte.Name = "lblMedida4Corte"
        Me.lblMedida4Corte.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida4Corte.TabIndex = 33
        Me.lblMedida4Corte.Tag = ""
        Me.lblMedida4Corte.Text = "Medida 4:"
        '
        'txtMedida4Corte
        '
        Me.txtMedida4Corte.DecimalDigits = 2
        Me.txtMedida4Corte.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida4Corte.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida4Corte.FormatString = "0.00"
        Me.txtMedida4Corte.Location = New System.Drawing.Point(343, 73)
        Me.txtMedida4Corte.MaxLength = 0
        Me.txtMedida4Corte.Name = "txtMedida4Corte"
        Me.txtMedida4Corte.Size = New System.Drawing.Size(103, 20)
        Me.txtMedida4Corte.TabIndex = 4
        Me.txtMedida4Corte.Tag = ""
        Me.txtMedida4Corte.Text = "0,00"
        Me.txtMedida4Corte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida1Corte
        '
        Me.lblMedida1Corte.AutoSize = True
        Me.lblMedida1Corte.Location = New System.Drawing.Point(6, 56)
        Me.lblMedida1Corte.Name = "lblMedida1Corte"
        Me.lblMedida1Corte.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida1Corte.TabIndex = 27
        Me.lblMedida1Corte.Tag = ""
        Me.lblMedida1Corte.Text = "Medida 1:"
        '
        'cboTipoRequisicao
        '
        Me.cboTipoRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoRequisicao.AutoSize = False
        Me.cboTipoRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoRequisicao.Enabled = False
        Me.cboTipoRequisicao.Location = New System.Drawing.Point(452, 73)
        Me.cboTipoRequisicao.Name = "cboTipoRequisicao"
        Me.cboTipoRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoRequisicao.Size = New System.Drawing.Size(158, 20)
        Me.cboTipoRequisicao.TabIndex = 0
        Me.cboTipoRequisicao.Tag = ""
        '
        'lblTipoRequisicao
        '
        Me.lblTipoRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoRequisicao.AutoSize = True
        Me.lblTipoRequisicao.ForeColor = System.Drawing.Color.Firebrick
        Me.lblTipoRequisicao.Location = New System.Drawing.Point(449, 56)
        Me.lblTipoRequisicao.Name = "lblTipoRequisicao"
        Me.lblTipoRequisicao.Size = New System.Drawing.Size(101, 14)
        Me.lblTipoRequisicao.TabIndex = 43
        Me.lblTipoRequisicao.Tag = ""
        Me.lblTipoRequisicao.Text = "Tipo de Requisição:"
        '
        'cboUnidadeMedidaEstoque
        '
        Me.cboUnidadeMedidaEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUnidadeMedidaEstoque.AutoSize = False
        Me.cboUnidadeMedidaEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaEstoque.Enabled = False
        Me.cboUnidadeMedidaEstoque.Location = New System.Drawing.Point(531, 115)
        Me.cboUnidadeMedidaEstoque.Name = "cboUnidadeMedidaEstoque"
        Me.cboUnidadeMedidaEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaEstoque.Size = New System.Drawing.Size(79, 20)
        Me.cboUnidadeMedidaEstoque.TabIndex = 42
        Me.cboUnidadeMedidaEstoque.Tag = ""
        '
        'lblUnidadeMedidaEstoque
        '
        Me.lblUnidadeMedidaEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnidadeMedidaEstoque.AutoSize = True
        Me.lblUnidadeMedidaEstoque.Location = New System.Drawing.Point(528, 98)
        Me.lblUnidadeMedidaEstoque.Name = "lblUnidadeMedidaEstoque"
        Me.lblUnidadeMedidaEstoque.Size = New System.Drawing.Size(76, 14)
        Me.lblUnidadeMedidaEstoque.TabIndex = 41
        Me.lblUnidadeMedidaEstoque.Tag = ""
        Me.lblUnidadeMedidaEstoque.Text = "Unid. Estoque:"
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(449, 98)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(75, 14)
        Me.lblQuantidadeEstoque.TabIndex = 39
        Me.lblQuantidadeEstoque.Text = "Qtde Estoque:"
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeEstoque.DecimalDigits = 2
        Me.txtQuantidadeEstoque.Enabled = False
        Me.txtQuantidadeEstoque.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(452, 115)
        Me.txtQuantidadeEstoque.MaxLength = 0
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(73, 20)
        Me.txtQuantidadeEstoque.TabIndex = 40
        Me.txtQuantidadeEstoque.Text = "0,00"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblObservacaoInterna
        '
        Me.lblObservacaoInterna.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblObservacaoInterna.AutoSize = True
        Me.lblObservacaoInterna.Location = New System.Drawing.Point(6, 449)
        Me.lblObservacaoInterna.Name = "lblObservacaoInterna"
        Me.lblObservacaoInterna.Size = New System.Drawing.Size(106, 14)
        Me.lblObservacaoInterna.TabIndex = 37
        Me.lblObservacaoInterna.Text = "Observação Interna:"
        '
        'txtObservacaoInterna
        '
        Me.txtObservacaoInterna.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoInterna.Location = New System.Drawing.Point(9, 466)
        Me.txtObservacaoInterna.Name = "txtObservacaoInterna"
        Me.txtObservacaoInterna.Size = New System.Drawing.Size(601, 20)
        Me.txtObservacaoInterna.TabIndex = 11
        '
        'lblObservacao
        '
        Me.lblObservacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 408)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 35
        Me.lblObservacao.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.Location = New System.Drawing.Point(9, 425)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(601, 20)
        Me.txtObservacao.TabIndex = 10
        '
        'dtpDataNecessidade
        '
        '
        '
        '
        Me.dtpDataNecessidade.DropDownCalendar.Name = ""
        Me.dtpDataNecessidade.Location = New System.Drawing.Point(452, 155)
        Me.dtpDataNecessidade.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpDataNecessidade.Name = "dtpDataNecessidade"
        Me.dtpDataNecessidade.Size = New System.Drawing.Size(158, 20)
        Me.dtpDataNecessidade.TabIndex = 3
        Me.dtpDataNecessidade.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'lblDataNecessidade
        '
        Me.lblDataNecessidade.AutoSize = True
        Me.lblDataNecessidade.Location = New System.Drawing.Point(449, 138)
        Me.lblDataNecessidade.Name = "lblDataNecessidade"
        Me.lblDataNecessidade.Size = New System.Drawing.Size(98, 14)
        Me.lblDataNecessidade.TabIndex = 16
        Me.lblDataNecessidade.Text = "Data Necessidade:"
        '
        'txtMedida1
        '
        Me.txtMedida1.DecimalDigits = 2
        Me.txtMedida1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida1.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida1.FormatString = "0.00"
        Me.txtMedida1.Location = New System.Drawing.Point(9, 195)
        Me.txtMedida1.MaxLength = 0
        Me.txtMedida1.Name = "txtMedida1"
        Me.txtMedida1.Size = New System.Drawing.Size(103, 20)
        Me.txtMedida1.TabIndex = 4
        Me.txtMedida1.Tag = ""
        Me.txtMedida1.Text = "0,00"
        Me.txtMedida1.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidadeRequisicaoListaMaterial
        '
        Me.lblQuantidadeRequisicaoListaMaterial.AutoSize = True
        Me.lblQuantidadeRequisicaoListaMaterial.ForeColor = System.Drawing.Color.Firebrick
        Me.lblQuantidadeRequisicaoListaMaterial.Location = New System.Drawing.Point(340, 138)
        Me.lblQuantidadeRequisicaoListaMaterial.Name = "lblQuantidadeRequisicaoListaMaterial"
        Me.lblQuantidadeRequisicaoListaMaterial.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeRequisicaoListaMaterial.TabIndex = 14
        Me.lblQuantidadeRequisicaoListaMaterial.Text = "Quantidade:"
        '
        'lblCodigoProdutoNovoRequisicaoListaMaterial
        '
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.AutoSize = True
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.Location = New System.Drawing.Point(6, 138)
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.Name = "lblCodigoProdutoNovoRequisicaoListaMaterial"
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.Size = New System.Drawing.Size(119, 14)
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.TabIndex = 12
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.Text = "Código Produto (Novo):"
        '
        'txtQuantidadeRequisicaoListaMaterial
        '
        Me.txtQuantidadeRequisicaoListaMaterial.DecimalDigits = 2
        Me.txtQuantidadeRequisicaoListaMaterial.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtQuantidadeRequisicaoListaMaterial.Location = New System.Drawing.Point(343, 155)
        Me.txtQuantidadeRequisicaoListaMaterial.MaxLength = 0
        Me.txtQuantidadeRequisicaoListaMaterial.Name = "txtQuantidadeRequisicaoListaMaterial"
        Me.txtQuantidadeRequisicaoListaMaterial.Size = New System.Drawing.Size(103, 20)
        Me.txtQuantidadeRequisicaoListaMaterial.TabIndex = 2
        Me.txtQuantidadeRequisicaoListaMaterial.Text = "0,00"
        Me.txtQuantidadeRequisicaoListaMaterial.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtCodigoProdutoNovoRequisicaoListaMaterial
        '
        Me.txtCodigoProdutoNovoRequisicaoListaMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoProdutoNovoRequisicaoListaMaterial.Location = New System.Drawing.Point(9, 155)
        Me.txtCodigoProdutoNovoRequisicaoListaMaterial.Name = "txtCodigoProdutoNovoRequisicaoListaMaterial"
        Me.txtCodigoProdutoNovoRequisicaoListaMaterial.Size = New System.Drawing.Size(328, 20)
        Me.txtCodigoProdutoNovoRequisicaoListaMaterial.TabIndex = 13
        Me.txtCodigoProdutoNovoRequisicaoListaMaterial.TabStop = False
        '
        'lblMedida3
        '
        Me.lblMedida3.AutoSize = True
        Me.lblMedida3.Location = New System.Drawing.Point(231, 178)
        Me.lblMedida3.Name = "lblMedida3"
        Me.lblMedida3.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida3.TabIndex = 23
        Me.lblMedida3.Tag = ""
        Me.lblMedida3.Text = "Medida 3:"
        '
        'lblDescricaoRequisicaoListaMaterial
        '
        Me.lblDescricaoRequisicaoListaMaterial.AutoSize = True
        Me.lblDescricaoRequisicaoListaMaterial.Location = New System.Drawing.Point(231, 218)
        Me.lblDescricaoRequisicaoListaMaterial.Name = "lblDescricaoRequisicaoListaMaterial"
        Me.lblDescricaoRequisicaoListaMaterial.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoRequisicaoListaMaterial.TabIndex = 33
        Me.lblDescricaoRequisicaoListaMaterial.Text = "Descrição:"
        '
        'txtDescricaoRequisicaoListaMaterial
        '
        Me.txtDescricaoRequisicaoListaMaterial.Location = New System.Drawing.Point(234, 235)
        Me.txtDescricaoRequisicaoListaMaterial.Name = "txtDescricaoRequisicaoListaMaterial"
        Me.txtDescricaoRequisicaoListaMaterial.Size = New System.Drawing.Size(376, 20)
        Me.txtDescricaoRequisicaoListaMaterial.TabIndex = 9
        '
        'txtMedida2
        '
        Me.txtMedida2.DecimalDigits = 2
        Me.txtMedida2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida2.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida2.FormatString = "0.00"
        Me.txtMedida2.Location = New System.Drawing.Point(118, 195)
        Me.txtMedida2.MaxLength = 0
        Me.txtMedida2.Name = "txtMedida2"
        Me.txtMedida2.Size = New System.Drawing.Size(110, 20)
        Me.txtMedida2.TabIndex = 5
        Me.txtMedida2.Tag = ""
        Me.txtMedida2.Text = "0,00"
        Me.txtMedida2.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(452, 195)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(158, 20)
        Me.cboUnidadeMedida.TabIndex = 8
        Me.cboUnidadeMedida.Tag = ""
        '
        'cboGrupoItemRequisicaoListaMaterial
        '
        Me.cboGrupoItemRequisicaoListaMaterial.AutoSize = False
        Me.cboGrupoItemRequisicaoListaMaterial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboGrupoItemRequisicaoListaMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemRequisicaoListaMaterial.Location = New System.Drawing.Point(9, 74)
        Me.cboGrupoItemRequisicaoListaMaterial.Name = "cboGrupoItemRequisicaoListaMaterial"
        Me.cboGrupoItemRequisicaoListaMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemRequisicaoListaMaterial.ReadOnly = True
        Me.cboGrupoItemRequisicaoListaMaterial.Size = New System.Drawing.Size(437, 20)
        Me.cboGrupoItemRequisicaoListaMaterial.TabIndex = 7
        Me.cboGrupoItemRequisicaoListaMaterial.Tag = ""
        '
        'cboCodigoProdutoRequisicaoListaMaterial
        '
        Me.cboCodigoProdutoRequisicaoListaMaterial.AutoSize = False
        Me.cboCodigoProdutoRequisicaoListaMaterial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboCodigoProdutoRequisicaoListaMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboCodigoProdutoRequisicaoListaMaterial.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCodigoProdutoRequisicaoListaMaterial.Location = New System.Drawing.Point(9, 115)
        Me.cboCodigoProdutoRequisicaoListaMaterial.Name = "cboCodigoProdutoRequisicaoListaMaterial"
        Me.cboCodigoProdutoRequisicaoListaMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProdutoRequisicaoListaMaterial.ReadOnly = True
        Me.cboCodigoProdutoRequisicaoListaMaterial.Size = New System.Drawing.Size(437, 20)
        Me.cboCodigoProdutoRequisicaoListaMaterial.TabIndex = 10
        Me.cboCodigoProdutoRequisicaoListaMaterial.Tag = ""
        '
        'lblCodigoProdutoRequisicaoListaMaterial
        '
        Me.lblCodigoProdutoRequisicaoListaMaterial.AutoSize = True
        Me.lblCodigoProdutoRequisicaoListaMaterial.Location = New System.Drawing.Point(6, 98)
        Me.lblCodigoProdutoRequisicaoListaMaterial.Name = "lblCodigoProdutoRequisicaoListaMaterial"
        Me.lblCodigoProdutoRequisicaoListaMaterial.Size = New System.Drawing.Size(106, 14)
        Me.lblCodigoProdutoRequisicaoListaMaterial.TabIndex = 9
        Me.lblCodigoProdutoRequisicaoListaMaterial.Tag = ""
        Me.lblCodigoProdutoRequisicaoListaMaterial.Text = "Produto Cadastrado:"
        '
        'lblGrupoItemRequisicaoListaMaterial
        '
        Me.lblGrupoItemRequisicaoListaMaterial.AutoSize = True
        Me.lblGrupoItemRequisicaoListaMaterial.ForeColor = System.Drawing.Color.Firebrick
        Me.lblGrupoItemRequisicaoListaMaterial.Location = New System.Drawing.Point(6, 57)
        Me.lblGrupoItemRequisicaoListaMaterial.Name = "lblGrupoItemRequisicaoListaMaterial"
        Me.lblGrupoItemRequisicaoListaMaterial.Size = New System.Drawing.Size(62, 14)
        Me.lblGrupoItemRequisicaoListaMaterial.TabIndex = 6
        Me.lblGrupoItemRequisicaoListaMaterial.Tag = ""
        Me.lblGrupoItemRequisicaoListaMaterial.Text = "Grupo Item:"
        '
        'txtMedida3
        '
        Me.txtMedida3.DecimalDigits = 2
        Me.txtMedida3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida3.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida3.FormatString = "0.00"
        Me.txtMedida3.Location = New System.Drawing.Point(234, 195)
        Me.txtMedida3.MaxLength = 0
        Me.txtMedida3.Name = "txtMedida3"
        Me.txtMedida3.Size = New System.Drawing.Size(103, 20)
        Me.txtMedida3.TabIndex = 6
        Me.txtMedida3.Tag = ""
        Me.txtMedida3.Text = "0,00"
        Me.txtMedida3.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida2
        '
        Me.lblMedida2.AutoSize = True
        Me.lblMedida2.Location = New System.Drawing.Point(115, 178)
        Me.lblMedida2.Name = "lblMedida2"
        Me.lblMedida2.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida2.TabIndex = 21
        Me.lblMedida2.Tag = ""
        Me.lblMedida2.Text = "Medida 2:"
        '
        'lblMedida4
        '
        Me.lblMedida4.AutoSize = True
        Me.lblMedida4.Location = New System.Drawing.Point(342, 178)
        Me.lblMedida4.Name = "lblMedida4"
        Me.lblMedida4.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida4.TabIndex = 25
        Me.lblMedida4.Tag = ""
        Me.lblMedida4.Text = "Medida 4:"
        '
        'txtMedida4
        '
        Me.txtMedida4.DecimalDigits = 2
        Me.txtMedida4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida4.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida4.FormatString = "0.00"
        Me.txtMedida4.Location = New System.Drawing.Point(343, 195)
        Me.txtMedida4.MaxLength = 0
        Me.txtMedida4.Name = "txtMedida4"
        Me.txtMedida4.Size = New System.Drawing.Size(103, 20)
        Me.txtMedida4.TabIndex = 7
        Me.txtMedida4.Tag = ""
        Me.txtMedida4.Text = "0,00"
        Me.txtMedida4.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida1
        '
        Me.lblMedida1.AutoSize = True
        Me.lblMedida1.Location = New System.Drawing.Point(6, 178)
        Me.lblMedida1.Name = "lblMedida1"
        Me.lblMedida1.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida1.TabIndex = 19
        Me.lblMedida1.Tag = ""
        Me.lblMedida1.Text = "Medida 1:"
        '
        'lblPesoEspecifico
        '
        Me.lblPesoEspecifico.AutoSize = True
        Me.lblPesoEspecifico.Location = New System.Drawing.Point(6, 218)
        Me.lblPesoEspecifico.Name = "lblPesoEspecifico"
        Me.lblPesoEspecifico.Size = New System.Drawing.Size(87, 14)
        Me.lblPesoEspecifico.TabIndex = 29
        Me.lblPesoEspecifico.Tag = ""
        Me.lblPesoEspecifico.Text = "Peso Específico:"
        '
        'txtPesoEspecifico
        '
        Me.txtPesoEspecifico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPesoEspecifico.DecimalDigits = 2
        Me.txtPesoEspecifico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPesoEspecifico.Location = New System.Drawing.Point(9, 235)
        Me.txtPesoEspecifico.MaxLength = 0
        Me.txtPesoEspecifico.Name = "txtPesoEspecifico"
        Me.txtPesoEspecifico.Size = New System.Drawing.Size(103, 20)
        Me.txtPesoEspecifico.TabIndex = 30
        Me.txtPesoEspecifico.TabStop = False
        Me.txtPesoEspecifico.Tag = ""
        Me.txtPesoEspecifico.Text = "0,00"
        Me.txtPesoEspecifico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPeso.DecimalDigits = 4
        Me.txtPeso.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPeso.Location = New System.Drawing.Point(118, 235)
        Me.txtPeso.MaxLength = 0
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.ReadOnly = True
        Me.txtPeso.Size = New System.Drawing.Size(110, 20)
        Me.txtPeso.TabIndex = 32
        Me.txtPeso.Tag = ""
        Me.txtPeso.Text = "0,0000"
        Me.txtPeso.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnFindGrupoItem
        '
        Me.btnFindGrupoItem.FlatAppearance.BorderSize = 0
        Me.btnFindGrupoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindGrupoItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnFindGrupoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFindGrupoItem.Location = New System.Drawing.Point(429, 56)
        Me.btnFindGrupoItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFindGrupoItem.Name = "btnFindGrupoItem"
        Me.btnFindGrupoItem.Size = New System.Drawing.Size(17, 16)
        Me.btnFindGrupoItem.TabIndex = 1
        Me.btnFindGrupoItem.TabStop = False
        Me.btnFindGrupoItem.Tag = ""
        Me.btnFindGrupoItem.UseVisualStyleBackColor = True
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(117, 218)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(34, 14)
        Me.lblPeso.TabIndex = 31
        Me.lblPeso.Tag = ""
        Me.lblPeso.Text = "Peso:"
        '
        'txtProduto
        '
        Me.txtProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(118, 34)
        Me.txtProduto.MaxLength = 60
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(219, 20)
        Me.txtProduto.TabIndex = 3
        Me.txtProduto.TabStop = False
        '
        'txtQuantidadePlanejada
        '
        Me.txtQuantidadePlanejada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadePlanejada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadePlanejada.DecimalDigits = 4
        Me.txtQuantidadePlanejada.Location = New System.Drawing.Point(507, 34)
        Me.txtQuantidadePlanejada.Name = "txtQuantidadePlanejada"
        Me.txtQuantidadePlanejada.ReadOnly = True
        Me.txtQuantidadePlanejada.Size = New System.Drawing.Size(103, 20)
        Me.txtQuantidadePlanejada.TabIndex = 5
        Me.txtQuantidadePlanejada.TabStop = False
        Me.txtQuantidadePlanejada.Text = "0,0000"
        Me.txtQuantidadePlanejada.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(115, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Produto:"
        '
        'lblQuantidadePlanejada
        '
        Me.lblQuantidadePlanejada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadePlanejada.AutoSize = True
        Me.lblQuantidadePlanejada.Location = New System.Drawing.Point(504, 17)
        Me.lblQuantidadePlanejada.Name = "lblQuantidadePlanejada"
        Me.lblQuantidadePlanejada.Size = New System.Drawing.Size(85, 14)
        Me.lblQuantidadePlanejada.TabIndex = 4
        Me.lblQuantidadePlanejada.Text = "Qtde. Planejada:"
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducao.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemProducao.MaxLength = 20
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.Size = New System.Drawing.Size(103, 20)
        Me.txtOrdemProducao.TabIndex = 1
        Me.txtOrdemProducao.TabStop = False
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducao.TabIndex = 0
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvarRequisicao)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 502)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(621, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvarRequisicao
        '
        Me.btnSalvarRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarRequisicao.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarRequisicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarRequisicao.Location = New System.Drawing.Point(424, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(521, 17)
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
        'frmPrdOrdemProducaoListaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 598)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrdOrdemProducaoListaMaterial"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ordem de Produção - Inserir Lista de Material"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpCorteMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCorteMaterial.ResumeLayout(False)
        Me.grpCorteMaterial.PerformLayout()
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
    Friend WithEvents txtMedida1 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeRequisicaoListaMaterial As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProdutoNovoRequisicaoListaMaterial As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeRequisicaoListaMaterial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida3 As System.Windows.Forms.Label
    Friend WithEvents lblDescricaoRequisicaoListaMaterial As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProdutoNovoRequisicaoListaMaterial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricaoRequisicaoListaMaterial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtMedida2 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboGrupoItemRequisicaoListaMaterial As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboCodigoProdutoRequisicaoListaMaterial As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProdutoRequisicaoListaMaterial As System.Windows.Forms.Label
    Friend WithEvents lblGrupoItemRequisicaoListaMaterial As System.Windows.Forms.Label
    Friend WithEvents txtMedida3 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida2 As System.Windows.Forms.Label
    Friend WithEvents lblMedida4 As System.Windows.Forms.Label
    Friend WithEvents txtMedida4 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida1 As System.Windows.Forms.Label
    Friend WithEvents lblPesoEspecifico As System.Windows.Forms.Label
    Friend WithEvents txtPesoEspecifico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtPeso As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnFindGrupoItem As System.Windows.Forms.Button
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents btnSalvarRequisicao As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents dtpDataNecessidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataNecessidade As System.Windows.Forms.Label
    Friend WithEvents lblObservacaoInterna As System.Windows.Forms.Label
    Friend WithEvents txtObservacaoInterna As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboUnidadeMedidaEstoque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaEstoque As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboTipoRequisicao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoRequisicao As Label
    Friend WithEvents grpCorteMaterial As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboUnidadeMedidaCorte As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaCorte As Label
    Friend WithEvents txtMedida1Corte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida3Corte As Label
    Friend WithEvents txtMedida2Corte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMedida3Corte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida2Corte As Label
    Friend WithEvents lblMedida4Corte As Label
    Friend WithEvents txtMedida4Corte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida1Corte As Label
    Friend WithEvents lblDescricaoCorte As Label
    Friend WithEvents txtDescricaoCorte As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPesoEspecificoCorte As Label
    Friend WithEvents txtPesoEspecificoCorte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtPesoCorte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPesoCorte As Label
    Friend WithEvents lblUnidadeMedida As Label
    Friend WithEvents lblCodigoProdutoNovoCorte As Label
    Friend WithEvents txtProdutoNovoCorte As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblQuantidadeCorte As Label
    Friend WithEvents txtQuantidadeCorte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNumeroDesenho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDesenho As Label
End Class
