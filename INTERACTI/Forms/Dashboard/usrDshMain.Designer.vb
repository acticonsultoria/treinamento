<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrDshMain
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
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrDshMain))
        Dim grdProdutosMaisVendidos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ButtonBarGroup1 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBarItem1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBarItem2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBarItem3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBarItem4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBarGroup2 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBarItem5 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBarItem6 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBarItem7 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim ButtonBarItem8 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagMenu = New Janus.Windows.UI.Tab.UITabPage()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblRelatorio = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.grdProdutosMaisVendidos = New Janus.Windows.GridEX.GridEX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.btbMain = New Janus.Windows.ButtonBar.ButtonBar()
        Me.btnProdutosMaisVendidos = New Janus.Windows.EditControls.UIButton()
        Me.btnProdutosMaisVendidosMarca = New Janus.Windows.EditControls.UIButton()
        Me.btnProdutosMaisVendidosVendedor = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagMenu.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProdutosMaisVendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btbMain, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(258, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(742, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagMenu})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagMenu
        '
        Me.pagMenu.Controls.Add(Me.lblData)
        Me.pagMenu.Controls.Add(Me.lblEmpresa)
        Me.pagMenu.Controls.Add(Me.pnlMain)
        Me.pagMenu.Controls.Add(Me.lblRelatorio)
        Me.pagMenu.Controls.Add(Me.picLogo)
        Me.pagMenu.Controls.Add(Me.lblDescricao)
        Me.pagMenu.Controls.Add(Me.GridEX1)
        Me.pagMenu.Controls.Add(Me.grdProdutosMaisVendidos)
        Me.pagMenu.Controls.Add(Me.PictureBox1)
        Me.pagMenu.Key = "pagListagem"
        Me.pagMenu.Location = New System.Drawing.Point(1, 22)
        Me.pagMenu.Name = "pagMenu"
        Me.pagMenu.Padding = New System.Windows.Forms.Padding(8)
        Me.pagMenu.Size = New System.Drawing.Size(740, 543)
        Me.pagMenu.TabStop = True
        Me.pagMenu.Text = "Relatórios"
        '
        'lblData
        '
        Me.lblData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblData.AutoSize = True
        Me.lblData.BackColor = System.Drawing.Color.White
        Me.lblData.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblData.Location = New System.Drawing.Point(599, 75)
        Me.lblData.Name = "lblData"
        Me.lblData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblData.Size = New System.Drawing.Size(0, 28)
        Me.lblData.TabIndex = 33
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.BackColor = System.Drawing.Color.White
        Me.lblEmpresa.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblEmpresa.Location = New System.Drawing.Point(384, 29)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblEmpresa.Size = New System.Drawing.Size(0, 28)
        Me.lblEmpresa.TabIndex = 32
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.Location = New System.Drawing.Point(8, 130)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(724, 404)
        Me.pnlMain.TabIndex = 31
        '
        'lblRelatorio
        '
        Me.lblRelatorio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRelatorio.BackColor = System.Drawing.Color.White
        Me.lblRelatorio.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblRelatorio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRelatorio.Location = New System.Drawing.Point(207, 71)
        Me.lblRelatorio.Name = "lblRelatorio"
        Me.lblRelatorio.Size = New System.Drawing.Size(250, 31)
        Me.lblRelatorio.TabIndex = 30
        Me.lblRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.SystemColors.Window
        Me.picLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picLogo.Location = New System.Drawing.Point(10, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(191, 106)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        SuperTipSettings1.HeaderText = "Logo"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "O Logo selecionado será exibido em todos os relatórios." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seu tamanho será redim" & _
    "ensionado para 40x25mm."
        Me.jstTip.SetSuperTip(Me.picLogo, SuperTipSettings1)
        Me.picLogo.TabIndex = 29
        Me.picLogo.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescricao.BackColor = System.Drawing.Color.White
        Me.lblDescricao.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblDescricao.Location = New System.Drawing.Point(207, 28)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(250, 31)
        Me.lblDescricao.TabIndex = 6
        Me.lblDescricao.Text = "MENU ESPECIAL"
        Me.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEX1_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX1_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX1_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX1_DesignTimeLayout_Reference_0})
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridEX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX1.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.GridEX1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridEX1.FrozenColumns = 1
        Me.GridEX1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(14, 164)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridEX1.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.GridEX1.Size = New System.Drawing.Size(724, 300)
        Me.GridEX1.TabIndex = 4
        Me.GridEX1.TabStop = False
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEX1.Visible = False
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.GridEX1.VisualStyleManager = Me.vsmMain
        '
        'grdProdutosMaisVendidos
        '
        Me.grdProdutosMaisVendidos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProdutosMaisVendidos.AlternatingColors = True
        Me.grdProdutosMaisVendidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdProdutosMaisVendidos_DesignTimeLayout.LayoutString = resources.GetString("grdProdutosMaisVendidos_DesignTimeLayout.LayoutString")
        Me.grdProdutosMaisVendidos.DesignTimeLayout = grdProdutosMaisVendidos_DesignTimeLayout
        Me.grdProdutosMaisVendidos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProdutosMaisVendidos.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProdutosMaisVendidos.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProdutosMaisVendidos.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProdutosMaisVendidos.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProdutosMaisVendidos.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProdutosMaisVendidos.GroupByBoxVisible = False
        Me.grdProdutosMaisVendidos.Location = New System.Drawing.Point(17, 164)
        Me.grdProdutosMaisVendidos.Name = "grdProdutosMaisVendidos"
        Me.grdProdutosMaisVendidos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProdutosMaisVendidos.RecordNavigator = True
        Me.grdProdutosMaisVendidos.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProdutosMaisVendidos.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProdutosMaisVendidos.Size = New System.Drawing.Size(724, 300)
        Me.grdProdutosMaisVendidos.TabIndex = 2
        Me.grdProdutosMaisVendidos.TabStop = False
        Me.grdProdutosMaisVendidos.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProdutosMaisVendidos.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProdutosMaisVendidos.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProdutosMaisVendidos.Visible = False
        Me.grdProdutosMaisVendidos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProdutosMaisVendidos.VisualStyleManager = Me.vsmMain
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(8, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(724, 110)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'btbMain
        '
        Me.btbMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btbMain.BackColor = System.Drawing.SystemColors.Window
        ButtonBarItem1.Image = CType(resources.GetObject("ButtonBarItem1.Image"), System.Drawing.Image)
        ButtonBarItem1.Key = "usrVen000000018"
        ButtonBarItem1.Text = "Produtos Mais Vendidos / Produto"
        ButtonBarItem2.Image = CType(resources.GetObject("ButtonBarItem2.Image"), System.Drawing.Image)
        ButtonBarItem2.Key = "usrVen000000019"
        ButtonBarItem2.Text = "Produtos Mais Vendidos / Marca"
        ButtonBarItem3.Image = CType(resources.GetObject("ButtonBarItem3.Image"), System.Drawing.Image)
        ButtonBarItem3.Key = "usrVen000000020"
        ButtonBarItem3.Text = "Produtos Mais Vendidos / Vendedor"
        ButtonBarItem4.Image = CType(resources.GetObject("ButtonBarItem4.Image"), System.Drawing.Image)
        ButtonBarItem4.Key = "frmCadProdutoPrecoVendaCalculadora"
        ButtonBarItem4.Text = "Calculadora   "
        ButtonBarGroup1.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBarItem1, ButtonBarItem2, ButtonBarItem3, ButtonBarItem4})
        ButtonBarGroup1.Key = "grpVenda"
        ButtonBarGroup1.Text = "Venda"
        ButtonBarItem5.Key = "Item1"
        ButtonBarItem5.Text = "New Item"
        ButtonBarItem6.Key = "Item2"
        ButtonBarItem6.Text = "New Item"
        ButtonBarItem7.Key = "Item3"
        ButtonBarItem7.Text = "New Item"
        ButtonBarItem8.Key = "Item4"
        ButtonBarItem8.Text = "New Item"
        ButtonBarGroup2.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBarItem5, ButtonBarItem6, ButtonBarItem7, ButtonBarItem8})
        ButtonBarGroup2.Key = "Group2"
        ButtonBarGroup2.Text = "New Group"
        Me.btbMain.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBarGroup1, ButtonBarGroup2})
        Me.btbMain.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.btbMain.Location = New System.Drawing.Point(3, 0)
        Me.btbMain.Name = "btbMain"
        Me.btbMain.Office2007ColorScheme = Janus.Windows.ButtonBar.Office2007ColorScheme.Silver
        Me.btbMain.ShadowOnHover = True
        Me.btbMain.Size = New System.Drawing.Size(246, 565)
        Me.btbMain.TabIndex = 6
        Me.btbMain.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2007
        Me.btbMain.VisualStyleManager = Me.vsmMain
        '
        'btnProdutosMaisVendidos
        '
        Me.btnProdutosMaisVendidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProdutosMaisVendidos.Image = Global.INTERACTI.My.Resources.Novo
        Me.btnProdutosMaisVendidos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProdutosMaisVendidos.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnProdutosMaisVendidos.Location = New System.Drawing.Point(263, 59)
        Me.btnProdutosMaisVendidos.Name = "btnProdutosMaisVendidos"
        Me.btnProdutosMaisVendidos.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProdutosMaisVendidos.Size = New System.Drawing.Size(200, 23)
        Me.btnProdutosMaisVendidos.TabIndex = 7
        Me.btnProdutosMaisVendidos.Text = "Produtos Mais Vendidos"
        Me.btnProdutosMaisVendidos.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProdutosMaisVendidosMarca
        '
        Me.btnProdutosMaisVendidosMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProdutosMaisVendidosMarca.Image = Global.INTERACTI.My.Resources.Novo
        Me.btnProdutosMaisVendidosMarca.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProdutosMaisVendidosMarca.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnProdutosMaisVendidosMarca.Location = New System.Drawing.Point(263, 86)
        Me.btnProdutosMaisVendidosMarca.Name = "btnProdutosMaisVendidosMarca"
        Me.btnProdutosMaisVendidosMarca.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProdutosMaisVendidosMarca.Size = New System.Drawing.Size(200, 23)
        Me.btnProdutosMaisVendidosMarca.TabIndex = 8
        Me.btnProdutosMaisVendidosMarca.Text = "Produtos Mais Vendidos - Marca"
        Me.btnProdutosMaisVendidosMarca.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProdutosMaisVendidosVendedor
        '
        Me.btnProdutosMaisVendidosVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProdutosMaisVendidosVendedor.Image = Global.INTERACTI.My.Resources.Novo
        Me.btnProdutosMaisVendidosVendedor.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProdutosMaisVendidosVendedor.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnProdutosMaisVendidosVendedor.Location = New System.Drawing.Point(263, 113)
        Me.btnProdutosMaisVendidosVendedor.Name = "btnProdutosMaisVendidosVendedor"
        Me.btnProdutosMaisVendidosVendedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProdutosMaisVendidosVendedor.Size = New System.Drawing.Size(200, 23)
        Me.btnProdutosMaisVendidosVendedor.TabIndex = 9
        Me.btnProdutosMaisVendidosVendedor.Text = "Produtos Mais Vendidos - Vendedor"
        Me.btnProdutosMaisVendidosVendedor.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrDshMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btbMain)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrDshMain"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagMenu.ResumeLayout(False)
        Me.pagMenu.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProdutosMaisVendidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagMenu As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents grdProdutosMaisVendidos As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnProdutosMaisVendidos As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProdutosMaisVendidosMarca As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProdutosMaisVendidosVendedor As Janus.Windows.EditControls.UIButton
    Friend WithEvents btbMain As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRelatorio As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label

End Class
