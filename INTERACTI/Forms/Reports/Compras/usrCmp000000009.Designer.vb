<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmp000000009
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmp000000009))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaEntreguePrazo = New System.Windows.Forms.PictureBox()
        Me.picLegendaNaoEntregue = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEntreguePrazo = New System.Windows.Forms.Label()
        Me.lblLegendaNaoEntregue = New System.Windows.Forms.Label()
        Me.picLegendaEntregueAtrasado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEntregueAtrasado = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAvaliarPor = New System.Windows.Forms.Label()
        Me.cboAvaliarPor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAgrupadoPorFiltro = New System.Windows.Forms.Label()
        Me.cboAgrupadoPorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataEntradaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEntradaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntradaFiltro = New System.Windows.Forms.Label()
        Me.dtpDataPrevisaoEntregaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPrevisaoEntregaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPrevisaoEntregaFiltro = New System.Windows.Forms.Label()
        Me.dtpDataPedidoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPedidoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPedidoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.cboFornecedorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.trvMain = New System.Windows.Forms.TreeView()
        Me.lblInformacao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaEntreguePrazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaNaoEntregue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaEntregueAtrasado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.lblInformacao)
        Me.pagLista.Controls.Add(Me.trvMain)
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Compras - CMP000000009"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaEntreguePrazo)
        Me.grpLegenda.Controls.Add(Me.picLegendaNaoEntregue)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEntreguePrazo)
        Me.grpLegenda.Controls.Add(Me.lblLegendaNaoEntregue)
        Me.grpLegenda.Controls.Add(Me.picLegendaEntregueAtrasado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEntregueAtrasado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(348, 51)
        Me.grpLegenda.TabIndex = 26
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaEntreguePrazo
        '
        Me.picLegendaEntreguePrazo.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaEntreguePrazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEntreguePrazo.Location = New System.Drawing.Point(10, 21)
        Me.picLegendaEntreguePrazo.Name = "picLegendaEntreguePrazo"
        Me.picLegendaEntreguePrazo.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEntreguePrazo.TabIndex = 22
        Me.picLegendaEntreguePrazo.TabStop = False
        '
        'picLegendaNaoEntregue
        '
        Me.picLegendaNaoEntregue.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaNaoEntregue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaNaoEntregue.Location = New System.Drawing.Point(131, 21)
        Me.picLegendaNaoEntregue.Name = "picLegendaNaoEntregue"
        Me.picLegendaNaoEntregue.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaNaoEntregue.TabIndex = 20
        Me.picLegendaNaoEntregue.TabStop = False
        '
        'lblLegendaEntreguePrazo
        '
        Me.lblLegendaEntreguePrazo.AutoSize = True
        Me.lblLegendaEntreguePrazo.Location = New System.Drawing.Point(29, 21)
        Me.lblLegendaEntreguePrazo.Name = "lblLegendaEntreguePrazo"
        Me.lblLegendaEntreguePrazo.Size = New System.Drawing.Size(96, 14)
        Me.lblLegendaEntreguePrazo.TabIndex = 0
        Me.lblLegendaEntreguePrazo.Text = "Entregue no Prazo"
        '
        'lblLegendaNaoEntregue
        '
        Me.lblLegendaNaoEntregue.AutoSize = True
        Me.lblLegendaNaoEntregue.Location = New System.Drawing.Point(150, 21)
        Me.lblLegendaNaoEntregue.Name = "lblLegendaNaoEntregue"
        Me.lblLegendaNaoEntregue.Size = New System.Drawing.Size(72, 14)
        Me.lblLegendaNaoEntregue.TabIndex = 2
        Me.lblLegendaNaoEntregue.Text = "Não Entregue"
        '
        'picLegendaEntregueAtrasado
        '
        Me.picLegendaEntregueAtrasado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaEntregueAtrasado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEntregueAtrasado.Location = New System.Drawing.Point(228, 21)
        Me.picLegendaEntregueAtrasado.Name = "picLegendaEntregueAtrasado"
        Me.picLegendaEntregueAtrasado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEntregueAtrasado.TabIndex = 4
        Me.picLegendaEntregueAtrasado.TabStop = False
        '
        'lblLegendaEntregueAtrasado
        '
        Me.lblLegendaEntregueAtrasado.AutoSize = True
        Me.lblLegendaEntregueAtrasado.Location = New System.Drawing.Point(247, 21)
        Me.lblLegendaEntregueAtrasado.Name = "lblLegendaEntregueAtrasado"
        Me.lblLegendaEntregueAtrasado.Size = New System.Drawing.Size(97, 14)
        Me.lblLegendaEntregueAtrasado.TabIndex = 1
        Me.lblLegendaEntregueAtrasado.Text = "Entregue Atrasado"
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
        Me.grdListagem.Location = New System.Drawing.Point(319, 160)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(671, 320)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(365, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(625, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(5, 22)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 13
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(100, 19)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 14
        Me.cboCongelarColuna.TabStop = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(272, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 12
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(369, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(150, 23)
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
        Me.btnSair.Location = New System.Drawing.Point(525, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAvaliarPor)
        Me.grpFiltro.Controls.Add(Me.cboAvaliarPor)
        Me.grpFiltro.Controls.Add(Me.lblAgrupadoPorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAgrupadoPorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEntradaFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPrevisaoEntregaFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboFornecedorFiltro)
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
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(217, 100)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 22
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(220, 117)
        Me.txtDescricaoFiltro.MaxLength = 120
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(630, 20)
        Me.txtDescricaoFiltro.TabIndex = 23
        '
        'lblCodigoProdutoFiltro
        '
        Me.lblCodigoProdutoFiltro.AutoSize = True
        Me.lblCodigoProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoFiltro.Location = New System.Drawing.Point(5, 100)
        Me.lblCodigoProdutoFiltro.Name = "lblCodigoProdutoFiltro"
        Me.lblCodigoProdutoFiltro.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProdutoFiltro.TabIndex = 20
        Me.lblCodigoProdutoFiltro.Text = "Código Produto:"
        '
        'txtCodigoProdutoFiltro
        '
        Me.txtCodigoProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProdutoFiltro.Location = New System.Drawing.Point(8, 117)
        Me.txtCodigoProdutoFiltro.Name = "txtCodigoProdutoFiltro"
        Me.txtCodigoProdutoFiltro.Size = New System.Drawing.Size(206, 20)
        Me.txtCodigoProdutoFiltro.TabIndex = 21
        '
        'lblAvaliarPor
        '
        Me.lblAvaliarPor.AutoSize = True
        Me.lblAvaliarPor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAvaliarPor.Location = New System.Drawing.Point(747, 20)
        Me.lblAvaliarPor.Name = "lblAvaliarPor"
        Me.lblAvaliarPor.Size = New System.Drawing.Size(63, 14)
        Me.lblAvaliarPor.TabIndex = 19
        Me.lblAvaliarPor.Text = "Avaliar Por:"
        '
        'cboAvaliarPor
        '
        Me.cboAvaliarPor.Location = New System.Drawing.Point(750, 37)
        Me.cboAvaliarPor.Name = "cboAvaliarPor"
        Me.cboAvaliarPor.Size = New System.Drawing.Size(100, 20)
        Me.cboAvaliarPor.TabIndex = 20
        '
        'lblAgrupadoPorFiltro
        '
        Me.lblAgrupadoPorFiltro.AutoSize = True
        Me.lblAgrupadoPorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAgrupadoPorFiltro.Location = New System.Drawing.Point(535, 20)
        Me.lblAgrupadoPorFiltro.Name = "lblAgrupadoPorFiltro"
        Me.lblAgrupadoPorFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblAgrupadoPorFiltro.TabIndex = 4
        Me.lblAgrupadoPorFiltro.Text = "Agrupar Por:"
        '
        'cboAgrupadoPorFiltro
        '
        Me.cboAgrupadoPorFiltro.Location = New System.Drawing.Point(538, 37)
        Me.cboAgrupadoPorFiltro.Name = "cboAgrupadoPorFiltro"
        Me.cboAgrupadoPorFiltro.Size = New System.Drawing.Size(206, 20)
        Me.cboAgrupadoPorFiltro.TabIndex = 5
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatusFiltro.Location = New System.Drawing.Point(323, 20)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 2
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.Location = New System.Drawing.Point(326, 37)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(206, 20)
        Me.cboStatusFiltro.TabIndex = 3
        '
        'dtpDataEntradaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEntradaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntradaTerminoFiltro.Location = New System.Drawing.Point(750, 77)
        Me.dtpDataEntradaTerminoFiltro.Name = "dtpDataEntradaTerminoFiltro"
        Me.dtpDataEntradaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEntradaTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataEntradaTerminoFiltro.TabIndex = 17
        '
        'dtpDataEntradaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEntradaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntradaInicioFiltro.Location = New System.Drawing.Point(644, 77)
        Me.dtpDataEntradaInicioFiltro.Name = "dtpDataEntradaInicioFiltro"
        Me.dtpDataEntradaInicioFiltro.ShowCheckBox = True
        Me.dtpDataEntradaInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataEntradaInicioFiltro.TabIndex = 16
        '
        'lblDataEntradaFiltro
        '
        Me.lblDataEntradaFiltro.AutoSize = True
        Me.lblDataEntradaFiltro.Location = New System.Drawing.Point(641, 60)
        Me.lblDataEntradaFiltro.Name = "lblDataEntradaFiltro"
        Me.lblDataEntradaFiltro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaFiltro.TabIndex = 15
        Me.lblDataEntradaFiltro.Text = "Data Entrada:"
        '
        'dtpDataPrevisaoEntregaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoEntregaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Location = New System.Drawing.Point(326, 77)
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Name = "dtpDataPrevisaoEntregaTerminoFiltro"
        Me.dtpDataPrevisaoEntregaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataPrevisaoEntregaTerminoFiltro.TabIndex = 11
        '
        'dtpDataPrevisaoEntregaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoEntregaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoEntregaInicioFiltro.Location = New System.Drawing.Point(220, 77)
        Me.dtpDataPrevisaoEntregaInicioFiltro.Name = "dtpDataPrevisaoEntregaInicioFiltro"
        Me.dtpDataPrevisaoEntregaInicioFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoEntregaInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataPrevisaoEntregaInicioFiltro.TabIndex = 10
        '
        'lblDataPrevisaoEntregaFiltro
        '
        Me.lblDataPrevisaoEntregaFiltro.AutoSize = True
        Me.lblDataPrevisaoEntregaFiltro.Location = New System.Drawing.Point(217, 60)
        Me.lblDataPrevisaoEntregaFiltro.Name = "lblDataPrevisaoEntregaFiltro"
        Me.lblDataPrevisaoEntregaFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblDataPrevisaoEntregaFiltro.TabIndex = 9
        Me.lblDataPrevisaoEntregaFiltro.Text = "Previsão de Entrega:"
        '
        'dtpDataPedidoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPedidoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPedidoTerminoFiltro.Location = New System.Drawing.Point(114, 77)
        Me.dtpDataPedidoTerminoFiltro.Name = "dtpDataPedidoTerminoFiltro"
        Me.dtpDataPedidoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPedidoTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataPedidoTerminoFiltro.TabIndex = 8
        '
        'dtpDataPedidoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPedidoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPedidoInicioFiltro.Location = New System.Drawing.Point(8, 77)
        Me.dtpDataPedidoInicioFiltro.Name = "dtpDataPedidoInicioFiltro"
        Me.dtpDataPedidoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPedidoInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataPedidoInicioFiltro.TabIndex = 7
        '
        'lblDataPedidoFiltro
        '
        Me.lblDataPedidoFiltro.AutoSize = True
        Me.lblDataPedidoFiltro.Location = New System.Drawing.Point(5, 60)
        Me.lblDataPedidoFiltro.Name = "lblDataPedidoFiltro"
        Me.lblDataPedidoFiltro.Size = New System.Drawing.Size(67, 14)
        Me.lblDataPedidoFiltro.TabIndex = 6
        Me.lblDataPedidoFiltro.Text = "Data Pedido:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 114)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 24
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(5, 20)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 0
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(538, 77)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 14
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(432, 77)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 13
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(429, 60)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 12
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'cboFornecedorFiltro
        '
        Me.cboFornecedorFiltro.Location = New System.Drawing.Point(8, 37)
        Me.cboFornecedorFiltro.Name = "cboFornecedorFiltro"
        Me.cboFornecedorFiltro.Size = New System.Drawing.Size(312, 20)
        Me.cboFornecedorFiltro.TabIndex = 1
        '
        'trvMain
        '
        Me.trvMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvMain.CheckBoxes = True
        Me.trvMain.FullRowSelect = True
        Me.trvMain.ItemHeight = 20
        Me.trvMain.Location = New System.Drawing.Point(8, 160)
        Me.trvMain.Name = "trvMain"
        Me.trvMain.ShowLines = False
        Me.trvMain.ShowNodeToolTips = True
        Me.trvMain.Size = New System.Drawing.Size(302, 289)
        Me.trvMain.TabIndex = 28
        '
        'lblInformacao
        '
        Me.lblInformacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInformacao.BackColor = System.Drawing.Color.Transparent
        Me.lblInformacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblInformacao.ForeColor = System.Drawing.Color.Firebrick
        Me.lblInformacao.Location = New System.Drawing.Point(10, 452)
        Me.lblInformacao.Name = "lblInformacao"
        Me.lblInformacao.Size = New System.Drawing.Size(300, 28)
        Me.lblInformacao.TabIndex = 29
        Me.lblInformacao.Text = "Marque os Grupos de Item que deseja Eliminar do Relatório"
        Me.lblInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usrCmp000000009
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmp000000009"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaEntreguePrazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaNaoEntregue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaEntregueAtrasado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboFornecedorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataPedidoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPedidoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataPrevisaoEntregaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPrevisaoEntregaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPrevisaoEntregaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataEntradaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntradaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntradaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblAgrupadoPorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAgrupadoPorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaEntreguePrazo As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEntregueAtrasado As System.Windows.Forms.Label
    Friend WithEvents picLegendaNaoEntregue As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEntreguePrazo As System.Windows.Forms.Label
    Friend WithEvents lblLegendaNaoEntregue As System.Windows.Forms.Label
    Friend WithEvents picLegendaEntregueAtrasado As System.Windows.Forms.PictureBox
    Friend WithEvents lblAvaliarPor As System.Windows.Forms.Label
    Friend WithEvents cboAvaliarPor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents trvMain As System.Windows.Forms.TreeView
    Friend WithEvents lblInformacao As System.Windows.Forms.Label

End Class
