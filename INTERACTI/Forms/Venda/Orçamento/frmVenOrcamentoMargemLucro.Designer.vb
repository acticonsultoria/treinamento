<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenOrcamentoMargemLucro
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
        Dim JanusColorScheme3 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenOrcamentoMargemLucro))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpComposição = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPrecoVenda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVenda = New System.Windows.Forms.Label()
        Me.lblPorcentagemLucro = New System.Windows.Forms.Label()
        Me.txtValorLucro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorLucro = New System.Windows.Forms.Label()
        Me.txtDespesaFixa = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaFixa = New System.Windows.Forms.Label()
        Me.txtDespesaVariavel = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaVariavel = New System.Windows.Forms.Label()
        Me.txtCustoTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCustoTotal = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtPrecoVendaNovo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVendaNovo = New System.Windows.Forms.Label()
        Me.grpMargemLucroNova = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorLucroNova = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorLucroNova = New System.Windows.Forms.Label()
        Me.txtPorcentagemLucroNova = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemLucroNova = New System.Windows.Forms.Label()
        Me.txtPorcentagemMargemLucro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        CType(Me.grpComposição, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpComposição.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpMargemLucroNova, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMargemLucroNova.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme3.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme3.Name = "Scheme"
        JanusColorScheme3.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme3.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme3.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme3)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'grpComposição
        '
        Me.grpComposição.BackColor = System.Drawing.Color.Transparent
        Me.grpComposição.Controls.Add(Me.txtPorcentagemMargemLucro)
        Me.grpComposição.Controls.Add(Me.txtPrecoVenda)
        Me.grpComposição.Controls.Add(Me.lblPrecoVenda)
        Me.grpComposição.Controls.Add(Me.lblPorcentagemLucro)
        Me.grpComposição.Controls.Add(Me.txtValorLucro)
        Me.grpComposição.Controls.Add(Me.lblValorLucro)
        Me.grpComposição.Controls.Add(Me.txtDespesaFixa)
        Me.grpComposição.Controls.Add(Me.lblDespesaFixa)
        Me.grpComposição.Controls.Add(Me.txtDespesaVariavel)
        Me.grpComposição.Controls.Add(Me.lblDespesaVariavel)
        Me.grpComposição.Controls.Add(Me.txtCustoTotal)
        Me.grpComposição.Controls.Add(Me.lblCustoTotal)
        Me.grpComposição.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpComposição.Location = New System.Drawing.Point(4, 3)
        Me.grpComposição.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpComposição.Name = "grpComposição"
        Me.grpComposição.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpComposição.Size = New System.Drawing.Size(327, 106)
        Me.grpComposição.TabIndex = 0
        Me.grpComposição.Text = "Composição"
        Me.grpComposição.VisualStyleManager = Me.vsmMain
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrecoVenda.DecimalDigits = 2
        Me.txtPrecoVenda.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtPrecoVenda.Location = New System.Drawing.Point(221, 76)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.ReadOnly = True
        Me.txtPrecoVenda.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoVenda.TabIndex = 25
        Me.txtPrecoVenda.TabStop = False
        Me.txtPrecoVenda.Text = "R$ 0,00"
        Me.txtPrecoVenda.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoVenda
        '
        Me.lblPrecoVenda.AutoSize = True
        Me.lblPrecoVenda.Location = New System.Drawing.Point(218, 59)
        Me.lblPrecoVenda.Name = "lblPrecoVenda"
        Me.lblPrecoVenda.Size = New System.Drawing.Size(72, 14)
        Me.lblPrecoVenda.TabIndex = 26
        Me.lblPrecoVenda.Text = "Preço Venda:"
        '
        'lblPorcentagemLucro
        '
        Me.lblPorcentagemLucro.AutoSize = True
        Me.lblPorcentagemLucro.Location = New System.Drawing.Point(112, 59)
        Me.lblPorcentagemLucro.Name = "lblPorcentagemLucro"
        Me.lblPorcentagemLucro.Size = New System.Drawing.Size(51, 14)
        Me.lblPorcentagemLucro.TabIndex = 23
        Me.lblPorcentagemLucro.Text = "% Lucro:"
        '
        'txtValorLucro
        '
        Me.txtValorLucro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorLucro.DecimalDigits = 2
        Me.txtValorLucro.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtValorLucro.Location = New System.Drawing.Point(9, 76)
        Me.txtValorLucro.Name = "txtValorLucro"
        Me.txtValorLucro.ReadOnly = True
        Me.txtValorLucro.Size = New System.Drawing.Size(100, 20)
        Me.txtValorLucro.TabIndex = 18
        Me.txtValorLucro.TabStop = False
        Me.txtValorLucro.Text = "R$ 0,00"
        Me.txtValorLucro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorLucro
        '
        Me.lblValorLucro.AutoSize = True
        Me.lblValorLucro.Location = New System.Drawing.Point(6, 59)
        Me.lblValorLucro.Name = "lblValorLucro"
        Me.lblValorLucro.Size = New System.Drawing.Size(66, 14)
        Me.lblValorLucro.TabIndex = 21
        Me.lblValorLucro.Text = "Valor Lucro:"
        '
        'txtDespesaFixa
        '
        Me.txtDespesaFixa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDespesaFixa.DecimalDigits = 2
        Me.txtDespesaFixa.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtDespesaFixa.Location = New System.Drawing.Point(221, 34)
        Me.txtDespesaFixa.Name = "txtDespesaFixa"
        Me.txtDespesaFixa.ReadOnly = True
        Me.txtDespesaFixa.Size = New System.Drawing.Size(100, 20)
        Me.txtDespesaFixa.TabIndex = 16
        Me.txtDespesaFixa.TabStop = False
        Me.txtDespesaFixa.Text = "R$ 0,00"
        Me.txtDespesaFixa.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDespesaFixa
        '
        Me.lblDespesaFixa.AutoSize = True
        Me.lblDespesaFixa.Location = New System.Drawing.Point(218, 17)
        Me.lblDespesaFixa.Name = "lblDespesaFixa"
        Me.lblDespesaFixa.Size = New System.Drawing.Size(76, 14)
        Me.lblDespesaFixa.TabIndex = 20
        Me.lblDespesaFixa.Text = "Despesa Fixa:"
        '
        'txtDespesaVariavel
        '
        Me.txtDespesaVariavel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDespesaVariavel.DecimalDigits = 2
        Me.txtDespesaVariavel.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtDespesaVariavel.Location = New System.Drawing.Point(115, 34)
        Me.txtDespesaVariavel.Name = "txtDespesaVariavel"
        Me.txtDespesaVariavel.ReadOnly = True
        Me.txtDespesaVariavel.Size = New System.Drawing.Size(100, 20)
        Me.txtDespesaVariavel.TabIndex = 15
        Me.txtDespesaVariavel.TabStop = False
        Me.txtDespesaVariavel.Text = "R$ 0,00"
        Me.txtDespesaVariavel.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDespesaVariavel
        '
        Me.lblDespesaVariavel.AutoSize = True
        Me.lblDespesaVariavel.Location = New System.Drawing.Point(112, 17)
        Me.lblDespesaVariavel.Name = "lblDespesaVariavel"
        Me.lblDespesaVariavel.Size = New System.Drawing.Size(95, 14)
        Me.lblDespesaVariavel.TabIndex = 19
        Me.lblDespesaVariavel.Text = "Despesa Variável:"
        '
        'txtCustoTotal
        '
        Me.txtCustoTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoTotal.DecimalDigits = 2
        Me.txtCustoTotal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtCustoTotal.Location = New System.Drawing.Point(9, 34)
        Me.txtCustoTotal.Name = "txtCustoTotal"
        Me.txtCustoTotal.ReadOnly = True
        Me.txtCustoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtCustoTotal.TabIndex = 14
        Me.txtCustoTotal.TabStop = False
        Me.txtCustoTotal.Text = "R$ 0,00"
        Me.txtCustoTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCustoTotal
        '
        Me.lblCustoTotal.AutoSize = True
        Me.lblCustoTotal.Location = New System.Drawing.Point(6, 17)
        Me.lblCustoTotal.Name = "lblCustoTotal"
        Me.lblCustoTotal.Size = New System.Drawing.Size(63, 14)
        Me.lblCustoTotal.TabIndex = 17
        Me.lblCustoTotal.Text = "Custo Total:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(4, 189)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(327, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(130, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(227, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPrecoVendaNovo
        '
        Me.txtPrecoVendaNovo.AccessibleDescription = ""
        Me.txtPrecoVendaNovo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrecoVendaNovo.DecimalDigits = 2
        Me.txtPrecoVendaNovo.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtPrecoVendaNovo.Location = New System.Drawing.Point(221, 34)
        Me.txtPrecoVendaNovo.Name = "txtPrecoVendaNovo"
        Me.txtPrecoVendaNovo.ReadOnly = True
        Me.txtPrecoVendaNovo.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoVendaNovo.TabIndex = 2
        Me.txtPrecoVendaNovo.TabStop = False
        Me.txtPrecoVendaNovo.Text = "R$ 0,00"
        Me.txtPrecoVendaNovo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoVendaNovo
        '
        Me.lblPrecoVendaNovo.AutoSize = True
        Me.lblPrecoVendaNovo.Location = New System.Drawing.Point(218, 17)
        Me.lblPrecoVendaNovo.Name = "lblPrecoVendaNovo"
        Me.lblPrecoVendaNovo.Size = New System.Drawing.Size(100, 14)
        Me.lblPrecoVendaNovo.TabIndex = 24
        Me.lblPrecoVendaNovo.Text = "Novo Preço Venda:"
        '
        'grpMargemLucroNova
        '
        Me.grpMargemLucroNova.BackColor = System.Drawing.Color.Transparent
        Me.grpMargemLucroNova.Controls.Add(Me.txtPrecoVendaNovo)
        Me.grpMargemLucroNova.Controls.Add(Me.lblPrecoVendaNovo)
        Me.grpMargemLucroNova.Controls.Add(Me.txtValorLucroNova)
        Me.grpMargemLucroNova.Controls.Add(Me.lblValorLucroNova)
        Me.grpMargemLucroNova.Controls.Add(Me.txtPorcentagemLucroNova)
        Me.grpMargemLucroNova.Controls.Add(Me.lblPorcentagemLucroNova)
        Me.grpMargemLucroNova.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMargemLucroNova.Location = New System.Drawing.Point(4, 117)
        Me.grpMargemLucroNova.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMargemLucroNova.Name = "grpMargemLucroNova"
        Me.grpMargemLucroNova.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMargemLucroNova.Size = New System.Drawing.Size(327, 66)
        Me.grpMargemLucroNova.TabIndex = 1
        Me.grpMargemLucroNova.Text = "Margem de Lucro Nova"
        Me.grpMargemLucroNova.VisualStyleManager = Me.vsmMain
        '
        'txtValorLucroNova
        '
        Me.txtValorLucroNova.DecimalDigits = 2
        Me.txtValorLucroNova.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtValorLucroNova.Location = New System.Drawing.Point(115, 34)
        Me.txtValorLucroNova.Name = "txtValorLucroNova"
        Me.txtValorLucroNova.Size = New System.Drawing.Size(100, 20)
        Me.txtValorLucroNova.TabIndex = 1
        Me.txtValorLucroNova.Text = "R$ 0,00"
        Me.txtValorLucroNova.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorLucroNova
        '
        Me.lblValorLucroNova.AutoSize = True
        Me.lblValorLucroNova.Location = New System.Drawing.Point(112, 17)
        Me.lblValorLucroNova.Name = "lblValorLucroNova"
        Me.lblValorLucroNova.Size = New System.Drawing.Size(66, 14)
        Me.lblValorLucroNova.TabIndex = 28
        Me.lblValorLucroNova.Text = "Valor Lucro:"
        '
        'txtPorcentagemLucroNova
        '
        Me.txtPorcentagemLucroNova.DecimalDigits = 6
        Me.txtPorcentagemLucroNova.Location = New System.Drawing.Point(9, 34)
        Me.txtPorcentagemLucroNova.Name = "txtPorcentagemLucroNova"
        Me.txtPorcentagemLucroNova.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentagemLucroNova.TabIndex = 0
        Me.txtPorcentagemLucroNova.Text = "0,000000"
        Me.txtPorcentagemLucroNova.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'lblPorcentagemLucroNova
        '
        Me.lblPorcentagemLucroNova.AutoSize = True
        Me.lblPorcentagemLucroNova.Location = New System.Drawing.Point(6, 17)
        Me.lblPorcentagemLucroNova.Name = "lblPorcentagemLucroNova"
        Me.lblPorcentagemLucroNova.Size = New System.Drawing.Size(51, 14)
        Me.lblPorcentagemLucroNova.TabIndex = 26
        Me.lblPorcentagemLucroNova.Text = "% Lucro:"
        '
        'txtPorcentagemMargemLucro
        '
        Me.txtPorcentagemMargemLucro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPorcentagemMargemLucro.DecimalDigits = 6
        Me.txtPorcentagemMargemLucro.Location = New System.Drawing.Point(115, 76)
        Me.txtPorcentagemMargemLucro.Name = "txtPorcentagemMargemLucro"
        Me.txtPorcentagemMargemLucro.ReadOnly = True
        Me.txtPorcentagemMargemLucro.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentagemMargemLucro.TabIndex = 31
        Me.txtPorcentagemMargemLucro.TabStop = False
        Me.txtPorcentagemMargemLucro.Text = "0,000000"
        Me.txtPorcentagemMargemLucro.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'frmVenOrcamentoMargemLucro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 246)
        Me.Controls.Add(Me.grpMargemLucroNova)
        Me.Controls.Add(Me.grpControl2)
        Me.Controls.Add(Me.grpComposição)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenOrcamentoMargemLucro"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lucro"
        CType(Me.grpComposição, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpComposição.ResumeLayout(False)
        Me.grpComposição.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpMargemLucroNova, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMargemLucroNova.ResumeLayout(False)
        Me.grpMargemLucroNova.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpComposição As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValorLucro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorLucro As System.Windows.Forms.Label
    Friend WithEvents txtDespesaFixa As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaFixa As System.Windows.Forms.Label
    Friend WithEvents txtDespesaVariavel As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaVariavel As System.Windows.Forms.Label
    Friend WithEvents txtCustoTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCustoTotal As System.Windows.Forms.Label
    Friend WithEvents lblPorcentagemLucro As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVenda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVenda As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaNovo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVendaNovo As System.Windows.Forms.Label
    Friend WithEvents grpMargemLucroNova As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorLucroNova As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorLucroNova As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemLucroNova As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemLucroNova As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemMargemLucro As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
