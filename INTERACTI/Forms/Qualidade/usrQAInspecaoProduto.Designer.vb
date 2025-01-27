<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrQAInspecaoProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrQAInspecaoProduto))
        Dim grdQualidadeSimNao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdQualidadeValor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoDocumentoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtEmitenteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.lblEmitenteFiltro = New System.Windows.Forms.Label()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaCaracteristicaAprovada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCaracteristicaReprovada = New System.Windows.Forms.Label()
        Me.picLegendaCaracteristicaReprovada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCaracteristicaAprovado = New System.Windows.Forms.Label()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.btnAtualizaLoteInterno = New Janus.Windows.EditControls.UIButton()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblLoteAtual = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtLoteAtual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDataEntrada = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEntrada = New System.Windows.Forms.Label()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLoteInterno = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtLoteInterno = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.lblEmitente = New System.Windows.Forms.Label()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagEstoque = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGridQualidadeSimNao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridQualidadeValor = New System.Windows.Forms.Button()
        Me.grdQualidadeSimNao = New Janus.Windows.GridEX.GridEX()
        Me.grdQualidadeValor = New Janus.Windows.GridEX.GridEX()
        Me.grpEstoque = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblQuantidadeQualidade = New System.Windows.Forms.Label()
        Me.txtQuantidadeQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDataFabricacaoEstoque = New System.Windows.Forms.Label()
        Me.dtpDataFabricacaoEstoque = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataValidadeEstoque = New System.Windows.Forms.Label()
        Me.dtpDataValidadeEstoque = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblLoteEstoque = New System.Windows.Forms.Label()
        Me.txtLoteEstoque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCadastrarDepositoEstoque = New System.Windows.Forms.Button()
        Me.lblDepositoEstoque = New System.Windows.Forms.Label()
        Me.cboDepositoEstoque = New Janus.Windows.EditControls.UIComboBox()
        Me.pagArquivos = New Janus.Windows.UI.Tab.UITabPage()
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
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEstoque.SuspendLayout()
        Me.pagArquivos.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
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
        Me.pagListagem.Text = "Qualidade - Inspeção de Produto"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(58, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 87
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(34, 463)
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
        Me.grpFiltro.Controls.Add(Me.lblTipoDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblTipoDocumentoFiltro
        '
        Me.lblTipoDocumentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoDocumentoFiltro.AutoSize = True
        Me.lblTipoDocumentoFiltro.Location = New System.Drawing.Point(549, 57)
        Me.lblTipoDocumentoFiltro.Name = "lblTipoDocumentoFiltro"
        Me.lblTipoDocumentoFiltro.Size = New System.Drawing.Size(102, 14)
        Me.lblTipoDocumentoFiltro.TabIndex = 13
        Me.lblTipoDocumentoFiltro.Text = "Tipo de Documento:"
        '
        'cboTipoDocumentoFiltro
        '
        Me.cboTipoDocumentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumentoFiltro.Location = New System.Drawing.Point(552, 74)
        Me.cboTipoDocumentoFiltro.Name = "cboTipoDocumentoFiltro"
        Me.cboTipoDocumentoFiltro.Size = New System.Drawing.Size(222, 20)
        Me.cboTipoDocumentoFiltro.TabIndex = 14
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
        Me.txtProdutoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtProdutoFiltro.MaxLength = 120
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(537, 20)
        Me.txtProdutoFiltro.TabIndex = 10
        '
        'dtpDataEmissaoInicioFiltro
        '
        Me.dtpDataEmissaoInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(552, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 7
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoTerminoFiltro
        '
        Me.dtpDataEmissaoTerminoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(666, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 8
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtEmitenteFiltro
        '
        Me.txtEmitenteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmitenteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitenteFiltro.Location = New System.Drawing.Point(185, 34)
        Me.txtEmitenteFiltro.MaxLength = 60
        Me.txtEmitenteFiltro.Name = "txtEmitenteFiltro"
        Me.txtEmitenteFiltro.Size = New System.Drawing.Size(361, 20)
        Me.txtEmitenteFiltro.TabIndex = 5
        '
        'txtSerieFiltro
        '
        Me.txtSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieFiltro.Location = New System.Drawing.Point(119, 34)
        Me.txtSerieFiltro.MaxLength = 3
        Me.txtSerieFiltro.Name = "txtSerieFiltro"
        Me.txtSerieFiltro.Size = New System.Drawing.Size(60, 20)
        Me.txtSerieFiltro.TabIndex = 3
        '
        'lblSerieFiltro
        '
        Me.lblSerieFiltro.AutoSize = True
        Me.lblSerieFiltro.Location = New System.Drawing.Point(116, 17)
        Me.lblSerieFiltro.Name = "lblSerieFiltro"
        Me.lblSerieFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieFiltro.TabIndex = 2
        Me.lblSerieFiltro.Text = "Série:"
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
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(549, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 6
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'lblEmitenteFiltro
        '
        Me.lblEmitenteFiltro.AutoSize = True
        Me.lblEmitenteFiltro.Location = New System.Drawing.Point(182, 17)
        Me.lblEmitenteFiltro.Name = "lblEmitenteFiltro"
        Me.lblEmitenteFiltro.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitenteFiltro.TabIndex = 4
        Me.lblEmitenteFiltro.Text = "Emitente:"
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
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
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
        Me.grdListagem.FrozenColumns = 1
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
        Me.pagDados.Text = "Qualidade - Inspeção de Produto"
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
        Me.lblLegendaCaracteristicaReprovada.TabIndex = 3
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
        Me.grpDados.Controls.Add(Me.lblNumeroDocumento)
        Me.grpDados.Controls.Add(Me.btnAtualizaLoteInterno)
        Me.grpDados.Controls.Add(Me.lblQuantidade)
        Me.grpDados.Controls.Add(Me.lblLoteAtual)
        Me.grpDados.Controls.Add(Me.txtQuantidade)
        Me.grpDados.Controls.Add(Me.txtLoteAtual)
        Me.grpDados.Controls.Add(Me.txtDataEntrada)
        Me.grpDados.Controls.Add(Me.lblDataEntrada)
        Me.grpDados.Controls.Add(Me.txtDataEmissao)
        Me.grpDados.Controls.Add(Me.lblLoteInterno)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.txtLoteInterno)
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.txtEmitente)
        Me.grpDados.Controls.Add(Me.txtSerie)
        Me.grpDados.Controls.Add(Me.lblSerie)
        Me.grpDados.Controls.Add(Me.txtNumeroDocumento)
        Me.grpDados.Controls.Add(Me.lblDataEmissao)
        Me.grpDados.Controls.Add(Me.lblEmitente)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 19
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'btnAtualizaLoteInterno
        '
        Me.btnAtualizaLoteInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizaLoteInterno.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAtualizaLoteInterno.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizaLoteInterno.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAtualizaLoteInterno.Location = New System.Drawing.Point(752, 74)
        Me.btnAtualizaLoteInterno.Name = "btnAtualizaLoteInterno"
        Me.btnAtualizaLoteInterno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizaLoteInterno.Size = New System.Drawing.Size(22, 20)
        Me.btnAtualizaLoteInterno.TabIndex = 16
        Me.btnAtualizaLoteInterno.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(777, 57)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 17
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'lblLoteAtual
        '
        Me.lblLoteAtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoteAtual.AutoSize = True
        Me.lblLoteAtual.Location = New System.Drawing.Point(663, 57)
        Me.lblLoteAtual.Name = "lblLoteAtual"
        Me.lblLoteAtual.Size = New System.Drawing.Size(94, 14)
        Me.lblLoteAtual.TabIndex = 14
        Me.lblLoteAtual.Text = "Lote Interno Atual:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(780, 74)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(108, 20)
        Me.txtQuantidade.TabIndex = 18
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtLoteAtual
        '
        Me.txtLoteAtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoteAtual.DecimalDigits = 0
        Me.txtLoteAtual.Location = New System.Drawing.Point(666, 74)
        Me.txtLoteAtual.Name = "txtLoteAtual"
        Me.txtLoteAtual.Size = New System.Drawing.Size(87, 20)
        Me.txtLoteAtual.TabIndex = 15
        Me.txtLoteAtual.TabStop = False
        Me.txtLoteAtual.Text = "0"
        Me.txtLoteAtual.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtLoteAtual.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDataEntrada
        '
        Me.txtDataEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataEntrada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEntrada.Location = New System.Drawing.Point(780, 34)
        Me.txtDataEntrada.MaxLength = 20
        Me.txtDataEntrada.Name = "txtDataEntrada"
        Me.txtDataEntrada.ReadOnly = True
        Me.txtDataEntrada.Size = New System.Drawing.Size(108, 20)
        Me.txtDataEntrada.TabIndex = 9
        Me.txtDataEntrada.TabStop = False
        '
        'lblDataEntrada
        '
        Me.lblDataEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEntrada.AutoSize = True
        Me.lblDataEntrada.Location = New System.Drawing.Point(777, 17)
        Me.lblDataEntrada.Name = "lblDataEntrada"
        Me.lblDataEntrada.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntrada.TabIndex = 8
        Me.lblDataEntrada.Text = "Data Entrada:"
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Location = New System.Drawing.Point(666, 34)
        Me.txtDataEmissao.MaxLength = 20
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.ReadOnly = True
        Me.txtDataEmissao.Size = New System.Drawing.Size(108, 20)
        Me.txtDataEmissao.TabIndex = 7
        Me.txtDataEmissao.TabStop = False
        '
        'lblLoteInterno
        '
        Me.lblLoteInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoteInterno.AutoSize = True
        Me.lblLoteInterno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLoteInterno.Location = New System.Drawing.Point(541, 57)
        Me.lblLoteInterno.Name = "lblLoteInterno"
        Me.lblLoteInterno.Size = New System.Drawing.Size(67, 14)
        Me.lblLoteInterno.TabIndex = 12
        Me.lblLoteInterno.Text = "Lote Interno:"
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
        'txtLoteInterno
        '
        Me.txtLoteInterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoteInterno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLoteInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteInterno.Location = New System.Drawing.Point(543, 74)
        Me.txtLoteInterno.MaxLength = 50
        Me.txtLoteInterno.Name = "txtLoteInterno"
        Me.txtLoteInterno.ReadOnly = True
        Me.txtLoteInterno.Size = New System.Drawing.Size(117, 20)
        Me.txtLoteInterno.TabIndex = 13
        Me.txtLoteInterno.TabStop = False
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
        Me.txtProduto.Size = New System.Drawing.Size(528, 20)
        Me.txtProduto.TabIndex = 11
        Me.txtProduto.TabStop = False
        '
        'txtEmitente
        '
        Me.txtEmitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmitente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitente.Location = New System.Drawing.Point(185, 34)
        Me.txtEmitente.MaxLength = 60
        Me.txtEmitente.Name = "txtEmitente"
        Me.txtEmitente.ReadOnly = True
        Me.txtEmitente.Size = New System.Drawing.Size(475, 20)
        Me.txtEmitente.TabIndex = 5
        Me.txtEmitente.TabStop = False
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(119, 34)
        Me.txtSerie.MaxLength = 3
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(60, 20)
        Me.txtSerie.TabIndex = 3
        Me.txtSerie.TabStop = False
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(116, 17)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Série:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.IncludeLiterals = False
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(663, 17)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 6
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'lblEmitente
        '
        Me.lblEmitente.AutoSize = True
        Me.lblEmitente.Location = New System.Drawing.Point(182, 17)
        Me.lblEmitente.Name = "lblEmitente"
        Me.lblEmitente.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitente.TabIndex = 4
        Me.lblEmitente.Text = "Emitente:"
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
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
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatus.Location = New System.Drawing.Point(6, 21)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(166, 14)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status da Inspeção de Qualidade"
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(478, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 1
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
        Me.btnSalvar.TabIndex = 0
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
        Me.pagEstoque.Controls.Add(Me.grpEstoque)
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
        Me.btnConfigurarGridQualidadeValor.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridQualidadeValor.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridQualidadeValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridQualidadeValor.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridQualidadeValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridQualidadeValor.Location = New System.Drawing.Point(9, 201)
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
        Me.grdQualidadeSimNao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.grdQualidadeSimNao.Location = New System.Drawing.Point(8, 217)
        Me.grdQualidadeSimNao.Name = "grdQualidadeSimNao"
        Me.grdQualidadeSimNao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdQualidadeSimNao.RecordNavigator = True
        Me.grdQualidadeSimNao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdQualidadeSimNao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdQualidadeSimNao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdQualidadeSimNao.Size = New System.Drawing.Size(879, 118)
        Me.grdQualidadeSimNao.TabIndex = 3
        Me.grdQualidadeSimNao.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdQualidadeSimNao.TabStop = False
        Me.grdQualidadeSimNao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdQualidadeSimNao.VisualStyleManager = Me.vsmMain
        '
        'grdQualidadeValor
        '
        Me.grdQualidadeValor.AlternatingColors = True
        Me.grdQualidadeValor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.grdQualidadeValor.Location = New System.Drawing.Point(8, 77)
        Me.grdQualidadeValor.Name = "grdQualidadeValor"
        Me.grdQualidadeValor.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdQualidadeValor.RecordNavigator = True
        Me.grdQualidadeValor.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdQualidadeValor.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdQualidadeValor.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdQualidadeValor.Size = New System.Drawing.Size(879, 141)
        Me.grdQualidadeValor.TabIndex = 1
        Me.grdQualidadeValor.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdQualidadeValor.TabStop = False
        Me.grdQualidadeValor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdQualidadeValor.VisualStyleManager = Me.vsmMain
        '
        'grpEstoque
        '
        Me.grpEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEstoque.BackColor = System.Drawing.Color.Transparent
        Me.grpEstoque.Controls.Add(Me.lblQuantidadeQualidade)
        Me.grpEstoque.Controls.Add(Me.txtQuantidadeQualidade)
        Me.grpEstoque.Controls.Add(Me.lblDataFabricacaoEstoque)
        Me.grpEstoque.Controls.Add(Me.dtpDataFabricacaoEstoque)
        Me.grpEstoque.Controls.Add(Me.lblDataValidadeEstoque)
        Me.grpEstoque.Controls.Add(Me.dtpDataValidadeEstoque)
        Me.grpEstoque.Controls.Add(Me.lblLoteEstoque)
        Me.grpEstoque.Controls.Add(Me.txtLoteEstoque)
        Me.grpEstoque.Controls.Add(Me.btnCadastrarDepositoEstoque)
        Me.grpEstoque.Controls.Add(Me.lblDepositoEstoque)
        Me.grpEstoque.Controls.Add(Me.cboDepositoEstoque)
        Me.grpEstoque.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEstoque.Location = New System.Drawing.Point(8, 3)
        Me.grpEstoque.Name = "grpEstoque"
        Me.grpEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEstoque.Size = New System.Drawing.Size(879, 65)
        Me.grpEstoque.TabIndex = 0
        Me.grpEstoque.VisualStyleManager = Me.vsmMain
        '
        'lblQuantidadeQualidade
        '
        Me.lblQuantidadeQualidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeQualidade.AutoSize = True
        Me.lblQuantidadeQualidade.Location = New System.Drawing.Point(531, 17)
        Me.lblQuantidadeQualidade.Name = "lblQuantidadeQualidade"
        Me.lblQuantidadeQualidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeQualidade.TabIndex = 5
        Me.lblQuantidadeQualidade.Text = "Quantidade:"
        '
        'txtQuantidadeQualidade
        '
        Me.txtQuantidadeQualidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeQualidade.DecimalDigits = 4
        Me.txtQuantidadeQualidade.Location = New System.Drawing.Point(534, 34)
        Me.txtQuantidadeQualidade.Name = "txtQuantidadeQualidade"
        Me.txtQuantidadeQualidade.Size = New System.Drawing.Size(108, 20)
        Me.txtQuantidadeQualidade.TabIndex = 6
        Me.txtQuantidadeQualidade.Text = "0,0000"
        Me.txtQuantidadeQualidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDataFabricacaoEstoque
        '
        Me.lblDataFabricacaoEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataFabricacaoEstoque.AutoSize = True
        Me.lblDataFabricacaoEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFabricacaoEstoque.Location = New System.Drawing.Point(645, 17)
        Me.lblDataFabricacaoEstoque.Name = "lblDataFabricacaoEstoque"
        Me.lblDataFabricacaoEstoque.Size = New System.Drawing.Size(89, 14)
        Me.lblDataFabricacaoEstoque.TabIndex = 7
        Me.lblDataFabricacaoEstoque.Text = "Data Fabricação:"
        '
        'dtpDataFabricacaoEstoque
        '
        Me.dtpDataFabricacaoEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataFabricacaoEstoque.DropDownCalendar.Name = ""
        Me.dtpDataFabricacaoEstoque.Location = New System.Drawing.Point(648, 34)
        Me.dtpDataFabricacaoEstoque.Name = "dtpDataFabricacaoEstoque"
        Me.dtpDataFabricacaoEstoque.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataFabricacaoEstoque.TabIndex = 8
        Me.dtpDataFabricacaoEstoque.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataValidadeEstoque
        '
        Me.lblDataValidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataValidadeEstoque.AutoSize = True
        Me.lblDataValidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataValidadeEstoque.Location = New System.Drawing.Point(759, 17)
        Me.lblDataValidadeEstoque.Name = "lblDataValidadeEstoque"
        Me.lblDataValidadeEstoque.Size = New System.Drawing.Size(76, 14)
        Me.lblDataValidadeEstoque.TabIndex = 9
        Me.lblDataValidadeEstoque.Text = "Data Validade:"
        '
        'dtpDataValidadeEstoque
        '
        Me.dtpDataValidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataValidadeEstoque.DropDownCalendar.Name = ""
        Me.dtpDataValidadeEstoque.Location = New System.Drawing.Point(762, 34)
        Me.dtpDataValidadeEstoque.Name = "dtpDataValidadeEstoque"
        Me.dtpDataValidadeEstoque.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataValidadeEstoque.TabIndex = 10
        Me.dtpDataValidadeEstoque.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblLoteEstoque
        '
        Me.lblLoteEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoteEstoque.AutoSize = True
        Me.lblLoteEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLoteEstoque.Location = New System.Drawing.Point(378, 17)
        Me.lblLoteEstoque.Name = "lblLoteEstoque"
        Me.lblLoteEstoque.Size = New System.Drawing.Size(90, 14)
        Me.lblLoteEstoque.TabIndex = 3
        Me.lblLoteEstoque.Text = "Lote Fornecedor:"
        '
        'txtLoteEstoque
        '
        Me.txtLoteEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoteEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteEstoque.Location = New System.Drawing.Point(381, 34)
        Me.txtLoteEstoque.MaxLength = 50
        Me.txtLoteEstoque.Name = "txtLoteEstoque"
        Me.txtLoteEstoque.Size = New System.Drawing.Size(147, 20)
        Me.txtLoteEstoque.TabIndex = 4
        '
        'btnCadastrarDepositoEstoque
        '
        Me.btnCadastrarDepositoEstoque.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDepositoEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDepositoEstoque.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarDepositoEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDepositoEstoque.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarDepositoEstoque.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDepositoEstoque.Name = "btnCadastrarDepositoEstoque"
        Me.btnCadastrarDepositoEstoque.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDepositoEstoque.TabIndex = 0
        Me.btnCadastrarDepositoEstoque.TabStop = False
        Me.btnCadastrarDepositoEstoque.UseVisualStyleBackColor = True
        '
        'lblDepositoEstoque
        '
        Me.lblDepositoEstoque.AutoSize = True
        Me.lblDepositoEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoEstoque.Location = New System.Drawing.Point(25, 17)
        Me.lblDepositoEstoque.Name = "lblDepositoEstoque"
        Me.lblDepositoEstoque.Size = New System.Drawing.Size(52, 14)
        Me.lblDepositoEstoque.TabIndex = 1
        Me.lblDepositoEstoque.Text = "Depósito:"
        '
        'cboDepositoEstoque
        '
        Me.cboDepositoEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDepositoEstoque.AutoSize = False
        Me.cboDepositoEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoEstoque.Location = New System.Drawing.Point(9, 34)
        Me.cboDepositoEstoque.Name = "cboDepositoEstoque"
        Me.cboDepositoEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepositoEstoque.Size = New System.Drawing.Size(366, 20)
        Me.cboDepositoEstoque.TabIndex = 2
        '
        'pagArquivos
        '
        Me.pagArquivos.Controls.Add(Me.btnAgruparGridArquivo)
        Me.pagArquivos.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagArquivos.Controls.Add(Me.grpArquivo)
        Me.pagArquivos.Controls.Add(Me.grdArquivo)
        Me.pagArquivos.Key = "pagArquivos"
        Me.pagArquivos.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivos.Name = "pagArquivos"
        Me.pagArquivos.Size = New System.Drawing.Size(895, 344)
        Me.pagArquivos.TabStop = True
        Me.pagArquivos.Text = "Arquivos"
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 318)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 7
        Me.btnAgruparGridArquivo.TabStop = False
        Me.btnAgruparGridArquivo.UseVisualStyleBackColor = False
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
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 6
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
        Me.grpArquivo.TabIndex = 4
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
        Me.grdArquivo.Size = New System.Drawing.Size(879, 219)
        Me.grdArquivo.TabIndex = 5
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
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
        'usrQAInspecaoProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrQAInspecaoProduto"
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
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEstoque.ResumeLayout(False)
        Me.grpEstoque.PerformLayout()
        Me.pagArquivos.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtEmitenteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblEmitenteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboTipoDocumentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtDataEntrada As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEntrada As System.Windows.Forms.Label
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents lblEmitente As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagEstoque As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpEstoque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataFabricacaoEstoque As System.Windows.Forms.Label
    Friend WithEvents dtpDataFabricacaoEstoque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataValidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents dtpDataValidadeEstoque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblLoteEstoque As System.Windows.Forms.Label
    Friend WithEvents txtLoteEstoque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnCadastrarDepositoEstoque As System.Windows.Forms.Button
    Friend WithEvents lblDepositoEstoque As System.Windows.Forms.Label
    Friend WithEvents cboDepositoEstoque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagArquivos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagObservacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblLoteInterno As System.Windows.Forms.Label
    Friend WithEvents txtLoteInterno As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblQuantidadeQualidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLoteAtual As System.Windows.Forms.Label
    Friend WithEvents txtLoteAtual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnAtualizaLoteInterno As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGridQualidadeSimNao As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridQualidadeValor As System.Windows.Forms.Button
    Friend WithEvents grdQualidadeSimNao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdQualidadeValor As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaCaracteristicaAprovada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCaracteristicaReprovada As System.Windows.Forms.Label
    Friend WithEvents picLegendaCaracteristicaReprovada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCaracteristicaAprovado As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
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

End Class
