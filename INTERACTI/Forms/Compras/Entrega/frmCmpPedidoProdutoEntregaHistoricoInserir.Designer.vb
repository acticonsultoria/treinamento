<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpPedidoProdutoEntregaHistoricoInserir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpPedidoProdutoEntregaHistoricoInserir))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.txtUnidadeMedida = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtDataPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataPedido = New System.Windows.Forms.Label()
        Me.txtItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtNumeroPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.txtHistorico = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblHistorico = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMotivo.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(667, 366)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(665, 343)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Histórico"
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtValorTotal)
        Me.grpMotivo.Controls.Add(Me.lblValorTotal)
        Me.grpMotivo.Controls.Add(Me.txtValorUnitario)
        Me.grpMotivo.Controls.Add(Me.lblValorUnitario)
        Me.grpMotivo.Controls.Add(Me.txtUnidadeMedida)
        Me.grpMotivo.Controls.Add(Me.lblUnidadeMedida)
        Me.grpMotivo.Controls.Add(Me.txtQuantidade)
        Me.grpMotivo.Controls.Add(Me.lblQuantidade)
        Me.grpMotivo.Controls.Add(Me.txtDataPedido)
        Me.grpMotivo.Controls.Add(Me.lblDataPedido)
        Me.grpMotivo.Controls.Add(Me.txtItem)
        Me.grpMotivo.Controls.Add(Me.lblItem)
        Me.grpMotivo.Controls.Add(Me.txtCliente)
        Me.grpMotivo.Controls.Add(Me.lblCliente)
        Me.grpMotivo.Controls.Add(Me.txtNumeroPedido)
        Me.grpMotivo.Controls.Add(Me.lblNumeroPedido)
        Me.grpMotivo.Controls.Add(Me.txtHistorico)
        Me.grpMotivo.Controls.Add(Me.lblHistorico)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(649, 277)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados do Pedido"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorTotal.Location = New System.Drawing.Point(327, 117)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotal.TabIndex = 15
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(324, 100)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 14
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorUnitario.DecimalDigits = 4
        Me.txtValorUnitario.Location = New System.Drawing.Point(221, 117)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.ReadOnly = True
        Me.txtValorUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtValorUnitario.TabIndex = 13
        Me.txtValorUnitario.TabStop = False
        Me.txtValorUnitario.Text = "0,0000"
        Me.txtValorUnitario.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.Location = New System.Drawing.Point(218, 100)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitario.TabIndex = 12
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'txtUnidadeMedida
        '
        Me.txtUnidadeMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadeMedida.Location = New System.Drawing.Point(115, 117)
        Me.txtUnidadeMedida.MaxLength = 250
        Me.txtUnidadeMedida.Name = "txtUnidadeMedida"
        Me.txtUnidadeMedida.ReadOnly = True
        Me.txtUnidadeMedida.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidadeMedida.TabIndex = 11
        Me.txtUnidadeMedida.TabStop = False
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(112, 100)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(101, 14)
        Me.lblUnidadeMedida.TabIndex = 10
        Me.lblUnidadeMedida.Text = "Unidade de Medida:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 117)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 9
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 100)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 8
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtDataPedido
        '
        Me.txtDataPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataPedido.Location = New System.Drawing.Point(115, 37)
        Me.txtDataPedido.MaxLength = 250
        Me.txtDataPedido.Name = "txtDataPedido"
        Me.txtDataPedido.ReadOnly = True
        Me.txtDataPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtDataPedido.TabIndex = 3
        Me.txtDataPedido.TabStop = False
        '
        'lblDataPedido
        '
        Me.lblDataPedido.AutoSize = True
        Me.lblDataPedido.Location = New System.Drawing.Point(112, 20)
        Me.lblDataPedido.Name = "lblDataPedido"
        Me.lblDataPedido.Size = New System.Drawing.Size(67, 14)
        Me.lblDataPedido.TabIndex = 2
        Me.lblDataPedido.Text = "Data Pedido:"
        '
        'txtItem
        '
        Me.txtItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItem.Location = New System.Drawing.Point(9, 77)
        Me.txtItem.MaxLength = 250
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(631, 20)
        Me.txtItem.TabIndex = 7
        Me.txtItem.TabStop = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(6, 60)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(29, 14)
        Me.lblItem.TabIndex = 6
        Me.lblItem.Text = "Item:"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(221, 37)
        Me.txtCliente.MaxLength = 250
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(419, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(218, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente:"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedido.Location = New System.Drawing.Point(9, 37)
        Me.txtNumeroPedido.MaxLength = 250
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.ReadOnly = True
        Me.txtNumeroPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPedido.TabIndex = 1
        Me.txtNumeroPedido.TabStop = False
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Location = New System.Drawing.Point(6, 20)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedido.TabIndex = 0
        Me.lblNumeroPedido.Text = "Nº Pedido:"
        '
        'txtHistorico
        '
        Me.txtHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHistorico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHistorico.Location = New System.Drawing.Point(9, 157)
        Me.txtHistorico.MaxLength = 500
        Me.txtHistorico.Multiline = True
        Me.txtHistorico.Name = "txtHistorico"
        Me.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHistorico.Size = New System.Drawing.Size(631, 111)
        Me.txtHistorico.TabIndex = 17
        '
        'lblHistorico
        '
        Me.lblHistorico.AutoSize = True
        Me.lblHistorico.BackColor = System.Drawing.Color.Transparent
        Me.lblHistorico.Location = New System.Drawing.Point(6, 140)
        Me.lblHistorico.Name = "lblHistorico"
        Me.lblHistorico.Size = New System.Drawing.Size(52, 14)
        Me.lblHistorico.TabIndex = 16
        Me.lblHistorico.Text = "Histórico:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 283)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(649, 51)
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
        Me.btnSalvar.Location = New System.Drawing.Point(452, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(549, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmCmpPedidoProdutoEntregaHistoricoInserir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 381)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCmpPedidoProdutoEntregaHistoricoInserir"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Histórico do Produto"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMotivo.ResumeLayout(False)
        Me.grpMotivo.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtHistorico As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblHistorico As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents txtItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents txtDataPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataPedido As System.Windows.Forms.Label
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents txtUnidadeMedida As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
End Class
