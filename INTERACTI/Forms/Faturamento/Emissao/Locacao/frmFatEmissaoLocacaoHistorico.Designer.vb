<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoLocacaoHistorico
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoLocacaoHistorico))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(771, 438)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grdListagem)
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(769, 415)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Histórico"
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 120)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(753, 232)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtSerie)
        Me.grpMotivo.Controls.Add(Me.lblSerie)
        Me.grpMotivo.Controls.Add(Me.txtDataEmissao)
        Me.grpMotivo.Controls.Add(Me.lblDataEmissao)
        Me.grpMotivo.Controls.Add(Me.txtNotaFiscal)
        Me.grpMotivo.Controls.Add(Me.lblNotaFiscal)
        Me.grpMotivo.Controls.Add(Me.txtCliente)
        Me.grpMotivo.Controls.Add(Me.lblCliente)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(753, 107)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados da Nota Fiscal"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(112, 37)
        Me.txtSerie.MaxLength = 250
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(41, 20)
        Me.txtSerie.TabIndex = 7
        Me.txtSerie.TabStop = False
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(108, 20)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 6
        Me.lblSerie.Text = "Série:"
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Location = New System.Drawing.Point(159, 37)
        Me.txtDataEmissao.MaxLength = 250
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.Size = New System.Drawing.Size(91, 20)
        Me.txtDataEmissao.TabIndex = 9
        Me.txtDataEmissao.TabStop = False
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(156, 20)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 8
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Location = New System.Drawing.Point(9, 37)
        Me.txtNotaFiscal.MaxLength = 250
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(97, 20)
        Me.txtNotaFiscal.TabIndex = 5
        Me.txtNotaFiscal.TabStop = False
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(5, 20)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscal.TabIndex = 4
        Me.lblNotaFiscal.Text = "Nota Fiscal:"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(9, 77)
        Me.txtCliente.MaxLength = 250
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(500, 20)
        Me.txtCliente.TabIndex = 1
        Me.txtCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(6, 60)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 355)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(753, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(653, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEmissaoLocacaoHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 453)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoLocacaoHistorico"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Histórico da Nota Fiscal"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
End Class
