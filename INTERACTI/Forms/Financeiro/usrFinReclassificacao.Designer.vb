<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinReclassificacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinReclassificacao))
        Dim grdClassificacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdClassificacao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarContaContabilFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarCentroGastoFiltro = New System.Windows.Forms.Button()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoTituloFiltro = New System.Windows.Forms.Label()
        Me.cboTipoTituloFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataPagamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPagamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblCentroGastoFiltro = New System.Windows.Forms.Label()
        Me.lblDataPagamentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataVencimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblContaContabilFiltro = New System.Windows.Forms.Label()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.lblDataVencimentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboCentroGastoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboContaContabilFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtParceiroNegocioFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.lblParceiroNegocioFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDespesa = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridClassificacao = New System.Windows.Forms.Button()
        Me.btnAgruparGridClassificacao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridClassificacao = New System.Windows.Forms.Button()
        Me.grpClassificao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.txtValorClassificacao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorClassificacao = New System.Windows.Forms.Label()
        Me.btnExcluirClassificacao = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirClassificao = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.grdClassificacao = New Janus.Windows.GridEX.GridEX()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValorPago = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValoPago = New System.Windows.Forms.Label()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.txtParceiroNegocio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picTituloQuitado = New System.Windows.Forms.PictureBox()
        Me.lblTituloNaoClassificado = New System.Windows.Forms.Label()
        Me.picTituloCancelado = New System.Windows.Forms.PictureBox()
        Me.lblTituloClassificado = New System.Windows.Forms.Label()
        Me.lblTituloClassificadoParcialmente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDespesa.SuspendLayout()
        CType(Me.grpClassificao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpClassificao.SuspendLayout()
        CType(Me.grdClassificacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDespesa})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Reclassificação dos Títulos"
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
        Me.btnExcelGrid.TabIndex = 26
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
        Me.btnAgruparGrid.TabIndex = 25
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
        Me.btnConfigurarGrid.TabIndex = 4
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarContaContabilFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarCentroGastoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoTituloFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoTituloFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCentroGastoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPagamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblContaContabilFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCentroGastoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboContaContabilFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarContaContabilFiltro
        '
        Me.btnProcurarContaContabilFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabilFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabilFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabilFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabilFiltro.Location = New System.Drawing.Point(446, 56)
        Me.btnProcurarContaContabilFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabilFiltro.Name = "btnProcurarContaContabilFiltro"
        Me.btnProcurarContaContabilFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabilFiltro.TabIndex = 47
        Me.btnProcurarContaContabilFiltro.TabStop = False
        Me.btnProcurarContaContabilFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarCentroGastoFiltro
        '
        Me.btnProcurarCentroGastoFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGastoFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGastoFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGastoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGastoFiltro.Location = New System.Drawing.Point(216, 56)
        Me.btnProcurarCentroGastoFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGastoFiltro.Name = "btnProcurarCentroGastoFiltro"
        Me.btnProcurarCentroGastoFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGastoFiltro.TabIndex = 46
        Me.btnProcurarCentroGastoFiltro.TabStop = False
        Me.btnProcurarCentroGastoFiltro.UseVisualStyleBackColor = True
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(466, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 12
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFiltro.AutoSize = False
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusFiltro.Location = New System.Drawing.Point(469, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusFiltro.Size = New System.Drawing.Size(224, 20)
        Me.cboStatusFiltro.TabIndex = 13
        '
        'lblTipoTituloFiltro
        '
        Me.lblTipoTituloFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoTituloFiltro.AutoSize = True
        Me.lblTipoTituloFiltro.Location = New System.Drawing.Point(538, 17)
        Me.lblTipoTituloFiltro.Name = "lblTipoTituloFiltro"
        Me.lblTipoTituloFiltro.Size = New System.Drawing.Size(73, 14)
        Me.lblTipoTituloFiltro.TabIndex = 6
        Me.lblTipoTituloFiltro.Text = "Tipo do Título:"
        '
        'cboTipoTituloFiltro
        '
        Me.cboTipoTituloFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoTituloFiltro.AutoSize = False
        Me.cboTipoTituloFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoTituloFiltro.Location = New System.Drawing.Point(541, 34)
        Me.cboTipoTituloFiltro.Name = "cboTipoTituloFiltro"
        Me.cboTipoTituloFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoTituloFiltro.Size = New System.Drawing.Size(152, 20)
        Me.cboTipoTituloFiltro.TabIndex = 7
        '
        'dtpDataPagamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoTerminoFiltro.Location = New System.Drawing.Point(584, 114)
        Me.dtpDataPagamentoTerminoFiltro.Name = "dtpDataPagamentoTerminoFiltro"
        Me.dtpDataPagamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoTerminoFiltro.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataPagamentoTerminoFiltro.TabIndex = 22
        '
        'dtpDataPagamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoInicioFiltro.Location = New System.Drawing.Point(469, 114)
        Me.dtpDataPagamentoInicioFiltro.Name = "dtpDataPagamentoInicioFiltro"
        Me.dtpDataPagamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoInicioFiltro.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataPagamentoInicioFiltro.TabIndex = 21
        '
        'lblCentroGastoFiltro
        '
        Me.lblCentroGastoFiltro.AutoSize = True
        Me.lblCentroGastoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblCentroGastoFiltro.Name = "lblCentroGastoFiltro"
        Me.lblCentroGastoFiltro.Size = New System.Drawing.Size(74, 14)
        Me.lblCentroGastoFiltro.TabIndex = 8
        Me.lblCentroGastoFiltro.Text = "Centro Gasto:"
        '
        'lblDataPagamentoFiltro
        '
        Me.lblDataPagamentoFiltro.AutoSize = True
        Me.lblDataPagamentoFiltro.Location = New System.Drawing.Point(466, 97)
        Me.lblDataPagamentoFiltro.Name = "lblDataPagamentoFiltro"
        Me.lblDataPagamentoFiltro.Size = New System.Drawing.Size(88, 14)
        Me.lblDataPagamentoFiltro.TabIndex = 20
        Me.lblDataPagamentoFiltro.Text = "Data Pagamento:"
        '
        'dtpDataVencimentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoFiltro.Location = New System.Drawing.Point(354, 114)
        Me.dtpDataVencimentoTerminoFiltro.Name = "dtpDataVencimentoTerminoFiltro"
        Me.dtpDataVencimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoFiltro.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataVencimentoTerminoFiltro.TabIndex = 19
        '
        'dtpDataVencimentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioFiltro.Location = New System.Drawing.Point(239, 114)
        Me.dtpDataVencimentoInicioFiltro.Name = "dtpDataVencimentoInicioFiltro"
        Me.dtpDataVencimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoInicioFiltro.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataVencimentoInicioFiltro.TabIndex = 18
        '
        'lblContaContabilFiltro
        '
        Me.lblContaContabilFiltro.AutoSize = True
        Me.lblContaContabilFiltro.Location = New System.Drawing.Point(236, 57)
        Me.lblContaContabilFiltro.Name = "lblContaContabilFiltro"
        Me.lblContaContabilFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabilFiltro.TabIndex = 10
        Me.lblContaContabilFiltro.Text = "Conta Contábil:"
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 14
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'lblDataVencimentoFiltro
        '
        Me.lblDataVencimentoFiltro.AutoSize = True
        Me.lblDataVencimentoFiltro.Location = New System.Drawing.Point(236, 97)
        Me.lblDataVencimentoFiltro.Name = "lblDataVencimentoFiltro"
        Me.lblDataVencimentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltro.TabIndex = 17
        Me.lblDataVencimentoFiltro.Text = "Data Vencimento:"
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(9, 114)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 15
        '
        'cboCentroGastoFiltro
        '
        Me.cboCentroGastoFiltro.AutoSize = False
        Me.cboCentroGastoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGastoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboCentroGastoFiltro.Name = "cboCentroGastoFiltro"
        Me.cboCentroGastoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGastoFiltro.Size = New System.Drawing.Size(224, 20)
        Me.cboCentroGastoFiltro.TabIndex = 9
        '
        'cboContaContabilFiltro
        '
        Me.cboContaContabilFiltro.AutoSize = False
        Me.cboContaContabilFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabilFiltro.Location = New System.Drawing.Point(239, 74)
        Me.cboContaContabilFiltro.Name = "cboContaContabilFiltro"
        Me.cboContaContabilFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabilFiltro.Size = New System.Drawing.Size(224, 20)
        Me.cboContaContabilFiltro.TabIndex = 11
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(124, 114)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 16
        '
        'txtParceiroNegocioFiltro
        '
        Me.txtParceiroNegocioFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParceiroNegocioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParceiroNegocioFiltro.Location = New System.Drawing.Point(160, 34)
        Me.txtParceiroNegocioFiltro.MaxLength = 60
        Me.txtParceiroNegocioFiltro.Name = "txtParceiroNegocioFiltro"
        Me.txtParceiroNegocioFiltro.Size = New System.Drawing.Size(375, 20)
        Me.txtParceiroNegocioFiltro.TabIndex = 5
        '
        'txtSerieFiltro
        '
        Me.txtSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieFiltro.Location = New System.Drawing.Point(114, 34)
        Me.txtSerieFiltro.MaxLength = 3
        Me.txtSerieFiltro.Name = "txtSerieFiltro"
        Me.txtSerieFiltro.Size = New System.Drawing.Size(40, 20)
        Me.txtSerieFiltro.TabIndex = 3
        '
        'lblSerieFiltro
        '
        Me.lblSerieFiltro.AutoSize = True
        Me.lblSerieFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblSerieFiltro.Name = "lblSerieFiltro"
        Me.lblSerieFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieFiltro.TabIndex = 2
        Me.lblSerieFiltro.Text = "Série:"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroDocumentoFiltro.TabIndex = 1
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoFiltro.TabIndex = 0
        Me.lblNumeroDocumentoFiltro.Text = "Nº Documento:"
        '
        'lblParceiroNegocioFiltro
        '
        Me.lblParceiroNegocioFiltro.AutoSize = True
        Me.lblParceiroNegocioFiltro.Location = New System.Drawing.Point(157, 17)
        Me.lblParceiroNegocioFiltro.Name = "lblParceiroNegocioFiltro"
        Me.lblParceiroNegocioFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocioFiltro.TabIndex = 4
        Me.lblParceiroNegocioFiltro.Text = "Parceiro de Negócio:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 23
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
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
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 156)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 324)
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
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(468, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(437, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(240, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(337, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDespesa
        '
        Me.pagDespesa.Controls.Add(Me.btnExcelGridClassificacao)
        Me.pagDespesa.Controls.Add(Me.btnAgruparGridClassificacao)
        Me.pagDespesa.Controls.Add(Me.btnConfigurarGridClassificacao)
        Me.pagDespesa.Controls.Add(Me.grpClassificao)
        Me.pagDespesa.Controls.Add(Me.grdClassificacao)
        Me.pagDespesa.Controls.Add(Me.grpInformacoes)
        Me.pagDespesa.Controls.Add(Me.grdControlesEdicao)
        Me.pagDespesa.Key = "pagDespesa"
        Me.pagDespesa.Location = New System.Drawing.Point(1, 22)
        Me.pagDespesa.Name = "pagDespesa"
        Me.pagDespesa.Size = New System.Drawing.Size(913, 543)
        Me.pagDespesa.TabStop = True
        Me.pagDespesa.Text = "Reclassificação dos Títulos"
        '
        'btnExcelGridClassificacao
        '
        Me.btnExcelGridClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridClassificacao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridClassificacao.FlatAppearance.BorderSize = 0
        Me.btnExcelGridClassificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridClassificacao.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridClassificacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridClassificacao.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridClassificacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridClassificacao.Name = "btnExcelGridClassificacao"
        Me.btnExcelGridClassificacao.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridClassificacao.TabIndex = 27
        Me.btnExcelGridClassificacao.TabStop = False
        Me.btnExcelGridClassificacao.UseVisualStyleBackColor = False
        '
        'btnAgruparGridClassificacao
        '
        Me.btnAgruparGridClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridClassificacao.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridClassificacao.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridClassificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridClassificacao.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridClassificacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridClassificacao.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridClassificacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridClassificacao.Name = "btnAgruparGridClassificacao"
        Me.btnAgruparGridClassificacao.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridClassificacao.TabIndex = 26
        Me.btnAgruparGridClassificacao.TabStop = False
        Me.btnAgruparGridClassificacao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridClassificacao
        '
        Me.btnConfigurarGridClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridClassificacao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridClassificacao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridClassificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridClassificacao.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridClassificacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridClassificacao.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridClassificacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridClassificacao.Name = "btnConfigurarGridClassificacao"
        Me.btnConfigurarGridClassificacao.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridClassificacao.TabIndex = 5
        Me.btnConfigurarGridClassificacao.TabStop = False
        Me.btnConfigurarGridClassificacao.UseVisualStyleBackColor = False
        '
        'grpClassificao
        '
        Me.grpClassificao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpClassificao.BackColor = System.Drawing.Color.Transparent
        Me.grpClassificao.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpClassificao.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpClassificao.Controls.Add(Me.txtValorClassificacao)
        Me.grpClassificao.Controls.Add(Me.lblValorClassificacao)
        Me.grpClassificao.Controls.Add(Me.btnExcluirClassificacao)
        Me.grpClassificao.Controls.Add(Me.btnInserirClassificao)
        Me.grpClassificao.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpClassificao.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpClassificao.Controls.Add(Me.lblContaContabil)
        Me.grpClassificao.Controls.Add(Me.cboContaContabil)
        Me.grpClassificao.Controls.Add(Me.lblCentroGasto)
        Me.grpClassificao.Controls.Add(Me.cboCentroGasto)
        Me.grpClassificao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpClassificao.Location = New System.Drawing.Point(8, 70)
        Me.grpClassificao.Name = "grpClassificao"
        Me.grpClassificao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpClassificao.Size = New System.Drawing.Size(897, 67)
        Me.grpClassificao.TabIndex = 1
        Me.grpClassificao.Text = "Dados da Classificação"
        Me.grpClassificao.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(545, 18)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 49
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(272, 18)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 48
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'txtValorClassificacao
        '
        Me.txtValorClassificacao.DecimalDigits = 2
        Me.txtValorClassificacao.Location = New System.Drawing.Point(568, 37)
        Me.txtValorClassificacao.MaxLength = 0
        Me.txtValorClassificacao.Name = "txtValorClassificacao"
        Me.txtValorClassificacao.Size = New System.Drawing.Size(99, 20)
        Me.txtValorClassificacao.TabIndex = 7
        Me.txtValorClassificacao.Text = "0,00"
        Me.txtValorClassificacao.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorClassificacao
        '
        Me.lblValorClassificacao.AutoSize = True
        Me.lblValorClassificacao.Location = New System.Drawing.Point(565, 20)
        Me.lblValorClassificacao.Name = "lblValorClassificacao"
        Me.lblValorClassificacao.Size = New System.Drawing.Size(35, 14)
        Me.lblValorClassificacao.TabIndex = 6
        Me.lblValorClassificacao.Text = "Valor:"
        '
        'btnExcluirClassificacao
        '
        Me.btnExcluirClassificacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirClassificacao.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirClassificacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirClassificacao.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirClassificacao.Location = New System.Drawing.Point(797, 34)
        Me.btnExcluirClassificacao.Name = "btnExcluirClassificacao"
        Me.btnExcluirClassificacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirClassificacao.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirClassificacao.TabIndex = 9
        Me.btnExcluirClassificacao.Text = "Excluir"
        Me.btnExcluirClassificacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirClassificao
        '
        Me.btnInserirClassificao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirClassificao.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirClassificao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirClassificao.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirClassificao.Location = New System.Drawing.Point(700, 34)
        Me.btnInserirClassificao.Name = "btnInserirClassificao"
        Me.btnInserirClassificao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirClassificao.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirClassificao.TabIndex = 8
        Me.btnInserirClassificao.Text = "Inserir"
        Me.btnInserirClassificao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(295, 21)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 3
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 0
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(311, 20)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 4
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(295, 37)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(267, 20)
        Me.cboContaContabil.TabIndex = 5
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.Location = New System.Drawing.Point(25, 20)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 1
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(9, 37)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(280, 20)
        Me.cboCentroGasto.TabIndex = 2
        '
        'grdClassificacao
        '
        Me.grdClassificacao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdClassificacao.AlternatingColors = True
        Me.grdClassificacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClassificacao.ColumnAutoResize = True
        grdClassificacao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdClassificacao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdClassificacao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdClassificacao_DesignTimeLayout_Reference_0})
        grdClassificacao_DesignTimeLayout.LayoutString = resources.GetString("grdClassificacao_DesignTimeLayout.LayoutString")
        Me.grdClassificacao.DesignTimeLayout = grdClassificacao_DesignTimeLayout
        Me.grdClassificacao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdClassificacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdClassificacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdClassificacao.GroupByBoxVisible = False
        Me.grdClassificacao.Location = New System.Drawing.Point(8, 146)
        Me.grdClassificacao.Name = "grdClassificacao"
        Me.grdClassificacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdClassificacao.RecordNavigator = True
        Me.grdClassificacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdClassificacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdClassificacao.Size = New System.Drawing.Size(897, 334)
        Me.grdClassificacao.TabIndex = 2
        Me.grdClassificacao.TabStop = False
        Me.grdClassificacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdClassificacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdClassificacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdClassificacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdClassificacao.VisualStyleManager = Me.vsmMain
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtValor)
        Me.grpInformacoes.Controls.Add(Me.lblValor)
        Me.grpInformacoes.Controls.Add(Me.txtValorPago)
        Me.grpInformacoes.Controls.Add(Me.lblValoPago)
        Me.grpInformacoes.Controls.Add(Me.txtDataEmissao)
        Me.grpInformacoes.Controls.Add(Me.lblDataEmissao)
        Me.grpInformacoes.Controls.Add(Me.txtParceiroNegocio)
        Me.grpInformacoes.Controls.Add(Me.lblParceiroNegocio)
        Me.grpInformacoes.Controls.Add(Me.txtSerie)
        Me.grpInformacoes.Controls.Add(Me.lblSerie)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(897, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtValor
        '
        Me.txtValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(684, 34)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(99, 20)
        Me.txtValor.TabIndex = 9
        Me.txtValor.TabStop = False
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(681, 17)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 8
        Me.lblValor.Text = "Valor:"
        '
        'txtValorPago
        '
        Me.txtValorPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorPago.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPago.DecimalDigits = 2
        Me.txtValorPago.Location = New System.Drawing.Point(789, 34)
        Me.txtValorPago.MaxLength = 0
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.ReadOnly = True
        Me.txtValorPago.Size = New System.Drawing.Size(99, 20)
        Me.txtValorPago.TabIndex = 11
        Me.txtValorPago.TabStop = False
        Me.txtValorPago.Text = "0,00"
        Me.txtValorPago.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValoPago
        '
        Me.lblValoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValoPago.AutoSize = True
        Me.lblValoPago.Location = New System.Drawing.Point(786, 17)
        Me.lblValoPago.Name = "lblValoPago"
        Me.lblValoPago.Size = New System.Drawing.Size(62, 14)
        Me.lblValoPago.TabIndex = 10
        Me.lblValoPago.Text = "Valor Pago:"
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Location = New System.Drawing.Point(160, 34)
        Me.txtDataEmissao.MaxLength = 20
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.ReadOnly = True
        Me.txtDataEmissao.Size = New System.Drawing.Size(99, 20)
        Me.txtDataEmissao.TabIndex = 5
        Me.txtDataEmissao.TabStop = False
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(157, 17)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 4
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'txtParceiroNegocio
        '
        Me.txtParceiroNegocio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParceiroNegocio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParceiroNegocio.Location = New System.Drawing.Point(265, 34)
        Me.txtParceiroNegocio.MaxLength = 60
        Me.txtParceiroNegocio.Name = "txtParceiroNegocio"
        Me.txtParceiroNegocio.ReadOnly = True
        Me.txtParceiroNegocio.Size = New System.Drawing.Size(413, 20)
        Me.txtParceiroNegocio.TabIndex = 7
        Me.txtParceiroNegocio.TabStop = False
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(262, 17)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocio.TabIndex = 6
        Me.lblParceiroNegocio.Text = "Parceiro de Negócio:"
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(114, 34)
        Me.txtSerie.MaxLength = 3
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(40, 20)
        Me.txtSerie.TabIndex = 3
        Me.txtSerie.TabStop = False
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(111, 17)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Série:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnVoltar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(8, 483)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(897, 51)
        Me.grdControlesEdicao.TabIndex = 3
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 0
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picTituloQuitado)
        Me.grpLegenda.Controls.Add(Me.lblTituloNaoClassificado)
        Me.grpLegenda.Controls.Add(Me.picTituloCancelado)
        Me.grpLegenda.Controls.Add(Me.lblTituloClassificado)
        Me.grpLegenda.Controls.Add(Me.lblTituloClassificadoParcialmente)
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(11, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(451, 51)
        Me.grpLegenda.TabIndex = 27
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picTituloQuitado
        '
        Me.picTituloQuitado.BackColor = System.Drawing.Color.ForestGreen
        Me.picTituloQuitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloQuitado.Location = New System.Drawing.Point(9, 21)
        Me.picTituloQuitado.Name = "picTituloQuitado"
        Me.picTituloQuitado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloQuitado.TabIndex = 12
        Me.picTituloQuitado.TabStop = False
        '
        'lblTituloNaoClassificado
        '
        Me.lblTituloNaoClassificado.AutoSize = True
        Me.lblTituloNaoClassificado.Location = New System.Drawing.Point(330, 21)
        Me.lblTituloNaoClassificado.Name = "lblTituloNaoClassificado"
        Me.lblTituloNaoClassificado.Size = New System.Drawing.Size(116, 14)
        Me.lblTituloNaoClassificado.TabIndex = 3
        Me.lblTituloNaoClassificado.Text = "Título Não Classificado"
        '
        'picTituloCancelado
        '
        Me.picTituloCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picTituloCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloCancelado.Location = New System.Drawing.Point(311, 21)
        Me.picTituloCancelado.Name = "picTituloCancelado"
        Me.picTituloCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloCancelado.TabIndex = 8
        Me.picTituloCancelado.TabStop = False
        '
        'lblTituloClassificado
        '
        Me.lblTituloClassificado.AutoSize = True
        Me.lblTituloClassificado.Location = New System.Drawing.Point(28, 21)
        Me.lblTituloClassificado.Name = "lblTituloClassificado"
        Me.lblTituloClassificado.Size = New System.Drawing.Size(94, 14)
        Me.lblTituloClassificado.TabIndex = 2
        Me.lblTituloClassificado.Text = "Título Classificado"
        '
        'lblTituloClassificadoParcialmente
        '
        Me.lblTituloClassificadoParcialmente.AutoSize = True
        Me.lblTituloClassificadoParcialmente.Location = New System.Drawing.Point(147, 21)
        Me.lblTituloClassificadoParcialmente.Name = "lblTituloClassificadoParcialmente"
        Me.lblTituloClassificadoParcialmente.Size = New System.Drawing.Size(158, 14)
        Me.lblTituloClassificadoParcialmente.TabIndex = 13
        Me.lblTituloClassificadoParcialmente.Text = "Título Classificado Parcialmente"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(128, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'usrFinReclassificacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinReclassificacao"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDespesa.ResumeLayout(False)
        CType(Me.grpClassificao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpClassificao.ResumeLayout(False)
        Me.grpClassificao.PerformLayout()
        CType(Me.grdClassificacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDespesa As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblParceiroNegocioFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtParceiroNegocioFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataPagamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblCentroGastoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblContaContabilFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboCentroGastoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboContaContabilFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpClassificao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorClassificacao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorClassificacao As System.Windows.Forms.Label
    Friend WithEvents btnExcluirClassificacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirClassificao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdClassificacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtValorPago As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValoPago As System.Windows.Forms.Label
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtParceiroNegocio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents lblTipoTituloFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoTituloFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridClassificacao As System.Windows.Forms.Button
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarContaContabilFiltro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCentroGastoFiltro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridClassificacao As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridClassificacao As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picTituloQuitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloNaoClassificado As System.Windows.Forms.Label
    Friend WithEvents picTituloCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloClassificado As System.Windows.Forms.Label
    Friend WithEvents lblTituloClassificadoParcialmente As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
