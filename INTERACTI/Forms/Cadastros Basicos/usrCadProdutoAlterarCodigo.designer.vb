<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadProdutoAlterarCodigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadProdutoAlterarCodigo))
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem9 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem10 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem11 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem12 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
        Me.btnProcurarItemEstoque = New System.Windows.Forms.Button()
        Me.btnProcurarItemFornecedor = New System.Windows.Forms.Button()
        Me.cboCodigoProdutoEstoque = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProdutoEstoque = New System.Windows.Forms.Label()
        Me.txtDescricaoProdutoEstoque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoProdutoEstoque = New System.Windows.Forms.Label()
        Me.cboCodigoProdutoFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProdutoFornecedor = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.txtDescricaoProdutoFornecedor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoProdutoFornecedor = New System.Windows.Forms.Label()
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
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(13, 163)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(634, 51)
        Me.grpControl.TabIndex = 1
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(431, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(528, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpDados.Controls.Add(Me.btnProcurarItemEstoque)
        Me.grpDados.Controls.Add(Me.btnProcurarItemFornecedor)
        Me.grpDados.Controls.Add(Me.cboCodigoProdutoEstoque)
        Me.grpDados.Controls.Add(Me.lblCodigoProdutoEstoque)
        Me.grpDados.Controls.Add(Me.txtDescricaoProdutoEstoque)
        Me.grpDados.Controls.Add(Me.lblDescricaoProdutoEstoque)
        Me.grpDados.Controls.Add(Me.cboCodigoProdutoFornecedor)
        Me.grpDados.Controls.Add(Me.lblCodigoProdutoFornecedor)
        Me.grpDados.Controls.Add(Me.cboFornecedor)
        Me.grpDados.Controls.Add(Me.lblFornecedor)
        Me.grpDados.Controls.Add(Me.txtDescricaoProdutoFornecedor)
        Me.grpDados.Controls.Add(Me.lblDescricaoProdutoFornecedor)
        Me.grpDados.Location = New System.Drawing.Point(13, 8)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(634, 149)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarFornecedor
        '
        Me.btnProcurarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(602, 102)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedor.TabIndex = 12
        Me.btnProcurarFornecedor.TabStop = False
        Me.btnProcurarFornecedor.UseVisualStyleBackColor = True
        '
        'btnProcurarItemEstoque
        '
        Me.btnProcurarItemEstoque.FlatAppearance.BorderSize = 0
        Me.btnProcurarItemEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItemEstoque.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItemEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItemEstoque.Location = New System.Drawing.Point(225, 57)
        Me.btnProcurarItemEstoque.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItemEstoque.Name = "btnProcurarItemEstoque"
        Me.btnProcurarItemEstoque.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItemEstoque.TabIndex = 7
        Me.btnProcurarItemEstoque.TabStop = False
        Me.btnProcurarItemEstoque.UseVisualStyleBackColor = True
        '
        'btnProcurarItemFornecedor
        '
        Me.btnProcurarItemFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarItemFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItemFornecedor.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItemFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItemFornecedor.Location = New System.Drawing.Point(225, 15)
        Me.btnProcurarItemFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItemFornecedor.Name = "btnProcurarItemFornecedor"
        Me.btnProcurarItemFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItemFornecedor.TabIndex = 2
        Me.btnProcurarItemFornecedor.TabStop = False
        Me.btnProcurarItemFornecedor.UseVisualStyleBackColor = True
        '
        'cboCodigoProdutoEstoque
        '
        Me.cboCodigoProdutoEstoque.AutoSize = False
        Me.cboCodigoProdutoEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = "SIM"
        UiComboBoxItem7.Value = True
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = "NÃO"
        UiComboBoxItem8.Value = False
        Me.cboCodigoProdutoEstoque.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboCodigoProdutoEstoque.Location = New System.Drawing.Point(9, 76)
        Me.cboCodigoProdutoEstoque.Name = "cboCodigoProdutoEstoque"
        Me.cboCodigoProdutoEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProdutoEstoque.Size = New System.Drawing.Size(233, 20)
        Me.cboCodigoProdutoEstoque.TabIndex = 6
        '
        'lblCodigoProdutoEstoque
        '
        Me.lblCodigoProdutoEstoque.AutoSize = True
        Me.lblCodigoProdutoEstoque.Location = New System.Drawing.Point(6, 59)
        Me.lblCodigoProdutoEstoque.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblCodigoProdutoEstoque.Name = "lblCodigoProdutoEstoque"
        Me.lblCodigoProdutoEstoque.Size = New System.Drawing.Size(186, 14)
        Me.lblCodigoProdutoEstoque.TabIndex = 5
        Me.lblCodigoProdutoEstoque.Text = "Código Produto no Estoque (correto):"
        '
        'txtDescricaoProdutoEstoque
        '
        Me.txtDescricaoProdutoEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoProdutoEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtDescricaoProdutoEstoque.Location = New System.Drawing.Point(248, 77)
        Me.txtDescricaoProdutoEstoque.MaxLength = 100
        Me.txtDescricaoProdutoEstoque.Name = "txtDescricaoProdutoEstoque"
        Me.txtDescricaoProdutoEstoque.ReadOnly = True
        Me.txtDescricaoProdutoEstoque.Size = New System.Drawing.Size(371, 20)
        Me.txtDescricaoProdutoEstoque.TabIndex = 9
        '
        'lblDescricaoProdutoEstoque
        '
        Me.lblDescricaoProdutoEstoque.AutoSize = True
        Me.lblDescricaoProdutoEstoque.Location = New System.Drawing.Point(245, 60)
        Me.lblDescricaoProdutoEstoque.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblDescricaoProdutoEstoque.Name = "lblDescricaoProdutoEstoque"
        Me.lblDescricaoProdutoEstoque.Size = New System.Drawing.Size(141, 14)
        Me.lblDescricaoProdutoEstoque.TabIndex = 8
        Me.lblDescricaoProdutoEstoque.Text = "Descrição Produto Estoque:"
        '
        'cboCodigoProdutoFornecedor
        '
        Me.cboCodigoProdutoFornecedor.AutoSize = False
        Me.cboCodigoProdutoFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem9.FormatStyle.Alpha = 0
        UiComboBoxItem9.IsSeparator = False
        UiComboBoxItem9.Text = "SIM"
        UiComboBoxItem9.Value = True
        UiComboBoxItem10.FormatStyle.Alpha = 0
        UiComboBoxItem10.IsSeparator = False
        UiComboBoxItem10.Text = "NÃO"
        UiComboBoxItem10.Value = False
        Me.cboCodigoProdutoFornecedor.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem9, UiComboBoxItem10})
        Me.cboCodigoProdutoFornecedor.Location = New System.Drawing.Point(9, 34)
        Me.cboCodigoProdutoFornecedor.Name = "cboCodigoProdutoFornecedor"
        Me.cboCodigoProdutoFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProdutoFornecedor.Size = New System.Drawing.Size(233, 20)
        Me.cboCodigoProdutoFornecedor.TabIndex = 1
        '
        'lblCodigoProdutoFornecedor
        '
        Me.lblCodigoProdutoFornecedor.AutoSize = True
        Me.lblCodigoProdutoFornecedor.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoProdutoFornecedor.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblCodigoProdutoFornecedor.Name = "lblCodigoProdutoFornecedor"
        Me.lblCodigoProdutoFornecedor.Size = New System.Drawing.Size(211, 14)
        Me.lblCodigoProdutoFornecedor.TabIndex = 0
        Me.lblCodigoProdutoFornecedor.Text = "Código Produto do Fornecedor (incorreto):"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.AutoSize = False
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem11.FormatStyle.Alpha = 0
        UiComboBoxItem11.IsSeparator = False
        UiComboBoxItem11.Text = "SIM"
        UiComboBoxItem11.Value = True
        UiComboBoxItem12.FormatStyle.Alpha = 0
        UiComboBoxItem12.IsSeparator = False
        UiComboBoxItem12.Text = "NÃO"
        UiComboBoxItem12.Value = False
        Me.cboFornecedor.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem11, UiComboBoxItem12})
        Me.cboFornecedor.Location = New System.Drawing.Point(9, 120)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedor.Size = New System.Drawing.Size(610, 20)
        Me.cboFornecedor.TabIndex = 11
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(6, 103)
        Me.lblFornecedor.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 10
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'txtDescricaoProdutoFornecedor
        '
        Me.txtDescricaoProdutoFornecedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoProdutoFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtDescricaoProdutoFornecedor.Location = New System.Drawing.Point(248, 35)
        Me.txtDescricaoProdutoFornecedor.MaxLength = 100
        Me.txtDescricaoProdutoFornecedor.Name = "txtDescricaoProdutoFornecedor"
        Me.txtDescricaoProdutoFornecedor.ReadOnly = True
        Me.txtDescricaoProdutoFornecedor.Size = New System.Drawing.Size(371, 20)
        Me.txtDescricaoProdutoFornecedor.TabIndex = 4
        '
        'lblDescricaoProdutoFornecedor
        '
        Me.lblDescricaoProdutoFornecedor.AutoSize = True
        Me.lblDescricaoProdutoFornecedor.Location = New System.Drawing.Point(245, 18)
        Me.lblDescricaoProdutoFornecedor.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblDescricaoProdutoFornecedor.Name = "lblDescricaoProdutoFornecedor"
        Me.lblDescricaoProdutoFornecedor.Size = New System.Drawing.Size(118, 14)
        Me.lblDescricaoProdutoFornecedor.TabIndex = 3
        Me.lblDescricaoProdutoFornecedor.Text = "Descrição Fornecedor:"
        '
        'usrCadProdutoAlterarCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.grpControl)
        Me.Controls.Add(Me.grpDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadProdutoAlterarCodigo"
        Me.Size = New System.Drawing.Size(661, 226)
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDescricaoProdutoFornecedor As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricaoProdutoFornecedor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboCodigoProdutoFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProdutoFornecedor As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProdutoEstoque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProdutoEstoque As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoProdutoEstoque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoProdutoEstoque As System.Windows.Forms.Label
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItemEstoque As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItemFornecedor As System.Windows.Forms.Button

End Class
