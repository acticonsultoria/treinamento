<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrQASAC
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdReacoes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdReacoes_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdAcoesCorretivas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdAcoesCorretivas_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdRiscosOportunidades_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRiscosOportunidades_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrQASAC))
        Dim grdHistorico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.lblOrdemProducaoFiltro = New System.Windows.Forms.Label()
        Me.txtOrdemProducaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroSACFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblNumeroSACFiltro = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirSAC = New Janus.Windows.EditControls.UIButton()
        Me.btnNovoSAC = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroRNC = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRNC = New System.Windows.Forms.Label()
        Me.lblSituacao = New System.Windows.Forms.Label()
        Me.cboSituacao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtOrigem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblQtdNC = New System.Windows.Forms.Label()
        Me.txtQtdNC = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboEmissor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoNC = New System.Windows.Forms.Label()
        Me.cboTipoNC = New Janus.Windows.EditControls.UIComboBox()
        Me.lblItemNC = New System.Windows.Forms.Label()
        Me.lblQtdSAC = New System.Windows.Forms.Label()
        Me.txtQtdSAC = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.lblOrigem = New System.Windows.Forms.Label()
        Me.lblEmissor = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroSAC = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroSAC = New System.Windows.Forms.Label()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnUltimoRegistro = New Janus.Windows.EditControls.UIButton()
        Me.btnRegistroAnterior = New Janus.Windows.EditControls.UIButton()
        Me.btnProximoRegistro = New Janus.Windows.EditControls.UIButton()
        Me.btnNovoSACDados = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDescricaoSAC = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDescricaoSAC = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDataDescricao = New System.Windows.Forms.Label()
        Me.dtpDataDescricao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboResponsavelDescricao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblResponsavelDescricao = New System.Windows.Forms.Label()
        Me.lblEvidenciaDescricao = New System.Windows.Forms.Label()
        Me.lblDesvioDescricao = New System.Windows.Forms.Label()
        Me.lblRequisitoDescricao = New System.Windows.Forms.Label()
        Me.txtRequisitoDescricao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtDesvioDescricao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtEvidenciaDescricao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagArquivos = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.pagReacaoNC = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpReacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblSituacaoReacao = New System.Windows.Forms.Label()
        Me.cboSituacaoReacoes = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPrazoReacoes = New System.Windows.Forms.Label()
        Me.dtpPrazoReacoes = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboResponsavelReacoes = New Janus.Windows.EditControls.UIComboBox()
        Me.lblResponsavelReacoes = New System.Windows.Forms.Label()
        Me.txtAcaoContencaoReacoes = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAcaoCorrecaoReacoes = New System.Windows.Forms.Label()
        Me.btnExcluirReacoes = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirReacoes = New Janus.Windows.EditControls.UIButton()
        Me.grdReacoes = New Janus.Windows.GridEX.GridEX()
        Me.pagDadosRI = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpExtensao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDataExtensao = New System.Windows.Forms.Label()
        Me.dtpDataExtensao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboResponsavelExtencao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblResponsavelExtencao = New System.Windows.Forms.Label()
        Me.lblExtencaoNC = New System.Windows.Forms.Label()
        Me.txtExtencaoNC = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagAnaliseCausas = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpAnaliseCausa = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDataAnaliseCausa = New System.Windows.Forms.Label()
        Me.dtpDataAnaliseCausa = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboResponsavelAnaliseCausa = New Janus.Windows.EditControls.UIComboBox()
        Me.lblResponsavelAnaliseCausa = New System.Windows.Forms.Label()
        Me.lblAnaliseCausa = New System.Windows.Forms.Label()
        Me.txtAnaliseCausa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagAcoesCorretivas = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdAcoesCorretivas = New Janus.Windows.GridEX.GridEX()
        Me.grpAcaoCorretiva = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtResponsaveis = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSituacaoAcoesCorretivas = New System.Windows.Forms.Label()
        Me.cboSituacaoAcoesCorretivas = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPrazoAcoesCorretivas = New System.Windows.Forms.Label()
        Me.dtpPrazoAcoesCorretivas = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblResponsavelAcoesCorretivas = New System.Windows.Forms.Label()
        Me.txtAcoesCorretivas = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAcoesCorretivas = New System.Windows.Forms.Label()
        Me.btnExcluirAcoesCorretivas = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirAcoesCorretivas = New Janus.Windows.EditControls.UIButton()
        Me.pagResultados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpResultados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDataResultados = New System.Windows.Forms.Label()
        Me.dtpDataResultados = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboResponsavelResultados = New Janus.Windows.EditControls.UIComboBox()
        Me.lblResponsavelResultados = New System.Windows.Forms.Label()
        Me.lblResultados = New System.Windows.Forms.Label()
        Me.txtResultados = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagAnaliseCritica = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpAnaliseCritica = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblSatisfatoriaAnaliseCritica = New System.Windows.Forms.Label()
        Me.cboSatisfatoriaAnaliseCritica = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataAnaliseCritica = New System.Windows.Forms.Label()
        Me.dtpDataAnaliseCritica = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboResponsavelAnaliseCritica = New Janus.Windows.EditControls.UIComboBox()
        Me.lblResponsavelAnaliseCritica = New System.Windows.Forms.Label()
        Me.lblAnaliseCritica = New System.Windows.Forms.Label()
        Me.txtAnaliseCritica = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagRiscosOportunidades = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdRiscosOportunidades = New Janus.Windows.GridEX.GridEX()
        Me.grpRiscos = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboResponsavelRiscosOportunidades = New Janus.Windows.EditControls.UIComboBox()
        Me.lblResponsavelRiscosOportunidades = New System.Windows.Forms.Label()
        Me.lblDataRiscosOportunidades = New System.Windows.Forms.Label()
        Me.dtpDataRiscosOportunidades = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtRiscosOportunidades = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRiscosOportunidades = New System.Windows.Forms.Label()
        Me.btnExcluirRiscosOportunidades = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirRiscosOportunidades = New Janus.Windows.EditControls.UIButton()
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
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDescricaoSAC.SuspendLayout()
        CType(Me.grpDescricaoSAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDescricaoSAC.SuspendLayout()
        Me.pagArquivos.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagReacaoNC.SuspendLayout()
        CType(Me.grpReacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReacao.SuspendLayout()
        CType(Me.grdReacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDadosRI.SuspendLayout()
        CType(Me.grpExtensao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExtensao.SuspendLayout()
        Me.pagAnaliseCausas.SuspendLayout()
        CType(Me.grpAnaliseCausa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAnaliseCausa.SuspendLayout()
        Me.pagAcoesCorretivas.SuspendLayout()
        CType(Me.grdAcoesCorretivas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpAcaoCorretiva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAcaoCorretiva.SuspendLayout()
        Me.pagResultados.SuspendLayout()
        CType(Me.grpResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResultados.SuspendLayout()
        Me.pagAnaliseCritica.SuspendLayout()
        CType(Me.grpAnaliseCritica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAnaliseCritica.SuspendLayout()
        Me.pagRiscosOportunidades.SuspendLayout()
        CType(Me.grdRiscosOportunidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRiscos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRiscos.SuspendLayout()
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
        Me.pagListagem.Text = "Qualidade - SAC"
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
        Me.grpFiltro.Controls.Add(Me.txtNumeroSACFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblNumeroSACFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 65)
        Me.grpFiltro.TabIndex = 2
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtItemFiltro
        '
        Me.txtItemFiltro.IncludeLiterals = False
        Me.txtItemFiltro.Location = New System.Drawing.Point(395, 34)
        Me.txtItemFiltro.MaxLength = 20
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtItemFiltro.Size = New System.Drawing.Size(230, 20)
        Me.txtItemFiltro.TabIndex = 31
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
        Me.txtOrdemProducaoFiltro.TabIndex = 27
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
        Me.dtpDataInicioFiltro.TabIndex = 23
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
        Me.dtpDataTerminoFiltro.TabIndex = 24
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
        'txtNumeroSACFiltro
        '
        Me.txtNumeroSACFiltro.IncludeLiterals = False
        Me.txtNumeroSACFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroSACFiltro.MaxLength = 20
        Me.txtNumeroSACFiltro.Name = "txtNumeroSACFiltro"
        Me.txtNumeroSACFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroSACFiltro.Size = New System.Drawing.Size(80, 20)
        Me.txtNumeroSACFiltro.TabIndex = 0
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(800, 33)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblNumeroSACFiltro
        '
        Me.lblNumeroSACFiltro.AutoSize = True
        Me.lblNumeroSACFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroSACFiltro.Name = "lblNumeroSACFiltro"
        Me.lblNumeroSACFiltro.Size = New System.Drawing.Size(46, 14)
        Me.lblNumeroSACFiltro.TabIndex = 0
        Me.lblNumeroSACFiltro.Text = "N° SAC:"
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcluirSAC)
        Me.grpControle.Controls.Add(Me.btnNovoSAC)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 1
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirSAC
        '
        Me.btnExcluirSAC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirSAC.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirSAC.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirSAC.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirSAC.Location = New System.Drawing.Point(580, 18)
        Me.btnExcluirSAC.Name = "btnExcluirSAC"
        Me.btnExcluirSAC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirSAC.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirSAC.TabIndex = 12
        Me.btnExcluirSAC.Text = "Excluir"
        Me.btnExcluirSAC.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovoSAC
        '
        Me.btnNovoSAC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoSAC.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovoSAC.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovoSAC.Location = New System.Drawing.Point(677, 18)
        Me.btnNovoSAC.Name = "btnNovoSAC"
        Me.btnNovoSAC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovoSAC.Size = New System.Drawing.Size(114, 23)
        Me.btnNovoSAC.TabIndex = 1
        Me.btnNovoSAC.Text = "Novo SAC"
        Me.btnNovoSAC.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 74)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 405)
        Me.grdListagem.TabIndex = 13
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Qualidade - SAC"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtNumeroRNC)
        Me.grpDados.Controls.Add(Me.lblNumeroRNC)
        Me.grpDados.Controls.Add(Me.lblSituacao)
        Me.grpDados.Controls.Add(Me.cboSituacao)
        Me.grpDados.Controls.Add(Me.txtOrigem)
        Me.grpDados.Controls.Add(Me.lblQtdNC)
        Me.grpDados.Controls.Add(Me.txtQtdNC)
        Me.grpDados.Controls.Add(Me.txtItem)
        Me.grpDados.Controls.Add(Me.cboEmissor)
        Me.grpDados.Controls.Add(Me.lblTipoNC)
        Me.grpDados.Controls.Add(Me.cboTipoNC)
        Me.grpDados.Controls.Add(Me.lblItemNC)
        Me.grpDados.Controls.Add(Me.lblQtdSAC)
        Me.grpDados.Controls.Add(Me.txtQtdSAC)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrigem)
        Me.grpDados.Controls.Add(Me.lblEmissor)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.dtpData)
        Me.grpDados.Controls.Add(Me.txtNumeroSAC)
        Me.grpDados.Controls.Add(Me.lblNumeroSAC)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(9, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(896, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroRNC
        '
        Me.txtNumeroRNC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRNC.IncludeLiterals = False
        Me.txtNumeroRNC.Location = New System.Drawing.Point(170, 34)
        Me.txtNumeroRNC.MaxLength = 20
        Me.txtNumeroRNC.Name = "txtNumeroRNC"
        Me.txtNumeroRNC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroRNC.ReadOnly = True
        Me.txtNumeroRNC.Size = New System.Drawing.Size(88, 20)
        Me.txtNumeroRNC.TabIndex = 46
        Me.txtNumeroRNC.TabStop = False
        '
        'lblNumeroRNC
        '
        Me.lblNumeroRNC.AutoSize = True
        Me.lblNumeroRNC.Location = New System.Drawing.Point(167, 17)
        Me.lblNumeroRNC.Name = "lblNumeroRNC"
        Me.lblNumeroRNC.Size = New System.Drawing.Size(45, 14)
        Me.lblNumeroRNC.TabIndex = 47
        Me.lblNumeroRNC.Text = "N° RNC:"
        '
        'lblSituacao
        '
        Me.lblSituacao.AutoSize = True
        Me.lblSituacao.Location = New System.Drawing.Point(635, 57)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Size = New System.Drawing.Size(52, 14)
        Me.lblSituacao.TabIndex = 45
        Me.lblSituacao.Text = "Situação:"
        '
        'cboSituacao
        '
        Me.cboSituacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacao.Location = New System.Drawing.Point(638, 75)
        Me.cboSituacao.Name = "cboSituacao"
        Me.cboSituacao.Size = New System.Drawing.Size(249, 20)
        Me.cboSituacao.TabIndex = 5
        '
        'txtOrigem
        '
        Me.txtOrigem.Location = New System.Drawing.Point(170, 75)
        Me.txtOrigem.MaxLength = 200
        Me.txtOrigem.Name = "txtOrigem"
        Me.txtOrigem.Size = New System.Drawing.Size(372, 20)
        Me.txtOrigem.TabIndex = 3
        '
        'lblQtdNC
        '
        Me.lblQtdNC.AutoSize = True
        Me.lblQtdNC.Location = New System.Drawing.Point(545, 17)
        Me.lblQtdNC.Name = "lblQtdNC"
        Me.lblQtdNC.Size = New System.Drawing.Size(44, 14)
        Me.lblQtdNC.TabIndex = 42
        Me.lblQtdNC.Text = "Qtd NC:"
        '
        'txtQtdNC
        '
        Me.txtQtdNC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQtdNC.DecimalDigits = 2
        Me.txtQtdNC.Location = New System.Drawing.Point(548, 34)
        Me.txtQtdNC.Name = "txtQtdNC"
        Me.txtQtdNC.ReadOnly = True
        Me.txtQtdNC.Size = New System.Drawing.Size(84, 20)
        Me.txtQtdNC.TabIndex = 41
        Me.txtQtdNC.TabStop = False
        Me.txtQtdNC.Text = "0,00"
        Me.txtQtdNC.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItem.IncludeLiterals = False
        Me.txtItem.Location = New System.Drawing.Point(264, 34)
        Me.txtItem.MaxLength = 200
        Me.txtItem.Name = "txtItem"
        Me.txtItem.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(278, 20)
        Me.txtItem.TabIndex = 40
        Me.txtItem.TabStop = False
        '
        'cboEmissor
        '
        Me.cboEmissor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEmissor.Location = New System.Drawing.Point(744, 34)
        Me.cboEmissor.Name = "cboEmissor"
        Me.cboEmissor.Size = New System.Drawing.Size(143, 20)
        Me.cboEmissor.TabIndex = 1
        '
        'lblTipoNC
        '
        Me.lblTipoNC.AutoSize = True
        Me.lblTipoNC.Location = New System.Drawing.Point(6, 58)
        Me.lblTipoNC.Name = "lblTipoNC"
        Me.lblTipoNC.Size = New System.Drawing.Size(137, 14)
        Me.lblTipoNC.TabIndex = 39
        Me.lblTipoNC.Text = "Tipo de Não Conformidade:"
        '
        'cboTipoNC
        '
        Me.cboTipoNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoNC.Location = New System.Drawing.Point(9, 75)
        Me.cboTipoNC.Name = "cboTipoNC"
        Me.cboTipoNC.Size = New System.Drawing.Size(155, 20)
        Me.cboTipoNC.TabIndex = 2
        '
        'lblItemNC
        '
        Me.lblItemNC.AutoSize = True
        Me.lblItemNC.Location = New System.Drawing.Point(261, 17)
        Me.lblItemNC.Name = "lblItemNC"
        Me.lblItemNC.Size = New System.Drawing.Size(29, 14)
        Me.lblItemNC.TabIndex = 35
        Me.lblItemNC.Text = "Item:"
        '
        'lblQtdSAC
        '
        Me.lblQtdSAC.AutoSize = True
        Me.lblQtdSAC.Location = New System.Drawing.Point(545, 58)
        Me.lblQtdSAC.Name = "lblQtdSAC"
        Me.lblQtdSAC.Size = New System.Drawing.Size(52, 14)
        Me.lblQtdSAC.TabIndex = 33
        Me.lblQtdSAC.Text = "Qtd SAC:"
        '
        'txtQtdSAC
        '
        Me.txtQtdSAC.DecimalDigits = 2
        Me.txtQtdSAC.Location = New System.Drawing.Point(548, 75)
        Me.txtQtdSAC.Name = "txtQtdSAC"
        Me.txtQtdSAC.Size = New System.Drawing.Size(84, 20)
        Me.txtQtdSAC.TabIndex = 4
        Me.txtQtdSAC.Text = "0,00"
        Me.txtQtdSAC.Value = New Decimal(New Integer() {0, 0, 0, 131072})
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
        'lblOrigem
        '
        Me.lblOrigem.AutoSize = True
        Me.lblOrigem.Location = New System.Drawing.Point(167, 58)
        Me.lblOrigem.Name = "lblOrigem"
        Me.lblOrigem.Size = New System.Drawing.Size(44, 14)
        Me.lblOrigem.TabIndex = 27
        Me.lblOrigem.Text = "Origem:"
        '
        'lblEmissor
        '
        Me.lblEmissor.AutoSize = True
        Me.lblEmissor.Location = New System.Drawing.Point(741, 17)
        Me.lblEmissor.Name = "lblEmissor"
        Me.lblEmissor.Size = New System.Drawing.Size(48, 14)
        Me.lblEmissor.TabIndex = 25
        Me.lblEmissor.Text = "Emissor:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(635, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 23
        Me.lblData.Text = "Data:"
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(638, 34)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(100, 20)
        Me.dtpData.TabIndex = 0
        Me.dtpData.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtNumeroSAC
        '
        Me.txtNumeroSAC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroSAC.IncludeLiterals = False
        Me.txtNumeroSAC.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroSAC.MaxLength = 20
        Me.txtNumeroSAC.Name = "txtNumeroSAC"
        Me.txtNumeroSAC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroSAC.ReadOnly = True
        Me.txtNumeroSAC.Size = New System.Drawing.Size(61, 20)
        Me.txtNumeroSAC.TabIndex = 0
        Me.txtNumeroSAC.TabStop = False
        '
        'lblNumeroSAC
        '
        Me.lblNumeroSAC.AutoSize = True
        Me.lblNumeroSAC.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroSAC.Name = "lblNumeroSAC"
        Me.lblNumeroSAC.Size = New System.Drawing.Size(46, 14)
        Me.lblNumeroSAC.TabIndex = 2
        Me.lblNumeroSAC.Text = "N° SAC:"
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnUltimoRegistro)
        Me.grpControle2.Controls.Add(Me.btnRegistroAnterior)
        Me.grpControle2.Controls.Add(Me.btnProximoRegistro)
        Me.grpControle2.Controls.Add(Me.btnNovoSACDados)
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Controls.Add(Me.btnSalvar)
        Me.grpControle2.Location = New System.Drawing.Point(9, 483)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(896, 51)
        Me.grpControle2.TabIndex = 1
        Me.grpControle2.VisualStyleManager = Me.vsmMain
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
        Me.btnUltimoRegistro.TabIndex = 32
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
        Me.btnRegistroAnterior.TabIndex = 30
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
        Me.btnProximoRegistro.TabIndex = 31
        Me.btnProximoRegistro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovoSACDados
        '
        Me.btnNovoSACDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoSACDados.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovoSACDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovoSACDados.Location = New System.Drawing.Point(579, 17)
        Me.btnNovoSACDados.Name = "btnNovoSACDados"
        Me.btnNovoSACDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovoSACDados.Size = New System.Drawing.Size(114, 23)
        Me.btnNovoSACDados.TabIndex = 0
        Me.btnNovoSACDados.Text = "Novo SAC"
        Me.btnNovoSACDados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(796, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
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
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 113)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 368)
        Me.tabDados.TabIndex = 0
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDescricaoSAC, Me.pagArquivos, Me.pagReacaoNC, Me.pagDadosRI, Me.pagAnaliseCausas, Me.pagAcoesCorretivas, Me.pagResultados, Me.pagAnaliseCritica, Me.pagRiscosOportunidades, Me.pagHistorico})
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDescricaoSAC
        '
        Me.pagDescricaoSAC.Controls.Add(Me.grpDescricaoSAC)
        Me.pagDescricaoSAC.Key = "pagDescricaoRNC"
        Me.pagDescricaoSAC.Location = New System.Drawing.Point(1, 22)
        Me.pagDescricaoSAC.Name = "pagDescricaoSAC"
        Me.pagDescricaoSAC.Size = New System.Drawing.Size(895, 345)
        Me.pagDescricaoSAC.TabStop = True
        Me.pagDescricaoSAC.Text = "Descrição SAC"
        '
        'grpDescricaoSAC
        '
        Me.grpDescricaoSAC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDescricaoSAC.BackColor = System.Drawing.Color.Transparent
        Me.grpDescricaoSAC.Controls.Add(Me.lblDataDescricao)
        Me.grpDescricaoSAC.Controls.Add(Me.dtpDataDescricao)
        Me.grpDescricaoSAC.Controls.Add(Me.cboResponsavelDescricao)
        Me.grpDescricaoSAC.Controls.Add(Me.lblResponsavelDescricao)
        Me.grpDescricaoSAC.Controls.Add(Me.lblEvidenciaDescricao)
        Me.grpDescricaoSAC.Controls.Add(Me.lblDesvioDescricao)
        Me.grpDescricaoSAC.Controls.Add(Me.lblRequisitoDescricao)
        Me.grpDescricaoSAC.Controls.Add(Me.txtRequisitoDescricao)
        Me.grpDescricaoSAC.Controls.Add(Me.txtDesvioDescricao)
        Me.grpDescricaoSAC.Controls.Add(Me.txtEvidenciaDescricao)
        Me.grpDescricaoSAC.Location = New System.Drawing.Point(9, 3)
        Me.grpDescricaoSAC.Name = "grpDescricaoSAC"
        Me.grpDescricaoSAC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDescricaoSAC.Size = New System.Drawing.Size(878, 335)
        Me.grpDescricaoSAC.TabIndex = 0
        Me.grpDescricaoSAC.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDescricaoSAC.VisualStyleManager = Me.vsmMain
        '
        'lblDataDescricao
        '
        Me.lblDataDescricao.AutoSize = True
        Me.lblDataDescricao.Location = New System.Drawing.Point(239, 17)
        Me.lblDataDescricao.Name = "lblDataDescricao"
        Me.lblDataDescricao.Size = New System.Drawing.Size(32, 14)
        Me.lblDataDescricao.TabIndex = 29
        Me.lblDataDescricao.Text = "Data:"
        '
        'dtpDataDescricao
        '
        '
        '
        '
        Me.dtpDataDescricao.DropDownCalendar.Name = ""
        Me.dtpDataDescricao.Location = New System.Drawing.Point(242, 34)
        Me.dtpDataDescricao.Name = "dtpDataDescricao"
        Me.dtpDataDescricao.ShowCheckBox = True
        Me.dtpDataDescricao.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataDescricao.TabIndex = 1
        Me.dtpDataDescricao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'cboResponsavelDescricao
        '
        Me.cboResponsavelDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsavelDescricao.Location = New System.Drawing.Point(9, 34)
        Me.cboResponsavelDescricao.Name = "cboResponsavelDescricao"
        Me.cboResponsavelDescricao.Size = New System.Drawing.Size(227, 20)
        Me.cboResponsavelDescricao.TabIndex = 0
        '
        'lblResponsavelDescricao
        '
        Me.lblResponsavelDescricao.AutoSize = True
        Me.lblResponsavelDescricao.Location = New System.Drawing.Point(6, 17)
        Me.lblResponsavelDescricao.Name = "lblResponsavelDescricao"
        Me.lblResponsavelDescricao.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavelDescricao.TabIndex = 27
        Me.lblResponsavelDescricao.Text = "Responsável:"
        '
        'lblEvidenciaDescricao
        '
        Me.lblEvidenciaDescricao.AutoSize = True
        Me.lblEvidenciaDescricao.Location = New System.Drawing.Point(6, 240)
        Me.lblEvidenciaDescricao.Name = "lblEvidenciaDescricao"
        Me.lblEvidenciaDescricao.Size = New System.Drawing.Size(56, 14)
        Me.lblEvidenciaDescricao.TabIndex = 10
        Me.lblEvidenciaDescricao.Text = "Evidência:"
        '
        'lblDesvioDescricao
        '
        Me.lblDesvioDescricao.AutoSize = True
        Me.lblDesvioDescricao.Location = New System.Drawing.Point(6, 148)
        Me.lblDesvioDescricao.Name = "lblDesvioDescricao"
        Me.lblDesvioDescricao.Size = New System.Drawing.Size(43, 14)
        Me.lblDesvioDescricao.TabIndex = 9
        Me.lblDesvioDescricao.Text = "Desvio:"
        '
        'lblRequisitoDescricao
        '
        Me.lblRequisitoDescricao.AutoSize = True
        Me.lblRequisitoDescricao.Location = New System.Drawing.Point(6, 59)
        Me.lblRequisitoDescricao.Name = "lblRequisitoDescricao"
        Me.lblRequisitoDescricao.Size = New System.Drawing.Size(54, 14)
        Me.lblRequisitoDescricao.TabIndex = 8
        Me.lblRequisitoDescricao.Text = "Requisito:"
        '
        'txtRequisitoDescricao
        '
        Me.txtRequisitoDescricao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRequisitoDescricao.Location = New System.Drawing.Point(9, 76)
        Me.txtRequisitoDescricao.MaxLength = 5000
        Me.txtRequisitoDescricao.Multiline = True
        Me.txtRequisitoDescricao.Name = "txtRequisitoDescricao"
        Me.txtRequisitoDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRequisitoDescricao.Size = New System.Drawing.Size(863, 69)
        Me.txtRequisitoDescricao.TabIndex = 2
        '
        'txtDesvioDescricao
        '
        Me.txtDesvioDescricao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesvioDescricao.Location = New System.Drawing.Point(9, 165)
        Me.txtDesvioDescricao.MaxLength = 5000
        Me.txtDesvioDescricao.Multiline = True
        Me.txtDesvioDescricao.Name = "txtDesvioDescricao"
        Me.txtDesvioDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesvioDescricao.Size = New System.Drawing.Size(864, 72)
        Me.txtDesvioDescricao.TabIndex = 3
        '
        'txtEvidenciaDescricao
        '
        Me.txtEvidenciaDescricao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEvidenciaDescricao.Location = New System.Drawing.Point(9, 257)
        Me.txtEvidenciaDescricao.MaxLength = 5000
        Me.txtEvidenciaDescricao.Multiline = True
        Me.txtEvidenciaDescricao.Name = "txtEvidenciaDescricao"
        Me.txtEvidenciaDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEvidenciaDescricao.Size = New System.Drawing.Size(864, 72)
        Me.txtEvidenciaDescricao.TabIndex = 4
        '
        'pagArquivos
        '
        Me.pagArquivos.Controls.Add(Me.grpArquivo)
        Me.pagArquivos.Controls.Add(Me.grdArquivo)
        Me.pagArquivos.Key = "pagArquivos"
        Me.pagArquivos.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivos.Name = "pagArquivos"
        Me.pagArquivos.Size = New System.Drawing.Size(895, 345)
        Me.pagArquivos.TabStop = True
        Me.pagArquivos.Text = "Arquivos"
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
        Me.grpArquivo.Size = New System.Drawing.Size(879, 104)
        Me.grpArquivo.TabIndex = 1
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarArquivo
        '
        Me.btnProcurarArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProcurarArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnProcurarArquivo.Location = New System.Drawing.Point(653, 74)
        Me.btnProcurarArquivo.Name = "btnProcurarArquivo"
        Me.btnProcurarArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProcurarArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnProcurarArquivo.TabIndex = 16
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
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(9, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(645, 20)
        Me.txtArquivo.TabIndex = 15
        Me.txtArquivo.TabStop = False
        '
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(664, 20)
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
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirArquivo.Name = "btnExcluirArquivo"
        Me.btnExcluirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivo.TabIndex = 2
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
        Me.btnInserirArquivo.TabIndex = 1
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
        Me.grdArquivo.Location = New System.Drawing.Point(9, 113)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 222)
        Me.grdArquivo.TabIndex = 3
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'pagReacaoNC
        '
        Me.pagReacaoNC.Controls.Add(Me.grpReacao)
        Me.pagReacaoNC.Controls.Add(Me.grdReacoes)
        Me.pagReacaoNC.Key = "pagReacaoNC"
        Me.pagReacaoNC.Location = New System.Drawing.Point(1, 22)
        Me.pagReacaoNC.Name = "pagReacaoNC"
        Me.pagReacaoNC.Size = New System.Drawing.Size(895, 345)
        Me.pagReacaoNC.TabStop = True
        Me.pagReacaoNC.Tag = "pagReacaoNC"
        Me.pagReacaoNC.Text = "Reações à Não Conformidade"
        '
        'grpReacao
        '
        Me.grpReacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpReacao.BackColor = System.Drawing.Color.Transparent
        Me.grpReacao.Controls.Add(Me.lblSituacaoReacao)
        Me.grpReacao.Controls.Add(Me.cboSituacaoReacoes)
        Me.grpReacao.Controls.Add(Me.lblPrazoReacoes)
        Me.grpReacao.Controls.Add(Me.dtpPrazoReacoes)
        Me.grpReacao.Controls.Add(Me.cboResponsavelReacoes)
        Me.grpReacao.Controls.Add(Me.lblResponsavelReacoes)
        Me.grpReacao.Controls.Add(Me.txtAcaoContencaoReacoes)
        Me.grpReacao.Controls.Add(Me.lblAcaoCorrecaoReacoes)
        Me.grpReacao.Controls.Add(Me.btnExcluirReacoes)
        Me.grpReacao.Controls.Add(Me.btnInserirReacoes)
        Me.grpReacao.Location = New System.Drawing.Point(9, 3)
        Me.grpReacao.Name = "grpReacao"
        Me.grpReacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpReacao.Size = New System.Drawing.Size(879, 104)
        Me.grpReacao.TabIndex = 4
        Me.grpReacao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpReacao.VisualStyleManager = Me.vsmMain
        '
        'lblSituacaoReacao
        '
        Me.lblSituacaoReacao.AutoSize = True
        Me.lblSituacaoReacao.Location = New System.Drawing.Point(345, 17)
        Me.lblSituacaoReacao.Name = "lblSituacaoReacao"
        Me.lblSituacaoReacao.Size = New System.Drawing.Size(52, 14)
        Me.lblSituacaoReacao.TabIndex = 35
        Me.lblSituacaoReacao.Text = "Situação:"
        '
        'cboSituacaoReacoes
        '
        Me.cboSituacaoReacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoReacoes.Location = New System.Drawing.Point(348, 34)
        Me.cboSituacaoReacoes.Name = "cboSituacaoReacoes"
        Me.cboSituacaoReacoes.Size = New System.Drawing.Size(381, 20)
        Me.cboSituacaoReacoes.TabIndex = 34
        '
        'lblPrazoReacoes
        '
        Me.lblPrazoReacoes.AutoSize = True
        Me.lblPrazoReacoes.Location = New System.Drawing.Point(239, 17)
        Me.lblPrazoReacoes.Name = "lblPrazoReacoes"
        Me.lblPrazoReacoes.Size = New System.Drawing.Size(38, 14)
        Me.lblPrazoReacoes.TabIndex = 33
        Me.lblPrazoReacoes.Text = "Prazo:"
        '
        'dtpPrazoReacoes
        '
        '
        '
        '
        Me.dtpPrazoReacoes.DropDownCalendar.Name = ""
        Me.dtpPrazoReacoes.Location = New System.Drawing.Point(242, 34)
        Me.dtpPrazoReacoes.Name = "dtpPrazoReacoes"
        Me.dtpPrazoReacoes.Size = New System.Drawing.Size(100, 20)
        Me.dtpPrazoReacoes.TabIndex = 32
        Me.dtpPrazoReacoes.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'cboResponsavelReacoes
        '
        Me.cboResponsavelReacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsavelReacoes.Location = New System.Drawing.Point(9, 34)
        Me.cboResponsavelReacoes.Name = "cboResponsavelReacoes"
        Me.cboResponsavelReacoes.Size = New System.Drawing.Size(227, 20)
        Me.cboResponsavelReacoes.TabIndex = 30
        '
        'lblResponsavelReacoes
        '
        Me.lblResponsavelReacoes.AutoSize = True
        Me.lblResponsavelReacoes.Location = New System.Drawing.Point(6, 17)
        Me.lblResponsavelReacoes.Name = "lblResponsavelReacoes"
        Me.lblResponsavelReacoes.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavelReacoes.TabIndex = 31
        Me.lblResponsavelReacoes.Text = "Responsável:"
        '
        'txtAcaoContencaoReacoes
        '
        Me.txtAcaoContencaoReacoes.Location = New System.Drawing.Point(9, 74)
        Me.txtAcaoContencaoReacoes.MaxLength = 200
        Me.txtAcaoContencaoReacoes.Name = "txtAcaoContencaoReacoes"
        Me.txtAcaoContencaoReacoes.Size = New System.Drawing.Size(720, 20)
        Me.txtAcaoContencaoReacoes.TabIndex = 0
        '
        'lblAcaoCorrecaoReacoes
        '
        Me.lblAcaoCorrecaoReacoes.AutoSize = True
        Me.lblAcaoCorrecaoReacoes.Location = New System.Drawing.Point(6, 57)
        Me.lblAcaoCorrecaoReacoes.Name = "lblAcaoCorrecaoReacoes"
        Me.lblAcaoCorrecaoReacoes.Size = New System.Drawing.Size(190, 14)
        Me.lblAcaoCorrecaoReacoes.TabIndex = 12
        Me.lblAcaoCorrecaoReacoes.Text = "Ações de Contenção ou de Correção:"
        '
        'btnExcluirReacoes
        '
        Me.btnExcluirReacoes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirReacoes.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirReacoes.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirReacoes.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirReacoes.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirReacoes.Name = "btnExcluirReacoes"
        Me.btnExcluirReacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirReacoes.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirReacoes.TabIndex = 2
        Me.btnExcluirReacoes.Text = "Excluir"
        Me.btnExcluirReacoes.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirReacoes
        '
        Me.btnInserirReacoes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirReacoes.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirReacoes.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirReacoes.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirReacoes.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirReacoes.Name = "btnInserirReacoes"
        Me.btnInserirReacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirReacoes.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirReacoes.TabIndex = 1
        Me.btnInserirReacoes.Text = "Inserir"
        Me.btnInserirReacoes.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdReacoes
        '
        Me.grdReacoes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdReacoes.AlternatingColors = True
        Me.grdReacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdReacoes_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdReacoes_DesignTimeLayout_Reference_0.Instance"), Object)
        grdReacoes_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdReacoes_DesignTimeLayout_Reference_0})
        grdReacoes_DesignTimeLayout.LayoutString = resources.GetString("grdReacoes_DesignTimeLayout.LayoutString")
        Me.grdReacoes.DesignTimeLayout = grdReacoes_DesignTimeLayout
        Me.grdReacoes.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdReacoes.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdReacoes.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdReacoes.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdReacoes.FrozenColumns = 3
        Me.grdReacoes.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdReacoes.GroupByBoxVisible = False
        Me.grdReacoes.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdReacoes.Location = New System.Drawing.Point(9, 113)
        Me.grdReacoes.Name = "grdReacoes"
        Me.grdReacoes.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdReacoes.RecordNavigator = True
        Me.grdReacoes.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdReacoes.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdReacoes.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdReacoes.Size = New System.Drawing.Size(879, 222)
        Me.grdReacoes.TabIndex = 5
        Me.grdReacoes.TabStop = False
        Me.grdReacoes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdReacoes.VisualStyleManager = Me.vsmMain
        '
        'pagDadosRI
        '
        Me.pagDadosRI.Controls.Add(Me.grpExtensao)
        Me.pagDadosRI.Key = "pagDadosRI"
        Me.pagDadosRI.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosRI.Name = "pagDadosRI"
        Me.pagDadosRI.Size = New System.Drawing.Size(895, 345)
        Me.pagDadosRI.TabStop = True
        Me.pagDadosRI.Text = "Extensão da Não Conformidade"
        '
        'grpExtensao
        '
        Me.grpExtensao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpExtensao.BackColor = System.Drawing.Color.Transparent
        Me.grpExtensao.Controls.Add(Me.lblDataExtensao)
        Me.grpExtensao.Controls.Add(Me.dtpDataExtensao)
        Me.grpExtensao.Controls.Add(Me.cboResponsavelExtencao)
        Me.grpExtensao.Controls.Add(Me.lblResponsavelExtencao)
        Me.grpExtensao.Controls.Add(Me.lblExtencaoNC)
        Me.grpExtensao.Controls.Add(Me.txtExtencaoNC)
        Me.grpExtensao.Location = New System.Drawing.Point(9, 3)
        Me.grpExtensao.Name = "grpExtensao"
        Me.grpExtensao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpExtensao.Size = New System.Drawing.Size(878, 335)
        Me.grpExtensao.TabIndex = 2
        Me.grpExtensao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpExtensao.VisualStyleManager = Me.vsmMain
        '
        'lblDataExtensao
        '
        Me.lblDataExtensao.AutoSize = True
        Me.lblDataExtensao.Location = New System.Drawing.Point(239, 17)
        Me.lblDataExtensao.Name = "lblDataExtensao"
        Me.lblDataExtensao.Size = New System.Drawing.Size(32, 14)
        Me.lblDataExtensao.TabIndex = 29
        Me.lblDataExtensao.Text = "Data:"
        '
        'dtpDataExtensao
        '
        Me.dtpDataExtensao.Checked = False
        '
        '
        '
        Me.dtpDataExtensao.DropDownCalendar.Name = ""
        Me.dtpDataExtensao.Location = New System.Drawing.Point(242, 34)
        Me.dtpDataExtensao.Name = "dtpDataExtensao"
        Me.dtpDataExtensao.ShowCheckBox = True
        Me.dtpDataExtensao.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataExtensao.TabIndex = 28
        Me.dtpDataExtensao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'cboResponsavelExtencao
        '
        Me.cboResponsavelExtencao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsavelExtencao.Location = New System.Drawing.Point(9, 34)
        Me.cboResponsavelExtencao.Name = "cboResponsavelExtencao"
        Me.cboResponsavelExtencao.Size = New System.Drawing.Size(227, 20)
        Me.cboResponsavelExtencao.TabIndex = 26
        '
        'lblResponsavelExtencao
        '
        Me.lblResponsavelExtencao.AutoSize = True
        Me.lblResponsavelExtencao.Location = New System.Drawing.Point(6, 17)
        Me.lblResponsavelExtencao.Name = "lblResponsavelExtencao"
        Me.lblResponsavelExtencao.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavelExtencao.TabIndex = 27
        Me.lblResponsavelExtencao.Text = "Responsável:"
        '
        'lblExtencaoNC
        '
        Me.lblExtencaoNC.AutoSize = True
        Me.lblExtencaoNC.Location = New System.Drawing.Point(6, 59)
        Me.lblExtencaoNC.Name = "lblExtencaoNC"
        Me.lblExtencaoNC.Size = New System.Drawing.Size(335, 14)
        Me.lblExtencaoNC.TabIndex = 8
        Me.lblExtencaoNC.Text = "Extensão da Não Conformidade (Ocorrência similar dentro do SGQ):"
        '
        'txtExtencaoNC
        '
        Me.txtExtencaoNC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExtencaoNC.Location = New System.Drawing.Point(9, 76)
        Me.txtExtencaoNC.MaxLength = 5000
        Me.txtExtencaoNC.Multiline = True
        Me.txtExtencaoNC.Name = "txtExtencaoNC"
        Me.txtExtencaoNC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExtencaoNC.Size = New System.Drawing.Size(863, 253)
        Me.txtExtencaoNC.TabIndex = 0
        '
        'pagAnaliseCausas
        '
        Me.pagAnaliseCausas.Controls.Add(Me.grpAnaliseCausa)
        Me.pagAnaliseCausas.Key = "pagAnaliseCausas"
        Me.pagAnaliseCausas.Location = New System.Drawing.Point(1, 22)
        Me.pagAnaliseCausas.Name = "pagAnaliseCausas"
        Me.pagAnaliseCausas.Size = New System.Drawing.Size(895, 345)
        Me.pagAnaliseCausas.TabStop = True
        Me.pagAnaliseCausas.Text = "Análise de Causas"
        '
        'grpAnaliseCausa
        '
        Me.grpAnaliseCausa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAnaliseCausa.BackColor = System.Drawing.Color.Transparent
        Me.grpAnaliseCausa.Controls.Add(Me.lblDataAnaliseCausa)
        Me.grpAnaliseCausa.Controls.Add(Me.dtpDataAnaliseCausa)
        Me.grpAnaliseCausa.Controls.Add(Me.cboResponsavelAnaliseCausa)
        Me.grpAnaliseCausa.Controls.Add(Me.lblResponsavelAnaliseCausa)
        Me.grpAnaliseCausa.Controls.Add(Me.lblAnaliseCausa)
        Me.grpAnaliseCausa.Controls.Add(Me.txtAnaliseCausa)
        Me.grpAnaliseCausa.Location = New System.Drawing.Point(9, 3)
        Me.grpAnaliseCausa.Name = "grpAnaliseCausa"
        Me.grpAnaliseCausa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAnaliseCausa.Size = New System.Drawing.Size(878, 335)
        Me.grpAnaliseCausa.TabIndex = 3
        Me.grpAnaliseCausa.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpAnaliseCausa.VisualStyleManager = Me.vsmMain
        '
        'lblDataAnaliseCausa
        '
        Me.lblDataAnaliseCausa.AutoSize = True
        Me.lblDataAnaliseCausa.Location = New System.Drawing.Point(239, 17)
        Me.lblDataAnaliseCausa.Name = "lblDataAnaliseCausa"
        Me.lblDataAnaliseCausa.Size = New System.Drawing.Size(32, 14)
        Me.lblDataAnaliseCausa.TabIndex = 29
        Me.lblDataAnaliseCausa.Text = "Data:"
        '
        'dtpDataAnaliseCausa
        '
        Me.dtpDataAnaliseCausa.Checked = False
        '
        '
        '
        Me.dtpDataAnaliseCausa.DropDownCalendar.Name = ""
        Me.dtpDataAnaliseCausa.Location = New System.Drawing.Point(242, 34)
        Me.dtpDataAnaliseCausa.Name = "dtpDataAnaliseCausa"
        Me.dtpDataAnaliseCausa.ShowCheckBox = True
        Me.dtpDataAnaliseCausa.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataAnaliseCausa.TabIndex = 28
        Me.dtpDataAnaliseCausa.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'cboResponsavelAnaliseCausa
        '
        Me.cboResponsavelAnaliseCausa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsavelAnaliseCausa.Location = New System.Drawing.Point(9, 34)
        Me.cboResponsavelAnaliseCausa.Name = "cboResponsavelAnaliseCausa"
        Me.cboResponsavelAnaliseCausa.Size = New System.Drawing.Size(227, 20)
        Me.cboResponsavelAnaliseCausa.TabIndex = 26
        '
        'lblResponsavelAnaliseCausa
        '
        Me.lblResponsavelAnaliseCausa.AutoSize = True
        Me.lblResponsavelAnaliseCausa.Location = New System.Drawing.Point(6, 17)
        Me.lblResponsavelAnaliseCausa.Name = "lblResponsavelAnaliseCausa"
        Me.lblResponsavelAnaliseCausa.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavelAnaliseCausa.TabIndex = 27
        Me.lblResponsavelAnaliseCausa.Text = "Responsável:"
        '
        'lblAnaliseCausa
        '
        Me.lblAnaliseCausa.AutoSize = True
        Me.lblAnaliseCausa.Location = New System.Drawing.Point(6, 59)
        Me.lblAnaliseCausa.Name = "lblAnaliseCausa"
        Me.lblAnaliseCausa.Size = New System.Drawing.Size(265, 14)
        Me.lblAnaliseCausa.TabIndex = 8
        Me.lblAnaliseCausa.Text = "Análise de Causas (Determinação de Causa(s) Raiz):"
        '
        'txtAnaliseCausa
        '
        Me.txtAnaliseCausa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnaliseCausa.Location = New System.Drawing.Point(9, 76)
        Me.txtAnaliseCausa.MaxLength = 5000
        Me.txtAnaliseCausa.Multiline = True
        Me.txtAnaliseCausa.Name = "txtAnaliseCausa"
        Me.txtAnaliseCausa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnaliseCausa.Size = New System.Drawing.Size(863, 253)
        Me.txtAnaliseCausa.TabIndex = 0
        '
        'pagAcoesCorretivas
        '
        Me.pagAcoesCorretivas.Controls.Add(Me.grdAcoesCorretivas)
        Me.pagAcoesCorretivas.Controls.Add(Me.grpAcaoCorretiva)
        Me.pagAcoesCorretivas.Key = "pagAcoesCorretivas"
        Me.pagAcoesCorretivas.Location = New System.Drawing.Point(1, 22)
        Me.pagAcoesCorretivas.Name = "pagAcoesCorretivas"
        Me.pagAcoesCorretivas.Size = New System.Drawing.Size(895, 345)
        Me.pagAcoesCorretivas.TabStop = True
        Me.pagAcoesCorretivas.Tag = ""
        Me.pagAcoesCorretivas.Text = "Ações Corretivas"
        '
        'grdAcoesCorretivas
        '
        Me.grdAcoesCorretivas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdAcoesCorretivas.AlternatingColors = True
        Me.grdAcoesCorretivas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdAcoesCorretivas_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdAcoesCorretivas_DesignTimeLayout_Reference_0.Instance"), Object)
        grdAcoesCorretivas_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdAcoesCorretivas_DesignTimeLayout_Reference_0})
        grdAcoesCorretivas_DesignTimeLayout.LayoutString = resources.GetString("grdAcoesCorretivas_DesignTimeLayout.LayoutString")
        Me.grdAcoesCorretivas.DesignTimeLayout = grdAcoesCorretivas_DesignTimeLayout
        Me.grdAcoesCorretivas.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdAcoesCorretivas.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdAcoesCorretivas.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdAcoesCorretivas.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdAcoesCorretivas.FrozenColumns = 3
        Me.grdAcoesCorretivas.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdAcoesCorretivas.GroupByBoxVisible = False
        Me.grdAcoesCorretivas.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdAcoesCorretivas.Location = New System.Drawing.Point(9, 114)
        Me.grdAcoesCorretivas.Name = "grdAcoesCorretivas"
        Me.grdAcoesCorretivas.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdAcoesCorretivas.RecordNavigator = True
        Me.grdAcoesCorretivas.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdAcoesCorretivas.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdAcoesCorretivas.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdAcoesCorretivas.Size = New System.Drawing.Size(879, 222)
        Me.grdAcoesCorretivas.TabIndex = 7
        Me.grdAcoesCorretivas.TabStop = False
        Me.grdAcoesCorretivas.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdAcoesCorretivas.VisualStyleManager = Me.vsmMain
        '
        'grpAcaoCorretiva
        '
        Me.grpAcaoCorretiva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAcaoCorretiva.BackColor = System.Drawing.Color.Transparent
        Me.grpAcaoCorretiva.Controls.Add(Me.txtResponsaveis)
        Me.grpAcaoCorretiva.Controls.Add(Me.lblSituacaoAcoesCorretivas)
        Me.grpAcaoCorretiva.Controls.Add(Me.cboSituacaoAcoesCorretivas)
        Me.grpAcaoCorretiva.Controls.Add(Me.lblPrazoAcoesCorretivas)
        Me.grpAcaoCorretiva.Controls.Add(Me.dtpPrazoAcoesCorretivas)
        Me.grpAcaoCorretiva.Controls.Add(Me.lblResponsavelAcoesCorretivas)
        Me.grpAcaoCorretiva.Controls.Add(Me.txtAcoesCorretivas)
        Me.grpAcaoCorretiva.Controls.Add(Me.lblAcoesCorretivas)
        Me.grpAcaoCorretiva.Controls.Add(Me.btnExcluirAcoesCorretivas)
        Me.grpAcaoCorretiva.Controls.Add(Me.btnInserirAcoesCorretivas)
        Me.grpAcaoCorretiva.Location = New System.Drawing.Point(9, 4)
        Me.grpAcaoCorretiva.Name = "grpAcaoCorretiva"
        Me.grpAcaoCorretiva.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAcaoCorretiva.Size = New System.Drawing.Size(879, 104)
        Me.grpAcaoCorretiva.TabIndex = 6
        Me.grpAcaoCorretiva.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpAcaoCorretiva.VisualStyleManager = Me.vsmMain
        '
        'txtResponsaveis
        '
        Me.txtResponsaveis.Location = New System.Drawing.Point(9, 34)
        Me.txtResponsaveis.MaxLength = 200
        Me.txtResponsaveis.Name = "txtResponsaveis"
        Me.txtResponsaveis.Size = New System.Drawing.Size(227, 20)
        Me.txtResponsaveis.TabIndex = 36
        '
        'lblSituacaoAcoesCorretivas
        '
        Me.lblSituacaoAcoesCorretivas.AutoSize = True
        Me.lblSituacaoAcoesCorretivas.Location = New System.Drawing.Point(345, 17)
        Me.lblSituacaoAcoesCorretivas.Name = "lblSituacaoAcoesCorretivas"
        Me.lblSituacaoAcoesCorretivas.Size = New System.Drawing.Size(52, 14)
        Me.lblSituacaoAcoesCorretivas.TabIndex = 35
        Me.lblSituacaoAcoesCorretivas.Text = "Situação:"
        '
        'cboSituacaoAcoesCorretivas
        '
        Me.cboSituacaoAcoesCorretivas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoAcoesCorretivas.Location = New System.Drawing.Point(348, 34)
        Me.cboSituacaoAcoesCorretivas.Name = "cboSituacaoAcoesCorretivas"
        Me.cboSituacaoAcoesCorretivas.Size = New System.Drawing.Size(381, 20)
        Me.cboSituacaoAcoesCorretivas.TabIndex = 34
        '
        'lblPrazoAcoesCorretivas
        '
        Me.lblPrazoAcoesCorretivas.AutoSize = True
        Me.lblPrazoAcoesCorretivas.Location = New System.Drawing.Point(239, 17)
        Me.lblPrazoAcoesCorretivas.Name = "lblPrazoAcoesCorretivas"
        Me.lblPrazoAcoesCorretivas.Size = New System.Drawing.Size(38, 14)
        Me.lblPrazoAcoesCorretivas.TabIndex = 33
        Me.lblPrazoAcoesCorretivas.Text = "Prazo:"
        '
        'dtpPrazoAcoesCorretivas
        '
        '
        '
        '
        Me.dtpPrazoAcoesCorretivas.DropDownCalendar.Name = ""
        Me.dtpPrazoAcoesCorretivas.Location = New System.Drawing.Point(242, 34)
        Me.dtpPrazoAcoesCorretivas.Name = "dtpPrazoAcoesCorretivas"
        Me.dtpPrazoAcoesCorretivas.Size = New System.Drawing.Size(100, 20)
        Me.dtpPrazoAcoesCorretivas.TabIndex = 32
        Me.dtpPrazoAcoesCorretivas.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblResponsavelAcoesCorretivas
        '
        Me.lblResponsavelAcoesCorretivas.AutoSize = True
        Me.lblResponsavelAcoesCorretivas.Location = New System.Drawing.Point(6, 17)
        Me.lblResponsavelAcoesCorretivas.Name = "lblResponsavelAcoesCorretivas"
        Me.lblResponsavelAcoesCorretivas.Size = New System.Drawing.Size(89, 14)
        Me.lblResponsavelAcoesCorretivas.TabIndex = 31
        Me.lblResponsavelAcoesCorretivas.Text = "Responsável(is):"
        '
        'txtAcoesCorretivas
        '
        Me.txtAcoesCorretivas.Location = New System.Drawing.Point(9, 74)
        Me.txtAcoesCorretivas.MaxLength = 200
        Me.txtAcoesCorretivas.Name = "txtAcoesCorretivas"
        Me.txtAcoesCorretivas.Size = New System.Drawing.Size(720, 20)
        Me.txtAcoesCorretivas.TabIndex = 0
        '
        'lblAcoesCorretivas
        '
        Me.lblAcoesCorretivas.AutoSize = True
        Me.lblAcoesCorretivas.Location = New System.Drawing.Point(6, 57)
        Me.lblAcoesCorretivas.Name = "lblAcoesCorretivas"
        Me.lblAcoesCorretivas.Size = New System.Drawing.Size(342, 14)
        Me.lblAcoesCorretivas.TabIndex = 12
        Me.lblAcoesCorretivas.Text = "Ações para eliminação da(s) causa(s) raiz para prevenir a repetição:"
        '
        'btnExcluirAcoesCorretivas
        '
        Me.btnExcluirAcoesCorretivas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirAcoesCorretivas.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirAcoesCorretivas.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirAcoesCorretivas.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirAcoesCorretivas.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirAcoesCorretivas.Name = "btnExcluirAcoesCorretivas"
        Me.btnExcluirAcoesCorretivas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirAcoesCorretivas.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirAcoesCorretivas.TabIndex = 2
        Me.btnExcluirAcoesCorretivas.Text = "Excluir"
        Me.btnExcluirAcoesCorretivas.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirAcoesCorretivas
        '
        Me.btnInserirAcoesCorretivas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirAcoesCorretivas.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirAcoesCorretivas.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirAcoesCorretivas.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirAcoesCorretivas.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirAcoesCorretivas.Name = "btnInserirAcoesCorretivas"
        Me.btnInserirAcoesCorretivas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirAcoesCorretivas.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirAcoesCorretivas.TabIndex = 1
        Me.btnInserirAcoesCorretivas.Text = "Inserir"
        Me.btnInserirAcoesCorretivas.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagResultados
        '
        Me.pagResultados.Controls.Add(Me.grpResultados)
        Me.pagResultados.Key = "pagResultados"
        Me.pagResultados.Location = New System.Drawing.Point(1, 22)
        Me.pagResultados.Name = "pagResultados"
        Me.pagResultados.Size = New System.Drawing.Size(895, 345)
        Me.pagResultados.TabStop = True
        Me.pagResultados.Text = "Resultados"
        '
        'grpResultados
        '
        Me.grpResultados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpResultados.BackColor = System.Drawing.Color.Transparent
        Me.grpResultados.Controls.Add(Me.lblDataResultados)
        Me.grpResultados.Controls.Add(Me.dtpDataResultados)
        Me.grpResultados.Controls.Add(Me.cboResponsavelResultados)
        Me.grpResultados.Controls.Add(Me.lblResponsavelResultados)
        Me.grpResultados.Controls.Add(Me.lblResultados)
        Me.grpResultados.Controls.Add(Me.txtResultados)
        Me.grpResultados.Location = New System.Drawing.Point(9, 3)
        Me.grpResultados.Name = "grpResultados"
        Me.grpResultados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpResultados.Size = New System.Drawing.Size(878, 335)
        Me.grpResultados.TabIndex = 3
        Me.grpResultados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpResultados.VisualStyleManager = Me.vsmMain
        '
        'lblDataResultados
        '
        Me.lblDataResultados.AutoSize = True
        Me.lblDataResultados.Location = New System.Drawing.Point(239, 17)
        Me.lblDataResultados.Name = "lblDataResultados"
        Me.lblDataResultados.Size = New System.Drawing.Size(32, 14)
        Me.lblDataResultados.TabIndex = 29
        Me.lblDataResultados.Text = "Data:"
        '
        'dtpDataResultados
        '
        Me.dtpDataResultados.Checked = False
        '
        '
        '
        Me.dtpDataResultados.DropDownCalendar.Name = ""
        Me.dtpDataResultados.Location = New System.Drawing.Point(242, 34)
        Me.dtpDataResultados.Name = "dtpDataResultados"
        Me.dtpDataResultados.ShowCheckBox = True
        Me.dtpDataResultados.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataResultados.TabIndex = 28
        Me.dtpDataResultados.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'cboResponsavelResultados
        '
        Me.cboResponsavelResultados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsavelResultados.Location = New System.Drawing.Point(9, 34)
        Me.cboResponsavelResultados.Name = "cboResponsavelResultados"
        Me.cboResponsavelResultados.Size = New System.Drawing.Size(227, 20)
        Me.cboResponsavelResultados.TabIndex = 26
        '
        'lblResponsavelResultados
        '
        Me.lblResponsavelResultados.AutoSize = True
        Me.lblResponsavelResultados.Location = New System.Drawing.Point(6, 17)
        Me.lblResponsavelResultados.Name = "lblResponsavelResultados"
        Me.lblResponsavelResultados.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavelResultados.TabIndex = 27
        Me.lblResponsavelResultados.Text = "Responsável:"
        '
        'lblResultados
        '
        Me.lblResultados.AutoSize = True
        Me.lblResultados.Location = New System.Drawing.Point(6, 59)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(309, 14)
        Me.lblResultados.TabIndex = 8
        Me.lblResultados.Text = "Resultados Alcançados com as Ações Corretivas Executadas:"
        '
        'txtResultados
        '
        Me.txtResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResultados.Location = New System.Drawing.Point(9, 76)
        Me.txtResultados.MaxLength = 5000
        Me.txtResultados.Multiline = True
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResultados.Size = New System.Drawing.Size(863, 253)
        Me.txtResultados.TabIndex = 0
        '
        'pagAnaliseCritica
        '
        Me.pagAnaliseCritica.Controls.Add(Me.grpAnaliseCritica)
        Me.pagAnaliseCritica.Key = "pagAnaliseCritica"
        Me.pagAnaliseCritica.Location = New System.Drawing.Point(1, 22)
        Me.pagAnaliseCritica.Name = "pagAnaliseCritica"
        Me.pagAnaliseCritica.Size = New System.Drawing.Size(895, 345)
        Me.pagAnaliseCritica.TabStop = True
        Me.pagAnaliseCritica.Text = "Análise Crítica"
        '
        'grpAnaliseCritica
        '
        Me.grpAnaliseCritica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAnaliseCritica.BackColor = System.Drawing.Color.Transparent
        Me.grpAnaliseCritica.Controls.Add(Me.lblSatisfatoriaAnaliseCritica)
        Me.grpAnaliseCritica.Controls.Add(Me.cboSatisfatoriaAnaliseCritica)
        Me.grpAnaliseCritica.Controls.Add(Me.lblDataAnaliseCritica)
        Me.grpAnaliseCritica.Controls.Add(Me.dtpDataAnaliseCritica)
        Me.grpAnaliseCritica.Controls.Add(Me.cboResponsavelAnaliseCritica)
        Me.grpAnaliseCritica.Controls.Add(Me.lblResponsavelAnaliseCritica)
        Me.grpAnaliseCritica.Controls.Add(Me.lblAnaliseCritica)
        Me.grpAnaliseCritica.Controls.Add(Me.txtAnaliseCritica)
        Me.grpAnaliseCritica.Location = New System.Drawing.Point(9, 3)
        Me.grpAnaliseCritica.Name = "grpAnaliseCritica"
        Me.grpAnaliseCritica.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAnaliseCritica.Size = New System.Drawing.Size(878, 335)
        Me.grpAnaliseCritica.TabIndex = 4
        Me.grpAnaliseCritica.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpAnaliseCritica.VisualStyleManager = Me.vsmMain
        '
        'lblSatisfatoriaAnaliseCritica
        '
        Me.lblSatisfatoriaAnaliseCritica.AutoSize = True
        Me.lblSatisfatoriaAnaliseCritica.Location = New System.Drawing.Point(345, 17)
        Me.lblSatisfatoriaAnaliseCritica.Name = "lblSatisfatoriaAnaliseCritica"
        Me.lblSatisfatoriaAnaliseCritica.Size = New System.Drawing.Size(65, 14)
        Me.lblSatisfatoriaAnaliseCritica.TabIndex = 31
        Me.lblSatisfatoriaAnaliseCritica.Text = "Satisfatória:"
        '
        'cboSatisfatoriaAnaliseCritica
        '
        Me.cboSatisfatoriaAnaliseCritica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSatisfatoriaAnaliseCritica.Location = New System.Drawing.Point(348, 34)
        Me.cboSatisfatoriaAnaliseCritica.Name = "cboSatisfatoriaAnaliseCritica"
        Me.cboSatisfatoriaAnaliseCritica.Size = New System.Drawing.Size(79, 20)
        Me.cboSatisfatoriaAnaliseCritica.TabIndex = 30
        '
        'lblDataAnaliseCritica
        '
        Me.lblDataAnaliseCritica.AutoSize = True
        Me.lblDataAnaliseCritica.Location = New System.Drawing.Point(239, 17)
        Me.lblDataAnaliseCritica.Name = "lblDataAnaliseCritica"
        Me.lblDataAnaliseCritica.Size = New System.Drawing.Size(32, 14)
        Me.lblDataAnaliseCritica.TabIndex = 29
        Me.lblDataAnaliseCritica.Text = "Data:"
        '
        'dtpDataAnaliseCritica
        '
        Me.dtpDataAnaliseCritica.Checked = False
        '
        '
        '
        Me.dtpDataAnaliseCritica.DropDownCalendar.Name = ""
        Me.dtpDataAnaliseCritica.Location = New System.Drawing.Point(242, 34)
        Me.dtpDataAnaliseCritica.Name = "dtpDataAnaliseCritica"
        Me.dtpDataAnaliseCritica.ShowCheckBox = True
        Me.dtpDataAnaliseCritica.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataAnaliseCritica.TabIndex = 28
        Me.dtpDataAnaliseCritica.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'cboResponsavelAnaliseCritica
        '
        Me.cboResponsavelAnaliseCritica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsavelAnaliseCritica.Location = New System.Drawing.Point(9, 34)
        Me.cboResponsavelAnaliseCritica.Name = "cboResponsavelAnaliseCritica"
        Me.cboResponsavelAnaliseCritica.Size = New System.Drawing.Size(227, 20)
        Me.cboResponsavelAnaliseCritica.TabIndex = 26
        '
        'lblResponsavelAnaliseCritica
        '
        Me.lblResponsavelAnaliseCritica.AutoSize = True
        Me.lblResponsavelAnaliseCritica.Location = New System.Drawing.Point(6, 17)
        Me.lblResponsavelAnaliseCritica.Name = "lblResponsavelAnaliseCritica"
        Me.lblResponsavelAnaliseCritica.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavelAnaliseCritica.TabIndex = 27
        Me.lblResponsavelAnaliseCritica.Text = "Responsável:"
        '
        'lblAnaliseCritica
        '
        Me.lblAnaliseCritica.AutoSize = True
        Me.lblAnaliseCritica.Location = New System.Drawing.Point(6, 59)
        Me.lblAnaliseCritica.Name = "lblAnaliseCritica"
        Me.lblAnaliseCritica.Size = New System.Drawing.Size(303, 14)
        Me.lblAnaliseCritica.TabIndex = 8
        Me.lblAnaliseCritica.Text = "Análise Crítica da Eficácia das Ações Corretivas Executadas:"
        '
        'txtAnaliseCritica
        '
        Me.txtAnaliseCritica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnaliseCritica.Location = New System.Drawing.Point(9, 76)
        Me.txtAnaliseCritica.MaxLength = 5000
        Me.txtAnaliseCritica.Multiline = True
        Me.txtAnaliseCritica.Name = "txtAnaliseCritica"
        Me.txtAnaliseCritica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnaliseCritica.Size = New System.Drawing.Size(863, 253)
        Me.txtAnaliseCritica.TabIndex = 0
        '
        'pagRiscosOportunidades
        '
        Me.pagRiscosOportunidades.Controls.Add(Me.grdRiscosOportunidades)
        Me.pagRiscosOportunidades.Controls.Add(Me.grpRiscos)
        Me.pagRiscosOportunidades.Key = "pagRiscosOportunidades"
        Me.pagRiscosOportunidades.Location = New System.Drawing.Point(1, 22)
        Me.pagRiscosOportunidades.Name = "pagRiscosOportunidades"
        Me.pagRiscosOportunidades.Size = New System.Drawing.Size(895, 345)
        Me.pagRiscosOportunidades.TabStop = True
        Me.pagRiscosOportunidades.Text = "Riscos e/ou Oportunidades"
        '
        'grdRiscosOportunidades
        '
        Me.grdRiscosOportunidades.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdRiscosOportunidades.AlternatingColors = True
        Me.grdRiscosOportunidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdRiscosOportunidades_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRiscosOportunidades_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRiscosOportunidades_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRiscosOportunidades_DesignTimeLayout_Reference_0})
        grdRiscosOportunidades_DesignTimeLayout.LayoutString = resources.GetString("grdRiscosOportunidades_DesignTimeLayout.LayoutString")
        Me.grdRiscosOportunidades.DesignTimeLayout = grdRiscosOportunidades_DesignTimeLayout
        Me.grdRiscosOportunidades.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdRiscosOportunidades.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdRiscosOportunidades.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRiscosOportunidades.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRiscosOportunidades.FrozenColumns = 3
        Me.grdRiscosOportunidades.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRiscosOportunidades.GroupByBoxVisible = False
        Me.grdRiscosOportunidades.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRiscosOportunidades.Location = New System.Drawing.Point(9, 113)
        Me.grdRiscosOportunidades.Name = "grdRiscosOportunidades"
        Me.grdRiscosOportunidades.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRiscosOportunidades.RecordNavigator = True
        Me.grdRiscosOportunidades.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdRiscosOportunidades.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRiscosOportunidades.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRiscosOportunidades.Size = New System.Drawing.Size(879, 222)
        Me.grdRiscosOportunidades.TabIndex = 11
        Me.grdRiscosOportunidades.TabStop = False
        Me.grdRiscosOportunidades.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRiscosOportunidades.VisualStyleManager = Me.vsmMain
        '
        'grpRiscos
        '
        Me.grpRiscos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRiscos.BackColor = System.Drawing.Color.Transparent
        Me.grpRiscos.Controls.Add(Me.cboResponsavelRiscosOportunidades)
        Me.grpRiscos.Controls.Add(Me.lblResponsavelRiscosOportunidades)
        Me.grpRiscos.Controls.Add(Me.lblDataRiscosOportunidades)
        Me.grpRiscos.Controls.Add(Me.dtpDataRiscosOportunidades)
        Me.grpRiscos.Controls.Add(Me.txtRiscosOportunidades)
        Me.grpRiscos.Controls.Add(Me.lblRiscosOportunidades)
        Me.grpRiscos.Controls.Add(Me.btnExcluirRiscosOportunidades)
        Me.grpRiscos.Controls.Add(Me.btnInserirRiscosOportunidades)
        Me.grpRiscos.Location = New System.Drawing.Point(9, 3)
        Me.grpRiscos.Name = "grpRiscos"
        Me.grpRiscos.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpRiscos.Size = New System.Drawing.Size(879, 104)
        Me.grpRiscos.TabIndex = 10
        Me.grpRiscos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpRiscos.VisualStyleManager = Me.vsmMain
        '
        'cboResponsavelRiscosOportunidades
        '
        Me.cboResponsavelRiscosOportunidades.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboResponsavelRiscosOportunidades.Location = New System.Drawing.Point(9, 34)
        Me.cboResponsavelRiscosOportunidades.Name = "cboResponsavelRiscosOportunidades"
        Me.cboResponsavelRiscosOportunidades.Size = New System.Drawing.Size(227, 20)
        Me.cboResponsavelRiscosOportunidades.TabIndex = 38
        '
        'lblResponsavelRiscosOportunidades
        '
        Me.lblResponsavelRiscosOportunidades.AutoSize = True
        Me.lblResponsavelRiscosOportunidades.Location = New System.Drawing.Point(6, 17)
        Me.lblResponsavelRiscosOportunidades.Name = "lblResponsavelRiscosOportunidades"
        Me.lblResponsavelRiscosOportunidades.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavelRiscosOportunidades.TabIndex = 39
        Me.lblResponsavelRiscosOportunidades.Text = "Responsável:"
        '
        'lblDataRiscosOportunidades
        '
        Me.lblDataRiscosOportunidades.AutoSize = True
        Me.lblDataRiscosOportunidades.Location = New System.Drawing.Point(239, 17)
        Me.lblDataRiscosOportunidades.Name = "lblDataRiscosOportunidades"
        Me.lblDataRiscosOportunidades.Size = New System.Drawing.Size(32, 14)
        Me.lblDataRiscosOportunidades.TabIndex = 37
        Me.lblDataRiscosOportunidades.Text = "Data:"
        '
        'dtpDataRiscosOportunidades
        '
        '
        '
        '
        Me.dtpDataRiscosOportunidades.DropDownCalendar.Name = ""
        Me.dtpDataRiscosOportunidades.Location = New System.Drawing.Point(242, 34)
        Me.dtpDataRiscosOportunidades.Name = "dtpDataRiscosOportunidades"
        Me.dtpDataRiscosOportunidades.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataRiscosOportunidades.TabIndex = 36
        Me.dtpDataRiscosOportunidades.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtRiscosOportunidades
        '
        Me.txtRiscosOportunidades.Location = New System.Drawing.Point(9, 74)
        Me.txtRiscosOportunidades.MaxLength = 200
        Me.txtRiscosOportunidades.Name = "txtRiscosOportunidades"
        Me.txtRiscosOportunidades.Size = New System.Drawing.Size(720, 20)
        Me.txtRiscosOportunidades.TabIndex = 0
        '
        'lblRiscosOportunidades
        '
        Me.lblRiscosOportunidades.AutoSize = True
        Me.lblRiscosOportunidades.Location = New System.Drawing.Point(6, 57)
        Me.lblRiscosOportunidades.Name = "lblRiscosOportunidades"
        Me.lblRiscosOportunidades.Size = New System.Drawing.Size(323, 14)
        Me.lblRiscosOportunidades.TabIndex = 12
        Me.lblRiscosOportunidades.Text = "Riscos e/ou Oportunidades identificados em decorrência da SAC:"
        '
        'btnExcluirRiscosOportunidades
        '
        Me.btnExcluirRiscosOportunidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirRiscosOportunidades.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirRiscosOportunidades.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirRiscosOportunidades.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirRiscosOportunidades.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirRiscosOportunidades.Name = "btnExcluirRiscosOportunidades"
        Me.btnExcluirRiscosOportunidades.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirRiscosOportunidades.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirRiscosOportunidades.TabIndex = 2
        Me.btnExcluirRiscosOportunidades.Text = "Excluir"
        Me.btnExcluirRiscosOportunidades.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirRiscosOportunidades
        '
        Me.btnInserirRiscosOportunidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirRiscosOportunidades.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirRiscosOportunidades.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirRiscosOportunidades.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirRiscosOportunidades.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirRiscosOportunidades.Name = "btnInserirRiscosOportunidades"
        Me.btnInserirRiscosOportunidades.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirRiscosOportunidades.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirRiscosOportunidades.TabIndex = 1
        Me.btnInserirRiscosOportunidades.Text = "Inserir"
        Me.btnInserirRiscosOportunidades.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagHistorico
        '
        Me.pagHistorico.Controls.Add(Me.grpControl2)
        Me.pagHistorico.Key = "pagHistorico"
        Me.pagHistorico.Location = New System.Drawing.Point(1, 22)
        Me.pagHistorico.Name = "pagHistorico"
        Me.pagHistorico.Size = New System.Drawing.Size(895, 345)
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
        Me.grpControl2.Size = New System.Drawing.Size(874, 339)
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
        Me.grdHistorico.Size = New System.Drawing.Size(856, 284)
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
        'usrQASAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrQASAC"
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
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDescricaoSAC.ResumeLayout(False)
        CType(Me.grpDescricaoSAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDescricaoSAC.ResumeLayout(False)
        Me.grpDescricaoSAC.PerformLayout()
        Me.pagArquivos.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagReacaoNC.ResumeLayout(False)
        CType(Me.grpReacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReacao.ResumeLayout(False)
        Me.grpReacao.PerformLayout()
        CType(Me.grdReacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDadosRI.ResumeLayout(False)
        CType(Me.grpExtensao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExtensao.ResumeLayout(False)
        Me.grpExtensao.PerformLayout()
        Me.pagAnaliseCausas.ResumeLayout(False)
        CType(Me.grpAnaliseCausa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAnaliseCausa.ResumeLayout(False)
        Me.grpAnaliseCausa.PerformLayout()
        Me.pagAcoesCorretivas.ResumeLayout(False)
        CType(Me.grdAcoesCorretivas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpAcaoCorretiva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAcaoCorretiva.ResumeLayout(False)
        Me.grpAcaoCorretiva.PerformLayout()
        Me.pagResultados.ResumeLayout(False)
        CType(Me.grpResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResultados.ResumeLayout(False)
        Me.grpResultados.PerformLayout()
        Me.pagAnaliseCritica.ResumeLayout(False)
        CType(Me.grpAnaliseCritica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAnaliseCritica.ResumeLayout(False)
        Me.grpAnaliseCritica.PerformLayout()
        Me.pagRiscosOportunidades.ResumeLayout(False)
        CType(Me.grdRiscosOportunidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRiscos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRiscos.ResumeLayout(False)
        Me.grpRiscos.PerformLayout()
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
    Friend WithEvents txtNumeroSACFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagArquivos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroSAC As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnNovoSAC As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNumeroSAC As Label
    Friend WithEvents lblData As Label
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblEmissor As Label
    Friend WithEvents lblOrigem As Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As Label
    Friend WithEvents lblQtdSAC As Label
    Friend WithEvents txtQtdSAC As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblItemNC As Label
    Friend WithEvents pagDescricaoSAC As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblTipoNC As Label
    Friend WithEvents cboTipoNC As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroSACFiltro As Label
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As Label
    Friend WithEvents cboEmissor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpDescricaoSAC As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRequisitoDescricao As Label
    Friend WithEvents txtRequisitoDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtDesvioDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtEvidenciaDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblEvidenciaDescricao As Label
    Friend WithEvents lblDesvioDescricao As Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcluirSAC As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblQtdNC As Label
    Friend WithEvents txtQtdNC As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnProcurarArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As Label
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblItemFiltro As Label
    Friend WithEvents lblOrdemProducaoFiltro As Label
    Friend WithEvents txtOrdemProducaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagDadosRI As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagHistorico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdHistorico As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnInserirHistorico As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataDescricao As Label
    Friend WithEvents dtpDataDescricao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboResponsavelDescricao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblResponsavelDescricao As Label
    Friend WithEvents pagReacaoNC As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpReacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAcaoContencaoReacoes As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAcaoCorrecaoReacoes As Label
    Friend WithEvents btnExcluirReacoes As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirReacoes As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdReacoes As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblSituacaoReacao As Label
    Friend WithEvents cboSituacaoReacoes As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPrazoReacoes As Label
    Friend WithEvents dtpPrazoReacoes As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboResponsavelReacoes As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblResponsavelReacoes As Label
    Friend WithEvents grpExtensao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataExtensao As Label
    Friend WithEvents dtpDataExtensao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboResponsavelExtencao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblResponsavelExtencao As Label
    Friend WithEvents lblExtencaoNC As Label
    Friend WithEvents txtExtencaoNC As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents pagAnaliseCausas As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpAnaliseCausa As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataAnaliseCausa As Label
    Friend WithEvents dtpDataAnaliseCausa As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboResponsavelAnaliseCausa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblResponsavelAnaliseCausa As Label
    Friend WithEvents lblAnaliseCausa As Label
    Friend WithEvents txtAnaliseCausa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents pagAcoesCorretivas As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpAcaoCorretiva As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblSituacaoAcoesCorretivas As Label
    Friend WithEvents cboSituacaoAcoesCorretivas As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPrazoAcoesCorretivas As Label
    Friend WithEvents dtpPrazoAcoesCorretivas As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblResponsavelAcoesCorretivas As Label
    Friend WithEvents txtAcoesCorretivas As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAcoesCorretivas As Label
    Friend WithEvents btnExcluirAcoesCorretivas As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirAcoesCorretivas As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtResponsaveis As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagResultados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpResultados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataResultados As Label
    Friend WithEvents dtpDataResultados As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboResponsavelResultados As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblResponsavelResultados As Label
    Friend WithEvents lblResultados As Label
    Friend WithEvents txtResultados As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents pagAnaliseCritica As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpAnaliseCritica As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataAnaliseCritica As Label
    Friend WithEvents dtpDataAnaliseCritica As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboResponsavelAnaliseCritica As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblResponsavelAnaliseCritica As Label
    Friend WithEvents lblAnaliseCritica As Label
    Friend WithEvents txtAnaliseCritica As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblSatisfatoriaAnaliseCritica As Label
    Friend WithEvents cboSatisfatoriaAnaliseCritica As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagRiscosOportunidades As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpRiscos As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtRiscosOportunidades As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRiscosOportunidades As Label
    Friend WithEvents btnExcluirRiscosOportunidades As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirRiscosOportunidades As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdAcoesCorretivas As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdRiscosOportunidades As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboResponsavelRiscosOportunidades As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblResponsavelRiscosOportunidades As Label
    Friend WithEvents lblDataRiscosOportunidades As Label
    Friend WithEvents dtpDataRiscosOportunidades As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtOrigem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSituacao As Label
    Friend WithEvents cboSituacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroRNC As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRNC As Label
    Friend WithEvents btnNovoSACDados As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnUltimoRegistro As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnRegistroAnterior As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProximoRegistro As Janus.Windows.EditControls.UIButton
End Class
