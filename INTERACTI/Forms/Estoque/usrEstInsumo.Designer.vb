<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstInsumo
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstInsumo))
        Dim grdPagamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPagamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaSaldoMenor = New System.Windows.Forms.Label()
        Me.picLegendaSaldoMenor = New System.Windows.Forms.PictureBox()
        Me.lblLegendaSaldoMaior = New System.Windows.Forms.Label()
        Me.picLegendaSaldoMaior = New System.Windows.Forms.PictureBox()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExportarGridPagamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridPagamento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPagamento = New System.Windows.Forms.Button()
        Me.grdPagamento = New Janus.Windows.GridEX.GridEX()
        Me.grpPagamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoMovimentacao = New System.Windows.Forms.Label()
        Me.cboTipoMovimentacao = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcluirMovimentacao = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataPagamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPagamento = New System.Windows.Forms.Label()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.btnPagar = New Janus.Windows.EditControls.UIButton()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataSaldo = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataSaldo = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.txtSaldo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.grpLegendaMovimentacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaSaida = New System.Windows.Forms.Label()
        Me.picLegendaSaida = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEntrada = New System.Windows.Forms.Label()
        Me.picLegendaEntrada = New System.Windows.Forms.PictureBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaSaldoMenor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaSaldoMaior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grdPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPagamento.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpLegendaMovimentacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegendaMovimentacao.SuspendLayout()
        CType(Me.picLegendaSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Insumos"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaSaldoMenor)
        Me.grpLegenda.Controls.Add(Me.picLegendaSaldoMenor)
        Me.grpLegenda.Controls.Add(Me.lblLegendaSaldoMaior)
        Me.grpLegenda.Controls.Add(Me.picLegendaSaldoMaior)
        Me.grpLegenda.Location = New System.Drawing.Point(8, 393)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(234, 51)
        Me.grpLegenda.TabIndex = 82
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaSaldoMenor
        '
        Me.lblLegendaSaldoMenor.AutoSize = True
        Me.lblLegendaSaldoMenor.Location = New System.Drawing.Point(28, 30)
        Me.lblLegendaSaldoMenor.Name = "lblLegendaSaldoMenor"
        Me.lblLegendaSaldoMenor.Size = New System.Drawing.Size(199, 14)
        Me.lblLegendaSaldoMenor.TabIndex = 1
        Me.lblLegendaSaldoMenor.Text = "Saldo Menor ou Igual ao Estoque Mínimo"
        '
        'picLegendaSaldoMenor
        '
        Me.picLegendaSaldoMenor.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaSaldoMenor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaSaldoMenor.Location = New System.Drawing.Point(9, 30)
        Me.picLegendaSaldoMenor.Name = "picLegendaSaldoMenor"
        Me.picLegendaSaldoMenor.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaSaldoMenor.TabIndex = 10
        Me.picLegendaSaldoMenor.TabStop = False
        '
        'lblLegendaSaldoMaior
        '
        Me.lblLegendaSaldoMaior.AutoSize = True
        Me.lblLegendaSaldoMaior.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaSaldoMaior.Name = "lblLegendaSaldoMaior"
        Me.lblLegendaSaldoMaior.Size = New System.Drawing.Size(161, 14)
        Me.lblLegendaSaldoMaior.TabIndex = 0
        Me.lblLegendaSaldoMaior.Text = "Saldo Maior que Estoque Mínimo"
        '
        'picLegendaSaldoMaior
        '
        Me.picLegendaSaldoMaior.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaSaldoMaior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaSaldoMaior.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaSaldoMaior.Name = "picLegendaSaldoMaior"
        Me.picLegendaSaldoMaior.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaSaldoMaior.TabIndex = 4
        Me.picLegendaSaldoMaior.TabStop = False
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 81
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 373)
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 314)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 67)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatusFiltro.Location = New System.Drawing.Point(193, 17)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 21
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AutoSize = False
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusFiltro.Location = New System.Drawing.Point(196, 34)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusFiltro.Size = New System.Drawing.Size(282, 20)
        Me.cboStatusFiltro.TabIndex = 1
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 0
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoFiltro.MaxLength = 50
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(181, 20)
        Me.txtDescricaoFiltro.TabIndex = 0
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(800, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(248, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(657, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(460, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 0
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(557, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpLegendaMovimentacao)
        Me.pagDados.Controls.Add(Me.btnExportarGridPagamento)
        Me.pagDados.Controls.Add(Me.btnAgruparGridPagamento)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridPagamento)
        Me.pagDados.Controls.Add(Me.grdPagamento)
        Me.pagDados.Controls.Add(Me.grpPagamento)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados"
        '
        'btnExportarGridPagamento
        '
        Me.btnExportarGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportarGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExportarGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnExportarGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExportarGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExportarGridPagamento.Location = New System.Drawing.Point(57, 370)
        Me.btnExportarGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExportarGridPagamento.Name = "btnExportarGridPagamento"
        Me.btnExportarGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnExportarGridPagamento.TabIndex = 84
        Me.btnExportarGridPagamento.TabStop = False
        Me.btnExportarGridPagamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPagamento
        '
        Me.btnAgruparGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPagamento.Location = New System.Drawing.Point(33, 370)
        Me.btnAgruparGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPagamento.Name = "btnAgruparGridPagamento"
        Me.btnAgruparGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPagamento.TabIndex = 83
        Me.btnAgruparGridPagamento.TabStop = False
        Me.btnAgruparGridPagamento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPagamento
        '
        Me.btnConfigurarGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPagamento.Location = New System.Drawing.Point(9, 370)
        Me.btnConfigurarGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPagamento.Name = "btnConfigurarGridPagamento"
        Me.btnConfigurarGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPagamento.TabIndex = 82
        Me.btnConfigurarGridPagamento.TabStop = False
        Me.btnConfigurarGridPagamento.UseVisualStyleBackColor = False
        '
        'grdPagamento
        '
        Me.grdPagamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPagamento.AlternatingColors = True
        Me.grdPagamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdPagamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdPagamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdPagamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdPagamento_DesignTimeLayout_Reference_0})
        grdPagamento_DesignTimeLayout.LayoutString = resources.GetString("grdPagamento_DesignTimeLayout.LayoutString")
        Me.grdPagamento.DesignTimeLayout = grdPagamento_DesignTimeLayout
        Me.grdPagamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPagamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPagamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPagamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPagamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPagamento.GroupByBoxVisible = False
        Me.grdPagamento.Location = New System.Drawing.Point(8, 162)
        Me.grdPagamento.Name = "grdPagamento"
        Me.grdPagamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPagamento.RecordNavigator = True
        Me.grdPagamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPagamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPagamento.Size = New System.Drawing.Size(897, 225)
        Me.grdPagamento.TabIndex = 3
        Me.grdPagamento.TabStop = False
        Me.grdPagamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPagamento.VisualStyleManager = Me.vsmMain
        '
        'grpPagamento
        '
        Me.grpPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPagamento.BackColor = System.Drawing.Color.Transparent
        Me.grpPagamento.Controls.Add(Me.lblTipoMovimentacao)
        Me.grpPagamento.Controls.Add(Me.cboTipoMovimentacao)
        Me.grpPagamento.Controls.Add(Me.btnExcluirMovimentacao)
        Me.grpPagamento.Controls.Add(Me.dtpDataPagamento)
        Me.grpPagamento.Controls.Add(Me.lblDataPagamento)
        Me.grpPagamento.Controls.Add(Me.lblFuncionario)
        Me.grpPagamento.Controls.Add(Me.cboFuncionario)
        Me.grpPagamento.Controls.Add(Me.btnPagar)
        Me.grpPagamento.Controls.Add(Me.lblQuantidade)
        Me.grpPagamento.Controls.Add(Me.txtQuantidade)
        Me.grpPagamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPagamento.Location = New System.Drawing.Point(8, 77)
        Me.grpPagamento.Name = "grpPagamento"
        Me.grpPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPagamento.Size = New System.Drawing.Size(897, 79)
        Me.grpPagamento.TabIndex = 2
        Me.grpPagamento.VisualStyleManager = Me.vsmMain
        '
        'lblTipoMovimentacao
        '
        Me.lblTipoMovimentacao.AutoSize = True
        Me.lblTipoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoMovimentacao.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoMovimentacao.Name = "lblTipoMovimentacao"
        Me.lblTipoMovimentacao.Size = New System.Drawing.Size(102, 14)
        Me.lblTipoMovimentacao.TabIndex = 19
        Me.lblTipoMovimentacao.Text = "Tipo Movimentação:"
        '
        'cboTipoMovimentacao
        '
        Me.cboTipoMovimentacao.AutoSize = False
        Me.cboTipoMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoMovimentacao.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoMovimentacao.Name = "cboTipoMovimentacao"
        Me.cboTipoMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoMovimentacao.Size = New System.Drawing.Size(99, 20)
        Me.cboTipoMovimentacao.TabIndex = 0
        '
        'btnExcluirMovimentacao
        '
        Me.btnExcluirMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirMovimentacao.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirMovimentacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirMovimentacao.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirMovimentacao.Location = New System.Drawing.Point(800, 46)
        Me.btnExcluirMovimentacao.Name = "btnExcluirMovimentacao"
        Me.btnExcluirMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirMovimentacao.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirMovimentacao.TabIndex = 5
        Me.btnExcluirMovimentacao.Text = "Excluir"
        Me.btnExcluirMovimentacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataPagamento
        '
        '
        '
        '
        Me.dtpDataPagamento.DropDownCalendar.Name = ""
        Me.dtpDataPagamento.Location = New System.Drawing.Point(442, 34)
        Me.dtpDataPagamento.Name = "dtpDataPagamento"
        Me.dtpDataPagamento.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamento.TabIndex = 3
        Me.dtpDataPagamento.Value = New Date(2013, 1, 6, 0, 0, 0, 0)
        '
        'lblDataPagamento
        '
        Me.lblDataPagamento.AutoSize = True
        Me.lblDataPagamento.Location = New System.Drawing.Point(439, 17)
        Me.lblDataPagamento.Name = "lblDataPagamento"
        Me.lblDataPagamento.Size = New System.Drawing.Size(88, 14)
        Me.lblDataPagamento.TabIndex = 17
        Me.lblDataPagamento.Text = "Data Pagamento:"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(111, 17)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(106, 14)
        Me.lblFuncionario.TabIndex = 15
        Me.lblFuncionario.Text = "Funcionário a Pagar:"
        '
        'cboFuncionario
        '
        Me.cboFuncionario.AutoSize = False
        Me.cboFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFuncionario.Location = New System.Drawing.Point(114, 34)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFuncionario.Size = New System.Drawing.Size(242, 20)
        Me.cboFuncionario.TabIndex = 1
        '
        'btnPagar
        '
        Me.btnPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar.Image = CType(resources.GetObject("btnPagar.Image"), System.Drawing.Image)
        Me.btnPagar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar.Location = New System.Drawing.Point(800, 17)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar.Size = New System.Drawing.Size(91, 23)
        Me.btnPagar.TabIndex = 4
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(359, 17)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 10
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 2
        Me.txtQuantidade.Location = New System.Drawing.Point(362, 34)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(74, 20)
        Me.txtQuantidade.TabIndex = 2
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.dtpDataSaldo)
        Me.grpDados.Controls.Add(Me.lblDataSaldo)
        Me.grpDados.Controls.Add(Me.lblSaldo)
        Me.grpDados.Controls.Add(Me.txtSaldo)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.cboCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblCodigoProduto)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 68)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'dtpDataSaldo
        '
        '
        '
        '
        Me.dtpDataSaldo.DropDownCalendar.Name = ""
        Me.dtpDataSaldo.Location = New System.Drawing.Point(795, 34)
        Me.dtpDataSaldo.Name = "dtpDataSaldo"
        Me.dtpDataSaldo.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataSaldo.TabIndex = 3
        Me.dtpDataSaldo.Value = New Date(2013, 1, 6, 0, 0, 0, 0)
        '
        'lblDataSaldo
        '
        Me.lblDataSaldo.AutoSize = True
        Me.lblDataSaldo.Location = New System.Drawing.Point(792, 17)
        Me.lblDataSaldo.Name = "lblDataSaldo"
        Me.lblDataSaldo.Size = New System.Drawing.Size(62, 14)
        Me.lblDataSaldo.TabIndex = 15
        Me.lblDataSaldo.Text = "Data Saldo:"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaldo.Location = New System.Drawing.Point(705, 17)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(37, 14)
        Me.lblSaldo.TabIndex = 14
        Me.lblSaldo.Text = "Saldo:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSaldo.DecimalDigits = 2
        Me.txtSaldo.Location = New System.Drawing.Point(708, 34)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(81, 20)
        Me.txtSaldo.TabIndex = 2
        Me.txtSaldo.Text = "0,00"
        Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(359, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 11
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(362, 34)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(340, 20)
        Me.txtDescricao.TabIndex = 1
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.AutoSize = False
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboCodigoProduto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCodigoProduto.Location = New System.Drawing.Point(9, 34)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProduto.Size = New System.Drawing.Size(347, 20)
        Me.cboCodigoProduto.TabIndex = 0
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProduto.TabIndex = 0
        Me.lblCodigoProduto.Text = "Código Produto:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Location = New System.Drawing.Point(103, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(802, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(605, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(702, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpLegendaMovimentacao
        '
        Me.grpLegendaMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegendaMovimentacao.BackColor = System.Drawing.Color.Transparent
        Me.grpLegendaMovimentacao.Controls.Add(Me.lblLegendaSaida)
        Me.grpLegendaMovimentacao.Controls.Add(Me.picLegendaSaida)
        Me.grpLegendaMovimentacao.Controls.Add(Me.lblLegendaEntrada)
        Me.grpLegendaMovimentacao.Controls.Add(Me.picLegendaEntrada)
        Me.grpLegendaMovimentacao.Location = New System.Drawing.Point(8, 393)
        Me.grpLegendaMovimentacao.Name = "grpLegendaMovimentacao"
        Me.grpLegendaMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegendaMovimentacao.Size = New System.Drawing.Size(89, 51)
        Me.grpLegendaMovimentacao.TabIndex = 85
        Me.grpLegendaMovimentacao.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaSaida
        '
        Me.lblLegendaSaida.AutoSize = True
        Me.lblLegendaSaida.Location = New System.Drawing.Point(28, 30)
        Me.lblLegendaSaida.Name = "lblLegendaSaida"
        Me.lblLegendaSaida.Size = New System.Drawing.Size(34, 14)
        Me.lblLegendaSaida.TabIndex = 1
        Me.lblLegendaSaida.Text = "Saída"
        '
        'picLegendaSaida
        '
        Me.picLegendaSaida.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaSaida.Location = New System.Drawing.Point(9, 30)
        Me.picLegendaSaida.Name = "picLegendaSaida"
        Me.picLegendaSaida.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaSaida.TabIndex = 10
        Me.picLegendaSaida.TabStop = False
        '
        'lblLegendaEntrada
        '
        Me.lblLegendaEntrada.AutoSize = True
        Me.lblLegendaEntrada.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaEntrada.Name = "lblLegendaEntrada"
        Me.lblLegendaEntrada.Size = New System.Drawing.Size(44, 14)
        Me.lblLegendaEntrada.TabIndex = 0
        Me.lblLegendaEntrada.Text = "Entrada"
        '
        'picLegendaEntrada
        '
        Me.picLegendaEntrada.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEntrada.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaEntrada.Name = "picLegendaEntrada"
        Me.picLegendaEntrada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEntrada.TabIndex = 4
        Me.picLegendaEntrada.TabStop = False
        '
        'usrEstInsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstInsumo"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaSaldoMenor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaSaldoMaior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grdPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPagamento.ResumeLayout(False)
        Me.grpPagamento.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpLegendaMovimentacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegendaMovimentacao.ResumeLayout(False)
        Me.grpLegendaMovimentacao.PerformLayout()
        CType(Me.picLegendaSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpDataSaldo As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataSaldo As System.Windows.Forms.Label
    Friend WithEvents grpPagamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPagamento As System.Windows.Forms.Label
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Private WithEvents btnPagar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grdPagamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcluirMovimentacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExportarGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPagamento As System.Windows.Forms.Button
    Friend WithEvents lblTipoMovimentacao As System.Windows.Forms.Label
    Friend WithEvents cboTipoMovimentacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaSaldoMenor As System.Windows.Forms.Label
    Friend WithEvents picLegendaSaldoMenor As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaSaldoMaior As System.Windows.Forms.Label
    Friend WithEvents picLegendaSaldoMaior As System.Windows.Forms.PictureBox
    Friend WithEvents grpLegendaMovimentacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaSaida As System.Windows.Forms.Label
    Friend WithEvents picLegendaSaida As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEntrada As System.Windows.Forms.Label
    Friend WithEvents picLegendaEntrada As System.Windows.Forms.PictureBox

End Class
