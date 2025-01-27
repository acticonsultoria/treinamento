<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrQAInspecaoProdutoProducao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrQAInspecaoProdutoProducao))
        Dim grdQualidadeSimNao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdQualidadeValor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
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
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblCentroTrabalhoFiltro = New System.Windows.Forms.Label()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaCaracteristicaAprovada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCaracteristicaReprovada = New System.Windows.Forms.Label()
        Me.picLegendaCaracteristicaReprovada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCaracteristicaAprovado = New System.Windows.Forms.Label()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblQuantidadeQualidade = New System.Windows.Forms.Label()
        Me.txtQuantidadeQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtOperacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtData = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCentroTrabalho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSequencia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSequencia = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatus = New Janus.Windows.EditControls.UIComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagEstoque = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGridQualidadeSimNao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridQualidadeValor = New System.Windows.Forms.Button()
        Me.grdQualidadeSimNao = New Janus.Windows.GridEX.GridEX()
        Me.grdQualidadeValor = New Janus.Windows.GridEX.GridEX()
        Me.pagArquivos = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCaracteristicasInspecionar = New System.Windows.Forms.Label()
        Me.cboCaracteristicasInspecionar = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarTipoArquivo = New System.Windows.Forms.Button()
        Me.lblTipoArquivo = New System.Windows.Forms.Label()
        Me.cboTipoArquivo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.pagObservacao = New Janus.Windows.UI.Tab.UITabPage()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
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
        Me.pagEstoque.SuspendLayout()
        CType(Me.grdQualidadeSimNao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdQualidadeValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagArquivos.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        Me.pagObservacao.SuspendLayout()
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
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(527, 74)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 20
        Me.dtpDataInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(641, 74)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 21
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(524, 57)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 19
        Me.lblDataFiltro.Text = "Data:"
        '
        'cboOperacaoFiltro
        '
        Me.cboOperacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOperacaoFiltro.Location = New System.Drawing.Point(527, 34)
        Me.cboOperacaoFiltro.Name = "cboOperacaoFiltro"
        Me.cboOperacaoFiltro.Size = New System.Drawing.Size(222, 20)
        Me.cboOperacaoFiltro.TabIndex = 18
        '
        'lblOperacaoFiltro
        '
        Me.lblOperacaoFiltro.AutoSize = True
        Me.lblOperacaoFiltro.Location = New System.Drawing.Point(524, 17)
        Me.lblOperacaoFiltro.Name = "lblOperacaoFiltro"
        Me.lblOperacaoFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblOperacaoFiltro.TabIndex = 17
        Me.lblOperacaoFiltro.Text = "Operação:"
        '
        'cboCentroTrabalhoFiltro
        '
        Me.cboCentroTrabalhoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroTrabalhoFiltro.Location = New System.Drawing.Point(185, 34)
        Me.cboCentroTrabalhoFiltro.Name = "cboCentroTrabalhoFiltro"
        Me.cboCentroTrabalhoFiltro.Size = New System.Drawing.Size(336, 20)
        Me.cboCentroTrabalhoFiltro.TabIndex = 16
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 9
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtProdutoFiltro.MaxLength = 120
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(512, 20)
        Me.txtProdutoFiltro.TabIndex = 10
        '
        'txtSequenciaFiltro
        '
        Me.txtSequenciaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSequenciaFiltro.Location = New System.Drawing.Point(119, 34)
        Me.txtSequenciaFiltro.MaxLength = 3
        Me.txtSequenciaFiltro.Name = "txtSequenciaFiltro"
        Me.txtSequenciaFiltro.Size = New System.Drawing.Size(60, 20)
        Me.txtSequenciaFiltro.TabIndex = 3
        '
        'lblSequenciaFiltro
        '
        Me.lblSequenciaFiltro.AutoSize = True
        Me.lblSequenciaFiltro.Location = New System.Drawing.Point(116, 17)
        Me.lblSequenciaFiltro.Name = "lblSequenciaFiltro"
        Me.lblSequenciaFiltro.Size = New System.Drawing.Size(61, 14)
        Me.lblSequenciaFiltro.TabIndex = 2
        Me.lblSequenciaFiltro.Text = "Sequência:"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.IncludeLiterals = False
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroDocumentoFiltro.TabIndex = 1
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
        Me.btnFiltrar.TabIndex = 15
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCentroTrabalhoFiltro
        '
        Me.lblCentroTrabalhoFiltro.AutoSize = True
        Me.lblCentroTrabalhoFiltro.Location = New System.Drawing.Point(182, 17)
        Me.lblCentroTrabalhoFiltro.Name = "lblCentroTrabalhoFiltro"
        Me.lblCentroTrabalhoFiltro.Size = New System.Drawing.Size(102, 14)
        Me.lblCentroTrabalhoFiltro.TabIndex = 4
        Me.lblCentroTrabalhoFiltro.Text = "Centro de Trabalho:"
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblNumeroDocumentoFiltro.TabIndex = 0
        Me.lblNumeroDocumentoFiltro.Text = "Ordem Produção:"
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
        Me.btnExcel.Location = New System.Drawing.Point(700, 17)
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 117)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 363)
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
        Me.grpLegenda.Controls.Add(Me.picLegendaCaracteristicaReprovada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCaracteristicaAprovado)
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
        'lblLegendaCaracteristicaAprovado
        '
        Me.lblLegendaCaracteristicaAprovado.AutoSize = True
        Me.lblLegendaCaracteristicaAprovado.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaCaracteristicaAprovado.Name = "lblLegendaCaracteristicaAprovado"
        Me.lblLegendaCaracteristicaAprovado.Size = New System.Drawing.Size(124, 14)
        Me.lblLegendaCaracteristicaAprovado.TabIndex = 0
        Me.lblLegendaCaracteristicaAprovado.Text = "Característica Aprovada"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblQuantidadeQualidade)
        Me.grpDados.Controls.Add(Me.txtQuantidadeQualidade)
        Me.grpDados.Controls.Add(Me.txtOperacao)
        Me.grpDados.Controls.Add(Me.lblOperacao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblQuantidade)
        Me.grpDados.Controls.Add(Me.txtQuantidade)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.txtData)
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.txtCentroTrabalho)
        Me.grpDados.Controls.Add(Me.txtSequencia)
        Me.grpDados.Controls.Add(Me.lblSequencia)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblCentroTrabalho)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblQuantidadeQualidade
        '
        Me.lblQuantidadeQualidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeQualidade.AutoSize = True
        Me.lblQuantidadeQualidade.Location = New System.Drawing.Point(795, 57)
        Me.lblQuantidadeQualidade.Name = "lblQuantidadeQualidade"
        Me.lblQuantidadeQualidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeQualidade.TabIndex = 5
        Me.lblQuantidadeQualidade.Text = "Quantidade:"
        '
        'txtQuantidadeQualidade
        '
        Me.txtQuantidadeQualidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeQualidade.DecimalDigits = 4
        Me.txtQuantidadeQualidade.Location = New System.Drawing.Point(798, 74)
        Me.txtQuantidadeQualidade.Name = "txtQuantidadeQualidade"
        Me.txtQuantidadeQualidade.Size = New System.Drawing.Size(90, 20)
        Me.txtQuantidadeQualidade.TabIndex = 6
        Me.txtQuantidadeQualidade.Text = "0,0000"
        Me.txtQuantidadeQualidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtOperacao
        '
        Me.txtOperacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOperacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOperacao.Location = New System.Drawing.Point(562, 34)
        Me.txtOperacao.MaxLength = 60
        Me.txtOperacao.Name = "txtOperacao"
        Me.txtOperacao.ReadOnly = True
        Me.txtOperacao.Size = New System.Drawing.Size(326, 20)
        Me.txtOperacao.TabIndex = 21
        Me.txtOperacao.TabStop = False
        '
        'lblOperacao
        '
        Me.lblOperacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOperacao.AutoSize = True
        Me.lblOperacao.Location = New System.Drawing.Point(559, 17)
        Me.lblOperacao.Name = "lblOperacao"
        Me.lblOperacao.Size = New System.Drawing.Size(58, 14)
        Me.lblOperacao.TabIndex = 20
        Me.lblOperacao.Text = "Operação:"
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducao.TabIndex = 19
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(699, 57)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 17
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(702, 74)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(90, 20)
        Me.txtQuantidade.TabIndex = 18
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblData
        '
        Me.lblData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblData.AutoSize = True
        Me.lblData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblData.Location = New System.Drawing.Point(559, 57)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 12
        Me.lblData.Text = "Data:"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(6, 57)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 10
        Me.lblProduto.Text = "Produto:"
        '
        'txtData
        '
        Me.txtData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData.Location = New System.Drawing.Point(562, 74)
        Me.txtData.MaxLength = 50
        Me.txtData.Name = "txtData"
        Me.txtData.ReadOnly = True
        Me.txtData.Size = New System.Drawing.Size(134, 20)
        Me.txtData.TabIndex = 13
        Me.txtData.TabStop = False
        '
        'txtProduto
        '
        Me.txtProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(9, 74)
        Me.txtProduto.MaxLength = 120
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(547, 20)
        Me.txtProduto.TabIndex = 11
        Me.txtProduto.TabStop = False
        '
        'txtCentroTrabalho
        '
        Me.txtCentroTrabalho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCentroTrabalho.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCentroTrabalho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentroTrabalho.Location = New System.Drawing.Point(185, 34)
        Me.txtCentroTrabalho.MaxLength = 60
        Me.txtCentroTrabalho.Name = "txtCentroTrabalho"
        Me.txtCentroTrabalho.ReadOnly = True
        Me.txtCentroTrabalho.Size = New System.Drawing.Size(371, 20)
        Me.txtCentroTrabalho.TabIndex = 5
        Me.txtCentroTrabalho.TabStop = False
        '
        'txtSequencia
        '
        Me.txtSequencia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSequencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSequencia.Location = New System.Drawing.Point(119, 34)
        Me.txtSequencia.MaxLength = 3
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.ReadOnly = True
        Me.txtSequencia.Size = New System.Drawing.Size(60, 20)
        Me.txtSequencia.TabIndex = 3
        Me.txtSequencia.TabStop = False
        '
        'lblSequencia
        '
        Me.lblSequencia.AutoSize = True
        Me.lblSequencia.Location = New System.Drawing.Point(116, 17)
        Me.lblSequencia.Name = "lblSequencia"
        Me.lblSequencia.Size = New System.Drawing.Size(61, 14)
        Me.lblSequencia.TabIndex = 2
        Me.lblSequencia.Text = "Sequência:"
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
        Me.txtOrdemProducao.Size = New System.Drawing.Size(104, 20)
        Me.txtOrdemProducao.TabIndex = 1
        Me.txtOrdemProducao.TabStop = False
        '
        'lblCentroTrabalho
        '
        Me.lblCentroTrabalho.AutoSize = True
        Me.lblCentroTrabalho.Location = New System.Drawing.Point(182, 17)
        Me.lblCentroTrabalho.Name = "lblCentroTrabalho"
        Me.lblCentroTrabalho.Size = New System.Drawing.Size(102, 14)
        Me.lblCentroTrabalho.TabIndex = 4
        Me.lblCentroTrabalho.Text = "Centro de Trabalho:"
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.cboStatus)
        Me.grpControle2.Controls.Add(Me.lblStatus)
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Controls.Add(Me.btnSalvar)
        Me.grpControle2.Location = New System.Drawing.Point(327, 483)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(578, 51)
        Me.grpControle2.TabIndex = 2
        Me.grpControle2.VisualStyleManager = Me.vsmMain
        '
        'cboStatus
        '
        Me.cboStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatus.Location = New System.Drawing.Point(181, 18)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(134, 20)
        Me.cboStatus.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatus.Location = New System.Drawing.Point(6, 21)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(169, 14)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Status da Inspeção de Qualidade:"
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
        Me.tabDados.Location = New System.Drawing.Point(8, 113)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 367)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagEstoque, Me.pagArquivos, Me.pagObservacao})
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagEstoque
        '
        Me.pagEstoque.Controls.Add(Me.btnConfigurarGridQualidadeSimNao)
        Me.pagEstoque.Controls.Add(Me.btnConfigurarGridQualidadeValor)
        Me.pagEstoque.Controls.Add(Me.grdQualidadeSimNao)
        Me.pagEstoque.Controls.Add(Me.grdQualidadeValor)
        Me.pagEstoque.Key = "pagEstoque"
        Me.pagEstoque.Location = New System.Drawing.Point(1, 22)
        Me.pagEstoque.Name = "pagEstoque"
        Me.pagEstoque.Size = New System.Drawing.Size(895, 344)
        Me.pagEstoque.TabStop = True
        Me.pagEstoque.Text = "Dados do Estoque"
        '
        'btnConfigurarGridQualidadeSimNao
        '
        Me.btnConfigurarGridQualidadeSimNao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridQualidadeSimNao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridQualidadeSimNao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridQualidadeSimNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridQualidadeSimNao.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridQualidadeSimNao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridQualidadeSimNao.Location = New System.Drawing.Point(9, 318)
        Me.btnConfigurarGridQualidadeSimNao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridQualidadeSimNao.Name = "btnConfigurarGridQualidadeSimNao"
        Me.btnConfigurarGridQualidadeSimNao.Size = New System.Drawing.Size(49, 15)
        Me.btnConfigurarGridQualidadeSimNao.TabIndex = 4
        Me.btnConfigurarGridQualidadeSimNao.TabStop = False
        Me.btnConfigurarGridQualidadeSimNao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridQualidadeValor
        '
        Me.btnConfigurarGridQualidadeValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridQualidadeValor.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridQualidadeValor.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridQualidadeValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridQualidadeValor.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridQualidadeValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridQualidadeValor.Location = New System.Drawing.Point(9, 145)
        Me.btnConfigurarGridQualidadeValor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridQualidadeValor.Name = "btnConfigurarGridQualidadeValor"
        Me.btnConfigurarGridQualidadeValor.Size = New System.Drawing.Size(49, 15)
        Me.btnConfigurarGridQualidadeValor.TabIndex = 2
        Me.btnConfigurarGridQualidadeValor.TabStop = False
        Me.btnConfigurarGridQualidadeValor.UseVisualStyleBackColor = False
        '
        'grdQualidadeSimNao
        '
        Me.grdQualidadeSimNao.AlternatingColors = True
        Me.grdQualidadeSimNao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdQualidadeSimNao.ColumnAutoResize = True
        grdQualidadeSimNao_DesignTimeLayout.LayoutString = resources.GetString("grdQualidadeSimNao_DesignTimeLayout.LayoutString")
        Me.grdQualidadeSimNao.DesignTimeLayout = grdQualidadeSimNao_DesignTimeLayout
        Me.grdQualidadeSimNao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdQualidadeSimNao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdQualidadeSimNao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdQualidadeSimNao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdQualidadeSimNao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdQualidadeSimNao.GroupByBoxVisible = False
        Me.grdQualidadeSimNao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdQualidadeSimNao.Location = New System.Drawing.Point(8, 161)
        Me.grdQualidadeSimNao.Name = "grdQualidadeSimNao"
        Me.grdQualidadeSimNao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdQualidadeSimNao.RecordNavigator = True
        Me.grdQualidadeSimNao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdQualidadeSimNao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdQualidadeSimNao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdQualidadeSimNao.Size = New System.Drawing.Size(879, 174)
        Me.grdQualidadeSimNao.TabIndex = 3
        Me.grdQualidadeSimNao.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdQualidadeSimNao.TabStop = False
        Me.grdQualidadeSimNao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdQualidadeSimNao.VisualStyleManager = Me.vsmMain
        '
        'grdQualidadeValor
        '
        Me.grdQualidadeValor.AlternatingColors = True
        Me.grdQualidadeValor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdQualidadeValor.ColumnAutoResize = True
        grdQualidadeValor_DesignTimeLayout.LayoutString = resources.GetString("grdQualidadeValor_DesignTimeLayout.LayoutString")
        Me.grdQualidadeValor.DesignTimeLayout = grdQualidadeValor_DesignTimeLayout
        Me.grdQualidadeValor.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdQualidadeValor.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdQualidadeValor.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdQualidadeValor.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdQualidadeValor.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdQualidadeValor.GroupByBoxVisible = False
        Me.grdQualidadeValor.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdQualidadeValor.Location = New System.Drawing.Point(8, 9)
        Me.grdQualidadeValor.Name = "grdQualidadeValor"
        Me.grdQualidadeValor.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdQualidadeValor.RecordNavigator = True
        Me.grdQualidadeValor.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdQualidadeValor.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdQualidadeValor.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdQualidadeValor.Size = New System.Drawing.Size(879, 153)
        Me.grdQualidadeValor.TabIndex = 1
        Me.grdQualidadeValor.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdQualidadeValor.TabStop = False
        Me.grdQualidadeValor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdQualidadeValor.VisualStyleManager = Me.vsmMain
        '
        'pagArquivos
        '
        Me.pagArquivos.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagArquivos.Controls.Add(Me.grdArquivo)
        Me.pagArquivos.Controls.Add(Me.grpArquivo)
        Me.pagArquivos.Key = "pagArquivos"
        Me.pagArquivos.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivos.Name = "pagArquivos"
        Me.pagArquivos.Size = New System.Drawing.Size(895, 344)
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
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 318)
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
        Me.grdArquivo.Size = New System.Drawing.Size(879, 219)
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
        Me.grpArquivo.Controls.Add(Me.lblCaracteristicasInspecionar)
        Me.grpArquivo.Controls.Add(Me.cboCaracteristicasInspecionar)
        Me.grpArquivo.Controls.Add(Me.btnCadastrarTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.cboTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnProcurarArquivo)
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
        'lblCaracteristicasInspecionar
        '
        Me.lblCaracteristicasInspecionar.AutoSize = True
        Me.lblCaracteristicasInspecionar.Location = New System.Drawing.Point(6, 17)
        Me.lblCaracteristicasInspecionar.Name = "lblCaracteristicasInspecionar"
        Me.lblCaracteristicasInspecionar.Size = New System.Drawing.Size(151, 14)
        Me.lblCaracteristicasInspecionar.TabIndex = 0
        Me.lblCaracteristicasInspecionar.Text = "Características a Inspecionar:"
        '
        'cboCaracteristicasInspecionar
        '
        Me.cboCaracteristicasInspecionar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCaracteristicasInspecionar.Location = New System.Drawing.Point(9, 34)
        Me.cboCaracteristicasInspecionar.Name = "cboCaracteristicasInspecionar"
        Me.cboCaracteristicasInspecionar.Size = New System.Drawing.Size(234, 20)
        Me.cboCaracteristicasInspecionar.TabIndex = 1
        '
        'btnCadastrarTipoArquivo
        '
        Me.btnCadastrarTipoArquivo.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoArquivo.Image = Global.INTERACTI.My.Resources.Resources.add
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
        Me.cboTipoArquivo.Size = New System.Drawing.Size(133, 20)
        Me.cboTipoArquivo.TabIndex = 6
        '
        'btnProcurarArquivo
        '
        Me.btnProcurarArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProcurarArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnProcurarArquivo.Location = New System.Drawing.Point(650, 74)
        Me.btnProcurarArquivo.Name = "btnProcurarArquivo"
        Me.btnProcurarArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProcurarArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnProcurarArquivo.TabIndex = 9
        Me.btnProcurarArquivo.Text = "..."
        Me.btnProcurarArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(145, 57)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 7
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(148, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(503, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
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
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(249, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(421, 20)
        Me.txtDescricaoArquivo.TabIndex = 3
        '
        'lblDescricaoArquivo
        '
        Me.lblDescricaoArquivo.AutoSize = True
        Me.lblDescricaoArquivo.Location = New System.Drawing.Point(246, 17)
        Me.lblDescricaoArquivo.Name = "lblDescricaoArquivo"
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoArquivo.TabIndex = 2
        Me.lblDescricaoArquivo.Text = "Descrição:"
        '
        'pagObservacao
        '
        Me.pagObservacao.Controls.Add(Me.txtObservacao)
        Me.pagObservacao.Key = "pagObservacao"
        Me.pagObservacao.Location = New System.Drawing.Point(1, 22)
        Me.pagObservacao.Name = "pagObservacao"
        Me.pagObservacao.Size = New System.Drawing.Size(895, 344)
        Me.pagObservacao.TabStop = True
        Me.pagObservacao.Text = "Observação"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(8, 9)
        Me.txtObservacao.MaxLength = 5000
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(879, 326)
        Me.txtObservacao.TabIndex = 0
        '
        'usrQAInspecaoProdutoProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrQAInspecaoProdutoProducao"
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
        Me.grpControle2.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagEstoque.ResumeLayout(False)
        CType(Me.grdQualidadeSimNao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdQualidadeValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagArquivos.ResumeLayout(False)
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        Me.pagObservacao.ResumeLayout(False)
        Me.pagObservacao.PerformLayout()
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
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSequenciaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSequenciaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCentroTrabalhoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCentroTrabalho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCentroTrabalho As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagEstoque As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagArquivos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarTipoArquivo As System.Windows.Forms.Button
    Friend WithEvents lblTipoArquivo As System.Windows.Forms.Label
    Friend WithEvents cboTipoArquivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As System.Windows.Forms.Label
    Friend WithEvents pagObservacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblCaracteristicasInspecionar As System.Windows.Forms.Label
    Friend WithEvents cboCaracteristicasInspecionar As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidadeQualidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnConfigurarGridQualidadeSimNao As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridQualidadeValor As System.Windows.Forms.Button
    Friend WithEvents grdQualidadeSimNao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdQualidadeValor As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaCaracteristicaAprovada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCaracteristicaReprovada As System.Windows.Forms.Label
    Friend WithEvents picLegendaCaracteristicaReprovada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCaracteristicaAprovado As System.Windows.Forms.Label
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents txtOperacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents txtSequencia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSequencia As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtData As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboOperacaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOperacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCentroTrabalhoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboStatus As Janus.Windows.EditControls.UIComboBox

End Class
