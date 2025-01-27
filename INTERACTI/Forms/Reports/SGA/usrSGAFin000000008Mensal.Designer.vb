<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrSGAFin000000008Mensal
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
        Dim grdListagemDimas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrSGAFin000000008Mensal))
        Dim grdListagemSolutions_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagemRodrigues_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagemGroupserv_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagemTotais_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDimas = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagemDimas = New Janus.Windows.GridEX.GridEX()
        Me.pagSolutions = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagemSolutions = New Janus.Windows.GridEX.GridEX()
        Me.pagRodrigues = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagemRodrigues = New Janus.Windows.GridEX.GridEX()
        Me.pagGroupserv = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagemGroupserv = New Janus.Windows.GridEX.GridEX()
        Me.pagTotais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagemTotais = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoDataFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoData = New System.Windows.Forms.Label()
        Me.btnFiltrarGrid = New Janus.Windows.EditControls.UIButton()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcelListagem = New System.Windows.Forms.Button()
        Me.btnConfiguraGridListagem = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDimas.SuspendLayout()
        CType(Me.grdListagemDimas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagSolutions.SuspendLayout()
        CType(Me.grdListagemSolutions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagRodrigues.SuspendLayout()
        CType(Me.grdListagemRodrigues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGroupserv.SuspendLayout()
        CType(Me.grdListagemGroupserv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagTotais.SuspendLayout()
        CType(Me.grdListagemTotais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.tabDados)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.btnExcelListagem)
        Me.pagLista.Controls.Add(Me.btnConfiguraGridListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Financeiro SGA - FIN000000008"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(8, 87)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(982, 391)
        Me.tabDados.TabIndex = 101
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDimas, Me.pagSolutions, Me.pagRodrigues, Me.pagGroupserv, Me.pagTotais})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDimas
        '
        Me.pagDimas.Controls.Add(Me.grdListagemDimas)
        Me.pagDimas.Key = "pagItem"
        Me.pagDimas.Location = New System.Drawing.Point(1, 22)
        Me.pagDimas.Name = "pagDimas"
        Me.pagDimas.Size = New System.Drawing.Size(980, 368)
        Me.pagDimas.TabStop = True
        Me.pagDimas.Text = "Dimas"
        '
        'grdListagemDimas
        '
        Me.grdListagemDimas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagemDimas.AlternatingColors = True
        Me.grdListagemDimas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagemDimas_DesignTimeLayout.LayoutString = resources.GetString("grdListagemDimas_DesignTimeLayout.LayoutString")
        Me.grdListagemDimas.DesignTimeLayout = grdListagemDimas_DesignTimeLayout
        Me.grdListagemDimas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagemDimas.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemDimas.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemDimas.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemDimas.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemDimas.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemDimas.GroupByBoxVisible = False
        Me.grdListagemDimas.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagemDimas.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagemDimas.Hierarchical = True
        Me.grdListagemDimas.Location = New System.Drawing.Point(8, 4)
        Me.grdListagemDimas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagemDimas.Name = "grdListagemDimas"
        Me.grdListagemDimas.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemDimas.RecordNavigator = True
        Me.grdListagemDimas.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemDimas.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemDimas.Size = New System.Drawing.Size(964, 360)
        Me.grdListagemDimas.TabIndex = 96
        Me.grdListagemDimas.TabStop = False
        Me.grdListagemDimas.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemDimas.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemDimas.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemDimas.VisualStyleManager = Me.vsmMain
        '
        'pagSolutions
        '
        Me.pagSolutions.Controls.Add(Me.grdListagemSolutions)
        Me.pagSolutions.Key = "pagServico"
        Me.pagSolutions.Location = New System.Drawing.Point(1, 22)
        Me.pagSolutions.Name = "pagSolutions"
        Me.pagSolutions.Size = New System.Drawing.Size(980, 368)
        Me.pagSolutions.TabStop = True
        Me.pagSolutions.Text = "Solutions"
        '
        'grdListagemSolutions
        '
        Me.grdListagemSolutions.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagemSolutions.AlternatingColors = True
        Me.grdListagemSolutions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagemSolutions_DesignTimeLayout.LayoutString = resources.GetString("grdListagemSolutions_DesignTimeLayout.LayoutString")
        Me.grdListagemSolutions.DesignTimeLayout = grdListagemSolutions_DesignTimeLayout
        Me.grdListagemSolutions.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagemSolutions.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemSolutions.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemSolutions.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemSolutions.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemSolutions.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemSolutions.GroupByBoxVisible = False
        Me.grdListagemSolutions.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagemSolutions.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagemSolutions.Hierarchical = True
        Me.grdListagemSolutions.Location = New System.Drawing.Point(8, 4)
        Me.grdListagemSolutions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagemSolutions.Name = "grdListagemSolutions"
        Me.grdListagemSolutions.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemSolutions.RecordNavigator = True
        Me.grdListagemSolutions.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemSolutions.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemSolutions.Size = New System.Drawing.Size(964, 360)
        Me.grdListagemSolutions.TabIndex = 97
        Me.grdListagemSolutions.TabStop = False
        Me.grdListagemSolutions.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagemSolutions.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemSolutions.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemSolutions.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemSolutions.VisualStyleManager = Me.vsmMain
        '
        'pagRodrigues
        '
        Me.pagRodrigues.Controls.Add(Me.grdListagemRodrigues)
        Me.pagRodrigues.Location = New System.Drawing.Point(1, 22)
        Me.pagRodrigues.Name = "pagRodrigues"
        Me.pagRodrigues.Size = New System.Drawing.Size(980, 368)
        Me.pagRodrigues.TabStop = True
        Me.pagRodrigues.Text = "Rodrigues"
        '
        'grdListagemRodrigues
        '
        Me.grdListagemRodrigues.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagemRodrigues.AlternatingColors = True
        Me.grdListagemRodrigues.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagemRodrigues_DesignTimeLayout.LayoutString = resources.GetString("grdListagemRodrigues_DesignTimeLayout.LayoutString")
        Me.grdListagemRodrigues.DesignTimeLayout = grdListagemRodrigues_DesignTimeLayout
        Me.grdListagemRodrigues.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagemRodrigues.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemRodrigues.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemRodrigues.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemRodrigues.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemRodrigues.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemRodrigues.GroupByBoxVisible = False
        Me.grdListagemRodrigues.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagemRodrigues.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagemRodrigues.Hierarchical = True
        Me.grdListagemRodrigues.Location = New System.Drawing.Point(8, 4)
        Me.grdListagemRodrigues.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagemRodrigues.Name = "grdListagemRodrigues"
        Me.grdListagemRodrigues.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemRodrigues.RecordNavigator = True
        Me.grdListagemRodrigues.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemRodrigues.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemRodrigues.Size = New System.Drawing.Size(964, 360)
        Me.grdListagemRodrigues.TabIndex = 97
        Me.grdListagemRodrigues.TabStop = False
        Me.grdListagemRodrigues.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagemRodrigues.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemRodrigues.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemRodrigues.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemRodrigues.VisualStyleManager = Me.vsmMain
        '
        'pagGroupserv
        '
        Me.pagGroupserv.Controls.Add(Me.grdListagemGroupserv)
        Me.pagGroupserv.Location = New System.Drawing.Point(1, 22)
        Me.pagGroupserv.Name = "pagGroupserv"
        Me.pagGroupserv.Size = New System.Drawing.Size(980, 368)
        Me.pagGroupserv.TabStop = True
        Me.pagGroupserv.Text = "Groupserv"
        '
        'grdListagemGroupserv
        '
        Me.grdListagemGroupserv.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagemGroupserv.AlternatingColors = True
        Me.grdListagemGroupserv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagemGroupserv_DesignTimeLayout.LayoutString = resources.GetString("grdListagemGroupserv_DesignTimeLayout.LayoutString")
        Me.grdListagemGroupserv.DesignTimeLayout = grdListagemGroupserv_DesignTimeLayout
        Me.grdListagemGroupserv.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagemGroupserv.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemGroupserv.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemGroupserv.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemGroupserv.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemGroupserv.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemGroupserv.GroupByBoxVisible = False
        Me.grdListagemGroupserv.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagemGroupserv.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagemGroupserv.Hierarchical = True
        Me.grdListagemGroupserv.Location = New System.Drawing.Point(8, 4)
        Me.grdListagemGroupserv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagemGroupserv.Name = "grdListagemGroupserv"
        Me.grdListagemGroupserv.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemGroupserv.RecordNavigator = True
        Me.grdListagemGroupserv.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemGroupserv.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemGroupserv.Size = New System.Drawing.Size(964, 360)
        Me.grdListagemGroupserv.TabIndex = 97
        Me.grdListagemGroupserv.TabStop = False
        Me.grdListagemGroupserv.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagemGroupserv.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemGroupserv.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemGroupserv.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemGroupserv.VisualStyleManager = Me.vsmMain
        '
        'pagTotais
        '
        Me.pagTotais.Controls.Add(Me.grdListagemTotais)
        Me.pagTotais.Location = New System.Drawing.Point(1, 22)
        Me.pagTotais.Name = "pagTotais"
        Me.pagTotais.Size = New System.Drawing.Size(980, 368)
        Me.pagTotais.TabStop = True
        Me.pagTotais.Text = "Totais"
        '
        'grdListagemTotais
        '
        Me.grdListagemTotais.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagemTotais.AlternatingColors = True
        Me.grdListagemTotais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagemTotais_DesignTimeLayout.LayoutString = resources.GetString("grdListagemTotais_DesignTimeLayout.LayoutString")
        Me.grdListagemTotais.DesignTimeLayout = grdListagemTotais_DesignTimeLayout
        Me.grdListagemTotais.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagemTotais.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemTotais.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemTotais.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemTotais.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemTotais.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemTotais.GroupByBoxVisible = False
        Me.grdListagemTotais.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagemTotais.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagemTotais.Hierarchical = True
        Me.grdListagemTotais.Location = New System.Drawing.Point(8, 4)
        Me.grdListagemTotais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagemTotais.Name = "grdListagemTotais"
        Me.grdListagemTotais.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemTotais.RecordNavigator = True
        Me.grdListagemTotais.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemTotais.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemTotais.Size = New System.Drawing.Size(964, 360)
        Me.grdListagemTotais.TabIndex = 97
        Me.grdListagemTotais.TabStop = False
        Me.grdListagemTotais.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagemTotais.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagemTotais.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagemTotais.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemTotais.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboTipoDataFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoData)
        Me.grpFiltro.Controls.Add(Me.btnFiltrarGrid)
        Me.grpFiltro.Controls.Add(Me.cboTipo)
        Me.grpFiltro.Controls.Add(Me.lblTipo)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissao)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 78)
        Me.grpFiltro.TabIndex = 2
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboTipoDataFiltro
        '
        Me.cboTipoDataFiltro.Location = New System.Drawing.Point(175, 37)
        Me.cboTipoDataFiltro.Name = "cboTipoDataFiltro"
        Me.cboTipoDataFiltro.Size = New System.Drawing.Size(140, 20)
        Me.cboTipoDataFiltro.TabIndex = 13
        '
        'lblTipoData
        '
        Me.lblTipoData.AutoSize = True
        Me.lblTipoData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoData.Location = New System.Drawing.Point(172, 20)
        Me.lblTipoData.Name = "lblTipoData"
        Me.lblTipoData.Size = New System.Drawing.Size(55, 14)
        Me.lblTipoData.TabIndex = 12
        Me.lblTipoData.Text = "Tipo Data:"
        '
        'btnFiltrarGrid
        '
        Me.btnFiltrarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarGrid.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarGrid.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarGrid.Location = New System.Drawing.Point(882, 37)
        Me.btnFiltrarGrid.Name = "btnFiltrarGrid"
        Me.btnFiltrarGrid.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarGrid.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarGrid.TabIndex = 11
        Me.btnFiltrarGrid.Text = "Filtrar"
        Me.btnFiltrarGrid.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboTipo
        '
        Me.cboTipo.Location = New System.Drawing.Point(10, 37)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(159, 20)
        Me.cboTipo.TabIndex = 1
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipo.Location = New System.Drawing.Point(7, 20)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo:"
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(435, 37)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 4
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(321, 37)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 3
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(318, 20)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(32, 14)
        Me.lblDataEmissao.TabIndex = 2
        Me.lblDataEmissao.Text = "Data:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(557, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(113, 23)
        Me.btnExcel.TabIndex = 2
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(676, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(200, 23)
        Me.btnVisualizarImpressao.TabIndex = 0
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcelListagem
        '
        Me.btnExcelListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelListagem.FlatAppearance.BorderSize = 0
        Me.btnExcelListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelListagem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelListagem.Location = New System.Drawing.Point(344, 463)
        Me.btnExcelListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelListagem.Name = "btnExcelListagem"
        Me.btnExcelListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelListagem.TabIndex = 100
        Me.btnExcelListagem.TabStop = False
        Me.btnExcelListagem.UseVisualStyleBackColor = False
        '
        'btnConfiguraGridListagem
        '
        Me.btnConfiguraGridListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGridListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGridListagem.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGridListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGridListagem.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfiguraGridListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGridListagem.Location = New System.Drawing.Point(320, 463)
        Me.btnConfiguraGridListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGridListagem.Name = "btnConfiguraGridListagem"
        Me.btnConfiguraGridListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGridListagem.TabIndex = 99
        Me.btnConfiguraGridListagem.TabStop = False
        Me.btnConfiguraGridListagem.UseVisualStyleBackColor = False
        '
        'usrSGAFin000000008Mensal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrSGAFin000000008Mensal"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDimas.ResumeLayout(False)
        CType(Me.grdListagemDimas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagSolutions.ResumeLayout(False)
        CType(Me.grdListagemSolutions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagRodrigues.ResumeLayout(False)
        CType(Me.grdListagemRodrigues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGroupserv.ResumeLayout(False)
        CType(Me.grdListagemGroupserv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagTotais.ResumeLayout(False)
        CType(Me.grdListagemTotais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrarGrid As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents grdListagemDimas As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelListagem As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGridListagem As System.Windows.Forms.Button
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDimas As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagSolutions As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagemSolutions As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagRodrigues As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagemRodrigues As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagGroupserv As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagemGroupserv As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagTotais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagemTotais As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboTipoDataFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoData As System.Windows.Forms.Label

End Class
