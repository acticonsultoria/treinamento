<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIntRE
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIntRE))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaArquivoImportado = New System.Windows.Forms.Label()
        Me.picLegendaArquivoImportado = New System.Windows.Forms.PictureBox()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPasta = New System.Windows.Forms.Label()
        Me.txtPasta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnPasta = New Janus.Windows.EditControls.UIButton()
        Me.lblIntegracao = New System.Windows.Forms.Label()
        Me.cboIntegracao = New Janus.Windows.EditControls.UIComboBox()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        CType(Me.grdControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControl.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaArquivoImportado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'grdControl
        '
        Me.grdControl.BackColor = System.Drawing.Color.Transparent
        Me.grdControl.Controls.Add(Me.btnNovo)
        Me.grdControl.Controls.Add(Me.btnSalvar)
        Me.grdControl.Controls.Add(Me.btnSair)
        Me.grdControl.Location = New System.Drawing.Point(265, 483)
        Me.grdControl.Name = "grdControl"
        Me.grdControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControl.Size = New System.Drawing.Size(640, 51)
        Me.grdControl.TabIndex = 3
        Me.grdControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(346, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(443, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(540, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpLegenda)
        Me.pagDados.Controls.Add(Me.UiGroupBox2)
        Me.pagDados.Controls.Add(Me.grdControl)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Importar Nota Fiscal Eletrônica - Emissão"
        '
        'grpLegenda
        '
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaArquivoImportado)
        Me.grpLegenda.Controls.Add(Me.picLegendaArquivoImportado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(248, 51)
        Me.grpLegenda.TabIndex = 2
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaArquivoImportado
        '
        Me.lblLegendaArquivoImportado.AutoSize = True
        Me.lblLegendaArquivoImportado.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaArquivoImportado.Name = "lblLegendaArquivoImportado"
        Me.lblLegendaArquivoImportado.Size = New System.Drawing.Size(216, 14)
        Me.lblLegendaArquivoImportado.TabIndex = 0
        Me.lblLegendaArquivoImportado.Text = "Arquivo de Nota Fiscal Eletrônica Importada"
        '
        'picLegendaArquivoImportado
        '
        Me.picLegendaArquivoImportado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaArquivoImportado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaArquivoImportado.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaArquivoImportado.Name = "picLegendaArquivoImportado"
        Me.picLegendaArquivoImportado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaArquivoImportado.TabIndex = 8
        Me.picLegendaArquivoImportado.TabStop = False
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.lblPasta)
        Me.UiGroupBox2.Controls.Add(Me.txtPasta)
        Me.UiGroupBox2.Controls.Add(Me.btnPasta)
        Me.UiGroupBox2.Controls.Add(Me.lblIntegracao)
        Me.UiGroupBox2.Controls.Add(Me.cboIntegracao)
        Me.UiGroupBox2.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(897, 64)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'lblPasta
        '
        Me.lblPasta.AutoSize = True
        Me.lblPasta.Location = New System.Drawing.Point(200, 17)
        Me.lblPasta.Name = "lblPasta"
        Me.lblPasta.Size = New System.Drawing.Size(89, 14)
        Me.lblPasta.TabIndex = 0
        Me.lblPasta.Text = "Pasta de Arquivo"
        '
        'txtPasta
        '
        Me.txtPasta.BackColor = System.Drawing.SystemColors.Info
        Me.txtPasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasta.Location = New System.Drawing.Point(203, 34)
        Me.txtPasta.MaxLength = 50
        Me.txtPasta.Name = "txtPasta"
        Me.txtPasta.ReadOnly = True
        Me.txtPasta.Size = New System.Drawing.Size(663, 20)
        Me.txtPasta.TabIndex = 1
        Me.txtPasta.TabStop = False
        '
        'btnPasta
        '
        Me.btnPasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPasta.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPasta.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPasta.Location = New System.Drawing.Point(865, 34)
        Me.btnPasta.Name = "btnPasta"
        Me.btnPasta.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPasta.Size = New System.Drawing.Size(23, 20)
        Me.btnPasta.TabIndex = 2
        Me.btnPasta.Text = "..."
        Me.btnPasta.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblIntegracao
        '
        Me.lblIntegracao.AutoSize = True
        Me.lblIntegracao.Location = New System.Drawing.Point(6, 17)
        Me.lblIntegracao.Name = "lblIntegracao"
        Me.lblIntegracao.Size = New System.Drawing.Size(148, 14)
        Me.lblIntegracao.TabIndex = 3
        Me.lblIntegracao.Text = "Integrar Financeiro / Estoque:"
        '
        'cboIntegracao
        '
        Me.cboIntegracao.AutoSize = False
        Me.cboIntegracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboIntegracao.Location = New System.Drawing.Point(9, 34)
        Me.cboIntegracao.Name = "cboIntegracao"
        Me.cboIntegracao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboIntegracao.Size = New System.Drawing.Size(188, 20)
        Me.cboIntegracao.TabIndex = 4
        '
        'tabDados
        '
        Me.tabDados.ShowFocusRectangle = False: Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 73)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.Size = New System.Drawing.Size(897, 407)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagArquivo})
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagArquivo
        '
        Me.pagArquivo.Controls.Add(Me.grdArquivo)
        Me.pagArquivo.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivo.Name = "pagArquivo"
        Me.pagArquivo.Size = New System.Drawing.Size(895, 384)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Tag = "pagArquivo"
        Me.pagArquivo.Text = "Lista de Arquivos"
        '
        'grdArquivo
        '
        Me.grdArquivo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdArquivo.AlternatingColors = True
        Me.grdArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdArquivo_DesignTimeLayout.LayoutString = resources.GetString("grdArquivo_DesignTimeLayout.LayoutString")
        Me.grdArquivo.DesignTimeLayout = grdArquivo_DesignTimeLayout
        Me.grdArquivo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdArquivo.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.grdArquivo.FilterRowFormatStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdArquivo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivo.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdArquivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdArquivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivo.GroupByBoxVisible = False
        Me.grdArquivo.Location = New System.Drawing.Point(8, 9)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 366)
        Me.grdArquivo.TabIndex = 0
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'usrIntRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrIntRE"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.grdControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControl.ResumeLayout(False)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaArquivoImportado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagArquivo.ResumeLayout(False)
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPasta As System.Windows.Forms.Label
    Friend WithEvents txtPasta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnPasta As Janus.Windows.EditControls.UIButton
    Private WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaArquivoImportado As System.Windows.Forms.Label
    Friend WithEvents picLegendaArquivoImportado As System.Windows.Forms.PictureBox
    Friend WithEvents lblIntegracao As System.Windows.Forms.Label
    Friend WithEvents cboIntegracao As Janus.Windows.EditControls.UIComboBox

End Class
