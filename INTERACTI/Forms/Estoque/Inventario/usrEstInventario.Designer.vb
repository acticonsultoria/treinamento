<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstInventario))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdInventario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdInventario_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaAguardandoAprovacao = New System.Windows.Forms.PictureBox()
        Me.picLegendaAprovado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaReprovado = New System.Windows.Forms.Label()
        Me.picLegendaReprovado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAprovado = New System.Windows.Forms.Label()
        Me.lblLegendaAguardandoAprovacao = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControles = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.cboDepositoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepositoFiltro = New System.Windows.Forms.Label()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboUsuarioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUsuarioFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.cboNumeroInventarioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroInventarioFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInventarioTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInventarioInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInventarioFiltro = New System.Windows.Forms.Label()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridInventario = New System.Windows.Forms.Button()
        Me.btnAgruparGridInventario = New System.Windows.Forms.Button()
        Me.grpLegendaInventario = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaRegistroValido = New System.Windows.Forms.Label()
        Me.picLegendaRegistroValido = New System.Windows.Forms.PictureBox()
        Me.lblLegendaRegistroInvalido = New System.Windows.Forms.Label()
        Me.picLegendaRegistroInvalido = New System.Windows.Forms.PictureBox()
        Me.btnConfigurarGridInventario = New System.Windows.Forms.Button()
        Me.grpDadosArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPlanilha = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlanilha = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaCustoMedio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaCustoMedio = New System.Windows.Forms.Label()
        Me.txtLinhaInicio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtArquivoExcel = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLinhaInicio = New System.Windows.Forms.Label()
        Me.btnArquivoExcel = New Janus.Windows.EditControls.UIButton()
        Me.cboConfiguracaoColunaQuantidade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaQuantidade = New System.Windows.Forms.Label()
        Me.lblConfiguracaoColunaCodigoProduto = New System.Windows.Forms.Label()
        Me.lblArquivoExcel = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.cboConfiguracaoColunaLote = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaLote = New System.Windows.Forms.Label()
        Me.grdInventario = New Janus.Windows.GridEX.GridEX()
        Me.grpControles1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosInventario = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboUnidadeMedidaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaFiltro = New System.Windows.Forms.Label()
        Me.cboStatus = New Janus.Windows.EditControls.UIComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboMarcaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMarcaFiltro = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.dtpDataInventario = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnCadastrarUsuario = New System.Windows.Forms.Button()
        Me.lblDataInventario = New System.Windows.Forms.Label()
        Me.cboNumeroInventario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroInventario = New System.Windows.Forms.Label()
        Me.cboUsuario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.cboPrimeiraContagem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPrimeiraContagem = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaDataFabricacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaDataFabricacao = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaDataValidade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaDataValidade = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaLocalizacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaLocalizacao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaAguardandoAprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAprovado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaReprovado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControles.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpLegendaInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegendaInventario.SuspendLayout()
        CType(Me.picLegendaRegistroValido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaRegistroInvalido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosArquivo.SuspendLayout()
        CType(Me.grdInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControles1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControles1.SuspendLayout()
        CType(Me.grpDadosInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosInventario.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpControles)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Inventário"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoAprovacao)
        Me.grpLegenda.Controls.Add(Me.picLegendaAprovado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaReprovado)
        Me.grpLegenda.Controls.Add(Me.picLegendaReprovado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAprovado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoAprovacao)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(321, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaAguardandoAprovacao
        '
        Me.picLegendaAguardandoAprovacao.BackColor = System.Drawing.Color.DarkGray
        Me.picLegendaAguardandoAprovacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoAprovacao.Location = New System.Drawing.Point(9, 23)
        Me.picLegendaAguardandoAprovacao.Name = "picLegendaAguardandoAprovacao"
        Me.picLegendaAguardandoAprovacao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAguardandoAprovacao.TabIndex = 14
        Me.picLegendaAguardandoAprovacao.TabStop = False
        '
        'picLegendaAprovado
        '
        Me.picLegendaAprovado.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaAprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAprovado.Location = New System.Drawing.Point(157, 23)
        Me.picLegendaAprovado.Name = "picLegendaAprovado"
        Me.picLegendaAprovado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAprovado.TabIndex = 12
        Me.picLegendaAprovado.TabStop = False
        '
        'lblLegendaReprovado
        '
        Me.lblLegendaReprovado.AutoSize = True
        Me.lblLegendaReprovado.Location = New System.Drawing.Point(256, 23)
        Me.lblLegendaReprovado.Name = "lblLegendaReprovado"
        Me.lblLegendaReprovado.Size = New System.Drawing.Size(60, 14)
        Me.lblLegendaReprovado.TabIndex = 2
        Me.lblLegendaReprovado.Text = "Reprovado"
        '
        'picLegendaReprovado
        '
        Me.picLegendaReprovado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaReprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaReprovado.Location = New System.Drawing.Point(237, 23)
        Me.picLegendaReprovado.Name = "picLegendaReprovado"
        Me.picLegendaReprovado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaReprovado.TabIndex = 8
        Me.picLegendaReprovado.TabStop = False
        '
        'lblLegendaAprovado
        '
        Me.lblLegendaAprovado.AutoSize = True
        Me.lblLegendaAprovado.Location = New System.Drawing.Point(176, 23)
        Me.lblLegendaAprovado.Name = "lblLegendaAprovado"
        Me.lblLegendaAprovado.Size = New System.Drawing.Size(55, 14)
        Me.lblLegendaAprovado.TabIndex = 1
        Me.lblLegendaAprovado.Text = "Aprovado"
        '
        'lblLegendaAguardandoAprovacao
        '
        Me.lblLegendaAguardandoAprovacao.AutoSize = True
        Me.lblLegendaAguardandoAprovacao.Location = New System.Drawing.Point(28, 23)
        Me.lblLegendaAguardandoAprovacao.Name = "lblLegendaAguardandoAprovacao"
        Me.lblLegendaAguardandoAprovacao.Size = New System.Drawing.Size(123, 14)
        Me.lblLegendaAguardandoAprovacao.TabIndex = 0
        Me.lblLegendaAguardandoAprovacao.Text = "Aguardando Aprovação"
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.CellToolTipText = "Duplo clique para visualizar o registro"
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Transparent
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControles
        '
        Me.grpControles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControles.BackColor = System.Drawing.Color.Transparent
        Me.grpControles.Controls.Add(Me.btnNovo)
        Me.grpControles.Controls.Add(Me.btnSair)
        Me.grpControles.Location = New System.Drawing.Point(338, 483)
        Me.grpControles.Name = "grpControles"
        Me.grpControles.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControles.Size = New System.Drawing.Size(567, 51)
        Me.grpControles.TabIndex = 6
        Me.grpControles.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(370, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(467, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboDepositoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDepositoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboUsuarioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblUsuarioFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.cboNumeroInventarioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroInventarioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInventarioTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInventarioInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataInventarioFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(359, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(409, 20)
        Me.cboStatusFiltro.TabIndex = 10
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'cboDepositoFiltro
        '
        Me.cboDepositoFiltro.AutoSize = False
        Me.cboDepositoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboDepositoFiltro.Name = "cboDepositoFiltro"
        Me.cboDepositoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepositoFiltro.Size = New System.Drawing.Size(344, 20)
        Me.cboDepositoFiltro.TabIndex = 8
        '
        'lblDepositoFiltro
        '
        Me.lblDepositoFiltro.AutoSize = True
        Me.lblDepositoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDepositoFiltro.Name = "lblDepositoFiltro"
        Me.lblDepositoFiltro.Size = New System.Drawing.Size(52, 14)
        Me.lblDepositoFiltro.TabIndex = 7
        Me.lblDepositoFiltro.Text = "Depósito:"
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatusFiltro.Location = New System.Drawing.Point(356, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 9
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboUsuarioFiltro
        '
        Me.cboUsuarioFiltro.AutoSize = False
        Me.cboUsuarioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUsuarioFiltro.Location = New System.Drawing.Point(359, 34)
        Me.cboUsuarioFiltro.Name = "cboUsuarioFiltro"
        Me.cboUsuarioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUsuarioFiltro.Size = New System.Drawing.Size(409, 20)
        Me.cboUsuarioFiltro.TabIndex = 5
        '
        'lblUsuarioFiltro
        '
        Me.lblUsuarioFiltro.AutoSize = True
        Me.lblUsuarioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUsuarioFiltro.Location = New System.Drawing.Point(356, 17)
        Me.lblUsuarioFiltro.Name = "lblUsuarioFiltro"
        Me.lblUsuarioFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuarioFiltro.TabIndex = 6
        Me.lblUsuarioFiltro.Text = "Usuário:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboNumeroInventarioFiltro
        '
        Me.cboNumeroInventarioFiltro.AutoSize = False
        Me.cboNumeroInventarioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroInventarioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboNumeroInventarioFiltro.Name = "cboNumeroInventarioFiltro"
        Me.cboNumeroInventarioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroInventarioFiltro.Size = New System.Drawing.Size(116, 20)
        Me.cboNumeroInventarioFiltro.TabIndex = 1
        '
        'lblNumeroInventarioFiltro
        '
        Me.lblNumeroInventarioFiltro.AutoSize = True
        Me.lblNumeroInventarioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroInventarioFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroInventarioFiltro.Name = "lblNumeroInventarioFiltro"
        Me.lblNumeroInventarioFiltro.Size = New System.Drawing.Size(72, 14)
        Me.lblNumeroInventarioFiltro.TabIndex = 0
        Me.lblNumeroInventarioFiltro.Text = "Nº Inventário:"
        '
        'dtpDataInventarioTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataInventarioTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInventarioTerminoFiltro.Location = New System.Drawing.Point(245, 34)
        Me.dtpDataInventarioTerminoFiltro.Name = "dtpDataInventarioTerminoFiltro"
        Me.dtpDataInventarioTerminoFiltro.ShowCheckBox = True
        Me.dtpDataInventarioTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInventarioTerminoFiltro.TabIndex = 4
        '
        'dtpDataInventarioInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInventarioInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInventarioInicioFiltro.Location = New System.Drawing.Point(131, 34)
        Me.dtpDataInventarioInicioFiltro.Name = "dtpDataInventarioInicioFiltro"
        Me.dtpDataInventarioInicioFiltro.ShowCheckBox = True
        Me.dtpDataInventarioInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInventarioInicioFiltro.TabIndex = 3
        '
        'lblDataInventarioFiltro
        '
        Me.lblDataInventarioFiltro.AutoSize = True
        Me.lblDataInventarioFiltro.Location = New System.Drawing.Point(128, 17)
        Me.lblDataInventarioFiltro.Name = "lblDataInventarioFiltro"
        Me.lblDataInventarioFiltro.Size = New System.Drawing.Size(82, 14)
        Me.lblDataInventarioFiltro.TabIndex = 2
        Me.lblDataInventarioFiltro.Text = "Data Inventário:"
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridInventario)
        Me.pagDados.Controls.Add(Me.btnAgruparGridInventario)
        Me.pagDados.Controls.Add(Me.grpLegendaInventario)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridInventario)
        Me.pagDados.Controls.Add(Me.grpDadosArquivo)
        Me.pagDados.Controls.Add(Me.grdInventario)
        Me.pagDados.Controls.Add(Me.grpControles1)
        Me.pagDados.Controls.Add(Me.grpDadosInventario)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Inventário"
        '
        'btnExcelGridInventario
        '
        Me.btnExcelGridInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridInventario.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridInventario.FlatAppearance.BorderSize = 0
        Me.btnExcelGridInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridInventario.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridInventario.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridInventario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridInventario.Name = "btnExcelGridInventario"
        Me.btnExcelGridInventario.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridInventario.TabIndex = 5
        Me.btnExcelGridInventario.TabStop = False
        Me.btnExcelGridInventario.UseVisualStyleBackColor = False
        '
        'btnAgruparGridInventario
        '
        Me.btnAgruparGridInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridInventario.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridInventario.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridInventario.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridInventario.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridInventario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridInventario.Name = "btnAgruparGridInventario"
        Me.btnAgruparGridInventario.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridInventario.TabIndex = 4
        Me.btnAgruparGridInventario.TabStop = False
        Me.btnAgruparGridInventario.UseVisualStyleBackColor = False
        '
        'grpLegendaInventario
        '
        Me.grpLegendaInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegendaInventario.BackColor = System.Drawing.Color.Transparent
        Me.grpLegendaInventario.Controls.Add(Me.lblLegendaRegistroValido)
        Me.grpLegendaInventario.Controls.Add(Me.picLegendaRegistroValido)
        Me.grpLegendaInventario.Controls.Add(Me.lblLegendaRegistroInvalido)
        Me.grpLegendaInventario.Controls.Add(Me.picLegendaRegistroInvalido)
        Me.grpLegendaInventario.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegendaInventario.Location = New System.Drawing.Point(8, 483)
        Me.grpLegendaInventario.Name = "grpLegendaInventario"
        Me.grpLegendaInventario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegendaInventario.Size = New System.Drawing.Size(368, 51)
        Me.grpLegendaInventario.TabIndex = 6
        Me.grpLegendaInventario.Text = "Legenda"
        Me.grpLegendaInventario.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaRegistroValido
        '
        Me.lblLegendaRegistroValido.AutoSize = True
        Me.lblLegendaRegistroValido.Location = New System.Drawing.Point(285, 23)
        Me.lblLegendaRegistroValido.Name = "lblLegendaRegistroValido"
        Me.lblLegendaRegistroValido.Size = New System.Drawing.Size(80, 14)
        Me.lblLegendaRegistroValido.TabIndex = 1
        Me.lblLegendaRegistroValido.Text = "Registro Válido"
        '
        'picLegendaRegistroValido
        '
        Me.picLegendaRegistroValido.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaRegistroValido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaRegistroValido.Location = New System.Drawing.Point(266, 23)
        Me.picLegendaRegistroValido.Name = "picLegendaRegistroValido"
        Me.picLegendaRegistroValido.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaRegistroValido.TabIndex = 10
        Me.picLegendaRegistroValido.TabStop = False
        '
        'lblLegendaRegistroInvalido
        '
        Me.lblLegendaRegistroInvalido.AutoSize = True
        Me.lblLegendaRegistroInvalido.Location = New System.Drawing.Point(28, 23)
        Me.lblLegendaRegistroInvalido.Name = "lblLegendaRegistroInvalido"
        Me.lblLegendaRegistroInvalido.Size = New System.Drawing.Size(232, 14)
        Me.lblLegendaRegistroInvalido.TabIndex = 0
        Me.lblLegendaRegistroInvalido.Text = "Registro Inválido (Não considera no Inventário)"
        '
        'picLegendaRegistroInvalido
        '
        Me.picLegendaRegistroInvalido.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaRegistroInvalido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaRegistroInvalido.Location = New System.Drawing.Point(9, 23)
        Me.picLegendaRegistroInvalido.Name = "picLegendaRegistroInvalido"
        Me.picLegendaRegistroInvalido.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaRegistroInvalido.TabIndex = 8
        Me.picLegendaRegistroInvalido.TabStop = False
        '
        'btnConfigurarGridInventario
        '
        Me.btnConfigurarGridInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridInventario.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridInventario.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridInventario.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridInventario.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridInventario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridInventario.Name = "btnConfigurarGridInventario"
        Me.btnConfigurarGridInventario.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridInventario.TabIndex = 3
        Me.btnConfigurarGridInventario.TabStop = False
        Me.btnConfigurarGridInventario.UseVisualStyleBackColor = False
        '
        'grpDadosArquivo
        '
        Me.grpDadosArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaLocalizacao)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaLocalizacao)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaDataValidade)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaDataValidade)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaDataFabricacao)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaDataFabricacao)
        Me.grpDadosArquivo.Controls.Add(Me.txtPlanilha)
        Me.grpDadosArquivo.Controls.Add(Me.lblPlanilha)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaCustoMedio)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaCustoMedio)
        Me.grpDadosArquivo.Controls.Add(Me.txtLinhaInicio)
        Me.grpDadosArquivo.Controls.Add(Me.txtArquivoExcel)
        Me.grpDadosArquivo.Controls.Add(Me.lblLinhaInicio)
        Me.grpDadosArquivo.Controls.Add(Me.btnArquivoExcel)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaQuantidade)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaQuantidade)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaCodigoProduto)
        Me.grpDadosArquivo.Controls.Add(Me.lblArquivoExcel)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaCodigoProduto)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaLote)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaLote)
        Me.grpDadosArquivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosArquivo.Location = New System.Drawing.Point(8, 110)
        Me.grpDadosArquivo.Name = "grpDadosArquivo"
        Me.grpDadosArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosArquivo.Size = New System.Drawing.Size(897, 104)
        Me.grpDadosArquivo.TabIndex = 1
        Me.grpDadosArquivo.Text = "Configuração da Planilha Excel"
        Me.grpDadosArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosArquivo.VisualStyleManager = Me.vsmMain
        '
        'txtPlanilha
        '
        Me.txtPlanilha.Location = New System.Drawing.Point(9, 34)
        Me.txtPlanilha.MaxLength = 35
        Me.txtPlanilha.Name = "txtPlanilha"
        Me.txtPlanilha.Size = New System.Drawing.Size(100, 20)
        Me.txtPlanilha.TabIndex = 1
        '
        'lblPlanilha
        '
        Me.lblPlanilha.AutoSize = True
        Me.lblPlanilha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlanilha.Location = New System.Drawing.Point(6, 17)
        Me.lblPlanilha.Name = "lblPlanilha"
        Me.lblPlanilha.Size = New System.Drawing.Size(46, 14)
        Me.lblPlanilha.TabIndex = 0
        Me.lblPlanilha.Text = "Planilha:"
        '
        'cboConfiguracaoColunaCustoMedio
        '
        Me.cboConfiguracaoColunaCustoMedio.AutoSize = False
        Me.cboConfiguracaoColunaCustoMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaCustoMedio.Location = New System.Drawing.Point(597, 34)
        Me.cboConfiguracaoColunaCustoMedio.Name = "cboConfiguracaoColunaCustoMedio"
        Me.cboConfiguracaoColunaCustoMedio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaCustoMedio.Size = New System.Drawing.Size(93, 20)
        Me.cboConfiguracaoColunaCustoMedio.TabIndex = 13
        '
        'lblConfiguracaoColunaCustoMedio
        '
        Me.lblConfiguracaoColunaCustoMedio.AutoSize = True
        Me.lblConfiguracaoColunaCustoMedio.Location = New System.Drawing.Point(594, 17)
        Me.lblConfiguracaoColunaCustoMedio.Name = "lblConfiguracaoColunaCustoMedio"
        Me.lblConfiguracaoColunaCustoMedio.Size = New System.Drawing.Size(69, 14)
        Me.lblConfiguracaoColunaCustoMedio.TabIndex = 12
        Me.lblConfiguracaoColunaCustoMedio.Text = "Custo Médio:"
        '
        'txtLinhaInicio
        '
        Me.txtLinhaInicio.DecimalDigits = 0
        Me.txtLinhaInicio.Location = New System.Drawing.Point(115, 34)
        Me.txtLinhaInicio.Name = "txtLinhaInicio"
        Me.txtLinhaInicio.Size = New System.Drawing.Size(78, 20)
        Me.txtLinhaInicio.TabIndex = 3
        Me.txtLinhaInicio.Text = "0"
        Me.txtLinhaInicio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtArquivoExcel
        '
        Me.txtArquivoExcel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivoExcel.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivoExcel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivoExcel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivoExcel.Location = New System.Drawing.Point(9, 74)
        Me.txtArquivoExcel.MaxLength = 50
        Me.txtArquivoExcel.Name = "txtArquivoExcel"
        Me.txtArquivoExcel.ReadOnly = True
        Me.txtArquivoExcel.Size = New System.Drawing.Size(860, 20)
        Me.txtArquivoExcel.TabIndex = 19
        Me.txtArquivoExcel.TabStop = False
        '
        'lblLinhaInicio
        '
        Me.lblLinhaInicio.AutoSize = True
        Me.lblLinhaInicio.Location = New System.Drawing.Point(112, 17)
        Me.lblLinhaInicio.Name = "lblLinhaInicio"
        Me.lblLinhaInicio.Size = New System.Drawing.Size(63, 14)
        Me.lblLinhaInicio.TabIndex = 2
        Me.lblLinhaInicio.Text = "Linha Início:"
        '
        'btnArquivoExcel
        '
        Me.btnArquivoExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivoExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivoExcel.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnArquivoExcel.Location = New System.Drawing.Point(868, 74)
        Me.btnArquivoExcel.Name = "btnArquivoExcel"
        Me.btnArquivoExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivoExcel.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivoExcel.TabIndex = 20
        Me.btnArquivoExcel.Text = "..."
        Me.btnArquivoExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboConfiguracaoColunaQuantidade
        '
        Me.cboConfiguracaoColunaQuantidade.AutoSize = False
        Me.cboConfiguracaoColunaQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaQuantidade.Location = New System.Drawing.Point(498, 34)
        Me.cboConfiguracaoColunaQuantidade.Name = "cboConfiguracaoColunaQuantidade"
        Me.cboConfiguracaoColunaQuantidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaQuantidade.Size = New System.Drawing.Size(93, 20)
        Me.cboConfiguracaoColunaQuantidade.TabIndex = 11
        '
        'lblConfiguracaoColunaQuantidade
        '
        Me.lblConfiguracaoColunaQuantidade.AutoSize = True
        Me.lblConfiguracaoColunaQuantidade.Location = New System.Drawing.Point(495, 17)
        Me.lblConfiguracaoColunaQuantidade.Name = "lblConfiguracaoColunaQuantidade"
        Me.lblConfiguracaoColunaQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblConfiguracaoColunaQuantidade.TabIndex = 10
        Me.lblConfiguracaoColunaQuantidade.Text = "Quantidade:"
        '
        'lblConfiguracaoColunaCodigoProduto
        '
        Me.lblConfiguracaoColunaCodigoProduto.AutoSize = True
        Me.lblConfiguracaoColunaCodigoProduto.Location = New System.Drawing.Point(190, 17)
        Me.lblConfiguracaoColunaCodigoProduto.Name = "lblConfiguracaoColunaCodigoProduto"
        Me.lblConfiguracaoColunaCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblConfiguracaoColunaCodigoProduto.TabIndex = 4
        Me.lblConfiguracaoColunaCodigoProduto.Text = "Código Produto:"
        '
        'lblArquivoExcel
        '
        Me.lblArquivoExcel.AutoSize = True
        Me.lblArquivoExcel.Location = New System.Drawing.Point(6, 57)
        Me.lblArquivoExcel.Name = "lblArquivoExcel"
        Me.lblArquivoExcel.Size = New System.Drawing.Size(77, 14)
        Me.lblArquivoExcel.TabIndex = 18
        Me.lblArquivoExcel.Text = "Arquivo Excel:"
        '
        'cboConfiguracaoColunaCodigoProduto
        '
        Me.cboConfiguracaoColunaCodigoProduto.AutoSize = False
        Me.cboConfiguracaoColunaCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaCodigoProduto.Location = New System.Drawing.Point(199, 34)
        Me.cboConfiguracaoColunaCodigoProduto.Name = "cboConfiguracaoColunaCodigoProduto"
        Me.cboConfiguracaoColunaCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaCodigoProduto.Size = New System.Drawing.Size(93, 20)
        Me.cboConfiguracaoColunaCodigoProduto.TabIndex = 5
        '
        'cboConfiguracaoColunaLote
        '
        Me.cboConfiguracaoColunaLote.AutoSize = False
        Me.cboConfiguracaoColunaLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaLote.Location = New System.Drawing.Point(298, 34)
        Me.cboConfiguracaoColunaLote.Name = "cboConfiguracaoColunaLote"
        Me.cboConfiguracaoColunaLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaLote.Size = New System.Drawing.Size(93, 20)
        Me.cboConfiguracaoColunaLote.TabIndex = 7
        '
        'lblConfiguracaoColunaLote
        '
        Me.lblConfiguracaoColunaLote.AutoSize = True
        Me.lblConfiguracaoColunaLote.Location = New System.Drawing.Point(295, 17)
        Me.lblConfiguracaoColunaLote.Name = "lblConfiguracaoColunaLote"
        Me.lblConfiguracaoColunaLote.Size = New System.Drawing.Size(31, 14)
        Me.lblConfiguracaoColunaLote.TabIndex = 6
        Me.lblConfiguracaoColunaLote.Text = "Lote:"
        '
        'grdInventario
        '
        Me.grdInventario.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdInventario.AlternatingColors = True
        Me.grdInventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdInventario_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdInventario_DesignTimeLayout_Reference_0.Instance"), Object)
        grdInventario_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdInventario_DesignTimeLayout_Reference_0})
        grdInventario_DesignTimeLayout.LayoutString = resources.GetString("grdInventario_DesignTimeLayout.LayoutString")
        Me.grdInventario.DesignTimeLayout = grdInventario_DesignTimeLayout
        Me.grdInventario.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdInventario.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdInventario.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdInventario.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdInventario.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdInventario.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdInventario.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdInventario.GroupByBoxVisible = False
        Me.grdInventario.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdInventario.Location = New System.Drawing.Point(8, 223)
        Me.grdInventario.Name = "grdInventario"
        Me.grdInventario.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdInventario.RecordNavigator = True
        Me.grdInventario.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdInventario.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdInventario.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdInventario.Size = New System.Drawing.Size(897, 257)
        Me.grdInventario.TabIndex = 2
        Me.grdInventario.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdInventario.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdInventario.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdInventario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdInventario.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdInventario.VisualStyleManager = Me.vsmMain
        '
        'grpControles1
        '
        Me.grpControles1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControles1.BackColor = System.Drawing.Color.Transparent
        Me.grpControles1.Controls.Add(Me.btnImprimir)
        Me.grpControles1.Controls.Add(Me.btnVoltar)
        Me.grpControles1.Controls.Add(Me.btnSalvar)
        Me.grpControles1.Controls.Add(Me.btnNovo1)
        Me.grpControles1.Location = New System.Drawing.Point(385, 483)
        Me.grpControles1.Name = "grpControles1"
        Me.grpControles1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControles1.Size = New System.Drawing.Size(520, 51)
        Me.grpControles1.TabIndex = 7
        Me.grpControles1.VisualStyleManager = Me.vsmMain
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(129, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(420, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 3
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(323, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(226, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 1
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDadosInventario
        '
        Me.grpDadosInventario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosInventario.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosInventario.Controls.Add(Me.cboUnidadeMedidaFiltro)
        Me.grpDadosInventario.Controls.Add(Me.lblUnidadeMedidaFiltro)
        Me.grpDadosInventario.Controls.Add(Me.cboStatus)
        Me.grpDadosInventario.Controls.Add(Me.lblStatus)
        Me.grpDadosInventario.Controls.Add(Me.cboMarcaFiltro)
        Me.grpDadosInventario.Controls.Add(Me.lblMarcaFiltro)
        Me.grpDadosInventario.Controls.Add(Me.cboDeposito)
        Me.grpDadosInventario.Controls.Add(Me.lblDeposito)
        Me.grpDadosInventario.Controls.Add(Me.dtpDataInventario)
        Me.grpDadosInventario.Controls.Add(Me.btnCadastrarUsuario)
        Me.grpDadosInventario.Controls.Add(Me.lblDataInventario)
        Me.grpDadosInventario.Controls.Add(Me.cboNumeroInventario)
        Me.grpDadosInventario.Controls.Add(Me.lblNumeroInventario)
        Me.grpDadosInventario.Controls.Add(Me.cboUsuario)
        Me.grpDadosInventario.Controls.Add(Me.lblUsuario)
        Me.grpDadosInventario.Controls.Add(Me.cboPrimeiraContagem)
        Me.grpDadosInventario.Controls.Add(Me.lblPrimeiraContagem)
        Me.grpDadosInventario.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosInventario.Name = "grpDadosInventario"
        Me.grpDadosInventario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosInventario.Size = New System.Drawing.Size(897, 104)
        Me.grpDadosInventario.TabIndex = 0
        Me.grpDadosInventario.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosInventario.VisualStyleManager = Me.vsmMain
        '
        'cboUnidadeMedidaFiltro
        '
        Me.cboUnidadeMedidaFiltro.AutoSize = False
        Me.cboUnidadeMedidaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaFiltro.Location = New System.Drawing.Point(561, 74)
        Me.cboUnidadeMedidaFiltro.Name = "cboUnidadeMedidaFiltro"
        Me.cboUnidadeMedidaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaFiltro.Size = New System.Drawing.Size(125, 20)
        Me.cboUnidadeMedidaFiltro.TabIndex = 16
        '
        'lblUnidadeMedidaFiltro
        '
        Me.lblUnidadeMedidaFiltro.AutoSize = True
        Me.lblUnidadeMedidaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedidaFiltro.Location = New System.Drawing.Point(558, 57)
        Me.lblUnidadeMedidaFiltro.Name = "lblUnidadeMedidaFiltro"
        Me.lblUnidadeMedidaFiltro.Size = New System.Drawing.Size(125, 14)
        Me.lblUnidadeMedidaFiltro.TabIndex = 15
        Me.lblUnidadeMedidaFiltro.Text = "Und. Medida Referência:"
        '
        'cboStatus
        '
        Me.cboStatus.AutoSize = False
        Me.cboStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatus.Location = New System.Drawing.Point(285, 74)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatus.Size = New System.Drawing.Size(270, 20)
        Me.cboStatus.TabIndex = 14
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatus.Location = New System.Drawing.Point(282, 57)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(41, 14)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status:"
        '
        'cboMarcaFiltro
        '
        Me.cboMarcaFiltro.AutoSize = False
        Me.cboMarcaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMarcaFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboMarcaFiltro.Name = "cboMarcaFiltro"
        Me.cboMarcaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMarcaFiltro.Size = New System.Drawing.Size(270, 20)
        Me.cboMarcaFiltro.TabIndex = 12
        '
        'lblMarcaFiltro
        '
        Me.lblMarcaFiltro.AutoSize = True
        Me.lblMarcaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcaFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblMarcaFiltro.Name = "lblMarcaFiltro"
        Me.lblMarcaFiltro.Size = New System.Drawing.Size(40, 14)
        Me.lblMarcaFiltro.TabIndex = 11
        Me.lblMarcaFiltro.Text = "Marca:"
        '
        'cboDeposito
        '
        Me.cboDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(561, 34)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(213, 20)
        Me.cboDeposito.TabIndex = 8
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(558, 17)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 7
        Me.lblDeposito.Text = "Depósito:"
        '
        'dtpDataInventario
        '
        Me.dtpDataInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataInventario.DropDownCalendar.Name = ""
        Me.dtpDataInventario.Location = New System.Drawing.Point(780, 34)
        Me.dtpDataInventario.Name = "dtpDataInventario"
        Me.dtpDataInventario.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInventario.TabIndex = 10
        '
        'btnCadastrarUsuario
        '
        Me.btnCadastrarUsuario.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUsuario.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUsuario.Location = New System.Drawing.Point(285, 18)
        Me.btnCadastrarUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUsuario.Name = "btnCadastrarUsuario"
        Me.btnCadastrarUsuario.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUsuario.TabIndex = 4
        Me.btnCadastrarUsuario.TabStop = False
        Me.btnCadastrarUsuario.UseVisualStyleBackColor = True
        '
        'lblDataInventario
        '
        Me.lblDataInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataInventario.AutoSize = True
        Me.lblDataInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataInventario.Location = New System.Drawing.Point(777, 17)
        Me.lblDataInventario.Name = "lblDataInventario"
        Me.lblDataInventario.Size = New System.Drawing.Size(82, 14)
        Me.lblDataInventario.TabIndex = 9
        Me.lblDataInventario.Text = "Data Inventário:"
        '
        'cboNumeroInventario
        '
        Me.cboNumeroInventario.AutoSize = False
        Me.cboNumeroInventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroInventario.Location = New System.Drawing.Point(147, 34)
        Me.cboNumeroInventario.Name = "cboNumeroInventario"
        Me.cboNumeroInventario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroInventario.Size = New System.Drawing.Size(132, 20)
        Me.cboNumeroInventario.TabIndex = 3
        '
        'lblNumeroInventario
        '
        Me.lblNumeroInventario.AutoSize = True
        Me.lblNumeroInventario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroInventario.Location = New System.Drawing.Point(144, 17)
        Me.lblNumeroInventario.Name = "lblNumeroInventario"
        Me.lblNumeroInventario.Size = New System.Drawing.Size(72, 14)
        Me.lblNumeroInventario.TabIndex = 2
        Me.lblNumeroInventario.Text = "Nº Inventário:"
        '
        'cboUsuario
        '
        Me.cboUsuario.AutoSize = False
        Me.cboUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUsuario.Location = New System.Drawing.Point(285, 34)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUsuario.Size = New System.Drawing.Size(270, 20)
        Me.cboUsuario.TabIndex = 6
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUsuario.Location = New System.Drawing.Point(301, 17)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "Usuário:"
        '
        'cboPrimeiraContagem
        '
        Me.cboPrimeiraContagem.AutoSize = False
        Me.cboPrimeiraContagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPrimeiraContagem.Location = New System.Drawing.Point(9, 34)
        Me.cboPrimeiraContagem.Name = "cboPrimeiraContagem"
        Me.cboPrimeiraContagem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPrimeiraContagem.Size = New System.Drawing.Size(132, 20)
        Me.cboPrimeiraContagem.TabIndex = 1
        '
        'lblPrimeiraContagem
        '
        Me.lblPrimeiraContagem.AutoSize = True
        Me.lblPrimeiraContagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrimeiraContagem.Location = New System.Drawing.Point(6, 17)
        Me.lblPrimeiraContagem.Name = "lblPrimeiraContagem"
        Me.lblPrimeiraContagem.Size = New System.Drawing.Size(99, 14)
        Me.lblPrimeiraContagem.TabIndex = 0
        Me.lblPrimeiraContagem.Text = "Primeira Contagem:"
        '
        'cboConfiguracaoColunaDataFabricacao
        '
        Me.cboConfiguracaoColunaDataFabricacao.AutoSize = False
        Me.cboConfiguracaoColunaDataFabricacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaDataFabricacao.Location = New System.Drawing.Point(696, 34)
        Me.cboConfiguracaoColunaDataFabricacao.Name = "cboConfiguracaoColunaDataFabricacao"
        Me.cboConfiguracaoColunaDataFabricacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaDataFabricacao.Size = New System.Drawing.Size(93, 20)
        Me.cboConfiguracaoColunaDataFabricacao.TabIndex = 15
        '
        'lblConfiguracaoColunaDataFabricacao
        '
        Me.lblConfiguracaoColunaDataFabricacao.AutoSize = True
        Me.lblConfiguracaoColunaDataFabricacao.Location = New System.Drawing.Point(693, 17)
        Me.lblConfiguracaoColunaDataFabricacao.Name = "lblConfiguracaoColunaDataFabricacao"
        Me.lblConfiguracaoColunaDataFabricacao.Size = New System.Drawing.Size(89, 14)
        Me.lblConfiguracaoColunaDataFabricacao.TabIndex = 14
        Me.lblConfiguracaoColunaDataFabricacao.Text = "Data Fabricação:"
        '
        'cboConfiguracaoColunaDataValidade
        '
        Me.cboConfiguracaoColunaDataValidade.AutoSize = False
        Me.cboConfiguracaoColunaDataValidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaDataValidade.Location = New System.Drawing.Point(795, 34)
        Me.cboConfiguracaoColunaDataValidade.Name = "cboConfiguracaoColunaDataValidade"
        Me.cboConfiguracaoColunaDataValidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaDataValidade.Size = New System.Drawing.Size(93, 20)
        Me.cboConfiguracaoColunaDataValidade.TabIndex = 17
        '
        'lblConfiguracaoColunaDataValidade
        '
        Me.lblConfiguracaoColunaDataValidade.AutoSize = True
        Me.lblConfiguracaoColunaDataValidade.Location = New System.Drawing.Point(792, 17)
        Me.lblConfiguracaoColunaDataValidade.Name = "lblConfiguracaoColunaDataValidade"
        Me.lblConfiguracaoColunaDataValidade.Size = New System.Drawing.Size(76, 14)
        Me.lblConfiguracaoColunaDataValidade.TabIndex = 16
        Me.lblConfiguracaoColunaDataValidade.Text = "Data Validade:"
        '
        'cboConfiguracaoColunaLocalizacao
        '
        Me.cboConfiguracaoColunaLocalizacao.AutoSize = False
        Me.cboConfiguracaoColunaLocalizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaLocalizacao.Location = New System.Drawing.Point(397, 34)
        Me.cboConfiguracaoColunaLocalizacao.Name = "cboConfiguracaoColunaLocalizacao"
        Me.cboConfiguracaoColunaLocalizacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaLocalizacao.Size = New System.Drawing.Size(95, 20)
        Me.cboConfiguracaoColunaLocalizacao.TabIndex = 9
        '
        'lblConfiguracaoColunaLocalizacao
        '
        Me.lblConfiguracaoColunaLocalizacao.AutoSize = True
        Me.lblConfiguracaoColunaLocalizacao.Location = New System.Drawing.Point(394, 17)
        Me.lblConfiguracaoColunaLocalizacao.Name = "lblConfiguracaoColunaLocalizacao"
        Me.lblConfiguracaoColunaLocalizacao.Size = New System.Drawing.Size(68, 14)
        Me.lblConfiguracaoColunaLocalizacao.TabIndex = 8
        Me.lblConfiguracaoColunaLocalizacao.Text = "Localização:"
        '
        'usrEstInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstInventario"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaAguardandoAprovacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAprovado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaReprovado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControles.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpLegendaInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegendaInventario.ResumeLayout(False)
        Me.grpLegendaInventario.PerformLayout()
        CType(Me.picLegendaRegistroValido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaRegistroInvalido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosArquivo.ResumeLayout(False)
        Me.grpDadosArquivo.PerformLayout()
        CType(Me.grdInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControles1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControles1.ResumeLayout(False)
        CType(Me.grpDadosInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosInventario.ResumeLayout(False)
        Me.grpDadosInventario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControles As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboNumeroInventarioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroInventarioFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdInventario As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControles1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosInventario As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboNumeroInventario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroInventario As System.Windows.Forms.Label
    Friend WithEvents cboUsuario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents cboPrimeiraContagem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPrimeiraContagem As System.Windows.Forms.Label
    Friend WithEvents lblDataInventario As System.Windows.Forms.Label
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboUsuarioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUsuarioFiltro As System.Windows.Forms.Label
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataInventarioFiltro As System.Windows.Forms.Label
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaAguardandoAprovacao As System.Windows.Forms.PictureBox
    Friend WithEvents picLegendaAprovado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaReprovado As System.Windows.Forms.Label
    Friend WithEvents picLegendaReprovado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAprovado As System.Windows.Forms.Label
    Friend WithEvents lblLegendaAguardandoAprovacao As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarUsuario As System.Windows.Forms.Button
    Friend WithEvents grpDadosArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtLinhaInicio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtArquivoExcel As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLinhaInicio As System.Windows.Forms.Label
    Private WithEvents btnArquivoExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboConfiguracaoColunaQuantidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblArquivoExcel As System.Windows.Forms.Label
    Friend WithEvents lblConfiguracaoColunaQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblConfiguracaoColunaCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboConfiguracaoColunaLote As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaLote As System.Windows.Forms.Label
    Friend WithEvents dtpDataInventarioTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInventarioInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInventario As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDepositoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepositoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridInventario As System.Windows.Forms.Button
    Friend WithEvents cboConfiguracaoColunaCustoMedio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaCustoMedio As System.Windows.Forms.Label
    Friend WithEvents grpLegendaInventario As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaRegistroInvalido As System.Windows.Forms.Label
    Friend WithEvents picLegendaRegistroInvalido As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaRegistroValido As System.Windows.Forms.Label
    Friend WithEvents picLegendaRegistroValido As System.Windows.Forms.PictureBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridInventario As System.Windows.Forms.Button
    Friend WithEvents txtPlanilha As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlanilha As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridInventario As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboMarcaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMarcaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatus As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboUnidadeMedidaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaLocalizacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaLocalizacao As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaDataValidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaDataValidade As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaDataFabricacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaDataFabricacao As System.Windows.Forms.Label

End Class
