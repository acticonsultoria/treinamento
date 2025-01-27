<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdAnaliseProducaoSeng
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdAnaliseProducaoSeng))
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRequisicao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdBeneficiamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdResumo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagItem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagApontamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.pagRequisicao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdRequisicao = New Janus.Windows.GridEX.GridEX()
        Me.pagBeneficiamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdBeneficiamento = New Janus.Windows.GridEX.GridEX()
        Me.pagResumo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdResumo = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.lblCodigoItemFiltro = New System.Windows.Forms.Label()
        Me.cboCodigoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPedidoVendaFiltro = New System.Windows.Forms.Label()
        Me.cboPedidoVendaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.btnExcelGridBeneficiamento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridBeneficiamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridBeneficiamento = New System.Windows.Forms.Button()
        Me.btnExcelGridRequisicao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRequisicao = New System.Windows.Forms.Button()
        Me.btnAgruparGridRequisicao = New System.Windows.Forms.Button()
        Me.btnExcelGridApontamento = New System.Windows.Forms.Button()
        Me.btnConfiguraGridApontamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridApontamento = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagItem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagApontamento.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagRequisicao.SuspendLayout()
        CType(Me.grdRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagBeneficiamento.SuspendLayout()
        CType(Me.grdBeneficiamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagResumo.SuspendLayout()
        CType(Me.grdResumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1120, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.tabDados)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpEntrega)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(1118, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Análise de Produção"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 83)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(1102, 389)
        Me.tabDados.TabIndex = 105
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagItem, Me.pagApontamento, Me.pagRequisicao, Me.pagBeneficiamento, Me.pagResumo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagItem
        '
        Me.pagItem.Controls.Add(Me.btnExcelGrid)
        Me.pagItem.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagItem.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagItem.Controls.Add(Me.grdListagem)
        Me.pagItem.Key = "pagItem"
        Me.pagItem.Location = New System.Drawing.Point(1, 22)
        Me.pagItem.Name = "pagItem"
        Me.pagItem.Size = New System.Drawing.Size(1100, 366)
        Me.pagItem.TabStop = True
        Me.pagItem.Text = "Acompanhamento"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(51, 346)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 16)
        Me.btnExcelGrid.TabIndex = 4
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(3, 346)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 16)
        Me.btnConfigurarGridProduto.TabIndex = 2
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridProduto
        '
        Me.btnAgruparGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridProduto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridProduto.Location = New System.Drawing.Point(27, 346)
        Me.btnAgruparGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProduto.Name = "btnAgruparGridProduto"
        Me.btnAgruparGridProduto.Size = New System.Drawing.Size(24, 16)
        Me.btnAgruparGridProduto.TabIndex = 3
        Me.btnAgruparGridProduto.TabStop = False
        Me.btnAgruparGridProduto.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(3, 3)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1094, 360)
        Me.grdListagem.TabIndex = 104
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagApontamento
        '
        Me.pagApontamento.Controls.Add(Me.btnExcelGridApontamento)
        Me.pagApontamento.Controls.Add(Me.btnConfiguraGridApontamento)
        Me.pagApontamento.Controls.Add(Me.btnAgruparGridApontamento)
        Me.pagApontamento.Controls.Add(Me.grdApontamento)
        Me.pagApontamento.Key = "pagApontamento"
        Me.pagApontamento.Location = New System.Drawing.Point(1, 22)
        Me.pagApontamento.Name = "pagApontamento"
        Me.pagApontamento.Size = New System.Drawing.Size(1100, 366)
        Me.pagApontamento.TabStop = True
        Me.pagApontamento.Text = "Apontamento"
        '
        'grdApontamento
        '
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdApontamento.AutoEdit = True
        Me.grdApontamento.ColumnAutoResize = True
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdApontamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdApontamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdApontamento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.Location = New System.Drawing.Point(3, 3)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.RecordNavigator = True
        Me.grdApontamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdApontamento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(1094, 360)
        Me.grdApontamento.TabIndex = 105
        Me.grdApontamento.TabStop = False
        Me.grdApontamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdApontamento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdApontamento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
        '
        'pagRequisicao
        '
        Me.pagRequisicao.Controls.Add(Me.btnExcelGridRequisicao)
        Me.pagRequisicao.Controls.Add(Me.btnConfigurarGridRequisicao)
        Me.pagRequisicao.Controls.Add(Me.btnAgruparGridRequisicao)
        Me.pagRequisicao.Controls.Add(Me.grdRequisicao)
        Me.pagRequisicao.Key = "pagRequisicao"
        Me.pagRequisicao.Location = New System.Drawing.Point(1, 22)
        Me.pagRequisicao.Name = "pagRequisicao"
        Me.pagRequisicao.Size = New System.Drawing.Size(1100, 366)
        Me.pagRequisicao.TabStop = True
        Me.pagRequisicao.Text = "Requisição"
        '
        'grdRequisicao
        '
        Me.grdRequisicao.AlternatingColors = True
        Me.grdRequisicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRequisicao.AutoEdit = True
        grdRequisicao_DesignTimeLayout.LayoutString = resources.GetString("grdRequisicao_DesignTimeLayout.LayoutString")
        Me.grdRequisicao.DesignTimeLayout = grdRequisicao_DesignTimeLayout
        Me.grdRequisicao.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdRequisicao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdRequisicao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdRequisicao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdRequisicao.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdRequisicao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRequisicao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRequisicao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRequisicao.GroupByBoxVisible = False
        Me.grdRequisicao.Location = New System.Drawing.Point(3, 3)
        Me.grdRequisicao.Name = "grdRequisicao"
        Me.grdRequisicao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRequisicao.RecordNavigator = True
        Me.grdRequisicao.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdRequisicao.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRequisicao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRequisicao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRequisicao.Size = New System.Drawing.Size(1094, 360)
        Me.grdRequisicao.TabIndex = 106
        Me.grdRequisicao.TabStop = False
        Me.grdRequisicao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRequisicao.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdRequisicao.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdRequisicao.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdRequisicao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRequisicao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRequisicao.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdRequisicao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRequisicao.VisualStyleManager = Me.vsmMain
        '
        'pagBeneficiamento
        '
        Me.pagBeneficiamento.Controls.Add(Me.btnExcelGridBeneficiamento)
        Me.pagBeneficiamento.Controls.Add(Me.btnConfigurarGridBeneficiamento)
        Me.pagBeneficiamento.Controls.Add(Me.btnAgruparGridBeneficiamento)
        Me.pagBeneficiamento.Controls.Add(Me.grdBeneficiamento)
        Me.pagBeneficiamento.Key = "pagBeneficiamento"
        Me.pagBeneficiamento.Location = New System.Drawing.Point(1, 22)
        Me.pagBeneficiamento.Name = "pagBeneficiamento"
        Me.pagBeneficiamento.Size = New System.Drawing.Size(1100, 366)
        Me.pagBeneficiamento.TabStop = True
        Me.pagBeneficiamento.Text = "Beneficiamento"
        '
        'grdBeneficiamento
        '
        Me.grdBeneficiamento.AlternatingColors = True
        Me.grdBeneficiamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBeneficiamento.AutoEdit = True
        grdBeneficiamento_DesignTimeLayout.LayoutString = resources.GetString("grdBeneficiamento_DesignTimeLayout.LayoutString")
        Me.grdBeneficiamento.DesignTimeLayout = grdBeneficiamento_DesignTimeLayout
        Me.grdBeneficiamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdBeneficiamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdBeneficiamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdBeneficiamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdBeneficiamento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdBeneficiamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdBeneficiamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdBeneficiamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdBeneficiamento.GroupByBoxVisible = False
        Me.grdBeneficiamento.Location = New System.Drawing.Point(3, 3)
        Me.grdBeneficiamento.Name = "grdBeneficiamento"
        Me.grdBeneficiamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdBeneficiamento.RecordNavigator = True
        Me.grdBeneficiamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdBeneficiamento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdBeneficiamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdBeneficiamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdBeneficiamento.Size = New System.Drawing.Size(1094, 360)
        Me.grdBeneficiamento.TabIndex = 107
        Me.grdBeneficiamento.TabStop = False
        Me.grdBeneficiamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdBeneficiamento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdBeneficiamento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdBeneficiamento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdBeneficiamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdBeneficiamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdBeneficiamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdBeneficiamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdBeneficiamento.VisualStyleManager = Me.vsmMain
        '
        'pagResumo
        '
        Me.pagResumo.Controls.Add(Me.grdResumo)
        Me.pagResumo.Key = "pagResumo"
        Me.pagResumo.Location = New System.Drawing.Point(1, 22)
        Me.pagResumo.Name = "pagResumo"
        Me.pagResumo.Size = New System.Drawing.Size(1100, 366)
        Me.pagResumo.TabStop = True
        Me.pagResumo.Text = "Resumo"
        '
        'grdResumo
        '
        Me.grdResumo.AlternatingColors = True
        Me.grdResumo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdResumo.AutoEdit = True
        grdResumo_DesignTimeLayout.LayoutString = resources.GetString("grdResumo_DesignTimeLayout.LayoutString")
        Me.grdResumo.DesignTimeLayout = grdResumo_DesignTimeLayout
        Me.grdResumo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdResumo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdResumo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdResumo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdResumo.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdResumo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdResumo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdResumo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdResumo.GroupByBoxVisible = False
        Me.grdResumo.Location = New System.Drawing.Point(3, 3)
        Me.grdResumo.Name = "grdResumo"
        Me.grdResumo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdResumo.RecordNavigator = True
        Me.grdResumo.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdResumo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdResumo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdResumo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdResumo.Size = New System.Drawing.Size(1094, 357)
        Me.grdResumo.TabIndex = 108
        Me.grdResumo.TabStop = False
        Me.grdResumo.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdResumo.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdResumo.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdResumo.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdResumo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdResumo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdResumo.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdResumo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdResumo.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarProduto)
        Me.grpFiltro.Controls.Add(Me.lblCodigoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCodigoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1102, 74)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(752, 21)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 5
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        Me.btnProcurarProduto.Visible = False
        '
        'lblCodigoItemFiltro
        '
        Me.lblCodigoItemFiltro.AutoSize = True
        Me.lblCodigoItemFiltro.Location = New System.Drawing.Point(166, 21)
        Me.lblCodigoItemFiltro.Name = "lblCodigoItemFiltro"
        Me.lblCodigoItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblCodigoItemFiltro.TabIndex = 2
        Me.lblCodigoItemFiltro.Text = "Item:"
        '
        'cboCodigoItemFiltro
        '
        Me.cboCodigoItemFiltro.AutoSize = False
        Me.cboCodigoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoItemFiltro.Location = New System.Drawing.Point(169, 38)
        Me.cboCodigoItemFiltro.Name = "cboCodigoItemFiltro"
        Me.cboCodigoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoItemFiltro.Size = New System.Drawing.Size(600, 20)
        Me.cboCodigoItemFiltro.TabIndex = 3
        '
        'lblPedidoVendaFiltro
        '
        Me.lblPedidoVendaFiltro.AutoSize = True
        Me.lblPedidoVendaFiltro.Location = New System.Drawing.Point(6, 21)
        Me.lblPedidoVendaFiltro.Name = "lblPedidoVendaFiltro"
        Me.lblPedidoVendaFiltro.Size = New System.Drawing.Size(106, 14)
        Me.lblPedidoVendaFiltro.TabIndex = 0
        Me.lblPedidoVendaFiltro.Text = "Nº Pedido de Venda:"
        '
        'cboPedidoVendaFiltro
        '
        Me.cboPedidoVendaFiltro.AutoSize = False
        Me.cboPedidoVendaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPedidoVendaFiltro.Location = New System.Drawing.Point(9, 38)
        Me.cboPedidoVendaFiltro.Name = "cboPedidoVendaFiltro"
        Me.cboPedidoVendaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPedidoVendaFiltro.Size = New System.Drawing.Size(154, 20)
        Me.cboPedidoVendaFiltro.TabIndex = 1
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(1002, 35)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.btnSair)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(8, 470)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(1102, 64)
        Me.grpEntrega.TabIndex = 5
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(1002, 31)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 60000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.ShowAlways = True
        '
        'btnExcelGridBeneficiamento
        '
        Me.btnExcelGridBeneficiamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridBeneficiamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridBeneficiamento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridBeneficiamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridBeneficiamento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridBeneficiamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridBeneficiamento.Location = New System.Drawing.Point(52, 346)
        Me.btnExcelGridBeneficiamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridBeneficiamento.Name = "btnExcelGridBeneficiamento"
        Me.btnExcelGridBeneficiamento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridBeneficiamento.TabIndex = 110
        Me.btnExcelGridBeneficiamento.TabStop = False
        Me.btnExcelGridBeneficiamento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridBeneficiamento
        '
        Me.btnConfigurarGridBeneficiamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridBeneficiamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridBeneficiamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridBeneficiamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridBeneficiamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridBeneficiamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridBeneficiamento.Location = New System.Drawing.Point(5, 346)
        Me.btnConfigurarGridBeneficiamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridBeneficiamento.Name = "btnConfigurarGridBeneficiamento"
        Me.btnConfigurarGridBeneficiamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridBeneficiamento.TabIndex = 109
        Me.btnConfigurarGridBeneficiamento.TabStop = False
        Me.btnConfigurarGridBeneficiamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridBeneficiamento
        '
        Me.btnAgruparGridBeneficiamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridBeneficiamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridBeneficiamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridBeneficiamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridBeneficiamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridBeneficiamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridBeneficiamento.Location = New System.Drawing.Point(28, 346)
        Me.btnAgruparGridBeneficiamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridBeneficiamento.Name = "btnAgruparGridBeneficiamento"
        Me.btnAgruparGridBeneficiamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridBeneficiamento.TabIndex = 108
        Me.btnAgruparGridBeneficiamento.TabStop = False
        Me.btnAgruparGridBeneficiamento.UseVisualStyleBackColor = False
        '
        'btnExcelGridRequisicao
        '
        Me.btnExcelGridRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridRequisicao.FlatAppearance.BorderSize = 0
        Me.btnExcelGridRequisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridRequisicao.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridRequisicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridRequisicao.Location = New System.Drawing.Point(52, 346)
        Me.btnExcelGridRequisicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridRequisicao.Name = "btnExcelGridRequisicao"
        Me.btnExcelGridRequisicao.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridRequisicao.TabIndex = 113
        Me.btnExcelGridRequisicao.TabStop = False
        Me.btnExcelGridRequisicao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridRequisicao
        '
        Me.btnConfigurarGridRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridRequisicao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridRequisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridRequisicao.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridRequisicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridRequisicao.Location = New System.Drawing.Point(4, 346)
        Me.btnConfigurarGridRequisicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridRequisicao.Name = "btnConfigurarGridRequisicao"
        Me.btnConfigurarGridRequisicao.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridRequisicao.TabIndex = 112
        Me.btnConfigurarGridRequisicao.TabStop = False
        Me.btnConfigurarGridRequisicao.UseVisualStyleBackColor = False
        '
        'btnAgruparGridRequisicao
        '
        Me.btnAgruparGridRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridRequisicao.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridRequisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridRequisicao.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridRequisicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridRequisicao.Location = New System.Drawing.Point(28, 346)
        Me.btnAgruparGridRequisicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridRequisicao.Name = "btnAgruparGridRequisicao"
        Me.btnAgruparGridRequisicao.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridRequisicao.TabIndex = 111
        Me.btnAgruparGridRequisicao.TabStop = False
        Me.btnAgruparGridRequisicao.UseVisualStyleBackColor = False
        '
        'btnExcelGridApontamento
        '
        Me.btnExcelGridApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridApontamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridApontamento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridApontamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridApontamento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridApontamento.Location = New System.Drawing.Point(52, 346)
        Me.btnExcelGridApontamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridApontamento.Name = "btnExcelGridApontamento"
        Me.btnExcelGridApontamento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridApontamento.TabIndex = 116
        Me.btnExcelGridApontamento.TabStop = False
        Me.btnExcelGridApontamento.UseVisualStyleBackColor = False
        '
        'btnConfiguraGridApontamento
        '
        Me.btnConfiguraGridApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGridApontamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGridApontamento.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGridApontamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGridApontamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfiguraGridApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGridApontamento.Location = New System.Drawing.Point(4, 346)
        Me.btnConfiguraGridApontamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGridApontamento.Name = "btnConfiguraGridApontamento"
        Me.btnConfiguraGridApontamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGridApontamento.TabIndex = 115
        Me.btnConfiguraGridApontamento.TabStop = False
        Me.btnConfiguraGridApontamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridApontamento
        '
        Me.btnAgruparGridApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridApontamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridApontamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridApontamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridApontamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridApontamento.Location = New System.Drawing.Point(28, 346)
        Me.btnAgruparGridApontamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridApontamento.Name = "btnAgruparGridApontamento"
        Me.btnAgruparGridApontamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridApontamento.TabIndex = 114
        Me.btnAgruparGridApontamento.TabStop = False
        Me.btnAgruparGridApontamento.UseVisualStyleBackColor = False
        '
        'usrPrdAnaliseProducaoSeng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdAnaliseProducaoSeng"
        Me.Size = New System.Drawing.Size(1120, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagItem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagApontamento.ResumeLayout(False)
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagRequisicao.ResumeLayout(False)
        CType(Me.grdRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagBeneficiamento.ResumeLayout(False)
        CType(Me.grdBeneficiamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagResumo.ResumeLayout(False)
        CType(Me.grdResumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntrega.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboPedidoVendaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblPedidoVendaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents lblCodigoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCodigoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagItem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagApontamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagRequisicao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdRequisicao As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagBeneficiamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdBeneficiamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagResumo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdResumo As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridBeneficiamento As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridBeneficiamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridBeneficiamento As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridRequisicao As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridRequisicao As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridRequisicao As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridApontamento As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGridApontamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridApontamento As System.Windows.Forms.Button

End Class
