<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgBox))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.pctExclamacao = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAcao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.pctExclamacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblMensagem.Location = New System.Drawing.Point(90, 27)
        Me.lblMensagem.MaximumSize = New System.Drawing.Size(360, 0)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMensagem.Size = New System.Drawing.Size(79, 15)
        Me.lblMensagem.TabIndex = 0
        Me.lblMensagem.Text = "Mensagem"
        '
        'pctExclamacao
        '
        Me.pctExclamacao.Image = Global.INTERACTI.My.Resources.Resources.warning
        Me.pctExclamacao.Location = New System.Drawing.Point(12, 19)
        Me.pctExclamacao.Name = "pctExclamacao"
        Me.pctExclamacao.Size = New System.Drawing.Size(72, 61)
        Me.pctExclamacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctExclamacao.TabIndex = 5
        Me.pctExclamacao.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnAcao)
        Me.Panel1.Controls.Add(Me.btnSair)
        Me.Panel1.Location = New System.Drawing.Point(1, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 38)
        Me.Panel1.TabIndex = 1
        '
        'btnAcao
        '
        Me.btnAcao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAcao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAcao.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAcao.Location = New System.Drawing.Point(325, 8)
        Me.btnAcao.Name = "btnAcao"
        Me.btnAcao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAcao.Size = New System.Drawing.Size(55, 23)
        Me.btnAcao.TabIndex = 0
        Me.btnAcao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnSair.Location = New System.Drawing.Point(386, 8)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(471, 145)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pctExclamacao)
        Me.Controls.Add(Me.lblMensagem)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsgBox"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pctExclamacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents pctExclamacao As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAcao As Janus.Windows.EditControls.UIButton
End Class
