<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinCashFlow
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
        Dim grdResumo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinCashFlow))
        Dim grdDespesa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdReceita_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdSintetico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPedido_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagResumo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdResumo = New Janus.Windows.GridEX.GridEX()
        Me.pagDespesa = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdDespesa = New Janus.Windows.GridEX.GridEX()
        Me.pagReceita = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdReceita = New Janus.Windows.GridEX.GridEX()
        Me.pagSintetico = New Janus.Windows.UI.Tab.UITabPage()
        Me.txtSaldoInicial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grdSintetico = New Janus.Windows.GridEX.GridEX()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.lblDataTermino = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnPagar = New Janus.Windows.EditControls.UIButton()
        Me.grdPedido = New Janus.Windows.GridEX.GridEX()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagResumo.SuspendLayout()
        CType(Me.grdResumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDespesa.SuspendLayout()
        CType(Me.grdDespesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagReceita.SuspendLayout()
        CType(Me.grdReceita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagSintetico.SuspendLayout()
        CType(Me.grdSintetico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.tabDados)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 453)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Cash Flow"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(9, 80)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.Size = New System.Drawing.Size(895, 307)
        Me.tabDados.TabIndex = 36
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagResumo, Me.pagDespesa, Me.pagReceita, Me.pagSintetico})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagResumo
        '
        Me.pagResumo.Controls.Add(Me.grdResumo)
        Me.pagResumo.Location = New System.Drawing.Point(1, 22)
        Me.pagResumo.Name = "pagResumo"
        Me.pagResumo.Size = New System.Drawing.Size(893, 284)
        Me.pagResumo.TabStop = True
        Me.pagResumo.Text = "Resumo"
        '
        'grdResumo
        '
        Me.grdResumo.AllowChildTableGroups = True
        Me.grdResumo.AllowDrop = True
        Me.grdResumo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdResumo.AlternatingColors = True
        Me.grdResumo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdResumo_DesignTimeLayout.LayoutString = resources.GetString("grdResumo_DesignTimeLayout.LayoutString")
        Me.grdResumo.DesignTimeLayout = grdResumo_DesignTimeLayout
        Me.grdResumo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdResumo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdResumo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdResumo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdResumo.FrozenColumns = 5
        Me.grdResumo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdResumo.GroupByBoxVisible = False
        Me.grdResumo.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdResumo.Location = New System.Drawing.Point(8, 11)
        Me.grdResumo.Name = "grdResumo"
        Me.grdResumo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdResumo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdResumo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdResumo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdResumo.Size = New System.Drawing.Size(877, 258)
        Me.grdResumo.TabIndex = 2
        Me.grdResumo.TabStop = False
        Me.grdResumo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdResumo.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdResumo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdResumo.VisualStyleManager = Me.vsmMain
        '
        'pagDespesa
        '
        Me.pagDespesa.Controls.Add(Me.grdDespesa)
        Me.pagDespesa.Location = New System.Drawing.Point(1, 22)
        Me.pagDespesa.Name = "pagDespesa"
        Me.pagDespesa.Size = New System.Drawing.Size(893, 284)
        Me.pagDespesa.TabStop = True
        Me.pagDespesa.Text = "Despesa"
        '
        'grdDespesa
        '
        Me.grdDespesa.AllowChildTableGroups = True
        Me.grdDespesa.AllowDrop = True
        Me.grdDespesa.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdDespesa.AlternatingColors = True
        Me.grdDespesa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdDespesa_DesignTimeLayout.LayoutString = resources.GetString("grdDespesa_DesignTimeLayout.LayoutString")
        Me.grdDespesa.DesignTimeLayout = grdDespesa_DesignTimeLayout
        Me.grdDespesa.DynamicFiltering = True
        Me.grdDespesa.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdDespesa.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdDespesa.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdDespesa.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDespesa.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDespesa.FrozenColumns = 5
        Me.grdDespesa.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDespesa.GroupByBoxVisible = False
        Me.grdDespesa.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdDespesa.Location = New System.Drawing.Point(8, 11)
        Me.grdDespesa.Name = "grdDespesa"
        Me.grdDespesa.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDespesa.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDespesa.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDespesa.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDespesa.Size = New System.Drawing.Size(877, 258)
        Me.grdDespesa.TabIndex = 1
        Me.grdDespesa.TabStop = False
        Me.grdDespesa.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdDespesa.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDespesa.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdDespesa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDespesa.VisualStyleManager = Me.vsmMain
        '
        'pagReceita
        '
        Me.pagReceita.Controls.Add(Me.grdReceita)
        Me.pagReceita.Location = New System.Drawing.Point(1, 22)
        Me.pagReceita.Name = "pagReceita"
        Me.pagReceita.Size = New System.Drawing.Size(893, 284)
        Me.pagReceita.TabStop = True
        Me.pagReceita.Text = "Receita"
        '
        'grdReceita
        '
        Me.grdReceita.AllowChildTableGroups = True
        Me.grdReceita.AllowDrop = True
        Me.grdReceita.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdReceita.AlternatingColors = True
        Me.grdReceita.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdReceita_DesignTimeLayout.LayoutString = resources.GetString("grdReceita_DesignTimeLayout.LayoutString")
        Me.grdReceita.DesignTimeLayout = grdReceita_DesignTimeLayout
        Me.grdReceita.DynamicFiltering = True
        Me.grdReceita.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdReceita.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdReceita.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdReceita.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdReceita.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdReceita.FrozenColumns = 5
        Me.grdReceita.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdReceita.GroupByBoxVisible = False
        Me.grdReceita.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdReceita.Location = New System.Drawing.Point(8, 11)
        Me.grdReceita.Name = "grdReceita"
        Me.grdReceita.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdReceita.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdReceita.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdReceita.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdReceita.Size = New System.Drawing.Size(877, 258)
        Me.grdReceita.TabIndex = 2
        Me.grdReceita.TabStop = False
        Me.grdReceita.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdReceita.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdReceita.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdReceita.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdReceita.VisualStyleManager = Me.vsmMain
        '
        'pagSintetico
        '
        Me.pagSintetico.Controls.Add(Me.txtSaldoInicial)
        Me.pagSintetico.Controls.Add(Me.grdSintetico)
        Me.pagSintetico.Controls.Add(Me.dtpDataTermino)
        Me.pagSintetico.Controls.Add(Me.lblSaldoInicial)
        Me.pagSintetico.Controls.Add(Me.lblDataTermino)
        Me.pagSintetico.Location = New System.Drawing.Point(1, 22)
        Me.pagSintetico.Name = "pagSintetico"
        Me.pagSintetico.Size = New System.Drawing.Size(893, 284)
        Me.pagSintetico.TabStop = True
        Me.pagSintetico.Text = "Sintético"
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.DecimalDigits = 2
        Me.txtSaldoInicial.FormatString = "0.00"
        Me.txtSaldoInicial.Location = New System.Drawing.Point(105, 24)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(98, 20)
        Me.txtSaldoInicial.TabIndex = 26
        Me.txtSaldoInicial.Text = "0,00"
        Me.txtSaldoInicial.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'grdSintetico
        '
        Me.grdSintetico.AllowChildTableGroups = True
        Me.grdSintetico.AllowDrop = True
        Me.grdSintetico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdSintetico.AlternatingColors = True
        Me.grdSintetico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdSintetico_DesignTimeLayout.LayoutString = resources.GetString("grdSintetico_DesignTimeLayout.LayoutString")
        Me.grdSintetico.DesignTimeLayout = grdSintetico_DesignTimeLayout
        Me.grdSintetico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdSintetico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdSintetico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdSintetico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdSintetico.FrozenColumns = 5
        Me.grdSintetico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdSintetico.GroupByBoxVisible = False
        Me.grdSintetico.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdSintetico.Location = New System.Drawing.Point(8, 50)
        Me.grdSintetico.Name = "grdSintetico"
        Me.grdSintetico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdSintetico.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdSintetico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdSintetico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdSintetico.Size = New System.Drawing.Size(877, 221)
        Me.grdSintetico.TabIndex = 3
        Me.grdSintetico.TabStop = False
        Me.grdSintetico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdSintetico.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdSintetico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdSintetico.VisualStyleManager = Me.vsmMain
        '
        'dtpDataTermino
        '
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(8, 24)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataTermino.TabIndex = 5
        Me.dtpDataTermino.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaldoInicial.Location = New System.Drawing.Point(102, 7)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(66, 14)
        Me.lblSaldoInicial.TabIndex = 25
        Me.lblSaldoInicial.Text = "Saldo Inicial:"
        '
        'lblDataTermino
        '
        Me.lblDataTermino.AutoSize = True
        Me.lblDataTermino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataTermino.Location = New System.Drawing.Point(5, 6)
        Me.lblDataTermino.Name = "lblDataTermino"
        Me.lblDataTermino.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTermino.TabIndex = 4
        Me.lblDataTermino.Text = "Data Término:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(10, 393)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(894, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(692, 18)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(97, 23)
        Me.btnExcel.TabIndex = 7
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(795, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(90, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblContaBancaria)
        Me.grpFiltro.Controls.Add(Me.cboContaBancaria)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(9, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(895, 71)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(786, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(90, 23)
        Me.btnFiltrar.TabIndex = 12
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnVoltar)
        Me.UiGroupBox2.Controls.Add(Me.btnPagar)
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 393)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(897, 51)
        Me.UiGroupBox2.TabIndex = 10
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(798, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(90, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPagar
        '
        Me.btnPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar.Image = Global.INTERACTI.My.Resources.Resources.dinheiro
        Me.btnPagar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar.Location = New System.Drawing.Point(702, 17)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar.Size = New System.Drawing.Size(90, 23)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdPedido
        '
        Me.grdPedido.AllowChildTableGroups = True
        Me.grdPedido.AlternatingColors = True
        Me.grdPedido.AutomaticSort = False
        Me.grdPedido.BuiltInTextsData = resources.GetString("grdPedido.BuiltInTextsData")
        grdPedido_DesignTimeLayout.LayoutString = resources.GetString("grdPedido_DesignTimeLayout.LayoutString")
        Me.grdPedido.DesignTimeLayout = grdPedido_DesignTimeLayout
        Me.grdPedido.DynamicFiltering = True
        Me.grdPedido.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedido.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedido.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedido.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedido.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPedido.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedido.GroupByBoxVisible = False
        Me.grdPedido.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.grdPedido.Location = New System.Drawing.Point(14, 10)
        Me.grdPedido.Name = "grdPedido"
        Me.grdPedido.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedido.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdPedido.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.grdPedido.Size = New System.Drawing.Size(1062, 381)
        Me.grdPedido.TabIndex = 6
        Me.grdPedido.TabStop = False
        Me.grdPedido.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedido.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedido.VisualStyleManager = Me.vsmMain
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaBancaria.Location = New System.Drawing.Point(9, 17)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 13
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContaBancaria.AutoSize = False
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancaria.Location = New System.Drawing.Point(9, 34)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancaria.Size = New System.Drawing.Size(273, 20)
        Me.cboContaBancaria.TabIndex = 14
        '
        'usrFinCashFlow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinCashFlow"
        Me.Size = New System.Drawing.Size(915, 476)
        Me.Tag = "S"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagResumo.ResumeLayout(False)
        CType(Me.grdResumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDespesa.ResumeLayout(False)
        CType(Me.grdDespesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagReceita.ResumeLayout(False)
        CType(Me.grdReceita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagSintetico.ResumeLayout(False)
        Me.pagSintetico.PerformLayout()
        CType(Me.grdSintetico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnPagar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdPedido As Janus.Windows.GridEX.GridEX
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDespesa As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdDespesa As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagReceita As Janus.Windows.UI.Tab.UITabPage
    Private WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagResumo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdReceita As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdResumo As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagSintetico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdSintetico As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataTermino As System.Windows.Forms.Label
    Friend WithEvents txtSaldoInicial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblSaldoInicial As System.Windows.Forms.Label
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox

End Class
