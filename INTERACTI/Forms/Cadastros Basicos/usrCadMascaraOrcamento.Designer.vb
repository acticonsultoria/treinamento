<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadMascaraOrcamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadMascaraOrcamento))
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim grdOrcamentoListaMaterial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamentoProcessoProdutivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamentoServicoTerceiros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.Image")
        Dim grdOrcamentoGrupo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrComposicao = New Dundas.Charting.WinControl.Chart()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagListaMaterialGrupo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdOrcamentoListaMaterial = New Janus.Windows.GridEX.GridEX()
        Me.pagProcessoProdutivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdOrcamentoProcessoProdutivo = New Janus.Windows.GridEX.GridEX()
        Me.pagServicoTerceiro = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpServicoTerceiros = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.txtQuantidadeServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.cboGrupo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSalvarServico = New Janus.Windows.EditControls.UIButton()
        Me.lblQuantidadeServico = New System.Windows.Forms.Label()
        Me.grdOrcamentoServicoTerceiros = New Janus.Windows.GridEX.GridEX()
        Me.grdOrcamentoGrupo = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
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
        CType(Me.chrComposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagListaMaterialGrupo.SuspendLayout()
        CType(Me.grdOrcamentoListaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagProcessoProdutivo.SuspendLayout()
        CType(Me.grdOrcamentoProcessoProdutivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagServicoTerceiro.SuspendLayout()
        CType(Me.grpServicoTerceiros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServicoTerceiros.SuspendLayout()
        CType(Me.grdOrcamentoServicoTerceiros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrcamentoGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Máscara de Orçamento"
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
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
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
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoFiltro.MaxLength = 50
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(413, 20)
        Me.txtDescricaoFiltro.TabIndex = 4
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 3
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 2
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
        Me.grpControl.Location = New System.Drawing.Point(8, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 2
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
        Me.pagDados.Controls.Add(Me.chrComposicao)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grdOrcamentoGrupo)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Máscara de Orçamento"
        '
        'chrComposicao
        '
        Me.chrComposicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrComposicao.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrComposicao.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrComposicao.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrComposicao.ChartAreas.Add(ChartArea1)
        Legend1.AutoFitText = False
        Legend1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.Name = "Default"
        Me.chrComposicao.Legends.Add(Legend1)
        Me.chrComposicao.Location = New System.Drawing.Point(388, 73)
        Me.chrComposicao.Name = "chrComposicao"
        Me.chrComposicao.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Me.chrComposicao.Size = New System.Drawing.Size(517, 167)
        Me.chrComposicao.TabIndex = 113
        Me.chrComposicao.UI.Toolbar.Enabled = True
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.Location = New System.Drawing.Point(8, 237)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 150)
        Me.tabDados.TabIndex = 8
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListaMaterialGrupo, Me.pagProcessoProdutivo, Me.pagServicoTerceiro})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagListaMaterialGrupo
        '
        Me.pagListaMaterialGrupo.Controls.Add(Me.grdOrcamentoListaMaterial)
        Me.pagListaMaterialGrupo.Location = New System.Drawing.Point(1, 22)
        Me.pagListaMaterialGrupo.Name = "pagListaMaterialGrupo"
        Me.pagListaMaterialGrupo.Size = New System.Drawing.Size(895, 127)
        Me.pagListaMaterialGrupo.TabStop = True
        Me.pagListaMaterialGrupo.Text = "Lista Material"
        '
        'grdOrcamentoListaMaterial
        '
        Me.grdOrcamentoListaMaterial.AlternatingColors = True
        Me.grdOrcamentoListaMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoListaMaterial_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoListaMaterial_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoListaMaterial.DesignTimeLayout = grdOrcamentoListaMaterial_DesignTimeLayout
        Me.grdOrcamentoListaMaterial.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoListaMaterial.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoListaMaterial.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoListaMaterial.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoListaMaterial.GroupByBoxVisible = False
        Me.grdOrcamentoListaMaterial.Location = New System.Drawing.Point(11, 9)
        Me.grdOrcamentoListaMaterial.Name = "grdOrcamentoListaMaterial"
        Me.grdOrcamentoListaMaterial.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoListaMaterial.RecordNavigator = True
        Me.grdOrcamentoListaMaterial.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoListaMaterial.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoListaMaterial.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoListaMaterial.Size = New System.Drawing.Size(876, 110)
        Me.grdOrcamentoListaMaterial.TabIndex = 3
        Me.grdOrcamentoListaMaterial.TabStop = False
        Me.grdOrcamentoListaMaterial.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoListaMaterial.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoListaMaterial.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoListaMaterial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoListaMaterial.VisualStyleManager = Me.vsmMain
        '
        'pagProcessoProdutivo
        '
        Me.pagProcessoProdutivo.Controls.Add(Me.grdOrcamentoProcessoProdutivo)
        Me.pagProcessoProdutivo.Location = New System.Drawing.Point(1, 22)
        Me.pagProcessoProdutivo.Name = "pagProcessoProdutivo"
        Me.pagProcessoProdutivo.Size = New System.Drawing.Size(895, 127)
        Me.pagProcessoProdutivo.TabStop = True
        Me.pagProcessoProdutivo.Text = "Processo Produtivo"
        '
        'grdOrcamentoProcessoProdutivo
        '
        Me.grdOrcamentoProcessoProdutivo.AlternatingColors = True
        Me.grdOrcamentoProcessoProdutivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoProcessoProdutivo_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoProcessoProdutivo_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoProcessoProdutivo.DesignTimeLayout = grdOrcamentoProcessoProdutivo_DesignTimeLayout
        Me.grdOrcamentoProcessoProdutivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoProcessoProdutivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoProcessoProdutivo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoProcessoProdutivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoProcessoProdutivo.GroupByBoxVisible = False
        Me.grdOrcamentoProcessoProdutivo.Location = New System.Drawing.Point(11, 9)
        Me.grdOrcamentoProcessoProdutivo.Name = "grdOrcamentoProcessoProdutivo"
        Me.grdOrcamentoProcessoProdutivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoProcessoProdutivo.RecordNavigator = True
        Me.grdOrcamentoProcessoProdutivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoProcessoProdutivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoProcessoProdutivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoProcessoProdutivo.Size = New System.Drawing.Size(876, 110)
        Me.grdOrcamentoProcessoProdutivo.TabIndex = 2
        Me.grdOrcamentoProcessoProdutivo.TabStop = False
        Me.grdOrcamentoProcessoProdutivo.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoProcessoProdutivo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoProcessoProdutivo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoProcessoProdutivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoProcessoProdutivo.VisualStyleManager = Me.vsmMain
        '
        'pagServicoTerceiro
        '
        Me.pagServicoTerceiro.Controls.Add(Me.grpServicoTerceiros)
        Me.pagServicoTerceiro.Controls.Add(Me.grdOrcamentoServicoTerceiros)
        Me.pagServicoTerceiro.Location = New System.Drawing.Point(1, 22)
        Me.pagServicoTerceiro.Name = "pagServicoTerceiro"
        Me.pagServicoTerceiro.Size = New System.Drawing.Size(895, 127)
        Me.pagServicoTerceiro.TabStop = True
        Me.pagServicoTerceiro.Text = "Serviço de Terceiros"
        '
        'grpServicoTerceiros
        '
        Me.grpServicoTerceiros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpServicoTerceiros.BackColor = System.Drawing.Color.Transparent
        Me.grpServicoTerceiros.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpServicoTerceiros.Controls.Add(Me.txtValorTotal)
        Me.grpServicoTerceiros.Controls.Add(Me.lblValorTotal)
        Me.grpServicoTerceiros.Controls.Add(Me.lblFornecedor)
        Me.grpServicoTerceiros.Controls.Add(Me.cboFornecedor)
        Me.grpServicoTerceiros.Controls.Add(Me.txtValorUnitario)
        Me.grpServicoTerceiros.Controls.Add(Me.lblValorUnitario)
        Me.grpServicoTerceiros.Controls.Add(Me.txtQuantidadeServico)
        Me.grpServicoTerceiros.Controls.Add(Me.lblOperacao)
        Me.grpServicoTerceiros.Controls.Add(Me.cboOperacao)
        Me.grpServicoTerceiros.Controls.Add(Me.lblGrupo)
        Me.grpServicoTerceiros.Controls.Add(Me.cboGrupo)
        Me.grpServicoTerceiros.Controls.Add(Me.btnSalvarServico)
        Me.grpServicoTerceiros.Controls.Add(Me.lblQuantidadeServico)
        Me.grpServicoTerceiros.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpServicoTerceiros.Location = New System.Drawing.Point(11, 4)
        Me.grpServicoTerceiros.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpServicoTerceiros.Name = "grpServicoTerceiros"
        Me.grpServicoTerceiros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpServicoTerceiros.Size = New System.Drawing.Size(876, 65)
        Me.grpServicoTerceiros.TabIndex = 4
        Me.grpServicoTerceiros.Text = "Dados do Serviço"
        Me.grpServicoTerceiros.Visible = False
        Me.grpServicoTerceiros.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarFornecedor
        '
        Me.btnProcurarFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.btnProcurarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(753, 16)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(24, 15)
        Me.btnProcurarFornecedor.TabIndex = 24
        Me.btnProcurarFornecedor.TabStop = False
        Me.btnProcurarFornecedor.UseVisualStyleBackColor = False
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.DecimalDigits = 2
        Me.txtValorTotal.Location = New System.Drawing.Point(615, 34)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(67, 20)
        Me.txtValorTotal.TabIndex = 16
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(612, 17)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 17
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(685, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 15
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedor.AutoSize = False
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedor.Location = New System.Drawing.Point(688, 34)
        Me.cboFornecedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedor.Size = New System.Drawing.Size(87, 20)
        Me.cboFornecedor.TabIndex = 4
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.BackColor = System.Drawing.Color.White
        Me.txtValorUnitario.DecimalDigits = 2
        Me.txtValorUnitario.Location = New System.Drawing.Point(538, 34)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(71, 20)
        Me.txtValorUnitario.TabIndex = 3
        Me.txtValorUnitario.Text = "0,00"
        Me.txtValorUnitario.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.Location = New System.Drawing.Point(535, 17)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitario.TabIndex = 13
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'txtQuantidadeServico
        '
        Me.txtQuantidadeServico.BackColor = System.Drawing.Color.White
        Me.txtQuantidadeServico.DecimalDigits = 2
        Me.txtQuantidadeServico.Location = New System.Drawing.Point(470, 34)
        Me.txtQuantidadeServico.Name = "txtQuantidadeServico"
        Me.txtQuantidadeServico.Size = New System.Drawing.Size(62, 20)
        Me.txtQuantidadeServico.TabIndex = 2
        Me.txtQuantidadeServico.Text = "0,00"
        Me.txtQuantidadeServico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblOperacao
        '
        Me.lblOperacao.AutoSize = True
        Me.lblOperacao.Location = New System.Drawing.Point(178, 17)
        Me.lblOperacao.Name = "lblOperacao"
        Me.lblOperacao.Size = New System.Drawing.Size(58, 14)
        Me.lblOperacao.TabIndex = 9
        Me.lblOperacao.Text = "Operação:"
        '
        'cboOperacao
        '
        Me.cboOperacao.AutoSize = False
        Me.cboOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOperacao.Location = New System.Drawing.Point(181, 34)
        Me.cboOperacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOperacao.Size = New System.Drawing.Size(283, 20)
        Me.cboOperacao.TabIndex = 1
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(6, 17)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(40, 14)
        Me.lblGrupo.TabIndex = 7
        Me.lblGrupo.Text = "Grupo:"
        '
        'cboGrupo
        '
        Me.cboGrupo.AutoSize = False
        Me.cboGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupo.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupo.Size = New System.Drawing.Size(166, 20)
        Me.cboGrupo.TabIndex = 0
        '
        'btnSalvarServico
        '
        Me.btnSalvarServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarServico.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarServico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarServico.Location = New System.Drawing.Point(781, 31)
        Me.btnSalvarServico.Name = "btnSalvarServico"
        Me.btnSalvarServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarServico.Size = New System.Drawing.Size(89, 23)
        Me.btnSalvarServico.TabIndex = 5
        Me.btnSalvarServico.Text = "Salvar"
        Me.btnSalvarServico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblQuantidadeServico
        '
        Me.lblQuantidadeServico.AutoSize = True
        Me.lblQuantidadeServico.Location = New System.Drawing.Point(467, 17)
        Me.lblQuantidadeServico.Name = "lblQuantidadeServico"
        Me.lblQuantidadeServico.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeServico.TabIndex = 11
        Me.lblQuantidadeServico.Text = "Quantidade:"
        '
        'grdOrcamentoServicoTerceiros
        '
        Me.grdOrcamentoServicoTerceiros.AlternatingColors = True
        Me.grdOrcamentoServicoTerceiros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_0.Instance"), Object)
        grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_1.Instance"), Object)
        grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_2.Instance"), Object)
        grdOrcamentoServicoTerceiros_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_0, grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_1, grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_2})
        grdOrcamentoServicoTerceiros_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoServicoTerceiros_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoServicoTerceiros.DesignTimeLayout = grdOrcamentoServicoTerceiros_DesignTimeLayout
        Me.grdOrcamentoServicoTerceiros.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoServicoTerceiros.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoServicoTerceiros.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoServicoTerceiros.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoServicoTerceiros.GroupByBoxVisible = False
        Me.grdOrcamentoServicoTerceiros.Location = New System.Drawing.Point(11, 9)
        Me.grdOrcamentoServicoTerceiros.Name = "grdOrcamentoServicoTerceiros"
        Me.grdOrcamentoServicoTerceiros.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoServicoTerceiros.RecordNavigator = True
        Me.grdOrcamentoServicoTerceiros.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoServicoTerceiros.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoServicoTerceiros.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoServicoTerceiros.Size = New System.Drawing.Size(876, 110)
        Me.grdOrcamentoServicoTerceiros.TabIndex = 3
        Me.grdOrcamentoServicoTerceiros.TabStop = False
        Me.grdOrcamentoServicoTerceiros.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoServicoTerceiros.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoServicoTerceiros.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoServicoTerceiros.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoServicoTerceiros.VisualStyleManager = Me.vsmMain
        '
        'grdOrcamentoGrupo
        '
        Me.grdOrcamentoGrupo.AlternatingColors = True
        grdOrcamentoGrupo_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoGrupo_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoGrupo.DesignTimeLayout = grdOrcamentoGrupo_DesignTimeLayout
        Me.grdOrcamentoGrupo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamentoGrupo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoGrupo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoGrupo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoGrupo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoGrupo.GroupByBoxVisible = False
        Me.grdOrcamentoGrupo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamentoGrupo.Hierarchical = True
        Me.grdOrcamentoGrupo.Location = New System.Drawing.Point(8, 73)
        Me.grdOrcamentoGrupo.Name = "grdOrcamentoGrupo"
        Me.grdOrcamentoGrupo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoGrupo.RecordNavigator = True
        Me.grdOrcamentoGrupo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoGrupo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoGrupo.Size = New System.Drawing.Size(374, 158)
        Me.grdOrcamentoGrupo.TabIndex = 7
        Me.grdOrcamentoGrupo.TabStop = False
        Me.grdOrcamentoGrupo.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoGrupo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoGrupo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoGrupo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoGrupo.VisualStyleManager = Me.vsmMain
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
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblAtivo
        '
        Me.lblAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(795, 17)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 2
        Me.lblAtivo.Text = "Ativo:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(783, 20)
        Me.txtDescricao.TabIndex = 0
        '
        'cboAtivo
        '
        Me.cboAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.cboAtivo.TabIndex = 1
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
        'usrCadMascaraOrcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadMascaraOrcamento"
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
        CType(Me.chrComposicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagListaMaterialGrupo.ResumeLayout(False)
        CType(Me.grdOrcamentoListaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagProcessoProdutivo.ResumeLayout(False)
        CType(Me.grdOrcamentoProcessoProdutivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagServicoTerceiro.ResumeLayout(False)
        CType(Me.grpServicoTerceiros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServicoTerceiros.ResumeLayout(False)
        Me.grpServicoTerceiros.PerformLayout()
        CType(Me.grdOrcamentoServicoTerceiros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrcamentoGrupo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdOrcamentoGrupo As Janus.Windows.GridEX.GridEX
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListaMaterialGrupo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdOrcamentoListaMaterial As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagProcessoProdutivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdOrcamentoProcessoProdutivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagServicoTerceiro As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpServicoTerceiros As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents cboGrupo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnSalvarServico As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblQuantidadeServico As System.Windows.Forms.Label
    Friend WithEvents grdOrcamentoServicoTerceiros As Janus.Windows.GridEX.GridEX
    Friend WithEvents chrComposicao As Dundas.Charting.WinControl.Chart

End Class
