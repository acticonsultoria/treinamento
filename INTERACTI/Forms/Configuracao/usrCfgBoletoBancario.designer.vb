<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCfgBoletoBancario
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCfgBoletoBancario))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem9 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem10 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem11 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem12 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem13 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem14 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroDias3 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroDias3 = New System.Windows.Forms.Label()
        Me.cboInstrucao3 = New Janus.Windows.EditControls.UIComboBox()
        Me.lblInstrucao3 = New System.Windows.Forms.Label()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.txtNumeroDias2 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroDias2 = New System.Windows.Forms.Label()
        Me.txtNumeroDias1 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroDias1 = New System.Windows.Forms.Label()
        Me.cboInstrucao2 = New Janus.Windows.EditControls.UIComboBox()
        Me.lblInstrucao2 = New System.Windows.Forms.Label()
        Me.cboInstrucao1 = New Janus.Windows.EditControls.UIComboBox()
        Me.txtConvenio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblConvenio = New System.Windows.Forms.Label()
        Me.cboCNAB = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCNAB = New System.Windows.Forms.Label()
        Me.lblInstrucao1 = New System.Windows.Forms.Label()
        Me.txtMulta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMulta = New System.Windows.Forms.Label()
        Me.txtJuros = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblJuros = New System.Windows.Forms.Label()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'grpControle
        '
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSalvar)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(9, 426)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(493, 51)
        Me.grpControle.TabIndex = 1
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(295, 14)
        Me.btnSalvar.Name = "btnSalvar"
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
        Me.btnSair.Location = New System.Drawing.Point(392, 14)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtNumeroDias3)
        Me.grpDados.Controls.Add(Me.lblNumeroDias3)
        Me.grpDados.Controls.Add(Me.cboInstrucao3)
        Me.grpDados.Controls.Add(Me.lblInstrucao3)
        Me.grpDados.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpDados.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpDados.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpDados.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpDados.Controls.Add(Me.cboCentroGasto)
        Me.grpDados.Controls.Add(Me.lblCentroGasto)
        Me.grpDados.Controls.Add(Me.txtNumeroDias2)
        Me.grpDados.Controls.Add(Me.lblNumeroDias2)
        Me.grpDados.Controls.Add(Me.txtNumeroDias1)
        Me.grpDados.Controls.Add(Me.lblNumeroDias1)
        Me.grpDados.Controls.Add(Me.cboInstrucao2)
        Me.grpDados.Controls.Add(Me.lblInstrucao2)
        Me.grpDados.Controls.Add(Me.cboInstrucao1)
        Me.grpDados.Controls.Add(Me.txtConvenio)
        Me.grpDados.Controls.Add(Me.lblConvenio)
        Me.grpDados.Controls.Add(Me.cboCNAB)
        Me.grpDados.Controls.Add(Me.lblCNAB)
        Me.grpDados.Controls.Add(Me.lblInstrucao1)
        Me.grpDados.Controls.Add(Me.txtMulta)
        Me.grpDados.Controls.Add(Me.lblMulta)
        Me.grpDados.Controls.Add(Me.txtJuros)
        Me.grpDados.Controls.Add(Me.lblJuros)
        Me.grpDados.Controls.Add(Me.cboContaBancaria)
        Me.grpDados.Controls.Add(Me.lblContaBancaria)
        Me.grpDados.Controls.Add(Me.cboContaContabil)
        Me.grpDados.Controls.Add(Me.lblContaContabil)
        Me.grpDados.Location = New System.Drawing.Point(9, 121)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(493, 302)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroDias3
        '
        Me.txtNumeroDias3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroDias3.DecimalDigits = 0
        Me.txtNumeroDias3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDias3.Location = New System.Drawing.Point(393, 274)
        Me.txtNumeroDias3.MaxLength = 0
        Me.txtNumeroDias3.Name = "txtNumeroDias3"
        Me.txtNumeroDias3.Size = New System.Drawing.Size(91, 20)
        Me.txtNumeroDias3.TabIndex = 29
        Me.txtNumeroDias3.Text = "0"
        Me.txtNumeroDias3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNumeroDias3.Value = 0.0R
        Me.txtNumeroDias3.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblNumeroDias3
        '
        Me.lblNumeroDias3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroDias3.AutoSize = True
        Me.lblNumeroDias3.Location = New System.Drawing.Point(389, 257)
        Me.lblNumeroDias3.Name = "lblNumeroDias3"
        Me.lblNumeroDias3.Size = New System.Drawing.Size(46, 14)
        Me.lblNumeroDias3.TabIndex = 28
        Me.lblNumeroDias3.Text = "Nº Dias:"
        '
        'cboInstrucao3
        '
        Me.cboInstrucao3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboInstrucao3.AutoSize = False
        Me.cboInstrucao3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboInstrucao3.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboInstrucao3.Location = New System.Drawing.Point(11, 274)
        Me.cboInstrucao3.Name = "cboInstrucao3"
        Me.cboInstrucao3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboInstrucao3.Size = New System.Drawing.Size(375, 20)
        Me.cboInstrucao3.TabIndex = 27
        '
        'lblInstrucao3
        '
        Me.lblInstrucao3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInstrucao3.AutoSize = True
        Me.lblInstrucao3.Location = New System.Drawing.Point(8, 257)
        Me.lblInstrucao3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblInstrucao3.Name = "lblInstrucao3"
        Me.lblInstrucao3.Size = New System.Drawing.Size(129, 14)
        Me.lblInstrucao3.TabIndex = 26
        Me.lblInstrucao3.Text = "Instrução de Cobrança 3:"
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(466, 96)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 8
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(466, 56)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 4
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(10, 98)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 6
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(10, 58)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 2
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboCentroGasto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboCentroGasto.Location = New System.Drawing.Point(10, 74)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(473, 20)
        Me.cboCentroGasto.TabIndex = 5
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(26, 57)
        Me.lblCentroGasto.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(88, 14)
        Me.lblCentroGasto.TabIndex = 3
        Me.lblCentroGasto.Text = "Centro de Custo:"
        '
        'txtNumeroDias2
        '
        Me.txtNumeroDias2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroDias2.DecimalDigits = 0
        Me.txtNumeroDias2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDias2.Location = New System.Drawing.Point(393, 234)
        Me.txtNumeroDias2.MaxLength = 0
        Me.txtNumeroDias2.Name = "txtNumeroDias2"
        Me.txtNumeroDias2.Size = New System.Drawing.Size(91, 20)
        Me.txtNumeroDias2.TabIndex = 25
        Me.txtNumeroDias2.Text = "0"
        Me.txtNumeroDias2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNumeroDias2.Value = 0.0R
        Me.txtNumeroDias2.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblNumeroDias2
        '
        Me.lblNumeroDias2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroDias2.AutoSize = True
        Me.lblNumeroDias2.Location = New System.Drawing.Point(389, 217)
        Me.lblNumeroDias2.Name = "lblNumeroDias2"
        Me.lblNumeroDias2.Size = New System.Drawing.Size(46, 14)
        Me.lblNumeroDias2.TabIndex = 24
        Me.lblNumeroDias2.Text = "Nº Dias:"
        '
        'txtNumeroDias1
        '
        Me.txtNumeroDias1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroDias1.DecimalDigits = 0
        Me.txtNumeroDias1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDias1.Location = New System.Drawing.Point(393, 194)
        Me.txtNumeroDias1.MaxLength = 0
        Me.txtNumeroDias1.Name = "txtNumeroDias1"
        Me.txtNumeroDias1.Size = New System.Drawing.Size(91, 20)
        Me.txtNumeroDias1.TabIndex = 21
        Me.txtNumeroDias1.Text = "0"
        Me.txtNumeroDias1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNumeroDias1.Value = 0.0R
        Me.txtNumeroDias1.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblNumeroDias1
        '
        Me.lblNumeroDias1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroDias1.AutoSize = True
        Me.lblNumeroDias1.Location = New System.Drawing.Point(389, 177)
        Me.lblNumeroDias1.Name = "lblNumeroDias1"
        Me.lblNumeroDias1.Size = New System.Drawing.Size(46, 14)
        Me.lblNumeroDias1.TabIndex = 20
        Me.lblNumeroDias1.Text = "Nº Dias:"
        '
        'cboInstrucao2
        '
        Me.cboInstrucao2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboInstrucao2.AutoSize = False
        Me.cboInstrucao2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboInstrucao2.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboInstrucao2.Location = New System.Drawing.Point(11, 234)
        Me.cboInstrucao2.Name = "cboInstrucao2"
        Me.cboInstrucao2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboInstrucao2.Size = New System.Drawing.Size(375, 20)
        Me.cboInstrucao2.TabIndex = 23
        '
        'lblInstrucao2
        '
        Me.lblInstrucao2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInstrucao2.AutoSize = True
        Me.lblInstrucao2.Location = New System.Drawing.Point(8, 217)
        Me.lblInstrucao2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblInstrucao2.Name = "lblInstrucao2"
        Me.lblInstrucao2.Size = New System.Drawing.Size(129, 14)
        Me.lblInstrucao2.TabIndex = 22
        Me.lblInstrucao2.Text = "Instrução de Cobrança 2:"
        '
        'cboInstrucao1
        '
        Me.cboInstrucao1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboInstrucao1.AutoSize = False
        Me.cboInstrucao1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = "SIM"
        UiComboBoxItem7.Value = True
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = "NÃO"
        UiComboBoxItem8.Value = False
        Me.cboInstrucao1.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboInstrucao1.Location = New System.Drawing.Point(11, 194)
        Me.cboInstrucao1.Name = "cboInstrucao1"
        Me.cboInstrucao1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboInstrucao1.Size = New System.Drawing.Size(375, 20)
        Me.cboInstrucao1.TabIndex = 19
        '
        'txtConvenio
        '
        Me.txtConvenio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtConvenio.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtConvenio.Location = New System.Drawing.Point(393, 154)
        Me.txtConvenio.MaxLength = 9
        Me.txtConvenio.Name = "txtConvenio"
        Me.txtConvenio.Size = New System.Drawing.Size(91, 20)
        Me.txtConvenio.TabIndex = 17
        '
        'lblConvenio
        '
        Me.lblConvenio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblConvenio.AutoSize = True
        Me.lblConvenio.Location = New System.Drawing.Point(390, 137)
        Me.lblConvenio.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblConvenio.Name = "lblConvenio"
        Me.lblConvenio.Size = New System.Drawing.Size(55, 14)
        Me.lblConvenio.TabIndex = 16
        Me.lblConvenio.Text = "Convênio:"
        '
        'cboCNAB
        '
        Me.cboCNAB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCNAB.AutoSize = False
        Me.cboCNAB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem9.FormatStyle.Alpha = 0
        UiComboBoxItem9.IsSeparator = False
        UiComboBoxItem9.Text = "SIM"
        UiComboBoxItem9.Value = True
        UiComboBoxItem10.FormatStyle.Alpha = 0
        UiComboBoxItem10.IsSeparator = False
        UiComboBoxItem10.Text = "NÃO"
        UiComboBoxItem10.Value = False
        Me.cboCNAB.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem9, UiComboBoxItem10})
        Me.cboCNAB.Location = New System.Drawing.Point(205, 154)
        Me.cboCNAB.Name = "cboCNAB"
        Me.cboCNAB.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCNAB.Size = New System.Drawing.Size(181, 20)
        Me.cboCNAB.TabIndex = 15
        '
        'lblCNAB
        '
        Me.lblCNAB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCNAB.AutoSize = True
        Me.lblCNAB.Location = New System.Drawing.Point(202, 137)
        Me.lblCNAB.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblCNAB.Name = "lblCNAB"
        Me.lblCNAB.Size = New System.Drawing.Size(39, 14)
        Me.lblCNAB.TabIndex = 14
        Me.lblCNAB.Text = "CNAB:"
        '
        'lblInstrucao1
        '
        Me.lblInstrucao1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInstrucao1.AutoSize = True
        Me.lblInstrucao1.Location = New System.Drawing.Point(8, 177)
        Me.lblInstrucao1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblInstrucao1.Name = "lblInstrucao1"
        Me.lblInstrucao1.Size = New System.Drawing.Size(129, 14)
        Me.lblInstrucao1.TabIndex = 18
        Me.lblInstrucao1.Text = "Instrução de Cobrança 1:"
        '
        'txtMulta
        '
        Me.txtMulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMulta.DecimalDigits = 2
        Me.txtMulta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMulta.Location = New System.Drawing.Point(108, 154)
        Me.txtMulta.MaxLength = 0
        Me.txtMulta.Name = "txtMulta"
        Me.txtMulta.Size = New System.Drawing.Size(91, 20)
        Me.txtMulta.TabIndex = 13
        Me.txtMulta.Text = "0,00"
        Me.txtMulta.Value = 0.0R
        Me.txtMulta.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblMulta
        '
        Me.lblMulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMulta.AutoSize = True
        Me.lblMulta.Location = New System.Drawing.Point(105, 137)
        Me.lblMulta.Name = "lblMulta"
        Me.lblMulta.Size = New System.Drawing.Size(35, 14)
        Me.lblMulta.TabIndex = 12
        Me.lblMulta.Text = "Multa:"
        '
        'txtJuros
        '
        Me.txtJuros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtJuros.DecimalDigits = 2
        Me.txtJuros.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuros.Location = New System.Drawing.Point(11, 154)
        Me.txtJuros.MaxLength = 0
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(91, 20)
        Me.txtJuros.TabIndex = 11
        Me.txtJuros.Text = "0,00"
        Me.txtJuros.Value = 0.0R
        Me.txtJuros.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblJuros
        '
        Me.lblJuros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblJuros.AutoSize = True
        Me.lblJuros.Location = New System.Drawing.Point(8, 137)
        Me.lblJuros.Name = "lblJuros"
        Me.lblJuros.Size = New System.Drawing.Size(79, 14)
        Me.lblJuros.TabIndex = 10
        Me.lblJuros.Text = "Juros de Mora:"
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.AutoSize = False
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem11.FormatStyle.Alpha = 0
        UiComboBoxItem11.IsSeparator = False
        UiComboBoxItem11.Text = "SIM"
        UiComboBoxItem11.Value = True
        UiComboBoxItem12.FormatStyle.Alpha = 0
        UiComboBoxItem12.IsSeparator = False
        UiComboBoxItem12.Text = "NÃO"
        UiComboBoxItem12.Value = False
        Me.cboContaBancaria.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem11, UiComboBoxItem12})
        Me.cboContaBancaria.Location = New System.Drawing.Point(10, 34)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancaria.Size = New System.Drawing.Size(473, 20)
        Me.cboContaBancaria.TabIndex = 1
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.Location = New System.Drawing.Point(7, 17)
        Me.lblContaBancaria.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 0
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem13.FormatStyle.Alpha = 0
        UiComboBoxItem13.IsSeparator = False
        UiComboBoxItem13.Text = "SIM"
        UiComboBoxItem13.Value = True
        UiComboBoxItem14.FormatStyle.Alpha = 0
        UiComboBoxItem14.IsSeparator = False
        UiComboBoxItem14.Text = "NÃO"
        UiComboBoxItem14.Value = False
        Me.cboContaContabil.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem13, UiComboBoxItem14})
        Me.cboContaContabil.Location = New System.Drawing.Point(10, 114)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(473, 20)
        Me.cboContaContabil.TabIndex = 9
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(26, 97)
        Me.lblContaContabil.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 7
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'picSistema
        '
        Me.picSistema.BackColor = System.Drawing.Color.White
        Me.picSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSistema.Image = Global.INTERACTI.My.Resources.Resources.interacti
        Me.picSistema.Location = New System.Drawing.Point(9, 9)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(493, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 16
        Me.picSistema.TabStop = False
        '
        'usrCfgBoletoBancario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picSistema)
        Me.Controls.Add(Me.grpControle)
        Me.Controls.Add(Me.grpDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCfgBoletoBancario"
        Me.Size = New System.Drawing.Size(511, 483)
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtMulta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMulta As System.Windows.Forms.Label
    Friend WithEvents txtJuros As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblJuros As System.Windows.Forms.Label
    Friend WithEvents lblInstrucao1 As System.Windows.Forms.Label
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents txtConvenio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblConvenio As System.Windows.Forms.Label
    Friend WithEvents cboCNAB As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCNAB As System.Windows.Forms.Label
    Friend WithEvents cboInstrucao2 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblInstrucao2 As System.Windows.Forms.Label
    Friend WithEvents cboInstrucao1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroDias2 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroDias2 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDias1 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroDias1 As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents txtNumeroDias3 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroDias3 As System.Windows.Forms.Label
    Friend WithEvents cboInstrucao3 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblInstrucao3 As System.Windows.Forms.Label

End Class
