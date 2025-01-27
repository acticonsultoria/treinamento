<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadVendedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadVendedor))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdEndereco_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEndereco_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdSubordinado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdSubordinado_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoVendedorFiltro = New System.Windows.Forms.Label()
        Me.cboTipoVendedorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRegraComissaoFiltro = New System.Windows.Forms.Label()
        Me.cboRegraComissaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNomeFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarRegraComissao = New System.Windows.Forms.Button()
        Me.lblTipoVendedor = New System.Windows.Forms.Label()
        Me.cboTipoVendedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRegraComissao = New System.Windows.Forms.Label()
        Me.cboRegraComissao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNome = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosGerais = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNextel = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNextel = New System.Windows.Forms.Label()
        Me.txtTelefoneRecado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefoneRecado = New System.Windows.Forms.Label()
        Me.txtTelefone2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefone2 = New System.Windows.Forms.Label()
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefone1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefone1 = New System.Windows.Forms.Label()
        Me.cboMunicipio = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumero = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplemento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cboPais = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtCEP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.cboUF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.txtLogradouro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnProcurarCEP = New System.Windows.Forms.Button()
        Me.btnCadastrarPais = New System.Windows.Forms.Button()
        Me.pagEndereco = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGridEndereco = New System.Windows.Forms.Button()
        Me.btnConfigurarGridEndereco = New System.Windows.Forms.Button()
        Me.grdEndereco = New Janus.Windows.GridEX.GridEX()
        Me.grpEnderecoCobranca = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirEndereco = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvarEndereco = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarCepEndereco = New System.Windows.Forms.Button()
        Me.btnCadastrarPaisEndereco = New System.Windows.Forms.Button()
        Me.cboMunicipioEndereco = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplementoEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairroEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPaisEndereco = New System.Windows.Forms.Label()
        Me.cboPaisEndereco = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCepEndereco = New System.Windows.Forms.Label()
        Me.txtCepEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplementoEndereco = New System.Windows.Forms.Label()
        Me.lblUFEndereco = New System.Windows.Forms.Label()
        Me.cboUFEndereco = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipioEndereco = New System.Windows.Forms.Label()
        Me.lblBairroEndereco = New System.Windows.Forms.Label()
        Me.lblNumeroEndereco = New System.Windows.Forms.Label()
        Me.lblLogradouroEndereco = New System.Windows.Forms.Label()
        Me.txtLogradouroEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoEndereco = New System.Windows.Forms.Label()
        Me.cboTipoEndereco = New Janus.Windows.EditControls.UIComboBox()
        Me.pagSubordinados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGridSubordinado = New System.Windows.Forms.Button()
        Me.grdSubordinado = New Janus.Windows.GridEX.GridEX()
        Me.grpSubordinado = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirSubordinado = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirSubordinado = New Janus.Windows.EditControls.UIButton()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.cboVendedor = New Janus.Windows.EditControls.UIComboBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnExcelGridEndereco = New System.Windows.Forms.Button()
        Me.btnExcelGridSubordinado = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosGerais.SuspendLayout()
        Me.pagEndereco.SuspendLayout()
        CType(Me.grdEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEnderecoCobranca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnderecoCobranca.SuspendLayout()
        Me.pagSubordinados.SuspendLayout()
        CType(Me.grdSubordinado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSubordinado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSubordinado.SuspendLayout()
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
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grdListagem)
        resources.ApplyResources(Me.pagLista, "pagLista")
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Name = "pagLista"
        Me.pagLista.TabStop = True
        '
        'btnAgruparGrid
        '
        resources.ApplyResources(Me.btnAgruparGrid, "btnAgruparGrid")
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        resources.ApplyResources(Me.btnConfigurarGrid, "btnConfigurarGrid")
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        resources.ApplyResources(Me.grpFiltro, "grpFiltro")
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblTipoVendedorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoVendedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRegraComissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboRegraComissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNomeFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNomeFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblTipoVendedorFiltro
        '
        resources.ApplyResources(Me.lblTipoVendedorFiltro, "lblTipoVendedorFiltro")
        Me.lblTipoVendedorFiltro.Name = "lblTipoVendedorFiltro"
        '
        'cboTipoVendedorFiltro
        '
        resources.ApplyResources(Me.cboTipoVendedorFiltro, "cboTipoVendedorFiltro")
        Me.cboTipoVendedorFiltro.Name = "cboTipoVendedorFiltro"
        Me.cboTipoVendedorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblRegraComissaoFiltro
        '
        resources.ApplyResources(Me.lblRegraComissaoFiltro, "lblRegraComissaoFiltro")
        Me.lblRegraComissaoFiltro.Name = "lblRegraComissaoFiltro"
        '
        'cboRegraComissaoFiltro
        '
        resources.ApplyResources(Me.cboRegraComissaoFiltro, "cboRegraComissaoFiltro")
        Me.cboRegraComissaoFiltro.Name = "cboRegraComissaoFiltro"
        Me.cboRegraComissaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtNomeFiltro
        '
        resources.ApplyResources(Me.txtNomeFiltro, "txtNomeFiltro")
        Me.txtNomeFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFiltro.MaxLength = 60
        Me.txtNomeFiltro.Name = "txtNomeFiltro"
        '
        'lblNomeFiltro
        '
        resources.ApplyResources(Me.lblNomeFiltro, "lblNomeFiltro")
        Me.lblNomeFiltro.Name = "lblNomeFiltro"
        '
        'btnFiltrar
        '
        resources.ApplyResources(Me.btnFiltrar, "btnFiltrar")
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
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
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Window
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
        Me.grpDados.Controls.Add(Me.btnCadastrarRegraComissao)
        Me.grpDados.Controls.Add(Me.lblTipoVendedor)
        Me.grpDados.Controls.Add(Me.cboTipoVendedor)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblRegraComissao)
        Me.grpDados.Controls.Add(Me.cboRegraComissao)
        Me.grpDados.Controls.Add(Me.txtNome)
        Me.grpDados.Controls.Add(Me.lblNome)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarRegraComissao
        '
        resources.ApplyResources(Me.btnCadastrarRegraComissao, "btnCadastrarRegraComissao")
        Me.btnCadastrarRegraComissao.FlatAppearance.BorderSize = 0
        Me.btnCadastrarRegraComissao.Name = "btnCadastrarRegraComissao"
        Me.btnCadastrarRegraComissao.TabStop = False
        Me.btnCadastrarRegraComissao.UseVisualStyleBackColor = True
        '
        'lblTipoVendedor
        '
        resources.ApplyResources(Me.lblTipoVendedor, "lblTipoVendedor")
        Me.lblTipoVendedor.Name = "lblTipoVendedor"
        '
        'cboTipoVendedor
        '
        resources.ApplyResources(Me.cboTipoVendedor, "cboTipoVendedor")
        Me.cboTipoVendedor.Name = "cboTipoVendedor"
        Me.cboTipoVendedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        'lblRegraComissao
        '
        resources.ApplyResources(Me.lblRegraComissao, "lblRegraComissao")
        Me.lblRegraComissao.Name = "lblRegraComissao"
        '
        'cboRegraComissao
        '
        resources.ApplyResources(Me.cboRegraComissao, "cboRegraComissao")
        Me.cboRegraComissao.Name = "cboRegraComissao"
        Me.cboRegraComissao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtNome
        '
        resources.ApplyResources(Me.txtNome, "txtNome")
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.MaxLength = 60
        Me.txtNome.Name = "txtNome"
        '
        'lblNome
        '
        resources.ApplyResources(Me.lblNome, "lblNome")
        Me.lblNome.Name = "lblNome"
        '
        'tabDados
        '
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosGerais, Me.pagEndereco, Me.pagSubordinados})
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
        Me.grpDadosGerais.Controls.Add(Me.txtNextel)
        Me.grpDadosGerais.Controls.Add(Me.lblNextel)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefoneRecado)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefoneRecado)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefone2)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefone2)
        Me.grpDadosGerais.Controls.Add(Me.txtEmail)
        Me.grpDadosGerais.Controls.Add(Me.lblEmail)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefone1)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefone1)
        Me.grpDadosGerais.Controls.Add(Me.cboMunicipio)
        Me.grpDadosGerais.Controls.Add(Me.txtNumero)
        Me.grpDadosGerais.Controls.Add(Me.txtComplemento)
        Me.grpDadosGerais.Controls.Add(Me.txtBairro)
        Me.grpDadosGerais.Controls.Add(Me.txtObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblPais)
        Me.grpDadosGerais.Controls.Add(Me.cboPais)
        Me.grpDadosGerais.Controls.Add(Me.lblCEP)
        Me.grpDadosGerais.Controls.Add(Me.txtCEP)
        Me.grpDadosGerais.Controls.Add(Me.lblComplemento)
        Me.grpDadosGerais.Controls.Add(Me.lblUF)
        Me.grpDadosGerais.Controls.Add(Me.cboUF)
        Me.grpDadosGerais.Controls.Add(Me.lblMunicipio)
        Me.grpDadosGerais.Controls.Add(Me.lblBairro)
        Me.grpDadosGerais.Controls.Add(Me.lblNumero)
        Me.grpDadosGerais.Controls.Add(Me.lblLogradouro)
        Me.grpDadosGerais.Controls.Add(Me.txtLogradouro)
        Me.grpDadosGerais.Controls.Add(Me.btnProcurarCEP)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarPais)
        Me.grpDadosGerais.Name = "grpDadosGerais"
        Me.grpDadosGerais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosGerais.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosGerais.VisualStyleManager = Me.vsmMain
        '
        'txtNextel
        '
        resources.ApplyResources(Me.txtNextel, "txtNextel")
        Me.txtNextel.MaxLength = 10
        Me.txtNextel.Name = "txtNextel"
        '
        'lblNextel
        '
        resources.ApplyResources(Me.lblNextel, "lblNextel")
        Me.lblNextel.Name = "lblNextel"
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
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        resources.ApplyResources(Me.txtEmail, "txtEmail")
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
        'txtNumero
        '
        resources.ApplyResources(Me.txtNumero, "txtNumero")
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.MaxLength = 60
        Me.txtNumero.Name = "txtNumero"
        '
        'txtComplemento
        '
        resources.ApplyResources(Me.txtComplemento, "txtComplemento")
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.MaxLength = 60
        Me.txtComplemento.Name = "txtComplemento"
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtBairro, "txtBairro")
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
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
        'lblPais
        '
        resources.ApplyResources(Me.lblPais, "lblPais")
        Me.lblPais.Name = "lblPais"
        '
        'cboPais
        '
        resources.ApplyResources(Me.cboPais, "cboPais")
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCEP
        '
        resources.ApplyResources(Me.lblCEP, "lblCEP")
        Me.lblCEP.Name = "lblCEP"
        '
        'txtCEP
        '
        resources.ApplyResources(Me.txtCEP, "txtCEP")
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.MaxLength = 10
        Me.txtCEP.Name = "txtCEP"
        '
        'lblComplemento
        '
        resources.ApplyResources(Me.lblComplemento, "lblComplemento")
        Me.lblComplemento.Name = "lblComplemento"
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
        'lblBairro
        '
        resources.ApplyResources(Me.lblBairro, "lblBairro")
        Me.lblBairro.Name = "lblBairro"
        '
        'lblNumero
        '
        resources.ApplyResources(Me.lblNumero, "lblNumero")
        Me.lblNumero.Name = "lblNumero"
        '
        'lblLogradouro
        '
        resources.ApplyResources(Me.lblLogradouro, "lblLogradouro")
        Me.lblLogradouro.Name = "lblLogradouro"
        '
        'txtLogradouro
        '
        resources.ApplyResources(Me.txtLogradouro, "txtLogradouro")
        Me.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouro.MaxLength = 60
        Me.txtLogradouro.Name = "txtLogradouro"
        '
        'btnProcurarCEP
        '
        Me.btnProcurarCEP.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarCEP, "btnProcurarCEP")
        Me.btnProcurarCEP.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarCEP.Name = "btnProcurarCEP"
        Me.btnProcurarCEP.TabStop = False
        Me.btnProcurarCEP.UseVisualStyleBackColor = True
        '
        'btnCadastrarPais
        '
        Me.btnCadastrarPais.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarPais, "btnCadastrarPais")
        Me.btnCadastrarPais.Name = "btnCadastrarPais"
        Me.btnCadastrarPais.TabStop = False
        Me.btnCadastrarPais.UseVisualStyleBackColor = True
        '
        'pagEndereco
        '
        Me.pagEndereco.Controls.Add(Me.btnExcelGridEndereco)
        Me.pagEndereco.Controls.Add(Me.btnAgruparGridEndereco)
        Me.pagEndereco.Controls.Add(Me.btnConfigurarGridEndereco)
        Me.pagEndereco.Controls.Add(Me.grdEndereco)
        Me.pagEndereco.Controls.Add(Me.grpEnderecoCobranca)
        Me.pagEndereco.Key = "pagEndereco"
        resources.ApplyResources(Me.pagEndereco, "pagEndereco")
        Me.pagEndereco.Name = "pagEndereco"
        Me.pagEndereco.TabStop = True
        '
        'btnAgruparGridEndereco
        '
        resources.ApplyResources(Me.btnAgruparGridEndereco, "btnAgruparGridEndereco")
        Me.btnAgruparGridEndereco.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridEndereco.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridEndereco.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridEndereco.Name = "btnAgruparGridEndereco"
        Me.btnAgruparGridEndereco.TabStop = False
        Me.btnAgruparGridEndereco.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridEndereco
        '
        resources.ApplyResources(Me.btnConfigurarGridEndereco, "btnConfigurarGridEndereco")
        Me.btnConfigurarGridEndereco.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridEndereco.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridEndereco.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridEndereco.Name = "btnConfigurarGridEndereco"
        Me.btnConfigurarGridEndereco.TabStop = False
        Me.btnConfigurarGridEndereco.UseVisualStyleBackColor = False
        '
        'grdEndereco
        '
        Me.grdEndereco.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEndereco.AlternatingColors = True
        resources.ApplyResources(Me.grdEndereco, "grdEndereco")
        grdEndereco_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdEndereco_DesignTimeLayout_Reference_0.Instance"), Object)
        grdEndereco_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdEndereco_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdEndereco_DesignTimeLayout, "grdEndereco_DesignTimeLayout")
        Me.grdEndereco.DesignTimeLayout = grdEndereco_DesignTimeLayout
        Me.grdEndereco.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEndereco.FrozenColumns = 2
        Me.grdEndereco.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEndereco.GroupByBoxVisible = False
        Me.grdEndereco.Name = "grdEndereco"
        Me.grdEndereco.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEndereco.RecordNavigator = True
        Me.grdEndereco.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEndereco.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEndereco.TabStop = False
        Me.grdEndereco.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEndereco.VisualStyleManager = Me.vsmMain
        '
        'grpEnderecoCobranca
        '
        resources.ApplyResources(Me.grpEnderecoCobranca, "grpEnderecoCobranca")
        Me.grpEnderecoCobranca.BackColor = System.Drawing.Color.Transparent
        Me.grpEnderecoCobranca.Controls.Add(Me.btnExcluirEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.btnSalvarEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.btnProcurarCepEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.btnCadastrarPaisEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.cboMunicipioEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtNumeroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtComplementoEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtBairroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblPaisEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.cboPaisEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblCepEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtCepEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblComplementoEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblUFEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.cboUFEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblMunicipioEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblBairroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblNumeroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblLogradouroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtLogradouroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblTipoEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.cboTipoEndereco)
        Me.grpEnderecoCobranca.Name = "grpEnderecoCobranca"
        Me.grpEnderecoCobranca.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEnderecoCobranca.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEnderecoCobranca.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirEndereco
        '
        resources.ApplyResources(Me.btnExcluirEndereco, "btnExcluirEndereco")
        Me.btnExcluirEndereco.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirEndereco.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirEndereco.Name = "btnExcluirEndereco"
        Me.btnExcluirEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirEndereco.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvarEndereco
        '
        resources.ApplyResources(Me.btnSalvarEndereco, "btnSalvarEndereco")
        Me.btnSalvarEndereco.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvarEndereco.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarEndereco.Name = "btnSalvarEndereco"
        Me.btnSalvarEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarEndereco.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProcurarCepEndereco
        '
        Me.btnProcurarCepEndereco.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarCepEndereco, "btnProcurarCepEndereco")
        Me.btnProcurarCepEndereco.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarCepEndereco.Name = "btnProcurarCepEndereco"
        Me.btnProcurarCepEndereco.TabStop = False
        Me.btnProcurarCepEndereco.UseVisualStyleBackColor = True
        '
        'btnCadastrarPaisEndereco
        '
        Me.btnCadastrarPaisEndereco.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarPaisEndereco, "btnCadastrarPaisEndereco")
        Me.btnCadastrarPaisEndereco.Name = "btnCadastrarPaisEndereco"
        Me.btnCadastrarPaisEndereco.TabStop = False
        Me.btnCadastrarPaisEndereco.UseVisualStyleBackColor = True
        '
        'cboMunicipioEndereco
        '
        resources.ApplyResources(Me.cboMunicipioEndereco, "cboMunicipioEndereco")
        Me.cboMunicipioEndereco.Name = "cboMunicipioEndereco"
        Me.cboMunicipioEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtNumeroEndereco
        '
        Me.txtNumeroEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNumeroEndereco, "txtNumeroEndereco")
        Me.txtNumeroEndereco.MaxLength = 60
        Me.txtNumeroEndereco.Name = "txtNumeroEndereco"
        '
        'txtComplementoEndereco
        '
        Me.txtComplementoEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtComplementoEndereco, "txtComplementoEndereco")
        Me.txtComplementoEndereco.MaxLength = 60
        Me.txtComplementoEndereco.Name = "txtComplementoEndereco"
        '
        'txtBairroEndereco
        '
        Me.txtBairroEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtBairroEndereco, "txtBairroEndereco")
        Me.txtBairroEndereco.MaxLength = 60
        Me.txtBairroEndereco.Name = "txtBairroEndereco"
        '
        'lblPaisEndereco
        '
        resources.ApplyResources(Me.lblPaisEndereco, "lblPaisEndereco")
        Me.lblPaisEndereco.Name = "lblPaisEndereco"
        '
        'cboPaisEndereco
        '
        resources.ApplyResources(Me.cboPaisEndereco, "cboPaisEndereco")
        Me.cboPaisEndereco.Name = "cboPaisEndereco"
        Me.cboPaisEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCepEndereco
        '
        resources.ApplyResources(Me.lblCepEndereco, "lblCepEndereco")
        Me.lblCepEndereco.Name = "lblCepEndereco"
        '
        'txtCepEndereco
        '
        resources.ApplyResources(Me.txtCepEndereco, "txtCepEndereco")
        Me.txtCepEndereco.Mask = "00000-000"
        Me.txtCepEndereco.MaxLength = 10
        Me.txtCepEndereco.Name = "txtCepEndereco"
        '
        'lblComplementoEndereco
        '
        resources.ApplyResources(Me.lblComplementoEndereco, "lblComplementoEndereco")
        Me.lblComplementoEndereco.Name = "lblComplementoEndereco"
        '
        'lblUFEndereco
        '
        resources.ApplyResources(Me.lblUFEndereco, "lblUFEndereco")
        Me.lblUFEndereco.Name = "lblUFEndereco"
        '
        'cboUFEndereco
        '
        resources.ApplyResources(Me.cboUFEndereco, "cboUFEndereco")
        Me.cboUFEndereco.Name = "cboUFEndereco"
        Me.cboUFEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblMunicipioEndereco
        '
        resources.ApplyResources(Me.lblMunicipioEndereco, "lblMunicipioEndereco")
        Me.lblMunicipioEndereco.Name = "lblMunicipioEndereco"
        '
        'lblBairroEndereco
        '
        resources.ApplyResources(Me.lblBairroEndereco, "lblBairroEndereco")
        Me.lblBairroEndereco.Name = "lblBairroEndereco"
        '
        'lblNumeroEndereco
        '
        resources.ApplyResources(Me.lblNumeroEndereco, "lblNumeroEndereco")
        Me.lblNumeroEndereco.Name = "lblNumeroEndereco"
        '
        'lblLogradouroEndereco
        '
        resources.ApplyResources(Me.lblLogradouroEndereco, "lblLogradouroEndereco")
        Me.lblLogradouroEndereco.Name = "lblLogradouroEndereco"
        '
        'txtLogradouroEndereco
        '
        Me.txtLogradouroEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtLogradouroEndereco, "txtLogradouroEndereco")
        Me.txtLogradouroEndereco.MaxLength = 60
        Me.txtLogradouroEndereco.Name = "txtLogradouroEndereco"
        '
        'lblTipoEndereco
        '
        resources.ApplyResources(Me.lblTipoEndereco, "lblTipoEndereco")
        Me.lblTipoEndereco.Name = "lblTipoEndereco"
        '
        'cboTipoEndereco
        '
        resources.ApplyResources(Me.cboTipoEndereco, "cboTipoEndereco")
        Me.cboTipoEndereco.Name = "cboTipoEndereco"
        Me.cboTipoEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'pagSubordinados
        '
        Me.pagSubordinados.Controls.Add(Me.btnExcelGridSubordinado)
        Me.pagSubordinados.Controls.Add(Me.btnConfigurarGridSubordinado)
        Me.pagSubordinados.Controls.Add(Me.grdSubordinado)
        Me.pagSubordinados.Controls.Add(Me.grpSubordinado)
        Me.pagSubordinados.Key = "pagSubordinados"
        resources.ApplyResources(Me.pagSubordinados, "pagSubordinados")
        Me.pagSubordinados.Name = "pagSubordinados"
        Me.pagSubordinados.TabStop = True
        '
        'btnConfigurarGridSubordinado
        '
        resources.ApplyResources(Me.btnConfigurarGridSubordinado, "btnConfigurarGridSubordinado")
        Me.btnConfigurarGridSubordinado.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridSubordinado.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridSubordinado.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridSubordinado.Name = "btnConfigurarGridSubordinado"
        Me.btnConfigurarGridSubordinado.TabStop = False
        Me.btnConfigurarGridSubordinado.UseVisualStyleBackColor = False
        '
        'grdSubordinado
        '
        Me.grdSubordinado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdSubordinado.AlternatingColors = True
        resources.ApplyResources(Me.grdSubordinado, "grdSubordinado")
        Me.grdSubordinado.ColumnAutoResize = True
        grdSubordinado_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdSubordinado_DesignTimeLayout_Reference_0.Instance"), Object)
        grdSubordinado_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdSubordinado_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdSubordinado_DesignTimeLayout, "grdSubordinado_DesignTimeLayout")
        Me.grdSubordinado.DesignTimeLayout = grdSubordinado_DesignTimeLayout
        Me.grdSubordinado.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdSubordinado.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdSubordinado.GroupByBoxVisible = False
        Me.grdSubordinado.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdSubordinado.Name = "grdSubordinado"
        Me.grdSubordinado.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdSubordinado.RecordNavigator = True
        Me.grdSubordinado.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdSubordinado.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdSubordinado.TabStop = False
        Me.grdSubordinado.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdSubordinado.VisualStyleManager = Me.vsmMain
        '
        'grpSubordinado
        '
        resources.ApplyResources(Me.grpSubordinado, "grpSubordinado")
        Me.grpSubordinado.BackColor = System.Drawing.Color.Transparent
        Me.grpSubordinado.Controls.Add(Me.btnExcluirSubordinado)
        Me.grpSubordinado.Controls.Add(Me.btnInserirSubordinado)
        Me.grpSubordinado.Controls.Add(Me.lblVendedor)
        Me.grpSubordinado.Controls.Add(Me.cboVendedor)
        Me.grpSubordinado.Name = "grpSubordinado"
        Me.grpSubordinado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSubordinado.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpSubordinado.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirSubordinado
        '
        resources.ApplyResources(Me.btnExcluirSubordinado, "btnExcluirSubordinado")
        Me.btnExcluirSubordinado.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirSubordinado.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirSubordinado.Name = "btnExcluirSubordinado"
        Me.btnExcluirSubordinado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirSubordinado.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirSubordinado
        '
        resources.ApplyResources(Me.btnInserirSubordinado, "btnInserirSubordinado")
        Me.btnInserirSubordinado.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirSubordinado.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirSubordinado.Name = "btnInserirSubordinado"
        Me.btnInserirSubordinado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirSubordinado.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblVendedor
        '
        resources.ApplyResources(Me.lblVendedor, "lblVendedor")
        Me.lblVendedor.Name = "lblVendedor"
        '
        'cboVendedor
        '
        resources.ApplyResources(Me.cboVendedor, "cboVendedor")
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        resources.ApplyResources(Me.btnVoltar, "btnVoltar")
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        resources.ApplyResources(Me.btnSalvar, "btnSalvar")
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
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
        Me.jstTip.AutoPopDelay = 3000
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'btnExcelGrid
        '
        resources.ApplyResources(Me.btnExcelGrid, "btnExcelGrid")
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnExcelGridEndereco
        '
        resources.ApplyResources(Me.btnExcelGridEndereco, "btnExcelGridEndereco")
        Me.btnExcelGridEndereco.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridEndereco.FlatAppearance.BorderSize = 0
        Me.btnExcelGridEndereco.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridEndereco.Name = "btnExcelGridEndereco"
        Me.btnExcelGridEndereco.TabStop = False
        Me.btnExcelGridEndereco.UseVisualStyleBackColor = False
        '
        'btnExcelGridSubordinado
        '
        resources.ApplyResources(Me.btnExcelGridSubordinado, "btnExcelGridSubordinado")
        Me.btnExcelGridSubordinado.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridSubordinado.FlatAppearance.BorderSize = 0
        Me.btnExcelGridSubordinado.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridSubordinado.Name = "btnExcelGridSubordinado"
        Me.btnExcelGridSubordinado.TabStop = False
        Me.btnExcelGridSubordinado.UseVisualStyleBackColor = False
        '
        'usrCadVendedor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadVendedor"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.pagEndereco.ResumeLayout(False)
        CType(Me.grdEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEnderecoCobranca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEnderecoCobranca.ResumeLayout(False)
        Me.grpEnderecoCobranca.PerformLayout()
        Me.pagSubordinados.ResumeLayout(False)
        CType(Me.grdSubordinado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSubordinado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSubordinado.ResumeLayout(False)
        Me.grpSubordinado.PerformLayout()
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
    Friend WithEvents grpDadosGerais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRegraComissao As System.Windows.Forms.Label
    Friend WithEvents cboRegraComissao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNome As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblLogradouro As System.Windows.Forms.Label
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents cboPais As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents txtCEP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents cboUF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtBairro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplemento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtLogradouro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumero As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboMunicipio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoVendedor As System.Windows.Forms.Label
    Friend WithEvents cboTipoVendedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarPais As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnProcurarCEP As System.Windows.Forms.Button
    Friend WithEvents pagEndereco As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblTelefone1 As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTelefone1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTelefoneRecado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefoneRecado As System.Windows.Forms.Label
    Friend WithEvents txtTelefone2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefone2 As System.Windows.Forms.Label
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoVendedorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoVendedorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRegraComissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboRegraComissaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNomeFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNextel As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNextel As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents pagSubordinados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridSubordinado As System.Windows.Forms.Button
    Friend WithEvents grdSubordinado As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpSubordinado As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirSubordinado As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirSubordinado As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents cboVendedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarRegraComissao As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridEndereco As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridEndereco As System.Windows.Forms.Button
    Friend WithEvents grdEndereco As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpEnderecoCobranca As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirEndereco As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvarEndereco As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProcurarCepEndereco As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarPaisEndereco As System.Windows.Forms.Button
    Friend WithEvents cboMunicipioEndereco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairroEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPaisEndereco As System.Windows.Forms.Label
    Friend WithEvents cboPaisEndereco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCepEndereco As System.Windows.Forms.Label
    Friend WithEvents txtCepEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplementoEndereco As System.Windows.Forms.Label
    Friend WithEvents lblUFEndereco As System.Windows.Forms.Label
    Friend WithEvents cboUFEndereco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipioEndereco As System.Windows.Forms.Label
    Friend WithEvents lblBairroEndereco As System.Windows.Forms.Label
    Friend WithEvents lblNumeroEndereco As System.Windows.Forms.Label
    Friend WithEvents lblLogradouroEndereco As System.Windows.Forms.Label
    Friend WithEvents txtLogradouroEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoEndereco As System.Windows.Forms.Label
    Friend WithEvents cboTipoEndereco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridEndereco As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridSubordinado As System.Windows.Forms.Button

End Class
