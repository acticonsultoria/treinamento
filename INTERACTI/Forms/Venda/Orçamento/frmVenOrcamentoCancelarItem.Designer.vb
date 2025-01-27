<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenOrcamentoCancelarItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenOrcamentoCancelarItem))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidadeCancelar = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeCancelar = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtDataOrcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataOrcamento = New System.Windows.Forms.Label()
        Me.txtItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtNumeroOrcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrcamento = New System.Windows.Forms.Label()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblJustificativa = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtQuantidadePedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadePedido = New System.Windows.Forms.Label()
        Me.txtQuantidadeCancelada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeCancelada = New System.Windows.Forms.Label()
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
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(705, 408)
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
        Me.pagTabela.Size = New System.Drawing.Size(703, 385)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Justificativa do Cancelamento"
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtQuantidadeCancelada)
        Me.grpMotivo.Controls.Add(Me.lblQuantidadeCancelada)
        Me.grpMotivo.Controls.Add(Me.txtQuantidadePedido)
        Me.grpMotivo.Controls.Add(Me.lblQuantidadePedido)
        Me.grpMotivo.Controls.Add(Me.txtQuantidadeCancelar)
        Me.grpMotivo.Controls.Add(Me.lblQuantidadeCancelar)
        Me.grpMotivo.Controls.Add(Me.txtQuantidade)
        Me.grpMotivo.Controls.Add(Me.lblQuantidade)
        Me.grpMotivo.Controls.Add(Me.txtDataOrcamento)
        Me.grpMotivo.Controls.Add(Me.lblDataOrcamento)
        Me.grpMotivo.Controls.Add(Me.txtItem)
        Me.grpMotivo.Controls.Add(Me.lblItem)
        Me.grpMotivo.Controls.Add(Me.txtCliente)
        Me.grpMotivo.Controls.Add(Me.lblCliente)
        Me.grpMotivo.Controls.Add(Me.txtNumeroOrcamento)
        Me.grpMotivo.Controls.Add(Me.lblNumeroOrcamento)
        Me.grpMotivo.Controls.Add(Me.txtJustificativa)
        Me.grpMotivo.Controls.Add(Me.lblJustificativa)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(687, 319)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados do Registro"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidadeCancelar
        '
        Me.txtQuantidadeCancelar.DecimalDigits = 2
        Me.txtQuantidadeCancelar.Location = New System.Drawing.Point(244, 114)
        Me.txtQuantidadeCancelar.Name = "txtQuantidadeCancelar"
        Me.txtQuantidadeCancelar.Size = New System.Drawing.Size(88, 20)
        Me.txtQuantidadeCancelar.TabIndex = 17
        Me.txtQuantidadeCancelar.Text = "0,00"
        Me.txtQuantidadeCancelar.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidadeCancelar
        '
        Me.lblQuantidadeCancelar.AutoSize = True
        Me.lblQuantidadeCancelar.Location = New System.Drawing.Point(241, 97)
        Me.lblQuantidadeCancelar.Name = "lblQuantidadeCancelar"
        Me.lblQuantidadeCancelar.Size = New System.Drawing.Size(91, 14)
        Me.lblQuantidadeCancelar.TabIndex = 16
        Me.lblQuantidadeCancelar.Text = "Qtde. a Cancelar:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 2
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 114)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(62, 20)
        Me.txtQuantidade.TabIndex = 9
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 97)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 8
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtDataOrcamento
        '
        Me.txtDataOrcamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataOrcamento.Location = New System.Drawing.Point(90, 34)
        Me.txtDataOrcamento.MaxLength = 250
        Me.txtDataOrcamento.Name = "txtDataOrcamento"
        Me.txtDataOrcamento.ReadOnly = True
        Me.txtDataOrcamento.Size = New System.Drawing.Size(85, 20)
        Me.txtDataOrcamento.TabIndex = 3
        Me.txtDataOrcamento.TabStop = False
        '
        'lblDataOrcamento
        '
        Me.lblDataOrcamento.AutoSize = True
        Me.lblDataOrcamento.Location = New System.Drawing.Point(87, 17)
        Me.lblDataOrcamento.Name = "lblDataOrcamento"
        Me.lblDataOrcamento.Size = New System.Drawing.Size(88, 14)
        Me.lblDataOrcamento.TabIndex = 2
        Me.lblDataOrcamento.Text = "Data Orçamento:"
        '
        'txtItem
        '
        Me.txtItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItem.Location = New System.Drawing.Point(9, 74)
        Me.txtItem.MaxLength = 250
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(669, 20)
        Me.txtItem.TabIndex = 7
        Me.txtItem.TabStop = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(6, 57)
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
        Me.txtCliente.Location = New System.Drawing.Point(181, 34)
        Me.txtCliente.MaxLength = 250
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(497, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(178, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente:"
        '
        'txtNumeroOrcamento
        '
        Me.txtNumeroOrcamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrcamento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrcamento.MaxLength = 250
        Me.txtNumeroOrcamento.Name = "txtNumeroOrcamento"
        Me.txtNumeroOrcamento.ReadOnly = True
        Me.txtNumeroOrcamento.Size = New System.Drawing.Size(75, 20)
        Me.txtNumeroOrcamento.TabIndex = 1
        Me.txtNumeroOrcamento.TabStop = False
        '
        'lblNumeroOrcamento
        '
        Me.lblNumeroOrcamento.AutoSize = True
        Me.lblNumeroOrcamento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrcamento.Name = "lblNumeroOrcamento"
        Me.lblNumeroOrcamento.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroOrcamento.TabIndex = 0
        Me.lblNumeroOrcamento.Text = "Nº Orçamento:"
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(9, 154)
        Me.txtJustificativa.MaxLength = 5000
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(669, 155)
        Me.txtJustificativa.TabIndex = 22
        '
        'lblJustificativa
        '
        Me.lblJustificativa.AutoSize = True
        Me.lblJustificativa.BackColor = System.Drawing.Color.Transparent
        Me.lblJustificativa.Location = New System.Drawing.Point(6, 137)
        Me.lblJustificativa.Name = "lblJustificativa"
        Me.lblJustificativa.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativa.TabIndex = 21
        Me.lblJustificativa.Text = "Justificativa:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnCancelar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 325)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(687, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(490, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(587, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtQuantidadePedido
        '
        Me.txtQuantidadePedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadePedido.DecimalDigits = 2
        Me.txtQuantidadePedido.Location = New System.Drawing.Point(77, 114)
        Me.txtQuantidadePedido.Name = "txtQuantidadePedido"
        Me.txtQuantidadePedido.ReadOnly = True
        Me.txtQuantidadePedido.Size = New System.Drawing.Size(68, 20)
        Me.txtQuantidadePedido.TabIndex = 24
        Me.txtQuantidadePedido.TabStop = False
        Me.txtQuantidadePedido.Text = "0,00"
        Me.txtQuantidadePedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidadePedido
        '
        Me.lblQuantidadePedido.AutoSize = True
        Me.lblQuantidadePedido.Location = New System.Drawing.Point(74, 97)
        Me.lblQuantidadePedido.Name = "lblQuantidadePedido"
        Me.lblQuantidadePedido.Size = New System.Drawing.Size(71, 14)
        Me.lblQuantidadePedido.TabIndex = 23
        Me.lblQuantidadePedido.Text = "Qtde. Pedido:"
        '
        'txtQuantidadeCancelada
        '
        Me.txtQuantidadeCancelada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeCancelada.DecimalDigits = 2
        Me.txtQuantidadeCancelada.Location = New System.Drawing.Point(151, 114)
        Me.txtQuantidadeCancelada.Name = "txtQuantidadeCancelada"
        Me.txtQuantidadeCancelada.ReadOnly = True
        Me.txtQuantidadeCancelada.Size = New System.Drawing.Size(87, 20)
        Me.txtQuantidadeCancelada.TabIndex = 26
        Me.txtQuantidadeCancelada.TabStop = False
        Me.txtQuantidadeCancelada.Text = "0,00"
        Me.txtQuantidadeCancelada.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidadeCancelada
        '
        Me.lblQuantidadeCancelada.AutoSize = True
        Me.lblQuantidadeCancelada.Location = New System.Drawing.Point(148, 97)
        Me.lblQuantidadeCancelada.Name = "lblQuantidadeCancelada"
        Me.lblQuantidadeCancelada.Size = New System.Drawing.Size(90, 14)
        Me.lblQuantidadeCancelada.TabIndex = 25
        Me.lblQuantidadeCancelada.Text = "Qtde. Cancelada:"
        '
        'frmVenOrcamentoCancelarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenOrcamentoCancelarItem"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cancelar Item do Orçamento"
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
    Private WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblJustificativa As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblNumeroOrcamento As System.Windows.Forms.Label
    Friend WithEvents txtItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents txtDataOrcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataOrcamento As System.Windows.Forms.Label
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtNumeroOrcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadeCancelar As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeCancelar As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeCancelada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeCancelada As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadePedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadePedido As System.Windows.Forms.Label
End Class
