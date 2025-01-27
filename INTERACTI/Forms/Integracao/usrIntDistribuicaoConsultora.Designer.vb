<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIntDistibuicaoConsultora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIntDistibuicaoConsultora))
        Dim grdImportacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDespesa = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPedidoVenda = New System.Windows.Forms.Label()
        Me.picLegendaTipoOrcamento = New System.Windows.Forms.PictureBox()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grdImportacao = New Janus.Windows.GridEX.GridEX()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCNAB = New System.Windows.Forms.Label()
        Me.cboNFEntrada = New Janus.Windows.EditControls.UIComboBox()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo2 = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnRelatorioEntrega = New Janus.Windows.EditControls.UIButton()
        Me.btnRelatorioEntrega2 = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDespesa.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdImportacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDespesa})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Importação"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 75)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 404)
        Me.grdListagem.TabIndex = 27
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = CType(resources.GetObject("btnExcelGrid.Image"), System.Drawing.Image)
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 461)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 26
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = CType(resources.GetObject("btnAgruparGrid.Image"), System.Drawing.Image)
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 461)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 25
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = CType(resources.GetObject("btnConfigurarGrid.Image"), System.Drawing.Image)
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 461)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 4
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTermino)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicio)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 66)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(6, 35)
        Me.txtNotaFiscalFiltro.MaxLength = 35
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(135, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 29
        '
        'lblNotaFiscalFiltro
        '
        Me.lblNotaFiscalFiltro.AutoSize = True
        Me.lblNotaFiscalFiltro.Location = New System.Drawing.Point(3, 18)
        Me.lblNotaFiscalFiltro.Name = "lblNotaFiscalFiltro"
        Me.lblNotaFiscalFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalFiltro.TabIndex = 28
        Me.lblNotaFiscalFiltro.Text = "Nota Fiscal:"
        '
        'dtpDataTermino
        '
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(262, 35)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataTermino.TabIndex = 25
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(144, 18)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 14
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'dtpDataInicio
        '
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(147, 35)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.ShowCheckBox = True
        Me.dtpDataInicio.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataInicio.TabIndex = 15
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 36)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 23
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnRelatorioEntrega)
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = CType(resources.GetObject("btnNovo1.Image"), System.Drawing.Image)
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(700, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 2
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
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDespesa
        '
        Me.pagDespesa.Controls.Add(Me.grpLegenda)
        Me.pagDespesa.Controls.Add(Me.btnExcelGridArquivo)
        Me.pagDespesa.Controls.Add(Me.btnAgruparGridArquivo)
        Me.pagDespesa.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagDespesa.Controls.Add(Me.grdImportacao)
        Me.pagDespesa.Controls.Add(Me.grpArquivo)
        Me.pagDespesa.Controls.Add(Me.grdControlesEdicao)
        Me.pagDespesa.Key = "pagDespesa"
        Me.pagDespesa.Location = New System.Drawing.Point(1, 22)
        Me.pagDespesa.Name = "pagDespesa"
        Me.pagDespesa.Size = New System.Drawing.Size(913, 543)
        Me.pagDespesa.TabStop = True
        Me.pagDespesa.Text = "Importação"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.Label1)
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoVenda)
        Me.grpLegenda.Controls.Add(Me.picLegendaTipoOrcamento)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(334, 51)
        Me.grpLegenda.TabIndex = 94
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(191, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Produto Não Encontrado"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Peru
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(174, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblLegendaPedidoVenda
        '
        Me.lblLegendaPedidoVenda.AutoSize = True
        Me.lblLegendaPedidoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLegendaPedidoVenda.Location = New System.Drawing.Point(30, 21)
        Me.lblLegendaPedidoVenda.Name = "lblLegendaPedidoVenda"
        Me.lblLegendaPedidoVenda.Size = New System.Drawing.Size(139, 14)
        Me.lblLegendaPedidoVenda.TabIndex = 0
        Me.lblLegendaPedidoVenda.Text = "Consultora Não Encontrada"
        '
        'picLegendaTipoOrcamento
        '
        Me.picLegendaTipoOrcamento.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaTipoOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaTipoOrcamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picLegendaTipoOrcamento.Location = New System.Drawing.Point(13, 21)
        Me.picLegendaTipoOrcamento.Name = "picLegendaTipoOrcamento"
        Me.picLegendaTipoOrcamento.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaTipoOrcamento.TabIndex = 4
        Me.picLegendaTipoOrcamento.TabStop = False
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = CType(resources.GetObject("btnExcelGridArquivo.Image"), System.Drawing.Image)
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 462)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 30
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = CType(resources.GetObject("btnAgruparGridArquivo.Image"), System.Drawing.Image)
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 462)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 29
        Me.btnAgruparGridArquivo.TabStop = False
        Me.btnAgruparGridArquivo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridArquivo
        '
        Me.btnConfigurarGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridArquivo.Image = CType(resources.GetObject("btnConfigurarGridArquivo.Image"), System.Drawing.Image)
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(10, 462)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 28
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'grdImportacao
        '
        Me.grdImportacao.AllowChildTableGroups = True
        Me.grdImportacao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdImportacao.AlternatingColors = True
        Me.grdImportacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdImportacao.AutoEdit = True
        grdImportacao_DesignTimeLayout.LayoutString = resources.GetString("grdImportacao_DesignTimeLayout.LayoutString")
        Me.grdImportacao.DesignTimeLayout = grdImportacao_DesignTimeLayout
        Me.grdImportacao.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdImportacao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdImportacao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdImportacao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdImportacao.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdImportacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdImportacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdImportacao.FrozenColumns = 5
        Me.grdImportacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdImportacao.GroupByBoxVisible = False
        Me.grdImportacao.Hierarchical = True
        Me.grdImportacao.Location = New System.Drawing.Point(8, 80)
        Me.grdImportacao.Name = "grdImportacao"
        Me.grdImportacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdImportacao.RecordNavigator = True
        Me.grdImportacao.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdImportacao.SelectedFormatStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grdImportacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdImportacao.Size = New System.Drawing.Size(897, 399)
        Me.grdImportacao.TabIndex = 31
        Me.grdImportacao.TabStop = False
        Me.grdImportacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdImportacao.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdImportacao.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdImportacao.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdImportacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdImportacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdImportacao.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdImportacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdImportacao.VisualStyleManager = Me.vsmMain
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.lblCNAB)
        Me.grpArquivo.Controls.Add(Me.cboNFEntrada)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(897, 67)
        Me.grpArquivo.TabIndex = 1
        Me.grpArquivo.Text = "Arquivo"
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'lblCNAB
        '
        Me.lblCNAB.AutoSize = True
        Me.lblCNAB.Location = New System.Drawing.Point(3, 19)
        Me.lblCNAB.Name = "lblCNAB"
        Me.lblCNAB.Size = New System.Drawing.Size(103, 14)
        Me.lblCNAB.TabIndex = 12
        Me.lblCNAB.Text = "Nota Fiscal Entrada:"
        '
        'cboNFEntrada
        '
        Me.cboNFEntrada.AutoSize = False
        Me.cboNFEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNFEntrada.Location = New System.Drawing.Point(7, 36)
        Me.cboNFEntrada.Name = "cboNFEntrada"
        Me.cboNFEntrada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNFEntrada.Size = New System.Drawing.Size(113, 20)
        Me.cboNFEntrada.TabIndex = 13
        '
        'txtArquivo
        '
        Me.txtArquivo.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivo.Location = New System.Drawing.Point(126, 36)
        Me.txtArquivo.MaxLength = 50
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(494, 20)
        Me.txtArquivo.TabIndex = 10
        Me.txtArquivo.TabStop = False
        '
        'btnArquivo
        '
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnArquivo.Location = New System.Drawing.Point(619, 36)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(23, 20)
        Me.btnArquivo.TabIndex = 11
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(123, 19)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 1
        Me.lblArquivo.Text = "Arquivo:"
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnRelatorioEntrega2)
        Me.grdControlesEdicao.Controls.Add(Me.btnNovo2)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvar)
        Me.grdControlesEdicao.Controls.Add(Me.btnVoltar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(348, 483)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(557, 51)
        Me.grdControlesEdicao.TabIndex = 3
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnNovo2
        '
        Me.btnNovo2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo2.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo2.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo2.Location = New System.Drawing.Point(263, 17)
        Me.btnNovo2.Name = "btnNovo2"
        Me.btnNovo2.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo2.TabIndex = 2
        Me.btnNovo2.Text = "Novo"
        Me.btnNovo2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(360, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(457, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 0
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnRelatorioEntrega
        '
        Me.btnRelatorioEntrega.Image = Global.INTERACTI.My.Resources.Resources.truck
        Me.btnRelatorioEntrega.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRelatorioEntrega.Location = New System.Drawing.Point(6, 17)
        Me.btnRelatorioEntrega.Name = "btnRelatorioEntrega"
        Me.btnRelatorioEntrega.Size = New System.Drawing.Size(135, 23)
        Me.btnRelatorioEntrega.TabIndex = 9
        Me.btnRelatorioEntrega.Text = "Relatório de Entrega"
        Me.btnRelatorioEntrega.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnRelatorioEntrega2
        '
        Me.btnRelatorioEntrega2.Enabled = False
        Me.btnRelatorioEntrega2.Image = Global.INTERACTI.My.Resources.Resources.truck
        Me.btnRelatorioEntrega2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRelatorioEntrega2.Location = New System.Drawing.Point(6, 16)
        Me.btnRelatorioEntrega2.Name = "btnRelatorioEntrega2"
        Me.btnRelatorioEntrega2.Size = New System.Drawing.Size(135, 23)
        Me.btnRelatorioEntrega2.TabIndex = 9
        Me.btnRelatorioEntrega2.Text = "Relatório de Entrega"
        Me.btnRelatorioEntrega2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrIntDistibuicaoConsultora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrIntDistibuicaoConsultora"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDespesa.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdImportacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDespesa As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grdImportacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblCNAB As System.Windows.Forms.Label
    Friend WithEvents cboNFEntrada As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents picLegendaTipoOrcamento As System.Windows.Forms.PictureBox
    Friend WithEvents btnRelatorioEntrega As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnRelatorioEntrega2 As Janus.Windows.EditControls.UIButton

End Class
