<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEntradaNFeDestinadaRecusa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEntradaNFeDestinadaRecusa))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtSequencia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSequencia = New System.Windows.Forms.Label()
        Me.txtChaveAcesso = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblChaveAcesso = New System.Windows.Forms.Label()
        Me.txtEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmitente = New System.Windows.Forms.Label()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblJustificativa = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtTipoEvento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoEvento = New System.Windows.Forms.Label()
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
        Me.tabMain.Size = New System.Drawing.Size(857, 406)
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
        Me.pagTabela.Size = New System.Drawing.Size(855, 383)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Justificativa da Recusa"
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtTipoEvento)
        Me.grpMotivo.Controls.Add(Me.lblTipoEvento)
        Me.grpMotivo.Controls.Add(Me.txtSequencia)
        Me.grpMotivo.Controls.Add(Me.lblSequencia)
        Me.grpMotivo.Controls.Add(Me.txtChaveAcesso)
        Me.grpMotivo.Controls.Add(Me.lblChaveAcesso)
        Me.grpMotivo.Controls.Add(Me.txtEmitente)
        Me.grpMotivo.Controls.Add(Me.lblEmitente)
        Me.grpMotivo.Controls.Add(Me.txtDataEmissao)
        Me.grpMotivo.Controls.Add(Me.lblDataEmissao)
        Me.grpMotivo.Controls.Add(Me.txtNotaFiscal)
        Me.grpMotivo.Controls.Add(Me.lblNotaFiscal)
        Me.grpMotivo.Controls.Add(Me.txtJustificativa)
        Me.grpMotivo.Controls.Add(Me.lblJustificativa)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(839, 317)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados da Nota Fiscal"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtSequencia
        '
        Me.txtSequencia.BackColor = System.Drawing.Color.White
        Me.txtSequencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSequencia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtSequencia.Location = New System.Drawing.Point(711, 34)
        Me.txtSequencia.MaxLength = 250
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.Size = New System.Drawing.Size(118, 20)
        Me.txtSequencia.TabIndex = 15
        Me.txtSequencia.TabStop = False
        Me.txtSequencia.Text = "1"
        Me.txtSequencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblSequencia
        '
        Me.lblSequencia.AutoSize = True
        Me.lblSequencia.Location = New System.Drawing.Point(708, 17)
        Me.lblSequencia.Name = "lblSequencia"
        Me.lblSequencia.Size = New System.Drawing.Size(61, 14)
        Me.lblSequencia.TabIndex = 14
        Me.lblSequencia.Text = "Sequência:"
        '
        'txtChaveAcesso
        '
        Me.txtChaveAcesso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtChaveAcesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChaveAcesso.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtChaveAcesso.Location = New System.Drawing.Point(340, 34)
        Me.txtChaveAcesso.MaxLength = 250
        Me.txtChaveAcesso.Name = "txtChaveAcesso"
        Me.txtChaveAcesso.Size = New System.Drawing.Size(214, 20)
        Me.txtChaveAcesso.TabIndex = 11
        Me.txtChaveAcesso.TabStop = False
        '
        'lblChaveAcesso
        '
        Me.lblChaveAcesso.AutoSize = True
        Me.lblChaveAcesso.Location = New System.Drawing.Point(337, 17)
        Me.lblChaveAcesso.Name = "lblChaveAcesso"
        Me.lblChaveAcesso.Size = New System.Drawing.Size(96, 14)
        Me.lblChaveAcesso.TabIndex = 10
        Me.lblChaveAcesso.Tag = ""
        Me.lblChaveAcesso.Text = "Chave de Acesso:"
        '
        'txtEmitente
        '
        Me.txtEmitente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEmitente.Location = New System.Drawing.Point(189, 34)
        Me.txtEmitente.MaxLength = 250
        Me.txtEmitente.Name = "txtEmitente"
        Me.txtEmitente.Size = New System.Drawing.Size(145, 20)
        Me.txtEmitente.TabIndex = 9
        Me.txtEmitente.TabStop = False
        '
        'lblEmitente
        '
        Me.lblEmitente.AutoSize = True
        Me.lblEmitente.Location = New System.Drawing.Point(186, 17)
        Me.lblEmitente.Name = "lblEmitente"
        Me.lblEmitente.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitente.TabIndex = 8
        Me.lblEmitente.Text = "Emitente:"
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDataEmissao.Location = New System.Drawing.Point(92, 34)
        Me.txtDataEmissao.MaxLength = 250
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.Size = New System.Drawing.Size(91, 20)
        Me.txtDataEmissao.TabIndex = 5
        Me.txtDataEmissao.TabStop = False
        Me.txtDataEmissao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(89, 17)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 4
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNotaFiscal.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscal.MaxLength = 250
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(77, 20)
        Me.txtNotaFiscal.TabIndex = 1
        Me.txtNotaFiscal.TabStop = False
        Me.txtNotaFiscal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(5, 17)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscal.TabIndex = 0
        Me.lblNotaFiscal.Text = "Nota Fiscal:"
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(9, 74)
        Me.txtJustificativa.MaxLength = 255
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(822, 233)
        Me.txtJustificativa.TabIndex = 12
        '
        'lblJustificativa
        '
        Me.lblJustificativa.AutoSize = True
        Me.lblJustificativa.BackColor = System.Drawing.Color.Transparent
        Me.lblJustificativa.Location = New System.Drawing.Point(6, 57)
        Me.lblJustificativa.Name = "lblJustificativa"
        Me.lblJustificativa.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativa.TabIndex = 13
        Me.lblJustificativa.Text = "Justificativa:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnCancelar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 323)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(839, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(583, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(150, 23)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Recusar Nota Fiscal"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(740, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtTipoEvento
        '
        Me.txtTipoEvento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipoEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoEvento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTipoEvento.Location = New System.Drawing.Point(560, 34)
        Me.txtTipoEvento.MaxLength = 250
        Me.txtTipoEvento.Name = "txtTipoEvento"
        Me.txtTipoEvento.Size = New System.Drawing.Size(145, 20)
        Me.txtTipoEvento.TabIndex = 17
        Me.txtTipoEvento.TabStop = False
        '
        'lblTipoEvento
        '
        Me.lblTipoEvento.AutoSize = True
        Me.lblTipoEvento.Location = New System.Drawing.Point(557, 17)
        Me.lblTipoEvento.Name = "lblTipoEvento"
        Me.lblTipoEvento.Size = New System.Drawing.Size(66, 14)
        Me.lblTipoEvento.TabIndex = 16
        Me.lblTipoEvento.Text = "Tipo Evento:"
        '
        'frmFatEntradaNFeDestinadaRecusa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEntradaNFeDestinadaRecusa"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recusar /Nota Fiscal de Entrada"
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
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEmitente As System.Windows.Forms.Label
    Friend WithEvents txtChaveAcesso As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblChaveAcesso As System.Windows.Forms.Label
    Friend WithEvents txtSequencia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSequencia As System.Windows.Forms.Label
    Friend WithEvents txtTipoEvento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoEvento As System.Windows.Forms.Label
End Class
