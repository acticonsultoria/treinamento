<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIndCompras2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme3 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim cboFornecedorFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboGrupoTecnologiaFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdDados_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIndCompras2))
        Dim ChartArea7 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend7 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim ChartArea8 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend8 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim ChartArea9 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend9 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtMetaFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMetaFiltro = New System.Windows.Forms.Label()
        Me.cboFornecedorFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.cboGrupoTecnologiaFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblGrupoTecnologia = New System.Windows.Forms.Label()
        Me.txtToleranciaFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblToleranciaFiltro = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPeríodo = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarGrafico = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox6 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagAmostra = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdDados = New Janus.Windows.GridEX.GridEX()
        Me.btnConfigurarGridAmostra = New System.Windows.Forms.Button()
        Me.btnExcelGridAmostra = New System.Windows.Forms.Button()
        Me.btnAgruparGridAmostra = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnInserirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.pagGrafico1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrGraficoOnTimePO = New Dundas.Charting.WinControl.Chart()
        Me.pagGrafico2 = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrGraficoOntimeMensal = New Dundas.Charting.WinControl.Chart()
        Me.pagGrafico3 = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrGraficoIAF = New Dundas.Charting.WinControl.Chart()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtMetaDados = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMetaDados = New System.Windows.Forms.Label()
        Me.txtFornecedorDados = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtToleranciaDados = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblToleranciaDados = New System.Windows.Forms.Label()
        Me.lblFornecedorDados = New System.Windows.Forms.Label()
        Me.dtpDataTerminoDados = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioDados = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFiltrarDados = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.btnExcelDados = New System.Windows.Forms.Button()
        Me.btnAgruparGridDados = New System.Windows.Forms.Button()
        Me.btnConfigurarGridDados = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox6.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagAmostra.SuspendLayout()
        CType(Me.grdDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGrafico1.SuspendLayout()
        CType(Me.chrGraficoOnTimePO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGrafico2.SuspendLayout()
        CType(Me.chrGraficoOntimeMensal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGrafico3.SuspendLayout()
        CType(Me.chrGraficoIAF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme3.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme3.Name = "Scheme"
        JanusColorScheme3.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme3.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme3.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme3)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
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
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Indicador - Compras"
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnAutoResize = True
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 7
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 74)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 401)
        Me.grdListagem.TabIndex = 5
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
        Me.grpFiltro.Controls.Add(Me.txtMetaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMetaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoTecnologiaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoTecnologia)
        Me.grpFiltro.Controls.Add(Me.txtToleranciaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblToleranciaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedor)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPeríodo)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 67)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtMetaFiltro
        '
        Me.txtMetaFiltro.FormatString = "0"
        Me.txtMetaFiltro.Location = New System.Drawing.Point(694, 37)
        Me.txtMetaFiltro.Name = "txtMetaFiltro"
        Me.txtMetaFiltro.Size = New System.Drawing.Size(58, 20)
        Me.txtMetaFiltro.TabIndex = 5
        Me.txtMetaFiltro.Text = "0"
        Me.txtMetaFiltro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMetaFiltro
        '
        Me.lblMetaFiltro.AutoSize = True
        Me.lblMetaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMetaFiltro.Location = New System.Drawing.Point(691, 20)
        Me.lblMetaFiltro.Name = "lblMetaFiltro"
        Me.lblMetaFiltro.Size = New System.Drawing.Size(33, 14)
        Me.lblMetaFiltro.TabIndex = 32
        Me.lblMetaFiltro.Text = "Meta:"
        '
        'cboFornecedorFiltro
        '
        Me.cboFornecedorFiltro.AllowDrop = True
        Me.cboFornecedorFiltro.ButtonCancelText = "Cancelar"
        Me.cboFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboFornecedorFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboFornecedorFiltro_DesignTimeLayout.LayoutString")
        Me.cboFornecedorFiltro.DesignTimeLayout = cboFornecedorFiltro_DesignTimeLayout
        Me.cboFornecedorFiltro.Location = New System.Drawing.Point(382, 37)
        Me.cboFornecedorFiltro.Name = "cboFornecedorFiltro"
        Me.cboFornecedorFiltro.SaveSettings = False
        Me.cboFornecedorFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboFornecedorFiltro.Size = New System.Drawing.Size(242, 20)
        Me.cboFornecedorFiltro.TabIndex = 3
        Me.cboFornecedorFiltro.ValuesDataMember = Nothing
        '
        'cboGrupoTecnologiaFiltro
        '
        Me.cboGrupoTecnologiaFiltro.AllowDrop = True
        Me.cboGrupoTecnologiaFiltro.ButtonCancelText = "Cancelar"
        Me.cboGrupoTecnologiaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboGrupoTecnologiaFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboGrupoTecnologiaFiltro_DesignTimeLayout.LayoutString")
        Me.cboGrupoTecnologiaFiltro.DesignTimeLayout = cboGrupoTecnologiaFiltro_DesignTimeLayout
        Me.cboGrupoTecnologiaFiltro.Location = New System.Drawing.Point(201, 37)
        Me.cboGrupoTecnologiaFiltro.Name = "cboGrupoTecnologiaFiltro"
        Me.cboGrupoTecnologiaFiltro.SaveSettings = False
        Me.cboGrupoTecnologiaFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboGrupoTecnologiaFiltro.Size = New System.Drawing.Size(175, 20)
        Me.cboGrupoTecnologiaFiltro.TabIndex = 2
        Me.cboGrupoTecnologiaFiltro.ValuesDataMember = Nothing
        '
        'lblGrupoTecnologia
        '
        Me.lblGrupoTecnologia.AutoSize = True
        Me.lblGrupoTecnologia.BackColor = System.Drawing.Color.Transparent
        Me.lblGrupoTecnologia.Location = New System.Drawing.Point(198, 20)
        Me.lblGrupoTecnologia.Name = "lblGrupoTecnologia"
        Me.lblGrupoTecnologia.Size = New System.Drawing.Size(94, 14)
        Me.lblGrupoTecnologia.TabIndex = 30
        Me.lblGrupoTecnologia.Text = "Grupo Tecnologia:"
        '
        'txtToleranciaFiltro
        '
        Me.txtToleranciaFiltro.FormatString = "0"
        Me.txtToleranciaFiltro.Location = New System.Drawing.Point(630, 37)
        Me.txtToleranciaFiltro.Name = "txtToleranciaFiltro"
        Me.txtToleranciaFiltro.Size = New System.Drawing.Size(58, 20)
        Me.txtToleranciaFiltro.TabIndex = 4
        Me.txtToleranciaFiltro.Text = "0"
        Me.txtToleranciaFiltro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblToleranciaFiltro
        '
        Me.lblToleranciaFiltro.AutoSize = True
        Me.lblToleranciaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblToleranciaFiltro.Location = New System.Drawing.Point(627, 20)
        Me.lblToleranciaFiltro.Name = "lblToleranciaFiltro"
        Me.lblToleranciaFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblToleranciaFiltro.TabIndex = 29
        Me.lblToleranciaFiltro.Text = "Tolerância:"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.lblFornecedor.Location = New System.Drawing.Point(379, 20)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 28
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(105, 37)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 1
        Me.dtpDataTerminoFiltro.Value = New Date(2014, 9, 23, 0, 0, 0, 0)
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 37)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataInicioFiltro.TabIndex = 0
        Me.dtpDataInicioFiltro.Value = New Date(2014, 9, 23, 0, 0, 0, 0)
        '
        'lblDataPeríodo
        '
        Me.lblDataPeríodo.AutoSize = True
        Me.lblDataPeríodo.Location = New System.Drawing.Point(6, 20)
        Me.lblDataPeríodo.Name = "lblDataPeríodo"
        Me.lblDataPeríodo.Size = New System.Drawing.Size(43, 14)
        Me.lblDataPeríodo.TabIndex = 0
        Me.lblDataPeríodo.Text = "Período"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVisualizarGrafico)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarGrafico
        '
        Me.btnVisualizarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarGrafico.Image = Global.INTERACTI.My.Resources.Resources.grafico
        Me.btnVisualizarGrafico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarGrafico.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnVisualizarGrafico.Location = New System.Drawing.Point(783, 17)
        Me.btnVisualizarGrafico.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnVisualizarGrafico.Name = "btnVisualizarGrafico"
        Me.btnVisualizarGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarGrafico.Size = New System.Drawing.Size(91, 23)
        Me.btnVisualizarGrafico.TabIndex = 1
        Me.btnVisualizarGrafico.Text = "Visualizar"
        Me.btnVisualizarGrafico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.UiGroupBox6)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.UiGroupBox1)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados"
        '
        'UiGroupBox6
        '
        Me.UiGroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox6.Controls.Add(Me.btnVoltar)
        Me.UiGroupBox6.Location = New System.Drawing.Point(8, 483)
        Me.UiGroupBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UiGroupBox6.Name = "UiGroupBox6"
        Me.UiGroupBox6.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox6.Size = New System.Drawing.Size(982, 51)
        Me.UiGroupBox6.TabIndex = 5
        Me.UiGroupBox6.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(882, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 3
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 76)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(982, 401)
        Me.tabDados.TabIndex = 2
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagAmostra, Me.pagGrafico1, Me.pagGrafico2, Me.pagGrafico3})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagAmostra
        '
        Me.pagAmostra.Controls.Add(Me.btnExcelDados)
        Me.pagAmostra.Controls.Add(Me.btnAgruparGridDados)
        Me.pagAmostra.Controls.Add(Me.btnConfigurarGridDados)
        Me.pagAmostra.Controls.Add(Me.btnConfigurarGridAmostra)
        Me.pagAmostra.Controls.Add(Me.btnExcelGridAmostra)
        Me.pagAmostra.Controls.Add(Me.btnAgruparGridAmostra)
        Me.pagAmostra.Controls.Add(Me.Button3)
        Me.pagAmostra.Controls.Add(Me.btnInserirAmostra)
        Me.pagAmostra.Controls.Add(Me.btnExcluirAmostra)
        Me.pagAmostra.Controls.Add(Me.grdDados)
        Me.pagAmostra.Location = New System.Drawing.Point(1, 22)
        Me.pagAmostra.Name = "pagAmostra"
        Me.pagAmostra.Size = New System.Drawing.Size(980, 378)
        Me.pagAmostra.TabStop = True
        Me.pagAmostra.Text = "Items de Compra"
        '
        'grdDados
        '
        Me.grdDados.AlternatingColors = True
        Me.grdDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDados.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdDados_DesignTimeLayout.LayoutString = resources.GetString("grdDados_DesignTimeLayout.LayoutString")
        Me.grdDados.DesignTimeLayout = grdDados_DesignTimeLayout
        Me.grdDados.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdDados.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdDados.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdDados.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDados.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDados.GroupByBoxVisible = False
        Me.grdDados.Hierarchical = True
        Me.grdDados.Location = New System.Drawing.Point(8, 3)
        Me.grdDados.Name = "grdDados"
        Me.grdDados.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDados.RecordNavigator = True
        Me.grdDados.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDados.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDados.Size = New System.Drawing.Size(964, 372)
        Me.grdDados.TabIndex = 26
        Me.grdDados.TabStop = False
        Me.grdDados.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdDados.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdDados.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDados.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDados.VisualStyleManager = Me.vsmMain
        '
        'btnConfigurarGridAmostra
        '
        Me.btnConfigurarGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridAmostra.Location = New System.Drawing.Point(11, 1378)
        Me.btnConfigurarGridAmostra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridAmostra.Name = "btnConfigurarGridAmostra"
        Me.btnConfigurarGridAmostra.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridAmostra.TabIndex = 25
        Me.btnConfigurarGridAmostra.TabStop = False
        Me.btnConfigurarGridAmostra.UseVisualStyleBackColor = False
        '
        'btnExcelGridAmostra
        '
        Me.btnExcelGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnExcelGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridAmostra.Location = New System.Drawing.Point(57, 1378)
        Me.btnExcelGridAmostra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridAmostra.Name = "btnExcelGridAmostra"
        Me.btnExcelGridAmostra.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridAmostra.TabIndex = 24
        Me.btnExcelGridAmostra.TabStop = False
        Me.btnExcelGridAmostra.UseVisualStyleBackColor = False
        '
        'btnAgruparGridAmostra
        '
        Me.btnAgruparGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridAmostra.Location = New System.Drawing.Point(33, 1378)
        Me.btnAgruparGridAmostra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridAmostra.Name = "btnAgruparGridAmostra"
        Me.btnAgruparGridAmostra.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridAmostra.TabIndex = 23
        Me.btnAgruparGridAmostra.TabStop = False
        Me.btnAgruparGridAmostra.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(11, 1380)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 15)
        Me.Button3.TabIndex = 22
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnInserirAmostra
        '
        Me.btnInserirAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirAmostra.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirAmostra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirAmostra.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirAmostra.Location = New System.Drawing.Point(3821, 7)
        Me.btnInserirAmostra.Name = "btnInserirAmostra"
        Me.btnInserirAmostra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirAmostra.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirAmostra.TabIndex = 14
        Me.btnInserirAmostra.Text = "Inserir"
        Me.btnInserirAmostra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirAmostra
        '
        Me.btnExcluirAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirAmostra.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirAmostra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirAmostra.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirAmostra.Location = New System.Drawing.Point(3821, 36)
        Me.btnExcluirAmostra.Name = "btnExcluirAmostra"
        Me.btnExcluirAmostra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirAmostra.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirAmostra.TabIndex = 15
        Me.btnExcluirAmostra.Text = "Excluir"
        Me.btnExcluirAmostra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagGrafico1
        '
        Me.pagGrafico1.Controls.Add(Me.chrGraficoOnTimePO)
        Me.pagGrafico1.Key = "pagDadosGerais"
        Me.pagGrafico1.Location = New System.Drawing.Point(1, 22)
        Me.pagGrafico1.Name = "pagGrafico1"
        Me.pagGrafico1.Size = New System.Drawing.Size(980, 378)
        Me.pagGrafico1.TabStop = True
        Me.pagGrafico1.Text = "Gráfico OnTime x PO"
        '
        'chrGraficoOnTimePO
        '
        Me.chrGraficoOnTimePO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrGraficoOnTimePO.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrGraficoOnTimePO.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrGraficoOnTimePO.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea7.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea7.AxisX.Title = "Período (dias)"
        ChartArea7.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea7.AxisY.Title = "Quantidade"
        ChartArea7.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea7.BorderColor = System.Drawing.Color.Empty
        ChartArea7.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea7.Name = "Default"
        Me.chrGraficoOnTimePO.ChartAreas.Add(ChartArea7)
        Legend7.AutoFitText = False
        Legend7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend7.Name = "Default"
        Me.chrGraficoOnTimePO.Legends.Add(Legend7)
        Me.chrGraficoOnTimePO.Location = New System.Drawing.Point(3, 3)
        Me.chrGraficoOnTimePO.Name = "chrGraficoOnTimePO"
        Me.chrGraficoOnTimePO.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrGraficoOnTimePO.Size = New System.Drawing.Size(974, 372)
        Me.chrGraficoOnTimePO.TabIndex = 2
        Me.chrGraficoOnTimePO.UI.Toolbar.Enabled = True
        '
        'pagGrafico2
        '
        Me.pagGrafico2.Controls.Add(Me.chrGraficoOntimeMensal)
        Me.pagGrafico2.Location = New System.Drawing.Point(1, 22)
        Me.pagGrafico2.Name = "pagGrafico2"
        Me.pagGrafico2.Size = New System.Drawing.Size(980, 378)
        Me.pagGrafico2.TabStop = True
        Me.pagGrafico2.Text = "Gráfico OnTime Mensal"
        '
        'chrGraficoOntimeMensal
        '
        Me.chrGraficoOntimeMensal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrGraficoOntimeMensal.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrGraficoOntimeMensal.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrGraficoOntimeMensal.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea8.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea8.AxisX.Title = "Período (dias)"
        ChartArea8.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea8.AxisY.Title = "Quantidade"
        ChartArea8.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea8.BorderColor = System.Drawing.Color.Empty
        ChartArea8.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea8.Name = "Default"
        Me.chrGraficoOntimeMensal.ChartAreas.Add(ChartArea8)
        Legend8.AutoFitText = False
        Legend8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend8.Name = "Default"
        Me.chrGraficoOntimeMensal.Legends.Add(Legend8)
        Me.chrGraficoOntimeMensal.Location = New System.Drawing.Point(3, 3)
        Me.chrGraficoOntimeMensal.Name = "chrGraficoOntimeMensal"
        Me.chrGraficoOntimeMensal.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrGraficoOntimeMensal.Size = New System.Drawing.Size(974, 372)
        Me.chrGraficoOntimeMensal.TabIndex = 3
        Me.chrGraficoOntimeMensal.UI.Toolbar.Enabled = True
        '
        'pagGrafico3
        '
        Me.pagGrafico3.Controls.Add(Me.chrGraficoIAF)
        Me.pagGrafico3.Location = New System.Drawing.Point(1, 22)
        Me.pagGrafico3.Name = "pagGrafico3"
        Me.pagGrafico3.Size = New System.Drawing.Size(980, 378)
        Me.pagGrafico3.TabStop = True
        Me.pagGrafico3.Text = "Gráfico IAF"
        '
        'chrGraficoIAF
        '
        Me.chrGraficoIAF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrGraficoIAF.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrGraficoIAF.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrGraficoIAF.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea9.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea9.AxisX.Title = "Período (dias)"
        ChartArea9.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea9.AxisY.Title = "Quantidade"
        ChartArea9.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea9.BorderColor = System.Drawing.Color.Empty
        ChartArea9.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea9.Name = "Default"
        Me.chrGraficoIAF.ChartAreas.Add(ChartArea9)
        Legend9.AutoFitText = False
        Legend9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend9.Name = "Default"
        Me.chrGraficoIAF.Legends.Add(Legend9)
        Me.chrGraficoIAF.Location = New System.Drawing.Point(3, 3)
        Me.chrGraficoIAF.Name = "chrGraficoIAF"
        Me.chrGraficoIAF.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrGraficoIAF.Size = New System.Drawing.Size(974, 372)
        Me.chrGraficoIAF.TabIndex = 4
        Me.chrGraficoIAF.UI.Toolbar.Enabled = True
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtMetaDados)
        Me.UiGroupBox1.Controls.Add(Me.lblMetaDados)
        Me.UiGroupBox1.Controls.Add(Me.txtFornecedorDados)
        Me.UiGroupBox1.Controls.Add(Me.txtToleranciaDados)
        Me.UiGroupBox1.Controls.Add(Me.lblToleranciaDados)
        Me.UiGroupBox1.Controls.Add(Me.lblFornecedorDados)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataTerminoDados)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataInicioDados)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Controls.Add(Me.btnFiltrarDados)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(982, 67)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.Text = "Filtro"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtMetaDados
        '
        Me.txtMetaDados.FormatString = "0"
        Me.txtMetaDados.Location = New System.Drawing.Point(516, 37)
        Me.txtMetaDados.Name = "txtMetaDados"
        Me.txtMetaDados.Size = New System.Drawing.Size(58, 20)
        Me.txtMetaDados.TabIndex = 33
        Me.txtMetaDados.Text = "0"
        Me.txtMetaDados.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMetaDados
        '
        Me.lblMetaDados.AutoSize = True
        Me.lblMetaDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMetaDados.Location = New System.Drawing.Point(513, 20)
        Me.lblMetaDados.Name = "lblMetaDados"
        Me.lblMetaDados.Size = New System.Drawing.Size(33, 14)
        Me.lblMetaDados.TabIndex = 34
        Me.lblMetaDados.Text = "Meta:"
        '
        'txtFornecedorDados
        '
        Me.txtFornecedorDados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFornecedorDados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorDados.Location = New System.Drawing.Point(204, 37)
        Me.txtFornecedorDados.MaxLength = 120
        Me.txtFornecedorDados.Name = "txtFornecedorDados"
        Me.txtFornecedorDados.Size = New System.Drawing.Size(242, 20)
        Me.txtFornecedorDados.TabIndex = 32
        '
        'txtToleranciaDados
        '
        Me.txtToleranciaDados.FormatString = "0"
        Me.txtToleranciaDados.Location = New System.Drawing.Point(452, 37)
        Me.txtToleranciaDados.Name = "txtToleranciaDados"
        Me.txtToleranciaDados.Size = New System.Drawing.Size(58, 20)
        Me.txtToleranciaDados.TabIndex = 30
        Me.txtToleranciaDados.Text = "0"
        Me.txtToleranciaDados.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblToleranciaDados
        '
        Me.lblToleranciaDados.AutoSize = True
        Me.lblToleranciaDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblToleranciaDados.Location = New System.Drawing.Point(449, 20)
        Me.lblToleranciaDados.Name = "lblToleranciaDados"
        Me.lblToleranciaDados.Size = New System.Drawing.Size(59, 14)
        Me.lblToleranciaDados.TabIndex = 31
        Me.lblToleranciaDados.Text = "Tolerância:"
        '
        'lblFornecedorDados
        '
        Me.lblFornecedorDados.AutoSize = True
        Me.lblFornecedorDados.BackColor = System.Drawing.Color.Transparent
        Me.lblFornecedorDados.Location = New System.Drawing.Point(201, 20)
        Me.lblFornecedorDados.Name = "lblFornecedorDados"
        Me.lblFornecedorDados.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorDados.TabIndex = 28
        Me.lblFornecedorDados.Text = "Fornecedor:"
        '
        'dtpDataTerminoDados
        '
        '
        '
        '
        Me.dtpDataTerminoDados.DropDownCalendar.Name = ""
        Me.dtpDataTerminoDados.Location = New System.Drawing.Point(105, 37)
        Me.dtpDataTerminoDados.Name = "dtpDataTerminoDados"
        Me.dtpDataTerminoDados.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataTerminoDados.TabIndex = 1
        Me.dtpDataTerminoDados.Value = New Date(2014, 9, 23, 0, 0, 0, 0)
        '
        'dtpDataInicioDados
        '
        '
        '
        '
        Me.dtpDataInicioDados.DropDownCalendar.Name = ""
        Me.dtpDataInicioDados.Location = New System.Drawing.Point(9, 37)
        Me.dtpDataInicioDados.Name = "dtpDataInicioDados"
        Me.dtpDataInicioDados.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataInicioDados.TabIndex = 0
        Me.dtpDataInicioDados.Value = New Date(2014, 9, 23, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Período"
        '
        'btnFiltrarDados
        '
        Me.btnFiltrarDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarDados.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarDados.Location = New System.Drawing.Point(882, 34)
        Me.btnFiltrarDados.Name = "btnFiltrarDados"
        Me.btnFiltrarDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarDados.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarDados.TabIndex = 4
        Me.btnFiltrarDados.Text = "Filtrar"
        Me.btnFiltrarDados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Key = "pagDadosCliente"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 22)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(980, 378)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Visible = False
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 458)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 29
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 458)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 28
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 458)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 27
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'btnExcelDados
        '
        Me.btnExcelDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelDados.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelDados.FlatAppearance.BorderSize = 0
        Me.btnExcelDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelDados.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelDados.Location = New System.Drawing.Point(59, 358)
        Me.btnExcelDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelDados.Name = "btnExcelDados"
        Me.btnExcelDados.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelDados.TabIndex = 32
        Me.btnExcelDados.TabStop = False
        Me.btnExcelDados.UseVisualStyleBackColor = False
        '
        'btnAgruparGridDados
        '
        Me.btnAgruparGridDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridDados.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridDados.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridDados.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridDados.Location = New System.Drawing.Point(35, 358)
        Me.btnAgruparGridDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridDados.Name = "btnAgruparGridDados"
        Me.btnAgruparGridDados.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridDados.TabIndex = 31
        Me.btnAgruparGridDados.TabStop = False
        Me.btnAgruparGridDados.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridDados
        '
        Me.btnConfigurarGridDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridDados.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridDados.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridDados.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridDados.Location = New System.Drawing.Point(11, 358)
        Me.btnConfigurarGridDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridDados.Name = "btnConfigurarGridDados"
        Me.btnConfigurarGridDados.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridDados.TabIndex = 30
        Me.btnConfigurarGridDados.TabStop = False
        Me.btnConfigurarGridDados.UseVisualStyleBackColor = False
        '
        'usrIndCompras2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "usrIndCompras2"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox6.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagAmostra.ResumeLayout(False)
        CType(Me.grdDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGrafico1.ResumeLayout(False)
        CType(Me.chrGraficoOnTimePO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGrafico2.ResumeLayout(False)
        CType(Me.chrGraficoOntimeMensal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGrafico3.ResumeLayout(False)
        CType(Me.chrGraficoIAF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPeríodo As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFornecedorDados As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoDados As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioDados As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarDados As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox6 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagAmostra As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridAmostra As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnInserirAmostra As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirAmostra As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagGrafico1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdDados As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagGrafico2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagGrafico3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtToleranciaFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblToleranciaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtToleranciaDados As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblToleranciaDados As System.Windows.Forms.Label
    Friend WithEvents txtFornecedorDados As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboGrupoTecnologiaFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblGrupoTecnologia As System.Windows.Forms.Label
    Friend WithEvents cboFornecedorFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents txtMetaFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMetaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtMetaDados As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMetaDados As System.Windows.Forms.Label
    Friend WithEvents chrGraficoOnTimePO As Dundas.Charting.WinControl.Chart
    Friend WithEvents chrGraficoOntimeMensal As Dundas.Charting.WinControl.Chart
    Friend WithEvents chrGraficoIAF As Dundas.Charting.WinControl.Chart
    Friend WithEvents btnVisualizarGrafico As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelDados As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridDados As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridDados As System.Windows.Forms.Button

End Class
