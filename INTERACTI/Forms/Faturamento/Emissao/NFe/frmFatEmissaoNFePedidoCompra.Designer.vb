<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFePedidoCompra
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdPedidoCompra_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPedidoCompra_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFePedidoCompra))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaRegraVenda = New System.Windows.Forms.Label()
        Me.picLegendaRegraVenda = New System.Windows.Forms.PictureBox()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdPedidoCompra = New Janus.Windows.GridEX.GridEX()
        Me.grpFornecedor = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroPedidoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
        Me.cboFornecedorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.txtCNPJCPFFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNPJCPFFiltro = New System.Windows.Forms.Label()
        Me.lblNumeroPedidoFiltro = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnImportarPedidoCompra = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPedidoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFornecedor.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(914, 567)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnExcelGrid)
        Me.pagTabela.Controls.Add(Me.grpLegenda)
        Me.pagTabela.Controls.Add(Me.btnAgruparGrid)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.grdPedidoCompra)
        Me.pagTabela.Controls.Add(Me.grpFornecedor)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(912, 544)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Pedido de Compra"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaRegraVenda)
        Me.grpLegenda.Controls.Add(Me.picLegendaRegraVenda)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 484)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(207, 51)
        Me.grpLegenda.TabIndex = 6
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaRegraVenda
        '
        Me.lblLegendaRegraVenda.AutoSize = True
        Me.lblLegendaRegraVenda.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaRegraVenda.Name = "lblLegendaRegraVenda"
        Me.lblLegendaRegraVenda.Size = New System.Drawing.Size(175, 14)
        Me.lblLegendaRegraVenda.TabIndex = 0
        Me.lblLegendaRegraVenda.Text = "NÃO possui Regra de Faturamento"
        '
        'picLegendaRegraVenda
        '
        Me.picLegendaRegraVenda.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaRegraVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaRegraVenda.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaRegraVenda.Name = "picLegendaRegraVenda"
        Me.picLegendaRegraVenda.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaRegraVenda.TabIndex = 16
        Me.picLegendaRegraVenda.TabStop = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 464)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 5
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 464)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdPedidoCompra
        '
        Me.grdPedidoCompra.AlternatingColors = True
        Me.grdPedidoCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPedidoCompra.AutoEdit = True
        Me.grdPedidoCompra.CardBorders = False
        grdPedidoCompra_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdPedidoCompra_DesignTimeLayout_Reference_0.Instance"), Object)
        grdPedidoCompra_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdPedidoCompra_DesignTimeLayout_Reference_0})
        grdPedidoCompra_DesignTimeLayout.LayoutString = resources.GetString("grdPedidoCompra_DesignTimeLayout.LayoutString")
        Me.grdPedidoCompra.DesignTimeLayout = grdPedidoCompra_DesignTimeLayout
        Me.grdPedidoCompra.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPedidoCompra.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedidoCompra.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedidoCompra.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedidoCompra.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdPedidoCompra.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedidoCompra.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPedidoCompra.FrozenColumns = 2
        Me.grdPedidoCompra.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedidoCompra.GroupByBoxVisible = False
        Me.grdPedidoCompra.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPedidoCompra.Location = New System.Drawing.Point(8, 77)
        Me.grdPedidoCompra.Name = "grdPedidoCompra"
        Me.grdPedidoCompra.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedidoCompra.RecordNavigator = True
        Me.grdPedidoCompra.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdPedidoCompra.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoCompra.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPedidoCompra.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPedidoCompra.Size = New System.Drawing.Size(896, 404)
        Me.grdPedidoCompra.TabIndex = 1
        Me.grdPedidoCompra.TabStop = False
        Me.grdPedidoCompra.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoCompra.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdPedidoCompra.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdPedidoCompra.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPedidoCompra.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPedidoCompra.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedidoCompra.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPedidoCompra.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedidoCompra.VisualStyleManager = Me.vsmMain
        '
        'grpFornecedor
        '
        Me.grpFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.grpFornecedor.Controls.Add(Me.txtNumeroPedidoFiltro)
        Me.grpFornecedor.Controls.Add(Me.btnFiltrar)
        Me.grpFornecedor.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpFornecedor.Controls.Add(Me.cboFornecedorFiltro)
        Me.grpFornecedor.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFornecedor.Controls.Add(Me.txtCNPJCPFFiltro)
        Me.grpFornecedor.Controls.Add(Me.lblCNPJCPFFiltro)
        Me.grpFornecedor.Controls.Add(Me.lblNumeroPedidoFiltro)
        Me.grpFornecedor.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grpFornecedor.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFornecedor.Location = New System.Drawing.Point(8, 3)
        Me.grpFornecedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFornecedor.Name = "grpFornecedor"
        Me.grpFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFornecedor.Size = New System.Drawing.Size(896, 64)
        Me.grpFornecedor.TabIndex = 0
        Me.grpFornecedor.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroPedidoFiltro
        '
        Me.txtNumeroPedidoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroPedidoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoFiltro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPedidoFiltro.Location = New System.Drawing.Point(503, 34)
        Me.txtNumeroPedidoFiltro.MaxLength = 20
        Me.txtNumeroPedidoFiltro.Name = "txtNumeroPedidoFiltro"
        Me.txtNumeroPedidoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroPedidoFiltro.TabIndex = 25
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(796, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 24
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProcurarFornecedor
        '
        Me.btnProcurarFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(345, 16)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedor.TabIndex = 10
        Me.btnProcurarFornecedor.TabStop = False
        Me.btnProcurarFornecedor.UseVisualStyleBackColor = True
        '
        'cboFornecedorFiltro
        '
        Me.cboFornecedorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedorFiltro.AutoSize = False
        Me.cboFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedorFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboFornecedorFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFornecedorFiltro.Name = "cboFornecedorFiltro"
        Me.cboFornecedorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedorFiltro.Size = New System.Drawing.Size(353, 20)
        Me.cboFornecedorFiltro.TabIndex = 1
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 0
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'txtCNPJCPFFiltro
        '
        Me.txtCNPJCPFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCNPJCPFFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCNPJCPFFiltro.Enabled = False
        Me.txtCNPJCPFFiltro.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCNPJCPFFiltro.Location = New System.Drawing.Point(368, 34)
        Me.txtCNPJCPFFiltro.Mask = "00,000,000/0000-00"
        Me.txtCNPJCPFFiltro.MaxLength = 25
        Me.txtCNPJCPFFiltro.Name = "txtCNPJCPFFiltro"
        Me.txtCNPJCPFFiltro.ReadOnly = True
        Me.txtCNPJCPFFiltro.Size = New System.Drawing.Size(129, 20)
        Me.txtCNPJCPFFiltro.TabIndex = 3
        Me.txtCNPJCPFFiltro.TabStop = False
        '
        'lblCNPJCPFFiltro
        '
        Me.lblCNPJCPFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPJCPFFiltro.AutoSize = True
        Me.lblCNPJCPFFiltro.Location = New System.Drawing.Point(365, 17)
        Me.lblCNPJCPFFiltro.Name = "lblCNPJCPFFiltro"
        Me.lblCNPJCPFFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJCPFFiltro.TabIndex = 2
        Me.lblCNPJCPFFiltro.Text = "CNPJ:"
        '
        'lblNumeroPedidoFiltro
        '
        Me.lblNumeroPedidoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroPedidoFiltro.AutoSize = True
        Me.lblNumeroPedidoFiltro.Location = New System.Drawing.Point(500, 17)
        Me.lblNumeroPedidoFiltro.Name = "lblNumeroPedidoFiltro"
        Me.lblNumeroPedidoFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedidoFiltro.TabIndex = 4
        Me.lblNumeroPedidoFiltro.Text = "Nº Pedido:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl2.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl2.Controls.Add(Me.btnImportarPedidoCompra)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(224, 484)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(680, 51)
        Me.grpControl2.TabIndex = 4
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 6
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 7
        Me.cboCongelarColuna.TabStop = False
        '
        'btnImportarPedidoCompra
        '
        Me.btnImportarPedidoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarPedidoCompra.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportarPedidoCompra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarPedidoCompra.Location = New System.Drawing.Point(483, 17)
        Me.btnImportarPedidoCompra.Name = "btnImportarPedidoCompra"
        Me.btnImportarPedidoCompra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarPedidoCompra.Size = New System.Drawing.Size(91, 23)
        Me.btnImportarPedidoCompra.TabIndex = 0
        Me.btnImportarPedidoCompra.Text = "Importar"
        Me.btnImportarPedidoCompra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(580, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 464)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 96
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'frmFatEmissaoNFePedidoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 582)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFePedidoCompra"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nota Fiscal Eletrônica - Importar Pedido de Compra"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPedidoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFornecedor.ResumeLayout(False)
        Me.grpFornecedor.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.grpControl2.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnImportarPedidoCompra As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFornecedor As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboFornecedorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCNPJCPFFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNPJCPFFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNumeroPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdPedidoCompra As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroPedidoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaRegraVenda As System.Windows.Forms.Label
    Friend WithEvents picLegendaRegraVenda As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
End Class
