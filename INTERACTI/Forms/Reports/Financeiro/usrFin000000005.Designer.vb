<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFin000000005
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFin000000005))
        Dim cboFormaPagamentoFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkLeSix = New Janus.Windows.EditControls.UICheckBox()
        Me.cboFormaPagamentoFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataPagamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPagamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPagamentoFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarParceiroNegocio = New System.Windows.Forms.Button()
        Me.lblContaBancariaFiltro = New System.Windows.Forms.Label()
        Me.cboContaBancariaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAgrupadoPorFiltro = New System.Windows.Forms.Label()
        Me.cboAgrupadoPorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFormaPagamentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataVencimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataVencimentoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblParceiroNegocioFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.cboParceiroNegocioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.grpParceiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkLavalpa = New Janus.Windows.EditControls.UICheckBox()
        Me.chkParceiro = New Janus.Windows.EditControls.UICheckBox()
        Me.btnExcelListagem = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.chkMovimentacao = New Janus.Windows.EditControls.UICheckBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpParceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParceiro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.btnExcelListagem)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Financeiro - FIN000000005"
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
        Me.btnConfigurarGrid.TabIndex = 88
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(7, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 3
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(102, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 4
        Me.cboCongelarColuna.TabStop = False
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(676, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(200, 23)
        Me.btnVisualizarImpressao.TabIndex = 1
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.chkMovimentacao)
        Me.grpFiltro.Controls.Add(Me.chkLeSix)
        Me.grpFiltro.Controls.Add(Me.cboFormaPagamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPagamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarParceiroNegocio)
        Me.grpFiltro.Controls.Add(Me.lblContaBancariaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboContaBancariaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAgrupadoPorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAgrupadoPorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFormaPagamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.grpParceiro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 147)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'chkLeSix
        '
        Me.chkLeSix.Enabled = False
        Me.chkLeSix.Location = New System.Drawing.Point(888, 48)
        Me.chkLeSix.Name = "chkLeSix"
        Me.chkLeSix.Size = New System.Drawing.Size(65, 18)
        Me.chkLeSix.TabIndex = 25
        Me.chkLeSix.Text = "Le Six"
        '
        'cboFormaPagamentoFiltro
        '
        Me.cboFormaPagamentoFiltro.AllowDrop = True
        Me.cboFormaPagamentoFiltro.ButtonCancelText = "Cancelar"
        Me.cboFormaPagamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboFormaPagamentoFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboFormaPagamentoFiltro_DesignTimeLayout.LayoutString")
        Me.cboFormaPagamentoFiltro.DesignTimeLayout = cboFormaPagamentoFiltro_DesignTimeLayout
        Me.cboFormaPagamentoFiltro.Location = New System.Drawing.Point(10, 77)
        Me.cboFormaPagamentoFiltro.Name = "cboFormaPagamentoFiltro"
        Me.cboFormaPagamentoFiltro.SaveSettings = False
        Me.cboFormaPagamentoFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboFormaPagamentoFiltro.Size = New System.Drawing.Size(399, 20)
        Me.cboFormaPagamentoFiltro.TabIndex = 19
        Me.cboFormaPagamentoFiltro.ValuesDataMember = Nothing
        '
        'dtpDataPagamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoTerminoFiltro.Location = New System.Drawing.Point(124, 117)
        Me.dtpDataPagamentoTerminoFiltro.Name = "dtpDataPagamentoTerminoFiltro"
        Me.dtpDataPagamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPagamentoTerminoFiltro.TabIndex = 15
        '
        'dtpDataPagamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoInicioFiltro.Location = New System.Drawing.Point(10, 117)
        Me.dtpDataPagamentoInicioFiltro.Name = "dtpDataPagamentoInicioFiltro"
        Me.dtpDataPagamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPagamentoInicioFiltro.TabIndex = 14
        '
        'lblDataPagamentoFiltro
        '
        Me.lblDataPagamentoFiltro.AutoSize = True
        Me.lblDataPagamentoFiltro.Location = New System.Drawing.Point(7, 100)
        Me.lblDataPagamentoFiltro.Name = "lblDataPagamentoFiltro"
        Me.lblDataPagamentoFiltro.Size = New System.Drawing.Size(88, 14)
        Me.lblDataPagamentoFiltro.TabIndex = 13
        Me.lblDataPagamentoFiltro.Text = "Data Pagamento:"
        '
        'btnProcurarParceiroNegocio
        '
        Me.btnProcurarParceiroNegocio.FlatAppearance.BorderSize = 0
        Me.btnProcurarParceiroNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarParceiroNegocio.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarParceiroNegocio.Location = New System.Drawing.Point(392, 19)
        Me.btnProcurarParceiroNegocio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarParceiroNegocio.Name = "btnProcurarParceiroNegocio"
        Me.btnProcurarParceiroNegocio.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarParceiroNegocio.TabIndex = 2
        Me.btnProcurarParceiroNegocio.TabStop = False
        Me.btnProcurarParceiroNegocio.UseVisualStyleBackColor = True
        '
        'lblContaBancariaFiltro
        '
        Me.lblContaBancariaFiltro.AutoSize = True
        Me.lblContaBancariaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaBancariaFiltro.Location = New System.Drawing.Point(412, 20)
        Me.lblContaBancariaFiltro.Name = "lblContaBancariaFiltro"
        Me.lblContaBancariaFiltro.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancariaFiltro.TabIndex = 3
        Me.lblContaBancariaFiltro.Text = "Conta Bancária:"
        '
        'cboContaBancariaFiltro
        '
        Me.cboContaBancariaFiltro.Location = New System.Drawing.Point(415, 37)
        Me.cboContaBancariaFiltro.Name = "cboContaBancariaFiltro"
        Me.cboContaBancariaFiltro.Size = New System.Drawing.Size(450, 20)
        Me.cboContaBancariaFiltro.TabIndex = 4
        '
        'lblAgrupadoPorFiltro
        '
        Me.lblAgrupadoPorFiltro.AutoSize = True
        Me.lblAgrupadoPorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAgrupadoPorFiltro.Location = New System.Drawing.Point(235, 100)
        Me.lblAgrupadoPorFiltro.Name = "lblAgrupadoPorFiltro"
        Me.lblAgrupadoPorFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblAgrupadoPorFiltro.TabIndex = 16
        Me.lblAgrupadoPorFiltro.Text = "Agrupado por:"
        '
        'cboAgrupadoPorFiltro
        '
        Me.cboAgrupadoPorFiltro.Location = New System.Drawing.Point(238, 117)
        Me.cboAgrupadoPorFiltro.Name = "cboAgrupadoPorFiltro"
        Me.cboAgrupadoPorFiltro.Size = New System.Drawing.Size(285, 20)
        Me.cboAgrupadoPorFiltro.TabIndex = 17
        '
        'lblFormaPagamentoFiltro
        '
        Me.lblFormaPagamentoFiltro.AutoSize = True
        Me.lblFormaPagamentoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormaPagamentoFiltro.Location = New System.Drawing.Point(7, 60)
        Me.lblFormaPagamentoFiltro.Name = "lblFormaPagamentoFiltro"
        Me.lblFormaPagamentoFiltro.Size = New System.Drawing.Size(111, 14)
        Me.lblFormaPagamentoFiltro.TabIndex = 5
        Me.lblFormaPagamentoFiltro.Text = "Forma de Pagamento:"
        '
        'dtpDataVencimentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoFiltro.Location = New System.Drawing.Point(757, 77)
        Me.dtpDataVencimentoTerminoFiltro.Name = "dtpDataVencimentoTerminoFiltro"
        Me.dtpDataVencimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataVencimentoTerminoFiltro.TabIndex = 12
        '
        'dtpDataVencimentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioFiltro.Location = New System.Drawing.Point(643, 77)
        Me.dtpDataVencimentoInicioFiltro.Name = "dtpDataVencimentoInicioFiltro"
        Me.dtpDataVencimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataVencimentoInicioFiltro.TabIndex = 11
        '
        'lblDataVencimentoFiltro
        '
        Me.lblDataVencimentoFiltro.AutoSize = True
        Me.lblDataVencimentoFiltro.Location = New System.Drawing.Point(640, 60)
        Me.lblDataVencimentoFiltro.Name = "lblDataVencimentoFiltro"
        Me.lblDataVencimentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltro.TabIndex = 10
        Me.lblDataVencimentoFiltro.Text = "Data Vencimento:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(883, 114)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 18
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblParceiroNegocioFiltro
        '
        Me.lblParceiroNegocioFiltro.AutoSize = True
        Me.lblParceiroNegocioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocioFiltro.Location = New System.Drawing.Point(7, 20)
        Me.lblParceiroNegocioFiltro.Name = "lblParceiroNegocioFiltro"
        Me.lblParceiroNegocioFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocioFiltro.TabIndex = 0
        Me.lblParceiroNegocioFiltro.Text = "Parceiro de Negócio:"
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(529, 77)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 9
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(415, 77)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 8
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(412, 60)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 7
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'cboParceiroNegocioFiltro
        '
        Me.cboParceiroNegocioFiltro.Location = New System.Drawing.Point(10, 37)
        Me.cboParceiroNegocioFiltro.Name = "cboParceiroNegocioFiltro"
        Me.cboParceiroNegocioFiltro.Size = New System.Drawing.Size(399, 20)
        Me.cboParceiroNegocioFiltro.TabIndex = 1
        '
        'grpParceiro
        '
        Me.grpParceiro.BackColor = System.Drawing.Color.Transparent
        Me.grpParceiro.Controls.Add(Me.chkLavalpa)
        Me.grpParceiro.Controls.Add(Me.chkParceiro)
        Me.grpParceiro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpParceiro.Location = New System.Drawing.Point(871, 33)
        Me.grpParceiro.Name = "grpParceiro"
        Me.grpParceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpParceiro.Size = New System.Drawing.Size(89, 60)
        Me.grpParceiro.TabIndex = 26
        Me.grpParceiro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpParceiro.VisualStyleManager = Me.vsmMain
        '
        'chkLavalpa
        '
        Me.chkLavalpa.Enabled = False
        Me.chkLavalpa.Location = New System.Drawing.Point(17, 35)
        Me.chkLavalpa.Name = "chkLavalpa"
        Me.chkLavalpa.Size = New System.Drawing.Size(65, 18)
        Me.chkLavalpa.TabIndex = 25
        Me.chkLavalpa.Text = "Lavalpa"
        '
        'chkParceiro
        '
        Me.chkParceiro.Location = New System.Drawing.Point(6, 0)
        Me.chkParceiro.Name = "chkParceiro"
        Me.chkParceiro.Size = New System.Drawing.Size(65, 18)
        Me.chkParceiro.TabIndex = 20
        '
        'btnExcelListagem
        '
        Me.btnExcelListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelListagem.FlatAppearance.BorderSize = 0
        Me.btnExcelListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelListagem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelListagem.Location = New System.Drawing.Point(33, 463)
        Me.btnExcelListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelListagem.Name = "btnExcelListagem"
        Me.btnExcelListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelListagem.TabIndex = 100
        Me.btnExcelListagem.TabStop = False
        Me.btnExcelListagem.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 159)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 321)
        Me.grdListagem.TabIndex = 90
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'chkMovimentacao
        '
        Me.chkMovimentacao.Location = New System.Drawing.Point(536, 106)
        Me.chkMovimentacao.Name = "chkMovimentacao"
        Me.chkMovimentacao.Size = New System.Drawing.Size(101, 35)
        Me.chkMovimentacao.TabIndex = 26
        Me.chkMovimentacao.Text = "Movimentação Financeira"
        '
        'usrFin000000005
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFin000000005"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpParceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParceiro.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboParceiroNegocioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblParceiroNegocioFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblFormaPagamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblAgrupadoPorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAgrupadoPorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaBancariaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboContaBancariaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarParceiroNegocio As System.Windows.Forms.Button
    Friend WithEvents dtpDataPagamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPagamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamentoFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents chkLeSix As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grpParceiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkLavalpa As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkParceiro As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelListagem As System.Windows.Forms.Button
    Friend WithEvents chkMovimentacao As Janus.Windows.EditControls.UICheckBox

End Class
