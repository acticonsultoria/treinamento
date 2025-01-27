<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCfgCupomFiscal
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCfgCupomFiscal))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.cboDepositoPadrao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepositoPadrao = New System.Windows.Forms.Label()
        Me.cboTipoICF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoICF = New System.Windows.Forms.Label()
        Me.txtMensagem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.txtCupomFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCupomFiscal = New System.Windows.Forms.Label()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSalvar)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(9, 348)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(492, 51)
        Me.grpControle.TabIndex = 1
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(291, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(388, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.cboContaBancaria)
        Me.grpDados.Controls.Add(Me.lblContaBancaria)
        Me.grpDados.Controls.Add(Me.txtArquivo)
        Me.grpDados.Controls.Add(Me.btnArquivo)
        Me.grpDados.Controls.Add(Me.cboDepositoPadrao)
        Me.grpDados.Controls.Add(Me.lblDepositoPadrao)
        Me.grpDados.Controls.Add(Me.cboTipoICF)
        Me.grpDados.Controls.Add(Me.lblTipoICF)
        Me.grpDados.Controls.Add(Me.txtMensagem)
        Me.grpDados.Controls.Add(Me.lblMensagem)
        Me.grpDados.Controls.Add(Me.txtCupomFiscal)
        Me.grpDados.Controls.Add(Me.lblCupomFiscal)
        Me.grpDados.Controls.Add(Me.lblArquivo)
        Me.grpDados.Location = New System.Drawing.Point(9, 121)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(492, 224)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancaria.Location = New System.Drawing.Point(10, 194)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Size = New System.Drawing.Size(469, 20)
        Me.cboContaBancaria.TabIndex = 12
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.Location = New System.Drawing.Point(7, 177)
        Me.lblContaBancaria.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 11
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(10, 114)
        Me.txtArquivo.MaxLength = 60
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(453, 20)
        Me.txtArquivo.TabIndex = 7
        Me.txtArquivo.TabStop = False
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(462, 114)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 8
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboDepositoPadrao
        '
        Me.cboDepositoPadrao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoPadrao.Location = New System.Drawing.Point(10, 154)
        Me.cboDepositoPadrao.Name = "cboDepositoPadrao"
        Me.cboDepositoPadrao.Size = New System.Drawing.Size(469, 20)
        Me.cboDepositoPadrao.TabIndex = 10
        '
        'lblDepositoPadrao
        '
        Me.lblDepositoPadrao.AutoSize = True
        Me.lblDepositoPadrao.Location = New System.Drawing.Point(7, 137)
        Me.lblDepositoPadrao.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblDepositoPadrao.Name = "lblDepositoPadrao"
        Me.lblDepositoPadrao.Size = New System.Drawing.Size(52, 14)
        Me.lblDepositoPadrao.TabIndex = 9
        Me.lblDepositoPadrao.Text = "Depósito:"
        '
        'cboTipoICF
        '
        Me.cboTipoICF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoICF.Location = New System.Drawing.Point(10, 74)
        Me.cboTipoICF.Name = "cboTipoICF"
        Me.cboTipoICF.Size = New System.Drawing.Size(123, 20)
        Me.cboTipoICF.TabIndex = 5
        '
        'lblTipoICF
        '
        Me.lblTipoICF.AutoSize = True
        Me.lblTipoICF.Location = New System.Drawing.Point(7, 57)
        Me.lblTipoICF.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblTipoICF.Name = "lblTipoICF"
        Me.lblTipoICF.Size = New System.Drawing.Size(63, 14)
        Me.lblTipoICF.TabIndex = 4
        Me.lblTipoICF.Text = "Tipo de ICF:"
        '
        'txtMensagem
        '
        Me.txtMensagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensagem.Location = New System.Drawing.Point(139, 34)
        Me.txtMensagem.MaxLength = 384
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensagem.Size = New System.Drawing.Size(340, 60)
        Me.txtMensagem.TabIndex = 3
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Location = New System.Drawing.Point(136, 17)
        Me.lblMensagem.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(62, 14)
        Me.lblMensagem.TabIndex = 2
        Me.lblMensagem.Text = "Mensagem:"
        '
        'txtCupomFiscal
        '
        Me.txtCupomFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCupomFiscal.Location = New System.Drawing.Point(10, 34)
        Me.txtCupomFiscal.MaxLength = 20
        Me.txtCupomFiscal.Name = "txtCupomFiscal"
        Me.txtCupomFiscal.Size = New System.Drawing.Size(123, 20)
        Me.txtCupomFiscal.TabIndex = 1
        '
        'lblCupomFiscal
        '
        Me.lblCupomFiscal.AutoSize = True
        Me.lblCupomFiscal.Location = New System.Drawing.Point(7, 17)
        Me.lblCupomFiscal.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblCupomFiscal.Name = "lblCupomFiscal"
        Me.lblCupomFiscal.Size = New System.Drawing.Size(74, 14)
        Me.lblCupomFiscal.TabIndex = 0
        Me.lblCupomFiscal.Text = "Cupom Fiscal:"
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArquivo.Location = New System.Drawing.Point(7, 97)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(140, 14)
        Me.lblArquivo.TabIndex = 6
        Me.lblArquivo.Text = "Local do Arquivo Bemafi.ini:"
        '
        'picSistema
        '
        Me.picSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSistema.BackColor = System.Drawing.Color.White
        Me.picSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSistema.Image = Global.INTERACTI.My.Resources.interacti
        Me.picSistema.Location = New System.Drawing.Point(9, 9)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(492, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 16
        Me.picSistema.TabStop = False
        '
        'usrCfgCupomFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picSistema)
        Me.Controls.Add(Me.grpControle)
        Me.Controls.Add(Me.grpDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCfgCupomFiscal"
        Me.Size = New System.Drawing.Size(511, 409)
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCupomFiscal As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCupomFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents cboDepositoPadrao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepositoPadrao As System.Windows.Forms.Label
    Friend WithEvents cboTipoICF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoICF As System.Windows.Forms.Label
    Friend WithEvents txtMensagem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label

End Class
