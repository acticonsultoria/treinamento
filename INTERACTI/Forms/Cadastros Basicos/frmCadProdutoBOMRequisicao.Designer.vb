<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutoBOMRequisicao
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
        Dim grdListagemBOM_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutoBOMRequisicao))
        Dim grdListagemRequisicao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelListagemRequisicao = New System.Windows.Forms.Button()
        Me.btnExcelListagemBOM = New System.Windows.Forms.Button()
        Me.grdListagemBOM = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCodigoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoItem = New System.Windows.Forms.Label()
        Me.cboRequisicaoEstoque = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRequisicaoEstoque = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.grdListagemRequisicao = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtMotivo = New Janus.Windows.GridEX.EditControls.EditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdListagemBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdListagemRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(984, 518)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnExcelListagemRequisicao)
        Me.pagTabela.Controls.Add(Me.btnExcelListagemBOM)
        Me.pagTabela.Controls.Add(Me.grdListagemBOM)
        Me.pagTabela.Controls.Add(Me.UiGroupBox1)
        Me.pagTabela.Controls.Add(Me.grdListagemRequisicao)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(982, 495)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Requisição de Estoque"
        '
        'btnExcelListagemRequisicao
        '
        Me.btnExcelListagemRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelListagemRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelListagemRequisicao.FlatAppearance.BorderSize = 0
        Me.btnExcelListagemRequisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelListagemRequisicao.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagemRequisicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelListagemRequisicao.Location = New System.Drawing.Point(10, 412)
        Me.btnExcelListagemRequisicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelListagemRequisicao.Name = "btnExcelListagemRequisicao"
        Me.btnExcelListagemRequisicao.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelListagemRequisicao.TabIndex = 109
        Me.btnExcelListagemRequisicao.TabStop = False
        Me.btnExcelListagemRequisicao.UseVisualStyleBackColor = False
        '
        'btnExcelListagemBOM
        '
        Me.btnExcelListagemBOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelListagemBOM.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelListagemBOM.FlatAppearance.BorderSize = 0
        Me.btnExcelListagemBOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelListagemBOM.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagemBOM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelListagemBOM.Location = New System.Drawing.Point(527, 412)
        Me.btnExcelListagemBOM.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelListagemBOM.Name = "btnExcelListagemBOM"
        Me.btnExcelListagemBOM.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelListagemBOM.TabIndex = 106
        Me.btnExcelListagemBOM.TabStop = False
        Me.btnExcelListagemBOM.UseVisualStyleBackColor = False
        '
        'grdListagemBOM
        '
        Me.grdListagemBOM.AllowChildTableGroups = True
        Me.grdListagemBOM.AlternatingColors = True
        Me.grdListagemBOM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagemBOM.AutoEdit = True
        grdListagemBOM_DesignTimeLayout.LayoutString = resources.GetString("grdListagemBOM_DesignTimeLayout.LayoutString")
        Me.grdListagemBOM.DesignTimeLayout = grdListagemBOM_DesignTimeLayout
        Me.grdListagemBOM.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagemBOM.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemBOM.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagemBOM.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemBOM.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagemBOM.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemBOM.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemBOM.FrozenColumns = 1
        Me.grdListagemBOM.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemBOM.GroupByBoxVisible = False
        Me.grdListagemBOM.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagemBOM.Hierarchical = True
        Me.grdListagemBOM.Location = New System.Drawing.Point(526, 70)
        Me.grdListagemBOM.Name = "grdListagemBOM"
        Me.grdListagemBOM.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemBOM.RecordNavigator = True
        Me.grdListagemBOM.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagemBOM.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemBOM.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemBOM.Size = New System.Drawing.Size(448, 359)
        Me.grdListagemBOM.TabIndex = 50
        Me.grdListagemBOM.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagemBOM.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagemBOM.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagemBOM.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemBOM.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemBOM.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagemBOM.UpdateOnLeave = False
        Me.grdListagemBOM.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemBOM.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtCodigoItem)
        Me.UiGroupBox1.Controls.Add(Me.lblCodigoItem)
        Me.UiGroupBox1.Controls.Add(Me.cboRequisicaoEstoque)
        Me.UiGroupBox1.Controls.Add(Me.lblRequisicaoEstoque)
        Me.UiGroupBox1.Controls.Add(Me.txtOrdemProducao)
        Me.UiGroupBox1.Controls.Add(Me.lblOrdemProducao)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(966, 61)
        Me.UiGroupBox1.TabIndex = 49
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtCodigoItem
        '
        Me.txtCodigoItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigoItem.Location = New System.Drawing.Point(396, 29)
        Me.txtCodigoItem.MaxLength = 120
        Me.txtCodigoItem.Name = "txtCodigoItem"
        Me.txtCodigoItem.ReadOnly = True
        Me.txtCodigoItem.Size = New System.Drawing.Size(235, 20)
        Me.txtCodigoItem.TabIndex = 10
        Me.txtCodigoItem.TabStop = False
        '
        'lblCodigoItem
        '
        Me.lblCodigoItem.AutoSize = True
        Me.lblCodigoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoItem.Location = New System.Drawing.Point(393, 12)
        Me.lblCodigoItem.Name = "lblCodigoItem"
        Me.lblCodigoItem.Size = New System.Drawing.Size(65, 14)
        Me.lblCodigoItem.TabIndex = 9
        Me.lblCodigoItem.Text = "Código Item:"
        '
        'cboRequisicaoEstoque
        '
        Me.cboRequisicaoEstoque.Location = New System.Drawing.Point(6, 29)
        Me.cboRequisicaoEstoque.Name = "cboRequisicaoEstoque"
        Me.cboRequisicaoEstoque.Size = New System.Drawing.Size(143, 20)
        Me.cboRequisicaoEstoque.TabIndex = 6
        '
        'lblRequisicaoEstoque
        '
        Me.lblRequisicaoEstoque.AutoSize = True
        Me.lblRequisicaoEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRequisicaoEstoque.Location = New System.Drawing.Point(3, 12)
        Me.lblRequisicaoEstoque.Name = "lblRequisicaoEstoque"
        Me.lblRequisicaoEstoque.Size = New System.Drawing.Size(77, 14)
        Me.lblRequisicaoEstoque.TabIndex = 5
        Me.lblRequisicaoEstoque.Text = "N° Requisição:"
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtOrdemProducao.Location = New System.Drawing.Point(155, 29)
        Me.txtOrdemProducao.MaxLength = 120
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.Size = New System.Drawing.Size(235, 20)
        Me.txtOrdemProducao.TabIndex = 8
        Me.txtOrdemProducao.TabStop = False
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrdemProducao.Location = New System.Drawing.Point(152, 12)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducao.TabIndex = 7
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'grdListagemRequisicao
        '
        Me.grdListagemRequisicao.AlternatingColors = True
        Me.grdListagemRequisicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagemRequisicao_DesignTimeLayout.LayoutString = resources.GetString("grdListagemRequisicao_DesignTimeLayout.LayoutString")
        Me.grdListagemRequisicao.DesignTimeLayout = grdListagemRequisicao_DesignTimeLayout
        Me.grdListagemRequisicao.DynamicFiltering = True
        Me.grdListagemRequisicao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemRequisicao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagemRequisicao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemRequisicao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemRequisicao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemRequisicao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemRequisicao.GroupByBoxVisible = False
        Me.grdListagemRequisicao.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagemRequisicao.Location = New System.Drawing.Point(8, 70)
        Me.grdListagemRequisicao.Name = "grdListagemRequisicao"
        Me.grdListagemRequisicao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemRequisicao.RecordNavigator = True
        Me.grdListagemRequisicao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemRequisicao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemRequisicao.Size = New System.Drawing.Size(512, 359)
        Me.grdListagemRequisicao.TabIndex = 45
        Me.grdListagemRequisicao.TabStop = False
        Me.grdListagemRequisicao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemRequisicao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemRequisicao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemRequisicao.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnConfirmar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 435)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(966, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnConfirmar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmar.Location = New System.Drawing.Point(769, 17)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfirmar.Size = New System.Drawing.Size(91, 23)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(866, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(9, 125)
        Me.txtJustificativa.MaxLength = 0
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(779, 239)
        Me.txtJustificativa.TabIndex = 1
        '
        'txtMotivo
        '
        Me.txtMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotivo.BackColor = System.Drawing.SystemColors.Info
        Me.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMotivo.Location = New System.Drawing.Point(9, 34)
        Me.txtMotivo.MaxLength = 0
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.ReadOnly = True
        Me.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivo.Size = New System.Drawing.Size(779, 71)
        Me.txtMotivo.TabIndex = 2
        Me.txtMotivo.TabStop = False
        '
        'frmCadProdutoBOMRequisicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 532)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadProdutoBOMRequisicao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Requisição de Estoque"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdListagemBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdListagemRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtMotivo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grdListagemRequisicao As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCodigoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoItem As System.Windows.Forms.Label
    Friend WithEvents cboRequisicaoEstoque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRequisicaoEstoque As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents grdListagemBOM As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelListagemRequisicao As System.Windows.Forms.Button
    Friend WithEvents btnExcelListagemBOM As System.Windows.Forms.Button
End Class
