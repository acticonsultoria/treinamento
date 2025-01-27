<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrOcr000000001
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
        Dim JanusColorScheme3 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdAnalitico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdStatus_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdTempo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrOcr000000001))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabRelatorios = New Janus.Windows.UI.Tab.UITab()
        Me.pagRelatorioTempo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdAnalitico = New Janus.Windows.GridEX.GridEX()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab()
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdStatus = New Janus.Windows.GridEX.GridEX()
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdTempo = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroPedidoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoFiltro = New System.Windows.Forms.Label()
        Me.txtLoteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLoteFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtSemanaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSemanaFiltro = New System.Windows.Forms.Label()
        Me.txtRevendedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroNotaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroNotaFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroProtocoloFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroProtocoloFiltro = New System.Windows.Forms.Label()
        Me.dtpDataOcorrenciaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataOcorrenciaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataOcorrenciaFiltro = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.tabRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRelatorios.SuspendLayout()
        Me.pagRelatorioTempo.SuspendLayout()
        CType(Me.grdAnalitico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.grdStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage3.SuspendLayout()
        CType(Me.grdTempo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme3.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme3.Name = "Scheme"
        JanusColorScheme3.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme3.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme3.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme3)
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
        Me.pagLista.Controls.Add(Me.tabRelatorios)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório de Ocorrência - OCR000000001"
        '
        'tabRelatorios
        '
        Me.tabRelatorios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabRelatorios.BackColor = System.Drawing.Color.Transparent
        Me.tabRelatorios.FlatBorderColor = System.Drawing.SystemColors.Control
        Me.tabRelatorios.Location = New System.Drawing.Point(9, 113)
        Me.tabRelatorios.Name = "tabRelatorios"
        Me.tabRelatorios.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabRelatorios.ShowFocusRectangle = False
        Me.tabRelatorios.Size = New System.Drawing.Size(981, 364)
        Me.tabRelatorios.TabIndex = 6
        Me.tabRelatorios.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagRelatorioTempo, Me.UiTabPage1})
        Me.tabRelatorios.TabStop = False
        Me.tabRelatorios.VisualStyleManager = Me.vsmMain
        '
        'pagRelatorioTempo
        '
        Me.pagRelatorioTempo.Controls.Add(Me.grdAnalitico)
        Me.pagRelatorioTempo.Key = "pagTabela"
        Me.pagRelatorioTempo.Location = New System.Drawing.Point(1, 22)
        Me.pagRelatorioTempo.Name = "pagRelatorioTempo"
        Me.pagRelatorioTempo.Size = New System.Drawing.Size(979, 341)
        Me.pagRelatorioTempo.TabStop = True
        Me.pagRelatorioTempo.Text = "Analítico"
        '
        'grdAnalitico
        '
        Me.grdAnalitico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdAnalitico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdAnalitico_DesignTimeLayout.LayoutString = resources.GetString("grdAnalitico_DesignTimeLayout.LayoutString")
        Me.grdAnalitico.DesignTimeLayout = grdAnalitico_DesignTimeLayout
        Me.grdAnalitico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdAnalitico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdAnalitico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdAnalitico.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdAnalitico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdAnalitico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdAnalitico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdAnalitico.GroupByBoxVisible = False
        Me.grdAnalitico.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdAnalitico.Location = New System.Drawing.Point(9, 11)
        Me.grdAnalitico.Name = "grdAnalitico"
        Me.grdAnalitico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdAnalitico.RecordNavigator = True
        Me.grdAnalitico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdAnalitico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdAnalitico.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdAnalitico.Size = New System.Drawing.Size(956, 315)
        Me.grdAnalitico.TabIndex = 2
        Me.grdAnalitico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdAnalitico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdAnalitico.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdAnalitico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdAnalitico.VisualStyleManager = Me.vsmMain
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.UiTab1)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 22)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(979, 341)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Sintético"
        '
        'UiTab1
        '
        Me.UiTab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTab1.BackColor = System.Drawing.Color.Transparent
        Me.UiTab1.FlatBorderColor = System.Drawing.SystemColors.Control
        Me.UiTab1.Location = New System.Drawing.Point(3, 3)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiTab1.ShowFocusRectangle = False
        Me.UiTab1.Size = New System.Drawing.Size(973, 335)
        Me.UiTab1.TabIndex = 8
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage2, Me.UiTabPage3})
        Me.UiTab1.TabStop = False
        Me.UiTab1.VisualStyleManager = Me.vsmMain
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.grdStatus)
        Me.UiTabPage2.Key = "pagTabela"
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 22)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(971, 312)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Status"
        '
        'grdStatus
        '
        Me.grdStatus.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdStatus_DesignTimeLayout.LayoutString = resources.GetString("grdStatus_DesignTimeLayout.LayoutString")
        Me.grdStatus.DesignTimeLayout = grdStatus_DesignTimeLayout
        Me.grdStatus.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdStatus.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdStatus.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdStatus.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdStatus.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdStatus.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdStatus.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdStatus.GroupByBoxVisible = False
        Me.grdStatus.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdStatus.Location = New System.Drawing.Point(11, 9)
        Me.grdStatus.Name = "grdStatus"
        Me.grdStatus.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdStatus.RecordNavigator = True
        Me.grdStatus.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdStatus.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdStatus.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdStatus.Size = New System.Drawing.Size(948, 286)
        Me.grdStatus.TabIndex = 2
        Me.grdStatus.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdStatus.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdStatus.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdStatus.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdStatus.VisualStyleManager = Me.vsmMain
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.grdTempo)
        Me.UiTabPage3.Location = New System.Drawing.Point(1, 22)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(971, 312)
        Me.UiTabPage3.TabStop = True
        Me.UiTabPage3.Text = "Tempo"
        '
        'grdTempo
        '
        Me.grdTempo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdTempo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdTempo_DesignTimeLayout.LayoutString = resources.GetString("grdTempo_DesignTimeLayout.LayoutString")
        Me.grdTempo.DesignTimeLayout = grdTempo_DesignTimeLayout
        Me.grdTempo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdTempo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdTempo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdTempo.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdTempo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdTempo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdTempo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdTempo.GroupByBoxVisible = False
        Me.grdTempo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdTempo.Location = New System.Drawing.Point(9, 11)
        Me.grdTempo.Name = "grdTempo"
        Me.grdTempo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdTempo.RecordNavigator = True
        Me.grdTempo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdTempo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdTempo.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdTempo.Size = New System.Drawing.Size(948, 286)
        Me.grdTempo.TabIndex = 3
        Me.grdTempo.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdTempo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdTempo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdTempo.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdTempo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdTempo.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtSemanaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSemanaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtRevendedorFiltro)
        Me.grpFiltro.Controls.Add(Me.Label1)
        Me.grpFiltro.Controls.Add(Me.txtNumeroNotaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroNotaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroProtocoloFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroProtocoloFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataOcorrenciaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataOcorrenciaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataOcorrenciaFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 104)
        Me.grpFiltro.TabIndex = 5
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(261, 20)
        Me.cboStatusFiltro.TabIndex = 26
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 25
        Me.lblStatusFiltro.Text = "Status:"
        '
        'txtNumeroPedidoFiltro
        '
        Me.txtNumeroPedidoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoFiltro.Location = New System.Drawing.Point(449, 74)
        Me.txtNumeroPedidoFiltro.MaxLength = 20
        Me.txtNumeroPedidoFiltro.Name = "txtNumeroPedidoFiltro"
        Me.txtNumeroPedidoFiltro.Size = New System.Drawing.Size(95, 20)
        Me.txtNumeroPedidoFiltro.TabIndex = 19
        '
        'lblNumeroPedidoFiltro
        '
        Me.lblNumeroPedidoFiltro.AutoSize = True
        Me.lblNumeroPedidoFiltro.Location = New System.Drawing.Point(446, 57)
        Me.lblNumeroPedidoFiltro.Name = "lblNumeroPedidoFiltro"
        Me.lblNumeroPedidoFiltro.Size = New System.Drawing.Size(56, 14)
        Me.lblNumeroPedidoFiltro.TabIndex = 18
        Me.lblNumeroPedidoFiltro.Text = "N° Pedido:"
        '
        'txtLoteFiltro
        '
        Me.txtLoteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteFiltro.Location = New System.Drawing.Point(363, 74)
        Me.txtLoteFiltro.MaxLength = 20
        Me.txtLoteFiltro.Name = "txtLoteFiltro"
        Me.txtLoteFiltro.Size = New System.Drawing.Size(80, 20)
        Me.txtLoteFiltro.TabIndex = 17
        '
        'lblLoteFiltro
        '
        Me.lblLoteFiltro.AutoSize = True
        Me.lblLoteFiltro.Location = New System.Drawing.Point(360, 57)
        Me.lblLoteFiltro.Name = "lblLoteFiltro"
        Me.lblLoteFiltro.Size = New System.Drawing.Size(31, 14)
        Me.lblLoteFiltro.TabIndex = 16
        Me.lblLoteFiltro.Text = "Lote:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 0
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtSemanaFiltro
        '
        Me.txtSemanaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSemanaFiltro.Location = New System.Drawing.Point(277, 74)
        Me.txtSemanaFiltro.MaxLength = 20
        Me.txtSemanaFiltro.Name = "txtSemanaFiltro"
        Me.txtSemanaFiltro.Size = New System.Drawing.Size(80, 20)
        Me.txtSemanaFiltro.TabIndex = 13
        '
        'lblSemanaFiltro
        '
        Me.lblSemanaFiltro.AutoSize = True
        Me.lblSemanaFiltro.Location = New System.Drawing.Point(274, 57)
        Me.lblSemanaFiltro.Name = "lblSemanaFiltro"
        Me.lblSemanaFiltro.Size = New System.Drawing.Size(49, 14)
        Me.lblSemanaFiltro.TabIndex = 14
        Me.lblSemanaFiltro.Text = "Semana:"
        '
        'txtRevendedorFiltro
        '
        Me.txtRevendedorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRevendedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevendedorFiltro.Location = New System.Drawing.Point(598, 34)
        Me.txtRevendedorFiltro.MaxLength = 20
        Me.txtRevendedorFiltro.Name = "txtRevendedorFiltro"
        Me.txtRevendedorFiltro.Size = New System.Drawing.Size(236, 20)
        Me.txtRevendedorFiltro.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(595, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Revendedor(a):"
        '
        'txtNumeroNotaFiltro
        '
        Me.txtNumeroNotaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroNotaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroNotaFiltro.Location = New System.Drawing.Point(507, 34)
        Me.txtNumeroNotaFiltro.MaxLength = 20
        Me.txtNumeroNotaFiltro.Name = "txtNumeroNotaFiltro"
        Me.txtNumeroNotaFiltro.Size = New System.Drawing.Size(85, 20)
        Me.txtNumeroNotaFiltro.TabIndex = 8
        '
        'lblNumeroNotaFiltro
        '
        Me.lblNumeroNotaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroNotaFiltro.AutoSize = True
        Me.lblNumeroNotaFiltro.Location = New System.Drawing.Point(504, 17)
        Me.lblNumeroNotaFiltro.Name = "lblNumeroNotaFiltro"
        Me.lblNumeroNotaFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNumeroNotaFiltro.TabIndex = 7
        Me.lblNumeroNotaFiltro.Text = "Nota Fiscal:"
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(342, 34)
        Me.txtProdutoFiltro.MaxLength = 20
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(159, 20)
        Me.txtProdutoFiltro.TabIndex = 6
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(339, 17)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 5
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'txtNumeroProtocoloFiltro
        '
        Me.txtNumeroProtocoloFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroProtocoloFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroProtocoloFiltro.MaxLength = 20
        Me.txtNumeroProtocoloFiltro.Name = "txtNumeroProtocoloFiltro"
        Me.txtNumeroProtocoloFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroProtocoloFiltro.TabIndex = 1
        '
        'lblNumeroProtocoloFiltro
        '
        Me.lblNumeroProtocoloFiltro.AutoSize = True
        Me.lblNumeroProtocoloFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroProtocoloFiltro.Name = "lblNumeroProtocoloFiltro"
        Me.lblNumeroProtocoloFiltro.Size = New System.Drawing.Size(70, 14)
        Me.lblNumeroProtocoloFiltro.TabIndex = 0
        Me.lblNumeroProtocoloFiltro.Text = "Nº Protocolo:"
        '
        'dtpDataOcorrenciaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataOcorrenciaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOcorrenciaInicioFiltro.Location = New System.Drawing.Point(115, 34)
        Me.dtpDataOcorrenciaInicioFiltro.Name = "dtpDataOcorrenciaInicioFiltro"
        Me.dtpDataOcorrenciaInicioFiltro.ShowCheckBox = True
        Me.dtpDataOcorrenciaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataOcorrenciaInicioFiltro.TabIndex = 3
        '
        'dtpDataOcorrenciaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataOcorrenciaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOcorrenciaTerminoFiltro.Location = New System.Drawing.Point(228, 34)
        Me.dtpDataOcorrenciaTerminoFiltro.Name = "dtpDataOcorrenciaTerminoFiltro"
        Me.dtpDataOcorrenciaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataOcorrenciaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataOcorrenciaTerminoFiltro.TabIndex = 4
        '
        'lblDataOcorrenciaFiltro
        '
        Me.lblDataOcorrenciaFiltro.AutoSize = True
        Me.lblDataOcorrenciaFiltro.Location = New System.Drawing.Point(112, 17)
        Me.lblDataOcorrenciaFiltro.Name = "lblDataOcorrenciaFiltro"
        Me.lblDataOcorrenciaFiltro.Size = New System.Drawing.Size(89, 14)
        Me.lblDataOcorrenciaFiltro.TabIndex = 2
        Me.lblDataOcorrenciaFiltro.Text = "Data Ocorrência:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(7, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 0
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(102, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 1
        Me.cboCongelarColuna.TabStop = False
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
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(785, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 9
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrOcr000000001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrOcr000000001"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.tabRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRelatorios.ResumeLayout(False)
        Me.pagRelatorioTempo.ResumeLayout(False)
        CType(Me.grdAnalitico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage1.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.grdStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage3.ResumeLayout(False)
        CType(Me.grdTempo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedidoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtLoteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLoteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSemanaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSemanaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtRevendedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroNotaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroNotaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroProtocoloFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroProtocoloFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataOcorrenciaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataOcorrenciaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataOcorrenciaFiltro As System.Windows.Forms.Label
    Friend WithEvents tabRelatorios As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagRelatorioTempo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdAnalitico As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdStatus As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdTempo As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton

End Class
