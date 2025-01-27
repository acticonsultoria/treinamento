<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadContratoCambio
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
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadContratoCambio))
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem9 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem10 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem11 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem12 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblInstituicaoFinanceiraFiltro = New System.Windows.Forms.Label()
        Me.cboInstituicaoFinanceiraFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroContratoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroContratoFiltro = New System.Windows.Forms.Label()
        Me.lblBancoFiltro = New System.Windows.Forms.Label()
        Me.cboBancoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboMoedaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMoedaFiltro = New System.Windows.Forms.Label()
        Me.lblTipoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnLista = New Janus.Windows.EditControls.UIButton()
        Me.btnGrafico = New Janus.Windows.EditControls.UIButton()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.chrDados = New Dundas.Charting.WinControl.Chart()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarInstituicaoFinanceira = New System.Windows.Forms.Button()
        Me.btnCadastrarBanco = New System.Windows.Forms.Button()
        Me.txtValorOperacaoMoedaCorrente = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOperacaoMoedaCorrente = New System.Windows.Forms.Label()
        Me.txtValorOperacao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorOperacao = New System.Windows.Forms.Label()
        Me.lblInstituicaoFinanceira = New System.Windows.Forms.Label()
        Me.cboInstituicaoFinanceira = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblData = New System.Windows.Forms.Label()
        Me.txtNumeroContrato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroContrato = New System.Windows.Forms.Label()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.cboBanco = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFatorCambial = New System.Windows.Forms.Label()
        Me.txtFatorCambial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboMoeda = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMoeda = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.chrDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.chrDados)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Contrato de Cambio"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 365)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblInstituicaoFinanceiraFiltro)
        Me.grpFiltro.Controls.Add(Me.cboInstituicaoFinanceiraFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroContratoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroContratoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblBancoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboBancoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboMoedaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMoedaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblInstituicaoFinanceiraFiltro
        '
        Me.lblInstituicaoFinanceiraFiltro.AutoSize = True
        Me.lblInstituicaoFinanceiraFiltro.Location = New System.Drawing.Point(360, 57)
        Me.lblInstituicaoFinanceiraFiltro.Name = "lblInstituicaoFinanceiraFiltro"
        Me.lblInstituicaoFinanceiraFiltro.Size = New System.Drawing.Size(111, 14)
        Me.lblInstituicaoFinanceiraFiltro.TabIndex = 11
        Me.lblInstituicaoFinanceiraFiltro.Text = "Instituição Financeira:"
        '
        'cboInstituicaoFinanceiraFiltro
        '
        Me.cboInstituicaoFinanceiraFiltro.AutoSize = False
        Me.cboInstituicaoFinanceiraFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboInstituicaoFinanceiraFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboInstituicaoFinanceiraFiltro.Location = New System.Drawing.Point(363, 74)
        Me.cboInstituicaoFinanceiraFiltro.Name = "cboInstituicaoFinanceiraFiltro"
        Me.cboInstituicaoFinanceiraFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboInstituicaoFinanceiraFiltro.Size = New System.Drawing.Size(284, 20)
        Me.cboInstituicaoFinanceiraFiltro.TabIndex = 12
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(135, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 3
        Me.dtpDataInicioFiltro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(249, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 4
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(132, 17)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 2
        Me.lblDataFiltro.Text = "Data:"
        '
        'txtNumeroContratoFiltro
        '
        Me.txtNumeroContratoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroContratoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroContratoFiltro.MaxLength = 100
        Me.txtNumeroContratoFiltro.Name = "txtNumeroContratoFiltro"
        Me.txtNumeroContratoFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroContratoFiltro.TabIndex = 1
        '
        'lblNumeroContratoFiltro
        '
        Me.lblNumeroContratoFiltro.AutoSize = True
        Me.lblNumeroContratoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroContratoFiltro.Name = "lblNumeroContratoFiltro"
        Me.lblNumeroContratoFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblNumeroContratoFiltro.TabIndex = 0
        Me.lblNumeroContratoFiltro.Text = "Nº Contrato:"
        '
        'lblBancoFiltro
        '
        Me.lblBancoFiltro.AutoSize = True
        Me.lblBancoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblBancoFiltro.Name = "lblBancoFiltro"
        Me.lblBancoFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblBancoFiltro.TabIndex = 9
        Me.lblBancoFiltro.Text = "Banco:"
        '
        'cboBancoFiltro
        '
        Me.cboBancoFiltro.AutoSize = False
        Me.cboBancoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboBancoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboBancoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboBancoFiltro.Name = "cboBancoFiltro"
        Me.cboBancoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBancoFiltro.Size = New System.Drawing.Size(348, 20)
        Me.cboBancoFiltro.TabIndex = 10
        '
        'cboMoedaFiltro
        '
        Me.cboMoedaFiltro.AutoSize = False
        Me.cboMoedaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMoedaFiltro.Location = New System.Drawing.Point(566, 34)
        Me.cboMoedaFiltro.Name = "cboMoedaFiltro"
        Me.cboMoedaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMoedaFiltro.Size = New System.Drawing.Size(81, 20)
        Me.cboMoedaFiltro.TabIndex = 8
        '
        'lblMoedaFiltro
        '
        Me.lblMoedaFiltro.AutoSize = True
        Me.lblMoedaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMoedaFiltro.Location = New System.Drawing.Point(563, 17)
        Me.lblMoedaFiltro.Name = "lblMoedaFiltro"
        Me.lblMoedaFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblMoedaFiltro.TabIndex = 7
        Me.lblMoedaFiltro.Text = "Moeda:"
        '
        'lblTipoFiltro
        '
        Me.lblTipoFiltro.AutoSize = True
        Me.lblTipoFiltro.Location = New System.Drawing.Point(360, 17)
        Me.lblTipoFiltro.Name = "lblTipoFiltro"
        Me.lblTipoFiltro.Size = New System.Drawing.Size(30, 14)
        Me.lblTipoFiltro.TabIndex = 5
        Me.lblTipoFiltro.Text = "Tipo:"
        '
        'cboTipoFiltro
        '
        Me.cboTipoFiltro.AutoSize = False
        Me.cboTipoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboTipoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboTipoFiltro.Location = New System.Drawing.Point(363, 34)
        Me.cboTipoFiltro.Name = "cboTipoFiltro"
        Me.cboTipoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoFiltro.Size = New System.Drawing.Size(197, 20)
        Me.cboTipoFiltro.TabIndex = 6
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 13
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnLista)
        Me.grpControl.Controls.Add(Me.btnGrafico)
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 484)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnLista
        '
        Me.btnLista.Image = Global.INTERACTI.My.Resources.Resources.grid
        Me.btnLista.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLista.Location = New System.Drawing.Point(9, 17)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnLista.Size = New System.Drawing.Size(91, 23)
        Me.btnLista.TabIndex = 5
        Me.btnLista.Text = "Lista"
        Me.btnLista.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnGrafico
        '
        Me.btnGrafico.Image = Global.INTERACTI.My.Resources.Resources.grafico
        Me.btnGrafico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGrafico.Location = New System.Drawing.Point(9, 17)
        Me.btnGrafico.Name = "btnGrafico"
        Me.btnGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGrafico.Size = New System.Drawing.Size(91, 23)
        Me.btnGrafico.TabIndex = 4
        Me.btnGrafico.Text = "Gráfico"
        Me.btnGrafico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcel
        '
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(506, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 1
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(700, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chrDados
        '
        Me.chrDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chrDados.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrDados.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrDados.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.Title = "Data"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Fator Cambial"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrDados.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Default"
        Me.chrDados.Legends.Add(Legend1)
        Me.chrDados.Location = New System.Drawing.Point(8, 116)
        Me.chrDados.Name = "chrDados"
        Me.chrDados.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series1.ChartType = "Line"
        Series1.CustomAttributes = "LabelStyle=Bottom"
        Series1.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Series1.Name = "Default"
        Series1.ShowLabelAsValue = True
        Series1.SmartLabels.Enabled = True
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrDados.Series.Add(Series1)
        Me.chrDados.Size = New System.Drawing.Size(897, 365)
        Me.chrDados.TabIndex = 3
        Title1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Variação Cambial"
        Title1.Text = "Variação Cambial"
        Me.chrDados.Titles.Add(Title1)
        Me.chrDados.UI.Toolbar.Enabled = True
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Contrato de Cambio"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 484)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnCadastrarInstituicaoFinanceira)
        Me.grpDados.Controls.Add(Me.btnCadastrarBanco)
        Me.grpDados.Controls.Add(Me.txtValorOperacaoMoedaCorrente)
        Me.grpDados.Controls.Add(Me.lblValorOperacaoMoedaCorrente)
        Me.grpDados.Controls.Add(Me.txtValorOperacao)
        Me.grpDados.Controls.Add(Me.lblValorOperacao)
        Me.grpDados.Controls.Add(Me.lblInstituicaoFinanceira)
        Me.grpDados.Controls.Add(Me.cboInstituicaoFinanceira)
        Me.grpDados.Controls.Add(Me.dtpData)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.txtNumeroContrato)
        Me.grpDados.Controls.Add(Me.lblNumeroContrato)
        Me.grpDados.Controls.Add(Me.btnArquivo)
        Me.grpDados.Controls.Add(Me.lblArquivo)
        Me.grpDados.Controls.Add(Me.txtArquivo)
        Me.grpDados.Controls.Add(Me.lblBanco)
        Me.grpDados.Controls.Add(Me.cboBanco)
        Me.grpDados.Controls.Add(Me.lblFatorCambial)
        Me.grpDados.Controls.Add(Me.txtFatorCambial)
        Me.grpDados.Controls.Add(Me.cboMoeda)
        Me.grpDados.Controls.Add(Me.lblMoeda)
        Me.grpDados.Controls.Add(Me.lblTipo)
        Me.grpDados.Controls.Add(Me.cboTipo)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 144)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarInstituicaoFinanceira
        '
        Me.btnCadastrarInstituicaoFinanceira.FlatAppearance.BorderSize = 0
        Me.btnCadastrarInstituicaoFinanceira.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarInstituicaoFinanceira.Image = CType(resources.GetObject("btnCadastrarInstituicaoFinanceira.Image"), System.Drawing.Image)
        Me.btnCadastrarInstituicaoFinanceira.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarInstituicaoFinanceira.Location = New System.Drawing.Point(439, 58)
        Me.btnCadastrarInstituicaoFinanceira.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarInstituicaoFinanceira.Name = "btnCadastrarInstituicaoFinanceira"
        Me.btnCadastrarInstituicaoFinanceira.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarInstituicaoFinanceira.TabIndex = 17
        Me.btnCadastrarInstituicaoFinanceira.TabStop = False
        Me.btnCadastrarInstituicaoFinanceira.UseVisualStyleBackColor = True
        '
        'btnCadastrarBanco
        '
        Me.btnCadastrarBanco.FlatAppearance.BorderSize = 0
        Me.btnCadastrarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarBanco.Image = CType(resources.GetObject("btnCadastrarBanco.Image"), System.Drawing.Image)
        Me.btnCadastrarBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarBanco.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarBanco.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarBanco.Name = "btnCadastrarBanco"
        Me.btnCadastrarBanco.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarBanco.TabIndex = 14
        Me.btnCadastrarBanco.TabStop = False
        Me.btnCadastrarBanco.UseVisualStyleBackColor = True
        '
        'txtValorOperacaoMoedaCorrente
        '
        Me.txtValorOperacaoMoedaCorrente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorOperacaoMoedaCorrente.DecimalDigits = 2
        Me.txtValorOperacaoMoedaCorrente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtValorOperacaoMoedaCorrente.Location = New System.Drawing.Point(767, 34)
        Me.txtValorOperacaoMoedaCorrente.MaxLength = 0
        Me.txtValorOperacaoMoedaCorrente.Name = "txtValorOperacaoMoedaCorrente"
        Me.txtValorOperacaoMoedaCorrente.ReadOnly = True
        Me.txtValorOperacaoMoedaCorrente.Size = New System.Drawing.Size(121, 20)
        Me.txtValorOperacaoMoedaCorrente.TabIndex = 13
        Me.txtValorOperacaoMoedaCorrente.TabStop = False
        Me.txtValorOperacaoMoedaCorrente.Text = "0,00"
        Me.txtValorOperacaoMoedaCorrente.Value = 0.0R
        Me.txtValorOperacaoMoedaCorrente.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorOperacaoMoedaCorrente
        '
        Me.lblValorOperacaoMoedaCorrente.AutoSize = True
        Me.lblValorOperacaoMoedaCorrente.Location = New System.Drawing.Point(765, 17)
        Me.lblValorOperacaoMoedaCorrente.Name = "lblValorOperacaoMoedaCorrente"
        Me.lblValorOperacaoMoedaCorrente.Size = New System.Drawing.Size(117, 14)
        Me.lblValorOperacaoMoedaCorrente.TabIndex = 12
        Me.lblValorOperacaoMoedaCorrente.Text = "Valor da Operação R$:"
        '
        'txtValorOperacao
        '
        Me.txtValorOperacao.DecimalDigits = 2
        Me.txtValorOperacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtValorOperacao.Location = New System.Drawing.Point(439, 34)
        Me.txtValorOperacao.MaxLength = 0
        Me.txtValorOperacao.Name = "txtValorOperacao"
        Me.txtValorOperacao.Size = New System.Drawing.Size(121, 20)
        Me.txtValorOperacao.TabIndex = 7
        Me.txtValorOperacao.Text = "0,00"
        Me.txtValorOperacao.Value = 0.0R
        Me.txtValorOperacao.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorOperacao
        '
        Me.lblValorOperacao.AutoSize = True
        Me.lblValorOperacao.Location = New System.Drawing.Point(437, 17)
        Me.lblValorOperacao.Name = "lblValorOperacao"
        Me.lblValorOperacao.Size = New System.Drawing.Size(101, 14)
        Me.lblValorOperacao.TabIndex = 6
        Me.lblValorOperacao.Text = "Valor da Operação:"
        '
        'lblInstituicaoFinanceira
        '
        Me.lblInstituicaoFinanceira.AutoSize = True
        Me.lblInstituicaoFinanceira.Location = New System.Drawing.Point(455, 57)
        Me.lblInstituicaoFinanceira.Name = "lblInstituicaoFinanceira"
        Me.lblInstituicaoFinanceira.Size = New System.Drawing.Size(111, 14)
        Me.lblInstituicaoFinanceira.TabIndex = 18
        Me.lblInstituicaoFinanceira.Text = "Instituição Financeira:"
        '
        'cboInstituicaoFinanceira
        '
        Me.cboInstituicaoFinanceira.AutoSize = False
        Me.cboInstituicaoFinanceira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = "SIM"
        UiComboBoxItem7.Value = True
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = "NÃO"
        UiComboBoxItem8.Value = False
        Me.cboInstituicaoFinanceira.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboInstituicaoFinanceira.Location = New System.Drawing.Point(439, 74)
        Me.cboInstituicaoFinanceira.Name = "cboInstituicaoFinanceira"
        Me.cboInstituicaoFinanceira.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboInstituicaoFinanceira.Size = New System.Drawing.Size(449, 20)
        Me.cboInstituicaoFinanceira.TabIndex = 19
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(135, 34)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(91, 20)
        Me.dtpData.TabIndex = 3
        Me.dtpData.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(132, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = "Data:"
        '
        'txtNumeroContrato
        '
        Me.txtNumeroContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroContrato.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroContrato.MaxLength = 100
        Me.txtNumeroContrato.Name = "txtNumeroContrato"
        Me.txtNumeroContrato.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroContrato.TabIndex = 1
        '
        'lblNumeroContrato
        '
        Me.lblNumeroContrato.AutoSize = True
        Me.lblNumeroContrato.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroContrato.Name = "lblNumeroContrato"
        Me.lblNumeroContrato.Size = New System.Drawing.Size(66, 14)
        Me.lblNumeroContrato.TabIndex = 0
        Me.lblNumeroContrato.Text = "Nº Contrato:"
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(868, 114)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 22
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArquivo.Location = New System.Drawing.Point(6, 97)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 20
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.Location = New System.Drawing.Point(9, 114)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(860, 20)
        Me.txtArquivo.TabIndex = 21
        Me.txtArquivo.TabStop = False
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(25, 57)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(41, 14)
        Me.lblBanco.TabIndex = 15
        Me.lblBanco.Text = "Banco:"
        '
        'cboBanco
        '
        Me.cboBanco.AutoSize = False
        Me.cboBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem9.FormatStyle.Alpha = 0
        UiComboBoxItem9.IsSeparator = False
        UiComboBoxItem9.Text = "SIM"
        UiComboBoxItem9.Value = True
        UiComboBoxItem10.FormatStyle.Alpha = 0
        UiComboBoxItem10.IsSeparator = False
        UiComboBoxItem10.Text = "NÃO"
        UiComboBoxItem10.Value = False
        Me.cboBanco.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem9, UiComboBoxItem10})
        Me.cboBanco.Location = New System.Drawing.Point(9, 74)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBanco.Size = New System.Drawing.Size(424, 20)
        Me.cboBanco.TabIndex = 16
        '
        'lblFatorCambial
        '
        Me.lblFatorCambial.AutoSize = True
        Me.lblFatorCambial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFatorCambial.Location = New System.Drawing.Point(650, 17)
        Me.lblFatorCambial.Name = "lblFatorCambial"
        Me.lblFatorCambial.Size = New System.Drawing.Size(75, 14)
        Me.lblFatorCambial.TabIndex = 10
        Me.lblFatorCambial.Text = "Fator Cambial:"
        '
        'txtFatorCambial
        '
        Me.txtFatorCambial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFatorCambial.DecimalDigits = 4
        Me.txtFatorCambial.Location = New System.Drawing.Point(653, 34)
        Me.txtFatorCambial.Name = "txtFatorCambial"
        Me.txtFatorCambial.ReadOnly = True
        Me.txtFatorCambial.Size = New System.Drawing.Size(108, 20)
        Me.txtFatorCambial.TabIndex = 11
        Me.txtFatorCambial.TabStop = False
        Me.txtFatorCambial.Text = "0,0000"
        Me.txtFatorCambial.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'cboMoeda
        '
        Me.cboMoeda.AutoSize = False
        Me.cboMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMoeda.Location = New System.Drawing.Point(566, 34)
        Me.cboMoeda.Name = "cboMoeda"
        Me.cboMoeda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMoeda.Size = New System.Drawing.Size(81, 20)
        Me.cboMoeda.TabIndex = 9
        '
        'lblMoeda
        '
        Me.lblMoeda.AutoSize = True
        Me.lblMoeda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMoeda.Location = New System.Drawing.Point(563, 17)
        Me.lblMoeda.Name = "lblMoeda"
        Me.lblMoeda.Size = New System.Drawing.Size(42, 14)
        Me.lblMoeda.TabIndex = 8
        Me.lblMoeda.Text = "Moeda:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(229, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 4
        Me.lblTipo.Text = "Tipo:"
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem11.FormatStyle.Alpha = 0
        UiComboBoxItem11.IsSeparator = False
        UiComboBoxItem11.Text = "SIM"
        UiComboBoxItem11.Value = True
        UiComboBoxItem12.FormatStyle.Alpha = 0
        UiComboBoxItem12.IsSeparator = False
        UiComboBoxItem12.Text = "NÃO"
        UiComboBoxItem12.Value = False
        Me.cboTipo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem11, UiComboBoxItem12})
        Me.cboTipo.Location = New System.Drawing.Point(232, 34)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(201, 20)
        Me.cboTipo.TabIndex = 5
        '
        'usrCadContratoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadContratoCambio"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.chrDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFatorCambial As System.Windows.Forms.Label
    Friend WithEvents txtFatorCambial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboMoeda As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMoeda As System.Windows.Forms.Label
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents cboBanco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroContratoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroContratoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblBancoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboBancoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboMoedaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMoedaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroContrato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroContrato As System.Windows.Forms.Label
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInstituicaoFinanceira As System.Windows.Forms.Label
    Friend WithEvents cboInstituicaoFinanceira As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtValorOperacao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOperacao As System.Windows.Forms.Label
    Friend WithEvents txtValorOperacaoMoedaCorrente As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorOperacaoMoedaCorrente As System.Windows.Forms.Label
    Friend WithEvents lblInstituicaoFinanceiraFiltro As System.Windows.Forms.Label
    Friend WithEvents cboInstituicaoFinanceiraFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarInstituicaoFinanceira As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarBanco As System.Windows.Forms.Button
    Friend WithEvents btnGrafico As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnLista As Janus.Windows.EditControls.UIButton
    Friend WithEvents chrDados As Dundas.Charting.WinControl.Chart

End Class
