<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstInventarioReprovar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstInventarioReprovar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDataInventario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataInventario = New System.Windows.Forms.Label()
        Me.lblHistorico = New System.Windows.Forms.Label()
        Me.txtHistorico = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtUsuario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroInventario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroInventario = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnReprovarInventario = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(705, 408)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpInformacoes)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(703, 385)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados do Inventário"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtDataInventario)
        Me.grpInformacoes.Controls.Add(Me.lblDataInventario)
        Me.grpInformacoes.Controls.Add(Me.lblHistorico)
        Me.grpInformacoes.Controls.Add(Me.txtHistorico)
        Me.grpInformacoes.Controls.Add(Me.txtUsuario)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroInventario)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroInventario)
        Me.grpInformacoes.Controls.Add(Me.lblUsuario)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(687, 319)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtDataInventario
        '
        Me.txtDataInventario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataInventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataInventario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDataInventario.Location = New System.Drawing.Point(135, 34)
        Me.txtDataInventario.MaxLength = 20
        Me.txtDataInventario.Name = "txtDataInventario"
        Me.txtDataInventario.ReadOnly = True
        Me.txtDataInventario.Size = New System.Drawing.Size(87, 20)
        Me.txtDataInventario.TabIndex = 6
        Me.txtDataInventario.TabStop = False
        '
        'lblDataInventario
        '
        Me.lblDataInventario.AutoSize = True
        Me.lblDataInventario.Location = New System.Drawing.Point(132, 17)
        Me.lblDataInventario.Name = "lblDataInventario"
        Me.lblDataInventario.Size = New System.Drawing.Size(32, 14)
        Me.lblDataInventario.TabIndex = 5
        Me.lblDataInventario.Text = "Data:"
        '
        'lblHistorico
        '
        Me.lblHistorico.AutoSize = True
        Me.lblHistorico.BackColor = System.Drawing.Color.Transparent
        Me.lblHistorico.Location = New System.Drawing.Point(6, 57)
        Me.lblHistorico.Name = "lblHistorico"
        Me.lblHistorico.Size = New System.Drawing.Size(52, 14)
        Me.lblHistorico.TabIndex = 4
        Me.lblHistorico.Text = "Histórico:"
        '
        'txtHistorico
        '
        Me.txtHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHistorico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHistorico.Location = New System.Drawing.Point(9, 74)
        Me.txtHistorico.MaxLength = 500
        Me.txtHistorico.Multiline = True
        Me.txtHistorico.Name = "txtHistorico"
        Me.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHistorico.Size = New System.Drawing.Size(669, 235)
        Me.txtHistorico.TabIndex = 0
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsuario.Location = New System.Drawing.Point(228, 34)
        Me.txtUsuario.MaxLength = 100
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(450, 20)
        Me.txtUsuario.TabIndex = 3
        Me.txtUsuario.TabStop = False
        '
        'txtNumeroInventario
        '
        Me.txtNumeroInventario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroInventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroInventario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumeroInventario.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroInventario.MaxLength = 20
        Me.txtNumeroInventario.Name = "txtNumeroInventario"
        Me.txtNumeroInventario.ReadOnly = True
        Me.txtNumeroInventario.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroInventario.TabIndex = 1
        Me.txtNumeroInventario.TabStop = False
        '
        'lblNumeroInventario
        '
        Me.lblNumeroInventario.AutoSize = True
        Me.lblNumeroInventario.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroInventario.Name = "lblNumeroInventario"
        Me.lblNumeroInventario.Size = New System.Drawing.Size(72, 14)
        Me.lblNumeroInventario.TabIndex = 0
        Me.lblNumeroInventario.Text = "Nº Inventário:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(225, 17)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuário:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnReprovarInventario)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 325)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(687, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnReprovarInventario
        '
        Me.btnReprovarInventario.Image = Global.INTERACTI.My.Resources.cancelar
        Me.btnReprovarInventario.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnReprovarInventario.Location = New System.Drawing.Point(431, 17)
        Me.btnReprovarInventario.Name = "btnReprovarInventario"
        Me.btnReprovarInventario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnReprovarInventario.Size = New System.Drawing.Size(150, 23)
        Me.btnReprovarInventario.TabIndex = 0
        Me.btnReprovarInventario.Text = "Reprovar Inventário"
        Me.btnReprovarInventario.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(587, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmEstInventarioReprovar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEstInventarioReprovar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventário - Reprovar"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnReprovarInventario As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblHistorico As System.Windows.Forms.Label
    Friend WithEvents txtHistorico As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtUsuario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroInventario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroInventario As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtDataInventario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataInventario As System.Windows.Forms.Label
End Class
