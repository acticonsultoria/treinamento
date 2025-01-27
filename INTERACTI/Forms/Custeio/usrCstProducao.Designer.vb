<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCstProducao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCstProducao))
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridItem = New System.Windows.Forms.Button()
        Me.btnAgruparGridItem = New System.Windows.Forms.Button()
        Me.btnConfigurarGridItem = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.btnExcelGridServico = New System.Windows.Forms.Button()
        Me.btnAgruparGridServico = New System.Windows.Forms.Button()
        Me.btnConfigurarGridServico = New System.Windows.Forms.Button()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(946, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagLista.Controls.Add(Me.btnExcelGridItem)
        Me.pagLista.Controls.Add(Me.btnAgruparGridItem)
        Me.pagLista.Controls.Add(Me.btnConfigurarGridItem)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpEntrega)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(944, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Análise"
        '
        'btnExcelGridItem
        '
        Me.btnExcelGridItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridItem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridItem.FlatAppearance.BorderSize = 0
        Me.btnExcelGridItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridItem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridItem.Location = New System.Drawing.Point(49, 465)
        Me.btnExcelGridItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridItem.Name = "btnExcelGridItem"
        Me.btnExcelGridItem.Size = New System.Drawing.Size(24, 16)
        Me.btnExcelGridItem.TabIndex = 124
        Me.btnExcelGridItem.TabStop = False
        Me.btnExcelGridItem.UseVisualStyleBackColor = False
        '
        'btnAgruparGridItem
        '
        Me.btnAgruparGridItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridItem.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridItem.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridItem.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridItem.Location = New System.Drawing.Point(25, 465)
        Me.btnAgruparGridItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridItem.Name = "btnAgruparGridItem"
        Me.btnAgruparGridItem.Size = New System.Drawing.Size(24, 16)
        Me.btnAgruparGridItem.TabIndex = 123
        Me.btnAgruparGridItem.TabStop = False
        Me.btnAgruparGridItem.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridItem
        '
        Me.btnConfigurarGridItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridItem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridItem.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridItem.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridItem.Location = New System.Drawing.Point(6, 465)
        Me.btnConfigurarGridItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridItem.Name = "btnConfigurarGridItem"
        Me.btnConfigurarGridItem.Size = New System.Drawing.Size(19, 16)
        Me.btnConfigurarGridItem.TabIndex = 122
        Me.btnConfigurarGridItem.TabStop = False
        Me.btnConfigurarGridItem.UseVisualStyleBackColor = False
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
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(3, 75)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(938, 407)
        Me.grdListagem.TabIndex = 121
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
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.btnSair)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(3, 488)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(938, 52)
        Me.grpEntrega.TabIndex = 2
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(838, 19)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.dtpDataFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(3, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(938, 66)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(824, 29)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 7
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataFiltro
        '
        '
        '
        '
        Me.dtpDataFiltro.DropDownCalendar.Name = ""
        Me.dtpDataFiltro.Location = New System.Drawing.Point(10, 32)
        Me.dtpDataFiltro.Name = "dtpDataFiltro"
        Me.dtpDataFiltro.ShowCheckBox = True
        Me.dtpDataFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataFiltro.TabIndex = 1
        Me.dtpDataFiltro.Value = New Date(2019, 1, 21, 10, 3, 19, 0)
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(7, 15)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 0
        Me.lblDataFiltro.Text = "Data:"
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 60000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.ShowAlways = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(50, 368)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 15)
        Me.Button1.TabIndex = 94
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(26, 368)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 15)
        Me.Button2.TabIndex = 93
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(2, 368)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 2
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'btnExcelGridServico
        '
        Me.btnExcelGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridServico.FlatAppearance.BorderSize = 0
        Me.btnExcelGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridServico.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridServico.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridServico.Name = "btnExcelGridServico"
        Me.btnExcelGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridServico.TabIndex = 96
        Me.btnExcelGridServico.TabStop = False
        Me.btnExcelGridServico.UseVisualStyleBackColor = False
        '
        'btnAgruparGridServico
        '
        Me.btnAgruparGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridServico.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridServico.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridServico.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridServico.Name = "btnAgruparGridServico"
        Me.btnAgruparGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridServico.TabIndex = 95
        Me.btnAgruparGridServico.TabStop = False
        Me.btnAgruparGridServico.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridServico
        '
        Me.btnConfigurarGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridServico.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridServico.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridServico.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridServico.Name = "btnConfigurarGridServico"
        Me.btnConfigurarGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridServico.TabIndex = 2
        Me.btnConfigurarGridServico.TabStop = False
        Me.btnConfigurarGridServico.UseVisualStyleBackColor = False
        '
        'grdProduto
        '
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.AutoEdit = True
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.DynamicFiltering = True
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProduto.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.Hierarchical = True
        Me.grdProduto.Location = New System.Drawing.Point(0, 0)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(936, 385)
        Me.grdProduto.TabIndex = 95
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdProduto.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdProduto.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.AutoEdit = True
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.DynamicFiltering = True
        Me.GridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridEX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX1.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.GridEX1.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.GridEX1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridEX1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.GridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridEX1.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.GridEX1.Size = New System.Drawing.Size(936, 384)
        Me.GridEX1.TabIndex = 97
        Me.GridEX1.TabStop = False
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.GridEX1.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridEX1.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.GridEX1.VisualStyleManager = Me.vsmMain
        '
        'usrCstProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCstProducao"
        Me.Size = New System.Drawing.Size(946, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntrega.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridServico As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridServico As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridServico As System.Windows.Forms.Button
    Friend WithEvents dtpDataFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridItem As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridItem As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridItem As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX

End Class
