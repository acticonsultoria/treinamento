<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenPedidoOrcamento
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
        Dim grdPedidoOrcamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenPedidoOrcamento))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaCancelado = New System.Windows.Forms.Label()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdPedidoOrcamento = New Janus.Windows.GridEX.GridEX()
        Me.grpCliente = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtMunicipioUFFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMunicipioUFFiltro = New System.Windows.Forms.Label()
        Me.cboOrcamentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrcamentoFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarClienteFiltro = New System.Windows.Forms.Button()
        Me.txtCNPJCPFFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNPJCPFFiltro = New System.Windows.Forms.Label()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportarOrcamento = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPedidoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCliente.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 9)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpLegenda)
        Me.pagTabela.Controls.Add(Me.btnExcelGrid)
        Me.pagTabela.Controls.Add(Me.btnAgruparGrid)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.grdPedidoOrcamento)
        Me.pagTabela.Controls.Add(Me.grpCliente)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(913, 543)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Orçamento"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(162, 51)
        Me.grpLegenda.TabIndex = 96
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaCancelado
        '
        Me.lblLegendaCancelado.AutoSize = True
        Me.lblLegendaCancelado.Location = New System.Drawing.Point(25, 26)
        Me.lblLegendaCancelado.Name = "lblLegendaCancelado"
        Me.lblLegendaCancelado.Size = New System.Drawing.Size(128, 14)
        Me.lblLegendaCancelado.TabIndex = 3
        Me.lblLegendaCancelado.Text = "Item não possui cadastro"
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(6, 26)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelado.TabIndex = 16
        Me.picLegendaCancelado.TabStop = False
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
        Me.btnExcelGrid.TabIndex = 95
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 24
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdPedidoOrcamento
        '
        Me.grdPedidoOrcamento.AlternatingColors = True
        Me.grdPedidoOrcamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPedidoOrcamento.AutoEdit = True
        grdPedidoOrcamento_DesignTimeLayout.LayoutString = resources.GetString("grdPedidoOrcamento_DesignTimeLayout.LayoutString")
        Me.grdPedidoOrcamento.DesignTimeLayout = grdPedidoOrcamento_DesignTimeLayout
        Me.grdPedidoOrcamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPedidoOrcamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedidoOrcamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedidoOrcamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedidoOrcamento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdPedidoOrcamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedidoOrcamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPedidoOrcamento.FrozenColumns = 1
        Me.grdPedidoOrcamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedidoOrcamento.GroupByBoxVisible = False
        Me.grdPedidoOrcamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPedidoOrcamento.Location = New System.Drawing.Point(8, 76)
        Me.grdPedidoOrcamento.Name = "grdPedidoOrcamento"
        Me.grdPedidoOrcamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedidoOrcamento.RecordNavigator = True
        Me.grdPedidoOrcamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdPedidoOrcamento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoOrcamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPedidoOrcamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPedidoOrcamento.Size = New System.Drawing.Size(897, 404)
        Me.grdPedidoOrcamento.TabIndex = 1
        Me.grdPedidoOrcamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoOrcamento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdPedidoOrcamento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdPedidoOrcamento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPedidoOrcamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPedidoOrcamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedidoOrcamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPedidoOrcamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedidoOrcamento.VisualStyleManager = Me.vsmMain
        '
        'grpCliente
        '
        Me.grpCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCliente.BackColor = System.Drawing.Color.Transparent
        Me.grpCliente.Controls.Add(Me.btnFiltrar)
        Me.grpCliente.Controls.Add(Me.txtMunicipioUFFiltro)
        Me.grpCliente.Controls.Add(Me.lblMunicipioUFFiltro)
        Me.grpCliente.Controls.Add(Me.cboOrcamentoFiltro)
        Me.grpCliente.Controls.Add(Me.lblOrcamentoFiltro)
        Me.grpCliente.Controls.Add(Me.btnProcurarClienteFiltro)
        Me.grpCliente.Controls.Add(Me.txtCNPJCPFFiltro)
        Me.grpCliente.Controls.Add(Me.lblCNPJCPFFiltro)
        Me.grpCliente.Controls.Add(Me.cboClienteFiltro)
        Me.grpCliente.Controls.Add(Me.lblClienteFiltro)
        Me.grpCliente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCliente.Location = New System.Drawing.Point(8, 3)
        Me.grpCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCliente.Size = New System.Drawing.Size(897, 64)
        Me.grpCliente.TabIndex = 0
        Me.grpCliente.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtMunicipioUFFiltro
        '
        Me.txtMunicipioUFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMunicipioUFFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMunicipioUFFiltro.Enabled = False
        Me.txtMunicipioUFFiltro.Location = New System.Drawing.Point(327, 35)
        Me.txtMunicipioUFFiltro.MaxLength = 25
        Me.txtMunicipioUFFiltro.Name = "txtMunicipioUFFiltro"
        Me.txtMunicipioUFFiltro.ReadOnly = True
        Me.txtMunicipioUFFiltro.Size = New System.Drawing.Size(178, 20)
        Me.txtMunicipioUFFiltro.TabIndex = 6
        Me.txtMunicipioUFFiltro.TabStop = False
        '
        'lblMunicipioUFFiltro
        '
        Me.lblMunicipioUFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMunicipioUFFiltro.AutoSize = True
        Me.lblMunicipioUFFiltro.Location = New System.Drawing.Point(324, 18)
        Me.lblMunicipioUFFiltro.Name = "lblMunicipioUFFiltro"
        Me.lblMunicipioUFFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblMunicipioUFFiltro.TabIndex = 5
        Me.lblMunicipioUFFiltro.Text = "Município - UF:"
        '
        'cboOrcamentoFiltro
        '
        Me.cboOrcamentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOrcamentoFiltro.AutoSize = False
        Me.cboOrcamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrcamentoFiltro.Location = New System.Drawing.Point(511, 35)
        Me.cboOrcamentoFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboOrcamentoFiltro.Name = "cboOrcamentoFiltro"
        Me.cboOrcamentoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrcamentoFiltro.Size = New System.Drawing.Size(106, 20)
        Me.cboOrcamentoFiltro.TabIndex = 1
        '
        'lblOrcamentoFiltro
        '
        Me.lblOrcamentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrcamentoFiltro.AutoSize = True
        Me.lblOrcamentoFiltro.Location = New System.Drawing.Point(508, 18)
        Me.lblOrcamentoFiltro.Name = "lblOrcamentoFiltro"
        Me.lblOrcamentoFiltro.Size = New System.Drawing.Size(78, 14)
        Me.lblOrcamentoFiltro.TabIndex = 7
        Me.lblOrcamentoFiltro.Text = "Nº Orçamento:"
        '
        'btnProcurarClienteFiltro
        '
        Me.btnProcurarClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarClienteFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarClienteFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarClienteFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarClienteFiltro.Location = New System.Drawing.Point(178, 16)
        Me.btnProcurarClienteFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarClienteFiltro.Name = "btnProcurarClienteFiltro"
        Me.btnProcurarClienteFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarClienteFiltro.TabIndex = 2
        Me.btnProcurarClienteFiltro.TabStop = False
        Me.btnProcurarClienteFiltro.UseVisualStyleBackColor = True
        '
        'txtCNPJCPFFiltro
        '
        Me.txtCNPJCPFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCNPJCPFFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCNPJCPFFiltro.Enabled = False
        Me.txtCNPJCPFFiltro.Location = New System.Drawing.Point(201, 35)
        Me.txtCNPJCPFFiltro.Mask = "00,000,000/0000-00"
        Me.txtCNPJCPFFiltro.MaxLength = 25
        Me.txtCNPJCPFFiltro.Name = "txtCNPJCPFFiltro"
        Me.txtCNPJCPFFiltro.ReadOnly = True
        Me.txtCNPJCPFFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtCNPJCPFFiltro.TabIndex = 4
        Me.txtCNPJCPFFiltro.TabStop = False
        '
        'lblCNPJCPFFiltro
        '
        Me.lblCNPJCPFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPJCPFFiltro.AutoSize = True
        Me.lblCNPJCPFFiltro.Location = New System.Drawing.Point(198, 18)
        Me.lblCNPJCPFFiltro.Name = "lblCNPJCPFFiltro"
        Me.lblCNPJCPFFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJCPFFiltro.TabIndex = 3
        Me.lblCNPJCPFFiltro.Text = "CNPJ:"
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClienteFiltro.AutoSize = False
        Me.cboClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboClienteFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(186, 20)
        Me.cboClienteFiltro.TabIndex = 0
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 0
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImportarOrcamento)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(176, 483)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(729, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImportarOrcamento
        '
        Me.btnImportarOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarOrcamento.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportarOrcamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarOrcamento.Location = New System.Drawing.Point(473, 17)
        Me.btnImportarOrcamento.Name = "btnImportarOrcamento"
        Me.btnImportarOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarOrcamento.Size = New System.Drawing.Size(150, 23)
        Me.btnImportarOrcamento.TabIndex = 0
        Me.btnImportarOrcamento.Text = "Importar Orçamento"
        Me.btnImportarOrcamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(629, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmVenPedidoOrcamento
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
        Me.Name = "frmVenPedidoOrcamento"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pedido de Venda - Importar Orçamentos"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPedidoOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCliente.ResumeLayout(False)
        Me.grpCliente.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnImportarOrcamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpCliente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCNPJCPFFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNPJCPFFiltro As System.Windows.Forms.Label
    Friend WithEvents grdPedidoOrcamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnProcurarClienteFiltro As System.Windows.Forms.Button
    Friend WithEvents cboOrcamentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrcamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtMunicipioUFFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMunicipioUFFiltro As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaCancelado As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
End Class
