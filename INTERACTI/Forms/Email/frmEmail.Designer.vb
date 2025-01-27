<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmail))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpEmail = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAssunto = New System.Windows.Forms.Label()
        Me.txtAnexo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnAnexo = New Janus.Windows.EditControls.UIButton()
        Me.txtAssunto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCC = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCC = New Janus.Windows.EditControls.UIButton()
        Me.txtPara = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnPara = New Janus.Windows.EditControls.UIButton()
        Me.btnEnviar = New Janus.Windows.EditControls.UIButton()
        Me.txtBcc = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnBcc = New Janus.Windows.EditControls.UIButton()
        Me.txtBody = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.cboEmail = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnCadastrarTextoEmail = New System.Windows.Forms.Button()
        CType(Me.grpEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmail.SuspendLayout()
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
        'grpEmail
        '
        Me.grpEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEmail.BackColor = System.Drawing.Color.Transparent
        Me.grpEmail.Controls.Add(Me.lblAssunto)
        Me.grpEmail.Controls.Add(Me.txtAnexo)
        Me.grpEmail.Controls.Add(Me.btnAnexo)
        Me.grpEmail.Controls.Add(Me.txtAssunto)
        Me.grpEmail.Controls.Add(Me.txtCC)
        Me.grpEmail.Controls.Add(Me.btnCC)
        Me.grpEmail.Controls.Add(Me.txtPara)
        Me.grpEmail.Controls.Add(Me.btnPara)
        Me.grpEmail.Controls.Add(Me.btnEnviar)
        Me.grpEmail.Controls.Add(Me.txtBcc)
        Me.grpEmail.Controls.Add(Me.btnBcc)
        Me.grpEmail.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEmail.Location = New System.Drawing.Point(6, 3)
        Me.grpEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEmail.Name = "grpEmail"
        Me.grpEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEmail.Size = New System.Drawing.Size(885, 151)
        Me.grpEmail.TabIndex = 1
        Me.grpEmail.VisualStyleManager = Me.vsmMain
        '
        'lblAssunto
        '
        Me.lblAssunto.AutoSize = True
        Me.lblAssunto.Location = New System.Drawing.Point(106, 98)
        Me.lblAssunto.Name = "lblAssunto"
        Me.lblAssunto.Size = New System.Drawing.Size(51, 14)
        Me.lblAssunto.TabIndex = 13
        Me.lblAssunto.Text = "Assunto:"
        '
        'txtAnexo
        '
        Me.txtAnexo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnexo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAnexo.Location = New System.Drawing.Point(178, 121)
        Me.txtAnexo.MaxLength = 60
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.ReadOnly = True
        Me.txtAnexo.Size = New System.Drawing.Size(698, 20)
        Me.txtAnexo.TabIndex = 12
        Me.txtAnexo.TabStop = False
        '
        'btnAnexo
        '
        Me.btnAnexo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAnexo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAnexo.Location = New System.Drawing.Point(109, 121)
        Me.btnAnexo.Name = "btnAnexo"
        Me.btnAnexo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAnexo.Size = New System.Drawing.Size(60, 20)
        Me.btnAnexo.TabIndex = 11
        Me.btnAnexo.Text = "&Anexo"
        Me.btnAnexo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtAssunto
        '
        Me.txtAssunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAssunto.Location = New System.Drawing.Point(178, 95)
        Me.txtAssunto.MaxLength = 60
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(698, 20)
        Me.txtAssunto.TabIndex = 10
        '
        'txtCC
        '
        Me.txtCC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCC.Location = New System.Drawing.Point(178, 43)
        Me.txtCC.MaxLength = 60
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(698, 20)
        Me.txtCC.TabIndex = 9
        '
        'btnCC
        '
        Me.btnCC.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCC.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnCC.Location = New System.Drawing.Point(109, 43)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCC.Size = New System.Drawing.Size(60, 20)
        Me.btnCC.TabIndex = 8
        Me.btnCC.Text = "&Cc"
        Me.btnCC.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPara
        '
        Me.txtPara.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPara.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtPara.Location = New System.Drawing.Point(178, 17)
        Me.txtPara.MaxLength = 60
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(698, 20)
        Me.txtPara.TabIndex = 7
        '
        'btnPara
        '
        Me.btnPara.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPara.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPara.Location = New System.Drawing.Point(109, 17)
        Me.btnPara.Name = "btnPara"
        Me.btnPara.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPara.Size = New System.Drawing.Size(60, 20)
        Me.btnPara.TabIndex = 4
        Me.btnPara.Text = "&Para"
        Me.btnPara.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEnviar
        '
        Me.btnEnviar.Image = Global.INTERACTI.My.Resources.email_maior
        Me.btnEnviar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnEnviar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnEnviar.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.TopOfText
        Me.btnEnviar.Location = New System.Drawing.Point(9, 17)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEnviar.Size = New System.Drawing.Size(91, 124)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = "&Enviar"
        Me.btnEnviar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtBcc
        '
        Me.txtBcc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBcc.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtBcc.Location = New System.Drawing.Point(178, 69)
        Me.txtBcc.MaxLength = 60
        Me.txtBcc.Name = "txtBcc"
        Me.txtBcc.Size = New System.Drawing.Size(698, 20)
        Me.txtBcc.TabIndex = 15
        '
        'btnBcc
        '
        Me.btnBcc.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnBcc.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnBcc.Location = New System.Drawing.Point(109, 69)
        Me.btnBcc.Name = "btnBcc"
        Me.btnBcc.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnBcc.Size = New System.Drawing.Size(60, 20)
        Me.btnBcc.TabIndex = 14
        Me.btnBcc.Text = "&Bcc"
        Me.btnBcc.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtBody
        '
        Me.txtBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBody.Location = New System.Drawing.Point(6, 189)
        Me.txtBody.MaxLength = 0
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBody.Size = New System.Drawing.Size(885, 326)
        Me.txtBody.TabIndex = 13
        '
        'cboEmail
        '
        Me.cboEmail.AutoSize = False
        Me.cboEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEmail.Location = New System.Drawing.Point(184, 162)
        Me.cboEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboEmail.Name = "cboEmail"
        Me.cboEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEmail.Size = New System.Drawing.Size(707, 20)
        Me.cboEmail.TabIndex = 15
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(22, 165)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(115, 14)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "E-mail pré cadastrado:"
        '
        'btnCadastrarTextoEmail
        '
        Me.btnCadastrarTextoEmail.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTextoEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTextoEmail.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarTextoEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTextoEmail.Location = New System.Drawing.Point(6, 166)
        Me.btnCadastrarTextoEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTextoEmail.Name = "btnCadastrarTextoEmail"
        Me.btnCadastrarTextoEmail.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTextoEmail.TabIndex = 16
        Me.btnCadastrarTextoEmail.TabStop = False
        Me.btnCadastrarTextoEmail.UseVisualStyleBackColor = True
        '
        'frmEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 522)
        Me.Controls.Add(Me.btnCadastrarTextoEmail)
        Me.Controls.Add(Me.cboEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.grpEmail)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmail"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-mail"
        CType(Me.grpEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmail.ResumeLayout(False)
        Me.grpEmail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpEmail As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnEnviar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnPara As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtPara As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtAnexo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnAnexo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAssunto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCC As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnCC As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtBody As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblAssunto As System.Windows.Forms.Label
    Friend WithEvents txtBcc As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnBcc As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboEmail As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarTextoEmail As System.Windows.Forms.Button
End Class
