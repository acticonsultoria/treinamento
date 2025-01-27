<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadBudget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadBudget))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAtivoFiltro = New System.Windows.Forms.Label()
        Me.cboAtivoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataFinalFinanceiro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFinanceiro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFinanceiroFiltro = New System.Windows.Forms.Label()
        Me.dtpDataFinalCompetenciaFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioCompeteciaFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCompetenciaFiltro = New System.Windows.Forms.Label()
        Me.lblContaContabilFiltro = New System.Windows.Forms.Label()
        Me.cboContaContabilFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportarExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataFinanceiro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFinanceiro = New System.Windows.Forms.Label()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.dtpDataCompetencia = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCompetencia = New System.Windows.Forms.Label()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
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
        Me.pagLista.Text = "Budget"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 374)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(49, 15)
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 74)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 317)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblAtivoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAtivoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataFinalFinanceiro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFinanceiro)
        Me.grpFiltro.Controls.Add(Me.lblDataFinanceiroFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataFinalCompetenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioCompeteciaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataCompetenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblContaContabilFiltro)
        Me.grpFiltro.Controls.Add(Me.cboContaContabilFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 65)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblAtivoFiltro
        '
        Me.lblAtivoFiltro.AutoSize = True
        Me.lblAtivoFiltro.Location = New System.Drawing.Point(673, 12)
        Me.lblAtivoFiltro.Name = "lblAtivoFiltro"
        Me.lblAtivoFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivoFiltro.TabIndex = 62
        Me.lblAtivoFiltro.Text = "Ativo:"
        '
        'cboAtivoFiltro
        '
        Me.cboAtivoFiltro.AutoSize = False
        Me.cboAtivoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAtivoFiltro.Location = New System.Drawing.Point(676, 29)
        Me.cboAtivoFiltro.Name = "cboAtivoFiltro"
        Me.cboAtivoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivoFiltro.Size = New System.Drawing.Size(81, 20)
        Me.cboAtivoFiltro.TabIndex = 63
        '
        'dtpDataFinalFinanceiro
        '
        Me.dtpDataFinalFinanceiro.Checked = False
        Me.dtpDataFinalFinanceiro.CustomFormat = "MM/yyyy"
        Me.dtpDataFinalFinanceiro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataFinalFinanceiro.DropDownCalendar.Name = ""
        Me.dtpDataFinalFinanceiro.Location = New System.Drawing.Point(589, 29)
        Me.dtpDataFinalFinanceiro.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataFinalFinanceiro.Name = "dtpDataFinalFinanceiro"
        Me.dtpDataFinalFinanceiro.ShowCheckBox = True
        Me.dtpDataFinalFinanceiro.Size = New System.Drawing.Size(81, 20)
        Me.dtpDataFinalFinanceiro.TabIndex = 61
        Me.dtpDataFinalFinanceiro.Value = New Date(2016, 2, 1, 0, 0, 0, 0)
        '
        'dtpDataInicioFinanceiro
        '
        Me.dtpDataInicioFinanceiro.Checked = False
        Me.dtpDataInicioFinanceiro.CustomFormat = "MM/yyyy"
        Me.dtpDataInicioFinanceiro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataInicioFinanceiro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFinanceiro.Location = New System.Drawing.Point(501, 29)
        Me.dtpDataInicioFinanceiro.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataInicioFinanceiro.Name = "dtpDataInicioFinanceiro"
        Me.dtpDataInicioFinanceiro.ShowCheckBox = True
        Me.dtpDataInicioFinanceiro.Size = New System.Drawing.Size(82, 20)
        Me.dtpDataInicioFinanceiro.TabIndex = 60
        Me.dtpDataInicioFinanceiro.Value = New Date(2016, 2, 1, 0, 0, 0, 0)
        '
        'lblDataFinanceiroFiltro
        '
        Me.lblDataFinanceiroFiltro.AutoSize = True
        Me.lblDataFinanceiroFiltro.Location = New System.Drawing.Point(498, 12)
        Me.lblDataFinanceiroFiltro.Name = "lblDataFinanceiroFiltro"
        Me.lblDataFinanceiroFiltro.Size = New System.Drawing.Size(99, 14)
        Me.lblDataFinanceiroFiltro.TabIndex = 59
        Me.lblDataFinanceiroFiltro.Text = "Período Financeiro:"
        '
        'dtpDataFinalCompetenciaFiltro
        '
        Me.dtpDataFinalCompetenciaFiltro.Checked = False
        Me.dtpDataFinalCompetenciaFiltro.CustomFormat = "MM/yyyy"
        Me.dtpDataFinalCompetenciaFiltro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataFinalCompetenciaFiltro.DropDownCalendar.Name = ""
        Me.dtpDataFinalCompetenciaFiltro.Location = New System.Drawing.Point(414, 29)
        Me.dtpDataFinalCompetenciaFiltro.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataFinalCompetenciaFiltro.Name = "dtpDataFinalCompetenciaFiltro"
        Me.dtpDataFinalCompetenciaFiltro.ShowCheckBox = True
        Me.dtpDataFinalCompetenciaFiltro.Size = New System.Drawing.Size(81, 20)
        Me.dtpDataFinalCompetenciaFiltro.TabIndex = 58
        Me.dtpDataFinalCompetenciaFiltro.Value = New Date(2016, 2, 1, 0, 0, 0, 0)
        '
        'dtpDataInicioCompeteciaFiltro
        '
        Me.dtpDataInicioCompeteciaFiltro.Checked = False
        Me.dtpDataInicioCompeteciaFiltro.CustomFormat = "MM/yyyy"
        Me.dtpDataInicioCompeteciaFiltro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataInicioCompeteciaFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioCompeteciaFiltro.Location = New System.Drawing.Point(326, 29)
        Me.dtpDataInicioCompeteciaFiltro.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataInicioCompeteciaFiltro.Name = "dtpDataInicioCompeteciaFiltro"
        Me.dtpDataInicioCompeteciaFiltro.ShowCheckBox = True
        Me.dtpDataInicioCompeteciaFiltro.Size = New System.Drawing.Size(82, 20)
        Me.dtpDataInicioCompeteciaFiltro.TabIndex = 57
        Me.dtpDataInicioCompeteciaFiltro.Value = New Date(2016, 2, 1, 0, 0, 0, 0)
        '
        'lblDataCompetenciaFiltro
        '
        Me.lblDataCompetenciaFiltro.AutoSize = True
        Me.lblDataCompetenciaFiltro.Location = New System.Drawing.Point(323, 12)
        Me.lblDataCompetenciaFiltro.Name = "lblDataCompetenciaFiltro"
        Me.lblDataCompetenciaFiltro.Size = New System.Drawing.Size(111, 14)
        Me.lblDataCompetenciaFiltro.TabIndex = 56
        Me.lblDataCompetenciaFiltro.Text = "Período Competência:"
        '
        'lblContaContabilFiltro
        '
        Me.lblContaContabilFiltro.AutoSize = True
        Me.lblContaContabilFiltro.Location = New System.Drawing.Point(6, 12)
        Me.lblContaContabilFiltro.Name = "lblContaContabilFiltro"
        Me.lblContaContabilFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabilFiltro.TabIndex = 53
        Me.lblContaContabilFiltro.Text = "Conta Contábil:"
        '
        'cboContaContabilFiltro
        '
        Me.cboContaContabilFiltro.AutoSize = False
        Me.cboContaContabilFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabilFiltro.Location = New System.Drawing.Point(6, 29)
        Me.cboContaContabilFiltro.Name = "cboContaContabilFiltro"
        Me.cboContaContabilFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabilFiltro.Size = New System.Drawing.Size(314, 20)
        Me.cboContaContabilFiltro.TabIndex = 54
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 29)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnImportarExcel)
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 394)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnImportarExcel
        '
        Me.btnImportarExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnImportarExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarExcel.Location = New System.Drawing.Point(9, 17)
        Me.btnImportarExcel.Name = "btnImportarExcel"
        Me.btnImportarExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarExcel.Size = New System.Drawing.Size(128, 23)
        Me.btnImportarExcel.TabIndex = 4
        Me.btnImportarExcel.Text = "Importar Excel"
        Me.btnImportarExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(506, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
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
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
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
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados do Budget"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 394)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
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
        Me.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
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
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
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
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.dtpDataFinanceiro)
        Me.grpDados.Controls.Add(Me.lblDataFinanceiro)
        Me.grpDados.Controls.Add(Me.txtValor)
        Me.grpDados.Controls.Add(Me.lblValor)
        Me.grpDados.Controls.Add(Me.dtpDataCompetencia)
        Me.grpDados.Controls.Add(Me.lblDataCompetencia)
        Me.grpDados.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpDados.Controls.Add(Me.lblContaContabil)
        Me.grpDados.Controls.Add(Me.cboContaContabil)
        Me.grpDados.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 120)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(807, 17)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 60
        Me.lblAtivo.Text = "Ativo:"
        '
        'cboAtivo
        '
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAtivo.Location = New System.Drawing.Point(810, 34)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(81, 20)
        Me.cboAtivo.TabIndex = 61
        '
        'dtpDataFinanceiro
        '
        Me.dtpDataFinanceiro.CustomFormat = "MM/yyyy"
        Me.dtpDataFinanceiro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataFinanceiro.DropDownCalendar.Name = ""
        Me.dtpDataFinanceiro.Location = New System.Drawing.Point(109, 77)
        Me.dtpDataFinanceiro.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataFinanceiro.Name = "dtpDataFinanceiro"
        Me.dtpDataFinanceiro.Size = New System.Drawing.Size(82, 20)
        Me.dtpDataFinanceiro.TabIndex = 59
        '
        'lblDataFinanceiro
        '
        Me.lblDataFinanceiro.AutoSize = True
        Me.lblDataFinanceiro.Location = New System.Drawing.Point(106, 60)
        Me.lblDataFinanceiro.Name = "lblDataFinanceiro"
        Me.lblDataFinanceiro.Size = New System.Drawing.Size(85, 14)
        Me.lblDataFinanceiro.TabIndex = 58
        Me.lblDataFinanceiro.Text = "Data Financeiro:"
        '
        'txtValor
        '
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(197, 77)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(99, 20)
        Me.txtValor.TabIndex = 57
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(194, 60)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 56
        Me.lblValor.Text = "Valor:"
        '
        'dtpDataCompetencia
        '
        Me.dtpDataCompetencia.CustomFormat = "MM/yyyy"
        Me.dtpDataCompetencia.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataCompetencia.DropDownCalendar.Name = ""
        Me.dtpDataCompetencia.Location = New System.Drawing.Point(9, 77)
        Me.dtpDataCompetencia.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataCompetencia.Name = "dtpDataCompetencia"
        Me.dtpDataCompetencia.Size = New System.Drawing.Size(94, 20)
        Me.dtpDataCompetencia.TabIndex = 55
        '
        'lblDataCompetencia
        '
        Me.lblDataCompetencia.AutoSize = True
        Me.lblDataCompetencia.Location = New System.Drawing.Point(6, 60)
        Me.lblDataCompetencia.Name = "lblDataCompetencia"
        Me.lblDataCompetencia.Size = New System.Drawing.Size(97, 14)
        Me.lblDataCompetencia.TabIndex = 54
        Me.lblDataCompetencia.Text = "Data Competência:"
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(256, 17)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 53
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(22, 17)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 51
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(9, 34)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(267, 20)
        Me.cboContaContabil.TabIndex = 52
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(6, 17)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 50
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(282, 34)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(522, 20)
        Me.txtDescricao.TabIndex = 9
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(279, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 8
        Me.lblDescricao.Text = "Descrição:"
        '
        'usrCadBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadBudget"
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
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents dtpDataCompetencia As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCompetencia As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicioCompeteciaFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCompetenciaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblContaContabilFiltro As System.Windows.Forms.Label
    Friend WithEvents cboContaContabilFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataFinalCompetenciaFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataFinanceiro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFinanceiro As System.Windows.Forms.Label
    Friend WithEvents dtpDataFinalFinanceiro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFinanceiro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFinanceiroFiltro As System.Windows.Forms.Label
    Friend WithEvents lblAtivoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAtivoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnImportarExcel As Janus.Windows.EditControls.UIButton

End Class
