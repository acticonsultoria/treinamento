<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindItemVenda
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
        Dim grdFind_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindItemVenda))
        Dim grdItensSimilares_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPedidoVenda_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdFind = New Janus.Windows.GridEX.GridEX()
        Me.grdItensSimilares = New Janus.Windows.GridEX.GridEX()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.btnExcelGridItensSimilares = New System.Windows.Forms.Button()
        Me.btnAgruparGridItensSimilares = New System.Windows.Forms.Button()
        Me.btnConfigurarGridItensSimilares = New System.Windows.Forms.Button()
        Me.pagVenda = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridPedido = New System.Windows.Forms.Button()
        Me.btnAgruparGridPedido = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPedido = New System.Windows.Forms.Button()
        Me.grdPedidoVenda = New Janus.Windows.GridEX.GridEX()
        Me.pagOrcamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridOrcamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridOrcamento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridOrcamento = New System.Windows.Forms.Button()
        Me.grdOrcamento = New Janus.Windows.GridEX.GridEX()
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdItensSimilares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagProduto.SuspendLayout()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        Me.pagVenda.SuspendLayout()
        CType(Me.grdPedidoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagOrcamento.SuspendLayout()
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grdFind
        '
        Me.grdFind.AlternatingColors = True
        Me.grdFind.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdFind.AutoEdit = True
        grdFind_DesignTimeLayout.LayoutString = resources.GetString("grdFind_DesignTimeLayout.LayoutString")
        Me.grdFind.DesignTimeLayout = grdFind_DesignTimeLayout
        Me.grdFind.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdFind.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdFind.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdFind.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdFind.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdFind.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdFind.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdFind.GroupByBoxVisible = False
        Me.grdFind.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdFind.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdFind.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdFind.Hierarchical = True
        Me.grdFind.Location = New System.Drawing.Point(8, 0)
        Me.grdFind.Name = "grdFind"
        Me.grdFind.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdFind.RecordNavigator = True
        Me.grdFind.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdFind.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdFind.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdFind.Size = New System.Drawing.Size(879, 216)
        Me.grdFind.TabIndex = 2
        Me.grdFind.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdFind.VisualStyleManager = Me.vsmMain
        '
        'grdItensSimilares
        '
        Me.grdItensSimilares.AlternatingColors = True
        Me.grdItensSimilares.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItensSimilares.AutoEdit = True
        grdItensSimilares_DesignTimeLayout.LayoutString = resources.GetString("grdItensSimilares_DesignTimeLayout.LayoutString")
        Me.grdItensSimilares.DesignTimeLayout = grdItensSimilares_DesignTimeLayout
        Me.grdItensSimilares.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdItensSimilares.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdItensSimilares.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdItensSimilares.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdItensSimilares.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdItensSimilares.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdItensSimilares.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdItensSimilares.GroupByBoxVisible = False
        Me.grdItensSimilares.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdItensSimilares.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdItensSimilares.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItensSimilares.Hierarchical = True
        Me.grdItensSimilares.Location = New System.Drawing.Point(8, 3)
        Me.grdItensSimilares.Name = "grdItensSimilares"
        Me.grdItensSimilares.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdItensSimilares.RecordNavigator = True
        Me.grdItensSimilares.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdItensSimilares.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItensSimilares.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdItensSimilares.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdItensSimilares.Size = New System.Drawing.Size(879, 187)
        Me.grdItensSimilares.TabIndex = 0
        Me.grdItensSimilares.TabStop = False
        Me.grdItensSimilares.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdItensSimilares.VisualStyleManager = Me.vsmMain
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 11)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 453)
        Me.tabDados.TabIndex = 4
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagProduto, Me.pagVenda, Me.pagOrcamento})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagProduto
        '
        Me.pagProduto.Controls.Add(Me.spcMain)
        Me.pagProduto.Key = "pagProduto"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Padding = New System.Windows.Forms.Padding(0, 9, 0, 8)
        Me.pagProduto.Size = New System.Drawing.Size(895, 430)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Lista de Produtos"
        '
        'spcMain
        '
        Me.spcMain.BackColor = System.Drawing.Color.Transparent
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.Location = New System.Drawing.Point(0, 9)
        Me.spcMain.Name = "spcMain"
        Me.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcMain.Panel1
        '
        Me.spcMain.Panel1.Controls.Add(Me.btnExcelGrid)
        Me.spcMain.Panel1.Controls.Add(Me.btnAgruparGrid)
        Me.spcMain.Panel1.Controls.Add(Me.btnConfigurarGrid)
        Me.spcMain.Panel1.Controls.Add(Me.grdFind)
        '
        'spcMain.Panel2
        '
        Me.spcMain.Panel2.Controls.Add(Me.btnExcelGridItensSimilares)
        Me.spcMain.Panel2.Controls.Add(Me.btnAgruparGridItensSimilares)
        Me.spcMain.Panel2.Controls.Add(Me.btnConfigurarGridItensSimilares)
        Me.spcMain.Panel2.Controls.Add(Me.grdItensSimilares)
        Me.spcMain.Size = New System.Drawing.Size(895, 413)
        Me.spcMain.SplitterDistance = 218
        Me.spcMain.TabIndex = 39
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 199)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 38
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 199)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 37
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 199)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 36
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'btnExcelGridItensSimilares
        '
        Me.btnExcelGridItensSimilares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridItensSimilares.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridItensSimilares.FlatAppearance.BorderSize = 0
        Me.btnExcelGridItensSimilares.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridItensSimilares.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridItensSimilares.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridItensSimilares.Location = New System.Drawing.Point(57, 173)
        Me.btnExcelGridItensSimilares.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridItensSimilares.Name = "btnExcelGridItensSimilares"
        Me.btnExcelGridItensSimilares.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridItensSimilares.TabIndex = 35
        Me.btnExcelGridItensSimilares.TabStop = False
        Me.btnExcelGridItensSimilares.UseVisualStyleBackColor = False
        '
        'btnAgruparGridItensSimilares
        '
        Me.btnAgruparGridItensSimilares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridItensSimilares.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridItensSimilares.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridItensSimilares.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridItensSimilares.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridItensSimilares.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridItensSimilares.Location = New System.Drawing.Point(33, 173)
        Me.btnAgruparGridItensSimilares.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridItensSimilares.Name = "btnAgruparGridItensSimilares"
        Me.btnAgruparGridItensSimilares.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridItensSimilares.TabIndex = 34
        Me.btnAgruparGridItensSimilares.TabStop = False
        Me.btnAgruparGridItensSimilares.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridItensSimilares
        '
        Me.btnConfigurarGridItensSimilares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridItensSimilares.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridItensSimilares.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridItensSimilares.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridItensSimilares.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridItensSimilares.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridItensSimilares.Location = New System.Drawing.Point(9, 173)
        Me.btnConfigurarGridItensSimilares.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridItensSimilares.Name = "btnConfigurarGridItensSimilares"
        Me.btnConfigurarGridItensSimilares.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridItensSimilares.TabIndex = 33
        Me.btnConfigurarGridItensSimilares.TabStop = False
        Me.btnConfigurarGridItensSimilares.UseVisualStyleBackColor = False
        '
        'pagVenda
        '
        Me.pagVenda.Controls.Add(Me.btnExcelGridPedido)
        Me.pagVenda.Controls.Add(Me.btnAgruparGridPedido)
        Me.pagVenda.Controls.Add(Me.btnConfigurarGridPedido)
        Me.pagVenda.Controls.Add(Me.grdPedidoVenda)
        Me.pagVenda.Key = "pagVenda"
        Me.pagVenda.Location = New System.Drawing.Point(1, 22)
        Me.pagVenda.Name = "pagVenda"
        Me.pagVenda.Size = New System.Drawing.Size(895, 430)
        Me.pagVenda.TabStop = True
        Me.pagVenda.Text = "Vendas"
        '
        'btnExcelGridPedido
        '
        Me.btnExcelGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPedido.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPedido.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPedido.Location = New System.Drawing.Point(57, 404)
        Me.btnExcelGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPedido.Name = "btnExcelGridPedido"
        Me.btnExcelGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPedido.TabIndex = 35
        Me.btnExcelGridPedido.TabStop = False
        Me.btnExcelGridPedido.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPedido
        '
        Me.btnAgruparGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPedido.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPedido.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPedido.Location = New System.Drawing.Point(33, 404)
        Me.btnAgruparGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPedido.Name = "btnAgruparGridPedido"
        Me.btnAgruparGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPedido.TabIndex = 34
        Me.btnAgruparGridPedido.TabStop = False
        Me.btnAgruparGridPedido.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPedido
        '
        Me.btnConfigurarGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPedido.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPedido.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPedido.Location = New System.Drawing.Point(9, 404)
        Me.btnConfigurarGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPedido.Name = "btnConfigurarGridPedido"
        Me.btnConfigurarGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPedido.TabIndex = 33
        Me.btnConfigurarGridPedido.TabStop = False
        Me.btnConfigurarGridPedido.UseVisualStyleBackColor = False
        '
        'grdPedidoVenda
        '
        Me.grdPedidoVenda.AlternatingColors = True
        Me.grdPedidoVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPedidoVenda.AutoEdit = True
        grdPedidoVenda_DesignTimeLayout.LayoutString = resources.GetString("grdPedidoVenda_DesignTimeLayout.LayoutString")
        Me.grdPedidoVenda.DesignTimeLayout = grdPedidoVenda_DesignTimeLayout
        Me.grdPedidoVenda.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdPedidoVenda.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedidoVenda.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedidoVenda.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedidoVenda.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedidoVenda.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPedidoVenda.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedidoVenda.GroupByBoxVisible = False
        Me.grdPedidoVenda.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPedidoVenda.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdPedidoVenda.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVenda.Hierarchical = True
        Me.grdPedidoVenda.Location = New System.Drawing.Point(8, 9)
        Me.grdPedidoVenda.Name = "grdPedidoVenda"
        Me.grdPedidoVenda.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedidoVenda.RecordNavigator = True
        Me.grdPedidoVenda.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdPedidoVenda.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVenda.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdPedidoVenda.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPedidoVenda.Size = New System.Drawing.Size(879, 412)
        Me.grdPedidoVenda.TabIndex = 36
        Me.grdPedidoVenda.TabStop = False
        Me.grdPedidoVenda.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVenda.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPedidoVenda.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedidoVenda.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedidoVenda.VisualStyleManager = Me.vsmMain
        '
        'pagOrcamento
        '
        Me.pagOrcamento.Controls.Add(Me.btnExcelGridOrcamento)
        Me.pagOrcamento.Controls.Add(Me.btnAgruparGridOrcamento)
        Me.pagOrcamento.Controls.Add(Me.btnConfigurarGridOrcamento)
        Me.pagOrcamento.Controls.Add(Me.grdOrcamento)
        Me.pagOrcamento.Key = "pagOrcamento"
        Me.pagOrcamento.Location = New System.Drawing.Point(1, 22)
        Me.pagOrcamento.Name = "pagOrcamento"
        Me.pagOrcamento.Size = New System.Drawing.Size(895, 430)
        Me.pagOrcamento.TabStop = True
        Me.pagOrcamento.Text = "Orçamentos"
        '
        'btnExcelGridOrcamento
        '
        Me.btnExcelGridOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridOrcamento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridOrcamento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridOrcamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridOrcamento.Location = New System.Drawing.Point(57, 404)
        Me.btnExcelGridOrcamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridOrcamento.Name = "btnExcelGridOrcamento"
        Me.btnExcelGridOrcamento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridOrcamento.TabIndex = 35
        Me.btnExcelGridOrcamento.TabStop = False
        Me.btnExcelGridOrcamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridOrcamento
        '
        Me.btnAgruparGridOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridOrcamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridOrcamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridOrcamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridOrcamento.Location = New System.Drawing.Point(33, 404)
        Me.btnAgruparGridOrcamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridOrcamento.Name = "btnAgruparGridOrcamento"
        Me.btnAgruparGridOrcamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridOrcamento.TabIndex = 34
        Me.btnAgruparGridOrcamento.TabStop = False
        Me.btnAgruparGridOrcamento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridOrcamento
        '
        Me.btnConfigurarGridOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridOrcamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridOrcamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridOrcamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridOrcamento.Location = New System.Drawing.Point(9, 404)
        Me.btnConfigurarGridOrcamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridOrcamento.Name = "btnConfigurarGridOrcamento"
        Me.btnConfigurarGridOrcamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridOrcamento.TabIndex = 33
        Me.btnConfigurarGridOrcamento.TabStop = False
        Me.btnConfigurarGridOrcamento.UseVisualStyleBackColor = False
        '
        'grdOrcamento
        '
        Me.grdOrcamento.AlternatingColors = True
        Me.grdOrcamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdOrcamento.AutoEdit = True
        grdOrcamento_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamento_DesignTimeLayout.LayoutString")
        Me.grdOrcamento.DesignTimeLayout = grdOrcamento_DesignTimeLayout
        Me.grdOrcamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdOrcamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdOrcamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamento.GroupByBoxVisible = False
        Me.grdOrcamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamento.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdOrcamento.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamento.Hierarchical = True
        Me.grdOrcamento.Location = New System.Drawing.Point(8, 9)
        Me.grdOrcamento.Name = "grdOrcamento"
        Me.grdOrcamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamento.RecordNavigator = True
        Me.grdOrcamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdOrcamento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamento.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdOrcamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamento.Size = New System.Drawing.Size(879, 412)
        Me.grdOrcamento.TabIndex = 4
        Me.grdOrcamento.TabStop = False
        Me.grdOrcamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamento.VisualStyleManager = Me.vsmMain
        '
        'frmFindItemVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 472)
        Me.Controls.Add(Me.tabDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindItemVenda"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Procurar Item"
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdItensSimilares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagProduto.ResumeLayout(False)
        Me.spcMain.Panel1.ResumeLayout(False)
        Me.spcMain.Panel2.ResumeLayout(False)
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        Me.pagVenda.ResumeLayout(False)
        CType(Me.grdPedidoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagOrcamento.ResumeLayout(False)
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grdFind As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdItensSimilares As Janus.Windows.GridEX.GridEX
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagOrcamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdOrcamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagVenda As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelGridItensSimilares As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridItensSimilares As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridItensSimilares As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridOrcamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridOrcamento As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridOrcamento As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridPedido As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPedido As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPedido As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdPedidoVenda As Janus.Windows.GridEX.GridEX
    Friend WithEvents spcMain As System.Windows.Forms.SplitContainer
End Class
