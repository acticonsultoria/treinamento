<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFsPedidoVenda
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
        Me.components = New System.ComponentModel.Container
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFsPedidoVenda))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage
        Me.grpServico = New Janus.Windows.EditControls.UIGroupBox
        Me.txtContaContabil = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtCentroCusto = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtValorServicoPendente = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblValorServicoPendente = New System.Windows.Forms.Label
        Me.lblContaContabilServico = New System.Windows.Forms.Label
        Me.lblCentroCustoServico = New System.Windows.Forms.Label
        Me.lblServico = New System.Windows.Forms.Label
        Me.cboServico = New Janus.Windows.EditControls.UIComboBox
        Me.lblDescricao = New System.Windows.Forms.Label
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.EditBox
        Me.txtValorServico = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblValorServico = New System.Windows.Forms.Label
        Me.grpCliente = New Janus.Windows.EditControls.UIGroupBox
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblCliente = New System.Windows.Forms.Label
        Me.txtCNPJCPF = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblCNPJCPF = New System.Windows.Forms.Label
        Me.cboPedidoVenda = New Janus.Windows.EditControls.UIComboBox
        Me.lblPedidoVenda = New System.Windows.Forms.Label
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnImportarPedidoVenda = New Janus.Windows.EditControls.UIButton
        Me.btnSair = New Janus.Windows.EditControls.UIButton
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServico.SuspendLayout()
        CType(Me.grpCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCliente.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(869, 343)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpServico)
        Me.pagTabela.Controls.Add(Me.grpCliente)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(867, 320)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Pedido de Venda"
        '
        'grpServico
        '
        Me.grpServico.BackColor = System.Drawing.Color.Transparent
        Me.grpServico.Controls.Add(Me.txtContaContabil)
        Me.grpServico.Controls.Add(Me.txtCentroCusto)
        Me.grpServico.Controls.Add(Me.txtValorServicoPendente)
        Me.grpServico.Controls.Add(Me.lblValorServicoPendente)
        Me.grpServico.Controls.Add(Me.lblContaContabilServico)
        Me.grpServico.Controls.Add(Me.lblCentroCustoServico)
        Me.grpServico.Controls.Add(Me.lblServico)
        Me.grpServico.Controls.Add(Me.cboServico)
        Me.grpServico.Controls.Add(Me.lblDescricao)
        Me.grpServico.Controls.Add(Me.txtDescricao)
        Me.grpServico.Controls.Add(Me.txtValorServico)
        Me.grpServico.Controls.Add(Me.lblValorServico)
        Me.grpServico.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpServico.Location = New System.Drawing.Point(8, 70)
        Me.grpServico.Name = "grpServico"
        Me.grpServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpServico.Size = New System.Drawing.Size(850, 187)
        Me.grpServico.TabIndex = 1
        Me.grpServico.Text = "Lista de Serviços"
        Me.grpServico.VisualStyleManager = Me.vsmMain
        '
        'txtContaContabil
        '
        Me.txtContaContabil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContaContabil.Location = New System.Drawing.Point(422, 117)
        Me.txtContaContabil.Name = "txtContaContabil"
        Me.txtContaContabil.ReadOnly = True
        Me.txtContaContabil.Size = New System.Drawing.Size(419, 20)
        Me.txtContaContabil.TabIndex = 11
        Me.txtContaContabil.TabStop = False
        '
        'txtCentroCusto
        '
        Me.txtCentroCusto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCentroCusto.Location = New System.Drawing.Point(422, 77)
        Me.txtCentroCusto.Name = "txtCentroCusto"
        Me.txtCentroCusto.ReadOnly = True
        Me.txtCentroCusto.Size = New System.Drawing.Size(419, 20)
        Me.txtCentroCusto.TabIndex = 9
        Me.txtCentroCusto.TabStop = False
        '
        'txtValorServicoPendente
        '
        Me.txtValorServicoPendente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorServicoPendente.DecimalDigits = 2
        Me.txtValorServicoPendente.Location = New System.Drawing.Point(422, 37)
        Me.txtValorServicoPendente.MaxLength = 0
        Me.txtValorServicoPendente.Name = "txtValorServicoPendente"
        Me.txtValorServicoPendente.ReadOnly = True
        Me.txtValorServicoPendente.Size = New System.Drawing.Size(135, 20)
        Me.txtValorServicoPendente.TabIndex = 5
        Me.txtValorServicoPendente.TabStop = False
        Me.txtValorServicoPendente.Text = "0,00"
        Me.txtValorServicoPendente.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorServicoPendente
        '
        Me.lblValorServicoPendente.AutoSize = True
        Me.lblValorServicoPendente.Location = New System.Drawing.Point(419, 20)
        Me.lblValorServicoPendente.Name = "lblValorServicoPendente"
        Me.lblValorServicoPendente.Size = New System.Drawing.Size(123, 14)
        Me.lblValorServicoPendente.TabIndex = 4
        Me.lblValorServicoPendente.Text = "Valor Serviço Pendente:"
        '
        'lblContaContabilServico
        '
        Me.lblContaContabilServico.AutoSize = True
        Me.lblContaContabilServico.Location = New System.Drawing.Point(419, 100)
        Me.lblContaContabilServico.Name = "lblContaContabilServico"
        Me.lblContaContabilServico.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabilServico.TabIndex = 10
        Me.lblContaContabilServico.Text = "Conta Contábil:"
        '
        'lblCentroCustoServico
        '
        Me.lblCentroCustoServico.AutoSize = True
        Me.lblCentroCustoServico.Location = New System.Drawing.Point(419, 60)
        Me.lblCentroCustoServico.Name = "lblCentroCustoServico"
        Me.lblCentroCustoServico.Size = New System.Drawing.Size(88, 14)
        Me.lblCentroCustoServico.TabIndex = 8
        Me.lblCentroCustoServico.Text = "Centro de Custo:"
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblServico.Location = New System.Drawing.Point(6, 20)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(47, 14)
        Me.lblServico.TabIndex = 0
        Me.lblServico.Text = "Serviço:"
        '
        'cboServico
        '
        Me.cboServico.AutoSize = False
        Me.cboServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboServico.Location = New System.Drawing.Point(9, 37)
        Me.cboServico.Name = "cboServico"
        Me.cboServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboServico.Size = New System.Drawing.Size(407, 20)
        Me.cboServico.TabIndex = 1
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 60)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 77)
        Me.txtDescricao.MaxLength = 1000
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescricao.Size = New System.Drawing.Size(407, 100)
        Me.txtDescricao.TabIndex = 3
        Me.txtDescricao.TabStop = False
        '
        'txtValorServico
        '
        Me.txtValorServico.DecimalDigits = 2
        Me.txtValorServico.Location = New System.Drawing.Point(563, 37)
        Me.txtValorServico.MaxLength = 0
        Me.txtValorServico.Name = "txtValorServico"
        Me.txtValorServico.Size = New System.Drawing.Size(142, 20)
        Me.txtValorServico.TabIndex = 7
        Me.txtValorServico.Text = "0,00"
        Me.txtValorServico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorServico
        '
        Me.lblValorServico.AutoSize = True
        Me.lblValorServico.Location = New System.Drawing.Point(560, 20)
        Me.lblValorServico.Name = "lblValorServico"
        Me.lblValorServico.Size = New System.Drawing.Size(75, 14)
        Me.lblValorServico.TabIndex = 6
        Me.lblValorServico.Text = "Valor Serviço:"
        '
        'grpCliente
        '
        Me.grpCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCliente.BackColor = System.Drawing.Color.Transparent
        Me.grpCliente.Controls.Add(Me.txtCliente)
        Me.grpCliente.Controls.Add(Me.lblCliente)
        Me.grpCliente.Controls.Add(Me.txtCNPJCPF)
        Me.grpCliente.Controls.Add(Me.lblCNPJCPF)
        Me.grpCliente.Controls.Add(Me.cboPedidoVenda)
        Me.grpCliente.Controls.Add(Me.lblPedidoVenda)
        Me.grpCliente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCliente.Location = New System.Drawing.Point(8, 3)
        Me.grpCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCliente.Size = New System.Drawing.Size(850, 64)
        Me.grpCliente.TabIndex = 0
        Me.grpCliente.VisualStyleManager = Me.vsmMain
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.Location = New System.Drawing.Point(137, 34)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(568, 20)
        Me.txtCliente.TabIndex = 3
        Me.txtCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(134, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente:"
        '
        'txtCNPJCPF
        '
        Me.txtCNPJCPF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCNPJCPF.Enabled = False
        Me.txtCNPJCPF.Location = New System.Drawing.Point(711, 34)
        Me.txtCNPJCPF.Mask = "00,000,000/0000-00"
        Me.txtCNPJCPF.MaxLength = 25
        Me.txtCNPJCPF.Name = "txtCNPJCPF"
        Me.txtCNPJCPF.ReadOnly = True
        Me.txtCNPJCPF.Size = New System.Drawing.Size(130, 20)
        Me.txtCNPJCPF.TabIndex = 5
        Me.txtCNPJCPF.TabStop = False
        '
        'lblCNPJCPF
        '
        Me.lblCNPJCPF.AutoSize = True
        Me.lblCNPJCPF.Location = New System.Drawing.Point(708, 17)
        Me.lblCNPJCPF.Name = "lblCNPJCPF"
        Me.lblCNPJCPF.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJCPF.TabIndex = 4
        Me.lblCNPJCPF.Text = "CNPJ:"
        '
        'cboPedidoVenda
        '
        Me.cboPedidoVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPedidoVenda.AutoSize = False
        Me.cboPedidoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPedidoVenda.Location = New System.Drawing.Point(9, 34)
        Me.cboPedidoVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPedidoVenda.Name = "cboPedidoVenda"
        Me.cboPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPedidoVenda.Size = New System.Drawing.Size(123, 20)
        Me.cboPedidoVenda.TabIndex = 1
        '
        'lblPedidoVenda
        '
        Me.lblPedidoVenda.AutoSize = True
        Me.lblPedidoVenda.Location = New System.Drawing.Point(6, 17)
        Me.lblPedidoVenda.Name = "lblPedidoVenda"
        Me.lblPedidoVenda.Size = New System.Drawing.Size(91, 14)
        Me.lblPedidoVenda.TabIndex = 0
        Me.lblPedidoVenda.Text = "Pedido de Venda:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImportarPedidoVenda)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 260)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(850, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImportarPedidoVenda
        '
        Me.btnImportarPedidoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarPedidoVenda.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnImportarPedidoVenda.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarPedidoVenda.Location = New System.Drawing.Point(544, 17)
        Me.btnImportarPedidoVenda.Name = "btnImportarPedidoVenda"
        Me.btnImportarPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarPedidoVenda.Size = New System.Drawing.Size(200, 23)
        Me.btnImportarPedidoVenda.TabIndex = 0
        Me.btnImportarPedidoVenda.Text = "Importar Pedido de Venda"
        Me.btnImportarPedidoVenda.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(750, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEmissaoNFsPedidoVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 359)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFsPedidoVenda"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nota Fiscal de Serviço - Importar Pedido de Venda"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServico.ResumeLayout(False)
        Me.grpServico.PerformLayout()
        CType(Me.grpCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCliente.ResumeLayout(False)
        Me.grpCliente.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnImportarPedidoVenda As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpCliente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents cboPedidoVenda As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCNPJCPF As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNPJCPF As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents grpServico As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtContaContabil As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCentroCusto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtValorServicoPendente As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorServicoPendente As System.Windows.Forms.Label
    Friend WithEvents lblContaContabilServico As System.Windows.Forms.Label
    Friend WithEvents lblCentroCustoServico As System.Windows.Forms.Label
    Friend WithEvents lblServico As System.Windows.Forms.Label
    Friend WithEvents cboServico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtValorServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorServico As System.Windows.Forms.Label
End Class
