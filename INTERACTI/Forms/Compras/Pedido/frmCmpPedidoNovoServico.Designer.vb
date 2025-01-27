<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpPedidoNovoServico
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
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpPedidoNovoServico))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpServico = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboGrupoItemCompras = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.cboServico = New Janus.Windows.EditControls.UIComboBox()
        Me.lblServico = New System.Windows.Forms.Label()
        Me.txtAliquotaIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIR = New System.Windows.Forms.Label()
        Me.txtAliquotaCSLL = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCSLL = New System.Windows.Forms.Label()
        Me.txtAliquotaINSS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaINSS = New System.Windows.Forms.Label()
        Me.btnProcurarServico = New System.Windows.Forms.Button()
        Me.txtValorUnitarioDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitarioDesconto = New System.Windows.Forms.Label()
        Me.lblAliquotaPISCOFINS = New System.Windows.Forms.Label()
        Me.lblAliquotaISS = New System.Windows.Forms.Label()
        Me.txtAliquotaPISCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.txtValorTotalImposto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotalImpostoProduto = New System.Windows.Forms.Label()
        Me.txtAliquotaISS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.dtpPrevisaoEntrega = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescontoValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoValor = New System.Windows.Forms.Label()
        Me.txtDescontoPercentual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoPercentual = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtComplemento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPrevisaoEntrega = New System.Windows.Forms.Label()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotalProduto = New System.Windows.Forms.Label()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.btnDesmembrarPrevisaoEntrega = New System.Windows.Forms.Button()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServico.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(835, 298)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpServico)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(833, 275)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Adicionar Serviço"
        '
        'grpServico
        '
        Me.grpServico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpServico.BackColor = System.Drawing.Color.Transparent
        Me.grpServico.Controls.Add(Me.lblDescricao)
        Me.grpServico.Controls.Add(Me.txtDescricao)
        Me.grpServico.Controls.Add(Me.cboGrupoItemCompras)
        Me.grpServico.Controls.Add(Me.lblGrupoItem)
        Me.grpServico.Controls.Add(Me.cboServico)
        Me.grpServico.Controls.Add(Me.lblServico)
        Me.grpServico.Controls.Add(Me.txtAliquotaIR)
        Me.grpServico.Controls.Add(Me.lblAliquotaIR)
        Me.grpServico.Controls.Add(Me.txtAliquotaCSLL)
        Me.grpServico.Controls.Add(Me.lblAliquotaCSLL)
        Me.grpServico.Controls.Add(Me.txtAliquotaINSS)
        Me.grpServico.Controls.Add(Me.lblAliquotaINSS)
        Me.grpServico.Controls.Add(Me.btnProcurarServico)
        Me.grpServico.Controls.Add(Me.txtValorUnitarioDesconto)
        Me.grpServico.Controls.Add(Me.lblValorUnitarioDesconto)
        Me.grpServico.Controls.Add(Me.lblAliquotaPISCOFINS)
        Me.grpServico.Controls.Add(Me.lblAliquotaISS)
        Me.grpServico.Controls.Add(Me.txtAliquotaPISCOFINS)
        Me.grpServico.Controls.Add(Me.txtValorUnitario)
        Me.grpServico.Controls.Add(Me.lblValorUnitario)
        Me.grpServico.Controls.Add(Me.txtValorTotalImposto)
        Me.grpServico.Controls.Add(Me.lblValorTotalImpostoProduto)
        Me.grpServico.Controls.Add(Me.txtAliquotaISS)
        Me.grpServico.Controls.Add(Me.dtpPrevisaoEntrega)
        Me.grpServico.Controls.Add(Me.lblContaContabil)
        Me.grpServico.Controls.Add(Me.cboContaContabil)
        Me.grpServico.Controls.Add(Me.lblCentroGasto)
        Me.grpServico.Controls.Add(Me.cboCentroGasto)
        Me.grpServico.Controls.Add(Me.txtDescontoValor)
        Me.grpServico.Controls.Add(Me.lblDescontoValor)
        Me.grpServico.Controls.Add(Me.txtDescontoPercentual)
        Me.grpServico.Controls.Add(Me.lblDescontoPercentual)
        Me.grpServico.Controls.Add(Me.lblComplemento)
        Me.grpServico.Controls.Add(Me.txtComplemento)
        Me.grpServico.Controls.Add(Me.lblPrevisaoEntrega)
        Me.grpServico.Controls.Add(Me.txtValorTotal)
        Me.grpServico.Controls.Add(Me.lblValorTotalProduto)
        Me.grpServico.Controls.Add(Me.lblUnidadeMedida)
        Me.grpServico.Controls.Add(Me.cboUnidadeMedida)
        Me.grpServico.Controls.Add(Me.txtQuantidade)
        Me.grpServico.Controls.Add(Me.lblQuantidade)
        Me.grpServico.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpServico.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpServico.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpServico.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpServico.Controls.Add(Me.btnDesmembrarPrevisaoEntrega)
        Me.grpServico.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpServico.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpServico.Location = New System.Drawing.Point(8, 3)
        Me.grpServico.Name = "grpServico"
        Me.grpServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpServico.Size = New System.Drawing.Size(817, 222)
        Me.grpServico.TabIndex = 0
        Me.grpServico.Text = "Dados do Serviço"
        Me.grpServico.VisualStyleManager = Me.vsmMain
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
        Me.cboGrupoItemCompras.TabIndex = 62
        Me.cboGrupoItemCompras.Tag = ""
        '
        'lblGrupoItem
        '
        Me.lblGrupoItem.AutoSize = True
        Me.lblGrupoItem.ForeColor = System.Drawing.Color.Firebrick
        Me.lblGrupoItem.Location = New System.Drawing.Point(7, 17)
        Me.lblGrupoItem.Name = "lblGrupoItem"
        Me.lblGrupoItem.Size = New System.Drawing.Size(62, 14)
        Me.lblGrupoItem.TabIndex = 63
        Me.lblGrupoItem.Tag = ""
        Me.lblGrupoItem.Text = "Grupo Item:"
        '
        'cboServico
        '
        Me.cboServico.AutoSize = False
        Me.cboServico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboServico.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboServico.Location = New System.Drawing.Point(555, 34)
        Me.cboServico.Name = "cboServico"
        Me.cboServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboServico.ReadOnly = True
        Me.cboServico.Size = New System.Drawing.Size(255, 20)
        Me.cboServico.TabIndex = 64
        Me.cboServico.TabStop = False
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.ForeColor = System.Drawing.Color.Black
        Me.lblServico.Location = New System.Drawing.Point(552, 17)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(47, 14)
        Me.lblServico.TabIndex = 65
        Me.lblServico.Text = "Serviço:"
        '
        'txtAliquotaIR
        '
        Me.txtAliquotaIR.DecimalDigits = 2
        Me.txtAliquotaIR.Location = New System.Drawing.Point(606, 153)
        Me.txtAliquotaIR.Name = "txtAliquotaIR"
        Me.txtAliquotaIR.Size = New System.Drawing.Size(39, 20)
        Me.txtAliquotaIR.TabIndex = 14
        Me.txtAliquotaIR.Text = "0,00"
        Me.txtAliquotaIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIR
        '
        Me.lblAliquotaIR.AutoSize = True
        Me.lblAliquotaIR.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaIR.Location = New System.Drawing.Point(603, 136)
        Me.lblAliquotaIR.Name = "lblAliquotaIR"
        Me.lblAliquotaIR.Size = New System.Drawing.Size(32, 14)
        Me.lblAliquotaIR.TabIndex = 61
        Me.lblAliquotaIR.Text = "% IR:"
        '
        'txtAliquotaCSLL
        '
        Me.txtAliquotaCSLL.DecimalDigits = 2
        Me.txtAliquotaCSLL.Location = New System.Drawing.Point(554, 153)
        Me.txtAliquotaCSLL.Name = "txtAliquotaCSLL"
        Me.txtAliquotaCSLL.Size = New System.Drawing.Size(46, 20)
        Me.txtAliquotaCSLL.TabIndex = 13
        Me.txtAliquotaCSLL.Text = "0,00"
        Me.txtAliquotaCSLL.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCSLL
        '
        Me.lblAliquotaCSLL.AutoSize = True
        Me.lblAliquotaCSLL.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaCSLL.Location = New System.Drawing.Point(551, 136)
        Me.lblAliquotaCSLL.Name = "lblAliquotaCSLL"
        Me.lblAliquotaCSLL.Size = New System.Drawing.Size(49, 14)
        Me.lblAliquotaCSLL.TabIndex = 60
        Me.lblAliquotaCSLL.Text = "% CSLL:"
        '
        'txtAliquotaINSS
        '
        Me.txtAliquotaINSS.DecimalDigits = 2
        Me.txtAliquotaINSS.Location = New System.Drawing.Point(505, 153)
        Me.txtAliquotaINSS.Name = "txtAliquotaINSS"
        Me.txtAliquotaINSS.Size = New System.Drawing.Size(43, 20)
        Me.txtAliquotaINSS.TabIndex = 12
        Me.txtAliquotaINSS.Text = "0,00"
        Me.txtAliquotaINSS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaINSS
        '
        Me.lblAliquotaINSS.AutoSize = True
        Me.lblAliquotaINSS.BackColor = System.Drawing.Color.Transparent
        Me.lblAliquotaINSS.Location = New System.Drawing.Point(502, 136)
        Me.lblAliquotaINSS.Name = "lblAliquotaINSS"
        Me.lblAliquotaINSS.Size = New System.Drawing.Size(46, 14)
        Me.lblAliquotaINSS.TabIndex = 59
        Me.lblAliquotaINSS.Text = "% INSS:"
        '
        'btnProcurarServico
        '
        Me.btnProcurarServico.FlatAppearance.BorderSize = 0
        Me.btnProcurarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarServico.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarServico.Location = New System.Drawing.Point(531, 16)
        Me.btnProcurarServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarServico.Name = "btnProcurarServico"
        Me.btnProcurarServico.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarServico.TabIndex = 54
        Me.btnProcurarServico.TabStop = False
        Me.btnProcurarServico.UseVisualStyleBackColor = True
        '
        'txtValorUnitarioDesconto
        '
        Me.txtValorUnitarioDesconto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorUnitarioDesconto.DecimalDigits = 2
        Me.txtValorUnitarioDesconto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnitarioDesconto.Location = New System.Drawing.Point(261, 153)
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
        Me.lblValorUnitarioDesconto.Location = New System.Drawing.Point(258, 136)
        Me.lblValorUnitarioDesconto.Name = "lblValorUnitarioDesconto"
        Me.lblValorUnitarioDesconto.Size = New System.Drawing.Size(108, 14)
        Me.lblValorUnitarioDesconto.TabIndex = 21
        Me.lblValorUnitarioDesconto.Text = "Valor Unit. Desconto:"
        '
        'lblAliquotaPISCOFINS
        '
        Me.lblAliquotaPISCOFINS.AutoSize = True
        Me.lblAliquotaPISCOFINS.Location = New System.Drawing.Point(421, 136)
        Me.lblAliquotaPISCOFINS.Name = "lblAliquotaPISCOFINS"
        Me.lblAliquotaPISCOFINS.Size = New System.Drawing.Size(78, 14)
        Me.lblAliquotaPISCOFINS.TabIndex = 25
        Me.lblAliquotaPISCOFINS.Text = "% PIS/COFINS:"
        '
        'lblAliquotaISS
        '
        Me.lblAliquotaISS.AutoSize = True
        Me.lblAliquotaISS.Location = New System.Drawing.Point(368, 136)
        Me.lblAliquotaISS.Name = "lblAliquotaISS"
        Me.lblAliquotaISS.Size = New System.Drawing.Size(39, 14)
        Me.lblAliquotaISS.TabIndex = 23
        Me.lblAliquotaISS.Text = "% ISS:"
        '
        'txtAliquotaPISCOFINS
        '
        Me.txtAliquotaPISCOFINS.DecimalDigits = 2
        Me.txtAliquotaPISCOFINS.Location = New System.Drawing.Point(424, 153)
        Me.txtAliquotaPISCOFINS.MaxLength = 0
        Me.txtAliquotaPISCOFINS.Name = "txtAliquotaPISCOFINS"
        Me.txtAliquotaPISCOFINS.Size = New System.Drawing.Size(75, 20)
        Me.txtAliquotaPISCOFINS.TabIndex = 11
        Me.txtAliquotaPISCOFINS.Text = "0,00"
        Me.txtAliquotaPISCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.DecimalDigits = 4
        Me.txtValorUnitario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnitario.Location = New System.Drawing.Point(10, 153)
        Me.txtValorUnitario.MaxLength = 0
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(71, 20)
        Me.txtValorUnitario.TabIndex = 6
        Me.txtValorUnitario.Text = "0,0000"
        Me.txtValorUnitario.Value = 0R
        Me.txtValorUnitario.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.ForeColor = System.Drawing.Color.Firebrick
        Me.lblValorUnitario.Location = New System.Drawing.Point(6, 136)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitario.TabIndex = 15
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'txtValorTotalImposto
        '
        Me.txtValorTotalImposto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotalImposto.DecimalDigits = 2
        Me.txtValorTotalImposto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotalImposto.Location = New System.Drawing.Point(734, 153)
        Me.txtValorTotalImposto.MaxLength = 0
        Me.txtValorTotalImposto.Name = "txtValorTotalImposto"
        Me.txtValorTotalImposto.ReadOnly = True
        Me.txtValorTotalImposto.Size = New System.Drawing.Size(77, 20)
        Me.txtValorTotalImposto.TabIndex = 16
        Me.txtValorTotalImposto.TabStop = False
        Me.txtValorTotalImposto.Text = "0,00"
        Me.txtValorTotalImposto.Value = 0R
        Me.txtValorTotalImposto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorTotalImpostoProduto
        '
        Me.lblValorTotalImpostoProduto.AutoSize = True
        Me.lblValorTotalImpostoProduto.Location = New System.Drawing.Point(731, 136)
        Me.lblValorTotalImpostoProduto.Name = "lblValorTotalImpostoProduto"
        Me.lblValorTotalImpostoProduto.Size = New System.Drawing.Size(82, 14)
        Me.lblValorTotalImpostoProduto.TabIndex = 33
        Me.lblValorTotalImpostoProduto.Text = "Valor Total Imp.:"
        '
        'txtAliquotaISS
        '
        Me.txtAliquotaISS.DecimalDigits = 2
        Me.txtAliquotaISS.Location = New System.Drawing.Point(371, 153)
        Me.txtAliquotaISS.MaxLength = 0
        Me.txtAliquotaISS.Name = "txtAliquotaISS"
        Me.txtAliquotaISS.Size = New System.Drawing.Size(47, 20)
        Me.txtAliquotaISS.TabIndex = 10
        Me.txtAliquotaISS.Text = "0,00"
        Me.txtAliquotaISS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'dtpPrevisaoEntrega
        '
        '
        '
        '
        Me.dtpPrevisaoEntrega.DropDownCalendar.Name = ""
        Me.dtpPrevisaoEntrega.Location = New System.Drawing.Point(720, 113)
        Me.dtpPrevisaoEntrega.Name = "dtpPrevisaoEntrega"
        Me.dtpPrevisaoEntrega.Size = New System.Drawing.Size(91, 20)
        Me.dtpPrevisaoEntrega.TabIndex = 5
        Me.dtpPrevisaoEntrega.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(440, 177)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 41
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(424, 194)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(387, 20)
        Me.cboContaContabil.TabIndex = 18
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(25, 177)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 38
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(9, 194)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(409, 20)
        Me.cboCentroGasto.TabIndex = 17
        '
        'txtDescontoValor
        '
        Me.txtDescontoValor.DecimalDigits = 4
        Me.txtDescontoValor.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDescontoValor.Location = New System.Drawing.Point(166, 153)
        Me.txtDescontoValor.MaxLength = 0
        Me.txtDescontoValor.Name = "txtDescontoValor"
        Me.txtDescontoValor.Size = New System.Drawing.Size(89, 20)
        Me.txtDescontoValor.TabIndex = 8
        Me.txtDescontoValor.Text = "0,0000"
        Me.txtDescontoValor.Value = 0R
        Me.txtDescontoValor.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoValor
        '
        Me.lblDescontoValor.AutoSize = True
        Me.lblDescontoValor.Location = New System.Drawing.Point(163, 136)
        Me.lblDescontoValor.Name = "lblDescontoValor"
        Me.lblDescontoValor.Size = New System.Drawing.Size(92, 14)
        Me.lblDescontoValor.TabIndex = 19
        Me.lblDescontoValor.Text = "Desconto (Valor):"
        '
        'txtDescontoPercentual
        '
        Me.txtDescontoPercentual.DecimalDigits = 5
        Me.txtDescontoPercentual.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDescontoPercentual.Location = New System.Drawing.Point(86, 153)
        Me.txtDescontoPercentual.MaxLength = 0
        Me.txtDescontoPercentual.Name = "txtDescontoPercentual"
        Me.txtDescontoPercentual.Size = New System.Drawing.Size(74, 20)
        Me.txtDescontoPercentual.TabIndex = 7
        Me.txtDescontoPercentual.Text = "0,00000"
        Me.txtDescontoPercentual.Value = 0R
        Me.txtDescontoPercentual.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoPercentual
        '
        Me.lblDescontoPercentual.AutoSize = True
        Me.lblDescontoPercentual.Location = New System.Drawing.Point(83, 136)
        Me.lblDescontoPercentual.Name = "lblDescontoPercentual"
        Me.lblDescontoPercentual.Size = New System.Drawing.Size(77, 14)
        Me.lblDescontoPercentual.TabIndex = 17
        Me.lblDescontoPercentual.Text = "Desconto (%):"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(6, 96)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(74, 14)
        Me.lblComplemento.TabIndex = 5
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(9, 113)
        Me.txtComplemento.MaxLength = 500
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(539, 20)
        Me.txtComplemento.TabIndex = 2
        '
        'lblPrevisaoEntrega
        '
        Me.lblPrevisaoEntrega.AutoSize = True
        Me.lblPrevisaoEntrega.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPrevisaoEntrega.Location = New System.Drawing.Point(737, 96)
        Me.lblPrevisaoEntrega.Name = "lblPrevisaoEntrega"
        Me.lblPrevisaoEntrega.Size = New System.Drawing.Size(74, 14)
        Me.lblPrevisaoEntrega.TabIndex = 13
        Me.lblPrevisaoEntrega.Text = "Prev. Entrega:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.DecimalDigits = 2
        Me.txtValorTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(651, 153)
        Me.txtValorTotal.MaxLength = 0
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(77, 20)
        Me.txtValorTotal.TabIndex = 15
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = 0R
        Me.txtValorTotal.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorTotalProduto
        '
        Me.lblValorTotalProduto.AutoSize = True
        Me.lblValorTotalProduto.Location = New System.Drawing.Point(648, 136)
        Me.lblValorTotalProduto.Name = "lblValorTotalProduto"
        Me.lblValorTotalProduto.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotalProduto.TabIndex = 29
        Me.lblValorTotalProduto.Text = "Valor Total:"
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.ForeColor = System.Drawing.Color.Firebrick
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(655, 96)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedida.TabIndex = 10
        Me.lblUnidadeMedida.Text = "Und. Med.:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(637, 113)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(77, 20)
        Me.cboUnidadeMedida.TabIndex = 4
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(554, 113)
        Me.txtQuantidade.MaxLength = 0
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(77, 20)
        Me.txtQuantidade.TabIndex = 3
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ForeColor = System.Drawing.Color.Firebrick
        Me.lblQuantidade.Location = New System.Drawing.Point(551, 96)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 7
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(793, 176)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 43
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(400, 176)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 40
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(424, 178)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 38
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(9, 176)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 37
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnDesmembrarPrevisaoEntrega
        '
        Me.btnDesmembrarPrevisaoEntrega.FlatAppearance.BorderSize = 0
        Me.btnDesmembrarPrevisaoEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesmembrarPrevisaoEntrega.Image = Global.INTERACTI.My.Resources.Resources.calendario
        Me.btnDesmembrarPrevisaoEntrega.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDesmembrarPrevisaoEntrega.Location = New System.Drawing.Point(717, 95)
        Me.btnDesmembrarPrevisaoEntrega.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDesmembrarPrevisaoEntrega.Name = "btnDesmembrarPrevisaoEntrega"
        Me.btnDesmembrarPrevisaoEntrega.Size = New System.Drawing.Size(17, 17)
        Me.btnDesmembrarPrevisaoEntrega.TabIndex = 12
        Me.btnDesmembrarPrevisaoEntrega.TabStop = False
        Me.btnDesmembrarPrevisaoEntrega.UseVisualStyleBackColor = True
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(639, 97)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 9
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Controls.Add(Me.btnInserirProduto)
        Me.grpControl2.Location = New System.Drawing.Point(8, 224)
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
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 73)
        Me.txtDescricao.MaxLength = 500
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(800, 20)
        Me.txtDescricao.TabIndex = 66
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ForeColor = System.Drawing.Color.Black
        Me.lblDescricao.Location = New System.Drawing.Point(7, 56)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 67
        Me.lblDescricao.Text = "Descrição:"
        '
        'frmCmpPedidoNovoServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 312)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmCmpPedidoNovoServico"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pedido de Compra"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServico.ResumeLayout(False)
        Me.grpServico.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpServico As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAliquotaPISCOFINS As System.Windows.Forms.Label
    Friend WithEvents lblAliquotaISS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPISCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents txtValorTotalImposto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotalImpostoProduto As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaISS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpPrevisaoEntrega As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescontoValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoValor As System.Windows.Forms.Label
    Friend WithEvents txtDescontoPercentual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoPercentual As System.Windows.Forms.Label
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents txtComplemento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPrevisaoEntrega As System.Windows.Forms.Label
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotalProduto As System.Windows.Forms.Label
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnDesmembrarPrevisaoEntrega As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValorUnitarioDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitarioDesconto As System.Windows.Forms.Label
    Friend WithEvents btnProcurarServico As System.Windows.Forms.Button
    Friend WithEvents txtAliquotaIR As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIR As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCSLL As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCSLL As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaINSS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaINSS As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemCompras As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItem As Label
    Friend WithEvents cboServico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblServico As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
End Class
