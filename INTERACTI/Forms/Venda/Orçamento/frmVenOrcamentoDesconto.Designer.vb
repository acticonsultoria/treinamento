<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenOrcamentoDesconto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenOrcamentoDesconto))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpDesconto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDesconto = New System.Windows.Forms.Label()
        Me.txtPorcentagemDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemDesconto = New System.Windows.Forms.Label()
        Me.txtPrecoVendaSemIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVendaSemIPI = New System.Windows.Forms.Label()
        Me.grpMargemLucroAtual = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorLucroAtual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorLucroAtual = New System.Windows.Forms.Label()
        Me.txtPorcentagemMargemLucroAtual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemMargemLucroAtual = New System.Windows.Forms.Label()
        Me.grpNovoPrecoVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPrecoVendaSemIPINovo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVendaSemIPINovo = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.grpDesconto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDesconto.SuspendLayout()
        CType(Me.grpMargemLucroAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMargemLucroAtual.SuspendLayout()
        CType(Me.grpNovoPrecoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNovoPrecoVenda.SuspendLayout()
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
        'grpDesconto
        '
        Me.grpDesconto.BackColor = System.Drawing.Color.Transparent
        Me.grpDesconto.Controls.Add(Me.txtValorDesconto)
        Me.grpDesconto.Controls.Add(Me.lblValorDesconto)
        Me.grpDesconto.Controls.Add(Me.txtPorcentagemDesconto)
        Me.grpDesconto.Controls.Add(Me.lblPorcentagemDesconto)
        Me.grpDesconto.Controls.Add(Me.txtPrecoVendaSemIPI)
        Me.grpDesconto.Controls.Add(Me.lblPrecoVendaSemIPI)
        Me.grpDesconto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDesconto.Location = New System.Drawing.Point(4, 3)
        Me.grpDesconto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDesconto.Name = "grpDesconto"
        Me.grpDesconto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDesconto.Size = New System.Drawing.Size(270, 108)
        Me.grpDesconto.TabIndex = 0
        Me.grpDesconto.Text = "Desconto"
        Me.grpDesconto.VisualStyleManager = Me.vsmMain
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.DecimalDigits = 2
        Me.txtValorDesconto.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtValorDesconto.Location = New System.Drawing.Point(136, 77)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.Size = New System.Drawing.Size(128, 20)
        Me.txtValorDesconto.TabIndex = 2
        Me.txtValorDesconto.Text = "R$ 0,00"
        Me.txtValorDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDesconto
        '
        Me.lblValorDesconto.AutoSize = True
        Me.lblValorDesconto.Location = New System.Drawing.Point(133, 60)
        Me.lblValorDesconto.Name = "lblValorDesconto"
        Me.lblValorDesconto.Size = New System.Drawing.Size(99, 14)
        Me.lblValorDesconto.TabIndex = 28
        Me.lblValorDesconto.Text = "Valor de Desconto:"
        '
        'txtPorcentagemDesconto
        '
        Me.txtPorcentagemDesconto.DecimalDigits = 2
        Me.txtPorcentagemDesconto.Location = New System.Drawing.Point(9, 77)
        Me.txtPorcentagemDesconto.Name = "txtPorcentagemDesconto"
        Me.txtPorcentagemDesconto.Size = New System.Drawing.Size(121, 20)
        Me.txtPorcentagemDesconto.TabIndex = 1
        Me.txtPorcentagemDesconto.Text = "0,00"
        Me.txtPorcentagemDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemDesconto
        '
        Me.lblPorcentagemDesconto.AutoSize = True
        Me.lblPorcentagemDesconto.Location = New System.Drawing.Point(6, 60)
        Me.lblPorcentagemDesconto.Name = "lblPorcentagemDesconto"
        Me.lblPorcentagemDesconto.Size = New System.Drawing.Size(69, 14)
        Me.lblPorcentagemDesconto.TabIndex = 26
        Me.lblPorcentagemDesconto.Text = "% Desconto:"
        '
        'txtPrecoVendaSemIPI
        '
        Me.txtPrecoVendaSemIPI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrecoVendaSemIPI.DecimalDigits = 2
        Me.txtPrecoVendaSemIPI.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtPrecoVendaSemIPI.Location = New System.Drawing.Point(9, 34)
        Me.txtPrecoVendaSemIPI.Name = "txtPrecoVendaSemIPI"
        Me.txtPrecoVendaSemIPI.ReadOnly = True
        Me.txtPrecoVendaSemIPI.Size = New System.Drawing.Size(255, 20)
        Me.txtPrecoVendaSemIPI.TabIndex = 0
        Me.txtPrecoVendaSemIPI.TabStop = False
        Me.txtPrecoVendaSemIPI.Text = "R$ 0,00"
        Me.txtPrecoVendaSemIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoVendaSemIPI
        '
        Me.lblPrecoVendaSemIPI.AutoSize = True
        Me.lblPrecoVendaSemIPI.Location = New System.Drawing.Point(6, 17)
        Me.lblPrecoVendaSemIPI.Name = "lblPrecoVendaSemIPI"
        Me.lblPrecoVendaSemIPI.Size = New System.Drawing.Size(109, 14)
        Me.lblPrecoVendaSemIPI.TabIndex = 24
        Me.lblPrecoVendaSemIPI.Text = "Preço Venda Sem IPI:"
        '
        'grpMargemLucroAtual
        '
        Me.grpMargemLucroAtual.BackColor = System.Drawing.Color.Transparent
        Me.grpMargemLucroAtual.Controls.Add(Me.txtValorLucroAtual)
        Me.grpMargemLucroAtual.Controls.Add(Me.lblValorLucroAtual)
        Me.grpMargemLucroAtual.Controls.Add(Me.txtPorcentagemMargemLucroAtual)
        Me.grpMargemLucroAtual.Controls.Add(Me.lblPorcentagemMargemLucroAtual)
        Me.grpMargemLucroAtual.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMargemLucroAtual.Location = New System.Drawing.Point(4, 119)
        Me.grpMargemLucroAtual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMargemLucroAtual.Name = "grpMargemLucroAtual"
        Me.grpMargemLucroAtual.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMargemLucroAtual.Size = New System.Drawing.Size(270, 66)
        Me.grpMargemLucroAtual.TabIndex = 1
        Me.grpMargemLucroAtual.Text = "Margem de Lucro Atual"
        Me.grpMargemLucroAtual.VisualStyleManager = Me.vsmMain
        '
        'txtValorLucroAtual
        '
        Me.txtValorLucroAtual.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorLucroAtual.DecimalDigits = 2
        Me.txtValorLucroAtual.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtValorLucroAtual.Location = New System.Drawing.Point(136, 34)
        Me.txtValorLucroAtual.Name = "txtValorLucroAtual"
        Me.txtValorLucroAtual.ReadOnly = True
        Me.txtValorLucroAtual.Size = New System.Drawing.Size(128, 20)
        Me.txtValorLucroAtual.TabIndex = 1
        Me.txtValorLucroAtual.TabStop = False
        Me.txtValorLucroAtual.Text = "R$ 0,00"
        Me.txtValorLucroAtual.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorLucroAtual
        '
        Me.lblValorLucroAtual.AutoSize = True
        Me.lblValorLucroAtual.Location = New System.Drawing.Point(133, 17)
        Me.lblValorLucroAtual.Name = "lblValorLucroAtual"
        Me.lblValorLucroAtual.Size = New System.Drawing.Size(66, 14)
        Me.lblValorLucroAtual.TabIndex = 28
        Me.lblValorLucroAtual.Text = "Valor Lucro:"
        '
        'txtPorcentagemMargemLucroAtual
        '
        Me.txtPorcentagemMargemLucroAtual.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPorcentagemMargemLucroAtual.DecimalDigits = 2
        Me.txtPorcentagemMargemLucroAtual.Location = New System.Drawing.Point(9, 34)
        Me.txtPorcentagemMargemLucroAtual.Name = "txtPorcentagemMargemLucroAtual"
        Me.txtPorcentagemMargemLucroAtual.ReadOnly = True
        Me.txtPorcentagemMargemLucroAtual.Size = New System.Drawing.Size(121, 20)
        Me.txtPorcentagemMargemLucroAtual.TabIndex = 0
        Me.txtPorcentagemMargemLucroAtual.TabStop = False
        Me.txtPorcentagemMargemLucroAtual.Text = "0,00"
        Me.txtPorcentagemMargemLucroAtual.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemMargemLucroAtual
        '
        Me.lblPorcentagemMargemLucroAtual.AutoSize = True
        Me.lblPorcentagemMargemLucroAtual.Location = New System.Drawing.Point(6, 17)
        Me.lblPorcentagemMargemLucroAtual.Name = "lblPorcentagemMargemLucroAtual"
        Me.lblPorcentagemMargemLucroAtual.Size = New System.Drawing.Size(107, 14)
        Me.lblPorcentagemMargemLucroAtual.TabIndex = 26
        Me.lblPorcentagemMargemLucroAtual.Text = "% Margem de Lucro:"
        '
        'grpNovoPrecoVenda
        '
        Me.grpNovoPrecoVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpNovoPrecoVenda.Controls.Add(Me.txtPrecoVendaSemIPINovo)
        Me.grpNovoPrecoVenda.Controls.Add(Me.lblPrecoVendaSemIPINovo)
        Me.grpNovoPrecoVenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpNovoPrecoVenda.Location = New System.Drawing.Point(4, 193)
        Me.grpNovoPrecoVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpNovoPrecoVenda.Name = "grpNovoPrecoVenda"
        Me.grpNovoPrecoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpNovoPrecoVenda.Size = New System.Drawing.Size(270, 62)
        Me.grpNovoPrecoVenda.TabIndex = 2
        Me.grpNovoPrecoVenda.VisualStyleManager = Me.vsmMain
        '
        'txtPrecoVendaSemIPINovo
        '
        Me.txtPrecoVendaSemIPINovo.AccessibleDescription = ""
        Me.txtPrecoVendaSemIPINovo.DecimalDigits = 2
        Me.txtPrecoVendaSemIPINovo.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtPrecoVendaSemIPINovo.Location = New System.Drawing.Point(9, 34)
        Me.txtPrecoVendaSemIPINovo.Name = "txtPrecoVendaSemIPINovo"
        Me.txtPrecoVendaSemIPINovo.Size = New System.Drawing.Size(255, 20)
        Me.txtPrecoVendaSemIPINovo.TabIndex = 0
        Me.txtPrecoVendaSemIPINovo.Text = "R$ 0,00"
        Me.txtPrecoVendaSemIPINovo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoVendaSemIPINovo
        '
        Me.lblPrecoVendaSemIPINovo.AutoSize = True
        Me.lblPrecoVendaSemIPINovo.Location = New System.Drawing.Point(6, 17)
        Me.lblPrecoVendaSemIPINovo.Name = "lblPrecoVendaSemIPINovo"
        Me.lblPrecoVendaSemIPINovo.Size = New System.Drawing.Size(137, 14)
        Me.lblPrecoVendaSemIPINovo.TabIndex = 24
        Me.lblPrecoVendaSemIPINovo.Text = "Novo Preço Venda Sem IPI:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(4, 261)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(270, 51)
        Me.grpControl2.TabIndex = 4
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(73, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(170, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmVenOrcamentoDesconto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 318)
        Me.Controls.Add(Me.grpControl2)
        Me.Controls.Add(Me.grpNovoPrecoVenda)
        Me.Controls.Add(Me.grpMargemLucroAtual)
        Me.Controls.Add(Me.grpDesconto)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenOrcamentoDesconto"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Desconto"
        CType(Me.grpDesconto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDesconto.ResumeLayout(False)
        Me.grpDesconto.PerformLayout()
        CType(Me.grpMargemLucroAtual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMargemLucroAtual.ResumeLayout(False)
        Me.grpMargemLucroAtual.PerformLayout()
        CType(Me.grpNovoPrecoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNovoPrecoVenda.ResumeLayout(False)
        Me.grpNovoPrecoVenda.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpDesconto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDesconto As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemDesconto As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaSemIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVendaSemIPI As System.Windows.Forms.Label
    Friend WithEvents grpMargemLucroAtual As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorLucroAtual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorLucroAtual As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemMargemLucroAtual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemMargemLucroAtual As System.Windows.Forms.Label
    Friend WithEvents grpNovoPrecoVenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtPrecoVendaSemIPINovo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVendaSemIPINovo As System.Windows.Forms.Label
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
End Class
