<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadParceiroNegocioSociosInativar
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadParceiroNegocioSociosInativar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroRegistro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRegistro = New System.Windows.Forms.Label()
        Me.chkExclusao = New Janus.Windows.EditControls.UICheckBox()
        Me.chkCessaoQuotas = New Janus.Windows.EditControls.UICheckBox()
        Me.chkMorte = New Janus.Windows.EditControls.UICheckBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMotivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
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
        Me.tabMain.Size = New System.Drawing.Size(225, 256)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(223, 233)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Inativação"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 173)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(207, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(10, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Inativar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(107, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtNumeroRegistro)
        Me.grpMotivo.Controls.Add(Me.lblNumeroRegistro)
        Me.grpMotivo.Controls.Add(Me.chkExclusao)
        Me.grpMotivo.Controls.Add(Me.chkCessaoQuotas)
        Me.grpMotivo.Controls.Add(Me.chkMorte)
        Me.grpMotivo.Controls.Add(Me.lblMotivo)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(207, 163)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroRegistro
        '
        Me.txtNumeroRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRegistro.Location = New System.Drawing.Point(9, 126)
        Me.txtNumeroRegistro.MaxLength = 60
        Me.txtNumeroRegistro.Name = "txtNumeroRegistro"
        Me.txtNumeroRegistro.Size = New System.Drawing.Size(189, 20)
        Me.txtNumeroRegistro.TabIndex = 74
        '
        'lblNumeroRegistro
        '
        Me.lblNumeroRegistro.AutoSize = True
        Me.lblNumeroRegistro.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroRegistro.Location = New System.Drawing.Point(6, 109)
        Me.lblNumeroRegistro.Name = "lblNumeroRegistro"
        Me.lblNumeroRegistro.Size = New System.Drawing.Size(165, 14)
        Me.lblNumeroRegistro.TabIndex = 73
        Me.lblNumeroRegistro.Text = "Número do registro da alteração:"
        '
        'chkExclusao
        '
        Me.chkExclusao.Location = New System.Drawing.Point(12, 56)
        Me.chkExclusao.Name = "chkExclusao"
        Me.chkExclusao.Size = New System.Drawing.Size(92, 25)
        Me.chkExclusao.TabIndex = 72
        Me.chkExclusao.Text = "Exclusão"
        '
        'chkCessaoQuotas
        '
        Me.chkCessaoQuotas.Location = New System.Drawing.Point(12, 81)
        Me.chkCessaoQuotas.Name = "chkCessaoQuotas"
        Me.chkCessaoQuotas.Size = New System.Drawing.Size(113, 25)
        Me.chkCessaoQuotas.TabIndex = 71
        Me.chkCessaoQuotas.Text = "Cessão de Quotas"
        '
        'chkMorte
        '
        Me.chkMorte.Location = New System.Drawing.Point(12, 31)
        Me.chkMorte.Name = "chkMorte"
        Me.chkMorte.Size = New System.Drawing.Size(92, 25)
        Me.chkMorte.TabIndex = 70
        Me.chkMorte.Text = "Morte"
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.BackColor = System.Drawing.Color.Transparent
        Me.lblMotivo.Location = New System.Drawing.Point(6, 17)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(41, 14)
        Me.lblMotivo.TabIndex = 3
        Me.lblMotivo.Text = "Motivo:"
        '
        'frmCadParceiroNegocioSociosInativar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 270)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadParceiroNegocioSociosInativar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inativação de Sócios"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMotivo.ResumeLayout(False)
        Me.grpMotivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRegistro As System.Windows.Forms.Label
    Friend WithEvents chkExclusao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkCessaoQuotas As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkMorte As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtNumeroRegistro As Janus.Windows.GridEX.EditControls.MaskedEditBox
End Class
