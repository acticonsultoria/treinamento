<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdOrdemServico
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdOrdemServico))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdApontamento_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdApontamento_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column14.Image")
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim grdCustoMP_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdCustoMO_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRoteiro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCancelado = New System.Windows.Forms.Label()
        Me.picLegendaConcluido = New System.Windows.Forms.PictureBox()
        Me.lblLegendaConcluido = New System.Windows.Forms.Label()
        Me.picLegendaProducao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaProducao = New System.Windows.Forms.Label()
        Me.picLegendaAguardandoEstoque = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAguardandoEstoque = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtOMFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.LBLOMFiltro = New System.Windows.Forms.Label()
        Me.txtREFFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblREFFiltro = New System.Windows.Forms.Label()
        Me.txtPlantaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlantaFiltro = New System.Windows.Forms.Label()
        Me.lblTipoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.lblDataInicioFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtOrdemServicoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnGerarOrdemServico = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboUsuario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtTempoEstimado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtPercentualConcluido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtOrdemProducaoOriginal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtQuantidadeProduzida = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadeRejeito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadePlanejada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeRejeito = New System.Windows.Forms.Label()
        Me.lblTempoEstimado = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblQuantidadeProduzida = New System.Windows.Forms.Label()
        Me.lblQuantidadePlanejada = New System.Windows.Forms.Label()
        Me.lblPercentualConcluido = New System.Windows.Forms.Label()
        Me.lblOrdemProducaoOriginal = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagApontamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGridApontamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridApontamento = New System.Windows.Forms.Button()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObervacao = New System.Windows.Forms.Label()
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.pagCusto = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridMP = New System.Windows.Forms.Button()
        Me.btnExcelGridMO = New System.Windows.Forms.Button()
        Me.chrCusto = New Dundas.Charting.WinControl.Chart()
        Me.grdCustoMP = New Janus.Windows.GridEX.GridEX()
        Me.grdCustoMO = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizar = New Janus.Windows.EditControls.UIButton()
        Me.lblCongelarColunaApontamento = New System.Windows.Forms.Label()
        Me.cboCongelarColunaApontamento = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.pagNova = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvarOSNova = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarOS = New Janus.Windows.EditControls.UIButton()
        Me.txtObservacaoOSNova = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacaoOs = New System.Windows.Forms.Label()
        Me.grpRoteiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.grdRoteiro = New Janus.Windows.GridEX.GridEX()
        Me.btnExcluirRoteiro = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirRoteiro = New Janus.Windows.EditControls.UIButton()
        Me.txtObservacaoRoteiro = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarOperacao = New System.Windows.Forms.Button()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.cboCentroTrabalho = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarCentroTrabalho = New System.Windows.Forms.Button()
        Me.lblSequencia = New System.Windows.Forms.Label()
        Me.txtSequencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpOPNova = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLinhaPV = New System.Windows.Forms.Label()
        Me.cboLinhaPV = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPedidoVenda = New System.Windows.Forms.Label()
        Me.cboPedidoVenda = New Janus.Windows.EditControls.UIComboBox()
        Me.cboCentroCusto = New Janus.Windows.EditControls.UIComboBox()
        Me.txtOM = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOMItem = New System.Windows.Forms.Label()
        Me.txtRef = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblREF = New System.Windows.Forms.Label()
        Me.txtPlanta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlanta = New System.Windows.Forms.Label()
        Me.dtpDataEmissao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblCentroCusto = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.btnCadCentroCusto = New System.Windows.Forms.Button()
        Me.txtNumeroOSNova = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQtdPlanejadaNova = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQtdPlanejadaNova = New System.Windows.Forms.Label()
        Me.txtDescricaoNova = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaProducao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAguardandoEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagApontamento.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCusto.SuspendLayout()
        CType(Me.chrCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCustoMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCustoMO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        Me.pagNova.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grpRoteiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRoteiro.SuspendLayout()
        CType(Me.grdRoteiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOPNova, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOPNova.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1107, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados, Me.pagNova})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(1105, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Ordem de Serviço"
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
        Me.btnExcelGrid.TabIndex = 24
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 10
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
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
        Me.btnAgruparGrid.TabIndex = 9
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.Label7)
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.picLegendaConcluido)
        Me.grpLegenda.Controls.Add(Me.lblLegendaConcluido)
        Me.grpLegenda.Controls.Add(Me.picLegendaProducao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaProducao)
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoEstoque)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoEstoque)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(335, 51)
        Me.grpLegenda.TabIndex = 2
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(254, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 14)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Rejeitada"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Peru
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(235, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(145, 30)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaCancelado.TabIndex = 17
        Me.picLegendaCancelado.TabStop = False
        '
        'lblLegendaCancelado
        '
        Me.lblLegendaCancelado.AutoSize = True
        Me.lblLegendaCancelado.Location = New System.Drawing.Point(166, 30)
        Me.lblLegendaCancelado.Name = "lblLegendaCancelado"
        Me.lblLegendaCancelado.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelado.TabIndex = 16
        Me.lblLegendaCancelado.Text = "Cancelado"
        '
        'picLegendaConcluido
        '
        Me.picLegendaConcluido.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaConcluido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaConcluido.Location = New System.Drawing.Point(145, 13)
        Me.picLegendaConcluido.Name = "picLegendaConcluido"
        Me.picLegendaConcluido.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaConcluido.TabIndex = 11
        Me.picLegendaConcluido.TabStop = False
        '
        'lblLegendaConcluido
        '
        Me.lblLegendaConcluido.AutoSize = True
        Me.lblLegendaConcluido.Location = New System.Drawing.Point(166, 13)
        Me.lblLegendaConcluido.Name = "lblLegendaConcluido"
        Me.lblLegendaConcluido.Size = New System.Drawing.Size(54, 14)
        Me.lblLegendaConcluido.TabIndex = 0
        Me.lblLegendaConcluido.Text = "Concluída"
        '
        'picLegendaProducao
        '
        Me.picLegendaProducao.BackColor = System.Drawing.Color.DarkGray
        Me.picLegendaProducao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaProducao.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaProducao.Name = "picLegendaProducao"
        Me.picLegendaProducao.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaProducao.TabIndex = 13
        Me.picLegendaProducao.TabStop = False
        '
        'lblLegendaProducao
        '
        Me.lblLegendaProducao.AutoSize = True
        Me.lblLegendaProducao.Location = New System.Drawing.Point(30, 13)
        Me.lblLegendaProducao.Name = "lblLegendaProducao"
        Me.lblLegendaProducao.Size = New System.Drawing.Size(70, 14)
        Me.lblLegendaProducao.TabIndex = 1
        Me.lblLegendaProducao.Text = "Em Produção"
        '
        'picLegendaAguardandoEstoque
        '
        Me.picLegendaAguardandoEstoque.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaAguardandoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoEstoque.Location = New System.Drawing.Point(9, 30)
        Me.picLegendaAguardandoEstoque.Name = "picLegendaAguardandoEstoque"
        Me.picLegendaAguardandoEstoque.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaAguardandoEstoque.TabIndex = 19
        Me.picLegendaAguardandoEstoque.TabStop = False
        '
        'lblLegendaAguardandoEstoque
        '
        Me.lblLegendaAguardandoEstoque.AutoSize = True
        Me.lblLegendaAguardandoEstoque.Location = New System.Drawing.Point(30, 30)
        Me.lblLegendaAguardandoEstoque.Name = "lblLegendaAguardandoEstoque"
        Me.lblLegendaAguardandoEstoque.Size = New System.Drawing.Size(109, 14)
        Me.lblLegendaAguardandoEstoque.TabIndex = 18
        Me.lblLegendaAguardandoEstoque.Text = "Aguardando Estoque"
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1089, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtOMFiltro)
        Me.grpFiltro.Controls.Add(Me.LBLOMFiltro)
        Me.grpFiltro.Controls.Add(Me.txtREFFiltro)
        Me.grpFiltro.Controls.Add(Me.lblREFFiltro)
        Me.grpFiltro.Controls.Add(Me.txtPlantaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPlantaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtOrdemServicoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblOrdemProducaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1089, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtOMFiltro
        '
        Me.txtOMFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOMFiltro.Location = New System.Drawing.Point(259, 74)
        Me.txtOMFiltro.MaxLength = 20
        Me.txtOMFiltro.Name = "txtOMFiltro"
        Me.txtOMFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtOMFiltro.TabIndex = 52
        '
        'LBLOMFiltro
        '
        Me.LBLOMFiltro.AutoSize = True
        Me.LBLOMFiltro.Location = New System.Drawing.Point(256, 57)
        Me.LBLOMFiltro.Name = "LBLOMFiltro"
        Me.LBLOMFiltro.Size = New System.Drawing.Size(26, 14)
        Me.LBLOMFiltro.TabIndex = 51
        Me.LBLOMFiltro.Text = "OM:"
        '
        'txtREFFiltro
        '
        Me.txtREFFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtREFFiltro.Location = New System.Drawing.Point(145, 74)
        Me.txtREFFiltro.MaxLength = 20
        Me.txtREFFiltro.Name = "txtREFFiltro"
        Me.txtREFFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtREFFiltro.TabIndex = 50
        '
        'lblREFFiltro
        '
        Me.lblREFFiltro.AutoSize = True
        Me.lblREFFiltro.Location = New System.Drawing.Point(142, 57)
        Me.lblREFFiltro.Name = "lblREFFiltro"
        Me.lblREFFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblREFFiltro.TabIndex = 49
        Me.lblREFFiltro.Text = "REF:"
        '
        'txtPlantaFiltro
        '
        Me.txtPlantaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlantaFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtPlantaFiltro.MaxLength = 20
        Me.txtPlantaFiltro.Name = "txtPlantaFiltro"
        Me.txtPlantaFiltro.Size = New System.Drawing.Size(130, 20)
        Me.txtPlantaFiltro.TabIndex = 48
        '
        'lblPlantaFiltro
        '
        Me.lblPlantaFiltro.AutoSize = True
        Me.lblPlantaFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblPlantaFiltro.Name = "lblPlantaFiltro"
        Me.lblPlantaFiltro.Size = New System.Drawing.Size(39, 14)
        Me.lblPlantaFiltro.TabIndex = 47
        Me.lblPlantaFiltro.Text = "Planta:"
        '
        'lblTipoFiltro
        '
        Me.lblTipoFiltro.AutoSize = True
        Me.lblTipoFiltro.Location = New System.Drawing.Point(506, 16)
        Me.lblTipoFiltro.Name = "lblTipoFiltro"
        Me.lblTipoFiltro.Size = New System.Drawing.Size(30, 14)
        Me.lblTipoFiltro.TabIndex = 16
        Me.lblTipoFiltro.Text = "Tipo:"
        '
        'cboTipoFiltro
        '
        Me.cboTipoFiltro.AutoSize = False
        Me.cboTipoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboTipoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboTipoFiltro.Location = New System.Drawing.Point(509, 33)
        Me.cboTipoFiltro.Name = "cboTipoFiltro"
        Me.cboTipoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoFiltro.Size = New System.Drawing.Size(148, 20)
        Me.cboTipoFiltro.TabIndex = 17
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(373, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(284, 20)
        Me.cboStatusFiltro.TabIndex = 12
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(259, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 6
        Me.dtpDataTerminoFiltro.Value = New Date(2021, 2, 2, 0, 0, 0, 0)
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(145, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 5
        Me.dtpDataInicioFiltro.Value = New Date(2021, 2, 2, 0, 0, 0, 0)
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(370, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 11
        Me.lblStatusFiltro.Text = "Status:"
        '
        'lblDataInicioFiltro
        '
        Me.lblDataInicioFiltro.AutoSize = True
        Me.lblDataInicioFiltro.Location = New System.Drawing.Point(142, 17)
        Me.lblDataInicioFiltro.Name = "lblDataInicioFiltro"
        Me.lblDataInicioFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicioFiltro.TabIndex = 4
        Me.lblDataInicioFiltro.Text = "Data Início:"
        '
        'txtCodigoProdutoFiltro
        '
        Me.txtCodigoProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProdutoFiltro.Location = New System.Drawing.Point(373, 34)
        Me.txtCodigoProdutoFiltro.MaxLength = 60
        Me.txtCodigoProdutoFiltro.Name = "txtCodigoProdutoFiltro"
        Me.txtCodigoProdutoFiltro.Size = New System.Drawing.Size(130, 20)
        Me.txtCodigoProdutoFiltro.TabIndex = 10
        '
        'lblCodigoProdutoFiltro
        '
        Me.lblCodigoProdutoFiltro.AutoSize = True
        Me.lblCodigoProdutoFiltro.Location = New System.Drawing.Point(370, 17)
        Me.lblCodigoProdutoFiltro.Name = "lblCodigoProdutoFiltro"
        Me.lblCodigoProdutoFiltro.Size = New System.Drawing.Size(98, 14)
        Me.lblCodigoProdutoFiltro.TabIndex = 9
        Me.lblCodigoProdutoFiltro.Text = "Código do Produto:"
        '
        'txtOrdemServicoFiltro
        '
        Me.txtOrdemServicoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemServicoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemServicoFiltro.MaxLength = 20
        Me.txtOrdemServicoFiltro.Name = "txtOrdemServicoFiltro"
        Me.txtOrdemServicoFiltro.Size = New System.Drawing.Size(130, 20)
        Me.txtOrdemServicoFiltro.TabIndex = 1
        '
        'lblOrdemProducaoFiltro
        '
        Me.lblOrdemProducaoFiltro.AutoSize = True
        Me.lblOrdemProducaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducaoFiltro.Name = "lblOrdemProducaoFiltro"
        Me.lblOrdemProducaoFiltro.Size = New System.Drawing.Size(82, 14)
        Me.lblOrdemProducaoFiltro.TabIndex = 0
        Me.lblOrdemProducaoFiltro.Text = "Ordem Serviço:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(989, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 15
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Controls.Add(Me.btnGerarOrdemServico)
        Me.grpControl.Controls.Add(Me.btnImprimir)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(349, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(748, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExcluir.Location = New System.Drawing.Point(442, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(97, 23)
        Me.btnExcluir.TabIndex = 8
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.Visible = False
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnGerarOrdemServico
        '
        Me.btnGerarOrdemServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarOrdemServico.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnGerarOrdemServico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarOrdemServico.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnGerarOrdemServico.Location = New System.Drawing.Point(545, 17)
        Me.btnGerarOrdemServico.Name = "btnGerarOrdemServico"
        Me.btnGerarOrdemServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarOrdemServico.Size = New System.Drawing.Size(97, 23)
        Me.btnGerarOrdemServico.TabIndex = 6
        Me.btnGerarOrdemServico.Text = "Novo"
        Me.btnGerarOrdemServico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(329, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(107, 23)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Visible = False
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(648, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(1105, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Ordem de Produção"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.cboUsuario)
        Me.grpDados.Controls.Add(Me.lblUsuario)
        Me.grpDados.Controls.Add(Me.txtTempoEstimado)
        Me.grpDados.Controls.Add(Me.txtPercentualConcluido)
        Me.grpDados.Controls.Add(Me.txtOrdemProducaoOriginal)
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.txtQuantidadeProduzida)
        Me.grpDados.Controls.Add(Me.txtQuantidadeRejeito)
        Me.grpDados.Controls.Add(Me.txtQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.lblQuantidadeRejeito)
        Me.grpDados.Controls.Add(Me.lblTempoEstimado)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.lblQuantidadeProduzida)
        Me.grpDados.Controls.Add(Me.lblQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.lblPercentualConcluido)
        Me.grpDados.Controls.Add(Me.lblOrdemProducaoOriginal)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(1089, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'cboUsuario
        '
        Me.cboUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUsuario.AutoSize = False
        Me.cboUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUsuario.Location = New System.Drawing.Point(975, 34)
        Me.cboUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUsuario.Size = New System.Drawing.Size(108, 20)
        Me.cboUsuario.TabIndex = 17
        Me.cboUsuario.Visible = False
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(972, 17)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuario.TabIndex = 19
        Me.lblUsuario.Text = "Usuário:"
        Me.lblUsuario.Visible = False
        '
        'txtTempoEstimado
        '
        Me.txtTempoEstimado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTempoEstimado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTempoEstimado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTempoEstimado.Location = New System.Drawing.Point(560, 34)
        Me.txtTempoEstimado.MaxLength = 20
        Me.txtTempoEstimado.Name = "txtTempoEstimado"
        Me.txtTempoEstimado.ReadOnly = True
        Me.txtTempoEstimado.Size = New System.Drawing.Size(84, 20)
        Me.txtTempoEstimado.TabIndex = 7
        Me.txtTempoEstimado.TabStop = False
        '
        'txtPercentualConcluido
        '
        Me.txtPercentualConcluido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPercentualConcluido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPercentualConcluido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPercentualConcluido.Location = New System.Drawing.Point(650, 34)
        Me.txtPercentualConcluido.MaxLength = 20
        Me.txtPercentualConcluido.Name = "txtPercentualConcluido"
        Me.txtPercentualConcluido.ReadOnly = True
        Me.txtPercentualConcluido.Size = New System.Drawing.Size(67, 20)
        Me.txtPercentualConcluido.TabIndex = 9
        Me.txtPercentualConcluido.TabStop = False
        '
        'txtOrdemProducaoOriginal
        '
        Me.txtOrdemProducaoOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOrdemProducaoOriginal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducaoOriginal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducaoOriginal.Location = New System.Drawing.Point(424, 34)
        Me.txtOrdemProducaoOriginal.MaxLength = 20
        Me.txtOrdemProducaoOriginal.Name = "txtOrdemProducaoOriginal"
        Me.txtOrdemProducaoOriginal.ReadOnly = True
        Me.txtOrdemProducaoOriginal.Size = New System.Drawing.Size(130, 20)
        Me.txtOrdemProducaoOriginal.TabIndex = 5
        Me.txtOrdemProducaoOriginal.TabStop = False
        '
        'txtProduto
        '
        Me.txtProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(103, 34)
        Me.txtProduto.MaxLength = 60
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(315, 20)
        Me.txtProduto.TabIndex = 3
        Me.txtProduto.TabStop = False
        '
        'txtQuantidadeProduzida
        '
        Me.txtQuantidadeProduzida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeProduzida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeProduzida.DecimalDigits = 4
        Me.txtQuantidadeProduzida.Location = New System.Drawing.Point(885, 34)
        Me.txtQuantidadeProduzida.Name = "txtQuantidadeProduzida"
        Me.txtQuantidadeProduzida.ReadOnly = True
        Me.txtQuantidadeProduzida.Size = New System.Drawing.Size(84, 20)
        Me.txtQuantidadeProduzida.TabIndex = 15
        Me.txtQuantidadeProduzida.TabStop = False
        Me.txtQuantidadeProduzida.Text = "0,0000"
        Me.txtQuantidadeProduzida.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtQuantidadeRejeito
        '
        Me.txtQuantidadeRejeito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeRejeito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeRejeito.DecimalDigits = 4
        Me.txtQuantidadeRejeito.Location = New System.Drawing.Point(811, 34)
        Me.txtQuantidadeRejeito.Name = "txtQuantidadeRejeito"
        Me.txtQuantidadeRejeito.ReadOnly = True
        Me.txtQuantidadeRejeito.Size = New System.Drawing.Size(68, 20)
        Me.txtQuantidadeRejeito.TabIndex = 13
        Me.txtQuantidadeRejeito.TabStop = False
        Me.txtQuantidadeRejeito.Text = "0,0000"
        Me.txtQuantidadeRejeito.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtQuantidadePlanejada
        '
        Me.txtQuantidadePlanejada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadePlanejada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadePlanejada.DecimalDigits = 4
        Me.txtQuantidadePlanejada.Location = New System.Drawing.Point(723, 34)
        Me.txtQuantidadePlanejada.Name = "txtQuantidadePlanejada"
        Me.txtQuantidadePlanejada.ReadOnly = True
        Me.txtQuantidadePlanejada.Size = New System.Drawing.Size(82, 20)
        Me.txtQuantidadePlanejada.TabIndex = 11
        Me.txtQuantidadePlanejada.TabStop = False
        Me.txtQuantidadePlanejada.Text = "0,0000"
        Me.txtQuantidadePlanejada.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeRejeito
        '
        Me.lblQuantidadeRejeito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeRejeito.AutoSize = True
        Me.lblQuantidadeRejeito.Location = New System.Drawing.Point(808, 18)
        Me.lblQuantidadeRejeito.Name = "lblQuantidadeRejeito"
        Me.lblQuantidadeRejeito.Size = New System.Drawing.Size(71, 14)
        Me.lblQuantidadeRejeito.TabIndex = 12
        Me.lblQuantidadeRejeito.Text = "Qtde. Rejeito:"
        '
        'lblTempoEstimado
        '
        Me.lblTempoEstimado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTempoEstimado.AutoSize = True
        Me.lblTempoEstimado.Location = New System.Drawing.Point(557, 17)
        Me.lblTempoEstimado.Name = "lblTempoEstimado"
        Me.lblTempoEstimado.Size = New System.Drawing.Size(87, 14)
        Me.lblTempoEstimado.TabIndex = 6
        Me.lblTempoEstimado.Text = "Tempo Estimado:"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(100, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Produto:"
        '
        'lblQuantidadeProduzida
        '
        Me.lblQuantidadeProduzida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeProduzida.AutoSize = True
        Me.lblQuantidadeProduzida.Location = New System.Drawing.Point(882, 17)
        Me.lblQuantidadeProduzida.Name = "lblQuantidadeProduzida"
        Me.lblQuantidadeProduzida.Size = New System.Drawing.Size(87, 14)
        Me.lblQuantidadeProduzida.TabIndex = 14
        Me.lblQuantidadeProduzida.Text = "Qtde. Produzida:"
        '
        'lblQuantidadePlanejada
        '
        Me.lblQuantidadePlanejada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadePlanejada.AutoSize = True
        Me.lblQuantidadePlanejada.Location = New System.Drawing.Point(720, 17)
        Me.lblQuantidadePlanejada.Name = "lblQuantidadePlanejada"
        Me.lblQuantidadePlanejada.Size = New System.Drawing.Size(85, 14)
        Me.lblQuantidadePlanejada.TabIndex = 10
        Me.lblQuantidadePlanejada.Text = "Qtde. Planejada:"
        '
        'lblPercentualConcluido
        '
        Me.lblPercentualConcluido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPercentualConcluido.AutoSize = True
        Me.lblPercentualConcluido.Location = New System.Drawing.Point(647, 18)
        Me.lblPercentualConcluido.Name = "lblPercentualConcluido"
        Me.lblPercentualConcluido.Size = New System.Drawing.Size(70, 14)
        Me.lblPercentualConcluido.TabIndex = 8
        Me.lblPercentualConcluido.Text = "% Concluído:"
        '
        'lblOrdemProducaoOriginal
        '
        Me.lblOrdemProducaoOriginal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrdemProducaoOriginal.AutoSize = True
        Me.lblOrdemProducaoOriginal.Location = New System.Drawing.Point(421, 18)
        Me.lblOrdemProducaoOriginal.Name = "lblOrdemProducaoOriginal"
        Me.lblOrdemProducaoOriginal.Size = New System.Drawing.Size(130, 14)
        Me.lblOrdemProducaoOriginal.TabIndex = 4
        Me.lblOrdemProducaoOriginal.Text = "Ordem Produção Original:"
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducao.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemProducao.MaxLength = 20
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.Size = New System.Drawing.Size(88, 20)
        Me.txtOrdemProducao.TabIndex = 1
        Me.txtOrdemProducao.TabStop = False
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducao.TabIndex = 0
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 73)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(1089, 407)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagApontamento, Me.pagCusto})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagApontamento
        '
        Me.pagApontamento.Controls.Add(Me.btnConfigurarGridApontamento)
        Me.pagApontamento.Controls.Add(Me.btnAgruparGridApontamento)
        Me.pagApontamento.Controls.Add(Me.txtObservacao)
        Me.pagApontamento.Controls.Add(Me.lblObervacao)
        Me.pagApontamento.Controls.Add(Me.grdApontamento)
        Me.pagApontamento.Key = "pagApontamento"
        Me.pagApontamento.Location = New System.Drawing.Point(1, 22)
        Me.pagApontamento.Name = "pagApontamento"
        Me.pagApontamento.Size = New System.Drawing.Size(1087, 384)
        Me.pagApontamento.TabStop = True
        Me.pagApontamento.Text = "Apontamento"
        '
        'btnConfigurarGridApontamento
        '
        Me.btnConfigurarGridApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridApontamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridApontamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridApontamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridApontamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridApontamento.Location = New System.Drawing.Point(9, 258)
        Me.btnConfigurarGridApontamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridApontamento.Name = "btnConfigurarGridApontamento"
        Me.btnConfigurarGridApontamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridApontamento.TabIndex = 12
        Me.btnConfigurarGridApontamento.TabStop = False
        Me.btnConfigurarGridApontamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridApontamento
        '
        Me.btnAgruparGridApontamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridApontamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridApontamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridApontamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridApontamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridApontamento.Location = New System.Drawing.Point(33, 258)
        Me.btnAgruparGridApontamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridApontamento.Name = "btnAgruparGridApontamento"
        Me.btnAgruparGridApontamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridApontamento.TabIndex = 11
        Me.btnAgruparGridApontamento.TabStop = False
        Me.btnAgruparGridApontamento.UseVisualStyleBackColor = False
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(8, 296)
        Me.txtObservacao.MaxLength = 5000
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(1071, 79)
        Me.txtObservacao.TabIndex = 2
        '
        'lblObervacao
        '
        Me.lblObervacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblObervacao.AutoSize = True
        Me.lblObervacao.Location = New System.Drawing.Point(5, 279)
        Me.lblObervacao.Name = "lblObervacao"
        Me.lblObervacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObervacao.TabIndex = 1
        Me.lblObervacao.Text = "Observação:"
        '
        'grdApontamento
        '
        Me.grdApontamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdApontamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdApontamento_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_1.Instance"), Object)
        grdApontamento_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_2.Instance"), Object)
        grdApontamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdApontamento_DesignTimeLayout_Reference_0, grdApontamento_DesignTimeLayout_Reference_1, grdApontamento_DesignTimeLayout_Reference_2})
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamento.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.FrozenColumns = 2
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.Location = New System.Drawing.Point(8, 9)
        Me.grdApontamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.RecordNavigator = True
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(1071, 266)
        Me.grdApontamento.TabIndex = 0
        Me.grdApontamento.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
        '
        'pagCusto
        '
        Me.pagCusto.Controls.Add(Me.btnExcelGridMP)
        Me.pagCusto.Controls.Add(Me.btnExcelGridMO)
        Me.pagCusto.Controls.Add(Me.chrCusto)
        Me.pagCusto.Controls.Add(Me.grdCustoMP)
        Me.pagCusto.Controls.Add(Me.grdCustoMO)
        Me.pagCusto.Key = "pagCusto"
        Me.pagCusto.Location = New System.Drawing.Point(1, 22)
        Me.pagCusto.Name = "pagCusto"
        Me.pagCusto.Size = New System.Drawing.Size(1087, 384)
        Me.pagCusto.TabStop = True
        Me.pagCusto.Text = "Margem de Contribuição"
        '
        'btnExcelGridMP
        '
        Me.btnExcelGridMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridMP.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridMP.FlatAppearance.BorderSize = 0
        Me.btnExcelGridMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridMP.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridMP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridMP.Location = New System.Drawing.Point(9, 358)
        Me.btnExcelGridMP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridMP.Name = "btnExcelGridMP"
        Me.btnExcelGridMP.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridMP.TabIndex = 26
        Me.btnExcelGridMP.TabStop = False
        Me.btnExcelGridMP.UseVisualStyleBackColor = False
        '
        'btnExcelGridMO
        '
        Me.btnExcelGridMO.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridMO.FlatAppearance.BorderSize = 0
        Me.btnExcelGridMO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridMO.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridMO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridMO.Location = New System.Drawing.Point(9, 170)
        Me.btnExcelGridMO.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridMO.Name = "btnExcelGridMO"
        Me.btnExcelGridMO.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridMO.TabIndex = 25
        Me.btnExcelGridMO.TabStop = False
        Me.btnExcelGridMO.UseVisualStyleBackColor = False
        '
        'chrCusto
        '
        Me.chrCusto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrCusto.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrCusto.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrCusto.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.Title = "Força (gf)"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Velocidade"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrCusto.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Default"
        Me.chrCusto.Legends.Add(Legend1)
        Me.chrCusto.Location = New System.Drawing.Point(711, 9)
        Me.chrCusto.Name = "chrCusto"
        Me.chrCusto.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrCusto.Size = New System.Drawing.Size(368, 366)
        Me.chrCusto.TabIndex = 3
        Title1.Name = "Title1"
        Me.chrCusto.Titles.Add(Title1)
        Me.chrCusto.UI.Toolbar.Enabled = True
        '
        'grdCustoMP
        '
        Me.grdCustoMP.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdCustoMP.AlternatingColors = True
        Me.grdCustoMP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdCustoMP_DesignTimeLayout.LayoutString = resources.GetString("grdCustoMP_DesignTimeLayout.LayoutString")
        Me.grdCustoMP.DesignTimeLayout = grdCustoMP_DesignTimeLayout
        Me.grdCustoMP.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdCustoMP.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCustoMP.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCustoMP.FrozenColumns = 3
        Me.grdCustoMP.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCustoMP.GroupByBoxVisible = False
        Me.grdCustoMP.Location = New System.Drawing.Point(8, 195)
        Me.grdCustoMP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdCustoMP.Name = "grdCustoMP"
        Me.grdCustoMP.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCustoMP.RecordNavigator = True
        Me.grdCustoMP.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdCustoMP.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCustoMP.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCustoMP.Size = New System.Drawing.Size(695, 180)
        Me.grdCustoMP.TabIndex = 2
        Me.grdCustoMP.TableHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grdCustoMP.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCustoMP.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCustoMP.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCustoMP.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCustoMP.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdCustoMP.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCustoMP.VisualStyleManager = Me.vsmMain
        '
        'grdCustoMO
        '
        Me.grdCustoMO.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdCustoMO.AlternatingColors = True
        Me.grdCustoMO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdCustoMO_DesignTimeLayout.LayoutString = resources.GetString("grdCustoMO_DesignTimeLayout.LayoutString")
        Me.grdCustoMO.DesignTimeLayout = grdCustoMO_DesignTimeLayout
        Me.grdCustoMO.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdCustoMO.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCustoMO.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCustoMO.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCustoMO.GroupByBoxVisible = False
        Me.grdCustoMO.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdCustoMO.Location = New System.Drawing.Point(8, 9)
        Me.grdCustoMO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdCustoMO.Name = "grdCustoMO"
        Me.grdCustoMO.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCustoMO.RecordNavigator = True
        Me.grdCustoMO.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCustoMO.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCustoMO.Size = New System.Drawing.Size(695, 178)
        Me.grdCustoMO.TabIndex = 1
        Me.grdCustoMO.TableHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grdCustoMO.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCustoMO.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCustoMO.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCustoMO.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCustoMO.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdCustoMO.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCustoMO.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnAtualizar)
        Me.grpControl2.Controls.Add(Me.lblCongelarColunaApontamento)
        Me.grpControl2.Controls.Add(Me.cboCongelarColunaApontamento)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 483)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(1089, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAtualizar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizar.Location = New System.Drawing.Point(795, 17)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizar.Size = New System.Drawing.Size(91, 23)
        Me.btnAtualizar.TabIndex = 2
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCongelarColunaApontamento
        '
        Me.lblCongelarColunaApontamento.AutoSize = True
        Me.lblCongelarColunaApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColunaApontamento.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColunaApontamento.Name = "lblCongelarColunaApontamento"
        Me.lblCongelarColunaApontamento.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColunaApontamento.TabIndex = 0
        Me.lblCongelarColunaApontamento.Text = "Congelar Coluna:"
        '
        'cboCongelarColunaApontamento
        '
        Me.cboCongelarColunaApontamento.AutoSize = False
        Me.cboCongelarColunaApontamento.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColunaApontamento.Name = "cboCongelarColunaApontamento"
        Me.cboCongelarColunaApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColunaApontamento.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColunaApontamento.TabIndex = 1
        Me.cboCongelarColunaApontamento.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(892, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(989, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 4
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagNova
        '
        Me.pagNova.Controls.Add(Me.UiGroupBox2)
        Me.pagNova.Controls.Add(Me.txtObservacaoOSNova)
        Me.pagNova.Controls.Add(Me.lblObservacaoOs)
        Me.pagNova.Controls.Add(Me.grpRoteiro)
        Me.pagNova.Controls.Add(Me.grpOPNova)
        Me.pagNova.Location = New System.Drawing.Point(1, 22)
        Me.pagNova.Name = "pagNova"
        Me.pagNova.Size = New System.Drawing.Size(1105, 543)
        Me.pagNova.TabStop = True
        Me.pagNova.Text = "Ordem de Serviço"
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnSalvarOSNova)
        Me.UiGroupBox2.Controls.Add(Me.btnVoltarOS)
        Me.UiGroupBox2.Location = New System.Drawing.Point(11, 483)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(1079, 51)
        Me.UiGroupBox2.TabIndex = 24
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvarOSNova
        '
        Me.btnSalvarOSNova.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarOSNova.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarOSNova.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarOSNova.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarOSNova.Location = New System.Drawing.Point(882, 17)
        Me.btnSalvarOSNova.Name = "btnSalvarOSNova"
        Me.btnSalvarOSNova.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarOSNova.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvarOSNova.TabIndex = 1
        Me.btnSalvarOSNova.Text = "Salvar"
        Me.btnSalvarOSNova.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarOS
        '
        Me.btnVoltarOS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarOS.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltarOS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarOS.Location = New System.Drawing.Point(979, 17)
        Me.btnVoltarOS.Name = "btnVoltarOS"
        Me.btnVoltarOS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarOS.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltarOS.TabIndex = 2
        Me.btnVoltarOS.Text = "Voltar"
        Me.btnVoltarOS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtObservacaoOSNova
        '
        Me.txtObservacaoOSNova.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoOSNova.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoOSNova.Location = New System.Drawing.Point(11, 426)
        Me.txtObservacaoOSNova.MaxLength = 5000
        Me.txtObservacaoOSNova.Multiline = True
        Me.txtObservacaoOSNova.Name = "txtObservacaoOSNova"
        Me.txtObservacaoOSNova.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacaoOSNova.Size = New System.Drawing.Size(1079, 54)
        Me.txtObservacaoOSNova.TabIndex = 23
        '
        'lblObservacaoOs
        '
        Me.lblObservacaoOs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblObservacaoOs.AutoSize = True
        Me.lblObservacaoOs.Location = New System.Drawing.Point(8, 409)
        Me.lblObservacaoOs.Name = "lblObservacaoOs"
        Me.lblObservacaoOs.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacaoOs.TabIndex = 22
        Me.lblObservacaoOs.Text = "Observação:"
        '
        'grpRoteiro
        '
        Me.grpRoteiro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.grpRoteiro.Controls.Add(Me.grdRoteiro)
        Me.grpRoteiro.Controls.Add(Me.btnExcluirRoteiro)
        Me.grpRoteiro.Controls.Add(Me.btnInserirRoteiro)
        Me.grpRoteiro.Controls.Add(Me.txtObservacaoRoteiro)
        Me.grpRoteiro.Controls.Add(Me.lblObservacao)
        Me.grpRoteiro.Controls.Add(Me.lblOperacao)
        Me.grpRoteiro.Controls.Add(Me.cboOperacao)
        Me.grpRoteiro.Controls.Add(Me.btnCadastrarOperacao)
        Me.grpRoteiro.Controls.Add(Me.lblCentroTrabalho)
        Me.grpRoteiro.Controls.Add(Me.cboCentroTrabalho)
        Me.grpRoteiro.Controls.Add(Me.btnCadastrarCentroTrabalho)
        Me.grpRoteiro.Controls.Add(Me.lblSequencia)
        Me.grpRoteiro.Controls.Add(Me.txtSequencia)
        Me.grpRoteiro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpRoteiro.Location = New System.Drawing.Point(8, 119)
        Me.grpRoteiro.Name = "grpRoteiro"
        Me.grpRoteiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpRoteiro.Size = New System.Drawing.Size(1082, 285)
        Me.grpRoteiro.TabIndex = 0
        Me.grpRoteiro.Text = "Dados do Roteiro"
        Me.grpRoteiro.VisualStyleManager = Me.vsmMain
        '
        'grdRoteiro
        '
        Me.grdRoteiro.AlternatingColors = True
        Me.grdRoteiro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdRoteiro_DesignTimeLayout.LayoutString = resources.GetString("grdRoteiro_DesignTimeLayout.LayoutString")
        Me.grdRoteiro.DesignTimeLayout = grdRoteiro_DesignTimeLayout
        Me.grdRoteiro.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRoteiro.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRoteiro.FrozenColumns = 2
        Me.grdRoteiro.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRoteiro.GroupByBoxVisible = False
        Me.grdRoteiro.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRoteiro.Location = New System.Drawing.Point(11, 102)
        Me.grdRoteiro.Name = "grdRoteiro"
        Me.grdRoteiro.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRoteiro.RecordNavigator = True
        Me.grdRoteiro.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRoteiro.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRoteiro.Size = New System.Drawing.Size(1058, 170)
        Me.grdRoteiro.TabIndex = 35
        Me.grdRoteiro.TabStop = False
        Me.grdRoteiro.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRoteiro.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRoteiro.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRoteiro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRoteiro.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirRoteiro
        '
        Me.btnExcluirRoteiro.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExcluirRoteiro.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirRoteiro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirRoteiro.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirRoteiro.Location = New System.Drawing.Point(978, 65)
        Me.btnExcluirRoteiro.Name = "btnExcluirRoteiro"
        Me.btnExcluirRoteiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirRoteiro.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirRoteiro.TabIndex = 11
        Me.btnExcluirRoteiro.Text = "Excluir"
        Me.btnExcluirRoteiro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirRoteiro
        '
        Me.btnInserirRoteiro.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnInserirRoteiro.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirRoteiro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirRoteiro.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirRoteiro.Location = New System.Drawing.Point(978, 36)
        Me.btnInserirRoteiro.Name = "btnInserirRoteiro"
        Me.btnInserirRoteiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirRoteiro.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirRoteiro.TabIndex = 10
        Me.btnInserirRoteiro.Text = "Inserir"
        Me.btnInserirRoteiro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtObservacaoRoteiro
        '
        Me.txtObservacaoRoteiro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoRoteiro.Location = New System.Drawing.Point(555, 36)
        Me.txtObservacaoRoteiro.MaxLength = 500
        Me.txtObservacaoRoteiro.Multiline = True
        Me.txtObservacaoRoteiro.Name = "txtObservacaoRoteiro"
        Me.txtObservacaoRoteiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacaoRoteiro.Size = New System.Drawing.Size(417, 60)
        Me.txtObservacaoRoteiro.TabIndex = 9
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObservacao.Location = New System.Drawing.Point(552, 19)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 8
        Me.lblObservacao.Text = "Observação:"
        '
        'lblOperacao
        '
        Me.lblOperacao.AutoSize = True
        Me.lblOperacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOperacao.Location = New System.Drawing.Point(27, 59)
        Me.lblOperacao.Name = "lblOperacao"
        Me.lblOperacao.Size = New System.Drawing.Size(58, 14)
        Me.lblOperacao.TabIndex = 6
        Me.lblOperacao.Text = "Operação:"
        '
        'cboOperacao
        '
        Me.cboOperacao.Location = New System.Drawing.Point(11, 76)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Size = New System.Drawing.Size(538, 20)
        Me.cboOperacao.TabIndex = 7
        '
        'btnCadastrarOperacao
        '
        Me.btnCadastrarOperacao.FlatAppearance.BorderSize = 0
        Me.btnCadastrarOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarOperacao.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarOperacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarOperacao.Location = New System.Drawing.Point(11, 60)
        Me.btnCadastrarOperacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarOperacao.Name = "btnCadastrarOperacao"
        Me.btnCadastrarOperacao.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarOperacao.TabIndex = 5
        Me.btnCadastrarOperacao.TabStop = False
        Me.btnCadastrarOperacao.UseVisualStyleBackColor = True
        '
        'lblCentroTrabalho
        '
        Me.lblCentroTrabalho.AutoSize = True
        Me.lblCentroTrabalho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCentroTrabalho.Location = New System.Drawing.Point(137, 19)
        Me.lblCentroTrabalho.Name = "lblCentroTrabalho"
        Me.lblCentroTrabalho.Size = New System.Drawing.Size(102, 14)
        Me.lblCentroTrabalho.TabIndex = 3
        Me.lblCentroTrabalho.Text = "Centro de Trabalho:"
        '
        'cboCentroTrabalho
        '
        Me.cboCentroTrabalho.Location = New System.Drawing.Point(121, 36)
        Me.cboCentroTrabalho.Name = "cboCentroTrabalho"
        Me.cboCentroTrabalho.Size = New System.Drawing.Size(428, 20)
        Me.cboCentroTrabalho.TabIndex = 4
        '
        'btnCadastrarCentroTrabalho
        '
        Me.btnCadastrarCentroTrabalho.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroTrabalho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroTrabalho.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroTrabalho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroTrabalho.Location = New System.Drawing.Point(121, 20)
        Me.btnCadastrarCentroTrabalho.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroTrabalho.Name = "btnCadastrarCentroTrabalho"
        Me.btnCadastrarCentroTrabalho.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroTrabalho.TabIndex = 2
        Me.btnCadastrarCentroTrabalho.TabStop = False
        Me.btnCadastrarCentroTrabalho.UseVisualStyleBackColor = True
        '
        'lblSequencia
        '
        Me.lblSequencia.AutoSize = True
        Me.lblSequencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSequencia.Location = New System.Drawing.Point(8, 19)
        Me.lblSequencia.Name = "lblSequencia"
        Me.lblSequencia.Size = New System.Drawing.Size(61, 14)
        Me.lblSequencia.TabIndex = 0
        Me.lblSequencia.Text = "Sequência:"
        '
        'txtSequencia
        '
        Me.txtSequencia.DecimalDigits = 0
        Me.txtSequencia.Location = New System.Drawing.Point(11, 36)
        Me.txtSequencia.Name = "txtSequencia"
        Me.txtSequencia.Size = New System.Drawing.Size(104, 20)
        Me.txtSequencia.TabIndex = 1
        Me.txtSequencia.Text = "0"
        Me.txtSequencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtSequencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpOPNova
        '
        Me.grpOPNova.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOPNova.BackColor = System.Drawing.Color.Transparent
        Me.grpOPNova.Controls.Add(Me.lblLinhaPV)
        Me.grpOPNova.Controls.Add(Me.cboLinhaPV)
        Me.grpOPNova.Controls.Add(Me.lblPedidoVenda)
        Me.grpOPNova.Controls.Add(Me.cboPedidoVenda)
        Me.grpOPNova.Controls.Add(Me.cboCentroCusto)
        Me.grpOPNova.Controls.Add(Me.txtOM)
        Me.grpOPNova.Controls.Add(Me.lblOMItem)
        Me.grpOPNova.Controls.Add(Me.txtRef)
        Me.grpOPNova.Controls.Add(Me.lblREF)
        Me.grpOPNova.Controls.Add(Me.txtPlanta)
        Me.grpOPNova.Controls.Add(Me.lblPlanta)
        Me.grpOPNova.Controls.Add(Me.dtpDataEmissao)
        Me.grpOPNova.Controls.Add(Me.lblData)
        Me.grpOPNova.Controls.Add(Me.lblCentroCusto)
        Me.grpOPNova.Controls.Add(Me.lblTipo)
        Me.grpOPNova.Controls.Add(Me.btnCadCentroCusto)
        Me.grpOPNova.Controls.Add(Me.txtNumeroOSNova)
        Me.grpOPNova.Controls.Add(Me.Label3)
        Me.grpOPNova.Controls.Add(Me.cboTipo)
        Me.grpOPNova.Controls.Add(Me.txtQtdPlanejadaNova)
        Me.grpOPNova.Controls.Add(Me.lblQtdPlanejadaNova)
        Me.grpOPNova.Controls.Add(Me.txtDescricaoNova)
        Me.grpOPNova.Controls.Add(Me.lblDescricao)
        Me.grpOPNova.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpOPNova.Location = New System.Drawing.Point(8, 5)
        Me.grpOPNova.Name = "grpOPNova"
        Me.grpOPNova.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOPNova.Size = New System.Drawing.Size(1082, 108)
        Me.grpOPNova.TabIndex = 1
        Me.grpOPNova.Text = "Dados Gerais"
        Me.grpOPNova.VisualStyleManager = Me.vsmMain
        '
        'lblLinhaPV
        '
        Me.lblLinhaPV.AutoSize = True
        Me.lblLinhaPV.Location = New System.Drawing.Point(263, 16)
        Me.lblLinhaPV.Name = "lblLinhaPV"
        Me.lblLinhaPV.Size = New System.Drawing.Size(36, 14)
        Me.lblLinhaPV.TabIndex = 50
        Me.lblLinhaPV.Text = "Linha:"
        '
        'cboLinhaPV
        '
        Me.cboLinhaPV.AutoSize = False
        Me.cboLinhaPV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLinhaPV.Location = New System.Drawing.Point(266, 33)
        Me.cboLinhaPV.Name = "cboLinhaPV"
        Me.cboLinhaPV.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLinhaPV.Size = New System.Drawing.Size(127, 20)
        Me.cboLinhaPV.TabIndex = 51
        '
        'lblPedidoVenda
        '
        Me.lblPedidoVenda.AutoSize = True
        Me.lblPedidoVenda.Location = New System.Drawing.Point(137, 17)
        Me.lblPedidoVenda.Name = "lblPedidoVenda"
        Me.lblPedidoVenda.Size = New System.Drawing.Size(91, 14)
        Me.lblPedidoVenda.TabIndex = 48
        Me.lblPedidoVenda.Text = "Pedido de Venda:"
        '
        'cboPedidoVenda
        '
        Me.cboPedidoVenda.AutoSize = False
        Me.cboPedidoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPedidoVenda.Location = New System.Drawing.Point(140, 34)
        Me.cboPedidoVenda.Name = "cboPedidoVenda"
        Me.cboPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPedidoVenda.Size = New System.Drawing.Size(120, 20)
        Me.cboPedidoVenda.TabIndex = 49
        '
        'cboCentroCusto
        '
        Me.cboCentroCusto.AutoSize = False
        Me.cboCentroCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboCentroCusto.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboCentroCusto.Location = New System.Drawing.Point(266, 74)
        Me.cboCentroCusto.Name = "cboCentroCusto"
        Me.cboCentroCusto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroCusto.Size = New System.Drawing.Size(326, 20)
        Me.cboCentroCusto.TabIndex = 47
        '
        'txtOM
        '
        Me.txtOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOM.Location = New System.Drawing.Point(851, 74)
        Me.txtOM.MaxLength = 20
        Me.txtOM.Name = "txtOM"
        Me.txtOM.Size = New System.Drawing.Size(121, 20)
        Me.txtOM.TabIndex = 46
        '
        'lblOMItem
        '
        Me.lblOMItem.AutoSize = True
        Me.lblOMItem.Location = New System.Drawing.Point(848, 57)
        Me.lblOMItem.Name = "lblOMItem"
        Me.lblOMItem.Size = New System.Drawing.Size(26, 14)
        Me.lblOMItem.TabIndex = 45
        Me.lblOMItem.Text = "OM:"
        '
        'txtRef
        '
        Me.txtRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRef.Location = New System.Drawing.Point(725, 74)
        Me.txtRef.MaxLength = 20
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(121, 20)
        Me.txtRef.TabIndex = 44
        '
        'lblREF
        '
        Me.lblREF.AutoSize = True
        Me.lblREF.Location = New System.Drawing.Point(722, 57)
        Me.lblREF.Name = "lblREF"
        Me.lblREF.Size = New System.Drawing.Size(29, 14)
        Me.lblREF.TabIndex = 43
        Me.lblREF.Text = "REF:"
        '
        'txtPlanta
        '
        Me.txtPlanta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlanta.Location = New System.Drawing.Point(598, 74)
        Me.txtPlanta.MaxLength = 20
        Me.txtPlanta.Name = "txtPlanta"
        Me.txtPlanta.Size = New System.Drawing.Size(121, 20)
        Me.txtPlanta.TabIndex = 42
        '
        'lblPlanta
        '
        Me.lblPlanta.AutoSize = True
        Me.lblPlanta.Location = New System.Drawing.Point(595, 57)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(39, 14)
        Me.lblPlanta.TabIndex = 41
        Me.lblPlanta.Text = "Planta:"
        '
        'dtpDataEmissao
        '
        '
        '
        '
        Me.dtpDataEmissao.DropDownCalendar.Name = ""
        Me.dtpDataEmissao.Location = New System.Drawing.Point(399, 33)
        Me.dtpDataEmissao.Name = "dtpDataEmissao"
        Me.dtpDataEmissao.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissao.TabIndex = 40
        Me.dtpDataEmissao.Value = New Date(2021, 2, 2, 0, 0, 0, 0)
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(396, 16)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 39
        Me.lblData.Text = "Data:"
        '
        'lblCentroCusto
        '
        Me.lblCentroCusto.AutoSize = True
        Me.lblCentroCusto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCentroCusto.Location = New System.Drawing.Point(281, 58)
        Me.lblCentroCusto.Name = "lblCentroCusto"
        Me.lblCentroCusto.Size = New System.Drawing.Size(88, 14)
        Me.lblCentroCusto.TabIndex = 37
        Me.lblCentroCusto.Text = "Centro de Custo:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(5, 57)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 12
        Me.lblTipo.Text = "Tipo:"
        '
        'btnCadCentroCusto
        '
        Me.btnCadCentroCusto.FlatAppearance.BorderSize = 0
        Me.btnCadCentroCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadCentroCusto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadCentroCusto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadCentroCusto.Location = New System.Drawing.Point(266, 58)
        Me.btnCadCentroCusto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadCentroCusto.Name = "btnCadCentroCusto"
        Me.btnCadCentroCusto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadCentroCusto.TabIndex = 36
        Me.btnCadCentroCusto.TabStop = False
        Me.btnCadCentroCusto.UseVisualStyleBackColor = True
        '
        'txtNumeroOSNova
        '
        Me.txtNumeroOSNova.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroOSNova.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOSNova.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroOSNova.Location = New System.Drawing.Point(8, 34)
        Me.txtNumeroOSNova.MaxLength = 20
        Me.txtNumeroOSNova.Name = "txtNumeroOSNova"
        Me.txtNumeroOSNova.ReadOnly = True
        Me.txtNumeroOSNova.Size = New System.Drawing.Size(126, 20)
        Me.txtNumeroOSNova.TabIndex = 1
        Me.txtNumeroOSNova.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ordem Serviço:"
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboTipo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboTipo.Location = New System.Drawing.Point(8, 74)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(126, 20)
        Me.cboTipo.TabIndex = 13
        '
        'txtQtdPlanejadaNova
        '
        Me.txtQtdPlanejadaNova.DecimalDigits = 4
        Me.txtQtdPlanejadaNova.Location = New System.Drawing.Point(140, 74)
        Me.txtQtdPlanejadaNova.Name = "txtQtdPlanejadaNova"
        Me.txtQtdPlanejadaNova.Size = New System.Drawing.Size(120, 20)
        Me.txtQtdPlanejadaNova.TabIndex = 9
        Me.txtQtdPlanejadaNova.Text = "0,0000"
        Me.txtQtdPlanejadaNova.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQtdPlanejadaNova
        '
        Me.lblQtdPlanejadaNova.AutoSize = True
        Me.lblQtdPlanejadaNova.Location = New System.Drawing.Point(137, 57)
        Me.lblQtdPlanejadaNova.Name = "lblQtdPlanejadaNova"
        Me.lblQtdPlanejadaNova.Size = New System.Drawing.Size(65, 14)
        Me.lblQtdPlanejadaNova.TabIndex = 8
        Me.lblQtdPlanejadaNova.Text = "Quantidade:"
        '
        'txtDescricaoNova
        '
        Me.txtDescricaoNova.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoNova.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoNova.Location = New System.Drawing.Point(513, 33)
        Me.txtDescricaoNova.MaxLength = 50
        Me.txtDescricaoNova.Name = "txtDescricaoNova"
        Me.txtDescricaoNova.ReadOnly = True
        Me.txtDescricaoNova.Size = New System.Drawing.Size(459, 20)
        Me.txtDescricaoNova.TabIndex = 7
        Me.txtDescricaoNova.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(510, 16)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 6
        Me.lblDescricao.Text = "Descrição:"
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 22)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(980, 384)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Edição"
        '
        'usrPrdOrdemServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdOrdemServico"
        Me.Size = New System.Drawing.Size(1107, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaProducao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAguardandoEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagApontamento.ResumeLayout(False)
        Me.pagApontamento.PerformLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCusto.ResumeLayout(False)
        CType(Me.chrCusto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCustoMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCustoMO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.grpControl2.PerformLayout()
        Me.pagNova.ResumeLayout(False)
        Me.pagNova.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.grpRoteiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRoteiro.ResumeLayout(False)
        Me.grpRoteiro.PerformLayout()
        CType(Me.grdRoteiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOPNova, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOPNova.ResumeLayout(False)
        Me.grpOPNova.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtOrdemServicoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtCodigoProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataInicioFiltro As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagApontamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblQuantidadeProduzida As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadePlanejada As System.Windows.Forms.Label
    Friend WithEvents lblPercentualConcluido As System.Windows.Forms.Label
    Friend WithEvents lblOrdemProducaoOriginal As System.Windows.Forms.Label
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblQuantidadeRejeito As System.Windows.Forms.Label
    Friend WithEvents lblTempoEstimado As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeProduzida As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadeRejeito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadePlanejada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtTempoEstimado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtPercentualConcluido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtOrdemProducaoOriginal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelado As System.Windows.Forms.Label
    Friend WithEvents picLegendaProducao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaProducao As System.Windows.Forms.Label
    Friend WithEvents picLegendaConcluido As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaConcluido As System.Windows.Forms.Label
    Friend WithEvents picLegendaAguardandoEstoque As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAguardandoEstoque As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObervacao As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagCusto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdCustoMP As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdCustoMO As Janus.Windows.GridEX.GridEX
    Friend WithEvents chrCusto As Dundas.Charting.WinControl.Chart
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridApontamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridApontamento As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColunaApontamento As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColunaApontamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAtualizar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridMP As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridMO As System.Windows.Forms.Button
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents cboUsuario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnGerarOrdemServico As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagNova As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpOPNova As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblQtdPlanejadaNova As System.Windows.Forms.Label
    Friend WithEvents txtQtdPlanejadaNova As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtDescricaoNova As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents grpRoteiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtNumeroOSNova As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSequencia As System.Windows.Forms.Label
    Friend WithEvents txtSequencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCentroTrabalho As System.Windows.Forms.Label
    Friend WithEvents cboCentroTrabalho As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarCentroTrabalho As System.Windows.Forms.Button
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarOperacao As System.Windows.Forms.Button
    Friend WithEvents txtObservacaoRoteiro As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents btnExcluirRoteiro As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirRoteiro As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdRoteiro As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSalvarOSNova As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltarOS As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtObservacaoOSNova As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacaoOs As System.Windows.Forms.Label
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCentroCusto As System.Windows.Forms.Label
    Friend WithEvents UiComboBox1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadCentroCusto As System.Windows.Forms.Button
    Friend WithEvents dtpDataEmissao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtPlanta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlanta As System.Windows.Forms.Label
    Friend WithEvents txtRef As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblREF As System.Windows.Forms.Label
    Friend WithEvents txtOMFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents LBLOMFiltro As System.Windows.Forms.Label
    Friend WithEvents txtREFFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblREFFiltro As System.Windows.Forms.Label
    Friend WithEvents txtPlantaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlantaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtOM As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOMItem As System.Windows.Forms.Label
    Friend WithEvents cboCentroCusto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLinhaPV As System.Windows.Forms.Label
    Friend WithEvents cboLinhaPV As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents cboPedidoVenda As Janus.Windows.EditControls.UIComboBox

End Class
