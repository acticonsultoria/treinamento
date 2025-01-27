<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadPlanoContas
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtContaContabilFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblContaContabilFiltro = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.trvMain = New System.Windows.Forms.TreeView()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCodigoIntegracao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoIntegracao = New System.Windows.Forms.Label()
        Me.cboItemSuperior = New Janus.Windows.EditControls.UIComboBox()
        Me.lblItemSuperior = New System.Windows.Forms.Label()
        Me.cboOrigem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrigem = New System.Windows.Forms.Label()
        Me.txtNomeConta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeConta = New System.Windows.Forms.Label()
        Me.txtContaContabil = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.lblCfop = New System.Windows.Forms.Label()
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpFiltro)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Controls.Add(Me.trvMain)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Plano de Contas"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtContaContabilFiltro)
        Me.grpFiltro.Controls.Add(Me.lblContaContabilFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(374, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(274, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtContaContabilFiltro
        '
        Me.txtContaContabilFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContaContabilFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtContaContabilFiltro.MaxLength = 100
        Me.txtContaContabilFiltro.Name = "txtContaContabilFiltro"
        Me.txtContaContabilFiltro.Size = New System.Drawing.Size(250, 20)
        Me.txtContaContabilFiltro.TabIndex = 1
        '
        'lblContaContabilFiltro
        '
        Me.lblContaContabilFiltro.AutoSize = True
        Me.lblContaContabilFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblContaContabilFiltro.Name = "lblContaContabilFiltro"
        Me.lblContaContabilFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabilFiltro.TabIndex = 0
        Me.lblContaContabilFiltro.Text = "Conta Contábil:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(603, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(506, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'trvMain
        '
        Me.trvMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvMain.CheckBoxes = True
        Me.trvMain.FullRowSelect = True
        Me.trvMain.HideSelection = False
        Me.trvMain.ItemHeight = 20
        Me.trvMain.Location = New System.Drawing.Point(8, 76)
        Me.trvMain.Name = "trvMain"
        Me.trvMain.ShowLines = False
        Me.trvMain.ShowNodeToolTips = True
        Me.trvMain.Size = New System.Drawing.Size(374, 404)
        Me.trvMain.TabIndex = 1
        Me.trvMain.TabStop = False
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblCfop)
        Me.grpDados.Controls.Add(Me.cboCFOP)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.txtCodigoIntegracao)
        Me.grpDados.Controls.Add(Me.lblCodigoIntegracao)
        Me.grpDados.Controls.Add(Me.cboItemSuperior)
        Me.grpDados.Controls.Add(Me.lblItemSuperior)
        Me.grpDados.Controls.Add(Me.cboOrigem)
        Me.grpDados.Controls.Add(Me.lblOrigem)
        Me.grpDados.Controls.Add(Me.txtNomeConta)
        Me.grpDados.Controls.Add(Me.lblNomeConta)
        Me.grpDados.Controls.Add(Me.txtContaContabil)
        Me.grpDados.Controls.Add(Me.lblContaContabil)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(391, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(514, 143)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados da Conta Contábil"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblAtivo
        '
        Me.lblAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAtivo.Location = New System.Drawing.Point(428, 57)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 8
        Me.lblAtivo.Text = "Ativo:"
        '
        'cboAtivo
        '
        Me.cboAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = ""
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = ""
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboAtivo.Location = New System.Drawing.Point(431, 74)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(74, 20)
        Me.cboAtivo.TabIndex = 4
        '
        'txtCodigoIntegracao
        '
        Me.txtCodigoIntegracao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoIntegracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoIntegracao.Location = New System.Drawing.Point(259, 74)
        Me.txtCodigoIntegracao.MaxLength = 50
        Me.txtCodigoIntegracao.Name = "txtCodigoIntegracao"
        Me.txtCodigoIntegracao.Size = New System.Drawing.Size(166, 20)
        Me.txtCodigoIntegracao.TabIndex = 3
        '
        'lblCodigoIntegracao
        '
        Me.lblCodigoIntegracao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoIntegracao.AutoSize = True
        Me.lblCodigoIntegracao.Location = New System.Drawing.Point(256, 57)
        Me.lblCodigoIntegracao.Name = "lblCodigoIntegracao"
        Me.lblCodigoIntegracao.Size = New System.Drawing.Size(97, 14)
        Me.lblCodigoIntegracao.TabIndex = 6
        Me.lblCodigoIntegracao.Text = "Código Integração:"
        '
        'cboItemSuperior
        '
        Me.cboItemSuperior.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboItemSuperior.Location = New System.Drawing.Point(259, 34)
        Me.cboItemSuperior.Name = "cboItemSuperior"
        Me.cboItemSuperior.Size = New System.Drawing.Size(246, 20)
        Me.cboItemSuperior.TabIndex = 1
        '
        'lblItemSuperior
        '
        Me.lblItemSuperior.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemSuperior.AutoSize = True
        Me.lblItemSuperior.Location = New System.Drawing.Point(256, 17)
        Me.lblItemSuperior.Name = "lblItemSuperior"
        Me.lblItemSuperior.Size = New System.Drawing.Size(73, 14)
        Me.lblItemSuperior.TabIndex = 2
        Me.lblItemSuperior.Text = "Item Superior:"
        '
        'cboOrigem
        '
        Me.cboOrigem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOrigem.Location = New System.Drawing.Point(9, 34)
        Me.cboOrigem.Name = "cboOrigem"
        Me.cboOrigem.Size = New System.Drawing.Size(244, 20)
        Me.cboOrigem.TabIndex = 0
        '
        'lblOrigem
        '
        Me.lblOrigem.AutoSize = True
        Me.lblOrigem.Location = New System.Drawing.Point(6, 17)
        Me.lblOrigem.Name = "lblOrigem"
        Me.lblOrigem.Size = New System.Drawing.Size(44, 14)
        Me.lblOrigem.TabIndex = 0
        Me.lblOrigem.Text = "Origem:"
        '
        'txtNomeConta
        '
        Me.txtNomeConta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomeConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeConta.Location = New System.Drawing.Point(9, 113)
        Me.txtNomeConta.MaxLength = 50
        Me.txtNomeConta.Name = "txtNomeConta"
        Me.txtNomeConta.Size = New System.Drawing.Size(416, 20)
        Me.txtNomeConta.TabIndex = 5
        '
        'lblNomeConta
        '
        Me.lblNomeConta.AutoSize = True
        Me.lblNomeConta.Location = New System.Drawing.Point(6, 96)
        Me.lblNomeConta.Name = "lblNomeConta"
        Me.lblNomeConta.Size = New System.Drawing.Size(83, 14)
        Me.lblNomeConta.TabIndex = 10
        Me.lblNomeConta.Text = "Nome da Conta:"
        '
        'txtContaContabil
        '
        Me.txtContaContabil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContaContabil.Location = New System.Drawing.Point(9, 74)
        Me.txtContaContabil.MaxLength = 50
        Me.txtContaContabil.Name = "txtContaContabil"
        Me.txtContaContabil.Size = New System.Drawing.Size(244, 20)
        Me.txtContaContabil.TabIndex = 2
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(6, 57)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 4
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'lblCfop
        '
        Me.lblCfop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCfop.AutoSize = True
        Me.lblCfop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCfop.Location = New System.Drawing.Point(428, 96)
        Me.lblCfop.Name = "lblCfop"
        Me.lblCfop.Size = New System.Drawing.Size(37, 14)
        Me.lblCfop.TabIndex = 15
        Me.lblCfop.Text = "CFOP:"
        '
        'cboCFOP
        '
        Me.cboCFOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = ""
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = ""
        Me.cboCFOP.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboCFOP.Location = New System.Drawing.Point(431, 113)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(74, 20)
        Me.cboCFOP.TabIndex = 7
        '
        'usrCadPlanoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadPlanoContas"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtContaContabilFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblContaContabilFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents trvMain As System.Windows.Forms.TreeView
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboItemSuperior As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblItemSuperior As System.Windows.Forms.Label
    Friend WithEvents cboOrigem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrigem As System.Windows.Forms.Label
    Friend WithEvents txtNomeConta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeConta As System.Windows.Forms.Label
    Friend WithEvents txtContaContabil As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents txtCodigoIntegracao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoIntegracao As System.Windows.Forms.Label
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCfop As System.Windows.Forms.Label
    Friend WithEvents cboCFOP As Janus.Windows.EditControls.UIComboBox

End Class
