<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinReceitaInclusaoCheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinReceitaInclusaoCheque))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataPreDatadoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblNumeroFiltro = New System.Windows.Forms.Label()
        Me.lblDataPreDatadoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
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
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.dtpDataPreDatado = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPreDatado = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.btnCadastrarCliente = New System.Windows.Forms.Button()
        Me.txtNumero = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Cheques"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 4
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
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.dtpDataPreDatadoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPreDatadoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.cboClienteFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtDescricaoFiltro.MaxLength = 500
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(766, 20)
        Me.txtDescricaoFiltro.TabIndex = 9
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 8
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 70)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 10
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataPreDatadoFiltro
        '
        '
        '
        '
        Me.dtpDataPreDatadoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPreDatadoFiltro.Location = New System.Drawing.Point(257, 34)
        Me.dtpDataPreDatadoFiltro.Name = "dtpDataPreDatadoFiltro"
        Me.dtpDataPreDatadoFiltro.ShowCheckBox = True
        Me.dtpDataPreDatadoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataPreDatadoFiltro.TabIndex = 5
        '
        'lblNumeroFiltro
        '
        Me.lblNumeroFiltro.AutoSize = True
        Me.lblNumeroFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroFiltro.Name = "lblNumeroFiltro"
        Me.lblNumeroFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblNumeroFiltro.TabIndex = 0
        Me.lblNumeroFiltro.Text = "Número:"
        '
        'lblDataPreDatadoFiltro
        '
        Me.lblDataPreDatadoFiltro.AutoSize = True
        Me.lblDataPreDatadoFiltro.Location = New System.Drawing.Point(254, 17)
        Me.lblDataPreDatadoFiltro.Name = "lblDataPreDatadoFiltro"
        Me.lblDataPreDatadoFiltro.Size = New System.Drawing.Size(88, 14)
        Me.lblDataPreDatadoFiltro.TabIndex = 4
        Me.lblDataPreDatadoFiltro.Text = "Data Pré Datado:"
        '
        'txtNumeroFiltro
        '
        Me.txtNumeroFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroFiltro.MaxLength = 500
        Me.txtNumeroFiltro.Name = "txtNumeroFiltro"
        Me.txtNumeroFiltro.Size = New System.Drawing.Size(137, 20)
        Me.txtNumeroFiltro.TabIndex = 1
        '
        'dtpDataFiltro
        '
        '
        '
        '
        Me.dtpDataFiltro.DropDownCalendar.Name = ""
        Me.dtpDataFiltro.Location = New System.Drawing.Point(152, 34)
        Me.dtpDataFiltro.Name = "dtpDataFiltro"
        Me.dtpDataFiltro.ShowCheckBox = True
        Me.dtpDataFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataFiltro.TabIndex = 3
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(359, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 6
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(149, 17)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 2
        Me.lblDataFiltro.Text = "Data:"
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClienteFiltro.AutoSize = False
        Me.cboClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFiltro.Location = New System.Drawing.Point(362, 34)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(413, 20)
        Me.cboClienteFiltro.TabIndex = 7
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.CellToolTipText = "Duplo clique para editar o registro"
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 274)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
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
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
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
        Me.btnNovo1.TabIndex = 2
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
        Me.btnSair.TabIndex = 4
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
        Me.btnExcluir.TabIndex = 3
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
        Me.pagDados.Text = "Dados Cheque"
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
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.txtValor)
        Me.grpDados.Controls.Add(Me.lblValor)
        Me.grpDados.Controls.Add(Me.dtpDataPreDatado)
        Me.grpDados.Controls.Add(Me.lblDataPreDatado)
        Me.grpDados.Controls.Add(Me.dtpData)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.cboCliente)
        Me.grpDados.Controls.Add(Me.lblCliente)
        Me.grpDados.Controls.Add(Me.btnProcurarCliente)
        Me.grpDados.Controls.Add(Me.btnCadastrarCliente)
        Me.grpDados.Controls.Add(Me.txtNumero)
        Me.grpDados.Controls.Add(Me.lblNumero)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(152, 74)
        Me.txtDescricao.MaxLength = 500
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(662, 20)
        Me.txtDescricao.TabIndex = 13
        '
        'lblDescricao
        '
        Me.lblDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(149, 57)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 12
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtValor
        '
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(9, 74)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(137, 20)
        Me.txtValor.TabIndex = 11
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(6, 57)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 10
        Me.lblValor.Text = "Valor:"
        '
        'dtpDataPreDatado
        '
        '
        '
        '
        Me.dtpDataPreDatado.DropDownCalendar.Name = ""
        Me.dtpDataPreDatado.Location = New System.Drawing.Point(257, 34)
        Me.dtpDataPreDatado.Name = "dtpDataPreDatado"
        Me.dtpDataPreDatado.ShowCheckBox = True
        Me.dtpDataPreDatado.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataPreDatado.TabIndex = 5
        '
        'lblDataPreDatado
        '
        Me.lblDataPreDatado.AutoSize = True
        Me.lblDataPreDatado.Location = New System.Drawing.Point(254, 17)
        Me.lblDataPreDatado.Name = "lblDataPreDatado"
        Me.lblDataPreDatado.Size = New System.Drawing.Size(88, 14)
        Me.lblDataPreDatado.TabIndex = 4
        Me.lblDataPreDatado.Text = "Data Pré Datado:"
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(152, 34)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.ShowCheckBox = True
        Me.dtpData.Size = New System.Drawing.Size(99, 20)
        Me.dtpData.TabIndex = 2
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(149, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data:"
        '
        'cboCliente
        '
        Me.cboCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(362, 34)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(452, 20)
        Me.cboCliente.TabIndex = 8
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(378, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Cliente:"
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(797, 16)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 9
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCliente.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCliente.Location = New System.Drawing.Point(362, 18)
        Me.btnCadastrarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCliente.TabIndex = 6
        Me.btnCadastrarCliente.TabStop = False
        Me.btnCadastrarCliente.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Location = New System.Drawing.Point(9, 34)
        Me.txtNumero.MaxLength = 500
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(137, 20)
        Me.txtNumero.TabIndex = 1
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(6, 17)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 14)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Número:"
        '
        'usrFinReceitaInclusaoCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinReceitaInclusaoCheque"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtNumero As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCliente As System.Windows.Forms.Button
    Friend WithEvents dtpDataPreDatado As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPreDatado As System.Windows.Forms.Label
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataPreDatadoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblNumeroFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataPreDatadoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox

End Class
