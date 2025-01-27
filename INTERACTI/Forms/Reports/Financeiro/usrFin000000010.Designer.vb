<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFin000000010
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFin000000010))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkMovimentacao = New Janus.Windows.EditControls.UICheckBox()
        Me.chkLeSix = New Janus.Windows.EditControls.UICheckBox()
        Me.btnFiltrarGrid = New Janus.Windows.EditControls.UIButton()
        Me.chkLavalpa = New Janus.Windows.EditControls.UICheckBox()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.dtpDataPagamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPagamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPagamento = New System.Windows.Forms.Label()
        Me.lblDataVencimento = New System.Windows.Forms.Label()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.grpParceiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkParceiro = New Janus.Windows.EditControls.UICheckBox()
        Me.lblInformacao = New System.Windows.Forms.Label()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtCentroCustroFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCentroCustroFiltro = New System.Windows.Forms.Label()
        Me.trvMain = New System.Windows.Forms.TreeView()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExportarRelatorio = New Janus.Windows.EditControls.UIButton()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnConfiguraGridListagem = New System.Windows.Forms.Button()
        Me.btnExcelListagem = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpParceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParceiro.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.lblInformacao)
        Me.pagLista.Controls.Add(Me.UiGroupBox1)
        Me.pagLista.Controls.Add(Me.trvMain)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.btnConfiguraGridListagem)
        Me.pagLista.Controls.Add(Me.btnExcelListagem)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Financeiro - FIN000000010"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.chkMovimentacao)
        Me.grpFiltro.Controls.Add(Me.chkLeSix)
        Me.grpFiltro.Controls.Add(Me.btnFiltrarGrid)
        Me.grpFiltro.Controls.Add(Me.chkLavalpa)
        Me.grpFiltro.Controls.Add(Me.cboTipo)
        Me.grpFiltro.Controls.Add(Me.lblTipo)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPagamentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPagamento)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimento)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissao)
        Me.grpFiltro.Controls.Add(Me.grpParceiro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(319, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(671, 107)
        Me.grpFiltro.TabIndex = 2
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'chkMovimentacao
        '
        Me.chkMovimentacao.Location = New System.Drawing.Point(572, 42)
        Me.chkMovimentacao.Name = "chkMovimentacao"
        Me.chkMovimentacao.Size = New System.Drawing.Size(101, 35)
        Me.chkMovimentacao.TabIndex = 26
        Me.chkMovimentacao.Text = "Movimentação Financeira"
        '
        'chkLeSix
        '
        Me.chkLeSix.Enabled = False
        Me.chkLeSix.Location = New System.Drawing.Point(483, 48)
        Me.chkLeSix.Name = "chkLeSix"
        Me.chkLeSix.Size = New System.Drawing.Size(65, 18)
        Me.chkLeSix.TabIndex = 20
        Me.chkLeSix.Text = "Le Six"
        '
        'btnFiltrarGrid
        '
        Me.btnFiltrarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarGrid.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarGrid.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarGrid.Location = New System.Drawing.Point(572, 74)
        Me.btnFiltrarGrid.Name = "btnFiltrarGrid"
        Me.btnFiltrarGrid.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarGrid.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarGrid.TabIndex = 11
        Me.btnFiltrarGrid.Text = "Filtrar"
        Me.btnFiltrarGrid.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chkLavalpa
        '
        Me.chkLavalpa.Enabled = False
        Me.chkLavalpa.Location = New System.Drawing.Point(483, 68)
        Me.chkLavalpa.Name = "chkLavalpa"
        Me.chkLavalpa.Size = New System.Drawing.Size(65, 18)
        Me.chkLavalpa.TabIndex = 21
        Me.chkLavalpa.Text = "Lavalpa"
        '
        'cboTipo
        '
        Me.cboTipo.Location = New System.Drawing.Point(10, 37)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(222, 20)
        Me.cboTipo.TabIndex = 1
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipo.Location = New System.Drawing.Point(7, 20)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo:"
        '
        'dtpDataPagamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoTerminoFiltro.Location = New System.Drawing.Point(352, 77)
        Me.dtpDataPagamentoTerminoFiltro.Name = "dtpDataPagamentoTerminoFiltro"
        Me.dtpDataPagamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPagamentoTerminoFiltro.TabIndex = 10
        Me.dtpDataPagamentoTerminoFiltro.Value = New Date(2014, 5, 11, 0, 0, 0, 0)
        '
        'dtpDataPagamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPagamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoInicioFiltro.Location = New System.Drawing.Point(238, 77)
        Me.dtpDataPagamentoInicioFiltro.Name = "dtpDataPagamentoInicioFiltro"
        Me.dtpDataPagamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPagamentoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPagamentoInicioFiltro.TabIndex = 9
        Me.dtpDataPagamentoInicioFiltro.Value = New Date(2014, 5, 11, 0, 0, 0, 0)
        '
        'dtpDataVencimentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoFiltro.Location = New System.Drawing.Point(124, 77)
        Me.dtpDataVencimentoTerminoFiltro.Name = "dtpDataVencimentoTerminoFiltro"
        Me.dtpDataVencimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataVencimentoTerminoFiltro.TabIndex = 7
        Me.dtpDataVencimentoTerminoFiltro.Value = New Date(2014, 5, 11, 0, 0, 0, 0)
        '
        'dtpDataVencimentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioFiltro.Location = New System.Drawing.Point(10, 77)
        Me.dtpDataVencimentoInicioFiltro.Name = "dtpDataVencimentoInicioFiltro"
        Me.dtpDataVencimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataVencimentoInicioFiltro.TabIndex = 6
        Me.dtpDataVencimentoInicioFiltro.Value = New Date(2014, 5, 11, 0, 0, 0, 0)
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(352, 37)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 4
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2014, 5, 11, 0, 0, 0, 0)
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(238, 37)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 3
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2014, 5, 11, 0, 0, 0, 0)
        '
        'lblDataPagamento
        '
        Me.lblDataPagamento.AutoSize = True
        Me.lblDataPagamento.Location = New System.Drawing.Point(235, 60)
        Me.lblDataPagamento.Name = "lblDataPagamento"
        Me.lblDataPagamento.Size = New System.Drawing.Size(85, 14)
        Me.lblDataPagamento.TabIndex = 8
        Me.lblDataPagamento.Text = "Data Pagamento"
        '
        'lblDataVencimento
        '
        Me.lblDataVencimento.AutoSize = True
        Me.lblDataVencimento.Location = New System.Drawing.Point(7, 60)
        Me.lblDataVencimento.Name = "lblDataVencimento"
        Me.lblDataVencimento.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimento.TabIndex = 5
        Me.lblDataVencimento.Text = "Data Vencimento:"
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(235, 20)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 2
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'grpParceiro
        '
        Me.grpParceiro.BackColor = System.Drawing.Color.Transparent
        Me.grpParceiro.Controls.Add(Me.chkParceiro)
        Me.grpParceiro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpParceiro.Location = New System.Drawing.Point(466, 33)
        Me.grpParceiro.Name = "grpParceiro"
        Me.grpParceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpParceiro.Size = New System.Drawing.Size(89, 60)
        Me.grpParceiro.TabIndex = 22
        Me.grpParceiro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpParceiro.VisualStyleManager = Me.vsmMain
        '
        'chkParceiro
        '
        Me.chkParceiro.Location = New System.Drawing.Point(6, 0)
        Me.chkParceiro.Name = "chkParceiro"
        Me.chkParceiro.Size = New System.Drawing.Size(65, 18)
        Me.chkParceiro.TabIndex = 20
        '
        'lblInformacao
        '
        Me.lblInformacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInformacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblInformacao.ForeColor = System.Drawing.Color.Firebrick
        Me.lblInformacao.Location = New System.Drawing.Point(14, 452)
        Me.lblInformacao.Name = "lblInformacao"
        Me.lblInformacao.Size = New System.Drawing.Size(296, 28)
        Me.lblInformacao.TabIndex = 4
        Me.lblInformacao.Text = "Desmarque os Centros de Gasto que deseja Eliminar do Relatório"
        Me.lblInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnFiltrar)
        Me.UiGroupBox1.Controls.Add(Me.txtCentroCustroFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblCentroCustroFiltro)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(302, 64)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(202, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtCentroCustroFiltro
        '
        Me.txtCentroCustroFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentroCustroFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCentroCustroFiltro.MaxLength = 100
        Me.txtCentroCustroFiltro.Name = "txtCentroCustroFiltro"
        Me.txtCentroCustroFiltro.Size = New System.Drawing.Size(178, 20)
        Me.txtCentroCustroFiltro.TabIndex = 1
        '
        'lblCentroCustroFiltro
        '
        Me.lblCentroCustroFiltro.AutoSize = True
        Me.lblCentroCustroFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCentroCustroFiltro.Name = "lblCentroCustroFiltro"
        Me.lblCentroCustroFiltro.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroCustroFiltro.TabIndex = 0
        Me.lblCentroCustroFiltro.Text = "Centro de Gasto:"
        '
        'trvMain
        '
        Me.trvMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvMain.CheckBoxes = True
        Me.trvMain.FullRowSelect = True
        Me.trvMain.ItemHeight = 20
        Me.trvMain.Location = New System.Drawing.Point(8, 76)
        Me.trvMain.Name = "trvMain"
        Me.trvMain.ShowLines = False
        Me.trvMain.ShowNodeToolTips = True
        Me.trvMain.Size = New System.Drawing.Size(302, 373)
        Me.trvMain.TabIndex = 1
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExportarRelatorio)
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExportarRelatorio
        '
        Me.btnExportarRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarRelatorio.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExportarRelatorio.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExportarRelatorio.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExportarRelatorio.Location = New System.Drawing.Point(9, 17)
        Me.btnExportarRelatorio.Name = "btnExportarRelatorio"
        Me.btnExportarRelatorio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExportarRelatorio.Size = New System.Drawing.Size(131, 23)
        Me.btnExportarRelatorio.TabIndex = 2
        Me.btnExportarRelatorio.Text = "Exportar Relatório"
        Me.btnExportarRelatorio.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnVisualizarImpressao.TabIndex = 0
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
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfiguraGridListagem
        '
        Me.btnConfiguraGridListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGridListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGridListagem.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGridListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGridListagem.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfiguraGridListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGridListagem.Location = New System.Drawing.Point(320, 463)
        Me.btnConfiguraGridListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGridListagem.Name = "btnConfiguraGridListagem"
        Me.btnConfiguraGridListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGridListagem.TabIndex = 101
        Me.btnConfiguraGridListagem.TabStop = False
        Me.btnConfiguraGridListagem.UseVisualStyleBackColor = False
        '
        'btnExcelListagem
        '
        Me.btnExcelListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelListagem.FlatAppearance.BorderSize = 0
        Me.btnExcelListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelListagem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelListagem.Location = New System.Drawing.Point(344, 463)
        Me.btnExcelListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelListagem.Name = "btnExcelListagem"
        Me.btnExcelListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelListagem.TabIndex = 102
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
        Me.grdListagem.ColumnAutoResize = True
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
        Me.grdListagem.Location = New System.Drawing.Point(319, 119)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(671, 361)
        Me.grdListagem.TabIndex = 100
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'usrFin000000010
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFin000000010"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpParceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParceiro.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCentroCustroFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCentroCustroFiltro As System.Windows.Forms.Label
    Friend WithEvents trvMain As System.Windows.Forms.TreeView
    Friend WithEvents lblInformacao As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarGrid As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents dtpDataPagamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPagamento As System.Windows.Forms.Label
    Friend WithEvents lblDataVencimento As System.Windows.Forms.Label
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents chkLeSix As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkLavalpa As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grpParceiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkParceiro As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelListagem As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGridListagem As System.Windows.Forms.Button
    Friend WithEvents btnExportarRelatorio As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkMovimentacao As Janus.Windows.EditControls.UICheckBox

End Class
