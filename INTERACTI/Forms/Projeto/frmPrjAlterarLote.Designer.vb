<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrjAlterarLote
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
        Dim JanusColorScheme3 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrjAlterarLote))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkDataResposta = New Janus.Windows.EditControls.UICheckBox()
        Me.dtpDataResposta = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.chkDataPrevisao = New Janus.Windows.EditControls.UICheckBox()
        Me.dtpDataPrevisao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.chkDataExecucao = New Janus.Windows.EditControls.UICheckBox()
        Me.dtpDataExecucao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboEtapa = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkObservacao = New Janus.Windows.EditControls.UICheckBox()
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
        JanusColorScheme3.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme3.Name = "Scheme"
        JanusColorScheme3.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme3.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme3.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme3)
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
        Me.tabMain.Size = New System.Drawing.Size(662, 208)
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
        Me.pagTabela.Size = New System.Drawing.Size(660, 185)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados"
        '
        'grpMotivo
        '
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.chkObservacao)
        Me.grpMotivo.Controls.Add(Me.txtObservacao)
        Me.grpMotivo.Controls.Add(Me.chkDataResposta)
        Me.grpMotivo.Controls.Add(Me.dtpDataResposta)
        Me.grpMotivo.Controls.Add(Me.chkDataPrevisao)
        Me.grpMotivo.Controls.Add(Me.dtpDataPrevisao)
        Me.grpMotivo.Controls.Add(Me.chkDataExecucao)
        Me.grpMotivo.Controls.Add(Me.dtpDataExecucao)
        Me.grpMotivo.Controls.Add(Me.cboEtapa)
        Me.grpMotivo.Controls.Add(Me.lblEtapa)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(646, 114)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Etapa para alterar"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'chkDataResposta
        '
        Me.chkDataResposta.Location = New System.Drawing.Point(525, 15)
        Me.chkDataResposta.Name = "chkDataResposta"
        Me.chkDataResposta.Size = New System.Drawing.Size(93, 17)
        Me.chkDataResposta.TabIndex = 6
        Me.chkDataResposta.Text = "Data Resposta:"
        '
        'dtpDataResposta
        '
        '
        '
        '
        Me.dtpDataResposta.DropDownCalendar.Name = ""
        Me.dtpDataResposta.Location = New System.Drawing.Point(523, 34)
        Me.dtpDataResposta.Name = "dtpDataResposta"
        Me.dtpDataResposta.ShowCheckBox = True
        Me.dtpDataResposta.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataResposta.TabIndex = 7
        Me.dtpDataResposta.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'chkDataPrevisao
        '
        Me.chkDataPrevisao.Location = New System.Drawing.Point(411, 15)
        Me.chkDataPrevisao.Name = "chkDataPrevisao"
        Me.chkDataPrevisao.Size = New System.Drawing.Size(93, 17)
        Me.chkDataPrevisao.TabIndex = 4
        Me.chkDataPrevisao.Text = "Data Previsão:"
        '
        'dtpDataPrevisao
        '
        '
        '
        '
        Me.dtpDataPrevisao.DropDownCalendar.Name = ""
        Me.dtpDataPrevisao.Location = New System.Drawing.Point(409, 34)
        Me.dtpDataPrevisao.Name = "dtpDataPrevisao"
        Me.dtpDataPrevisao.ShowCheckBox = True
        Me.dtpDataPrevisao.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisao.TabIndex = 5
        Me.dtpDataPrevisao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'chkDataExecucao
        '
        Me.chkDataExecucao.Location = New System.Drawing.Point(297, 15)
        Me.chkDataExecucao.Name = "chkDataExecucao"
        Me.chkDataExecucao.Size = New System.Drawing.Size(93, 17)
        Me.chkDataExecucao.TabIndex = 2
        Me.chkDataExecucao.Text = "Data Execução:"
        '
        'dtpDataExecucao
        '
        '
        '
        '
        Me.dtpDataExecucao.DropDownCalendar.Name = ""
        Me.dtpDataExecucao.Location = New System.Drawing.Point(295, 34)
        Me.dtpDataExecucao.Name = "dtpDataExecucao"
        Me.dtpDataExecucao.ShowCheckBox = True
        Me.dtpDataExecucao.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataExecucao.TabIndex = 3
        Me.dtpDataExecucao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'cboEtapa
        '
        Me.cboEtapa.AutoSize = False
        Me.cboEtapa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEtapa.Location = New System.Drawing.Point(9, 33)
        Me.cboEtapa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboEtapa.Name = "cboEtapa"
        Me.cboEtapa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEtapa.Size = New System.Drawing.Size(281, 20)
        Me.cboEtapa.TabIndex = 1
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Location = New System.Drawing.Point(6, 17)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(37, 14)
        Me.lblEtapa.TabIndex = 0
        Me.lblEtapa.Text = "Etapa:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 125)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(644, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Location = New System.Drawing.Point(429, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(100, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(535, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(100, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtObservacao
        '
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(9, 80)
        Me.txtObservacao.MaxLength = 20
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(622, 20)
        Me.txtObservacao.TabIndex = 21
        '
        'chkObservacao
        '
        Me.chkObservacao.Location = New System.Drawing.Point(9, 60)
        Me.chkObservacao.Name = "chkObservacao"
        Me.chkObservacao.Size = New System.Drawing.Size(93, 17)
        Me.chkObservacao.TabIndex = 22
        Me.chkObservacao.Text = "Observação:"
        '
        'frmPrjAlterarLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 222)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrjAlterarLote"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alteração em Lote"
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
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblEtapa As System.Windows.Forms.Label
    Friend WithEvents cboEtapa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataExecucao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents chkDataExecucao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkDataResposta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents dtpDataResposta As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents chkDataPrevisao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents dtpDataPrevisao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkObservacao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
End Class
