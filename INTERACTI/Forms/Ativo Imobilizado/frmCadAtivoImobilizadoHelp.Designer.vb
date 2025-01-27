<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadAtivoImobilizadoHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadAtivoImobilizadoHelp))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFormulario = New System.Windows.Forms.Label()
        Me.txtFormulario = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblCampo = New System.Windows.Forms.Label()
        Me.txtCampo = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtHELP = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblHELP = New System.Windows.Forms.Label()
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
        Me.tabMain.Size = New System.Drawing.Size(815, 463)
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
        Me.pagTabela.Size = New System.Drawing.Size(813, 440)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Informações Adicionais"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 380)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(797, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Location = New System.Drawing.Point(600, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(697, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.lblFormulario)
        Me.grpMotivo.Controls.Add(Me.txtFormulario)
        Me.grpMotivo.Controls.Add(Me.lblCampo)
        Me.grpMotivo.Controls.Add(Me.txtCampo)
        Me.grpMotivo.Controls.Add(Me.txtHELP)
        Me.grpMotivo.Controls.Add(Me.lblHELP)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(797, 374)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'lblFormulario
        '
        Me.lblFormulario.AutoSize = True
        Me.lblFormulario.BackColor = System.Drawing.Color.Transparent
        Me.lblFormulario.Location = New System.Drawing.Point(6, 17)
        Me.lblFormulario.Name = "lblFormulario"
        Me.lblFormulario.Size = New System.Drawing.Size(60, 14)
        Me.lblFormulario.TabIndex = 5
        Me.lblFormulario.Text = "Formulário:"
        '
        'txtFormulario
        '
        Me.txtFormulario.BackColor = System.Drawing.SystemColors.Info
        Me.txtFormulario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFormulario.Location = New System.Drawing.Point(9, 34)
        Me.txtFormulario.MaxLength = 0
        Me.txtFormulario.Name = "txtFormulario"
        Me.txtFormulario.ReadOnly = True
        Me.txtFormulario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFormulario.Size = New System.Drawing.Size(442, 20)
        Me.txtFormulario.TabIndex = 4
        Me.txtFormulario.TabStop = False
        '
        'lblCampo
        '
        Me.lblCampo.AutoSize = True
        Me.lblCampo.BackColor = System.Drawing.Color.Transparent
        Me.lblCampo.Location = New System.Drawing.Point(454, 17)
        Me.lblCampo.Name = "lblCampo"
        Me.lblCampo.Size = New System.Drawing.Size(43, 14)
        Me.lblCampo.TabIndex = 3
        Me.lblCampo.Text = "Campo:"
        '
        'txtCampo
        '
        Me.txtCampo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCampo.BackColor = System.Drawing.SystemColors.Info
        Me.txtCampo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCampo.Location = New System.Drawing.Point(457, 34)
        Me.txtCampo.MaxLength = 0
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.ReadOnly = True
        Me.txtCampo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCampo.Size = New System.Drawing.Size(331, 20)
        Me.txtCampo.TabIndex = 2
        Me.txtCampo.TabStop = False
        '
        'txtHELP
        '
        Me.txtHELP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHELP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHELP.Location = New System.Drawing.Point(9, 74)
        Me.txtHELP.MaxLength = 0
        Me.txtHELP.Multiline = True
        Me.txtHELP.Name = "txtHELP"
        Me.txtHELP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHELP.Size = New System.Drawing.Size(779, 290)
        Me.txtHELP.TabIndex = 1
        '
        'lblHELP
        '
        Me.lblHELP.AutoSize = True
        Me.lblHELP.BackColor = System.Drawing.Color.Transparent
        Me.lblHELP.Location = New System.Drawing.Point(6, 57)
        Me.lblHELP.Name = "lblHELP"
        Me.lblHELP.Size = New System.Drawing.Size(35, 14)
        Me.lblHELP.TabIndex = 0
        Me.lblHELP.Text = "HELP:"
        '
        'frmCadAtivoImobilizadoHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 477)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadAtivoImobilizadoHelp"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Ativo Imobilizado - HELP"
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
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblHELP As System.Windows.Forms.Label
    Friend WithEvents txtHELP As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblCampo As System.Windows.Forms.Label
    Friend WithEvents txtCampo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFormulario As System.Windows.Forms.Label
    Friend WithEvents txtFormulario As Janus.Windows.GridEX.EditControls.EditBox
End Class
