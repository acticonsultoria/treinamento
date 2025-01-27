<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenDadosProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenDadosProduto))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPrecoVenda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVenda = New System.Windows.Forms.Label()
        Me.txtMargemLucro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMargemLucro = New System.Windows.Forms.Label()
        Me.txtPrecoCompra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoCompra = New System.Windows.Forms.Label()
        Me.txtCustoMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCustoMedio = New System.Windows.Forms.Label()
        Me.txtQuantidadeSistema = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeSistema = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(456, 193)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grdControlesEdicao)
        Me.pagTabela.Controls.Add(Me.grpProduto)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(454, 170)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados do Produto"
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnSair)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(8, 110)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(438, 51)
        Me.grdControlesEdicao.TabIndex = 1
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(338, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(241, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpProduto
        '
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.txtPrecoVenda)
        Me.grpProduto.Controls.Add(Me.lblPrecoVenda)
        Me.grpProduto.Controls.Add(Me.txtMargemLucro)
        Me.grpProduto.Controls.Add(Me.lblMargemLucro)
        Me.grpProduto.Controls.Add(Me.txtPrecoCompra)
        Me.grpProduto.Controls.Add(Me.lblPrecoCompra)
        Me.grpProduto.Controls.Add(Me.txtCustoMedio)
        Me.grpProduto.Controls.Add(Me.lblCustoMedio)
        Me.grpProduto.Controls.Add(Me.txtQuantidadeSistema)
        Me.grpProduto.Controls.Add(Me.lblQuantidadeSistema)
        Me.grpProduto.Controls.Add(Me.txtDescricao)
        Me.grpProduto.Controls.Add(Me.lblDescricao)
        Me.grpProduto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProduto.Location = New System.Drawing.Point(8, 3)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(438, 104)
        Me.grpProduto.TabIndex = 0
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Location = New System.Drawing.Point(329, 74)
        Me.txtPrecoVenda.MaxLength = 0
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoVenda.TabIndex = 15
        Me.txtPrecoVenda.Text = "0,00"
        Me.txtPrecoVenda.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoVenda
        '
        Me.lblPrecoVenda.AutoSize = True
        Me.lblPrecoVenda.Location = New System.Drawing.Point(326, 57)
        Me.lblPrecoVenda.Name = "lblPrecoVenda"
        Me.lblPrecoVenda.Size = New System.Drawing.Size(87, 14)
        Me.lblPrecoVenda.TabIndex = 14
        Me.lblPrecoVenda.Text = "Preço de Venda:"
        '
        'txtMargemLucro
        '
        Me.txtMargemLucro.Location = New System.Drawing.Point(223, 74)
        Me.txtMargemLucro.MaxLength = 0
        Me.txtMargemLucro.Name = "txtMargemLucro"
        Me.txtMargemLucro.Size = New System.Drawing.Size(100, 20)
        Me.txtMargemLucro.TabIndex = 13
        Me.txtMargemLucro.Text = "0,00"
        Me.txtMargemLucro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMargemLucro
        '
        Me.lblMargemLucro.AutoSize = True
        Me.lblMargemLucro.Location = New System.Drawing.Point(220, 57)
        Me.lblMargemLucro.Name = "lblMargemLucro"
        Me.lblMargemLucro.Size = New System.Drawing.Size(94, 14)
        Me.lblMargemLucro.TabIndex = 12
        Me.lblMargemLucro.Text = "Margem de Lucro:"
        '
        'txtPrecoCompra
        '
        Me.txtPrecoCompra.Location = New System.Drawing.Point(115, 74)
        Me.txtPrecoCompra.MaxLength = 0
        Me.txtPrecoCompra.Name = "txtPrecoCompra"
        Me.txtPrecoCompra.Size = New System.Drawing.Size(102, 20)
        Me.txtPrecoCompra.TabIndex = 11
        Me.txtPrecoCompra.Text = "0,00"
        Me.txtPrecoCompra.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoCompra
        '
        Me.lblPrecoCompra.AutoSize = True
        Me.lblPrecoCompra.Location = New System.Drawing.Point(112, 57)
        Me.lblPrecoCompra.Name = "lblPrecoCompra"
        Me.lblPrecoCompra.Size = New System.Drawing.Size(93, 14)
        Me.lblPrecoCompra.TabIndex = 10
        Me.lblPrecoCompra.Text = "Preço de Compra:"
        '
        'txtCustoMedio
        '
        Me.txtCustoMedio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoMedio.Location = New System.Drawing.Point(9, 74)
        Me.txtCustoMedio.MaxLength = 0
        Me.txtCustoMedio.Name = "txtCustoMedio"
        Me.txtCustoMedio.ReadOnly = True
        Me.txtCustoMedio.Size = New System.Drawing.Size(100, 20)
        Me.txtCustoMedio.TabIndex = 9
        Me.txtCustoMedio.TabStop = False
        Me.txtCustoMedio.Text = "0,00"
        Me.txtCustoMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCustoMedio
        '
        Me.lblCustoMedio.AutoSize = True
        Me.lblCustoMedio.Location = New System.Drawing.Point(6, 57)
        Me.lblCustoMedio.Name = "lblCustoMedio"
        Me.lblCustoMedio.Size = New System.Drawing.Size(69, 14)
        Me.lblCustoMedio.TabIndex = 8
        Me.lblCustoMedio.Text = "Custo Médio:"
        '
        'txtQuantidadeSistema
        '
        Me.txtQuantidadeSistema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeSistema.DecimalDigits = 2
        Me.txtQuantidadeSistema.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeSistema.Location = New System.Drawing.Point(329, 34)
        Me.txtQuantidadeSistema.MaxLength = 0
        Me.txtQuantidadeSistema.Name = "txtQuantidadeSistema"
        Me.txtQuantidadeSistema.ReadOnly = True
        Me.txtQuantidadeSistema.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeSistema.TabIndex = 5
        Me.txtQuantidadeSistema.TabStop = False
        Me.txtQuantidadeSistema.Text = "0,00"
        Me.txtQuantidadeSistema.Value = 0.0R
        Me.txtQuantidadeSistema.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblQuantidadeSistema
        '
        Me.lblQuantidadeSistema.AutoSize = True
        Me.lblQuantidadeSistema.Location = New System.Drawing.Point(326, 17)
        Me.lblQuantidadeSistema.Name = "lblQuantidadeSistema"
        Me.lblQuantidadeSistema.Size = New System.Drawing.Size(77, 14)
        Me.lblQuantidadeSistema.TabIndex = 4
        Me.lblQuantidadeSistema.Text = "Qtde. Sistema:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricao.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricao.MaxLength = 20
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(314, 20)
        Me.txtDescricao.TabIndex = 1
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 0
        Me.lblDescricao.Text = "Descrição:"
        '
        'frmVenDadosProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 207)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenDadosProduto"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produto: "
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCustoMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCustoMedio As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeSistema As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeSistema As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVenda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVenda As System.Windows.Forms.Label
    Friend WithEvents txtMargemLucro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMargemLucro As System.Windows.Forms.Label
    Friend WithEvents txtPrecoCompra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoCompra As System.Windows.Forms.Label
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
End Class
