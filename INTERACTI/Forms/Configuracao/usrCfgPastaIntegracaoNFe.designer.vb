<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCfgPastaIntegracaoNFe
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
        Me.components = New System.ComponentModel.Container
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCfgPastaIntegracaoNFe))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox
        Me.btnPastaArquivoNFe = New Janus.Windows.EditControls.UIButton
        Me.txtPastaArquivoNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblPastaArquivoNFe = New System.Windows.Forms.Label
        Me.picEmail = New System.Windows.Forms.PictureBox
        Me.btnSair = New Janus.Windows.EditControls.UIButton
        Me.btnPastaArquivoRetornoNFe = New Janus.Windows.EditControls.UIButton
        Me.txtPastaArquivoRetornoNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblPastaArquivoRetornoNFe = New System.Windows.Forms.Label
        Me.btnPastaArquivoCancelamentoNFe = New Janus.Windows.EditControls.UIButton
        Me.txtPastaArquivoCancelamentoNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblPastaArquivoCancelamentoNFe = New System.Windows.Forms.Label
        Me.btnPastaArquivoRetornoCancelamentoNFe = New Janus.Windows.EditControls.UIButton
        Me.txtPastaArquivoRetornoCancelamentoNFe = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblPastaArquivoRetornoCancelamentoNFe = New System.Windows.Forms.Label
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        'grpControle
        '
        Me.grpControle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSalvar)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(13, 201)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(489, 51)
        Me.grpControle.TabIndex = 1
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(292, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnPastaArquivoRetornoCancelamentoNFe)
        Me.grpDados.Controls.Add(Me.txtPastaArquivoRetornoCancelamentoNFe)
        Me.grpDados.Controls.Add(Me.lblPastaArquivoRetornoCancelamentoNFe)
        Me.grpDados.Controls.Add(Me.btnPastaArquivoCancelamentoNFe)
        Me.grpDados.Controls.Add(Me.txtPastaArquivoCancelamentoNFe)
        Me.grpDados.Controls.Add(Me.lblPastaArquivoCancelamentoNFe)
        Me.grpDados.Controls.Add(Me.btnPastaArquivoRetornoNFe)
        Me.grpDados.Controls.Add(Me.txtPastaArquivoRetornoNFe)
        Me.grpDados.Controls.Add(Me.lblPastaArquivoRetornoNFe)
        Me.grpDados.Controls.Add(Me.btnPastaArquivoNFe)
        Me.grpDados.Controls.Add(Me.txtPastaArquivoNFe)
        Me.grpDados.Controls.Add(Me.lblPastaArquivoNFe)
        Me.grpDados.Location = New System.Drawing.Point(157, 8)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(345, 185)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnPastaArquivoNFe
        '
        Me.btnPastaArquivoNFe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPastaArquivoNFe.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPastaArquivoNFe.Location = New System.Drawing.Point(316, 34)
        Me.btnPastaArquivoNFe.Name = "btnPastaArquivoNFe"
        Me.btnPastaArquivoNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPastaArquivoNFe.Size = New System.Drawing.Size(20, 20)
        Me.btnPastaArquivoNFe.TabIndex = 2
        Me.btnPastaArquivoNFe.Text = "..."
        Me.btnPastaArquivoNFe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPastaArquivoNFe
        '
        Me.txtPastaArquivoNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPastaArquivoNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPastaArquivoNFe.Enabled = False
        Me.txtPastaArquivoNFe.Location = New System.Drawing.Point(9, 34)
        Me.txtPastaArquivoNFe.MaxLength = 255
        Me.txtPastaArquivoNFe.Name = "txtPastaArquivoNFe"
        Me.txtPastaArquivoNFe.ReadOnly = True
        Me.txtPastaArquivoNFe.Size = New System.Drawing.Size(308, 20)
        Me.txtPastaArquivoNFe.TabIndex = 1
        Me.txtPastaArquivoNFe.TabStop = False
        '
        'lblPastaArquivoNFe
        '
        Me.lblPastaArquivoNFe.AutoSize = True
        Me.lblPastaArquivoNFe.Location = New System.Drawing.Point(6, 17)
        Me.lblPastaArquivoNFe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblPastaArquivoNFe.Name = "lblPastaArquivoNFe"
        Me.lblPastaArquivoNFe.Size = New System.Drawing.Size(121, 14)
        Me.lblPastaArquivoNFe.TabIndex = 0
        Me.lblPastaArquivoNFe.Text = "Pasta de Arquivo - NFe:"
        '
        'picEmail
        '
        Me.picEmail.Image = Global.INTERACTI.My.Resources.pasta
        Me.picEmail.Location = New System.Drawing.Point(13, 39)
        Me.picEmail.Name = "picEmail"
        Me.picEmail.Size = New System.Drawing.Size(134, 139)
        Me.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmail.TabIndex = 9
        Me.picEmail.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(389, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPastaArquivoRetornoNFe
        '
        Me.btnPastaArquivoRetornoNFe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPastaArquivoRetornoNFe.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPastaArquivoRetornoNFe.Location = New System.Drawing.Point(317, 74)
        Me.btnPastaArquivoRetornoNFe.Name = "btnPastaArquivoRetornoNFe"
        Me.btnPastaArquivoRetornoNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPastaArquivoRetornoNFe.Size = New System.Drawing.Size(20, 20)
        Me.btnPastaArquivoRetornoNFe.TabIndex = 5
        Me.btnPastaArquivoRetornoNFe.Text = "..."
        Me.btnPastaArquivoRetornoNFe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPastaArquivoRetornoNFe
        '
        Me.txtPastaArquivoRetornoNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPastaArquivoRetornoNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPastaArquivoRetornoNFe.Enabled = False
        Me.txtPastaArquivoRetornoNFe.Location = New System.Drawing.Point(10, 74)
        Me.txtPastaArquivoRetornoNFe.MaxLength = 255
        Me.txtPastaArquivoRetornoNFe.Name = "txtPastaArquivoRetornoNFe"
        Me.txtPastaArquivoRetornoNFe.ReadOnly = True
        Me.txtPastaArquivoRetornoNFe.Size = New System.Drawing.Size(308, 20)
        Me.txtPastaArquivoRetornoNFe.TabIndex = 4
        Me.txtPastaArquivoRetornoNFe.TabStop = False
        '
        'lblPastaArquivoRetornoNFe
        '
        Me.lblPastaArquivoRetornoNFe.AutoSize = True
        Me.lblPastaArquivoRetornoNFe.Location = New System.Drawing.Point(7, 57)
        Me.lblPastaArquivoRetornoNFe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblPastaArquivoRetornoNFe.Name = "lblPastaArquivoRetornoNFe"
        Me.lblPastaArquivoRetornoNFe.Size = New System.Drawing.Size(162, 14)
        Me.lblPastaArquivoRetornoNFe.TabIndex = 3
        Me.lblPastaArquivoRetornoNFe.Text = "Pasta de Arquivo - Retorno NFe:"
        '
        'btnPastaArquivoCancelamentoNFe
        '
        Me.btnPastaArquivoCancelamentoNFe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPastaArquivoCancelamentoNFe.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPastaArquivoCancelamentoNFe.Location = New System.Drawing.Point(317, 114)
        Me.btnPastaArquivoCancelamentoNFe.Name = "btnPastaArquivoCancelamentoNFe"
        Me.btnPastaArquivoCancelamentoNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPastaArquivoCancelamentoNFe.Size = New System.Drawing.Size(20, 20)
        Me.btnPastaArquivoCancelamentoNFe.TabIndex = 8
        Me.btnPastaArquivoCancelamentoNFe.Text = "..."
        Me.btnPastaArquivoCancelamentoNFe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPastaArquivoCancelamentoNFe
        '
        Me.txtPastaArquivoCancelamentoNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPastaArquivoCancelamentoNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPastaArquivoCancelamentoNFe.Enabled = False
        Me.txtPastaArquivoCancelamentoNFe.Location = New System.Drawing.Point(10, 114)
        Me.txtPastaArquivoCancelamentoNFe.MaxLength = 255
        Me.txtPastaArquivoCancelamentoNFe.Name = "txtPastaArquivoCancelamentoNFe"
        Me.txtPastaArquivoCancelamentoNFe.ReadOnly = True
        Me.txtPastaArquivoCancelamentoNFe.Size = New System.Drawing.Size(308, 20)
        Me.txtPastaArquivoCancelamentoNFe.TabIndex = 7
        Me.txtPastaArquivoCancelamentoNFe.TabStop = False
        '
        'lblPastaArquivoCancelamentoNFe
        '
        Me.lblPastaArquivoCancelamentoNFe.AutoSize = True
        Me.lblPastaArquivoCancelamentoNFe.Location = New System.Drawing.Point(7, 97)
        Me.lblPastaArquivoCancelamentoNFe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblPastaArquivoCancelamentoNFe.Name = "lblPastaArquivoCancelamentoNFe"
        Me.lblPastaArquivoCancelamentoNFe.Size = New System.Drawing.Size(192, 14)
        Me.lblPastaArquivoCancelamentoNFe.TabIndex = 6
        Me.lblPastaArquivoCancelamentoNFe.Text = "Pasta de Arquivo - Cancelamento NFe:"
        '
        'btnPastaArquivoRetornoCancelamentoNFe
        '
        Me.btnPastaArquivoRetornoCancelamentoNFe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPastaArquivoRetornoCancelamentoNFe.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPastaArquivoRetornoCancelamentoNFe.Location = New System.Drawing.Point(316, 154)
        Me.btnPastaArquivoRetornoCancelamentoNFe.Name = "btnPastaArquivoRetornoCancelamentoNFe"
        Me.btnPastaArquivoRetornoCancelamentoNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPastaArquivoRetornoCancelamentoNFe.Size = New System.Drawing.Size(20, 20)
        Me.btnPastaArquivoRetornoCancelamentoNFe.TabIndex = 11
        Me.btnPastaArquivoRetornoCancelamentoNFe.Text = "..."
        Me.btnPastaArquivoRetornoCancelamentoNFe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPastaArquivoRetornoCancelamentoNFe
        '
        Me.txtPastaArquivoRetornoCancelamentoNFe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPastaArquivoRetornoCancelamentoNFe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPastaArquivoRetornoCancelamentoNFe.Enabled = False
        Me.txtPastaArquivoRetornoCancelamentoNFe.Location = New System.Drawing.Point(9, 154)
        Me.txtPastaArquivoRetornoCancelamentoNFe.MaxLength = 255
        Me.txtPastaArquivoRetornoCancelamentoNFe.Name = "txtPastaArquivoRetornoCancelamentoNFe"
        Me.txtPastaArquivoRetornoCancelamentoNFe.ReadOnly = True
        Me.txtPastaArquivoRetornoCancelamentoNFe.Size = New System.Drawing.Size(308, 20)
        Me.txtPastaArquivoRetornoCancelamentoNFe.TabIndex = 10
        Me.txtPastaArquivoRetornoCancelamentoNFe.TabStop = False
        '
        'lblPastaArquivoRetornoCancelamentoNFe
        '
        Me.lblPastaArquivoRetornoCancelamentoNFe.AutoSize = True
        Me.lblPastaArquivoRetornoCancelamentoNFe.Location = New System.Drawing.Point(6, 137)
        Me.lblPastaArquivoRetornoCancelamentoNFe.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblPastaArquivoRetornoCancelamentoNFe.Name = "lblPastaArquivoRetornoCancelamentoNFe"
        Me.lblPastaArquivoRetornoCancelamentoNFe.Size = New System.Drawing.Size(233, 14)
        Me.lblPastaArquivoRetornoCancelamentoNFe.TabIndex = 9
        Me.lblPastaArquivoRetornoCancelamentoNFe.Text = "Pasta de Arquivo - Retorno Cancelamento NFe:"
        '
        'usrCfgArquivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picEmail)
        Me.Controls.Add(Me.grpControle)
        Me.Controls.Add(Me.grpDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCfgArquivo"
        Me.Size = New System.Drawing.Size(516, 267)
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPastaArquivoNFe As System.Windows.Forms.Label
    Friend WithEvents picEmail As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtPastaArquivoNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnPastaArquivoNFe As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPastaArquivoCancelamentoNFe As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtPastaArquivoCancelamentoNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPastaArquivoCancelamentoNFe As System.Windows.Forms.Label
    Friend WithEvents btnPastaArquivoRetornoNFe As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtPastaArquivoRetornoNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPastaArquivoRetornoNFe As System.Windows.Forms.Label
    Friend WithEvents btnPastaArquivoRetornoCancelamentoNFe As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtPastaArquivoRetornoCancelamentoNFe As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPastaArquivoRetornoCancelamentoNFe As System.Windows.Forms.Label

End Class
