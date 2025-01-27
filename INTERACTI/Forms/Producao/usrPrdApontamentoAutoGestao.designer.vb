<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdApontamentoAutoGestao
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdApontamentoAutoGestao))
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series2 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title2 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosOrdemProducao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblOrdemProducaoLabel = New System.Windows.Forms.Label()
        Me.lblOrdemProducaoValor = New System.Windows.Forms.Label()
        Me.lblCodigoProdutoValor = New System.Windows.Forms.Label()
        Me.lblTipoApontamentoLabel = New System.Windows.Forms.Label()
        Me.lblCodigoProdutoLabel = New System.Windows.Forms.Label()
        Me.lblQuantidadeRejeitoLabel = New System.Windows.Forms.Label()
        Me.lblTipoApontamentoValor = New System.Windows.Forms.Label()
        Me.lblQuantidadeRejeitoValor = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpApontamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboEquipamento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.cboOPOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.cboTipoApontamento = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarMotivoParada = New System.Windows.Forms.Button()
        Me.cboMotivoParada = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMotivoParada = New System.Windows.Forms.Label()
        Me.txtQuantidadeAbertura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeAbertura = New System.Windows.Forms.Label()
        Me.txtQuantidadeProduzida = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadePlanejada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeProduzida = New System.Windows.Forms.Label()
        Me.lblQuantidadePlanejada = New System.Windows.Forms.Label()
        Me.lblEquipamento = New System.Windows.Forms.Label()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.lblOPOperacao = New System.Windows.Forms.Label()
        Me.lblTipoApontamento = New System.Windows.Forms.Label()
        Me.grpControlFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.lblInformativo = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagIndicadores = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrIndicadorPeriodo = New Dundas.Charting.WinControl.Chart()
        Me.chrIndicadorAtual = New Dundas.Charting.WinControl.Chart()
        Me.pagResumo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpDadosOrdemProducao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosOrdemProducao.SuspendLayout()
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpApontamento.SuspendLayout()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlFiltro.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagIndicadores.SuspendLayout()
        CType(Me.chrIndicadorPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrIndicadorAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagResumo.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(919, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpDadosOrdemProducao)
        Me.pagLista.Controls.Add(Me.grpApontamento)
        Me.pagLista.Controls.Add(Me.grpControlFiltro)
        Me.pagLista.Controls.Add(Me.lblInformativo)
        Me.pagLista.Controls.Add(Me.tabDados)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(917, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Apontamento de Produção"
        '
        'grpDadosOrdemProducao
        '
        Me.grpDadosOrdemProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosOrdemProducao.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosOrdemProducao.Controls.Add(Me.lblOrdemProducaoLabel)
        Me.grpDadosOrdemProducao.Controls.Add(Me.lblOrdemProducaoValor)
        Me.grpDadosOrdemProducao.Controls.Add(Me.lblCodigoProdutoValor)
        Me.grpDadosOrdemProducao.Controls.Add(Me.lblTipoApontamentoLabel)
        Me.grpDadosOrdemProducao.Controls.Add(Me.lblCodigoProdutoLabel)
        Me.grpDadosOrdemProducao.Controls.Add(Me.lblQuantidadeRejeitoLabel)
        Me.grpDadosOrdemProducao.Controls.Add(Me.lblTipoApontamentoValor)
        Me.grpDadosOrdemProducao.Controls.Add(Me.lblQuantidadeRejeitoValor)
        Me.grpDadosOrdemProducao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosOrdemProducao.Location = New System.Drawing.Point(561, 54)
        Me.grpDadosOrdemProducao.Name = "grpDadosOrdemProducao"
        Me.grpDadosOrdemProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosOrdemProducao.Size = New System.Drawing.Size(348, 133)
        Me.grpDadosOrdemProducao.TabIndex = 2
        Me.grpDadosOrdemProducao.Text = "Dados da Ordem de Produção"
        Me.grpDadosOrdemProducao.VisualStyleManager = Me.vsmMain
        '
        'lblOrdemProducaoLabel
        '
        Me.lblOrdemProducaoLabel.BackColor = System.Drawing.Color.Moccasin
        Me.lblOrdemProducaoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdemProducaoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrdemProducaoLabel.Location = New System.Drawing.Point(9, 24)
        Me.lblOrdemProducaoLabel.Name = "lblOrdemProducaoLabel"
        Me.lblOrdemProducaoLabel.Size = New System.Drawing.Size(113, 20)
        Me.lblOrdemProducaoLabel.TabIndex = 0
        Me.lblOrdemProducaoLabel.Text = "Ordem de Produção:"
        Me.lblOrdemProducaoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrdemProducaoValor
        '
        Me.lblOrdemProducaoValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOrdemProducaoValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrdemProducaoValor.Location = New System.Drawing.Point(125, 24)
        Me.lblOrdemProducaoValor.Name = "lblOrdemProducaoValor"
        Me.lblOrdemProducaoValor.Size = New System.Drawing.Size(214, 20)
        Me.lblOrdemProducaoValor.TabIndex = 4
        Me.lblOrdemProducaoValor.Text = "-"
        Me.lblOrdemProducaoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigoProdutoValor
        '
        Me.lblCodigoProdutoValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCodigoProdutoValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoValor.Location = New System.Drawing.Point(125, 50)
        Me.lblCodigoProdutoValor.Name = "lblCodigoProdutoValor"
        Me.lblCodigoProdutoValor.Size = New System.Drawing.Size(214, 20)
        Me.lblCodigoProdutoValor.TabIndex = 5
        Me.lblCodigoProdutoValor.Text = "-"
        Me.lblCodigoProdutoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoApontamentoLabel
        '
        Me.lblTipoApontamentoLabel.BackColor = System.Drawing.Color.Moccasin
        Me.lblTipoApontamentoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoApontamentoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoApontamentoLabel.Location = New System.Drawing.Point(9, 76)
        Me.lblTipoApontamentoLabel.Name = "lblTipoApontamentoLabel"
        Me.lblTipoApontamentoLabel.Size = New System.Drawing.Size(113, 20)
        Me.lblTipoApontamentoLabel.TabIndex = 2
        Me.lblTipoApontamentoLabel.Text = "Tipo de Apontamento:"
        Me.lblTipoApontamentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigoProdutoLabel
        '
        Me.lblCodigoProdutoLabel.BackColor = System.Drawing.Color.Moccasin
        Me.lblCodigoProdutoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProdutoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoLabel.Location = New System.Drawing.Point(9, 50)
        Me.lblCodigoProdutoLabel.Name = "lblCodigoProdutoLabel"
        Me.lblCodigoProdutoLabel.Size = New System.Drawing.Size(113, 20)
        Me.lblCodigoProdutoLabel.TabIndex = 1
        Me.lblCodigoProdutoLabel.Text = "Código do Produto:"
        Me.lblCodigoProdutoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuantidadeRejeitoLabel
        '
        Me.lblQuantidadeRejeitoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeRejeitoLabel.BackColor = System.Drawing.Color.Moccasin
        Me.lblQuantidadeRejeitoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidadeRejeitoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeRejeitoLabel.Location = New System.Drawing.Point(9, 102)
        Me.lblQuantidadeRejeitoLabel.Name = "lblQuantidadeRejeitoLabel"
        Me.lblQuantidadeRejeitoLabel.Size = New System.Drawing.Size(113, 20)
        Me.lblQuantidadeRejeitoLabel.TabIndex = 3
        Me.lblQuantidadeRejeitoLabel.Text = "Quantidade Rejeito:"
        Me.lblQuantidadeRejeitoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoApontamentoValor
        '
        Me.lblTipoApontamentoValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTipoApontamentoValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoApontamentoValor.Location = New System.Drawing.Point(128, 76)
        Me.lblTipoApontamentoValor.Name = "lblTipoApontamentoValor"
        Me.lblTipoApontamentoValor.Size = New System.Drawing.Size(214, 20)
        Me.lblTipoApontamentoValor.TabIndex = 6
        Me.lblTipoApontamentoValor.Text = "-"
        Me.lblTipoApontamentoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuantidadeRejeitoValor
        '
        Me.lblQuantidadeRejeitoValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeRejeitoValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQuantidadeRejeitoValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeRejeitoValor.Location = New System.Drawing.Point(125, 102)
        Me.lblQuantidadeRejeitoValor.Name = "lblQuantidadeRejeitoValor"
        Me.lblQuantidadeRejeitoValor.Size = New System.Drawing.Size(214, 20)
        Me.lblQuantidadeRejeitoValor.TabIndex = 7
        Me.lblQuantidadeRejeitoValor.Text = "-"
        Me.lblQuantidadeRejeitoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'grpApontamento
        '
        Me.grpApontamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpApontamento.BackColor = System.Drawing.Color.Transparent
        Me.grpApontamento.Controls.Add(Me.cboEquipamento)
        Me.grpApontamento.Controls.Add(Me.cboFuncionario)
        Me.grpApontamento.Controls.Add(Me.cboOPOperacao)
        Me.grpApontamento.Controls.Add(Me.cboTipoApontamento)
        Me.grpApontamento.Controls.Add(Me.btnCadastrarMotivoParada)
        Me.grpApontamento.Controls.Add(Me.cboMotivoParada)
        Me.grpApontamento.Controls.Add(Me.lblMotivoParada)
        Me.grpApontamento.Controls.Add(Me.txtQuantidadeAbertura)
        Me.grpApontamento.Controls.Add(Me.lblQuantidadeAbertura)
        Me.grpApontamento.Controls.Add(Me.txtQuantidadeProduzida)
        Me.grpApontamento.Controls.Add(Me.txtQuantidadePlanejada)
        Me.grpApontamento.Controls.Add(Me.lblQuantidadeProduzida)
        Me.grpApontamento.Controls.Add(Me.lblQuantidadePlanejada)
        Me.grpApontamento.Controls.Add(Me.lblEquipamento)
        Me.grpApontamento.Controls.Add(Me.lblFuncionario)
        Me.grpApontamento.Controls.Add(Me.lblOPOperacao)
        Me.grpApontamento.Controls.Add(Me.lblTipoApontamento)
        Me.grpApontamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpApontamento.Location = New System.Drawing.Point(8, 3)
        Me.grpApontamento.Name = "grpApontamento"
        Me.grpApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpApontamento.Size = New System.Drawing.Size(544, 184)
        Me.grpApontamento.TabIndex = 0
        Me.grpApontamento.Text = "Apontamento"
        Me.grpApontamento.VisualStyleManager = Me.vsmMain
        '
        'cboEquipamento
        '
        Me.cboEquipamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEquipamento.Location = New System.Drawing.Point(9, 114)
        Me.cboEquipamento.Name = "cboEquipamento"
        Me.cboEquipamento.Size = New System.Drawing.Size(526, 20)
        Me.cboEquipamento.TabIndex = 7
        '
        'cboFuncionario
        '
        Me.cboFuncionario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFuncionario.Location = New System.Drawing.Point(9, 74)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(526, 20)
        Me.cboFuncionario.TabIndex = 5
        '
        'cboOPOperacao
        '
        Me.cboOPOperacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOPOperacao.Location = New System.Drawing.Point(216, 34)
        Me.cboOPOperacao.Name = "cboOPOperacao"
        Me.cboOPOperacao.Size = New System.Drawing.Size(319, 20)
        Me.cboOPOperacao.TabIndex = 3
        '
        'cboTipoApontamento
        '
        Me.cboTipoApontamento.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoApontamento.Name = "cboTipoApontamento"
        Me.cboTipoApontamento.Size = New System.Drawing.Size(201, 20)
        Me.cboTipoApontamento.TabIndex = 1
        '
        'btnCadastrarMotivoParada
        '
        Me.btnCadastrarMotivoParada.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMotivoParada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMotivoParada.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarMotivoParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMotivoParada.Location = New System.Drawing.Point(342, 138)
        Me.btnCadastrarMotivoParada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMotivoParada.Name = "btnCadastrarMotivoParada"
        Me.btnCadastrarMotivoParada.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMotivoParada.TabIndex = 18
        Me.btnCadastrarMotivoParada.TabStop = False
        Me.btnCadastrarMotivoParada.UseVisualStyleBackColor = True
        '
        'cboMotivoParada
        '
        Me.cboMotivoParada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMotivoParada.Location = New System.Drawing.Point(342, 154)
        Me.cboMotivoParada.Name = "cboMotivoParada"
        Me.cboMotivoParada.Size = New System.Drawing.Size(193, 20)
        Me.cboMotivoParada.TabIndex = 20
        '
        'lblMotivoParada
        '
        Me.lblMotivoParada.AutoSize = True
        Me.lblMotivoParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMotivoParada.Location = New System.Drawing.Point(358, 137)
        Me.lblMotivoParada.Name = "lblMotivoParada"
        Me.lblMotivoParada.Size = New System.Drawing.Size(93, 14)
        Me.lblMotivoParada.TabIndex = 19
        Me.lblMotivoParada.Text = "Motivo da Parada:"
        '
        'txtQuantidadeAbertura
        '
        Me.txtQuantidadeAbertura.DecimalDigits = 4
        Me.txtQuantidadeAbertura.Location = New System.Drawing.Point(120, 154)
        Me.txtQuantidadeAbertura.Name = "txtQuantidadeAbertura"
        Me.txtQuantidadeAbertura.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidadeAbertura.TabIndex = 15
        Me.txtQuantidadeAbertura.Text = "0,0000"
        Me.txtQuantidadeAbertura.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeAbertura
        '
        Me.lblQuantidadeAbertura.AutoSize = True
        Me.lblQuantidadeAbertura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeAbertura.Location = New System.Drawing.Point(117, 137)
        Me.lblQuantidadeAbertura.Name = "lblQuantidadeAbertura"
        Me.lblQuantidadeAbertura.Size = New System.Drawing.Size(81, 14)
        Me.lblQuantidadeAbertura.TabIndex = 14
        Me.lblQuantidadeAbertura.Text = "Qtde. Abertura:"
        '
        'txtQuantidadeProduzida
        '
        Me.txtQuantidadeProduzida.DecimalDigits = 4
        Me.txtQuantidadeProduzida.Location = New System.Drawing.Point(231, 154)
        Me.txtQuantidadeProduzida.Name = "txtQuantidadeProduzida"
        Me.txtQuantidadeProduzida.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidadeProduzida.TabIndex = 17
        Me.txtQuantidadeProduzida.Text = "0,0000"
        Me.txtQuantidadeProduzida.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtQuantidadePlanejada
        '
        Me.txtQuantidadePlanejada.DecimalDigits = 4
        Me.txtQuantidadePlanejada.Location = New System.Drawing.Point(9, 154)
        Me.txtQuantidadePlanejada.Name = "txtQuantidadePlanejada"
        Me.txtQuantidadePlanejada.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidadePlanejada.TabIndex = 13
        Me.txtQuantidadePlanejada.Text = "0,0000"
        Me.txtQuantidadePlanejada.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeProduzida
        '
        Me.lblQuantidadeProduzida.AutoSize = True
        Me.lblQuantidadeProduzida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeProduzida.Location = New System.Drawing.Point(228, 137)
        Me.lblQuantidadeProduzida.Name = "lblQuantidadeProduzida"
        Me.lblQuantidadeProduzida.Size = New System.Drawing.Size(87, 14)
        Me.lblQuantidadeProduzida.TabIndex = 16
        Me.lblQuantidadeProduzida.Text = "Qtde. Produzida:"
        '
        'lblQuantidadePlanejada
        '
        Me.lblQuantidadePlanejada.AutoSize = True
        Me.lblQuantidadePlanejada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadePlanejada.Location = New System.Drawing.Point(6, 137)
        Me.lblQuantidadePlanejada.Name = "lblQuantidadePlanejada"
        Me.lblQuantidadePlanejada.Size = New System.Drawing.Size(85, 14)
        Me.lblQuantidadePlanejada.TabIndex = 12
        Me.lblQuantidadePlanejada.Text = "Qtde. Planejada:"
        '
        'lblEquipamento
        '
        Me.lblEquipamento.AutoSize = True
        Me.lblEquipamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEquipamento.Location = New System.Drawing.Point(6, 97)
        Me.lblEquipamento.Name = "lblEquipamento"
        Me.lblEquipamento.Size = New System.Drawing.Size(71, 14)
        Me.lblEquipamento.TabIndex = 6
        Me.lblEquipamento.Text = "Equipamento:"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(6, 57)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionario.TabIndex = 4
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'lblOPOperacao
        '
        Me.lblOPOperacao.AutoSize = True
        Me.lblOPOperacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOPOperacao.Location = New System.Drawing.Point(213, 17)
        Me.lblOPOperacao.Name = "lblOPOperacao"
        Me.lblOPOperacao.Size = New System.Drawing.Size(81, 14)
        Me.lblOPOperacao.TabIndex = 2
        Me.lblOPOperacao.Text = "OP / Operação:"
        '
        'lblTipoApontamento
        '
        Me.lblTipoApontamento.AutoSize = True
        Me.lblTipoApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoApontamento.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoApontamento.Name = "lblTipoApontamento"
        Me.lblTipoApontamento.Size = New System.Drawing.Size(111, 14)
        Me.lblTipoApontamento.TabIndex = 0
        Me.lblTipoApontamento.Text = "Tipo de Apontamento:"
        '
        'grpControlFiltro
        '
        Me.grpControlFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControlFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpControlFiltro.Controls.Add(Me.btnNovo)
        Me.grpControlFiltro.Controls.Add(Me.btnSair)
        Me.grpControlFiltro.Location = New System.Drawing.Point(8, 483)
        Me.grpControlFiltro.Name = "grpControlFiltro"
        Me.grpControlFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlFiltro.Size = New System.Drawing.Size(901, 51)
        Me.grpControlFiltro.TabIndex = 4
        Me.grpControlFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(704, 18)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(801, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblInformativo
        '
        Me.lblInformativo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInformativo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblInformativo.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformativo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInformativo.Location = New System.Drawing.Point(561, 10)
        Me.lblInformativo.Name = "lblInformativo"
        Me.lblInformativo.Size = New System.Drawing.Size(348, 37)
        Me.lblInformativo.TabIndex = 1
        Me.lblInformativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 193)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(901, 287)
        Me.tabDados.TabIndex = 5
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagIndicadores, Me.pagResumo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagIndicadores
        '
        Me.pagIndicadores.Controls.Add(Me.chrIndicadorPeriodo)
        Me.pagIndicadores.Controls.Add(Me.chrIndicadorAtual)
        Me.pagIndicadores.Key = "pagIndicadores"
        Me.pagIndicadores.Location = New System.Drawing.Point(1, 22)
        Me.pagIndicadores.Name = "pagIndicadores"
        Me.pagIndicadores.Size = New System.Drawing.Size(899, 264)
        Me.pagIndicadores.TabStop = True
        Me.pagIndicadores.Text = "Indicadores"
        '
        'chrIndicadorPeriodo
        '
        Me.chrIndicadorPeriodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrIndicadorPeriodo.BorderLineColor = System.Drawing.Color.Black
        Me.chrIndicadorPeriodo.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrIndicadorPeriodo.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.Name = "Default"
        Me.chrIndicadorPeriodo.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Default"
        Me.chrIndicadorPeriodo.Legends.Add(Legend1)
        Me.chrIndicadorPeriodo.Location = New System.Drawing.Point(549, 8)
        Me.chrIndicadorPeriodo.Name = "chrIndicadorPeriodo"
        Me.chrIndicadorPeriodo.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.ChartType = "Pie"
        Series1.CustomAttributes = "LabelStyle=Outside"
        Series1.Font = New System.Drawing.Font("Arial", 8.25!)
        Series1.Name = "Series1"
        Series1.ShadowOffset = 1
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrIndicadorPeriodo.Series.Add(Series1)
        Me.chrIndicadorPeriodo.Size = New System.Drawing.Size(342, 247)
        Me.chrIndicadorPeriodo.TabIndex = 4
        Me.chrIndicadorPeriodo.Text = "Chart2"
        Title1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Title1"
        Title1.Text = "Histórico de Apontamento (Período de um ano)"
        Me.chrIndicadorPeriodo.Titles.Add(Title1)
        Me.chrIndicadorPeriodo.UI.Toolbar.Enabled = True
        '
        'chrIndicadorAtual
        '
        Me.chrIndicadorAtual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chrIndicadorAtual.BorderLineColor = System.Drawing.Color.Black
        Me.chrIndicadorAtual.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrIndicadorAtual.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea2.BorderColor = System.Drawing.Color.Empty
        ChartArea2.Name = "Default"
        Me.chrIndicadorAtual.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Default"
        Me.chrIndicadorAtual.Legends.Add(Legend2)
        Me.chrIndicadorAtual.Location = New System.Drawing.Point(8, 8)
        Me.chrIndicadorAtual.Name = "chrIndicadorAtual"
        Me.chrIndicadorAtual.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series2.ChartType = "Pie"
        Series2.CustomAttributes = "LabelStyle=Outside"
        Series2.Font = New System.Drawing.Font("Arial", 8.25!)
        Series2.Name = "Series1"
        Series2.ShadowOffset = 1
        Series2.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series2.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrIndicadorAtual.Series.Add(Series2)
        Me.chrIndicadorAtual.Size = New System.Drawing.Size(535, 247)
        Me.chrIndicadorAtual.TabIndex = 3
        Me.chrIndicadorAtual.Text = "Chart2"
        Title2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Title2.Name = "Title1"
        Title2.Text = "Tempo Previsto x Realizado"
        Me.chrIndicadorAtual.Titles.Add(Title2)
        Me.chrIndicadorAtual.UI.Toolbar.Enabled = True
        '
        'pagResumo
        '
        Me.pagResumo.Controls.Add(Me.grdApontamento)
        Me.pagResumo.Key = "pagResumo"
        Me.pagResumo.Location = New System.Drawing.Point(1, 22)
        Me.pagResumo.Name = "pagResumo"
        Me.pagResumo.Size = New System.Drawing.Size(899, 264)
        Me.pagResumo.TabStop = True
        Me.pagResumo.Text = "Resumo da Ordem de Produção"
        '
        'grdApontamento
        '
        Me.grdApontamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdApontamento.ColumnAutoResize = True
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.FrozenColumns = 3
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.Location = New System.Drawing.Point(8, 9)
        Me.grdApontamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(883, 246)
        Me.grdApontamento.TabIndex = 3
        Me.grdApontamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 500
        '
        'usrPrdApontamentoAutoGestao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrPrdApontamentoAutoGestao"
        Me.Size = New System.Drawing.Size(919, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpDadosOrdemProducao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosOrdemProducao.ResumeLayout(False)
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpApontamento.ResumeLayout(False)
        Me.grpApontamento.PerformLayout()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlFiltro.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagIndicadores.ResumeLayout(False)
        CType(Me.chrIndicadorPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrIndicadorAtual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagResumo.ResumeLayout(False)
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControlFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpApontamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblOPOperacao As System.Windows.Forms.Label
    Friend WithEvents lblEquipamento As System.Windows.Forms.Label
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProdutoValor As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProdutoLabel As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents lblOrdemProducaoValor As System.Windows.Forms.Label
    Friend WithEvents lblOrdemProducaoLabel As System.Windows.Forms.Label
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblQuantidadeProduzida As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadePlanejada As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRejeitoValor As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRejeitoLabel As System.Windows.Forms.Label
    Friend WithEvents lblTipoApontamentoValor As System.Windows.Forms.Label
    Friend WithEvents lblTipoApontamentoLabel As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeProduzida As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadePlanejada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpDadosOrdemProducao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidadeAbertura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeAbertura As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarMotivoParada As System.Windows.Forms.Button
    Friend WithEvents cboMotivoParada As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMotivoParada As System.Windows.Forms.Label
    Friend WithEvents lblInformativo As System.Windows.Forms.Label
    Friend WithEvents lblTipoApontamento As System.Windows.Forms.Label
    Friend WithEvents cboTipoApontamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboEquipamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboOPOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagIndicadores As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagResumo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents chrIndicadorPeriodo As Dundas.Charting.WinControl.Chart
    Friend WithEvents chrIndicadorAtual As Dundas.Charting.WinControl.Chart

End Class
