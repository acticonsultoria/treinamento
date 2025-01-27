<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdOrdemProducaoTratamentoRejeito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdOrdemProducaoTratamentoRejeito))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdRoteiro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRoteiro_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdQualidade_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdQualidade_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.cboOperacaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOperacaoFiltro = New System.Windows.Forms.Label()
        Me.cboCentroTrabalhoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSequenciaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSequenciaFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCentroTrabalhoFiltro = New System.Windows.Forms.Label()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtRejeito = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRejeito = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.grpRoteiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtTempoMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTempoMaoObra = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTempoSetupMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblTempoMaquina = New System.Windows.Forms.Label()
        Me.lblTempoMaoObra = New System.Windows.Forms.Label()
        Me.lblTempoSetupMaquina = New System.Windows.Forms.Label()
        Me.cboApontamentoConcorrente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblApontamentoConcorrente = New System.Windows.Forms.Label()
        Me.lblSequenciaPredecessora = New System.Windows.Forms.Label()
        Me.cboSequenciaPredecessora = New Janus.Windows.EditControls.UIComboBox()
        Me.lblControlaQualidade = New System.Windows.Forms.Label()
        Me.cboControlaQualidade = New Janus.Windows.EditControls.UIComboBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblAponta = New System.Windows.Forms.Label()
        Me.cboAponta = New Janus.Windows.EditControls.UIComboBox()
        Me.lblApontaEquipamento = New System.Windows.Forms.Label()
        Me.cboApontaEquipamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSequencia = New System.Windows.Forms.Label()
        Me.txtSequencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.cboCentroTrabalho = New Janus.Windows.EditControls.UIComboBox()
        Me.grdRoteiro = New Janus.Windows.GridEX.GridEX()
        Me.grdQualidade = New Janus.Windows.GridEX.GridEX()
        Me.grpQualidade = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRoteiro = New System.Windows.Forms.Label()
        Me.cboRoteiro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFrequenciaQualidade = New System.Windows.Forms.Label()
        Me.txtFrequenciaQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorMaximoQualidade = New System.Windows.Forms.Label()
        Me.txtValorMaximoQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorMinimoQualidade = New System.Windows.Forms.Label()
        Me.txtValorMinimoQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorNominalQualidade = New System.Windows.Forms.Label()
        Me.txtObservacaoQualidade = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.cboCaracteristicaInspecionarQualidade = New Janus.Windows.EditControls.UIComboBox()
        Me.txtValorNominalQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblObservacaoQualidade = New System.Windows.Forms.Label()
        Me.lblCaracteristicaInspecionarQualidade = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.grpObservacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtObservacaoPerda = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.grpDadosPerda = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtRejeitoPerda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRejeitoPerda = New System.Windows.Forms.Label()
        Me.txtQuantidadePerda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadePerda = New System.Windows.Forms.Label()
        Me.txtOrdemProducaoPerda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducaoPerda = New System.Windows.Forms.Label()
        Me.txtProdutoPerda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoPerda = New System.Windows.Forms.Label()
        Me.grpControlePerda = New Janus.Windows.EditControls.UIGroupBox()
        Me.grpObservacaoReposicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtObservacaoReposicao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.grpDadosReposicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtRejeitoReposicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRejeitoReposicao = New System.Windows.Forms.Label()
        Me.txtQuantidadeReposicao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeReposicao = New System.Windows.Forms.Label()
        Me.txtOrdemProducaoReposicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducaoReposicao = New System.Windows.Forms.Label()
        Me.txtProdutoReposicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoReposicao = New System.Windows.Forms.Label()
        Me.grdControleReposicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.EditBox1 = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.pagRetrabalho = New Janus.Windows.UI.Tab.UITabPage()
        Me.pagPerda = New Janus.Windows.UI.Tab.UITabPage()
        Me.pagReposicao = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarCentroTrabalho = New System.Windows.Forms.Button()
        Me.btnCadastrarOperacao = New System.Windows.Forms.Button()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.btnAgruparGridRoteiro = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRoteiro = New System.Windows.Forms.Button()
        Me.btnAgruparGridQualidade = New System.Windows.Forms.Button()
        Me.btnConfigurarGridQualidade = New System.Windows.Forms.Button()
        Me.btnCadastrarCaracteristicaInspecionarQualidade = New System.Windows.Forms.Button()
        Me.btnExcluirQualidade = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirQualidade = New Janus.Windows.EditControls.UIButton()
        Me.btnGerarOrdemProducao = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnPerda = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarPerda = New Janus.Windows.EditControls.UIButton()
        Me.btnReposicao = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarReposicao = New Janus.Windows.EditControls.UIButton()
        Me.pagRoteiro = New Janus.Windows.UI.Tab.UITabPage()
        Me.pagQualidade = New Janus.Windows.UI.Tab.UITabPage()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        CType(Me.grpRoteiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRoteiro.SuspendLayout()
        CType(Me.grdRoteiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdQualidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpQualidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQualidade.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpObservacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpObservacao.SuspendLayout()
        CType(Me.grpDadosPerda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosPerda.SuspendLayout()
        CType(Me.grpControlePerda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlePerda.SuspendLayout()
        CType(Me.grpObservacaoReposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpObservacaoReposicao.SuspendLayout()
        CType(Me.grpDadosReposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosReposicao.SuspendLayout()
        CType(Me.grdControleReposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControleReposicao.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        Me.pagRetrabalho.SuspendLayout()
        Me.pagPerda.SuspendLayout()
        Me.pagReposicao.SuspendLayout()
        Me.pagRoteiro.SuspendLayout()
        Me.pagQualidade.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagRetrabalho, Me.pagPerda, Me.pagReposicao})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        resources.ApplyResources(Me.grpFiltro, "grpFiltro")
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.cboOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCentroTrabalhoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSequenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSequenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblCentroTrabalhoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataInicioFiltro
        '
        resources.ApplyResources(Me.dtpDataInicioFiltro, "dtpDataInicioFiltro")
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        resources.ApplyResources(Me.dtpDataTerminoFiltro, "dtpDataTerminoFiltro")
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataFiltro
        '
        resources.ApplyResources(Me.lblDataFiltro, "lblDataFiltro")
        Me.lblDataFiltro.Name = "lblDataFiltro"
        '
        'cboOperacaoFiltro
        '
        resources.ApplyResources(Me.cboOperacaoFiltro, "cboOperacaoFiltro")
        Me.cboOperacaoFiltro.Name = "cboOperacaoFiltro"
        '
        'lblOperacaoFiltro
        '
        resources.ApplyResources(Me.lblOperacaoFiltro, "lblOperacaoFiltro")
        Me.lblOperacaoFiltro.Name = "lblOperacaoFiltro"
        '
        'cboCentroTrabalhoFiltro
        '
        resources.ApplyResources(Me.cboCentroTrabalhoFiltro, "cboCentroTrabalhoFiltro")
        Me.cboCentroTrabalhoFiltro.Name = "cboCentroTrabalhoFiltro"
        '
        'lblProdutoFiltro
        '
        resources.ApplyResources(Me.lblProdutoFiltro, "lblProdutoFiltro")
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        '
        'txtProdutoFiltro
        '
        resources.ApplyResources(Me.txtProdutoFiltro, "txtProdutoFiltro")
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.MaxLength = 120
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        '
        'txtSequenciaFiltro
        '
        Me.txtSequenciaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtSequenciaFiltro, "txtSequenciaFiltro")
        Me.txtSequenciaFiltro.MaxLength = 3
        Me.txtSequenciaFiltro.Name = "txtSequenciaFiltro"
        '
        'lblSequenciaFiltro
        '
        resources.ApplyResources(Me.lblSequenciaFiltro, "lblSequenciaFiltro")
        Me.lblSequenciaFiltro.Name = "lblSequenciaFiltro"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.IncludeLiterals = False
        resources.ApplyResources(Me.txtNumeroDocumentoFiltro, "txtNumeroDocumentoFiltro")
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        '
        'lblCentroTrabalhoFiltro
        '
        resources.ApplyResources(Me.lblCentroTrabalhoFiltro, "lblCentroTrabalhoFiltro")
        Me.lblCentroTrabalhoFiltro.Name = "lblCentroTrabalhoFiltro"
        '
        'lblNumeroDocumentoFiltro
        '
        resources.ApplyResources(Me.lblNumeroDocumentoFiltro, "lblNumeroDocumentoFiltro")
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        '
        'grpControle
        '
        resources.ApplyResources(Me.grpControle, "grpControle")
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.FrozenColumns = 3
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtRejeito)
        Me.grpDados.Controls.Add(Me.lblRejeito)
        Me.grpDados.Controls.Add(Me.txtQuantidade)
        Me.grpDados.Controls.Add(Me.lblQuantidade)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtRejeito
        '
        resources.ApplyResources(Me.txtRejeito, "txtRejeito")
        Me.txtRejeito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRejeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRejeito.MaxLength = 120
        Me.txtRejeito.Name = "txtRejeito"
        Me.txtRejeito.ReadOnly = True
        Me.txtRejeito.TabStop = False
        '
        'lblRejeito
        '
        resources.ApplyResources(Me.lblRejeito, "lblRejeito")
        Me.lblRejeito.Name = "lblRejeito"
        '
        'txtQuantidade
        '
        resources.ApplyResources(Me.txtQuantidade, "txtQuantidade")
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        resources.ApplyResources(Me.lblQuantidade, "lblQuantidade")
        Me.lblQuantidade.Name = "lblQuantidade"
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtOrdemProducao, "txtOrdemProducao")
        Me.txtOrdemProducao.MaxLength = 120
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.TabStop = False
        '
        'lblOrdemProducao
        '
        resources.ApplyResources(Me.lblOrdemProducao, "lblOrdemProducao")
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        '
        'txtProduto
        '
        resources.ApplyResources(Me.txtProduto, "txtProduto")
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.MaxLength = 120
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.TabStop = False
        '
        'lblProduto
        '
        resources.ApplyResources(Me.lblProduto, "lblProduto")
        Me.lblProduto.Name = "lblProduto"
        '
        'tabDados
        '
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagRoteiro, Me.pagQualidade})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'grpRoteiro
        '
        resources.ApplyResources(Me.grpRoteiro, "grpRoteiro")
        Me.grpRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.grpRoteiro.Controls.Add(Me.txtReferencia)
        Me.grpRoteiro.Controls.Add(Me.txtTempoMaquina)
        Me.grpRoteiro.Controls.Add(Me.txtTempoMaoObra)
        Me.grpRoteiro.Controls.Add(Me.txtTempoSetupMaquina)
        Me.grpRoteiro.Controls.Add(Me.lblReferencia)
        Me.grpRoteiro.Controls.Add(Me.lblTempoMaquina)
        Me.grpRoteiro.Controls.Add(Me.lblTempoMaoObra)
        Me.grpRoteiro.Controls.Add(Me.lblTempoSetupMaquina)
        Me.grpRoteiro.Controls.Add(Me.cboApontamentoConcorrente)
        Me.grpRoteiro.Controls.Add(Me.lblApontamentoConcorrente)
        Me.grpRoteiro.Controls.Add(Me.lblSequenciaPredecessora)
        Me.grpRoteiro.Controls.Add(Me.cboSequenciaPredecessora)
        Me.grpRoteiro.Controls.Add(Me.lblControlaQualidade)
        Me.grpRoteiro.Controls.Add(Me.cboControlaQualidade)
        Me.grpRoteiro.Controls.Add(Me.txtObservacao)
        Me.grpRoteiro.Controls.Add(Me.lblAponta)
        Me.grpRoteiro.Controls.Add(Me.cboAponta)
        Me.grpRoteiro.Controls.Add(Me.lblApontaEquipamento)
        Me.grpRoteiro.Controls.Add(Me.cboApontaEquipamento)
        Me.grpRoteiro.Controls.Add(Me.lblSequencia)
        Me.grpRoteiro.Controls.Add(Me.txtSequencia)
        Me.grpRoteiro.Controls.Add(Me.lblObservacao)
        Me.grpRoteiro.Controls.Add(Me.lblOperacao)
        Me.grpRoteiro.Controls.Add(Me.cboOperacao)
        Me.grpRoteiro.Controls.Add(Me.lblCentroTrabalho)
        Me.grpRoteiro.Controls.Add(Me.cboCentroTrabalho)
        Me.grpRoteiro.Controls.Add(Me.btnCadastrarCentroTrabalho)
        Me.grpRoteiro.Controls.Add(Me.btnCadastrarOperacao)
        Me.grpRoteiro.Controls.Add(Me.btnExcluir)
        Me.grpRoteiro.Controls.Add(Me.btnInserir)
        Me.grpRoteiro.Name = "grpRoteiro"
        Me.grpRoteiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpRoteiro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpRoteiro.VisualStyleManager = Me.vsmMain
        '
        'txtReferencia
        '
        Me.txtReferencia.DecimalDigits = 0
        resources.ApplyResources(Me.txtReferencia, "txtReferencia")
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtReferencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTempoMaquina
        '
        resources.ApplyResources(Me.txtTempoMaquina, "txtTempoMaquina")
        Me.txtTempoMaquina.Mask = "00:00:00"
        Me.txtTempoMaquina.Name = "txtTempoMaquina"
        Me.txtTempoMaquina.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtTempoMaoObra
        '
        resources.ApplyResources(Me.txtTempoMaoObra, "txtTempoMaoObra")
        Me.txtTempoMaoObra.Mask = "00:00:00"
        Me.txtTempoMaoObra.Name = "txtTempoMaoObra"
        Me.txtTempoMaoObra.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtTempoSetupMaquina
        '
        resources.ApplyResources(Me.txtTempoSetupMaquina, "txtTempoSetupMaquina")
        Me.txtTempoSetupMaquina.Mask = "00:00:00"
        Me.txtTempoSetupMaquina.Name = "txtTempoSetupMaquina"
        Me.txtTempoSetupMaquina.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblReferencia
        '
        resources.ApplyResources(Me.lblReferencia, "lblReferencia")
        Me.lblReferencia.Name = "lblReferencia"
        '
        'lblTempoMaquina
        '
        resources.ApplyResources(Me.lblTempoMaquina, "lblTempoMaquina")
        Me.lblTempoMaquina.Name = "lblTempoMaquina"
        '
        'lblTempoMaoObra
        '
        resources.ApplyResources(Me.lblTempoMaoObra, "lblTempoMaoObra")
        Me.lblTempoMaoObra.Name = "lblTempoMaoObra"
        '
        'lblTempoSetupMaquina
        '
        resources.ApplyResources(Me.lblTempoSetupMaquina, "lblTempoSetupMaquina")
        Me.lblTempoSetupMaquina.Name = "lblTempoSetupMaquina"
        '
        'cboApontamentoConcorrente
        '
        resources.ApplyResources(Me.cboApontamentoConcorrente, "cboApontamentoConcorrente")
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem1, "UiComboBoxItem1")
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem2, "UiComboBoxItem2")
        Me.cboApontamentoConcorrente.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboApontamentoConcorrente.Name = "cboApontamentoConcorrente"
        Me.cboApontamentoConcorrente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblApontamentoConcorrente
        '
        resources.ApplyResources(Me.lblApontamentoConcorrente, "lblApontamentoConcorrente")
        Me.lblApontamentoConcorrente.Name = "lblApontamentoConcorrente"
        '
        'lblSequenciaPredecessora
        '
        resources.ApplyResources(Me.lblSequenciaPredecessora, "lblSequenciaPredecessora")
        Me.lblSequenciaPredecessora.Name = "lblSequenciaPredecessora"
        '
        'cboSequenciaPredecessora
        '
        resources.ApplyResources(Me.cboSequenciaPredecessora, "cboSequenciaPredecessora")
        Me.cboSequenciaPredecessora.Name = "cboSequenciaPredecessora"
        '
        'lblControlaQualidade
        '
        resources.ApplyResources(Me.lblControlaQualidade, "lblControlaQualidade")
        Me.lblControlaQualidade.Name = "lblControlaQualidade"
        '
        'cboControlaQualidade
        '
        resources.ApplyResources(Me.cboControlaQualidade, "cboControlaQualidade")
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem3, "UiComboBoxItem3")
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem4, "UiComboBoxItem4")
        Me.cboControlaQualidade.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboControlaQualidade.Name = "cboControlaQualidade"
        Me.cboControlaQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtObservacao
        '
        resources.ApplyResources(Me.txtObservacao, "txtObservacao")
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'lblAponta
        '
        resources.ApplyResources(Me.lblAponta, "lblAponta")
        Me.lblAponta.Name = "lblAponta"
        '
        'cboAponta
        '
        resources.ApplyResources(Me.cboAponta, "cboAponta")
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem5, "UiComboBoxItem5")
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem6, "UiComboBoxItem6")
        Me.cboAponta.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboAponta.Name = "cboAponta"
        Me.cboAponta.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblApontaEquipamento
        '
        resources.ApplyResources(Me.lblApontaEquipamento, "lblApontaEquipamento")
        Me.lblApontaEquipamento.Name = "lblApontaEquipamento"
        '
        'cboApontaEquipamento
        '
        resources.ApplyResources(Me.cboApontaEquipamento, "cboApontaEquipamento")
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem7, "UiComboBoxItem7")
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem8, "UiComboBoxItem8")
        Me.cboApontaEquipamento.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboApontaEquipamento.Name = "cboApontaEquipamento"
        Me.cboApontaEquipamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblSequencia
        '
        resources.ApplyResources(Me.lblSequencia, "lblSequencia")
        Me.lblSequencia.Name = "lblSequencia"
        '
        'txtSequencia
        '
        Me.txtSequencia.DecimalDigits = 0
        resources.ApplyResources(Me.txtSequencia, "txtSequencia")
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtSequencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblObservacao
        '
        resources.ApplyResources(Me.lblObservacao, "lblObservacao")
        Me.lblObservacao.Name = "lblObservacao"
        '
        'lblOperacao
        '
        resources.ApplyResources(Me.lblOperacao, "lblOperacao")
        Me.lblOperacao.Name = "lblOperacao"
        '
        'cboOperacao
        '
        resources.ApplyResources(Me.cboOperacao, "cboOperacao")
        Me.cboOperacao.Name = "cboOperacao"
        '
        'lblCentroTrabalho
        '
        resources.ApplyResources(Me.lblCentroTrabalho, "lblCentroTrabalho")
        Me.lblCentroTrabalho.Name = "lblCentroTrabalho"
        '
        'cboCentroTrabalho
        '
        resources.ApplyResources(Me.cboCentroTrabalho, "cboCentroTrabalho")
        Me.cboCentroTrabalho.Name = "cboCentroTrabalho"
        '
        'grdRoteiro
        '
        Me.grdRoteiro.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdRoteiro.AlternatingColors = True
        resources.ApplyResources(Me.grdRoteiro, "grdRoteiro")
        grdRoteiro_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRoteiro_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRoteiro_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRoteiro_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdRoteiro_DesignTimeLayout, "grdRoteiro_DesignTimeLayout")
        Me.grdRoteiro.DesignTimeLayout = grdRoteiro_DesignTimeLayout
        Me.grdRoteiro.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRoteiro.FrozenColumns = 2
        Me.grdRoteiro.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRoteiro.GroupByBoxVisible = False
        Me.grdRoteiro.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRoteiro.Name = "grdRoteiro"
        Me.grdRoteiro.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRoteiro.RecordNavigator = True
        Me.grdRoteiro.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRoteiro.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRoteiro.TabStop = False
        Me.grdRoteiro.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRoteiro.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRoteiro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRoteiro.VisualStyleManager = Me.vsmMain
        '
        'grdQualidade
        '
        Me.grdQualidade.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdQualidade.AlternatingColors = True
        resources.ApplyResources(Me.grdQualidade, "grdQualidade")
        Me.grdQualidade.ColumnAutoResize = True
        grdQualidade_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdQualidade_DesignTimeLayout_Reference_0.Instance"), Object)
        grdQualidade_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdQualidade_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdQualidade_DesignTimeLayout, "grdQualidade_DesignTimeLayout")
        Me.grdQualidade.DesignTimeLayout = grdQualidade_DesignTimeLayout
        Me.grdQualidade.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdQualidade.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdQualidade.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdQualidade.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdQualidade.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdQualidade.GroupByBoxVisible = False
        Me.grdQualidade.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdQualidade.Name = "grdQualidade"
        Me.grdQualidade.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdQualidade.RecordNavigator = True
        Me.grdQualidade.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdQualidade.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdQualidade.TabStop = False
        Me.grdQualidade.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdQualidade.VisualStyleManager = Me.vsmMain
        '
        'grpQualidade
        '
        resources.ApplyResources(Me.grpQualidade, "grpQualidade")
        Me.grpQualidade.BackColor = System.Drawing.Color.Transparent
        Me.grpQualidade.Controls.Add(Me.lblRoteiro)
        Me.grpQualidade.Controls.Add(Me.cboRoteiro)
        Me.grpQualidade.Controls.Add(Me.lblFrequenciaQualidade)
        Me.grpQualidade.Controls.Add(Me.txtFrequenciaQualidade)
        Me.grpQualidade.Controls.Add(Me.lblValorMaximoQualidade)
        Me.grpQualidade.Controls.Add(Me.txtValorMaximoQualidade)
        Me.grpQualidade.Controls.Add(Me.lblValorMinimoQualidade)
        Me.grpQualidade.Controls.Add(Me.txtValorMinimoQualidade)
        Me.grpQualidade.Controls.Add(Me.lblValorNominalQualidade)
        Me.grpQualidade.Controls.Add(Me.txtObservacaoQualidade)
        Me.grpQualidade.Controls.Add(Me.cboCaracteristicaInspecionarQualidade)
        Me.grpQualidade.Controls.Add(Me.txtValorNominalQualidade)
        Me.grpQualidade.Controls.Add(Me.lblObservacaoQualidade)
        Me.grpQualidade.Controls.Add(Me.lblCaracteristicaInspecionarQualidade)
        Me.grpQualidade.Controls.Add(Me.btnCadastrarCaracteristicaInspecionarQualidade)
        Me.grpQualidade.Controls.Add(Me.btnExcluirQualidade)
        Me.grpQualidade.Controls.Add(Me.btnInserirQualidade)
        Me.grpQualidade.Name = "grpQualidade"
        Me.grpQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpQualidade.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpQualidade.VisualStyleManager = Me.vsmMain
        '
        'lblRoteiro
        '
        resources.ApplyResources(Me.lblRoteiro, "lblRoteiro")
        Me.lblRoteiro.Name = "lblRoteiro"
        '
        'cboRoteiro
        '
        resources.ApplyResources(Me.cboRoteiro, "cboRoteiro")
        Me.cboRoteiro.Name = "cboRoteiro"
        '
        'lblFrequenciaQualidade
        '
        resources.ApplyResources(Me.lblFrequenciaQualidade, "lblFrequenciaQualidade")
        Me.lblFrequenciaQualidade.Name = "lblFrequenciaQualidade"
        '
        'txtFrequenciaQualidade
        '
        Me.txtFrequenciaQualidade.DecimalDigits = 0
        resources.ApplyResources(Me.txtFrequenciaQualidade, "txtFrequenciaQualidade")
        Me.txtFrequenciaQualidade.Name = "txtFrequenciaQualidade"
        Me.txtFrequenciaQualidade.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblValorMaximoQualidade
        '
        resources.ApplyResources(Me.lblValorMaximoQualidade, "lblValorMaximoQualidade")
        Me.lblValorMaximoQualidade.Name = "lblValorMaximoQualidade"
        '
        'txtValorMaximoQualidade
        '
        Me.txtValorMaximoQualidade.DecimalDigits = 4
        resources.ApplyResources(Me.txtValorMaximoQualidade, "txtValorMaximoQualidade")
        Me.txtValorMaximoQualidade.Name = "txtValorMaximoQualidade"
        Me.txtValorMaximoQualidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorMinimoQualidade
        '
        resources.ApplyResources(Me.lblValorMinimoQualidade, "lblValorMinimoQualidade")
        Me.lblValorMinimoQualidade.Name = "lblValorMinimoQualidade"
        '
        'txtValorMinimoQualidade
        '
        Me.txtValorMinimoQualidade.DecimalDigits = 4
        resources.ApplyResources(Me.txtValorMinimoQualidade, "txtValorMinimoQualidade")
        Me.txtValorMinimoQualidade.Name = "txtValorMinimoQualidade"
        Me.txtValorMinimoQualidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorNominalQualidade
        '
        resources.ApplyResources(Me.lblValorNominalQualidade, "lblValorNominalQualidade")
        Me.lblValorNominalQualidade.Name = "lblValorNominalQualidade"
        '
        'txtObservacaoQualidade
        '
        resources.ApplyResources(Me.txtObservacaoQualidade, "txtObservacaoQualidade")
        Me.txtObservacaoQualidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoQualidade.MaxLength = 1000
        Me.txtObservacaoQualidade.Multiline = True
        Me.txtObservacaoQualidade.Name = "txtObservacaoQualidade"
        Me.txtObservacaoQualidade.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'cboCaracteristicaInspecionarQualidade
        '
        resources.ApplyResources(Me.cboCaracteristicaInspecionarQualidade, "cboCaracteristicaInspecionarQualidade")
        Me.cboCaracteristicaInspecionarQualidade.Name = "cboCaracteristicaInspecionarQualidade"
        '
        'txtValorNominalQualidade
        '
        Me.txtValorNominalQualidade.DecimalDigits = 4
        resources.ApplyResources(Me.txtValorNominalQualidade, "txtValorNominalQualidade")
        Me.txtValorNominalQualidade.Name = "txtValorNominalQualidade"
        Me.txtValorNominalQualidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblObservacaoQualidade
        '
        resources.ApplyResources(Me.lblObservacaoQualidade, "lblObservacaoQualidade")
        Me.lblObservacaoQualidade.Name = "lblObservacaoQualidade"
        '
        'lblCaracteristicaInspecionarQualidade
        '
        resources.ApplyResources(Me.lblCaracteristicaInspecionarQualidade, "lblCaracteristicaInspecionarQualidade")
        Me.lblCaracteristicaInspecionarQualidade.Name = "lblCaracteristicaInspecionarQualidade"
        '
        'grpControl2
        '
        resources.ApplyResources(Me.grpControl2, "grpControl2")
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnGerarOrdemProducao)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'grpObservacao
        '
        resources.ApplyResources(Me.grpObservacao, "grpObservacao")
        Me.grpObservacao.BackColor = System.Drawing.Color.Transparent
        Me.grpObservacao.Controls.Add(Me.txtObservacaoPerda)
        Me.grpObservacao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpObservacao.Name = "grpObservacao"
        Me.grpObservacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpObservacao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpObservacao.VisualStyleManager = Me.vsmMain
        '
        'txtObservacaoPerda
        '
        resources.ApplyResources(Me.txtObservacaoPerda, "txtObservacaoPerda")
        Me.txtObservacaoPerda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoPerda.MaxLength = 1000
        Me.txtObservacaoPerda.Multiline = True
        Me.txtObservacaoPerda.Name = "txtObservacaoPerda"
        Me.txtObservacaoPerda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'grpDadosPerda
        '
        resources.ApplyResources(Me.grpDadosPerda, "grpDadosPerda")
        Me.grpDadosPerda.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosPerda.Controls.Add(Me.txtRejeitoPerda)
        Me.grpDadosPerda.Controls.Add(Me.lblRejeitoPerda)
        Me.grpDadosPerda.Controls.Add(Me.txtQuantidadePerda)
        Me.grpDadosPerda.Controls.Add(Me.lblQuantidadePerda)
        Me.grpDadosPerda.Controls.Add(Me.txtOrdemProducaoPerda)
        Me.grpDadosPerda.Controls.Add(Me.lblOrdemProducaoPerda)
        Me.grpDadosPerda.Controls.Add(Me.txtProdutoPerda)
        Me.grpDadosPerda.Controls.Add(Me.lblProdutoPerda)
        Me.grpDadosPerda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosPerda.Name = "grpDadosPerda"
        Me.grpDadosPerda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosPerda.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosPerda.VisualStyleManager = Me.vsmMain
        '
        'txtRejeitoPerda
        '
        resources.ApplyResources(Me.txtRejeitoPerda, "txtRejeitoPerda")
        Me.txtRejeitoPerda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRejeitoPerda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRejeitoPerda.MaxLength = 120
        Me.txtRejeitoPerda.Name = "txtRejeitoPerda"
        Me.txtRejeitoPerda.ReadOnly = True
        Me.txtRejeitoPerda.TabStop = False
        '
        'lblRejeitoPerda
        '
        resources.ApplyResources(Me.lblRejeitoPerda, "lblRejeitoPerda")
        Me.lblRejeitoPerda.Name = "lblRejeitoPerda"
        '
        'txtQuantidadePerda
        '
        resources.ApplyResources(Me.txtQuantidadePerda, "txtQuantidadePerda")
        Me.txtQuantidadePerda.DecimalDigits = 4
        Me.txtQuantidadePerda.Name = "txtQuantidadePerda"
        Me.txtQuantidadePerda.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadePerda
        '
        resources.ApplyResources(Me.lblQuantidadePerda, "lblQuantidadePerda")
        Me.lblQuantidadePerda.Name = "lblQuantidadePerda"
        '
        'txtOrdemProducaoPerda
        '
        Me.txtOrdemProducaoPerda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducaoPerda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtOrdemProducaoPerda, "txtOrdemProducaoPerda")
        Me.txtOrdemProducaoPerda.MaxLength = 120
        Me.txtOrdemProducaoPerda.Name = "txtOrdemProducaoPerda"
        Me.txtOrdemProducaoPerda.ReadOnly = True
        Me.txtOrdemProducaoPerda.TabStop = False
        '
        'lblOrdemProducaoPerda
        '
        resources.ApplyResources(Me.lblOrdemProducaoPerda, "lblOrdemProducaoPerda")
        Me.lblOrdemProducaoPerda.Name = "lblOrdemProducaoPerda"
        '
        'txtProdutoPerda
        '
        resources.ApplyResources(Me.txtProdutoPerda, "txtProdutoPerda")
        Me.txtProdutoPerda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProdutoPerda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoPerda.MaxLength = 120
        Me.txtProdutoPerda.Name = "txtProdutoPerda"
        Me.txtProdutoPerda.ReadOnly = True
        Me.txtProdutoPerda.TabStop = False
        '
        'lblProdutoPerda
        '
        resources.ApplyResources(Me.lblProdutoPerda, "lblProdutoPerda")
        Me.lblProdutoPerda.Name = "lblProdutoPerda"
        '
        'grpControlePerda
        '
        resources.ApplyResources(Me.grpControlePerda, "grpControlePerda")
        Me.grpControlePerda.BackColor = System.Drawing.Color.Transparent
        Me.grpControlePerda.Controls.Add(Me.btnPerda)
        Me.grpControlePerda.Controls.Add(Me.btnVoltarPerda)
        Me.grpControlePerda.Name = "grpControlePerda"
        Me.grpControlePerda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlePerda.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControlePerda.VisualStyleManager = Me.vsmMain
        '
        'grpObservacaoReposicao
        '
        resources.ApplyResources(Me.grpObservacaoReposicao, "grpObservacaoReposicao")
        Me.grpObservacaoReposicao.BackColor = System.Drawing.Color.Transparent
        Me.grpObservacaoReposicao.Controls.Add(Me.txtObservacaoReposicao)
        Me.grpObservacaoReposicao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpObservacaoReposicao.Name = "grpObservacaoReposicao"
        Me.grpObservacaoReposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpObservacaoReposicao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpObservacaoReposicao.VisualStyleManager = Me.vsmMain
        '
        'txtObservacaoReposicao
        '
        resources.ApplyResources(Me.txtObservacaoReposicao, "txtObservacaoReposicao")
        Me.txtObservacaoReposicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoReposicao.MaxLength = 1000
        Me.txtObservacaoReposicao.Multiline = True
        Me.txtObservacaoReposicao.Name = "txtObservacaoReposicao"
        Me.txtObservacaoReposicao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'grpDadosReposicao
        '
        resources.ApplyResources(Me.grpDadosReposicao, "grpDadosReposicao")
        Me.grpDadosReposicao.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosReposicao.Controls.Add(Me.txtRejeitoReposicao)
        Me.grpDadosReposicao.Controls.Add(Me.lblRejeitoReposicao)
        Me.grpDadosReposicao.Controls.Add(Me.txtQuantidadeReposicao)
        Me.grpDadosReposicao.Controls.Add(Me.lblQuantidadeReposicao)
        Me.grpDadosReposicao.Controls.Add(Me.txtOrdemProducaoReposicao)
        Me.grpDadosReposicao.Controls.Add(Me.lblOrdemProducaoReposicao)
        Me.grpDadosReposicao.Controls.Add(Me.txtProdutoReposicao)
        Me.grpDadosReposicao.Controls.Add(Me.lblProdutoReposicao)
        Me.grpDadosReposicao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosReposicao.Name = "grpDadosReposicao"
        Me.grpDadosReposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosReposicao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosReposicao.VisualStyleManager = Me.vsmMain
        '
        'txtRejeitoReposicao
        '
        resources.ApplyResources(Me.txtRejeitoReposicao, "txtRejeitoReposicao")
        Me.txtRejeitoReposicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRejeitoReposicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRejeitoReposicao.MaxLength = 120
        Me.txtRejeitoReposicao.Name = "txtRejeitoReposicao"
        Me.txtRejeitoReposicao.ReadOnly = True
        Me.txtRejeitoReposicao.TabStop = False
        '
        'lblRejeitoReposicao
        '
        resources.ApplyResources(Me.lblRejeitoReposicao, "lblRejeitoReposicao")
        Me.lblRejeitoReposicao.Name = "lblRejeitoReposicao"
        '
        'txtQuantidadeReposicao
        '
        resources.ApplyResources(Me.txtQuantidadeReposicao, "txtQuantidadeReposicao")
        Me.txtQuantidadeReposicao.DecimalDigits = 4
        Me.txtQuantidadeReposicao.Name = "txtQuantidadeReposicao"
        Me.txtQuantidadeReposicao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeReposicao
        '
        resources.ApplyResources(Me.lblQuantidadeReposicao, "lblQuantidadeReposicao")
        Me.lblQuantidadeReposicao.Name = "lblQuantidadeReposicao"
        '
        'txtOrdemProducaoReposicao
        '
        Me.txtOrdemProducaoReposicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducaoReposicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtOrdemProducaoReposicao, "txtOrdemProducaoReposicao")
        Me.txtOrdemProducaoReposicao.MaxLength = 120
        Me.txtOrdemProducaoReposicao.Name = "txtOrdemProducaoReposicao"
        Me.txtOrdemProducaoReposicao.ReadOnly = True
        Me.txtOrdemProducaoReposicao.TabStop = False
        '
        'lblOrdemProducaoReposicao
        '
        resources.ApplyResources(Me.lblOrdemProducaoReposicao, "lblOrdemProducaoReposicao")
        Me.lblOrdemProducaoReposicao.Name = "lblOrdemProducaoReposicao"
        '
        'txtProdutoReposicao
        '
        resources.ApplyResources(Me.txtProdutoReposicao, "txtProdutoReposicao")
        Me.txtProdutoReposicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProdutoReposicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoReposicao.MaxLength = 120
        Me.txtProdutoReposicao.Name = "txtProdutoReposicao"
        Me.txtProdutoReposicao.ReadOnly = True
        Me.txtProdutoReposicao.TabStop = False
        '
        'lblProdutoReposicao
        '
        resources.ApplyResources(Me.lblProdutoReposicao, "lblProdutoReposicao")
        Me.lblProdutoReposicao.Name = "lblProdutoReposicao"
        '
        'grdControleReposicao
        '
        resources.ApplyResources(Me.grdControleReposicao, "grdControleReposicao")
        Me.grdControleReposicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControleReposicao.Controls.Add(Me.btnReposicao)
        Me.grdControleReposicao.Controls.Add(Me.btnVoltarReposicao)
        Me.grdControleReposicao.Name = "grdControleReposicao"
        Me.grdControleReposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControleReposicao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grdControleReposicao.VisualStyleManager = Me.vsmMain
        '
        'EditBox1
        '
        resources.ApplyResources(Me.EditBox1, "EditBox1")
        Me.EditBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EditBox1.MaxLength = 1000
        Me.EditBox1.Multiline = True
        Me.EditBox1.Name = "EditBox1"
        Me.EditBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Key = "pagListagem"
        resources.ApplyResources(Me.pagListagem, "pagListagem")
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.TabStop = True
        '
        'btnAgruparGrid
        '
        resources.ApplyResources(Me.btnAgruparGrid, "btnAgruparGrid")
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        resources.ApplyResources(Me.btnConfigurarGrid, "btnConfigurarGrid")
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'pagRetrabalho
        '
        Me.pagRetrabalho.Controls.Add(Me.grpDados)
        Me.pagRetrabalho.Controls.Add(Me.tabDados)
        Me.pagRetrabalho.Controls.Add(Me.grpControl2)
        Me.pagRetrabalho.Key = "pagRetrabalho"
        resources.ApplyResources(Me.pagRetrabalho, "pagRetrabalho")
        Me.pagRetrabalho.Name = "pagRetrabalho"
        Me.pagRetrabalho.TabStop = True
        '
        'pagPerda
        '
        Me.pagPerda.Controls.Add(Me.grpObservacao)
        Me.pagPerda.Controls.Add(Me.grpDadosPerda)
        Me.pagPerda.Controls.Add(Me.grpControlePerda)
        Me.pagPerda.Key = "pagPerda"
        resources.ApplyResources(Me.pagPerda, "pagPerda")
        Me.pagPerda.Name = "pagPerda"
        Me.pagPerda.TabStop = True
        '
        'pagReposicao
        '
        Me.pagReposicao.Controls.Add(Me.grpObservacaoReposicao)
        Me.pagReposicao.Controls.Add(Me.grpDadosReposicao)
        Me.pagReposicao.Controls.Add(Me.grdControleReposicao)
        Me.pagReposicao.Key = "pagReposicao"
        resources.ApplyResources(Me.pagReposicao, "pagReposicao")
        Me.pagReposicao.Name = "pagReposicao"
        Me.pagReposicao.TabStop = True
        '
        'btnFiltrar
        '
        resources.ApplyResources(Me.btnFiltrar, "btnFiltrar")
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcel
        '
        resources.ApplyResources(Me.btnExcel, "btnExcel")
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.Name = "btnSair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarCentroTrabalho
        '
        Me.btnCadastrarCentroTrabalho.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarCentroTrabalho, "btnCadastrarCentroTrabalho")
        Me.btnCadastrarCentroTrabalho.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarCentroTrabalho.Name = "btnCadastrarCentroTrabalho"
        Me.btnCadastrarCentroTrabalho.TabStop = False
        Me.btnCadastrarCentroTrabalho.UseVisualStyleBackColor = True
        '
        'btnCadastrarOperacao
        '
        Me.btnCadastrarOperacao.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarOperacao, "btnCadastrarOperacao")
        Me.btnCadastrarOperacao.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarOperacao.Name = "btnCadastrarOperacao"
        Me.btnCadastrarOperacao.TabStop = False
        Me.btnCadastrarOperacao.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        resources.ApplyResources(Me.btnExcluir, "btnExcluir")
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        resources.ApplyResources(Me.btnInserir, "btnInserir")
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAgruparGridRoteiro
        '
        resources.ApplyResources(Me.btnAgruparGridRoteiro, "btnAgruparGridRoteiro")
        Me.btnAgruparGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridRoteiro.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridRoteiro.Name = "btnAgruparGridRoteiro"
        Me.btnAgruparGridRoteiro.TabStop = False
        Me.btnAgruparGridRoteiro.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridRoteiro
        '
        resources.ApplyResources(Me.btnConfigurarGridRoteiro, "btnConfigurarGridRoteiro")
        Me.btnConfigurarGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridRoteiro.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridRoteiro.Name = "btnConfigurarGridRoteiro"
        Me.btnConfigurarGridRoteiro.TabStop = False
        Me.btnConfigurarGridRoteiro.UseVisualStyleBackColor = False
        '
        'btnAgruparGridQualidade
        '
        resources.ApplyResources(Me.btnAgruparGridQualidade, "btnAgruparGridQualidade")
        Me.btnAgruparGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridQualidade.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridQualidade.Name = "btnAgruparGridQualidade"
        Me.btnAgruparGridQualidade.TabStop = False
        Me.btnAgruparGridQualidade.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridQualidade
        '
        resources.ApplyResources(Me.btnConfigurarGridQualidade, "btnConfigurarGridQualidade")
        Me.btnConfigurarGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridQualidade.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridQualidade.Name = "btnConfigurarGridQualidade"
        Me.btnConfigurarGridQualidade.TabStop = False
        Me.btnConfigurarGridQualidade.UseVisualStyleBackColor = False
        '
        'btnCadastrarCaracteristicaInspecionarQualidade
        '
        Me.btnCadastrarCaracteristicaInspecionarQualidade.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarCaracteristicaInspecionarQualidade, "btnCadastrarCaracteristicaInspecionarQualidade")
        Me.btnCadastrarCaracteristicaInspecionarQualidade.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarCaracteristicaInspecionarQualidade.Name = "btnCadastrarCaracteristicaInspecionarQualidade"
        Me.btnCadastrarCaracteristicaInspecionarQualidade.TabStop = False
        Me.btnCadastrarCaracteristicaInspecionarQualidade.UseVisualStyleBackColor = True
        '
        'btnExcluirQualidade
        '
        resources.ApplyResources(Me.btnExcluirQualidade, "btnExcluirQualidade")
        Me.btnExcluirQualidade.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirQualidade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirQualidade.Name = "btnExcluirQualidade"
        Me.btnExcluirQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirQualidade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirQualidade
        '
        resources.ApplyResources(Me.btnInserirQualidade, "btnInserirQualidade")
        Me.btnInserirQualidade.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirQualidade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirQualidade.Name = "btnInserirQualidade"
        Me.btnInserirQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirQualidade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnGerarOrdemProducao
        '
        resources.ApplyResources(Me.btnGerarOrdemProducao, "btnGerarOrdemProducao")
        Me.btnGerarOrdemProducao.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnGerarOrdemProducao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarOrdemProducao.Name = "btnGerarOrdemProducao"
        Me.btnGerarOrdemProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarOrdemProducao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        resources.ApplyResources(Me.btnVoltar, "btnVoltar")
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPerda
        '
        resources.ApplyResources(Me.btnPerda, "btnPerda")
        Me.btnPerda.Image = Global.INTERACTI.My.Resources.cancelar
        Me.btnPerda.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPerda.Name = "btnPerda"
        Me.btnPerda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPerda.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarPerda
        '
        resources.ApplyResources(Me.btnVoltarPerda, "btnVoltarPerda")
        Me.btnVoltarPerda.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltarPerda.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarPerda.Name = "btnVoltarPerda"
        Me.btnVoltarPerda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarPerda.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnReposicao
        '
        resources.ApplyResources(Me.btnReposicao, "btnReposicao")
        Me.btnReposicao.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnReposicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnReposicao.Name = "btnReposicao"
        Me.btnReposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnReposicao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarReposicao
        '
        resources.ApplyResources(Me.btnVoltarReposicao, "btnVoltarReposicao")
        Me.btnVoltarReposicao.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltarReposicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarReposicao.Name = "btnVoltarReposicao"
        Me.btnVoltarReposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarReposicao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagRoteiro
        '
        Me.pagRoteiro.Controls.Add(Me.grpRoteiro)
        Me.pagRoteiro.Controls.Add(Me.btnAgruparGridRoteiro)
        Me.pagRoteiro.Controls.Add(Me.btnConfigurarGridRoteiro)
        Me.pagRoteiro.Controls.Add(Me.grdRoteiro)
        Me.pagRoteiro.Key = "pagRoteiro"
        resources.ApplyResources(Me.pagRoteiro, "pagRoteiro")
        Me.pagRoteiro.Name = "pagRoteiro"
        Me.pagRoteiro.TabStop = True
        '
        'pagQualidade
        '
        Me.pagQualidade.Controls.Add(Me.btnAgruparGridQualidade)
        Me.pagQualidade.Controls.Add(Me.btnConfigurarGridQualidade)
        Me.pagQualidade.Controls.Add(Me.grdQualidade)
        Me.pagQualidade.Controls.Add(Me.grpQualidade)
        Me.pagQualidade.Key = "pagQualidade"
        resources.ApplyResources(Me.pagQualidade, "pagQualidade")
        Me.pagQualidade.Name = "pagQualidade"
        Me.pagQualidade.TabStop = True
        '
        'usrPrdOrdemProducaoTratamentoRejeito
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrPrdOrdemProducaoTratamentoRejeito"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        CType(Me.grpRoteiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRoteiro.ResumeLayout(False)
        Me.grpRoteiro.PerformLayout()
        CType(Me.grdRoteiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdQualidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpQualidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQualidade.ResumeLayout(False)
        Me.grpQualidade.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpObservacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpObservacao.ResumeLayout(False)
        Me.grpObservacao.PerformLayout()
        CType(Me.grpDadosPerda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosPerda.ResumeLayout(False)
        Me.grpDadosPerda.PerformLayout()
        CType(Me.grpControlePerda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlePerda.ResumeLayout(False)
        CType(Me.grpObservacaoReposicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpObservacaoReposicao.ResumeLayout(False)
        Me.grpObservacaoReposicao.PerformLayout()
        CType(Me.grpDadosReposicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosReposicao.ResumeLayout(False)
        Me.grpDadosReposicao.PerformLayout()
        CType(Me.grdControleReposicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControleReposicao.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        Me.pagRetrabalho.ResumeLayout(False)
        Me.pagPerda.ResumeLayout(False)
        Me.pagReposicao.ResumeLayout(False)
        Me.pagRoteiro.ResumeLayout(False)
        Me.pagQualidade.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagRetrabalho As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents grdRoteiro As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpRoteiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblControlaQualidade As System.Windows.Forms.Label
    Friend WithEvents cboControlaQualidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblAponta As System.Windows.Forms.Label
    Friend WithEvents cboAponta As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblApontaEquipamento As System.Windows.Forms.Label
    Friend WithEvents cboApontaEquipamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSequencia As System.Windows.Forms.Label
    Friend WithEvents txtSequencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroTrabalho As System.Windows.Forms.Label
    Friend WithEvents cboCentroTrabalho As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarCentroTrabalho As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarOperacao As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgruparGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagRoteiro As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagQualidade As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridQualidade As System.Windows.Forms.Button
    Friend WithEvents grdQualidade As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpQualidade As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFrequenciaQualidade As System.Windows.Forms.Label
    Friend WithEvents txtFrequenciaQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorMaximoQualidade As System.Windows.Forms.Label
    Friend WithEvents txtValorMaximoQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorMinimoQualidade As System.Windows.Forms.Label
    Friend WithEvents txtValorMinimoQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorNominalQualidade As System.Windows.Forms.Label
    Friend WithEvents txtObservacaoQualidade As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents cboCaracteristicaInspecionarQualidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorNominalQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblObservacaoQualidade As System.Windows.Forms.Label
    Friend WithEvents lblCaracteristicaInspecionarQualidade As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarCaracteristicaInspecionarQualidade As System.Windows.Forms.Button
    Friend WithEvents btnExcluirQualidade As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirQualidade As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblRoteiro As System.Windows.Forms.Label
    Friend WithEvents cboRoteiro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGridQualidade As System.Windows.Forms.Button
    Friend WithEvents lblSequenciaPredecessora As System.Windows.Forms.Label
    Friend WithEvents cboSequenciaPredecessora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents cboOperacaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOperacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCentroTrabalhoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSequenciaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSequenciaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCentroTrabalhoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnGerarOrdemProducao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtRejeito As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRejeito As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents lblApontamentoConcorrente As System.Windows.Forms.Label
    Friend WithEvents pagPerda As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpObservacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtObservacaoPerda As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grpDadosPerda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtRejeitoPerda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRejeitoPerda As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadePerda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadePerda As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducaoPerda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducaoPerda As System.Windows.Forms.Label
    Friend WithEvents txtProdutoPerda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoPerda As System.Windows.Forms.Label
    Friend WithEvents grpControlePerda As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnPerda As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltarPerda As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagReposicao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosReposicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtRejeitoReposicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRejeitoReposicao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeReposicao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeReposicao As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducaoReposicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducaoReposicao As System.Windows.Forms.Label
    Friend WithEvents txtProdutoReposicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoReposicao As System.Windows.Forms.Label
    Friend WithEvents EditBox1 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grdControleReposicao As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnReposicao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltarReposicao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpObservacaoReposicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtObservacaoReposicao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents cboApontamentoConcorrente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtTempoMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTempoMaoObra As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTempoSetupMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents lblTempoMaquina As System.Windows.Forms.Label
    Friend WithEvents lblTempoMaoObra As System.Windows.Forms.Label
    Friend WithEvents lblTempoSetupMaquina As System.Windows.Forms.Label

End Class
