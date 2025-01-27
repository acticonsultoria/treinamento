<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstPicking
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
        Dim cboGrupoItemFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstPicking))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim grdPicking_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPicking_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdPedido_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaFaturado = New System.Windows.Forms.Label()
        Me.picLegendaFaturado = New System.Windows.Forms.PictureBox()
        Me.picLegendaPicking = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPickingCancelado = New System.Windows.Forms.Label()
        Me.picLegendaPickingCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPicking = New System.Windows.Forms.Label()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblStatusPicking = New System.Windows.Forms.Label()
        Me.cboStatusPicking = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarClienteFiltro = New System.Windows.Forms.Button()
        Me.txtReferenciaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblReferenciaFiltro = New System.Windows.Forms.Label()
        Me.dtpDataPickingInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPickingTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPickingFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroPickingFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPickingFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarProdutoFiltro = New System.Windows.Forms.Button()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroPedidoClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoClienteFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroPedidoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoFiltro = New System.Windows.Forms.Label()
        Me.txtClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridPedido = New System.Windows.Forms.Button()
        Me.btnAgruparGridPedido = New System.Windows.Forms.Button()
        Me.grpPicking = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.txtQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.cboLote = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnExcluirPicking = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirPicking = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGridPedido = New System.Windows.Forms.Button()
        Me.grpPedido = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDataPicking = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataPicking = New System.Windows.Forms.Label()
        Me.txtNumeroPicking = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroPedidoCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoCliente = New System.Windows.Forms.Label()
        Me.txtDataPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoVenda = New System.Windows.Forms.Label()
        Me.cboNumeroPedidoVenda = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblDataPedido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.grdPicking = New Janus.Windows.GridEX.GridEX()
        Me.grdPedido = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaFaturado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaPicking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaPickingCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpPicking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPicking.SuspendLayout()
        CType(Me.grpPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPedido.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdPicking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.UiGroupBox2)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Picking"
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
        Me.btnExcelGrid.TabIndex = 14
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
        Me.btnAgruparGrid.TabIndex = 8
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaFaturado)
        Me.grpLegenda.Controls.Add(Me.picLegendaFaturado)
        Me.grpLegenda.Controls.Add(Me.picLegendaPicking)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPickingCancelado)
        Me.grpLegenda.Controls.Add(Me.picLegendaPickingCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPicking)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(267, 51)
        Me.grpLegenda.TabIndex = 3
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaFaturado
        '
        Me.lblLegendaFaturado.AutoSize = True
        Me.lblLegendaFaturado.Location = New System.Drawing.Point(212, 23)
        Me.lblLegendaFaturado.Name = "lblLegendaFaturado"
        Me.lblLegendaFaturado.Size = New System.Drawing.Size(50, 14)
        Me.lblLegendaFaturado.TabIndex = 13
        Me.lblLegendaFaturado.Text = "Faturado"
        '
        'picLegendaFaturado
        '
        Me.picLegendaFaturado.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaFaturado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaFaturado.Location = New System.Drawing.Point(193, 23)
        Me.picLegendaFaturado.Name = "picLegendaFaturado"
        Me.picLegendaFaturado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaFaturado.TabIndex = 14
        Me.picLegendaFaturado.TabStop = False
        '
        'picLegendaPicking
        '
        Me.picLegendaPicking.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaPicking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaPicking.Location = New System.Drawing.Point(9, 23)
        Me.picLegendaPicking.Name = "picLegendaPicking"
        Me.picLegendaPicking.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaPicking.TabIndex = 12
        Me.picLegendaPicking.TabStop = False
        '
        'lblLegendaPickingCancelado
        '
        Me.lblLegendaPickingCancelado.AutoSize = True
        Me.lblLegendaPickingCancelado.Location = New System.Drawing.Point(93, 23)
        Me.lblLegendaPickingCancelado.Name = "lblLegendaPickingCancelado"
        Me.lblLegendaPickingCancelado.Size = New System.Drawing.Size(94, 14)
        Me.lblLegendaPickingCancelado.TabIndex = 1
        Me.lblLegendaPickingCancelado.Text = "Picking Cancelado"
        '
        'picLegendaPickingCancelado
        '
        Me.picLegendaPickingCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaPickingCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaPickingCancelado.Location = New System.Drawing.Point(74, 23)
        Me.picLegendaPickingCancelado.Name = "picLegendaPickingCancelado"
        Me.picLegendaPickingCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaPickingCancelado.TabIndex = 8
        Me.picLegendaPickingCancelado.TabStop = False
        '
        'lblLegendaPicking
        '
        Me.lblLegendaPicking.AutoSize = True
        Me.lblLegendaPicking.Location = New System.Drawing.Point(28, 23)
        Me.lblLegendaPicking.Name = "lblLegendaPicking"
        Me.lblLegendaPicking.Size = New System.Drawing.Size(40, 14)
        Me.lblLegendaPicking.TabIndex = 0
        Me.lblLegendaPicking.Text = "Picking"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblStatusPicking)
        Me.grpFiltro.Controls.Add(Me.cboStatusPicking)
        Me.grpFiltro.Controls.Add(Me.btnProcurarClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtReferenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblReferenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPickingInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPickingTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPickingFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPickingFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPickingFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblStatusPicking
        '
        Me.lblStatusPicking.AutoSize = True
        Me.lblStatusPicking.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatusPicking.Location = New System.Drawing.Point(486, 97)
        Me.lblStatusPicking.Name = "lblStatusPicking"
        Me.lblStatusPicking.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusPicking.TabIndex = 20
        Me.lblStatusPicking.Text = "Status:"
        '
        'cboStatusPicking
        '
        Me.cboStatusPicking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusPicking.AutoSize = False
        Me.cboStatusPicking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusPicking.Location = New System.Drawing.Point(489, 114)
        Me.cboStatusPicking.Name = "cboStatusPicking"
        Me.cboStatusPicking.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusPicking.Size = New System.Drawing.Size(283, 20)
        Me.cboStatusPicking.TabIndex = 21
        '
        'btnProcurarClienteFiltro
        '
        Me.btnProcurarClienteFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarClienteFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarClienteFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarClienteFiltro.Location = New System.Drawing.Point(466, 56)
        Me.btnProcurarClienteFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarClienteFiltro.Name = "btnProcurarClienteFiltro"
        Me.btnProcurarClienteFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarClienteFiltro.TabIndex = 12
        Me.btnProcurarClienteFiltro.TabStop = False
        Me.btnProcurarClienteFiltro.UseVisualStyleBackColor = True
        '
        'txtReferenciaFiltro
        '
        Me.txtReferenciaFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReferenciaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenciaFiltro.Location = New System.Drawing.Point(615, 34)
        Me.txtReferenciaFiltro.MaxLength = 20
        Me.txtReferenciaFiltro.Name = "txtReferenciaFiltro"
        Me.txtReferenciaFiltro.Size = New System.Drawing.Size(157, 20)
        Me.txtReferenciaFiltro.TabIndex = 10
        '
        'lblReferenciaFiltro
        '
        Me.lblReferenciaFiltro.AutoSize = True
        Me.lblReferenciaFiltro.Location = New System.Drawing.Point(612, 17)
        Me.lblReferenciaFiltro.Name = "lblReferenciaFiltro"
        Me.lblReferenciaFiltro.Size = New System.Drawing.Size(60, 14)
        Me.lblReferenciaFiltro.TabIndex = 9
        Me.lblReferenciaFiltro.Text = "Referência"
        '
        'dtpDataPickingInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPickingInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPickingInicioFiltro.Location = New System.Drawing.Point(135, 34)
        Me.dtpDataPickingInicioFiltro.Name = "dtpDataPickingInicioFiltro"
        Me.dtpDataPickingInicioFiltro.ShowCheckBox = True
        Me.dtpDataPickingInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPickingInicioFiltro.TabIndex = 3
        Me.dtpDataPickingInicioFiltro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'dtpDataPickingTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPickingTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPickingTerminoFiltro.Location = New System.Drawing.Point(249, 34)
        Me.dtpDataPickingTerminoFiltro.Name = "dtpDataPickingTerminoFiltro"
        Me.dtpDataPickingTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPickingTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPickingTerminoFiltro.TabIndex = 4
        Me.dtpDataPickingTerminoFiltro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataPickingFiltro
        '
        Me.lblDataPickingFiltro.AutoSize = True
        Me.lblDataPickingFiltro.Location = New System.Drawing.Point(132, 17)
        Me.lblDataPickingFiltro.Name = "lblDataPickingFiltro"
        Me.lblDataPickingFiltro.Size = New System.Drawing.Size(68, 14)
        Me.lblDataPickingFiltro.TabIndex = 2
        Me.lblDataPickingFiltro.Text = "Data Picking:"
        '
        'txtNumeroPickingFiltro
        '
        Me.txtNumeroPickingFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPickingFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroPickingFiltro.MaxLength = 20
        Me.txtNumeroPickingFiltro.Name = "txtNumeroPickingFiltro"
        Me.txtNumeroPickingFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroPickingFiltro.TabIndex = 1
        '
        'lblNumeroPickingFiltro
        '
        Me.lblNumeroPickingFiltro.AutoSize = True
        Me.lblNumeroPickingFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroPickingFiltro.Name = "lblNumeroPickingFiltro"
        Me.lblNumeroPickingFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblNumeroPickingFiltro.TabIndex = 0
        Me.lblNumeroPickingFiltro.Text = "Nº Picking:"
        '
        'btnProcurarProdutoFiltro
        '
        Me.btnProcurarProdutoFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarProdutoFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProdutoFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProdutoFiltro.Location = New System.Drawing.Point(466, 96)
        Me.btnProcurarProdutoFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProdutoFiltro.Name = "btnProcurarProdutoFiltro"
        Me.btnProcurarProdutoFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProdutoFiltro.TabIndex = 17
        Me.btnProcurarProdutoFiltro.TabStop = False
        Me.btnProcurarProdutoFiltro.UseVisualStyleBackColor = True
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 114)
        Me.txtProdutoFiltro.MaxLength = 60
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(474, 20)
        Me.txtProdutoFiltro.TabIndex = 18
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 16
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.AllowDrop = True
        Me.cboGrupoItemFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoItemFiltro.ButtonCancelText = "Cancelar"
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboGrupoItemFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboGrupoItemFiltro_DesignTimeLayout.LayoutString")
        Me.cboGrupoItemFiltro.DesignTimeLayout = cboGrupoItemFiltro_DesignTimeLayout
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(489, 74)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.SaveSettings = False
        Me.cboGrupoItemFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(283, 20)
        Me.cboGrupoItemFiltro.TabIndex = 15
        Me.cboGrupoItemFiltro.ValuesDataMember = Nothing
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(486, 57)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblGrupoItemFiltro.TabIndex = 14
        Me.lblGrupoItemFiltro.Text = "Grupo de Item:"
        '
        'txtNumeroPedidoClienteFiltro
        '
        Me.txtNumeroPedidoClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoClienteFiltro.Location = New System.Drawing.Point(489, 34)
        Me.txtNumeroPedidoClienteFiltro.MaxLength = 20
        Me.txtNumeroPedidoClienteFiltro.Name = "txtNumeroPedidoClienteFiltro"
        Me.txtNumeroPedidoClienteFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroPedidoClienteFiltro.TabIndex = 8
        '
        'lblNumeroPedidoClienteFiltro
        '
        Me.lblNumeroPedidoClienteFiltro.AutoSize = True
        Me.lblNumeroPedidoClienteFiltro.Location = New System.Drawing.Point(486, 17)
        Me.lblNumeroPedidoClienteFiltro.Name = "lblNumeroPedidoClienteFiltro"
        Me.lblNumeroPedidoClienteFiltro.Size = New System.Drawing.Size(92, 14)
        Me.lblNumeroPedidoClienteFiltro.TabIndex = 7
        Me.lblNumeroPedidoClienteFiltro.Text = "Nº Pedido Cliente:"
        '
        'txtNumeroPedidoFiltro
        '
        Me.txtNumeroPedidoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoFiltro.Location = New System.Drawing.Point(363, 34)
        Me.txtNumeroPedidoFiltro.MaxLength = 20
        Me.txtNumeroPedidoFiltro.Name = "txtNumeroPedidoFiltro"
        Me.txtNumeroPedidoFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroPedidoFiltro.TabIndex = 6
        '
        'lblNumeroPedidoFiltro
        '
        Me.lblNumeroPedidoFiltro.AutoSize = True
        Me.lblNumeroPedidoFiltro.Location = New System.Drawing.Point(360, 17)
        Me.lblNumeroPedidoFiltro.Name = "lblNumeroPedidoFiltro"
        Me.lblNumeroPedidoFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedidoFiltro.TabIndex = 5
        Me.lblNumeroPedidoFiltro.Text = "Nº Pedido:"
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtClienteFiltro.MaxLength = 60
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.Size = New System.Drawing.Size(474, 20)
        Me.txtClienteFiltro.TabIndex = 13
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 11
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 19
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 3
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 156)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 324)
        Me.grdListagem.TabIndex = 1
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
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnCancelar)
        Me.UiGroupBox2.Controls.Add(Me.btnNovo)
        Me.UiGroupBox2.Controls.Add(Me.btnSair)
        Me.UiGroupBox2.Location = New System.Drawing.Point(284, 483)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(621, 51)
        Me.UiGroupBox2.TabIndex = 4
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(327, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(424, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 2
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(521, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridPedido)
        Me.pagDados.Controls.Add(Me.btnAgruparGridPedido)
        Me.pagDados.Controls.Add(Me.grpPicking)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridPedido)
        Me.pagDados.Controls.Add(Me.grpPedido)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Controls.Add(Me.grdPicking)
        Me.pagDados.Controls.Add(Me.grdPedido)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Picking"
        '
        'btnExcelGridPedido
        '
        Me.btnExcelGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPedido.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPedido.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPedido.Location = New System.Drawing.Point(57, 249)
        Me.btnExcelGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPedido.Name = "btnExcelGridPedido"
        Me.btnExcelGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPedido.TabIndex = 4
        Me.btnExcelGridPedido.TabStop = False
        Me.btnExcelGridPedido.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPedido
        '
        Me.btnAgruparGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPedido.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPedido.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPedido.Location = New System.Drawing.Point(33, 249)
        Me.btnAgruparGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPedido.Name = "btnAgruparGridPedido"
        Me.btnAgruparGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPedido.TabIndex = 3
        Me.btnAgruparGridPedido.TabStop = False
        Me.btnAgruparGridPedido.UseVisualStyleBackColor = False
        '
        'grpPicking
        '
        Me.grpPicking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPicking.BackColor = System.Drawing.Color.Transparent
        Me.grpPicking.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpPicking.Controls.Add(Me.txtQuantidadeEstoque)
        Me.grpPicking.Controls.Add(Me.lblLote)
        Me.grpPicking.Controls.Add(Me.lblDeposito)
        Me.grpPicking.Controls.Add(Me.cboDeposito)
        Me.grpPicking.Controls.Add(Me.lblQuantidade)
        Me.grpPicking.Controls.Add(Me.txtQuantidade)
        Me.grpPicking.Controls.Add(Me.btnExcluirPicking)
        Me.grpPicking.Controls.Add(Me.btnInserirPicking)
        Me.grpPicking.Controls.Add(Me.txtLote)
        Me.grpPicking.Controls.Add(Me.cboLote)
        Me.grpPicking.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPicking.Location = New System.Drawing.Point(8, 269)
        Me.grpPicking.Name = "grpPicking"
        Me.grpPicking.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPicking.Size = New System.Drawing.Size(897, 64)
        Me.grpPicking.TabIndex = 5
        Me.grpPicking.VisualStyleManager = Me.vsmMain
        '
        'txtLote
        '
        Me.txtLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(291, 35)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(165, 20)
        Me.txtLote.TabIndex = 4
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(459, 18)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeEstoque.TabIndex = 5
        Me.lblQuantidadeEstoque.Text = "Qtde. Estoque:"
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeEstoque.DecimalDigits = 4
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(462, 35)
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.ReadOnly = True
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeEstoque.TabIndex = 6
        Me.txtQuantidadeEstoque.TabStop = False
        Me.txtQuantidadeEstoque.Text = "0,0000"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblLote
        '
        Me.lblLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(288, 18)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 2
        Me.lblLote.Text = "Lote:"
        '
        'cboLote
        '
        Me.cboLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLote.AutoSize = False
        Me.cboLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLote.Location = New System.Drawing.Point(291, 35)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLote.Size = New System.Drawing.Size(165, 20)
        Me.cboLote.TabIndex = 3
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(6, 18)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 0
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(9, 35)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(276, 20)
        Me.cboDeposito.TabIndex = 1
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(565, 18)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(72, 14)
        Me.lblQuantidade.TabIndex = 7
        Me.lblQuantidade.Text = "Qtde. Picking:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(568, 35)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 8
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnExcluirPicking
        '
        Me.btnExcluirPicking.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirPicking.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirPicking.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirPicking.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirPicking.Location = New System.Drawing.Point(797, 32)
        Me.btnExcluirPicking.Name = "btnExcluirPicking"
        Me.btnExcluirPicking.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirPicking.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirPicking.TabIndex = 10
        Me.btnExcluirPicking.Text = "Excluir"
        Me.btnExcluirPicking.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirPicking
        '
        Me.btnInserirPicking.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirPicking.Image = CType(resources.GetObject("btnInserirPicking.Image"), System.Drawing.Image)
        Me.btnInserirPicking.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirPicking.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirPicking.Location = New System.Drawing.Point(700, 32)
        Me.btnInserirPicking.Name = "btnInserirPicking"
        Me.btnInserirPicking.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirPicking.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirPicking.TabIndex = 9
        Me.btnInserirPicking.Text = "Inserir"
        Me.btnInserirPicking.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfigurarGridPedido
        '
        Me.btnConfigurarGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPedido.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPedido.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPedido.Location = New System.Drawing.Point(9, 249)
        Me.btnConfigurarGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPedido.Name = "btnConfigurarGridPedido"
        Me.btnConfigurarGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPedido.TabIndex = 2
        Me.btnConfigurarGridPedido.TabStop = False
        Me.btnConfigurarGridPedido.UseVisualStyleBackColor = False
        '
        'grpPedido
        '
        Me.grpPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPedido.BackColor = System.Drawing.Color.Transparent
        Me.grpPedido.Controls.Add(Me.txtDataPicking)
        Me.grpPedido.Controls.Add(Me.lblDataPicking)
        Me.grpPedido.Controls.Add(Me.txtNumeroPicking)
        Me.grpPedido.Controls.Add(Me.txtNumeroPedidoCliente)
        Me.grpPedido.Controls.Add(Me.lblNumeroPedidoCliente)
        Me.grpPedido.Controls.Add(Me.txtDataPedido)
        Me.grpPedido.Controls.Add(Me.lblNumeroPedidoVenda)
        Me.grpPedido.Controls.Add(Me.cboNumeroPedidoVenda)
        Me.grpPedido.Controls.Add(Me.txtCliente)
        Me.grpPedido.Controls.Add(Me.lblCliente)
        Me.grpPedido.Controls.Add(Me.lblDataPedido)
        Me.grpPedido.Controls.Add(Me.Label1)
        Me.grpPedido.Location = New System.Drawing.Point(8, 3)
        Me.grpPedido.Name = "grpPedido"
        Me.grpPedido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPedido.Size = New System.Drawing.Size(897, 64)
        Me.grpPedido.TabIndex = 0
        Me.grpPedido.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpPedido.VisualStyleManager = Me.vsmMain
        '
        'txtDataPicking
        '
        Me.txtDataPicking.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataPicking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataPicking.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDataPicking.Location = New System.Drawing.Point(135, 34)
        Me.txtDataPicking.MaxLength = 20
        Me.txtDataPicking.Name = "txtDataPicking"
        Me.txtDataPicking.ReadOnly = True
        Me.txtDataPicking.Size = New System.Drawing.Size(99, 20)
        Me.txtDataPicking.TabIndex = 3
        Me.txtDataPicking.TabStop = False
        Me.txtDataPicking.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblDataPicking
        '
        Me.lblDataPicking.AutoSize = True
        Me.lblDataPicking.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataPicking.Location = New System.Drawing.Point(132, 17)
        Me.lblDataPicking.Name = "lblDataPicking"
        Me.lblDataPicking.Size = New System.Drawing.Size(68, 14)
        Me.lblDataPicking.TabIndex = 2
        Me.lblDataPicking.Text = "Data Picking:"
        '
        'txtNumeroPicking
        '
        Me.txtNumeroPicking.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroPicking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPicking.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroPicking.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroPicking.MaxLength = 20
        Me.txtNumeroPicking.Name = "txtNumeroPicking"
        Me.txtNumeroPicking.ReadOnly = True
        Me.txtNumeroPicking.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroPicking.TabIndex = 1
        Me.txtNumeroPicking.TabStop = False
        Me.txtNumeroPicking.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtNumeroPedidoCliente
        '
        Me.txtNumeroPedidoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroPedidoCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroPedidoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoCliente.Location = New System.Drawing.Point(789, 34)
        Me.txtNumeroPedidoCliente.MaxLength = 20
        Me.txtNumeroPedidoCliente.Name = "txtNumeroPedidoCliente"
        Me.txtNumeroPedidoCliente.ReadOnly = True
        Me.txtNumeroPedidoCliente.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroPedidoCliente.TabIndex = 11
        Me.txtNumeroPedidoCliente.TabStop = False
        '
        'lblNumeroPedidoCliente
        '
        Me.lblNumeroPedidoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroPedidoCliente.AutoSize = True
        Me.lblNumeroPedidoCliente.Location = New System.Drawing.Point(786, 17)
        Me.lblNumeroPedidoCliente.Name = "lblNumeroPedidoCliente"
        Me.lblNumeroPedidoCliente.Size = New System.Drawing.Size(75, 14)
        Me.lblNumeroPedidoCliente.TabIndex = 10
        Me.lblNumeroPedidoCliente.Text = "Nº OC Cliente:"
        '
        'txtDataPedido
        '
        Me.txtDataPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataPedido.Location = New System.Drawing.Point(366, 34)
        Me.txtDataPedido.MaxLength = 20
        Me.txtDataPedido.Name = "txtDataPedido"
        Me.txtDataPedido.ReadOnly = True
        Me.txtDataPedido.Size = New System.Drawing.Size(99, 20)
        Me.txtDataPedido.TabIndex = 7
        Me.txtDataPedido.TabStop = False
        '
        'lblNumeroPedidoVenda
        '
        Me.lblNumeroPedidoVenda.AutoSize = True
        Me.lblNumeroPedidoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroPedidoVenda.Location = New System.Drawing.Point(237, 17)
        Me.lblNumeroPedidoVenda.Name = "lblNumeroPedidoVenda"
        Me.lblNumeroPedidoVenda.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedidoVenda.TabIndex = 4
        Me.lblNumeroPedidoVenda.Text = "Nº Pedido:"
        '
        'cboNumeroPedidoVenda
        '
        Me.cboNumeroPedidoVenda.AutoSize = False
        Me.cboNumeroPedidoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroPedidoVenda.Location = New System.Drawing.Point(240, 34)
        Me.cboNumeroPedidoVenda.Name = "cboNumeroPedidoVenda"
        Me.cboNumeroPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroPedidoVenda.Size = New System.Drawing.Size(120, 20)
        Me.cboNumeroPedidoVenda.TabIndex = 5
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(471, 34)
        Me.txtCliente.MaxLength = 60
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(312, 20)
        Me.txtCliente.TabIndex = 9
        Me.txtCliente.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCliente.Location = New System.Drawing.Point(468, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 8
        Me.lblCliente.Text = "Cliente:"
        '
        'lblDataPedido
        '
        Me.lblDataPedido.AutoSize = True
        Me.lblDataPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataPedido.Location = New System.Drawing.Point(363, 17)
        Me.lblDataPedido.Name = "lblDataPedido"
        Me.lblDataPedido.Size = New System.Drawing.Size(67, 14)
        Me.lblDataPedido.TabIndex = 6
        Me.lblDataPedido.Text = "Data Pedido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Picking:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnVoltar)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 7
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 0
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'grdPicking
        '
        Me.grdPicking.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPicking.AlternatingColors = True
        Me.grdPicking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPicking.AutoEdit = True
        Me.grdPicking.ColumnAutoResize = True
        grdPicking_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdPicking_DesignTimeLayout_Reference_0.Instance"), Object)
        grdPicking_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdPicking_DesignTimeLayout_Reference_0})
        grdPicking_DesignTimeLayout.LayoutString = resources.GetString("grdPicking_DesignTimeLayout.LayoutString")
        Me.grdPicking.DesignTimeLayout = grdPicking_DesignTimeLayout
        Me.grdPicking.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPicking.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPicking.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPicking.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdPicking.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPicking.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPicking.FrozenColumns = 2
        Me.grdPicking.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPicking.GroupByBoxVisible = False
        Me.grdPicking.Location = New System.Drawing.Point(8, 342)
        Me.grdPicking.Name = "grdPicking"
        Me.grdPicking.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPicking.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdPicking.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdPicking.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPicking.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPicking.Size = New System.Drawing.Size(897, 138)
        Me.grdPicking.TabIndex = 6
        Me.grdPicking.TabStop = False
        Me.grdPicking.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPicking.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdPicking.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdPicking.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPicking.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPicking.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPicking.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPicking.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPicking.VisualStyleManager = Me.vsmMain
        '
        'grdPedido
        '
        Me.grdPedido.AllowChildTableGroups = True
        Me.grdPedido.AlternatingColors = True
        Me.grdPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPedido.AutoEdit = True
        grdPedido_DesignTimeLayout.LayoutString = resources.GetString("grdPedido_DesignTimeLayout.LayoutString")
        Me.grdPedido.DesignTimeLayout = grdPedido_DesignTimeLayout
        Me.grdPedido.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPedido.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedido.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedido.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedido.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdPedido.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedido.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPedido.FrozenColumns = 1
        Me.grdPedido.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedido.GroupByBoxVisible = False
        Me.grdPedido.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPedido.Hierarchical = True
        Me.grdPedido.Location = New System.Drawing.Point(8, 77)
        Me.grdPedido.Name = "grdPedido"
        Me.grdPedido.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedido.RecordNavigator = True
        Me.grdPedido.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdPedido.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPedido.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPedido.Size = New System.Drawing.Size(897, 189)
        Me.grdPedido.TabIndex = 1
        Me.grdPedido.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedido.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdPedido.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdPedido.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPedido.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPedido.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedido.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPedido.UpdateOnLeave = False
        Me.grdPedido.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedido.VisualStyleManager = Me.vsmMain
        '
        'usrEstPicking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstPicking"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaFaturado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaPicking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaPickingCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpPicking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPicking.ResumeLayout(False)
        Me.grpPicking.PerformLayout()
        CType(Me.grpPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPedido.ResumeLayout(False)
        Me.grpPedido.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grdPicking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpPedido As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents cboNumeroPedidoVenda As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtDataPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataPedido As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedidoCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoCliente As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGridPedido As System.Windows.Forms.Button
    Friend WithEvents grpPicking As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents cboLote As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluirPicking As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirPicking As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grdPicking As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarProdutoFiltro As System.Windows.Forms.Button
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedidoClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedidoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroPickingFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPickingFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroPicking As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcurarClienteFiltro As System.Windows.Forms.Button
    Friend WithEvents txtReferenciaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblReferenciaFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataPickingInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPickingTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPickingFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDataPicking As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataPicking As System.Windows.Forms.Label
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaPicking As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPickingCancelado As System.Windows.Forms.Label
    Friend WithEvents picLegendaPickingCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPicking As System.Windows.Forms.Label
    Friend WithEvents lblLegendaFaturado As System.Windows.Forms.Label
    Friend WithEvents picLegendaFaturado As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatusPicking As System.Windows.Forms.Label
    Friend WithEvents cboStatusPicking As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGridPedido As System.Windows.Forms.Button
    Friend WithEvents grdPedido As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridPedido As System.Windows.Forms.Button
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox

End Class
