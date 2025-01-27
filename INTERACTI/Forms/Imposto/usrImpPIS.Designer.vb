<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrImpPIS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrImpPIS))
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
        Me.lblSituacaoTributariaPISFiltro = New System.Windows.Forms.Label()
        Me.cboSituacaoTributariaPISFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNaturezaOperacaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNaturezaOperacaoFiltro = New System.Windows.Forms.Label()
        Me.lblCFOPFiltro = New System.Windows.Forms.Label()
        Me.cboCFOPFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabPIS = New Janus.Windows.UI.Tab.UITab()
        Me.pagICMS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpBCPIS = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.txtFormula = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControleBCICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnIPI = New Janus.Windows.EditControls.UIButton()
        Me.btnAliquotaPIS = New Janus.Windows.EditControls.UIButton()
        Me.btnII = New Janus.Windows.EditControls.UIButton()
        Me.btnRedICMS = New Janus.Windows.EditControls.UIButton()
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
        Me.btnAliquotaCOFINS = New Janus.Windows.EditControls.UIButton()
        Me.btnAliquotaII = New Janus.Windows.EditControls.UIButton()
        Me.btnAliquotaIPI = New Janus.Windows.EditControls.UIButton()
        Me.btnSoma = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarCFOP = New System.Windows.Forms.Button()
        Me.lblSituacaoTributariaPIS = New System.Windows.Forms.Label()
        Me.cboSituacaoTributariaPIS = New Janus.Windows.EditControls.UIComboBox()
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
        CType(Me.tabPIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPIS.SuspendLayout()
        Me.pagICMS.SuspendLayout()
        CType(Me.grpBCPIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBCPIS.SuspendLayout()
        CType(Me.grpControleBCICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleBCICMS.SuspendLayout()
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
        Me.pagListagem.Text = "Fórmula da Base de Cálculo do PIS"
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
        Me.btnAgruparGrid.TabIndex = 18
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
        Me.btnConfigurarGrid.TabIndex = 13
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
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
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
        Me.grpControl.TabIndex = 2
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
        Me.grpFiltro.Controls.Add(Me.lblSituacaoTributariaPISFiltro)
        Me.grpFiltro.Controls.Add(Me.cboSituacaoTributariaPISFiltro)
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
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblSituacaoTributariaPISFiltro
        '
        Me.lblSituacaoTributariaPISFiltro.AutoSize = True
        Me.lblSituacaoTributariaPISFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblSituacaoTributariaPISFiltro.Name = "lblSituacaoTributariaPISFiltro"
        Me.lblSituacaoTributariaPISFiltro.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaPISFiltro.TabIndex = 4
        Me.lblSituacaoTributariaPISFiltro.Text = "Situação Tributária:"
        '
        'cboSituacaoTributariaPISFiltro
        '
        Me.cboSituacaoTributariaPISFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaPISFiltro.AutoSize = False
        Me.cboSituacaoTributariaPISFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboSituacaoTributariaPISFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboSituacaoTributariaPISFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboSituacaoTributariaPISFiltro.Name = "cboSituacaoTributariaPISFiltro"
        Me.cboSituacaoTributariaPISFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaPISFiltro.Size = New System.Drawing.Size(745, 20)
        Me.cboSituacaoTributariaPISFiltro.TabIndex = 5
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
        Me.pagDados.Controls.Add(Me.tabPIS)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Fórmula da Base de Cálculo do PIS"
        '
        'tabPIS
        '
        Me.tabPIS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabPIS.BackColor = System.Drawing.Color.Transparent
        Me.tabPIS.FocusOnClick = False
        Me.tabPIS.Location = New System.Drawing.Point(8, 113)
        Me.tabPIS.Name = "tabPIS"
        Me.tabPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabPIS.ShowFocusRectangle = False
        Me.tabPIS.Size = New System.Drawing.Size(897, 277)
        Me.tabPIS.TabIndex = 1
        Me.tabPIS.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagICMS})
        Me.tabPIS.TabStop = False
        Me.tabPIS.VisualStyleManager = Me.vsmMain
        '
        'pagICMS
        '
        Me.pagICMS.Controls.Add(Me.grpBCPIS)
        Me.pagICMS.Controls.Add(Me.grpControleBCICMS)
        Me.pagICMS.Key = "pagICMS"
        Me.pagICMS.Location = New System.Drawing.Point(1, 22)
        Me.pagICMS.Name = "pagICMS"
        Me.pagICMS.Size = New System.Drawing.Size(895, 254)
        Me.pagICMS.TabStop = True
        Me.pagICMS.Text = "PIS"
        '
        'grpBCPIS
        '
        Me.grpBCPIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBCPIS.BackColor = System.Drawing.Color.Transparent
        Me.grpBCPIS.Controls.Add(Me.lblFormula)
        Me.grpBCPIS.Controls.Add(Me.txtFormula)
        Me.grpBCPIS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpBCPIS.Location = New System.Drawing.Point(253, 3)
        Me.grpBCPIS.Name = "grpBCPIS"
        Me.grpBCPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBCPIS.Size = New System.Drawing.Size(634, 67)
        Me.grpBCPIS.TabIndex = 1
        Me.grpBCPIS.Text = "Base de Cálculo PIS"
        Me.grpBCPIS.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpBCPIS.VisualStyleManager = Me.vsmMain
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
        Me.grpControleBCICMS.Controls.Add(Me.btnIPI)
        Me.grpControleBCICMS.Controls.Add(Me.btnAliquotaPIS)
        Me.grpControleBCICMS.Controls.Add(Me.btnII)
        Me.grpControleBCICMS.Controls.Add(Me.btnRedICMS)
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
        Me.grpControleBCICMS.Controls.Add(Me.btnAliquotaCOFINS)
        Me.grpControleBCICMS.Controls.Add(Me.btnAliquotaII)
        Me.grpControleBCICMS.Controls.Add(Me.btnAliquotaIPI)
        Me.grpControleBCICMS.Controls.Add(Me.btnSoma)
        Me.grpControleBCICMS.Location = New System.Drawing.Point(8, 3)
        Me.grpControleBCICMS.Name = "grpControleBCICMS"
        Me.grpControleBCICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleBCICMS.Size = New System.Drawing.Size(236, 242)
        Me.grpControleBCICMS.TabIndex = 0
        Me.grpControleBCICMS.VisualStyleManager = Me.vsmMain
        '
        'btnIPI
        '
        Me.btnIPI.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnIPI.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnIPI.Location = New System.Drawing.Point(9, 173)
        Me.btnIPI.Name = "btnIPI"
        Me.btnIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnIPI.Size = New System.Drawing.Size(106, 20)
        Me.btnIPI.TabIndex = 12
        Me.btnIPI.TabStop = False
        Me.btnIPI.Tag = "|IPI|"
        Me.btnIPI.Text = "Valor do IPI"
        Me.btnIPI.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAliquotaPIS
        '
        Me.btnAliquotaPIS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAliquotaPIS.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAliquotaPIS.Location = New System.Drawing.Point(121, 95)
        Me.btnAliquotaPIS.Name = "btnAliquotaPIS"
        Me.btnAliquotaPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAliquotaPIS.Size = New System.Drawing.Size(106, 20)
        Me.btnAliquotaPIS.TabIndex = 7
        Me.btnAliquotaPIS.TabStop = False
        Me.btnAliquotaPIS.Tag = "|%PIS|"
        Me.btnAliquotaPIS.Text = "Alíquota PIS"
        Me.btnAliquotaPIS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnII
        '
        Me.btnII.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnII.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnII.Location = New System.Drawing.Point(121, 147)
        Me.btnII.Name = "btnII"
        Me.btnII.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnII.Size = New System.Drawing.Size(106, 20)
        Me.btnII.TabIndex = 11
        Me.btnII.TabStop = False
        Me.btnII.Tag = "|II|"
        Me.btnII.Text = "Valor do II"
        Me.btnII.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnRedICMS
        '
        Me.btnRedICMS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRedICMS.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnRedICMS.Location = New System.Drawing.Point(9, 147)
        Me.btnRedICMS.Name = "btnRedICMS"
        Me.btnRedICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRedICMS.Size = New System.Drawing.Size(106, 20)
        Me.btnRedICMS.TabIndex = 10
        Me.btnRedICMS.TabStop = False
        Me.btnRedICMS.Tag = "|%RED_ICMS|"
        Me.btnRedICMS.Text = "% Red ICMS"
        Me.btnRedICMS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDesconto
        '
        Me.btnDesconto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDesconto.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnDesconto.Location = New System.Drawing.Point(121, 121)
        Me.btnDesconto.Name = "btnDesconto"
        Me.btnDesconto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDesconto.Size = New System.Drawing.Size(106, 20)
        Me.btnDesconto.TabIndex = 9
        Me.btnDesconto.TabStop = False
        Me.btnDesconto.Tag = "|DESCONTO|"
        Me.btnDesconto.Text = "Desconto"
        Me.btnDesconto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnValor
        '
        Me.btnValor.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnValor.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnValor.Location = New System.Drawing.Point(188, 173)
        Me.btnValor.Name = "btnValor"
        Me.btnValor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnValor.Size = New System.Drawing.Size(39, 20)
        Me.btnValor.TabIndex = 14
        Me.btnValor.TabStop = False
        Me.btnValor.Tag = ""
        Me.btnValor.Text = "Valor"
        Me.btnValor.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(121, 173)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(68, 20)
        Me.txtValor.TabIndex = 13
        Me.txtValor.TabStop = False
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnOutrasDespesas
        '
        Me.btnOutrasDespesas.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOutrasDespesas.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnOutrasDespesas.Location = New System.Drawing.Point(121, 69)
        Me.btnOutrasDespesas.Name = "btnOutrasDespesas"
        Me.btnOutrasDespesas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOutrasDespesas.Size = New System.Drawing.Size(106, 20)
        Me.btnOutrasDespesas.TabIndex = 5
        Me.btnOutrasDespesas.TabStop = False
        Me.btnOutrasDespesas.Tag = "|OUTRAS|"
        Me.btnOutrasDespesas.Text = "Outras Despesas"
        Me.btnOutrasDespesas.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSeguro
        '
        Me.btnSeguro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSeguro.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnSeguro.Location = New System.Drawing.Point(121, 43)
        Me.btnSeguro.Name = "btnSeguro"
        Me.btnSeguro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSeguro.Size = New System.Drawing.Size(106, 20)
        Me.btnSeguro.TabIndex = 3
        Me.btnSeguro.TabStop = False
        Me.btnSeguro.Tag = "|SEGURO|"
        Me.btnSeguro.Text = "Valor do Seguro"
        Me.btnSeguro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnFrete
        '
        Me.btnFrete.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFrete.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnFrete.Location = New System.Drawing.Point(121, 17)
        Me.btnFrete.Name = "btnFrete"
        Me.btnFrete.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFrete.Size = New System.Drawing.Size(106, 20)
        Me.btnFrete.TabIndex = 1
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
        Me.btnAliquotaICMS.TabIndex = 2
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
        Me.btnProduto.Size = New System.Drawing.Size(106, 20)
        Me.btnProduto.TabIndex = 0
        Me.btnProduto.TabStop = False
        Me.btnProduto.Tag = "|PRODUTO|"
        Me.btnProduto.Text = "Valor do Produto"
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
        Me.btnC.TabIndex = 22
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
        Me.btnCE.TabIndex = 21
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
        Me.btnFechaParenteses.TabIndex = 20
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
        Me.btnAbreParenteses.TabIndex = 19
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
        Me.btnDivide.TabIndex = 18
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
        Me.btnMultiplica.TabIndex = 17
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
        Me.btnSubtrai.TabIndex = 16
        Me.btnSubtrai.TabStop = False
        Me.btnSubtrai.Tag = "-"
        Me.btnSubtrai.Text = "–"
        Me.btnSubtrai.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAliquotaCOFINS
        '
        Me.btnAliquotaCOFINS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAliquotaCOFINS.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAliquotaCOFINS.Location = New System.Drawing.Point(9, 121)
        Me.btnAliquotaCOFINS.Name = "btnAliquotaCOFINS"
        Me.btnAliquotaCOFINS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAliquotaCOFINS.Size = New System.Drawing.Size(106, 20)
        Me.btnAliquotaCOFINS.TabIndex = 8
        Me.btnAliquotaCOFINS.TabStop = False
        Me.btnAliquotaCOFINS.Tag = "|%COFINS|"
        Me.btnAliquotaCOFINS.Text = "Alíquota COFINS"
        Me.btnAliquotaCOFINS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAliquotaII
        '
        Me.btnAliquotaII.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAliquotaII.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAliquotaII.Location = New System.Drawing.Point(9, 95)
        Me.btnAliquotaII.Name = "btnAliquotaII"
        Me.btnAliquotaII.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAliquotaII.Size = New System.Drawing.Size(106, 20)
        Me.btnAliquotaII.TabIndex = 6
        Me.btnAliquotaII.TabStop = False
        Me.btnAliquotaII.Tag = "|%II|"
        Me.btnAliquotaII.Text = "Alíquota II"
        Me.btnAliquotaII.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAliquotaIPI
        '
        Me.btnAliquotaIPI.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAliquotaIPI.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAliquotaIPI.Location = New System.Drawing.Point(9, 69)
        Me.btnAliquotaIPI.Name = "btnAliquotaIPI"
        Me.btnAliquotaIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAliquotaIPI.Size = New System.Drawing.Size(106, 20)
        Me.btnAliquotaIPI.TabIndex = 4
        Me.btnAliquotaIPI.TabStop = False
        Me.btnAliquotaIPI.Tag = "|%IPI|"
        Me.btnAliquotaIPI.Text = "Alíquota IPI"
        Me.btnAliquotaIPI.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnSoma.TabIndex = 15
        Me.btnSoma.TabStop = False
        Me.btnSoma.Tag = "+"
        Me.btnSoma.Text = "+"
        Me.btnSoma.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnNovo.TabIndex = 1
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
        Me.btnVoltar.TabIndex = 3
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
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnCadastrarCFOP)
        Me.grpDados.Controls.Add(Me.lblSituacaoTributariaPIS)
        Me.grpDados.Controls.Add(Me.cboSituacaoTributariaPIS)
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
        Me.btnCadastrarCFOP.TabIndex = 7
        Me.btnCadastrarCFOP.TabStop = False
        Me.btnCadastrarCFOP.UseVisualStyleBackColor = True
        '
        'lblSituacaoTributariaPIS
        '
        Me.lblSituacaoTributariaPIS.AutoSize = True
        Me.lblSituacaoTributariaPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaPIS.Location = New System.Drawing.Point(6, 57)
        Me.lblSituacaoTributariaPIS.Name = "lblSituacaoTributariaPIS"
        Me.lblSituacaoTributariaPIS.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaPIS.TabIndex = 4
        Me.lblSituacaoTributariaPIS.Text = "Situação Tributária:"
        '
        'cboSituacaoTributariaPIS
        '
        Me.cboSituacaoTributariaPIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaPIS.AutoSize = False
        Me.cboSituacaoTributariaPIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboSituacaoTributariaPIS.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboSituacaoTributariaPIS.Location = New System.Drawing.Point(9, 74)
        Me.cboSituacaoTributariaPIS.Name = "cboSituacaoTributariaPIS"
        Me.cboSituacaoTributariaPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaPIS.Size = New System.Drawing.Size(879, 20)
        Me.cboSituacaoTributariaPIS.TabIndex = 5
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
        Me.txtNaturezaOperacao.TabIndex = 3
        Me.txtNaturezaOperacao.TabStop = False
        '
        'lblNaturezaOperacao
        '
        Me.lblNaturezaOperacao.AutoSize = True
        Me.lblNaturezaOperacao.Location = New System.Drawing.Point(127, 17)
        Me.lblNaturezaOperacao.Name = "lblNaturezaOperacao"
        Me.lblNaturezaOperacao.Size = New System.Drawing.Size(120, 14)
        Me.lblNaturezaOperacao.TabIndex = 2
        Me.lblNaturezaOperacao.Text = "Natureza da Operação:"
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.Location = New System.Drawing.Point(25, 17)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 0
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
        Me.cboCFOP.TabIndex = 1
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
        'usrImpPIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrImpPIS"
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
        CType(Me.tabPIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPIS.ResumeLayout(False)
        Me.pagICMS.ResumeLayout(False)
        CType(Me.grpBCPIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBCPIS.ResumeLayout(False)
        Me.grpBCPIS.PerformLayout()
        CType(Me.grpControleBCICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleBCICMS.ResumeLayout(False)
        Me.grpControleBCICMS.PerformLayout()
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
    Friend WithEvents tabPIS As Janus.Windows.UI.Tab.UITab
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
    Friend WithEvents btnAliquotaCOFINS As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAliquotaIPI As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSoma As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpBCPIS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFormula As System.Windows.Forms.Label
    Friend WithEvents txtFormula As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnOutrasDespesas As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSeguro As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFrete As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboSituacaoTributariaPIS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblSituacaoTributariaPISFiltro As System.Windows.Forms.Label
    Friend WithEvents cboSituacaoTributariaPISFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNaturezaOperacaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNaturezaOperacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCFOPFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCFOPFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaPIS As System.Windows.Forms.Label
    Friend WithEvents btnDesconto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnValor As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnAliquotaII As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCFOP As System.Windows.Forms.Button
    Friend WithEvents btnIPI As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAliquotaPIS As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnII As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnRedICMS As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button

End Class
