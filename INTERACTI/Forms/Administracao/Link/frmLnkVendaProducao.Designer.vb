<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLnkVendaProducao
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
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLnkVendaProducao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpDadosPedidoVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblNumeroOrdemProducao = New System.Windows.Forms.Label()
        Me.cboOrdemProducao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblNumerPedidoVenda = New System.Windows.Forms.Label()
        Me.cboNumeroPedidoVenda = New Janus.Windows.EditControls.UIComboBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosPedidoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosPedidoVenda.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        'picSistema
        '
        Me.picSistema.Image = Global.INTERACTI.My.Resources.interacti
        Me.picSistema.Location = New System.Drawing.Point(8, 11)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(489, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 15
        Me.picSistema.TabStop = False
        '
        'grpDadosPedidoVenda
        '
        Me.grpDadosPedidoVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosPedidoVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosPedidoVenda.Controls.Add(Me.lblNumeroOrdemProducao)
        Me.grpDadosPedidoVenda.Controls.Add(Me.cboOrdemProducao)
        Me.grpDadosPedidoVenda.Controls.Add(Me.txtCliente)
        Me.grpDadosPedidoVenda.Controls.Add(Me.lblCliente)
        Me.grpDadosPedidoVenda.Controls.Add(Me.lblNumerPedidoVenda)
        Me.grpDadosPedidoVenda.Controls.Add(Me.cboNumeroPedidoVenda)
        Me.grpDadosPedidoVenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosPedidoVenda.Location = New System.Drawing.Point(8, 123)
        Me.grpDadosPedidoVenda.Name = "grpDadosPedidoVenda"
        Me.grpDadosPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosPedidoVenda.Size = New System.Drawing.Size(489, 116)
        Me.grpDadosPedidoVenda.TabIndex = 16
        Me.grpDadosPedidoVenda.VisualStyleManager = Me.vsmMain
        '
        'lblNumeroOrdemProducao
        '
        Me.lblNumeroOrdemProducao.AutoSize = True
        Me.lblNumeroOrdemProducao.Location = New System.Drawing.Point(6, 57)
        Me.lblNumeroOrdemProducao.Name = "lblNumeroOrdemProducao"
        Me.lblNumeroOrdemProducao.Size = New System.Drawing.Size(106, 14)
        Me.lblNumeroOrdemProducao.TabIndex = 4
        Me.lblNumeroOrdemProducao.Text = "Ordem de Produção:"
        '
        'cboOrdemProducao
        '
        Me.cboOrdemProducao.AutoSize = False
        Me.cboOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboOrdemProducao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboOrdemProducao.Location = New System.Drawing.Point(9, 74)
        Me.cboOrdemProducao.Name = "cboOrdemProducao"
        Me.cboOrdemProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrdemProducao.Size = New System.Drawing.Size(146, 20)
        Me.cboOrdemProducao.TabIndex = 5
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(161, 34)
        Me.txtCliente.MaxLength = 50
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(319, 20)
        Me.txtCliente.TabIndex = 3
        Me.txtCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(158, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente:"
        '
        'lblNumerPedidoVenda
        '
        Me.lblNumerPedidoVenda.AutoSize = True
        Me.lblNumerPedidoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumerPedidoVenda.Location = New System.Drawing.Point(6, 17)
        Me.lblNumerPedidoVenda.Name = "lblNumerPedidoVenda"
        Me.lblNumerPedidoVenda.Size = New System.Drawing.Size(106, 14)
        Me.lblNumerPedidoVenda.TabIndex = 0
        Me.lblNumerPedidoVenda.Text = "Nº Pedido de Venda:"
        '
        'cboNumeroPedidoVenda
        '
        Me.cboNumeroPedidoVenda.AutoSize = False
        Me.cboNumeroPedidoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroPedidoVenda.Location = New System.Drawing.Point(9, 34)
        Me.cboNumeroPedidoVenda.Name = "cboNumeroPedidoVenda"
        Me.cboNumeroPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroPedidoVenda.Size = New System.Drawing.Size(146, 20)
        Me.cboNumeroPedidoVenda.TabIndex = 1
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(8, 242)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(489, 51)
        Me.grpControl.TabIndex = 17
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(389, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        Me.btnSalvar.Location = New System.Drawing.Point(292, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(14, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "*Obs.: Somente Pedidos de Venda e Ordem de Produção sem Link serão carregados."
        '
        'frmLnkVendaProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(506, 301)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpDadosPedidoVenda)
        Me.Controls.Add(Me.grpControl)
        Me.Controls.Add(Me.picSistema)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLnkVendaProducao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Link - Pedido de Venda x Ordem de Produção"
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDadosPedidoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosPedidoVenda.ResumeLayout(False)
        Me.grpDadosPedidoVenda.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents grpDadosPedidoVenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents cboOrdemProducao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblNumerPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents cboNumeroPedidoVenda As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
