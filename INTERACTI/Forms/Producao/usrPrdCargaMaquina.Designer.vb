<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdCargaMaquina
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
        Dim grdDisponibilidade_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdCargaMaquina))
        Dim grdOrcamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdOrcamentoOperacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdNecessidade_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdCargaMaquina_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagMain = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDisponibilidade = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdDisponibilidade = New Janus.Windows.GridEX.GridEX()
        Me.pagOrcamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdOrcamento = New Janus.Windows.GridEX.GridEX()
        Me.grpOrcamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEntregaOrcamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntregaOrcamento = New System.Windows.Forms.Label()
        Me.btnInserirOrcamento = New Janus.Windows.EditControls.UIButton()
        Me.cboOrcamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrcamento = New System.Windows.Forms.Label()
        Me.grdOrcamentoOperacao = New Janus.Windows.GridEX.GridEX()
        Me.pagNecessidade = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdNecessidade = New Janus.Windows.GridEX.GridEX()
        Me.pagCargaMaquina = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdCargaMaquina = New Janus.Windows.GridEX.GridEX()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.txtOrdemProducaoDesconsiderar = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducaoDesconsiderar = New System.Windows.Forms.Label()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataProducaoFiltro = New System.Windows.Forms.Label()
        Me.chkIncluirDomingo = New Janus.Windows.EditControls.UICheckBox()
        Me.chkIncluirSabado = New Janus.Windows.EditControls.UICheckBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.btnExcelGridServico = New System.Windows.Forms.Button()
        Me.btnAgruparGridServico = New System.Windows.Forms.Button()
        Me.btnConfigurarGridServico = New System.Windows.Forms.Button()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.dtpDataEntregaInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEntregaTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntregaFiltro = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagMain.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDisponibilidade.SuspendLayout()
        CType(Me.grdDisponibilidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagOrcamento.SuspendLayout()
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrcamento.SuspendLayout()
        CType(Me.grdOrcamentoOperacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagNecessidade.SuspendLayout()
        CType(Me.grdNecessidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCargaMaquina.SuspendLayout()
        CType(Me.grdCargaMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(946, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagMain})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagMain
        '
        Me.pagMain.Controls.Add(Me.tabDados)
        Me.pagMain.Controls.Add(Me.grpEntrega)
        Me.pagMain.Controls.Add(Me.grpFiltro)
        Me.pagMain.Location = New System.Drawing.Point(1, 24)
        Me.pagMain.Name = "pagMain"
        Me.pagMain.Size = New System.Drawing.Size(944, 541)
        Me.pagMain.TabStop = True
        Me.pagMain.Text = "Relatório de Carga Máquina"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(7, 119)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(925, 356)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDisponibilidade, Me.pagOrcamento, Me.pagNecessidade, Me.pagCargaMaquina})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDisponibilidade
        '
        Me.pagDisponibilidade.Controls.Add(Me.grdDisponibilidade)
        Me.pagDisponibilidade.Location = New System.Drawing.Point(1, 24)
        Me.pagDisponibilidade.Name = "pagDisponibilidade"
        Me.pagDisponibilidade.Size = New System.Drawing.Size(923, 331)
        Me.pagDisponibilidade.TabStop = True
        Me.pagDisponibilidade.Text = "Disponibilidade"
        '
        'grdDisponibilidade
        '
        Me.grdDisponibilidade.AlternatingColors = True
        Me.grdDisponibilidade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdDisponibilidade_DesignTimeLayout.LayoutString = resources.GetString("grdDisponibilidade_DesignTimeLayout.LayoutString")
        Me.grdDisponibilidade.DesignTimeLayout = grdDisponibilidade_DesignTimeLayout
        Me.grdDisponibilidade.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdDisponibilidade.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdDisponibilidade.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdDisponibilidade.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDisponibilidade.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDisponibilidade.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDisponibilidade.GroupByBoxVisible = False
        Me.grdDisponibilidade.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdDisponibilidade.Location = New System.Drawing.Point(14, 16)
        Me.grdDisponibilidade.Name = "grdDisponibilidade"
        Me.grdDisponibilidade.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDisponibilidade.RecordNavigator = True
        Me.grdDisponibilidade.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdDisponibilidade.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDisponibilidade.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDisponibilidade.Size = New System.Drawing.Size(895, 299)
        Me.grdDisponibilidade.TabIndex = 8
        Me.grdDisponibilidade.TabStop = False
        Me.grdDisponibilidade.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdDisponibilidade.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdDisponibilidade.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDisponibilidade.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDisponibilidade.VisualStyleManager = Me.vsmMain
        '
        'pagOrcamento
        '
        Me.pagOrcamento.Controls.Add(Me.grdOrcamento)
        Me.pagOrcamento.Controls.Add(Me.grpOrcamento)
        Me.pagOrcamento.Controls.Add(Me.grdOrcamentoOperacao)
        Me.pagOrcamento.Location = New System.Drawing.Point(1, 22)
        Me.pagOrcamento.Name = "pagOrcamento"
        Me.pagOrcamento.Size = New System.Drawing.Size(923, 335)
        Me.pagOrcamento.TabStop = True
        Me.pagOrcamento.Text = "Incluir Orçamento"
        '
        'grdOrcamento
        '
        Me.grdOrcamento.AlternatingColors = True
        Me.grdOrcamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdOrcamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdOrcamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdOrcamento_DesignTimeLayout_Reference_0})
        grdOrcamento_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamento_DesignTimeLayout.LayoutString")
        Me.grdOrcamento.DesignTimeLayout = grdOrcamento_DesignTimeLayout
        Me.grdOrcamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdOrcamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamento.GroupByBoxVisible = False
        Me.grdOrcamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamento.Location = New System.Drawing.Point(10, 85)
        Me.grdOrcamento.Name = "grdOrcamento"
        Me.grdOrcamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamento.RecordNavigator = True
        Me.grdOrcamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamento.Size = New System.Drawing.Size(568, 242)
        Me.grdOrcamento.TabIndex = 12
        Me.grdOrcamento.TabStop = False
        Me.grdOrcamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamento.VisualStyleManager = Me.vsmMain
        '
        'grpOrcamento
        '
        Me.grpOrcamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.grpOrcamento.Controls.Add(Me.dtpDataEntregaOrcamento)
        Me.grpOrcamento.Controls.Add(Me.lblDataEntregaOrcamento)
        Me.grpOrcamento.Controls.Add(Me.btnInserirOrcamento)
        Me.grpOrcamento.Controls.Add(Me.cboOrcamento)
        Me.grpOrcamento.Controls.Add(Me.lblOrcamento)
        Me.grpOrcamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpOrcamento.Location = New System.Drawing.Point(11, 8)
        Me.grpOrcamento.Name = "grpOrcamento"
        Me.grpOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOrcamento.Size = New System.Drawing.Size(567, 71)
        Me.grpOrcamento.TabIndex = 11
        Me.grpOrcamento.Text = "Inserir Orçamento"
        Me.grpOrcamento.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpOrcamento.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEntregaOrcamento
        '
        Me.dtpDataEntregaOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEntregaOrcamento.DropDownCalendar.Name = ""
        Me.dtpDataEntregaOrcamento.Location = New System.Drawing.Point(346, 34)
        Me.dtpDataEntregaOrcamento.Name = "dtpDataEntregaOrcamento"
        Me.dtpDataEntregaOrcamento.Size = New System.Drawing.Size(88, 20)
        Me.dtpDataEntregaOrcamento.TabIndex = 31
        Me.dtpDataEntregaOrcamento.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntregaOrcamento
        '
        Me.lblDataEntregaOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEntregaOrcamento.AutoSize = True
        Me.lblDataEntregaOrcamento.Location = New System.Drawing.Point(343, 17)
        Me.lblDataEntregaOrcamento.Name = "lblDataEntregaOrcamento"
        Me.lblDataEntregaOrcamento.Size = New System.Drawing.Size(96, 16)
        Me.lblDataEntregaOrcamento.TabIndex = 32
        Me.lblDataEntregaOrcamento.Text = "Data Entrega:"
        '
        'btnInserirOrcamento
        '
        Me.btnInserirOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirOrcamento.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnInserirOrcamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirOrcamento.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnInserirOrcamento.Location = New System.Drawing.Point(440, 31)
        Me.btnInserirOrcamento.Name = "btnInserirOrcamento"
        Me.btnInserirOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirOrcamento.Size = New System.Drawing.Size(121, 23)
        Me.btnInserirOrcamento.TabIndex = 30
        Me.btnInserirOrcamento.Text = "Inserir"
        Me.btnInserirOrcamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboOrcamento
        '
        Me.cboOrcamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOrcamento.AutoSize = False
        Me.cboOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboOrcamento.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboOrcamento.Location = New System.Drawing.Point(9, 34)
        Me.cboOrcamento.Name = "cboOrcamento"
        Me.cboOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrcamento.Size = New System.Drawing.Size(331, 20)
        Me.cboOrcamento.TabIndex = 29
        '
        'lblOrcamento
        '
        Me.lblOrcamento.AutoSize = True
        Me.lblOrcamento.Location = New System.Drawing.Point(6, 17)
        Me.lblOrcamento.Name = "lblOrcamento"
        Me.lblOrcamento.Size = New System.Drawing.Size(100, 16)
        Me.lblOrcamento.TabIndex = 2
        Me.lblOrcamento.Text = "Nº Orçamento:"
        '
        'grdOrcamentoOperacao
        '
        Me.grdOrcamentoOperacao.AlternatingColors = True
        Me.grdOrcamentoOperacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoOperacao_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoOperacao_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoOperacao.DesignTimeLayout = grdOrcamentoOperacao_DesignTimeLayout
        Me.grdOrcamentoOperacao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamentoOperacao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoOperacao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdOrcamentoOperacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoOperacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoOperacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoOperacao.GroupByBoxVisible = False
        Me.grdOrcamentoOperacao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamentoOperacao.Location = New System.Drawing.Point(584, 8)
        Me.grdOrcamentoOperacao.Name = "grdOrcamentoOperacao"
        Me.grdOrcamentoOperacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoOperacao.RecordNavigator = True
        Me.grdOrcamentoOperacao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoOperacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoOperacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoOperacao.Size = New System.Drawing.Size(331, 319)
        Me.grdOrcamentoOperacao.TabIndex = 10
        Me.grdOrcamentoOperacao.TabStop = False
        Me.grdOrcamentoOperacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoOperacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoOperacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoOperacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoOperacao.VisualStyleManager = Me.vsmMain
        '
        'pagNecessidade
        '
        Me.pagNecessidade.Controls.Add(Me.grdNecessidade)
        Me.pagNecessidade.Location = New System.Drawing.Point(1, 24)
        Me.pagNecessidade.Name = "pagNecessidade"
        Me.pagNecessidade.Size = New System.Drawing.Size(923, 331)
        Me.pagNecessidade.TabStop = True
        Me.pagNecessidade.Text = "Necessidade"
        '
        'grdNecessidade
        '
        Me.grdNecessidade.AlternatingColors = True
        Me.grdNecessidade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdNecessidade_DesignTimeLayout.LayoutString = resources.GetString("grdNecessidade_DesignTimeLayout.LayoutString")
        Me.grdNecessidade.DesignTimeLayout = grdNecessidade_DesignTimeLayout
        Me.grdNecessidade.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdNecessidade.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdNecessidade.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdNecessidade.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNecessidade.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNecessidade.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNecessidade.GroupByBoxVisible = False
        Me.grdNecessidade.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdNecessidade.Hierarchical = True
        Me.grdNecessidade.Location = New System.Drawing.Point(16, 10)
        Me.grdNecessidade.Name = "grdNecessidade"
        Me.grdNecessidade.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNecessidade.RecordNavigator = True
        Me.grdNecessidade.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdNecessidade.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdNecessidade.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdNecessidade.Size = New System.Drawing.Size(895, 299)
        Me.grdNecessidade.TabIndex = 7
        Me.grdNecessidade.TabStop = False
        Me.grdNecessidade.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNecessidade.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdNecessidade.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNecessidade.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNecessidade.VisualStyleManager = Me.vsmMain
        '
        'pagCargaMaquina
        '
        Me.pagCargaMaquina.Controls.Add(Me.grdCargaMaquina)
        Me.pagCargaMaquina.Location = New System.Drawing.Point(1, 24)
        Me.pagCargaMaquina.Name = "pagCargaMaquina"
        Me.pagCargaMaquina.Size = New System.Drawing.Size(923, 331)
        Me.pagCargaMaquina.TabStop = True
        Me.pagCargaMaquina.Text = "Carga Máquina"
        '
        'grdCargaMaquina
        '
        Me.grdCargaMaquina.AlternatingColors = True
        Me.grdCargaMaquina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdCargaMaquina_DesignTimeLayout.LayoutString = resources.GetString("grdCargaMaquina_DesignTimeLayout.LayoutString")
        Me.grdCargaMaquina.DesignTimeLayout = grdCargaMaquina_DesignTimeLayout
        Me.grdCargaMaquina.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCargaMaquina.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCargaMaquina.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdCargaMaquina.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCargaMaquina.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCargaMaquina.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCargaMaquina.GroupByBoxVisible = False
        Me.grdCargaMaquina.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdCargaMaquina.Location = New System.Drawing.Point(14, 16)
        Me.grdCargaMaquina.Name = "grdCargaMaquina"
        Me.grdCargaMaquina.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCargaMaquina.RecordNavigator = True
        Me.grdCargaMaquina.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdCargaMaquina.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCargaMaquina.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCargaMaquina.Size = New System.Drawing.Size(895, 299)
        Me.grdCargaMaquina.TabIndex = 9
        Me.grdCargaMaquina.TabStop = False
        Me.grdCargaMaquina.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCargaMaquina.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCargaMaquina.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCargaMaquina.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCargaMaquina.VisualStyleManager = Me.vsmMain
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.btnExcel)
        Me.grpEntrega.Controls.Add(Me.btnSair)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(7, 481)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(925, 52)
        Me.grpEntrega.TabIndex = 2
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(728, 19)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(825, 19)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataEntregaInicio)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntregaTermino)
        Me.grpFiltro.Controls.Add(Me.lblDataEntregaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtOrdemProducaoDesconsiderar)
        Me.grpFiltro.Controls.Add(Me.lblOrdemProducaoDesconsiderar)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.chkIncluirDomingo)
        Me.grpFiltro.Controls.Add(Me.chkIncluirSabado)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(7, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(925, 110)
        Me.grpFiltro.TabIndex = 1
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
        Me.cboStatusFiltro.Location = New System.Drawing.Point(15, 72)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(887, 23)
        Me.cboStatusFiltro.TabIndex = 56
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(12, 55)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(52, 16)
        Me.lblStatusFiltro.TabIndex = 55
        Me.lblStatusFiltro.Text = "Status:"
        '
        'txtOrdemProducaoDesconsiderar
        '
        Me.txtOrdemProducaoDesconsiderar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOrdemProducaoDesconsiderar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducaoDesconsiderar.Location = New System.Drawing.Point(471, 33)
        Me.txtOrdemProducaoDesconsiderar.MaxLength = 60
        Me.txtOrdemProducaoDesconsiderar.Name = "txtOrdemProducaoDesconsiderar"
        Me.txtOrdemProducaoDesconsiderar.Size = New System.Drawing.Size(176, 23)
        Me.txtOrdemProducaoDesconsiderar.TabIndex = 54
        '
        'lblOrdemProducaoDesconsiderar
        '
        Me.lblOrdemProducaoDesconsiderar.AutoSize = True
        Me.lblOrdemProducaoDesconsiderar.Location = New System.Drawing.Point(468, 14)
        Me.lblOrdemProducaoDesconsiderar.Name = "lblOrdemProducaoDesconsiderar"
        Me.lblOrdemProducaoDesconsiderar.Size = New System.Drawing.Size(382, 16)
        Me.lblOrdemProducaoDesconsiderar.TabIndex = 53
        Me.lblOrdemProducaoDesconsiderar.Text = "Desconsiderar Ordem de Produção (separado por vírgula):"
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(15, 33)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataInicioFiltro.TabIndex = 51
        Me.dtpDataInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(129, 33)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataTerminoFiltro.TabIndex = 52
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataProducaoFiltro
        '
        Me.lblDataProducaoFiltro.AutoSize = True
        Me.lblDataProducaoFiltro.Location = New System.Drawing.Point(12, 16)
        Me.lblDataProducaoFiltro.Name = "lblDataProducaoFiltro"
        Me.lblDataProducaoFiltro.Size = New System.Drawing.Size(107, 16)
        Me.lblDataProducaoFiltro.TabIndex = 50
        Me.lblDataProducaoFiltro.Text = "Data Produção:"
        '
        'chkIncluirDomingo
        '
        Me.chkIncluirDomingo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncluirDomingo.Location = New System.Drawing.Point(675, 36)
        Me.chkIncluirDomingo.Name = "chkIncluirDomingo"
        Me.chkIncluirDomingo.Size = New System.Drawing.Size(113, 17)
        Me.chkIncluirDomingo.TabIndex = 49
        Me.chkIncluirDomingo.TabStop = False
        Me.chkIncluirDomingo.Text = "Incluir Domingo"
        '
        'chkIncluirSabado
        '
        Me.chkIncluirSabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIncluirSabado.Location = New System.Drawing.Point(675, 16)
        Me.chkIncluirSabado.Name = "chkIncluirSabado"
        Me.chkIncluirSabado.Size = New System.Drawing.Size(113, 17)
        Me.chkIncluirSabado.TabIndex = 48
        Me.chkIncluirSabado.TabStop = False
        Me.chkIncluirSabado.Text = "Incluir Sábado"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(811, 30)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 8
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(50, 368)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 15)
        Me.Button1.TabIndex = 94
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(26, 368)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 15)
        Me.Button2.TabIndex = 93
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(2, 368)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 2
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'btnExcelGridServico
        '
        Me.btnExcelGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridServico.FlatAppearance.BorderSize = 0
        Me.btnExcelGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridServico.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridServico.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridServico.Name = "btnExcelGridServico"
        Me.btnExcelGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridServico.TabIndex = 96
        Me.btnExcelGridServico.TabStop = False
        Me.btnExcelGridServico.UseVisualStyleBackColor = False
        '
        'btnAgruparGridServico
        '
        Me.btnAgruparGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridServico.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridServico.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridServico.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridServico.Name = "btnAgruparGridServico"
        Me.btnAgruparGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridServico.TabIndex = 95
        Me.btnAgruparGridServico.TabStop = False
        Me.btnAgruparGridServico.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridServico
        '
        Me.btnConfigurarGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridServico.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridServico.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridServico.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridServico.Name = "btnConfigurarGridServico"
        Me.btnConfigurarGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridServico.TabIndex = 2
        Me.btnConfigurarGridServico.TabStop = False
        Me.btnConfigurarGridServico.UseVisualStyleBackColor = False
        '
        'grdProduto
        '
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.AutoEdit = True
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.DynamicFiltering = True
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProduto.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.Hierarchical = True
        Me.grdProduto.Location = New System.Drawing.Point(0, 0)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(936, 385)
        Me.grdProduto.TabIndex = 95
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdProduto.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdProduto.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'GridEX1
        '
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.AutoEdit = True
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.DynamicFiltering = True
        Me.GridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.GridEX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX1.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.GridEX1.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.GridEX1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridEX1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Hierarchical = True
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.GridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridEX1.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.GridEX1.Size = New System.Drawing.Size(936, 384)
        Me.GridEX1.TabIndex = 97
        Me.GridEX1.TabStop = False
        Me.GridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.GridEX1.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.GridEX1.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridEX1.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.GridEX1.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEntregaInicio
        '
        Me.dtpDataEntregaInicio.Checked = False
        '
        '
        '
        Me.dtpDataEntregaInicio.DropDownCalendar.Name = ""
        Me.dtpDataEntregaInicio.Location = New System.Drawing.Point(243, 33)
        Me.dtpDataEntregaInicio.Name = "dtpDataEntregaInicio"
        Me.dtpDataEntregaInicio.ShowCheckBox = True
        Me.dtpDataEntregaInicio.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataEntregaInicio.TabIndex = 58
        Me.dtpDataEntregaInicio.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEntregaTermino
        '
        Me.dtpDataEntregaTermino.Checked = False
        '
        '
        '
        Me.dtpDataEntregaTermino.DropDownCalendar.Name = ""
        Me.dtpDataEntregaTermino.Location = New System.Drawing.Point(357, 33)
        Me.dtpDataEntregaTermino.Name = "dtpDataEntregaTermino"
        Me.dtpDataEntregaTermino.ShowCheckBox = True
        Me.dtpDataEntregaTermino.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataEntregaTermino.TabIndex = 59
        Me.dtpDataEntregaTermino.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntregaFiltro
        '
        Me.lblDataEntregaFiltro.AutoSize = True
        Me.lblDataEntregaFiltro.Location = New System.Drawing.Point(240, 16)
        Me.lblDataEntregaFiltro.Name = "lblDataEntregaFiltro"
        Me.lblDataEntregaFiltro.Size = New System.Drawing.Size(96, 16)
        Me.lblDataEntregaFiltro.TabIndex = 57
        Me.lblDataEntregaFiltro.Text = "Data Entrega:"
        '
        'usrPrdCargaMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdCargaMaquina"
        Me.Size = New System.Drawing.Size(946, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagMain.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDisponibilidade.ResumeLayout(False)
        CType(Me.grdDisponibilidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagOrcamento.ResumeLayout(False)
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrcamento.ResumeLayout(False)
        Me.grpOrcamento.PerformLayout()
        CType(Me.grdOrcamentoOperacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagNecessidade.ResumeLayout(False)
        CType(Me.grdNecessidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCargaMaquina.ResumeLayout(False)
        CType(Me.grdCargaMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntrega.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents pagMain As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridServico As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridServico As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridServico As System.Windows.Forms.Button
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdNecessidade As Janus.Windows.GridEX.GridEX
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagNecessidade As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDisponibilidade As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdDisponibilidade As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagCargaMaquina As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdCargaMaquina As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagOrcamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdOrcamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpOrcamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataEntregaOrcamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntregaOrcamento As System.Windows.Forms.Label
    Friend WithEvents btnInserirOrcamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboOrcamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrcamento As System.Windows.Forms.Label
    Friend WithEvents grdOrcamentoOperacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents chkIncluirDomingo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkIncluirSabado As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataProducaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducaoDesconsiderar As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducaoDesconsiderar As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEntregaInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntregaTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntregaFiltro As System.Windows.Forms.Label

End Class
