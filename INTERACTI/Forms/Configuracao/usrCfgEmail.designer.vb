<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCfgEmail
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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCfgEmail))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboFormaEnvio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFormaEnvio = New System.Windows.Forms.Label()
        Me.cboSSL = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSSL = New System.Windows.Forms.Label()
        Me.txtPorta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPorta = New System.Windows.Forms.Label()
        Me.txtServidor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.txtSenha = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtUsuario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.picEmail = New System.Windows.Forms.PictureBox()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(13, 198)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(489, 51)
        Me.grpControl.TabIndex = 1
        Me.grpControl.VisualStyleManager = Me.vsmMain
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
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.cboFormaEnvio)
        Me.grpDados.Controls.Add(Me.lblFormaEnvio)
        Me.grpDados.Controls.Add(Me.cboSSL)
        Me.grpDados.Controls.Add(Me.lblSSL)
        Me.grpDados.Controls.Add(Me.txtPorta)
        Me.grpDados.Controls.Add(Me.lblPorta)
        Me.grpDados.Controls.Add(Me.txtServidor)
        Me.grpDados.Controls.Add(Me.lblServidor)
        Me.grpDados.Controls.Add(Me.txtSenha)
        Me.grpDados.Controls.Add(Me.lblSenha)
        Me.grpDados.Controls.Add(Me.txtUsuario)
        Me.grpDados.Controls.Add(Me.txtEmail)
        Me.grpDados.Controls.Add(Me.lblUsuario)
        Me.grpDados.Controls.Add(Me.lblEmail)
        Me.grpDados.Location = New System.Drawing.Point(157, 8)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(345, 184)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'cboFormaEnvio
        '
        Me.cboFormaEnvio.AutoSize = False
        Me.cboFormaEnvio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboFormaEnvio.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboFormaEnvio.Location = New System.Drawing.Point(9, 34)
        Me.cboFormaEnvio.Name = "cboFormaEnvio"
        Me.cboFormaEnvio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaEnvio.Size = New System.Drawing.Size(326, 20)
        Me.cboFormaEnvio.TabIndex = 1
        '
        'lblFormaEnvio
        '
        Me.lblFormaEnvio.AutoSize = True
        Me.lblFormaEnvio.Location = New System.Drawing.Point(6, 17)
        Me.lblFormaEnvio.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblFormaEnvio.Name = "lblFormaEnvio"
        Me.lblFormaEnvio.Size = New System.Drawing.Size(84, 14)
        Me.lblFormaEnvio.TabIndex = 0
        Me.lblFormaEnvio.Text = "Forma de Envio:"
        '
        'cboSSL
        '
        Me.cboSSL.AutoSize = False
        Me.cboSSL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboSSL.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboSSL.Location = New System.Drawing.Point(235, 154)
        Me.cboSSL.Name = "cboSSL"
        Me.cboSSL.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSSL.Size = New System.Drawing.Size(100, 20)
        Me.cboSSL.TabIndex = 13
        '
        'lblSSL
        '
        Me.lblSSL.AutoSize = True
        Me.lblSSL.Location = New System.Drawing.Point(232, 137)
        Me.lblSSL.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSSL.Name = "lblSSL"
        Me.lblSSL.Size = New System.Drawing.Size(71, 14)
        Me.lblSSL.TabIndex = 12
        Me.lblSSL.Text = "Enabled SSL:"
        '
        'txtPorta
        '
        Me.txtPorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorta.Location = New System.Drawing.Point(180, 154)
        Me.txtPorta.MaxLength = 4
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Size = New System.Drawing.Size(49, 20)
        Me.txtPorta.TabIndex = 11
        '
        'lblPorta
        '
        Me.lblPorta.AutoSize = True
        Me.lblPorta.Location = New System.Drawing.Point(177, 137)
        Me.lblPorta.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblPorta.Name = "lblPorta"
        Me.lblPorta.Size = New System.Drawing.Size(35, 14)
        Me.lblPorta.TabIndex = 10
        Me.lblPorta.Text = "Porta:"
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(9, 154)
        Me.txtServidor.MaxLength = 100
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(165, 20)
        Me.txtServidor.TabIndex = 9
        '
        'lblServidor
        '
        Me.lblServidor.AutoSize = True
        Me.lblServidor.Location = New System.Drawing.Point(6, 137)
        Me.lblServidor.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(51, 14)
        Me.lblServidor.TabIndex = 8
        Me.lblServidor.Text = "Servidor:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(235, 114)
        Me.txtSenha.MaxLength = 20
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 7
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(232, 97)
        Me.lblSenha.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(41, 14)
        Me.lblSenha.TabIndex = 6
        Me.lblSenha.Text = "Senha:"
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUsuario.Location = New System.Drawing.Point(9, 114)
        Me.txtUsuario.MaxLength = 100
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(9, 74)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(326, 20)
        Me.txtEmail.TabIndex = 3
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(6, 97)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuário:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 57)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 14)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "E-mail:"
        '
        'picEmail
        '
        Me.picEmail.Image = Global.INTERACTI.My.Resources.server_email
        Me.picEmail.Location = New System.Drawing.Point(13, 35)
        Me.picEmail.Name = "picEmail"
        Me.picEmail.Size = New System.Drawing.Size(130, 130)
        Me.picEmail.TabIndex = 9
        Me.picEmail.TabStop = False
        '
        'usrCfgEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picEmail)
        Me.Controls.Add(Me.grpControl)
        Me.Controls.Add(Me.grpDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCfgEmail"
        Me.Size = New System.Drawing.Size(516, 264)
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents picEmail As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSenha As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtPorta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPorta As System.Windows.Forms.Label
    Friend WithEvents txtServidor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblServidor As System.Windows.Forms.Label
    Friend WithEvents lblSSL As System.Windows.Forms.Label
    Friend WithEvents cboSSL As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboFormaEnvio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFormaEnvio As System.Windows.Forms.Label

End Class
