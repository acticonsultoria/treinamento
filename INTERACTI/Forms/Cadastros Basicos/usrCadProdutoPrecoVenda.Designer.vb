<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadProdutoPrecoVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadProdutoPrecoVenda))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdOrcamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPedidoVenda_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnEditarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtLegenda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLegenda = New System.Windows.Forms.Label()
        Me.picLegenda = New System.Windows.Forms.PictureBox()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.grbFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCotacao = New System.Windows.Forms.Label()
        Me.txtCotacao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMoedaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarRevisao = New System.Windows.Forms.Button()
        Me.lblRevisaoFiltro = New System.Windows.Forms.Label()
        Me.cboRevisaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarProdutoFiltro = New System.Windows.Forms.Button()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpDadosProdutoOrcamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCodigoOrcamento = New System.Windows.Forms.Label()
        Me.txtMarcaOrcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarcaOrcamento = New System.Windows.Forms.Label()
        Me.txtCodigo2Orcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoOrcamento = New System.Windows.Forms.Label()
        Me.lblCodigo2Orcamento = New System.Windows.Forms.Label()
        Me.txtDescricaoOrcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigoOrcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroMesesOrcamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroMesesOrcamento = New System.Windows.Forms.Label()
        Me.btnExcelGridOrcamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridOrcamento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridOrcamento = New System.Windows.Forms.Button()
        Me.grdOrcamento = New Janus.Windows.GridEX.GridEX()
        Me.txtNumeroMesesPedidoVenda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroMesesPedidoVenda = New System.Windows.Forms.Label()
        Me.btnExcelGridPedido = New System.Windows.Forms.Button()
        Me.btnAgruparGridPedido = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPedido = New System.Windows.Forms.Button()
        Me.grpDadosPedido = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCodigoPedido = New System.Windows.Forms.Label()
        Me.txtMarcaPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarcaPedido = New System.Windows.Forms.Label()
        Me.txtCodigo2Pedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoPedido = New System.Windows.Forms.Label()
        Me.lblCodigo2Pedido = New System.Windows.Forms.Label()
        Me.txtDescricaoPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigoPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grdPedidoVenda = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosProdutoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosProdutoOrcamento.SuspendLayout()
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosPedido.SuspendLayout()
        CType(Me.grdPedidoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnEditarGrid)
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.grbFiltro)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
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
        'grpLegenda
        '
        resources.ApplyResources(Me.grpLegenda, "grpLegenda")
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.txtLegenda)
        Me.grpLegenda.Controls.Add(Me.lblLegenda)
        Me.grpLegenda.Controls.Add(Me.picLegenda)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'txtLegenda
        '
        Me.txtLegenda.DecimalDigits = 2
        Me.txtLegenda.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        resources.ApplyResources(Me.txtLegenda, "txtLegenda")
        Me.txtLegenda.Name = "txtLegenda"
        Me.txtLegenda.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblLegenda
        '
        resources.ApplyResources(Me.lblLegenda, "lblLegenda")
        Me.lblLegenda.Name = "lblLegenda"
        '
        'picLegenda
        '
        Me.picLegenda.BackColor = System.Drawing.Color.Firebrick
        Me.picLegenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picLegenda, "picLegenda")
        Me.picLegenda.Name = "picLegenda"
        Me.picLegenda.TabStop = False
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
        'grbFiltro
        '
        resources.ApplyResources(Me.grbFiltro, "grbFiltro")
        Me.grbFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grbFiltro.Controls.Add(Me.lblCotacao)
        Me.grbFiltro.Controls.Add(Me.txtCotacao)
        Me.grbFiltro.Controls.Add(Me.Label1)
        Me.grbFiltro.Controls.Add(Me.cboMoedaFiltro)
        Me.grbFiltro.Controls.Add(Me.btnCadastrarRevisao)
        Me.grbFiltro.Controls.Add(Me.lblRevisaoFiltro)
        Me.grbFiltro.Controls.Add(Me.cboRevisaoFiltro)
        Me.grbFiltro.Controls.Add(Me.btnProcurarProdutoFiltro)
        Me.grbFiltro.Controls.Add(Me.btnFiltrar)
        Me.grbFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grbFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grbFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grbFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grbFiltro.Name = "grbFiltro"
        Me.grbFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grbFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grbFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblCotacao
        '
        resources.ApplyResources(Me.lblCotacao, "lblCotacao")
        Me.lblCotacao.BackColor = System.Drawing.Color.Transparent
        Me.lblCotacao.Name = "lblCotacao"
        '
        'txtCotacao
        '
        resources.ApplyResources(Me.txtCotacao, "txtCotacao")
        Me.txtCotacao.DecimalDigits = 4
        Me.txtCotacao.Name = "txtCotacao"
        Me.txtCotacao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cboMoedaFiltro
        '
        resources.ApplyResources(Me.cboMoedaFiltro, "cboMoedaFiltro")
        Me.cboMoedaFiltro.Name = "cboMoedaFiltro"
        Me.cboMoedaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'btnCadastrarRevisao
        '
        Me.btnCadastrarRevisao.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarRevisao, "btnCadastrarRevisao")
        Me.btnCadastrarRevisao.Name = "btnCadastrarRevisao"
        Me.btnCadastrarRevisao.TabStop = False
        Me.btnCadastrarRevisao.UseVisualStyleBackColor = True
        '
        'lblRevisaoFiltro
        '
        resources.ApplyResources(Me.lblRevisaoFiltro, "lblRevisaoFiltro")
        Me.lblRevisaoFiltro.Name = "lblRevisaoFiltro"
        '
        'cboRevisaoFiltro
        '
        resources.ApplyResources(Me.cboRevisaoFiltro, "cboRevisaoFiltro")
        Me.cboRevisaoFiltro.Name = "cboRevisaoFiltro"
        Me.cboRevisaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'btnProcurarProdutoFiltro
        '
        resources.ApplyResources(Me.btnProcurarProdutoFiltro, "btnProcurarProdutoFiltro")
        Me.btnProcurarProdutoFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarProdutoFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProdutoFiltro.Name = "btnProcurarProdutoFiltro"
        Me.btnProcurarProdutoFiltro.TabStop = False
        Me.btnProcurarProdutoFiltro.UseVisualStyleBackColor = True
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
        'txtProdutoFiltro
        '
        resources.ApplyResources(Me.txtProdutoFiltro, "txtProdutoFiltro")
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.MaxLength = 120
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        '
        'lblProdutoFiltro
        '
        resources.ApplyResources(Me.lblProdutoFiltro, "lblProdutoFiltro")
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
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
        'grpControl
        '
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnSair)
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
        'btnSair
        '
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        Me.grdListagem.AutoEdit = True
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
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.FrozenColumns = 4
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.GroupRowFormatStyle.ForeColor = System.Drawing.Color.SteelBlue
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpDadosProdutoOrcamento
        '
        resources.ApplyResources(Me.grpDadosProdutoOrcamento, "grpDadosProdutoOrcamento")
        Me.grpDadosProdutoOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosProdutoOrcamento.Controls.Add(Me.lblCodigoOrcamento)
        Me.grpDadosProdutoOrcamento.Controls.Add(Me.txtMarcaOrcamento)
        Me.grpDadosProdutoOrcamento.Controls.Add(Me.lblMarcaOrcamento)
        Me.grpDadosProdutoOrcamento.Controls.Add(Me.txtCodigo2Orcamento)
        Me.grpDadosProdutoOrcamento.Controls.Add(Me.lblDescricaoOrcamento)
        Me.grpDadosProdutoOrcamento.Controls.Add(Me.lblCodigo2Orcamento)
        Me.grpDadosProdutoOrcamento.Controls.Add(Me.txtDescricaoOrcamento)
        Me.grpDadosProdutoOrcamento.Controls.Add(Me.txtCodigoOrcamento)
        Me.grpDadosProdutoOrcamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosProdutoOrcamento.Name = "grpDadosProdutoOrcamento"
        Me.grpDadosProdutoOrcamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosProdutoOrcamento.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosProdutoOrcamento.VisualStyleManager = Me.vsmMain
        '
        'lblCodigoOrcamento
        '
        resources.ApplyResources(Me.lblCodigoOrcamento, "lblCodigoOrcamento")
        Me.lblCodigoOrcamento.Name = "lblCodigoOrcamento"
        '
        'txtMarcaOrcamento
        '
        resources.ApplyResources(Me.txtMarcaOrcamento, "txtMarcaOrcamento")
        Me.txtMarcaOrcamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMarcaOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaOrcamento.MaxLength = 100
        Me.txtMarcaOrcamento.Name = "txtMarcaOrcamento"
        Me.txtMarcaOrcamento.ReadOnly = True
        Me.txtMarcaOrcamento.TabStop = False
        '
        'lblMarcaOrcamento
        '
        resources.ApplyResources(Me.lblMarcaOrcamento, "lblMarcaOrcamento")
        Me.lblMarcaOrcamento.Name = "lblMarcaOrcamento"
        '
        'txtCodigo2Orcamento
        '
        Me.txtCodigo2Orcamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo2Orcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtCodigo2Orcamento, "txtCodigo2Orcamento")
        Me.txtCodigo2Orcamento.Name = "txtCodigo2Orcamento"
        Me.txtCodigo2Orcamento.ReadOnly = True
        Me.txtCodigo2Orcamento.TabStop = False
        '
        'lblDescricaoOrcamento
        '
        resources.ApplyResources(Me.lblDescricaoOrcamento, "lblDescricaoOrcamento")
        Me.lblDescricaoOrcamento.Name = "lblDescricaoOrcamento"
        '
        'lblCodigo2Orcamento
        '
        resources.ApplyResources(Me.lblCodigo2Orcamento, "lblCodigo2Orcamento")
        Me.lblCodigo2Orcamento.Name = "lblCodigo2Orcamento"
        '
        'txtDescricaoOrcamento
        '
        resources.ApplyResources(Me.txtDescricaoOrcamento, "txtDescricaoOrcamento")
        Me.txtDescricaoOrcamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoOrcamento.MaxLength = 120
        Me.txtDescricaoOrcamento.Name = "txtDescricaoOrcamento"
        Me.txtDescricaoOrcamento.ReadOnly = True
        Me.txtDescricaoOrcamento.TabStop = False
        '
        'txtCodigoOrcamento
        '
        Me.txtCodigoOrcamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtCodigoOrcamento, "txtCodigoOrcamento")
        Me.txtCodigoOrcamento.Name = "txtCodigoOrcamento"
        Me.txtCodigoOrcamento.ReadOnly = True
        Me.txtCodigoOrcamento.TabStop = False
        '
        'txtNumeroMesesOrcamento
        '
        resources.ApplyResources(Me.txtNumeroMesesOrcamento, "txtNumeroMesesOrcamento")
        Me.txtNumeroMesesOrcamento.DecimalDigits = 0
        Me.txtNumeroMesesOrcamento.MaxLength = 0
        Me.txtNumeroMesesOrcamento.Name = "txtNumeroMesesOrcamento"
        Me.txtNumeroMesesOrcamento.TabStop = False
        Me.txtNumeroMesesOrcamento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroMesesOrcamento
        '
        resources.ApplyResources(Me.lblNumeroMesesOrcamento, "lblNumeroMesesOrcamento")
        Me.lblNumeroMesesOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroMesesOrcamento.Name = "lblNumeroMesesOrcamento"
        '
        'btnExcelGridOrcamento
        '
        resources.ApplyResources(Me.btnExcelGridOrcamento, "btnExcelGridOrcamento")
        Me.btnExcelGridOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridOrcamento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridOrcamento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridOrcamento.Name = "btnExcelGridOrcamento"
        Me.btnExcelGridOrcamento.TabStop = False
        Me.btnExcelGridOrcamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridOrcamento
        '
        resources.ApplyResources(Me.btnAgruparGridOrcamento, "btnAgruparGridOrcamento")
        Me.btnAgruparGridOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridOrcamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridOrcamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridOrcamento.Name = "btnAgruparGridOrcamento"
        Me.btnAgruparGridOrcamento.TabStop = False
        Me.btnAgruparGridOrcamento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridOrcamento
        '
        resources.ApplyResources(Me.btnConfigurarGridOrcamento, "btnConfigurarGridOrcamento")
        Me.btnConfigurarGridOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridOrcamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridOrcamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridOrcamento.Name = "btnConfigurarGridOrcamento"
        Me.btnConfigurarGridOrcamento.TabStop = False
        Me.btnConfigurarGridOrcamento.UseVisualStyleBackColor = False
        '
        'grdOrcamento
        '
        Me.grdOrcamento.AlternatingColors = True
        resources.ApplyResources(Me.grdOrcamento, "grdOrcamento")
        Me.grdOrcamento.AutoEdit = True
        Me.grdOrcamento.ColumnAutoResize = True
        resources.ApplyResources(grdOrcamento_DesignTimeLayout, "grdOrcamento_DesignTimeLayout")
        Me.grdOrcamento.DesignTimeLayout = grdOrcamento_DesignTimeLayout
        Me.grdOrcamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdOrcamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdOrcamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamento.GroupByBoxVisible = False
        Me.grdOrcamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamento.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdOrcamento.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamento.Hierarchical = True
        Me.grdOrcamento.Name = "grdOrcamento"
        Me.grdOrcamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamento.RecordNavigator = True
        Me.grdOrcamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdOrcamento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamento.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdOrcamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamento.TabStop = False
        Me.grdOrcamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamento.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroMesesPedidoVenda
        '
        resources.ApplyResources(Me.txtNumeroMesesPedidoVenda, "txtNumeroMesesPedidoVenda")
        Me.txtNumeroMesesPedidoVenda.DecimalDigits = 0
        Me.txtNumeroMesesPedidoVenda.MaxLength = 0
        Me.txtNumeroMesesPedidoVenda.Name = "txtNumeroMesesPedidoVenda"
        Me.txtNumeroMesesPedidoVenda.TabStop = False
        Me.txtNumeroMesesPedidoVenda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroMesesPedidoVenda
        '
        resources.ApplyResources(Me.lblNumeroMesesPedidoVenda, "lblNumeroMesesPedidoVenda")
        Me.lblNumeroMesesPedidoVenda.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroMesesPedidoVenda.Name = "lblNumeroMesesPedidoVenda"
        '
        'btnExcelGridPedido
        '
        resources.ApplyResources(Me.btnExcelGridPedido, "btnExcelGridPedido")
        Me.btnExcelGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPedido.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPedido.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPedido.Name = "btnExcelGridPedido"
        Me.btnExcelGridPedido.TabStop = False
        Me.btnExcelGridPedido.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPedido
        '
        resources.ApplyResources(Me.btnAgruparGridPedido, "btnAgruparGridPedido")
        Me.btnAgruparGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPedido.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPedido.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPedido.Name = "btnAgruparGridPedido"
        Me.btnAgruparGridPedido.TabStop = False
        Me.btnAgruparGridPedido.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPedido
        '
        resources.ApplyResources(Me.btnConfigurarGridPedido, "btnConfigurarGridPedido")
        Me.btnConfigurarGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPedido.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPedido.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPedido.Name = "btnConfigurarGridPedido"
        Me.btnConfigurarGridPedido.TabStop = False
        Me.btnConfigurarGridPedido.UseVisualStyleBackColor = False
        '
        'grpDadosPedido
        '
        resources.ApplyResources(Me.grpDadosPedido, "grpDadosPedido")
        Me.grpDadosPedido.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosPedido.Controls.Add(Me.lblCodigoPedido)
        Me.grpDadosPedido.Controls.Add(Me.txtMarcaPedido)
        Me.grpDadosPedido.Controls.Add(Me.lblMarcaPedido)
        Me.grpDadosPedido.Controls.Add(Me.txtCodigo2Pedido)
        Me.grpDadosPedido.Controls.Add(Me.lblDescricaoPedido)
        Me.grpDadosPedido.Controls.Add(Me.lblCodigo2Pedido)
        Me.grpDadosPedido.Controls.Add(Me.txtDescricaoPedido)
        Me.grpDadosPedido.Controls.Add(Me.txtCodigoPedido)
        Me.grpDadosPedido.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosPedido.Name = "grpDadosPedido"
        Me.grpDadosPedido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosPedido.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosPedido.VisualStyleManager = Me.vsmMain
        '
        'lblCodigoPedido
        '
        resources.ApplyResources(Me.lblCodigoPedido, "lblCodigoPedido")
        Me.lblCodigoPedido.Name = "lblCodigoPedido"
        '
        'txtMarcaPedido
        '
        resources.ApplyResources(Me.txtMarcaPedido, "txtMarcaPedido")
        Me.txtMarcaPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMarcaPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaPedido.MaxLength = 100
        Me.txtMarcaPedido.Name = "txtMarcaPedido"
        Me.txtMarcaPedido.ReadOnly = True
        Me.txtMarcaPedido.TabStop = False
        '
        'lblMarcaPedido
        '
        resources.ApplyResources(Me.lblMarcaPedido, "lblMarcaPedido")
        Me.lblMarcaPedido.Name = "lblMarcaPedido"
        '
        'txtCodigo2Pedido
        '
        Me.txtCodigo2Pedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo2Pedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtCodigo2Pedido, "txtCodigo2Pedido")
        Me.txtCodigo2Pedido.Name = "txtCodigo2Pedido"
        Me.txtCodigo2Pedido.ReadOnly = True
        Me.txtCodigo2Pedido.TabStop = False
        '
        'lblDescricaoPedido
        '
        resources.ApplyResources(Me.lblDescricaoPedido, "lblDescricaoPedido")
        Me.lblDescricaoPedido.Name = "lblDescricaoPedido"
        '
        'lblCodigo2Pedido
        '
        resources.ApplyResources(Me.lblCodigo2Pedido, "lblCodigo2Pedido")
        Me.lblCodigo2Pedido.Name = "lblCodigo2Pedido"
        '
        'txtDescricaoPedido
        '
        resources.ApplyResources(Me.txtDescricaoPedido, "txtDescricaoPedido")
        Me.txtDescricaoPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoPedido.MaxLength = 120
        Me.txtDescricaoPedido.Name = "txtDescricaoPedido"
        Me.txtDescricaoPedido.ReadOnly = True
        Me.txtDescricaoPedido.TabStop = False
        '
        'txtCodigoPedido
        '
        Me.txtCodigoPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtCodigoPedido, "txtCodigoPedido")
        Me.txtCodigoPedido.Name = "txtCodigoPedido"
        Me.txtCodigoPedido.ReadOnly = True
        Me.txtCodigoPedido.TabStop = False
        '
        'grdPedidoVenda
        '
        Me.grdPedidoVenda.AlternatingColors = True
        resources.ApplyResources(Me.grdPedidoVenda, "grdPedidoVenda")
        Me.grdPedidoVenda.AutoEdit = True
        Me.grdPedidoVenda.ColumnAutoResize = True
        resources.ApplyResources(grdPedidoVenda_DesignTimeLayout, "grdPedidoVenda_DesignTimeLayout")
        Me.grdPedidoVenda.DesignTimeLayout = grdPedidoVenda_DesignTimeLayout
        Me.grdPedidoVenda.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdPedidoVenda.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedidoVenda.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedidoVenda.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedidoVenda.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedidoVenda.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedidoVenda.GroupByBoxVisible = False
        Me.grdPedidoVenda.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPedidoVenda.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdPedidoVenda.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVenda.Hierarchical = True
        Me.grdPedidoVenda.Name = "grdPedidoVenda"
        Me.grdPedidoVenda.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedidoVenda.RecordNavigator = True
        Me.grdPedidoVenda.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdPedidoVenda.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVenda.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdPedidoVenda.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPedidoVenda.TabStop = False
        Me.grdPedidoVenda.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVenda.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPedidoVenda.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedidoVenda.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedidoVenda.VisualStyleManager = Me.vsmMain
        '
        'usrCadProdutoPrecoVenda
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadProdutoPrecoVenda"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFiltro.ResumeLayout(False)
        Me.grbFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDadosProdutoOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosProdutoOrcamento.ResumeLayout(False)
        Me.grpDadosProdutoOrcamento.PerformLayout()
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDadosPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosPedido.ResumeLayout(False)
        Me.grpDadosPedido.PerformLayout()
        CType(Me.grdPedidoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grbFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiComboBox1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiComboBox2 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegenda As System.Windows.Forms.Label
    Friend WithEvents picLegenda As System.Windows.Forms.PictureBox
    Friend WithEvents txtLegenda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarProdutoFiltro As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridOrcamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridOrcamento As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridOrcamento As System.Windows.Forms.Button
    Friend WithEvents grdOrcamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblNumeroMesesOrcamento As System.Windows.Forms.Label
    Friend WithEvents txtNumeroMesesOrcamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNumeroMesesPedidoVenda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroMesesPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents btnExcelGridPedido As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPedido As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPedido As System.Windows.Forms.Button
    Friend WithEvents grdPedidoVenda As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpDadosProdutoOrcamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCodigoOrcamento As System.Windows.Forms.Label
    Friend WithEvents txtMarcaOrcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarcaOrcamento As System.Windows.Forms.Label
    Friend WithEvents txtCodigo2Orcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoOrcamento As System.Windows.Forms.Label
    Friend WithEvents lblCodigo2Orcamento As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoOrcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigoOrcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpDadosPedido As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCodigoPedido As System.Windows.Forms.Label
    Friend WithEvents txtMarcaPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarcaPedido As System.Windows.Forms.Label
    Friend WithEvents txtCodigo2Pedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoPedido As System.Windows.Forms.Label
    Friend WithEvents lblCodigo2Pedido As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigoPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRevisaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboRevisaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarRevisao As System.Windows.Forms.Button
    Friend WithEvents btnEditarGrid As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMoedaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCotacao As System.Windows.Forms.Label
    Friend WithEvents txtCotacao As Janus.Windows.GridEX.EditControls.NumericEditBox

End Class
