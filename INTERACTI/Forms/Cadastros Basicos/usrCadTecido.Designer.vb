<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadTecido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadTecido))
        Dim grdMaterial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMaterial_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCodigoFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGridMaterial = New System.Windows.Forms.Button()
        Me.grdMaterial = New Janus.Windows.GridEX.GridEX()
        Me.grpMaterial = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPercentual = New System.Windows.Forms.Label()
        Me.txtPercentual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCadastrarMaterial = New System.Windows.Forms.Button()
        Me.cboMaterial = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.btnExcluirMaterial = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirMaterial = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblGramaM2 = New System.Windows.Forms.Label()
        Me.txtGramaM2 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTempoDescanso = New System.Windows.Forms.Label()
        Me.txtTempoDescanso = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnExcelGridMaterial = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grdMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaterial.SuspendLayout()
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
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Tecido"
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
        Me.grdListagem.CellToolTipText = "Duplo clique para editar o registro"
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
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 314)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblCodigoFiltro
        '
        Me.lblCodigoFiltro.AutoSize = True
        Me.lblCodigoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoFiltro.Name = "lblCodigoFiltro"
        Me.lblCodigoFiltro.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoFiltro.TabIndex = 0
        Me.lblCodigoFiltro.Text = "Código:"
        '
        'txtCodigoFiltro
        '
        Me.txtCodigoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigoFiltro.MaxLength = 20
        Me.txtCodigoFiltro.Name = "txtCodigoFiltro"
        Me.txtCodigoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoFiltro.TabIndex = 1
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(115, 34)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(636, 20)
        Me.txtDescricaoFiltro.TabIndex = 3
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(112, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 2
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 4
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
        Me.grpControl.Location = New System.Drawing.Point(8, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
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
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridMaterial)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridMaterial)
        Me.pagDados.Controls.Add(Me.grdMaterial)
        Me.pagDados.Controls.Add(Me.grpMaterial)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Tecido"
        '
        'btnConfigurarGridMaterial
        '
        Me.btnConfigurarGridMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridMaterial.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridMaterial.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridMaterial.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridMaterial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridMaterial.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGridMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridMaterial.Name = "btnConfigurarGridMaterial"
        Me.btnConfigurarGridMaterial.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridMaterial.TabIndex = 3
        Me.btnConfigurarGridMaterial.TabStop = False
        Me.btnConfigurarGridMaterial.UseVisualStyleBackColor = False
        '
        'grdMaterial
        '
        Me.grdMaterial.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMaterial.AlternatingColors = True
        Me.grdMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMaterial.ColumnAutoResize = True
        grdMaterial_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdMaterial_DesignTimeLayout_Reference_0.Instance"), Object)
        grdMaterial_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdMaterial_DesignTimeLayout_Reference_0})
        grdMaterial_DesignTimeLayout.LayoutString = resources.GetString("grdMaterial_DesignTimeLayout.LayoutString")
        Me.grdMaterial.DesignTimeLayout = grdMaterial_DesignTimeLayout
        Me.grdMaterial.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMaterial.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMaterial.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMaterial.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMaterial.FrozenColumns = 3
        Me.grdMaterial.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMaterial.GroupByBoxVisible = False
        Me.grdMaterial.Location = New System.Drawing.Point(8, 143)
        Me.grdMaterial.Name = "grdMaterial"
        Me.grdMaterial.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMaterial.RecordNavigator = True
        Me.grdMaterial.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdMaterial.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMaterial.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMaterial.Size = New System.Drawing.Size(897, 247)
        Me.grdMaterial.TabIndex = 2
        Me.grdMaterial.TabStop = False
        Me.grdMaterial.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMaterial.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMaterial.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMaterial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMaterial.VisualStyleManager = Me.vsmMain
        '
        'grpMaterial
        '
        Me.grpMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMaterial.BackColor = System.Drawing.Color.Transparent
        Me.grpMaterial.Controls.Add(Me.lblPercentual)
        Me.grpMaterial.Controls.Add(Me.txtPercentual)
        Me.grpMaterial.Controls.Add(Me.btnCadastrarMaterial)
        Me.grpMaterial.Controls.Add(Me.cboMaterial)
        Me.grpMaterial.Controls.Add(Me.lblMaterial)
        Me.grpMaterial.Controls.Add(Me.btnExcluirMaterial)
        Me.grpMaterial.Controls.Add(Me.btnInserirMaterial)
        Me.grpMaterial.Location = New System.Drawing.Point(8, 70)
        Me.grpMaterial.Name = "grpMaterial"
        Me.grpMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMaterial.Size = New System.Drawing.Size(897, 64)
        Me.grpMaterial.TabIndex = 1
        Me.grpMaterial.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpMaterial.VisualStyleManager = Me.vsmMain
        '
        'lblPercentual
        '
        Me.lblPercentual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPercentual.AutoSize = True
        Me.lblPercentual.Location = New System.Drawing.Point(382, 17)
        Me.lblPercentual.Name = "lblPercentual"
        Me.lblPercentual.Size = New System.Drawing.Size(61, 14)
        Me.lblPercentual.TabIndex = 3
        Me.lblPercentual.Text = "Percentual:"
        '
        'txtPercentual
        '
        Me.txtPercentual.DecimalDigits = 2
        Me.txtPercentual.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPercentual.Location = New System.Drawing.Point(385, 34)
        Me.txtPercentual.Name = "txtPercentual"
        Me.txtPercentual.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentual.TabIndex = 4
        Me.txtPercentual.Text = "0,00%"
        Me.txtPercentual.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnCadastrarMaterial
        '
        Me.btnCadastrarMaterial.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMaterial.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarMaterial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMaterial.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMaterial.Name = "btnCadastrarMaterial"
        Me.btnCadastrarMaterial.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMaterial.TabIndex = 0
        Me.btnCadastrarMaterial.TabStop = False
        Me.btnCadastrarMaterial.UseVisualStyleBackColor = True
        '
        'cboMaterial
        '
        Me.cboMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMaterial.AutoSize = False
        Me.cboMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboMaterial.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboMaterial.Location = New System.Drawing.Point(9, 34)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaterial.Size = New System.Drawing.Size(370, 20)
        Me.cboMaterial.TabIndex = 2
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Location = New System.Drawing.Point(25, 17)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(59, 14)
        Me.lblMaterial.TabIndex = 1
        Me.lblMaterial.Text = "Descrição:"
        '
        'btnExcluirMaterial
        '
        Me.btnExcluirMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirMaterial.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirMaterial.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirMaterial.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirMaterial.Location = New System.Drawing.Point(797, 31)
        Me.btnExcluirMaterial.Name = "btnExcluirMaterial"
        Me.btnExcluirMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirMaterial.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirMaterial.TabIndex = 6
        Me.btnExcluirMaterial.Text = "Excluir"
        Me.btnExcluirMaterial.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirMaterial
        '
        Me.btnInserirMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirMaterial.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirMaterial.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirMaterial.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirMaterial.Location = New System.Drawing.Point(700, 31)
        Me.btnInserirMaterial.Name = "btnInserirMaterial"
        Me.btnInserirMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirMaterial.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirMaterial.TabIndex = 5
        Me.btnInserirMaterial.Text = "Inserir"
        Me.btnInserirMaterial.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.grpControl2.TabIndex = 4
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
        Me.grpDados.Controls.Add(Me.lblGramaM2)
        Me.grpDados.Controls.Add(Me.txtGramaM2)
        Me.grpDados.Controls.Add(Me.lblTempoDescanso)
        Me.grpDados.Controls.Add(Me.txtTempoDescanso)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblGramaM2
        '
        Me.lblGramaM2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGramaM2.AutoSize = True
        Me.lblGramaM2.Location = New System.Drawing.Point(689, 17)
        Me.lblGramaM2.Name = "lblGramaM2"
        Me.lblGramaM2.Size = New System.Drawing.Size(63, 14)
        Me.lblGramaM2.TabIndex = 6
        Me.lblGramaM2.Text = "Grama / m²:"
        '
        'txtGramaM2
        '
        Me.txtGramaM2.DecimalDigits = 2
        Me.txtGramaM2.Location = New System.Drawing.Point(692, 34)
        Me.txtGramaM2.Name = "txtGramaM2"
        Me.txtGramaM2.Size = New System.Drawing.Size(100, 20)
        Me.txtGramaM2.TabIndex = 7
        Me.txtGramaM2.Text = "0,00"
        Me.txtGramaM2.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTempoDescanso
        '
        Me.lblTempoDescanso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTempoDescanso.AutoSize = True
        Me.lblTempoDescanso.Location = New System.Drawing.Point(583, 17)
        Me.lblTempoDescanso.Name = "lblTempoDescanso"
        Me.lblTempoDescanso.Size = New System.Drawing.Size(99, 14)
        Me.lblTempoDescanso.TabIndex = 4
        Me.lblTempoDescanso.Text = "Descanso (Horas):"
        '
        'txtTempoDescanso
        '
        Me.txtTempoDescanso.DecimalDigits = 0
        Me.txtTempoDescanso.Location = New System.Drawing.Point(586, 34)
        Me.txtTempoDescanso.Name = "txtTempoDescanso"
        Me.txtTempoDescanso.Size = New System.Drawing.Size(100, 20)
        Me.txtTempoDescanso.TabIndex = 5
        Me.txtTempoDescanso.Text = "0"
        Me.txtTempoDescanso.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        SuperTipSettings1.HeaderText = "Código IBGE"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "O Código IBGE é informado na emissão da Nota Fiscal Eletrônica." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Favor se atent" & _
    "ar ao Código IBGE correspondente ao País."
        Me.jstTip.SetSuperTip(Me.lblCodigo, SuperTipSettings1)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        SuperTipSettings2.HeaderText = "Código IBGE"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "O Código IBGE é informado na emissão da Nota Fiscal Eletrônica." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Favor se atent" & _
    "ar ao Código IBGE correspondente ao País."
        Me.jstTip.SetSuperTip(Me.txtCodigo, SuperTipSettings2)
        Me.txtCodigo.TabIndex = 1
        '
        'lblAtivo
        '
        Me.lblAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(795, 17)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 8
        Me.lblAtivo.Text = "Ativo:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(115, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(465, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'cboAtivo
        '
        Me.cboAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboAtivo.Location = New System.Drawing.Point(798, 34)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(90, 20)
        Me.cboAtivo.TabIndex = 9
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(112, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(33, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 78
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnExcelGridMaterial
        '
        Me.btnExcelGridMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridMaterial.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridMaterial.FlatAppearance.BorderSize = 0
        Me.btnExcelGridMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridMaterial.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridMaterial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridMaterial.Location = New System.Drawing.Point(33, 373)
        Me.btnExcelGridMaterial.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridMaterial.Name = "btnExcelGridMaterial"
        Me.btnExcelGridMaterial.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridMaterial.TabIndex = 78
        Me.btnExcelGridMaterial.TabStop = False
        Me.btnExcelGridMaterial.UseVisualStyleBackColor = False
        '
        'usrCadTecido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadTecido"
        Me.Size = New System.Drawing.Size(915, 476)
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
        CType(Me.grdMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaterial.ResumeLayout(False)
        Me.grpMaterial.PerformLayout()
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
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblTempoDescanso As System.Windows.Forms.Label
    Friend WithEvents txtTempoDescanso As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblGramaM2 As System.Windows.Forms.Label
    Friend WithEvents txtGramaM2 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnConfigurarGridMaterial As System.Windows.Forms.Button
    Friend WithEvents grdMaterial As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpMaterial As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboMaterial As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaterial As System.Windows.Forms.Label
    Friend WithEvents btnExcluirMaterial As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirMaterial As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPercentual As System.Windows.Forms.Label
    Friend WithEvents txtPercentual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarMaterial As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridMaterial As System.Windows.Forms.Button

End Class
