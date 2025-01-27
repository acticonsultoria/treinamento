<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmpCotacaoMapaComparativo
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
        Dim grdVencedores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpCotacaoMapaComparativo))
        Dim grdAprovacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagAprovacao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdVencedores = New Janus.Windows.GridEX.GridEX()
        Me.btnConfigurarGridAprovacao = New System.Windows.Forms.Button()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFormaAnaliseOrcamento = New System.Windows.Forms.Label()
        Me.cboFormaAnaliseOrcamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroCotacaoAprovacao = New System.Windows.Forms.Label()
        Me.txtDataCotacaoAprovacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboNumeroCotacaoAprovacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataCotacaoAprovacao = New System.Windows.Forms.Label()
        Me.grpControleAprovacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnAprovarOrcamento = New Janus.Windows.EditControls.UIButton()
        Me.grdAprovacao = New Janus.Windows.GridEX.GridEX()
        Me.cmsOrcamento = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnDesmembrarEntrega = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDescritivoOrcamento = New System.Windows.Forms.Label()
        Me.txtDescritivoOrcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabMain.SuspendLayout
        Me.pagAprovacao.SuspendLayout
        CType(Me.grdVencedores,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UiGroupBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UiGroupBox1.SuspendLayout
        CType(Me.grpControleAprovacao,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpControleAprovacao.SuspendLayout
        CType(Me.grdAprovacao,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsOrcamento.SuspendLayout
        Me.SuspendLayout
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
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagAprovacao})
        Me.tabMain.TabStop = false
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagAprovacao
        '
        Me.pagAprovacao.Controls.Add(Me.grdVencedores)
        Me.pagAprovacao.Controls.Add(Me.btnConfigurarGridAprovacao)
        Me.pagAprovacao.Controls.Add(Me.UiGroupBox1)
        Me.pagAprovacao.Controls.Add(Me.grpControleAprovacao)
        Me.pagAprovacao.Controls.Add(Me.grdAprovacao)
        Me.pagAprovacao.Key = "pagAprovacao"
        Me.pagAprovacao.Location = New System.Drawing.Point(1, 22)
        Me.pagAprovacao.Name = "pagAprovacao"
        Me.pagAprovacao.Size = New System.Drawing.Size(913, 543)
        Me.pagAprovacao.TabStop = true
        Me.pagAprovacao.Text = "Mapa Comparativo"
        '
        'grdVencedores
        '
        Me.grdVencedores.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVencedores.AlternatingColors = true
        grdVencedores_DesignTimeLayout.LayoutString = resources.GetString("grdVencedores_DesignTimeLayout.LayoutString")
        Me.grdVencedores.DesignTimeLayout = grdVencedores_DesignTimeLayout
        Me.grdVencedores.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdVencedores.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVencedores.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVencedores.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVencedores.GroupByBoxVisible = false
        Me.grdVencedores.Location = New System.Drawing.Point(8, 375)
        Me.grdVencedores.Name = "grdVencedores"
        Me.grdVencedores.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.grdVencedores.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVencedores.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVencedores.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVencedores.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVencedores.Size = New System.Drawing.Size(897, 105)
        Me.grdVencedores.TabIndex = 11
        Me.grdVencedores.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdVencedores.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdVencedores.UpdateOnLeave = false
        Me.grdVencedores.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVencedores.VisualStyleManager = Me.vsmMain
        '
        'btnConfigurarGridAprovacao
        '
        Me.btnConfigurarGridAprovacao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridAprovacao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridAprovacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridAprovacao.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridAprovacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridAprovacao.Location = New System.Drawing.Point(9, 349)
        Me.btnConfigurarGridAprovacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridAprovacao.Name = "btnConfigurarGridAprovacao"
        Me.btnConfigurarGridAprovacao.Size = New System.Drawing.Size(48, 15)
        Me.btnConfigurarGridAprovacao.TabIndex = 10
        Me.btnConfigurarGridAprovacao.TabStop = false
        Me.btnConfigurarGridAprovacao.UseVisualStyleBackColor = false
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.lblDescritivoOrcamento)
        Me.UiGroupBox1.Controls.Add(Me.txtDescritivoOrcamento)
        Me.UiGroupBox1.Controls.Add(Me.lblFormaAnaliseOrcamento)
        Me.UiGroupBox1.Controls.Add(Me.cboFormaAnaliseOrcamento)
        Me.UiGroupBox1.Controls.Add(Me.lblNumeroCotacaoAprovacao)
        Me.UiGroupBox1.Controls.Add(Me.txtDataCotacaoAprovacao)
        Me.UiGroupBox1.Controls.Add(Me.cboNumeroCotacaoAprovacao)
        Me.UiGroupBox1.Controls.Add(Me.lblDataCotacaoAprovacao)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(897, 64)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'lblFormaAnaliseOrcamento
        '
        Me.lblFormaAnaliseOrcamento.AutoSize = true
        Me.lblFormaAnaliseOrcamento.Location = New System.Drawing.Point(641, 17)
        Me.lblFormaAnaliseOrcamento.Name = "lblFormaAnaliseOrcamento"
        Me.lblFormaAnaliseOrcamento.Size = New System.Drawing.Size(93, 14)
        Me.lblFormaAnaliseOrcamento.TabIndex = 6
        Me.lblFormaAnaliseOrcamento.Text = "Forma de Análise:"
        '
        'cboFormaAnaliseOrcamento
        '
        Me.cboFormaAnaliseOrcamento.AutoSize = false
        Me.cboFormaAnaliseOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaAnaliseOrcamento.Location = New System.Drawing.Point(644, 34)
        Me.cboFormaAnaliseOrcamento.Name = "cboFormaAnaliseOrcamento"
        Me.cboFormaAnaliseOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaAnaliseOrcamento.Size = New System.Drawing.Size(244, 20)
        Me.cboFormaAnaliseOrcamento.TabIndex = 7
        '
        'lblNumeroCotacaoAprovacao
        '
        Me.lblNumeroCotacaoAprovacao.AutoSize = true
        Me.lblNumeroCotacaoAprovacao.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroCotacaoAprovacao.Name = "lblNumeroCotacaoAprovacao"
        Me.lblNumeroCotacaoAprovacao.Size = New System.Drawing.Size(65, 14)
        Me.lblNumeroCotacaoAprovacao.TabIndex = 0
        Me.lblNumeroCotacaoAprovacao.Text = "Nº Cotação:"
        '
        'txtDataCotacaoAprovacao
        '
        Me.txtDataCotacaoAprovacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataCotacaoAprovacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataCotacaoAprovacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDataCotacaoAprovacao.Location = New System.Drawing.Point(130, 34)
        Me.txtDataCotacaoAprovacao.MaxLength = 10
        Me.txtDataCotacaoAprovacao.Name = "txtDataCotacaoAprovacao"
        Me.txtDataCotacaoAprovacao.ReadOnly = true
        Me.txtDataCotacaoAprovacao.Size = New System.Drawing.Size(115, 20)
        Me.txtDataCotacaoAprovacao.TabIndex = 3
        Me.txtDataCotacaoAprovacao.TabStop = false
        Me.txtDataCotacaoAprovacao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'cboNumeroCotacaoAprovacao
        '
        Me.cboNumeroCotacaoAprovacao.AutoSize = false
        Me.cboNumeroCotacaoAprovacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroCotacaoAprovacao.Location = New System.Drawing.Point(9, 34)
        Me.cboNumeroCotacaoAprovacao.Name = "cboNumeroCotacaoAprovacao"
        Me.cboNumeroCotacaoAprovacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroCotacaoAprovacao.Size = New System.Drawing.Size(115, 20)
        Me.cboNumeroCotacaoAprovacao.TabIndex = 1
        '
        'lblDataCotacaoAprovacao
        '
        Me.lblDataCotacaoAprovacao.AutoSize = true
        Me.lblDataCotacaoAprovacao.Location = New System.Drawing.Point(127, 17)
        Me.lblDataCotacaoAprovacao.Name = "lblDataCotacaoAprovacao"
        Me.lblDataCotacaoAprovacao.Size = New System.Drawing.Size(90, 14)
        Me.lblDataCotacaoAprovacao.TabIndex = 2
        Me.lblDataCotacaoAprovacao.Text = "Data da Cotação:"
        '
        'grpControleAprovacao
        '
        Me.grpControleAprovacao.BackColor = System.Drawing.Color.Transparent
        Me.grpControleAprovacao.Controls.Add(Me.btnSair)
        Me.grpControleAprovacao.Controls.Add(Me.btnAprovarOrcamento)
        Me.grpControleAprovacao.Location = New System.Drawing.Point(8, 483)
        Me.grpControleAprovacao.Name = "grpControleAprovacao"
        Me.grpControleAprovacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleAprovacao.Size = New System.Drawing.Size(897, 51)
        Me.grpControleAprovacao.TabIndex = 6
        Me.grpControleAprovacao.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"),System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAprovarOrcamento
        '
        Me.btnAprovarOrcamento.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnAprovarOrcamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAprovarOrcamento.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAprovarOrcamento.Location = New System.Drawing.Point(651, 17)
        Me.btnAprovarOrcamento.Name = "btnAprovarOrcamento"
        Me.btnAprovarOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAprovarOrcamento.Size = New System.Drawing.Size(140, 23)
        Me.btnAprovarOrcamento.TabIndex = 1
        Me.btnAprovarOrcamento.Text = "Alterar Cotação"
        Me.btnAprovarOrcamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdAprovacao
        '
        Me.grdAprovacao.AlternatingColors = true
        Me.grdAprovacao.AutoEdit = true
        grdAprovacao_DesignTimeLayout.LayoutString = resources.GetString("grdAprovacao_DesignTimeLayout.LayoutString")
        Me.grdAprovacao.DesignTimeLayout = grdAprovacao_DesignTimeLayout
        Me.grdAprovacao.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdAprovacao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdAprovacao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdAprovacao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdAprovacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdAprovacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdAprovacao.FrozenColumns = 5
        Me.grdAprovacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdAprovacao.GroupByBoxVisible = false
        Me.grdAprovacao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdAprovacao.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdAprovacao.Location = New System.Drawing.Point(8, 75)
        Me.grdAprovacao.Name = "grdAprovacao"
        Me.grdAprovacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdAprovacao.RecordNavigator = true
        Me.grdAprovacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdAprovacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdAprovacao.Size = New System.Drawing.Size(897, 291)
        Me.grdAprovacao.TabIndex = 1
        Me.grdAprovacao.TabStop = false
        Me.grdAprovacao.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdAprovacao.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdAprovacao.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdAprovacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdAprovacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdAprovacao.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdAprovacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdAprovacao.VisualStyleManager = Me.vsmMain
        '
        'cmsOrcamento
        '
        Me.cmsOrcamento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDesmembrarEntrega})
        Me.cmsOrcamento.Name = "cmsDesmembrarEntrega"
        Me.cmsOrcamento.Size = New System.Drawing.Size(186, 26)
        '
        'btnDesmembrarEntrega
        '
        Me.btnDesmembrarEntrega.Name = "btnDesmembrarEntrega"
        Me.btnDesmembrarEntrega.Size = New System.Drawing.Size(185, 22)
        Me.btnDesmembrarEntrega.Text = "Desmembrar Entrega"
        '
        'lblDescritivoOrcamento
        '
        Me.lblDescritivoOrcamento.AutoSize = true
        Me.lblDescritivoOrcamento.Location = New System.Drawing.Point(248, 17)
        Me.lblDescritivoOrcamento.Name = "lblDescritivoOrcamento"
        Me.lblDescritivoOrcamento.Size = New System.Drawing.Size(129, 14)
        Me.lblDescritivoOrcamento.TabIndex = 4
        Me.lblDescritivoOrcamento.Text = "Descritivo do Orçamento:"
        '
        'txtDescritivoOrcamento
        '
        Me.txtDescritivoOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivoOrcamento.Location = New System.Drawing.Point(251, 34)
        Me.txtDescritivoOrcamento.MaxLength = 100
        Me.txtDescritivoOrcamento.Name = "txtDescritivoOrcamento"
        Me.txtDescritivoOrcamento.Size = New System.Drawing.Size(387, 20)
        Me.txtDescritivoOrcamento.TabIndex = 5
        '
        'usrCmpCotacaoMapaComparativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpCotacaoMapaComparativo"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagAprovacao.ResumeLayout(false)
        CType(Me.grdVencedores,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UiGroupBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.UiGroupBox1.ResumeLayout(false)
        Me.UiGroupBox1.PerformLayout
        CType(Me.grpControleAprovacao,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControleAprovacao.ResumeLayout(false)
        CType(Me.grdAprovacao,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsOrcamento.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagAprovacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdAprovacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControleAprovacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAprovarOrcamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroCotacaoAprovacao As System.Windows.Forms.Label
    Friend WithEvents txtDataCotacaoAprovacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboNumeroCotacaoAprovacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDataCotacaoAprovacao As System.Windows.Forms.Label
    Friend WithEvents lblFormaAnaliseOrcamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaAnaliseOrcamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cmsOrcamento As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnDesmembrarEntrega As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnConfigurarGridAprovacao As System.Windows.Forms.Button
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdVencedores As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblDescritivoOrcamento As System.Windows.Forms.Label
    Friend WithEvents txtDescritivoOrcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox

End Class
