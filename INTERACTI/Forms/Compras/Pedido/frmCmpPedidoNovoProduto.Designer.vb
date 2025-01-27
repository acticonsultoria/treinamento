<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpPedidoNovoProduto
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
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpPedidoNovoProduto))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFindGrupoItem = New System.Windows.Forms.Button()
        Me.cboGrupoItemCompras = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.lblValorTotalIPI = New System.Windows.Forms.Label()
        Me.txtValorTotalIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorUnitarioDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitarioDesconto = New System.Windows.Forms.Label()
        Me.lblAliquotaIPI = New System.Windows.Forms.Label()
        Me.lblAliquotaPISCOFINS = New System.Windows.Forms.Label()
        Me.lblAliquotaICMS = New System.Windows.Forms.Label()
        Me.cboOrdemProducao = New Janus.Windows.EditControls.UIComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEspecificacoes = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtOMItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOMItem = New System.Windows.Forms.Label()
        Me.txtRCItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRCItem = New System.Windows.Forms.Label()
        Me.txtAliquotaPISCOFINSProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorUnitarioProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitarioProduto = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtAliquotaIPIProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.dtpPrevisaoEntregaProduto = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblContaContabilProduto = New System.Windows.Forms.Label()
        Me.cboContaContabilProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGastoProduto = New System.Windows.Forms.Label()
        Me.cboCentroGastoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescontoValorProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoValorProduto = New System.Windows.Forms.Label()
        Me.txtDescontoPercentualProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoPercentualProduto = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblComplementoProduto = New System.Windows.Forms.Label()
        Me.txtComplementoProdutos = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPrevisaoEntregaProduto = New System.Windows.Forms.Label()
        Me.txtValorTotalProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotalProduto = New System.Windows.Forms.Label()
        Me.lblUnidadeMedidaProduto = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidadeProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeProduto = New System.Windows.Forms.Label()
        Me.btnProcurarContaContabilProduto = New System.Windows.Forms.Button()
        Me.btnProcurarCentroGastoProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarContaContabilProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGastoProduto = New System.Windows.Forms.Button()
        Me.btnDesmembrarPrevisaoEntregaProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarUnidadeMedidaProduto = New System.Windows.Forms.Button()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(835, 342)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpProduto)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(833, 319)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Adicionar Produto"
        '
        'grpProduto
        '
        Me.grpProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.lblDescricao)
        Me.grpProduto.Controls.Add(Me.txtDescricao)
        Me.grpProduto.Controls.Add(Me.btnFindGrupoItem)
        Me.grpProduto.Controls.Add(Me.cboGrupoItemCompras)
        Me.grpProduto.Controls.Add(Me.lblGrupoItem)
        Me.grpProduto.Controls.Add(Me.lblValorTotalIPI)
        Me.grpProduto.Controls.Add(Me.txtValorTotalIPI)
        Me.grpProduto.Controls.Add(Me.txtValorUnitarioDesconto)
        Me.grpProduto.Controls.Add(Me.lblValorUnitarioDesconto)
        Me.grpProduto.Controls.Add(Me.lblAliquotaIPI)
        Me.grpProduto.Controls.Add(Me.lblAliquotaPISCOFINS)
        Me.grpProduto.Controls.Add(Me.lblAliquotaICMS)
        Me.grpProduto.Controls.Add(Me.cboOrdemProducao)
        Me.grpProduto.Controls.Add(Me.Label4)
        Me.grpProduto.Controls.Add(Me.Label3)
        Me.grpProduto.Controls.Add(Me.txtEspecificacoes)
        Me.grpProduto.Controls.Add(Me.txtOMItem)
        Me.grpProduto.Controls.Add(Me.lblOMItem)
        Me.grpProduto.Controls.Add(Me.txtRCItem)
        Me.grpProduto.Controls.Add(Me.lblRCItem)
        Me.grpProduto.Controls.Add(Me.txtAliquotaPISCOFINSProduto)
        Me.grpProduto.Controls.Add(Me.txtValorUnitarioProduto)
        Me.grpProduto.Controls.Add(Me.lblValorUnitarioProduto)
        Me.grpProduto.Controls.Add(Me.txtAliquotaICMSProduto)
        Me.grpProduto.Controls.Add(Me.txtAliquotaIPIProduto)
        Me.grpProduto.Controls.Add(Me.dtpPrevisaoEntregaProduto)
        Me.grpProduto.Controls.Add(Me.lblContaContabilProduto)
        Me.grpProduto.Controls.Add(Me.cboContaContabilProduto)
        Me.grpProduto.Controls.Add(Me.lblCentroGastoProduto)
        Me.grpProduto.Controls.Add(Me.cboCentroGastoProduto)
        Me.grpProduto.Controls.Add(Me.cboProduto)
        Me.grpProduto.Controls.Add(Me.txtDescontoValorProduto)
        Me.grpProduto.Controls.Add(Me.lblDescontoValorProduto)
        Me.grpProduto.Controls.Add(Me.txtDescontoPercentualProduto)
        Me.grpProduto.Controls.Add(Me.lblDescontoPercentualProduto)
        Me.grpProduto.Controls.Add(Me.lblProduto)
        Me.grpProduto.Controls.Add(Me.lblComplementoProduto)
        Me.grpProduto.Controls.Add(Me.txtComplementoProdutos)
        Me.grpProduto.Controls.Add(Me.lblPrevisaoEntregaProduto)
        Me.grpProduto.Controls.Add(Me.txtValorTotalProduto)
        Me.grpProduto.Controls.Add(Me.lblValorTotalProduto)
        Me.grpProduto.Controls.Add(Me.lblUnidadeMedidaProduto)
        Me.grpProduto.Controls.Add(Me.cboUnidadeMedidaProduto)
        Me.grpProduto.Controls.Add(Me.txtQuantidadeProduto)
        Me.grpProduto.Controls.Add(Me.lblQuantidadeProduto)
        Me.grpProduto.Controls.Add(Me.btnProcurarContaContabilProduto)
        Me.grpProduto.Controls.Add(Me.btnProcurarCentroGastoProduto)
        Me.grpProduto.Controls.Add(Me.btnCadastrarContaContabilProduto)
        Me.grpProduto.Controls.Add(Me.btnCadastrarCentroGastoProduto)
        Me.grpProduto.Controls.Add(Me.btnDesmembrarPrevisaoEntregaProduto)
        Me.grpProduto.Controls.Add(Me.btnCadastrarUnidadeMedidaProduto)
        Me.grpProduto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProduto.Location = New System.Drawing.Point(8, 3)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(817, 265)
        Me.grpProduto.TabIndex = 0
        Me.grpProduto.Text = "Lista de Produtos"
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'btnFindGrupoItem
        '
        Me.btnFindGrupoItem.FlatAppearance.BorderSize = 0
        Me.btnFindGrupoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindGrupoItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnFindGrupoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFindGrupoItem.Location = New System.Drawing.Point(531, 16)
        Me.btnFindGrupoItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFindGrupoItem.Name = "btnFindGrupoItem"
        Me.btnFindGrupoItem.Size = New System.Drawing.Size(17, 16)
        Me.btnFindGrupoItem.TabIndex = 2
        Me.btnFindGrupoItem.TabStop = False
        Me.btnFindGrupoItem.Tag = ""
        Me.btnFindGrupoItem.UseVisualStyleBackColor = True
        '
        'cboGrupoItemCompras
        '
        Me.cboGrupoItemCompras.AutoSize = False
        Me.cboGrupoItemCompras.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboGrupoItemCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemCompras.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItemCompras.Name = "cboGrupoItemCompras"
        Me.cboGrupoItemCompras.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemCompras.ReadOnly = True
        Me.cboGrupoItemCompras.Size = New System.Drawing.Size(539, 20)
        Me.cboGrupoItemCompras.TabIndex = 0
        Me.cboGrupoItemCompras.Tag = ""
        '
        'lblGrupoItem
        '
        Me.lblGrupoItem.AutoSize = True
        Me.lblGrupoItem.ForeColor = System.Drawing.Color.Firebrick
        Me.lblGrupoItem.Location = New System.Drawing.Point(6, 17)
        Me.lblGrupoItem.Name = "lblGrupoItem"
        Me.lblGrupoItem.Size = New System.Drawing.Size(62, 14)
        Me.lblGrupoItem.TabIndex = 0
        Me.lblGrupoItem.Tag = ""
        Me.lblGrupoItem.Text = "Grupo Item:"
        '
        'lblValorTotalIPI
        '
        Me.lblValorTotalIPI.AutoSize = True
        Me.lblValorTotalIPI.Location = New System.Drawing.Point(634, 137)
        Me.lblValorTotalIPI.Name = "lblValorTotalIPI"
        Me.lblValorTotalIPI.Size = New System.Drawing.Size(97, 14)
        Me.lblValorTotalIPI.TabIndex = 35
        Me.lblValorTotalIPI.Text = "Valor Total Com IPI:"
        '
        'txtValorTotalIPI
        '
        Me.txtValorTotalIPI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotalIPI.DecimalDigits = 2
        Me.txtValorTotalIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotalIPI.Location = New System.Drawing.Point(637, 154)
        Me.txtValorTotalIPI.MaxLength = 0
        Me.txtValorTotalIPI.Name = "txtValorTotalIPI"
        Me.txtValorTotalIPI.ReadOnly = True
        Me.txtValorTotalIPI.Size = New System.Drawing.Size(172, 20)
        Me.txtValorTotalIPI.TabIndex = 15
        Me.txtValorTotalIPI.TabStop = False
        Me.txtValorTotalIPI.Text = "0,00"
        Me.txtValorTotalIPI.Value = 0R
        Me.txtValorTotalIPI.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'txtValorUnitarioDesconto
        '
        Me.txtValorUnitarioDesconto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorUnitarioDesconto.DecimalDigits = 2
        Me.txtValorUnitarioDesconto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnitarioDesconto.Location = New System.Drawing.Point(261, 154)
        Me.txtValorUnitarioDesconto.MaxLength = 0
        Me.txtValorUnitarioDesconto.Name = "txtValorUnitarioDesconto"
        Me.txtValorUnitarioDesconto.ReadOnly = True
        Me.txtValorUnitarioDesconto.Size = New System.Drawing.Size(104, 20)
        Me.txtValorUnitarioDesconto.TabIndex = 9
        Me.txtValorUnitarioDesconto.TabStop = False
        Me.txtValorUnitarioDesconto.Text = "0,00"
        Me.txtValorUnitarioDesconto.Value = 0R
        Me.txtValorUnitarioDesconto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorUnitarioDesconto
        '
        Me.lblValorUnitarioDesconto.AutoSize = True
        Me.lblValorUnitarioDesconto.Location = New System.Drawing.Point(258, 137)
        Me.lblValorUnitarioDesconto.Name = "lblValorUnitarioDesconto"
        Me.lblValorUnitarioDesconto.Size = New System.Drawing.Size(108, 14)
        Me.lblValorUnitarioDesconto.TabIndex = 21
        Me.lblValorUnitarioDesconto.Text = "Valor Unit. Desconto:"
        '
        'lblAliquotaIPI
        '
        Me.lblAliquotaIPI.AutoSize = True
        Me.lblAliquotaIPI.Location = New System.Drawing.Point(502, 137)
        Me.lblAliquotaIPI.Name = "lblAliquotaIPI"
        Me.lblAliquotaIPI.Size = New System.Drawing.Size(33, 14)
        Me.lblAliquotaIPI.TabIndex = 27
        Me.lblAliquotaIPI.Text = "% IPI:"
        '
        'lblAliquotaPISCOFINS
        '
        Me.lblAliquotaPISCOFINS.AutoSize = True
        Me.lblAliquotaPISCOFINS.Location = New System.Drawing.Point(421, 137)
        Me.lblAliquotaPISCOFINS.Name = "lblAliquotaPISCOFINS"
        Me.lblAliquotaPISCOFINS.Size = New System.Drawing.Size(78, 14)
        Me.lblAliquotaPISCOFINS.TabIndex = 25
        Me.lblAliquotaPISCOFINS.Text = "% PIS/COFINS:"
        '
        'lblAliquotaICMS
        '
        Me.lblAliquotaICMS.AutoSize = True
        Me.lblAliquotaICMS.Location = New System.Drawing.Point(368, 137)
        Me.lblAliquotaICMS.Name = "lblAliquotaICMS"
        Me.lblAliquotaICMS.Size = New System.Drawing.Size(47, 14)
        Me.lblAliquotaICMS.TabIndex = 23
        Me.lblAliquotaICMS.Text = "% ICMS:"
        '
        'cboOrdemProducao
        '
        Me.cboOrdemProducao.AutoSize = False
        Me.cboOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboOrdemProducao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboOrdemProducao.Location = New System.Drawing.Point(637, 234)
        Me.cboOrdemProducao.Name = "cboOrdemProducao"
        Me.cboOrdemProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrdemProducao.Size = New System.Drawing.Size(174, 20)
        Me.cboOrdemProducao.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(634, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ordem de Produção:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 14)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Especificações:"
        '
        'txtEspecificacoes
        '
        Me.txtEspecificacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspecificacoes.Location = New System.Drawing.Point(9, 234)
        Me.txtEspecificacoes.MaxLength = 500
        Me.txtEspecificacoes.Name = "txtEspecificacoes"
        Me.txtEspecificacoes.Size = New System.Drawing.Size(622, 20)
        Me.txtEspecificacoes.TabIndex = 20
        '
        'txtOMItem
        '
        Me.txtOMItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOMItem.Location = New System.Drawing.Point(720, 194)
        Me.txtOMItem.MaxLength = 20
        Me.txtOMItem.Name = "txtOMItem"
        Me.txtOMItem.Size = New System.Drawing.Size(91, 20)
        Me.txtOMItem.TabIndex = 19
        '
        'lblOMItem
        '
        Me.lblOMItem.AutoSize = True
        Me.lblOMItem.Location = New System.Drawing.Point(717, 177)
        Me.lblOMItem.Name = "lblOMItem"
        Me.lblOMItem.Size = New System.Drawing.Size(26, 14)
        Me.lblOMItem.TabIndex = 46
        Me.lblOMItem.Text = "OM:"
        '
        'txtRCItem
        '
        Me.txtRCItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRCItem.Location = New System.Drawing.Point(637, 194)
        Me.txtRCItem.MaxLength = 20
        Me.txtRCItem.Name = "txtRCItem"
        Me.txtRCItem.Size = New System.Drawing.Size(77, 20)
        Me.txtRCItem.TabIndex = 18
        '
        'lblRCItem
        '
        Me.lblRCItem.AutoSize = True
        Me.lblRCItem.Location = New System.Drawing.Point(634, 177)
        Me.lblRCItem.Name = "lblRCItem"
        Me.lblRCItem.Size = New System.Drawing.Size(24, 14)
        Me.lblRCItem.TabIndex = 44
        Me.lblRCItem.Text = "RC:"
        '
        'txtAliquotaPISCOFINSProduto
        '
        Me.txtAliquotaPISCOFINSProduto.DecimalDigits = 2
        Me.txtAliquotaPISCOFINSProduto.Location = New System.Drawing.Point(424, 154)
        Me.txtAliquotaPISCOFINSProduto.MaxLength = 0
        Me.txtAliquotaPISCOFINSProduto.Name = "txtAliquotaPISCOFINSProduto"
        Me.txtAliquotaPISCOFINSProduto.Size = New System.Drawing.Size(75, 20)
        Me.txtAliquotaPISCOFINSProduto.TabIndex = 11
        Me.txtAliquotaPISCOFINSProduto.Text = "0,00"
        Me.txtAliquotaPISCOFINSProduto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorUnitarioProduto
        '
        Me.txtValorUnitarioProduto.DecimalDigits = 4
        Me.txtValorUnitarioProduto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnitarioProduto.Location = New System.Drawing.Point(9, 154)
        Me.txtValorUnitarioProduto.MaxLength = 0
        Me.txtValorUnitarioProduto.Name = "txtValorUnitarioProduto"
        Me.txtValorUnitarioProduto.Size = New System.Drawing.Size(71, 20)
        Me.txtValorUnitarioProduto.TabIndex = 6
        Me.txtValorUnitarioProduto.Text = "0,0000"
        Me.txtValorUnitarioProduto.Value = 0R
        Me.txtValorUnitarioProduto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorUnitarioProduto
        '
        Me.lblValorUnitarioProduto.AutoSize = True
        Me.lblValorUnitarioProduto.ForeColor = System.Drawing.Color.Firebrick
        Me.lblValorUnitarioProduto.Location = New System.Drawing.Point(6, 137)
        Me.lblValorUnitarioProduto.Name = "lblValorUnitarioProduto"
        Me.lblValorUnitarioProduto.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitarioProduto.TabIndex = 15
        Me.lblValorUnitarioProduto.Text = "Valor Unitário:"
        '
        'txtAliquotaICMSProduto
        '
        Me.txtAliquotaICMSProduto.DecimalDigits = 2
        Me.txtAliquotaICMSProduto.Location = New System.Drawing.Point(371, 154)
        Me.txtAliquotaICMSProduto.MaxLength = 0
        Me.txtAliquotaICMSProduto.Name = "txtAliquotaICMSProduto"
        Me.txtAliquotaICMSProduto.Size = New System.Drawing.Size(47, 20)
        Me.txtAliquotaICMSProduto.TabIndex = 10
        Me.txtAliquotaICMSProduto.Text = "0,00"
        Me.txtAliquotaICMSProduto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtAliquotaIPIProduto
        '
        Me.txtAliquotaIPIProduto.DecimalDigits = 2
        Me.txtAliquotaIPIProduto.Location = New System.Drawing.Point(505, 154)
        Me.txtAliquotaIPIProduto.MaxLength = 0
        Me.txtAliquotaIPIProduto.Name = "txtAliquotaIPIProduto"
        Me.txtAliquotaIPIProduto.Size = New System.Drawing.Size(43, 20)
        Me.txtAliquotaIPIProduto.TabIndex = 12
        Me.txtAliquotaIPIProduto.Text = "0,00"
        Me.txtAliquotaIPIProduto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'dtpPrevisaoEntregaProduto
        '
        '
        '
        '
        Me.dtpPrevisaoEntregaProduto.DropDownCalendar.Name = ""
        Me.dtpPrevisaoEntregaProduto.Location = New System.Drawing.Point(720, 114)
        Me.dtpPrevisaoEntregaProduto.Name = "dtpPrevisaoEntregaProduto"
        Me.dtpPrevisaoEntregaProduto.Size = New System.Drawing.Size(91, 20)
        Me.dtpPrevisaoEntregaProduto.TabIndex = 5
        Me.dtpPrevisaoEntregaProduto.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblContaContabilProduto
        '
        Me.lblContaContabilProduto.AutoSize = True
        Me.lblContaContabilProduto.Location = New System.Drawing.Point(316, 177)
        Me.lblContaContabilProduto.Name = "lblContaContabilProduto"
        Me.lblContaContabilProduto.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabilProduto.TabIndex = 41
        Me.lblContaContabilProduto.Text = "Conta Contábil:"
        '
        'cboContaContabilProduto
        '
        Me.cboContaContabilProduto.AutoSize = False
        Me.cboContaContabilProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabilProduto.Location = New System.Drawing.Point(300, 194)
        Me.cboContaContabilProduto.Name = "cboContaContabilProduto"
        Me.cboContaContabilProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabilProduto.Size = New System.Drawing.Size(331, 20)
        Me.cboContaContabilProduto.TabIndex = 17
        '
        'lblCentroGastoProduto
        '
        Me.lblCentroGastoProduto.AutoSize = True
        Me.lblCentroGastoProduto.Location = New System.Drawing.Point(25, 177)
        Me.lblCentroGastoProduto.Name = "lblCentroGastoProduto"
        Me.lblCentroGastoProduto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGastoProduto.TabIndex = 38
        Me.lblCentroGastoProduto.Text = "Centro de Gasto:"
        '
        'cboCentroGastoProduto
        '
        Me.cboCentroGastoProduto.AutoSize = False
        Me.cboCentroGastoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGastoProduto.Location = New System.Drawing.Point(9, 194)
        Me.cboCentroGastoProduto.Name = "cboCentroGastoProduto"
        Me.cboCentroGastoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGastoProduto.Size = New System.Drawing.Size(285, 20)
        Me.cboCentroGastoProduto.TabIndex = 16
        '
        'cboProduto
        '
        Me.cboProduto.AutoSize = False
        Me.cboProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboProduto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboProduto.Location = New System.Drawing.Point(554, 34)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.ReadOnly = True
        Me.cboProduto.Size = New System.Drawing.Size(255, 20)
        Me.cboProduto.TabIndex = 1
        Me.cboProduto.TabStop = False
        '
        'txtDescontoValorProduto
        '
        Me.txtDescontoValorProduto.DecimalDigits = 4
        Me.txtDescontoValorProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDescontoValorProduto.Location = New System.Drawing.Point(166, 154)
        Me.txtDescontoValorProduto.MaxLength = 0
        Me.txtDescontoValorProduto.Name = "txtDescontoValorProduto"
        Me.txtDescontoValorProduto.Size = New System.Drawing.Size(89, 20)
        Me.txtDescontoValorProduto.TabIndex = 8
        Me.txtDescontoValorProduto.Text = "0,0000"
        Me.txtDescontoValorProduto.Value = 0R
        Me.txtDescontoValorProduto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoValorProduto
        '
        Me.lblDescontoValorProduto.AutoSize = True
        Me.lblDescontoValorProduto.Location = New System.Drawing.Point(163, 137)
        Me.lblDescontoValorProduto.Name = "lblDescontoValorProduto"
        Me.lblDescontoValorProduto.Size = New System.Drawing.Size(92, 14)
        Me.lblDescontoValorProduto.TabIndex = 19
        Me.lblDescontoValorProduto.Text = "Desconto (Valor):"
        '
        'txtDescontoPercentualProduto
        '
        Me.txtDescontoPercentualProduto.DecimalDigits = 5
        Me.txtDescontoPercentualProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDescontoPercentualProduto.Location = New System.Drawing.Point(86, 154)
        Me.txtDescontoPercentualProduto.MaxLength = 0
        Me.txtDescontoPercentualProduto.Name = "txtDescontoPercentualProduto"
        Me.txtDescontoPercentualProduto.Size = New System.Drawing.Size(74, 20)
        Me.txtDescontoPercentualProduto.TabIndex = 7
        Me.txtDescontoPercentualProduto.Text = "0,00000"
        Me.txtDescontoPercentualProduto.Value = 0R
        Me.txtDescontoPercentualProduto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoPercentualProduto
        '
        Me.lblDescontoPercentualProduto.AutoSize = True
        Me.lblDescontoPercentualProduto.Location = New System.Drawing.Point(83, 137)
        Me.lblDescontoPercentualProduto.Name = "lblDescontoPercentualProduto"
        Me.lblDescontoPercentualProduto.Size = New System.Drawing.Size(77, 14)
        Me.lblDescontoPercentualProduto.TabIndex = 17
        Me.lblDescontoPercentualProduto.Text = "Desconto (%):"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.ForeColor = System.Drawing.Color.Black
        Me.lblProduto.Location = New System.Drawing.Point(551, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 3
        Me.lblProduto.Text = "Produto:"
        '
        'lblComplementoProduto
        '
        Me.lblComplementoProduto.AutoSize = True
        Me.lblComplementoProduto.Location = New System.Drawing.Point(6, 97)
        Me.lblComplementoProduto.Name = "lblComplementoProduto"
        Me.lblComplementoProduto.Size = New System.Drawing.Size(74, 14)
        Me.lblComplementoProduto.TabIndex = 5
        Me.lblComplementoProduto.Text = "Complemento:"
        '
        'txtComplementoProdutos
        '
        Me.txtComplementoProdutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoProdutos.Location = New System.Drawing.Point(9, 114)
        Me.txtComplementoProdutos.MaxLength = 500
        Me.txtComplementoProdutos.Name = "txtComplementoProdutos"
        Me.txtComplementoProdutos.Size = New System.Drawing.Size(539, 20)
        Me.txtComplementoProdutos.TabIndex = 2
        '
        'lblPrevisaoEntregaProduto
        '
        Me.lblPrevisaoEntregaProduto.AutoSize = True
        Me.lblPrevisaoEntregaProduto.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPrevisaoEntregaProduto.Location = New System.Drawing.Point(737, 97)
        Me.lblPrevisaoEntregaProduto.Name = "lblPrevisaoEntregaProduto"
        Me.lblPrevisaoEntregaProduto.Size = New System.Drawing.Size(74, 14)
        Me.lblPrevisaoEntregaProduto.TabIndex = 13
        Me.lblPrevisaoEntregaProduto.Text = "Prev. Entrega:"
        '
        'txtValorTotalProduto
        '
        Me.txtValorTotalProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotalProduto.DecimalDigits = 2
        Me.txtValorTotalProduto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotalProduto.Location = New System.Drawing.Point(554, 154)
        Me.txtValorTotalProduto.MaxLength = 0
        Me.txtValorTotalProduto.Name = "txtValorTotalProduto"
        Me.txtValorTotalProduto.ReadOnly = True
        Me.txtValorTotalProduto.Size = New System.Drawing.Size(77, 20)
        Me.txtValorTotalProduto.TabIndex = 13
        Me.txtValorTotalProduto.TabStop = False
        Me.txtValorTotalProduto.Text = "0,00"
        Me.txtValorTotalProduto.Value = 0R
        Me.txtValorTotalProduto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorTotalProduto
        '
        Me.lblValorTotalProduto.AutoSize = True
        Me.lblValorTotalProduto.Location = New System.Drawing.Point(551, 137)
        Me.lblValorTotalProduto.Name = "lblValorTotalProduto"
        Me.lblValorTotalProduto.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotalProduto.TabIndex = 29
        Me.lblValorTotalProduto.Text = "Valor Total:"
        '
        'lblUnidadeMedidaProduto
        '
        Me.lblUnidadeMedidaProduto.AutoSize = True
        Me.lblUnidadeMedidaProduto.ForeColor = System.Drawing.Color.Firebrick
        Me.lblUnidadeMedidaProduto.Location = New System.Drawing.Point(655, 97)
        Me.lblUnidadeMedidaProduto.Name = "lblUnidadeMedidaProduto"
        Me.lblUnidadeMedidaProduto.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedidaProduto.TabIndex = 10
        Me.lblUnidadeMedidaProduto.Text = "Und. Med.:"
        '
        'cboUnidadeMedidaProduto
        '
        Me.cboUnidadeMedidaProduto.AutoSize = False
        Me.cboUnidadeMedidaProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaProduto.Location = New System.Drawing.Point(637, 114)
        Me.cboUnidadeMedidaProduto.Name = "cboUnidadeMedidaProduto"
        Me.cboUnidadeMedidaProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaProduto.Size = New System.Drawing.Size(77, 20)
        Me.cboUnidadeMedidaProduto.TabIndex = 4
        '
        'txtQuantidadeProduto
        '
        Me.txtQuantidadeProduto.DecimalDigits = 4
        Me.txtQuantidadeProduto.Location = New System.Drawing.Point(554, 114)
        Me.txtQuantidadeProduto.MaxLength = 0
        Me.txtQuantidadeProduto.Name = "txtQuantidadeProduto"
        Me.txtQuantidadeProduto.Size = New System.Drawing.Size(77, 20)
        Me.txtQuantidadeProduto.TabIndex = 3
        Me.txtQuantidadeProduto.Text = "0,0000"
        Me.txtQuantidadeProduto.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeProduto
        '
        Me.lblQuantidadeProduto.AutoSize = True
        Me.lblQuantidadeProduto.ForeColor = System.Drawing.Color.Firebrick
        Me.lblQuantidadeProduto.Location = New System.Drawing.Point(551, 97)
        Me.lblQuantidadeProduto.Name = "lblQuantidadeProduto"
        Me.lblQuantidadeProduto.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeProduto.TabIndex = 7
        Me.lblQuantidadeProduto.Text = "Quantidade:"
        '
        'btnProcurarContaContabilProduto
        '
        Me.btnProcurarContaContabilProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabilProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabilProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabilProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabilProduto.Location = New System.Drawing.Point(613, 176)
        Me.btnProcurarContaContabilProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabilProduto.Name = "btnProcurarContaContabilProduto"
        Me.btnProcurarContaContabilProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabilProduto.TabIndex = 43
        Me.btnProcurarContaContabilProduto.TabStop = False
        Me.btnProcurarContaContabilProduto.UseVisualStyleBackColor = True
        '
        'btnProcurarCentroGastoProduto
        '
        Me.btnProcurarCentroGastoProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGastoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGastoProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGastoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGastoProduto.Location = New System.Drawing.Point(277, 176)
        Me.btnProcurarCentroGastoProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGastoProduto.Name = "btnProcurarCentroGastoProduto"
        Me.btnProcurarCentroGastoProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGastoProduto.TabIndex = 40
        Me.btnProcurarCentroGastoProduto.TabStop = False
        Me.btnProcurarCentroGastoProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarContaContabilProduto
        '
        Me.btnCadastrarContaContabilProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabilProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabilProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabilProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabilProduto.Location = New System.Drawing.Point(300, 178)
        Me.btnCadastrarContaContabilProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabilProduto.Name = "btnCadastrarContaContabilProduto"
        Me.btnCadastrarContaContabilProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabilProduto.TabIndex = 38
        Me.btnCadastrarContaContabilProduto.TabStop = False
        Me.btnCadastrarContaContabilProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGastoProduto
        '
        Me.btnCadastrarCentroGastoProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGastoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGastoProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGastoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGastoProduto.Location = New System.Drawing.Point(9, 178)
        Me.btnCadastrarCentroGastoProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGastoProduto.Name = "btnCadastrarCentroGastoProduto"
        Me.btnCadastrarCentroGastoProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGastoProduto.TabIndex = 37
        Me.btnCadastrarCentroGastoProduto.TabStop = False
        Me.btnCadastrarCentroGastoProduto.UseVisualStyleBackColor = True
        '
        'btnDesmembrarPrevisaoEntregaProduto
        '
        Me.btnDesmembrarPrevisaoEntregaProduto.FlatAppearance.BorderSize = 0
        Me.btnDesmembrarPrevisaoEntregaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesmembrarPrevisaoEntregaProduto.Image = Global.INTERACTI.My.Resources.Resources.calendario
        Me.btnDesmembrarPrevisaoEntregaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDesmembrarPrevisaoEntregaProduto.Location = New System.Drawing.Point(717, 96)
        Me.btnDesmembrarPrevisaoEntregaProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDesmembrarPrevisaoEntregaProduto.Name = "btnDesmembrarPrevisaoEntregaProduto"
        Me.btnDesmembrarPrevisaoEntregaProduto.Size = New System.Drawing.Size(17, 17)
        Me.btnDesmembrarPrevisaoEntregaProduto.TabIndex = 12
        Me.btnDesmembrarPrevisaoEntregaProduto.TabStop = False
        Me.btnDesmembrarPrevisaoEntregaProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarUnidadeMedidaProduto
        '
        Me.btnCadastrarUnidadeMedidaProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedidaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedidaProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedidaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedidaProduto.Location = New System.Drawing.Point(639, 98)
        Me.btnCadastrarUnidadeMedidaProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedidaProduto.Name = "btnCadastrarUnidadeMedidaProduto"
        Me.btnCadastrarUnidadeMedidaProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedidaProduto.TabIndex = 9
        Me.btnCadastrarUnidadeMedidaProduto.TabStop = False
        Me.btnCadastrarUnidadeMedidaProduto.UseVisualStyleBackColor = True
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Controls.Add(Me.btnInserirProduto)
        Me.grpControl2.Location = New System.Drawing.Point(8, 268)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(817, 42)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(720, 13)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirProduto.Image = CType(resources.GetObject("btnInserirProduto.Image"), System.Drawing.Image)
        Me.btnInserirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirProduto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirProduto.Location = New System.Drawing.Point(623, 13)
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirProduto.TabIndex = 0
        Me.btnInserirProduto.Text = "Inserir"
        Me.btnInserirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ForeColor = System.Drawing.Color.Black
        Me.lblDescricao.Location = New System.Drawing.Point(6, 57)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 69
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(8, 74)
        Me.txtDescricao.MaxLength = 500
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(800, 20)
        Me.txtDescricao.TabIndex = 68
        '
        'frmCmpPedidoNovoProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 356)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmCmpPedidoNovoProduto"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pedido de Compra"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAliquotaIPI As System.Windows.Forms.Label
    Friend WithEvents lblAliquotaPISCOFINS As System.Windows.Forms.Label
    Friend WithEvents lblAliquotaICMS As System.Windows.Forms.Label
    Friend WithEvents cboOrdemProducao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEspecificacoes As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtOMItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOMItem As System.Windows.Forms.Label
    Friend WithEvents txtRCItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRCItem As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPISCOFINSProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorUnitarioProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitarioProduto As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMSProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtAliquotaIPIProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpPrevisaoEntregaProduto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblContaContabilProduto As System.Windows.Forms.Label
    Friend WithEvents cboContaContabilProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGastoProduto As System.Windows.Forms.Label
    Friend WithEvents cboCentroGastoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescontoValorProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoValorProduto As System.Windows.Forms.Label
    Friend WithEvents txtDescontoPercentualProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoPercentualProduto As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents lblComplementoProduto As System.Windows.Forms.Label
    Friend WithEvents txtComplementoProdutos As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPrevisaoEntregaProduto As System.Windows.Forms.Label
    Friend WithEvents txtValorTotalProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotalProduto As System.Windows.Forms.Label
    Friend WithEvents lblUnidadeMedidaProduto As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedidaProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtQuantidadeProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeProduto As System.Windows.Forms.Label
    Friend WithEvents btnProcurarContaContabilProduto As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCentroGastoProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarContaContabilProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGastoProduto As System.Windows.Forms.Button
    Friend WithEvents btnDesmembrarPrevisaoEntregaProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarUnidadeMedidaProduto As System.Windows.Forms.Button
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValorUnitarioDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitarioDesconto As System.Windows.Forms.Label
    Friend WithEvents lblValorTotalIPI As System.Windows.Forms.Label
    Friend WithEvents txtValorTotalIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboGrupoItemCompras As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItem As System.Windows.Forms.Label
    Friend WithEvents btnFindGrupoItem As System.Windows.Forms.Button
    Friend WithEvents lblDescricao As Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
End Class
