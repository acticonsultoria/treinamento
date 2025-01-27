<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadProdutoRoteiroProducao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadProdutoRoteiroProducao))
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings4 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
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
        Dim grdBOM_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagRevisao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpNovo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricaoImportar = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoImportar = New System.Windows.Forms.Label()
        Me.cboModeloRoteiroImportar = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModeloRoteiroImportar = New System.Windows.Forms.Label()
        Me.cboRevisaoImportar = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRevisaoImportar = New System.Windows.Forms.Label()
        Me.btnProcurarProdutoImportar = New System.Windows.Forms.Button()
        Me.cboProdutoImportar = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProdutoImportar = New System.Windows.Forms.Label()
        Me.lblDataInicioNovo = New System.Windows.Forms.Label()
        Me.dtpDataInicioNovo = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtRevisaoNovo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRevisaoNovo = New System.Windows.Forms.Label()
        Me.grpDadosQualidade = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTempoEstimadoMaquina = New System.Windows.Forms.Label()
        Me.lblTempoEstimadoMaquinaRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblTempoEstimadoSetup = New System.Windows.Forms.Label()
        Me.lblTempoEstimadoSetupRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblDataValidadeRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblDataValidadeRevisao = New System.Windows.Forms.Label()
        Me.lblDataInicioRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblDataInicioRevisao = New System.Windows.Forms.Label()
        Me.lblRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblRevisao = New System.Windows.Forms.Label()
        Me.lblTempoMedioProducao = New System.Windows.Forms.Label()
        Me.lblTempoEstimadoMaoObra = New System.Windows.Forms.Label()
        Me.lblTempoMedioProducaoRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblQuantidadeRejeito = New System.Windows.Forms.Label()
        Me.lblQuantidadeOrdemProducaoTryout = New System.Windows.Forms.Label()
        Me.lblTempoEstimadoMaoObraRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblQuantidadeOrdemProducao = New System.Windows.Forms.Label()
        Me.lblQuantidadeRejeitoRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblStatusRevisao = New System.Windows.Forms.Label()
        Me.lblAprovadoPorRevisao = New System.Windows.Forms.Label()
        Me.lblQuantidadeOrdemProducaoTryoutRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblStatusRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblQuantidadeOrdemProducaoRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblElaboradoPorRevisao = New System.Windows.Forms.Label()
        Me.lblElaboradoPorRevisaoInfo = New System.Windows.Forms.Label()
        Me.lblAprovadoPorRevisaoInfo = New System.Windows.Forms.Label()
        Me.chrMain = New Dundas.Charting.WinControl.Chart()
        Me.pagRoteiro = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridRoteiro = New System.Windows.Forms.Button()
        Me.grpRoteiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtTempoMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTempoMaoObra = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTempoSetupMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblTempoMaquina = New System.Windows.Forms.Label()
        Me.lblTempoMaoObra = New System.Windows.Forms.Label()
        Me.lblTempoSetupMaquina = New System.Windows.Forms.Label()
        Me.lblApontamentoConcorrente = New System.Windows.Forms.Label()
        Me.cboApontamentoConcorrente = New Janus.Windows.EditControls.UIComboBox()
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
        Me.btnCadastrarCentroTrabalho = New System.Windows.Forms.Button()
        Me.btnCadastrarOperacao = New System.Windows.Forms.Button()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.btnAgruparGridRoteiro = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRoteiro = New System.Windows.Forms.Button()
        Me.grdRoteiro = New Janus.Windows.GridEX.GridEX()
        Me.pagQualidade = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridQualidade = New System.Windows.Forms.Button()
        Me.btnAgruparGridQualidade = New System.Windows.Forms.Button()
        Me.btnConfigurarGridQualidade = New System.Windows.Forms.Button()
        Me.grdQualidade = New Janus.Windows.GridEX.GridEX()
        Me.grpQualidade = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblApontaQualidade = New System.Windows.Forms.Label()
        Me.cboApontaQualidade = New Janus.Windows.EditControls.UIComboBox()
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
        Me.btnCadastrarCaracteristicaInspecionarQualidade = New System.Windows.Forms.Button()
        Me.btnExcluirQualidade = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirQualidade = New Janus.Windows.EditControls.UIButton()
        Me.pagRequisicaoEstoque = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridBOM = New System.Windows.Forms.Button()
        Me.btnAgruparGridBOM = New System.Windows.Forms.Button()
        Me.btnConfigurarGridBOM = New System.Windows.Forms.Button()
        Me.grdBOM = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAprovar = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnLimpar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarModeloRoteiroProducao = New System.Windows.Forms.Button()
        Me.cboModeloRoteiroProducao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModeloRoteiroProducao = New System.Windows.Forms.Label()
        Me.cboRevisao = New Janus.Windows.EditControls.UIComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagRevisao.SuspendLayout()
        CType(Me.grpNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNovo.SuspendLayout()
        CType(Me.grpDadosQualidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosQualidade.SuspendLayout()
        CType(Me.chrMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagRoteiro.SuspendLayout()
        CType(Me.grpRoteiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRoteiro.SuspendLayout()
        CType(Me.grdRoteiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagQualidade.SuspendLayout()
        CType(Me.grdQualidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpQualidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQualidade.SuspendLayout()
        Me.pagRequisicaoEstoque.SuspendLayout()
        CType(Me.grdBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Key = "pagDados"
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'tabDados
        '
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagRevisao, Me.pagRoteiro, Me.pagQualidade, Me.pagRequisicaoEstoque})
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagRevisao
        '
        Me.pagRevisao.Controls.Add(Me.grpNovo)
        Me.pagRevisao.Controls.Add(Me.grpDadosQualidade)
        Me.pagRevisao.Controls.Add(Me.chrMain)
        Me.pagRevisao.Key = "pagRevisao"
        resources.ApplyResources(Me.pagRevisao, "pagRevisao")
        Me.pagRevisao.Name = "pagRevisao"
        Me.pagRevisao.TabStop = True
        '
        'grpNovo
        '
        resources.ApplyResources(Me.grpNovo, "grpNovo")
        Me.grpNovo.BackColor = System.Drawing.Color.Transparent
        Me.grpNovo.Controls.Add(Me.txtDescricaoImportar)
        Me.grpNovo.Controls.Add(Me.lblDescricaoImportar)
        Me.grpNovo.Controls.Add(Me.cboModeloRoteiroImportar)
        Me.grpNovo.Controls.Add(Me.lblModeloRoteiroImportar)
        Me.grpNovo.Controls.Add(Me.cboRevisaoImportar)
        Me.grpNovo.Controls.Add(Me.lblRevisaoImportar)
        Me.grpNovo.Controls.Add(Me.btnProcurarProdutoImportar)
        Me.grpNovo.Controls.Add(Me.cboProdutoImportar)
        Me.grpNovo.Controls.Add(Me.lblProdutoImportar)
        Me.grpNovo.Controls.Add(Me.lblDataInicioNovo)
        Me.grpNovo.Controls.Add(Me.dtpDataInicioNovo)
        Me.grpNovo.Controls.Add(Me.txtRevisaoNovo)
        Me.grpNovo.Controls.Add(Me.lblRevisaoNovo)
        Me.grpNovo.Name = "grpNovo"
        Me.grpNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpNovo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpNovo.VisualStyleManager = Me.vsmMain
        '
        'txtDescricaoImportar
        '
        resources.ApplyResources(Me.txtDescricaoImportar, "txtDescricaoImportar")
        Me.txtDescricaoImportar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoImportar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoImportar.MaxLength = 120
        Me.txtDescricaoImportar.Name = "txtDescricaoImportar"
        Me.txtDescricaoImportar.ReadOnly = True
        Me.txtDescricaoImportar.TabStop = False
        '
        'lblDescricaoImportar
        '
        resources.ApplyResources(Me.lblDescricaoImportar, "lblDescricaoImportar")
        Me.lblDescricaoImportar.Name = "lblDescricaoImportar"
        '
        'cboModeloRoteiroImportar
        '
        resources.ApplyResources(Me.cboModeloRoteiroImportar, "cboModeloRoteiroImportar")
        Me.cboModeloRoteiroImportar.Name = "cboModeloRoteiroImportar"
        '
        'lblModeloRoteiroImportar
        '
        resources.ApplyResources(Me.lblModeloRoteiroImportar, "lblModeloRoteiroImportar")
        Me.lblModeloRoteiroImportar.Name = "lblModeloRoteiroImportar"
        '
        'cboRevisaoImportar
        '
        resources.ApplyResources(Me.cboRevisaoImportar, "cboRevisaoImportar")
        Me.cboRevisaoImportar.Name = "cboRevisaoImportar"
        '
        'lblRevisaoImportar
        '
        resources.ApplyResources(Me.lblRevisaoImportar, "lblRevisaoImportar")
        Me.lblRevisaoImportar.Name = "lblRevisaoImportar"
        '
        'btnProcurarProdutoImportar
        '
        Me.btnProcurarProdutoImportar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarProdutoImportar, "btnProcurarProdutoImportar")
        Me.btnProcurarProdutoImportar.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProdutoImportar.Name = "btnProcurarProdutoImportar"
        Me.btnProcurarProdutoImportar.TabStop = False
        Me.btnProcurarProdutoImportar.UseVisualStyleBackColor = True
        '
        'cboProdutoImportar
        '
        resources.ApplyResources(Me.cboProdutoImportar, "cboProdutoImportar")
        Me.cboProdutoImportar.Name = "cboProdutoImportar"
        '
        'lblProdutoImportar
        '
        resources.ApplyResources(Me.lblProdutoImportar, "lblProdutoImportar")
        Me.lblProdutoImportar.Name = "lblProdutoImportar"
        '
        'lblDataInicioNovo
        '
        resources.ApplyResources(Me.lblDataInicioNovo, "lblDataInicioNovo")
        Me.lblDataInicioNovo.Name = "lblDataInicioNovo"
        '
        'dtpDataInicioNovo
        '
        '
        '
        '
        Me.dtpDataInicioNovo.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataInicioNovo, "dtpDataInicioNovo")
        Me.dtpDataInicioNovo.Name = "dtpDataInicioNovo"
        '
        'txtRevisaoNovo
        '
        Me.txtRevisaoNovo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtRevisaoNovo, "txtRevisaoNovo")
        Me.txtRevisaoNovo.MaxLength = 100
        Me.txtRevisaoNovo.Name = "txtRevisaoNovo"
        '
        'lblRevisaoNovo
        '
        resources.ApplyResources(Me.lblRevisaoNovo, "lblRevisaoNovo")
        Me.lblRevisaoNovo.Name = "lblRevisaoNovo"
        '
        'grpDadosQualidade
        '
        resources.ApplyResources(Me.grpDadosQualidade, "grpDadosQualidade")
        Me.grpDadosQualidade.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosQualidade.Controls.Add(Me.lblTempoEstimadoMaquina)
        Me.grpDadosQualidade.Controls.Add(Me.lblTempoEstimadoMaquinaRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblTempoEstimadoSetup)
        Me.grpDadosQualidade.Controls.Add(Me.lblTempoEstimadoSetupRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblDataValidadeRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblDataValidadeRevisao)
        Me.grpDadosQualidade.Controls.Add(Me.lblDataInicioRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblDataInicioRevisao)
        Me.grpDadosQualidade.Controls.Add(Me.lblRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblRevisao)
        Me.grpDadosQualidade.Controls.Add(Me.lblTempoMedioProducao)
        Me.grpDadosQualidade.Controls.Add(Me.lblTempoEstimadoMaoObra)
        Me.grpDadosQualidade.Controls.Add(Me.lblTempoMedioProducaoRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblQuantidadeRejeito)
        Me.grpDadosQualidade.Controls.Add(Me.lblQuantidadeOrdemProducaoTryout)
        Me.grpDadosQualidade.Controls.Add(Me.lblTempoEstimadoMaoObraRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblQuantidadeOrdemProducao)
        Me.grpDadosQualidade.Controls.Add(Me.lblQuantidadeRejeitoRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblStatusRevisao)
        Me.grpDadosQualidade.Controls.Add(Me.lblAprovadoPorRevisao)
        Me.grpDadosQualidade.Controls.Add(Me.lblQuantidadeOrdemProducaoTryoutRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblStatusRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblQuantidadeOrdemProducaoRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblElaboradoPorRevisao)
        Me.grpDadosQualidade.Controls.Add(Me.lblElaboradoPorRevisaoInfo)
        Me.grpDadosQualidade.Controls.Add(Me.lblAprovadoPorRevisaoInfo)
        Me.grpDadosQualidade.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosQualidade.Name = "grpDadosQualidade"
        Me.grpDadosQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosQualidade.Tag = "356"
        Me.grpDadosQualidade.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosQualidade.VisualStyleManager = Me.vsmMain
        '
        'lblTempoEstimadoMaquina
        '
        Me.lblTempoEstimadoMaquina.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblTempoEstimadoMaquina, "lblTempoEstimadoMaquina")
        Me.lblTempoEstimadoMaquina.Name = "lblTempoEstimadoMaquina"
        '
        'lblTempoEstimadoMaquinaRevisaoInfo
        '
        Me.lblTempoEstimadoMaquinaRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblTempoEstimadoMaquinaRevisaoInfo, "lblTempoEstimadoMaquinaRevisaoInfo")
        Me.lblTempoEstimadoMaquinaRevisaoInfo.Name = "lblTempoEstimadoMaquinaRevisaoInfo"
        '
        'lblTempoEstimadoSetup
        '
        Me.lblTempoEstimadoSetup.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblTempoEstimadoSetup, "lblTempoEstimadoSetup")
        Me.lblTempoEstimadoSetup.Name = "lblTempoEstimadoSetup"
        '
        'lblTempoEstimadoSetupRevisaoInfo
        '
        Me.lblTempoEstimadoSetupRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblTempoEstimadoSetupRevisaoInfo, "lblTempoEstimadoSetupRevisaoInfo")
        Me.lblTempoEstimadoSetupRevisaoInfo.Name = "lblTempoEstimadoSetupRevisaoInfo"
        '
        'lblDataValidadeRevisaoInfo
        '
        Me.lblDataValidadeRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblDataValidadeRevisaoInfo, "lblDataValidadeRevisaoInfo")
        Me.lblDataValidadeRevisaoInfo.Name = "lblDataValidadeRevisaoInfo"
        '
        'lblDataValidadeRevisao
        '
        Me.lblDataValidadeRevisao.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblDataValidadeRevisao, "lblDataValidadeRevisao")
        Me.lblDataValidadeRevisao.Name = "lblDataValidadeRevisao"
        '
        'lblDataInicioRevisaoInfo
        '
        Me.lblDataInicioRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblDataInicioRevisaoInfo, "lblDataInicioRevisaoInfo")
        Me.lblDataInicioRevisaoInfo.Name = "lblDataInicioRevisaoInfo"
        '
        'lblDataInicioRevisao
        '
        Me.lblDataInicioRevisao.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblDataInicioRevisao, "lblDataInicioRevisao")
        Me.lblDataInicioRevisao.Name = "lblDataInicioRevisao"
        '
        'lblRevisaoInfo
        '
        Me.lblRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblRevisaoInfo, "lblRevisaoInfo")
        Me.lblRevisaoInfo.Name = "lblRevisaoInfo"
        '
        'lblRevisao
        '
        Me.lblRevisao.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblRevisao, "lblRevisao")
        Me.lblRevisao.Name = "lblRevisao"
        '
        'lblTempoMedioProducao
        '
        Me.lblTempoMedioProducao.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblTempoMedioProducao, "lblTempoMedioProducao")
        Me.lblTempoMedioProducao.Name = "lblTempoMedioProducao"
        '
        'lblTempoEstimadoMaoObra
        '
        Me.lblTempoEstimadoMaoObra.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblTempoEstimadoMaoObra, "lblTempoEstimadoMaoObra")
        Me.lblTempoEstimadoMaoObra.Name = "lblTempoEstimadoMaoObra"
        '
        'lblTempoMedioProducaoRevisaoInfo
        '
        Me.lblTempoMedioProducaoRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblTempoMedioProducaoRevisaoInfo, "lblTempoMedioProducaoRevisaoInfo")
        Me.lblTempoMedioProducaoRevisaoInfo.Name = "lblTempoMedioProducaoRevisaoInfo"
        '
        'lblQuantidadeRejeito
        '
        Me.lblQuantidadeRejeito.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblQuantidadeRejeito, "lblQuantidadeRejeito")
        Me.lblQuantidadeRejeito.Name = "lblQuantidadeRejeito"
        '
        'lblQuantidadeOrdemProducaoTryout
        '
        Me.lblQuantidadeOrdemProducaoTryout.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblQuantidadeOrdemProducaoTryout, "lblQuantidadeOrdemProducaoTryout")
        Me.lblQuantidadeOrdemProducaoTryout.Name = "lblQuantidadeOrdemProducaoTryout"
        '
        'lblTempoEstimadoMaoObraRevisaoInfo
        '
        Me.lblTempoEstimadoMaoObraRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblTempoEstimadoMaoObraRevisaoInfo, "lblTempoEstimadoMaoObraRevisaoInfo")
        Me.lblTempoEstimadoMaoObraRevisaoInfo.Name = "lblTempoEstimadoMaoObraRevisaoInfo"
        '
        'lblQuantidadeOrdemProducao
        '
        Me.lblQuantidadeOrdemProducao.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblQuantidadeOrdemProducao, "lblQuantidadeOrdemProducao")
        Me.lblQuantidadeOrdemProducao.Name = "lblQuantidadeOrdemProducao"
        '
        'lblQuantidadeRejeitoRevisaoInfo
        '
        Me.lblQuantidadeRejeitoRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblQuantidadeRejeitoRevisaoInfo, "lblQuantidadeRejeitoRevisaoInfo")
        Me.lblQuantidadeRejeitoRevisaoInfo.Name = "lblQuantidadeRejeitoRevisaoInfo"
        '
        'lblStatusRevisao
        '
        Me.lblStatusRevisao.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblStatusRevisao, "lblStatusRevisao")
        Me.lblStatusRevisao.Name = "lblStatusRevisao"
        '
        'lblAprovadoPorRevisao
        '
        Me.lblAprovadoPorRevisao.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblAprovadoPorRevisao, "lblAprovadoPorRevisao")
        Me.lblAprovadoPorRevisao.Name = "lblAprovadoPorRevisao"
        '
        'lblQuantidadeOrdemProducaoTryoutRevisaoInfo
        '
        Me.lblQuantidadeOrdemProducaoTryoutRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblQuantidadeOrdemProducaoTryoutRevisaoInfo, "lblQuantidadeOrdemProducaoTryoutRevisaoInfo")
        Me.lblQuantidadeOrdemProducaoTryoutRevisaoInfo.Name = "lblQuantidadeOrdemProducaoTryoutRevisaoInfo"
        '
        'lblStatusRevisaoInfo
        '
        Me.lblStatusRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblStatusRevisaoInfo, "lblStatusRevisaoInfo")
        Me.lblStatusRevisaoInfo.Name = "lblStatusRevisaoInfo"
        '
        'lblQuantidadeOrdemProducaoRevisaoInfo
        '
        Me.lblQuantidadeOrdemProducaoRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblQuantidadeOrdemProducaoRevisaoInfo, "lblQuantidadeOrdemProducaoRevisaoInfo")
        Me.lblQuantidadeOrdemProducaoRevisaoInfo.Name = "lblQuantidadeOrdemProducaoRevisaoInfo"
        '
        'lblElaboradoPorRevisao
        '
        Me.lblElaboradoPorRevisao.BackColor = System.Drawing.Color.Moccasin
        resources.ApplyResources(Me.lblElaboradoPorRevisao, "lblElaboradoPorRevisao")
        Me.lblElaboradoPorRevisao.Name = "lblElaboradoPorRevisao"
        '
        'lblElaboradoPorRevisaoInfo
        '
        Me.lblElaboradoPorRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblElaboradoPorRevisaoInfo, "lblElaboradoPorRevisaoInfo")
        Me.lblElaboradoPorRevisaoInfo.Name = "lblElaboradoPorRevisaoInfo"
        '
        'lblAprovadoPorRevisaoInfo
        '
        Me.lblAprovadoPorRevisaoInfo.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.lblAprovadoPorRevisaoInfo, "lblAprovadoPorRevisaoInfo")
        Me.lblAprovadoPorRevisaoInfo.Name = "lblAprovadoPorRevisaoInfo"
        '
        'chrMain
        '
        resources.ApplyResources(Me.chrMain, "chrMain")
        Me.chrMain.BorderLineColor = System.Drawing.Color.Black
        Me.chrMain.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrMain.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.Name = "Default"
        Me.chrMain.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Default"
        Me.chrMain.Legends.Add(Legend1)
        Me.chrMain.Name = "chrMain"
        Me.chrMain.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.ChartType = "Pie"
        Series1.CustomAttributes = "LabelStyle=Outside"
        Series1.Font = New System.Drawing.Font("Arial", 8.25!)
        Series1.Name = "Series1"
        Series1.ShadowOffset = 1
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrMain.Series.Add(Series1)
        Me.chrMain.UI.Toolbar.Enabled = True
        '
        'pagRoteiro
        '
        Me.pagRoteiro.Controls.Add(Me.btnExcelGridRoteiro)
        Me.pagRoteiro.Controls.Add(Me.grpRoteiro)
        Me.pagRoteiro.Controls.Add(Me.btnAgruparGridRoteiro)
        Me.pagRoteiro.Controls.Add(Me.btnConfigurarGridRoteiro)
        Me.pagRoteiro.Controls.Add(Me.grdRoteiro)
        Me.pagRoteiro.Key = "pagRoteiro"
        resources.ApplyResources(Me.pagRoteiro, "pagRoteiro")
        Me.pagRoteiro.Name = "pagRoteiro"
        Me.pagRoteiro.TabStop = True
        '
        'btnExcelGridRoteiro
        '
        resources.ApplyResources(Me.btnExcelGridRoteiro, "btnExcelGridRoteiro")
        Me.btnExcelGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnExcelGridRoteiro.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridRoteiro.Name = "btnExcelGridRoteiro"
        Me.btnExcelGridRoteiro.TabStop = False
        Me.btnExcelGridRoteiro.UseVisualStyleBackColor = False
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
        Me.grpRoteiro.Controls.Add(Me.lblApontamentoConcorrente)
        Me.grpRoteiro.Controls.Add(Me.cboApontamentoConcorrente)
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
        SuperTipSettings1.HeaderText = "Ref. Produto"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Quantidade de produtos feito no tempo informado."
        Me.jstTip.SetSuperTip(Me.txtReferencia, SuperTipSettings1)
        Me.txtReferencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtReferencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTempoMaquina
        '
        resources.ApplyResources(Me.txtTempoMaquina, "txtTempoMaquina")
        Me.txtTempoMaquina.Mask = "00:00:00"
        Me.txtTempoMaquina.Name = "txtTempoMaquina"
        SuperTipSettings2.FooterText = "Formato HH:MM:SS"
        SuperTipSettings2.HeaderText = "Tempo Máquina"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Tempo de Máquina utilizado para produzir a quantidade de produto especificada no " & _
    "campo Referência."
        Me.jstTip.SetSuperTip(Me.txtTempoMaquina, SuperTipSettings2)
        Me.txtTempoMaquina.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtTempoMaoObra
        '
        resources.ApplyResources(Me.txtTempoMaoObra, "txtTempoMaoObra")
        Me.txtTempoMaoObra.Mask = "00:00:00"
        Me.txtTempoMaoObra.Name = "txtTempoMaoObra"
        SuperTipSettings3.FooterText = "Formato HH:MM:SS"
        SuperTipSettings3.HeaderText = "Tempo M.O."
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Tempo de Mão de Obra utilizado para produzir a quantidade de produto especificada" & _
    " no campo Referência."
        Me.jstTip.SetSuperTip(Me.txtTempoMaoObra, SuperTipSettings3)
        Me.txtTempoMaoObra.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtTempoSetupMaquina
        '
        resources.ApplyResources(Me.txtTempoSetupMaquina, "txtTempoSetupMaquina")
        Me.txtTempoSetupMaquina.Mask = "00:00:00"
        Me.txtTempoSetupMaquina.Name = "txtTempoSetupMaquina"
        SuperTipSettings4.FooterText = "Formato HH:MM:SS"
        SuperTipSettings4.HeaderText = "Tempo Setup"
        SuperTipSettings4.ImageListProvider = Nothing
        SuperTipSettings4.Text = "Tempo de Setup utilizado para liberar a produção." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Este campo não está vinculad" & _
    "o ao campo Referência."
        Me.jstTip.SetSuperTip(Me.txtTempoSetupMaquina, SuperTipSettings4)
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
        'lblApontamentoConcorrente
        '
        resources.ApplyResources(Me.lblApontamentoConcorrente, "lblApontamentoConcorrente")
        Me.lblApontamentoConcorrente.Name = "lblApontamentoConcorrente"
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
        'btnCadastrarCentroTrabalho
        '
        Me.btnCadastrarCentroTrabalho.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarCentroTrabalho, "btnCadastrarCentroTrabalho")
        Me.btnCadastrarCentroTrabalho.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroTrabalho.Name = "btnCadastrarCentroTrabalho"
        Me.btnCadastrarCentroTrabalho.TabStop = False
        Me.btnCadastrarCentroTrabalho.UseVisualStyleBackColor = True
        '
        'btnCadastrarOperacao
        '
        Me.btnCadastrarOperacao.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarOperacao, "btnCadastrarOperacao")
        Me.btnCadastrarOperacao.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarOperacao.Name = "btnCadastrarOperacao"
        Me.btnCadastrarOperacao.TabStop = False
        Me.btnCadastrarOperacao.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        resources.ApplyResources(Me.btnExcluir, "btnExcluir")
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        resources.ApplyResources(Me.btnInserir, "btnInserir")
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
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
        Me.btnAgruparGridRoteiro.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridRoteiro.Name = "btnAgruparGridRoteiro"
        Me.btnAgruparGridRoteiro.TabStop = False
        Me.btnAgruparGridRoteiro.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridRoteiro
        '
        resources.ApplyResources(Me.btnConfigurarGridRoteiro, "btnConfigurarGridRoteiro")
        Me.btnConfigurarGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridRoteiro.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridRoteiro.Name = "btnConfigurarGridRoteiro"
        Me.btnConfigurarGridRoteiro.TabStop = False
        Me.btnConfigurarGridRoteiro.UseVisualStyleBackColor = False
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
        Me.grdRoteiro.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRoteiro.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRoteiro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRoteiro.VisualStyleManager = Me.vsmMain
        '
        'pagQualidade
        '
        Me.pagQualidade.Controls.Add(Me.btnExcelGridQualidade)
        Me.pagQualidade.Controls.Add(Me.btnAgruparGridQualidade)
        Me.pagQualidade.Controls.Add(Me.btnConfigurarGridQualidade)
        Me.pagQualidade.Controls.Add(Me.grdQualidade)
        Me.pagQualidade.Controls.Add(Me.grpQualidade)
        Me.pagQualidade.Key = "pagQualidade"
        resources.ApplyResources(Me.pagQualidade, "pagQualidade")
        Me.pagQualidade.Name = "pagQualidade"
        Me.pagQualidade.TabStop = True
        '
        'btnExcelGridQualidade
        '
        resources.ApplyResources(Me.btnExcelGridQualidade, "btnExcelGridQualidade")
        Me.btnExcelGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnExcelGridQualidade.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridQualidade.Name = "btnExcelGridQualidade"
        Me.btnExcelGridQualidade.TabStop = False
        Me.btnExcelGridQualidade.UseVisualStyleBackColor = False
        '
        'btnAgruparGridQualidade
        '
        resources.ApplyResources(Me.btnAgruparGridQualidade, "btnAgruparGridQualidade")
        Me.btnAgruparGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridQualidade.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridQualidade.Name = "btnAgruparGridQualidade"
        Me.btnAgruparGridQualidade.TabStop = False
        Me.btnAgruparGridQualidade.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridQualidade
        '
        resources.ApplyResources(Me.btnConfigurarGridQualidade, "btnConfigurarGridQualidade")
        Me.btnConfigurarGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridQualidade.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridQualidade.Name = "btnConfigurarGridQualidade"
        Me.btnConfigurarGridQualidade.TabStop = False
        Me.btnConfigurarGridQualidade.UseVisualStyleBackColor = False
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
        Me.grdQualidade.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
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
        Me.grpQualidade.Controls.Add(Me.lblApontaQualidade)
        Me.grpQualidade.Controls.Add(Me.cboApontaQualidade)
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
        'lblApontaQualidade
        '
        resources.ApplyResources(Me.lblApontaQualidade, "lblApontaQualidade")
        Me.lblApontaQualidade.Name = "lblApontaQualidade"
        '
        'cboApontaQualidade
        '
        resources.ApplyResources(Me.cboApontaQualidade, "cboApontaQualidade")
        Me.cboApontaQualidade.Name = "cboApontaQualidade"
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
        'btnCadastrarCaracteristicaInspecionarQualidade
        '
        Me.btnCadastrarCaracteristicaInspecionarQualidade.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarCaracteristicaInspecionarQualidade, "btnCadastrarCaracteristicaInspecionarQualidade")
        Me.btnCadastrarCaracteristicaInspecionarQualidade.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCaracteristicaInspecionarQualidade.Name = "btnCadastrarCaracteristicaInspecionarQualidade"
        Me.btnCadastrarCaracteristicaInspecionarQualidade.TabStop = False
        Me.btnCadastrarCaracteristicaInspecionarQualidade.UseVisualStyleBackColor = True
        '
        'btnExcluirQualidade
        '
        resources.ApplyResources(Me.btnExcluirQualidade, "btnExcluirQualidade")
        Me.btnExcluirQualidade.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirQualidade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirQualidade.Name = "btnExcluirQualidade"
        Me.btnExcluirQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirQualidade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirQualidade
        '
        resources.ApplyResources(Me.btnInserirQualidade, "btnInserirQualidade")
        Me.btnInserirQualidade.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirQualidade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirQualidade.Name = "btnInserirQualidade"
        Me.btnInserirQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirQualidade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagRequisicaoEstoque
        '
        Me.pagRequisicaoEstoque.Controls.Add(Me.btnExcelGridBOM)
        Me.pagRequisicaoEstoque.Controls.Add(Me.btnAgruparGridBOM)
        Me.pagRequisicaoEstoque.Controls.Add(Me.btnConfigurarGridBOM)
        Me.pagRequisicaoEstoque.Controls.Add(Me.grdBOM)
        Me.pagRequisicaoEstoque.Key = "pagRequisicaoEstoque"
        resources.ApplyResources(Me.pagRequisicaoEstoque, "pagRequisicaoEstoque")
        Me.pagRequisicaoEstoque.Name = "pagRequisicaoEstoque"
        Me.pagRequisicaoEstoque.TabStop = True
        '
        'btnExcelGridBOM
        '
        resources.ApplyResources(Me.btnExcelGridBOM, "btnExcelGridBOM")
        Me.btnExcelGridBOM.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridBOM.FlatAppearance.BorderSize = 0
        Me.btnExcelGridBOM.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridBOM.Name = "btnExcelGridBOM"
        Me.btnExcelGridBOM.TabStop = False
        Me.btnExcelGridBOM.UseVisualStyleBackColor = False
        '
        'btnAgruparGridBOM
        '
        resources.ApplyResources(Me.btnAgruparGridBOM, "btnAgruparGridBOM")
        Me.btnAgruparGridBOM.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridBOM.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridBOM.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridBOM.Name = "btnAgruparGridBOM"
        Me.btnAgruparGridBOM.TabStop = False
        Me.btnAgruparGridBOM.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridBOM
        '
        resources.ApplyResources(Me.btnConfigurarGridBOM, "btnConfigurarGridBOM")
        Me.btnConfigurarGridBOM.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridBOM.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridBOM.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridBOM.Name = "btnConfigurarGridBOM"
        Me.btnConfigurarGridBOM.TabStop = False
        Me.btnConfigurarGridBOM.UseVisualStyleBackColor = False
        '
        'grdBOM
        '
        Me.grdBOM.AlternatingColors = True
        resources.ApplyResources(Me.grdBOM, "grdBOM")
        Me.grdBOM.ColumnAutoResize = True
        resources.ApplyResources(grdBOM_DesignTimeLayout, "grdBOM_DesignTimeLayout")
        Me.grdBOM.DesignTimeLayout = grdBOM_DesignTimeLayout
        Me.grdBOM.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdBOM.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdBOM.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdBOM.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdBOM.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdBOM.GroupByBoxVisible = False
        Me.grdBOM.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdBOM.Hierarchical = True
        Me.grdBOM.Name = "grdBOM"
        Me.grdBOM.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdBOM.RecordNavigator = True
        Me.grdBOM.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdBOM.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdBOM.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdBOM.TabStop = False
        Me.grdBOM.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdBOM.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdBOM.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdBOM.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdBOM.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        resources.ApplyResources(Me.grpControl2, "grpControl2")
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnAprovar)
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnLimpar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnAprovar
        '
        resources.ApplyResources(Me.btnAprovar, "btnAprovar")
        Me.btnAprovar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnAprovar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAprovar.Name = "btnAprovar"
        Me.btnAprovar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAprovar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        resources.ApplyResources(Me.btnNovo, "btnNovo")
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        resources.ApplyResources(Me.btnSalvar, "btnSalvar")
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnLimpar
        '
        resources.ApplyResources(Me.btnLimpar, "btnLimpar")
        Me.btnLimpar.Image = Global.INTERACTI.My.Resources.Resources.limpar
        Me.btnLimpar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnLimpar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnCadastrarModeloRoteiroProducao)
        Me.grpDados.Controls.Add(Me.cboModeloRoteiroProducao)
        Me.grpDados.Controls.Add(Me.lblModeloRoteiroProducao)
        Me.grpDados.Controls.Add(Me.cboRevisao)
        Me.grpDados.Controls.Add(Me.Label1)
        Me.grpDados.Controls.Add(Me.btnProcurarProduto)
        Me.grpDados.Controls.Add(Me.btnCadastrarProduto)
        Me.grpDados.Controls.Add(Me.cboProduto)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarModeloRoteiroProducao
        '
        resources.ApplyResources(Me.btnCadastrarModeloRoteiroProducao, "btnCadastrarModeloRoteiroProducao")
        Me.btnCadastrarModeloRoteiroProducao.FlatAppearance.BorderSize = 0
        Me.btnCadastrarModeloRoteiroProducao.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarModeloRoteiroProducao.Name = "btnCadastrarModeloRoteiroProducao"
        Me.btnCadastrarModeloRoteiroProducao.TabStop = False
        Me.btnCadastrarModeloRoteiroProducao.UseVisualStyleBackColor = True
        '
        'cboModeloRoteiroProducao
        '
        resources.ApplyResources(Me.cboModeloRoteiroProducao, "cboModeloRoteiroProducao")
        Me.cboModeloRoteiroProducao.Name = "cboModeloRoteiroProducao"
        '
        'lblModeloRoteiroProducao
        '
        resources.ApplyResources(Me.lblModeloRoteiroProducao, "lblModeloRoteiroProducao")
        Me.lblModeloRoteiroProducao.Name = "lblModeloRoteiroProducao"
        '
        'cboRevisao
        '
        resources.ApplyResources(Me.cboRevisao, "cboRevisao")
        Me.cboRevisao.Name = "cboRevisao"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarProduto, "btnProcurarProduto")
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarProduto, "btnCadastrarProduto")
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'cboProduto
        '
        resources.ApplyResources(Me.cboProduto, "cboProduto")
        Me.cboProduto.Name = "cboProduto"
        '
        'lblProduto
        '
        resources.ApplyResources(Me.lblProduto, "lblProduto")
        Me.lblProduto.Name = "lblProduto"
        '
        'txtDescricao
        '
        resources.ApplyResources(Me.txtDescricao, "txtDescricao")
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        resources.ApplyResources(Me.lblDescricao, "lblDescricao")
        Me.lblDescricao.Name = "lblDescricao"
        '
        'UiButton2
        '
        Me.UiButton2.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.UiButton2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.UiButton2, "UiButton2")
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadProdutoRoteiroProducao
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadProdutoRoteiroProducao"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagRevisao.ResumeLayout(False)
        CType(Me.grpNovo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNovo.ResumeLayout(False)
        Me.grpNovo.PerformLayout()
        CType(Me.grpDadosQualidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosQualidade.ResumeLayout(False)
        CType(Me.chrMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagRoteiro.ResumeLayout(False)
        CType(Me.grpRoteiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRoteiro.ResumeLayout(False)
        Me.grpRoteiro.PerformLayout()
        CType(Me.grdRoteiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagQualidade.ResumeLayout(False)
        CType(Me.grdQualidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpQualidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQualidade.ResumeLayout(False)
        Me.grpQualidade.PerformLayout()
        Me.pagRequisicaoEstoque.ResumeLayout(False)
        CType(Me.grdBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiComboBox1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiComboBox2 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
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
    Friend WithEvents pagRevisao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosQualidade As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTempoMedioProducaoRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblTempoEstimadoMaoObraRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRejeitoRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeOrdemProducaoTryoutRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeOrdemProducaoRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblAprovadoPorRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblElaboradoPorRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblStatusRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblTempoMedioProducao As System.Windows.Forms.Label
    Friend WithEvents lblTempoEstimadoMaoObra As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRejeito As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeOrdemProducaoTryout As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents lblStatusRevisao As System.Windows.Forms.Label
    Friend WithEvents lblAprovadoPorRevisao As System.Windows.Forms.Label
    Friend WithEvents lblElaboradoPorRevisao As System.Windows.Forms.Label
    Friend WithEvents chrMain As Dundas.Charting.WinControl.Chart
    Friend WithEvents cboRevisao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDataValidadeRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblDataValidadeRevisao As System.Windows.Forms.Label
    Friend WithEvents lblDataInicioRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblDataInicioRevisao As System.Windows.Forms.Label
    Friend WithEvents lblRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblRevisao As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpNovo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataInicioNovo As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicioNovo As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtRevisaoNovo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRevisaoNovo As System.Windows.Forms.Label
    Friend WithEvents btnAprovar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgruparGridQualidade As System.Windows.Forms.Button
    Friend WithEvents grpRoteiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblApontamentoConcorrente As System.Windows.Forms.Label
    Friend WithEvents cboApontamentoConcorrente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSequenciaPredecessora As System.Windows.Forms.Label
    Friend WithEvents cboSequenciaPredecessora As Janus.Windows.EditControls.UIComboBox
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
    Friend WithEvents grdRoteiro As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboModeloRoteiroProducao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModeloRoteiroProducao As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarModeloRoteiroProducao As System.Windows.Forms.Button
    Friend WithEvents pagRequisicaoEstoque As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridBOM As System.Windows.Forms.Button
    Friend WithEvents grdBOM As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgruparGridBOM As System.Windows.Forms.Button
    Friend WithEvents lblApontaQualidade As System.Windows.Forms.Label
    Friend WithEvents cboApontaQualidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents lblTempoMaquina As System.Windows.Forms.Label
    Friend WithEvents lblTempoMaoObra As System.Windows.Forms.Label
    Friend WithEvents lblTempoSetupMaquina As System.Windows.Forms.Label
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtTempoMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTempoMaoObra As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTempoSetupMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcelGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridQualidade As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridBOM As System.Windows.Forms.Button
    Friend WithEvents cboModeloRoteiroImportar As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModeloRoteiroImportar As System.Windows.Forms.Label
    Friend WithEvents cboRevisaoImportar As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRevisaoImportar As System.Windows.Forms.Label
    Friend WithEvents btnProcurarProdutoImportar As System.Windows.Forms.Button
    Friend WithEvents cboProdutoImportar As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblProdutoImportar As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoImportar As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoImportar As System.Windows.Forms.Label
    Friend WithEvents lblTempoEstimadoMaquina As System.Windows.Forms.Label
    Friend WithEvents lblTempoEstimadoMaquinaRevisaoInfo As System.Windows.Forms.Label
    Friend WithEvents lblTempoEstimadoSetup As System.Windows.Forms.Label
    Friend WithEvents lblTempoEstimadoSetupRevisaoInfo As System.Windows.Forms.Label

End Class
