<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiberacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents picUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblSenha As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiberacao))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.txtUsuario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSenha = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnLiberar = New Janus.Windows.EditControls.UIButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.lblUsuario.Location = New System.Drawing.Point(314, 165)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuário:"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.SystemColors.Window
        Me.lblSenha.Location = New System.Drawing.Point(314, 191)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(41, 14)
        Me.lblSenha.TabIndex = 5
        Me.lblSenha.Text = "Senha:"
        Me.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSistema
        '
        Me.lblSistema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSistema.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.Location = New System.Drawing.Point(10, 13)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(676, 26)
        Me.lblSistema.TabIndex = 0
        Me.lblSistema.Text = "teste"
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Location = New System.Drawing.Point(379, 162)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(210, 20)
        Me.txtUsuario.TabIndex = 4
        Me.txtUsuario.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'txtSenha
        '
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSenha.Location = New System.Drawing.Point(379, 188)
        Me.txtSenha.MaxLength = 20
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(210, 20)
        Me.txtSenha.TabIndex = 6
        Me.txtSenha.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.lblEmpresa.Location = New System.Drawing.Point(314, 139)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(52, 14)
        Me.lblEmpresa.TabIndex = 1
        Me.lblEmpresa.Text = "Empresa:"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(595, 302)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnLiberar
        '
        Me.btnLiberar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLiberar.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnLiberar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLiberar.Location = New System.Drawing.Point(498, 302)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(91, 23)
        Me.btnLiberar.TabIndex = 8
        Me.btnLiberar.Text = "Liberar"
        Me.btnLiberar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.Image = Global.INTERACTI.My.Resources.interacti
        Me.PictureBox1.Location = New System.Drawing.Point(6, 245)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'picUser
        '
        Me.picUser.BackColor = System.Drawing.Color.White
        Me.picUser.Image = Global.INTERACTI.My.Resources.integracao
        Me.picUser.Location = New System.Drawing.Point(0, 55)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(308, 234)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser.TabIndex = 0
        Me.picUser.TabStop = False
        '
        'picMain
        '
        Me.picMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picMain.BackColor = System.Drawing.SystemColors.Window
        Me.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMain.Location = New System.Drawing.Point(-3, 54)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(704, 236)
        Me.picMain.TabIndex = 8
        Me.picMain.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(376, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "-"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLiberacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(695, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblSistema)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.picMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLiberacao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liberação"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSistema As System.Windows.Forms.Label
    Friend WithEvents txtSenha As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtUsuario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnLiberar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
