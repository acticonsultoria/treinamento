<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrManRequisicao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrManRequisicao))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column0.Image")
        Dim cboStatusRequisicaoFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdManutencao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdManutencao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaAguardandoOrdemServico = New System.Windows.Forms.Label()
        Me.picLegendaAguardandoOrdemServico = New System.Windows.Forms.PictureBox()
        Me.lblLegendaConcluido = New System.Windows.Forms.Label()
        Me.picLegendaConcluido = New System.Windows.Forms.PictureBox()
        Me.lblLegendaReprovado = New System.Windows.Forms.Label()
        Me.picLegendaReprovao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEmManutencao = New System.Windows.Forms.Label()
        Me.picLegendaEmManutencao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAguardandoAprovacao = New System.Windows.Forms.Label()
        Me.picLegendaAguardandoAprovacao = New System.Windows.Forms.PictureBox()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboManutencaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboAprovadorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAprovadorFiltro = New System.Windows.Forms.Label()
        Me.cboRequisitanteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRequisitanteFiltro = New System.Windows.Forms.Label()
        Me.cboStatusRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataRequisicaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataRequisicaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblManutencaoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblDataRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblStatusRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosRequisicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboAprovador = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.lblAprovador = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagItem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridManutencao = New System.Windows.Forms.Button()
        Me.btnAgruparGridManutencao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridManutencao = New System.Windows.Forms.Button()
        Me.grpManutencao = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboArea = New Janus.Windows.EditControls.UIComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnCadastrarArea = New System.Windows.Forms.Button()
        Me.dtpDataNecessidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboManutencao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblManutencao = New System.Windows.Forms.Label()
        Me.lblJustificativa = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtComplemento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataNecessidade = New System.Windows.Forms.Label()
        Me.btnCadastrarManutencao = New System.Windows.Forms.Button()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.btnExcluirManutencao = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirManutencao = New Janus.Windows.EditControls.UIButton()
        Me.grdManutencao = New Janus.Windows.GridEX.GridEX()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRevisaoArquivo = New System.Windows.Forms.Label()
        Me.txtRevisaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCadastrarTipoArquivo = New System.Windows.Forms.Button()
        Me.lblTipoArquivo = New System.Windows.Forms.Label()
        Me.cboTipoArquivo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaAguardandoOrdemServico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaReprovao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaEmManutencao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAguardandoAprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDadosRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosRequisicao.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagItem.SuspendLayout()
        CType(Me.grpManutencao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpManutencao.SuspendLayout()
        CType(Me.grdManutencao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Requisição de Manutenção"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
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
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoOrdemServico)
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoOrdemServico)
        Me.grpLegenda.Controls.Add(Me.lblLegendaConcluido)
        Me.grpLegenda.Controls.Add(Me.picLegendaConcluido)
        Me.grpLegenda.Controls.Add(Me.lblLegendaReprovado)
        Me.grpLegenda.Controls.Add(Me.picLegendaReprovao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEmManutencao)
        Me.grpLegenda.Controls.Add(Me.picLegendaEmManutencao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoAprovacao)
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoAprovacao)
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(440, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaAguardandoOrdemServico
        '
        Me.lblLegendaAguardandoOrdemServico.AutoSize = True
        Me.lblLegendaAguardandoOrdemServico.Location = New System.Drawing.Point(176, 13)
        Me.lblLegendaAguardandoOrdemServico.Name = "lblLegendaAguardandoOrdemServico"
        Me.lblLegendaAguardandoOrdemServico.Size = New System.Drawing.Size(157, 14)
        Me.lblLegendaAguardandoOrdemServico.TabIndex = 25
        Me.lblLegendaAguardandoOrdemServico.Text = "Aguardando Ordem de Serviço"
        '
        'picLegendaAguardandoOrdemServico
        '
        Me.picLegendaAguardandoOrdemServico.BackColor = System.Drawing.Color.Peru
        Me.picLegendaAguardandoOrdemServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoOrdemServico.Location = New System.Drawing.Point(157, 13)
        Me.picLegendaAguardandoOrdemServico.Name = "picLegendaAguardandoOrdemServico"
        Me.picLegendaAguardandoOrdemServico.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAguardandoOrdemServico.TabIndex = 26
        Me.picLegendaAguardandoOrdemServico.TabStop = False
        '
        'lblLegendaConcluido
        '
        Me.lblLegendaConcluido.AutoSize = True
        Me.lblLegendaConcluido.Location = New System.Drawing.Point(28, 31)
        Me.lblLegendaConcluido.Name = "lblLegendaConcluido"
        Me.lblLegendaConcluido.Size = New System.Drawing.Size(54, 14)
        Me.lblLegendaConcluido.TabIndex = 3
        Me.lblLegendaConcluido.Text = "Concluído"
        '
        'picLegendaConcluido
        '
        Me.picLegendaConcluido.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaConcluido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaConcluido.Location = New System.Drawing.Point(9, 31)
        Me.picLegendaConcluido.Name = "picLegendaConcluido"
        Me.picLegendaConcluido.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaConcluido.TabIndex = 24
        Me.picLegendaConcluido.TabStop = False
        '
        'lblLegendaReprovado
        '
        Me.lblLegendaReprovado.AutoSize = True
        Me.lblLegendaReprovado.Location = New System.Drawing.Point(176, 31)
        Me.lblLegendaReprovado.Name = "lblLegendaReprovado"
        Me.lblLegendaReprovado.Size = New System.Drawing.Size(60, 14)
        Me.lblLegendaReprovado.TabIndex = 4
        Me.lblLegendaReprovado.Text = "Reprovado"
        '
        'picLegendaReprovao
        '
        Me.picLegendaReprovao.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaReprovao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaReprovao.Location = New System.Drawing.Point(157, 31)
        Me.picLegendaReprovao.Name = "picLegendaReprovao"
        Me.picLegendaReprovao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaReprovao.TabIndex = 22
        Me.picLegendaReprovao.TabStop = False
        '
        'lblLegendaEmManutencao
        '
        Me.lblLegendaEmManutencao.AutoSize = True
        Me.lblLegendaEmManutencao.Location = New System.Drawing.Point(358, 13)
        Me.lblLegendaEmManutencao.Name = "lblLegendaEmManutencao"
        Me.lblLegendaEmManutencao.Size = New System.Drawing.Size(78, 14)
        Me.lblLegendaEmManutencao.TabIndex = 1
        Me.lblLegendaEmManutencao.Text = "Em Andamento"
        '
        'picLegendaEmManutencao
        '
        Me.picLegendaEmManutencao.BackColor = System.Drawing.Color.Purple
        Me.picLegendaEmManutencao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEmManutencao.Location = New System.Drawing.Point(339, 13)
        Me.picLegendaEmManutencao.Name = "picLegendaEmManutencao"
        Me.picLegendaEmManutencao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEmManutencao.TabIndex = 20
        Me.picLegendaEmManutencao.TabStop = False
        '
        'lblLegendaAguardandoAprovacao
        '
        Me.lblLegendaAguardandoAprovacao.AutoSize = True
        Me.lblLegendaAguardandoAprovacao.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaAguardandoAprovacao.Name = "lblLegendaAguardandoAprovacao"
        Me.lblLegendaAguardandoAprovacao.Size = New System.Drawing.Size(123, 14)
        Me.lblLegendaAguardandoAprovacao.TabIndex = 0
        Me.lblLegendaAguardandoAprovacao.Text = "Aguardando Aprovação"
        '
        'picLegendaAguardandoAprovacao
        '
        Me.picLegendaAguardandoAprovacao.BackColor = System.Drawing.Color.DarkGray
        Me.picLegendaAguardandoAprovacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoAprovacao.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaAguardandoAprovacao.Name = "picLegendaAguardandoAprovacao"
        Me.picLegendaAguardandoAprovacao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAguardandoAprovacao.TabIndex = 4
        Me.picLegendaAguardandoAprovacao.TabStop = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
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
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
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
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 5
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 364)
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
        Me.grpFiltro.Controls.Add(Me.cboManutencaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAprovadorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAprovadorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblManutencaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusRequisicaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboManutencaoFiltro
        '
        Me.cboManutencaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboManutencaoFiltro.AutoSize = False
        Me.cboManutencaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboManutencaoFiltro.Location = New System.Drawing.Point(221, 74)
        Me.cboManutencaoFiltro.Name = "cboManutencaoFiltro"
        Me.cboManutencaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboManutencaoFiltro.Size = New System.Drawing.Size(549, 20)
        Me.cboManutencaoFiltro.TabIndex = 12
        '
        'cboAprovadorFiltro
        '
        Me.cboAprovadorFiltro.AutoSize = False
        Me.cboAprovadorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAprovadorFiltro.Location = New System.Drawing.Point(371, 34)
        Me.cboAprovadorFiltro.Name = "cboAprovadorFiltro"
        Me.cboAprovadorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAprovadorFiltro.Size = New System.Drawing.Size(250, 20)
        Me.cboAprovadorFiltro.TabIndex = 5
        '
        'lblAprovadorFiltro
        '
        Me.lblAprovadorFiltro.AutoSize = True
        Me.lblAprovadorFiltro.Location = New System.Drawing.Point(368, 17)
        Me.lblAprovadorFiltro.Name = "lblAprovadorFiltro"
        Me.lblAprovadorFiltro.Size = New System.Drawing.Size(62, 14)
        Me.lblAprovadorFiltro.TabIndex = 4
        Me.lblAprovadorFiltro.Text = "Aprovador:"
        '
        'cboRequisitanteFiltro
        '
        Me.cboRequisitanteFiltro.AutoSize = False
        Me.cboRequisitanteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRequisitanteFiltro.Location = New System.Drawing.Point(115, 34)
        Me.cboRequisitanteFiltro.Name = "cboRequisitanteFiltro"
        Me.cboRequisitanteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRequisitanteFiltro.Size = New System.Drawing.Size(250, 20)
        Me.cboRequisitanteFiltro.TabIndex = 3
        '
        'lblRequisitanteFiltro
        '
        Me.lblRequisitanteFiltro.AutoSize = True
        Me.lblRequisitanteFiltro.Location = New System.Drawing.Point(112, 17)
        Me.lblRequisitanteFiltro.Name = "lblRequisitanteFiltro"
        Me.lblRequisitanteFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblRequisitanteFiltro.TabIndex = 2
        Me.lblRequisitanteFiltro.Text = "Requisitante:"
        '
        'cboStatusRequisicaoFiltro
        '
        Me.cboStatusRequisicaoFiltro.AllowDrop = True
        Me.cboStatusRequisicaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusRequisicaoFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusRequisicaoFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusRequisicaoFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusRequisicaoFiltro.DesignTimeLayout = cboStatusRequisicaoFiltro_DesignTimeLayout
        Me.cboStatusRequisicaoFiltro.Location = New System.Drawing.Point(627, 34)
        Me.cboStatusRequisicaoFiltro.Name = "cboStatusRequisicaoFiltro"
        Me.cboStatusRequisicaoFiltro.SaveSettings = False
        Me.cboStatusRequisicaoFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusRequisicaoFiltro.Size = New System.Drawing.Size(143, 20)
        Me.cboStatusRequisicaoFiltro.TabIndex = 7
        Me.cboStatusRequisicaoFiltro.ValuesDataMember = Nothing
        '
        'dtpDataRequisicaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoTerminoFiltro.Location = New System.Drawing.Point(115, 74)
        Me.dtpDataRequisicaoTerminoFiltro.Name = "dtpDataRequisicaoTerminoFiltro"
        Me.dtpDataRequisicaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataRequisicaoTerminoFiltro.TabIndex = 10
        '
        'dtpDataRequisicaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataRequisicaoInicioFiltro.Name = "dtpDataRequisicaoInicioFiltro"
        Me.dtpDataRequisicaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataRequisicaoInicioFiltro.TabIndex = 9
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 13
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblManutencaoFiltro
        '
        Me.lblManutencaoFiltro.AutoSize = True
        Me.lblManutencaoFiltro.Location = New System.Drawing.Point(218, 57)
        Me.lblManutencaoFiltro.Name = "lblManutencaoFiltro"
        Me.lblManutencaoFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblManutencaoFiltro.TabIndex = 11
        Me.lblManutencaoFiltro.Text = "Manutenção:"
        '
        'txtNumeroRequisicaoFiltro
        '
        Me.txtNumeroRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicaoFiltro.MaxLength = 20
        Me.txtNumeroRequisicaoFiltro.Name = "txtNumeroRequisicaoFiltro"
        Me.txtNumeroRequisicaoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroRequisicaoFiltro.TabIndex = 1
        '
        'lblNumeroRequisicaoFiltro
        '
        Me.lblNumeroRequisicaoFiltro.AutoSize = True
        Me.lblNumeroRequisicaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicaoFiltro.Name = "lblNumeroRequisicaoFiltro"
        Me.lblNumeroRequisicaoFiltro.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicaoFiltro.TabIndex = 0
        Me.lblNumeroRequisicaoFiltro.Text = "Nº Requisição:"
        '
        'lblDataRequisicaoFiltro
        '
        Me.lblDataRequisicaoFiltro.AutoSize = True
        Me.lblDataRequisicaoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataRequisicaoFiltro.Name = "lblDataRequisicaoFiltro"
        Me.lblDataRequisicaoFiltro.Size = New System.Drawing.Size(103, 14)
        Me.lblDataRequisicaoFiltro.TabIndex = 8
        Me.lblDataRequisicaoFiltro.Text = "Data da Requisição:"
        '
        'lblStatusRequisicaoFiltro
        '
        Me.lblStatusRequisicaoFiltro.AutoSize = True
        Me.lblStatusRequisicaoFiltro.Location = New System.Drawing.Point(624, 17)
        Me.lblStatusRequisicaoFiltro.Name = "lblStatusRequisicaoFiltro"
        Me.lblStatusRequisicaoFiltro.Size = New System.Drawing.Size(97, 14)
        Me.lblStatusRequisicaoFiltro.TabIndex = 6
        Me.lblStatusRequisicaoFiltro.Text = "Status Requisição:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(457, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(448, 51)
        Me.grpControle.TabIndex = 6
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(251, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 0
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(348, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDadosRequisicao)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagLista"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Requisição de Manutenção"
        '
        'grpDadosRequisicao
        '
        Me.grpDadosRequisicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosRequisicao.Controls.Add(Me.cboAprovador)
        Me.grpDadosRequisicao.Controls.Add(Me.txtNumeroRequisicao)
        Me.grpDadosRequisicao.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpDadosRequisicao.Controls.Add(Me.lblAprovador)
        Me.grpDadosRequisicao.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosRequisicao.Name = "grpDadosRequisicao"
        Me.grpDadosRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosRequisicao.Size = New System.Drawing.Size(897, 63)
        Me.grpDadosRequisicao.TabIndex = 0
        Me.grpDadosRequisicao.VisualStyleManager = Me.vsmMain
        '
        'cboAprovador
        '
        Me.cboAprovador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAprovador.AutoSize = False
        Me.cboAprovador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAprovador.Location = New System.Drawing.Point(115, 34)
        Me.cboAprovador.Name = "cboAprovador"
        Me.cboAprovador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAprovador.Size = New System.Drawing.Size(773, 20)
        Me.cboAprovador.TabIndex = 3
        '
        'txtNumeroRequisicao
        '
        Me.txtNumeroRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroRequisicao.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicao.MaxLength = 20
        Me.txtNumeroRequisicao.Name = "txtNumeroRequisicao"
        Me.txtNumeroRequisicao.ReadOnly = True
        Me.txtNumeroRequisicao.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroRequisicao.TabIndex = 1
        Me.txtNumeroRequisicao.TabStop = False
        Me.txtNumeroRequisicao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicao.TabIndex = 0
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'lblAprovador
        '
        Me.lblAprovador.AutoSize = True
        Me.lblAprovador.Location = New System.Drawing.Point(112, 17)
        Me.lblAprovador.Name = "lblAprovador"
        Me.lblAprovador.Size = New System.Drawing.Size(62, 14)
        Me.lblAprovador.TabIndex = 2
        Me.lblAprovador.Text = "Aprovador:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnImprimir)
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnVoltar)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(700, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(506, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 3
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(603, 17)
        Me.btnSalvar.Name = "btnSalvar"
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
        Me.tabDados.Location = New System.Drawing.Point(8, 72)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 408)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagItem, Me.pagArquivo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagItem
        '
        Me.pagItem.Controls.Add(Me.btnExcelGridManutencao)
        Me.pagItem.Controls.Add(Me.btnAgruparGridManutencao)
        Me.pagItem.Controls.Add(Me.btnConfigurarGridManutencao)
        Me.pagItem.Controls.Add(Me.grpManutencao)
        Me.pagItem.Controls.Add(Me.grdManutencao)
        Me.pagItem.Key = "pagItem"
        Me.pagItem.Location = New System.Drawing.Point(1, 22)
        Me.pagItem.Name = "pagItem"
        Me.pagItem.Size = New System.Drawing.Size(895, 385)
        Me.pagItem.TabStop = True
        Me.pagItem.Text = "Manutenção"
        '
        'btnExcelGridManutencao
        '
        Me.btnExcelGridManutencao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridManutencao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridManutencao.FlatAppearance.BorderSize = 0
        Me.btnExcelGridManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridManutencao.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridManutencao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridManutencao.Location = New System.Drawing.Point(57, 359)
        Me.btnExcelGridManutencao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridManutencao.Name = "btnExcelGridManutencao"
        Me.btnExcelGridManutencao.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridManutencao.TabIndex = 0
        Me.btnExcelGridManutencao.TabStop = False
        Me.btnExcelGridManutencao.UseVisualStyleBackColor = False
        '
        'btnAgruparGridManutencao
        '
        Me.btnAgruparGridManutencao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridManutencao.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridManutencao.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridManutencao.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridManutencao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridManutencao.Location = New System.Drawing.Point(33, 359)
        Me.btnAgruparGridManutencao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridManutencao.Name = "btnAgruparGridManutencao"
        Me.btnAgruparGridManutencao.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridManutencao.TabIndex = 4
        Me.btnAgruparGridManutencao.TabStop = False
        Me.btnAgruparGridManutencao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridManutencao
        '
        Me.btnConfigurarGridManutencao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridManutencao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridManutencao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridManutencao.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridManutencao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridManutencao.Location = New System.Drawing.Point(9, 359)
        Me.btnConfigurarGridManutencao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridManutencao.Name = "btnConfigurarGridManutencao"
        Me.btnConfigurarGridManutencao.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridManutencao.TabIndex = 3
        Me.btnConfigurarGridManutencao.TabStop = False
        Me.btnConfigurarGridManutencao.UseVisualStyleBackColor = False
        '
        'grpManutencao
        '
        Me.grpManutencao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpManutencao.BackColor = System.Drawing.Color.Transparent
        Me.grpManutencao.Controls.Add(Me.cboArea)
        Me.grpManutencao.Controls.Add(Me.lblArea)
        Me.grpManutencao.Controls.Add(Me.btnCadastrarArea)
        Me.grpManutencao.Controls.Add(Me.dtpDataNecessidade)
        Me.grpManutencao.Controls.Add(Me.cboManutencao)
        Me.grpManutencao.Controls.Add(Me.lblManutencao)
        Me.grpManutencao.Controls.Add(Me.lblJustificativa)
        Me.grpManutencao.Controls.Add(Me.lblComplemento)
        Me.grpManutencao.Controls.Add(Me.txtComplemento)
        Me.grpManutencao.Controls.Add(Me.lblDataNecessidade)
        Me.grpManutencao.Controls.Add(Me.btnCadastrarManutencao)
        Me.grpManutencao.Controls.Add(Me.txtJustificativa)
        Me.grpManutencao.Controls.Add(Me.btnExcluirManutencao)
        Me.grpManutencao.Controls.Add(Me.btnInserirManutencao)
        Me.grpManutencao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpManutencao.Location = New System.Drawing.Point(8, 3)
        Me.grpManutencao.Name = "grpManutencao"
        Me.grpManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpManutencao.Size = New System.Drawing.Size(879, 144)
        Me.grpManutencao.TabIndex = 1
        Me.grpManutencao.VisualStyleManager = Me.vsmMain
        '
        'cboArea
        '
        Me.cboArea.AutoSize = False
        Me.cboArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboArea.Location = New System.Drawing.Point(9, 74)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboArea.Size = New System.Drawing.Size(325, 20)
        Me.cboArea.TabIndex = 9
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(25, 57)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(34, 14)
        Me.lblArea.TabIndex = 8
        Me.lblArea.Text = "Área:"
        '
        'btnCadastrarArea
        '
        Me.btnCadastrarArea.FlatAppearance.BorderSize = 0
        Me.btnCadastrarArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarArea.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarArea.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarArea.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarArea.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarArea.Name = "btnCadastrarArea"
        Me.btnCadastrarArea.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarArea.TabIndex = 7
        Me.btnCadastrarArea.TabStop = False
        Me.btnCadastrarArea.UseVisualStyleBackColor = True
        '
        'dtpDataNecessidade
        '
        Me.dtpDataNecessidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataNecessidade.DropDownCalendar.Name = ""
        Me.dtpDataNecessidade.Location = New System.Drawing.Point(635, 34)
        Me.dtpDataNecessidade.Name = "dtpDataNecessidade"
        Me.dtpDataNecessidade.ShowCheckBox = True
        Me.dtpDataNecessidade.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataNecessidade.TabIndex = 6
        '
        'cboManutencao
        '
        Me.cboManutencao.AutoSize = False
        Me.cboManutencao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboManutencao.Location = New System.Drawing.Point(9, 34)
        Me.cboManutencao.Name = "cboManutencao"
        Me.cboManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboManutencao.Size = New System.Drawing.Size(325, 20)
        Me.cboManutencao.TabIndex = 2
        '
        'lblManutencao
        '
        Me.lblManutencao.AutoSize = True
        Me.lblManutencao.Location = New System.Drawing.Point(25, 17)
        Me.lblManutencao.Name = "lblManutencao"
        Me.lblManutencao.Size = New System.Drawing.Size(69, 14)
        Me.lblManutencao.TabIndex = 1
        Me.lblManutencao.Text = "Manutenção:"
        '
        'lblJustificativa
        '
        Me.lblJustificativa.AutoSize = True
        Me.lblJustificativa.Location = New System.Drawing.Point(337, 57)
        Me.lblJustificativa.Name = "lblJustificativa"
        Me.lblJustificativa.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativa.TabIndex = 10
        Me.lblJustificativa.Text = "Justificativa:"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(337, 17)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(74, 14)
        Me.lblComplemento.TabIndex = 3
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(340, 34)
        Me.txtComplemento.MaxLength = 100
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(289, 20)
        Me.txtComplemento.TabIndex = 4
        '
        'lblDataNecessidade
        '
        Me.lblDataNecessidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataNecessidade.AutoSize = True
        Me.lblDataNecessidade.Location = New System.Drawing.Point(632, 17)
        Me.lblDataNecessidade.Name = "lblDataNecessidade"
        Me.lblDataNecessidade.Size = New System.Drawing.Size(98, 14)
        Me.lblDataNecessidade.TabIndex = 5
        Me.lblDataNecessidade.Text = "Data Necessidade:"
        '
        'btnCadastrarManutencao
        '
        Me.btnCadastrarManutencao.FlatAppearance.BorderSize = 0
        Me.btnCadastrarManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarManutencao.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarManutencao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarManutencao.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarManutencao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarManutencao.Name = "btnCadastrarManutencao"
        Me.btnCadastrarManutencao.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarManutencao.TabIndex = 0
        Me.btnCadastrarManutencao.TabStop = False
        Me.btnCadastrarManutencao.UseVisualStyleBackColor = True
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(340, 74)
        Me.txtJustificativa.MaxLength = 500
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(395, 60)
        Me.txtJustificativa.TabIndex = 11
        '
        'btnExcluirManutencao
        '
        Me.btnExcluirManutencao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirManutencao.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirManutencao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirManutencao.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirManutencao.Location = New System.Drawing.Point(779, 111)
        Me.btnExcluirManutencao.Name = "btnExcluirManutencao"
        Me.btnExcluirManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirManutencao.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirManutencao.TabIndex = 13
        Me.btnExcluirManutencao.Text = "Excluir"
        Me.btnExcluirManutencao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirManutencao
        '
        Me.btnInserirManutencao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirManutencao.Image = CType(resources.GetObject("btnInserirManutencao.Image"), System.Drawing.Image)
        Me.btnInserirManutencao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirManutencao.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirManutencao.Location = New System.Drawing.Point(779, 82)
        Me.btnInserirManutencao.Name = "btnInserirManutencao"
        Me.btnInserirManutencao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirManutencao.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirManutencao.TabIndex = 12
        Me.btnInserirManutencao.Text = "Inserir"
        Me.btnInserirManutencao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdManutencao
        '
        Me.grdManutencao.AlternatingColors = True
        Me.grdManutencao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdManutencao.AutoEdit = True
        grdManutencao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdManutencao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdManutencao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdManutencao_DesignTimeLayout_Reference_0})
        grdManutencao_DesignTimeLayout.LayoutString = resources.GetString("grdManutencao_DesignTimeLayout.LayoutString")
        Me.grdManutencao.DesignTimeLayout = grdManutencao_DesignTimeLayout
        Me.grdManutencao.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdManutencao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdManutencao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdManutencao.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdManutencao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdManutencao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdManutencao.FrozenColumns = 2
        Me.grdManutencao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdManutencao.GroupByBoxVisible = False
        Me.grdManutencao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdManutencao.Location = New System.Drawing.Point(8, 156)
        Me.grdManutencao.Name = "grdManutencao"
        Me.grdManutencao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdManutencao.RecordNavigator = True
        Me.grdManutencao.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdManutencao.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdManutencao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdManutencao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdManutencao.Size = New System.Drawing.Size(879, 220)
        Me.grdManutencao.TabIndex = 2
        Me.grdManutencao.TabStop = False
        Me.grdManutencao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdManutencao.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdManutencao.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdManutencao.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdManutencao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdManutencao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdManutencao.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdManutencao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdManutencao.VisualStyleManager = Me.vsmMain
        '
        'pagArquivo
        '
        Me.pagArquivo.Controls.Add(Me.btnExcelGridArquivo)
        Me.pagArquivo.Controls.Add(Me.btnAgruparGridArquivo)
        Me.pagArquivo.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagArquivo.Controls.Add(Me.grpArquivo)
        Me.pagArquivo.Controls.Add(Me.grdArquivo)
        Me.pagArquivo.Key = "pagArquivo"
        Me.pagArquivo.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivo.Name = "pagArquivo"
        Me.pagArquivo.Size = New System.Drawing.Size(895, 385)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Text = "Arquivos"
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 359)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 4
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 359)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 3
        Me.btnAgruparGridArquivo.TabStop = False
        Me.btnAgruparGridArquivo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridArquivo
        '
        Me.btnConfigurarGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridArquivo.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 359)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 2
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.lblRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.txtRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnCadastrarTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.cboTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Controls.Add(Me.txtDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblDescricaoArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(879, 104)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'lblRevisaoArquivo
        '
        Me.lblRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevisaoArquivo.AutoSize = True
        Me.lblRevisaoArquivo.Location = New System.Drawing.Point(575, 17)
        Me.lblRevisaoArquivo.Name = "lblRevisaoArquivo"
        Me.lblRevisaoArquivo.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoArquivo.TabIndex = 2
        Me.lblRevisaoArquivo.Text = "Revisão:"
        '
        'txtRevisaoArquivo
        '
        Me.txtRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRevisaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisaoArquivo.Location = New System.Drawing.Point(578, 34)
        Me.txtRevisaoArquivo.MaxLength = 5
        Me.txtRevisaoArquivo.Name = "txtRevisaoArquivo"
        Me.txtRevisaoArquivo.Size = New System.Drawing.Size(89, 20)
        Me.txtRevisaoArquivo.TabIndex = 3
        '
        'btnCadastrarTipoArquivo
        '
        Me.btnCadastrarTipoArquivo.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoArquivo.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarTipoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoArquivo.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarTipoArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoArquivo.Name = "btnCadastrarTipoArquivo"
        Me.btnCadastrarTipoArquivo.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoArquivo.TabIndex = 4
        Me.btnCadastrarTipoArquivo.TabStop = False
        Me.btnCadastrarTipoArquivo.UseVisualStyleBackColor = True
        '
        'lblTipoArquivo
        '
        Me.lblTipoArquivo.AutoSize = True
        Me.lblTipoArquivo.Location = New System.Drawing.Point(25, 57)
        Me.lblTipoArquivo.Name = "lblTipoArquivo"
        Me.lblTipoArquivo.Size = New System.Drawing.Size(85, 14)
        Me.lblTipoArquivo.TabIndex = 5
        Me.lblTipoArquivo.Text = "Tipo do Arquivo:"
        '
        'cboTipoArquivo
        '
        Me.cboTipoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoArquivo.Location = New System.Drawing.Point(9, 74)
        Me.cboTipoArquivo.Name = "cboTipoArquivo"
        Me.cboTipoArquivo.Size = New System.Drawing.Size(240, 20)
        Me.cboTipoArquivo.TabIndex = 6
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(647, 74)
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
        Me.lblArquivo.Location = New System.Drawing.Point(252, 57)
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
        Me.txtArquivo.Location = New System.Drawing.Point(255, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(393, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.excluir
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
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.salvar
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
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(563, 20)
        Me.txtDescricaoArquivo.TabIndex = 1
        '
        'lblDescricaoArquivo
        '
        Me.lblDescricaoArquivo.AutoSize = True
        Me.lblDescricaoArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoArquivo.Name = "lblDescricaoArquivo"
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoArquivo.TabIndex = 0
        Me.lblDescricaoArquivo.Text = "Descrição:"
        '
        'grdArquivo
        '
        Me.grdArquivo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdArquivo.AlternatingColors = True
        Me.grdArquivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArquivo.ColumnAutoResize = True
        grdArquivo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdArquivo_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_1.Instance"), Object)
        grdArquivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivo_DesignTimeLayout_Reference_0, grdArquivo_DesignTimeLayout_Reference_1})
        grdArquivo_DesignTimeLayout.LayoutString = resources.GetString("grdArquivo_DesignTimeLayout.LayoutString")
        Me.grdArquivo.DesignTimeLayout = grdArquivo_DesignTimeLayout
        Me.grdArquivo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdArquivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
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
        Me.grdArquivo.Size = New System.Drawing.Size(879, 260)
        Me.grdArquivo.TabIndex = 1
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrManRequisicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrManRequisicao"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaAguardandoOrdemServico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaReprovao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaEmManutencao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAguardandoAprovacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDadosRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosRequisicao.ResumeLayout(False)
        Me.grpDadosRequisicao.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagItem.ResumeLayout(False)
        CType(Me.grpManutencao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpManutencao.ResumeLayout(False)
        Me.grpManutencao.PerformLayout()
        CType(Me.grdManutencao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagArquivo.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosRequisicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAprovador As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents cboAprovador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblManutencaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroRequisicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpManutencao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents txtComplemento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataNecessidade As System.Windows.Forms.Label
    Friend WithEvents btnExcluirManutencao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirManutencao As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblJustificativa As System.Windows.Forms.Label
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grdManutencao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboManutencao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblManutencao As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarManutencao As System.Windows.Forms.Button
    Friend WithEvents dtpDataRequisicaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataRequisicaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataNecessidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridManutencao As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagItem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents cboAprovadorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAprovadorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboRequisitanteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRequisitanteFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusRequisicaoFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaConcluido As System.Windows.Forms.Label
    Friend WithEvents picLegendaConcluido As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaReprovado As System.Windows.Forms.Label
    Friend WithEvents picLegendaReprovao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEmManutencao As System.Windows.Forms.Label
    Friend WithEvents picLegendaEmManutencao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAguardandoAprovacao As System.Windows.Forms.Label
    Friend WithEvents picLegendaAguardandoAprovacao As System.Windows.Forms.PictureBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridManutencao As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRevisaoArquivo As System.Windows.Forms.Label
    Friend WithEvents txtRevisaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnCadastrarTipoArquivo As System.Windows.Forms.Button
    Friend WithEvents lblTipoArquivo As System.Windows.Forms.Label
    Friend WithEvents cboTipoArquivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As System.Windows.Forms.Label
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridManutencao As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents cboArea As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarArea As System.Windows.Forms.Button
    Friend WithEvents cboManutencaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLegendaAguardandoOrdemServico As System.Windows.Forms.Label
    Friend WithEvents picLegendaAguardandoOrdemServico As System.Windows.Forms.PictureBox

End Class
