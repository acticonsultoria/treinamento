<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdPlanejamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdPlanejamento))
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings4 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpConfiguracao = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkConsiderarEstoque = New Janus.Windows.EditControls.UICheckBox()
        Me.chkConsiderarPedidoVenda = New Janus.Windows.EditControls.UICheckBox()
        Me.chkConsiderarEstoqueMinimo = New Janus.Windows.EditControls.UICheckBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtMateriaPrimaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMateriaPrimaFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.txtClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPedidoVendaFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.dtpDataNecessidadeTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataNecessidadeInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataNecessidadeFiltro = New System.Windows.Forms.Label()
        Me.cboPedidoVendaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkAgrupar = New Janus.Windows.EditControls.UICheckBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnOrdemProducao = New Janus.Windows.EditControls.UIButton()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpConfiguracao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConfiguracao.SuspendLayout()
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
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpConfiguracao)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpEntrega)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(1118, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Planejamento de Produção"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 23
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGridProduto
        '
        Me.btnAgruparGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridProduto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridProduto.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProduto.Name = "btnAgruparGridProduto"
        Me.btnAgruparGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridProduto.TabIndex = 8
        Me.btnAgruparGridProduto.TabStop = False
        Me.btnAgruparGridProduto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 7
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 5
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 166)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1102, 314)
        Me.grdListagem.TabIndex = 6
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
        'grpConfiguracao
        '
        Me.grpConfiguracao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpConfiguracao.BackColor = System.Drawing.Color.Transparent
        Me.grpConfiguracao.Controls.Add(Me.chkConsiderarEstoque)
        Me.grpConfiguracao.Controls.Add(Me.chkConsiderarPedidoVenda)
        Me.grpConfiguracao.Controls.Add(Me.chkConsiderarEstoqueMinimo)
        Me.grpConfiguracao.Location = New System.Drawing.Point(938, 3)
        Me.grpConfiguracao.Name = "grpConfiguracao"
        Me.grpConfiguracao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpConfiguracao.Size = New System.Drawing.Size(172, 157)
        Me.grpConfiguracao.TabIndex = 1
        Me.grpConfiguracao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpConfiguracao.VisualStyleManager = Me.vsmMain
        '
        'chkConsiderarEstoque
        '
        Me.chkConsiderarEstoque.Location = New System.Drawing.Point(8, 76)
        Me.chkConsiderarEstoque.Name = "chkConsiderarEstoque"
        Me.chkConsiderarEstoque.Size = New System.Drawing.Size(150, 18)
        SuperTipSettings1.HeaderText = "Considerar Estoque Mínimo"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Quando selecionado, será considerado na Demanda a Quantidade Necessária para atin" &
    "gir o Estoque Mínimo."
        Me.jstMain.SetSuperTip(Me.chkConsiderarEstoque, SuperTipSettings1)
        Me.chkConsiderarEstoque.TabIndex = 2
        Me.chkConsiderarEstoque.TabStop = False
        Me.chkConsiderarEstoque.Text = "Considerar Estoque"
        '
        'chkConsiderarPedidoVenda
        '
        Me.chkConsiderarPedidoVenda.Location = New System.Drawing.Point(8, 56)
        Me.chkConsiderarPedidoVenda.Name = "chkConsiderarPedidoVenda"
        Me.chkConsiderarPedidoVenda.Size = New System.Drawing.Size(153, 18)
        SuperTipSettings2.HeaderText = "Considerar Pedido Venda"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Quando selecionado, será considerado na Demanda os Pedidos de Venda em Aberto."
        Me.jstMain.SetSuperTip(Me.chkConsiderarPedidoVenda, SuperTipSettings2)
        Me.chkConsiderarPedidoVenda.TabIndex = 1
        Me.chkConsiderarPedidoVenda.TabStop = False
        Me.chkConsiderarPedidoVenda.Text = "Considerar Demanda Venda"
        '
        'chkConsiderarEstoqueMinimo
        '
        Me.chkConsiderarEstoqueMinimo.Location = New System.Drawing.Point(8, 96)
        Me.chkConsiderarEstoqueMinimo.Name = "chkConsiderarEstoqueMinimo"
        Me.chkConsiderarEstoqueMinimo.Size = New System.Drawing.Size(150, 18)
        SuperTipSettings3.HeaderText = "Considerar Estoque Mínimo"
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Quando selecionado, será considerado na Demanda a Quantidade Necessária para atin" &
    "gir o Estoque Mínimo."
        Me.jstMain.SetSuperTip(Me.chkConsiderarEstoqueMinimo, SuperTipSettings3)
        Me.chkConsiderarEstoqueMinimo.TabIndex = 3
        Me.chkConsiderarEstoqueMinimo.TabStop = False
        Me.chkConsiderarEstoqueMinimo.Text = "Considerar Estoque Mínimo"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtMateriaPrimaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMateriaPrimaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarCliente)
        Me.grpFiltro.Controls.Add(Me.btnProcurarProduto)
        Me.grpFiltro.Controls.Add(Me.txtClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataNecessidadeTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataNecessidadeInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataNecessidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.cboPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(921, 157)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtMateriaPrimaFiltro
        '
        Me.txtMateriaPrimaFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMateriaPrimaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMateriaPrimaFiltro.Location = New System.Drawing.Point(323, 74)
        Me.txtMateriaPrimaFiltro.MaxLength = 120
        Me.txtMateriaPrimaFiltro.Name = "txtMateriaPrimaFiltro"
        Me.txtMateriaPrimaFiltro.Size = New System.Drawing.Size(448, 20)
        Me.txtMateriaPrimaFiltro.TabIndex = 15
        '
        'lblMateriaPrimaFiltro
        '
        Me.lblMateriaPrimaFiltro.AutoSize = True
        Me.lblMateriaPrimaFiltro.Location = New System.Drawing.Point(320, 57)
        Me.lblMateriaPrimaFiltro.Name = "lblMateriaPrimaFiltro"
        Me.lblMateriaPrimaFiltro.Size = New System.Drawing.Size(74, 14)
        Me.lblMateriaPrimaFiltro.TabIndex = 14
        Me.lblMateriaPrimaFiltro.Text = "Matéria Prima:"
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(754, 96)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 13
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(300, 56)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 6
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteFiltro.Location = New System.Drawing.Point(135, 114)
        Me.txtClienteFiltro.MaxLength = 120
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.Size = New System.Drawing.Size(636, 20)
        Me.txtClienteFiltro.TabIndex = 10
        '
        'lblPedidoVendaFiltro
        '
        Me.lblPedidoVendaFiltro.AutoSize = True
        Me.lblPedidoVendaFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblPedidoVendaFiltro.Name = "lblPedidoVendaFiltro"
        Me.lblPedidoVendaFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblPedidoVendaFiltro.TabIndex = 8
        Me.lblPedidoVendaFiltro.Text = "Nº Pedido Venda:"
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblClienteFiltro.Location = New System.Drawing.Point(132, 97)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 11
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'dtpDataNecessidadeTerminoFiltro
        '
        Me.dtpDataNecessidadeTerminoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataNecessidadeTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataNecessidadeTerminoFiltro.Location = New System.Drawing.Point(651, 34)
        Me.dtpDataNecessidadeTerminoFiltro.Name = "dtpDataNecessidadeTerminoFiltro"
        Me.dtpDataNecessidadeTerminoFiltro.ShowCheckBox = True
        Me.dtpDataNecessidadeTerminoFiltro.Size = New System.Drawing.Size(120, 20)
        Me.dtpDataNecessidadeTerminoFiltro.TabIndex = 4
        '
        'dtpDataNecessidadeInicioFiltro
        '
        Me.dtpDataNecessidadeInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataNecessidadeInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataNecessidadeInicioFiltro.Location = New System.Drawing.Point(525, 34)
        Me.dtpDataNecessidadeInicioFiltro.Name = "dtpDataNecessidadeInicioFiltro"
        Me.dtpDataNecessidadeInicioFiltro.ShowCheckBox = True
        Me.dtpDataNecessidadeInicioFiltro.Size = New System.Drawing.Size(120, 20)
        Me.dtpDataNecessidadeInicioFiltro.TabIndex = 3
        '
        'lblDataNecessidadeFiltro
        '
        Me.lblDataNecessidadeFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataNecessidadeFiltro.AutoSize = True
        Me.lblDataNecessidadeFiltro.Location = New System.Drawing.Point(522, 17)
        Me.lblDataNecessidadeFiltro.Name = "lblDataNecessidadeFiltro"
        Me.lblDataNecessidadeFiltro.Size = New System.Drawing.Size(98, 14)
        Me.lblDataNecessidadeFiltro.TabIndex = 2
        Me.lblDataNecessidadeFiltro.Text = "Data Necessidade:"
        '
        'cboPedidoVendaFiltro
        '
        Me.cboPedidoVendaFiltro.AutoSize = False
        Me.cboPedidoVendaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPedidoVendaFiltro.Location = New System.Drawing.Point(9, 114)
        Me.cboPedidoVendaFiltro.Name = "cboPedidoVendaFiltro"
        Me.cboPedidoVendaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPedidoVendaFiltro.Size = New System.Drawing.Size(120, 20)
        Me.cboPedidoVendaFiltro.TabIndex = 9
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblGrupoItemFiltro.TabIndex = 0
        Me.lblGrupoItemFiltro.Text = "Grupo - Item:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoItemFiltro.AutoSize = False
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(510, 20)
        Me.cboGrupoItemFiltro.TabIndex = 1
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtProdutoFiltro.MaxLength = 120
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(308, 20)
        Me.txtProdutoFiltro.TabIndex = 7
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 5
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(821, 113)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 12
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.chkAgrupar)
        Me.grpEntrega.Controls.Add(Me.btnSair)
        Me.grpEntrega.Controls.Add(Me.btnOrdemProducao)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(8, 486)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(1102, 51)
        Me.grpEntrega.TabIndex = 0
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'chkAgrupar
        '
        Me.chkAgrupar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAgrupar.Checked = True
        Me.chkAgrupar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAgrupar.Location = New System.Drawing.Point(578, 17)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Size = New System.Drawing.Size(251, 18)
        SuperTipSettings4.HeaderText = "Agrupar Produtos no Topo"
        SuperTipSettings4.ImageListProvider = Nothing
        SuperTipSettings4.Text = "Essa opção fará com que toda composição dos filhos e netos sejam agrupados no pro" &
    "duto topo"
        Me.jstMain.SetSuperTip(Me.chkAgrupar, SuperTipSettings4)
        Me.chkAgrupar.TabIndex = 13
        Me.chkAgrupar.TabStop = False
        Me.chkAgrupar.Text = "Agrupar apontamentos no Produto Vendido"
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(1002, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 12
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnOrdemProducao
        '
        Me.btnOrdemProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrdemProducao.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnOrdemProducao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOrdemProducao.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnOrdemProducao.Location = New System.Drawing.Point(835, 17)
        Me.btnOrdemProducao.Name = "btnOrdemProducao"
        Me.btnOrdemProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOrdemProducao.Size = New System.Drawing.Size(161, 23)
        Me.btnOrdemProducao.TabIndex = 11
        Me.btnOrdemProducao.Text = "Gerar Ordem de Produção"
        Me.btnOrdemProducao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 60000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.ShowAlways = True
        '
        'usrPrdPlanejamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdPlanejamento"
        Me.Size = New System.Drawing.Size(1120, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpConfiguracao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConfiguracao.ResumeLayout(False)
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
    Private WithEvents btnOrdemProducao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboPedidoVendaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblPedidoVendaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataNecessidadeTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataNecessidadeInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataNecessidadeFiltro As System.Windows.Forms.Label
    Friend WithEvents txtClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents grpConfiguracao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkConsiderarPedidoVenda As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkConsiderarEstoqueMinimo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents txtMateriaPrimaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMateriaPrimaFiltro As System.Windows.Forms.Label
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkConsiderarEstoque As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents chkAgrupar As Janus.Windows.EditControls.UICheckBox

End Class
