<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpECF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpECF))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCupomFiscal = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNCM = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNCM = New System.Windows.Forms.Label()
        Me.cboAliquotaICMS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAliquotaICMS = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpCupomFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCupomFiscal.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(417, 155)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpCupomFiscal)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(415, 132)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Regra de Imposto"
        '
        'grpCupomFiscal
        '
        Me.grpCupomFiscal.BackColor = System.Drawing.Color.Transparent
        Me.grpCupomFiscal.Controls.Add(Me.txtNCM)
        Me.grpCupomFiscal.Controls.Add(Me.lblNCM)
        Me.grpCupomFiscal.Controls.Add(Me.cboAliquotaICMS)
        Me.grpCupomFiscal.Controls.Add(Me.lblAliquotaICMS)
        Me.grpCupomFiscal.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCupomFiscal.Location = New System.Drawing.Point(8, 3)
        Me.grpCupomFiscal.Name = "grpCupomFiscal"
        Me.grpCupomFiscal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCupomFiscal.Size = New System.Drawing.Size(399, 67)
        Me.grpCupomFiscal.TabIndex = 7
        Me.grpCupomFiscal.Text = "Dados para Emissão de Cupom Fiscal"
        Me.grpCupomFiscal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpCupomFiscal.VisualStyleManager = Me.vsmMain
        '
        'txtNCM
        '
        Me.txtNCM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCM.Location = New System.Drawing.Point(9, 37)
        Me.txtNCM.MaxLength = 15
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.ReadOnly = True
        Me.txtNCM.Size = New System.Drawing.Size(100, 20)
        Me.txtNCM.TabIndex = 3
        Me.txtNCM.TabStop = False
        '
        'lblNCM
        '
        Me.lblNCM.AutoSize = True
        Me.lblNCM.Location = New System.Drawing.Point(6, 20)
        Me.lblNCM.Name = "lblNCM"
        Me.lblNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblNCM.TabIndex = 2
        Me.lblNCM.Text = "NCM:"
        '
        'cboAliquotaICMS
        '
        Me.cboAliquotaICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAliquotaICMS.AutoSize = False
        Me.cboAliquotaICMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAliquotaICMS.Location = New System.Drawing.Point(115, 37)
        Me.cboAliquotaICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAliquotaICMS.Name = "cboAliquotaICMS"
        Me.cboAliquotaICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAliquotaICMS.Size = New System.Drawing.Size(275, 20)
        Me.cboAliquotaICMS.TabIndex = 1
        '
        'lblAliquotaICMS
        '
        Me.lblAliquotaICMS.AutoSize = True
        Me.lblAliquotaICMS.Location = New System.Drawing.Point(112, 20)
        Me.lblAliquotaICMS.Name = "lblAliquotaICMS"
        Me.lblAliquotaICMS.Size = New System.Drawing.Size(76, 14)
        Me.lblAliquotaICMS.TabIndex = 0
        Me.lblAliquotaICMS.Text = "Alíquota ICMS:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 73)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(399, 51)
        Me.grpControl2.TabIndex = 6
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(299, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(202, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmImpECF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 170)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImpECF"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Imposto - ECF"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpCupomFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCupomFiscal.ResumeLayout(False)
        Me.grpCupomFiscal.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpCupomFiscal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNCM As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNCM As System.Windows.Forms.Label
    Friend WithEvents cboAliquotaICMS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAliquotaICMS As System.Windows.Forms.Label
End Class
