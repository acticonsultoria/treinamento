<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmpRequisicaoAutomatica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpRequisicaoAutomatica))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpDadosRequisicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAprovador = New System.Windows.Forms.Label()
        Me.cboAprovador = New Janus.Windows.EditControls.UIComboBox()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPnTopoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPnTopoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroPedidoVendaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoVendaFiltro = New System.Windows.Forms.Label()
        Me.chkSomentePendentes = New Janus.Windows.EditControls.UICheckBox()
        Me.chkConsiderarItemCompra = New Janus.Windows.EditControls.UICheckBox()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboFormaAnaliseFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFormaAnaliseFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnGerarRequisicaoGlobal = New Janus.Windows.EditControls.UIButton()
        Me.btnGerarRequisicaoUnitaria = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpDadosRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosRequisicao.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.grpDadosRequisicao)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Requisição de Compra - Sob Demanda"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 396)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 4
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 396)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpDadosRequisicao
        '
        Me.grpDadosRequisicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosRequisicao.Controls.Add(Me.lblAprovador)
        Me.grpDadosRequisicao.Controls.Add(Me.cboAprovador)
        Me.grpDadosRequisicao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosRequisicao.Location = New System.Drawing.Point(8, 416)
        Me.grpDadosRequisicao.Name = "grpDadosRequisicao"
        Me.grpDadosRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosRequisicao.Size = New System.Drawing.Size(897, 64)
        Me.grpDadosRequisicao.TabIndex = 5
        Me.grpDadosRequisicao.Text = "Dados da Requisição"
        Me.grpDadosRequisicao.VisualStyleManager = Me.vsmMain
        '
        'lblAprovador
        '
        Me.lblAprovador.AutoSize = True
        Me.lblAprovador.Location = New System.Drawing.Point(6, 17)
        Me.lblAprovador.Name = "lblAprovador"
        Me.lblAprovador.Size = New System.Drawing.Size(62, 14)
        Me.lblAprovador.TabIndex = 0
        Me.lblAprovador.Text = "Aprovador:"
        '
        'cboAprovador
        '
        Me.cboAprovador.AutoSize = False
        Me.cboAprovador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAprovador.Location = New System.Drawing.Point(9, 34)
        Me.cboAprovador.Name = "cboAprovador"
        Me.cboAprovador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAprovador.Size = New System.Drawing.Size(440, 20)
        Me.cboAprovador.TabIndex = 1
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 396)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 112)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 301)
        Me.grdListagem.TabIndex = 1
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
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtPnTopoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPnTopoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.chkSomentePendentes)
        Me.grpFiltro.Controls.Add(Me.chkConsiderarItemCompra)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboFormaAnaliseFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFormaAnaliseFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 103)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtPnTopoFiltro
        '
        Me.txtPnTopoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPnTopoFiltro.Location = New System.Drawing.Point(506, 74)
        Me.txtPnTopoFiltro.MaxLength = 60
        Me.txtPnTopoFiltro.Name = "txtPnTopoFiltro"
        Me.txtPnTopoFiltro.Size = New System.Drawing.Size(112, 20)
        Me.txtPnTopoFiltro.TabIndex = 13
        '
        'lblPnTopoFiltro
        '
        Me.lblPnTopoFiltro.AutoSize = True
        Me.lblPnTopoFiltro.Location = New System.Drawing.Point(503, 57)
        Me.lblPnTopoFiltro.Name = "lblPnTopoFiltro"
        Me.lblPnTopoFiltro.Size = New System.Drawing.Size(84, 14)
        Me.lblPnTopoFiltro.TabIndex = 12
        Me.lblPnTopoFiltro.Text = "Código Pn Topo:"
        '
        'txtNumeroPedidoVendaFiltro
        '
        Me.txtNumeroPedidoVendaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoVendaFiltro.Location = New System.Drawing.Point(506, 34)
        Me.txtNumeroPedidoVendaFiltro.MaxLength = 60
        Me.txtNumeroPedidoVendaFiltro.Name = "txtNumeroPedidoVendaFiltro"
        Me.txtNumeroPedidoVendaFiltro.Size = New System.Drawing.Size(112, 20)
        Me.txtNumeroPedidoVendaFiltro.TabIndex = 5
        '
        'lblNumeroPedidoVendaFiltro
        '
        Me.lblNumeroPedidoVendaFiltro.AutoSize = True
        Me.lblNumeroPedidoVendaFiltro.Location = New System.Drawing.Point(503, 17)
        Me.lblNumeroPedidoVendaFiltro.Name = "lblNumeroPedidoVendaFiltro"
        Me.lblNumeroPedidoVendaFiltro.Size = New System.Drawing.Size(105, 14)
        Me.lblNumeroPedidoVendaFiltro.TabIndex = 4
        Me.lblNumeroPedidoVendaFiltro.Text = "N° Pedido de Venda:"
        '
        'chkSomentePendentes
        '
        Me.chkSomentePendentes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSomentePendentes.Location = New System.Drawing.Point(741, 36)
        Me.chkSomentePendentes.Name = "chkSomentePendentes"
        Me.chkSomentePendentes.Size = New System.Drawing.Size(150, 18)
        Me.chkSomentePendentes.TabIndex = 15
        Me.chkSomentePendentes.TabStop = False
        Me.chkSomentePendentes.Text = "Somente Pendentes"
        '
        'chkConsiderarItemCompra
        '
        Me.chkConsiderarItemCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkConsiderarItemCompra.Location = New System.Drawing.Point(741, 17)
        Me.chkConsiderarItemCompra.Name = "chkConsiderarItemCompra"
        Me.chkConsiderarItemCompra.Size = New System.Drawing.Size(150, 18)
        Me.chkConsiderarItemCompra.TabIndex = 14
        Me.chkConsiderarItemCompra.TabStop = False
        Me.chkConsiderarItemCompra.Text = "Considerar Item de Compra"
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblGrupoItemFiltro.TabIndex = 0
        Me.lblGrupoItemFiltro.Text = "Grupo de Item:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.AutoSize = False
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(246, 20)
        Me.cboGrupoItemFiltro.TabIndex = 1
        '
        'cboFormaAnaliseFiltro
        '
        Me.cboFormaAnaliseFiltro.AutoSize = False
        Me.cboFormaAnaliseFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaAnaliseFiltro.Location = New System.Drawing.Point(261, 34)
        Me.cboFormaAnaliseFiltro.Name = "cboFormaAnaliseFiltro"
        Me.cboFormaAnaliseFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaAnaliseFiltro.Size = New System.Drawing.Size(239, 20)
        Me.cboFormaAnaliseFiltro.TabIndex = 3
        '
        'lblFormaAnaliseFiltro
        '
        Me.lblFormaAnaliseFiltro.AutoSize = True
        Me.lblFormaAnaliseFiltro.Location = New System.Drawing.Point(258, 17)
        Me.lblFormaAnaliseFiltro.Name = "lblFormaAnaliseFiltro"
        Me.lblFormaAnaliseFiltro.Size = New System.Drawing.Size(93, 14)
        Me.lblFormaAnaliseFiltro.TabIndex = 2
        Me.lblFormaAnaliseFiltro.Text = "Forma de Análise:"
        '
        'txtCodigoProdutoFiltro
        '
        Me.txtCodigoProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtCodigoProdutoFiltro.MaxLength = 60
        Me.txtCodigoProdutoFiltro.Name = "txtCodigoProdutoFiltro"
        Me.txtCodigoProdutoFiltro.Size = New System.Drawing.Size(150, 20)
        Me.txtCodigoProdutoFiltro.TabIndex = 7
        '
        'lblCodigoProdutoFiltro
        '
        Me.lblCodigoProdutoFiltro.AutoSize = True
        Me.lblCodigoProdutoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblCodigoProdutoFiltro.Name = "lblCodigoProdutoFiltro"
        Me.lblCodigoProdutoFiltro.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProdutoFiltro.TabIndex = 6
        Me.lblCodigoProdutoFiltro.Text = "Código Produto:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 16
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(162, 57)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 8
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(165, 74)
        Me.txtDescricaoFiltro.MaxLength = 120
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(335, 20)
        Me.txtDescricaoFiltro.TabIndex = 9
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnGerarRequisicaoGlobal)
        Me.grpControle.Controls.Add(Me.btnGerarRequisicaoUnitaria)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 6
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnGerarRequisicaoGlobal
        '
        Me.btnGerarRequisicaoGlobal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarRequisicaoGlobal.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnGerarRequisicaoGlobal.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarRequisicaoGlobal.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnGerarRequisicaoGlobal.Location = New System.Drawing.Point(145, 17)
        Me.btnGerarRequisicaoGlobal.Name = "btnGerarRequisicaoGlobal"
        Me.btnGerarRequisicaoGlobal.Size = New System.Drawing.Size(320, 23)
        Me.btnGerarRequisicaoGlobal.TabIndex = 0
        Me.btnGerarRequisicaoGlobal.Text = "Gerar uma Única Requisição para Produtos Selecionados"
        Me.btnGerarRequisicaoGlobal.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnGerarRequisicaoUnitaria
        '
        Me.btnGerarRequisicaoUnitaria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarRequisicaoUnitaria.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnGerarRequisicaoUnitaria.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarRequisicaoUnitaria.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnGerarRequisicaoUnitaria.Location = New System.Drawing.Point(471, 17)
        Me.btnGerarRequisicaoUnitaria.Name = "btnGerarRequisicaoUnitaria"
        Me.btnGerarRequisicaoUnitaria.Size = New System.Drawing.Size(320, 23)
        Me.btnGerarRequisicaoUnitaria.TabIndex = 1
        Me.btnGerarRequisicaoUnitaria.Text = "Gerar uma Requisição para cada Produto Selecionado"
        Me.btnGerarRequisicaoUnitaria.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrCmpRequisicaoAutomatica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpRequisicaoAutomatica"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpDadosRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosRequisicao.ResumeLayout(False)
        Me.grpDadosRequisicao.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtCodigoProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboFormaAnaliseFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFormaAnaliseFiltro As System.Windows.Forms.Label
    Friend WithEvents btnGerarRequisicaoUnitaria As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnGerarRequisicaoGlobal As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosRequisicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAprovador As System.Windows.Forms.Label
    Friend WithEvents cboAprovador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents chkConsiderarItemCompra As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSomentePendentes As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtNumeroPedidoVendaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoVendaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtPnTopoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPnTopoFiltro As System.Windows.Forms.Label

End Class
