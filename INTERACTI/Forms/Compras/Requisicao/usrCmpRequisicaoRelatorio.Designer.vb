<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmpRequisicaoRelatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpRequisicaoRelatorio))
        Dim cboStatusRequisicaoFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdItem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarItemFiltro = New System.Windows.Forms.Button()
        Me.cboAprovadorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAprovadorFiltro = New System.Windows.Forms.Label()
        Me.cboRequisitanteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRequisitanteFiltro = New System.Windows.Forms.Label()
        Me.cboStatusRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataRequisicaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataRequisicaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblDataRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblStatusRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosRequisicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboAprovador = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.lblAprovador = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColunaItem = New System.Windows.Forms.Label()
        Me.cboCongelarColunaItem = New Janus.Windows.EditControls.UIComboBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagItem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridItem = New System.Windows.Forms.Button()
        Me.btnAgruparGridItem = New System.Windows.Forms.Button()
        Me.btnConfigurarGridItem = New System.Windows.Forms.Button()
        Me.grpItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblOrdemDeProducaoPai = New System.Windows.Forms.Label()
        Me.cboOrdemDeProducaoPai = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPartNumberPai = New System.Windows.Forms.Label()
        Me.cboPartNumberPai = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.btnQuantidadeAberto = New System.Windows.Forms.Button()
        Me.txtQuantidadeAberto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeAberto = New System.Windows.Forms.Label()
        Me.cboTipoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoItem = New System.Windows.Forms.Label()
        Me.txtMultiploCompra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMultiploCompra = New System.Windows.Forms.Label()
        Me.txtQuantidadeMinima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeMinima = New System.Windows.Forms.Label()
        Me.dtpDataNecessidadeItem = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoItem = New System.Windows.Forms.Label()
        Me.lblJustificativaItem = New System.Windows.Forms.Label()
        Me.cboContaContabilItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaContabilItem = New System.Windows.Forms.Label()
        Me.lblCentroGastoItem = New System.Windows.Forms.Label()
        Me.cboCentroGastoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblComplementoItem = New System.Windows.Forms.Label()
        Me.txtComplementoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataNecessidadeItem = New System.Windows.Forms.Label()
        Me.lblUnidadeMedidaItem = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaItem = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidadeItem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.btnCadastrarItem = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGastoItem = New System.Windows.Forms.Button()
        Me.btnCadastrarContaContabilItem = New System.Windows.Forms.Button()
        Me.lblQuantidadeItem = New System.Windows.Forms.Label()
        Me.txtMarcaItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarcaItem = New System.Windows.Forms.Label()
        Me.txtDescricaoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoItem = New System.Windows.Forms.Label()
        Me.txtJustificativaItem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.btnCadastrarUnidadeMedidaItem = New System.Windows.Forms.Button()
        Me.btnExcluirItem = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirItem = New Janus.Windows.EditControls.UIButton()
        Me.grdItem = New Janus.Windows.GridEX.GridEX()
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
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpDadosRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosRequisicao.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagItem.SuspendLayout()
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItem.SuspendLayout()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Requisição de Compra"
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
        Me.btnExcelGrid.TabIndex = 54
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
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 364)
        Me.grdListagem.TabIndex = 1
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
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAprovadorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAprovadorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusRequisicaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarItemFiltro
        '
        Me.btnProcurarItemFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarItemFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarItemFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItemFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItemFiltro.Location = New System.Drawing.Point(753, 56)
        Me.btnProcurarItemFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItemFiltro.Name = "btnProcurarItemFiltro"
        Me.btnProcurarItemFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItemFiltro.TabIndex = 12
        Me.btnProcurarItemFiltro.TabStop = False
        Me.btnProcurarItemFiltro.UseVisualStyleBackColor = True
        '
        'cboAprovadorFiltro
        '
        Me.cboAprovadorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAprovadorFiltro.AutoSize = False
        Me.cboAprovadorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAprovadorFiltro.Location = New System.Drawing.Point(508, 34)
        Me.cboAprovadorFiltro.Name = "cboAprovadorFiltro"
        Me.cboAprovadorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAprovadorFiltro.Size = New System.Drawing.Size(262, 20)
        Me.cboAprovadorFiltro.TabIndex = 3
        '
        'lblAprovadorFiltro
        '
        Me.lblAprovadorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAprovadorFiltro.AutoSize = True
        Me.lblAprovadorFiltro.Location = New System.Drawing.Point(505, 17)
        Me.lblAprovadorFiltro.Name = "lblAprovadorFiltro"
        Me.lblAprovadorFiltro.Size = New System.Drawing.Size(62, 14)
        Me.lblAprovadorFiltro.TabIndex = 6
        Me.lblAprovadorFiltro.Text = "Aprovador:"
        '
        'cboRequisitanteFiltro
        '
        Me.cboRequisitanteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboRequisitanteFiltro.AutoSize = False
        Me.cboRequisitanteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRequisitanteFiltro.Location = New System.Drawing.Point(237, 34)
        Me.cboRequisitanteFiltro.Name = "cboRequisitanteFiltro"
        Me.cboRequisitanteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRequisitanteFiltro.Size = New System.Drawing.Size(265, 20)
        Me.cboRequisitanteFiltro.TabIndex = 2
        '
        'lblRequisitanteFiltro
        '
        Me.lblRequisitanteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRequisitanteFiltro.AutoSize = True
        Me.lblRequisitanteFiltro.Location = New System.Drawing.Point(234, 17)
        Me.lblRequisitanteFiltro.Name = "lblRequisitanteFiltro"
        Me.lblRequisitanteFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblRequisitanteFiltro.TabIndex = 4
        Me.lblRequisitanteFiltro.Text = "Requisitante:"
        '
        'cboStatusRequisicaoFiltro
        '
        Me.cboStatusRequisicaoFiltro.AllowDrop = True
        Me.cboStatusRequisicaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusRequisicaoFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusRequisicaoFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusRequisicaoFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusRequisicaoFiltro.DesignTimeLayout = cboStatusRequisicaoFiltro_DesignTimeLayout
        Me.cboStatusRequisicaoFiltro.Location = New System.Drawing.Point(123, 34)
        Me.cboStatusRequisicaoFiltro.Name = "cboStatusRequisicaoFiltro"
        Me.cboStatusRequisicaoFiltro.SaveSettings = False
        Me.cboStatusRequisicaoFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusRequisicaoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.cboStatusRequisicaoFiltro.TabIndex = 1
        Me.cboStatusRequisicaoFiltro.ValuesDataMember = Nothing
        '
        'dtpDataRequisicaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoTerminoFiltro.Location = New System.Drawing.Point(123, 74)
        Me.dtpDataRequisicaoTerminoFiltro.Name = "dtpDataRequisicaoTerminoFiltro"
        Me.dtpDataRequisicaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRequisicaoTerminoFiltro.TabIndex = 5
        '
        'dtpDataRequisicaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataRequisicaoInicioFiltro.Name = "dtpDataRequisicaoInicioFiltro"
        Me.dtpDataRequisicaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRequisicaoInicioFiltro.TabIndex = 4
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 7
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblItemFiltro
        '
        Me.lblItemFiltro.AutoSize = True
        Me.lblItemFiltro.Location = New System.Drawing.Point(234, 57)
        Me.lblItemFiltro.Name = "lblItemFiltro"
        Me.lblItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblItemFiltro.TabIndex = 11
        Me.lblItemFiltro.Text = "Item:"
        '
        'txtItemFiltro
        '
        Me.txtItemFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemFiltro.Location = New System.Drawing.Point(237, 74)
        Me.txtItemFiltro.MaxLength = 120
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.Size = New System.Drawing.Size(533, 20)
        Me.txtItemFiltro.TabIndex = 6
        '
        'txtNumeroRequisicaoFiltro
        '
        Me.txtNumeroRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicaoFiltro.MaxLength = 20
        Me.txtNumeroRequisicaoFiltro.Name = "txtNumeroRequisicaoFiltro"
        Me.txtNumeroRequisicaoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroRequisicaoFiltro.TabIndex = 0
        '
        'lblNumeroRequisicaoFiltro
        '
        Me.lblNumeroRequisicaoFiltro.AutoSize = True
        Me.lblNumeroRequisicaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicaoFiltro.Name = "lblNumeroRequisicaoFiltro"
        Me.lblNumeroRequisicaoFiltro.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicaoFiltro.TabIndex = 0
        Me.lblNumeroRequisicaoFiltro.Text = "Nº Requisição:"
        '
        'lblDataRequisicaoFiltro
        '
        Me.lblDataRequisicaoFiltro.AutoSize = True
        Me.lblDataRequisicaoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataRequisicaoFiltro.Name = "lblDataRequisicaoFiltro"
        Me.lblDataRequisicaoFiltro.Size = New System.Drawing.Size(103, 14)
        Me.lblDataRequisicaoFiltro.TabIndex = 8
        Me.lblDataRequisicaoFiltro.Text = "Data da Requisição:"
        '
        'lblStatusRequisicaoFiltro
        '
        Me.lblStatusRequisicaoFiltro.AutoSize = True
        Me.lblStatusRequisicaoFiltro.Location = New System.Drawing.Point(120, 17)
        Me.lblStatusRequisicaoFiltro.Name = "lblStatusRequisicaoFiltro"
        Me.lblStatusRequisicaoFiltro.Size = New System.Drawing.Size(97, 14)
        Me.lblStatusRequisicaoFiltro.TabIndex = 2
        Me.lblStatusRequisicaoFiltro.Text = "Status Requisição:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 5
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDadosRequisicao
        '
        Me.grpDadosRequisicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosRequisicao.Controls.Add(Me.cboAprovador)
        Me.grpDadosRequisicao.Controls.Add(Me.txtNumeroRequisicao)
        Me.grpDadosRequisicao.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpDadosRequisicao.Controls.Add(Me.lblAprovador)
        Me.grpDadosRequisicao.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosRequisicao.Name = "grpDadosRequisicao"
        Me.grpDadosRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosRequisicao.Size = New System.Drawing.Size(897, 63)
        Me.grpDadosRequisicao.TabIndex = 0
        Me.grpDadosRequisicao.VisualStyleManager = Me.vsmMain
        '
        'cboAprovador
        '
        Me.cboAprovador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAprovador.AutoSize = False
        Me.cboAprovador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAprovador.Location = New System.Drawing.Point(123, 34)
        Me.cboAprovador.Name = "cboAprovador"
        Me.cboAprovador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAprovador.Size = New System.Drawing.Size(765, 20)
        Me.cboAprovador.TabIndex = 5
        '
        'txtNumeroRequisicao
        '
        Me.txtNumeroRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroRequisicao.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicao.MaxLength = 20
        Me.txtNumeroRequisicao.Name = "txtNumeroRequisicao"
        Me.txtNumeroRequisicao.ReadOnly = True
        Me.txtNumeroRequisicao.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroRequisicao.TabIndex = 1
        Me.txtNumeroRequisicao.TabStop = False
        Me.txtNumeroRequisicao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 13)
        Me.lblNumeroRequisicao.TabIndex = 0
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'lblAprovador
        '
        Me.lblAprovador.AutoSize = True
        Me.lblAprovador.Location = New System.Drawing.Point(120, 17)
        Me.lblAprovador.Name = "lblAprovador"
        Me.lblAprovador.Size = New System.Drawing.Size(59, 13)
        Me.lblAprovador.TabIndex = 4
        Me.lblAprovador.Text = "Aprovador:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColunaItem)
        Me.grpControl.Controls.Add(Me.cboCongelarColunaItem)
        Me.grpControl.Controls.Add(Me.btnImprimir)
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnVoltar)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColunaItem
        '
        Me.lblCongelarColunaItem.AutoSize = True
        Me.lblCongelarColunaItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColunaItem.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColunaItem.Name = "lblCongelarColunaItem"
        Me.lblCongelarColunaItem.Size = New System.Drawing.Size(88, 13)
        Me.lblCongelarColunaItem.TabIndex = 7
        Me.lblCongelarColunaItem.Text = "Congelar Coluna:"
        '
        'cboCongelarColunaItem
        '
        Me.cboCongelarColunaItem.AutoSize = False
        Me.cboCongelarColunaItem.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColunaItem.Name = "cboCongelarColunaItem"
        Me.cboCongelarColunaItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColunaItem.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColunaItem.TabIndex = 8
        Me.cboCongelarColunaItem.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(700, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(506, 17)
        Me.btnNovo.Name = "btnNovo"
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
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 3
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(603, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 72)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 408)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagItem, Me.pagArquivo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagItem
        '
        Me.pagItem.Controls.Add(Me.btnExcelGridItem)
        Me.pagItem.Controls.Add(Me.btnAgruparGridItem)
        Me.pagItem.Controls.Add(Me.btnConfigurarGridItem)
        Me.pagItem.Controls.Add(Me.grpItem)
        Me.pagItem.Controls.Add(Me.grdItem)
        Me.pagItem.Key = "pagItem"
        Me.pagItem.Location = New System.Drawing.Point(1, 22)
        Me.pagItem.Name = "pagItem"
        Me.pagItem.Size = New System.Drawing.Size(895, 385)
        Me.pagItem.TabStop = True
        Me.pagItem.Text = "Itens"
        '
        'btnExcelGridItem
        '
        Me.btnExcelGridItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridItem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridItem.FlatAppearance.BorderSize = 0
        Me.btnExcelGridItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridItem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridItem.Location = New System.Drawing.Point(57, 359)
        Me.btnExcelGridItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridItem.Name = "btnExcelGridItem"
        Me.btnExcelGridItem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridItem.TabIndex = 55
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
        Me.btnAgruparGridItem.Location = New System.Drawing.Point(33, 359)
        Me.btnAgruparGridItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridItem.Name = "btnAgruparGridItem"
        Me.btnAgruparGridItem.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridItem.TabIndex = 0
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
        Me.btnConfigurarGridItem.Location = New System.Drawing.Point(9, 359)
        Me.btnConfigurarGridItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridItem.Name = "btnConfigurarGridItem"
        Me.btnConfigurarGridItem.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridItem.TabIndex = 3
        Me.btnConfigurarGridItem.TabStop = False
        Me.btnConfigurarGridItem.UseVisualStyleBackColor = False
        '
        'grpItem
        '
        Me.grpItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItem.BackColor = System.Drawing.Color.Transparent
        Me.grpItem.Controls.Add(Me.lblOrdemDeProducaoPai)
        Me.grpItem.Controls.Add(Me.cboOrdemDeProducaoPai)
        Me.grpItem.Controls.Add(Me.lblPartNumberPai)
        Me.grpItem.Controls.Add(Me.cboPartNumberPai)
        Me.grpItem.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpItem.Controls.Add(Me.btnQuantidadeAberto)
        Me.grpItem.Controls.Add(Me.txtQuantidadeAberto)
        Me.grpItem.Controls.Add(Me.lblQuantidadeAberto)
        Me.grpItem.Controls.Add(Me.cboTipoItem)
        Me.grpItem.Controls.Add(Me.lblTipoItem)
        Me.grpItem.Controls.Add(Me.txtMultiploCompra)
        Me.grpItem.Controls.Add(Me.lblMultiploCompra)
        Me.grpItem.Controls.Add(Me.txtQuantidadeMinima)
        Me.grpItem.Controls.Add(Me.lblQuantidadeMinima)
        Me.grpItem.Controls.Add(Me.dtpDataNecessidadeItem)
        Me.grpItem.Controls.Add(Me.cboItem)
        Me.grpItem.Controls.Add(Me.lblCodigoItem)
        Me.grpItem.Controls.Add(Me.lblJustificativaItem)
        Me.grpItem.Controls.Add(Me.cboContaContabilItem)
        Me.grpItem.Controls.Add(Me.lblContaContabilItem)
        Me.grpItem.Controls.Add(Me.lblCentroGastoItem)
        Me.grpItem.Controls.Add(Me.cboCentroGastoItem)
        Me.grpItem.Controls.Add(Me.lblComplementoItem)
        Me.grpItem.Controls.Add(Me.txtComplementoItem)
        Me.grpItem.Controls.Add(Me.lblDataNecessidadeItem)
        Me.grpItem.Controls.Add(Me.lblUnidadeMedidaItem)
        Me.grpItem.Controls.Add(Me.cboUnidadeMedidaItem)
        Me.grpItem.Controls.Add(Me.txtQuantidadeItem)
        Me.grpItem.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpItem.Controls.Add(Me.btnProcurarItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarCentroGastoItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarContaContabilItem)
        Me.grpItem.Controls.Add(Me.lblQuantidadeItem)
        Me.grpItem.Controls.Add(Me.txtMarcaItem)
        Me.grpItem.Controls.Add(Me.lblMarcaItem)
        Me.grpItem.Controls.Add(Me.txtDescricaoItem)
        Me.grpItem.Controls.Add(Me.lblDescricaoItem)
        Me.grpItem.Controls.Add(Me.txtJustificativaItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarUnidadeMedidaItem)
        Me.grpItem.Controls.Add(Me.btnExcluirItem)
        Me.grpItem.Controls.Add(Me.btnInserirItem)
        Me.grpItem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpItem.Location = New System.Drawing.Point(8, 3)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpItem.Size = New System.Drawing.Size(879, 184)
        Me.grpItem.TabIndex = 1
        Me.grpItem.VisualStyleManager = Me.vsmMain
        '
        'lblOrdemDeProducaoPai
        '
        Me.lblOrdemDeProducaoPai.AutoSize = True
        Me.lblOrdemDeProducaoPai.Location = New System.Drawing.Point(337, 138)
        Me.lblOrdemDeProducaoPai.Name = "lblOrdemDeProducaoPai"
        Me.lblOrdemDeProducaoPai.Size = New System.Drawing.Size(123, 13)
        Me.lblOrdemDeProducaoPai.TabIndex = 41
        Me.lblOrdemDeProducaoPai.Text = "Ordem de Produção Pai:"
        '
        'cboOrdemDeProducaoPai
        '
        Me.cboOrdemDeProducaoPai.AutoSize = False
        Me.cboOrdemDeProducaoPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrdemDeProducaoPai.Location = New System.Drawing.Point(340, 154)
        Me.cboOrdemDeProducaoPai.Name = "cboOrdemDeProducaoPai"
        Me.cboOrdemDeProducaoPai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrdemDeProducaoPai.Size = New System.Drawing.Size(178, 20)
        Me.cboOrdemDeProducaoPai.TabIndex = 40
        '
        'lblPartNumberPai
        '
        Me.lblPartNumberPai.AutoSize = True
        Me.lblPartNumberPai.Location = New System.Drawing.Point(337, 98)
        Me.lblPartNumberPai.Name = "lblPartNumberPai"
        Me.lblPartNumberPai.Size = New System.Drawing.Size(87, 13)
        Me.lblPartNumberPai.TabIndex = 39
        Me.lblPartNumberPai.Text = "Part Number Pai:"
        '
        'cboPartNumberPai
        '
        Me.cboPartNumberPai.AutoSize = False
        Me.cboPartNumberPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPartNumberPai.Location = New System.Drawing.Point(340, 114)
        Me.cboPartNumberPai.Name = "cboPartNumberPai"
        Me.cboPartNumberPai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPartNumberPai.Size = New System.Drawing.Size(178, 20)
        Me.cboPartNumberPai.TabIndex = 38
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(317, 136)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 32
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'btnQuantidadeAberto
        '
        Me.btnQuantidadeAberto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuantidadeAberto.FlatAppearance.BorderSize = 0
        Me.btnQuantidadeAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuantidadeAberto.Image = Global.INTERACTI.My.Resources.Resources.grid
        Me.btnQuantidadeAberto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnQuantidadeAberto.Location = New System.Drawing.Point(557, 56)
        Me.btnQuantidadeAberto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnQuantidadeAberto.Name = "btnQuantidadeAberto"
        Me.btnQuantidadeAberto.Size = New System.Drawing.Size(17, 16)
        SuperTipSettings1.HeaderText = "Quantidade em Aberto"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Σ Quantidade de Pedido de Compra em Trânsito."
        Me.jstTip.SetSuperTip(Me.btnQuantidadeAberto, SuperTipSettings1)
        Me.btnQuantidadeAberto.TabIndex = 18
        Me.btnQuantidadeAberto.TabStop = False
        Me.btnQuantidadeAberto.UseVisualStyleBackColor = True
        '
        'txtQuantidadeAberto
        '
        Me.txtQuantidadeAberto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeAberto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeAberto.DecimalDigits = 4
        Me.txtQuantidadeAberto.Location = New System.Drawing.Point(558, 74)
        Me.txtQuantidadeAberto.MaxLength = 0
        Me.txtQuantidadeAberto.Name = "txtQuantidadeAberto"
        Me.txtQuantidadeAberto.ReadOnly = True
        Me.txtQuantidadeAberto.Size = New System.Drawing.Size(100, 20)
        SuperTipSettings2.HeaderText = "Quantidade em Aberto"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Σ Quantidade de Pedido de Compra em Trânsito."
        Me.jstTip.SetSuperTip(Me.txtQuantidadeAberto, SuperTipSettings2)
        Me.txtQuantidadeAberto.TabIndex = 20
        Me.txtQuantidadeAberto.TabStop = False
        Me.txtQuantidadeAberto.Text = "0,0000"
        Me.txtQuantidadeAberto.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeAberto
        '
        Me.lblQuantidadeAberto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeAberto.AutoSize = True
        Me.lblQuantidadeAberto.Location = New System.Drawing.Point(577, 57)
        Me.lblQuantidadeAberto.Name = "lblQuantidadeAberto"
        Me.lblQuantidadeAberto.Size = New System.Drawing.Size(70, 13)
        SuperTipSettings3.HeaderText = "Quantidade em Aberto"
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Σ Quantidade de Pedido de Compra em Trânsito."
        Me.jstTip.SetSuperTip(Me.lblQuantidadeAberto, SuperTipSettings3)
        Me.lblQuantidadeAberto.TabIndex = 19
        Me.lblQuantidadeAberto.Text = "Qtde. Aberto:"
        '
        'cboTipoItem
        '
        Me.cboTipoItem.AutoSize = False
        Me.cboTipoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboTipoItem.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboTipoItem.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoItem.Name = "cboTipoItem"
        Me.cboTipoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoItem.Size = New System.Drawing.Size(132, 20)
        Me.cboTipoItem.TabIndex = 1
        '
        'lblTipoItem
        '
        Me.lblTipoItem.AutoSize = True
        Me.lblTipoItem.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoItem.Name = "lblTipoItem"
        Me.lblTipoItem.Size = New System.Drawing.Size(69, 13)
        Me.lblTipoItem.TabIndex = 0
        Me.lblTipoItem.Text = "Tipo de Item:"
        '
        'txtMultiploCompra
        '
        Me.txtMultiploCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMultiploCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMultiploCompra.DecimalDigits = 4
        Me.txtMultiploCompra.Location = New System.Drawing.Point(770, 34)
        Me.txtMultiploCompra.MaxLength = 0
        Me.txtMultiploCompra.Name = "txtMultiploCompra"
        Me.txtMultiploCompra.ReadOnly = True
        Me.txtMultiploCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtMultiploCompra.TabIndex = 11
        Me.txtMultiploCompra.TabStop = False
        Me.txtMultiploCompra.Text = "0,0000"
        Me.txtMultiploCompra.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblMultiploCompra
        '
        Me.lblMultiploCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMultiploCompra.AutoSize = True
        Me.lblMultiploCompra.Location = New System.Drawing.Point(767, 17)
        Me.lblMultiploCompra.Name = "lblMultiploCompra"
        Me.lblMultiploCompra.Size = New System.Drawing.Size(90, 13)
        Me.lblMultiploCompra.TabIndex = 10
        Me.lblMultiploCompra.Text = "Múltiplo Compras:"
        '
        'txtQuantidadeMinima
        '
        Me.txtQuantidadeMinima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeMinima.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeMinima.DecimalDigits = 4
        Me.txtQuantidadeMinima.Location = New System.Drawing.Point(664, 34)
        Me.txtQuantidadeMinima.MaxLength = 0
        Me.txtQuantidadeMinima.Name = "txtQuantidadeMinima"
        Me.txtQuantidadeMinima.ReadOnly = True
        Me.txtQuantidadeMinima.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeMinima.TabIndex = 9
        Me.txtQuantidadeMinima.TabStop = False
        Me.txtQuantidadeMinima.Text = "0,0000"
        Me.txtQuantidadeMinima.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeMinima
        '
        Me.lblQuantidadeMinima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeMinima.AutoSize = True
        Me.lblQuantidadeMinima.Location = New System.Drawing.Point(662, 17)
        Me.lblQuantidadeMinima.Name = "lblQuantidadeMinima"
        Me.lblQuantidadeMinima.Size = New System.Drawing.Size(74, 13)
        Me.lblQuantidadeMinima.TabIndex = 8
        Me.lblQuantidadeMinima.Text = "Qtde. Mínima:"
        '
        'dtpDataNecessidadeItem
        '
        Me.dtpDataNecessidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataNecessidadeItem.DropDownCalendar.Name = ""
        Me.dtpDataNecessidadeItem.Location = New System.Drawing.Point(770, 74)
        Me.dtpDataNecessidadeItem.Name = "dtpDataNecessidadeItem"
        Me.dtpDataNecessidadeItem.ShowCheckBox = True
        Me.dtpDataNecessidadeItem.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataNecessidadeItem.TabIndex = 25
        '
        'cboItem
        '
        Me.cboItem.AutoSize = False
        Me.cboItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboItem.Location = New System.Drawing.Point(147, 34)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboItem.Size = New System.Drawing.Size(187, 20)
        Me.cboItem.TabIndex = 5
        '
        'lblCodigoItem
        '
        Me.lblCodigoItem.AutoSize = True
        Me.lblCodigoItem.Location = New System.Drawing.Point(163, 17)
        Me.lblCodigoItem.Name = "lblCodigoItem"
        Me.lblCodigoItem.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigoItem.TabIndex = 3
        Me.lblCodigoItem.Text = "Código:"
        '
        'lblJustificativaItem
        '
        Me.lblJustificativaItem.AutoSize = True
        Me.lblJustificativaItem.Location = New System.Drawing.Point(521, 97)
        Me.lblJustificativaItem.Name = "lblJustificativaItem"
        Me.lblJustificativaItem.Size = New System.Drawing.Size(65, 13)
        Me.lblJustificativaItem.TabIndex = 34
        Me.lblJustificativaItem.Text = "Justificativa:"
        '
        'cboContaContabilItem
        '
        Me.cboContaContabilItem.AutoSize = False
        Me.cboContaContabilItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabilItem.Location = New System.Drawing.Point(9, 154)
        Me.cboContaContabilItem.Name = "cboContaContabilItem"
        Me.cboContaContabilItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabilItem.Size = New System.Drawing.Size(325, 20)
        Me.cboContaContabilItem.TabIndex = 33
        '
        'lblContaContabilItem
        '
        Me.lblContaContabilItem.AutoSize = True
        Me.lblContaContabilItem.Location = New System.Drawing.Point(25, 137)
        Me.lblContaContabilItem.Name = "lblContaContabilItem"
        Me.lblContaContabilItem.Size = New System.Drawing.Size(79, 13)
        Me.lblContaContabilItem.TabIndex = 31
        Me.lblContaContabilItem.Text = "Conta Contábil:"
        '
        'lblCentroGastoItem
        '
        Me.lblCentroGastoItem.AutoSize = True
        Me.lblCentroGastoItem.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroGastoItem.Location = New System.Drawing.Point(25, 97)
        Me.lblCentroGastoItem.Name = "lblCentroGastoItem"
        Me.lblCentroGastoItem.Size = New System.Drawing.Size(87, 13)
        Me.lblCentroGastoItem.TabIndex = 27
        Me.lblCentroGastoItem.Text = "Centro de Gasto:"
        '
        'cboCentroGastoItem
        '
        Me.cboCentroGastoItem.AutoSize = False
        Me.cboCentroGastoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboCentroGastoItem.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboCentroGastoItem.Location = New System.Drawing.Point(9, 114)
        Me.cboCentroGastoItem.Name = "cboCentroGastoItem"
        Me.cboCentroGastoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGastoItem.Size = New System.Drawing.Size(325, 20)
        Me.cboCentroGastoItem.TabIndex = 29
        '
        'lblComplementoItem
        '
        Me.lblComplementoItem.AutoSize = True
        Me.lblComplementoItem.Location = New System.Drawing.Point(6, 57)
        Me.lblComplementoItem.Name = "lblComplementoItem"
        Me.lblComplementoItem.Size = New System.Drawing.Size(74, 13)
        Me.lblComplementoItem.TabIndex = 12
        Me.lblComplementoItem.Text = "Complemento:"
        '
        'txtComplementoItem
        '
        Me.txtComplementoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoItem.Location = New System.Drawing.Point(9, 74)
        Me.txtComplementoItem.MaxLength = 100
        Me.txtComplementoItem.Name = "txtComplementoItem"
        Me.txtComplementoItem.Size = New System.Drawing.Size(325, 20)
        Me.txtComplementoItem.TabIndex = 13
        '
        'lblDataNecessidadeItem
        '
        Me.lblDataNecessidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataNecessidadeItem.AutoSize = True
        Me.lblDataNecessidadeItem.Location = New System.Drawing.Point(767, 57)
        Me.lblDataNecessidadeItem.Name = "lblDataNecessidadeItem"
        Me.lblDataNecessidadeItem.Size = New System.Drawing.Size(98, 13)
        Me.lblDataNecessidadeItem.TabIndex = 24
        Me.lblDataNecessidadeItem.Text = "Data Necessidade:"
        '
        'lblUnidadeMedidaItem
        '
        Me.lblUnidadeMedidaItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnidadeMedidaItem.AutoSize = True
        Me.lblUnidadeMedidaItem.Location = New System.Drawing.Point(680, 57)
        Me.lblUnidadeMedidaItem.Name = "lblUnidadeMedidaItem"
        Me.lblUnidadeMedidaItem.Size = New System.Drawing.Size(60, 13)
        Me.lblUnidadeMedidaItem.TabIndex = 22
        Me.lblUnidadeMedidaItem.Text = "Und. Med.:"
        '
        'cboUnidadeMedidaItem
        '
        Me.cboUnidadeMedidaItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUnidadeMedidaItem.AutoSize = False
        Me.cboUnidadeMedidaItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaItem.Location = New System.Drawing.Point(664, 74)
        Me.cboUnidadeMedidaItem.Name = "cboUnidadeMedidaItem"
        Me.cboUnidadeMedidaItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaItem.Size = New System.Drawing.Size(100, 20)
        Me.cboUnidadeMedidaItem.TabIndex = 23
        '
        'txtQuantidadeItem
        '
        Me.txtQuantidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeItem.DecimalDigits = 4
        Me.txtQuantidadeItem.Location = New System.Drawing.Point(452, 74)
        Me.txtQuantidadeItem.MaxLength = 0
        Me.txtQuantidadeItem.Name = "txtQuantidadeItem"
        Me.txtQuantidadeItem.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeItem.TabIndex = 17
        Me.txtQuantidadeItem.Text = "0,0000"
        Me.txtQuantidadeItem.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(317, 96)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 28
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(317, 15)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 4
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarItem
        '
        Me.btnCadastrarItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarItem.Location = New System.Drawing.Point(147, 18)
        Me.btnCadastrarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarItem.Name = "btnCadastrarItem"
        Me.btnCadastrarItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarItem.TabIndex = 2
        Me.btnCadastrarItem.TabStop = False
        Me.btnCadastrarItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGastoItem
        '
        Me.btnCadastrarCentroGastoItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGastoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGastoItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGastoItem.Location = New System.Drawing.Point(9, 98)
        Me.btnCadastrarCentroGastoItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGastoItem.Name = "btnCadastrarCentroGastoItem"
        Me.btnCadastrarCentroGastoItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGastoItem.TabIndex = 26
        Me.btnCadastrarCentroGastoItem.TabStop = False
        Me.btnCadastrarCentroGastoItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarContaContabilItem
        '
        Me.btnCadastrarContaContabilItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabilItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabilItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabilItem.Location = New System.Drawing.Point(9, 138)
        Me.btnCadastrarContaContabilItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabilItem.Name = "btnCadastrarContaContabilItem"
        Me.btnCadastrarContaContabilItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabilItem.TabIndex = 30
        Me.btnCadastrarContaContabilItem.TabStop = False
        Me.btnCadastrarContaContabilItem.UseVisualStyleBackColor = True
        '
        'lblQuantidadeItem
        '
        Me.lblQuantidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeItem.AutoSize = True
        Me.lblQuantidadeItem.Location = New System.Drawing.Point(449, 57)
        Me.lblQuantidadeItem.Name = "lblQuantidadeItem"
        Me.lblQuantidadeItem.Size = New System.Drawing.Size(65, 13)
        Me.lblQuantidadeItem.TabIndex = 16
        Me.lblQuantidadeItem.Text = "Quantidade:"
        '
        'txtMarcaItem
        '
        Me.txtMarcaItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarcaItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaItem.Location = New System.Drawing.Point(340, 74)
        Me.txtMarcaItem.MaxLength = 100
        Me.txtMarcaItem.Name = "txtMarcaItem"
        Me.txtMarcaItem.Size = New System.Drawing.Size(106, 20)
        Me.txtMarcaItem.TabIndex = 15
        '
        'lblMarcaItem
        '
        Me.lblMarcaItem.AutoSize = True
        Me.lblMarcaItem.Location = New System.Drawing.Point(337, 57)
        Me.lblMarcaItem.Name = "lblMarcaItem"
        Me.lblMarcaItem.Size = New System.Drawing.Size(40, 13)
        Me.lblMarcaItem.TabIndex = 14
        Me.lblMarcaItem.Text = "Marca:"
        '
        'txtDescricaoItem
        '
        Me.txtDescricaoItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoItem.Location = New System.Drawing.Point(340, 34)
        Me.txtDescricaoItem.MaxLength = 120
        Me.txtDescricaoItem.Name = "txtDescricaoItem"
        Me.txtDescricaoItem.ReadOnly = True
        Me.txtDescricaoItem.Size = New System.Drawing.Size(318, 20)
        Me.txtDescricaoItem.TabIndex = 7
        Me.txtDescricaoItem.TabStop = False
        '
        'lblDescricaoItem
        '
        Me.lblDescricaoItem.AutoSize = True
        Me.lblDescricaoItem.Location = New System.Drawing.Point(337, 17)
        Me.lblDescricaoItem.Name = "lblDescricaoItem"
        Me.lblDescricaoItem.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricaoItem.TabIndex = 6
        Me.lblDescricaoItem.Text = "Descrição:"
        '
        'txtJustificativaItem
        '
        Me.txtJustificativaItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativaItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativaItem.Location = New System.Drawing.Point(524, 114)
        Me.txtJustificativaItem.MaxLength = 500
        Me.txtJustificativaItem.Multiline = True
        Me.txtJustificativaItem.Name = "txtJustificativaItem"
        Me.txtJustificativaItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativaItem.Size = New System.Drawing.Size(248, 60)
        Me.txtJustificativaItem.TabIndex = 35
        '
        'btnCadastrarUnidadeMedidaItem
        '
        Me.btnCadastrarUnidadeMedidaItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarUnidadeMedidaItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedidaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedidaItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedidaItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedidaItem.Location = New System.Drawing.Point(664, 58)
        Me.btnCadastrarUnidadeMedidaItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedidaItem.Name = "btnCadastrarUnidadeMedidaItem"
        Me.btnCadastrarUnidadeMedidaItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedidaItem.TabIndex = 21
        Me.btnCadastrarUnidadeMedidaItem.TabStop = False
        Me.btnCadastrarUnidadeMedidaItem.UseVisualStyleBackColor = True
        '
        'btnExcluirItem
        '
        Me.btnExcluirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirItem.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirItem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirItem.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirItem.Location = New System.Drawing.Point(779, 151)
        Me.btnExcluirItem.Name = "btnExcluirItem"
        Me.btnExcluirItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirItem.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirItem.TabIndex = 37
        Me.btnExcluirItem.Text = "Excluir"
        Me.btnExcluirItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirItem
        '
        Me.btnInserirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirItem.Image = CType(resources.GetObject("btnInserirItem.Image"), System.Drawing.Image)
        Me.btnInserirItem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirItem.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirItem.Location = New System.Drawing.Point(779, 122)
        Me.btnInserirItem.Name = "btnInserirItem"
        Me.btnInserirItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirItem.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirItem.TabIndex = 36
        Me.btnInserirItem.Text = "Inserir"
        Me.btnInserirItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdItem
        '
        Me.grdItem.AlternatingColors = True
        Me.grdItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItem.AutoEdit = True
        grdItem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdItem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdItem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdItem_DesignTimeLayout_Reference_0})
        grdItem_DesignTimeLayout.LayoutString = resources.GetString("grdItem_DesignTimeLayout.LayoutString")
        Me.grdItem.DesignTimeLayout = grdItem_DesignTimeLayout
        Me.grdItem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdItem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdItem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdItem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdItem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdItem.FrozenColumns = 2
        Me.grdItem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdItem.GroupByBoxVisible = False
        Me.grdItem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdItem.Location = New System.Drawing.Point(8, 196)
        Me.grdItem.Name = "grdItem"
        Me.grdItem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdItem.RecordNavigator = True
        Me.grdItem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdItem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdItem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdItem.Size = New System.Drawing.Size(879, 180)
        Me.grdItem.TabIndex = 2
        Me.grdItem.TabStop = False
        Me.grdItem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdItem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdItem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdItem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdItem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdItem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdItem.VisualStyleManager = Me.vsmMain
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
        Me.pagArquivo.Size = New System.Drawing.Size(895, 385)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Text = "Arquivos"
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 359)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 55
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
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 359)
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
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 359)
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
        Me.lblRevisaoArquivo.Size = New System.Drawing.Size(49, 13)
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
        Me.btnCadastrarTipoArquivo.Image = Global.INTERACTI.My.Resources.Resources.add
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
        Me.lblTipoArquivo.Size = New System.Drawing.Size(85, 13)
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
        Me.lblArquivo.Size = New System.Drawing.Size(46, 13)
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
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.Resources.excluir
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
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.Resources.salvar
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
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(58, 13)
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
        Me.grdArquivo.Size = New System.Drawing.Size(879, 260)
        Me.grdArquivo.TabIndex = 1
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCmpRequisicaoRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpRequisicaoRelatorio"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpDadosRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosRequisicao.ResumeLayout(False)
        Me.grpDadosRequisicao.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagItem.ResumeLayout(False)
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagArquivo.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosRequisicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAprovador As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents cboAprovador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblItemFiltro As System.Windows.Forms.Label
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroRequisicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCentroGastoItem As System.Windows.Forms.Label
    Friend WithEvents cboCentroGastoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblComplementoItem As System.Windows.Forms.Label
    Friend WithEvents txtComplementoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataNecessidadeItem As System.Windows.Forms.Label
    Friend WithEvents lblUnidadeMedidaItem As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedidaItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtQuantidadeItem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeItem As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarUnidadeMedidaItem As System.Windows.Forms.Button
    Friend WithEvents btnExcluirItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtMarcaItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarcaItem As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarContaContabilItem As System.Windows.Forms.Button
    Friend WithEvents cboContaContabilItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaContabilItem As System.Windows.Forms.Label
    Friend WithEvents lblJustificativaItem As System.Windows.Forms.Label
    Friend WithEvents txtJustificativaItem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents btnCadastrarCentroGastoItem As System.Windows.Forms.Button
    Friend WithEvents grdItem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoItem As System.Windows.Forms.Label
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarItem As System.Windows.Forms.Button
    Friend WithEvents txtDescricaoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoItem As System.Windows.Forms.Label
    Friend WithEvents dtpDataRequisicaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataRequisicaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataNecessidadeItem As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridItem As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtQuantidadeMinima As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeMinima As System.Windows.Forms.Label
    Friend WithEvents txtMultiploCompra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMultiploCompra As System.Windows.Forms.Label
    Friend WithEvents cboTipoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoItem As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagItem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtQuantidadeAberto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeAberto As System.Windows.Forms.Label
    Friend WithEvents btnQuantidadeAberto As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItemFiltro As System.Windows.Forms.Button
    Friend WithEvents cboAprovadorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAprovadorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboRequisitanteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRequisitanteFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusRequisicaoFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridItem As System.Windows.Forms.Button
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
    Friend WithEvents lblCongelarColunaItem As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColunaItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridItem As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents lblOrdemDeProducaoPai As System.Windows.Forms.Label
    Friend WithEvents cboOrdemDeProducaoPai As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPartNumberPai As System.Windows.Forms.Label
    Friend WithEvents cboPartNumberPai As Janus.Windows.EditControls.UIComboBox

End Class
