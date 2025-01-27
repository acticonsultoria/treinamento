<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailContato
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
        Dim grdContato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdContato_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmailContato))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpEmail = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtBcc = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnBcc = New Janus.Windows.EditControls.UIButton()
        Me.txtCC = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCC = New Janus.Windows.EditControls.UIButton()
        Me.txtPara = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnPara = New Janus.Windows.EditControls.UIButton()
        Me.grdContato = New Janus.Windows.GridEX.GridEX()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        CType(Me.grpEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmail.SuspendLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        'grpEmail
        '
        Me.grpEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpEmail.BackColor = System.Drawing.Color.Transparent
        Me.grpEmail.Controls.Add(Me.txtBcc)
        Me.grpEmail.Controls.Add(Me.btnBcc)
        Me.grpEmail.Controls.Add(Me.txtCC)
        Me.grpEmail.Controls.Add(Me.btnCC)
        Me.grpEmail.Controls.Add(Me.txtPara)
        Me.grpEmail.Controls.Add(Me.btnPara)
        Me.grpEmail.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEmail.Location = New System.Drawing.Point(7, 225)
        Me.grpEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEmail.Name = "grpEmail"
        Me.grpEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEmail.Size = New System.Drawing.Size(674, 100)
        Me.grpEmail.TabIndex = 1
        Me.grpEmail.VisualStyleManager = Me.vsmMain
        '
        'txtBcc
        '
        Me.txtBcc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBcc.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtBcc.Location = New System.Drawing.Point(84, 69)
        Me.txtBcc.MaxLength = 60
        Me.txtBcc.Name = "txtBcc"
        Me.txtBcc.ReadOnly = True
        Me.txtBcc.Size = New System.Drawing.Size(581, 20)
        Me.txtBcc.TabIndex = 11
        Me.txtBcc.TabStop = False
        '
        'btnBcc
        '
        Me.btnBcc.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnBcc.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnBcc.Location = New System.Drawing.Point(9, 69)
        Me.btnBcc.Name = "btnBcc"
        Me.btnBcc.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnBcc.Size = New System.Drawing.Size(60, 20)
        Me.btnBcc.TabIndex = 10
        Me.btnBcc.Text = "&Bcc"
        Me.btnBcc.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtCC
        '
        Me.txtCC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCC.Location = New System.Drawing.Point(84, 43)
        Me.txtCC.MaxLength = 60
        Me.txtCC.Name = "txtCC"
        Me.txtCC.ReadOnly = True
        Me.txtCC.Size = New System.Drawing.Size(581, 20)
        Me.txtCC.TabIndex = 9
        Me.txtCC.TabStop = False
        '
        'btnCC
        '
        Me.btnCC.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCC.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnCC.Location = New System.Drawing.Point(9, 43)
        Me.btnCC.Name = "btnCC"
        Me.btnCC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCC.Size = New System.Drawing.Size(60, 20)
        Me.btnCC.TabIndex = 8
        Me.btnCC.Text = "&Cc"
        Me.btnCC.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPara
        '
        Me.txtPara.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPara.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtPara.Location = New System.Drawing.Point(84, 17)
        Me.txtPara.MaxLength = 60
        Me.txtPara.Name = "txtPara"
        Me.txtPara.ReadOnly = True
        Me.txtPara.Size = New System.Drawing.Size(581, 20)
        Me.txtPara.TabIndex = 7
        Me.txtPara.TabStop = False
        '
        'btnPara
        '
        Me.btnPara.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPara.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPara.Location = New System.Drawing.Point(9, 17)
        Me.btnPara.Name = "btnPara"
        Me.btnPara.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPara.Size = New System.Drawing.Size(60, 20)
        Me.btnPara.TabIndex = 4
        Me.btnPara.Text = "&Para"
        Me.btnPara.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdContato
        '
        Me.grdContato.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdContato.AlternatingColors = True
        Me.grdContato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        grdContato_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdContato_DesignTimeLayout_Reference_0.Instance"), Object)
        grdContato_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdContato_DesignTimeLayout_Reference_0})
        grdContato_DesignTimeLayout.LayoutString = resources.GetString("grdContato_DesignTimeLayout.LayoutString")
        Me.grdContato.DesignTimeLayout = grdContato_DesignTimeLayout
        Me.grdContato.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdContato.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdContato.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdContato.GroupByBoxVisible = False
        Me.grdContato.Location = New System.Drawing.Point(7, 9)
        Me.grdContato.Name = "grdContato"
        Me.grdContato.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdContato.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdContato.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdContato.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdContato.Size = New System.Drawing.Size(674, 212)
        Me.grdContato.TabIndex = 5
        Me.grdContato.TabStop = False
        Me.grdContato.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdContato.VisualStyleManager = Me.vsmMain
        '
        'grpControle
        '
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnConfirmar)
        Me.grpControle.Controls.Add(Me.btnCancelar)
        Me.grpControle.Location = New System.Drawing.Point(7, 328)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(674, 51)
        Me.grpControle.TabIndex = 6
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnConfirmar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmar.Location = New System.Drawing.Point(477, 17)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfirmar.Size = New System.Drawing.Size(91, 23)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(574, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmEmailContato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 387)
        Me.Controls.Add(Me.grpControle)
        Me.Controls.Add(Me.grdContato)
        Me.Controls.Add(Me.grpEmail)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmailContato"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contatos"
        CType(Me.grpEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmail.ResumeLayout(False)
        Me.grpEmail.PerformLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpEmail As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnPara As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtPara As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCC As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnCC As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdContato As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtBcc As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnBcc As Janus.Windows.EditControls.UIButton
End Class
