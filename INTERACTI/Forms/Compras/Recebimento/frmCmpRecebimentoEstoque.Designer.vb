<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpRecebimentoEstoque
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
        Dim grdEstoque_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEstoque_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpRecebimentoEstoque))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.pagLote = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidadeProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeProduto = New System.Windows.Forms.Label()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.grpSalvarLote = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.grdEstoque = New Janus.Windows.GridEX.GridEX()
        Me.grpEstoque = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.pagLote.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        CType(Me.grpSalvarLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSalvarLote.SuspendLayout()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEstoque.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
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
        'pagLote
        '
        Me.pagLote.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLote.Controls.Add(Me.grpProduto)
        Me.pagLote.Controls.Add(Me.grpSalvarLote)
        Me.pagLote.Controls.Add(Me.grdEstoque)
        Me.pagLote.Controls.Add(Me.grpEstoque)
        Me.pagLote.Location = New System.Drawing.Point(1, 22)
        Me.pagLote.Name = "pagLote"
        Me.pagLote.Size = New System.Drawing.Size(823, 422)
        Me.pagLote.TabStop = True
        Me.pagLote.Text = "Dados do Estoque"
        '
        'grpProduto
        '
        Me.grpProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.txtQuantidadeProduto)
        Me.grpProduto.Controls.Add(Me.lblQuantidadeProduto)
        Me.grpProduto.Controls.Add(Me.txtProduto)
        Me.grpProduto.Controls.Add(Me.lblProduto)
        Me.grpProduto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProduto.Location = New System.Drawing.Point(8, 4)
        Me.grpProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(807, 66)
        Me.grpProduto.TabIndex = 0
        Me.grpProduto.Text = "Identificação do Produto"
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidadeProduto
        '
        Me.txtQuantidadeProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeProduto.DecimalDigits = 4
        Me.txtQuantidadeProduto.Location = New System.Drawing.Point(698, 37)
        Me.txtQuantidadeProduto.Name = "txtQuantidadeProduto"
        Me.txtQuantidadeProduto.ReadOnly = True
        Me.txtQuantidadeProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeProduto.TabIndex = 3
        Me.txtQuantidadeProduto.TabStop = False
        Me.txtQuantidadeProduto.Text = "0,0000"
        Me.txtQuantidadeProduto.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeProduto
        '
        Me.lblQuantidadeProduto.AutoSize = True
        Me.lblQuantidadeProduto.Location = New System.Drawing.Point(695, 20)
        Me.lblQuantidadeProduto.Name = "lblQuantidadeProduto"
        Me.lblQuantidadeProduto.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeProduto.TabIndex = 2
        Me.lblQuantidadeProduto.Text = "Quantidade:"
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(9, 37)
        Me.txtProduto.MaxLength = 250
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(683, 20)
        Me.txtProduto.TabIndex = 1
        Me.txtProduto.TabStop = False
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(6, 20)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 0
        Me.lblProduto.Text = "Produto:"
        '
        'grpSalvarLote
        '
        Me.grpSalvarLote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSalvarLote.BackColor = System.Drawing.Color.Transparent
        Me.grpSalvarLote.Controls.Add(Me.btnVoltar)
        Me.grpSalvarLote.Location = New System.Drawing.Point(8, 362)
        Me.grpSalvarLote.Name = "grpSalvarLote"
        Me.grpSalvarLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSalvarLote.Size = New System.Drawing.Size(807, 51)
        Me.grpSalvarLote.TabIndex = 4
        Me.grpSalvarLote.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpSalvarLote.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(707, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 0
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdEstoque
        '
        Me.grdEstoque.AllowDrop = True
        Me.grdEstoque.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEstoque.AlternatingColors = True
        Me.grdEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdEstoque.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdEstoque_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdEstoque_DesignTimeLayout_Reference_0.Instance"), Object)
        grdEstoque_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdEstoque_DesignTimeLayout_Reference_0})
        grdEstoque_DesignTimeLayout.LayoutString = resources.GetString("grdEstoque_DesignTimeLayout.LayoutString")
        Me.grdEstoque.DesignTimeLayout = grdEstoque_DesignTimeLayout
        Me.grdEstoque.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdEstoque.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdEstoque.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdEstoque.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdEstoque.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEstoque.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEstoque.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEstoque.FrozenColumns = 3
        Me.grdEstoque.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEstoque.GroupByBoxVisible = False
        Me.grdEstoque.Location = New System.Drawing.Point(8, 149)
        Me.grdEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdEstoque.Name = "grdEstoque"
        Me.grdEstoque.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEstoque.RecordNavigator = True
        Me.grdEstoque.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdEstoque.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEstoque.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEstoque.Size = New System.Drawing.Size(807, 210)
        Me.grdEstoque.TabIndex = 2
        Me.grdEstoque.TabStop = False
        Me.grdEstoque.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdEstoque.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdEstoque.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdEstoque.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdEstoque.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEstoque.VisualStyleManager = Me.vsmMain
        '
        'grpEstoque
        '
        Me.grpEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEstoque.BackColor = System.Drawing.Color.Transparent
        Me.grpEstoque.Controls.Add(Me.txtLote)
        Me.grpEstoque.Controls.Add(Me.cboDeposito)
        Me.grpEstoque.Controls.Add(Me.txtQuantidade)
        Me.grpEstoque.Controls.Add(Me.lblQuantidade)
        Me.grpEstoque.Controls.Add(Me.btnExcluir)
        Me.grpEstoque.Controls.Add(Me.btnInserir)
        Me.grpEstoque.Controls.Add(Me.lblLote)
        Me.grpEstoque.Controls.Add(Me.lblDeposito)
        Me.grpEstoque.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEstoque.Location = New System.Drawing.Point(8, 73)
        Me.grpEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEstoque.Name = "grpEstoque"
        Me.grpEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEstoque.Size = New System.Drawing.Size(807, 67)
        Me.grpEstoque.TabIndex = 1
        Me.grpEstoque.Text = "Dados de Movimentação do Estoque"
        Me.grpEstoque.VisualStyleManager = Me.vsmMain
        '
        'cboDeposito
        '
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(9, 37)
        Me.cboDeposito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(261, 20)
        Me.cboDeposito.TabIndex = 1
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(276, 37)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 3
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(273, 20)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 2
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(707, 34)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(610, 34)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 6
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(379, 20)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 4
        Me.lblLote.Text = "Lote:"
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.Location = New System.Drawing.Point(6, 20)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 0
        Me.lblDeposito.Text = "Depósito:"
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
        Me.tabMain.Size = New System.Drawing.Size(825, 445)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLote})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(382, 37)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(192, 20)
        Me.txtLote.TabIndex = 5
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 342)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(49, 15)
        Me.btnConfigurarGrid.TabIndex = 3
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'frmCmpRecebimentoEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 460)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCmpRecebimentoEstoque"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recebimento - Dados do Estoque"
        Me.pagLote.ResumeLayout(False)
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        CType(Me.grpSalvarLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSalvarLote.ResumeLayout(False)
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEstoque.ResumeLayout(False)
        Me.grpEstoque.PerformLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagLote As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpSalvarLote As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdEstoque As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpEstoque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Private WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidadeProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeProduto As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
End Class
