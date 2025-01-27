<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrFatVinculoMaterialTerceiro
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatVinculoMaterialTerceiro))
        Dim grdVinculos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdVinculos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdVinculos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.txtNFEntradaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNFEntradaFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntradaFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.txtCFOP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDataEntradaNF = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEntradaNF = New System.Windows.Forms.Label()
        Me.txtFornecedor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.txtCodigoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDescricaoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoProduto = New System.Windows.Forms.Label()
        Me.txtNFEntrada = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNFEntrada = New System.Windows.Forms.Label()
        Me.grdVinculos = New Janus.Windows.GridEX.GridEX()
        Me.grpVinculo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRequisisaoEstoqueVinculo = New System.Windows.Forms.Label()
        Me.cboRequisisaoEstoqueVinculo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrdemProducaoVinculo = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaVinculo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaVinculo = New System.Windows.Forms.Label()
        Me.lblQuantidadeVinculo = New System.Windows.Forms.Label()
        Me.txtQuantidadeVinculo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboOrdemProducaoVinculo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnLimparVinculo = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirVinculo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirVinculo = New Janus.Windows.EditControls.UIButton()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.lblLegendaVinculado = New System.Windows.Forms.Label()
        Me.picLegendaVinculado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaSemVinculo = New System.Windows.Forms.Label()
        Me.picLegendaSemVinculo = New System.Windows.Forms.PictureBox()
        Me.lblLegendaParcialmenteVinculado = New System.Windows.Forms.Label()
        Me.picLegendaParcialmenteVinculado = New System.Windows.Forms.PictureBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grdVinculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpVinculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVinculo.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
        CType(Me.picLegendaVinculado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaSemVinculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaParcialmenteVinculado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Vínculo Material de Terceiros"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNFEntradaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNFEntradaFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEntradaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 69)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(315, 34)
        Me.txtFornecedorFiltro.MaxLength = 20
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(365, 20)
        Me.txtFornecedorFiltro.TabIndex = 37
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(312, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 36
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'txtNFEntradaFiltro
        '
        Me.txtNFEntradaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNFEntradaFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNFEntradaFiltro.MaxLength = 20
        Me.txtNFEntradaFiltro.Name = "txtNFEntradaFiltro"
        Me.txtNFEntradaFiltro.Size = New System.Drawing.Size(86, 20)
        Me.txtNFEntradaFiltro.TabIndex = 33
        '
        'lblNFEntradaFiltro
        '
        Me.lblNFEntradaFiltro.AutoSize = True
        Me.lblNFEntradaFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNFEntradaFiltro.Name = "lblNFEntradaFiltro"
        Me.lblNFEntradaFiltro.Size = New System.Drawing.Size(78, 14)
        Me.lblNFEntradaFiltro.TabIndex = 32
        Me.lblNFEntradaFiltro.Text = "NF de Entrada:"
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(101, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(101, 20)
        Me.dtpDataInicioFiltro.TabIndex = 0
        Me.dtpDataInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(208, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(101, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 1
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntradaFiltro
        '
        Me.lblDataEntradaFiltro.AutoSize = True
        Me.lblDataEntradaFiltro.Location = New System.Drawing.Point(98, 17)
        Me.lblDataEntradaFiltro.Name = "lblDataEntradaFiltro"
        Me.lblDataEntradaFiltro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaFiltro.TabIndex = 22
        Me.lblDataEntradaFiltro.Text = "Data Entrada:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'vsmMain
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme1)
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.lblLegendaVinculado)
        Me.grpControle.Controls.Add(Me.picLegendaVinculado)
        Me.grpControle.Controls.Add(Me.lblLegendaSemVinculo)
        Me.grpControle.Controls.Add(Me.picLegendaSemVinculo)
        Me.grpControle.Controls.Add(Me.lblLegendaParcialmenteVinculado)
        Me.grpControle.Controls.Add(Me.picLegendaParcialmenteVinculado)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 1
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 3
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 78)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 399)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grdVinculos)
        Me.pagDados.Controls.Add(Me.grpVinculo)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Vínculo Material de Terceiros"
        '
        'grpDados
        '
        Me.grpDados.AccessibleDescription = "lblDataEntradaNF"
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.cboUnidadeMedida)
        Me.grpDados.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDados.Controls.Add(Me.lblCFOP)
        Me.grpDados.Controls.Add(Me.txtCFOP)
        Me.grpDados.Controls.Add(Me.txtDataEntradaNF)
        Me.grpDados.Controls.Add(Me.lblDataEntradaNF)
        Me.grpDados.Controls.Add(Me.txtFornecedor)
        Me.grpDados.Controls.Add(Me.lblFornecedor)
        Me.grpDados.Controls.Add(Me.txtCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblQuantidade)
        Me.grpDados.Controls.Add(Me.txtQuantidade)
        Me.grpDados.Controls.Add(Me.txtDescricaoProduto)
        Me.grpDados.Controls.Add(Me.lblDescricaoProduto)
        Me.grpDados.Controls.Add(Me.txtNFEntrada)
        Me.grpDados.Controls.Add(Me.lblNFEntrada)
        Me.grpDados.Location = New System.Drawing.Point(9, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(896, 105)
        Me.grpDados.TabIndex = 6
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(678, 74)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.ReadOnly = True
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(87, 20)
        Me.cboUnidadeMedida.TabIndex = 71
        Me.cboUnidadeMedida.Tag = ""
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(675, 58)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(71, 14)
        Me.lblUnidadeMedida.TabIndex = 72
        Me.lblUnidadeMedida.Tag = ""
        Me.lblUnidadeMedida.Text = "Unid. Medida:"
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.Location = New System.Drawing.Point(559, 17)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 70
        Me.lblCFOP.Text = "CFOP:"
        '
        'txtCFOP
        '
        Me.txtCFOP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCFOP.IncludeLiterals = False
        Me.txtCFOP.Location = New System.Drawing.Point(562, 34)
        Me.txtCFOP.MaxLength = 20
        Me.txtCFOP.Name = "txtCFOP"
        Me.txtCFOP.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCFOP.ReadOnly = True
        Me.txtCFOP.Size = New System.Drawing.Size(110, 20)
        Me.txtCFOP.TabIndex = 69
        Me.txtCFOP.TabStop = False
        '
        'txtDataEntradaNF
        '
        Me.txtDataEntradaNF.AccessibleDescription = ""
        Me.txtDataEntradaNF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEntradaNF.IncludeLiterals = False
        Me.txtDataEntradaNF.Location = New System.Drawing.Point(127, 34)
        Me.txtDataEntradaNF.MaxLength = 20
        Me.txtDataEntradaNF.Name = "txtDataEntradaNF"
        Me.txtDataEntradaNF.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtDataEntradaNF.ReadOnly = True
        Me.txtDataEntradaNF.Size = New System.Drawing.Size(110, 20)
        Me.txtDataEntradaNF.TabIndex = 67
        Me.txtDataEntradaNF.TabStop = False
        '
        'lblDataEntradaNF
        '
        Me.lblDataEntradaNF.AutoSize = True
        Me.lblDataEntradaNF.Location = New System.Drawing.Point(124, 17)
        Me.lblDataEntradaNF.Name = "lblDataEntradaNF"
        Me.lblDataEntradaNF.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaNF.TabIndex = 68
        Me.lblDataEntradaNF.Text = "Data Entrada:"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFornecedor.IncludeLiterals = False
        Me.txtFornecedor.Location = New System.Drawing.Point(243, 34)
        Me.txtFornecedor.MaxLength = 20
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFornecedor.ReadOnly = True
        Me.txtFornecedor.Size = New System.Drawing.Size(313, 20)
        Me.txtFornecedor.TabIndex = 65
        Me.txtFornecedor.TabStop = False
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(240, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 66
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoProduto.IncludeLiterals = False
        Me.txtCodigoProduto.Location = New System.Drawing.Point(9, 74)
        Me.txtCodigoProduto.MaxLength = 20
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCodigoProduto.ReadOnly = True
        Me.txtCodigoProduto.Size = New System.Drawing.Size(228, 20)
        Me.txtCodigoProduto.TabIndex = 60
        Me.txtCodigoProduto.TabStop = False
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(6, 57)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProduto.TabIndex = 61
        Me.lblCodigoProduto.Text = "Código Produto:"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(559, 58)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 58
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 2
        Me.txtQuantidade.Location = New System.Drawing.Point(562, 74)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(110, 20)
        Me.txtQuantidade.TabIndex = 57
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtDescricaoProduto
        '
        Me.txtDescricaoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoProduto.IncludeLiterals = False
        Me.txtDescricaoProduto.Location = New System.Drawing.Point(243, 74)
        Me.txtDescricaoProduto.MaxLength = 20
        Me.txtDescricaoProduto.Name = "txtDescricaoProduto"
        Me.txtDescricaoProduto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtDescricaoProduto.ReadOnly = True
        Me.txtDescricaoProduto.Size = New System.Drawing.Size(313, 20)
        Me.txtDescricaoProduto.TabIndex = 45
        Me.txtDescricaoProduto.TabStop = False
        '
        'lblDescricaoProduto
        '
        Me.lblDescricaoProduto.AutoSize = True
        Me.lblDescricaoProduto.Location = New System.Drawing.Point(240, 58)
        Me.lblDescricaoProduto.Name = "lblDescricaoProduto"
        Me.lblDescricaoProduto.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoProduto.TabIndex = 49
        Me.lblDescricaoProduto.Text = "Descrição:"
        '
        'txtNFEntrada
        '
        Me.txtNFEntrada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNFEntrada.IncludeLiterals = False
        Me.txtNFEntrada.Location = New System.Drawing.Point(9, 34)
        Me.txtNFEntrada.MaxLength = 20
        Me.txtNFEntrada.Name = "txtNFEntrada"
        Me.txtNFEntrada.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNFEntrada.ReadOnly = True
        Me.txtNFEntrada.Size = New System.Drawing.Size(110, 20)
        Me.txtNFEntrada.TabIndex = 44
        Me.txtNFEntrada.TabStop = False
        '
        'lblNFEntrada
        '
        Me.lblNFEntrada.AutoSize = True
        Me.lblNFEntrada.Location = New System.Drawing.Point(6, 17)
        Me.lblNFEntrada.Name = "lblNFEntrada"
        Me.lblNFEntrada.Size = New System.Drawing.Size(63, 14)
        Me.lblNFEntrada.TabIndex = 48
        Me.lblNFEntrada.Text = "Nota Fiscal:"
        '
        'grdVinculos
        '
        Me.grdVinculos.AlternatingColors = True
        Me.grdVinculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVinculos.AutoEdit = True
        grdVinculos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdVinculos_DesignTimeLayout_Reference_0.Instance"), Object)
        grdVinculos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdVinculos_DesignTimeLayout_Reference_1.Instance"), Object)
        grdVinculos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdVinculos_DesignTimeLayout_Reference_0, grdVinculos_DesignTimeLayout_Reference_1})
        grdVinculos_DesignTimeLayout.LayoutString = resources.GetString("grdVinculos_DesignTimeLayout.LayoutString")
        Me.grdVinculos.DesignTimeLayout = grdVinculos_DesignTimeLayout
        Me.grdVinculos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdVinculos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdVinculos.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdVinculos.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdVinculos.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVinculos.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVinculos.FrozenColumns = 2
        Me.grdVinculos.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVinculos.GroupByBoxVisible = False
        Me.grdVinculos.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdVinculos.Location = New System.Drawing.Point(9, 221)
        Me.grdVinculos.Name = "grdVinculos"
        Me.grdVinculos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVinculos.RecordNavigator = True
        Me.grdVinculos.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdVinculos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVinculos.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVinculos.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVinculos.Size = New System.Drawing.Size(896, 256)
        Me.grdVinculos.TabIndex = 5
        Me.grdVinculos.TabStop = False
        Me.grdVinculos.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVinculos.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdVinculos.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdVinculos.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdVinculos.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdVinculos.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdVinculos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdVinculos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVinculos.VisualStyleManager = Me.vsmMain
        '
        'grpVinculo
        '
        Me.grpVinculo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpVinculo.BackColor = System.Drawing.Color.Transparent
        Me.grpVinculo.Controls.Add(Me.lblRequisisaoEstoqueVinculo)
        Me.grpVinculo.Controls.Add(Me.cboRequisisaoEstoqueVinculo)
        Me.grpVinculo.Controls.Add(Me.lblOrdemProducaoVinculo)
        Me.grpVinculo.Controls.Add(Me.cboUnidadeMedidaVinculo)
        Me.grpVinculo.Controls.Add(Me.lblUnidadeMedidaVinculo)
        Me.grpVinculo.Controls.Add(Me.lblQuantidadeVinculo)
        Me.grpVinculo.Controls.Add(Me.txtQuantidadeVinculo)
        Me.grpVinculo.Controls.Add(Me.cboOrdemProducaoVinculo)
        Me.grpVinculo.Controls.Add(Me.btnLimparVinculo)
        Me.grpVinculo.Controls.Add(Me.btnExcluirVinculo)
        Me.grpVinculo.Controls.Add(Me.btnInserirVinculo)
        Me.grpVinculo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpVinculo.Location = New System.Drawing.Point(9, 114)
        Me.grpVinculo.Name = "grpVinculo"
        Me.grpVinculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpVinculo.Size = New System.Drawing.Size(896, 101)
        Me.grpVinculo.TabIndex = 0
        Me.grpVinculo.VisualStyleManager = Me.vsmMain
        '
        'lblRequisisaoEstoqueVinculo
        '
        Me.lblRequisisaoEstoqueVinculo.AutoSize = True
        Me.lblRequisisaoEstoqueVinculo.Location = New System.Drawing.Point(124, 17)
        Me.lblRequisisaoEstoqueVinculo.Name = "lblRequisisaoEstoqueVinculo"
        Me.lblRequisisaoEstoqueVinculo.Size = New System.Drawing.Size(105, 14)
        Me.lblRequisisaoEstoqueVinculo.TabIndex = 81
        Me.lblRequisisaoEstoqueVinculo.Text = "Requisição Estoque:"
        '
        'cboRequisisaoEstoqueVinculo
        '
        Me.cboRequisisaoEstoqueVinculo.AutoSize = False
        Me.cboRequisisaoEstoqueVinculo.BackColor = System.Drawing.Color.White
        Me.cboRequisisaoEstoqueVinculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRequisisaoEstoqueVinculo.Location = New System.Drawing.Point(127, 34)
        Me.cboRequisisaoEstoqueVinculo.Name = "cboRequisisaoEstoqueVinculo"
        Me.cboRequisisaoEstoqueVinculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRequisisaoEstoqueVinculo.Size = New System.Drawing.Size(110, 20)
        Me.cboRequisisaoEstoqueVinculo.TabIndex = 80
        Me.cboRequisisaoEstoqueVinculo.Tag = ""
        '
        'lblOrdemProducaoVinculo
        '
        Me.lblOrdemProducaoVinculo.AutoSize = True
        Me.lblOrdemProducaoVinculo.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducaoVinculo.Name = "lblOrdemProducaoVinculo"
        Me.lblOrdemProducaoVinculo.Size = New System.Drawing.Size(106, 14)
        Me.lblOrdemProducaoVinculo.TabIndex = 78
        Me.lblOrdemProducaoVinculo.Text = "Ordem de Produção:"
        '
        'cboUnidadeMedidaVinculo
        '
        Me.cboUnidadeMedidaVinculo.AutoSize = False
        Me.cboUnidadeMedidaVinculo.BackColor = System.Drawing.Color.White
        Me.cboUnidadeMedidaVinculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaVinculo.Location = New System.Drawing.Point(359, 34)
        Me.cboUnidadeMedidaVinculo.Name = "cboUnidadeMedidaVinculo"
        Me.cboUnidadeMedidaVinculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaVinculo.Size = New System.Drawing.Size(87, 20)
        Me.cboUnidadeMedidaVinculo.TabIndex = 76
        Me.cboUnidadeMedidaVinculo.Tag = ""
        '
        'lblUnidadeMedidaVinculo
        '
        Me.lblUnidadeMedidaVinculo.AutoSize = True
        Me.lblUnidadeMedidaVinculo.Location = New System.Drawing.Point(356, 17)
        Me.lblUnidadeMedidaVinculo.Name = "lblUnidadeMedidaVinculo"
        Me.lblUnidadeMedidaVinculo.Size = New System.Drawing.Size(71, 14)
        Me.lblUnidadeMedidaVinculo.TabIndex = 77
        Me.lblUnidadeMedidaVinculo.Tag = ""
        Me.lblUnidadeMedidaVinculo.Text = "Unid. Medida:"
        '
        'lblQuantidadeVinculo
        '
        Me.lblQuantidadeVinculo.AutoSize = True
        Me.lblQuantidadeVinculo.Location = New System.Drawing.Point(241, 18)
        Me.lblQuantidadeVinculo.Name = "lblQuantidadeVinculo"
        Me.lblQuantidadeVinculo.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeVinculo.TabIndex = 75
        Me.lblQuantidadeVinculo.Text = "Quantidade:"
        '
        'txtQuantidadeVinculo
        '
        Me.txtQuantidadeVinculo.BackColor = System.Drawing.Color.White
        Me.txtQuantidadeVinculo.DecimalDigits = 2
        Me.txtQuantidadeVinculo.Location = New System.Drawing.Point(243, 34)
        Me.txtQuantidadeVinculo.Name = "txtQuantidadeVinculo"
        Me.txtQuantidadeVinculo.Size = New System.Drawing.Size(110, 20)
        Me.txtQuantidadeVinculo.TabIndex = 74
        Me.txtQuantidadeVinculo.TabStop = False
        Me.txtQuantidadeVinculo.Text = "0,00"
        Me.txtQuantidadeVinculo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboOrdemProducaoVinculo
        '
        Me.cboOrdemProducaoVinculo.AutoSize = False
        Me.cboOrdemProducaoVinculo.BackColor = System.Drawing.Color.White
        Me.cboOrdemProducaoVinculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrdemProducaoVinculo.Location = New System.Drawing.Point(9, 34)
        Me.cboOrdemProducaoVinculo.Name = "cboOrdemProducaoVinculo"
        Me.cboOrdemProducaoVinculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrdemProducaoVinculo.Size = New System.Drawing.Size(112, 20)
        Me.cboOrdemProducaoVinculo.TabIndex = 72
        Me.cboOrdemProducaoVinculo.Tag = ""
        '
        'btnLimparVinculo
        '
        Me.btnLimparVinculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimparVinculo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnLimparVinculo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLimparVinculo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnLimparVinculo.Location = New System.Drawing.Point(794, 70)
        Me.btnLimparVinculo.Name = "btnLimparVinculo"
        Me.btnLimparVinculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnLimparVinculo.Size = New System.Drawing.Size(91, 23)
        Me.btnLimparVinculo.TabIndex = 9
        Me.btnLimparVinculo.Text = "Limpar"
        Me.btnLimparVinculo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirVinculo
        '
        Me.btnExcluirVinculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirVinculo.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirVinculo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirVinculo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirVinculo.Location = New System.Drawing.Point(794, 41)
        Me.btnExcluirVinculo.Name = "btnExcluirVinculo"
        Me.btnExcluirVinculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirVinculo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirVinculo.TabIndex = 8
        Me.btnExcluirVinculo.Text = "Excluir"
        Me.btnExcluirVinculo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirVinculo
        '
        Me.btnInserirVinculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirVinculo.Image = CType(resources.GetObject("btnInserirVinculo.Image"), System.Drawing.Image)
        Me.btnInserirVinculo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirVinculo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirVinculo.Location = New System.Drawing.Point(794, 12)
        Me.btnInserirVinculo.Name = "btnInserirVinculo"
        Me.btnInserirVinculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirVinculo.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirVinculo.TabIndex = 7
        Me.btnInserirVinculo.Text = "Inserir"
        Me.btnInserirVinculo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Location = New System.Drawing.Point(9, 483)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(896, 51)
        Me.grpControle2.TabIndex = 1
        Me.grpControle2.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(796, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 0
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblLegendaVinculado
        '
        Me.lblLegendaVinculado.AutoSize = True
        Me.lblLegendaVinculado.Location = New System.Drawing.Point(253, 23)
        Me.lblLegendaVinculado.Name = "lblLegendaVinculado"
        Me.lblLegendaVinculado.Size = New System.Drawing.Size(55, 14)
        Me.lblLegendaVinculado.TabIndex = 20
        Me.lblLegendaVinculado.Text = "Vínculado"
        '
        'picLegendaVinculado
        '
        Me.picLegendaVinculado.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaVinculado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaVinculado.Location = New System.Drawing.Point(234, 23)
        Me.picLegendaVinculado.Name = "picLegendaVinculado"
        Me.picLegendaVinculado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaVinculado.TabIndex = 24
        Me.picLegendaVinculado.TabStop = False
        '
        'lblLegendaSemVinculo
        '
        Me.lblLegendaSemVinculo.AutoSize = True
        Me.lblLegendaSemVinculo.Location = New System.Drawing.Point(25, 23)
        Me.lblLegendaSemVinculo.Name = "lblLegendaSemVinculo"
        Me.lblLegendaSemVinculo.Size = New System.Drawing.Size(67, 14)
        Me.lblLegendaSemVinculo.TabIndex = 21
        Me.lblLegendaSemVinculo.Text = "Sem Vínculo"
        '
        'picLegendaSemVinculo
        '
        Me.picLegendaSemVinculo.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaSemVinculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaSemVinculo.Location = New System.Drawing.Point(6, 23)
        Me.picLegendaSemVinculo.Name = "picLegendaSemVinculo"
        Me.picLegendaSemVinculo.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaSemVinculo.TabIndex = 23
        Me.picLegendaSemVinculo.TabStop = False
        '
        'lblLegendaParcialmenteVinculado
        '
        Me.lblLegendaParcialmenteVinculado.AutoSize = True
        Me.lblLegendaParcialmenteVinculado.Location = New System.Drawing.Point(139, 23)
        Me.lblLegendaParcialmenteVinculado.Name = "lblLegendaParcialmenteVinculado"
        Me.lblLegendaParcialmenteVinculado.Size = New System.Drawing.Size(83, 14)
        Me.lblLegendaParcialmenteVinculado.TabIndex = 19
        Me.lblLegendaParcialmenteVinculado.Text = "Parc. Vínculado"
        '
        'picLegendaParcialmenteVinculado
        '
        Me.picLegendaParcialmenteVinculado.BackColor = System.Drawing.Color.Goldenrod
        Me.picLegendaParcialmenteVinculado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaParcialmenteVinculado.Location = New System.Drawing.Point(120, 23)
        Me.picLegendaParcialmenteVinculado.Name = "picLegendaParcialmenteVinculado"
        Me.picLegendaParcialmenteVinculado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaParcialmenteVinculado.TabIndex = 22
        Me.picLegendaParcialmenteVinculado.TabStop = False
        '
        'usrFatVinculoMaterialTerceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatVinculoMaterialTerceiro"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grdVinculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpVinculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVinculo.ResumeLayout(False)
        Me.grpVinculo.PerformLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        CType(Me.picLegendaVinculado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaSemVinculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaParcialmenteVinculado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpControle2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntradaFiltro As Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdVinculos As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpVinculo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirVinculo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirVinculo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnLimparVinculo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNFEntradaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNFEntradaFiltro As Label
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedorFiltro As Label
    Friend WithEvents txtDataEntradaNF As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEntradaNF As Label
    Friend WithEvents txtFornecedor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents txtCodigoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProduto As Label
    Friend WithEvents txtDescricaoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoProduto As Label
    Friend WithEvents txtNFEntrada As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNFEntrada As Label
    Friend WithEvents lblCFOP As Label
    Friend WithEvents txtCFOP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedida As Label
    Friend WithEvents lblOrdemProducaoVinculo As Label
    Friend WithEvents cboUnidadeMedidaVinculo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaVinculo As Label
    Friend WithEvents lblQuantidadeVinculo As Label
    Friend WithEvents txtQuantidadeVinculo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboOrdemProducaoVinculo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRequisisaoEstoqueVinculo As Label
    Friend WithEvents cboRequisisaoEstoqueVinculo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLegendaVinculado As Label
    Friend WithEvents picLegendaVinculado As PictureBox
    Friend WithEvents lblLegendaSemVinculo As Label
    Friend WithEvents picLegendaSemVinculo As PictureBox
    Friend WithEvents lblLegendaParcialmenteVinculado As Label
    Friend WithEvents picLegendaParcialmenteVinculado As PictureBox
End Class
