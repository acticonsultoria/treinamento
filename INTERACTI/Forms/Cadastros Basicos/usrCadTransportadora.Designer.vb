<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadTransportadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadTransportadora))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim grdContato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdContato_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdContato_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdMotorista_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMotorista_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdVeiculo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdVeiculo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboImportado = New Janus.Windows.EditControls.UIComboBox()
        Me.txtMunicipioFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMunicipioFiltro = New System.Windows.Forms.Label()
        Me.lblUFFiltro = New System.Windows.Forms.Label()
        Me.cboUFFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCnpjCpfFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCnpjCpfFiltro = New System.Windows.Forms.Label()
        Me.txtNomeFantasiaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeFantasiaFiltro = New System.Windows.Forms.Label()
        Me.txtRazaoSocialFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRazaoSocialFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.cboPersonalidadeFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPersonalidadeFiltro = New System.Windows.Forms.Label()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkMotorista = New Janus.Windows.EditControls.UICheckBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPersonalidade = New System.Windows.Forms.Label()
        Me.cboPersonalidade = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNomeFantasia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeFantasia = New System.Windows.Forms.Label()
        Me.txtRazaoSocial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRazaoSocial = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosGerais = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCEP = New System.Windows.Forms.Button()
        Me.txtTelefoneRecado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefoneRecado = New System.Windows.Forms.Label()
        Me.txtFax = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.txtTelefone2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefone2 = New System.Windows.Forms.Label()
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefone1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefone1 = New System.Windows.Forms.Label()
        Me.cboMunicipio = New Janus.Windows.EditControls.UIComboBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.cboUF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.txtInscricaoEstadual = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadual = New System.Windows.Forms.Label()
        Me.txtCnpjCpf = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCnpjCpf = New System.Windows.Forms.Label()
        Me.txtLogradouro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCEP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.pagContato = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridContato = New System.Windows.Forms.Button()
        Me.btnAgruparGridContato = New System.Windows.Forms.Button()
        Me.grpEndereco = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarTipoContato = New System.Windows.Forms.Button()
        Me.dtpDataAniversario = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataAniversario = New System.Windows.Forms.Label()
        Me.txtCelularContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCelularContato = New System.Windows.Forms.Label()
        Me.txtTelefoneContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoContato = New System.Windows.Forms.Label()
        Me.cboTipoContato = New Janus.Windows.EditControls.UIComboBox()
        Me.txtEmailContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplementoContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNomeContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplementoContato = New System.Windows.Forms.Label()
        Me.lblEmailContato = New System.Windows.Forms.Label()
        Me.lblTelefoneContato = New System.Windows.Forms.Label()
        Me.lblNomeContato = New System.Windows.Forms.Label()
        Me.btnExcluirContato = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvarContato = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGridContato = New System.Windows.Forms.Button()
        Me.grdContato = New Janus.Windows.GridEX.GridEX()
        Me.pagVeiculo = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridVeiculo = New System.Windows.Forms.Button()
        Me.btnAgruparGridVeiculo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridVeiculo = New System.Windows.Forms.Button()
        Me.grpVeiculo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDescricaoVeiculo = New System.Windows.Forms.Label()
        Me.txtDescricaoVeiculo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRNTCVeiculo = New System.Windows.Forms.Label()
        Me.txtRNTCVeiculo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboUFVeiculo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUFVeiculo = New System.Windows.Forms.Label()
        Me.txtPlacaVeiculo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlacaVeiculo = New System.Windows.Forms.Label()
        Me.btnExcluirVeiculo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirVeiculo = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdMotorista = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataVencimentoCNH = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNumeroCNH = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataVencimentoNTT = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataVencimentoNTT = New System.Windows.Forms.Label()
        Me.lblNumeroNTT = New System.Windows.Forms.Label()
        Me.txtNumeroNTT = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboMunicipioMotorista = New Janus.Windows.EditControls.UIComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboUFMotorista = New Janus.Windows.EditControls.UIComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEnderecoMotorista = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCEPMotorista = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDataNascimentoMotorista = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataNascimentoMotorista = New System.Windows.Forms.Label()
        Me.lblRGMotorista = New System.Windows.Forms.Label()
        Me.txtRGMotorista = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCPFMotorista = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCPFMotorista = New System.Windows.Forms.Label()
        Me.lblNomeMotorista = New System.Windows.Forms.Label()
        Me.txtNomeMotorista = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPIS = New System.Windows.Forms.Label()
        Me.txtPISNITMotorista = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtPlacaMotorista = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlacaMotorista = New System.Windows.Forms.Label()
        Me.btnExcluirMotorista = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirMotorista = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.grdVeiculo = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosGerais.SuspendLayout()
        Me.pagContato.SuspendLayout()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEndereco.SuspendLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagVeiculo.SuspendLayout()
        CType(Me.grpVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVeiculo.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.grdMotorista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grdVeiculo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        resources.ApplyResources(Me.pagLista, "pagLista")
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Name = "pagLista"
        Me.pagLista.TabStop = True
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
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.FrozenColumns = 3
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
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
        Me.grpFiltro.Controls.Add(Me.Label1)
        Me.grpFiltro.Controls.Add(Me.cboImportado)
        Me.grpFiltro.Controls.Add(Me.txtMunicipioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMunicipioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblUFFiltro)
        Me.grpFiltro.Controls.Add(Me.cboUFFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCnpjCpfFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCnpjCpfFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNomeFantasiaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNomeFantasiaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtRazaoSocialFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRazaoSocialFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.cboPersonalidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPersonalidadeFiltro)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cboImportado
        '
        resources.ApplyResources(Me.cboImportado, "cboImportado")
        Me.cboImportado.Name = "cboImportado"
        Me.cboImportado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtMunicipioFiltro
        '
        resources.ApplyResources(Me.txtMunicipioFiltro, "txtMunicipioFiltro")
        Me.txtMunicipioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMunicipioFiltro.MaxLength = 100
        Me.txtMunicipioFiltro.Name = "txtMunicipioFiltro"
        '
        'lblMunicipioFiltro
        '
        resources.ApplyResources(Me.lblMunicipioFiltro, "lblMunicipioFiltro")
        Me.lblMunicipioFiltro.Name = "lblMunicipioFiltro"
        '
        'lblUFFiltro
        '
        resources.ApplyResources(Me.lblUFFiltro, "lblUFFiltro")
        Me.lblUFFiltro.Name = "lblUFFiltro"
        '
        'cboUFFiltro
        '
        resources.ApplyResources(Me.cboUFFiltro, "cboUFFiltro")
        Me.cboUFFiltro.Name = "cboUFFiltro"
        Me.cboUFFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtCnpjCpfFiltro
        '
        resources.ApplyResources(Me.txtCnpjCpfFiltro, "txtCnpjCpfFiltro")
        Me.txtCnpjCpfFiltro.MaxLength = 20
        Me.txtCnpjCpfFiltro.Name = "txtCnpjCpfFiltro"
        '
        'lblCnpjCpfFiltro
        '
        resources.ApplyResources(Me.lblCnpjCpfFiltro, "lblCnpjCpfFiltro")
        Me.lblCnpjCpfFiltro.Name = "lblCnpjCpfFiltro"
        '
        'txtNomeFantasiaFiltro
        '
        Me.txtNomeFantasiaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNomeFantasiaFiltro, "txtNomeFantasiaFiltro")
        Me.txtNomeFantasiaFiltro.MaxLength = 60
        Me.txtNomeFantasiaFiltro.Name = "txtNomeFantasiaFiltro"
        '
        'lblNomeFantasiaFiltro
        '
        resources.ApplyResources(Me.lblNomeFantasiaFiltro, "lblNomeFantasiaFiltro")
        Me.lblNomeFantasiaFiltro.Name = "lblNomeFantasiaFiltro"
        '
        'txtRazaoSocialFiltro
        '
        resources.ApplyResources(Me.txtRazaoSocialFiltro, "txtRazaoSocialFiltro")
        Me.txtRazaoSocialFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazaoSocialFiltro.MaxLength = 60
        Me.txtRazaoSocialFiltro.Name = "txtRazaoSocialFiltro"
        '
        'lblRazaoSocialFiltro
        '
        resources.ApplyResources(Me.lblRazaoSocialFiltro, "lblRazaoSocialFiltro")
        Me.lblRazaoSocialFiltro.Name = "lblRazaoSocialFiltro"
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
        'cboPersonalidadeFiltro
        '
        resources.ApplyResources(Me.cboPersonalidadeFiltro, "cboPersonalidadeFiltro")
        Me.cboPersonalidadeFiltro.Name = "cboPersonalidadeFiltro"
        Me.cboPersonalidadeFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblPersonalidadeFiltro
        '
        resources.ApplyResources(Me.lblPersonalidadeFiltro, "lblPersonalidadeFiltro")
        Me.lblPersonalidadeFiltro.Name = "lblPersonalidadeFiltro"
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
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.chkMotorista)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblPersonalidade)
        Me.grpDados.Controls.Add(Me.cboPersonalidade)
        Me.grpDados.Controls.Add(Me.txtNomeFantasia)
        Me.grpDados.Controls.Add(Me.lblNomeFantasia)
        Me.grpDados.Controls.Add(Me.txtRazaoSocial)
        Me.grpDados.Controls.Add(Me.lblRazaoSocial)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'chkMotorista
        '
        resources.ApplyResources(Me.chkMotorista, "chkMotorista")
        Me.chkMotorista.Name = "chkMotorista"
        '
        'lblAtivo
        '
        resources.ApplyResources(Me.lblAtivo, "lblAtivo")
        Me.lblAtivo.Name = "lblAtivo"
        '
        'cboAtivo
        '
        resources.ApplyResources(Me.cboAtivo, "cboAtivo")
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem1, "UiComboBoxItem1")
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem2, "UiComboBoxItem2")
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblPersonalidade
        '
        resources.ApplyResources(Me.lblPersonalidade, "lblPersonalidade")
        Me.lblPersonalidade.Name = "lblPersonalidade"
        '
        'cboPersonalidade
        '
        resources.ApplyResources(Me.cboPersonalidade, "cboPersonalidade")
        Me.cboPersonalidade.Name = "cboPersonalidade"
        Me.cboPersonalidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtNomeFantasia
        '
        Me.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNomeFantasia, "txtNomeFantasia")
        Me.txtNomeFantasia.MaxLength = 60
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        '
        'lblNomeFantasia
        '
        resources.ApplyResources(Me.lblNomeFantasia, "lblNomeFantasia")
        Me.lblNomeFantasia.Name = "lblNomeFantasia"
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtRazaoSocial, "txtRazaoSocial")
        Me.txtRazaoSocial.MaxLength = 60
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        '
        'lblRazaoSocial
        '
        resources.ApplyResources(Me.lblRazaoSocial, "lblRazaoSocial")
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        '
        'tabDados
        '
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosGerais, Me.pagContato, Me.pagVeiculo, Me.UiTabPage2})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDadosGerais
        '
        Me.pagDadosGerais.Controls.Add(Me.grpDadosGerais)
        Me.pagDadosGerais.Key = "pagDadosGerais"
        resources.ApplyResources(Me.pagDadosGerais, "pagDadosGerais")
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.TabStop = True
        '
        'grpDadosGerais
        '
        resources.ApplyResources(Me.grpDadosGerais, "grpDadosGerais")
        Me.grpDadosGerais.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosGerais.Controls.Add(Me.btnProcurarCEP)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefoneRecado)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefoneRecado)
        Me.grpDadosGerais.Controls.Add(Me.txtFax)
        Me.grpDadosGerais.Controls.Add(Me.lblFax)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefone2)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefone2)
        Me.grpDadosGerais.Controls.Add(Me.txtEmail)
        Me.grpDadosGerais.Controls.Add(Me.lblEmail)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefone1)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefone1)
        Me.grpDadosGerais.Controls.Add(Me.cboMunicipio)
        Me.grpDadosGerais.Controls.Add(Me.txtObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblUF)
        Me.grpDadosGerais.Controls.Add(Me.cboUF)
        Me.grpDadosGerais.Controls.Add(Me.lblMunicipio)
        Me.grpDadosGerais.Controls.Add(Me.lblLogradouro)
        Me.grpDadosGerais.Controls.Add(Me.txtInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.lblInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.txtCnpjCpf)
        Me.grpDadosGerais.Controls.Add(Me.lblCnpjCpf)
        Me.grpDadosGerais.Controls.Add(Me.txtLogradouro)
        Me.grpDadosGerais.Controls.Add(Me.txtCEP)
        Me.grpDadosGerais.Controls.Add(Me.lblCEP)
        Me.grpDadosGerais.Name = "grpDadosGerais"
        Me.grpDadosGerais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosGerais.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosGerais.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCEP
        '
        Me.btnProcurarCEP.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarCEP, "btnProcurarCEP")
        Me.btnProcurarCEP.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCEP.Name = "btnProcurarCEP"
        Me.btnProcurarCEP.TabStop = False
        Me.btnProcurarCEP.UseVisualStyleBackColor = True
        '
        'txtTelefoneRecado
        '
        resources.ApplyResources(Me.txtTelefoneRecado, "txtTelefoneRecado")
        Me.txtTelefoneRecado.Mask = "!(##) 0000-0000"
        Me.txtTelefoneRecado.MaxLength = 10
        Me.txtTelefoneRecado.Name = "txtTelefoneRecado"
        '
        'lblTelefoneRecado
        '
        resources.ApplyResources(Me.lblTelefoneRecado, "lblTelefoneRecado")
        Me.lblTelefoneRecado.Name = "lblTelefoneRecado"
        '
        'txtFax
        '
        resources.ApplyResources(Me.txtFax, "txtFax")
        Me.txtFax.Mask = "!(##) 0000-0000"
        Me.txtFax.MaxLength = 10
        Me.txtFax.Name = "txtFax"
        '
        'lblFax
        '
        resources.ApplyResources(Me.lblFax, "lblFax")
        Me.lblFax.Name = "lblFax"
        '
        'txtTelefone2
        '
        resources.ApplyResources(Me.txtTelefone2, "txtTelefone2")
        Me.txtTelefone2.Mask = "!(##) 0000-0000"
        Me.txtTelefone2.MaxLength = 10
        Me.txtTelefone2.Name = "txtTelefone2"
        '
        'lblTelefone2
        '
        resources.ApplyResources(Me.lblTelefone2, "lblTelefone2")
        Me.lblTelefone2.Name = "lblTelefone2"
        '
        'txtEmail
        '
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.MaxLength = 60
        Me.txtEmail.Name = "txtEmail"
        '
        'lblEmail
        '
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.Name = "lblEmail"
        '
        'txtTelefone1
        '
        resources.ApplyResources(Me.txtTelefone1, "txtTelefone1")
        Me.txtTelefone1.Mask = "!(##) 0000-0000"
        Me.txtTelefone1.MaxLength = 10
        Me.txtTelefone1.Name = "txtTelefone1"
        '
        'lblTelefone1
        '
        resources.ApplyResources(Me.lblTelefone1, "lblTelefone1")
        Me.lblTelefone1.Name = "lblTelefone1"
        '
        'cboMunicipio
        '
        resources.ApplyResources(Me.cboMunicipio, "cboMunicipio")
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtObservacao
        '
        resources.ApplyResources(Me.txtObservacao, "txtObservacao")
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.MaxLength = 0
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'lblObservacao
        '
        resources.ApplyResources(Me.lblObservacao, "lblObservacao")
        Me.lblObservacao.Name = "lblObservacao"
        '
        'lblUF
        '
        resources.ApplyResources(Me.lblUF, "lblUF")
        Me.lblUF.Name = "lblUF"
        '
        'cboUF
        '
        resources.ApplyResources(Me.cboUF, "cboUF")
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblMunicipio
        '
        resources.ApplyResources(Me.lblMunicipio, "lblMunicipio")
        Me.lblMunicipio.Name = "lblMunicipio"
        '
        'lblLogradouro
        '
        resources.ApplyResources(Me.lblLogradouro, "lblLogradouro")
        Me.lblLogradouro.Name = "lblLogradouro"
        '
        'txtInscricaoEstadual
        '
        resources.ApplyResources(Me.txtInscricaoEstadual, "txtInscricaoEstadual")
        Me.txtInscricaoEstadual.MaxLength = 14
        Me.txtInscricaoEstadual.Name = "txtInscricaoEstadual"
        SuperTipSettings1.HeaderText = "Inscrição Estadual"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = resources.GetString("SuperTipSettings1.Text")
        Me.jstTip.SetSuperTip(Me.txtInscricaoEstadual, SuperTipSettings1)
        '
        'lblInscricaoEstadual
        '
        resources.ApplyResources(Me.lblInscricaoEstadual, "lblInscricaoEstadual")
        Me.lblInscricaoEstadual.Name = "lblInscricaoEstadual"
        '
        'txtCnpjCpf
        '
        resources.ApplyResources(Me.txtCnpjCpf, "txtCnpjCpf")
        Me.txtCnpjCpf.MaxLength = 20
        Me.txtCnpjCpf.Name = "txtCnpjCpf"
        '
        'lblCnpjCpf
        '
        resources.ApplyResources(Me.lblCnpjCpf, "lblCnpjCpf")
        Me.lblCnpjCpf.Name = "lblCnpjCpf"
        '
        'txtLogradouro
        '
        resources.ApplyResources(Me.txtLogradouro, "txtLogradouro")
        Me.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouro.MaxLength = 60
        Me.txtLogradouro.Name = "txtLogradouro"
        '
        'txtCEP
        '
        resources.ApplyResources(Me.txtCEP, "txtCEP")
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.MaxLength = 10
        Me.txtCEP.Name = "txtCEP"
        '
        'lblCEP
        '
        resources.ApplyResources(Me.lblCEP, "lblCEP")
        Me.lblCEP.Name = "lblCEP"
        '
        'pagContato
        '
        Me.pagContato.Controls.Add(Me.btnExcelGridContato)
        Me.pagContato.Controls.Add(Me.btnAgruparGridContato)
        Me.pagContato.Controls.Add(Me.grpEndereco)
        Me.pagContato.Controls.Add(Me.btnConfigurarGridContato)
        Me.pagContato.Controls.Add(Me.grdContato)
        Me.pagContato.Key = "pagContato"
        resources.ApplyResources(Me.pagContato, "pagContato")
        Me.pagContato.Name = "pagContato"
        Me.pagContato.TabStop = True
        '
        'btnExcelGridContato
        '
        resources.ApplyResources(Me.btnExcelGridContato, "btnExcelGridContato")
        Me.btnExcelGridContato.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridContato.FlatAppearance.BorderSize = 0
        Me.btnExcelGridContato.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridContato.Name = "btnExcelGridContato"
        Me.btnExcelGridContato.TabStop = False
        Me.btnExcelGridContato.UseVisualStyleBackColor = False
        '
        'btnAgruparGridContato
        '
        resources.ApplyResources(Me.btnAgruparGridContato, "btnAgruparGridContato")
        Me.btnAgruparGridContato.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridContato.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridContato.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridContato.Name = "btnAgruparGridContato"
        Me.btnAgruparGridContato.TabStop = False
        Me.btnAgruparGridContato.UseVisualStyleBackColor = False
        '
        'grpEndereco
        '
        resources.ApplyResources(Me.grpEndereco, "grpEndereco")
        Me.grpEndereco.BackColor = System.Drawing.Color.Transparent
        Me.grpEndereco.Controls.Add(Me.btnCadastrarTipoContato)
        Me.grpEndereco.Controls.Add(Me.dtpDataAniversario)
        Me.grpEndereco.Controls.Add(Me.lblDataAniversario)
        Me.grpEndereco.Controls.Add(Me.txtCelularContato)
        Me.grpEndereco.Controls.Add(Me.lblCelularContato)
        Me.grpEndereco.Controls.Add(Me.txtTelefoneContato)
        Me.grpEndereco.Controls.Add(Me.lblTipoContato)
        Me.grpEndereco.Controls.Add(Me.cboTipoContato)
        Me.grpEndereco.Controls.Add(Me.txtEmailContato)
        Me.grpEndereco.Controls.Add(Me.txtComplementoContato)
        Me.grpEndereco.Controls.Add(Me.txtNomeContato)
        Me.grpEndereco.Controls.Add(Me.lblComplementoContato)
        Me.grpEndereco.Controls.Add(Me.lblEmailContato)
        Me.grpEndereco.Controls.Add(Me.lblTelefoneContato)
        Me.grpEndereco.Controls.Add(Me.lblNomeContato)
        Me.grpEndereco.Controls.Add(Me.btnExcluirContato)
        Me.grpEndereco.Controls.Add(Me.btnSalvarContato)
        Me.grpEndereco.Name = "grpEndereco"
        Me.grpEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEndereco.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEndereco.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarTipoContato
        '
        Me.btnCadastrarTipoContato.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarTipoContato, "btnCadastrarTipoContato")
        Me.btnCadastrarTipoContato.Name = "btnCadastrarTipoContato"
        Me.btnCadastrarTipoContato.TabStop = False
        Me.btnCadastrarTipoContato.UseVisualStyleBackColor = True
        '
        'dtpDataAniversario
        '
        resources.ApplyResources(Me.dtpDataAniversario, "dtpDataAniversario")
        '
        '
        '
        Me.dtpDataAniversario.DropDownCalendar.Name = ""
        Me.dtpDataAniversario.Name = "dtpDataAniversario"
        Me.dtpDataAniversario.ShowCheckBox = True
        Me.dtpDataAniversario.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataAniversario
        '
        resources.ApplyResources(Me.lblDataAniversario, "lblDataAniversario")
        Me.lblDataAniversario.Name = "lblDataAniversario"
        '
        'txtCelularContato
        '
        resources.ApplyResources(Me.txtCelularContato, "txtCelularContato")
        Me.txtCelularContato.Mask = "!(##) 0000-0000"
        Me.txtCelularContato.MaxLength = 10
        Me.txtCelularContato.Name = "txtCelularContato"
        '
        'lblCelularContato
        '
        resources.ApplyResources(Me.lblCelularContato, "lblCelularContato")
        Me.lblCelularContato.Name = "lblCelularContato"
        '
        'txtTelefoneContato
        '
        resources.ApplyResources(Me.txtTelefoneContato, "txtTelefoneContato")
        Me.txtTelefoneContato.Mask = "!(##) 0000-0000"
        Me.txtTelefoneContato.MaxLength = 10
        Me.txtTelefoneContato.Name = "txtTelefoneContato"
        '
        'lblTipoContato
        '
        resources.ApplyResources(Me.lblTipoContato, "lblTipoContato")
        Me.lblTipoContato.Name = "lblTipoContato"
        '
        'cboTipoContato
        '
        resources.ApplyResources(Me.cboTipoContato, "cboTipoContato")
        Me.cboTipoContato.Name = "cboTipoContato"
        Me.cboTipoContato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtEmailContato
        '
        resources.ApplyResources(Me.txtEmailContato, "txtEmailContato")
        Me.txtEmailContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailContato.MaxLength = 100
        Me.txtEmailContato.Name = "txtEmailContato"
        '
        'txtComplementoContato
        '
        resources.ApplyResources(Me.txtComplementoContato, "txtComplementoContato")
        Me.txtComplementoContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoContato.MaxLength = 50
        Me.txtComplementoContato.Name = "txtComplementoContato"
        '
        'txtNomeContato
        '
        resources.ApplyResources(Me.txtNomeContato, "txtNomeContato")
        Me.txtNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeContato.MaxLength = 70
        Me.txtNomeContato.Name = "txtNomeContato"
        '
        'lblComplementoContato
        '
        resources.ApplyResources(Me.lblComplementoContato, "lblComplementoContato")
        Me.lblComplementoContato.Name = "lblComplementoContato"
        '
        'lblEmailContato
        '
        resources.ApplyResources(Me.lblEmailContato, "lblEmailContato")
        Me.lblEmailContato.Name = "lblEmailContato"
        '
        'lblTelefoneContato
        '
        resources.ApplyResources(Me.lblTelefoneContato, "lblTelefoneContato")
        Me.lblTelefoneContato.Name = "lblTelefoneContato"
        '
        'lblNomeContato
        '
        resources.ApplyResources(Me.lblNomeContato, "lblNomeContato")
        Me.lblNomeContato.Name = "lblNomeContato"
        '
        'btnExcluirContato
        '
        resources.ApplyResources(Me.btnExcluirContato, "btnExcluirContato")
        Me.btnExcluirContato.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirContato.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirContato.Name = "btnExcluirContato"
        Me.btnExcluirContato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirContato.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvarContato
        '
        resources.ApplyResources(Me.btnSalvarContato, "btnSalvarContato")
        Me.btnSalvarContato.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarContato.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarContato.Name = "btnSalvarContato"
        Me.btnSalvarContato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarContato.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfigurarGridContato
        '
        resources.ApplyResources(Me.btnConfigurarGridContato, "btnConfigurarGridContato")
        Me.btnConfigurarGridContato.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridContato.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridContato.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridContato.Name = "btnConfigurarGridContato"
        Me.btnConfigurarGridContato.TabStop = False
        Me.btnConfigurarGridContato.UseVisualStyleBackColor = False
        '
        'grdContato
        '
        Me.grdContato.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdContato.AlternatingColors = True
        resources.ApplyResources(Me.grdContato, "grdContato")
        grdContato_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdContato_DesignTimeLayout_Reference_0.Instance"), Object)
        grdContato_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdContato_DesignTimeLayout_Reference_1.Instance"), Object)
        grdContato_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdContato_DesignTimeLayout_Reference_0, grdContato_DesignTimeLayout_Reference_1})
        resources.ApplyResources(grdContato_DesignTimeLayout, "grdContato_DesignTimeLayout")
        Me.grdContato.DesignTimeLayout = grdContato_DesignTimeLayout
        Me.grdContato.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdContato.FrozenColumns = 3
        Me.grdContato.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdContato.GroupByBoxVisible = False
        Me.grdContato.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdContato.Name = "grdContato"
        Me.grdContato.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdContato.RecordNavigator = True
        Me.grdContato.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdContato.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdContato.TabStop = False
        Me.grdContato.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdContato.VisualStyleManager = Me.vsmMain
        '
        'pagVeiculo
        '
        Me.pagVeiculo.Controls.Add(Me.btnExcelGridVeiculo)
        Me.pagVeiculo.Controls.Add(Me.btnAgruparGridVeiculo)
        Me.pagVeiculo.Controls.Add(Me.btnConfigurarGridVeiculo)
        Me.pagVeiculo.Controls.Add(Me.grdVeiculo)
        Me.pagVeiculo.Controls.Add(Me.grpVeiculo)
        Me.pagVeiculo.Key = "pagVeiculo"
        resources.ApplyResources(Me.pagVeiculo, "pagVeiculo")
        Me.pagVeiculo.Name = "pagVeiculo"
        Me.pagVeiculo.TabStop = True
        Me.pagVeiculo.Tag = ""
        '
        'btnExcelGridVeiculo
        '
        resources.ApplyResources(Me.btnExcelGridVeiculo, "btnExcelGridVeiculo")
        Me.btnExcelGridVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridVeiculo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridVeiculo.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridVeiculo.Name = "btnExcelGridVeiculo"
        Me.btnExcelGridVeiculo.TabStop = False
        Me.btnExcelGridVeiculo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridVeiculo
        '
        resources.ApplyResources(Me.btnAgruparGridVeiculo, "btnAgruparGridVeiculo")
        Me.btnAgruparGridVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridVeiculo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridVeiculo.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridVeiculo.Name = "btnAgruparGridVeiculo"
        Me.btnAgruparGridVeiculo.TabStop = False
        Me.btnAgruparGridVeiculo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridVeiculo
        '
        resources.ApplyResources(Me.btnConfigurarGridVeiculo, "btnConfigurarGridVeiculo")
        Me.btnConfigurarGridVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridVeiculo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridVeiculo.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridVeiculo.Name = "btnConfigurarGridVeiculo"
        Me.btnConfigurarGridVeiculo.TabStop = False
        Me.btnConfigurarGridVeiculo.UseVisualStyleBackColor = False
        '
        'grpVeiculo
        '
        resources.ApplyResources(Me.grpVeiculo, "grpVeiculo")
        Me.grpVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.grpVeiculo.Controls.Add(Me.lblDescricaoVeiculo)
        Me.grpVeiculo.Controls.Add(Me.txtDescricaoVeiculo)
        Me.grpVeiculo.Controls.Add(Me.lblRNTCVeiculo)
        Me.grpVeiculo.Controls.Add(Me.txtRNTCVeiculo)
        Me.grpVeiculo.Controls.Add(Me.cboUFVeiculo)
        Me.grpVeiculo.Controls.Add(Me.lblUFVeiculo)
        Me.grpVeiculo.Controls.Add(Me.txtPlacaVeiculo)
        Me.grpVeiculo.Controls.Add(Me.lblPlacaVeiculo)
        Me.grpVeiculo.Controls.Add(Me.btnExcluirVeiculo)
        Me.grpVeiculo.Controls.Add(Me.btnInserirVeiculo)
        Me.grpVeiculo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpVeiculo.Name = "grpVeiculo"
        Me.grpVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpVeiculo.VisualStyleManager = Me.vsmMain
        '
        'lblDescricaoVeiculo
        '
        resources.ApplyResources(Me.lblDescricaoVeiculo, "lblDescricaoVeiculo")
        Me.lblDescricaoVeiculo.Name = "lblDescricaoVeiculo"
        '
        'txtDescricaoVeiculo
        '
        resources.ApplyResources(Me.txtDescricaoVeiculo, "txtDescricaoVeiculo")
        Me.txtDescricaoVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoVeiculo.MaxLength = 50
        Me.txtDescricaoVeiculo.Name = "txtDescricaoVeiculo"
        '
        'lblRNTCVeiculo
        '
        resources.ApplyResources(Me.lblRNTCVeiculo, "lblRNTCVeiculo")
        Me.lblRNTCVeiculo.Name = "lblRNTCVeiculo"
        '
        'txtRNTCVeiculo
        '
        resources.ApplyResources(Me.txtRNTCVeiculo, "txtRNTCVeiculo")
        Me.txtRNTCVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRNTCVeiculo.MaxLength = 20
        Me.txtRNTCVeiculo.Name = "txtRNTCVeiculo"
        '
        'cboUFVeiculo
        '
        resources.ApplyResources(Me.cboUFVeiculo, "cboUFVeiculo")
        Me.cboUFVeiculo.Name = "cboUFVeiculo"
        Me.cboUFVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblUFVeiculo
        '
        resources.ApplyResources(Me.lblUFVeiculo, "lblUFVeiculo")
        Me.lblUFVeiculo.Name = "lblUFVeiculo"
        '
        'txtPlacaVeiculo
        '
        resources.ApplyResources(Me.txtPlacaVeiculo, "txtPlacaVeiculo")
        Me.txtPlacaVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaVeiculo.Mask = "LLL-0A00"
        Me.txtPlacaVeiculo.MaxLength = 10
        Me.txtPlacaVeiculo.Name = "txtPlacaVeiculo"
        '
        'lblPlacaVeiculo
        '
        resources.ApplyResources(Me.lblPlacaVeiculo, "lblPlacaVeiculo")
        Me.lblPlacaVeiculo.Name = "lblPlacaVeiculo"
        '
        'btnExcluirVeiculo
        '
        resources.ApplyResources(Me.btnExcluirVeiculo, "btnExcluirVeiculo")
        Me.btnExcluirVeiculo.Image = CType(resources.GetObject("btnExcluirVeiculo.Image"), System.Drawing.Image)
        Me.btnExcluirVeiculo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirVeiculo.Name = "btnExcluirVeiculo"
        Me.btnExcluirVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirVeiculo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirVeiculo
        '
        resources.ApplyResources(Me.btnInserirVeiculo, "btnInserirVeiculo")
        Me.btnInserirVeiculo.Image = CType(resources.GetObject("btnInserirVeiculo.Image"), System.Drawing.Image)
        Me.btnInserirVeiculo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirVeiculo.Name = "btnInserirVeiculo"
        Me.btnInserirVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirVeiculo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.grdMotorista)
        Me.UiTabPage2.Controls.Add(Me.UiGroupBox1)
        resources.ApplyResources(Me.UiTabPage2, "UiTabPage2")
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.TabStop = True
        '
        'grdMotorista
        '
        Me.grdMotorista.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMotorista.AlternatingColors = True
        resources.ApplyResources(Me.grdMotorista, "grdMotorista")
        grdMotorista_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdMotorista_DesignTimeLayout_Reference_0.Instance"), Object)
        grdMotorista_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdMotorista_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdMotorista_DesignTimeLayout, "grdMotorista_DesignTimeLayout")
        Me.grdMotorista.DesignTimeLayout = grdMotorista_DesignTimeLayout
        Me.grdMotorista.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMotorista.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMotorista.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMotorista.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMotorista.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMotorista.GroupByBoxVisible = False
        Me.grdMotorista.Name = "grdMotorista"
        Me.grdMotorista.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMotorista.RecordNavigator = True
        Me.grdMotorista.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdMotorista.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMotorista.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMotorista.TabStop = False
        Me.grdMotorista.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMotorista.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox1
        '
        resources.ApplyResources(Me.UiGroupBox1, "UiGroupBox1")
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.dtpDataVencimentoCNH)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.Label7)
        Me.UiGroupBox1.Controls.Add(Me.txtNumeroCNH)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataVencimentoNTT)
        Me.UiGroupBox1.Controls.Add(Me.lblDataVencimentoNTT)
        Me.UiGroupBox1.Controls.Add(Me.lblNumeroNTT)
        Me.UiGroupBox1.Controls.Add(Me.txtNumeroNTT)
        Me.UiGroupBox1.Controls.Add(Me.Button1)
        Me.UiGroupBox1.Controls.Add(Me.cboMunicipioMotorista)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.cboUFMotorista)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.txtEnderecoMotorista)
        Me.UiGroupBox1.Controls.Add(Me.txtCEPMotorista)
        Me.UiGroupBox1.Controls.Add(Me.Label6)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataNascimentoMotorista)
        Me.UiGroupBox1.Controls.Add(Me.lblDataNascimentoMotorista)
        Me.UiGroupBox1.Controls.Add(Me.lblRGMotorista)
        Me.UiGroupBox1.Controls.Add(Me.txtRGMotorista)
        Me.UiGroupBox1.Controls.Add(Me.txtCPFMotorista)
        Me.UiGroupBox1.Controls.Add(Me.lblCPFMotorista)
        Me.UiGroupBox1.Controls.Add(Me.lblNomeMotorista)
        Me.UiGroupBox1.Controls.Add(Me.txtNomeMotorista)
        Me.UiGroupBox1.Controls.Add(Me.lblPIS)
        Me.UiGroupBox1.Controls.Add(Me.txtPISNITMotorista)
        Me.UiGroupBox1.Controls.Add(Me.txtPlacaMotorista)
        Me.UiGroupBox1.Controls.Add(Me.lblPlacaMotorista)
        Me.UiGroupBox1.Controls.Add(Me.btnExcluirMotorista)
        Me.UiGroupBox1.Controls.Add(Me.btnInserirMotorista)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'dtpDataVencimentoCNH
        '
        '
        '
        '
        Me.dtpDataVencimentoCNH.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataVencimentoCNH, "dtpDataVencimentoCNH")
        Me.dtpDataVencimentoCNH.Name = "dtpDataVencimentoCNH"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtNumeroCNH
        '
        Me.txtNumeroCNH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNumeroCNH, "txtNumeroCNH")
        Me.txtNumeroCNH.MaxLength = 20
        Me.txtNumeroCNH.Name = "txtNumeroCNH"
        '
        'dtpDataVencimentoNTT
        '
        Me.dtpDataVencimentoNTT.Checked = False
        '
        '
        '
        Me.dtpDataVencimentoNTT.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataVencimentoNTT, "dtpDataVencimentoNTT")
        Me.dtpDataVencimentoNTT.Name = "dtpDataVencimentoNTT"
        Me.dtpDataVencimentoNTT.ShowCheckBox = True
        '
        'lblDataVencimentoNTT
        '
        resources.ApplyResources(Me.lblDataVencimentoNTT, "lblDataVencimentoNTT")
        Me.lblDataVencimentoNTT.Name = "lblDataVencimentoNTT"
        '
        'lblNumeroNTT
        '
        resources.ApplyResources(Me.lblNumeroNTT, "lblNumeroNTT")
        Me.lblNumeroNTT.Name = "lblNumeroNTT"
        '
        'txtNumeroNTT
        '
        Me.txtNumeroNTT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNumeroNTT, "txtNumeroNTT")
        Me.txtNumeroNTT.MaxLength = 20
        Me.txtNumeroNTT.Name = "txtNumeroNTT"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.Button1.Name = "Button1"
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboMunicipioMotorista
        '
        resources.ApplyResources(Me.cboMunicipioMotorista, "cboMunicipioMotorista")
        Me.cboMunicipioMotorista.Name = "cboMunicipioMotorista"
        Me.cboMunicipioMotorista.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cboUFMotorista
        '
        resources.ApplyResources(Me.cboUFMotorista, "cboUFMotorista")
        Me.cboUFMotorista.Name = "cboUFMotorista"
        Me.cboUFMotorista.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtEnderecoMotorista
        '
        Me.txtEnderecoMotorista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtEnderecoMotorista, "txtEnderecoMotorista")
        Me.txtEnderecoMotorista.MaxLength = 60
        Me.txtEnderecoMotorista.Name = "txtEnderecoMotorista"
        '
        'txtCEPMotorista
        '
        resources.ApplyResources(Me.txtCEPMotorista, "txtCEPMotorista")
        Me.txtCEPMotorista.Mask = "00000-000"
        Me.txtCEPMotorista.MaxLength = 10
        Me.txtCEPMotorista.Name = "txtCEPMotorista"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'dtpDataNascimentoMotorista
        '
        Me.dtpDataNascimentoMotorista.Checked = False
        '
        '
        '
        Me.dtpDataNascimentoMotorista.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataNascimentoMotorista, "dtpDataNascimentoMotorista")
        Me.dtpDataNascimentoMotorista.Name = "dtpDataNascimentoMotorista"
        Me.dtpDataNascimentoMotorista.ShowCheckBox = True
        '
        'lblDataNascimentoMotorista
        '
        resources.ApplyResources(Me.lblDataNascimentoMotorista, "lblDataNascimentoMotorista")
        Me.lblDataNascimentoMotorista.Name = "lblDataNascimentoMotorista"
        '
        'lblRGMotorista
        '
        resources.ApplyResources(Me.lblRGMotorista, "lblRGMotorista")
        Me.lblRGMotorista.Name = "lblRGMotorista"
        '
        'txtRGMotorista
        '
        Me.txtRGMotorista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtRGMotorista, "txtRGMotorista")
        Me.txtRGMotorista.MaxLength = 20
        Me.txtRGMotorista.Name = "txtRGMotorista"
        '
        'txtCPFMotorista
        '
        resources.ApplyResources(Me.txtCPFMotorista, "txtCPFMotorista")
        Me.txtCPFMotorista.Mask = "000,000,000-00"
        Me.txtCPFMotorista.MaxLength = 20
        Me.txtCPFMotorista.Name = "txtCPFMotorista"
        '
        'lblCPFMotorista
        '
        resources.ApplyResources(Me.lblCPFMotorista, "lblCPFMotorista")
        Me.lblCPFMotorista.Name = "lblCPFMotorista"
        '
        'lblNomeMotorista
        '
        resources.ApplyResources(Me.lblNomeMotorista, "lblNomeMotorista")
        Me.lblNomeMotorista.Name = "lblNomeMotorista"
        '
        'txtNomeMotorista
        '
        Me.txtNomeMotorista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNomeMotorista, "txtNomeMotorista")
        Me.txtNomeMotorista.MaxLength = 50
        Me.txtNomeMotorista.Name = "txtNomeMotorista"
        '
        'lblPIS
        '
        resources.ApplyResources(Me.lblPIS, "lblPIS")
        Me.lblPIS.Name = "lblPIS"
        '
        'txtPISNITMotorista
        '
        Me.txtPISNITMotorista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtPISNITMotorista, "txtPISNITMotorista")
        Me.txtPISNITMotorista.MaxLength = 20
        Me.txtPISNITMotorista.Name = "txtPISNITMotorista"
        '
        'txtPlacaMotorista
        '
        Me.txtPlacaMotorista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtPlacaMotorista, "txtPlacaMotorista")
        Me.txtPlacaMotorista.Mask = "LLL-0000"
        Me.txtPlacaMotorista.MaxLength = 10
        Me.txtPlacaMotorista.Name = "txtPlacaMotorista"
        '
        'lblPlacaMotorista
        '
        resources.ApplyResources(Me.lblPlacaMotorista, "lblPlacaMotorista")
        Me.lblPlacaMotorista.Name = "lblPlacaMotorista"
        '
        'btnExcluirMotorista
        '
        resources.ApplyResources(Me.btnExcluirMotorista, "btnExcluirMotorista")
        Me.btnExcluirMotorista.Image = CType(resources.GetObject("btnExcluirMotorista.Image"), System.Drawing.Image)
        Me.btnExcluirMotorista.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirMotorista.Name = "btnExcluirMotorista"
        Me.btnExcluirMotorista.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirMotorista.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirMotorista
        '
        resources.ApplyResources(Me.btnInserirMotorista, "btnInserirMotorista")
        Me.btnInserirMotorista.Image = CType(resources.GetObject("btnInserirMotorista.Image"), System.Drawing.Image)
        Me.btnInserirMotorista.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirMotorista.Name = "btnInserirMotorista"
        Me.btnInserirMotorista.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirMotorista.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl2
        '
        resources.ApplyResources(Me.grpControl2, "grpControl2")
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.VisualStyleManager = Me.vsmMain
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
        'btnVoltar
        '
        resources.ApplyResources(Me.btnVoltar, "btnVoltar")
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'UiTabPage1
        '
        Me.UiTabPage1.Key = "pagVendas"
        resources.ApplyResources(Me.UiTabPage1, "UiTabPage1")
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.TabStop = True
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 1
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 1
        Me.jstTip.ShowAlways = True
        '
        'grdVeiculo
        '
        Me.grdVeiculo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdVeiculo.AlternatingColors = True
        resources.ApplyResources(Me.grdVeiculo, "grdVeiculo")
        grdVeiculo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdVeiculo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdVeiculo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdVeiculo_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdVeiculo_DesignTimeLayout, "grdVeiculo_DesignTimeLayout")
        Me.grdVeiculo.DesignTimeLayout = grdVeiculo_DesignTimeLayout
        Me.grdVeiculo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdVeiculo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdVeiculo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdVeiculo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVeiculo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVeiculo.GroupByBoxVisible = False
        Me.grdVeiculo.Name = "grdVeiculo"
        Me.grdVeiculo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVeiculo.RecordNavigator = True
        Me.grdVeiculo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVeiculo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVeiculo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVeiculo.TabStop = False
        Me.grdVeiculo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVeiculo.VisualStyleManager = Me.vsmMain
        '
        'usrCadTransportadora
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadTransportadora"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDadosGerais.ResumeLayout(False)
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosGerais.ResumeLayout(False)
        Me.grpDadosGerais.PerformLayout()
        Me.pagContato.ResumeLayout(False)
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEndereco.ResumeLayout(False)
        Me.grpEndereco.PerformLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagVeiculo.ResumeLayout(False)
        CType(Me.grpVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVeiculo.ResumeLayout(False)
        Me.grpVeiculo.PerformLayout()
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.grdMotorista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grdVeiculo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosGerais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCnpjCpf As System.Windows.Forms.Label
    Friend WithEvents pagContato As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPersonalidade As System.Windows.Forms.Label
    Friend WithEvents cboPersonalidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNomeFantasia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeFantasia As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents txtCnpjCpf As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtInscricaoEstadual As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadual As System.Windows.Forms.Label
    Friend WithEvents lblLogradouro As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents cboUF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPersonalidadeFiltro As System.Windows.Forms.Label
    Friend WithEvents cboPersonalidadeFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtLogradouro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboMunicipio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblTelefone1 As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTelefone1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTelefoneRecado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefoneRecado As System.Windows.Forms.Label
    Friend WithEvents txtFax As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtTelefone2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefone2 As System.Windows.Forms.Label
    Friend WithEvents txtMunicipioFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMunicipioFiltro As System.Windows.Forms.Label
    Friend WithEvents lblUFFiltro As System.Windows.Forms.Label
    Friend WithEvents cboUFFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCnpjCpfFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCnpjCpfFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNomeFantasiaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeFantasiaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocialFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRazaoSocialFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridContato As System.Windows.Forms.Button
    Friend WithEvents pagVeiculo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpVeiculo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirVeiculo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirVeiculo As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboUFVeiculo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUFVeiculo As System.Windows.Forms.Label
    Friend WithEvents txtPlacaVeiculo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlacaVeiculo As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGridVeiculo As System.Windows.Forms.Button
    Friend WithEvents lblDescricaoVeiculo As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoVeiculo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRNTCVeiculo As System.Windows.Forms.Label
    Friend WithEvents txtRNTCVeiculo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpEndereco As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarTipoContato As System.Windows.Forms.Button
    Friend WithEvents dtpDataAniversario As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataAniversario As System.Windows.Forms.Label
    Friend WithEvents txtCelularContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCelularContato As System.Windows.Forms.Label
    Friend WithEvents txtTelefoneContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoContato As System.Windows.Forms.Label
    Friend WithEvents cboTipoContato As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtEmailContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNomeContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplementoContato As System.Windows.Forms.Label
    Friend WithEvents lblEmailContato As System.Windows.Forms.Label
    Friend WithEvents lblTelefoneContato As System.Windows.Forms.Label
    Friend WithEvents lblNomeContato As System.Windows.Forms.Label
    Friend WithEvents btnExcluirContato As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvarContato As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdContato As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridContato As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridContato As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridVeiculo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridVeiculo As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCEP As System.Windows.Forms.Button
    Friend WithEvents txtCEP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboImportado As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents chkMotorista As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCPFMotorista As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCPFMotorista As System.Windows.Forms.Label
    Friend WithEvents lblNomeMotorista As System.Windows.Forms.Label
    Friend WithEvents txtNomeMotorista As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPIS As System.Windows.Forms.Label
    Friend WithEvents txtPISNITMotorista As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtPlacaMotorista As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlacaMotorista As System.Windows.Forms.Label
    Friend WithEvents btnExcluirMotorista As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirMotorista As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblRGMotorista As System.Windows.Forms.Label
    Friend WithEvents txtRGMotorista As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroNTT As System.Windows.Forms.Label
    Friend WithEvents txtNumeroNTT As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboMunicipioMotorista As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboUFMotorista As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEnderecoMotorista As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCEPMotorista As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDataNascimentoMotorista As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataNascimentoMotorista As System.Windows.Forms.Label
    Friend WithEvents grdMotorista As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataVencimentoNTT As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataVencimentoNTT As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimentoCNH As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCNH As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdVeiculo As Janus.Windows.GridEX.GridEX
End Class
