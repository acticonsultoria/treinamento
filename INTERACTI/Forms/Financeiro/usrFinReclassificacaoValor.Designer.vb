<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinReclassificacaoValor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinReclassificacaoValor))
        Dim grdDeve_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdDeve_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPago_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdBoleto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoDocumentoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoTituloFiltro = New System.Windows.Forms.Label()
        Me.cboTipoTituloFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
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
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblParcialmenteEntregue = New System.Windows.Forms.Label()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPedidoVenda = New System.Windows.Forms.Label()
        Me.picLegendaTipoOrcamento = New System.Windows.Forms.PictureBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridBoleto = New System.Windows.Forms.Button()
        Me.btnAgruparGridBoleto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridBoleto = New System.Windows.Forms.Button()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblDataVencimento = New System.Windows.Forms.Label()
        Me.dtpDataVencimento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnExcluirParcela = New Janus.Windows.EditControls.UIButton()
        Me.btnAdicionarParcela = New Janus.Windows.EditControls.UIButton()
        Me.btnExcelGridDeve = New System.Windows.Forms.Button()
        Me.btnAgrupaGridDeve = New System.Windows.Forms.Button()
        Me.btnConfiguraGridDeve = New System.Windows.Forms.Button()
        Me.grdDeve = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelGridPago = New System.Windows.Forms.Button()
        Me.btnAgruparGridPago = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPago = New System.Windows.Forms.Button()
        Me.grdPago = New Janus.Windows.GridEX.GridEX()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoTitulo = New System.Windows.Forms.Label()
        Me.txtTipoTitulo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTipoDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
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
        Me.grdBoleto = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grdDeve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
        CType(Me.grdBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
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
        Me.pagListagem.Text = "Reclassificação de Valor"
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
        Me.btnExcelGrid.TabIndex = 5
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
        Me.btnAgruparGrid.TabIndex = 4
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
        Me.btnConfigurarGrid.TabIndex = 3
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblTipoDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoTituloFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoTituloFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
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
        Me.grpFiltro.Size = New System.Drawing.Size(897, 103)
        Me.grpFiltro.TabIndex = 1
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblTipoDocumentoFiltro
        '
        Me.lblTipoDocumentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoDocumentoFiltro.AutoSize = True
        Me.lblTipoDocumentoFiltro.Location = New System.Drawing.Point(696, 17)
        Me.lblTipoDocumentoFiltro.Name = "lblTipoDocumentoFiltro"
        Me.lblTipoDocumentoFiltro.Size = New System.Drawing.Size(102, 14)
        Me.lblTipoDocumentoFiltro.TabIndex = 18
        Me.lblTipoDocumentoFiltro.Text = "Tipo do Documento:"
        '
        'cboTipoDocumentoFiltro
        '
        Me.cboTipoDocumentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoDocumentoFiltro.AutoSize = False
        Me.cboTipoDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumentoFiltro.Location = New System.Drawing.Point(699, 34)
        Me.cboTipoDocumentoFiltro.Name = "cboTipoDocumentoFiltro"
        Me.cboTipoDocumentoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumentoFiltro.Size = New System.Drawing.Size(152, 20)
        Me.cboTipoDocumentoFiltro.TabIndex = 19
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
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 8
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 9
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(124, 74)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 10
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
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 17
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 112)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 368)
        Me.grdListagem.TabIndex = 2
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
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(187, 481)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(718, 53)
        Me.grpControle.TabIndex = 0
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblParcialmenteEntregue)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoVenda)
        Me.grpLegenda.Controls.Add(Me.picLegendaTipoOrcamento)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(9, 481)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(172, 53)
        Me.grpLegenda.TabIndex = 11
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblParcialmenteEntregue
        '
        Me.lblParcialmenteEntregue.AutoSize = True
        Me.lblParcialmenteEntregue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParcialmenteEntregue.Location = New System.Drawing.Point(108, 24)
        Me.lblParcialmenteEntregue.Name = "lblParcialmenteEntregue"
        Me.lblParcialmenteEntregue.Size = New System.Drawing.Size(50, 14)
        Me.lblParcialmenteEntregue.TabIndex = 1
        Me.lblParcialmenteEntregue.Text = "Despesa"
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picLegendaCancelado.Location = New System.Drawing.Point(89, 23)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelado.TabIndex = 16
        Me.picLegendaCancelado.TabStop = False
        '
        'lblLegendaPedidoVenda
        '
        Me.lblLegendaPedidoVenda.AutoSize = True
        Me.lblLegendaPedidoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLegendaPedidoVenda.Location = New System.Drawing.Point(32, 24)
        Me.lblLegendaPedidoVenda.Name = "lblLegendaPedidoVenda"
        Me.lblLegendaPedidoVenda.Size = New System.Drawing.Size(43, 14)
        Me.lblLegendaPedidoVenda.TabIndex = 0
        Me.lblLegendaPedidoVenda.Text = "Receita"
        '
        'picLegendaTipoOrcamento
        '
        Me.picLegendaTipoOrcamento.BackColor = System.Drawing.Color.Green
        Me.picLegendaTipoOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaTipoOrcamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picLegendaTipoOrcamento.Location = New System.Drawing.Point(13, 23)
        Me.picLegendaTipoOrcamento.Name = "picLegendaTipoOrcamento"
        Me.picLegendaTipoOrcamento.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaTipoOrcamento.TabIndex = 4
        Me.picLegendaTipoOrcamento.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(618, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridBoleto)
        Me.pagDados.Controls.Add(Me.btnAgruparGridBoleto)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridBoleto)
        Me.pagDados.Controls.Add(Me.txtValor)
        Me.pagDados.Controls.Add(Me.lblValor)
        Me.pagDados.Controls.Add(Me.lblDataVencimento)
        Me.pagDados.Controls.Add(Me.dtpDataVencimento)
        Me.pagDados.Controls.Add(Me.btnExcluirParcela)
        Me.pagDados.Controls.Add(Me.btnAdicionarParcela)
        Me.pagDados.Controls.Add(Me.btnExcelGridDeve)
        Me.pagDados.Controls.Add(Me.btnAgrupaGridDeve)
        Me.pagDados.Controls.Add(Me.btnConfiguraGridDeve)
        Me.pagDados.Controls.Add(Me.grdDeve)
        Me.pagDados.Controls.Add(Me.btnExcelGridPago)
        Me.pagDados.Controls.Add(Me.btnAgruparGridPago)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridPago)
        Me.pagDados.Controls.Add(Me.grdPago)
        Me.pagDados.Controls.Add(Me.grpInformacoes)
        Me.pagDados.Controls.Add(Me.grdControlesEdicao)
        Me.pagDados.Controls.Add(Me.grdBoleto)
        Me.pagDados.Key = "pagDespesa"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Reclassificação de Valor"
        '
        'btnExcelGridBoleto
        '
        Me.btnExcelGridBoleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridBoleto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridBoleto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridBoleto.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridBoleto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridBoleto.Location = New System.Drawing.Point(58, 461)
        Me.btnExcelGridBoleto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridBoleto.Name = "btnExcelGridBoleto"
        Me.btnExcelGridBoleto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridBoleto.TabIndex = 42
        Me.btnExcelGridBoleto.TabStop = False
        Me.btnExcelGridBoleto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridBoleto
        '
        Me.btnAgruparGridBoleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridBoleto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridBoleto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridBoleto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridBoleto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridBoleto.Location = New System.Drawing.Point(34, 461)
        Me.btnAgruparGridBoleto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridBoleto.Name = "btnAgruparGridBoleto"
        Me.btnAgruparGridBoleto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridBoleto.TabIndex = 41
        Me.btnAgruparGridBoleto.TabStop = False
        Me.btnAgruparGridBoleto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridBoleto
        '
        Me.btnConfigurarGridBoleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridBoleto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridBoleto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridBoleto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridBoleto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridBoleto.Location = New System.Drawing.Point(10, 461)
        Me.btnConfigurarGridBoleto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridBoleto.Name = "btnConfigurarGridBoleto"
        Me.btnConfigurarGridBoleto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridBoleto.TabIndex = 40
        Me.btnConfigurarGridBoleto.TabStop = False
        Me.btnConfigurarGridBoleto.UseVisualStyleBackColor = False
        '
        'txtValor
        '
        Me.txtValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(603, 88)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(71, 20)
        Me.txtValor.TabIndex = 38
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(600, 71)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 37
        Me.lblValor.Text = "Valor:"
        '
        'lblDataVencimento
        '
        Me.lblDataVencimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataVencimento.AutoSize = True
        Me.lblDataVencimento.Location = New System.Drawing.Point(506, 71)
        Me.lblDataVencimento.Name = "lblDataVencimento"
        Me.lblDataVencimento.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimento.TabIndex = 10
        Me.lblDataVencimento.Text = "Data Vencimento:"
        '
        'dtpDataVencimento
        '
        Me.dtpDataVencimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataVencimento.DropDownCalendar.Name = ""
        Me.dtpDataVencimento.Location = New System.Drawing.Point(509, 88)
        Me.dtpDataVencimento.Name = "dtpDataVencimento"
        Me.dtpDataVencimento.Size = New System.Drawing.Size(88, 20)
        Me.dtpDataVencimento.TabIndex = 36
        '
        'btnExcluirParcela
        '
        Me.btnExcluirParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirParcela.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirParcela.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirParcela.Location = New System.Drawing.Point(680, 85)
        Me.btnExcluirParcela.Name = "btnExcluirParcela"
        Me.btnExcluirParcela.Size = New System.Drawing.Size(105, 23)
        Me.btnExcluirParcela.TabIndex = 34
        Me.btnExcluirParcela.Text = "Excluir Parcela"
        Me.btnExcluirParcela.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAdicionarParcela
        '
        Me.btnAdicionarParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdicionarParcela.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnAdicionarParcela.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAdicionarParcela.Location = New System.Drawing.Point(791, 85)
        Me.btnAdicionarParcela.Name = "btnAdicionarParcela"
        Me.btnAdicionarParcela.Size = New System.Drawing.Size(105, 23)
        Me.btnAdicionarParcela.TabIndex = 33
        Me.btnAdicionarParcela.Text = "Inserir Parcela"
        Me.btnAdicionarParcela.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcelGridDeve
        '
        Me.btnExcelGridDeve.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridDeve.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridDeve.FlatAppearance.BorderSize = 0
        Me.btnExcelGridDeve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridDeve.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridDeve.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridDeve.Location = New System.Drawing.Point(559, 462)
        Me.btnExcelGridDeve.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridDeve.Name = "btnExcelGridDeve"
        Me.btnExcelGridDeve.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridDeve.TabIndex = 31
        Me.btnExcelGridDeve.TabStop = False
        Me.btnExcelGridDeve.UseVisualStyleBackColor = False
        '
        'btnAgrupaGridDeve
        '
        Me.btnAgrupaGridDeve.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgrupaGridDeve.BackColor = System.Drawing.Color.Transparent
        Me.btnAgrupaGridDeve.FlatAppearance.BorderSize = 0
        Me.btnAgrupaGridDeve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgrupaGridDeve.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgrupaGridDeve.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgrupaGridDeve.Location = New System.Drawing.Point(535, 462)
        Me.btnAgrupaGridDeve.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgrupaGridDeve.Name = "btnAgrupaGridDeve"
        Me.btnAgrupaGridDeve.Size = New System.Drawing.Size(24, 15)
        Me.btnAgrupaGridDeve.TabIndex = 30
        Me.btnAgrupaGridDeve.TabStop = False
        Me.btnAgrupaGridDeve.UseVisualStyleBackColor = False
        '
        'btnConfiguraGridDeve
        '
        Me.btnConfiguraGridDeve.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGridDeve.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGridDeve.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGridDeve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGridDeve.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfiguraGridDeve.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGridDeve.Location = New System.Drawing.Point(511, 462)
        Me.btnConfiguraGridDeve.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGridDeve.Name = "btnConfiguraGridDeve"
        Me.btnConfiguraGridDeve.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGridDeve.TabIndex = 29
        Me.btnConfiguraGridDeve.TabStop = False
        Me.btnConfiguraGridDeve.UseVisualStyleBackColor = False
        '
        'grdDeve
        '
        Me.grdDeve.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdDeve.AlternatingColors = True
        Me.grdDeve.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDeve.ColumnAutoResize = True
        grdDeve_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdDeve_DesignTimeLayout_Reference_0.Instance"), Object)
        grdDeve_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdDeve_DesignTimeLayout_Reference_0})
        grdDeve_DesignTimeLayout.LayoutString = resources.GetString("grdDeve_DesignTimeLayout.LayoutString")
        Me.grdDeve.DesignTimeLayout = grdDeve_DesignTimeLayout
        Me.grdDeve.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdDeve.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDeve.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDeve.GroupByBoxVisible = False
        Me.grdDeve.Location = New System.Drawing.Point(509, 114)
        Me.grdDeve.Name = "grdDeve"
        Me.grdDeve.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDeve.RecordNavigator = True
        Me.grdDeve.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDeve.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDeve.Size = New System.Drawing.Size(396, 364)
        Me.grdDeve.TabIndex = 28
        Me.grdDeve.TabStop = False
        Me.grdDeve.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdDeve.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdDeve.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDeve.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDeve.VisualStyleManager = Me.vsmMain
        '
        'btnExcelGridPago
        '
        Me.btnExcelGridPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPago.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPago.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPago.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPago.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPago.Location = New System.Drawing.Point(58, 259)
        Me.btnExcelGridPago.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPago.Name = "btnExcelGridPago"
        Me.btnExcelGridPago.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPago.TabIndex = 27
        Me.btnExcelGridPago.TabStop = False
        Me.btnExcelGridPago.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPago
        '
        Me.btnAgruparGridPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPago.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPago.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPago.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPago.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPago.Location = New System.Drawing.Point(34, 259)
        Me.btnAgruparGridPago.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPago.Name = "btnAgruparGridPago"
        Me.btnAgruparGridPago.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPago.TabIndex = 26
        Me.btnAgruparGridPago.TabStop = False
        Me.btnAgruparGridPago.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPago
        '
        Me.btnConfigurarGridPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPago.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPago.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPago.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPago.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPago.Location = New System.Drawing.Point(10, 259)
        Me.btnConfigurarGridPago.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPago.Name = "btnConfigurarGridPago"
        Me.btnConfigurarGridPago.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPago.TabIndex = 5
        Me.btnConfigurarGridPago.TabStop = False
        Me.btnConfigurarGridPago.UseVisualStyleBackColor = False
        '
        'grdPago
        '
        Me.grdPago.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPago.AlternatingColors = True
        Me.grdPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPago.ColumnAutoResize = True
        grdPago_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdPago_DesignTimeLayout_Reference_0.Instance"), Object)
        grdPago_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdPago_DesignTimeLayout_Reference_0})
        grdPago_DesignTimeLayout.LayoutString = resources.GetString("grdPago_DesignTimeLayout.LayoutString")
        Me.grdPago.DesignTimeLayout = grdPago_DesignTimeLayout
        Me.grdPago.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPago.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPago.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPago.GroupByBoxVisible = False
        Me.grdPago.Location = New System.Drawing.Point(8, 73)
        Me.grdPago.Name = "grdPago"
        Me.grdPago.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPago.RecordNavigator = True
        Me.grdPago.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPago.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPago.Size = New System.Drawing.Size(492, 203)
        Me.grdPago.TabIndex = 2
        Me.grdPago.TabStop = False
        Me.grdPago.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPago.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPago.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPago.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPago.VisualStyleManager = Me.vsmMain
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.lblTipoTitulo)
        Me.grpInformacoes.Controls.Add(Me.txtTipoTitulo)
        Me.grpInformacoes.Controls.Add(Me.txtTipoDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblTipoDocumento)
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
        'lblTipoTitulo
        '
        Me.lblTipoTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoTitulo.AutoSize = True
        Me.lblTipoTitulo.Location = New System.Drawing.Point(791, 17)
        Me.lblTipoTitulo.Name = "lblTipoTitulo"
        Me.lblTipoTitulo.Size = New System.Drawing.Size(73, 14)
        Me.lblTipoTitulo.TabIndex = 10
        Me.lblTipoTitulo.Text = "Tipo de Título:"
        '
        'txtTipoTitulo
        '
        Me.txtTipoTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoTitulo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipoTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoTitulo.Location = New System.Drawing.Point(794, 34)
        Me.txtTipoTitulo.MaxLength = 60
        Me.txtTipoTitulo.Name = "txtTipoTitulo"
        Me.txtTipoTitulo.ReadOnly = True
        Me.txtTipoTitulo.Size = New System.Drawing.Size(94, 20)
        Me.txtTipoTitulo.TabIndex = 11
        Me.txtTipoTitulo.TabStop = False
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoDocumento.Location = New System.Drawing.Point(673, 34)
        Me.txtTipoDocumento.MaxLength = 60
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.ReadOnly = True
        Me.txtTipoDocumento.Size = New System.Drawing.Size(115, 20)
        Me.txtTipoDocumento.TabIndex = 9
        Me.txtTipoDocumento.TabStop = False
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(670, 17)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(102, 14)
        Me.lblTipoDocumento.TabIndex = 8
        Me.lblTipoDocumento.Text = "Tipo de Documento:"
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
        Me.txtParceiroNegocio.Size = New System.Drawing.Size(402, 20)
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
        'grdBoleto
        '
        Me.grdBoleto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdBoleto.AlternatingColors = True
        Me.grdBoleto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBoleto.ColumnAutoResize = True
        grdBoleto_DesignTimeLayout.LayoutString = resources.GetString("grdBoleto_DesignTimeLayout.LayoutString")
        Me.grdBoleto.DesignTimeLayout = grdBoleto_DesignTimeLayout
        Me.grdBoleto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdBoleto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdBoleto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdBoleto.GroupByBoxVisible = False
        Me.grdBoleto.Location = New System.Drawing.Point(9, 282)
        Me.grdBoleto.Name = "grdBoleto"
        Me.grdBoleto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdBoleto.RecordNavigator = True
        Me.grdBoleto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdBoleto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdBoleto.Size = New System.Drawing.Size(492, 196)
        Me.grdBoleto.TabIndex = 39
        Me.grdBoleto.TabStop = False
        Me.grdBoleto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdBoleto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdBoleto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdBoleto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdBoleto.VisualStyleManager = Me.vsmMain
        '
        'usrFinReclassificacaoValor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinReclassificacaoValor"
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
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        Me.pagDados.PerformLayout()
        CType(Me.grdDeve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        CType(Me.grdBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
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
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grdPago As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents txtParceiroNegocio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents lblTipoTituloFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoTituloFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPago As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridPago As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPago As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridDeve As System.Windows.Forms.Button
    Friend WithEvents btnAgrupaGridDeve As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGridDeve As System.Windows.Forms.Button
    Friend WithEvents grdDeve As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtTipoDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents btnExcluirParcela As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAdicionarParcela As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataVencimento As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblTipoTitulo As System.Windows.Forms.Label
    Friend WithEvents txtTipoTitulo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblParcialmenteEntregue As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents picLegendaTipoOrcamento As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcelGridBoleto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridBoleto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridBoleto As System.Windows.Forms.Button
    Friend WithEvents grdBoleto As Janus.Windows.GridEX.GridEX

End Class
