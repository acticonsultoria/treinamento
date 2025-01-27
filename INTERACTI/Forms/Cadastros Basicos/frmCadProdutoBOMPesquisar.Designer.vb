<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutoBOMPesquisar
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
        Dim grdListagemPesquisar_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutoBOMPesquisar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelListagemRequisicao = New System.Windows.Forms.Button()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCodigoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoItem = New System.Windows.Forms.Label()
        Me.grdListagemPesquisar = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtMotivo = New Janus.Windows.GridEX.EditControls.EditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdListagemPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagTabela.Controls.Add(Me.UiGroupBox1)
        Me.pagTabela.Controls.Add(Me.grdListagemPesquisar)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(982, 495)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "BOM"
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
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtCodigoItem)
        Me.UiGroupBox1.Controls.Add(Me.lblCodigoItem)
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
        Me.txtCodigoItem.Location = New System.Drawing.Point(6, 33)
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
        Me.lblCodigoItem.Location = New System.Drawing.Point(3, 16)
        Me.lblCodigoItem.Name = "lblCodigoItem"
        Me.lblCodigoItem.Size = New System.Drawing.Size(65, 14)
        Me.lblCodigoItem.TabIndex = 9
        Me.lblCodigoItem.Text = "Código Item:"
        '
        'grdListagemPesquisar
        '
        Me.grdListagemPesquisar.AlternatingColors = True
        Me.grdListagemPesquisar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagemPesquisar_DesignTimeLayout.LayoutString = resources.GetString("grdListagemPesquisar_DesignTimeLayout.LayoutString")
        Me.grdListagemPesquisar.DesignTimeLayout = grdListagemPesquisar_DesignTimeLayout
        Me.grdListagemPesquisar.DynamicFiltering = True
        Me.grdListagemPesquisar.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemPesquisar.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagemPesquisar.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemPesquisar.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemPesquisar.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemPesquisar.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemPesquisar.GroupByBoxVisible = False
        Me.grdListagemPesquisar.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagemPesquisar.Location = New System.Drawing.Point(8, 70)
        Me.grdListagemPesquisar.Name = "grdListagemPesquisar"
        Me.grdListagemPesquisar.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemPesquisar.RecordNavigator = True
        Me.grdListagemPesquisar.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemPesquisar.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemPesquisar.Size = New System.Drawing.Size(966, 359)
        Me.grdListagemPesquisar.TabIndex = 45
        Me.grdListagemPesquisar.TabStop = False
        Me.grdListagemPesquisar.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemPesquisar.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemPesquisar.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemPesquisar.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 435)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(966, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
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
        'frmCadProdutoBOMPesquisar
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
        Me.Name = "frmCadProdutoBOMPesquisar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produto - BOM"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdListagemPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtMotivo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grdListagemPesquisar As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCodigoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoItem As System.Windows.Forms.Label
    Friend WithEvents btnExcelListagemRequisicao As System.Windows.Forms.Button
End Class
