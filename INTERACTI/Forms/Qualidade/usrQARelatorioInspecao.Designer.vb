<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrQARelatorioInspecao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrQARelatorioInspecao))
        Dim grdQualidade_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdQualidade_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.lblOrdemProducaoFiltro = New System.Windows.Forms.Label()
        Me.txtOrdemProducaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroRIFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblNumeroRIFiltro = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovaInspecao = New Janus.Windows.EditControls.UIButton()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaCaracteristicaAprovada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCaracteristicaReprovada = New System.Windows.Forms.Label()
        Me.lblLegendaCaracteristicaAprovado = New System.Windows.Forms.Label()
        Me.picLegendaCaracteristicaReprovada = New System.Windows.Forms.PictureBox()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblStatusInspecao = New System.Windows.Forms.Label()
        Me.cboStatus = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroRI = New System.Windows.Forms.Label()
        Me.txtNumeroRI = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblQuantidadeInspecao = New System.Windows.Forms.Label()
        Me.txtQuantidadeInspecao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.lblQuantidadeOP = New System.Windows.Forms.Label()
        Me.txtQuantidadeOP = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtData = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovaInspecaoDados = New Janus.Windows.EditControls.UIButton()
        Me.btnUltimoRegistro = New Janus.Windows.EditControls.UIButton()
        Me.btnRegistroAnterior = New Janus.Windows.EditControls.UIButton()
        Me.btnProximoRegistro = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosGerais = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblInspecaoVisual = New System.Windows.Forms.Label()
        Me.txtInspecaoVisual = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.txtFornecedor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCoordenacao = New System.Windows.Forms.Label()
        Me.txtCoordenacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOutros = New System.Windows.Forms.Label()
        Me.txtOutros = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAmbiente = New System.Windows.Forms.Label()
        Me.txtAmbiente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAlinhamento = New System.Windows.Forms.Label()
        Me.txtAlinhamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPintura = New System.Windows.Forms.Label()
        Me.txtPintura = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblIdentificacao = New System.Windows.Forms.Label()
        Me.txtIdentificacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrigem = New System.Windows.Forms.Label()
        Me.txtOrigem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNivelamento = New System.Windows.Forms.Label()
        Me.txtNivelamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNivelInspecao = New System.Windows.Forms.Label()
        Me.txtNivelInspecao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInspecaoDimensional = New System.Windows.Forms.Label()
        Me.txtInspecaoDimensional = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblNormaInspecao = New System.Windows.Forms.Label()
        Me.cboNormaInspecao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroDesenho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDesenho = New System.Windows.Forms.Label()
        Me.lblMascaraInspecao = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cboMascaraInspecao = New Janus.Windows.EditControls.UIComboBox()
        Me.chkProdutoSeriado = New Janus.Windows.EditControls.UICheckBox()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroSerieTermino = New System.Windows.Forms.Label()
        Me.txtRevisao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroSerieTermino = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblRevisao = New System.Windows.Forms.Label()
        Me.lblNumeroSerialInicial = New System.Windows.Forms.Label()
        Me.txtVeiculo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroSerieInicial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblVeiculo = New System.Windows.Forms.Label()
        Me.txtEstagio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNorma = New System.Windows.Forms.Label()
        Me.lblEstagio = New System.Windows.Forms.Label()
        Me.txtNorma = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.pagInspecao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCaracteristicas = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblToleranciaMaxima = New System.Windows.Forms.Label()
        Me.txtToleranciaMaxima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblToleranciaMinima = New System.Windows.Forms.Label()
        Me.txtToleranciaMinima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorEncontrado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtValorNominal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCapacidade = New System.Windows.Forms.Label()
        Me.txtCapacidade = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboEquipamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEquipamento = New System.Windows.Forms.Label()
        Me.lblObservacaoCaracteristica = New System.Windows.Forms.Label()
        Me.txtObservacaoCaracteristica = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValorEncontrado = New System.Windows.Forms.Label()
        Me.lblValorMaximo = New System.Windows.Forms.Label()
        Me.txtValorMaximo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorMinimo = New System.Windows.Forms.Label()
        Me.txtValorMinimo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorNominal = New System.Windows.Forms.Label()
        Me.cboClasseTolerancia = New Janus.Windows.EditControls.UIComboBox()
        Me.lblClasseTolerancia = New System.Windows.Forms.Label()
        Me.cboCaracteristica = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCaracteristica = New System.Windows.Forms.Label()
        Me.btnExcluirCaracteristica = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirCaracteristica = New Janus.Windows.EditControls.UIButton()
        Me.grdQualidade = New Janus.Windows.GridEX.GridEX()
        Me.pagArquivos = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaCaracteristicaAprovada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCaracteristicaReprovada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosGerais.SuspendLayout()
        Me.pagInspecao.SuspendLayout()
        CType(Me.grpCaracteristicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCaracteristicas.SuspendLayout()
        CType(Me.grdQualidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagArquivos.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
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
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Qualidade - Inspeção - Produção"
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
        Me.btnAgruparGrid.TabIndex = 12
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroRIFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblNumeroRIFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 65)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtItemFiltro
        '
        Me.txtItemFiltro.IncludeLiterals = False
        Me.txtItemFiltro.Location = New System.Drawing.Point(419, 34)
        Me.txtItemFiltro.MaxLength = 20
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtItemFiltro.Size = New System.Drawing.Size(230, 20)
        Me.txtItemFiltro.TabIndex = 38
        '
        'lblItemFiltro
        '
        Me.lblItemFiltro.AutoSize = True
        Me.lblItemFiltro.Location = New System.Drawing.Point(416, 17)
        Me.lblItemFiltro.Name = "lblItemFiltro"
        Me.lblItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblItemFiltro.TabIndex = 37
        Me.lblItemFiltro.Text = "Item:"
        '
        'lblOrdemProducaoFiltro
        '
        Me.lblOrdemProducaoFiltro.AutoSize = True
        Me.lblOrdemProducaoFiltro.Location = New System.Drawing.Point(322, 17)
        Me.lblOrdemProducaoFiltro.Name = "lblOrdemProducaoFiltro"
        Me.lblOrdemProducaoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducaoFiltro.TabIndex = 36
        Me.lblOrdemProducaoFiltro.Text = "Ordem Produção:"
        '
        'txtOrdemProducaoFiltro
        '
        Me.txtOrdemProducaoFiltro.IncludeLiterals = False
        Me.txtOrdemProducaoFiltro.Location = New System.Drawing.Point(325, 34)
        Me.txtOrdemProducaoFiltro.MaxLength = 20
        Me.txtOrdemProducaoFiltro.Name = "txtOrdemProducaoFiltro"
        Me.txtOrdemProducaoFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtOrdemProducaoFiltro.Size = New System.Drawing.Size(88, 20)
        Me.txtOrdemProducaoFiltro.TabIndex = 35
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(97, 20)
        Me.dtpDataInicioFiltro.TabIndex = 33
        Me.dtpDataInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(222, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(97, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 34
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(116, 17)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 32
        Me.lblDataFiltro.Text = "Data:"
        '
        'txtNumeroRIFiltro
        '
        Me.txtNumeroRIFiltro.IncludeLiterals = False
        Me.txtNumeroRIFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRIFiltro.MaxLength = 20
        Me.txtNumeroRIFiltro.Name = "txtNumeroRIFiltro"
        Me.txtNumeroRIFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroRIFiltro.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroRIFiltro.TabIndex = 1
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
        Me.btnFiltrar.TabIndex = 15
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblNumeroRIFiltro
        '
        Me.lblNumeroRIFiltro.AutoSize = True
        Me.lblNumeroRIFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRIFiltro.Name = "lblNumeroRIFiltro"
        Me.lblNumeroRIFiltro.Size = New System.Drawing.Size(34, 14)
        Me.lblNumeroRIFiltro.TabIndex = 0
        Me.lblNumeroRIFiltro.Text = "Nº RI:"
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
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnNovaInspecao)
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnNovaInspecao
        '
        Me.btnNovaInspecao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovaInspecao.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovaInspecao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovaInspecao.Location = New System.Drawing.Point(677, 18)
        Me.btnNovaInspecao.Name = "btnNovaInspecao"
        Me.btnNovaInspecao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovaInspecao.Size = New System.Drawing.Size(114, 23)
        Me.btnNovaInspecao.TabIndex = 10
        Me.btnNovaInspecao.Text = "Nova Inspeção"
        Me.btnNovaInspecao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 8
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 9
        Me.cboCongelarColuna.TabStop = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(580, 18)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
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
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 75)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 405)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpLegenda)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Qualidade - Inspeção - Produção"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaCaracteristicaAprovada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCaracteristicaReprovada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCaracteristicaAprovado)
        Me.grpLegenda.Controls.Add(Me.picLegendaCaracteristicaReprovada)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(310, 51)
        Me.grpLegenda.TabIndex = 11
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaCaracteristicaAprovada
        '
        Me.picLegendaCaracteristicaAprovada.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaCaracteristicaAprovada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCaracteristicaAprovada.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaCaracteristicaAprovada.Name = "picLegendaCaracteristicaAprovada"
        Me.picLegendaCaracteristicaAprovada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCaracteristicaAprovada.TabIndex = 18
        Me.picLegendaCaracteristicaAprovada.TabStop = False
        '
        'lblLegendaCaracteristicaReprovada
        '
        Me.lblLegendaCaracteristicaReprovada.AutoSize = True
        Me.lblLegendaCaracteristicaReprovada.Location = New System.Drawing.Point(177, 21)
        Me.lblLegendaCaracteristicaReprovada.Name = "lblLegendaCaracteristicaReprovada"
        Me.lblLegendaCaracteristicaReprovada.Size = New System.Drawing.Size(130, 14)
        Me.lblLegendaCaracteristicaReprovada.TabIndex = 1
        Me.lblLegendaCaracteristicaReprovada.Text = "Característica Reprovada"
        '
        'lblLegendaCaracteristicaAprovado
        '
        Me.lblLegendaCaracteristicaAprovado.AutoSize = True
        Me.lblLegendaCaracteristicaAprovado.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaCaracteristicaAprovado.Name = "lblLegendaCaracteristicaAprovado"
        Me.lblLegendaCaracteristicaAprovado.Size = New System.Drawing.Size(124, 14)
        Me.lblLegendaCaracteristicaAprovado.TabIndex = 0
        Me.lblLegendaCaracteristicaAprovado.Text = "Característica Aprovada"
        '
        'picLegendaCaracteristicaReprovada
        '
        Me.picLegendaCaracteristicaReprovada.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCaracteristicaReprovada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCaracteristicaReprovada.Location = New System.Drawing.Point(158, 21)
        Me.picLegendaCaracteristicaReprovada.Name = "picLegendaCaracteristicaReprovada"
        Me.picLegendaCaracteristicaReprovada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCaracteristicaReprovada.TabIndex = 16
        Me.picLegendaCaracteristicaReprovada.TabStop = False
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblStatusInspecao)
        Me.grpDados.Controls.Add(Me.cboStatus)
        Me.grpDados.Controls.Add(Me.lblNumeroRI)
        Me.grpDados.Controls.Add(Me.txtNumeroRI)
        Me.grpDados.Controls.Add(Me.lblQuantidadeInspecao)
        Me.grpDados.Controls.Add(Me.txtQuantidadeInspecao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblQuantidadeOP)
        Me.grpDados.Controls.Add(Me.txtQuantidadeOP)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.txtData)
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 70)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblStatusInspecao
        '
        Me.lblStatusInspecao.AutoSize = True
        Me.lblStatusInspecao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatusInspecao.Location = New System.Drawing.Point(710, 17)
        Me.lblStatusInspecao.Name = "lblStatusInspecao"
        Me.lblStatusInspecao.Size = New System.Drawing.Size(88, 14)
        Me.lblStatusInspecao.TabIndex = 12
        Me.lblStatusInspecao.Text = "Status Inspeção:"
        '
        'cboStatus
        '
        Me.cboStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatus.AutoSize = False
        Me.cboStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatus.Location = New System.Drawing.Point(714, 34)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatus.Size = New System.Drawing.Size(170, 20)
        Me.cboStatus.TabIndex = 13
        '
        'lblNumeroRI
        '
        Me.lblNumeroRI.AutoSize = True
        Me.lblNumeroRI.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRI.Name = "lblNumeroRI"
        Me.lblNumeroRI.Size = New System.Drawing.Size(34, 14)
        Me.lblNumeroRI.TabIndex = 0
        Me.lblNumeroRI.Text = "Nº RI:"
        '
        'txtNumeroRI
        '
        Me.txtNumeroRI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRI.IncludeLiterals = False
        Me.txtNumeroRI.Location = New System.Drawing.Point(10, 34)
        Me.txtNumeroRI.MaxLength = 20
        Me.txtNumeroRI.Name = "txtNumeroRI"
        Me.txtNumeroRI.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroRI.ReadOnly = True
        Me.txtNumeroRI.Size = New System.Drawing.Size(87, 20)
        Me.txtNumeroRI.TabIndex = 1
        Me.txtNumeroRI.TabStop = False
        '
        'lblQuantidadeInspecao
        '
        Me.lblQuantidadeInspecao.AutoSize = True
        Me.lblQuantidadeInspecao.Location = New System.Drawing.Point(601, 17)
        Me.lblQuantidadeInspecao.Name = "lblQuantidadeInspecao"
        Me.lblQuantidadeInspecao.Size = New System.Drawing.Size(80, 14)
        Me.lblQuantidadeInspecao.TabIndex = 10
        Me.lblQuantidadeInspecao.Text = "Qtde Inspeção:"
        '
        'txtQuantidadeInspecao
        '
        Me.txtQuantidadeInspecao.DecimalDigits = 4
        Me.txtQuantidadeInspecao.Location = New System.Drawing.Point(604, 34)
        Me.txtQuantidadeInspecao.Name = "txtQuantidadeInspecao"
        Me.txtQuantidadeInspecao.Size = New System.Drawing.Size(104, 20)
        Me.txtQuantidadeInspecao.TabIndex = 11
        Me.txtQuantidadeInspecao.Text = "0,0000"
        Me.txtQuantidadeInspecao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(100, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducao.TabIndex = 2
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'lblQuantidadeOP
        '
        Me.lblQuantidadeOP.AutoSize = True
        Me.lblQuantidadeOP.Location = New System.Drawing.Point(508, 17)
        Me.lblQuantidadeOP.Name = "lblQuantidadeOP"
        Me.lblQuantidadeOP.Size = New System.Drawing.Size(50, 14)
        Me.lblQuantidadeOP.TabIndex = 8
        Me.lblQuantidadeOP.Text = "Qtde OP:"
        '
        'txtQuantidadeOP
        '
        Me.txtQuantidadeOP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeOP.DecimalDigits = 4
        Me.txtQuantidadeOP.Location = New System.Drawing.Point(511, 34)
        Me.txtQuantidadeOP.Name = "txtQuantidadeOP"
        Me.txtQuantidadeOP.ReadOnly = True
        Me.txtQuantidadeOP.Size = New System.Drawing.Size(87, 20)
        Me.txtQuantidadeOP.TabIndex = 9
        Me.txtQuantidadeOP.TabStop = False
        Me.txtQuantidadeOP.Text = "0,0000"
        Me.txtQuantidadeOP.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblData.Location = New System.Drawing.Point(368, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 6
        Me.lblData.Text = "Data:"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(210, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 4
        Me.lblProduto.Text = "Produto:"
        '
        'txtData
        '
        Me.txtData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData.Location = New System.Drawing.Point(371, 34)
        Me.txtData.MaxLength = 50
        Me.txtData.Name = "txtData"
        Me.txtData.ReadOnly = True
        Me.txtData.Size = New System.Drawing.Size(134, 20)
        Me.txtData.TabIndex = 7
        Me.txtData.TabStop = False
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(213, 34)
        Me.txtProduto.MaxLength = 120
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(152, 20)
        Me.txtProduto.TabIndex = 5
        Me.txtProduto.TabStop = False
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.IncludeLiterals = False
        Me.txtOrdemProducao.Location = New System.Drawing.Point(103, 34)
        Me.txtOrdemProducao.MaxLength = 20
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.Size = New System.Drawing.Size(104, 20)
        Me.txtOrdemProducao.TabIndex = 3
        Me.txtOrdemProducao.TabStop = False
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnImprimir)
        Me.grpControle2.Controls.Add(Me.btnNovaInspecaoDados)
        Me.grpControle2.Controls.Add(Me.btnUltimoRegistro)
        Me.grpControle2.Controls.Add(Me.btnRegistroAnterior)
        Me.grpControle2.Controls.Add(Me.btnProximoRegistro)
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Controls.Add(Me.btnSalvar)
        Me.grpControle2.Location = New System.Drawing.Point(327, 483)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(578, 51)
        Me.grpControle2.TabIndex = 2
        Me.grpControle2.VisualStyleManager = Me.vsmMain
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(141, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(114, 23)
        Me.btnImprimir.TabIndex = 31
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovaInspecaoDados
        '
        Me.btnNovaInspecaoDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovaInspecaoDados.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovaInspecaoDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovaInspecaoDados.Location = New System.Drawing.Point(261, 17)
        Me.btnNovaInspecaoDados.Name = "btnNovaInspecaoDados"
        Me.btnNovaInspecaoDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovaInspecaoDados.Size = New System.Drawing.Size(114, 23)
        Me.btnNovaInspecaoDados.TabIndex = 30
        Me.btnNovaInspecaoDados.Text = "Nova Inspeção"
        Me.btnNovaInspecaoDados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnUltimoRegistro
        '
        Me.btnUltimoRegistro.Image = CType(resources.GetObject("btnUltimoRegistro.Image"), System.Drawing.Image)
        Me.btnUltimoRegistro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnUltimoRegistro.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnUltimoRegistro.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.btnUltimoRegistro.Location = New System.Drawing.Point(69, 17)
        Me.btnUltimoRegistro.Name = "btnUltimoRegistro"
        Me.btnUltimoRegistro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnUltimoRegistro.Size = New System.Drawing.Size(21, 23)
        Me.btnUltimoRegistro.TabIndex = 29
        Me.btnUltimoRegistro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnRegistroAnterior
        '
        Me.btnRegistroAnterior.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnRegistroAnterior.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRegistroAnterior.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnRegistroAnterior.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.btnRegistroAnterior.Location = New System.Drawing.Point(15, 17)
        Me.btnRegistroAnterior.Name = "btnRegistroAnterior"
        Me.btnRegistroAnterior.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRegistroAnterior.Size = New System.Drawing.Size(21, 23)
        Me.btnRegistroAnterior.TabIndex = 27
        Me.btnRegistroAnterior.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProximoRegistro
        '
        Me.btnProximoRegistro.Image = Global.INTERACTI.My.Resources.Resources.seta_direita
        Me.btnProximoRegistro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProximoRegistro.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnProximoRegistro.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.btnProximoRegistro.Location = New System.Drawing.Point(42, 17)
        Me.btnProximoRegistro.Name = "btnProximoRegistro"
        Me.btnProximoRegistro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProximoRegistro.Size = New System.Drawing.Size(21, 23)
        Me.btnProximoRegistro.TabIndex = 28
        Me.btnProximoRegistro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(478, 17)
        Me.btnVoltar.Name = "btnVoltar"
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
        Me.btnSalvar.Location = New System.Drawing.Point(381, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 79)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 401)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.pagInspecao, Me.pagArquivos})
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.grpDadosGerais)
        Me.UiTabPage1.Key = "pagDadosGerais"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 22)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(895, 378)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Dados Gerais"
        '
        'grpDadosGerais
        '
        Me.grpDadosGerais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosGerais.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosGerais.Controls.Add(Me.lblInspecaoVisual)
        Me.grpDadosGerais.Controls.Add(Me.txtInspecaoVisual)
        Me.grpDadosGerais.Controls.Add(Me.lblFornecedor)
        Me.grpDadosGerais.Controls.Add(Me.txtFornecedor)
        Me.grpDadosGerais.Controls.Add(Me.lblCoordenacao)
        Me.grpDadosGerais.Controls.Add(Me.txtCoordenacao)
        Me.grpDadosGerais.Controls.Add(Me.lblOutros)
        Me.grpDadosGerais.Controls.Add(Me.txtOutros)
        Me.grpDadosGerais.Controls.Add(Me.lblAmbiente)
        Me.grpDadosGerais.Controls.Add(Me.txtAmbiente)
        Me.grpDadosGerais.Controls.Add(Me.lblAlinhamento)
        Me.grpDadosGerais.Controls.Add(Me.txtAlinhamento)
        Me.grpDadosGerais.Controls.Add(Me.lblPintura)
        Me.grpDadosGerais.Controls.Add(Me.txtPintura)
        Me.grpDadosGerais.Controls.Add(Me.lblIdentificacao)
        Me.grpDadosGerais.Controls.Add(Me.txtIdentificacao)
        Me.grpDadosGerais.Controls.Add(Me.lblOrigem)
        Me.grpDadosGerais.Controls.Add(Me.txtOrigem)
        Me.grpDadosGerais.Controls.Add(Me.lblNivelamento)
        Me.grpDadosGerais.Controls.Add(Me.txtNivelamento)
        Me.grpDadosGerais.Controls.Add(Me.lblNivelInspecao)
        Me.grpDadosGerais.Controls.Add(Me.txtNivelInspecao)
        Me.grpDadosGerais.Controls.Add(Me.lblInspecaoDimensional)
        Me.grpDadosGerais.Controls.Add(Me.txtInspecaoDimensional)
        Me.grpDadosGerais.Controls.Add(Me.lblObservacao)
        Me.grpDadosGerais.Controls.Add(Me.txtObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblNormaInspecao)
        Me.grpDadosGerais.Controls.Add(Me.cboNormaInspecao)
        Me.grpDadosGerais.Controls.Add(Me.txtNumeroDesenho)
        Me.grpDadosGerais.Controls.Add(Me.lblNumeroDesenho)
        Me.grpDadosGerais.Controls.Add(Me.lblMascaraInspecao)
        Me.grpDadosGerais.Controls.Add(Me.lblCliente)
        Me.grpDadosGerais.Controls.Add(Me.cboMascaraInspecao)
        Me.grpDadosGerais.Controls.Add(Me.chkProdutoSeriado)
        Me.grpDadosGerais.Controls.Add(Me.txtCliente)
        Me.grpDadosGerais.Controls.Add(Me.lblNumeroSerieTermino)
        Me.grpDadosGerais.Controls.Add(Me.txtRevisao)
        Me.grpDadosGerais.Controls.Add(Me.txtNumeroSerieTermino)
        Me.grpDadosGerais.Controls.Add(Me.lblRevisao)
        Me.grpDadosGerais.Controls.Add(Me.lblNumeroSerialInicial)
        Me.grpDadosGerais.Controls.Add(Me.txtVeiculo)
        Me.grpDadosGerais.Controls.Add(Me.txtNumeroSerieInicial)
        Me.grpDadosGerais.Controls.Add(Me.lblVeiculo)
        Me.grpDadosGerais.Controls.Add(Me.txtEstagio)
        Me.grpDadosGerais.Controls.Add(Me.lblNorma)
        Me.grpDadosGerais.Controls.Add(Me.lblEstagio)
        Me.grpDadosGerais.Controls.Add(Me.txtNorma)
        Me.grpDadosGerais.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosGerais.Name = "grpDadosGerais"
        Me.grpDadosGerais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosGerais.Size = New System.Drawing.Size(879, 366)
        Me.grpDadosGerais.TabIndex = 0
        Me.grpDadosGerais.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosGerais.VisualStyleManager = Me.vsmMain
        '
        'lblInspecaoVisual
        '
        Me.lblInspecaoVisual.AutoSize = True
        Me.lblInspecaoVisual.Location = New System.Drawing.Point(389, 219)
        Me.lblInspecaoVisual.Name = "lblInspecaoVisual"
        Me.lblInspecaoVisual.Size = New System.Drawing.Size(87, 14)
        Me.lblInspecaoVisual.TabIndex = 56
        Me.lblInspecaoVisual.Text = "Inspeção Visual:"
        '
        'txtInspecaoVisual
        '
        Me.txtInspecaoVisual.IncludeLiterals = False
        Me.txtInspecaoVisual.Location = New System.Drawing.Point(392, 236)
        Me.txtInspecaoVisual.MaxLength = 1000
        Me.txtInspecaoVisual.Name = "txtInspecaoVisual"
        Me.txtInspecaoVisual.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtInspecaoVisual.Size = New System.Drawing.Size(472, 20)
        Me.txtInspecaoVisual.TabIndex = 23
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(6, 219)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 54
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.IncludeLiterals = False
        Me.txtFornecedor.Location = New System.Drawing.Point(9, 236)
        Me.txtFornecedor.MaxLength = 500
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFornecedor.Size = New System.Drawing.Size(377, 20)
        Me.txtFornecedor.TabIndex = 22
        '
        'lblCoordenacao
        '
        Me.lblCoordenacao.AutoSize = True
        Me.lblCoordenacao.Location = New System.Drawing.Point(179, 179)
        Me.lblCoordenacao.Name = "lblCoordenacao"
        Me.lblCoordenacao.Size = New System.Drawing.Size(75, 14)
        Me.lblCoordenacao.TabIndex = 52
        Me.lblCoordenacao.Text = "Coordenação:"
        '
        'txtCoordenacao
        '
        Me.txtCoordenacao.IncludeLiterals = False
        Me.txtCoordenacao.Location = New System.Drawing.Point(181, 196)
        Me.txtCoordenacao.MaxLength = 120
        Me.txtCoordenacao.Name = "txtCoordenacao"
        Me.txtCoordenacao.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCoordenacao.Size = New System.Drawing.Size(205, 20)
        Me.txtCoordenacao.TabIndex = 20
        '
        'lblOutros
        '
        Me.lblOutros.AutoSize = True
        Me.lblOutros.Location = New System.Drawing.Point(389, 179)
        Me.lblOutros.Name = "lblOutros"
        Me.lblOutros.Size = New System.Drawing.Size(43, 14)
        Me.lblOutros.TabIndex = 50
        Me.lblOutros.Text = "Outros:"
        '
        'txtOutros
        '
        Me.txtOutros.IncludeLiterals = False
        Me.txtOutros.Location = New System.Drawing.Point(392, 196)
        Me.txtOutros.MaxLength = 500
        Me.txtOutros.Name = "txtOutros"
        Me.txtOutros.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtOutros.Size = New System.Drawing.Size(472, 20)
        Me.txtOutros.TabIndex = 21
        '
        'lblAmbiente
        '
        Me.lblAmbiente.AutoSize = True
        Me.lblAmbiente.Location = New System.Drawing.Point(6, 179)
        Me.lblAmbiente.Name = "lblAmbiente"
        Me.lblAmbiente.Size = New System.Drawing.Size(55, 14)
        Me.lblAmbiente.TabIndex = 48
        Me.lblAmbiente.Text = "Ambiente:"
        '
        'txtAmbiente
        '
        Me.txtAmbiente.IncludeLiterals = False
        Me.txtAmbiente.Location = New System.Drawing.Point(9, 196)
        Me.txtAmbiente.MaxLength = 120
        Me.txtAmbiente.Name = "txtAmbiente"
        Me.txtAmbiente.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAmbiente.Size = New System.Drawing.Size(166, 20)
        Me.txtAmbiente.TabIndex = 19
        '
        'lblAlinhamento
        '
        Me.lblAlinhamento.AutoSize = True
        Me.lblAlinhamento.Location = New System.Drawing.Point(6, 139)
        Me.lblAlinhamento.Name = "lblAlinhamento"
        Me.lblAlinhamento.Size = New System.Drawing.Size(69, 14)
        Me.lblAlinhamento.TabIndex = 46
        Me.lblAlinhamento.Text = "Alinhamento:"
        '
        'txtAlinhamento
        '
        Me.txtAlinhamento.IncludeLiterals = False
        Me.txtAlinhamento.Location = New System.Drawing.Point(9, 156)
        Me.txtAlinhamento.MaxLength = 100
        Me.txtAlinhamento.Name = "txtAlinhamento"
        Me.txtAlinhamento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtAlinhamento.Size = New System.Drawing.Size(166, 20)
        Me.txtAlinhamento.TabIndex = 15
        '
        'lblPintura
        '
        Me.lblPintura.AutoSize = True
        Me.lblPintura.Location = New System.Drawing.Point(592, 139)
        Me.lblPintura.Name = "lblPintura"
        Me.lblPintura.Size = New System.Drawing.Size(43, 14)
        Me.lblPintura.TabIndex = 44
        Me.lblPintura.Text = "Pintura:"
        '
        'txtPintura
        '
        Me.txtPintura.IncludeLiterals = False
        Me.txtPintura.Location = New System.Drawing.Point(594, 156)
        Me.txtPintura.MaxLength = 100
        Me.txtPintura.Name = "txtPintura"
        Me.txtPintura.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPintura.Size = New System.Drawing.Size(270, 20)
        Me.txtPintura.TabIndex = 18
        '
        'lblIdentificacao
        '
        Me.lblIdentificacao.AutoSize = True
        Me.lblIdentificacao.Location = New System.Drawing.Point(389, 139)
        Me.lblIdentificacao.Name = "lblIdentificacao"
        Me.lblIdentificacao.Size = New System.Drawing.Size(71, 14)
        Me.lblIdentificacao.TabIndex = 42
        Me.lblIdentificacao.Text = "Identificação:"
        '
        'txtIdentificacao
        '
        Me.txtIdentificacao.IncludeLiterals = False
        Me.txtIdentificacao.Location = New System.Drawing.Point(392, 156)
        Me.txtIdentificacao.MaxLength = 120
        Me.txtIdentificacao.Name = "txtIdentificacao"
        Me.txtIdentificacao.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtIdentificacao.Size = New System.Drawing.Size(197, 20)
        Me.txtIdentificacao.TabIndex = 17
        '
        'lblOrigem
        '
        Me.lblOrigem.AutoSize = True
        Me.lblOrigem.Location = New System.Drawing.Point(178, 139)
        Me.lblOrigem.Name = "lblOrigem"
        Me.lblOrigem.Size = New System.Drawing.Size(44, 14)
        Me.lblOrigem.TabIndex = 40
        Me.lblOrigem.Text = "Origem:"
        '
        'txtOrigem
        '
        Me.txtOrigem.IncludeLiterals = False
        Me.txtOrigem.Location = New System.Drawing.Point(181, 156)
        Me.txtOrigem.MaxLength = 100
        Me.txtOrigem.Name = "txtOrigem"
        Me.txtOrigem.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtOrigem.Size = New System.Drawing.Size(205, 20)
        Me.txtOrigem.TabIndex = 16
        '
        'lblNivelamento
        '
        Me.lblNivelamento.AutoSize = True
        Me.lblNivelamento.Location = New System.Drawing.Point(592, 99)
        Me.lblNivelamento.Name = "lblNivelamento"
        Me.lblNivelamento.Size = New System.Drawing.Size(68, 14)
        Me.lblNivelamento.TabIndex = 38
        Me.lblNivelamento.Text = "Nivelamento:"
        '
        'txtNivelamento
        '
        Me.txtNivelamento.IncludeLiterals = False
        Me.txtNivelamento.Location = New System.Drawing.Point(594, 116)
        Me.txtNivelamento.MaxLength = 100
        Me.txtNivelamento.Name = "txtNivelamento"
        Me.txtNivelamento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNivelamento.Size = New System.Drawing.Size(270, 20)
        Me.txtNivelamento.TabIndex = 14
        '
        'lblNivelInspecao
        '
        Me.lblNivelInspecao.AutoSize = True
        Me.lblNivelInspecao.Location = New System.Drawing.Point(389, 99)
        Me.lblNivelInspecao.Name = "lblNivelInspecao"
        Me.lblNivelInspecao.Size = New System.Drawing.Size(80, 14)
        Me.lblNivelInspecao.TabIndex = 36
        Me.lblNivelInspecao.Text = "Nível Inspeção:"
        '
        'txtNivelInspecao
        '
        Me.txtNivelInspecao.IncludeLiterals = False
        Me.txtNivelInspecao.Location = New System.Drawing.Point(392, 116)
        Me.txtNivelInspecao.MaxLength = 100
        Me.txtNivelInspecao.Name = "txtNivelInspecao"
        Me.txtNivelInspecao.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNivelInspecao.Size = New System.Drawing.Size(197, 20)
        Me.txtNivelInspecao.TabIndex = 13
        '
        'lblInspecaoDimensional
        '
        Me.lblInspecaoDimensional.AutoSize = True
        Me.lblInspecaoDimensional.Location = New System.Drawing.Point(178, 99)
        Me.lblInspecaoDimensional.Name = "lblInspecaoDimensional"
        Me.lblInspecaoDimensional.Size = New System.Drawing.Size(114, 14)
        Me.lblInspecaoDimensional.TabIndex = 34
        Me.lblInspecaoDimensional.Text = "Inspeção Dimensional:"
        '
        'txtInspecaoDimensional
        '
        Me.txtInspecaoDimensional.IncludeLiterals = False
        Me.txtInspecaoDimensional.Location = New System.Drawing.Point(181, 116)
        Me.txtInspecaoDimensional.MaxLength = 200
        Me.txtInspecaoDimensional.Name = "txtInspecaoDimensional"
        Me.txtInspecaoDimensional.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtInspecaoDimensional.Size = New System.Drawing.Size(205, 20)
        Me.txtInspecaoDimensional.TabIndex = 12
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObservacao.Location = New System.Drawing.Point(7, 259)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 33
        Me.lblObservacao.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(9, 276)
        Me.txtObservacao.MaxLength = 5000
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(855, 84)
        Me.txtObservacao.TabIndex = 24
        '
        'lblNormaInspecao
        '
        Me.lblNormaInspecao.AutoSize = True
        Me.lblNormaInspecao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNormaInspecao.Location = New System.Drawing.Point(6, 99)
        Me.lblNormaInspecao.Name = "lblNormaInspecao"
        Me.lblNormaInspecao.Size = New System.Drawing.Size(88, 14)
        Me.lblNormaInspecao.TabIndex = 31
        Me.lblNormaInspecao.Text = "Norma Inspeção:"
        '
        'cboNormaInspecao
        '
        Me.cboNormaInspecao.AutoSize = False
        Me.cboNormaInspecao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNormaInspecao.Location = New System.Drawing.Point(9, 116)
        Me.cboNormaInspecao.Name = "cboNormaInspecao"
        Me.cboNormaInspecao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNormaInspecao.Size = New System.Drawing.Size(166, 20)
        Me.cboNormaInspecao.TabIndex = 11
        '
        'txtNumeroDesenho
        '
        Me.txtNumeroDesenho.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDesenho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDesenho.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDesenho.MaxLength = 50
        Me.txtNumeroDesenho.Name = "txtNumeroDesenho"
        Me.txtNumeroDesenho.ReadOnly = True
        Me.txtNumeroDesenho.Size = New System.Drawing.Size(165, 20)
        Me.txtNumeroDesenho.TabIndex = 0
        Me.txtNumeroDesenho.TabStop = False
        '
        'lblNumeroDesenho
        '
        Me.lblNumeroDesenho.AutoSize = True
        Me.lblNumeroDesenho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDesenho.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDesenho.Name = "lblNumeroDesenho"
        Me.lblNumeroDesenho.Size = New System.Drawing.Size(68, 14)
        Me.lblNumeroDesenho.TabIndex = 8
        Me.lblNumeroDesenho.Text = "Nº Desenho:"
        '
        'lblMascaraInspecao
        '
        Me.lblMascaraInspecao.AutoSize = True
        Me.lblMascaraInspecao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMascaraInspecao.Location = New System.Drawing.Point(177, 56)
        Me.lblMascaraInspecao.Name = "lblMascaraInspecao"
        Me.lblMascaraInspecao.Size = New System.Drawing.Size(114, 14)
        Me.lblMascaraInspecao.TabIndex = 24
        Me.lblMascaraInspecao.Text = "Máscara de Inspeção:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCliente.Location = New System.Drawing.Point(178, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 10
        Me.lblCliente.Text = "Cliente:"
        '
        'cboMascaraInspecao
        '
        Me.cboMascaraInspecao.AutoSize = False
        Me.cboMascaraInspecao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMascaraInspecao.Location = New System.Drawing.Point(181, 73)
        Me.cboMascaraInspecao.Name = "cboMascaraInspecao"
        Me.cboMascaraInspecao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMascaraInspecao.Size = New System.Drawing.Size(298, 20)
        Me.cboMascaraInspecao.TabIndex = 6
        '
        'chkProdutoSeriado
        '
        Me.chkProdutoSeriado.Location = New System.Drawing.Point(486, 74)
        Me.chkProdutoSeriado.Name = "chkProdutoSeriado"
        Me.chkProdutoSeriado.Size = New System.Drawing.Size(103, 17)
        Me.chkProdutoSeriado.TabIndex = 7
        Me.chkProdutoSeriado.Text = "Produto seriado"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(181, 34)
        Me.txtCliente.MaxLength = 50
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(205, 20)
        Me.txtCliente.TabIndex = 1
        Me.txtCliente.TabStop = False
        '
        'lblNumeroSerieTermino
        '
        Me.lblNumeroSerieTermino.AutoSize = True
        Me.lblNumeroSerieTermino.Location = New System.Drawing.Point(730, 57)
        Me.lblNumeroSerieTermino.Name = "lblNumeroSerieTermino"
        Me.lblNumeroSerieTermino.Size = New System.Drawing.Size(93, 14)
        Me.lblNumeroSerieTermino.TabIndex = 29
        Me.lblNumeroSerieTermino.Text = "Nº Serial Término:"
        '
        'txtRevisao
        '
        Me.txtRevisao.IncludeLiterals = False
        Me.txtRevisao.Location = New System.Drawing.Point(392, 34)
        Me.txtRevisao.MaxLength = 20
        Me.txtRevisao.Name = "txtRevisao"
        Me.txtRevisao.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtRevisao.Size = New System.Drawing.Size(87, 20)
        Me.txtRevisao.TabIndex = 2
        Me.txtRevisao.TabStop = False
        '
        'txtNumeroSerieTermino
        '
        Me.txtNumeroSerieTermino.DecimalDigits = 0
        Me.txtNumeroSerieTermino.Location = New System.Drawing.Point(733, 74)
        Me.txtNumeroSerieTermino.Name = "txtNumeroSerieTermino"
        Me.txtNumeroSerieTermino.Size = New System.Drawing.Size(131, 20)
        Me.txtNumeroSerieTermino.TabIndex = 10
        Me.txtNumeroSerieTermino.Text = "0"
        Me.txtNumeroSerieTermino.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblRevisao
        '
        Me.lblRevisao.AutoSize = True
        Me.lblRevisao.Location = New System.Drawing.Point(389, 17)
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisao.TabIndex = 16
        Me.lblRevisao.Text = "Revisão:"
        '
        'lblNumeroSerialInicial
        '
        Me.lblNumeroSerialInicial.AutoSize = True
        Me.lblNumeroSerialInicial.Location = New System.Drawing.Point(592, 57)
        Me.lblNumeroSerialInicial.Name = "lblNumeroSerialInicial"
        Me.lblNumeroSerialInicial.Size = New System.Drawing.Size(81, 14)
        Me.lblNumeroSerialInicial.TabIndex = 27
        Me.lblNumeroSerialInicial.Text = "Nº Serial Inicial:"
        '
        'txtVeiculo
        '
        Me.txtVeiculo.IncludeLiterals = False
        Me.txtVeiculo.Location = New System.Drawing.Point(486, 34)
        Me.txtVeiculo.MaxLength = 20
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtVeiculo.Size = New System.Drawing.Size(103, 20)
        Me.txtVeiculo.TabIndex = 3
        Me.txtVeiculo.TabStop = False
        '
        'txtNumeroSerieInicial
        '
        Me.txtNumeroSerieInicial.DecimalDigits = 0
        Me.txtNumeroSerieInicial.Location = New System.Drawing.Point(595, 74)
        Me.txtNumeroSerieInicial.Name = "txtNumeroSerieInicial"
        Me.txtNumeroSerieInicial.Size = New System.Drawing.Size(132, 20)
        Me.txtNumeroSerieInicial.TabIndex = 9
        Me.txtNumeroSerieInicial.Text = "0"
        Me.txtNumeroSerieInicial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblVeiculo
        '
        Me.lblVeiculo.AutoSize = True
        Me.lblVeiculo.Location = New System.Drawing.Point(482, 17)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.Size = New System.Drawing.Size(45, 14)
        Me.lblVeiculo.TabIndex = 18
        Me.lblVeiculo.Text = "Veículo:"
        '
        'txtEstagio
        '
        Me.txtEstagio.IncludeLiterals = False
        Me.txtEstagio.Location = New System.Drawing.Point(595, 34)
        Me.txtEstagio.MaxLength = 20
        Me.txtEstagio.Name = "txtEstagio"
        Me.txtEstagio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtEstagio.Size = New System.Drawing.Size(269, 20)
        Me.txtEstagio.TabIndex = 4
        Me.txtEstagio.TabStop = False
        '
        'lblNorma
        '
        Me.lblNorma.AutoSize = True
        Me.lblNorma.Location = New System.Drawing.Point(6, 56)
        Me.lblNorma.Name = "lblNorma"
        Me.lblNorma.Size = New System.Drawing.Size(41, 14)
        Me.lblNorma.TabIndex = 22
        Me.lblNorma.Text = "Norma:"
        '
        'lblEstagio
        '
        Me.lblEstagio.AutoSize = True
        Me.lblEstagio.Location = New System.Drawing.Point(591, 17)
        Me.lblEstagio.Name = "lblEstagio"
        Me.lblEstagio.Size = New System.Drawing.Size(45, 14)
        Me.lblEstagio.TabIndex = 20
        Me.lblEstagio.Text = "Estágio:"
        '
        'txtNorma
        '
        Me.txtNorma.IncludeLiterals = False
        Me.txtNorma.Location = New System.Drawing.Point(9, 73)
        Me.txtNorma.MaxLength = 20
        Me.txtNorma.Name = "txtNorma"
        Me.txtNorma.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNorma.Size = New System.Drawing.Size(165, 20)
        Me.txtNorma.TabIndex = 5
        Me.txtNorma.TabStop = False
        '
        'pagInspecao
        '
        Me.pagInspecao.Controls.Add(Me.grpCaracteristicas)
        Me.pagInspecao.Controls.Add(Me.grdQualidade)
        Me.pagInspecao.Key = "pagInspecao"
        Me.pagInspecao.Location = New System.Drawing.Point(1, 22)
        Me.pagInspecao.Name = "pagInspecao"
        Me.pagInspecao.Size = New System.Drawing.Size(895, 378)
        Me.pagInspecao.TabStop = True
        Me.pagInspecao.Text = "Dados da Inspeção"
        '
        'grpCaracteristicas
        '
        Me.grpCaracteristicas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCaracteristicas.BackColor = System.Drawing.Color.Transparent
        Me.grpCaracteristicas.Controls.Add(Me.lblToleranciaMaxima)
        Me.grpCaracteristicas.Controls.Add(Me.txtToleranciaMaxima)
        Me.grpCaracteristicas.Controls.Add(Me.lblToleranciaMinima)
        Me.grpCaracteristicas.Controls.Add(Me.txtToleranciaMinima)
        Me.grpCaracteristicas.Controls.Add(Me.txtValorEncontrado)
        Me.grpCaracteristicas.Controls.Add(Me.txtValorNominal)
        Me.grpCaracteristicas.Controls.Add(Me.lblTipo)
        Me.grpCaracteristicas.Controls.Add(Me.cboTipo)
        Me.grpCaracteristicas.Controls.Add(Me.lblCapacidade)
        Me.grpCaracteristicas.Controls.Add(Me.txtCapacidade)
        Me.grpCaracteristicas.Controls.Add(Me.cboEquipamento)
        Me.grpCaracteristicas.Controls.Add(Me.lblEquipamento)
        Me.grpCaracteristicas.Controls.Add(Me.lblObservacaoCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.txtObservacaoCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.lblValorEncontrado)
        Me.grpCaracteristicas.Controls.Add(Me.lblValorMaximo)
        Me.grpCaracteristicas.Controls.Add(Me.txtValorMaximo)
        Me.grpCaracteristicas.Controls.Add(Me.lblValorMinimo)
        Me.grpCaracteristicas.Controls.Add(Me.txtValorMinimo)
        Me.grpCaracteristicas.Controls.Add(Me.lblValorNominal)
        Me.grpCaracteristicas.Controls.Add(Me.cboClasseTolerancia)
        Me.grpCaracteristicas.Controls.Add(Me.lblClasseTolerancia)
        Me.grpCaracteristicas.Controls.Add(Me.cboCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.lblCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.btnExcluirCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.btnInserirCaracteristica)
        Me.grpCaracteristicas.Location = New System.Drawing.Point(8, 3)
        Me.grpCaracteristicas.Name = "grpCaracteristicas"
        Me.grpCaracteristicas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCaracteristicas.Size = New System.Drawing.Size(879, 104)
        Me.grpCaracteristicas.TabIndex = 0
        Me.grpCaracteristicas.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpCaracteristicas.VisualStyleManager = Me.vsmMain
        '
        'lblToleranciaMaxima
        '
        Me.lblToleranciaMaxima.AutoSize = True
        Me.lblToleranciaMaxima.Location = New System.Drawing.Point(232, 57)
        Me.lblToleranciaMaxima.Name = "lblToleranciaMaxima"
        Me.lblToleranciaMaxima.Size = New System.Drawing.Size(98, 14)
        Me.lblToleranciaMaxima.TabIndex = 14
        Me.lblToleranciaMaxima.Text = "Tolerância Máxima:"
        '
        'txtToleranciaMaxima
        '
        Me.txtToleranciaMaxima.DecimalDigits = 4
        Me.txtToleranciaMaxima.Location = New System.Drawing.Point(235, 74)
        Me.txtToleranciaMaxima.Name = "txtToleranciaMaxima"
        Me.txtToleranciaMaxima.Size = New System.Drawing.Size(91, 20)
        Me.txtToleranciaMaxima.TabIndex = 15
        Me.txtToleranciaMaxima.Text = "0,0000"
        Me.txtToleranciaMaxima.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblToleranciaMinima
        '
        Me.lblToleranciaMinima.AutoSize = True
        Me.lblToleranciaMinima.Location = New System.Drawing.Point(135, 57)
        Me.lblToleranciaMinima.Name = "lblToleranciaMinima"
        Me.lblToleranciaMinima.Size = New System.Drawing.Size(94, 14)
        Me.lblToleranciaMinima.TabIndex = 12
        Me.lblToleranciaMinima.Text = "Tolerância Mínima:"
        '
        'txtToleranciaMinima
        '
        Me.txtToleranciaMinima.DecimalDigits = 4
        Me.txtToleranciaMinima.Location = New System.Drawing.Point(138, 74)
        Me.txtToleranciaMinima.Name = "txtToleranciaMinima"
        Me.txtToleranciaMinima.Size = New System.Drawing.Size(91, 20)
        Me.txtToleranciaMinima.TabIndex = 13
        Me.txtToleranciaMinima.Text = "0,0000"
        Me.txtToleranciaMinima.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtValorEncontrado
        '
        Me.txtValorEncontrado.IncludeLiterals = False
        Me.txtValorEncontrado.Location = New System.Drawing.Point(498, 74)
        Me.txtValorEncontrado.MaxLength = 20
        Me.txtValorEncontrado.Name = "txtValorEncontrado"
        Me.txtValorEncontrado.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtValorEncontrado.Size = New System.Drawing.Size(105, 20)
        Me.txtValorEncontrado.TabIndex = 21
        Me.txtValorEncontrado.TabStop = False
        '
        'txtValorNominal
        '
        Me.txtValorNominal.IncludeLiterals = False
        Me.txtValorNominal.Location = New System.Drawing.Point(10, 74)
        Me.txtValorNominal.MaxLength = 20
        Me.txtValorNominal.Name = "txtValorNominal"
        Me.txtValorNominal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtValorNominal.Size = New System.Drawing.Size(122, 20)
        Me.txtValorNominal.TabIndex = 11
        Me.txtValorNominal.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(177, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 2
        Me.lblTipo.Text = "Tipo:"
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Location = New System.Drawing.Point(180, 34)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(176, 20)
        Me.cboTipo.TabIndex = 3
        '
        'lblCapacidade
        '
        Me.lblCapacidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCapacidade.AutoSize = True
        Me.lblCapacidade.Location = New System.Drawing.Point(688, 17)
        Me.lblCapacidade.Name = "lblCapacidade"
        Me.lblCapacidade.Size = New System.Drawing.Size(67, 14)
        Me.lblCapacidade.TabIndex = 8
        Me.lblCapacidade.Text = "Capacidade:"
        '
        'txtCapacidade
        '
        Me.txtCapacidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCapacidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCapacidade.IncludeLiterals = False
        Me.txtCapacidade.Location = New System.Drawing.Point(691, 34)
        Me.txtCapacidade.MaxLength = 20
        Me.txtCapacidade.Name = "txtCapacidade"
        Me.txtCapacidade.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCapacidade.Size = New System.Drawing.Size(69, 20)
        Me.txtCapacidade.TabIndex = 9
        Me.txtCapacidade.TabStop = False
        '
        'cboEquipamento
        '
        Me.cboEquipamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEquipamento.AutoSize = False
        Me.cboEquipamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEquipamento.Location = New System.Drawing.Point(524, 34)
        Me.cboEquipamento.Name = "cboEquipamento"
        Me.cboEquipamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEquipamento.Size = New System.Drawing.Size(161, 20)
        Me.cboEquipamento.TabIndex = 7
        '
        'lblEquipamento
        '
        Me.lblEquipamento.AutoSize = True
        Me.lblEquipamento.Location = New System.Drawing.Point(521, 17)
        Me.lblEquipamento.Name = "lblEquipamento"
        Me.lblEquipamento.Size = New System.Drawing.Size(71, 14)
        Me.lblEquipamento.TabIndex = 6
        Me.lblEquipamento.Text = "Equipamento:"
        '
        'lblObservacaoCaracteristica
        '
        Me.lblObservacaoCaracteristica.AutoSize = True
        Me.lblObservacaoCaracteristica.Location = New System.Drawing.Point(605, 57)
        Me.lblObservacaoCaracteristica.Name = "lblObservacaoCaracteristica"
        Me.lblObservacaoCaracteristica.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacaoCaracteristica.TabIndex = 22
        Me.lblObservacaoCaracteristica.Text = "Observação:"
        '
        'txtObservacaoCaracteristica
        '
        Me.txtObservacaoCaracteristica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoCaracteristica.IncludeLiterals = False
        Me.txtObservacaoCaracteristica.Location = New System.Drawing.Point(609, 74)
        Me.txtObservacaoCaracteristica.MaxLength = 20
        Me.txtObservacaoCaracteristica.Name = "txtObservacaoCaracteristica"
        Me.txtObservacaoCaracteristica.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtObservacaoCaracteristica.Size = New System.Drawing.Size(152, 20)
        Me.txtObservacaoCaracteristica.TabIndex = 23
        Me.txtObservacaoCaracteristica.TabStop = False
        '
        'lblValorEncontrado
        '
        Me.lblValorEncontrado.AutoSize = True
        Me.lblValorEncontrado.Location = New System.Drawing.Point(496, 57)
        Me.lblValorEncontrado.Name = "lblValorEncontrado"
        Me.lblValorEncontrado.Size = New System.Drawing.Size(93, 14)
        Me.lblValorEncontrado.TabIndex = 20
        Me.lblValorEncontrado.Text = "Valor Encontrado:"
        '
        'lblValorMaximo
        '
        Me.lblValorMaximo.AutoSize = True
        Me.lblValorMaximo.Location = New System.Drawing.Point(412, 57)
        Me.lblValorMaximo.Name = "lblValorMaximo"
        Me.lblValorMaximo.Size = New System.Drawing.Size(74, 14)
        Me.lblValorMaximo.TabIndex = 18
        Me.lblValorMaximo.Text = "Valor Máximo:"
        '
        'txtValorMaximo
        '
        Me.txtValorMaximo.DecimalDigits = 4
        Me.txtValorMaximo.Location = New System.Drawing.Point(415, 74)
        Me.txtValorMaximo.Name = "txtValorMaximo"
        Me.txtValorMaximo.Size = New System.Drawing.Size(77, 20)
        Me.txtValorMaximo.TabIndex = 19
        Me.txtValorMaximo.Text = "0,0000"
        Me.txtValorMaximo.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorMinimo
        '
        Me.lblValorMinimo.AutoSize = True
        Me.lblValorMinimo.Location = New System.Drawing.Point(329, 57)
        Me.lblValorMinimo.Name = "lblValorMinimo"
        Me.lblValorMinimo.Size = New System.Drawing.Size(70, 14)
        Me.lblValorMinimo.TabIndex = 16
        Me.lblValorMinimo.Text = "Valor Mínimo:"
        '
        'txtValorMinimo
        '
        Me.txtValorMinimo.DecimalDigits = 4
        Me.txtValorMinimo.Location = New System.Drawing.Point(332, 74)
        Me.txtValorMinimo.Name = "txtValorMinimo"
        Me.txtValorMinimo.Size = New System.Drawing.Size(77, 20)
        Me.txtValorMinimo.TabIndex = 17
        Me.txtValorMinimo.Text = "0,0000"
        Me.txtValorMinimo.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorNominal
        '
        Me.lblValorNominal.AutoSize = True
        Me.lblValorNominal.Location = New System.Drawing.Point(8, 57)
        Me.lblValorNominal.Name = "lblValorNominal"
        Me.lblValorNominal.Size = New System.Drawing.Size(75, 14)
        Me.lblValorNominal.TabIndex = 10
        Me.lblValorNominal.Text = "Valor Nominal:"
        '
        'cboClasseTolerancia
        '
        Me.cboClasseTolerancia.AutoSize = False
        Me.cboClasseTolerancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClasseTolerancia.Location = New System.Drawing.Point(361, 34)
        Me.cboClasseTolerancia.Name = "cboClasseTolerancia"
        Me.cboClasseTolerancia.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClasseTolerancia.Size = New System.Drawing.Size(157, 20)
        Me.cboClasseTolerancia.TabIndex = 5
        '
        'lblClasseTolerancia
        '
        Me.lblClasseTolerancia.AutoSize = True
        Me.lblClasseTolerancia.Location = New System.Drawing.Point(358, 17)
        Me.lblClasseTolerancia.Name = "lblClasseTolerancia"
        Me.lblClasseTolerancia.Size = New System.Drawing.Size(110, 14)
        Me.lblClasseTolerancia.TabIndex = 4
        Me.lblClasseTolerancia.Text = "Classe de Tolerância:"
        '
        'cboCaracteristica
        '
        Me.cboCaracteristica.AutoSize = False
        Me.cboCaracteristica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCaracteristica.Location = New System.Drawing.Point(11, 34)
        Me.cboCaracteristica.Name = "cboCaracteristica"
        Me.cboCaracteristica.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCaracteristica.Size = New System.Drawing.Size(163, 20)
        Me.cboCaracteristica.TabIndex = 1
        '
        'lblCaracteristica
        '
        Me.lblCaracteristica.AutoSize = True
        Me.lblCaracteristica.Location = New System.Drawing.Point(8, 17)
        Me.lblCaracteristica.Name = "lblCaracteristica"
        Me.lblCaracteristica.Size = New System.Drawing.Size(77, 14)
        Me.lblCaracteristica.TabIndex = 0
        Me.lblCaracteristica.Text = "Característica:"
        '
        'btnExcluirCaracteristica
        '
        Me.btnExcluirCaracteristica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirCaracteristica.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirCaracteristica.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirCaracteristica.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirCaracteristica.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirCaracteristica.Name = "btnExcluirCaracteristica"
        Me.btnExcluirCaracteristica.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirCaracteristica.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirCaracteristica.TabIndex = 25
        Me.btnExcluirCaracteristica.Text = "Excluir"
        Me.btnExcluirCaracteristica.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirCaracteristica
        '
        Me.btnInserirCaracteristica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirCaracteristica.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirCaracteristica.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirCaracteristica.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirCaracteristica.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirCaracteristica.Name = "btnInserirCaracteristica"
        Me.btnInserirCaracteristica.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirCaracteristica.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirCaracteristica.TabIndex = 24
        Me.btnInserirCaracteristica.Text = "Inserir"
        Me.btnInserirCaracteristica.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdQualidade
        '
        Me.grdQualidade.AlternatingColors = True
        Me.grdQualidade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdQualidade_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdQualidade_DesignTimeLayout_Reference_0.Instance"), Object)
        grdQualidade_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdQualidade_DesignTimeLayout_Reference_0})
        grdQualidade_DesignTimeLayout.LayoutString = resources.GetString("grdQualidade_DesignTimeLayout.LayoutString")
        Me.grdQualidade.DesignTimeLayout = grdQualidade_DesignTimeLayout
        Me.grdQualidade.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdQualidade.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdQualidade.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdQualidade.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdQualidade.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdQualidade.GroupByBoxVisible = False
        Me.grdQualidade.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdQualidade.Location = New System.Drawing.Point(8, 113)
        Me.grdQualidade.Name = "grdQualidade"
        Me.grdQualidade.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdQualidade.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdQualidade.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdQualidade.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdQualidade.Size = New System.Drawing.Size(879, 256)
        Me.grdQualidade.TabIndex = 1
        Me.grdQualidade.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdQualidade.TabStop = False
        Me.grdQualidade.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdQualidade.VisualStyleManager = Me.vsmMain
        '
        'pagArquivos
        '
        Me.pagArquivos.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagArquivos.Controls.Add(Me.grdArquivo)
        Me.pagArquivos.Controls.Add(Me.grpArquivo)
        Me.pagArquivos.Key = "pagArquivos"
        Me.pagArquivos.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivos.Name = "pagArquivos"
        Me.pagArquivos.Size = New System.Drawing.Size(895, 378)
        Me.pagArquivos.TabStop = True
        Me.pagArquivos.Text = "Arquivos"
        '
        'btnConfigurarGridArquivo
        '
        Me.btnConfigurarGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 352)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(48, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 2
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'grdArquivo
        '
        Me.grdArquivo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdArquivo.AlternatingColors = True
        Me.grdArquivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdArquivo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdArquivo_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_1.Instance"), Object)
        grdArquivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivo_DesignTimeLayout_Reference_0, grdArquivo_DesignTimeLayout_Reference_1})
        grdArquivo_DesignTimeLayout.LayoutString = resources.GetString("grdArquivo_DesignTimeLayout.LayoutString")
        Me.grdArquivo.DesignTimeLayout = grdArquivo_DesignTimeLayout
        Me.grdArquivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdArquivo.FrozenColumns = 3
        Me.grdArquivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivo.GroupByBoxVisible = False
        Me.grdArquivo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdArquivo.Location = New System.Drawing.Point(8, 116)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 253)
        Me.grdArquivo.TabIndex = 1
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.txtDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(879, 104)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(650, 74)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 9
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(8, 57)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 7
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(11, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(640, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
        '
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(11, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(648, 20)
        Me.txtDescricaoArquivo.TabIndex = 3
        '
        'lblDescricaoArquivo
        '
        Me.lblDescricaoArquivo.AutoSize = True
        Me.lblDescricaoArquivo.Location = New System.Drawing.Point(8, 17)
        Me.lblDescricaoArquivo.Name = "lblDescricaoArquivo"
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoArquivo.TabIndex = 2
        Me.lblDescricaoArquivo.Text = "Descrição:"
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirArquivo.Name = "btnExcluirArquivo"
        Me.btnExcluirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivo.TabIndex = 11
        Me.btnExcluirArquivo.Text = "Excluir"
        Me.btnExcluirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirArquivo
        '
        Me.btnInserirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirArquivo.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirArquivo.Name = "btnInserirArquivo"
        Me.btnInserirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirArquivo.TabIndex = 10
        Me.btnInserirArquivo.Text = "Inserir"
        Me.btnInserirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrQARelatorioInspecao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrQARelatorioInspecao"
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
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaCaracteristicaAprovada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCaracteristicaReprovada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosGerais.ResumeLayout(False)
        Me.grpDadosGerais.PerformLayout()
        Me.pagInspecao.ResumeLayout(False)
        CType(Me.grpCaracteristicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCaracteristicas.ResumeLayout(False)
        Me.grpCaracteristicas.PerformLayout()
        CType(Me.grdQualidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagArquivos.ResumeLayout(False)
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
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
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroRIFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNumeroRIFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblQuantidadeOP As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeOP As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagInspecao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagArquivos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblQuantidadeInspecao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeInspecao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grdQualidade As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaCaracteristicaReprovada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCaracteristicaAprovado As System.Windows.Forms.Label
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtData As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroRI As System.Windows.Forms.Label
    Friend WithEvents txtNumeroRI As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDesenho As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDesenho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNorma As System.Windows.Forms.Label
    Friend WithEvents txtNorma As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEstagio As System.Windows.Forms.Label
    Friend WithEvents txtEstagio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblVeiculo As System.Windows.Forms.Label
    Friend WithEvents txtVeiculo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRevisao As System.Windows.Forms.Label
    Friend WithEvents txtRevisao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroSerieTermino As System.Windows.Forms.Label
    Friend WithEvents txtNumeroSerieTermino As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroSerialInicial As System.Windows.Forms.Label
    Friend WithEvents txtNumeroSerieInicial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents picLegendaCaracteristicaAprovada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCaracteristicaReprovada As System.Windows.Forms.Label
    Friend WithEvents chkProdutoSeriado As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnNovaInspecao As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMascaraInspecao As System.Windows.Forms.Label
    Friend WithEvents cboMascaraInspecao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblStatusInspecao As System.Windows.Forms.Label
    Friend WithEvents cboStatus As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpCaracteristicas As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblObservacaoCaracteristica As System.Windows.Forms.Label
    Friend WithEvents txtObservacaoCaracteristica As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblValorEncontrado As System.Windows.Forms.Label
    Friend WithEvents lblValorMaximo As System.Windows.Forms.Label
    Friend WithEvents lblValorMinimo As System.Windows.Forms.Label
    Friend WithEvents lblValorNominal As System.Windows.Forms.Label
    Friend WithEvents cboClasseTolerancia As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblClasseTolerancia As System.Windows.Forms.Label
    Friend WithEvents cboCaracteristica As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCaracteristica As System.Windows.Forms.Label
    Friend WithEvents btnExcluirCaracteristica As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirCaracteristica As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboEquipamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblEquipamento As System.Windows.Forms.Label
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosGerais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNormaInspecao As System.Windows.Forms.Label
    Friend WithEvents cboNormaInspecao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnUltimoRegistro As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnRegistroAnterior As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProximoRegistro As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtValorMaximo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorMinimo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCapacidade As System.Windows.Forms.Label
    Friend WithEvents txtCapacidade As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnNovaInspecaoDados As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNivelamento As Label
    Friend WithEvents txtNivelamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNivelInspecao As Label
    Friend WithEvents txtNivelInspecao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInspecaoDimensional As Label
    Friend WithEvents txtInspecaoDimensional As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInspecaoVisual As Label
    Friend WithEvents txtInspecaoVisual As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedor As Label
    Friend WithEvents txtFornecedor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCoordenacao As Label
    Friend WithEvents txtCoordenacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOutros As Label
    Friend WithEvents txtOutros As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAmbiente As Label
    Friend WithEvents txtAmbiente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAlinhamento As Label
    Friend WithEvents txtAlinhamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPintura As Label
    Friend WithEvents txtPintura As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblIdentificacao As Label
    Friend WithEvents txtIdentificacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrigem As Label
    Friend WithEvents txtOrigem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItemFiltro As System.Windows.Forms.Label
    Friend WithEvents lblOrdemProducaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValorNominal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtValorEncontrado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblToleranciaMaxima As System.Windows.Forms.Label
    Friend WithEvents txtToleranciaMaxima As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblToleranciaMinima As System.Windows.Forms.Label
    Friend WithEvents txtToleranciaMinima As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
