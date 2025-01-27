<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadProdutoNFE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadProdutoNFE))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnEditarGrid = New System.Windows.Forms.Button()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMarcaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblControlaQualidadeFiltro = New System.Windows.Forms.Label()
        Me.cboControlaQualidadeFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblInsumoProducaoFiltro = New System.Windows.Forms.Label()
        Me.cboInsumoProducaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCodigo2Filtro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigo2Filtro = New System.Windows.Forms.Label()
        Me.lblMarcaFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricao2Filtro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao2Filtro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoEANFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoEANFiltro = New System.Windows.Forms.Label()
        Me.lblCodigoFiltro = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosGerais = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.lblInsumoProducao = New System.Windows.Forms.Label()
        Me.cboInsumoProducao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.lblOrigemItem = New System.Windows.Forms.Label()
        Me.cboOrigemItem = New Janus.Windows.EditControls.UIComboBox()
        Me.txtPesoLiquido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPesoLiquido = New System.Windows.Forms.Label()
        Me.txtDescricaoNCM = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoNCM = New System.Windows.Forms.Label()
        Me.lblCodigoNCM = New System.Windows.Forms.Label()
        Me.cboCodigoNCM = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarNCM = New System.Windows.Forms.Button()
        Me.grpTipoItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkItemProducao = New Janus.Windows.EditControls.UICheckBox()
        Me.chkAtivoFixo = New Janus.Windows.EditControls.UICheckBox()
        Me.chkItemCompra = New Janus.Windows.EditControls.UICheckBox()
        Me.chkItemVenda = New Janus.Windows.EditControls.UICheckBox()
        Me.chkItemEstoque = New Janus.Windows.EditControls.UICheckBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarGrupoItem = New System.Windows.Forms.Button()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.txtCodigo2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigo2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtCodigoEAN = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.cboGrupoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoEAN = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnCadastrarGrupoItem = New System.Windows.Forms.Button()
        Me.btnExcelGridContaContabil = New System.Windows.Forms.Button()
        Me.btnAgruparGridContaContabil = New System.Windows.Forms.Button()
        Me.btnConfigurarGridContaContabil = New System.Windows.Forms.Button()
        Me.btnExcelGridClienteVenda = New System.Windows.Forms.Button()
        Me.btnAgruparGridClienteVenda = New System.Windows.Forms.Button()
        Me.btnConfigurarGridClienteVenda = New System.Windows.Forms.Button()
        Me.btnExcelGridFornecedor = New System.Windows.Forms.Button()
        Me.btnAgruparGridFornecedor = New System.Windows.Forms.Button()
        Me.btnConfigurarGridFornecedor = New System.Windows.Forms.Button()
        Me.btnExcelGridLocalizacao = New System.Windows.Forms.Button()
        Me.btnAgruparGridLocalizacao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridLocalizacao = New System.Windows.Forms.Button()
        Me.btnExcelGridRoteiro = New System.Windows.Forms.Button()
        Me.btnAgruparGridRoteiro = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRoteiro = New System.Windows.Forms.Button()
        Me.btnExcelGridBOM = New System.Windows.Forms.Button()
        Me.btnAgruparGridBOM = New System.Windows.Forms.Button()
        Me.btnConfigurarGridBOM = New System.Windows.Forms.Button()
        Me.btnExcelGridQualidade = New System.Windows.Forms.Button()
        Me.btnAgruparGridQualidade = New System.Windows.Forms.Button()
        Me.btnConfigurarGridQualidade = New System.Windows.Forms.Button()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.btnExcelGridEmbalagem = New System.Windows.Forms.Button()
        Me.btnAgruparGridEmbalagem = New System.Windows.Forms.Button()
        Me.btnConfigurarGridEmbalagem = New System.Windows.Forms.Button()
        Me.btnExcelGridUnidadeMedida = New System.Windows.Forms.Button()
        Me.btnAgruparGridUnidadeMedida = New System.Windows.Forms.Button()
        Me.btnConfigurarGridUnidadeMedida = New System.Windows.Forms.Button()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosGerais.SuspendLayout()
        CType(Me.grpTipoItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipoItem.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnEditarGrid)
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
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
        Me.grdListagem.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdListagem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        resources.ApplyResources(Me.grpFiltro, "grpFiltro")
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblControlaQualidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.cboControlaQualidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.lblInsumoProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboInsumoProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigo2Filtro)
        Me.grpFiltro.Controls.Add(Me.lblCodigo2Filtro)
        Me.grpFiltro.Controls.Add(Me.lblMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricao2Filtro)
        Me.grpFiltro.Controls.Add(Me.lblDescricao2Filtro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoEANFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoEANFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoFiltro)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboMarcaFiltro
        '
        resources.ApplyResources(Me.cboMarcaFiltro, "cboMarcaFiltro")
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem1, "UiComboBoxItem1")
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem2, "UiComboBoxItem2")
        Me.cboMarcaFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboMarcaFiltro.Name = "cboMarcaFiltro"
        Me.cboMarcaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblControlaQualidadeFiltro
        '
        resources.ApplyResources(Me.lblControlaQualidadeFiltro, "lblControlaQualidadeFiltro")
        Me.lblControlaQualidadeFiltro.Name = "lblControlaQualidadeFiltro"
        '
        'cboControlaQualidadeFiltro
        '
        resources.ApplyResources(Me.cboControlaQualidadeFiltro, "cboControlaQualidadeFiltro")
        Me.cboControlaQualidadeFiltro.Name = "cboControlaQualidadeFiltro"
        Me.cboControlaQualidadeFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblInsumoProducaoFiltro
        '
        resources.ApplyResources(Me.lblInsumoProducaoFiltro, "lblInsumoProducaoFiltro")
        Me.lblInsumoProducaoFiltro.Name = "lblInsumoProducaoFiltro"
        '
        'cboInsumoProducaoFiltro
        '
        resources.ApplyResources(Me.cboInsumoProducaoFiltro, "cboInsumoProducaoFiltro")
        Me.cboInsumoProducaoFiltro.Name = "cboInsumoProducaoFiltro"
        Me.cboInsumoProducaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtCodigo2Filtro
        '
        resources.ApplyResources(Me.txtCodigo2Filtro, "txtCodigo2Filtro")
        Me.txtCodigo2Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo2Filtro.Name = "txtCodigo2Filtro"
        '
        'lblCodigo2Filtro
        '
        resources.ApplyResources(Me.lblCodigo2Filtro, "lblCodigo2Filtro")
        Me.lblCodigo2Filtro.Name = "lblCodigo2Filtro"
        '
        'lblMarcaFiltro
        '
        resources.ApplyResources(Me.lblMarcaFiltro, "lblMarcaFiltro")
        Me.lblMarcaFiltro.Name = "lblMarcaFiltro"
        '
        'txtCodigoFiltro
        '
        resources.ApplyResources(Me.txtCodigoFiltro, "txtCodigoFiltro")
        Me.txtCodigoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoFiltro.Name = "txtCodigoFiltro"
        '
        'txtDescricao2Filtro
        '
        resources.ApplyResources(Me.txtDescricao2Filtro, "txtDescricao2Filtro")
        Me.txtDescricao2Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao2Filtro.MaxLength = 500
        Me.txtDescricao2Filtro.Name = "txtDescricao2Filtro"
        '
        'lblDescricao2Filtro
        '
        resources.ApplyResources(Me.lblDescricao2Filtro, "lblDescricao2Filtro")
        Me.lblDescricao2Filtro.Name = "lblDescricao2Filtro"
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
        'txtDescricaoFiltro
        '
        resources.ApplyResources(Me.txtDescricaoFiltro, "txtDescricaoFiltro")
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.MaxLength = 120
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        '
        'lblDescricaoFiltro
        '
        resources.ApplyResources(Me.lblDescricaoFiltro, "lblDescricaoFiltro")
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        '
        'txtCodigoEANFiltro
        '
        resources.ApplyResources(Me.txtCodigoEANFiltro, "txtCodigoEANFiltro")
        Me.txtCodigoEANFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoEANFiltro.MaxLength = 14
        Me.txtCodigoEANFiltro.Name = "txtCodigoEANFiltro"
        '
        'lblGrupoItemFiltro
        '
        resources.ApplyResources(Me.lblGrupoItemFiltro, "lblGrupoItemFiltro")
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        '
        'cboGrupoItemFiltro
        '
        resources.ApplyResources(Me.cboGrupoItemFiltro, "cboGrupoItemFiltro")
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCodigoEANFiltro
        '
        resources.ApplyResources(Me.lblCodigoEANFiltro, "lblCodigoEANFiltro")
        Me.lblCodigoEANFiltro.Name = "lblCodigoEANFiltro"
        '
        'lblCodigoFiltro
        '
        resources.ApplyResources(Me.lblCodigoFiltro, "lblCodigoFiltro")
        Me.lblCodigoFiltro.Name = "lblCodigoFiltro"
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
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDadosGerais)
        Me.pagDados.Controls.Add(Me.grpTipoItem)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Key = "pagDados"
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        Me.pagDados.Tag = ""
        '
        'grpDadosGerais
        '
        resources.ApplyResources(Me.grpDadosGerais, "grpDadosGerais")
        Me.grpDadosGerais.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosGerais.Controls.Add(Me.cboUnidadeMedida)
        Me.grpDadosGerais.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDadosGerais.Controls.Add(Me.lblInsumoProducao)
        Me.grpDadosGerais.Controls.Add(Me.cboInsumoProducao)
        Me.grpDadosGerais.Controls.Add(Me.txtObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblOrigemItem)
        Me.grpDadosGerais.Controls.Add(Me.cboOrigemItem)
        Me.grpDadosGerais.Controls.Add(Me.txtPesoLiquido)
        Me.grpDadosGerais.Controls.Add(Me.lblPesoLiquido)
        Me.grpDadosGerais.Controls.Add(Me.txtDescricaoNCM)
        Me.grpDadosGerais.Controls.Add(Me.lblDescricaoNCM)
        Me.grpDadosGerais.Controls.Add(Me.lblCodigoNCM)
        Me.grpDadosGerais.Controls.Add(Me.cboCodigoNCM)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarNCM)
        Me.grpDadosGerais.Name = "grpDadosGerais"
        Me.grpDadosGerais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosGerais.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosGerais.VisualStyleManager = Me.vsmMain
        '
        'cboUnidadeMedida
        '
        resources.ApplyResources(Me.cboUnidadeMedida, "cboUnidadeMedida")
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblUnidadeMedida
        '
        resources.ApplyResources(Me.lblUnidadeMedida, "lblUnidadeMedida")
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        '
        'lblInsumoProducao
        '
        resources.ApplyResources(Me.lblInsumoProducao, "lblInsumoProducao")
        Me.lblInsumoProducao.Name = "lblInsumoProducao"
        '
        'cboInsumoProducao
        '
        resources.ApplyResources(Me.cboInsumoProducao, "cboInsumoProducao")
        Me.cboInsumoProducao.Name = "cboInsumoProducao"
        Me.cboInsumoProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        'lblOrigemItem
        '
        resources.ApplyResources(Me.lblOrigemItem, "lblOrigemItem")
        Me.lblOrigemItem.Name = "lblOrigemItem"
        '
        'cboOrigemItem
        '
        resources.ApplyResources(Me.cboOrigemItem, "cboOrigemItem")
        Me.cboOrigemItem.Name = "cboOrigemItem"
        Me.cboOrigemItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtPesoLiquido
        '
        Me.txtPesoLiquido.DecimalDigits = 4
        resources.ApplyResources(Me.txtPesoLiquido, "txtPesoLiquido")
        Me.txtPesoLiquido.Name = "txtPesoLiquido"
        Me.txtPesoLiquido.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblPesoLiquido
        '
        resources.ApplyResources(Me.lblPesoLiquido, "lblPesoLiquido")
        Me.lblPesoLiquido.Name = "lblPesoLiquido"
        '
        'txtDescricaoNCM
        '
        resources.ApplyResources(Me.txtDescricaoNCM, "txtDescricaoNCM")
        Me.txtDescricaoNCM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoNCM.MaxLength = 60
        Me.txtDescricaoNCM.Name = "txtDescricaoNCM"
        Me.txtDescricaoNCM.ReadOnly = True
        Me.txtDescricaoNCM.TabStop = False
        '
        'lblDescricaoNCM
        '
        resources.ApplyResources(Me.lblDescricaoNCM, "lblDescricaoNCM")
        Me.lblDescricaoNCM.Name = "lblDescricaoNCM"
        '
        'lblCodigoNCM
        '
        resources.ApplyResources(Me.lblCodigoNCM, "lblCodigoNCM")
        Me.lblCodigoNCM.Name = "lblCodigoNCM"
        '
        'cboCodigoNCM
        '
        resources.ApplyResources(Me.cboCodigoNCM, "cboCodigoNCM")
        Me.cboCodigoNCM.Name = "cboCodigoNCM"
        Me.cboCodigoNCM.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'btnCadastrarNCM
        '
        Me.btnCadastrarNCM.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarNCM, "btnCadastrarNCM")
        Me.btnCadastrarNCM.Name = "btnCadastrarNCM"
        Me.btnCadastrarNCM.TabStop = False
        Me.btnCadastrarNCM.UseVisualStyleBackColor = True
        '
        'grpTipoItem
        '
        resources.ApplyResources(Me.grpTipoItem, "grpTipoItem")
        Me.grpTipoItem.BackColor = System.Drawing.Color.Transparent
        Me.grpTipoItem.Controls.Add(Me.chkItemProducao)
        Me.grpTipoItem.Controls.Add(Me.chkAtivoFixo)
        Me.grpTipoItem.Controls.Add(Me.chkItemCompra)
        Me.grpTipoItem.Controls.Add(Me.chkItemVenda)
        Me.grpTipoItem.Controls.Add(Me.chkItemEstoque)
        Me.grpTipoItem.Name = "grpTipoItem"
        Me.grpTipoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTipoItem.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpTipoItem.VisualStyleManager = Me.vsmMain
        '
        'chkItemProducao
        '
        resources.ApplyResources(Me.chkItemProducao, "chkItemProducao")
        Me.chkItemProducao.Name = "chkItemProducao"
        '
        'chkAtivoFixo
        '
        resources.ApplyResources(Me.chkAtivoFixo, "chkAtivoFixo")
        Me.chkAtivoFixo.Name = "chkAtivoFixo"
        '
        'chkItemCompra
        '
        resources.ApplyResources(Me.chkItemCompra, "chkItemCompra")
        Me.chkItemCompra.Name = "chkItemCompra"
        '
        'chkItemVenda
        '
        resources.ApplyResources(Me.chkItemVenda, "chkItemVenda")
        Me.chkItemVenda.Name = "chkItemVenda"
        '
        'chkItemEstoque
        '
        resources.ApplyResources(Me.chkItemEstoque, "chkItemEstoque")
        Me.chkItemEstoque.Name = "chkItemEstoque"
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
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnProcurarGrupoItem)
        Me.grpDados.Controls.Add(Me.txtReferencia)
        Me.grpDados.Controls.Add(Me.lblReferencia)
        Me.grpDados.Controls.Add(Me.txtCodigo2)
        Me.grpDados.Controls.Add(Me.lblCodigo2)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.txtCodigoEAN)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblGrupoItem)
        Me.grpDados.Controls.Add(Me.cboGrupoItem)
        Me.grpDados.Controls.Add(Me.lblCodigoEAN)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.btnCadastrarGrupoItem)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarGrupoItem
        '
        resources.ApplyResources(Me.btnProcurarGrupoItem, "btnProcurarGrupoItem")
        Me.btnProcurarGrupoItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarGrupoItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarGrupoItem.Name = "btnProcurarGrupoItem"
        Me.btnProcurarGrupoItem.TabStop = False
        Me.btnProcurarGrupoItem.UseVisualStyleBackColor = True
        '
        'txtReferencia
        '
        resources.ApplyResources(Me.txtReferencia, "txtReferencia")
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.MaxLength = 100
        Me.txtReferencia.Name = "txtReferencia"
        '
        'lblReferencia
        '
        resources.ApplyResources(Me.lblReferencia, "lblReferencia")
        Me.lblReferencia.Name = "lblReferencia"
        '
        'txtCodigo2
        '
        resources.ApplyResources(Me.txtCodigo2, "txtCodigo2")
        Me.txtCodigo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo2.Name = "txtCodigo2"
        '
        'lblCodigo2
        '
        resources.ApplyResources(Me.lblCodigo2, "lblCodigo2")
        Me.lblCodigo2.Name = "lblCodigo2"
        '
        'txtCodigo
        '
        resources.ApplyResources(Me.txtCodigo, "txtCodigo")
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Name = "txtCodigo"
        '
        'txtDescricao
        '
        resources.ApplyResources(Me.txtDescricao, "txtDescricao")
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        '
        'lblDescricao
        '
        resources.ApplyResources(Me.lblDescricao, "lblDescricao")
        Me.lblDescricao.Name = "lblDescricao"
        '
        'txtCodigoEAN
        '
        resources.ApplyResources(Me.txtCodigoEAN, "txtCodigoEAN")
        Me.txtCodigoEAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoEAN.MaxLength = 14
        Me.txtCodigoEAN.Name = "txtCodigoEAN"
        '
        'lblAtivo
        '
        resources.ApplyResources(Me.lblAtivo, "lblAtivo")
        Me.lblAtivo.Name = "lblAtivo"
        '
        'cboAtivo
        '
        resources.ApplyResources(Me.cboAtivo, "cboAtivo")
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem3, "UiComboBoxItem3")
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem4, "UiComboBoxItem4")
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblGrupoItem
        '
        resources.ApplyResources(Me.lblGrupoItem, "lblGrupoItem")
        Me.lblGrupoItem.Name = "lblGrupoItem"
        '
        'cboGrupoItem
        '
        resources.ApplyResources(Me.cboGrupoItem, "cboGrupoItem")
        Me.cboGrupoItem.Name = "cboGrupoItem"
        Me.cboGrupoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCodigoEAN
        '
        resources.ApplyResources(Me.lblCodigoEAN, "lblCodigoEAN")
        Me.lblCodigoEAN.Name = "lblCodigoEAN"
        '
        'lblCodigo
        '
        resources.ApplyResources(Me.lblCodigo, "lblCodigo")
        Me.lblCodigo.Name = "lblCodigo"
        '
        'btnCadastrarGrupoItem
        '
        Me.btnCadastrarGrupoItem.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarGrupoItem, "btnCadastrarGrupoItem")
        Me.btnCadastrarGrupoItem.Name = "btnCadastrarGrupoItem"
        Me.btnCadastrarGrupoItem.TabStop = False
        Me.btnCadastrarGrupoItem.UseVisualStyleBackColor = True
        '
        'btnExcelGridContaContabil
        '
        resources.ApplyResources(Me.btnExcelGridContaContabil, "btnExcelGridContaContabil")
        Me.btnExcelGridContaContabil.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridContaContabil.FlatAppearance.BorderSize = 0
        Me.btnExcelGridContaContabil.Name = "btnExcelGridContaContabil"
        Me.btnExcelGridContaContabil.TabStop = False
        Me.btnExcelGridContaContabil.UseVisualStyleBackColor = False
        '
        'btnAgruparGridContaContabil
        '
        resources.ApplyResources(Me.btnAgruparGridContaContabil, "btnAgruparGridContaContabil")
        Me.btnAgruparGridContaContabil.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridContaContabil.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridContaContabil.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridContaContabil.Name = "btnAgruparGridContaContabil"
        Me.btnAgruparGridContaContabil.TabStop = False
        Me.btnAgruparGridContaContabil.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridContaContabil
        '
        resources.ApplyResources(Me.btnConfigurarGridContaContabil, "btnConfigurarGridContaContabil")
        Me.btnConfigurarGridContaContabil.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridContaContabil.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridContaContabil.Name = "btnConfigurarGridContaContabil"
        Me.btnConfigurarGridContaContabil.TabStop = False
        Me.btnConfigurarGridContaContabil.UseVisualStyleBackColor = False
        '
        'btnExcelGridClienteVenda
        '
        resources.ApplyResources(Me.btnExcelGridClienteVenda, "btnExcelGridClienteVenda")
        Me.btnExcelGridClienteVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridClienteVenda.FlatAppearance.BorderSize = 0
        Me.btnExcelGridClienteVenda.Name = "btnExcelGridClienteVenda"
        Me.btnExcelGridClienteVenda.TabStop = False
        Me.btnExcelGridClienteVenda.UseVisualStyleBackColor = False
        '
        'btnAgruparGridClienteVenda
        '
        resources.ApplyResources(Me.btnAgruparGridClienteVenda, "btnAgruparGridClienteVenda")
        Me.btnAgruparGridClienteVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridClienteVenda.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridClienteVenda.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridClienteVenda.Name = "btnAgruparGridClienteVenda"
        Me.btnAgruparGridClienteVenda.TabStop = False
        Me.btnAgruparGridClienteVenda.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridClienteVenda
        '
        resources.ApplyResources(Me.btnConfigurarGridClienteVenda, "btnConfigurarGridClienteVenda")
        Me.btnConfigurarGridClienteVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridClienteVenda.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridClienteVenda.Name = "btnConfigurarGridClienteVenda"
        Me.btnConfigurarGridClienteVenda.TabStop = False
        Me.btnConfigurarGridClienteVenda.UseVisualStyleBackColor = False
        '
        'btnExcelGridFornecedor
        '
        resources.ApplyResources(Me.btnExcelGridFornecedor, "btnExcelGridFornecedor")
        Me.btnExcelGridFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridFornecedor.FlatAppearance.BorderSize = 0
        Me.btnExcelGridFornecedor.Name = "btnExcelGridFornecedor"
        Me.btnExcelGridFornecedor.TabStop = False
        Me.btnExcelGridFornecedor.UseVisualStyleBackColor = False
        '
        'btnAgruparGridFornecedor
        '
        resources.ApplyResources(Me.btnAgruparGridFornecedor, "btnAgruparGridFornecedor")
        Me.btnAgruparGridFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridFornecedor.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridFornecedor.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridFornecedor.Name = "btnAgruparGridFornecedor"
        Me.btnAgruparGridFornecedor.TabStop = False
        Me.btnAgruparGridFornecedor.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridFornecedor
        '
        resources.ApplyResources(Me.btnConfigurarGridFornecedor, "btnConfigurarGridFornecedor")
        Me.btnConfigurarGridFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridFornecedor.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridFornecedor.Name = "btnConfigurarGridFornecedor"
        Me.btnConfigurarGridFornecedor.TabStop = False
        Me.btnConfigurarGridFornecedor.UseVisualStyleBackColor = False
        '
        'btnExcelGridLocalizacao
        '
        resources.ApplyResources(Me.btnExcelGridLocalizacao, "btnExcelGridLocalizacao")
        Me.btnExcelGridLocalizacao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridLocalizacao.FlatAppearance.BorderSize = 0
        Me.btnExcelGridLocalizacao.Name = "btnExcelGridLocalizacao"
        Me.btnExcelGridLocalizacao.TabStop = False
        Me.btnExcelGridLocalizacao.UseVisualStyleBackColor = False
        '
        'btnAgruparGridLocalizacao
        '
        resources.ApplyResources(Me.btnAgruparGridLocalizacao, "btnAgruparGridLocalizacao")
        Me.btnAgruparGridLocalizacao.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridLocalizacao.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridLocalizacao.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridLocalizacao.Name = "btnAgruparGridLocalizacao"
        Me.btnAgruparGridLocalizacao.TabStop = False
        Me.btnAgruparGridLocalizacao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridLocalizacao
        '
        resources.ApplyResources(Me.btnConfigurarGridLocalizacao, "btnConfigurarGridLocalizacao")
        Me.btnConfigurarGridLocalizacao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridLocalizacao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridLocalizacao.Name = "btnConfigurarGridLocalizacao"
        Me.btnConfigurarGridLocalizacao.TabStop = False
        Me.btnConfigurarGridLocalizacao.UseVisualStyleBackColor = False
        '
        'btnExcelGridRoteiro
        '
        resources.ApplyResources(Me.btnExcelGridRoteiro, "btnExcelGridRoteiro")
        Me.btnExcelGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnExcelGridRoteiro.Name = "btnExcelGridRoteiro"
        Me.btnExcelGridRoteiro.TabStop = False
        Me.btnExcelGridRoteiro.UseVisualStyleBackColor = False
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
        Me.btnConfigurarGridRoteiro.Name = "btnConfigurarGridRoteiro"
        Me.btnConfigurarGridRoteiro.TabStop = False
        Me.btnConfigurarGridRoteiro.UseVisualStyleBackColor = False
        '
        'btnExcelGridBOM
        '
        resources.ApplyResources(Me.btnExcelGridBOM, "btnExcelGridBOM")
        Me.btnExcelGridBOM.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridBOM.FlatAppearance.BorderSize = 0
        Me.btnExcelGridBOM.Name = "btnExcelGridBOM"
        Me.btnExcelGridBOM.TabStop = False
        Me.btnExcelGridBOM.UseVisualStyleBackColor = False
        '
        'btnAgruparGridBOM
        '
        resources.ApplyResources(Me.btnAgruparGridBOM, "btnAgruparGridBOM")
        Me.btnAgruparGridBOM.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridBOM.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridBOM.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridBOM.Name = "btnAgruparGridBOM"
        Me.btnAgruparGridBOM.TabStop = False
        Me.btnAgruparGridBOM.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridBOM
        '
        resources.ApplyResources(Me.btnConfigurarGridBOM, "btnConfigurarGridBOM")
        Me.btnConfigurarGridBOM.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridBOM.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridBOM.Name = "btnConfigurarGridBOM"
        Me.btnConfigurarGridBOM.TabStop = False
        Me.btnConfigurarGridBOM.UseVisualStyleBackColor = False
        '
        'btnExcelGridQualidade
        '
        resources.ApplyResources(Me.btnExcelGridQualidade, "btnExcelGridQualidade")
        Me.btnExcelGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnExcelGridQualidade.Name = "btnExcelGridQualidade"
        Me.btnExcelGridQualidade.TabStop = False
        Me.btnExcelGridQualidade.UseVisualStyleBackColor = False
        '
        'btnAgruparGridQualidade
        '
        resources.ApplyResources(Me.btnAgruparGridQualidade, "btnAgruparGridQualidade")
        Me.btnAgruparGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridQualidade.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridQualidade.Name = "btnAgruparGridQualidade"
        Me.btnAgruparGridQualidade.TabStop = False
        Me.btnAgruparGridQualidade.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridQualidade
        '
        resources.ApplyResources(Me.btnConfigurarGridQualidade, "btnConfigurarGridQualidade")
        Me.btnConfigurarGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridQualidade.Name = "btnConfigurarGridQualidade"
        Me.btnConfigurarGridQualidade.TabStop = False
        Me.btnConfigurarGridQualidade.UseVisualStyleBackColor = False
        '
        'btnExcelGridArquivo
        '
        resources.ApplyResources(Me.btnExcelGridArquivo, "btnExcelGridArquivo")
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        resources.ApplyResources(Me.btnAgruparGridArquivo, "btnAgruparGridArquivo")
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.TabStop = False
        Me.btnAgruparGridArquivo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridArquivo
        '
        resources.ApplyResources(Me.btnConfigurarGridArquivo, "btnConfigurarGridArquivo")
        Me.btnConfigurarGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'btnExcelGridEmbalagem
        '
        resources.ApplyResources(Me.btnExcelGridEmbalagem, "btnExcelGridEmbalagem")
        Me.btnExcelGridEmbalagem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridEmbalagem.FlatAppearance.BorderSize = 0
        Me.btnExcelGridEmbalagem.Name = "btnExcelGridEmbalagem"
        Me.btnExcelGridEmbalagem.TabStop = False
        Me.btnExcelGridEmbalagem.UseVisualStyleBackColor = False
        '
        'btnAgruparGridEmbalagem
        '
        resources.ApplyResources(Me.btnAgruparGridEmbalagem, "btnAgruparGridEmbalagem")
        Me.btnAgruparGridEmbalagem.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridEmbalagem.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridEmbalagem.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridEmbalagem.Name = "btnAgruparGridEmbalagem"
        Me.btnAgruparGridEmbalagem.TabStop = False
        Me.btnAgruparGridEmbalagem.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridEmbalagem
        '
        resources.ApplyResources(Me.btnConfigurarGridEmbalagem, "btnConfigurarGridEmbalagem")
        Me.btnConfigurarGridEmbalagem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridEmbalagem.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridEmbalagem.Name = "btnConfigurarGridEmbalagem"
        Me.btnConfigurarGridEmbalagem.TabStop = False
        Me.btnConfigurarGridEmbalagem.UseVisualStyleBackColor = False
        '
        'btnExcelGridUnidadeMedida
        '
        resources.ApplyResources(Me.btnExcelGridUnidadeMedida, "btnExcelGridUnidadeMedida")
        Me.btnExcelGridUnidadeMedida.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnExcelGridUnidadeMedida.Name = "btnExcelGridUnidadeMedida"
        Me.btnExcelGridUnidadeMedida.TabStop = False
        Me.btnExcelGridUnidadeMedida.UseVisualStyleBackColor = False
        '
        'btnAgruparGridUnidadeMedida
        '
        resources.ApplyResources(Me.btnAgruparGridUnidadeMedida, "btnAgruparGridUnidadeMedida")
        Me.btnAgruparGridUnidadeMedida.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridUnidadeMedida.Name = "btnAgruparGridUnidadeMedida"
        Me.btnAgruparGridUnidadeMedida.TabStop = False
        Me.btnAgruparGridUnidadeMedida.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridUnidadeMedida
        '
        resources.ApplyResources(Me.btnConfigurarGridUnidadeMedida, "btnConfigurarGridUnidadeMedida")
        Me.btnConfigurarGridUnidadeMedida.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridUnidadeMedida.Name = "btnConfigurarGridUnidadeMedida"
        Me.btnConfigurarGridUnidadeMedida.TabStop = False
        Me.btnConfigurarGridUnidadeMedida.UseVisualStyleBackColor = False
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadProdutoNFE
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadProdutoNFE"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosGerais.ResumeLayout(False)
        Me.grpDadosGerais.PerformLayout()
        CType(Me.grpTipoItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipoItem.ResumeLayout(False)
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
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
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricao2Filtro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao2Filtro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoEANFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoEANFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCodigoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents lblOrigemItem As System.Windows.Forms.Label
    Friend WithEvents cboOrigemItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtPesoLiquido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPesoLiquido As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoNCM As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoNCM As System.Windows.Forms.Label
    Friend WithEvents lblCodigoNCM As System.Windows.Forms.Label
    Friend WithEvents cboCodigoNCM As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarNCM As System.Windows.Forms.Button
    Friend WithEvents grpTipoItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkItemProducao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkAtivoFixo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkItemCompra As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkItemVenda As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkItemEstoque As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCodigoEAN As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItem As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoEAN As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarGrupoItem As System.Windows.Forms.Button
    Friend WithEvents lblMarcaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridLocalizacao As System.Windows.Forms.Button
    Friend WithEvents txtCodigo2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo2Filtro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo2Filtro As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGridQualidade As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridClienteVenda As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblInsumoProducao As System.Windows.Forms.Label
    Friend WithEvents cboInsumoProducao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGridBOM As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridBOM As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboMarcaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridClienteVenda As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridClienteVenda As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridLocalizacao As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridLocalizacao As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridBOM As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridQualidade As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridQualidade As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnEditarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridEmbalagem As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridEmbalagem As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridEmbalagem As System.Windows.Forms.Button
    Friend WithEvents lblControlaQualidadeFiltro As System.Windows.Forms.Label
    Friend WithEvents cboControlaQualidadeFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblInsumoProducaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboInsumoProducaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarGrupoItem As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents grpDadosGerais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label

End Class
