<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadPortariaNotaFiscal
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
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadPortariaNotaFiscal))
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem9 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem10 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem11 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem12 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEntradaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEntradaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntradaFiltro = New System.Windows.Forms.Label()
        Me.lblMotoristaFiltro = New System.Windows.Forms.Label()
        Me.txtMotoristaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtResponsavelFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblResponsavelFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblEmpresaFiltro = New System.Windows.Forms.Label()
        Me.cboEmpresaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblParceiroNegocioFiltro = New System.Windows.Forms.Label()
        Me.cboParceiroNegocioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.cboEmpresa = New Janus.Windows.EditControls.UIComboBox()
        Me.txtResponsavel = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.cboParceiroNegocio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMotorista = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtSerie = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.txtMotorista = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Lista de Nota Fiscal"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEntradaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMotoristaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtMotoristaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtResponsavelFiltro)
        Me.grpFiltro.Controls.Add(Me.lblResponsavelFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblEmpresaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboEmpresaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboParceiroNegocioFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEntradaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEntradaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntradaInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataEntradaInicioFiltro.Name = "dtpDataEntradaInicioFiltro"
        Me.dtpDataEntradaInicioFiltro.ShowCheckBox = True
        Me.dtpDataEntradaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntradaInicioFiltro.TabIndex = 16
        Me.dtpDataEntradaInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEntradaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEntradaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntradaTerminoFiltro.Location = New System.Drawing.Point(123, 74)
        Me.dtpDataEntradaTerminoFiltro.Name = "dtpDataEntradaTerminoFiltro"
        Me.dtpDataEntradaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEntradaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntradaTerminoFiltro.TabIndex = 17
        Me.dtpDataEntradaTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntradaFiltro
        '
        Me.lblDataEntradaFiltro.AutoSize = True
        Me.lblDataEntradaFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataEntradaFiltro.Name = "lblDataEntradaFiltro"
        Me.lblDataEntradaFiltro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaFiltro.TabIndex = 15
        Me.lblDataEntradaFiltro.Text = "Data Entrada:"
        '
        'lblMotoristaFiltro
        '
        Me.lblMotoristaFiltro.AutoSize = True
        Me.lblMotoristaFiltro.Location = New System.Drawing.Point(414, 57)
        Me.lblMotoristaFiltro.Name = "lblMotoristaFiltro"
        Me.lblMotoristaFiltro.Size = New System.Drawing.Size(54, 14)
        Me.lblMotoristaFiltro.TabIndex = 10
        Me.lblMotoristaFiltro.Text = "Motorista:"
        '
        'txtMotoristaFiltro
        '
        Me.txtMotoristaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMotoristaFiltro.Location = New System.Drawing.Point(417, 74)
        Me.txtMotoristaFiltro.MaxLength = 250
        Me.txtMotoristaFiltro.Name = "txtMotoristaFiltro"
        Me.txtMotoristaFiltro.Size = New System.Drawing.Size(343, 20)
        Me.txtMotoristaFiltro.TabIndex = 11
        '
        'txtResponsavelFiltro
        '
        Me.txtResponsavelFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsavelFiltro.Location = New System.Drawing.Point(9, 114)
        Me.txtResponsavelFiltro.MaxLength = 250
        Me.txtResponsavelFiltro.Name = "txtResponsavelFiltro"
        Me.txtResponsavelFiltro.Size = New System.Drawing.Size(402, 20)
        Me.txtResponsavelFiltro.TabIndex = 13
        '
        'lblResponsavelFiltro
        '
        Me.lblResponsavelFiltro.AutoSize = True
        Me.lblResponsavelFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblResponsavelFiltro.Name = "lblResponsavelFiltro"
        Me.lblResponsavelFiltro.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavelFiltro.TabIndex = 12
        Me.lblResponsavelFiltro.Text = "Responsável:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 14
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblEmpresaFiltro
        '
        Me.lblEmpresaFiltro.AutoSize = True
        Me.lblEmpresaFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblEmpresaFiltro.Name = "lblEmpresaFiltro"
        Me.lblEmpresaFiltro.Size = New System.Drawing.Size(52, 14)
        Me.lblEmpresaFiltro.TabIndex = 0
        Me.lblEmpresaFiltro.Text = "Empresa:"
        '
        'cboEmpresaFiltro
        '
        Me.cboEmpresaFiltro.AutoSize = False
        Me.cboEmpresaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboEmpresaFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboEmpresaFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboEmpresaFiltro.Name = "cboEmpresaFiltro"
        Me.cboEmpresaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEmpresaFiltro.Size = New System.Drawing.Size(222, 20)
        Me.cboEmpresaFiltro.TabIndex = 1
        '
        'lblSerieFiltro
        '
        Me.lblSerieFiltro.AutoSize = True
        Me.lblSerieFiltro.Location = New System.Drawing.Point(348, 17)
        Me.lblSerieFiltro.Name = "lblSerieFiltro"
        Me.lblSerieFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieFiltro.TabIndex = 4
        Me.lblSerieFiltro.Text = "Série:"
        '
        'txtSerieFiltro
        '
        Me.txtSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieFiltro.Location = New System.Drawing.Point(351, 34)
        Me.txtSerieFiltro.MaxLength = 8
        Me.txtSerieFiltro.Name = "txtSerieFiltro"
        Me.txtSerieFiltro.Size = New System.Drawing.Size(60, 20)
        Me.txtSerieFiltro.TabIndex = 5
        '
        'lblTipoFiltro
        '
        Me.lblTipoFiltro.AutoSize = True
        Me.lblTipoFiltro.Location = New System.Drawing.Point(234, 57)
        Me.lblTipoFiltro.Name = "lblTipoFiltro"
        Me.lblTipoFiltro.Size = New System.Drawing.Size(30, 14)
        Me.lblTipoFiltro.TabIndex = 8
        Me.lblTipoFiltro.Text = "Tipo:"
        '
        'cboTipoFiltro
        '
        Me.cboTipoFiltro.AutoSize = False
        Me.cboTipoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboTipoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboTipoFiltro.Location = New System.Drawing.Point(237, 74)
        Me.cboTipoFiltro.Name = "cboTipoFiltro"
        Me.cboTipoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoFiltro.Size = New System.Drawing.Size(174, 20)
        Me.cboTipoFiltro.TabIndex = 9
        '
        'lblNotaFiscalFiltro
        '
        Me.lblNotaFiscalFiltro.AutoSize = True
        Me.lblNotaFiscalFiltro.Location = New System.Drawing.Point(234, 17)
        Me.lblNotaFiscalFiltro.Name = "lblNotaFiscalFiltro"
        Me.lblNotaFiscalFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalFiltro.TabIndex = 2
        Me.lblNotaFiscalFiltro.Text = "Nota Fiscal:"
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(237, 34)
        Me.txtNotaFiscalFiltro.MaxLength = 8
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 3
        '
        'lblParceiroNegocioFiltro
        '
        Me.lblParceiroNegocioFiltro.AutoSize = True
        Me.lblParceiroNegocioFiltro.Location = New System.Drawing.Point(414, 17)
        Me.lblParceiroNegocioFiltro.Name = "lblParceiroNegocioFiltro"
        Me.lblParceiroNegocioFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocioFiltro.TabIndex = 6
        Me.lblParceiroNegocioFiltro.Text = "Parceiro de Negócio:"
        '
        'cboParceiroNegocioFiltro
        '
        Me.cboParceiroNegocioFiltro.AutoSize = False
        Me.cboParceiroNegocioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboParceiroNegocioFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboParceiroNegocioFiltro.Location = New System.Drawing.Point(417, 34)
        Me.cboParceiroNegocioFiltro.Name = "cboParceiroNegocioFiltro"
        Me.cboParceiroNegocioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboParceiroNegocioFiltro.Size = New System.Drawing.Size(343, 20)
        Me.cboParceiroNegocioFiltro.TabIndex = 7
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(49, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 156)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 324)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
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
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
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
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
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
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados da Nota Fiscal"
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtObservacao)
        Me.grpDados.Controls.Add(Me.lblObservacao)
        Me.grpDados.Controls.Add(Me.lblEmpresa)
        Me.grpDados.Controls.Add(Me.cboEmpresa)
        Me.grpDados.Controls.Add(Me.txtResponsavel)
        Me.grpDados.Controls.Add(Me.lblResponsavel)
        Me.grpDados.Controls.Add(Me.txtValor)
        Me.grpDados.Controls.Add(Me.lblValor)
        Me.grpDados.Controls.Add(Me.cboParceiroNegocio)
        Me.grpDados.Controls.Add(Me.lblMotorista)
        Me.grpDados.Controls.Add(Me.lblSerie)
        Me.grpDados.Controls.Add(Me.txtSerie)
        Me.grpDados.Controls.Add(Me.lblTipo)
        Me.grpDados.Controls.Add(Me.cboTipo)
        Me.grpDados.Controls.Add(Me.lblNotaFiscal)
        Me.grpDados.Controls.Add(Me.txtNotaFiscal)
        Me.grpDados.Controls.Add(Me.lblParceiroNegocio)
        Me.grpDados.Controls.Add(Me.txtMotorista)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 477)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(9, 114)
        Me.txtObservacao.MaxLength = 0
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(879, 353)
        Me.txtObservacao.TabIndex = 17
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 97)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 16
        Me.lblObservacao.Text = "Observação:"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(6, 17)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(52, 14)
        Me.lblEmpresa.TabIndex = 0
        Me.lblEmpresa.Text = "Empresa:"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.AutoSize = False
        Me.cboEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = "SIM"
        UiComboBoxItem7.Value = True
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = "NÃO"
        UiComboBoxItem8.Value = False
        Me.cboEmpresa.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboEmpresa.Location = New System.Drawing.Point(9, 34)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEmpresa.Size = New System.Drawing.Size(222, 20)
        Me.cboEmpresa.TabIndex = 1
        '
        'txtResponsavel
        '
        Me.txtResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsavel.Location = New System.Drawing.Point(581, 74)
        Me.txtResponsavel.MaxLength = 250
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(307, 20)
        Me.txtResponsavel.TabIndex = 15
        '
        'lblResponsavel
        '
        Me.lblResponsavel.AutoSize = True
        Me.lblResponsavel.Location = New System.Drawing.Point(578, 57)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Size = New System.Drawing.Size(73, 14)
        Me.lblResponsavel.TabIndex = 14
        Me.lblResponsavel.Text = "Responsável:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(794, 34)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(94, 20)
        Me.txtValor.TabIndex = 9
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(791, 17)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 8
        Me.lblValor.Text = "Valor:"
        '
        'cboParceiroNegocio
        '
        Me.cboParceiroNegocio.AutoSize = False
        Me.cboParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem9.FormatStyle.Alpha = 0
        UiComboBoxItem9.IsSeparator = False
        UiComboBoxItem9.Text = "SIM"
        UiComboBoxItem9.Value = True
        UiComboBoxItem10.FormatStyle.Alpha = 0
        UiComboBoxItem10.IsSeparator = False
        UiComboBoxItem10.Text = "NÃO"
        UiComboBoxItem10.Value = False
        Me.cboParceiroNegocio.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem9, UiComboBoxItem10})
        Me.cboParceiroNegocio.Location = New System.Drawing.Point(417, 34)
        Me.cboParceiroNegocio.Name = "cboParceiroNegocio"
        Me.cboParceiroNegocio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboParceiroNegocio.Size = New System.Drawing.Size(371, 20)
        Me.cboParceiroNegocio.TabIndex = 7
        '
        'lblMotorista
        '
        Me.lblMotorista.AutoSize = True
        Me.lblMotorista.Location = New System.Drawing.Point(234, 57)
        Me.lblMotorista.Name = "lblMotorista"
        Me.lblMotorista.Size = New System.Drawing.Size(54, 14)
        Me.lblMotorista.TabIndex = 12
        Me.lblMotorista.Text = "Motorista:"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(348, 17)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 4
        Me.lblSerie.Text = "Série:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(351, 34)
        Me.txtSerie.MaxLength = 8
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(60, 20)
        Me.txtSerie.TabIndex = 5
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(6, 57)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 10
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
        Me.cboTipo.Location = New System.Drawing.Point(9, 74)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(222, 20)
        Me.cboTipo.TabIndex = 11
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(234, 17)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscal.TabIndex = 2
        Me.lblNotaFiscal.Text = "Nota Fiscal:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Location = New System.Drawing.Point(237, 34)
        Me.txtNotaFiscal.MaxLength = 8
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(108, 20)
        Me.txtNotaFiscal.TabIndex = 3
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(414, 17)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocio.TabIndex = 6
        Me.lblParceiroNegocio.Text = "Parceiro de Negócio:"
        '
        'txtMotorista
        '
        Me.txtMotorista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMotorista.Location = New System.Drawing.Point(237, 74)
        Me.txtMotorista.MaxLength = 250
        Me.txtMotorista.Name = "txtMotorista"
        Me.txtMotorista.Size = New System.Drawing.Size(338, 20)
        Me.txtMotorista.TabIndex = 13
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 483)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
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
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
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
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
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
        'usrCadPortariaNotaFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadPortariaNotaFiscal"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents cboParceiroNegocio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtMotorista As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMotorista As System.Windows.Forms.Label
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtSerie As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents cboEmpresa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtResponsavel As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblResponsavel As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblMotoristaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtMotoristaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtResponsavelFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblResponsavelFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblEmpresaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboEmpresaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblParceiroNegocioFiltro As System.Windows.Forms.Label
    Friend WithEvents cboParceiroNegocioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents dtpDataEntradaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntradaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntradaFiltro As System.Windows.Forms.Label

End Class
