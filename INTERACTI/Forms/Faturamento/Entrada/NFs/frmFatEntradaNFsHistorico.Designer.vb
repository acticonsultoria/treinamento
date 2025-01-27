<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEntradaNFsHistorico
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
        Dim grdHistorico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEntradaNFsHistorico))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdHistorico = New Janus.Windows.GridEX.GridEX()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCodigoVerificacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoVerificacao = New System.Windows.Forms.Label()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.txtPrestador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPrestador = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(705, 408)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.grdHistorico)
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(703, 385)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Histórico"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 305)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(48, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdHistorico
        '
        Me.grdHistorico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdHistorico.AlternatingColors = True
        Me.grdHistorico.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdHistorico_DesignTimeLayout.LayoutString = resources.GetString("grdHistorico_DesignTimeLayout.LayoutString")
        Me.grdHistorico.DesignTimeLayout = grdHistorico_DesignTimeLayout
        Me.grdHistorico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdHistorico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdHistorico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdHistorico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdHistorico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdHistorico.GroupByBoxVisible = False
        Me.grdHistorico.Location = New System.Drawing.Point(8, 117)
        Me.grdHistorico.Name = "grdHistorico"
        Me.grdHistorico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdHistorico.RecordNavigator = True
        Me.grdHistorico.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdHistorico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdHistorico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdHistorico.Size = New System.Drawing.Size(687, 205)
        Me.grdHistorico.TabIndex = 1
        Me.grdHistorico.TabStop = False
        Me.grdHistorico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdHistorico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdHistorico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdHistorico.VisualStyleManager = Me.vsmMain
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtCodigoVerificacao)
        Me.grpMotivo.Controls.Add(Me.lblCodigoVerificacao)
        Me.grpMotivo.Controls.Add(Me.txtSerie)
        Me.grpMotivo.Controls.Add(Me.lblSerie)
        Me.grpMotivo.Controls.Add(Me.txtDataEmissao)
        Me.grpMotivo.Controls.Add(Me.lblDataEmissao)
        Me.grpMotivo.Controls.Add(Me.txtNotaFiscal)
        Me.grpMotivo.Controls.Add(Me.lblNotaFiscal)
        Me.grpMotivo.Controls.Add(Me.txtPrestador)
        Me.grpMotivo.Controls.Add(Me.lblPrestador)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(687, 104)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados do Registro"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtCodigoVerificacao
        '
        Me.txtCodigoVerificacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoVerificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoVerificacao.Location = New System.Drawing.Point(268, 34)
        Me.txtCodigoVerificacao.MaxLength = 250
        Me.txtCodigoVerificacao.Name = "txtCodigoVerificacao"
        Me.txtCodigoVerificacao.Size = New System.Drawing.Size(169, 20)
        Me.txtCodigoVerificacao.TabIndex = 17
        Me.txtCodigoVerificacao.TabStop = False
        '
        'lblCodigoVerificacao
        '
        Me.lblCodigoVerificacao.AutoSize = True
        Me.lblCodigoVerificacao.Location = New System.Drawing.Point(265, 17)
        Me.lblCodigoVerificacao.Name = "lblCodigoVerificacao"
        Me.lblCodigoVerificacao.Size = New System.Drawing.Size(116, 14)
        Me.lblCodigoVerificacao.TabIndex = 16
        Me.lblCodigoVerificacao.Text = "Código de Verificação:"
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(116, 34)
        Me.txtSerie.MaxLength = 250
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(41, 20)
        Me.txtSerie.TabIndex = 13
        Me.txtSerie.TabStop = False
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(112, 17)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 12
        Me.lblSerie.Text = "Série:"
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Location = New System.Drawing.Point(163, 34)
        Me.txtDataEmissao.MaxLength = 250
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.Size = New System.Drawing.Size(99, 20)
        Me.txtDataEmissao.TabIndex = 15
        Me.txtDataEmissao.TabStop = False
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(160, 17)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 14
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscal.MaxLength = 250
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(100, 20)
        Me.txtNotaFiscal.TabIndex = 11
        Me.txtNotaFiscal.TabStop = False
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(6, 17)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscal.TabIndex = 10
        Me.lblNotaFiscal.Text = "Nota Fiscal:"
        '
        'txtPrestador
        '
        Me.txtPrestador.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrestador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrestador.Location = New System.Drawing.Point(9, 74)
        Me.txtPrestador.MaxLength = 250
        Me.txtPrestador.Name = "txtPrestador"
        Me.txtPrestador.Size = New System.Drawing.Size(669, 20)
        Me.txtPrestador.TabIndex = 19
        Me.txtPrestador.TabStop = False
        '
        'lblPrestador
        '
        Me.lblPrestador.AutoSize = True
        Me.lblPrestador.Location = New System.Drawing.Point(6, 57)
        Me.lblPrestador.Name = "lblPrestador"
        Me.lblPrestador.Size = New System.Drawing.Size(57, 14)
        Me.lblPrestador.TabIndex = 18
        Me.lblPrestador.Text = "Prestador:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 325)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(687, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(587, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEntradaNFsHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEntradaNFsHistorico"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Histórico da Nota Fiscal de Serviço"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdHistorico, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grdHistorico As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtCodigoVerificacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoVerificacao As System.Windows.Forms.Label
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtPrestador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPrestador As System.Windows.Forms.Label
End Class
