<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmConfigXML
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmConfigXML))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnGerarXML = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosXML = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboPreconfiguracao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPreconfiguracao = New System.Windows.Forms.Label()
        Me.txtBancoDados = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBancoDados = New System.Windows.Forms.Label()
        Me.txtSenha = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtUsuario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtNomeServidor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnRelatorio = New Janus.Windows.EditControls.UIButton()
        Me.txtRelatorio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRelatorio = New System.Windows.Forms.Label()
        Me.lblNomeServidor = New System.Windows.Forms.Label()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpDadosXML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosXML.SuspendLayout()
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
        Me.picSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSistema.Image = Global.INTERACTI.My.Resources.Resources.interacti
        Me.picSistema.Location = New System.Drawing.Point(8, 11)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(489, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 16
        Me.picSistema.TabStop = False
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnGerarXML)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 319)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(489, 51)
        Me.grpControle.TabIndex = 15
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnGerarXML
        '
        Me.btnGerarXML.Image = Global.INTERACTI.My.Resources.Resources.xml
        Me.btnGerarXML.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarXML.Location = New System.Drawing.Point(233, 17)
        Me.btnGerarXML.Name = "btnGerarXML"
        Me.btnGerarXML.Size = New System.Drawing.Size(150, 23)
        Me.btnGerarXML.TabIndex = 0
        Me.btnGerarXML.Text = "Gerar Config.xml"
        Me.btnGerarXML.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'grpDadosXML
        '
        Me.grpDadosXML.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosXML.Controls.Add(Me.cboPreconfiguracao)
        Me.grpDadosXML.Controls.Add(Me.lblPreconfiguracao)
        Me.grpDadosXML.Controls.Add(Me.txtBancoDados)
        Me.grpDadosXML.Controls.Add(Me.lblBancoDados)
        Me.grpDadosXML.Controls.Add(Me.txtSenha)
        Me.grpDadosXML.Controls.Add(Me.lblSenha)
        Me.grpDadosXML.Controls.Add(Me.txtUsuario)
        Me.grpDadosXML.Controls.Add(Me.lblUsuario)
        Me.grpDadosXML.Controls.Add(Me.txtNomeServidor)
        Me.grpDadosXML.Controls.Add(Me.btnRelatorio)
        Me.grpDadosXML.Controls.Add(Me.txtRelatorio)
        Me.grpDadosXML.Controls.Add(Me.lblRelatorio)
        Me.grpDadosXML.Controls.Add(Me.lblNomeServidor)
        Me.grpDadosXML.Location = New System.Drawing.Point(8, 123)
        Me.grpDadosXML.Name = "grpDadosXML"
        Me.grpDadosXML.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosXML.Size = New System.Drawing.Size(489, 193)
        Me.grpDadosXML.TabIndex = 14
        Me.grpDadosXML.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosXML.VisualStyleManager = Me.vsmMain
        '
        'cboPreconfiguracao
        '
        Me.cboPreconfiguracao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPreconfiguracao.AutoSize = False
        Me.cboPreconfiguracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPreconfiguracao.Location = New System.Drawing.Point(133, 63)
        Me.cboPreconfiguracao.Name = "cboPreconfiguracao"
        Me.cboPreconfiguracao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPreconfiguracao.Size = New System.Drawing.Size(347, 20)
        Me.cboPreconfiguracao.TabIndex = 12
        '
        'lblPreconfiguracao
        '
        Me.lblPreconfiguracao.AutoSize = True
        Me.lblPreconfiguracao.Location = New System.Drawing.Point(6, 63)
        Me.lblPreconfiguracao.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblPreconfiguracao.Name = "lblPreconfiguracao"
        Me.lblPreconfiguracao.Size = New System.Drawing.Size(94, 14)
        Me.lblPreconfiguracao.TabIndex = 11
        Me.lblPreconfiguracao.Text = "Pré-configuração:"
        '
        'txtBancoDados
        '
        Me.txtBancoDados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoDados.Location = New System.Drawing.Point(133, 165)
        Me.txtBancoDados.Name = "txtBancoDados"
        Me.txtBancoDados.Size = New System.Drawing.Size(250, 20)
        Me.txtBancoDados.TabIndex = 10
        '
        'lblBancoDados
        '
        Me.lblBancoDados.AutoSize = True
        Me.lblBancoDados.Location = New System.Drawing.Point(6, 168)
        Me.lblBancoDados.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblBancoDados.Name = "lblBancoDados"
        Me.lblBancoDados.Size = New System.Drawing.Size(90, 14)
        Me.lblBancoDados.TabIndex = 9
        Me.lblBancoDados.Text = "Banco de Dados:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(133, 139)
        Me.txtSenha.MaxLength = 20
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(113, 20)
        Me.txtSenha.TabIndex = 8
        Me.txtSenha.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(6, 142)
        Me.lblSenha.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(41, 14)
        Me.lblSenha.TabIndex = 7
        Me.lblSenha.Text = "Senha:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(133, 113)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(113, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(6, 116)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "Usuário:"
        '
        'txtNomeServidor
        '
        Me.txtNomeServidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeServidor.Location = New System.Drawing.Point(133, 87)
        Me.txtNomeServidor.Name = "txtNomeServidor"
        Me.txtNomeServidor.Size = New System.Drawing.Size(250, 20)
        Me.txtNomeServidor.TabIndex = 4
        '
        'btnRelatorio
        '
        Me.btnRelatorio.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRelatorio.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnRelatorio.Location = New System.Drawing.Point(460, 34)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRelatorio.Size = New System.Drawing.Size(20, 20)
        Me.btnRelatorio.TabIndex = 2
        Me.btnRelatorio.Text = "..."
        Me.btnRelatorio.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtRelatorio
        '
        Me.txtRelatorio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRelatorio.Location = New System.Drawing.Point(9, 34)
        Me.txtRelatorio.MaxLength = 255
        Me.txtRelatorio.Name = "txtRelatorio"
        Me.txtRelatorio.Size = New System.Drawing.Size(452, 20)
        Me.txtRelatorio.TabIndex = 1
        Me.txtRelatorio.TabStop = False
        '
        'lblRelatorio
        '
        Me.lblRelatorio.AutoSize = True
        Me.lblRelatorio.Location = New System.Drawing.Point(6, 17)
        Me.lblRelatorio.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblRelatorio.Name = "lblRelatorio"
        Me.lblRelatorio.Size = New System.Drawing.Size(52, 14)
        Me.lblRelatorio.TabIndex = 0
        Me.lblRelatorio.Text = "Relatório:"
        '
        'lblNomeServidor
        '
        Me.lblNomeServidor.AutoSize = True
        Me.lblNomeServidor.Location = New System.Drawing.Point(6, 90)
        Me.lblNomeServidor.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblNomeServidor.Name = "lblNomeServidor"
        Me.lblNomeServidor.Size = New System.Drawing.Size(96, 14)
        Me.lblNomeServidor.TabIndex = 3
        Me.lblNomeServidor.Text = "Nome do Servidor:"
        '
        'frmAdmConfigXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(506, 379)
        Me.Controls.Add(Me.picSistema)
        Me.Controls.Add(Me.grpControle)
        Me.Controls.Add(Me.grpDadosXML)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdmConfigXML"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpDadosXML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosXML.ResumeLayout(False)
        Me.grpDadosXML.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnGerarXML As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosXML As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtBancoDados As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBancoDados As System.Windows.Forms.Label
    Friend WithEvents txtSenha As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtNomeServidor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnRelatorio As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtRelatorio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRelatorio As System.Windows.Forms.Label
    Friend WithEvents lblNomeServidor As System.Windows.Forms.Label
    Friend WithEvents lblPreconfiguracao As System.Windows.Forms.Label
    Friend WithEvents cboPreconfiguracao As Janus.Windows.EditControls.UIComboBox
End Class
