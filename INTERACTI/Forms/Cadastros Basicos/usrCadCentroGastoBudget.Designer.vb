<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadCentroGastoBudget
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadCentroGastoBudget))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdValores_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdValores_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaAprovada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaReprovada = New System.Windows.Forms.Label()
        Me.picLegendaReprovada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAprovada = New System.Windows.Forms.Label()
        Me.picLegendaAguardandoAprovacao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAguardandoAprovada = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCentroGastoFiltro = New System.Windows.Forms.Button()
        Me.cboCentroGastoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepartamentoFiltro = New System.Windows.Forms.Label()
        Me.cboDepartamentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGastroFiltro = New System.Windows.Forms.Label()
        Me.txtRevisaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRevisaoFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoBudgetFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoBudgetFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataTermino = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtRevisao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRevisao = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagValores = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridValores = New System.Windows.Forms.Button()
        Me.grpDadosLinha = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.btnCadastrarDepartamento = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.cboDepartamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.btnExcluirLinha = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirLinha = New Janus.Windows.EditControls.UIButton()
        Me.btnAgruparGridValores = New System.Windows.Forms.Button()
        Me.btnConfiguraGridValores = New System.Windows.Forms.Button()
        Me.grdValores = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaAprovada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaReprovada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAguardandoAprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagValores.SuspendLayout()
        CType(Me.grpDadosLinha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosLinha.SuspendLayout()
        CType(Me.grdValores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Centro de Gasto - Budget"
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
        Me.btnExcelGrid.TabIndex = 70
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
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
        Me.btnAgruparGrid.TabIndex = 69
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
        Me.btnConfigurarGrid.TabIndex = 68
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaAprovada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaReprovada)
        Me.grpLegenda.Controls.Add(Me.picLegendaReprovada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAprovada)
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoAprovacao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoAprovada)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 393)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(321, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaAprovada
        '
        Me.picLegendaAprovada.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaAprovada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAprovada.Location = New System.Drawing.Point(157, 21)
        Me.picLegendaAprovada.Name = "picLegendaAprovada"
        Me.picLegendaAprovada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAprovada.TabIndex = 12
        Me.picLegendaAprovada.TabStop = False
        '
        'lblLegendaReprovada
        '
        Me.lblLegendaReprovada.AutoSize = True
        Me.lblLegendaReprovada.Location = New System.Drawing.Point(256, 21)
        Me.lblLegendaReprovada.Name = "lblLegendaReprovada"
        Me.lblLegendaReprovada.Size = New System.Drawing.Size(60, 14)
        Me.lblLegendaReprovada.TabIndex = 1
        Me.lblLegendaReprovada.Text = "Reprovada"
        '
        'picLegendaReprovada
        '
        Me.picLegendaReprovada.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaReprovada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaReprovada.Location = New System.Drawing.Point(237, 21)
        Me.picLegendaReprovada.Name = "picLegendaReprovada"
        Me.picLegendaReprovada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaReprovada.TabIndex = 8
        Me.picLegendaReprovada.TabStop = False
        '
        'lblLegendaAprovada
        '
        Me.lblLegendaAprovada.AutoSize = True
        Me.lblLegendaAprovada.Location = New System.Drawing.Point(176, 21)
        Me.lblLegendaAprovada.Name = "lblLegendaAprovada"
        Me.lblLegendaAprovada.Size = New System.Drawing.Size(55, 14)
        Me.lblLegendaAprovada.TabIndex = 0
        Me.lblLegendaAprovada.Text = "Aprovada"
        '
        'picLegendaAguardandoAprovacao
        '
        Me.picLegendaAguardandoAprovacao.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaAguardandoAprovacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoAprovacao.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaAguardandoAprovacao.Name = "picLegendaAguardandoAprovacao"
        Me.picLegendaAguardandoAprovacao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAguardandoAprovacao.TabIndex = 14
        Me.picLegendaAguardandoAprovacao.TabStop = False
        '
        'lblLegendaAguardandoAprovada
        '
        Me.lblLegendaAguardandoAprovada.AutoSize = True
        Me.lblLegendaAguardandoAprovada.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaAguardandoAprovada.Name = "lblLegendaAguardandoAprovada"
        Me.lblLegendaAguardandoAprovada.Size = New System.Drawing.Size(123, 14)
        Me.lblLegendaAguardandoAprovada.TabIndex = 13
        Me.lblLegendaAguardandoAprovada.Text = "Aguardando Aprovação"
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
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 274)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarCentroGastoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCentroGastoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDepartamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboDepartamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCentroGastroFiltro)
        Me.grpFiltro.Controls.Add(Me.txtRevisaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRevisaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoBudgetFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoBudgetFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCentroGastoFiltro
        '
        Me.btnProcurarCentroGastoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCentroGastoFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGastoFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGastoFiltro.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarCentroGastoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGastoFiltro.Location = New System.Drawing.Point(329, 56)
        Me.btnProcurarCentroGastoFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGastoFiltro.Name = "btnProcurarCentroGastoFiltro"
        Me.btnProcurarCentroGastoFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGastoFiltro.TabIndex = 7
        Me.btnProcurarCentroGastoFiltro.TabStop = False
        Me.btnProcurarCentroGastoFiltro.UseVisualStyleBackColor = True
        '
        'cboCentroGastoFiltro
        '
        Me.cboCentroGastoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroGastoFiltro.AutoSize = False
        Me.cboCentroGastoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGastoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboCentroGastoFiltro.Name = "cboCentroGastoFiltro"
        Me.cboCentroGastoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGastoFiltro.Size = New System.Drawing.Size(337, 20)
        Me.cboCentroGastoFiltro.TabIndex = 8
        '
        'lblDepartamentoFiltro
        '
        Me.lblDepartamentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDepartamentoFiltro.AutoSize = True
        Me.lblDepartamentoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepartamentoFiltro.Location = New System.Drawing.Point(349, 57)
        Me.lblDepartamentoFiltro.Name = "lblDepartamentoFiltro"
        Me.lblDepartamentoFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblDepartamentoFiltro.TabIndex = 9
        Me.lblDepartamentoFiltro.Text = "Departamento:"
        '
        'cboDepartamentoFiltro
        '
        Me.cboDepartamentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDepartamentoFiltro.AutoSize = False
        Me.cboDepartamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepartamentoFiltro.Location = New System.Drawing.Point(352, 74)
        Me.cboDepartamentoFiltro.Name = "cboDepartamentoFiltro"
        Me.cboDepartamentoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepartamentoFiltro.Size = New System.Drawing.Size(325, 20)
        Me.cboDepartamentoFiltro.TabIndex = 10
        '
        'lblCentroGastroFiltro
        '
        Me.lblCentroGastroFiltro.AutoSize = True
        Me.lblCentroGastroFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCentroGastroFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblCentroGastroFiltro.Name = "lblCentroGastroFiltro"
        Me.lblCentroGastroFiltro.Size = New System.Drawing.Size(74, 14)
        Me.lblCentroGastroFiltro.TabIndex = 6
        Me.lblCentroGastroFiltro.Text = "Centro Gasto:"
        '
        'txtRevisaoFiltro
        '
        Me.txtRevisaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRevisaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisaoFiltro.Location = New System.Drawing.Point(607, 34)
        Me.txtRevisaoFiltro.MaxLength = 20
        Me.txtRevisaoFiltro.Name = "txtRevisaoFiltro"
        Me.txtRevisaoFiltro.Size = New System.Drawing.Size(70, 20)
        Me.txtRevisaoFiltro.TabIndex = 5
        '
        'lblRevisaoFiltro
        '
        Me.lblRevisaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevisaoFiltro.AutoSize = True
        Me.lblRevisaoFiltro.Location = New System.Drawing.Point(604, 17)
        Me.lblRevisaoFiltro.Name = "lblRevisaoFiltro"
        Me.lblRevisaoFiltro.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoFiltro.TabIndex = 4
        Me.lblRevisaoFiltro.Text = "Revisão:"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(125, 34)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(476, 20)
        Me.txtDescricaoFiltro.TabIndex = 3
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(122, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 2
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'txtCodigoBudgetFiltro
        '
        Me.txtCodigoBudgetFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBudgetFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigoBudgetFiltro.MaxLength = 20
        Me.txtCodigoBudgetFiltro.Name = "txtCodigoBudgetFiltro"
        Me.txtCodigoBudgetFiltro.Size = New System.Drawing.Size(110, 20)
        Me.txtCodigoBudgetFiltro.TabIndex = 1
        '
        'lblCodigoBudgetFiltro
        '
        Me.lblCodigoBudgetFiltro.AutoSize = True
        Me.lblCodigoBudgetFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoBudgetFiltro.Name = "lblCodigoBudgetFiltro"
        Me.lblCodigoBudgetFiltro.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoBudgetFiltro.TabIndex = 0
        Me.lblCodigoBudgetFiltro.Text = "Código:"
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
        Me.btnFiltrar.TabIndex = 11
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
        Me.grpControl.Location = New System.Drawing.Point(338, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(567, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(273, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(467, 17)
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
        Me.btnExcluir.Location = New System.Drawing.Point(370, 17)
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
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Centro de Gasto - Budget"
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
        Me.grpDados.Controls.Add(Me.dtpDataTermino)
        Me.grpDados.Controls.Add(Me.lblDataTermino)
        Me.grpDados.Controls.Add(Me.dtpDataInicio)
        Me.grpDados.Controls.Add(Me.lblDataInicio)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.txtRevisao)
        Me.grpDados.Controls.Add(Me.lblRevisao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'dtpDataTermino
        '
        Me.dtpDataTermino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(789, 34)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataTermino.TabIndex = 9
        Me.dtpDataTermino.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataTermino
        '
        Me.lblDataTermino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataTermino.AutoSize = True
        Me.lblDataTermino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataTermino.Location = New System.Drawing.Point(786, 17)
        Me.lblDataTermino.Name = "lblDataTermino"
        Me.lblDataTermino.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTermino.TabIndex = 8
        Me.lblDataTermino.Text = "Data Término:"
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(683, 34)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataInicio.TabIndex = 7
        Me.dtpDataInicio.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataInicio
        '
        Me.lblDataInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataInicio.Location = New System.Drawing.Point(680, 17)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicio.TabIndex = 6
        Me.lblDataInicio.Text = "Data Início:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(125, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(476, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(122, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(110, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtRevisao
        '
        Me.txtRevisao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRevisao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtRevisao.Location = New System.Drawing.Point(607, 34)
        Me.txtRevisao.MaxLength = 20
        Me.txtRevisao.Name = "txtRevisao"
        Me.txtRevisao.ReadOnly = True
        Me.txtRevisao.Size = New System.Drawing.Size(70, 20)
        Me.txtRevisao.TabIndex = 5
        Me.txtRevisao.TabStop = False
        Me.txtRevisao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblRevisao
        '
        Me.lblRevisao.AutoSize = True
        Me.lblRevisao.Location = New System.Drawing.Point(604, 17)
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisao.TabIndex = 4
        Me.lblRevisao.Text = "Revisão:"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 73)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 317)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagValores})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagValores
        '
        Me.pagValores.Controls.Add(Me.btnExcelGridValores)
        Me.pagValores.Controls.Add(Me.grpDadosLinha)
        Me.pagValores.Controls.Add(Me.btnAgruparGridValores)
        Me.pagValores.Controls.Add(Me.btnConfiguraGridValores)
        Me.pagValores.Controls.Add(Me.grdValores)
        Me.pagValores.Key = "pagValores"
        Me.pagValores.Location = New System.Drawing.Point(1, 22)
        Me.pagValores.Name = "pagValores"
        Me.pagValores.Size = New System.Drawing.Size(895, 294)
        Me.pagValores.TabStop = True
        Me.pagValores.Text = "Valores"
        '
        'btnExcelGridValores
        '
        Me.btnExcelGridValores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridValores.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridValores.FlatAppearance.BorderSize = 0
        Me.btnExcelGridValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridValores.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridValores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridValores.Location = New System.Drawing.Point(57, 269)
        Me.btnExcelGridValores.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridValores.Name = "btnExcelGridValores"
        Me.btnExcelGridValores.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridValores.TabIndex = 73
        Me.btnExcelGridValores.TabStop = False
        Me.btnExcelGridValores.UseVisualStyleBackColor = False
        '
        'grpDadosLinha
        '
        Me.grpDadosLinha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosLinha.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosLinha.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpDadosLinha.Controls.Add(Me.btnCadastrarDepartamento)
        Me.grpDadosLinha.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpDadosLinha.Controls.Add(Me.lblValor)
        Me.grpDadosLinha.Controls.Add(Me.txtValor)
        Me.grpDadosLinha.Controls.Add(Me.cboCentroGasto)
        Me.grpDadosLinha.Controls.Add(Me.lblDepartamento)
        Me.grpDadosLinha.Controls.Add(Me.cboDepartamento)
        Me.grpDadosLinha.Controls.Add(Me.lblCentroGasto)
        Me.grpDadosLinha.Controls.Add(Me.btnExcluirLinha)
        Me.grpDadosLinha.Controls.Add(Me.btnInserirLinha)
        Me.grpDadosLinha.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosLinha.Name = "grpDadosLinha"
        Me.grpDadosLinha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosLinha.Size = New System.Drawing.Size(879, 64)
        Me.grpDadosLinha.TabIndex = 0
        Me.grpDadosLinha.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosLinha.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(221, 16)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 2
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnCadastrarDepartamento
        '
        Me.btnCadastrarDepartamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarDepartamento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDepartamento.Image = CType(resources.GetObject("btnCadastrarDepartamento.Image"), System.Drawing.Image)
        Me.btnCadastrarDepartamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDepartamento.Location = New System.Drawing.Point(244, 18)
        Me.btnCadastrarDepartamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDepartamento.Name = "btnCadastrarDepartamento"
        Me.btnCadastrarDepartamento.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDepartamento.TabIndex = 4
        Me.btnCadastrarDepartamento.TabStop = False
        Me.btnCadastrarDepartamento.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = CType(resources.GetObject("btnCadastrarCentroGasto.Image"), System.Drawing.Image)
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 0
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'lblValor
        '
        Me.lblValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValor.AutoSize = True
        Me.lblValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValor.Location = New System.Drawing.Point(571, 17)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 7
        Me.lblValor.Text = "Valor:"
        '
        'txtValor
        '
        Me.txtValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor.Location = New System.Drawing.Point(574, 34)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(93, 20)
        Me.txtValor.TabIndex = 8
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(9, 34)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(229, 20)
        Me.cboCentroGasto.TabIndex = 3
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepartamento.Location = New System.Drawing.Point(260, 17)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 14)
        Me.lblDepartamento.TabIndex = 5
        Me.lblDepartamento.Text = "Departamento:"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDepartamento.AutoSize = False
        Me.cboDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepartamento.Location = New System.Drawing.Point(244, 34)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepartamento.Size = New System.Drawing.Size(324, 20)
        Me.cboDepartamento.TabIndex = 6
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCentroGasto.Location = New System.Drawing.Point(25, 17)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(74, 14)
        Me.lblCentroGasto.TabIndex = 1
        Me.lblCentroGasto.Text = "Centro Gasto:"
        '
        'btnExcluirLinha
        '
        Me.btnExcluirLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirLinha.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirLinha.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirLinha.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirLinha.Location = New System.Drawing.Point(779, 31)
        Me.btnExcluirLinha.Name = "btnExcluirLinha"
        Me.btnExcluirLinha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirLinha.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirLinha.TabIndex = 10
        Me.btnExcluirLinha.Text = "Excluir"
        Me.btnExcluirLinha.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirLinha
        '
        Me.btnInserirLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirLinha.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirLinha.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirLinha.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirLinha.Location = New System.Drawing.Point(682, 31)
        Me.btnInserirLinha.Name = "btnInserirLinha"
        Me.btnInserirLinha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirLinha.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirLinha.TabIndex = 9
        Me.btnInserirLinha.Text = "Inserir"
        Me.btnInserirLinha.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAgruparGridValores
        '
        Me.btnAgruparGridValores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridValores.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridValores.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridValores.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridValores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridValores.Location = New System.Drawing.Point(33, 269)
        Me.btnAgruparGridValores.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridValores.Name = "btnAgruparGridValores"
        Me.btnAgruparGridValores.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridValores.TabIndex = 72
        Me.btnAgruparGridValores.TabStop = False
        Me.btnAgruparGridValores.UseVisualStyleBackColor = False
        '
        'btnConfiguraGridValores
        '
        Me.btnConfiguraGridValores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGridValores.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGridValores.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGridValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGridValores.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfiguraGridValores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGridValores.Location = New System.Drawing.Point(9, 269)
        Me.btnConfiguraGridValores.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGridValores.Name = "btnConfiguraGridValores"
        Me.btnConfiguraGridValores.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGridValores.TabIndex = 71
        Me.btnConfiguraGridValores.TabStop = False
        Me.btnConfiguraGridValores.UseVisualStyleBackColor = False
        '
        'grdValores
        '
        Me.grdValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdValores.AlternatingColors = True
        Me.grdValores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdValores.ColumnAutoResize = True
        grdValores_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdValores_DesignTimeLayout_Reference_0.Instance"), Object)
        grdValores_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdValores_DesignTimeLayout_Reference_0})
        grdValores_DesignTimeLayout.LayoutString = resources.GetString("grdValores_DesignTimeLayout.LayoutString")
        Me.grdValores.DesignTimeLayout = grdValores_DesignTimeLayout
        Me.grdValores.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdValores.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdValores.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdValores.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdValores.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdValores.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdValores.GroupByBoxVisible = False
        Me.grdValores.Location = New System.Drawing.Point(8, 76)
        Me.grdValores.Name = "grdValores"
        Me.grdValores.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdValores.RecordNavigator = True
        Me.grdValores.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdValores.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdValores.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdValores.Size = New System.Drawing.Size(879, 210)
        Me.grdValores.TabIndex = 1
        Me.grdValores.TabStop = False
        Me.grdValores.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdValores.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdValores.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdValores.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdValores.VisualStyleManager = Me.vsmMain
        '
        'usrCadCentroGastoBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadCentroGastoBudget"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaAprovada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaReprovada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAguardandoAprovacao, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagValores.ResumeLayout(False)
        CType(Me.grpDadosLinha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosLinha.ResumeLayout(False)
        Me.grpDadosLinha.PerformLayout()
        CType(Me.grdValores, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBudgetFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoBudgetFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataTermino As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagValores As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosLinha As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents cboDepartamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents btnExcluirLinha As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirLinha As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdValores As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtRevisaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRevisaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtRevisao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRevisao As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarDepartamento As System.Windows.Forms.Button
    Friend WithEvents cboCentroGastoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepartamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboDepartamentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGastroFiltro As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCentroGastoFiltro As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaAprovada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaReprovada As System.Windows.Forms.Label
    Friend WithEvents picLegendaReprovada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAprovada As System.Windows.Forms.Label
    Friend WithEvents picLegendaAguardandoAprovacao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAguardandoAprovada As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridValores As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridValores As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGridValores As System.Windows.Forms.Button

End Class
