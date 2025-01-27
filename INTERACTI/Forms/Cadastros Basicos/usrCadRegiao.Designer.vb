<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadRegiao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadRegiao))
        Dim grdMunicipio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMunicipio_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
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
        Me.btnExcelGridMunicipio = New System.Windows.Forms.Button()
        Me.btnAgruparGridMunicipio = New System.Windows.Forms.Button()
        Me.btnConfigurarGridMunicipio = New System.Windows.Forms.Button()
        Me.grdMunicipio = New Janus.Windows.GridEX.GridEX()
        Me.grpDadosMunicipio = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMunicipio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.cboUF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.btnExcluirMunicipio = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirMunicipio = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosCapa = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
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
        CType(Me.grdMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosMunicipio.SuspendLayout()
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
        Me.pagLista.Text = "Região"
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
        Me.btnExcelGrid.TabIndex = 11
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
        Me.btnAgruparGrid.TabIndex = 3
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
        Me.btnConfigurarGrid.TabIndex = 2
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
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
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
        Me.txtCodigoFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoFiltro.TabIndex = 1
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(559, 20)
        Me.txtDescricaoFiltro.TabIndex = 3
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(132, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 2
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
        Me.grpControl.TabIndex = 4
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
        Me.pagDados.Controls.Add(Me.btnExcelGridMunicipio)
        Me.pagDados.Controls.Add(Me.btnAgruparGridMunicipio)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridMunicipio)
        Me.pagDados.Controls.Add(Me.grdMunicipio)
        Me.pagDados.Controls.Add(Me.grpDadosMunicipio)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDadosCapa)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Região"
        '
        'btnExcelGridMunicipio
        '
        Me.btnExcelGridMunicipio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridMunicipio.FlatAppearance.BorderSize = 0
        Me.btnExcelGridMunicipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridMunicipio.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridMunicipio.Location = New System.Drawing.Point(57, 373)
        Me.btnExcelGridMunicipio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridMunicipio.Name = "btnExcelGridMunicipio"
        Me.btnExcelGridMunicipio.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridMunicipio.TabIndex = 13
        Me.btnExcelGridMunicipio.TabStop = False
        Me.btnExcelGridMunicipio.UseVisualStyleBackColor = False
        '
        'btnAgruparGridMunicipio
        '
        Me.btnAgruparGridMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridMunicipio.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridMunicipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridMunicipio.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridMunicipio.Location = New System.Drawing.Point(33, 373)
        Me.btnAgruparGridMunicipio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridMunicipio.Name = "btnAgruparGridMunicipio"
        Me.btnAgruparGridMunicipio.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridMunicipio.TabIndex = 12
        Me.btnAgruparGridMunicipio.TabStop = False
        Me.btnAgruparGridMunicipio.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridMunicipio
        '
        Me.btnConfigurarGridMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridMunicipio.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridMunicipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridMunicipio.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridMunicipio.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGridMunicipio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridMunicipio.Name = "btnConfigurarGridMunicipio"
        Me.btnConfigurarGridMunicipio.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridMunicipio.TabIndex = 3
        Me.btnConfigurarGridMunicipio.TabStop = False
        Me.btnConfigurarGridMunicipio.UseVisualStyleBackColor = False
        '
        'grdMunicipio
        '
        Me.grdMunicipio.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMunicipio.AlternatingColors = True
        Me.grdMunicipio.ColumnAutoResize = True
        grdMunicipio_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdMunicipio_DesignTimeLayout_Reference_0.Instance"), Object)
        grdMunicipio_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdMunicipio_DesignTimeLayout_Reference_0})
        grdMunicipio_DesignTimeLayout.LayoutString = resources.GetString("grdMunicipio_DesignTimeLayout.LayoutString")
        Me.grdMunicipio.DesignTimeLayout = grdMunicipio_DesignTimeLayout
        Me.grdMunicipio.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMunicipio.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMunicipio.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMunicipio.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMunicipio.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdMunicipio.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMunicipio.GroupByBoxVisible = False
        Me.grdMunicipio.Location = New System.Drawing.Point(8, 143)
        Me.grdMunicipio.Name = "grdMunicipio"
        Me.grdMunicipio.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMunicipio.RecordNavigator = True
        Me.grdMunicipio.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdMunicipio.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMunicipio.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMunicipio.Size = New System.Drawing.Size(897, 247)
        Me.grdMunicipio.TabIndex = 2
        Me.grdMunicipio.TabStop = False
        Me.grdMunicipio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMunicipio.VisualStyleManager = Me.vsmMain
        '
        'grpDadosMunicipio
        '
        Me.grpDadosMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosMunicipio.Controls.Add(Me.cboMunicipio)
        Me.grpDadosMunicipio.Controls.Add(Me.lblUF)
        Me.grpDadosMunicipio.Controls.Add(Me.cboUF)
        Me.grpDadosMunicipio.Controls.Add(Me.lblMunicipio)
        Me.grpDadosMunicipio.Controls.Add(Me.btnExcluirMunicipio)
        Me.grpDadosMunicipio.Controls.Add(Me.btnInserirMunicipio)
        Me.grpDadosMunicipio.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosMunicipio.Name = "grpDadosMunicipio"
        Me.grpDadosMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosMunicipio.Size = New System.Drawing.Size(897, 64)
        Me.grpDadosMunicipio.TabIndex = 1
        Me.grpDadosMunicipio.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosMunicipio.VisualStyleManager = Me.vsmMain
        '
        'cboMunicipio
        '
        Me.cboMunicipio.AutoSize = False
        Me.cboMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipio.Location = New System.Drawing.Point(73, 34)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipio.Size = New System.Drawing.Size(457, 20)
        Me.cboMunicipio.TabIndex = 3
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUF.Location = New System.Drawing.Point(6, 17)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(23, 14)
        Me.lblUF.TabIndex = 0
        Me.lblUF.Text = "UF:"
        '
        'cboUF
        '
        Me.cboUF.AutoSize = False
        Me.cboUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUF.Location = New System.Drawing.Point(9, 34)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUF.Size = New System.Drawing.Size(58, 20)
        Me.cboUF.TabIndex = 1
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipio.Location = New System.Drawing.Point(70, 17)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipio.TabIndex = 2
        Me.lblMunicipio.Text = "Município:"
        '
        'btnExcluirMunicipio
        '
        Me.btnExcluirMunicipio.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirMunicipio.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirMunicipio.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirMunicipio.Location = New System.Drawing.Point(797, 31)
        Me.btnExcluirMunicipio.Name = "btnExcluirMunicipio"
        Me.btnExcluirMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirMunicipio.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirMunicipio.TabIndex = 5
        Me.btnExcluirMunicipio.Text = "Excluir"
        Me.btnExcluirMunicipio.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirMunicipio
        '
        Me.btnInserirMunicipio.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirMunicipio.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirMunicipio.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirMunicipio.Location = New System.Drawing.Point(700, 31)
        Me.btnInserirMunicipio.Name = "btnInserirMunicipio"
        Me.btnInserirMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirMunicipio.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirMunicipio.TabIndex = 4
        Me.btnInserirMunicipio.Text = "Inserir"
        Me.btnInserirMunicipio.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.grpControl2.TabIndex = 4
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
        Me.grpDadosCapa.Controls.Add(Me.lblCodigo)
        Me.grpDadosCapa.Controls.Add(Me.txtCodigo)
        Me.grpDadosCapa.Controls.Add(Me.lblAtivo)
        Me.grpDadosCapa.Controls.Add(Me.cboAtivo)
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
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(795, 17)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 4
        Me.lblAtivo.Text = "Ativo:"
        '
        'cboAtivo
        '
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboAtivo.Location = New System.Drawing.Point(798, 34)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(90, 20)
        Me.cboAtivo.TabIndex = 5
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(657, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(132, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'usrCadRegiao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadRegiao"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagLista.ResumeLayout(false)
        CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpFiltro,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFiltro.ResumeLayout(false)
        Me.grpFiltro.PerformLayout
        CType(Me.grpControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControl.ResumeLayout(false)
        Me.pagDados.ResumeLayout(false)
        CType(Me.grdMunicipio,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpDadosMunicipio,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDadosMunicipio.ResumeLayout(false)
        Me.grpDadosMunicipio.PerformLayout
        CType(Me.grpControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControl2.ResumeLayout(false)
        CType(Me.grpDadosCapa,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDadosCapa.ResumeLayout(false)
        Me.grpDadosCapa.PerformLayout
        Me.ResumeLayout(false)

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
    Friend WithEvents grpDadosMunicipio As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdMunicipio As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcluirMunicipio As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirMunicipio As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboMunicipio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents cboUF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridMunicipio As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridMunicipio As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridMunicipio As System.Windows.Forms.Button

End Class
