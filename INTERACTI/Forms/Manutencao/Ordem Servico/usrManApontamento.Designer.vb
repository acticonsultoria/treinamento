<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrManApontamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrManApontamento))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdAtividade_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdAtividade_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem9 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem10 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltrar = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboManutencaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblManutencaoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroOrdemServicoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrdemServicoFiltro = New System.Windows.Forms.Label()
        Me.txtRequisitanteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRequisitanteFiltro = New System.Windows.Forms.Label()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblFuncionarioFiltro = New System.Windows.Forms.Label()
        Me.cboFuncionarioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabAtividade = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosGerais = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtSituacaoFinal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSituacaoFinal = New System.Windows.Forms.Label()
        Me.txtSituacaoInicial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSituacaoInicial = New System.Windows.Forms.Label()
        Me.pagAtividade = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridAtividade = New System.Windows.Forms.Button()
        Me.btnConfigurarGridAtividade = New System.Windows.Forms.Button()
        Me.grdAtividade = New Janus.Windows.GridEX.GridEX()
        Me.grpAtividade = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarAtividade = New System.Windows.Forms.Button()
        Me.cboAtividade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAtividade = New System.Windows.Forms.Label()
        Me.btnExcluirAtividade = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirAtividade = New Janus.Windows.EditControls.UIButton()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRevisaoArquivo = New System.Windows.Forms.Label()
        Me.txtRevisaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCadastrarTipoArquivo = New System.Windows.Forms.Button()
        Me.lblTipoArquivo = New System.Windows.Forms.Label()
        Me.cboTipoArquivo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTotalHoraTrabalhada = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTotalHoraTrabalhada = New System.Windows.Forms.Label()
        Me.txtEncarregado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtManutencao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtHoraParada = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblHoraParada = New System.Windows.Forms.Label()
        Me.txtTerminoTrabalho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTerminoTrabalho = New System.Windows.Forms.Label()
        Me.txtInicioTrabalho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInicioTrabalho = New System.Windows.Forms.Label()
        Me.lblManutencao = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEncarregado = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.cboNumeroOrdemServico = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroOrdemServico = New System.Windows.Forms.Label()
        Me.btnCadastrarFuncionario = New System.Windows.Forms.Button()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.btnConfigurarGridHoras = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaConcluido = New System.Windows.Forms.Label()
        Me.picLegendaConcluido = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCancelado = New System.Windows.Forms.Label()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEmAndamento = New System.Windows.Forms.Label()
        Me.picLegendaEmAndamento = New System.Windows.Forms.PictureBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltrar.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabAtividade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAtividade.SuspendLayout()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosGerais.SuspendLayout()
        Me.pagAtividade.SuspendLayout()
        CType(Me.grdAtividade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpAtividade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAtividade.SuspendLayout()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaEmAndamento, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
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
        Me.pagLista.Controls.Add(Me.grpFiltrar)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Apontamento"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 6
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
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
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 4
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 156)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 324)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltrar
        '
        Me.grpFiltrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltrar.Controls.Add(Me.cboManutencaoFiltro)
        Me.grpFiltrar.Controls.Add(Me.txtNumeroRequisicaoFiltro)
        Me.grpFiltrar.Controls.Add(Me.lblNumeroRequisicaoFiltro)
        Me.grpFiltrar.Controls.Add(Me.lblManutencaoFiltro)
        Me.grpFiltrar.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltrar.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltrar.Controls.Add(Me.txtNumeroOrdemServicoFiltro)
        Me.grpFiltrar.Controls.Add(Me.lblNumeroOrdemServicoFiltro)
        Me.grpFiltrar.Controls.Add(Me.txtRequisitanteFiltro)
        Me.grpFiltrar.Controls.Add(Me.lblRequisitanteFiltro)
        Me.grpFiltrar.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltrar.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltrar.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltrar.Controls.Add(Me.btnFiltrar)
        Me.grpFiltrar.Controls.Add(Me.lblFuncionarioFiltro)
        Me.grpFiltrar.Controls.Add(Me.cboFuncionarioFiltro)
        Me.grpFiltrar.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltrar.Name = "grpFiltrar"
        Me.grpFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltrar.Size = New System.Drawing.Size(897, 144)
        Me.grpFiltrar.TabIndex = 0
        Me.grpFiltrar.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltrar.VisualStyleManager = Me.vsmMain
        '
        'cboManutencaoFiltro
        '
        Me.cboManutencaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboManutencaoFiltro.AutoSize = False
        Me.cboManutencaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboManutencaoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboManutencaoFiltro.Location = New System.Drawing.Point(221, 74)
        Me.cboManutencaoFiltro.Name = "cboManutencaoFiltro"
        Me.cboManutencaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboManutencaoFiltro.Size = New System.Drawing.Size(473, 20)
        Me.cboManutencaoFiltro.TabIndex = 16
        '
        'txtNumeroRequisicaoFiltro
        '
        Me.txtNumeroRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicaoFiltro.Location = New System.Drawing.Point(115, 34)
        Me.txtNumeroRequisicaoFiltro.MaxLength = 20
        Me.txtNumeroRequisicaoFiltro.Name = "txtNumeroRequisicaoFiltro"
        Me.txtNumeroRequisicaoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroRequisicaoFiltro.TabIndex = 3
        '
        'lblNumeroRequisicaoFiltro
        '
        Me.lblNumeroRequisicaoFiltro.AutoSize = True
        Me.lblNumeroRequisicaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroRequisicaoFiltro.Location = New System.Drawing.Point(112, 17)
        Me.lblNumeroRequisicaoFiltro.Name = "lblNumeroRequisicaoFiltro"
        Me.lblNumeroRequisicaoFiltro.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicaoFiltro.TabIndex = 2
        Me.lblNumeroRequisicaoFiltro.Text = "Nº Requisição:"
        '
        'lblManutencaoFiltro
        '
        Me.lblManutencaoFiltro.AutoSize = True
        Me.lblManutencaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblManutencaoFiltro.Location = New System.Drawing.Point(218, 57)
        Me.lblManutencaoFiltro.Name = "lblManutencaoFiltro"
        Me.lblManutencaoFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblManutencaoFiltro.TabIndex = 9
        Me.lblManutencaoFiltro.Text = "Manutenção:"
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(115, 74)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 8
        Me.dtpDataTerminoFiltro.Value = New Date(2014, 1, 8, 0, 0, 0, 0)
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataInicioFiltro.TabIndex = 7
        Me.dtpDataInicioFiltro.Value = New Date(2014, 1, 8, 0, 0, 0, 0)
        '
        'txtNumeroOrdemServicoFiltro
        '
        Me.txtNumeroOrdemServicoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrdemServicoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrdemServicoFiltro.MaxLength = 20
        Me.txtNumeroOrdemServicoFiltro.Name = "txtNumeroOrdemServicoFiltro"
        Me.txtNumeroOrdemServicoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroOrdemServicoFiltro.TabIndex = 1
        '
        'lblNumeroOrdemServicoFiltro
        '
        Me.lblNumeroOrdemServicoFiltro.AutoSize = True
        Me.lblNumeroOrdemServicoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroOrdemServicoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrdemServicoFiltro.Name = "lblNumeroOrdemServicoFiltro"
        Me.lblNumeroOrdemServicoFiltro.Size = New System.Drawing.Size(97, 14)
        Me.lblNumeroOrdemServicoFiltro.TabIndex = 0
        Me.lblNumeroOrdemServicoFiltro.Text = "Nº Ordem Servico:"
        '
        'txtRequisitanteFiltro
        '
        Me.txtRequisitanteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRequisitanteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRequisitanteFiltro.Location = New System.Drawing.Point(221, 34)
        Me.txtRequisitanteFiltro.MaxLength = 60
        Me.txtRequisitanteFiltro.Name = "txtRequisitanteFiltro"
        Me.txtRequisitanteFiltro.Size = New System.Drawing.Size(473, 20)
        Me.txtRequisitanteFiltro.TabIndex = 5
        '
        'lblRequisitanteFiltro
        '
        Me.lblRequisitanteFiltro.AutoSize = True
        Me.lblRequisitanteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRequisitanteFiltro.Location = New System.Drawing.Point(218, 17)
        Me.lblRequisitanteFiltro.Name = "lblRequisitanteFiltro"
        Me.lblRequisitanteFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblRequisitanteFiltro.TabIndex = 4
        Me.lblRequisitanteFiltro.Text = "Requisitante:"
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(138, 14)
        Me.lblStatusFiltro.TabIndex = 11
        Me.lblStatusFiltro.Text = "Status - Ordem de Serviço:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AutoSize = False
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboStatusFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 114)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusFiltro.Size = New System.Drawing.Size(206, 20)
        Me.cboStatusFiltro.TabIndex = 12
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 6
        Me.lblDataFiltro.Text = "Data:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 15
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblFuncionarioFiltro
        '
        Me.lblFuncionarioFiltro.AutoSize = True
        Me.lblFuncionarioFiltro.Location = New System.Drawing.Point(218, 97)
        Me.lblFuncionarioFiltro.Name = "lblFuncionarioFiltro"
        Me.lblFuncionarioFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionarioFiltro.TabIndex = 13
        Me.lblFuncionarioFiltro.Text = "Funcionário:"
        '
        'cboFuncionarioFiltro
        '
        Me.cboFuncionarioFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFuncionarioFiltro.AutoSize = False
        Me.cboFuncionarioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboFuncionarioFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboFuncionarioFiltro.Location = New System.Drawing.Point(221, 114)
        Me.cboFuncionarioFiltro.Name = "cboFuncionarioFiltro"
        Me.cboFuncionarioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFuncionarioFiltro.Size = New System.Drawing.Size(473, 20)
        Me.cboFuncionarioFiltro.TabIndex = 14
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(288, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(617, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
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
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(323, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 3
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(517, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(420, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 4
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabAtividade)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Apontamento"
        '
        'tabAtividade
        '
        Me.tabAtividade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAtividade.BackColor = System.Drawing.Color.Transparent
        Me.tabAtividade.FocusOnClick = False
        Me.tabAtividade.Location = New System.Drawing.Point(8, 193)
        Me.tabAtividade.Name = "tabAtividade"
        Me.tabAtividade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabAtividade.ShowFocusRectangle = False
        Me.tabAtividade.Size = New System.Drawing.Size(897, 287)
        Me.tabAtividade.TabIndex = 1
        Me.tabAtividade.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosGerais, Me.pagAtividade, Me.pagArquivo})
        Me.tabAtividade.TabStop = False
        Me.tabAtividade.VisualStyleManager = Me.vsmMain
        '
        'pagDadosGerais
        '
        Me.pagDadosGerais.Controls.Add(Me.grpDadosGerais)
        Me.pagDadosGerais.Key = "pagDadosGerais"
        Me.pagDadosGerais.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.Size = New System.Drawing.Size(895, 264)
        Me.pagDadosGerais.TabStop = True
        Me.pagDadosGerais.Text = "Dados Gerais"
        '
        'grpDadosGerais
        '
        Me.grpDadosGerais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosGerais.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosGerais.Controls.Add(Me.txtObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblObservacao)
        Me.grpDadosGerais.Controls.Add(Me.txtSituacaoFinal)
        Me.grpDadosGerais.Controls.Add(Me.lblSituacaoFinal)
        Me.grpDadosGerais.Controls.Add(Me.txtSituacaoInicial)
        Me.grpDadosGerais.Controls.Add(Me.lblSituacaoInicial)
        Me.grpDadosGerais.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosGerais.Name = "grpDadosGerais"
        Me.grpDadosGerais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosGerais.Size = New System.Drawing.Size(879, 252)
        Me.grpDadosGerais.TabIndex = 0
        Me.grpDadosGerais.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosGerais.VisualStyleManager = Me.vsmMain
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(9, 114)
        Me.txtObservacao.MaxLength = 5000
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(861, 128)
        Me.txtObservacao.TabIndex = 5
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 97)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 4
        Me.lblObservacao.Text = "Observação:"
        '
        'txtSituacaoFinal
        '
        Me.txtSituacaoFinal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSituacaoFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSituacaoFinal.Location = New System.Drawing.Point(9, 74)
        Me.txtSituacaoFinal.MaxLength = 250
        Me.txtSituacaoFinal.Name = "txtSituacaoFinal"
        Me.txtSituacaoFinal.Size = New System.Drawing.Size(861, 20)
        Me.txtSituacaoFinal.TabIndex = 2
        '
        'lblSituacaoFinal
        '
        Me.lblSituacaoFinal.AutoSize = True
        Me.lblSituacaoFinal.Location = New System.Drawing.Point(7, 57)
        Me.lblSituacaoFinal.Name = "lblSituacaoFinal"
        Me.lblSituacaoFinal.Size = New System.Drawing.Size(77, 14)
        Me.lblSituacaoFinal.TabIndex = 3
        Me.lblSituacaoFinal.Text = "Situação Final:"
        '
        'txtSituacaoInicial
        '
        Me.txtSituacaoInicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSituacaoInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSituacaoInicial.Location = New System.Drawing.Point(9, 34)
        Me.txtSituacaoInicial.MaxLength = 250
        Me.txtSituacaoInicial.Name = "txtSituacaoInicial"
        Me.txtSituacaoInicial.Size = New System.Drawing.Size(861, 20)
        Me.txtSituacaoInicial.TabIndex = 1
        '
        'lblSituacaoInicial
        '
        Me.lblSituacaoInicial.AutoSize = True
        Me.lblSituacaoInicial.Location = New System.Drawing.Point(6, 17)
        Me.lblSituacaoInicial.Name = "lblSituacaoInicial"
        Me.lblSituacaoInicial.Size = New System.Drawing.Size(81, 14)
        Me.lblSituacaoInicial.TabIndex = 0
        Me.lblSituacaoInicial.Text = "Situação Inicial:"
        '
        'pagAtividade
        '
        Me.pagAtividade.Controls.Add(Me.btnExcelGridAtividade)
        Me.pagAtividade.Controls.Add(Me.btnConfigurarGridAtividade)
        Me.pagAtividade.Controls.Add(Me.grdAtividade)
        Me.pagAtividade.Controls.Add(Me.grpAtividade)
        Me.pagAtividade.Key = "pagAtividade"
        Me.pagAtividade.Location = New System.Drawing.Point(1, 22)
        Me.pagAtividade.Name = "pagAtividade"
        Me.pagAtividade.Size = New System.Drawing.Size(895, 264)
        Me.pagAtividade.TabStop = True
        Me.pagAtividade.Text = "Atividade"
        '
        'btnExcelGridAtividade
        '
        Me.btnExcelGridAtividade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridAtividade.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridAtividade.FlatAppearance.BorderSize = 0
        Me.btnExcelGridAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridAtividade.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridAtividade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridAtividade.Location = New System.Drawing.Point(33, 238)
        Me.btnExcelGridAtividade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridAtividade.Name = "btnExcelGridAtividade"
        Me.btnExcelGridAtividade.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridAtividade.TabIndex = 5
        Me.btnExcelGridAtividade.TabStop = False
        Me.btnExcelGridAtividade.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridAtividade
        '
        Me.btnConfigurarGridAtividade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridAtividade.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridAtividade.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridAtividade.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridAtividade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridAtividade.Location = New System.Drawing.Point(9, 238)
        Me.btnConfigurarGridAtividade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridAtividade.Name = "btnConfigurarGridAtividade"
        Me.btnConfigurarGridAtividade.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridAtividade.TabIndex = 2
        Me.btnConfigurarGridAtividade.TabStop = False
        Me.btnConfigurarGridAtividade.UseVisualStyleBackColor = False
        '
        'grdAtividade
        '
        Me.grdAtividade.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdAtividade.AlternatingColors = True
        Me.grdAtividade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAtividade.AutoEdit = True
        Me.grdAtividade.ColumnAutoResize = True
        grdAtividade_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdAtividade_DesignTimeLayout_Reference_0.Instance"), Object)
        grdAtividade_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdAtividade_DesignTimeLayout_Reference_0})
        grdAtividade_DesignTimeLayout.LayoutString = resources.GetString("grdAtividade_DesignTimeLayout.LayoutString")
        Me.grdAtividade.DesignTimeLayout = grdAtividade_DesignTimeLayout
        Me.grdAtividade.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdAtividade.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdAtividade.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdAtividade.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdAtividade.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdAtividade.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdAtividade.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdAtividade.FrozenColumns = 2
        Me.grdAtividade.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdAtividade.GroupByBoxVisible = False
        Me.grdAtividade.Location = New System.Drawing.Point(8, 76)
        Me.grdAtividade.Name = "grdAtividade"
        Me.grdAtividade.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdAtividade.RecordNavigator = True
        Me.grdAtividade.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdAtividade.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdAtividade.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdAtividade.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdAtividade.Size = New System.Drawing.Size(879, 179)
        Me.grdAtividade.TabIndex = 1
        Me.grdAtividade.TabStop = False
        Me.grdAtividade.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdAtividade.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdAtividade.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdAtividade.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdAtividade.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdAtividade.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdAtividade.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdAtividade.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdAtividade.VisualStyleManager = Me.vsmMain
        '
        'grpAtividade
        '
        Me.grpAtividade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAtividade.BackColor = System.Drawing.Color.Transparent
        Me.grpAtividade.Controls.Add(Me.btnCadastrarAtividade)
        Me.grpAtividade.Controls.Add(Me.cboAtividade)
        Me.grpAtividade.Controls.Add(Me.lblAtividade)
        Me.grpAtividade.Controls.Add(Me.btnExcluirAtividade)
        Me.grpAtividade.Controls.Add(Me.btnInserirAtividade)
        Me.grpAtividade.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpAtividade.Location = New System.Drawing.Point(8, 3)
        Me.grpAtividade.Name = "grpAtividade"
        Me.grpAtividade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAtividade.Size = New System.Drawing.Size(879, 64)
        Me.grpAtividade.TabIndex = 0
        Me.grpAtividade.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarAtividade
        '
        Me.btnCadastrarAtividade.FlatAppearance.BorderSize = 0
        Me.btnCadastrarAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarAtividade.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarAtividade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarAtividade.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarAtividade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarAtividade.Name = "btnCadastrarAtividade"
        Me.btnCadastrarAtividade.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarAtividade.TabIndex = 0
        Me.btnCadastrarAtividade.TabStop = False
        Me.btnCadastrarAtividade.UseVisualStyleBackColor = True
        '
        'cboAtividade
        '
        Me.cboAtividade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAtividade.AutoSize = False
        Me.cboAtividade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAtividade.Location = New System.Drawing.Point(9, 34)
        Me.cboAtividade.Name = "cboAtividade"
        Me.cboAtividade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtividade.Size = New System.Drawing.Size(303, 20)
        Me.cboAtividade.TabIndex = 2
        '
        'lblAtividade
        '
        Me.lblAtividade.AutoSize = True
        Me.lblAtividade.Location = New System.Drawing.Point(25, 17)
        Me.lblAtividade.Name = "lblAtividade"
        Me.lblAtividade.Size = New System.Drawing.Size(55, 14)
        Me.lblAtividade.TabIndex = 1
        Me.lblAtividade.Text = "Atividade:"
        '
        'btnExcluirAtividade
        '
        Me.btnExcluirAtividade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirAtividade.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirAtividade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirAtividade.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirAtividade.Location = New System.Drawing.Point(779, 31)
        Me.btnExcluirAtividade.Name = "btnExcluirAtividade"
        Me.btnExcluirAtividade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirAtividade.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirAtividade.TabIndex = 4
        Me.btnExcluirAtividade.Text = "Excluir"
        Me.btnExcluirAtividade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirAtividade
        '
        Me.btnInserirAtividade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirAtividade.Image = CType(resources.GetObject("btnInserirAtividade.Image"), System.Drawing.Image)
        Me.btnInserirAtividade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirAtividade.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirAtividade.Location = New System.Drawing.Point(682, 31)
        Me.btnInserirAtividade.Name = "btnInserirAtividade"
        Me.btnInserirAtividade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirAtividade.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirAtividade.TabIndex = 3
        Me.btnInserirAtividade.Text = "Inserir"
        Me.btnInserirAtividade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagArquivo
        '
        Me.pagArquivo.Controls.Add(Me.btnExcelGridArquivo)
        Me.pagArquivo.Controls.Add(Me.btnAgruparGridArquivo)
        Me.pagArquivo.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagArquivo.Controls.Add(Me.grpArquivo)
        Me.pagArquivo.Controls.Add(Me.grdArquivo)
        Me.pagArquivo.Key = "pagArquivo"
        Me.pagArquivo.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivo.Name = "pagArquivo"
        Me.pagArquivo.Size = New System.Drawing.Size(895, 264)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Text = "Arquivos"
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 238)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 5
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 238)
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
        Me.btnConfigurarGridArquivo.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 238)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 2
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.lblRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.txtRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnCadastrarTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.cboTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Controls.Add(Me.txtDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblDescricaoArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(879, 104)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'lblRevisaoArquivo
        '
        Me.lblRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevisaoArquivo.AutoSize = True
        Me.lblRevisaoArquivo.Location = New System.Drawing.Point(575, 17)
        Me.lblRevisaoArquivo.Name = "lblRevisaoArquivo"
        Me.lblRevisaoArquivo.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoArquivo.TabIndex = 2
        Me.lblRevisaoArquivo.Text = "Revisão:"
        '
        'txtRevisaoArquivo
        '
        Me.txtRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRevisaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisaoArquivo.Location = New System.Drawing.Point(578, 34)
        Me.txtRevisaoArquivo.MaxLength = 5
        Me.txtRevisaoArquivo.Name = "txtRevisaoArquivo"
        Me.txtRevisaoArquivo.Size = New System.Drawing.Size(89, 20)
        Me.txtRevisaoArquivo.TabIndex = 3
        '
        'btnCadastrarTipoArquivo
        '
        Me.btnCadastrarTipoArquivo.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoArquivo.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarTipoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoArquivo.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarTipoArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoArquivo.Name = "btnCadastrarTipoArquivo"
        Me.btnCadastrarTipoArquivo.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoArquivo.TabIndex = 4
        Me.btnCadastrarTipoArquivo.TabStop = False
        Me.btnCadastrarTipoArquivo.UseVisualStyleBackColor = True
        '
        'lblTipoArquivo
        '
        Me.lblTipoArquivo.AutoSize = True
        Me.lblTipoArquivo.Location = New System.Drawing.Point(25, 57)
        Me.lblTipoArquivo.Name = "lblTipoArquivo"
        Me.lblTipoArquivo.Size = New System.Drawing.Size(85, 14)
        Me.lblTipoArquivo.TabIndex = 5
        Me.lblTipoArquivo.Text = "Tipo do Arquivo:"
        '
        'cboTipoArquivo
        '
        Me.cboTipoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoArquivo.Location = New System.Drawing.Point(9, 74)
        Me.cboTipoArquivo.Name = "cboTipoArquivo"
        Me.cboTipoArquivo.Size = New System.Drawing.Size(240, 20)
        Me.cboTipoArquivo.TabIndex = 6
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(647, 74)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 9
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(252, 57)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 7
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(255, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(393, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirArquivo.Name = "btnExcluirArquivo"
        Me.btnExcluirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivo.TabIndex = 11
        Me.btnExcluirArquivo.Text = "Excluir"
        Me.btnExcluirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirArquivo
        '
        Me.btnInserirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirArquivo.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirArquivo.Name = "btnInserirArquivo"
        Me.btnInserirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirArquivo.TabIndex = 10
        Me.btnInserirArquivo.Text = "Inserir"
        Me.btnInserirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(563, 20)
        Me.txtDescricaoArquivo.TabIndex = 1
        '
        'lblDescricaoArquivo
        '
        Me.lblDescricaoArquivo.AutoSize = True
        Me.lblDescricaoArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoArquivo.Name = "lblDescricaoArquivo"
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoArquivo.TabIndex = 0
        Me.lblDescricaoArquivo.Text = "Descrição:"
        '
        'grdArquivo
        '
        Me.grdArquivo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdArquivo.AlternatingColors = True
        Me.grdArquivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArquivo.ColumnAutoResize = True
        grdArquivo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdArquivo_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_1.Instance"), Object)
        grdArquivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivo_DesignTimeLayout_Reference_0, grdArquivo_DesignTimeLayout_Reference_1})
        grdArquivo_DesignTimeLayout.LayoutString = resources.GetString("grdArquivo_DesignTimeLayout.LayoutString")
        Me.grdArquivo.DesignTimeLayout = grdArquivo_DesignTimeLayout
        Me.grdArquivo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdArquivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivo.FrozenColumns = 3
        Me.grdArquivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivo.GroupByBoxVisible = False
        Me.grdArquivo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdArquivo.Location = New System.Drawing.Point(8, 116)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 139)
        Me.grdArquivo.TabIndex = 1
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 483)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(603, 17)
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
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
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
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
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
        Me.grpDados.Controls.Add(Me.txtTotalHoraTrabalhada)
        Me.grpDados.Controls.Add(Me.lblTotalHoraTrabalhada)
        Me.grpDados.Controls.Add(Me.txtEncarregado)
        Me.grpDados.Controls.Add(Me.txtManutencao)
        Me.grpDados.Controls.Add(Me.txtNumeroRequisicao)
        Me.grpDados.Controls.Add(Me.txtHoraParada)
        Me.grpDados.Controls.Add(Me.lblHoraParada)
        Me.grpDados.Controls.Add(Me.txtTerminoTrabalho)
        Me.grpDados.Controls.Add(Me.lblTerminoTrabalho)
        Me.grpDados.Controls.Add(Me.txtInicioTrabalho)
        Me.grpDados.Controls.Add(Me.lblInicioTrabalho)
        Me.grpDados.Controls.Add(Me.lblManutencao)
        Me.grpDados.Controls.Add(Me.dtpData)
        Me.grpDados.Controls.Add(Me.cboFuncionario)
        Me.grpDados.Controls.Add(Me.lblEncarregado)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.lblFuncionario)
        Me.grpDados.Controls.Add(Me.cboNumeroOrdemServico)
        Me.grpDados.Controls.Add(Me.lblNumeroOrdemServico)
        Me.grpDados.Controls.Add(Me.btnCadastrarFuncionario)
        Me.grpDados.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 184)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtTotalHoraTrabalhada
        '
        Me.txtTotalHoraTrabalhada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalHoraTrabalhada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalHoraTrabalhada.Location = New System.Drawing.Point(788, 35)
        Me.txtTotalHoraTrabalhada.Mask = "00:00:00"
        Me.txtTotalHoraTrabalhada.Name = "txtTotalHoraTrabalhada"
        Me.txtTotalHoraTrabalhada.ReadOnly = True
        Me.txtTotalHoraTrabalhada.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalHoraTrabalhada.TabIndex = 20
        Me.txtTotalHoraTrabalhada.TabStop = False
        Me.txtTotalHoraTrabalhada.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblTotalHoraTrabalhada
        '
        Me.lblTotalHoraTrabalhada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalHoraTrabalhada.AutoSize = True
        Me.lblTotalHoraTrabalhada.Location = New System.Drawing.Point(785, 18)
        Me.lblTotalHoraTrabalhada.Name = "lblTotalHoraTrabalhada"
        Me.lblTotalHoraTrabalhada.Size = New System.Drawing.Size(100, 14)
        Me.lblTotalHoraTrabalhada.TabIndex = 19
        Me.lblTotalHoraTrabalhada.Text = "Σ Hora Trabalhada:"
        '
        'txtEncarregado
        '
        Me.txtEncarregado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEncarregado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEncarregado.Location = New System.Drawing.Point(9, 154)
        Me.txtEncarregado.MaxLength = 100
        Me.txtEncarregado.Name = "txtEncarregado"
        Me.txtEncarregado.Size = New System.Drawing.Size(312, 20)
        Me.txtEncarregado.TabIndex = 12
        '
        'txtManutencao
        '
        Me.txtManutencao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtManutencao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtManutencao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtManutencao.Location = New System.Drawing.Point(9, 74)
        Me.txtManutencao.MaxLength = 500
        Me.txtManutencao.Name = "txtManutencao"
        Me.txtManutencao.ReadOnly = True
        Me.txtManutencao.Size = New System.Drawing.Size(312, 20)
        Me.txtManutencao.TabIndex = 7
        Me.txtManutencao.TabStop = False
        '
        'txtNumeroRequisicao
        '
        Me.txtNumeroRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicao.Location = New System.Drawing.Point(115, 34)
        Me.txtNumeroRequisicao.MaxLength = 20
        Me.txtNumeroRequisicao.Name = "txtNumeroRequisicao"
        Me.txtNumeroRequisicao.ReadOnly = True
        Me.txtNumeroRequisicao.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroRequisicao.TabIndex = 3
        Me.txtNumeroRequisicao.TabStop = False
        '
        'txtHoraParada
        '
        Me.txtHoraParada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHoraParada.Location = New System.Drawing.Point(682, 34)
        Me.txtHoraParada.Mask = "00:00:00"
        Me.txtHoraParada.Name = "txtHoraParada"
        Me.txtHoraParada.Size = New System.Drawing.Size(100, 20)
        Me.txtHoraParada.TabIndex = 18
        Me.txtHoraParada.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblHoraParada
        '
        Me.lblHoraParada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraParada.AutoSize = True
        Me.lblHoraParada.Location = New System.Drawing.Point(679, 17)
        Me.lblHoraParada.Name = "lblHoraParada"
        Me.lblHoraParada.Size = New System.Drawing.Size(70, 14)
        Me.lblHoraParada.TabIndex = 17
        Me.lblHoraParada.Text = "Hora Parada:"
        '
        'txtTerminoTrabalho
        '
        Me.txtTerminoTrabalho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTerminoTrabalho.Location = New System.Drawing.Point(576, 34)
        Me.txtTerminoTrabalho.Mask = "00:00:00"
        Me.txtTerminoTrabalho.Name = "txtTerminoTrabalho"
        Me.txtTerminoTrabalho.Size = New System.Drawing.Size(100, 20)
        Me.txtTerminoTrabalho.TabIndex = 16
        Me.txtTerminoTrabalho.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblTerminoTrabalho
        '
        Me.lblTerminoTrabalho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTerminoTrabalho.AutoSize = True
        Me.lblTerminoTrabalho.Location = New System.Drawing.Point(573, 17)
        Me.lblTerminoTrabalho.Name = "lblTerminoTrabalho"
        Me.lblTerminoTrabalho.Size = New System.Drawing.Size(93, 14)
        Me.lblTerminoTrabalho.TabIndex = 15
        Me.lblTerminoTrabalho.Text = "Término Trabalho:"
        '
        'txtInicioTrabalho
        '
        Me.txtInicioTrabalho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInicioTrabalho.Location = New System.Drawing.Point(470, 34)
        Me.txtInicioTrabalho.Mask = "00:00:00"
        Me.txtInicioTrabalho.Name = "txtInicioTrabalho"
        Me.txtInicioTrabalho.Size = New System.Drawing.Size(100, 20)
        Me.txtInicioTrabalho.TabIndex = 14
        Me.txtInicioTrabalho.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblInicioTrabalho
        '
        Me.lblInicioTrabalho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInicioTrabalho.AutoSize = True
        Me.lblInicioTrabalho.Location = New System.Drawing.Point(467, 17)
        Me.lblInicioTrabalho.Name = "lblInicioTrabalho"
        Me.lblInicioTrabalho.Size = New System.Drawing.Size(79, 14)
        Me.lblInicioTrabalho.TabIndex = 13
        Me.lblInicioTrabalho.Text = "Início Trabalho:"
        '
        'lblManutencao
        '
        Me.lblManutencao.AutoSize = True
        Me.lblManutencao.Location = New System.Drawing.Point(6, 57)
        Me.lblManutencao.Name = "lblManutencao"
        Me.lblManutencao.Size = New System.Drawing.Size(69, 14)
        Me.lblManutencao.TabIndex = 6
        Me.lblManutencao.Text = "Manutenção:"
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(221, 34)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(100, 20)
        Me.dtpData.TabIndex = 5
        Me.dtpData.Value = New Date(2014, 1, 8, 0, 0, 0, 0)
        '
        'cboFuncionario
        '
        Me.cboFuncionario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFuncionario.AutoSize = False
        Me.cboFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = "SIM"
        UiComboBoxItem7.Value = True
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = "NÃO"
        UiComboBoxItem8.Value = False
        Me.cboFuncionario.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboFuncionario.Location = New System.Drawing.Point(9, 114)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFuncionario.Size = New System.Drawing.Size(312, 20)
        Me.cboFuncionario.TabIndex = 10
        '
        'lblEncarregado
        '
        Me.lblEncarregado.AutoSize = True
        Me.lblEncarregado.Location = New System.Drawing.Point(6, 137)
        Me.lblEncarregado.Name = "lblEncarregado"
        Me.lblEncarregado.Size = New System.Drawing.Size(72, 14)
        Me.lblEncarregado.TabIndex = 11
        Me.lblEncarregado.Text = "Encarregado:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(218, 18)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "Data:"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(25, 97)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionario.TabIndex = 9
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'cboNumeroOrdemServico
        '
        Me.cboNumeroOrdemServico.AutoSize = False
        Me.cboNumeroOrdemServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem9.FormatStyle.Alpha = 0
        UiComboBoxItem9.IsSeparator = False
        UiComboBoxItem9.Text = "SIM"
        UiComboBoxItem9.Value = True
        UiComboBoxItem10.FormatStyle.Alpha = 0
        UiComboBoxItem10.IsSeparator = False
        UiComboBoxItem10.Text = "NÃO"
        UiComboBoxItem10.Value = False
        Me.cboNumeroOrdemServico.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem9, UiComboBoxItem10})
        Me.cboNumeroOrdemServico.Location = New System.Drawing.Point(9, 34)
        Me.cboNumeroOrdemServico.Name = "cboNumeroOrdemServico"
        Me.cboNumeroOrdemServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroOrdemServico.Size = New System.Drawing.Size(100, 20)
        Me.cboNumeroOrdemServico.TabIndex = 1
        '
        'lblNumeroOrdemServico
        '
        Me.lblNumeroOrdemServico.AutoSize = True
        Me.lblNumeroOrdemServico.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrdemServico.Name = "lblNumeroOrdemServico"
        Me.lblNumeroOrdemServico.Size = New System.Drawing.Size(97, 14)
        Me.lblNumeroOrdemServico.TabIndex = 0
        Me.lblNumeroOrdemServico.Text = "Nº Ordem Serviço:"
        '
        'btnCadastrarFuncionario
        '
        Me.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0
        Me.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarFuncionario.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarFuncionario.Location = New System.Drawing.Point(9, 98)
        Me.btnCadastrarFuncionario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario"
        Me.btnCadastrarFuncionario.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarFuncionario.TabIndex = 8
        Me.btnCadastrarFuncionario.TabStop = False
        Me.btnCadastrarFuncionario.UseVisualStyleBackColor = True
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(112, 17)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicao.TabIndex = 2
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'btnConfigurarGridHoras
        '
        Me.btnConfigurarGridHoras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridHoras.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridHoras.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridHoras.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridHoras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridHoras.Location = New System.Drawing.Point(9, 238)
        Me.btnConfigurarGridHoras.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridHoras.Name = "btnConfigurarGridHoras"
        Me.btnConfigurarGridHoras.Size = New System.Drawing.Size(49, 15)
        Me.btnConfigurarGridHoras.TabIndex = 3
        Me.btnConfigurarGridHoras.TabStop = False
        Me.btnConfigurarGridHoras.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.INTERACTI.My.Resources.config
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(9, 238)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 15)
        Me.Button1.TabIndex = 5
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaConcluido)
        Me.grpLegenda.Controls.Add(Me.picLegendaConcluido)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEmAndamento)
        Me.grpLegenda.Controls.Add(Me.picLegendaEmAndamento)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(271, 51)
        Me.grpLegenda.TabIndex = 7
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaConcluido
        '
        Me.lblLegendaConcluido.AutoSize = True
        Me.lblLegendaConcluido.Location = New System.Drawing.Point(131, 21)
        Me.lblLegendaConcluido.Name = "lblLegendaConcluido"
        Me.lblLegendaConcluido.Size = New System.Drawing.Size(54, 14)
        Me.lblLegendaConcluido.TabIndex = 17
        Me.lblLegendaConcluido.Text = "Concluído"
        '
        'picLegendaConcluido
        '
        Me.picLegendaConcluido.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaConcluido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaConcluido.Location = New System.Drawing.Point(112, 21)
        Me.picLegendaConcluido.Name = "picLegendaConcluido"
        Me.picLegendaConcluido.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaConcluido.TabIndex = 18
        Me.picLegendaConcluido.TabStop = False
        '
        'lblLegendaCancelado
        '
        Me.lblLegendaCancelado.AutoSize = True
        Me.lblLegendaCancelado.Location = New System.Drawing.Point(210, 21)
        Me.lblLegendaCancelado.Name = "lblLegendaCancelado"
        Me.lblLegendaCancelado.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelado.TabIndex = 1
        Me.lblLegendaCancelado.Text = "Cancelado"
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(191, 21)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelado.TabIndex = 16
        Me.picLegendaCancelado.TabStop = False
        '
        'lblLegendaEmAndamento
        '
        Me.lblLegendaEmAndamento.AutoSize = True
        Me.lblLegendaEmAndamento.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaEmAndamento.Name = "lblLegendaEmAndamento"
        Me.lblLegendaEmAndamento.Size = New System.Drawing.Size(78, 14)
        Me.lblLegendaEmAndamento.TabIndex = 0
        Me.lblLegendaEmAndamento.Text = "Em Andamento"
        '
        'picLegendaEmAndamento
        '
        Me.picLegendaEmAndamento.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaEmAndamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEmAndamento.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaEmAndamento.Name = "picLegendaEmAndamento"
        Me.picLegendaEmAndamento.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEmAndamento.TabIndex = 4
        Me.picLegendaEmAndamento.TabStop = False
        '
        'usrManApontamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrManApontamento"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltrar.ResumeLayout(False)
        Me.grpFiltrar.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabAtividade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAtividade.ResumeLayout(False)
        Me.pagDadosGerais.ResumeLayout(False)
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosGerais.ResumeLayout(False)
        Me.grpDadosGerais.PerformLayout()
        Me.pagAtividade.ResumeLayout(False)
        CType(Me.grdAtividade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpAtividade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAtividade.ResumeLayout(False)
        Me.grpAtividade.PerformLayout()
        Me.pagArquivo.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaEmAndamento, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblNumeroOrdemServico As System.Windows.Forms.Label
    Friend WithEvents cboNumeroOrdemServico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpFiltrar As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFuncionarioFiltro As System.Windows.Forms.Label
    Friend WithEvents cboFuncionarioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblEncarregado As System.Windows.Forms.Label
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtRequisitanteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRequisitanteFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroOrdemServicoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrdemServicoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents lblManutencao As System.Windows.Forms.Label
    Friend WithEvents lblManutencaoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarFuncionario As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridHoras As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtHoraParada As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblHoraParada As System.Windows.Forms.Label
    Friend WithEvents txtTerminoTrabalho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTerminoTrabalho As System.Windows.Forms.Label
    Friend WithEvents txtInicioTrabalho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInicioTrabalho As System.Windows.Forms.Label
    Friend WithEvents tabAtividade As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagAtividade As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridAtividade As System.Windows.Forms.Button
    Friend WithEvents grdAtividade As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpAtividade As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAtividade As System.Windows.Forms.Label
    Friend WithEvents btnExcluirAtividade As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirAtividade As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRevisaoArquivo As System.Windows.Forms.Label
    Friend WithEvents txtRevisaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnCadastrarTipoArquivo As System.Windows.Forms.Button
    Friend WithEvents lblTipoArquivo As System.Windows.Forms.Label
    Friend WithEvents cboTipoArquivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As System.Windows.Forms.Label
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents txtEncarregado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtManutencao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroRequisicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosGerais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtSituacaoFinal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSituacaoFinal As System.Windows.Forms.Label
    Friend WithEvents txtSituacaoInicial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSituacaoInicial As System.Windows.Forms.Label
    Friend WithEvents txtTotalHoraTrabalhada As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTotalHoraTrabalhada As System.Windows.Forms.Label
    Friend WithEvents cboManutencaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarAtividade As System.Windows.Forms.Button
    Friend WithEvents cboAtividade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridAtividade As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaConcluido As System.Windows.Forms.Label
    Friend WithEvents picLegendaConcluido As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelado As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEmAndamento As System.Windows.Forms.Label
    Friend WithEvents picLegendaEmAndamento As System.Windows.Forms.PictureBox

End Class
