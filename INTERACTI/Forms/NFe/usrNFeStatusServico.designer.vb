<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrNFeStatusServico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrNFeStatusServico))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnConsultarStatusServico = New Janus.Windows.EditControls.UIButton
        Me.btnSair = New Janus.Windows.EditControls.UIButton
        Me.picEmail = New System.Windows.Forms.PictureBox
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtUsuario = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtSenha = New Janus.Windows.GridEX.EditControls.EditBox
        Me.txtServidor = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtPorta = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblValorDataPrevisaoRetorno = New System.Windows.Forms.Label
        Me.lblValorTempoMedioResposta = New System.Windows.Forms.Label
        Me.lblTempoMedioResposta = New System.Windows.Forms.Label
        Me.lblValorDataProcessamento = New System.Windows.Forms.Label
        Me.lblMotivo = New System.Windows.Forms.Label
        Me.lblValorMotivo = New System.Windows.Forms.Label
        Me.lblValorUF = New System.Windows.Forms.Label
        Me.lblUF = New System.Windows.Forms.Label
        Me.lblValorAmbiente = New System.Windows.Forms.Label
        Me.lblAmbiente = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblValorStatus = New System.Windows.Forms.Label
        Me.lblDataProcessamento = New System.Windows.Forms.Label
        Me.lblDataPrevisaoRetorno = New System.Windows.Forms.Label
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
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
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.btnConsultarStatusServico)
        Me.UiGroupBox3.Controls.Add(Me.btnSair)
        Me.UiGroupBox3.Location = New System.Drawing.Point(13, 175)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(588, 51)
        Me.UiGroupBox3.TabIndex = 1
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'btnConsultarStatusServico
        '
        Me.btnConsultarStatusServico.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnConsultarStatusServico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConsultarStatusServico.Location = New System.Drawing.Point(301, 17)
        Me.btnConsultarStatusServico.Name = "btnConsultarStatusServico"
        Me.btnConsultarStatusServico.Size = New System.Drawing.Size(180, 23)
        Me.btnConsultarStatusServico.TabIndex = 0
        Me.btnConsultarStatusServico.Text = "Consultar Status do Serviço"
        Me.btnConsultarStatusServico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(487, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'picEmail
        '
        Me.picEmail.Image = Global.INTERACTI.My.Resources.servico
        Me.picEmail.Location = New System.Drawing.Point(13, 26)
        Me.picEmail.Name = "picEmail"
        Me.picEmail.Size = New System.Drawing.Size(130, 130)
        Me.picEmail.TabIndex = 9
        Me.picEmail.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(9, 34)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(326, 20)
        Me.txtEmail.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUsuario.Location = New System.Drawing.Point(9, 74)
        Me.txtUsuario.MaxLength = 100
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(235, 74)
        Me.txtSenha.MaxLength = 20
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 5
        '
        'txtServidor
        '
        Me.txtServidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtServidor.Location = New System.Drawing.Point(9, 114)
        Me.txtServidor.MaxLength = 100
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(165, 20)
        Me.txtServidor.TabIndex = 7
        '
        'txtPorta
        '
        Me.txtPorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorta.Location = New System.Drawing.Point(180, 114)
        Me.txtPorta.MaxLength = 4
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Size = New System.Drawing.Size(49, 20)
        Me.txtPorta.TabIndex = 9
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.lblValorDataPrevisaoRetorno)
        Me.UiGroupBox2.Controls.Add(Me.lblValorTempoMedioResposta)
        Me.UiGroupBox2.Controls.Add(Me.lblTempoMedioResposta)
        Me.UiGroupBox2.Controls.Add(Me.lblValorDataProcessamento)
        Me.UiGroupBox2.Controls.Add(Me.lblMotivo)
        Me.UiGroupBox2.Controls.Add(Me.lblValorMotivo)
        Me.UiGroupBox2.Controls.Add(Me.lblValorUF)
        Me.UiGroupBox2.Controls.Add(Me.lblUF)
        Me.UiGroupBox2.Controls.Add(Me.lblValorAmbiente)
        Me.UiGroupBox2.Controls.Add(Me.lblAmbiente)
        Me.UiGroupBox2.Controls.Add(Me.lblStatus)
        Me.UiGroupBox2.Controls.Add(Me.lblValorStatus)
        Me.UiGroupBox2.Controls.Add(Me.lblDataProcessamento)
        Me.UiGroupBox2.Controls.Add(Me.lblDataPrevisaoRetorno)
        Me.UiGroupBox2.Location = New System.Drawing.Point(157, 8)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(444, 162)
        Me.UiGroupBox2.TabIndex = 10
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'lblValorDataPrevisaoRetorno
        '
        Me.lblValorDataPrevisaoRetorno.AutoSize = True
        Me.lblValorDataPrevisaoRetorno.Location = New System.Drawing.Point(153, 134)
        Me.lblValorDataPrevisaoRetorno.Name = "lblValorDataPrevisaoRetorno"
        Me.lblValorDataPrevisaoRetorno.Size = New System.Drawing.Size(11, 14)
        Me.lblValorDataPrevisaoRetorno.TabIndex = 17
        Me.lblValorDataPrevisaoRetorno.Text = "-"
        '
        'lblValorTempoMedioResposta
        '
        Me.lblValorTempoMedioResposta.AutoSize = True
        Me.lblValorTempoMedioResposta.Location = New System.Drawing.Point(153, 115)
        Me.lblValorTempoMedioResposta.Name = "lblValorTempoMedioResposta"
        Me.lblValorTempoMedioResposta.Size = New System.Drawing.Size(11, 14)
        Me.lblValorTempoMedioResposta.TabIndex = 14
        Me.lblValorTempoMedioResposta.Text = "-"
        '
        'lblTempoMedioResposta
        '
        Me.lblTempoMedioResposta.AutoSize = True
        Me.lblTempoMedioResposta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempoMedioResposta.Location = New System.Drawing.Point(6, 115)
        Me.lblTempoMedioResposta.Name = "lblTempoMedioResposta"
        Me.lblTempoMedioResposta.Size = New System.Drawing.Size(140, 14)
        Me.lblTempoMedioResposta.TabIndex = 15
        Me.lblTempoMedioResposta.Text = "Tempo Médio Resposta:"
        '
        'lblValorDataProcessamento
        '
        Me.lblValorDataProcessamento.AutoSize = True
        Me.lblValorDataProcessamento.Location = New System.Drawing.Point(153, 96)
        Me.lblValorDataProcessamento.Name = "lblValorDataProcessamento"
        Me.lblValorDataProcessamento.Size = New System.Drawing.Size(11, 14)
        Me.lblValorDataProcessamento.TabIndex = 12
        Me.lblValorDataProcessamento.Text = "-"
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivo.Location = New System.Drawing.Point(6, 77)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(47, 14)
        Me.lblMotivo.TabIndex = 11
        Me.lblMotivo.Text = "Motivo:"
        '
        'lblValorMotivo
        '
        Me.lblValorMotivo.AutoSize = True
        Me.lblValorMotivo.Location = New System.Drawing.Point(153, 77)
        Me.lblValorMotivo.Name = "lblValorMotivo"
        Me.lblValorMotivo.Size = New System.Drawing.Size(11, 14)
        Me.lblValorMotivo.TabIndex = 10
        Me.lblValorMotivo.Text = "-"
        '
        'lblValorUF
        '
        Me.lblValorUF.AutoSize = True
        Me.lblValorUF.Location = New System.Drawing.Point(153, 39)
        Me.lblValorUF.Name = "lblValorUF"
        Me.lblValorUF.Size = New System.Drawing.Size(11, 14)
        Me.lblValorUF.TabIndex = 9
        Me.lblValorUF.Text = "-"
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUF.Location = New System.Drawing.Point(6, 39)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(23, 14)
        Me.lblUF.TabIndex = 8
        Me.lblUF.Text = "UF:"
        '
        'lblValorAmbiente
        '
        Me.lblValorAmbiente.AutoSize = True
        Me.lblValorAmbiente.Location = New System.Drawing.Point(153, 20)
        Me.lblValorAmbiente.Name = "lblValorAmbiente"
        Me.lblValorAmbiente.Size = New System.Drawing.Size(11, 14)
        Me.lblValorAmbiente.TabIndex = 7
        Me.lblValorAmbiente.Text = "-"
        '
        'lblAmbiente
        '
        Me.lblAmbiente.AutoSize = True
        Me.lblAmbiente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmbiente.Location = New System.Drawing.Point(6, 20)
        Me.lblAmbiente.Name = "lblAmbiente"
        Me.lblAmbiente.Size = New System.Drawing.Size(64, 14)
        Me.lblAmbiente.TabIndex = 6
        Me.lblAmbiente.Text = "Ambiente:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(6, 58)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 14)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Status:"
        '
        'lblValorStatus
        '
        Me.lblValorStatus.AutoSize = True
        Me.lblValorStatus.Location = New System.Drawing.Point(153, 58)
        Me.lblValorStatus.Name = "lblValorStatus"
        Me.lblValorStatus.Size = New System.Drawing.Size(11, 14)
        Me.lblValorStatus.TabIndex = 4
        Me.lblValorStatus.Text = "-"
        '
        'lblDataProcessamento
        '
        Me.lblDataProcessamento.AutoSize = True
        Me.lblDataProcessamento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataProcessamento.Location = New System.Drawing.Point(6, 96)
        Me.lblDataProcessamento.Name = "lblDataProcessamento"
        Me.lblDataProcessamento.Size = New System.Drawing.Size(124, 14)
        Me.lblDataProcessamento.TabIndex = 13
        Me.lblDataProcessamento.Text = "Data Processamento:"
        '
        'lblDataPrevisaoRetorno
        '
        Me.lblDataPrevisaoRetorno.AutoSize = True
        Me.lblDataPrevisaoRetorno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataPrevisaoRetorno.Location = New System.Drawing.Point(6, 134)
        Me.lblDataPrevisaoRetorno.Name = "lblDataPrevisaoRetorno"
        Me.lblDataPrevisaoRetorno.Size = New System.Drawing.Size(131, 14)
        Me.lblDataPrevisaoRetorno.TabIndex = 16
        Me.lblDataPrevisaoRetorno.Text = "Data Previsão Retorno:"
        '
        'usrFatEmissaoNFeStatusServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.UiGroupBox2)
        Me.Controls.Add(Me.picEmail)
        Me.Controls.Add(Me.UiGroupBox3)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatEmissaoNFeStatusServico"
        Me.Size = New System.Drawing.Size(615, 241)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picEmail As System.Windows.Forms.PictureBox
    Friend WithEvents btnConsultarStatusServico As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtUsuario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSenha As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtServidor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtPorta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorUF As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents lblValorAmbiente As System.Windows.Forms.Label
    Friend WithEvents lblAmbiente As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblValorStatus As System.Windows.Forms.Label
    Friend WithEvents lblValorTempoMedioResposta As System.Windows.Forms.Label
    Friend WithEvents lblTempoMedioResposta As System.Windows.Forms.Label
    Friend WithEvents lblValorDataProcessamento As System.Windows.Forms.Label
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents lblValorMotivo As System.Windows.Forms.Label
    Friend WithEvents lblDataProcessamento As System.Windows.Forms.Label
    Friend WithEvents lblDataPrevisaoRetorno As System.Windows.Forms.Label
    Friend WithEvents lblValorDataPrevisaoRetorno As System.Windows.Forms.Label

End Class
