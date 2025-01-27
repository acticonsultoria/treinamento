<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVen000000014
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
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVen000000014))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarProdutoFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarClienteFiltro = New System.Windows.Forms.Button()
        Me.dtpDataAceiteInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataAceiteTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataAceiteFiltro = New System.Windows.Forms.Label()
        Me.cboEstoqueFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEstoqueFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataEntregaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEntregaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPrevisaoEntregaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPrevisaoEntregaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.lblDataEntregaFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroPedidoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblPrazoEntregaFiltro = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.tadDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagGrafico = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrMain = New Dundas.Charting.WinControl.Chart()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.tadDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tadDados.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagGrafico.SuspendLayout()
        CType(Me.chrMain, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.tadDados)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Financeiro - VEN000000014"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataAceiteInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataAceiteTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataAceiteFiltro)
        Me.grpFiltro.Controls.Add(Me.cboEstoqueFiltro)
        Me.grpFiltro.Controls.Add(Me.lblEstoqueFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntregaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntregaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEntregaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblPrazoEntregaFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarProdutoFiltro
        '
        Me.btnProcurarProdutoFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarProdutoFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProdutoFiltro.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProdutoFiltro.Location = New System.Drawing.Point(319, 56)
        Me.btnProcurarProdutoFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProdutoFiltro.Name = "btnProcurarProdutoFiltro"
        Me.btnProcurarProdutoFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProdutoFiltro.TabIndex = 21
        Me.btnProcurarProdutoFiltro.TabStop = False
        Me.btnProcurarProdutoFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarClienteFiltro
        '
        Me.btnProcurarClienteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarClienteFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarClienteFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarClienteFiltro.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarClienteFiltro.Location = New System.Drawing.Point(827, 16)
        Me.btnProcurarClienteFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarClienteFiltro.Name = "btnProcurarClienteFiltro"
        Me.btnProcurarClienteFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarClienteFiltro.TabIndex = 20
        Me.btnProcurarClienteFiltro.TabStop = False
        Me.btnProcurarClienteFiltro.UseVisualStyleBackColor = True
        '
        'dtpDataAceiteInicioFiltro
        '
        '
        '
        '
        Me.dtpDataAceiteInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataAceiteInicioFiltro.Location = New System.Drawing.Point(342, 114)
        Me.dtpDataAceiteInicioFiltro.Name = "dtpDataAceiteInicioFiltro"
        Me.dtpDataAceiteInicioFiltro.ShowCheckBox = True
        Me.dtpDataAceiteInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataAceiteInicioFiltro.TabIndex = 17
        '
        'dtpDataAceiteTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataAceiteTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataAceiteTerminoFiltro.Location = New System.Drawing.Point(456, 114)
        Me.dtpDataAceiteTerminoFiltro.Name = "dtpDataAceiteTerminoFiltro"
        Me.dtpDataAceiteTerminoFiltro.ShowCheckBox = True
        Me.dtpDataAceiteTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataAceiteTerminoFiltro.TabIndex = 18
        '
        'lblDataAceiteFiltro
        '
        Me.lblDataAceiteFiltro.AutoSize = True
        Me.lblDataAceiteFiltro.Location = New System.Drawing.Point(339, 97)
        Me.lblDataAceiteFiltro.Name = "lblDataAceiteFiltro"
        Me.lblDataAceiteFiltro.Size = New System.Drawing.Size(65, 14)
        Me.lblDataAceiteFiltro.TabIndex = 16
        Me.lblDataAceiteFiltro.Text = "Data Aceite:"
        '
        'cboEstoqueFiltro
        '
        Me.cboEstoqueFiltro.AutoSize = False
        Me.cboEstoqueFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEstoqueFiltro.Location = New System.Drawing.Point(9, 114)
        Me.cboEstoqueFiltro.Name = "cboEstoqueFiltro"
        Me.cboEstoqueFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEstoqueFiltro.Size = New System.Drawing.Size(327, 20)
        Me.cboEstoqueFiltro.TabIndex = 15
        '
        'lblEstoqueFiltro
        '
        Me.lblEstoqueFiltro.AutoSize = True
        Me.lblEstoqueFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblEstoqueFiltro.Name = "lblEstoqueFiltro"
        Me.lblEstoqueFiltro.Size = New System.Drawing.Size(97, 14)
        Me.lblEstoqueFiltro.TabIndex = 14
        Me.lblEstoqueFiltro.Text = "Estoque / Trânsito:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(570, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(274, 20)
        Me.cboStatusFiltro.TabIndex = 13
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'dtpDataEntregaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEntregaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntregaInicioFiltro.Location = New System.Drawing.Point(342, 74)
        Me.dtpDataEntregaInicioFiltro.Name = "dtpDataEntregaInicioFiltro"
        Me.dtpDataEntregaInicioFiltro.ShowCheckBox = True
        Me.dtpDataEntregaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntregaInicioFiltro.TabIndex = 10
        '
        'dtpDataEntregaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEntregaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntregaTerminoFiltro.Location = New System.Drawing.Point(456, 74)
        Me.dtpDataEntregaTerminoFiltro.Name = "dtpDataEntregaTerminoFiltro"
        Me.dtpDataEntregaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEntregaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntregaTerminoFiltro.TabIndex = 11
        '
        'dtpDataPrevisaoEntregaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoEntregaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoEntregaInicioFiltro.Location = New System.Drawing.Point(114, 34)
        Me.dtpDataPrevisaoEntregaInicioFiltro.Name = "dtpDataPrevisaoEntregaInicioFiltro"
        Me.dtpDataPrevisaoEntregaInicioFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoEntregaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoEntregaInicioFiltro.TabIndex = 3
        '
        'dtpDataPrevisaoEntregaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoEntregaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Location = New System.Drawing.Point(228, 34)
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Name = "dtpDataPrevisaoEntregaTerminoFiltro"
        Me.dtpDataPrevisaoEntregaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoEntregaTerminoFiltro.TabIndex = 4
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(567, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 12
        Me.lblStatusFiltro.Text = "Status:"
        '
        'lblDataEntregaFiltro
        '
        Me.lblDataEntregaFiltro.AutoSize = True
        Me.lblDataEntregaFiltro.Location = New System.Drawing.Point(339, 57)
        Me.lblDataEntregaFiltro.Name = "lblDataEntregaFiltro"
        Me.lblDataEntregaFiltro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntregaFiltro.TabIndex = 9
        Me.lblDataEntregaFiltro.Text = "Data Entrega:"
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtProdutoFiltro.MaxLength = 60
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(327, 20)
        Me.txtProdutoFiltro.TabIndex = 8
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 7
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteFiltro.Location = New System.Drawing.Point(342, 34)
        Me.txtClienteFiltro.MaxLength = 60
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.Size = New System.Drawing.Size(502, 20)
        Me.txtClienteFiltro.TabIndex = 6
        '
        'txtNumeroPedidoFiltro
        '
        Me.txtNumeroPedidoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroPedidoFiltro.MaxLength = 20
        Me.txtNumeroPedidoFiltro.Name = "txtNumeroPedidoFiltro"
        Me.txtNumeroPedidoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroPedidoFiltro.TabIndex = 1
        '
        'lblNumeroPedidoFiltro
        '
        Me.lblNumeroPedidoFiltro.AutoSize = True
        Me.lblNumeroPedidoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroPedidoFiltro.Name = "lblNumeroPedidoFiltro"
        Me.lblNumeroPedidoFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedidoFiltro.TabIndex = 0
        Me.lblNumeroPedidoFiltro.Text = "Nº Pedido:"
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(339, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 5
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 19
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblPrazoEntregaFiltro
        '
        Me.lblPrazoEntregaFiltro.AutoSize = True
        Me.lblPrazoEntregaFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblPrazoEntregaFiltro.Name = "lblPrazoEntregaFiltro"
        Me.lblPrazoEntregaFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblPrazoEntregaFiltro.TabIndex = 2
        Me.lblPrazoEntregaFiltro.Text = "Previsão de Entrega:"
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
        Me.lblCongelarColuna.TabIndex = 5
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(102, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 6
        Me.cboCongelarColuna.TabStop = False
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(676, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(200, 23)
        Me.btnVisualizarImpressao.TabIndex = 0
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.Visible = False
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
        'tadDados
        '
        Me.tadDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tadDados.BackColor = System.Drawing.Color.Transparent
        Me.tadDados.Location = New System.Drawing.Point(8, 153)
        Me.tadDados.Name = "tadDados"
        Me.tadDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tadDados.ShowFocusRectangle = False
        Me.tadDados.Size = New System.Drawing.Size(982, 327)
        Me.tadDados.TabIndex = 1
        Me.tadDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagGrafico})
        Me.tadDados.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(980, 304)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Listagem"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(58, 277)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 92
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(34, 277)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 91
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(10, 277)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 90
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
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
        Me.grdListagem.Location = New System.Drawing.Point(9, 9)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(963, 285)
        Me.grdListagem.TabIndex = 0
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagGrafico
        '
        Me.pagGrafico.Controls.Add(Me.chrMain)
        Me.pagGrafico.Location = New System.Drawing.Point(1, 22)
        Me.pagGrafico.Name = "pagGrafico"
        Me.pagGrafico.Size = New System.Drawing.Size(980, 304)
        Me.pagGrafico.TabStop = True
        Me.pagGrafico.Text = "Gráfico"
        '
        'chrMain
        '
        Me.chrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrMain.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrMain.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrMain.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.Title = "Força (gf)"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Velocidade"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrMain.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Default"
        Me.chrMain.Legends.Add(Legend1)
        Me.chrMain.Location = New System.Drawing.Point(9, 9)
        Me.chrMain.Name = "chrMain"
        Me.chrMain.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrMain.Size = New System.Drawing.Size(963, 286)
        Me.chrMain.TabIndex = 4
        Title1.Name = "Title1"
        Title1.Text = "Grupo de Item x Faturamento"
        Me.chrMain.Titles.Add(Title1)
        Me.chrMain.UI.Toolbar.Enabled = True
        '
        'usrVen000000014
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrVen000000014"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.tadDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tadDados.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagGrafico.ResumeLayout(False)
        CType(Me.chrMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents tadDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagGrafico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents chrMain As Dundas.Charting.WinControl.Chart
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarProdutoFiltro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarClienteFiltro As System.Windows.Forms.Button
    Friend WithEvents dtpDataAceiteInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataAceiteTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataAceiteFiltro As System.Windows.Forms.Label
    Friend WithEvents cboEstoqueFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblEstoqueFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents dtpDataEntregaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntregaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPrevisaoEntregaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPrevisaoEntregaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataEntregaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroPedidoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPrazoEntregaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button

End Class
