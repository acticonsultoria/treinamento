<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdPlanejamentoLegado
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
        Dim grdAnalitico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdAnalitico_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdPlanejamentoLegado))
        Dim grdProcesso_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProcesso_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdMaquinaAtual_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMaquinaAtual_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdFuncionarioAtual_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdFuncionarioAtual_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagAnalitico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdAnalitico = New Janus.Windows.GridEX.GridEX()
        Me.pagProcesso = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdProcesso = New Janus.Windows.GridEX.GridEX()
        Me.pagAgrupado = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagMaquinaAtual = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdMaquinaAtual = New Janus.Windows.GridEX.GridEX()
        Me.pagFuncionarioAtual = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdFuncionarioAtual = New Janus.Windows.GridEX.GridEX()
        Me.pagApontamentos = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpApontamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.dtpDataTerminoApontamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioApontamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblPeriodoApontamento = New System.Windows.Forms.Label()
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.dtpDataNecessidadeTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataNecessidadeInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataNecessidadeFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.pagSintetico = New Janus.Windows.UI.Tab.UITabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagAnalitico.SuspendLayout()
        CType(Me.grdAnalitico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagProcesso.SuspendLayout()
        CType(Me.grdProcesso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagAgrupado.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagMaquinaAtual.SuspendLayout()
        CType(Me.grdMaquinaAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagFuncionarioAtual.SuspendLayout()
        CType(Me.grdFuncionarioAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagApontamentos.SuspendLayout()
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpApontamento.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(966, 459)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grpControl2)
        Me.pagListagem.Controls.Add(Me.tabDados)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 24)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(964, 434)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Planejamento de Produção"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(9, 376)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(948, 51)
        Me.grpControl2.TabIndex = 11
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(851, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 11
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(8, 78)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(948, 292)
        Me.tabDados.TabIndex = 10
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagAnalitico, Me.pagProcesso, Me.pagAgrupado, Me.pagMaquinaAtual, Me.pagFuncionarioAtual, Me.pagApontamentos})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagAnalitico
        '
        Me.pagAnalitico.Controls.Add(Me.grdAnalitico)
        Me.pagAnalitico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagAnalitico.Key = "pagListagem"
        Me.pagAnalitico.Location = New System.Drawing.Point(1, 24)
        Me.pagAnalitico.Name = "pagAnalitico"
        Me.pagAnalitico.Size = New System.Drawing.Size(946, 267)
        Me.pagAnalitico.TabStop = True
        Me.pagAnalitico.Text = "Analítico"
        '
        'grdAnalitico
        '
        Me.grdAnalitico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdAnalitico.AlternatingColors = True
        Me.grdAnalitico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdAnalitico_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdAnalitico_DesignTimeLayout_Reference_0.Instance"), Object)
        grdAnalitico_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdAnalitico_DesignTimeLayout_Reference_0})
        grdAnalitico_DesignTimeLayout.LayoutString = resources.GetString("grdAnalitico_DesignTimeLayout.LayoutString")
        Me.grdAnalitico.DesignTimeLayout = grdAnalitico_DesignTimeLayout
        Me.grdAnalitico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdAnalitico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdAnalitico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdAnalitico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdAnalitico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdAnalitico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdAnalitico.GroupByBoxVisible = False
        Me.grdAnalitico.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdAnalitico.Location = New System.Drawing.Point(8, 11)
        Me.grdAnalitico.Name = "grdAnalitico"
        Me.grdAnalitico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdAnalitico.RecordNavigator = True
        Me.grdAnalitico.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdAnalitico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdAnalitico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdAnalitico.Size = New System.Drawing.Size(930, 249)
        Me.grdAnalitico.TabIndex = 4
        Me.grdAnalitico.TabStop = False
        Me.grdAnalitico.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdAnalitico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdAnalitico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdAnalitico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdAnalitico.VisualStyleManager = Me.vsmMain
        '
        'pagProcesso
        '
        Me.pagProcesso.Controls.Add(Me.grdProcesso)
        Me.pagProcesso.Location = New System.Drawing.Point(1, 24)
        Me.pagProcesso.Name = "pagProcesso"
        Me.pagProcesso.Size = New System.Drawing.Size(946, 267)
        Me.pagProcesso.TabStop = True
        Me.pagProcesso.Text = "Processo"
        '
        'grdProcesso
        '
        Me.grdProcesso.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProcesso.AlternatingColors = True
        Me.grdProcesso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdProcesso_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProcesso_DesignTimeLayout_Reference_0.Instance"), Object)
        grdProcesso_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProcesso_DesignTimeLayout_Reference_0})
        grdProcesso_DesignTimeLayout.LayoutString = resources.GetString("grdProcesso_DesignTimeLayout.LayoutString")
        Me.grdProcesso.DesignTimeLayout = grdProcesso_DesignTimeLayout
        Me.grdProcesso.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProcesso.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProcesso.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProcesso.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProcesso.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProcesso.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProcesso.GroupByBoxVisible = False
        Me.grdProcesso.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdProcesso.Location = New System.Drawing.Point(8, 9)
        Me.grdProcesso.Name = "grdProcesso"
        Me.grdProcesso.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProcesso.RecordNavigator = True
        Me.grdProcesso.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdProcesso.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProcesso.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProcesso.Size = New System.Drawing.Size(930, 249)
        Me.grdProcesso.TabIndex = 5
        Me.grdProcesso.TabStop = False
        Me.grdProcesso.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProcesso.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProcesso.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProcesso.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProcesso.VisualStyleManager = Me.vsmMain
        '
        'pagAgrupado
        '
        Me.pagAgrupado.Controls.Add(Me.grdListagem)
        Me.pagAgrupado.Location = New System.Drawing.Point(1, 24)
        Me.pagAgrupado.Name = "pagAgrupado"
        Me.pagAgrupado.Size = New System.Drawing.Size(946, 267)
        Me.pagAgrupado.TabStop = True
        Me.pagAgrupado.Text = "Agrupado"
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
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 7)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(930, 253)
        Me.grdListagem.TabIndex = 3
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
        'pagMaquinaAtual
        '
        Me.pagMaquinaAtual.Controls.Add(Me.grdMaquinaAtual)
        Me.pagMaquinaAtual.Location = New System.Drawing.Point(1, 22)
        Me.pagMaquinaAtual.Name = "pagMaquinaAtual"
        Me.pagMaquinaAtual.Size = New System.Drawing.Size(946, 271)
        Me.pagMaquinaAtual.TabStop = True
        Me.pagMaquinaAtual.Text = "Máquinas atual"
        '
        'grdMaquinaAtual
        '
        Me.grdMaquinaAtual.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMaquinaAtual.AlternatingColors = True
        Me.grdMaquinaAtual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdMaquinaAtual_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdMaquinaAtual_DesignTimeLayout_Reference_0.Instance"), Object)
        grdMaquinaAtual_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdMaquinaAtual_DesignTimeLayout_Reference_0})
        grdMaquinaAtual_DesignTimeLayout.LayoutString = resources.GetString("grdMaquinaAtual_DesignTimeLayout.LayoutString")
        Me.grdMaquinaAtual.DesignTimeLayout = grdMaquinaAtual_DesignTimeLayout
        Me.grdMaquinaAtual.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMaquinaAtual.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMaquinaAtual.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMaquinaAtual.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMaquinaAtual.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdMaquinaAtual.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMaquinaAtual.GroupByBoxVisible = False
        Me.grdMaquinaAtual.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdMaquinaAtual.Location = New System.Drawing.Point(8, 9)
        Me.grdMaquinaAtual.Name = "grdMaquinaAtual"
        Me.grdMaquinaAtual.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMaquinaAtual.RecordNavigator = True
        Me.grdMaquinaAtual.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdMaquinaAtual.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMaquinaAtual.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMaquinaAtual.Size = New System.Drawing.Size(930, 253)
        Me.grdMaquinaAtual.TabIndex = 7
        Me.grdMaquinaAtual.TabStop = False
        Me.grdMaquinaAtual.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMaquinaAtual.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMaquinaAtual.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMaquinaAtual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMaquinaAtual.VisualStyleManager = Me.vsmMain
        '
        'pagFuncionarioAtual
        '
        Me.pagFuncionarioAtual.Controls.Add(Me.grdFuncionarioAtual)
        Me.pagFuncionarioAtual.Location = New System.Drawing.Point(1, 22)
        Me.pagFuncionarioAtual.Name = "pagFuncionarioAtual"
        Me.pagFuncionarioAtual.Size = New System.Drawing.Size(946, 271)
        Me.pagFuncionarioAtual.TabStop = True
        Me.pagFuncionarioAtual.Text = "Funcionários atual"
        '
        'grdFuncionarioAtual
        '
        Me.grdFuncionarioAtual.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdFuncionarioAtual.AlternatingColors = True
        Me.grdFuncionarioAtual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdFuncionarioAtual_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdFuncionarioAtual_DesignTimeLayout_Reference_0.Instance"), Object)
        grdFuncionarioAtual_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdFuncionarioAtual_DesignTimeLayout_Reference_0})
        grdFuncionarioAtual_DesignTimeLayout.LayoutString = resources.GetString("grdFuncionarioAtual_DesignTimeLayout.LayoutString")
        Me.grdFuncionarioAtual.DesignTimeLayout = grdFuncionarioAtual_DesignTimeLayout
        Me.grdFuncionarioAtual.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdFuncionarioAtual.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdFuncionarioAtual.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdFuncionarioAtual.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdFuncionarioAtual.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdFuncionarioAtual.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdFuncionarioAtual.GroupByBoxVisible = False
        Me.grdFuncionarioAtual.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdFuncionarioAtual.Location = New System.Drawing.Point(8, 9)
        Me.grdFuncionarioAtual.Name = "grdFuncionarioAtual"
        Me.grdFuncionarioAtual.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdFuncionarioAtual.RecordNavigator = True
        Me.grdFuncionarioAtual.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdFuncionarioAtual.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdFuncionarioAtual.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdFuncionarioAtual.Size = New System.Drawing.Size(930, 253)
        Me.grdFuncionarioAtual.TabIndex = 6
        Me.grdFuncionarioAtual.TabStop = False
        Me.grdFuncionarioAtual.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdFuncionarioAtual.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdFuncionarioAtual.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdFuncionarioAtual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdFuncionarioAtual.VisualStyleManager = Me.vsmMain
        '
        'pagApontamentos
        '
        Me.pagApontamentos.Controls.Add(Me.grpApontamento)
        Me.pagApontamentos.Controls.Add(Me.grdApontamento)
        Me.pagApontamentos.Location = New System.Drawing.Point(1, 22)
        Me.pagApontamentos.Name = "pagApontamentos"
        Me.pagApontamentos.Size = New System.Drawing.Size(946, 271)
        Me.pagApontamentos.TabStop = True
        Me.pagApontamentos.Text = "Apontamentos"
        '
        'grpApontamento
        '
        Me.grpApontamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpApontamento.BackColor = System.Drawing.Color.Transparent
        Me.grpApontamento.Controls.Add(Me.cboMaquina)
        Me.grpApontamento.Controls.Add(Me.lblMaquina)
        Me.grpApontamento.Controls.Add(Me.cboFuncionario)
        Me.grpApontamento.Controls.Add(Me.lblFuncionario)
        Me.grpApontamento.Controls.Add(Me.dtpDataTerminoApontamento)
        Me.grpApontamento.Controls.Add(Me.dtpDataInicioApontamento)
        Me.grpApontamento.Controls.Add(Me.lblPeriodoApontamento)
        Me.grpApontamento.Location = New System.Drawing.Point(8, 6)
        Me.grpApontamento.Name = "grpApontamento"
        Me.grpApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpApontamento.Size = New System.Drawing.Size(930, 69)
        Me.grpApontamento.TabIndex = 7
        Me.grpApontamento.VisualStyleManager = Me.vsmMain
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoSize = False
        Me.cboMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboMaquina.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboMaquina.Location = New System.Drawing.Point(386, 33)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaquina.Size = New System.Drawing.Size(286, 20)
        Me.cboMaquina.TabIndex = 21
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaquina.Location = New System.Drawing.Point(383, 17)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(66, 16)
        Me.lblMaquina.TabIndex = 20
        Me.lblMaquina.Text = "Máquina:"
        '
        'cboFuncionario
        '
        Me.cboFuncionario.AutoSize = False
        Me.cboFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboFuncionario.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboFuncionario.Location = New System.Drawing.Point(9, 33)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFuncionario.Size = New System.Drawing.Size(371, 20)
        Me.cboFuncionario.TabIndex = 19
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(6, 17)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(87, 16)
        Me.lblFuncionario.TabIndex = 11
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'dtpDataTerminoApontamento
        '
        '
        '
        '
        Me.dtpDataTerminoApontamento.DropDownCalendar.Name = ""
        Me.dtpDataTerminoApontamento.Location = New System.Drawing.Point(804, 33)
        Me.dtpDataTerminoApontamento.Name = "dtpDataTerminoApontamento"
        Me.dtpDataTerminoApontamento.ShowCheckBox = True
        Me.dtpDataTerminoApontamento.Size = New System.Drawing.Size(120, 20)
        Me.dtpDataTerminoApontamento.TabIndex = 4
        '
        'dtpDataInicioApontamento
        '
        '
        '
        '
        Me.dtpDataInicioApontamento.DropDownCalendar.Name = ""
        Me.dtpDataInicioApontamento.Location = New System.Drawing.Point(678, 33)
        Me.dtpDataInicioApontamento.Name = "dtpDataInicioApontamento"
        Me.dtpDataInicioApontamento.ShowCheckBox = True
        Me.dtpDataInicioApontamento.Size = New System.Drawing.Size(120, 20)
        Me.dtpDataInicioApontamento.TabIndex = 3
        '
        'lblPeriodoApontamento
        '
        Me.lblPeriodoApontamento.AutoSize = True
        Me.lblPeriodoApontamento.Location = New System.Drawing.Point(675, 16)
        Me.lblPeriodoApontamento.Name = "lblPeriodoApontamento"
        Me.lblPeriodoApontamento.Size = New System.Drawing.Size(166, 16)
        Me.lblPeriodoApontamento.TabIndex = 2
        Me.lblPeriodoApontamento.Text = "Data início apontamento:"
        '
        'grdApontamento
        '
        Me.grdApontamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdApontamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdApontamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdApontamento_DesignTimeLayout_Reference_0})
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdApontamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdApontamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdApontamento.Location = New System.Drawing.Point(8, 81)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.RecordNavigator = True
        Me.grdApontamento.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(930, 181)
        Me.grdApontamento.TabIndex = 6
        Me.grdApontamento.TabStop = False
        Me.grdApontamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCliente)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataNecessidadeTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataNecessidadeInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataNecessidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(948, 69)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(515, 34)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(309, 23)
        Me.cboStatusFiltro.TabIndex = 6
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(512, 17)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(52, 16)
        Me.lblStatusFiltro.TabIndex = 5
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboCliente
        '
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboCliente.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboCliente.Location = New System.Drawing.Point(9, 34)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(248, 20)
        Me.cboCliente.TabIndex = 1
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblClienteFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(56, 16)
        Me.lblClienteFiltro.TabIndex = 0
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'dtpDataNecessidadeTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataNecessidadeTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataNecessidadeTerminoFiltro.Location = New System.Drawing.Point(389, 34)
        Me.dtpDataNecessidadeTerminoFiltro.Name = "dtpDataNecessidadeTerminoFiltro"
        Me.dtpDataNecessidadeTerminoFiltro.ShowCheckBox = True
        Me.dtpDataNecessidadeTerminoFiltro.Size = New System.Drawing.Size(120, 23)
        Me.dtpDataNecessidadeTerminoFiltro.TabIndex = 4
        '
        'dtpDataNecessidadeInicioFiltro
        '
        '
        '
        '
        Me.dtpDataNecessidadeInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataNecessidadeInicioFiltro.Location = New System.Drawing.Point(263, 34)
        Me.dtpDataNecessidadeInicioFiltro.Name = "dtpDataNecessidadeInicioFiltro"
        Me.dtpDataNecessidadeInicioFiltro.ShowCheckBox = True
        Me.dtpDataNecessidadeInicioFiltro.Size = New System.Drawing.Size(120, 23)
        Me.dtpDataNecessidadeInicioFiltro.TabIndex = 3
        '
        'lblDataNecessidadeFiltro
        '
        Me.lblDataNecessidadeFiltro.AutoSize = True
        Me.lblDataNecessidadeFiltro.Location = New System.Drawing.Point(260, 17)
        Me.lblDataNecessidadeFiltro.Name = "lblDataNecessidadeFiltro"
        Me.lblDataNecessidadeFiltro.Size = New System.Drawing.Size(107, 16)
        Me.lblDataNecessidadeFiltro.TabIndex = 2
        Me.lblDataNecessidadeFiltro.Text = "Data Produção:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(848, 33)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 7
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 60000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.ShowAlways = True
        '
        'pagSintetico
        '
        Me.pagSintetico.Location = New System.Drawing.Point(1, 22)
        Me.pagSintetico.Name = "pagSintetico"
        Me.pagSintetico.Size = New System.Drawing.Size(946, 291)
        Me.pagSintetico.TabStop = True
        Me.pagSintetico.Text = "Sintético"
        '
        'Timer1
        '
        '
        'usrPrdPlanejamentoLegado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdPlanejamentoLegado"
        Me.Size = New System.Drawing.Size(966, 459)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagAnalitico.ResumeLayout(False)
        CType(Me.grdAnalitico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagProcesso.ResumeLayout(False)
        CType(Me.grdProcesso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagAgrupado.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagMaquinaAtual.ResumeLayout(False)
        CType(Me.grdMaquinaAtual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagFuncionarioAtual.ResumeLayout(False)
        CType(Me.grdFuncionarioAtual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagApontamentos.ResumeLayout(False)
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpApontamento.ResumeLayout(False)
        Me.grpApontamento.PerformLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagAnalitico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagProcesso As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagAgrupado As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagSintetico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdAnalitico As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdProcesso As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagApontamentos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagFuncionarioAtual As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagMaquinaAtual As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdFuncionarioAtual As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpApontamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoApontamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioApontamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblPeriodoApontamento As System.Windows.Forms.Label
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataNecessidadeTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataNecessidadeInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataNecessidadeFiltro As System.Windows.Forms.Label
    Friend WithEvents grdMaquinaAtual As Janus.Windows.GridEX.GridEX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cboMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaquina As System.Windows.Forms.Label
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
End Class
