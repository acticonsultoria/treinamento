<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadContrato
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadContrato))
        Dim grdOperacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOperacao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdServicoTerceiros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdServicoTerceiros_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarClienteFiltro = New System.Windows.Forms.Button()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataContratoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroContratoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroContratoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagProcessoProdutivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdOperacao = New Janus.Windows.GridEX.GridEX()
        Me.grpProcessoProdutivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCustoTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCustoTotal = New System.Windows.Forms.Label()
        Me.txtQuantidadeHoras = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeHoras = New System.Windows.Forms.Label()
        Me.txtValorFinal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFinal = New System.Windows.Forms.Label()
        Me.txtPorcentagemLucro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemLucro = New System.Windows.Forms.Label()
        Me.txtCustoHora = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCustoHora = New System.Windows.Forms.Label()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.btnExcluirOperacao = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirOperacao = New Janus.Windows.EditControls.UIButton()
        Me.pagServicoTerceiros = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdServicoTerceiros = New Janus.Windows.GridEX.GridEX()
        Me.grpServicoTerceiros = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblServicoTerceiros = New System.Windows.Forms.Label()
        Me.cboServicoTerceiros = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.cboGrupo = New Janus.Windows.EditControls.UIComboBox()
        Me.txtValorFinalServicoTerceiros = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFinalServicoTerceiros = New System.Windows.Forms.Label()
        Me.txtPorcentagemLucroServicoTerceiros = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemLucroServicoTerceiros = New System.Windows.Forms.Label()
        Me.txtValorServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorServico = New System.Windows.Forms.Label()
        Me.btnExcluirServicoTerceiros = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirServicoTerceiros = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaCSLL = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCSLL = New System.Windows.Forms.Label()
        Me.txtDespesaVariavel = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaVariavel = New System.Windows.Forms.Label()
        Me.txtAliquotaISS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaISS = New System.Windows.Forms.Label()
        Me.txtAliquotaIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIR = New System.Windows.Forms.Label()
        Me.txtAliquotaCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCOFINS = New System.Windows.Forms.Label()
        Me.txtDespesaFixa = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaFixa = New System.Windows.Forms.Label()
        Me.txtAliquotaPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPIS = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSReduzida = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMSReduzida = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMS = New System.Windows.Forms.Label()
        Me.txtAliquotaICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMS = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.btnCadastrarCliente = New System.Windows.Forms.Button()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.dtpDataContrato = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataContrato = New System.Windows.Forms.Label()
        Me.txtNumeroContrato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroContrato = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagProcessoProdutivo.SuspendLayout()
        CType(Me.grdOperacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProcessoProdutivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProcessoProdutivo.SuspendLayout()
        Me.pagServicoTerceiros.SuspendLayout()
        CType(Me.grdServicoTerceiros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpServicoTerceiros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServicoTerceiros.SuspendLayout()
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
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(973, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(971, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Contrato"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.CellToolTipText = "Duplo clique para editar o registro"
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(955, 314)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.cboClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataContratoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroContratoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroContratoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(955, 64)
        Me.grpFiltro.TabIndex = 1
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarClienteFiltro
        '
        Me.btnProcurarClienteFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarClienteFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarClienteFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarClienteFiltro.Location = New System.Drawing.Point(689, 16)
        Me.btnProcurarClienteFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarClienteFiltro.Name = "btnProcurarClienteFiltro"
        Me.btnProcurarClienteFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarClienteFiltro.TabIndex = 31
        Me.btnProcurarClienteFiltro.TabStop = False
        Me.btnProcurarClienteFiltro.UseVisualStyleBackColor = True
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.AutoSize = False
        Me.cboClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFiltro.Location = New System.Drawing.Point(307, 34)
        Me.cboClienteFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(400, 20)
        Me.cboClienteFiltro.TabIndex = 3
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(304, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 30
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.FirstMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(201, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 2
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.FirstMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(95, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataInicioFiltro.TabIndex = 1
        Me.dtpDataInicioFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataContratoFiltro
        '
        Me.lblDataContratoFiltro.AutoSize = True
        Me.lblDataContratoFiltro.Location = New System.Drawing.Point(92, 17)
        Me.lblDataContratoFiltro.Name = "lblDataContratoFiltro"
        Me.lblDataContratoFiltro.Size = New System.Drawing.Size(76, 14)
        Me.lblDataContratoFiltro.TabIndex = 27
        Me.lblDataContratoFiltro.Text = "Data Contrato:"
        '
        'txtNumeroContratoFiltro
        '
        Me.txtNumeroContratoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroContratoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroContratoFiltro.MaxLength = 100
        Me.txtNumeroContratoFiltro.Name = "txtNumeroContratoFiltro"
        Me.txtNumeroContratoFiltro.Size = New System.Drawing.Size(80, 20)
        Me.txtNumeroContratoFiltro.TabIndex = 0
        '
        'lblNumeroContratoFiltro
        '
        Me.lblNumeroContratoFiltro.AutoSize = True
        Me.lblNumeroContratoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroContratoFiltro.Name = "lblNumeroContratoFiltro"
        Me.lblNumeroContratoFiltro.Size = New System.Drawing.Size(65, 14)
        Me.lblNumeroContratoFiltro.TabIndex = 2
        Me.lblNumeroContratoFiltro.Text = "N° Contrato:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(855, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(955, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(661, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 0
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(855, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(758, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(971, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Contrato"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.Location = New System.Drawing.Point(8, 110)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(955, 277)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagProcessoProdutivo, Me.pagServicoTerceiros})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagProcessoProdutivo
        '
        Me.pagProcessoProdutivo.Controls.Add(Me.grdOperacao)
        Me.pagProcessoProdutivo.Controls.Add(Me.grpProcessoProdutivo)
        Me.pagProcessoProdutivo.Key = "pagProcessoProdutivo"
        Me.pagProcessoProdutivo.Location = New System.Drawing.Point(1, 22)
        Me.pagProcessoProdutivo.Name = "pagProcessoProdutivo"
        Me.pagProcessoProdutivo.Size = New System.Drawing.Size(953, 254)
        Me.pagProcessoProdutivo.TabStop = True
        Me.pagProcessoProdutivo.Text = "Processo Produtivo"
        '
        'grdOperacao
        '
        Me.grdOperacao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdOperacao.AlternatingColors = True
        Me.grdOperacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOperacao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdOperacao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdOperacao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdOperacao_DesignTimeLayout_Reference_0})
        grdOperacao_DesignTimeLayout.LayoutString = resources.GetString("grdOperacao_DesignTimeLayout.LayoutString")
        Me.grdOperacao.DesignTimeLayout = grdOperacao_DesignTimeLayout
        Me.grdOperacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOperacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOperacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOperacao.GroupByBoxVisible = False
        Me.grdOperacao.Location = New System.Drawing.Point(8, 78)
        Me.grdOperacao.Name = "grdOperacao"
        Me.grdOperacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOperacao.RecordNavigator = True
        Me.grdOperacao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdOperacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOperacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOperacao.Size = New System.Drawing.Size(937, 173)
        Me.grdOperacao.TabIndex = 3
        Me.grdOperacao.TabStop = False
        Me.grdOperacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOperacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOperacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOperacao.VisualStyleManager = Me.vsmMain
        '
        'grpProcessoProdutivo
        '
        Me.grpProcessoProdutivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProcessoProdutivo.BackColor = System.Drawing.Color.Transparent
        Me.grpProcessoProdutivo.Controls.Add(Me.txtCustoTotal)
        Me.grpProcessoProdutivo.Controls.Add(Me.lblCustoTotal)
        Me.grpProcessoProdutivo.Controls.Add(Me.txtQuantidadeHoras)
        Me.grpProcessoProdutivo.Controls.Add(Me.lblQuantidadeHoras)
        Me.grpProcessoProdutivo.Controls.Add(Me.txtValorFinal)
        Me.grpProcessoProdutivo.Controls.Add(Me.lblValorFinal)
        Me.grpProcessoProdutivo.Controls.Add(Me.txtPorcentagemLucro)
        Me.grpProcessoProdutivo.Controls.Add(Me.lblPorcentagemLucro)
        Me.grpProcessoProdutivo.Controls.Add(Me.txtCustoHora)
        Me.grpProcessoProdutivo.Controls.Add(Me.lblCustoHora)
        Me.grpProcessoProdutivo.Controls.Add(Me.cboOperacao)
        Me.grpProcessoProdutivo.Controls.Add(Me.lblOperacao)
        Me.grpProcessoProdutivo.Controls.Add(Me.btnExcluirOperacao)
        Me.grpProcessoProdutivo.Controls.Add(Me.btnInserirOperacao)
        Me.grpProcessoProdutivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProcessoProdutivo.Location = New System.Drawing.Point(8, 3)
        Me.grpProcessoProdutivo.Name = "grpProcessoProdutivo"
        Me.grpProcessoProdutivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProcessoProdutivo.Size = New System.Drawing.Size(937, 69)
        Me.grpProcessoProdutivo.TabIndex = 0
        Me.grpProcessoProdutivo.VisualStyleManager = Me.vsmMain
        '
        'txtCustoTotal
        '
        Me.txtCustoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCustoTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoTotal.DecimalDigits = 2
        Me.txtCustoTotal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCustoTotal.Location = New System.Drawing.Point(565, 34)
        Me.txtCustoTotal.Name = "txtCustoTotal"
        Me.txtCustoTotal.ReadOnly = True
        Me.txtCustoTotal.Size = New System.Drawing.Size(61, 20)
        Me.txtCustoTotal.TabIndex = 35
        Me.txtCustoTotal.TabStop = False
        Me.txtCustoTotal.Text = "0,00"
        Me.txtCustoTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCustoTotal
        '
        Me.lblCustoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustoTotal.AutoSize = True
        Me.lblCustoTotal.Location = New System.Drawing.Point(562, 17)
        Me.lblCustoTotal.Name = "lblCustoTotal"
        Me.lblCustoTotal.Size = New System.Drawing.Size(63, 14)
        Me.lblCustoTotal.TabIndex = 36
        Me.lblCustoTotal.Text = "Custo Total:"
        '
        'txtQuantidadeHoras
        '
        Me.txtQuantidadeHoras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeHoras.BackColor = System.Drawing.Color.White
        Me.txtQuantidadeHoras.DecimalDigits = 2
        Me.txtQuantidadeHoras.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtQuantidadeHoras.Location = New System.Drawing.Point(398, 34)
        Me.txtQuantidadeHoras.Name = "txtQuantidadeHoras"
        Me.txtQuantidadeHoras.Size = New System.Drawing.Size(94, 20)
        Me.txtQuantidadeHoras.TabIndex = 1
        Me.txtQuantidadeHoras.Text = "0,00"
        Me.txtQuantidadeHoras.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidadeHoras
        '
        Me.lblQuantidadeHoras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeHoras.AutoSize = True
        Me.lblQuantidadeHoras.Location = New System.Drawing.Point(395, 17)
        Me.lblQuantidadeHoras.Name = "lblQuantidadeHoras"
        Me.lblQuantidadeHoras.Size = New System.Drawing.Size(97, 14)
        Me.lblQuantidadeHoras.TabIndex = 34
        Me.lblQuantidadeHoras.Text = "Quantidade Horas:"
        '
        'txtValorFinal
        '
        Me.txtValorFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorFinal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorFinal.DecimalDigits = 2
        Me.txtValorFinal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtValorFinal.Location = New System.Drawing.Point(686, 34)
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.ReadOnly = True
        Me.txtValorFinal.Size = New System.Drawing.Size(57, 20)
        Me.txtValorFinal.TabIndex = 4
        Me.txtValorFinal.TabStop = False
        Me.txtValorFinal.Text = "0,00"
        Me.txtValorFinal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFinal
        '
        Me.lblValorFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblValorFinal.AutoSize = True
        Me.lblValorFinal.Location = New System.Drawing.Point(683, 17)
        Me.lblValorFinal.Name = "lblValorFinal"
        Me.lblValorFinal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorFinal.TabIndex = 32
        Me.lblValorFinal.Text = "Valor Final:"
        '
        'txtPorcentagemLucro
        '
        Me.txtPorcentagemLucro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorcentagemLucro.BackColor = System.Drawing.Color.White
        Me.txtPorcentagemLucro.DecimalDigits = 2
        Me.txtPorcentagemLucro.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPorcentagemLucro.Location = New System.Drawing.Point(632, 34)
        Me.txtPorcentagemLucro.Name = "txtPorcentagemLucro"
        Me.txtPorcentagemLucro.Size = New System.Drawing.Size(48, 20)
        Me.txtPorcentagemLucro.TabIndex = 3
        Me.txtPorcentagemLucro.Text = "0,00"
        Me.txtPorcentagemLucro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemLucro
        '
        Me.lblPorcentagemLucro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPorcentagemLucro.AutoSize = True
        Me.lblPorcentagemLucro.Location = New System.Drawing.Point(629, 17)
        Me.lblPorcentagemLucro.Name = "lblPorcentagemLucro"
        Me.lblPorcentagemLucro.Size = New System.Drawing.Size(51, 14)
        Me.lblPorcentagemLucro.TabIndex = 26
        Me.lblPorcentagemLucro.Text = "% Lucro:"
        '
        'txtCustoHora
        '
        Me.txtCustoHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCustoHora.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoHora.DecimalDigits = 2
        Me.txtCustoHora.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCustoHora.Location = New System.Drawing.Point(498, 34)
        Me.txtCustoHora.Name = "txtCustoHora"
        Me.txtCustoHora.ReadOnly = True
        Me.txtCustoHora.Size = New System.Drawing.Size(61, 20)
        Me.txtCustoHora.TabIndex = 2
        Me.txtCustoHora.TabStop = False
        Me.txtCustoHora.Text = "0,00"
        Me.txtCustoHora.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCustoHora
        '
        Me.lblCustoHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustoHora.AutoSize = True
        Me.lblCustoHora.Location = New System.Drawing.Point(495, 17)
        Me.lblCustoHora.Name = "lblCustoHora"
        Me.lblCustoHora.Size = New System.Drawing.Size(64, 14)
        Me.lblCustoHora.TabIndex = 22
        Me.lblCustoHora.Text = "Custo Hora:"
        '
        'cboOperacao
        '
        Me.cboOperacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOperacao.AutoSize = False
        Me.cboOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOperacao.Location = New System.Drawing.Point(9, 34)
        Me.cboOperacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOperacao.Size = New System.Drawing.Size(383, 20)
        Me.cboOperacao.TabIndex = 0
        '
        'lblOperacao
        '
        Me.lblOperacao.AutoSize = True
        Me.lblOperacao.Location = New System.Drawing.Point(6, 17)
        Me.lblOperacao.Name = "lblOperacao"
        Me.lblOperacao.Size = New System.Drawing.Size(58, 14)
        Me.lblOperacao.TabIndex = 21
        Me.lblOperacao.Text = "Operação:"
        '
        'btnExcluirOperacao
        '
        Me.btnExcluirOperacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirOperacao.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirOperacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirOperacao.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirOperacao.Location = New System.Drawing.Point(840, 41)
        Me.btnExcluirOperacao.Name = "btnExcluirOperacao"
        Me.btnExcluirOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirOperacao.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirOperacao.TabIndex = 6
        Me.btnExcluirOperacao.Text = "Excluir"
        Me.btnExcluirOperacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirOperacao
        '
        Me.btnInserirOperacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirOperacao.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirOperacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirOperacao.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirOperacao.Location = New System.Drawing.Point(840, 12)
        Me.btnInserirOperacao.Name = "btnInserirOperacao"
        Me.btnInserirOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirOperacao.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirOperacao.TabIndex = 5
        Me.btnInserirOperacao.Text = "Inserir"
        Me.btnInserirOperacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagServicoTerceiros
        '
        Me.pagServicoTerceiros.Controls.Add(Me.grdServicoTerceiros)
        Me.pagServicoTerceiros.Controls.Add(Me.grpServicoTerceiros)
        Me.pagServicoTerceiros.Key = "pagServicoTerceiros"
        Me.pagServicoTerceiros.Location = New System.Drawing.Point(1, 22)
        Me.pagServicoTerceiros.Name = "pagServicoTerceiros"
        Me.pagServicoTerceiros.Size = New System.Drawing.Size(953, 254)
        Me.pagServicoTerceiros.TabStop = True
        Me.pagServicoTerceiros.Text = "Serviço de Terceiros"
        '
        'grdServicoTerceiros
        '
        Me.grdServicoTerceiros.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdServicoTerceiros.AlternatingColors = True
        Me.grdServicoTerceiros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdServicoTerceiros_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdServicoTerceiros_DesignTimeLayout_Reference_0.Instance"), Object)
        grdServicoTerceiros_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdServicoTerceiros_DesignTimeLayout_Reference_0})
        grdServicoTerceiros_DesignTimeLayout.LayoutString = resources.GetString("grdServicoTerceiros_DesignTimeLayout.LayoutString")
        Me.grdServicoTerceiros.DesignTimeLayout = grdServicoTerceiros_DesignTimeLayout
        Me.grdServicoTerceiros.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdServicoTerceiros.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdServicoTerceiros.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdServicoTerceiros.GroupByBoxVisible = False
        Me.grdServicoTerceiros.Location = New System.Drawing.Point(8, 78)
        Me.grdServicoTerceiros.Name = "grdServicoTerceiros"
        Me.grdServicoTerceiros.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdServicoTerceiros.RecordNavigator = True
        Me.grdServicoTerceiros.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdServicoTerceiros.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdServicoTerceiros.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdServicoTerceiros.Size = New System.Drawing.Size(937, 173)
        Me.grdServicoTerceiros.TabIndex = 4
        Me.grdServicoTerceiros.TabStop = False
        Me.grdServicoTerceiros.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdServicoTerceiros.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdServicoTerceiros.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdServicoTerceiros.VisualStyleManager = Me.vsmMain
        '
        'grpServicoTerceiros
        '
        Me.grpServicoTerceiros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpServicoTerceiros.BackColor = System.Drawing.Color.Transparent
        Me.grpServicoTerceiros.Controls.Add(Me.lblServicoTerceiros)
        Me.grpServicoTerceiros.Controls.Add(Me.cboServicoTerceiros)
        Me.grpServicoTerceiros.Controls.Add(Me.lblGrupo)
        Me.grpServicoTerceiros.Controls.Add(Me.cboGrupo)
        Me.grpServicoTerceiros.Controls.Add(Me.txtValorFinalServicoTerceiros)
        Me.grpServicoTerceiros.Controls.Add(Me.lblValorFinalServicoTerceiros)
        Me.grpServicoTerceiros.Controls.Add(Me.txtPorcentagemLucroServicoTerceiros)
        Me.grpServicoTerceiros.Controls.Add(Me.lblPorcentagemLucroServicoTerceiros)
        Me.grpServicoTerceiros.Controls.Add(Me.txtValorServico)
        Me.grpServicoTerceiros.Controls.Add(Me.lblValorServico)
        Me.grpServicoTerceiros.Controls.Add(Me.btnExcluirServicoTerceiros)
        Me.grpServicoTerceiros.Controls.Add(Me.btnInserirServicoTerceiros)
        Me.grpServicoTerceiros.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpServicoTerceiros.Location = New System.Drawing.Point(8, 3)
        Me.grpServicoTerceiros.Name = "grpServicoTerceiros"
        Me.grpServicoTerceiros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpServicoTerceiros.Size = New System.Drawing.Size(937, 69)
        Me.grpServicoTerceiros.TabIndex = 0
        Me.grpServicoTerceiros.VisualStyleManager = Me.vsmMain
        '
        'lblServicoTerceiros
        '
        Me.lblServicoTerceiros.AutoSize = True
        Me.lblServicoTerceiros.Location = New System.Drawing.Point(216, 17)
        Me.lblServicoTerceiros.Name = "lblServicoTerceiros"
        Me.lblServicoTerceiros.Size = New System.Drawing.Size(107, 14)
        Me.lblServicoTerceiros.TabIndex = 36
        Me.lblServicoTerceiros.Text = "Serviço de Terceiros"
        '
        'cboServicoTerceiros
        '
        Me.cboServicoTerceiros.AutoSize = False
        Me.cboServicoTerceiros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboServicoTerceiros.Location = New System.Drawing.Point(219, 34)
        Me.cboServicoTerceiros.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboServicoTerceiros.Name = "cboServicoTerceiros"
        Me.cboServicoTerceiros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboServicoTerceiros.Size = New System.Drawing.Size(358, 20)
        Me.cboServicoTerceiros.TabIndex = 1
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(6, 17)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(40, 14)
        Me.lblGrupo.TabIndex = 35
        Me.lblGrupo.Text = "Grupo:"
        '
        'cboGrupo
        '
        Me.cboGrupo.AutoSize = False
        Me.cboGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupo.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupo.Size = New System.Drawing.Size(204, 20)
        Me.cboGrupo.TabIndex = 0
        '
        'txtValorFinalServicoTerceiros
        '
        Me.txtValorFinalServicoTerceiros.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorFinalServicoTerceiros.DecimalDigits = 2
        Me.txtValorFinalServicoTerceiros.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtValorFinalServicoTerceiros.Location = New System.Drawing.Point(716, 34)
        Me.txtValorFinalServicoTerceiros.Name = "txtValorFinalServicoTerceiros"
        Me.txtValorFinalServicoTerceiros.ReadOnly = True
        Me.txtValorFinalServicoTerceiros.Size = New System.Drawing.Size(57, 20)
        Me.txtValorFinalServicoTerceiros.TabIndex = 5
        Me.txtValorFinalServicoTerceiros.TabStop = False
        Me.txtValorFinalServicoTerceiros.Text = "0,00"
        Me.txtValorFinalServicoTerceiros.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFinalServicoTerceiros
        '
        Me.lblValorFinalServicoTerceiros.AutoSize = True
        Me.lblValorFinalServicoTerceiros.Location = New System.Drawing.Point(713, 17)
        Me.lblValorFinalServicoTerceiros.Name = "lblValorFinalServicoTerceiros"
        Me.lblValorFinalServicoTerceiros.Size = New System.Drawing.Size(60, 14)
        Me.lblValorFinalServicoTerceiros.TabIndex = 32
        Me.lblValorFinalServicoTerceiros.Text = "Valor Final:"
        '
        'txtPorcentagemLucroServicoTerceiros
        '
        Me.txtPorcentagemLucroServicoTerceiros.BackColor = System.Drawing.Color.White
        Me.txtPorcentagemLucroServicoTerceiros.DecimalDigits = 2
        Me.txtPorcentagemLucroServicoTerceiros.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPorcentagemLucroServicoTerceiros.Location = New System.Drawing.Point(662, 34)
        Me.txtPorcentagemLucroServicoTerceiros.Name = "txtPorcentagemLucroServicoTerceiros"
        Me.txtPorcentagemLucroServicoTerceiros.Size = New System.Drawing.Size(48, 20)
        Me.txtPorcentagemLucroServicoTerceiros.TabIndex = 4
        Me.txtPorcentagemLucroServicoTerceiros.Text = "0,00"
        Me.txtPorcentagemLucroServicoTerceiros.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemLucroServicoTerceiros
        '
        Me.lblPorcentagemLucroServicoTerceiros.AutoSize = True
        Me.lblPorcentagemLucroServicoTerceiros.Location = New System.Drawing.Point(659, 17)
        Me.lblPorcentagemLucroServicoTerceiros.Name = "lblPorcentagemLucroServicoTerceiros"
        Me.lblPorcentagemLucroServicoTerceiros.Size = New System.Drawing.Size(51, 14)
        Me.lblPorcentagemLucroServicoTerceiros.TabIndex = 26
        Me.lblPorcentagemLucroServicoTerceiros.Text = "% Lucro:"
        '
        'txtValorServico
        '
        Me.txtValorServico.BackColor = System.Drawing.Color.White
        Me.txtValorServico.DecimalDigits = 2
        Me.txtValorServico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtValorServico.Location = New System.Drawing.Point(583, 34)
        Me.txtValorServico.Name = "txtValorServico"
        Me.txtValorServico.Size = New System.Drawing.Size(73, 20)
        Me.txtValorServico.TabIndex = 2
        Me.txtValorServico.Text = "0,00"
        Me.txtValorServico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorServico
        '
        Me.lblValorServico.AutoSize = True
        Me.lblValorServico.Location = New System.Drawing.Point(580, 17)
        Me.lblValorServico.Name = "lblValorServico"
        Me.lblValorServico.Size = New System.Drawing.Size(75, 14)
        Me.lblValorServico.TabIndex = 22
        Me.lblValorServico.Text = "Valor Serviço:"
        '
        'btnExcluirServicoTerceiros
        '
        Me.btnExcluirServicoTerceiros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirServicoTerceiros.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirServicoTerceiros.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirServicoTerceiros.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirServicoTerceiros.Location = New System.Drawing.Point(840, 41)
        Me.btnExcluirServicoTerceiros.Name = "btnExcluirServicoTerceiros"
        Me.btnExcluirServicoTerceiros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirServicoTerceiros.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirServicoTerceiros.TabIndex = 7
        Me.btnExcluirServicoTerceiros.Text = "Excluir"
        Me.btnExcluirServicoTerceiros.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirServicoTerceiros
        '
        Me.btnInserirServicoTerceiros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirServicoTerceiros.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirServicoTerceiros.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirServicoTerceiros.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirServicoTerceiros.Location = New System.Drawing.Point(840, 12)
        Me.btnInserirServicoTerceiros.Name = "btnInserirServicoTerceiros"
        Me.btnInserirServicoTerceiros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirServicoTerceiros.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirServicoTerceiros.TabIndex = 6
        Me.btnInserirServicoTerceiros.Text = "Inserir"
        Me.btnInserirServicoTerceiros.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(955, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(661, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(855, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        Me.btnSalvar.Location = New System.Drawing.Point(758, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtAliquotaCSLL)
        Me.grpDados.Controls.Add(Me.lblAliquotaCSLL)
        Me.grpDados.Controls.Add(Me.txtDespesaVariavel)
        Me.grpDados.Controls.Add(Me.lblDespesaVariavel)
        Me.grpDados.Controls.Add(Me.txtAliquotaISS)
        Me.grpDados.Controls.Add(Me.lblAliquotaISS)
        Me.grpDados.Controls.Add(Me.txtAliquotaIR)
        Me.grpDados.Controls.Add(Me.lblAliquotaIR)
        Me.grpDados.Controls.Add(Me.txtAliquotaCOFINS)
        Me.grpDados.Controls.Add(Me.lblAliquotaCOFINS)
        Me.grpDados.Controls.Add(Me.txtDespesaFixa)
        Me.grpDados.Controls.Add(Me.lblDespesaFixa)
        Me.grpDados.Controls.Add(Me.txtAliquotaPIS)
        Me.grpDados.Controls.Add(Me.lblAliquotaPIS)
        Me.grpDados.Controls.Add(Me.txtAliquotaICMSReduzida)
        Me.grpDados.Controls.Add(Me.lblAliquotaICMSReduzida)
        Me.grpDados.Controls.Add(Me.txtPorcentagemReducaoBCICMS)
        Me.grpDados.Controls.Add(Me.lblPorcentagemReducaoBCICMS)
        Me.grpDados.Controls.Add(Me.txtAliquotaICMS)
        Me.grpDados.Controls.Add(Me.lblAliquotaICMS)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.btnCadastrarCliente)
        Me.grpDados.Controls.Add(Me.btnProcurarCliente)
        Me.grpDados.Controls.Add(Me.cboCliente)
        Me.grpDados.Controls.Add(Me.lblCliente)
        Me.grpDados.Controls.Add(Me.dtpDataContrato)
        Me.grpDados.Controls.Add(Me.lblDataContrato)
        Me.grpDados.Controls.Add(Me.txtNumeroContrato)
        Me.grpDados.Controls.Add(Me.lblNumeroContrato)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(955, 101)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaCSLL
        '
        Me.txtAliquotaCSLL.DecimalDigits = 2
        Me.txtAliquotaCSLL.Location = New System.Drawing.Point(673, 75)
        Me.txtAliquotaCSLL.Name = "txtAliquotaCSLL"
        Me.txtAliquotaCSLL.Size = New System.Drawing.Size(75, 20)
        Me.txtAliquotaCSLL.TabIndex = 11
        Me.txtAliquotaCSLL.Text = "0,00"
        Me.txtAliquotaCSLL.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCSLL
        '
        Me.lblAliquotaCSLL.AutoSize = True
        Me.lblAliquotaCSLL.Location = New System.Drawing.Point(670, 58)
        Me.lblAliquotaCSLL.Name = "lblAliquotaCSLL"
        Me.lblAliquotaCSLL.Size = New System.Drawing.Size(78, 14)
        Me.lblAliquotaCSLL.TabIndex = 32
        Me.lblAliquotaCSLL.Text = "Alíquota CSLL:"
        '
        'txtDespesaVariavel
        '
        Me.txtDespesaVariavel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDespesaVariavel.DecimalDigits = 2
        Me.txtDespesaVariavel.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDespesaVariavel.Location = New System.Drawing.Point(754, 75)
        Me.txtDespesaVariavel.Name = "txtDespesaVariavel"
        Me.txtDespesaVariavel.ReadOnly = True
        Me.txtDespesaVariavel.Size = New System.Drawing.Size(105, 20)
        Me.txtDespesaVariavel.TabIndex = 12
        Me.txtDespesaVariavel.TabStop = False
        Me.txtDespesaVariavel.Text = "0,00"
        Me.txtDespesaVariavel.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDespesaVariavel
        '
        Me.lblDespesaVariavel.AutoSize = True
        Me.lblDespesaVariavel.Location = New System.Drawing.Point(751, 58)
        Me.lblDespesaVariavel.Name = "lblDespesaVariavel"
        Me.lblDespesaVariavel.Size = New System.Drawing.Size(108, 14)
        Me.lblDespesaVariavel.TabIndex = 30
        Me.lblDespesaVariavel.Text = "% Despesa Variável:"
        '
        'txtAliquotaISS
        '
        Me.txtAliquotaISS.Location = New System.Drawing.Point(500, 75)
        Me.txtAliquotaISS.Name = "txtAliquotaISS"
        Me.txtAliquotaISS.Size = New System.Drawing.Size(86, 20)
        Me.txtAliquotaISS.TabIndex = 9
        Me.txtAliquotaISS.Text = "0,00"
        Me.txtAliquotaISS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaISS
        '
        Me.lblAliquotaISS.AutoSize = True
        Me.lblAliquotaISS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaISS.Location = New System.Drawing.Point(497, 58)
        Me.lblAliquotaISS.Name = "lblAliquotaISS"
        Me.lblAliquotaISS.Size = New System.Drawing.Size(68, 14)
        Me.lblAliquotaISS.TabIndex = 43
        Me.lblAliquotaISS.Text = "Alíquota ISS:"
        '
        'txtAliquotaIR
        '
        Me.txtAliquotaIR.DecimalDigits = 2
        Me.txtAliquotaIR.Location = New System.Drawing.Point(592, 75)
        Me.txtAliquotaIR.Name = "txtAliquotaIR"
        Me.txtAliquotaIR.Size = New System.Drawing.Size(75, 20)
        Me.txtAliquotaIR.TabIndex = 10
        Me.txtAliquotaIR.Text = "0,00"
        Me.txtAliquotaIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIR
        '
        Me.lblAliquotaIR.AutoSize = True
        Me.lblAliquotaIR.Location = New System.Drawing.Point(589, 58)
        Me.lblAliquotaIR.Name = "lblAliquotaIR"
        Me.lblAliquotaIR.Size = New System.Drawing.Size(61, 14)
        Me.lblAliquotaIR.TabIndex = 31
        Me.lblAliquotaIR.Text = "Alíquota IR:"
        '
        'txtAliquotaCOFINS
        '
        Me.txtAliquotaCOFINS.Location = New System.Drawing.Point(407, 75)
        Me.txtAliquotaCOFINS.Name = "txtAliquotaCOFINS"
        Me.txtAliquotaCOFINS.Size = New System.Drawing.Size(87, 20)
        Me.txtAliquotaCOFINS.TabIndex = 8
        Me.txtAliquotaCOFINS.Text = "0,00"
        Me.txtAliquotaCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCOFINS
        '
        Me.lblAliquotaCOFINS.AutoSize = True
        Me.lblAliquotaCOFINS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaCOFINS.Location = New System.Drawing.Point(404, 58)
        Me.lblAliquotaCOFINS.Name = "lblAliquotaCOFINS"
        Me.lblAliquotaCOFINS.Size = New System.Drawing.Size(89, 14)
        Me.lblAliquotaCOFINS.TabIndex = 38
        Me.lblAliquotaCOFINS.Text = "Alíquota COFINS:"
        '
        'txtDespesaFixa
        '
        Me.txtDespesaFixa.BackColor = System.Drawing.Color.White
        Me.txtDespesaFixa.DecimalDigits = 2
        Me.txtDespesaFixa.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDespesaFixa.Location = New System.Drawing.Point(865, 75)
        Me.txtDespesaFixa.Name = "txtDespesaFixa"
        Me.txtDespesaFixa.Size = New System.Drawing.Size(84, 20)
        Me.txtDespesaFixa.TabIndex = 13
        Me.txtDespesaFixa.Text = "0,00"
        Me.txtDespesaFixa.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDespesaFixa
        '
        Me.lblDespesaFixa.AutoSize = True
        Me.lblDespesaFixa.Location = New System.Drawing.Point(862, 58)
        Me.lblDespesaFixa.Name = "lblDespesaFixa"
        Me.lblDespesaFixa.Size = New System.Drawing.Size(89, 14)
        Me.lblDespesaFixa.TabIndex = 24
        Me.lblDespesaFixa.Text = "% Despesa Fixa:"
        '
        'txtAliquotaPIS
        '
        Me.txtAliquotaPIS.Location = New System.Drawing.Point(337, 75)
        Me.txtAliquotaPIS.Name = "txtAliquotaPIS"
        Me.txtAliquotaPIS.Size = New System.Drawing.Size(64, 20)
        Me.txtAliquotaPIS.TabIndex = 7
        Me.txtAliquotaPIS.Text = "0,00"
        Me.txtAliquotaPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPIS
        '
        Me.lblAliquotaPIS.AutoSize = True
        Me.lblAliquotaPIS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaPIS.Location = New System.Drawing.Point(334, 58)
        Me.lblAliquotaPIS.Name = "lblAliquotaPIS"
        Me.lblAliquotaPIS.Size = New System.Drawing.Size(67, 14)
        Me.lblAliquotaPIS.TabIndex = 39
        Me.lblAliquotaPIS.Text = "Alíquota PIS:"
        '
        'txtAliquotaICMSReduzida
        '
        Me.txtAliquotaICMSReduzida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaICMSReduzida.DecimalDigits = 2
        Me.txtAliquotaICMSReduzida.Location = New System.Drawing.Point(211, 75)
        Me.txtAliquotaICMSReduzida.Name = "txtAliquotaICMSReduzida"
        Me.txtAliquotaICMSReduzida.ReadOnly = True
        Me.txtAliquotaICMSReduzida.Size = New System.Drawing.Size(120, 20)
        Me.txtAliquotaICMSReduzida.TabIndex = 6
        Me.txtAliquotaICMSReduzida.TabStop = False
        Me.txtAliquotaICMSReduzida.Text = "0,00"
        Me.txtAliquotaICMSReduzida.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSReduzida
        '
        Me.lblAliquotaICMSReduzida.AutoSize = True
        Me.lblAliquotaICMSReduzida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaICMSReduzida.Location = New System.Drawing.Point(208, 58)
        Me.lblAliquotaICMSReduzida.Name = "lblAliquotaICMSReduzida"
        Me.lblAliquotaICMSReduzida.Size = New System.Drawing.Size(124, 14)
        Me.lblAliquotaICMSReduzida.TabIndex = 37
        Me.lblAliquotaICMSReduzida.Text = "Alíquota ICMS Reduzida:"
        '
        'txtPorcentagemReducaoBCICMS
        '
        Me.txtPorcentagemReducaoBCICMS.DecimalDigits = 2
        Me.txtPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(9, 75)
        Me.txtPorcentagemReducaoBCICMS.Name = "txtPorcentagemReducaoBCICMS"
        Me.txtPorcentagemReducaoBCICMS.Size = New System.Drawing.Size(107, 20)
        Me.txtPorcentagemReducaoBCICMS.TabIndex = 4
        Me.txtPorcentagemReducaoBCICMS.Text = "0,00"
        Me.txtPorcentagemReducaoBCICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemReducaoBCICMS
        '
        Me.lblPorcentagemReducaoBCICMS.AutoSize = True
        Me.lblPorcentagemReducaoBCICMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(6, 58)
        Me.lblPorcentagemReducaoBCICMS.Name = "lblPorcentagemReducaoBCICMS"
        Me.lblPorcentagemReducaoBCICMS.Size = New System.Drawing.Size(110, 14)
        Me.lblPorcentagemReducaoBCICMS.TabIndex = 35
        Me.lblPorcentagemReducaoBCICMS.Text = "% Redução BC ICMS:"
        '
        'txtAliquotaICMS
        '
        Me.txtAliquotaICMS.Location = New System.Drawing.Point(122, 75)
        Me.txtAliquotaICMS.Name = "txtAliquotaICMS"
        Me.txtAliquotaICMS.Size = New System.Drawing.Size(83, 20)
        Me.txtAliquotaICMS.TabIndex = 5
        Me.txtAliquotaICMS.Text = "0,00"
        Me.txtAliquotaICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMS
        '
        Me.lblAliquotaICMS.AutoSize = True
        Me.lblAliquotaICMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaICMS.Location = New System.Drawing.Point(119, 58)
        Me.lblAliquotaICMS.Name = "lblAliquotaICMS"
        Me.lblAliquotaICMS.Size = New System.Drawing.Size(76, 14)
        Me.lblAliquotaICMS.TabIndex = 34
        Me.lblAliquotaICMS.Text = "Alíquota ICMS:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(592, 34)
        Me.txtDescricao.MaxLength = 500
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(357, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(589, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 31
        Me.lblDescricao.Text = "Descrição:"
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCliente.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCliente.Location = New System.Drawing.Point(211, 16)
        Me.btnCadastrarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCliente.TabIndex = 29
        Me.btnCadastrarCliente.TabStop = False
        Me.btnCadastrarCliente.UseVisualStyleBackColor = True
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(568, 16)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 28
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'cboCliente
        '
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(211, 34)
        Me.cboCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(375, 20)
        Me.cboCliente.TabIndex = 2
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(227, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.Text = "Cliente:"
        '
        'dtpDataContrato
        '
        '
        '
        '
        Me.dtpDataContrato.DropDownCalendar.FirstMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.dtpDataContrato.DropDownCalendar.Name = ""
        Me.dtpDataContrato.Location = New System.Drawing.Point(122, 34)
        Me.dtpDataContrato.Name = "dtpDataContrato"
        Me.dtpDataContrato.Size = New System.Drawing.Size(83, 20)
        Me.dtpDataContrato.TabIndex = 1
        Me.dtpDataContrato.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataContrato
        '
        Me.lblDataContrato.AutoSize = True
        Me.lblDataContrato.Location = New System.Drawing.Point(119, 17)
        Me.lblDataContrato.Name = "lblDataContrato"
        Me.lblDataContrato.Size = New System.Drawing.Size(76, 14)
        Me.lblDataContrato.TabIndex = 25
        Me.lblDataContrato.Text = "Data Contrato:"
        '
        'txtNumeroContrato
        '
        Me.txtNumeroContrato.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroContrato.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroContrato.MaxLength = 100
        Me.txtNumeroContrato.Name = "txtNumeroContrato"
        Me.txtNumeroContrato.ReadOnly = True
        Me.txtNumeroContrato.Size = New System.Drawing.Size(107, 20)
        Me.txtNumeroContrato.TabIndex = 0
        Me.txtNumeroContrato.TabStop = False
        Me.txtNumeroContrato.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroContrato
        '
        Me.lblNumeroContrato.AutoSize = True
        Me.lblNumeroContrato.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroContrato.Name = "lblNumeroContrato"
        Me.lblNumeroContrato.Size = New System.Drawing.Size(65, 14)
        Me.lblNumeroContrato.TabIndex = 2
        Me.lblNumeroContrato.Text = "N° Contrato:"
        '
        'usrCadContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadContrato"
        Me.Size = New System.Drawing.Size(973, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagProcessoProdutivo.ResumeLayout(False)
        CType(Me.grdOperacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProcessoProdutivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProcessoProdutivo.ResumeLayout(False)
        Me.grpProcessoProdutivo.PerformLayout()
        Me.pagServicoTerceiros.ResumeLayout(False)
        CType(Me.grdServicoTerceiros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpServicoTerceiros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServicoTerceiros.ResumeLayout(False)
        Me.grpServicoTerceiros.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroContrato As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNumeroContratoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroContrato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroContratoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdOperacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpProcessoProdutivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirOperacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirOperacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents dtpDataContrato As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataContrato As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarCliente As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtCustoHora As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCustoHora As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemLucro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemLucro As System.Windows.Forms.Label
    Friend WithEvents txtDespesaFixa As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaFixa As System.Windows.Forms.Label
    Friend WithEvents txtDespesaVariavel As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaVariavel As System.Windows.Forms.Label
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataContratoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnProcurarClienteFiltro As System.Windows.Forms.Button
    Friend WithEvents txtAliquotaICMSReduzida As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMSReduzida As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemReducaoBCICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemReducaoBCICMS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaISS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaISS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPIS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCSLL As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCSLL As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIR As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIR As System.Windows.Forms.Label
    Friend WithEvents txtValorFinal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFinal As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagProcessoProdutivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagServicoTerceiros As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdServicoTerceiros As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpServicoTerceiros As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorFinalServicoTerceiros As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFinalServicoTerceiros As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemLucroServicoTerceiros As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemLucroServicoTerceiros As System.Windows.Forms.Label
    Friend WithEvents btnExcluirServicoTerceiros As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirServicoTerceiros As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblServicoTerceiros As System.Windows.Forms.Label
    Friend WithEvents cboServicoTerceiros As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents cboGrupo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorServico As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeHoras As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeHoras As System.Windows.Forms.Label
    Friend WithEvents txtCustoTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCustoTotal As System.Windows.Forms.Label

End Class
