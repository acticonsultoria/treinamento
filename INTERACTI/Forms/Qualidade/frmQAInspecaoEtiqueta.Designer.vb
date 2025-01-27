<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQAInspecaoEtiqueta
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
        Dim grdVolume_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQAInspecaoEtiqueta))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdVolume = New Janus.Windows.GridEX.GridEX()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtVolume = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.txtFornecedor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtPedidoCompra = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPedidoCompra = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(702, 347)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grdVolume)
        Me.pagTabela.Controls.Add(Me.grpInformacoes)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(700, 324)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados"
        '
        'grdVolume
        '
        Me.grdVolume.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdVolume.AutoEdit = True
        Me.grdVolume.BlendColor = System.Drawing.SystemColors.WindowFrame
        grdVolume_DesignTimeLayout.LayoutString = resources.GetString("grdVolume_DesignTimeLayout.LayoutString")
        Me.grdVolume.DesignTimeLayout = grdVolume_DesignTimeLayout
        Me.grdVolume.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdVolume.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVolume.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVolume.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVolume.GroupByBoxVisible = False
        Me.grdVolume.Location = New System.Drawing.Point(8, 129)
        Me.grdVolume.Name = "grdVolume"
        Me.grdVolume.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVolume.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVolume.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVolume.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVolume.Size = New System.Drawing.Size(688, 129)
        Me.grdVolume.TabIndex = 2
        Me.grdVolume.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdVolume.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdVolume.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVolume.VisualStyleManager = Me.vsmMain
        '
        'grpInformacoes
        '
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtPedidoCompra)
        Me.grpInformacoes.Controls.Add(Me.lblPedidoCompra)
        Me.grpInformacoes.Controls.Add(Me.txtQuantidade)
        Me.grpInformacoes.Controls.Add(Me.lblQuantidade)
        Me.grpInformacoes.Controls.Add(Me.txtVolume)
        Me.grpInformacoes.Controls.Add(Me.lblVolume)
        Me.grpInformacoes.Controls.Add(Me.txtFornecedor)
        Me.grpInformacoes.Controls.Add(Me.lblFornecedor)
        Me.grpInformacoes.Controls.Add(Me.txtNotaFiscal)
        Me.grpInformacoes.Controls.Add(Me.txtLote)
        Me.grpInformacoes.Controls.Add(Me.txtProduto)
        Me.grpInformacoes.Controls.Add(Me.lblLote)
        Me.grpInformacoes.Controls.Add(Me.lblProduto)
        Me.grpInformacoes.Controls.Add(Me.lblNotaFiscal)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(688, 120)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 2
        Me.txtQuantidade.Location = New System.Drawing.Point(59, 78)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(62, 20)
        Me.txtQuantidade.TabIndex = 32
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(56, 61)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 31
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtVolume
        '
        Me.txtVolume.DecimalDigits = 0
        Me.txtVolume.Location = New System.Drawing.Point(11, 78)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(42, 20)
        Me.txtVolume.TabIndex = 30
        Me.txtVolume.Text = "0"
        Me.txtVolume.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(8, 61)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(45, 14)
        Me.lblVolume.TabIndex = 29
        Me.lblVolume.Text = "Volume:"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedor.Location = New System.Drawing.Point(402, 34)
        Me.txtFornecedor.MaxLength = 100
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.ReadOnly = True
        Me.txtFornecedor.Size = New System.Drawing.Size(277, 20)
        Me.txtFornecedor.TabIndex = 20
        Me.txtFornecedor.TabStop = False
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(399, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 19
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Location = New System.Drawing.Point(236, 34)
        Me.txtNotaFiscal.MaxLength = 100
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.ReadOnly = True
        Me.txtNotaFiscal.Size = New System.Drawing.Size(77, 20)
        Me.txtNotaFiscal.TabIndex = 18
        Me.txtNotaFiscal.TabStop = False
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(120, 34)
        Me.txtLote.MaxLength = 100
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(110, 20)
        Me.txtLote.TabIndex = 17
        Me.txtLote.TabStop = False
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(9, 34)
        Me.txtProduto.MaxLength = 100
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(105, 20)
        Me.txtProduto.TabIndex = 16
        Me.txtProduto.TabStop = False
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(117, 17)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 14
        Me.lblLote.Text = "Lote:"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(6, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Produto:"
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(233, 17)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscal.TabIndex = 0
        Me.lblNotaFiscal.Text = "Nota Fiscal:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImprimir)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 264)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(688, 51)
        Me.grpControl2.TabIndex = 4
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(487, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(95, 23)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(588, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPedidoCompra
        '
        Me.txtPedidoCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPedidoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPedidoCompra.Location = New System.Drawing.Point(319, 34)
        Me.txtPedidoCompra.MaxLength = 100
        Me.txtPedidoCompra.Name = "txtPedidoCompra"
        Me.txtPedidoCompra.ReadOnly = True
        Me.txtPedidoCompra.Size = New System.Drawing.Size(77, 20)
        Me.txtPedidoCompra.TabIndex = 34
        Me.txtPedidoCompra.TabStop = False
        '
        'lblPedidoCompra
        '
        Me.lblPedidoCompra.AutoSize = True
        Me.lblPedidoCompra.Location = New System.Drawing.Point(316, 17)
        Me.lblPedidoCompra.Name = "lblPedidoCompra"
        Me.lblPedidoCompra.Size = New System.Drawing.Size(82, 14)
        Me.lblPedidoCompra.TabIndex = 33
        Me.lblPedidoCompra.Text = "Pedido Compra:"
        '
        'frmQAInspecaoEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(716, 363)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQAInspecaoEtiqueta"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Imprimir Etiqueta"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents grdVolume As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents txtFornecedor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtVolume As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents txtPedidoCompra As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPedidoCompra As System.Windows.Forms.Label
End Class
