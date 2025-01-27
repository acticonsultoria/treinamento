<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdCenarioManutencao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdCenarioManutencao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDuracao = New System.Windows.Forms.Label()
        Me.txtDuracao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.cboMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblMaquina = New System.Windows.Forms.Label()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(4, 125)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(525, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(328, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(425, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblDuracao)
        Me.grpDados.Controls.Add(Me.txtDuracao)
        Me.grpDados.Controls.Add(Me.txtObservacao)
        Me.grpDados.Controls.Add(Me.lblObservacao)
        Me.grpDados.Controls.Add(Me.cboMaquina)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.dtpData)
        Me.grpDados.Controls.Add(Me.lblMaquina)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(4, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(525, 116)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblDuracao
        '
        Me.lblDuracao.AutoSize = True
        Me.lblDuracao.Location = New System.Drawing.Point(422, 17)
        Me.lblDuracao.Name = "lblDuracao"
        Me.lblDuracao.Size = New System.Drawing.Size(91, 14)
        Me.lblDuracao.TabIndex = 33
        Me.lblDuracao.Text = "Duração (Horas):"
        '
        'txtDuracao
        '
        Me.txtDuracao.DecimalDigits = 0
        Me.txtDuracao.Location = New System.Drawing.Point(425, 34)
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.Size = New System.Drawing.Size(94, 20)
        Me.txtDuracao.TabIndex = 3
        Me.txtDuracao.Text = "0"
        Me.txtDuracao.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(9, 80)
        Me.txtObservacao.MaxLength = 500
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(510, 20)
        Me.txtObservacao.TabIndex = 4
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 63)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 31
        Me.lblObservacao.Text = "Observação:"
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoSize = False
        Me.cboMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMaquina.Location = New System.Drawing.Point(9, 34)
        Me.cboMaquina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaquina.Size = New System.Drawing.Size(267, 20)
        Me.cboMaquina.TabIndex = 1
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.Location = New System.Drawing.Point(279, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(59, 14)
        Me.lblData.TabIndex = 28
        Me.lblData.Text = "Data Início:"
        '
        'dtpData
        '
        Me.dtpData.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(282, 34)
        Me.dtpData.MinuteIncrement = 1
        Me.dtpData.Name = "dtpData"
        Me.dtpData.SecondIncrement = 1
        Me.dtpData.Size = New System.Drawing.Size(137, 20)
        Me.dtpData.TabIndex = 2
        Me.dtpData.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.Location = New System.Drawing.Point(6, 17)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(50, 14)
        Me.lblMaquina.TabIndex = 0
        Me.lblMaquina.Text = "Máquina:"
        '
        'frmPrdCenarioManutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 182)
        Me.Controls.Add(Me.grpDados)
        Me.Controls.Add(Me.grpControl2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrdCenarioManutencao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inserir Manutenção"
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblMaquina As System.Windows.Forms.Label
    Friend WithEvents cboMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents lblDuracao As System.Windows.Forms.Label
    Friend WithEvents txtDuracao As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
