<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpPedidoProdutoInspecao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpPedidoProdutoInspecao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPedido = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInspecao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInspecao = New System.Windows.Forms.Label()
        Me.lblQuantidadeReprovada = New System.Windows.Forms.Label()
        Me.txtQuantidadeReprovada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeEntrega = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeAprovada = New System.Windows.Forms.Label()
        Me.txtQuantidadeAprovada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.dtpDataEntregaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPrevisaoEntrega = New System.Windows.Forms.Label()
        Me.txtCodigoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.lblDataPedido = New System.Windows.Forms.Label()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtNumeroPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservação = New System.Windows.Forms.Label()
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
        Me.tabMain.Size = New System.Drawing.Size(751, 284)
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
        Me.pagTabela.Size = New System.Drawing.Size(749, 261)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Inspeção"
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.lblObservação)
        Me.grpMotivo.Controls.Add(Me.txtObservacao)
        Me.grpMotivo.Controls.Add(Me.dtpDataPedido)
        Me.grpMotivo.Controls.Add(Me.dtpDataInspecao)
        Me.grpMotivo.Controls.Add(Me.lblDataInspecao)
        Me.grpMotivo.Controls.Add(Me.lblQuantidadeReprovada)
        Me.grpMotivo.Controls.Add(Me.txtQuantidadeReprovada)
        Me.grpMotivo.Controls.Add(Me.lblQuantidadeEntrega)
        Me.grpMotivo.Controls.Add(Me.txtQuantidade)
        Me.grpMotivo.Controls.Add(Me.lblQuantidadeAprovada)
        Me.grpMotivo.Controls.Add(Me.txtQuantidadeAprovada)
        Me.grpMotivo.Controls.Add(Me.dtpDataEntregaInicioFiltro)
        Me.grpMotivo.Controls.Add(Me.lblDataPrevisaoEntrega)
        Me.grpMotivo.Controls.Add(Me.txtCodigoProduto)
        Me.grpMotivo.Controls.Add(Me.lblCodigoProduto)
        Me.grpMotivo.Controls.Add(Me.lblDataPedido)
        Me.grpMotivo.Controls.Add(Me.txtCliente)
        Me.grpMotivo.Controls.Add(Me.lblCliente)
        Me.grpMotivo.Controls.Add(Me.txtNumeroPedido)
        Me.grpMotivo.Controls.Add(Me.lblNumeroPedido)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(733, 191)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados do Pedido"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPedido
        '
        Me.dtpDataPedido.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.dtpDataPedido.DropDownCalendar.Name = ""
        Me.dtpDataPedido.Enabled = False
        Me.dtpDataPedido.Location = New System.Drawing.Point(125, 37)
        Me.dtpDataPedido.Name = "dtpDataPedido"
        Me.dtpDataPedido.ReadOnly = True
        Me.dtpDataPedido.Size = New System.Drawing.Size(114, 20)
        Me.dtpDataPedido.TabIndex = 26
        Me.dtpDataPedido.TabStop = False
        '
        'dtpDataInspecao
        '
        Me.dtpDataInspecao.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.dtpDataInspecao.DropDownCalendar.Name = ""
        Me.dtpDataInspecao.Location = New System.Drawing.Point(245, 81)
        Me.dtpDataInspecao.Name = "dtpDataInspecao"
        Me.dtpDataInspecao.ShowCheckBox = True
        Me.dtpDataInspecao.Size = New System.Drawing.Size(105, 20)
        Me.dtpDataInspecao.TabIndex = 0
        '
        'lblDataInspecao
        '
        Me.lblDataInspecao.AutoSize = True
        Me.lblDataInspecao.Location = New System.Drawing.Point(242, 64)
        Me.lblDataInspecao.Name = "lblDataInspecao"
        Me.lblDataInspecao.Size = New System.Drawing.Size(79, 14)
        Me.lblDataInspecao.TabIndex = 22
        Me.lblDataInspecao.Text = "Data Inspeção:"
        '
        'lblQuantidadeReprovada
        '
        Me.lblQuantidadeReprovada.AutoSize = True
        Me.lblQuantidadeReprovada.Location = New System.Drawing.Point(470, 65)
        Me.lblQuantidadeReprovada.Name = "lblQuantidadeReprovada"
        Me.lblQuantidadeReprovada.Size = New System.Drawing.Size(121, 14)
        Me.lblQuantidadeReprovada.TabIndex = 19
        Me.lblQuantidadeReprovada.Text = "Quantidade Reprovada:"
        '
        'txtQuantidadeReprovada
        '
        Me.txtQuantidadeReprovada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeReprovada.DecimalDigits = 4
        Me.txtQuantidadeReprovada.Location = New System.Drawing.Point(474, 82)
        Me.txtQuantidadeReprovada.MaxLength = 0
        Me.txtQuantidadeReprovada.Name = "txtQuantidadeReprovada"
        Me.txtQuantidadeReprovada.ReadOnly = True
        Me.txtQuantidadeReprovada.Size = New System.Drawing.Size(127, 20)
        Me.txtQuantidadeReprovada.TabIndex = 2
        Me.txtQuantidadeReprovada.TabStop = False
        Me.txtQuantidadeReprovada.Text = "0,0000"
        Me.txtQuantidadeReprovada.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeEntrega
        '
        Me.lblQuantidadeEntrega.AutoSize = True
        Me.lblQuantidadeEntrega.Location = New System.Drawing.Point(6, 64)
        Me.lblQuantidadeEntrega.Name = "lblQuantidadeEntrega"
        Me.lblQuantidadeEntrega.Size = New System.Drawing.Size(111, 14)
        Me.lblQuantidadeEntrega.TabIndex = 17
        Me.lblQuantidadeEntrega.Text = "Quantidade Entregue:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 81)
        Me.txtQuantidade.MaxLength = 0
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(108, 20)
        Me.txtQuantidade.TabIndex = 16
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeAprovada
        '
        Me.lblQuantidadeAprovada.AutoSize = True
        Me.lblQuantidadeAprovada.Location = New System.Drawing.Point(352, 65)
        Me.lblQuantidadeAprovada.Name = "lblQuantidadeAprovada"
        Me.lblQuantidadeAprovada.Size = New System.Drawing.Size(115, 14)
        Me.lblQuantidadeAprovada.TabIndex = 15
        Me.lblQuantidadeAprovada.Text = "Quantidade Aprovada:"
        '
        'txtQuantidadeAprovada
        '
        Me.txtQuantidadeAprovada.DecimalDigits = 4
        Me.txtQuantidadeAprovada.Location = New System.Drawing.Point(356, 82)
        Me.txtQuantidadeAprovada.MaxLength = 0
        Me.txtQuantidadeAprovada.Name = "txtQuantidadeAprovada"
        Me.txtQuantidadeAprovada.Size = New System.Drawing.Size(111, 20)
        Me.txtQuantidadeAprovada.TabIndex = 1
        Me.txtQuantidadeAprovada.Text = "0,0000"
        Me.txtQuantidadeAprovada.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'dtpDataEntregaInicioFiltro
        '
        Me.dtpDataEntregaInicioFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.dtpDataEntregaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntregaInicioFiltro.Enabled = False
        Me.dtpDataEntregaInicioFiltro.Location = New System.Drawing.Point(125, 81)
        Me.dtpDataEntregaInicioFiltro.Name = "dtpDataEntregaInicioFiltro"
        Me.dtpDataEntregaInicioFiltro.ReadOnly = True
        Me.dtpDataEntregaInicioFiltro.Size = New System.Drawing.Size(114, 20)
        Me.dtpDataEntregaInicioFiltro.TabIndex = 13
        Me.dtpDataEntregaInicioFiltro.TabStop = False
        '
        'lblDataPrevisaoEntrega
        '
        Me.lblDataPrevisaoEntrega.AutoSize = True
        Me.lblDataPrevisaoEntrega.Location = New System.Drawing.Point(122, 64)
        Me.lblDataPrevisaoEntrega.Name = "lblDataPrevisaoEntrega"
        Me.lblDataPrevisaoEntrega.Size = New System.Drawing.Size(117, 14)
        Me.lblDataPrevisaoEntrega.TabIndex = 8
        Me.lblDataPrevisaoEntrega.Text = "Data Previsão Entrega:"
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProduto.Location = New System.Drawing.Point(474, 37)
        Me.txtCodigoProduto.MaxLength = 250
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.ReadOnly = True
        Me.txtCodigoProduto.Size = New System.Drawing.Size(244, 20)
        Me.txtCodigoProduto.TabIndex = 7
        Me.txtCodigoProduto.TabStop = False
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(470, 20)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProduto.TabIndex = 6
        Me.lblCodigoProduto.Text = "Codigo Produto:"
        '
        'lblDataPedido
        '
        Me.lblDataPedido.AutoSize = True
        Me.lblDataPedido.Location = New System.Drawing.Point(122, 20)
        Me.lblDataPedido.Name = "lblDataPedido"
        Me.lblDataPedido.Size = New System.Drawing.Size(67, 14)
        Me.lblDataPedido.TabIndex = 2
        Me.lblDataPedido.Text = "Data Pedido:"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(245, 37)
        Me.txtCliente.MaxLength = 250
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(222, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(242, 20)
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
        Me.txtNumeroPedido.Size = New System.Drawing.Size(108, 20)
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
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 201)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(733, 51)
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
        Me.btnSalvar.Location = New System.Drawing.Point(536, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(633, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(9, 127)
        Me.txtObservacao.MaxLength = 0
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(709, 58)
        Me.txtObservacao.TabIndex = 27
        '
        'lblObservação
        '
        Me.lblObservação.AutoSize = True
        Me.lblObservação.Location = New System.Drawing.Point(6, 110)
        Me.lblObservação.Name = "lblObservação"
        Me.lblObservação.Size = New System.Drawing.Size(70, 14)
        Me.lblObservação.TabIndex = 28
        Me.lblObservação.Text = "Observação:"
        '
        'frmCmpPedidoProdutoInspecao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 299)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCmpPedidoProdutoInspecao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inspeção"
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
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataPedido As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataPrevisaoEntrega As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents dtpDataEntregaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInspecao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataInspecao As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeReprovada As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeReprovada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeEntrega As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeAprovada As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeAprovada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpDataPedido As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservação As System.Windows.Forms.Label
End Class
