<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmpContrato
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpContrato))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoContratoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoContratoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroContratoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroContratoFiltro = New System.Windows.Forms.Label()
        Me.txtDiaVencimentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.txtParceiroNegocioFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDiaVencimentoFiltro = New System.Windows.Forms.Label()
        Me.lblDataTerminoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInicioTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInicioFiltro = New System.Windows.Forms.Label()
        Me.lblTipoTituloFiltro = New System.Windows.Forms.Label()
        Me.cboTipoTituloFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAtivoFiltro = New System.Windows.Forms.Label()
        Me.lblParceiroNegocioFiltro = New System.Windows.Forms.Label()
        Me.cboAtivoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaCancelado = New System.Windows.Forms.Label()
        Me.lblLegendaConcluido = New System.Windows.Forms.Label()
        Me.lblLegendaProducao = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoContrato = New System.Windows.Forms.Label()
        Me.cboTipoContrato = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoTituloFinanceiro = New System.Windows.Forms.Label()
        Me.cboTipoTitulo = New Janus.Windows.EditControls.UIComboBox()
        Me.txtTolerancia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTolerancica = New System.Windows.Forms.Label()
        Me.cboCentroCusto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroCusto = New System.Windows.Forms.Label()
        Me.lblNumeroContrato = New System.Windows.Forms.Label()
        Me.txtNumeroContrato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescritivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescritivo = New System.Windows.Forms.Label()
        Me.txtValorMensal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtDiaVencimento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDiaVencimento = New System.Windows.Forms.Label()
        Me.lblDataTermino = New System.Windows.Forms.Label()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.cboParceiroNegocio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.picLegendaConcluido = New System.Windows.Forms.PictureBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.picLegendaProducao = New System.Windows.Forms.PictureBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        Me.pagLista.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaProducao, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblTipoContratoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoContratoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroContratoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroContratoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDiaVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDiaVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoTituloFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoTituloFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAtivoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAtivoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(9, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(896, 107)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblTipoContratoFiltro
        '
        Me.lblTipoContratoFiltro.AutoSize = True
        Me.lblTipoContratoFiltro.Location = New System.Drawing.Point(640, 58)
        Me.lblTipoContratoFiltro.Name = "lblTipoContratoFiltro"
        Me.lblTipoContratoFiltro.Size = New System.Drawing.Size(89, 14)
        Me.lblTipoContratoFiltro.TabIndex = 28
        Me.lblTipoContratoFiltro.Text = "Tipo do Contrato:"
        '
        'cboTipoContratoFiltro
        '
        Me.cboTipoContratoFiltro.AutoSize = False
        Me.cboTipoContratoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoContratoFiltro.Location = New System.Drawing.Point(643, 75)
        Me.cboTipoContratoFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoContratoFiltro.Name = "cboTipoContratoFiltro"
        Me.cboTipoContratoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoContratoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.cboTipoContratoFiltro.TabIndex = 27
        '
        'txtNumeroContratoFiltro
        '
        Me.txtNumeroContratoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroContratoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroContratoFiltro.MaxLength = 20
        Me.txtNumeroContratoFiltro.Name = "txtNumeroContratoFiltro"
        Me.txtNumeroContratoFiltro.Size = New System.Drawing.Size(99, 20)
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
        'txtDiaVencimentoFiltro
        '
        Me.txtDiaVencimentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiaVencimentoFiltro.Location = New System.Drawing.Point(643, 34)
        Me.txtDiaVencimentoFiltro.MaxLength = 60
        Me.txtDiaVencimentoFiltro.Name = "txtDiaVencimentoFiltro"
        Me.txtDiaVencimentoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtDiaVencimentoFiltro.TabIndex = 7
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(324, 34)
        Me.txtDescricaoFiltro.MaxLength = 60
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(313, 20)
        Me.txtDescricaoFiltro.TabIndex = 5
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(321, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblDescricaoFiltro.TabIndex = 4
        Me.lblDescricaoFiltro.Text = "Descritivo:"
        '
        'txtParceiroNegocioFiltro
        '
        Me.txtParceiroNegocioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParceiroNegocioFiltro.Location = New System.Drawing.Point(114, 34)
        Me.txtParceiroNegocioFiltro.MaxLength = 60
        Me.txtParceiroNegocioFiltro.Name = "txtParceiroNegocioFiltro"
        Me.txtParceiroNegocioFiltro.Size = New System.Drawing.Size(204, 20)
        Me.txtParceiroNegocioFiltro.TabIndex = 3
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(324, 75)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 13
        '
        'dtpDataTerminoInicioFiltro
        '
        Me.dtpDataTerminoInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoInicioFiltro.Location = New System.Drawing.Point(219, 75)
        Me.dtpDataTerminoInicioFiltro.Name = "dtpDataTerminoInicioFiltro"
        Me.dtpDataTerminoInicioFiltro.ShowCheckBox = True
        Me.dtpDataTerminoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataTerminoInicioFiltro.TabIndex = 12
        '
        'lblDiaVencimentoFiltro
        '
        Me.lblDiaVencimentoFiltro.AutoSize = True
        Me.lblDiaVencimentoFiltro.Location = New System.Drawing.Point(640, 17)
        Me.lblDiaVencimentoFiltro.Name = "lblDiaVencimentoFiltro"
        Me.lblDiaVencimentoFiltro.Size = New System.Drawing.Size(84, 14)
        Me.lblDiaVencimentoFiltro.TabIndex = 6
        Me.lblDiaVencimentoFiltro.Text = "Dia Vencimento:"
        '
        'lblDataTerminoFiltro
        '
        Me.lblDataTerminoFiltro.AutoSize = True
        Me.lblDataTerminoFiltro.Location = New System.Drawing.Point(216, 58)
        Me.lblDataTerminoFiltro.Name = "lblDataTerminoFiltro"
        Me.lblDataTerminoFiltro.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTerminoFiltro.TabIndex = 9
        Me.lblDataTerminoFiltro.Text = "Data Término:"
        '
        'dtpDataInicioTerminoFiltro
        '
        Me.dtpDataInicioTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioTerminoFiltro.Location = New System.Drawing.Point(114, 75)
        Me.dtpDataInicioTerminoFiltro.Name = "dtpDataInicioTerminoFiltro"
        Me.dtpDataInicioTerminoFiltro.ShowCheckBox = True
        Me.dtpDataInicioTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataInicioTerminoFiltro.TabIndex = 11
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 75)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataInicioFiltro.TabIndex = 10
        '
        'lblDataInicioFiltro
        '
        Me.lblDataInicioFiltro.AutoSize = True
        Me.lblDataInicioFiltro.Location = New System.Drawing.Point(6, 58)
        Me.lblDataInicioFiltro.Name = "lblDataInicioFiltro"
        Me.lblDataInicioFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicioFiltro.TabIndex = 9
        Me.lblDataInicioFiltro.Text = "Data Início:"
        '
        'lblTipoTituloFiltro
        '
        Me.lblTipoTituloFiltro.AutoSize = True
        Me.lblTipoTituloFiltro.Location = New System.Drawing.Point(429, 58)
        Me.lblTipoTituloFiltro.Name = "lblTipoTituloFiltro"
        Me.lblTipoTituloFiltro.Size = New System.Drawing.Size(73, 14)
        Me.lblTipoTituloFiltro.TabIndex = 12
        Me.lblTipoTituloFiltro.Text = "Tipo do Título:"
        '
        'cboTipoTituloFiltro
        '
        Me.cboTipoTituloFiltro.AutoSize = False
        Me.cboTipoTituloFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoTituloFiltro.Location = New System.Drawing.Point(432, 75)
        Me.cboTipoTituloFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoTituloFiltro.Name = "cboTipoTituloFiltro"
        Me.cboTipoTituloFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoTituloFiltro.Size = New System.Drawing.Size(99, 20)
        Me.cboTipoTituloFiltro.TabIndex = 14
        '
        'lblAtivoFiltro
        '
        Me.lblAtivoFiltro.AutoSize = True
        Me.lblAtivoFiltro.Location = New System.Drawing.Point(534, 58)
        Me.lblAtivoFiltro.Name = "lblAtivoFiltro"
        Me.lblAtivoFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivoFiltro.TabIndex = 14
        Me.lblAtivoFiltro.Text = "Ativo:"
        '
        'lblParceiroNegocioFiltro
        '
        Me.lblParceiroNegocioFiltro.AutoSize = True
        Me.lblParceiroNegocioFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblParceiroNegocioFiltro.Name = "lblParceiroNegocioFiltro"
        Me.lblParceiroNegocioFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocioFiltro.TabIndex = 2
        Me.lblParceiroNegocioFiltro.Text = "Parceiro de Negócio:"
        '
        'cboAtivoFiltro
        '
        Me.cboAtivoFiltro.AutoSize = False
        Me.cboAtivoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboAtivoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboAtivoFiltro.Location = New System.Drawing.Point(537, 75)
        Me.cboAtivoFiltro.Name = "cboAtivoFiltro"
        Me.cboAtivoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.cboAtivoFiltro.TabIndex = 15
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.picLegendaCancelado)
        Me.grpControl.Controls.Add(Me.lblLegendaCancelado)
        Me.grpControl.Controls.Add(Me.picLegendaConcluido)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.lblLegendaConcluido)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.picLegendaProducao)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Controls.Add(Me.lblLegendaProducao)
        Me.grpControl.Location = New System.Drawing.Point(8, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaCancelado
        '
        Me.lblLegendaCancelado.AutoSize = True
        Me.lblLegendaCancelado.Location = New System.Drawing.Point(248, 25)
        Me.lblLegendaCancelado.Name = "lblLegendaCancelado"
        Me.lblLegendaCancelado.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelado.TabIndex = 16
        Me.lblLegendaCancelado.Text = "Cancelado"
        '
        'lblLegendaConcluido
        '
        Me.lblLegendaConcluido.AutoSize = True
        Me.lblLegendaConcluido.Location = New System.Drawing.Point(177, 25)
        Me.lblLegendaConcluido.Name = "lblLegendaConcluido"
        Me.lblLegendaConcluido.Size = New System.Drawing.Size(44, 14)
        Me.lblLegendaConcluido.TabIndex = 0
        Me.lblLegendaConcluido.Text = "Vigente"
        '
        'lblLegendaProducao
        '
        Me.lblLegendaProducao.AutoSize = True
        Me.lblLegendaProducao.Location = New System.Drawing.Point(27, 25)
        Me.lblLegendaProducao.Name = "lblLegendaProducao"
        Me.lblLegendaProducao.Size = New System.Drawing.Size(123, 14)
        Me.lblLegendaProducao.TabIndex = 1
        Me.lblLegendaProducao.Text = "Aguardando Aprovação"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.[Default]
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 117)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 269)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblTipoContrato)
        Me.grpDados.Controls.Add(Me.cboTipoContrato)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblTipoTituloFinanceiro)
        Me.grpDados.Controls.Add(Me.cboTipoTitulo)
        Me.grpDados.Controls.Add(Me.txtTolerancia)
        Me.grpDados.Controls.Add(Me.lblTolerancica)
        Me.grpDados.Controls.Add(Me.cboCentroCusto)
        Me.grpDados.Controls.Add(Me.lblCentroCusto)
        Me.grpDados.Controls.Add(Me.lblNumeroContrato)
        Me.grpDados.Controls.Add(Me.txtNumeroContrato)
        Me.grpDados.Controls.Add(Me.txtDescritivo)
        Me.grpDados.Controls.Add(Me.lblDescritivo)
        Me.grpDados.Controls.Add(Me.txtValorMensal)
        Me.grpDados.Controls.Add(Me.lblValor)
        Me.grpDados.Controls.Add(Me.txtDiaVencimento)
        Me.grpDados.Controls.Add(Me.lblDiaVencimento)
        Me.grpDados.Controls.Add(Me.lblDataTermino)
        Me.grpDados.Controls.Add(Me.dtpDataTermino)
        Me.grpDados.Controls.Add(Me.dtpDataInicio)
        Me.grpDados.Controls.Add(Me.lblDataInicio)
        Me.grpDados.Controls.Add(Me.cboParceiroNegocio)
        Me.grpDados.Controls.Add(Me.lblParceiroNegocio)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 153)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblTipoContrato
        '
        Me.lblTipoContrato.AutoSize = True
        Me.lblTipoContrato.Location = New System.Drawing.Point(696, 58)
        Me.lblTipoContrato.Name = "lblTipoContrato"
        Me.lblTipoContrato.Size = New System.Drawing.Size(89, 14)
        Me.lblTipoContrato.TabIndex = 26
        Me.lblTipoContrato.Text = "Tipo do Contrato:"
        '
        'cboTipoContrato
        '
        Me.cboTipoContrato.AutoSize = False
        Me.cboTipoContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoContrato.Location = New System.Drawing.Point(699, 76)
        Me.cboTipoContrato.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoContrato.Name = "cboTipoContrato"
        Me.cboTipoContrato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoContrato.Size = New System.Drawing.Size(99, 20)
        Me.cboTipoContrato.TabIndex = 9
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(801, 58)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 24
        Me.lblAtivo.Text = "Ativo:"
        '
        'cboAtivo
        '
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboAtivo.Location = New System.Drawing.Point(804, 76)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(83, 20)
        Me.cboAtivo.TabIndex = 10
        '
        'lblTipoTituloFinanceiro
        '
        Me.lblTipoTituloFinanceiro.AutoSize = True
        Me.lblTipoTituloFinanceiro.Location = New System.Drawing.Point(592, 58)
        Me.lblTipoTituloFinanceiro.Name = "lblTipoTituloFinanceiro"
        Me.lblTipoTituloFinanceiro.Size = New System.Drawing.Size(73, 14)
        Me.lblTipoTituloFinanceiro.TabIndex = 22
        Me.lblTipoTituloFinanceiro.Text = "Tipo do Título:"
        '
        'cboTipoTitulo
        '
        Me.cboTipoTitulo.AutoSize = False
        Me.cboTipoTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoTitulo.Location = New System.Drawing.Point(595, 76)
        Me.cboTipoTitulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoTitulo.Name = "cboTipoTitulo"
        Me.cboTipoTitulo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoTitulo.Size = New System.Drawing.Size(99, 20)
        Me.cboTipoTitulo.TabIndex = 8
        '
        'txtTolerancia
        '
        Me.txtTolerancia.DecimalDigits = 2
        Me.txtTolerancia.Location = New System.Drawing.Point(114, 76)
        Me.txtTolerancia.Name = "txtTolerancia"
        Me.txtTolerancia.Size = New System.Drawing.Size(98, 20)
        Me.txtTolerancia.TabIndex = 6
        Me.txtTolerancia.Text = "0,00"
        Me.txtTolerancia.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTolerancica
        '
        Me.lblTolerancica.AutoSize = True
        Me.lblTolerancica.Location = New System.Drawing.Point(112, 58)
        Me.lblTolerancica.Name = "lblTolerancica"
        Me.lblTolerancica.Size = New System.Drawing.Size(80, 14)
        Me.lblTolerancica.TabIndex = 20
        Me.lblTolerancica.Text = "Tolerância (%):"
        '
        'cboCentroCusto
        '
        Me.cboCentroCusto.AutoSize = False
        Me.cboCentroCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboCentroCusto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboCentroCusto.Location = New System.Drawing.Point(218, 76)
        Me.cboCentroCusto.Name = "cboCentroCusto"
        Me.cboCentroCusto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroCusto.Size = New System.Drawing.Size(371, 20)
        Me.cboCentroCusto.TabIndex = 7
        '
        'lblCentroCusto
        '
        Me.lblCentroCusto.AutoSize = True
        Me.lblCentroCusto.Location = New System.Drawing.Point(215, 58)
        Me.lblCentroCusto.Name = "lblCentroCusto"
        Me.lblCentroCusto.Size = New System.Drawing.Size(88, 14)
        Me.lblCentroCusto.TabIndex = 18
        Me.lblCentroCusto.Text = "Centro de Custo:"
        '
        'lblNumeroContrato
        '
        Me.lblNumeroContrato.AutoSize = True
        Me.lblNumeroContrato.Location = New System.Drawing.Point(6, 16)
        Me.lblNumeroContrato.Name = "lblNumeroContrato"
        Me.lblNumeroContrato.Size = New System.Drawing.Size(91, 14)
        Me.lblNumeroContrato.TabIndex = 17
        Me.lblNumeroContrato.Text = "Número Contrato:"
        '
        'txtNumeroContrato
        '
        Me.txtNumeroContrato.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroContrato.Location = New System.Drawing.Point(9, 33)
        Me.txtNumeroContrato.MaxLength = 60
        Me.txtNumeroContrato.Name = "txtNumeroContrato"
        Me.txtNumeroContrato.ReadOnly = True
        Me.txtNumeroContrato.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroContrato.TabIndex = 0
        '
        'txtDescritivo
        '
        Me.txtDescritivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescritivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivo.Location = New System.Drawing.Point(11, 120)
        Me.txtDescritivo.MaxLength = 60
        Me.txtDescritivo.Name = "txtDescritivo"
        Me.txtDescritivo.Size = New System.Drawing.Size(876, 20)
        Me.txtDescritivo.TabIndex = 11
        '
        'lblDescritivo
        '
        Me.lblDescritivo.AutoSize = True
        Me.lblDescritivo.Location = New System.Drawing.Point(8, 103)
        Me.lblDescritivo.Name = "lblDescritivo"
        Me.lblDescritivo.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivo.TabIndex = 2
        Me.lblDescritivo.Text = "Descritivo:"
        '
        'txtValorMensal
        '
        Me.txtValorMensal.DecimalDigits = 2
        Me.txtValorMensal.Location = New System.Drawing.Point(10, 76)
        Me.txtValorMensal.Name = "txtValorMensal"
        Me.txtValorMensal.Size = New System.Drawing.Size(98, 20)
        Me.txtValorMensal.TabIndex = 5
        Me.txtValorMensal.Text = "0,00"
        Me.txtValorMensal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(8, 58)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(72, 14)
        Me.lblValor.TabIndex = 10
        Me.lblValor.Text = "Valor Mensal:"
        '
        'txtDiaVencimento
        '
        Me.txtDiaVencimento.DecimalDigits = 0
        Me.txtDiaVencimento.Location = New System.Drawing.Point(805, 33)
        Me.txtDiaVencimento.Name = "txtDiaVencimento"
        Me.txtDiaVencimento.Size = New System.Drawing.Size(82, 20)
        Me.txtDiaVencimento.TabIndex = 4
        Me.txtDiaVencimento.Text = "0"
        Me.txtDiaVencimento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDiaVencimento
        '
        Me.lblDiaVencimento.AutoSize = True
        Me.lblDiaVencimento.Location = New System.Drawing.Point(803, 16)
        Me.lblDiaVencimento.Name = "lblDiaVencimento"
        Me.lblDiaVencimento.Size = New System.Drawing.Size(84, 14)
        Me.lblDiaVencimento.TabIndex = 8
        Me.lblDiaVencimento.Text = "Dia Vencimento:"
        '
        'lblDataTermino
        '
        Me.lblDataTermino.AutoSize = True
        Me.lblDataTermino.Location = New System.Drawing.Point(697, 16)
        Me.lblDataTermino.Name = "lblDataTermino"
        Me.lblDataTermino.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTermino.TabIndex = 6
        Me.lblDataTermino.Text = "Data Término:"
        '
        'dtpDataTermino
        '
        Me.dtpDataTermino.Checked = False
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(700, 33)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataTermino.TabIndex = 3
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.Checked = False
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(595, 33)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataInicio.TabIndex = 2
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(592, 16)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicio.TabIndex = 4
        Me.lblDataInicio.Text = "Data Início:"
        '
        'cboParceiroNegocio
        '
        Me.cboParceiroNegocio.AutoSize = False
        Me.cboParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = "SIM"
        UiComboBoxItem7.Value = True
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = "NÃO"
        UiComboBoxItem8.Value = False
        Me.cboParceiroNegocio.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboParceiroNegocio.Location = New System.Drawing.Point(114, 33)
        Me.cboParceiroNegocio.Name = "cboParceiroNegocio"
        Me.cboParceiroNegocio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboParceiroNegocio.Size = New System.Drawing.Size(475, 20)
        Me.cboParceiroNegocio.TabIndex = 1
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(111, 16)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocio.TabIndex = 0
        Me.lblParceiroNegocio.Text = "Parceiro de Negócio:"
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
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Contrato"
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(56, 370)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 4
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(33, 370)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 3
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 370)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Contrato"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(796, 74)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 16
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(227, 25)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaCancelado.TabIndex = 17
        Me.picLegendaCancelado.TabStop = False
        '
        'picLegendaConcluido
        '
        Me.picLegendaConcluido.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaConcluido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaConcluido.Location = New System.Drawing.Point(156, 25)
        Me.picLegendaConcluido.Name = "picLegendaConcluido"
        Me.picLegendaConcluido.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaConcluido.TabIndex = 11
        Me.picLegendaConcluido.TabStop = False
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(700, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 1
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'picLegendaProducao
        '
        Me.picLegendaProducao.BackColor = System.Drawing.Color.DarkGray
        Me.picLegendaProducao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaProducao.Location = New System.Drawing.Point(6, 25)
        Me.picLegendaProducao.Name = "picLegendaProducao"
        Me.picLegendaProducao.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaProducao.TabIndex = 13
        Me.picLegendaProducao.TabStop = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(603, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 0
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
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
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'usrCmpContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpContrato"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaProducao, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtParceiroNegocioFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDiaVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataTerminoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicioTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataInicioFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoTituloFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoTituloFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAtivoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblParceiroNegocioFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAtivoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescritivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescritivo As System.Windows.Forms.Label
    Friend WithEvents txtValorMensal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtDiaVencimento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDiaVencimento As System.Windows.Forms.Label
    Friend WithEvents lblDataTermino As System.Windows.Forms.Label
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents cboParceiroNegocio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDiaVencimentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboCentroCusto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroCusto As System.Windows.Forms.Label
    Friend WithEvents lblNumeroContrato As System.Windows.Forms.Label
    Friend WithEvents txtNumeroContrato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTolerancia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTolerancica As System.Windows.Forms.Label
    Friend WithEvents lblTipoTituloFinanceiro As System.Windows.Forms.Label
    Friend WithEvents cboTipoTitulo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelado As System.Windows.Forms.Label
    Friend WithEvents picLegendaConcluido As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaConcluido As System.Windows.Forms.Label
    Friend WithEvents picLegendaProducao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaProducao As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtNumeroContratoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroContratoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoContrato As System.Windows.Forms.Label
    Friend WithEvents cboTipoContrato As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoContratoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoContratoFiltro As Janus.Windows.EditControls.UIComboBox

End Class
