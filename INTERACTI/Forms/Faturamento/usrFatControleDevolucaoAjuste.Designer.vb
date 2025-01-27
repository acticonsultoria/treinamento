<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatControleDevolucaoAjuste
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatControleDevolucaoAjuste))
        Dim cboCFOPFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.txtNFRemessaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblNFRemessaFiltro = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpPedidoVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcluirProduto = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDevolucaoDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDevolucaoDescricao = New System.Windows.Forms.Label()
        Me.cboDevolucaoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDevolucaoEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDevolucaoEmissaoNota = New System.Windows.Forms.Label()
        Me.lblDevolucaoEmitente = New System.Windows.Forms.Label()
        Me.lblDevolucaoQuantidade = New System.Windows.Forms.Label()
        Me.txtDevolucaoDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDevolucaoQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDevolucaoProduto = New System.Windows.Forms.Label()
        Me.lblDevolucaoNF = New System.Windows.Forms.Label()
        Me.cboDevolucaoNF = New Janus.Windows.EditControls.UIComboBox()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.grpAlteracao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtRemessaDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRemessaDescricao = New System.Windows.Forms.Label()
        Me.lblRemessaQuantidade = New System.Windows.Forms.Label()
        Me.txtRemessaQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtRemessaProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRemessaProduto = New System.Windows.Forms.Label()
        Me.txtRemessaDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtRemessaDestinatario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRemessaDestinatario = New System.Windows.Forms.Label()
        Me.lblRemessaDataEmissao = New System.Windows.Forms.Label()
        Me.txtRemessaNF = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRemessaNF = New System.Windows.Forms.Label()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboCFOPFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblCFOPFiltro = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPedidoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPedidoVenda.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpAlteracao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAlteracao.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
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
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpPedidoVenda)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Devolução"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNFRemessaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblNFRemessaFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(3, 4)
        Me.grpFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(907, 105)
        Me.grpFiltro.TabIndex = 37
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(329, 34)
        Me.txtFornecedorFiltro.MaxLength = 20
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(365, 20)
        Me.txtFornecedorFiltro.TabIndex = 33
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(326, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 32
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(101, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 28
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(215, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 29
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(98, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 27
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'txtNFRemessaFiltro
        '
        Me.txtNFRemessaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNFRemessaFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNFRemessaFiltro.MaxLength = 20
        Me.txtNFRemessaFiltro.Name = "txtNFRemessaFiltro"
        Me.txtNFRemessaFiltro.Size = New System.Drawing.Size(86, 20)
        Me.txtNFRemessaFiltro.TabIndex = 26
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(802, 72)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 23
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblNFRemessaFiltro
        '
        Me.lblNFRemessaFiltro.AutoSize = True
        Me.lblNFRemessaFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNFRemessaFiltro.Name = "lblNFRemessaFiltro"
        Me.lblNFRemessaFiltro.Size = New System.Drawing.Size(71, 14)
        Me.lblNFRemessaFiltro.TabIndex = 0
        Me.lblNFRemessaFiltro.Text = "NF Remessa:"
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 8
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(3, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(907, 362)
        Me.grdListagem.TabIndex = 38
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpPedidoVenda
        '
        Me.grpPedidoVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPedidoVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpPedidoVenda.Controls.Add(Me.btnSair)
        Me.grpPedidoVenda.Location = New System.Drawing.Point(2, 483)
        Me.grpPedidoVenda.Name = "grpPedidoVenda"
        Me.grpPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPedidoVenda.Size = New System.Drawing.Size(903, 51)
        Me.grpPedidoVenda.TabIndex = 5
        Me.grpPedidoVenda.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpPedidoVenda.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(803, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcluirProduto)
        Me.pagDados.Controls.Add(Me.UiGroupBox2)
        Me.pagDados.Controls.Add(Me.btnInserirProduto)
        Me.pagDados.Controls.Add(Me.grdProduto)
        Me.pagDados.Controls.Add(Me.grpAlteracao)
        Me.pagDados.Controls.Add(Me.UiGroupBox1)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Alteração"
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirProduto.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirProduto.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirProduto.Location = New System.Drawing.Point(722, 223)
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirProduto.TabIndex = 61
        Me.btnExcluirProduto.Text = "Excluir"
        Me.btnExcluirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.txtDevolucaoDescricao)
        Me.UiGroupBox2.Controls.Add(Me.lblDevolucaoDescricao)
        Me.UiGroupBox2.Controls.Add(Me.cboDevolucaoProduto)
        Me.UiGroupBox2.Controls.Add(Me.txtDevolucaoEmitente)
        Me.UiGroupBox2.Controls.Add(Me.lblDevolucaoEmissaoNota)
        Me.UiGroupBox2.Controls.Add(Me.lblDevolucaoEmitente)
        Me.UiGroupBox2.Controls.Add(Me.lblDevolucaoQuantidade)
        Me.UiGroupBox2.Controls.Add(Me.txtDevolucaoDataEmissao)
        Me.UiGroupBox2.Controls.Add(Me.txtDevolucaoQuantidade)
        Me.UiGroupBox2.Controls.Add(Me.lblDevolucaoProduto)
        Me.UiGroupBox2.Controls.Add(Me.lblDevolucaoNF)
        Me.UiGroupBox2.Controls.Add(Me.cboDevolucaoNF)
        Me.UiGroupBox2.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox2.Location = New System.Drawing.Point(2, 114)
        Me.UiGroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(907, 102)
        Me.UiGroupBox2.TabIndex = 42
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'txtDevolucaoDescricao
        '
        Me.txtDevolucaoDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDevolucaoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDevolucaoDescricao.Location = New System.Drawing.Point(194, 75)
        Me.txtDevolucaoDescricao.MaxLength = 20
        Me.txtDevolucaoDescricao.Name = "txtDevolucaoDescricao"
        Me.txtDevolucaoDescricao.ReadOnly = True
        Me.txtDevolucaoDescricao.Size = New System.Drawing.Size(637, 20)
        Me.txtDevolucaoDescricao.TabIndex = 64
        Me.txtDevolucaoDescricao.TabStop = False
        '
        'lblDevolucaoDescricao
        '
        Me.lblDevolucaoDescricao.AutoSize = True
        Me.lblDevolucaoDescricao.Location = New System.Drawing.Point(191, 58)
        Me.lblDevolucaoDescricao.Name = "lblDevolucaoDescricao"
        Me.lblDevolucaoDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDevolucaoDescricao.TabIndex = 63
        Me.lblDevolucaoDescricao.Text = "Descrição:"
        '
        'cboDevolucaoProduto
        '
        Me.cboDevolucaoProduto.AutoSize = False
        Me.cboDevolucaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDevolucaoProduto.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cboDevolucaoProduto.Location = New System.Drawing.Point(10, 75)
        Me.cboDevolucaoProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDevolucaoProduto.Name = "cboDevolucaoProduto"
        Me.cboDevolucaoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDevolucaoProduto.Size = New System.Drawing.Size(178, 20)
        Me.cboDevolucaoProduto.TabIndex = 62
        '
        'txtDevolucaoEmitente
        '
        Me.txtDevolucaoEmitente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDevolucaoEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDevolucaoEmitente.Location = New System.Drawing.Point(194, 35)
        Me.txtDevolucaoEmitente.MaxLength = 20
        Me.txtDevolucaoEmitente.Name = "txtDevolucaoEmitente"
        Me.txtDevolucaoEmitente.ReadOnly = True
        Me.txtDevolucaoEmitente.Size = New System.Drawing.Size(705, 20)
        Me.txtDevolucaoEmitente.TabIndex = 41
        Me.txtDevolucaoEmitente.TabStop = False
        '
        'lblDevolucaoEmissaoNota
        '
        Me.lblDevolucaoEmissaoNota.AutoSize = True
        Me.lblDevolucaoEmissaoNota.Location = New System.Drawing.Point(99, 18)
        Me.lblDevolucaoEmissaoNota.Name = "lblDevolucaoEmissaoNota"
        Me.lblDevolucaoEmissaoNota.Size = New System.Drawing.Size(75, 14)
        Me.lblDevolucaoEmissaoNota.TabIndex = 39
        Me.lblDevolucaoEmissaoNota.Text = "Data Emissão:"
        '
        'lblDevolucaoEmitente
        '
        Me.lblDevolucaoEmitente.AutoSize = True
        Me.lblDevolucaoEmitente.Location = New System.Drawing.Point(191, 18)
        Me.lblDevolucaoEmitente.Name = "lblDevolucaoEmitente"
        Me.lblDevolucaoEmitente.Size = New System.Drawing.Size(50, 14)
        Me.lblDevolucaoEmitente.TabIndex = 40
        Me.lblDevolucaoEmitente.Text = "Emitente:"
        '
        'lblDevolucaoQuantidade
        '
        Me.lblDevolucaoQuantidade.AutoSize = True
        Me.lblDevolucaoQuantidade.Location = New System.Drawing.Point(834, 58)
        Me.lblDevolucaoQuantidade.Name = "lblDevolucaoQuantidade"
        Me.lblDevolucaoQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblDevolucaoQuantidade.TabIndex = 50
        Me.lblDevolucaoQuantidade.Text = "Quantidade:"
        '
        'txtDevolucaoDataEmissao
        '
        Me.txtDevolucaoDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDevolucaoDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDevolucaoDataEmissao.Location = New System.Drawing.Point(102, 35)
        Me.txtDevolucaoDataEmissao.MaxLength = 20
        Me.txtDevolucaoDataEmissao.Name = "txtDevolucaoDataEmissao"
        Me.txtDevolucaoDataEmissao.ReadOnly = True
        Me.txtDevolucaoDataEmissao.Size = New System.Drawing.Size(86, 20)
        Me.txtDevolucaoDataEmissao.TabIndex = 42
        Me.txtDevolucaoDataEmissao.TabStop = False
        '
        'txtDevolucaoQuantidade
        '
        Me.txtDevolucaoQuantidade.BackColor = System.Drawing.Color.White
        Me.txtDevolucaoQuantidade.Location = New System.Drawing.Point(837, 75)
        Me.txtDevolucaoQuantidade.Name = "txtDevolucaoQuantidade"
        Me.txtDevolucaoQuantidade.Size = New System.Drawing.Size(62, 20)
        Me.txtDevolucaoQuantidade.TabIndex = 49
        Me.txtDevolucaoQuantidade.Text = "0,00"
        Me.txtDevolucaoQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDevolucaoProduto
        '
        Me.lblDevolucaoProduto.AutoSize = True
        Me.lblDevolucaoProduto.Location = New System.Drawing.Point(7, 58)
        Me.lblDevolucaoProduto.Name = "lblDevolucaoProduto"
        Me.lblDevolucaoProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblDevolucaoProduto.TabIndex = 43
        Me.lblDevolucaoProduto.Text = "Produto:"
        '
        'lblDevolucaoNF
        '
        Me.lblDevolucaoNF.AutoSize = True
        Me.lblDevolucaoNF.Location = New System.Drawing.Point(7, 19)
        Me.lblDevolucaoNF.Name = "lblDevolucaoNF"
        Me.lblDevolucaoNF.Size = New System.Drawing.Size(77, 14)
        Me.lblDevolucaoNF.TabIndex = 45
        Me.lblDevolucaoNF.Text = "NF Devolução:"
        '
        'cboDevolucaoNF
        '
        Me.cboDevolucaoNF.AutoSize = False
        Me.cboDevolucaoNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDevolucaoNF.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cboDevolucaoNF.Location = New System.Drawing.Point(10, 36)
        Me.cboDevolucaoNF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDevolucaoNF.Name = "cboDevolucaoNF"
        Me.cboDevolucaoNF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDevolucaoNF.Size = New System.Drawing.Size(86, 20)
        Me.cboDevolucaoNF.TabIndex = 46
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirProduto.Image = CType(resources.GetObject("btnInserirProduto.Image"), System.Drawing.Image)
        Me.btnInserirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirProduto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirProduto.Location = New System.Drawing.Point(819, 223)
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirProduto.TabIndex = 60
        Me.btnInserirProduto.Text = "Inserir"
        Me.btnInserirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdProduto
        '
        Me.grdProduto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.AutoEdit = True
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.FrozenColumns = 2
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.Location = New System.Drawing.Point(3, 252)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(907, 229)
        Me.grdProduto.TabIndex = 41
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdProduto.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdProduto.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'grpAlteracao
        '
        Me.grpAlteracao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAlteracao.BackColor = System.Drawing.Color.Transparent
        Me.grpAlteracao.Controls.Add(Me.txtRemessaDescricao)
        Me.grpAlteracao.Controls.Add(Me.lblRemessaDescricao)
        Me.grpAlteracao.Controls.Add(Me.lblRemessaQuantidade)
        Me.grpAlteracao.Controls.Add(Me.txtRemessaQuantidade)
        Me.grpAlteracao.Controls.Add(Me.txtRemessaProduto)
        Me.grpAlteracao.Controls.Add(Me.lblRemessaProduto)
        Me.grpAlteracao.Controls.Add(Me.txtRemessaDataEmissao)
        Me.grpAlteracao.Controls.Add(Me.txtRemessaDestinatario)
        Me.grpAlteracao.Controls.Add(Me.lblRemessaDestinatario)
        Me.grpAlteracao.Controls.Add(Me.lblRemessaDataEmissao)
        Me.grpAlteracao.Controls.Add(Me.txtRemessaNF)
        Me.grpAlteracao.Controls.Add(Me.lblRemessaNF)
        Me.grpAlteracao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpAlteracao.Location = New System.Drawing.Point(3, 4)
        Me.grpAlteracao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAlteracao.Name = "grpAlteracao"
        Me.grpAlteracao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAlteracao.Size = New System.Drawing.Size(907, 102)
        Me.grpAlteracao.TabIndex = 40
        Me.grpAlteracao.VisualStyleManager = Me.vsmMain
        '
        'txtRemessaDescricao
        '
        Me.txtRemessaDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRemessaDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemessaDescricao.Location = New System.Drawing.Point(193, 76)
        Me.txtRemessaDescricao.MaxLength = 20
        Me.txtRemessaDescricao.Name = "txtRemessaDescricao"
        Me.txtRemessaDescricao.ReadOnly = True
        Me.txtRemessaDescricao.Size = New System.Drawing.Size(637, 20)
        Me.txtRemessaDescricao.TabIndex = 50
        Me.txtRemessaDescricao.TabStop = False
        '
        'lblRemessaDescricao
        '
        Me.lblRemessaDescricao.AutoSize = True
        Me.lblRemessaDescricao.Location = New System.Drawing.Point(190, 59)
        Me.lblRemessaDescricao.Name = "lblRemessaDescricao"
        Me.lblRemessaDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblRemessaDescricao.TabIndex = 49
        Me.lblRemessaDescricao.Text = "Descrição:"
        '
        'lblRemessaQuantidade
        '
        Me.lblRemessaQuantidade.AutoSize = True
        Me.lblRemessaQuantidade.Location = New System.Drawing.Point(833, 59)
        Me.lblRemessaQuantidade.Name = "lblRemessaQuantidade"
        Me.lblRemessaQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblRemessaQuantidade.TabIndex = 48
        Me.lblRemessaQuantidade.Text = "Quantidade:"
        '
        'txtRemessaQuantidade
        '
        Me.txtRemessaQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRemessaQuantidade.Location = New System.Drawing.Point(836, 76)
        Me.txtRemessaQuantidade.Name = "txtRemessaQuantidade"
        Me.txtRemessaQuantidade.ReadOnly = True
        Me.txtRemessaQuantidade.Size = New System.Drawing.Size(62, 20)
        Me.txtRemessaQuantidade.TabIndex = 47
        Me.txtRemessaQuantidade.TabStop = False
        Me.txtRemessaQuantidade.Text = "0,00"
        Me.txtRemessaQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtRemessaProduto
        '
        Me.txtRemessaProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRemessaProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemessaProduto.Location = New System.Drawing.Point(9, 76)
        Me.txtRemessaProduto.MaxLength = 20
        Me.txtRemessaProduto.Name = "txtRemessaProduto"
        Me.txtRemessaProduto.ReadOnly = True
        Me.txtRemessaProduto.Size = New System.Drawing.Size(178, 20)
        Me.txtRemessaProduto.TabIndex = 36
        Me.txtRemessaProduto.TabStop = False
        '
        'lblRemessaProduto
        '
        Me.lblRemessaProduto.AutoSize = True
        Me.lblRemessaProduto.Location = New System.Drawing.Point(6, 59)
        Me.lblRemessaProduto.Name = "lblRemessaProduto"
        Me.lblRemessaProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblRemessaProduto.TabIndex = 35
        Me.lblRemessaProduto.Text = "Produto:"
        '
        'txtRemessaDataEmissao
        '
        Me.txtRemessaDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRemessaDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemessaDataEmissao.Location = New System.Drawing.Point(101, 34)
        Me.txtRemessaDataEmissao.MaxLength = 20
        Me.txtRemessaDataEmissao.Name = "txtRemessaDataEmissao"
        Me.txtRemessaDataEmissao.ReadOnly = True
        Me.txtRemessaDataEmissao.Size = New System.Drawing.Size(86, 20)
        Me.txtRemessaDataEmissao.TabIndex = 34
        Me.txtRemessaDataEmissao.TabStop = False
        '
        'txtRemessaDestinatario
        '
        Me.txtRemessaDestinatario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRemessaDestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemessaDestinatario.Location = New System.Drawing.Point(193, 34)
        Me.txtRemessaDestinatario.MaxLength = 20
        Me.txtRemessaDestinatario.Name = "txtRemessaDestinatario"
        Me.txtRemessaDestinatario.ReadOnly = True
        Me.txtRemessaDestinatario.Size = New System.Drawing.Size(705, 20)
        Me.txtRemessaDestinatario.TabIndex = 33
        Me.txtRemessaDestinatario.TabStop = False
        '
        'lblRemessaDestinatario
        '
        Me.lblRemessaDestinatario.AutoSize = True
        Me.lblRemessaDestinatario.Location = New System.Drawing.Point(190, 17)
        Me.lblRemessaDestinatario.Name = "lblRemessaDestinatario"
        Me.lblRemessaDestinatario.Size = New System.Drawing.Size(67, 14)
        Me.lblRemessaDestinatario.TabIndex = 32
        Me.lblRemessaDestinatario.Text = "Destinatário:"
        '
        'lblRemessaDataEmissao
        '
        Me.lblRemessaDataEmissao.AutoSize = True
        Me.lblRemessaDataEmissao.Location = New System.Drawing.Point(98, 17)
        Me.lblRemessaDataEmissao.Name = "lblRemessaDataEmissao"
        Me.lblRemessaDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblRemessaDataEmissao.TabIndex = 27
        Me.lblRemessaDataEmissao.Text = "Data Emissão:"
        '
        'txtRemessaNF
        '
        Me.txtRemessaNF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRemessaNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemessaNF.Location = New System.Drawing.Point(9, 34)
        Me.txtRemessaNF.MaxLength = 20
        Me.txtRemessaNF.Name = "txtRemessaNF"
        Me.txtRemessaNF.ReadOnly = True
        Me.txtRemessaNF.Size = New System.Drawing.Size(86, 20)
        Me.txtRemessaNF.TabIndex = 26
        Me.txtRemessaNF.TabStop = False
        '
        'lblRemessaNF
        '
        Me.lblRemessaNF.AutoSize = True
        Me.lblRemessaNF.Location = New System.Drawing.Point(6, 17)
        Me.lblRemessaNF.Name = "lblRemessaNF"
        Me.lblRemessaNF.Size = New System.Drawing.Size(71, 14)
        Me.lblRemessaNF.TabIndex = 0
        Me.lblRemessaNF.Text = "NF Remessa:"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnVoltar)
        Me.UiGroupBox1.Location = New System.Drawing.Point(3, 487)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(907, 51)
        Me.UiGroupBox1.TabIndex = 6
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(807, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 4
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 75)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(200, 20)
        Me.cboStatusFiltro.TabIndex = 40
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 39
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboCFOPFiltro
        '
        Me.cboCFOPFiltro.AllowDrop = True
        Me.cboCFOPFiltro.ButtonCancelText = "Cancelar"
        Me.cboCFOPFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboCFOPFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboCFOPFiltro_DesignTimeLayout.LayoutString")
        Me.cboCFOPFiltro.DesignTimeLayout = cboCFOPFiltro_DesignTimeLayout
        Me.cboCFOPFiltro.Location = New System.Drawing.Point(700, 34)
        Me.cboCFOPFiltro.Name = "cboCFOPFiltro"
        Me.cboCFOPFiltro.SaveSettings = False
        Me.cboCFOPFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboCFOPFiltro.Size = New System.Drawing.Size(91, 20)
        Me.cboCFOPFiltro.TabIndex = 38
        Me.cboCFOPFiltro.ValuesDataMember = Nothing
        '
        'lblCFOPFiltro
        '
        Me.lblCFOPFiltro.AutoSize = True
        Me.lblCFOPFiltro.Location = New System.Drawing.Point(697, 17)
        Me.lblCFOPFiltro.Name = "lblCFOPFiltro"
        Me.lblCFOPFiltro.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOPFiltro.TabIndex = 37
        Me.lblCFOPFiltro.Text = "CFOP:"
        '
        'usrFatControleDevolucaoAjuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatControleDevolucaoAjuste"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPedidoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPedidoVenda.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpAlteracao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAlteracao.ResumeLayout(False)
        Me.grpAlteracao.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpPedidoVenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNFRemessaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNFRemessaFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpAlteracao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtRemessaDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtRemessaDestinatario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRemessaDestinatario As System.Windows.Forms.Label
    Friend WithEvents lblRemessaDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtRemessaNF As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRemessaNF As System.Windows.Forms.Label
    Friend WithEvents lblDevolucaoProduto As System.Windows.Forms.Label
    Friend WithEvents txtDevolucaoDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDevolucaoEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDevolucaoEmitente As System.Windows.Forms.Label
    Friend WithEvents lblDevolucaoEmissaoNota As System.Windows.Forms.Label
    Friend WithEvents txtRemessaProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRemessaProduto As System.Windows.Forms.Label
    Friend WithEvents cboDevolucaoNF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDevolucaoNF As System.Windows.Forms.Label
    Friend WithEvents lblRemessaQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtRemessaQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDevolucaoQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtDevolucaoQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnExcluirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboDevolucaoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDevolucaoDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDevolucaoDescricao As System.Windows.Forms.Label
    Friend WithEvents txtRemessaDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRemessaDescricao As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCFOPFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblCFOPFiltro As System.Windows.Forms.Label

End Class
