<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFeDevolucaoNotaFiscalFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFeDevolucaoNotaFiscalFornecedor))
        Dim grdNotaFiscalRecebida_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdNotaFiscalRecebida_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaRegraVenda = New System.Windows.Forms.Label()
        Me.picLegendaRegraVenda = New System.Windows.Forms.PictureBox()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboDestinacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDestinacao = New System.Windows.Forms.Label()
        Me.chkDefinirImposto = New Janus.Windows.EditControls.UICheckBox()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
        Me.cboFornecedorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.txtCNPJCPFFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNPJCPFFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.grpPedidoVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnImportarDados = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdNotaFiscalRecebida = New Janus.Windows.GridEX.GridEX()
        Me.txtOrdemProducaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducaoFiltro = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpPedidoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPedidoVenda.SuspendLayout()
        CType(Me.grdNotaFiscalRecebida, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(914, 567)
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
        Me.pagTabela.Controls.Add(Me.grpFiltro)
        Me.pagTabela.Controls.Add(Me.grpPedidoVenda)
        Me.pagTabela.Controls.Add(Me.grdNotaFiscalRecebida)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(912, 544)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Notas Fiscais Recebidas"
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
        Me.grpLegenda.TabIndex = 7
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
        Me.btnExcelGrid.TabIndex = 4
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 464)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
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
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboDestinacao)
        Me.grpFiltro.Controls.Add(Me.lblDestinacao)
        Me.grpFiltro.Controls.Add(Me.chkDefinirImposto)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpFiltro.Controls.Add(Me.cboFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCNPJCPFFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCNPJCPFFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(896, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboDestinacao
        '
        Me.cboDestinacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDestinacao.AutoSize = False
        Me.cboDestinacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDestinacao.Location = New System.Drawing.Point(423, 34)
        Me.cboDestinacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDestinacao.Name = "cboDestinacao"
        Me.cboDestinacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDestinacao.Size = New System.Drawing.Size(157, 20)
        Me.cboDestinacao.TabIndex = 7
        '
        'lblDestinacao
        '
        Me.lblDestinacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDestinacao.AutoSize = True
        Me.lblDestinacao.Location = New System.Drawing.Point(420, 17)
        Me.lblDestinacao.Name = "lblDestinacao"
        Me.lblDestinacao.Size = New System.Drawing.Size(64, 14)
        Me.lblDestinacao.TabIndex = 6
        Me.lblDestinacao.Text = "Destinação:"
        '
        'chkDefinirImposto
        '
        Me.chkDefinirImposto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDefinirImposto.Location = New System.Drawing.Point(329, 34)
        Me.chkDefinirImposto.Name = "chkDefinirImposto"
        Me.chkDefinirImposto.Size = New System.Drawing.Size(88, 17)
        Me.chkDefinirImposto.TabIndex = 5
        Me.chkDefinirImposto.Text = "Definir Imposto"
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotaFiscalFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(586, 34)
        Me.txtNotaFiscalFiltro.MaxLength = 20
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 9
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(796, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 10
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
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(171, 15)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedor.TabIndex = 1
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
        Me.cboFornecedorFiltro.Size = New System.Drawing.Size(179, 20)
        Me.cboFornecedorFiltro.TabIndex = 2
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
        Me.txtCNPJCPFFiltro.Location = New System.Drawing.Point(194, 34)
        Me.txtCNPJCPFFiltro.Mask = "00,000,000/0000-00"
        Me.txtCNPJCPFFiltro.MaxLength = 25
        Me.txtCNPJCPFFiltro.Name = "txtCNPJCPFFiltro"
        Me.txtCNPJCPFFiltro.ReadOnly = True
        Me.txtCNPJCPFFiltro.Size = New System.Drawing.Size(129, 20)
        Me.txtCNPJCPFFiltro.TabIndex = 4
        Me.txtCNPJCPFFiltro.TabStop = False
        '
        'lblCNPJCPFFiltro
        '
        Me.lblCNPJCPFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPJCPFFiltro.AutoSize = True
        Me.lblCNPJCPFFiltro.Location = New System.Drawing.Point(191, 17)
        Me.lblCNPJCPFFiltro.Name = "lblCNPJCPFFiltro"
        Me.lblCNPJCPFFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJCPFFiltro.TabIndex = 3
        Me.lblCNPJCPFFiltro.Text = "CNPJ:"
        '
        'lblNotaFiscalFiltro
        '
        Me.lblNotaFiscalFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotaFiscalFiltro.AutoSize = True
        Me.lblNotaFiscalFiltro.Location = New System.Drawing.Point(583, 17)
        Me.lblNotaFiscalFiltro.Name = "lblNotaFiscalFiltro"
        Me.lblNotaFiscalFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalFiltro.TabIndex = 8
        Me.lblNotaFiscalFiltro.Text = "Nota Fiscal:"
        '
        'grpPedidoVenda
        '
        Me.grpPedidoVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPedidoVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpPedidoVenda.Controls.Add(Me.lblCongelarColuna)
        Me.grpPedidoVenda.Controls.Add(Me.cboCongelarColuna)
        Me.grpPedidoVenda.Controls.Add(Me.btnImportarDados)
        Me.grpPedidoVenda.Controls.Add(Me.btnSair)
        Me.grpPedidoVenda.Location = New System.Drawing.Point(224, 484)
        Me.grpPedidoVenda.Name = "grpPedidoVenda"
        Me.grpPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPedidoVenda.Size = New System.Drawing.Size(680, 51)
        Me.grpPedidoVenda.TabIndex = 6
        Me.grpPedidoVenda.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpPedidoVenda.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 0
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 1
        Me.cboCongelarColuna.TabStop = False
        '
        'btnImportarDados
        '
        Me.btnImportarDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarDados.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportarDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarDados.Location = New System.Drawing.Point(483, 17)
        Me.btnImportarDados.Name = "btnImportarDados"
        Me.btnImportarDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarDados.Size = New System.Drawing.Size(91, 23)
        Me.btnImportarDados.TabIndex = 2
        Me.btnImportarDados.Text = "Importar"
        Me.btnImportarDados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdNotaFiscalRecebida
        '
        Me.grdNotaFiscalRecebida.AllowChildTableGroups = True
        Me.grdNotaFiscalRecebida.AlternatingColors = True
        Me.grdNotaFiscalRecebida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdNotaFiscalRecebida.AutoEdit = True
        grdNotaFiscalRecebida_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdNotaFiscalRecebida_DesignTimeLayout_Reference_0.Instance"), Object)
        grdNotaFiscalRecebida_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdNotaFiscalRecebida_DesignTimeLayout_Reference_0})
        grdNotaFiscalRecebida_DesignTimeLayout.LayoutString = resources.GetString("grdNotaFiscalRecebida_DesignTimeLayout.LayoutString")
        Me.grdNotaFiscalRecebida.DesignTimeLayout = grdNotaFiscalRecebida_DesignTimeLayout
        Me.grdNotaFiscalRecebida.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdNotaFiscalRecebida.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdNotaFiscalRecebida.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdNotaFiscalRecebida.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdNotaFiscalRecebida.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdNotaFiscalRecebida.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNotaFiscalRecebida.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNotaFiscalRecebida.FrozenColumns = 2
        Me.grdNotaFiscalRecebida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNotaFiscalRecebida.GroupByBoxVisible = False
        Me.grdNotaFiscalRecebida.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdNotaFiscalRecebida.Hierarchical = True
        Me.grdNotaFiscalRecebida.Location = New System.Drawing.Point(8, 77)
        Me.grdNotaFiscalRecebida.Name = "grdNotaFiscalRecebida"
        Me.grdNotaFiscalRecebida.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNotaFiscalRecebida.RecordNavigator = True
        Me.grdNotaFiscalRecebida.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdNotaFiscalRecebida.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdNotaFiscalRecebida.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdNotaFiscalRecebida.Size = New System.Drawing.Size(896, 404)
        Me.grdNotaFiscalRecebida.TabIndex = 1
        Me.grdNotaFiscalRecebida.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscalRecebida.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdNotaFiscalRecebida.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdNotaFiscalRecebida.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdNotaFiscalRecebida.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdNotaFiscalRecebida.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNotaFiscalRecebida.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdNotaFiscalRecebida.UpdateOnLeave = False
        Me.grdNotaFiscalRecebida.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNotaFiscalRecebida.VisualStyleManager = Me.vsmMain
        '
        'txtOrdemProducaoFiltro
        '
        Me.txtOrdemProducaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOrdemProducaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducaoFiltro.Location = New System.Drawing.Point(691, 33)
        Me.txtOrdemProducaoFiltro.MaxLength = 20
        Me.txtOrdemProducaoFiltro.Name = "txtOrdemProducaoFiltro"
        Me.txtOrdemProducaoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtOrdemProducaoFiltro.TabIndex = 12
        '
        'lblOrdemProducaoFiltro
        '
        Me.lblOrdemProducaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrdemProducaoFiltro.AutoSize = True
        Me.lblOrdemProducaoFiltro.Location = New System.Drawing.Point(688, 16)
        Me.lblOrdemProducaoFiltro.Name = "lblOrdemProducaoFiltro"
        Me.lblOrdemProducaoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducaoFiltro.TabIndex = 11
        Me.lblOrdemProducaoFiltro.Text = "Ordem Produção:"
        '
        'frmFatEmissaoNFeDevolucaoNotaFiscalFornecedor
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
        Me.Name = "frmFatEmissaoNFeDevolucaoNotaFiscalFornecedor"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nota Fiscal Eletrônica - Devolução de Fornecedor"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpPedidoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPedidoVenda.ResumeLayout(False)
        Me.grpPedidoVenda.PerformLayout()
        CType(Me.grdNotaFiscalRecebida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpPedidoVenda As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnImportarDados As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCNPJCPFFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNPJCPFFiltro As System.Windows.Forms.Label
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboFornecedorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdNotaFiscalRecebida As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaRegraVenda As System.Windows.Forms.Label
    Friend WithEvents picLegendaRegraVenda As System.Windows.Forms.PictureBox
    Friend WithEvents chkDefinirImposto As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents cboDestinacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDestinacao As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducaoFiltro As System.Windows.Forms.Label
End Class
