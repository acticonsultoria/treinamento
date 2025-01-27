<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEntradaNFPedidoCompraUnidadeMedida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEntradaNFPedidoCompraUnidadeMedida))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblQuantidadeNova = New System.Windows.Forms.Label()
        Me.txtQuantidadeNova = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFatorConversao = New System.Windows.Forms.Label()
        Me.txtFatorConversao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.lblUnidadeMedidaNova = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaNova = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.txtUnidadeMedida = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoCompra = New System.Windows.Forms.Label()
        Me.txtNumeroPedidoCompra = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(610, 193)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(608, 170)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados do Pedido de Compra"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblQuantidadeNova)
        Me.grpDados.Controls.Add(Me.txtQuantidadeNova)
        Me.grpDados.Controls.Add(Me.lblFatorConversao)
        Me.grpDados.Controls.Add(Me.txtFatorConversao)
        Me.grpDados.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpDados.Controls.Add(Me.lblUnidadeMedidaNova)
        Me.grpDados.Controls.Add(Me.cboUnidadeMedidaNova)
        Me.grpDados.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDados.Controls.Add(Me.txtUnidadeMedida)
        Me.grpDados.Controls.Add(Me.lblQuantidade)
        Me.grpDados.Controls.Add(Me.txtQuantidade)
        Me.grpDados.Controls.Add(Me.lblItem)
        Me.grpDados.Controls.Add(Me.txtItem)
        Me.grpDados.Controls.Add(Me.lblNumeroPedidoCompra)
        Me.grpDados.Controls.Add(Me.txtNumeroPedidoCompra)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(592, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblQuantidadeNova
        '
        Me.lblQuantidadeNova.AutoSize = True
        Me.lblQuantidadeNova.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeNova.Location = New System.Drawing.Point(470, 57)
        Me.lblQuantidadeNova.Name = "lblQuantidadeNova"
        Me.lblQuantidadeNova.Size = New System.Drawing.Size(91, 14)
        Me.lblQuantidadeNova.TabIndex = 13
        Me.lblQuantidadeNova.Text = "Qtde. Convertida:"
        '
        'txtQuantidadeNova
        '
        Me.txtQuantidadeNova.DecimalDigits = 4
        Me.txtQuantidadeNova.Location = New System.Drawing.Point(473, 74)
        Me.txtQuantidadeNova.Name = "txtQuantidadeNova"
        Me.txtQuantidadeNova.Size = New System.Drawing.Size(110, 20)
        Me.txtQuantidadeNova.TabIndex = 14
        Me.txtQuantidadeNova.Text = "0,0000"
        Me.txtQuantidadeNova.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblFatorConversao
        '
        Me.lblFatorConversao.AutoSize = True
        Me.lblFatorConversao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFatorConversao.Location = New System.Drawing.Point(354, 57)
        Me.lblFatorConversao.Name = "lblFatorConversao"
        Me.lblFatorConversao.Size = New System.Drawing.Size(106, 14)
        Me.lblFatorConversao.TabIndex = 11
        Me.lblFatorConversao.Text = "Fator de Conversão:"
        '
        'txtFatorConversao
        '
        Me.txtFatorConversao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFatorConversao.DecimalDigits = 4
        Me.txtFatorConversao.Location = New System.Drawing.Point(357, 74)
        Me.txtFatorConversao.Name = "txtFatorConversao"
        Me.txtFatorConversao.ReadOnly = True
        Me.txtFatorConversao.Size = New System.Drawing.Size(110, 20)
        Me.txtFatorConversao.TabIndex = 12
        Me.txtFatorConversao.TabStop = False
        Me.txtFatorConversao.Text = "0,0000"
        Me.txtFatorConversao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(241, 58)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 8
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'lblUnidadeMedidaNova
        '
        Me.lblUnidadeMedidaNova.AutoSize = True
        Me.lblUnidadeMedidaNova.Location = New System.Drawing.Point(257, 57)
        Me.lblUnidadeMedidaNova.Name = "lblUnidadeMedidaNova"
        Me.lblUnidadeMedidaNova.Size = New System.Drawing.Size(69, 14)
        Me.lblUnidadeMedidaNova.TabIndex = 9
        Me.lblUnidadeMedidaNova.Text = "Und. Medida:"
        '
        'cboUnidadeMedidaNova
        '
        Me.cboUnidadeMedidaNova.AutoSize = False
        Me.cboUnidadeMedidaNova.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaNova.Location = New System.Drawing.Point(241, 74)
        Me.cboUnidadeMedidaNova.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUnidadeMedidaNova.Name = "cboUnidadeMedidaNova"
        Me.cboUnidadeMedidaNova.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaNova.Size = New System.Drawing.Size(110, 20)
        Me.cboUnidadeMedidaNova.TabIndex = 10
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(122, 57)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(71, 14)
        Me.lblUnidadeMedida.TabIndex = 6
        Me.lblUnidadeMedida.Text = "Unid. Medida:"
        '
        'txtUnidadeMedida
        '
        Me.txtUnidadeMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadeMedida.Location = New System.Drawing.Point(125, 74)
        Me.txtUnidadeMedida.MaxLength = 60
        Me.txtUnidadeMedida.Name = "txtUnidadeMedida"
        Me.txtUnidadeMedida.ReadOnly = True
        Me.txtUnidadeMedida.Size = New System.Drawing.Size(110, 20)
        Me.txtUnidadeMedida.TabIndex = 7
        Me.txtUnidadeMedida.TabStop = False
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 57)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 4
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 74)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(110, 20)
        Me.txtQuantidade.TabIndex = 5
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblItem.Location = New System.Drawing.Point(122, 17)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(29, 14)
        Me.lblItem.TabIndex = 2
        Me.lblItem.Text = "Item:"
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItem.Location = New System.Drawing.Point(125, 34)
        Me.txtItem.MaxLength = 60
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(458, 20)
        Me.txtItem.TabIndex = 3
        Me.txtItem.TabStop = False
        '
        'lblNumeroPedidoCompra
        '
        Me.lblNumeroPedidoCompra.AutoSize = True
        Me.lblNumeroPedidoCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroPedidoCompra.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroPedidoCompra.Name = "lblNumeroPedidoCompra"
        Me.lblNumeroPedidoCompra.Size = New System.Drawing.Size(97, 14)
        Me.lblNumeroPedidoCompra.TabIndex = 0
        Me.lblNumeroPedidoCompra.Text = "Nº Pedido Compra:"
        '
        'txtNumeroPedidoCompra
        '
        Me.txtNumeroPedidoCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroPedidoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoCompra.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroPedidoCompra.MaxLength = 60
        Me.txtNumeroPedidoCompra.Name = "txtNumeroPedidoCompra"
        Me.txtNumeroPedidoCompra.ReadOnly = True
        Me.txtNumeroPedidoCompra.Size = New System.Drawing.Size(110, 20)
        Me.txtNumeroPedidoCompra.TabIndex = 1
        Me.txtNumeroPedidoCompra.TabStop = False
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 110)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(592, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(395, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(492, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEntradaNFPedidoCompraUnidadeMedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 207)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEntradaNFPedidoCompraUnidadeMedida"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pedido de Compra"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroPedidoCompra As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedidoCompra As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents txtUnidadeMedida As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents txtItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblQuantidadeNova As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeNova As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFatorConversao As System.Windows.Forms.Label
    Friend WithEvents txtFatorConversao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents lblUnidadeMedidaNova As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedidaNova As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
End Class
