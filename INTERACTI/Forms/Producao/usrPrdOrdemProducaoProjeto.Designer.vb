<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdOrdemProducaoProjeto
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdOrdemProducaoProjeto))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdRequisicao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRequisicao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtProdutoIntermediarioFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoIntermediarioFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataOrcamentoFiltro = New System.Windows.Forms.Label()
        Me.txtOrdemProducaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoAcabadoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoAcabadoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboLote = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataSaida = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataSaida = New System.Windows.Forms.Label()
        Me.txtQuantidadeProdutoIntermediario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grdRequisicao = New Janus.Windows.GridEX.GridEX()
        Me.btnInserirItem = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirItem = New Janus.Windows.EditControls.UIButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProdutoIntermediario = New System.Windows.Forms.Label()
        Me.cboProdutoIntermediario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidadeProdutoIntermediario = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.txtQuantidadeProdutoAcabado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeProdutoAcabado = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataOrdemProducao = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.lblProdutoAcabado = New System.Windows.Forms.Label()
        Me.cboProdutoAcabado = New Janus.Windows.EditControls.UIComboBox()
        Me.btnAgruparGridServico = New System.Windows.Forms.Button()
        Me.btnConfigurarGridServico = New System.Windows.Forms.Button()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1110, 551)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(1108, 528)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Ordem de Produção - Projeto"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(33, 448)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 86
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 448)
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
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1092, 389)
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
        Me.grpFiltro.Controls.Add(Me.txtProdutoIntermediarioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoIntermediarioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataOrcamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoAcabadoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoAcabadoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1092, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtProdutoIntermediarioFiltro
        '
        Me.txtProdutoIntermediarioFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdutoIntermediarioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoIntermediarioFiltro.Location = New System.Drawing.Point(634, 34)
        Me.txtProdutoIntermediarioFiltro.MaxLength = 100
        Me.txtProdutoIntermediarioFiltro.Name = "txtProdutoIntermediarioFiltro"
        Me.txtProdutoIntermediarioFiltro.Size = New System.Drawing.Size(265, 20)
        Me.txtProdutoIntermediarioFiltro.TabIndex = 8
        '
        'lblProdutoIntermediarioFiltro
        '
        Me.lblProdutoIntermediarioFiltro.AutoSize = True
        Me.lblProdutoIntermediarioFiltro.Location = New System.Drawing.Point(631, 16)
        Me.lblProdutoIntermediarioFiltro.Name = "lblProdutoIntermediarioFiltro"
        Me.lblProdutoIntermediarioFiltro.Size = New System.Drawing.Size(111, 14)
        Me.lblProdutoIntermediarioFiltro.TabIndex = 7
        Me.lblProdutoIntermediarioFiltro.Text = "Produto Intermediário:"
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(135, 33)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 3
        Me.dtpDataInicioFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(249, 33)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 4
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataOrcamentoFiltro
        '
        Me.lblDataOrcamentoFiltro.AutoSize = True
        Me.lblDataOrcamentoFiltro.Location = New System.Drawing.Point(132, 16)
        Me.lblDataOrcamentoFiltro.Name = "lblDataOrcamentoFiltro"
        Me.lblDataOrcamentoFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataOrcamentoFiltro.TabIndex = 2
        Me.lblDataOrcamentoFiltro.Text = "Data:"
        '
        'txtOrdemProducaoFiltro
        '
        Me.txtOrdemProducaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemProducaoFiltro.MaxLength = 20
        Me.txtOrdemProducaoFiltro.Name = "txtOrdemProducaoFiltro"
        Me.txtOrdemProducaoFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtOrdemProducaoFiltro.TabIndex = 1
        '
        'lblCodigoFiltro
        '
        Me.lblCodigoFiltro.AutoSize = True
        Me.lblCodigoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoFiltro.Name = "lblCodigoFiltro"
        Me.lblCodigoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblCodigoFiltro.TabIndex = 0
        Me.lblCodigoFiltro.Text = "Ordem Produção:"
        '
        'txtProdutoAcabadoFiltro
        '
        Me.txtProdutoAcabadoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdutoAcabadoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoAcabadoFiltro.Location = New System.Drawing.Point(363, 34)
        Me.txtProdutoAcabadoFiltro.MaxLength = 100
        Me.txtProdutoAcabadoFiltro.Name = "txtProdutoAcabadoFiltro"
        Me.txtProdutoAcabadoFiltro.Size = New System.Drawing.Size(265, 20)
        Me.txtProdutoAcabadoFiltro.TabIndex = 6
        '
        'lblProdutoAcabadoFiltro
        '
        Me.lblProdutoAcabadoFiltro.AutoSize = True
        Me.lblProdutoAcabadoFiltro.Location = New System.Drawing.Point(360, 16)
        Me.lblProdutoAcabadoFiltro.Name = "lblProdutoAcabadoFiltro"
        Me.lblProdutoAcabadoFiltro.Size = New System.Drawing.Size(93, 14)
        Me.lblProdutoAcabadoFiltro.TabIndex = 5
        Me.lblProdutoAcabadoFiltro.Text = "Produto Acabado:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(992, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 9
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
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 468)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(1092, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(798, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 1
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(992, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(895, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.UiGroupBox1)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(1108, 528)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados da Ordem de Produção"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.cboLote)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataSaida)
        Me.UiGroupBox1.Controls.Add(Me.lblDataSaida)
        Me.UiGroupBox1.Controls.Add(Me.txtQuantidadeProdutoIntermediario)
        Me.UiGroupBox1.Controls.Add(Me.grdRequisicao)
        Me.UiGroupBox1.Controls.Add(Me.btnInserirItem)
        Me.UiGroupBox1.Controls.Add(Me.btnExcluirItem)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.lblProdutoIntermediario)
        Me.UiGroupBox1.Controls.Add(Me.cboProdutoIntermediario)
        Me.UiGroupBox1.Controls.Add(Me.lblQuantidadeProdutoIntermediario)
        Me.UiGroupBox1.Location = New System.Drawing.Point(9, 80)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(1090, 380)
        Me.UiGroupBox1.TabIndex = 2
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'cboLote
        '
        Me.cboLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLote.AutoSize = False
        Me.cboLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboLote.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboLote.Location = New System.Drawing.Point(609, 32)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLote.Size = New System.Drawing.Size(113, 20)
        Me.cboLote.TabIndex = 7
        '
        'dtpDataSaida
        '
        Me.dtpDataSaida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataSaida.DropDownCalendar.Name = ""
        Me.dtpDataSaida.Location = New System.Drawing.Point(728, 32)
        Me.dtpDataSaida.Name = "dtpDataSaida"
        Me.dtpDataSaida.Size = New System.Drawing.Size(135, 20)
        Me.dtpDataSaida.TabIndex = 9
        Me.dtpDataSaida.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataSaida
        '
        Me.lblDataSaida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataSaida.AutoSize = True
        Me.lblDataSaida.Location = New System.Drawing.Point(725, 15)
        Me.lblDataSaida.Name = "lblDataSaida"
        Me.lblDataSaida.Size = New System.Drawing.Size(62, 14)
        Me.lblDataSaida.TabIndex = 8
        Me.lblDataSaida.Text = "Data Saída:"
        '
        'txtQuantidadeProdutoIntermediario
        '
        Me.txtQuantidadeProdutoIntermediario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeProdutoIntermediario.DecimalDigits = 6
        Me.txtQuantidadeProdutoIntermediario.Location = New System.Drawing.Point(504, 32)
        Me.txtQuantidadeProdutoIntermediario.MaxLength = 0
        Me.txtQuantidadeProdutoIntermediario.Name = "txtQuantidadeProdutoIntermediario"
        Me.txtQuantidadeProdutoIntermediario.Size = New System.Drawing.Size(99, 20)
        Me.txtQuantidadeProdutoIntermediario.TabIndex = 5
        Me.txtQuantidadeProdutoIntermediario.Text = "0,000000"
        Me.txtQuantidadeProdutoIntermediario.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'grdRequisicao
        '
        Me.grdRequisicao.AlternatingColors = True
        Me.grdRequisicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRequisicao.ColumnAutoResize = True
        grdRequisicao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRequisicao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRequisicao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRequisicao_DesignTimeLayout_Reference_0})
        grdRequisicao_DesignTimeLayout.LayoutString = resources.GetString("grdRequisicao_DesignTimeLayout.LayoutString")
        Me.grdRequisicao.DesignTimeLayout = grdRequisicao_DesignTimeLayout
        Me.grdRequisicao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdRequisicao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdRequisicao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdRequisicao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRequisicao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRequisicao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRequisicao.GroupByBoxVisible = False
        Me.grdRequisicao.Location = New System.Drawing.Point(9, 69)
        Me.grdRequisicao.Name = "grdRequisicao"
        Me.grdRequisicao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRequisicao.RecordNavigator = True
        Me.grdRequisicao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdRequisicao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRequisicao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRequisicao.Size = New System.Drawing.Size(1067, 296)
        Me.grdRequisicao.TabIndex = 13
        Me.grdRequisicao.TabStop = False
        Me.grdRequisicao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRequisicao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRequisicao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRequisicao.VisualStyleManager = Me.vsmMain
        '
        'btnInserirItem
        '
        Me.btnInserirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirItem.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirItem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirItem.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirItem.Location = New System.Drawing.Point(883, 29)
        Me.btnInserirItem.Name = "btnInserirItem"
        Me.btnInserirItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirItem.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirItem.TabIndex = 10
        Me.btnInserirItem.Text = "Inserir"
        Me.btnInserirItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirItem
        '
        Me.btnExcluirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirItem.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirItem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirItem.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExcluirItem.Location = New System.Drawing.Point(985, 29)
        Me.btnExcluirItem.Name = "btnExcluirItem"
        Me.btnExcluirItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirItem.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirItem.TabIndex = 11
        Me.btnExcluirItem.Text = "Excluir"
        Me.btnExcluirItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(606, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lote:"
        '
        'lblProdutoIntermediario
        '
        Me.lblProdutoIntermediario.AutoSize = True
        Me.lblProdutoIntermediario.Location = New System.Drawing.Point(6, 15)
        Me.lblProdutoIntermediario.Name = "lblProdutoIntermediario"
        Me.lblProdutoIntermediario.Size = New System.Drawing.Size(111, 14)
        Me.lblProdutoIntermediario.TabIndex = 2
        Me.lblProdutoIntermediario.Text = "Produto Intermediário:"
        '
        'cboProdutoIntermediario
        '
        Me.cboProdutoIntermediario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProdutoIntermediario.AutoSize = False
        Me.cboProdutoIntermediario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboProdutoIntermediario.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboProdutoIntermediario.Location = New System.Drawing.Point(9, 32)
        Me.cboProdutoIntermediario.Name = "cboProdutoIntermediario"
        Me.cboProdutoIntermediario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProdutoIntermediario.Size = New System.Drawing.Size(489, 20)
        Me.cboProdutoIntermediario.TabIndex = 3
        '
        'lblQuantidadeProdutoIntermediario
        '
        Me.lblQuantidadeProdutoIntermediario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeProdutoIntermediario.AutoSize = True
        Me.lblQuantidadeProdutoIntermediario.Location = New System.Drawing.Point(501, 16)
        Me.lblQuantidadeProdutoIntermediario.Name = "lblQuantidadeProdutoIntermediario"
        Me.lblQuantidadeProdutoIntermediario.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeProdutoIntermediario.TabIndex = 4
        Me.lblQuantidadeProdutoIntermediario.Text = "Quantidade:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 466)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(1091, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(797, 17)
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
        Me.btnVoltar.Location = New System.Drawing.Point(991, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(894, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtNumeroRequisicao)
        Me.grpDados.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpDados.Controls.Add(Me.txtQuantidadeProdutoAcabado)
        Me.grpDados.Controls.Add(Me.lblQuantidadeProdutoAcabado)
        Me.grpDados.Controls.Add(Me.dtpData)
        Me.grpDados.Controls.Add(Me.lblDataOrdemProducao)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblProdutoAcabado)
        Me.grpDados.Controls.Add(Me.cboProdutoAcabado)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(1091, 71)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroRequisicao
        '
        Me.txtNumeroRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicao.Location = New System.Drawing.Point(276, 34)
        Me.txtNumeroRequisicao.MaxLength = 20
        Me.txtNumeroRequisicao.Name = "txtNumeroRequisicao"
        Me.txtNumeroRequisicao.Size = New System.Drawing.Size(132, 20)
        Me.txtNumeroRequisicao.TabIndex = 5
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(273, 17)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicao.TabIndex = 4
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'txtQuantidadeProdutoAcabado
        '
        Me.txtQuantidadeProdutoAcabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeProdutoAcabado.DecimalDigits = 4
        Me.txtQuantidadeProdutoAcabado.Location = New System.Drawing.Point(962, 33)
        Me.txtQuantidadeProdutoAcabado.MaxLength = 0
        Me.txtQuantidadeProdutoAcabado.Name = "txtQuantidadeProdutoAcabado"
        Me.txtQuantidadeProdutoAcabado.Size = New System.Drawing.Size(99, 20)
        Me.txtQuantidadeProdutoAcabado.TabIndex = 9
        Me.txtQuantidadeProdutoAcabado.Text = "0,0000"
        Me.txtQuantidadeProdutoAcabado.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeProdutoAcabado
        '
        Me.lblQuantidadeProdutoAcabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeProdutoAcabado.AutoSize = True
        Me.lblQuantidadeProdutoAcabado.Location = New System.Drawing.Point(959, 16)
        Me.lblQuantidadeProdutoAcabado.Name = "lblQuantidadeProdutoAcabado"
        Me.lblQuantidadeProdutoAcabado.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeProdutoAcabado.TabIndex = 8
        Me.lblQuantidadeProdutoAcabado.Text = "Quantidade:"
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(135, 33)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(135, 20)
        Me.dtpData.TabIndex = 3
        Me.dtpData.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataOrdemProducao
        '
        Me.lblDataOrdemProducao.AutoSize = True
        Me.lblDataOrdemProducao.Location = New System.Drawing.Point(132, 16)
        Me.lblDataOrdemProducao.Name = "lblDataOrdemProducao"
        Me.lblDataOrdemProducao.Size = New System.Drawing.Size(116, 14)
        Me.lblDataOrdemProducao.TabIndex = 2
        Me.lblDataOrdemProducao.Text = "Data Ordem Produção:"
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducao.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemProducao.MaxLength = 20
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.Size = New System.Drawing.Size(120, 20)
        Me.txtOrdemProducao.TabIndex = 1
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducao.TabIndex = 0
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'lblProdutoAcabado
        '
        Me.lblProdutoAcabado.AutoSize = True
        Me.lblProdutoAcabado.Location = New System.Drawing.Point(411, 16)
        Me.lblProdutoAcabado.Name = "lblProdutoAcabado"
        Me.lblProdutoAcabado.Size = New System.Drawing.Size(93, 14)
        Me.lblProdutoAcabado.TabIndex = 6
        Me.lblProdutoAcabado.Text = "Produto Acabado:"
        '
        'cboProdutoAcabado
        '
        Me.cboProdutoAcabado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProdutoAcabado.AutoSize = False
        Me.cboProdutoAcabado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboProdutoAcabado.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboProdutoAcabado.Location = New System.Drawing.Point(414, 33)
        Me.cboProdutoAcabado.Name = "cboProdutoAcabado"
        Me.cboProdutoAcabado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProdutoAcabado.Size = New System.Drawing.Size(542, 20)
        Me.cboProdutoAcabado.TabIndex = 7
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
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 96
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 3
        Me.btnAgruparGridArquivo.TabStop = False
        Me.btnAgruparGridArquivo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridArquivo
        '
        Me.btnConfigurarGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 2
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'pagProduto
        '
        Me.pagProduto.Key = "pagItem"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Size = New System.Drawing.Size(1090, 301)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Produto"
        '
        'usrPrdOrdemProducaoProjeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdOrdemProducaoProjeto"
        Me.Size = New System.Drawing.Size(1110, 551)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblProdutoAcabadoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboProdutoAcabado As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtProdutoAcabadoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoAcabado As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtOrdemProducaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblProdutoIntermediario As System.Windows.Forms.Label
    Friend WithEvents cboProdutoIntermediario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidadeProdutoIntermediario As System.Windows.Forms.Label
    Friend WithEvents grdRequisicao As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnInserirItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtQuantidadeProdutoIntermediario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataOrcamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGridServico As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridServico As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents lblQuantidadeProdutoAcabado As System.Windows.Forms.Label
    Friend WithEvents txtProdutoIntermediarioFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoIntermediarioFiltro As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeProdutoAcabado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents dtpDataSaida As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataSaida As System.Windows.Forms.Label
    Friend WithEvents cboLote As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label

End Class
