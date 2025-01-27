<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadVeiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadVeiculo))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem9 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem10 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem11 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem12 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdManutencao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdManutencao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem13 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem14 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdDocumento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdDocumento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdDocumento_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim UiComboBoxItem15 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem16 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboCentroGastoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGastoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtRenavanFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRenavanFiltro = New System.Windows.Forms.Label()
        Me.txtPlacaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlacaFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroSerieFiltro = New System.Windows.Forms.Label()
        Me.lblAnoFiltro = New System.Windows.Forms.Label()
        Me.cboAnoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoVeiculoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoVeiculoFiltro = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataAquisicao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataAquisicao = New System.Windows.Forms.Label()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.btnCadastrarTipoVeiculo = New System.Windows.Forms.Button()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.txtRenavan = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRenavan = New System.Windows.Forms.Label()
        Me.txtPlaca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.txtNumeroSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroSerie = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.cboAno = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.cboTipoVeiculo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoVeiculo = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGridManutencao = New System.Windows.Forms.Button()
        Me.grdManutencao = New Janus.Windows.GridEX.GridEX()
        Me.grbManutencao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAlertaAntecedenciaManutencao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAlertaAntecedenciaManutencao = New System.Windows.Forms.Label()
        Me.txtHoraKM = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblHoraKm = New System.Windows.Forms.Label()
        Me.btnCadastrarManutencao = New System.Windows.Forms.Button()
        Me.cboManutencao = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcluirManutencao = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirManutencao = New Janus.Windows.EditControls.UIButton()
        Me.lblManutencao = New System.Windows.Forms.Label()
        Me.pagDocumento = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGridDocumento = New System.Windows.Forms.Button()
        Me.grdDocumento = New Janus.Windows.GridEX.GridEX()
        Me.grpDocumento = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivoDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnArquivoDocumento = New Janus.Windows.EditControls.UIButton()
        Me.txtAlertaAntecedenciaDia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAlertaAntecedenciaDia = New System.Windows.Forms.Label()
        Me.dtpDataValidadeDocumento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoDocumento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnCadastrarDocumento = New System.Windows.Forms.Button()
        Me.lblDataValidadeDocumento = New System.Windows.Forms.Label()
        Me.lblDataEmissaoDocumento = New System.Windows.Forms.Label()
        Me.cboDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.btnExcluirDocumento = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirDocumento = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grdManutencao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbManutencao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbManutencao.SuspendLayout()
        Me.pagDocumento.SuspendLayout()
        CType(Me.grdDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDocumento.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.UiGroupBox1)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        resources.ApplyResources(Me.pagLista, "pagLista")
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Name = "pagLista"
        Me.pagLista.TabStop = True
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnConfigurarGrid, "btnConfigurarGrid")
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.cboCentroGastoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblCentroGastoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.btnFiltrar)
        Me.UiGroupBox1.Controls.Add(Me.txtRenavanFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblRenavanFiltro)
        Me.UiGroupBox1.Controls.Add(Me.txtPlacaFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblPlacaFiltro)
        Me.UiGroupBox1.Controls.Add(Me.txtNumeroSerieFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblNumeroSerieFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblAnoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.cboAnoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.txtDescricaoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblDescricaoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.cboTipoVeiculoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblTipoVeiculoFiltro)
        resources.ApplyResources(Me.UiGroupBox1, "UiGroupBox1")
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'cboCentroGastoFiltro
        '
        resources.ApplyResources(Me.cboCentroGastoFiltro, "cboCentroGastoFiltro")
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem1, "UiComboBoxItem1")
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem2, "UiComboBoxItem2")
        Me.cboCentroGastoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCentroGastoFiltro.Name = "cboCentroGastoFiltro"
        Me.cboCentroGastoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCentroGastoFiltro
        '
        resources.ApplyResources(Me.lblCentroGastoFiltro, "lblCentroGastoFiltro")
        Me.lblCentroGastoFiltro.Name = "lblCentroGastoFiltro"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnFiltrar, "btnFiltrar")
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtRenavanFiltro
        '
        Me.txtRenavanFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtRenavanFiltro, "txtRenavanFiltro")
        Me.txtRenavanFiltro.MaxLength = 50
        Me.txtRenavanFiltro.Name = "txtRenavanFiltro"
        '
        'lblRenavanFiltro
        '
        resources.ApplyResources(Me.lblRenavanFiltro, "lblRenavanFiltro")
        Me.lblRenavanFiltro.Name = "lblRenavanFiltro"
        '
        'txtPlacaFiltro
        '
        Me.txtPlacaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtPlacaFiltro, "txtPlacaFiltro")
        Me.txtPlacaFiltro.Mask = "LLL-0000"
        Me.txtPlacaFiltro.Name = "txtPlacaFiltro"
        '
        'lblPlacaFiltro
        '
        resources.ApplyResources(Me.lblPlacaFiltro, "lblPlacaFiltro")
        Me.lblPlacaFiltro.Name = "lblPlacaFiltro"
        '
        'txtNumeroSerieFiltro
        '
        Me.txtNumeroSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNumeroSerieFiltro, "txtNumeroSerieFiltro")
        Me.txtNumeroSerieFiltro.MaxLength = 50
        Me.txtNumeroSerieFiltro.Name = "txtNumeroSerieFiltro"
        '
        'lblNumeroSerieFiltro
        '
        resources.ApplyResources(Me.lblNumeroSerieFiltro, "lblNumeroSerieFiltro")
        Me.lblNumeroSerieFiltro.Name = "lblNumeroSerieFiltro"
        '
        'lblAnoFiltro
        '
        resources.ApplyResources(Me.lblAnoFiltro, "lblAnoFiltro")
        Me.lblAnoFiltro.Name = "lblAnoFiltro"
        '
        'cboAnoFiltro
        '
        resources.ApplyResources(Me.cboAnoFiltro, "cboAnoFiltro")
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem3, "UiComboBoxItem3")
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem4, "UiComboBoxItem4")
        Me.cboAnoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboAnoFiltro.Name = "cboAnoFiltro"
        Me.cboAnoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtDescricaoFiltro, "txtDescricaoFiltro")
        Me.txtDescricaoFiltro.MaxLength = 50
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        '
        'lblDescricaoFiltro
        '
        resources.ApplyResources(Me.lblDescricaoFiltro, "lblDescricaoFiltro")
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        '
        'cboTipoVeiculoFiltro
        '
        resources.ApplyResources(Me.cboTipoVeiculoFiltro, "cboTipoVeiculoFiltro")
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem5, "UiComboBoxItem5")
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem6, "UiComboBoxItem6")
        Me.cboTipoVeiculoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboTipoVeiculoFiltro.Name = "cboTipoVeiculoFiltro"
        Me.cboTipoVeiculoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblTipoVeiculoFiltro
        '
        resources.ApplyResources(Me.lblTipoVeiculoFiltro, "lblTipoVeiculoFiltro")
        Me.lblTipoVeiculoFiltro.Name = "lblTipoVeiculoFiltro"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Manual
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnExcel, "btnExcel")
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnNovo1, "btnNovo1")
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnExcluir, "btnExcluir")
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Key = "padDados"
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.dtpDataAquisicao)
        Me.grpDados.Controls.Add(Me.lblDataAquisicao)
        Me.grpDados.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpDados.Controls.Add(Me.btnCadastrarTipoVeiculo)
        Me.grpDados.Controls.Add(Me.cboCentroGasto)
        Me.grpDados.Controls.Add(Me.lblCentroGasto)
        Me.grpDados.Controls.Add(Me.txtRenavan)
        Me.grpDados.Controls.Add(Me.lblRenavan)
        Me.grpDados.Controls.Add(Me.txtPlaca)
        Me.grpDados.Controls.Add(Me.lblPlaca)
        Me.grpDados.Controls.Add(Me.txtNumeroSerie)
        Me.grpDados.Controls.Add(Me.lblNumeroSerie)
        Me.grpDados.Controls.Add(Me.lblAno)
        Me.grpDados.Controls.Add(Me.cboAno)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.cboTipoVeiculo)
        Me.grpDados.Controls.Add(Me.lblTipoVeiculo)
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'dtpDataAquisicao
        '
        '
        '
        '
        Me.dtpDataAquisicao.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataAquisicao, "dtpDataAquisicao")
        Me.dtpDataAquisicao.Name = "dtpDataAquisicao"
        Me.dtpDataAquisicao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataAquisicao
        '
        resources.ApplyResources(Me.lblDataAquisicao, "lblDataAquisicao")
        Me.lblDataAquisicao.Name = "lblDataAquisicao"
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarCentroGasto, "btnCadastrarCentroGasto")
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnCadastrarTipoVeiculo
        '
        Me.btnCadastrarTipoVeiculo.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarTipoVeiculo, "btnCadastrarTipoVeiculo")
        Me.btnCadastrarTipoVeiculo.Name = "btnCadastrarTipoVeiculo"
        Me.btnCadastrarTipoVeiculo.TabStop = False
        Me.btnCadastrarTipoVeiculo.UseVisualStyleBackColor = True
        '
        'cboCentroGasto
        '
        resources.ApplyResources(Me.cboCentroGasto, "cboCentroGasto")
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem7, "UiComboBoxItem7")
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem8, "UiComboBoxItem8")
        Me.cboCentroGasto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCentroGasto
        '
        resources.ApplyResources(Me.lblCentroGasto, "lblCentroGasto")
        Me.lblCentroGasto.Name = "lblCentroGasto"
        '
        'txtRenavan
        '
        Me.txtRenavan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtRenavan, "txtRenavan")
        Me.txtRenavan.MaxLength = 50
        Me.txtRenavan.Name = "txtRenavan"
        '
        'lblRenavan
        '
        resources.ApplyResources(Me.lblRenavan, "lblRenavan")
        Me.lblRenavan.Name = "lblRenavan"
        '
        'txtPlaca
        '
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtPlaca, "txtPlaca")
        Me.txtPlaca.Mask = "LLL-0000"
        Me.txtPlaca.Name = "txtPlaca"
        '
        'lblPlaca
        '
        resources.ApplyResources(Me.lblPlaca, "lblPlaca")
        Me.lblPlaca.Name = "lblPlaca"
        '
        'txtNumeroSerie
        '
        Me.txtNumeroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNumeroSerie, "txtNumeroSerie")
        Me.txtNumeroSerie.MaxLength = 50
        Me.txtNumeroSerie.Name = "txtNumeroSerie"
        '
        'lblNumeroSerie
        '
        resources.ApplyResources(Me.lblNumeroSerie, "lblNumeroSerie")
        Me.lblNumeroSerie.Name = "lblNumeroSerie"
        '
        'lblAno
        '
        resources.ApplyResources(Me.lblAno, "lblAno")
        Me.lblAno.Name = "lblAno"
        '
        'cboAno
        '
        resources.ApplyResources(Me.cboAno, "cboAno")
        UiComboBoxItem9.FormatStyle.Alpha = 0
        UiComboBoxItem9.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem9, "UiComboBoxItem9")
        UiComboBoxItem10.FormatStyle.Alpha = 0
        UiComboBoxItem10.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem10, "UiComboBoxItem10")
        Me.cboAno.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem9, UiComboBoxItem10})
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtDescricao, "txtDescricao")
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        '
        'lblDescricao
        '
        resources.ApplyResources(Me.lblDescricao, "lblDescricao")
        Me.lblDescricao.Name = "lblDescricao"
        '
        'cboTipoVeiculo
        '
        resources.ApplyResources(Me.cboTipoVeiculo, "cboTipoVeiculo")
        UiComboBoxItem11.FormatStyle.Alpha = 0
        UiComboBoxItem11.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem11, "UiComboBoxItem11")
        UiComboBoxItem12.FormatStyle.Alpha = 0
        UiComboBoxItem12.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem12, "UiComboBoxItem12")
        Me.cboTipoVeiculo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem11, UiComboBoxItem12})
        Me.cboTipoVeiculo.Name = "cboTipoVeiculo"
        Me.cboTipoVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblTipoVeiculo
        '
        resources.ApplyResources(Me.lblTipoVeiculo, "lblTipoVeiculo")
        Me.lblTipoVeiculo.Name = "lblTipoVeiculo"
        '
        'tabDados
        '
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosGerais, Me.pagDocumento})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDadosGerais
        '
        Me.pagDadosGerais.Controls.Add(Me.btnConfigurarGridManutencao)
        Me.pagDadosGerais.Controls.Add(Me.grdManutencao)
        Me.pagDadosGerais.Controls.Add(Me.grbManutencao)
        Me.pagDadosGerais.Key = "pagDadosGerais"
        resources.ApplyResources(Me.pagDadosGerais, "pagDadosGerais")
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.TabStop = True
        '
        'btnConfigurarGridManutencao
        '
        Me.btnConfigurarGridManutencao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridManutencao.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnConfigurarGridManutencao, "btnConfigurarGridManutencao")
        Me.btnConfigurarGridManutencao.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridManutencao.Name = "btnConfigurarGridManutencao"
        Me.btnConfigurarGridManutencao.TabStop = False
        Me.btnConfigurarGridManutencao.UseVisualStyleBackColor = False
        '
        'grdManutencao
        '
        Me.grdManutencao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdManutencao.AlternatingColors = True
        grdManutencao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdManutencao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdManutencao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdManutencao_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdManutencao_DesignTimeLayout, "grdManutencao_DesignTimeLayout")
        Me.grdManutencao.DesignTimeLayout = grdManutencao_DesignTimeLayout
        Me.grdManutencao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        resources.ApplyResources(Me.grdManutencao, "grdManutencao")
        Me.grdManutencao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdManutencao.GroupByBoxVisible = False
        Me.grdManutencao.Name = "grdManutencao"
        Me.grdManutencao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdManutencao.RecordNavigator = True
        Me.grdManutencao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdManutencao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdManutencao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdManutencao.TabStop = False
        Me.grdManutencao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdManutencao.VisualStyleManager = Me.vsmMain
        '
        'grbManutencao
        '
        Me.grbManutencao.BackColor = System.Drawing.Color.Transparent
        Me.grbManutencao.Controls.Add(Me.txtAlertaAntecedenciaManutencao)
        Me.grbManutencao.Controls.Add(Me.lblAlertaAntecedenciaManutencao)
        Me.grbManutencao.Controls.Add(Me.txtHoraKM)
        Me.grbManutencao.Controls.Add(Me.lblHoraKm)
        Me.grbManutencao.Controls.Add(Me.btnCadastrarManutencao)
        Me.grbManutencao.Controls.Add(Me.cboManutencao)
        Me.grbManutencao.Controls.Add(Me.btnExcluirManutencao)
        Me.grbManutencao.Controls.Add(Me.btnInserirManutencao)
        Me.grbManutencao.Controls.Add(Me.lblManutencao)
        Me.grbManutencao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.grbManutencao, "grbManutencao")
        Me.grbManutencao.Name = "grbManutencao"
        Me.grbManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grbManutencao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grbManutencao.VisualStyleManager = Me.vsmMain
        '
        'txtAlertaAntecedenciaManutencao
        '
        Me.txtAlertaAntecedenciaManutencao.DecimalDigits = 0
        resources.ApplyResources(Me.txtAlertaAntecedenciaManutencao, "txtAlertaAntecedenciaManutencao")
        Me.txtAlertaAntecedenciaManutencao.Name = "txtAlertaAntecedenciaManutencao"
        Me.txtAlertaAntecedenciaManutencao.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAlertaAntecedenciaManutencao
        '
        resources.ApplyResources(Me.lblAlertaAntecedenciaManutencao, "lblAlertaAntecedenciaManutencao")
        Me.lblAlertaAntecedenciaManutencao.Name = "lblAlertaAntecedenciaManutencao"
        '
        'txtHoraKM
        '
        Me.txtHoraKM.DecimalDigits = 0
        resources.ApplyResources(Me.txtHoraKM, "txtHoraKM")
        Me.txtHoraKM.Name = "txtHoraKM"
        Me.txtHoraKM.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblHoraKm
        '
        resources.ApplyResources(Me.lblHoraKm, "lblHoraKm")
        Me.lblHoraKm.Name = "lblHoraKm"
        '
        'btnCadastrarManutencao
        '
        Me.btnCadastrarManutencao.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarManutencao, "btnCadastrarManutencao")
        Me.btnCadastrarManutencao.Name = "btnCadastrarManutencao"
        Me.btnCadastrarManutencao.TabStop = False
        Me.btnCadastrarManutencao.UseVisualStyleBackColor = True
        '
        'cboManutencao
        '
        resources.ApplyResources(Me.cboManutencao, "cboManutencao")
        UiComboBoxItem13.FormatStyle.Alpha = 0
        UiComboBoxItem13.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem13, "UiComboBoxItem13")
        UiComboBoxItem14.FormatStyle.Alpha = 0
        UiComboBoxItem14.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem14, "UiComboBoxItem14")
        Me.cboManutencao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem13, UiComboBoxItem14})
        Me.cboManutencao.Name = "cboManutencao"
        Me.cboManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'btnExcluirManutencao
        '
        Me.btnExcluirManutencao.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirManutencao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnExcluirManutencao, "btnExcluirManutencao")
        Me.btnExcluirManutencao.Name = "btnExcluirManutencao"
        Me.btnExcluirManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirManutencao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirManutencao
        '
        Me.btnInserirManutencao.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirManutencao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnInserirManutencao, "btnInserirManutencao")
        Me.btnInserirManutencao.Name = "btnInserirManutencao"
        Me.btnInserirManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirManutencao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblManutencao
        '
        resources.ApplyResources(Me.lblManutencao, "lblManutencao")
        Me.lblManutencao.Name = "lblManutencao"
        '
        'pagDocumento
        '
        Me.pagDocumento.Controls.Add(Me.btnConfigurarGridDocumento)
        Me.pagDocumento.Controls.Add(Me.grdDocumento)
        Me.pagDocumento.Controls.Add(Me.grpDocumento)
        Me.pagDocumento.Key = "pagDocumento"
        resources.ApplyResources(Me.pagDocumento, "pagDocumento")
        Me.pagDocumento.Name = "pagDocumento"
        Me.pagDocumento.TabStop = True
        '
        'btnConfigurarGridDocumento
        '
        Me.btnConfigurarGridDocumento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridDocumento.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnConfigurarGridDocumento, "btnConfigurarGridDocumento")
        Me.btnConfigurarGridDocumento.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridDocumento.Name = "btnConfigurarGridDocumento"
        Me.btnConfigurarGridDocumento.TabStop = False
        Me.btnConfigurarGridDocumento.UseVisualStyleBackColor = False
        '
        'grdDocumento
        '
        Me.grdDocumento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdDocumento.AlternatingColors = True
        grdDocumento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdDocumento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdDocumento_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdDocumento_DesignTimeLayout_Reference_1.Instance"), Object)
        grdDocumento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdDocumento_DesignTimeLayout_Reference_0, grdDocumento_DesignTimeLayout_Reference_1})
        resources.ApplyResources(grdDocumento_DesignTimeLayout, "grdDocumento_DesignTimeLayout")
        Me.grdDocumento.DesignTimeLayout = grdDocumento_DesignTimeLayout
        Me.grdDocumento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        resources.ApplyResources(Me.grdDocumento, "grdDocumento")
        Me.grdDocumento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDocumento.GroupByBoxVisible = False
        Me.grdDocumento.Name = "grdDocumento"
        Me.grdDocumento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDocumento.RecordNavigator = True
        Me.grdDocumento.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDocumento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDocumento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDocumento.TabStop = False
        Me.grdDocumento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDocumento.VisualStyleManager = Me.vsmMain
        '
        'grpDocumento
        '
        Me.grpDocumento.BackColor = System.Drawing.Color.Transparent
        Me.grpDocumento.Controls.Add(Me.lblArquivo)
        Me.grpDocumento.Controls.Add(Me.txtArquivoDocumento)
        Me.grpDocumento.Controls.Add(Me.btnArquivoDocumento)
        Me.grpDocumento.Controls.Add(Me.txtAlertaAntecedenciaDia)
        Me.grpDocumento.Controls.Add(Me.lblAlertaAntecedenciaDia)
        Me.grpDocumento.Controls.Add(Me.dtpDataValidadeDocumento)
        Me.grpDocumento.Controls.Add(Me.dtpDataEmissaoDocumento)
        Me.grpDocumento.Controls.Add(Me.btnCadastrarDocumento)
        Me.grpDocumento.Controls.Add(Me.lblDataValidadeDocumento)
        Me.grpDocumento.Controls.Add(Me.lblDataEmissaoDocumento)
        Me.grpDocumento.Controls.Add(Me.cboDocumento)
        Me.grpDocumento.Controls.Add(Me.lblDocumento)
        Me.grpDocumento.Controls.Add(Me.btnExcluirDocumento)
        Me.grpDocumento.Controls.Add(Me.btnInserirDocumento)
        Me.grpDocumento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.grpDocumento, "grpDocumento")
        Me.grpDocumento.Name = "grpDocumento"
        Me.grpDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDocumento.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDocumento.VisualStyleManager = Me.vsmMain
        '
        'lblArquivo
        '
        resources.ApplyResources(Me.lblArquivo, "lblArquivo")
        Me.lblArquivo.Name = "lblArquivo"
        '
        'txtArquivoDocumento
        '
        resources.ApplyResources(Me.txtArquivoDocumento, "txtArquivoDocumento")
        Me.txtArquivoDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivoDocumento.MaxLength = 60
        Me.txtArquivoDocumento.Name = "txtArquivoDocumento"
        Me.txtArquivoDocumento.ReadOnly = True
        Me.txtArquivoDocumento.TabStop = False
        '
        'btnArquivoDocumento
        '
        resources.ApplyResources(Me.btnArquivoDocumento, "btnArquivoDocumento")
        Me.btnArquivoDocumento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivoDocumento.Name = "btnArquivoDocumento"
        Me.btnArquivoDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivoDocumento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtAlertaAntecedenciaDia
        '
        Me.txtAlertaAntecedenciaDia.DecimalDigits = 0
        resources.ApplyResources(Me.txtAlertaAntecedenciaDia, "txtAlertaAntecedenciaDia")
        Me.txtAlertaAntecedenciaDia.Name = "txtAlertaAntecedenciaDia"
        Me.txtAlertaAntecedenciaDia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAlertaAntecedenciaDia
        '
        resources.ApplyResources(Me.lblAlertaAntecedenciaDia, "lblAlertaAntecedenciaDia")
        Me.lblAlertaAntecedenciaDia.Name = "lblAlertaAntecedenciaDia"
        '
        'dtpDataValidadeDocumento
        '
        '
        '
        '
        Me.dtpDataValidadeDocumento.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataValidadeDocumento, "dtpDataValidadeDocumento")
        Me.dtpDataValidadeDocumento.Name = "dtpDataValidadeDocumento"
        Me.dtpDataValidadeDocumento.ShowCheckBox = True
        Me.dtpDataValidadeDocumento.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoDocumento
        '
        '
        '
        '
        Me.dtpDataEmissaoDocumento.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataEmissaoDocumento, "dtpDataEmissaoDocumento")
        Me.dtpDataEmissaoDocumento.Name = "dtpDataEmissaoDocumento"
        Me.dtpDataEmissaoDocumento.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'btnCadastrarDocumento
        '
        Me.btnCadastrarDocumento.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarDocumento, "btnCadastrarDocumento")
        Me.btnCadastrarDocumento.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarDocumento.Name = "btnCadastrarDocumento"
        Me.btnCadastrarDocumento.TabStop = False
        Me.btnCadastrarDocumento.UseVisualStyleBackColor = True
        '
        'lblDataValidadeDocumento
        '
        resources.ApplyResources(Me.lblDataValidadeDocumento, "lblDataValidadeDocumento")
        Me.lblDataValidadeDocumento.Name = "lblDataValidadeDocumento"
        '
        'lblDataEmissaoDocumento
        '
        resources.ApplyResources(Me.lblDataEmissaoDocumento, "lblDataEmissaoDocumento")
        Me.lblDataEmissaoDocumento.Name = "lblDataEmissaoDocumento"
        '
        'cboDocumento
        '
        resources.ApplyResources(Me.cboDocumento, "cboDocumento")
        UiComboBoxItem15.FormatStyle.Alpha = 0
        UiComboBoxItem15.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem15, "UiComboBoxItem15")
        UiComboBoxItem16.FormatStyle.Alpha = 0
        UiComboBoxItem16.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem16, "UiComboBoxItem16")
        Me.cboDocumento.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem15, UiComboBoxItem16})
        Me.cboDocumento.Name = "cboDocumento"
        Me.cboDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblDocumento
        '
        resources.ApplyResources(Me.lblDocumento, "lblDocumento")
        Me.lblDocumento.Name = "lblDocumento"
        '
        'btnExcluirDocumento
        '
        Me.btnExcluirDocumento.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirDocumento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnExcluirDocumento, "btnExcluirDocumento")
        Me.btnExcluirDocumento.Name = "btnExcluirDocumento"
        Me.btnExcluirDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirDocumento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirDocumento
        '
        Me.btnInserirDocumento.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirDocumento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnInserirDocumento, "btnInserirDocumento")
        Me.btnInserirDocumento.Name = "btnInserirDocumento"
        Me.btnInserirDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirDocumento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl2
        '
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        resources.ApplyResources(Me.grpControl2, "grpControl2")
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnNovo, "btnNovo")
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnVoltar, "btnVoltar")
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnSalvar, "btnSalvar")
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Key = "pagVendas"
        resources.ApplyResources(Me.UiTabPage1, "UiTabPage1")
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.TabStop = True
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 3000
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadVeiculo
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadVeiculo"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDadosGerais.ResumeLayout(False)
        CType(Me.grdManutencao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbManutencao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbManutencao.ResumeLayout(False)
        Me.grbManutencao.PerformLayout()
        Me.pagDocumento.ResumeLayout(False)
        CType(Me.grdDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDocumento.ResumeLayout(False)
        Me.grpDocumento.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
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
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents pagDocumento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataAquisicao As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarTipoVeiculo As System.Windows.Forms.Button
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents txtRenavan As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRenavan As System.Windows.Forms.Label
    Friend WithEvents txtPlaca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlaca As System.Windows.Forms.Label
    Friend WithEvents txtNumeroSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroSerie As System.Windows.Forms.Label
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents cboAno As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents cboTipoVeiculo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoVeiculo As System.Windows.Forms.Label
    Friend WithEvents grdManutencao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grbManutencao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtHoraKM As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblHoraKm As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarManutencao As System.Windows.Forms.Button
    Friend WithEvents cboManutencao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluirManutencao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirManutencao As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblManutencao As System.Windows.Forms.Label
    Friend WithEvents grdDocumento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpDocumento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarDocumento As System.Windows.Forms.Button
    Friend WithEvents lblDataValidadeDocumento As System.Windows.Forms.Label
    Friend WithEvents lblDataEmissaoDocumento As System.Windows.Forms.Label
    Friend WithEvents cboDocumento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents btnExcluirDocumento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirDocumento As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboCentroGastoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGastoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtRenavanFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRenavanFiltro As System.Windows.Forms.Label
    Friend WithEvents txtPlacaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlacaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents lblAnoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAnoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoVeiculoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoVeiculoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataAquisicao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataValidadeDocumento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoDocumento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtAlertaAntecedenciaManutencao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAlertaAntecedenciaManutencao As System.Windows.Forms.Label
    Friend WithEvents txtAlertaAntecedenciaDia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAlertaAntecedenciaDia As System.Windows.Forms.Label
    Friend WithEvents txtArquivoDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnArquivoDocumento As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridManutencao As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridDocumento As System.Windows.Forms.Button

End Class
