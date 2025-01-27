<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstListagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstListagem))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdGrupoItemQuantidade_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim grdGrupoItemPrecoVenda_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series2 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title2 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim grdGrupoItemCustoMedio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ChartArea3 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend3 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series3 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title3 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim grdPontoReposicao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ChartArea4 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend4 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series4 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title4 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim ChartArea5 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend5 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series5 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title5 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkIncluirZerado = New Janus.Windows.EditControls.UICheckBox()
        Me.lblDataInicioFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboUnidadeMedidaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboMarcaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblInsumoProducaoFiltro = New System.Windows.Forms.Label()
        Me.cboInsumoProducaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConsiderarLoteFiltro = New System.Windows.Forms.Label()
        Me.cboConsiderarLoteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataCorteFiltro = New System.Windows.Forms.Label()
        Me.dtpDataCorteFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtLocalizacaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLocalizacaoFiltro = New System.Windows.Forms.Label()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtLoteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLoteFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.cboDepositoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepositoFiltro = New System.Windows.Forms.Label()
        Me.lblMarcaFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.lblUnidadeMedidaFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagGrafico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltroGrafico = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrarGrafico = New Janus.Windows.EditControls.UIButton()
        Me.cboDepositoFiltroGrafico = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepositoFiltroGrafico = New System.Windows.Forms.Label()
        Me.grpControleGrafico = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSairGrafico = New Janus.Windows.EditControls.UIButton()
        Me.tabGrafico = New Janus.Windows.UI.Tab.UITab()
        Me.pagGrupoItemQuantidade = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridGrupoItemQuantidade = New System.Windows.Forms.Button()
        Me.btnGraficoGrupoItemQuantidade = New System.Windows.Forms.Button()
        Me.btnConfigurarGridGrupoItemQuantidade = New System.Windows.Forms.Button()
        Me.grdGrupoItemQuantidade = New Janus.Windows.GridEX.GridEX()
        Me.chrGrupoItemQuantidade = New Dundas.Charting.WinControl.Chart()
        Me.pagGrupoItemPrecoVenda = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridGrupoItemPrecoVenda = New System.Windows.Forms.Button()
        Me.btnGraficoGrupoItemPrecoVenda = New System.Windows.Forms.Button()
        Me.btnConfigurarGridGrupoItemPrecoVenda = New System.Windows.Forms.Button()
        Me.grdGrupoItemPrecoVenda = New Janus.Windows.GridEX.GridEX()
        Me.chrGrupoItemPrecoVenda = New Dundas.Charting.WinControl.Chart()
        Me.pagGrupoItemCustoMedio = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridGrupoItemCustoMedio = New System.Windows.Forms.Button()
        Me.btnGraficoGrupoItemCustoMedio = New System.Windows.Forms.Button()
        Me.btnConfigurarGridGrupoItemCustoMedio = New System.Windows.Forms.Button()
        Me.grdGrupoItemCustoMedio = New Janus.Windows.GridEX.GridEX()
        Me.chrGrupoItemCustoMedio = New Dundas.Charting.WinControl.Chart()
        Me.pagPontoReposicao = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridPontoReposicao = New System.Windows.Forms.Button()
        Me.btnGraficoPontoReposicao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPontoReposicao = New System.Windows.Forms.Button()
        Me.grdPontoReposicao = New Janus.Windows.GridEX.GridEX()
        Me.chrPontoReposicao = New Dundas.Charting.WinControl.Chart()
        Me.chrDados = New Dundas.Charting.WinControl.Chart()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGrafico.SuspendLayout()
        CType(Me.grpFiltroGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltroGrafico.SuspendLayout()
        CType(Me.grpControleGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleGrafico.SuspendLayout()
        CType(Me.tabGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGrafico.SuspendLayout()
        Me.pagGrupoItemQuantidade.SuspendLayout()
        CType(Me.grdGrupoItemQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrGrupoItemQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGrupoItemPrecoVenda.SuspendLayout()
        CType(Me.grdGrupoItemPrecoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrGrupoItemPrecoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGrupoItemCustoMedio.SuspendLayout()
        CType(Me.grdGrupoItemCustoMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrGrupoItemCustoMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagPontoReposicao.SuspendLayout()
        CType(Me.grdPontoReposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrPontoReposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrDados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagGrafico})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 24)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 541)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Listagem"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 461)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 22
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 461)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 12
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 461)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 9
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.chkIncluirZerado)
        Me.grpFiltro.Controls.Add(Me.lblDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboUnidadeMedidaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblInsumoProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboInsumoProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblConsiderarLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.cboConsiderarLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataCorteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataCorteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtLocalizacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblLocalizacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.cboDepositoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDepositoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblUnidadeMedidaFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'chkIncluirZerado
        '
        Me.chkIncluirZerado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncluirZerado.Location = New System.Drawing.Point(848, 34)
        Me.chkIncluirZerado.Name = "chkIncluirZerado"
        Me.chkIncluirZerado.Size = New System.Drawing.Size(125, 20)
        Me.chkIncluirZerado.TabIndex = 17
        Me.chkIncluirZerado.Text = "Incluir Saldo Zerado"
        '
        'lblDataInicioFiltro
        '
        Me.lblDataInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataInicioFiltro.AutoSize = True
        Me.lblDataInicioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataInicioFiltro.Location = New System.Drawing.Point(232, 97)
        Me.lblDataInicioFiltro.Name = "lblDataInicioFiltro"
        Me.lblDataInicioFiltro.Size = New System.Drawing.Size(79, 16)
        Me.lblDataInicioFiltro.TabIndex = 16
        Me.lblDataInicioFiltro.Text = "Data Início:"
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(235, 114)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(102, 23)
        Me.dtpDataInicioFiltro.TabIndex = 17
        '
        'cboUnidadeMedidaFiltro
        '
        Me.cboUnidadeMedidaFiltro.AutoSize = False
        Me.cboUnidadeMedidaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboUnidadeMedidaFiltro.Name = "cboUnidadeMedidaFiltro"
        Me.cboUnidadeMedidaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaFiltro.Size = New System.Drawing.Size(98, 20)
        Me.cboUnidadeMedidaFiltro.TabIndex = 25
        '
        'cboMarcaFiltro
        '
        Me.cboMarcaFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMarcaFiltro.AutoSize = False
        Me.cboMarcaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMarcaFiltro.Location = New System.Drawing.Point(9, 114)
        Me.cboMarcaFiltro.Name = "cboMarcaFiltro"
        Me.cboMarcaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMarcaFiltro.Size = New System.Drawing.Size(217, 20)
        Me.cboMarcaFiltro.TabIndex = 15
        '
        'lblInsumoProducaoFiltro
        '
        Me.lblInsumoProducaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInsumoProducaoFiltro.AutoSize = True
        Me.lblInsumoProducaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInsumoProducaoFiltro.Location = New System.Drawing.Point(448, 97)
        Me.lblInsumoProducaoFiltro.Name = "lblInsumoProducaoFiltro"
        Me.lblInsumoProducaoFiltro.Size = New System.Drawing.Size(142, 16)
        Me.lblInsumoProducaoFiltro.TabIndex = 20
        Me.lblInsumoProducaoFiltro.Text = "Insumo de Produção:"
        '
        'cboInsumoProducaoFiltro
        '
        Me.cboInsumoProducaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboInsumoProducaoFiltro.AutoSize = False
        Me.cboInsumoProducaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboInsumoProducaoFiltro.Location = New System.Drawing.Point(451, 114)
        Me.cboInsumoProducaoFiltro.Name = "cboInsumoProducaoFiltro"
        Me.cboInsumoProducaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboInsumoProducaoFiltro.Size = New System.Drawing.Size(131, 20)
        Me.cboInsumoProducaoFiltro.TabIndex = 21
        '
        'lblConsiderarLoteFiltro
        '
        Me.lblConsiderarLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConsiderarLoteFiltro.AutoSize = True
        Me.lblConsiderarLoteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConsiderarLoteFiltro.Location = New System.Drawing.Point(585, 57)
        Me.lblConsiderarLoteFiltro.Name = "lblConsiderarLoteFiltro"
        Me.lblConsiderarLoteFiltro.Size = New System.Drawing.Size(114, 16)
        Me.lblConsiderarLoteFiltro.TabIndex = 10
        Me.lblConsiderarLoteFiltro.Text = "Considerar Lote:"
        '
        'cboConsiderarLoteFiltro
        '
        Me.cboConsiderarLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboConsiderarLoteFiltro.AutoSize = False
        Me.cboConsiderarLoteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConsiderarLoteFiltro.Location = New System.Drawing.Point(588, 74)
        Me.cboConsiderarLoteFiltro.Name = "cboConsiderarLoteFiltro"
        Me.cboConsiderarLoteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConsiderarLoteFiltro.Size = New System.Drawing.Size(150, 20)
        Me.cboConsiderarLoteFiltro.TabIndex = 11
        '
        'lblDataCorteFiltro
        '
        Me.lblDataCorteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataCorteFiltro.AutoSize = True
        Me.lblDataCorteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataCorteFiltro.Location = New System.Drawing.Point(340, 97)
        Me.lblDataCorteFiltro.Name = "lblDataCorteFiltro"
        Me.lblDataCorteFiltro.Size = New System.Drawing.Size(81, 16)
        Me.lblDataCorteFiltro.TabIndex = 18
        Me.lblDataCorteFiltro.Text = "Data Corte:"
        '
        'dtpDataCorteFiltro
        '
        Me.dtpDataCorteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataCorteFiltro.DropDownCalendar.Name = ""
        Me.dtpDataCorteFiltro.Location = New System.Drawing.Point(343, 114)
        Me.dtpDataCorteFiltro.Name = "dtpDataCorteFiltro"
        Me.dtpDataCorteFiltro.ShowCheckBox = True
        Me.dtpDataCorteFiltro.Size = New System.Drawing.Size(102, 23)
        Me.dtpDataCorteFiltro.TabIndex = 19
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatusFiltro.Location = New System.Drawing.Point(585, 97)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(52, 16)
        Me.lblStatusFiltro.TabIndex = 22
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFiltro.AutoSize = False
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusFiltro.Location = New System.Drawing.Point(588, 114)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusFiltro.Size = New System.Drawing.Size(254, 20)
        Me.cboStatusFiltro.TabIndex = 23
        '
        'txtLocalizacaoFiltro
        '
        Me.txtLocalizacaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocalizacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalizacaoFiltro.Location = New System.Drawing.Point(744, 74)
        Me.txtLocalizacaoFiltro.MaxLength = 35
        Me.txtLocalizacaoFiltro.Name = "txtLocalizacaoFiltro"
        Me.txtLocalizacaoFiltro.Size = New System.Drawing.Size(98, 23)
        Me.txtLocalizacaoFiltro.TabIndex = 13
        '
        'lblLocalizacaoFiltro
        '
        Me.lblLocalizacaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLocalizacaoFiltro.AutoSize = True
        Me.lblLocalizacaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLocalizacaoFiltro.Location = New System.Drawing.Point(741, 57)
        Me.lblLocalizacaoFiltro.Name = "lblLocalizacaoFiltro"
        Me.lblLocalizacaoFiltro.Size = New System.Drawing.Size(86, 16)
        Me.lblLocalizacaoFiltro.TabIndex = 12
        Me.lblLocalizacaoFiltro.Text = "Localização:"
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(340, 17)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(91, 16)
        Me.lblGrupoItemFiltro.TabIndex = 2
        Me.lblGrupoItemFiltro.Text = "Grupo - Item:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoItemFiltro.AutoSize = False
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(343, 34)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(239, 20)
        Me.cboGrupoItemFiltro.TabIndex = 3
        '
        'txtLoteFiltro
        '
        Me.txtLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteFiltro.Location = New System.Drawing.Point(744, 34)
        Me.txtLoteFiltro.MaxLength = 50
        Me.txtLoteFiltro.Name = "txtLoteFiltro"
        Me.txtLoteFiltro.Size = New System.Drawing.Size(98, 23)
        Me.txtLoteFiltro.TabIndex = 7
        '
        'lblLoteFiltro
        '
        Me.lblLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoteFiltro.AutoSize = True
        Me.lblLoteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLoteFiltro.Location = New System.Drawing.Point(741, 17)
        Me.lblLoteFiltro.Name = "lblLoteFiltro"
        Me.lblLoteFiltro.Size = New System.Drawing.Size(40, 16)
        Me.lblLoteFiltro.TabIndex = 6
        Me.lblLoteFiltro.Text = "Lote:"
        '
        'txtCodigoProdutoFiltro
        '
        Me.txtCodigoProdutoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProdutoFiltro.Location = New System.Drawing.Point(588, 34)
        Me.txtCodigoProdutoFiltro.MaxLength = 60
        Me.txtCodigoProdutoFiltro.Name = "txtCodigoProdutoFiltro"
        Me.txtCodigoProdutoFiltro.Size = New System.Drawing.Size(150, 23)
        Me.txtCodigoProdutoFiltro.TabIndex = 5
        '
        'lblCodigoProdutoFiltro
        '
        Me.lblCodigoProdutoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoProdutoFiltro.AutoSize = True
        Me.lblCodigoProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoFiltro.Location = New System.Drawing.Point(585, 17)
        Me.lblCodigoProdutoFiltro.Name = "lblCodigoProdutoFiltro"
        Me.lblCodigoProdutoFiltro.Size = New System.Drawing.Size(131, 16)
        Me.lblCodigoProdutoFiltro.TabIndex = 4
        Me.lblCodigoProdutoFiltro.Text = "Código do Produto:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 24
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboDepositoFiltro
        '
        Me.cboDepositoFiltro.AutoSize = False
        Me.cboDepositoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoFiltro.Location = New System.Drawing.Point(113, 34)
        Me.cboDepositoFiltro.Name = "cboDepositoFiltro"
        Me.cboDepositoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepositoFiltro.Size = New System.Drawing.Size(224, 20)
        Me.cboDepositoFiltro.TabIndex = 1
        '
        'lblDepositoFiltro
        '
        Me.lblDepositoFiltro.AutoSize = True
        Me.lblDepositoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoFiltro.Location = New System.Drawing.Point(110, 17)
        Me.lblDepositoFiltro.Name = "lblDepositoFiltro"
        Me.lblDepositoFiltro.Size = New System.Drawing.Size(68, 16)
        Me.lblDepositoFiltro.TabIndex = 0
        Me.lblDepositoFiltro.Text = "Depósito:"
        '
        'lblMarcaFiltro
        '
        Me.lblMarcaFiltro.AutoSize = True
        Me.lblMarcaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcaFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblMarcaFiltro.Name = "lblMarcaFiltro"
        Me.lblMarcaFiltro.Size = New System.Drawing.Size(51, 16)
        Me.lblMarcaFiltro.TabIndex = 14
        Me.lblMarcaFiltro.Text = "Marca:"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtDescricaoFiltro.MaxLength = 120
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(573, 23)
        Me.txtDescricaoFiltro.TabIndex = 9
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(75, 16)
        Me.lblDescricaoFiltro.TabIndex = 8
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'lblUnidadeMedidaFiltro
        '
        Me.lblUnidadeMedidaFiltro.AutoSize = True
        Me.lblUnidadeMedidaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedidaFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblUnidadeMedidaFiltro.Name = "lblUnidadeMedidaFiltro"
        Me.lblUnidadeMedidaFiltro.Size = New System.Drawing.Size(106, 16)
        Me.lblUnidadeMedidaFiltro.TabIndex = 24
        Me.lblUnidadeMedidaFiltro.Text = "Und. Med. Ref.:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnImprimir)
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 481)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(982, 51)
        Me.grpControle.TabIndex = 2
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(119, 16)
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
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Location = New System.Drawing.Point(8, 156)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 322)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagGrafico
        '
        Me.pagGrafico.Controls.Add(Me.grpFiltroGrafico)
        Me.pagGrafico.Controls.Add(Me.grpControleGrafico)
        Me.pagGrafico.Controls.Add(Me.tabGrafico)
        Me.pagGrafico.Key = "pagGrafico"
        Me.pagGrafico.Location = New System.Drawing.Point(1, 22)
        Me.pagGrafico.Name = "pagGrafico"
        Me.pagGrafico.Size = New System.Drawing.Size(998, 543)
        Me.pagGrafico.TabStop = True
        Me.pagGrafico.Text = "Gráfico"
        '
        'grpFiltroGrafico
        '
        Me.grpFiltroGrafico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltroGrafico.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltroGrafico.Controls.Add(Me.btnFiltrarGrafico)
        Me.grpFiltroGrafico.Controls.Add(Me.cboDepositoFiltroGrafico)
        Me.grpFiltroGrafico.Controls.Add(Me.lblDepositoFiltroGrafico)
        Me.grpFiltroGrafico.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltroGrafico.Name = "grpFiltroGrafico"
        Me.grpFiltroGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltroGrafico.Size = New System.Drawing.Size(982, 64)
        Me.grpFiltroGrafico.TabIndex = 5
        Me.grpFiltroGrafico.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltroGrafico.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrarGrafico
        '
        Me.btnFiltrarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarGrafico.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarGrafico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarGrafico.Location = New System.Drawing.Point(882, 31)
        Me.btnFiltrarGrafico.Name = "btnFiltrarGrafico"
        Me.btnFiltrarGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarGrafico.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarGrafico.TabIndex = 16
        Me.btnFiltrarGrafico.Text = "Filtrar"
        Me.btnFiltrarGrafico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboDepositoFiltroGrafico
        '
        Me.cboDepositoFiltroGrafico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDepositoFiltroGrafico.AutoSize = False
        Me.cboDepositoFiltroGrafico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoFiltroGrafico.Location = New System.Drawing.Point(9, 34)
        Me.cboDepositoFiltroGrafico.Name = "cboDepositoFiltroGrafico"
        Me.cboDepositoFiltroGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepositoFiltroGrafico.Size = New System.Drawing.Size(328, 20)
        Me.cboDepositoFiltroGrafico.TabIndex = 1
        '
        'lblDepositoFiltroGrafico
        '
        Me.lblDepositoFiltroGrafico.AutoSize = True
        Me.lblDepositoFiltroGrafico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoFiltroGrafico.Location = New System.Drawing.Point(6, 17)
        Me.lblDepositoFiltroGrafico.Name = "lblDepositoFiltroGrafico"
        Me.lblDepositoFiltroGrafico.Size = New System.Drawing.Size(68, 16)
        Me.lblDepositoFiltroGrafico.TabIndex = 0
        Me.lblDepositoFiltroGrafico.Text = "Depósito:"
        '
        'grpControleGrafico
        '
        Me.grpControleGrafico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleGrafico.BackColor = System.Drawing.Color.Transparent
        Me.grpControleGrafico.Controls.Add(Me.btnSairGrafico)
        Me.grpControleGrafico.Location = New System.Drawing.Point(8, 483)
        Me.grpControleGrafico.Name = "grpControleGrafico"
        Me.grpControleGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleGrafico.Size = New System.Drawing.Size(982, 51)
        Me.grpControleGrafico.TabIndex = 4
        Me.grpControleGrafico.VisualStyleManager = Me.vsmMain
        '
        'btnSairGrafico
        '
        Me.btnSairGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSairGrafico.Image = CType(resources.GetObject("btnSairGrafico.Image"), System.Drawing.Image)
        Me.btnSairGrafico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSairGrafico.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSairGrafico.Location = New System.Drawing.Point(882, 17)
        Me.btnSairGrafico.Name = "btnSairGrafico"
        Me.btnSairGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSairGrafico.Size = New System.Drawing.Size(91, 23)
        Me.btnSairGrafico.TabIndex = 2
        Me.btnSairGrafico.Text = "Sair"
        Me.btnSairGrafico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabGrafico
        '
        Me.tabGrafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabGrafico.BackColor = System.Drawing.Color.Transparent
        Me.tabGrafico.Location = New System.Drawing.Point(8, 73)
        Me.tabGrafico.Name = "tabGrafico"
        Me.tabGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabGrafico.ShowFocusRectangle = False
        Me.tabGrafico.Size = New System.Drawing.Size(982, 407)
        Me.tabGrafico.TabIndex = 8
        Me.tabGrafico.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagGrupoItemQuantidade, Me.pagGrupoItemPrecoVenda, Me.pagGrupoItemCustoMedio, Me.pagPontoReposicao})
        Me.tabGrafico.VisualStyleManager = Me.vsmMain
        '
        'pagGrupoItemQuantidade
        '
        Me.pagGrupoItemQuantidade.Controls.Add(Me.btnExcelGridGrupoItemQuantidade)
        Me.pagGrupoItemQuantidade.Controls.Add(Me.btnGraficoGrupoItemQuantidade)
        Me.pagGrupoItemQuantidade.Controls.Add(Me.btnConfigurarGridGrupoItemQuantidade)
        Me.pagGrupoItemQuantidade.Controls.Add(Me.grdGrupoItemQuantidade)
        Me.pagGrupoItemQuantidade.Controls.Add(Me.chrGrupoItemQuantidade)
        Me.pagGrupoItemQuantidade.Key = "pagGrupoItemQuantidade"
        Me.pagGrupoItemQuantidade.Location = New System.Drawing.Point(1, 22)
        Me.pagGrupoItemQuantidade.Name = "pagGrupoItemQuantidade"
        Me.pagGrupoItemQuantidade.Size = New System.Drawing.Size(980, 384)
        Me.pagGrupoItemQuantidade.TabStop = True
        Me.pagGrupoItemQuantidade.Text = "Grupo de Item x Quantidade"
        '
        'btnExcelGridGrupoItemQuantidade
        '
        Me.btnExcelGridGrupoItemQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridGrupoItemQuantidade.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridGrupoItemQuantidade.FlatAppearance.BorderSize = 0
        Me.btnExcelGridGrupoItemQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridGrupoItemQuantidade.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridGrupoItemQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridGrupoItemQuantidade.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridGrupoItemQuantidade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridGrupoItemQuantidade.Name = "btnExcelGridGrupoItemQuantidade"
        Me.btnExcelGridGrupoItemQuantidade.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridGrupoItemQuantidade.TabIndex = 24
        Me.btnExcelGridGrupoItemQuantidade.TabStop = False
        Me.btnExcelGridGrupoItemQuantidade.UseVisualStyleBackColor = False
        '
        'btnGraficoGrupoItemQuantidade
        '
        Me.btnGraficoGrupoItemQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGraficoGrupoItemQuantidade.BackColor = System.Drawing.Color.Transparent
        Me.btnGraficoGrupoItemQuantidade.FlatAppearance.BorderSize = 0
        Me.btnGraficoGrupoItemQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoGrupoItemQuantidade.Image = Global.INTERACTI.My.Resources.Resources.grafico
        Me.btnGraficoGrupoItemQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGraficoGrupoItemQuantidade.Location = New System.Drawing.Point(33, 358)
        Me.btnGraficoGrupoItemQuantidade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGraficoGrupoItemQuantidade.Name = "btnGraficoGrupoItemQuantidade"
        Me.btnGraficoGrupoItemQuantidade.Size = New System.Drawing.Size(24, 15)
        Me.btnGraficoGrupoItemQuantidade.TabIndex = 23
        Me.btnGraficoGrupoItemQuantidade.TabStop = False
        Me.btnGraficoGrupoItemQuantidade.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridGrupoItemQuantidade
        '
        Me.btnConfigurarGridGrupoItemQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridGrupoItemQuantidade.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridGrupoItemQuantidade.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridGrupoItemQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridGrupoItemQuantidade.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridGrupoItemQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridGrupoItemQuantidade.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridGrupoItemQuantidade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridGrupoItemQuantidade.Name = "btnConfigurarGridGrupoItemQuantidade"
        Me.btnConfigurarGridGrupoItemQuantidade.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridGrupoItemQuantidade.TabIndex = 11
        Me.btnConfigurarGridGrupoItemQuantidade.TabStop = False
        Me.btnConfigurarGridGrupoItemQuantidade.UseVisualStyleBackColor = False
        '
        'grdGrupoItemQuantidade
        '
        Me.grdGrupoItemQuantidade.AlternatingColors = True
        Me.grdGrupoItemQuantidade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGrupoItemQuantidade.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        Me.grdGrupoItemQuantidade.ColumnAutoResize = True
        grdGrupoItemQuantidade_DesignTimeLayout.LayoutString = resources.GetString("grdGrupoItemQuantidade_DesignTimeLayout.LayoutString")
        Me.grdGrupoItemQuantidade.DesignTimeLayout = grdGrupoItemQuantidade_DesignTimeLayout
        Me.grdGrupoItemQuantidade.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdGrupoItemQuantidade.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdGrupoItemQuantidade.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdGrupoItemQuantidade.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdGrupoItemQuantidade.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdGrupoItemQuantidade.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdGrupoItemQuantidade.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdGrupoItemQuantidade.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.grdGrupoItemQuantidade.GroupByBoxVisible = False
        Me.grdGrupoItemQuantidade.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdGrupoItemQuantidade.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdGrupoItemQuantidade.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.grdGrupoItemQuantidade.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdGrupoItemQuantidade.Location = New System.Drawing.Point(8, 9)
        Me.grdGrupoItemQuantidade.Name = "grdGrupoItemQuantidade"
        Me.grdGrupoItemQuantidade.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdGrupoItemQuantidade.RecordNavigator = True
        Me.grdGrupoItemQuantidade.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdGrupoItemQuantidade.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdGrupoItemQuantidade.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdGrupoItemQuantidade.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdGrupoItemQuantidade.Size = New System.Drawing.Size(964, 366)
        Me.grdGrupoItemQuantidade.TabIndex = 3
        Me.grdGrupoItemQuantidade.TabStop = False
        Me.grdGrupoItemQuantidade.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdGrupoItemQuantidade.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdGrupoItemQuantidade.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdGrupoItemQuantidade.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdGrupoItemQuantidade.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdGrupoItemQuantidade.VisualStyleManager = Me.vsmMain
        '
        'chrGrupoItemQuantidade
        '
        Me.chrGrupoItemQuantidade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrGrupoItemQuantidade.BorderLineColor = System.Drawing.Color.Black
        Me.chrGrupoItemQuantidade.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrGrupoItemQuantidade.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.Name = "Default"
        Me.chrGrupoItemQuantidade.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Default"
        Me.chrGrupoItemQuantidade.Legends.Add(Legend1)
        Me.chrGrupoItemQuantidade.Location = New System.Drawing.Point(8, 9)
        Me.chrGrupoItemQuantidade.Name = "chrGrupoItemQuantidade"
        Me.chrGrupoItemQuantidade.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.ChartType = "Pie"
        Series1.CustomAttributes = "LabelStyle=Outside"
        Series1.Font = New System.Drawing.Font("Arial", 8.25!)
        Series1.Name = "Series1"
        Series1.ShadowOffset = 1
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrGrupoItemQuantidade.Series.Add(Series1)
        Me.chrGrupoItemQuantidade.Size = New System.Drawing.Size(964, 366)
        Me.chrGrupoItemQuantidade.TabIndex = 2
        Me.chrGrupoItemQuantidade.Text = "Chart2"
        Title1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Title1"
        Title1.Text = "Grupo de Item x Quantidade"
        Me.chrGrupoItemQuantidade.Titles.Add(Title1)
        Me.chrGrupoItemQuantidade.UI.Toolbar.Enabled = True
        '
        'pagGrupoItemPrecoVenda
        '
        Me.pagGrupoItemPrecoVenda.Controls.Add(Me.btnExcelGridGrupoItemPrecoVenda)
        Me.pagGrupoItemPrecoVenda.Controls.Add(Me.btnGraficoGrupoItemPrecoVenda)
        Me.pagGrupoItemPrecoVenda.Controls.Add(Me.btnConfigurarGridGrupoItemPrecoVenda)
        Me.pagGrupoItemPrecoVenda.Controls.Add(Me.grdGrupoItemPrecoVenda)
        Me.pagGrupoItemPrecoVenda.Controls.Add(Me.chrGrupoItemPrecoVenda)
        Me.pagGrupoItemPrecoVenda.Key = "pagGrupoItemPrecoVenda"
        Me.pagGrupoItemPrecoVenda.Location = New System.Drawing.Point(1, 22)
        Me.pagGrupoItemPrecoVenda.Name = "pagGrupoItemPrecoVenda"
        Me.pagGrupoItemPrecoVenda.Size = New System.Drawing.Size(895, 384)
        Me.pagGrupoItemPrecoVenda.TabStop = True
        Me.pagGrupoItemPrecoVenda.Text = "Grupo de Item x Preço de Venda"
        '
        'btnExcelGridGrupoItemPrecoVenda
        '
        Me.btnExcelGridGrupoItemPrecoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridGrupoItemPrecoVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridGrupoItemPrecoVenda.FlatAppearance.BorderSize = 0
        Me.btnExcelGridGrupoItemPrecoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridGrupoItemPrecoVenda.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridGrupoItemPrecoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridGrupoItemPrecoVenda.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridGrupoItemPrecoVenda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridGrupoItemPrecoVenda.Name = "btnExcelGridGrupoItemPrecoVenda"
        Me.btnExcelGridGrupoItemPrecoVenda.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridGrupoItemPrecoVenda.TabIndex = 26
        Me.btnExcelGridGrupoItemPrecoVenda.TabStop = False
        Me.btnExcelGridGrupoItemPrecoVenda.UseVisualStyleBackColor = False
        '
        'btnGraficoGrupoItemPrecoVenda
        '
        Me.btnGraficoGrupoItemPrecoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGraficoGrupoItemPrecoVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnGraficoGrupoItemPrecoVenda.FlatAppearance.BorderSize = 0
        Me.btnGraficoGrupoItemPrecoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoGrupoItemPrecoVenda.Image = Global.INTERACTI.My.Resources.Resources.grafico
        Me.btnGraficoGrupoItemPrecoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGraficoGrupoItemPrecoVenda.Location = New System.Drawing.Point(33, 358)
        Me.btnGraficoGrupoItemPrecoVenda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGraficoGrupoItemPrecoVenda.Name = "btnGraficoGrupoItemPrecoVenda"
        Me.btnGraficoGrupoItemPrecoVenda.Size = New System.Drawing.Size(24, 15)
        Me.btnGraficoGrupoItemPrecoVenda.TabIndex = 25
        Me.btnGraficoGrupoItemPrecoVenda.TabStop = False
        Me.btnGraficoGrupoItemPrecoVenda.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridGrupoItemPrecoVenda
        '
        Me.btnConfigurarGridGrupoItemPrecoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridGrupoItemPrecoVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridGrupoItemPrecoVenda.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridGrupoItemPrecoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridGrupoItemPrecoVenda.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridGrupoItemPrecoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridGrupoItemPrecoVenda.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridGrupoItemPrecoVenda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridGrupoItemPrecoVenda.Name = "btnConfigurarGridGrupoItemPrecoVenda"
        Me.btnConfigurarGridGrupoItemPrecoVenda.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridGrupoItemPrecoVenda.TabIndex = 12
        Me.btnConfigurarGridGrupoItemPrecoVenda.TabStop = False
        Me.btnConfigurarGridGrupoItemPrecoVenda.UseVisualStyleBackColor = False
        '
        'grdGrupoItemPrecoVenda
        '
        Me.grdGrupoItemPrecoVenda.AlternatingColors = True
        Me.grdGrupoItemPrecoVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGrupoItemPrecoVenda.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        Me.grdGrupoItemPrecoVenda.ColumnAutoResize = True
        grdGrupoItemPrecoVenda_DesignTimeLayout.LayoutString = resources.GetString("grdGrupoItemPrecoVenda_DesignTimeLayout.LayoutString")
        Me.grdGrupoItemPrecoVenda.DesignTimeLayout = grdGrupoItemPrecoVenda_DesignTimeLayout
        Me.grdGrupoItemPrecoVenda.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdGrupoItemPrecoVenda.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdGrupoItemPrecoVenda.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdGrupoItemPrecoVenda.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdGrupoItemPrecoVenda.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdGrupoItemPrecoVenda.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdGrupoItemPrecoVenda.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdGrupoItemPrecoVenda.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.grdGrupoItemPrecoVenda.GroupByBoxVisible = False
        Me.grdGrupoItemPrecoVenda.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdGrupoItemPrecoVenda.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdGrupoItemPrecoVenda.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.grdGrupoItemPrecoVenda.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdGrupoItemPrecoVenda.Location = New System.Drawing.Point(8, 9)
        Me.grdGrupoItemPrecoVenda.Name = "grdGrupoItemPrecoVenda"
        Me.grdGrupoItemPrecoVenda.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdGrupoItemPrecoVenda.RecordNavigator = True
        Me.grdGrupoItemPrecoVenda.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdGrupoItemPrecoVenda.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdGrupoItemPrecoVenda.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdGrupoItemPrecoVenda.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdGrupoItemPrecoVenda.Size = New System.Drawing.Size(879, 366)
        Me.grdGrupoItemPrecoVenda.TabIndex = 4
        Me.grdGrupoItemPrecoVenda.TabStop = False
        Me.grdGrupoItemPrecoVenda.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdGrupoItemPrecoVenda.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdGrupoItemPrecoVenda.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdGrupoItemPrecoVenda.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdGrupoItemPrecoVenda.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdGrupoItemPrecoVenda.VisualStyleManager = Me.vsmMain
        '
        'chrGrupoItemPrecoVenda
        '
        Me.chrGrupoItemPrecoVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrGrupoItemPrecoVenda.BorderLineColor = System.Drawing.Color.Black
        Me.chrGrupoItemPrecoVenda.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrGrupoItemPrecoVenda.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea2.BorderColor = System.Drawing.Color.Empty
        ChartArea2.Name = "Default"
        Me.chrGrupoItemPrecoVenda.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Default"
        Me.chrGrupoItemPrecoVenda.Legends.Add(Legend2)
        Me.chrGrupoItemPrecoVenda.Location = New System.Drawing.Point(8, 9)
        Me.chrGrupoItemPrecoVenda.Name = "chrGrupoItemPrecoVenda"
        Me.chrGrupoItemPrecoVenda.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series2.ChartType = "Pie"
        Series2.CustomAttributes = "LabelStyle=Outside"
        Series2.Font = New System.Drawing.Font("Arial", 8.25!)
        Series2.Name = "Series1"
        Series2.ShadowOffset = 1
        Series2.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series2.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrGrupoItemPrecoVenda.Series.Add(Series2)
        Me.chrGrupoItemPrecoVenda.Size = New System.Drawing.Size(879, 366)
        Me.chrGrupoItemPrecoVenda.TabIndex = 3
        Me.chrGrupoItemPrecoVenda.Text = "Chart2"
        Title2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Title2.Name = "Title1"
        Title2.Text = "Grupo de Item x Preço de Venda"
        Me.chrGrupoItemPrecoVenda.Titles.Add(Title2)
        Me.chrGrupoItemPrecoVenda.UI.Toolbar.Enabled = True
        '
        'pagGrupoItemCustoMedio
        '
        Me.pagGrupoItemCustoMedio.Controls.Add(Me.btnExcelGridGrupoItemCustoMedio)
        Me.pagGrupoItemCustoMedio.Controls.Add(Me.btnGraficoGrupoItemCustoMedio)
        Me.pagGrupoItemCustoMedio.Controls.Add(Me.btnConfigurarGridGrupoItemCustoMedio)
        Me.pagGrupoItemCustoMedio.Controls.Add(Me.grdGrupoItemCustoMedio)
        Me.pagGrupoItemCustoMedio.Controls.Add(Me.chrGrupoItemCustoMedio)
        Me.pagGrupoItemCustoMedio.Key = "pagGrupoItemCustoMedio"
        Me.pagGrupoItemCustoMedio.Location = New System.Drawing.Point(1, 22)
        Me.pagGrupoItemCustoMedio.Name = "pagGrupoItemCustoMedio"
        Me.pagGrupoItemCustoMedio.Size = New System.Drawing.Size(895, 384)
        Me.pagGrupoItemCustoMedio.TabStop = True
        Me.pagGrupoItemCustoMedio.Text = "Grupo de Item x Custo Médio"
        '
        'btnExcelGridGrupoItemCustoMedio
        '
        Me.btnExcelGridGrupoItemCustoMedio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridGrupoItemCustoMedio.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridGrupoItemCustoMedio.FlatAppearance.BorderSize = 0
        Me.btnExcelGridGrupoItemCustoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridGrupoItemCustoMedio.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridGrupoItemCustoMedio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridGrupoItemCustoMedio.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridGrupoItemCustoMedio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridGrupoItemCustoMedio.Name = "btnExcelGridGrupoItemCustoMedio"
        Me.btnExcelGridGrupoItemCustoMedio.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridGrupoItemCustoMedio.TabIndex = 28
        Me.btnExcelGridGrupoItemCustoMedio.TabStop = False
        Me.btnExcelGridGrupoItemCustoMedio.UseVisualStyleBackColor = False
        '
        'btnGraficoGrupoItemCustoMedio
        '
        Me.btnGraficoGrupoItemCustoMedio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGraficoGrupoItemCustoMedio.BackColor = System.Drawing.Color.Transparent
        Me.btnGraficoGrupoItemCustoMedio.FlatAppearance.BorderSize = 0
        Me.btnGraficoGrupoItemCustoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoGrupoItemCustoMedio.Image = Global.INTERACTI.My.Resources.Resources.grafico
        Me.btnGraficoGrupoItemCustoMedio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGraficoGrupoItemCustoMedio.Location = New System.Drawing.Point(33, 358)
        Me.btnGraficoGrupoItemCustoMedio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGraficoGrupoItemCustoMedio.Name = "btnGraficoGrupoItemCustoMedio"
        Me.btnGraficoGrupoItemCustoMedio.Size = New System.Drawing.Size(24, 15)
        Me.btnGraficoGrupoItemCustoMedio.TabIndex = 27
        Me.btnGraficoGrupoItemCustoMedio.TabStop = False
        Me.btnGraficoGrupoItemCustoMedio.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridGrupoItemCustoMedio
        '
        Me.btnConfigurarGridGrupoItemCustoMedio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridGrupoItemCustoMedio.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridGrupoItemCustoMedio.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridGrupoItemCustoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridGrupoItemCustoMedio.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridGrupoItemCustoMedio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridGrupoItemCustoMedio.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridGrupoItemCustoMedio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridGrupoItemCustoMedio.Name = "btnConfigurarGridGrupoItemCustoMedio"
        Me.btnConfigurarGridGrupoItemCustoMedio.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridGrupoItemCustoMedio.TabIndex = 13
        Me.btnConfigurarGridGrupoItemCustoMedio.TabStop = False
        Me.btnConfigurarGridGrupoItemCustoMedio.UseVisualStyleBackColor = False
        '
        'grdGrupoItemCustoMedio
        '
        Me.grdGrupoItemCustoMedio.AlternatingColors = True
        Me.grdGrupoItemCustoMedio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGrupoItemCustoMedio.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        Me.grdGrupoItemCustoMedio.ColumnAutoResize = True
        grdGrupoItemCustoMedio_DesignTimeLayout.LayoutString = resources.GetString("grdGrupoItemCustoMedio_DesignTimeLayout.LayoutString")
        Me.grdGrupoItemCustoMedio.DesignTimeLayout = grdGrupoItemCustoMedio_DesignTimeLayout
        Me.grdGrupoItemCustoMedio.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdGrupoItemCustoMedio.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdGrupoItemCustoMedio.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdGrupoItemCustoMedio.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdGrupoItemCustoMedio.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdGrupoItemCustoMedio.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdGrupoItemCustoMedio.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdGrupoItemCustoMedio.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.grdGrupoItemCustoMedio.GroupByBoxVisible = False
        Me.grdGrupoItemCustoMedio.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdGrupoItemCustoMedio.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdGrupoItemCustoMedio.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.grdGrupoItemCustoMedio.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdGrupoItemCustoMedio.Location = New System.Drawing.Point(8, 9)
        Me.grdGrupoItemCustoMedio.Name = "grdGrupoItemCustoMedio"
        Me.grdGrupoItemCustoMedio.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdGrupoItemCustoMedio.RecordNavigator = True
        Me.grdGrupoItemCustoMedio.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdGrupoItemCustoMedio.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdGrupoItemCustoMedio.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdGrupoItemCustoMedio.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdGrupoItemCustoMedio.Size = New System.Drawing.Size(879, 366)
        Me.grdGrupoItemCustoMedio.TabIndex = 5
        Me.grdGrupoItemCustoMedio.TabStop = False
        Me.grdGrupoItemCustoMedio.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdGrupoItemCustoMedio.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdGrupoItemCustoMedio.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdGrupoItemCustoMedio.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdGrupoItemCustoMedio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdGrupoItemCustoMedio.VisualStyleManager = Me.vsmMain
        '
        'chrGrupoItemCustoMedio
        '
        Me.chrGrupoItemCustoMedio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrGrupoItemCustoMedio.BorderLineColor = System.Drawing.Color.Black
        Me.chrGrupoItemCustoMedio.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrGrupoItemCustoMedio.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea3.BorderColor = System.Drawing.Color.Empty
        ChartArea3.Name = "Default"
        Me.chrGrupoItemCustoMedio.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Default"
        Me.chrGrupoItemCustoMedio.Legends.Add(Legend3)
        Me.chrGrupoItemCustoMedio.Location = New System.Drawing.Point(8, 9)
        Me.chrGrupoItemCustoMedio.Name = "chrGrupoItemCustoMedio"
        Me.chrGrupoItemCustoMedio.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series3.ChartType = "Pie"
        Series3.CustomAttributes = "LabelStyle=Outside"
        Series3.Font = New System.Drawing.Font("Arial", 8.25!)
        Series3.Name = "Series1"
        Series3.ShadowOffset = 1
        Series3.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series3.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrGrupoItemCustoMedio.Series.Add(Series3)
        Me.chrGrupoItemCustoMedio.Size = New System.Drawing.Size(879, 366)
        Me.chrGrupoItemCustoMedio.TabIndex = 4
        Me.chrGrupoItemCustoMedio.Text = "Chart2"
        Title3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Title3.Name = "Title1"
        Title3.Text = "Grupo de Item x Custo Médio"
        Me.chrGrupoItemCustoMedio.Titles.Add(Title3)
        Me.chrGrupoItemCustoMedio.UI.Toolbar.Enabled = True
        '
        'pagPontoReposicao
        '
        Me.pagPontoReposicao.Controls.Add(Me.btnExcelGridPontoReposicao)
        Me.pagPontoReposicao.Controls.Add(Me.btnGraficoPontoReposicao)
        Me.pagPontoReposicao.Controls.Add(Me.btnConfigurarGridPontoReposicao)
        Me.pagPontoReposicao.Controls.Add(Me.grdPontoReposicao)
        Me.pagPontoReposicao.Controls.Add(Me.chrPontoReposicao)
        Me.pagPontoReposicao.Key = "pagPontoReposicao"
        Me.pagPontoReposicao.Location = New System.Drawing.Point(1, 22)
        Me.pagPontoReposicao.Name = "pagPontoReposicao"
        Me.pagPontoReposicao.Size = New System.Drawing.Size(895, 384)
        Me.pagPontoReposicao.TabStop = True
        Me.pagPontoReposicao.Text = "Ponto de Reposição"
        '
        'btnExcelGridPontoReposicao
        '
        Me.btnExcelGridPontoReposicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPontoReposicao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPontoReposicao.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPontoReposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPontoReposicao.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPontoReposicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPontoReposicao.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridPontoReposicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPontoReposicao.Name = "btnExcelGridPontoReposicao"
        Me.btnExcelGridPontoReposicao.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPontoReposicao.TabIndex = 30
        Me.btnExcelGridPontoReposicao.TabStop = False
        Me.btnExcelGridPontoReposicao.UseVisualStyleBackColor = False
        '
        'btnGraficoPontoReposicao
        '
        Me.btnGraficoPontoReposicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGraficoPontoReposicao.BackColor = System.Drawing.Color.Transparent
        Me.btnGraficoPontoReposicao.FlatAppearance.BorderSize = 0
        Me.btnGraficoPontoReposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGraficoPontoReposicao.Image = Global.INTERACTI.My.Resources.Resources.grafico
        Me.btnGraficoPontoReposicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGraficoPontoReposicao.Location = New System.Drawing.Point(33, 358)
        Me.btnGraficoPontoReposicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGraficoPontoReposicao.Name = "btnGraficoPontoReposicao"
        Me.btnGraficoPontoReposicao.Size = New System.Drawing.Size(24, 15)
        Me.btnGraficoPontoReposicao.TabIndex = 29
        Me.btnGraficoPontoReposicao.TabStop = False
        Me.btnGraficoPontoReposicao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPontoReposicao
        '
        Me.btnConfigurarGridPontoReposicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPontoReposicao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPontoReposicao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPontoReposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPontoReposicao.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPontoReposicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPontoReposicao.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridPontoReposicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPontoReposicao.Name = "btnConfigurarGridPontoReposicao"
        Me.btnConfigurarGridPontoReposicao.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPontoReposicao.TabIndex = 10
        Me.btnConfigurarGridPontoReposicao.TabStop = False
        Me.btnConfigurarGridPontoReposicao.UseVisualStyleBackColor = False
        '
        'grdPontoReposicao
        '
        Me.grdPontoReposicao.AlternatingColors = True
        Me.grdPontoReposicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPontoReposicao.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        Me.grdPontoReposicao.ColumnAutoResize = True
        grdPontoReposicao_DesignTimeLayout.LayoutString = resources.GetString("grdPontoReposicao_DesignTimeLayout.LayoutString")
        Me.grdPontoReposicao.DesignTimeLayout = grdPontoReposicao_DesignTimeLayout
        Me.grdPontoReposicao.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPontoReposicao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPontoReposicao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPontoReposicao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPontoReposicao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPontoReposicao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPontoReposicao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPontoReposicao.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.grdPontoReposicao.GroupByBoxVisible = False
        Me.grdPontoReposicao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPontoReposicao.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdPontoReposicao.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.grdPontoReposicao.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPontoReposicao.Location = New System.Drawing.Point(8, 9)
        Me.grdPontoReposicao.Name = "grdPontoReposicao"
        Me.grdPontoReposicao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPontoReposicao.RecordNavigator = True
        Me.grdPontoReposicao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdPontoReposicao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPontoReposicao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPontoReposicao.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPontoReposicao.Size = New System.Drawing.Size(879, 366)
        Me.grdPontoReposicao.TabIndex = 6
        Me.grdPontoReposicao.TabStop = False
        Me.grdPontoReposicao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPontoReposicao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPontoReposicao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPontoReposicao.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPontoReposicao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPontoReposicao.VisualStyleManager = Me.vsmMain
        '
        'chrPontoReposicao
        '
        Me.chrPontoReposicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrPontoReposicao.BorderLineColor = System.Drawing.Color.Black
        Me.chrPontoReposicao.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrPontoReposicao.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea4.BorderColor = System.Drawing.Color.Empty
        ChartArea4.Name = "Default"
        Me.chrPontoReposicao.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Default"
        Me.chrPontoReposicao.Legends.Add(Legend4)
        Me.chrPontoReposicao.Location = New System.Drawing.Point(8, 9)
        Me.chrPontoReposicao.Name = "chrPontoReposicao"
        Me.chrPontoReposicao.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series4.ChartType = "Pie"
        Series4.CustomAttributes = "LabelStyle=Outside"
        Series4.Font = New System.Drawing.Font("Arial", 8.25!)
        Series4.Name = "Series1"
        Series4.ShadowOffset = 1
        Series4.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series4.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrPontoReposicao.Series.Add(Series4)
        Me.chrPontoReposicao.Size = New System.Drawing.Size(879, 366)
        Me.chrPontoReposicao.TabIndex = 5
        Me.chrPontoReposicao.Text = "Chart2"
        Title4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Title4.Name = "Title1"
        Title4.Text = "Ponto de Reposição"
        Me.chrPontoReposicao.Titles.Add(Title4)
        Me.chrPontoReposicao.UI.Toolbar.Enabled = True
        '
        'chrDados
        '
        Me.chrDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chrDados.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrDados.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrDados.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea5.AxisX.Title = "Data"
        ChartArea5.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea5.AxisY.Title = "Fator Cambial"
        ChartArea5.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea5.BorderColor = System.Drawing.Color.Empty
        ChartArea5.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea5.Name = "Default"
        Me.chrDados.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Default"
        Me.chrDados.Legends.Add(Legend5)
        Me.chrDados.Location = New System.Drawing.Point(9, 178)
        Me.chrDados.Name = "chrDados"
        Me.chrDados.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series5.ChartType = "Line"
        Series5.CustomAttributes = "LabelStyle=Bottom"
        Series5.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Series5.Name = "Default"
        Series5.ShowLabelAsValue = True
        Series5.SmartLabels.Enabled = True
        Series5.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series5.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrDados.Series.Add(Series5)
        Me.chrDados.Size = New System.Drawing.Size(897, 324)
        Me.chrDados.TabIndex = 4
        Title5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Title5.Name = "Variação Cambial"
        Title5.Text = "Variação Cambial"
        Me.chrDados.Titles.Add(Title5)
        Me.chrDados.UI.Toolbar.Enabled = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnImprimir.Location = New System.Drawing.Point(785, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 13
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrEstListagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.chrDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstListagem"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGrafico.ResumeLayout(False)
        CType(Me.grpFiltroGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltroGrafico.ResumeLayout(False)
        Me.grpFiltroGrafico.PerformLayout()
        CType(Me.grpControleGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleGrafico.ResumeLayout(False)
        CType(Me.tabGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGrafico.ResumeLayout(False)
        Me.pagGrupoItemQuantidade.ResumeLayout(False)
        CType(Me.grdGrupoItemQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrGrupoItemQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGrupoItemPrecoVenda.ResumeLayout(False)
        CType(Me.grdGrupoItemPrecoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrGrupoItemPrecoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGrupoItemCustoMedio.ResumeLayout(False)
        CType(Me.grdGrupoItemCustoMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrGrupoItemCustoMedio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagPontoReposicao.ResumeLayout(False)
        CType(Me.grdPontoReposicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrPontoReposicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtLocalizacaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLocalizacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtLoteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLoteFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboDepositoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepositoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblMarcaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents chrDados As Dundas.Charting.WinControl.Chart
    Friend WithEvents pagGrafico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleGrafico As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSairGrafico As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltroGrafico As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrarGrafico As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboDepositoFiltroGrafico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepositoFiltroGrafico As System.Windows.Forms.Label
    Friend WithEvents tabGrafico As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagGrupoItemQuantidade As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents chrGrupoItemQuantidade As Dundas.Charting.WinControl.Chart
    Friend WithEvents pagGrupoItemPrecoVenda As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagGrupoItemCustoMedio As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagPontoReposicao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdGrupoItemQuantidade As Janus.Windows.GridEX.GridEX
    Friend WithEvents chrGrupoItemPrecoVenda As Dundas.Charting.WinControl.Chart
    Friend WithEvents grdGrupoItemPrecoVenda As Janus.Windows.GridEX.GridEX
    Friend WithEvents chrGrupoItemCustoMedio As Dundas.Charting.WinControl.Chart
    Friend WithEvents grdGrupoItemCustoMedio As Janus.Windows.GridEX.GridEX
    Friend WithEvents chrPontoReposicao As Dundas.Charting.WinControl.Chart
    Friend WithEvents grdPontoReposicao As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents lblDataCorteFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataCorteFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblConsiderarLoteFiltro As System.Windows.Forms.Label
    Friend WithEvents cboConsiderarLoteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPontoReposicao As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridGrupoItemQuantidade As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridGrupoItemPrecoVenda As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridGrupoItemCustoMedio As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridGrupoItemQuantidade As System.Windows.Forms.Button
    Friend WithEvents btnGraficoGrupoItemQuantidade As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridGrupoItemPrecoVenda As System.Windows.Forms.Button
    Friend WithEvents btnGraficoGrupoItemPrecoVenda As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridGrupoItemCustoMedio As System.Windows.Forms.Button
    Friend WithEvents btnGraficoGrupoItemCustoMedio As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridPontoReposicao As System.Windows.Forms.Button
    Friend WithEvents btnGraficoPontoReposicao As System.Windows.Forms.Button
    Friend WithEvents lblInsumoProducaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboInsumoProducaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboMarcaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboUnidadeMedidaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataInicioFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents chkIncluirZerado As Janus.Windows.EditControls.UICheckBox
    Private WithEvents btnImprimir As Janus.Windows.EditControls.UIButton

End Class
