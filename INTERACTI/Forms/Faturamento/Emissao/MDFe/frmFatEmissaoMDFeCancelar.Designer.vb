<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoMDFeCancelar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoMDFeCancelar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtChaveAcesso = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblChaveAcesso = New System.Windows.Forms.Label()
        Me.txtModelo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.dtpDataEmissao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.txtProtocolo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProtocolo = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblJustificativa = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
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
        Me.pagTabela.Text = "Justificativa do Cancelamento"
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtChaveAcesso)
        Me.grpMotivo.Controls.Add(Me.lblChaveAcesso)
        Me.grpMotivo.Controls.Add(Me.txtModelo)
        Me.grpMotivo.Controls.Add(Me.lblModelo)
        Me.grpMotivo.Controls.Add(Me.dtpDataEmissao)
        Me.grpMotivo.Controls.Add(Me.txtSerie)
        Me.grpMotivo.Controls.Add(Me.lblSerie)
        Me.grpMotivo.Controls.Add(Me.lblDataEmissao)
        Me.grpMotivo.Controls.Add(Me.txtProtocolo)
        Me.grpMotivo.Controls.Add(Me.lblProtocolo)
        Me.grpMotivo.Controls.Add(Me.txtNumeroDocumento)
        Me.grpMotivo.Controls.Add(Me.lblNumeroDocumento)
        Me.grpMotivo.Controls.Add(Me.txtJustificativa)
        Me.grpMotivo.Controls.Add(Me.lblJustificativa)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(753, 349)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados do Manifesto Eletrônico"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtChaveAcesso
        '
        Me.txtChaveAcesso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtChaveAcesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChaveAcesso.Location = New System.Drawing.Point(363, 37)
        Me.txtChaveAcesso.MaxLength = 250
        Me.txtChaveAcesso.Name = "txtChaveAcesso"
        Me.txtChaveAcesso.Size = New System.Drawing.Size(226, 20)
        Me.txtChaveAcesso.TabIndex = 16
        Me.txtChaveAcesso.TabStop = False
        '
        'lblChaveAcesso
        '
        Me.lblChaveAcesso.AutoSize = True
        Me.lblChaveAcesso.Location = New System.Drawing.Point(360, 20)
        Me.lblChaveAcesso.Name = "lblChaveAcesso"
        Me.lblChaveAcesso.Size = New System.Drawing.Size(81, 14)
        Me.lblChaveAcesso.TabIndex = 15
        Me.lblChaveAcesso.Text = "Chave Acesso:"
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtModelo.DecimalDigits = 0
        Me.txtModelo.Enabled = False
        Me.txtModelo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtModelo.Location = New System.Drawing.Point(160, 38)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(58, 20)
        Me.txtModelo.TabIndex = 14
        Me.txtModelo.TabStop = False
        Me.txtModelo.Text = "0"
        Me.txtModelo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BackColor = System.Drawing.Color.Transparent
        Me.lblModelo.Location = New System.Drawing.Point(157, 21)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(44, 14)
        Me.lblModelo.TabIndex = 13
        Me.lblModelo.Text = "Modelo:"
        '
        'dtpDataEmissao
        '
        Me.dtpDataEmissao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDataEmissao.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpDataEmissao.DropDownCalendar.Name = ""
        Me.dtpDataEmissao.Location = New System.Drawing.Point(595, 37)
        Me.dtpDataEmissao.Name = "dtpDataEmissao"
        Me.dtpDataEmissao.ShowCheckBox = True
        Me.dtpDataEmissao.Size = New System.Drawing.Size(149, 20)
        Me.dtpDataEmissao.TabIndex = 12
        Me.dtpDataEmissao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(113, 38)
        Me.txtSerie.MaxLength = 250
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(41, 20)
        Me.txtSerie.TabIndex = 7
        Me.txtSerie.TabStop = False
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(110, 21)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 6
        Me.lblSerie.Text = "Série:"
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(592, 20)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 8
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'txtProtocolo
        '
        Me.txtProtocolo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProtocolo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProtocolo.Location = New System.Drawing.Point(224, 37)
        Me.txtProtocolo.MaxLength = 250
        Me.txtProtocolo.Name = "txtProtocolo"
        Me.txtProtocolo.Size = New System.Drawing.Size(133, 20)
        Me.txtProtocolo.TabIndex = 5
        Me.txtProtocolo.TabStop = False
        '
        'lblProtocolo
        '
        Me.lblProtocolo.AutoSize = True
        Me.lblProtocolo.Location = New System.Drawing.Point(221, 20)
        Me.lblProtocolo.Name = "lblProtocolo"
        Me.lblProtocolo.Size = New System.Drawing.Size(55, 14)
        Me.lblProtocolo.TabIndex = 4
        Me.lblProtocolo.Text = "Protocolo:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 37)
        Me.txtNumeroDocumento.MaxLength = 250
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(98, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 20)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "N° Documento:"
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(9, 77)
        Me.txtJustificativa.MaxLength = 255
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(735, 262)
        Me.txtJustificativa.TabIndex = 11
        '
        'lblJustificativa
        '
        Me.lblJustificativa.AutoSize = True
        Me.lblJustificativa.BackColor = System.Drawing.Color.Transparent
        Me.lblJustificativa.Location = New System.Drawing.Point(6, 60)
        Me.lblJustificativa.Name = "lblJustificativa"
        Me.lblJustificativa.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativa.TabIndex = 10
        Me.lblJustificativa.Text = "Justificativa:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnCancelar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 355)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(753, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(556, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(653, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEmissaoMDFeCancelar
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
        Me.Name = "frmFatEmissaoMDFeCancelar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cancelar Manifesto Eletrônica"
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
    Private WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblJustificativa As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtProtocolo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProtocolo As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtModelo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents txtChaveAcesso As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblChaveAcesso As System.Windows.Forms.Label
End Class
