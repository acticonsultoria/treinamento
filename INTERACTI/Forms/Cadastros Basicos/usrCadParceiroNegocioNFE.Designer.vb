<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadParceiroNegocioNFE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadParceiroNegocioNFE))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim cboVendedorFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings4 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings5 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings6 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnEditarGrid = New System.Windows.Forms.Button()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblParcialmenteEntregue = New System.Windows.Forms.Label()
        Me.lblEntregue = New System.Windows.Forms.Label()
        Me.picEntregue = New System.Windows.Forms.PictureBox()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPedidoVenda = New System.Windows.Forms.Label()
        Me.picLegendaTipoOrcamento = New System.Windows.Forms.PictureBox()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnMalaDireta = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboImportado = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoNegativacaoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoNegativacaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboVendedorFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblVendedorFiltro = New System.Windows.Forms.Label()
        Me.txtMunicipioFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMunicipioFiltro = New System.Windows.Forms.Label()
        Me.lblSegmentoFiltro = New System.Windows.Forms.Label()
        Me.cboSegmentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoParceiroNegocioFiltro = New System.Windows.Forms.Label()
        Me.txtCnpjCpfFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCnpjCpfFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.cboPersonalidadeFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNomeFantasiaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeFantasiaFiltro = New System.Windows.Forms.Label()
        Me.txtRazaoSocialFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRazaoSocialFiltro = New System.Windows.Forms.Label()
        Me.cboTipoParceiroNegocioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPersonalidadeFiltro = New System.Windows.Forms.Label()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosGerais = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAvisoTempoCompra = New System.Windows.Forms.Label()
        Me.txtAvisoTempoCompra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLimiteCredito = New System.Windows.Forms.Label()
        Me.txtLimiteCredito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTipoInscricaoEstadual = New System.Windows.Forms.Label()
        Me.cboTipoInscricaoEstadual = New Janus.Windows.EditControls.UIComboBox()
        Me.txtInscricaoEstadualSubstitutoTriburario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadualSubstitutoTriburario = New System.Windows.Forms.Label()
        Me.txtTelefone2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefone2 = New System.Windows.Forms.Label()
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefone1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefone1 = New System.Windows.Forms.Label()
        Me.txtInscricaoSuframa = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoSuframa = New System.Windows.Forms.Label()
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
        Me.txtInscricaoMunicipal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoMunicipal = New System.Windows.Forms.Label()
        Me.txtInscricaoEstadual = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadual = New System.Windows.Forms.Label()
        Me.txtCnpjCpf = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCnpjCpf = New System.Windows.Forms.Label()
        Me.txtLogradouro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnProcurarCEP = New System.Windows.Forms.Button()
        Me.btnCadastrarPais = New System.Windows.Forms.Button()
        Me.grpTipoParceiroNegocio = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkDespachante = New Janus.Windows.EditControls.UICheckBox()
        Me.chkAgenteLogistico = New Janus.Windows.EditControls.UICheckBox()
        Me.chkFornecedor = New Janus.Windows.EditControls.UICheckBox()
        Me.chkCliente = New Janus.Windows.EditControls.UICheckBox()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarSegmento = New System.Windows.Forms.Button()
        Me.lblSegmento = New System.Windows.Forms.Label()
        Me.cboSegmento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCNAE = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNAE = New System.Windows.Forms.Label()
        Me.lblRegimeTributario = New System.Windows.Forms.Label()
        Me.cboRegimeTributario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPersonalidade = New System.Windows.Forms.Label()
        Me.cboPersonalidade = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNomeFantasia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeFantasia = New System.Windows.Forms.Label()
        Me.txtRazaoSocial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRazaoSocial = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picEntregue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosGerais.SuspendLayout()
        CType(Me.grpTipoParceiroNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipoParceiroNegocio.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.pagLista.Controls.Add(Me.btnEditarGrid)
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.grpLegenda)
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
        'btnEditarGrid
        '
        resources.ApplyResources(Me.btnEditarGrid, "btnEditarGrid")
        Me.btnEditarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarGrid.FlatAppearance.BorderSize = 0
        Me.btnEditarGrid.Image = Global.INTERACTI.My.Resources.Resources.lapis
        Me.btnEditarGrid.Name = "btnEditarGrid"
        Me.btnEditarGrid.TabStop = False
        Me.btnEditarGrid.UseVisualStyleBackColor = False
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
        'grpLegenda
        '
        resources.ApplyResources(Me.grpLegenda, "grpLegenda")
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblParcialmenteEntregue)
        Me.grpLegenda.Controls.Add(Me.lblEntregue)
        Me.grpLegenda.Controls.Add(Me.picEntregue)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoVenda)
        Me.grpLegenda.Controls.Add(Me.picLegendaTipoOrcamento)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblParcialmenteEntregue
        '
        resources.ApplyResources(Me.lblParcialmenteEntregue, "lblParcialmenteEntregue")
        Me.lblParcialmenteEntregue.Name = "lblParcialmenteEntregue"
        '
        'lblEntregue
        '
        resources.ApplyResources(Me.lblEntregue, "lblEntregue")
        Me.lblEntregue.Name = "lblEntregue"
        '
        'picEntregue
        '
        Me.picEntregue.BackColor = System.Drawing.Color.Peru
        Me.picEntregue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picEntregue, "picEntregue")
        Me.picEntregue.Name = "picEntregue"
        Me.picEntregue.TabStop = False
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picLegendaCancelado, "picLegendaCancelado")
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.TabStop = False
        '
        'lblLegendaPedidoVenda
        '
        resources.ApplyResources(Me.lblLegendaPedidoVenda, "lblLegendaPedidoVenda")
        Me.lblLegendaPedidoVenda.Name = "lblLegendaPedidoVenda"
        '
        'picLegendaTipoOrcamento
        '
        Me.picLegendaTipoOrcamento.BackColor = System.Drawing.Color.Black
        Me.picLegendaTipoOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picLegendaTipoOrcamento, "picLegendaTipoOrcamento")
        Me.picLegendaTipoOrcamento.Name = "picLegendaTipoOrcamento"
        Me.picLegendaTipoOrcamento.TabStop = False
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
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.FrozenColumns = 5
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
        Me.grpControl.Controls.Add(Me.btnMalaDireta)
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
        'btnMalaDireta
        '
        resources.ApplyResources(Me.btnMalaDireta, "btnMalaDireta")
        Me.btnMalaDireta.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnMalaDireta.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnMalaDireta.Name = "btnMalaDireta"
        Me.btnMalaDireta.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnMalaDireta.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.grpFiltro.Controls.Add(Me.lblTipoNegativacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoNegativacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboVendedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblVendedorFiltro)
        Me.grpFiltro.Controls.Add(Me.txtMunicipioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMunicipioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSegmentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboSegmentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCnpjCpfFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCnpjCpfFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.cboPersonalidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNomeFantasiaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNomeFantasiaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtRazaoSocialFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRazaoSocialFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoParceiroNegocioFiltro)
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
        'lblTipoNegativacaoFiltro
        '
        resources.ApplyResources(Me.lblTipoNegativacaoFiltro, "lblTipoNegativacaoFiltro")
        Me.lblTipoNegativacaoFiltro.Name = "lblTipoNegativacaoFiltro"
        '
        'cboTipoNegativacaoFiltro
        '
        resources.ApplyResources(Me.cboTipoNegativacaoFiltro, "cboTipoNegativacaoFiltro")
        Me.cboTipoNegativacaoFiltro.Name = "cboTipoNegativacaoFiltro"
        Me.cboTipoNegativacaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'cboVendedorFiltro
        '
        Me.cboVendedorFiltro.AllowDrop = True
        resources.ApplyResources(Me.cboVendedorFiltro, "cboVendedorFiltro")
        Me.cboVendedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(cboVendedorFiltro_DesignTimeLayout, "cboVendedorFiltro_DesignTimeLayout")
        Me.cboVendedorFiltro.DesignTimeLayout = cboVendedorFiltro_DesignTimeLayout
        Me.cboVendedorFiltro.Name = "cboVendedorFiltro"
        Me.cboVendedorFiltro.SaveSettings = False
        Me.cboVendedorFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboVendedorFiltro.ValuesDataMember = Nothing
        '
        'lblVendedorFiltro
        '
        resources.ApplyResources(Me.lblVendedorFiltro, "lblVendedorFiltro")
        Me.lblVendedorFiltro.Name = "lblVendedorFiltro"
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
        'lblSegmentoFiltro
        '
        resources.ApplyResources(Me.lblSegmentoFiltro, "lblSegmentoFiltro")
        Me.lblSegmentoFiltro.Name = "lblSegmentoFiltro"
        '
        'cboSegmentoFiltro
        '
        resources.ApplyResources(Me.cboSegmentoFiltro, "cboSegmentoFiltro")
        Me.cboSegmentoFiltro.Name = "cboSegmentoFiltro"
        Me.cboSegmentoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblTipoParceiroNegocioFiltro
        '
        resources.ApplyResources(Me.lblTipoParceiroNegocioFiltro, "lblTipoParceiroNegocioFiltro")
        Me.lblTipoParceiroNegocioFiltro.Name = "lblTipoParceiroNegocioFiltro"
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
        'txtNomeFantasiaFiltro
        '
        resources.ApplyResources(Me.txtNomeFantasiaFiltro, "txtNomeFantasiaFiltro")
        Me.txtNomeFantasiaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        'cboTipoParceiroNegocioFiltro
        '
        resources.ApplyResources(Me.cboTipoParceiroNegocioFiltro, "cboTipoParceiroNegocioFiltro")
        Me.cboTipoParceiroNegocioFiltro.Name = "cboTipoParceiroNegocioFiltro"
        Me.cboTipoParceiroNegocioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblPersonalidadeFiltro
        '
        resources.ApplyResources(Me.lblPersonalidadeFiltro, "lblPersonalidadeFiltro")
        Me.lblPersonalidadeFiltro.Name = "lblPersonalidadeFiltro"
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDadosGerais)
        Me.pagDados.Controls.Add(Me.grpTipoParceiroNegocio)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Key = "padDados"
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'grpDadosGerais
        '
        resources.ApplyResources(Me.grpDadosGerais, "grpDadosGerais")
        Me.grpDadosGerais.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosGerais.Controls.Add(Me.cboCentroGasto)
        Me.grpDadosGerais.Controls.Add(Me.Label2)
        Me.grpDadosGerais.Controls.Add(Me.lblAvisoTempoCompra)
        Me.grpDadosGerais.Controls.Add(Me.txtAvisoTempoCompra)
        Me.grpDadosGerais.Controls.Add(Me.lblLimiteCredito)
        Me.grpDadosGerais.Controls.Add(Me.txtLimiteCredito)
        Me.grpDadosGerais.Controls.Add(Me.lblTipoInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.cboTipoInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.txtInscricaoEstadualSubstitutoTriburario)
        Me.grpDadosGerais.Controls.Add(Me.lblInscricaoEstadualSubstitutoTriburario)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefone2)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefone2)
        Me.grpDadosGerais.Controls.Add(Me.txtEmail)
        Me.grpDadosGerais.Controls.Add(Me.lblEmail)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefone1)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefone1)
        Me.grpDadosGerais.Controls.Add(Me.txtInscricaoSuframa)
        Me.grpDadosGerais.Controls.Add(Me.lblInscricaoSuframa)
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
        Me.grpDadosGerais.Controls.Add(Me.txtInscricaoMunicipal)
        Me.grpDadosGerais.Controls.Add(Me.lblInscricaoMunicipal)
        Me.grpDadosGerais.Controls.Add(Me.txtInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.lblInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.txtCnpjCpf)
        Me.grpDadosGerais.Controls.Add(Me.lblCnpjCpf)
        Me.grpDadosGerais.Controls.Add(Me.txtLogradouro)
        Me.grpDadosGerais.Controls.Add(Me.btnProcurarCEP)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarPais)
        Me.grpDadosGerais.Name = "grpDadosGerais"
        Me.grpDadosGerais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosGerais.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosGerais.VisualStyleManager = Me.vsmMain
        '
        'cboCentroGasto
        '
        resources.ApplyResources(Me.cboCentroGasto, "cboCentroGasto")
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'lblAvisoTempoCompra
        '
        resources.ApplyResources(Me.lblAvisoTempoCompra, "lblAvisoTempoCompra")
        Me.lblAvisoTempoCompra.Name = "lblAvisoTempoCompra"
        '
        'txtAvisoTempoCompra
        '
        Me.txtAvisoTempoCompra.DecimalDigits = 0
        resources.ApplyResources(Me.txtAvisoTempoCompra, "txtAvisoTempoCompra")
        Me.txtAvisoTempoCompra.Name = "txtAvisoTempoCompra"
        SuperTipSettings1.HeaderText = "Limite de Crédito"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = resources.GetString("SuperTipSettings1.Text")
        Me.jstTip.SetSuperTip(Me.txtAvisoTempoCompra, SuperTipSettings1)
        Me.txtAvisoTempoCompra.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.txtAvisoTempoCompra.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLimiteCredito
        '
        resources.ApplyResources(Me.lblLimiteCredito, "lblLimiteCredito")
        Me.lblLimiteCredito.Name = "lblLimiteCredito"
        '
        'txtLimiteCredito
        '
        resources.ApplyResources(Me.txtLimiteCredito, "txtLimiteCredito")
        Me.txtLimiteCredito.Name = "txtLimiteCredito"
        SuperTipSettings2.HeaderText = "Limite de Crédito"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = resources.GetString("SuperTipSettings2.Text")
        Me.jstTip.SetSuperTip(Me.txtLimiteCredito, SuperTipSettings2)
        Me.txtLimiteCredito.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTipoInscricaoEstadual
        '
        resources.ApplyResources(Me.lblTipoInscricaoEstadual, "lblTipoInscricaoEstadual")
        Me.lblTipoInscricaoEstadual.Name = "lblTipoInscricaoEstadual"
        '
        'cboTipoInscricaoEstadual
        '
        resources.ApplyResources(Me.cboTipoInscricaoEstadual, "cboTipoInscricaoEstadual")
        Me.cboTipoInscricaoEstadual.Name = "cboTipoInscricaoEstadual"
        Me.cboTipoInscricaoEstadual.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtInscricaoEstadualSubstitutoTriburario
        '
        resources.ApplyResources(Me.txtInscricaoEstadualSubstitutoTriburario, "txtInscricaoEstadualSubstitutoTriburario")
        Me.txtInscricaoEstadualSubstitutoTriburario.MaxLength = 14
        Me.txtInscricaoEstadualSubstitutoTriburario.Name = "txtInscricaoEstadualSubstitutoTriburario"
        SuperTipSettings3.ImageListProvider = Nothing
        Me.jstTip.SetSuperTip(Me.txtInscricaoEstadualSubstitutoTriburario, SuperTipSettings3)
        '
        'lblInscricaoEstadualSubstitutoTriburario
        '
        resources.ApplyResources(Me.lblInscricaoEstadualSubstitutoTriburario, "lblInscricaoEstadualSubstitutoTriburario")
        Me.lblInscricaoEstadualSubstitutoTriburario.Name = "lblInscricaoEstadualSubstitutoTriburario"
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
        'txtInscricaoSuframa
        '
        resources.ApplyResources(Me.txtInscricaoSuframa, "txtInscricaoSuframa")
        Me.txtInscricaoSuframa.MaxLength = 9
        Me.txtInscricaoSuframa.Name = "txtInscricaoSuframa"
        SuperTipSettings4.HeaderText = "Inscrição Suframa"
        SuperTipSettings4.ImageListProvider = Nothing
        SuperTipSettings4.Text = "Preencher Inscrição Suframa (somente números)"
        Me.jstTip.SetSuperTip(Me.txtInscricaoSuframa, SuperTipSettings4)
        '
        'lblInscricaoSuframa
        '
        resources.ApplyResources(Me.lblInscricaoSuframa, "lblInscricaoSuframa")
        Me.lblInscricaoSuframa.Name = "lblInscricaoSuframa"
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
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtComplemento, "txtComplemento")
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
        'txtInscricaoMunicipal
        '
        resources.ApplyResources(Me.txtInscricaoMunicipal, "txtInscricaoMunicipal")
        Me.txtInscricaoMunicipal.MaxLength = 15
        Me.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal"
        SuperTipSettings5.HeaderText = "Inscrição Municipal"
        SuperTipSettings5.ImageListProvider = Nothing
        SuperTipSettings5.Text = "Preencher Inscrição Municipal (somente números)"
        Me.jstTip.SetSuperTip(Me.txtInscricaoMunicipal, SuperTipSettings5)
        '
        'lblInscricaoMunicipal
        '
        resources.ApplyResources(Me.lblInscricaoMunicipal, "lblInscricaoMunicipal")
        Me.lblInscricaoMunicipal.Name = "lblInscricaoMunicipal"
        '
        'txtInscricaoEstadual
        '
        resources.ApplyResources(Me.txtInscricaoEstadual, "txtInscricaoEstadual")
        Me.txtInscricaoEstadual.MaxLength = 14
        Me.txtInscricaoEstadual.Name = "txtInscricaoEstadual"
        SuperTipSettings6.HeaderText = "Inscrição Estadual"
        SuperTipSettings6.ImageListProvider = Nothing
        SuperTipSettings6.Text = resources.GetString("SuperTipSettings6.Text")
        Me.jstTip.SetSuperTip(Me.txtInscricaoEstadual, SuperTipSettings6)
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
        'btnProcurarCEP
        '
        Me.btnProcurarCEP.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarCEP, "btnProcurarCEP")
        Me.btnProcurarCEP.Image = Global.INTERACTI.My.Resources.Resources.search
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
        'grpTipoParceiroNegocio
        '
        resources.ApplyResources(Me.grpTipoParceiroNegocio, "grpTipoParceiroNegocio")
        Me.grpTipoParceiroNegocio.BackColor = System.Drawing.Color.Transparent
        Me.grpTipoParceiroNegocio.Controls.Add(Me.chkDespachante)
        Me.grpTipoParceiroNegocio.Controls.Add(Me.chkAgenteLogistico)
        Me.grpTipoParceiroNegocio.Controls.Add(Me.chkFornecedor)
        Me.grpTipoParceiroNegocio.Controls.Add(Me.chkCliente)
        Me.grpTipoParceiroNegocio.Name = "grpTipoParceiroNegocio"
        Me.grpTipoParceiroNegocio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTipoParceiroNegocio.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpTipoParceiroNegocio.VisualStyleManager = Me.vsmMain
        '
        'chkDespachante
        '
        resources.ApplyResources(Me.chkDespachante, "chkDespachante")
        Me.chkDespachante.Name = "chkDespachante"
        '
        'chkAgenteLogistico
        '
        resources.ApplyResources(Me.chkAgenteLogistico, "chkAgenteLogistico")
        Me.chkAgenteLogistico.Name = "chkAgenteLogistico"
        '
        'chkFornecedor
        '
        resources.ApplyResources(Me.chkFornecedor, "chkFornecedor")
        Me.chkFornecedor.Name = "chkFornecedor"
        '
        'chkCliente
        '
        resources.ApplyResources(Me.chkCliente, "chkCliente")
        Me.chkCliente.Name = "chkCliente"
        '
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnCadastrarSegmento)
        Me.grpDados.Controls.Add(Me.lblSegmento)
        Me.grpDados.Controls.Add(Me.cboSegmento)
        Me.grpDados.Controls.Add(Me.txtCNAE)
        Me.grpDados.Controls.Add(Me.lblCNAE)
        Me.grpDados.Controls.Add(Me.lblRegimeTributario)
        Me.grpDados.Controls.Add(Me.cboRegimeTributario)
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
        'btnCadastrarSegmento
        '
        Me.btnCadastrarSegmento.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarSegmento, "btnCadastrarSegmento")
        Me.btnCadastrarSegmento.Name = "btnCadastrarSegmento"
        Me.btnCadastrarSegmento.TabStop = False
        Me.btnCadastrarSegmento.UseVisualStyleBackColor = True
        '
        'lblSegmento
        '
        resources.ApplyResources(Me.lblSegmento, "lblSegmento")
        Me.lblSegmento.Name = "lblSegmento"
        '
        'cboSegmento
        '
        resources.ApplyResources(Me.cboSegmento, "cboSegmento")
        Me.cboSegmento.Name = "cboSegmento"
        Me.cboSegmento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtCNAE
        '
        resources.ApplyResources(Me.txtCNAE, "txtCNAE")
        Me.txtCNAE.MaxLength = 7
        Me.txtCNAE.Name = "txtCNAE"
        '
        'lblCNAE
        '
        resources.ApplyResources(Me.lblCNAE, "lblCNAE")
        Me.lblCNAE.Name = "lblCNAE"
        '
        'lblRegimeTributario
        '
        resources.ApplyResources(Me.lblRegimeTributario, "lblRegimeTributario")
        Me.lblRegimeTributario.Name = "lblRegimeTributario"
        '
        'cboRegimeTributario
        '
        resources.ApplyResources(Me.cboRegimeTributario, "cboRegimeTributario")
        Me.cboRegimeTributario.Name = "cboRegimeTributario"
        Me.cboRegimeTributario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        resources.ApplyResources(Me.txtNomeFantasia, "txtNomeFantasia")
        Me.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadParceiroNegocioNFE
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadParceiroNegocioNFE"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picEntregue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosGerais.ResumeLayout(False)
        Me.grpDadosGerais.PerformLayout()
        CType(Me.grpTipoParceiroNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipoParceiroNegocio.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosGerais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCnpjCpf As System.Windows.Forms.Label
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPersonalidade As System.Windows.Forms.Label
    Friend WithEvents cboPersonalidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNomeFantasia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeFantasia As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents txtCnpjCpf As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtInscricaoMunicipal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoMunicipal As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoEstadual As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadual As System.Windows.Forms.Label
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
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPersonalidadeFiltro As System.Windows.Forms.Label
    Friend WithEvents cboPersonalidadeFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNomeFantasiaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeFantasiaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocialFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRazaoSocialFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCnpjCpfFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCnpjCpfFiltro As System.Windows.Forms.Label
    Friend WithEvents txtBairro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplemento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtLogradouro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumero As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoParceiroNegocioFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoParceiroNegocioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpTipoParceiroNegocio As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkFornecedor As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkCliente As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents cboMunicipio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRegimeTributario As System.Windows.Forms.Label
    Friend WithEvents cboRegimeTributario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtInscricaoSuframa As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoSuframa As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarPais As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnProcurarCEP As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblTelefone1 As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTelefone1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTelefone2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefone2 As System.Windows.Forms.Label
    Friend WithEvents btnMalaDireta As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCNAE As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNAE As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoEstadualSubstitutoTriburario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadualSubstitutoTriburario As System.Windows.Forms.Label
    Friend WithEvents lblSegmento As System.Windows.Forms.Label
    Friend WithEvents cboSegmento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSegmentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboSegmentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarSegmento As System.Windows.Forms.Button
    Friend WithEvents txtMunicipioFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMunicipioFiltro As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents lblVendedorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboVendedorFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents chkAgenteLogistico As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkDespachante As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblParcialmenteEntregue As System.Windows.Forms.Label
    Friend WithEvents lblEntregue As System.Windows.Forms.Label
    Friend WithEvents picEntregue As System.Windows.Forms.PictureBox
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents picLegendaTipoOrcamento As System.Windows.Forms.PictureBox
    Friend WithEvents lblTipoNegativacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoNegativacaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents lblTipoInscricaoEstadual As System.Windows.Forms.Label
    Friend WithEvents cboTipoInscricaoEstadual As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboImportado As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnEditarGrid As System.Windows.Forms.Button
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAvisoTempoCompra As System.Windows.Forms.Label
    Friend WithEvents txtAvisoTempoCompra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLimiteCredito As System.Windows.Forms.Label
    Friend WithEvents txtLimiteCredito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
