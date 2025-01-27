<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVenEmbraer
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
        Dim grdEmbraer_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVenEmbraer))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoPlanilha = New System.Windows.Forms.Label()
        Me.cboTipoPlanilha = New Janus.Windows.EditControls.UIComboBox()
        Me.txtPlanilha = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlanilha = New System.Windows.Forms.Label()
        Me.txtArquivoExcel = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblArquivoExcel = New System.Windows.Forms.Label()
        Me.btnArquivoExcel = New Janus.Windows.EditControls.UIButton()
        Me.lblLinhaInicio = New System.Windows.Forms.Label()
        Me.txtLinhaInicio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPlanilhaDesenho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlanilhaDesenho = New System.Windows.Forms.Label()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaPedidoJaLancado = New System.Windows.Forms.PictureBox()
        Me.picLegendaPedidoNovo = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPedidoNovo = New System.Windows.Forms.Label()
        Me.lblLegendaPedidoJaLancado = New System.Windows.Forms.Label()
        Me.grpDadosArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboColunaAcaoDias = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaAcaoDias = New System.Windows.Forms.Label()
        Me.cboColunaDepositoArmazenamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaDepositoArmazenamento = New System.Windows.Forms.Label()
        Me.cboColunaUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaUnidadeMedida = New System.Windows.Forms.Label()
        Me.cboColunaCiclo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaCiclo = New System.Windows.Forms.Label()
        Me.cboColunaRevisaoPartNumber = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaRevisaoPartNumber = New System.Windows.Forms.Label()
        Me.cboColunaCentro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaCentro = New System.Windows.Forms.Label()
        Me.cboColunaValorUnitario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaValorUnitario = New System.Windows.Forms.Label()
        Me.cboColunaCodigoEmbraer = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaCodigoEmbraer = New System.Windows.Forms.Label()
        Me.cboColunaCodigoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaCodigoItem = New System.Windows.Forms.Label()
        Me.cboColunaRequerente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaRequerente = New System.Windows.Forms.Label()
        Me.cboColunaPrioridade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaPrioridade = New System.Windows.Forms.Label()
        Me.cboColunaTipoPO = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaTipoPO = New System.Windows.Forms.Label()
        Me.cboColunaPrevisaoEntrega = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaPrevisaoEntrega = New System.Windows.Forms.Label()
        Me.cboColunaQuantidade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaQuantidade = New System.Windows.Forms.Label()
        Me.cboColunaStatus = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaStatus = New System.Windows.Forms.Label()
        Me.lblColunaPO = New System.Windows.Forms.Label()
        Me.cboColunaPO = New Janus.Windows.EditControls.UIComboBox()
        Me.cboColunaPOLinha = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaPOLinha = New System.Windows.Forms.Label()
        Me.grdEmbraer = New Janus.Windows.GridEX.GridEX()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvarLinha = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvarPO = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaPedidoJaLancado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaPedidoNovo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosArquivo.SuspendLayout()
        CType(Me.grdEmbraer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 654)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGrid)
        Me.pagDados.Controls.Add(Me.btnAgruparGrid)
        Me.pagDados.Controls.Add(Me.grpArquivo)
        Me.pagDados.Controls.Add(Me.btnConfigurarGrid)
        Me.pagDados.Controls.Add(Me.grpLegenda)
        Me.pagDados.Controls.Add(Me.grpDadosArquivo)
        Me.pagDados.Controls.Add(Me.grdEmbraer)
        Me.pagDados.Controls.Add(Me.grdControlesEdicao)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 631)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Integração - Embraer"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(294, 551)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 6
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(270, 551)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 5
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.lblTipoPlanilha)
        Me.grpArquivo.Controls.Add(Me.cboTipoPlanilha)
        Me.grpArquivo.Controls.Add(Me.txtPlanilha)
        Me.grpArquivo.Controls.Add(Me.lblPlanilha)
        Me.grpArquivo.Controls.Add(Me.txtArquivoExcel)
        Me.grpArquivo.Controls.Add(Me.lblArquivoExcel)
        Me.grpArquivo.Controls.Add(Me.btnArquivoExcel)
        Me.grpArquivo.Controls.Add(Me.lblLinhaInicio)
        Me.grpArquivo.Controls.Add(Me.txtLinhaInicio)
        Me.grpArquivo.Controls.Add(Me.txtPlanilhaDesenho)
        Me.grpArquivo.Controls.Add(Me.lblPlanilhaDesenho)
        Me.grpArquivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(982, 64)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'lblTipoPlanilha
        '
        Me.lblTipoPlanilha.AutoSize = True
        Me.lblTipoPlanilha.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoPlanilha.Name = "lblTipoPlanilha"
        Me.lblTipoPlanilha.Size = New System.Drawing.Size(69, 14)
        Me.lblTipoPlanilha.TabIndex = 0
        Me.lblTipoPlanilha.Text = "Tipo Planilha:"
        '
        'cboTipoPlanilha
        '
        Me.cboTipoPlanilha.AutoSize = False
        Me.cboTipoPlanilha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoPlanilha.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoPlanilha.Name = "cboTipoPlanilha"
        Me.cboTipoPlanilha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoPlanilha.Size = New System.Drawing.Size(131, 20)
        Me.cboTipoPlanilha.TabIndex = 1
        '
        'txtPlanilha
        '
        Me.txtPlanilha.Location = New System.Drawing.Point(268, 34)
        Me.txtPlanilha.MaxLength = 35
        Me.txtPlanilha.Name = "txtPlanilha"
        Me.txtPlanilha.Size = New System.Drawing.Size(132, 20)
        Me.txtPlanilha.TabIndex = 5
        '
        'lblPlanilha
        '
        Me.lblPlanilha.AutoSize = True
        Me.lblPlanilha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlanilha.Location = New System.Drawing.Point(265, 17)
        Me.lblPlanilha.Name = "lblPlanilha"
        Me.lblPlanilha.Size = New System.Drawing.Size(46, 14)
        Me.lblPlanilha.TabIndex = 4
        Me.lblPlanilha.Text = "Planilha:"
        '
        'txtArquivoExcel
        '
        Me.txtArquivoExcel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivoExcel.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivoExcel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivoExcel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivoExcel.Location = New System.Drawing.Point(544, 34)
        Me.txtArquivoExcel.MaxLength = 50
        Me.txtArquivoExcel.Name = "txtArquivoExcel"
        Me.txtArquivoExcel.ReadOnly = True
        Me.txtArquivoExcel.Size = New System.Drawing.Size(407, 20)
        Me.txtArquivoExcel.TabIndex = 9
        Me.txtArquivoExcel.TabStop = False
        '
        'lblArquivoExcel
        '
        Me.lblArquivoExcel.AutoSize = True
        Me.lblArquivoExcel.Location = New System.Drawing.Point(541, 17)
        Me.lblArquivoExcel.Name = "lblArquivoExcel"
        Me.lblArquivoExcel.Size = New System.Drawing.Size(77, 14)
        Me.lblArquivoExcel.TabIndex = 8
        Me.lblArquivoExcel.Text = "Arquivo Excel:"
        '
        'btnArquivoExcel
        '
        Me.btnArquivoExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivoExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivoExcel.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnArquivoExcel.Location = New System.Drawing.Point(950, 34)
        Me.btnArquivoExcel.Name = "btnArquivoExcel"
        Me.btnArquivoExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivoExcel.Size = New System.Drawing.Size(23, 20)
        Me.btnArquivoExcel.TabIndex = 10
        Me.btnArquivoExcel.Text = "..."
        Me.btnArquivoExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblLinhaInicio
        '
        Me.lblLinhaInicio.AutoSize = True
        Me.lblLinhaInicio.Location = New System.Drawing.Point(143, 17)
        Me.lblLinhaInicio.Name = "lblLinhaInicio"
        Me.lblLinhaInicio.Size = New System.Drawing.Size(63, 14)
        Me.lblLinhaInicio.TabIndex = 3
        Me.lblLinhaInicio.Text = "Linha Início:"
        '
        'txtLinhaInicio
        '
        Me.txtLinhaInicio.DecimalDigits = 0
        Me.txtLinhaInicio.Location = New System.Drawing.Point(146, 34)
        Me.txtLinhaInicio.Name = "txtLinhaInicio"
        Me.txtLinhaInicio.Size = New System.Drawing.Size(116, 20)
        Me.txtLinhaInicio.TabIndex = 2
        Me.txtLinhaInicio.Text = "0"
        Me.txtLinhaInicio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtPlanilhaDesenho
        '
        Me.txtPlanilhaDesenho.Location = New System.Drawing.Point(406, 34)
        Me.txtPlanilhaDesenho.MaxLength = 35
        Me.txtPlanilhaDesenho.Name = "txtPlanilhaDesenho"
        Me.txtPlanilhaDesenho.Size = New System.Drawing.Size(132, 20)
        Me.txtPlanilhaDesenho.TabIndex = 7
        '
        'lblPlanilhaDesenho
        '
        Me.lblPlanilhaDesenho.AutoSize = True
        Me.lblPlanilhaDesenho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlanilhaDesenho.Location = New System.Drawing.Point(403, 17)
        Me.lblPlanilhaDesenho.Name = "lblPlanilhaDesenho"
        Me.lblPlanilhaDesenho.Size = New System.Drawing.Size(92, 14)
        Me.lblPlanilhaDesenho.TabIndex = 6
        Me.lblPlanilhaDesenho.Text = "Planilha Desenho:"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(246, 551)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 4
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaPedidoJaLancado)
        Me.grpLegenda.Controls.Add(Me.picLegendaPedidoNovo)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoNovo)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoJaLancado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 571)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(228, 51)
        Me.grpLegenda.TabIndex = 1
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaPedidoJaLancado
        '
        Me.picLegendaPedidoJaLancado.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaPedidoJaLancado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaPedidoJaLancado.Location = New System.Drawing.Point(106, 21)
        Me.picLegendaPedidoJaLancado.Name = "picLegendaPedidoJaLancado"
        Me.picLegendaPedidoJaLancado.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaPedidoJaLancado.TabIndex = 11
        Me.picLegendaPedidoJaLancado.TabStop = False
        '
        'picLegendaPedidoNovo
        '
        Me.picLegendaPedidoNovo.BackColor = System.Drawing.Color.DarkGray
        Me.picLegendaPedidoNovo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaPedidoNovo.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaPedidoNovo.Name = "picLegendaPedidoNovo"
        Me.picLegendaPedidoNovo.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaPedidoNovo.TabIndex = 13
        Me.picLegendaPedidoNovo.TabStop = False
        '
        'lblLegendaPedidoNovo
        '
        Me.lblLegendaPedidoNovo.AutoSize = True
        Me.lblLegendaPedidoNovo.Location = New System.Drawing.Point(30, 21)
        Me.lblLegendaPedidoNovo.Name = "lblLegendaPedidoNovo"
        Me.lblLegendaPedidoNovo.Size = New System.Drawing.Size(67, 14)
        Me.lblLegendaPedidoNovo.TabIndex = 0
        Me.lblLegendaPedidoNovo.Text = "Pedido Novo"
        '
        'lblLegendaPedidoJaLancado
        '
        Me.lblLegendaPedidoJaLancado.AutoSize = True
        Me.lblLegendaPedidoJaLancado.Location = New System.Drawing.Point(127, 21)
        Me.lblLegendaPedidoJaLancado.Name = "lblLegendaPedidoJaLancado"
        Me.lblLegendaPedidoJaLancado.Size = New System.Drawing.Size(95, 14)
        Me.lblLegendaPedidoJaLancado.TabIndex = 1
        Me.lblLegendaPedidoJaLancado.Text = "Pedido já Lançado"
        '
        'grpDadosArquivo
        '
        Me.grpDadosArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpDadosArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaAcaoDias)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaAcaoDias)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaDepositoArmazenamento)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaDepositoArmazenamento)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaUnidadeMedida)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaUnidadeMedida)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaCiclo)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaCiclo)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaRevisaoPartNumber)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaRevisaoPartNumber)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaCentro)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaCentro)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaValorUnitario)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaValorUnitario)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaCodigoEmbraer)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaCodigoEmbraer)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaCodigoItem)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaCodigoItem)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaRequerente)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaRequerente)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaPrioridade)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaPrioridade)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaTipoPO)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaTipoPO)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaPrevisaoEntrega)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaPrevisaoEntrega)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaQuantidade)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaQuantidade)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaStatus)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaStatus)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaPO)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaPO)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaPOLinha)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaPOLinha)
        Me.grpDadosArquivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosArquivo.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosArquivo.Name = "grpDadosArquivo"
        Me.grpDadosArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosArquivo.Size = New System.Drawing.Size(228, 498)
        Me.grpDadosArquivo.TabIndex = 0
        Me.grpDadosArquivo.Text = "Configuração da Planilha Excel"
        Me.grpDadosArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosArquivo.VisualStyleManager = Me.vsmMain
        '
        'cboColunaAcaoDias
        '
        Me.cboColunaAcaoDias.AutoSize = False
        Me.cboColunaAcaoDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaAcaoDias.Location = New System.Drawing.Point(104, 435)
        Me.cboColunaAcaoDias.Name = "cboColunaAcaoDias"
        Me.cboColunaAcaoDias.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaAcaoDias.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaAcaoDias.TabIndex = 33
        '
        'lblColunaAcaoDias
        '
        Me.lblColunaAcaoDias.AutoSize = True
        Me.lblColunaAcaoDias.Location = New System.Drawing.Point(6, 438)
        Me.lblColunaAcaoDias.Name = "lblColunaAcaoDias"
        Me.lblColunaAcaoDias.Size = New System.Drawing.Size(67, 14)
        Me.lblColunaAcaoDias.TabIndex = 32
        Me.lblColunaAcaoDias.Text = "Ação (dias):"
        '
        'cboColunaDepositoArmazenamento
        '
        Me.cboColunaDepositoArmazenamento.AutoSize = False
        Me.cboColunaDepositoArmazenamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaDepositoArmazenamento.Location = New System.Drawing.Point(104, 409)
        Me.cboColunaDepositoArmazenamento.Name = "cboColunaDepositoArmazenamento"
        Me.cboColunaDepositoArmazenamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaDepositoArmazenamento.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaDepositoArmazenamento.TabIndex = 31
        '
        'lblColunaDepositoArmazenamento
        '
        Me.lblColunaDepositoArmazenamento.AutoSize = True
        Me.lblColunaDepositoArmazenamento.Location = New System.Drawing.Point(6, 412)
        Me.lblColunaDepositoArmazenamento.Name = "lblColunaDepositoArmazenamento"
        Me.lblColunaDepositoArmazenamento.Size = New System.Drawing.Size(69, 14)
        Me.lblColunaDepositoArmazenamento.TabIndex = 30
        Me.lblColunaDepositoArmazenamento.Text = "Dep. Armaz.:"
        '
        'cboColunaUnidadeMedida
        '
        Me.cboColunaUnidadeMedida.AutoSize = False
        Me.cboColunaUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaUnidadeMedida.Location = New System.Drawing.Point(104, 383)
        Me.cboColunaUnidadeMedida.Name = "cboColunaUnidadeMedida"
        Me.cboColunaUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaUnidadeMedida.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaUnidadeMedida.TabIndex = 29
        '
        'lblColunaUnidadeMedida
        '
        Me.lblColunaUnidadeMedida.AutoSize = True
        Me.lblColunaUnidadeMedida.Location = New System.Drawing.Point(6, 386)
        Me.lblColunaUnidadeMedida.Name = "lblColunaUnidadeMedida"
        Me.lblColunaUnidadeMedida.Size = New System.Drawing.Size(86, 14)
        Me.lblColunaUnidadeMedida.TabIndex = 28
        Me.lblColunaUnidadeMedida.Text = "Unidade Medida:"
        '
        'cboColunaCiclo
        '
        Me.cboColunaCiclo.AutoSize = False
        Me.cboColunaCiclo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaCiclo.Location = New System.Drawing.Point(104, 357)
        Me.cboColunaCiclo.Name = "cboColunaCiclo"
        Me.cboColunaCiclo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaCiclo.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaCiclo.TabIndex = 27
        '
        'lblColunaCiclo
        '
        Me.lblColunaCiclo.AutoSize = True
        Me.lblColunaCiclo.Location = New System.Drawing.Point(6, 360)
        Me.lblColunaCiclo.Name = "lblColunaCiclo"
        Me.lblColunaCiclo.Size = New System.Drawing.Size(33, 14)
        Me.lblColunaCiclo.TabIndex = 26
        Me.lblColunaCiclo.Text = "Ciclo:"
        '
        'cboColunaRevisaoPartNumber
        '
        Me.cboColunaRevisaoPartNumber.AutoSize = False
        Me.cboColunaRevisaoPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaRevisaoPartNumber.Location = New System.Drawing.Point(104, 227)
        Me.cboColunaRevisaoPartNumber.Name = "cboColunaRevisaoPartNumber"
        Me.cboColunaRevisaoPartNumber.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaRevisaoPartNumber.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaRevisaoPartNumber.TabIndex = 17
        '
        'lblColunaRevisaoPartNumber
        '
        Me.lblColunaRevisaoPartNumber.AutoSize = True
        Me.lblColunaRevisaoPartNumber.Location = New System.Drawing.Point(6, 230)
        Me.lblColunaRevisaoPartNumber.Name = "lblColunaRevisaoPartNumber"
        Me.lblColunaRevisaoPartNumber.Size = New System.Drawing.Size(93, 14)
        Me.lblColunaRevisaoPartNumber.TabIndex = 16
        Me.lblColunaRevisaoPartNumber.Text = "Rev. Part Number:"
        '
        'cboColunaCentro
        '
        Me.cboColunaCentro.AutoSize = False
        Me.cboColunaCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaCentro.Location = New System.Drawing.Point(104, 305)
        Me.cboColunaCentro.Name = "cboColunaCentro"
        Me.cboColunaCentro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaCentro.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaCentro.TabIndex = 23
        '
        'lblColunaCentro
        '
        Me.lblColunaCentro.AutoSize = True
        Me.lblColunaCentro.Location = New System.Drawing.Point(6, 308)
        Me.lblColunaCentro.Name = "lblColunaCentro"
        Me.lblColunaCentro.Size = New System.Drawing.Size(42, 14)
        Me.lblColunaCentro.TabIndex = 22
        Me.lblColunaCentro.Text = "Centro:"
        '
        'cboColunaValorUnitario
        '
        Me.cboColunaValorUnitario.AutoSize = False
        Me.cboColunaValorUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaValorUnitario.Location = New System.Drawing.Point(104, 279)
        Me.cboColunaValorUnitario.Name = "cboColunaValorUnitario"
        Me.cboColunaValorUnitario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaValorUnitario.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaValorUnitario.TabIndex = 21
        '
        'lblColunaValorUnitario
        '
        Me.lblColunaValorUnitario.AutoSize = True
        Me.lblColunaValorUnitario.Location = New System.Drawing.Point(6, 282)
        Me.lblColunaValorUnitario.Name = "lblColunaValorUnitario"
        Me.lblColunaValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblColunaValorUnitario.TabIndex = 20
        Me.lblColunaValorUnitario.Text = "Valor Unitário:"
        '
        'cboColunaCodigoEmbraer
        '
        Me.cboColunaCodigoEmbraer.AutoSize = False
        Me.cboColunaCodigoEmbraer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaCodigoEmbraer.Location = New System.Drawing.Point(104, 253)
        Me.cboColunaCodigoEmbraer.Name = "cboColunaCodigoEmbraer"
        Me.cboColunaCodigoEmbraer.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaCodigoEmbraer.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaCodigoEmbraer.TabIndex = 19
        '
        'lblColunaCodigoEmbraer
        '
        Me.lblColunaCodigoEmbraer.AutoSize = True
        Me.lblColunaCodigoEmbraer.Location = New System.Drawing.Point(6, 256)
        Me.lblColunaCodigoEmbraer.Name = "lblColunaCodigoEmbraer"
        Me.lblColunaCodigoEmbraer.Size = New System.Drawing.Size(38, 14)
        Me.lblColunaCodigoEmbraer.TabIndex = 18
        Me.lblColunaCodigoEmbraer.Text = "CEMB:"
        '
        'cboColunaCodigoItem
        '
        Me.cboColunaCodigoItem.AutoSize = False
        Me.cboColunaCodigoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaCodigoItem.Location = New System.Drawing.Point(104, 201)
        Me.cboColunaCodigoItem.Name = "cboColunaCodigoItem"
        Me.cboColunaCodigoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaCodigoItem.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaCodigoItem.TabIndex = 15
        '
        'lblColunaCodigoItem
        '
        Me.lblColunaCodigoItem.AutoSize = True
        Me.lblColunaCodigoItem.Location = New System.Drawing.Point(6, 204)
        Me.lblColunaCodigoItem.Name = "lblColunaCodigoItem"
        Me.lblColunaCodigoItem.Size = New System.Drawing.Size(69, 14)
        Me.lblColunaCodigoItem.TabIndex = 14
        Me.lblColunaCodigoItem.Text = "Part Number:"
        '
        'cboColunaRequerente
        '
        Me.cboColunaRequerente.AutoSize = False
        Me.cboColunaRequerente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaRequerente.Location = New System.Drawing.Point(104, 331)
        Me.cboColunaRequerente.Name = "cboColunaRequerente"
        Me.cboColunaRequerente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaRequerente.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaRequerente.TabIndex = 25
        '
        'lblColunaRequerente
        '
        Me.lblColunaRequerente.AutoSize = True
        Me.lblColunaRequerente.Location = New System.Drawing.Point(6, 334)
        Me.lblColunaRequerente.Name = "lblColunaRequerente"
        Me.lblColunaRequerente.Size = New System.Drawing.Size(66, 14)
        Me.lblColunaRequerente.TabIndex = 24
        Me.lblColunaRequerente.Text = "Requerente:"
        '
        'cboColunaPrioridade
        '
        Me.cboColunaPrioridade.AutoSize = False
        Me.cboColunaPrioridade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaPrioridade.Location = New System.Drawing.Point(104, 175)
        Me.cboColunaPrioridade.Name = "cboColunaPrioridade"
        Me.cboColunaPrioridade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaPrioridade.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaPrioridade.TabIndex = 13
        '
        'lblColunaPrioridade
        '
        Me.lblColunaPrioridade.AutoSize = True
        Me.lblColunaPrioridade.Location = New System.Drawing.Point(6, 178)
        Me.lblColunaPrioridade.Name = "lblColunaPrioridade"
        Me.lblColunaPrioridade.Size = New System.Drawing.Size(58, 14)
        Me.lblColunaPrioridade.TabIndex = 12
        Me.lblColunaPrioridade.Text = "Prioridade:"
        '
        'cboColunaTipoPO
        '
        Me.cboColunaTipoPO.AutoSize = False
        Me.cboColunaTipoPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaTipoPO.Location = New System.Drawing.Point(104, 149)
        Me.cboColunaTipoPO.Name = "cboColunaTipoPO"
        Me.cboColunaTipoPO.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaTipoPO.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaTipoPO.TabIndex = 11
        '
        'lblColunaTipoPO
        '
        Me.lblColunaTipoPO.AutoSize = True
        Me.lblColunaTipoPO.Location = New System.Drawing.Point(6, 152)
        Me.lblColunaTipoPO.Name = "lblColunaTipoPO"
        Me.lblColunaTipoPO.Size = New System.Drawing.Size(62, 14)
        Me.lblColunaTipoPO.TabIndex = 10
        Me.lblColunaTipoPO.Text = "Tipo de PO:"
        '
        'cboColunaPrevisaoEntrega
        '
        Me.cboColunaPrevisaoEntrega.AutoSize = False
        Me.cboColunaPrevisaoEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaPrevisaoEntrega.Location = New System.Drawing.Point(104, 123)
        Me.cboColunaPrevisaoEntrega.Name = "cboColunaPrevisaoEntrega"
        Me.cboColunaPrevisaoEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaPrevisaoEntrega.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaPrevisaoEntrega.TabIndex = 9
        '
        'lblColunaPrevisaoEntrega
        '
        Me.lblColunaPrevisaoEntrega.AutoSize = True
        Me.lblColunaPrevisaoEntrega.Location = New System.Drawing.Point(6, 126)
        Me.lblColunaPrevisaoEntrega.Name = "lblColunaPrevisaoEntrega"
        Me.lblColunaPrevisaoEntrega.Size = New System.Drawing.Size(92, 14)
        Me.lblColunaPrevisaoEntrega.TabIndex = 8
        Me.lblColunaPrevisaoEntrega.Text = "Previsão Entrega:"
        '
        'cboColunaQuantidade
        '
        Me.cboColunaQuantidade.AutoSize = False
        Me.cboColunaQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaQuantidade.Location = New System.Drawing.Point(104, 97)
        Me.cboColunaQuantidade.Name = "cboColunaQuantidade"
        Me.cboColunaQuantidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaQuantidade.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaQuantidade.TabIndex = 7
        '
        'lblColunaQuantidade
        '
        Me.lblColunaQuantidade.AutoSize = True
        Me.lblColunaQuantidade.Location = New System.Drawing.Point(6, 100)
        Me.lblColunaQuantidade.Name = "lblColunaQuantidade"
        Me.lblColunaQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblColunaQuantidade.TabIndex = 6
        Me.lblColunaQuantidade.Text = "Quantidade:"
        '
        'cboColunaStatus
        '
        Me.cboColunaStatus.AutoSize = False
        Me.cboColunaStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaStatus.Location = New System.Drawing.Point(104, 71)
        Me.cboColunaStatus.Name = "cboColunaStatus"
        Me.cboColunaStatus.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaStatus.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaStatus.TabIndex = 5
        '
        'lblColunaStatus
        '
        Me.lblColunaStatus.AutoSize = True
        Me.lblColunaStatus.Location = New System.Drawing.Point(6, 74)
        Me.lblColunaStatus.Name = "lblColunaStatus"
        Me.lblColunaStatus.Size = New System.Drawing.Size(41, 14)
        Me.lblColunaStatus.TabIndex = 4
        Me.lblColunaStatus.Text = "Status:"
        '
        'lblColunaPO
        '
        Me.lblColunaPO.AutoSize = True
        Me.lblColunaPO.Location = New System.Drawing.Point(6, 22)
        Me.lblColunaPO.Name = "lblColunaPO"
        Me.lblColunaPO.Size = New System.Drawing.Size(24, 14)
        Me.lblColunaPO.TabIndex = 0
        Me.lblColunaPO.Text = "PO:"
        '
        'cboColunaPO
        '
        Me.cboColunaPO.AutoSize = False
        Me.cboColunaPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaPO.Location = New System.Drawing.Point(104, 19)
        Me.cboColunaPO.Name = "cboColunaPO"
        Me.cboColunaPO.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaPO.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaPO.TabIndex = 1
        '
        'cboColunaPOLinha
        '
        Me.cboColunaPOLinha.AutoSize = False
        Me.cboColunaPOLinha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaPOLinha.Location = New System.Drawing.Point(104, 45)
        Me.cboColunaPOLinha.Name = "cboColunaPOLinha"
        Me.cboColunaPOLinha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaPOLinha.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaPOLinha.TabIndex = 3
        '
        'lblColunaPOLinha
        '
        Me.lblColunaPOLinha.AutoSize = True
        Me.lblColunaPOLinha.Location = New System.Drawing.Point(6, 48)
        Me.lblColunaPOLinha.Name = "lblColunaPOLinha"
        Me.lblColunaPOLinha.Size = New System.Drawing.Size(53, 14)
        Me.lblColunaPOLinha.TabIndex = 2
        Me.lblColunaPOLinha.Text = "PO Linha:"
        '
        'grdEmbraer
        '
        Me.grdEmbraer.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEmbraer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdEmbraer_DesignTimeLayout.LayoutString = resources.GetString("grdEmbraer_DesignTimeLayout.LayoutString")
        Me.grdEmbraer.DesignTimeLayout = grdEmbraer_DesignTimeLayout
        Me.grdEmbraer.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdEmbraer.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdEmbraer.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdEmbraer.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdEmbraer.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEmbraer.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEmbraer.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEmbraer.GroupByBoxVisible = False
        Me.grdEmbraer.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdEmbraer.Location = New System.Drawing.Point(245, 76)
        Me.grdEmbraer.Name = "grdEmbraer"
        Me.grdEmbraer.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEmbraer.RecordNavigator = True
        Me.grdEmbraer.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEmbraer.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEmbraer.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEmbraer.Size = New System.Drawing.Size(745, 492)
        Me.grdEmbraer.TabIndex = 3
        Me.grdEmbraer.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdEmbraer.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdEmbraer.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdEmbraer.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdEmbraer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEmbraer.VisualStyleManager = Me.vsmMain
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnNovo)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvarLinha)
        Me.grdControlesEdicao.Controls.Add(Me.btnSair)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvarPO)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(245, 571)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(745, 51)
        Me.grdControlesEdicao.TabIndex = 7
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(76, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvarLinha
        '
        Me.btnSalvarLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarLinha.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvarLinha.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarLinha.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarLinha.Location = New System.Drawing.Point(173, 17)
        Me.btnSalvarLinha.Name = "btnSalvarLinha"
        Me.btnSalvarLinha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarLinha.Size = New System.Drawing.Size(230, 23)
        Me.btnSalvarLinha.TabIndex = 1
        Me.btnSalvarLinha.Text = "Cadastrar um Pedido Venda por PO / Linha"
        Me.btnSalvarLinha.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(645, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvarPO
        '
        Me.btnSalvarPO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarPO.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvarPO.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarPO.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarPO.Location = New System.Drawing.Point(409, 17)
        Me.btnSalvarPO.Name = "btnSalvarPO"
        Me.btnSalvarPO.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarPO.Size = New System.Drawing.Size(230, 23)
        Me.btnSalvarPO.TabIndex = 2
        Me.btnSalvarPO.Text = "Cadastrar um Pedido Venda por PO"
        Me.btnSalvarPO.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrVenEmbraer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrVenEmbraer"
        Me.Size = New System.Drawing.Size(1000, 654)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaPedidoJaLancado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaPedidoNovo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosArquivo.ResumeLayout(False)
        Me.grpDadosArquivo.PerformLayout()
        CType(Me.grdEmbraer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvarPO As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboColunaCentro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaCentro As System.Windows.Forms.Label
    Friend WithEvents cboColunaValorUnitario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaValorUnitario As System.Windows.Forms.Label
    Friend WithEvents cboColunaCodigoEmbraer As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaCodigoEmbraer As System.Windows.Forms.Label
    Friend WithEvents cboColunaCodigoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaCodigoItem As System.Windows.Forms.Label
    Friend WithEvents cboColunaRequerente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaRequerente As System.Windows.Forms.Label
    Friend WithEvents cboColunaPrioridade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaPrioridade As System.Windows.Forms.Label
    Friend WithEvents cboColunaTipoPO As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaTipoPO As System.Windows.Forms.Label
    Friend WithEvents cboColunaPrevisaoEntrega As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaPrevisaoEntrega As System.Windows.Forms.Label
    Friend WithEvents cboColunaQuantidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtArquivoExcel As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnArquivoExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboColunaStatus As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblArquivoExcel As System.Windows.Forms.Label
    Friend WithEvents lblColunaStatus As System.Windows.Forms.Label
    Friend WithEvents lblColunaPO As System.Windows.Forms.Label
    Friend WithEvents cboColunaPO As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboColunaPOLinha As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaPOLinha As System.Windows.Forms.Label
    Friend WithEvents grdEmbraer As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaPedidoJaLancado As System.Windows.Forms.PictureBox
    Friend WithEvents picLegendaPedidoNovo As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPedidoNovo As System.Windows.Forms.Label
    Friend WithEvents lblLegendaPedidoJaLancado As System.Windows.Forms.Label
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Private WithEvents btnSalvarLinha As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents cboColunaRevisaoPartNumber As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaRevisaoPartNumber As System.Windows.Forms.Label
    Friend WithEvents lblLinhaInicio As System.Windows.Forms.Label
    Friend WithEvents txtLinhaInicio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboColunaAcaoDias As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaAcaoDias As System.Windows.Forms.Label
    Friend WithEvents cboColunaDepositoArmazenamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaDepositoArmazenamento As System.Windows.Forms.Label
    Friend WithEvents cboColunaUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents cboColunaCiclo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaCiclo As System.Windows.Forms.Label
    Friend WithEvents txtPlanilha As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlanilha As System.Windows.Forms.Label
    Friend WithEvents lblTipoPlanilha As System.Windows.Forms.Label
    Friend WithEvents cboTipoPlanilha As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtPlanilhaDesenho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlanilhaDesenho As System.Windows.Forms.Label

End Class
