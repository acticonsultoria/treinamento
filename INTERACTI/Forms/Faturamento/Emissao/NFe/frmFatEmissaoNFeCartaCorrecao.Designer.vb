<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFeCartaCorrecao
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
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFeCartaCorrecao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtNumeroSequencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroSequencia = New System.Windows.Forms.Label()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.txtProtocolo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProtocolo = New System.Windows.Forms.Label()
        Me.txtChaveAcesso = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblChaveAcesso = New System.Windows.Forms.Label()
        Me.txtCartaCorrecao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblCartaCorrecao = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnTransmitirCartaCorrecaoEmail = New Janus.Windows.EditControls.UIButton()
        Me.btnTransmitirCartaCorrecao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMotivo.SuspendLayout()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(771, 438)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(769, 415)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Carta de Correção"
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtEmail)
        Me.grpMotivo.Controls.Add(Me.lblEmail)
        Me.grpMotivo.Controls.Add(Me.txtNumeroSequencia)
        Me.grpMotivo.Controls.Add(Me.lblNumeroSequencia)
        Me.grpMotivo.Controls.Add(Me.txtSerie)
        Me.grpMotivo.Controls.Add(Me.lblSerie)
        Me.grpMotivo.Controls.Add(Me.txtDataEmissao)
        Me.grpMotivo.Controls.Add(Me.lblDataEmissao)
        Me.grpMotivo.Controls.Add(Me.txtNotaFiscal)
        Me.grpMotivo.Controls.Add(Me.lblNotaFiscal)
        Me.grpMotivo.Controls.Add(Me.txtProtocolo)
        Me.grpMotivo.Controls.Add(Me.lblProtocolo)
        Me.grpMotivo.Controls.Add(Me.txtChaveAcesso)
        Me.grpMotivo.Controls.Add(Me.lblChaveAcesso)
        Me.grpMotivo.Controls.Add(Me.txtCartaCorrecao)
        Me.grpMotivo.Controls.Add(Me.lblCartaCorrecao)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(753, 349)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados da Nota Fiscal"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(9, 117)
        Me.txtEmail.MaxLength = 250
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(735, 20)
        Me.txtEmail.TabIndex = 13
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 100)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 14)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "E-mail:"
        '
        'txtNumeroSequencia
        '
        Me.txtNumeroSequencia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroSequencia.DecimalDigits = 0
        Me.txtNumeroSequencia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroSequencia.Location = New System.Drawing.Point(652, 77)
        Me.txtNumeroSequencia.Name = "txtNumeroSequencia"
        Me.txtNumeroSequencia.ReadOnly = True
        Me.txtNumeroSequencia.Size = New System.Drawing.Size(92, 20)
        Me.txtNumeroSequencia.TabIndex = 11
        Me.txtNumeroSequencia.TabStop = False
        Me.txtNumeroSequencia.Text = "0"
        Me.txtNumeroSequencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNumeroSequencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroSequencia
        '
        Me.lblNumeroSequencia.AutoSize = True
        Me.lblNumeroSequencia.Location = New System.Drawing.Point(649, 60)
        Me.lblNumeroSequencia.Name = "lblNumeroSequencia"
        Me.lblNumeroSequencia.Size = New System.Drawing.Size(76, 14)
        Me.lblNumeroSequencia.TabIndex = 10
        Me.lblNumeroSequencia.Text = "Nº Sequência:"
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(469, 77)
        Me.txtSerie.MaxLength = 250
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(41, 20)
        Me.txtSerie.TabIndex = 7
        Me.txtSerie.TabStop = False
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(465, 60)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 6
        Me.lblSerie.Text = "Série:"
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Location = New System.Drawing.Point(516, 77)
        Me.txtDataEmissao.MaxLength = 250
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.ReadOnly = True
        Me.txtDataEmissao.Size = New System.Drawing.Size(130, 20)
        Me.txtDataEmissao.TabIndex = 9
        Me.txtDataEmissao.TabStop = False
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(513, 60)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 8
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Location = New System.Drawing.Point(366, 77)
        Me.txtNotaFiscal.MaxLength = 250
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.ReadOnly = True
        Me.txtNotaFiscal.Size = New System.Drawing.Size(97, 20)
        Me.txtNotaFiscal.TabIndex = 5
        Me.txtNotaFiscal.TabStop = False
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(362, 60)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscal.TabIndex = 4
        Me.lblNotaFiscal.Text = "Nota Fiscal:"
        '
        'txtProtocolo
        '
        Me.txtProtocolo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProtocolo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProtocolo.Location = New System.Drawing.Point(9, 77)
        Me.txtProtocolo.MaxLength = 250
        Me.txtProtocolo.Name = "txtProtocolo"
        Me.txtProtocolo.ReadOnly = True
        Me.txtProtocolo.Size = New System.Drawing.Size(351, 20)
        Me.txtProtocolo.TabIndex = 3
        Me.txtProtocolo.TabStop = False
        '
        'lblProtocolo
        '
        Me.lblProtocolo.AutoSize = True
        Me.lblProtocolo.Location = New System.Drawing.Point(6, 60)
        Me.lblProtocolo.Name = "lblProtocolo"
        Me.lblProtocolo.Size = New System.Drawing.Size(55, 14)
        Me.lblProtocolo.TabIndex = 2
        Me.lblProtocolo.Text = "Protocolo:"
        '
        'txtChaveAcesso
        '
        Me.txtChaveAcesso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtChaveAcesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChaveAcesso.Location = New System.Drawing.Point(9, 37)
        Me.txtChaveAcesso.MaxLength = 250
        Me.txtChaveAcesso.Name = "txtChaveAcesso"
        Me.txtChaveAcesso.ReadOnly = True
        Me.txtChaveAcesso.Size = New System.Drawing.Size(454, 20)
        Me.txtChaveAcesso.TabIndex = 1
        Me.txtChaveAcesso.TabStop = False
        '
        'lblChaveAcesso
        '
        Me.lblChaveAcesso.AutoSize = True
        Me.lblChaveAcesso.Location = New System.Drawing.Point(6, 20)
        Me.lblChaveAcesso.Name = "lblChaveAcesso"
        Me.lblChaveAcesso.Size = New System.Drawing.Size(96, 14)
        Me.lblChaveAcesso.TabIndex = 0
        Me.lblChaveAcesso.Text = "Chave de Acesso:"
        '
        'txtCartaCorrecao
        '
        Me.txtCartaCorrecao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCartaCorrecao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCartaCorrecao.Location = New System.Drawing.Point(9, 159)
        Me.txtCartaCorrecao.MaxLength = 500
        Me.txtCartaCorrecao.Multiline = True
        Me.txtCartaCorrecao.Name = "txtCartaCorrecao"
        Me.txtCartaCorrecao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCartaCorrecao.Size = New System.Drawing.Size(735, 181)
        SuperTipSettings1.HeaderText = "Condições de Uso da Carta de Correção"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = resources.GetString("SuperTipSettings1.Text")
        Me.jstMain.SetSuperTip(Me.txtCartaCorrecao, SuperTipSettings1)
        Me.txtCartaCorrecao.TabIndex = 15
        '
        'lblCartaCorrecao
        '
        Me.lblCartaCorrecao.AutoSize = True
        Me.lblCartaCorrecao.BackColor = System.Drawing.Color.Transparent
        Me.lblCartaCorrecao.Location = New System.Drawing.Point(6, 142)
        Me.lblCartaCorrecao.Name = "lblCartaCorrecao"
        Me.lblCartaCorrecao.Size = New System.Drawing.Size(143, 14)
        Me.lblCartaCorrecao.TabIndex = 14
        Me.lblCartaCorrecao.Text = "Texto da Carta de Correção:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnTransmitirCartaCorrecaoEmail)
        Me.grpControl2.Controls.Add(Me.btnTransmitirCartaCorrecao)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 355)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(753, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnTransmitirCartaCorrecaoEmail
        '
        Me.btnTransmitirCartaCorrecaoEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransmitirCartaCorrecaoEmail.Image = Global.INTERACTI.My.Resources.Resources.upload
        Me.btnTransmitirCartaCorrecaoEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnTransmitirCartaCorrecaoEmail.Location = New System.Drawing.Point(295, 17)
        Me.btnTransmitirCartaCorrecaoEmail.Name = "btnTransmitirCartaCorrecaoEmail"
        Me.btnTransmitirCartaCorrecaoEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnTransmitirCartaCorrecaoEmail.Size = New System.Drawing.Size(350, 23)
        Me.btnTransmitirCartaCorrecaoEmail.TabIndex = 1
        Me.btnTransmitirCartaCorrecaoEmail.Text = "Transmitir Carta de Correção e Enviar E-mail para o Destinatário"
        Me.btnTransmitirCartaCorrecaoEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnTransmitirCartaCorrecao
        '
        Me.btnTransmitirCartaCorrecao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransmitirCartaCorrecao.Image = Global.INTERACTI.My.Resources.Resources.upload
        Me.btnTransmitirCartaCorrecao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnTransmitirCartaCorrecao.Location = New System.Drawing.Point(89, 17)
        Me.btnTransmitirCartaCorrecao.Name = "btnTransmitirCartaCorrecao"
        Me.btnTransmitirCartaCorrecao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnTransmitirCartaCorrecao.Size = New System.Drawing.Size(200, 23)
        Me.btnTransmitirCartaCorrecao.TabIndex = 0
        Me.btnTransmitirCartaCorrecao.Text = "Transmitir Carta de Correção"
        Me.btnTransmitirCartaCorrecao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(653, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 100
        Me.jstMain.ImageList = Nothing
        Me.jstMain.InitialDelay = 100
        '
        'frmFatEmissaoNFeCartaCorrecao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 453)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFeCartaCorrecao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Carta de Correção Eletrônica"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMotivo.ResumeLayout(False)
        Me.grpMotivo.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnTransmitirCartaCorrecao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCartaCorrecao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblCartaCorrecao As System.Windows.Forms.Label
    Friend WithEvents txtProtocolo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProtocolo As System.Windows.Forms.Label
    Friend WithEvents txtChaveAcesso As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblChaveAcesso As System.Windows.Forms.Label
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtNumeroSequencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroSequencia As System.Windows.Forms.Label
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Private WithEvents btnTransmitirCartaCorrecaoEmail As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
End Class
