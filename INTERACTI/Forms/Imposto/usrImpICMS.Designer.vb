<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrImpICMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrImpICMS))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblSituacaoTributariaICMSFiltro = New System.Windows.Forms.Label()
        Me.cboSituacaoTributariaICMSFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNaturezaOperacaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNaturezaOperacaoFiltro = New System.Windows.Forms.Label()
        Me.lblCFOPFiltro = New System.Windows.Forms.Label()
        Me.cboCFOPFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabICMS = New Janus.Windows.UI.Tab.UITab()
        Me.pagICMS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpBCICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.txtFormula = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControleBCICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnRedICMS = New Janus.Windows.EditControls.UIButton()
        Me.btnAliquotaII = New Janus.Windows.EditControls.UIButton()
        Me.btnII = New Janus.Windows.EditControls.UIButton()
        Me.btnDesconto = New Janus.Windows.EditControls.UIButton()
        Me.btnValor = New Janus.Windows.EditControls.UIButton()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnOutrasDespesas = New Janus.Windows.EditControls.UIButton()
        Me.btnSeguro = New Janus.Windows.EditControls.UIButton()
        Me.btnFrete = New Janus.Windows.EditControls.UIButton()
        Me.btnAliquotaICMS = New Janus.Windows.EditControls.UIButton()
        Me.btnProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnC = New Janus.Windows.EditControls.UIButton()
        Me.btnCE = New Janus.Windows.EditControls.UIButton()
        Me.btnFechaParenteses = New Janus.Windows.EditControls.UIButton()
        Me.btnAbreParenteses = New Janus.Windows.EditControls.UIButton()
        Me.btnDivide = New Janus.Windows.EditControls.UIButton()
        Me.btnMultiplica = New Janus.Windows.EditControls.UIButton()
        Me.btnSubtrai = New Janus.Windows.EditControls.UIButton()
        Me.btnCOFINS = New Janus.Windows.EditControls.UIButton()
        Me.btnPIS = New Janus.Windows.EditControls.UIButton()
        Me.btnIPI = New Janus.Windows.EditControls.UIButton()
        Me.btnSoma = New Janus.Windows.EditControls.UIButton()
        Me.pagICMSST = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpBCICMSST = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFormulaST = New System.Windows.Forms.Label()
        Me.txtFormulaST = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControleBCICMSST = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnIIST = New Janus.Windows.EditControls.UIButton()
        Me.btnDescontoST = New Janus.Windows.EditControls.UIButton()
        Me.btnIVAST = New Janus.Windows.EditControls.UIButton()
        Me.btnPautaST = New Janus.Windows.EditControls.UIButton()
        Me.btnValorST = New Janus.Windows.EditControls.UIButton()
        Me.txtValorST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnOutrasDespesasST = New Janus.Windows.EditControls.UIButton()
        Me.btnSeguroST = New Janus.Windows.EditControls.UIButton()
        Me.btnFreteST = New Janus.Windows.EditControls.UIButton()
        Me.btnAliquotaICMSST = New Janus.Windows.EditControls.UIButton()
        Me.btnProdutoST = New Janus.Windows.EditControls.UIButton()
        Me.btnCST = New Janus.Windows.EditControls.UIButton()
        Me.btnCEST = New Janus.Windows.EditControls.UIButton()
        Me.btnFechaParentesesST = New Janus.Windows.EditControls.UIButton()
        Me.btnAbreParentesesST = New Janus.Windows.EditControls.UIButton()
        Me.btnDivideST = New Janus.Windows.EditControls.UIButton()
        Me.btnMultiplicaST = New Janus.Windows.EditControls.UIButton()
        Me.btnSubtraiST = New Janus.Windows.EditControls.UIButton()
        Me.btnCOFINSST = New Janus.Windows.EditControls.UIButton()
        Me.btnPISST = New Janus.Windows.EditControls.UIButton()
        Me.btnIPIST = New Janus.Windows.EditControls.UIButton()
        Me.btnSomaST = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarCFOP = New System.Windows.Forms.Button()
        Me.lblSituacaoTributariaICMS = New System.Windows.Forms.Label()
        Me.cboSituacaoTributariaICMS = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNaturezaOperacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNaturezaOperacao = New System.Windows.Forms.Label()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabICMS.SuspendLayout()
        Me.pagICMS.SuspendLayout()
        CType(Me.grpBCICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBCICMS.SuspendLayout()
        CType(Me.grpControleBCICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleBCICMS.SuspendLayout()
        Me.pagICMSST.SuspendLayout()
        CType(Me.grpBCICMSST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBCICMSST.SuspendLayout()
        CType(Me.grpControleBCICMSST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleBCICMSST.SuspendLayout()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 453)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Fórmula da Base de Cálculo do ICMS"
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
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
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
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
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 274)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(603, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
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
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(700, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblSituacaoTributariaICMSFiltro)
        Me.grpFiltro.Controls.Add(Me.cboSituacaoTributariaICMSFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNaturezaOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNaturezaOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCFOPFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblSituacaoTributariaICMSFiltro
        '
        Me.lblSituacaoTributariaICMSFiltro.AutoSize = True
        Me.lblSituacaoTributariaICMSFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblSituacaoTributariaICMSFiltro.Name = "lblSituacaoTributariaICMSFiltro"
        Me.lblSituacaoTributariaICMSFiltro.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaICMSFiltro.TabIndex = 4
        Me.lblSituacaoTributariaICMSFiltro.Text = "Situação Tributária:"
        '
        'cboSituacaoTributariaICMSFiltro
        '
        Me.cboSituacaoTributariaICMSFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaICMSFiltro.AutoSize = False
        Me.cboSituacaoTributariaICMSFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboSituacaoTributariaICMSFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboSituacaoTributariaICMSFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboSituacaoTributariaICMSFiltro.Name = "cboSituacaoTributariaICMSFiltro"
        Me.cboSituacaoTributariaICMSFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaICMSFiltro.Size = New System.Drawing.Size(745, 20)
        Me.cboSituacaoTributariaICMSFiltro.TabIndex = 5
        '
        'txtNaturezaOperacaoFiltro
        '
        Me.txtNaturezaOperacaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNaturezaOperacaoFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNaturezaOperacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNaturezaOperacaoFiltro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaturezaOperacaoFiltro.Location = New System.Drawing.Point(130, 34)
        Me.txtNaturezaOperacaoFiltro.MaxLength = 350
        Me.txtNaturezaOperacaoFiltro.Name = "txtNaturezaOperacaoFiltro"
        Me.txtNaturezaOperacaoFiltro.ReadOnly = True
        Me.txtNaturezaOperacaoFiltro.Size = New System.Drawing.Size(624, 20)
        Me.txtNaturezaOperacaoFiltro.TabIndex = 3
        Me.txtNaturezaOperacaoFiltro.TabStop = False
        '
        'lblNaturezaOperacaoFiltro
        '
        Me.lblNaturezaOperacaoFiltro.AutoSize = True
        Me.lblNaturezaOperacaoFiltro.Location = New System.Drawing.Point(127, 17)
        Me.lblNaturezaOperacaoFiltro.Name = "lblNaturezaOperacaoFiltro"
        Me.lblNaturezaOperacaoFiltro.Size = New System.Drawing.Size(120, 14)
        Me.lblNaturezaOperacaoFiltro.TabIndex = 2
        Me.lblNaturezaOperacaoFiltro.Text = "Natureza da Operação:"
        '
        'lblCFOPFiltro
        '
        Me.lblCFOPFiltro.AutoSize = True
        Me.lblCFOPFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCFOPFiltro.Name = "lblCFOPFiltro"
        Me.lblCFOPFiltro.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOPFiltro.TabIndex = 0
        Me.lblCFOPFiltro.Text = "CFOP:"
        '
        'cboCFOPFiltro
        '
        Me.cboCFOPFiltro.AutoSize = False
        Me.cboCFOPFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboCFOPFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboCFOPFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboCFOPFiltro.Name = "cboCFOPFiltro"
        Me.cboCFOPFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOPFiltro.Size = New System.Drawing.Size(115, 20)
        Me.cboCFOPFiltro.TabIndex = 1
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabICMS)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Fórmula da Base de Cálculo do ICMS"
        '
        'tabICMS
        '
        Me.tabICMS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabICMS.BackColor = System.Drawing.Color.Transparent
        Me.tabICMS.FocusOnClick = False
        Me.tabICMS.Location = New System.Drawing.Point(8, 113)
        Me.tabICMS.Name = "tabICMS"
        Me.tabICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabICMS.ShowFocusRectangle = False
        Me.tabICMS.Size = New System.Drawing.Size(897, 277)
        Me.tabICMS.TabIndex = 0
        Me.tabICMS.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagICMS, Me.pagICMSST})
        Me.tabICMS.TabStop = False
        Me.tabICMS.VisualStyleManager = Me.vsmMain
        '
        'pagICMS
        '
        Me.pagICMS.Controls.Add(Me.grpBCICMS)
        Me.pagICMS.Controls.Add(Me.grpControleBCICMS)
        Me.pagICMS.Key = "pagICMS"
        Me.pagICMS.Location = New System.Drawing.Point(1, 22)
        Me.pagICMS.Name = "pagICMS"
        Me.pagICMS.Size = New System.Drawing.Size(895, 254)
        Me.pagICMS.TabStop = True
        Me.pagICMS.Text = "ICMS"
        '
        'grpBCICMS
        '
        Me.grpBCICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBCICMS.BackColor = System.Drawing.Color.Transparent
        Me.grpBCICMS.Controls.Add(Me.lblFormula)
        Me.grpBCICMS.Controls.Add(Me.txtFormula)
        Me.grpBCICMS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpBCICMS.Location = New System.Drawing.Point(253, 3)
        Me.grpBCICMS.Name = "grpBCICMS"
        Me.grpBCICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBCICMS.Size = New System.Drawing.Size(634, 67)
        Me.grpBCICMS.TabIndex = 1
        Me.grpBCICMS.Text = "Base de Cálculo ICMS"
        Me.grpBCICMS.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpBCICMS.VisualStyleManager = Me.vsmMain
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Location = New System.Drawing.Point(6, 20)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(48, 14)
        Me.lblFormula.TabIndex = 0
        Me.lblFormula.Text = "Formula:"
        '
        'txtFormula
        '
        Me.txtFormula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormula.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFormula.Location = New System.Drawing.Point(9, 37)
        Me.txtFormula.MaxLength = 500
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.ReadOnly = True
        Me.txtFormula.Size = New System.Drawing.Size(616, 20)
        Me.txtFormula.TabIndex = 1
        Me.txtFormula.TabStop = False
        '
        'grpControleBCICMS
        '
        Me.grpControleBCICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControleBCICMS.BackColor = System.Drawing.Color.Transparent
        Me.grpControleBCICMS.Controls.Add(Me.btnRedICMS)
        Me.grpControleBCICMS.Controls.Add(Me.btnAliquotaII)
        Me.grpControleBCICMS.Controls.Add(Me.btnII)
        Me.grpControleBCICMS.Controls.Add(Me.btnDesconto)
        Me.grpControleBCICMS.Controls.Add(Me.btnValor)
        Me.grpControleBCICMS.Controls.Add(Me.txtValor)
        Me.grpControleBCICMS.Controls.Add(Me.btnOutrasDespesas)
        Me.grpControleBCICMS.Controls.Add(Me.btnSeguro)
        Me.grpControleBCICMS.Controls.Add(Me.btnFrete)
        Me.grpControleBCICMS.Controls.Add(Me.btnAliquotaICMS)
        Me.grpControleBCICMS.Controls.Add(Me.btnProduto)
        Me.grpControleBCICMS.Controls.Add(Me.btnC)
        Me.grpControleBCICMS.Controls.Add(Me.btnCE)
        Me.grpControleBCICMS.Controls.Add(Me.btnFechaParenteses)
        Me.grpControleBCICMS.Controls.Add(Me.btnAbreParenteses)
        Me.grpControleBCICMS.Controls.Add(Me.btnDivide)
        Me.grpControleBCICMS.Controls.Add(Me.btnMultiplica)
        Me.grpControleBCICMS.Controls.Add(Me.btnSubtrai)
        Me.grpControleBCICMS.Controls.Add(Me.btnCOFINS)
        Me.grpControleBCICMS.Controls.Add(Me.btnPIS)
        Me.grpControleBCICMS.Controls.Add(Me.btnIPI)
        Me.grpControleBCICMS.Controls.Add(Me.btnSoma)
        Me.grpControleBCICMS.Location = New System.Drawing.Point(8, 3)
        Me.grpControleBCICMS.Name = "grpControleBCICMS"
        Me.grpControleBCICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleBCICMS.Size = New System.Drawing.Size(236, 242)
        Me.grpControleBCICMS.TabIndex = 0
        Me.grpControleBCICMS.VisualStyleManager = Me.vsmMain
        '
        'btnRedICMS
        '
        Me.btnRedICMS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRedICMS.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnRedICMS.Location = New System.Drawing.Point(121, 173)
        Me.btnRedICMS.Name = "btnRedICMS"
        Me.btnRedICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRedICMS.Size = New System.Drawing.Size(106, 20)
        Me.btnRedICMS.TabIndex = 13
        Me.btnRedICMS.TabStop = False
        Me.btnRedICMS.Tag = "|%RED_ICMS|"
        Me.btnRedICMS.Text = "% Red ICMS"
        Me.btnRedICMS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAliquotaII
        '
        Me.btnAliquotaII.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAliquotaII.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAliquotaII.Location = New System.Drawing.Point(9, 173)
        Me.btnAliquotaII.Name = "btnAliquotaII"
        Me.btnAliquotaII.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAliquotaII.Size = New System.Drawing.Size(106, 20)
        Me.btnAliquotaII.TabIndex = 12
        Me.btnAliquotaII.TabStop = False
        Me.btnAliquotaII.Tag = "|%II|"
        Me.btnAliquotaII.Text = "Alíquota II"
        Me.btnAliquotaII.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnII
        '
        Me.btnII.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnII.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnII.Location = New System.Drawing.Point(9, 147)
        Me.btnII.Name = "btnII"
        Me.btnII.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnII.Size = New System.Drawing.Size(106, 20)
        Me.btnII.TabIndex = 9
        Me.btnII.TabStop = False
        Me.btnII.Tag = "|II|"
        Me.btnII.Text = "Valor do II"
        Me.btnII.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDesconto
        '
        Me.btnDesconto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDesconto.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnDesconto.Location = New System.Drawing.Point(121, 121)
        Me.btnDesconto.Name = "btnDesconto"
        Me.btnDesconto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDesconto.Size = New System.Drawing.Size(106, 20)
        Me.btnDesconto.TabIndex = 8
        Me.btnDesconto.TabStop = False
        Me.btnDesconto.Tag = "|DESCONTO|"
        Me.btnDesconto.Text = "Desconto"
        Me.btnDesconto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnValor
        '
        Me.btnValor.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnValor.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnValor.Location = New System.Drawing.Point(188, 147)
        Me.btnValor.Name = "btnValor"
        Me.btnValor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnValor.Size = New System.Drawing.Size(39, 20)
        Me.btnValor.TabIndex = 11
        Me.btnValor.TabStop = False
        Me.btnValor.Tag = ""
        Me.btnValor.Text = "Valor"
        Me.btnValor.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(121, 147)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(68, 20)
        Me.txtValor.TabIndex = 10
        Me.txtValor.TabStop = False
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnOutrasDespesas
        '
        Me.btnOutrasDespesas.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOutrasDespesas.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnOutrasDespesas.Location = New System.Drawing.Point(121, 95)
        Me.btnOutrasDespesas.Name = "btnOutrasDespesas"
        Me.btnOutrasDespesas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOutrasDespesas.Size = New System.Drawing.Size(106, 20)
        Me.btnOutrasDespesas.TabIndex = 6
        Me.btnOutrasDespesas.TabStop = False
        Me.btnOutrasDespesas.Tag = "|OUTRAS|"
        Me.btnOutrasDespesas.Text = "Outras Despesas"
        Me.btnOutrasDespesas.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSeguro
        '
        Me.btnSeguro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSeguro.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnSeguro.Location = New System.Drawing.Point(121, 69)
        Me.btnSeguro.Name = "btnSeguro"
        Me.btnSeguro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSeguro.Size = New System.Drawing.Size(106, 20)
        Me.btnSeguro.TabIndex = 4
        Me.btnSeguro.TabStop = False
        Me.btnSeguro.Tag = "|SEGURO|"
        Me.btnSeguro.Text = "Valor do Seguro"
        Me.btnSeguro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnFrete
        '
        Me.btnFrete.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFrete.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnFrete.Location = New System.Drawing.Point(121, 43)
        Me.btnFrete.Name = "btnFrete"
        Me.btnFrete.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFrete.Size = New System.Drawing.Size(106, 20)
        Me.btnFrete.TabIndex = 2
        Me.btnFrete.TabStop = False
        Me.btnFrete.Tag = "|FRETE|"
        Me.btnFrete.Text = "Valor do Frete"
        Me.btnFrete.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAliquotaICMS
        '
        Me.btnAliquotaICMS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAliquotaICMS.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAliquotaICMS.Location = New System.Drawing.Point(9, 43)
        Me.btnAliquotaICMS.Name = "btnAliquotaICMS"
        Me.btnAliquotaICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAliquotaICMS.Size = New System.Drawing.Size(106, 20)
        Me.btnAliquotaICMS.TabIndex = 1
        Me.btnAliquotaICMS.TabStop = False
        Me.btnAliquotaICMS.Tag = "|%ICMS|"
        Me.btnAliquotaICMS.Text = "Alíquota ICMS"
        Me.btnAliquotaICMS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProduto
        '
        Me.btnProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProduto.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnProduto.Location = New System.Drawing.Point(9, 17)
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProduto.Size = New System.Drawing.Size(218, 20)
        Me.btnProduto.TabIndex = 0
        Me.btnProduto.TabStop = False
        Me.btnProduto.Tag = "|PRODUTO|"
        Me.btnProduto.Text = "Valor do Produto (Qtde. x Valor Unitário)"
        Me.btnProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnC
        '
        Me.btnC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnC.Location = New System.Drawing.Point(205, 213)
        Me.btnC.Name = "btnC"
        Me.btnC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnC.Size = New System.Drawing.Size(22, 20)
        Me.btnC.TabIndex = 21
        Me.btnC.TabStop = False
        Me.btnC.Tag = ""
        Me.btnC.Text = "C"
        Me.btnC.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCE
        '
        Me.btnCE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCE.Location = New System.Drawing.Point(177, 213)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCE.Size = New System.Drawing.Size(22, 20)
        Me.btnCE.TabIndex = 20
        Me.btnCE.TabStop = False
        Me.btnCE.Tag = ""
        Me.btnCE.Text = "CE"
        Me.btnCE.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnFechaParenteses
        '
        Me.btnFechaParenteses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFechaParenteses.Enabled = False
        Me.btnFechaParenteses.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechaParenteses.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFechaParenteses.Location = New System.Drawing.Point(149, 213)
        Me.btnFechaParenteses.Name = "btnFechaParenteses"
        Me.btnFechaParenteses.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFechaParenteses.Size = New System.Drawing.Size(22, 20)
        Me.btnFechaParenteses.TabIndex = 19
        Me.btnFechaParenteses.TabStop = False
        Me.btnFechaParenteses.Tag = ")"
        Me.btnFechaParenteses.Text = ")"
        Me.btnFechaParenteses.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAbreParenteses
        '
        Me.btnAbreParenteses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbreParenteses.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreParenteses.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAbreParenteses.Location = New System.Drawing.Point(121, 213)
        Me.btnAbreParenteses.Name = "btnAbreParenteses"
        Me.btnAbreParenteses.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAbreParenteses.Size = New System.Drawing.Size(22, 20)
        Me.btnAbreParenteses.TabIndex = 18
        Me.btnAbreParenteses.TabStop = False
        Me.btnAbreParenteses.Tag = "("
        Me.btnAbreParenteses.Text = "("
        Me.btnAbreParenteses.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDivide
        '
        Me.btnDivide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDivide.Enabled = False
        Me.btnDivide.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDivide.Location = New System.Drawing.Point(93, 213)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDivide.Size = New System.Drawing.Size(22, 20)
        Me.btnDivide.TabIndex = 17
        Me.btnDivide.TabStop = False
        Me.btnDivide.Tag = "/"
        Me.btnDivide.Text = "/"
        Me.btnDivide.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnMultiplica
        '
        Me.btnMultiplica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMultiplica.Enabled = False
        Me.btnMultiplica.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplica.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnMultiplica.Location = New System.Drawing.Point(65, 213)
        Me.btnMultiplica.Name = "btnMultiplica"
        Me.btnMultiplica.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnMultiplica.Size = New System.Drawing.Size(22, 20)
        Me.btnMultiplica.TabIndex = 16
        Me.btnMultiplica.TabStop = False
        Me.btnMultiplica.Tag = "*"
        Me.btnMultiplica.Text = "x"
        Me.btnMultiplica.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSubtrai
        '
        Me.btnSubtrai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSubtrai.Enabled = False
        Me.btnSubtrai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtrai.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSubtrai.Location = New System.Drawing.Point(37, 213)
        Me.btnSubtrai.Name = "btnSubtrai"
        Me.btnSubtrai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSubtrai.Size = New System.Drawing.Size(22, 20)
        Me.btnSubtrai.TabIndex = 15
        Me.btnSubtrai.TabStop = False
        Me.btnSubtrai.Tag = "-"
        Me.btnSubtrai.Text = "–"
        Me.btnSubtrai.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCOFINS
        '
        Me.btnCOFINS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCOFINS.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnCOFINS.Location = New System.Drawing.Point(9, 121)
        Me.btnCOFINS.Name = "btnCOFINS"
        Me.btnCOFINS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCOFINS.Size = New System.Drawing.Size(106, 20)
        Me.btnCOFINS.TabIndex = 7
        Me.btnCOFINS.TabStop = False
        Me.btnCOFINS.Tag = "|COFINS|"
        Me.btnCOFINS.Text = "Valor do COFINS"
        Me.btnCOFINS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPIS
        '
        Me.btnPIS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPIS.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPIS.Location = New System.Drawing.Point(9, 95)
        Me.btnPIS.Name = "btnPIS"
        Me.btnPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPIS.Size = New System.Drawing.Size(106, 20)
        Me.btnPIS.TabIndex = 5
        Me.btnPIS.TabStop = False
        Me.btnPIS.Tag = "|PIS|"
        Me.btnPIS.Text = "Valor do PIS"
        Me.btnPIS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnIPI
        '
        Me.btnIPI.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnIPI.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnIPI.Location = New System.Drawing.Point(9, 69)
        Me.btnIPI.Name = "btnIPI"
        Me.btnIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnIPI.Size = New System.Drawing.Size(106, 20)
        Me.btnIPI.TabIndex = 3
        Me.btnIPI.TabStop = False
        Me.btnIPI.Tag = "|IPI|"
        Me.btnIPI.Text = "Valor do IPI"
        Me.btnIPI.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSoma
        '
        Me.btnSoma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSoma.Enabled = False
        Me.btnSoma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoma.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSoma.Location = New System.Drawing.Point(9, 213)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSoma.Size = New System.Drawing.Size(22, 20)
        Me.btnSoma.TabIndex = 14
        Me.btnSoma.TabStop = False
        Me.btnSoma.Tag = "+"
        Me.btnSoma.Text = "+"
        Me.btnSoma.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagICMSST
        '
        Me.pagICMSST.Controls.Add(Me.grpBCICMSST)
        Me.pagICMSST.Controls.Add(Me.grpControleBCICMSST)
        Me.pagICMSST.Key = "pagIPI"
        Me.pagICMSST.Location = New System.Drawing.Point(1, 22)
        Me.pagICMSST.Name = "pagICMSST"
        Me.pagICMSST.Size = New System.Drawing.Size(895, 254)
        Me.pagICMSST.TabStop = True
        Me.pagICMSST.Text = "ICMS ST"
        '
        'grpBCICMSST
        '
        Me.grpBCICMSST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBCICMSST.BackColor = System.Drawing.Color.Transparent
        Me.grpBCICMSST.Controls.Add(Me.lblFormulaST)
        Me.grpBCICMSST.Controls.Add(Me.txtFormulaST)
        Me.grpBCICMSST.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpBCICMSST.Location = New System.Drawing.Point(253, 3)
        Me.grpBCICMSST.Name = "grpBCICMSST"
        Me.grpBCICMSST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBCICMSST.Size = New System.Drawing.Size(634, 67)
        Me.grpBCICMSST.TabIndex = 1
        Me.grpBCICMSST.Text = "Base de Cálculo ICMS ST"
        Me.grpBCICMSST.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpBCICMSST.VisualStyleManager = Me.vsmMain
        '
        'lblFormulaST
        '
        Me.lblFormulaST.AutoSize = True
        Me.lblFormulaST.Location = New System.Drawing.Point(6, 20)
        Me.lblFormulaST.Name = "lblFormulaST"
        Me.lblFormulaST.Size = New System.Drawing.Size(48, 14)
        Me.lblFormulaST.TabIndex = 4
        Me.lblFormulaST.Text = "Formula:"
        '
        'txtFormulaST
        '
        Me.txtFormulaST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormulaST.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFormulaST.Location = New System.Drawing.Point(9, 37)
        Me.txtFormulaST.MaxLength = 250
        Me.txtFormulaST.Name = "txtFormulaST"
        Me.txtFormulaST.ReadOnly = True
        Me.txtFormulaST.Size = New System.Drawing.Size(616, 20)
        Me.txtFormulaST.TabIndex = 5
        Me.txtFormulaST.TabStop = False
        '
        'grpControleBCICMSST
        '
        Me.grpControleBCICMSST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControleBCICMSST.BackColor = System.Drawing.Color.Transparent
        Me.grpControleBCICMSST.Controls.Add(Me.btnIIST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnDescontoST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnIVAST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnPautaST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnValorST)
        Me.grpControleBCICMSST.Controls.Add(Me.txtValorST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnOutrasDespesasST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnSeguroST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnFreteST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnAliquotaICMSST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnProdutoST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnCST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnCEST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnFechaParentesesST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnAbreParentesesST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnDivideST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnMultiplicaST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnSubtraiST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnCOFINSST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnPISST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnIPIST)
        Me.grpControleBCICMSST.Controls.Add(Me.btnSomaST)
        Me.grpControleBCICMSST.Location = New System.Drawing.Point(8, 3)
        Me.grpControleBCICMSST.Name = "grpControleBCICMSST"
        Me.grpControleBCICMSST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleBCICMSST.Size = New System.Drawing.Size(236, 242)
        Me.grpControleBCICMSST.TabIndex = 0
        Me.grpControleBCICMSST.VisualStyleManager = Me.vsmMain
        '
        'btnIIST
        '
        Me.btnIIST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnIIST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnIIST.Location = New System.Drawing.Point(9, 147)
        Me.btnIIST.Name = "btnIIST"
        Me.btnIIST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnIIST.Size = New System.Drawing.Size(106, 20)
        Me.btnIIST.TabIndex = 9
        Me.btnIIST.TabStop = False
        Me.btnIIST.Tag = "|II|"
        Me.btnIIST.Text = "Valor do II"
        Me.btnIIST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDescontoST
        '
        Me.btnDescontoST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDescontoST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnDescontoST.Location = New System.Drawing.Point(121, 121)
        Me.btnDescontoST.Name = "btnDescontoST"
        Me.btnDescontoST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDescontoST.Size = New System.Drawing.Size(106, 20)
        Me.btnDescontoST.TabIndex = 8
        Me.btnDescontoST.TabStop = False
        Me.btnDescontoST.Tag = "|DESCONTO|"
        Me.btnDescontoST.Text = "Desconto"
        Me.btnDescontoST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnIVAST
        '
        Me.btnIVAST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnIVAST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnIVAST.Location = New System.Drawing.Point(121, 147)
        Me.btnIVAST.Name = "btnIVAST"
        Me.btnIVAST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnIVAST.Size = New System.Drawing.Size(106, 20)
        Me.btnIVAST.TabIndex = 10
        Me.btnIVAST.TabStop = False
        Me.btnIVAST.Tag = "|IVA|"
        Me.btnIVAST.Text = "IVA"
        Me.btnIVAST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPautaST
        '
        Me.btnPautaST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPautaST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPautaST.Location = New System.Drawing.Point(9, 173)
        Me.btnPautaST.Name = "btnPautaST"
        Me.btnPautaST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPautaST.Size = New System.Drawing.Size(106, 20)
        Me.btnPautaST.TabIndex = 11
        Me.btnPautaST.TabStop = False
        Me.btnPautaST.Tag = "|PAUTA|"
        Me.btnPautaST.Text = "Pauta (valor)"
        Me.btnPautaST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnValorST
        '
        Me.btnValorST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnValorST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnValorST.Location = New System.Drawing.Point(188, 173)
        Me.btnValorST.Name = "btnValorST"
        Me.btnValorST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnValorST.Size = New System.Drawing.Size(39, 20)
        Me.btnValorST.TabIndex = 13
        Me.btnValorST.TabStop = False
        Me.btnValorST.Tag = ""
        Me.btnValorST.Text = "Valor"
        Me.btnValorST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtValorST
        '
        Me.txtValorST.Location = New System.Drawing.Point(121, 173)
        Me.txtValorST.Name = "txtValorST"
        Me.txtValorST.Size = New System.Drawing.Size(68, 20)
        Me.txtValorST.TabIndex = 12
        Me.txtValorST.TabStop = False
        Me.txtValorST.Text = "0,00"
        Me.txtValorST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnOutrasDespesasST
        '
        Me.btnOutrasDespesasST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOutrasDespesasST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnOutrasDespesasST.Location = New System.Drawing.Point(121, 95)
        Me.btnOutrasDespesasST.Name = "btnOutrasDespesasST"
        Me.btnOutrasDespesasST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOutrasDespesasST.Size = New System.Drawing.Size(106, 20)
        Me.btnOutrasDespesasST.TabIndex = 6
        Me.btnOutrasDespesasST.TabStop = False
        Me.btnOutrasDespesasST.Tag = "|OUTRAS|"
        Me.btnOutrasDespesasST.Text = "Outras Despesas"
        Me.btnOutrasDespesasST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSeguroST
        '
        Me.btnSeguroST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSeguroST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnSeguroST.Location = New System.Drawing.Point(121, 69)
        Me.btnSeguroST.Name = "btnSeguroST"
        Me.btnSeguroST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSeguroST.Size = New System.Drawing.Size(106, 20)
        Me.btnSeguroST.TabIndex = 4
        Me.btnSeguroST.TabStop = False
        Me.btnSeguroST.Tag = "|SEGURO|"
        Me.btnSeguroST.Text = "Valor do Seguro"
        Me.btnSeguroST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnFreteST
        '
        Me.btnFreteST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFreteST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnFreteST.Location = New System.Drawing.Point(121, 43)
        Me.btnFreteST.Name = "btnFreteST"
        Me.btnFreteST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFreteST.Size = New System.Drawing.Size(106, 20)
        Me.btnFreteST.TabIndex = 2
        Me.btnFreteST.TabStop = False
        Me.btnFreteST.Tag = "|FRETE|"
        Me.btnFreteST.Text = "Valor do Frete"
        Me.btnFreteST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAliquotaICMSST
        '
        Me.btnAliquotaICMSST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAliquotaICMSST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAliquotaICMSST.Location = New System.Drawing.Point(9, 43)
        Me.btnAliquotaICMSST.Name = "btnAliquotaICMSST"
        Me.btnAliquotaICMSST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAliquotaICMSST.Size = New System.Drawing.Size(106, 20)
        Me.btnAliquotaICMSST.TabIndex = 1
        Me.btnAliquotaICMSST.TabStop = False
        Me.btnAliquotaICMSST.Tag = "|%ICMS|"
        Me.btnAliquotaICMSST.Text = "Alíquota ICMS"
        Me.btnAliquotaICMSST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProdutoST
        '
        Me.btnProdutoST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProdutoST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnProdutoST.Location = New System.Drawing.Point(9, 17)
        Me.btnProdutoST.Name = "btnProdutoST"
        Me.btnProdutoST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProdutoST.Size = New System.Drawing.Size(218, 20)
        Me.btnProdutoST.TabIndex = 0
        Me.btnProdutoST.TabStop = False
        Me.btnProdutoST.Tag = "|PRODUTO|"
        Me.btnProdutoST.Text = "Valor do Produto (Qtde. x Valor Unitário)"
        Me.btnProdutoST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCST
        '
        Me.btnCST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCST.Location = New System.Drawing.Point(205, 213)
        Me.btnCST.Name = "btnCST"
        Me.btnCST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCST.Size = New System.Drawing.Size(22, 20)
        Me.btnCST.TabIndex = 21
        Me.btnCST.TabStop = False
        Me.btnCST.Tag = ""
        Me.btnCST.Text = "C"
        Me.btnCST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCEST
        '
        Me.btnCEST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCEST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCEST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCEST.Location = New System.Drawing.Point(177, 213)
        Me.btnCEST.Name = "btnCEST"
        Me.btnCEST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCEST.Size = New System.Drawing.Size(22, 20)
        Me.btnCEST.TabIndex = 20
        Me.btnCEST.TabStop = False
        Me.btnCEST.Tag = ""
        Me.btnCEST.Text = "CE"
        Me.btnCEST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnFechaParentesesST
        '
        Me.btnFechaParentesesST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFechaParentesesST.Enabled = False
        Me.btnFechaParentesesST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechaParentesesST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFechaParentesesST.Location = New System.Drawing.Point(149, 213)
        Me.btnFechaParentesesST.Name = "btnFechaParentesesST"
        Me.btnFechaParentesesST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFechaParentesesST.Size = New System.Drawing.Size(22, 20)
        Me.btnFechaParentesesST.TabIndex = 19
        Me.btnFechaParentesesST.TabStop = False
        Me.btnFechaParentesesST.Tag = ")"
        Me.btnFechaParentesesST.Text = ")"
        Me.btnFechaParentesesST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAbreParentesesST
        '
        Me.btnAbreParentesesST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAbreParentesesST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreParentesesST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAbreParentesesST.Location = New System.Drawing.Point(121, 213)
        Me.btnAbreParentesesST.Name = "btnAbreParentesesST"
        Me.btnAbreParentesesST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAbreParentesesST.Size = New System.Drawing.Size(22, 20)
        Me.btnAbreParentesesST.TabIndex = 18
        Me.btnAbreParentesesST.TabStop = False
        Me.btnAbreParentesesST.Tag = "("
        Me.btnAbreParentesesST.Text = "("
        Me.btnAbreParentesesST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDivideST
        '
        Me.btnDivideST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDivideST.Enabled = False
        Me.btnDivideST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivideST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDivideST.Location = New System.Drawing.Point(93, 213)
        Me.btnDivideST.Name = "btnDivideST"
        Me.btnDivideST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDivideST.Size = New System.Drawing.Size(22, 20)
        Me.btnDivideST.TabIndex = 17
        Me.btnDivideST.TabStop = False
        Me.btnDivideST.Tag = "/"
        Me.btnDivideST.Text = "/"
        Me.btnDivideST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnMultiplicaST
        '
        Me.btnMultiplicaST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMultiplicaST.Enabled = False
        Me.btnMultiplicaST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicaST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnMultiplicaST.Location = New System.Drawing.Point(65, 213)
        Me.btnMultiplicaST.Name = "btnMultiplicaST"
        Me.btnMultiplicaST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnMultiplicaST.Size = New System.Drawing.Size(22, 20)
        Me.btnMultiplicaST.TabIndex = 16
        Me.btnMultiplicaST.TabStop = False
        Me.btnMultiplicaST.Tag = "*"
        Me.btnMultiplicaST.Text = "x"
        Me.btnMultiplicaST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSubtraiST
        '
        Me.btnSubtraiST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSubtraiST.Enabled = False
        Me.btnSubtraiST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtraiST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSubtraiST.Location = New System.Drawing.Point(37, 213)
        Me.btnSubtraiST.Name = "btnSubtraiST"
        Me.btnSubtraiST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSubtraiST.Size = New System.Drawing.Size(22, 20)
        Me.btnSubtraiST.TabIndex = 15
        Me.btnSubtraiST.TabStop = False
        Me.btnSubtraiST.Tag = "-"
        Me.btnSubtraiST.Text = "–"
        Me.btnSubtraiST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCOFINSST
        '
        Me.btnCOFINSST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCOFINSST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnCOFINSST.Location = New System.Drawing.Point(9, 121)
        Me.btnCOFINSST.Name = "btnCOFINSST"
        Me.btnCOFINSST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCOFINSST.Size = New System.Drawing.Size(106, 20)
        Me.btnCOFINSST.TabIndex = 7
        Me.btnCOFINSST.TabStop = False
        Me.btnCOFINSST.Tag = "|COFINS|"
        Me.btnCOFINSST.Text = "Valor do COFINS"
        Me.btnCOFINSST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPISST
        '
        Me.btnPISST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPISST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPISST.Location = New System.Drawing.Point(9, 95)
        Me.btnPISST.Name = "btnPISST"
        Me.btnPISST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPISST.Size = New System.Drawing.Size(106, 20)
        Me.btnPISST.TabIndex = 5
        Me.btnPISST.TabStop = False
        Me.btnPISST.Tag = "|PIS|"
        Me.btnPISST.Text = "Valor do PIS"
        Me.btnPISST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnIPIST
        '
        Me.btnIPIST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnIPIST.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnIPIST.Location = New System.Drawing.Point(9, 69)
        Me.btnIPIST.Name = "btnIPIST"
        Me.btnIPIST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnIPIST.Size = New System.Drawing.Size(106, 20)
        Me.btnIPIST.TabIndex = 3
        Me.btnIPIST.TabStop = False
        Me.btnIPIST.Tag = "|IPI|"
        Me.btnIPIST.Text = "Valor do IPI"
        Me.btnIPIST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSomaST
        '
        Me.btnSomaST.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSomaST.Enabled = False
        Me.btnSomaST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSomaST.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSomaST.Location = New System.Drawing.Point(9, 213)
        Me.btnSomaST.Name = "btnSomaST"
        Me.btnSomaST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSomaST.Size = New System.Drawing.Size(22, 20)
        Me.btnSomaST.TabIndex = 14
        Me.btnSomaST.TabStop = False
        Me.btnSomaST.Tag = "+"
        Me.btnSomaST.Text = "+"
        Me.btnSomaST.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Novo
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
        Me.grpDados.Controls.Add(Me.btnCadastrarCFOP)
        Me.grpDados.Controls.Add(Me.lblSituacaoTributariaICMS)
        Me.grpDados.Controls.Add(Me.cboSituacaoTributariaICMS)
        Me.grpDados.Controls.Add(Me.txtNaturezaOperacao)
        Me.grpDados.Controls.Add(Me.lblNaturezaOperacao)
        Me.grpDados.Controls.Add(Me.lblCFOP)
        Me.grpDados.Controls.Add(Me.cboCFOP)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarCFOP
        '
        Me.btnCadastrarCFOP.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCFOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCFOP.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarCFOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCFOP.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarCFOP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCFOP.Name = "btnCadastrarCFOP"
        Me.btnCadastrarCFOP.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCFOP.TabIndex = 0
        Me.btnCadastrarCFOP.TabStop = False
        Me.btnCadastrarCFOP.UseVisualStyleBackColor = True
        '
        'lblSituacaoTributariaICMS
        '
        Me.lblSituacaoTributariaICMS.AutoSize = True
        Me.lblSituacaoTributariaICMS.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaICMS.Location = New System.Drawing.Point(6, 57)
        Me.lblSituacaoTributariaICMS.Name = "lblSituacaoTributariaICMS"
        Me.lblSituacaoTributariaICMS.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaICMS.TabIndex = 5
        Me.lblSituacaoTributariaICMS.Text = "Situação Tributária:"
        '
        'cboSituacaoTributariaICMS
        '
        Me.cboSituacaoTributariaICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaICMS.AutoSize = False
        Me.cboSituacaoTributariaICMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboSituacaoTributariaICMS.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboSituacaoTributariaICMS.Location = New System.Drawing.Point(9, 74)
        Me.cboSituacaoTributariaICMS.Name = "cboSituacaoTributariaICMS"
        Me.cboSituacaoTributariaICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaICMS.Size = New System.Drawing.Size(879, 20)
        Me.cboSituacaoTributariaICMS.TabIndex = 6
        '
        'txtNaturezaOperacao
        '
        Me.txtNaturezaOperacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNaturezaOperacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNaturezaOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNaturezaOperacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaturezaOperacao.Location = New System.Drawing.Point(130, 34)
        Me.txtNaturezaOperacao.MaxLength = 350
        Me.txtNaturezaOperacao.Name = "txtNaturezaOperacao"
        Me.txtNaturezaOperacao.ReadOnly = True
        Me.txtNaturezaOperacao.Size = New System.Drawing.Size(758, 20)
        Me.txtNaturezaOperacao.TabIndex = 4
        Me.txtNaturezaOperacao.TabStop = False
        '
        'lblNaturezaOperacao
        '
        Me.lblNaturezaOperacao.AutoSize = True
        Me.lblNaturezaOperacao.Location = New System.Drawing.Point(127, 17)
        Me.lblNaturezaOperacao.Name = "lblNaturezaOperacao"
        Me.lblNaturezaOperacao.Size = New System.Drawing.Size(120, 14)
        Me.lblNaturezaOperacao.TabIndex = 3
        Me.lblNaturezaOperacao.Text = "Natureza da Operação:"
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.Location = New System.Drawing.Point(25, 17)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 1
        Me.lblCFOP.Text = "CFOP:"
        '
        'cboCFOP
        '
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = "SIM"
        UiComboBoxItem7.Value = True
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = "NÃO"
        UiComboBoxItem8.Value = False
        Me.cboCFOP.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboCFOP.Location = New System.Drawing.Point(9, 34)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(115, 20)
        Me.cboCFOP.TabIndex = 2
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 28
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'usrImpICMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrImpICMS"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabICMS.ResumeLayout(False)
        Me.pagICMS.ResumeLayout(False)
        CType(Me.grpBCICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBCICMS.ResumeLayout(False)
        Me.grpBCICMS.PerformLayout()
        CType(Me.grpControleBCICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleBCICMS.ResumeLayout(False)
        Me.grpControleBCICMS.PerformLayout()
        Me.pagICMSST.ResumeLayout(False)
        CType(Me.grpBCICMSST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBCICMSST.ResumeLayout(False)
        Me.grpBCICMSST.PerformLayout()
        CType(Me.grpControleBCICMSST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleBCICMSST.ResumeLayout(False)
        Me.grpControleBCICMSST.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCFOP As System.Windows.Forms.Label
    Friend WithEvents cboCFOP As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNaturezaOperacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNaturezaOperacao As System.Windows.Forms.Label
    Friend WithEvents tabICMS As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagICMS As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleBCICMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAliquotaICMS As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnC As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCE As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFechaParenteses As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAbreParenteses As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDivide As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnMultiplica As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSubtrai As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCOFINS As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPIS As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnIPI As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSoma As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagICMSST As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpBCICMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFormula As System.Windows.Forms.Label
    Friend WithEvents txtFormula As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnValor As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnOutrasDespesas As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSeguro As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFrete As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboSituacaoTributariaICMS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpBCICMSST As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFormulaST As System.Windows.Forms.Label
    Friend WithEvents txtFormulaST As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpControleBCICMSST As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnValorST As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValorST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnOutrasDespesasST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSeguroST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFreteST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAliquotaICMSST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProdutoST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCEST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFechaParentesesST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAbreParentesesST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDivideST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnMultiplicaST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSubtraiST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCOFINSST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPISST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnIPIST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSomaST As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblSituacaoTributariaICMSFiltro As System.Windows.Forms.Label
    Friend WithEvents cboSituacaoTributariaICMSFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNaturezaOperacaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNaturezaOperacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCFOPFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCFOPFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaICMS As System.Windows.Forms.Label
    Friend WithEvents btnIVAST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPautaST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDesconto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDescontoST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnII As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnIIST As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCFOP As System.Windows.Forms.Button
    Friend WithEvents btnRedICMS As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAliquotaII As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button

End Class
