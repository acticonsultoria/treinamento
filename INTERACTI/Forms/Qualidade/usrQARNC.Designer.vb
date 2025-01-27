<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrQARNC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrQARNC))
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdHistorico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDisposicaoFiltro = New System.Windows.Forms.Label()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.lblOrdemProducaoFiltro = New System.Windows.Forms.Label()
        Me.txtOrdemProducaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboDisposicaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroRNCFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblNumeroRNCFiltro = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirRNC = New Janus.Windows.EditControls.UIButton()
        Me.btnNovoRNC = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCombosRNC = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAbertoPor = New System.Windows.Forms.Label()
        Me.cboAbertoPor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.cboMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoNC = New System.Windows.Forms.Label()
        Me.cboGrupoNC = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCausaNC = New System.Windows.Forms.Label()
        Me.cboCausaRNC = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNaoConformidadeDetectada = New System.Windows.Forms.Label()
        Me.cboNaoConformidadeDetectada = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOperacaoOrigemNC = New System.Windows.Forms.Label()
        Me.cboOperacaoOrigemNC = New Janus.Windows.EditControls.UIComboBox()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblImpacto = New System.Windows.Forms.Label()
        Me.cboImpacto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQtdOP = New System.Windows.Forms.Label()
        Me.txtQtdOP = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtItemNC = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboResponsavel = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDisposicao = New System.Windows.Forms.Label()
        Me.cboDisposicao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblItemNC = New System.Windows.Forms.Label()
        Me.lblQtdNC = New System.Windows.Forms.Label()
        Me.txtQtdNC = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.lblFonte = New System.Windows.Forms.Label()
        Me.cboFonte = New Janus.Windows.EditControls.UIComboBox()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroRNC = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRNC = New System.Windows.Forms.Label()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProsseguirProducao = New Janus.Windows.EditControls.UIButton()
        Me.btnUltimoRegistro = New Janus.Windows.EditControls.UIButton()
        Me.btnRegistroAnterior = New Janus.Windows.EditControls.UIButton()
        Me.btnProximoRegistro = New Janus.Windows.EditControls.UIButton()
        Me.btnNovoRNCDados = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDescricaoRNC = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDescricaoRNC = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAnalise = New System.Windows.Forms.Label()
        Me.lblDescricaoNC = New System.Windows.Forms.Label()
        Me.txtDescricaoNC = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtAnalise = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagAcaoImediata = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpAcaoImediata = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboAtendidoPorAcaoImediata = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAtendidoPorAcaoImediata = New System.Windows.Forms.Label()
        Me.lblAcaoImediata = New System.Windows.Forms.Label()
        Me.txtAcaoImediata = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagAnaliseCausa = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpAnaliseCausa = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboAnalisadoPorAnaliseCausa = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAnalisadoPorAnaliseCausa = New System.Windows.Forms.Label()
        Me.lblAnaliseCausa = New System.Windows.Forms.Label()
        Me.txtAnaliseCausa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagAcaoCorretiva = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpAcaoCorretiva = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataAcaoCorretiva = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataAcaoCorretiva = New System.Windows.Forms.Label()
        Me.cboResponsavelAcaoCorretiva = New Janus.Windows.EditControls.UIComboBox()
        Me.lblResponsavelAcaoCorretiva = New System.Windows.Forms.Label()
        Me.cboAutorizadoPorAcaoCorretiva = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAutorizadoPorAcaoCorretiva = New System.Windows.Forms.Label()
        Me.lblAcaoCorretiva = New System.Windows.Forms.Label()
        Me.txtAcaoCorretiva = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagConclusao = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDadosConclusao = New Janus.Windows.UI.Tab.UITab()
        Me.pagObservacao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpObservacaoConclusao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblObservacaoConclusao = New System.Windows.Forms.Label()
        Me.txtObservacaoConclusao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagDadosRI = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCaracteristicas = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblToleranciaMax = New System.Windows.Forms.Label()
        Me.txtToleranciaMax = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtValorEncontrado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtValorNominal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSequenciaCaracteristica = New System.Windows.Forms.Label()
        Me.txtSequenciaCaracteristica = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtValorMaximo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorMinimo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroRI = New System.Windows.Forms.Label()
        Me.txtNumeroRI = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtEquipamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtClasseTolerancia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCaracteristica = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEquipamento = New System.Windows.Forms.Label()
        Me.lblObservacaoCaracteristica = New System.Windows.Forms.Label()
        Me.txtObservacaoCaracteristica = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValorEncontrado = New System.Windows.Forms.Label()
        Me.lblToleranciaMin = New System.Windows.Forms.Label()
        Me.txtToleranciaMin = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValorMaximo = New System.Windows.Forms.Label()
        Me.lblValorMinimo = New System.Windows.Forms.Label()
        Me.lblValorNominal = New System.Windows.Forms.Label()
        Me.lblClasseTolerancia = New System.Windows.Forms.Label()
        Me.lblCaracteristica = New System.Windows.Forms.Label()
        Me.PagArquivos = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.btnGerarSAC = New Janus.Windows.EditControls.UIButton()
        Me.pagHistorico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.grdHistorico = New Janus.Windows.GridEX.GridEX()
        Me.btnInserirHistorico = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grpCombosRNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCombosRNC.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDescricaoRNC.SuspendLayout()
        CType(Me.grpDescricaoRNC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDescricaoRNC.SuspendLayout()
        Me.pagAcaoImediata.SuspendLayout()
        CType(Me.grpAcaoImediata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAcaoImediata.SuspendLayout()
        Me.pagAnaliseCausa.SuspendLayout()
        CType(Me.grpAnaliseCausa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAnaliseCausa.SuspendLayout()
        Me.pagAcaoCorretiva.SuspendLayout()
        CType(Me.grpAcaoCorretiva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAcaoCorretiva.SuspendLayout()
        Me.pagConclusao.SuspendLayout()
        CType(Me.tabDadosConclusao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDadosConclusao.SuspendLayout()
        Me.pagObservacao.SuspendLayout()
        CType(Me.grpObservacaoConclusao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpObservacaoConclusao.SuspendLayout()
        Me.pagDadosRI.SuspendLayout()
        CType(Me.grpCaracteristicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCaracteristicas.SuspendLayout()
        Me.PagArquivos.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagHistorico.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grdHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagListagem.Text = "Qualidade - RNC"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDisposicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboDisposicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroRNCFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblNumeroRNCFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 98)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(6, 55)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 46
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 72)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(183, 20)
        Me.cboStatusFiltro.TabIndex = 6
        '
        'txtItemFiltro
        '
        Me.txtItemFiltro.IncludeLiterals = False
        Me.txtItemFiltro.Location = New System.Drawing.Point(395, 34)
        Me.txtItemFiltro.MaxLength = 20
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtItemFiltro.Size = New System.Drawing.Size(230, 20)
        Me.txtItemFiltro.TabIndex = 4
        '
        'lblDisposicaoFiltro
        '
        Me.lblDisposicaoFiltro.AutoSize = True
        Me.lblDisposicaoFiltro.Location = New System.Drawing.Point(628, 17)
        Me.lblDisposicaoFiltro.Name = "lblDisposicaoFiltro"
        Me.lblDisposicaoFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblDisposicaoFiltro.TabIndex = 30
        Me.lblDisposicaoFiltro.Text = "Disposição:"
        '
        'lblItemFiltro
        '
        Me.lblItemFiltro.AutoSize = True
        Me.lblItemFiltro.Location = New System.Drawing.Point(392, 17)
        Me.lblItemFiltro.Name = "lblItemFiltro"
        Me.lblItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblItemFiltro.TabIndex = 29
        Me.lblItemFiltro.Text = "Item:"
        '
        'lblOrdemProducaoFiltro
        '
        Me.lblOrdemProducaoFiltro.AutoSize = True
        Me.lblOrdemProducaoFiltro.Location = New System.Drawing.Point(298, 17)
        Me.lblOrdemProducaoFiltro.Name = "lblOrdemProducaoFiltro"
        Me.lblOrdemProducaoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducaoFiltro.TabIndex = 28
        Me.lblOrdemProducaoFiltro.Text = "Ordem Produção:"
        '
        'txtOrdemProducaoFiltro
        '
        Me.txtOrdemProducaoFiltro.IncludeLiterals = False
        Me.txtOrdemProducaoFiltro.Location = New System.Drawing.Point(301, 34)
        Me.txtOrdemProducaoFiltro.MaxLength = 20
        Me.txtOrdemProducaoFiltro.Name = "txtOrdemProducaoFiltro"
        Me.txtOrdemProducaoFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtOrdemProducaoFiltro.Size = New System.Drawing.Size(88, 20)
        Me.txtOrdemProducaoFiltro.TabIndex = 3
        '
        'cboDisposicaoFiltro
        '
        Me.cboDisposicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDisposicaoFiltro.Location = New System.Drawing.Point(631, 34)
        Me.cboDisposicaoFiltro.Name = "cboDisposicaoFiltro"
        Me.cboDisposicaoFiltro.Size = New System.Drawing.Size(152, 20)
        Me.cboDisposicaoFiltro.TabIndex = 5
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(95, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(97, 20)
        Me.dtpDataInicioFiltro.TabIndex = 1
        Me.dtpDataInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(198, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(97, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 2
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(92, 17)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 22
        Me.lblDataFiltro.Text = "Data:"
        '
        'txtNumeroRNCFiltro
        '
        Me.txtNumeroRNCFiltro.IncludeLiterals = False
        Me.txtNumeroRNCFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRNCFiltro.MaxLength = 20
        Me.txtNumeroRNCFiltro.Name = "txtNumeroRNCFiltro"
        Me.txtNumeroRNCFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroRNCFiltro.Size = New System.Drawing.Size(80, 20)
        Me.txtNumeroRNCFiltro.TabIndex = 0
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 46)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 7
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblNumeroRNCFiltro
        '
        Me.lblNumeroRNCFiltro.AutoSize = True
        Me.lblNumeroRNCFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRNCFiltro.Name = "lblNumeroRNCFiltro"
        Me.lblNumeroRNCFiltro.Size = New System.Drawing.Size(45, 14)
        Me.lblNumeroRNCFiltro.TabIndex = 0
        Me.lblNumeroRNCFiltro.Text = "N° RNC:"
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
        Me.grpControle.Controls.Add(Me.btnExcluirRNC)
        Me.grpControle.Controls.Add(Me.btnNovoRNC)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 1
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirRNC
        '
        Me.btnExcluirRNC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirRNC.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirRNC.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirRNC.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirRNC.Location = New System.Drawing.Point(580, 18)
        Me.btnExcluirRNC.Name = "btnExcluirRNC"
        Me.btnExcluirRNC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirRNC.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirRNC.TabIndex = 0
        Me.btnExcluirRNC.Text = "Excluir"
        Me.btnExcluirRNC.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovoRNC
        '
        Me.btnNovoRNC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoRNC.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovoRNC.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovoRNC.Location = New System.Drawing.Point(677, 18)
        Me.btnNovoRNC.Name = "btnNovoRNC"
        Me.btnNovoRNC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovoRNC.Size = New System.Drawing.Size(114, 23)
        Me.btnNovoRNC.TabIndex = 1
        Me.btnNovoRNC.Text = "Novo RNC"
        Me.btnNovoRNC.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 107)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 372)
        Me.grdListagem.TabIndex = 13
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpCombosRNC)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Qualidade - RNC"
        '
        'grpCombosRNC
        '
        Me.grpCombosRNC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpCombosRNC.BackColor = System.Drawing.Color.Transparent
        Me.grpCombosRNC.Controls.Add(Me.lblAbertoPor)
        Me.grpCombosRNC.Controls.Add(Me.cboAbertoPor)
        Me.grpCombosRNC.Controls.Add(Me.lblMaquina)
        Me.grpCombosRNC.Controls.Add(Me.cboMaquina)
        Me.grpCombosRNC.Controls.Add(Me.lblOperacao)
        Me.grpCombosRNC.Controls.Add(Me.cboOperacao)
        Me.grpCombosRNC.Controls.Add(Me.lblGrupoNC)
        Me.grpCombosRNC.Controls.Add(Me.cboGrupoNC)
        Me.grpCombosRNC.Controls.Add(Me.lblCausaNC)
        Me.grpCombosRNC.Controls.Add(Me.cboCausaRNC)
        Me.grpCombosRNC.Controls.Add(Me.lblNaoConformidadeDetectada)
        Me.grpCombosRNC.Controls.Add(Me.cboNaoConformidadeDetectada)
        Me.grpCombosRNC.Controls.Add(Me.lblOperacaoOrigemNC)
        Me.grpCombosRNC.Controls.Add(Me.cboOperacaoOrigemNC)
        Me.grpCombosRNC.Location = New System.Drawing.Point(9, 113)
        Me.grpCombosRNC.Name = "grpCombosRNC"
        Me.grpCombosRNC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCombosRNC.Size = New System.Drawing.Size(261, 368)
        Me.grpCombosRNC.TabIndex = 1
        Me.grpCombosRNC.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpCombosRNC.VisualStyleManager = Me.vsmMain
        '
        'lblAbertoPor
        '
        Me.lblAbertoPor.AutoSize = True
        Me.lblAbertoPor.Location = New System.Drawing.Point(6, 177)
        Me.lblAbertoPor.Name = "lblAbertoPor"
        Me.lblAbertoPor.Size = New System.Drawing.Size(62, 14)
        Me.lblAbertoPor.TabIndex = 12
        Me.lblAbertoPor.Text = "Aberto Por:"
        '
        'cboAbertoPor
        '
        Me.cboAbertoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAbertoPor.Location = New System.Drawing.Point(9, 194)
        Me.cboAbertoPor.Name = "cboAbertoPor"
        Me.cboAbertoPor.Size = New System.Drawing.Size(246, 20)
        Me.cboAbertoPor.TabIndex = 4
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.Location = New System.Drawing.Point(6, 137)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(94, 14)
        Me.lblMaquina.TabIndex = 10
        Me.lblMaquina.Text = "Máquina/Recurso:"
        '
        'cboMaquina
        '
        Me.cboMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMaquina.Location = New System.Drawing.Point(9, 154)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Size = New System.Drawing.Size(246, 20)
        Me.cboMaquina.TabIndex = 3
        '
        'lblOperacao
        '
        Me.lblOperacao.AutoSize = True
        Me.lblOperacao.Location = New System.Drawing.Point(6, 17)
        Me.lblOperacao.Name = "lblOperacao"
        Me.lblOperacao.Size = New System.Drawing.Size(58, 14)
        Me.lblOperacao.TabIndex = 2
        Me.lblOperacao.Text = "Operação:"
        '
        'cboOperacao
        '
        Me.cboOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOperacao.Location = New System.Drawing.Point(9, 34)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Size = New System.Drawing.Size(246, 20)
        Me.cboOperacao.TabIndex = 0
        '
        'lblGrupoNC
        '
        Me.lblGrupoNC.AutoSize = True
        Me.lblGrupoNC.Location = New System.Drawing.Point(6, 57)
        Me.lblGrupoNC.Name = "lblGrupoNC"
        Me.lblGrupoNC.Size = New System.Drawing.Size(72, 14)
        Me.lblGrupoNC.TabIndex = 4
        Me.lblGrupoNC.Text = "Grupo de NC:"
        '
        'cboGrupoNC
        '
        Me.cboGrupoNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoNC.Location = New System.Drawing.Point(9, 74)
        Me.cboGrupoNC.Name = "cboGrupoNC"
        Me.cboGrupoNC.Size = New System.Drawing.Size(246, 20)
        Me.cboGrupoNC.TabIndex = 1
        '
        'lblCausaNC
        '
        Me.lblCausaNC.AutoSize = True
        Me.lblCausaNC.Location = New System.Drawing.Point(6, 257)
        Me.lblCausaNC.Name = "lblCausaNC"
        Me.lblCausaNC.Size = New System.Drawing.Size(73, 14)
        Me.lblCausaNC.TabIndex = 8
        Me.lblCausaNC.Text = "Causa da NC:"
        '
        'cboCausaRNC
        '
        Me.cboCausaRNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCausaRNC.Location = New System.Drawing.Point(9, 274)
        Me.cboCausaRNC.Name = "cboCausaRNC"
        Me.cboCausaRNC.Size = New System.Drawing.Size(246, 20)
        Me.cboCausaRNC.TabIndex = 6
        '
        'lblNaoConformidadeDetectada
        '
        Me.lblNaoConformidadeDetectada.AutoSize = True
        Me.lblNaoConformidadeDetectada.Location = New System.Drawing.Point(6, 97)
        Me.lblNaoConformidadeDetectada.Name = "lblNaoConformidadeDetectada"
        Me.lblNaoConformidadeDetectada.Size = New System.Drawing.Size(76, 14)
        Me.lblNaoConformidadeDetectada.TabIndex = 6
        Me.lblNaoConformidadeDetectada.Text = "NC Detectada:"
        '
        'cboNaoConformidadeDetectada
        '
        Me.cboNaoConformidadeDetectada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNaoConformidadeDetectada.Location = New System.Drawing.Point(9, 114)
        Me.cboNaoConformidadeDetectada.Name = "cboNaoConformidadeDetectada"
        Me.cboNaoConformidadeDetectada.Size = New System.Drawing.Size(246, 20)
        Me.cboNaoConformidadeDetectada.TabIndex = 2
        '
        'lblOperacaoOrigemNC
        '
        Me.lblOperacaoOrigemNC.AutoSize = True
        Me.lblOperacaoOrigemNC.Location = New System.Drawing.Point(6, 217)
        Me.lblOperacaoOrigemNC.Name = "lblOperacaoOrigemNC"
        Me.lblOperacaoOrigemNC.Size = New System.Drawing.Size(120, 14)
        Me.lblOperacaoOrigemNC.TabIndex = 0
        Me.lblOperacaoOrigemNC.Text = "Operação (Origem NC):"
        '
        'cboOperacaoOrigemNC
        '
        Me.cboOperacaoOrigemNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOperacaoOrigemNC.Location = New System.Drawing.Point(9, 234)
        Me.cboOperacaoOrigemNC.Name = "cboOperacaoOrigemNC"
        Me.cboOperacaoOrigemNC.Size = New System.Drawing.Size(246, 20)
        Me.cboOperacaoOrigemNC.TabIndex = 5
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblImpacto)
        Me.grpDados.Controls.Add(Me.cboImpacto)
        Me.grpDados.Controls.Add(Me.lblStatus)
        Me.grpDados.Controls.Add(Me.cboStatus)
        Me.grpDados.Controls.Add(Me.lblQtdOP)
        Me.grpDados.Controls.Add(Me.txtQtdOP)
        Me.grpDados.Controls.Add(Me.txtItemNC)
        Me.grpDados.Controls.Add(Me.cboResponsavel)
        Me.grpDados.Controls.Add(Me.lblDisposicao)
        Me.grpDados.Controls.Add(Me.cboDisposicao)
        Me.grpDados.Controls.Add(Me.lblItemNC)
        Me.grpDados.Controls.Add(Me.lblQtdNC)
        Me.grpDados.Controls.Add(Me.txtQtdNC)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblFonte)
        Me.grpDados.Controls.Add(Me.cboFonte)
        Me.grpDados.Controls.Add(Me.lblResponsavel)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.dtpData)
        Me.grpDados.Controls.Add(Me.txtNumeroRNC)
        Me.grpDados.Controls.Add(Me.lblNumeroRNC)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(9, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(896, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblImpacto
        '
        Me.lblImpacto.AutoSize = True
        Me.lblImpacto.Location = New System.Drawing.Point(687, 58)
        Me.lblImpacto.Name = "lblImpacto"
        Me.lblImpacto.Size = New System.Drawing.Size(47, 14)
        Me.lblImpacto.TabIndex = 46
        Me.lblImpacto.Text = "Impacto:"
        '
        'cboImpacto
        '
        Me.cboImpacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboImpacto.Location = New System.Drawing.Point(690, 75)
        Me.cboImpacto.Name = "cboImpacto"
        Me.cboImpacto.Size = New System.Drawing.Size(197, 20)
        Me.cboImpacto.TabIndex = 10
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(440, 58)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(41, 14)
        Me.lblStatus.TabIndex = 44
        Me.lblStatus.Text = "Status:"
        '
        'cboStatus
        '
        Me.cboStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatus.Location = New System.Drawing.Point(443, 75)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(241, 20)
        Me.cboStatus.TabIndex = 9
        '
        'lblQtdOP
        '
        Me.lblQtdOP.AutoSize = True
        Me.lblQtdOP.Location = New System.Drawing.Point(440, 17)
        Me.lblQtdOP.Name = "lblQtdOP"
        Me.lblQtdOP.Size = New System.Drawing.Size(44, 14)
        Me.lblQtdOP.TabIndex = 42
        Me.lblQtdOP.Text = "Qtd OP:"
        '
        'txtQtdOP
        '
        Me.txtQtdOP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQtdOP.DecimalDigits = 2
        Me.txtQtdOP.Location = New System.Drawing.Point(443, 34)
        Me.txtQtdOP.Name = "txtQtdOP"
        Me.txtQtdOP.ReadOnly = True
        Me.txtQtdOP.Size = New System.Drawing.Size(99, 20)
        Me.txtQtdOP.TabIndex = 3
        Me.txtQtdOP.TabStop = False
        Me.txtQtdOP.Text = "0,00"
        Me.txtQtdOP.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtItemNC
        '
        Me.txtItemNC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItemNC.IncludeLiterals = False
        Me.txtItemNC.Location = New System.Drawing.Point(170, 34)
        Me.txtItemNC.MaxLength = 20
        Me.txtItemNC.Name = "txtItemNC"
        Me.txtItemNC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtItemNC.ReadOnly = True
        Me.txtItemNC.Size = New System.Drawing.Size(266, 20)
        Me.txtItemNC.TabIndex = 2
        Me.txtItemNC.TabStop = False
        '
        'cboResponsavel
        '
        Me.cboResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsavel.Location = New System.Drawing.Point(690, 34)
        Me.cboResponsavel.Name = "cboResponsavel"
        Me.cboResponsavel.Size = New System.Drawing.Size(197, 20)
        Me.cboResponsavel.TabIndex = 5
        '
        'lblDisposicao
        '
        Me.lblDisposicao.AutoSize = True
        Me.lblDisposicao.Location = New System.Drawing.Point(273, 58)
        Me.lblDisposicao.Name = "lblDisposicao"
        Me.lblDisposicao.Size = New System.Drawing.Size(63, 14)
        Me.lblDisposicao.TabIndex = 39
        Me.lblDisposicao.Text = "Disposição:"
        '
        'cboDisposicao
        '
        Me.cboDisposicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDisposicao.Location = New System.Drawing.Point(276, 75)
        Me.cboDisposicao.Name = "cboDisposicao"
        Me.cboDisposicao.Size = New System.Drawing.Size(160, 20)
        Me.cboDisposicao.TabIndex = 8
        '
        'lblItemNC
        '
        Me.lblItemNC.AutoSize = True
        Me.lblItemNC.Location = New System.Drawing.Point(167, 17)
        Me.lblItemNC.Name = "lblItemNC"
        Me.lblItemNC.Size = New System.Drawing.Size(29, 14)
        Me.lblItemNC.TabIndex = 35
        Me.lblItemNC.Text = "Item:"
        '
        'lblQtdNC
        '
        Me.lblQtdNC.AutoSize = True
        Me.lblQtdNC.Location = New System.Drawing.Point(167, 58)
        Me.lblQtdNC.Name = "lblQtdNC"
        Me.lblQtdNC.Size = New System.Drawing.Size(44, 14)
        Me.lblQtdNC.TabIndex = 33
        Me.lblQtdNC.Text = "Qtd NC:"
        '
        'txtQtdNC
        '
        Me.txtQtdNC.DecimalDigits = 2
        Me.txtQtdNC.Location = New System.Drawing.Point(170, 75)
        Me.txtQtdNC.Name = "txtQtdNC"
        Me.txtQtdNC.Size = New System.Drawing.Size(100, 20)
        Me.txtQtdNC.TabIndex = 7
        Me.txtQtdNC.Text = "0,00"
        Me.txtQtdNC.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.IncludeLiterals = False
        Me.txtOrdemProducao.Location = New System.Drawing.Point(76, 34)
        Me.txtOrdemProducao.MaxLength = 20
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.Size = New System.Drawing.Size(88, 20)
        Me.txtOrdemProducao.TabIndex = 1
        Me.txtOrdemProducao.TabStop = False
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(73, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducao.TabIndex = 28
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'lblFonte
        '
        Me.lblFonte.AutoSize = True
        Me.lblFonte.Location = New System.Drawing.Point(6, 58)
        Me.lblFonte.Name = "lblFonte"
        Me.lblFonte.Size = New System.Drawing.Size(37, 14)
        Me.lblFonte.TabIndex = 27
        Me.lblFonte.Text = "Fonte:"
        '
        'cboFonte
        '
        Me.cboFonte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFonte.Location = New System.Drawing.Point(9, 75)
        Me.cboFonte.Name = "cboFonte"
        Me.cboFonte.Size = New System.Drawing.Size(155, 20)
        Me.cboFonte.TabIndex = 6
        '
        'lblResponsavel
        '
        Me.lblResponsavel.AutoSize = True
        Me.lblResponsavel.Location = New System.Drawing.Point(687, 17)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavel.TabIndex = 25
        Me.lblResponsavel.Text = "Responsável:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(545, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 23
        Me.lblData.Text = "Data:"
        '
        'dtpData
        '
        Me.dtpData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dtpData.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(548, 34)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.ReadOnly = True
        Me.dtpData.Size = New System.Drawing.Size(136, 20)
        Me.dtpData.TabIndex = 4
        Me.dtpData.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtNumeroRNC
        '
        Me.txtNumeroRNC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRNC.IncludeLiterals = False
        Me.txtNumeroRNC.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRNC.MaxLength = 20
        Me.txtNumeroRNC.Name = "txtNumeroRNC"
        Me.txtNumeroRNC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroRNC.ReadOnly = True
        Me.txtNumeroRNC.Size = New System.Drawing.Size(61, 20)
        Me.txtNumeroRNC.TabIndex = 0
        Me.txtNumeroRNC.TabStop = False
        '
        'lblNumeroRNC
        '
        Me.lblNumeroRNC.AutoSize = True
        Me.lblNumeroRNC.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRNC.Name = "lblNumeroRNC"
        Me.lblNumeroRNC.Size = New System.Drawing.Size(45, 14)
        Me.lblNumeroRNC.TabIndex = 2
        Me.lblNumeroRNC.Text = "N° RNC:"
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnProsseguirProducao)
        Me.grpControle2.Controls.Add(Me.btnUltimoRegistro)
        Me.grpControle2.Controls.Add(Me.btnRegistroAnterior)
        Me.grpControle2.Controls.Add(Me.btnProximoRegistro)
        Me.grpControle2.Controls.Add(Me.btnNovoRNCDados)
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Controls.Add(Me.btnSalvar)
        Me.grpControle2.Location = New System.Drawing.Point(9, 483)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(896, 51)
        Me.grpControle2.TabIndex = 3
        Me.grpControle2.VisualStyleManager = Me.vsmMain
        '
        'btnProsseguirProducao
        '
        Me.btnProsseguirProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProsseguirProducao.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnProsseguirProducao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProsseguirProducao.Location = New System.Drawing.Point(443, 17)
        Me.btnProsseguirProducao.Name = "btnProsseguirProducao"
        Me.btnProsseguirProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProsseguirProducao.Size = New System.Drawing.Size(130, 23)
        Me.btnProsseguirProducao.TabIndex = 3
        Me.btnProsseguirProducao.Text = "Prosseguir Produção"
        Me.btnProsseguirProducao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnUltimoRegistro
        '
        Me.btnUltimoRegistro.Image = CType(resources.GetObject("btnUltimoRegistro.Image"), System.Drawing.Image)
        Me.btnUltimoRegistro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnUltimoRegistro.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnUltimoRegistro.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.btnUltimoRegistro.Location = New System.Drawing.Point(63, 17)
        Me.btnUltimoRegistro.Name = "btnUltimoRegistro"
        Me.btnUltimoRegistro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnUltimoRegistro.Size = New System.Drawing.Size(21, 23)
        Me.btnUltimoRegistro.TabIndex = 2
        Me.btnUltimoRegistro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnRegistroAnterior
        '
        Me.btnRegistroAnterior.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnRegistroAnterior.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRegistroAnterior.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnRegistroAnterior.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.btnRegistroAnterior.Location = New System.Drawing.Point(9, 17)
        Me.btnRegistroAnterior.Name = "btnRegistroAnterior"
        Me.btnRegistroAnterior.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRegistroAnterior.Size = New System.Drawing.Size(21, 23)
        Me.btnRegistroAnterior.TabIndex = 0
        Me.btnRegistroAnterior.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProximoRegistro
        '
        Me.btnProximoRegistro.Image = Global.INTERACTI.My.Resources.Resources.seta_direita
        Me.btnProximoRegistro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProximoRegistro.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnProximoRegistro.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.btnProximoRegistro.Location = New System.Drawing.Point(36, 17)
        Me.btnProximoRegistro.Name = "btnProximoRegistro"
        Me.btnProximoRegistro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProximoRegistro.Size = New System.Drawing.Size(21, 23)
        Me.btnProximoRegistro.TabIndex = 1
        Me.btnProximoRegistro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovoRNCDados
        '
        Me.btnNovoRNCDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoRNCDados.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovoRNCDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovoRNCDados.Location = New System.Drawing.Point(579, 17)
        Me.btnNovoRNCDados.Name = "btnNovoRNCDados"
        Me.btnNovoRNCDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovoRNCDados.Size = New System.Drawing.Size(114, 23)
        Me.btnNovoRNCDados.TabIndex = 4
        Me.btnNovoRNCDados.Text = "Novo RNC"
        Me.btnNovoRNCDados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(796, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 6
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(699, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 5
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(276, 113)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(629, 368)
        Me.tabDados.TabIndex = 2
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDescricaoRNC, Me.pagAcaoImediata, Me.pagAnaliseCausa, Me.pagAcaoCorretiva, Me.pagConclusao, Me.pagHistorico})
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDescricaoRNC
        '
        Me.pagDescricaoRNC.Controls.Add(Me.grpDescricaoRNC)
        Me.pagDescricaoRNC.Key = "pagDescricaoRNC"
        Me.pagDescricaoRNC.Location = New System.Drawing.Point(1, 22)
        Me.pagDescricaoRNC.Name = "pagDescricaoRNC"
        Me.pagDescricaoRNC.Size = New System.Drawing.Size(627, 345)
        Me.pagDescricaoRNC.TabStop = True
        Me.pagDescricaoRNC.Text = "Descrição RNC"
        '
        'grpDescricaoRNC
        '
        Me.grpDescricaoRNC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDescricaoRNC.BackColor = System.Drawing.Color.Transparent
        Me.grpDescricaoRNC.Controls.Add(Me.lblAnalise)
        Me.grpDescricaoRNC.Controls.Add(Me.lblDescricaoNC)
        Me.grpDescricaoRNC.Controls.Add(Me.txtDescricaoNC)
        Me.grpDescricaoRNC.Controls.Add(Me.txtAnalise)
        Me.grpDescricaoRNC.Location = New System.Drawing.Point(9, 3)
        Me.grpDescricaoRNC.Name = "grpDescricaoRNC"
        Me.grpDescricaoRNC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDescricaoRNC.Size = New System.Drawing.Size(610, 335)
        Me.grpDescricaoRNC.TabIndex = 0
        Me.grpDescricaoRNC.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDescricaoRNC.VisualStyleManager = Me.vsmMain
        '
        'lblAnalise
        '
        Me.lblAnalise.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAnalise.AutoSize = True
        Me.lblAnalise.Location = New System.Drawing.Point(6, 171)
        Me.lblAnalise.Name = "lblAnalise"
        Me.lblAnalise.Size = New System.Drawing.Size(207, 14)
        Me.lblAnalise.TabIndex = 10
        Me.lblAnalise.Text = "Descrição Técnica da Não Conformidade:"
        '
        'lblDescricaoNC
        '
        Me.lblDescricaoNC.AutoSize = True
        Me.lblDescricaoNC.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoNC.Name = "lblDescricaoNC"
        Me.lblDescricaoNC.Size = New System.Drawing.Size(166, 14)
        Me.lblDescricaoNC.TabIndex = 8
        Me.lblDescricaoNC.Text = "Descrição da Não Conformidade:"
        '
        'txtDescricaoNC
        '
        Me.txtDescricaoNC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoNC.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoNC.MaxLength = 5000
        Me.txtDescricaoNC.Multiline = True
        Me.txtDescricaoNC.Name = "txtDescricaoNC"
        Me.txtDescricaoNC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescricaoNC.Size = New System.Drawing.Size(595, 130)
        Me.txtDescricaoNC.TabIndex = 0
        '
        'txtAnalise
        '
        Me.txtAnalise.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnalise.Location = New System.Drawing.Point(9, 188)
        Me.txtAnalise.MaxLength = 5000
        Me.txtAnalise.Multiline = True
        Me.txtAnalise.Name = "txtAnalise"
        Me.txtAnalise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnalise.Size = New System.Drawing.Size(595, 141)
        Me.txtAnalise.TabIndex = 1
        '
        'pagAcaoImediata
        '
        Me.pagAcaoImediata.Controls.Add(Me.grpAcaoImediata)
        Me.pagAcaoImediata.Key = "pagAcaoImediata"
        Me.pagAcaoImediata.Location = New System.Drawing.Point(1, 22)
        Me.pagAcaoImediata.Name = "pagAcaoImediata"
        Me.pagAcaoImediata.Size = New System.Drawing.Size(627, 345)
        Me.pagAcaoImediata.TabStop = True
        Me.pagAcaoImediata.Text = "Ação Imediata"
        '
        'grpAcaoImediata
        '
        Me.grpAcaoImediata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAcaoImediata.BackColor = System.Drawing.Color.Transparent
        Me.grpAcaoImediata.Controls.Add(Me.cboAtendidoPorAcaoImediata)
        Me.grpAcaoImediata.Controls.Add(Me.lblAtendidoPorAcaoImediata)
        Me.grpAcaoImediata.Controls.Add(Me.lblAcaoImediata)
        Me.grpAcaoImediata.Controls.Add(Me.txtAcaoImediata)
        Me.grpAcaoImediata.Location = New System.Drawing.Point(9, 3)
        Me.grpAcaoImediata.Name = "grpAcaoImediata"
        Me.grpAcaoImediata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAcaoImediata.Size = New System.Drawing.Size(610, 335)
        Me.grpAcaoImediata.TabIndex = 0
        Me.grpAcaoImediata.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpAcaoImediata.VisualStyleManager = Me.vsmMain
        '
        'cboAtendidoPorAcaoImediata
        '
        Me.cboAtendidoPorAcaoImediata.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAtendidoPorAcaoImediata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAtendidoPorAcaoImediata.Location = New System.Drawing.Point(10, 309)
        Me.cboAtendidoPorAcaoImediata.Name = "cboAtendidoPorAcaoImediata"
        Me.cboAtendidoPorAcaoImediata.Size = New System.Drawing.Size(594, 20)
        Me.cboAtendidoPorAcaoImediata.TabIndex = 1
        '
        'lblAtendidoPorAcaoImediata
        '
        Me.lblAtendidoPorAcaoImediata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAtendidoPorAcaoImediata.AutoSize = True
        Me.lblAtendidoPorAcaoImediata.Location = New System.Drawing.Point(7, 292)
        Me.lblAtendidoPorAcaoImediata.Name = "lblAtendidoPorAcaoImediata"
        Me.lblAtendidoPorAcaoImediata.Size = New System.Drawing.Size(72, 14)
        Me.lblAtendidoPorAcaoImediata.TabIndex = 27
        Me.lblAtendidoPorAcaoImediata.Text = "Atendido Por:"
        '
        'lblAcaoImediata
        '
        Me.lblAcaoImediata.AutoSize = True
        Me.lblAcaoImediata.Location = New System.Drawing.Point(6, 17)
        Me.lblAcaoImediata.Name = "lblAcaoImediata"
        Me.lblAcaoImediata.Size = New System.Drawing.Size(78, 14)
        Me.lblAcaoImediata.TabIndex = 8
        Me.lblAcaoImediata.Text = "Ação Imediata:"
        '
        'txtAcaoImediata
        '
        Me.txtAcaoImediata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAcaoImediata.Location = New System.Drawing.Point(9, 34)
        Me.txtAcaoImediata.MaxLength = 5000
        Me.txtAcaoImediata.Multiline = True
        Me.txtAcaoImediata.Name = "txtAcaoImediata"
        Me.txtAcaoImediata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcaoImediata.Size = New System.Drawing.Size(595, 255)
        Me.txtAcaoImediata.TabIndex = 0
        '
        'pagAnaliseCausa
        '
        Me.pagAnaliseCausa.Controls.Add(Me.grpAnaliseCausa)
        Me.pagAnaliseCausa.Key = "pagAnaliseCausa"
        Me.pagAnaliseCausa.Location = New System.Drawing.Point(1, 22)
        Me.pagAnaliseCausa.Name = "pagAnaliseCausa"
        Me.pagAnaliseCausa.Size = New System.Drawing.Size(627, 345)
        Me.pagAnaliseCausa.TabStop = True
        Me.pagAnaliseCausa.Text = "Análise de Causa"
        '
        'grpAnaliseCausa
        '
        Me.grpAnaliseCausa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAnaliseCausa.BackColor = System.Drawing.Color.Transparent
        Me.grpAnaliseCausa.Controls.Add(Me.cboAnalisadoPorAnaliseCausa)
        Me.grpAnaliseCausa.Controls.Add(Me.lblAnalisadoPorAnaliseCausa)
        Me.grpAnaliseCausa.Controls.Add(Me.lblAnaliseCausa)
        Me.grpAnaliseCausa.Controls.Add(Me.txtAnaliseCausa)
        Me.grpAnaliseCausa.Location = New System.Drawing.Point(9, 3)
        Me.grpAnaliseCausa.Name = "grpAnaliseCausa"
        Me.grpAnaliseCausa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAnaliseCausa.Size = New System.Drawing.Size(610, 335)
        Me.grpAnaliseCausa.TabIndex = 0
        Me.grpAnaliseCausa.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpAnaliseCausa.VisualStyleManager = Me.vsmMain
        '
        'cboAnalisadoPorAnaliseCausa
        '
        Me.cboAnalisadoPorAnaliseCausa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAnalisadoPorAnaliseCausa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAnalisadoPorAnaliseCausa.Location = New System.Drawing.Point(10, 309)
        Me.cboAnalisadoPorAnaliseCausa.Name = "cboAnalisadoPorAnaliseCausa"
        Me.cboAnalisadoPorAnaliseCausa.Size = New System.Drawing.Size(594, 20)
        Me.cboAnalisadoPorAnaliseCausa.TabIndex = 1
        '
        'lblAnalisadoPorAnaliseCausa
        '
        Me.lblAnalisadoPorAnaliseCausa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAnalisadoPorAnaliseCausa.AutoSize = True
        Me.lblAnalisadoPorAnaliseCausa.Location = New System.Drawing.Point(7, 292)
        Me.lblAnalisadoPorAnaliseCausa.Name = "lblAnalisadoPorAnaliseCausa"
        Me.lblAnalisadoPorAnaliseCausa.Size = New System.Drawing.Size(77, 14)
        Me.lblAnalisadoPorAnaliseCausa.TabIndex = 27
        Me.lblAnalisadoPorAnaliseCausa.Text = "Analisado Por:"
        '
        'lblAnaliseCausa
        '
        Me.lblAnaliseCausa.AutoSize = True
        Me.lblAnaliseCausa.Location = New System.Drawing.Point(6, 17)
        Me.lblAnaliseCausa.Name = "lblAnaliseCausa"
        Me.lblAnaliseCausa.Size = New System.Drawing.Size(80, 14)
        Me.lblAnaliseCausa.TabIndex = 8
        Me.lblAnaliseCausa.Text = "Análise Causa:"
        '
        'txtAnaliseCausa
        '
        Me.txtAnaliseCausa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnaliseCausa.Location = New System.Drawing.Point(9, 34)
        Me.txtAnaliseCausa.MaxLength = 5000
        Me.txtAnaliseCausa.Multiline = True
        Me.txtAnaliseCausa.Name = "txtAnaliseCausa"
        Me.txtAnaliseCausa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnaliseCausa.Size = New System.Drawing.Size(595, 255)
        Me.txtAnaliseCausa.TabIndex = 0
        '
        'pagAcaoCorretiva
        '
        Me.pagAcaoCorretiva.Controls.Add(Me.grpAcaoCorretiva)
        Me.pagAcaoCorretiva.Key = "pagAcaoCorretiva"
        Me.pagAcaoCorretiva.Location = New System.Drawing.Point(1, 22)
        Me.pagAcaoCorretiva.Name = "pagAcaoCorretiva"
        Me.pagAcaoCorretiva.Size = New System.Drawing.Size(627, 345)
        Me.pagAcaoCorretiva.TabStop = True
        Me.pagAcaoCorretiva.Text = "Ação Corretiva "
        '
        'grpAcaoCorretiva
        '
        Me.grpAcaoCorretiva.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAcaoCorretiva.BackColor = System.Drawing.Color.Transparent
        Me.grpAcaoCorretiva.Controls.Add(Me.dtpDataAcaoCorretiva)
        Me.grpAcaoCorretiva.Controls.Add(Me.lblDataAcaoCorretiva)
        Me.grpAcaoCorretiva.Controls.Add(Me.cboResponsavelAcaoCorretiva)
        Me.grpAcaoCorretiva.Controls.Add(Me.lblResponsavelAcaoCorretiva)
        Me.grpAcaoCorretiva.Controls.Add(Me.cboAutorizadoPorAcaoCorretiva)
        Me.grpAcaoCorretiva.Controls.Add(Me.lblAutorizadoPorAcaoCorretiva)
        Me.grpAcaoCorretiva.Controls.Add(Me.lblAcaoCorretiva)
        Me.grpAcaoCorretiva.Controls.Add(Me.txtAcaoCorretiva)
        Me.grpAcaoCorretiva.Location = New System.Drawing.Point(9, 3)
        Me.grpAcaoCorretiva.Name = "grpAcaoCorretiva"
        Me.grpAcaoCorretiva.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAcaoCorretiva.Size = New System.Drawing.Size(610, 335)
        Me.grpAcaoCorretiva.TabIndex = 0
        Me.grpAcaoCorretiva.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpAcaoCorretiva.VisualStyleManager = Me.vsmMain
        '
        'dtpDataAcaoCorretiva
        '
        Me.dtpDataAcaoCorretiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpDataAcaoCorretiva.Checked = False
        '
        '
        '
        Me.dtpDataAcaoCorretiva.DropDownCalendar.Name = ""
        Me.dtpDataAcaoCorretiva.Location = New System.Drawing.Point(271, 309)
        Me.dtpDataAcaoCorretiva.Name = "dtpDataAcaoCorretiva"
        Me.dtpDataAcaoCorretiva.ShowCheckBox = True
        Me.dtpDataAcaoCorretiva.Size = New System.Drawing.Size(97, 20)
        Me.dtpDataAcaoCorretiva.TabIndex = 2
        Me.dtpDataAcaoCorretiva.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataAcaoCorretiva
        '
        Me.lblDataAcaoCorretiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDataAcaoCorretiva.AutoSize = True
        Me.lblDataAcaoCorretiva.Location = New System.Drawing.Point(268, 292)
        Me.lblDataAcaoCorretiva.Name = "lblDataAcaoCorretiva"
        Me.lblDataAcaoCorretiva.Size = New System.Drawing.Size(32, 14)
        Me.lblDataAcaoCorretiva.TabIndex = 30
        Me.lblDataAcaoCorretiva.Text = "Data:"
        '
        'cboResponsavelAcaoCorretiva
        '
        Me.cboResponsavelAcaoCorretiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboResponsavelAcaoCorretiva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsavelAcaoCorretiva.Location = New System.Drawing.Point(9, 309)
        Me.cboResponsavelAcaoCorretiva.Name = "cboResponsavelAcaoCorretiva"
        Me.cboResponsavelAcaoCorretiva.Size = New System.Drawing.Size(256, 20)
        Me.cboResponsavelAcaoCorretiva.TabIndex = 1
        '
        'lblResponsavelAcaoCorretiva
        '
        Me.lblResponsavelAcaoCorretiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblResponsavelAcaoCorretiva.AutoSize = True
        Me.lblResponsavelAcaoCorretiva.Location = New System.Drawing.Point(6, 292)
        Me.lblResponsavelAcaoCorretiva.Name = "lblResponsavelAcaoCorretiva"
        Me.lblResponsavelAcaoCorretiva.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavelAcaoCorretiva.TabIndex = 29
        Me.lblResponsavelAcaoCorretiva.Text = "Responsável:"
        '
        'cboAutorizadoPorAcaoCorretiva
        '
        Me.cboAutorizadoPorAcaoCorretiva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAutorizadoPorAcaoCorretiva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAutorizadoPorAcaoCorretiva.Location = New System.Drawing.Point(374, 309)
        Me.cboAutorizadoPorAcaoCorretiva.Name = "cboAutorizadoPorAcaoCorretiva"
        Me.cboAutorizadoPorAcaoCorretiva.Size = New System.Drawing.Size(230, 20)
        Me.cboAutorizadoPorAcaoCorretiva.TabIndex = 3
        '
        'lblAutorizadoPorAcaoCorretiva
        '
        Me.lblAutorizadoPorAcaoCorretiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAutorizadoPorAcaoCorretiva.AutoSize = True
        Me.lblAutorizadoPorAcaoCorretiva.Location = New System.Drawing.Point(371, 292)
        Me.lblAutorizadoPorAcaoCorretiva.Name = "lblAutorizadoPorAcaoCorretiva"
        Me.lblAutorizadoPorAcaoCorretiva.Size = New System.Drawing.Size(82, 14)
        Me.lblAutorizadoPorAcaoCorretiva.TabIndex = 27
        Me.lblAutorizadoPorAcaoCorretiva.Text = "Autorizado Por:"
        '
        'lblAcaoCorretiva
        '
        Me.lblAcaoCorretiva.AutoSize = True
        Me.lblAcaoCorretiva.Location = New System.Drawing.Point(6, 17)
        Me.lblAcaoCorretiva.Name = "lblAcaoCorretiva"
        Me.lblAcaoCorretiva.Size = New System.Drawing.Size(83, 14)
        Me.lblAcaoCorretiva.TabIndex = 8
        Me.lblAcaoCorretiva.Text = "Ação Corretiva:"
        '
        'txtAcaoCorretiva
        '
        Me.txtAcaoCorretiva.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAcaoCorretiva.Location = New System.Drawing.Point(9, 34)
        Me.txtAcaoCorretiva.MaxLength = 5000
        Me.txtAcaoCorretiva.Multiline = True
        Me.txtAcaoCorretiva.Name = "txtAcaoCorretiva"
        Me.txtAcaoCorretiva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcaoCorretiva.Size = New System.Drawing.Size(595, 255)
        Me.txtAcaoCorretiva.TabIndex = 0
        '
        'pagConclusao
        '
        Me.pagConclusao.Controls.Add(Me.tabDadosConclusao)
        Me.pagConclusao.Controls.Add(Me.btnGerarSAC)
        Me.pagConclusao.Key = "pagConclusao"
        Me.pagConclusao.Location = New System.Drawing.Point(1, 22)
        Me.pagConclusao.Name = "pagConclusao"
        Me.pagConclusao.Size = New System.Drawing.Size(627, 345)
        Me.pagConclusao.TabStop = True
        Me.pagConclusao.Text = "Conclusão (Qualidade) "
        '
        'tabDadosConclusao
        '
        Me.tabDadosConclusao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDadosConclusao.BackColor = System.Drawing.Color.Transparent
        Me.tabDadosConclusao.Location = New System.Drawing.Point(9, 3)
        Me.tabDadosConclusao.Name = "tabDadosConclusao"
        Me.tabDadosConclusao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDadosConclusao.ShowFocusRectangle = False
        Me.tabDadosConclusao.Size = New System.Drawing.Size(610, 313)
        Me.tabDadosConclusao.TabIndex = 1
        Me.tabDadosConclusao.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagObservacao, Me.pagDadosRI, Me.PagArquivos})
        Me.tabDadosConclusao.VisualStyleManager = Me.vsmMain
        '
        'pagObservacao
        '
        Me.pagObservacao.Controls.Add(Me.grpObservacaoConclusao)
        Me.pagObservacao.Key = "pagObservacao"
        Me.pagObservacao.Location = New System.Drawing.Point(1, 22)
        Me.pagObservacao.Name = "pagObservacao"
        Me.pagObservacao.Size = New System.Drawing.Size(608, 290)
        Me.pagObservacao.TabStop = True
        Me.pagObservacao.Text = "Observação"
        '
        'grpObservacaoConclusao
        '
        Me.grpObservacaoConclusao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpObservacaoConclusao.BackColor = System.Drawing.Color.Transparent
        Me.grpObservacaoConclusao.Controls.Add(Me.lblObservacaoConclusao)
        Me.grpObservacaoConclusao.Controls.Add(Me.txtObservacaoConclusao)
        Me.grpObservacaoConclusao.Location = New System.Drawing.Point(9, 3)
        Me.grpObservacaoConclusao.Name = "grpObservacaoConclusao"
        Me.grpObservacaoConclusao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpObservacaoConclusao.Size = New System.Drawing.Size(591, 284)
        Me.grpObservacaoConclusao.TabIndex = 0
        Me.grpObservacaoConclusao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpObservacaoConclusao.VisualStyleManager = Me.vsmMain
        '
        'lblObservacaoConclusao
        '
        Me.lblObservacaoConclusao.AutoSize = True
        Me.lblObservacaoConclusao.Location = New System.Drawing.Point(6, 17)
        Me.lblObservacaoConclusao.Name = "lblObservacaoConclusao"
        Me.lblObservacaoConclusao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacaoConclusao.TabIndex = 10
        Me.lblObservacaoConclusao.Text = "Observação:"
        '
        'txtObservacaoConclusao
        '
        Me.txtObservacaoConclusao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoConclusao.Location = New System.Drawing.Point(9, 34)
        Me.txtObservacaoConclusao.MaxLength = 5000
        Me.txtObservacaoConclusao.Multiline = True
        Me.txtObservacaoConclusao.Name = "txtObservacaoConclusao"
        Me.txtObservacaoConclusao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacaoConclusao.Size = New System.Drawing.Size(573, 244)
        Me.txtObservacaoConclusao.TabIndex = 0
        '
        'pagDadosRI
        '
        Me.pagDadosRI.Controls.Add(Me.grpCaracteristicas)
        Me.pagDadosRI.Key = "pagDadosRI"
        Me.pagDadosRI.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosRI.Name = "pagDadosRI"
        Me.pagDadosRI.Size = New System.Drawing.Size(608, 290)
        Me.pagDadosRI.TabStop = True
        Me.pagDadosRI.Text = "Dados Relatório de Inspeção"
        '
        'grpCaracteristicas
        '
        Me.grpCaracteristicas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCaracteristicas.BackColor = System.Drawing.Color.Transparent
        Me.grpCaracteristicas.Controls.Add(Me.lblToleranciaMax)
        Me.grpCaracteristicas.Controls.Add(Me.txtToleranciaMax)
        Me.grpCaracteristicas.Controls.Add(Me.txtValorEncontrado)
        Me.grpCaracteristicas.Controls.Add(Me.txtValorNominal)
        Me.grpCaracteristicas.Controls.Add(Me.lblSequenciaCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.txtSequenciaCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.txtValorMaximo)
        Me.grpCaracteristicas.Controls.Add(Me.txtValorMinimo)
        Me.grpCaracteristicas.Controls.Add(Me.lblNumeroRI)
        Me.grpCaracteristicas.Controls.Add(Me.txtNumeroRI)
        Me.grpCaracteristicas.Controls.Add(Me.txtEquipamento)
        Me.grpCaracteristicas.Controls.Add(Me.txtClasseTolerancia)
        Me.grpCaracteristicas.Controls.Add(Me.txtCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.lblEquipamento)
        Me.grpCaracteristicas.Controls.Add(Me.lblObservacaoCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.txtObservacaoCaracteristica)
        Me.grpCaracteristicas.Controls.Add(Me.lblValorEncontrado)
        Me.grpCaracteristicas.Controls.Add(Me.lblToleranciaMin)
        Me.grpCaracteristicas.Controls.Add(Me.txtToleranciaMin)
        Me.grpCaracteristicas.Controls.Add(Me.lblValorMaximo)
        Me.grpCaracteristicas.Controls.Add(Me.lblValorMinimo)
        Me.grpCaracteristicas.Controls.Add(Me.lblValorNominal)
        Me.grpCaracteristicas.Controls.Add(Me.lblClasseTolerancia)
        Me.grpCaracteristicas.Controls.Add(Me.lblCaracteristica)
        Me.grpCaracteristicas.Location = New System.Drawing.Point(9, 3)
        Me.grpCaracteristicas.Name = "grpCaracteristicas"
        Me.grpCaracteristicas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCaracteristicas.Size = New System.Drawing.Size(591, 284)
        Me.grpCaracteristicas.TabIndex = 0
        Me.grpCaracteristicas.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpCaracteristicas.VisualStyleManager = Me.vsmMain
        '
        'lblToleranciaMax
        '
        Me.lblToleranciaMax.AutoSize = True
        Me.lblToleranciaMax.Location = New System.Drawing.Point(198, 97)
        Me.lblToleranciaMax.Name = "lblToleranciaMax"
        Me.lblToleranciaMax.Size = New System.Drawing.Size(85, 14)
        Me.lblToleranciaMax.TabIndex = 31
        Me.lblToleranciaMax.Text = "Tolerância Max.:"
        '
        'txtToleranciaMax
        '
        Me.txtToleranciaMax.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtToleranciaMax.IncludeLiterals = False
        Me.txtToleranciaMax.Location = New System.Drawing.Point(201, 114)
        Me.txtToleranciaMax.MaxLength = 20
        Me.txtToleranciaMax.Name = "txtToleranciaMax"
        Me.txtToleranciaMax.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtToleranciaMax.ReadOnly = True
        Me.txtToleranciaMax.Size = New System.Drawing.Size(82, 20)
        Me.txtToleranciaMax.TabIndex = 32
        Me.txtToleranciaMax.TabStop = False
        '
        'txtValorEncontrado
        '
        Me.txtValorEncontrado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorEncontrado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorEncontrado.IncludeLiterals = False
        Me.txtValorEncontrado.Location = New System.Drawing.Point(497, 114)
        Me.txtValorEncontrado.MaxLength = 20
        Me.txtValorEncontrado.Name = "txtValorEncontrado"
        Me.txtValorEncontrado.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtValorEncontrado.ReadOnly = True
        Me.txtValorEncontrado.Size = New System.Drawing.Size(87, 20)
        Me.txtValorEncontrado.TabIndex = 30
        Me.txtValorEncontrado.TabStop = False
        '
        'txtValorNominal
        '
        Me.txtValorNominal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorNominal.IncludeLiterals = False
        Me.txtValorNominal.Location = New System.Drawing.Point(9, 114)
        Me.txtValorNominal.MaxLength = 20
        Me.txtValorNominal.Name = "txtValorNominal"
        Me.txtValorNominal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtValorNominal.ReadOnly = True
        Me.txtValorNominal.Size = New System.Drawing.Size(104, 20)
        Me.txtValorNominal.TabIndex = 29
        Me.txtValorNominal.TabStop = False
        '
        'lblSequenciaCaracteristica
        '
        Me.lblSequenciaCaracteristica.AutoSize = True
        Me.lblSequenciaCaracteristica.Location = New System.Drawing.Point(116, 17)
        Me.lblSequenciaCaracteristica.Name = "lblSequenciaCaracteristica"
        Me.lblSequenciaCaracteristica.Size = New System.Drawing.Size(29, 14)
        Me.lblSequenciaCaracteristica.TabIndex = 28
        Me.lblSequenciaCaracteristica.Text = "Seq."
        '
        'txtSequenciaCaracteristica
        '
        Me.txtSequenciaCaracteristica.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSequenciaCaracteristica.IncludeLiterals = False
        Me.txtSequenciaCaracteristica.Location = New System.Drawing.Point(119, 34)
        Me.txtSequenciaCaracteristica.MaxLength = 20
        Me.txtSequenciaCaracteristica.Name = "txtSequenciaCaracteristica"
        Me.txtSequenciaCaracteristica.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSequenciaCaracteristica.ReadOnly = True
        Me.txtSequenciaCaracteristica.Size = New System.Drawing.Size(76, 20)
        Me.txtSequenciaCaracteristica.TabIndex = 27
        Me.txtSequenciaCaracteristica.TabStop = False
        '
        'txtValorMaximo
        '
        Me.txtValorMaximo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorMaximo.DecimalDigits = 4
        Me.txtValorMaximo.Location = New System.Drawing.Point(387, 114)
        Me.txtValorMaximo.Name = "txtValorMaximo"
        Me.txtValorMaximo.ReadOnly = True
        Me.txtValorMaximo.Size = New System.Drawing.Size(104, 20)
        Me.txtValorMaximo.TabIndex = 25
        Me.txtValorMaximo.Text = "0,0000"
        Me.txtValorMaximo.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtValorMinimo
        '
        Me.txtValorMinimo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorMinimo.DecimalDigits = 4
        Me.txtValorMinimo.Location = New System.Drawing.Point(289, 114)
        Me.txtValorMinimo.Name = "txtValorMinimo"
        Me.txtValorMinimo.ReadOnly = True
        Me.txtValorMinimo.Size = New System.Drawing.Size(92, 20)
        Me.txtValorMinimo.TabIndex = 24
        Me.txtValorMinimo.Text = "0,0000"
        Me.txtValorMinimo.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblNumeroRI
        '
        Me.lblNumeroRI.AutoSize = True
        Me.lblNumeroRI.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRI.Name = "lblNumeroRI"
        Me.lblNumeroRI.Size = New System.Drawing.Size(27, 14)
        Me.lblNumeroRI.TabIndex = 22
        Me.lblNumeroRI.Text = "N°RI"
        '
        'txtNumeroRI
        '
        Me.txtNumeroRI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRI.IncludeLiterals = False
        Me.txtNumeroRI.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRI.MaxLength = 20
        Me.txtNumeroRI.Name = "txtNumeroRI"
        Me.txtNumeroRI.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroRI.ReadOnly = True
        Me.txtNumeroRI.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroRI.TabIndex = 21
        Me.txtNumeroRI.TabStop = False
        '
        'txtEquipamento
        '
        Me.txtEquipamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEquipamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEquipamento.IncludeLiterals = False
        Me.txtEquipamento.Location = New System.Drawing.Point(9, 74)
        Me.txtEquipamento.MaxLength = 20
        Me.txtEquipamento.Name = "txtEquipamento"
        Me.txtEquipamento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtEquipamento.ReadOnly = True
        Me.txtEquipamento.Size = New System.Drawing.Size(575, 20)
        Me.txtEquipamento.TabIndex = 20
        Me.txtEquipamento.TabStop = False
        '
        'txtClasseTolerancia
        '
        Me.txtClasseTolerancia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClasseTolerancia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtClasseTolerancia.IncludeLiterals = False
        Me.txtClasseTolerancia.Location = New System.Drawing.Point(387, 34)
        Me.txtClasseTolerancia.MaxLength = 20
        Me.txtClasseTolerancia.Name = "txtClasseTolerancia"
        Me.txtClasseTolerancia.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtClasseTolerancia.ReadOnly = True
        Me.txtClasseTolerancia.Size = New System.Drawing.Size(197, 20)
        Me.txtClasseTolerancia.TabIndex = 19
        Me.txtClasseTolerancia.TabStop = False
        '
        'txtCaracteristica
        '
        Me.txtCaracteristica.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCaracteristica.IncludeLiterals = False
        Me.txtCaracteristica.Location = New System.Drawing.Point(201, 34)
        Me.txtCaracteristica.MaxLength = 20
        Me.txtCaracteristica.Name = "txtCaracteristica"
        Me.txtCaracteristica.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCaracteristica.ReadOnly = True
        Me.txtCaracteristica.Size = New System.Drawing.Size(180, 20)
        Me.txtCaracteristica.TabIndex = 18
        Me.txtCaracteristica.TabStop = False
        '
        'lblEquipamento
        '
        Me.lblEquipamento.AutoSize = True
        Me.lblEquipamento.Location = New System.Drawing.Point(6, 57)
        Me.lblEquipamento.Name = "lblEquipamento"
        Me.lblEquipamento.Size = New System.Drawing.Size(71, 14)
        Me.lblEquipamento.TabIndex = 5
        Me.lblEquipamento.Text = "Equipamento:"
        '
        'lblObservacaoCaracteristica
        '
        Me.lblObservacaoCaracteristica.AutoSize = True
        Me.lblObservacaoCaracteristica.Location = New System.Drawing.Point(6, 137)
        Me.lblObservacaoCaracteristica.Name = "lblObservacaoCaracteristica"
        Me.lblObservacaoCaracteristica.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacaoCaracteristica.TabIndex = 16
        Me.lblObservacaoCaracteristica.Text = "Observação:"
        '
        'txtObservacaoCaracteristica
        '
        Me.txtObservacaoCaracteristica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoCaracteristica.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtObservacaoCaracteristica.IncludeLiterals = False
        Me.txtObservacaoCaracteristica.Location = New System.Drawing.Point(9, 154)
        Me.txtObservacaoCaracteristica.MaxLength = 20
        Me.txtObservacaoCaracteristica.Name = "txtObservacaoCaracteristica"
        Me.txtObservacaoCaracteristica.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtObservacaoCaracteristica.ReadOnly = True
        Me.txtObservacaoCaracteristica.Size = New System.Drawing.Size(575, 20)
        Me.txtObservacaoCaracteristica.TabIndex = 17
        Me.txtObservacaoCaracteristica.TabStop = False
        '
        'lblValorEncontrado
        '
        Me.lblValorEncontrado.AutoSize = True
        Me.lblValorEncontrado.Location = New System.Drawing.Point(494, 97)
        Me.lblValorEncontrado.Name = "lblValorEncontrado"
        Me.lblValorEncontrado.Size = New System.Drawing.Size(93, 14)
        Me.lblValorEncontrado.TabIndex = 14
        Me.lblValorEncontrado.Text = "Valor Encontrado:"
        '
        'lblToleranciaMin
        '
        Me.lblToleranciaMin.AutoSize = True
        Me.lblToleranciaMin.Location = New System.Drawing.Point(116, 97)
        Me.lblToleranciaMin.Name = "lblToleranciaMin"
        Me.lblToleranciaMin.Size = New System.Drawing.Size(81, 14)
        Me.lblToleranciaMin.TabIndex = 8
        Me.lblToleranciaMin.Text = "Tolerância Min.:"
        '
        'txtToleranciaMin
        '
        Me.txtToleranciaMin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtToleranciaMin.IncludeLiterals = False
        Me.txtToleranciaMin.Location = New System.Drawing.Point(119, 114)
        Me.txtToleranciaMin.MaxLength = 20
        Me.txtToleranciaMin.Name = "txtToleranciaMin"
        Me.txtToleranciaMin.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtToleranciaMin.ReadOnly = True
        Me.txtToleranciaMin.Size = New System.Drawing.Size(76, 20)
        Me.txtToleranciaMin.TabIndex = 9
        Me.txtToleranciaMin.TabStop = False
        '
        'lblValorMaximo
        '
        Me.lblValorMaximo.AutoSize = True
        Me.lblValorMaximo.Location = New System.Drawing.Point(384, 97)
        Me.lblValorMaximo.Name = "lblValorMaximo"
        Me.lblValorMaximo.Size = New System.Drawing.Size(74, 14)
        Me.lblValorMaximo.TabIndex = 12
        Me.lblValorMaximo.Text = "Valor Máximo:"
        '
        'lblValorMinimo
        '
        Me.lblValorMinimo.AutoSize = True
        Me.lblValorMinimo.Location = New System.Drawing.Point(289, 97)
        Me.lblValorMinimo.Name = "lblValorMinimo"
        Me.lblValorMinimo.Size = New System.Drawing.Size(70, 14)
        Me.lblValorMinimo.TabIndex = 10
        Me.lblValorMinimo.Text = "Valor Mínimo:"
        '
        'lblValorNominal
        '
        Me.lblValorNominal.AutoSize = True
        Me.lblValorNominal.Location = New System.Drawing.Point(6, 97)
        Me.lblValorNominal.Name = "lblValorNominal"
        Me.lblValorNominal.Size = New System.Drawing.Size(75, 14)
        Me.lblValorNominal.TabIndex = 6
        Me.lblValorNominal.Text = "Valor Nominal:"
        '
        'lblClasseTolerancia
        '
        Me.lblClasseTolerancia.AutoSize = True
        Me.lblClasseTolerancia.Location = New System.Drawing.Point(384, 17)
        Me.lblClasseTolerancia.Name = "lblClasseTolerancia"
        Me.lblClasseTolerancia.Size = New System.Drawing.Size(110, 14)
        Me.lblClasseTolerancia.TabIndex = 2
        Me.lblClasseTolerancia.Text = "Classe de Tolerância:"
        '
        'lblCaracteristica
        '
        Me.lblCaracteristica.AutoSize = True
        Me.lblCaracteristica.Location = New System.Drawing.Point(198, 17)
        Me.lblCaracteristica.Name = "lblCaracteristica"
        Me.lblCaracteristica.Size = New System.Drawing.Size(77, 14)
        Me.lblCaracteristica.TabIndex = 0
        Me.lblCaracteristica.Text = "Característica:"
        '
        'PagArquivos
        '
        Me.PagArquivos.Controls.Add(Me.grpArquivo)
        Me.PagArquivos.Controls.Add(Me.grdArquivo)
        Me.PagArquivos.Key = "pagArquivos"
        Me.PagArquivos.Location = New System.Drawing.Point(1, 22)
        Me.PagArquivos.Name = "PagArquivos"
        Me.PagArquivos.Size = New System.Drawing.Size(608, 290)
        Me.PagArquivos.TabStop = True
        Me.PagArquivos.Text = "Arquivos"
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.btnProcurarArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.txtDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(9, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(591, 104)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarArquivo
        '
        Me.btnProcurarArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProcurarArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnProcurarArquivo.Location = New System.Drawing.Point(453, 74)
        Me.btnProcurarArquivo.Name = "btnProcurarArquivo"
        Me.btnProcurarArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProcurarArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnProcurarArquivo.TabIndex = 2
        Me.btnProcurarArquivo.Text = "..."
        Me.btnProcurarArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(6, 57)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 14
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(9, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(445, 20)
        Me.txtArquivo.TabIndex = 1
        Me.txtArquivo.TabStop = False
        '
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(464, 20)
        Me.txtDescricaoArquivo.TabIndex = 0
        '
        'lblDescricaoArquivo
        '
        Me.lblDescricaoArquivo.AutoSize = True
        Me.lblDescricaoArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoArquivo.Name = "lblDescricaoArquivo"
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoArquivo.TabIndex = 12
        Me.lblDescricaoArquivo.Text = "Descrição:"
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(491, 71)
        Me.btnExcluirArquivo.Name = "btnExcluirArquivo"
        Me.btnExcluirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivo.TabIndex = 4
        Me.btnExcluirArquivo.Text = "Excluir"
        Me.btnExcluirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirArquivo
        '
        Me.btnInserirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirArquivo.Location = New System.Drawing.Point(491, 42)
        Me.btnInserirArquivo.Name = "btnInserirArquivo"
        Me.btnInserirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirArquivo.TabIndex = 3
        Me.btnInserirArquivo.Text = "Inserir"
        Me.btnInserirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.grdArquivo.Location = New System.Drawing.Point(9, 110)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(591, 177)
        Me.grdArquivo.TabIndex = 1
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'btnGerarSAC
        '
        Me.btnGerarSAC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGerarSAC.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnGerarSAC.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarSAC.Location = New System.Drawing.Point(9, 319)
        Me.btnGerarSAC.Name = "btnGerarSAC"
        Me.btnGerarSAC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarSAC.Size = New System.Drawing.Size(114, 23)
        Me.btnGerarSAC.TabIndex = 0
        Me.btnGerarSAC.Text = "Gerar SAC"
        Me.btnGerarSAC.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagHistorico
        '
        Me.pagHistorico.Controls.Add(Me.grpControl2)
        Me.pagHistorico.Key = "pagHistorico"
        Me.pagHistorico.Location = New System.Drawing.Point(1, 22)
        Me.pagHistorico.Name = "pagHistorico"
        Me.pagHistorico.Size = New System.Drawing.Size(627, 345)
        Me.pagHistorico.TabStop = True
        Me.pagHistorico.Text = "Histórico"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.grdHistorico)
        Me.grpControl2.Controls.Add(Me.btnInserirHistorico)
        Me.grpControl2.Location = New System.Drawing.Point(9, 3)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(610, 339)
        Me.grpControl2.TabIndex = 9
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'grdHistorico
        '
        Me.grdHistorico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdHistorico.AlternatingColors = True
        Me.grdHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdHistorico.ColumnAutoResize = True
        grdHistorico_DesignTimeLayout.LayoutString = resources.GetString("grdHistorico_DesignTimeLayout.LayoutString")
        Me.grdHistorico.DesignTimeLayout = grdHistorico_DesignTimeLayout
        Me.grdHistorico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdHistorico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdHistorico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdHistorico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdHistorico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdHistorico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdHistorico.GroupByBoxVisible = False
        Me.grdHistorico.Location = New System.Drawing.Point(9, 46)
        Me.grdHistorico.Name = "grdHistorico"
        Me.grdHistorico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdHistorico.RecordNavigator = True
        Me.grdHistorico.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdHistorico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdHistorico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdHistorico.Size = New System.Drawing.Size(592, 284)
        Me.grdHistorico.TabIndex = 11
        Me.grdHistorico.TabStop = False
        Me.grdHistorico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdHistorico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdHistorico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdHistorico.VisualStyleManager = Me.vsmMain
        '
        'btnInserirHistorico
        '
        Me.btnInserirHistorico.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnInserirHistorico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirHistorico.Location = New System.Drawing.Point(9, 17)
        Me.btnInserirHistorico.Name = "btnInserirHistorico"
        Me.btnInserirHistorico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirHistorico.Size = New System.Drawing.Size(113, 23)
        Me.btnInserirHistorico.TabIndex = 1
        Me.btnInserirHistorico.Text = "Inserir Histórico"
        Me.btnInserirHistorico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrQARNC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrQARNC"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpCombosRNC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCombosRNC.ResumeLayout(False)
        Me.grpCombosRNC.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDescricaoRNC.ResumeLayout(False)
        CType(Me.grpDescricaoRNC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDescricaoRNC.ResumeLayout(False)
        Me.grpDescricaoRNC.PerformLayout()
        Me.pagAcaoImediata.ResumeLayout(False)
        CType(Me.grpAcaoImediata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAcaoImediata.ResumeLayout(False)
        Me.grpAcaoImediata.PerformLayout()
        Me.pagAnaliseCausa.ResumeLayout(False)
        CType(Me.grpAnaliseCausa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAnaliseCausa.ResumeLayout(False)
        Me.grpAnaliseCausa.PerformLayout()
        Me.pagAcaoCorretiva.ResumeLayout(False)
        CType(Me.grpAcaoCorretiva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAcaoCorretiva.ResumeLayout(False)
        Me.grpAcaoCorretiva.PerformLayout()
        Me.pagConclusao.ResumeLayout(False)
        CType(Me.tabDadosConclusao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDadosConclusao.ResumeLayout(False)
        Me.pagObservacao.ResumeLayout(False)
        CType(Me.grpObservacaoConclusao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpObservacaoConclusao.ResumeLayout(False)
        Me.grpObservacaoConclusao.PerformLayout()
        Me.pagDadosRI.ResumeLayout(False)
        CType(Me.grpCaracteristicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCaracteristicas.ResumeLayout(False)
        Me.grpCaracteristicas.PerformLayout()
        Me.PagArquivos.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagHistorico.ResumeLayout(False)
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grdHistorico, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroRNCFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents txtNumeroRNC As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnNovoRNC As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNumeroRNC As Label
    Friend WithEvents lblData As Label
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblResponsavel As Label
    Friend WithEvents lblFonte As Label
    Friend WithEvents cboFonte As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As Label
    Friend WithEvents lblQtdNC As Label
    Friend WithEvents txtQtdNC As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblItemNC As Label
    Friend WithEvents pagDescricaoRNC As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblDisposicao As Label
    Friend WithEvents cboDisposicao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroRNCFiltro As Label
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As Label
    Friend WithEvents cboResponsavel As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpDescricaoRNC As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDescricaoNC As Label
    Friend WithEvents txtDescricaoNC As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtAnalise As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblAnalise As Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcluirRNC As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtItemNC As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblQtdOP As Label
    Friend WithEvents txtQtdOP As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDisposicaoFiltro As Label
    Friend WithEvents lblItemFiltro As Label
    Friend WithEvents lblOrdemProducaoFiltro As Label
    Friend WithEvents txtOrdemProducaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboDisposicaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagHistorico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdHistorico As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnInserirHistorico As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnGerarSAC As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovoRNCDados As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnUltimoRegistro As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnRegistroAnterior As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProximoRegistro As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblStatusFiltro As Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagAcaoImediata As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagAnaliseCausa As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagAcaoCorretiva As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagConclusao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabDadosConclusao As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDadosRI As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpCaracteristicas As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblToleranciaMax As Label
    Friend WithEvents txtToleranciaMax As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtValorEncontrado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtValorNominal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSequenciaCaracteristica As Label
    Friend WithEvents txtSequenciaCaracteristica As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtValorMaximo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorMinimo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroRI As Label
    Friend WithEvents txtNumeroRI As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtEquipamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtClasseTolerancia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCaracteristica As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEquipamento As Label
    Friend WithEvents lblObservacaoCaracteristica As Label
    Friend WithEvents txtObservacaoCaracteristica As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblValorEncontrado As Label
    Friend WithEvents lblToleranciaMin As Label
    Friend WithEvents txtToleranciaMin As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblValorMaximo As Label
    Friend WithEvents lblValorMinimo As Label
    Friend WithEvents lblValorNominal As Label
    Friend WithEvents lblClasseTolerancia As Label
    Friend WithEvents lblCaracteristica As Label
    Friend WithEvents PagArquivos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As Label
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagObservacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpObservacaoConclusao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblObservacaoConclusao As Label
    Friend WithEvents txtObservacaoConclusao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblImpacto As Label
    Friend WithEvents cboImpacto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpCombosRNC As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAbertoPor As Label
    Friend WithEvents cboAbertoPor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaquina As Label
    Friend WithEvents cboMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOperacao As Label
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoNC As Label
    Friend WithEvents cboGrupoNC As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCausaNC As Label
    Friend WithEvents cboCausaRNC As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNaoConformidadeDetectada As Label
    Friend WithEvents cboNaoConformidadeDetectada As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOperacaoOrigemNC As Label
    Friend WithEvents cboOperacaoOrigemNC As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpAcaoImediata As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboAtendidoPorAcaoImediata As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAtendidoPorAcaoImediata As Label
    Friend WithEvents lblAcaoImediata As Label
    Friend WithEvents txtAcaoImediata As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grpAnaliseCausa As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboAnalisadoPorAnaliseCausa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAnalisadoPorAnaliseCausa As Label
    Friend WithEvents lblAnaliseCausa As Label
    Friend WithEvents txtAnaliseCausa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grpAcaoCorretiva As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboResponsavelAcaoCorretiva As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblResponsavelAcaoCorretiva As Label
    Friend WithEvents cboAutorizadoPorAcaoCorretiva As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAutorizadoPorAcaoCorretiva As Label
    Friend WithEvents lblAcaoCorretiva As Label
    Friend WithEvents txtAcaoCorretiva As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents dtpDataAcaoCorretiva As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataAcaoCorretiva As Label
    Friend WithEvents btnProsseguirProducao As Janus.Windows.EditControls.UIButton
End Class
