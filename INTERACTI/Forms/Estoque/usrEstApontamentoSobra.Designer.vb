<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrEstApontamentoSobra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstApontamentoSobra))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataMovimentacaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaApontado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaApontado = New System.Windows.Forms.Label()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDataMovimentacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataMovimentacao = New System.Windows.Forms.Label()
        Me.txtUnidadeMedida = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.txtCodigoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.lblQuantidadeDiferenca = New System.Windows.Forms.Label()
        Me.txtQuantidadeDiferenca = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeMovimentacaoEstoque = New System.Windows.Forms.Label()
        Me.txtQuantidadeMovimentacaoEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtNumeroRE = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRE = New System.Windows.Forms.Label()
        Me.lblQuantidadeRE = New System.Windows.Forms.Label()
        Me.txtQuantidadeRE = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDescricaoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoProduto = New System.Windows.Forms.Label()
        Me.cboGrupoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItemRequisicaoListaMaterial = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.grpApontamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPesoEspecifico = New System.Windows.Forms.Label()
        Me.txtPesoEspecifico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPeso = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial = New System.Windows.Forms.Label()
        Me.txtCodigoProdutoNovo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuantidadeApontamento = New System.Windows.Forms.Label()
        Me.txtQuantidadeApontamento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescricaoApontamento = New System.Windows.Forms.Label()
        Me.txtDescricaoApontamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtMedida1 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida3 = New System.Windows.Forms.Label()
        Me.txtMedida2 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.txtMedida3 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida2 = New System.Windows.Forms.Label()
        Me.lblMedida4 = New System.Windows.Forms.Label()
        Me.lblUnidadeMedidaApontamento = New System.Windows.Forms.Label()
        Me.txtMedida4 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida1 = New System.Windows.Forms.Label()
        Me.btnLimparApontamento = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirApontamento = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirApontamento = New Janus.Windows.EditControls.UIButton()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.picLegendaApontado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpApontamento.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
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
        Me.pagListagem.Location = New System.Drawing.Point(1, 24)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 541)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Apontamento Sobra"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataMovimentacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 69)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(101, 23)
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
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(116, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(101, 23)
        Me.dtpDataTerminoFiltro.TabIndex = 1
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataMovimentacaoFiltro
        '
        Me.lblDataMovimentacaoFiltro.AutoSize = True
        Me.lblDataMovimentacaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDataMovimentacaoFiltro.Name = "lblDataMovimentacaoFiltro"
        Me.lblDataMovimentacaoFiltro.Size = New System.Drawing.Size(137, 16)
        Me.lblDataMovimentacaoFiltro.TabIndex = 22
        Me.lblDataMovimentacaoFiltro.Text = "Data Movimentação:"
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
        Me.grpControle.Controls.Add(Me.picLegendaApontado)
        Me.grpControle.Controls.Add(Me.lblLegendaApontado)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 481)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 1
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'picLegendaApontado
        '
        Me.picLegendaApontado.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaApontado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaApontado.Location = New System.Drawing.Point(9, 18)
        Me.picLegendaApontado.Name = "picLegendaApontado"
        Me.picLegendaApontado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaApontado.TabIndex = 18
        Me.picLegendaApontado.TabStop = False
        '
        'lblLegendaApontado
        '
        Me.lblLegendaApontado.AutoSize = True
        Me.lblLegendaApontado.Location = New System.Drawing.Point(28, 18)
        Me.lblLegendaApontado.Name = "lblLegendaApontado"
        Me.lblLegendaApontado.Size = New System.Drawing.Size(69, 16)
        Me.lblLegendaApontado.TabIndex = 17
        Me.lblLegendaApontado.Text = "Apontado"
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
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
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
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 397)
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
        Me.pagDados.Controls.Add(Me.grdApontamento)
        Me.pagDados.Controls.Add(Me.grpApontamento)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 24)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 541)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Apontamento Sobra"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtDataMovimentacao)
        Me.grpDados.Controls.Add(Me.lblDataMovimentacao)
        Me.grpDados.Controls.Add(Me.txtUnidadeMedida)
        Me.grpDados.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDados.Controls.Add(Me.txtCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblQuantidadeDiferenca)
        Me.grpDados.Controls.Add(Me.txtQuantidadeDiferenca)
        Me.grpDados.Controls.Add(Me.lblQuantidadeMovimentacaoEstoque)
        Me.grpDados.Controls.Add(Me.txtQuantidadeMovimentacaoEstoque)
        Me.grpDados.Controls.Add(Me.txtNumeroRE)
        Me.grpDados.Controls.Add(Me.lblNumeroRE)
        Me.grpDados.Controls.Add(Me.lblQuantidadeRE)
        Me.grpDados.Controls.Add(Me.txtQuantidadeRE)
        Me.grpDados.Controls.Add(Me.txtDescricaoProduto)
        Me.grpDados.Controls.Add(Me.lblDescricaoProduto)
        Me.grpDados.Controls.Add(Me.cboGrupoItem)
        Me.grpDados.Controls.Add(Me.lblGrupoItemRequisicaoListaMaterial)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Location = New System.Drawing.Point(9, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(896, 105)
        Me.grpDados.TabIndex = 6
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtDataMovimentacao
        '
        Me.txtDataMovimentacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataMovimentacao.IncludeLiterals = False
        Me.txtDataMovimentacao.Location = New System.Drawing.Point(127, 34)
        Me.txtDataMovimentacao.MaxLength = 20
        Me.txtDataMovimentacao.Name = "txtDataMovimentacao"
        Me.txtDataMovimentacao.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtDataMovimentacao.ReadOnly = True
        Me.txtDataMovimentacao.Size = New System.Drawing.Size(110, 23)
        Me.txtDataMovimentacao.TabIndex = 67
        Me.txtDataMovimentacao.TabStop = False
        '
        'lblDataMovimentacao
        '
        Me.lblDataMovimentacao.AutoSize = True
        Me.lblDataMovimentacao.Location = New System.Drawing.Point(124, 17)
        Me.lblDataMovimentacao.Name = "lblDataMovimentacao"
        Me.lblDataMovimentacao.Size = New System.Drawing.Size(75, 16)
        Me.lblDataMovimentacao.TabIndex = 68
        Me.lblDataMovimentacao.Text = "Data Mov.:"
        '
        'txtUnidadeMedida
        '
        Me.txtUnidadeMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUnidadeMedida.IncludeLiterals = False
        Me.txtUnidadeMedida.Location = New System.Drawing.Point(400, 78)
        Me.txtUnidadeMedida.MaxLength = 20
        Me.txtUnidadeMedida.Name = "txtUnidadeMedida"
        Me.txtUnidadeMedida.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtUnidadeMedida.ReadOnly = True
        Me.txtUnidadeMedida.Size = New System.Drawing.Size(110, 23)
        Me.txtUnidadeMedida.TabIndex = 65
        Me.txtUnidadeMedida.TabStop = False
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(399, 61)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(79, 16)
        Me.lblUnidadeMedida.TabIndex = 66
        Me.lblUnidadeMedida.Text = "Un Medida:"
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoProduto.IncludeLiterals = False
        Me.txtCodigoProduto.Location = New System.Drawing.Point(360, 34)
        Me.txtCodigoProduto.MaxLength = 20
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCodigoProduto.ReadOnly = True
        Me.txtCodigoProduto.Size = New System.Drawing.Size(182, 23)
        Me.txtCodigoProduto.TabIndex = 60
        Me.txtCodigoProduto.TabStop = False
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(357, 18)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(111, 16)
        Me.lblCodigoProduto.TabIndex = 61
        Me.lblCodigoProduto.Text = "Código Produto:"
        '
        'lblQuantidadeDiferenca
        '
        Me.lblQuantidadeDiferenca.AutoSize = True
        Me.lblQuantidadeDiferenca.Location = New System.Drawing.Point(748, 62)
        Me.lblQuantidadeDiferenca.Name = "lblQuantidadeDiferenca"
        Me.lblQuantidadeDiferenca.Size = New System.Drawing.Size(100, 16)
        Me.lblQuantidadeDiferenca.TabIndex = 58
        Me.lblQuantidadeDiferenca.Text = "Qtd Diferença:"
        Me.lblQuantidadeDiferenca.Visible = False
        '
        'txtQuantidadeDiferenca
        '
        Me.txtQuantidadeDiferenca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeDiferenca.DecimalDigits = 2
        Me.txtQuantidadeDiferenca.Location = New System.Drawing.Point(751, 78)
        Me.txtQuantidadeDiferenca.Name = "txtQuantidadeDiferenca"
        Me.txtQuantidadeDiferenca.ReadOnly = True
        Me.txtQuantidadeDiferenca.Size = New System.Drawing.Size(110, 23)
        Me.txtQuantidadeDiferenca.TabIndex = 57
        Me.txtQuantidadeDiferenca.TabStop = False
        Me.txtQuantidadeDiferenca.Text = "0,00"
        Me.txtQuantidadeDiferenca.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtQuantidadeDiferenca.Visible = False
        '
        'lblQuantidadeMovimentacaoEstoque
        '
        Me.lblQuantidadeMovimentacaoEstoque.AutoSize = True
        Me.lblQuantidadeMovimentacaoEstoque.Location = New System.Drawing.Point(515, 62)
        Me.lblQuantidadeMovimentacaoEstoque.Name = "lblQuantidadeMovimentacaoEstoque"
        Me.lblQuantidadeMovimentacaoEstoque.Size = New System.Drawing.Size(100, 16)
        Me.lblQuantidadeMovimentacaoEstoque.TabIndex = 56
        Me.lblQuantidadeMovimentacaoEstoque.Text = "Qtd. Mov. Est.:"
        '
        'txtQuantidadeMovimentacaoEstoque
        '
        Me.txtQuantidadeMovimentacaoEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeMovimentacaoEstoque.DecimalDigits = 2
        Me.txtQuantidadeMovimentacaoEstoque.Location = New System.Drawing.Point(518, 78)
        Me.txtQuantidadeMovimentacaoEstoque.Name = "txtQuantidadeMovimentacaoEstoque"
        Me.txtQuantidadeMovimentacaoEstoque.ReadOnly = True
        Me.txtQuantidadeMovimentacaoEstoque.Size = New System.Drawing.Size(110, 23)
        Me.txtQuantidadeMovimentacaoEstoque.TabIndex = 55
        Me.txtQuantidadeMovimentacaoEstoque.TabStop = False
        Me.txtQuantidadeMovimentacaoEstoque.Text = "0,00"
        Me.txtQuantidadeMovimentacaoEstoque.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtNumeroRE
        '
        Me.txtNumeroRE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRE.IncludeLiterals = False
        Me.txtNumeroRE.Location = New System.Drawing.Point(243, 34)
        Me.txtNumeroRE.MaxLength = 20
        Me.txtNumeroRE.Name = "txtNumeroRE"
        Me.txtNumeroRE.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroRE.ReadOnly = True
        Me.txtNumeroRE.Size = New System.Drawing.Size(110, 23)
        Me.txtNumeroRE.TabIndex = 53
        Me.txtNumeroRE.TabStop = False
        '
        'lblNumeroRE
        '
        Me.lblNumeroRE.AutoSize = True
        Me.lblNumeroRE.Location = New System.Drawing.Point(240, 17)
        Me.lblNumeroRE.Name = "lblNumeroRE"
        Me.lblNumeroRE.Size = New System.Drawing.Size(98, 16)
        Me.lblNumeroRE.TabIndex = 54
        Me.lblNumeroRE.Text = "Req. Estoque:"
        '
        'lblQuantidadeRE
        '
        Me.lblQuantidadeRE.AutoSize = True
        Me.lblQuantidadeRE.Location = New System.Drawing.Point(631, 62)
        Me.lblQuantidadeRE.Name = "lblQuantidadeRE"
        Me.lblQuantidadeRE.Size = New System.Drawing.Size(58, 16)
        Me.lblQuantidadeRE.TabIndex = 50
        Me.lblQuantidadeRE.Text = "Qtd RE:"
        Me.lblQuantidadeRE.Visible = False
        '
        'txtQuantidadeRE
        '
        Me.txtQuantidadeRE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeRE.DecimalDigits = 2
        Me.txtQuantidadeRE.Location = New System.Drawing.Point(634, 78)
        Me.txtQuantidadeRE.Name = "txtQuantidadeRE"
        Me.txtQuantidadeRE.ReadOnly = True
        Me.txtQuantidadeRE.Size = New System.Drawing.Size(110, 23)
        Me.txtQuantidadeRE.TabIndex = 47
        Me.txtQuantidadeRE.TabStop = False
        Me.txtQuantidadeRE.Text = "0,00"
        Me.txtQuantidadeRE.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtQuantidadeRE.Visible = False
        '
        'txtDescricaoProduto
        '
        Me.txtDescricaoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoProduto.IncludeLiterals = False
        Me.txtDescricaoProduto.Location = New System.Drawing.Point(548, 34)
        Me.txtDescricaoProduto.MaxLength = 20
        Me.txtDescricaoProduto.Name = "txtDescricaoProduto"
        Me.txtDescricaoProduto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtDescricaoProduto.ReadOnly = True
        Me.txtDescricaoProduto.Size = New System.Drawing.Size(313, 23)
        Me.txtDescricaoProduto.TabIndex = 45
        Me.txtDescricaoProduto.TabStop = False
        '
        'lblDescricaoProduto
        '
        Me.lblDescricaoProduto.AutoSize = True
        Me.lblDescricaoProduto.Location = New System.Drawing.Point(545, 18)
        Me.lblDescricaoProduto.Name = "lblDescricaoProduto"
        Me.lblDescricaoProduto.Size = New System.Drawing.Size(62, 16)
        Me.lblDescricaoProduto.TabIndex = 49
        Me.lblDescricaoProduto.Text = "Produto:"
        '
        'cboGrupoItem
        '
        Me.cboGrupoItem.AutoSize = False
        Me.cboGrupoItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboGrupoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItem.Location = New System.Drawing.Point(9, 78)
        Me.cboGrupoItem.Name = "cboGrupoItem"
        Me.cboGrupoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItem.ReadOnly = True
        Me.cboGrupoItem.Size = New System.Drawing.Size(385, 20)
        Me.cboGrupoItem.TabIndex = 30
        Me.cboGrupoItem.Tag = ""
        '
        'lblGrupoItemRequisicaoListaMaterial
        '
        Me.lblGrupoItemRequisicaoListaMaterial.AutoSize = True
        Me.lblGrupoItemRequisicaoListaMaterial.Location = New System.Drawing.Point(6, 61)
        Me.lblGrupoItemRequisicaoListaMaterial.Name = "lblGrupoItemRequisicaoListaMaterial"
        Me.lblGrupoItemRequisicaoListaMaterial.Size = New System.Drawing.Size(82, 16)
        Me.lblGrupoItemRequisicaoListaMaterial.TabIndex = 29
        Me.lblGrupoItemRequisicaoListaMaterial.Tag = ""
        Me.lblGrupoItemRequisicaoListaMaterial.Text = "Grupo Item:"
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.IncludeLiterals = False
        Me.txtOrdemProducao.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemProducao.MaxLength = 20
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.Size = New System.Drawing.Size(110, 23)
        Me.txtOrdemProducao.TabIndex = 44
        Me.txtOrdemProducao.TabStop = False
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(120, 16)
        Me.lblOrdemProducao.TabIndex = 48
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'grdApontamento
        '
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdApontamento.AutoEdit = True
        grdApontamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdApontamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdApontamento_DesignTimeLayout_Reference_0})
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdApontamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdApontamento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.FrozenColumns = 2
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdApontamento.Location = New System.Drawing.Point(9, 271)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.RecordNavigator = True
        Me.grdApontamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdApontamento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(896, 204)
        Me.grdApontamento.TabIndex = 5
        Me.grdApontamento.TabStop = False
        Me.grdApontamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdApontamento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdApontamento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
        '
        'grpApontamento
        '
        Me.grpApontamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpApontamento.BackColor = System.Drawing.Color.Transparent
        Me.grpApontamento.Controls.Add(Me.lblPesoEspecifico)
        Me.grpApontamento.Controls.Add(Me.txtPesoEspecifico)
        Me.grpApontamento.Controls.Add(Me.txtPeso)
        Me.grpApontamento.Controls.Add(Me.lblPeso)
        Me.grpApontamento.Controls.Add(Me.lblCodigoProdutoNovoRequisicaoListaMaterial)
        Me.grpApontamento.Controls.Add(Me.txtCodigoProdutoNovo)
        Me.grpApontamento.Controls.Add(Me.cboCodigoProduto)
        Me.grpApontamento.Controls.Add(Me.Label2)
        Me.grpApontamento.Controls.Add(Me.lblQuantidadeApontamento)
        Me.grpApontamento.Controls.Add(Me.txtQuantidadeApontamento)
        Me.grpApontamento.Controls.Add(Me.lblDescricaoApontamento)
        Me.grpApontamento.Controls.Add(Me.txtDescricaoApontamento)
        Me.grpApontamento.Controls.Add(Me.txtMedida1)
        Me.grpApontamento.Controls.Add(Me.lblMedida3)
        Me.grpApontamento.Controls.Add(Me.txtMedida2)
        Me.grpApontamento.Controls.Add(Me.cboUnidadeMedida)
        Me.grpApontamento.Controls.Add(Me.txtMedida3)
        Me.grpApontamento.Controls.Add(Me.lblMedida2)
        Me.grpApontamento.Controls.Add(Me.lblMedida4)
        Me.grpApontamento.Controls.Add(Me.lblUnidadeMedidaApontamento)
        Me.grpApontamento.Controls.Add(Me.txtMedida4)
        Me.grpApontamento.Controls.Add(Me.lblMedida1)
        Me.grpApontamento.Controls.Add(Me.btnLimparApontamento)
        Me.grpApontamento.Controls.Add(Me.btnExcluirApontamento)
        Me.grpApontamento.Controls.Add(Me.btnInserirApontamento)
        Me.grpApontamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpApontamento.Location = New System.Drawing.Point(9, 114)
        Me.grpApontamento.Name = "grpApontamento"
        Me.grpApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpApontamento.Size = New System.Drawing.Size(896, 151)
        Me.grpApontamento.TabIndex = 0
        Me.grpApontamento.VisualStyleManager = Me.vsmMain
        '
        'lblPesoEspecifico
        '
        Me.lblPesoEspecifico.AutoSize = True
        Me.lblPesoEspecifico.Location = New System.Drawing.Point(491, 60)
        Me.lblPesoEspecifico.Name = "lblPesoEspecifico"
        Me.lblPesoEspecifico.Size = New System.Drawing.Size(113, 16)
        Me.lblPesoEspecifico.TabIndex = 68
        Me.lblPesoEspecifico.Tag = ""
        Me.lblPesoEspecifico.Text = "Peso Específico:"
        '
        'txtPesoEspecifico
        '
        Me.txtPesoEspecifico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPesoEspecifico.DecimalDigits = 2
        Me.txtPesoEspecifico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPesoEspecifico.Location = New System.Drawing.Point(492, 77)
        Me.txtPesoEspecifico.MaxLength = 0
        Me.txtPesoEspecifico.Name = "txtPesoEspecifico"
        Me.txtPesoEspecifico.Size = New System.Drawing.Size(85, 23)
        Me.txtPesoEspecifico.TabIndex = 69
        Me.txtPesoEspecifico.TabStop = False
        Me.txtPesoEspecifico.Tag = ""
        Me.txtPesoEspecifico.Text = "0,00"
        Me.txtPesoEspecifico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtPeso
        '
        Me.txtPeso.DecimalDigits = 4
        Me.txtPeso.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPeso.Location = New System.Drawing.Point(583, 77)
        Me.txtPeso.MaxLength = 0
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(85, 23)
        Me.txtPeso.TabIndex = 71
        Me.txtPeso.Tag = ""
        Me.txtPeso.Text = "0,0000"
        Me.txtPeso.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(580, 60)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(44, 16)
        Me.lblPeso.TabIndex = 70
        Me.lblPeso.Tag = ""
        Me.lblPeso.Text = "Peso:"
        '
        'lblCodigoProdutoNovoRequisicaoListaMaterial
        '
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.AutoSize = True
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.Location = New System.Drawing.Point(6, 19)
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.Name = "lblCodigoProdutoNovoRequisicaoListaMaterial"
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.Size = New System.Drawing.Size(157, 16)
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.TabIndex = 66
        Me.lblCodigoProdutoNovoRequisicaoListaMaterial.Text = "Código Produto (Novo):"
        '
        'txtCodigoProdutoNovo
        '
        Me.txtCodigoProdutoNovo.Location = New System.Drawing.Point(9, 36)
        Me.txtCodigoProdutoNovo.Name = "txtCodigoProdutoNovo"
        Me.txtCodigoProdutoNovo.Size = New System.Drawing.Size(148, 23)
        Me.txtCodigoProdutoNovo.TabIndex = 67
        Me.txtCodigoProdutoNovo.TabStop = False
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.AutoSize = False
        Me.cboCodigoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboCodigoProduto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCodigoProduto.Location = New System.Drawing.Point(165, 36)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProduto.ReadOnly = True
        Me.cboCodigoProduto.Size = New System.Drawing.Size(275, 20)
        Me.cboCodigoProduto.TabIndex = 65
        Me.cboCodigoProduto.Tag = ""
        Me.cboCodigoProduto.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Código Produto:"
        Me.Label2.Visible = False
        '
        'lblQuantidadeApontamento
        '
        Me.lblQuantidadeApontamento.AutoSize = True
        Me.lblQuantidadeApontamento.Location = New System.Drawing.Point(317, 60)
        Me.lblQuantidadeApontamento.Name = "lblQuantidadeApontamento"
        Me.lblQuantidadeApontamento.Size = New System.Drawing.Size(86, 16)
        Me.lblQuantidadeApontamento.TabIndex = 43
        Me.lblQuantidadeApontamento.Text = "Quantidade:"
        '
        'txtQuantidadeApontamento
        '
        Me.txtQuantidadeApontamento.DecimalDigits = 2
        Me.txtQuantidadeApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtQuantidadeApontamento.Location = New System.Drawing.Point(318, 77)
        Me.txtQuantidadeApontamento.MaxLength = 0
        Me.txtQuantidadeApontamento.Name = "txtQuantidadeApontamento"
        Me.txtQuantidadeApontamento.Size = New System.Drawing.Size(69, 23)
        Me.txtQuantidadeApontamento.TabIndex = 4
        Me.txtQuantidadeApontamento.Text = "0,00"
        Me.txtQuantidadeApontamento.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDescricaoApontamento
        '
        Me.lblDescricaoApontamento.AutoSize = True
        Me.lblDescricaoApontamento.Location = New System.Drawing.Point(6, 100)
        Me.lblDescricaoApontamento.Name = "lblDescricaoApontamento"
        Me.lblDescricaoApontamento.Size = New System.Drawing.Size(75, 16)
        Me.lblDescricaoApontamento.TabIndex = 41
        Me.lblDescricaoApontamento.Text = "Descrição:"
        '
        'txtDescricaoApontamento
        '
        Me.txtDescricaoApontamento.Location = New System.Drawing.Point(9, 117)
        Me.txtDescricaoApontamento.Name = "txtDescricaoApontamento"
        Me.txtDescricaoApontamento.Size = New System.Drawing.Size(659, 23)
        Me.txtDescricaoApontamento.TabIndex = 6
        '
        'txtMedida1
        '
        Me.txtMedida1.DecimalDigits = 2
        Me.txtMedida1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida1.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida1.FormatString = "0.00"
        Me.txtMedida1.Location = New System.Drawing.Point(9, 77)
        Me.txtMedida1.MaxLength = 0
        Me.txtMedida1.Name = "txtMedida1"
        Me.txtMedida1.Size = New System.Drawing.Size(70, 23)
        Me.txtMedida1.TabIndex = 0
        Me.txtMedida1.Tag = ""
        Me.txtMedida1.Text = "0,00"
        Me.txtMedida1.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida3
        '
        Me.lblMedida3.AutoSize = True
        Me.lblMedida3.Location = New System.Drawing.Point(159, 60)
        Me.lblMedida3.Name = "lblMedida3"
        Me.lblMedida3.Size = New System.Drawing.Size(70, 16)
        Me.lblMedida3.TabIndex = 35
        Me.lblMedida3.Tag = ""
        Me.lblMedida3.Text = "Medida 3:"
        '
        'txtMedida2
        '
        Me.txtMedida2.DecimalDigits = 2
        Me.txtMedida2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida2.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida2.FormatString = "0.00"
        Me.txtMedida2.Location = New System.Drawing.Point(85, 77)
        Me.txtMedida2.MaxLength = 0
        Me.txtMedida2.Name = "txtMedida2"
        Me.txtMedida2.Size = New System.Drawing.Size(72, 23)
        Me.txtMedida2.TabIndex = 1
        Me.txtMedida2.Tag = ""
        Me.txtMedida2.Text = "0,00"
        Me.txtMedida2.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(393, 77)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.ReadOnly = True
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(93, 20)
        Me.cboUnidadeMedida.TabIndex = 5
        Me.cboUnidadeMedida.Tag = ""
        '
        'txtMedida3
        '
        Me.txtMedida3.DecimalDigits = 2
        Me.txtMedida3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida3.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida3.FormatString = "0.00"
        Me.txtMedida3.Location = New System.Drawing.Point(162, 77)
        Me.txtMedida3.MaxLength = 0
        Me.txtMedida3.Name = "txtMedida3"
        Me.txtMedida3.Size = New System.Drawing.Size(72, 23)
        Me.txtMedida3.TabIndex = 2
        Me.txtMedida3.Tag = ""
        Me.txtMedida3.Text = "0,00"
        Me.txtMedida3.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida2
        '
        Me.lblMedida2.AutoSize = True
        Me.lblMedida2.Location = New System.Drawing.Point(82, 60)
        Me.lblMedida2.Name = "lblMedida2"
        Me.lblMedida2.Size = New System.Drawing.Size(70, 16)
        Me.lblMedida2.TabIndex = 33
        Me.lblMedida2.Tag = ""
        Me.lblMedida2.Text = "Medida 2:"
        '
        'lblMedida4
        '
        Me.lblMedida4.AutoSize = True
        Me.lblMedida4.Location = New System.Drawing.Point(237, 60)
        Me.lblMedida4.Name = "lblMedida4"
        Me.lblMedida4.Size = New System.Drawing.Size(70, 16)
        Me.lblMedida4.TabIndex = 37
        Me.lblMedida4.Tag = ""
        Me.lblMedida4.Text = "Medida 4:"
        '
        'lblUnidadeMedidaApontamento
        '
        Me.lblUnidadeMedidaApontamento.AutoSize = True
        Me.lblUnidadeMedidaApontamento.Location = New System.Drawing.Point(390, 60)
        Me.lblUnidadeMedidaApontamento.Name = "lblUnidadeMedidaApontamento"
        Me.lblUnidadeMedidaApontamento.Size = New System.Drawing.Size(94, 16)
        Me.lblUnidadeMedidaApontamento.TabIndex = 39
        Me.lblUnidadeMedidaApontamento.Tag = ""
        Me.lblUnidadeMedidaApontamento.Text = "Unid. Medida:"
        '
        'txtMedida4
        '
        Me.txtMedida4.DecimalDigits = 2
        Me.txtMedida4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida4.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida4.FormatString = "0.00"
        Me.txtMedida4.Location = New System.Drawing.Point(240, 77)
        Me.txtMedida4.MaxLength = 0
        Me.txtMedida4.Name = "txtMedida4"
        Me.txtMedida4.Size = New System.Drawing.Size(72, 23)
        Me.txtMedida4.TabIndex = 3
        Me.txtMedida4.Tag = ""
        Me.txtMedida4.Text = "0,00"
        Me.txtMedida4.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida1
        '
        Me.lblMedida1.AutoSize = True
        Me.lblMedida1.Location = New System.Drawing.Point(6, 60)
        Me.lblMedida1.Name = "lblMedida1"
        Me.lblMedida1.Size = New System.Drawing.Size(70, 16)
        Me.lblMedida1.TabIndex = 31
        Me.lblMedida1.Tag = ""
        Me.lblMedida1.Text = "Medida 1:"
        '
        'btnLimparApontamento
        '
        Me.btnLimparApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimparApontamento.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnLimparApontamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLimparApontamento.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnLimparApontamento.Location = New System.Drawing.Point(796, 103)
        Me.btnLimparApontamento.Name = "btnLimparApontamento"
        Me.btnLimparApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnLimparApontamento.Size = New System.Drawing.Size(91, 23)
        Me.btnLimparApontamento.TabIndex = 9
        Me.btnLimparApontamento.Text = "Limpar"
        Me.btnLimparApontamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirApontamento
        '
        Me.btnExcluirApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirApontamento.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirApontamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirApontamento.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirApontamento.Location = New System.Drawing.Point(796, 74)
        Me.btnExcluirApontamento.Name = "btnExcluirApontamento"
        Me.btnExcluirApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirApontamento.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirApontamento.TabIndex = 8
        Me.btnExcluirApontamento.Text = "Excluir"
        Me.btnExcluirApontamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirApontamento
        '
        Me.btnInserirApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirApontamento.Image = CType(resources.GetObject("btnInserirApontamento.Image"), System.Drawing.Image)
        Me.btnInserirApontamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirApontamento.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirApontamento.Location = New System.Drawing.Point(796, 45)
        Me.btnInserirApontamento.Name = "btnInserirApontamento"
        Me.btnInserirApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirApontamento.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirApontamento.TabIndex = 7
        Me.btnInserirApontamento.Text = "Inserir"
        Me.btnInserirApontamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Location = New System.Drawing.Point(9, 481)
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
        'usrEstApontamentoSobra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstApontamentoSobra"
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
        CType(Me.picLegendaApontado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpApontamento.ResumeLayout(False)
        Me.grpApontamento.PerformLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
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
    Friend WithEvents lblDataMovimentacaoFiltro As Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpApontamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirApontamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirApontamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnLimparApontamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblQuantidadeRE As Label
    Friend WithEvents txtQuantidadeRE As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtDescricaoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoProduto As Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As Label
    Friend WithEvents lblQuantidadeMovimentacaoEstoque As Label
    Friend WithEvents txtQuantidadeMovimentacaoEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNumeroRE As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRE As Label
    Friend WithEvents txtCodigoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProduto As Label
    Friend WithEvents lblQuantidadeDiferenca As Label
    Friend WithEvents txtQuantidadeDiferenca As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtUnidadeMedida As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblUnidadeMedida As Label
    Friend WithEvents txtDataMovimentacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataMovimentacao As Label
    Friend WithEvents txtMedida1 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida3 As Label
    Friend WithEvents txtMedida2 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboGrupoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItemRequisicaoListaMaterial As Label
    Friend WithEvents txtMedida3 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida2 As Label
    Friend WithEvents lblMedida4 As Label
    Friend WithEvents lblUnidadeMedidaApontamento As Label
    Friend WithEvents txtMedida4 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida1 As Label
    Friend WithEvents lblDescricaoApontamento As Label
    Friend WithEvents txtDescricaoApontamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblQuantidadeApontamento As Label
    Friend WithEvents txtQuantidadeApontamento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProdutoNovoRequisicaoListaMaterial As Label
    Friend WithEvents txtCodigoProdutoNovo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPesoEspecifico As Label
    Friend WithEvents txtPesoEspecifico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtPeso As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents picLegendaApontado As PictureBox
    Friend WithEvents lblLegendaApontado As Label
End Class
