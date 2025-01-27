<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAdmAlterarSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrAdmAlterarSenha))
        Me.lblNovaSenha = New System.Windows.Forms.Label()
        Me.lblSenhaAtual = New System.Windows.Forms.Label()
        Me.txtSenhaAtual = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtNovaSenha = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblSistema = New System.Windows.Forms.Label()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNovaSenha
        '
        Me.lblNovaSenha.AutoSize = True
        Me.lblNovaSenha.BackColor = System.Drawing.Color.White
        Me.lblNovaSenha.Location = New System.Drawing.Point(358, 178)
        Me.lblNovaSenha.Name = "lblNovaSenha"
        Me.lblNovaSenha.Size = New System.Drawing.Size(69, 14)
        Me.lblNovaSenha.TabIndex = 2
        Me.lblNovaSenha.Text = "Nova Senha:"
        Me.lblNovaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSenhaAtual
        '
        Me.lblSenhaAtual.AutoSize = True
        Me.lblSenhaAtual.BackColor = System.Drawing.Color.White
        Me.lblSenhaAtual.Location = New System.Drawing.Point(358, 150)
        Me.lblSenhaAtual.Name = "lblSenhaAtual"
        Me.lblSenhaAtual.Size = New System.Drawing.Size(68, 14)
        Me.lblSenhaAtual.TabIndex = 0
        Me.lblSenhaAtual.Text = "Senha Atual:"
        Me.lblSenhaAtual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSenhaAtual
        '
        Me.txtSenhaAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSenhaAtual.Location = New System.Drawing.Point(429, 147)
        Me.txtSenhaAtual.MaxLength = 20
        Me.txtSenhaAtual.Name = "txtSenhaAtual"
        Me.txtSenhaAtual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaAtual.Size = New System.Drawing.Size(141, 20)
        Me.txtSenhaAtual.TabIndex = 1
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNovaSenha.Location = New System.Drawing.Point(429, 175)
        Me.txtNovaSenha.MaxLength = 20
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenha.Size = New System.Drawing.Size(141, 20)
        Me.txtNovaSenha.TabIndex = 3
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(490, 299)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 25)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(587, 299)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 25)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'picMain
        '
        Me.picMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picMain.BackColor = System.Drawing.SystemColors.Window
        Me.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMain.Location = New System.Drawing.Point(-1, 62)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(690, 221)
        Me.picMain.TabIndex = 10
        Me.picMain.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.INTERACTI.My.Resources.integracao
        Me.PictureBox1.Location = New System.Drawing.Point(9, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Image = Global.INTERACTI.My.Resources.interacti
        Me.PictureBox2.Location = New System.Drawing.Point(14, 235)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'lblSistema
        '
        Me.lblSistema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSistema.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.Location = New System.Drawing.Point(1, 16)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(686, 28)
        Me.lblSistema.TabIndex = 13
        Me.lblSistema.Text = "teste"
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usrAdmAlterarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblSistema)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNovaSenha)
        Me.Controls.Add(Me.txtSenhaAtual)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblNovaSenha)
        Me.Controls.Add(Me.lblSenhaAtual)
        Me.Controls.Add(Me.picMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "usrAdmAlterarSenha"
        Me.Size = New System.Drawing.Size(686, 338)
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNovaSenha As System.Windows.Forms.Label
    Friend WithEvents lblSenhaAtual As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSenhaAtual As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtNovaSenha As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSistema As System.Windows.Forms.Label

End Class
