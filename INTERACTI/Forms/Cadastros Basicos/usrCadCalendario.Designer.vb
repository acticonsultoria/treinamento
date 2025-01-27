<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadCalendario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadCalendario))
        Dim grdListagemData_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagemData_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAnoFiltro = New System.Windows.Forms.Label()
        Me.cboAnoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridData = New System.Windows.Forms.Button()
        Me.btnAgruparGridData = New System.Windows.Forms.Button()
        Me.btnConfigurarGridData = New System.Windows.Forms.Button()
        Me.grdListagemData = New Janus.Windows.GridEX.GridEX()
        Me.grpDadosLinha = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMunicipio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.cboUF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.txtData = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoFeriado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFeriado = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.btnExcluirLinha = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirLinha = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosCapa = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.cboAno = New Janus.Windows.EditControls.UIComboBox()
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
        CType(Me.grdListagemData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosLinha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosLinha.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDadosCapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosCapa.SuspendLayout()
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
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Calendário"
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
        Me.btnExcelGrid.TabIndex = 64
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 373)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 12
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 11
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
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
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 314)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblAnoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAnoFiltro)
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
        'lblAnoFiltro
        '
        Me.lblAnoFiltro.AutoSize = True
        Me.lblAnoFiltro.Location = New System.Drawing.Point(533, 17)
        Me.lblAnoFiltro.Name = "lblAnoFiltro"
        Me.lblAnoFiltro.Size = New System.Drawing.Size(30, 14)
        Me.lblAnoFiltro.TabIndex = 2
        Me.lblAnoFiltro.Text = "Ano:"
        '
        'cboAnoFiltro
        '
        Me.cboAnoFiltro.Location = New System.Drawing.Point(536, 34)
        Me.cboAnoFiltro.Name = "cboAnoFiltro"
        Me.cboAnoFiltro.Size = New System.Drawing.Size(91, 20)
        Me.cboAnoFiltro.TabIndex = 3
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(521, 20)
        Me.txtDescricaoFiltro.TabIndex = 1
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 0
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'btnFiltrar
        '
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
        Me.pagDados.Controls.Add(Me.btnExcelGridData)
        Me.pagDados.Controls.Add(Me.btnAgruparGridData)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridData)
        Me.pagDados.Controls.Add(Me.grdListagemData)
        Me.pagDados.Controls.Add(Me.grpDadosLinha)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDadosCapa)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Calendário"
        '
        'btnExcelGridData
        '
        Me.btnExcelGridData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridData.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridData.FlatAppearance.BorderSize = 0
        Me.btnExcelGridData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridData.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridData.Location = New System.Drawing.Point(57, 373)
        Me.btnExcelGridData.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridData.Name = "btnExcelGridData"
        Me.btnExcelGridData.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridData.TabIndex = 66
        Me.btnExcelGridData.TabStop = False
        Me.btnExcelGridData.UseVisualStyleBackColor = False
        '
        'btnAgruparGridData
        '
        Me.btnAgruparGridData.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridData.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridData.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridData.Location = New System.Drawing.Point(33, 373)
        Me.btnAgruparGridData.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridData.Name = "btnAgruparGridData"
        Me.btnAgruparGridData.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridData.TabIndex = 65
        Me.btnAgruparGridData.TabStop = False
        Me.btnAgruparGridData.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridData
        '
        Me.btnConfigurarGridData.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridData.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridData.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridData.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGridData.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridData.Name = "btnConfigurarGridData"
        Me.btnConfigurarGridData.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridData.TabIndex = 12
        Me.btnConfigurarGridData.TabStop = False
        Me.btnConfigurarGridData.UseVisualStyleBackColor = False
        '
        'grdListagemData
        '
        Me.grdListagemData.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagemData.AlternatingColors = True
        Me.grdListagemData.ColumnAutoResize = True
        grdListagemData_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagemData_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagemData_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagemData_DesignTimeLayout_Reference_0})
        grdListagemData_DesignTimeLayout.LayoutString = resources.GetString("grdListagemData_DesignTimeLayout.LayoutString")
        Me.grdListagemData.DesignTimeLayout = grdListagemData_DesignTimeLayout
        Me.grdListagemData.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagemData.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagemData.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagemData.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagemData.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagemData.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagemData.GroupByBoxVisible = False
        Me.grdListagemData.Location = New System.Drawing.Point(8, 183)
        Me.grdListagemData.Name = "grdListagemData"
        Me.grdListagemData.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagemData.RecordNavigator = True
        Me.grdListagemData.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagemData.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagemData.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagemData.Size = New System.Drawing.Size(897, 207)
        Me.grdListagemData.TabIndex = 2
        Me.grdListagemData.TabStop = False
        Me.grdListagemData.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagemData.VisualStyleManager = Me.vsmMain
        '
        'grpDadosLinha
        '
        Me.grpDadosLinha.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosLinha.Controls.Add(Me.cboMunicipio)
        Me.grpDadosLinha.Controls.Add(Me.lblUF)
        Me.grpDadosLinha.Controls.Add(Me.cboUF)
        Me.grpDadosLinha.Controls.Add(Me.lblMunicipio)
        Me.grpDadosLinha.Controls.Add(Me.txtData)
        Me.grpDadosLinha.Controls.Add(Me.txtDescricaoFeriado)
        Me.grpDadosLinha.Controls.Add(Me.lblDescricaoFeriado)
        Me.grpDadosLinha.Controls.Add(Me.lblData)
        Me.grpDadosLinha.Controls.Add(Me.btnExcluirLinha)
        Me.grpDadosLinha.Controls.Add(Me.btnInserirLinha)
        Me.grpDadosLinha.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosLinha.Name = "grpDadosLinha"
        Me.grpDadosLinha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosLinha.Size = New System.Drawing.Size(897, 104)
        Me.grpDadosLinha.TabIndex = 1
        Me.grpDadosLinha.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosLinha.VisualStyleManager = Me.vsmMain
        '
        'cboMunicipio
        '
        Me.cboMunicipio.AutoSize = False
        Me.cboMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipio.Location = New System.Drawing.Point(73, 74)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipio.Size = New System.Drawing.Size(457, 20)
        Me.cboMunicipio.TabIndex = 7
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUF.Location = New System.Drawing.Point(6, 57)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(23, 14)
        Me.lblUF.TabIndex = 4
        Me.lblUF.Text = "UF:"
        '
        'cboUF
        '
        Me.cboUF.AutoSize = False
        Me.cboUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUF.Location = New System.Drawing.Point(9, 74)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUF.Size = New System.Drawing.Size(58, 20)
        Me.cboUF.TabIndex = 5
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipio.Location = New System.Drawing.Point(70, 57)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipio.TabIndex = 6
        Me.lblMunicipio.Text = "Município:"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(9, 34)
        Me.txtData.Mask = "00/00"
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(58, 20)
        Me.txtData.TabIndex = 1
        '
        'txtDescricaoFeriado
        '
        Me.txtDescricaoFeriado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFeriado.Location = New System.Drawing.Point(73, 34)
        Me.txtDescricaoFeriado.MaxLength = 100
        Me.txtDescricaoFeriado.Name = "txtDescricaoFeriado"
        Me.txtDescricaoFeriado.Size = New System.Drawing.Size(457, 20)
        Me.txtDescricaoFeriado.TabIndex = 3
        '
        'lblDescricaoFeriado
        '
        Me.lblDescricaoFeriado.AutoSize = True
        Me.lblDescricaoFeriado.Location = New System.Drawing.Point(70, 17)
        Me.lblDescricaoFeriado.Name = "lblDescricaoFeriado"
        Me.lblDescricaoFeriado.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFeriado.TabIndex = 2
        Me.lblDescricaoFeriado.Text = "Descrição:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(6, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 0
        Me.lblData.Text = "Data:"
        '
        'btnExcluirLinha
        '
        Me.btnExcluirLinha.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirLinha.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirLinha.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirLinha.Location = New System.Drawing.Point(797, 71)
        Me.btnExcluirLinha.Name = "btnExcluirLinha"
        Me.btnExcluirLinha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirLinha.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirLinha.TabIndex = 9
        Me.btnExcluirLinha.Text = "Excluir"
        Me.btnExcluirLinha.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirLinha
        '
        Me.btnInserirLinha.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirLinha.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirLinha.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirLinha.Location = New System.Drawing.Point(700, 71)
        Me.btnInserirLinha.Name = "btnInserirLinha"
        Me.btnInserirLinha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirLinha.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirLinha.TabIndex = 8
        Me.btnInserirLinha.Text = "Inserir"
        Me.btnInserirLinha.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl2
        '
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
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
        'grpDadosCapa
        '
        Me.grpDadosCapa.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosCapa.Controls.Add(Me.lblAno)
        Me.grpDadosCapa.Controls.Add(Me.cboAno)
        Me.grpDadosCapa.Controls.Add(Me.txtDescricao)
        Me.grpDadosCapa.Controls.Add(Me.lblDescricao)
        Me.grpDadosCapa.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosCapa.Name = "grpDadosCapa"
        Me.grpDadosCapa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosCapa.Size = New System.Drawing.Size(897, 64)
        Me.grpDadosCapa.TabIndex = 0
        Me.grpDadosCapa.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosCapa.VisualStyleManager = Me.vsmMain
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(533, 17)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(30, 14)
        Me.lblAno.TabIndex = 2
        Me.lblAno.Text = "Ano:"
        '
        'cboAno
        '
        Me.cboAno.Location = New System.Drawing.Point(536, 34)
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Size = New System.Drawing.Size(91, 20)
        Me.cboAno.TabIndex = 3
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(521, 20)
        Me.txtDescricao.TabIndex = 1
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 0
        Me.lblDescricao.Text = "Descrição:"
        '
        'usrCadCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadCalendario"
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
        CType(Me.grdListagemData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDadosLinha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosLinha.ResumeLayout(False)
        Me.grpDadosLinha.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDadosCapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosCapa.ResumeLayout(False)
        Me.grpDadosCapa.PerformLayout()
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
    Friend WithEvents grpDadosCapa As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpDadosLinha As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtData As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricaoFeriado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFeriado As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents grdListagemData As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcluirLinha As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirLinha As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAnoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAnoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents cboAno As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboMunicipio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents cboUF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridData As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridData As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridData As System.Windows.Forms.Button

End Class
