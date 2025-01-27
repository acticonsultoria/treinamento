<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAdmAtualizarAplicativo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrAdmAtualizarAplicativo))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox
        Me.btnAtualizar = New Janus.Windows.EditControls.UIButton
        Me.btnSair = New Janus.Windows.EditControls.UIButton
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox
        Me.lblVersao = New System.Windows.Forms.Label
        Me.txtVersao = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.btnAplicativo = New Janus.Windows.EditControls.UIButton
        Me.txtAplicativo = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblAplicativo = New System.Windows.Forms.Label
        Me.lblVersaoAtual = New System.Windows.Forms.Label
        Me.lblVersaoAtualLabel = New System.Windows.Forms.Label
        Me.lblDataUltimaAtualizacao = New System.Windows.Forms.Label
        Me.lblDataUltimaAtualizacaoLabel = New System.Windows.Forms.Label
        Me.picSistema = New System.Windows.Forms.PictureBox
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpControle.Controls.Add(Me.btnAtualizar)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(13, 227)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(489, 51)
        Me.grpControle.TabIndex = 1
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Image = Global.INTERACTI.My.Resources.upload
        Me.btnAtualizar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizar.Location = New System.Drawing.Point(292, 17)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(91, 23)
        Me.btnAtualizar.TabIndex = 0
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblVersao)
        Me.grpDados.Controls.Add(Me.txtVersao)
        Me.grpDados.Controls.Add(Me.btnAplicativo)
        Me.grpDados.Controls.Add(Me.txtAplicativo)
        Me.grpDados.Controls.Add(Me.lblAplicativo)
        Me.grpDados.Controls.Add(Me.lblVersaoAtual)
        Me.grpDados.Controls.Add(Me.lblVersaoAtualLabel)
        Me.grpDados.Controls.Add(Me.lblDataUltimaAtualizacao)
        Me.grpDados.Controls.Add(Me.lblDataUltimaAtualizacaoLabel)
        Me.grpDados.Location = New System.Drawing.Point(13, 120)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(489, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblVersao
        '
        Me.lblVersao.AutoSize = True
        Me.lblVersao.Location = New System.Drawing.Point(386, 17)
        Me.lblVersao.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(45, 14)
        Me.lblVersao.TabIndex = 3
        Me.lblVersao.Text = "Versão:"
        '
        'txtVersao
        '
        Me.txtVersao.Location = New System.Drawing.Point(389, 34)
        Me.txtVersao.Mask = "0,0,0,0"
        Me.txtVersao.Name = "txtVersao"
        Me.txtVersao.Size = New System.Drawing.Size(91, 20)
        Me.txtVersao.TabIndex = 4
        '
        'btnAplicativo
        '
        Me.btnAplicativo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAplicativo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAplicativo.Location = New System.Drawing.Point(363, 34)
        Me.btnAplicativo.Name = "btnAplicativo"
        Me.btnAplicativo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAplicativo.Size = New System.Drawing.Size(20, 20)
        Me.btnAplicativo.TabIndex = 2
        Me.btnAplicativo.Text = "..."
        Me.btnAplicativo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtAplicativo
        '
        Me.txtAplicativo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAplicativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAplicativo.Enabled = False
        Me.txtAplicativo.Location = New System.Drawing.Point(9, 34)
        Me.txtAplicativo.MaxLength = 255
        Me.txtAplicativo.Name = "txtAplicativo"
        Me.txtAplicativo.ReadOnly = True
        Me.txtAplicativo.Size = New System.Drawing.Size(355, 20)
        Me.txtAplicativo.TabIndex = 1
        Me.txtAplicativo.TabStop = False
        '
        'lblAplicativo
        '
        Me.lblAplicativo.AutoSize = True
        Me.lblAplicativo.Location = New System.Drawing.Point(6, 17)
        Me.lblAplicativo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblAplicativo.Name = "lblAplicativo"
        Me.lblAplicativo.Size = New System.Drawing.Size(57, 14)
        Me.lblAplicativo.TabIndex = 0
        Me.lblAplicativo.Text = "Aplicativo:"
        '
        'lblVersaoAtual
        '
        Me.lblVersaoAtual.AutoSize = True
        Me.lblVersaoAtual.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblVersaoAtual.ForeColor = System.Drawing.Color.Blue
        Me.lblVersaoAtual.Location = New System.Drawing.Point(134, 60)
        Me.lblVersaoAtual.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblVersaoAtual.Name = "lblVersaoAtual"
        Me.lblVersaoAtual.Size = New System.Drawing.Size(11, 14)
        Me.lblVersaoAtual.TabIndex = 6
        Me.lblVersaoAtual.Text = "-"
        '
        'lblVersaoAtualLabel
        '
        Me.lblVersaoAtualLabel.AutoSize = True
        Me.lblVersaoAtualLabel.Location = New System.Drawing.Point(6, 60)
        Me.lblVersaoAtualLabel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblVersaoAtualLabel.Name = "lblVersaoAtualLabel"
        Me.lblVersaoAtualLabel.Size = New System.Drawing.Size(72, 14)
        Me.lblVersaoAtualLabel.TabIndex = 5
        Me.lblVersaoAtualLabel.Text = "Versão Atual:"
        '
        'lblDataUltimaAtualizacao
        '
        Me.lblDataUltimaAtualizacao.AutoSize = True
        Me.lblDataUltimaAtualizacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDataUltimaAtualizacao.ForeColor = System.Drawing.Color.Blue
        Me.lblDataUltimaAtualizacao.Location = New System.Drawing.Point(134, 81)
        Me.lblDataUltimaAtualizacao.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblDataUltimaAtualizacao.Name = "lblDataUltimaAtualizacao"
        Me.lblDataUltimaAtualizacao.Size = New System.Drawing.Size(11, 14)
        Me.lblDataUltimaAtualizacao.TabIndex = 8
        Me.lblDataUltimaAtualizacao.Text = "-"
        '
        'lblDataUltimaAtualizacaoLabel
        '
        Me.lblDataUltimaAtualizacaoLabel.AutoSize = True
        Me.lblDataUltimaAtualizacaoLabel.Location = New System.Drawing.Point(6, 81)
        Me.lblDataUltimaAtualizacaoLabel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblDataUltimaAtualizacaoLabel.Name = "lblDataUltimaAtualizacaoLabel"
        Me.lblDataUltimaAtualizacaoLabel.Size = New System.Drawing.Size(122, 14)
        Me.lblDataUltimaAtualizacaoLabel.TabIndex = 7
        Me.lblDataUltimaAtualizacaoLabel.Text = "Data Última Atualização:"
        '
        'picSistema
        '
        Me.picSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSistema.Image = Global.INTERACTI.My.Resources.Interacti
        Me.picSistema.Location = New System.Drawing.Point(13, 8)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(489, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 10
        Me.picSistema.TabStop = False
        '
        'usrECFLeituraX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picSistema)
        Me.Controls.Add(Me.grpControle)
        Me.Controls.Add(Me.grpDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrECFLeituraX"
        Me.Size = New System.Drawing.Size(516, 293)
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
    Friend WithEvents btnAtualizar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersaoAtual As System.Windows.Forms.Label
    Friend WithEvents lblVersaoAtualLabel As System.Windows.Forms.Label
    Friend WithEvents lblDataUltimaAtualizacao As System.Windows.Forms.Label
    Friend WithEvents lblDataUltimaAtualizacaoLabel As System.Windows.Forms.Label
    Friend WithEvents btnAplicativo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAplicativo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAplicativo As System.Windows.Forms.Label
    Friend WithEvents lblVersao As System.Windows.Forms.Label
    Friend WithEvents txtVersao As Janus.Windows.GridEX.EditControls.MaskedEditBox

End Class
