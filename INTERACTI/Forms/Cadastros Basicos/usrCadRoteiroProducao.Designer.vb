<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadRoteiroProducao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadRoteiroProducao))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings4 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdRoteiro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRoteiro_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdMaquina_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMaquina_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblModeloOrdemProducaoFiltro = New System.Windows.Forms.Label()
        Me.cboModeloOrdemProducaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtCodigoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagRoteiro = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridRoteiro = New System.Windows.Forms.Button()
        Me.grpRoteiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblReferenciaMolde = New System.Windows.Forms.Label()
        Me.cboReferenciaMolde = New Janus.Windows.EditControls.UIComboBox()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtTempoMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTempoMaoObra = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTempoSetupMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblApontamentoConcorrente = New System.Windows.Forms.Label()
        Me.cboApontamentoConcorrente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSequenciaPredecessora = New System.Windows.Forms.Label()
        Me.cboSequenciaPredecessora = New Janus.Windows.EditControls.UIComboBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblTempoMaquina = New System.Windows.Forms.Label()
        Me.lblTempoMaoObra = New System.Windows.Forms.Label()
        Me.lblControlaQualidade = New System.Windows.Forms.Label()
        Me.cboControlaQualidade = New Janus.Windows.EditControls.UIComboBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblAponta = New System.Windows.Forms.Label()
        Me.cboAponta = New Janus.Windows.EditControls.UIComboBox()
        Me.lblApontaEquipamento = New System.Windows.Forms.Label()
        Me.cboApontaEquipamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSequencia = New System.Windows.Forms.Label()
        Me.txtSequencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTempoSetupMaquina = New System.Windows.Forms.Label()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.cboCentroTrabalho = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarCentroTrabalho = New System.Windows.Forms.Button()
        Me.btnCadastrarOperacao = New System.Windows.Forms.Button()
        Me.btnExcluirRoteiro = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirRoteiro = New Janus.Windows.EditControls.UIButton()
        Me.btnAgruparGridRoteiro = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRoteiro = New System.Windows.Forms.Button()
        Me.grdRoteiro = New Janus.Windows.GridEX.GridEX()
        Me.pagMaquina = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridMaquina = New System.Windows.Forms.Button()
        Me.btnAgruparGridMaquina = New System.Windows.Forms.Button()
        Me.grpMaquina = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricaoMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluirMaquina = New Janus.Windows.EditControls.UIButton()
        Me.lblDescricaoMaquina = New System.Windows.Forms.Label()
        Me.btnInserirMaquina = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarMaquina = New System.Windows.Forms.Button()
        Me.cboCodigoMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoMaquina = New System.Windows.Forms.Label()
        Me.btnConfigurarGridMaquina = New System.Windows.Forms.Button()
        Me.grdMaquina = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblModeloOrdemProducao = New System.Windows.Forms.Label()
        Me.cboModeloOrdemProducao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagRoteiro.SuspendLayout()
        CType(Me.grpRoteiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRoteiro.SuspendLayout()
        CType(Me.grdRoteiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagMaquina.SuspendLayout()
        CType(Me.grpMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaquina.SuspendLayout()
        CType(Me.grdMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
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
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
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
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Key = "pagListagem"
        resources.ApplyResources(Me.pagListagem, "pagListagem")
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.TabStop = True
        '
        'btnExcelGrid
        '
        resources.ApplyResources(Me.btnExcelGrid, "btnExcelGrid")
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        resources.ApplyResources(Me.btnAgruparGrid, "btnAgruparGrid")
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        resources.ApplyResources(Me.btnConfigurarGrid, "btnConfigurarGrid")
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        resources.ApplyResources(Me.btnNovo1, "btnNovo1")
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        resources.ApplyResources(Me.btnExcluir, "btnExcluir")
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        resources.ApplyResources(Me.grpFiltro, "grpFiltro")
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblModeloOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboModeloOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblModeloOrdemProducaoFiltro
        '
        resources.ApplyResources(Me.lblModeloOrdemProducaoFiltro, "lblModeloOrdemProducaoFiltro")
        Me.lblModeloOrdemProducaoFiltro.Name = "lblModeloOrdemProducaoFiltro"
        '
        'cboModeloOrdemProducaoFiltro
        '
        resources.ApplyResources(Me.cboModeloOrdemProducaoFiltro, "cboModeloOrdemProducaoFiltro")
        Me.cboModeloOrdemProducaoFiltro.Name = "cboModeloOrdemProducaoFiltro"
        '
        'btnFiltrar
        '
        resources.ApplyResources(Me.btnFiltrar, "btnFiltrar")
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtCodigoFiltro
        '
        Me.txtCodigoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtCodigoFiltro, "txtCodigoFiltro")
        Me.txtCodigoFiltro.MaxLength = 20
        Me.txtCodigoFiltro.Name = "txtCodigoFiltro"
        '
        'lblCodigoFiltro
        '
        resources.ApplyResources(Me.lblCodigoFiltro, "lblCodigoFiltro")
        Me.lblCodigoFiltro.Name = "lblCodigoFiltro"
        '
        'txtDescricaoFiltro
        '
        resources.ApplyResources(Me.txtDescricaoFiltro, "txtDescricaoFiltro")
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.MaxLength = 250
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        '
        'lblDescricaoFiltro
        '
        resources.ApplyResources(Me.lblDescricaoFiltro, "lblDescricaoFiltro")
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Key = "pagDados"
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'tabDados
        '
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagRoteiro, Me.pagMaquina})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagRoteiro
        '
        Me.pagRoteiro.Controls.Add(Me.btnExcelGridRoteiro)
        Me.pagRoteiro.Controls.Add(Me.grpRoteiro)
        Me.pagRoteiro.Controls.Add(Me.btnAgruparGridRoteiro)
        Me.pagRoteiro.Controls.Add(Me.btnConfigurarGridRoteiro)
        Me.pagRoteiro.Controls.Add(Me.grdRoteiro)
        Me.pagRoteiro.Key = "pagRoteiro"
        resources.ApplyResources(Me.pagRoteiro, "pagRoteiro")
        Me.pagRoteiro.Name = "pagRoteiro"
        Me.pagRoteiro.TabStop = True
        '
        'btnExcelGridRoteiro
        '
        resources.ApplyResources(Me.btnExcelGridRoteiro, "btnExcelGridRoteiro")
        Me.btnExcelGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnExcelGridRoteiro.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridRoteiro.Name = "btnExcelGridRoteiro"
        Me.btnExcelGridRoteiro.TabStop = False
        Me.btnExcelGridRoteiro.UseVisualStyleBackColor = False
        '
        'grpRoteiro
        '
        resources.ApplyResources(Me.grpRoteiro, "grpRoteiro")
        Me.grpRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.grpRoteiro.Controls.Add(Me.lblReferenciaMolde)
        Me.grpRoteiro.Controls.Add(Me.cboReferenciaMolde)
        Me.grpRoteiro.Controls.Add(Me.txtReferencia)
        Me.grpRoteiro.Controls.Add(Me.txtTempoMaquina)
        Me.grpRoteiro.Controls.Add(Me.txtTempoMaoObra)
        Me.grpRoteiro.Controls.Add(Me.txtTempoSetupMaquina)
        Me.grpRoteiro.Controls.Add(Me.lblApontamentoConcorrente)
        Me.grpRoteiro.Controls.Add(Me.cboApontamentoConcorrente)
        Me.grpRoteiro.Controls.Add(Me.lblSequenciaPredecessora)
        Me.grpRoteiro.Controls.Add(Me.cboSequenciaPredecessora)
        Me.grpRoteiro.Controls.Add(Me.lblReferencia)
        Me.grpRoteiro.Controls.Add(Me.lblTempoMaquina)
        Me.grpRoteiro.Controls.Add(Me.lblTempoMaoObra)
        Me.grpRoteiro.Controls.Add(Me.lblControlaQualidade)
        Me.grpRoteiro.Controls.Add(Me.cboControlaQualidade)
        Me.grpRoteiro.Controls.Add(Me.txtObservacao)
        Me.grpRoteiro.Controls.Add(Me.lblAponta)
        Me.grpRoteiro.Controls.Add(Me.cboAponta)
        Me.grpRoteiro.Controls.Add(Me.lblApontaEquipamento)
        Me.grpRoteiro.Controls.Add(Me.cboApontaEquipamento)
        Me.grpRoteiro.Controls.Add(Me.lblSequencia)
        Me.grpRoteiro.Controls.Add(Me.txtSequencia)
        Me.grpRoteiro.Controls.Add(Me.lblTempoSetupMaquina)
        Me.grpRoteiro.Controls.Add(Me.lblObservacao)
        Me.grpRoteiro.Controls.Add(Me.lblOperacao)
        Me.grpRoteiro.Controls.Add(Me.cboOperacao)
        Me.grpRoteiro.Controls.Add(Me.lblCentroTrabalho)
        Me.grpRoteiro.Controls.Add(Me.cboCentroTrabalho)
        Me.grpRoteiro.Controls.Add(Me.btnCadastrarCentroTrabalho)
        Me.grpRoteiro.Controls.Add(Me.btnCadastrarOperacao)
        Me.grpRoteiro.Controls.Add(Me.btnExcluirRoteiro)
        Me.grpRoteiro.Controls.Add(Me.btnInserirRoteiro)
        Me.grpRoteiro.Name = "grpRoteiro"
        Me.grpRoteiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpRoteiro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpRoteiro.VisualStyleManager = Me.vsmMain
        '
        'lblReferenciaMolde
        '
        resources.ApplyResources(Me.lblReferenciaMolde, "lblReferenciaMolde")
        Me.lblReferenciaMolde.Name = "lblReferenciaMolde"
        '
        'cboReferenciaMolde
        '
        resources.ApplyResources(Me.cboReferenciaMolde, "cboReferenciaMolde")
        Me.cboReferenciaMolde.Name = "cboReferenciaMolde"
        '
        'txtReferencia
        '
        Me.txtReferencia.DecimalDigits = 0
        resources.ApplyResources(Me.txtReferencia, "txtReferencia")
        Me.txtReferencia.Name = "txtReferencia"
        SuperTipSettings1.HeaderText = "Ref. Produto"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Quantidade de produtos feito no tempo informado."
        Me.jstTip.SetSuperTip(Me.txtReferencia, SuperTipSettings1)
        Me.txtReferencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtReferencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTempoMaquina
        '
        resources.ApplyResources(Me.txtTempoMaquina, "txtTempoMaquina")
        Me.txtTempoMaquina.Mask = "00:00:00"
        Me.txtTempoMaquina.Name = "txtTempoMaquina"
        SuperTipSettings2.FooterText = "Formato HH:MM:SS"
        SuperTipSettings2.HeaderText = "Tempo Máquina"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Tempo de Máquina utilizado para produzir a quantidade de produto especificada no " & _
    "campo Referência."
        Me.jstTip.SetSuperTip(Me.txtTempoMaquina, SuperTipSettings2)
        Me.txtTempoMaquina.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtTempoMaoObra
        '
        resources.ApplyResources(Me.txtTempoMaoObra, "txtTempoMaoObra")
        Me.txtTempoMaoObra.Mask = "00:00:00"
        Me.txtTempoMaoObra.Name = "txtTempoMaoObra"
        SuperTipSettings3.FooterText = "Formato HH:MM:SS"
        SuperTipSettings3.HeaderText = "Tempo M.O."
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Tempo de Mão de Obra utilizado para produzir a quantidade de produto especificada" & _
    " no campo Referência."
        Me.jstTip.SetSuperTip(Me.txtTempoMaoObra, SuperTipSettings3)
        Me.txtTempoMaoObra.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtTempoSetupMaquina
        '
        resources.ApplyResources(Me.txtTempoSetupMaquina, "txtTempoSetupMaquina")
        Me.txtTempoSetupMaquina.Mask = "00:00:00"
        Me.txtTempoSetupMaquina.Name = "txtTempoSetupMaquina"
        SuperTipSettings4.FooterText = "Formato HH:MM:SS"
        SuperTipSettings4.HeaderText = "Tempo Setup"
        SuperTipSettings4.ImageListProvider = Nothing
        SuperTipSettings4.Text = "Tempo de Setup utilizado para liberar a produção." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Este campo não está vinculad" & _
    "o ao campo Referência."
        Me.jstTip.SetSuperTip(Me.txtTempoSetupMaquina, SuperTipSettings4)
        Me.txtTempoSetupMaquina.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblApontamentoConcorrente
        '
        resources.ApplyResources(Me.lblApontamentoConcorrente, "lblApontamentoConcorrente")
        Me.lblApontamentoConcorrente.Name = "lblApontamentoConcorrente"
        '
        'cboApontamentoConcorrente
        '
        resources.ApplyResources(Me.cboApontamentoConcorrente, "cboApontamentoConcorrente")
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem1, "UiComboBoxItem1")
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem2, "UiComboBoxItem2")
        Me.cboApontamentoConcorrente.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboApontamentoConcorrente.Name = "cboApontamentoConcorrente"
        Me.cboApontamentoConcorrente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblSequenciaPredecessora
        '
        resources.ApplyResources(Me.lblSequenciaPredecessora, "lblSequenciaPredecessora")
        Me.lblSequenciaPredecessora.Name = "lblSequenciaPredecessora"
        '
        'cboSequenciaPredecessora
        '
        resources.ApplyResources(Me.cboSequenciaPredecessora, "cboSequenciaPredecessora")
        Me.cboSequenciaPredecessora.Name = "cboSequenciaPredecessora"
        '
        'lblReferencia
        '
        resources.ApplyResources(Me.lblReferencia, "lblReferencia")
        Me.lblReferencia.Name = "lblReferencia"
        '
        'lblTempoMaquina
        '
        resources.ApplyResources(Me.lblTempoMaquina, "lblTempoMaquina")
        Me.lblTempoMaquina.Name = "lblTempoMaquina"
        '
        'lblTempoMaoObra
        '
        resources.ApplyResources(Me.lblTempoMaoObra, "lblTempoMaoObra")
        Me.lblTempoMaoObra.Name = "lblTempoMaoObra"
        '
        'lblControlaQualidade
        '
        resources.ApplyResources(Me.lblControlaQualidade, "lblControlaQualidade")
        Me.lblControlaQualidade.Name = "lblControlaQualidade"
        '
        'cboControlaQualidade
        '
        resources.ApplyResources(Me.cboControlaQualidade, "cboControlaQualidade")
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem3, "UiComboBoxItem3")
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem4, "UiComboBoxItem4")
        Me.cboControlaQualidade.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboControlaQualidade.Name = "cboControlaQualidade"
        Me.cboControlaQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtObservacao
        '
        resources.ApplyResources(Me.txtObservacao, "txtObservacao")
        Me.txtObservacao.MaxLength = 500
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'lblAponta
        '
        resources.ApplyResources(Me.lblAponta, "lblAponta")
        Me.lblAponta.Name = "lblAponta"
        '
        'cboAponta
        '
        resources.ApplyResources(Me.cboAponta, "cboAponta")
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem5, "UiComboBoxItem5")
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem6, "UiComboBoxItem6")
        Me.cboAponta.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboAponta.Name = "cboAponta"
        Me.cboAponta.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblApontaEquipamento
        '
        resources.ApplyResources(Me.lblApontaEquipamento, "lblApontaEquipamento")
        Me.lblApontaEquipamento.Name = "lblApontaEquipamento"
        '
        'cboApontaEquipamento
        '
        resources.ApplyResources(Me.cboApontaEquipamento, "cboApontaEquipamento")
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem7, "UiComboBoxItem7")
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem8, "UiComboBoxItem8")
        Me.cboApontaEquipamento.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboApontaEquipamento.Name = "cboApontaEquipamento"
        Me.cboApontaEquipamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblSequencia
        '
        resources.ApplyResources(Me.lblSequencia, "lblSequencia")
        Me.lblSequencia.Name = "lblSequencia"
        '
        'txtSequencia
        '
        Me.txtSequencia.DecimalDigits = 0
        resources.ApplyResources(Me.txtSequencia, "txtSequencia")
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtSequencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTempoSetupMaquina
        '
        resources.ApplyResources(Me.lblTempoSetupMaquina, "lblTempoSetupMaquina")
        Me.lblTempoSetupMaquina.Name = "lblTempoSetupMaquina"
        '
        'lblObservacao
        '
        resources.ApplyResources(Me.lblObservacao, "lblObservacao")
        Me.lblObservacao.Name = "lblObservacao"
        '
        'lblOperacao
        '
        resources.ApplyResources(Me.lblOperacao, "lblOperacao")
        Me.lblOperacao.Name = "lblOperacao"
        '
        'cboOperacao
        '
        resources.ApplyResources(Me.cboOperacao, "cboOperacao")
        Me.cboOperacao.Name = "cboOperacao"
        '
        'lblCentroTrabalho
        '
        resources.ApplyResources(Me.lblCentroTrabalho, "lblCentroTrabalho")
        Me.lblCentroTrabalho.Name = "lblCentroTrabalho"
        '
        'cboCentroTrabalho
        '
        resources.ApplyResources(Me.cboCentroTrabalho, "cboCentroTrabalho")
        Me.cboCentroTrabalho.Name = "cboCentroTrabalho"
        '
        'btnCadastrarCentroTrabalho
        '
        Me.btnCadastrarCentroTrabalho.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarCentroTrabalho, "btnCadastrarCentroTrabalho")
        Me.btnCadastrarCentroTrabalho.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroTrabalho.Name = "btnCadastrarCentroTrabalho"
        Me.btnCadastrarCentroTrabalho.TabStop = False
        Me.btnCadastrarCentroTrabalho.UseVisualStyleBackColor = True
        '
        'btnCadastrarOperacao
        '
        Me.btnCadastrarOperacao.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarOperacao, "btnCadastrarOperacao")
        Me.btnCadastrarOperacao.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarOperacao.Name = "btnCadastrarOperacao"
        Me.btnCadastrarOperacao.TabStop = False
        Me.btnCadastrarOperacao.UseVisualStyleBackColor = True
        '
        'btnExcluirRoteiro
        '
        resources.ApplyResources(Me.btnExcluirRoteiro, "btnExcluirRoteiro")
        Me.btnExcluirRoteiro.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirRoteiro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirRoteiro.Name = "btnExcluirRoteiro"
        Me.btnExcluirRoteiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirRoteiro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirRoteiro
        '
        resources.ApplyResources(Me.btnInserirRoteiro, "btnInserirRoteiro")
        Me.btnInserirRoteiro.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirRoteiro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirRoteiro.Name = "btnInserirRoteiro"
        Me.btnInserirRoteiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirRoteiro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAgruparGridRoteiro
        '
        resources.ApplyResources(Me.btnAgruparGridRoteiro, "btnAgruparGridRoteiro")
        Me.btnAgruparGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridRoteiro.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridRoteiro.Name = "btnAgruparGridRoteiro"
        Me.btnAgruparGridRoteiro.TabStop = False
        Me.btnAgruparGridRoteiro.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridRoteiro
        '
        resources.ApplyResources(Me.btnConfigurarGridRoteiro, "btnConfigurarGridRoteiro")
        Me.btnConfigurarGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridRoteiro.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridRoteiro.Name = "btnConfigurarGridRoteiro"
        Me.btnConfigurarGridRoteiro.TabStop = False
        Me.btnConfigurarGridRoteiro.UseVisualStyleBackColor = False
        '
        'grdRoteiro
        '
        Me.grdRoteiro.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdRoteiro.AlternatingColors = True
        resources.ApplyResources(Me.grdRoteiro, "grdRoteiro")
        grdRoteiro_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRoteiro_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRoteiro_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRoteiro_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdRoteiro_DesignTimeLayout, "grdRoteiro_DesignTimeLayout")
        Me.grdRoteiro.DesignTimeLayout = grdRoteiro_DesignTimeLayout
        Me.grdRoteiro.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRoteiro.FrozenColumns = 2
        Me.grdRoteiro.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRoteiro.GroupByBoxVisible = False
        Me.grdRoteiro.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRoteiro.Name = "grdRoteiro"
        Me.grdRoteiro.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRoteiro.RecordNavigator = True
        Me.grdRoteiro.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRoteiro.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRoteiro.TabStop = False
        Me.grdRoteiro.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRoteiro.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRoteiro.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRoteiro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRoteiro.VisualStyleManager = Me.vsmMain
        '
        'pagMaquina
        '
        Me.pagMaquina.Controls.Add(Me.btnExcelGridMaquina)
        Me.pagMaquina.Controls.Add(Me.btnAgruparGridMaquina)
        Me.pagMaquina.Controls.Add(Me.grpMaquina)
        Me.pagMaquina.Controls.Add(Me.btnConfigurarGridMaquina)
        Me.pagMaquina.Controls.Add(Me.grdMaquina)
        Me.pagMaquina.Key = "pagMaquina"
        resources.ApplyResources(Me.pagMaquina, "pagMaquina")
        Me.pagMaquina.Name = "pagMaquina"
        Me.pagMaquina.TabStop = True
        '
        'btnExcelGridMaquina
        '
        resources.ApplyResources(Me.btnExcelGridMaquina, "btnExcelGridMaquina")
        Me.btnExcelGridMaquina.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridMaquina.FlatAppearance.BorderSize = 0
        Me.btnExcelGridMaquina.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridMaquina.Name = "btnExcelGridMaquina"
        Me.btnExcelGridMaquina.TabStop = False
        Me.btnExcelGridMaquina.UseVisualStyleBackColor = False
        '
        'btnAgruparGridMaquina
        '
        resources.ApplyResources(Me.btnAgruparGridMaquina, "btnAgruparGridMaquina")
        Me.btnAgruparGridMaquina.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridMaquina.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridMaquina.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridMaquina.Name = "btnAgruparGridMaquina"
        Me.btnAgruparGridMaquina.TabStop = False
        Me.btnAgruparGridMaquina.UseVisualStyleBackColor = False
        '
        'grpMaquina
        '
        resources.ApplyResources(Me.grpMaquina, "grpMaquina")
        Me.grpMaquina.BackColor = System.Drawing.Color.Transparent
        Me.grpMaquina.Controls.Add(Me.txtDescricaoMaquina)
        Me.grpMaquina.Controls.Add(Me.btnExcluirMaquina)
        Me.grpMaquina.Controls.Add(Me.lblDescricaoMaquina)
        Me.grpMaquina.Controls.Add(Me.btnInserirMaquina)
        Me.grpMaquina.Controls.Add(Me.btnCadastrarMaquina)
        Me.grpMaquina.Controls.Add(Me.cboCodigoMaquina)
        Me.grpMaquina.Controls.Add(Me.lblCodigoMaquina)
        Me.grpMaquina.Name = "grpMaquina"
        Me.grpMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMaquina.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpMaquina.VisualStyleManager = Me.vsmMain
        '
        'txtDescricaoMaquina
        '
        resources.ApplyResources(Me.txtDescricaoMaquina, "txtDescricaoMaquina")
        Me.txtDescricaoMaquina.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoMaquina.MaxLength = 100
        Me.txtDescricaoMaquina.Name = "txtDescricaoMaquina"
        Me.txtDescricaoMaquina.ReadOnly = True
        Me.txtDescricaoMaquina.TabStop = False
        '
        'btnExcluirMaquina
        '
        resources.ApplyResources(Me.btnExcluirMaquina, "btnExcluirMaquina")
        Me.btnExcluirMaquina.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirMaquina.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirMaquina.Name = "btnExcluirMaquina"
        Me.btnExcluirMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirMaquina.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDescricaoMaquina
        '
        resources.ApplyResources(Me.lblDescricaoMaquina, "lblDescricaoMaquina")
        Me.lblDescricaoMaquina.Name = "lblDescricaoMaquina"
        '
        'btnInserirMaquina
        '
        resources.ApplyResources(Me.btnInserirMaquina, "btnInserirMaquina")
        Me.btnInserirMaquina.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirMaquina.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirMaquina.Name = "btnInserirMaquina"
        Me.btnInserirMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirMaquina.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarMaquina
        '
        Me.btnCadastrarMaquina.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarMaquina, "btnCadastrarMaquina")
        Me.btnCadastrarMaquina.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarMaquina.Name = "btnCadastrarMaquina"
        Me.btnCadastrarMaquina.TabStop = False
        Me.btnCadastrarMaquina.UseVisualStyleBackColor = True
        '
        'cboCodigoMaquina
        '
        resources.ApplyResources(Me.cboCodigoMaquina, "cboCodigoMaquina")
        Me.cboCodigoMaquina.Name = "cboCodigoMaquina"
        '
        'lblCodigoMaquina
        '
        resources.ApplyResources(Me.lblCodigoMaquina, "lblCodigoMaquina")
        Me.lblCodigoMaquina.Name = "lblCodigoMaquina"
        '
        'btnConfigurarGridMaquina
        '
        resources.ApplyResources(Me.btnConfigurarGridMaquina, "btnConfigurarGridMaquina")
        Me.btnConfigurarGridMaquina.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridMaquina.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridMaquina.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridMaquina.Name = "btnConfigurarGridMaquina"
        Me.btnConfigurarGridMaquina.TabStop = False
        Me.btnConfigurarGridMaquina.UseVisualStyleBackColor = False
        '
        'grdMaquina
        '
        Me.grdMaquina.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMaquina.AlternatingColors = True
        resources.ApplyResources(Me.grdMaquina, "grdMaquina")
        Me.grdMaquina.ColumnAutoResize = True
        grdMaquina_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdMaquina_DesignTimeLayout_Reference_0.Instance"), Object)
        grdMaquina_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdMaquina_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdMaquina_DesignTimeLayout, "grdMaquina_DesignTimeLayout")
        Me.grdMaquina.DesignTimeLayout = grdMaquina_DesignTimeLayout
        Me.grdMaquina.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMaquina.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMaquina.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMaquina.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMaquina.FrozenColumns = 3
        Me.grdMaquina.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMaquina.GroupByBoxVisible = False
        Me.grdMaquina.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdMaquina.Name = "grdMaquina"
        Me.grdMaquina.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMaquina.RecordNavigator = True
        Me.grdMaquina.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMaquina.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMaquina.TabStop = False
        Me.grdMaquina.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMaquina.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMaquina.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMaquina.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMaquina.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        resources.ApplyResources(Me.grpControl2, "grpControl2")
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl2.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        resources.ApplyResources(Me.lblCongelarColuna, "lblCongelarColuna")
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        '
        'cboCongelarColuna
        '
        resources.ApplyResources(Me.cboCongelarColuna, "cboCongelarColuna")
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.TabStop = False
        '
        'btnNovo
        '
        resources.ApplyResources(Me.btnNovo, "btnNovo")
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        resources.ApplyResources(Me.btnSalvar, "btnSalvar")
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        resources.ApplyResources(Me.btnVoltar, "btnVoltar")
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblModeloOrdemProducao)
        Me.grpDados.Controls.Add(Me.cboModeloOrdemProducao)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblModeloOrdemProducao
        '
        resources.ApplyResources(Me.lblModeloOrdemProducao, "lblModeloOrdemProducao")
        Me.lblModeloOrdemProducao.Name = "lblModeloOrdemProducao"
        '
        'cboModeloOrdemProducao
        '
        resources.ApplyResources(Me.cboModeloOrdemProducao, "cboModeloOrdemProducao")
        Me.cboModeloOrdemProducao.Name = "cboModeloOrdemProducao"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtCodigo, "txtCodigo")
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        '
        'lblCodigo
        '
        resources.ApplyResources(Me.lblCodigo, "lblCodigo")
        Me.lblCodigo.Name = "lblCodigo"
        '
        'txtDescricao
        '
        resources.ApplyResources(Me.txtDescricao, "txtDescricao")
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.MaxLength = 250
        Me.txtDescricao.Name = "txtDescricao"
        '
        'lblDescricao
        '
        resources.ApplyResources(Me.lblDescricao, "lblDescricao")
        Me.lblDescricao.Name = "lblDescricao"
        '
        'UiButton2
        '
        Me.UiButton2.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.UiButton2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.UiButton2, "UiButton2")
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadRoteiroProducao
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadRoteiroProducao"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagRoteiro.ResumeLayout(False)
        CType(Me.grpRoteiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRoteiro.ResumeLayout(False)
        Me.grpRoteiro.PerformLayout()
        CType(Me.grdRoteiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagMaquina.ResumeLayout(False)
        CType(Me.grpMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaquina.ResumeLayout(False)
        Me.grpMaquina.PerformLayout()
        CType(Me.grdMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.grpControl2.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiComboBox1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiComboBox2 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagRoteiro As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpRoteiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblApontamentoConcorrente As System.Windows.Forms.Label
    Friend WithEvents cboApontamentoConcorrente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSequenciaPredecessora As System.Windows.Forms.Label
    Friend WithEvents cboSequenciaPredecessora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents lblTempoMaquina As System.Windows.Forms.Label
    Friend WithEvents lblTempoMaoObra As System.Windows.Forms.Label
    Friend WithEvents lblControlaQualidade As System.Windows.Forms.Label
    Friend WithEvents cboControlaQualidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblAponta As System.Windows.Forms.Label
    Friend WithEvents cboAponta As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblApontaEquipamento As System.Windows.Forms.Label
    Friend WithEvents cboApontaEquipamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSequencia As System.Windows.Forms.Label
    Friend WithEvents txtSequencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTempoSetupMaquina As System.Windows.Forms.Label
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroTrabalho As System.Windows.Forms.Label
    Friend WithEvents cboCentroTrabalho As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarCentroTrabalho As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarOperacao As System.Windows.Forms.Button
    Friend WithEvents btnExcluirRoteiro As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirRoteiro As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdRoteiro As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCodigoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescricaoMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoMaquina As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarMaquina As System.Windows.Forms.Button
    Friend WithEvents lblCodigoMaquina As System.Windows.Forms.Label
    Friend WithEvents cboCodigoMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagMaquina As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGridMaquina As System.Windows.Forms.Button
    Friend WithEvents grpMaquina As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirMaquina As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirMaquina As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGridMaquina As System.Windows.Forms.Button
    Friend WithEvents grdMaquina As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtTempoMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTempoMaoObra As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTempoSetupMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblReferenciaMolde As System.Windows.Forms.Label
    Friend WithEvents cboReferenciaMolde As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridMaquina As System.Windows.Forms.Button
    Friend WithEvents lblModeloOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents cboModeloOrdemProducao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModeloOrdemProducaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboModeloOrdemProducaoFiltro As Janus.Windows.EditControls.UIComboBox

End Class
