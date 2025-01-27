<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEmailMalaDireta
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEmailMalaDireta))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarTextoEmail = New System.Windows.Forms.Button()
        Me.cboEmail = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtBody = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.grpEmail = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAssunto = New System.Windows.Forms.Label()
        Me.txtAnexo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnAnexo = New Janus.Windows.EditControls.UIButton()
        Me.txtAssunto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnEnviar = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEmail.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGrid)
        Me.pagDados.Controls.Add(Me.btnAgruparGrid)
        Me.pagDados.Controls.Add(Me.btnConfigurarGrid)
        Me.pagDados.Controls.Add(Me.grpControle)
        Me.pagDados.Controls.Add(Me.btnCadastrarTextoEmail)
        Me.pagDados.Controls.Add(Me.cboEmail)
        Me.pagDados.Controls.Add(Me.lblEmail)
        Me.pagDados.Controls.Add(Me.txtBody)
        Me.pagDados.Controls.Add(Me.grpEmail)
        Me.pagDados.Controls.Add(Me.grdListagem)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Interacti - Mala Direta"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 147)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 27
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 147)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 26
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 147)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 25
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 6
        Me.grpControle.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarTextoEmail
        '
        Me.btnCadastrarTextoEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarTextoEmail.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastrarTextoEmail.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTextoEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTextoEmail.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarTextoEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTextoEmail.Location = New System.Drawing.Point(8, 253)
        Me.btnCadastrarTextoEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTextoEmail.Name = "btnCadastrarTextoEmail"
        Me.btnCadastrarTextoEmail.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTextoEmail.TabIndex = 2
        Me.btnCadastrarTextoEmail.TabStop = False
        Me.btnCadastrarTextoEmail.UseVisualStyleBackColor = False
        '
        'cboEmail
        '
        Me.cboEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboEmail.AutoSize = False
        Me.cboEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEmail.Location = New System.Drawing.Point(186, 249)
        Me.cboEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboEmail.Name = "cboEmail"
        Me.cboEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEmail.Size = New System.Drawing.Size(392, 20)
        Me.cboEmail.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Location = New System.Drawing.Point(24, 252)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(115, 14)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "E-mail pré cadastrado:"
        '
        'txtBody
        '
        Me.txtBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBody.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBody.Location = New System.Drawing.Point(8, 276)
        Me.txtBody.MaxLength = 0
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBody.Size = New System.Drawing.Size(897, 204)
        Me.txtBody.TabIndex = 5
        '
        'grpEmail
        '
        Me.grpEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEmail.BackColor = System.Drawing.Color.Transparent
        Me.grpEmail.Controls.Add(Me.lblAssunto)
        Me.grpEmail.Controls.Add(Me.txtAnexo)
        Me.grpEmail.Controls.Add(Me.btnAnexo)
        Me.grpEmail.Controls.Add(Me.txtAssunto)
        Me.grpEmail.Controls.Add(Me.btnEnviar)
        Me.grpEmail.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEmail.Location = New System.Drawing.Point(8, 167)
        Me.grpEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEmail.Name = "grpEmail"
        Me.grpEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEmail.Size = New System.Drawing.Size(897, 74)
        Me.grpEmail.TabIndex = 1
        Me.grpEmail.VisualStyleManager = Me.vsmMain
        '
        'lblAssunto
        '
        Me.lblAssunto.AutoSize = True
        Me.lblAssunto.Location = New System.Drawing.Point(106, 20)
        Me.lblAssunto.Name = "lblAssunto"
        Me.lblAssunto.Size = New System.Drawing.Size(51, 14)
        Me.lblAssunto.TabIndex = 1
        Me.lblAssunto.Text = "Assunto:"
        '
        'txtAnexo
        '
        Me.txtAnexo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnexo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAnexo.Location = New System.Drawing.Point(178, 43)
        Me.txtAnexo.MaxLength = 60
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.ReadOnly = True
        Me.txtAnexo.Size = New System.Drawing.Size(710, 20)
        Me.txtAnexo.TabIndex = 4
        Me.txtAnexo.TabStop = False
        '
        'btnAnexo
        '
        Me.btnAnexo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAnexo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAnexo.Location = New System.Drawing.Point(109, 43)
        Me.btnAnexo.Name = "btnAnexo"
        Me.btnAnexo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAnexo.Size = New System.Drawing.Size(60, 20)
        Me.btnAnexo.TabIndex = 3
        Me.btnAnexo.Text = "&Anexo"
        Me.btnAnexo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtAssunto
        '
        Me.txtAssunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAssunto.Location = New System.Drawing.Point(178, 17)
        Me.txtAssunto.MaxLength = 60
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(710, 20)
        Me.txtAssunto.TabIndex = 2
        '
        'btnEnviar
        '
        Me.btnEnviar.Image = Global.INTERACTI.My.Resources.Resources.email_maior
        Me.btnEnviar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnEnviar.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnEnviar.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.TopOfText
        Me.btnEnviar.Location = New System.Drawing.Point(9, 17)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEnviar.Size = New System.Drawing.Size(91, 46)
        Me.btnEnviar.TabIndex = 0
        Me.btnEnviar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Location = New System.Drawing.Point(8, 9)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 155)
        Me.grdListagem.TabIndex = 0
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'usrEmailMalaDireta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEmailMalaDireta"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        Me.pagDados.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEmail.ResumeLayout(False)
        Me.grpEmail.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnCadastrarTextoEmail As System.Windows.Forms.Button
    Friend WithEvents cboEmail As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtBody As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grpEmail As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAssunto As System.Windows.Forms.Label
    Friend WithEvents txtAnexo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnAnexo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAssunto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnEnviar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button

End Class
