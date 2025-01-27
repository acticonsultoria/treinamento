<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmControleLicenca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmControleLicenca))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroLicencaNovo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroLicencaNovo = New System.Windows.Forms.Label()
        Me.txtDataExpiracaoNovo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataExpiracaoNovo = New System.Windows.Forms.Label()
        Me.txtNumeroLicenca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDataExpiracao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataExpiracao = New System.Windows.Forms.Label()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        'tabMain
        '
        Me.tabMain.Location = New System.Drawing.Point(7, 9)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(483, 220)
        Me.tabMain.TabIndex = 2
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.UiGroupBox2)
        Me.pagTabela.Controls.Add(Me.UiGroupBox1)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(481, 197)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Licença"
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.txtNumeroLicencaNovo)
        Me.UiGroupBox2.Controls.Add(Me.lblNumeroLicencaNovo)
        Me.UiGroupBox2.Controls.Add(Me.txtDataExpiracaoNovo)
        Me.UiGroupBox2.Controls.Add(Me.lblDataExpiracaoNovo)
        Me.UiGroupBox2.Controls.Add(Me.txtNumeroLicenca)
        Me.UiGroupBox2.Controls.Add(Me.Label1)
        Me.UiGroupBox2.Controls.Add(Me.txtDataExpiracao)
        Me.UiGroupBox2.Controls.Add(Me.lblDataExpiracao)
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 70)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(465, 64)
        Me.UiGroupBox2.TabIndex = 8
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroLicencaNovo
        '
        Me.txtNumeroLicencaNovo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroLicencaNovo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroLicencaNovo.Location = New System.Drawing.Point(348, 34)
        Me.txtNumeroLicencaNovo.MaxLength = 50
        Me.txtNumeroLicencaNovo.Name = "txtNumeroLicencaNovo"
        Me.txtNumeroLicencaNovo.ReadOnly = True
        Me.txtNumeroLicencaNovo.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroLicencaNovo.TabIndex = 15
        Me.txtNumeroLicencaNovo.TabStop = False
        '
        'lblNumeroLicencaNovo
        '
        Me.lblNumeroLicencaNovo.AutoSize = True
        Me.lblNumeroLicencaNovo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroLicencaNovo.Location = New System.Drawing.Point(345, 17)
        Me.lblNumeroLicencaNovo.Name = "lblNumeroLicencaNovo"
        Me.lblNumeroLicencaNovo.Size = New System.Drawing.Size(96, 14)
        Me.lblNumeroLicencaNovo.TabIndex = 14
        Me.lblNumeroLicencaNovo.Text = "N° Licenças Novo:"
        '
        'txtDataExpiracaoNovo
        '
        Me.txtDataExpiracaoNovo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataExpiracaoNovo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataExpiracaoNovo.Location = New System.Drawing.Point(235, 34)
        Me.txtDataExpiracaoNovo.MaxLength = 50
        Me.txtDataExpiracaoNovo.Name = "txtDataExpiracaoNovo"
        Me.txtDataExpiracaoNovo.ReadOnly = True
        Me.txtDataExpiracaoNovo.Size = New System.Drawing.Size(107, 20)
        Me.txtDataExpiracaoNovo.TabIndex = 13
        Me.txtDataExpiracaoNovo.TabStop = False
        '
        'lblDataExpiracaoNovo
        '
        Me.lblDataExpiracaoNovo.AutoSize = True
        Me.lblDataExpiracaoNovo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataExpiracaoNovo.Location = New System.Drawing.Point(232, 17)
        Me.lblDataExpiracaoNovo.Name = "lblDataExpiracaoNovo"
        Me.lblDataExpiracaoNovo.Size = New System.Drawing.Size(111, 14)
        Me.lblDataExpiracaoNovo.TabIndex = 12
        Me.lblDataExpiracaoNovo.Text = "Data Expiração Novo:"
        '
        'txtNumeroLicenca
        '
        Me.txtNumeroLicenca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroLicenca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroLicenca.Location = New System.Drawing.Point(122, 34)
        Me.txtNumeroLicenca.MaxLength = 50
        Me.txtNumeroLicenca.Name = "txtNumeroLicenca"
        Me.txtNumeroLicenca.ReadOnly = True
        Me.txtNumeroLicenca.Size = New System.Drawing.Size(107, 20)
        Me.txtNumeroLicenca.TabIndex = 11
        Me.txtNumeroLicenca.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(119, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "N° Licenças Atual:"
        '
        'txtDataExpiracao
        '
        Me.txtDataExpiracao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataExpiracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataExpiracao.Location = New System.Drawing.Point(9, 34)
        Me.txtDataExpiracao.MaxLength = 50
        Me.txtDataExpiracao.Name = "txtDataExpiracao"
        Me.txtDataExpiracao.ReadOnly = True
        Me.txtDataExpiracao.Size = New System.Drawing.Size(107, 20)
        Me.txtDataExpiracao.TabIndex = 8
        Me.txtDataExpiracao.TabStop = False
        '
        'lblDataExpiracao
        '
        Me.lblDataExpiracao.AutoSize = True
        Me.lblDataExpiracao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataExpiracao.Location = New System.Drawing.Point(6, 17)
        Me.lblDataExpiracao.Name = "lblDataExpiracao"
        Me.lblDataExpiracao.Size = New System.Drawing.Size(110, 14)
        Me.lblDataExpiracao.TabIndex = 7
        Me.lblDataExpiracao.Text = "Data Expiração Atual:"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnArquivo)
        Me.UiGroupBox1.Controls.Add(Me.txtArquivo)
        Me.UiGroupBox1.Controls.Add(Me.lblArquivo)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(465, 64)
        Me.UiGroupBox1.TabIndex = 7
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnArquivo
        '
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(436, 34)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 9
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtArquivo
        '
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtArquivo.MaxLength = 50
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(428, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 7
        Me.lblArquivo.Text = "Arquivo:"
        '
        'grpControl2
        '
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnConfirmar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 137)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(465, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnConfirmar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmar.Location = New System.Drawing.Point(224, 17)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfirmar.Size = New System.Drawing.Size(135, 23)
        Me.btnConfirmar.TabIndex = 2
        Me.btnConfirmar.Text = "Confirmar Licença"
        Me.btnConfirmar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(365, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmAdmControleLicenca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 236)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdmControleLicenca"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Licença - Interacti"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDataExpiracao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataExpiracao As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtNumeroLicenca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroLicencaNovo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroLicencaNovo As System.Windows.Forms.Label
    Friend WithEvents txtDataExpiracaoNovo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataExpiracaoNovo As System.Windows.Forms.Label
End Class
